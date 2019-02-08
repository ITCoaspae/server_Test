Public Class frmMantenimientoCatalogo
    Dim contabilidas As New wrConta.wsLibContab
    Private dataSetArbol As DataSet
    Private Sub llenarListaCatalogo()
        Dim dts As New DataSet
        dataSetArbol = contabilidas.ObtenerCatContab("concat(rtrim(idcuenta),'-',descripcion) as NombreNodo,correlativo as IdentificadorNodo,cta_Dependencia as IdentificadorPadre, idcuenta", "", "IdCuenta", sUsuario, sPassword, sSucursal)
    End Sub
    Private Sub CrearNodosDelPadre(ByVal indicePadre As Integer, ByVal nodePadre As TreeNode)

        Dim dataViewHijos As DataView

        ' Crear un DataView con los Nodos que dependen del Nodo padre pasado como parámetro.
        dataViewHijos = New DataView(dataSetArbol.Tables(0))

        dataViewHijos.RowFilter = dataSetArbol.Tables(0).Columns("IdentificadorPadre").ColumnName + " = '" & indicePadre.ToString & "' "

        ' Agregar al TreeView los nodos Hijos que se han obtenido en el DataView.
        For Each dataRowCurrent As DataRowView In dataViewHijos

            Dim nuevoNodo As New TreeNode
            nuevoNodo.Text = dataRowCurrent("NombreNodo").ToString().Trim()

            ' si el parámetro nodoPadre es nulo es porque es la primera llamada, son los Nodos
            ' del primer nivel que no dependen de otro nodo.
            If nodePadre Is Nothing Then
                TreeView1.Nodes.Add(nuevoNodo)
            Else
                ' se añade el nuevo nodo al nodo padre.
                nodePadre.Nodes.Add(nuevoNodo)
            End If

            ' Llamada recurrente al mismo método para agregar los Hijos del Nodo recién agregado.
            CrearNodosDelPadre(Int32.Parse(dataRowCurrent("IdentificadorNodo").ToString()), nuevoNodo)
        Next dataRowCurrent

    End Sub

    Private Sub frmMantenimientoCatalogo_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenarListaCatalogo()
        CrearNodosDelPadre(1, Nothing)
    End Sub
End Class