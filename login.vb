Imports MySql.Data.MySqlClient
Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbPassword.Focus()
        Me.BackColor = Color.FromArgb(9, 11, 23)


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
End Class
