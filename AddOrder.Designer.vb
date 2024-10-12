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
        lblType = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        Label1 = New Label()
        cbStype = New ComboBox()
        Label2 = New Label()
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
        nudPayment = New NumericUpDown()
        lblPayment = New Label()
        Panel2 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        PictureBox2 = New PictureBox()
        Timer1 = New Timer(components)
        CType(nudValue, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).BeginInit()
        pnAddOrders.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPayment, ComponentModel.ISupportInitialize).BeginInit()
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
        lblAddMoreOrders.Size = New Size(203, 32)
        lblAddMoreOrders.TabIndex = 1
        lblAddMoreOrders.Text = "Add More Orders"
        ' 
        ' btnOrderSave
        ' 
        btnOrderSave.Anchor = AnchorStyles.None
        btnOrderSave.BackColor = Color.SeaShell
        btnOrderSave.Location = New Point(679, 557)
        btnOrderSave.Name = "btnOrderSave"
        btnOrderSave.Size = New Size(104, 41)
        btnOrderSave.TabIndex = 3
        btnOrderSave.Text = "Save"
        btnOrderSave.UseVisualStyleBackColor = False
        ' 
        ' nudValue
        ' 
        nudValue.Anchor = AnchorStyles.None
        nudValue.Location = New Point(251, 197)
        nudValue.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        nudValue.Name = "nudValue"
        nudValue.Size = New Size(120, 23)
        nudValue.TabIndex = 18
        ' 
        ' btnaddMeasurement
        ' 
        btnaddMeasurement.Anchor = AnchorStyles.None
        btnaddMeasurement.Location = New Point(504, 196)
        btnaddMeasurement.Name = "btnaddMeasurement"
        btnaddMeasurement.Size = New Size(75, 23)
        btnaddMeasurement.TabIndex = 17
        btnaddMeasurement.Text = "Add Size"
        btnaddMeasurement.UseVisualStyleBackColor = True
        ' 
        ' cbUnit
        ' 
        cbUnit.Anchor = AnchorStyles.None
        cbUnit.FormattingEnabled = True
        cbUnit.Items.AddRange(New Object() {"cm", "inches", "meters"})
        cbUnit.Location = New Point(377, 197)
        cbUnit.Name = "cbUnit"
        cbUnit.Size = New Size(121, 23)
        cbUnit.TabIndex = 16
        cbUnit.Text = "inch"
        ' 
        ' sbMType
        ' 
        sbMType.Anchor = AnchorStyles.None
        sbMType.FormattingEnabled = True
        sbMType.Location = New Point(124, 196)
        sbMType.Name = "sbMType"
        sbMType.Size = New Size(121, 23)
        sbMType.TabIndex = 12
        sbMType.Text = "Waist"
        ' 
        ' lblType
        ' 
        lblType.Anchor = AnchorStyles.None
        lblType.AutoSize = True
        lblType.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblType.Location = New Point(87, 199)
        lblType.Name = "lblType"
        lblType.Size = New Size(31, 15)
        lblType.TabIndex = 11
        lblType.Text = "Type"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label1.Location = New Point(65, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 0
        Label1.Text = "Service Type"
        ' 
        ' cbStype
        ' 
        cbStype.FormattingEnabled = True
        cbStype.Items.AddRange(New Object() {"Repair", "Resize"})
        cbStype.Location = New Point(167, 88)
        cbStype.Name = "cbStype"
        cbStype.Size = New Size(121, 23)
        cbStype.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label2.Location = New Point(87, 248)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 15)
        Label2.TabIndex = 2
        Label2.Text = "Garment Type"
        ' 
        ' cbGarment
        ' 
        cbGarment.FormattingEnabled = True
        cbGarment.Items.AddRange(New Object() {"Cotton", "Silk", "Leather"})
        cbGarment.Location = New Point(167, 245)
        cbGarment.Name = "cbGarment"
        cbGarment.Size = New Size(121, 23)
        cbGarment.TabIndex = 3
        cbGarment.Text = "Cotton"
        ' 
        ' tbOrderName
        ' 
        tbOrderName.Location = New Point(167, 43)
        tbOrderName.MaxLength = 150
        tbOrderName.Name = "tbOrderName"
        tbOrderName.PlaceholderText = "Enter Order Name"
        tbOrderName.Size = New Size(121, 23)
        tbOrderName.TabIndex = 4
        ' 
        ' lblorderName
        ' 
        lblorderName.AutoSize = True
        lblorderName.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblorderName.Location = New Point(65, 48)
        lblorderName.Name = "lblorderName"
        lblorderName.Size = New Size(72, 15)
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
        lblDesc.Location = New Point(76, 338)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New Size(137, 32)
        lblDesc.TabIndex = 7
        lblDesc.Text = "Description"
        ' 
        ' rbDescription
        ' 
        rbDescription.Anchor = AnchorStyles.None
        rbDescription.BackColor = Color.FromArgb(CByte(194), CByte(194), CByte(194))
        rbDescription.Location = New Point(140, 388)
        rbDescription.MaxLength = 20000
        rbDescription.Name = "rbDescription"
        rbDescription.ScrollBars = RichTextBoxScrollBars.Vertical
        rbDescription.Size = New Size(399, 162)
        rbDescription.TabIndex = 8
        rbDescription.Text = ""
        ' 
        ' lblSize
        ' 
        lblSize.Anchor = AnchorStyles.None
        lblSize.AutoSize = True
        lblSize.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSize.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblSize.Location = New Point(76, 140)
        lblSize.Name = "lblSize"
        lblSize.Size = New Size(57, 32)
        lblSize.TabIndex = 9
        lblSize.Text = "Size"
        ' 
        ' dgMeasurements
        ' 
        dgMeasurements.Anchor = AnchorStyles.None
        dgMeasurements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgMeasurements.Columns.AddRange(New DataGridViewColumn() {size_type, measurement, GarmentType})
        dgMeasurements.Location = New Point(679, 109)
        dgMeasurements.Name = "dgMeasurements"
        dgMeasurements.Size = New Size(362, 144)
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
        Label3.Location = New Point(830, 66)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 15)
        Label3.TabIndex = 20
        Label3.Text = "Amount Due"
        ' 
        ' nudPrice
        ' 
        nudPrice.Anchor = AnchorStyles.None
        nudPrice.Location = New Point(921, 64)
        nudPrice.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        nudPrice.Name = "nudPrice"
        nudPrice.Size = New Size(120, 23)
        nudPrice.TabIndex = 19
        ' 
        ' pnAddOrders
        ' 
        pnAddOrders.Anchor = AnchorStyles.None
        pnAddOrders.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnAddOrders.BackColor = Color.White
        pnAddOrders.Controls.Add(PictureBox1)
        pnAddOrders.Controls.Add(nudPayment)
        pnAddOrders.Controls.Add(lblPayment)
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
        pnAddOrders.Controls.Add(lblType)
        pnAddOrders.Controls.Add(tbOrderName)
        pnAddOrders.Controls.Add(sbMType)
        pnAddOrders.Controls.Add(cbGarment)
        pnAddOrders.Controls.Add(Label2)
        pnAddOrders.Controls.Add(cbStype)
        pnAddOrders.Controls.Add(Label1)
        pnAddOrders.Location = New Point(290, 83)
        pnAddOrders.Name = "pnAddOrders"
        pnAddOrders.Size = New Size(1074, 691)
        pnAddOrders.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(679, 280)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(362, 244)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' nudPayment
        ' 
        nudPayment.Anchor = AnchorStyles.None
        nudPayment.Location = New Point(921, 30)
        nudPayment.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        nudPayment.Name = "nudPayment"
        nudPayment.Size = New Size(120, 23)
        nudPayment.TabIndex = 22
        ' 
        ' lblPayment
        ' 
        lblPayment.Anchor = AnchorStyles.None
        lblPayment.AutoSize = True
        lblPayment.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblPayment.Location = New Point(829, 35)
        lblPayment.Name = "lblPayment"
        lblPayment.Size = New Size(80, 15)
        lblPayment.TabIndex = 21
        lblPayment.Text = " Amount Paid"
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
        Panel2.Size = New Size(284, 1066)
        Panel2.TabIndex = 19
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.BurlyWood
        Button4.Location = New Point(3, 363)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(29, 0, 0, 0)
        Button4.Size = New Size(281, 45)
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
        Button3.Size = New Size(281, 45)
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
        Button2.Size = New Size(281, 45)
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
        PictureBox2.Size = New Size(203, 142)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' AddOrder
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        ClientSize = New Size(1370, 749)
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
        CType(nudPayment, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblAddMoreOrders As Label
    Friend WithEvents sbMType As ComboBox
    Friend WithEvents lblType As Label
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
    Friend WithEvents Label2 As Label
    Friend WithEvents cbStype As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents nudPayment As NumericUpDown
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
End Class
