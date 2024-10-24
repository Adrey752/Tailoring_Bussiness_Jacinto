Public Class Order

    Public Property OrderId As Integer
    Public Property OrderName As String
    Public Property Type As String

    Public Property Description As String
    Public Property Price As Decimal
    Public Property Done As Boolean
    Public Property Sizes As List(Of Size)

    Public Property Status As String


    Public Sub New(OrderId As Integer, orderName As String, serviceType As String, description As String, price As Decimal, done As Boolean, sizes As List(Of Size), status As String)
        Me.OrderId = OrderId
        Me.OrderName = orderName
        Me.Type = serviceType
        Me.Description = description
        Me.Price = price
        Me.Done = done
        Me.Sizes = sizes
        Me.Status = status
    End Sub

    Public Sub AddSize(size As Size)
        Sizes.Add(size)
    End Sub

End Class