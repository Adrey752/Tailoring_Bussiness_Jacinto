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
        lblTask = New Label()
        tbNumber = New TextBox()
        tbAddress = New TextBox()
        tbName = New TextBox()
        lblAddress = New Label()
        lblContactNumber = New Label()
        LblName = New Label()
        DataGridView1 = New DataGridView()
        Tasks = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        nudPayment = New NumericUpDown()
        lblPayment = New Label()
        nudPrice = New NumericUpDown()
        Label3 = New Label()
        Label2 = New Label()
        nudOrders = New NumericUpDown()
        tbStatus = New TextBox()
        Label4 = New Label()
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
        lblTask.Location = New Point(118, 376)
        lblTask.Name = "lblTask"
        lblTask.Size = New Drawing.Size(99, 36)
        lblTask.TabIndex = 14
        lblTask.Text = "Order"
        ' 
        ' tbNumber
        ' 
        tbNumber.BackColor = Color.White
        tbNumber.Location = New Point(223, 153)
        tbNumber.MaxLength = 11
        tbNumber.Name = "tbNumber"
        tbNumber.PlaceholderText = "Enter Text"
        tbNumber.ReadOnly = True
        tbNumber.Size = New Drawing.Size(133, 23)
        tbNumber.TabIndex = 13
        ' 
        ' tbAddress
        ' 
        tbAddress.BackColor = Color.White
        tbAddress.ForeColor = Color.BurlyWood
        tbAddress.Location = New Point(145, 102)
        tbAddress.MaxLength = 150
        tbAddress.Name = "tbAddress"
        tbAddress.PlaceholderText = "Enter Address"
        tbAddress.ReadOnly = True
        tbAddress.Size = New Drawing.Size(379, 23)
        tbAddress.TabIndex = 12
        ' 
        ' tbName
        ' 
        tbName.BackColor = Color.White
        tbName.ForeColor = Color.BurlyWood
        tbName.Location = New Point(145, 57)
        tbName.MaxLength = 150
        tbName.Name = "tbName"
        tbName.PlaceholderText = "Enter Client Name"
        tbName.ReadOnly = True
        tbName.Size = New Drawing.Size(379, 23)
        tbName.TabIndex = 11
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.BackColor = Color.Transparent
        lblAddress.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddress.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblAddress.Location = New Point(53, 100)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Drawing.Size(86, 22)
        lblAddress.TabIndex = 10
        lblAddress.Text = "Address:"
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.BackColor = Color.Transparent
        lblContactNumber.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContactNumber.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblContactNumber.Location = New Point(52, 153)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New Drawing.Size(165, 22)
        lblContactNumber.TabIndex = 9
        lblContactNumber.Text = "Contact Number: "
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.BackColor = Color.Transparent
        LblName.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblName.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        LblName.Location = New Point(53, 55)
        LblName.Name = "LblName"
        LblName.Size = New Drawing.Size(72, 22)
        LblName.TabIndex = 8
        LblName.Text = "Name: "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Tasks, Column2, Column3})
        DataGridView1.Location = New Point(118, 418)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Drawing.Size(945, 61)
        DataGridView1.TabIndex = 20
        ' 
        ' Tasks
        ' 
        Tasks.HeaderText = "Pending Tasks"
        Tasks.Name = "Tasks"
        Tasks.Width = 300
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Finished"
        Column2.Name = "Column2"
        Column2.Width = 300
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Claimed"
        Column3.Name = "Column3"
        Column3.Width = 300
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label1.Location = New Point(776, 124)
        Label1.Name = "Label1"
        Label1.Size = New Drawing.Size(133, 36)
        Label1.TabIndex = 21
        Label1.Text = "Payment"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(445, 389)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Drawing.Size(121, 23)
        ComboBox1.TabIndex = 22
        ComboBox1.Text = "Sort By"
        ' 
        ' nudPayment
        ' 
        nudPayment.Anchor = AnchorStyles.None
        nudPayment.Location = New Point(877, 212)
        nudPayment.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        nudPayment.Name = "nudPayment"
        nudPayment.ReadOnly = True
        nudPayment.Size = New Drawing.Size(120, 23)
        nudPayment.TabIndex = 29
        ' 
        ' lblPayment
        ' 
        lblPayment.Anchor = AnchorStyles.None
        lblPayment.AutoSize = True
        lblPayment.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblPayment.Location = New Point(785, 217)
        lblPayment.Name = "lblPayment"
        lblPayment.Size = New Drawing.Size(80, 15)
        lblPayment.TabIndex = 28
        lblPayment.Text = " Amount Paid"
        ' 
        ' nudPrice
        ' 
        nudPrice.Anchor = AnchorStyles.None
        nudPrice.Location = New Point(877, 172)
        nudPrice.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        nudPrice.Name = "nudPrice"
        nudPrice.ReadOnly = True
        nudPrice.Size = New Drawing.Size(120, 23)
        nudPrice.TabIndex = 30
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label3.Location = New Point(786, 174)
        Label3.Name = "Label3"
        Label3.Size = New Drawing.Size(75, 15)
        Label3.TabIndex = 31
        Label3.Text = "Amount Due"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label2.Location = New Point(55, 211)
        Label2.Name = "Label2"
        Label2.Size = New Drawing.Size(177, 22)
        Label2.TabIndex = 32
        Label2.Text = "Number of Orders:"
        ' 
        ' nudOrders
        ' 
        nudOrders.Location = New Point(250, 211)
        nudOrders.Name = "nudOrders"
        nudOrders.ReadOnly = True
        nudOrders.Size = New Drawing.Size(120, 23)
        nudOrders.TabIndex = 33
        ' 
        ' tbStatus
        ' 
        tbStatus.BackColor = Color.White
        tbStatus.Location = New Point(877, 54)
        tbStatus.MaxLength = 11
        tbStatus.Name = "tbStatus"
        tbStatus.ReadOnly = True
        tbStatus.Size = New Drawing.Size(133, 23)
        tbStatus.TabIndex = 35
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label4.Location = New Point(779, 55)
        Label4.Name = "Label4"
        Label4.Size = New Drawing.Size(61, 22)
        Label4.TabIndex = 34
        Label4.Text = "Status"
        ' 
        ' ProjectDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Drawing.Size(1169, 749)
        Controls.Add(tbStatus)
        Controls.Add(Label4)
        Controls.Add(nudOrders)
        Controls.Add(Label2)
        Controls.Add(nudPrice)
        Controls.Add(Label3)
        Controls.Add(nudPayment)
        Controls.Add(lblPayment)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(lblTask)
        Controls.Add(tbNumber)
        Controls.Add(tbAddress)
        Controls.Add(tbName)
        Controls.Add(lblAddress)
        Controls.Add(lblContactNumber)
        Controls.Add(LblName)
        Name = "ProjectDetailsForm"
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
    Friend WithEvents Tasks As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents nudPayment As NumericUpDown
    Friend WithEvents lblPayment As Label
    Friend WithEvents nudPrice As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nudOrders As NumericUpDown
    Friend WithEvents tbStatus As TextBox
    Friend WithEvents Label4 As Label
End Class
