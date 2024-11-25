Public Class AdminDetails
    Public Property Firstname As String
    Public Property Middlename As String
    Public Property Lastname As String

    Public Property Birthday As Date
    Public Property Password As String
    Public Property SecurityQuestions As Dictionary(Of String, String)

    Public Sub New(Firstname As String, Middlename As String, Lastname As String, BirthDay As Date, Password As String, SecurityQuestions As Dictionary(Of String, String))
        Me.Firstname = Firstname
        Me.Middlename = Middlename
        Me.Lastname = Lastname
        Me.Birthday = BirthDay
        Me.Password = Password
        Me.SecurityQuestions = SecurityQuestions
    End Sub

End Class
