Imports System.Data
Imports System.Data.SqlClient
Public Class frmMsPLDetPlanilla
    Private oplan As New wrPlanilla.wsLibPlanilla
    Private Sub frmMsPLDetPlanilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim DTS As New DataSet
            DTS = oplan.Consultar_PlPlanillas(1, Now, Now) 'muestra todas las planillas ingresadas
            dgPLANILLAS.DataSource = DTS.Tables(0)
            dgPLANILLAS.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
            dgPLANILLAS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            Me.dgPLANILLAS.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, " Modulo - Planillas")
        End Try
    End Sub
    Private Sub dgPLANILLAS_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPLANILLAS.CellDoubleClick
        Try
            Dim CODPLANILLA As Integer
            Dim PERIODO As String
            Dim FORM As New frmMPLModificacionPlanilla
            CODPLANILLA = dgPLANILLAS.Item("CodPlanilla", dgPLANILLAS.CurrentRow.Index).Value.ToString.Trim
            PERIODO = Format(dgPLANILLAS.Item("FechaInicio", dgPLANILLAS.CurrentRow.Index).Value, "SHORT DATE") & _
            "-" & Format(dgPLANILLAS.Item("FechaFin", dgPLANILLAS.CurrentRow.Index).Value, "SHORT DATE")
            FORM.CODPLANILLA = CODPLANILLA
            FORM.txtPERIODO.Text = PERIODO
            FORM.Show()
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Por favor comuniquese con el administrador del sistema")
        End Try

    End Sub

End Class