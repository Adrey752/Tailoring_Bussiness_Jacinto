Imports System.ComponentModel.Design
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AddClientForm
    Dim _home As Home
    Dim _client As Client
    Public Sub New(homeInstance As Home, client As Client)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _home = homeInstance
        _client = client


    End Sub
    Private Sub Btn_Save(sender As Object, e As EventArgs) Handles btnSave.Click

        If ValidateFields() Then

            Dim name As String = tbName.Text
            Dim address As String = tbAddress.Text
            Dim contact As String = tbNumber.Text



            ' Step 1: Insert Client into the database and retrieve client_id
            Dim clientId As Integer = InsertClientToDB(_client)


            ' Step 2: Insert each Order for the client and retrieve order_id
            For Each order As Order In _client.Orders
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
    Public Function InsertClientToDB(client As Client) As Integer
        Dim clientQuery As String = "INSERT INTO client (Name, Address, Contact, Status) VALUES (@Name, @Address, @Contact, @Status); SELECT LAST_INSERT_ID();"
        Dim clientParams As New Dictionary(Of String, Object) From {
        {"@Name", client.Name},
        {"@Address", client.Address},
        {"@Contact", client.Contact},
        {"@Status", client.Status}
    }

        ' Return the newly inserted client_id
        Return Convert.ToInt32(MySQLModule.ExecuteScalar(clientQuery, clientParams))

    End Function
    Public Function InsertOrder(order As Order, clientId As Integer) As Integer
        Dim orderQuery As String = "INSERT INTO client_order (client_id, order_name, type, description, price, done) VALUES (@ClientId, @OrderName, @Type, @Description, @Price, @Done); SELECT LAST_INSERT_ID();"
        Dim orderParams As New Dictionary(Of String, Object) From {
        {"@ClientId", clientId},
        {"@OrderName", order.OrderName},
        {"@Type", order.Type},
        {"@Description", order.Description},
        {"@Price", order.Price},
        {"@Done", order.Done}
    }

        ' Return the newly inserted order_id
        Return Convert.ToInt32(MySQLModule.ExecuteScalar(orderQuery, orderParams))
    End Function
    Public Sub InsertSize(size As Size, orderId As Integer)
        Dim sizeQuery As String = "INSERT INTO size_values (order_id, type_id, size_value, size_unit, garment_id) VALUES (@OrderId, @TypeId, @SizeValue, @SizeUnit, @garment_id)"
        Dim sizeParams As New Dictionary(Of String, Object) From {
        {"@OrderId", orderId},
        {"@TypeId", GetTypeId(size.PartMeasurement)}, ' Get type_id for the measurement type
        {"@garment_id", GetGarmentId(size.garment)},
        {"@SizeValue", size.Value},
        {"@SizeUnit", size.Unit}
    }

        MySQLModule.ExecuteNonQuery(sizeQuery, sizeParams)
    End Sub


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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Public Sub AddProjectPanel(orderName As String, serviceType As String, description As String, order As Order)

        Dim projectPanel As New Panel
        projectPanel.Height = 80
        projectPanel.Width = 200
        projectPanel.Margin = New Padding(10)

        Dim lblOrderName As New Label
        lblOrderName.Text = "Order Name: " & orderName
        lblOrderName.Location = New Point(10, 10)

        Dim lblServiceType As New Label
        lblServiceType.Text = "Service Type: " & serviceType
        lblServiceType.Location = New Point(10, 30)



        Dim checkBox As New CheckBox
        checkBox.Location = New Point(projectPanel.Width - 40, 30)  ' Positioned to the right
        checkBox.Tag = order ' Associate the checkbox with the Order object

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
        ' Attempt to get the clicked Panel. If the sender is not a Panel, find the parent Panel.
        Dim clickedPanel As Panel = TryCast(sender, Panel)

        If clickedPanel Is Nothing Then
            ' If sender is not a Panel, look for the parent Panel
            Dim control As Control = DirectCast(sender, Control) ' Cast sender to Control
            clickedPanel = control.Parent ' Get the parent control, which should be the Panel
        End If

        ' Check if clickedPanel is still Nothing; if so, exit the method
        If clickedPanel IsNot Nothing Then
            ' Display full project details when clicked (e.g., open a new form)
            Dim orderDisplay As OrderDisplay = New OrderDisplay()
            orderDisplay.Show()
        End If
    End Sub


    Private Sub orderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'DesignSurface


    End Sub
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

    Private Sub fpTask_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub tbNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNumber.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Function ValidateFields() As Boolean
        Dim emptyFields As New List(Of String) ' Initialize the list

        ' Check if each TextBox is empty and add its name to the list
        If String.IsNullOrEmpty(tbName.Text) Then
            emptyFields.Add("Name")
        End If
        If String.IsNullOrEmpty(tbAddress.Text) Then
            emptyFields.Add("Address")
        End If
        If String.IsNullOrEmpty(tbNumber.Text) Then
            emptyFields.Add("Number")
        End If

        ' If there are any empty fields, show a warning and set focus
        If emptyFields.Count > 0 Then
            MessageBox.Show("The following fields cannot be blank: " & String.Join(", ", emptyFields), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ' Set focus to the first empty field
            If emptyFields.Contains("Name") Then
                tbName.Focus()
            ElseIf emptyFields.Contains("Address") Then
                tbAddress.Focus()
            ElseIf emptyFields.Contains("Number") Then
                tbNumber.Focus()
            End If
            Return False ' Validation failed
        Else
            ' All fields are valid
            MessageBox.Show("All inputs are valid.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return True ' Validation succeeded
        End If
    End Function

    Private Sub btnRemoveTask_Click(sender As Object, e As EventArgs) Handles btnRemoveTask.Click
        ' Use a reverse loop to avoid index shifting while removing controls
        For i As Integer = fpTask.Controls.Count - 1 To 0 Step -1
            ' Get the control, assume it is a Panel
            Dim panel As Panel = TryCast(fpTask.Controls(i), Panel)
            If panel IsNot Nothing Then
                ' Find the checkbox and check if it is checked
                Dim checkBox As CheckBox = TryCast(panel.Controls.OfType(Of CheckBox)().FirstOrDefault(), CheckBox)
                If checkBox IsNot Nothing AndAlso checkBox.Checked Then
                    ' Retrieve the Order object from the Tag
                    Dim orderToRemove As Order = TryCast(checkBox.Tag, Order)

                    ' Remove the order from the client.Orders list
                    If orderToRemove IsNot Nothing Then
                        _client.Orders.Remove(orderToRemove)
                    End If

                    ' Remove the panel from the FlowLayoutPanel
                    fpTask.Controls.Remove(panel)
                End If
            End If
        Next
    End Sub


End Class