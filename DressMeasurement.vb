Public Class DressMeasurement
    Public Property PartMeasurement As String
    Public Property Value As Decimal
    Public Property Unit As String


    Public Sub New(partMeasurement As String, value As Decimal, unit As String)
        Me.PartMeasurement = partMeasurement
        Me.Value = value
        Me.Unit = unit
    End Sub
End Class
