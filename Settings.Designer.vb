<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        btnOrderSave = New Button()
        btnAdd = New Button()
        pnNavigation = New Panel()
        pbTailoringJacinto = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        btnLogout = New Button()
        btnSettings = New Button()
        btnHome = New Button()
        dgMeasurements = New DataGridView()
        size_type = New DataGridViewTextBoxColumn()
        measurement = New DataGridViewTextBoxColumn()
        GarmentType = New DataGridViewTextBoxColumn()
        dgSizes = New DataGridView()
        Sizes = New DataGridViewTextBoxColumn()
        dgGarmentTypes = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        confirmShowpass = New PictureBox()
        createShowpass = New PictureBox()
        Label7 = New Label()
        tbCreatepassword = New TextBox()
        Label6 = New Label()
        tbConfirmpassword = New TextBox()
        tbAnswer2 = New TextBox()
        cbQuestion2 = New ComboBox()
        Label5 = New Label()
        tbAnswer1 = New TextBox()
        cbQuestion1 = New ComboBox()
        Label4 = New Label()
        Label3 = New Label()
        dtpBirthdate = New DateTimePicker()
        Label2 = New Label()
        tbLastname = New TextBox()
        tbMiddlename = New TextBox()
        lblorderName = New Label()
        tbFirstname = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Panel1 = New Panel()
        btnCancelEditing = New Button()
        btnSaveEditing = New Button()
        btnEdit = New Button()
        PictureBox5 = New PictureBox()
        pnNavigation.SuspendLayout()
        CType(pbTailoringJacinto, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgSizes, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgGarmentTypes, ComponentModel.ISupportInitialize).BeginInit()
        CType(confirmShowpass, ComponentModel.ISupportInitialize).BeginInit()
        CType(createShowpass, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnOrderSave
        ' 
        btnOrderSave.Anchor = AnchorStyles.None
        btnOrderSave.BackColor = Color.SeaShell
        btnOrderSave.Location = New Point(1128, 601)
        btnOrderSave.Name = "btnOrderSave"
        btnOrderSave.Size = New Size(104, 41)
        btnOrderSave.TabIndex = 11
        btnOrderSave.Text = "Save"
        btnOrderSave.UseVisualStyleBackColor = False
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.None
        btnAdd.BackColor = Color.SeaShell
        btnAdd.Location = New Point(1018, 601)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(104, 41)
        btnAdd.TabIndex = 10
        btnAdd.Text = "Add Order"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' pnNavigation
        ' 
        pnNavigation.Anchor = AnchorStyles.None
        pnNavigation.BackColor = Color.FromArgb(CByte(255), CByte(254), CByte(254))
        pnNavigation.Controls.Add(pbTailoringJacinto)
        pnNavigation.Controls.Add(PictureBox3)
        pnNavigation.Controls.Add(PictureBox1)
        pnNavigation.Controls.Add(PictureBox2)
        pnNavigation.Controls.Add(btnLogout)
        pnNavigation.Controls.Add(btnSettings)
        pnNavigation.Controls.Add(btnHome)
        pnNavigation.Location = New Point(12, 1)
        pnNavigation.Name = "pnNavigation"
        pnNavigation.Size = New Size(79, 700)
        pnNavigation.TabIndex = 29
        ' 
        ' pbTailoringJacinto
        ' 
        pbTailoringJacinto.Anchor = AnchorStyles.None
        pbTailoringJacinto.Image = CType(resources.GetObject("pbTailoringJacinto.Image"), Image)
        pbTailoringJacinto.Location = New Point(0, 0)
        pbTailoringJacinto.Name = "pbTailoringJacinto"
        pbTailoringJacinto.Size = New Size(79, 65)
        pbTailoringJacinto.SizeMode = PictureBoxSizeMode.Zoom
        pbTailoringJacinto.TabIndex = 30
        pbTailoringJacinto.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.None
        PictureBox3.Enabled = False
        PictureBox3.Image = My.Resources.Resources.logout
        PictureBox3.Location = New Point(24, 160)
        PictureBox3.Margin = New Padding(0)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(31, 29)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 18
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Enabled = False
        PictureBox1.Image = My.Resources.Resources.arrow__1_
        PictureBox1.Location = New Point(24, 120)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(31, 29)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 19
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Enabled = False
        PictureBox2.Image = My.Resources.Resources.home
        PictureBox2.Location = New Point(24, 65)
        PictureBox2.Margin = New Padding(0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(41, 38)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' btnLogout
        ' 
        btnLogout.Anchor = AnchorStyles.None
        btnLogout.BackColor = Color.BurlyWood
        btnLogout.FlatStyle = FlatStyle.Flat
        btnLogout.ForeColor = Color.BurlyWood
        btnLogout.Location = New Point(0, 155)
        btnLogout.Name = "btnLogout"
        btnLogout.Padding = New Padding(30, 0, 0, 0)
        btnLogout.Size = New Size(81, 45)
        btnLogout.TabIndex = 11
        btnLogout.TextAlign = ContentAlignment.MiddleLeft
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnSettings
        ' 
        btnSettings.Anchor = AnchorStyles.None
        btnSettings.BackColor = Color.FromArgb(CByte(217), CByte(185), CByte(155))
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.ForeColor = Color.FromArgb(CByte(217), CByte(185), CByte(155))
        btnSettings.Location = New Point(0, 109)
        btnSettings.Name = "btnSettings"
        btnSettings.Padding = New Padding(30, 0, 0, 0)
        btnSettings.Size = New Size(81, 45)
        btnSettings.TabIndex = 10
        btnSettings.TextAlign = ContentAlignment.MiddleLeft
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.Anchor = AnchorStyles.None
        btnHome.BackColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.ForeColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        btnHome.Location = New Point(-2, 65)
        btnHome.Name = "btnHome"
        btnHome.Padding = New Padding(30, 0, 0, 0)
        btnHome.Size = New Size(81, 45)
        btnHome.TabIndex = 9
        btnHome.TextAlign = ContentAlignment.MiddleLeft
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' dgMeasurements
        ' 
        dgMeasurements.Anchor = AnchorStyles.None
        dgMeasurements.BackgroundColor = Color.White
        dgMeasurements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgMeasurements.Columns.AddRange(New DataGridViewColumn() {size_type, measurement, GarmentType})
        dgMeasurements.GridColor = Color.White
        dgMeasurements.Location = New Point(747, 76)
        dgMeasurements.Name = "dgMeasurements"
        dgMeasurements.Size = New Size(466, 165)
        dgMeasurements.TabIndex = 30
        ' 
        ' size_type
        ' 
        size_type.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        size_type.HeaderText = "Measurement type"
        size_type.Name = "size_type"
        size_type.Width = 160
        ' 
        ' measurement
        ' 
        measurement.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        measurement.HeaderText = "Measurement"
        measurement.Name = "measurement"
        measurement.Width = 110
        ' 
        ' GarmentType
        ' 
        GarmentType.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        GarmentType.HeaderText = "Garment Type"
        GarmentType.Name = "GarmentType"
        GarmentType.Width = 160
        ' 
        ' dgSizes
        ' 
        dgSizes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgSizes.Columns.AddRange(New DataGridViewColumn() {Sizes})
        dgSizes.Location = New Point(520, 76)
        dgSizes.Name = "dgSizes"
        dgSizes.Size = New Size(208, 165)
        dgSizes.TabIndex = 31
        ' 
        ' Sizes
        ' 
        Sizes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Sizes.HeaderText = "Sizes"
        Sizes.Name = "Sizes"
        ' 
        ' dgGarmentTypes
        ' 
        dgGarmentTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgGarmentTypes.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1})
        dgGarmentTypes.Location = New Point(170, 91)
        dgGarmentTypes.Name = "dgGarmentTypes"
        dgGarmentTypes.Size = New Size(208, 150)
        dgGarmentTypes.TabIndex = 32
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewTextBoxColumn1.HeaderText = "Garment Types"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(415, 28)
        Label10.Name = "Label10"
        Label10.Size = New Size(58, 15)
        Label10.TabIndex = 55
        Label10.Text = "Lastname"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(269, 28)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 15)
        Label9.TabIndex = 54
        Label9.Text = "Middlename"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(158, 28)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 15)
        Label8.TabIndex = 53
        Label8.Text = "Firstname"
        ' 
        ' confirmShowpass
        ' 
        confirmShowpass.Anchor = AnchorStyles.None
        confirmShowpass.BackColor = Color.White
        confirmShowpass.BackgroundImage = My.Resources.Resources.eye
        confirmShowpass.BackgroundImageLayout = ImageLayout.None
        confirmShowpass.Image = My.Resources.Resources.eye
        confirmShowpass.Location = New Point(437, 174)
        confirmShowpass.Margin = New Padding(1)
        confirmShowpass.Name = "confirmShowpass"
        confirmShowpass.Size = New Size(23, 17)
        confirmShowpass.SizeMode = PictureBoxSizeMode.Zoom
        confirmShowpass.TabIndex = 52
        confirmShowpass.TabStop = False
        ' 
        ' createShowpass
        ' 
        createShowpass.Anchor = AnchorStyles.None
        createShowpass.BackColor = Color.White
        createShowpass.BackgroundImage = My.Resources.Resources.eye
        createShowpass.BackgroundImageLayout = ImageLayout.None
        createShowpass.Image = My.Resources.Resources.eye
        createShowpass.Location = New Point(437, 139)
        createShowpass.Margin = New Padding(1)
        createShowpass.Name = "createShowpass"
        createShowpass.Size = New Size(23, 17)
        createShowpass.SizeMode = PictureBoxSizeMode.Zoom
        createShowpass.TabIndex = 51
        createShowpass.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label7.Location = New Point(52, 135)
        Label7.Name = "Label7"
        Label7.Size = New Size(125, 21)
        Label7.TabIndex = 49
        Label7.Text = "Create Password"
        ' 
        ' tbCreatepassword
        ' 
        tbCreatepassword.Location = New Point(210, 137)
        tbCreatepassword.Name = "tbCreatepassword"
        tbCreatepassword.Size = New Size(250, 23)
        tbCreatepassword.TabIndex = 48
        tbCreatepassword.UseSystemPasswordChar = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label6.Location = New Point(52, 170)
        Label6.Name = "Label6"
        Label6.Size = New Size(137, 21)
        Label6.TabIndex = 47
        Label6.Text = "Confirm Password"
        ' 
        ' tbConfirmpassword
        ' 
        tbConfirmpassword.Location = New Point(210, 172)
        tbConfirmpassword.Name = "tbConfirmpassword"
        tbConfirmpassword.Size = New Size(250, 23)
        tbConfirmpassword.TabIndex = 46
        tbConfirmpassword.UseSystemPasswordChar = True
        ' 
        ' tbAnswer2
        ' 
        tbAnswer2.Location = New Point(371, 316)
        tbAnswer2.Name = "tbAnswer2"
        tbAnswer2.Size = New Size(118, 23)
        tbAnswer2.TabIndex = 45
        ' 
        ' cbQuestion2
        ' 
        cbQuestion2.FormattingEnabled = True
        cbQuestion2.Items.AddRange(New Object() {"What's your favorite book?", "What's your favorite movie?", "What's your favorite hobby?"})
        cbQuestion2.Location = New Point(144, 316)
        cbQuestion2.Name = "cbQuestion2"
        cbQuestion2.Size = New Size(211, 23)
        cbQuestion2.TabIndex = 44
        cbQuestion2.Text = "What's your favorite book?"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label5.Location = New Point(52, 314)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 21)
        Label5.TabIndex = 43
        Label5.Text = "Question 2"
        ' 
        ' tbAnswer1
        ' 
        tbAnswer1.Location = New Point(371, 265)
        tbAnswer1.Name = "tbAnswer1"
        tbAnswer1.Size = New Size(118, 23)
        tbAnswer1.TabIndex = 42
        ' 
        ' cbQuestion1
        ' 
        cbQuestion1.FormattingEnabled = True
        cbQuestion1.Items.AddRange(New Object() {"What's the name of your first Pet?", "What's your favorite song?", "What's your favorite Color?"})
        cbQuestion1.Location = New Point(144, 269)
        cbQuestion1.Name = "cbQuestion1"
        cbQuestion1.Size = New Size(211, 23)
        cbQuestion1.TabIndex = 41
        cbQuestion1.Text = "What's the name of your first Pet"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label4.Location = New Point(52, 267)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 21)
        Label4.TabIndex = 40
        Label4.Text = "Question 1"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label3.Location = New Point(177, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(269, 36)
        Label3.TabIndex = 39
        Label3.Text = "Security Questions"
        ' 
        ' dtpBirthdate
        ' 
        dtpBirthdate.Location = New Point(131, 86)
        dtpBirthdate.Name = "dtpBirthdate"
        dtpBirthdate.Size = New Size(200, 23)
        dtpBirthdate.TabIndex = 38
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label2.Location = New Point(52, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 21)
        Label2.TabIndex = 37
        Label2.Text = "Birthdate"
        ' 
        ' tbLastname
        ' 
        tbLastname.Location = New Point(371, 46)
        tbLastname.Name = "tbLastname"
        tbLastname.Size = New Size(118, 23)
        tbLastname.TabIndex = 36
        ' 
        ' tbMiddlename
        ' 
        tbMiddlename.Location = New Point(271, 46)
        tbMiddlename.Name = "tbMiddlename"
        tbMiddlename.Size = New Size(74, 23)
        tbMiddlename.TabIndex = 35
        ' 
        ' lblorderName
        ' 
        lblorderName.AutoSize = True
        lblorderName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblorderName.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblorderName.Location = New Point(52, 48)
        lblorderName.Name = "lblorderName"
        lblorderName.Size = New Size(52, 21)
        lblorderName.TabIndex = 34
        lblorderName.Text = "Name"
        ' 
        ' tbFirstname
        ' 
        tbFirstname.Location = New Point(130, 46)
        tbFirstname.Name = "tbFirstname"
        tbFirstname.Size = New Size(118, 23)
        tbFirstname.TabIndex = 33
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(520, 47)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 56
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(601, 47)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 57
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(btnCancelEditing)
        Panel1.Controls.Add(btnSaveEditing)
        Panel1.Controls.Add(btnEdit)
        Panel1.Controls.Add(lblorderName)
        Panel1.Controls.Add(dtpBirthdate)
        Panel1.Controls.Add(tbFirstname)
        Panel1.Controls.Add(createShowpass)
        Panel1.Controls.Add(confirmShowpass)
        Panel1.Controls.Add(Label10)
        Panel1.Controls.Add(tbMiddlename)
        Panel1.Controls.Add(Label9)
        Panel1.Controls.Add(tbLastname)
        Panel1.Controls.Add(Label8)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(cbQuestion1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(tbAnswer1)
        Panel1.Controls.Add(tbCreatepassword)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(cbQuestion2)
        Panel1.Controls.Add(tbConfirmpassword)
        Panel1.Controls.Add(tbAnswer2)
        Panel1.ForeColor = Color.Black
        Panel1.Location = New Point(109, 276)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(669, 353)
        Panel1.TabIndex = 59
        ' 
        ' btnCancelEditing
        ' 
        btnCancelEditing.Location = New Point(591, 20)
        btnCancelEditing.Name = "btnCancelEditing"
        btnCancelEditing.Size = New Size(75, 23)
        btnCancelEditing.TabIndex = 61
        btnCancelEditing.Text = "Cancel"
        btnCancelEditing.UseVisualStyleBackColor = True
        btnCancelEditing.Visible = False
        ' 
        ' btnSaveEditing
        ' 
        btnSaveEditing.Location = New Point(510, 20)
        btnSaveEditing.Name = "btnSaveEditing"
        btnSaveEditing.Size = New Size(75, 23)
        btnSaveEditing.TabIndex = 60
        btnSaveEditing.Text = "Save"
        btnSaveEditing.UseVisualStyleBackColor = True
        btnSaveEditing.Visible = False
        ' 
        ' btnEdit
        ' 
        btnEdit.ForeColor = Color.Black
        btnEdit.Location = New Point(580, 20)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(75, 23)
        btnEdit.TabIndex = 57
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.White
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(347, 60)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(31, 25)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 60
        PictureBox5.TabStop = False
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        ClientSize = New Size(1276, 654)
        Controls.Add(PictureBox5)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(dgGarmentTypes)
        Controls.Add(dgSizes)
        Controls.Add(dgMeasurements)
        Controls.Add(pnNavigation)
        Controls.Add(btnOrderSave)
        Controls.Add(btnAdd)
        Controls.Add(Panel1)
        ForeColor = Color.Black
        Name = "Settings"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddOrder"
        pnNavigation.ResumeLayout(False)
        CType(pbTailoringJacinto, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).EndInit()
        CType(dgSizes, ComponentModel.ISupportInitialize).EndInit()
        CType(dgGarmentTypes, ComponentModel.ISupportInitialize).EndInit()
        CType(confirmShowpass, ComponentModel.ISupportInitialize).EndInit()
        CType(createShowpass, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnOrderSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents pnNavigation As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents pbTailoringJacinto As PictureBox
    Friend WithEvents dgMeasurements As DataGridView
    Friend WithEvents size_type As DataGridViewTextBoxColumn
    Friend WithEvents measurement As DataGridViewTextBoxColumn
    Friend WithEvents GarmentType As DataGridViewTextBoxColumn
    Friend WithEvents dgSizes As DataGridView
    Friend WithEvents Sizes As DataGridViewTextBoxColumn
    Friend WithEvents dgGarmentTypes As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents confirmShowpass As PictureBox
    Friend WithEvents createShowpass As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbCreatepassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbConfirmpassword As TextBox
    Friend WithEvents tbAnswer2 As TextBox
    Friend WithEvents cbQuestion2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbAnswer1 As TextBox
    Friend WithEvents cbQuestion1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpBirthdate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents tbLastname As TextBox
    Friend WithEvents tbMiddlename As TextBox
    Friend WithEvents lblorderName As Label
    Friend WithEvents tbFirstname As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnCancelEditing As Button
    Friend WithEvents btnSaveEditing As Button
    Friend WithEvents PictureBox5 As PictureBox
End Class
