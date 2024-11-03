<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddClientForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddClientForm))
        btnSave = New Button()
        Panel1 = New Panel()
        tbNumber = New TextBox()
        lblContactNumber = New Label()
        fpTask = New FlowLayoutPanel()
        tbName = New TextBox()
        lblCustomerDetails = New Label()
        LblName = New Label()
        tbAddress = New TextBox()
        btnRemoveTask = New Button()
        lblAddress = New Label()
        btnAddTask = New Button()
        lblTask = New Label()
        btnCancel = New Button()
        Button1 = New Button()
        pnLogout = New Panel()
        btnSetNew = New Button()
        btnLogOut = New Button()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel1.SuspendLayout()
        pnLogout.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSave.ForeColor = Color.Black
        btnSave.Location = New Point(1064, 502)
        btnSave.Name = "btnSave"
        btnSave.Size = New System.Drawing.Size(91, 38)
        btnSave.TabIndex = 1
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        Panel1.Controls.Add(tbNumber)
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(lblContactNumber)
        Panel1.Controls.Add(fpTask)
        Panel1.Controls.Add(tbName)
        Panel1.Controls.Add(lblCustomerDetails)
        Panel1.Controls.Add(LblName)
        Panel1.Controls.Add(tbAddress)
        Panel1.Controls.Add(btnRemoveTask)
        Panel1.Controls.Add(lblAddress)
        Panel1.Controls.Add(btnAddTask)
        Panel1.Controls.Add(lblTask)
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(FlowLayoutPanel1)
        Panel1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(1300, 614)
        Panel1.TabIndex = 2
        ' 
        ' tbNumber
        ' 
        tbNumber.BackColor = Color.White
        tbNumber.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbNumber.Location = New Point(53, 347)
        tbNumber.MaxLength = 11
        tbNumber.Name = "tbNumber"
        tbNumber.PlaceholderText = "Enter Text"
        tbNumber.Size = New System.Drawing.Size(442, 33)
        tbNumber.TabIndex = 6
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.BackColor = Color.White
        lblContactNumber.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContactNumber.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblContactNumber.Location = New Point(53, 317)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New System.Drawing.Size(198, 27)
        lblContactNumber.TabIndex = 2
        lblContactNumber.Text = "Contact Number: "
        ' 
        ' fpTask
        ' 
        fpTask.AutoScroll = True
        fpTask.BackColor = Color.White
        fpTask.Location = New Point(555, 116)
        fpTask.Name = "fpTask"
        fpTask.Size = New System.Drawing.Size(694, 344)
        fpTask.TabIndex = 12
        ' 
        ' tbName
        ' 
        tbName.BackColor = Color.White
        tbName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbName.ForeColor = Color.BurlyWood
        tbName.Location = New Point(53, 202)
        tbName.MaxLength = 150
        tbName.Name = "tbName"
        tbName.PlaceholderText = "Enter Client Name"
        tbName.Size = New System.Drawing.Size(442, 33)
        tbName.TabIndex = 4
        ' 
        ' lblCustomerDetails
        ' 
        lblCustomerDetails.AutoSize = True
        lblCustomerDetails.BackColor = Color.Transparent
        lblCustomerDetails.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerDetails.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblCustomerDetails.Location = New Point(53, 52)
        lblCustomerDetails.Name = "lblCustomerDetails"
        lblCustomerDetails.Size = New System.Drawing.Size(260, 36)
        lblCustomerDetails.TabIndex = 0
        lblCustomerDetails.Text = " Customer Details"
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.BackColor = Color.White
        LblName.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblName.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        LblName.Location = New Point(53, 172)
        LblName.Name = "LblName"
        LblName.Size = New System.Drawing.Size(88, 27)
        LblName.TabIndex = 1
        LblName.Text = "Name: "
        ' 
        ' tbAddress
        ' 
        tbAddress.BackColor = Color.White
        tbAddress.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbAddress.ForeColor = Color.BurlyWood
        tbAddress.Location = New Point(53, 274)
        tbAddress.MaxLength = 150
        tbAddress.Name = "tbAddress"
        tbAddress.PlaceholderText = "Enter Address"
        tbAddress.Size = New System.Drawing.Size(442, 33)
        tbAddress.TabIndex = 5
        ' 
        ' btnRemoveTask
        ' 
        btnRemoveTask.BackColor = Color.White
        btnRemoveTask.Location = New Point(743, 77)
        btnRemoveTask.Name = "btnRemoveTask"
        btnRemoveTask.Size = New System.Drawing.Size(99, 34)
        btnRemoveTask.TabIndex = 11
        btnRemoveTask.Text = "Remove "
        btnRemoveTask.UseVisualStyleBackColor = False
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.BackColor = Color.White
        lblAddress.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddress.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblAddress.Location = New Point(53, 244)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New System.Drawing.Size(104, 27)
        lblAddress.TabIndex = 3
        lblAddress.Text = "Address:"
        ' 
        ' btnAddTask
        ' 
        btnAddTask.BackColor = Color.White
        btnAddTask.Location = New Point(646, 77)
        btnAddTask.Name = "btnAddTask"
        btnAddTask.Size = New System.Drawing.Size(91, 34)
        btnAddTask.TabIndex = 9
        btnAddTask.Text = "Add "
        btnAddTask.UseVisualStyleBackColor = False
        ' 
        ' lblTask
        ' 
        lblTask.AutoSize = True
        lblTask.BackColor = Color.Transparent
        lblTask.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTask.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblTask.Location = New Point(555, 82)
        lblTask.Name = "lblTask"
        lblTask.Size = New System.Drawing.Size(85, 27)
        lblTask.TabIndex = 7
        lblTask.Text = "Orders"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(1158, 502)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New System.Drawing.Size(91, 38)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(2022, 21)
        Button1.Name = "Button1"
        Button1.Size = New System.Drawing.Size(42, 36)
        Button1.TabIndex = 11
        Button1.UseVisualStyleBackColor = False
        ' 
        ' pnLogout
        ' 
        pnLogout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnLogout.BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        pnLogout.Controls.Add(btnSetNew)
        pnLogout.Controls.Add(btnLogOut)
        pnLogout.Location = New Point(1958, 63)
        pnLogout.Name = "pnLogout"
        pnLogout.Size = New System.Drawing.Size(122, 105)
        pnLogout.TabIndex = 12
        pnLogout.Visible = False
        ' 
        ' btnSetNew
        ' 
        btnSetNew.BackColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        btnSetNew.FlatStyle = FlatStyle.Flat
        btnSetNew.Location = New Point(18, 55)
        btnSetNew.Name = "btnSetNew"
        btnSetNew.Size = New System.Drawing.Size(91, 38)
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
        btnLogOut.Size = New System.Drawing.Size(91, 38)
        btnLogOut.TabIndex = 0
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = Color.White
        FlowLayoutPanel1.ForeColor = SystemColors.ControlLightLight
        FlowLayoutPanel1.Location = New Point(25, 116)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New System.Drawing.Size(506, 344)
        FlowLayoutPanel1.TabIndex = 13
        ' 
        ' AddClientForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        ClientSize = New System.Drawing.Size(1283, 608)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(pnLogout)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Name = "AddClientForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Client"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnLogout.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCustomerDetails As Label
    Friend WithEvents lblTask As Label
    Friend WithEvents btnAddTask As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRemoveTask As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pnLogout As Panel
    Friend WithEvents btnSetNew As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents fpTask As FlowLayoutPanel
    Friend WithEvents tbNumber As TextBox
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents LblName As Label
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
