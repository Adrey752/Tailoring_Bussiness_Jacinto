Imports Mysqlx.XDevAPI

Public Class AddOrder
    Dim client As Client
    Dim order As Order
    Dim _addClientForm As AddClientForm
    Private selectedPanelIndex As Integer = -1


    Private ReadOnly Property AllPanelsInFlowPane As List(Of Panel)
        Get
            Return fPanelOrders.Controls.OfType(Of Panel).ToList()
        End Get
    End Property

    Private ReadOnly Property ListOrders As List(Of Order)
        Get
            Dim orders As New List(Of Order)
            For Each panel As Panel In AllPanelsInFlowPane
                Dim order = CType(panel.Tag, Order)
                orders.Add(order)
            Next
            Return orders
        End Get
    End Property
    Private ReadOnly Property ListSizes As List(Of Size)
        Get
            Dim sizes As New List(Of Size)
            For Each row As DataGridViewRow In dgMeasurements.Rows
                Dim size = CType(row.Cells(0).Tag, Size)
                sizes.Add(size)
            Next
            Return sizes
        End Get
    End Property
    Public Sub New(client As Client, orderForm As AddClientForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.client = client
        Me.order = New Order(0, "", "", "", 0, False, New List(Of Size), "Pending")
        Me._addClientForm = orderForm
        LoadMeasurementsType()

    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        order.OrderName = tbOrderName.Text
        order.Type = cbStype.Text
        order.Price = nudPrice.Value
        order.Description = rbDescription.Text
        AddOrderToFlowPane(order)
        order.Sizes = ListSizes
        dgMeasurements.Rows.Clear()
        Me.order = New Order(1, "", "", "", 1, False, New List(Of Size), "Pending")
    End Sub


    Private Sub btnOrderSave_Click(sender As Object, e As EventArgs) Handles btnOrderSave.Click
        For Each order In ListOrders
            client.addOrder(order)
        Next
        Me.Close()
    End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim AllPanelsInFlowPane = fPanelOrders.Controls.OfType(Of Panel).ToList()
        Dim searchText As String = txtSearch.Text.ToLower()
        Dim suggestions = AllPanelsInFlowPane.Where(Function(p) CType(p.Tag, Order).OrderName.ToLower().Contains(searchText)).ToList()

        ' Update ListBox with matching tags
        LbSuggestions.Items.Clear()
        LbSuggestions.Items.AddRange(suggestions.Select(Function(p) CType(p.Tag, Order).OrderName).ToArray())
        LbSuggestions.Visible = LbSuggestions.Items.Count > 0
    End Sub

    ' Step 3: Move the selected panel to the top when a suggestion is clicked
    Private Sub LbSuggestions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbSuggestions.SelectedIndexChanged
        Dim selectedTag = CStr(LbSuggestions.SelectedItem)

        ' Find the matching panel by its tag
        Dim panelToMove = AllPanelsInFlowPane.FirstOrDefault(Function(p) CType(p.Tag, Order).OrderName = selectedTag)
        If panelToMove IsNot Nothing Then
            ' Move the panel to the top of the FlowLayoutPanel
            fPanelOrders.Controls.SetChildIndex(panelToMove, 0)
        End If

        ' Hide the suggestions after selection
        txtSearch.Clear()
        LbSuggestions.Visible = False
    End Sub

    Private Sub addMeasurement_Click(sender As Object, e As EventArgs) Handles btnaddMeasurement.Click
        Dim measurementType = sbMType.Text
        Dim value = nudValue.Value
        Dim unit = cbUnit.Text
        Dim garment = cbGarment.Text
        Dim measurement = New Size(measurementType, value, unit, garment)

        'order.AddSize(measurement)

        Dim rowIndex = dgMeasurements.Rows.Add(measurementType, (value & unit), garment)
        dgMeasurements.Rows(rowIndex).Cells(0).Tag = measurement
    End Sub


    Public Sub AddOrderToFlowPane(order As Order)

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

        lblOrderName.Enabled = False
        lblServiceType.Enabled = False


        projectPanel.Controls.Add(lblOrderName)
        projectPanel.Controls.Add(lblServiceType)
        projectPanel.Controls.Add(checkBox)

        projectPanel.BackColor = Color.FromArgb(217, 185, 155)
        projectPanel.ForeColor = Color.Black


        AddHandler projectPanel.Click, AddressOf Order_Panel_Click

        fPanelOrders.Controls.Add(projectPanel)
    End Sub

    '********** HELPLER FUNCTIONS NI Adrial ***********



    Private Sub LoadMeasurementsType()
        Dim query = "SELECT types FROM size_types"
        Dim dataTable = MySQLModule.ExecuteQuery(query, New Dictionary(Of String, Object))

        For Each row As DataRow In dataTable.Rows
            sbMType.Items.Add(row("types").ToString())
        Next
    End Sub
    ' easter egg
    Private Sub LoadGarmentTypes()
        Dim query As String = "SELECT garment_type FROM garment_types"
        Dim parameter As New Dictionary(Of String, Object)
        Dim datatable As DataTable = MySQLModule.ExecuteQuery(query, parameter)

        For Each row As DataRow In datatable.Rows
            cbGarment.Items.Add(row("garment_type").ToString())
        Next

    End Sub

    Private Sub AddOrder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _addClientForm.Show()
    End Sub

    Dim selected = True
    Private Sub SelectPanel(index As Integer)
        ' Deselect previous panel
        If selectedPanelIndex >= 0 AndAlso selectedPanelIndex < fPanelOrders.Controls.Count Then
            fPanelOrders.Controls(selectedPanelIndex).BackColor = Color.FromArgb(217, 185, 155)
        End If

        ' Select the new panel
        If index = selectedPanelIndex Then
            If selected Then
                fPanelOrders.Controls(selectedPanelIndex).BackColor = Color.FromArgb(217, 185, 155)
                selected = False
            Else
                fPanelOrders.Controls(selectedPanelIndex).BackColor = Color.Gray
                selected = True
            End If
            Exit Sub
        End If
        selectedPanelIndex = index

        Dim panel = fPanelOrders.Controls(selectedPanelIndex)
        Dim objectTaged = panel.Tag
        panel.BackColor = Color.Gray
    End Sub

    Private Sub Order_Panel_Click(sender As Object, e As EventArgs)
        Dim Panel = TryCast(sender, Panel)
        If Panel IsNot Nothing Then
            Dim panelIndex = fPanelOrders.Controls.GetChildIndex(Panel)
            SelectPanel(panelIndex)
        End If
    End Sub

    Private Sub ShowOrderDetailsn(order As Order)
        tbOrderName.Text = order.OrderName
        cbStype.Text = order.Type
        nudPrice.Value = order.Price
        rbDescription.Text = order.Description
        AddMeasurementsToDatagrid(order.Sizes)

    End Sub

    Private Sub AddMeasurementsToDatagrid(sizes As List(Of Size))
        For Each size As Size In sizes
            dgMeasurements.Rows.Add(size.BodyPart, (size.Value & size.Unit), size.garment)
        Next
    End Sub

    Private Sub AddOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Focus
    End Sub


End Class