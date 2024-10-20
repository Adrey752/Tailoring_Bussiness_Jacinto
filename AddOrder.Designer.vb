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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddOrder))
        btnOrderSave = New Button()
        nudValue = New NumericUpDown()
        btnaddMeasurement = New Button()
        cbUnit = New ComboBox()
        sbMType = New ComboBox()
        ErrorProvider1 = New ErrorProvider(components)
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
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        btnCancel = New Button()
        btnAdd = New Button()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        LbSuggestions = New ListBox()
        Timer1 = New Timer(components)
        fPanelOrders = New FlowLayoutPanel()
        lblOrders = New Label()
        txtSearch = New TextBox()
        CType(nudValue, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).BeginInit()
        pnAddOrders.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnOrderSave
        ' 
        btnOrderSave.Anchor = AnchorStyles.None
        btnOrderSave.BackColor = Color.SeaShell
        btnOrderSave.Location = New Point(687, 578)
        btnOrderSave.Name = "btnOrderSave"
        btnOrderSave.Size = New System.Drawing.Size(104, 41)
        btnOrderSave.TabIndex = 3
        btnOrderSave.Text = "Save"
        btnOrderSave.UseVisualStyleBackColor = False
        ' 
        ' nudValue
        ' 
        nudValue.Anchor = AnchorStyles.None
        nudValue.Location = New Point(147, 307)
        nudValue.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        nudValue.Name = "nudValue"
        nudValue.Size = New System.Drawing.Size(102, 23)
        nudValue.TabIndex = 18
        ' 
        ' btnaddMeasurement
        ' 
        btnaddMeasurement.Anchor = AnchorStyles.None
        btnaddMeasurement.Location = New Point(430, 307)
        btnaddMeasurement.Name = "btnaddMeasurement"
        btnaddMeasurement.Size = New System.Drawing.Size(75, 23)
        btnaddMeasurement.TabIndex = 17
        btnaddMeasurement.Text = "Add Size"
        btnaddMeasurement.UseVisualStyleBackColor = True
        ' 
        ' cbUnit
        ' 
        cbUnit.Anchor = AnchorStyles.None
        cbUnit.FormattingEnabled = True
        cbUnit.Items.AddRange(New Object() {"cm", "inches", "meters"})
        cbUnit.Location = New Point(264, 306)
        cbUnit.Name = "cbUnit"
        cbUnit.Size = New System.Drawing.Size(77, 23)
        cbUnit.TabIndex = 16
        cbUnit.Text = "inches"
        ' 
        ' sbMType
        ' 
        sbMType.Anchor = AnchorStyles.None
        sbMType.FormattingEnabled = True
        sbMType.Location = New Point(39, 307)
        sbMType.Name = "sbMType"
        sbMType.Size = New System.Drawing.Size(102, 23)
        sbMType.TabIndex = 12
        sbMType.Text = "Waist"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label1.Location = New Point(54, 141)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 15)
        Label1.TabIndex = 0
        Label1.Text = "Service Type"
        ' 
        ' cbStype
        ' 
        cbStype.CausesValidation = False
        cbStype.FormattingEnabled = True
        cbStype.Items.AddRange(New Object() {"Repair", "Resize"})
        cbStype.Location = New Point(153, 142)
        cbStype.Name = "cbStype"
        cbStype.Size = New System.Drawing.Size(121, 23)
        cbStype.TabIndex = 1
        ' 
        ' cbGarment
        ' 
        cbGarment.FormattingEnabled = True
        cbGarment.Items.AddRange(New Object() {"Cotton", "Silk", "Leather"})
        cbGarment.Location = New Point(347, 308)
        cbGarment.Name = "cbGarment"
        cbGarment.Size = New System.Drawing.Size(66, 23)
        cbGarment.TabIndex = 3
        cbGarment.Text = "Cotton"
        ' 
        ' tbOrderName
        ' 
        tbOrderName.Location = New Point(151, 86)
        tbOrderName.MaxLength = 150
        tbOrderName.Name = "tbOrderName"
        tbOrderName.PlaceholderText = "Enter Order Name"
        tbOrderName.Size = New System.Drawing.Size(121, 23)
        tbOrderName.TabIndex = 0
        ' 
        ' lblorderName
        ' 
        lblorderName.AutoSize = True
        lblorderName.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblorderName.Location = New Point(54, 89)
        lblorderName.Name = "lblorderName"
        lblorderName.Size = New System.Drawing.Size(72, 15)
        lblorderName.TabIndex = 5
        lblorderName.Text = "Order Name"
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
        GarmentType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        GarmentType.HeaderText = "Garment Type"
        GarmentType.Name = "GarmentType"
        GarmentType.Width = 160
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label3.Location = New Point(55, 171)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(33, 15)
        Label3.TabIndex = 20
        Label3.Text = "Price"
        ' 
        ' nudPrice
        ' 
        nudPrice.Anchor = AnchorStyles.None
        nudPrice.Location = New Point(151, 182)
        nudPrice.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        nudPrice.Name = "nudPrice"
        nudPrice.Size = New System.Drawing.Size(120, 23)
        nudPrice.TabIndex = 2
        ' 
        ' pnAddOrders
        ' 
        pnAddOrders.Anchor = AnchorStyles.None
        pnAddOrders.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnAddOrders.BackColor = Color.White
        pnAddOrders.Controls.Add(ComboBox1)
        pnAddOrders.Controls.Add(Label2)
        pnAddOrders.Controls.Add(btnCancel)
        pnAddOrders.Controls.Add(btnAdd)
        pnAddOrders.Controls.Add(Label4)
        pnAddOrders.Controls.Add(PictureBox1)
        pnAddOrders.Controls.Add(btnOrderSave)
        pnAddOrders.Controls.Add(nudPrice)
        pnAddOrders.Controls.Add(Label3)
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
        pnAddOrders.Controls.Add(Label1)
        pnAddOrders.Location = New Point(0, 0)
        pnAddOrders.Name = "pnAddOrders"
        pnAddOrders.Size = New System.Drawing.Size(998, 653)
        pnAddOrders.TabIndex = 2
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.None
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Small T-Shirt", "Large T-Shirt", "X-Large T-Shirt"})
        ComboBox1.Location = New Point(235, 267)
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
        Label2.Location = New Point(91, 270)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(130, 15)
        Label2.TabIndex = 26
        Label2.Text = "Custom Measurements"
        ' 
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.None
        btnCancel.BackColor = Color.SeaShell
        btnCancel.Location = New Point(797, 578)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New System.Drawing.Size(104, 41)
        btnCancel.TabIndex = 25
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.None
        btnAdd.BackColor = Color.SeaShell
        btnAdd.Location = New Point(560, 578)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New System.Drawing.Size(104, 41)
        btnAdd.TabIndex = 24
        btnAdd.Text = "Add+"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label4.Location = New Point(28, 31)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(137, 32)
        Label4.TabIndex = 23
        Label4.Text = "Description"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(521, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(438, 297)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' LbSuggestions
        ' 
        LbSuggestions.FormattingEnabled = True
        LbSuggestions.ItemHeight = 15
        LbSuggestions.Location = New Point(1014, 86)
        LbSuggestions.Name = "LbSuggestions"
        LbSuggestions.Size = New System.Drawing.Size(207, 49)
        LbSuggestions.TabIndex = 27
        LbSuggestions.Visible = False
        ' 
        ' Timer1
        ' 
        ' 
        ' fPanelOrders
        ' 
        fPanelOrders.AutoScroll = True
        fPanelOrders.BackColor = SystemColors.ActiveCaption
        fPanelOrders.Location = New Point(1017, 89)
        fPanelOrders.Name = "fPanelOrders"
        fPanelOrders.Size = New System.Drawing.Size(208, 564)
        fPanelOrders.TabIndex = 0
        ' 
        ' lblOrders
        ' 
        lblOrders.Anchor = AnchorStyles.None
        lblOrders.AutoSize = True
        lblOrders.BackColor = Color.WhiteSmoke
        lblOrders.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrders.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblOrders.Location = New Point(1013, 9)
        lblOrders.Name = "lblOrders"
        lblOrders.Size = New System.Drawing.Size(207, 32)
        lblOrders.TabIndex = 24
        lblOrders.Text = "Orders ng Whatt?"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(1013, 58)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New System.Drawing.Size(208, 23)
        txtSearch.TabIndex = 25
        ' 
        ' AddOrder
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
        ForeColor = Color.Black
        Name = "AddOrder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddOrder"
        CType(nudValue, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).EndInit()
        pnAddOrders.ResumeLayout(False)
        pnAddOrders.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents sbMType As ComboBox
    Friend WithEvents cbUnit As ComboBox
    Friend WithEvents btnaddMeasurement As Button
    Friend WithEvents btnOrderSave As Button
    Friend WithEvents nudValue As NumericUpDown
    Friend WithEvents ErrorProvider1 As ErrorProvider
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
    Friend WithEvents fPanelOrders As FlowLayoutPanel
    Friend WithEvents lblOrders As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents LbSuggestions As ListBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents size_type As DataGridViewTextBoxColumn
    Friend WithEvents measurement As DataGridViewTextBoxColumn
    Friend WithEvents GarmentType As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
End Class
