Public Class OrderPanel
    Inherits Panel

    Public Property Order As Order

    Private lblServiceType As Label
    Private lblOrderName As Label
    Public Property checkBox As CheckBox

    'Public Event CheckBoxStateChanged(sender As Object, e As EventArgs)

    Public Sub New(order As Order)
        Me.Order = order
        Me.Height = 100
        Me.Width = 225
        Me.Margin = New Padding(10)
        Me.BackColor = Color.FromArgb(217, 185, 155)
        Me.ForeColor = Color.Black

        lblOrderName = New Label() With {
            .Text = "Order Name: " & order.OrderName,
            .Location = New Point(10, 25),
            .Width = Me.Width - 20,
            .AutoSize = True,
            .Enabled = False
        }

        lblServiceType = New Label() With {
            .Text = "Service Type: " & order.Type,
            .Location = New Point(10, lblOrderName.Bottom + 5),
            .Width = Me.Width - 20,
            .AutoSize = True,
            .Enabled = False
        }

        checkBox = New CheckBox() With {
            .Location = New Point(Me.Width - 30, 5),
            .Anchor = AnchorStyles.Top Or AnchorStyles.Right,
            .Text = "",
            .Enabled = False
        }

        'AddHandler checkBox.CheckedChanged, AddressOf CheckBox_CheckedChanged

        Me.Controls.Add(lblOrderName)
        Me.Controls.Add(lblServiceType)
        Me.Controls.Add(checkBox)
        Me.Tag = order
    End Sub

    'Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs)
    '    RaiseEvent CheckBoxStateChanged(Me, e)
    'End Sub

    Public Sub UpdateUI()
        lblOrderName.Text = "Order Name: " & Order.OrderName
        lblServiceType.Text = "Service Type: " & Order.Type
    End Sub
End Class
