Public Class ClothingSize
    Public Property Id As Integer
    Public Property Name As String
    Public Property Measurements As List(Of Measurement)

    Public Sub New(Name As String)
        Me.Name = Name
    End Sub

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class
