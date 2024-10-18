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
        lblAddMoreOrders = New Label()
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
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        PictureBox2 = New PictureBox()
        Timer1 = New Timer(components)
        Label4 = New Label()
        CType(nudValue, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).BeginInit()
        pnAddOrders.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblAddMoreOrders
        ' 
        lblAddMoreOrders.Anchor = AnchorStyles.None
        lblAddMoreOrders.AutoSize = True
        lblAddMoreOrders.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddMoreOrders.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblAddMoreOrders.Location = New Point(296, 30)
        lblAddMoreOrders.Name = "lblAddMoreOrders"
        lblAddMoreOrders.Size = New System.Drawing.Size(203, 32)
        lblAddMoreOrders.TabIndex = 1
        lblAddMoreOrders.Text = "Add More Orders"
        ' 
        ' btnOrderSave
        ' 
        btnOrderSave.Anchor = AnchorStyles.None
        btnOrderSave.BackColor = Color.SeaShell
        btnOrderSave.Location = New Point(679, 557)
        btnOrderSave.Name = "btnOrderSave"
        btnOrderSave.Size = New System.Drawing.Size(104, 41)
        btnOrderSave.TabIndex = 3
        btnOrderSave.Text = "Save"
        btnOrderSave.UseVisualStyleBackColor = False
        ' 
        ' nudValue
        ' 
        nudValue.Anchor = AnchorStyles.None
        nudValue.Location = New Point(143, 505)
        nudValue.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        nudValue.Name = "nudValue"
        nudValue.Size = New System.Drawing.Size(120, 23)
        nudValue.TabIndex = 18
        ' 
        ' btnaddMeasurement
        ' 
        btnaddMeasurement.Anchor = AnchorStyles.None
        btnaddMeasurement.Location = New Point(494, 503)
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
        cbUnit.Location = New Point(269, 505)
        cbUnit.Name = "cbUnit"
        cbUnit.Size = New System.Drawing.Size(98, 23)
        cbUnit.TabIndex = 16
        cbUnit.Text = "inches"
        ' 
        ' sbMType
        ' 
        sbMType.Anchor = AnchorStyles.None
        sbMType.FormattingEnabled = True
        sbMType.Location = New Point(24, 505)
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
        cbStype.FormattingEnabled = True
        cbStype.Items.AddRange(New Object() {"Repair", "Resize"})
        cbStype.Location = New Point(152, 141)
        cbStype.Name = "cbStype"
        cbStype.Size = New System.Drawing.Size(121, 23)
        cbStype.TabIndex = 1
        ' 
        ' cbGarment
        ' 
        cbGarment.FormattingEnabled = True
        cbGarment.Items.AddRange(New Object() {"Cotton", "Silk", "Leather"})
        cbGarment.Location = New Point(382, 505)
        cbGarment.Name = "cbGarment"
        cbGarment.Size = New System.Drawing.Size(88, 23)
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
        tbOrderName.TabIndex = 4
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
        lblDesc.Location = New Point(660, 307)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New System.Drawing.Size(137, 32)
        lblDesc.TabIndex = 7
        lblDesc.Text = "Description"
        ' 
        ' rbDescription
        ' 
        rbDescription.Anchor = AnchorStyles.None
        rbDescription.BackColor = Color.FromArgb(CByte(194), CByte(194), CByte(194))
        rbDescription.Location = New Point(660, 367)
        rbDescription.MaxLength = 20000
        rbDescription.Name = "rbDescription"
        rbDescription.ScrollBars = RichTextBoxScrollBars.Vertical
        rbDescription.Size = New System.Drawing.Size(399, 133)
        rbDescription.TabIndex = 8
        rbDescription.Text = ""
        ' 
        ' lblSize
        ' 
        lblSize.Anchor = AnchorStyles.None
        lblSize.AutoSize = True
        lblSize.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSize.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblSize.Location = New Point(30, 280)
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
        dgMeasurements.Location = New Point(28, 332)
        dgMeasurements.Name = "dgMeasurements"
        dgMeasurements.Size = New System.Drawing.Size(545, 144)
        dgMeasurements.TabIndex = 10
        ' 
        ' size_type
        ' 
        size_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        size_type.HeaderText = "Body Measurement"
        size_type.Name = "size_type"
        size_type.Width = 124
        ' 
        ' measurement
        ' 
        measurement.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        measurement.HeaderText = "Measurement"
        measurement.Name = "measurement"
        ' 
        ' GarmentType
        ' 
        GarmentType.HeaderText = "Garment Type"
        GarmentType.Name = "GarmentType"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label3.Location = New Point(54, 184)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(33, 15)
        Label3.TabIndex = 20
        Label3.Text = "Price"
        ' 
        ' nudPrice
        ' 
        nudPrice.Anchor = AnchorStyles.None
        nudPrice.Location = New Point(152, 182)
        nudPrice.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        nudPrice.Name = "nudPrice"
        nudPrice.Size = New System.Drawing.Size(120, 23)
        nudPrice.TabIndex = 19
        ' 
        ' pnAddOrders
        ' 
        pnAddOrders.Anchor = AnchorStyles.None
        pnAddOrders.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnAddOrders.BackColor = Color.White
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
        pnAddOrders.Location = New Point(290, 83)
        pnAddOrders.Name = "pnAddOrders"
        pnAddOrders.Size = New System.Drawing.Size(1074, 691)
        pnAddOrders.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(650, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(399, 260)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(254), CByte(254))
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New System.Drawing.Size(284, 1066)
        Panel2.TabIndex = 19
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.BurlyWood
        Button4.Location = New Point(3, 363)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(29, 0, 0, 0)
        Button4.Size = New System.Drawing.Size(281, 45)
        Button4.TabIndex = 11
        Button4.Text = "Settings"
        Button4.TextAlign = ContentAlignment.MiddleLeft
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(217), CByte(185), CByte(155))
        Button3.Location = New Point(3, 322)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(29, 0, 0, 0)
        Button3.Size = New System.Drawing.Size(281, 45)
        Button3.TabIndex = 10
        Button3.Text = "Search"
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        Button2.Location = New Point(3, 280)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(29, 0, 0, 0)
        Button2.Size = New System.Drawing.Size(281, 45)
        Button2.TabIndex = 9
        Button2.Text = "Home"
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(39, 83)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New System.Drawing.Size(203, 142)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' Timer1
        ' 
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.BackColor = Color.WhiteSmoke
        Label4.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label4.Location = New Point(30, 37)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(137, 32)
        Label4.TabIndex = 23
        Label4.Text = "Description"
        ' 
        ' AddOrder
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        ClientSize = New System.Drawing.Size(1370, 749)
        Controls.Add(pnAddOrders)
        Controls.Add(Panel2)
        Controls.Add(lblAddMoreOrders)
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
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblAddMoreOrders As Label
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
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents size_type As DataGridViewTextBoxColumn
    Friend WithEvents measurement As DataGridViewTextBoxColumn
    Friend WithEvents GarmentType As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label4 As Label
End Class
