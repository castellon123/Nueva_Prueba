Imports System.Data.SqlClient
Imports System.Data
Module ConectDB
    Public dbSQLConn As SqlConnection
    Public dbSQLComm As SqlCommand
    Public dbSQLAdapter As SqlDataAdapter
    Public Sub ConectarSQL(Optional ByVal Server As String = "(local)\SQLEXPRESS", Optional ByVal DB As String = "MyBase")
        dbSQLConn = New SqlConnection("Server=" & Server & ";Database=" & DB & ";Integrated Security=true")
        'Server=(local)\SQLEXPRESS;Database=MyBase;Integrated Security=true
        Try
            'If dbSQLConn.Open() Then
            dbSQLConn.Open()
            'MsgBox("Conexion con exito", MsgBoxStyle.Information)
            'End If
        Catch ex As Exception
            MessageBox.Show("Error al conectar: " & vbCrLf & ex.Message)
        End Try
    End Sub
    Public Sub CloseSql()
        Try
            dbSQLConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error al desconectar: " & vbCrLf & ex.Message)
        End Try

    End Sub
    Public Function consulta(ByVal sql As String) As DataTable
        Dim dtTabla As New DataTable
        Try
            dbSQLComm = New SqlClient.SqlCommand(sql, dbSQLConn)
            dbSQLComm.ExecuteNonQuery()
            dbSQLAdapter = New SqlDataAdapter(dbSQLComm)
            dbSQLAdapter.Fill(dtTabla)
        Catch ex As Exception
            MsgBox("Error en la consulta: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        Return dtTabla
    End Function
    Public Function InsertSQL(ByVal sql As String) As Boolean
        Dim accion As Boolean
        Try
            ConectarSQL()
            dbSQLComm = New SqlClient.SqlCommand(sql, dbSQLConn)
            dbSQLComm.ExecuteNonQuery()
            accion = True
            CloseSql()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            accion = False
        End Try
        Return accion
    End Function
    Public Function EliminarSQL(ByVal sql As String) As Boolean
        Dim accion As Boolean
        Try
            ConectarSQL()
            dbSQLComm = New SqlClient.SqlCommand(sql, dbSQLConn)
            dbSQLComm.ExecuteNonQuery()
            accion = True
            CloseSql()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            accion = False
        End Try
        Return accion
    End Function
    Public Function UpdateSQL(ByVal sql As String) As Boolean
        Dim accion As Boolean
        Try
            ConectarSQL()
            dbSQLComm = New SqlClient.SqlCommand(sql, dbSQLConn)
            dbSQLComm.ExecuteNonQuery()
            accion = True
            CloseSql()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            accion = False
        End Try
        Return accion
    End Function
End Module
