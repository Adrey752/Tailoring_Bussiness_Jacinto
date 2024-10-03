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
        ComboBox2 = New ComboBox()
        ComboBox3 = New ComboBox()
        Label2 = New Label()
        Panel1 = New Panel()
        nudPayment = New NumericUpDown()
        lblPayment = New Label()
        nudPrice = New NumericUpDown()
        Label3 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPayment, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPrice, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTask
        ' 
        lblTask.AutoSize = True
        lblTask.BackColor = Color.Transparent
        lblTask.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTask.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblTask.Location = New Point(104, 140)
        lblTask.Name = "lblTask"
        lblTask.Size = New Size(99, 36)
        lblTask.TabIndex = 14
        lblTask.Text = "Order"
        ' 
        ' tbNumber
        ' 
        tbNumber.BackColor = Color.White
        tbNumber.Location = New Point(1013, 27)
        tbNumber.MaxLength = 11
        tbNumber.Name = "tbNumber"
        tbNumber.PlaceholderText = "Enter Text"
        tbNumber.Size = New Size(133, 23)
        tbNumber.TabIndex = 13
        ' 
        ' tbAddress
        ' 
        tbAddress.BackColor = Color.White
        tbAddress.ForeColor = Color.BurlyWood
        tbAddress.Location = New Point(104, 74)
        tbAddress.MaxLength = 150
        tbAddress.Name = "tbAddress"
        tbAddress.PlaceholderText = "Enter Address"
        tbAddress.Size = New Size(379, 23)
        tbAddress.TabIndex = 12
        ' 
        ' tbName
        ' 
        tbName.BackColor = Color.White
        tbName.ForeColor = Color.BurlyWood
        tbName.Location = New Point(104, 29)
        tbName.MaxLength = 150
        tbName.Name = "tbName"
        tbName.PlaceholderText = "Enter Client Name"
        tbName.Size = New Size(379, 23)
        tbName.TabIndex = 11
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.BackColor = Color.Transparent
        lblAddress.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddress.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblAddress.Location = New Point(12, 72)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(86, 22)
        lblAddress.TabIndex = 10
        lblAddress.Text = "Address:"
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.BackColor = Color.Transparent
        lblContactNumber.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContactNumber.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblContactNumber.Location = New Point(842, 27)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New Size(165, 22)
        lblContactNumber.TabIndex = 9
        lblContactNumber.Text = "Contact Number: "
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.BackColor = Color.Transparent
        LblName.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblName.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        LblName.Location = New Point(12, 27)
        LblName.Name = "LblName"
        LblName.Size = New Size(72, 22)
        LblName.TabIndex = 8
        LblName.Text = "Name: "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Tasks, Column2, Column3})
        DataGridView1.Location = New Point(104, 225)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(945, 61)
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
        Label1.Location = New Point(104, 490)
        Label1.Name = "Label1"
        Label1.Size = New Size(133, 36)
        Label1.TabIndex = 21
        Label1.Text = "Payment"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(323, 196)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 22
        ComboBox1.Text = "Sort By"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(624, 196)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 23
        ComboBox2.Text = "Sort By"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(928, 196)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(121, 23)
        ComboBox3.TabIndex = 24
        ComboBox3.Text = "Sort By"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label2.Location = New Point(104, 322)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 36)
        Label2.TabIndex = 26
        Label2.Text = "Tasks"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaptionText
        Panel1.Location = New Point(104, 370)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(952, 93)
        Panel1.TabIndex = 27
        ' 
        ' nudPayment
        ' 
        nudPayment.Anchor = AnchorStyles.None
        nudPayment.Location = New Point(296, 584)
        nudPayment.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
        nudPayment.Name = "nudPayment"
        nudPayment.Size = New Size(120, 23)
        nudPayment.TabIndex = 29
        ' 
        ' lblPayment
        ' 
        lblPayment.Anchor = AnchorStyles.None
        lblPayment.AutoSize = True
        lblPayment.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblPayment.Location = New Point(204, 589)
        lblPayment.Name = "lblPayment"
        lblPayment.Size = New Size(80, 15)
        lblPayment.TabIndex = 28
        lblPayment.Text = " Amount Paid"
        ' 
        ' nudPrice
        ' 
        nudPrice.Anchor = AnchorStyles.None
        nudPrice.Location = New Point(296, 544)
        nudPrice.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        nudPrice.Name = "nudPrice"
        nudPrice.Size = New Size(120, 23)
        nudPrice.TabIndex = 30
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label3.Location = New Point(205, 546)
        Label3.Name = "Label3"
        Label3.Size = New Size(75, 15)
        Label3.TabIndex = 31
        Label3.Text = "Amount Due"
        ' 
        ' ProjectDetailsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1169, 756)
        Controls.Add(nudPrice)
        Controls.Add(Label3)
        Controls.Add(nudPayment)
        Controls.Add(lblPayment)
        Controls.Add(Panel1)
        Controls.Add(Label2)
        Controls.Add(ComboBox3)
        Controls.Add(ComboBox2)
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
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents nudPayment As NumericUpDown
    Friend WithEvents lblPayment As Label
    Friend WithEvents nudPrice As NumericUpDown
    Friend WithEvents Label3 As Label
End Class
