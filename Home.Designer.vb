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
        PictureBox1 = New PictureBox()
        btnAddrOrder = New Button()
        lblTitel = New Label()
        btnSort = New Button()
        CType(DataGridOrders, ComponentModel.ISupportInitialize).BeginInit()
        pnLogout.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridOrders
        ' 
        DataGridOrders.Anchor = AnchorStyles.None
        DataGridOrders.BackgroundColor = SystemColors.Control
        DataGridOrders.BorderStyle = BorderStyle.None
        DataGridOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridOrders.Columns.AddRange(New DataGridViewColumn() {btDetails, colId, colName, colAddress, colContNumber, colStatus, colPrice, colPay, colStartedDate, colDueDate})
        DataGridOrders.Location = New Point(73, 248)
        DataGridOrders.Name = "DataGridOrders"
        DataGridOrders.Size = New Size(1079, 385)
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
        colStartedDate.Width = 77
        ' 
        ' colDueDate
        ' 
        colDueDate.HeaderText = "Due Date"
        colDueDate.MinimumWidth = 80
        colDueDate.Name = "colDueDate"
        colDueDate.Width = 80
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.BackgroundImage = My.Resources.Resources.menus__1_
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(1130, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(42, 36)
        Button1.TabIndex = 2
        Button1.UseVisualStyleBackColor = True
        ' 
        ' pnLogout
        ' 
        pnLogout.BackColor = SystemColors.ActiveCaption
        pnLogout.Controls.Add(btnSetNew)
        pnLogout.Controls.Add(btnLogOut)
        pnLogout.Location = New Point(1073, 54)
        pnLogout.Name = "pnLogout"
        pnLogout.Size = New Size(99, 105)
        pnLogout.TabIndex = 3
        pnLogout.Visible = False
        ' 
        ' btnSetNew
        ' 
        btnSetNew.BackColor = Color.PaleTurquoise
        btnSetNew.Location = New Point(5, 55)
        btnSetNew.Name = "btnSetNew"
        btnSetNew.Size = New Size(91, 37)
        btnSetNew.TabIndex = 1
        btnSetNew.Text = "Set New password"
        btnSetNew.UseVisualStyleBackColor = False
        ' 
        ' btnLogOut
        ' 
        btnLogOut.BackColor = Color.PaleTurquoise
        btnLogOut.Location = New Point(8, 12)
        btnLogOut.Name = "btnLogOut"
        btnLogOut.Size = New Size(91, 37)
        btnLogOut.TabIndex = 0
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(73, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(203, 143)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' btnAddrOrder
        ' 
        btnAddrOrder.Anchor = AnchorStyles.None
        btnAddrOrder.BackColor = Color.PaleTurquoise
        btnAddrOrder.FlatAppearance.BorderSize = 0
        btnAddrOrder.FlatStyle = FlatStyle.Flat
        btnAddrOrder.ForeColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        btnAddrOrder.Location = New Point(329, 208)
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
        lblTitel.Anchor = AnchorStyles.None
        lblTitel.AutoSize = True
        lblTitel.BackColor = Color.Transparent
        lblTitel.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitel.ForeColor = Color.White
        lblTitel.Location = New Point(73, 200)
        lblTitel.Name = "lblTitel"
        lblTitel.Size = New Size(121, 45)
        lblTitel.TabIndex = 6
        lblTitel.Text = "Orders"
        ' 
        ' btnSort
        ' 
        btnSort.Anchor = AnchorStyles.None
        btnSort.BackColor = Color.PaleTurquoise
        btnSort.FlatAppearance.BorderSize = 0
        btnSort.FlatStyle = FlatStyle.Flat
        btnSort.ForeColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        btnSort.Location = New Point(226, 208)
        btnSort.Margin = New Padding(0)
        btnSort.Name = "btnSort"
        btnSort.RightToLeft = RightToLeft.No
        btnSort.Size = New Size(91, 37)
        btnSort.TabIndex = 7
        btnSort.Text = "Sort By"
        btnSort.UseVisualStyleBackColor = False
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        BackColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        ClientSize = New Size(1184, 661)
        Controls.Add(btnSort)
        Controls.Add(lblTitel)
        Controls.Add(btnAddrOrder)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(pnLogout)
        Controls.Add(DataGridOrders)
        ForeColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        MinimumSize = New Size(1000, 700)
        Name = "Home"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Home"
        CType(DataGridOrders, ComponentModel.ISupportInitialize).EndInit()
        pnLogout.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents DataGridOrders As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents pnLogout As Panel
    Friend WithEvents btnSetNew As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents PictureBox1 As PictureBox
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
End Class
