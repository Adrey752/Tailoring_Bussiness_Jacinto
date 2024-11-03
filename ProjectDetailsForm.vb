Imports System.IO
Imports System.Net.Http
Imports System.Reflection.Metadata
Imports MySql.Data.MySqlClient
Imports Mysqlx.Resultset

Public Class ProjectDetailsForm

    Dim clientId As Integer
    Dim client As Client
    Dim _HomeForm As Home
    Dim balance

    Public Sub New(id As Integer, _home As Home)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.clientId = id
        Me._HomeForm = _home
        LoadClient(clientId)

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

        Dim price As String = Convert.ToDecimal(row("price"))
        Dim payment As String = Convert.ToDecimal(row("payment"))
        Dim quantity As String = Convert.ToDecimal(row("quantity"))

        client = New Client(name, address, contact, price, payment, quantity)
        client.Orders = GetClientOrdersFromDatabase(clientId)

        tbName.Text = client.Name
        tbAddress.Text = client.Address
        tbNumber.Text = client.Contact
        nudOrders.Value = client.Quantity
        lblDue.Text = "₱" & client.Price.ToString("N2")
        lblPaid.Text = "₱ " & client.Payment
        Dim balance = client.Price - client.Payment
        lblBalance.Text = "₱ " & balance.ToString("N2")

        LoadOrders(clientId)
        LoadPaymentHistory()


    End Sub

    Private Sub LoadOrders(client_id As Integer)
        dgSortOrders.Rows.Clear()
        Dim orderList = GetClientOrdersFromDatabase(client_id)
        Dim pendingOrders = orderList.Where(Function(o) o.Status = "Pending").ToList()
        Dim finishedOrders = orderList.Where(Function(o) o.Status = "Finished").ToList()
        Dim claimedOrders = orderList.Where(Function(o) o.Status = "Claimed").ToList()

        Dim maxRow = Math.Max(Math.Max(pendingOrders.Count, finishedOrders.Count), claimedOrders.Count)

        For i As Integer = 0 To maxRow - 1 ' Looping from 0 to maxRow - 1

            ' Get the order names if available, otherwise use an empty string
            Dim pendingOrder = If(i < pendingOrders.Count, pendingOrders(i), Nothing)
            Dim finishedOrder = If(i < finishedOrders.Count, finishedOrders(i), Nothing)
            Dim claimedOrder = If(i < claimedOrders.Count, claimedOrders(i), Nothing)

            ' Add a new row to the DataGridView
            Dim rowIndex = dgSortOrders.Rows.Add(False,
                                             If(pendingOrder IsNot Nothing, If(pendingOrder.Payment_id <> -1, pendingOrder.OrderName & "  - Paid", pendingOrder.OrderName), ""),
                                             False,
                                             If(finishedOrder IsNot Nothing, If(finishedOrder.Payment_id <> -1, finishedOrder.OrderName & "  - Paid", finishedOrder.OrderName), ""),
                                             If(claimedOrder IsNot Nothing, If(claimedOrder.Payment_id <> -1, claimedOrder.OrderName & "  - Paid", claimedOrder.OrderName), ""))

            ' Tag each row with the corresponding order object (if available)
            If pendingOrder IsNot Nothing Then
                dgSortOrders.Rows(rowIndex).Cells(1).Tag = pendingOrder
                If pendingOrder.Payment_id <> -1 Then ' Check if pendingOrder is not Nothing before accessing Paid
                    MarkOrderAsPaid(dgSortOrders.Rows(rowIndex).Cells(1))
                End If
            End If

            If finishedOrder IsNot Nothing Then
                dgSortOrders.Rows(rowIndex).Cells(3).Tag = finishedOrder
                If finishedOrder.Payment_id <> -1 Then ' Check if finishedOrder is not Nothing before accessing Paid
                    MarkOrderAsPaid(dgSortOrders.Rows(rowIndex).Cells(3))
                End If
            End If

            If claimedOrder IsNot Nothing Then
                dgSortOrders.Rows(rowIndex).Cells(4).Tag = claimedOrder
                If claimedOrder.Payment_id <> -1 Then ' Check if claimedOrder is not Nothing before accessing Paid
                    MarkOrderAsPaid(dgSortOrders.Rows(rowIndex).Cells(4))
                End If
            End If
        Next
    End Sub

    Private Sub dgSortOrders_MouseDown(sender As Object, e As MouseEventArgs) Handles dgSortOrders.MouseDown
        Dim hit = dgSortOrders.HitTest(e.X, e.Y)

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

        Dim droppedOrder = CType(e.Data.GetData(GetType(Order)), Order)
        Dim clientPoint = dgSortOrders.PointToClient(New Point(e.X, e.Y))

        Dim hit = dgSortOrders.HitTest(clientPoint.X, clientPoint.Y)
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

            LoadOrders(clientId)
        End If


    End Sub


    Private Sub dgSortOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSortOrders.CellContentClick

        Dim columnIndex = e.ColumnIndex
        If columnIndex = 0 Or columnIndex = 2 AndAlso e.RowIndex >= 0 Then

            Dim order = CType(dgSortOrders.Rows(e.RowIndex).Cells(columnIndex + 1).Tag, Order)

            If order IsNot Nothing Then
                Dim status = ""
                Dim order_id = order.OrderId
                Select Case order.Status
                    Case "Pending"
                        status = "Finished"
                    Case "Finished"
                        status = "Claimed"
                End Select
                UpdateOrderStatus(order_id, status)


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

    Private Sub UpdateOrderPaymentStatus(order_id As Integer)
        Dim query = "UPDATE client_order SET paymentStatus = @paymentStatus WHERE order_id = @order_id"
        Dim parameter As New Dictionary(Of String, Object) From {
            {"@paymentStatus", True},
            {"@order_id", order_id}
        }
        MySQLModule.ExecuteNonQuery(query, parameter)
    End Sub



    Private Shared Function GetClientOrdersFromDatabase(client_id As Integer) As List(Of Order)
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

            Dim imageByte As Byte() = row.Field(Of Byte())("image")
            Dim image As Image = ByteArrayToImage(imageByte)
            Dim OrderDate As DateTime = row.Field(Of DateTime)("date")
            Dim sizes As List(Of Size) = GetSize(row.Field(Of Integer)("order_id"))
            Dim status As String = row.Field(Of String)("status")
            Dim payment_id As Integer = If(row.IsNull("payment_id"), -1, row.Field(Of Integer)("payment_id"))

            OrderList.Add(New Order(OrderId, OrderName, OrderType, description, price, image, OrderDate, sizes, status, payment_id))
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
            Throw New Exception("garment_id doesn't exist ")
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

    Private Sub btnAddrOrder_Click(sender As Object, e As EventArgs) Handles btnMakePayment.Click
        Dim paymentDialog As New PaymentDialog(client)
        paymentDialog.ShowDialog()
        If paymentDialog.DialogResult = DialogResult.OK Then
            Dim PaymentDate As DateTime = paymentDialog.PaymentDate
            Dim PaymentAmount As Decimal = paymentDialog.PaymentAmount
            Dim PaidOrders As List(Of Order) = paymentDialog.CheckedOrders
            Dim paymentDetails As New PaymentDetails(PaymentDate, PaymentAmount, PaidOrders)

            client.PaymenHistory.Add(paymentDetails)
            SavePaymentDetails(clientId, paymentDetails)
            paymentDialog.Close()
            LoadClient(clientId)
        End If

    End Sub

    Private Sub SavePaymentDetails(client_id As Integer, paymentDetails As PaymentDetails)
        Dim updatedPaymentAmount = paymentDetails.PaymentAmount + client.Payment
        UpdateClientPaymentInDB(client_id, updatedPaymentAmount)
        Dim payment_id = InsertPaymentToDb(client_id, paymentDetails)

        For Each order As Order In paymentDetails.OrdersPaid
            UpdateOrderPaymentStatus(payment_id, order)
        Next

    End Sub

    Private Function InsertPaymentToDb(client_id As Integer, paymentDetails As PaymentDetails) As Integer
        Dim parameter = "INSERT INTO payment_log (payment_date, payment_amount, client_id) VALUES (@payment_date, @payment_amount, @client_id); SELECT LAST_INSERT_ID();"
        Dim query As New Dictionary(Of String, Object) From {
            {"@payment_date", paymentDetails.PaymentDate},
            {"@payment_amount", paymentDetails.PaymentAmount},
            {"@client_id", clientId}
        }
        Dim payment_id = Convert.ToInt32(MySQLModule.ExecuteScalar(parameter, query))
        Return payment_id
    End Function

    Private Sub UpdateClientPaymentInDB(client_id As Integer, payment As Decimal)
        Dim query = "UPDATE client SET payment = @payment WHERE client_id = @client_id"
        Dim parameter As New Dictionary(Of String, Object) From {
            {"@payment", payment},
            {"@client_id", clientId}
        }
        MySQLModule.ExecuteNonQuery(query, parameter)
    End Sub

    Private Sub UpdateOrderPaymentStatus(payment_id As Integer, order As Order)
        Dim query = "UPDATE client_order SET payment_id = @payment_id WHERE order_id = @order_id"
        Dim parameter As New Dictionary(Of String, Object) From {
            {"payment_id", payment_id},
            {"order_id", order.OrderId}
        }
        MySQLModule.ExecuteNonQuery(query, parameter)
    End Sub

    Private Sub LoadPaymentHistory()
        dgPaymentHistory.Rows.Clear()
        Dim parameter = "SELECT * FROM payment_log WHERE client_id = @client_id"
        Dim query As New Dictionary(Of String, Object) From {
            {"@client_id", clientId}
        }
        Dim datatable As DataTable = MySQLModule.ExecuteQuery(parameter, query)
        For Each row As DataRow In datatable.Rows
            Dim paymentDate = row.Field(Of DateTime)("payment_date")
            Dim paymentAmount = "₱ " & row.Field(Of Decimal)("payment_amount").ToString("N2")
            Dim payment_id As Integer = If(row.IsNull("payment_id"), -1, row.Field(Of Integer)("payment_id"))
            Dim ordersPaid As String = ListOfOrderNames(GetPaidOrdersFromDatabase(payment_id))
            dgPaymentHistory.Rows.Add(paymentDate, paymentAmount, ordersPaid)

        Next
    End Sub

    Private Shared Function GetPaidOrdersFromDatabase(payment_id As Integer) As List(Of Order)
        Dim OrderList As New List(Of Order)
        Dim query As String = "SELECT * FROM client_order WHERE payment_id = @payment_id"
        Dim parameter As New Dictionary(Of String, Object) From {
        {"payment_id", payment_id}
        }

        Dim datatable = MySQLModule.ExecuteQuery(query, parameter)



        For Each row As DataRow In datatable.Rows
            Dim OrderId As Integer = row.Field(Of Integer)("order_id")
            Dim OrderName As String = row.Field(Of String)("order_name")
            Dim OrderType As String = row.Field(Of String)("type")
            Dim description As String = row.Field(Of String)("description")
            Dim price As Decimal = row.Field(Of Decimal)("price")

            Dim imageByte As Byte() = row.Field(Of Byte())("image")
            Dim image As Image = ByteArrayToImage(imageByte)
            Dim OrderDate As DateTime = row.Field(Of DateTime)("date")
            Dim sizes As List(Of Size) = GetSize(row.Field(Of Integer)("order_id"))
            Dim status As String = row.Field(Of String)("status")
            Dim paymentId As Integer = row.Field(Of Integer)("payment_id")

            OrderList.Add(New Order(OrderId, OrderName, OrderType, description, price, image, OrderDate, sizes, status, payment_id))
        Next
        Return OrderList
    End Function
    Private Sub MarkOrderAsPaid(orderCell As DataGridViewCell)
        ' Check if the orderCell is valid and not already marked
        If orderCell IsNot Nothing AndAlso orderCell.Style.BackColor <> Color.Green Then
            orderCell.Style.BackColor = Color.Green ' Change the background color to green
            orderCell.Style.ForeColor = Color.White ' Optionally change text color to white for contrast
        End If
    End Sub


    Private Function ListOfOrderNames(listOfOrder As List(Of Order)) As String
        Dim orderNames = ""
        For Each order As Order In listOfOrder
            orderNames &= order.OrderName & ", "
        Next
        Return orderNames
    End Function

    Private Sub ProjectDetailsForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub ProjectDetailsForm_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub LblName_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblAddress_Click(sender As Object, e As EventArgs) Handles lblAddress.Click

    End Sub

    Private Sub lblPayment_Click(sender As Object, e As EventArgs) Handles lblPayment.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ProjectDetailsForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class