Imports Mysqlx.XDevAPI

Public Class AddNewOrder
    Dim client_id As Integer
    Dim order As Order
    Public Sub New(client_id As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.client_id = client_id
        Me.order = New Order(1, "", "", "", 1, False, New List(Of Size), "Pending")

    End Sub
    Private Sub AddNewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMeasurementsType()
        LoadGarmentTypes()
    End Sub

    Private Sub btnOrderSave_Click(sender As Object, e As EventArgs) Handles btnOrderSave.Click

    End Sub
    Public Function InsertOrder(order As Order, clientId As Integer) As Integer
        Dim orderQuery As String = "INSERT INTO client_order (client_id, order_name, type, description, price, done) VALUES (@ClientId, @OrderName, @Type, @Description, @Price, @Done); SELECT LAST_INSERT_ID();"
        Dim orderParams As New Dictionary(Of String, Object) From {
    {"@ClientId", clientId},
    {"@OrderName", order.OrderName},
    {"@Type", order.Type},
    {"@Description", order.Description},
    {"@Price", order.Price},
    {"@Done", order.Done}
}

        ' Return the newly inserted order_id
        Return Convert.ToInt32(MySQLModule.ExecuteScalar(orderQuery, orderParams))
    End Function
    Public Sub InsertSize(size As Size, orderId As Integer)
        Dim sizeQuery As String = "INSERT INTO size_values (order_id, type_id, size_value, size_unit, garment_id) VALUES (@OrderId, @TypeId, @SizeValue, @SizeUnit, @garment_id)"
        Dim sizeParams As New Dictionary(Of String, Object) From {
        {"@OrderId", orderId},
        {"@TypeId", GetTypeId(size.BodyPart)}, ' Get type_id for the measurement type
        {"@garment_id", GetGarmentId(size.garment)},
        {"@SizeValue", size.Value},
        {"@SizeUnit", size.Unit}
    }

        MySQLModule.ExecuteNonQuery(sizeQuery, sizeParams)
    End Sub
    Public Shared Function GetTypeId(partMeasurement As String) As Integer
        Dim query As String = "SELECT type_id FROM size_types WHERE types = @PartMeasurement"
        Dim parameters As New Dictionary(Of String, Object) From {{"@PartMeasurement", partMeasurement}}
        Dim result As Object = MySQLModule.ExecuteScalar(query, parameters)
        If result IsNot Nothing Then
            Return Convert.ToInt64(result)
        Else
            Throw New Exception("Invalid measurement type: " & partMeasurement)
        End If
    End Function
    Private Sub LoadMeasurementsType()
        Dim query = "SELECT types FROM size_types"
        Dim dataTable = MySQLModule.ExecuteQuery(query, New Dictionary(Of String, Object))

        For Each row As DataRow In dataTable.Rows
            sbMType.Items.Add(row("types").ToString())
        Next
    End Sub

    Private Sub LoadGarmentTypes()
        Dim query As String = "SELECT garment_type FROM garment_types"
        Dim parameter As New Dictionary(Of String, Object)
        Dim datatable As DataTable = MySQLModule.ExecuteQuery(query, parameter)

        For Each row As DataRow In datatable.Rows
            cbGarment.Items.Add(row("garment_type").ToString())
        Next

    End Sub

    Private Sub addMeasurement_Click(sender As Object, e As EventArgs) Handles btnaddMeasurement.Click
        Dim measurementType = sbMType.Text
        Dim value = nudValue.Value
        Dim unit = cbUnit.Text
        Dim garment = cbGarment.Text
        Dim measurement = New Size(measurementType, value, unit, garment)

        order.AddSize(measurement)

        dgMeasurements.Rows.Add(measurementType, (value & unit), garment)
    End Sub
    Public Shared Function GetGarmentId(garment As String)
        Dim query As String = "SELECT garment_id FROM garment_types WHERE garment_type = @garment_type"
        Dim parament As New Dictionary(Of String, Object) From {
        {"garment_type", garment}
        }
        Dim result As Object = MySQLModule.ExecuteScalar(query, parament)

        If result IsNot Nothing Then
            Return Convert.ToInt64(result)
        Else
            Throw New Exception("Invalid garment Type" & garment)
        End If
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub
End Class