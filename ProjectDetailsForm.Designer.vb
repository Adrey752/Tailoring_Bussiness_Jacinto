<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProjectDetailsForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProjectDetailsForm))
        lblTask = New Label()
        tbNumber = New TextBox()
        tbAddress = New TextBox()
        lblAddress = New Label()
        lblContactNumber = New Label()
        dgSortOrders = New DataGridView()
        pendingCheckBox = New DataGridViewCheckBoxColumn()
        pending = New DataGridViewTextBoxColumn()
        finishedCheckBox = New DataGridViewCheckBoxColumn()
        finished = New DataGridViewTextBoxColumn()
        claimed = New DataGridViewTextBoxColumn()
        cbSort = New ComboBox()
        lblPayment = New Label()
        lblTotalPrice = New Label()
        lblNumOrders = New Label()
        nudOrders = New NumericUpDown()
        lblHeaderOrder = New Label()
        btnAddOrder = New Button()
        dgPaymentHistory = New DataGridView()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        colOrdersPaid = New DataGridViewTextBoxColumn()
        lblDue = New Label()
        lblPaid = New Label()
        Panel1 = New Panel()
        lblBalance = New Label()
        Label4 = New Label()
        btnMakePayment = New Button()
        tbName = New TextBox()
        LblName = New Label()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        pnNavigation = New Panel()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        pbTailoringJacinto = New PictureBox()
        btnSettings = New Button()
        btnSearch = New Button()
        btnHome = New Button()
        Panel6 = New Panel()
        lblCustomerDetails = New Label()
        Panel7 = New Panel()
        lblHeaderPayment = New Label()
        CType(dgSortOrders, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudOrders, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgPaymentHistory, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        pnNavigation.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbTailoringJacinto, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTask
        ' 
        lblTask.AutoSize = True
        lblTask.BackColor = Color.Transparent
        lblTask.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTask.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblTask.Location = New Point(110, 434)
        lblTask.Name = "lblTask"
        lblTask.Size = New Size(76, 27)
        lblTask.TabIndex = 14
        lblTask.Text = "Order"
        ' 
        ' tbNumber
        ' 
        tbNumber.BackColor = Color.White
        tbNumber.Location = New Point(136, 15)
        tbNumber.MaxLength = 11
        tbNumber.Name = "tbNumber"
        tbNumber.PlaceholderText = "Enter Phone Number"
        tbNumber.ReadOnly = True
        tbNumber.Size = New Size(410, 23)
        tbNumber.TabIndex = 13
        ' 
        ' tbAddress
        ' 
        tbAddress.BackColor = Color.White
        tbAddress.ForeColor = Color.Black
        tbAddress.Location = New Point(139, 16)
        tbAddress.MaxLength = 150
        tbAddress.Name = "tbAddress"
        tbAddress.PlaceholderText = "Enter Address"
        tbAddress.ReadOnly = True
        tbAddress.Size = New Size(410, 23)
        tbAddress.TabIndex = 12
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.BackColor = Color.Transparent
        lblAddress.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAddress.ForeColor = SystemColors.ActiveCaptionText
        lblAddress.Location = New Point(9, 17)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(64, 18)
        lblAddress.TabIndex = 10
        lblAddress.Text = "Address:"
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.BackColor = Color.White
        lblContactNumber.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblContactNumber.ForeColor = SystemColors.ActiveCaptionText
        lblContactNumber.Location = New Point(7, 16)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New Size(123, 18)
        lblContactNumber.TabIndex = 9
        lblContactNumber.Text = "Contact Number: "
        ' 
        ' dgSortOrders
        ' 
        dgSortOrders.AllowDrop = True
        dgSortOrders.AllowUserToAddRows = False
        dgSortOrders.AllowUserToDeleteRows = False
        dgSortOrders.AllowUserToOrderColumns = True
        dgSortOrders.BackgroundColor = Color.White
        dgSortOrders.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        dgSortOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgSortOrders.Columns.AddRange(New DataGridViewColumn() {pendingCheckBox, pending, finishedCheckBox, finished, claimed})
        dgSortOrders.Location = New Point(108, 472)
        dgSortOrders.Name = "dgSortOrders"
        dgSortOrders.ReadOnly = True
        dgSortOrders.Size = New Size(673, 227)
        dgSortOrders.TabIndex = 20
        ' 
        ' pendingCheckBox
        ' 
        pendingCheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        pendingCheckBox.HeaderText = ""
        pendingCheckBox.MinimumWidth = 35
        pendingCheckBox.Name = "pendingCheckBox"
        pendingCheckBox.ReadOnly = True
        pendingCheckBox.Width = 35
        ' 
        ' pending
        ' 
        pending.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        pending.DataPropertyName = "pending"
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        pending.DefaultCellStyle = DataGridViewCellStyle1
        pending.HeaderText = "Pending Orders"
        pending.Name = "pending"
        pending.ReadOnly = True
        pending.Resizable = DataGridViewTriState.True
        pending.Width = 200
        ' 
        ' finishedCheckBox
        ' 
        finishedCheckBox.HeaderText = ""
        finishedCheckBox.MinimumWidth = 35
        finishedCheckBox.Name = "finishedCheckBox"
        finishedCheckBox.ReadOnly = True
        finishedCheckBox.Width = 35
        ' 
        ' finished
        ' 
        finished.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        finished.DataPropertyName = "finished"
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        finished.DefaultCellStyle = DataGridViewCellStyle2
        finished.HeaderText = "Finished"
        finished.Name = "finished"
        finished.ReadOnly = True
        finished.Resizable = DataGridViewTriState.True
        finished.Width = 200
        ' 
        ' claimed
        ' 
        claimed.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        claimed.DataPropertyName = "claimed"
        claimed.HeaderText = "Claimed"
        claimed.Name = "claimed"
        claimed.ReadOnly = True
        claimed.Width = 200
        ' 
        ' cbSort
        ' 
        cbSort.FormattingEnabled = True
        cbSort.Location = New Point(205, 437)
        cbSort.Name = "cbSort"
        cbSort.Size = New Size(66, 23)
        cbSort.TabIndex = 22
        cbSort.Text = "Sort By"
        ' 
        ' lblPayment
        ' 
        lblPayment.Anchor = AnchorStyles.None
        lblPayment.AutoSize = True
        lblPayment.Font = New Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPayment.ForeColor = Color.Black
        lblPayment.Location = New Point(13, 73)
        lblPayment.Name = "lblPayment"
        lblPayment.Size = New Size(102, 21)
        lblPayment.TabIndex = 28
        lblPayment.Text = "Amount Paid:"
        ' 
        ' lblTotalPrice
        ' 
        lblTotalPrice.Anchor = AnchorStyles.None
        lblTotalPrice.AutoSize = True
        lblTotalPrice.Font = New Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotalPrice.ForeColor = Color.Black
        lblTotalPrice.Location = New Point(13, 27)
        lblTotalPrice.Name = "lblTotalPrice"
        lblTotalPrice.Size = New Size(83, 21)
        lblTotalPrice.TabIndex = 31
        lblTotalPrice.Text = "Total Price:"
        ' 
        ' lblNumOrders
        ' 
        lblNumOrders.AutoSize = True
        lblNumOrders.BackColor = Color.Transparent
        lblNumOrders.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNumOrders.ForeColor = Color.Black
        lblNumOrders.Location = New Point(7, 17)
        lblNumOrders.Name = "lblNumOrders"
        lblNumOrders.Size = New Size(132, 18)
        lblNumOrders.TabIndex = 32
        lblNumOrders.Text = "Number of Orders:"
        ' 
        ' nudOrders
        ' 
        nudOrders.Location = New Point(426, 17)
        nudOrders.Name = "nudOrders"
        nudOrders.ReadOnly = True
        nudOrders.Size = New Size(120, 23)
        nudOrders.TabIndex = 33
        ' 
        ' lblHeaderOrder
        ' 
        lblHeaderOrder.AutoSize = True
        lblHeaderOrder.BackColor = Color.Transparent
        lblHeaderOrder.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeaderOrder.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblHeaderOrder.Location = New Point(110, 102)
        lblHeaderOrder.Name = "lblHeaderOrder"
        lblHeaderOrder.Size = New Size(213, 27)
        lblHeaderOrder.TabIndex = 34
        lblHeaderOrder.Text = "Client  Information"
        ' 
        ' btnAddOrder
        ' 
        btnAddOrder.BackColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        btnAddOrder.FlatStyle = FlatStyle.Popup
        btnAddOrder.ForeColor = Color.White
        btnAddOrder.Location = New Point(709, 434)
        btnAddOrder.Name = "btnAddOrder"
        btnAddOrder.Size = New Size(72, 32)
        btnAddOrder.TabIndex = 35
        btnAddOrder.Tag = ""
        btnAddOrder.Text = "Add Order"
        btnAddOrder.UseVisualStyleBackColor = False
        ' 
        ' dgPaymentHistory
        ' 
        dgPaymentHistory.AllowDrop = True
        dgPaymentHistory.AllowUserToAddRows = False
        dgPaymentHistory.AllowUserToDeleteRows = False
        dgPaymentHistory.AllowUserToOrderColumns = True
        dgPaymentHistory.BackgroundColor = Color.White
        dgPaymentHistory.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        dgPaymentHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgPaymentHistory.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, colOrdersPaid})
        dgPaymentHistory.Location = New Point(864, 473)
        dgPaymentHistory.Name = "dgPaymentHistory"
        dgPaymentHistory.ReadOnly = True
        dgPaymentHistory.Size = New Size(472, 222)
        dgPaymentHistory.TabIndex = 36
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewTextBoxColumn2.DataPropertyName = "finished"
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        DataGridViewTextBoxColumn2.HeaderText = "Date"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        DataGridViewTextBoxColumn2.Resizable = DataGridViewTriState.True
        ' 
        ' DataGridViewTextBoxColumn3
        ' 
        DataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewTextBoxColumn3.DataPropertyName = "claimed"
        DataGridViewTextBoxColumn3.HeaderText = "Amount Paid"
        DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        DataGridViewTextBoxColumn3.ReadOnly = True
        DataGridViewTextBoxColumn3.Width = 200
        ' 
        ' colOrdersPaid
        ' 
        colOrdersPaid.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colOrdersPaid.HeaderText = "Orders Paid"
        colOrdersPaid.Name = "colOrdersPaid"
        colOrdersPaid.ReadOnly = True
        ' 
        ' lblDue
        ' 
        lblDue.Anchor = AnchorStyles.None
        lblDue.AutoSize = True
        lblDue.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblDue.ForeColor = Color.FromArgb(CByte(255), CByte(87), CByte(34))
        lblDue.Location = New Point(260, 27)
        lblDue.Name = "lblDue"
        lblDue.Size = New Size(88, 25)
        lblDue.TabIndex = 37
        lblDue.Text = "5,000.00"
        ' 
        ' lblPaid
        ' 
        lblPaid.Anchor = AnchorStyles.None
        lblPaid.AutoSize = True
        lblPaid.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblPaid.ForeColor = Color.FromArgb(CByte(255), CByte(87), CByte(34))
        lblPaid.Location = New Point(260, 73)
        lblPaid.Name = "lblPaid"
        lblPaid.Size = New Size(88, 25)
        lblPaid.TabIndex = 38
        lblPaid.Text = "2,500.00"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(lblBalance)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lblDue)
        Panel1.Controls.Add(lblPaid)
        Panel1.Controls.Add(lblPayment)
        Panel1.Controls.Add(lblTotalPrice)
        Panel1.Location = New Point(910, 176)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(367, 169)
        Panel1.TabIndex = 39
        ' 
        ' lblBalance
        ' 
        lblBalance.Anchor = AnchorStyles.None
        lblBalance.AutoSize = True
        lblBalance.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblBalance.ForeColor = Color.FromArgb(CByte(255), CByte(87), CByte(34))
        lblBalance.Location = New Point(260, 114)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New Size(88, 25)
        lblBalance.TabIndex = 40
        lblBalance.Text = "2,500.00"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(13, 114)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 21)
        Label4.TabIndex = 39
        Label4.Text = "Balance:"
        ' 
        ' btnMakePayment
        ' 
        btnMakePayment.AutoSize = True
        btnMakePayment.BackColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        btnMakePayment.FlatAppearance.BorderSize = 0
        btnMakePayment.FlatStyle = FlatStyle.Flat
        btnMakePayment.ForeColor = Color.White
        btnMakePayment.Location = New Point(910, 360)
        btnMakePayment.Margin = New Padding(0)
        btnMakePayment.Name = "btnMakePayment"
        btnMakePayment.RightToLeft = RightToLeft.No
        btnMakePayment.Size = New Size(367, 37)
        btnMakePayment.TabIndex = 40
        btnMakePayment.Text = "Make Payment"
        btnMakePayment.UseVisualStyleBackColor = False
        ' 
        ' tbName
        ' 
        tbName.BackColor = Color.White
        tbName.ForeColor = Color.Black
        tbName.Location = New Point(136, 13)
        tbName.MaxLength = 150
        tbName.Name = "tbName"
        tbName.PlaceholderText = "Enter Client Name"
        tbName.ReadOnly = True
        tbName.Size = New Size(410, 23)
        tbName.TabIndex = 11
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.BackColor = Color.White
        LblName.Font = New Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblName.ForeColor = SystemColors.ActiveCaptionText
        LblName.Location = New Point(18, 18)
        LblName.Name = "LblName"
        LblName.Size = New Size(55, 18)
        LblName.TabIndex = 8
        LblName.Text = "Name: "
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Controls.Add(tbName)
        Panel2.Controls.Add(LblName)
        Panel2.Location = New Point(170, 167)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(557, 51)
        Panel2.TabIndex = 41
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(lblAddress)
        Panel3.Controls.Add(tbAddress)
        Panel3.Location = New Point(167, 346)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(560, 51)
        Panel3.TabIndex = 42
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(lblContactNumber)
        Panel4.Controls.Add(tbNumber)
        Panel4.Location = New Point(170, 224)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(557, 51)
        Panel4.TabIndex = 42
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.White
        Panel5.Controls.Add(lblNumOrders)
        Panel5.Controls.Add(nudOrders)
        Panel5.Location = New Point(170, 281)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(557, 51)
        Panel5.TabIndex = 42
        ' 
        ' pnNavigation
        ' 
        pnNavigation.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnNavigation.BackColor = Color.FromArgb(CByte(255), CByte(254), CByte(254))
        pnNavigation.Controls.Add(PictureBox3)
        pnNavigation.Controls.Add(PictureBox2)
        pnNavigation.Controls.Add(PictureBox1)
        pnNavigation.Controls.Add(pbTailoringJacinto)
        pnNavigation.Controls.Add(btnSettings)
        pnNavigation.Controls.Add(btnSearch)
        pnNavigation.Controls.Add(btnHome)
        pnNavigation.Location = New Point(2, -1)
        pnNavigation.Name = "pnNavigation"
        pnNavigation.Size = New Size(78, 732)
        pnNavigation.TabIndex = 43
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.BurlyWood
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(13, 211)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(50, 26)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(217), CByte(185), CByte(155))
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(13, 169)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(50, 27)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 129)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 27)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' pbTailoringJacinto
        ' 
        pbTailoringJacinto.Image = CType(resources.GetObject("pbTailoringJacinto.Image"), Image)
        pbTailoringJacinto.Location = New Point(3, 3)
        pbTailoringJacinto.Name = "pbTailoringJacinto"
        pbTailoringJacinto.Size = New Size(72, 65)
        pbTailoringJacinto.SizeMode = PictureBoxSizeMode.Zoom
        pbTailoringJacinto.TabIndex = 9
        pbTailoringJacinto.TabStop = False
        ' 
        ' btnSettings
        ' 
        btnSettings.BackColor = Color.BurlyWood
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.ForeColor = Color.BurlyWood
        btnSettings.Location = New Point(-3, 202)
        btnSettings.Name = "btnSettings"
        btnSettings.Padding = New Padding(30, 0, 0, 0)
        btnSettings.Size = New Size(81, 45)
        btnSettings.TabIndex = 11
        btnSettings.TextAlign = ContentAlignment.MiddleLeft
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(217), CByte(185), CByte(155))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.ForeColor = Color.FromArgb(CByte(217), CByte(185), CByte(155))
        btnSearch.Location = New Point(-3, 160)
        btnSearch.Name = "btnSearch"
        btnSearch.Padding = New Padding(30, 0, 0, 0)
        btnSearch.Size = New Size(81, 45)
        btnSearch.TabIndex = 10
        btnSearch.TextAlign = ContentAlignment.MiddleLeft
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.ForeColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        btnHome.Location = New Point(-3, 118)
        btnHome.Name = "btnHome"
        btnHome.Padding = New Padding(30, 0, 0, 0)
        btnHome.Size = New Size(81, 45)
        btnHome.TabIndex = 9
        btnHome.TextAlign = ContentAlignment.MiddleLeft
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(255), CByte(254), CByte(254))
        Panel6.Controls.Add(lblCustomerDetails)
        Panel6.Location = New Point(74, -1)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1369, 68)
        Panel6.TabIndex = 44
        ' 
        ' lblCustomerDetails
        ' 
        lblCustomerDetails.AutoSize = True
        lblCustomerDetails.BackColor = Color.Transparent
        lblCustomerDetails.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerDetails.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblCustomerDetails.Location = New Point(34, 20)
        lblCustomerDetails.Name = "lblCustomerDetails"
        lblCustomerDetails.Size = New Size(215, 36)
        lblCustomerDetails.TabIndex = 0
        lblCustomerDetails.Text = "Project Details"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(255), CByte(254), CByte(254))
        Panel7.Location = New Point(108, 143)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(673, 279)
        Panel7.TabIndex = 45
        ' 
        ' lblHeaderPayment
        ' 
        lblHeaderPayment.AutoSize = True
        lblHeaderPayment.BackColor = Color.Transparent
        lblHeaderPayment.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeaderPayment.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblHeaderPayment.Location = New Point(910, 128)
        lblHeaderPayment.Name = "lblHeaderPayment"
        lblHeaderPayment.Size = New Size(133, 36)
        lblHeaderPayment.TabIndex = 21
        lblHeaderPayment.Text = "Payment"
        ' 
        ' ProjectDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        ClientSize = New Size(1361, 726)
        Controls.Add(lblHeaderPayment)
        Controls.Add(pnNavigation)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(btnMakePayment)
        Controls.Add(Panel1)
        Controls.Add(dgPaymentHistory)
        Controls.Add(btnAddOrder)
        Controls.Add(lblHeaderOrder)
        Controls.Add(cbSort)
        Controls.Add(dgSortOrders)
        Controls.Add(lblTask)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(Panel7)
        Location = New Point(244, 52)
        Name = "ProjectDetailsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ProjectDetailsForm"
        CType(dgSortOrders, ComponentModel.ISupportInitialize).EndInit()
        CType(nudOrders, ComponentModel.ISupportInitialize).EndInit()
        CType(dgPaymentHistory, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        pnNavigation.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbTailoringJacinto, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTask As Label
    Friend WithEvents tbNumber As TextBox
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents dgSortOrders As DataGridView
    Friend WithEvents cbSort As ComboBox
    Friend WithEvents lblPayment As Label
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lblNumOrders As Label
    Friend WithEvents nudOrders As NumericUpDown
    Friend WithEvents lblHeaderOrder As Label
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents dgPaymentHistory As DataGridView
    Friend WithEvents lblDue As Label
    Friend WithEvents lblPaid As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblBalance As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnMakePayment As Button
    Friend WithEvents pendingCheckBox As DataGridViewCheckBoxColumn
    Friend WithEvents pending As DataGridViewTextBoxColumn
    Friend WithEvents finishedCheckBox As DataGridViewCheckBoxColumn
    Friend WithEvents finished As DataGridViewTextBoxColumn
    Friend WithEvents claimed As DataGridViewTextBoxColumn
    Friend WithEvents tbName As TextBox
    Friend WithEvents LblName As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents colOrdersPaid As DataGridViewTextBoxColumn
    Friend WithEvents pnNavigation As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbTailoringJacinto As PictureBox
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblCustomerDetails As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblHeaderPayment As Label
End Class
