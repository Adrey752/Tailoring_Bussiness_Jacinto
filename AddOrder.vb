Imports System.Diagnostics.CodeAnalysis
Imports System.Net.NetworkInformation
Imports System.Text.RegularExpressions
Imports Mysqlx.Crud
Imports Mysqlx.XDevAPI
Imports Windows.Win32.UI.Input

Public Class AddOrder

    Dim client As Client
    Dim order As Order
    Dim _addClientForm As AddClientForm
    Dim SelectedOrder As Order
    Dim selectedCount As Integer = 0
    Private selectedPanelIndex As Integer
    Dim selected = False

    Private ReadOnly Property OrderNames As List(Of String)
        Get
            Dim names As New HashSet(Of String)

            ' Add order names from client orders
            For Each order As Order In client.Orders
                MessageBox.Show("Adding from client.orders: " & order.OrderName)
                names.Add(order.OrderName)
            Next

            ' Add order names from staged orders in the panel
            For Each panel As Panel In AllPanelsInFlowPane
                Dim order = CType(panel.Tag, Order)
                names.Add(order.OrderName)
            Next


            Return names.ToList()
        End Get
    End Property


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


    Public Sub New(client As Client, orderForm As AddClientForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.client = client
        Me.order = New Order(0, "", "", "", 0, My.Resources.noImageIcon, Date.Now, New List(Of Measurement), "Pending", -1)
        Me._addClientForm = orderForm
        LoadMeasurementsType()

    End Sub

    ' ****** Buttons or Input Handlers  ********

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If validateFieds() = True Then

            If SelectedOrder IsNot Nothing Then
                Dim SelectedPanel = fPanelOrders.Controls(selectedPanelIndex)
                SaveEdit(SelectedOrder, SelectedPanel)
                UnselectMethod(SelectedPanel)

            Else
                AddOrder()

            End If
            ReloadForm()
        End If


    End Sub
    Private Function HandleSameName(orderName As String) As String
        Dim result = ""
        'For Each name As String In OrderNames
        '    MessageBox.Show(name)
        'Next
        If OrderNames.Contains(orderName) Then
            Dim match As Match = Regex.Match(orderName, "\d+$")
            If match.Success Then

                Dim number As Integer = match.Value + 1
                result = Regex.Replace(orderName, "\d+$", number.ToString)
            Else
                result = orderName & "1"

            End If
        End If
        Return result
    End Function
    Private Function ValidateFieds() As Boolean
        Dim listOfEmptyFields As New List(Of String)

        If OrderNames.Contains(tbOrderName.Text) Then
            MessageBox.Show("Name already in use!", "Duplicate Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbOrderName.Text = HandleSameName(tbOrderName.Text)
            tbOrderName.Focus()
            Return False
        End If

        If String.IsNullOrEmpty(tbOrderName.Text.Trim()) Then
            listOfEmptyFields.Add("Order Name")
        End If

        If nudPrice.Value = 0 Then
            listOfEmptyFields.Add("Price")
        End If

        If listOfEmptyFields.Count > 0 Then
            MessageBox.Show("The following fields cannot be blank: " & String.Join(", ", listOfEmptyFields), "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            If listOfEmptyFields.Contains("Order Name") Then
                tbOrderName.Focus()
            ElseIf listOfEmptyFields.Contains("Price") Then
                nudPrice.Focus()
            End If

            Return False
        End If

        Return True
    End Function


    Private Sub AddOrder()
        order.OrderName = tbOrderName.Text
        order.Type = cbStype.Text
        order.Price = nudPrice.Value
        order.Description = rbDescription.Text
        order.OrderImage = OrderPicturebox.Image
        order.DateOrdered = dtpOrderDate.Value

        order.Sizes.Clear()
        For Each row As DataGridViewRow In dgMeasurements.Rows
            If row.Tag IsNot Nothing Then
                Dim size As Measurement = CType(row.Tag, Measurement)
                order.Sizes.Add(size)
            End If
        Next

        Dim OrderPanel = New OrderPanel(order)
        AddHandler OrderPanel.Click, AddressOf Order_Panel_Click
        AddHandler OrderPanel.CheckBoxStateChanged, AddressOf UpdateSelectedCount
        fPanelOrders.Controls.Add(OrderPanel)
        numberOfOrdersDisplay()

    End Sub
    Private Sub UpdateSelectedCount(sender As Object, e As EventArgs)
        ' Cast sender to OrderPanel to access the checkbox state
        Dim orderPanel As OrderPanel = CType(sender, OrderPanel)

        If orderPanel.checkBox.Checked Then
            selectedCount += 1
        Else
            selectedCount -= 1
        End If

        ' Update the label with the new selected count
        lblOrders.Text = "Selected Orders: " & selectedCount
    End Sub
    Private Sub ReloadForm()
        Me.order = New Order(0, "", "", "", 0, My.Resources.noImageIcon, Date.Now, New List(Of Measurement), "Pending", -1)
        tbOrderName.Text = HandleSameName(tbOrderName.Text)

    End Sub
    Private Sub addMeasurement_Click(sender As Object, e As EventArgs) Handles btnaddMeasurement.Click
        Dim measurementType = sbMType.Text
        Dim value = nudValue.Value
        Dim unit = cbUnit.Text
        Dim garment = cbGarment.Text
        Dim measurement = New Measurement(measurementType, value, unit, garment)

        ' Add row to DataGridView with Size Tag 
        Dim rowIndex = dgMeasurements.Rows.Add(measurementType, value & " " & unit, garment)
        dgMeasurements.Rows(rowIndex).Tag = measurement
    End Sub
    Private Sub SaveEdit(OrderToEdit As Order, PanelToEdit As OrderPanel)
        OrderToEdit.OrderName = tbOrderName.Text
        OrderToEdit.Type = cbStype.Text
        OrderToEdit.Price = nudPrice.Value
        OrderToEdit.Description = rbDescription.Text
        OrderToEdit.OrderImage = OrderPicturebox.Image
        OrderToEdit.DateOrdered = dtpOrderDate.Value

        OrderToEdit.Sizes.Clear()
        For Each row As DataGridViewRow In dgMeasurements.Rows
            If row.Tag IsNot Nothing Then
                Dim size As Measurement = CType(row.Tag, Measurement)
                OrderToEdit.Sizes.Add(size)

            End If
        Next
        PanelToEdit.UpdateUI()
    End Sub

    Private Sub btnOrderSave_Click(sender As Object, e As EventArgs) Handles btnOrderSave.Click
        If tbOrderName.Text <> "" Then
            AddOrder()
        End If
        For Each order In ListOrders
            client.addOrder(order)
        Next
        Me.Close()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim AllPanelsInFlowPane = fPanelOrders.Controls.OfType(Of Panel).ToList()
        Dim searchText As String = txtSearch.Text.ToLower()
        Dim suggestions = AllPanelsInFlowPane.Where(Function(p) CType(p.Tag, Order).OrderName.ToLower().Contains(searchText)).ToList()


        LbSuggestions.Items.Clear()
        LbSuggestions.Items.AddRange(suggestions.Select(Function(p) CType(p.Tag, Order).OrderName).ToArray())
        LbSuggestions.Visible = LbSuggestions.Items.Count > 0
    End Sub

    Private Sub AddOrder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _addClientForm.Show()
    End Sub



    Public Sub Order_Panel_Click(sender As Object, e As EventArgs)
        Dim Panel = TryCast(sender, Panel)
        If Panel IsNot Nothing Then
            Dim panelIndex = fPanelOrders.Controls.GetChildIndex(Panel)

            SelectPanel(panelIndex)

        End If
    End Sub
    Private Sub SelectPanel(index As Integer)
        Dim OrderPanelsCount = fPanelOrders.Controls.Count

        ' unselect previously selected panel if it's not the same as current clicked panel
        If ValidIndexRange(selectedPanelIndex, OrderPanelsCount) AndAlso index <> selectedPanelIndex Then
            Dim previousSelectedPanel = fPanelOrders.Controls(selectedPanelIndex)
            UnselectMethod(previousSelectedPanel)
        End If

        If ValidIndexRange(index, OrderPanelsCount) Then

            Dim panelClicked = fPanelOrders.Controls(index)
            SelectedOrder = panelClicked.Tag
            'When clicking the same panel
            If selectedPanelIndex = index Then
                If selected Then
                    UnselectMethod(panelClicked)

                Else
                    SelectMethod(panelClicked, SelectedOrder)

                End If
            Else
                ' when clicking different panel
                SelectMethod(panelClicked, SelectedOrder)
                selectedPanelIndex = index
            End If
        End If

    End Sub

    Private Shared Function ValidIndexRange(index As Integer, upperLimit As Integer) As Boolean
        If index >= upperLimit Or index < 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub SelectMethod(selectedPanel As Panel, selectedOrder As Order)
        selectedPanel.BackColor = Color.Gray
        ShowOrderDetails(selectedOrder)
        btnAdd.Text = "Save Edit"
        selected = True
    End Sub
    Private Sub UnselectMethod(selectedPanel As Panel)
        selectedPanel.BackColor = Color.FromArgb(217, 185, 155)
        selected = False
        btnAdd.Text = "Add +"
        SelectedOrder = Nothing
        ClearForm()
    End Sub

    ' ******* Helper Functions *******
    Private Sub ClearForm()
        tbOrderName.Clear()
        nudPrice.Value = 0
        rbDescription.Clear()
        nudValue.Value = 0
        dgMeasurements.Rows.Clear()
        OrderPicturebox.Image = My.Resources.noImageIcon
    End Sub


    Private Sub LbSuggestions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbSuggestions.SelectedIndexChanged

        Dim selectedTag = CStr(LbSuggestions.SelectedItem)

        ' Find matching panel by it's tag
        Dim panelToMove = AllPanelsInFlowPane.FirstOrDefault(Function(p) CType(p.Tag, Order).OrderName = selectedTag)
        'isang pitik sa itlog pag may nakita kang bug
        If panelToMove IsNot Nothing Then
            ' Move the panel to top of the FlowLayoutPanel
            fPanelOrders.Controls.SetChildIndex(panelToMove, 0)
        End If

        ' Hide suggestions after selection
        txtSearch.Clear()
        LbSuggestions.Visible = False
    End Sub

    Private Sub ShowOrderDetails(order As Order)

        tbOrderName.Text = order.OrderName
        cbStype.Text = order.Type
        nudPrice.Value = order.Price
        rbDescription.Text = order.Description
        OrderPicturebox.Image = order.OrderImage
        AddMeasurementsToDatagrid(order.Sizes)


    End Sub


    '   ****** Setting Up Functions *******

    Private Sub AddMeasurementsToDatagrid(sizes As List(Of Measurement))
        For Each size As Measurement In sizes
            Dim rowIndex As Integer = dgMeasurements.Rows.Add(size.BodyPart, (size.Value & " " & size.Unit), size.garment)
            dgMeasurements.Rows(rowIndex).Tag = size
        Next
    End Sub





    '********** SQl FUNCTIONS NI Adrial ***********

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        Dim openFileDialog = New OpenFileDialog
        openFileDialog.Filter = "Image File |*.jpg;, *.png;, *.jpeg;, *.bmp;"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            OrderPicturebox.Image = Image.FromFile(openFileDialog.FileName)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles OrderPicturebox.Click

    End Sub

    Private Sub btnRemoveImage_Click(sender As Object, e As EventArgs) Handles btnRemoveImage.Click
        OrderPicturebox.Image = My.Resources.noImageIcon
    End Sub


    Private Sub numberOfOrdersDisplay()
        If ListOrders.Count = 1 Then
            lblOrders.Text = "1 order added"
        ElseIf ListOrders.Count > 1 Then
            lblOrders.Text = ListOrders.Count & " orders added"
        End If
    End Sub




    '********** Di ko narin yata to gagamitin yung mga ito pero itatabi ko lang ********

    'Public Sub AddOrderToFlowPane(order As Order)

    '    Dim projectPanel As New Panel
    '    projectPanel.Height = 80
    '    projectPanel.Width = 200
    '    projectPanel.Margin = New Padding(10)

    '    Dim lblOrderName As New Label
    '    lblOrderName.Text = "Order Name: " & order.OrderName
    '    lblOrderName.Location = New Point(10, 10)

    '    Dim lblServiceType As New Label
    '    lblServiceType.Text = "Service Type: " & order.Type
    '    lblServiceType.Location = New Point(10, 30)



    '    Dim checkBox As New CheckBox
    '    checkBox.Location = New Point(projectPanel.Width - 40, 30)
    '    projectPanel.Tag = order

    '    lblServiceType.AutoSize = True
    '    lblOrderName.AutoSize = True

    '    lblOrderName.Enabled = False
    '    lblServiceType.Enabled = False


    '    projectPanel.Controls.Add(lblOrderName)
    '    projectPanel.Controls.Add(lblServiceType)
    '    projectPanel.Controls.Add(checkBox)

    '    projectPanel.BackColor = Color.FromArgb(217, 185, 155)
    '    projectPanel.ForeColor = Color.Black


    '    AddHandler projectPanel.Click, AddressOf Order_Panel_Click

    '    fPanelOrders.Controls.Add(projectPanel)
    'End Sub




End Class