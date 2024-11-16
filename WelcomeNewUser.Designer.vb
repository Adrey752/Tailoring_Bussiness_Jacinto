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
        TextBox1 = New TextBox()
        Label1 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label3 = New Label()
        lblorderName = New Label()
        Label4 = New Label()
        ComboBox1 = New ComboBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        ComboBox2 = New ComboBox()
        Label5 = New Label()
        Label6 = New Label()
        TextBox6 = New TextBox()
        Label7 = New Label()
        TextBox7 = New TextBox()
        SuspendLayout()
        ' 
        ' lblCustomerDetails
        ' 
        lblCustomerDetails.AutoSize = True
        lblCustomerDetails.BackColor = Color.Transparent
        lblCustomerDetails.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerDetails.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblCustomerDetails.Location = New Point(246, 41)
        lblCustomerDetails.Name = "lblCustomerDetails"
        lblCustomerDetails.Size = New System.Drawing.Size(300, 36)
        lblCustomerDetails.TabIndex = 1
        lblCustomerDetails.Text = "Welcome New User!"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(111, 139)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New System.Drawing.Size(118, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(323, 92)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(147, 15)
        Label1.TabIndex = 3
        Label1.Text = "Please Input the following!"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(235, 139)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New System.Drawing.Size(74, 23)
        TextBox2.TabIndex = 7
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(323, 139)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New System.Drawing.Size(118, 23)
        TextBox3.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label2.Location = New Point(33, 179)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(73, 21)
        Label2.TabIndex = 9
        Label2.Text = "Birthdate"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(112, 179)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New System.Drawing.Size(200, 23)
        DateTimePicker1.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Baskerville Old Face", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label3.Location = New Point(158, 305)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(269, 36)
        Label3.TabIndex = 11
        Label3.Text = "Security Questions"
        ' 
        ' lblorderName
        ' 
        lblorderName.AutoSize = True
        lblorderName.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblorderName.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        lblorderName.Location = New Point(33, 141)
        lblorderName.Name = "lblorderName"
        lblorderName.Size = New System.Drawing.Size(52, 21)
        lblorderName.TabIndex = 6
        lblorderName.Text = "Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label4.Location = New Point(33, 360)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(86, 21)
        Label4.TabIndex = 12
        Label4.Text = "Question 1"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"What's the name of your first Pet"})
        ComboBox1.Location = New Point(125, 362)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New System.Drawing.Size(211, 23)
        ComboBox1.TabIndex = 13
        ComboBox1.Text = "What's the name of your first Pet"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(415, 362)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New System.Drawing.Size(118, 23)
        TextBox4.TabIndex = 14
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(352, 409)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New System.Drawing.Size(118, 23)
        TextBox5.TabIndex = 17
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(125, 409)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New System.Drawing.Size(187, 23)
        ComboBox2.TabIndex = 16
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label5.Location = New Point(33, 407)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(86, 21)
        Label5.TabIndex = 15
        Label5.Text = "Question 1"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label6.Location = New Point(33, 263)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(137, 21)
        Label6.TabIndex = 19
        Label6.Text = "Confirm Password"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(191, 265)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New System.Drawing.Size(250, 23)
        TextBox6.TabIndex = 18
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        Label7.Location = New Point(33, 228)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(125, 21)
        Label7.TabIndex = 21
        Label7.Text = "Create Password"
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(191, 230)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New System.Drawing.Size(250, 23)
        TextBox7.TabIndex = 20
        ' 
        ' WelcomeNewUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(800, 450)
        Controls.Add(Label7)
        Controls.Add(TextBox7)
        Controls.Add(Label6)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(ComboBox2)
        Controls.Add(Label5)
        Controls.Add(TextBox4)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(lblorderName)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(lblCustomerDetails)
        Name = "WelcomeNewUser"
        Text = "Birthdate"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCustomerDetails As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents lblorderName As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
End Class
