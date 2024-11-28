Imports System.Runtime.CompilerServices

Public Class Settings
    Dim _back_form As Form
    Dim _login As login
    Dim _home As Home
    Public Sub New(back_form As Form, login As login, home As Home)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        If TryCast(back_form, AddOrder) IsNot Nothing Then
            Me._back_form = TryCast(back_form, AddOrder)
        ElseIf TryCast(back_form, AddNewOrder) IsNot Nothing Then
            Me._back_form = TryCast(back_form, AddNewOrder)
        ElseIf TryCast(back_form, AddClientForm) IsNot Nothing Then
            Me._back_form = TryCast(back_form, AddClientForm)
        ElseIf TryCast(back_form, ProjectDetailsForm) IsNot Nothing Then
            Me._back_form = TryCast(back_form, ProjectDetailsForm)
        ElseIf TryCast(back_form, Home) IsNot Nothing Then
            Me._back_form = TryCast(back_form, Home)
        End If
        Me._home = home
        Me._login = login

    End Sub


    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGarmentTypesToDatagrid()
        LoadSizes()

    End Sub

    Private Sub LoadGarmentTypesToDatagrid()
        Dim query = "SELECT * FROM garment_types"
        Dim parameter As New Dictionary(Of String, Object)

        Dim resultable = MySQLModule.ExecuteQuery(query, parameter)

        For Each row As DataRow In resultable.Rows
            Dim id = row.Field(Of Integer)("garment_id")
            Dim garment = row.Field(Of String)("garment_type")

            Dim rowIndex = dgGarmentTypes.Rows.Add(garment)
            dgGarmentTypes.Rows(rowIndex).Tag = id
        Next
    End Sub

    Private Sub dgGarmentTypes_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgGarmentTypes.CellValueChanged
        If e.RowIndex >= 0 Then
            Dim editedCell = dgGarmentTypes.Rows(e.RowIndex).Cells(e.ColumnIndex)
            Dim garment As String = editedCell.Value.ToString()
            Dim index = dgGarmentTypes.Rows(e.RowIndex).Tag
            If index IsNot Nothing Then
                editGarmentToDB(garment, index)

            Else
                insertGarmentToDB(garment)
            End If
        End If
    End Sub


    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click

        Me.Close()
        _back_form.Show()
    End Sub



    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If _back_form IsNot Nothing Then
            _back_form.Show()
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()

        If TypeOf _back_form IsNot Home Then
            _back_form.Close()
        End If
        _home.Show()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If TypeOf _back_form IsNot Home Then
            _back_form.Close()
        End If
        Me.Hide()
        _login.Show()


    End Sub





    Private Sub insertGarmentToDB(garment As String)
        Dim query = "INSERT INTO garment_types (garment_type) VALUES (@garment)"
        Dim parameter As New Dictionary(Of String, Object) From {
                {"@garment", garment}
           }
        MySQLModule.ExecuteNonQuery(query, parameter)
    End Sub


    Private Sub editGarmentToDB(garment As String, id As Integer)

        Dim query = "UPDATE garment_types SET garment_type = @garment WHERE garment_id = @id"
        Dim parameter As New Dictionary(Of String, Object) From {
            {"@garment", garment},
            {"@id", id}
        }
        MySQLModule.ExecuteNonQuery(query, parameter)

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        If dgGarmentTypes.SelectedRows.Count > 0 Then
            For Each row As DataGridViewRow In dgGarmentTypes.SelectedRows
                Dim index = row.Tag
                dgGarmentTypes.Rows.Remove(row)
                deletGarmentToDB(index)


            Next
        End If
    End Sub

    Private Sub deletGarmentToDB(id As Integer)
        Dim query = "DELETE FROM garment_types WHERE garment_id = @id"
        Dim parameter As New Dictionary(Of String, Object) From {
            {"@id", id}
        }
        MySQLModule.ExecuteNonQuery(query, parameter)
    End Sub

    Private Sub LoadSizes()
        Dim query = "SELECT * FROM clothing_size"
        Dim parameter As New Dictionary(Of String, Object)

        Dim resultTable = MySQLModule.ExecuteQuery(query, parameter)

        For Each row As DataRow In resultTable.Rows
            Dim id = row.Field(Of Integer)("clothing_id")
            Dim sizename = row.Field(Of String)("name")

            Dim rowindex = dgSizes.Rows.Add(sizename)
            dgSizes.Rows(rowindex).Tag = id

        Next


    End Sub


    Private Sub dgSizes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSizes.CellClick
        Dim rowindex = dgSizes.Rows(e.RowIndex).Tag
        LoadMeasurements(rowindex)
    End Sub

    Private Sub LoadMeasurements(id As Integer)
        Dim query = "SELECT t.types, s.size_value, s.size_unit, g.garment_id FROM size_values As s WHERE clothing_id = @id INNER JOIN garment_types As g ON s.garment_id = g.garment_id INNER JOIN size_types As t ON t.type_id = s.type_id"
        Dim parameter As New Dictionary(Of String, Object) From {
            {"@id", id}
        }
        Dim resultable = MySQLModule.ExecuteQuery(query, parameter)

        For Each row As DataRow In resultable.Rows
            Dim type As String = row.Field(Of String)("type")
            Dim value As Decimal = row.Field(Of Decimal)("size_value")
            Dim unit As String = row.Field(Of String)("size_unit")
            Dim garment As String = row.Field(Of String)("garment_type")
            Dim rowIndex = dgMeasurements.Rows.Add(type, (value & unit), garment)

        Next
    End Sub


End Class