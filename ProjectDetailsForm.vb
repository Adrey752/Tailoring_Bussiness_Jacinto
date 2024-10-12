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
        tbStatus.Text = client.Status
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


End Class