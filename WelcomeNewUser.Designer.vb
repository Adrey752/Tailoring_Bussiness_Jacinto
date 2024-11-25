<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeNewUser
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
        lblCustomerDetails = New Label()
        tbFirstname = New TextBox()
        Label1 = New Label()
        tbMiddlename = New TextBox()
        tbLastname = New TextBox()
        Label2 = New Label()
        dtpBirthdate = New DateTimePicker()
        Label3 = New Label()
        lblorderName = New Label()
        Label4 = New Label()
        cbQuestion1 = New ComboBox()
        tbAnswer1 = New TextBox()
        tbAnswer2 = New TextBox()
        cbQuestion2 = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        btnSave = New Button()
        tbConfirmpassword = New TextBox()
        tbCreatepassword = New TextBox()
        createShowpass = New PictureBox()
        confirmShowpass = New PictureBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        CType(createShowpass, ComponentModel.ISupportInitialize).BeginInit()
        CType(confirmShowpass, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblCustomerDetails
        ' 
        lblCustomerDetails.AutoSize = True
        lblCustomerDetails.BackColor = Color.Transparent
        lblCustomerDetails.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerDetails.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblCustomerDetails.Location = New Point(252, 19)
        lblCustomerDetails.Name = "lblCustomerDetails"
        lblCustomerDetails.Size = New Size(300, 36)
        lblCustomerDetails.TabIndex = 1
        lblCustomerDetails.Text = "Welcome New User!"
        ' 
        ' tbFirstname
        ' 
        tbFirstname.Location = New Point(111, 129)
        tbFirstname.Name = "tbFirstname"
        tbFirstname.Size = New Size(118, 23)
        tbFirstname.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(323, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 15)
        Label1.TabIndex = 3
        Label1.Text = "Please Input the following!"
        ' 
        ' tbMiddlename
        ' 
        tbMiddlename.Location = New Point(252, 129)
        tbMiddlename.Name = "tbMiddlename"
        tbMiddlename.Size = New Size(74, 23)
        tbMiddlename.TabIndex = 7
        ' 
        ' tbLastname
        ' 
        tbLastname.Location = New Point(352, 129)
        tbLastname.Name = "tbLastname"
        tbLastname.Size = New Size(118, 23)
        tbLastname.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label2.Location = New Point(33, 169)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 21)
        Label2.TabIndex = 9
        Label2.Text = "Birthdate"
        ' 
        ' dtpBirthdate
        ' 
        dtpBirthdate.Location = New Point(112, 169)
        dtpBirthdate.Name = "dtpBirthdate"
        dtpBirthdate.Size = New Size(200, 23)
        dtpBirthdate.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label3.Location = New Point(158, 295)
        Label3.Name = "Label3"
        Label3.Size = New Size(269, 36)
        Label3.TabIndex = 11
        Label3.Text = "Security Questions"
        ' 
        ' lblorderName
        ' 
        lblorderName.AutoSize = True
        lblorderName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblorderName.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblorderName.Location = New Point(33, 131)
        lblorderName.Name = "lblorderName"
        lblorderName.Size = New Size(52, 21)
        lblorderName.TabIndex = 6
        lblorderName.Text = "Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label4.Location = New Point(33, 350)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 21)
        Label4.TabIndex = 12
        Label4.Text = "Question 1"
        ' 
        ' cbQuestion1
        ' 
        cbQuestion1.FormattingEnabled = True
        cbQuestion1.Items.AddRange(New Object() {"What's the name of your first Pet?", "What's your favorite song?", "What's your favorite Color?"})
        cbQuestion1.Location = New Point(125, 352)
        cbQuestion1.Name = "cbQuestion1"
        cbQuestion1.Size = New Size(211, 23)
        cbQuestion1.TabIndex = 13
        cbQuestion1.Text = "What's the name of your first Pet"
        ' 
        ' tbAnswer1
        ' 
        tbAnswer1.Location = New Point(352, 348)
        tbAnswer1.Name = "tbAnswer1"
        tbAnswer1.Size = New Size(118, 23)
        tbAnswer1.TabIndex = 14
        ' 
        ' tbAnswer2
        ' 
        tbAnswer2.Location = New Point(352, 399)
        tbAnswer2.Name = "tbAnswer2"
        tbAnswer2.Size = New Size(118, 23)
        tbAnswer2.TabIndex = 17
        ' 
        ' cbQuestion2
        ' 
        cbQuestion2.FormattingEnabled = True
        cbQuestion2.Items.AddRange(New Object() {"What's your favorite book?", "What's your favorite movie?", "What's your favorite hobby?"})
        cbQuestion2.Location = New Point(125, 399)
        cbQuestion2.Name = "cbQuestion2"
        cbQuestion2.Size = New Size(211, 23)
        cbQuestion2.TabIndex = 16
        cbQuestion2.Text = "What's your favorite book?"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label5.Location = New Point(33, 397)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 21)
        Label5.TabIndex = 15
        Label5.Text = "Question 2"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label6.Location = New Point(33, 253)
        Label6.Name = "Label6"
        Label6.Size = New Size(137, 21)
        Label6.TabIndex = 19
        Label6.Text = "Confirm Password"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label7.Location = New Point(33, 218)
        Label7.Name = "Label7"
        Label7.Size = New Size(125, 21)
        Label7.TabIndex = 21
        Label7.Text = "Create Password"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(514, 399)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 23)
        btnSave.TabIndex = 22
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' tbConfirmpassword
        ' 
        tbConfirmpassword.Location = New Point(191, 255)
        tbConfirmpassword.Name = "tbConfirmpassword"
        tbConfirmpassword.Size = New Size(250, 23)
        tbConfirmpassword.TabIndex = 18
        tbConfirmpassword.UseSystemPasswordChar = True
        ' 
        ' tbCreatepassword
        ' 
        tbCreatepassword.Location = New Point(191, 220)
        tbCreatepassword.Name = "tbCreatepassword"
        tbCreatepassword.Size = New Size(250, 23)
        tbCreatepassword.TabIndex = 20
        tbCreatepassword.UseSystemPasswordChar = True
        ' 
        ' createShowpass
        ' 
        createShowpass.Anchor = AnchorStyles.None
        createShowpass.BackColor = Color.White
        createShowpass.BackgroundImage = My.Resources.Resources.eye
        createShowpass.BackgroundImageLayout = ImageLayout.None
        createShowpass.Image = My.Resources.Resources.eye
        createShowpass.Location = New Point(418, 222)
        createShowpass.Margin = New Padding(1)
        createShowpass.Name = "createShowpass"
        createShowpass.Size = New Size(23, 17)
        createShowpass.SizeMode = PictureBoxSizeMode.Zoom
        createShowpass.TabIndex = 23
        createShowpass.TabStop = False
        ' 
        ' confirmShowpass
        ' 
        confirmShowpass.Anchor = AnchorStyles.None
        confirmShowpass.BackColor = Color.White
        confirmShowpass.BackgroundImage = My.Resources.Resources.eye
        confirmShowpass.BackgroundImageLayout = ImageLayout.None
        confirmShowpass.Image = My.Resources.Resources.eye
        confirmShowpass.Location = New Point(418, 257)
        confirmShowpass.Margin = New Padding(1)
        confirmShowpass.Name = "confirmShowpass"
        confirmShowpass.Size = New Size(23, 17)
        confirmShowpass.SizeMode = PictureBoxSizeMode.Zoom
        confirmShowpass.TabIndex = 24
        confirmShowpass.TabStop = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(139, 111)
        Label8.Name = "Label8"
        Label8.Size = New Size(59, 15)
        Label8.TabIndex = 25
        Label8.Text = "Firstname"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(250, 111)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 15)
        Label9.TabIndex = 26
        Label9.Text = "Middlename"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(396, 111)
        Label10.Name = "Label10"
        Label10.Size = New Size(58, 15)
        Label10.TabIndex = 27
        Label10.Text = "Lastname"
        ' 
        ' WelcomeNewUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 477)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(confirmShowpass)
        Controls.Add(createShowpass)
        Controls.Add(btnSave)
        Controls.Add(Label7)
        Controls.Add(tbCreatepassword)
        Controls.Add(Label6)
        Controls.Add(tbConfirmpassword)
        Controls.Add(tbAnswer2)
        Controls.Add(cbQuestion2)
        Controls.Add(Label5)
        Controls.Add(tbAnswer1)
        Controls.Add(cbQuestion1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(dtpBirthdate)
        Controls.Add(Label2)
        Controls.Add(tbLastname)
        Controls.Add(tbMiddlename)
        Controls.Add(lblorderName)
        Controls.Add(Label1)
        Controls.Add(tbFirstname)
        Controls.Add(lblCustomerDetails)
        Name = "WelcomeNewUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Birthdate"
        CType(createShowpass, ComponentModel.ISupportInitialize).EndInit()
        CType(confirmShowpass, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCustomerDetails As Label
    Friend WithEvents tbFirstname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMiddlename As TextBox
    Friend WithEvents tbLastname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dtpBirthdate As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents lblorderName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbQuestion1 As ComboBox
    Friend WithEvents tbAnswer1 As TextBox
    Friend WithEvents tbAnswer2 As TextBox
    Friend WithEvents cbQuestion2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents tbConfirmpassword As TextBox
    Friend WithEvents tbCreatepassword As TextBox
    Friend WithEvents createShowpass As PictureBox
    Friend WithEvents confirmShowpass As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
