Imports System.Data.Sql
Public Class frmMPLBoletaPago
    Protected planillas As New wrPlanilla.wsLibPlanilla
#Region "Llenar ComboBox"
    Protected Sub llenarCbAreas()
        Dim Dts As New DataSet
        Dts = planillas.Consultar_PlAreas(sUsuario, sPassword, sSucursal, 1, "")
        Me.cbAreas.DataSource = Dts.Tables(0)
    End Sub
    Protected Sub llenarcbDepartamentos(ByVal CodArea As String)
        Dim dts As New DataSet
        dts = planillas.CONSULTAR_PLDEPARTAMENTOS(sUsuario, sPassword, sSucursal, 2, CodArea, "", "")
        Me.cbDepartamento.DataSource = dts.Tables(0)
    End Sub
    Protected Sub LlenarCbEmpleado(ByVal CodArea As String, ByVal CodDepartamento As String, ByVal Opcion As Integer)
        Dim Dts As New DataSet
        Dts = planillas.Consultar_PlEmpleados2(CodArea, CodDepartamento, "A", Opcion)
        Me.cbEmpleados.DataSource = Dts.Tables(0)
    End Sub
#End Region
    Private Sub cbAreas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAreas.SelectedIndexChanged
        If Me.cbAreas.SelectedIndex > -1 Then
            If (Me.rbDepartamento.Checked = True Or Me.rbEmpleado.Checked = True) Then
                llenarcbDepartamentos(Me.cbAreas.SelectedValue)
            End If
        End If
    End Sub
    Private Sub rbMostrarTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMostrarTodos.CheckedChanged
        If rbMostrarTodos.Checked = True Then
            Me.cbAreas.Enabled = False
            Me.cbDepartamento.Enabled = False
            Me.cbEmpleados.Enabled = False
        End If
    End Sub
    Private Sub rbArea_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbArea.CheckedChanged
        If rbArea.Checked = True Then
            Me.cbAreas.Enabled = True
            Me.cbDepartamento.Enabled = False
            Me.cbEmpleados.Enabled = False
            llenarCbAreas()
        End If
    End Sub
    Private Sub rbDepartamento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDepartamento.CheckedChanged
        If rbDepartamento.Checked = True Then
            Me.cbAreas.Enabled = True
            Me.cbDepartamento.Enabled = True
            Me.cbEmpleados.Enabled = False
        End If
    End Sub
    Private Sub rbEmpleado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEmpleado.CheckedChanged
        If rbEmpleado.Checked = True Then
            Me.cbAreas.Enabled = True
            Me.cbDepartamento.Enabled = True
            Me.cbEmpleados.Enabled = True
        End If
    End Sub
    Private Sub cbDepartamento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDepartamento.SelectedIndexChanged
        If Me.cbDepartamento.SelectedIndex > -1 Then
            If (Me.rbEmpleado.Checked = True Or Me.rbEmpleado.Checked = True) Then
                LlenarCbEmpleado(Me.cbAreas.SelectedValue, Me.cbDepartamento.SelectedValue, 3)
            End If
        End If
    End Sub
    Private Sub frmMPLBoletaPago_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbEmpleados.DisplayMember = "Empleado"
        Me.cbEmpleados.ValueMember = "Codempleado"
        Me.cbDepartamento.ValueMember = "CODDEPARTAMENTO"
        Me.cbDepartamento.DisplayMember = "DESCRIPCION"
        Me.cbAreas.ValueMember = "CODAREA"
        Me.cbAreas.DisplayMember = "DESCRIPCION"
    End Sub
    Protected Sub LlenarReporte(ByVal CodArea As String, ByVal CodDepartamento As String, ByVal CodEmpleado As String, ByVal FechaInicio As DateTime, _
                                            ByVal FechaFin As DateTime, ByVal Opcion As Integer)
        Dim dts As New DataSet
        Dim dtI As New DataTable
        Dim dtD As New DataTable
        dtI = planillas.Detalle_Ingresos_BoletaPagos(CodArea, CodDepartamento, CodEmpleado, FechaInicio, FechaFin, Opcion)
        dtD = planillas.Detalle_Descuentos_BoletaPagos(CodArea, CodDepartamento, CodEmpleado, FechaInicio, FechaFin, Opcion)
        dts = planillas.Reporte_BoletaPagos(CodArea, CodDepartamento, CodEmpleado, FechaInicio, FechaFin, Opcion)
        dts.Tables.Add(dtI)
        dts.Tables.Add(dtD)
        Dim ofrm As New frmVisor(dts, 216, 0)
        ofrm.ShowDialog()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If Me.rbMostrarTodos.Checked = True Then
                LlenarReporte("", "", "",
                               Format(Me.DateTimePicker1.Value, "SHORT DATE"), Format(Me.DateTimePicker2.Value, "SHORT DATE"), 1)
            ElseIf Me.rbArea.Checked = True Then
                LlenarReporte(Me.cbAreas.SelectedValue, "", "",
                               Format(Me.DateTimePicker1.Value, "SHORT DATE"), Format(Me.DateTimePicker2.Value, "SHORT DATE"), 2)
            ElseIf Me.rbDepartamento.Checked = True Then
                LlenarReporte(Me.cbAreas.SelectedValue, Me.cbDepartamento.SelectedValue, "",
                               Format(Me.DateTimePicker1.Value, "SHORT DATE"), Format(Me.DateTimePicker2.Value, "SHORT DATE"), 3)
            ElseIf Me.rbEmpleado.Checked = True Then
                LlenarReporte(Me.cbAreas.SelectedValue, Me.cbDepartamento.SelectedValue, Me.cbEmpleados.SelectedValue,
                               Format(Me.DateTimePicker1.Value, "SHORT DATE"), Format(Me.DateTimePicker2.Value, "SHORT DATE"), 4)
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
