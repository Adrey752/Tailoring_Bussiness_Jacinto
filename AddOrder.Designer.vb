﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnOrderSave = New Button()
        nudValue = New NumericUpDown()
        btnaddMeasurement = New Button()
        cbUnit = New ComboBox()
        sbMType = New ComboBox()
        Label1 = New Label()
        cbStype = New ComboBox()
        cbGarment = New ComboBox()
        tbOrderName = New TextBox()
        lblorderName = New Label()
        lblDesc = New Label()
        rbDescription = New RichTextBox()
        lblSize = New Label()
        dgMeasurements = New DataGridView()
        size_type = New DataGridViewTextBoxColumn()
        measurement = New DataGridViewTextBoxColumn()
        GarmentType = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        nudPrice = New NumericUpDown()
        pnAddOrders = New Panel()
        Label5 = New Label()
        Panel3 = New Panel()
        dtpOrderDate = New DateTimePicker()
        btnAddImage = New Button()
        btnRemoveImage = New Button()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        btnCancel = New Button()
        btnAdd = New Button()
        OrderPicturebox = New PictureBox()
        Panel2 = New Panel()
        Panel1 = New Panel()
        LbSuggestions = New ListBox()
        fPanelOrders = New FlowLayoutPanel()
        lblOrders = New Label()
        txtSearch = New TextBox()
        CType(nudValue, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).BeginInit()
        pnAddOrders.SuspendLayout()
        Panel3.SuspendLayout()
        CType(OrderPicturebox, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnOrderSave
        ' 
        btnOrderSave.Anchor = AnchorStyles.None
        btnOrderSave.BackColor = Color.SeaShell
        btnOrderSave.Location = New Point(1047, 601)
        btnOrderSave.Name = "btnOrderSave"
        btnOrderSave.Size = New System.Drawing.Size(104, 41)
        btnOrderSave.TabIndex = 11
        btnOrderSave.Text = "Save"
        btnOrderSave.UseVisualStyleBackColor = False
        ' 
        ' nudValue
        ' 
        nudValue.Anchor = AnchorStyles.None
        nudValue.Location = New Point(200, 360)
        nudValue.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        nudValue.Name = "nudValue"
        nudValue.Size = New System.Drawing.Size(102, 23)
        nudValue.TabIndex = 5
        ' 
        ' btnaddMeasurement
        ' 
        btnaddMeasurement.Anchor = AnchorStyles.None
        btnaddMeasurement.BackColor = Color.White
        btnaddMeasurement.Location = New Point(406, 600)
        btnaddMeasurement.Name = "btnaddMeasurement"
        btnaddMeasurement.Size = New System.Drawing.Size(104, 30)
        btnaddMeasurement.TabIndex = 8
        btnaddMeasurement.Text = "Add Size"
        btnaddMeasurement.UseVisualStyleBackColor = False
        ' 
        ' cbUnit
        ' 
        cbUnit.Anchor = AnchorStyles.None
        cbUnit.FormattingEnabled = True
        cbUnit.Items.AddRange(New Object() {"cm", "inches", "meters"})
        cbUnit.Location = New Point(317, 359)
        cbUnit.Name = "cbUnit"
        cbUnit.Size = New System.Drawing.Size(77, 23)
        cbUnit.TabIndex = 6
        cbUnit.Text = "inches"
        ' 
        ' sbMType
        ' 
        sbMType.Anchor = AnchorStyles.None
        sbMType.FormattingEnabled = True
        sbMType.Location = New Point(92, 360)
        sbMType.Name = "sbMType"
        sbMType.Size = New System.Drawing.Size(102, 23)
        sbMType.TabIndex = 4
        sbMType.Text = "Waist"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label1.Location = New Point(9, 14)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(93, 21)
        Label1.TabIndex = 0
        Label1.Text = "Service Type"
        ' 
        ' cbStype
        ' 
        cbStype.CausesValidation = False
        cbStype.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbStype.FormattingEnabled = True
        cbStype.Items.AddRange(New Object() {"Custom Tailoring", "Repair", "Resize"})
        cbStype.Location = New Point(108, 11)
        cbStype.Name = "cbStype"
        cbStype.Size = New System.Drawing.Size(346, 29)
        cbStype.TabIndex = 1
        cbStype.Text = "Custom Tailoring"
        ' 
        ' cbGarment
        ' 
        cbGarment.FormattingEnabled = True
        cbGarment.Items.AddRange(New Object() {"Cotton", "Silk", "Leather"})
        cbGarment.Location = New Point(400, 359)
        cbGarment.Name = "cbGarment"
        cbGarment.Size = New System.Drawing.Size(66, 23)
        cbGarment.TabIndex = 7
        cbGarment.Text = "Cotton"
        ' 
        ' tbOrderName
        ' 
        tbOrderName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbOrderName.Location = New Point(108, 13)
        tbOrderName.MaxLength = 150
        tbOrderName.Name = "tbOrderName"
        tbOrderName.PlaceholderText = "Enter Order Name"
        tbOrderName.Size = New System.Drawing.Size(346, 29)
        tbOrderName.TabIndex = 0
        ' 
        ' lblorderName
        ' 
        lblorderName.AutoSize = True
        lblorderName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblorderName.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblorderName.Location = New Point(5, 16)
        lblorderName.Name = "lblorderName"
        lblorderName.Size = New System.Drawing.Size(97, 21)
        lblorderName.TabIndex = 5
        lblorderName.Text = "Order Name"
        ' 
        ' lblDesc
        ' 
        lblDesc.Anchor = AnchorStyles.None
        lblDesc.AutoSize = True
        lblDesc.BackColor = Color.Transparent
        lblDesc.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDesc.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblDesc.Location = New Point(553, 350)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New System.Drawing.Size(137, 32)
        lblDesc.TabIndex = 7
        lblDesc.Text = "Description"
        ' 
        ' rbDescription
        ' 
        rbDescription.Anchor = AnchorStyles.None
        rbDescription.BackColor = Color.White
        rbDescription.Location = New Point(553, 390)
        rbDescription.MaxLength = 20000
        rbDescription.Name = "rbDescription"
        rbDescription.ScrollBars = RichTextBoxScrollBars.Vertical
        rbDescription.Size = New System.Drawing.Size(434, 198)
        rbDescription.TabIndex = 9
        rbDescription.Text = ""
        ' 
        ' lblSize
        ' 
        lblSize.Anchor = AnchorStyles.None
        lblSize.AutoSize = True
        lblSize.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSize.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblSize.Location = New Point(43, 326)
        lblSize.Name = "lblSize"
        lblSize.Size = New System.Drawing.Size(57, 32)
        lblSize.TabIndex = 9
        lblSize.Text = "Size"
        ' 
        ' dgMeasurements
        ' 
        dgMeasurements.Anchor = AnchorStyles.None
        dgMeasurements.BackgroundColor = Color.White
        dgMeasurements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgMeasurements.Columns.AddRange(New DataGridViewColumn() {size_type, measurement, GarmentType})
        dgMeasurements.GridColor = Color.White
        dgMeasurements.Location = New Point(44, 390)
        dgMeasurements.Name = "dgMeasurements"
        dgMeasurements.Size = New System.Drawing.Size(466, 198)
        dgMeasurements.TabIndex = 10
        ' 
        ' size_type
        ' 
        size_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        size_type.HeaderText = "Measurement type"
        size_type.Name = "size_type"
        size_type.Width = 160
        ' 
        ' measurement
        ' 
        measurement.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        measurement.HeaderText = "Measurement"
        measurement.Name = "measurement"
        measurement.Width = 110
        ' 
        ' GarmentType
        ' 
        GarmentType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        GarmentType.HeaderText = "Garment Type"
        GarmentType.Name = "GarmentType"
        GarmentType.Width = 160
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label3.Location = New Point(12, 18)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(43, 21)
        Label3.TabIndex = 20
        Label3.Text = "Price"
        ' 
        ' nudPrice
        ' 
        nudPrice.Anchor = AnchorStyles.None
        nudPrice.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nudPrice.Location = New Point(108, 16)
        nudPrice.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        nudPrice.Name = "nudPrice"
        nudPrice.Size = New System.Drawing.Size(340, 29)
        nudPrice.TabIndex = 2
        ' 
        ' pnAddOrders
        ' 
        pnAddOrders.Anchor = AnchorStyles.None
        pnAddOrders.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnAddOrders.BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        pnAddOrders.Controls.Add(Label5)
        pnAddOrders.Controls.Add(Panel3)
        pnAddOrders.Controls.Add(dtpOrderDate)
        pnAddOrders.Controls.Add(btnAddImage)
        pnAddOrders.Controls.Add(btnRemoveImage)
        pnAddOrders.Controls.Add(ComboBox1)
        pnAddOrders.Controls.Add(Label2)
        pnAddOrders.Controls.Add(btnAdd)
        pnAddOrders.Controls.Add(OrderPicturebox)
        pnAddOrders.Controls.Add(btnaddMeasurement)
        pnAddOrders.Controls.Add(nudValue)
        pnAddOrders.Controls.Add(dgMeasurements)
        pnAddOrders.Controls.Add(cbUnit)
        pnAddOrders.Controls.Add(rbDescription)
        pnAddOrders.Controls.Add(lblSize)
        pnAddOrders.Controls.Add(lblDesc)
        pnAddOrders.Controls.Add(sbMType)
        pnAddOrders.Controls.Add(cbGarment)
        pnAddOrders.Controls.Add(Panel2)
        pnAddOrders.Controls.Add(Panel1)
        pnAddOrders.Location = New Point(1, 1)
        pnAddOrders.Name = "pnAddOrders"
        pnAddOrders.Size = New System.Drawing.Size(1009, 653)
        pnAddOrders.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label5.Location = New Point(44, 33)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(179, 45)
        Label5.TabIndex = 45
        Label5.Text = "Add Order"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(nudPrice)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(45, 235)
        Panel3.Name = "Panel3"
        Panel3.Size = New System.Drawing.Size(461, 51)
        Panel3.TabIndex = 44
        ' 
        ' dtpOrderDate
        ' 
        dtpOrderDate.Location = New Point(45, 92)
        dtpOrderDate.Name = "dtpOrderDate"
        dtpOrderDate.Size = New System.Drawing.Size(200, 23)
        dtpOrderDate.TabIndex = 33
        ' 
        ' btnAddImage
        ' 
        btnAddImage.Anchor = AnchorStyles.None
        btnAddImage.BackColor = Color.White
        btnAddImage.Location = New Point(818, 294)
        btnAddImage.Name = "btnAddImage"
        btnAddImage.Size = New System.Drawing.Size(92, 28)
        btnAddImage.TabIndex = 26
        btnAddImage.Text = "Add Image"
        btnAddImage.UseVisualStyleBackColor = False
        ' 
        ' btnRemoveImage
        ' 
        btnRemoveImage.Anchor = AnchorStyles.None
        btnRemoveImage.BackColor = Color.White
        btnRemoveImage.Location = New Point(916, 294)
        btnRemoveImage.Name = "btnRemoveImage"
        btnRemoveImage.Size = New System.Drawing.Size(86, 28)
        btnRemoveImage.TabIndex = 25
        btnRemoveImage.Text = "Remove "
        btnRemoveImage.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.None
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Small T-Shirt", "Large T-Shirt", "X-Large T-Shirt"})
        ComboBox1.Location = New Point(410, 332)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(109, 23)
        ComboBox1.TabIndex = 3
        ComboBox1.Text = "Small T-Shirt"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label2.Location = New Point(273, 335)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(130, 15)
        Label2.TabIndex = 3
        Label2.Text = "Custom Measurements"
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.None
        btnCancel.BackColor = Color.SeaShell
        btnCancel.Location = New Point(1157, 601)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New System.Drawing.Size(104, 41)
        btnCancel.TabIndex = 12
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.None
        btnAdd.BackColor = Color.SeaShell
        btnAdd.Location = New Point(696, 355)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New System.Drawing.Size(104, 28)
        btnAdd.TabIndex = 10
        btnAdd.Text = "Add+"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' OrderPicturebox
        ' 
        OrderPicturebox.Anchor = AnchorStyles.None
        OrderPicturebox.BackColor = Color.Transparent
        OrderPicturebox.Image = My.Resources.Resources.noImageIcon
        OrderPicturebox.Location = New Point(553, 33)
        OrderPicturebox.Name = "OrderPicturebox"
        OrderPicturebox.Size = New System.Drawing.Size(449, 255)
        OrderPicturebox.SizeMode = PictureBoxSizeMode.Zoom
        OrderPicturebox.TabIndex = 12
        OrderPicturebox.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(tbOrderName)
        Panel2.Controls.Add(lblorderName)
        Panel2.Location = New Point(45, 122)
        Panel2.Name = "Panel2"
        Panel2.Size = New System.Drawing.Size(461, 51)
        Panel2.TabIndex = 42
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(cbStype)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(45, 178)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(461, 51)
        Panel1.TabIndex = 43
        ' 
        ' LbSuggestions
        ' 
        LbSuggestions.FormattingEnabled = True
        LbSuggestions.ItemHeight = 15
        LbSuggestions.Location = New Point(1016, 86)
        LbSuggestions.Name = "LbSuggestions"
        LbSuggestions.Size = New System.Drawing.Size(245, 49)
        LbSuggestions.TabIndex = 27
        LbSuggestions.Visible = False
        ' 
        ' fPanelOrders
        ' 
        fPanelOrders.AutoScroll = True
        fPanelOrders.BackColor = Color.White
        fPanelOrders.Location = New Point(1016, 86)
        fPanelOrders.Name = "fPanelOrders"
        fPanelOrders.Size = New System.Drawing.Size(245, 503)
        fPanelOrders.TabIndex = 0
        ' 
        ' lblOrders
        ' 
        lblOrders.Anchor = AnchorStyles.None
        lblOrders.AutoSize = True
        lblOrders.BackColor = Color.Transparent
        lblOrders.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrders.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblOrders.Location = New Point(1038, 9)
        lblOrders.Name = "lblOrders"
        lblOrders.Size = New System.Drawing.Size(207, 32)
        lblOrders.TabIndex = 24
        lblOrders.Text = "Orders ng Whatt?"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(1016, 57)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New System.Drawing.Size(245, 23)
        txtSearch.TabIndex = 25
        ' 
        ' AddOrder
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        ClientSize = New System.Drawing.Size(1273, 654)
        Controls.Add(LbSuggestions)
        Controls.Add(pnAddOrders)
        Controls.Add(lblOrders)
        Controls.Add(txtSearch)
        Controls.Add(fPanelOrders)
        Controls.Add(btnCancel)
        Controls.Add(btnOrderSave)
        ForeColor = Color.Black
        Name = "AddOrder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddOrder"
        CType(nudValue, ComponentModel.ISupportInitialize).EndInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).EndInit()
        pnAddOrders.ResumeLayout(False)
        pnAddOrders.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(OrderPicturebox, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents sbMType As ComboBox
    Friend WithEvents cbUnit As ComboBox
    Friend WithEvents btnaddMeasurement As Button
    Friend WithEvents btnOrderSave As Button
    Friend WithEvents nudValue As NumericUpDown
    Friend WithEvents pnAddOrders As Panel
    Friend WithEvents nudPrice As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents dgMeasurements As DataGridView
    Friend WithEvents lblSize As Label
    Friend WithEvents rbDescription As RichTextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblorderName As Label
    Friend WithEvents tbOrderName As TextBox
    Friend WithEvents cbGarment As ComboBox
    Friend WithEvents cbStype As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OrderPicturebox As PictureBox
    Friend WithEvents fPanelOrders As FlowLayoutPanel
    Friend WithEvents lblOrders As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents LbSuggestions As ListBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents size_type As DataGridViewTextBoxColumn
    Friend WithEvents measurement As DataGridViewTextBoxColumn
    Friend WithEvents GarmentType As DataGridViewTextBoxColumn
    Friend WithEvents btnRemoveImage As Button
    Friend WithEvents btnAddImage As Button
    Friend WithEvents dtpOrderDate As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
End Class
