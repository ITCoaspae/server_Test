Imports MetroFramework

Public Class uifEfectivo
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim caja As New wrCaja.wsLibCaja
    Private dui, codSucursal, idMovimiento, cajero, tipo, horaFactura As String
    Private fechaFactura As Date
    Private idReporte As Integer
    Private id As Integer
#Region "Propiedades"
    Public Property idP() As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property
    Public Property idReporteP() As Integer
        Get
            Return idReporte
        End Get
        Set(value As Integer)
            idReporte = value
        End Set
    End Property
    Public Property duip() As String
        Get
            Return dui
        End Get
        Set(ByVal Value As String)
            dui = Value
        End Set
    End Property
    Public Property codSucursalP() As String
        Get
            Return codSucursal
        End Get
        Set(value As String)
            codSucursal = value
        End Set
    End Property
    Public Property idMovimientoP() As String
        Get
            Return idMovimiento
        End Get
        Set(value As String)
            idMovimiento = value
        End Set
    End Property
    Public Property cajeroP() As String
        Get
            Return cajero
        End Get
        Set(value As String)
            cajero = value
        End Set
    End Property
    Public Property tipoP() As String
        Get
            Return tipo
        End Get
        Set(value As String)
            tipo = value
        End Set
    End Property
    Public Property fechaFacturaP() As Date
        Get
            Return fechaFactura
        End Get
        Set(value As Date)
            fechaFactura = value
        End Set
    End Property
    Public Property horaFacturaP() As String
        Get
            Return horaFactura
        End Get
        Set(value As String)
            horaFactura = value
        End Set
    End Property
#End Region

    Private Sub llenarDepartamentoSucursal()
        Dim dts As New DataSet
        dts = asociados.ConsultarDepartamentos("CodDepartamento,Departamento", "", "Departamento", sUsuario, sPassword, sSucursal)
        cbDeptoSucursal.DataSource = dts.Tables(0)
        cbDeptoSucursal.DisplayMember = "Departamento"
        cbDeptoSucursal.ValueMember = "CodDepartamento"
    End Sub
    Private Sub llenarMunicipioSucursal(codDepartamento)
        Dim dts As New DataSet
        dts = asociados.ConsultarMunicipios("codMunicipio,Municipio", " codDepartamento = '" & codDepartamento & "' ", "Municipio", sUsuario, sPassword, sSucursal)
        cbMunSucursal.DataSource = dts.Tables(0)
        cbMunSucursal.DisplayMember = "Municipio"
        cbMunSucursal.ValueMember = "codMunicipio"
    End Sub
    Private Sub recuperarInformacionSucursal(codsucursal As String)
        Dim dts As New DataSet
        dts = asociados.ConsultarSucursales("nom_sucursal,Direccion,codDepartamento,codMunicipio", " codSucursal = '" & codsucursal & "'", "", sUsuario, sPassword, sSucursal)
        txtDirSucursal.Text = dts.Tables(0).Rows(0).Item("Direccion").ToString.ToUpper
        llenarDepartamentoSucursal()
        cbDeptoSucursal.SelectedValue = dts.Tables(0).Rows(0).Item("codDepartamento").ToString
        llenarMunicipioSucursal(cbDeptoSucursal.SelectedValue)
        cbMunSucursal.SelectedValue = dts.Tables(0).Rows(0).Item("codMunicipio").ToString
        txtDirComSO.Text = dts.Tables(0).Rows(0).Item("Direccion").ToString.ToUpper
    End Sub

    Private Sub recuperarInformacionTransaccion(idMovimiento As String)
        Try
            Dim dts As New DataSet
            dts = caja.consultarTranccionReporteUIF(idMovimiento, 1, dui, fechaFactura)
            If dts.Tables(0).Rows.Count > 0 Then
                dtpFechaTran.Value = fechaFactura
                txtHoraTran.Text = horaFactura
                txtNumProdcuto.Text = dts.Tables(0).Rows(0).Item("NoCuenta")
                txtClaseProducto.Text = dts.Tables(0).Rows(0).Item("ClaseProducto")
                txtTipoTran.Text = dts.Tables(0).Rows(0).Item("tipoTransaccion")
                txtMonto.Text = dts.Tables(0).Rows(0).Item("Vta_Total")
                txtColaborador.Text = cajero
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Function recuperarDescripcionCatActividadEconomica(codigo As String) As String
        Dim dts As New DataSet
        Dim descripcion As String = ""
        Try
            dts = asociados.consultarCatActividadEconomica("0", "0", 4, codigo)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    descripcion = dts.Tables(0).Rows(0).Item("descripcion").ToString
                Else
                    MsgBox("Código ingresado no existe.", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("Código ingresado no existe.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Código ingresado no existe.", MsgBoxStyle.Critical)
        End Try
        Return descripcion
    End Function
    Public Sub recuperarDatosSujetoObligado()
        Dim dtsParametros As New DataSet
        dtsParametros = asociados.ConsultarParametros("razonSocial,nitInstitucion,nrcInstitucion,codActividadEconomica", "", "razonSocial", sUsuario, sPassword, sSucursal)
        txtRazonSO.Text = dtsParametros.Tables(0).Rows(0).Item("razonSocial").ToString.ToUpper
        txtNITSO.Text = dtsParametros.Tables(0).Rows(0).Item("nitInstitucion").ToString.ToUpper
        txtNRCSO.Text = dtsParametros.Tables(0).Rows(0).Item("nrcInstitucion").ToString.ToUpper
        txtCodActEcoSO.Text = dtsParametros.Tables(0).Rows(0).Item("codActividadEconomica").ToString.ToUpper
        txtDescripcionActEcoSO.Text = recuperarDescripcionCatActividadEconomica(txtCodActEcoSO.Text).ToUpper

    End Sub
#Region "tab 3"
    Private Sub llenarTipoDocumentoSeccionC()
        Dim dts As New DataSet
        cbTipoDocBene.DisplayMember = "Descripcion"
        cbTipoDocBene.ValueMember = "idCatalogo"
        dts = asociados.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.tipoDocumento,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                cbTipoDocBene.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarActividadEconomicaSeccionC(dui As String)
        Try
            Dim dts As New DataSet
            dts = asociados.consultarAsocActividadEconomia(dui, False, 2, 0)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    txtCodActEcoBene.Text = dts.Tables(0).Rows(0).Item("codigoActividadEconomica")
                    txtDescActEcoBene.Text = dts.Tables(0).Rows(0).Item("ActividadEconomica")

                End If
            End If


        Catch ex As Exception

        End Try

    End Sub
#End Region
#Region "tab 2"
    Private Sub llenarDepartamentoSeccionCnat()
        Dim dts As New DataSet
        dts = asociados.ConsultarDepartamentos("CodDepartamento,Departamento", "", "Departamento", sUsuario, sPassword, sSucursal)
        cbDeptoBene.DataSource = dts.Tables(0)
        cbDeptoBene.DisplayMember = "Departamento"
        cbDeptoBene.ValueMember = "CodDepartamento"
    End Sub
    Private Sub cbDeptoBene_Validated(sender As Object, e As EventArgs) Handles cbDeptoBene.Validated
        Dim dts As New DataSet
        dts = asociados.ConsultarMunicipios("codMunicipio,Municipio", " codDepartamento = '" & cbDeptoNomb.SelectedValue & "' ", "Municipio", sUsuario, sPassword, sSucursal)
        cbMunBene.DataSource = dts.Tables(0)
        cbMunBene.DisplayMember = "Municipio"
        cbMunBene.ValueMember = "codMunicipio"
    End Sub
    Private Sub llenarNacionalidadSeccionCNat()
        Try
            Dim dts As New DataSet
            dts = asociados.ConsultarNacionalidades("Nacionalidad,codNacionalidad", "", "Nacionalidad", sUsuario, sPassword, sSucursal)
            cbNacionalidadBene.DataSource = dts.Tables(0)
            cbNacionalidadBene.DisplayMember = "Nacionalidad"
            cbNacionalidadBene.ValueMember = "codNacionalidad"
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error en la recuperación de datos (Sucursales)", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub
    Private Sub llenarEstadoCivilSeccionCNat()
        Dim dts As New DataSet
        cbEstadoFamBene.DisplayMember = "Descripcion"
        cbEstadoFamBene.ValueMember = "idCatalogo"
        dts = asociados.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.estadoCivil,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                cbEstadoFamBene.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Private Sub llenarProfesionSeccionCNat()
        cbProfesionBene.DisplayMember = "Descripcion"
        cbProfesionBene.ValueMember = "codProfesion"
        Dim dts As New DataSet
        dts = asociados.ConsultarProfesiones("codProfesion,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                cbProfesionBene.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
#End Region
#Region "Tab 1"
    Private Sub llenarTipoDocumentoSeccionB()
        Dim dts As New DataSet
        cbTipoDocNomb.DisplayMember = "Descripcion"
        cbTipoDocNomb.ValueMember = "idCatalogo"
        dts = asociados.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.tipoDocumento,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                cbTipoDocNomb.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Private Sub llenarDomicilio(dui As String)

    End Sub
    Private Sub llenarDepartamentoSeccionBNat()
        Dim dts As New DataSet
        dts = asociados.ConsultarDepartamentos("CodDepartamento,Departamento", "", "Departamento", sUsuario, sPassword, sSucursal)
        cbDeptoNomb.DataSource = dts.Tables(0)
        cbDeptoNomb.DisplayMember = "Departamento"
        cbDeptoNomb.ValueMember = "CodDepartamento"
    End Sub
    Private Sub cbDeptoNomb_Validated(sender As Object, e As EventArgs) Handles cbDeptoNomb.Validated
        Dim dts As New DataSet
        dts = asociados.ConsultarMunicipios("codMunicipio,Municipio", " codDepartamento = '" & cbDeptoNomb.SelectedValue & "' ", "Municipio", sUsuario, sPassword, sSucursal)
        cbMunNomb.DataSource = dts.Tables(0)
        cbMunNomb.DisplayMember = "Municipio"
        cbMunNomb.ValueMember = "codMunicipio"
    End Sub

    Private Sub llenarNacionalidadSeccionBNat()
        Try
            Dim dts As New DataSet
            dts = asociados.ConsultarNacionalidades("Nacionalidad,codNacionalidad", "", "Nacionalidad", sUsuario, sPassword, sSucursal)
            cbNacionalidadNomb.DataSource = dts.Tables(0)
            cbNacionalidadNomb.DisplayMember = "Nacionalidad"
            cbNacionalidadNomb.ValueMember = "codNacionalidad"
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error en la recuperación de datos (Sucursales)", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub
    Private Sub llenarEstadoCivilSeccionBNat()
        Dim dts As New DataSet
        cbEstadoCivilNomb.DisplayMember = "Descripcion"
        cbEstadoCivilNomb.ValueMember = "idCatalogo"
        dts = asociados.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.estadoCivil,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                cbEstadoCivilNomb.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Private Sub llenarProfesionSeccionBNat()
        cbProfesionNomb.DisplayMember = "Descripcion"
        cbProfesionNomb.ValueMember = "codProfesion"
        Dim dts As New DataSet
        dts = asociados.ConsultarProfesiones("codProfesion,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                cbProfesionNomb.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
#End Region
#Region "Tab 0"
    Private Sub llenarTipoDocumento()
        Dim dts As New DataSet
        cbTipoDocInv.DisplayMember = "Descripcion"
        cbTipoDocInv.ValueMember = "idCatalogo"
        dts = asociados.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.tipoDocumento,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                cbTipoDocInv.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Private Sub llenarDepartamentoSeccionA()
        Dim dts As New DataSet
        dts = asociados.ConsultarDepartamentos("CodDepartamento,Departamento", "", "Departamento", sUsuario, sPassword, sSucursal)
        cbDepartamentoInv.DataSource = dts.Tables(0)
        cbDepartamentoInv.DisplayMember = "Departamento"
        cbDepartamentoInv.ValueMember = "CodDepartamento"
    End Sub
    Private Sub cbDepartamentoInv_Validated(sender As Object, e As EventArgs) Handles cbDepartamentoInv.Validated
        Dim dts As New DataSet
        dts = asociados.ConsultarMunicipios("codMunicipio,Municipio", " codDepartamento = '" & cbDepartamentoInv.SelectedValue & "' ", "Municipio", sUsuario, sPassword, sSucursal)
        cbMunicipioInv.DataSource = dts.Tables(0)
        cbMunicipioInv.DisplayMember = "Municipio"
        cbMunicipioInv.ValueMember = "codMunicipio"
    End Sub
    Private Sub llenarNacionalidadSeccionA()
        Try
            Dim dts As New DataSet
            dts = asociados.ConsultarNacionalidades("Nacionalidad,codNacionalidad", "", "Nacionalidad", sUsuario, sPassword, sSucursal)
            cbNacionalidadInv.DataSource = dts.Tables(0)
            cbNacionalidadInv.DisplayMember = "Nacionalidad"
            cbNacionalidadInv.ValueMember = "codNacionalidad"
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error en la recuperación de datos (Sucursales)", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Close()
        End Try
    End Sub
    Private Sub llenarEstadoCivilSeccionA()
        Dim dts As New DataSet
        cbEstadoFamInv.DisplayMember = "Descripcion"
        cbEstadoFamInv.ValueMember = "idCatalogo"
        dts = asociados.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.estadoCivil,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                cbEstadoFamInv.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Private Sub llenarProfesionSeccionA()
        cbProfesionInv.DisplayMember = "Descripcion"
        cbProfesionInv.ValueMember = "codProfesion"
        Dim dts As New DataSet
        dts = asociados.ConsultarProfesiones("codProfesion,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                cbProfesionInv.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarActividadEconomicaSeccionB(dui As String)
        Try
            Dim dts As New DataSet
            dts = asociados.consultarAsocActividadEconomia(dui, False, 2, 0)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    txtActEcoNomb.Text = dts.Tables(0).Rows(0).Item("codigoActividadEconomica")
                    txtDescripcionActEcoNomb.Text = dts.Tables(0).Rows(0).Item("ActividadEconomica")

                End If
            End If


        Catch ex As Exception

        End Try

    End Sub
    Private Sub llenarDatosAsoc()
        Dim dts As New DataSet
        dts = asociados.consultarCat_Asociados(dui)
        If dts.Tables(0).Rows.Count > 0 Then
            txtNombresInv.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Nombres")), " ", dts.Tables(0).Rows(0).Item("Nombres")).ToString.ToUpper
            txtApeliidosInv.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellido1")), " ", dts.Tables(0).Rows(0).Item("apellido1")).ToString.ToUpper + " " + IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellido2")), " ", dts.Tables(0).Rows(0).Item("apellido2")).ToString.ToUpper
            txtApellidoCasInv.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellidocas")), " ", dts.Tables(0).Rows(0).Item("apellidocas")).ToString.ToUpper
            dtpNacInv.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Fecha_Nac")), Now, dts.Tables(0).Rows(0).Item("Fecha_Nac"))
            cbNacionalidadInv.SelectedValue = dts.Tables(0).Rows(0).Item("codNacionalidad")
            cbEstadoFamInv.SelectedValue = dts.Tables(0).Rows(0).Item("codEstadoCivil")
            cbProfesionInv.SelectedValue = dts.Tables(0).Rows(0).Item("codProfesion")
            cbTipoDocInv.SelectedIndex = 0
            txtNoDocInv.Text = dui
            ' SECCION B
            cbTipoDocNomb.SelectedIndex = 0
            txtNoDocNomb.Text = dui
            txtNombresNomb.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Nombres")), " ", dts.Tables(0).Rows(0).Item("Nombres")).ToString.ToUpper
            txtApellidosNom.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellido1")), " ", dts.Tables(0).Rows(0).Item("apellido1")).ToString.ToUpper + " " + IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellido2")), " ", dts.Tables(0).Rows(0).Item("apellido2")).ToString.ToUpper
            txtApellidoCasNom.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellidocas")), " ", dts.Tables(0).Rows(0).Item("apellidocas")).ToString.ToUpper
            dtpNacimientoNomb.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Fecha_Nac")), Now, dts.Tables(0).Rows(0).Item("Fecha_Nac"))
            cbNacionalidadNomb.SelectedValue = dts.Tables(0).Rows(0).Item("codNacionalidad")
            cbEstadoCivilNomb.SelectedValue = dts.Tables(0).Rows(0).Item("codEstadoCivil")
            cbProfesionNomb.SelectedValue = dts.Tables(0).Rows(0).Item("codProfesion")
            'Seccion B juridica
            txtRazonSocialNomb.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("RazonSocial")), "", dts.Tables(0).Rows(0).Item("RazonSocial"))
            txtDirComercialNomb.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("direccionPJ")), "", dts.Tables(0).Rows(0).Item("direccionPJ"))
            txtNRCNomb.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NoRegContribuyente")), "", dts.Tables(0).Rows(0).Item("NoRegContribuyente"))
            txtNitNomb.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NitEmpresa")), "", dts.Tables(0).Rows(0).Item("NitEmpresa"))
            llenarActividadEconomicaSeccionB(dui)




        End If
    End Sub
    Private Sub uifEfectivo_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' sección a persona natural
        llenarDepartamentoSeccionA()
        llenarNacionalidadSeccionA()
        llenarEstadoCivilSeccionA()
        llenarProfesionSeccionA()
        llenarTipoDocumento()
        Dim dtsDomicilioA As New DataSet
        dtsDomicilioA = asociados.ConsultarDomicilios(dui)
        If dtsDomicilioA.Tables(0).Rows.Count > 0 Then
            cbDepartamentoInv.SelectedValue = dtsDomicilioA.Tables(0).Rows(0).Item("CodDepartamento")
            cbDepartamentoInv_Validated(sender, e)
            cbMunicipioInv.SelectedValue = dtsDomicilioA.Tables(0).Rows(0).Item("codMunicipio")
            txtDireccionInv.Text = dtsDomicilioA.Tables(0).Rows(0).Item("Direccion")
        End If
        ' seccion b persona natural 
        llenarDepartamentoSeccionBNat()
        llenarNacionalidadSeccionBNat()
        llenarEstadoCivilSeccionBNat()
        llenarProfesionSeccionBNat()
        llenarTipoDocumentoSeccionB()
        Dim dtsDomicilioB As New DataSet
        dtsDomicilioB = asociados.ConsultarDomicilios(dui)
        If dtsDomicilioB.Tables(0).Rows.Count > 0 Then
            cbDeptoNomb.SelectedValue = dtsDomicilioB.Tables(0).Rows(0).Item("CodDepartamento")
            cbDeptoNomb_Validated(sender, e)
            cbMunNomb.SelectedValue = dtsDomicilioB.Tables(0).Rows(0).Item("codMunicipio")
            txtDirNomb.Text = dtsDomicilioB.Tables(0).Rows(0).Item("Direccion")
        End If
        ' seccion c
        llenarDepartamentoSeccionCnat()
        llenarNacionalidadSeccionCNat()
        llenarEstadoCivilSeccionCNat()
        llenarProfesionSeccionCNat()
        llenarTipoDocumentoSeccionC()
        llenarDatosAsoc()
        ' datos de sucursal
        recuperarInformacionSucursal(codSucursal)
        ' datos transaccion 
        'txt
        recuperarInformacionTransaccion(idMovimiento)
        ' sujeto obligado
        recuperarDatosSujetoObligado()
    End Sub

    Private Sub btnGuardarA_Click(sender As Object, e As EventArgs) Handles btnGuardarA.Click
        Try
            If (asociados.ingresarFormularioUIFSeccionA(chkDistCliente.Checked, txtApeliidosInv.Text.ToUpper,
                                                    txtApellidoCasInv.Text.ToUpper, txtNombresInv.Text.ToUpper,
                                                    cbMunicipioInv.SelectedValue, cbDepartamentoInv.SelectedValue,
                                                    dtpNacInv.Value.ToShortDateString, cbNacionalidadInv.SelectedValue,
                                                    cbEstadoFamInv.SelectedValue, cbTipoDocInv.SelectedValue,
                                                    txtNoDocInv.Text.Trim, cbProfesionInv.SelectedValue,
                                                    txtDireccionInv.Text.ToUpper, My.Computer.Name.ToUpper.ToString,
                                                    sUsuario, idReporte)) > 0 Then
                MetroMessageBox.Show(Me, "Datos Ingresados exitosamente, por favor complementar las otras secciones.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, mensajeError, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbTipoDocNomb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoDocNomb.SelectedIndexChanged

    End Sub

    Private Sub MetroTabPage2_Click(sender As Object, e As EventArgs) Handles MetroTabPage2.Click

    End Sub

    Private Sub btnGuardarB_Click(sender As Object, e As EventArgs) Handles btnGuardarB.Click
        Try
            If (asociados.ingresarFormularioUIFSeccionBNatural(chkPerJur.Checked, txtApellidosNom.Text.ToUpper, txtApellidoCasNom.Text.ToUpper,
                                                               txtNombresNomb.Text.ToUpper, cbMunNomb.SelectedValue, cbDeptoNomb.SelectedValue,
                                                               cbEstadoCivilNomb.SelectedValue, cbTipoDocNomb.SelectedValue, txtNoDocNomb.Text.Trim,
                                                               cbProfesionNomb.SelectedValue, txtDirNomb.Text.ToUpper, id)) > 0 Then

                MetroMessageBox.Show(Me, "Datos Ingresados exitosamente, por favor complementar las otras secciones.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If


        Catch ex As Exception
            MetroMessageBox.Show(Me, mensajeError, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardarJurB_Click(sender As Object, e As EventArgs) Handles btnGuardarJurB.Click
        Try
            If (asociados.ingresarFormularioUIFSeccionBJuridica(txtRazonSocialNomb.Text.ToUpper, txtDirComercialNomb.Text.ToUpper, txtActEcoNomb.Text.Trim, txtNitNomb.Text.Trim, txtNRCNomb.Text.Trim, id)) > 0 Then
                MetroMessageBox.Show(Me, "Datos Ingresados exitosamente, por favor complementar las otras secciones.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MetroMessageBox.Show(Me, mensajeError, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



#End Region
    Dim ingreso As Boolean
    Dim esEfectivo As Boolean


    Private Sub btnSaveObligado_Click(sender As Object, e As EventArgs) Handles btnSaveObligado.Click
        asociados.ingresarFormularioUIF(chkDistCliente.Checked, txtApeliidosInv.Text.Trim,
                                        txtApellidoCasInv.Text.Trim, txtNombresInv.Text.Trim,
                                        cbMunicipioInv.SelectedValue, cbDepartamentoInv.SelectedValue,
                                        dtpNacInv.Value.ToShortDateString, cbNacionalidadInv.SelectedValue,
                                        cbEstadoFamInv.SelectedValue, cbTipoDocInv.SelectedIndex,
                                        txtNoDocInv.Text.Trim, cbProfesionInv.SelectedValue,
                                        txtDireccionInv.Text.Trim, chkPerJur.Checked,
                                        txtApellidosNom.Text.Trim, txtApellidoCasNom.Text.Trim,
                                        txtNombresNomb.Text.Trim, cbMunNomb.SelectedValue,
                                        cbDeptoNomb.SelectedValue, cbEstadoCivilNomb.SelectedValue,
                                        cbTipoDocNomb.SelectedIndex, txtNoDocNomb.Text.Trim,
                                        cbProfesionNomb.SelectedValue, txtDirNomb.Text.Trim,
                                        txtRazonSocialNomb.Text.Trim, txtDirComercialNomb.Text.Trim,
                                        txtActEcoNomb.Text.Trim, txtNitNomb.Text.Trim, txtNRCNomb.Text.Trim,
                                        chkJurBene.Checked, txtApellidosBene.Text.Trim,
                                        txtApellidoCasBene.Text.Trim, txtNombresBene.Text.Trim,
                                        cbMunBene.SelectedValue, cbDeptoBene.SelectedValue,
                                        cbEstadoFamBene.SelectedValue, cbTipoDocBene.SelectedValue,
                                        txtNoDocBene.Text.Trim, cbProfesionBene.SelectedValue,
                                        txtDirBene.Text.Trim, txtRazonSocialBene.Text.Trim,
                                        txtDirComercialBene.Text.Trim, txtCodActEcoBene.Text.Trim,
                                        txtNitBene.Text.Trim, txtNrcBene.Text.Trim,
                                        txtDirSucursal.Text.Trim, cbMunSucursal.SelectedValue,
                                        cbDeptoSucursal.SelectedValue, dtpFechaTran.Value.ToShortDateString,
                                        txtNumProdcuto.Text.Trim, txtClaseProducto.Text.Trim,
                                        ingreso, txtConcepto.Text.Trim,
                                        txtMonto.Text.Trim, esEfectivo,
                                        txtProcedencia.Text.Trim, txtColaborador.Text.Trim,
                                        txtCargoCol.Text.Trim, dtpFehaEnvioReporte.Value,
                                        "", "", "", "", "", "", "", "", My.Computer.Name.ToUpper.ToString,
                                        sUsuario, False)
    End Sub

    Private Sub txtActEcoNomb_Click(sender As Object, e As EventArgs) Handles txtActEcoNomb.Click

    End Sub

    Private Sub txtActEcoNomb_DoubleClick(sender As Object, e As EventArgs) Handles txtActEcoNomb.DoubleClick
        Dim frm As New frmMsConsultarActividadEconomica
        Dim dts As New DataSet
        frm.Text = "Buscar Actividad Económica"
        Try
            frm.ShowDialog()
            txtActEcoNomb.Text = frm.Resultado
            txtDescripcionActEcoNomb.Text = frm.Resultado2
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Ejecutivos Mercadeo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub uifEfectivo_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class