Imports Mysqlx.XDevAPI

Public Class AddOrder
    Dim client As Client
    Dim order As Order
    Dim _orderForm As AddClientForm

    Public Sub New(client As Client, orderForm As AddClientForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.client = client
        Me.order = New Order("", "", "", "", 0)
        Me._orderForm = orderForm
        LoadMeasurementsType()

    End Sub

    Private Sub AddOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

        'lblAddMoreOrders.ForeColor = Color.FromArgb(163, 120, 81)
        'Me.BackColor = Color.FromArgb(9, 11, 23)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tbOrderName.Focus() ' Set focus to the TextBox
        Timer1.Stop() ' Stop the timer after setting focus
    End Sub

    Private Sub LoadMeasurementsType()
        Dim query = "SELECT types FROM size_types"
        Dim dataTable = MySQLModule.ExecuteQuery(query, New Dictionary(Of String, Object))

        For Each row As DataRow In dataTable.Rows
            sbMType.Items.Add(row("types").ToString())
        Next
    End Sub

    Private Sub LoadGarmentTypes()
        Dim query As String = "SELECT garment_type FROM garment_types"
        Dim parameter As New Dictionary(Of String, Object)
        Dim datatable As DataTable = MySQLModule.ExecuteQuery(query, parameter)

        For Each row As DataRow In datatable.Rows
            cbGarment.Items.Add(row("garment_type").ToString())
        Next

    End Sub



    Private Sub btnOrderSave_Click(sender As Object, e As EventArgs) Handles btnOrderSave.Click
        Dim orderName = tbOrderName.Text
        Dim serviceType = cbStype.Text
        Dim description = rbDescription.Text
        Dim price = nudPrice.Value
        order.OrderName = orderName
        order.Type = serviceType
        order.Description = description
        order.Price = price
        client.addOrder(order)

        _orderForm.AddProjectPanel(orderName, order.Type, order.Description, order)
        Me.Close()
        _orderForm.Show()

    End Sub

    Private Sub addMeasurement_Click(sender As Object, e As EventArgs) Handles btnaddMeasurement.Click
        Dim measurementType = sbMType.Text
        Dim value = nudValue.Value
        Dim unit = cbUnit.Text
        Dim garment = cbGarment.Text
        Dim measurement = New Size(measurementType, value, unit, garment)

        order.AddSize(measurement)

        dgMeasurements.Rows.Add(measurementType, (value & unit), garment)
    End Sub


End Class