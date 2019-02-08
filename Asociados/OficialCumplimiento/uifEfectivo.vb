Imports MetroFramework

Public Class uifEfectivo
    Dim asociados As New wrAsociados.wsLibAsoc
    Private dui As String
#Region "Propiedades"
    Public Property duip() As String
        Get
            Return Me.dui
        End Get
        Set(ByVal Value As String)
            Me.dui = Value
        End Set
    End Property
#End Region
#Region "Tab 1"
    Private Sub llenarDomicilio(dui As String)

    End Sub
    Private Sub llenarDepartamentoSeccionBNat()
        Dim dts As New DataSet
        dts = asociados.ConsultarDepartamentos("CodDepartamento,Departamento", "", "Departamento", sUsuario, sPassword, sSucursal)
        Me.cbDeptoNomb.DataSource = dts.Tables(0)
        Me.cbDeptoNomb.DisplayMember = "Departamento"
        Me.cbDeptoNomb.ValueMember = "CodDepartamento"
    End Sub
    Private Sub cbDeptoNomb_Validated(sender As Object, e As EventArgs) Handles cbDeptoNomb.Validated
        Dim dts As New DataSet
        dts = asociados.ConsultarMunicipios("codMunicipio,Municipio", " codDepartamento = '" & Me.cbDeptoNomb.SelectedValue & "' ", "Municipio", sUsuario, sPassword, sSucursal)
        Me.cbMunNomb.DataSource = dts.Tables(0)
        Me.cbMunNomb.DisplayMember = "Municipio"
        Me.cbMunNomb.ValueMember = "codMunicipio"
    End Sub

    Private Sub llenarNacionalidadSeccionBNat()
        Try
            Dim dts As New DataSet
            dts = asociados.ConsultarNacionalidades("Nacionalidad,codNacionalidad", "", "Nacionalidad", sUsuario, sPassword, sSucursal)
            Me.cbNacionalidadNomb.DataSource = dts.Tables(0)
            Me.cbNacionalidadNomb.DisplayMember = "Nacionalidad"
            Me.cbNacionalidadNomb.ValueMember = "codNacionalidad"
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error en la recuperación de datos (Sucursales)", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub
    Private Sub llenarEstadoCivilSeccionBNat()
        Dim dts As New DataSet
        Me.cbEstadoCivilNomb.DisplayMember = "Descripcion"
        Me.cbEstadoCivilNomb.ValueMember = "idCatalogo"
        dts = asociados.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.estadoCivil,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbEstadoCivilNomb.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Private Sub llenarProfesionSeccionBNat()
        Me.cbProfesionNomb.DisplayMember = "Descripcion"
        Me.cbProfesionNomb.ValueMember = "codProfesion"
        Dim dts As New DataSet
        dts = asociados.ConsultarProfesiones("codProfesion,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbProfesionNomb.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
#End Region
#Region "Tab 0"

    ''' <summary>
    ''' 
    ''' </summary>
    Private Sub llenarDepartamentoSeccionA()
        Dim dts As New DataSet
        dts = asociados.ConsultarDepartamentos("CodDepartamento,Departamento", "", "Departamento", sUsuario, sPassword, sSucursal)
        Me.cbDepartamentoInv.DataSource = dts.Tables(0)
        Me.cbDepartamentoInv.DisplayMember = "Departamento"
        Me.cbDepartamentoInv.ValueMember = "CodDepartamento"
    End Sub
    Private Sub cbDepartamentoInv_Validated(sender As Object, e As EventArgs) Handles cbDepartamentoInv.Validated
        Dim dts As New DataSet
        dts = asociados.ConsultarMunicipios("codMunicipio,Municipio", " codDepartamento = '" & Me.cbDepartamentoInv.SelectedValue & "' ", "Municipio", sUsuario, sPassword, sSucursal)
        Me.cbMunicipioInv.DataSource = dts.Tables(0)
        Me.cbMunicipioInv.DisplayMember = "Municipio"
        Me.cbMunicipioInv.ValueMember = "codMunicipio"
    End Sub
    Private Sub llenarNacionalidadSeccionA()
        Try
            Dim dts As New DataSet
            dts = asociados.ConsultarNacionalidades("Nacionalidad,codNacionalidad", "", "Nacionalidad", sUsuario, sPassword, sSucursal)
            Me.cbNacionalidadInv.DataSource = dts.Tables(0)
            Me.cbNacionalidadInv.DisplayMember = "Nacionalidad"
            Me.cbNacionalidadInv.ValueMember = "codNacionalidad"
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error en la recuperación de datos (Sucursales)", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub
    Private Sub llenarEstadoCivilSeccionA()
        Dim dts As New DataSet
        Me.cbEstadoFamInv.DisplayMember = "Descripcion"
        Me.cbEstadoFamInv.ValueMember = "idCatalogo"
        dts = asociados.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.estadoCivil,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbEstadoFamInv.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Private Sub llenarProfesionSeccionA()
        Me.cbProfesionInv.DisplayMember = "Descripcion"
        Me.cbProfesionInv.ValueMember = "codProfesion"
        Dim dts As New DataSet
        dts = asociados.ConsultarProfesiones("codProfesion,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbProfesionInv.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Private Sub llenarDatosAsoc()
        Dim dts As New DataSet
        dts = asociados.consultarCat_Asociados("04308147-7")
        If dts.Tables(0).Rows.Count > 0 Then
            txtNombresInv.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Nombres")), " ", dts.Tables(0).Rows(0).Item("Nombres")).ToString.ToUpper
            txtApeliidosInv.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellido1")), " ", dts.Tables(0).Rows(0).Item("apellido1")).ToString.ToUpper + " " + IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellido2")), " ", dts.Tables(0).Rows(0).Item("apellido2")).ToString.ToUpper
            txtApellidoCasInv.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellidocas")), " ", dts.Tables(0).Rows(0).Item("apellidocas")).ToString.ToUpper
            dtpNacInv.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Fecha_Nac")), Now, dts.Tables(0).Rows(0).Item("Fecha_Nac"))
            cbNacionalidadInv.SelectedValue = dts.Tables(0).Rows(0).Item("codNacionalidad")
            cbEstadoFamInv.SelectedValue = dts.Tables(0).Rows(0).Item("codEstadoCivil")
            cbProfesionInv.SelectedValue = dts.Tables(0).Rows(0).Item("codProfesion")
            ' SECCION B
            txtNombresNomb.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Nombres")), " ", dts.Tables(0).Rows(0).Item("Nombres")).ToString.ToUpper
            txtApellidosNom.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellido1")), " ", dts.Tables(0).Rows(0).Item("apellido1")).ToString.ToUpper + " " + IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellido2")), " ", dts.Tables(0).Rows(0).Item("apellido2")).ToString.ToUpper
            txtApellidoCasNom.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("apellidocas")), " ", dts.Tables(0).Rows(0).Item("apellidocas")).ToString.ToUpper
            dtpNacimientoNomb.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("Fecha_Nac")), Now, dts.Tables(0).Rows(0).Item("Fecha_Nac"))
            cbNacionalidadNomb.SelectedValue = dts.Tables(0).Rows(0).Item("codNacionalidad")
            cbEstadoCivilNomb.SelectedValue = dts.Tables(0).Rows(0).Item("codEstadoCivil")
            cbProfesionNomb.SelectedValue = dts.Tables(0).Rows(0).Item("codProfesion")
        End If
    End Sub
    Private Sub uifEfectivo_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' sección a persona natural
        llenarDepartamentoSeccionA()
        llenarNacionalidadSeccionA()
        llenarEstadoCivilSeccionA()
        llenarProfesionSeccionA()
        Dim dtsDomicilioA As New DataSet
        dtsDomicilioA = asociados.ConsultarDomicilios("04308147-7")
        If dtsDomicilioA.Tables(0).Rows.Count > 0 Then
            cbDeptoNomb.SelectedValue = dtsDomicilioA.Tables(0).Rows(0).Item("CodDepartamento")
            Me.cbDeptoNomb_Validated(sender, e)
            cbMunNomb.SelectedValue = dtsDomicilioA.Tables(0).Rows(0).Item("codMunicipio")
            txtDireccionInv.Text = dtsDomicilioA.Tables(0).Rows(0).Item("Direccion")
        End If
        ' seccion b persona natural 
        llenarDepartamentoSeccionBNat()
        llenarNacionalidadSeccionBNat()
        llenarEstadoCivilSeccionBNat()
        llenarProfesionSeccionBNat()

        llenarDatosAsoc()
    End Sub
#End Region


    Dim ingreso As Boolean
    Dim esEfectivo As Boolean
    Private Sub btnSaveObligado_Click(sender As Object, e As EventArgs) Handles btnSaveObligado.Click
        asociados.ingresarFormularioUIF(chkDistCliente.Checked, txtApeliidosInv.Text.Trim,
                                        txtApellidoCasInv.Text.Trim, txtNombresInv.Text.Trim,
                                        cbMunicipioInv.SelectedValue, cbDepartamentoInv.SelectedValue,
                                        dtpNacInv.Value.ToShortDateString, cbNacionalidadInv.SelectedValue,
                                        cbEstadoFamInv.SelectedValue, cbTipoDocInv.SelectedValue,
                                        txtNoDocInv.Text.Trim, cbProfesionInv.SelectedValue,
                                        txtDireccionInv.Text.Trim, chkPerJur.Checked,
                                        txtApellidosNom.Text.Trim, txtApellidoCasNom.Text.Trim,
                                        txtNombresNomb.Text.Trim, cbMunNomb.SelectedValue,
                                        cbDeptoNomb.SelectedValue, cbEstadoCivilNomb.SelectedValue,
                                        cbTipoDocNomb.SelectedValue, txtNoDocNomb.Text.Trim,
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


End Class