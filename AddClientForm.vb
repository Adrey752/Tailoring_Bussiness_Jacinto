Imports System.ComponentModel.Design
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AddClientForm
    Dim _home As Home
    Dim _client As Client
    Private ReadOnly Property Client_Orders As List(Of Order)
        Get
            Return _client.Orders
        End Get
    End Property
    Public Sub New(homeInstance As Home)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _home = homeInstance
        _client = New Client("", "", -1, 0, 0, 0)


    End Sub
    Private Sub Btn_Save(sender As Object, e As EventArgs) Handles btnSave.Click

        If ValidateFields() = True Then

            _client.Name = tbName.Text
            _client.Address = tbAddress.Text
            _client.Contact = tbNumber.Text



            ' Step 1: Insert Client into the database and retrieve client_id
            Dim clientId As Integer = InsertClientToDB(_client)


            ' Step 2: Insert each Order for the client and retrieve order_id
            For Each order As Order In Client_Orders
                Dim orderId As Integer = InsertOrder(order, clientId)

                ' Step 3: Insert each DressMeasurement (Size) for the order
                For Each size As Size In order.Sizes
                    InsertSize(size, orderId)
                Next
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

        Dim addOrder = New AddOrder(_client, Me)
        Me.Hide()
        addOrder.Show()
    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Public Sub AddProjectPanel(order As Order)

        Dim projectPanel As New Panel
        projectPanel.Height = 80
        projectPanel.Width = 200
        projectPanel.Margin = New Padding(10)

        Dim lblOrderName As New Label
        lblOrderName.Text = "Order Name: " & order.OrderName
        lblOrderName.Location = New Point(10, 10)

        Dim lblServiceType As New Label
        lblServiceType.Text = "Service Type: " & order.Type
        lblServiceType.Location = New Point(10, 30)



        Dim checkBox As New CheckBox
        checkBox.Location = New Point(projectPanel.Width - 40, 30)
        checkBox.Tag = order

        lblServiceType.AutoSize = True
        lblOrderName.AutoSize = True

        projectPanel.Controls.Add(lblOrderName)
        projectPanel.Controls.Add(lblServiceType)
        projectPanel.Controls.Add(checkBox)

        projectPanel.BackColor = Color.FromArgb(217, 185, 155)
        projectPanel.ForeColor = Color.Black

        AddHandler projectPanel.Click, AddressOf ProjectPanel_Click
        AddHandler lblOrderName.Click, AddressOf ProjectPanel_Click
        AddHandler lblServiceType.Click, AddressOf ProjectPanel_Click
        AddHandler checkBox.Click, AddressOf ProjectPanel_Click


        fpTask.Controls.Add(projectPanel)
    End Sub



    Private Sub ProjectPanel_Click(sender As Object, e As EventArgs)
        Dim clickedPanel As Panel = TryCast(sender, Panel)
        If clickedPanel Is Nothing Then

            Dim control As Control = DirectCast(sender, Control)
            clickedPanel = control.Parent
        End If
        If clickedPanel IsNot Nothing Then
            Dim orderDisplay As OrderDisplay = New OrderDisplay()
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
                    Dim orderToRemove As Order = TryCast(checkBox.Tag, Order)
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
                AddProjectPanel(order)
            Next
        End If
    End Sub



    '********** Function Helper ni ***********8
    Private Sub btnAddrOrder_Paint(sender As Object, e As PaintEventArgs) Handles btnSave.Paint, btnCancel.Paint
        'sender = FormBorderStyle.Non
        sender.BackColor = Color.FromArgb(184, 115, 51)


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
    Public Function InsertOrder(order As Order, clientId As Integer) As Integer
        Dim orderQuery As String = "INSERT INTO client_order (client_id, order_name, type, description, price, image, date) VALUES (@ClientId, @OrderName, @Type, @Description, @Price, @image, @date); SELECT LAST_INSERT_ID();"
        Dim orderParams As New Dictionary(Of String, Object) From {
    {"@ClientId", clientId},
    {"@OrderName", order.OrderName},
    {"@Type", order.Type},
    {"@Description", order.Description},
    {"@Price", order.Price},
    {"@image", ImageToBinary(order.OrderImage)},
    {"@date", order.DateOrdered}
}

        Return Convert.ToInt32(MySQLModule.ExecuteScalar(orderQuery, orderParams))
    End Function

    Private Function ImageToBinary(image As Image) As Byte()
        Using ms As New MemoryStream
            image.Save(ms, image.RawFormat)
            Return ms.ToArray()
        End Using
    End Function
    Public Sub InsertSize(size As Size, orderId As Integer)
        Dim sizeQuery As String = "INSERT INTO size_values (order_id, type_id, size_value, size_unit, garment_id) VALUES (@OrderId, @TypeId, @SizeValue, @SizeUnit, @garment_id)"
        Dim sizeParams As New Dictionary(Of String, Object) From {
        {"@OrderId", orderId},
        {"@TypeId", GetTypeId(size.BodyPart)}, ' Get type_id for the measurement type
        {"@garment_id", GetGarmentId(size.garment)},
        {"@SizeValue", size.Value},
        {"@SizeUnit", size.Unit}
    }

        MySQLModule.ExecuteNonQuery(sizeQuery, sizeParams)
    End Sub

    Private Sub AddClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class