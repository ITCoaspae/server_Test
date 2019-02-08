Public Class frmMsGarantias
    Dim CREDITO As New wrCredito.wsLibCred
    Protected Sub LLENAR_DG(ByVal NUMSOLICITUD As Integer, ByVal OPCION As Integer, _
                            ByVal NOCOMPROBANTE As String, ByVal NOMATRICULA As String, ByVal DUI As String)
        Dim DTS As New DataSet
        DTS = CREDITO.CONSULTARINSCRIPCIONGARANTIA(sUsuario, sPassword, sSucursal, _
                                                   NUMSOLICITUD, OPCION, NOCOMPROBANTE, DUI, NOMATRICULA)
        Me.DataGridView1.DataSource = DTS.Tables(0)
        ENCABEZADODG()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim PENDIENTE As Boolean
        Dim NOCOMPROBANTE As String
        Dim NUMSOLICITUD As String
        Dim FRM As New frmMsGrMovimientoGarantias
        NOCOMPROBANTE = DataGridView1.CurrentRow.Cells("NOCOMPROBANTE").Value
        PENDIENTE = CONSULTAR_DOCPENDIENTES_ENTREGA(NOCOMPROBANTE)
        If PENDIENTE = True Then
            MsgBox("Los documentos de esta Garantia no han sido retornados.", MsgBoxStyle.Information, "Modulo - Garantias")
        End If
        NUMSOLICITUD = DataGridView1.CurrentRow.Cells("NUMSOLICITUD").Value
        FRM.vNOCOMPROBANTE = NOCOMPROBANTE
        FRM.vNUMSOLICITUD = NUMSOLICITUD
        FRM.Height = 477
        FRM.vACCION = 1
        Me.Hide()
        FRM.ShowDialog()
        FRM.Dispose()
    End Sub
    Protected Function CONSULTAR_DOCPENDIENTES_ENTREGA(ByVal NOCOMPROBANTE) As Boolean
        Dim DTS As New DataSet
        Dim PENDIENTE As Boolean
        DTS = CREDITO.CONSULTAR_GRMOVIMIENTOSDOCGARANTIAS(sUsuario, sPassword, sSucursal, NOCOMPROBANTE, 3, Now, Now)
        If DTS.Tables(0).Rows.Count > 0 Then
            PENDIENTE = True
        Else
            PENDIENTE = False
        End If
        Return PENDIENTE
    End Function

    Protected Sub ENCABEZADODG()
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

    End Sub
    Private Sub btnDEVOLUCION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
    Private Sub btnMODIFICAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtDUI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDUI.Click
        Me.txtDUI.SelectionStart = 0
    End Sub
    Private Sub frmMsGarantias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.rbDUI.Checked = True
    End Sub
    Private Sub txtDUI_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDUI.GotFocus
        Me.rbDUI.Checked = True
        Me.txtDUI.SelectionStart = 0
    End Sub
    Private Sub txtNOCOMPROBANTE_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNOCOMPROBANTE.GotFocus
        Me.rbNOCOMPROBANTE.Checked = True
    End Sub
    Private Sub txtNOMATRICULA_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNOMATRICULA.GotFocus
        Me.rbNOMATRICULA.Checked = True
    End Sub



    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If Me.rbDUI.Checked = True Then
                LLENAR_DG(0, 3, " ", "", Me.txtDUI.Text)
            ElseIf Me.rbNOCOMPROBANTE.Checked = True Then
                LLENAR_DG(0, 5, txtNOCOMPROBANTE.Text, " ", txtDUI.Text)
            ElseIf Me.rbNOMATRICULA.Checked = True Then
                LLENAR_DG(0, 4, " ", txtNOMATRICULA.Text, " ")
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            Dim PENDIENTE As Boolean
            Dim NOCOMPROBANTE As String
            Dim NUMSOLICITUD As String
            Dim FRM As New frmMsGrMovimientoGarantias
            NOCOMPROBANTE = DataGridView1.CurrentRow.Cells("NOCOMPROBANTE").Value
            PENDIENTE = CONSULTAR_DOCPENDIENTES_ENTREGA(NOCOMPROBANTE)
            If PENDIENTE = True Then
                NUMSOLICITUD = DataGridView1.CurrentRow.Cells("NUMSOLICITUD").Value
                FRM.vNOCOMPROBANTE = NOCOMPROBANTE
                FRM.vNUMSOLICITUD = NUMSOLICITUD
                'FRM.Height = 477
                FRM.vACCION = 1
                Me.Hide()
                FRM.ShowDialog()
                FRM.Dispose()
            Else
                MsgBox("No se han registrado prestamos de doc. para la garantía seleccionada.", MsgBoxStyle.Information, "Modulo - Garantias")
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim PENDIENTE As Boolean
            Dim NOCOMPROBANTE As String
            Dim NUMSOLICITUD As String
            Dim FRM As New frmMsGrMovimientoGarantias
            NOCOMPROBANTE = DataGridView1.CurrentRow.Cells("NOCOMPROBANTE").Value
            PENDIENTE = CONSULTAR_DOCPENDIENTES_ENTREGA(NOCOMPROBANTE)
            If PENDIENTE = True Then
                MsgBox("Los documentos de esta Garantia no han sido retornados.", MsgBoxStyle.Information, "Modulo - Garantias")
            End If
            NUMSOLICITUD = DataGridView1.CurrentRow.Cells("NUMSOLICITUD").Value
            FRM.vNOCOMPROBANTE = NOCOMPROBANTE
            FRM.vNUMSOLICITUD = NUMSOLICITUD
            'FRM.Height = 477
            FRM.vACCION = 1
            Me.Hide()
            FRM.ShowDialog()
            FRM.Dispose()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim NOCOMPROBANTE As String
            Dim NUMSOLICITUD As String
            Dim FRM As New frmMsGrMovimientoGarantias
            NOCOMPROBANTE = DataGridView1.CurrentRow.Cells("NOCOMPROBANTE").Value
            NUMSOLICITUD = DataGridView1.CurrentRow.Cells("NUMSOLICITUD").Value
            FRM.vNOCOMPROBANTE = NOCOMPROBANTE
            FRM.vNUMSOLICITUD = NUMSOLICITUD
            'FRM.Height = 477
            FRM.vACCION = 2
            FRM.ShowDialog()
            FRM.Dispose()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim PENDIENTE As Boolean
            Dim NOCOMPROBANTE As String
            Dim NUMSOLICITUD As String
            Dim FRM As New frmMsGrMovimientoGarantias
            NOCOMPROBANTE = DataGridView1.CurrentRow.Cells("NOCOMPROBANTE").Value
            NUMSOLICITUD = DataGridView1.CurrentRow.Cells("NUMSOLICITUD").Value
            FRM.vNOCOMPROBANTE = NOCOMPROBANTE
            FRM.vNUMSOLICITUD = NUMSOLICITUD
            'FRM.Height = 477
            FRM.vACCION = 3
            Me.Hide()
            FRM.ShowDialog()
            FRM.Dispose()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class