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
        headerOrder = New Label()
        btnAdd = New Button()
        btnCancel = New Button()
        PictureBox1 = New PictureBox()
        btnOrderSave = New Button()
        nudPrice = New NumericUpDown()
        lblPrice = New Label()
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
        lblorderName = New Label()
        tbOrderName = New TextBox()
        sbMType = New ComboBox()
        cbGarment = New ComboBox()
        cbStype = New ComboBox()
        lblServiceType = New Label()
        fPanelOrders = New FlowLayoutPanel()
        LbSuggestions = New ListBox()
        lblOrders = New Label()
        txtSearch = New TextBox()
        pnAddOrders.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudValue, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnAddOrders
        ' 
        pnAddOrders.Anchor = AnchorStyles.None
        pnAddOrders.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnAddOrders.BackColor = Color.White
        pnAddOrders.Controls.Add(headerOrder)
        pnAddOrders.Controls.Add(btnAdd)
        pnAddOrders.Controls.Add(btnCancel)
        pnAddOrders.Controls.Add(PictureBox1)
        pnAddOrders.Controls.Add(btnOrderSave)
        pnAddOrders.Controls.Add(nudPrice)
        pnAddOrders.Controls.Add(lblPrice)
        pnAddOrders.Controls.Add(btnaddMeasurement)
        pnAddOrders.Controls.Add(nudValue)
        pnAddOrders.Controls.Add(dgMeasurements)
        pnAddOrders.Controls.Add(cbUnit)
        pnAddOrders.Controls.Add(rbDescription)
        pnAddOrders.Controls.Add(lblSize)
        pnAddOrders.Controls.Add(lblDesc)
        pnAddOrders.Controls.Add(lblorderName)
        pnAddOrders.Controls.Add(tbOrderName)
        pnAddOrders.Controls.Add(sbMType)
        pnAddOrders.Controls.Add(cbGarment)
        pnAddOrders.Controls.Add(cbStype)
        pnAddOrders.Controls.Add(lblServiceType)
        pnAddOrders.Location = New Point(1, 2)
        pnAddOrders.Name = "pnAddOrders"
        pnAddOrders.Size = New System.Drawing.Size(998, 653)
        pnAddOrders.TabIndex = 3
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
        btnAdd.Location = New Point(635, 599)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New System.Drawing.Size(104, 41)
        btnAdd.TabIndex = 25
        btnAdd.Text = "Add +"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.None
        btnCancel.BackColor = Color.SeaShell
        btnCancel.Location = New Point(855, 599)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New System.Drawing.Size(104, 41)
        btnCancel.TabIndex = 24
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.ErrorImage = My.Resources.Resources.eye
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(548, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(438, 297)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' btnOrderSave
        ' 
        btnOrderSave.Anchor = AnchorStyles.None
        btnOrderSave.BackColor = Color.SeaShell
        btnOrderSave.Location = New Point(745, 599)
        btnOrderSave.Name = "btnOrderSave"
        btnOrderSave.Size = New System.Drawing.Size(104, 41)
        btnOrderSave.TabIndex = 3
        btnOrderSave.Text = "Save"
        btnOrderSave.UseVisualStyleBackColor = False
        ' 
        ' nudPrice
        ' 
        nudPrice.Anchor = AnchorStyles.None
        nudPrice.Location = New Point(164, 178)
        nudPrice.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        nudPrice.Name = "nudPrice"
        nudPrice.Size = New System.Drawing.Size(120, 23)
        nudPrice.TabIndex = 19
        ' 
        ' lblPrice
        ' 
        lblPrice.Anchor = AnchorStyles.None
        lblPrice.AutoSize = True
        lblPrice.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblPrice.Location = New Point(61, 180)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New System.Drawing.Size(33, 15)
        lblPrice.TabIndex = 20
        lblPrice.Text = "Price"
        ' 
        ' btnaddMeasurement
        ' 
        btnaddMeasurement.Anchor = AnchorStyles.None
        btnaddMeasurement.Location = New Point(430, 306)
        btnaddMeasurement.Name = "btnaddMeasurement"
        btnaddMeasurement.Size = New System.Drawing.Size(75, 23)
        btnaddMeasurement.TabIndex = 17
        btnaddMeasurement.Text = "Add Size"
        btnaddMeasurement.UseVisualStyleBackColor = True
        ' 
        ' nudValue
        ' 
        nudValue.Anchor = AnchorStyles.None
        nudValue.Location = New Point(146, 306)
        nudValue.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        nudValue.Name = "nudValue"
        nudValue.Size = New System.Drawing.Size(102, 23)
        nudValue.TabIndex = 18
        ' 
        ' dgMeasurements
        ' 
        dgMeasurements.Anchor = AnchorStyles.None
        dgMeasurements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgMeasurements.Columns.AddRange(New DataGridViewColumn() {size_type, measurement, GarmentType})
        dgMeasurements.Location = New Point(39, 345)
        dgMeasurements.Name = "dgMeasurements"
        dgMeasurements.Size = New System.Drawing.Size(466, 295)
        dgMeasurements.TabIndex = 10
        ' 
        ' size_type
        ' 
        size_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        size_type.HeaderText = "Body Measurement"
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
        cbUnit.Location = New Point(254, 305)
        cbUnit.Name = "cbUnit"
        cbUnit.Size = New System.Drawing.Size(77, 23)
        cbUnit.TabIndex = 16
        cbUnit.Text = "inches"
        ' 
        ' rbDescription
        ' 
        rbDescription.Anchor = AnchorStyles.None
        rbDescription.BackColor = Color.FromArgb(CByte(194), CByte(194), CByte(194))
        rbDescription.Location = New Point(548, 413)
        rbDescription.MaxLength = 20000
        rbDescription.Name = "rbDescription"
        rbDescription.ScrollBars = RichTextBoxScrollBars.Vertical
        rbDescription.Size = New System.Drawing.Size(438, 112)
        rbDescription.TabIndex = 8
        rbDescription.Text = ""
        ' 
        ' lblSize
        ' 
        lblSize.Anchor = AnchorStyles.None
        lblSize.AutoSize = True
        lblSize.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSize.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblSize.Location = New Point(28, 256)
        lblSize.Name = "lblSize"
        lblSize.Size = New System.Drawing.Size(57, 32)
        lblSize.TabIndex = 9
        lblSize.Text = "Size"
        ' 
        ' lblDesc
        ' 
        lblDesc.Anchor = AnchorStyles.None
        lblDesc.AutoSize = True
        lblDesc.BackColor = Color.WhiteSmoke
        lblDesc.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDesc.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblDesc.Location = New Point(548, 345)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New System.Drawing.Size(137, 32)
        lblDesc.TabIndex = 7
        lblDesc.Text = "Description"
        ' 
        ' lblorderName
        ' 
        lblorderName.AutoSize = True
        lblorderName.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblorderName.Location = New Point(61, 96)
        lblorderName.Name = "lblorderName"
        lblorderName.Size = New System.Drawing.Size(72, 15)
        lblorderName.TabIndex = 5
        lblorderName.Text = "Order Name"
        ' 
        ' tbOrderName
        ' 
        tbOrderName.Location = New Point(164, 96)
        tbOrderName.MaxLength = 150
        tbOrderName.Name = "tbOrderName"
        tbOrderName.PlaceholderText = "Enter Order Name"
        tbOrderName.Size = New System.Drawing.Size(121, 23)
        tbOrderName.TabIndex = 4
        ' 
        ' sbMType
        ' 
        sbMType.Anchor = AnchorStyles.None
        sbMType.FormattingEnabled = True
        sbMType.Location = New Point(38, 305)
        sbMType.Name = "sbMType"
        sbMType.Size = New System.Drawing.Size(102, 23)
        sbMType.TabIndex = 12
        sbMType.Text = "Waist"
        ' 
        ' cbGarment
        ' 
        cbGarment.FormattingEnabled = True
        cbGarment.Items.AddRange(New Object() {"Cotton", "Silk", "Leather"})
        cbGarment.Location = New Point(337, 306)
        cbGarment.Name = "cbGarment"
        cbGarment.Size = New System.Drawing.Size(66, 23)
        cbGarment.TabIndex = 3
        cbGarment.Text = "Cotton"
        ' 
        ' cbStype
        ' 
        cbStype.FormattingEnabled = True
        cbStype.Items.AddRange(New Object() {"Repair", "Resize"})
        cbStype.Location = New Point(164, 142)
        cbStype.Name = "cbStype"
        cbStype.Size = New System.Drawing.Size(121, 23)
        cbStype.TabIndex = 1
        ' 
        ' lblServiceType
        ' 
        lblServiceType.AutoSize = True
        lblServiceType.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblServiceType.Location = New Point(61, 142)
        lblServiceType.Name = "lblServiceType"
        lblServiceType.Size = New System.Drawing.Size(71, 15)
        lblServiceType.TabIndex = 0
        lblServiceType.Text = "Service Type"
        ' 
        ' fPanelOrders
        ' 
        fPanelOrders.AutoScroll = True
        fPanelOrders.BackColor = SystemColors.ActiveCaption
        fPanelOrders.Location = New Point(1013, 87)
        fPanelOrders.Name = "fPanelOrders"
        fPanelOrders.Size = New System.Drawing.Size(208, 504)
        fPanelOrders.TabIndex = 4
        ' 
        ' LbSuggestions
        ' 
        LbSuggestions.FormattingEnabled = True
        LbSuggestions.ItemHeight = 15
        LbSuggestions.Location = New Point(1014, 83)
        LbSuggestions.Name = "LbSuggestions"
        LbSuggestions.Size = New System.Drawing.Size(207, 49)
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
        txtSearch.Size = New System.Drawing.Size(207, 23)
        txtSearch.TabIndex = 9
        ' 
        ' AddNewOrder
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(1246, 654)
        Controls.Add(LbSuggestions)
        Controls.Add(txtSearch)
        Controls.Add(lblOrders)
        Controls.Add(fPanelOrders)
        Controls.Add(pnAddOrders)
        Name = "AddNewOrder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddNewOrder"
        pnAddOrders.ResumeLayout(False)
        pnAddOrders.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).EndInit()
        CType(nudValue, ComponentModel.ISupportInitialize).EndInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnAddOrders As Panel
    Friend WithEvents PictureBox1 As PictureBox
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
    Friend WithEvents size_type As DataGridViewTextBoxColumn
    Friend WithEvents measurement As DataGridViewTextBoxColumn
    Friend WithEvents GarmentType As DataGridViewTextBoxColumn
End Class
