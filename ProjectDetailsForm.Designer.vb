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
        lblTask = New Label()
        tbNumber = New TextBox()
        tbAddress = New TextBox()
        tbName = New TextBox()
        lblAddress = New Label()
        lblContactNumber = New Label()
        LblName = New Label()
        DataGridView1 = New DataGridView()
        Tasks = New DataGridViewCheckBoxColumn()
        Column2 = New DataGridViewCheckBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        lblHeaderPayment = New Label()
        cbSort = New ComboBox()
        nudPayment = New NumericUpDown()
        lblPayment = New Label()
        nudPrice = New NumericUpDown()
        lblAmountDue = New Label()
        lblNumOrders = New Label()
        nudOrders = New NumericUpDown()
        lblHeaderOrder = New Label()
        btnAddOrder = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPayment, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudOrders, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTask
        ' 
        lblTask.AutoSize = True
        lblTask.BackColor = Color.Transparent
        lblTask.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTask.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblTask.Location = New Point(555, 49)
        lblTask.Name = "lblTask"
        lblTask.Size = New System.Drawing.Size(99, 36)
        lblTask.TabIndex = 14
        lblTask.Text = "Order"
        ' 
        ' tbNumber
        ' 
        tbNumber.BackColor = Color.White
        tbNumber.Location = New Point(210, 211)
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
        tbAddress.Location = New Point(132, 160)
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
        tbName.Location = New Point(132, 115)
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
        lblAddress.Location = New Point(40, 159)
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
        lblContactNumber.Location = New Point(39, 211)
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
        LblName.Location = New Point(40, 114)
        LblName.Name = "LblName"
        LblName.Size = New System.Drawing.Size(72, 22)
        LblName.TabIndex = 8
        LblName.Text = "Name: "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Tasks, Column2, Column3})
        DataGridView1.Location = New Point(555, 159)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.Size = New System.Drawing.Size(644, 443)
        DataGridView1.TabIndex = 20
        ' 
        ' Tasks
        ' 
        Tasks.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Tasks.HeaderText = "Pending Tasks"
        Tasks.Name = "Tasks"
        Tasks.ReadOnly = True
        Tasks.Resizable = DataGridViewTriState.True
        Tasks.SortMode = DataGridViewColumnSortMode.Automatic
        Tasks.Width = 200
        ' 
        ' Column2
        ' 
        Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Column2.HeaderText = "Finished"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Resizable = DataGridViewTriState.True
        Column2.SortMode = DataGridViewColumnSortMode.Automatic
        Column2.Width = 200
        ' 
        ' Column3
        ' 
        Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        Column3.HeaderText = "Claimed"
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 200
        ' 
        ' lblHeaderPayment
        ' 
        lblHeaderPayment.AutoSize = True
        lblHeaderPayment.BackColor = Color.Transparent
        lblHeaderPayment.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeaderPayment.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblHeaderPayment.Location = New Point(49, 361)
        lblHeaderPayment.Name = "lblHeaderPayment"
        lblHeaderPayment.Size = New System.Drawing.Size(133, 36)
        lblHeaderPayment.TabIndex = 21
        lblHeaderPayment.Text = "Payment"
        ' 
        ' cbSort
        ' 
        cbSort.FormattingEnabled = True
        cbSort.Location = New Point(555, 113)
        cbSort.Name = "cbSort"
        cbSort.Size = New System.Drawing.Size(121, 23)
        cbSort.TabIndex = 22
        cbSort.Text = "Sort By"
        ' 
        ' nudPayment
        ' 
        nudPayment.Anchor = AnchorStyles.None
        nudPayment.Location = New Point(210, 485)
        nudPayment.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        nudPayment.Name = "nudPayment"
        nudPayment.ReadOnly = True
        nudPayment.Size = New System.Drawing.Size(120, 23)
        nudPayment.TabIndex = 29
        ' 
        ' lblPayment
        ' 
        lblPayment.Anchor = AnchorStyles.None
        lblPayment.AutoSize = True
        lblPayment.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblPayment.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblPayment.Location = New Point(49, 483)
        lblPayment.Name = "lblPayment"
        lblPayment.Size = New System.Drawing.Size(134, 25)
        lblPayment.TabIndex = 28
        lblPayment.Text = " Amount Paid"
        ' 
        ' nudPrice
        ' 
        nudPrice.Anchor = AnchorStyles.None
        nudPrice.Location = New Point(210, 426)
        nudPrice.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        nudPrice.Name = "nudPrice"
        nudPrice.ReadOnly = True
        nudPrice.Size = New System.Drawing.Size(120, 23)
        nudPrice.TabIndex = 30
        ' 
        ' lblAmountDue
        ' 
        lblAmountDue.Anchor = AnchorStyles.None
        lblAmountDue.AutoSize = True
        lblAmountDue.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblAmountDue.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblAmountDue.Location = New Point(56, 420)
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
        lblNumOrders.Location = New Point(42, 269)
        lblNumOrders.Name = "lblNumOrders"
        lblNumOrders.Size = New System.Drawing.Size(177, 22)
        lblNumOrders.TabIndex = 32
        lblNumOrders.Text = "Number of Orders:"
        ' 
        ' nudOrders
        ' 
        nudOrders.Location = New Point(237, 269)
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
        lblHeaderOrder.Location = New Point(39, 49)
        lblHeaderOrder.Name = "lblHeaderOrder"
        lblHeaderOrder.Size = New System.Drawing.Size(201, 36)
        lblHeaderOrder.TabIndex = 34
        lblHeaderOrder.Text = "Client Details"
        ' 
        ' btnAddOrder
        ' 
        btnAddOrder.Location = New Point(1124, 115)
        btnAddOrder.Name = "btnAddOrder"
        btnAddOrder.Size = New System.Drawing.Size(75, 23)
        btnAddOrder.TabIndex = 35
        btnAddOrder.Tag = ""
        btnAddOrder.Text = "Add Order"
        btnAddOrder.UseVisualStyleBackColor = True
        ' 
        ' ProjectDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(1246, 654)
        Controls.Add(btnAddOrder)
        Controls.Add(lblHeaderOrder)
        Controls.Add(nudOrders)
        Controls.Add(lblNumOrders)
        Controls.Add(nudPrice)
        Controls.Add(lblAmountDue)
        Controls.Add(nudPayment)
        Controls.Add(lblPayment)
        Controls.Add(cbSort)
        Controls.Add(lblHeaderPayment)
        Controls.Add(DataGridView1)
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
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPayment, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).EndInit()
        CType(nudOrders, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lblHeaderPayment As Label
    Friend WithEvents cbSort As ComboBox
    Friend WithEvents nudPayment As NumericUpDown
    Friend WithEvents lblPayment As Label
    Friend WithEvents nudPrice As NumericUpDown
    Friend WithEvents lblAmountDue As Label
    Friend WithEvents lblNumOrders As Label
    Friend WithEvents nudOrders As NumericUpDown
    Friend WithEvents lblHeaderOrder As Label
    Friend WithEvents btnAddOrder As Button
    Friend WithEvents Tasks As DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As DataGridViewCheckBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
