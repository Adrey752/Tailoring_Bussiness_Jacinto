﻿Imports System.ComponentModel.Design.ObjectSelectorEditor
Imports System.IO
Imports Microsoft.VisualBasic.ApplicationServices
Imports Mysqlx.XDevAPI

Public Class AddNewOrder
    Dim client_id As Integer
    Dim order As Order
    Dim _ProjectDetailsForm As ProjectDetailsForm
    Dim SelectedOrder As Order
    Private selectedPanelIndex As Integer
    Dim selected = False
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
    Public Sub New(client_id As Integer, _ProjectForm As ProjectDetailsForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.client_id = client_id
        Me._ProjectDetailsForm = _ProjectForm
        Me.order = New Order(1, "", "", "", 1, My.Resources.noImageIcon, Date.Now, New List(Of Measurement), "Pending", -1)

    End Sub
    Private Sub AddNewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMeasurementsType()
        LoadGarmentTypes()
    End Sub




    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If SelectedOrder IsNot Nothing Then
            Dim SelectedPanel = fPanelOrders.Controls(selectedPanelIndex)
            SaveEdit(SelectedOrder, SelectedPanel)
            UnselectMethod(SelectedPanel)

        Else
            AddOrder()

        End If


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
        ClearForm()
    End Sub
    Private Sub btnOrderSave_Click(sender As Object, e As EventArgs) Handles btnOrderSave.Click

        If tbOrderName.Text <> "" Then
            AddOrder()
        End If
        For Each order In ListOrders
            Dim orderId = InsertOrder(order, client_id)
            For Each Size As Measurement In order.Sizes
                InsertSize(Size, orderId)
            Next
        Next
        _ProjectDetailsForm.dgSortOrders.Rows.Clear()
        _ProjectDetailsForm.LoadClient(client_id)
        Me.Close()

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

    Private Sub ShowOrderDetails(order As Order)

        tbOrderName.Text = order.OrderName
        cbStype.Text = order.Type
        nudPrice.Value = order.Price
        rbDescription.Text = order.Description
        AddMeasurementsToDatagrid(order.Sizes)

    End Sub


    '   ****** Setting Up Functions *******

    Private Sub AddMeasurementsToDatagrid(sizes As List(Of Measurement))
        If sizes.Count = 0 Then
            MessageBox.Show("empty sizes")
        End If
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

    '*********** HELPER FUNCTIONS BELOW NG MGA WHATT ***************

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

    Private Sub AddNewOrder_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _ProjectDetailsForm.Show()
    End Sub


    Private Sub addMeasurement_Click(sender As Object, e As EventArgs) Handles btnaddMeasurement.Click
        Dim measurementType = sbMType.Text
        Dim value = nudValue.Value
        Dim unit = cbUnit.Text
        Dim garment = cbGarment.Text
        Dim measurement = New Measurement(measurementType, value, unit, garment)

        Dim rowIndex As Integer = dgMeasurements.Rows.Add(measurementType, (value & " " & unit), garment)
        dgMeasurements.Rows(rowIndex).Tag = measurement
    End Sub


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

    Private Sub btnAddImage_Click(sender As Object, e As EventArgs) Handles btnAddImage.Click
        Dim OpenFileDialog = New OpenFileDialog
        OpenFileDialog.Filter = "Image ile |*.jpg;, *.jpeg;, *.png;, *.svg; *.bmp;"
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            OrderPicturebox.Image = Image.FromFile(OpenFileDialog.FileName)
        End If
    End Sub

    Private Sub btnRemoveImage_Click(sender As Object, e As EventArgs) Handles btnRemoveImage.Click
        OrderPicturebox.Image = My.Resources.noImageIcon
    End Sub

    Private Sub pnAddOrders_Paint(sender As Object, e As PaintEventArgs) Handles pnAddOrders.Paint

    End Sub

    Private Sub lblServiceType_Click(sender As Object, e As EventArgs) Handles lblServiceType.Click

    End Sub
End Class