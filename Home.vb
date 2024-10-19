Public Class Home
    Dim _login As login

    Public Sub New(login As login)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._login = login

    End Sub
    Public Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadDatabase()


        'Designs
        DataGridOrders.EnableHeadersVisualStyles = False
        DataGridOrders.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(222, 184, 135)

        With DataGridOrders.ColumnHeadersDefaultCellStyle
            .BackColor = Color.FromArgb(9, 11, 23)
            .ForeColor = Color.White
            .Font = New Font("Arial", 10, FontStyle.Bold)
            .Alignment = DataGridViewContentAlignment.MiddleCenter

        End With


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnToggle.Click
        If Not pnLogout.Visible Then
            pnLogout.Visible = True
        Else
            pnLogout.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        login.Show()
    End Sub


    Public Sub loadDatabase()
        Dim tableQuery = "SELECT client.client_id, client.name, client.address, client.contact, client.status, price, payment" &
    " FROM client"

        Dim parameter As New Dictionary(Of String, Object)()

        Dim resultTable As DataTable = ExecuteQuery(tableQuery, parameter)
        DataGridOrders.DataSource = resultTable

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnAddrOrder.Click
        Dim newClient = New Client("", "", -1, False, 0, 0, 0)
        Dim addOrder As New AddClientForm(Me, newClient)
        Me.Hide()
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
        Dim cornerRadius As Integer = 15

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

    Private Sub DataGridOrders_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridOrders.CellContentClick


        Dim clickedRow As DataGridViewRow = DataGridOrders.Rows(e.RowIndex)
        If e.ColumnIndex = DataGridOrders.Columns("btDetails").Index AndAlso e.RowIndex >= 0 AndAlso Not IsDBNull(clickedRow.Cells("client_id").Value) Then
            Dim client_id As Integer = Convert.ToInt32(clickedRow.Cells("client_id").Value)

            Dim projectDetails = New ProjectDetailsForm(client_id, Me)
            Me.Hide()
            projectDetails.Show()

        End If
    End Sub

    Private Sub DataGridOrders_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridOrders.KeyDown
        If e.KeyCode = Keys.Delete Then
            If DataGridOrders.SelectedRows.Count = 1 AndAlso IsDBNull(DataGridOrders.SelectedRows(0).Cells("client_id").Value) Then
                Exit Sub
            End If
            If DataGridOrders.SelectedRows.Count > 0 Then

                    Dim verify As DialogResult = MessageBox.Show("Are you sure you want to delete this items?")
                    If verify = DialogResult.OK Then
                        For Each row As DataGridViewRow In DataGridOrders.SelectedRows
                            If IsDBNull(row.Cells("client_id").Value) Then
                                Continue For
                            End If
                        Dim id As Integer = Convert.ToInt64(row.Cells("client_id").Value)
                        DeleteClient(id)
                            DataGridOrders.Rows.Remove(row)

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
End Class