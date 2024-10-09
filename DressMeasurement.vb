Public Class DressMeasurement
    Public Property PartMeasurement As String
    Public Property Value As Decimal
    Public Property Unit As String
    Public Property garment As String


    Public Sub New(partMeasurement As String, value As Decimal, unit As String, garment As String)
        Me.PartMeasurement = partMeasurement
        Me.Value = value
        Me.Unit = unit
        Me.garment = garment
    End Sub
End Class
