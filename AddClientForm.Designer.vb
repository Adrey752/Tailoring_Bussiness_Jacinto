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
        LblName = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblAddress = New Label()
        lblContactNumber = New Label()
        tbName = New TextBox()
        tbAddress = New TextBox()
        btnRemoveTask = New Button()
        btnAddTask = New Button()
        pnNavigation = New Panel()
        pbTailoringJacinto = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox3 = New PictureBox()
        btnForward = New Button()
        PictureBox1 = New PictureBox()
        btnSettings = New Button()
        PictureBox2 = New PictureBox()
        btnSearch = New Button()
        btnHome = New Button()
        fpTask = New FlowLayoutPanel()
        Button3 = New Button()
        Button2 = New Button()
        Panel6 = New Panel()
        PictureBox6 = New PictureBox()
        lblCustomerDetails = New Label()
        PictureBox8 = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        tbNumber = New TextBox()
        Button1 = New Button()
        pnLogout = New Panel()
        btnSetNew = New Button()
        btnLogOut = New Button()
        Panel1.SuspendLayout()
        pnNavigation.SuspendLayout()
        CType(pbTailoringJacinto, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel6.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        pnLogout.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.Transparent
        btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), Image)
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(1122, 612)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(100, 40)
        btnSave.TabIndex = 1
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        Panel1.Controls.Add(LblName)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(lblAddress)
        Panel1.Controls.Add(lblContactNumber)
        Panel1.Controls.Add(tbName)
        Panel1.Controls.Add(tbAddress)
        Panel1.Controls.Add(btnRemoveTask)
        Panel1.Controls.Add(btnAddTask)
        Panel1.Controls.Add(pnNavigation)
        Panel1.Controls.Add(btnSave)
        Panel1.Controls.Add(fpTask)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel4)
        Panel1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.ForeColor = Color.BurlyWood
        Panel1.Location = New Point(-1, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1300, 700)
        Panel1.TabIndex = 2
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.BackColor = Color.Transparent
        LblName.Font = New Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblName.ForeColor = Color.Black
        LblName.Location = New Point(120, 278)
        LblName.Name = "LblName"
        LblName.Size = New Size(61, 18)
        LblName.TabIndex = 1
        LblName.Text = "Name: "
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.None
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(620, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(111, 36)
        Label2.TabIndex = 48
        Label2.Text = "Orders"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(111, 227)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 36)
        Label1.TabIndex = 47
        Label1.Text = "Client Details"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.BackColor = Color.Transparent
        lblAddress.Font = New Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddress.ForeColor = Color.Black
        lblAddress.Location = New Point(120, 340)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(72, 18)
        lblAddress.TabIndex = 3
        lblAddress.Text = "Address:"
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.BackColor = Color.Transparent
        lblContactNumber.Font = New Font("Baskerville Old Face", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblContactNumber.ForeColor = Color.Black
        lblContactNumber.Location = New Point(120, 410)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New Size(139, 18)
        lblContactNumber.TabIndex = 2
        lblContactNumber.Text = "Contact Number: "
        ' 
        ' tbName
        ' 
        tbName.BackColor = Color.White
        tbName.BorderStyle = BorderStyle.None
        tbName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbName.ForeColor = Color.Black
        tbName.Location = New Point(133, 299)
        tbName.MaxLength = 150
        tbName.Name = "tbName"
        tbName.Size = New Size(446, 26)
        tbName.TabIndex = 4
        ' 
        ' tbAddress
        ' 
        tbAddress.BackColor = Color.White
        tbAddress.BorderStyle = BorderStyle.None
        tbAddress.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbAddress.ForeColor = Color.Black
        tbAddress.Location = New Point(130, 369)
        tbAddress.MaxLength = 150
        tbAddress.Name = "tbAddress"
        tbAddress.Size = New Size(446, 22)
        tbAddress.TabIndex = 5
        ' 
        ' btnRemoveTask
        ' 
        btnRemoveTask.BackColor = Color.White
        btnRemoveTask.BackgroundImage = CType(resources.GetObject("btnRemoveTask.BackgroundImage"), Image)
        btnRemoveTask.BackgroundImageLayout = ImageLayout.Zoom
        btnRemoveTask.Cursor = Cursors.IBeam
        btnRemoveTask.FlatStyle = FlatStyle.Flat
        btnRemoveTask.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRemoveTask.ForeColor = Color.Black
        btnRemoveTask.Location = New Point(1122, 164)
        btnRemoveTask.Name = "btnRemoveTask"
        btnRemoveTask.Size = New Size(100, 40)
        btnRemoveTask.TabIndex = 11
        btnRemoveTask.Text = "Remove "
        btnRemoveTask.UseVisualStyleBackColor = False
        ' 
        ' btnAddTask
        ' 
        btnAddTask.BackColor = Color.Transparent
        btnAddTask.BackgroundImage = CType(resources.GetObject("btnAddTask.BackgroundImage"), Image)
        btnAddTask.FlatStyle = FlatStyle.Flat
        btnAddTask.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAddTask.ForeColor = Color.White
        btnAddTask.Location = New Point(1017, 164)
        btnAddTask.Name = "btnAddTask"
        btnAddTask.Size = New Size(100, 40)
        btnAddTask.TabIndex = 9
        btnAddTask.Text = "Add "
        btnAddTask.UseVisualStyleBackColor = False
        ' 
        ' pnNavigation
        ' 
        pnNavigation.Anchor = AnchorStyles.None
        pnNavigation.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(254))
        pnNavigation.Controls.Add(pbTailoringJacinto)
        pnNavigation.Controls.Add(PictureBox7)
        pnNavigation.Controls.Add(PictureBox3)
        pnNavigation.Controls.Add(btnForward)
        pnNavigation.Controls.Add(PictureBox1)
        pnNavigation.Controls.Add(btnSettings)
        pnNavigation.Controls.Add(PictureBox2)
        pnNavigation.Controls.Add(btnSearch)
        pnNavigation.Controls.Add(btnHome)
        pnNavigation.Location = New Point(0, 0)
        pnNavigation.Name = "pnNavigation"
        pnNavigation.Size = New Size(78, 700)
        pnNavigation.TabIndex = 14
        ' 
        ' pbTailoringJacinto
        ' 
        pbTailoringJacinto.Anchor = AnchorStyles.None
        pbTailoringJacinto.Image = CType(resources.GetObject("pbTailoringJacinto.Image"), Image)
        pbTailoringJacinto.Location = New Point(16, 12)
        pbTailoringJacinto.Name = "pbTailoringJacinto"
        pbTailoringJacinto.Size = New Size(46, 56)
        pbTailoringJacinto.SizeMode = PictureBoxSizeMode.StretchImage
        pbTailoringJacinto.TabIndex = 9
        pbTailoringJacinto.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Anchor = AnchorStyles.None
        PictureBox7.BackColor = Color.Bisque
        PictureBox7.Enabled = False
        PictureBox7.Image = My.Resources.Resources.right_arrow
        PictureBox7.Location = New Point(23, 215)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(31, 30)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 23
        PictureBox7.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.BackColor = Color.BurlyWood
        PictureBox3.Enabled = False
        PictureBox3.Image = My.Resources.Resources.logout
        PictureBox3.Location = New Point(23, 266)
        PictureBox3.Margin = New Padding(0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(31, 25)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 18
        PictureBox3.TabStop = False
        ' 
        ' btnForward
        ' 
        btnForward.Anchor = AnchorStyles.None
        btnForward.BackColor = Color.Bisque
        btnForward.FlatStyle = FlatStyle.Flat
        btnForward.ForeColor = Color.BlanchedAlmond
        btnForward.Location = New Point(0, 209)
        btnForward.Margin = New Padding(0)
        btnForward.Name = "btnForward"
        btnForward.Padding = New Padding(30, 0, 0, 0)
        btnForward.Size = New Size(90, 45)
        btnForward.TabIndex = 20
        btnForward.TextAlign = ContentAlignment.MiddleLeft
        btnForward.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        PictureBox1.Enabled = False
        PictureBox1.Image = My.Resources.Resources.setting
        PictureBox1.Location = New Point(23, 175)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(31, 30)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' btnSettings
        ' 
        btnSettings.Anchor = AnchorStyles.None
        btnSettings.BackColor = Color.BurlyWood
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.ForeColor = Color.BurlyWood
        btnSettings.Location = New Point(-3, 251)
        btnSettings.Name = "btnSettings"
        btnSettings.Padding = New Padding(30, 0, 0, 0)
        btnSettings.Size = New Size(90, 45)
        btnSettings.TabIndex = 11
        btnSettings.TextAlign = ContentAlignment.MiddleLeft
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.None
        PictureBox2.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(234))
        PictureBox2.Enabled = False
        PictureBox2.Image = My.Resources.Resources.home
        PictureBox2.Location = New Point(23, 135)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(31, 29)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' btnSearch
        ' 
        btnSearch.Anchor = AnchorStyles.None
        btnSearch.BackColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.ForeColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        btnSearch.Location = New Point(-3, 167)
        btnSearch.Name = "btnSearch"
        btnSearch.Padding = New Padding(30, 0, 0, 0)
        btnSearch.Size = New Size(90, 48)
        btnSearch.TabIndex = 10
        btnSearch.TextAlign = ContentAlignment.MiddleLeft
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.Anchor = AnchorStyles.None
        btnHome.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(234))
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.ForeColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        btnHome.Location = New Point(-3, 128)
        btnHome.Name = "btnHome"
        btnHome.Padding = New Padding(30, 0, 0, 0)
        btnHome.Size = New Size(90, 48)
        btnHome.TabIndex = 9
        btnHome.TextAlign = ContentAlignment.MiddleLeft
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' fpTask
        ' 
        fpTask.AutoScroll = True
        fpTask.BackColor = Color.Transparent
        fpTask.BackgroundImage = CType(resources.GetObject("fpTask.BackgroundImage"), Image)
        fpTask.BackgroundImageLayout = ImageLayout.Stretch
        fpTask.Location = New Point(620, 209)
        fpTask.Name = "fpTask"
        fpTask.Size = New Size(602, 380)
        fpTask.TabIndex = 12
        ' 
        ' Button3
        ' 
        Button3.Anchor = AnchorStyles.None
        Button3.BackColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.ForeColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        Button3.Location = New Point(67, 75)
        Button3.Name = "Button3"
        Button3.Padding = New Padding(30, 0, 0, 0)
        Button3.Size = New Size(1228, 18)
        Button3.TabIndex = 24
        Button3.TextAlign = ContentAlignment.MiddleLeft
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Anchor = AnchorStyles.None
        Button2.BackColor = Color.FromArgb(CByte(255), CByte(248), CByte(234))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        Button2.Location = New Point(71, 59)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(30, 0, 0, 0)
        Button2.Size = New Size(1224, 18)
        Button2.TabIndex = 24
        Button2.TextAlign = ContentAlignment.MiddleLeft
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(255), CByte(254), CByte(254))
        Panel6.Controls.Add(PictureBox6)
        Panel6.Controls.Add(lblCustomerDetails)
        Panel6.Controls.Add(PictureBox8)
        Panel6.Location = New Point(68, 0)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1385, 71)
        Panel6.TabIndex = 45
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(52, 19)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(31, 36)
        PictureBox6.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox6.TabIndex = 46
        PictureBox6.TabStop = False
        ' 
        ' lblCustomerDetails
        ' 
        lblCustomerDetails.AutoSize = True
        lblCustomerDetails.BackColor = Color.Transparent
        lblCustomerDetails.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerDetails.ForeColor = Color.Black
        lblCustomerDetails.Location = New Point(100, 19)
        lblCustomerDetails.Name = "lblCustomerDetails"
        lblCustomerDetails.Size = New Size(165, 36)
        lblCustomerDetails.TabIndex = 0
        lblCustomerDetails.Text = "Add Client"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(12, 19)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(34, 35)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 46
        PictureBox8.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.Location = New Point(120, 290)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(469, 47)
        Panel2.TabIndex = 49
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Transparent
        Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), Image)
        Panel3.BackgroundImageLayout = ImageLayout.Zoom
        Panel3.Location = New Point(117, 357)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(472, 47)
        Panel3.TabIndex = 50
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.Transparent
        Panel4.BackgroundImage = CType(resources.GetObject("Panel4.BackgroundImage"), Image)
        Panel4.BackgroundImageLayout = ImageLayout.Zoom
        Panel4.Controls.Add(tbNumber)
        Panel4.Location = New Point(117, 431)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(472, 47)
        Panel4.TabIndex = 51
        ' 
        ' tbNumber
        ' 
        tbNumber.BackColor = Color.White
        tbNumber.BorderStyle = BorderStyle.None
        tbNumber.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tbNumber.Location = New Point(13, 10)
        tbNumber.MaxLength = 11
        tbNumber.Name = "tbNumber"
        tbNumber.Size = New Size(446, 26)
        tbNumber.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Button1.BackColor = Color.Transparent
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.Location = New Point(2022, 21)
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
        pnLogout.Location = New Point(1958, 63)
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
        ' AddClientForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        ClientSize = New Size(1283, 691)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(pnLogout)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Name = "AddClientForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Client"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        pnNavigation.ResumeLayout(False)
        CType(pbTailoringJacinto, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        pnLogout.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAddTask As Button
    Friend WithEvents btnRemoveTask As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents pnLogout As Panel
    Friend WithEvents btnSetNew As Button
    Friend WithEvents btnLogOut As Button
    Friend WithEvents fpTask As FlowLayoutPanel
    Friend WithEvents pnNavigation As Panel
    Friend WithEvents pbTailoringJacinto As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents lblCustomerDetails As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents btnForward As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblContactNumber As Label
    Friend WithEvents tbName As TextBox
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents tbNumber As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
