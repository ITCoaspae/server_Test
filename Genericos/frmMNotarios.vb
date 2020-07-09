Public Class frmMNotarios
    Dim CREDITO As New wrCredito.wsLibCred

    Protected Sub CARGARDATOS_NOTARIOS(ByVal OPCION As Integer, ByVal IDNOTARIO As Integer, ByVal NOMBRES As String, ByVal APELLIDO1 As String, ByVal APELLIDO2 As String)
        Dim DTS As New DataSet
        DTS = CREDITO.CONSULTARGRNOTARIO(sUsuario, sPassword, sSucursal, OPCION, IDNOTARIO, NOMBRES, APELLIDO1, APELLIDO2)
        Me.dgNOTARIOS.DataSource = DTS.Tables(0)
        Me.dgNOTARIOS.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgNOTARIOS.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgNOTARIOS.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub rbIdNotario_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIdNotario.CheckedChanged
        If Me.rbIdNotario.Checked = True Then
            Me.txtIDNOTARIO.Focus()
        End If
    End Sub
    Private Sub rbNombres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNombres.CheckedChanged
        If Me.rbNombres.Checked = True Then
            Me.txtNOMBRES.Focus()
        End If
    End Sub
    Private Sub rbApellido1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbApellido1.CheckedChanged
        Me.txtAPELLIDO1.Focus()
    End Sub
    Private Sub rbAPELLIDO2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAPELLIDO2.CheckedChanged
        Me.txtAPELLIDO2.Focus()
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If Me.rbIdNotario.Checked = True Then
                If IsNumeric(Me.txtIDNOTARIO.Text) = True Then
                    CARGARDATOS_NOTARIOS(2, CInt(txtIDNOTARIO.Text), " ", " ", " ")
                End If
            ElseIf Me.rbNombres.Checked = True Then
                CARGARDATOS_NOTARIOS(3, 0, Me.txtNOMBRES.Text.Trim, " ", "")
            ElseIf Me.rbApellido1.Checked = True Then
                CARGARDATOS_NOTARIOS(4, 0, " ", Me.txtAPELLIDO1.Text.Trim, "")
            ElseIf Me.rbAPELLIDO2.Checked = True Then
                CARGARDATOS_NOTARIOS(5, 0, " ", " ", Me.txtAPELLIDO2.Text.Trim)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim frm As New frmMsNotario
            frm.vACCION = 1
            frm.ShowDialog()
            CARGARDATOS_NOTARIOS(1, 0, "", "", "")
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            Dim frm As New frmMsNotario
            Dim IDNOTARIO As Integer
            IDNOTARIO = Me.dgNOTARIOS.CurrentRow.Cells("IDNOTARIO").Value
            frm.vACCION = 2
            frm.vIDNOTARIO = IDNOTARIO
            frm.ShowDialog()
            CARGARDATOS_NOTARIOS(1, 0, "", "", "")
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim IDNOTARIO As Integer
        Dim RESULTADO As Integer
        Try
            IDNOTARIO = Me.dgNOTARIOS.CurrentRow.Cells("IDNOTARIO").Value
            RESULTADO = CREDITO.ELIMINARGRNOTARIO(sUsuario, sPassword, sSucursal, IDNOTARIO)
            If RESULTADO = 1 Then
                MsgBox("Notario eliminado exitosamente", MsgBoxStyle.Information, "")
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            Dim frm As New frmMsNotario
            Dim IDNOTARIO As Integer
            IDNOTARIO = Me.dgNOTARIOS.CurrentRow.Cells("IDNOTARIO").Value
            frm.vACCION = 3
            frm.vIDNOTARIO = IDNOTARIO
            frm.ShowDialog()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class