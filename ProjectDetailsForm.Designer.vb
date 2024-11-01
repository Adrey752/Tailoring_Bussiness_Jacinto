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
        lblTask = New Label()
        tbNumber = New TextBox()
        tbAddress = New TextBox()
        tbName = New TextBox()
        lblAddress = New Label()
        lblContactNumber = New Label()
        LblName = New Label()
        dgSortOrders = New DataGridView()
        pendingCheckBox = New DataGridViewCheckBoxColumn()
        pending = New DataGridViewTextBoxColumn()
        finishedCheckBox = New DataGridViewCheckBoxColumn()
        finished = New DataGridViewTextBoxColumn()
        claimed = New DataGridViewTextBoxColumn()
        lblHeaderPayment = New Label()
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
        CType(dgSortOrders, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudOrders, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgPaymentHistory, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTask
        ' 
        lblTask.AutoSize = True
        lblTask.BackColor = Color.Transparent
        lblTask.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTask.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblTask.Location = New Point(546, 27)
        lblTask.Name = "lblTask"
        lblTask.Size = New System.Drawing.Size(99, 36)
        lblTask.TabIndex = 14
        lblTask.Text = "Order"
        ' 
        ' tbNumber
        ' 
        tbNumber.BackColor = Color.White
        tbNumber.Location = New Point(210, 187)
        tbNumber.MaxLength = 11
        tbNumber.Name = "tbNumber"
        tbNumber.PlaceholderText = "Enter Phone Number"
        tbNumber.ReadOnly = True
        tbNumber.Size = New System.Drawing.Size(244, 23)
        tbNumber.TabIndex = 13
        ' 
        ' tbAddress
        ' 
        tbAddress.BackColor = Color.White
        tbAddress.ForeColor = Color.BurlyWood
        tbAddress.Location = New Point(132, 136)
        tbAddress.MaxLength = 150
        tbAddress.Name = "tbAddress"
        tbAddress.PlaceholderText = "Enter Address"
        tbAddress.ReadOnly = True
        tbAddress.Size = New System.Drawing.Size(322, 23)
        tbAddress.TabIndex = 12
        ' 
        ' tbName
        ' 
        tbName.BackColor = Color.White
        tbName.ForeColor = Color.BurlyWood
        tbName.Location = New Point(132, 91)
        tbName.MaxLength = 150
        tbName.Name = "tbName"
        tbName.PlaceholderText = "Enter Client Name"
        tbName.ReadOnly = True
        tbName.Size = New System.Drawing.Size(322, 23)
        tbName.TabIndex = 11
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.BackColor = Color.Transparent
        lblAddress.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddress.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblAddress.Location = New Point(40, 135)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New System.Drawing.Size(86, 22)
        lblAddress.TabIndex = 10
        lblAddress.Text = "Address:"
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.BackColor = Color.Transparent
        lblContactNumber.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContactNumber.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblContactNumber.Location = New Point(39, 187)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New System.Drawing.Size(165, 22)
        lblContactNumber.TabIndex = 9
        lblContactNumber.Text = "Contact Number: "
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.BackColor = Color.Transparent
        LblName.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblName.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        LblName.Location = New Point(40, 90)
        LblName.Name = "LblName"
        LblName.Size = New System.Drawing.Size(72, 22)
        LblName.TabIndex = 8
        LblName.Text = "Name: "
        ' 
        ' dgSortOrders
        ' 
        dgSortOrders.AllowDrop = True
        dgSortOrders.AllowUserToAddRows = False
        dgSortOrders.AllowUserToDeleteRows = False
        dgSortOrders.AllowUserToOrderColumns = True
        dgSortOrders.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        dgSortOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgSortOrders.Columns.AddRange(New DataGridViewColumn() {pendingCheckBox, pending, finishedCheckBox, finished, claimed})
        dgSortOrders.Location = New Point(533, 110)
        dgSortOrders.Name = "dgSortOrders"
        dgSortOrders.ReadOnly = True
        dgSortOrders.Size = New System.Drawing.Size(679, 287)
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
        ' lblHeaderPayment
        ' 
        lblHeaderPayment.AutoSize = True
        lblHeaderPayment.BackColor = Color.Transparent
        lblHeaderPayment.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeaderPayment.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblHeaderPayment.Location = New Point(39, 383)
        lblHeaderPayment.Name = "lblHeaderPayment"
        lblHeaderPayment.Size = New System.Drawing.Size(133, 36)
        lblHeaderPayment.TabIndex = 21
        lblHeaderPayment.Text = "Payment"
        ' 
        ' cbSort
        ' 
        cbSort.FormattingEnabled = True
        cbSort.Location = New Point(533, 81)
        cbSort.Name = "cbSort"
        cbSort.Size = New System.Drawing.Size(121, 23)
        cbSort.TabIndex = 22
        cbSort.Text = "Sort By"
        ' 
        ' lblPayment
        ' 
        lblPayment.Anchor = AnchorStyles.None
        lblPayment.AutoSize = True
        lblPayment.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblPayment.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblPayment.Location = New Point(30, 74)
        lblPayment.Name = "lblPayment"
        lblPayment.Size = New System.Drawing.Size(129, 25)
        lblPayment.TabIndex = 28
        lblPayment.Text = "Amount Paid"
        ' 
        ' lblTotalPrice
        ' 
        lblTotalPrice.Anchor = AnchorStyles.None
        lblTotalPrice.AutoSize = True
        lblTotalPrice.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblTotalPrice.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblTotalPrice.Location = New Point(30, 28)
        lblTotalPrice.Name = "lblTotalPrice"
        lblTotalPrice.Size = New System.Drawing.Size(104, 25)
        lblTotalPrice.TabIndex = 31
        lblTotalPrice.Text = "Total Price"
        ' 
        ' lblNumOrders
        ' 
        lblNumOrders.AutoSize = True
        lblNumOrders.BackColor = Color.Transparent
        lblNumOrders.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumOrders.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblNumOrders.Location = New Point(42, 245)
        lblNumOrders.Name = "lblNumOrders"
        lblNumOrders.Size = New System.Drawing.Size(177, 22)
        lblNumOrders.TabIndex = 32
        lblNumOrders.Text = "Number of Orders:"
        ' 
        ' nudOrders
        ' 
        nudOrders.Location = New Point(237, 245)
        nudOrders.Name = "nudOrders"
        nudOrders.ReadOnly = True
        nudOrders.Size = New System.Drawing.Size(120, 23)
        nudOrders.TabIndex = 33
        ' 
        ' lblHeaderOrder
        ' 
        lblHeaderOrder.AutoSize = True
        lblHeaderOrder.BackColor = Color.Transparent
        lblHeaderOrder.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeaderOrder.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblHeaderOrder.Location = New Point(39, 27)
        lblHeaderOrder.Name = "lblHeaderOrder"
        lblHeaderOrder.Size = New System.Drawing.Size(201, 36)
        lblHeaderOrder.TabIndex = 34
        lblHeaderOrder.Text = "Client Details"
        ' 
        ' btnAddOrder
        ' 
        btnAddOrder.Location = New Point(1037, 81)
        btnAddOrder.Name = "btnAddOrder"
        btnAddOrder.Size = New System.Drawing.Size(75, 23)
        btnAddOrder.TabIndex = 35
        btnAddOrder.Tag = ""
        btnAddOrder.Text = "Add Order"
        btnAddOrder.UseVisualStyleBackColor = True
        ' 
        ' dgPaymentHistory
        ' 
        dgPaymentHistory.AllowDrop = True
        dgPaymentHistory.AllowUserToAddRows = False
        dgPaymentHistory.AllowUserToDeleteRows = False
        dgPaymentHistory.AllowUserToOrderColumns = True
        dgPaymentHistory.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        dgPaymentHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgPaymentHistory.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, colOrdersPaid})
        dgPaymentHistory.Location = New Point(533, 424)
        dgPaymentHistory.Name = "dgPaymentHistory"
        dgPaymentHistory.ReadOnly = True
        dgPaymentHistory.Size = New System.Drawing.Size(679, 197)
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
        DataGridViewTextBoxColumn2.Width = 200
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
        lblDue.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblDue.Location = New Point(195, 28)
        lblDue.Name = "lblDue"
        lblDue.Size = New System.Drawing.Size(88, 25)
        lblDue.TabIndex = 37
        lblDue.Text = "5,000.00"
        ' 
        ' lblPaid
        ' 
        lblPaid.Anchor = AnchorStyles.None
        lblPaid.AutoSize = True
        lblPaid.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblPaid.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblPaid.Location = New Point(195, 74)
        lblPaid.Name = "lblPaid"
        lblPaid.Size = New System.Drawing.Size(88, 25)
        lblPaid.TabIndex = 38
        lblPaid.Text = "2,500.00"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(lblBalance)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(lblDue)
        Panel1.Controls.Add(lblPaid)
        Panel1.Controls.Add(lblPayment)
        Panel1.Controls.Add(lblTotalPrice)
        Panel1.Location = New Point(42, 424)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(367, 169)
        Panel1.TabIndex = 39
        ' 
        ' lblBalance
        ' 
        lblBalance.Anchor = AnchorStyles.None
        lblBalance.AutoSize = True
        lblBalance.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblBalance.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblBalance.Location = New Point(194, 115)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New System.Drawing.Size(88, 25)
        lblBalance.TabIndex = 40
        lblBalance.Text = "2,500.00"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.None
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label4.Location = New Point(33, 115)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(80, 25)
        Label4.TabIndex = 39
        Label4.Text = "Balance"
        ' 
        ' btnMakePayment
        ' 
        btnMakePayment.AutoSize = True
        btnMakePayment.BackColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        btnMakePayment.FlatAppearance.BorderSize = 0
        btnMakePayment.FlatStyle = FlatStyle.Flat
        btnMakePayment.ForeColor = Color.White
        btnMakePayment.Location = New Point(42, 608)
        btnMakePayment.Margin = New Padding(0)
        btnMakePayment.Name = "btnMakePayment"
        btnMakePayment.RightToLeft = RightToLeft.No
        btnMakePayment.Size = New System.Drawing.Size(367, 37)
        btnMakePayment.TabIndex = 40
        btnMakePayment.Text = "Make Payment"
        btnMakePayment.UseVisualStyleBackColor = False
        ' 
        ' ProjectDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(1246, 654)
        Controls.Add(btnMakePayment)
        Controls.Add(Panel1)
        Controls.Add(dgPaymentHistory)
        Controls.Add(btnAddOrder)
        Controls.Add(lblHeaderOrder)
        Controls.Add(nudOrders)
        Controls.Add(lblNumOrders)
        Controls.Add(cbSort)
        Controls.Add(lblHeaderPayment)
        Controls.Add(dgSortOrders)
        Controls.Add(lblTask)
        Controls.Add(tbNumber)
        Controls.Add(tbAddress)
        Controls.Add(tbName)
        Controls.Add(lblAddress)
        Controls.Add(lblContactNumber)
        Controls.Add(LblName)
        Location = New Point(244, 52)
        Name = "ProjectDetailsForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "ProjectDetailsForm"
        CType(dgSortOrders, ComponentModel.ISupportInitialize).EndInit()
        CType(nudOrders, ComponentModel.ISupportInitialize).EndInit()
        CType(dgPaymentHistory, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTask As Label
    Friend WithEvents tbNumber As TextBox
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents LblName As Label
    Friend WithEvents dgSortOrders As DataGridView
    Friend WithEvents lblHeaderPayment As Label
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
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents colOrdersPaid As DataGridViewTextBoxColumn
End Class
