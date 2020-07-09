Public Class frmMsBC_CatTransaccionesSucursalesBov
    Dim Bancos As New wrBancos.wsLibBancos
    Dim Contabilidad As New wrConta.wsLibContab
    Dim Asociados As New wrAsociados.wsLibAsoc
    Public Accion As Integer '1=insertar,2=Modificar,3Consultar
    Public idSucursalTransaccionBoveda As Integer

#Region "Metodos"
    Protected Sub limpiar()
        Me.txtCtaAbono.Text = ""
        Me.txtCtaCargos.Text = ""
        Me.txtDescCtaAbono.Text = ""
        Me.txtDescCtaCargo.Text = ""
    End Sub
    Public Sub LlenarCBSucursales(ByVal Campos As String, ByVal Filtro As String, ByVal Orden As String)
        Dim Dts As New DataSet
        Dts = Asociados.ConsultarSucursales(Campos, Filtro, Orden, sUsuario, sPassword, sSucursal)
        If Dts.Tables.Count > 0 Then
            If Dts.Tables(0).Rows.Count > 0 Then
                Me.cbSucursal.DataSource = Dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarCbTransacciones(ByVal opcion As Integer, ByVal codTransaccion As Integer)
        Dim Dts As New DataSet
        Dts = Bancos.ConsultarBCCatTransacciones_Boveda(opcion, codTransaccion)
        If Dts.Tables.Count > 0 Then
            If Dts.Tables(0).Rows.Count > 0 Then
                Me.cbTransaccion.DataSource = Dts.Tables(0)
            End If
        End If
    End Sub
#End Region

#Region "Funciones"
    Private Function consultarCatalogoContable(ByVal campos As String, ByVal filtro As String, ByVal orden As String) As DataSet
        Dim dts As New DataSet
        dts = Contabilidad.ObtenerCatContab("IdCuenta,Descripcion", _
                                      "", "IdCuenta", sUsuario, sPassword, sSucursal)
        Return dts
    End Function

    Private Function GuardarTransaccionSucursal(ByVal codSucursal As String, ByVal codTransaccion As Integer, _
                                                ByVal idCuentaA As String, ByVal idCuentaC As String _
                                                ) As Integer
        Dim resultado As Integer
        resultado = Bancos.InsertarBcSucursales_TransaccionesBoveda(codSucursal, codTransaccion, idCuentaA, idCuentaC)
        Return resultado
    End Function

    Private Function ModificarTransaccionSucursal(ByVal idSucursalTransaccionBoveda As Integer, ByVal codSucursal As String, _
                                                  ByVal codTransaccion As Integer, ByVal idCuentaA As String, _
                                                  ByVal idCuentaC As String) As Integer
        Dim resultado As Integer
        resultado = Bancos.ActualizarBcSucursales_TransaccionesBoveda(codSucursal, codTransaccion, _
                                                                      idCuentaA, idCuentaC, _
                                                                      idSucursalTransaccionBoveda)
        Return resultado
    End Function

#End Region

#Region "Eventos"
    Private Sub txtCtaAbono_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCtaAbono.DoubleClick
        Dim ofrm As New frmAGenerico
        Dim Dts As New DataSet
        ofrm.Text = "Catalogo Cuentas Contables."
        Dts = consultarCatalogoContable("IdCuenta,Descripcion", "", "IdCuenta")
        ofrm.Datos = Dts
        ofrm.ColSeleccion = 0
        ofrm.RefrescarGrid()
        ofrm.ShowDialog()
        Me.txtCtaAbono.Text = ofrm.Resultado.ToString
        Me.txtDescCtaAbono.Text = ofrm.Resultado2.ToString
    End Sub

    Private Sub txtCtaAbono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCtaAbono.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim ofrm As New frmAGenerico
            Dim Dts As New DataSet
            ofrm.Text = "Catalogo Cuentas Contables."
            Dts = consultarCatalogoContable("IdCuenta,Descripcion", "", "IdCuenta")
            ofrm.Datos = Dts
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCtaAbono.Text = ofrm.Resultado.ToString
            Me.txtDescCtaAbono.Text = ofrm.Resultado2.ToString
        End If
    End Sub

    Private Sub txtCtaCargos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCtaCargos.DoubleClick
        Dim ofrm As New frmAGenerico
        Dim Dts As New DataSet
        ofrm.Text = "Catalogo Cuentas Contables."
        Dts = consultarCatalogoContable("IdCuenta,Descripcion", "", "IdCuenta")
        ofrm.Datos = Dts
        ofrm.ColSeleccion = 0
        ofrm.RefrescarGrid()
        ofrm.ShowDialog()
        Me.txtCtaCargos.Text = ofrm.Resultado.ToString
        Me.txtDescCtaCargo.Text = ofrm.Resultado2.ToString
    End Sub

    Private Sub txtCtaCargos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCtaCargos.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            Dim ofrm As New frmAGenerico
            Dim Dts As New DataSet
            ofrm.Text = "Catalogo Cuentas Contables."
            Dts = consultarCatalogoContable("IdCuenta,Descripcion", "", "IdCuenta")
            ofrm.Datos = Dts
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCtaCargos.Text = ofrm.Resultado.ToString
            Me.txtDescCtaCargo.Text = ofrm.Resultado2.ToString
        End If
       
    End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub frmMsBC_CatTransaccionesSucursalesBov_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Accion = 1 Then
            Me.cbSucursal.ValueMember = "CodSucursal"
            Me.cbSucursal.DisplayMember = "Nom_Sucursal"
            Me.cbTransaccion.ValueMember = "codTransaccion"
            Me.cbTransaccion.DisplayMember = "Descripcion"
            LlenarCBSucursales("CodSucursal,Nom_Sucursal", "", "Nom_Sucursal")
            llenarCbTransacciones(1, 0)
        End If

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim resultado As Integer
        Try
            If Accion = 1 Then
                resultado = GuardarTransaccionSucursal(Me.cbSucursal.SelectedValue, Me.cbTransaccion.SelectedValue,
                                       Me.txtCtaAbono.Text.Trim, Me.txtCtaCargos.Text.Trim)
                If resultado <> 0 Then
                    MsgBox("Registro ingresado correctamente.", MsgBoxStyle.Information, "Módulo - Bóveda")
                    limpiar()
                Else
                    MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Information, "Módulo - Bóveda")
                End If
            ElseIf Accion = 2 Then
                resultado = ModificarTransaccionSucursal(idSucursalTransaccionBoveda, Me.cbSucursal.SelectedValue,
                                                          Me.cbTransaccion.SelectedValue, Me.txtCtaAbono.Text.Trim,
                                                          Me.txtCtaCargos.Text.Trim)
                If resultado <> 0 Then
                    MsgBox("Registro ingresado correctamente.", MsgBoxStyle.Information, "Módulo - Bóveda")
                    limpiar()
                Else
                    MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Information, "Módulo - Bóveda")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error, por favor comunicarse con el administrador del sistema." + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Bóveda")
        End Try
    End Sub

    Private Sub frmMsBC_CatTransaccionesSucursalesBov_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
#End Region







End Class