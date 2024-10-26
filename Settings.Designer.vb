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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        dgMeasurements = New DataGridView()
        size_type = New DataGridViewTextBoxColumn()
        measurement = New DataGridViewTextBoxColumn()
        GarmentType = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1})
        DataGridView1.Location = New Point(34, 97)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New System.Drawing.Size(240, 289)
        DataGridView1.TabIndex = 0
        ' 
        ' Column1
        ' 
        Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Column1.HeaderText = "Custom Size"
        Column1.Name = "Column1"
        ' 
        ' dgMeasurements
        ' 
        dgMeasurements.Anchor = AnchorStyles.None
        dgMeasurements.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgMeasurements.Columns.AddRange(New DataGridViewColumn() {size_type, measurement, GarmentType})
        dgMeasurements.Location = New Point(322, 97)
        dgMeasurements.Name = "dgMeasurements"
        dgMeasurements.Size = New System.Drawing.Size(466, 295)
        dgMeasurements.TabIndex = 11
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
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New System.Drawing.Size(800, 450)
        Controls.Add(dgMeasurements)
        Controls.Add(DataGridView1)
        Name = "Settings"
        Text = "Settings"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(dgMeasurements, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents dgMeasurements As DataGridView
    Friend WithEvents size_type As DataGridViewTextBoxColumn
    Friend WithEvents measurement As DataGridViewTextBoxColumn
    Friend WithEvents GarmentType As DataGridViewTextBoxColumn
End Class
