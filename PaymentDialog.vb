Imports System.Threading
Imports System.Windows.Forms

Public Class PaymentDialog
    Dim client As Client
    Dim amountToPay As Integer

    Public Sub New(client As Client)

        ' This call is required by the designer.
        InitializeComponent()
        Me.client = client

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK_Button.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub PaymentDialog_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        For Each order As Order In client.Orders
            Dim rowIndex As Integer = dgOrders.Rows.Add(False, order.OrderName, "₱" & order.Price)
            dgOrders.Rows(rowIndex).Tag = order

        Next
    End Sub

    Private Sub dgOrders_Click(sender As Object, e As DataGridViewCellEventArgs) Handles dgOrders.CellContentClick
        Dim columnIndex As Integer = e.ColumnIndex
        Dim rowIndex As Integer = e.RowIndex
        If rowIndex >= 0 AndAlso columnIndex = 0 Then

            Dim row As DataGridViewRow = dgOrders.Rows(rowIndex)
            Dim order As Order = row.Tag
            If Convert.ToBoolean(row.Cells(0).Value) Then
                amountToPay -= order.Price
            Else
                amountToPay += order.Price
            End If
            lblAmountToPay.Text = "₱ " & amountToPay.ToString("N2")
        End If
    End Sub
End Class
