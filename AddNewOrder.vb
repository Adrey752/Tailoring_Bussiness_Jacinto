Imports Mysqlx.XDevAPI

Public Class AddNewOrder
    Dim client_id As Integer
    Dim order As Order
    Private ReadOnly Property allPanels As List(Of Panel)
        Get
            Return fPanelOrders.Controls.OfType(Of Panel).ToList()
        End Get
    End Property

    Private ReadOnly Property ListOrders As List(Of Order)
        Get
            Dim orders As New List(Of Order)
            For Each panel As Panel In allPanels
                Dim order = CType(panel.Tag, Order)
                orders.Add(order)
            Next
            Return orders
        End Get
    End Property
    Public Sub New(client_id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.client_id = client_id
        Me.order = New Order(1, "", "", "", 1, False, New List(Of Size), "Pending")

    End Sub
    Private Sub AddNewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMeasurementsType()
        LoadGarmentTypes()
    End Sub

    Private Sub btnOrderSave_Click(sender As Object, e As EventArgs) Handles btnOrderSave.Click
        For Each order In ListOrders
            Dim orderId = InsertOrder(order, client_id)
            For Each Size As Size In order.Sizes
                InsertSize(Size, orderId)
            Next
        Next
        Me.Close()

    End Sub
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
        {"@TypeId", GetTypeId(size.BodyPart)}, ' Get type_id for the measurement type
        {"@garment_id", GetGarmentId(size.garment)},
        {"@SizeValue", size.Value},
        {"@SizeUnit", size.Unit}
    }

        MySQLModule.ExecuteNonQuery(sizeQuery, sizeParams)
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
    Private Sub LoadMeasurementsType()
        Dim query = "SELECT types FROM size_types"
        Dim dataTable = MySQLModule.ExecuteQuery(query, New Dictionary(Of String, Object))

        For Each row As DataRow In dataTable.Rows
            sbMType.Items.Add(row("types").ToString())
        Next
    End Sub

    Private Sub LoadGarmentTypes()
        Dim query As String = "SELECT garment_type FROM garment_types"
        Dim parameter As New Dictionary(Of String, Object)
        Dim datatable As DataTable = MySQLModule.ExecuteQuery(query, parameter)

        For Each row As DataRow In datatable.Rows
            cbGarment.Items.Add(row("garment_type").ToString())
        Next

    End Sub

    Private Sub addMeasurement_Click(sender As Object, e As EventArgs) Handles btnaddMeasurement.Click
        Dim measurementType = sbMType.Text
        Dim value = nudValue.Value
        Dim unit = cbUnit.Text
        Dim garment = cbGarment.Text
        Dim measurement = New Size(measurementType, value, unit, garment)

        order.AddSize(measurement)

        dgMeasurements.Rows.Add(measurementType, (value & unit), garment)
    End Sub
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

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        order.OrderName = tbOrderName.Text
        order.Type = cbStype.Text
        order.Price = nudPrice.Value
        order.Description = rbDescription.Text
        AddProjectPanel(order)
        Me.order = New Order(1, "", "", "", 1, False, New List(Of Size), "Pending")

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
        projectPanel.Tag = order

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

        fPanelOrders.Controls.Add(projectPanel)
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



    Private Sub SortOrderPanel()
        ' Step 1: Get all panels from the FlowLayoutPanel
        Dim panels As List(Of Panel) = fPanelOrders.Controls.OfType(Of Panel).ToList()

        ' Step 2: Sort the panels based on their Tag property
        panels.Sort(Function(x, y) String.Compare(CStr(x.Tag), CStr(y.Tag)))

        ' Step 3: Clear the FlowLayoutPanel
        fPanelOrders.Controls.Clear()

        ' Step 4: Add the sorted panels back to the FlowLayoutPanel
        For Each panel As Panel In panels
            fPanelOrders.Controls.Add(panel)
        Next
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim allPanels = fPanelOrders.Controls.OfType(Of Panel).ToList()
        Dim searchText As String = txtSearch.Text.ToLower()
        Dim suggestions = allPanels.Where(Function(p) CType(p.Tag, Order).OrderName.ToLower().Contains(searchText)).ToList()

        ' Update ListBox with matching tags
        LbSuggestions.Items.Clear()
        LbSuggestions.Items.AddRange(suggestions.Select(Function(p) CType(p.Tag, Order).OrderName).ToArray())
        LbSuggestions.Visible = LbSuggestions.Items.Count > 0
    End Sub

    ' Step 3: Move the selected panel to the top when a suggestion is clicked
    Private Sub LbSuggestions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbSuggestions.SelectedIndexChanged
        Dim selectedTag As String = CStr(LbSuggestions.SelectedItem)

        ' Find the matching panel by its tag
        Dim panelToMove = allPanels.FirstOrDefault(Function(p) CType(p.Tag, Order).OrderName = selectedTag)
        If panelToMove IsNot Nothing Then
            ' Move the panel to the top of the FlowLayoutPanel
            fPanelOrders.Controls.SetChildIndex(panelToMove, 0)
        End If

        ' Hide the suggestions after selection
        txtSearch.Clear()
        LbSuggestions.Visible = False
    End Sub
End Class