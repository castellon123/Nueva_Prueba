<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_producto = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.txt_proveedor = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btn_agregar = New System.Windows.Forms.ToolStripButton()
        Me.btn_editar = New System.Windows.Forms.ToolStripButton()
        Me.btn_guardar = New System.Windows.Forms.ToolStripButton()
        Me.btn_cancelar = New System.Windows.Forms.ToolStripButton()
        Me.btn_eliminar = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_proveedor)
        Me.GroupBox1.Controls.Add(Me.txt_marca)
        Me.GroupBox1.Controls.Add(Me.txt_precio)
        Me.GroupBox1.Controls.Add(Me.txt_producto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(609, 266)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Productos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Del Producto:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(301, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Proveedor:"
        '
        'txt_producto
        '
        Me.txt_producto.Location = New System.Drawing.Point(210, 54)
        Me.txt_producto.Name = "txt_producto"
        Me.txt_producto.Size = New System.Drawing.Size(368, 26)
        Me.txt_producto.TabIndex = 4
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(85, 122)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(146, 26)
        Me.txt_precio.TabIndex = 5
        '
        'txt_marca
        '
        Me.txt_marca.Location = New System.Drawing.Point(381, 125)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.Size = New System.Drawing.Size(197, 26)
        Me.txt_marca.TabIndex = 6
        '
        'txt_proveedor
        '
        Me.txt_proveedor.Location = New System.Drawing.Point(125, 207)
        Me.txt_proveedor.Name = "txt_proveedor"
        Me.txt_proveedor.Size = New System.Drawing.Size(453, 26)
        Me.txt_proveedor.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 408)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(608, 232)
        Me.DataGridView1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(46, 364)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Buscar:"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(125, 358)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(453, 26)
        Me.txt_buscar.TabIndex = 8
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_agregar, Me.btn_editar, Me.btn_guardar, Me.btn_cancelar, Me.btn_eliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(708, 31)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_agregar
        '
        Me.btn_agregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_agregar.Image = Global.Nueva_Prueba.My.Resources.Resources.nuevo
        Me.btn_agregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(28, 28)
        Me.btn_agregar.Text = "btn_agregar"
        '
        'btn_editar
        '
        Me.btn_editar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_editar.Image = Global.Nueva_Prueba.My.Resources.Resources.editar
        Me.btn_editar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(28, 28)
        Me.btn_editar.Text = "btn_editar"
        '
        'btn_guardar
        '
        Me.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_guardar.Image = Global.Nueva_Prueba.My.Resources.Resources.guardar
        Me.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(28, 28)
        Me.btn_guardar.Text = "btn_agregar"
        '
        'btn_cancelar
        '
        Me.btn_cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_cancelar.Image = Global.Nueva_Prueba.My.Resources.Resources.cancelar
        Me.btn_cancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(28, 28)
        Me.btn_cancelar.Text = "btn_cancelar"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_eliminar.Image = Global.Nueva_Prueba.My.Resources.Resources.eliminar
        Me.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(28, 28)
        Me.btn_eliminar.Text = "btn_salir"
        '
        'frmProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 695)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmProductos"
        Me.Text = "Productos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_proveedor As TextBox
    Friend WithEvents txt_marca As TextBox
    Friend WithEvents txt_precio As TextBox
    Friend WithEvents txt_producto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_buscar As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btn_agregar As ToolStripButton
    Friend WithEvents btn_editar As ToolStripButton
    Friend WithEvents btn_guardar As ToolStripButton
    Friend WithEvents btn_cancelar As ToolStripButton
    Friend WithEvents btn_eliminar As ToolStripButton
End Class
