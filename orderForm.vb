Imports System.ComponentModel.Design

Public Class orderForm
    Dim _home As Home
    Dim _client As Client
    Public Sub New(homeInstance As Home, client As Client)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _home = homeInstance
        _client = client


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim name As String = tbName.Text
        Dim address As String = tbAddress.Text
        Dim contact As String = tbNumber.Text

        Dim insertClient As String = "INSERT INTO client (name, contact, address) VALUES (@name, @contact, @address);"

        Dim parameters As New Dictionary(Of String, Object)
        parameters.Add("@name", name)
        parameters.Add("@contact", contact)
        parameters.Add("@address", address)

        MySQLModule.ExecuteNonQuery(insertClient, parameters)
        _home.loadDatabase()
        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Public Sub AddProjectPanel(orderName As String, serviceType As String, garmentType As String, description As String)
        ' Create a new panel

        Dim projectPanel As New Panel
        projectPanel.Height = 200
        projectPanel.Width = 800
        projectPanel.BackColor = Color.LightGray
        projectPanel.Margin = New Padding(10)

        ' Add labels for the project details
        Dim lblServiceName As New Label
        lblServiceName.Text = "Service Type: " & orderName
        lblServiceName.Location = New Point(10, 10)

        Dim lblServiceType As New Label
        lblServiceType.Text = "Service Type: " & serviceType
        lblServiceType.Location = New Point(10, 10)

        Dim lblGarmentType As New Label
        lblGarmentType.Text = "Garment Type: " & garmentType
        lblGarmentType.Location = New Point(10, 30)

        Dim lblDescription As New Label
        lblDescription.Text = "Description: " & description
        lblDescription.Location = New Point(10, 50)
        lblServiceType.AutoSize = True
        lblGarmentType.AutoSize = True
        lblDescription.AutoSize = True

        ' Add the labels to the panel
        projectPanel.Controls.Add(lblServiceType)
        projectPanel.Controls.Add(lblGarmentType)
        projectPanel.Controls.Add(lblDescription)
        projectPanel.BackColor = Color.Black
        projectPanel.ForeColor = Color.White

        ' Add click event handler for panel click
        AddHandler projectPanel.Click, AddressOf ProjectPanel_Click

        ' Add the project panel to a FlowLayoutPanel for dynamic UI
        fpTask.Controls.Add(projectPanel)
    End Sub

    Private Sub ProjectPanel_Click(sender As Object, e As EventArgs)
        Dim clickedPanel As Panel = DirectCast(sender, Panel)

        ' Display full project details when clicked (e.g., open a new form)
        Dim projectDetailsForm As New ProjectDetailsForm()
        projectDetailsForm.Show()
    End Sub



    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click
        Dim name = tbName.Text
        Dim address = tbAddress.Text
        Dim number = tbNumber.Text

        _client.Name = name
        _client.Address = address
        _client.Contact = number

        Dim addOrder = New AddOrder(_client, Me)
        addOrder.Show()
    End Sub

    Private Sub orderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'DesignSurface


    End Sub
    Private Sub btnAddrOrder_Paint(sender As Object, e As PaintEventArgs) Handles btnSave.Paint, btnCancel.Paint
        'sender = FormBorderStyle.Non
        sender.BackColor = Color.PaleTurquoise


        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure()
        'top left corner
        DGP.AddArc(New Rectangle(0, 0, 8, 8), 180, 90)
        DGP.AddLine(8, 0, sender.Width - 8, 0)

        'top right corner
        DGP.AddArc(New Rectangle(sender.Width - 8, 0, 8, 8), -90, 90)
        DGP.AddLine(sender.Width, 8, sender.Width, sender.Height - 8)

        'buttom right corner
        DGP.AddArc(New Rectangle(sender.Width - 8, sender.Height - 8, 8, 8), 0, 90)
        DGP.AddLine(sender.Width - 8, sender.Height, 8, sender.Height)

        'buttom left corner
        DGP.AddArc(New Rectangle(0, sender.Height - 8, 8, 8), 90, 90)
        DGP.CloseFigure()

        sender.Region = New Region(DGP)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles lblTask.Click

    End Sub
End Class