﻿Imports Mysqlx.XDevAPI

Public Class AddOrder
    Dim client As Client
    Dim order As Order
    Dim _orderForm As AddClientForm

    Public Sub New(client As Client, orderForm As AddClientForm)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.client = client
        Me.order = New Order("", "", "", "", 0)
        Me._orderForm = orderForm
        LoadMeasurementsType()

    End Sub

    Private Sub AddOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'lblAddMoreOrders.ForeColor = Color.FromArgb(163, 120, 81)
        'Me.BackColor = Color.FromArgb(9, 11, 23)
    End Sub


    Private Sub LoadMeasurementsType()
        Dim query = "SELECT types FROM size_types"
        Dim dataTable = MySQLModule.ExecuteQuery(query, New Dictionary(Of String, Object))

        For Each row As DataRow In dataTable.Rows
            sbMType.Items.Add(row("types").ToString())
        Next
    End Sub



    Private Sub btnOrderSave_Click(sender As Object, e As EventArgs) Handles btnOrderSave.Click
        Dim orderName = tbOrderName.Text
        Dim serviceType = cbStype.Text
        Dim description = rbDescription.Text
        Dim price = nudPrice.Value
        Dim garmentType = cbGarment.Text
        order.OrderName = orderName
        order.Type = serviceType
        order.Description = description
        order.Price = price
        order.GarmentType = garmentType
        client.addOrder(order)

        _orderForm.AddProjectPanel(orderName, order.Type, order.GarmentType, order.Description, order)
        Me.Close()

    End Sub

    Private Sub addMeasurement_Click(sender As Object, e As EventArgs) Handles btnaddMeasurement.Click
        Dim measurementType = sbMType.Text
        Dim value = nudValue.Value
        Dim unit = cbUnit.Text
        Dim garment = cbGarment.Text
        Dim measurement = New DressMeasurement(measurementType, value, unit, garment)

        order.AddSize(measurement)

        dgMeasurements.Rows.Add(measurementType, (value & unit), garment)
    End Sub


End Class