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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        DataGridOrders = New DataGridView()
        btDetails = New DataGridViewButtonColumn()
        colId = New DataGridViewTextBoxColumn()
        colName = New DataGridViewButtonColumn()
        colAddress = New DataGridViewButtonColumn()
        colContNumber = New DataGridViewButtonColumn()
        colStatus = New DataGridViewButtonColumn()
        colPrice = New DataGridViewButtonColumn()
        colPay = New DataGridViewTextBoxColumn()
        colStartedDate = New DataGridViewTextBoxColumn()
        colDueDate = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        pnLogout = New Panel()
        btnSetNew = New Button()
        btnLogOut = New Button()
        btnAddrOrder = New Button()
        lblTitel = New Label()
        btnSort = New Button()
        Panel1 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        PictureBox2 = New PictureBox()
        TextBox1 = New TextBox()
        Button5 = New Button()
        CType(DataGridOrders, ComponentModel.ISupportInitialize).BeginInit()
        pnLogout.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridOrders
        ' 
        DataGridOrders.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        DataGridOrders.BackgroundColor = Color.White
        DataGridOrders.BorderStyle = BorderStyle.None
        DataGridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridOrders.Columns.AddRange(New DataGridViewColumn() {btDetails, colId, colName, colAddress, colContNumber, colStatus, colPrice, colPay, colStartedDate, colDueDate})
        DataGridOrders.GridColor = SystemColors.MenuHighlight
        DataGridOrders.Location = New Point(386, 279)
        DataGridOrders.Name = "DataGridOrders"
        DataGridOrders.Size = New Size(1365, 616)
        DataGridOrders.TabIndex = 1
        ' 
        ' btDetails
        ' 
        btDetails.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        btDetails.FillWeight = 48.07692F
        btDetails.HeaderText = "View Details"
        btDetails.Name = "btDetails"
        btDetails.Resizable = DataGridViewTriState.True
        btDetails.Text = "Details"
        btDetails.UseColumnTextForButtonValue = True
        ' 
        ' colId
        ' 
        colId.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        colId.DataPropertyName = "client_id"
        colId.FillWeight = 48.07692F
        colId.HeaderText = "id"
        colId.Name = "colId"
        colId.Width = 42
        ' 
        ' colName
        ' 
        colName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        colName.DataPropertyName = "name"
        colName.HeaderText = "Name"
        colName.Name = "colName"
        colName.Width = 45
        ' 
        ' colAddress
        ' 
        colAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        colAddress.DataPropertyName = "address"
        colAddress.HeaderText = "Address"
        colAddress.Name = "colAddress"
        colAddress.Width = 55
        ' 
        ' colContNumber
        ' 
        colContNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colContNumber.DataPropertyName = "contact"
        colContNumber.FillWeight = 48.07692F
        colContNumber.HeaderText = "ContactNumber"
        colContNumber.MinimumWidth = 120
        colContNumber.Name = "colContNumber"
        colContNumber.Width = 120
        ' 
        ' colStatus
        ' 
        colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colStatus.DataPropertyName = "status"
        colStatus.HeaderText = "Status"
        colStatus.MinimumWidth = 60
        colStatus.Name = "colStatus"
        colStatus.Width = 60
        ' 
        ' colPrice
        ' 
        colPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colPrice.DataPropertyName = "price"
        colPrice.FillWeight = 48.07692F
        colPrice.HeaderText = "Price"
        colPrice.MinimumWidth = 73
        colPrice.Name = "colPrice"
        colPrice.Text = ""
        ' 
        ' colPay
        ' 
        colPay.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colPay.DataPropertyName = "payment"
        colPay.FillWeight = 50F
        colPay.HeaderText = "Payment"
        colPay.MinimumWidth = 65
        colPay.Name = "colPay"
        colPay.Width = 65
        ' 
        ' colStartedDate
        ' 
        colStartedDate.HeaderText = "Started Date"
        colStartedDate.MinimumWidth = 77
        colStartedDate.Name = "colStartedDate"
        colStartedDate.Width = 159
        ' 
        ' colDueDate
        ' 
        colDueDate.HeaderText = "Due Date"
        colDueDate.MinimumWidth = 80
        colDueDate.Name = "colDueDate"
        colDueDate.Width = 160
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(1802, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(42, 36)
        Button1.TabIndex = 2
        Button1.UseVisualStyleBackColor = False
        ' 
        ' pnLogout
        ' 
        pnLogout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnLogout.BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        pnLogout.Controls.Add(btnSetNew)
        pnLogout.Controls.Add(btnLogOut)
        pnLogout.Location = New Point(1737, 54)
        pnLogout.Name = "pnLogout"
        pnLogout.Size = New Size(122, 105)
        pnLogout.TabIndex = 3
        pnLogout.Visible = False
        ' 
        ' btnSetNew
        ' 
        btnSetNew.BackColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        btnSetNew.FlatStyle = FlatStyle.Flat
        btnSetNew.Location = New Point(18, 55)
        btnSetNew.Name = "btnSetNew"
        btnSetNew.Size = New Size(91, 37)
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
        btnLogOut.Size = New Size(91, 37)
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
        btnAddrOrder.Location = New Point(622, 204)
        btnAddrOrder.Margin = New Padding(0)
        btnAddrOrder.Name = "btnAddrOrder"
        btnAddrOrder.RightToLeft = RightToLeft.No
        btnAddrOrder.Size = New Size(91, 37)
        btnAddrOrder.TabIndex = 5
        btnAddrOrder.Text = "Add order"
        btnAddrOrder.UseVisualStyleBackColor = False
        ' 
        ' lblTitel
        ' 
        lblTitel.AutoSize = True
        lblTitel.BackColor = Color.Transparent
        lblTitel.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitel.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblTitel.Location = New Point(384, 198)
        lblTitel.Name = "lblTitel"
        lblTitel.Size = New Size(121, 45)
        lblTitel.TabIndex = 6
        lblTitel.Text = "Orders"
        ' 
        ' btnSort
        ' 
        btnSort.AutoSize = True
        btnSort.BackColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        btnSort.FlatAppearance.BorderSize = 0
        btnSort.FlatStyle = FlatStyle.Flat
        btnSort.ForeColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        btnSort.Location = New Point(519, 204)
        btnSort.Margin = New Padding(0)
        btnSort.Name = "btnSort"
        btnSort.RightToLeft = RightToLeft.No
        btnSort.Size = New Size(91, 37)
        btnSort.TabIndex = 7
        btnSort.Text = "Sort By"
        btnSort.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(254), CByte(254))
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(1, -1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(284, 1066)
        Panel1.TabIndex = 8
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.BurlyWood
        Button4.Location = New Point(3, 363)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(30, 0, 0, 0)
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
        Button3.Padding = New Padding(30, 0, 0, 0)
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
        Button2.Padding = New Padding(30, 0, 0, 0)
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
        PictureBox2.Location = New Point(35, 82)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(203, 143)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.None
        TextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(756, 43)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(637, 29)
        TextBox1.TabIndex = 9
        ' 
        ' Button5
        ' 
        Button5.Anchor = AnchorStyles.None
        Button5.BackColor = Color.Transparent
        Button5.Image = CType(resources.GetObject("Button5.Image"), Image)
        Button5.Location = New Point(1342, 43)
        Button5.Name = "Button5"
        Button5.Size = New Size(51, 30)
        Button5.TabIndex = 10
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        ClientSize = New Size(1856, 1061)
        Controls.Add(Button5)
        Controls.Add(TextBox1)
        Controls.Add(Panel1)
        Controls.Add(btnSort)
        Controls.Add(lblTitel)
        Controls.Add(btnAddrOrder)
        Controls.Add(Button1)
        Controls.Add(pnLogout)
        Controls.Add(DataGridOrders)
        ForeColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        MinimumSize = New Size(1000, 700)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        CType(DataGridOrders, ComponentModel.ISupportInitialize).EndInit()
        pnLogout.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridOrders As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents pnLogout As Panel
    Friend WithEvents btnSetNew As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents btnAddrOrder As Button
    Friend WithEvents lblTitel As Label
    Friend WithEvents btnSort As Button
    Friend WithEvents btDetails As DataGridViewButtonColumn
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewButtonColumn
    Friend WithEvents colAddress As DataGridViewButtonColumn
    Friend WithEvents colContNumber As DataGridViewButtonColumn
    Friend WithEvents colStatus As DataGridViewButtonColumn
    Friend WithEvents colPrice As DataGridViewButtonColumn
    Friend WithEvents colPay As DataGridViewTextBoxColumn
    Friend WithEvents colStartedDate As DataGridViewTextBoxColumn
    Friend WithEvents colDueDate As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button5 As Button
End Class
