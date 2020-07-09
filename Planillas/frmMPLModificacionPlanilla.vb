Imports System.Data
Imports System.Data.SqlClient
Public Class frmMPLModificacionPlanilla
    Public CODPLANILLA As Integer
    Private oplan As New wrPlanilla.wsLibPlanilla
    Private Editar As Boolean

    Private Sub TextBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCODPLANILLA.DoubleClick
        My.Forms.frmMsPLDetPlanilla.Show(Me)
        Me.Dispose()
    End Sub
    Private Sub frmMPLModificacionPlanilla_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtCODPLANILLA.Text = CODPLANILLA
        LlenarCbAreas()
    End Sub
    Public Sub LLENAR_DG(ByVal CodPlanilla As String, ByVal Opcion As Integer, ByVal CodArea As String, ByVal Coddepartamento As String)
        Dim DTS As New DataSet
        DTS = oplan.Rpt_Planilla(CodPlanilla, Opcion, CodArea, Coddepartamento)
        'DTS = oplan.CONSULTARDESCUENTOSLEY(sUsuario, sPassword, sSucursal, CODPLANILLA)
        dgDESCUENTOS.DataSource = DTS.Tables(0)
        ENCABEZADOS_DG()
        Me.dgDESCUENTOS.Columns("CODPLANILLA").ReadOnly = True
        Me.dgDESCUENTOS.Columns(1).ReadOnly = True
        Me.dgDESCUENTOS.Columns(2).ReadOnly = True
        Me.dgDESCUENTOS.Columns(3).ReadOnly = True
        Me.dgDESCUENTOS.Columns(4).ReadOnly = True
        Me.dgDESCUENTOS.Columns(5).ReadOnly = True
        Me.dgDESCUENTOS.Columns(6).ReadOnly = True
        Me.dgDESCUENTOS.Columns(7).ReadOnly = True
        Me.dgDESCUENTOS.Columns(11).ReadOnly = True
        Me.dgDESCUENTOS.Columns(12).ReadOnly = True
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Protected Sub ENCABEZADOS_DG()
        Me.dgDESCUENTOS.Columns("CODPLANILLA").HeaderText = "Codigo de la planilla"
        Me.dgDESCUENTOS.Columns("CODEMPLEADO").HeaderText = "Codigo de Empleado"
        Me.dgDESCUENTOS.Columns("EMPLEADO").HeaderText = "Empleado"
        Me.dgDESCUENTOS.Columns("CARGO").HeaderText = "Cargo"
        Me.dgDESCUENTOS.Columns("DEPARTAMENTO").HeaderText = "Departamento"
        Me.dgDESCUENTOS.Columns("DIASTRABAJADOS").HeaderText = "Dias Trabajados"
        Me.dgDESCUENTOS.Columns("SUELDOQUINCENAL").HeaderText = "Sueldo Quincenal"
        Me.dgDESCUENTOS.Columns("SUELDODEVENGADO").HeaderText = "Sueldo Devengado"
        Me.dgDESCUENTOS.Columns("ISSS").HeaderText = "ISSS"
        Me.dgDESCUENTOS.Columns("AFP").HeaderText = "AFP"
        Me.dgDESCUENTOS.Columns("RENTA").HeaderText = "Renta"
        Me.dgDESCUENTOS.Columns("TOTALRETENIDO").HeaderText = "Total Retenido"
        Me.dgDESCUENTOS.Columns("TOTALRECIBIR").HeaderText = "Total a recibir"

        Me.dgDESCUENTOS.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgDESCUENTOS.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgDESCUENTOS.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgDESCUENTOS.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgDESCUENTOS.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgDESCUENTOS.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgDESCUENTOS.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgDESCUENTOS.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgDESCUENTOS.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgDESCUENTOS.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgDESCUENTOS.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgDESCUENTOS.Columns(11).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgDESCUENTOS.Columns(12).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgDESCUENTOS.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgDESCUENTOS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgDESCUENTOS.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub
    Protected edicion As Integer
    Protected FILA As Integer
    Protected COLUMNA As Integer
    Protected VALOR_A As Double
    Private Sub dgDESCUENTOS_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgDESCUENTOS.CellBeginEdit
        If Me.dgDESCUENTOS.CurrentRow.Index >= 0 Then
            Dim ELECCION As Integer
            ELECCION = MsgBox("Edición de celda", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Modulo - Planillas")
            If ELECCION = 6 Then
                Cursor = Cursors.WaitCursor
                Editar = True
                edicion = 1
                FILA = dgDESCUENTOS.CurrentRow.Index
                COLUMNA = dgDESCUENTOS.CurrentCell.ColumnIndex
                VALOR_A = Me.dgDESCUENTOS.CurrentCell.Value
            Else
                Cursor = Cursors.Default
                Editar = False
            End If
        End If

    End Sub
    Private Sub dgDESCUENTOS_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgDESCUENTOS.CellEndEdit
        If Editar = True Then

            Dim CODEMPLEADO As String
            Dim RECIBIR As Double
            Dim VALOR_N As Double
            Dim TOTAL_RECIBIR As Double
            Dim OPCION As Integer
            Dim RESULTADO As Integer
            Dim RETENIDO As Double
            Dim TOTAL_RETENIDO As Double
            If edicion = 1 Then
                RETENIDO = Me.dgDESCUENTOS.Item(11, FILA).Value
                CODEMPLEADO = Me.dgDESCUENTOS.Item(1, FILA).Value
                RECIBIR = Me.dgDESCUENTOS.Item(12, FILA).Value
                VALOR_N = Me.dgDESCUENTOS.CurrentCell.Value
                If VALOR_A > VALOR_N Then
                    TOTAL_RECIBIR = RECIBIR + (VALOR_A - VALOR_N)
                    TOTAL_RETENIDO = RETENIDO - (VALOR_A - VALOR_N)
                ElseIf VALOR_N > VALOR_A Then
                    TOTAL_RECIBIR = RECIBIR - (VALOR_N - VALOR_A)
                    TOTAL_RETENIDO = RETENIDO + (VALOR_N - VALOR_A)
                Else
                    TOTAL_RECIBIR = RECIBIR
                End If
                'COLUMNA 8 ISSS
                'COLUMNA 9 AFP
                'COLUMNA 10 RENTA
                If COLUMNA = 8 Then
                    OPCION = 2
                    RESULTADO = oplan.MODIFICAR_DESCUENTOSLEY(sUsuario, sPassword, sSucursal, OPCION, VALOR_N, CODPLANILLA, CODEMPLEADO, TOTAL_RECIBIR, TOTAL_RETENIDO)
                ElseIf COLUMNA = 9 Then
                    OPCION = 1
                    RESULTADO = oplan.MODIFICAR_DESCUENTOSLEY(sUsuario, sPassword, sSucursal, OPCION, VALOR_N, CODPLANILLA, CODEMPLEADO, TOTAL_RECIBIR, TOTAL_RETENIDO)
                ElseIf COLUMNA = 10 Then
                    OPCION = 3
                    RESULTADO = oplan.MODIFICAR_DESCUENTOSLEY(sUsuario, sPassword, sSucursal, OPCION, VALOR_N, CODPLANILLA, CODEMPLEADO, TOTAL_RECIBIR, TOTAL_RETENIDO)
                End If

                If RESULTADO <> 0 Then
                    RESULTADO = False

                    MsgBox("Modificación realizada exitosamente", MsgBoxStyle.Information, "Modulo - Planillas")
                    LLENAR_DG(Me.txtCODPLANILLA.Text.Trim, 4, cbArea.SelectedValue.ToString.Trim, Me.cbDepartamento.SelectedValue.ToString.Trim)
                    Cursor = Cursors.Default
                Else
                    MsgBox("No se pudo realizar la modifiación, por favor comunicarce con el Admin. del sistema", MsgBoxStyle.Information, "Modulo - Planillas")
                    Cursor = Cursors.Default
                End If
            End If
        End If
        Cursor = Cursors.Default
    End Sub

    Protected Sub LlenarCbAreas()
        Dim Dts As New DataSet
        Dts = oplan.Consultar_PlAreas(sUsuario, sPassword, sSucursal, 1, "")
        Me.cbArea.DataSource = Dts.Tables(0)
    End Sub
    Protected Sub LlenarDepartamentos(ByVal CodArea As String)
        Dim Dts As New DataSet
        Dts = oplan.CONSULTAR_PLDEPARTAMENTOS(sUsuario, sPassword, sSucursal, 2, CodArea, "", "")
        Me.cbDepartamento.DataSource = Dts.Tables(0)
    End Sub
    Private Sub cbArea_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbArea.SelectedIndexChanged
        LlenarDepartamentos(Me.cbArea.SelectedValue.ToString.Trim)
    End Sub

    Private Sub rbMostrarTodos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbMostrarTodos.Click
        If rbMostrarTodos.Checked = True Then
            Me.cbArea.Enabled = False
            Me.cbDepartamento.Enabled = False
        End If
    End Sub

    Private Sub rbSucursal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbSucursal.Click
        If rbSucursal.Checked = True Then
            Me.cbArea.Enabled = True
            Me.cbDepartamento.Enabled = False
        End If
    End Sub

    Private Sub rbDepartamento_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbDepartamento.Click
        If rbDepartamento.Checked = True Then
            Me.cbArea.Enabled = True
            Me.cbDepartamento.Enabled = True
        End If
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try
            If Me.rbMostrarTodos.Checked = True Then
                LLENAR_DG(Me.txtCODPLANILLA.Text.Trim, 4, cbArea.SelectedValue.ToString.Trim, Me.cbDepartamento.SelectedValue.ToString.Trim)
            ElseIf Me.rbSucursal.Checked = True Then
                LLENAR_DG(Me.txtCODPLANILLA.Text.Trim, 5, cbArea.SelectedValue.ToString.Trim, Me.cbDepartamento.SelectedValue.ToString.Trim)
            ElseIf Me.rbDepartamento.Checked = True Then
                LLENAR_DG(Me.txtCODPLANILLA.Text.Trim, 6, cbArea.SelectedValue.ToString.Trim, Me.cbDepartamento.SelectedValue.ToString.Trim)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class