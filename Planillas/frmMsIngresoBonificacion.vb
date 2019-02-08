Public Class frmMsIngresoBonificacion
    Protected Planillas As New wrPlanilla.wsLibPlanilla
    Private Sub frmMsIngresoBonificacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim btnColumn As New DataGridViewButtonColumn
        With btnColumn
            .Width = 50
            .UseColumnTextForButtonValue = True
            '.DefaultCellStyle.BackColor = Color.Teal
            .DefaultCellStyle.ForeColor = Color.Red
            .Text = "Remover"
            .Name = "Eliminar"
            .HeaderText = "Remover Empleado"
        End With
        Me.dgBonificacion.Columns.Add(btnColumn)
    End Sub
    Private Sub EstiloDg()
        Me.dgBonificacion.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgBonificacion.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgBonificacion.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgBonificacion.Columns("BONIFICACION").HeaderText = "Bonificacion"
        Me.dgBonificacion.Columns("FechaIngreso").HeaderText = "Fecha de Ingreso"
        Me.dgBonificacion.Columns("FechaInicial").Visible = False
        Me.dgBonificacion.Columns("NoPlaza").Visible = False
        Me.dgBonificacion.Columns("Empleado").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgBonificacion.Columns("SueldoMensual").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgBonificacion.Columns("FechaIngreso").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgBonificacion.Columns("FechaInicial").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgBonificacion.Columns("Dias").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgBonificacion.Columns("Años de labor").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgBonificacion.Columns("BONIFICACION").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub
    Private Sub LlenardgBonificaciones(ByVal FechaInicio As DateTime, ByVal FechaFin As DateTime)
        Dim Dts As New DataSet
        Dts = Planillas.Bonificacion_Anual(FechaInicio, FechaFin)
        Me.dgBonificacion.DataSource = Dts.Tables(0)
        EstiloDg()
    End Sub
    Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub dgBonificacion_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgBonificacion.CellContentClick
        Try
            If Me.dgBonificacion.Rows.Count > 0 Then
                If Me.dgBonificacion.Columns(e.ColumnIndex).Name = "Eliminar" Then
                    If MsgBox("Desea eliminar este empleado", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo Planillas") = 6 Then
                        Me.dgBonificacion.Rows.RemoveAt(Me.dgBonificacion.CurrentRow.Index)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error, Por favor comunicarse con el administrador del sistema" + vbCrLf + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo - Planillas")
        End Try
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try
            If lblOpcion.Text.Trim = "B" Then
                LlenardgBonificaciones(Format(Me.dtpFechaInicio.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
            ElseIf lblOpcion.Text.Trim = "I" Then

            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If GridAExcel(Me.dgBonificacion) = True Then
                MsgBox("Datos exportados exitosamente", MsgBoxStyle.Information, "Módulo - Planillas")
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            If MsgBox("Desea realizar esta acción", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Módulo - Planillas") = MsgBoxResult.Yes Then
                If Me.dgBonificacion.RowCount > 0 Then
                    Dim Resultado As Integer
                    Dim CodEmpleado As String
                    Dim CodTipoIngreso As String
                    Dim NoPlaza As String
                    Dim Monto As Double
                    Dim CodTipoPlanilla As Integer
                    CodTipoIngreso = "002"
                    CodTipoPlanilla = 3

                    For I As Integer = 0 To dgBonificacion.Rows.Count - 1
                        CodEmpleado = dgBonificacion.Item("CodEmpleado", I).Value
                        NoPlaza = dgBonificacion.Item("NoPlaza", I).Value
                        Monto = dgBonificacion.Item("BONIFICACION", I).Value
                        Resultado = Planillas.Insertar_PlIngresos(sUsuario, sPassword, sSucursal, CodEmpleado,
                                                                 CodTipoIngreso, NoPlaza, Monto, 1, Format(Me.dtpFechaI.Value, "Short Date"),
                                                                 Format(Me.dtpFechaF.Value, "Short Date"), "N", "1", CodTipoPlanilla, 1)

                    Next
                    MsgBox("Registros ingresados exitosamente", MsgBoxStyle.Information, "Módulo - Planillas")
                    Me.dgBonificacion.ReadOnly = True
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class