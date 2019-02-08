Public Class frmMsPrGastosTramitacion
    Dim Contabilidad As New wrConta.wsLibContab
    Dim Creditos As New wrCredito.wsLibCred
    Public Id_CatGastos_Tramitacion As Integer
    Dim vAccion As Integer
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Private Sub txtIdCtaContable_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCtaContable.DoubleClick
        Dim ofrm As New frmAGenerico
        Dim Dts As New DataSet
        ofrm.Text = "Catalogo Cuentas Contables."
        Dts = Contabilidad.ObtenerCatContab("IdCuenta,Descripcion", _
                                      "", "IdCuenta", sUsuario, sPassword, sSucursal)
        ofrm.Datos = Dts
        ofrm.ColSeleccion = 0
        ofrm.RefrescarGrid()
        ofrm.ShowDialog()
        Me.txtIdCtaContable.Text = ofrm.Resultado.ToString
        Me.txtCuenta.Text = ofrm.Resultado2.ToString
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmMsPrGastosTramitacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtMax.Enabled = False
        Me.txtMin.Enabled = False
        If accion = 1 Then
            Me.Text = "Ingresar Gasto de Tramitación"
            btnGuardar1.Text = "Guardar"
        ElseIf accion = 2 Then
            Me.Text = "Modificar Gasto de Tramitación"
            btnGuardar1.Text = "Modificar"
        End If
    End Sub


    Private Sub chkMin_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMin.CheckedChanged
        If Me.chkMin.Checked = True Then
            Me.txtMin.Enabled = True
        ElseIf chkMin.Checked = False Then
            Me.txtMin.Enabled = False
        End If
    End Sub

    Private Sub chkMax_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMax.CheckedChanged
        If Me.chkMax.Checked = True Then
            Me.txtMax.Enabled = True
        ElseIf chkMax.Checked = False Then
            Me.txtMax.Enabled = False
        End If
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        If Me.txtDescripcion.Text.Length > 0 Then
            Try
                Dim Resultado As Integer
                Dim montoMax As Double = IIf(chkMax.Checked = True, txtMax.Value, 0)
                Dim montoMin As Double = IIf(chkMin.Checked = True, txtMin.Value, 0)

                If Me.btnGuardar1.Text = "Guardar" Then
                    Resultado = Creditos.Ingresar_PrCatGastosTramitacion(txtDescripcion.Text.Trim, Me.txtIdCtaContable.Text.Trim, Me.chkMin.Checked, montoMin, Me.chkMax.Checked, montoMax)
                    If Resultado <> 0 Then
                        MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Creditos")
                        Me.Close()
                    Else
                        MsgBox("Registro no pudo ser ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Creditos")
                    End If
                ElseIf Me.btnGuardar1.Text = "Modificar" Then
                    Resultado = Creditos.Modificar_PrCatGastosTramitacion(Me.txtDescripcion.Text, Me.txtIdCtaContable.Text.Trim, Id_CatGastos_Tramitacion, Me.chkMin.Checked, montoMin, Me.chkMax.Checked, montoMax)
                    If Resultado <> 0 Then
                        MsgBox("Registro modificado exitosamente", MsgBoxStyle.Information, "Módulo - Creditos")
                        Me.Close()
                    Else
                        MsgBox("Registro no pudo ser modificado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Creditos")
                    End If
                End If
            Catch ex As Exception
                MsgBox(mensajeError, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
End Class