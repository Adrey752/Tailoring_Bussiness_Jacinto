Imports System.Threading
Imports System.Windows.Forms

Public Class PaymentDialog
    Dim client As Client
    Dim selectedOrdersPrice As Decimal
    Dim partialPayment As Decimal
    Dim totalPrice As Decimal

    Public Property CheckedOrders As List(Of Order)
    Public Property PaymentDate As DateTime
    Public Property PaymentAmount As Decimal
    Public Sub New(client As Client)

        ' This call is required by the designer.
        InitializeComponent()
        Me.client = client

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub OK_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles OK_Button.Click
        DialogResult = DialogResult.OK
        CheckedOrders = GetCheckoutOrders()
        PaymentDate = dtpPaymentDate.Value
        PaymentAmount = totalPrice
        Hide()
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

    Private Function GetCheckoutOrders() As List(Of Order)
        Dim checkedOrder As New List(Of Order)
        For Each row As DataGridViewRow In dgOrders.Rows
            Dim checkbox As Boolean = row.Cells(0).Value
            If checkbox = True Then
                Dim taggedOrder As Order = row.Tag
                taggedOrder.Paid = True
                checkedOrder.Add(taggedOrder)
            End If
        Next
        Return checkedOrder
    End Function

    Private Sub dgOrders_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgOrders.CellValueChanged
        Dim columnIndex As Integer = e.ColumnIndex
        Dim rowIndex As Integer = e.RowIndex

        If rowIndex >= 0 AndAlso columnIndex = 0 Then
            Dim row As DataGridViewRow = dgOrders.Rows(rowIndex)
            Dim order As Order = CType(row.Tag, Order)

            If Convert.ToBoolean(row.Cells(0).Value) Then
                selectedOrdersPrice += order.Price
            Else
                selectedOrdersPrice -= order.Price
            End If
            totalPrice = selectedOrdersPrice + partialPayment
            lblAmountToPay.Text = "₱ " & totalPrice.ToString("N2")
        End If
    End Sub
    Private Sub dgOrders_CurrentCellDirtyStateChanged(sender As Object, e As EventArgs) Handles dgOrders.CurrentCellDirtyStateChanged
        If dgOrders.IsCurrentCellDirty AndAlso TypeOf dgOrders.CurrentCell Is DataGridViewCheckBoxCell Then
            dgOrders.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub






    Private Sub nudPartialPayment_ImeModeChanged(sender As Object, e As EventArgs) Handles nudPartialPayment.ValueChanged
        partialPayment = nudPartialPayment.Value
        totalPrice = selectedOrdersPrice + partialPayment
        lblAmountToPay.Text = "₱ " & totalPrice.ToString("N2")
    End Sub

    Private Sub lblAmountToPay_Click(sender As Object, e As EventArgs) Handles lblAmountToPay.Click

    End Sub
End Class
