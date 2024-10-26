Imports System.IO
Imports System.Net.Http
Imports System.Reflection.Metadata
Imports MySql.Data.MySqlClient
Imports Mysqlx.Resultset

Public Class ProjectDetailsForm

    Dim clientId As Integer
    Dim client As Client
    Dim _HomeForm As Home

    Public Sub New(id As Integer, _home As Home)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.clientId = id
        Me._HomeForm = _home
        LoadClient(clientId)

        tbName.Text = client.Name
        tbAddress.Text = client.Address
        tbNumber.Text = client.Contact
        nudOrders.Value = client.Quantity
        nudPayment.Value = client.Payment
        nudPrice.Value = client.Price


    End Sub


    Public Sub LoadClient(id As Integer)
        Dim query As String = "SELECT * FROM client WHERE client_id = @client_id"
        Dim parameter As New Dictionary(Of String, Object) From {
            {"@client_id", id}
            }
        Dim dataTable = MySQLModule.ExecuteQuery(query, parameter)
        Dim row = dataTable.Rows(0)

        Dim name As String = Convert.ToString(row("name"))
        Dim address As String = Convert.ToString(row("address"))
        Dim contact As String = Convert.ToString(row("contact"))
        Dim status As String = Convert.ToBoolean(row("status"))
        Dim price As String = Convert.ToDecimal(row("price"))
        Dim payment As String = Convert.ToDecimal(row("payment"))
        Dim quantity As String = Convert.ToDecimal(row("quantity"))


        client = New Client(name, address, contact, status, price, payment, quantity)
        LoadOrders(clientId)


    End Sub

    Private Sub LoadOrders(client_id As Integer)
        Dim orderList = GetOrdersFromDatabase(client_id)
        Dim pendingOrders = orderList.Where(Function(o) o.Status = "Pending").ToList()
        Dim finishedOrders = orderList.Where(Function(o) o.Status = "Finished").ToList()
        Dim claimedOrders = orderList.Where(Function(o) o.Status = "Claimed").ToList()

        Dim maxRow = Math.Max(Math.Max(pendingOrders.Count, finishedOrders.Count), claimedOrders.Count)

        For i As Integer = 0 To maxRow

            ' Get the order names if available, otherwise use an empty string
            Dim pendingOrder = If(i < pendingOrders.Count, pendingOrders(i), Nothing)
            Dim finishedOrder = If(i < finishedOrders.Count, finishedOrders(i), Nothing)
            Dim claimedOrder = If(i < claimedOrders.Count, claimedOrders(i), Nothing)

            ' Add a new row to the DataGridView
            Dim rowIndex = dgSortOrders.Rows.Add(False,
                                             If(pendingOrder IsNot Nothing, pendingOrder.OrderName, ""),
                                             False,
                                             If(finishedOrder IsNot Nothing, finishedOrder.OrderName, ""),
                                             If(claimedOrder IsNot Nothing, claimedOrder.OrderName, ""))

            ' Tag each row with the corresponding order object (if available)
            If pendingOrder IsNot Nothing Then dgSortOrders.Rows(rowIndex).Cells(1).Tag = pendingOrder
            If finishedOrder IsNot Nothing Then dgSortOrders.Rows(rowIndex).Cells(3).Tag = finishedOrder
            If claimedOrder IsNot Nothing Then dgSortOrders.Rows(rowIndex).Cells(4).Tag = claimedOrder
            'dgSortOrders.Rows.Add(Nothing, "", Nothing, "", "")
        Next
    End Sub
    Private Sub dgSortOrders_MouseDown(sender As Object, e As MouseEventArgs) Handles dgSortOrders.MouseDown
        Dim hit As DataGridView.HitTestInfo = dgSortOrders.HitTest(e.X, e.Y)

        If hit.RowIndex >= 0 AndAlso hit.ColumnIndex >= 0 Then
            ' Get the order object stored in the tag
            Dim order = TryCast(dgSortOrders.Rows(hit.RowIndex).Cells(hit.ColumnIndex).Tag, Order)

            ' Only start drag if the order is not Nothing
            If order IsNot Nothing Then
                dgSortOrders.DoDragDrop(order, DragDropEffects.Move)
            End If
        End If
    End Sub

    Private Sub dgSortOrders_DragEnter(sender As Object, e As DragEventArgs) Handles dgSortOrders.DragEnter
        ' Allow the drop if it's a valid move operation
        If e.Data.GetDataPresent(GetType(Order)) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub dgSortOrders_DragDrop(sender As Object, e As DragEventArgs) Handles dgSortOrders.DragDrop

        Dim droppedOrder As Order = CType(e.Data.GetData(GetType(Order)), Order)
        Dim clientPoint As Point = dgSortOrders.PointToClient(New Point(e.X, e.Y))

        Dim hit As DataGridView.HitTestInfo = dgSortOrders.HitTest(clientPoint.X, clientPoint.Y)
        If hit.RowIndex >= 0 AndAlso hit.ColumnIndex > 0 AndAlso hit.ColumnIndex <> -1 AndAlso
           (hit.ColumnIndex = 1 Or hit.ColumnIndex = 3 Or hit.ColumnIndex = 4) Then

            Dim Status = ""
            Dim order_id = droppedOrder.OrderId

            Select Case hit.ColumnIndex
                Case 1
                    Status = "Pending"
                Case 3
                    Status = "Finished"
                Case 4
                    Status = "Claimed"
            End Select

            UpdateOrderStatus(order_id, Status)
            dgSortOrders.Rows.Clear()
            LoadOrders(clientId)
        End If


    End Sub


    Private Sub dgSortOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSortOrders.CellContentClick

        Dim columnIndex = e.ColumnIndex
        If columnIndex = 0 Or columnIndex = 2 AndAlso e.RowIndex >= 0 Then

            Dim order As Order = CType(dgSortOrders.Rows(e.RowIndex).Cells(columnIndex + 1).Tag, Order)

            If order IsNot Nothing Then
                Dim status As String = ""
                Dim order_id = order.OrderId
                Select Case order.Status
                    Case "Pending"
                        status = "Finished"
                    Case "Finished"
                        status = "Claimed"
                End Select
                UpdateOrderStatus(order_id, status)

                dgSortOrders.Rows.Clear()
                LoadOrders(clientId)
            End If
        End If
    End Sub

    Private Sub UpdateOrderStatus(order_id As Integer, status As String)
        Dim query = "UPDATE client_order SET status = @status WHERE order_id = @order_id"
        Dim parameter As New Dictionary(Of String, Object) From {
        {"@status", status},
        {"@order_id", order_id}
        }

        MySQLModule.ExecuteNonQuery(query, parameter)
    End Sub

    Private Shared Function GetOrdersFromDatabase(client_id As Integer) As List(Of Order)
        Dim OrderList As New List(Of Order)
        Dim query As String = "SELECT * FROM client_order WHERE client_id = @client_id"
        Dim parameter As New Dictionary(Of String, Object) From {
        {"client_id", client_id}
        }

        Dim datatable = MySQLModule.ExecuteQuery(query, parameter)



        For Each row As DataRow In datatable.Rows
            Dim OrderId As Integer = row.Field(Of Integer)("order_id")
            Dim OrderName As String = row.Field(Of String)("order_name")
            Dim OrderType As String = row.Field(Of String)("type")
            Dim description As String = row.Field(Of String)("description")
            Dim price As Decimal = row.Field(Of Decimal)("price")
            Dim done As Boolean = row.Field(Of Boolean)("done")

            Dim imageByte As Byte() = row.Field(Of Byte())("image")
            Dim image As Image = ByteArrayToImage(imageByte)
            Dim OrderDate As DateTime = row.Field(Of DateTime)("date")
            Dim sizes As List(Of Size) = GetSize(row.Field(Of Integer)("order_id"))
            Dim status As String = row.Field(Of String)("status")

            OrderList.Add(New Order(OrderId, OrderName, OrderType, description, price, done, image, OrderDate, sizes, status))
        Next
        Return OrderList
    End Function

    Private Shared Function ByteArrayToImage(bytes As Byte()) As Image
        Using ms As New MemoryStream(bytes)
            Return Image.FromStream(ms)
        End Using
    End Function

    Private Shared Function GetSize(order_id As Integer) As List(Of Size)
        Dim sizes As New List(Of Size)

        Dim query = "SELECT * FROM size_values WHERE order_id = @order_id"
        Dim parameter As New Dictionary(Of String, Object) From {
            {"order_id", order_id}
        }

        Dim datatable = MySQLModule.ExecuteQuery(query, parameter)
        For Each row As DataRow In datatable.Rows
            Dim bodyPart = GetBodyPart(row.Field(Of Integer)("type_id"))
            Dim value = row.Field(Of Decimal)("size_value")
            Dim unit = row.Field(Of String)("size_unit")
            Dim garment = GetGarmentType(row.Field(Of Integer)("garment_id"))

            sizes.Add(New Size(bodyPart, value, unit, garment))
        Next

        Return sizes
    End Function

    Private Shared Function GetBodyPart(type_id As Integer) As String
        Dim query = "SELECT (types) FROM size_types WHERE type_id = @type_id"
        Dim parameter As New Dictionary(Of String, Object) From {
        {"type_id", type_id}
        }
        Dim bodypart = MySQLModule.ExecuteScalar(query, parameter)
        If bodypart IsNot Nothing Then
            Return bodypart.ToString
        Else
            Throw New Exception("type_id doesn't exist brooooo")
        End If
    End Function

    Private Shared Function GetGarmentType(garment_id As Integer) As String
        Dim query = "SELECT (garment_type) FROM garment_types WHERE garment_id = @garment_id"
        Dim parameter As New Dictionary(Of String, Object) From {
        {"garment_id", garment_id}
        }

        Dim result = MySQLModule.ExecuteScalar(query, parameter).ToString

        If result IsNot Nothing Then
            Return result
        Else
            Throw New Exception("garment_id doesn't exist ni whattt")
        End If
    End Function

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        Dim AddNewOrderForm As New AddNewOrder(clientId, Me)
        Me.Hide()
        AddNewOrderForm.Show()
    End Sub


    Private Sub ProjectDetailsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _HomeForm.Show()
    End Sub

    Private Sub ProjectDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class