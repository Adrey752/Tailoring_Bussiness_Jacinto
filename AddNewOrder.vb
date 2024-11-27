Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.ApplicationServices
Imports Mysqlx.XDevAPI
Imports ZstdSharp.Unsafe

Public Class AddNewOrder
    Dim client_id As Integer
    Dim client As Client
    Dim order As Order
    Dim _ProjectDetailsForm As ProjectDetailsForm
    Dim _home As Home
    Dim _login As login
    Dim SelectedOrder As Order
    Private selectedPanelIndex As Integer
    Private selectedPanels As New List(Of Integer)()
    Private ctrlKeyPressed As Boolean = False
    Dim selected = False
    Private ReadOnly Property allPanels As List(Of Panel)
        Get
            Return fPanelOrders.Controls.OfType(Of Panel).ToList()
        End Get
    End Property


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
            For Each panel As Panel In allPanels
                Dim order = CType(panel.Tag, Order)
                orders.Add(order)
            Next
            Return orders
        End Get
    End Property
    Public Sub New(client As Client, _ProjectForm As ProjectDetailsForm, _home As Home, _login As login)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.client = client
        Me.client_id = client.client_Id
        Me._ProjectDetailsForm = _ProjectForm
        Me._home = _home
        Me._login = _login
        Me.order = New Order(1, "", "", "", 1, My.Resources.noImageIcon, Date.Now, New List(Of Measurement), "Pending", -1)

    End Sub
    Private Sub AddNewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMeasurementsType()
        LoadGarmentTypes()
    End Sub





    Private Sub SaveEdit(OrderToEdit As Order, PanelToEdit As OrderPanel)
        OrderToEdit.OrderName = tbOrderName.Text
        OrderToEdit.Type = cbStype.Text
        OrderToEdit.Price = nudPrice.Value
        OrderToEdit.Description = rbDescription.Text
        OrderToEdit.Sizes.Clear()
        For Each row As DataGridViewRow In dgMeasurements.Rows
            If row.Tag IsNot Nothing Then
                Dim size As Measurement = CType(row.Tag, Measurement)
                OrderToEdit.Sizes.Add(size)
            End If
        Next
        PanelToEdit.UpdateUI()

    End Sub
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

        Me.order = New Order(0, "", "", "", 0, My.Resources.noImageIcon, Date.Now, New List(Of Measurement), "Pending", -1)

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

    Private Sub ShowOrderDetails(order As Order)

        tbOrderName.Text = order.OrderName
        cbStype.Text = order.Type
        nudPrice.Value = order.Price
        rbDescription.Text = order.Description
        AddMeasurementsToDatagrid(order.Sizes)

    End Sub

    Private Sub ReloadForm()
        Me.order = New Order(0, "", "", "", 0, My.Resources.noImageIcon, Date.Now, New List(Of Measurement), "Pending", -1)
        tbOrderName.Text = HandleSameName(tbOrderName.Text)

    End Sub

    '   ****** Setting Up Functions *******

    Private Sub AddMeasurementsToDatagrid(sizes As List(Of Measurement))

        For Each size As Measurement In sizes
            Dim rowIndex As Integer = dgMeasurements.Rows.Add(size.BodyPart, (size.Value & " " & size.Unit), size.garment)
            dgMeasurements.Rows(rowIndex).Tag = size
        Next
    End Sub
    ' ******* Helper Functions *******
    Private Sub ClearForm()
        tbOrderName.Clear()
        nudPrice.Value = 0
        rbDescription.Clear()
        nudValue.Value = 0
        dgMeasurements.Rows.Clear()
    End Sub

    Private Shared Function ValidIndexRange(index As Integer, upperLimit As Integer) As Boolean
        If index >= upperLimit Or index < 0 Then
            Return False
        End If
        Return True
    End Function





    '*********** HELPER FUNCTIONS BELOW NG MGA WHATT ***************






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

        ' Return the newly inserted order_id
        Return Convert.ToInt32(MySQLModule.ExecuteScalar(orderQuery, orderParams))
    End Function

    Private Function ImageToBinary(image As Image) As Byte()
        Using ms As New MemoryStream
            image.Save(ms, image.RawFormat)
            Return ms.ToArray()
        End Using
    End Function

    Public Sub InsertSize(size As Measurement, orderId As Integer)
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





    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Close()
        _ProjectDetailsForm.Close()
        _home.Show()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close()
        _ProjectDetailsForm.Close()
        _home.Hide()
        _login.Show()


    End Sub
    Private Sub AddNewOrder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _ProjectDetailsForm.Show()
    End Sub


    Private Sub btnOrderSave_Click_1(sender As Object, e As EventArgs) Handles btnOrderSave.Click

        If tbOrderName.Text <> "" Then
            AddOrder()
        End If
        For Each order In ListOrders
            Dim orderId = InsertOrder(order, client_id)
            For Each size As Measurement In order.Sizes
                InsertSize(size, orderId)
            Next
        Next
        _ProjectDetailsForm.dgSortOrders.Rows.Clear()
        _ProjectDetailsForm.LoadClient(client_id)
        Close()
    End Sub
    Private Sub addMeasurement_Click(sender As Object, e As EventArgs) Handles btnaddMeasurement.Click
        Dim measurementType = sbMType.Text
        Dim value = nudValue.Value
        Dim unit = cbUnit.Text
        Dim garment = cbGarment.Text
        Dim measurement = New Measurement(measurementType, value, unit, garment)

        Dim rowIndex = dgMeasurements.Rows.Add(measurementType, value & " " & unit, garment)
        dgMeasurements.Rows(rowIndex).Tag = measurement
    End Sub
    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        Dim OpenFileDialog = New OpenFileDialog
        OpenFileDialog.Filter = "Image ile |*.jpg;, *.jpeg;, *.png;, *.svg; *.bmp;"
        If OpenFileDialog.ShowDialog = DialogResult.OK Then
            OrderPicturebox.Image = Image.FromFile(OpenFileDialog.FileName)
        End If
    End Sub
    'Private Sub SortOrderPanel()

    '    Dim panels As List(Of Panel) = fPanelOrders.Controls.OfType(Of Panel).ToList()

    '    panels.Sort(Function(x, y) String.Compare(CStr(x.Tag), CStr(y.Tag)))

    '    fPanelOrders.Controls.Clear()


    '    For Each panel As Panel In panels
    '        fPanelOrders.Controls.Add(panel)
    '    Next
    'End Sub
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim allPanels = fPanelOrders.Controls.OfType(Of Panel).ToList
        Dim searchText = txtSearch.Text.ToLower
        Dim suggestions = allPanels.Where(Function(p) CType(p.Tag, Order).OrderName.ToLower.Contains(searchText)).ToList

        ' Update ListBox with matching tags
        LbSuggestions.Items.Clear()
        LbSuggestions.Items.AddRange(suggestions.Select(Function(p) CType(p.Tag, Order).OrderName).ToArray)
        LbSuggestions.Visible = LbSuggestions.Items.Count > 0
    End Sub

    ' Step 3: Move the selected panel to the top when a suggestion is clicked
    Private Sub LbSuggestions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbSuggestions.SelectedIndexChanged
        Dim selectedTag = CStr(LbSuggestions.SelectedItem)

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

    Private Sub btnRemoveImage_Click_1(sender As Object, e As EventArgs) Handles btnRemoveImage.Click
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
End Class