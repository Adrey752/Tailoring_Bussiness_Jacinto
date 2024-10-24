Public Class OrderPanel
    Inherits Panel

    Public Property Order As Order
    Dim lblServiceType As Label
    Dim lblOrderName As Label

    Public Sub New(order As Order)
        Me.Order = order
        Me.Height = 80
        Me.Width = 200
        Me.Margin = New Padding(10)
        Me.BackColor = Color.FromArgb(217, 185, 155)
        Me.ForeColor = Color.Black

        lblOrderName = New Label()
        lblServiceType = New Label()

        lblOrderName.Text = "Order Name: " & order.OrderName
        lblOrderName.Location = New Point(10, 10)
        lblOrderName.AutoSize = True
        lblOrderName.Enabled = False

        lblServiceType.Text = "Service Type: " & order.Type
        lblServiceType.Location = New Point(10, 30)
        lblServiceType.AutoSize = True
        lblServiceType.Enabled = False


        Dim checkBox As New CheckBox With {
            .Location = New Point(Me.Width - 40, 30)
        }

        Me.Controls.Add(lblOrderName)
        Me.Controls.Add(lblServiceType)
        Me.Controls.Add(checkBox)

        Me.Tag = order
    End Sub
    Public Sub UpdateUI()
        lblOrderName.Text = "Order Name: " & Order.OrderName
        lblServiceType.Text = "Service Type: " & Order.Type
    End Sub
End Class
