<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddOrder))
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
        lblSize = New Label()
        dgMeasurements = New DataGridView()
        size_type = New DataGridViewTextBoxColumn()
        measurement = New DataGridViewTextBoxColumn()
        GarmentType = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        nudPrice = New NumericUpDown()
        pnAddOrders = New Panel()
        PictureBox4 = New PictureBox()
        OrderPicturebox = New PictureBox()
        Label5 = New Label()
        Panel3 = New Panel()
        dtpOrderDate = New DateTimePicker()
        btnAddImage = New Button()
        btnRemoveImage = New Button()
        cbSizes = New ComboBox()
        Label2 = New Label()
        rbDescription = New RichTextBox()
        Panel2 = New Panel()
        Panel1 = New Panel()
        btnAdd = New Button()
        LbSuggestions = New ListBox()
        fPanelOrders = New FlowLayoutPanel()
        lblOrders = New Label()
        txtSearch = New TextBox()
        btnDelete = New PictureBox()
        pnNavigation = New Panel()
        Button1 = New Button()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        pbTailoringJacinto = New PictureBox()
        btnLogout = New Button()
        btnSettings = New Button()
        btnHome = New Button()
        CType(nudValue, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).BeginInit()
        pnAddOrders.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(OrderPicturebox, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        CType(btnDelete, ComponentModel.ISupportInitialize).BeginInit()
        pnNavigation.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbTailoringJacinto, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnOrderSave
        ' 
        btnOrderSave.Anchor = AnchorStyles.None
        btnOrderSave.BackColor = Color.SeaShell
        btnOrderSave.Location = New Point(1128, 601)
        btnOrderSave.Name = "btnOrderSave"
        btnOrderSave.Size = New Size(104, 41)
        btnOrderSave.TabIndex = 11
        btnOrderSave.Text = "Save"
        btnOrderSave.UseVisualStyleBackColor = False
        ' 
        ' nudValue
        ' 
        nudValue.Anchor = AnchorStyles.None
        nudValue.Location = New Point(127, 522)
        nudValue.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        nudValue.Name = "nudValue"
        nudValue.Size = New Size(102, 23)
        nudValue.TabIndex = 5
        ' 
        ' btnaddMeasurement
        ' 
        btnaddMeasurement.Anchor = AnchorStyles.None
        btnaddMeasurement.BackColor = Color.White
        btnaddMeasurement.Location = New Point(321, 564)
        btnaddMeasurement.Name = "btnaddMeasurement"
        btnaddMeasurement.Size = New Size(104, 44)
        btnaddMeasurement.TabIndex = 8
        btnaddMeasurement.Text = "Add Size"
        btnaddMeasurement.UseVisualStyleBackColor = False
        ' 
        ' cbUnit
        ' 
        cbUnit.Anchor = AnchorStyles.None
        cbUnit.FormattingEnabled = True
        cbUnit.Items.AddRange(New Object() {"cm", "inches", "meters"})
        cbUnit.Location = New Point(244, 521)
        cbUnit.Name = "cbUnit"
        cbUnit.Size = New Size(77, 23)
        cbUnit.TabIndex = 6
        cbUnit.Text = "inches"
        ' 
        ' sbMType
        ' 
        sbMType.Anchor = AnchorStyles.None
        sbMType.FormattingEnabled = True
        sbMType.Location = New Point(19, 522)
        sbMType.Name = "sbMType"
        sbMType.Size = New Size(102, 23)
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
        Label1.Size = New Size(93, 21)
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
        cbStype.Size = New Size(346, 29)
        cbStype.TabIndex = 1
        cbStype.Text = "Custom Tailoring"
        ' 
        ' cbGarment
        ' 
        cbGarment.FormattingEnabled = True
        cbGarment.Items.AddRange(New Object() {"Cotton", "Silk", "Leather"})
        cbGarment.Location = New Point(392, 521)
        cbGarment.Name = "cbGarment"
        cbGarment.Size = New Size(66, 23)
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
        tbOrderName.Size = New Size(346, 29)
        tbOrderName.TabIndex = 0
        ' 
        ' lblorderName
        ' 
        lblorderName.AutoSize = True
        lblorderName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblorderName.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblorderName.Location = New Point(5, 16)
        lblorderName.Name = "lblorderName"
        lblorderName.Size = New Size(97, 21)
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
        lblDesc.Location = New Point(30, 295)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New Size(137, 32)
        lblDesc.TabIndex = 7
        lblDesc.Text = "Description"
        ' 
        ' lblSize
        ' 
        lblSize.Anchor = AnchorStyles.None
        lblSize.AutoSize = True
        lblSize.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSize.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblSize.Location = New Point(30, 468)
        lblSize.Name = "lblSize"
        lblSize.Size = New Size(57, 32)
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
        dgMeasurements.Location = New Point(459, 451)
        dgMeasurements.Name = "dgMeasurements"
        dgMeasurements.Size = New Size(466, 165)
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
        Label3.Size = New Size(43, 21)
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
        nudPrice.Size = New Size(340, 29)
        nudPrice.TabIndex = 2
        ' 
        ' pnAddOrders
        ' 
        pnAddOrders.Anchor = AnchorStyles.None
        pnAddOrders.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnAddOrders.BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        pnAddOrders.Controls.Add(OrderPicturebox)
        pnAddOrders.Controls.Add(Label5)
        pnAddOrders.Controls.Add(Panel3)
        pnAddOrders.Controls.Add(dtpOrderDate)
        pnAddOrders.Controls.Add(btnAddImage)
        pnAddOrders.Controls.Add(btnRemoveImage)
        pnAddOrders.Controls.Add(cbSizes)
        pnAddOrders.Controls.Add(Label2)
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
        pnAddOrders.Location = New Point(110, 1)
        pnAddOrders.Name = "pnAddOrders"
        pnAddOrders.Size = New Size(879, 653)
        pnAddOrders.TabIndex = 2
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.None
        PictureBox4.Enabled = False
        PictureBox4.Image = My.Resources.Resources.arrow__1_
        PictureBox4.Location = New Point(24, 160)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(31, 29)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 20
        PictureBox4.TabStop = False
        ' 
        ' OrderPicturebox
        ' 
        OrderPicturebox.Anchor = AnchorStyles.None
        OrderPicturebox.BackColor = Color.Transparent
        OrderPicturebox.Image = My.Resources.Resources.noImageIcon
        OrderPicturebox.Location = New Point(459, 56)
        OrderPicturebox.Name = "OrderPicturebox"
        OrderPicturebox.Size = New Size(449, 255)
        OrderPicturebox.SizeMode = PictureBoxSizeMode.Zoom
        OrderPicturebox.TabIndex = 12
        OrderPicturebox.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label5.Location = New Point(30, 22)
        Label5.Name = "Label5"
        Label5.Size = New Size(179, 45)
        Label5.TabIndex = 45
        Label5.Text = "Add Order"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(nudPrice)
        Panel3.Controls.Add(Label3)
        Panel3.Location = New Point(30, 228)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(461, 51)
        Panel3.TabIndex = 44
        ' 
        ' dtpOrderDate
        ' 
        dtpOrderDate.Location = New Point(30, 85)
        dtpOrderDate.Name = "dtpOrderDate"
        dtpOrderDate.Size = New Size(200, 23)
        dtpOrderDate.TabIndex = 33
        ' 
        ' btnAddImage
        ' 
        btnAddImage.Anchor = AnchorStyles.None
        btnAddImage.BackColor = Color.White
        btnAddImage.Location = New Point(687, 317)
        btnAddImage.Name = "btnAddImage"
        btnAddImage.Size = New Size(92, 44)
        btnAddImage.TabIndex = 26
        btnAddImage.Text = "Upload Image"
        btnAddImage.UseVisualStyleBackColor = False
        ' 
        ' btnRemoveImage
        ' 
        btnRemoveImage.Anchor = AnchorStyles.None
        btnRemoveImage.BackColor = Color.White
        btnRemoveImage.Location = New Point(785, 317)
        btnRemoveImage.Name = "btnRemoveImage"
        btnRemoveImage.Size = New Size(86, 44)
        btnRemoveImage.TabIndex = 25
        btnRemoveImage.Text = "Remove "
        btnRemoveImage.UseVisualStyleBackColor = False
        ' 
        ' cbSizes
        ' 
        cbSizes.Anchor = AnchorStyles.None
        cbSizes.FormattingEnabled = True
        cbSizes.Location = New Point(323, 494)
        cbSizes.Name = "cbSizes"
        cbSizes.Size = New Size(109, 23)
        cbSizes.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label2.Location = New Point(176, 497)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 15)
        Label2.TabIndex = 3
        Label2.Text = "Custom Measurements"
        ' 
        ' rbDescription
        ' 
        rbDescription.Anchor = AnchorStyles.None
        rbDescription.BackColor = Color.White
        rbDescription.Location = New Point(28, 360)
        rbDescription.MaxLength = 20000
        rbDescription.Name = "rbDescription"
        rbDescription.ScrollBars = RichTextBoxScrollBars.Vertical
        rbDescription.Size = New Size(456, 72)
        rbDescription.TabIndex = 9
        rbDescription.Text = ""
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(tbOrderName)
        Panel2.Controls.Add(lblorderName)
        Panel2.Location = New Point(30, 115)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(461, 51)
        Panel2.TabIndex = 42
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(cbStype)
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(30, 171)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(461, 51)
        Panel1.TabIndex = 43
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.None
        btnAdd.BackColor = Color.SeaShell
        btnAdd.Location = New Point(1018, 601)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(104, 41)
        btnAdd.TabIndex = 10
        btnAdd.Text = "Add Order"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' LbSuggestions
        ' 
        LbSuggestions.FormattingEnabled = True
        LbSuggestions.ItemHeight = 15
        LbSuggestions.Location = New Point(993, 86)
        LbSuggestions.Name = "LbSuggestions"
        LbSuggestions.Size = New Size(268, 49)
        LbSuggestions.TabIndex = 27
        LbSuggestions.Visible = False
        ' 
        ' fPanelOrders
        ' 
        fPanelOrders.Anchor = AnchorStyles.None
        fPanelOrders.AutoScroll = True
        fPanelOrders.BackColor = Color.White
        fPanelOrders.Location = New Point(995, 86)
        fPanelOrders.Name = "fPanelOrders"
        fPanelOrders.Size = New Size(268, 503)
        fPanelOrders.TabIndex = 0
        ' 
        ' lblOrders
        ' 
        lblOrders.Anchor = AnchorStyles.None
        lblOrders.AutoSize = True
        lblOrders.BackColor = Color.Transparent
        lblOrders.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrders.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblOrders.Location = New Point(995, 22)
        lblOrders.Name = "lblOrders"
        lblOrders.Size = New Size(201, 32)
        lblOrders.TabIndex = 24
        lblOrders.Text = "No Orders added"
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.None
        txtSearch.Location = New Point(995, 57)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(268, 23)
        txtSearch.TabIndex = 25
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.White
        btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), Image)
        btnDelete.Location = New Point(1230, 26)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(31, 25)
        btnDelete.SizeMode = PictureBoxSizeMode.Zoom
        btnDelete.TabIndex = 28
        btnDelete.TabStop = False
        ' 
        ' pnNavigation
        ' 
        pnNavigation.Anchor = AnchorStyles.None
        pnNavigation.BackColor = Color.FromArgb(CByte(255), CByte(254), CByte(254))
        pnNavigation.Controls.Add(PictureBox4)
        pnNavigation.Controls.Add(Button1)
        pnNavigation.Controls.Add(PictureBox3)
        pnNavigation.Controls.Add(PictureBox1)
        pnNavigation.Controls.Add(PictureBox2)
        pnNavigation.Controls.Add(pbTailoringJacinto)
        pnNavigation.Controls.Add(btnLogout)
        pnNavigation.Controls.Add(btnSettings)
        pnNavigation.Controls.Add(btnHome)
        pnNavigation.Location = New Point(12, 1)
        pnNavigation.Name = "pnNavigation"
        pnNavigation.Size = New Size(79, 700)
        pnNavigation.TabIndex = 29
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.BackColor = Color.BurlyWood
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.BurlyWood
        Button1.Location = New Point(0, 157)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Padding = New Padding(30, 0, 0, 0)
        Button1.Size = New Size(81, 45)
        Button1.TabIndex = 20
        Button1.TextAlign = ContentAlignment.MiddleLeft
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.Enabled = False
        PictureBox3.Image = My.Resources.Resources.logout
        PictureBox3.Location = New Point(24, 207)
        PictureBox3.Margin = New Padding(0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(31, 29)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 18
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Enabled = False
        PictureBox1.Image = My.Resources.Resources.setting
        PictureBox1.Location = New Point(24, 120)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(31, 29)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Enabled = False
        PictureBox2.Image = My.Resources.Resources.home
        PictureBox2.Location = New Point(24, 65)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(41, 38)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' pbTailoringJacinto
        ' 
        pbTailoringJacinto.Anchor = AnchorStyles.None
        pbTailoringJacinto.Image = CType(resources.GetObject("pbTailoringJacinto.Image"), Image)
        pbTailoringJacinto.Location = New Point(3, 0)
        pbTailoringJacinto.Name = "pbTailoringJacinto"
        pbTailoringJacinto.Size = New Size(72, 65)
        pbTailoringJacinto.SizeMode = PictureBoxSizeMode.Zoom
        pbTailoringJacinto.TabIndex = 9
        pbTailoringJacinto.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.None
        btnLogout.BackColor = Color.BurlyWood
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.BurlyWood
        btnLogout.Location = New Point(0, 207)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(30, 0, 0, 0)
        btnLogout.Size = New Size(81, 45)
        btnLogout.TabIndex = 11
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnSettings
        ' 
        btnSettings.Anchor = AnchorStyles.None
        btnSettings.BackColor = Color.FromArgb(CByte(217), CByte(185), CByte(155))
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.ForeColor = Color.FromArgb(CByte(217), CByte(185), CByte(155))
        btnSettings.Location = New Point(0, 109)
        btnSettings.Name = "btnSettings"
        btnSettings.Padding = New Padding(30, 0, 0, 0)
        btnSettings.Size = New Size(81, 45)
        btnSettings.TabIndex = 10
        btnSettings.TextAlign = ContentAlignment.MiddleLeft
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.Anchor = AnchorStyles.None
        btnHome.BackColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.ForeColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        btnHome.Location = New Point(-2, 65)
        btnHome.Name = "btnHome"
        btnHome.Padding = New Padding(30, 0, 0, 0)
        btnHome.Size = New Size(81, 45)
        btnHome.TabIndex = 9
        btnHome.TextAlign = ContentAlignment.MiddleLeft
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' AddOrder
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        ClientSize = New Size(1276, 654)
        Controls.Add(pnNavigation)
        Controls.Add(btnDelete)
        Controls.Add(LbSuggestions)
        Controls.Add(pnAddOrders)
        Controls.Add(lblOrders)
        Controls.Add(txtSearch)
        Controls.Add(fPanelOrders)
        Controls.Add(btnOrderSave)
        Controls.Add(btnAdd)
        ForeColor = Color.Black
        Name = "AddOrder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddOrder"
        CType(nudValue, ComponentModel.ISupportInitialize).EndInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).EndInit()
        pnAddOrders.ResumeLayout(False)
        pnAddOrders.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(OrderPicturebox, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(btnDelete, ComponentModel.ISupportInitialize).EndInit()
        pnNavigation.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(pbTailoringJacinto, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnAdd As Button
    Friend WithEvents cbSizes As ComboBox
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
    Friend WithEvents rbDescription As RichTextBox
    Friend WithEvents btnDelete As PictureBox
    Friend WithEvents pnNavigation As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents pbTailoringJacinto As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Button1 As Button
End Class
