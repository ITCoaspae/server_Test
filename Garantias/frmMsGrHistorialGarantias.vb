Public Class frmMsGrHistorialGarantias
    Dim CREDITO As New wrCredito.wsLibCred
    Public vNOCOMPROBANTE As String
    Public vNUMSOLICITUD As Integer
    Dim PERMISO As Boolean
    Dim CORRELATIVO As Integer
    Private Sub frmMsGrHistorialGarantias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LLENAR_DGHISTORICO(vNOCOMPROBANTE)
        OCULTAR_ENCABEZADOS_DG()
        DatosGeneralesCredito(vNUMSOLICITUD)
    End Sub
    Protected Sub LLENAR_DGHISTORICO(ByVal NOCOMPROBANTE As String)
        Dim DTS As New DataSet
        DTS = CREDITO.CONSULTAR_GRHISTOINSCRIPCIONGARANTIA(sUsuario, sPassword, sSucursal, NOCOMPROBANTE)
        Me.dgHISTORICOGARANTIAS.DataSource = DTS.Tables(0)
    End Sub
    Private Sub dgHISTORICOGARANTIAS_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgHISTORICOGARANTIAS.CellDoubleClick
        Dim COMPROBANTE As String
        Dim FECHAMODIFICACION As Date
        Dim MONTO As Double
        Dim PLAZO, TASA As Integer
        Dim INSCRIPCION As String
        Dim OBSERVACIONES As String
        Dim FECHA_INSCRIPCION, FECHA_PRESENTACION As DateTime
        COMPROBANTE = dgHISTORICOGARANTIAS.CurrentRow.Cells("NOCOMPROBANTE").Value
        FECHAMODIFICACION = dgHISTORICOGARANTIAS.CurrentRow.Cells("FECHA_MODIFICACION").Value
        MONTO = dgHISTORICOGARANTIAS.CurrentRow.Cells("MONTO").Value
        FECHA_PRESENTACION = dgHISTORICOGARANTIAS.CurrentRow.Cells("FEC_PRESENTACION_HIPOTECA").Value
        FECHA_INSCRIPCION = dgHISTORICOGARANTIAS.CurrentRow.Cells("FEC_INSCRIPCION_HIPOTECA").Value
        INSCRIPCION = dgHISTORICOGARANTIAS.CurrentRow.Cells("NO_INSCRIPCION_HIPOTECA").Value
        OBSERVACIONES = dgHISTORICOGARANTIAS.CurrentRow.Cells("OBSERVACIONES").Value
        TASA = dgHISTORICOGARANTIAS.CurrentRow.Cells("TASA_INTERES").Value
        PLAZO = dgHISTORICOGARANTIAS.CurrentRow.Cells("PLAZO").Value
        Me.CORRELATIVO = dgHISTORICOGARANTIAS.CurrentRow.Cells("CORRELATIVO").Value
        Me.txtNOCOMPROBANTE.Text = COMPROBANTE
        Me.dtpFECHAINSCRIPCION.Value = FECHA_INSCRIPCION
        Me.dtpFECHAMODIFICACION.Value = FECHAMODIFICACION
        Me.dtpFECHAPRESENTACION.Value = FECHA_PRESENTACION
        Me.txtMONTO.Text = MONTO
        Me.txtTASA.Text = TASA
        Me.txtOBSERVACIONES.Text = OBSERVACIONES
        Me.txtPLAZO.Text = PLAZO
        Me.txtINSCRIPCION.Text = INSCRIPCION
    End Sub
    Protected Sub OCULTAR_ENCABEZADOS_DG()
        Me.dgHISTORICOGARANTIAS.Columns("CORRELATIVO").Visible = False
        Me.dgHISTORICOGARANTIAS.Columns("USUARIO").Visible = False
        Me.dgHISTORICOGARANTIAS.Columns("FECHA_ACTU").Visible = False
        Me.dgHISTORICOGARANTIAS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgHISTORICOGARANTIAS.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgHISTORICOGARANTIAS.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgHISTORICOGARANTIAS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgHISTORICOGARANTIAS.Columns.Item("NOCOMPROBANTE").HeaderText = "No. Comprobante"
        Me.dgHISTORICOGARANTIAS.Columns.Item("FECHA_MODIFICACION").HeaderText = "Fecha de Modificación"
        Me.dgHISTORICOGARANTIAS.Columns.Item("MONTO").HeaderText = "Monto"
        Me.dgHISTORICOGARANTIAS.Columns.Item("FEC_PRESENTACION_HIPOTECA").HeaderText = "Fecha Presentación Hipoteca"
        Me.dgHISTORICOGARANTIAS.Columns.Item("FEC_INSCRIPCION_HIPOTECA").HeaderText = "Fecha Inscripión Hipoteca"
        Me.dgHISTORICOGARANTIAS.Columns.Item("NO_INSCRIPCION_HIPOTECA").HeaderText = "No. Inscripción Hipoteca"
        Me.dgHISTORICOGARANTIAS.Columns.Item("OBSERVACIONES").HeaderText = "Observaciones"
        Me.dgHISTORICOGARANTIAS.Columns.Item("TASA_INTERES").HeaderText = "Tasa Interes"
        Me.dgHISTORICOGARANTIAS.Columns.Item("PLAZO").HeaderText = "Plazo"
    End Sub
    Protected Sub DatosGeneralesCredito(ByVal NUMSOLICITUD As Integer)
        Dim DTS As New DataSet
        DTS = Credito.CONSULTAR_DATOSGENERALESASOCIADOS(sUsuario, sPassword, sSucursal, NUMSOLICITUD)
        If DTS.Tables(0).Rows.Count > 0 Then
            Me.lblASOCIADO.Text = Me.lblASOCIADO.Text + " " + DTS.Tables(0).Rows(0).Item("ASOCIADO").ToString.Trim
            Me.lblENCPLAZO.Text = Me.lblENCPLAZO.Text + " " + DTS.Tables(0).Rows(0).Item("PLAZO").ToString.Trim
            Me.lblENCTASA.Text = Me.lblENCTASA.Text + " " + DTS.Tables(0).Rows(0).Item("TASA_INTERES").ToString.Trim
            Me.lblENCESTADO.Text = Me.lblENCESTADO.Text + " " + DTS.Tables(0).Rows(0).Item("ESTADO").ToString.Trim
            Me.lblENCMONTO.Text = Me.lblENCMONTO.Text + " " + DTS.Tables(0).Rows(0).Item("MONTO").ToString.Trim
            Me.lblENCFECHAVENCIMIENTO.Text = Me.lblENCFECHAVENCIMIENTO.Text + " " + DTS.Tables(0).Rows(0).Item("FECHAVENCIMIENTO").ToString.Trim
            Me.lblENCFECHAOTOR.Text = Me.lblENCFECHAOTOR.Text + " " + DTS.Tables(0).Rows(0).Item("FECHAOTORGAMIENTO").ToString.Trim
            Me.lblNUMSOLICITUD.Text = Me.lblNUMSOLICITUD.Text + " " + CStr(vNUMSOLICITUD)
        End If
    End Sub
    Private Sub btnMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmMsAutorizacion
        frm.TipoPermiso = "P"
        frm.NumPrograma = "AHN012"
        frm.ShowDialog()
        If frm.Autoriza = True Then
            Dim RESULTADO As Integer
            PERMISO = True
            frm.Autoriza = False
            frm.Dispose()
            RESULTADO = CREDITO.MODIFICAR_GRHISTOINSCRIPCIONGARANTIA(sUsuario, sPassword, sSucursal, Me.CORRELATIVO, dtpFECHAMODIFICACION.Value,
                                                         Me.txtMONTO.Text.Trim, Me.dtpFECHAPRESENTACION.Value, Me.dtpFECHAINSCRIPCION.Value,
                                                         Me.txtINSCRIPCION.Text.Trim, Me.txtOBSERVACIONES.Text, Me.txtTASA.Text, Me.txtPLAZO.Text,
                                                         Now)
            If RESULTADO <> 0 Then
                LLENAR_DGHISTORICO(vNOCOMPROBANTE)
                MsgBox("Historial actualizado exitosamente.", MsgBoxStyle.Information, "MODÚLO - GARANTÍAS")
            Else
                MsgBox("No se pudo realizar la modificación, por favor comunicarce con el Administrador del sistema..", MsgBoxStyle.Information, "MODÚLO - GARANTÍAS")
            End If

        Else
            'Me.chkDPF.Checked = False
            frm.Dispose()
            MsgBox("No tiene los derechos para realizar esta acción.", MsgBoxStyle.Information, "MODÚLO - GARANTÍAS")
        End If
    End Sub
End Class