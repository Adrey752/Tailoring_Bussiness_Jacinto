<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderDisplay
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
        pnAddOrders = New Panel()
        Label4 = New Label()
        rbDescription = New RichTextBox()
        Label3 = New Label()
        lblAmountToPay = New Label()
        dtpOrderDate = New DateTimePicker()
        btnAddImage = New Button()
        btnRemoveImage = New Button()
        ComboBox1 = New ComboBox()
        Label2 = New Label()
        headerOrder = New Label()
        btnCancel = New Button()
        OrderPicturebox = New PictureBox()
        btnOrderSave = New Button()
        lblPrice = New Label()
        btnaddMeasurement = New Button()
        nudValue = New NumericUpDown()
        dgMeasurements = New DataGridView()
        size_type = New DataGridViewTextBoxColumn()
        measurement = New DataGridViewTextBoxColumn()
        GarmentType = New DataGridViewTextBoxColumn()
        cbUnit = New ComboBox()
        lblSize = New Label()
        lblDesc = New Label()
        lblorderName = New Label()
        tbOrderName = New TextBox()
        sbMType = New ComboBox()
        cbGarment = New ComboBox()
        cbStype = New ComboBox()
        lblServiceType = New Label()
        pnAddOrders.SuspendLayout()
        CType(OrderPicturebox, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudValue, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pnAddOrders
        ' 
        pnAddOrders.Anchor = AnchorStyles.None
        pnAddOrders.BackColor = Color.White
        pnAddOrders.Controls.Add(Label4)
        pnAddOrders.Controls.Add(rbDescription)
        pnAddOrders.Controls.Add(Label3)
        pnAddOrders.Controls.Add(lblAmountToPay)
        pnAddOrders.Controls.Add(dtpOrderDate)
        pnAddOrders.Controls.Add(btnAddImage)
        pnAddOrders.Controls.Add(btnRemoveImage)
        pnAddOrders.Controls.Add(ComboBox1)
        pnAddOrders.Controls.Add(Label2)
        pnAddOrders.Controls.Add(headerOrder)
        pnAddOrders.Controls.Add(btnCancel)
        pnAddOrders.Controls.Add(OrderPicturebox)
        pnAddOrders.Controls.Add(btnOrderSave)
        pnAddOrders.Controls.Add(lblPrice)
        pnAddOrders.Controls.Add(btnaddMeasurement)
        pnAddOrders.Controls.Add(nudValue)
        pnAddOrders.Controls.Add(dgMeasurements)
        pnAddOrders.Controls.Add(cbUnit)
        pnAddOrders.Controls.Add(lblSize)
        pnAddOrders.Controls.Add(lblDesc)
        pnAddOrders.Controls.Add(lblorderName)
        pnAddOrders.Controls.Add(tbOrderName)
        pnAddOrders.Controls.Add(sbMType)
        pnAddOrders.Controls.Add(cbGarment)
        pnAddOrders.Controls.Add(cbStype)
        pnAddOrders.Controls.Add(lblServiceType)
        pnAddOrders.Location = New Point(17, 0)
        pnAddOrders.Name = "pnAddOrders"
        pnAddOrders.Size = New System.Drawing.Size(998, 653)
        pnAddOrders.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label4.Location = New Point(131, 206)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(30, 15)
        Label4.TabIndex = 69
        Label4.Text = "Paid"
        ' 
        ' rbDescription
        ' 
        rbDescription.Anchor = AnchorStyles.None
        rbDescription.BackColor = Color.FromArgb(CByte(194), CByte(194), CByte(194))
        rbDescription.Location = New Point(28, 277)
        rbDescription.MaxLength = 20000
        rbDescription.Name = "rbDescription"
        rbDescription.ScrollBars = RichTextBoxScrollBars.Vertical
        rbDescription.Size = New System.Drawing.Size(438, 125)
        rbDescription.TabIndex = 8
        rbDescription.Text = ""
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label3.Location = New Point(28, 206)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(89, 15)
        Label3.TabIndex = 68
        Label3.Text = "Payment Status"
        ' 
        ' lblAmountToPay
        ' 
        lblAmountToPay.Anchor = AnchorStyles.Left
        lblAmountToPay.AutoSize = True
        lblAmountToPay.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblAmountToPay.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblAmountToPay.Location = New Point(131, 167)
        lblAmountToPay.Name = "lblAmountToPay"
        lblAmountToPay.Size = New System.Drawing.Size(105, 25)
        lblAmountToPay.TabIndex = 67
        lblAmountToPay.Text = "₱ 2,550.00"
        ' 
        ' dtpOrderDate
        ' 
        dtpOrderDate.Location = New Point(298, 39)
        dtpOrderDate.Name = "dtpOrderDate"
        dtpOrderDate.Size = New System.Drawing.Size(200, 23)
        dtpOrderDate.TabIndex = 32
        ' 
        ' btnAddImage
        ' 
        btnAddImage.Anchor = AnchorStyles.None
        btnAddImage.Location = New Point(777, 345)
        btnAddImage.Name = "btnAddImage"
        btnAddImage.Size = New System.Drawing.Size(99, 41)
        btnAddImage.TabIndex = 31
        btnAddImage.Text = "Upload Image"
        btnAddImage.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveImage
        ' 
        btnRemoveImage.Anchor = AnchorStyles.None
        btnRemoveImage.Location = New Point(888, 345)
        btnRemoveImage.Name = "btnRemoveImage"
        btnRemoveImage.Size = New System.Drawing.Size(98, 41)
        btnRemoveImage.TabIndex = 30
        btnRemoveImage.Text = "Remove Image"
        btnRemoveImage.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Anchor = AnchorStyles.None
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Small T-Shirt", "Large T-Shirt", "X-Large T-Shirt"})
        ComboBox1.Location = New Point(330, 452)
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
        Label2.Location = New Point(194, 452)
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
        ' btnCancel
        ' 
        btnCancel.Anchor = AnchorStyles.None
        btnCancel.BackColor = Color.SeaShell
        btnCancel.Location = New Point(882, 601)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New System.Drawing.Size(104, 41)
        btnCancel.TabIndex = 24
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' OrderPicturebox
        ' 
        OrderPicturebox.Anchor = AnchorStyles.None
        OrderPicturebox.ErrorImage = My.Resources.Resources.eye
        OrderPicturebox.Image = My.Resources.Resources.noImageIcon
        OrderPicturebox.Location = New Point(520, 32)
        OrderPicturebox.Name = "OrderPicturebox"
        OrderPicturebox.Size = New System.Drawing.Size(466, 297)
        OrderPicturebox.SizeMode = PictureBoxSizeMode.Zoom
        OrderPicturebox.TabIndex = 12
        OrderPicturebox.TabStop = False
        ' 
        ' btnOrderSave
        ' 
        btnOrderSave.Anchor = AnchorStyles.None
        btnOrderSave.BackColor = Color.SeaShell
        btnOrderSave.Location = New Point(772, 601)
        btnOrderSave.Name = "btnOrderSave"
        btnOrderSave.Size = New System.Drawing.Size(104, 41)
        btnOrderSave.TabIndex = 3
        btnOrderSave.Text = "Save"
        btnOrderSave.UseVisualStyleBackColor = False
        ' 
        ' lblPrice
        ' 
        lblPrice.Anchor = AnchorStyles.None
        lblPrice.AutoSize = True
        lblPrice.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblPrice.Location = New Point(28, 167)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New System.Drawing.Size(33, 15)
        lblPrice.TabIndex = 20
        lblPrice.Text = "Price"
        ' 
        ' btnaddMeasurement
        ' 
        btnaddMeasurement.Anchor = AnchorStyles.None
        btnaddMeasurement.Location = New Point(391, 545)
        btnaddMeasurement.Name = "btnaddMeasurement"
        btnaddMeasurement.Size = New System.Drawing.Size(75, 41)
        btnaddMeasurement.TabIndex = 7
        btnaddMeasurement.Text = "Add Size"
        btnaddMeasurement.UseVisualStyleBackColor = True
        ' 
        ' nudValue
        ' 
        nudValue.Anchor = AnchorStyles.None
        nudValue.Location = New Point(178, 491)
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
        dgMeasurements.Location = New Point(520, 407)
        dgMeasurements.Name = "dgMeasurements"
        dgMeasurements.Size = New System.Drawing.Size(466, 179)
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
        cbUnit.Location = New Point(286, 490)
        cbUnit.Name = "cbUnit"
        cbUnit.Size = New System.Drawing.Size(77, 23)
        cbUnit.TabIndex = 5
        cbUnit.Text = "inches"
        ' 
        ' lblSize
        ' 
        lblSize.Anchor = AnchorStyles.None
        lblSize.AutoSize = True
        lblSize.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblSize.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblSize.Location = New Point(60, 441)
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
        lblDesc.Location = New Point(24, 242)
        lblDesc.Name = "lblDesc"
        lblDesc.Size = New System.Drawing.Size(137, 32)
        lblDesc.TabIndex = 7
        lblDesc.Text = "Description"
        ' 
        ' lblorderName
        ' 
        lblorderName.AutoSize = True
        lblorderName.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblorderName.Location = New Point(28, 83)
        lblorderName.Name = "lblorderName"
        lblorderName.Size = New System.Drawing.Size(72, 15)
        lblorderName.TabIndex = 5
        lblorderName.Text = "Order Name"
        ' 
        ' tbOrderName
        ' 
        tbOrderName.Location = New Point(131, 83)
        tbOrderName.MaxLength = 150
        tbOrderName.Name = "tbOrderName"
        tbOrderName.PlaceholderText = "Enter Order Name"
        tbOrderName.Size = New System.Drawing.Size(121, 23)
        tbOrderName.TabIndex = 0
        ' 
        ' sbMType
        ' 
        sbMType.Anchor = AnchorStyles.None
        sbMType.FormattingEnabled = True
        sbMType.Location = New Point(70, 490)
        sbMType.Name = "sbMType"
        sbMType.Size = New System.Drawing.Size(102, 23)
        sbMType.TabIndex = 3
        sbMType.Text = "Waist"
        ' 
        ' cbGarment
        ' 
        cbGarment.FormattingEnabled = True
        cbGarment.Items.AddRange(New Object() {"Cotton", "Silk", "Leather"})
        cbGarment.Location = New Point(373, 490)
        cbGarment.Name = "cbGarment"
        cbGarment.Size = New System.Drawing.Size(66, 23)
        cbGarment.TabIndex = 6
        cbGarment.Text = "Cotton"
        ' 
        ' cbStype
        ' 
        cbStype.FormattingEnabled = True
        cbStype.Items.AddRange(New Object() {"Repair", "Resize"})
        cbStype.Location = New Point(131, 129)
        cbStype.Name = "cbStype"
        cbStype.Size = New System.Drawing.Size(121, 23)
        cbStype.TabIndex = 1
        ' 
        ' lblServiceType
        ' 
        lblServiceType.AutoSize = True
        lblServiceType.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblServiceType.Location = New Point(28, 117)
        lblServiceType.Name = "lblServiceType"
        lblServiceType.Size = New System.Drawing.Size(71, 15)
        lblServiceType.TabIndex = 0
        lblServiceType.Text = "Service Type"
        ' 
        ' OrderDisplay
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(1022, 654)
        Controls.Add(pnAddOrders)
        Name = "OrderDisplay"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Order Display"
        pnAddOrders.ResumeLayout(False)
        pnAddOrders.PerformLayout()
        CType(OrderPicturebox, ComponentModel.ISupportInitialize).EndInit()
        CType(nudValue, ComponentModel.ISupportInitialize).EndInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents pnAddOrders As Panel
    Friend WithEvents OrderPicturebox As PictureBox
    Friend WithEvents btnOrderSave As Button
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
    Friend WithEvents btnCancel As Button
    Friend WithEvents headerOrder As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents size_type As DataGridViewTextBoxColumn
    Friend WithEvents measurement As DataGridViewTextBoxColumn
    Friend WithEvents GarmentType As DataGridViewTextBoxColumn
    Friend WithEvents btnAddImage As Button
    Friend WithEvents btnRemoveImage As Button
    Friend WithEvents dtpOrderDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAmountToPay As Label
End Class
