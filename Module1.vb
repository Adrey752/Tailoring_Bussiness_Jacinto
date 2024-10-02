Imports MySql.Data.MySqlClient
Imports System.Configuration

Module MySQLModule
    ' Method to establish a connection
    Public Function GetConnection() As MySqlConnection
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MySqlConnectionString").ConnectionString
        Return New MySqlConnection(connectionString)
    End Function

    ' Method to execute a query and fill DataTable (uses DataAdapter, safe from SQL injection)
    Public Function ExecuteQuery(query As String, parameters As Dictionary(Of String, Object)) As DataTable
        Dim resultTable As New DataTable()

        Using connection As MySqlConnection = GetConnection()
            connection.Open()

            ' Using DataAdapter for disconnected approach
            Using cmd As New MySqlCommand(query, connection)
                ' Add parameters to avoid SQL injection
                For Each param As KeyValuePair(Of String, Object) In parameters
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next

                ' Fill DataTable using DataAdapter
                Using adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(resultTable)
                End Using
            End Using
        End Using

        Return resultTable
    End Function

    ' Method to execute insert, update, or delete operations (uses parameterized NonQuery)
    Public Function ExecuteNonQuery(query As String, parameters As Dictionary(Of String, Object)) As Integer
        Dim rowsAffected As Integer = 0

        Using connection As MySqlConnection = GetConnection()
            connection.Open()

            Using cmd As New MySqlCommand(query, connection)
                ' Add parameters to avoid SQL injection
                For Each param As KeyValuePair(Of String, Object) In parameters
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next

                ' Execute NonQuery for Insert/Update/Delete
                rowsAffected = cmd.ExecuteNonQuery()
            End Using
        End Using

        Return rowsAffected
    End Function

    ' Method to execute a scalar query, which returns a single value
    Public Function ExecuteScalar(query As String, parameters As Dictionary(Of String, Object)) As Object
        Dim result As Object = Nothing

        Using connection As MySqlConnection = GetConnection()
            connection.Open()

            Using cmd As New MySqlCommand(query, connection)
                ' Add parameters to avoid SQL injection
                For Each param As KeyValuePair(Of String, Object) In parameters
                    cmd.Parameters.AddWithValue(param.Key, param.Value)
                Next

                ' Execute Scalar (for single value returns)
                result = cmd.ExecuteScalar()
            End Using
        End Using

        Return result
    End Function

End Module




'Imports MySql.Data.MySqlClient
'Imports System.Configuration
'Module MySQLModule

'    Public Function GetConnection() As MySqlConnection
'        Dim connectionString As String = ConfigurationManager.ConnectionStrings("MySqlConnectionString").ConnectionString
'        Return New MySqlConnection(connectionString)
'    End Function


'    Public Function ExecuteReader(query As String, parameters As Dictionary(Of String, Object)) As DataTable
'        Dim resultTable As New DataTable()

'        Using connection As MySqlConnection = GetConnection()
'            connection.Open()

'            Using cmd As New MySqlCommand(query, connection)
'                For Each param As KeyValuePair(Of String, Object) In parameters
'                    cmd.Parameters.AddWithValue(param.Key, param.Value)
'                Next

'                Using reader As MySqlDataReader = cmd.ExecuteReader()
'                    resultTable.Load(reader)
'                End Using
'            End Using
'        End Using

'        Return resultTable
'    End Function

'    Public Function ExecuteNonQuery(query As String, parameters As Dictionary(Of String, Object)) As Integer
'        Dim rowsAffected As Integer = 0

'        Using connection As MySqlConnection = GetConnection()
'            connection.Open()

'            Using cmd As New MySqlCommand(query, connection)
'                ' Add parameters to the command
'                For Each param As KeyValuePair(Of String, Object) In parameters
'                    cmd.Parameters.AddWithValue(param.Key, param.Value)
'                Next

'                rowsAffected = cmd.ExecuteNonQuery()
'            End Using
'        End Using

'        Return rowsAffected
'    End Function

'    Public Function ExecuteScalar(query As String, parameters As Dictionary(Of String, Object)) As Object
'        Dim result As Object = Nothing

'        Using connection As MySqlConnection = GetConnection()
'            connection.Open()

'            Using cmd As New MySqlCommand(query, connection)
'                For Each param As KeyValuePair(Of String, Object) In parameters
'                    cmd.Parameters.AddWithValue(param.Key, param.Value)
'                Next

'                result = cmd.ExecuteScalar()
'            End Using
'        End Using

'        Return result
'    End Function

'End Module

