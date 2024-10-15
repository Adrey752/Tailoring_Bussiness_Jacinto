<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim DataGridViewCellStyle25 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        DataGridOrders = New DataGridView()
        btDetails = New DataGridViewButtonColumn()
        client_id = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colAddress = New DataGridViewTextBoxColumn()
        colContNumber = New DataGridViewTextBoxColumn()
        colStatus = New DataGridViewTextBoxColumn()
        colPrice = New DataGridViewTextBoxColumn()
        colPay = New DataGridViewTextBoxColumn()
        colStartedDate = New DataGridViewTextBoxColumn()
        colDueDate = New DataGridViewTextBoxColumn()
        btnToggle = New Button()
        pnLogout = New Panel()
        btnSetNew = New Button()
        btnLogOut = New Button()
        btnAddrOrder = New Button()
        lblOrders = New Label()
        btnSort = New Button()
        pnNavigation = New Panel()
        btnSettings = New Button()
        btnSearch = New Button()
        btnHome = New Button()
        pbTailoringJacinto = New PictureBox()
        TextBox1 = New TextBox()
        PictureBox1 = New PictureBox()
        CType(DataGridOrders, ComponentModel.ISupportInitialize).BeginInit()
        pnLogout.SuspendLayout()
        pnNavigation.SuspendLayout()
        CType(pbTailoringJacinto, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridOrders
        ' 
        DataGridOrders.AllowUserToAddRows = False
        DataGridOrders.AllowUserToDeleteRows = False
        DataGridOrders.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        DataGridOrders.BackgroundColor = Color.White
        DataGridOrders.BorderStyle = BorderStyle.None
        DataGridOrders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle25.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        DataGridViewCellStyle25.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle25.ForeColor = Color.White
        DataGridViewCellStyle25.Padding = New Padding(0, 8, 0, 8)
        DataGridViewCellStyle25.SelectionBackColor = Color.White
        DataGridViewCellStyle25.SelectionForeColor = Color.Black
        DataGridViewCellStyle25.WrapMode = DataGridViewTriState.True
        DataGridOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle25
        DataGridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridOrders.Columns.AddRange(New DataGridViewColumn() {btDetails, client_id, colName, colAddress, colContNumber, colStatus, colPrice, colPay, colStartedDate, colDueDate})
        DataGridViewCellStyle36.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle36.BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle36.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle36.ForeColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        DataGridViewCellStyle36.SelectionBackColor = Color.Gray
        DataGridViewCellStyle36.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle36.WrapMode = DataGridViewTriState.False
        DataGridOrders.DefaultCellStyle = DataGridViewCellStyle36
        DataGridOrders.EnableHeadersVisualStyles = False
        DataGridOrders.GridColor = Color.Gray
        DataGridOrders.Location = New Point(313, 210)
        DataGridOrders.Name = "DataGridOrders"
        DataGridOrders.ReadOnly = True
        DataGridOrders.Size = New System.Drawing.Size(908, 439)
        DataGridOrders.TabIndex = 1
        ' 
        ' btDetails
        ' 
        btDetails.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle26.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle26.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle26.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle26.ForeColor = Color.White
        btDetails.DefaultCellStyle = DataGridViewCellStyle26
        btDetails.FillWeight = 48.07692F
        btDetails.FlatStyle = FlatStyle.Flat
        btDetails.HeaderText = "View Details"
        btDetails.Name = "btDetails"
        btDetails.ReadOnly = True
        btDetails.Resizable = DataGridViewTriState.True
        btDetails.Text = "Details"
        btDetails.UseColumnTextForButtonValue = True
        ' 
        ' client_id
        ' 
        client_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        client_id.DataPropertyName = "client_id"
        DataGridViewCellStyle27.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle27.ForeColor = Color.White
        DataGridViewCellStyle27.SelectionBackColor = Color.Gray
        DataGridViewCellStyle27.SelectionForeColor = Color.White
        client_id.DefaultCellStyle = DataGridViewCellStyle27
        client_id.FillWeight = 48.07692F
        client_id.HeaderText = "id"
        client_id.Name = "client_id"
        client_id.ReadOnly = True
        client_id.Width = 47
        ' 
        ' colName
        ' 
        colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        colName.DataPropertyName = "name"
        DataGridViewCellStyle28.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle28.ForeColor = Color.White
        DataGridViewCellStyle28.SelectionBackColor = Color.Gray
        DataGridViewCellStyle28.SelectionForeColor = Color.White
        colName.DefaultCellStyle = DataGridViewCellStyle28
        colName.HeaderText = "Name"
        colName.Name = "colName"
        colName.ReadOnly = True
        colName.Resizable = DataGridViewTriState.True
        colName.SortMode = DataGridViewColumnSortMode.NotSortable
        colName.Width = 57
        ' 
        ' colAddress
        ' 
        colAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        colAddress.DataPropertyName = "address"
        DataGridViewCellStyle29.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle29.ForeColor = Color.White
        DataGridViewCellStyle29.SelectionBackColor = Color.Gray
        DataGridViewCellStyle29.SelectionForeColor = Color.White
        colAddress.DefaultCellStyle = DataGridViewCellStyle29
        colAddress.HeaderText = "Address"
        colAddress.Name = "colAddress"
        colAddress.ReadOnly = True
        colAddress.Resizable = DataGridViewTriState.True
        colAddress.SortMode = DataGridViewColumnSortMode.NotSortable
        colAddress.Width = 71
        ' 
        ' colContNumber
        ' 
        colContNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colContNumber.DataPropertyName = "contact"
        DataGridViewCellStyle30.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle30.ForeColor = Color.White
        DataGridViewCellStyle30.SelectionBackColor = Color.Gray
        DataGridViewCellStyle30.SelectionForeColor = Color.White
        colContNumber.DefaultCellStyle = DataGridViewCellStyle30
        colContNumber.FillWeight = 48.07692F
        colContNumber.HeaderText = "ContactNumber"
        colContNumber.MinimumWidth = 120
        colContNumber.Name = "colContNumber"
        colContNumber.ReadOnly = True
        colContNumber.Resizable = DataGridViewTriState.True
        colContNumber.SortMode = DataGridViewColumnSortMode.NotSortable
        colContNumber.Width = 120
        ' 
        ' colStatus
        ' 
        colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colStatus.DataPropertyName = "status"
        DataGridViewCellStyle31.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle31.ForeColor = Color.White
        DataGridViewCellStyle31.SelectionBackColor = Color.Gray
        DataGridViewCellStyle31.SelectionForeColor = Color.White
        colStatus.DefaultCellStyle = DataGridViewCellStyle31
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 60
        colStatus.Name = "colStatus"
        colStatus.ReadOnly = True
        colStatus.Resizable = DataGridViewTriState.True
        colStatus.SortMode = DataGridViewColumnSortMode.NotSortable
        colStatus.Width = 60
        ' 
        ' colPrice
        ' 
        colPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colPrice.DataPropertyName = "price"
        DataGridViewCellStyle32.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle32.ForeColor = Color.White
        DataGridViewCellStyle32.SelectionBackColor = Color.Gray
        DataGridViewCellStyle32.SelectionForeColor = Color.White
        colPrice.DefaultCellStyle = DataGridViewCellStyle32
        colPrice.FillWeight = 48.07692F
        colPrice.HeaderText = "Price"
        colPrice.MinimumWidth = 73
        colPrice.Name = "colPrice"
        colPrice.ReadOnly = True
        colPrice.Resizable = DataGridViewTriState.True
        colPrice.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colPay
        ' 
        colPay.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colPay.DataPropertyName = "payment"
        DataGridViewCellStyle33.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle33.ForeColor = Color.White
        DataGridViewCellStyle33.SelectionBackColor = Color.Gray
        DataGridViewCellStyle33.SelectionForeColor = Color.White
        colPay.DefaultCellStyle = DataGridViewCellStyle33
        colPay.FillWeight = 50F
        colPay.HeaderText = "Payment"
        colPay.MinimumWidth = 65
        colPay.Name = "colPay"
        colPay.ReadOnly = True
        colPay.Width = 65
        ' 
        ' colStartedDate
        ' 
        DataGridViewCellStyle34.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle34.ForeColor = Color.White
        DataGridViewCellStyle34.SelectionBackColor = Color.Gray
        DataGridViewCellStyle34.SelectionForeColor = Color.White
        colStartedDate.DefaultCellStyle = DataGridViewCellStyle34
        colStartedDate.HeaderText = "Started Date"
        colStartedDate.MinimumWidth = 77
        colStartedDate.Name = "colStartedDate"
        colStartedDate.ReadOnly = True
        colStartedDate.Width = 159
        ' 
        ' colDueDate
        ' 
        DataGridViewCellStyle35.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle35.ForeColor = Color.White
        DataGridViewCellStyle35.SelectionBackColor = Color.Gray
        DataGridViewCellStyle35.SelectionForeColor = Color.White
        colDueDate.DefaultCellStyle = DataGridViewCellStyle35
        colDueDate.HeaderText = "Due Date"
        colDueDate.MinimumWidth = 80
        colDueDate.Name = "colDueDate"
        colDueDate.ReadOnly = True
        colDueDate.Width = 160
        ' 
        ' btnToggle
        ' 
        btnToggle.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnToggle.BackColor = Color.Transparent
        btnToggle.BackgroundImage = CType(resources.GetObject("btnToggle.BackgroundImage"), Image)
        btnToggle.BackgroundImageLayout = ImageLayout.Stretch
        btnToggle.Location = New Point(1179, 30)
        btnToggle.Name = "btnToggle"
        btnToggle.Size = New System.Drawing.Size(42, 36)
        btnToggle.TabIndex = 2
        btnToggle.UseVisualStyleBackColor = False
        ' 
        ' pnLogout
        ' 
        pnLogout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnLogout.BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        pnLogout.Controls.Add(btnSetNew)
        pnLogout.Controls.Add(btnLogOut)
        pnLogout.Location = New Point(1112, 71)
        pnLogout.Name = "pnLogout"
        pnLogout.Size = New System.Drawing.Size(122, 105)
        pnLogout.TabIndex = 3
        pnLogout.Visible = False
        ' 
        ' btnSetNew
        ' 
        btnSetNew.BackColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        btnSetNew.FlatStyle = FlatStyle.Flat
        btnSetNew.Location = New Point(18, 55)
        btnSetNew.Name = "btnSetNew"
        btnSetNew.Size = New System.Drawing.Size(91, 37)
        btnSetNew.TabIndex = 1
        btnSetNew.Text = "Set New password"
        btnSetNew.UseVisualStyleBackColor = False
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        btnLogOut.FlatStyle = FlatStyle.Flat
        btnLogOut.Location = New Point(18, 12)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New System.Drawing.Size(91, 37)
        btnLogOut.TabIndex = 0
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' btnAddrOrder
        ' 
        btnAddrOrder.AutoSize = True
        btnAddrOrder.BackColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        btnAddrOrder.FlatAppearance.BorderSize = 0
        btnAddrOrder.FlatStyle = FlatStyle.Flat
        btnAddrOrder.ForeColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        btnAddrOrder.Location = New Point(522, 160)
        btnAddrOrder.Margin = New Padding(0)
        btnAddrOrder.Name = "btnAddrOrder"
        btnAddrOrder.RightToLeft = RightToLeft.No
        btnAddrOrder.Size = New System.Drawing.Size(91, 37)
        btnAddrOrder.TabIndex = 5
        btnAddrOrder.Text = "Add order"
        btnAddrOrder.UseVisualStyleBackColor = False
        ' 
        ' lblOrders
        ' 
        lblOrders.AutoSize = True
        lblOrders.BackColor = Color.Transparent
        lblOrders.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOrders.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblOrders.Location = New Point(313, 152)
        lblOrders.Name = "lblOrders"
        lblOrders.Size = New System.Drawing.Size(121, 45)
        lblOrders.TabIndex = 6
        lblOrders.Text = "Orders"
        ' 
        ' btnSort
        ' 
        btnSort.AutoSize = True
        btnSort.BackColor = Color.Transparent
        btnSort.BackgroundImage = My.Resources.Resources.sort
        btnSort.BackgroundImageLayout = ImageLayout.Stretch
        btnSort.FlatAppearance.BorderSize = 0
        btnSort.FlatStyle = FlatStyle.Flat
        btnSort.ForeColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        btnSort.Location = New Point(449, 165)
        btnSort.Margin = New Padding(0)
        btnSort.Name = "btnSort"
        btnSort.RightToLeft = RightToLeft.No
        btnSort.Size = New System.Drawing.Size(41, 32)
        btnSort.TabIndex = 7
        btnSort.UseVisualStyleBackColor = False
        ' 
        ' pnNavigation
        ' 
        pnNavigation.BackColor = Color.FromArgb(CByte(255), CByte(254), CByte(254))
        pnNavigation.Controls.Add(btnSettings)
        pnNavigation.Controls.Add(btnSearch)
        pnNavigation.Controls.Add(btnHome)
        pnNavigation.Controls.Add(pbTailoringJacinto)
        pnNavigation.Location = New Point(12, 12)
        pnNavigation.Name = "pnNavigation"
        pnNavigation.Size = New System.Drawing.Size(284, 637)
        pnNavigation.TabIndex = 8
        ' 
        ' btnSettings
        ' 
        btnSettings.BackColor = Color.BurlyWood
        btnSettings.Location = New Point(3, 363)
        btnSettings.Name = "btnSettings"
        btnSettings.Padding = New Padding(30, 0, 0, 0)
        btnSettings.Size = New System.Drawing.Size(281, 45)
        btnSettings.TabIndex = 11
        btnSettings.Text = "Settings"
        btnSettings.TextAlign = ContentAlignment.MiddleLeft
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(217), CByte(185), CByte(155))
        btnSearch.Location = New Point(3, 322)
        btnSearch.Name = "btnSearch"
        btnSearch.Padding = New Padding(30, 0, 0, 0)
        btnSearch.Size = New System.Drawing.Size(281, 45)
        btnSearch.TabIndex = 10
        btnSearch.Text = "Search"
        btnSearch.TextAlign = ContentAlignment.MiddleLeft
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        btnHome.Location = New Point(3, 280)
        btnHome.Name = "btnHome"
        btnHome.Padding = New Padding(30, 0, 0, 0)
        btnHome.Size = New System.Drawing.Size(281, 45)
        btnHome.TabIndex = 9
        btnHome.Text = "Home"
        btnHome.TextAlign = ContentAlignment.MiddleLeft
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' pbTailoringJacinto
        ' 
        pbTailoringJacinto.Anchor = AnchorStyles.None
        pbTailoringJacinto.Image = CType(resources.GetObject("pbTailoringJacinto.Image"), Image)
        pbTailoringJacinto.Location = New Point(41, 26)
        pbTailoringJacinto.Name = "pbTailoringJacinto"
        pbTailoringJacinto.Size = New System.Drawing.Size(203, 143)
        pbTailoringJacinto.SizeMode = PictureBoxSizeMode.StretchImage
        pbTailoringJacinto.TabIndex = 9
        pbTailoringJacinto.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(449, 38)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New System.Drawing.Size(440, 23)
        TextBox1.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources.search_interface_symbol
        PictureBox1.Location = New Point(895, 38)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(26, 23)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        ClientSize = New System.Drawing.Size(1246, 661)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox1)
        Controls.Add(pnNavigation)
        Controls.Add(btnSort)
        Controls.Add(lblOrders)
        Controls.Add(btnAddrOrder)
        Controls.Add(btnToggle)
        Controls.Add(pnLogout)
        Controls.Add(DataGridOrders)
        ForeColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        MinimumSize = New System.Drawing.Size(1000, 700)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        CType(DataGridOrders, ComponentModel.ISupportInitialize).EndInit()
        pnLogout.ResumeLayout(False)
        pnNavigation.ResumeLayout(False)
        CType(pbTailoringJacinto, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridOrders As DataGridView
    Friend WithEvents btnToggle As Button
    Friend WithEvents pnLogout As Panel
    Friend WithEvents btnSetNew As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnAddrOrder As Button
    Friend WithEvents lblOrders As Label
    Friend WithEvents btnSort As Button
    Friend WithEvents pnNavigation As Panel
    Friend WithEvents pbTailoringJacinto As PictureBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btDetails As DataGridViewButtonColumn
    Friend WithEvents client_id As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colAddress As DataGridViewTextBoxColumn
    Friend WithEvents colContNumber As DataGridViewTextBoxColumn
    Friend WithEvents colStatus As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colPay As DataGridViewTextBoxColumn
    Friend WithEvents colStartedDate As DataGridViewTextBoxColumn
    Friend WithEvents colDueDate As DataGridViewTextBoxColumn
End Class
