Public Class frmMsBcCatCtasContablesCheques
    Dim Bancos As New wrBancos.wsLibBancos
    Dim Contabilidad As New wrConta.wsLibContab
    Dim Asociados As New wrAsociados.wsLibAsoc
    Dim usuarios As New wrAdmin.wsLibAdmin
    Public Accion As Integer '1=insertar,2=Modificar,3Consultar
    Public Id As Integer
#Region "Metodos"
    Public Sub LlenarCBSucursales(ByVal Campos As String, ByVal Filtro As String, ByVal Orden As String)
        Dim Dts As New DataSet
        Dts = Asociados.ConsultarSucursales(Campos, Filtro, Orden, sUsuario, sPassword, sSucursal)
        If Dts.Tables.Count > 0 Then
            If Dts.Tables(0).Rows.Count > 0 Then
                Me.cbSucursales.DataSource = Dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarCbRoles(ByVal campos As String, ByVal filtro As String, ByVal orden As String)
        Dim dts As New DataSet
        dts = usuarios.ConsultarRol(campos, filtro, orden, sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbRoles.DataSource = dts.Tables(0)
            End If
        End If

    End Sub
#End Region
#Region "Funciones"
    Private Function consultarCatalogoContable() As DataSet
        Dim dts As New DataSet
        dts = Contabilidad.ObtenerCatContab("IdCuenta,Descripcion", _
                                      "", "IdCuenta", sUsuario, sPassword, sSucursal)
        Return dts
    End Function
    Private Function Guardar(ByVal codSucursal As String, ByVal codRol As String, ByVal idcuenta As String, ByVal descripcion As String, _
                             ByVal fechaCreacion As DateTime, ByVal usuarioActu As String, ByVal fechaActu As DateTime) As Integer
        Dim resultado As Integer
        resultado = Bancos.insertarBcCatCtasContablesCheques(codSucursal, codRol, idcuenta, descripcion, fechaCreacion, usuarioActu, fechaActu)
        Return resultado
    End Function
    Private Function modificar(ByVal codSucursal As String, ByVal codRol As String, ByVal idcuenta As String, ByVal descripcion As String, _
                             ByVal fechaCreacion As DateTime, ByVal usuarioActu As String, ByVal fechaActu As DateTime, ByVal idctascontcheques As Integer) As Integer
        Dim resultado As Integer
        resultado = Bancos.modificarBcCatCtasContablesCheques(codSucursal, codRol, idcuenta, descripcion, _
                                                              fechaCreacion, usuarioActu, fechaActu, _
                                                              idctascontcheques)
        Return resultado
    End Function
#End Region
#Region "Eventos"

    Private Sub txtCodCtaContable_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCtaContable.Click
        Dim ofrm As New frmAGenerico
        Dim Dts As New DataSet
        ofrm.Text = "Catalogo Cuentas Contables."
        Dts = consultarCatalogoContable()
        ofrm.Datos = Dts
        ofrm.ColSeleccion = 0
        ofrm.RefrescarGrid()
        ofrm.ShowDialog()
        Me.txtCodCtaContable.Text = ofrm.Resultado.ToString
        Me.txtDescCtaContable.Text = ofrm.Resultado2.ToString
    End Sub
   
    Private Sub frmMsBcCatCtasContablesCheques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Accion = 1 Then
            Me.cbSucursales.DisplayMember = "nom_sucursal"
            Me.cbSucursales.ValueMember = "codsucursal"
            Me.cbRoles.DisplayMember = "descripcion"
            Me.cbRoles.ValueMember = "codrol"
            llenarCbRoles("codRol,Descripcion", "", "descripcion")
            LlenarCBSucursales("codSucursal,Nom_Sucursal", "", "Nom_Sucursal")

        End If


    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If Accion = 1 Then
                If Guardar(Me.cbSucursales.SelectedValue, Me.cbRoles.SelectedValue, Me.txtCodCtaContable.Text.Trim, _
                         Me.txtDescCtaContable.Text.Trim, Format(Now, "Short Date"), sUsuario, Format(Now, "Short Date")) <> 0 Then
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo Contabilidad")
                End If
            ElseIf Accion = 2 Then
                If modificar(Me.cbSucursales.SelectedValue, Me.cbRoles.SelectedValue, Me.txtCodCtaContable.Text.Trim, _
                     Me.txtDescCtaContable.Text.Trim, Format(Now, "Short Date"), sUsuario, Now, _
                     Id) <> 0 Then
                    MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information, "Módulo Contabilidad")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error, por favor comunicarse con el administrador del sistema." + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo Contabilidad")
        End Try


    End Sub
#End Region




    
    Private Sub txtCodCtaContable_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCtaContable.Enter
        Dim ofrm As New frmAGenerico
        Dim Dts As New DataSet
        ofrm.Text = "Catalogo Cuentas Contables."
        Dts = consultarCatalogoContable()
        ofrm.Datos = Dts
        ofrm.ColSeleccion = 0
        ofrm.RefrescarGrid()
        ofrm.ShowDialog()
        Me.txtCodCtaContable.Text = ofrm.Resultado.ToString
        Me.txtDescCtaContable.Text = ofrm.Resultado2.ToString
    End Sub
End Class