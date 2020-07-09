Public Class frmMsCorrelativosDocumentsoCaja
    Dim caja As New wrCaja.wsLibCaja
    Dim Seguridad As New wrAdmin.wsLibAdmin
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim vAccion As Integer ' 1=Insertar;2=Modificar;3=Consultar
    Dim vIdCorrCaja As Integer
#Region "Propiedades"
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property idCorrCaja() As Integer
        Get
            Return vIdCorrCaja
        End Get
        Set(ByVal value As Integer)
            vIdCorrCaja = value
        End Set
    End Property
#End Region
#Region "Funciones"
    Protected Function GuardarCorrelativosCaja(ByVal codSucursal As String, ByVal noCaja As Integer, _
                                               ByVal idTipoDoc As Integer, ByVal min As Integer, _
                                               ByVal max As Integer, ByVal correlativo As Integer) As Integer
        Dim resultado As Integer
        resultado = caja.insertarCaCorrelativoCaja(codSucursal, noCaja, idTipoDoc, min, max, correlativo)
        Return resultado
    End Function
    Protected Function ModificarCorrelativosCaja(ByVal codSucursal As String, ByVal codCajero As Integer, _
                                               ByVal idTipoDoc As Integer, ByVal min As Integer, _
                                               ByVal max As Integer, ByVal correlativo As Integer, _
                                               ByVal idCorrCaja As Integer) As Integer
        Dim resultado As Integer
        resultado = caja.modificarCaCorrelativoCaja(codSucursal, codCajero, idTipoDoc, min, max, correlativo, idCorrCaja)
        Return resultado
    End Function
#End Region
#Region "Metodos"
    Public Sub LlenarCbSucursales(ByVal Campos, ByVal Filtro, ByVal Orden, ByVal sUsuario, ByVal sPassword, ByVal sSucursal)
        Dim Dts As New DataSet
        Dts = asociados.ConsultarSucursales(Campos, Filtro, Orden, sUsuario, sPassword, sSucursal)
        If Dts.Tables.Count > 0 Then
            If Dts.Tables(0).Rows.Count > 0 Then
                Me.cbSucursal.DataSource = Dts.Tables(0)
            End If
        End If

    End Sub
    Public Sub llenarCajero(ByVal campos As String, ByVal filtros As String, ByVal orden As String)
        Dim Dts As New DataSet
        Dts = caja.ConsultarCajas(campos, filtros, orden, sUsuario, sPassword, sSucursal)

        If Dts.Tables.Count > 0 Then
            If Dts.Tables(0).Rows.Count > 0 Then
                Me.cbCajero.DataSource = Dts.Tables(0)
            End If
        End If

    End Sub
    Public Sub llenarCbDocumentos(ByVal activo As Boolean, ByVal idtipoDoc As Integer, ByVal opcion As Integer)
        Dim Dts As New DataSet
        Dts = caja.consultarCaMaestrosTipoDocumentos(opcion, activo, idtipoDoc)
        If Dts.Tables.Count > 0 Then
            If Dts.Tables(0).Rows.Count > 0 Then
                Me.cbDocumento.DataSource = Dts.Tables(0)
            End If
        End If


    End Sub
    Protected Sub limpiar()
        Me.txtMinimo.Text = ""
        Me.txtMaximo.Text = ""
        Me.txtCorrIni.Text = ""
    End Sub
#End Region
#Region "Eventos"
    Private Sub frmMsCorrelativosDocumentsoCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



        If vAccion = 1 Then
            Dim dtsRoles As New DataSet
            dtsRoles = Seguridad.ConsultarRolesUsuario(sUsuario, "", 2)
            For I As Integer = 0 To dtsRoles.Tables(0).Rows.Count - 1
                If Seguridad.ConsultarPermisoProcesos("CAL001", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                    LlenarCbSucursales("CodSucursal,Nom_Sucursal", "codSucursal = '" & sSucursal & "'", "Nom_Sucursal", sUsuario, sPassword, sSucursal)
                    Exit For
                ElseIf Seguridad.ConsultarPermisoProcesos("CAL004", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                    LlenarCbSucursales("CodSucursal,Nom_Sucursal", "", "Nom_Sucursal", sUsuario, sPassword, sSucursal)
                    Exit For
                End If
            Next
            Me.cbCajero.DisplayMember = "noCaja"
            Me.cbCajero.ValueMember = "noCaja"
            Me.cbSucursal.DisplayMember = "Nom_Sucursal"
            Me.cbSucursal.ValueMember = "CodSucursal"
            Me.cbDocumento.DisplayMember = "tipoDocumento"
            Me.cbDocumento.ValueMember = "idTipoDoc"
            '  LlenarCbSucursales("Nom_Sucursal,CodSucursal", "", "Nom_Sucursal", sUsuario, sPassword, sSucursal)
            llenarCajero("noCaja", "CodSucursal = '" & Me.cbSucursal.SelectedValue & "'", "")
            llenarCbDocumentos(True, 0, 1)
        End If
    End Sub

    Private Sub cbSucursal_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSucursal.DropDownClosed
        llenarCajero("noCaja", "CodSucursal = '" & Me.cbSucursal.SelectedValue & "'", "")
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If vAccion = 1 Then
                If GuardarCorrelativosCaja(Me.cbSucursal.SelectedValue, Me.cbCajero.SelectedValue,
                                        Me.cbDocumento.SelectedValue, Me.txtMinimo.Text,
                                        Me.txtMaximo.Text, Me.txtCorrIni.Text) <> 0 Then
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Caja")
                Else
                    MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Caja")
                End If
            ElseIf vAccion = 2 Then
                If ModificarCorrelativosCaja(Me.cbSucursal.SelectedValue, Me.cbCajero.SelectedValue,
                                                    Me.cbDocumento.SelectedValue, Me.txtMinimo.Text,
                                                    Me.txtMaximo.Text, Me.txtCorrIni.Text, vIdCorrCaja) <> 0 Then
                    MsgBox("Registro modificado exitosamente.", MsgBoxStyle.Information, "Módulo - Caja")
                Else
                    MsgBox("El registro no pudo ser modificado, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Caja")
                End If
            End If
            limpiar()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

End Class