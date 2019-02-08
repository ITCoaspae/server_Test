Public Class frmsGrConsultarAnotaciones_Garantias
    Dim CRED As New wrCredito.wsLibCred
    Public vNUMSOLICITUD As Integer
    Private Sub frmsGrConsultarAnotaciones_Garantias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            LLENAR_CERTIFICACIONES(vNUMSOLICITUD)
            LLENAR_GARANTIAS(vNUMSOLICITUD)
            HEADERDG()
            Me.lblENC_Garantias.Text = Me.lblENC_Garantias.Text + " " + CStr(vNUMSOLICITUD).Trim
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comuniquese con el Administrador del sistema.")
        End Try
    End Sub
    Protected Sub LLENAR_CERTIFICACIONES(ByVal NUMSOLICITUD As Integer)
        Dim DTS As New DataSet
        DTS = CRED.CONSULTARDET_CERTIFICACIONEXTRACTADA(sUsuario, sPassword, sSucursal, NUMSOLICITUD, 3, " ")
        dgCERTIFICACIONES.DataSource = DTS.Tables(0)
    End Sub
    Protected Sub LLENAR_GARANTIAS(ByVal NUMSOLIITUD As Integer)
        Dim DTS As New DataSet
        DTS = CRED.CONSULTARINSCRIPCIONGARANTIA(sUsuario, sPassword, sSucursal, NUMSOLIITUD, 1, " ", " ", " ")
        dgGARANTIAS.DataSource = DTS.Tables(0)
    End Sub
    Private Sub dgCERTIFICACIONES_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCERTIFICACIONES.CellDoubleClick
        Dim NOCOMPROBANTE As String
        Dim IDNOTIFICACION As Integer
        Dim FRMG As New frmMsGrInscripcionGarantia
        NOCOMPROBANTE = dgCERTIFICACIONES.CurrentRow.Cells("NOCOMPROBANTE").Value
        IDNOTIFICACION = dgCERTIFICACIONES.CurrentRow.Cells("IDANOTACION").Value
        FRMG.vNOCOMPROBANTE_CERTIFICACION = NOCOMPROBANTE
        FRMG.vIDANOTACION = IDNOTIFICACION
        FRMG.NumSolicitud = vNUMSOLICITUD
        FRMG.vOPERACION = 1
        FRMG.Accion = "Guardar"
        FRMG.ShowDialog()
    End Sub
    Private Sub btnAGREGAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub dgGARANTIAS_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgGARANTIAS.CellDoubleClick
        Dim NOCOMPROBANTE As String
        Dim NOCOMPROBANTE_CE As String
        Dim FRMG As New frmMsGrInscripcionGarantia
        NOCOMPROBANTE = dgGARANTIAS.CurrentRow.Cells("NOCOMPROBANTE").Value
        NOCOMPROBANTE_CE = dgGARANTIAS.CurrentRow.Cells("NOCOMPROBANTE_CE").Value
        FRMG.vNOCOMPROBANTE = NOCOMPROBANTE
        FRMG.vNOCOMPROBANTE_CERTIFICACION = NOCOMPROBANTE_CE
        FRMG.NumSolicitud = vNUMSOLICITUD
        FRMG.vOPERACION = 0
        FRMG.ShowDialog()
    End Sub
    Private Sub btnCONSULTAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnELIMINAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Protected Sub HEADERDG()
        Me.dgCERTIFICACIONES.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgGARANTIAS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgGARANTIAS.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgCERTIFICACIONES.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgCERTIFICACIONES.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgCERTIFICACIONES.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgGARANTIAS.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgGARANTIAS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgCERTIFICACIONES.Columns.Item("CODDEPARTAMENTO").Visible = False
        Me.dgCERTIFICACIONES.Columns.Item("CODMUNICIPIO").Visible = False
        Me.dgCERTIFICACIONES.Columns.Item("CODSECCION").Visible = False
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            If Me.dgCERTIFICACIONES.CurrentRow.Index > -1 Then
                Dim NOCOMPROBANTE As String
                Dim IDNOTIFICACION As Integer
                Dim FRMG As New frmMsGrInscripcionGarantia
                NOCOMPROBANTE = dgCERTIFICACIONES.CurrentRow.Cells("NOCOMPROBANTE").Value
                IDNOTIFICACION = dgCERTIFICACIONES.CurrentRow.Cells("IDANOTACION").Value
                FRMG.vNOCOMPROBANTE_CERTIFICACION = NOCOMPROBANTE
                FRMG.vIDANOTACION = IDNOTIFICACION
                FRMG.NumSolicitud = vNUMSOLICITUD
                FRMG.vOPERACION = 1
                FRMG.Accion = "Guardar"
                FRMG.ShowDialog()
                LLENAR_CERTIFICACIONES(vNUMSOLICITUD)
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If Me.dgGARANTIAS.CurrentRow.Index > -1 Then
                Dim NOCOMPROBANTE As String
                Dim NOCOMPROBANTE_CE As String
                Dim FRMG As New frmMsGrInscripcionGarantia
                NOCOMPROBANTE = dgGARANTIAS.CurrentRow.Cells("NOCOMPROBANTE").Value
                NOCOMPROBANTE_CE = dgGARANTIAS.CurrentRow.Cells("NOCOMPROBANTE_CE").Value
                FRMG.vNOCOMPROBANTE = NOCOMPROBANTE
                FRMG.vNOCOMPROBANTE_CERTIFICACION = NOCOMPROBANTE_CE
                FRMG.NumSolicitud = vNUMSOLICITUD
                FRMG.vOPERACION = 0
                FRMG.ShowDialog()
            Else
                MsgBox("Por favor seleccione la garantia a consultar", MsgBoxStyle.Information, "MÓDULO - GARANTÍAS")
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            If Me.dgGARANTIAS.CurrentRow.Index > -1 Then
                Dim NOCOMPROBANTE As String
                Dim NOCOMPROBANTE_CE As String
                Dim IDANOTACION As Integer
                Dim FRMG As New frmMsGrInscripcionGarantia
                NOCOMPROBANTE = dgGARANTIAS.CurrentRow.Cells("NOCOMPROBANTE").Value
                NOCOMPROBANTE_CE = dgGARANTIAS.CurrentRow.Cells("NOCOMPROBANTE_CE").Value
                IDANOTACION = dgGARANTIAS.CurrentRow.Cells("IDANOTACION").Value
                FRMG.vNOCOMPROBANTE = NOCOMPROBANTE
                FRMG.vNOCOMPROBANTE_CERTIFICACION = NOCOMPROBANTE_CE
                FRMG.NumSolicitud = vNUMSOLICITUD
                FRMG.vIDANOTACION = IDANOTACION
                FRMG.vOPERACION = 2
                FRMG.ShowDialog()
            Else
                MsgBox("Por favor seleccione la garantia a consultar", MsgBoxStyle.Information, "MÓDULO - GARANTÍAS")
            End If
            LLENAR_GARANTIAS(vNUMSOLICITUD)
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        If Me.dgGARANTIAS.CurrentRow.Index > -1 Then
            Try
                Dim NOCOMPROBANTE As String
                NOCOMPROBANTE = dgGARANTIAS.CurrentRow.Cells("NOCOMPROBANTE").Value
                Dim RESULTADO As Integer
                RESULTADO = CRED.ELIMINARINSCRIPCIONGARANTIA(sUsuario, sSucursal, sPassword, NOCOMPROBANTE)
                If RESULTADO <> 0 Then
                    MsgBox("Garantía eliminada exitosamente.", MsgBoxStyle.Information, "MÓDULO - GARANTÍAS")
                    LLENAR_GARANTIAS(vNUMSOLICITUD)
                    LLENAR_CERTIFICACIONES(vNUMSOLICITUD)
                Else
                    MsgBox("Error al eliminar garantía, por favor comuniquese con el administrador del sistema.", MsgBoxStyle.Information, "MÓDULO - GARANTÍAS")
                End If
            Catch ex As Exception
                MsgBox(mensajeError, MsgBoxStyle.Critical)
            End Try

        End If
    End Sub
End Class