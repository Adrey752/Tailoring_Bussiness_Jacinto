﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        PbshowPassword = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PbshowPassword, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tbPassword
        ' 
        tbPassword.Anchor = AnchorStyles.None
        tbPassword.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbPassword.Location = New Point(530, 411)
        tbPassword.Margin = New Padding(0)
        tbPassword.Name = "tbPassword"
        tbPassword.Size = New System.Drawing.Size(250, 33)
        tbPassword.TabIndex = 1
        tbPassword.UseSystemPasswordChar = True
        ' 
        ' tbEnter
        ' 
        tbEnter.Anchor = AnchorStyles.None
        tbEnter.BackColor = Color.FromArgb(CByte(143), CByte(77), CByte(30))
        tbEnter.FlatAppearance.BorderSize = 0
        tbEnter.FlatStyle = FlatStyle.Flat
        tbEnter.ForeColor = Color.White
        tbEnter.Location = New Point(610, 458)
        tbEnter.Name = "tbEnter"
        tbEnter.Size = New System.Drawing.Size(108, 38)
        tbEnter.TabIndex = 2
        tbEnter.Text = "Enter"
        tbEnter.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.None
        Label3.AutoSize = True
        Label3.Location = New Point(569, 307)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(87, 15)
        Label3.TabIndex = 5
        Label3.Text = "Enter Password"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(494, 159)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New System.Drawing.Size(324, 233)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' PbshowPassword
        ' 
        PbshowPassword.Anchor = AnchorStyles.None
        PbshowPassword.BackColor = Color.Transparent
        PbshowPassword.Image = My.Resources.Resources.eye
        PbshowPassword.Location = New Point(781, 411)
        PbshowPassword.Margin = New Padding(1)
        PbshowPassword.Name = "PbshowPassword"
        PbshowPassword.Size = New System.Drawing.Size(33, 33)
        PbshowPassword.SizeMode = PictureBoxSizeMode.StretchImage
        PbshowPassword.TabIndex = 8
        PbshowPassword.TabStop = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        ClientSize = New System.Drawing.Size(1287, 636)
        Controls.Add(PbshowPassword)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(tbEnter)
        Controls.Add(tbPassword)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PbshowPassword, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbEnter As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PbshowPassword As PictureBox

End Class
