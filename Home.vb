Imports System.ComponentModel

Public Class Home
    Dim _login As login

    Dim selectedSortby As ToolStripItem
    Dim selectedSortDirection As ToolStripItem

    Private ReadOnly Property AllClients As List(Of Client)
        Get
            Dim listOfClients As New List(Of Client)
            For Each row As DataGridViewRow In DataGridProjects.Rows
                listOfClients.Add(CType(row.Tag, Client))
            Next
            Return listOfClients
        End Get

    End Property

    Public Sub New(login As login)

        InitializeComponent()

        Me._login = login
        selectedSortby = nameItem
        selectedSortDirection = ascendingItem
        selectToolStripItem(selectedSortby)
        selectToolStripItem(selectedSortDirection)

        SortDataGridProjects(selectedSortby.Text, selectedSortDirection.Text)


    End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Hide()
        login.Show()
    End Sub


    Public Sub loadDatabase()
        DataGridProjects.Rows.Clear()
        Dim tableQuery = "SELECT * FROM CLIENT"

        Dim parameter As New Dictionary(Of String, Object)()

        Dim resultTable As DataTable = ExecuteQuery(tableQuery, parameter)

        For Each row As DataRow In resultTable.Rows
            Dim client_id As Integer = row.Field(Of Integer)("client_id")
            Dim name As String = row.Field(Of String)("name")
            Dim dateOrder As String = If(IsDBNull(row("date")), "00/00/00", row.Field(Of DateTime)("date").ToString())
            Dim orderStatus As String = row.Field(Of String)("order_status")
            Dim payment As Decimal = row.Field(Of Decimal)("payment")
            Dim price As Decimal = row.Field(Of Decimal)("price")
            Dim quantity As Integer = row.Field(Of Integer)("quantity")
            Dim address As String = row.Field(Of String)("address")
            Dim contact As String = row.Field(Of String)("contact")

            Dim paymentStatus As String
            If payment > 0 Then
                If payment = price Then
                    paymentStatus = "Fully Paid"

                Else
                    paymentStatus = "Partially Paid"
                End If
            Else
                paymentStatus = "No Payments Made"

            End If

            Dim rowIndex = DataGridProjects.Rows.Add("theres' a button in the first column", client_id, name, dateOrder, quantity, orderStatus, paymentStatus)

            Dim client As New Client(name, address, contact, price, payment, quantity)

            paymentStatusCellColor(paymentStatus, rowIndex)
            orderStatusCellColor(orderStatus, rowIndex)
            DataGridProjects.Rows(rowIndex).Tag = client


        Next



    End Sub

    Private Sub orderStatusCellColor(orderStatus As String, rowIndex As Integer)
        If orderStatus = "Pending" Then
            DataGridProjects.Rows(rowIndex).Cells("colOrderStatus").Style.BackColor = Color.Yellow
            DataGridProjects.Rows(rowIndex).Cells("colOrderStatus").Style.ForeColor = Color.Black
        ElseIf orderStatus = "Finished" Then
            DataGridProjects.Rows(rowIndex).Cells("colOrderStatus").Style.BackColor = Color.YellowGreen
            DataGridProjects.Rows(rowIndex).Cells("colOrderStatus").Style.ForeColor = Color.Black

        ElseIf orderStatus = "Claimed" Then
            DataGridProjects.Rows(rowIndex).Cells("colOrderStatus").Style.BackColor = Color.Green
            DataGridProjects.Rows(rowIndex).Cells("colOrderStatus").Style.ForeColor = Color.Black
        End If
    End Sub

    Private Sub paymentStatusCellColor(paymentStatus As String, rowIndex As Integer)

        If paymentStatus = "Partially Paid" Then
            DataGridProjects.Rows(rowIndex).Cells("colPayStatus").Style.BackColor = Color.Yellow
            DataGridProjects.Rows(rowIndex).Cells("colPayStatus").Style.ForeColor = Color.Black

        ElseIf paymentStatus = "Fully Paid" Then
            DataGridProjects.Rows(rowIndex).Cells("colPayStatus").Style.BackColor = Color.Green
            DataGridProjects.Rows(rowIndex).Cells("colPayStatus").Style.ForeColor = Color.Black

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAddrOrder.Click

        Dim addOrder As New AddClientForm(_login, Me)
        Hide()
        addOrder.Show()

    End Sub

    Private Sub btnAddrOrder_Paint(sender As Object, e As PaintEventArgs) Handles btnAddrOrder.Paint

        ' Enable anti-aliasing for smoother edges
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        ' Enable anti-aliasing for text rendering
        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias

        ' Set background color
        sender.BackColor = Color.FromArgb(184, 115, 51)

        ' Define corner radius for rounded edges
        Dim cornerRadius = 15

        ' Create a new GraphicsPath for rounded rectangle
        Dim path As New Drawing2D.GraphicsPath

        ' Start drawing the rounded rectangle
        path.StartFigure()

        ' Top left corner
        path.AddArc(New Rectangle(0, 0, cornerRadius, cornerRadius), 180, 90)
        path.AddLine(cornerRadius, 0, sender.Width - cornerRadius, 0)

        ' Top right corner
        path.AddArc(New Rectangle(sender.Width - cornerRadius, 0, cornerRadius, cornerRadius), -90, 90)
        path.AddLine(sender.Width, cornerRadius, sender.Width, sender.Height - cornerRadius)

        ' Bottom right corner
        path.AddArc(New Rectangle(sender.Width - cornerRadius, sender.Height - cornerRadius, cornerRadius, cornerRadius), 0, 90)
        path.AddLine(sender.Width - cornerRadius, sender.Height, cornerRadius, sender.Height)

        ' Bottom left corner
        path.AddArc(New Rectangle(0, sender.Height - cornerRadius, cornerRadius, cornerRadius), 90, 90)
        path.CloseFigure()

        ' Apply the rounded region to the sender
        sender.Region = New Region(path)
    End Sub




    Private Sub Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        _login.Close()
    End Sub

    Private Sub DataGridOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridProjects.CellContentClick


        Dim clickedRow As DataGridViewRow = DataGridProjects.Rows(e.RowIndex)
        If e.ColumnIndex = DataGridProjects.Columns("btDetails").Index AndAlso e.RowIndex >= 0 AndAlso Not IsDBNull(clickedRow.Cells("client_id").Value) Then
            Dim client_id As Integer = Convert.ToInt32(clickedRow.Cells("client_id").Value)

            Dim projectDetails = New ProjectDetailsForm(client_id, Me, _login)
            Me.Hide()
            projectDetails.Show()


        End If
    End Sub

    Private Sub DataGridOrders_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridProjects.KeyDown
        If e.KeyCode = Keys.Delete Then
            If DataGridProjects.SelectedRows.Count = 1 AndAlso IsDBNull(DataGridProjects.SelectedRows(0).Cells("client_id").Value) Then
                Exit Sub
            End If
            If DataGridProjects.SelectedRows.Count > 0 Then

                Dim verify As DialogResult = MessageBox.Show("Are you sure you want to delete this items?")
                If verify = DialogResult.OK Then
                    For Each row As DataGridViewRow In DataGridProjects.SelectedRows

                        If IsDBNull(row.Cells("client_id").Value) Then
                            MessageBox.Show("column null")
                            Continue For
                        End If
                        Dim id As Integer = Convert.ToInt64(row.Cells("client_id").Value)
                        DeleteClient(id)
                        DataGridProjects.Rows.Remove(row)

                    Next
                End If
            End If
        End If
    End Sub

    Private Sub DeleteClient(client_id As Integer)

        Dim deleteClient As String = "DELETE FROM client WHERE client_id = @client_id"
        Dim delClientParam As New Dictionary(Of String, Object) From {
        {"client_id", client_id}
        }


        Dim ListOrder As List(Of Integer) = GetOrderIds(client_id)
        If ListOrder.Count > 0 Then
            For Each orderId As Integer In ListOrder
                DeleteSizesFromDatabase(orderId)
            Next
            Dim delOrder As String = "DELETE FROM client_order WHERE client_id = @client_id"
            Dim delOrderParam As New Dictionary(Of String, Object) From {
            {"client_id", client_id}
            }
            MySQLModule.ExecuteNonQuery(delOrder, delOrderParam)
            MySQLModule.ExecuteNonQuery(deleteClient, delClientParam)

        Else
            MySQLModule.ExecuteNonQuery(deleteClient, delClientParam)
        End If

    End Sub

    Private Function GetOrderIds(client_id As Integer) As List(Of Integer)
        Dim listOfIds As New List(Of Integer)

        Dim query As String = "SELECT order_id FROM client_order WHERE client_id = @client_id"
        Dim parameter As New Dictionary(Of String, Object) From {
        {"client_id", client_id}
        }

        Dim resultTable As DataTable = MySQLModule.ExecuteQuery(query, parameter)

        If resultTable.Rows.Count > 0 Then

            For Each row As DataRow In resultTable.Rows
                Dim id As Integer = Convert.ToInt64(row(0))
                listOfIds.Add(id)
            Next
        End If

        Return listOfIds

    End Function

    Private Sub DeleteSizesFromDatabase(orderId As Integer)
        Dim query As String = "DELETE FROM size_values WHERE order_id = @order_id"
        Dim parameter As New Dictionary(Of String, Object) From {
        {"order_id", orderId}
        }
        MySQLModule.ExecuteNonQuery(query, parameter)

    End Sub



    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadDatabase()

    End Sub
    'Git Conflict Management broooooo!
    Private Sub pnSort_Click(sender As Object, e As EventArgs) Handles pnSort.Click
        cmsSorting.Show(pnSort, New Point(0, pnSort.Height))
    End Sub


    Dim sortingTypes As New List(Of String) From {"Name", "Date", "Quantity"}
    Dim sortingDirections As New List(Of String) From {"Ascending", "Decending"}

    Private Sub cmsSorting_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cmsSorting.ItemClicked


        Dim selectedItem = TryCast(e.ClickedItem, ToolStripItem)


        If sortingTypes.Contains(selectedItem.Text) Then
            unselectToolStripItem(selectedSortby)
            selectedSortby = selectedItem
            selectToolStripItem(selectedSortby)
        ElseIf sortingDirections.Contains(selectedItem.Text) Then
            unselectToolStripItem(selectedSortDirection)
            selectedSortDirection = selectedItem
            selectToolStripItem(selectedSortDirection)
        End If
        SortDataGridProjects(selectedSortby.Text, selectedSortDirection.Text)
    End Sub

    Private Sub selectToolStripItem(item As ToolStripItem)
        item.BackColor = Color.Gray
        item.ForeColor = Color.White
    End Sub

    Private Sub unselectToolStripItem(item As ToolStripItem)
        If item IsNot Nothing Then
            item.BackColor = Color.Empty
            item.ForeColor = Color.Empty
        End If
    End Sub




    Private Sub SortDataGridProjects(sortBy As String, sortDirection As String)
        Dim columnName = ""
        Dim ListSortDirection As System.ComponentModel.ListSortDirection
        Select Case sortBy
            Case Is = "Name"
                columnName = "colName"
            Case Is = "Date"
                columnName = "OrderDate"
            Case Is = "Quantity"
                columnName = "colQuantity"
        End Select

        Select Case sortDirection
            Case Is = "Ascending"
                ListSortDirection = System.ComponentModel.ListSortDirection.Ascending
            Case Is = "Decending"
                ListSortDirection = System.ComponentModel.ListSortDirection.Descending
        End Select
        Dim datagridColumn As DataGridViewColumn = DataGridProjects.Columns(columnName)
        DataGridProjects.Sort(datagridColumn, ListSortDirection)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

    End Sub

    Private Sub pbTailoringJacinto_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        _login.Show()
        Me.Hide()

    End Sub

    Private Sub tbSearch_TextChanged(sender As Object, e As EventArgs) Handles tbSearch.TextChanged

        Dim searchText = tbSearch.Text.ToLower()
        Dim suggestions = AllClients.Where(Function(c) c.Name.ToLower().Contains(searchText)).ToList()
        If suggestions.Count > 0 Then
            lbSuggestions.Visible = True
        Else
            lbSuggestions.Visible = False
        End If
        lbSuggestions.Items.Clear()
        lbSuggestions.Items.AddRange(suggestions.Select(Function(c) c.Name).ToArray)
    End Sub



    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Me.Click
        lbSuggestions.Visible = False
        DataGridProjects.ClearSelection()
    End Sub

    Private Sub lbSuggestions_SelectedValueChanged(sender As Object, e As EventArgs) Handles lbSuggestions.SelectedValueChanged
        Dim selectedResult = CStr(lbSuggestions.SelectedItem)
        SearchAndSelectRow(selectedResult)
    End Sub
    Private Sub SearchAndSelectRow(searchValue As String)
        Dim rowIndex As Integer = -1
        For Each row As DataGridViewRow In DataGridProjects.Rows
            If row.Cells("colName").Value IsNot Nothing AndAlso row.Cells("colName").Value.ToString() = searchValue Then
                rowIndex = row.Index
                Exit For
            End If
        Next

        If rowIndex <> -1 Then
            DataGridProjects.Rows(rowIndex).Selected = True
            DataGridProjects.FirstDisplayedScrollingRowIndex = rowIndex
        Else
            MessageBox.Show("Value not found.")
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        Dim setting As New Settings(Me, login, Me)

        Me.Hide()

        setting.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub
End Class