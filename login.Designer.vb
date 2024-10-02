<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        tbPassword = New TextBox()
        tbEnter = New Button()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbPassword
        ' 
        tbPassword.Anchor = AnchorStyles.None
        tbPassword.Location = New Point(418, 293)
        tbPassword.Name = "tbPassword"
        tbPassword.Size = New Size(236, 23)
        tbPassword.TabIndex = 1
        tbPassword.UseSystemPasswordChar = True
        ' 
        ' tbEnter
        ' 
        tbEnter.Anchor = AnchorStyles.None
        tbEnter.FlatAppearance.BorderSize = 0
        tbEnter.Location = New Point(454, 341)
        tbEnter.Name = "tbEnter"
        tbEnter.Size = New Size(160, 23)
        tbEnter.TabIndex = 2
        tbEnter.Text = "Enter"
        tbEnter.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(454, 210)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 15)
        Label3.TabIndex = 5
        Label3.Text = "Enter Password"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(418, 90)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(236, 169)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        ClientSize = New Size(1057, 442)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(tbEnter)
        Controls.Add(tbPassword)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbEnter As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
