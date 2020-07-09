Imports System.Data
Imports CrystalDecisions.Windows.Forms
Imports CrystalDecisions.CrystalReports.Engine
Public Class wfRPT_PLANILLA
    Public FECHAI As DateTime
    Public FECHAF As DateTime
    Dim PLANILLA As New wrPlanilla.wsLibPlanilla

    Private Sub wfRPT_PLANILLA_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.cbAreas.DisplayMember = "DESCRIPCION"
            Me.cbAreas.ValueMember = "CODAREA"
            Me.cbDepartamento.DisplayMember = "DESCRIPCION"
            Me.cbDepartamento.ValueMember = "CODDEPARTAMENTO"
            Me.txtCodPlanilla.Enabled = False
            Me.dtpFechaInicio.Enabled = False
            Me.dtpFechaFin.Enabled = False
            Me.CargarAreas()
        Catch ex As Exception
            MsgBox("Error, por favor comuniquese con el administrador del sistema." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
        End Try
       
    End Sub
    Public Function LLENAR_PLANILLA_XSUCURSAL(ByVal CODSUCURSAL As String, ByVal CODPLANILLA As Integer) As DataSet
        Dim DTS As New DataSet
        DTS = PLANILLA.RPT_PLAN_SUCURSAL(CODPLANILLA, CODSUCURSAL)
        Return DTS
    End Function
#Region "Cargar Combobox"
    Protected Sub CargarAreas()
        Dim Dts As New DataSet
        Dts = PLANILLA.Consultar_PlAreas(sUsuario, sPassword, sSucursal, 1, "")
        Me.cbAreas.DataSource = Dts.Tables(0)
    End Sub
    Protected Sub cargarDepartamento(ByVal codarea As String)
        Dim dts As New DataSet
        dts = PLANILLA.CONSULTAR_PLDEPARTAMENTOS(sUsuario, sPassword, sSucursal, 1, codarea, "", "")
        Me.cbDepartamento.DataSource = dts.Tables(0)
    End Sub
#End Region
    Public Sub LlenarPlanilla(ByVal CodPlanilla As Integer, ByVal Opcion As Integer, ByVal CodArea As String, ByVal CodDepartamento As String)
        Dim Dts As New DataSet

        If txtTipoPlanilla.Text = "1" Then
            Dim Rpt As New rpt_PlanillaSalarios
            Dim Fecha_Inicio As DateTime = Format(Me.dtpFechaInicio.Value, "SHORT DATE")
            Dim Fecha_Fin As DateTime = Format(Me.dtpFechaFin.Value, "SHORT DATE")
            Dts.EnforceConstraints = False
            Dim text As TextObject
            Dim MINI As String
            Dim MFIN As String
            Dim AÑOINI, AÑOFIN As String
            Dim NMESINI, NMESFIN As Integer
            NMESINI = Month(Fecha_Inicio)
            NMESFIN = Month(Fecha_Fin)
            AÑOINI = Year(Fecha_Inicio)
            AÑOFIN = Year(Fecha_Fin)
            MINI = MonthName(NMESINI)
            MFIN = MonthName(NMESFIN)
            text = Rpt.Section1.ReportObjects("txtPERIODO")
            text.Text = UCase("DEL " & Fecha_Inicio.Day.ToString & " de " & MINI & " de " & AÑOINI.ToString &
            " al " & Fecha_Fin.Day & " de " & MFIN & " de " & AÑOFIN.ToString)
            Dts = PLANILLA.Rpt_Planilla(CodPlanilla, Opcion, CodArea, CodDepartamento)
            Rpt.SetDataSource(Dts.Tables(0))
            Me.crPLANGENERAL.ReportSource = Rpt
        ElseIf txtTipoPlanilla.Text = "2" Then
            Dim rpt As New crPlanillaBonificacion
            Dts = PLANILLA.Rpt_PlanillaBonificacion(CodPlanilla)
            rpt.SetDataSource(Dts.Tables(0))
            Me.crPLANGENERAL.ReportSource = rpt
        ElseIf txtTipoPlanilla.Text = "3" Then
            Dim rpt As New crPLanillaComisiones
            Dts = PLANILLA.Rpt_PlanillaComisiones(CodPlanilla)
            rpt.SetDataSource(Dts.Tables(0))
            Me.crPLANGENERAL.ReportSource = rpt

        ElseIf txtTipoPlanilla.Text = "4" Then
            Dim rpt As New crPlanillaAguinaldo
            Dts = PLANILLA.Rpt_PlanillaAguinaldo(CodPlanilla)
            rpt.SetDataSource(Dts.Tables(0))
            Me.crPLANGENERAL.ReportSource = rpt
        End If
    End Sub
    Private Sub rbMostrarTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMostrarTodos.CheckedChanged
        If rbMostrarTodos.Checked = True Then
            Me.cbAreas.Enabled = False
            Me.cbDepartamento.Enabled = False
        End If
    End Sub
    Private Sub rbAreas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAreas.CheckedChanged
        If rbAreas.Checked = True Then
            Me.cbAreas.Enabled = True
            Me.cbDepartamento.Enabled = False
        End If
    End Sub
    Private Sub rbDepartamento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDepartamento.CheckedChanged
        If rbDepartamento.Checked = True Then
            Me.cbAreas.Enabled = True
            Me.cbDepartamento.Enabled = True
        End If
    End Sub
    Private Sub cbAreas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAreas.SelectedIndexChanged
        cargarDepartamento(Me.cbAreas.SelectedValue)
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim opcion As Integer
            If Me.rbMostrarTodos.Checked = True Then
                opcion = 1
            ElseIf rbAreas.Checked = True Then
                opcion = 2
            ElseIf rbDepartamento.Checked = True Then
                opcion = 3
            End If
            LlenarPlanilla(Me.txtCodPlanilla.Text.Trim, opcion, Me.cbAreas.SelectedValue.ToString.Trim, Me.cbDepartamento.SelectedValue.ToString.Trim)
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodPlanilla_TextChanged(sender As Object, e As EventArgs) Handles txtCodPlanilla.TextChanged

    End Sub
End Class