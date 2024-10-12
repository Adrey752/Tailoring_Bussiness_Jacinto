Public Class Client
    Public Property Name As String
    Public Property Address As String
    Public Property Contact As String
    Public Property Status As Boolean
    Public Property Price As Decimal
    Public Property Payment As Decimal
    Public Property Quantity As Integer
    Public Property Orders As List(Of Order)

    Public Sub New(name As String, address As String, contact As String, status As Boolean, price As Decimal, payment As Decimal, quantity As Integer)
        Me.Name = name
        Me.Address = address
        Me.Contact = contact
        Me.Status = status
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
