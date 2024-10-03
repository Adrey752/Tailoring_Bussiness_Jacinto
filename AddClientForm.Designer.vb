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
        lblAddOrderTitle = New Label()
        btnSave = New Button()
        Panel1 = New Panel()
        btnRemoveTask = New Button()
        fpTask = New FlowLayoutPanel()
        btnAddTask = New Button()
        lblTask = New Label()
        tbNumber = New TextBox()
        tbAddress = New TextBox()
        tbName = New TextBox()
        lblAddress = New Label()
        lblContactNumber = New Label()
        LblName = New Label()
        lblCustomerDetails = New Label()
        btnCancel = New Button()
        PictureBoxLogo = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblAddOrderTitle
        ' 
        lblAddOrderTitle.AutoSize = True
        lblAddOrderTitle.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAddOrderTitle.ForeColor = SystemColors.ButtonFace
        lblAddOrderTitle.Location = New Point(31, 142)
        lblAddOrderTitle.Name = "lblAddOrderTitle"
        lblAddOrderTitle.Size = New Size(174, 40)
        lblAddOrderTitle.TabIndex = 0
        lblAddOrderTitle.Text = "Add Orders"
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.SaddleBrown
        btnSave.FlatAppearance.BorderSize = 0
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(741, 158)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(91, 37)
        btnSave.TabIndex = 1
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        Panel1.Controls.Add(btnRemoveTask)
        Panel1.Controls.Add(fpTask)
        Panel1.Controls.Add(btnAddTask)
        Panel1.Controls.Add(lblTask)
        Panel1.Controls.Add(tbNumber)
        Panel1.Controls.Add(tbAddress)
        Panel1.Controls.Add(tbName)
        Panel1.Controls.Add(lblAddress)
        Panel1.Controls.Add(lblContactNumber)
        Panel1.Controls.Add(LblName)
        Panel1.Controls.Add(lblCustomerDetails)
        Panel1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Panel1.Location = New Point(69, 205)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(853, 404)
        Panel1.TabIndex = 2
        ' 
        ' btnRemoveTask
        ' 
        btnRemoveTask.BackColor = Color.White
        btnRemoveTask.Location = New Point(523, 339)
        btnRemoveTask.Name = "btnRemoveTask"
        btnRemoveTask.Size = New Size(143, 46)
        btnRemoveTask.TabIndex = 11
        btnRemoveTask.Text = "Remove Task"
        btnRemoveTask.UseVisualStyleBackColor = False
        ' 
        ' fpTask
        ' 
        fpTask.AutoScroll = True
        fpTask.BackColor = Color.White
        fpTask.FlowDirection = FlowDirection.TopDown
        fpTask.Location = New Point(41, 218)
        fpTask.Name = "fpTask"
        fpTask.Size = New Size(775, 106)
        fpTask.TabIndex = 10
        fpTask.WrapContents = False
        ' 
        ' btnAddTask
        ' 
        btnAddTask.BackColor = Color.White
        btnAddTask.Location = New Point(672, 339)
        btnAddTask.Name = "btnAddTask"
        btnAddTask.Size = New Size(144, 46)
        btnAddTask.TabIndex = 9
        btnAddTask.Text = "Add Task"
        btnAddTask.UseVisualStyleBackColor = False
        ' 
        ' lblTask
        ' 
        lblTask.AutoSize = True
        lblTask.BackColor = Color.Transparent
        lblTask.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTask.Location = New Point(33, 174)
        lblTask.Name = "lblTask"
        lblTask.Size = New Size(74, 32)
        lblTask.TabIndex = 7
        lblTask.Text = "Tasks"
        ' 
        ' tbNumber
        ' 
        tbNumber.BackColor = Color.White
        tbNumber.Location = New Point(523, 86)
        tbNumber.MaxLength = 11
        tbNumber.Name = "tbNumber"
        tbNumber.PlaceholderText = "Enter Text"
        tbNumber.Size = New Size(283, 23)
        tbNumber.TabIndex = 6
        ' 
        ' tbAddress
        ' 
        tbAddress.BackColor = Color.White
        tbAddress.Location = New Point(156, 133)
        tbAddress.MaxLength = 150
        tbAddress.Name = "tbAddress"
        tbAddress.PlaceholderText = "Enter Address"
        tbAddress.Size = New Size(172, 23)
        tbAddress.TabIndex = 5
        ' 
        ' tbName
        ' 
        tbName.BackColor = Color.White
        tbName.Location = New Point(156, 86)
        tbName.MaxLength = 150
        tbName.Name = "tbName"
        tbName.PlaceholderText = "Enter Client Name"
        tbName.Size = New Size(172, 23)
        tbName.TabIndex = 4
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.BackColor = Color.Transparent
        lblAddress.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblAddress.Location = New Point(41, 128)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(88, 25)
        lblAddress.TabIndex = 3
        lblAddress.Text = "Address:"
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.BackColor = Color.Transparent
        lblContactNumber.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        lblContactNumber.Location = New Point(356, 86)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New Size(171, 25)
        lblContactNumber.TabIndex = 2
        lblContactNumber.Text = "Contact Number: "
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.BackColor = Color.Transparent
        LblName.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        LblName.Location = New Point(41, 84)
        LblName.Name = "LblName"
        LblName.Size = New Size(74, 25)
        LblName.TabIndex = 1
        LblName.Text = "Name: "
        ' 
        ' lblCustomerDetails
        ' 
        lblCustomerDetails.AutoSize = True
        lblCustomerDetails.BackColor = Color.Transparent
        lblCustomerDetails.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCustomerDetails.Location = New Point(21, 23)
        lblCustomerDetails.Name = "lblCustomerDetails"
        lblCustomerDetails.Size = New Size(216, 32)
        lblCustomerDetails.TabIndex = 0
        lblCustomerDetails.Text = " Customer Details"
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = SystemColors.GradientActiveCaption
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnCancel.ForeColor = Color.White
        btnCancel.Location = New Point(837, 158)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(91, 37)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' PictureBoxLogo
        ' 
        PictureBoxLogo.Image = CType(resources.GetObject("PictureBoxLogo.Image"), Image)
        PictureBoxLogo.Location = New Point(425, 28)
        PictureBoxLogo.Name = "PictureBoxLogo"
        PictureBoxLogo.Size = New Size(160, 111)
        PictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBoxLogo.TabIndex = 3
        PictureBoxLogo.TabStop = False
        ' 
        ' AddClientForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(9), CByte(11), CByte(23))
        ClientSize = New Size(984, 661)
        Controls.Add(btnCancel)
        Controls.Add(PictureBoxLogo)
        Controls.Add(lblAddOrderTitle)
        Controls.Add(Panel1)
        Controls.Add(btnSave)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Name = "AddClientForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Client"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAddOrderTitle As Label
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
    Friend WithEvents fpTask As FlowLayoutPanel
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents btnRemoveTask As Button
End Class
