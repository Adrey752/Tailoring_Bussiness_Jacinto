Imports MySql.Data.MySqlClient
Imports Mysqlx.Resultset

Public Class ProjectDetailsForm

    Dim id As Integer
    Dim client As Client

    Public Sub New(id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.id = id
        LoadClient(id)

        tbName.Text = client.Name
        tbAddress.Text = client.Address
        tbNumber.Text = client.Contact
        nudOrders.Value = client.Quantity
        nudPayment.Value = client.Payment
        nudPrice.Value = client.Price


    End Sub
    Private Sub ProjectDetailsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadClient(id As Integer)
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
    End Sub

    Private Shared Function GetOrdersFromDatabase(client_id As Integer) As List(Of Order)
        Dim OrderList As New List(Of Order)
        Dim query As String = "SELECT * FROM client_order WHERE client_id = @client_id"
        Dim parameter As New Dictionary(Of String, Object) From {
        {"client_id", client_id}
        }

        Dim datatable = MySQLModule.ExecuteQuery(query, parameter)



        For Each row As DataRow In datatable.Rows
            Dim OrderName As String = row.Field(Of String)("order_name")
            Dim OrderType As String = row.Field(Of String)("type")
            Dim description As String = row.Field(Of String)("description")
            Dim price As Decimal = row.Field(Of Decimal)("price")
            Dim done As Boolean = row.Field(Of Boolean)("done")
            Dim sizes As List(Of Size) = GetSize(row.Field(Of Integer)("order_id"))

            OrderList.Add(New Order(OrderName, OrderType, description, price, done, sizes))
        Next

        Return OrderList
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
        {"garment_type", garment_id}
        }

        Dim result = MySQLModule.ExecuteScalar(query, parameter).ToString

        If result IsNot Nothing Then
            Return result
        Else
            Throw New Exception("garment_id doesn't exist ni whattt")
        End If
    End Function
End Class