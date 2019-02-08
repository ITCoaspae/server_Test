Public Class frmMsPlan_Eje_Mercadeo
    Public Accion As Integer '1=INSERTAR, 2= MODIFICAR, 3 = CONSULTAR
    Public IdPlan_Merca As Integer
    Private Planilla As New wrPlanilla.wsLibPlanilla
    Private Asociados As New wrAsociados.wsLibAsoc
    Private Prestamos As New wrPrestamo.wsLibPrest
    Public Sub LlenarSucursales()
        Dim Dts As New DataSet
        Dts = Planilla.Consultar_Sucursales()
        Me.cbSucursal.DataSource = Dts.Tables(0)
    End Sub
    Public Sub LlenarEjecutivos(ByVal Opcion As Integer, ByVal CodSucursal As String)
        Dim Dts As New DataSet
        Dts = Asociados.Consultar_EjecutivosMercadeo(Opcion, CodSucursal)
        Me.cbEjecutivo.DataSource = Dts.Tables(0)
    End Sub
    Public Sub LlenarRubrosPlanificacion(ByVal Opcion As Integer, ByVal IdTipo_Planificacion As Integer)
        Dim Dts As New DataSet
        Dts = Prestamos.Consultar_Ejec_Cat_Tipo_Planificacion(Opcion, IdTipo_Planificacion)
        Me.cbRubro.DataSource = Dts.Tables(0)
    End Sub
    Private Sub frmMsPlan_Eje_Mercadeo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Accion = 1 Then
            Me.nudAnios.Value = Now.Year
            Me.nudMes.Value = Now.Month
            Me.cbSucursal.DisplayMember = "NOM_SUCURSAL"
            Me.cbSucursal.ValueMember = "CODSUCURSAL"
            Me.cbEjecutivo.DisplayMember = "EJECUTIVO"
            Me.cbEjecutivo.ValueMember = "CODEJECMERCADEO"
            Me.cbRubro.DisplayMember = "Descripcion"
            Me.cbRubro.ValueMember = "IdTipo_Planificacion"
            LlenarSucursales()
            LlenarEjecutivos(5, Me.cbSucursal.SelectedValue)
            LlenarRubrosPlanificacion(1, 1)
        ElseIf Accion = 2 Then 'Modificar
            Me.btnGuardar1.Text = "Modificar"
        End If
    End Sub
    Protected Sub Limpiar()

        Me.txtMonto.Text = ""
        Me.txtCantidad.Text = ""
    End Sub

    Private Sub cbSucursal_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSucursal.DropDownClosed
        LlenarEjecutivos(5, Me.cbSucursal.SelectedValue)
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            'validamos que la planificacion no haya sido ingresada.


            Dim Resultado As Integer
            If Accion = 1 Then 'Insertar
                'Dim Dts As New DataSet
                'Dts = Prestamos.Consultar_Ejec_Planificacion_Mensual(3, nudMes.Value, nudAnios.Value, Me.cbEjecutivo.SelectedValue, " ")
                'If Dts.Tables(0).Rows.Count > 0 Then
                '    MsgBox("No se pueden ingresar registros duplicados", MsgBoxStyle.Critical)
                'Else
                Resultado = Prestamos.Insertar_Ejec_Planificacion_Mensual(Me.cbEjecutivo.SelectedValue, Me.nudAnios.Value,
                                                                          nudMes.Value, IIf(Me.txtMonto.Text.Length = 0, 0, Me.txtMonto.Text),
                                                                          IIf(Me.txtCantidad.Text.Length = 0, 0, Me.txtCantidad.Text),
                                                                          cbRubro.SelectedValue)
                If Resultado > 0 Then
                    Limpiar()
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "")
                Else
                    MsgBox("No se pudo ingresar el registro", MsgBoxStyle.Critical, "")
                End If
                'End If
            ElseIf Accion = 2 Then 'Modificar
                Resultado = Prestamos.Modificar_Ejec_Planificacion_Mensual(Me.cbEjecutivo.SelectedValue, Me.nudAnios.Value,
                                                                       nudMes.Value, Me.txtMonto.Text, Me.txtCantidad.Text,
                                                                      cbRubro.SelectedValue, IdPlan_Merca)
                If Resultado > 0 Then
                    Limpiar()
                    MsgBox("Registro modificado exitosamente", MsgBoxStyle.Information, "")
                Else
                    MsgBox("No se pudo ingresar el registro", MsgBoxStyle.Critical, "")
                End If
            End If

        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try

    End Sub
End Class