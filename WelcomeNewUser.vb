Imports System.Text.Json
Public Class WelcomeNewUser
    Dim loginForm As login
    Public Sub New(login As login)

        ' This call is required by the designer.
        InitializeComponent()
        Me.loginForm = login
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub WelcomeNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbQuestion1.SelectedIndexChanged

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If validateFields() = True Then

            Dim firstname = tbFirstname.Text
            Dim middlename = tbMiddlename.Text
            Dim lastname = tbLastname.Text
            Dim birthday = dtpBirthdate.Value
            Dim password = tbConfirmpassword.Text
            Dim question1 = cbQuestion1.Text
            Dim question2 = cbQuestion2.Text
            Dim answer1 = tbAnswer1.Text
            Dim answer2 = tbAnswer2.Text
            Dim securityquestions As New Dictionary(Of String, String) From {
        {question1, answer1},
        {question2, answer2}
        }
            Dim adminDetails As New AdminDetails(firstname, middlename, lastname, birthday, password, securityquestions)

            InsertAdminDetailsToDb(adminDetails)
            loginForm.Show()
            Me.Close()
        End If

    End Sub
    Private Function validateFields() As Boolean
        Dim errorFields As New List(Of String)()

        If String.IsNullOrEmpty(tbFirstname.Text) Then
            errorFields.Add("Firstname")
        End If
        If String.IsNullOrEmpty(tbMiddlename.Text) Then
            errorFields.Add("Middlename")
        End If
        If String.IsNullOrEmpty(tbLastname.Text) Then
            errorFields.Add("Lastname")
        End If
        If String.IsNullOrEmpty(tbAnswer1.Text) Then
            errorFields.Add("Answer to Question 1")
        End If
        If String.IsNullOrEmpty(tbAnswer2.Text) Then
            errorFields.Add("Answer to Question 2")
        End If

        If errorFields.Count > 0 Then
            MessageBox.Show("Please fill in the following fields: " & String.Join(", ", errorFields),
                        "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            If errorFields.Contains("Firstname") Then
                tbFirstname.Focus()
            ElseIf errorFields.Contains("Middlename") Then
                tbMiddlename.Focus()
            ElseIf errorFields.Contains("Lastname") Then
                tbLastname.Focus()
            ElseIf errorFields.Contains("Answer to Question 1") Then
                tbAnswer1.Focus()
            ElseIf errorFields.Contains("Answer to Question 2") Then
                tbAnswer2.Focus()
            End If
            Return False
        End If

        If tbCreatepassword.Text <> tbConfirmpassword.Text Then
            MessageBox.Show("Passwords do not match",
                        "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            tbCreatepassword.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub InsertAdminDetailsToDb(admindetails As AdminDetails)
        Dim serializeSectQuestion = JsonSerializer.Serialize(admindetails.SecurityQuestions)
        Dim query = "INSERT INTO admin (firstname, middlename, lastname, birthday, password, securityQuestion) VALUES (@firstname, @middlename, @lastname, @birthday, @password, @securityQuestion);"
        Dim parameter As New Dictionary(Of String, Object) From {
            {"@firstname", admindetails.Firstname},
            {"middlename", admindetails.Middlename},
            {"lastname", admindetails.Lastname},
            {"birthday", admindetails.Birthday},
            {"password", admindetails.Password},
            {"securityQuestion", serializeSectQuestion}
        }
        MySQLModule.ExecuteNonQuery(query, parameter)
    End Sub

    Private Sub createShowPassword_Click(sender As Object, e As EventArgs) Handles createShowpass.Click
        If tbCreatepassword.UseSystemPasswordChar = True Then
            tbCreatepassword.UseSystemPasswordChar = False
            createShowpass.Image = My.Resources.show
        Else
            tbCreatepassword.UseSystemPasswordChar = True
            createShowpass.Image = My.Resources.eye
        End If
    End Sub

    Private Sub confirmShowpass_Click(sender As Object, e As EventArgs) Handles confirmShowpass.Click

        If tbConfirmpassword.UseSystemPasswordChar = True Then
            tbConfirmpassword.UseSystemPasswordChar = False
            confirmShowpass.Image = My.Resources.show
        Else
            tbConfirmpassword.UseSystemPasswordChar = True
            confirmShowpass.Image = My.Resources.eye
        End If
    End Sub



End Class