Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class frmMsConsultarPrestamos
    Public vDUI, vNOCOMPROBATE As String
    Dim CREDITO As New wrCredito.wsLibCred
    Private Sub frmMsConsultarPrestamos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LLENAR_DG(vDUI)
        ENCABEZADODG()
    End Sub
    Protected Sub ENCABEZADODG()
        Me.dgGENERICO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgGENERICO.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgGENERICO.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgGENERICO.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub
    Protected Sub LLENAR_DG(ByVal DUI As String)
        Dim DTS As New DataSet
        DTS = CREDITO.CONSULTARPRESTAMOSHIPOTECARIOS(sUsuario, sPassword, sSucursal, DUI, 1)
        Me.dgGENERICO.DataSource = DTS.Tables(0)
    End Sub
    Private Sub dgGENERICO_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgGENERICO.CellDoubleClick
        Dim RESULTADO As Integer
        RESULTADO = MsgBox("Desea realiazar esta acción", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo - Garantías")
        If RESULTADO = 6 Then
            Dim VALIDACION As Integer

            Dim CODPRESTAMO As String
            Dim NUMSOLICITUD As Integer
            'Dim FRM As New frmMsGrInscripcionGarantia
            CODPRESTAMO = dgGENERICO.CurrentRow.Cells("CODPRESTAMO").Value
            NUMSOLICITUD = dgGENERICO.CurrentRow.Cells("NUMSOLICITUD").Value
            VALIDACION = CREDITO.VALIDAR_INSCRIPCION_PRESTAMOSGARANTIA(sUsuario, sPassword, sSucursal, NUMSOLICITUD, vNOCOMPROBATE)
            If VALIDACION = 0 Then
                My.Forms.frmMsGrInscripcionGarantia.vNOCOMPROBANTE = vNOCOMPROBATE
                My.Forms.frmMsGrInscripcionGarantia.INSERTAR_INSCRIPCIONPRESTAMOS(CODPRESTAMO, NUMSOLICITUD)
            Else
                MsgBox("El Prestamo seleccionado ya ha sido asiganado a una garantia", MsgBoxStyle.Information, "Módulo - Garantías")
            End If
        End If
        Me.Dispose()
    End Sub
End Class