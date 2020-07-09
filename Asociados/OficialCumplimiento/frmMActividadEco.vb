Public Class frmMActividadEco
#Region "Servicios Web"
    Dim cliente As New wrAsociados.wsLibAsoc
    Dim credPre As New wrCredito.wsLibCred
#End Region

#Region "variables locales"
    Dim vAccionAct As Integer
    Dim vIdActEco As Integer
    Dim vDui As String
#End Region
#Region "Propiedades Publicas"
    Public Property accion() As Integer
        Get
            Return Me.vAccionAct
        End Get
        Set(ByVal value As Integer)
            vAccionAct = value
        End Set
    End Property
    Public Property idActEco() As Integer
        Get
            Return Me.vIdActEco
        End Get
        Set(value As Integer)
            vIdActEco = value
        End Set
    End Property
    Public Property dui() As String
        Get
            Return Me.vDui
        End Get
        Set(value As String)
            vDui = value
        End Set
    End Property
    Public Sub llenarLugarTrabajo()
        Dim dts As New DataSet
        Me.cbLugarTrabajo.ValueMember = "codPagaduria"
        Me.cbLugarTrabajo.DisplayMember = "nombre"
        dts = credPre.consultarPrPagadurias("", "", 0)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbLugarTrabajo.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarEstadoLaboral()
        Dim dts As New DataSet
        Me.cbEstadoLaboral.DisplayMember = "Descripcion"
        Me.cbEstadoLaboral.ValueMember = "idCatalogo"
        dts = cliente.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.estadoLaboral,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbEstadoLaboral.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarDepartamentos()
        Dim dtsDepto As New DataSet
        Me.cbDeptoOfi.DisplayMember = "Departamento"
        Me.cbDeptoOfi.ValueMember = "codDepartamento"
        dtsDepto = cliente.ConsultarDepartamentos("codDepartamento,Departamento", "", "Departamento", sUsuario, sPassword, sSucursal)
        If dtsDepto.Tables(0).Rows.Count > 0 Then
            Me.cbDeptoOfi.DataSource = dtsDepto.Tables(0)
        End If
    End Sub
    Public Sub llenarMunicipio(ByVal codDepartamento As String)
        Dim dtsMun As New DataSet
        cbMunOfi.DisplayMember = "Municipio"
        Me.cbMunOfi.ValueMember = "codMunicipio"
        dtsMun = cliente.ConsultarMunicipios("codMunicipio,Municipio", "codDepartamento='" & codDepartamento & "'", "Municipio", sUsuario, sPassword, sSucursal)
        If dtsMun.Tables(0).Rows.Count > 0 Then
            Me.cbMunOfi.DataSource = dtsMun.Tables(0)
        End If
    End Sub
    Public Sub llenarDatos(idActividadEco)
        Dim dts As New DataSet
        dts = cliente.consultarAsocActividadEconomia(dui, False, 3, idActividadEco)
        If dts IsNot Nothing Then
            If dts.Tables(0).Rows.Count > 0 Then
                txtCodActEconomica.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("CodigoActividadEconomica")), "", dts.Tables(0).Rows(0).Item("CodigoActividadEconomica"))
                recuperarCatActividadEconomica(IIf(IsDBNull(dts.Tables(0).Rows(0).Item("CodigoActividadEconomica")), "", dts.Tables(0).Rows(0).Item("CodigoActividadEconomica")))
                llenarLugarTrabajo()
                If dts.Tables(0).Rows(0).Item("CodLugarTrabajo") Is DBNull.Value = False Then
                    cbLugarTrabajo.SelectedValue = dts.Tables(0).Rows(0).Item("CodLugarTrabajo")
                End If
                txtNoAcreUIF.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NoAcreditacion")), "", dts.Tables(0).Rows(0).Item("NoAcreditacion"))
                dtpFechAcre.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaAcreditacion")), "", dts.Tables(0).Rows(0).Item("FechaAcreditacion"))
                dtpVencimientoUIF.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaVencimiento")), "", dts.Tables(0).Rows(0).Item("FechaVencimiento"))
                chkNegFormal.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NegocioFormal")), "", dts.Tables(0).Rows(0).Item("NegocioFormal"))
                txtNoRegContribuyente.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NumRegistroContribuyente")), "", dts.Tables(0).Rows(0).Item("NumRegistroContribuyente"))
                txtNomComEc.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NombreComercial")), "", dts.Tables(0).Rows(0).Item("NombreComercial"))
                txtRazonSocialPrim.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("RazonSocial")), "", dts.Tables(0).Rows(0).Item("RazonSocial"))
                txtGiroPrim.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("giro")), "", dts.Tables(0).Rows(0).Item("giro"))
                llenarEstadoLaboral()
                If dts.Tables(0).Rows(0).Item("EstadoLaboral") Is DBNull.Value = False Then
                    cbEstadoLaboral.SelectedValue = dts.Tables(0).Rows(0).Item("EstadoLaboral")
                End If
                txtDptoTrabajo.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("AreaTrabajo")), "", dts.Tables(0).Rows(0).Item("AreaTrabajo"))
                dtpFechaIniTra.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaInicioTrabajo")), "", dts.Tables(0).Rows(0).Item("FechaInicioTrabajo"))
                txtCargo.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("cargo")), "", dts.Tables(0).Rows(0).Item("cargo"))
                txtIngresosPrim.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Ingresos")), 0, dts.Tables(0).Rows(0).Item("Ingresos"))
                txtTelOficina.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("TelOficina")), 0, dts.Tables(0).Rows(0).Item("telOficina"))
                txtExtOficinaPrim.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("ExtOficina")), 0, dts.Tables(0).Rows(0).Item("ExtOficina"))
                llenarDepartamentos()
                If dts.Tables(0).Rows(0).Item("codDepartamento") Is DBNull.Value = False Then
                    cbDeptoOfi.SelectedValue = dts.Tables(0).Rows(0).Item("codDepartamento")
                    llenarMunicipio(cbDeptoOfi.SelectedValue)
                End If
                If dts.Tables(0).Rows(0).Item("codMunicipio") Is DBNull.Value = False Then
                    cbMunOfi.SelectedValue = dts.Tables(0).Rows(0).Item("codMunicipio")
                End If
                txtDirOfi.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("direccion")), 0, dts.Tables(0).Rows(0).Item("direccion"))


            End If

        End If
    End Sub

    Private Sub btnGuardarDom_Click(sender As Object, e As EventArgs) Handles btnGuardarDom.Click
        Try
            If requeridosActividadEconomica() = True Then

                If accion = 1 Then
                    If (cliente.insertarAsocActividadEconomica(dui, cbLugarTrabajo.SelectedValue, txtNoAcreUIF.Text, dtpFechAcre.Value.ToShortDateString,
                                                           dtpVencimientoUIF.Value.ToShortDateString, chkNegFormal.Checked, chkcontribuyente.Checked, txtNoRegContribuyente.Text.Trim,
                                                           txtNomComEc.Text.ToUpper.Trim, cbEstadoLaboral.SelectedValue, txtDptoTrabajo.Text.Trim.ToUpper, dtpFechaIniTra.Value.ToShortDateString, txtCargo.Text.Trim.ToUpper,
                                                           txtIngresosPrim.Value, txtTelOficina.Text, txtExtOficinaPrim.Text, cbDeptoOfi.SelectedValue, cbMunOfi.SelectedValue,
                                                           txtDirOfi.Text.ToUpper.Trim, txtRazonSocialPrim.Text.ToUpper.Trim, txtGiroPrim.Text.ToUpper.Trim, chkPrincipal.Checked, txtCodActEconomica.Text,
                                                           True)) > 0 Then
                        MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information)
                    Else
                        MsgBox("El registro no fue ingresado, por favor comunicarce con el administrador de sistema.", MsgBoxStyle.Critical)
                    End If
                ElseIf accion = 2 Then

                    If (cliente.actulizarAsocActividadEconomica(dui, cbLugarTrabajo.SelectedValue, txtNoAcreUIF.Text, dtpFechAcre.Value.ToShortDateString,
                                                           dtpVencimientoUIF.Value.ToShortDateString, chkNegFormal.Checked, chkcontribuyente.Checked, txtNoRegContribuyente.Text.Trim,
                                                           txtNomComEc.Text.ToUpper.Trim, cbEstadoLaboral.SelectedValue, txtDptoTrabajo.Text.Trim.ToUpper, dtpFechaIniTra.Value.ToShortDateString, txtCargo.Text.Trim.ToUpper,
                                                           txtIngresosPrim.Value, txtTelOficina.Text, txtExtOficinaPrim.Text, cbDeptoOfi.SelectedValue, cbMunOfi.SelectedValue,
                                                           txtDirOfi.Text.ToUpper.Trim, idActEco, txtRazonSocialPrim.Text.ToUpper.Trim, txtGiroPrim.Text.ToUpper.Trim, chkPrincipal.Checked, txtCodActEconomica.Text,
                                                           True)) > 0 Then
                        MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information)
                    Else
                        MsgBox("El registro no fue actualizado, por favor comunicarce con el administrador de sistema.", MsgBoxStyle.Critical)
                    End If
                End If
            End If


        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub cbDeptoOfi_DropDownClosed(sender As Object, e As EventArgs) Handles cbDeptoOfi.DropDownClosed
        llenarMunicipio(Me.cbDeptoOfi.SelectedValue)
    End Sub

    Private Sub cbDeptoOfi_Validated(sender As Object, e As EventArgs) Handles cbDeptoOfi.Validated
        llenarMunicipio(Me.cbDeptoOfi.SelectedValue)
    End Sub

    Private Sub txtCodActEconomica_TextChanged(sender As Object, e As EventArgs) Handles txtCodActEconomica.TextChanged


    End Sub
    Public Sub recuperarCatActividadEconomica(codigo As String)
        Dim dts As New DataSet
        Try
            dts = cliente.consultarCatActividadEconomica("0", "0", 4, codigo)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    Me.txtDescripcionActEco.Text = dts.Tables(0).Rows(0).Item("descripcion").ToString
                Else
                    MsgBox("Código ingresado no existe.", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Código ingresado no existe.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Código ingresado no existe.", MsgBoxStyle.Critical)
        End Try

    End Sub


    Private Sub txtCodActEconomica_DoubleClick(sender As Object, e As EventArgs) Handles txtCodActEconomica.DoubleClick
        Dim frm As New frmMsConsultarActividadEconomica
        Dim dts As New DataSet
        frm.Text = "Buscar Actividad Económica"
        Try
            frm.ShowDialog()
            txtCodActEconomica.Text = frm.Resultado
            txtDescripcionActEco.Text = frm.Resultado2
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Ejecutivos Mercadeo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodActEconomica_Leave(sender As Object, e As EventArgs) Handles txtCodActEconomica.Leave
        If txtCodActEconomica.Text.Length > 0 Then
            recuperarCatActividadEconomica(txtCodActEconomica.Text.Trim)
        End If
    End Sub

    Private Sub frmMActividadEco_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            If accion = 1 Then
                llenarEstadoLaboral()
                llenarDepartamentos()
                llenarLugarTrabajo()
            ElseIf accion = 2
                llenarDatos(idActEco)
            End If
        Catch ex As Exception

        End Try


    End Sub
#End Region
    Public Function requeridosActividadEconomica() As Boolean
        Me.ErrorProvider1.Clear()
        Dim valido As Boolean = True
        If Me.cbDeptoOfi.SelectedIndex < 0 Then
            Me.ErrorProvider1.SetError(cbDeptoOfi, "Campo Requerido")
            valido = False
        End If
        If Me.cbMunOfi.SelectedIndex < 0 Then
            Me.ErrorProvider1.SetError(cbMunOfi, "Campo Requerido")
            valido = False
        End If
        If Me.txtDirOfi.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtDirOfi, "Campo Requerido")
            valido = False
        End If

        If txtCodActEconomica.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtCodActEconomica, "Campo Requerido")
            valido = False
        End If
        If txtIngresosPrim.Value = 0 Then
            Me.ErrorProvider1.SetError(txtIngresosPrim, "Valor debe ser mayor que cero.")
            valido = False
        End If
        Return valido
    End Function

    Private Sub frmMActividadEco_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class