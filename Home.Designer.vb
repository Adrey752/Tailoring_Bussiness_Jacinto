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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        DataGridOrders = New DataGridView()
        btDetails = New DataGridViewButtonColumn()
        client_id = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        OrderDate = New DataGridViewTextBoxColumn()
        colQuantity = New DataGridViewTextBoxColumn()
        colOrderStatus = New DataGridViewTextBoxColumn()
        colPayStatus = New DataGridViewTextBoxColumn()
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
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.Padding = New Padding(0, 8, 0, 8)
        DataGridViewCellStyle1.SelectionBackColor = Color.White
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridOrders.Columns.AddRange(New DataGridViewColumn() {btDetails, client_id, colName, OrderDate, colQuantity, colOrderStatus, colPayStatus})
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle9.ForeColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        DataGridViewCellStyle9.SelectionBackColor = Color.Gray
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        DataGridOrders.DefaultCellStyle = DataGridViewCellStyle9
        DataGridOrders.EnableHeadersVisualStyles = False
        DataGridOrders.GridColor = Color.Gray
        DataGridOrders.Location = New Point(313, 210)
        DataGridOrders.Name = "DataGridOrders"
        DataGridOrders.ReadOnly = True
        DataGridOrders.RowTemplate.Height = 58
        DataGridOrders.Size = New System.Drawing.Size(908, 439)
        DataGridOrders.TabIndex = 1
        ' 
        ' btDetails
        ' 
        btDetails.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        btDetails.DefaultCellStyle = DataGridViewCellStyle2
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
        client_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        client_id.DataPropertyName = "client_id"
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle3.ForeColor = Color.White
        DataGridViewCellStyle3.SelectionBackColor = Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = Color.White
        client_id.DefaultCellStyle = DataGridViewCellStyle3
        client_id.FillWeight = 48.07692F
        client_id.HeaderText = "id"
        client_id.Name = "client_id"
        client_id.ReadOnly = True
        ' 
        ' colName
        ' 
        colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colName.DataPropertyName = "name"
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        colName.DefaultCellStyle = DataGridViewCellStyle4
        colName.HeaderText = "Name"
        colName.MinimumWidth = 57
        colName.Name = "colName"
        colName.ReadOnly = True
        colName.Resizable = DataGridViewTriState.True
        colName.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' OrderDate
        ' 
        OrderDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        OrderDate.DataPropertyName = "date"
        DataGridViewCellStyle5.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.Format = "MM/dd/yyyy"
        DataGridViewCellStyle5.NullValue = Nothing
        DataGridViewCellStyle5.SelectionBackColor = Color.Gray
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        OrderDate.DefaultCellStyle = DataGridViewCellStyle5
        OrderDate.HeaderText = "Date of Order"
        OrderDate.Name = "OrderDate"
        OrderDate.ReadOnly = True
        ' 
        ' colQuantity
        ' 
        colQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colQuantity.DataPropertyName = "quantity"
        DataGridViewCellStyle6.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.SelectionBackColor = Color.Gray
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        colQuantity.DefaultCellStyle = DataGridViewCellStyle6
        colQuantity.HeaderText = "Quantity"
        colQuantity.Name = "colQuantity"
        colQuantity.ReadOnly = True
        ' 
        ' colOrderStatus
        ' 
        colOrderStatus.DataPropertyName = "order_status"
        DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle7.ForeColor = Color.White
        DataGridViewCellStyle7.SelectionBackColor = Color.Gray
        DataGridViewCellStyle7.SelectionForeColor = Color.White
        colOrderStatus.DefaultCellStyle = DataGridViewCellStyle7
        colOrderStatus.HeaderText = "Orders Status"
        colOrderStatus.Name = "colOrderStatus"
        colOrderStatus.ReadOnly = True
        ' 
        ' colPayStatus
        ' 
        colPayStatus.DataPropertyName = "payment_status"
        DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle8.ForeColor = Color.White
        DataGridViewCellStyle8.SelectionBackColor = Color.Gray
        DataGridViewCellStyle8.SelectionForeColor = Color.White
        colPayStatus.DefaultCellStyle = DataGridViewCellStyle8
        colPayStatus.HeaderText = "Payment Status"
        colPayStatus.Name = "colPayStatus"
        colPayStatus.ReadOnly = True
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
    Friend WithEvents OrderDate As DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As DataGridViewTextBoxColumn
    Friend WithEvents colOrderStatus As DataGridViewTextBoxColumn
    Friend WithEvents colPayStatus As DataGridViewTextBoxColumn
End Class
