Imports Mysqlx.XDevAPI

Public Class AddOrder
    Dim client As Client
    Dim order As Order
    Dim _orderForm As orderForm

    Public Sub New(client As Client, orderForm As orderForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.client = client
        Me.order = New Order("", "", "", "", 1)
        Me._orderForm = orderForm
        LoadMeasurementsType()

    End Sub

    Private Sub AddOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblAddMoreOrders.ForeColor = Color.FromArgb(163, 120, 81)
        Me.BackColor = Color.FromArgb(9, 11, 23)
    End Sub


    Private Sub LoadMeasurementsType()
        Dim query = "SELECT types FROM size_types"
        Dim dataTable = MySQLModule.ExecuteQuery(query, New Dictionary(Of String, Object))

        For Each row As DataRow In dataTable.Rows
            sbMType.Items.Add(row("types").ToString())
        Next
    End Sub



    Private Sub btnOrderSave_Click(sender As Object, e As EventArgs) Handles btnOrderSave.Click
        Dim orderName = tbOrderName.Text
        Dim serviceType = cbStype.Text
        Dim description = rbDescription.Text
        Dim price = nudPrice.Value
        Dim garmentType = cbGarment.Text
        order.OrderName = orderName
        order.Type = serviceType
        order.Description = description
        order.Price = price
        order.GarmentType = garmentType

        _orderForm.AddProjectPanel(orderName, order.Type, order.GarmentType, order.Description)
        Me.Close()

    End Sub

    Private Sub addMeasurement_Click(sender As Object, e As EventArgs) Handles btnaddMeasurement.Click
        Dim measurementType = sbMType.Text
        Dim value = nudValue.Value
        Dim unit = cbUnit.Text
        Dim measurement = New DressMeasurement(measurementType, value, unit)

        order.AddSize(measurement)

        dgMeasurements.Rows.Add(measurementType, value, unit)
    End Sub


    Private Sub lblAdd_Click(sender As Object, e As EventArgs) Handles lblAddMoreOrders.Click

    End Sub

    Private Sub nudValue_ValueChanged(sender As Object, e As EventArgs) Handles nudValue.ValueChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBoxLogo.Click

    End Sub

    Private Sub nudPrice_ValueChanged(sender As Object, e As EventArgs) Handles nudPrice.ValueChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lblPayment.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblDesc.Click

    End Sub

    Private Sub pnAddOrders_Paint(sender As Object, e As PaintEventArgs) Handles pnAddOrders.Paint

    End Sub
End Class