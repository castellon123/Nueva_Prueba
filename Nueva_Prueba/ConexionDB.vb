Imports System.Data.SqlClient
Imports System.Data
Module ConexionDB
    Public dbSQLConn As SqlConnection
    Public dbSQLComm As SqlCommand
    Public dbSQLAdapter As SqlDataAdapter


    Public Sub ConectarSQL(Optional ByVal Server As String = "(local)\SQLEXPRESS", Optional ByVal DB As String = "master")
        dbSQLConn = New SqlConnection("Server=" & Server & ";Database=" & DB & ";Integrated Security=true")
        Try
            dbSQLConn.Open()
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & vbCrLf & ex.Message)
        End Try
    End Sub
    Public Sub DesconectarSQL()
        dbSQLConn.Close()
    End Sub
    Public Function ExecuteSQL(ByVal Query As String) As SqlDataAdapter
        dbSQLComm = New SqlCommand(Query, dbSQLConn)
        dbSQLAdapter = New SqlDataAdapter(dbSQLComm)
        Return dbSQLAdapter
    End Function
    Public Function consulta(ByVal sql As String) As DataTable
        Dim dtTabla As New DataTable
        Try
            dbSQLComm = New SqlClient.SqlCommand(sql, dbSQLConn)
            dbSQLComm.ExecuteNonQuery()
            dbSQLAdapter = New SqlDataAdapter(dbSQLComm)
            dbSQLAdapter.Fill(dtTabla)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return dtTabla
    End Function

End Module
