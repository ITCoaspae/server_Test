Public Class frmMsRelacionesAsoc
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim vDui As String
    Dim vAccion, vCorrelativo As Integer
    Public Property accion() As Integer
        Get
            Return Me.vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property dui() As String
        Get
            Return Me.vDui
        End Get
        Set(ByVal value As String)
            vDui = value
        End Set
    End Property
    Public Property correlativo() As Integer
        Get
            Return Me.vCorrelativo
        End Get
        Set(ByVal value As Integer)
            vCorrelativo = value
        End Set
    End Property
    Public Sub llenarCbParentesco()
        Dim dts As New DataSet
        dts = asociados.ConsultarParentescos("codParentesco,descripcion", "", "descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbRelaciones.DisplayMember = "descripcion"
                Me.cbRelaciones.ValueMember = "codParentesco"
                Me.cbRelaciones.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Private Sub btnGuardarTp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmMsRelacionesAsoc_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If accion = 1 Then
            llenarCbParentesco()
        End If
    End Sub

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim dts As New DataSet
        Try
            dts = asociados.ConsultarAsociado("DUI, rtrim(nombres)+' '+rtrim(apellido1)+' '+rtrim(apellido2)+' '+rtrim(apellidoCas) [nombre]", "", "Correlativo", sUsuario, sPassword, sSucursal) 'Ópcion que permite la busqueda del dui de los asociados.
            frm.Datos = dts
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim <> "" Then
                txtDui.Text = frm.Resultado.Trim
                txtAsociado.Text = frm.Resultado2
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGuardarDom_Click(sender As Object, e As EventArgs) Handles btnGuardarDom.Click
        Try
            Dim resultado As Integer = 0
            If accion = 1 Then
                resultado = asociados.insertarAsocRelacionesAsociado(dui, txtDui.Text, cbRelaciones.SelectedValue)
                If resultado > 0 Then
                    MsgBox("Registro ingresado exitosamente.", MsgBoxStyle.Information)
                Else
                    MsgBox("El registro no fue ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical)
                End If
            ElseIf accion = 2 Then
                resultado = asociados.modificarAsocRelacionesAsociado(dui, txtDui.Text, cbRelaciones.SelectedValue, correlativo)
                If resultado > 0 Then
                    MsgBox("Registro actualizado exitosamente.", MsgBoxStyle.Information)
                Else
                    MsgBox("El registro no fue actualizado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical)
                End If
            End If
            Me.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDui_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.Leave
        Dim dts As New DataSet
        If txtDui.Text.Trim.Length > 0 Then
            dts = asociados.ConsultarAsociado("rtrim(nombres)+' '+rtrim(apellido1)+' '+rtrim(apellido2)+' '+rtrim(apellidoCas) as nombre ", " where dui = '" & txtDui.Text.Trim & "' ", "", sUsuario, sPassword, sSucursal)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    txtAsociado.Text = dts.Tables(0).Rows(0).Item(0)
                End If
            End If
        End If
    End Sub
End Class