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

                If resultado <> 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If

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
                If resultado <> 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeUpdateRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                Else
                    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If

            End If


            Me.Close()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Source.ToString, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar1_Click(sender As Object, e As EventArgs) Handles btnCerrar1.Click
        Me.Close()
    End Sub

    Private Sub frmMsListaNegra_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class