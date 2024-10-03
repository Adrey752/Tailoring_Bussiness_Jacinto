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
                For Each size As DressMeasurement In order.Sizes
                    InsertSize(size, orderId)
                Next
            Next


            _home.loadDatabase()
            Me.Close()
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
        Dim orderQuery As String = "INSERT INTO client_order (client_id, order_name, type, garment_type, description, price, done) VALUES (@ClientId, @OrderName, @Type, @GarmentType, @Description, @Price, @Done); SELECT LAST_INSERT_ID();"
        Dim orderParams As New Dictionary(Of String, Object) From {
        {"@ClientId", clientId},
        {"@OrderName", order.OrderName},
        {"@Type", order.Type},
        {"@GarmentType", order.GarmentType},
        {"@Description", order.Description},
        {"@Price", order.Price},
        {"@Done", order.Done}
    }

        ' Return the newly inserted order_id
        Return Convert.ToInt32(MySQLModule.ExecuteScalar(orderQuery, orderParams))
    End Function
    Public Sub InsertSize(size As DressMeasurement, orderId As Integer)
        Dim sizeQuery As String = "INSERT INTO size_values (order_id, type_id, size_value, size_unit) VALUES (@OrderId, @TypeId, @SizeValue, @SizeUnit)"
        Dim sizeParams As New Dictionary(Of String, Object) From {
        {"@OrderId", orderId},
        {"@TypeId", GetTypeId(size.PartMeasurement)}, ' Get type_id for the measurement type
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
        addOrder.Show()
    End Sub

    Public Function GetTypeId(partMeasurement As String) As Integer
        Dim query As String = "SELECT type_id FROM size_types WHERE types = @PartMeasurement"
        Dim parameters As New Dictionary(Of String, Object) From {{"@PartMeasurement", partMeasurement}}
        Dim result As Object = MySQLModule.ExecuteScalar(query, parameters)
        If result IsNot Nothing Then
            Return Convert.ToInt32(result)
        Else
            Throw New Exception("Invalid measurement type: " & partMeasurement)
        End If
    End Function

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

    Private Sub fpTask_Paint(sender As Object, e As PaintEventArgs) Handles fpTask.Paint

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



End Class