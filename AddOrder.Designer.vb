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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddOrder))
        PictureBoxLogo = New PictureBox()
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
        unit = New DataGridViewTextBoxColumn()
        Label3 = New Label()
        nudPrice = New NumericUpDown()
        pnAddOrders = New Panel()
        nudPayment = New NumericUpDown()
        lblPayment = New Label()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudValue, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).BeginInit()
        pnAddOrders.SuspendLayout()
        CType(nudPayment, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.Anchor = AnchorStyles.None
        PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), Image)
        PictureBoxLogo.Location = New Point(416, 22)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(203, 136)
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxLogo.TabIndex = 0
        PictureBoxLogo.TabStop = False
        ' 
        ' lblAddMoreOrders
        ' 
        lblAddMoreOrders.Anchor = AnchorStyles.None
        lblAddMoreOrders.AutoSize = True
        lblAddMoreOrders.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddMoreOrders.ForeColor = Color.BlanchedAlmond
        lblAddMoreOrders.Location = New Point(51, 126)
        lblAddMoreOrders.Name = "lblAddMoreOrders"
        lblAddMoreOrders.Size = New Size(203, 32)
        lblAddMoreOrders.TabIndex = 1
        lblAddMoreOrders.Text = "Add More Orders"
        ' 
        ' btnOrderSave
        ' 
        btnOrderSave.Anchor = AnchorStyles.None
        btnOrderSave.BackColor = Color.SandyBrown
        btnOrderSave.Location = New Point(795, 547)
        btnOrderSave.Name = "btnOrderSave"
        btnOrderSave.Size = New Size(104, 41)
        btnOrderSave.TabIndex = 3
        btnOrderSave.Text = "Save"
        btnOrderSave.UseVisualStyleBackColor = False
        ' 
        ' nudValue
        ' 
        nudValue.Anchor = AnchorStyles.None
        nudValue.Location = New Point(260, 566)
        nudValue.Name = "nudValue"
        nudValue.Size = New Size(120, 23)
        nudValue.TabIndex = 18
        ' 
        ' btnaddMeasurement
        ' 
        btnaddMeasurement.Anchor = AnchorStyles.None
        btnaddMeasurement.Location = New Point(522, 565)
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
        cbUnit.Location = New Point(386, 566)
        cbUnit.Name = "cbUnit"
        cbUnit.Size = New Size(121, 23)
        cbUnit.TabIndex = 16
        cbUnit.Text = "inch"
        ' 
        ' sbMType
        ' 
        sbMType.Anchor = AnchorStyles.None
        sbMType.FormattingEnabled = True
        sbMType.Location = New Point(133, 566)
        sbMType.Name = "sbMType"
        sbMType.Size = New Size(121, 23)
        sbMType.TabIndex = 12
        sbMType.Text = "Waist"
        ' 
        ' lblType
        ' 
        lblType.Anchor = AnchorStyles.None
        lblType.AutoSize = True
        lblType.ForeColor = Color.White
        lblType.Location = New Point(92, 569)
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
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 15)
        Label1.TabIndex = 0
        Label1.Text = "Service Type"
        ' 
        ' cbStype
        ' 
        cbStype.FormattingEnabled = True
        cbStype.Items.AddRange(New Object() {"Repair", "Resize"})
        cbStype.Location = New Point(105, 61)
        cbStype.Name = "cbStype"
        cbStype.Size = New Size(121, 23)
        cbStype.TabIndex = 1
        cbStype.Text = "Repair"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(689, 16)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 15)
        Label2.TabIndex = 2
        Label2.Text = "Garment Type"
        ' 
        ' cbGarment
        ' 
        cbGarment.FormattingEnabled = True
        cbGarment.Items.AddRange(New Object() {"Silk", "Cotton"})
        cbGarment.Location = New Point(780, 8)
        cbGarment.Name = "cbGarment"
        cbGarment.Size = New Size(121, 23)
        cbGarment.TabIndex = 3
        cbGarment.Text = "Silk"
        ' 
        ' tbOrderName
        ' 
        tbOrderName.Location = New Point(105, 16)
        tbOrderName.Name = "tbOrderName"
        tbOrderName.PlaceholderText = "Enter Order Name"
        tbOrderName.Size = New Size(207, 23)
        tbOrderName.TabIndex = 4
        ' 
        ' lblorderName
        ' 
        lblorderName.AutoSize = True
        lblorderName.ForeColor = Color.White
        lblorderName.Location = New Point(3, 21)
        lblorderName.Name = "lblorderName"
        lblorderName.Size = New Size(72, 15)
        lblorderName.TabIndex = 5
        lblorderName.Text = "Order Name"
        ' 
        ' lblDesc
        ' 
        lblDesc.Anchor = AnchorStyles.None
        lblDesc.AutoSize = True
        lblDesc.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDesc.ForeColor = Color.White
        lblDesc.Location = New Point(3, 101)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New Size(137, 32)
        lblDesc.TabIndex = 7
        lblDesc.Text = "Description"
        ' 
        ' rbDescription
        ' 
        rbDescription.Anchor = AnchorStyles.None
        rbDescription.Location = New Point(3, 145)
        rbDescription.Name = "rbDescription"
        rbDescription.ScrollBars = RichTextBoxScrollBars.Vertical
        rbDescription.Size = New Size(616, 210)
        rbDescription.TabIndex = 8
        rbDescription.Text = ""
        ' 
        ' lblSize
        ' 
        lblSize.Anchor = AnchorStyles.None
        lblSize.AutoSize = True
        lblSize.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSize.ForeColor = Color.White
        lblSize.Location = New Point(63, 537)
        lblSize.Name = "lblSize"
        lblSize.Size = New Size(57, 32)
        lblSize.TabIndex = 9
        lblSize.Text = "Size"
        ' 
        ' dgMeasurements
        ' 
        dgMeasurements.Anchor = AnchorStyles.None
        dgMeasurements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgMeasurements.Columns.AddRange(New DataGridViewColumn() {size_type, measurement, unit})
        dgMeasurements.Location = New Point(642, 145)
        dgMeasurements.Name = "dgMeasurements"
        dgMeasurements.Size = New Size(263, 210)
        dgMeasurements.TabIndex = 10
        ' 
        ' size_type
        ' 
        size_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        size_type.HeaderText = "Type"
        size_type.Name = "size_type"
        size_type.Width = 60
        ' 
        ' measurement
        ' 
        measurement.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        measurement.HeaderText = "Measurement"
        measurement.Name = "measurement"
        ' 
        ' unit
        ' 
        unit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        unit.HeaderText = "Unit"
        unit.Name = "unit"
        unit.Width = 60
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.ForeColor = Color.White
        Label3.Location = New Point(689, 85)
        Label3.Name = "Label3"
        Label3.Size = New Size(33, 15)
        Label3.TabIndex = 20
        Label3.Text = "Price"
        ' 
        ' nudPrice
        ' 
        nudPrice.Anchor = AnchorStyles.None
        nudPrice.Location = New Point(780, 83)
        nudPrice.Name = "nudPrice"
        nudPrice.Size = New Size(120, 23)
        nudPrice.TabIndex = 19
        ' 
        ' pnAddOrders
        ' 
        pnAddOrders.Anchor = AnchorStyles.None
        pnAddOrders.AutoSizeMode = AutoSizeMode.GrowAndShrink
        pnAddOrders.Controls.Add(nudPayment)
        pnAddOrders.Controls.Add(lblPayment)
        pnAddOrders.Controls.Add(nudPrice)
        pnAddOrders.Controls.Add(Label3)
        pnAddOrders.Controls.Add(dgMeasurements)
        pnAddOrders.Controls.Add(rbDescription)
        pnAddOrders.Controls.Add(lblDesc)
        pnAddOrders.Controls.Add(lblorderName)
        pnAddOrders.Controls.Add(tbOrderName)
        pnAddOrders.Controls.Add(cbGarment)
        pnAddOrders.Controls.Add(Label2)
        pnAddOrders.Controls.Add(cbStype)
        pnAddOrders.Controls.Add(Label1)
        pnAddOrders.Location = New Point(60, 178)
        pnAddOrders.Name = "pnAddOrders"
        pnAddOrders.Size = New Size(912, 360)
        pnAddOrders.TabIndex = 2
        ' 
        ' nudPayment
        ' 
        nudPayment.Anchor = AnchorStyles.None
        nudPayment.Location = New Point(781, 48)
        nudPayment.Name = "nudPayment"
        nudPayment.Size = New Size(120, 23)
        nudPayment.TabIndex = 22
        ' 
        ' lblPayment
        ' 
        lblPayment.Anchor = AnchorStyles.None
        lblPayment.AutoSize = True
        lblPayment.ForeColor = Color.White
        lblPayment.Location = New Point(689, 50)
        lblPayment.Name = "lblPayment"
        lblPayment.Size = New Size(54, 15)
        lblPayment.TabIndex = 21
        lblPayment.Text = "Payment"
        ' 
        ' AddOrder
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        ClientSize = New Size(984, 661)
        Controls.Add(btnOrderSave)
        Controls.Add(pnAddOrders)
        Controls.Add(btnaddMeasurement)
        Controls.Add(nudValue)
        Controls.Add(cbUnit)
        Controls.Add(lblSize)
        Controls.Add(lblAddMoreOrders)
        Controls.Add(PictureBoxLogo)
        Controls.Add(lblType)
        Controls.Add(sbMType)
        ForeColor = Color.Black
        Name = "AddOrder"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddOrder"
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        CType(nudValue, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).EndInit()
        pnAddOrders.ResumeLayout(False)
        pnAddOrders.PerformLayout()
        CType(nudPayment, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBoxLogo As PictureBox
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
    Friend WithEvents size_type As DataGridViewTextBoxColumn
    Friend WithEvents measurement As DataGridViewTextBoxColumn
    Friend WithEvents unit As DataGridViewTextBoxColumn
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
End Class
