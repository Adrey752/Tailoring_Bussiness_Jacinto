Public Class Order
    Public Property OrderName As String
    Public Property Type As String

    Public Property Description As String
    Public Property Price As Decimal
    Public Property Done As Boolean
    Public Property Sizes As List(Of Size)


    Public Sub New(orderName As String, serviceType As String, garmentType As String, description As String, price As Decimal)
        Me.OrderName = orderName
        Me.Type = serviceType
        Me.Description = description
        Me.Price = price
        Me.Done = False
        Sizes = New List(Of Size)()
    End Sub

    Public Sub AddSize(size As Size)
        Sizes.Add(size)
    End Sub

End Class