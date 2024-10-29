﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblTask = New Label()
        tbNumber = New TextBox()
        tbAddress = New TextBox()
        tbName = New TextBox()
        lblAddress = New Label()
        lblContactNumber = New Label()
        LblName = New Label()
        dgSortOrders = New DataGridView()
        lblHeaderPayment = New Label()
        cbSort = New ComboBox()
        lblPayment = New Label()
        lblAmountDue = New Label()
        lblNumOrders = New Label()
        nudOrders = New NumericUpDown()
        lblHeaderOrder = New Label()
        btnAddOrder = New Button()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Panel1 = New Panel()
        Label3 = New Label()
        Label4 = New Label()
        btnAddrOrder = New Button()
        claimed = New DataGridViewTextBoxColumn()
        finished = New DataGridViewTextBoxColumn()
        finishedCheckBox = New DataGridViewCheckBoxColumn()
        pending = New DataGridViewTextBoxColumn()
        pendingCheckBox = New DataGridViewCheckBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn3 = New DataGridViewTextBoxColumn()
        colOrdersPaid = New DataGridViewTextBoxColumn()
        Panel2 = New Panel()
        CType(dgSortOrders, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudOrders, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' lblAmountDue
        ' 
        lblAmountDue.Anchor = AnchorStyles.None
        lblAmountDue.AutoSize = True
        lblAmountDue.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblAmountDue.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblAmountDue.Location = New Point(30, 28)
        lblAmountDue.Name = "lblAmountDue"
        lblAmountDue.Size = New System.Drawing.Size(126, 25)
        lblAmountDue.TabIndex = 31
        lblAmountDue.Text = "Amount Due"
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
        ' DataGridView1
        ' 
        DataGridView1.AllowDrop = True
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn2, DataGridViewTextBoxColumn3, colOrdersPaid})
        DataGridView1.Location = New Point(533, 424)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New System.Drawing.Size(679, 197)
        DataGridView1.TabIndex = 36
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label1.Location = New Point(195, 28)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(88, 25)
        Label1.TabIndex = 37
        Label1.Text = "5,000.00"
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label2.Location = New Point(195, 74)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(88, 25)
        Label2.TabIndex = 38
        Label2.Text = "2,500.00"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(lblPayment)
        Panel1.Controls.Add(lblAmountDue)
        Panel1.Location = New Point(42, 424)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(367, 169)
        Panel1.TabIndex = 39
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label3.Location = New Point(194, 115)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(88, 25)
        Label3.TabIndex = 40
        Label3.Text = "2,500.00"
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
        ' btnAddrOrder
        ' 
        btnAddrOrder.AutoSize = True
        btnAddrOrder.BackColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        btnAddrOrder.FlatAppearance.BorderSize = 0
        btnAddrOrder.FlatStyle = FlatStyle.Flat
        btnAddrOrder.ForeColor = Color.White
        btnAddrOrder.Location = New Point(42, 608)
        btnAddrOrder.Margin = New Padding(0)
        btnAddrOrder.Name = "btnAddrOrder"
        btnAddrOrder.RightToLeft = RightToLeft.No
        btnAddrOrder.Size = New System.Drawing.Size(367, 37)
        btnAddrOrder.TabIndex = 40
        btnAddrOrder.Text = "Add order"
        btnAddrOrder.UseVisualStyleBackColor = False
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
        ' finishedCheckBox
        ' 
        finishedCheckBox.HeaderText = ""
        finishedCheckBox.MinimumWidth = 35
        finishedCheckBox.Name = "finishedCheckBox"
        finishedCheckBox.ReadOnly = True
        finishedCheckBox.Width = 35
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
        ' pendingCheckBox
        ' 
        pendingCheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        pendingCheckBox.HeaderText = ""
        pendingCheckBox.MinimumWidth = 35
        pendingCheckBox.Name = "pendingCheckBox"
        pendingCheckBox.ReadOnly = True
        pendingCheckBox.Width = 35
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
        ' Panel2
        ' 
        Panel2.BackColor = Color.White
        Panel2.Location = New Point(533, 136)
        Panel2.Name = "Panel2"
        Panel2.Size = New System.Drawing.Size(442, 239)
        Panel2.TabIndex = 41
        ' 
        ' ProjectDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(1246, 654)
        Controls.Add(Panel2)
        Controls.Add(btnAddrOrder)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
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
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblAmountDue As Label
    Friend WithEvents lblNumOrders As Label
    Friend WithEvents nudOrders As NumericUpDown
    Friend WithEvents lblHeaderOrder As Label
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddrOrder As Button
    Friend WithEvents pendingCheckBox As DataGridViewCheckBoxColumn
    Friend WithEvents pending As DataGridViewTextBoxColumn
    Friend WithEvents finishedCheckBox As DataGridViewCheckBoxColumn
    Friend WithEvents finished As DataGridViewTextBoxColumn
    Friend WithEvents claimed As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents colOrdersPaid As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As Panel
End Class
