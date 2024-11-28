Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Text.Json
Imports System.Text.Json.Nodes
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim admin_details As AdminDetails = GetAdminDetails()

        If admin_details IsNot Nothing Then
            tbPassword.Focus()
            Me.BackColor = Color.FromArgb(226, 217, 185)
        Else
            Dim Welcome As New WelcomeNewUser(Me)
            Me.Hide()
            Welcome.ShowDialog()

        End If


    End Sub



    Private Sub tbEnter_Click(sender As Object, e As EventArgs) Handles tbEnter.Click
        Login()
    End Sub

    Private Sub Login()
        Dim password As String = tbPassword.Text.Trim()

        If ValidateLogin(password) Then

            tbPassword.Text = ""
            Me.Hide()
            Dim homePage As New Home(Me)

            homePage.Show()
            If Me.WindowState = FormWindowState.Maximized Then
                homePage.WindowState = FormWindowState.Maximized
            End If

        Else
            MessageBox.Show("Invalid username or password. Please try again.")
        End If
    End Sub

    Private Sub tbPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Login()
        End If
    End Sub

    Private Function ValidateLogin(password As String) As Boolean
        Dim query As String = "SELECT password FROM admin LIMIT 1"

        Dim resultTable As DataTable = MySQLModule.ExecuteQuery(query, New Dictionary(Of String, Object))

        If resultTable.Rows.Count > 0 Then
            Dim storedPassword As String = resultTable.Rows(0)("password").ToString()

            If storedPassword = password Then
                Return True
            End If
        End If


        Return False
    End Function

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PbshowPassword_Click(sender As Object, e As EventArgs) Handles PbshowPassword.Click
        If tbPassword.UseSystemPasswordChar Then
            tbPassword.UseSystemPasswordChar = False
            PbshowPassword.Image = My.Resources.show
        Else
            tbPassword.UseSystemPasswordChar = True
            PbshowPassword.Image = My.Resources.eye
        End If
    End Sub

    Private Function GetAdminDetails() As AdminDetails
        Dim query = "SELECT * FROM admin LIMIT 1"
        Dim parametery As New Dictionary(Of String, Object)

        Dim resultTable = MySQLModule.ExecuteQuery(query, parametery)

        If resultTable Is Nothing OrElse resultTable.Rows.Count = 0 Then
            Return Nothing
        End If

        For Each row As DataRow In resultTable.Rows
            Dim firstname As String = row.Field(Of String)("firstname")
            Dim middlename As String = row.Field(Of String)("middlename")
            Dim lastname As String = row.Field(Of String)("lastname")
            Dim birthday As Date = row.Field(Of Date)("birthday")
            Dim password As String = row.Field(Of String)("password")
            Dim secque As String = row.Field(Of String)("securityQuestion")
            Dim securityQuestions As Dictionary(Of String, String) = JsonSerializer.Deserialize(Of Dictionary(Of String, String))(secque)

            Dim adminDetails As New AdminDetails(firstname, middlename, lastname, birthday, password, securityQuestions)
            Return adminDetails
        Next

        Return Nothing
    End Function

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
