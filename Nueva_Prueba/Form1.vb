Public Class fmrClientes
    Public IDClientes As String
    Public AccionSQL As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGconfig()
        fillDataGrid("select * from tbl_paises")
        ModuloClientes.botones_OnOffClientes(True)
        Me.GroupBox1.Enabled = False
    End Sub
    Public Sub DGconfig()
        Me.ConsultaDatos.EditMode = False
        Me.ConsultaDatos.AllowUserToAddRows = False
        Me.ConsultaDatos.AllowUserToDeleteRows = False
        Me.ConsultaDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
    Public Sub fillDataGrid(ByVal sql As String)
        'Me.dgDatosConsulta.Rows.Clear()
        ConectDB.ConectarSQL()
        Me.ConsultaDatos.DataSource = ConectDB.consulta(sql)
        ConectDB.CloseSql()
    End Sub
    Private Sub ConsultaDatos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ConsultaDatos.CellClick
        Try
            If e.RowIndex >= 0 Then
                Dim row As DataGridViewRow
                row = Me.ConsultaDatos.Rows(e.RowIndex)
                IDClientes = row.Cells("id").Value.ToString
                Me.txt_nombre.Text = row.Cells("nombre").Value.ToString
                Me.txt_id.Text = row.Cells("identidad").Value.ToString
                Me.txt_direccion.Text = row.Cells("direccion").Value.ToString
                Me.txt_correo.Text = row.Cells("correo").Value.ToString
                Me.txt_tel.Text = row.Cells("telefono").Value.ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        ModuloClientes.botones_OnOffClientes(False)
        Me.GroupBox1.Enabled = True
        Me.ConsultaDatos.Enabled = False
        AccionSQL = "Insert"
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        ModuloClientes.botones_OnOffClientes(False)
        Me.GroupBox1.Enabled = True
        Me.ConsultaDatos.Enabled = False
        AccionSQL = "Update"
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Select Case AccionSQL
            Case "Update"
                ModuloClientes.botones_OnOffClientes(True)
                Me.GroupBox1.Enabled = False
                Me.ConsultaDatos.Enabled = True
                ConectDB.UpdateSQL("Update tbl_clientes Set  = '" & Me.txt_nombre.Text & "', Nombre = '" & Me.txt_id.Text & "' Where ID = " & IDClientes)
                fillDataGrid("select * from tbl_clientes")
                MsgBox("Registro Guardado con exito", MsgBoxStyle.Information)
            Case "Insert"
                ModuloClientes.botones_OnOffClientes(True)
                Me.GroupBox1.Enabled = False
                Me.ConsultaDatos.Enabled = True
                ConectDB.InsertSQL("Insert into tbl_clientes values('" & Me.txt_nombre.Text & "','" & Me.txt_direccion.Text & "')")
                fillDataGrid("select * from tbl_clientes")
                MsgBox("Registro Guardado con exito", MsgBoxStyle.Information)
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        ModuloClientes.botones_OnOffClientes(True)
        Me.GroupBox1.Enabled = False
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If Me.txt_nombre.Text <> "" Then
            If MsgBox("¿Esta seguro que desea eliminar el registro?", MsgBoxStyle.YesNo, "Confirmacion") = MsgBoxResult.Yes Then
                ConectDB.EliminarSQL("Delete from tbl_paises where ID = " & IDClientes)
                fillDataGrid("select * from tbl_clientes")
                MsgBox("Su registro fue Eliminado", MsgBoxStyle.Information)

                ModuloClientes.botones_OnOffClientes(True)
                Me.GroupBox1.Enabled = False
                Me.txt_nombre.Text = ""
                Me.txt_direccion.Text = ""
                Me.txt_id.Text = ""
                Me.txt_correo.Text = ""
                Me.txt_tel = "0"
                Me.txt_buscar.Text = ""
                Me.ConsultaDatos.Enabled = True
            End If
        Else
            MsgBox("Seleccione un registro para eliminar")
        End If
    End Sub
    End Sub
End Class
