﻿Public Class Home
    Dim _login As login

    Public Sub New(login As login)

        ' This call is required by the designer.
        InitializeComponent()
        _login = login
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadDatabase()


        'Designs
        DataGridOrders.EnableHeadersVisualStyles = False
        DataGridOrders.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(222, 184, 135)

        With DataGridOrders.ColumnHeadersDefaultCellStyle
            .BackColor = Color.FromArgb(9, 11, 23)
            .ForeColor = Color.White
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Alignment = DataGridViewContentAlignment.MiddleCenter

        End With


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        If Not pnLogout.Visible Then
            pnLogout.Visible = True
        Else
            pnLogout.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        login.Show()
    End Sub


    Public Sub loadDatabase()
        Dim tableQuery = "SELECT client.client_id, client.name, client.address, client.contact, client.status, price, payment" &
    " FROM client"

        Dim parameter As New Dictionary(Of String, Object)()

        Dim resultTable As DataTable = ExecuteQuery(tableQuery, parameter)
        DataGridOrders.DataSource = resultTable

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAddrOrder.Click
        Dim newClient = New Client("", "", -1)
        Dim addOrder As New AddClientForm(Me, newClient)
        addOrder.Show()
    End Sub

    Private Sub btnAddrOrder_Paint(sender As Object, e As PaintEventArgs) Handles btnAddrOrder.Paint

        ' Enable anti-aliasing for smoother edges
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        ' Enable anti-aliasing for text rendering
        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

        ' Set background color
        sender.BackColor = Color.FromArgb(184, 115, 51)

        ' Define corner radius for rounded edges
        Dim cornerRadius As Integer = 15

        ' Create a new GraphicsPath for rounded rectangle
        Dim path As New Drawing2D.GraphicsPath

        ' Start drawing the rounded rectangle
        path.StartFigure()

        ' Top left corner
        path.AddArc(New Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90)
        path.AddLine(cornerRadius, 0, sender.Width - cornerRadius, 0)

        ' Top right corner
        path.AddArc(New Rectangle(sender.Width - cornerRadius, 0, cornerRadius, cornerRadius), -90, 90)
        path.AddLine(sender.Width, cornerRadius, sender.Width, sender.Height - cornerRadius)

        ' Bottom right corner
        path.AddArc(New Rectangle(sender.Width - cornerRadius, sender.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90)
        path.AddLine(sender.Width - cornerRadius, sender.Height, cornerRadius, sender.Height)

        ' Bottom left corner
        path.AddArc(New Rectangle(0, sender.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90)
        path.CloseFigure()

        ' Apply the rounded region to the sender
        sender.Region = New Region(path)
    End Sub




    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _login.Close()
    End Sub




End Class