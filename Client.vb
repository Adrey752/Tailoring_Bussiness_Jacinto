Public Class Client

    Public Property client_Id
    Public Property Name As String
    Public Property Address As String
    Public Property Contact As String
    Public Property Price As Decimal
    Public Property Payment As Decimal
    Public Property Quantity As Integer
    Public Property Orders As List(Of Order)

    Public Property PaymenHistory As New List(Of PaymentDetails)

    Public Sub New(name As String, address As String, contact As String, price As Decimal, payment As Decimal, quantity As Integer)
        Me.Name = name
        Me.Address = address
        Me.Contact = contact
        Me.Price = price
        Me.Payment = payment
        Me.Quantity = quantity
        Me.Orders = New List(Of Order)

    End Sub

    Public Sub addOrder(order As Order)
        Orders.Add(order)
    End Sub
    Public Sub RemoveOrder(orderToRemove As Order)
        Orders.Remove(orderToRemove)
    End Sub
End Class
