<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OrderDisplay
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
        Label1 = New Label()
        TextBox1 = New TextBox()
        btnSave = New Button()
        btnEdit = New Button()
        btnClose = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ComboBox1 = New ComboBox()
        Label6 = New Label()
        RichTextBox1 = New RichTextBox()
        DataGridView1 = New DataGridView()
        colBodyPart = New DataGridViewTextBoxColumn()
        colMeasurement = New DataGridViewTextBoxColumn()
        colGarment = New DataGridViewTextBoxColumn()
        NumericUpDown1 = New NumericUpDown()
        lblMeasurements = New Label()
        PictureBox1 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(21, 43)
        Label1.Name = "Label1"
        Label1.Size = New Drawing.Size(104, 21)
        Label1.TabIndex = 0
        Label1.Text = "Order Name: "
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(131, 45)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Drawing.Size(165, 23)
        TextBox1.TabIndex = 1
        ' 
        ' btnSave
        ' 
        btnSave.Enabled = False
        btnSave.Location = New Point(533, 21)
        btnSave.Name = "btnSave"
        btnSave.Size = New Drawing.Size(75, 23)
        btnSave.TabIndex = 2
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.Location = New Point(614, 21)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Drawing.Size(75, 23)
        btnEdit.TabIndex = 3
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnClose
        ' 
        btnClose.Location = New Point(696, 21)
        btnClose.Name = "btnClose"
        btnClose.Size = New Drawing.Size(75, 23)
        btnClose.TabIndex = 4
        btnClose.Text = "Close"
        btnClose.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(21, 97)
        Label2.Name = "Label2"
        Label2.Size = New Drawing.Size(98, 21)
        Label2.TabIndex = 5
        Label2.Text = "Order Type:  "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(21, 144)
        Label3.Name = "Label3"
        Label3.Size = New Drawing.Size(44, 21)
        Label3.TabIndex = 6
        Label3.Text = "Price"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(21, 193)
        Label4.Name = "Label4"
        Label4.Size = New Drawing.Size(59, 21)
        Label4.TabIndex = 7
        Label4.Text = "Status: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(131, 193)
        Label5.Name = "Label5"
        Label5.Size = New Drawing.Size(47, 21)
        Label5.TabIndex = 8
        Label5.Text = "Done"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Enabled = False
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(131, 99)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Drawing.Size(165, 23)
        ComboBox1.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(12, 242)
        Label6.Name = "Label6"
        Label6.Size = New Drawing.Size(92, 21)
        Label6.TabIndex = 10
        Label6.Text = "Description:"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Enabled = False
        RichTextBox1.Location = New Point(73, 297)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Drawing.Size(264, 124)
        RichTextBox1.TabIndex = 11
        RichTextBox1.Text = ""
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {colBodyPart, colMeasurement, colGarment})
        DataGridView1.Location = New Point(443, 297)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Drawing.Size(328, 124)
        DataGridView1.TabIndex = 12
        ' 
        ' colBodyPart
        ' 
        colBodyPart.HeaderText = "Body Part"
        colBodyPart.Name = "colBodyPart"
        ' 
        ' colMeasurement
        ' 
        colMeasurement.HeaderText = "Measurement"
        colMeasurement.Name = "colMeasurement"
        ' 
        ' colGarment
        ' 
        colGarment.HeaderText = "Garment"
        colGarment.Name = "colGarment"
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Enabled = False
        NumericUpDown1.Location = New Point(131, 147)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Drawing.Size(120, 23)
        NumericUpDown1.TabIndex = 13
        ' 
        ' lblMeasurements
        ' 
        lblMeasurements.AutoSize = True
        lblMeasurements.Location = New Point(443, 260)
        lblMeasurements.Name = "lblMeasurements"
        lblMeasurements.Size = New Drawing.Size(85, 15)
        lblMeasurements.TabIndex = 14
        lblMeasurements.Text = "Measurements"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(498, 66)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Drawing.Size(273, 171)
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' OrderDisplay
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Drawing.Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(lblMeasurements)
        Controls.Add(NumericUpDown1)
        Controls.Add(DataGridView1)
        Controls.Add(RichTextBox1)
        Controls.Add(Label6)
        Controls.Add(ComboBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnClose)
        Controls.Add(btnEdit)
        Controls.Add(btnSave)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "OrderDisplay"
        StartPosition = FormStartPosition.CenterScreen
        Text = "OrderDisplay"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colBodyPart As DataGridViewTextBoxColumn
    Friend WithEvents colMeasurement As DataGridViewTextBoxColumn
    Friend WithEvents colGarment As DataGridViewTextBoxColumn
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents lblMeasurements As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
