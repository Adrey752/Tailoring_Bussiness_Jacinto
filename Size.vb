Public Class Size

    Public Property BodyPart As String
    Public Property Value As Decimal
    Public Property Unit As String
    Public Property garment As String


    Public Sub New(SisBodyPart As String, value As Decimal, unit As String, garment As String)

        Me.BodyPart = BodyPart
        Me.Value = value
        Me.Unit = unit
        Me.garment = garment
    End Sub
End Class
