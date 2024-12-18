﻿Imports System.ComponentModel.Design
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AddClientForm
    Dim _home As Home
    Dim _client As Client
    Dim _login As login
    Public Property _Forward As AddOrder
    Private ReadOnly Property Client_Orders As List(Of Order)
        Get
            Return _client.Orders
        End Get
    End Property
    Public Sub New(login As login, homeInstance As Home)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _home = homeInstance
        _client = New Client("", "", -1, 0, 0, 0)
        _login = login

    End Sub
    Private Sub Btn_Save(sender As Object, e As EventArgs) Handles btnSave.Click

        If ValidateFields() = True Then

            _client.Name = tbName.Text
            _client.Address = tbAddress.Text
            _client.Contact = tbNumber.Text
            Dim clientId As Integer = InsertClientToDB(_client)

            For Each order As Order In Client_Orders
                Dim orderId As Integer = InsertOrder(order, clientId, order.CloatheSize.Id)

            Next


            _home.loadDatabase()
            Me.Close()
            _home.Show()
        End If

    End Sub
    Private Function ValidateFields() As Boolean

        Dim emptyFields As New List(Of String)
        If String.IsNullOrEmpty(tbName.Text) Then
            emptyFields.Add("Name")
        End If
        If String.IsNullOrEmpty(tbAddress.Text) Then
            emptyFields.Add("Address")
        End If
        If String.IsNullOrEmpty(tbNumber.Text) Then
            emptyFields.Add("Number")
        End If
        If emptyFields.Count > 0 Then
            MessageBox.Show("The following fields cannot be blank: " & String.Join(", ", emptyFields), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            If emptyFields.Contains("Name") Then
                tbName.Focus()
            ElseIf emptyFields.Contains("Address") Then
                tbAddress.Focus()
            ElseIf emptyFields.Contains("Number") Then
                tbNumber.Focus()
            End If
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddTask.Click
        Dim name = tbName.Text
        Dim address = tbAddress.Text
        Dim number = tbNumber.Text

        _client.Name = name
        _client.Address = address
        _client.Contact = number

        Dim addOrder = New AddOrder(_login, _home, _client, Me)
        Me.Hide()
        addOrder.Show()
    End Sub




    Private Sub ProjectPanel_Click(sender As Object, e As EventArgs)
        Dim clickedPanel As OrderPanel = TryCast(sender, OrderPanel)
        If clickedPanel Is Nothing Then

            Dim control As Control = DirectCast(sender, Control)
            clickedPanel = control.Parent
        End If
        If clickedPanel IsNot Nothing Then
            Dim order As Order = clickedPanel.Tag
            Dim orderDisplay As OrderDisplay = New OrderDisplay(order)
            orderDisplay.Show()
        End If
    End Sub

    Private Sub tbNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub



    Private Sub btnRemoveTask_Click(sender As Object, e As EventArgs) Handles btnRemoveTask.Click
        For i As Integer = fpTask.Controls.Count - 1 To 0 Step -1
            Dim panel As Panel = TryCast(fpTask.Controls(i), Panel)
            If panel IsNot Nothing Then
                Dim checkBox As CheckBox = TryCast(panel.Controls.OfType(Of CheckBox)().FirstOrDefault(), CheckBox)
                If checkBox IsNot Nothing AndAlso checkBox.Checked Then
                    Dim orderToRemove As Order = TryCast(panel.Tag, Order)
                    If orderToRemove IsNot Nothing Then
                        Client_Orders.Remove(orderToRemove)
                    End If
                    fpTask.Controls.Remove(panel)
                End If
            End If
        Next
    End Sub

    Private Sub AddClientForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _home.Show()
    End Sub
    Private Sub AddClientForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        fpTask.Controls.Clear()
        If Client_Orders.Count > 0 Then
            For Each order As Order In Client_Orders
                Dim orderPanel As New OrderPanel(order)
                orderPanel.checkBox.Enabled = True
                AddHandler orderPanel.Click, AddressOf ProjectPanel_Click
                fpTask.Controls.Add(orderPanel)
            Next
        End If
    End Sub



    '********** Function Helper ni ***********8
    Private Sub btnAddrOrder_Paint(sender As Object, e As PaintEventArgs) Handles btnSave.Paint
        'sender = FormBorderStyle.Non
        sender.BackColor = Color.FromArgb(184, 115, 51)


        Dim DGP As New Drawing2D.GraphicsPath
        DGP.StartFigure
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
        DGP.CloseFigure

        sender.Region = New Region(DGP)
    End Sub


    ' ********* SQL Functions Helper ko *********
    Public Shared Function GetTypeId(partMeasurement As String) As Integer
        Dim query As String = "SELECT type_id FROM size_types WHERE types = @PartMeasurement"
        Dim parameters As New Dictionary(Of String, Object) From {{"@PartMeasurement", partMeasurement}}
        Dim result As Object = MySQLModule.ExecuteScalar(query, parameters)
        If result IsNot Nothing Then
            Return Convert.ToInt64(result)
        Else
            Throw New Exception("Invalid measurement type: " & partMeasurement)
        End If
    End Function

    Public Shared Function GetGarmentId(garment As String)
        Dim query As String = "SELECT garment_id FROM garment_types WHERE garment_type = @garment_type"
        Dim parament As New Dictionary(Of String, Object) From {
        {"garment_type", garment}
        }
        Dim result As Object = MySQLModule.ExecuteScalar(query, parament)

        If result IsNot Nothing Then
            Return Convert.ToInt64(result)
        Else
            Throw New Exception("Invalid garment Type" & garment)
        End If
    End Function
    Public Function InsertClientToDB(client As Client) As Integer
        Dim clientQuery As String = "INSERT INTO client (Name, Address, Contact) VALUES (@Name, @Address, @Contact); SELECT LAST_INSERT_ID();"
        Dim clientParams As New Dictionary(Of String, Object) From {
        {"@Name", client.Name},
        {"@Address", client.Address},
        {"@Contact", client.Contact}
    }

        ' Return the newly inserted client_id
        Return Convert.ToInt32(MySQLModule.ExecuteScalar(clientQuery, clientParams))

    End Function

    Public Function InsertOrder(order As Order, clientId As Integer, cloathe_id As Integer) As Integer
        Dim orderQuery As String = "INSERT INTO client_order (client_id, order_name, type, description, price, image, date,clothing_id) VALUES (@ClientId, @OrderName, @Type, @Description, @Price, @image, @date, @clothing_id); SELECT LAST_INSERT_ID();"
        Dim orderParams As New Dictionary(Of String, Object) From {
    {"@ClientId", clientId},
    {"@OrderName", order.OrderName},
    {"@Type", order.Type},
    {"@Description", order.Description},
    {"@Price", order.Price},
    {"@image", ImageToBinary(order.OrderImage)},
    {"@date", order.DateOrdered},
    {"@clothing_id", cloathe_id}
}

        ' Return the newly inserted order_id
        Return Convert.ToInt32(MySQLModule.ExecuteScalar(orderQuery, orderParams))
    End Function
    Private Function ImageToBinary(image As Image) As Byte()
        Using ms As New MemoryStream
            image.Save(ms, image.RawFormat)
            Return ms.ToArray()
        End Using
    End Function


    Private Sub AddClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        _home.Show
        Close

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Close
        _home.Hide
        _login.Show

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim settings As New Settings(Me, _login, _home)
        Hide
        settings.Show
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        If _Forward Is Nothing Then
            btnAddTask.PerformClick()
        Else
            _Forward.Show()

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        Close()

    End Sub

    Private Sub fpTask_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub pbTailoringJacinto_Click(sender As Object, e As EventArgs) Handles pbTailoringJacinto.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub lblCustomerDetails_Click(sender As Object, e As EventArgs) Handles lblCustomerDetails.Click

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pnNavigation_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub LblName_Click(sender As Object, e As EventArgs) Handles LblName.Click

    End Sub

    Private Sub lblAddress_Click(sender As Object, e As EventArgs) Handles lblAddress.Click

    End Sub

    Private Sub fpTask_Paint_1(sender As Object, e As PaintEventArgs) Handles fpTask.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub tbAddress_TextChanged(sender As Object, e As EventArgs) Handles tbAddress.TextChanged

    End Sub
End Class