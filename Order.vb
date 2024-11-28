Public Class Order

    Public Property OrderId As Integer
    Public Property OrderName As String
    Public Property Type As String

    Public Property Description As String
    Public Property Price As Decimal
    Public Property CloatheSize As ClothingSize

    Public Property DateOrdered As DateTime
    Public Property OrderImage As Image

    Public Property Status As String
    Public Property Payment_id As Integer


    Public Sub New(OrderId As Integer, orderName As String, serviceType As String, description As String, price As Decimal, orderImage As Image, DateOrdered As DateTime, status As String, paymentId As Integer, cloatheSize As ClothingSize)
        Me.OrderId = OrderId
        Me.OrderName = orderName
        Me.Type = serviceType
        Me.Description = description
        Me.Price = price
        Me.Status = status
        Me.DateOrdered = DateOrdered
        Me.OrderImage = orderImage
        Me.Payment_id = paymentId
        Me.CloatheSize = cloatheSize
    End Sub



End Class