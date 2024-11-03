<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewOrder))
        pnAddOrders = New Panel()
        Panel1 = New Panel()
        cbStype = New ComboBox()
        lblServiceType = New Label()
        dtpOrderDate = New DateTimePicker()
        btnAddImage = New Button()
        btnRemoveImage = New Button()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        headerOrder = New Label()
        btnAdd = New Button()
        OrderPicturebox = New PictureBox()
        btnaddMeasurement = New Button()
        nudValue = New NumericUpDown()
        dgMeasurements = New DataGridView()
        size_type = New DataGridViewTextBoxColumn()
        measurement = New DataGridViewTextBoxColumn()
        GarmentType = New DataGridViewTextBoxColumn()
        cbUnit = New ComboBox()
        rbDescription = New RichTextBox()
        lblSize = New Label()
        lblDesc = New Label()
        sbMType = New ComboBox()
        cbGarment = New ComboBox()
        Panel2 = New Panel()
        tbOrderName = New TextBox()
        lblorderName = New Label()
        Panel3 = New Panel()
        lblPrice = New Label()
        nudPrice = New NumericUpDown()
        btnCancel = New Button()
        btnOrderSave = New Button()
        fPanelOrders = New FlowLayoutPanel()
        LbSuggestions = New ListBox()
        lblOrders = New Label()
        txtSearch = New TextBox()
        pnAddOrders.SuspendLayout()
        Panel1.SuspendLayout()
        CType(OrderPicturebox, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudValue, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(nudPrice, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnAddOrders
        ' 
        pnAddOrders.Anchor = AnchorStyles.None
        pnAddOrders.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnAddOrders.BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        pnAddOrders.Controls.Add(Panel1)
        pnAddOrders.Controls.Add(dtpOrderDate)
        pnAddOrders.Controls.Add(btnAddImage)
        pnAddOrders.Controls.Add(btnRemoveImage)
        pnAddOrders.Controls.Add(ComboBox1)
        pnAddOrders.Controls.Add(Label2)
        pnAddOrders.Controls.Add(headerOrder)
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
        pnAddOrders.Controls.Add(Panel3)
        pnAddOrders.Location = New Point(1, 2)
        pnAddOrders.Name = "pnAddOrders"
        pnAddOrders.Size = New System.Drawing.Size(998, 653)
        pnAddOrders.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(cbStype)
        Panel1.Controls.Add(lblServiceType)
        Panel1.Location = New Point(40, 148)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(481, 51)
        Panel1.TabIndex = 44
        ' 
        ' cbStype
        ' 
        cbStype.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbStype.FormattingEnabled = True
        cbStype.Items.AddRange(New Object() {"Repair", "Resize"})
        cbStype.Location = New Point(125, 13)
        cbStype.Name = "cbStype"
        cbStype.Size = New System.Drawing.Size(342, 29)
        cbStype.TabIndex = 1
        ' 
        ' lblServiceType
        ' 
        lblServiceType.AutoSize = True
        lblServiceType.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblServiceType.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblServiceType.Location = New Point(14, 16)
        lblServiceType.Name = "lblServiceType"
        lblServiceType.Size = New System.Drawing.Size(96, 21)
        lblServiceType.TabIndex = 0
        lblServiceType.Text = "Service Type"
        ' 
        ' dtpOrderDate
        ' 
        dtpOrderDate.Location = New Point(38, 66)
        dtpOrderDate.Name = "dtpOrderDate"
        dtpOrderDate.Size = New System.Drawing.Size(200, 23)
        dtpOrderDate.TabIndex = 32
        ' 
        ' btnAddImage
        ' 
        btnAddImage.Anchor = AnchorStyles.None
        btnAddImage.Location = New Point(821, 310)
        btnAddImage.Name = "btnAddImage"
        btnAddImage.Size = New System.Drawing.Size(75, 23)
        btnAddImage.TabIndex = 31
        btnAddImage.Text = "Add Image"
        btnAddImage.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveImage
        ' 
        btnRemoveImage.Anchor = AnchorStyles.None
        btnRemoveImage.Location = New Point(902, 310)
        btnRemoveImage.Name = "btnRemoveImage"
        btnRemoveImage.Size = New System.Drawing.Size(84, 23)
        btnRemoveImage.TabIndex = 30
        btnRemoveImage.Text = "Remove "
        btnRemoveImage.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.None
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Small T-Shirt", "Large T-Shirt", "X-Large T-Shirt"})
        ComboBox1.Location = New Point(398, 311)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(109, 23)
        ComboBox1.TabIndex = 27
        ComboBox1.Text = "Small T-Shirt"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label2.Location = New Point(254, 314)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(130, 15)
        Label2.TabIndex = 28
        Label2.Text = "Custom Measurements"
        ' 
        ' headerOrder
        ' 
        headerOrder.Anchor = AnchorStyles.None
        headerOrder.AutoSize = True
        headerOrder.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        headerOrder.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        headerOrder.Location = New Point(28, 31)
        headerOrder.Name = "headerOrder"
        headerOrder.Size = New System.Drawing.Size(158, 32)
        headerOrder.TabIndex = 26
        headerOrder.Text = "Order Details"
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.None
        btnAdd.BackColor = Color.SeaShell
        btnAdd.Location = New Point(691, 346)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New System.Drawing.Size(72, 30)
        btnAdd.TabIndex = 25
        btnAdd.Text = "Add +"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' OrderPicturebox
        ' 
        OrderPicturebox.Anchor = AnchorStyles.None
        OrderPicturebox.ErrorImage = My.Resources.Resources.eye
        OrderPicturebox.Image = CType(resources.GetObject("OrderPicturebox.Image"), Image)
        OrderPicturebox.Location = New Point(548, 32)
        OrderPicturebox.Name = "OrderPicturebox"
        OrderPicturebox.Size = New System.Drawing.Size(438, 272)
        OrderPicturebox.SizeMode = PictureBoxSizeMode.Zoom
        OrderPicturebox.TabIndex = 12
        OrderPicturebox.TabStop = False
        ' 
        ' btnaddMeasurement
        ' 
        btnaddMeasurement.Anchor = AnchorStyles.None
        btnaddMeasurement.Location = New Point(430, 617)
        btnaddMeasurement.Name = "btnaddMeasurement"
        btnaddMeasurement.Size = New System.Drawing.Size(75, 23)
        btnaddMeasurement.TabIndex = 7
        btnaddMeasurement.Text = "Add Size"
        btnaddMeasurement.UseVisualStyleBackColor = True
        ' 
        ' nudValue
        ' 
        nudValue.Anchor = AnchorStyles.None
        nudValue.Location = New Point(201, 347)
        nudValue.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        nudValue.Name = "nudValue"
        nudValue.Size = New System.Drawing.Size(102, 23)
        nudValue.TabIndex = 4
        ' 
        ' dgMeasurements
        ' 
        dgMeasurements.Anchor = AnchorStyles.None
        dgMeasurements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgMeasurements.Columns.AddRange(New DataGridViewColumn() {size_type, measurement, GarmentType})
        dgMeasurements.Location = New Point(39, 383)
        dgMeasurements.Name = "dgMeasurements"
        dgMeasurements.Size = New System.Drawing.Size(466, 217)
        dgMeasurements.TabIndex = 10
        ' 
        ' size_type
        ' 
        size_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        size_type.HeaderText = "Measurement Type"
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
        GarmentType.HeaderText = "Garment Type"
        GarmentType.Name = "GarmentType"
        GarmentType.Width = 160
        ' 
        ' cbUnit
        ' 
        cbUnit.Anchor = AnchorStyles.None
        cbUnit.FormattingEnabled = True
        cbUnit.Items.AddRange(New Object() {"cm", "inches", "meters"})
        cbUnit.Location = New Point(309, 346)
        cbUnit.Name = "cbUnit"
        cbUnit.Size = New System.Drawing.Size(77, 23)
        cbUnit.TabIndex = 5
        cbUnit.Text = "inches"
        ' 
        ' rbDescription
        ' 
        rbDescription.Anchor = AnchorStyles.None
        rbDescription.BackColor = Color.FromArgb(CByte(194), CByte(194), CByte(194))
        rbDescription.Location = New Point(548, 383)
        rbDescription.MaxLength = 20000
        rbDescription.Name = "rbDescription"
        rbDescription.ScrollBars = RichTextBoxScrollBars.Vertical
        rbDescription.Size = New System.Drawing.Size(438, 217)
        rbDescription.TabIndex = 8
        rbDescription.Text = ""
        ' 
        ' lblSize
        ' 
        lblSize.Anchor = AnchorStyles.None
        lblSize.AutoSize = True
        lblSize.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSize.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblSize.Location = New Point(38, 302)
        lblSize.Name = "lblSize"
        lblSize.Size = New System.Drawing.Size(57, 32)
        lblSize.TabIndex = 9
        lblSize.Text = "Size"
        ' 
        ' lblDesc
        ' 
        lblDesc.Anchor = AnchorStyles.None
        lblDesc.AutoSize = True
        lblDesc.BackColor = Color.Transparent
        lblDesc.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDesc.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblDesc.Location = New Point(548, 346)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New System.Drawing.Size(137, 32)
        lblDesc.TabIndex = 7
        lblDesc.Text = "Description"
        ' 
        ' sbMType
        ' 
        sbMType.Anchor = AnchorStyles.None
        sbMType.FormattingEnabled = True
        sbMType.Location = New Point(93, 346)
        sbMType.Name = "sbMType"
        sbMType.Size = New System.Drawing.Size(102, 23)
        sbMType.TabIndex = 3
        sbMType.Text = "Waist"
        ' 
        ' cbGarment
        ' 
        cbGarment.FormattingEnabled = True
        cbGarment.Items.AddRange(New Object() {"Cotton", "Silk", "Leather"})
        cbGarment.Location = New Point(392, 347)
        cbGarment.Name = "cbGarment"
        cbGarment.Size = New System.Drawing.Size(66, 23)
        cbGarment.TabIndex = 6
        cbGarment.Text = "Cotton"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(tbOrderName)
        Panel2.Controls.Add(lblorderName)
        Panel2.Location = New Point(38, 91)
        Panel2.Name = "Panel2"
        Panel2.Size = New System.Drawing.Size(481, 51)
        Panel2.TabIndex = 43
        ' 
        ' tbOrderName
        ' 
        tbOrderName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbOrderName.Location = New Point(127, 13)
        tbOrderName.MaxLength = 150
        tbOrderName.Name = "tbOrderName"
        tbOrderName.PlaceholderText = "Enter Order Name"
        tbOrderName.Size = New System.Drawing.Size(342, 29)
        tbOrderName.TabIndex = 0
        ' 
        ' lblorderName
        ' 
        lblorderName.AutoSize = True
        lblorderName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblorderName.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblorderName.Location = New Point(15, 16)
        lblorderName.Name = "lblorderName"
        lblorderName.Size = New System.Drawing.Size(97, 21)
        lblorderName.TabIndex = 5
        lblorderName.Text = "Order Name"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(lblPrice)
        Panel3.Controls.Add(nudPrice)
        Panel3.Location = New Point(40, 205)
        Panel3.Name = "Panel3"
        Panel3.Size = New System.Drawing.Size(481, 51)
        Panel3.TabIndex = 45
        ' 
        ' lblPrice
        ' 
        lblPrice.Anchor = AnchorStyles.None
        lblPrice.AutoSize = True
        lblPrice.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPrice.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblPrice.Location = New Point(14, 17)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New System.Drawing.Size(44, 21)
        lblPrice.TabIndex = 20
        lblPrice.Text = "Price"
        ' 
        ' nudPrice
        ' 
        nudPrice.Anchor = AnchorStyles.None
        nudPrice.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        nudPrice.Location = New Point(126, 15)
        nudPrice.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        nudPrice.Name = "nudPrice"
        nudPrice.Size = New System.Drawing.Size(341, 29)
        nudPrice.TabIndex = 2
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.None
        btnCancel.BackColor = Color.SeaShell
        btnCancel.Location = New Point(1130, 601)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New System.Drawing.Size(104, 41)
        btnCancel.TabIndex = 24
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnOrderSave
        ' 
        btnOrderSave.Anchor = AnchorStyles.None
        btnOrderSave.BackColor = Color.SeaShell
        btnOrderSave.Location = New Point(1013, 601)
        btnOrderSave.Name = "btnOrderSave"
        btnOrderSave.Size = New System.Drawing.Size(104, 41)
        btnOrderSave.TabIndex = 3
        btnOrderSave.Text = "Save"
        btnOrderSave.UseVisualStyleBackColor = False
        ' 
        ' fPanelOrders
        ' 
        fPanelOrders.AutoScroll = True
        fPanelOrders.BackColor = Color.White
        fPanelOrders.Location = New Point(1014, 87)
        fPanelOrders.Name = "fPanelOrders"
        fPanelOrders.Size = New System.Drawing.Size(220, 504)
        fPanelOrders.TabIndex = 0
        ' 
        ' LbSuggestions
        ' 
        LbSuggestions.FormattingEnabled = True
        LbSuggestions.ItemHeight = 15
        LbSuggestions.Location = New Point(1014, 83)
        LbSuggestions.Name = "LbSuggestions"
        LbSuggestions.Size = New System.Drawing.Size(220, 49)
        LbSuggestions.TabIndex = 26
        LbSuggestions.Visible = False
        ' 
        ' lblOrders
        ' 
        lblOrders.Anchor = AnchorStyles.None
        lblOrders.AutoSize = True
        lblOrders.BackColor = Color.WhiteSmoke
        lblOrders.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrders.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblOrders.Location = New Point(1014, 9)
        lblOrders.Name = "lblOrders"
        lblOrders.Size = New System.Drawing.Size(207, 32)
        lblOrders.TabIndex = 8
        lblOrders.Text = "Orders ng Whatt?"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(1014, 58)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New System.Drawing.Size(220, 23)
        txtSearch.TabIndex = 9
        ' 
        ' AddNewOrder
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        ClientSize = New System.Drawing.Size(1246, 654)
        Controls.Add(LbSuggestions)
        Controls.Add(txtSearch)
        Controls.Add(lblOrders)
        Controls.Add(fPanelOrders)
        Controls.Add(pnAddOrders)
        Controls.Add(btnCancel)
        Controls.Add(btnOrderSave)
        Name = "AddNewOrder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddNewOrder"
        pnAddOrders.ResumeLayout(False)
        pnAddOrders.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(OrderPicturebox, ComponentModel.ISupportInitialize).EndInit()
        CType(nudValue, ComponentModel.ISupportInitialize).EndInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(nudPrice, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnAddOrders As Panel
    Friend WithEvents OrderPicturebox As PictureBox
    Friend WithEvents btnOrderSave As Button
    Friend WithEvents nudPrice As NumericUpDown
    Friend WithEvents lblPrice As Label
    Friend WithEvents btnaddMeasurement As Button
    Friend WithEvents nudValue As NumericUpDown
    Friend WithEvents dgMeasurements As DataGridView
    Friend WithEvents cbUnit As ComboBox
    Friend WithEvents rbDescription As RichTextBox
    Friend WithEvents lblSize As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblorderName As Label
    Friend WithEvents tbOrderName As TextBox
    Friend WithEvents sbMType As ComboBox
    Friend WithEvents cbGarment As ComboBox
    Friend WithEvents cbStype As ComboBox
    Friend WithEvents lblServiceType As Label
    Friend WithEvents fPanelOrders As FlowLayoutPanel
    Friend WithEvents lblOrders As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents LbSuggestions As ListBox
    Friend WithEvents headerOrder As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents size_type As DataGridViewTextBoxColumn
    Friend WithEvents measurement As DataGridViewTextBoxColumn
    Friend WithEvents GarmentType As DataGridViewTextBoxColumn
    Friend WithEvents btnAddImage As Button
    Friend WithEvents btnRemoveImage As Button
    Friend WithEvents dtpOrderDate As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
End Class
