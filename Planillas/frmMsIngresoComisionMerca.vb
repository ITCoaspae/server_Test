Public Class frmMsIngresoComisionMerca
    Protected Planillas As New wrPlanilla.wsLibPlanilla
    Protected Asociados As New wrAsociados.wsLibAsoc
    Private Sub ColumnasDg()
        If Me.chkTipoComision.Checked = False Then
            Dim CodEjecutivo As New DataGridViewTextBoxColumn
            With CodEjecutivo
                .Name = "ColumnCodEjectutivo"
                .HeaderText = "Codigo de Ejecutivo"
                .Visible = False
            End With
            Dim CodEmpleado As New DataGridViewTextBoxColumn
            With CodEmpleado
                .Name = "ColumnCodEmpleado"
                .HeaderText = "Código de Empleado"
                .Visible = False
            End With
            Dim Noplaza As New DataGridViewTextBoxColumn
            With Noplaza
                .Name = "ColumnNoPlaza"
                .HeaderText = "No. Plaza"
                .Visible = False
            End With
            Dim Ejecutivo As New DataGridViewTextBoxColumn
            With Ejecutivo
                .Name = "ColumnEjecutivo"
                .HeaderText = "Ejecutivo"
            End With
            'Dim TotalMembresia As New DataGridViewTextBoxColumn
            'With TotalMembresia
            '    .Name = "ColumnTotalMembresia"
            '    .HeaderText = "Total Membresia"
            'End With
            'Dim TotalComisionCN As New DataGridViewTextBoxColumn
            'With TotalComisionCN
            '    .Name = "ColumnTotalComisionCn"
            '    .HeaderText = "Comisión Créditos Nuevos"
            'End With
            'Dim TotalComisionCR As New DataGridViewTextBoxColumn
            'With TotalComisionCR
            '    .Name = "ColumnComisionCR"
            '    .HeaderText = "Comisión Créditos Refinan"
            'End With
            'Dim TotalDpfMenor6 As New DataGridViewTextBoxColumn
            'With TotalDpfMenor6
            '    .Name = "ColumnDPFMenor6"
            '    .HeaderText = "DPF Menor 6 Meses"
            'End With
            'Dim TotalDpf6 As New DataGridViewTextBoxColumn
            'With TotalDpf6
            '    .Name = "ColumnDPF6"
            '    .HeaderText = "DPF 6 Meses"
            'End With
            'Dim TotalDpfMayor6 As New DataGridViewTextBoxColumn
            'With TotalDpfMayor6
            '    .Name = "ColumnDPFMayor6"
            '    .HeaderText = "DPF Mayor 6 Meses"
            'End With
            'Dim TotalIncDpfMenor6 As New DataGridViewTextBoxColumn
            'With TotalIncDpfMenor6
            '    .Name = "ColumnDPFIncDpfmenor6"
            '    .HeaderText = "Incremento DPF Menor 6 Meses"
            'End With
            'Dim TotalIncDpf6 As New DataGridViewTextBoxColumn
            'With TotalIncDpf6
            '    .Name = "ColumnTotalIncDpf6"
            '    .HeaderText = "Incremento DPF 6 Meses"
            'End With
            'Dim TotalIncDpfMayor6 As New DataGridViewTextBoxColumn
            'With TotalIncDpfMayor6
            '    .Name = "ColumnTotalIncDpfMayor6"
            '    .HeaderText = "Incremento DPF Mayor 6 Meses"
            'End With
            'Dim IncColoMensual As New DataGridViewTextBoxColumn
            'With IncColoMensual
            '    .Name = "ColumnIncColoMensual"
            '    .HeaderText = "Incentivo Colocación Mensual"
            'End With
            'Dim IncColoTrim As New DataGridViewTextBoxColumn
            'With IncColoTrim
            '    .Name = "ColumnIncColoTrim"
            '    .HeaderText = "Incentivo Colocación Trimestral"
            'End With
            Dim TotalComision As New DataGridViewTextBoxColumn
            With TotalComision
                .Name = "ColumnTotalComision"
                .HeaderText = "Total Comisión"
            End With
            Dim Eliminar As New DataGridViewButtonColumn
            With Eliminar
                .Name = "ColumnEliminar"
                .HeaderText = "Eliminar"
                .Text = "Eliminar"
                .DefaultCellStyle.ForeColor = Color.Red
                .UseColumnTextForButtonValue = True
            End With
            Me.dgComisiones.Columns.Add(CodEjecutivo)
            Me.dgComisiones.Columns.Add(CodEmpleado)
            Me.dgComisiones.Columns.Add(Noplaza)
            Me.dgComisiones.Columns.Add(Ejecutivo)
            'Me.dgComisiones.Columns.Add(TotalMembresia)
            'Me.dgComisiones.Columns.Add(TotalComisionCN)
            'Me.dgComisiones.Columns.Add(TotalComisionCR)
            'Me.dgComisiones.Columns.Add(TotalDpfMenor6)
            'Me.dgComisiones.Columns.Add(TotalDpf6)
            'Me.dgComisiones.Columns.Add(TotalDpfMayor6)
            'Me.dgComisiones.Columns.Add(TotalIncDpfMenor6)
            'Me.dgComisiones.Columns.Add(TotalIncDpf6)
            'Me.dgComisiones.Columns.Add(TotalIncDpfMayor6)
            'Me.dgComisiones.Columns.Add(IncColoMensual)
            'Me.dgComisiones.Columns.Add(IncColoTrim)
            Me.dgComisiones.Columns.Add(TotalComision)
            Me.dgComisiones.Columns.Add(Eliminar)
            Me.dgComisiones.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
            Me.dgComisiones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            Me.dgComisiones.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Else
            Dim CodEjecutivo As New DataGridViewTextBoxColumn
            With CodEjecutivo
                .Name = "ColumnCodEjectutivo"
                .HeaderText = "Codigo de Ejecutivo"
                .Visible = False
            End With
            Dim CodEmpleado As New DataGridViewTextBoxColumn
            With CodEmpleado
                .Name = "ColumnCodEmpleado"
                .HeaderText = "Código de Empleado"
                .Visible = False
            End With
            Dim Noplaza As New DataGridViewTextBoxColumn
            With Noplaza
                .Name = "ColumnNoPlaza"
                .HeaderText = "No. Plaza"
                .Visible = False
            End With
            Dim Ejecutivo As New DataGridViewTextBoxColumn
            With Ejecutivo
                .Name = "ColumnEjecutivo"
                .HeaderText = "Ejecutivo"
            End With
            'Dim Monto As New DataGridViewTextBoxColumn
            'With Monto
            '    .Name = "ColumnMonto"
            '    .HeaderText = "Monto Colocado"
            'End With
            Dim ComisionTotal As New DataGridViewTextBoxColumn
            With ComisionTotal
                .Name = "ColumnTotalComision"
                .HeaderText = "Comisión Total"
            End With
            Dim Eliminar As New DataGridViewButtonColumn
            With Eliminar
                .Name = "ColumnEliminar"
                .Text = "Eliminar"
                .HeaderText = "Eliminar"
                .DefaultCellStyle.ForeColor = Color.Red
                .UseColumnTextForButtonValue = True
            End With
            Me.dgComisiones.Columns.Add(CodEjecutivo)
            Me.dgComisiones.Columns.Add(CodEmpleado)
            Me.dgComisiones.Columns.Add(Noplaza)
            Me.dgComisiones.Columns.Add(Ejecutivo)
            'Me.dgComisiones.Columns.Add(Monto)
            Me.dgComisiones.Columns.Add(ComisionTotal)
            Me.dgComisiones.Columns.Add(Eliminar)
            Me.dgComisiones.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
            Me.dgComisiones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            Me.dgComisiones.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        End If
    End Sub
    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub llenarDgComisiones(ByVal CodEjecutivo As String, ByVal Ejecutivo As String, ByVal ComisionGerencial As Boolean, ByVal CodSucursal As String, ByVal NoPlaza As String, ByVal CodEmpleado As String)
        Try
            Dim Totales As Double()
            If ComisionGerencial = False Then
                Totales = Planillas.Total_Comision_Ejecutivo(Format(Me.dtpFechaInicio.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"), CodEjecutivo)
                If Totales(11) > 0 Then
                    Me.dgComisiones.Rows.Add(CodEjecutivo, CodEmpleado, NoPlaza, Ejecutivo, Totales(11))
                    'Me.dgComisiones.Rows.Add(CodEjecutivo, CodEmpleado, NoPlaza, Ejecutivo, Totales(0), Totales(1), Totales(2), Totales(3), Totales(4), _
                    '                         Totales(5), Totales(6), Totales(7), Totales(8), Totales(9), Totales(10), Totales(11))
                End If
            Else
                Totales = Planillas.Total_ComisionesGerenciales(Format(Me.dtpFechaInicio.Value, "Short Date"),
                                                                Format(Me.dtpFechaFin.Value, "Short Date"), CodEjecutivo, CodSucursal)
                If Totales(3) > 0 Then
                    Me.dgComisiones.Rows.Add(CodEjecutivo, CodEmpleado, NoPlaza, Ejecutivo, Totales(3))
                    'Me.dgComisiones.Rows.Add(CodEjecutivo, CodEmpleado, NoPlaza, Ejecutivo, Totales(0), Totales(3))
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Módulo - Planillas")
        End Try
    End Sub

    Private Sub dgComisiones_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgComisiones.CellContentClick
        Try
            If Me.dgComisiones.Rows.Count > 0 Then
                If Me.dgComisiones.Columns(e.ColumnIndex).Name = "ColumnEliminar" Then
                    If MsgBox("Desea eliminar este empleado", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo Planillas") = 6 Then
                        Me.dgComisiones.Rows.RemoveAt(Me.dgComisiones.CurrentRow.Index)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error, Por favor comunicarse con el administrador del sistema" + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
        End Try
    End Sub
    Private Sub frmMsIngresoComisionMerca_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.btnGuardar1.Enabled = False
    End Sub


    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try
            Dim Dts As New DataSet
            Me.dgComisiones.Columns.Clear()
            Me.dgComisiones.Rows.Clear()
            ' La opcion 1 Muestra todos los ejecutivos activos
            If Me.chkTipoComision.Checked = False Then
                ColumnasDg()
                Dts = Asociados.Consultar_EjecutivosMercadeo(4, "")
                If Dts.Tables(0).Rows.Count > 0 Then
                    Me.btnGuardar1.Enabled = True
                    For i As Integer = 0 To Dts.Tables(0).Rows.Count - 1
                        llenarDgComisiones(Dts.Tables(0).Rows(i).Item("CODEJECMERCADEO").ToString, Dts.Tables(0).Rows(i).Item("EJECUTIVO").ToString, False,
                        Dts.Tables(0).Rows(i).Item("CODSUCURSAL").ToString, Dts.Tables(0).Rows(i).Item("NoPlaza").ToString,
                                           Dts.Tables(0).Rows(i).Item("CodEmpleado").ToString)
                    Next
                Else
                    Me.btnGuardar1.Enabled = False
                End If
            Else
                ColumnasDg()
                Dts = Asociados.Consultar_EjecutivosMercadeo(3, "")
                If Dts.Tables(0).Rows.Count > 0 Then
                    Me.btnGuardar1.Enabled = True
                    For i As Integer = 0 To Dts.Tables(0).Rows.Count - 1
                        llenarDgComisiones(Dts.Tables(0).Rows(i).Item("CODEJECMERCADEO").ToString, Dts.Tables(0).Rows(i).Item("EJECUTIVO").ToString, True,
                                           Dts.Tables(0).Rows(i).Item("CODSUCURSAL").ToString, Dts.Tables(0).Rows(i).Item("NoPlaza").ToString,
                                           Dts.Tables(0).Rows(i).Item("CodEmpleado").ToString)
                    Next
                Else
                    Me.btnGuardar1.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
            Exit Sub
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If GridAExcel(Me.dgComisiones) = True Then
                MsgBox("Documento exportado exitosamente", MsgBoxStyle.Information, "Módulo - Planillas")
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim Filas As Integer
            Dim Ingresos As Integer
            Dim Resultado As Integer
            Dim CodEmpleado As String
            Dim CodTipoIngreso As String
            Dim NumPlaza As String
            Dim Monto As Double
            Dim NoCuotas As Integer
            Dim FechaI As DateTime
            Dim FechaF As DateTime
            Dim Cancelado As String
            Dim TipoPlanilla As Integer
            If Me.chkTipoComision.Checked = False Then 'Guardamos comisiones de creditos no gerenciales para ejecutivos de mercadeo.
                If Me.dgComisiones.Rows.Count > 0 Then
                    Filas = dgComisiones.Rows.Count 'Recuperamos el numero de Registros a ingresar
                    For i As Integer = 0 To Filas - 1
                        CodEmpleado = Me.dgComisiones.Item("ColumnCodEmpleado", i).Value
                        NumPlaza = Me.dgComisiones.Item("ColumnNoPlaza", i).Value
                        CodTipoIngreso = "003"
                        Monto = Me.dgComisiones.Item("ColumnTotalComision", i).Value
                        NoCuotas = 1
                        FechaI = Format(Me.dtpFechaI.Value, "Short Date")
                        FechaF = Format(Me.dtpFechaF.Value, "Short Date")
                        Cancelado = "N"
                        TipoPlanilla = 1
                        Resultado = Planillas.Insertar_PlIngresos(sUsuario, sPassword, sSucursal, CodEmpleado, CodTipoIngreso,
                                                      NumPlaza, Monto, NoCuotas, FechaI, FechaF, Cancelado, "1", TipoPlanilla, 1)
                        If Resultado <> 0 Then
                            Ingresos = i
                        End If
                    Next
                    MsgBox("Se han creado " + Ingresos.ToString + "nuevos ingresos", MsgBoxStyle.Information, "Módulo - Planillas")
                End If
            Else
                If Me.dgComisiones.Rows.Count > 0 Then
                    Filas = dgComisiones.Rows.Count 'Recuperamos el numero de Registros a ingresar
                    For i As Integer = 0 To Filas - 1
                        CodEmpleado = Me.dgComisiones.Item("ColumnCodEmpleado", i).Value
                        NumPlaza = Me.dgComisiones.Item("ColumnNoPlaza", i).Value
                        CodTipoIngreso = "003"
                        Monto = Me.dgComisiones.Item("ColumnTotalComision", i).Value
                        NoCuotas = 1
                        FechaI = Format(Me.dtpFechaI.Value, "Short Date")
                        FechaF = Format(Me.dtpFechaF.Value, "Short Date")
                        Cancelado = "N"
                        TipoPlanilla = 1
                        Resultado = Planillas.Insertar_PlIngresos(sUsuario, sPassword, sSucursal, CodEmpleado, CodTipoIngreso,
                                                      NumPlaza, Monto, NoCuotas, FechaI, FechaF, Cancelado, "1", TipoPlanilla, 1)
                        If Resultado <> 0 Then
                            Ingresos = i
                        End If
                    Next
                    MsgBox("Se han creado " + Ingresos.ToString + "nuevos ingresos", MsgBoxStyle.Information, "Módulo - Planillas")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class