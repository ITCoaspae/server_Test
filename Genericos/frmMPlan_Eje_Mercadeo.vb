Public Class frmMPlan_Eje_Mercadeo
    Private Prestamos As New wrPrestamo.wsLibPrest
    Private Planilla As New wrPlanilla.wsLibPlanilla
    Private Asociados As New wrAsociados.wsLibAsoc
    Public Sub LlenarSucursales()
        Dim Dts As New DataSet
        Dts = Planilla.Consultar_Sucursales()
        Me.cbSucursal.DataSource = Dts.Tables(0)
    End Sub
    Public Sub LlenarEjecutivos(ByVal Opcion As Integer, ByVal CodSucursal As String)
        Dim Dts As New DataSet
        Dts = Asociados.Consultar_EjecutivosMercadeo(Opcion, CodSucursal)
        Me.cbEjecutivos.DataSource = Dts.Tables(0)
    End Sub
    Private Sub EstiloDg()

        Me.dgPlanificacion.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgPlanificacion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgPlanificacion.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgPlanificacion.Columns("CodSucursal").Visible = False
        Me.dgPlanificacion.Columns("CodEjecMercadeo").Visible = False
        Me.dgPlanificacion.Columns("IdTipo_Planificacion").Visible = False
        Me.dgPlanificacion.Columns("idPlan_Merca").Visible = False

        Me.dgPlanificacion.Columns("Nom_Sucursal").HeaderText = "Sucursal"
        Me.dgPlanificacion.Columns("Annio").HeaderText = "Año"
        Me.dgPlanificacion.Columns("TIPOPLANIFICACION").HeaderText = "Rubro"

        Me.dgPlanificacion.Columns("Nom_Sucursal").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanificacion.Columns("TIPOPLANIFICACION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanificacion.Columns("Annio").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanificacion.Columns("Mes").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanificacion.Columns("Ejecutivo").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells


    End Sub
    Private Sub llenarDg(ByVal opcion As Integer, ByVal mes As Integer, ByVal annio As Integer,
                         ByVal CodEjecMercadeo As String, ByVal CodSucursal As String)
        Dim Dts As New DataSet
        Dts = Prestamos.Consultar_Ejec_Planificacion_Mensual(opcion, mes, annio, CodEjecMercadeo, CodSucursal)
        Me.dgPlanificacion.DataSource = Dts.Tables(0)
    End Sub

    Private Sub frmMPlan_Eje_Mercadeo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.nudAnios.Value = Now.Year
        Me.nudMes.Value = Now.Month
        Me.chkMes.Enabled = False
        Me.chkEjecutivo.Enabled = False
        Me.chkSucursal.Enabled = False
        llenarDg(2, Now.Month, Now.Year, " ", " ")
        Me.cbSucursal.DisplayMember = "NOM_SUCURSAL"
        Me.cbSucursal.ValueMember = "CODSUCURSAL"
        Me.cbEjecutivos.DisplayMember = "EJECUTIVO"
        Me.cbEjecutivos.ValueMember = "CODEJECMERCADEO"
        LlenarSucursales()
        LlenarEjecutivos(5, Me.cbSucursal.SelectedValue)
        EstiloDg()
    End Sub

    Private Sub chkAnio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAnio.CheckedChanged
        If Me.chkAnio.Checked = True Then
            Me.chkMes.Enabled = True
        Else
            chkMes.Enabled = False
        End If
    End Sub

    Private Sub chkMes_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkMes.CheckedChanged
        If Me.chkMes.Checked = True Then
            Me.chkSucursal.Enabled = True
        Else
            chkEjecutivo.Enabled = False
        End If
    End Sub

    Private Sub chkSucursal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSucursal.CheckedChanged
        If Me.chkSucursal.Checked = True Then
            Me.chkEjecutivo.Enabled = True
        Else
            chkEjecutivo.Enabled = False
        End If
    End Sub

    Private Sub cbSucursal_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSucursal.DropDownClosed
        LlenarEjecutivos(5, Me.cbSucursal.SelectedValue)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If Me.chkAnio.Checked = True And Me.chkMes.Checked = False And Me.chkEjecutivo.Checked = False And chkSucursal.Checked = False Then
                llenarDg(1, 0, nudAnios.Value, "", "")
            ElseIf Me.chkAnio.Checked = True And Me.chkMes.Checked = True And Me.chkEjecutivo.Checked = False And chkSucursal.Checked = False Then
                llenarDg(2, nudMes.Value, nudAnios.Value, "", "")
            ElseIf Me.chkAnio.Checked = True And Me.chkMes.Checked = True And Me.chkEjecutivo.Checked = False And chkSucursal.Checked = True Then
                llenarDg(4, nudMes.Value, nudAnios.Value, "", Me.cbSucursal.SelectedValue)
            ElseIf Me.chkAnio.Checked = True And Me.chkMes.Checked = True And Me.chkEjecutivo.Checked = True And chkSucursal.Checked = True Then
                llenarDg(3, nudMes.Value, nudAnios.Value, Me.cbEjecutivos.SelectedValue, "")
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim form As New frmMsPlan_Eje_Mercadeo
            form.Accion = 1
            form.ShowDialog()
            llenarDg(2, Now.Month, Now.Year, " ", "")
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            If Me.dgPlanificacion.CurrentRow.Index <> -1 Then
                Dim form As New frmMsPlan_Eje_Mercadeo
                form.Accion = 2
                form.cbSucursal.DisplayMember = "NOM_SUCURSAL"
                form.cbSucursal.ValueMember = "CODSUCURSAL"
                form.cbEjecutivo.DisplayMember = "EJECUTIVO"
                form.cbEjecutivo.ValueMember = "CODEJECMERCADEO"
                form.cbRubro.DisplayMember = "Descripcion"
                form.cbRubro.ValueMember = "IdTipo_Planificacion"
                form.LlenarSucursales()
                form.LlenarEjecutivos(5, Me.dgPlanificacion.Item("CodSucursal", Me.dgPlanificacion.CurrentRow.Index).Value.ToString)
                form.LlenarRubrosPlanificacion(1, 1)
                form.IdPlan_Merca = Me.dgPlanificacion.Item("idPlan_Merca", Me.dgPlanificacion.CurrentRow.Index).Value
                form.cbSucursal.SelectedValue = Me.dgPlanificacion.Item("CodSucursal", Me.dgPlanificacion.CurrentRow.Index).Value.ToString
                form.cbEjecutivo.SelectedValue = Me.dgPlanificacion.Item("CODEJECMERCADEO", Me.dgPlanificacion.CurrentRow.Index).Value.ToString
                form.cbRubro.SelectedValue = Me.dgPlanificacion.Item("IdTipo_Planificacion", Me.dgPlanificacion.CurrentRow.Index).Value.ToString
                form.nudAnios.Value = Me.dgPlanificacion.Item("Annio", Me.dgPlanificacion.CurrentRow.Index).Value.ToString
                form.nudMes.Value = Me.dgPlanificacion.Item("Mes", Me.dgPlanificacion.CurrentRow.Index).Value.ToString
                form.txtCantidad.Text = Me.dgPlanificacion.Item("Cantidad", Me.dgPlanificacion.CurrentRow.Index).Value.ToString
                form.txtMonto.Text = Me.dgPlanificacion.Item("Monto", Me.dgPlanificacion.CurrentRow.Index).Value.ToString
                form.ShowDialog()
                llenarDg(2, Now.Month, Now.Year, " ", " ")
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If Me.dgPlanificacion.CurrentRow.Index <> -1 Then
                If MsgBox("¿Desea eliminar este registro?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim resultado As Integer
                    resultado = Prestamos.Eliminar_Ejec_Planificacion_Mensual(Me.dgPlanificacion.Item("idPlan_Merca", Me.dgPlanificacion.CurrentRow.Index).Value.ToString)
                    If resultado <> 0 Then
                        MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information)
                        llenarDg(2, Now.Month, Now.Year, " ", " ")
                    Else
                        MsgBox("El registro no pudo ser eliminado.", MsgBoxStyle.Information)

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            Dim Ofrm As New frmVisorRS
            OpcionRS = 28
            Ofrm.ShowDialog()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class