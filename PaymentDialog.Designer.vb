<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentDialog
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
        Cancel_Button = New Button()
        OK_Button = New Button()
        btnAddrOrder = New Button()
        lblBalance = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        Label3 = New Label()
        dtpPaymentDate = New DateTimePicker()
        nudPartialPayment = New NumericUpDown()
        Label2 = New Label()
        lblTotal = New Label()
        lblAmountDue = New Label()
        dgOrders = New DataGridView()
        Column1 = New DataGridViewCheckBoxColumn()
        colOrderName = New DataGridViewTextBoxColumn()
        colOrderPrice = New DataGridViewTextBoxColumn()
        Label6 = New Label()
        lblAmountToPay = New Label()
        Panel1 = New Panel()
        Label1 = New Label()
        CType(nudPartialPayment, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgOrders, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.Left
        Cancel_Button.AutoSize = True
        Cancel_Button.BackColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Cancel_Button.FlatAppearance.BorderSize = 0
        Cancel_Button.FlatStyle = FlatStyle.Flat
        Cancel_Button.ForeColor = Color.White
        Cancel_Button.Location = New Point(636, 421)
        Cancel_Button.Margin = New Padding(0)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.RightToLeft = RightToLeft.No
        Cancel_Button.Size = New System.Drawing.Size(100, 45)
        Cancel_Button.TabIndex = 63
        Cancel_Button.Text = "Cancel"
        Cancel_Button.UseVisualStyleBackColor = False
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.Left
        OK_Button.AutoSize = True
        OK_Button.BackColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        OK_Button.FlatAppearance.BorderSize = 0
        OK_Button.FlatStyle = FlatStyle.Flat
        OK_Button.ForeColor = Color.White
        OK_Button.Location = New Point(37, 383)
        OK_Button.Margin = New Padding(0)
        OK_Button.Name = "OK_Button"
        OK_Button.RightToLeft = RightToLeft.No
        OK_Button.Size = New System.Drawing.Size(237, 45)
        OK_Button.TabIndex = 62
        OK_Button.Text = "Check Out"
        OK_Button.UseVisualStyleBackColor = False
        ' 
        ' btnAddrOrder
        ' 
        btnAddrOrder.Anchor = AnchorStyles.Left
        btnAddrOrder.AutoSize = True
        btnAddrOrder.BackColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        btnAddrOrder.FlatAppearance.BorderSize = 0
        btnAddrOrder.FlatStyle = FlatStyle.Flat
        btnAddrOrder.ForeColor = Color.White
        btnAddrOrder.Location = New Point(37, 319)
        btnAddrOrder.Margin = New Padding(0)
        btnAddrOrder.Name = "btnAddrOrder"
        btnAddrOrder.RightToLeft = RightToLeft.No
        btnAddrOrder.Size = New System.Drawing.Size(237, 45)
        btnAddrOrder.TabIndex = 61
        btnAddrOrder.Text = "Preview Reciept"
        btnAddrOrder.UseVisualStyleBackColor = False
        ' 
        ' lblBalance
        ' 
        lblBalance.Anchor = AnchorStyles.Left
        lblBalance.AutoSize = True
        lblBalance.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblBalance.ForeColor = Color.FromArgb(CByte(255), CByte(87), CByte(34))
        lblBalance.Location = New Point(190, 127)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New System.Drawing.Size(105, 25)
        lblBalance.TabIndex = 60
        lblBalance.Text = "₱ 5,000.00"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(14, 131)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(140, 21)
        Label5.TabIndex = 59
        Label5.Text = "Remaining Balance"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Left
        TextBox1.Location = New Point(357, 121)
        TextBox1.Name = "TextBox1"
        TextBox1.PlaceholderText = "Search Order"
        TextBox1.Size = New System.Drawing.Size(379, 23)
        TextBox1.TabIndex = 58
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label3.Location = New Point(357, 77)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(182, 25)
        Label3.TabIndex = 57
        Label3.Text = "Pay Specific Orders"
        ' 
        ' dtpPaymentDate
        ' 
        dtpPaymentDate.Anchor = AnchorStyles.Left
        dtpPaymentDate.Location = New Point(544, 34)
        dtpPaymentDate.Name = "dtpPaymentDate"
        dtpPaymentDate.Size = New System.Drawing.Size(192, 23)
        dtpPaymentDate.TabIndex = 55
        ' 
        ' nudPartialPayment
        ' 
        nudPartialPayment.Anchor = AnchorStyles.Left
        nudPartialPayment.Location = New Point(190, 164)
        nudPartialPayment.Maximum = New Decimal(New Integer() {-1304428544, 434162106, 542, 0})
        nudPartialPayment.Name = "nudPartialPayment"
        nudPartialPayment.Size = New System.Drawing.Size(105, 23)
        nudPartialPayment.TabIndex = 54
        nudPartialPayment.ThousandsSeparator = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(14, 211)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(110, 21)
        Label2.TabIndex = 53
        Label2.Text = "Amount to Pay"
        ' 
        ' lblTotal
        ' 
        lblTotal.Anchor = AnchorStyles.Left
        lblTotal.AutoSize = True
        lblTotal.BackColor = Color.White
        lblTotal.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblTotal.ForeColor = Color.FromArgb(CByte(255), CByte(87), CByte(34))
        lblTotal.Location = New Point(190, 85)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New System.Drawing.Size(105, 25)
        lblTotal.TabIndex = 52
        lblTotal.Text = "₱ 5,000.00"
        ' 
        ' lblAmountDue
        ' 
        lblAmountDue.Anchor = AnchorStyles.Left
        lblAmountDue.AutoSize = True
        lblAmountDue.Font = New Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAmountDue.ForeColor = Color.Black
        lblAmountDue.Location = New Point(14, 89)
        lblAmountDue.Name = "lblAmountDue"
        lblAmountDue.Size = New System.Drawing.Size(79, 21)
        lblAmountDue.TabIndex = 51
        lblAmountDue.Text = "Total Price"
        ' 
        ' dgOrders
        ' 
        dgOrders.AllowUserToAddRows = False
        dgOrders.AllowUserToDeleteRows = False
        dgOrders.Anchor = AnchorStyles.Left
        dgOrders.BackgroundColor = Color.White
        dgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgOrders.Columns.AddRange(New DataGridViewColumn() {Column1, colOrderName, colOrderPrice})
        dgOrders.Location = New Point(357, 167)
        dgOrders.Name = "dgOrders"
        dgOrders.Size = New System.Drawing.Size(379, 247)
        dgOrders.TabIndex = 64
        ' 
        ' Column1
        ' 
        Column1.HeaderText = ""
        Column1.Name = "Column1"
        Column1.Resizable = DataGridViewTriState.True
        Column1.SortMode = DataGridViewColumnSortMode.Automatic
        Column1.Width = 25
        ' 
        ' colOrderName
        ' 
        colOrderName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        colOrderName.HeaderText = "Order Name"
        colOrderName.Name = "colOrderName"
        colOrderName.ReadOnly = True
        ' 
        ' colOrderPrice
        ' 
        colOrderPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colOrderPrice.HeaderText = "Price"
        colOrderPrice.Name = "colOrderPrice"
        colOrderPrice.ReadOnly = True
        colOrderPrice.Width = 135
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semilight", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Black
        Label6.Location = New Point(14, 166)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(114, 21)
        Label6.TabIndex = 65
        Label6.Text = "Partial Payment"
        ' 
        ' lblAmountToPay
        ' 
        lblAmountToPay.Anchor = AnchorStyles.Left
        lblAmountToPay.AutoSize = True
        lblAmountToPay.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblAmountToPay.ForeColor = Color.FromArgb(CByte(255), CByte(87), CByte(34))
        lblAmountToPay.Location = New Point(190, 211)
        lblAmountToPay.Name = "lblAmountToPay"
        lblAmountToPay.Size = New System.Drawing.Size(105, 25)
        lblAmountToPay.TabIndex = 66
        lblAmountToPay.Text = "₱ 2,550.00"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblAmountToPay)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(OK_Button)
        Panel1.Controls.Add(lblTotal)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(btnAddrOrder)
        Panel1.Controls.Add(lblBalance)
        Panel1.Controls.Add(lblAmountDue)
        Panel1.Controls.Add(nudPartialPayment)
        Panel1.Controls.Add(Label2)
        Panel1.Location = New Point(12, 19)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(319, 447)
        Panel1.TabIndex = 67
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Left
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label1.Location = New Point(14, 29)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(98, 30)
        Label1.TabIndex = 67
        Label1.Text = "Payment"
        ' 
        ' PaymentDialog
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        ClientSize = New System.Drawing.Size(748, 501)
        Controls.Add(dgOrders)
        Controls.Add(TextBox1)
        Controls.Add(Cancel_Button)
        Controls.Add(Label3)
        Controls.Add(dtpPaymentDate)
        Controls.Add(Panel1)
        ForeColor = SystemColors.ControlText
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "PaymentDialog"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dialog1"
        CType(nudPartialPayment, ComponentModel.ISupportInitialize).EndInit()
        CType(dgOrders, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents Cancel_Button As Button
    Friend WithEvents OK_Button As Button
    Friend WithEvents btnAddrOrder As Button
    Friend WithEvents lblBalance As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpPaymentDate As DateTimePicker
    Friend WithEvents nudPartialPayment As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblAmountDue As Label
    Friend WithEvents dgOrders As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents lblAmountToPay As Label
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents colOrderName As DataGridViewTextBoxColumn
    Friend WithEvents colOrderPrice As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label

End Class
