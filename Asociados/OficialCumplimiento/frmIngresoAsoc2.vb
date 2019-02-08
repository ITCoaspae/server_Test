Imports System.Text.RegularExpressions
Imports System.IO
Imports System.ComponentModel

Public Class frmIngresoAsoc2

#Region "Servicios Web"
    Dim cliente As New wrAsociados.wsLibAsoc
    Dim credPre As New wrCredito.wsLibCred
#End Region

#Region "variables locales"
    Dim vAccion As Integer
    Dim accionJur As Integer
    Dim idCatPersonaJuridica As Integer
    Dim idDeclaracionJurada As Integer
    Dim CorrelaticoDomi As Integer = 0
    Dim idPep As Integer
    Dim reingreso As Boolean = False  'variable para cambiar el estado del formulario, true= modificar,false= insertar
    Dim observacionIni As String = ""
#End Region

#Region "Propiedades Publicas"
    Public Property accion() As Integer
        Get
            Return Me.vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As New MemoryStream(byteArrayIn)
        Return Image.FromStream(ms)
    End Function
    Public Sub llenarDatos(dui As String)
        Dim dts As New DataSet
        dts = cliente.consultarCat_Asociados(dui)
        If dts.Tables(0).Rows.Count > 0 Then
            'Datos Personales
            'txtUltIngreso.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("fechaingresoAnt")), "", dts.Tables(0).Rows(0).Item("fechaingresoAnt"))
            txtDui.Text = dui
            txtNoPasaporte.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NumPasaporte")), "", dts.Tables(0).Rows(0).Item("NumPasaporte")).ToString.ToUpper
            cbEstadoIngreso.SelectedValue = dts.Tables(0).Rows(0).Item("EstadoIngreso")
            txtNoSocio.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NoSocio")), "", dts.Tables(0).Rows(0).Item("NoSocio"))
            chkPersonaJuridica.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("PersonaJuridica")), False, dts.Tables(0).Rows(0).Item("PersonaJuridica"))
            chkResidente.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Residente")), False, dts.Tables(0).Rows(0).Item("Residente"))
            txtNoResidente.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NoResidente")), " ", dts.Tables(0).Rows(0).Item("NoResidente")).ToString.ToUpper
            txtNombres.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Nombres")), " ", dts.Tables(0).Rows(0).Item("Nombres")).ToString.ToUpper
            txtPApellido.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellido1")), " ", dts.Tables(0).Rows(0).Item("apellido1")).ToString.ToUpper
            txtSApellido.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellido2")), " ", dts.Tables(0).Rows(0).Item("apellido2")).ToString.ToUpper
            txtACasada.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellidoCas")), " ", dts.Tables(0).Rows(0).Item("apellidoCas")).ToString.ToUpper
            txtConocidoPor.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("conocidoPor")), " ", dts.Tables(0).Rows(0).Item("conocidoPor")).ToString.ToUpper
            chkEsEmpleado.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("EsEmpleado")), False, dts.Tables(0).Rows(0).Item("EsEmpleado"))
            'llenarNacionalidad()
            Dim nacionalidad As String = dts.Tables(0).Rows(0).Item("codNacionalidad")
            Dim estadoCivil As Integer = dts.Tables(0).Rows(0).Item("codEstadoCivil")
            Me.cbNacionalidad.SelectedValue = dts.Tables(0).Rows(0).Item("codNacionalidad")
            chkDobleNacionalidad.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("dobleNacionalidad")), False, dts.Tables(0).Rows(0).Item("dobleNacionalidad"))
            If chkDobleNacionalidad.Checked = False Then
                Me.cb2Nacionalidad.Enabled = False
            End If
            If Me.chkResidente.Checked = False Then
                txtNoResidente.Enabled = False
            End If
            Me.cb2Nacionalidad.SelectedValue = dts.Tables(0).Rows(0).Item("codNacionalidad2")

            txtExtDui.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("lugarExtDui")), " ", dts.Tables(0).Rows(0).Item("lugarExtDui")).ToString.ToUpper
            cbProfesion.SelectedValue = dts.Tables(0).Rows(0).Item("codProfesion")
            dtpFecExtDui.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaExtDUI")), Now, dts.Tables(0).Rows(0).Item("FechaExtDUI"))
            dtpFechaNac.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Fecha_Nac")), Now, dts.Tables(0).Rows(0).Item("Fecha_Nac"))

            Me.cbGenero.SelectedIndex = dts.Tables(0).Rows(0).Item("sexo")
            Me.cbEstadoCivil.SelectedValue = dts.Tables(0).Rows(0).Item("codEstadoCivil")
            txtNit.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NIT")), "", dts.Tables(0).Rows(0).Item("NIT")).ToString.ToUpper
            txtIsss.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("ISSS")), "", dts.Tables(0).Rows(0).Item("ISSS")).ToString.ToUpper
            txtTelCasa.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("telCasa")), "", dts.Tables(0).Rows(0).Item("telCasa")).ToString.ToUpper
            txtCelular.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("celular")), "", dts.Tables(0).Rows(0).Item("celular")).ToString.ToUpper
            txtEmail.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("email")), "", dts.Tables(0).Rows(0).Item("email")).ToString.ToUpper.Trim

            'ultimos campos 
            cbPaisResidencia.SelectedValue = dts.Tables(0).Rows(0).Item("CodPaisResidencia")
            txtLugarNac.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("LugarNacimiento")), "", dts.Tables(0).Rows(0).Item("LugarNacimiento")).ToString.ToUpper
            dtpFechaVenciDui.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaVenciDUI")), Now, dts.Tables(0).Rows(0).Item("FechaVenciDUI"))
            ' llenarDepartamentos()
            '----------------------------------
            'Domicilio
            'If dts.Tables(0).Rows(0).Item("CodDepartamento") Is DBNull.Value = False Then
            '    Me.cbDepartamento.SelectedValue = dts.Tables(0).Rows(0).Item("CodDepartamento")
            'End If
            'If dts.Tables(0).Rows(0).Item("codMunicipio") Is DBNull.Value = False Then
            '    llenarMunicipio(dts.Tables(0).Rows(0).Item("CodDepartamento"))
            '    Me.cbMunicipio.SelectedValue = dts.Tables(0).Rows(0).Item("CodMunicipio")
            'End If
            'txtDireccion.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("direccion")), "", dts.Tables(0).Rows(0).Item("direccion")).ToString.ToUpper

            'Persona Juridica
            If chkPersonaJuridica.Checked = True Then
                Me.tpPerJur.Enabled = True
                chkPersonaJuridica.Enabled = False
                idCatPersonaJuridica = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("idCatPerJuridica")), 0, dts.Tables(0).Rows(0).Item("idCatPerJuridica"))
                Me.btnAddJuntaDir.Enabled = True
                txtRazonSocial.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("RazonSocial")), "", dts.Tables(0).Rows(0).Item("RazonSocial"))
                txtNomComercial.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NombreComercial")), "", dts.Tables(0).Rows(0).Item("NombreComercial"))
                txtRepLegal.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("RepresentanteLegal")), "", dts.Tables(0).Rows(0).Item("RepresentanteLegal"))
                txtNRC.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NoRegContribuyente")), "", dts.Tables(0).Rows(0).Item("NoRegContribuyente"))
                txtNitEmpresa.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NitEmpresa")), "", dts.Tables(0).Rows(0).Item("NitEmpresa"))
                txtTelEmpresa.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("TelPJ")), "", dts.Tables(0).Rows(0).Item("TelPJ"))
                cbDeptoJuridica.SelectedValue = dts.Tables(0).Rows(0).Item("codDeptoPJ")
                llenarMunicipioJur(dts.Tables(0).Rows(0).Item("codDeptoPJ"))
                cbMunicipioJur.SelectedValue = dts.Tables(0).Rows(0).Item("codMunPJ")
                txtDirJur.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("direccionPJ")), "", dts.Tables(0).Rows(0).Item("direccionPJ"))
                llenarJuntaDirectiva(idCatPersonaJuridica)
            End If

            'declaracion jurada
            If IIf(IsDBNull(dts.Tables(0).Rows(0).Item("idDeclaracionJurada")), 0, dts.Tables(0).Rows(0).Item("idDeclaracionJurada")) > 0 Then
                idDeclaracionJurada = dts.Tables(0).Rows(0).Item("idDeclaracionJurada")
                'idDeclaracion = dts.Tables(0).Rows(0).Item("idDeclaracionJurada")
                txtDepPromMen.Text = dts.Tables(0).Rows(0).Item("depositosPromMensual")
                'chkInversionista.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("inversionista")), False, dts.Tables(0).Rows(0).Item("inversionista"))
                txtRetPromMen.Text = dts.Tables(0).Rows(0).Item("retirosPromMensual")
                txtDestino.Text = dts.Tables(0).Rows(0).Item("PropositoCuenta")
                txtOrigenFondos.Text = dts.Tables(0).Rows(0).Item("origenFondos")
                txtPromDPF.Text = dts.Tables(0).Rows(0).Item("montoPromedioDpf")
                chkDocOrigen.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("presentoDocOrigenFondos")), False, dts.Tables(0).Rows(0).Item("presentoDocOrigenFondos"))
                txtOrigenFondosDpf.Text = dts.Tables(0).Rows(0).Item("origenFondosDpf")
                llenarDocumentos(idDeclaracionJurada)
            End If
            'informacion complementaria
            If dts.Tables(0).Rows(0).Item("idNivelEducacion") IsNot Nothing And dts.Tables(0).Rows(0).Item("idNivelEducacion") Is DBNull.Value = False Then
                cbNivelEducativo.SelectedValue = dts.Tables(0).Rows(0).Item("idNivelEducacion")
            End If
            If dts.Tables(0).Rows(0).Item("CodProfesionConyugue") IsNot Nothing And dts.Tables(0).Rows(0).Item("CodProfesionConyugue") Is DBNull.Value = False Then
                cbProfesionCon.SelectedValue = dts.Tables(0).Rows(0).Item("CodProfesionConyugue")
            End If
            If dts.Tables(0).Rows(0).Item("idEstadoVivienda") IsNot Nothing And dts.Tables(0).Rows(0).Item("idEstadoVivienda") Is DBNull.Value = False Then
                cbEstadoVivienda.SelectedValue = dts.Tables(0).Rows(0).Item("idEstadoVivienda")
            End If
            If dts.Tables(0).Rows(0).Item("codLugarTrabajoConyugue") IsNot Nothing And dts.Tables(0).Rows(0).Item("codLugarTrabajoConyugue") Is DBNull.Value = False Then
                cbTrabajoCon.SelectedValue = dts.Tables(0).Rows(0).Item("codLugarTrabajoConyugue")
            End If

            If dts.Tables(0).Rows(0).Item("CodProfesion") IsNot Nothing And dts.Tables(0).Rows(0).Item("CodProfesion") Is DBNull.Value = False Then
                Me.cbProfesion.SelectedValue = dts.Tables(0).Rows(0).Item("CodProfesion")
            End If

            txtTituloObtenido.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("TituloObtenido")), "", dts.Tables(0).Rows(0).Item("TituloObtenido"))
            txtNombreConyugue.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NombreConyugue")), "", dts.Tables(0).Rows(0).Item("NombreConyugue"))
            dtpFechaNacCon.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaNacConyugue")), Now, dts.Tables(0).Rows(0).Item("FechaNacConyugue"))

            txtOfiCon.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Oficio")), "", dts.Tables(0).Rows(0).Item("Oficio"))

            'tx.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("telefonoConyugue")), "", dts.Tables(0).Rows(0).Item("telefonoConyugue"))
            txtCodActEco.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("idActividadEconomicaConyugue")), "", dts.Tables(0).Rows(0).Item("idActividadEconomicaConyugue"))
            txtActEco.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("descripcionActEcoCony")), "", dts.Tables(0).Rows(0).Item("descripcionActEcoCony"))
            txtIngCon.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("SueldoConyugue")), 0, dts.Tables(0).Rows(0).Item("SueldoConyugue"))

            txtNumDep.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NumDependientes")), 0, dts.Tables(0).Rows(0).Item("NumDependientes"))
            txtNumGrupFam.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NumGrupoFam")), 0, dts.Tables(0).Rows(0).Item("NumGrupoFam"))

            txtAnioRes.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("TiempoResidencia")), "", dts.Tables(0).Rows(0).Item("TiempoResidencia"))

            'otros datos
            If dts.Tables(0).Rows(0).Item("EstadoAsociado") IsNot Nothing And dts.Tables(0).Rows(0).Item("EstadoAsociado") Is DBNull.Value = False Then
                cbEstadoAsoc.SelectedValue = dts.Tables(0).Rows(0).Item("EstadoAsociado")
            End If
            If dts.Tables(0).Rows(0).Item("CodEjecMercadeo") IsNot Nothing And dts.Tables(0).Rows(0).Item("CodEjecMercadeo") Is DBNull.Value = False Then
                cbEjecutivo.SelectedValue = dts.Tables(0).Rows(0).Item("CodEjecMercadeo")
            End If

            txtObservaciones.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Observaciones_Asociado")), " ", dts.Tables(0).Rows(0).Item("Observaciones_Asociado"))
            observacionIni = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Observaciones_Asociado")), " ", dts.Tables(0).Rows(0).Item("Observaciones_Asociado"))
            If dts.Tables(0).Rows(0).Item("CodCuota") IsNot Nothing And dts.Tables(0).Rows(0).Item("CodCuota") Is DBNull.Value = False Then
                cbCuotaIngreso.SelectedValue = dts.Tables(0).Rows(0).Item("CodCuota")
            End If

            Try
                If IsDBNull(dts.Tables(0).Rows(0).Item("Imagen")) = False Then
                    Dim foto As Byte()
                    Me.txtFoto.Image = ByteArrayToImage(dts.Tables(0).Rows(0).Item("Imagen"))
                End If
            Catch ex As Exception

            End Try
            Try
                If IsDBNull(dts.Tables(0).Rows(0).Item("Firmas")) = False Then
                    Dim foto As Byte()
                    Me.pbFirma.Image = ByteArrayToImage(dts.Tables(0).Rows(0).Item("Firmas"))
                End If
            Catch ex As Exception

            End Try

            'PEP
            If IIf(IsDBNull(dts.Tables(0).Rows(0).Item("idPep")), 0, dts.Tables(0).Rows(0).Item("idPep")) > 0 Then
                idPep = dts.Tables(0).Rows(0).Item("idPep")
                dtpFecNombramiento.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaNombramiento")), Now, dts.Tables(0).Rows(0).Item("FechaNombramiento"))
                txtPerNombramiento.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("PeriodoNombramiento")), "", dts.Tables(0).Rows(0).Item("PeriodoNombramiento"))
                cbTipoPep.SelectedValue = dts.Tables(0).Rows(0).Item("codTipoPep")
                txtAnioRes.Value = dts.Tables(0).Rows(0).Item("TiempoLaboral")
                chkVigente.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("PepActivo")), False, dts.Tables(0).Rows(0).Item("PepActivo"))
                cbGradPar.SelectedValue = dts.Tables(0).Rows(0).Item("codParentesco")
                llenarFamiliaresPep(idPep)
                llenarSociedadesPep(idPep)

            End If
            llenarRelacionesAsoc(txtDui.Text)
            llenarBeneficiarios(txtDui.Text)
            llenarReferencias(txtDui.Text)
            llenarActividadEconomica(txtDui.Text)
            llenarDomicilios(txtDui.Text)
        End If
    End Sub
#Region "LLenar Combos"
    Public Sub recuperarCatActividadEconomica(codigo As String)
        Dim dts As New DataSet
        Try
            dts = cliente.consultarCatActividadEconomica("0", "0", 4, codigo)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    Me.txtActEco.Text = dts.Tables(0).Rows(0).Item("descripcion").ToString
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
    Public Sub llenarEstadoIngreso()
        Dim dts As New DataSet
        Me.cbEstadoIngreso.DisplayMember = "Descripcion"
        Me.cbEstadoIngreso.ValueMember = "idCatalogo"
        dts = cliente.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.estadoIngreso,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbEstadoIngreso.DataSource = dts.Tables(0)

            End If
        End If
    End Sub
    Public Sub llenarNacionalidad()
        cbNacionalidad.DisplayMember = "Descripcion"
        Me.cbNacionalidad.ValueMember = "codNacionalidad"
        Dim dtsNac As New DataSet
        dtsNac = cliente.ConsultarNacionalidades("codNacionalidad,Descripcion", "", "descripcion", sUsuario, sPassword, sSucursal)
        If dtsNac.Tables(0).Rows.Count > 0 Then
            Me.cbNacionalidad.DataSource = dtsNac.Tables(0)
        End If
    End Sub
    Public Sub llenarPaisResidencia()
        cbPaisResidencia.DisplayMember = "Descripcion"
        Me.cbPaisResidencia.ValueMember = "codNacionalidad"
        Dim dtsNac3 As New DataSet
        dtsNac3 = cliente.ConsultarNacionalidades("codNacionalidad,Descripcion", "", "descripcion", sUsuario, sPassword, sSucursal)
        If dtsNac3.Tables(0).Rows.Count > 0 Then
            Me.cbPaisResidencia.DataSource = dtsNac3.Tables(0)
        End If
    End Sub
    Public Sub llenarNacionalidad2()
        cb2Nacionalidad.DisplayMember = "Descripcion"
        Me.cb2Nacionalidad.ValueMember = "codNacionalidad"
        Dim dtsNac2 As New DataSet
        dtsNac2 = cliente.ConsultarNacionalidades("codNacionalidad,Descripcion", "", "descripcion", sUsuario, sPassword, sSucursal)
        If dtsNac2.Tables(0).Rows.Count > 0 Then
            Me.cb2Nacionalidad.DataSource = dtsNac2.Tables(0)
        End If
    End Sub
    Public Sub llenarProfesiones()
        Me.cbProfesion.DisplayMember = "Descripcion"
        Me.cbProfesion.ValueMember = "codProfesion"
        Dim dts As New DataSet
        dts = cliente.ConsultarProfesiones("codProfesion,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbProfesion.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarEstadoCivil()
        Dim dts As New DataSet
        Me.cbEstadoCivil.DisplayMember = "Descripcion"
        Me.cbEstadoCivil.ValueMember = "idCatalogo"
        dts = cliente.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.estadoCivil,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbEstadoCivil.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarDepartamentos()
        Dim dtsDepto As New DataSet
        Me.cbDepartamento.DisplayMember = "Departamento"
        Me.cbDepartamento.ValueMember = "codDepartamento"
        dtsDepto = cliente.ConsultarDepartamentos("codDepartamento,Departamento", "", "Departamento", sUsuario, sPassword, sSucursal)
        If dtsDepto.Tables(0).Rows.Count > 0 Then
            Me.cbDepartamento.DataSource = dtsDepto.Tables(0)
        End If
    End Sub
    Public Sub llenarMunicipio(ByVal codDepartamento As String)
        Dim dtsMun As New DataSet
        cbMunicipio.DisplayMember = "Municipio"
        Me.cbMunicipio.ValueMember = "codMunicipio"
        dtsMun = cliente.ConsultarMunicipios("codMunicipio,Municipio", "codDepartamento='" & codDepartamento & "'", "Municipio", sUsuario, sPassword, sSucursal)
        If dtsMun.Tables(0).Rows.Count > 0 Then
            Me.cbMunicipio.DataSource = dtsMun.Tables(0)
        End If
    End Sub
    Public Sub llenarDepartamentoJur()
        Dim dtsDeptoJur As New DataSet
        Me.cbDeptoJuridica.DisplayMember = "Departamento"
        Me.cbDeptoJuridica.ValueMember = "codDepartamento"
        dtsDeptoJur = cliente.ConsultarDepartamentos("codDepartamento,Departamento", "", "Departamento", sUsuario, sPassword, sSucursal)
        If dtsDeptoJur.Tables(0).Rows.Count > 0 Then
            Me.cbDeptoJuridica.DataSource = dtsDeptoJur.Tables(0)
        End If
    End Sub
    Public Sub llenarMunicipioJur(codDepartamento As String)
        Dim dtsMunJur As New DataSet
        Me.cbMunicipioJur.DisplayMember = "Municipio"
        Me.cbMunicipioJur.ValueMember = "codMunicipio"
        dtsMunJur = cliente.ConsultarMunicipios("codMunicipio,Municipio", "codDepartamento='" & codDepartamento & "'", "Municipio", sUsuario, sPassword, sSucursal)
        If dtsMunJur.Tables(0).Rows.Count > 0 Then
            Me.cbMunicipioJur.DataSource = dtsMunJur.Tables(0)
        End If
    End Sub
    Public Sub llenarTipoPep()
        Dim dts As New DataSet
        Me.cbTipoPep.DisplayMember = "Descripcion"
        Me.cbTipoPep.ValueMember = "idCatalogo"
        dts = cliente.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.tipoPEP,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbTipoPep.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarGradoParentesco()
        Dim dts As New DataSet
        Me.cbGradPar.DisplayMember = "Descripcion"
        Me.cbGradPar.ValueMember = "idCatalogo"
        dts = cliente.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.gradoParentesco,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbGradPar.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarNivelEducativo()
        Dim dts As New DataSet
        Me.cbNivelEducativo.DisplayMember = "Descripcion"
        Me.cbNivelEducativo.ValueMember = "idCatalogo"
        dts = cliente.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.nivelEducativo,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbNivelEducativo.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarProfesionesConyugue()
        Me.cbProfesionCon.DisplayMember = "Descripcion"
        Me.cbProfesionCon.ValueMember = "codProfesion"
        Dim dts As New DataSet
        dts = cliente.ConsultarProfesiones("codProfesion,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbProfesionCon.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarEstadoVivienda()
        Dim dts As New DataSet
        Me.cbEstadoVivienda.DisplayMember = "Descripcion"
        Me.cbEstadoVivienda.ValueMember = "idCatalogo"
        dts = cliente.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.estadoVivienda,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbEstadoVivienda.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarEstadoAsociado()
        Dim dts As New DataSet
        Me.cbEstadoAsoc.DisplayMember = "Descripcion"
        Me.cbEstadoAsoc.ValueMember = "idCatalogo"
        dts = cliente.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.estadoAsociado,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbEstadoAsoc.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarEjecutivos()
        Dim dtsEjec As New DataSet
        cbEjecutivo.DisplayMember = "Nombres"
        cbEjecutivo.ValueMember = "CodEjecMercadeo"
        If accion = 1 Then
            dtsEjec = cliente.ConsultarEjecutivosMercadeoxFiltro(" a.estado = '1'", sUsuario, sPassword, sSucursal)
        Else
            dtsEjec = cliente.ConsultarEjecutivosMercadeoxFiltro(" a.estado in ('1','0') ", sUsuario, sPassword, sSucursal)
        End If

        If dtsEjec.Tables(0).Rows.Count > 0 Then
            Me.cbEjecutivo.DataSource = dtsEjec.Tables(0)
        End If
    End Sub
    Public Sub llenarCuotaIngreso()
        Dim dts As New DataSet
        Me.cbCuotaIngreso.DisplayMember = "descripcion"
        Me.cbCuotaIngreso.ValueMember = "codCuota"
        If accion = 1 Then
            dts = cliente.ConsultarTipoCuota("codCuota,Descripcion", "estado = '1' ", "Descripcion", sUsuario, sPassword, sSucursal)
        Else
            dts = cliente.ConsultarTipoCuota("codCuota,Descripcion", "estado  in ('1','0') ", "Descripcion", sUsuario, sPassword, sSucursal)
        End If

        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbCuotaIngreso.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarLugarTrabajo()
        Dim dts As New DataSet
        Me.cbTrabajoCon.ValueMember = "codPagaduria"
        Me.cbTrabajoCon.DisplayMember = "nombre"
        dts = credPre.consultarPrPagadurias("", "", 0)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbTrabajoCon.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
#End Region
#Region "Llenar Grid"
    'LUIS ALVARENGA
    Public Sub llenarDomicilios(dui As String)
        Try
            Me.dgDirecciones.DataSource = Nothing
            Dim dts As New DataSet
            dts = cliente.ConsultarDomicilios(dui)
            If dts.Tables(0).Rows.Count > 0 Then

                Me.dgDirecciones.DataSource = dts.Tables(0)
                Me.dgDirecciones.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
                Me.dgDirecciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                Me.dgDirecciones.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                Me.dgDirecciones.Columns("Direccion").Width = 500
                Me.dgDirecciones.Columns("Correlativo").Visible = True
                Me.dgDirecciones.Columns("DUI").Visible = False

                Me.dgDirecciones.Columns("Direccion").HeaderText = "Direccion"
                Me.dgDirecciones.Columns("CodMunicipio").Visible = False
                Me.dgDirecciones.Columns("CodDepartamento").Visible = False
                Me.dgDirecciones.Columns("Estado").Visible = False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub llenarActividadEconomica(dui As String)
        Try
            Dim dts As New DataSet
            dts = cliente.consultarAsocActividadEconomia(dui, False, 2, 0)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    Dim total As Double = 0
                    For i As Integer = 0 To dts.Tables(0).Rows.Count - 1
                        total = total + dts.Tables(0).Rows(i).Item("Ingresos")
                    Next
                    txtTotalIngresos.Text = total

                End If
            End If
            Me.dgActEco.DataSource = dts.Tables(0)
            Me.dgActEco.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
            Me.dgActEco.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            Me.dgActEco.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke


        Catch ex As Exception

        End Try

    End Sub
    Public Sub llenarReferencias(dui As String)
        Try
            Me.dgReferenciaPersonal.DataSource = Nothing
            Dim dts As New DataSet
            dts = cliente.ConsultarReferencias("NumRef,Nombre,apellido1,apellido2,direccion,telCasa,lugarTrabajo,cargo,direccionTrabajo,telOficina,emails,codParentesco",
                                                 " dui = '" & dui & "' ", "", sUsuario, sPassword, sSucursal)
            If dts.Tables(0).Rows.Count > 0 Then

                Me.dgReferenciaPersonal.DataSource = dts.Tables(0)
                Me.dgReferenciaPersonal.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
                Me.dgReferenciaPersonal.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                Me.dgReferenciaPersonal.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

                Me.dgReferenciaPersonal.Columns("NumRef").Visible = False
                Me.dgReferenciaPersonal.Columns("codParentesco").Visible = False


                Me.dgReferenciaPersonal.Columns("Nombre").HeaderText = "Nombre"
                Me.dgReferenciaPersonal.Columns("apellido1").HeaderText = "Primer Apellido"
                Me.dgReferenciaPersonal.Columns("apellido2").HeaderText = "Segundo Apellido"
                Me.dgReferenciaPersonal.Columns("direccion").HeaderText = "Dirección"
                Me.dgReferenciaPersonal.Columns("telCasa").HeaderText = "Tel. Casa"
                Me.dgReferenciaPersonal.Columns("lugarTrabajo").HeaderText = "Lugar Trabajo"
                Me.dgReferenciaPersonal.Columns("cargo").HeaderText = "Cargo"
                Me.dgReferenciaPersonal.Columns("direccionTrabajo").HeaderText = "Dirección Trabajo"
                Me.dgReferenciaPersonal.Columns("telOficina").HeaderText = "Tel. Oficina"
                Me.dgReferenciaPersonal.Columns("emails").HeaderText = "Email"
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub llenarBeneficiarios(dui As String)
        Try
            Me.dgBeneficiarios.DataSource = Nothing
            Dim dts As New DataSet
            dts = cliente.ConsultarBeneficiarios("correlativo,Nombres,Apellido1,apellido2,apellidoCas,codParentesco,porcentBeneficio,direccion,telCasa,telOficina,emails,duiBeneficiario,TipoDoc,sexo",
                                                   " dui = '" & dui & "' ", " correlativo", sUsuario,
                                                   sPassword, sSucursal)
            If dts.Tables(0).Rows.Count > 0 Then

                Me.dgBeneficiarios.DataSource = dts.Tables(0)
                Me.dgBeneficiarios.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
                Me.dgBeneficiarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                Me.dgBeneficiarios.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

                Me.dgBeneficiarios.Columns("correlativo").Visible = False
                Me.dgBeneficiarios.Columns("codParentesco").Visible = False
                Me.dgBeneficiarios.Columns("TipoDoc").Visible = False
                Me.dgBeneficiarios.Columns("sexo").Visible = False


                Me.dgBeneficiarios.Columns("Nombres").HeaderText = "Nombres"
                Me.dgBeneficiarios.Columns("apellido1").HeaderText = "Primer Apellido"
                Me.dgBeneficiarios.Columns("apellido2").HeaderText = "Segundo Apellido"
                Me.dgBeneficiarios.Columns("direccion").HeaderText = "Dirección"
                Me.dgBeneficiarios.Columns("telCasa").HeaderText = "Tel. Casa"
                Me.dgBeneficiarios.Columns("telOficina").HeaderText = "Tel. Oficina"
                Me.dgBeneficiarios.Columns("emails").HeaderText = "Email"
                Me.dgBeneficiarios.Columns("duiBeneficiario").HeaderText = "No. Documento"
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub llenarRelacionesAsoc(dui As String)
        Try
            Dim dts As New DataSet
            Me.dgRelaciones.DataSource = Nothing
            dts = cliente.consultarAsocRelacionesAsociado(dui)
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgRelaciones.DataSource = dts.Tables(0)
                Me.dgRelaciones.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
                Me.dgRelaciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                Me.dgRelaciones.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

                Me.dgRelaciones.Columns("duiRelacion").HeaderText = "DUI"
                Me.dgRelaciones.Columns("Descripcion").HeaderText = "Parentesco"


                Me.dgRelaciones.Columns("correlativo").Visible = False
                Me.dgRelaciones.Columns("dui").Visible = False
                Me.dgRelaciones.Columns("CodParentesco").Visible = False

                Me.dgRelaciones.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            End If
        Catch ex As Exception

        End Try

    End Sub
    Public Sub llenarSociedadesPep(idPep As Integer)
        Try
            Me.dgSociedades.DataSource = Nothing
            Dim dts As New DataSet
            dts = cliente.consultarAsocPep_Sociedades(idPep)
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgSociedades.DataSource = dts.Tables(0)
                Me.dgSociedades.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
                Me.dgSociedades.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                Me.dgSociedades.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

                Me.dgSociedades.Columns("idSociedad").Visible = False
                Me.dgSociedades.Columns("idpep").Visible = False

                Me.dgSociedades.Columns("sociedad").HeaderText = "Sociedad"
                Me.dgSociedades.Columns("porcentajeParticipacion").HeaderText = "Porcentaje de Participación"
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub llenarFamiliaresPep(idPep As Integer)
        Try
            Me.dgFamPep.DataSource = Nothing
            Dim dts As New DataSet
            dts = cliente.consultarAsocPep_Familiares(idPep)
            If dts.Tables.Count > 0 Then
                Me.dgFamPep.DataSource = dts.Tables(0)
                Me.dgFamPep.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
                Me.dgFamPep.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                Me.dgFamPep.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

                Me.dgFamPep.Columns("idFamiliarPep").Visible = False
                Me.dgFamPep.Columns("idpep").Visible = False
                Me.dgFamPep.Columns("codTipoFamiliar").Visible = False

                Me.dgFamPep.Columns("tipoFamiliar").HeaderText = "Tipo de Familiar"
                Me.dgFamPep.Columns("nombres").HeaderText = "Nombres"
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub llenarJuntaDirectiva(idPerJur As Integer)
        Try
            Me.dgJuntaDir.DataSource = Nothing
            Dim dts As New DataSet
            dts = cliente.consultarAsocPersonaJuridicaDirectivos(idPerJur)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    Me.dgJuntaDir.DataSource = dts.Tables(0)
                    Me.dgJuntaDir.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
                    Me.dgJuntaDir.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                    Me.dgJuntaDir.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                    Me.dgJuntaDir.Columns("Nombres").HeaderText = "Nombre"
                    Me.dgJuntaDir.Columns("Cargo").HeaderText = "Cargo"
                    Me.dgJuntaDir.Columns("Activo").HeaderText = "Activo"
                    Me.dgJuntaDir.Columns("idJuntaDirectiva").Visible = False
                    Me.dgJuntaDir.Columns("idCatPerJuridica").Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de la información, comunicarse con el administrador de sistema", MsgBoxStyle.Critical)
        End Try

    End Sub
    Public Sub llenarDocumentos(idDeclaracion As Integer)
        Try
            Me.dgDocumentos.DataSource = Nothing
            Dim dts As New DataSet
            dts = cliente.consultarAsocDeclaracionJuradaDocumentos(idDeclaracion, 0, 1)
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgDocumentos.DataSource = dts.Tables(0)
                Me.dgDocumentos.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
                Me.dgDocumentos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                Me.dgDocumentos.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

                Me.dgDocumentos.Columns("idDoc").HeaderText = "Id. Documento"
                Me.dgDocumentos.Columns("Descripcion").HeaderText = "Tipo de Documento"
                Me.dgDocumentos.Columns("FechaPresentacion").HeaderText = "Fecha de Entrega de Documento"
                Me.dgDocumentos.Columns("presentoDocumento").HeaderText = "Presento Documento"
                Me.dgDocumentos.Columns("Plazo").HeaderText = "Plazo"

                Me.dgDocumentos.Columns("idDeclaracionJurada").Visible = False
                Me.dgDocumentos.Columns("idDocumento").Visible = False
                Me.dgDocumentos.Columns("PlazoPresentacion").Visible = False

                Me.dgDocumentos.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                Me.dgDocumentos.Columns("FechaPresentacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                Me.dgDocumentos.Columns("idDoc").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                Me.dgDocumentos.Columns("presentoDocumento").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                Me.dgDocumentos.Columns("Plazo").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            End If
        Catch ex As Exception

        End Try

    End Sub
#End Region

#End Region
    Private Sub frmIngresoAsoc2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Llenamos catalogos 
            llenarEstadoIngreso()
            llenarNacionalidad()
            llenarNacionalidad2()
            llenarPaisResidencia()
            llenarProfesiones()
            llenarEstadoCivil()
            llenarDepartamentos()
            llenarDepartamentoJur()
            llenarTipoPep()
            llenarGradoParentesco()
            llenarNivelEducativo()
            llenarEstadoVivienda()
            llenarEstadoAsociado()
            llenarEjecutivos()
            llenarCuotaIngreso()
            llenarProfesionesConyugue()
            llenarLugarTrabajo()
            Me.cbEstadoIngreso.Enabled = False
            Me.cbEstadoAsoc.Enabled = False

            If accion = 1 Then
                Me.cbEstadoIngreso.SelectedValue = 1
                '  Me.cbEstadoIngreso.Visible = False
                '  Me.lblEstadoIngreso.Visible = False
                Me.btnGuardarJur.Enabled = False
                Me.btnGuardarDom.Enabled = False
                Me.btnGuardarJur.Enabled = False
                Me.btnAddActEco.Enabled = False
                Me.btnGuardarDecJur.Enabled = False
                Me.btnGuardarPep.Enabled = False
                Me.btnGuardarComp.Enabled = False
                Me.btnAddRefPer.Enabled = False
                Me.btnAddBen.Enabled = False
                Me.btnRelaciones.Enabled = False
                Me.btnGuardarOtros.Enabled = False
                tpPerJur.Enabled = False
                cb2Nacionalidad.Enabled = False
            ElseIf accion = 2 Then
                llenarDatos(txtDui.Text)
                If chkPersonaJuridica.Checked = True Then
                    tpPerJur.Enabled = True
                Else
                    tpPerJur.Enabled = False
                End If
                Me.btnGuardarJur.Enabled = True
                Me.btnGuardarDom.Enabled = True
                Me.btnGuardarJur.Enabled = True
                Me.btnAddActEco.Enabled = True
                Me.btnGuardarDecJur.Enabled = True
                Me.btnGuardarPep.Enabled = True
                Me.btnGuardarComp.Enabled = True
                Me.btnAddRefPer.Enabled = True
                Me.btnAddBen.Enabled = True
                Me.btnRelaciones.Enabled = True
                Me.btnGuardarOtros.Enabled = True
            Else
                llenarDatos(txtDui.Text)
                Me.btnGuardarNat.Enabled = False
                Me.btnGuardarJur.Enabled = False
                Me.btnGuardarDom.Enabled = False
                Me.btnGuardarJur.Enabled = False
                Me.btnAddActEco.Enabled = False
                Me.btnGuardarDecJur.Enabled = False
                Me.btnGuardarPep.Enabled = False
                Me.btnGuardarComp.Enabled = False
                Me.btnAddRefPer.Enabled = False
                Me.btnAddBen.Enabled = False
                Me.btnRelaciones.Enabled = False
                Me.btnGuardarOtros.Enabled = False
            End If
        Catch ex As Exception

        End Try
    End Sub
#Region "Funciones"
    Public Function ingresarPersonaNatural(campos As String, valores As String) As Integer

    End Function
    Public Function ingresarDomicilio(campos As String, valores As String) As Integer

    End Function
    Public Function ingresarPersonaJuridica(campos As String, valores As String) As Integer

    End Function

#End Region
#Region "Validaciones"
    Public Function validarReingreso(dui As String) As Boolean
        Dim esReingreso As Boolean
        Dim dts As New DataSet
        'dts = asociado.consulta
    End Function
    Public Function isValidaFechaNacimiento(fecha As DateTime) As Boolean
        If DateDiff(DateInterval.Year, fecha, Now) < 18 Or DateDiff(DateInterval.Year, fecha, Now) > 100 Then
            MsgBox("Fecha de nacimiento invalida.", MsgBoxStyle.Critical)
            Return False
        Else
            Return True
        End If

        'If DateDiff(DateInterval.Year, fecha, Now) > 100 Then
        '    MsgBox("Fecha de nacimiento invalida.", MsgBoxStyle.Critical)
        '    Return False
        'End If
    End Function

    Public Function isValidoEmail(email As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" &
       "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(email, pattern)
        If emailAddressMatch.Success Then
            Return True
        Else
            MsgBox("Formato de correo electronico incorrecto", MsgBoxStyle.Critical)
            Return False
        End If

    End Function
#End Region
#Region "Eventos"

    Private Sub btnGuardarNat_Click(sender As Object, e As EventArgs) Handles btnGuardarNat.Click
        ' MsgBox(My.Computer.Name.ToString)
        If isValidaFechaNacimiento(dtpFechaNac.Value) = False Then
            Exit Sub
        End If

        If txtEmail.Text.Length > 0 Then
            If isValidoEmail(txtEmail.Text.Trim) = False Then
                Exit Sub
            End If
        End If
        If requeridosPersonaNatural() = True Then
            If accion = 1 Then 'insertar
                Dim correlativo As String
                correlativo = cliente.ObtenerCorrelativoAsociado("NoSocio", sUsuario, sPassword, sSucursal)
                If correlativo = "0" Then
                    MsgBox(mensajeError, MsgBoxStyle.Critical)
                    Exit Sub
                End If

                txtNoSocio.Text = correlativo 'cliente.ObtenerCorrelativoAsociado("NoSocio", sUsuario, sPassword, sSucursal)
                If txtNoSocio.Text.Length > 0 Then
                    If (cliente.insertarCat_Asociados(txtDui.Text.Trim, txtNit.Text.Trim, txtIsss.Text.Trim, txtExtDui.Text.ToUpper.Trim, dtpFecExtDui.Value.ToShortDateString,
                                              txtNoPasaporte.Text.Trim, cbEstadoIngreso.SelectedValue, txtPApellido.Text.Trim.ToUpper, txtSApellido.Text.ToUpper.Trim, txtACasada.Text.ToUpper.Trim,
                                              txtNombres.Text.ToUpper.Trim, dtpFechaNac.Value.ToShortDateString, txtTelCasa.Text.Trim, txtCelular.Text.Trim, txtEmail.Text.Trim, cbProfesion.SelectedValue,
                                              cbNacionalidad.SelectedValue, cbGenero.SelectedIndex.ToString, chkResidente.Checked, txtNoResidente.Text.Trim, chkPersonaJuridica.Checked,
                                              txtConocidoPor.Text.ToUpper.Trim, chkDobleNacionalidad.Checked, cb2Nacionalidad.SelectedValue, txtNoSocio.Text.Trim, cbEstadoCivil.SelectedValue, cbPaisResidencia.SelectedValue, txtLugarNac.Text.ToUpper.Trim,
                                                      dtpFechaVenciDui.Value.ToShortDateString, chkEsEmpleado.Checked, sUsuario.ToUpper, My.Computer.Name.ToUpper.ToString)) > 0 Then
                        txtDui.Enabled = False
                        Me.btnGuardarJur.Enabled = True
                        Me.btnGuardarDom.Enabled = True
                        Me.btnGuardarJur.Enabled = True
                        Me.btnAddActEco.Enabled = True
                        Me.btnGuardarDecJur.Enabled = True
                        Me.btnGuardarPep.Enabled = True
                        Me.btnGuardarComp.Enabled = True
                        Me.btnAddRefPer.Enabled = True
                        Me.btnAddBen.Enabled = True
                        Me.btnRelaciones.Enabled = True
                        Me.btnGuardarOtros.Enabled = True
                        MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information)

                    Else
                        MsgBox("Registro no fue ingresado, Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
                    End If
                Else
                    MsgBox("Error al generar código de asociado. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
                End If


            ElseIf accion = 2 Then

                If (cliente.modificarCat_Asociados(txtDui.Text.Trim, txtNit.Text.Trim, txtIsss.Text.Trim, txtExtDui.Text.ToUpper.Trim, dtpFecExtDui.Value.ToShortDateString,
                                              txtNoPasaporte.Text.Trim, cbEstadoIngreso.SelectedValue, txtPApellido.Text.Trim.ToUpper, txtSApellido.Text.ToUpper.Trim, txtACasada.Text.ToUpper.Trim,
                                              txtNombres.Text.ToUpper.Trim, dtpFechaNac.Value.ToShortDateString, txtTelCasa.Text.Trim, txtCelular.Text.Trim, txtEmail.Text.Trim, cbProfesion.SelectedValue,
                                              cbNacionalidad.SelectedValue, cbGenero.SelectedIndex.ToString, chkResidente.Checked, txtNoResidente.Text.Trim, chkPersonaJuridica.Checked,
                                              txtConocidoPor.Text.ToUpper.Trim, chkDobleNacionalidad.Checked, cb2Nacionalidad.SelectedValue, txtNoSocio.Text.Trim, cbEstadoCivil.SelectedValue,
                                              cbPaisResidencia.SelectedValue, txtLugarNac.Text.ToUpper.Trim, dtpFechaVenciDui.Value.ToShortDateString, chkEsEmpleado.Checked,
                                              sUsuario.ToUpper, My.Computer.Name.ToUpper.ToString)) > 0 Then

                    MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information)
                Else
                    MsgBox("Registro no fue actualizado, Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    Private Sub btnGuardarDom_Click(sender As Object, e As EventArgs) Handles btnGuardarDom.Click
        Try
            If requeridosDomicilio() = True Then
                If CorrelaticoDomi = 0 Then ' si es una direccion nueva
                    txtTipoOperacion.Text = 1
                End If
                If CorrelaticoDomi > 0 Then ' si se va a modificar
                    txtTipoOperacion.Text = 2
                End If

                If cliente.insertar_CatAsociados_Domicilio(txtTipoOperacion.Text, CorrelaticoDomi, txtDui.Text, txtDireccion.Text.ToUpper.Trim, cbMunicipio.SelectedValue, cbDepartamento.SelectedValue, chkActual.Checked) > 0 Then
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information)
                    llenarDomicilios(txtDui.Text)
                    Me.btnNuevoDomicilio_Click(sender, e)
                Else
                    MsgBox("Registro no fue ingresado, Por favor comunicarse con el administrador de sistema." & Err.Description.ToString, MsgBoxStyle.Critical)
                End If

            End If

        Catch ex As Exception
            MsgBox("Error al generar código de asociado. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnGuardarJur_Click(sender As Object, e As EventArgs) Handles btnGuardarJur.Click
        Try
            If requeridosPerJur() = True Then
                Dim dts As New DataSet
                If txtNoSocio.Text.Length > 0 Then
                    dts = cliente.consultarCatPersonaJuridica(txtNoSocio.Text)
                    If dts IsNot Nothing Then
                        If dts.Tables.Count > 0 Then
                            If dts.Tables(0).Rows.Count > 0 Then
                                idCatPersonaJuridica = dts.Tables(0).Rows(0).Item("IdCatPerJuridica")
                                accionJur = 2
                            Else
                                accionJur = 1
                            End If
                        Else
                            accionJur = 1
                        End If
                    Else
                        accionJur = 1
                    End If

                Else
                    accionJur = 1
                End If


                If accionJur = 1 Then
                    If (cliente.insertar_catPersonaJuridica(txtDui.Text.Trim, txtRazonSocial.Text.Trim.ToUpper, txtNomComercial.Text.ToUpper.Trim, txtRepLegal.Text.ToUpper,
                                                    txtNRC.Text.Trim, txtNitEmpresa.Text, txtTelEmpresa.Text, cbDeptoJuridica.SelectedValue, cbMunicipioJur.SelectedValue,
                                                    txtDirJur.Text.ToUpper.Trim, txtNoSocio.Text)) > 0 Then
                        MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information)
                    Else
                        MsgBox("Registro no ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical)
                    End If
                ElseIf accionJur = 2 Then

                    If idCatPersonaJuridica <> 0 Then
                        If (cliente.modificarPersonaJuridica(txtDui.Text.Trim, txtRazonSocial.Text.Trim.ToUpper, txtNomComercial.Text.ToUpper.Trim, txtRepLegal.Text.ToUpper,
                                                    txtNRC.Text.Trim, txtNitEmpresa.Text, txtTelEmpresa.Text, cbDeptoJuridica.SelectedValue, cbMunicipioJur.SelectedValue,
                                                    txtDirJur.Text.ToUpper.Trim, idCatPersonaJuridica)) > 0 Then
                            MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information)
                        Else
                            MsgBox("Registro no actualizado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical)

                        End If
                    Else
                        MsgBox("No se encontro información de persona jurídica.", MsgBoxStyle.Critical)
                    End If

                End If
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnGuardarDecJur_Click(sender As Object, e As EventArgs) Handles btnGuardarDecJur.Click
        Try
            If requeridosDecJur() = True Then
                Dim dts As New DataSet
                dts = cliente.consultarAsocDeclaracionJurada(txtNoSocio.Text.Trim)
                If dts IsNot Nothing Then
                    If dts.Tables.Count > 0 Then
                        If dts.Tables(0).Rows.Count > 0 Then
                            If cliente.modificarAsocDeclaracionJurada(idDeclaracionJurada, txtDepPromMen.Text,
                                                               False, txtRetPromMen.Text,
                                                               txtDestino.Text.Trim.ToUpper, txtOrigenFondos.Text.Trim.ToUpper,
                                                               txtPromDPF.Text, txtOrigenFondosDpf.Text) > 0 Then
                                MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information)
                            Else
                                MsgBox("Registro no actualizado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical)
                            End If
                        Else 'crear declaracion 
                            idDeclaracionJurada = cliente.generarIdDeclaracionJurada()
                            If cliente.insertarAsocDeclaracionJurada(txtNoSocio.Text, txtDepPromMen.Text, False,
                                                              txtRetPromMen.Text, txtDestino.Text.Trim.ToUpper, txtOrigenFondos.Text.Trim.ToUpper, txtPromDPF.Text,
                                                              txtOrigenFondosDpf.Text, idDeclaracionJurada) > 0 Then
                                MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information)
                            Else
                                MsgBox("Registro no ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical)
                            End If
                        End If
                    End If
                Else
                    idDeclaracionJurada = cliente.generarIdDeclaracionJurada()
                    If cliente.insertarAsocDeclaracionJurada(txtNoSocio.Text, txtDepPromMen.Text, False,
                                                      txtRetPromMen.Text, txtDestino.Text.Trim.ToUpper, txtOrigenFondos.Text.Trim.ToUpper, txtPromDPF.Text,
                                                      txtOrigenFondosDpf.Text, idDeclaracionJurada) > 0 Then
                        MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information)
                    Else
                        MsgBox("Registro no ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical)
                    End If
                End If


            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub btnGuardarPep_Click(sender As Object, e As EventArgs) Handles btnGuardarPep.Click
        Try
            If requeridosPep() = True Then
                Dim dts As New DataSet
                dts = cliente.consultarAsocPep(txtDui.Text.Trim)
                If dts IsNot Nothing Then
                    If dts.Tables.Count > 0 Then
                        If dts.Tables(0).Rows.Count > 0 Then 'Modificar
                            If cliente.modificarAsocPep(idPep, dtpFecNombramiento.Value.ToShortDateString,
                                                        cbTipoPep.SelectedValue, txtAniosPep.Value,
                                                        txtPerNombramiento.Text.Trim.ToUpper, chkVigente.Checked,
                                                        cbGradPar.SelectedValue) Then
                                MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information)
                            Else
                                MsgBox("Registro no actualizado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical)
                            End If
                        Else
                            idPep = cliente.generarIdPep()
                            If idPep > 0 Then
                                If cliente.insertar_AsocPep(txtDui.Text, dtpFecNombramiento.Value.ToShortDateString,
                                                     cbTipoPep.SelectedValue, txtAniosPep.Value, idPep, txtPerNombramiento.Text.Trim.ToUpper, chkVigente.Checked, cbGradPar.SelectedValue) > 0 Then
                                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information)
                                Else
                                    MsgBox("Registro no ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical)
                                End If
                            End If

                        End If
                    End If
                Else
                    idPep = cliente.generarIdPep()
                    If idPep > 0 Then
                        If cliente.insertar_AsocPep(txtDui.Text, dtpFecNombramiento.Value.ToShortDateString,
                                             cbTipoPep.SelectedValue, txtAniosPep.Value, idPep, txtPerNombramiento.Text.Trim.ToUpper, chkVigente.Checked, cbGradPar.SelectedValue) > 0 Then
                            MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information)
                        Else
                            MsgBox("Registro no ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical)
                        End If
                    End If
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardarComp_Click(sender As Object, e As EventArgs) Handles btnGuardarComp.Click
        Try
            If requeridosInfComp() = True Then
                cliente.insertar_CatAsociados_InfComplementaria(txtDui.Text, txtTituloObtenido.Text.Trim.ToUpper,
                                                            txtNombreConyugue.Text.Trim.ToUpper, txtNumGrupFam.Value,
                                                            txtNumDep.Value, cbEstadoVivienda.SelectedValue,
                                                            txtAnioRes.Value, cbNivelEducativo.SelectedValue,
                                                            dtpFechaNacCon.Value.ToShortDateString, cbProfesionCon.SelectedValue,
                                                            txtOfiCon.Text.Trim.ToUpper, txtCodActEco.Text,
                                                            txtIngCon.Text, cbTrabajoCon.SelectedValue,
                                                            "")
                MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information)
            Else
                MsgBox("Registro no fue ingresado, Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox("Error al generar código de asociado. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnGuardarOtros_Click(sender As Object, e As EventArgs) Handles btnGuardarOtros.Click
        Try
            Dim ms As New System.IO.MemoryStream
            Dim firma As New System.IO.MemoryStream
            If txtFoto.Image IsNot Nothing Then
                txtFoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If
            If pbFirma.Image IsNot Nothing Then
                pbFirma.Image.Save(firma, System.Drawing.Imaging.ImageFormat.Jpeg)
            End If



            If (cliente.insertar_CatAsociados_OtrosDatos(txtDui.Text, cbEstadoAsoc.SelectedValue,
                                                     ms.GetBuffer, cbEjecutivo.SelectedValue,
                                                     txtObservaciones.Text.Trim.ToUpper, txtNoSocio.Text,
                                                     sUsuario, Now, sSucursal, cbCuotaIngreso.SelectedValue, accion, firma.GetBuffer)) > 0 Then
                MsgBox("Registro ingresado exitosamente.", MsgBoxStyle.Information)
            Else
                MsgBox("Registro no fue ingresado, Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Error al generar código de asociado. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub btnImagen_Click(sender As Object, e As EventArgs) Handles btnImagen.Click
        Dim dialog As New OpenFileDialog
        Dim result As New DialogResult
        result = dialog.ShowDialog
        If (result = DialogResult.OK) Then

            Me.txtFoto.Image = ResizeImage(Image.FromFile(dialog.FileName), Me.txtFoto.Width, Me.txtFoto.Height) 'Image.FromFile(dialog.FileName)
        End If

    End Sub
    Public Overloads Shared Function ResizeImage(bmSource As Drawing.Bitmap, TargetWidth As Int32, TargetHeight As Int32) As Drawing.Bitmap
        Dim bmDest As New Drawing.Bitmap(TargetWidth, TargetHeight, Drawing.Imaging.PixelFormat.Format32bppArgb)

        Dim nSourceAspectRatio = bmSource.Width / bmSource.Height
        Dim nDestAspectRatio = bmDest.Width / bmDest.Height

        Dim NewX = 0
        Dim NewY = 0
        Dim NewWidth = bmDest.Width
        Dim NewHeight = bmDest.Height

        If nDestAspectRatio = nSourceAspectRatio Then
            'same ratio
        ElseIf nDestAspectRatio > nSourceAspectRatio Then
            'Source is taller
            NewWidth = Convert.ToInt32(Math.Floor(nSourceAspectRatio * NewHeight))
            NewX = Convert.ToInt32(Math.Floor((bmDest.Width - NewWidth) / 2))
        Else
            'Source is wider
            NewHeight = Convert.ToInt32(Math.Floor((1 / nSourceAspectRatio) * NewWidth))
            NewY = Convert.ToInt32(Math.Floor((bmDest.Height - NewHeight) / 2))
        End If

        Using grDest = Drawing.Graphics.FromImage(bmDest)
            With grDest
                .CompositingQuality = Drawing.Drawing2D.CompositingQuality.HighQuality
                .InterpolationMode = Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
                .PixelOffsetMode = Drawing.Drawing2D.PixelOffsetMode.HighQuality
                .SmoothingMode = Drawing.Drawing2D.SmoothingMode.AntiAlias
                .CompositingMode = Drawing.Drawing2D.CompositingMode.SourceOver

                .DrawImage(bmSource, NewX, NewY, NewWidth, NewHeight)
            End With
        End Using

        Return bmDest
    End Function

    Private Sub btnAddActEco_Click(sender As Object, e As EventArgs) Handles btnAddActEco.Click
        Try
            Dim frm As New frmMActividadEco
            With frm
                .dui = txtDui.Text
                .accion = 1
                .ShowDialog()
            End With
            llenarActividadEconomica(txtDui.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If Me.dgActEco.CurrentRow.Index >= 0 Then
            Dim frm As New frmMActividadEco
            With frm
                .idActEco = Me.dgActEco.Item("idActividadEconomica", Me.dgActEco.CurrentRow.Index).Value
                .accion = 2
                .dui = txtDui.Text
                .ShowDialog()
                '.llenarLugarTrabajo()
                '.cbLugarTrabajo.SelectedValue = Me.dgActEco.Item("codlugarTrabajo", Me.dgActEco.CurrentRow.Index).Value
                '.txtNoAcreUIF.Text = Me.dgActEco.Item("noAcreditacion", Me.dgActEco.CurrentRow.Index).Value
                '.dtpFechAcre.Value = Me.dgActEco.Item("fechaAcreditacion", Me.dgActEco.CurrentRow.Index).Value
                '.dtpVencimientoUIF.Value = Me.dgActEco.Item("fechaVencimiento", Me.dgActEco.CurrentRow.Index).Value
                '.chkNegFormal.Checked = Me.dgActEco.Item("NegocioFormal", Me.dgActEco.CurrentRow.Index).Value
                '.chkcontribuyente.Checked = Me.dgActEco.Item("Contribuyente", Me.dgActEco.CurrentRow.Index).Value
                '.txtNoRegContribuyente.Text = Me.dgActEco.Item("NumRegistroContribuyente", Me.dgActEco.CurrentRow.Index).Value
                '.txtNomComEc.Text = Me.dgActEco.Item("NombreComercial", Me.dgActEco.CurrentRow.Index).Value
                '.txtRazonSocialPrim.Text = Me.dgActEco.Item("RazonSocial", Me.dgActEco.CurrentRow.Index).Value
                '.txtGiroPrim.Text = Me.dgActEco.Item("giro", Me.dgActEco.CurrentRow.Index).Value
                '.llenarEstadoLaboral()
                '.cbEstadoLaboral.SelectedValue = Me.dgActEco.Item("estadoLaboral", Me.dgActEco.CurrentRow.Index).Value
                '.txtDptoTrabajo.Text = Me.dgActEco.Item("areaTrabajo", Me.dgActEco.CurrentRow.Index).Value
                '.dtpFechaIniTra.Value = Me.dgActEco.Item("fechaInicioTrabajo", Me.dgActEco.CurrentRow.Index).Value
                '.txtCargo.Text = Me.dgActEco.Item("cargo", Me.dgActEco.CurrentRow.Index).Value
                '.txtIngresosPrim.Text = Me.dgActEco.Item("ingresos", Me.dgActEco.CurrentRow.Index).Value
                '.txtTelOficina.Text = Me.dgActEco.Item("telOficina", Me.dgActEco.CurrentRow.Index).Value
                '.txtExtOficinaPrim.Text = Me.dgActEco.Item("extOficina", Me.dgActEco.CurrentRow.Index).Value
                '.llenarDepartamentos()
                '.cbDeptoOfi.SelectedValue = Me.dgActEco.Item("codDepartamento", Me.dgActEco.CurrentRow.Index).Value
                '.llenarMunicipio(Me.dgActEco.Item("codDepartamento", Me.dgActEco.CurrentRow.Index).Value)
                '.cbMunOfi.SelectedValue = Me.dgActEco.Item("codMunicipio", Me.dgActEco.CurrentRow.Index).Value
                '.txtDirOfi.Text = Me.dgActEco.Item("Direccion", Me.dgActEco.CurrentRow.Index).Value
                '.chkPrincipal.Checked = Me.dgActEco.Item("Primaria", Me.dgActEco.CurrentRow.Index).Value
                '.txtCodActEconomica.Text = Me.dgActEco.Item("codActividadEconomica", Me.dgActEco.CurrentRow.Index).Value
                '.recuperarCatActividadEconomica(Me.dgActEco.Item("codActividadEconomica", Me.dgActEco.CurrentRow.Index).Value)
                '.txtIngresosPrim.Text = Me.dgActEco.Item("descripcionIngreso", Me.dgActEco.CurrentRow.Index).Value

            End With
        End If
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            If Me.dgActEco.CurrentRow.Index >= 0 Then
                'Dim activo As Boolean = Me.dgActEco.Item("activo", Me.dgActEco.CurrentRow.Index).Value
                If (Me.dgActEco.Item("activo", Me.dgActEco.CurrentRow.Index).Value) = True Then

                    If (cliente.inactivarAsocActividadEconomica(Me.dgActEco.Item("idActividadEconomica", Me.dgActEco.CurrentRow.Index).Value, False)) > 0 Then
                        MsgBox("Registro inactivo.", MsgBoxStyle.Information)
                        llenarActividadEconomica(txtDui.Text)
                    Else
                        MsgBox("Error, por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
                    End If
                Else
                    MsgBox("Actividad Económica ya se encuentra inactiva", MsgBoxStyle.Information)
                End If

            End If
        Catch ex As Exception
            MsgBox("Error, por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub cbDepartamento_DropDownClosed(sender As Object, e As EventArgs) Handles cbDepartamento.DropDownClosed
        llenarMunicipio(Me.cbDepartamento.SelectedValue)
    End Sub

    Private Sub cbDepartamento_KeyDown(sender As Object, e As KeyEventArgs) Handles cbDepartamento.KeyDown
        llenarMunicipio(Me.cbDepartamento.SelectedValue)
    End Sub

    Private Sub cbDepartamento_Leave(sender As Object, e As EventArgs) Handles cbDepartamento.Leave
        llenarMunicipio(Me.cbDepartamento.SelectedValue)
    End Sub

    Private Sub cbDeptoJuridica_DropDownClosed(sender As Object, e As EventArgs) Handles cbDeptoJuridica.DropDownClosed
        llenarMunicipioJur(Me.cbDeptoJuridica.SelectedValue)
    End Sub

    Private Sub cbDeptoJuridica_KeyDown(sender As Object, e As KeyEventArgs) Handles cbDeptoJuridica.KeyDown
        llenarMunicipioJur(Me.cbDeptoJuridica.SelectedValue)
    End Sub

    Private Sub cbDeptoJuridica_Leave(sender As Object, e As EventArgs) Handles cbDeptoJuridica.Leave
        llenarMunicipioJur(Me.cbDeptoJuridica.SelectedValue)
    End Sub



    Private Sub txtCodActEco_Leave(sender As Object, e As EventArgs) Handles txtCodActEco.Leave
        If txtCodActEco.Text.Length > 0 Then
            recuperarCatActividadEconomica(txtCodActEco.Text.Trim)
        End If
    End Sub



    Private Sub txtCodActEco_DoubleClick(sender As Object, e As EventArgs) Handles txtCodActEco.DoubleClick
        Dim frm As New frmMsConsultarActividadEconomica
        Dim dts As New DataSet
        frm.Text = "Buscar Actividad Económica"
        Try
            frm.ShowDialog()
            txtCodActEco.Text = frm.Resultado
            txtActEco.Text = frm.Resultado2
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Ejecutivos Mercadeo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAddJuntaDir_Click(sender As Object, e As EventArgs) Handles btnAddJuntaDir.Click
        Try
            Dim idPerJur As Integer
            idPerJur = cliente.recuperarIdPersonaJuridica(txtNoSocio.Text.Trim)
            If idPerJur > 0 Then
                Dim frm As New frmMsJuntaDirectivaActEco
                With frm
                    .accion = 1
                    .idPersonaJur = idPerJur
                    .ShowDialog()
                End With
                llenarJuntaDirectiva(idPerJur)
            Else
                MsgBox("Información de persona juridica no encontrada.", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnModJunDir_Click(sender As Object, e As EventArgs) Handles btnModJunDir.Click
        Try
            Dim idJuntaDir As Integer
            If Me.dgJuntaDir.CurrentRow.Index >= 0 Then
                idJuntaDir = Me.dgJuntaDir.Item("idJuntaDirectiva", Me.dgJuntaDir.CurrentRow.Index).Value
                If idJuntaDir > 0 Then
                    Dim frm As New frmMsJuntaDirectivaActEco
                    With frm
                        .accion = 2
                        .txtNombreDir.Text = Me.dgJuntaDir.Item("Nombres", Me.dgJuntaDir.CurrentRow.Index).Value
                        .txtCargo.Text = Me.dgJuntaDir.Item("Cargo", Me.dgJuntaDir.CurrentRow.Index).Value
                        .chkActivo.Checked = Me.dgJuntaDir.Item("Activo", Me.dgJuntaDir.CurrentRow.Index).Value
                        .idJuntaDirectiva = Me.dgJuntaDir.Item("idJuntaDirectiva", Me.dgJuntaDir.CurrentRow.Index).Value
                        .idPersonaJur = Me.dgJuntaDir.Item("IdCatPerJuridica", Me.dgJuntaDir.CurrentRow.Index).Value
                        .ShowDialog()
                    End With
                    Dim idPerJur As Integer
                    idPerJur = cliente.recuperarIdPersonaJuridica((txtNoSocio.Text.Trim))
                    llenarJuntaDirectiva(idPerJur)
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnInactivaJunDir_Click(sender As Object, e As EventArgs) Handles btnInactivaJunDir.Click
        Try
            Dim idJuntaDir As Integer
            If Me.dgJuntaDir.CurrentRow.Index >= 0 Then
                idJuntaDir = Me.dgJuntaDir.Item("idJuntaDirectiva", Me.dgJuntaDir.CurrentRow.Index).Value

                If idJuntaDir > 0 Then
                    If cliente.eliminarAsocPersonaJuridicaDirectivos(idJuntaDir) > 0 Then
                        MsgBox("Registro inactivo", MsgBoxStyle.Information)
                    End If
                    Dim idPerJur As Integer
                    idPerJur = cliente.recuperarIdPersonaJuridica((txtNoSocio.Text.Trim))
                    llenarJuntaDirectiva(idPerJur)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDui_Validated(sender As Object, e As EventArgs) Handles txtDui.Validated
        Try
            If reingreso = False Then
                Dim dts As New DataSet
                dts = cliente.ConsultarAsociado("Dui", "dui='" & txtDui.Text.Trim & "'", "", sUsuario, sPassword, sSucursal)
                If dts.Tables.Count > 0 Then
                    If dts.Tables(0).Rows.Count > 0 Then
                        If MsgBox("DUI ya se encuentra registrado, ¿desea realizar reingreso de asociado?",
                                  MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                            txtDui.Enabled = False
                            llenarDatos(txtDui.Text)
                            accion = 2
                        End If
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNit_Validated(sender As Object, e As EventArgs) Handles txtNit.Validated
        Try
            If accion = 1 Then
                If reingreso = False Then
                    Dim dts As New DataSet
                    dts = cliente.ConsultarAsociado("Dui", "nit='" & txtNit.Text.Trim & "'", "", sUsuario, sPassword, sSucursal)
                    If dts.Tables.Count > 0 Then
                        If dts.Tables(0).Rows.Count > 0 Then
                            If MsgBox("DUI ya se encuentra registrado, ¿desea realizar reingreso de asociado?",
                                      MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                                txtDui.Enabled = False

                                llenarDatos(txtDui.Text)
                                accion = 2
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub btnAddDoc_Click(sender As Object, e As EventArgs) Handles btnAddDoc.Click
        Try
            If idDeclaracionJurada > 0 Then


                Dim frm As New frmMsDocDeclaracionJurada
                With frm
                    .idDeclaracion = idDeclaracionJurada
                    .accion = 1
                    .btnGuardarDom.Text = "Guardar"
                    .ShowDialog()
                End With
                llenarDocumentos(idDeclaracionJurada)
                'Me.dgDocumentos.DataSource = asociados.consultarAsocDeclaracionJuradaDocumentos(idDeclaracion).Tables(0)
            Else
                MsgBox("primero debe guardar la declaracion", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub btnIngFam_Click(sender As Object, e As EventArgs) Handles btnIngFam.Click
        Try
            If idPep > 0 Then
                Dim frm As New frmMsFamiliaresPep
                With frm
                    .idPep = idPep
                    .accion = 1
                    .ShowDialog()
                End With
                llenarFamiliaresPep(idPep)
            End If
        Catch ex As Exception
            MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub btnIngSociedades_Click(sender As Object, e As EventArgs) Handles btnIngSociedades.Click
        Try
            If idPep > 0 Then
                Dim frm As New frmMsAsociacionesPep
                With frm
                    .idPep = idPep
                    .accion = 1
                    .ShowDialog()
                End With
            End If
            llenarSociedadesPep(idPep)

        Catch ex As Exception
            MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAddRefPer_Click(sender As Object, e As EventArgs) Handles btnAddRefPer.Click
        Try
            Dim frm As New frmMsDetReferencia
            With frm
                .pDui = txtDui.Text.Trim
                .btnGuardar1.Text = "&Guardar"
                .ShowDialog()
            End With
            llenarReferencias(txtDui.Text)
        Catch ex As Exception
            MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAddBen_Click(sender As Object, e As EventArgs) Handles btnAddBen.Click
        Try
            Dim frm As frmMsDetBeneficiarios = New frmMsDetBeneficiarios
            frm.pDui = Trim(txtDui.Text)
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            llenarBeneficiarios(txtDui.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRelaciones_Click(sender As Object, e As EventArgs) Handles btnRelaciones.Click
        Try
            Dim frm As New frmMsRelacionesAsoc
            With frm
                .dui = txtDui.Text.Trim
                .accion = 1
                .ShowDialog()
                llenarRelacionesAsoc(txtDui.Text.Trim)
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtpFechaNac_Validated(sender As Object, e As EventArgs) Handles dtpFechaNac.Validated
        isValidaFechaNacimiento(dtpFechaNac.Value)
    End Sub

    Private Sub txtEmail_Validated(sender As Object, e As EventArgs) Handles txtEmail.Validated
        If txtEmail.Text.Length > 0 Then
            isValidoEmail(txtEmail.Text.Trim)
        End If
    End Sub

    Private Sub btnFirma_Click(sender As Object, e As EventArgs) Handles btnFirma.Click
        Dim dialog As New OpenFileDialog
        Dim result As New DialogResult
        result = dialog.ShowDialog
        If (result = DialogResult.OK) Then

            Me.pbFirma.Image = ResizeImage(Image.FromFile(dialog.FileName), Me.pbFirma.Width, Me.pbFirma.Height) 'Image.FromFile(dialog.FileName)
        End If
    End Sub

    Private Sub chkPersonaJuridica_CheckedChanged(sender As Object, e As EventArgs) Handles chkPersonaJuridica.CheckedChanged
        If accion = 1 Then
            If chkPersonaJuridica.Checked = True Then
                Me.tpPerJur.Enabled = True
            Else
                Me.tpPerJur.Enabled = False
            End If
        ElseIf accion = 2 Then

            If chkPersonaJuridica.Checked = True Then
                Me.tpPerJur.Enabled = True
            Else
                Me.tpPerJur.Enabled = False
            End If
        End If
    End Sub

    Private Sub chkDobleNacionalidad_Click(sender As Object, e As EventArgs) Handles chkDobleNacionalidad.Click
        If chkDobleNacionalidad.Checked = True Then
            Me.cb2Nacionalidad.Enabled = True
        Else
            cb2Nacionalidad.Enabled = False
        End If
    End Sub



    Private Sub chkResidente_Click(sender As Object, e As EventArgs) Handles chkResidente.Click
        If chkResidente.Checked = True Then
            txtNoResidente.Enabled = True
        Else
            txtNoResidente.Enabled = False
        End If
    End Sub
    Public Function requeridosPep() As Boolean
        Me.ErrorProvider1.Clear()
        Dim valido As Boolean = True
        If cbTipoPep.SelectedIndex <= 0 Then
            Me.ErrorProvider1.SetError(cbTipoPep, "Campo Requerido")
            valido = False
        End If
        If txtPerNombramiento.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtPerNombramiento, "Campo Requerido")
            valido = False
        End If
        If txtAniosPep.Value = 0 Then
            Me.ErrorProvider1.SetError(txtAniosPep, "Campo Requerido")
            valido = False
        End If
        Return valido
    End Function
    Public Function requeridosDecJur() As Boolean
        Me.ErrorProvider1.Clear()
        Dim valido As Boolean = True
        If txtDepPromMen.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtDepPromMen, "Campo Requerido")
            valido = False
        End If
        If txtRetPromMen.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtRetPromMen, "Campo Requerido")
            valido = False
        End If
        If txtDestino.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtDestino, "Campo Requerido")
            valido = False
        End If
        If txtOrigenFondos.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtOrigenFondos, "Campo Requerido")
            valido = False
        End If
        Return valido
    End Function
    Public Function requeridosPerJur() As Boolean
        Me.ErrorProvider1.Clear()
        Dim valido As Boolean = True
        If txtRazonSocial.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtRazonSocial, "Campo Requerido")
            valido = False
        End If
        If txtNomComercial.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtNomComercial, "Campo Requerido")
            valido = False
        End If
        If Me.txtRepLegal.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtRepLegal, "Campo Requerido")
            valido = False
        End If
        If Me.txtNRC.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtNRC, "Campo Requerido")
            valido = False
        End If
        If Me.txtNit.MaskCompleted = False Then
            Me.ErrorProvider1.SetError(txtNit, "Campo Requerido")
            valido = False
        End If
        If Me.cbDeptoJuridica.SelectedIndex < 0 Then
            Me.ErrorProvider1.SetError(cbDeptoJuridica, "Campo Requerido")
            valido = False
        End If
        If Me.cbMunicipioJur.SelectedIndex < 0 Then
            Me.ErrorProvider1.SetError(cbMunicipioJur, "Campo Requerido")
            valido = False
        End If
        If Me.txtDirJur.Text.Trim.Length < 0 Then
            Me.ErrorProvider1.SetError(txtDirJur, "Campo Requerido")
            valido = False
        End If
        Return valido
    End Function
    Public Function requeridosOtrosDatos() As Boolean
        Me.ErrorProvider1.Clear()
        Dim valido As Boolean = True
        If cbEjecutivo.SelectedIndex < 0 Then
            Me.ErrorProvider1.SetError(cbEjecutivo, "Campo Requerido")
            valido = False
        End If
        If cbCuotaIngreso.SelectedIndex < 0 Then
            Me.ErrorProvider1.SetError(cbCuotaIngreso, "Campo Requerido")
            valido = False
        End If
        Return valido
    End Function
    Public Function requeridosInfComp() As Boolean
        Me.ErrorProvider1.Clear()
        Dim valido As Boolean = True
        If cbNivelEducativo.SelectedIndex <= 0 Then
            Me.ErrorProvider1.SetError(cbNivelEducativo, "Campo Requerido")
            valido = False
        End If
        If txtNumDep.Value < 0 Then
            Me.ErrorProvider1.SetError(txtNumDep, "Campo Requerido")
            valido = False
        End If
        If txtNumGrupFam.Value < 0 Then
            Me.ErrorProvider1.SetError(txtNumGrupFam, "Campo Requerido")
            valido = False
        End If
        If Me.txtAnioRes.Value < 0 Then
            Me.ErrorProvider1.SetError(txtAnioRes, "Campo Requerido")
            valido = False
        End If
        If Me.cbEstadoVivienda.SelectedIndex <= 0 Then
            Me.ErrorProvider1.SetError(cbEstadoVivienda, "Campo Requerido")
            valido = False
        End If
        Return valido
    End Function
    Public Function requeridosDomicilio() As Boolean
        Me.ErrorProvider1.Clear()
        Dim valido As Boolean = True
        If Me.cbDepartamento.SelectedIndex < 0 Then
            Me.ErrorProvider1.SetError(cbDepartamento, "Campo Requerido")
            valido = False
        End If
        If Me.cbMunicipio.SelectedIndex < 0 Then
            Me.ErrorProvider1.SetError(cbMunicipio, "Campo Requerido")
            valido = False
        End If
        If Me.txtDireccion.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtDireccion, "Campo Requerido")
            valido = False
        End If
        Return valido
    End Function
    Public Function requeridosPersonaNatural() As Boolean
        Me.ErrorProvider1.Clear()
        Dim valido As Boolean = True
        If txtDui.MaskCompleted = False Then
            Me.ErrorProvider1.SetError(txtDui, "Campo Requerido")
            valido = False
        End If

        If txtNit.MaskCompleted = False Then
            Me.ErrorProvider1.SetError(txtNit, "Campo Requerido")
            valido = False
        End If

        If Me.txtNombres.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtNombres, "Campo Requerido")
            valido = False
        End If
        If Me.txtPApellido.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtPApellido, "Campo Requerido")
            valido = False
        End If
        If Me.cbNacionalidad.SelectedIndex < 0 Then
            Me.ErrorProvider1.SetError(cbNacionalidad, "Campo Requerido")
            valido = False
        End If
        If Me.chkDobleNacionalidad.Checked = True Then
            If Me.cb2Nacionalidad.SelectedIndex < 0 Then
                Me.ErrorProvider1.SetError(cb2Nacionalidad, "Campo Requerido")
                valido = False
            End If
        End If

        If Me.cbProfesion.SelectedIndex < 0 Then
            Me.ErrorProvider1.SetError(cbProfesion, "Campo Requerido")
            valido = False
        End If
        If Me.txtExtDui.Text.Trim.Length <= 0 Then
            Me.ErrorProvider1.SetError(txtExtDui, "Campo Requerido")
            valido = False
        End If

        If Me.cbGenero.SelectedIndex < 0 Then
            Me.ErrorProvider1.SetError(cbGenero, "Campo Requerido")
            valido = False
        End If
        If Me.cbEstadoCivil.SelectedIndex <= 0 Then
            Me.ErrorProvider1.SetError(cbEstadoCivil, "Campo Requerido")
            valido = False
        End If
        If Me.cbPaisResidencia.SelectedIndex <= 0 Then
            Me.ErrorProvider1.SetError(cbPaisResidencia, "Campo Requerido")
            valido = False
        End If
        If Me.txtLugarNac.Text.Trim.Length <= 0 Then
            Me.ErrorProvider1.SetError(txtLugarNac, "Campo Requerido")
            valido = False
        End If
        Return valido
    End Function

    Private Sub btnUpdDoc_Click(sender As Object, e As EventArgs) Handles btnUpdDoc.Click
        Try
            If idDeclaracionJurada > 0 Then
                If Me.dgDocumentos.CurrentRow.Index >= 0 Then
                    Dim frm As New frmMsDocDeclaracionJurada
                    With frm
                        .idDeclaracion = idDeclaracionJurada
                        .idDocumento = Me.dgDocumentos.Item("idDoc", Me.dgDocumentos.CurrentRow.Index).Value
                        .accion = 2
                        .btnGuardarDom.Text = "Modificar"
                        .ShowDialog()
                    End With
                    llenarDocumentos(idDeclaracionJurada)
                End If
            Else
                MsgBox("primero debe guardar la declaracion", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnDelDoc_Click(sender As Object, e As EventArgs) Handles btnDelDoc.Click
        Try
            If Me.dgDocumentos.CurrentRow.Index >= 0 Then
                If MsgBox("Desea anular documento", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    If cliente.anularAsocDeclaracionJuradaDocumentos(Me.dgDocumentos.Item("idDoc", Me.dgDocumentos.CurrentRow.Index).Value, False) > 0 Then
                        MsgBox("Registro anulado exitosamente", MsgBoxStyle.Information)
                        llenarDocumentos(idDeclaracionJurada)
                    Else
                        MsgBox("Registro no pudo ser anulado.", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModFam_Click(sender As Object, e As EventArgs) Handles btnModFam.Click
        Try
            If dgFamPep.CurrentRow.Index >= 0 Then
                If idPep > 0 Then
                    Dim frm As New frmMsFamiliaresPep
                    With frm
                        .idPep = idPep
                        .IdFamiliarPep = Me.dgFamPep.Item("idFamiliarPep", Me.dgFamPep.CurrentRow.Index).Value
                        .txtNombre.Text = Me.dgFamPep.Item("Nombres", Me.dgFamPep.CurrentRow.Index).Value
                        .llenarTipoFamiliar()
                        .cbParentesco.SelectedValue = Me.dgFamPep.Item("codTipoFamiliar", Me.dgFamPep.CurrentRow.Index).Value
                        .accion = 2
                        .ShowDialog()
                    End With
                    llenarFamiliaresPep(idPep)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnDelFam_Click(sender As Object, e As EventArgs) Handles btnDelFam.Click
        Try
            If dgFamPep.CurrentRow.Index >= 0 Then
                If MsgBox("Desea eliminar el registro", vbYesNo) = MsgBoxResult.Yes Then
                    If (cliente.eliminarAsocPep_Familiares(Me.dgFamPep.Item("idFamiliarPep", Me.dgFamPep.CurrentRow.Index).Value)) > 0 Then
                        MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information)
                        llenarFamiliaresPep(idPep)
                    Else
                        MsgBox("El registro no pudo ser eliminado.", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModSoc_Click(sender As Object, e As EventArgs) Handles btnModSoc.Click
        Try
            If Me.dgSociedades.CurrentRow.Index >= 0 Then
                If idPep > 0 Then
                    Dim frm As New frmMsAsociacionesPep
                    With frm
                        .idPep = idPep
                        .accion = 2
                        .idSociedad = Me.dgSociedades.Item("idSociedad", Me.dgSociedades.CurrentRow.Index).Value
                        .txtPorParticipacin.Value = Me.dgSociedades.Item("porcentajeParticipacion", Me.dgSociedades.CurrentRow.Index).Value
                        .txtSociedad.Text = Me.dgSociedades.Item("sociedad", Me.dgSociedades.CurrentRow.Index).Value.ToString.ToUpper
                        .ShowDialog()
                    End With
                End If
                llenarSociedadesPep(idPep)
            End If


        Catch ex As Exception
            MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnDelSoc_Click(sender As Object, e As EventArgs) Handles btnDelSoc.Click
        Try
            If dgSociedades.CurrentRow.Index >= 0 Then
                If MsgBox("Desea eliminar el registro", vbYesNo) = MsgBoxResult.Yes Then
                    If (cliente.eliminarAsocPep_Sociedades(Me.dgSociedades.Item("idSociedad", Me.dgSociedades.CurrentRow.Index).Value)) > 0 Then

                        MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information)
                        llenarSociedadesPep(idPep)
                    Else
                        MsgBox("El registro no pudo ser eliminado.", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModRefPer_Click(sender As Object, e As EventArgs) Handles btnModRefPer.Click
        Try
            Dim frm As New frmMsDetReferencia
            With frm
                .pCorrelativo = Me.dgReferenciaPersonal.Item("NumRef", Me.dgReferenciaPersonal.CurrentRow.Index).Value
                .pDui = txtDui.Text.Trim
                .btnGuardar1.Text = "&Modificar"
                .ShowDialog()
            End With
            llenarReferencias(txtDui.Text)
        Catch ex As Exception
            MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnDelRefPer_Click(sender As Object, e As EventArgs) Handles btnDelRefPer.Click
        Try
            If Me.dgReferenciaPersonal.CurrentRow.Index >= 0 Then
                If MsgBox("¿Desea eliminar la Referencia No. " & Me.dgReferenciaPersonal.Item("NumRef", Me.dgReferenciaPersonal.CurrentRow.Index).Value & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Referencias") = MsgBoxResult.Yes Then
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
                    oAsoc.EliminarReferencias("Dui='" & txtDui.Text & "' and NumRef=" & Me.dgReferenciaPersonal.Item("NumRef", Me.dgReferenciaPersonal.CurrentRow.Index).Value & "", sUsuario, sPassword, sSucursal)
                    llenarReferencias(txtDui.Text)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModBen_Click(sender As Object, e As EventArgs) Handles btnModBen.Click
        Try
            If Me.dgBeneficiarios.CurrentRow.Index >= 0 Then
                Dim frm As frmMsDetBeneficiarios = New frmMsDetBeneficiarios
                frm.pDui = txtDui.Text
                frm.pCorrelativo = Me.dgBeneficiarios.Item("correlativo", Me.dgBeneficiarios.CurrentRow.Index).Value 'C1fGrdDetBeneficiarios.Item(C1fGrdDetBeneficiarios.Row, "Correlativo")
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                llenarBeneficiarios(txtDui.Text)
            End If
        Catch ex As Exception
            MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub btnDelBen_Click(sender As Object, e As EventArgs) Handles btnDelBen.Click
        Try
            If Me.dgBeneficiarios.CurrentRow.Index >= 0 Then
                If MsgBox("¿Desea eliminar el Beneficiario No. " & dgBeneficiarios.Item("correlativo", Me.dgBeneficiarios.CurrentRow.Index).Value & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Beneficiarios") = MsgBoxResult.Yes Then
                    cliente.EliminarBeneficiarios("Correlativo=" & dgBeneficiarios.Item("correlativo", Me.dgBeneficiarios.CurrentRow.Index).Value & "", sUsuario, sPassword, sSucursal)
                    llenarBeneficiarios(txtDui.Text)
                End If
            End If
        Catch ex As Exception
            MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModRelaciones_Click(sender As Object, e As EventArgs) Handles btnModRelaciones.Click
        Try
            If Me.dgRelaciones.CurrentRow.Index >= 0 Then
                Dim frm As New frmMsRelacionesAsoc
                Dim dtsa As New DataSet
                dtsa = cliente.ConsultarAsociado("rtrim(nombres) +' '+RTRIM (apellido1)+' '+ isnull(rtrim(Apellido2),' ')+ ' ' + isnull(rtrim(ApellidoCas),' ') ", " dui = '" & dgRelaciones.Item("duiRelacion", Me.dgRelaciones.CurrentRow.Index).Value.ToString & "'", "", sUsuario, sPassword, sSucursal)
                If dtsa IsNot Nothing Then
                    If dtsa.Tables.Count > 0 Then
                        If dtsa.Tables(0).Rows.Count > 0 Then
                            With frm
                                .dui = txtDui.Text.Trim
                                .txtDui.Value = Me.dgRelaciones.Item("duiRelacion", Me.dgRelaciones.CurrentRow.Index).Value.ToString
                                .llenarCbParentesco()
                                .cbRelaciones.SelectedValue = Me.dgRelaciones.Item("codParentesco", Me.dgRelaciones.CurrentRow.Index).Value
                                .txtAsociado.Text = dtsa.Tables(0).Rows(0).Item(0).ToString.ToUpper
                                .accion = 2
                                .correlativo = Me.dgRelaciones.Item("correlativo", Me.dgRelaciones.CurrentRow.Index).Value
                                .ShowDialog()
                                llenarRelacionesAsoc(txtDui.Text.Trim)
                            End With
                        End If
                    End If
                End If

            End If

        Catch ex As Exception
            MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnDelRelaciones_Click(sender As Object, e As EventArgs) Handles btnDelRelaciones.Click
        Try
            If Me.dgRelaciones.CurrentRow.Index >= 0 Then
                If MsgBox("¿Desea eliminar relación?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Relación") = MsgBoxResult.Yes Then
                    If (cliente.eliminarAsocRelacionesAsociado(dgRelaciones.Item("correlativo", Me.dgRelaciones.CurrentRow.Index).Value)) > 0 Then
                        MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information)
                        llenarRelacionesAsoc(txtDui.Text.Trim)
                    Else
                        MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox("Error,Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dim frm As New frmVisorRS
        OpcionRS = 75
        With frm
            .ShowDialog()
        End With
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Dim frm As New frmVisorRS
        OpcionRS = 79
        With frm
            .dui = txtDui.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Dim frm As New frmVisorRS
        OpcionRS = 80
        With frm
            .dui = txtDui.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles MetroButton6.Click
        Dim frm As New frmVisorRS
        OpcionRS = 76
        With frm
            .dui = txtDui.Text
            .ShowDialog()
        End With
    End Sub

    Private Sub btnNuevoDomicilio_Click(sender As Object, e As EventArgs) Handles btnNuevoDomicilio.Click
        txtDireccion.Text = ""
        cbMunicipio.SelectedValue = 0
        cbDepartamento.SelectedValue = 0
        txtTipoOperacion.Text = 1
        CorrelaticoDomi = 0
    End Sub

    Private Sub BtnModificarDireccion_Click(sender As Object, e As EventArgs) Handles BtnModificarDireccion.Click

        Try
            If dgDirecciones.Rows.Count > 0 Then
                cbDepartamento.SelectedValue = Me.dgDirecciones.Item("CodDepartamento", Me.dgDirecciones.CurrentRow.Index).Value

                llenarMunicipio(Me.dgDirecciones.Item("CodDepartamento", Me.dgDirecciones.CurrentRow.Index).Value)
                cbMunicipio.SelectedValue = Me.dgDirecciones.Item("Codmunicipio", Me.dgDirecciones.CurrentRow.Index).Value
                txtDireccion.Text = Me.dgDirecciones.Item("Direccion", Me.dgDirecciones.CurrentRow.Index).Value
                chkActual.Checked = Me.dgDirecciones.Item("Estado", Me.dgDirecciones.CurrentRow.Index).Value
                txtTipoOperacion.Text = 2
                CorrelaticoDomi = Me.dgDirecciones.Item("Correlativo", Me.dgDirecciones.CurrentRow.Index).Value
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnEliminarDireccion_Click(sender As Object, e As EventArgs) Handles btnEliminarDireccion.Click
        CorrelaticoDomi = Me.dgDirecciones.Item("Correlativo", Me.dgDirecciones.CurrentRow.Index).Value
        If CorrelaticoDomi > 0 Then
            If cliente.insertar_CatAsociados_Domicilio(3, CorrelaticoDomi, txtDui.Text, txtDireccion.Text.ToUpper.Trim, 0, 0, chkActual.Checked) > 0 Then
                MsgBox("Registro Eliminado exitosamente", MsgBoxStyle.Information)
                llenarDomicilios(txtDui.Text)
                CorrelaticoDomi = 0
            Else
                MsgBox("Registro no fue Eliminado, Por favor comunicarse con el administrador de sistema." & Err.Description.ToString, MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        Dim frm As New frmVisorRS
        OpcionRS = 78
        With frm
            .dui = txtDui.Text
            .Show()
        End With
    End Sub



    Private Sub frmIngresoAsoc2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim dts, dtsAsociado As New DataSet
        dtsAsociado = cliente.ConsultarAsociado("Dui", "dui='" & txtDui.Text.Trim & "'", "", sUsuario, sPassword, sSucursal)
        If dtsAsociado.Tables.Count > 0 Then
            If dtsAsociado.Tables(0).Rows.Count > 0 Then
                dts = cliente.ConsultarEstadoIngreso("a.dui", "a.dui = '" & txtDui.Text.Trim & "'", "a.dui", sUsuario, sPassword, sSucursal)
                If dts.Tables.Count = 0 Then
                    MsgBox("Por favor ingresar información en pestaña Otros Datos' ", MsgBoxStyle.Information)
                    e.Cancel = True
                    Exit Sub
                Else
                    If dts.Tables(0).Rows.Count = 0 Then
                        MsgBox("Por favor ingresar información en pestaña Otros Datos' ", MsgBoxStyle.Information)
                        e.Cancel = True
                        Exit Sub
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub MetroButton8_Click(sender As Object, e As EventArgs) Handles MetroButton8.Click
        Dim dts As New DataSet
        dts = cliente.rptSolicitudIngreso(txtDui.Text.Trim)

        Dim frm As New frmVisor(dts, 218, 0)
        With frm
            .ShowDialog()
        End With
    End Sub

    Private Sub txtObservaciones_TextChanged(sender As Object, e As EventArgs) Handles txtObservaciones.TextChanged
        Try
            If txtObservaciones.Text.StartsWith(observacionIni) = False Then
                Me.txtObservaciones.Text = observacionIni
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region
End Class