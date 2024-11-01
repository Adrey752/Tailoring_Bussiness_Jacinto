Imports Mysqlx.Crud

Public Class PaymentDetails
    Public Property Payment_id As Integer
    Public Property PaymentDate As DateTime
    Public Property PaymentAmount As Decimal
    Public Property OrdersPaid As List(Of Order)

    Public Sub New(PaymentDate As DateTime, amount As Decimal, orders As List(Of Order))
        Me.PaymentDate = PaymentDate
        Me.PaymentAmount = amount
        Me.OrdersPaid = orders
    End Sub
End Class
