Module ModuloClientes
    Public Function botones_OnOffClientes(ByVal OnOff As Boolean)
        My.Forms.fmrClientes.btn_agregar.Enabled = OnOff
        My.Forms.fmrClientes.btn_editar.Enabled = OnOff
        My.Forms.fmrClientes.btn_guardar.Enabled = Not (OnOff)
        My.Forms.fmrClientes.btn_cancelar.Enabled = Not (OnOff)
        Return 0
    End Function
End Module
