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
    Dim _home As Home
    Dim _login As login
    Dim SelectedOrder As Order
    Private selectedPanelIndex As Integer
    Private selectedPanels As New List(Of Integer)()
    Private ctrlKeyPressed As Boolean = False
    Dim selected = False

    Private ReadOnly Property OrderNames As List(Of String)
        Get
            Dim names As New HashSet(Of String)

            ' Add order names from client orders
            For Each order As Order In client.Orders
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


    Public Sub New(login As login, home As Home, client As Client, orderForm As AddClientForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.client = client
        Me.order = New Order(0, "", "", "", 0, My.Resources.noImageIcon, Date.Now, New List(Of Measurement), "Pending", -1)
        Me._addClientForm = orderForm
        Me._home = home
        Me._login = login
        LoadMeasurementsType()
        Dim ClothingSizes = GetSizesInDb()
        cbSizes.Items.AddRange(ClothingSizes.ToArray)

    End Sub
    Private Function GetSizesInDb() As List(Of ClothingSize)
        Dim list As New List(Of ClothingSize)

        Dim query = "SELECT * FROM clothing_size"
        Dim parameter As New Dictionary(Of String, Object)

        Dim datatable = MySQLModule.ExecuteQuery(query, parameter)

        For Each row As DataRow In datatable.Rows
            Dim id As Integer = row.Field(Of Integer)("id")
            Dim name As String = row.Field(Of String)("name")

            Dim newClothingSize As New ClothingSize(name)
            newClothingSize.Id = id
            list.Add(newClothingSize)

        Next
        Return list
    End Function
    ' ****** Buttons or Input Handlers  ********

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ValidateFieds() = True Then

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
        fPanelOrders.Controls.Add(OrderPanel)
        numberOfOrdersDisplay()

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
        _addClientForm._Forward = Nothing
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
        Dim OrderPanel = TryCast(sender, OrderPanel)
        If OrderPanel IsNot Nothing Then
            SelectPanel(OrderPanel)

        End If
    End Sub


    Private Sub SelectPanel(orderPanel As OrderPanel)
        Dim OrderPanelsCount = fPanelOrders.Controls.Count
        Dim orderPanelIndex = fPanelOrders.Controls.GetChildIndex(orderPanel)

        ctrlKeyPressed = (Control.ModifierKeys And Keys.Control) = Keys.Control

        If ValidIndexRange(orderPanelIndex, OrderPanelsCount) Then

            ' clicking panels when ctrl keys is pressed
            If ctrlKeyPressed Then
                If selectedPanels.Contains(orderPanelIndex) Then
                    UnselectMethod(orderPanel)
                Else
                    SelectMethod(orderPanel)
                End If
                ' When clicking panels when ctrke is not pressed
            ElseIf ctrlKeyPressed = False Then
                If ValidIndexRange(selectedPanelIndex, fPanelOrders.Controls.Count) AndAlso orderPanelIndex <> selectedPanelIndex Then
                    Dim previouslySelected = fPanelOrders.Controls(selectedPanelIndex)
                    UnselectMethod(previouslySelected)

                End If
                If selectedPanels.Count > 1 Then
                    UnselectAllPanelsSelected()
                Else

                End If

                If selectedPanelIndex = orderPanelIndex Then
                    If selected Then
                        UnselectMethod(orderPanel)
                    Else
                        SelectMethod(orderPanel)
                    End If
                Else
                    SelectMethod(orderPanel)
                    selectedPanelIndex = orderPanelIndex
                End If
            End If

            numberOfOrdersDisplay()
        End If

    End Sub

    Private Sub UnselectAllPanelsSelected()
        For Each index In selectedPanels.ToList()
            Dim orderPanel = TryCast(fPanelOrders.Controls(index), OrderPanel)
            UnselectMethod(orderPanel)
        Next
    End Sub




    Private Sub SelectMethod(selectedPanel As OrderPanel)
        Dim index = fPanelOrders.Controls.GetChildIndex(selectedPanel)
        Dim SelectedOrder = selectedPanel.Tag
        selectedPanel.BackColor = Color.Gray
        ShowOrderDetails(SelectedOrder)
        btnAdd.Text = "Save Edit"
        selected = True
        selectedPanel.checkBox.Checked = True
        selectedPanels.Add(index)
    End Sub
    Private Sub numberOfOrdersDisplay()
        If selectedPanels.Count > 0 Then
            lblOrders.Text = "Selected Orders: " & selectedPanels.Count
        ElseIf ListOrders.Count = 1 Then
            lblOrders.Text = "1 order added"
        ElseIf ListOrders.Count > 1 Then
            lblOrders.Text = ListOrders.Count & " orders added"
        End If
    End Sub
    Private Sub UnselectMethod(selectedPanel As OrderPanel)
        Dim index = fPanelOrders.Controls.GetChildIndex(selectedPanel)
        selectedPanel.BackColor = Color.FromArgb(217, 185, 155)
        selected = False
        btnAdd.Text = "Add +"
        SelectedOrder = Nothing
        selectedPanel.checkBox.Checked = False
        selectedPanels.Remove(index)
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




    Private Sub DeleteSelectedPanels() Handles btnDelete.Click
        ' Iterate in reverse handling index shift when deleting
        For Each index In selectedPanels.OrderByDescending(Function(i) i)
            If index >= 0 AndAlso index < fPanelOrders.Controls.Count Then
                fPanelOrders.Controls.RemoveAt(index)
            End If
        Next
        selectedPanels.Clear()
    End Sub

    Private Shared Function ValidIndexRange(index As Integer, upperLimit As Integer) As Boolean
        If index >= upperLimit Or index < 0 Then
            Return False
        End If
        Return True
    End Function

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        _addClientForm.Close()
        _home.Show()


    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Dim settings As New Settings(Me, _login, _home)
        Me.Hide()
        settings.Show()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Close()
        _addClientForm.Close()
        _home.Hide()
        _login.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        _addClientForm._Forward = Me
        Me.Hide()
        _addClientForm.Show()

    End Sub
End Class