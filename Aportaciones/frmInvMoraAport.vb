Public Class frmInvMoraAport
    Dim Ahorro As New wrAhorro.wsLibAhorro
    Dim Asociado As New wrAsociados.wsLibAsoc
    Private Sub LlenarDg(ByVal Fecha As DateTime, ByVal opcion As Integer, ByVal dui As String)
        Dim Dts As New DataSet
        Dts = Asociado.Consultar_InversionistasMora(Fecha, opcion, dui)
        'Dts = Ahorro.Consultar_Inv_Mora_Aportaciones(Fecha)
        Me.dgInvMoraAport.DataSource = Dts.Tables(0)
        EstiloDg()
    End Sub
    Protected Sub EstiloDg()
        Me.dgInvMoraAport.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgInvMoraAport.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgInvMoraAport.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgInvMoraAport.Columns("DUI").HeaderText = "DUI"
        Me.dgInvMoraAport.Columns("NOMBRE").HeaderText = "ASOCIADO"
        Me.dgInvMoraAport.Columns("SALDOAPORTACION").HeaderText = "SALDO CTA. DE APORTACIONES"
        Me.dgInvMoraAport.Columns("MORAAPORTACIONES").HeaderText = "SALDO EN MORA"
        Me.dgInvMoraAport.Columns("CUOTASMORAAPORTACIONES").HeaderText = "N° CUOTAS EN MORA"
        Me.dgInvMoraAport.Columns("CTAAPORTACIONES").HeaderText = "CTA. APORTACIONES"
        Me.dgInvMoraAport.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgInvMoraAport.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgInvMoraAport.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgInvMoraAport.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgInvMoraAport.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgInvMoraAport.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        'agregamos columna
        Dim Aplica As DataGridViewColumn = New DataGridViewCheckBoxColumn
        Aplica.HeaderText = "NO APLICA"
        Me.dgInvMoraAport.Columns.Add(Aplica)
    End Sub
    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        If Me.dgInvMoraAport.Columns.Count > 0 Then
            Me.dgInvMoraAport.Columns.Clear()
        End If
        LlenarDg(Format(Me.dtpFecha.Value, "Short Date"), 1, "")
    End Sub
    Private Sub dgInvMoraAport_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgInvMoraAport.CellContentClick
        Try
            If e.ColumnIndex = 6 Then
                If (Convert.ToBoolean(dgInvMoraAport.Rows(e.RowIndex).Cells(6).Value)) Then
                    dgInvMoraAport.Rows(e.RowIndex).Cells(6).Value = False
                    dgInvMoraAport.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.WhiteSmoke
                    dgInvMoraAport.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
                Else
                    dgInvMoraAport.Rows(e.RowIndex).Cells(6).Value = True
                    dgInvMoraAport.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Black
                    dgInvMoraAport.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Aportaciones")
        End Try
    End Sub
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Try
            GridAExcel(Me.dgInvMoraAport)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Aportaciones")
        End Try
    End Sub
    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesar.Click
        Try
            If Me.dgInvMoraAport.Rows.Count > 0 Then
                If MsgBox("Desea realizar esta accion", MsgBoxStyle.YesNo, "Módulo - Aportaciones") = MsgBoxResult.Yes Then
                    Dim Resultado As Integer
                    Dim dui As String
                    dui = RecuperarDui()
                    Dim TotalCaracteres As Integer
                    If dui.Length > 0 Then
                        TotalCaracteres = dui.Length
                        dui = dui.Substring(0, (TotalCaracteres - 1))
                    End If
                    Resultado = Ahorro.Transferencia_IntDpf_CuotaAportaciones(Format(Me.dtpFecha.Value, "short date"), dui, sUsuario)
                    If Resultado <> 0 Then
                        MsgBox("Proceso realizado exitosamente.", MsgBoxStyle.Information, "Módulo - Aportaciones")
                    Else
                        MsgBox("Error, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Aportaciones")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Aportaciones")
        End Try
    End Sub
    Private Function RecuperarDui()
        Dim dui As String = ""
        For Each row As DataGridViewRow In dgInvMoraAport.Rows
            If row.Cells(6).Value = False Then
                dui += row.Cells("DUI").Value.ToString.Trim + " "
            End If
        Next
        If dui.Length = 0 Then
            Return ""
        Else
            Return Replace(dui, " ", ",")
        End If
    End Function
End Class