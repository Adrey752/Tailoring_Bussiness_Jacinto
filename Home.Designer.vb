<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
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
        DataGridProjects = New DataGridView()
        btDetails = New DataGridViewButtonColumn()
        client_id = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        OrderDate = New DataGridViewTextBoxColumn()
        colQuantity = New DataGridViewTextBoxColumn()
        colOrderStatus = New DataGridViewTextBoxColumn()
        colPayStatus = New DataGridViewTextBoxColumn()
        btnAddrOrder = New Button()
        lblProjects = New Label()
        btnSort = New Button()
        pnNavigation = New Panel()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        pbTailoringJacinto = New PictureBox()
        btnLogout = New Button()
        btnSettings = New Button()
        btnHome = New Button()
        tbSearch = New TextBox()
        PictureBox1 = New PictureBox()
        cmsSorting = New ContextMenuStrip(components)
        nameItem = New ToolStripMenuItem()
        dateItem = New ToolStripMenuItem()
        quantityItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ascendingItem = New ToolStripMenuItem()
        decendingItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        pnSort = New Panel()
        Button1 = New Button()
        lbSuggestions = New ListBox()
        CType(DataGridProjects, ComponentModel.ISupportInitialize).BeginInit()
        pnNavigation.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbTailoringJacinto, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        cmsSorting.SuspendLayout()
        pnSort.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridProjects
        ' 
        DataGridProjects.AllowUserToAddRows = False
        DataGridProjects.AllowUserToDeleteRows = False
        DataGridProjects.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridProjects.BackgroundColor = Color.White
        DataGridProjects.BorderStyle = BorderStyle.None
        DataGridProjects.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(36), CByte(36), CByte(36))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 12F)
        DataGridViewCellStyle1.ForeColor = Color.White
        DataGridViewCellStyle1.Padding = New Padding(0, 8, 0, 8)
        DataGridViewCellStyle1.SelectionBackColor = Color.White
        DataGridViewCellStyle1.SelectionForeColor = Color.Black
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridProjects.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridProjects.Columns.AddRange(New DataGridViewColumn() {btDetails, client_id, colName, OrderDate, colQuantity, colOrderStatus, colPayStatus})
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(33), CByte(33), CByte(33))
        DataGridViewCellStyle9.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle9.ForeColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        DataGridViewCellStyle9.SelectionBackColor = Color.Gray
        DataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = DataGridViewTriState.False
        DataGridProjects.DefaultCellStyle = DataGridViewCellStyle9
        DataGridProjects.EnableHeadersVisualStyles = False
        DataGridProjects.GridColor = Color.Gray
        DataGridProjects.Location = New Point(258, 210)
        DataGridProjects.Name = "DataGridProjects"
        DataGridProjects.ReadOnly = True
        DataGridProjects.RowTemplate.Height = 58
        DataGridProjects.Size = New Size(963, 439)
        DataGridProjects.TabIndex = 1
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
        DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(56), CByte(56), CByte(56))
        DataGridViewCellStyle4.ForeColor = Color.White
        DataGridViewCellStyle4.SelectionBackColor = Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = Color.White
        colName.DefaultCellStyle = DataGridViewCellStyle4
        colName.HeaderText = "Client Name"
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
        OrderDate.HeaderText = "Date of Ordered"
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
        ' btnAddrOrder
        ' 
        btnAddrOrder.AutoSize = True
        btnAddrOrder.BackColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        btnAddrOrder.FlatAppearance.BorderSize = 0
        btnAddrOrder.FlatStyle = FlatStyle.Flat
        btnAddrOrder.ForeColor = Color.White
        btnAddrOrder.Location = New Point(539, 169)
        btnAddrOrder.Margin = New Padding(0)
        btnAddrOrder.Name = "btnAddrOrder"
        btnAddrOrder.RightToLeft = RightToLeft.No
        btnAddrOrder.Size = New Size(91, 37)
        btnAddrOrder.TabIndex = 5
        btnAddrOrder.Text = "Add Project"
        btnAddrOrder.UseVisualStyleBackColor = False
        ' 
        ' lblProjects
        ' 
        lblProjects.AutoSize = True
        lblProjects.BackColor = Color.Transparent
        lblProjects.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblProjects.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblProjects.Location = New Point(258, 162)
        lblProjects.Name = "lblProjects"
        lblProjects.Size = New Size(140, 45)
        lblProjects.TabIndex = 6
        lblProjects.Text = "Projects"
        ' 
        ' btnSort
        ' 
        btnSort.AutoSize = True
        btnSort.BackColor = Color.Transparent
        btnSort.BackgroundImage = My.Resources.Resources.sort
        btnSort.BackgroundImageLayout = ImageLayout.Stretch
        btnSort.Enabled = False
        btnSort.FlatAppearance.BorderSize = 0
        btnSort.FlatStyle = FlatStyle.Flat
        btnSort.ForeColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        btnSort.Location = New Point(10, 1)
        btnSort.Margin = New Padding(0)
        btnSort.Name = "btnSort"
        btnSort.RightToLeft = RightToLeft.No
        btnSort.Size = New Size(35, 35)
        btnSort.TabIndex = 7
        btnSort.UseVisualStyleBackColor = False
        ' 
        ' pnNavigation
        ' 
        pnNavigation.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnNavigation.BackColor = Color.FromArgb(CByte(255), CByte(254), CByte(254))
        pnNavigation.Controls.Add(PictureBox4)
        pnNavigation.Controls.Add(PictureBox3)
        pnNavigation.Controls.Add(PictureBox2)
        pnNavigation.Controls.Add(pbTailoringJacinto)
        pnNavigation.Controls.Add(btnLogout)
        pnNavigation.Controls.Add(btnSettings)
        pnNavigation.Controls.Add(btnHome)
        pnNavigation.Location = New Point(0, -1)
        pnNavigation.Name = "pnNavigation"
        pnNavigation.Size = New Size(227, 663)
        pnNavigation.TabIndex = 8
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.None
        PictureBox4.Enabled = False
        PictureBox4.Image = My.Resources.Resources.setting
        PictureBox4.Location = New Point(12, 249)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(31, 29)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 15
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Enabled = False
        PictureBox3.Image = My.Resources.Resources.logout
        PictureBox3.Location = New Point(12, 291)
        PictureBox3.Margin = New Padding(0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(31, 29)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 14
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Enabled = False
        PictureBox2.Image = My.Resources.Resources.home
        PictureBox2.Location = New Point(12, 211)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(31, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' pbTailoringJacinto
        ' 
        pbTailoringJacinto.Image = CType(resources.GetObject("pbTailoringJacinto.Image"), Image)
        pbTailoringJacinto.Location = New Point(0, -3)
        pbTailoringJacinto.Name = "pbTailoringJacinto"
        pbTailoringJacinto.Size = New Size(227, 192)
        pbTailoringJacinto.SizeMode = PictureBoxSizeMode.Zoom
        pbTailoringJacinto.TabIndex = 12
        pbTailoringJacinto.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.AccessibleRole = AccessibleRole.None
        btnLogout.BackColor = Color.BurlyWood
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogout.ForeColor = Color.Black
        btnLogout.Location = New Point(-3, 289)
        btnLogout.Margin = New Padding(0)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(30, 0, 0, 0)
        btnLogout.Size = New Size(227, 45)
        btnLogout.TabIndex = 11
        btnLogout.Text = "    Logout"
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnSettings
        ' 
        btnSettings.BackColor = Color.FromArgb(CByte(217), CByte(185), CByte(155))
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSettings.ForeColor = Color.Black
        btnSettings.Location = New Point(-3, 246)
        btnSettings.Margin = New Padding(0)
        btnSettings.Name = "btnSettings"
        btnSettings.Padding = New Padding(30, 0, 0, 0)
        btnSettings.Size = New Size(227, 45)
        btnSettings.TabIndex = 10
        btnSettings.Text = "    Settings"
        btnSettings.TextAlign = ContentAlignment.MiddleLeft
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHome.ForeColor = Color.Black
        btnHome.Location = New Point(0, 201)
        btnHome.Margin = New Padding(0)
        btnHome.Name = "btnHome"
        btnHome.Padding = New Padding(30, 0, 0, 0)
        btnHome.Size = New Size(227, 45)
        btnHome.TabIndex = 9
        btnHome.Text = "   Home"
        btnHome.TextAlign = ContentAlignment.MiddleLeft
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' tbSearch
        ' 
        tbSearch.Anchor = AnchorStyles.Top
        tbSearch.Location = New Point(513, 38)
        tbSearch.Name = "tbSearch"
        tbSearch.Size = New Size(440, 23)
        tbSearch.TabIndex = 9
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Top
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources.search_interface_symbol
        PictureBox1.Location = New Point(959, 38)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(26, 23)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' cmsSorting
        ' 
        cmsSorting.Items.AddRange(New ToolStripItem() {nameItem, dateItem, quantityItem, ToolStripSeparator1, ascendingItem, decendingItem, ToolStripSeparator2})
        cmsSorting.Name = "ContextMenuStrip1"
        cmsSorting.Size = New Size(132, 126)
        ' 
        ' nameItem
        ' 
        nameItem.BackColor = Color.White
        nameItem.ForeColor = Color.Black
        nameItem.Name = "nameItem"
        nameItem.Size = New Size(131, 22)
        nameItem.Text = "Name"
        ' 
        ' dateItem
        ' 
        dateItem.Name = "dateItem"
        dateItem.Size = New Size(131, 22)
        dateItem.Text = "Date"
        ' 
        ' quantityItem
        ' 
        quantityItem.Name = "quantityItem"
        quantityItem.Size = New Size(131, 22)
        quantityItem.Text = "Quantity"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(128, 6)
        ' 
        ' ascendingItem
        ' 
        ascendingItem.BackColor = Color.Transparent
        ascendingItem.ForeColor = Color.Black
        ascendingItem.Name = "ascendingItem"
        ascendingItem.Size = New Size(131, 22)
        ascendingItem.Text = "Ascending"
        ' 
        ' decendingItem
        ' 
        decendingItem.Name = "decendingItem"
        decendingItem.Size = New Size(131, 22)
        decendingItem.Text = "Decending"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(128, 6)
        ' 
        ' pnSort
        ' 
        pnSort.BackColor = Color.Transparent
        pnSort.Controls.Add(Button1)
        pnSort.Controls.Add(btnSort)
        pnSort.Location = New Point(404, 170)
        pnSort.Name = "pnSort"
        pnSort.Size = New Size(115, 37)
        pnSort.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.BackColor = Color.Transparent
        Button1.Enabled = False
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        Button1.Location = New Point(45, -1)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.RightToLeft = RightToLeft.No
        Button1.Size = New Size(70, 37)
        Button1.TabIndex = 12
        Button1.Text = "Sort by"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' lbSuggestions
        ' 
        lbSuggestions.FormattingEnabled = True
        lbSuggestions.ItemHeight = 15
        lbSuggestions.Location = New Point(510, 72)
        lbSuggestions.Name = "lbSuggestions"
        lbSuggestions.Size = New Size(443, 94)
        lbSuggestions.TabIndex = 12
        lbSuggestions.Visible = False
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        ClientSize = New Size(1246, 661)
        Controls.Add(lbSuggestions)
        Controls.Add(pnSort)
        Controls.Add(PictureBox1)
        Controls.Add(tbSearch)
        Controls.Add(pnNavigation)
        Controls.Add(lblProjects)
        Controls.Add(btnAddrOrder)
        Controls.Add(DataGridProjects)
        ForeColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        MinimumSize = New Size(1000, 700)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        CType(DataGridProjects, ComponentModel.ISupportInitialize).EndInit()
        pnNavigation.ResumeLayout(False)
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(pbTailoringJacinto, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        cmsSorting.ResumeLayout(False)
        pnSort.ResumeLayout(False)
        pnSort.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridProjects As DataGridView
    Friend WithEvents btnAddrOrder As Button
    Friend WithEvents lblProjects As Label
    Friend WithEvents btnSort As Button
    Friend WithEvents pnNavigation As Panel
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btDetails As DataGridViewButtonColumn
    Friend WithEvents client_id As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents OrderDate As DataGridViewTextBoxColumn
    Friend WithEvents colQuantity As DataGridViewTextBoxColumn
    Friend WithEvents colOrderStatus As DataGridViewTextBoxColumn
    Friend WithEvents colPayStatus As DataGridViewTextBoxColumn
    Friend WithEvents cmsSorting As ContextMenuStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents pnSort As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents nameItem As ToolStripMenuItem
    Friend WithEvents dateItem As ToolStripMenuItem
    Friend WithEvents quantityItem As ToolStripMenuItem
    Friend WithEvents ascendingItem As ToolStripMenuItem
    Friend WithEvents decendingItem As ToolStripMenuItem
    Friend WithEvents lbSuggestions As ListBox
    Friend WithEvents btnHome As Button
    Friend WithEvents pbTailoringJacinto As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
