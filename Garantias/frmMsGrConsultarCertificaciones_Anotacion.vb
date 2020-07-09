Public Class frmMsGrConsultarCertificaciones_Anotacion
    Public vNUMSOLICITUD As Integer
    Public vDui As String
    Dim OCRED As New wrCredito.wsLibCred ' SIF_ERP.wrCredito.wsLibCred
    Private Sub frmMsGrConsultarCertificaciones_Anotacion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ENCABEZADOSDG()
            Dim DTS As New DataSet
            btnAGREGAR1.Enabled = False
            Dim ds As New DataSet
            Dim dr As DataRow
            DTS = OCRED.CONSULTARDET_CERTIFICACIONEXTRACTADA(sUsuario, sPassword, sSucursal, vNUMSOLICITUD, 2, "")
            dgCERTIFICACIONES.DataSource = DTS.Tables(0)
            LLENAR_ANOTACIONES()
            Me.lblENCANOTACION.Text = Me.lblENCANOTACION.Text & " " & vNUMSOLICITUD
            MOSTRAR_DATOS_ASOCIADO(vNUMSOLICITUD)
            If dgCERTIFICACIONES.RowCount <= 0 Then
                dgCERTIFICACIONES.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comuniquese con el Administrador del sistema.")
        End Try
    End Sub
    Private Sub dgCERTIFICACIONES_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCERTIFICACIONES.CellDoubleClick
        Dim NOCOMPROBANTE As String
        NOCOMPROBANTE = dgCERTIFICACIONES.CurrentRow.Cells(0).Value.ToString.Trim
        Dim frmA As New frmMsGrAnotacionPreventiva
        frmA.vNOCOMPROBANTE = NOCOMPROBANTE
        frmA.NumSolicitud = vNUMSOLICITUD
        frmA.ORIGEN = 1
        frmA.vACCION = 2
        frmA.ShowDialog()
        Me.Dispose()
    End Sub
    Public Sub LLENAR_ANOTACIONES()
        Dim DTS As New DataSet
        DTS = OCRED.CONSULTARANOTACIONPREVENTIVA(sUsuario, sPassword, sSucursal, vNUMSOLICITUD, 0, 1)
        Me.dgANOTACIONPREV.DataSource = DTS.Tables(0)
    End Sub
    Private Sub dgANOTACIONPREV_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgANOTACIONPREV.CellDoubleClick
        Dim IDANOTACION As Integer
        Dim NOCOMPROBANTE As String
        Dim FRMA As New frmMsGrAnotacionPreventiva
        IDANOTACION = dgANOTACIONPREV.CurrentRow.Cells(0).Value.ToString.Trim
        NOCOMPROBANTE = dgANOTACIONPREV.CurrentRow.Cells("NOCOMPROBANTE").Value.ToString.Trim
        FRMA.IDANOTACION = IDANOTACION
        FRMA.NumSolicitud = vNUMSOLICITUD
        FRMA.vNOCOMPROBANTE = NOCOMPROBANTE
        FRMA.ORIGEN = 1
        FRMA.vACCION = 1
        FRMA.ShowDialog()
    End Sub
    Protected Function ELIMINAR_ANOTACION(ByVal IDANOTACION As Integer) As Integer
        Dim RESULTADO As Integer
        RESULTADO = OCRED.ELIMINARANOTACIONPREVENTIVA(sUsuario, sPassword, sSucursal, IDANOTACION)
        Return RESULTADO
    End Function
    Private Sub dgCERTIFICACIONES_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCERTIFICACIONES.CellContentClick
        If Me.dgCERTIFICACIONES.CurrentRow.Index > -1 Then
            Me.btnAGREGAR1.Enabled = True
        End If
    End Sub
    Protected Sub MOSTRAR_DATOS_ASOCIADO(ByVal NUMSOLICITUD As Integer)
        Dim DTS As New DataSet
        Dim ASOCIADO As String
        Dim MONTO As Double
        Dim PLAZO As Integer
        DTS = OCRED.CONSULTAR_DATOSGENERALESASOCIADOS(sUsuario, sPassword, sSucursal, NUMSOLICITUD)
        ASOCIADO = DTS.Tables(0).Rows(0).Item("ASOCIADO")
        MONTO = DTS.Tables(0).Rows(0).Item("MONTO")
        PLAZO = DTS.Tables(0).Rows(0).Item("PLAZO")
        Me.lblConcedido.Text = Me.lblConcedido.Text & " " & ASOCIADO
        Me.lblMonto.Text = Me.lblMonto.Text & " " & CStr(MONTO).Trim
        Me.lblPlazo.Text = Me.lblPlazo.Text & " " & CStr(PLAZO).Trim
    End Sub
    Protected Sub ENCABEZADOSDG()
        Me.dgANOTACIONPREV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgANOTACIONPREV.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgANOTACIONPREV.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgANOTACIONPREV.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgCERTIFICACIONES.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgCERTIFICACIONES.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgCERTIFICACIONES.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgCERTIFICACIONES.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub
    Private Sub btnAGREGAR1_Click(sender As Object, e As EventArgs) Handles btnAGREGAR1.Click
        Try
            If Me.dgCERTIFICACIONES.RowCount > -1 Then
                Dim NOCOMPROBANTE As String
                NOCOMPROBANTE = dgCERTIFICACIONES.CurrentRow.Cells(0).Value.ToString.Trim
                Dim frmA As New frmMsGrAnotacionPreventiva
                frmA.vNOCOMPROBANTE = NOCOMPROBANTE
                frmA.NumSolicitud = vNUMSOLICITUD
                frmA.ORIGEN = 1
                frmA.vACCION = 2
                frmA.ShowDialog()
                Me.Dispose()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnCONSULTAR1_Click(sender As Object, e As EventArgs) Handles btnCONSULTAR1.Click
        Try
            Dim IDANOTACION As Integer
            Dim NOCOMPROBANTE As String
            Dim FRMA As New frmMsGrAnotacionPreventiva
            IDANOTACION = dgANOTACIONPREV.CurrentRow.Cells(0).Value.ToString.Trim
            NOCOMPROBANTE = dgANOTACIONPREV.CurrentRow.Cells("NOCOMPROBANTE").Value.ToString.Trim
            FRMA.IDANOTACION = IDANOTACION
            FRMA.NumSolicitud = vNUMSOLICITUD
            FRMA.vNOCOMPROBANTE = NOCOMPROBANTE
            FRMA.ORIGEN = 1
            FRMA.vACCION = 1
            FRMA.ShowDialog()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnMODIFICAR1_Click(sender As Object, e As EventArgs) Handles btnMODIFICAR1.Click
        Try
            Dim IDANOTACION As Integer
            Dim NOCOMPROBANTE As String
            Dim FRMA As New frmMsGrAnotacionPreventiva
            If Me.dgANOTACIONPREV.CurrentRow.Index > -1 Then
                IDANOTACION = dgANOTACIONPREV.CurrentRow.Cells(0).Value.ToString.Trim
                NOCOMPROBANTE = dgANOTACIONPREV.CurrentRow.Cells("NOCOMPROBANTE").Value.ToString.Trim
                FRMA.IDANOTACION = IDANOTACION
                FRMA.NumSolicitud = vNUMSOLICITUD
                FRMA.vNOCOMPROBANTE = NOCOMPROBANTE
                FRMA.ORIGEN = 1
                FRMA.vACCION = 3
                FRMA.ShowDialog()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnELIMINAR1_Click(sender As Object, e As EventArgs) Handles btnELIMINAR1.Click
        Try
            Dim IDANOTACION As Integer
            Dim RESULTADO As Integer
            If Me.dgANOTACIONPREV.CurrentRow.Index > -1 Then
                IDANOTACION = dgANOTACIONPREV.CurrentRow.Cells(0).Value.ToString.Trim
                RESULTADO = ELIMINAR_ANOTACION(IDANOTACION)
                If RESULTADO <> 0 Then
                    MsgBox("Anotación eliminada exitosamente", MsgBoxStyle.Information, "Módulo - Garantías")
                Else
                    MsgBox("El registro no ha sido eliminado, " & vbCrLf & "Por favor comuniquese con el administrador del sistema", MsgBoxStyle.Information, "Modulo - Garantias")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class