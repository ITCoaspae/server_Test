Imports Microsoft.Office.Interop.Excel
Public Class frmMSPLPrePlanilla
    Protected planillas As New wrPlanilla.wsLibPlanilla
    Protected Sub GenerarPlanilla()

        Me.dgPlanillas.AllowUserToOrderColumns = True
        Dim Dts As New DataSet
        Dim Quincena As Integer
        Dim opcion As Integer

        If Me.dtpFechaInicio.Value.Day = 1 Then
            Quincena = 1
        ElseIf Me.dtpFechaInicio.Value.Day >= 16 Then
            Quincena = 2
        End If
        If Me.chMostrarTodos.Checked = True Then
            opcion = 1
        Else
            opcion = 2
        End If
        Dts = planillas.GenerarPlanilla2(Format(dtpFechaInicio.Value, "SHORT DATE"), Format(dtpFechaFin.Value, "SHORT DATE"), Quincena, Me.cbTipoPlanilla.SelectedValue,
                                         Me.cbArea.SelectedValue, Me.cbDepartamento.SelectedValue, opcion)
        Me.dgPlanillas.DataSource = Dts.Tables(0)




        If cbTipoPlanilla.SelectedValue = 1 Then
            Encabezado()
        End If

    End Sub
    Protected Sub Encabezado()
        Me.dgPlanillas.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgPlanillas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgPlanillas.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgPlanillas.Columns("Correlativo").Visible = False
        Me.dgPlanillas.Columns("CodEmpleado").HeaderText = "Código de Empleado"
        Me.dgPlanillas.Columns("Empleado").HeaderText = "Empleado"
        Me.dgPlanillas.Columns("CodArea").Visible = False
        Me.dgPlanillas.Columns("Sucursal").HeaderText = "Sucursal"
        Me.dgPlanillas.Columns("CodDepartamento").Visible = False
        Me.dgPlanillas.Columns("Departamento").HeaderText = "Departamento"
        Me.dgPlanillas.Columns("CodCargo").Visible = False
        Me.dgPlanillas.Columns("Cargo").HeaderText = "Cargo"
        Me.dgPlanillas.Columns("SueldoMensual").HeaderText = "Sueldo Mensual"
        Me.dgPlanillas.Columns("DiasTrabajados").HeaderText = "Días Trabajados"
        Me.dgPlanillas.Columns("SueldoQuincenal").HeaderText = "Sueldo Quincenal"
        Me.dgPlanillas.Columns("OtrosIngresos").HeaderText = "Otros Ingresos"
        Me.dgPlanillas.Columns("TotalDevengado").HeaderText = "Total Devengado"
        Me.dgPlanillas.Columns("CodPension").Visible = False
        Me.dgPlanillas.Columns("ISSS").HeaderText = "ISSS"
        Me.dgPlanillas.Columns("AFP").HeaderText = "AFP"
        Me.dgPlanillas.Columns("Renta").HeaderText = "Renta"
        Me.dgPlanillas.Columns("OtrosDesc").HeaderText = "Otros Desc."
        Me.dgPlanillas.Columns("TotalRetenido").HeaderText = "Total Retenido"
        Me.dgPlanillas.Columns("SubTotal").HeaderText = "Sub Total"
        Me.dgPlanillas.Columns("Viaticos").HeaderText = "Viaticos"
        Me.dgPlanillas.Columns("TotalPagar").HeaderText = "Total a Pagar"
        'tamaño de columans
        Me.dgPlanillas.Columns("Correlativo").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("CodEmpleado").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("Empleado").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("CodArea").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("Sucursal").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("Departamento").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("CodCargo").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("Cargo").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("SueldoMensual").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("DiasTrabajados").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("SueldoQuincenal").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("OtrosIngresos").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("TotalDevengado").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("CodPension").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("ISSS").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("AFP").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("Renta").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("OtrosDesc").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("TotalRetenido").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("SubTotal").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("Viaticos").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlanillas.Columns("TotalPagar").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells



    End Sub
    Protected Sub LlenarArea()
        Dim Dts As New DataSet
        Dts = planillas.Consultar_PlAreas(sUsuario, sPassword, sSucursal, 1, "")
        Me.cbArea.DataSource = Dts.Tables(0)
    End Sub
    Protected Sub LlenarDepartamentos()
        Dim Dts As New DataSet
        Dts = planillas.CONSULTAR_PLDEPARTAMENTOS(sUsuario, sPassword, sSucursal, 2, Me.cbArea.SelectedValue, "", "") '2 MUESTRA TODOS LOS DEPARTAMENTOS DE UN AREÁ ESPECIFICA.
        Me.cbDepartamento.DataSource = Dts.Tables(0)
    End Sub
    Protected Sub llenarcbTipoPlanilla()
        Dim Dts As New DataSet
        Dts = planillas.CONSULTAR_PLTIPOPLANILLA(sUsuario, sPassword, sSucursal)
        Me.cbTipoPlanilla.DataSource = Dts.Tables(0)
    End Sub
    Private Sub frmMSPLPrePlanilla_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarcbTipoPlanilla()
        Me.MetroButton2.Enabled = False
        Me.cbArea.DisplayMember = "DESCRIPCION"
        Me.cbArea.ValueMember = "CODAREA"
        LlenarArea()
    End Sub
    Private Sub btnGenerar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub dgPlanillas_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPlanillas.CellDoubleClick
        If Me.dgPlanillas.CurrentRow.Index >= 0 Then
            Dim Valido As Boolean
            Dim Fila As Integer
            Dim Columna As Integer
            Dim CodEmpleado As String
            Fila = Me.dgPlanillas.CurrentRow.Index
            Columna = Me.dgPlanillas.CurrentCell.ColumnIndex
            CodEmpleado = Me.dgPlanillas.Item("CodEmpleado", Fila).Value.ToString.Trim
            Valido = planillas.ValidarCasosEspeciales(CodEmpleado)
            If Valido = True Then
                If MsgBox("Modificar Descuentos", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Modulo - Planillas") = 6 Then
                    Dim Frm As New FrmMsPlDesc_x_Empleado
                    Frm.MostarDescuentos(2, 0, CodEmpleado, Format(Me.dtpFechaInicio.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
                    Frm.Show()
                End If
            End If
        End If
    End Sub
    Private Sub cbArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbArea.SelectedIndexChanged
        LlenarDepartamentos()
        Me.cbDepartamento.Enabled = True
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub chMostrarTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chMostrarTodos.CheckedChanged
        If chMostrarTodos.Checked = True Then
            Me.cbArea.Enabled = False
            Me.cbDepartamento.Enabled = False
        Else
            Me.cbArea.Enabled = True
            Me.cbDepartamento.Enabled = True
        End If
    End Sub
    Public Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean
        'Dim exApp As New Microsoft.Office.Interop.Excel.Application
        'Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        'Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            'exLibro = exApp.Workbooks.Add
            'exHoja = exLibro.Worksheets.Add()

            '' ¿Cuantas columnas y cuantas filas?
            'Dim NCol As Integer = ElGrid.ColumnCount
            'Dim NRow As Integer = ElGrid.RowCount

            ''Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            'For i As Integer = 1 To NCol
            '    exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
            '    'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            'Next

            'For Fila As Integer = 0 To NRow - 1
            '    For Col As Integer = 0 To NCol - 1
            '        exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
            '    Next
            'Next
            ''Titulo en negrita, Alineado al centro y que el tamaño de la columna seajuste al texto
            'exHoja.Rows.Item(1).Font.Bold = 1
            'exHoja.Rows.Item(1).HorizontalAlignment = 3
            'exHoja.Columns.AutoFit()


            ''Aplicación visible
            'exApp.Application.Visible = True

            'exHoja = Nothing
            'exLibro = Nothing
            'exApp = Nothing

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try

        Return True
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            GenerarPlanilla()
            Me.MetroButton2.Enabled = True
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If GridAExcel(Me.dgPlanillas) = True Then
                MsgBox("Exportación Realizada Exitossamente", MsgBoxStyle.Information, "Módulo - Planillas")
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        If MsgBox("Desea realizar esta acción", MsgBoxStyle.YesNo, "Módulo - Planillas") = 6 Then
            Try
                Dim Quincena As Integer
                If Me.dtpFechaInicio.Value.Day = 1 Then
                    Quincena = 1
                Else
                    Quincena = 2
                End If
                Dim Resultado As Integer
                Resultado = planillas.GuardarPlanilla(Me.cbTipoPlanilla.SelectedValue, Format(Now, "Short Date"), Format(Me.dtpFechaInicio.Value, "Short Date"),
                                                      Format(Me.dtpFechaFin.Value, "Short Date"), Quincena, sUsuario)

                If Resultado <> 0 Then

                    MsgBox("Planilla Ingresada Exitosamente", MsgBoxStyle.Information, "Módulo - Planillas")
                    'End If
                End If
            Catch ex As Exception
                 MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub dgPlanillas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPlanillas.CellContentClick

    End Sub

    Private Sub dgPlanillas_Click(sender As Object, e As EventArgs) Handles dgPlanillas.Click
        Try
            Dim total As Double
            Dim Col As Integer = Me.dgPlanillas.CurrentCell.ColumnIndex
            Dim nomCol As String = Me.dgPlanillas.Columns(Col).Name
            For Each row As DataGridViewRow In Me.dgPlanillas.Rows
                total += Val(row.Cells(Col).Value)
            Next
            lbTotales.Text = "TOTAL " + nomCol.ToString + " :" + total.ToString
        Catch ex As Exception

        End Try
    End Sub
End Class