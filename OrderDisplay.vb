Public Class OrderDisplay
    Dim order As Order
    Public Sub New(order As Order)

        ' This call is required by the designer.
        InitializeComponent()
        Me.order = order

        tbOrderName.Text = order.OrderName
        cbStype.Text = order.Type
        lblAmountToPay.Text = "₱ " & order.Price.ToString("N2")
        SetPaymentStatud(order.Payment_id)
        rbDescription.Text = order.Description
        OrderPicturebox.Image = order.OrderImage
        dtpOrderDate.Value = order.DateOrdered
        SetOrderMeausurements(order.Sizes)

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub SetPaymentStatud(paymentId As Integer)
        If paymentId <> -1 Then
            lblPaymentStatus.Text = "Paid"
        Else
            lblPaymentStatus.Text = "Not Paid"
        End If
    End Sub

    Private Sub SetOrderMeausurements(measurements As List(Of Measurement))
        For Each measurement As Measurement In measurements
            Dim measurementPart = measurement.BodyPart
            Dim measurementValue = measurement.Value & measurement.Unit
            Dim garmentType = measurement.garment
            dgMeasurements.Rows.Add(measurementPart, measurementValue, garmentType)
        Next

    End Sub
    Private Sub btnRemoveImage_Click(sender As Object, e As EventArgs) Handles btnRemoveImage.Click

    End Sub

    Private Sub OrderDisplay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class