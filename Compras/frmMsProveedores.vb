Imports sifLib.Asociado

Public Class frmMsProveedores

    Dim vAccion As Integer '1= Insertar;2=Modificar;3=Consultar
    Dim vIdProveedor As Integer
    Dim contabilidad As New wrConta.wsLibContab
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim asoc As New clsAsociado
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property idProveedor() As Integer
        Get
            Return vIdProveedor
        End Get
        Set(ByVal value As Integer)
            vIdProveedor = value
        End Set
    End Property
    Public Sub llenarCbDepartamento(ByVal campos As String, ByVal filtro As String, ByVal orden As String)
        Dim dts As New DataSet
        dts = asociados.ConsultarDepartamentos(campos, filtro, orden, sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbDepartamento.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarTipoContribuyente()
        Dim dts As New DataSet

        dts = asociados.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.tipoContribuyente, wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbTipoContri.DataSource = dts.Tables(0)
            End If
        End If
    End Sub


    Public Sub llenarCbMunicipio(ByVal campos As String, ByVal filtro As String, ByVal orden As String)
        Dim dts As New DataSet
        dts = asociados.ConsultarMunicipios(campos, filtro, orden, sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbMunicipio.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
#Region "Eventos"
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
#End Region

    Private Sub frmMsProveedores_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.accion = 1 Then
            Me.cbTipoContri.ValueMember = "idCatalogo"
            Me.cbTipoContri.DisplayMember = "Descripcion"
            Me.cbDepartamento.ValueMember = "codDepartamento"
            Me.cbDepartamento.DisplayMember = "Departamento"
            Me.cbMunicipio.ValueMember = "codMunicipio"
            Me.cbMunicipio.DisplayMember = "Municipio"
            llenarCbDepartamento("codDepartamento,Departamento", "", "Departamento")
            llenarCbMunicipio("codMunicipio,Municipio", "CodDepartamento = '" & Me.cbDepartamento.SelectedValue & "'", "")
            llenarTipoContribuyente()
        End If
    End Sub

    'Private Sub cbDepartamento_DataSourceChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbDepartamento.DataSourceChanged
    '    llenarCbMunicipio("codMunicipio,Municipio", "CodDepartamento = '" & Me.cbDepartamento.SelectedValue & "'", "")

    'End Sub

    'Private Sub cbDepartamento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    llenarCbMunicipio("codMunicipio,Municipio", "CodDepartamento = '" & Me.cbDepartamento.SelectedValue & "'", "")
    'End Sub



    Private Sub cbDepartamento_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDepartamento.DropDownClosed
        llenarCbMunicipio("codMunicipio,Municipio", "CodDepartamento = '" & Me.cbDepartamento.SelectedValue & "'", "")
    End Sub

    Private Sub cbDepartamento_LostFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDepartamento.LostFocus
        llenarCbMunicipio("codMunicipio,Municipio", "CodDepartamento = '" & Me.cbDepartamento.SelectedValue & "'", "")
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If txtNoRegistro.Text.Trim = "" Then
                MsgBox("No. de registro no puede quedar vacio.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            If txtNit.Text.Trim = "" Then
                MsgBox("NIT no puede quedar vacio.", MsgBoxStyle.Critical)
                Exit Sub
            End If
            Dim resultado As Integer
            If Me.accion = 1 Then
                resultado = contabilidad.insertarCaProveedores(txtNoRegistro.Text.Trim, txtNit.Text.Trim,
                                                               txtDui.Text.Trim, txtProveedor.Text.Trim,
                                                               txtDireccion.Text.Trim, txtTelefono.Text.Trim,
                                                               txtEmail.Text, txtRepresentante.Text,
                                                               Me.cbDepartamento.SelectedValue, Me.cbMunicipio.SelectedValue, Me.cbTipoContri.SelectedValue)
                If resultado <> 0 Then
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Caja")
                Else
                    MsgBox("El registro no pudo ser ingresado por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Compras")
                End If
            ElseIf accion = 2 Then
                resultado = contabilidad.modificarCaProveedores(idProveedor, txtNoRegistro.Text.Trim, txtNit.Text.Trim,
                                                               txtDui.Text.Trim, txtProveedor.Text.Trim,
                                                               txtDireccion.Text.Trim, txtTelefono.Text.Trim,
                                                               txtEmail.Text, txtRepresentante.Text,
                                                               Me.cbDepartamento.SelectedValue, Me.cbMunicipio.SelectedValue, Me.cbTipoContri.SelectedValue)
                If resultado <> 0 Then
                    MsgBox("Registro actualizdo exitosamente", MsgBoxStyle.Information, "Módulo - Caja")
                Else
                    MsgBox("El registro no pudo ser actualizado por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Compras")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema." + ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class