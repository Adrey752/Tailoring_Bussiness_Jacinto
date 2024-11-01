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
        CType(nudPartialPayment, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgOrders, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Cancel_Button
        ' 
        Cancel_Button.Anchor = AnchorStyles.Left
        Cancel_Button.AutoSize = True
        Cancel_Button.BackColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Cancel_Button.FlatAppearance.BorderSize = 0
        Cancel_Button.FlatStyle = FlatStyle.Flat
        Cancel_Button.ForeColor = Color.White
        Cancel_Button.Location = New Point(49, 413)
        Cancel_Button.Margin = New Padding(0)
        Cancel_Button.Name = "Cancel_Button"
        Cancel_Button.RightToLeft = RightToLeft.No
        Cancel_Button.Size = New System.Drawing.Size(237, 37)
        Cancel_Button.TabIndex = 63
        Cancel_Button.Text = "Cancel"
        Cancel_Button.UseVisualStyleBackColor = False
        ' 
        ' OK_Button
        ' 
        OK_Button.Anchor = AnchorStyles.Left
        OK_Button.AutoSize = True
        OK_Button.BackColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        OK_Button.FlatAppearance.BorderSize = 0
        OK_Button.FlatStyle = FlatStyle.Flat
        OK_Button.ForeColor = Color.White
        OK_Button.Location = New Point(49, 364)
        OK_Button.Margin = New Padding(0)
        OK_Button.Name = "OK_Button"
        OK_Button.RightToLeft = RightToLeft.No
        OK_Button.Size = New System.Drawing.Size(237, 37)
        OK_Button.TabIndex = 62
        OK_Button.Text = "Check Out"
        OK_Button.UseVisualStyleBackColor = False
        ' 
        ' btnAddrOrder
        ' 
        btnAddrOrder.Anchor = AnchorStyles.Left
        btnAddrOrder.AutoSize = True
        btnAddrOrder.BackColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        btnAddrOrder.FlatAppearance.BorderSize = 0
        btnAddrOrder.FlatStyle = FlatStyle.Flat
        btnAddrOrder.ForeColor = Color.White
        btnAddrOrder.Location = New Point(49, 309)
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
        lblBalance.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblBalance.Location = New Point(187, 106)
        lblBalance.Name = "lblBalance"
        lblBalance.Size = New System.Drawing.Size(105, 25)
        lblBalance.TabIndex = 60
        lblBalance.Text = "₱ 5,000.00"
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Left
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label5.Location = New Point(22, 94)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(112, 50)
        Label5.TabIndex = 59
        Label5.Text = "Remaining " & vbCrLf & "Balance"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Left
        TextBox1.Location = New Point(357, 187)
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
        Label3.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label3.Location = New Point(357, 146)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(182, 25)
        Label3.TabIndex = 57
        Label3.Text = "Pay Specific Orders"
        ' 
        ' dtpPaymentDate
        ' 
        dtpPaymentDate.Anchor = AnchorStyles.Left
        dtpPaymentDate.Location = New Point(526, 36)
        dtpPaymentDate.Name = "dtpPaymentDate"
        dtpPaymentDate.Size = New System.Drawing.Size(192, 23)
        dtpPaymentDate.TabIndex = 55
        ' 
        ' nudPartialPayment
        ' 
        nudPartialPayment.Anchor = AnchorStyles.Left
        nudPartialPayment.Location = New Point(187, 184)
        nudPartialPayment.Maximum = New Decimal(New Integer() {-1304428544, 434162106, 542, 0})
        nudPartialPayment.Name = "nudPartialPayment"
        nudPartialPayment.Size = New System.Drawing.Size(120, 23)
        nudPartialPayment.TabIndex = 54
        nudPartialPayment.ThousandsSeparator = True
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label2.Location = New Point(22, 230)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(146, 25)
        Label2.TabIndex = 53
        Label2.Text = "Amount to Pay"
        ' 
        ' lblTotal
        ' 
        lblTotal.Anchor = AnchorStyles.Left
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblTotal.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblTotal.Location = New Point(187, 34)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New System.Drawing.Size(105, 25)
        lblTotal.TabIndex = 52
        lblTotal.Text = "₱ 5,000.00"
        ' 
        ' lblAmountDue
        ' 
        lblAmountDue.Anchor = AnchorStyles.Left
        lblAmountDue.AutoSize = True
        lblAmountDue.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblAmountDue.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblAmountDue.Location = New Point(22, 34)
        lblAmountDue.Name = "lblAmountDue"
        lblAmountDue.Size = New System.Drawing.Size(104, 25)
        lblAmountDue.TabIndex = 51
        lblAmountDue.Text = "Total Price"
        ' 
        ' dgOrders
        ' 
        dgOrders.AllowUserToAddRows = False
        dgOrders.AllowUserToDeleteRows = False
        dgOrders.Anchor = AnchorStyles.Left
        dgOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgOrders.Columns.AddRange(New DataGridViewColumn() {Column1, colOrderName, colOrderPrice})
        dgOrders.Location = New Point(357, 230)
        dgOrders.Name = "dgOrders"
        dgOrders.Size = New System.Drawing.Size(379, 236)
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
        Label6.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        Label6.Location = New Point(22, 182)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(153, 25)
        Label6.TabIndex = 65
        Label6.Text = "Partial Payment"
        ' 
        ' lblAmountToPay
        ' 
        lblAmountToPay.Anchor = AnchorStyles.Left
        lblAmountToPay.AutoSize = True
        lblAmountToPay.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblAmountToPay.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblAmountToPay.Location = New Point(187, 230)
        lblAmountToPay.Name = "lblAmountToPay"
        lblAmountToPay.Size = New System.Drawing.Size(105, 25)
        lblAmountToPay.TabIndex = 66
        lblAmountToPay.Text = "₱ 2,550.00"
        ' 
        ' PaymentDialog
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(748, 501)
        Controls.Add(lblAmountToPay)
        Controls.Add(Label6)
        Controls.Add(dgOrders)
        Controls.Add(Cancel_Button)
        Controls.Add(OK_Button)
        Controls.Add(btnAddrOrder)
        Controls.Add(lblBalance)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(dtpPaymentDate)
        Controls.Add(nudPartialPayment)
        Controls.Add(Label2)
        Controls.Add(lblTotal)
        Controls.Add(lblAmountDue)
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

End Class
