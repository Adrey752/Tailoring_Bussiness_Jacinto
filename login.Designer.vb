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
        PictureBox1 = New PictureBox()
        PbshowPassword = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        Panel2 = New Panel()
        btnHome = New Button()
        btnSearch = New Button()
        btnSettings = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PbshowPassword, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' tbPassword
        ' 
        tbPassword.Anchor = AnchorStyles.None
        tbPassword.BackColor = Color.FromArgb(CByte(245), CByte(245), CByte(250))
        tbPassword.BorderStyle = BorderStyle.None
        tbPassword.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tbPassword.Location = New Point(19, 9)
        tbPassword.Margin = New Padding(0)
        tbPassword.Name = "tbPassword"
        tbPassword.Size = New Size(324, 28)
        tbPassword.TabIndex = 1
        tbPassword.UseSystemPasswordChar = True
        ' 
        ' tbEnter
        ' 
        tbEnter.Anchor = AnchorStyles.None
        tbEnter.BackColor = Color.FromArgb(CByte(184), CByte(115), CByte(51))
        tbEnter.FlatAppearance.BorderSize = 0
        tbEnter.FlatStyle = FlatStyle.Flat
        tbEnter.ForeColor = Color.White
        tbEnter.Location = New Point(131, 405)
        tbEnter.Name = "tbEnter"
        tbEnter.Size = New Size(100, 40)
        tbEnter.TabIndex = 2
        tbEnter.Text = "Log in"
        tbEnter.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.None
        PictureBox1.BackColor = Color.FromArgb(CByte(255), CByte(254), CByte(254))
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(30, 53)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(324, 233)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' PbshowPassword
        ' 
        PbshowPassword.Anchor = AnchorStyles.None
        PbshowPassword.BackColor = Color.WhiteSmoke
        PbshowPassword.BackgroundImage = My.Resources.Resources.eye
        PbshowPassword.BackgroundImageLayout = ImageLayout.None
        PbshowPassword.Image = My.Resources.Resources.eye
        PbshowPassword.Location = New Point(320, 16)
        PbshowPassword.Margin = New Padding(1)
        PbshowPassword.Name = "PbshowPassword"
        PbshowPassword.Size = New Size(23, 17)
        PbshowPassword.SizeMode = PictureBoxSizeMode.Zoom
        PbshowPassword.TabIndex = 8
        PbshowPassword.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(255), CByte(254), CByte(254))
        Label1.Location = New Point(11, 305)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 15)
        Label1.TabIndex = 9
        Label1.Text = "Enter Password:"
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.None
        Panel1.BackColor = Color.FromArgb(CByte(255), CByte(254), CByte(254))
        Panel1.Controls.Add(tbEnter)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(btnSearch)
        Panel1.Controls.Add(btnSettings)
        Panel1.Location = New Point(1, -11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(383, 503)
        Panel1.TabIndex = 10
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Transparent
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Zoom
        Panel2.Controls.Add(PbshowPassword)
        Panel2.Controls.Add(tbPassword)
        Panel2.Location = New Point(11, 323)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(358, 47)
        Panel2.TabIndex = 50
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.ForeColor = Color.FromArgb(CByte(255), CByte(240), CByte(219))
        btnHome.Location = New Point(0, 376)
        btnHome.Name = "btnHome"
        btnHome.Padding = New Padding(30, 0, 0, 0)
        btnHome.Size = New Size(382, 45)
        btnHome.TabIndex = 12
        btnHome.TextAlign = ContentAlignment.MiddleLeft
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(217), CByte(185), CByte(155))
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.ForeColor = Color.FromArgb(CByte(217), CByte(185), CByte(155))
        btnSearch.Location = New Point(0, 420)
        btnSearch.Name = "btnSearch"
        btnSearch.Padding = New Padding(30, 0, 0, 0)
        btnSearch.Size = New Size(382, 45)
        btnSearch.TabIndex = 13
        btnSearch.TextAlign = ContentAlignment.MiddleLeft
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' btnSettings
        ' 
        btnSettings.AccessibleRole = AccessibleRole.None
        btnSettings.BackColor = Color.BurlyWood
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.ForeColor = Color.BurlyWood
        btnSettings.Location = New Point(0, 459)
        btnSettings.Name = "btnSettings"
        btnSettings.Padding = New Padding(30, 0, 0, 0)
        btnSettings.Size = New Size(382, 45)
        btnSettings.TabIndex = 14
        btnSettings.TextAlign = ContentAlignment.MiddleLeft
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(226), CByte(217), CByte(185))
        BackgroundImageLayout = ImageLayout.None
        ClientSize = New Size(382, 493)
        Controls.Add(Panel1)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PbshowPassword, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents tbEnter As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PbshowPassword As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSettings As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents Panel2 As Panel

End Class
