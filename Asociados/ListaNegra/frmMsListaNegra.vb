Public Class frmMsListaNegra
    Dim vAccion As Integer
    Dim vIdLista As Integer
    Dim listaNegra As New wrAsociados.wsLibAsoc
    Public Sub llenarCbNacionalidades()
        Dim dts As New DataSet
        dts = listaNegra.ConsultarNacionalidades("CodNacionalidad,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbNacionalidad.DataSource = dts.Tables(0)
                Me.cbNacionalidad.DisplayMember = "Descripcion"
                Me.cbNacionalidad.ValueMember = "CodNacionalidad"
            End If
        End If
    End Sub
    Public Sub llenarCbEstado()
        Dim dts As New DataSet
        dts = listaNegra.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.estadoListaNegraInterna, wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbEstado.DataSource = dts.Tables(0)
                Me.cbEstado.DisplayMember = "Descripcion"
                Me.cbEstado.ValueMember = "idCatalogo"
            End If
        End If
    End Sub
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property idLista() As Integer
        Get
            Return vIdLista
        End Get
        Set(ByVal value As Integer)
            vIdLista = value
        End Set
    End Property

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) 

    End Sub

    Private Sub frmMsListaNegra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If accion = 1 Then
            llenarCbNacionalidades()
            llenarCbEstado()
        End If

    End Sub


    Private Sub lblNombreReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNombreReport.Click

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim resultado As Integer
            If accion = 1 Then
                resultado = listaNegra.insertarListaNegra(txtNomReport.Text.Trim.ToUpper,
                                                          Now, txtInstReporta.Text.Trim.ToUpper,
                                                          txtDuiA.Text.Trim,
                                                          txtNit.Text.Trim, txtNoPas.Text.Trim,
                                                          txtNoRes.Text.Trim, sUsuario, Now,
                                                          chkActivo.Checked, Me.cbNacionalidad.SelectedValue,
                                                          txtMotIngreso.Text.Trim, txtAlias.Text.Trim.ToUpper,
                                                          txtNoOficio.Text.Trim, txtRefOficio.Text.Trim.ToUpper,
                                                          txtInfComp.Text.Trim.ToUpper, cbEstado.SelectedValue)

            ElseIf accion = 2 Then
                resultado = listaNegra.modificartarListaNegra(txtNomReport.Text.Trim.ToUpper,
                                                          Now, txtInstReporta.Text.Trim.ToUpper,
                                                          txtDuiA.Text.Trim,
                                                          txtNit.Text.Trim, txtNoPas.Text.Trim,
                                                          txtNoRes.Text.Trim, sUsuario,
                                                          Now, chkActivo.Checked,
                                                          idLista, Me.cbNacionalidad.SelectedValue,
                                                          txtMotIngreso.Text, txtAlias.Text.Trim.ToUpper,
                                                          txtNoOficio.Text.Trim, txtRefOficio.Text.Trim.ToUpper,
                                                          txtInfComp.Text.Trim.ToUpper, cbEstado.SelectedValue)
            End If
            If resultado <> 0 Then
                MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Oficial de Cumplimiento")
            Else
                MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Oficial de Cumplimiento")
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Oficial de Cumplimiento")
        End Try
    End Sub

    Private Sub btnCerrar1_Click(sender As Object, e As EventArgs) Handles btnCerrar1.Click
        Me.Close()
    End Sub
End Class