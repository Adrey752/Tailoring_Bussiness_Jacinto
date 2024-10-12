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
        fpTask = New FlowLayoutPanel()
        btnRemoveTask = New Button()
        btnAddTask = New Button()
        lblTask = New Label()
        btnCancel = New Button()
        tbNumber = New TextBox()
        tbAddress = New TextBox()
        tbName = New TextBox()
        lblAddress = New Label()
        lblContactNumber = New Label()
        LblName = New Label()
        lblCustomerDetails = New Label()
        Button1 = New Button()
        pnLogout = New Panel()
        btnSetNew = New Button()
        btnLogOut = New Button()
        Panel2 = New Panel()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        pnLogout.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(720, 77)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(91, 38)
        btnSave.TabIndex = 1
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(fpTask)
        Panel1.Controls.Add(btnRemoveTask)
        Panel1.Controls.Add(btnAddTask)
        Panel1.Controls.Add(lblTask)
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(tbNumber)
        Panel1.Controls.Add(tbAddress)
        Panel1.Controls.Add(tbName)
        Panel1.Controls.Add(lblAddress)
        Panel1.Controls.Add(lblContactNumber)
        Panel1.Controls.Add(LblName)
        Panel1.Controls.Add(lblCustomerDetails)
        Panel1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(290, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1009, 746)
        Panel1.TabIndex = 2
        ' 
        ' fpTask
        ' 
        fpTask.AutoScroll = True
        fpTask.Location = New Point(41, 267)
        fpTask.Name = "fpTask"
        fpTask.Size = New Size(877, 202)
        fpTask.TabIndex = 12
        ' 
        ' btnRemoveTask
        ' 
        btnRemoveTask.BackColor = Color.White
        btnRemoveTask.Location = New Point(827, 505)
        btnRemoveTask.Name = "btnRemoveTask"
        btnRemoveTask.Size = New Size(91, 38)
        btnRemoveTask.TabIndex = 11
        btnRemoveTask.Text = "Remove Task"
        btnRemoveTask.UseVisualStyleBackColor = False
        ' 
        ' btnAddTask
        ' 
        btnAddTask.BackColor = Color.White
        btnAddTask.Location = New Point(720, 505)
        btnAddTask.Name = "btnAddTask"
        btnAddTask.Size = New Size(91, 38)
        btnAddTask.TabIndex = 9
        btnAddTask.Text = "Add Task"
        btnAddTask.UseVisualStyleBackColor = False
        ' 
        ' lblTask
        ' 
        lblTask.AutoSize = True
        lblTask.BackColor = Color.Transparent
        lblTask.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTask.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblTask.Location = New Point(41, 216)
        lblTask.Name = "lblTask"
        lblTask.Size = New Size(71, 27)
        lblTask.TabIndex = 7
        lblTask.Text = "Tasks"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(827, 77)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(91, 38)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' tbNumber
        ' 
        tbNumber.BackColor = Color.White
        tbNumber.Location = New Point(212, 159)
        tbNumber.MaxLength = 11
        tbNumber.Name = "tbNumber"
        tbNumber.PlaceholderText = "Enter Text"
        tbNumber.Size = New Size(322, 23)
        tbNumber.TabIndex = 6
        ' 
        ' tbAddress
        ' 
        tbAddress.BackColor = Color.White
        tbAddress.ForeColor = Color.BurlyWood
        tbAddress.Location = New Point(155, 121)
        tbAddress.MaxLength = 150
        tbAddress.Name = "tbAddress"
        tbAddress.PlaceholderText = "Enter Address"
        tbAddress.Size = New Size(379, 23)
        tbAddress.TabIndex = 5
        ' 
        ' tbName
        ' 
        tbName.BackColor = Color.White
        tbName.ForeColor = Color.BurlyWood
        tbName.Location = New Point(155, 86)
        tbName.MaxLength = 150
        tbName.Name = "tbName"
        tbName.PlaceholderText = "Enter Client Name"
        tbName.Size = New Size(379, 23)
        tbName.TabIndex = 4
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.BackColor = Color.Transparent
        lblAddress.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddress.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblAddress.Location = New Point(41, 116)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(86, 22)
        lblAddress.TabIndex = 3
        lblAddress.Text = "Address:"
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.BackColor = Color.Transparent
        lblContactNumber.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContactNumber.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblContactNumber.Location = New Point(41, 160)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New Size(165, 22)
        lblContactNumber.TabIndex = 2
        lblContactNumber.Text = "Contact Number: "
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.BackColor = Color.Transparent
        LblName.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblName.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        LblName.Location = New Point(41, 84)
        LblName.Name = "LblName"
        LblName.Size = New Size(72, 22)
        LblName.TabIndex = 1
        LblName.Text = "Name: "
        ' 
        ' lblCustomerDetails
        ' 
        lblCustomerDetails.AutoSize = True
        lblCustomerDetails.BackColor = Color.Transparent
        lblCustomerDetails.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerDetails.ForeColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        lblCustomerDetails.Location = New Point(447, 23)
        lblCustomerDetails.Name = "lblCustomerDetails"
        lblCustomerDetails.Size = New Size(199, 27)
        lblCustomerDetails.TabIndex = 0
        lblCustomerDetails.Text = " Customer Details"
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(2039, 21)
        Button1.Name = "Button1"
        Button1.Size = New Size(42, 36)
        Button1.TabIndex = 11
        Button1.UseVisualStyleBackColor = False
        ' 
        ' pnLogout
        ' 
        pnLogout.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        pnLogout.BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        pnLogout.Controls.Add(btnSetNew)
        pnLogout.Controls.Add(btnLogOut)
        pnLogout.Location = New Point(1975, 63)
        pnLogout.Name = "pnLogout"
        pnLogout.Size = New Size(122, 105)
        pnLogout.TabIndex = 12
        pnLogout.Visible = False
        ' 
        ' btnSetNew
        ' 
        btnSetNew.BackColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        btnSetNew.FlatStyle = FlatStyle.Flat
        btnSetNew.Location = New Point(18, 55)
        btnSetNew.Name = "btnSetNew"
        btnSetNew.Size = New Size(91, 38)
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
        btnLogOut.Size = New Size(91, 38)
        btnLogOut.TabIndex = 0
        btnLogOut.Text = "Logout"
        btnLogOut.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(254), CByte(254))
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(PictureBox2)
        Panel2.Location = New Point(0, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(284, 1066)
        Panel2.TabIndex = 15
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.BurlyWood
        Button4.Location = New Point(3, 363)
        Button4.Name = "Button4"
        Button4.Padding = New Padding(29, 0, 0, 0)
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
        Button3.Padding = New Padding(29, 0, 0, 0)
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
        Button2.Padding = New Padding(29, 0, 0, 0)
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
        PictureBox2.Location = New Point(43, 62)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(203, 142)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 9
        PictureBox2.TabStop = False
        ' 
        ' AddClientForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        ClientSize = New Size(1300, 749)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Button1)
        Controls.Add(pnLogout)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Name = "AddClientForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Client"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnLogout.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCustomerDetails As Label
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents tbName As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents LblName As Label
    Friend WithEvents tbNumber As TextBox
    Friend WithEvents lblTask As Label
    Friend WithEvents btnAddTask As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRemoveTask As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pnLogout As Panel
    Friend WithEvents btnSetNew As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents fpTask As FlowLayoutPanel
End Class
