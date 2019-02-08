Imports System.Text.RegularExpressions
Imports System.IO

Public Class frmMsIngresoAsociados
    Dim asociados As New wsSysFinCoop.LibAsoc.wsLibAsoc
    Dim creditos As New wsSysFinCoop.LibCred.wsLibCred
    Private vAccion As Integer
    Dim idDeclaracion As Integer
    Dim idPep As Integer
    Dim vDui As String
    Dim vCorrelativo As Integer
    Dim idCatPersonaJuridica, idDeclaracionJurada As Integer
    Dim fechaExtDui As Boolean
    Dim idActEcoPrim, idActEcoSec As Integer
    Dim modificarPersonaJuridica, modificarDatosPersonales, modificarActEco, modificarDecJurada, modificarPEP As Boolean
    Dim otrosDatos, infComp, datPersonales As Boolean
    Dim accionDatPer, accionActEcoPrim, accionActEcoSec As Integer
    Dim reIngreso As Boolean = False


#Region "Propiedades"
    Public Property accion() As Integer
        Get
            Return Me.vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property correlativo() As Integer
        Get
            Return Me.vCorrelativo
        End Get
        Set(ByVal value As Integer)
            vCorrelativo = correlativo
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
#End Region
#Region "Eventos"
    Protected Sub llenarDatosAsoc(ByVal dui As String)
        Dim dts As New DataSet
        dts = asociados.consultarCat_Asociados(dui)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                'Datos Personales
                txtUltIngreso.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("fechaingresoAnt")), "", dts.Tables(0).Rows(0).Item("fechaingresoAnt"))
                txtDui.Text = dui
                txtNoPasaporte.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NumPasaporte")), "", dts.Tables(0).Rows(0).Item("NumPasaporte"))
                cbEstadoIngreso.SelectedIndex = dts.Tables(0).Rows(0).Item("EstadoIngreso")
                txtNosocio.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NoSocio")), "", dts.Tables(0).Rows(0).Item("NoSocio"))
                chkPersonaJuridica.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("PersonaJuridica")), False, dts.Tables(0).Rows(0).Item("PersonaJuridica"))
                chkResidente.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Residente")), False, IIf(dts.Tables(0).Rows(0).Item("Residente") = "F", False, True))
                txtNoResidente.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NoResidente")), " ", dts.Tables(0).Rows(0).Item("NoResidente"))
                txtNombres.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Nombres")), " ", dts.Tables(0).Rows(0).Item("Nombres"))
                txtPrimerApellido.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellido1")), " ", dts.Tables(0).Rows(0).Item("apellido1"))
                txtSegApellido.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellido2")), " ", dts.Tables(0).Rows(0).Item("apellido2"))
                txtApellidoCasada.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellidoCas")), " ", dts.Tables(0).Rows(0).Item("apellidoCas"))
                txtConocidoPor.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("conocidoPor")), " ", dts.Tables(0).Rows(0).Item("conocidoPor"))
                Me.cbPrimerNacionalidad.SelectedValue = dts.Tables(0).Rows(0).Item("codNacionalidad")
                chkDobleNacionalidad.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("dobleNacionalidad")), False, dts.Tables(0).Rows(0).Item("dobleNacionalidad"))
                If chkDobleNacionalidad.Checked = False Then
                    Me.cbSegNacionalidad.Enabled = False
                End If
                If Me.chkResidente.Checked = False Then
                    txtNoResidente.Enabled = False
                End If
                Me.cbSegNacionalidad.SelectedValue = dts.Tables(0).Rows(0).Item("codNacionalidad2")
                txtExtDui.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("lugarExtDui")), " ", dts.Tables(0).Rows(0).Item("lugarExtDui"))
                cbProfesionDui.SelectedValue = dts.Tables(0).Rows(0).Item("codProfesion")
                dtpFechaExtDui.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaExtDUI")), Now, dts.Tables(0).Rows(0).Item("FechaExtDUI"))
                dtpFechaNac.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Fecha_Nac")), Now, dts.Tables(0).Rows(0).Item("Fecha_Nac"))
                Me.cbSexo.SelectedIndex = dts.Tables(0).Rows(0).Item("sexo")
                Me.cbEstadoCivil.SelectedValue = dts.Tables(0).Rows(0).Item("codEstadoCivil")
                txtNit.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NIT")), "", dts.Tables(0).Rows(0).Item("NIT"))
                txtIsss.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("ISSS")), "", dts.Tables(0).Rows(0).Item("ISSS"))
                Me.cbDepto.SelectedValue = dts.Tables(0).Rows(0).Item("CodDepartamento")
                llenarCbMunicipio(dts.Tables(0).Rows(0).Item("CodDepartamento"))
                Me.cbMunicipio.SelectedValue = dts.Tables(0).Rows(0).Item("CodMunicipio")
                txtDireccion.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("direccion")), "", dts.Tables(0).Rows(0).Item("direccion"))
                txtTelCasa.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("telCasa")), "", dts.Tables(0).Rows(0).Item("telCasa"))
                txtCelular.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("celular")), "", dts.Tables(0).Rows(0).Item("celular"))
                txtCorreo.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("email")), "", dts.Tables(0).Rows(0).Item("email"))
                'Persona Juridica
                If chkPersonaJuridica.Checked = True Then
                    chkPersonaJuridica.Enabled = False
                    idCatPersonaJuridica = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("idCatPerJuridica")), 0, dts.Tables(0).Rows(0).Item("idCatPerJuridica"))
                    Me.btnJuntaDirectiva.Enabled = True
                    txtRazSocial.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("RazonSocial")), "", dts.Tables(0).Rows(0).Item("RazonSocial"))
                    txtNomComercial.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NombreComercial")), "", dts.Tables(0).Rows(0).Item("NombreComercial"))
                    txtRepresentanteLegal.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("RepresentanteLegal")), "", dts.Tables(0).Rows(0).Item("RepresentanteLegal"))
                    txtNoRegContribuyente.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NoRegContribuyente")), "", dts.Tables(0).Rows(0).Item("NoRegContribuyente"))
                    txtNitEmpresa.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NitEmpresa")), "", dts.Tables(0).Rows(0).Item("NitEmpresa"))
                    txtTelPerJur.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("TelPJ")), "", dts.Tables(0).Rows(0).Item("TelPJ"))
                    cbDeptoPerJur.SelectedValue = dts.Tables(0).Rows(0).Item("codDeptoPJ")
                    llenarCbMunicipioJur(dts.Tables(0).Rows(0).Item("codDeptoPJ"))
                    cbMunicipioJur.SelectedValue = dts.Tables(0).Rows(0).Item("codMunPJ")
                    txtDirPerJur.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("direccionPJ")), "", dts.Tables(0).Rows(0).Item("direccionPJ"))
                    llenarDgJuntaDirectiva(idCatPersonaJuridica)
                End If
                'Actividad economica primaria
                If IIf(IsDBNull(dts.Tables(0).Rows(0).Item("idActividadEconomica")), 0, dts.Tables(0).Rows(0).Item("idActividadEconomica")) > 0 Then
                    idActEcoPrim = dts.Tables(0).Rows(0).Item("idActividadEconomica")
                    Me.cbLugarTrabajo.SelectedValue = dts.Tables(0).Rows(0).Item("CodLugarTrabajo")
                    Me.txtCodActEconomica.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("CodigoActividadEconomica")), "", dts.Tables(0).Rows(0).Item("CodigoActividadEconomica"))
                    txtDescripcionActEco.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("descActEcoPrim")), "", dts.Tables(0).Rows(0).Item("descActEcoPrim"))
                    txtNoAcreUIF.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NoAcreditacion")), "", dts.Tables(0).Rows(0).Item("NoAcreditacion"))
                    dtpFechAcre.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaAcreditacion")), Now, dts.Tables(0).Rows(0).Item("FechaAcreditacion"))
                    dtpVencimientoUIF.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaVencimiento")), Now, dts.Tables(0).Rows(0).Item("FechaVencimiento"))
                    chkNegFormal.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NegocioFormal")), False, dts.Tables(0).Rows(0).Item("NegocioFormal"))
                    chkcontribuyente.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Contribuyente")), False, dts.Tables(0).Rows(0).Item("Contribuyente"))
                    txtNoRegContribuyente.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NumRegistroContribuyente")), "", dts.Tables(0).Rows(0).Item("NumRegistroContribuyente"))
                    If chkcontribuyente.Checked = False Then
                        Me.txtNoRegContribuyente.Enabled = False
                    End If
                    txtNomComEc.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NombreComercialAE")), "", dts.Tables(0).Rows(0).Item("NombreComercialAE"))
                    txtRazonSocialPrim.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("RazonSocialAE")), "", dts.Tables(0).Rows(0).Item("RazonSocialAE"))
                    txtGiroPrim.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Giro")), "", dts.Tables(0).Rows(0).Item("Giro"))
                    cbEstadoLaboral.SelectedValue = dts.Tables(0).Rows(0).Item("EstadoLaboral")
                    txtDptoTrabajo.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("AreaTrabajo")), "", dts.Tables(0).Rows(0).Item("AreaTrabajo"))
                    dtpFechaIniTra.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaInicioTrabajo")), Now, dts.Tables(0).Rows(0).Item("FechaInicioTrabajo"))
                    Me.txtCargo.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Cargo")), "", dts.Tables(0).Rows(0).Item("Cargo"))
                    txtIngresosPrim.Value = dts.Tables(0).Rows(0).Item("Ingresos")
                    txtTotalIngresosPrim.Value = dts.Tables(0).Rows(0).Item("Ingresos") + IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Ingresos2")), 0, dts.Tables(0).Rows(0).Item("Ingresos2")) + IIf(IsDBNull(dts.Tables(0).Rows(0).Item("OtrosIngresos")), 0, dts.Tables(0).Rows(0).Item("OtrosIngresos"))
                    txtTelOficina.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("TelOficina")), "", dts.Tables(0).Rows(0).Item("TelOficina"))
                    txtExtOficinaPrim.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("ExtOficina")), "", dts.Tables(0).Rows(0).Item("ExtOficina"))
                    cbDeptoOfi.SelectedValue = dts.Tables(0).Rows(0).Item("codDeptoAE")
                    llenarCbMunicipioActEco1(dts.Tables(0).Rows(0).Item("codDeptoAE"))
                    cbMunOfi.SelectedValue = dts.Tables(0).Rows(0).Item("codMunAE")
                    txtDirOfi.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("direccionAE")), "", dts.Tables(0).Rows(0).Item("direccionAE"))
                    txtDetIngresos.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("DescripcionIngreso")), "", dts.Tables(0).Rows(0).Item("DescripcionIngreso"))
                    txtOtrosIngresos.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("OtrosIngresos")), 0, dts.Tables(0).Rows(0).Item("OtrosIngresos"))
                End If
                'Actividad economica secundaria
                If IIf(IsDBNull(dts.Tables(0).Rows(0).Item("idActividadEconomica2")), 0, dts.Tables(0).Rows(0).Item("idActividadEconomica2")) > 0 Then
                    idActEcoSec = dts.Tables(0).Rows(0).Item("idActividadEconomica2")
                    Me.cbLugarTrabajo2.SelectedValue = dts.Tables(0).Rows(0).Item("CodLugarTrabajo2")
                    Me.txtCodActividadEco2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("CodigoActividadEconomica2")), "", dts.Tables(0).Rows(0).Item("CodigoActividadEconomica2"))
                    txtDescripcionActEco2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("descActEcoSec")), "", dts.Tables(0).Rows(0).Item("descActEcoSec"))
                    txtNoAcreUIF2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NoAcreditacion2")), "", dts.Tables(0).Rows(0).Item("NoAcreditacion2"))
                    dtpFechAcre2.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaAcreditacion2")), Now, dts.Tables(0).Rows(0).Item("FechaAcreditacion2"))
                    dtpVencimientoUIF2.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaVencimiento2")), Now, dts.Tables(0).Rows(0).Item("FechaVencimiento2"))
                    chkNegFormal2.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NegocioFormal2")), False, dts.Tables(0).Rows(0).Item("NegocioFormal2"))
                    chkcontribuyente2.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Contribuyente2")), False, dts.Tables(0).Rows(0).Item("Contribuyente2"))
                    txtNoRegContribuyente2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NumRegistroContribuyente2")), "", dts.Tables(0).Rows(0).Item("NumRegistroContribuyente2"))
                    If chkcontribuyente2.Checked = False Then
                        Me.txtNoRegContribuyente2.Enabled = False
                    End If
                    txtNomComEc2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NombreComercial2")), "", dts.Tables(0).Rows(0).Item("NombreComercial2"))
                    txtRazonSocialSec.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("RazonSocial2")), "", dts.Tables(0).Rows(0).Item("RazonSocial2"))
                    txtGiroSec.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Giro2")), "", dts.Tables(0).Rows(0).Item("Giro2"))
                    cbEstadoLaboral2.SelectedValue = dts.Tables(0).Rows(0).Item("EstadoLaboral2")
                    txtDptoTrabajo2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("AreaTrabajo2")), "", dts.Tables(0).Rows(0).Item("AreaTrabajo2"))
                    dtpFechaIniTra2.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaInicioTrabajo2")), Now, dts.Tables(0).Rows(0).Item("FechaInicioTrabajo2"))
                    Me.txtCargo2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Cargo2")), "", dts.Tables(0).Rows(0).Item("Cargo2"))
                    txtIngresosSec.Value = dts.Tables(0).Rows(0).Item("Ingresos2")
                    txtTotalIngresosSec.Value = dts.Tables(0).Rows(0).Item("Ingresos") + IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Ingresos2")), 0, dts.Tables(0).Rows(0).Item("Ingresos2")) + IIf(IsDBNull(dts.Tables(0).Rows(0).Item("OtrosIngresos")), 0, dts.Tables(0).Rows(0).Item("OtrosIngresos"))
                    txtTelOficina2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("TelOficina2")), "", dts.Tables(0).Rows(0).Item("TelOficina2"))
                    txtExtOficinaSec.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("ExtOficina2")), "", dts.Tables(0).Rows(0).Item("ExtOficina2"))
                    cbDeptoOfi2.SelectedValue = dts.Tables(0).Rows(0).Item("codDeptoAE2")
                    llenarCbMunicipioActEco2(dts.Tables(0).Rows(0).Item("codDeptoAE2"))
                    cbMunOfi2.SelectedValue = dts.Tables(0).Rows(0).Item("codMunAE2")
                    txtDirOfi2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("direccionAE2")), "", dts.Tables(0).Rows(0).Item("direccionAE2"))
                    txtDetIngresos.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("DescripcionIngreso2")), "", dts.Tables(0).Rows(0).Item("DescripcionIngreso2"))

                End If
                'declaracion jurada
                If IIf(IsDBNull(dts.Tables(0).Rows(0).Item("idDeclaracionJurada")), 0, dts.Tables(0).Rows(0).Item("idDeclaracionJurada")) > 0 Then
                    idDeclaracionJurada = dts.Tables(0).Rows(0).Item("idDeclaracionJurada")
                    idDeclaracion = dts.Tables(0).Rows(0).Item("idDeclaracionJurada")
                    txtDepProm.Value = dts.Tables(0).Rows(0).Item("depositosPromMensual")
                    chkInversionista.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("inversionista")), False, dts.Tables(0).Rows(0).Item("inversionista"))
                    txtRetPromMen.Value = dts.Tables(0).Rows(0).Item("retirosPromMensual")
                    txtDestCta.Text = dts.Tables(0).Rows(0).Item("PropositoCuenta")
                    txtOriFondos.Text = dts.Tables(0).Rows(0).Item("origenFondos")
                    txtMontoPromDpf.Value = dts.Tables(0).Rows(0).Item("montoPromedioDpf")
                    chkDocOrigen.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("presentoDocOrigenFondos")), False, dts.Tables(0).Rows(0).Item("presentoDocOrigenFondos"))
                    txtOrigenFondosDpf.Text = dts.Tables(0).Rows(0).Item("origenFondosDpf")
                    llenarDgDocumentos(idDeclaracionJurada)
                End If
                'informacion complementaria
                cbNivelEducativo.SelectedValue = dts.Tables(0).Rows(0).Item("idNivelEducacion")
                txtTituloObtenido.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("TituloObtenido")), "", dts.Tables(0).Rows(0).Item("TituloObtenido"))
                txtNombreConyugue.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NombreConyugue")), "", dts.Tables(0).Rows(0).Item("NombreConyugue"))
                dtpFechaNacConyugue.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaNacConyugue")), Now, dts.Tables(0).Rows(0).Item("FechaNacConyugue"))
                cbProfesionConyugue.SelectedValue = dts.Tables(0).Rows(0).Item("CodProfesionConyugue")
                txtOficioConyugue.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Oficio")), "", dts.Tables(0).Rows(0).Item("Oficio"))
                cbTrabajoConyugue.SelectedValue = dts.Tables(0).Rows(0).Item("codLugarTrabajoConyugue")
                txtTelConyugue.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("telefonoConyugue")), "", dts.Tables(0).Rows(0).Item("telefonoConyugue"))
                txtCodActEcoCon.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("idActividadEconomicaConyugue")), "", dts.Tables(0).Rows(0).Item("idActividadEconomicaConyugue"))
                txtDescripcionActEcoCon.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("descripcionActEcoCony")), "", dts.Tables(0).Rows(0).Item("descripcionActEcoCony"))
                txtSueldoConyugue.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("SueldoConyugue")), 0, dts.Tables(0).Rows(0).Item("SueldoConyugue"))
                txtIngresoPromMensualConyugue.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("IngresoPromConyugue")), 0, dts.Tables(0).Rows(0).Item("IngresoPromConyugue"))
                nuDNumDep.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NumDependientes")), 0, dts.Tables(0).Rows(0).Item("NumDependientes"))
                nuDGrupoFam.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NumGrupoFam")), 0, dts.Tables(0).Rows(0).Item("NumGrupoFam"))
                cbEstadoVivienda.SelectedValue = dts.Tables(0).Rows(0).Item("idEstadoVivienda")
                txtTiempoResidencia.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("TiempoResidencia")), "", dts.Tables(0).Rows(0).Item("TiempoResidencia"))
                chkFueDir.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FueDirectivo")), False, dts.Tables(0).Rows(0).Item("FueDirectivo"))
                chkDir.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Directivo")), False, dts.Tables(0).Rows(0).Item("Directivo"))
                txtPerFueDir.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("PeriodoFueDirectivo")), "", dts.Tables(0).Rows(0).Item("PeriodoFueDirectivo"))
                txtPeriodoNombramiento.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("PeriodoDirectivo")), "", dts.Tables(0).Rows(0).Item("PeriodoDirectivo"))
                cbCuerpoDir.SelectedValue = dts.Tables(0).Rows(0).Item("CodCuerpoDirectivo")
                'otros datos
                cbEstadoAsociado.SelectedIndex = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("EstadoAsociado")), 0, dts.Tables(0).Rows(0).Item("EstadoAsociado"))
                cbEjecutivo.SelectedValue = dts.Tables(0).Rows(0).Item("CodEjecMercadeo")
                txtObservacion.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Observaciones_Aspirante")), "", dts.Tables(0).Rows(0).Item("Observaciones_Aspirante"))
                cbTipoCuota.SelectedValue = dts.Tables(0).Rows(0).Item("CodCuota")
                'PEP
                If IIf(IsDBNull(dts.Tables(0).Rows(0).Item("idPep")), 0, dts.Tables(0).Rows(0).Item("idPep")) > 0 Then
                    idPep = dts.Tables(0).Rows(0).Item("idPep")
                    dtpFechaNomPEP.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaNombramiento")), Now, dts.Tables(0).Rows(0).Item("FechaNombramiento"))
                    txtPeriodoNombramiento.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("PeriodoNombramiento")), "", dts.Tables(0).Rows(0).Item("PeriodoNombramiento"))
                    cbTipoPep.SelectedValue = dts.Tables(0).Rows(0).Item("codTipoPep")
                    txtTiempoLaboral.Value = dts.Tables(0).Rows(0).Item("TiempoLaboral")
                    chkPepActivo.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("PepActivo")), False, dts.Tables(0).Rows(0).Item("PepActivo"))
                    llenarDgFamiliaresPep(idPep)
                    llenarDgSociedadesPep(idPep)
                    cbParentescoPep.SelectedValue = dts.Tables(0).Rows(0).Item("codParentesco")
                End If
                llenarDgRelaciones(txtDui.Text)
                llenarDgBeneficiarios(txtDui.Text)
                llenarDgReferencias(txtDui.Text)
            End If
        End If
        'If dts.Tables.Count > 0 Then
        '    If dts.Tables(0).Rows.Count > 0 Then
        '        'Datos Personales
        '        txtDui.Text = dui
        '        txtNoPasaporte.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NumPasaporte")), "", dts.Tables(0).Rows(0).Item("NumPasaporte"))
        '        cbEstadoIngreso.SelectedValue = dts.Tables(0).Rows(0).Item("EstadoIngreso")
        '        txtNosocio.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NoSocio")), "", dts.Tables(0).Rows(0).Item("NoSocio"))
        '        chkPersonaJuridica.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("PersonaJuridica")), False, dts.Tables(0).Rows(0).Item("PersonaJuridica"))
        '        chkResidente.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Residente")), False, IIf(dts.Tables(0).Rows(0).Item("Residente") = "F", False, True))
        '        txtNoResidente.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NoResidente")), " ", dts.Tables(0).Rows(0).Item("NoResidente"))
        '        txtNombres.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Nombres")), " ", dts.Tables(0).Rows(0).Item("Nombres"))
        '        txtPrimerApellido.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellido1")), " ", dts.Tables(0).Rows(0).Item("apellido1"))
        '        txtSegApellido.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellido2")), " ", dts.Tables(0).Rows(0).Item("apellido2"))
        '        txtApellidoCasada.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellidoCas")), " ", dts.Tables(0).Rows(0).Item("apellidoCas"))
        '        txtConocidoPor.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("conocidoPor")), " ", dts.Tables(0).Rows(0).Item("conocidoPor"))
        '        Me.cbPrimerNacionalidad.SelectedValue = dts.Tables(0).Rows(0).Item("codNacionalidad")
        '        chkDobleNacionalidad.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("dobleNacionalidad")), False, dts.Tables(0).Rows(0).Item("dobleNacionalidad"))
        '        If chkDobleNacionalidad.Checked = False Then
        '            Me.cbSegNacionalidad.Enabled = False
        '        End If
        '        If Me.chkResidente.Checked = False Then
        '            txtNoResidente.Enabled = False
        '        End If
        '        Me.cbSegNacionalidad.SelectedValue = dts.Tables(0).Rows(0).Item("codNacionalidad2")
        '        txtExtDui.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("lugarExtDui")), " ", dts.Tables(0).Rows(0).Item("lugarExtDui"))
        '        cbProfesionDui.SelectedValue = dts.Tables(0).Rows(0).Item("codProfesion")
        '        dtpFechaExtDui.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaExtDUI")), Now, dts.Tables(0).Rows(0).Item("FechaExtDUI"))
        '        dtpFechaNac.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Fecha_Nac")), Now, dts.Tables(0).Rows(0).Item("Fecha_Nac"))
        '        Me.cbSexo.SelectedIndex = dts.Tables(0).Rows(0).Item("sexo")
        '        Me.cbEstadoCivil.SelectedValue = dts.Tables(0).Rows(0).Item("EstadoCivil")
        '        txtNit.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NIT")), "", dts.Tables(0).Rows(0).Item("NIT"))
        '        txtIsss.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("ISSS")), "", dts.Tables(0).Rows(0).Item("ISSS"))
        '        Me.cbDepto.SelectedValue = dts.Tables(0).Rows(0).Item("CodDepartamento")
        '        llenarCbMunicipio(dts.Tables(0).Rows(0).Item("CodDepartamento"))
        '        Me.cbMunicipio.SelectedValue = dts.Tables(0).Rows(0).Item("CodMunicipio")
        '        txtDireccion.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("direccion")), "", dts.Tables(0).Rows(0).Item("direccion"))
        '        txtTelCasa.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("telCasa")), "", dts.Tables(0).Rows(0).Item("telCasa"))
        '        txtCelular.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("celular")), "", dts.Tables(0).Rows(0).Item("celular"))
        '        txtCorreo.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("email")), "", dts.Tables(0).Rows(0).Item("email"))
        '        'Persona Juridica
        '        If chkPersonaJuridica.Checked = True Then
        '            idCatPersonaJuridica = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("idCatPerJuridica")), 0, dts.Tables(0).Rows(0).Item("idCatPerJuridica"))
        '            txtRazSocial.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("RazonSocial")), "", dts.Tables(0).Rows(0).Item("RazonSocial"))
        '            txtNomComercial.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NombreComercial")), "", dts.Tables(0).Rows(0).Item("NombreComercial"))
        '            txtRepresentanteLegal.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("RepresentanteLegal")), "", dts.Tables(0).Rows(0).Item("RepresentanteLegal"))
        '            txtNoRegContribuyente.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NoRegContribuyente")), "", dts.Tables(0).Rows(0).Item("NoRegContribuyente"))
        '            txtNitEmpresa.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NitEmpresa")), "", dts.Tables(0).Rows(0).Item("NitEmpresa"))
        '            txtTelPerJur.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("TelPJ")), "", dts.Tables(0).Rows(0).Item("TelPJ"))
        '            cbDeptoPerJur.SelectedValue = dts.Tables(0).Rows(0).Item("codDeptoPJ")
        '            llenarCbMunicipioJur(dts.Tables(0).Rows(0).Item("codDeptoPJ"))
        '            cbMunicipioJur.SelectedValue = dts.Tables(0).Rows(0).Item("codMunPJ")
        '            txtDirPerJur.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("direccionPJ")), "", dts.Tables(0).Rows(0).Item("direccionPJ"))
        '            llenarDgJuntaDirectiva(idCatPersonaJuridica)
        '        End If
        '        'Actividad economica primaria
        '        If IIf(IsDBNull(dts.Tables(0).Rows(0).Item("idActividadEconomica")), 0, dts.Tables(0).Rows(0).Item("idActividadEconomica")) > 0 Then
        '            idActEcoPrim = dts.Tables(0).Rows(0).Item("idActividadEconomica")
        '            Me.cbLugarTrabajo.SelectedValue = dts.Tables(0).Rows(0).Item("CodLugarTrabajo")
        '            Me.txtCodActEconomica.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("CodigoActividadEconomica")), "", dts.Tables(0).Rows(0).Item("CodigoActividadEconomica"))
        '            txtDescripcionActEco.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("descActEcoPrim")), "", dts.Tables(0).Rows(0).Item("descActEcoPrim"))
        '            txtNoAcreUIF.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NoAcreditacion")), "", dts.Tables(0).Rows(0).Item("NoAcreditacion"))
        '            dtpFechAcre.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaAcreditacion")), Now, dts.Tables(0).Rows(0).Item("FechaAcreditacion"))
        '            dtpVencimientoUIF.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaVencimiento")), Now, dts.Tables(0).Rows(0).Item("FechaVencimiento"))
        '            chkNegFormal.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NegocioFormal")), False, dts.Tables(0).Rows(0).Item("NegocioFormal"))
        '            chkcontribuyente.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Contribuyente")), False, dts.Tables(0).Rows(0).Item("Contribuyente"))
        '            txtNoRegContribuyente.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NumRegistroContribuyente")), "", dts.Tables(0).Rows(0).Item("NumRegistroContribuyente"))
        '            If chkcontribuyente.Checked = False Then
        '                Me.txtNoRegContribuyente.Enabled = False
        '            End If
        '            txtNomComEc.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NombreComercial")), "", dts.Tables(0).Rows(0).Item("NombreComercial"))
        '            txtRazonSocialPrim.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("RazonSocial")), "", dts.Tables(0).Rows(0).Item("RazonSocial"))
        '            txtGiroPrim.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Giro")), "", dts.Tables(0).Rows(0).Item("Giro"))
        '            cbEstadoLaboral.SelectedValue = dts.Tables(0).Rows(0).Item("EstadoLaboral")
        '            txtDptoTrabajo.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("AreaTrabajo")), "", dts.Tables(0).Rows(0).Item("AreaTrabajo"))
        '            dtpFechaIniTra.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaInicioTrabajo")), Now, dts.Tables(0).Rows(0).Item("FechaInicioTrabajo"))
        '            Me.txtCargo.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Cargo")), "", dts.Tables(0).Rows(0).Item("Cargo"))
        '            txtIngresosPrim.Value = dts.Tables(0).Rows(0).Item("Ingresos")
        '            txtTotalIngresosPrim.Value = dts.Tables(0).Rows(0).Item("TotalIngresos")
        '            txtTelOficina.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("TelOficina")), "", dts.Tables(0).Rows(0).Item("TelOficina"))
        '            txtExtOficinaPrim.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("ExtOficina")), "", dts.Tables(0).Rows(0).Item("ExtOficina"))
        '            cbDeptoOfi.SelectedValue = dts.Tables(0).Rows(0).Item("codDeptoAE")
        '            llenarCbMunicipioActEco1(dts.Tables(0).Rows(0).Item("codDeptoAE"))
        '            cbMunOfi.SelectedValue = dts.Tables(0).Rows(0).Item("codMunAE")
        '            txtDirOfi.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("direccionAE")), "", dts.Tables(0).Rows(0).Item("direccionAE"))
        '        End If
        '        'Actividad economica secundaria
        '        If IIf(IsDBNull(dts.Tables(0).Rows(0).Item("idActividadEconomica2")), 0, dts.Tables(0).Rows(0).Item("idActividadEconomica2")) > 0 Then
        '            idActEcoSec = dts.Tables(0).Rows(0).Item("idActividadEconomica2")
        '            Me.cbLugarTrabajo2.SelectedValue = dts.Tables(0).Rows(0).Item("CodLugarTrabajo2")
        '            Me.txtCodActividadEco2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("CodigoActividadEconomica2")), "", dts.Tables(0).Rows(0).Item("CodigoActividadEconomica2"))
        '            txtDescripcionActEco2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("descActEcoSec")), "", dts.Tables(0).Rows(0).Item("descActEcoSec"))
        '            txtNoAcreUIF2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NoAcreditacion2")), "", dts.Tables(0).Rows(0).Item("NoAcreditacion2"))
        '            dtpFechAcre2.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaAcreditacion2")), Now, dts.Tables(0).Rows(0).Item("FechaAcreditacion2"))
        '            dtpVencimientoUIF2.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaVencimiento2")), Now, dts.Tables(0).Rows(0).Item("FechaVencimiento2"))
        '            chkNegFormal2.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NegocioFormal2")), False, dts.Tables(0).Rows(0).Item("NegocioFormal2"))
        '            chkcontribuyente2.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Contribuyente2")), False, dts.Tables(0).Rows(0).Item("Contribuyente2"))
        '            txtNoRegContribuyente2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NumRegistroContribuyente2")), "", dts.Tables(0).Rows(0).Item("NumRegistroContribuyente2"))
        '            If chkcontribuyente2.Checked = False Then
        '                Me.txtNoRegContribuyente2.Enabled = False
        '            End If
        '            txtNomComEc2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NombreComercial2")), "", dts.Tables(0).Rows(0).Item("NombreComercial2"))
        '            txtRazonSocialSec.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("RazonSocial2")), "", dts.Tables(0).Rows(0).Item("RazonSocial2"))
        '            txtGiroSec.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Giro2")), "", dts.Tables(0).Rows(0).Item("Giro2"))
        '            cbEstadoLaboral2.SelectedValue = dts.Tables(0).Rows(0).Item("EstadoLaboral2")
        '            txtDptoTrabajo2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("AreaTrabajo2")), "", dts.Tables(0).Rows(0).Item("AreaTrabajo2"))
        '            dtpFechaIniTra2.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaInicioTrabajo2")), Now, dts.Tables(0).Rows(0).Item("FechaInicioTrabajo2"))
        '            Me.txtCargo2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Cargo2")), "", dts.Tables(0).Rows(0).Item("Cargo2"))
        '            txtIngresosSec.Value = dts.Tables(0).Rows(0).Item("Ingresos2")
        '            txtTotalIngresosSec.Value = dts.Tables(0).Rows(0).Item("TotalIngresos2")
        '            txtTelOficina2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("TelOficina2")), "", dts.Tables(0).Rows(0).Item("TelOficina2"))
        '            txtExtOficinaSec.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("ExtOficina2")), "", dts.Tables(0).Rows(0).Item("ExtOficina2"))
        '            cbDeptoOfi2.SelectedValue = dts.Tables(0).Rows(0).Item("codDeptoAE2")
        '            llenarCbMunicipioActEco2(dts.Tables(0).Rows(0).Item("codDeptoAE2"))
        '            cbMunOfi2.SelectedValue = dts.Tables(0).Rows(0).Item("codMunAE2")
        '            txtDirOfi2.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("direccionAE2")), "", dts.Tables(0).Rows(0).Item("direccionAE2"))
        '        End If
        '        'Información complementaria
        '        If IIf(IsDBNull(dts.Tables(0).Rows(0).Item("idDeclaracionJurada")), 0, dts.Tables(0).Rows(0).Item("idDeclaracionJurada")) > 0 Then
        '            idDeclaracionJurada = dts.Tables(0).Rows(0).Item("idDeclaracionJurada")
        '            txtDepProm.Value = dts.Tables(0).Rows(0).Item("depositosPromMensual")
        '            chkInversionista.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("inversionista")), False, dts.Tables(0).Rows(0).Item("inversionista"))
        '            txtRetPromMen.Value = dts.Tables(0).Rows(0).Item("retirosPromMensual")
        '            txtDestCta.Text = dts.Tables(0).Rows(0).Item("PropositoCuenta")
        '            txtOriFondos.Text = dts.Tables(0).Rows(0).Item("origenFondos")
        '            txtMontoPromDpf.Value = dts.Tables(0).Rows(0).Item("montoPromedioDpf")
        '            chkDocOrigen.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("presentoDocOrigenFondos")), False, dts.Tables(0).Rows(0).Item("presentoDocOrigenFondos"))
        '            txtOrigenFondosDpf.Text = dts.Tables(0).Rows(0).Item("origenFondosDpf")
        '            llenarDgDocumentos(idDeclaracionJurada)
        '        End If
        '        'informacion complementaria
        '        cbNivelEducativo.SelectedValue = dts.Tables(0).Rows(0).Item("idNivelEducacion")
        '        txtTituloObtenido.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("TituloObtenido")), "", dts.Tables(0).Rows(0).Item("TituloObtenido"))
        '        txtNombreConyugue.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("NombreConyugue")), "", dts.Tables(0).Rows(0).Item("NombreConyugue"))
        '        dtpFechaNacConyugue.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaNacConyugue")), Now, dts.Tables(0).Rows(0).Item("FechaNacConyugue"))
        '        cbProfesionConyugue.SelectedValue = dts.Tables(0).Rows(0).Item("CodProfesionConyugue")
        '        txtOficioConyugue.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Oficio")), "", dts.Tables(0).Rows(0).Item("Oficio"))
        '        cbTrabajoConyugue.SelectedValue = dts.Tables(0).Rows(0).Item("codLugarTrabajoConyugue")
        '        txtTelConyugue.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("telefonoConyugue")), "", dts.Tables(0).Rows(0).Item("telefonoConyugue"))
        '        txtCodActEcoCon.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("idActividadEconomicaConyugue")), "", dts.Tables(0).Rows(0).Item("idActividadEconomicaConyugue"))
        '        txtDescripcionActEcoCon.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("descripcionActEcoCony")), "", dts.Tables(0).Rows(0).Item("descripcionActEcoCony"))
        '        txtSueldoConyugue.Value = dts.Tables(0).Rows(0).Item("SueldoConyugue")
        '        txtIngresoPromMensualConyugue.Value = dts.Tables(0).Rows(0).Item("IngresoPromConyugue")
        '        nuDNumDep.Value = dts.Tables(0).Rows(0).Item("NumDependientes")
        '        nuDGrupoFam.Value = dts.Tables(0).Rows(0).Item("NumGrupoFam")
        '        cbEstadoVivienda.SelectedValue = dts.Tables(0).Rows(0).Item("EstadoVivienda")
        '        txtTiempoResidencia.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("TiempoResidencia")), "", dts.Tables(0).Rows(0).Item("TiempoResidencia"))
        '        chkFueDir.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FueDirectivo")), False, dts.Tables(0).Rows(0).Item("FueDirectivo"))
        '        chkDir.Checked = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Directivo")), False, dts.Tables(0).Rows(0).Item("Directivo"))
        '        txtPerFueDir.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("PeriodoFueDirectivo")), "", dts.Tables(0).Rows(0).Item("PeriodoFueDirectivo"))
        '        txtPeriodoNombramiento.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("PeriodoDirectivo")), "", dts.Tables(0).Rows(0).Item("PeriodoDirectivo"))
        '        cbCuerpoDir.SelectedValue = dts.Tables(0).Rows(0).Item("CodCuerpoDirectivo")
        '        'otros datos
        '        cbEstadoAsociado.SelectedIndex = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("EstadoAsociado")), 0, dts.Tables(0).Rows(0).Item("EstadoAsociado"))
        '        cbEjecutivo.SelectedValue = dts.Tables(0).Rows(0).Item("CodEjecMercadeo")
        '        txtObservacion.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Observaciones_Aspirante")), "", dts.Tables(0).Rows(0).Item("Observaciones_Aspirante"))
        '        cbTipoCuota.SelectedValue = dts.Tables(0).Rows(0).Item("CodCuota")
        '        'PEP
        '        If IIf(IsDBNull(dts.Tables(0).Rows(0).Item("idPep")), 0, dts.Tables(0).Rows(0).Item("idPep")) > 0 Then
        '            idPep = dts.Tables(0).Rows(0).Item("idPep")
        '            dtpFechaNomPEP.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaNombramiento")), Now, dts.Tables(0).Rows(0).Item("FechaNombramiento"))
        '            txtPeriodoNombramiento.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("PeriodoNombramiento")), "", dts.Tables(0).Rows(0).Item("PeriodoNombramiento"))
        '            cbTipoPep.SelectedValue = dts.Tables(0).Rows(0).Item("codTipoPep")
        '            txtTiempoLaboral.Value = dts.Tables(0).Rows(0).Item("TiempoLaboral")
        '            llenarDgFamiliaresPep(idPep)
        '            llenarDgSociedadesPep(idPep)
        '        End If
        '        llenarDgBeneficiarios(txtDui.Text)
        '        llenarDgReferencias(txtDui.Text)
        '    End If
        'End If
    End Sub
    Private Sub frmMsIngresoAsociados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.cbPrimerNacionalidad.DisplayMember = "Descripcion"
        Me.cbPrimerNacionalidad.ValueMember = "codNacionalidad"
        Me.cbSegNacionalidad.DisplayMember = "Descripcion"
        Me.cbSegNacionalidad.ValueMember = "codNacionalidad"
        Me.cbDepto.ValueMember = "codDepartamento"
        Me.cbDepto.DisplayMember = "Departamento"
        Me.cbMunicipio.ValueMember = "codMunicipio"
        Me.cbMunicipio.DisplayMember = "Municipio"
        Me.cbEstadoCivil.DisplayMember = "Descripcion"
        Me.cbEstadoCivil.ValueMember = "idCatalogo"
        Me.cbLugarTrabajo.DisplayMember = "Nombre"
        Me.cbLugarTrabajo2.DisplayMember = "Nombre"
        Me.cbLugarTrabajo.ValueMember = "CodPagaduria"
        Me.cbLugarTrabajo2.ValueMember = "CodPagaduria"
        Me.cbTrabajoConyugue.ValueMember = "CodPagaduria"
        Me.cbTrabajoConyugue.DisplayMember = "Nombre"
        Me.cbEstadoLaboral.DisplayMember = "Descripcion"
        Me.cbEstadoLaboral.ValueMember = "idCatalogo"
        Me.cbEstadoLaboral2.DisplayMember = "Descripcion"
        Me.cbEstadoLaboral2.ValueMember = "idCatalogo"
        Me.cbMunOfi.ValueMember = "codMunicipio"
        Me.cbMunOfi.DisplayMember = "Municipio"
        Me.cbMunOfi2.ValueMember = "codMunicipio"
        Me.cbMunOfi2.DisplayMember = "Municipio"
        Me.cbDeptoOfi.ValueMember = "codDepartamento"
        Me.cbDeptoOfi.DisplayMember = "Departamento"
        Me.cbDeptoOfi2.ValueMember = "codDepartamento"
        Me.cbDeptoOfi2.DisplayMember = "Departamento"
        Me.cbNivelEducativo.DisplayMember = "Descripcion"
        Me.cbNivelEducativo.ValueMember = "idCatalogo"
        Me.cbProfesionDui.ValueMember = "codProfesion"
        Me.cbProfesionDui.DisplayMember = "Descripcion"
        Me.cbProfesionConyugue.ValueMember = "codProfesion"
        Me.cbProfesionConyugue.DisplayMember = "Descripcion"
        Me.cbCuerpoDir.DisplayMember = "Descripcion"
        Me.cbCuerpoDir.ValueMember = "CodCuerpoDirectivo"
        Me.cbEstadoIngreso.DisplayMember = "Descripcion"
        Me.cbEstadoIngreso.ValueMember = "idCatalogo"
        Me.cbEjecutivo.ValueMember = "CodEjecMercadeo"
        Me.cbEjecutivo.DisplayMember = "Nombres"
        '================================================
        'Pestaña Persona Judicial
        Me.cbDeptoPerJur.ValueMember = "codDepartamento"
        Me.cbDeptoPerJur.DisplayMember = "Departamento"
        Me.cbMunicipioJur.ValueMember = "codMunicipio"
        Me.cbMunicipioJur.DisplayMember = "Municipio"
        '================================================
        'Pestaña pep
        Me.cbTipoPep.DisplayMember = "Descripcion"
        Me.cbTipoPep.ValueMember = "idCatalogo"
        '================================================
        'Llenamos todos los combobox del formulario
        'llenarCbTipoPersona()
        llenarCbNacionalidad()
        llenarCbDepartamentos()
        llenarDeptoActEco1()
        llenarDeptoActEco2()
        llenarCbEstadoCivil()
        llenarCbEstadoCivil()
        llenarcbLugarTrabajoPrimario()
        llenarcbLugarTrabajoSec()
        llenarCbEstadoLaboral()
        llenarCbNivelEducativo()
        llenarCbProfesiones()
        llenarCbCuerpoDirectivo()
        llenarEstadoIngreso()
        llenarCbLugarTrabajoConyugue()
        llenarCbProfesionConyugue()
        llenarEjecutivso()
        llenarCbTipoPep()
        llenarCbCuotaIngreso()
        llenarEstadoVivienda()
        llenarCbDepartamentosJur()
        llenarCbParentescoPep()
        llenarCbEstadoLaboralSecundario()
        'llenarCbMunicipioJur()
        Me.chkDir.Enabled = True
        If accion = 1 Then
            Me.cbSegNacionalidad.Enabled = False
            Me.txtNoResidente.Enabled = False
            Me.txtNoRegContribuyente.Enabled = False
            Me.txtNoRegContribuyente2.Enabled = False
            Me.txtPerFueDir.Enabled = False
            Me.txtCuerpoDir.Enabled = False
            'Me.cbCuerpoDir.Enabled = False
            Me.cbEstadoIngreso.Enabled = False
            Me.cbEstadoAsociado.SelectedIndex = 0
            Me.cbEstadoAsociado.Enabled = False
            '=================================================
            'Deshabilita controles de persona judicial
            habilitarCamposPerJuridica(False)
            'Me.txtRazSocial.ReadOnly = True
            'Me.txtNomComercial.ReadOnly = True
            'Me.txtRepresentanteLegal.ReadOnly = True
            'txtNoRegContribuyenteJur.ReadOnly = True
            'txtNitEmpresa.ReadOnly = True
            'txtTelPerJur.ReadOnly = True
            'txtDirPerJur.ReadOnly = True
            'Me.cbMunicipioJur.Enabled = False
            'Me.cbDeptoPerJur.Enabled = False
            '=================================================
            'deshabilita controles en pep
            Me.btnAgregarSociedad.Enabled = False
            Me.btnAgregarFam.Enabled = False
        ElseIf accion = 2 Then
            llenarDatosAsoc(dui)
            Me.cbEstadoAsociado.Enabled = False
            Me.cbEstadoIngreso.Enabled = False
            txtDui.Enabled = False
            txtNosocio.Enabled = False
            txtDui.Value = dui
            Me.cbEjecutivo.Enabled = False
        ElseIf accion = 3 Then
            llenarDatosAsoc(dui)
            Me.cbEstadoAsociado.Enabled = False
            Me.cbEstadoIngreso.Enabled = False
            txtDui.Enabled = False
            txtNosocio.Enabled = False
            txtDui.Value = dui
            Me.cbEjecutivo.Enabled = False
            btnGuardarDatPer.Enabled = False
            btnGuardarInfComp.Enabled = False
            btnGuardarOtrosDatos.Enabled = False
            btnGuardarPep.Enabled = False
            btnGuardarTp2.Enabled = False

        End If

    End Sub
    Private Sub cbDepto_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDepto.DropDownClosed
        Me.llenarCbMunicipio(Me.cbDepto.SelectedValue)
    End Sub
    Private Sub cbDeptoOfi2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDeptoOfi2.Click
        Me.llenarCbMunicipioOfi2(Me.cbDeptoOfi2.SelectedValue)
    End Sub
    Private Sub cbDeptoOfi_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDeptoOfi.DropDownClosed
        Me.llenarCbMunicipioActEco1(Me.cbDeptoOfi.SelectedValue)
    End Sub
    Private Sub chkDobleNacionalidad_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDobleNacionalidad.CheckedChanged
        If Me.chkDobleNacionalidad.Checked = True Then
            Me.cbSegNacionalidad.Enabled = True
            llenarCbSegNacionalidad2()
        Else
            Me.cbSegNacionalidad.Enabled = False
        End If

    End Sub
    Private Sub chkResidente_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkResidente.CheckedChanged
        If Me.chkResidente.Checked = True Then
            Me.txtNoResidente.Enabled = True
        Else
            Me.txtNoResidente.Enabled = False
            Me.txtNoResidente.Text = ""
        End If
    End Sub
    Private Sub chkcontribuyente_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkcontribuyente.CheckedChanged
        If Me.chkcontribuyente.Checked = True Then
            txtNoRegContribuyente.Enabled = True
        Else
            txtNoRegContribuyente.Enabled = False
        End If
    End Sub
    Private Sub chkcontribuyente2_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkcontribuyente2.CheckedChanged
        If Me.chkcontribuyente2.Checked = True Then
            txtNoRegContribuyente2.Enabled = True
        Else
            txtNoRegContribuyente2.Enabled = False
        End If
    End Sub
    Private Sub chkFueDir_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkFueDir.CheckedChanged
        If Me.chkFueDir.Checked = True Then
            Me.txtPerFueDir.Enabled = True
            Me.cbCuerpoDir.Enabled = True
            Me.chkDir.Enabled = False
        Else
            Me.txtPerFueDir.Text = ""
            Me.txtPerFueDir.Enabled = False
            Me.cbCuerpoDir.Enabled = False
            Me.chkDir.Enabled = True
        End If
    End Sub
    Private Sub chkDir_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDir.CheckedChanged
        If Me.chkDir.Checked = True Then
            Me.txtCuerpoDir.Enabled = True
            txtCuerpoDir.ReadOnly = False
            Me.cbCuerpoDir.Enabled = True
            Me.chkFueDir.Enabled = False
        Else
            txtCuerpoDir.Text = ""
            Me.txtCuerpoDir.Enabled = False
            Me.cbCuerpoDir.Enabled = False
            Me.chkFueDir.Enabled = True
        End If
    End Sub
#End Region
#Region "Validaciones"
    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" & _
        "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True
        Else
            EmailAddressCheck = False
        End If
    End Function
    Private Sub txtCorreo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCorreo.Validating
        If txtCorreo.Text.Length > 0 Then
            If EmailAddressCheck(txtCorreo.Text.Trim) = False Then
                Dim result As DialogResult _
                = MessageBox.Show("La dirección de correo electronico ingresada no es valida." & _
                                           "Por favor ingresar una dirección valida.", "Correo electronico invalido", _
                                           MessageBoxButtons.OK, MessageBoxIcon.Error)
                If result = Windows.Forms.DialogResult.Yes Then
                    e.Cancel = True
                End If
            End If
        End If
        
    End Sub
#End Region
#Region "Funciones"
#Region "Llenar ComboBox"
    'Public Sub llenarCbTipoPersona()
    '    Dim dts As New DataSet
    '    dts = asociados.consultarDbCatalogosCatalogos(0, wsSysFinCoop.LibAsoc.tipoCatalogo.tipoPersona, _
    '                                                  wsSysFinCoop.LibAsoc.tipoConsultaCatalogos.detalleCatalogo)
    '    If dts.Tables.Count > 0 Then
    '        If dts.Tables(0).Rows.Count > 0 Then
    '            Me.cbTipoPersona.DataSource = dts.Tables(0)
    '        End If
    '    End If
    'End Sub
    Public Sub llenarEjecutivso()
        Dim dtsEjec As New DataSet
        dtsEjec = asociados.ConsultarEjecutivosMercadeoxFiltro(" a.estado = '1'", sUsuario, sPassword, sSucursal)
        If dtsEjec.Tables(0).Rows.Count > 0 Then
            Me.cbEjecutivo.DataSource = dtsEjec.Tables(0)
        End If
    End Sub
    Public Sub llenarCbNacionalidad()
        Dim dtsNac As New DataSet
        dtsNac = asociados.ConsultarNacionalidades("codNacionalidad,Descripcion", "", "descripcion", sUsuario, sPassword, sSucursal)
        If dtsNac.Tables(0).Rows.Count > 0 Then
            Me.cbPrimerNacionalidad.DataSource = dtsNac.Tables(0)
        End If
    End Sub
    Public Sub llenarCbSegNacionalidad2()
        Dim dtsNac As New DataSet
        dtsNac = asociados.ConsultarNacionalidades("codNacionalidad,Descripcion", "", "descripcion", sUsuario, sPassword, sSucursal)
        If dtsNac.Tables(0).Rows.Count > 0 Then
            Me.cbSegNacionalidad.DataSource = dtsNac.Tables(0)
        End If
    End Sub
    Public Sub llenarCbDepartamentos()
        Dim dtsDepto As New DataSet
        dtsDepto = asociados.ConsultarDepartamentos("codDepartamento,Departamento", "", "Departamento", sUsuario, sPassword, sSucursal)
        If dtsDepto.Tables(0).Rows.Count > 0 Then
            Me.cbDepto.DataSource = dtsDepto.Tables(0)


        End If
    End Sub
    Public Sub llenarDeptoActEco1()
        Dim dtsDepto As New DataSet
        dtsDepto = asociados.ConsultarDepartamentos("codDepartamento,Departamento", "", "Departamento", sUsuario, sPassword, sSucursal)
        If dtsDepto.Tables(0).Rows.Count > 0 Then
            Me.cbDeptoOfi.DataSource = dtsDepto.Tables(0)
        End If
    End Sub
    Public Sub llenarDeptoActEco2()
        Dim dtsDepto As New DataSet
        dtsDepto = asociados.ConsultarDepartamentos("codDepartamento,Departamento", "", "Departamento", sUsuario, sPassword, sSucursal)
        If dtsDepto.Tables(0).Rows.Count > 0 Then
            Me.cbDeptoOfi2.DataSource = dtsDepto.Tables(0)
        End If
    End Sub
    Public Sub llenarCbDepartamentosJur()
        Dim dtsDepto As New DataSet
        dtsDepto = asociados.ConsultarDepartamentos("codDepartamento,Departamento", "", "Departamento", sUsuario, sPassword, sSucursal)
        If dtsDepto.Tables(0).Rows.Count > 0 Then
            Me.cbDeptoPerJur.DataSource = dtsDepto.Tables(0)
        End If
    End Sub
    Public Sub llenarCbMunicipio(ByVal codDepartamento As String)
        Dim dtsMun As New DataSet
        dtsMun = asociados.ConsultarMunicipios("codMunicipio,Municipio", "codDepartamento='" & codDepartamento & "'", "Municipio", sUsuario, sPassword, sSucursal)
        If dtsMun.Tables(0).Rows.Count > 0 Then
            Me.cbMunicipio.DataSource = dtsMun.Tables(0)
        End If
    End Sub
    Public Sub llenarCbMunicipioActEco1(ByVal codDepartamento As String)
        Dim dtsMun As New DataSet
        dtsMun = asociados.ConsultarMunicipios("codMunicipio,Municipio", "codDepartamento='" & codDepartamento & "'", "Municipio", sUsuario, sPassword, sSucursal)
        If dtsMun.Tables(0).Rows.Count > 0 Then
            cbMunOfi.DataSource = dtsMun.Tables(0)

        End If
    End Sub
    Public Sub llenarCbMunicipioActEco2(ByVal codDepartamento As String)
        Dim dtsMun As New DataSet
        dtsMun = asociados.ConsultarMunicipios("codMunicipio,Municipio", "codDepartamento='" & codDepartamento & "'", "Municipio", sUsuario, sPassword, sSucursal)
        If dtsMun.Tables(0).Rows.Count > 0 Then
            cbMunOfi2.DataSource = dtsMun.Tables(0)
        End If
    End Sub
    Public Sub llenarCbMunicipioJur(ByVal codDepartamento As String)
        Dim dtsMun As New DataSet
        dtsMun = asociados.ConsultarMunicipios("codMunicipio,Municipio", "codDepartamento='" & codDepartamento & "'", "Municipio", sUsuario, sPassword, sSucursal)
        If dtsMun.Tables(0).Rows.Count > 0 Then
            Me.cbMunicipioJur.DataSource = dtsMun.Tables(0)
        End If
    End Sub
    Public Sub llenarCbMunicipioOfi(ByVal codDepartamento As String)
        Dim dtsMun As New DataSet
        dtsMun = asociados.ConsultarMunicipios("codMunicipio,Municipio", "codDepartamento='" & codDepartamento & "'", "Municipio", sUsuario, sPassword, sSucursal)
        If dtsMun.Tables(0).Rows.Count > 0 Then
            cbMunOfi.DataSource = dtsMun.Tables(0)

        End If
    End Sub
    Public Sub llenarCbMunicipioOfi2(ByVal codDepartamento As String)
        Dim dtsMun As New DataSet
        dtsMun = asociados.ConsultarMunicipios("codMunicipio,Municipio", "codDepartamento='" & codDepartamento & "'", "Municipio", sUsuario, sPassword, sSucursal)
        If dtsMun.Tables(0).Rows.Count > 0 Then

            cbMunOfi2.DataSource = dtsMun.Tables(0)
        End If
    End Sub
    Public Sub llenarCbEstadoCivil()
        Dim dtsEstCivil As New DataSet
        dtsEstCivil = asociados.consultarDbCatalogosCatalogos(0, wsSysFinCoop.LibAsoc.tipoCatalogo.estadoCivil, wsSysFinCoop.LibAsoc.tipoConsultaCatalogos.detalleCatalogo)
        If dtsEstCivil.Tables.Count > 0 Then
            If dtsEstCivil.Tables(0).Rows.Count > 0 Then
                Me.cbEstadoCivil.DataSource = dtsEstCivil.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarEstadoVivienda()
        Dim dtsEstVivienda As New DataSet
        dtsEstVivienda = asociados.consultarDbCatalogosCatalogos(0, wsSysFinCoop.LibAsoc.tipoCatalogo.estadoVivienda, wsSysFinCoop.LibAsoc.tipoConsultaCatalogos.detalleCatalogo)
        If dtsEstVivienda.Tables.Count > 0 Then
            If dtsEstVivienda.Tables(0).Rows.Count > 0 Then
                Me.cbEstadoVivienda.DisplayMember = "Descripcion"
                Me.cbEstadoVivienda.ValueMember = "idCatalogo"
                Me.cbEstadoVivienda.DataSource = dtsEstVivienda.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarcbLugarTrabajoPrimario()
        Dim dts As New DataSet
        dts = creditos.consultarPrPagadurias("", "", 0)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbLugarTrabajo.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarcbLugarTrabajoSec()
        Dim dts As New DataSet
        dts = creditos.consultarPrPagadurias("", "", 0)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbLugarTrabajo2.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarCbLugarTrabajoConyugue()
        Dim dts As New DataSet
        dts = creditos.consultarPrPagadurias("", "", 0)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbTrabajoConyugue.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarCbEstadoLaboral()
        Dim dts As New DataSet

        dts = asociados.consultarDbCatalogosCatalogos(0, wsSysFinCoop.LibAsoc.tipoCatalogo.estadoLaboral, _
                                                      wsSysFinCoop.LibAsoc.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbEstadoLaboral.DataSource = dts.Tables(0)

            End If
        End If
    End Sub
    Public Sub llenarCbEstadoLaboralSecundario()
        Dim dts As New DataSet

        dts = asociados.consultarDbCatalogosCatalogos(0, wsSysFinCoop.LibAsoc.tipoCatalogo.estadoLaboral, _
                                                      wsSysFinCoop.LibAsoc.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then

                Me.cbEstadoLaboral2.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarCbNivelEducativo()
        Dim dts As New DataSet
        dts = asociados.consultarDbCatalogosCatalogos(0, wsSysFinCoop.LibAsoc.tipoCatalogo.nivelEducativo, _
                                                      wsSysFinCoop.LibAsoc.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbNivelEducativo.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarCbProfesiones()
        Dim dts As New DataSet
        dts = asociados.ConsultarProfesiones("codProfesion,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbProfesionDui.DataSource = dts.Tables(0)
                'Me.cbProfesionConyugue.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarCbProfesionConyugue()
        Dim dts As New DataSet
        dts = asociados.ConsultarProfesiones("codProfesion,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbProfesionConyugue.DataSource = dts.Tables(0)
                'Me.cbProfesionConyugue.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarCbCuerpoDirectivo()
        Dim dts As New DataSet
        dts = asociados.ConsultarCuerposDirectivos("codCuerpoDirectivo,Descripcion", "", "codCuerpoDirectivo", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbCuerpoDir.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarEstadoIngreso()
        Dim dts As New DataSet
        dts = asociados.consultarDbCatalogosCatalogos(0, wsSysFinCoop.LibAsoc.tipoCatalogo.estadoAsociado, _
                                                      wsSysFinCoop.LibAsoc.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbEstadoIngreso.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarCbTipoPep()
        Dim dts As New DataSet
        dts = asociados.consultarDbCatalogosCatalogos(0, wsSysFinCoop.LibAsoc.tipoCatalogo.tipoPep, _
                                                      wsSysFinCoop.LibAsoc.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbTipoPep.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarCbParentescoPep()
        Dim dts As New DataSet
        dts = asociados.ConsultarParentescos("codParentesco,descripcion", "", "descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbParentescoPep.DisplayMember = "descripcion"
                Me.cbParentescoPep.ValueMember = "codParentesco"
                Me.cbParentescoPep.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
#End Region

#End Region

#Region "Navegacion"
    Private Sub btnSigDP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSigDP.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub
    Private Sub btnAtrasEco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtrasEco.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub
    Private Sub btnSigEco_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSigEco.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub
    Private Sub btnAtrasDeJu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtrasDeJu.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub
    Private Sub btnSigDecJur_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSigDecJur.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub
    Private Sub btnAtrasInfComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtrasInfComp.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub
    Private Sub btnSigInfComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSigInfComp.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub
    Private Sub btnAtrasPep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtrasPep.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub
    Private Sub btnPepSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPepSig.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub
    Private Sub btnAtrasOtrosDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtrasOtrosDatos.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub
#End Region
    Protected Sub llenarDatos(ByVal dui As String)
        Dim dtsCatAsociados As New DataSet
        'Recuperamos informacion de la tabla Cat_Asociados 
        'Primera pestaña datos personales
        dtsCatAsociados = asociados.ConsultarAsociado("Correlativo,Dui,NumPasaporte," & _
                                                      "EstadoIngreso,NoSocio,PersonaJuridica," & _
                                                      "Residente,NoResidente,Nombres," & _
                                                      "Apellido1,Apellido2,ApellidoCas," & _
                                                      "ConocidoPor,CodNacionalidad,DobleNacionalidad," & _
                                                      "CodNacionalidad2,LugarExtDUI,CodProfesion," & _
                                                      "FechaExtDUI,Fecha_Nac,Sexo,codEstadoCivil," & _
                                                      "NIT,CodDepartamento,CodMunicipio,Direccion," & _
                                                      "TelCasa,Celular,Email", _
                                                      "Dui='" & Me.txtDui.Text.Trim & "'", _
                                                      "", sUsuario, _
                                                      sPassword, sSucursal)
        'Llenar información de pestana datos personales
        If dtsCatAsociados.Tables.Count > 0 Then
            If dtsCatAsociados.Tables(0).Rows.Count > 0 Then
                correlativo = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("Correlativo") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("Correlativo"))
                txtNoPasaporte.Text = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("NumPasaporte") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("NumPasaporte"))
                cbEstadoIngreso.SelectedValue = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("EstadoIngreso") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("EstadoIngreso"))
                txtNosocio.Text = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("NoSocio") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("NoSocio"))
                chkPersonaJuridica.Checked = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("PersonaJuridica") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("PersonaJuridica"))
                habilitarCamposPerJuridica(chkPersonaJuridica.Checked)
                chkResidente.Checked = IIf(IIf(dtsCatAsociados.Tables(0).Rows(0).Item("Residente") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("Residente")) = "F", False, True)
                txtNoResidente.Text = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("NoResidente") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("NoResidente"))
                txtNombres.Text = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("Nombres") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("Nombres"))
                txtPrimerApellido.Text = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("Apellido1") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("Apellido1"))
                txtSegApellido.Text = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("Apellido2") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("Apellido2"))
                txtApellidoCasada.Text = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("ApellidoCas") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("ApellidoCas"))
                txtConocidoPor.Text = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("ConocidoPor") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("ConocidoPor"))
                cbPrimerNacionalidad.SelectedValue = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("CodNacionalidad") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("CodNacionalidad"))
                Me.chkDobleNacionalidad.Checked = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("DobleNacionalidad") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("DobleNacionalidad"))
                cbSegNacionalidad.SelectedValue = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("CodNacionalidad2") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("CodNacionalidad2"))
                Me.txtExtDui.Text = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("LugarExtDUI") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("LugarExtDUI"))
                Me.cbProfesionDui.SelectedValue = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("CodProfesion") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("CodProfesion"))
                Me.dtpFechaExtDui.Value = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("FechaExtDUI") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("FechaExtDUI"))
                Me.dtpFechaNac.Value = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("Fecha_Nac") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("Fecha_Nac"))
                Me.cbSexo.SelectedIndex = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("Sexo") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("Sexo"))
                Me.cbEstadoCivil.SelectedValue = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("codEstadoCivil") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("codEstadoCivil"))
                Me.txtNit.Text = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("NIT") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("NIT"))
                Me.cbDepto.SelectedValue = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("CodDepartamento") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("CodDepartamento"))
                Me.cbMunicipio.SelectedValue = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("CodMunicipio") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("CodMunicipio"))
                txtDireccion.Text = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("Direccion") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("Direccion"))
                txtTelCasa.Text = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("TelCasa") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("TelCasa"))
                txtCelular.Text = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("Celular") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("Celular"))
                txtCorreo.Text = IIf(dtsCatAsociados.Tables(0).Rows(0).Item("Email") Is DBNull.Value, 0, dtsCatAsociados.Tables(0).Rows(0).Item("Email"))
                '=================================================================================================================================================================================================================
                '=================================================================================================================================================================================================================
                'Verificamos si es persona juridica
                If chkPersonaJuridica.Checked.Equals(True) Then
                    chkPersonaJuridica.Enabled = False
                    'Dim idPersonaJuridica As Integer
                    idCatPersonaJuridica = asociados.recuperarIdPersonaJuridica(txtNosocio.Text)
                    If idCatPersonaJuridica > 0 Then
                        Dim dtsCatPersonaJuridica As New DataSet
                        dtsCatPersonaJuridica = asociados.consultarCatPersonaJuridica(txtNosocio.Text)
                        'Llena informacion de pestaña persona juridica
                        If dtsCatPersonaJuridica.Tables.Count > 0 Then
                            If dtsCatPersonaJuridica.Tables(0).Rows.Count > 0 Then
                                txtRazSocial.Text = IIf(dtsCatPersonaJuridica.Tables(0).Rows(0).Item("RazonSocial") Is DBNull.Value, 0, dtsCatPersonaJuridica.Tables(0).Rows(0).Item("RazonSocial"))
                                txtNomComercial.Text = IIf(dtsCatPersonaJuridica.Tables(0).Rows(0).Item("NombreComercial") Is DBNull.Value, 0, dtsCatPersonaJuridica.Tables(0).Rows(0).Item("NombreComercial"))
                                txtRepresentanteLegal.Text = IIf(dtsCatPersonaJuridica.Tables(0).Rows(0).Item("RepresentanteLegal") Is DBNull.Value, 0, dtsCatPersonaJuridica.Tables(0).Rows(0).Item("RepresentanteLegal"))
                                txtNoRegContribuyente.Text = IIf(dtsCatPersonaJuridica.Tables(0).Rows(0).Item("NoRegContribuyente") Is DBNull.Value, 0, dtsCatPersonaJuridica.Tables(0).Rows(0).Item("NoRegContribuyente"))
                                txtNitEmpresa.Text = IIf(dtsCatPersonaJuridica.Tables(0).Rows(0).Item("NitEmpresa") Is DBNull.Value, 0, dtsCatPersonaJuridica.Tables(0).Rows(0).Item("NitEmpresa"))
                                txtTelPerJur.Text = IIf(dtsCatPersonaJuridica.Tables(0).Rows(0).Item("Telefonos") Is DBNull.Value, 0, dtsCatPersonaJuridica.Tables(0).Rows(0).Item("Telefonos"))
                                cbDeptoPerJur.SelectedValue = IIf(dtsCatPersonaJuridica.Tables(0).Rows(0).Item("codDepartamento") Is DBNull.Value, 0, dtsCatPersonaJuridica.Tables(0).Rows(0).Item("codDepartamento"))
                                cbMunicipioJur.SelectedValue = IIf(dtsCatPersonaJuridica.Tables(0).Rows(0).Item("CodMunicipio") Is DBNull.Value, 0, dtsCatPersonaJuridica.Tables(0).Rows(0).Item("CodMunicipio"))
                                txtDirPerJur.Text = IIf(dtsCatPersonaJuridica.Tables(0).Rows(0).Item("Direccion") Is DBNull.Value, 0, dtsCatPersonaJuridica.Tables(0).Rows(0).Item("Direccion"))
                                txtNosocio.Text = IIf(dtsCatPersonaJuridica.Tables(0).Rows(0).Item("noSocio") Is DBNull.Value, 0, dtsCatPersonaJuridica.Tables(0).Rows(0).Item("noSocio"))
                                'Mostrar junta directiva
                                llenarDgJuntaDirectiva(idCatPersonaJuridica)
                            End If
                        End If
                    End If
                End If
                '=================================================================================================================================================================================================================
                '=================================================================================================================================================================================================================
                'recupera informacion de actividad economica
                Dim dtsAsocActividadEconomicaPrimaria As DataSet
                dtsAsocActividadEconomicaPrimaria = asociados.consultarAsocActividadEconomia(txtDui.Text, True)
                If dtsAsocActividadEconomicaPrimaria.Tables.Count > 0 Then
                    If dtsAsocActividadEconomicaPrimaria.Tables(0).Rows.Count > 0 Then
                        Me.cbLugarTrabajo.SelectedValue = IIf(dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("CodLugarTrabajo") Is DBNull.Value, 0, dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("CodLugarTrabajo"))
                        Me.txtNoAcreUIF.Text = IIf(dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("NoAcreditacion") Is DBNull.Value, "", dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("NoAcreditacion"))
                        If dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("FechaAcreditacion") Is DBNull.Value = False Then
                            dtpFechAcre.Value = dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("FechaAcreditacion")
                        End If
                        If dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("FechaVencimiento") Is DBNull.Value = False Then
                            dtpVencimientoUIF.Value = dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("FechaVencimiento")
                        End If
                        chkNegFormal.Checked = IIf(dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("NegocioFormal") Is DBNull.Value, False, dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("NegocioFormal"))
                        txtNoRegContribuyente.Text = IIf(dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("NumRegistroContribuyente") Is DBNull.Value, "", dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("NumRegistroContribuyente"))
                        txtNomComEc.Text = IIf(dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("NombreComercial") Is DBNull.Value, "", dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("NombreComercial"))
                        txtRazonSocialPrim.Text = IIf(dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("RazonSocial") Is DBNull.Value, "", dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("RazonSocial"))
                        txtGiroPrim.Text = IIf(dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("Giro") Is DBNull.Value, "", dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("Giro"))
                        If dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("FechaAcreditacion") Is DBNull.Value = False Then
                            cbEstadoLaboral.SelectedValue = dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("EstadoLaboral")
                        End If
                        txtDptoTrabajo.Text = IIf(dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("AreaTrabajo") Is DBNull.Value, "", dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("AreaTrabajo"))
                        dtpFechaIniTra.Value = IIf(dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("FechaInicioTrabajo") Is DBNull.Value, "", dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("FechaInicioTrabajo"))
                        txtCargo.Text = IIf(dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("Cargo") Is DBNull.Value, "", dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("Cargo"))
                        txtIngresosPrim.Value = IIf(dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("Ingresos") Is DBNull.Value, 0, dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("Ingresos"))
                        txtTotalIngresosPrim.Value = IIf(dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("TotalIngresos") Is DBNull.Value, 0, dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("TotalIngresos"))
                        txtTelOficina.Text = IIf(dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("TelOficina") Is DBNull.Value, "", dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("TelOficina"))
                        txtExtOficinaPrim.Text = IIf(dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("ExtOficina") Is DBNull.Value, "", dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("ExtOficina"))
                        cbDeptoOfi.SelectedValue = dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("CodDepartamento")
                        cbMunOfi.SelectedValue = dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("CodMunicipio")
                        txtDirOfi.Text = IIf(dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("Direccion") Is DBNull.Value, "", dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("Direccion"))
                        txtCodActEconomica.Text = dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("CodigoActividadEconomica")
                        txtDescripcionActEco.Text = dtsAsocActividadEconomicaPrimaria.Tables(0).Rows(0).Item("ActividadEconomica")
                    End If
                End If
                '=================================================================================================================================================================================================================
                '=================================================================================================================================================================================================================
                'recupera informacion de actividad economica secundaria
                Dim dtsAsocActividadEconomicaSecundaria As DataSet
                dtsAsocActividadEconomicaSecundaria = asociados.consultarAsocActividadEconomia(txtDui.Text, False)
                If dtsAsocActividadEconomicaSecundaria.Tables.Count > 0 Then
                    If dtsAsocActividadEconomicaSecundaria.Tables(0).Rows.Count > 0 Then
                        Me.cbLugarTrabajo2.SelectedValue = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("CodLugarTrabajo") Is DBNull.Value, 0, dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("CodLugarTrabajo"))
                        Me.txtNoAcreUIF2.Text = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("NoAcreditacion") Is DBNull.Value, "", dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("NoAcreditacion"))
                        If dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("FechaAcreditacion") Is DBNull.Value = False Then
                            dtpFechAcre2.Value = dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("FechaAcreditacion")
                        End If
                        If dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("FechaVencimiento") Is DBNull.Value = False Then
                            dtpVencimientoUIF2.Value = dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("FechaVencimiento")
                        End If
                        chkNegFormal2.Checked = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("NegocioFormal") Is DBNull.Value, False, dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("NegocioFormal"))
                        txtNoRegContribuyente2.Text = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("NumRegistroContribuyente") Is DBNull.Value, "", dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("NumRegistroContribuyente"))
                        txtNomComEc2.Text = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("NombreComercial") Is DBNull.Value, "", dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("NombreComercial"))
                        txtRazonSocialSec.Text = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("RazonSocial") Is DBNull.Value, "", dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("RazonSocial"))
                        txtGiroSec.Text = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("Giro") Is DBNull.Value, "", dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("Giro"))
                        If dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("FechaAcreditacion") Is DBNull.Value = False Then
                            cbEstadoLaboral2.SelectedValue = dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("EstadoLaboral")
                        End If
                        txtDptoTrabajo2.Text = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("AreaTrabajo") Is DBNull.Value, "", dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("AreaTrabajo"))
                        dtpFechaIniTra2.Value = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("FechaInicioTrabajo") Is DBNull.Value, "", dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("FechaInicioTrabajo"))
                        txtCargo2.Text = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("Cargo") Is DBNull.Value, "", dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("Cargo"))
                        txtIngresosSec.Value = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("Ingresos") Is DBNull.Value, 0, dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("Ingresos"))
                        txtTotalIngresosSec.Value = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("TotalIngresos") Is DBNull.Value, 0, dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("TotalIngresos"))
                        txtTelOficina2.Text = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("TelOficina") Is DBNull.Value, "", dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("TelOficina"))
                        txtExtOficinaSec.Text = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("ExtOficina") Is DBNull.Value, "", dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("ExtOficina"))
                        cbDeptoOfi2.SelectedValue = dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("CodDepartamento")
                        cbMunOfi2.SelectedValue = dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("CodMunicipio")
                        txtDirOfi2.Text = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("Direccion") Is DBNull.Value, "", dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("Direccion"))
                        txtCodActividadEco2.Text = dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("CodigoActividadEconomica")
                        txtDescripcionActEco2.Text = dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("ActividadEconomica")
                    End If
                End If
                '=================================================================================================================================================================================================================
                '=================================================================================================================================================================================================================
                'recupera informacion de declaración jurada
                Dim dtsAsocDeclaracionJurada As New DataSet
                dtsAsocDeclaracionJurada = asociados.consultarAsocDeclaracionJurada(txtNosocio.Text)
                If dtsAsocDeclaracionJurada.Tables.Count > 0 Then
                    If dtsAsocDeclaracionJurada.Tables(0).Rows.Count > 0 Then
                        idDeclaracionJurada = dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("depositosPromMensual")
                        txtDepProm.Value = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("depositosPromMensual") Is DBNull.Value, 0, dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("depositosPromMensual"))
                        chkInversionista.Checked = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("Inversionista") Is DBNull.Value, False, dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("Inversionista"))
                        txtRetPromMen.Value = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("RetirosPromMensual") Is DBNull.Value, 0, dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("RetirosPromMensual"))
                        txtDestCta.Text = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("PropositoCuenta") Is DBNull.Value, "", dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("PropositoCuenta"))
                        txtOriFondos.Text = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("OrigenFondos") Is DBNull.Value, "", dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("OrigenFondos"))
                        txtMontoPromDpf.Value = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("MontoPromedioDpf") Is DBNull.Value, 0, dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("MontoPromedioDpf"))
                        chkDocOrigen.Checked = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("PresentoDocOrigenFondos") Is DBNull.Value, False, dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("PresentoDocOrigenFondos"))
                        txtOrigenFondosDpf = IIf(dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("OrigenFondosDpf") Is DBNull.Value, "", dtsAsocActividadEconomicaSecundaria.Tables(0).Rows(0).Item("OrigenFondosDpf"))
                        llenarDgDocumentos(idDeclaracionJurada)
                    End If
                End If
                '=================================================================================================================================================================================================================
                '=================================================================================================================================================================================================================
                'recupera informacion pestaña información complemantaria
                Dim dtsCatAsociadosInfCom As New DataSet
                dtsCatAsociadosInfCom = asociados.ConsultarAsociado("tituloObtenido,nombreConyugue,numGrupoFam," & _
                                                      "numDependientes,idEstadoVivienda,fueDirectivo," & _
                                                      "periodoFueDirectivo,codCuerpoDirectivo,tiempoResidencia," & _
                                                      "IdNivelEducacion,fechaNacConyugue,codProfesionConyugue," & _
                                                      "oficio,idActividadEconomicaConyugue,SueldoConyugue," & _
                                                      "periodoDirectivo,directivo" & _
                                                      "ingresoPromConyugue,codlugarTrabajoConyugue,telefonoConyugue", _
                                                      "Dui='" & Me.txtDui.Text.Trim & "'", _
                                                      "", sUsuario, _
                                                      sPassword, sSucursal)
                If dtsCatAsociadosInfCom.Tables.Count > 0 Then
                    If dtsCatAsociadosInfCom.Tables(0).Rows.Count > 0 Then
                        txtTituloObtenido.Text = IIf(dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("tituloObtenido") Is DBNull.Value, "", dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("tituloObtenido"))
                        txtNombreConyugue.Text = IIf(dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("nombreConyugue") Is DBNull.Value, "", dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("nombreConyugue"))
                        nuDGrupoFam.Value = IIf(dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("numGrupoFam") Is DBNull.Value, 0, dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("numGrupoFam"))
                        nuDNumDep.Value = IIf(dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("numDependientes") Is DBNull.Value, 0, dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("numDependientes"))
                        cbEstadoVivienda.SelectedValue = dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("idEstadoVivienda")
                        chkFueDir.Checked = dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("fueDirectivo")
                        chkDir.Checked = dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("Directivo")
                        If chkFueDir.Checked = True Then
                            txtPerFueDir.Text = dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("periodoFueDirectivo")
                        End If
                        If chkDir.Checked = True Then
                            txtCuerpoDir.Text = dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("PeriodoDirectivo")
                        End If
                        Me.cbCuerpoDir.SelectedValue = IIf(dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("codCuerpoDirectivo") Is DBNull.Value, 0, dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("codCuerpoDirectivo"))
                        txtTiempoResidencia.Text = IIf(dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("tiempoResidencia") Is DBNull.Value, 0, dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("tiempoResidencia"))
                        cbNivelEducativo.SelectedValue = dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("IdNivelEducacion")
                        dtpFechaNacConyugue.Value = dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("fechaNacConyugue")
                        cbProfesionConyugue.SelectedValue = dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("codProfesionConyugue")
                        txtOficioConyugue.Text = IIf(dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("oficio") Is DBNull.Value, 0, dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("oficio"))
                        txtCodActEconomica.Text = dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("idActividadEconomicaConyugue")
                        txtSueldoConyugue.Value = IIf(dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("SueldoConyugue") Is DBNull.Value, 0, dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("SueldoConyugue"))
                        txtIngresoPromMensualConyugue.Value = IIf(dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("ingresoPromConyugue") Is DBNull.Value, 0, dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("ingresoPromConyugue"))
                        cbTrabajoConyugue.SelectedValue = dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("codlugarTrabajoConyugue")
                        txtTelConyugue.Text = dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("telefonoConyugue")

                    End If
                End If
                '=================================================================================================================================================================================================================
                '=================================================================================================================================================================================================================
                'recupera informacion PEP
                Dim dtsPep As New DataSet
                dtsPep = asociados.consultarAsocPep(txtDui.Text)
                If dtsPep.Tables.Count > 0 Then
                    If dtsPep.Tables(0).Rows.Count > 0 Then
                        idPep = dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("idpep")
                        dtpFechaNomPEP.Value = dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("fechaNombramiento")
                        cbTipoPep.SelectedValue = dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("codtipoPep")
                        txtTiempoLaboral.Text = dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("tiempoLaboral")
                        txtPeriodoNombramiento.Text = dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("PeriodoNombramiento")
                        llenarDgFamiliaresPep(idPep)
                        llenarDgSociedadesPep(idPep)
                    End If
                End If
                '=================================================================================================================================================================================================================
                '=================================================================================================================================================================================================================
                'recupera información otros datos
                Dim dtsOtrosDatos As New DataSet
                dtsOtrosDatos = asociados.ConsultarAsociado("estadoAsociado,foto,codEjecutivo,Observacion", _
                                                      "Dui='" & Me.txtDui.Text.Trim & "'", _
                                                      "", sUsuario, _
                                                      sPassword, sSucursal)
                If dtsOtrosDatos.Tables.Count > 0 Then
                    If dtsOtrosDatos.Tables(0).Rows.Count > 0 Then
                        Me.cbEstadoAsociado.SelectedIndex = dtsOtrosDatos.Tables(0).Rows(0).Item("EstadoAsociado")
                        If dtsOtrosDatos.Tables(0).Rows(0).Item("EstadoAsociado") Is DBNull.Value = False Then
                            extraerImagen(dtsOtrosDatos.Tables(0).Rows(0).Item("imagen"))
                        End If
                        Me.cbEjecutivo.SelectedValue = dtsOtrosDatos.Tables(0).Rows(0).Item("CodEjecMercadeo")
                        txtObservacion = IIf(dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("observaciones_Candidato") Is DBNull.Value, "", dtsCatAsociadosInfCom.Tables(0).Rows(0).Item("observaciones_Candidato"))
                    End If
                End If
            End If
        End If
    End Sub
#Region "Validaciones"
    Public Function validarInformacionDatosPersonales()
        If txtDui.Text.Length = 10 Then
            If txtNombres.Text.Length > 0 And txtPrimerApellido.Text.Length > 0 Then
                If DateDiff(DateInterval.Year, dtpFechaNac.Value, Now) > 18 Then
                    If cbSexo.SelectedIndex >= 0 Then
                        If fechaExtDui = False Then
                            Return True
                        Else
                            MsgBox("Fecha de extensión de DUI ha superado su fecha de vencimiento.", MsgBoxStyle.Critical, "Módulo - Asociados")
                        End If
                    Else
                        MsgBox("Por favor ingresar sexo.", MsgBoxStyle.Critical, "Módulo - Asociados")
                        Return False
                    End If
                Else
                    MsgBox("No se puede ingresar asociados menores de 18 años", MsgBoxStyle.Critical, "Módulo - Asociados")
                    Return False
                End If
            Else
                MsgBox("Por favor ingresar nombres y apellidos.", MsgBoxStyle.Critical, "Módulo - Asociados")
                Return False
            End If
        Else
            MsgBox("Por favor ingresar DUI.", MsgBoxStyle.Critical, "Módulo - Asociados")
            Return False
        End If
    End Function
    Public Function validarInformacionDatosPersonalesJuridica()
        If txtRazSocial.Text.Length > 0 Then
            If txtNomComercial.Text.Length > 0 Then
                If txtRepresentanteLegal.Text.Length > 0 Then
                    If txtNitEmpresa.Text.Length > 0 Then
                        If txtDirPerJur.Text.Length > 0 Then
                            Return True
                        Else
                            MsgBox("Por favor ingresar dirección.", MsgBoxStyle.Critical, "Módulo - Asociados")
                            Return False
                        End If
                    Else
                        MsgBox("Por favor ingresar NIT", MsgBoxStyle.Critical, "Módulo - Asociados")
                        Return False
                    End If

                Else
                    MsgBox("Por favor ingresar Nombre de representante legal", MsgBoxStyle.Critical, "Módulo - Asociados")
                    Return False
                End If
            Else
                MsgBox("Por favor ingresar Nombre Comercial", MsgBoxStyle.Critical, "Módulo - Asociados")
                Return False
            End If
        Else
            MsgBox("Por favor ingresar Razón Social", MsgBoxStyle.Critical, "Módulo -Asociados")
            Return False
        End If

    End Function
    Public Function validarDeclaracionJurada() As Boolean
        If txtDepProm.Value > 0 Then
            If txtRetPromMen.Value > 0 Then
                If txtDestCta.Text.Length > 0 Then
                    If txtOriFondos.Text.Length > 0 Then
                        Return True
                    Else
                        MsgBox("El campo origen de fondos no puede quedar vacio.", MsgBoxStyle.Critical, "Módulo - Asociados")
                    End If
                Else
                    MsgBox("El campo destino de la cuenta no puede quedar vacio.", MsgBoxStyle.Critical, "Módulo - Asociados")
                End If
            Else
                MsgBox("Por favor ingresar el promedio de retiros mensuales.", MsgBoxStyle.Critical, "Módulo - Asociados")
            End If
        Else
            MsgBox("Por favor ingresar el promedio de depositos mensuales.", MsgBoxStyle.Critical, "Módulo - Asociados")
        End If
    End Function
    Public Function validarPep() As Boolean
        If DateDiff(DateInterval.Day, dtpFechaNomPEP.Value, Now) > 0 Then
            If txtPeriodoNombramiento.Text.Length > 0 Then
                If txtTiempoLaboral.Value > 0 Then
                    Return True
                Else
                    MsgBox("El campo tiempo de laboral no puede ser cero.", MsgBoxStyle.Critical, "Módulo - Asociados")
                End If
            Else
                MsgBox("El campo periodo de nombramiento no puede quedar vacio.", MsgBoxStyle.Critical, "Módulo - Asociados")
            End If
        Else
            MsgBox("Por favor ingresar fecha de nombramiento valida.", MsgBoxStyle.Critical, "Módulo - Asociados")
        End If
    End Function
#End Region
#Region "Guardar"
    'Private Sub btnGuardarDatPer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarDatPer.Click
    '    If accion = 1 Then
    '        If modificarDatosPersonales = False Then
    '            If chkPersonaJuridica.Checked = True Then
    '                If validarInformacionDatosPersonales() = True And validarInformacionDatosPersonalesJuridica() = True Then
    '                    txtNosocio.Text = asociados.ObtenerCorrelativoAsociado("NoSocio", sUsuario, sPassword, sSucursal)
    '                    Dim resultado1, resultado2 As Integer
    '                    resultado1 = asociados.insertarCat_Asociados(txtDui.Text.Trim, txtNit.Text.Trim, _
    '                                                    txtIsss.Text.Trim, txtExtDui.Text.Trim, _
    '                                                    Format(dtpFechaExtDui.Value, "short date"), Me.txtNoPasaporte.Text.Trim, _
    '                                                    cbEstadoIngreso.SelectedValue, Me.txtPrimerApellido.Text.Trim, _
    '                                                    txtSegApellido.Text.Trim, txtApellidoCasada.Text.Trim, _
    '                                                    txtNombres.Text.Trim, Format(dtpFechaNac.Value, "short date"), _
    '                                                    txtDireccion.Text.Trim, txtTelCasa.Text.Trim, _
    '                                                    txtCelular.Text.Trim, txtCorreo.Text.Trim, _
    '                                                    cbProfesionDui.SelectedValue, Me.cbPrimerNacionalidad.SelectedValue, _
    '                                                    cbMunicipio.SelectedValue, cbDepto.SelectedValue, _
    '                                                    cbSexo.SelectedIndex, IIf(Me.chkResidente.Checked = True, "1", "0"), _
    '                                                    txtNoResidente.Text.Trim, chkPersonaJuridica.Checked, _
    '                                                    txtConocidoPor.Text.Trim, chkDobleNacionalidad.Checked, cbEstadoCivil.SelectedValue, txtNosocio.Text)

    '                    resultado2 = asociados.insertar_catPersonaJuridica(txtDui.Text.Trim, txtRazSocial.Text.Trim, _
    '                                                 txtNomComercial.Text.Trim, txtRepresentanteLegal.Text.Trim, _
    '                                                 txtNoRegContribuyente.Text.Trim, txtNitEmpresa.Text.Trim, _
    '                                                 txtTelPerJur.Text.Trim, cbDeptoPerJur.SelectedValue, _
    '                                                 cbMunicipioJur.SelectedValue, txtDirPerJur.Text.Trim, txtNosocio.Text)
    '                    If resultado1 > 0 And resultado2 > 0 Then
    '                        MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
    '                        Me.btnSigDP.Enabled = True
    '                        btnJuntaDirectiva.Enabled = True
    '                        Me.btnGuardarDatPer.Enabled = False
    '                        modificarDatosPersonales = True
    '                        modificarPersonaJuridica = True
    '                        'accion = 2
    '                        'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    '                    End If
    '                End If
    '            Else
    '                If validarInformacionDatosPersonales() = True Then
    '                    txtNosocio.Text = asociados.ObtenerCorrelativoAsociado("NoSocio", sUsuario, sPassword, sSucursal)
    '                    Dim resultado As Integer
    '                    resultado = asociados.insertarCat_Asociados(txtDui.Text.Trim, txtNit.Text.Trim, _
    '                                                    txtIsss.Text.Trim, txtExtDui.Text.Trim, _
    '                                                    Format(dtpFechaExtDui.Value, "short date"), Me.txtNoPasaporte.Text.Trim, _
    '                                                    cbEstadoIngreso.SelectedValue, Me.txtPrimerApellido.Text.Trim, _
    '                                                    txtSegApellido.Text.Trim, txtApellidoCasada.Text.Trim, _
    '                                                    txtNombres.Text.Trim, Format(dtpFechaNac.Value, "short date"), _
    '                                                    txtDireccion.Text.Trim, txtTelCasa.Text.Trim, _
    '                                                    txtCelular.Text.Trim, txtCorreo.Text.Trim, _
    '                                                    cbProfesionDui.SelectedValue, Me.cbPrimerNacionalidad.SelectedValue, _
    '                                                    cbMunicipio.SelectedValue, cbDepto.SelectedValue, _
    '                                                    cbSexo.SelectedIndex, chkResidente.Checked, _
    '                                                    txtNoResidente.Text.Trim, chkPersonaJuridica.Checked, _
    '                                                    txtConocidoPor.Text.Trim, chkDobleNacionalidad.Checked, cbEstadoCivil.SelectedValue, txtNosocio.Text)
    '                    If resultado > 0 Then
    '                        MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
    '                        Me.btnSigDP.Enabled = True
    '                        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    '                        Me.btnGuardarDatPer.Enabled = False
    '                        modificarDatosPersonales = True
    '                        'accion = 2
    '                    End If
    '                End If
    '            End If
    '        ElseIf modificarDatosPersonales = True And tcTipoPersona.SelectedIndex = 0 Then

    '            If validarInformacionDatosPersonales() = True Then
    '                If asociados.modificarCat_Asociados(txtDui.Text.Trim, txtNit.Text.Trim, _
    '                                                  txtIsss.Text.Trim, txtExtDui.Text.Trim, _
    '                                                  Format(dtpFechaExtDui.Value, "short date"), Me.txtNoPasaporte.Text.Trim, _
    '                                                  cbEstadoIngreso.SelectedValue, Me.txtPrimerApellido.Text.Trim, _
    '                                                  txtSegApellido.Text.Trim, txtApellidoCasada.Text.Trim, _
    '                                                  txtNombres.Text.Trim, Format(dtpFechaNac.Value, "short date"), _
    '                                                  txtDireccion.Text.Trim, txtTelCasa.Text.Trim, _
    '                                                  txtCelular.Text.Trim, txtCorreo.Text.Trim, _
    '                                                  cbProfesionDui.SelectedValue, Me.cbPrimerNacionalidad.SelectedValue, _
    '                                                  cbMunicipio.SelectedValue, cbDepto.SelectedValue, _
    '                                                  cbSexo.SelectedIndex, IIf(Me.chkResidente.Checked = True, "1", "0"), _
    '                                                  txtNoResidente.Text.Trim, chkPersonaJuridica.Checked, _
    '                                                  txtConocidoPor.Text.Trim, chkDobleNacionalidad.Checked, _
    '                                                  cbEstadoCivil.SelectedValue, txtNosocio.Text) > 0 Then
    '                    MsgBox("Información actualizada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
    '                Else
    '                    MsgBox("La información no fue actualizada. Por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Asociados")
    '                End If
    '            End If
    '        ElseIf modificarPersonaJuridica = True And tcTipoPersona.SelectedIndex = 1 And chkPersonaJuridica.Checked = True Then
    '            If validarInformacionDatosPersonalesJuridica() = True Then
    '                idCatPersonaJuridica = asociados.recuperarIdPersonaJuridica(CInt(txtNosocio.Text.Trim))
    '                If idCatPersonaJuridica > 0 Then
    '                    If asociados.modificarPersonaJuridica(txtDui.Text.Trim, txtRazSocial.Text.Trim, _
    '                                                    txtNomComercial.Text.Trim, txtRepresentanteLegal.Text.Trim, _
    '                                                    txtNoRegContribuyente.Text.Trim, txtNitEmpresa.Text.Trim, _
    '                                                    txtTelPerJur.Text.Trim, cbDeptoPerJur.SelectedValue, _
    '                                                    cbMunicipioJur.SelectedValue, txtDirPerJur.Text.Trim, idCatPersonaJuridica) > 0 Then
    '                        MsgBox("Información actualizada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
    '                    Else
    '                        MsgBox("La información no fue actualizada. Por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Asociados")
    '                    End If
    '                End If

    '            End If
    '        End If
    '    ElseIf accion = 2 Then
    '        If tcTipoPersona.SelectedIndex = 0 Then

    '            If validarInformacionDatosPersonales() = True Then
    '                If asociados.modificarCat_Asociados(txtDui.Text.Trim, txtNit.Text.Trim, _
    '                                                  txtIsss.Text.Trim, txtExtDui.Text.Trim, _
    '                                                  Format(dtpFechaExtDui.Value, "short date"), Me.txtNoPasaporte.Text.Trim, _
    '                                                  cbEstadoIngreso.SelectedValue, Me.txtPrimerApellido.Text.Trim, _
    '                                                  txtSegApellido.Text.Trim, txtApellidoCasada.Text.Trim, _
    '                                                  txtNombres.Text.Trim, Format(dtpFechaNac.Value, "short date"), _
    '                                                  txtDireccion.Text.Trim, txtTelCasa.Text.Trim, _
    '                                                  txtCelular.Text.Trim, txtCorreo.Text.Trim, _
    '                                                  cbProfesionDui.SelectedValue, Me.cbPrimerNacionalidad.SelectedValue, _
    '                                                  cbMunicipio.SelectedValue, cbDepto.SelectedValue, _
    '                                                  cbSexo.SelectedIndex, IIf(Me.chkResidente.Checked = True, "1", "0"), _
    '                                                  txtNoResidente.Text.Trim, chkPersonaJuridica.Checked, _
    '                                                  txtConocidoPor.Text.Trim, chkDobleNacionalidad.Checked, _
    '                                                  cbEstadoCivil.SelectedValue, txtNosocio.Text) > 0 Then
    '                    MsgBox("Información actualizada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
    '                Else
    '                    MsgBox("La información no fue actualizada. Por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Asociados")
    '                End If
    '            End If
    '        ElseIf tcTipoPersona.SelectedIndex = 1 And chkPersonaJuridica.Checked = True Then
    '            If validarInformacionDatosPersonalesJuridica() = True Then
    '                idCatPersonaJuridica = asociados.recuperarIdPersonaJuridica(CInt(txtNosocio.Text.Trim))
    '                If idCatPersonaJuridica > 0 Then
    '                    If asociados.modificarPersonaJuridica(txtDui.Text.Trim, txtRazSocial.Text.Trim, _
    '                                                    txtNomComercial.Text.Trim, txtRepresentanteLegal.Text.Trim, _
    '                                                    txtNoRegContribuyente.Text.Trim, txtNitEmpresa.Text.Trim, _
    '                                                    txtTelPerJur.Text.Trim, cbDeptoPerJur.SelectedValue, _
    '                                                    cbMunicipioJur.SelectedValue, txtDirPerJur.Text.Trim, idCatPersonaJuridica) > 0 Then
    '                        MsgBox("Información actualizada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
    '                    Else
    '                        MsgBox("La información no fue actualizada. Por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Asociados")
    '                    End If
    '                End If

    '            End If
    '        End If
    '    End If
    'End Sub
    'Private actPrimaria, actSecundaria As Boolean
    'Private Sub btnGuardarTp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarTp2.Click

    '    If accion = 1 Then
    '        If tcActividadEco.SelectedIndex = 0 Then
    '            If actPrimaria = False Then
    '                If asociados.insertarAsocActividadEconomica(txtDui.Text.Trim, cbLugarTrabajo.SelectedValue, _
    '                                                     txtNoAcreUIF.Text.Trim, Format(dtpFechAcre.Value, "Short date"), _
    '                                                     Format(dtpVencimientoUIF.Value, "Short date"), chkNegFormal.Checked, _
    '                                                     chkcontribuyente.Checked, txtNoRegContribuyente.Text.Trim, _
    '                                                     txtNomComEc.Text.Trim, cbEstadoLaboral.SelectedValue, _
    '                                                     txtDptoTrabajo.Text.Trim, Format(dtpFechaIniTra.Value, "Short date"), _
    '                                                     txtCargo.Text.Trim, txtIngresosPrim.Text.Trim, _
    '                                                     txtTotalIngresosPrim.Text.Trim, txtTelOficina.Text.Trim, _
    '                                                     txtExtOficinaPrim.Text.Trim, cbDeptoOfi.SelectedValue, _
    '                                                     cbMunOfi.SelectedValue, txtDirOfi.Text.Trim, _
    '                                                     txtRazonSocialPrim.Text.Trim, txtGiroPrim.Text.Trim, _
    '                                                     True, txtCodActEconomica.Text.Trim) > 0 Then
    '                    actPrimaria = True
    '                    MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
    '                    Me.tcActividadEco.SelectedIndex = Me.tcActividadEco.SelectedIndex() + 1
    '                    Me.btnSigEco.Enabled = True
    '                End If
    '            End If

    '        ElseIf tcActividadEco.SelectedIndex = 1 Then
    '            If actPrimaria = True And actSecundaria = False Then
    '                If asociados.insertarAsocActividadEconomica(txtDui.Text.Trim, cbLugarTrabajo2.SelectedValue, _
    '                                                         txtNoAcreUIF2.Text.Trim, Format(dtpFechAcre2.Value, "Short date"), _
    '                                                         Format(dtpVencimientoUIF2.Value, "Short date"), chkNegFormal2.Checked, _
    '                                                         chkcontribuyente2.Checked, txtNoRegContribuyente2.Text.Trim, _
    '                                                         txtNomComEc2.Text.Trim, cbEstadoLaboral2.SelectedValue, _
    '                                                         txtDptoTrabajo2.Text.Trim, Format(dtpFechaIniTra2.Value, "Short date"), _
    '                                                         txtCargo2.Text.Trim, txtIngresosSec.Value, _
    '                                                         txtTotalIngresosSec.Value, txtTelOficina2.Text.Trim, _
    '                                                         txtExtOficinaSec.Text.Trim, cbDeptoOfi2.SelectedValue, _
    '                                                         cbMunOfi2.SelectedValue, txtDirOfi2.Text.Trim, _
    '                                                         txtRazonSocialSec.Text.Trim, txtGiroSec.Text.Trim, _
    '                                                         False, txtCodActividadEco2.Text.Trim) > 0 Then
    '                    actSecundaria = True
    '                    MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
    '                    Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    '                    Me.btnSigEco.Enabled = True
    '                End If
    '            End If
    '        End If
    '    End If

    'End Sub
    'Private Sub btGuardarDeclaJurada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGuardarDeclaJurada.Click
    '    Try
    '        If accion = 1 Then
    '            If validarDeclaracionJurada() = True Then
    '                Dim idDeclaracionJurada As Integer
    '                idDeclaracionJurada = asociados.generarIdDeclaracionJurada()
    '                If idDeclaracionJurada > 0 Then
    '                    If asociados.insertarAsocDeclaracionJurada(txtNosocio.Text, txtDepProm.Value, _
    '                                                              chkInversionista.Checked, txtRetPromMen.Value, _
    '                                                              txtDestCta.Text.Trim, txtOriFondos.Text, _
    '                                                              txtMontoPromDpf.Value, _
    '                                                              txtOrigenFondosDpf.Text, idDeclaracionJurada) > 0 Then
    '                        idDeclaracion = idDeclaracionJurada
    '                        MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
    '                        btGuardarDeclaJurada.Enabled = False
    '                        Me.btnSigDecJur.Enabled = True
    '                    End If
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    End Try
    'End Sub
    'Private Sub btnGuardarInfComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarInfComp.Click
    '    Try
    '        Dim resultado As Integer
    '        resultado = asociados.insertar_CatAsociados_InfComplementaria(txtDui.Text.Trim, txtTituloObtenido.Text.Trim, _
    '                                                          txtNombreConyugue.Text.Trim, nuDGrupoFam.Value, _
    '                                                          nuDNumDep.Value, cbEstadoVivienda.SelectedValue, _
    '                                                          chkFueDir.Checked, txtPerFueDir.Text.Trim, _
    '                                                          cbCuerpoDir.SelectedValue, txtTiempoResidencia.Text.Trim, _
    '                                                          cbNivelEducativo.SelectedValue, Format(dtpFechaNacConyugue.Value, "short date"), _
    '                                                          cbProfesionConyugue.SelectedValue, txtOficioConyugue.Text.Trim, _
    '                                                          txtCodActEcoCon.Text.Trim, txtSueldoConyugue.Value, _
    '                                                          txtIngresoPromMensualConyugue.Value, cbTrabajoConyugue.SelectedValue, _
    '                                                          txtTelConyugue.Text.Trim, chkDir.Checked, txtCuerpoDir.Text)
    '        If resultado = 1 Then
    '            MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
    '            Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    '        Else
    '            MsgBox("Error. información no ingresada.", MsgBoxStyle.Critical, "Módulo - Asociados")
    '        End If
    '    Catch ex As Exception
    '        MsgBox("Error. información no ingresada." + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Asociados")
    '    End Try
    'End Sub
    'Private Sub btnGuardarOtrosDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarOtrosDatos.Click
    '    Dim arrFilename() As String = Split(Text, "\")
    '    Array.Reverse(arrFilename)
    '    Dim ms As New MemoryStream
    '    If PictureBox1.Image Is Nothing = False Then
    '        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
    '    End If

    '    Dim arrImage() As Byte
    '    If ms.GetBuffer.Length > 0 Then
    '        arrImage = ms.GetBuffer
    '    End If
    '    Dim dtsCodSucEJe As New DataSet
    '    Dim codSucursal As String = ""
    '    dtsCodSucEJe = asociados.ConsultarEjecutivosMercadeo("codSucursal", "codEjecMercadeo = '" & Me.cbEjecutivo.SelectedValue & "'", "", sUsuario, sPassword, sSucursal)
    '    If dtsCodSucEJe.Tables.Count > 0 Then
    '        If dtsCodSucEJe.Tables(0).Rows.Count > 0 Then
    '            codSucursal = dtsCodSucEJe.Tables(0).Rows(0).Item(0)
    '        End If
    '    End If
    '    If codSucursal <> "" Then
    '        If asociados.insertar_CatAsociados_OtrosDatos(txtDui.Text.Trim, _
    '                                              cbEstadoAsociado.SelectedIndex.ToString.Trim, _
    '                                              arrImage, _
    '                                              cbEjecutivo.SelectedValue, _
    '                                              txtObservacion.Text.Trim, txtNosocio.Text, sUsuario, Now, codSucursal, Me.cbTipoCuota.SelectedValue) > 0 Then
    '            MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
    '        Else
    '            MsgBox("Información no ingresada", MsgBoxStyle.Critical, "Módulo - Asociados")
    '        End If
    '    Else
    '        MsgBox("Debe seleccionar un ejecutivo de mercadeo.", MsgBoxStyle.Critical, "Módulo - Asociados")
    '    End If

    'End Sub
    'Private Sub btnGuardarPep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarPep.Click
    '    If accion = 1 Then
    '        If validarPep() = True Then
    '            Dim resultado As Integer
    '            idPep = asociados.generarIdPep()
    '            If idPep <> 0 Then
    '                resultado = asociados.insertar_AsocPep(txtDui.Text.Trim, Format(dtpFechaNomPEP.Value, "short date"), _
    '                                                       cbTipoPep.SelectedValue, txtTiempoLaboral.Text.Trim, _
    '                                                       idPep, txtPeriodoNombramiento.Text)
    '                If resultado <> 0 Then
    '                    Me.btnAgregarFam.Enabled = True
    '                    Me.btnAgregarSociedad.Enabled = True
    '                    btnGuardarPep.Enabled = False
    '                    MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
    '                    'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub
    Private Sub btnGuardarDatPer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarDatPer.Click
        Dim resultado1, resultado2, resultado As Integer
        Dim validacion As String = asociados.validarCamposObligatorios(txtNombres.Text.Trim, txtDui.Value.ToString.Trim, txtNit.Value.ToString, _
                                               txtDireccion.Text.Trim, txtTelCasa.Text.Trim, dtpFechaNac.Value, _
                                               cbSexo.SelectedIndex, txtExtDui.Text.Trim, dtpFechaExtDui.Value, _
                                               cbPrimerNacionalidad.SelectedValue.ToString, "", "", "", "", Now, "", _
                                               "", "", 0, "", 1)
        If validacion.Equals("OK") Then
            If reIngreso = True Then
                If accion = 1 Then
                    If chkPersonaJuridica.Checked = False Then
                        txtNosocio.Text = asociados.ObtenerCorrelativoAsociado("NoSocio", sUsuario, sPassword, sSucursal)
                        If txtNosocio.Text > 0 Then
                            resultado = asociados.modificarCat_Asociados(txtDui.Text.Trim, txtNit.Text.Trim, _
                                                           txtIsss.Text.Trim, txtExtDui.Text.Trim, _
                                                           Format(dtpFechaExtDui.Value, "short date"), Me.txtNoPasaporte.Text.Trim, _
                                                           cbEstadoIngreso.SelectedValue, Me.txtPrimerApellido.Text.Trim, _
                                                           txtSegApellido.Text.Trim, txtApellidoCasada.Text.Trim, _
                                                           txtNombres.Text.Trim, Format(dtpFechaNac.Value, "short date"), _
                                                           txtDireccion.Text.Trim, txtTelCasa.Text.Trim, _
                                                           txtCelular.Text.Trim, txtCorreo.Text.Trim, _
                                                           cbProfesionDui.SelectedValue, Me.cbPrimerNacionalidad.SelectedValue, _
                                                           cbMunicipio.SelectedValue, cbDepto.SelectedValue, _
                                                           cbSexo.SelectedIndex, chkResidente.Checked, _
                                                           txtNoResidente.Text.Trim, chkPersonaJuridica.Checked, _
                                                           txtConocidoPor.Text.Trim, chkDobleNacionalidad.Checked, _
                                                           cbEstadoCivil.SelectedValue, txtNosocio.Text)
                            If resultado > 0 Then
                                MsgBox("Información ingresada exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                                Me.btnSigDP.Enabled = True
                                'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                                Me.txtNosocio.Enabled = False
                                Me.txtDui.Enabled = False
                                Me.txtNit.Enabled = False
                                modificarDatosPersonales = True
                                'Me.btnGuardarDatPer.Enabled = False
                                accionDatPer = 2
                                Exit Sub
                            End If
                        End If
                    End If
                End If
            End If




            If accion = 1 Then
                If chkPersonaJuridica.Checked = False Then
                    If validarInformacionDatosPersonales() = True Then
                        If modificarDatosPersonales = False Then
                            txtNosocio.Text = asociados.ObtenerCorrelativoAsociado("NoSocio", sUsuario, sPassword, sSucursal)
                            If txtNosocio.Text > 0 Then
                                resultado = asociados.insertarCat_Asociados(txtDui.Text.Trim, txtNit.Text.Trim, _
                                                           txtIsss.Text.Trim, txtExtDui.Text.Trim, _
                                                           Format(dtpFechaExtDui.Value, "short date"), Me.txtNoPasaporte.Text.Trim, _
                                                           cbEstadoIngreso.SelectedIndex, Me.txtPrimerApellido.Text.Trim, _
                                                           txtSegApellido.Text.Trim, txtApellidoCasada.Text.Trim, _
                                                           txtNombres.Text.Trim, Format(dtpFechaNac.Value, "short date"), _
                                                           txtDireccion.Text.Trim, txtTelCasa.Text.Trim, _
                                                           txtCelular.Text.Trim, txtCorreo.Text.Trim, _
                                                           cbProfesionDui.SelectedValue, Me.cbPrimerNacionalidad.SelectedValue, _
                                                           cbMunicipio.SelectedValue, cbDepto.SelectedValue, _
                                                           cbSexo.SelectedIndex, chkResidente.Checked, _
                                                           txtNoResidente.Text.Trim, chkPersonaJuridica.Checked, _
                                                           txtConocidoPor.Text.Trim, chkDobleNacionalidad.Checked, _
                                                           cbEstadoCivil.SelectedValue, txtNosocio.Text)
                                'sUsuario, Now, sSucursal)
                                If resultado > 0 Then
                                    MsgBox("Información ingresada exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                                    Me.btnSigDP.Enabled = True
                                    'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                                    Me.txtNosocio.Enabled = False
                                    Me.txtDui.Enabled = False
                                    Me.txtNit.Enabled = False
                                    modificarDatosPersonales = True
                                    'Me.btnGuardarDatPer.Enabled = False
                                    accionDatPer = 2
                                End If
                            End If
                        ElseIf modificarDatosPersonales = True Then
                            resultado = asociados.modificarCat_Asociados(txtDui.Text.Trim, txtNit.Text.Trim, _
                                                           txtIsss.Text.Trim, txtExtDui.Text.Trim, _
                                                           Format(dtpFechaExtDui.Value, "short date"), Me.txtNoPasaporte.Text.Trim, _
                                                           cbEstadoIngreso.SelectedValue, Me.txtPrimerApellido.Text.Trim, _
                                                           txtSegApellido.Text.Trim, txtApellidoCasada.Text.Trim, _
                                                           txtNombres.Text.Trim, Format(dtpFechaNac.Value, "short date"), _
                                                           txtDireccion.Text.Trim, txtTelCasa.Text.Trim, _
                                                           txtCelular.Text.Trim, txtCorreo.Text.Trim, _
                                                           cbProfesionDui.SelectedValue, Me.cbPrimerNacionalidad.SelectedValue, _
                                                           cbMunicipio.SelectedValue, cbDepto.SelectedValue, _
                                                           cbSexo.SelectedIndex, chkResidente.Checked, _
                                                           txtNoResidente.Text.Trim, chkPersonaJuridica.Checked, _
                                                           txtConocidoPor.Text.Trim, chkDobleNacionalidad.Checked, _
                                                           cbEstadoCivil.SelectedValue, txtNosocio.Text)
                            If resultado > 0 Then
                                MsgBox("Información actualizada exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                                Me.btnSigDP.Enabled = True
                                'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                                Me.txtNosocio.Enabled = False
                                Me.txtDui.Enabled = False
                                Me.txtNit.Enabled = False
                                modificarDatosPersonales = True
                                'Me.btnGuardarDatPer.Enabled = False
                                accionDatPer = 2
                            End If
                        End If
                    End If
                ElseIf chkPersonaJuridica.Checked = True Then
                    If modificarDatosPersonales = False Then
                        txtNosocio.Text = asociados.ObtenerCorrelativoAsociado("NoSocio", sUsuario, sPassword, sSucursal)
                        If txtNosocio.Text > 0 Then
                            resultado = asociados.insertarCat_Asociados(txtDui.Text.Trim, txtNit.Text.Trim, _
                                                       txtIsss.Text.Trim, txtExtDui.Text.Trim, _
                                                       Format(dtpFechaExtDui.Value, "short date"), Me.txtNoPasaporte.Text.Trim, _
                                                       cbEstadoIngreso.SelectedIndex, Me.txtPrimerApellido.Text.Trim, _
                                                       txtSegApellido.Text.Trim, txtApellidoCasada.Text.Trim, _
                                                       txtNombres.Text.Trim, Format(dtpFechaNac.Value, "short date"), _
                                                       txtDireccion.Text.Trim, txtTelCasa.Text.Trim, _
                                                       txtCelular.Text.Trim, txtCorreo.Text.Trim, _
                                                       cbProfesionDui.SelectedValue, Me.cbPrimerNacionalidad.SelectedValue, _
                                                       cbMunicipio.SelectedValue, cbDepto.SelectedValue, _
                                                       cbSexo.SelectedIndex, chkResidente.Checked, _
                                                       txtNoResidente.Text.Trim, chkPersonaJuridica.Checked, _
                                                       txtConocidoPor.Text.Trim, chkDobleNacionalidad.Checked, _
                                                       cbEstadoCivil.SelectedValue, txtNosocio.Text)
                            'sUsuario, Now, sSucursal)
                            If resultado > 0 Then
                                MsgBox("Información ingresada exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                                Me.btnSigDP.Enabled = True
                                'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                                Me.txtNosocio.Enabled = False
                                Me.txtDui.Enabled = False
                                Me.txtNit.Enabled = False
                                modificarDatosPersonales = True
                                'Me.btnGuardarDatPer.Enabled = False
                                accionDatPer = 2
                            End If
                        End If
                    End If
                    'Validar Que exista o no Registro de persona juridica
                    idCatPersonaJuridica = asociados.recuperarIdPersonaJuridica(txtNosocio.Text)
                    If idCatPersonaJuridica > 0 Then
                        resultado = asociados.modificarCat_Asociados(txtDui.Text.Trim, txtNit.Text.Trim, _
                                                          txtIsss.Text.Trim, txtExtDui.Text.Trim, _
                                                          Format(dtpFechaExtDui.Value, "short date"), Me.txtNoPasaporte.Text.Trim, _
                                                          cbEstadoIngreso.SelectedIndex, Me.txtPrimerApellido.Text.Trim, _
                                                          txtSegApellido.Text.Trim, txtApellidoCasada.Text.Trim, _
                                                          txtNombres.Text.Trim, Format(dtpFechaNac.Value, "short date"), _
                                                          txtDireccion.Text.Trim, txtTelCasa.Text.Trim, _
                                                          txtCelular.Text.Trim, txtCorreo.Text.Trim, _
                                                          cbProfesionDui.SelectedValue, Me.cbPrimerNacionalidad.SelectedValue, _
                                                          cbMunicipio.SelectedValue, cbDepto.SelectedValue, _
                                                          cbSexo.SelectedIndex, chkResidente.Checked, _
                                                          txtNoResidente.Text.Trim, chkPersonaJuridica.Checked, _
                                                          txtConocidoPor.Text.Trim, chkDobleNacionalidad.Checked, _
                                                          cbEstadoCivil.SelectedValue, txtNosocio.Text)

                        If resultado > 0 Then
                            MsgBox("Información actualizada exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                            Me.btnSigDP.Enabled = True
                            'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                            Me.txtNosocio.Enabled = False
                            Me.txtDui.Enabled = False
                            Me.txtNit.Enabled = False
                            modificarDatosPersonales = True
                            'Me.btnGuardarDatPer.Enabled = False
                            accionDatPer = 2
                            Me.btnJuntaDirectiva.Enabled = True
                        End If
                        resultado2 = asociados.modificarPersonaJuridica(txtDui.Text, txtRazSocial.Text.Trim, _
                                                                txtNomComercial.Text.Trim, txtRepresentanteLegal.Text, _
                                                                txtNoRegContribuyenteJur.Text, txtNit.Value, _
                                                                txtTelPerJur.Text, Me.cbDeptoPerJur.SelectedValue, _
                                                                Me.cbMunicipioJur.SelectedValue, txtDirPerJur.Text, _
                                                                idCatPersonaJuridica)
                        If resultado2 > 0 Then
                            MsgBox("Información persona jurídica actualizada exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                            Me.btnSigDP.Enabled = True
                            'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                            Me.txtNosocio.Enabled = False
                            Me.txtDui.Enabled = False
                            Me.txtNit.Enabled = False
                            modificarDatosPersonales = True
                            Me.chkPersonaJuridica.Enabled = False
                            'Me.btnGuardarDatPer.Enabled = False
                            accionDatPer = 2
                        End If
                    ElseIf idCatPersonaJuridica = 0 Then
                        If validarInformacionDatosPersonalesJuridica() = True Then
                            resultado = asociados.modificarCat_Asociados(txtDui.Text.Trim, txtNit.Text.Trim, _
                                                             txtIsss.Text.Trim, txtExtDui.Text.Trim, _
                                                             Format(dtpFechaExtDui.Value, "short date"), Me.txtNoPasaporte.Text.Trim, _
                                                             cbEstadoIngreso.SelectedIndex, Me.txtPrimerApellido.Text.Trim, _
                                                             txtSegApellido.Text.Trim, txtApellidoCasada.Text.Trim, _
                                                             txtNombres.Text.Trim, Format(dtpFechaNac.Value, "short date"), _
                                                             txtDireccion.Text.Trim, txtTelCasa.Text.Trim, _
                                                             txtCelular.Text.Trim, txtCorreo.Text.Trim, _
                                                             cbProfesionDui.SelectedValue, Me.cbPrimerNacionalidad.SelectedValue, _
                                                             cbMunicipio.SelectedValue, cbDepto.SelectedValue, _
                                                             cbSexo.SelectedIndex, chkResidente.Checked, _
                                                             txtNoResidente.Text.Trim, chkPersonaJuridica.Checked, _
                                                             txtConocidoPor.Text.Trim, chkDobleNacionalidad.Checked, _
                                                             cbEstadoCivil.SelectedValue, txtNosocio.Text)

                            If resultado > 0 Then
                                MsgBox("Información actualizada exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                                Me.btnSigDP.Enabled = True
                                ''Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                                Me.txtNosocio.Enabled = False
                                Me.txtDui.Enabled = False
                                Me.txtNit.Enabled = False
                                modificarDatosPersonales = True
                                'Me.btnGuardarDatPer.Enabled = False
                                accionDatPer = 2
                            End If
                            resultado2 = asociados.insertar_catPersonaJuridica(txtDui.Text.Trim, txtRazSocial.Text.Trim, _
                                                          txtNomComercial.Text.Trim, txtRepresentanteLegal.Text.Trim, _
                                                          txtNoRegContribuyente.Text.Trim, txtNitEmpresa.Text.Trim, _
                                                          txtTelPerJur.Text.Trim, cbDeptoPerJur.SelectedValue, _
                                                          cbMunicipioJur.SelectedValue, txtDirPerJur.Text.Trim, txtNosocio.Text)
                            Me.btnJuntaDirectiva.Enabled = True
                            Me.chkPersonaJuridica.Enabled = False
                        End If

                    End If
                    End If
            ElseIf accion = 2 Then
                If chkPersonaJuridica.Checked = False Then
                    If validarInformacionDatosPersonales() = True Then
                        resultado = asociados.modificarCat_Asociados(txtDui.Text.Trim, txtNit.Text.Trim, _
                                                          txtIsss.Text.Trim, txtExtDui.Text.Trim, _
                                                          Format(dtpFechaExtDui.Value, "short date"), Me.txtNoPasaporte.Text.Trim, _
                                                          cbEstadoIngreso.SelectedIndex, Me.txtPrimerApellido.Text.Trim, _
                                                          txtSegApellido.Text.Trim, txtApellidoCasada.Text.Trim, _
                                                          txtNombres.Text.Trim, Format(dtpFechaNac.Value, "short date"), _
                                                          txtDireccion.Text.Trim, txtTelCasa.Text.Trim, _
                                                          txtCelular.Text.Trim, txtCorreo.Text.Trim, _
                                                          cbProfesionDui.SelectedValue, Me.cbPrimerNacionalidad.SelectedValue, _
                                                          cbMunicipio.SelectedValue, cbDepto.SelectedValue, _
                                                          cbSexo.SelectedIndex, chkResidente.Checked, _
                                                          txtNoResidente.Text.Trim, chkPersonaJuridica.Checked, _
                                                          txtConocidoPor.Text.Trim, chkDobleNacionalidad.Checked, _
                                                          cbEstadoCivil.SelectedValue, txtNosocio.Text)
                        If resultado > 0 Then
                            MsgBox("Información actualizada exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                            Me.btnSigDP.Enabled = True
                            'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                            Me.txtNosocio.Enabled = False
                            Me.txtDui.Enabled = False
                            Me.txtNit.Enabled = False
                            modificarDatosPersonales = True
                            'Me.btnGuardarDatPer.Enabled = False
                            accionDatPer = 2
                        End If
                    End If
                ElseIf chkPersonaJuridica.Checked = True Then
                    If validarInformacionDatosPersonales() = True And validarInformacionDatosPersonalesJuridica() = True Then
                        If idCatPersonaJuridica > 0 Then
                            resultado = asociados.modificarCat_Asociados(txtDui.Text.Trim, txtNit.Text.Trim, _
                                                              txtIsss.Text.Trim, txtExtDui.Text.Trim, _
                                                              Format(dtpFechaExtDui.Value, "short date"), Me.txtNoPasaporte.Text.Trim, _
                                                              cbEstadoIngreso.SelectedIndex, Me.txtPrimerApellido.Text.Trim, _
                                                              txtSegApellido.Text.Trim, txtApellidoCasada.Text.Trim, _
                                                              txtNombres.Text.Trim, Format(dtpFechaNac.Value, "short date"), _
                                                              txtDireccion.Text.Trim, txtTelCasa.Text.Trim, _
                                                              txtCelular.Text.Trim, txtCorreo.Text.Trim, _
                                                              cbProfesionDui.SelectedValue, Me.cbPrimerNacionalidad.SelectedValue, _
                                                              cbMunicipio.SelectedValue, cbDepto.SelectedValue, _
                                                              cbSexo.SelectedIndex, chkResidente.Checked, _
                                                              txtNoResidente.Text.Trim, chkPersonaJuridica.Checked, _
                                                              txtConocidoPor.Text.Trim, chkDobleNacionalidad.Checked, _
                                                              cbEstadoCivil.SelectedValue, txtNosocio.Text)

                            If resultado > 0 Then
                                MsgBox("Información actualizada exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                                Me.btnSigDP.Enabled = True
                                'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                                Me.txtNosocio.Enabled = False
                                Me.txtDui.Enabled = False
                                Me.txtNit.Enabled = False
                                modificarDatosPersonales = True
                                'Me.btnGuardarDatPer.Enabled = False
                                accionDatPer = 2
                            End If
                            resultado2 = asociados.modificarPersonaJuridica(txtDui.Text, txtRazSocial.Text.Trim, _
                                                                    txtNomComercial.Text.Trim, txtRepresentanteLegal.Text, _
                                                                    txtNoRegContribuyenteJur.Text, txtNit.Value, _
                                                                    txtTelPerJur.Text, Me.cbDeptoPerJur.SelectedValue, _
                                                                    Me.cbMunicipioJur.SelectedValue, txtDirPerJur.Text, _
                                                                     idCatPersonaJuridica)
                            If resultado2 > 0 Then
                                MsgBox("Información persona jurídica actualizada exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                                Me.btnSigDP.Enabled = True
                                'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                                Me.txtNosocio.Enabled = False
                                Me.txtDui.Enabled = False
                                Me.txtNit.Enabled = False
                                modificarDatosPersonales = True
                                Me.chkPersonaJuridica.Enabled = False
                                'Me.btnGuardarDatPer.Enabled = False
                                Me.btnJuntaDirectiva.Enabled = True
                                accionDatPer = 2
                            End If
                        ElseIf idCatPersonaJuridica = 0 Then
                            If validarInformacionDatosPersonalesJuridica() = True Then
                                idCatPersonaJuridica = asociados.recuperarIdPersonaJuridica(txtNosocio.Text)
                                resultado = asociados.modificarCat_Asociados(txtDui.Text.Trim, txtNit.Text.Trim, _
                                                                 txtIsss.Text.Trim, txtExtDui.Text.Trim, _
                                                                 Format(dtpFechaExtDui.Value, "short date"), Me.txtNoPasaporte.Text.Trim, _
                                                                 cbEstadoIngreso.SelectedIndex, Me.txtPrimerApellido.Text.Trim, _
                                                                 txtSegApellido.Text.Trim, txtApellidoCasada.Text.Trim, _
                                                                 txtNombres.Text.Trim, Format(dtpFechaNac.Value, "short date"), _
                                                                 txtDireccion.Text.Trim, txtTelCasa.Text.Trim, _
                                                                 txtCelular.Text.Trim, txtCorreo.Text.Trim, _
                                                                 cbProfesionDui.SelectedValue, Me.cbPrimerNacionalidad.SelectedValue, _
                                                                 cbMunicipio.SelectedValue, cbDepto.SelectedValue, _
                                                                 cbSexo.SelectedIndex, chkResidente.Checked, _
                                                                 txtNoResidente.Text.Trim, chkPersonaJuridica.Checked, _
                                                                 txtConocidoPor.Text.Trim, chkDobleNacionalidad.Checked, _
                                                                 cbEstadoCivil.SelectedValue, txtNosocio.Text)

                                If resultado > 0 Then
                                    MsgBox("Información actualizada exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                                    Me.btnSigDP.Enabled = True
                                    'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                                    Me.txtNosocio.Enabled = False
                                    Me.txtDui.Enabled = False
                                    Me.txtNit.Enabled = False
                                    modificarDatosPersonales = True
                                    'Me.btnGuardarDatPer.Enabled = False
                                    Me.btnJuntaDirectiva.Enabled = True
                                    accionDatPer = 2
                                End If
                                resultado2 = asociados.insertar_catPersonaJuridica(txtDui.Text.Trim, txtRazSocial.Text.Trim, _
                                                              txtNomComercial.Text.Trim, txtRepresentanteLegal.Text.Trim, _
                                                              txtNoRegContribuyente.Text.Trim, txtNitEmpresa.Text.Trim, _
                                                              txtTelPerJur.Text.Trim, cbDeptoPerJur.SelectedValue, _
                                                              cbMunicipioJur.SelectedValue, txtDirPerJur.Text.Trim, txtNosocio.Text)
                            End If
                        End If
                    End If
                End If
            End If
        Else
            MsgBox("El campo " & validacion & " no puede quedar vacio.", MsgBoxStyle.Critical, "Módulo - Asociados")
        End If
    End Sub
    Private actPrimaria, actSecundaria As Boolean
    Private Sub btnGuardarTp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarTp2.Click
        Dim validacion As String
        If tcActividadEco.SelectedIndex = 0 Then
            validacion = asociados.validarCamposActividadEconomica(cbLugarTrabajo.SelectedValue, txtCodActEconomica.Text.Trim, _
                                                         chkNegFormal.Checked, chkcontribuyente.Checked, _
                                                         txtNoRegContribuyente.Text, txtNomComEc.Text.Trim, _
                                                         txtRazonSocialPrim.Text, txtGiroPrim.Text.Trim, _
                                                         cbEstadoLaboral.SelectedValue, txtDptoTrabajo.Text, _
                                                         dtpFechaIniTra.Value, txtCargo.Text, _
                                                         txtIngresosPrim.Value, txtTotalIngresosPrim.Value, _
                                                         txtTelOficina.Text, txtExtOficinaPrim.Text, _
                                                         cbDeptoOfi.SelectedValue, cbMunOfi.SelectedValue, _
                                                         txtDirOfi.Text)
            If validacion <> "OK" Then
                MsgBox("El campo " & validacion & " no puede quedar vacio.", MsgBoxStyle.Critical, "Módulo - Asociados")
                Exit Sub
            End If
        ElseIf tcActividadEco.SelectedIndex = 1 Then
            validacion = asociados.validarCamposActividadEconomica(cbLugarTrabajo2.SelectedValue, txtCodActividadEco2.Text, _
                                                                   chkNegFormal2.Checked, chkcontribuyente2.Checked, _
                                                                   txtNoRegContribuyente2.Text, txtNomComEc2.Text, _
                                                                   txtRazonSocialSec.Text, txtGiroSec.Text, _
                                                                   cbEstadoLaboral2.SelectedValue, txtDptoTrabajo2.Text, _
                                                                   dtpFechaIniTra2.Value, txtCargo2.Text, _
                                                                   txtIngresosSec.Value, txtTotalIngresosSec.Value, _
                                                                   txtTelOficina2.Text, txtExtOficinaSec.Text, _
                                                                   cbDeptoOfi2.SelectedValue, cbMunOfi2.SelectedValue, _
                                                                   txtDirOfi2.Text)
            If validacion <> "OK" Then
                MsgBox("El campo " & validacion & " no puede quedar vacio.", MsgBoxStyle.Critical, "Módulo - Asociados")
                Exit Sub
            End If
        End If

        If accion = 1 Then
            If tcActividadEco.SelectedIndex = 0 Then
                If actPrimaria = False Then
                    If asociados.insertarAsocActividadEconomica(txtDui.Text.Trim, cbLugarTrabajo.SelectedValue, _
                                                         txtNoAcreUIF.Text.Trim, Format(dtpFechAcre.Value, "Short date"), _
                                                         Format(dtpVencimientoUIF.Value, "Short date"), chkNegFormal.Checked, _
                                                         chkcontribuyente.Checked, txtNoRegContribuyente.Text.Trim, _
                                                         txtNomComEc.Text.Trim, cbEstadoLaboral.SelectedValue, _
                                                         txtDptoTrabajo.Text.Trim, Format(dtpFechaIniTra.Value, "Short date"), _
                                                         txtCargo.Text.Trim, txtIngresosPrim.Text.Trim, _
                                                         txtTotalIngresosPrim.Text.Trim, txtTelOficina.Text.Trim, _
                                                         txtExtOficinaPrim.Text.Trim, cbDeptoOfi.SelectedValue, _
                                                         cbMunOfi.SelectedValue, txtDirOfi.Text.Trim, _
                                                         txtRazonSocialPrim.Text.Trim, txtGiroPrim.Text.Trim, _
                                                         True, txtCodActEconomica.Text.Trim, txtDetIngresos.Text.Trim, _
                                                         txtOtrosIngresos.Value) > 0 Then
                        actPrimaria = True
                        MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                        'Me.tcActividadEco.SelectedIndex = Me.tcActividadEco.SelectedIndex() + 1
                        Me.btnSigEco.Enabled = True
                    End If
                ElseIf actPrimaria = True Then
                    Dim dts As New DataSet
                    dts = asociados.consultarAsocActividadEconomia(txtDui.Value, True)
                    If dts.Tables(0).Rows.Count > 0 Then
                        idActEcoPrim = dts.Tables(0).Rows(0).Item("IdActividadEconomica")
                        If idActEcoPrim > 0 Then
                            If asociados.actulizarAsocActividadEconomica(txtDui.Text.Trim, cbLugarTrabajo.SelectedValue, _
                                                         txtNoAcreUIF.Text.Trim, Format(dtpFechAcre.Value, "Short date"), _
                                                         Format(dtpVencimientoUIF.Value, "Short date"), chkNegFormal.Checked, _
                                                         chkcontribuyente.Checked, txtNoRegContribuyente.Text.Trim, _
                                                         txtNomComEc.Text.Trim, cbEstadoLaboral.SelectedValue, _
                                                         txtDptoTrabajo.Text.Trim, Format(dtpFechaIniTra.Value, "Short date"), _
                                                         txtCargo.Text.Trim, txtIngresosPrim.Text.Trim, _
                                                         txtTotalIngresosPrim.Text.Trim, txtTelOficina.Text.Trim, _
                                                         txtExtOficinaPrim.Text.Trim, cbDeptoOfi.SelectedValue, _
                                                         cbMunOfi.SelectedValue, txtDirOfi.Text.Trim, _
                                                         txtRazonSocialPrim.Text.Trim, txtGiroPrim.Text.Trim, _
                                                         True, txtCodActEconomica.Text.Trim, idActEcoPrim, txtDetIngresos.Text.Trim, _
                                                         txtOtrosIngresos.Value) > 0 Then
                                MsgBox("Información actualizada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                                'Me.tcActividadEco.SelectedIndex = Me.tcActividadEco.SelectedIndex() + 1
                                Me.btnSigEco.Enabled = True
                            End If
                        End If
                    End If
                End If
            ElseIf tcActividadEco.SelectedIndex = 1 Then
                If actPrimaria = True And actSecundaria = False Then
                    If asociados.insertarAsocActividadEconomica(txtDui.Text.Trim, cbLugarTrabajo2.SelectedValue, _
                                                             txtNoAcreUIF2.Text.Trim, Format(dtpFechAcre2.Value, "Short date"), _
                                                             Format(dtpVencimientoUIF2.Value, "Short date"), chkNegFormal2.Checked, _
                                                             chkcontribuyente2.Checked, txtNoRegContribuyente2.Text.Trim, _
                                                             txtNomComEc2.Text.Trim, cbEstadoLaboral2.SelectedValue, _
                                                             txtDptoTrabajo2.Text.Trim, Format(dtpFechaIniTra2.Value, "Short date"), _
                                                             txtCargo2.Text.Trim, txtIngresosSec.Value, _
                                                             txtTotalIngresosSec.Value, txtTelOficina2.Text.Trim, _
                                                             txtExtOficinaSec.Text.Trim, cbDeptoOfi2.SelectedValue, _
                                                             cbMunOfi2.SelectedValue, txtDirOfi2.Text.Trim, _
                                                             txtRazonSocialSec.Text.Trim, txtGiroSec.Text.Trim, _
                                                             False, txtCodActividadEco2.Text.Trim, txtDetIngresos2.Text.Trim, 0) > 0 Then
                        actSecundaria = True
                        MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                        'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                        Me.btnSigEco.Enabled = True
                    End If
                ElseIf actSecundaria = True Then
                    Dim dts As New DataSet
                    dts = asociados.consultarAsocActividadEconomia(txtDui.Value, False)
                    If dts.Tables(0).Rows.Count > 0 Then
                        idActEcoSec = dts.Tables(0).Rows(0).Item("IdActividadEconomica")
                        If asociados.actulizarAsocActividadEconomica(txtDui.Text.Trim, cbLugarTrabajo2.SelectedValue, _
                                                             txtNoAcreUIF2.Text.Trim, Format(dtpFechAcre2.Value, "Short date"), _
                                                             Format(dtpVencimientoUIF2.Value, "Short date"), chkNegFormal2.Checked, _
                                                             chkcontribuyente2.Checked, txtNoRegContribuyente2.Text.Trim, _
                                                             txtNomComEc2.Text.Trim, cbEstadoLaboral2.SelectedValue, _
                                                             txtDptoTrabajo2.Text.Trim, Format(dtpFechaIniTra2.Value, "Short date"), _
                                                             txtCargo2.Text.Trim, txtIngresosSec.Value, _
                                                             txtTotalIngresosSec.Value, txtTelOficina2.Text.Trim, _
                                                             txtExtOficinaSec.Text.Trim, cbDeptoOfi2.SelectedValue, _
                                                             cbMunOfi2.SelectedValue, txtDirOfi2.Text.Trim, _
                                                             txtRazonSocialSec.Text.Trim, txtGiroSec.Text.Trim, _
                                                             False, txtCodActividadEco2.Text.Trim, idActEcoSec, txtDetIngresos2.Text.Trim, 0) > 0 Then
                            MsgBox("Información actualizada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                            'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                            Me.btnSigEco.Enabled = True
                        End If
                    End If
                End If
            End If
        ElseIf accion = 2 Then
            If tcActividadEco.SelectedIndex = 0 Then
                If idActEcoPrim > 0 Then
                    If asociados.actulizarAsocActividadEconomica(txtDui.Text.Trim, cbLugarTrabajo.SelectedValue, _
                                                         txtNoAcreUIF.Text.Trim, Format(dtpFechAcre.Value, "Short date"), _
                                                         Format(dtpVencimientoUIF.Value, "Short date"), chkNegFormal.Checked, _
                                                         chkcontribuyente.Checked, txtNoRegContribuyente.Text.Trim, _
                                                         txtNomComEc.Text.Trim, cbEstadoLaboral.SelectedValue, _
                                                         txtDptoTrabajo.Text.Trim, Format(dtpFechaIniTra.Value, "Short date"), _
                                                         txtCargo.Text.Trim, txtIngresosPrim.Text.Trim, _
                                                         txtTotalIngresosPrim.Text.Trim, txtTelOficina.Text.Trim, _
                                                         txtExtOficinaPrim.Text.Trim, cbDeptoOfi.SelectedValue, _
                                                         cbMunOfi.SelectedValue, txtDirOfi.Text.Trim, _
                                                         idActEcoPrim, txtRazonSocialPrim.Text.Trim, txtGiroPrim.Text.Trim, _
                                                         True, txtCodActEconomica.Text.Trim, txtDetIngresos.Text.Trim, _
                                                         txtOtrosIngresos.Value) > 0 Then
                        MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                        'Me.tcActividadEco.SelectedIndex = Me.tcActividadEco.SelectedIndex() + 1
                        Me.btnSigEco.Enabled = True
                    End If
                Else
                    If asociados.insertarAsocActividadEconomica(txtDui.Text.Trim, cbLugarTrabajo.SelectedValue, _
                                                        txtNoAcreUIF.Text.Trim, Format(dtpFechAcre.Value, "Short date"), _
                                                        Format(dtpVencimientoUIF.Value, "Short date"), chkNegFormal.Checked, _
                                                        chkcontribuyente.Checked, txtNoRegContribuyente.Text.Trim, _
                                                        txtNomComEc.Text.Trim, cbEstadoLaboral.SelectedValue, _
                                                        txtDptoTrabajo.Text.Trim, Format(dtpFechaIniTra.Value, "Short date"), _
                                                        txtCargo.Text.Trim, txtIngresosPrim.Text.Trim, _
                                                        txtTotalIngresosPrim.Text.Trim, txtTelOficina.Text.Trim, _
                                                        txtExtOficinaPrim.Text.Trim, cbDeptoOfi.SelectedValue, _
                                                        cbMunOfi.SelectedValue, txtDirOfi.Text.Trim, _
                                                        txtRazonSocialPrim.Text.Trim, txtGiroPrim.Text.Trim, _
                                                        True, txtCodActEconomica.Text.Trim, txtDetIngresos.Text.Trim, _
                                                        txtOtrosIngresos.Value) > 0 Then
                        actPrimaria = True
                        MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                        'Me.tcActividadEco.SelectedIndex = Me.tcActividadEco.SelectedIndex() + 1
                        Me.btnSigEco.Enabled = True
                    End If
                End If
            ElseIf tcActividadEco.SelectedIndex = 1 Then
                If idActEcoSec > 0 Then
                    If asociados.actulizarAsocActividadEconomica(txtDui.Text.Trim, cbLugarTrabajo2.SelectedValue, _
                                                             txtNoAcreUIF2.Text.Trim, Format(dtpFechAcre2.Value, "Short date"), _
                                                             Format(dtpVencimientoUIF2.Value, "Short date"), chkNegFormal2.Checked, _
                                                             chkcontribuyente2.Checked, txtNoRegContribuyente2.Text.Trim, _
                                                             txtNomComEc2.Text.Trim, cbEstadoLaboral2.SelectedValue, _
                                                             txtDptoTrabajo2.Text.Trim, Format(dtpFechaIniTra2.Value, "Short date"), _
                                                             txtCargo2.Text.Trim, txtIngresosSec.Value, _
                                                             txtTotalIngresosSec.Value, txtTelOficina2.Text.Trim, _
                                                             txtExtOficinaSec.Text.Trim, cbDeptoOfi2.SelectedValue, _
                                                             cbMunOfi2.SelectedValue, txtDirOfi2.Text.Trim, _
                                                             idActEcoSec, txtRazonSocialSec.Text.Trim, txtGiroSec.Text.Trim, _
                                                             False, txtCodActividadEco2.Text.Trim, txtDetIngresos2.Text.Trim, 0) > 0 Then

                        MsgBox("Información actualizada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                        Me.btnSigEco.Enabled = True
                    End If
                ElseIf idActEcoSec = 0 Then
                    If asociados.insertarAsocActividadEconomica(txtDui.Text.Trim, cbLugarTrabajo2.SelectedValue, _
                                                            txtNoAcreUIF2.Text.Trim, Format(dtpFechAcre2.Value, "Short date"), _
                                                            Format(dtpVencimientoUIF2.Value, "Short date"), chkNegFormal2.Checked, _
                                                            chkcontribuyente2.Checked, txtNoRegContribuyente2.Text.Trim, _
                                                            txtNomComEc2.Text.Trim, cbEstadoLaboral2.SelectedValue, _
                                                            txtDptoTrabajo2.Text.Trim, Format(dtpFechaIniTra2.Value, "Short date"), _
                                                            txtCargo2.Text.Trim, txtIngresosSec.Value, _
                                                            txtTotalIngresosSec.Value, txtTelOficina2.Text.Trim, _
                                                            txtExtOficinaSec.Text.Trim, cbDeptoOfi2.SelectedValue, _
                                                            cbMunOfi2.SelectedValue, txtDirOfi2.Text.Trim, _
                                                            txtRazonSocialSec.Text.Trim, txtGiroSec.Text.Trim, _
                                                            False, txtCodActividadEco2.Text.Trim, txtDetIngresos2.Text.Trim, 0) > 0 Then
                        actSecundaria = True
                        MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                        'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                        Me.btnSigEco.Enabled = True
                    End If
                End If
            End If
        End If

    End Sub
    Private Sub btGuardarDeclaJurada_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGuardarDeclaJurada.Click
        Try
            Dim validacion As String
            validacion = asociados.validarCamposDeclaracionJurada(txtDepProm.Value, chkInversionista.Checked, _
                                                                  txtRetPromMen.Value, txtDestCta.Text, _
                                                                  txtOriFondos.Text, txtMontoPromDpf.Value, _
                                                                  chkDocOrigen.Checked, txtOrigenFondosDpf.Text)
            If validacion <> "OK" Then
                MsgBox("El campo " & validacion & " no puede quedar vacio.", MsgBoxStyle.Critical, "Módulo - Asociados")
                Exit Sub
            End If

            If accion = 1 Then
                If validarDeclaracionJurada() = True Then
                    If modificarDecJurada = False Then
                        Dim idDeclaracionJurada As Integer
                        idDeclaracionJurada = asociados.generarIdDeclaracionJurada()
                        If idDeclaracionJurada > 0 Then
                            If asociados.insertarAsocDeclaracionJurada(txtNosocio.Text, txtDepProm.Value, _
                                                                      chkInversionista.Checked, txtRetPromMen.Value, _
                                                                      txtDestCta.Text.Trim, txtOriFondos.Text, _
                                                                      txtMontoPromDpf.Value, _
                                                                      txtOrigenFondosDpf.Text, idDeclaracionJurada) > 0 Then
                                idDeclaracion = idDeclaracionJurada
                                MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                                btGuardarDeclaJurada.Text = "Modificar"
                                Me.btnSigDecJur.Enabled = True
                                modificarDecJurada = True
                            End If
                        End If
                    ElseIf modificarDecJurada = True Then
                        If idDeclaracion > 0 Then
                            If asociados.modificarAsocDeclaracionJurada(txtDepProm.Value, _
                                                                  chkInversionista.Checked, txtRetPromMen.Value, _
                                                                  txtDestCta.Text.Trim, txtOriFondos.Text, _
                                                                  txtMontoPromDpf.Value, _
                                                                  txtOrigenFondosDpf.Text, idDeclaracion) > 0 Then
                                MsgBox("Información actualizada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                            End If
                        End If
                    End If
                End If
            ElseIf accion = 2 Then
                If idDeclaracionJurada > 0 Then
                    If validarDeclaracionJurada() = True Then
                        If asociados.modificarAsocDeclaracionJurada(txtDepProm.Value, _
                                                                  chkInversionista.Checked, txtRetPromMen.Value, _
                                                                  txtDestCta.Text.Trim, txtOriFondos.Text, _
                                                                  txtMontoPromDpf.Value, _
                                                                  txtOrigenFondosDpf.Text, idDeclaracionJurada) > 0 Then
                            MsgBox("Información actualizada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                        End If
                    End If
                ElseIf idDeclaracionJurada = 0 Then
                    If validarDeclaracionJurada() = True Then
                        Dim idDeclaracionJurada As Integer
                        idDeclaracionJurada = asociados.generarIdDeclaracionJurada()
                        If idDeclaracionJurada > 0 Then
                            If asociados.insertarAsocDeclaracionJurada(txtNosocio.Text, txtDepProm.Value, _
                                                                      chkInversionista.Checked, txtRetPromMen.Value, _
                                                                      txtDestCta.Text.Trim, txtOriFondos.Text, _
                                                                      txtMontoPromDpf.Value, _
                                                                      txtOrigenFondosDpf.Text, idDeclaracionJurada) > 0 Then
                                idDeclaracion = idDeclaracionJurada
                                MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                                btGuardarDeclaJurada.Text = "Modificar"
                                Me.btnSigDecJur.Enabled = True
                                modificarDecJurada = True
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnGuardarInfComp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarInfComp.Click
        Try

            Dim validacion As String
            validacion = asociados.validarInfComplementaria(cbNivelEducativo.SelectedValue, txtTituloObtenido.Text, _
                                                            txtNombreConyugue.Text, dtpFechaNacConyugue.Value, _
                                                            cbProfesionConyugue.SelectedValue, txtOficioConyugue.Text, _
                                                            cbTrabajoConyugue.SelectedValue, txtTelConyugue.Text, _
                                                            txtCodActEcoCon.Text.Trim, txtSueldoConyugue.Value, _
                                                            txtIngresoPromMensualConyugue.Value, nuDNumDep.Value, _
                                                            nuDGrupoFam.Value, cbEstadoVivienda.SelectedValue, _
                                                            txtTiempoResidencia.Text, chkFueDir.Checked, _
                                                            chkDir.Checked, txtPerFueDir.Text, _
                                                            txtCuerpoDir.Text, cbCuerpoDir.SelectedValue)
            If validacion <> "OK" Then
                MsgBox("El campo " & validacion & " no puede quedar vacio.", MsgBoxStyle.Critical, "Módulo - Asociados")
                Exit Sub
            End If

            Dim resultado As Integer
            Dim cuerpoDir, nivelEducativo, profesionCon, trabajoCon As String
            If cbCuerpoDir.SelectedValue Is Nothing Then
                cuerpoDir = ""
            Else
                cuerpoDir = cbCuerpoDir.SelectedValue
            End If
            If cbNivelEducativo.SelectedValue Is Nothing Then
                nivelEducativo = ""
            Else
                nivelEducativo = cbNivelEducativo.SelectedValue
            End If
            If cbProfesionConyugue.SelectedValue Is Nothing Then
                profesionCon = ""
            Else
                profesionCon = cbProfesionConyugue.SelectedValue
            End If
            If cbTrabajoConyugue.SelectedValue Is Nothing Then
                trabajoCon = ""
            Else
                trabajoCon = cbTrabajoConyugue.SelectedValue
            End If
            resultado = asociados.insertar_CatAsociados_InfComplementaria(txtDui.Text.Trim, txtTituloObtenido.Text.Trim, _
                                                              txtNombreConyugue.Text.Trim, nuDGrupoFam.Value, _
                                                              nuDNumDep.Value, cbEstadoVivienda.SelectedValue, _
                                                              chkFueDir.Checked, txtPerFueDir.Text.Trim, _
                                                              cuerpoDir, _
                                                              txtTiempoResidencia.Text.Trim, _
                                                              nivelEducativo, _
                                                              Format(dtpFechaNacConyugue.Value, "short date"), _
                                                              profesionCon, _
                                                              txtOficioConyugue.Text.Trim, _
                                                              txtCodActEcoCon.Text.Trim, txtSueldoConyugue.Value, _
                                                              txtIngresoPromMensualConyugue.Value, _
                                                              trabajoCon, _
                                                              txtTelConyugue.Text.Trim, chkDir.Checked, txtCuerpoDir.Text)
            If resultado = 1 Then
                If accion = 1 Then
                    MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                    'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                    infComp = True
                Else
                    MsgBox("Información actualizada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                    'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                    infComp = True
                End If

            Else
                MsgBox("Error. información no ingresada.", MsgBoxStyle.Critical, "Módulo - Asociados")
            End If
        Catch ex As Exception
            MsgBox("Error. información no ingresada." + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Asociados")
        End Try
    End Sub
    Private Sub btnGuardarOtrosDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarOtrosDatos.Click

        Dim validacion As String
        validacion = asociados.validarOtrosDatos(cbEstadoAsociado.SelectedValue, cbEjecutivo.SelectedValue, _
                                                 txtObservacion.Text, cbTipoCuota.SelectedValue)
        If validacion <> "OK" Then
            MsgBox("El campo " & validacion & " no puede quedar vacio.", MsgBoxStyle.Critical, "Módulo - Asociados")
            Exit Sub
        End If


        Dim arrFilename() As String = Split(Text, "\")
        Array.Reverse(arrFilename)
        Dim ms As New MemoryStream
        If PictureBox1.Image Is Nothing = False Then
            PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        End If

        Dim arrImage() As Byte
        If ms.GetBuffer.Length > 0 Then
            arrImage = ms.GetBuffer
        End If
        Dim dtsCodSucEJe As New DataSet
        Dim codSucursal As String = ""
        dtsCodSucEJe = asociados.ConsultarEjecutivosMercadeo("codSucursal", "codEjecMercadeo = '" & Me.cbEjecutivo.SelectedValue & "'", "", sUsuario, sPassword, sSucursal)
        If dtsCodSucEJe.Tables.Count > 0 Then
            If dtsCodSucEJe.Tables(0).Rows.Count > 0 Then
                codSucursal = dtsCodSucEJe.Tables(0).Rows(0).Item(0)
            End If
        End If
        If codSucursal <> "" Then
            If asociados.insertar_CatAsociados_OtrosDatos(txtDui.Text.Trim, _
                                                  cbEstadoAsociado.SelectedIndex.ToString.Trim, _
                                                  arrImage, _
                                                  cbEjecutivo.SelectedValue, _
                                                  txtObservacion.Text.Trim, txtNosocio.Text, sUsuario, Now, _
                                                  codSucursal, Me.cbTipoCuota.SelectedValue, _
                                                  accion) > 0 Then
                MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                otrosDatos = True
            Else
                MsgBox("Información no ingresada", MsgBoxStyle.Critical, "Módulo - Asociados")
            End If
        Else
            MsgBox("Debe seleccionar un ejecutivo de mercadeo.", MsgBoxStyle.Critical, "Módulo - Asociados")
        End If

    End Sub
    Private Sub btnGuardarPep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarPep.Click
        Dim validacion As String
        'validacion = asociados.validarPEP(Format(dtpFechaNomPEP.Value, "short date"), txtPeriodoNombramiento.Text, _
        '                                  cbTipoPep.SelectedValue, txtTiempoLaboral.Value)
        'If validacion <> "OK" Then
        '    MsgBox("El campo " & validacion & " no puede quedar vacio.", MsgBoxStyle.Critical, "Módulo - Asociados")
        '    Exit Sub
        'End If

        If accion = 1 Then
            If validarPep() = True Then
                If modificarPEP = False Then
                    Dim resultado As Integer
                    idPep = asociados.generarIdPep()
                    If idPep <> 0 Then
                        resultado = asociados.insertar_AsocPep(txtDui.Text.Trim, Format(dtpFechaNomPEP.Value, "short date"), _
                                                               cbTipoPep.SelectedValue, txtTiempoLaboral.Value, _
                                                               idPep, txtPeriodoNombramiento.Text, _
                                                               Me.chkPepActivo.Checked, Me.cbParentescoPep.SelectedValue)
                        If resultado <> 0 Then
                            Me.btnAgregarFam.Enabled = True
                            Me.btnAgregarSociedad.Enabled = True
                            btnGuardarPep.Text = "Modificar"
                            MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                            'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                        End If
                    End If
                Else
                    If idPep > 0 Then
                        If asociados.modificarAsocPep(idPep, Format(dtpFechaNomPEP.Value, "short date"), _
                                                  cbTipoPep.SelectedValue, txtTiempoLaboral.Value, _
                                                  txtPeriodoNombramiento.Text.Trim, chkPepActivo.Checked, _
                                                   Me.cbParentescoPep.SelectedValue) > 0 Then
                            MsgBox("Información actualizada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                        End If
                    End If
                End If
            End If
        ElseIf accion = 2 Then
            If validarPep() = True Then
                If idPep > 0 Then
                    If asociados.modificarAsocPep(idPep, Format(dtpFechaNomPEP.Value, "short date"), _
                                                  cbTipoPep.SelectedValue, txtTiempoLaboral.Value, _
                                                  txtPeriodoNombramiento.Text.Trim, chkPepActivo.Checked, _
                                                  Me.cbParentescoPep.SelectedValue) > 0 Then
                        MsgBox("Información actualizada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                    End If
                ElseIf idPep = 0 Then
                    Dim resultado As Integer
                    idPep = asociados.generarIdPep()
                    If idPep <> 0 Then
                        resultado = asociados.insertar_AsocPep(txtDui.Text.Trim, Format(dtpFechaNomPEP.Value, "short date"), _
                                                               cbTipoPep.SelectedValue, txtTiempoLaboral.Value, _
                                                               idPep, txtPeriodoNombramiento.Text, Me.chkPepActivo.Checked, _
                                                               Me.cbParentescoPep.SelectedValue)
                        If resultado <> 0 Then
                            Me.btnAgregarFam.Enabled = True
                            Me.btnAgregarSociedad.Enabled = True
                            btnGuardarPep.Text = "Modificar"
                            MsgBox("Información ingresada exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                            'Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                        End If
                    End If
                End If
            End If
        End If
    End Sub
#End Region
#Region "Estilos Dg"
    Protected Sub estiloDgPepSociedades()
        Me.dgSociedadesPep.ColumnHeadersDefaultCellStyle.BackColor = Color.OliveDrab
        Me.dgSociedadesPep.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgSociedadesPep.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        Me.dgSociedadesPep.Columns("idSociedad").Visible = False
        Me.dgSociedadesPep.Columns("idpep").Visible = False

        Me.dgSociedadesPep.Columns("sociedad").HeaderText = "Sociedad"
        Me.dgSociedadesPep.Columns("porcentajeParticipacion").HeaderText = "Porcentaje de Participación"
    End Sub
    Protected Sub estiloDgPepFamiliares()
        Me.dgFamiliaPep.ColumnHeadersDefaultCellStyle.BackColor = Color.OliveDrab
        Me.dgFamiliaPep.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgFamiliaPep.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        Me.dgFamiliaPep.Columns("idFamiliarPep").Visible = False
        Me.dgFamiliaPep.Columns("idpep").Visible = False
        Me.dgFamiliaPep.Columns("codTipoFamiliar").Visible = False

        Me.dgFamiliaPep.Columns("tipoFamiliar").HeaderText = "Tipo de Familiar"
        Me.dgFamiliaPep.Columns("nombres").HeaderText = "Nombres"
    End Sub
    Protected Sub estiloDgDocumentos()
        Me.dgDocumentos.ColumnHeadersDefaultCellStyle.BackColor = Color.OliveDrab
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


    End Sub
    Private Sub estiloDgJuntaDirectiva()
        Try
            Me.dgJuntaDirectiva.ColumnHeadersDefaultCellStyle.BackColor = Color.OliveDrab
            Me.dgJuntaDirectiva.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            Me.dgJuntaDirectiva.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
            Me.dgJuntaDirectiva.Columns("Nombres").HeaderText = "Nombre"
            Me.dgJuntaDirectiva.Columns("Cargo").HeaderText = "Cargo"
            Me.dgJuntaDirectiva.Columns("Activo").HeaderText = "Activo"
            Me.dgJuntaDirectiva.Columns("idJuntaDirectiva").Visible = False
            Me.dgJuntaDirectiva.Columns("idCatPerJuridica").Visible = False
            Me.dgJuntaDirectiva.Columns("Nombres").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            Me.dgJuntaDirectiva.Columns("Cargo").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Catch ex As Exception

        End Try
       


    End Sub
#End Region
#Region "Llenar Dg"

    Protected Sub llenarDgDocumentos(ByVal idDeclaracion As Integer)
        Try
            If Me.dgDocumentos.Rows.Count > 0 Then
                Me.dgDocumentos.Columns.Remove("modificar")
                Me.dgDocumentos.Columns.Remove("eliminar")
            End If
            Dim dts As New DataSet
            dts = asociados.consultarAsocDeclaracionJuradaDocumentos(idDeclaracion)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    Me.dgDocumentos.DataSource = dts.Tables(0)
                    Dim btnColumnModificar As New DataGridViewButtonColumn
                    With btnColumnModificar
                        .UseColumnTextForButtonValue = True
                        '.DefaultCellStyle.BackColor = Color.SteelBlue
                        .DefaultCellStyle.ForeColor = Color.Red
                        .Text = "Modificar"
                        .Name = "Modificar"
                        .HeaderText = "Modificar Documento"
                        .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    End With
                    Me.dgDocumentos.Columns.Add(btnColumnModificar)


                    Dim btnColumnEliminar As New DataGridViewButtonColumn
                    With btnColumnEliminar

                        .UseColumnTextForButtonValue = True
                        '.DefaultCellStyle.BackColor = Color.SteelBlue
                        .DefaultCellStyle.ForeColor = Color.Red
                        .Text = "Eliminar"
                        .Name = "Eliminar"
                        .HeaderText = "Eliminar Documento"
                        .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    End With
                    Me.dgDocumentos.Columns.Add(btnColumnEliminar)
                    estiloDgDocumentos()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Protected Sub llenarDgFamiliaresPep(ByVal idPep As Integer)
        Try
            If Me.dgFamiliaPep.Rows.Count > 0 Then
                Me.dgFamiliaPep.Columns.Remove("modificar")
                Me.dgFamiliaPep.Columns.Remove("eliminar")
            End If
            Dim dts As New DataSet
            dts = asociados.consultarAsocPep_Familiares(idPep)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    Me.dgFamiliaPep.DataSource = dts.Tables(0)
                    Dim btnColumnModificar As New DataGridViewButtonColumn
                    With btnColumnModificar
                        .Width = 50
                        .UseColumnTextForButtonValue = True
                        '.DefaultCellStyle.BackColor = Color.SteelBlue
                        .DefaultCellStyle.ForeColor = Color.Red
                        .Text = "Modificar"
                        .Name = "Modificar"
                        .HeaderText = "Modificar Documento"
                        .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    End With
                    Me.dgFamiliaPep.Columns.Add(btnColumnModificar)


                    Dim btnColumnEliminar As New DataGridViewButtonColumn
                    With btnColumnEliminar
                        .Width = 50
                        .UseColumnTextForButtonValue = True
                        '.DefaultCellStyle.BackColor = Color.SteelBlue
                        .DefaultCellStyle.ForeColor = Color.Red
                        .Text = "Eliminar"
                        .Name = "Eliminar"
                        .HeaderText = "Eliminar Documento"
                        .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    End With
                    Me.dgFamiliaPep.Columns.Add(btnColumnEliminar)
                    estiloDgPepFamiliares()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Protected Sub llenarDgSociedadesPep(ByVal idPep)
        Try
            If Me.dgSociedadesPep.Rows.Count > 0 Then
                Me.dgSociedadesPep.Columns.Remove("modificar")
                Me.dgSociedadesPep.Columns.Remove("eliminar")
            End If
            Dim dts As New DataSet
            dts = asociados.consultarAsocPep_Sociedades(idPep)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    Me.dgSociedadesPep.DataSource = dts.Tables(0)
                    Dim btnColumnModificar As New DataGridViewButtonColumn
                    With btnColumnModificar
                        .Width = 50
                        .UseColumnTextForButtonValue = True
                        '.DefaultCellStyle.BackColor = Color.SteelBlue
                        .DefaultCellStyle.ForeColor = Color.Red
                        .Text = "Modificar"
                        .Name = "Modificar"
                        .HeaderText = "Modificar Documento"
                        .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    End With
                    Me.dgSociedadesPep.Columns.Add(btnColumnModificar)


                    Dim btnColumnEliminar As New DataGridViewButtonColumn
                    With btnColumnEliminar
                        .Width = 50
                        .UseColumnTextForButtonValue = True
                        '.DefaultCellStyle.BackColor = Color.SteelBlue
                        .DefaultCellStyle.ForeColor = Color.Red
                        .Text = "Eliminar"
                        .Name = "Eliminar"
                        .HeaderText = "Eliminar Documento"
                        .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                    End With
                    Me.dgSociedadesPep.Columns.Add(btnColumnEliminar)
                    estiloDgPepSociedades()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Protected Sub llenarDgJuntaDirectiva(ByVal idperJur As Integer)
        Try
            If Me.dgJuntaDirectiva.Rows.Count > 0 Then
                Me.dgJuntaDirectiva.Columns.Remove("modificar")
                Me.dgJuntaDirectiva.Columns.Remove("eliminar")
            End If
            Dim dts As New DataSet
            dts = asociados.consultarAsocPersonaJuridicaDirectivos(idperJur)
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgJuntaDirectiva.DataSource = dts.Tables(0)
                Dim btnColumnModificar As New DataGridViewButtonColumn
                With btnColumnModificar
                    .Width = 50
                    .UseColumnTextForButtonValue = True
                    '.DefaultCellStyle.BackColor = Color.SteelBlue
                    .DefaultCellStyle.ForeColor = Color.Red
                    .Text = "Modificar"
                    .Name = "Modificar"
                    .HeaderText = "Modificar Documento"
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                End With
                Me.dgJuntaDirectiva.Columns.Add(btnColumnModificar)


                Dim btnColumnEliminar As New DataGridViewButtonColumn
                With btnColumnEliminar
                    .Width = 50
                    .UseColumnTextForButtonValue = True
                    '.DefaultCellStyle.BackColor = Color.SteelBlue
                    .DefaultCellStyle.ForeColor = Color.Red
                    .Text = "Eliminar"
                    .Name = "Eliminar"
                    .HeaderText = "Eliminar Documento"
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                End With
                Me.dgJuntaDirectiva.Columns.Add(btnColumnEliminar)
                estiloDgJuntaDirectiva()
            End If
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Eventos DG"
    Private Sub dgJuntaDirectiva_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgJuntaDirectiva.CellClick
        If Me.dgJuntaDirectiva.CurrentRow.Index > -1 Then
            If Me.dgJuntaDirectiva.Columns(e.ColumnIndex).Name = "Eliminar" Then
                If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo Asociados") = MsgBoxResult.Yes Then
                    Dim idPerJur As Integer
                    idPerJur = Me.dgJuntaDirectiva.Item("IdCatPerJuridica", Me.dgJuntaDirectiva.CurrentRow.Index).Value
                    Dim idJunta, resultado As Integer
                    idJunta = dgJuntaDirectiva.Item("idJuntaDirectiva", Me.dgJuntaDirectiva.CurrentRow.Index).Value
                    If asociados.eliminarAsocPersonaJuridicaDirectivos(idJunta) > 0 Then
                        MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                        llenarDgJuntaDirectiva(idPerJur)
                    Else
                        MsgBox("El registro no pudo ser eliminado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Asociados")
                    End If

                End If
            ElseIf Me.dgJuntaDirectiva.Columns(e.ColumnIndex).Name = "Modificar" Then
                Dim frm As New frmMsJuntaDirectivaActEco
                With frm
                    .accion = 2
                    .txtNombreDir.Text = Me.dgJuntaDirectiva.Item("Nombres", Me.dgJuntaDirectiva.CurrentRow.Index).Value
                    .txtCargo.Text = Me.dgJuntaDirectiva.Item("Cargo", Me.dgJuntaDirectiva.CurrentRow.Index).Value
                    .chkActivo.Checked = Me.dgJuntaDirectiva.Item("Activo", Me.dgJuntaDirectiva.CurrentRow.Index).Value
                    .idJuntaDirectiva = Me.dgJuntaDirectiva.Item("idJuntaDirectiva", Me.dgJuntaDirectiva.CurrentRow.Index).Value
                    .idPersonaJur = Me.dgJuntaDirectiva.Item("IdCatPerJuridica", Me.dgJuntaDirectiva.CurrentRow.Index).Value
                    .ShowDialog(Me)
                End With
                llenarDgJuntaDirectiva(Me.dgJuntaDirectiva.Item("IdCatPerJuridica", Me.dgJuntaDirectiva.CurrentRow.Index).Value)
            End If
        End If
    End Sub
    Private Sub dgDocumentos_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDocumentos.CellClick
        If Me.dgDocumentos.CurrentRow.Index > -1 Then
            If Me.dgDocumentos.Columns(e.ColumnIndex).Name = "Eliminar" Then
                If MsgBox("¿Desea eliminar el documento?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo Asociados") = MsgBoxResult.Yes Then
                    Dim idDoc, resultado As Integer
                    idDoc = Me.dgDocumentos.Item("idDoc", Me.dgDocumentos.CurrentRow.Index).Value
                    resultado = asociados.anularAsocDeclaracionJuradaDocumentos(idDoc, False)
                    llenarDgDocumentos(idDeclaracion)
                End If
            ElseIf Me.dgDocumentos.Columns(e.ColumnIndex).Name = "Modificar" Then
                Dim frm As New frmMsDocDeclaracionJurada
                With frm
                    .accion = 2
                    .idDoc = Me.dgDocumentos.Item("idDoc", Me.dgDocumentos.CurrentRow.Index).Value
                    .llenarCbDocumentos()
                    .llenarCbPlazo()
                    .cbPlazo.SelectedValue = Me.dgDocumentos.Item("PlazoPresentacion", Me.dgDocumentos.CurrentRow.Index).Value
                    .cbTipoDoc.SelectedValue = Me.dgDocumentos.Item("idDocumento", Me.dgDocumentos.CurrentRow.Index).Value
                    .chkPresentoDoc.Checked = Me.dgDocumentos.Item("PresentoDocumento", Me.dgDocumentos.CurrentRow.Index).Value
                    .dtpFechaEntrega.Value = Me.dgDocumentos.Item("FechaPresentacion", Me.dgDocumentos.CurrentRow.Index).Value
                    .btnGuardar.Text = "Modificar"
                    .ShowDialog(Me)
                End With
                llenarDgDocumentos(idDeclaracion)
            End If
        End If
    End Sub
    Private Sub dgDocumentos_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDocumentos.CellDoubleClick
        If Me.dgDocumentos.CurrentRow.Index > -1 Then
            Dim frm As New frmMsDocDeclaracionJurada
            With frm
                .accion = 2
                .idDeclaracion = idDeclaracion
                .llenarCbDocumentos()
                .llenarCbPlazo()
                .idDocumento = Me.dgDocumentos.Item("idDoc", Me.dgDocumentos.CurrentRow.Index).Value
                .cbPlazo.SelectedValue = Me.dgDocumentos.Item("PlazoPresentacion", Me.dgDocumentos.CurrentRow.Index).Value
                .cbTipoDoc.SelectedValue = Me.dgDocumentos.Item("idDocumento", Me.dgDocumentos.CurrentRow.Index).Value
                .chkPresentoDoc.Checked = Me.dgDocumentos.Item("PresentoDocumento", Me.dgDocumentos.CurrentRow.Index).Value
                .btnGuardar.Text = "Guardar"
                .ShowDialog(Me)
            End With

        End If
    End Sub
    Private Sub dgFamiliaPep_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgFamiliaPep.CellClick
        If Me.dgFamiliaPep.CurrentRow.Index > -1 Then
            If Me.dgFamiliaPep.Columns(e.ColumnIndex).Name = "Eliminar" Then
                idPep = Me.dgFamiliaPep.Item("idPep", Me.dgFamiliaPep.CurrentRow.Index).Value
                If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo Asociados") = MsgBoxResult.Yes Then
                    If asociados.eliminarAsocPep_Familiares(Me.dgFamiliaPep.Item("idFamiliarPep", Me.dgFamiliaPep.CurrentRow.Index).Value) > 0 Then
                        MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                        llenarDgFamiliaresPep(idPep)
                    End If
                End If
            ElseIf Me.dgFamiliaPep.Columns(e.ColumnIndex).Name = "Modificar" Then
                Dim frm As New frmMsFamiliaresPep
                With frm
                    .llenarTipoFamiliar()
                    .IdFamiliarPep = Me.dgFamiliaPep.Item("idFamiliarPep", Me.dgFamiliaPep.CurrentRow.Index).Value
                    .cbParentesco.SelectedValue = Me.dgFamiliaPep.Item("codtipoFamiliar", Me.dgFamiliaPep.CurrentRow.Index).Value
                    .txtNombre.Text = Me.dgFamiliaPep.Item("nombres", Me.dgFamiliaPep.CurrentRow.Index).Value
                    .idPep = Me.dgFamiliaPep.Item("idPep", Me.dgFamiliaPep.CurrentRow.Index).Value
                    .accion = 2
                    .ShowDialog(Me)
                End With
                llenarDgFamiliaresPep(Me.dgFamiliaPep.Item("idPep", Me.dgFamiliaPep.CurrentRow.Index).Value)
            End If
        End If
    End Sub
    Private Sub dgSociedadesPep_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgSociedadesPep.CellClick
        If Me.dgSociedadesPep.CurrentRow.Index > -1 Then
            If Me.dgSociedadesPep.Columns(e.ColumnIndex).Name = "Eliminar" Then
                idPep = Me.dgSociedadesPep.Item("idPep", Me.dgSociedadesPep.CurrentRow.Index).Value
                If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo Asociados") = MsgBoxResult.Yes Then
                    If asociados.eliminarAsocPep_Sociedades(Me.dgSociedadesPep.Item("idSociedad", Me.dgSociedadesPep.CurrentRow.Index).Value) > 0 Then
                        MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                        llenarDgSociedadesPep(idPep)
                    End If
                End If
            ElseIf Me.dgSociedadesPep.Columns(e.ColumnIndex).Name = "Modificar" Then
                Dim frm As New frmMsAsociacionesPep
                With frm
                    .idPep = Me.dgSociedadesPep.Item("idPep", Me.dgSociedadesPep.CurrentRow.Index).Value
                    .idSociedad = Me.dgSociedadesPep.Item("idSociedad", Me.dgSociedadesPep.CurrentRow.Index).Value
                    .txtSociedad.Text = Me.dgSociedadesPep.Item("sociedad", Me.dgSociedadesPep.CurrentRow.Index).Value
                    .txtPorParticipacin.Value = Me.dgSociedadesPep.Item("porcentajeParticipacion", Me.dgSociedadesPep.CurrentRow.Index).Value
                    .accion = 2
                    .ShowDialog(Me)
                End With
                llenarDgSociedadesPep(Me.dgSociedadesPep.Item("idPep", Me.dgSociedadesPep.CurrentRow.Index).Value)
            End If
        End If
    End Sub
#End Region


    Private Sub cbDeptoPerJur_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDeptoPerJur.DropDownClosed
        llenarCbMunicipioJur(cbDeptoPerJur.SelectedValue)
    End Sub
    Private Sub cbDeptoPerJur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbDeptoPerJur.KeyPress
        llenarCbMunicipioJur(cbDeptoPerJur.SelectedValue)
    End Sub
    Private Sub cbDeptoPerJur_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDeptoPerJur.LostFocus
        llenarCbMunicipioJur(cbDeptoPerJur.SelectedValue)
    End Sub
    Private Sub cbDeptoPerJur_MouseWheel(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cbDeptoPerJur.MouseWheel
        llenarCbMunicipioJur(cbDeptoPerJur.SelectedValue)
    End Sub

    Private Sub btnAgregarDoc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAgregarDoc.Click
        If idDeclaracion > 0 Then
            'If Me.dgDocumentos.Rows.Count > 0 Then
            '    Me.dgDocumentos.Columns.Remove("modificar")
            '    Me.dgDocumentos.Columns.Remove("eliminar")
            'End If


            Dim frm As New frmMsDocDeclaracionJurada
            With frm
                .idDeclaracion = idDeclaracion
                .accion = 1
                .btnGuardar.Text = "Guardar"
                .ShowDialog(Me)
            End With
            llenarDgDocumentos(idDeclaracion)
            'Me.dgDocumentos.DataSource = asociados.consultarAsocDeclaracionJuradaDocumentos(idDeclaracion).Tables(0)
        Else
            MsgBox("primero debe guardar la declaracion")
        End If

    End Sub




    Private Sub btnCargarFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargarFoto.Click
        Dim texto As String
        OpenFileDialog1.ShowDialog()
        texto = OpenFileDialog1.FileName.ToString
        PictureBox1.Image = System.Drawing.Image.FromFile(texto)
    End Sub
    Protected Function extraerImagen(ByVal foto() As Byte)
        Dim ms As New MemoryStream(foto)
        PictureBox1.Image = Image.FromStream(ms)
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarFam.Click
        If idPep > 0 Then
            Dim frm As New frmMsFamiliaresPep
            With frm
                .idPep = idPep
                .accion = 1
                .ShowDialog(Me)
            End With
            llenarDgFamiliaresPep(idPep)
        End If

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarSociedad.Click
        If idPep > 0 Then
            Dim frm As New frmMsAsociacionesPep
            With frm
                .idPep = idPep
                .accion = 1
                .ShowDialog(Me)
            End With
        End If
        llenarDgSociedadesPep(idPep)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJuntaDirectiva.Click
        Dim idPerJur As Integer
        idPerJur = asociados.recuperarIdPersonaJuridica(CInt(txtNosocio.Text.Trim))
        If idPerJur > 0 Then
            Dim frm As New frmMsJuntaDirectivaActEco
            With frm
                .accion = 1
                .idPersonaJur = idPerJur
                .ShowDialog(Me)
            End With
            llenarDgJuntaDirectiva(idPerJur)
            estiloDgJuntaDirectiva()
        End If

    End Sub
    
    
    Private Sub txtCodActEconomica_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodActEconomica.DoubleClick
        Dim frm As New frmMsConsultarActividadEconomica
        Dim dts As New DataSet
        frm.Text = "Buscar Actividad Económica"
        Try
            frm.ShowDialog()
            txtCodActEconomica.Text = frm.Resultado
            txtDescripcionActEco.Text = frm.Resultado2
            If frm.Resultado3 = True Then
                MsgBox("Por favor ingresar información de APFND", MsgBoxStyle.Information, "Módulo - Asociados")
                txtNoAcreUIF.Enabled = True
                dtpFechAcre.Enabled = True
                dtpVencimientoUIF.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Ejecutivos Mercadeo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtCodActividadEco2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodActividadEco2.DoubleClick
        Dim frm As New frmMsConsultarActividadEconomica
        Dim dts As New DataSet
        frm.Text = "Buscar Actividad Económica"
        Try
            frm.ShowDialog()
            txtCodActividadEco2.Text = frm.Resultado
            txtDescripcionActEco2.Text = frm.Resultado2
            If frm.Resultado3 = True Then
                MsgBox("Por favor ingresar información de APFND", MsgBoxStyle.Information, "Módulo - Asociados")
                txtNoAcreUIF2.Enabled = True
                dtpFechAcre2.Enabled = True
                dtpVencimientoUIF2.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Ejecutivos Mercadeo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub TextBox2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodActEcoCon.DoubleClick
        Dim frm As New frmMsConsultarActividadEconomica
        Dim dts As New DataSet
        frm.Text = "Buscar Actividad Económica"
        Try
            frm.ShowDialog()
            txtCodActEcoCon.Text = frm.Resultado
            txtDescripcionActEcoCon.Text = frm.Resultado2
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Ejecutivos Mercadeo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If reIngreso = False Then
            Dim dts As New DataSet
            dts = asociados.ConsultarAsociado("Dui", "dui='" & txtDui.Text.Trim & "'", "", sUsuario, sPassword, sSucursal)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    If MsgBox("El dui ya se encuentra asignado, ¿desea realizar reingreso del asociado?", MsgBoxStyle.YesNo, "Módulo - Asociado") = MsgBoxResult.Yes Then
                        llenarDatosAsoc(txtDui.Text.Trim)
                        reIngreso = True
                        Me.cbEstadoAsociado.SelectedIndex = 0
                        Me.cbEstadoAsociado.Enabled = False
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub txtNit_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNit.LostFocus
        If reIngreso = False Then
            Dim dts As New DataSet
            dts = asociados.ConsultarAsociado("Dui", "nit='" & txtNit.Text.Trim & "'", "", sUsuario, sPassword, sSucursal)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    If MsgBox("El dui ya se encuentra asignado, ¿desea realizar reingreso del asociado?", MsgBoxStyle.YesNo, "Módulo - Asociado") = MsgBoxResult.Yes Then
                        llenarDatosAsoc(dts.Tables(0).Rows(0).Item("Dui").ToString.Trim)
                        reIngreso = True
                        Me.cbEstadoAsociado.SelectedIndex = 0
                        Me.cbEstadoAsociado.Enabled = False
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub cbDeptoOfi2_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDeptoOfi2.DropDownClosed
        llenarCbMunicipioActEco2(Me.cbDeptoOfi2.SelectedValue)
    End Sub
    Private Sub chkInversionista_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkInversionista.CheckedChanged
        If chkInversionista.Checked = True Then
            txtMontoPromDpf.Enabled = True
            txtOrigenFondosDpf.Enabled = True
        Else
            txtMontoPromDpf.Enabled = False
            txtOrigenFondosDpf.Enabled = True
            txtMontoPromDpf.Text = ""
            txtOriFondos.Text = ""
        End If
    End Sub

    Private Sub dtpFechaExtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFechaExtDui.LostFocus
        Dim dts As New DataSet
        dts = asociados.ConsultarParametros("AniosMaxDui", "", "AniosMaxDui", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Dim annios As Integer
                annios = dts.Tables(0).Rows(0).Item(0)
                If DateDiff(DateInterval.Year, dtpFechaExtDui.Value, Now) >= annios Then
                    MsgBox("Fecha de extensión de DUI ha superado su fecha de vencimiento", MsgBoxStyle.Critical, "Módulo - Asocidos")
                    fechaExtDui = True
                Else
                    fechaExtDui = False
                End If
            End If
        End If
    End Sub

   
  
    Private Sub cbDepto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDepto.Leave
        Me.llenarCbMunicipio(Me.cbDepto.SelectedValue)
    End Sub

    Private Sub cbDeptoOfi_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDeptoOfi.Leave
        Me.llenarCbMunicipioActEco1(Me.cbDeptoOfi.SelectedValue)
    End Sub

    Private Sub cbDeptoOfi2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDeptoOfi2.Leave
        Me.llenarCbMunicipioActEco2(Me.cbDeptoOfi2.SelectedValue)
    End Sub


#Region "Referencias&Beneficiarios"
    Protected Sub llenarDgReferencias(ByVal dui As String)
        If Me.dgReferencia.Rows.Count > 0 Then
            Me.dgReferencia.Columns.Remove("modificar")
            Me.dgReferencia.Columns.Remove("eliminar")
        End If
        Dim dts As New DataSet
        dts = asociados.ConsultarReferencias("NumRef,Nombre,apellido1,apellido2,direccion,telCasa,lugarTrabajo,cargo,direccionTrabajo,telOficina,emails,codParentesco", _
                                             " dui = '" & dui & "' ", "", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgReferencia.DataSource = dts.Tables(0)
                Dim btnColumnModificar As New DataGridViewButtonColumn
                With btnColumnModificar
                    .Width = 50
                    .UseColumnTextForButtonValue = True
                    '.DefaultCellStyle.BackColor = Color.SteelBlue
                    .DefaultCellStyle.ForeColor = Color.Red
                    .Text = "Modificar"
                    .Name = "Modificar"
                    .HeaderText = "Modificar"
                End With
                Me.dgReferencia.Columns.Add(btnColumnModificar)


                Dim btnColumnEliminar As New DataGridViewButtonColumn
                With btnColumnEliminar
                    .Width = 50
                    .UseColumnTextForButtonValue = True
                    '.DefaultCellStyle.BackColor = Color.SteelBlue
                    .DefaultCellStyle.ForeColor = Color.Red
                    .Text = "Eliminar"
                    .Name = "Eliminar"
                    .HeaderText = "Eliminar"
                End With
                Me.dgReferencia.Columns.Add(btnColumnEliminar)
                estiloDgReferencias()
            End If
        End If
    End Sub
    Protected Sub estiloDgReferencias()
        Me.dgReferencia.ColumnHeadersDefaultCellStyle.BackColor = Color.OliveDrab
        Me.dgReferencia.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgReferencia.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        Me.dgReferencia.Columns("NumRef").Visible = False
        Me.dgReferencia.Columns("codParentesco").Visible = False


        Me.dgReferencia.Columns("Nombre").HeaderText = "Nombre"
        Me.dgReferencia.Columns("apellido1").HeaderText = "Primer Apellido"
        Me.dgReferencia.Columns("apellido2").HeaderText = "Segundo Apellido"
        Me.dgReferencia.Columns("direccion").HeaderText = "Dirección"
        Me.dgReferencia.Columns("telCasa").HeaderText = "Tel. Casa"
        Me.dgReferencia.Columns("lugarTrabajo").HeaderText = "Lugar Trabajo"
        Me.dgReferencia.Columns("cargo").HeaderText = "Cargo"
        Me.dgReferencia.Columns("direccionTrabajo").HeaderText = "Dirección Trabajo"
        Me.dgReferencia.Columns("telOficina").HeaderText = "Tel. Oficina"
        Me.dgReferencia.Columns("emails").HeaderText = "Email"



    End Sub
    Protected Sub llenarDgBeneficiarios(ByVal dui As String)
        Try
            If Me.dgBeneficiario.Rows.Count > 0 Then
                Me.dgBeneficiario.Columns.Remove("modificar")
                Me.dgBeneficiario.Columns.Remove("eliminar")
            End If
            Dim dts As New DataSet
            dts = asociados.ConsultarBeneficiarios("correlativo,Nombres,Apellido1,apellido2,apellidoCas,codParentesco,porcentBeneficio,direccion,telCasa,telOficina,emails,duiBeneficiario,TipoDoc,sexo", _
                                                   " dui = '" & dui & "' ", " correlativo", sUsuario, _
                                                   sPassword, sSucursal)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    Me.dgBeneficiario.DataSource = dts.Tables(0)
                    Dim btnColumnModificar As New DataGridViewButtonColumn
                    With btnColumnModificar
                        .Width = 50
                        .UseColumnTextForButtonValue = True
                        '.DefaultCellStyle.BackColor = Color.SteelBlue
                        .DefaultCellStyle.ForeColor = Color.Red
                        .Text = "Modificar"
                        .Name = "Modificar"
                        .HeaderText = "Modificar"
                    End With
                    Me.dgBeneficiario.Columns.Add(btnColumnModificar)


                    Dim btnColumnEliminar As New DataGridViewButtonColumn
                    With btnColumnEliminar
                        .Width = 50
                        .UseColumnTextForButtonValue = True
                        '.DefaultCellStyle.BackColor = Color.SteelBlue
                        .DefaultCellStyle.ForeColor = Color.Red
                        .Text = "Eliminar"
                        .Name = "Eliminar"
                        .HeaderText = "Eliminar"
                    End With
                    Me.dgBeneficiario.Columns.Add(btnColumnEliminar)
                    estiloDgBeneficiarios()
                End If
            End If
        
        Catch ex As Exception

        End Try

    End Sub
    Protected Sub estiloDgBeneficiarios()
        Try
            Me.dgBeneficiario.ColumnHeadersDefaultCellStyle.BackColor = Color.OliveDrab
            Me.dgBeneficiario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            Me.dgBeneficiario.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

            Me.dgBeneficiario.Columns("correlativo").Visible = False
            Me.dgBeneficiario.Columns("codParentesco").Visible = False
            Me.dgBeneficiario.Columns("TipoDoc").Visible = False
            Me.dgBeneficiario.Columns("sexo").Visible = False


            Me.dgBeneficiario.Columns("Nombres").HeaderText = "Nombres"
            Me.dgBeneficiario.Columns("apellido1").HeaderText = "Primer Apellido"
            Me.dgBeneficiario.Columns("apellido2").HeaderText = "Segundo Apellido"
            Me.dgBeneficiario.Columns("direccion").HeaderText = "Dirección"
            Me.dgBeneficiario.Columns("telCasa").HeaderText = "Tel. Casa"
            Me.dgBeneficiario.Columns("telOficina").HeaderText = "Tel. Oficina"
            Me.dgBeneficiario.Columns("emails").HeaderText = "Email"
            Me.dgBeneficiario.Columns("duiBeneficiario").HeaderText = "No. Documento"


        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnAddReferencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddReferencia.Click
        Dim frm As New frmMsDetReferencia
        With frm
            .pDui = txtDui.Text.Trim
            .btnGuardar1.Text = "&Guardar"
            .ShowDialog(Me)
        End With
        llenarDgReferencias(txtDui.Value)

    End Sub

    Private Sub btnAddBeneficiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBeneficiario.Click
        Dim frm As frmMsDetBeneficiarios = New frmMsDetBeneficiarios
        frm.pDui = Trim(txtDui.Text)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog(Me)
        llenarDgBeneficiarios(txtDui.Value)
    End Sub
    Private Sub dgReferencia_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgReferencia.CellClick
        If Me.dgReferencia.CurrentRow.Index > -1 Then
            If Me.dgReferencia.Columns(e.ColumnIndex).Name = "Eliminar" Then
                If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo Asociados") = MsgBoxResult.Yes Then
                    If asociados.EliminarReferencias("dui = '" & txtDui.Value & "' and numRef = '" & Me.dgReferencia.Item("NumRef", Me.dgReferencia.CurrentRow.Index).Value & "' ", sUsuario, sPassword, sSucursal) = True Then
                        MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                    Else
                        MsgBox("El registro no pudo ser eliminado, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Asociados")
                    End If
                End If
            ElseIf Me.dgReferencia.Columns(e.ColumnIndex).Name = "Modificar" Then
                Dim frm As frmMsDetReferencia = New frmMsDetReferencia
                frm.pDui = txtDui.Value
                frm.btnGuardar1.Text = "&Modificar"
                frm.pCorrelativo = Me.dgReferencia.Item("NumRef", Me.dgReferencia.CurrentRow.Index).Value 'fgDetRef.Item(fgDetRef.Row, "NumRef")
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog(Me)
            End If
            llenarDgReferencias(txtDui.Value)
        End If
    End Sub

    Private Sub dgBeneficiario_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgBeneficiario.CellClick
        If Me.dgBeneficiario.CurrentRow.Index > -1 Then
            If Me.dgBeneficiario.Columns(e.ColumnIndex).Name = "Eliminar" Then
                If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo Asociados") = MsgBoxResult.Yes Then
                    'If asociados.EliminarBeneficiarios(" correlativo = '" & Me.dgReferencia.Item("Correlativo", Me.dgBeneficiario.CurrentRow.Index).Value & "' , dui = '" & txtDui.Value & "' ", _
                    If asociados.EliminarBeneficiarios(" correlativo = '" & Me.dgBeneficiario.Item("Correlativo", Me.dgBeneficiario.CurrentRow.Index).Value & "' ", _
                                                       sUsuario, sPassword, sSucursal) = True Then
                        MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                    Else
                        MsgBox("El registro no pudo ser eliminado, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Asociados")
                    End If

                    'ActualizaGrid()
                End If
            ElseIf Me.dgBeneficiario.Columns(e.ColumnIndex).Name = "Modificar" Then
                Dim frm As frmMsDetBeneficiarios = New frmMsDetBeneficiarios
                frm.pDui = txtDui.Value
                frm.pCorrelativo = Me.dgBeneficiario.Item("Correlativo", Me.dgBeneficiario.CurrentRow.Index).Value
                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog(Me)
            End If
            llenarDgBeneficiarios(txtDui.Value)
        End If
    End Sub
#End Region

   
    Private Sub btnImpSol_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImpSol.Click
        'Dim frm As New frmVisorRS
        'OpcionRS = 74
        'With frm
        '    .dui = txtDui.Value
        '    .ShowDialog(Me)
        'End With
        Dim dts As New DataSet
        dts = asociados.rptSolicitudIngreso(txtDui.Value)
        Dim ofrm As New frmVisor(dts, 218, 0)
        ofrm.ShowDialog(Me)
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub
#Region "Nuevas funciones 25/02/2016"
    Public Sub llenarCbCuotaIngreso()
        Dim dts As New DataSet
        dts = asociados.ConsultarTipoCuota("codCuota,Descripcion", "estado = '1' ", "Descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbTipoCuota.DataSource = dts.Tables(0)
                Me.cbTipoCuota.DisplayMember = "descripcion"
                Me.cbTipoCuota.ValueMember = "codCuota"
            End If
        End If
    End Sub
#End Region

    Private Sub btmImpDJ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btmImpDJ.Click
        Dim frm As New frmVisorRS
        OpcionRS = 79
        With frm
            .dui = txtDui.Value
            .ShowDialog(Me)
        End With
    End Sub

    Private Sub btnDecJurGA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecJurGA.Click
        Dim frm As New frmVisorRS
        OpcionRS = 76
        With frm
            .dui = txtDui.Value
            .ShowDialog(Me)
        End With
    End Sub

    Private Sub btnBuscLN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscLN.Click
        Dim frm As New frmVisorRS
        OpcionRS = 77
        With frm
            .ShowDialog(Me)
        End With
    End Sub
#Region "Relaciones Asociados"
    Private Sub btnAgregarRelacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarRelacion.Click
        Dim frm As New frmMsRelacionesAsoc
        With frm
            .dui = txtDui.Text.Trim
            .accion = 1
            .ShowDialog(Me)
            llenarDgRelaciones(txtDui.Text.Trim)
        End With
    End Sub

    Private Sub dgRelaciones_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRelaciones.CellClick
        Dim correlativo As Integer
        If Me.dgRelaciones.CurrentRow.Index > -1 Then
            If Me.dgRelaciones.Columns(e.ColumnIndex).Name = "Eliminar" Then
                correlativo = Me.dgRelaciones.Item("correlativo", Me.dgRelaciones.CurrentRow.Index).Value
                If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo Asociados") = MsgBoxResult.Yes Then
                    If asociados.eliminarAsocRelacionesAsociado(Me.dgRelaciones.Item("correlativo", Me.dgRelaciones.CurrentRow.Index).Value) > 0 Then
                        MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information, "Módulo - Asociados")
                        llenarDgRelaciones(txtDui.Text.Trim)
                    End If
                End If
            ElseIf Me.dgRelaciones.Columns(e.ColumnIndex).Name = "Modificar" Then
                Dim frm As New frmMsRelacionesAsoc
                With frm
                    .dui = txtDui.Text.Trim 'Me.dgRelaciones.Item("idPep", Me.dgRelaciones.CurrentRow.Index).Value
                    .txtDui.Value = Me.dgRelaciones.Item("duiRelacion", Me.dgRelaciones.CurrentRow.Index).Value
                    .correlativo = Me.dgRelaciones.Item("correlativo", Me.dgRelaciones.CurrentRow.Index).Value
                    .txtAsociado.Text = Me.dgRelaciones.Item("nombre", Me.dgRelaciones.CurrentRow.Index).Value
                    .llenarCbParentesco()
                    .accion = 2
                    .cbRelaciones.SelectedValue = Me.dgRelaciones.Item("CodParentesco", Me.dgRelaciones.CurrentRow.Index).Value
                    .ShowDialog(Me)
                End With
                llenarDgRelaciones(txtDui.Text.Trim)
            End If
        End If
    End Sub
    Protected Sub llenarDgRelaciones(ByVal dui As String)
        Try
            If Me.dgRelaciones.Rows.Count > 0 Then
                Me.dgRelaciones.Columns.Remove("modificar")
                Me.dgRelaciones.Columns.Remove("eliminar")
            End If
            Dim dts As New DataSet
            dts = asociados.consultarAsocRelacionesAsociado(dui)
            If dts.Tables.Count > 0 Then
                'If dts.Tables(0).Rows.Count > 0 Then
                Me.dgRelaciones.DataSource = dts.Tables(0)
                Dim btnColumnModificar As New DataGridViewButtonColumn
                With btnColumnModificar
                    .UseColumnTextForButtonValue = True
                    '.DefaultCellStyle.BackColor = Color.SteelBlue
                    .DefaultCellStyle.ForeColor = Color.Red
                    .Text = "Modificar"
                    .Name = "Modificar"
                    .HeaderText = "Modificar"
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                End With
                Me.dgRelaciones.Columns.Add(btnColumnModificar)


                Dim btnColumnEliminar As New DataGridViewButtonColumn
                With btnColumnEliminar

                    .UseColumnTextForButtonValue = True
                    '.DefaultCellStyle.BackColor = Color.SteelBlue
                    .DefaultCellStyle.ForeColor = Color.Red
                    .Text = "Eliminar"
                    .Name = "Eliminar"
                    .HeaderText = "Eliminar"
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
                End With
                Me.dgRelaciones.Columns.Add(btnColumnEliminar)
                estiloDgRelaciones()
                'End If
            End If
        Catch ex As Exception

        End Try
        
    End Sub
    Protected Sub estiloDgRelaciones()
        Me.dgRelaciones.ColumnHeadersDefaultCellStyle.BackColor = Color.OliveDrab
        Me.dgRelaciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgRelaciones.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        Me.dgRelaciones.Columns("duiRelacion").HeaderText = "DUI"
        Me.dgRelaciones.Columns("Descripcion").HeaderText = "Parentesco"


        Me.dgRelaciones.Columns("correlativo").Visible = False
        Me.dgRelaciones.Columns("dui").Visible = False
        Me.dgRelaciones.Columns("CodParentesco").Visible = False

        Me.dgRelaciones.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells


    End Sub
#End Region

    Private Sub txtIngresosPrim_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIngresosPrim.Leave
        txtTotalIngresosPrim.Value = txtIngresosPrim.Value + txtIngresosSec.Value + txtOtrosIngresos.Value
        txtTotalIngresosSec.Value = txtIngresosPrim.Value + txtIngresosSec.Value + txtOtrosIngresos.Value
    End Sub

    Private Sub txtIngresosSec_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIngresosSec.Leave
        txtTotalIngresosSec.Value = txtIngresosPrim.Value + txtIngresosSec.Value + txtOtrosIngresos.Value
        txtTotalIngresosPrim.Value = txtIngresosPrim.Value + txtIngresosSec.Value + txtOtrosIngresos.Value
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrimerApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrimerApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSegApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSegApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtConocidoPor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConocidoPor.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtApellidoCasada_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidoCasada.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDireccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtRepresentanteLegal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRepresentanteLegal.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDirPerJur_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDirPerJur.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
        End If
    End Sub
    Protected Sub habilitarCamposPerJuridica(ByVal habilitar As Boolean)
        If habilitar = False Then
            txtRazSocial.Enabled = False
            txtNomComercial.Enabled = False
            txtRepresentanteLegal.Enabled = False
            txtNoRegContribuyente.Enabled = False
            txtNitEmpresa.Enabled = False
            txtTelPerJur.Enabled = False
            cbDeptoPerJur.Enabled = False
            cbMunicipioJur.Enabled = False
            txtDirPerJur.Enabled = False
            btnJuntaDirectiva.Enabled = False

            txtRazSocial.Text = ""
            txtNomComercial.Text = ""
            txtRepresentanteLegal.Text = ""
            txtNoRegContribuyente.Text = ""
            txtNitEmpresa.Value = ""
            txtTelPerJur.Text = ""
            txtDirPerJur.Text = ""
            btnJuntaDirectiva.Enabled = False
        Else
            txtRazSocial.Enabled = True
            txtNomComercial.Enabled = True
            txtRepresentanteLegal.Enabled = True
            txtNoRegContribuyente.Enabled = True
            txtNitEmpresa.Enabled = True
            txtTelPerJur.Enabled = True
            cbDeptoPerJur.Enabled = True
            cbMunicipioJur.Enabled = True
            txtDirPerJur.Enabled = True
            btnJuntaDirectiva.Enabled = True

        End If
        

    End Sub
  
    Private Sub chkPersonaJuridica_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPersonaJuridica.Click
        habilitarCamposPerJuridica(chkPersonaJuridica.Checked)
    End Sub

    Private Sub lblNit_Click(sender As Object, e As EventArgs) Handles lblNit.Click

    End Sub

    Private Sub txtNit_TextChanged(sender As Object, e As EventArgs) Handles txtNit.TextChanged

    End Sub

    Private Sub lblIsss_Click(sender As Object, e As EventArgs) Handles lblIsss.Click

    End Sub

    Private Sub txtIsss_TextChanged(sender As Object, e As EventArgs) Handles txtIsss.TextChanged

    End Sub

    Private Sub txtNomComercial_TextChanged(sender As Object, e As EventArgs) Handles txtNomComercial.TextChanged

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub txtNoRegContribuyente_TextChanged(sender As Object, e As EventArgs) Handles txtNoRegContribuyente.TextChanged

    End Sub

    Private Sub Label51_Click(sender As Object, e As EventArgs) Handles Label51.Click

    End Sub

    Private Sub Label28_Click(sender As Object, e As EventArgs) Handles Label28.Click

    End Sub

    Private Sub txtDirOfi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDirOfi.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDirOfi2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDirOfi2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDestCta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDestCta.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtOriFondos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOriFondos.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
        End If
    End Sub
    Private Sub txtOrigenFondosDpf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOrigenFondosDpf.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPeriodoNombramiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPeriodoNombramiento.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtObservacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtObservacion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnRelAtras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelAtras.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub

    Private Sub btnRelSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelSig.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub

    Private Sub btnRptConCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptConCliente.Click
        Dim frm As New frmVisorRS
        If chkPersonaJuridica.Checked = True Then
            OpcionRS = 77
        Else
            OpcionRS = 78
        End If
        With frm
            .dui = txtDui.Value
            .ShowDialog(Me)
        End With
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim frm As New frmVisorRS
        OpcionRS = 80
        With frm
            .dui = txtDui.Value
            .ShowDialog(Me)
        End With
    End Sub


End Class