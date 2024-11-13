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
        PictureBox5 = New PictureBox()
        PictureBox4 = New PictureBox()
        pnNavigation = New Panel()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        pbTailoringJacinto = New PictureBox()
        btnSettings = New Button()
        btnSearch = New Button()
        btnHome = New Button()
        Panel2 = New Panel()
        lblCustomerDetails = New Label()
        tbNumber = New TextBox()
        lblContactNumber = New Label()
        fpTask = New FlowLayoutPanel()
        tbName = New TextBox()
        LblName = New Label()
        tbAddress = New TextBox()
        lblAddress = New Label()
        lblTask = New Label()
        btnAddTask = New Button()
        btnRemoveTask = New Button()
        Button1 = New Button()
        pnLogout = New Panel()
        btnSetNew = New Button()
        btnLogOut = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        pnNavigation.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbTailoringJacinto, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        pnLogout.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(1157, 551)
        btnSave.Name = "btnSave"
        btnSave.Size = New System.Drawing.Size(91, 38)
        btnSave.TabIndex = 1
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(pnNavigation)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(tbNumber)
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(lblContactNumber)
        Panel1.Controls.Add(fpTask)
        Panel1.Controls.Add(tbName)
        Panel1.Controls.Add(LblName)
        Panel1.Controls.Add(tbAddress)
        Panel1.Controls.Add(lblAddress)
        Panel1.Controls.Add(lblTask)
        Panel1.Controls.Add(btnAddTask)
        Panel1.Controls.Add(btnRemoveTask)
        Panel1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(1300, 700)
        Panel1.TabIndex = 2
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.White
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(873, 149)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New System.Drawing.Size(31, 25)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 17
        PictureBox5.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.White
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(771, 149)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New System.Drawing.Size(27, 25)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 16
        PictureBox4.TabStop = False
        ' 
        ' pnNavigation
        ' 
        pnNavigation.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        pnNavigation.BackColor = Color.FromArgb(CByte(255), CByte(254), CByte(254))
        pnNavigation.Controls.Add(PictureBox3)
        pnNavigation.Controls.Add(PictureBox2)
        pnNavigation.Controls.Add(PictureBox1)
        pnNavigation.Controls.Add(pbTailoringJacinto)
        pnNavigation.Controls.Add(btnSettings)
        pnNavigation.Controls.Add(btnSearch)
        pnNavigation.Controls.Add(btnHome)
        pnNavigation.Location = New Point(0, 0)
        pnNavigation.Name = "pnNavigation"
        pnNavigation.Size = New System.Drawing.Size(78, 778)
        pnNavigation.TabIndex = 14
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.BurlyWood
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(13, 211)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New System.Drawing.Size(50, 26)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 17
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(217), CByte(185), CByte(155))
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(13, 169)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New System.Drawing.Size(50, 27)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 16
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 129)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(50, 27)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' pbTailoringJacinto
        ' 
        pbTailoringJacinto.Image = CType(resources.GetObject("pbTailoringJacinto.Image"), Image)
        pbTailoringJacinto.Location = New Point(3, 3)
        pbTailoringJacinto.Name = "pbTailoringJacinto"
        pbTailoringJacinto.Size = New System.Drawing.Size(72, 65)
        pbTailoringJacinto.SizeMode = PictureBoxSizeMode.Zoom
        pbTailoringJacinto.TabIndex = 9
        pbTailoringJacinto.TabStop = False
        ' 
        ' btnSettings
        ' 
        btnSettings.BackColor = Color.BurlyWood
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.ForeColor = Color.BurlyWood
        btnSettings.Location = New Point(-3, 202)
        btnSettings.Name = "btnSettings"
        btnSettings.Padding = New Padding(30, 0, 0, 0)
        btnSettings.Size = New System.Drawing.Size(81, 45)
        btnSettings.TabIndex = 11
        btnSettings.TextAlign = ContentAlignment.MiddleLeft
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(217), CByte(185), CByte(155))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.ForeColor = Color.FromArgb(CByte(217), CByte(185), CByte(155))
        btnSearch.Location = New Point(-3, 160)
        btnSearch.Name = "btnSearch"
        btnSearch.Padding = New Padding(30, 0, 0, 0)
        btnSearch.Size = New System.Drawing.Size(81, 45)
        btnSearch.TabIndex = 10
        btnSearch.TextAlign = ContentAlignment.MiddleLeft
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.ForeColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        btnHome.Location = New Point(-3, 118)
        btnHome.Name = "btnHome"
        btnHome.Padding = New Padding(30, 0, 0, 0)
        btnHome.Size = New System.Drawing.Size(81, 45)
        btnHome.TabIndex = 9
        btnHome.TextAlign = ContentAlignment.MiddleLeft
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(255), CByte(254), CByte(254))
        Panel2.Controls.Add(lblCustomerDetails)
        Panel2.Location = New Point(73, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New System.Drawing.Size(1212, 68)
        Panel2.TabIndex = 15
        ' 
        ' lblCustomerDetails
        ' 
        lblCustomerDetails.AutoSize = True
        lblCustomerDetails.BackColor = Color.Transparent
        lblCustomerDetails.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerDetails.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblCustomerDetails.Location = New Point(26, 18)
        lblCustomerDetails.Name = "lblCustomerDetails"
        lblCustomerDetails.Size = New System.Drawing.Size(260, 36)
        lblCustomerDetails.TabIndex = 0
        lblCustomerDetails.Text = " Customer Details"
        ' 
        ' tbNumber
        ' 
        tbNumber.BackColor = Color.White
        tbNumber.BorderStyle = BorderStyle.None
        tbNumber.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbNumber.Location = New Point(126, 374)
        tbNumber.MaxLength = 11
        tbNumber.Name = "tbNumber"
        tbNumber.Size = New System.Drawing.Size(442, 26)
        tbNumber.TabIndex = 6
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.BackColor = Color.Transparent
        lblContactNumber.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContactNumber.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblContactNumber.Location = New Point(126, 344)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New System.Drawing.Size(165, 22)
        lblContactNumber.TabIndex = 2
        lblContactNumber.Text = "Contact Number: "
        ' 
        ' fpTask
        ' 
        fpTask.AutoScroll = True
        fpTask.BackColor = Color.White
        fpTask.Location = New Point(629, 187)
        fpTask.Name = "fpTask"
        fpTask.Size = New System.Drawing.Size(619, 279)
        fpTask.TabIndex = 12
        ' 
        ' tbName
        ' 
        tbName.BackColor = Color.White
        tbName.BorderStyle = BorderStyle.None
        tbName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbName.ForeColor = Color.BurlyWood
        tbName.Location = New Point(126, 229)
        tbName.MaxLength = 150
        tbName.Name = "tbName"
        tbName.Size = New System.Drawing.Size(442, 26)
        tbName.TabIndex = 4
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.BackColor = Color.Transparent
        LblName.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblName.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        LblName.Location = New Point(126, 202)
        LblName.Name = "LblName"
        LblName.Size = New System.Drawing.Size(72, 22)
        LblName.TabIndex = 1
        LblName.Text = "Name: "
        ' 
        ' tbAddress
        ' 
        tbAddress.BackColor = Color.White
        tbAddress.BorderStyle = BorderStyle.None
        tbAddress.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbAddress.ForeColor = Color.BurlyWood
        tbAddress.Location = New Point(126, 301)
        tbAddress.MaxLength = 150
        tbAddress.Name = "tbAddress"
        tbAddress.Size = New System.Drawing.Size(442, 26)
        tbAddress.TabIndex = 5
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.BackColor = Color.Transparent
        lblAddress.Font = New Font("Baskerville Old Face", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddress.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblAddress.Location = New Point(126, 271)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New System.Drawing.Size(86, 22)
        lblAddress.TabIndex = 3
        lblAddress.Text = "Address:"
        ' 
        ' lblTask
        ' 
        lblTask.AutoSize = True
        lblTask.BackColor = Color.Transparent
        lblTask.Font = New Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTask.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblTask.Location = New Point(629, 149)
        lblTask.Name = "lblTask"
        lblTask.Size = New System.Drawing.Size(85, 27)
        lblTask.TabIndex = 7
        lblTask.Text = "Orders"
        ' 
        ' btnAddTask
        ' 
        btnAddTask.BackColor = Color.White
        btnAddTask.FlatStyle = FlatStyle.Flat
        btnAddTask.ForeColor = Color.Black
        btnAddTask.Location = New Point(731, 144)
        btnAddTask.Name = "btnAddTask"
        btnAddTask.Size = New System.Drawing.Size(75, 34)
        btnAddTask.TabIndex = 9
        btnAddTask.Text = "Add "
        btnAddTask.TextAlign = ContentAlignment.MiddleLeft
        btnAddTask.UseVisualStyleBackColor = False
        ' 
        ' btnRemoveTask
        ' 
        btnRemoveTask.BackColor = Color.White
        btnRemoveTask.BackgroundImageLayout = ImageLayout.None
        btnRemoveTask.FlatStyle = FlatStyle.Flat
        btnRemoveTask.ForeColor = Color.Black
        btnRemoveTask.Location = New Point(812, 144)
        btnRemoveTask.Name = "btnRemoveTask"
        btnRemoveTask.Size = New System.Drawing.Size(96, 34)
        btnRemoveTask.TabIndex = 11
        btnRemoveTask.Text = "Remove "
        btnRemoveTask.TextAlign = ContentAlignment.MiddleLeft
        btnRemoveTask.UseVisualStyleBackColor = False
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
        ' AddClientForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        ClientSize = New System.Drawing.Size(1283, 691)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(pnLogout)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Name = "AddClientForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Client"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        pnNavigation.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(pbTailoringJacinto, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        pnLogout.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblCustomerDetails As Label
    Friend WithEvents lblTask As Label
    Friend WithEvents btnAddTask As Button
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
    Friend WithEvents pnNavigation As Panel
    Friend WithEvents pbTailoringJacinto As PictureBox
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
