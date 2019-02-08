Public Class FrmMsAhTransferenciasAutomaticas
    Dim Ahorro As New wrAhorro.wsLibAhorro
    Private Sub FrmMsAhTransferenciasAutomaticas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Enabled = False
        Llenar_Dg(Format(Me.dtpFecha.Value, "Short Date"))
    End Sub
    Protected Sub Llenar_Dg(ByVal fecha As DateTime)
        Dim Dts As New DataSet
        Dts = Ahorro.ConsultarCtasTransferencia(fecha)
        Me.dgCuentas.DataSource = Dts.Tables(0)
        Encabezado()
    End Sub
    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        Llenar_Dg(Format(Me.dtpFecha.Value, "Short Date"))
    End Sub
    'Protected Function OmitirCtas()
    '    Dim ctas As String
    '    Dim cta As String
    '    Dim conjunto() As String
    '    conjunto = Split(txtOmision.Text, ",")
    '    For Each cta In conjunto
    '        ctas = ctas + "," + cta
    '    Next
    '    Return conjunto
    'End Function
    Protected Sub MarcarCtas_Omitir(ByVal cadena() As String)
        Dim TotalCtas As Integer
        TotalCtas = cadena.Count
        If TotalCtas > 0 Then
            For i As Integer = 1 To TotalCtas
                For Each row As DataGridViewRow In Me.dgCuentas.Rows
                    If row.Cells("Nocuenta").Value.ToString.Trim = cadena(i - 1) Then
                        row.DefaultCellStyle.BackColor = Color.Red
                        row.DefaultCellStyle.ForeColor = Color.White
                    End If
                Next
            Next
        End If
    End Sub
    'Private Sub txtOmision_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim Accion As Integer
    '    Accion = MsgBox("Desea omitir las siguientes ctas.", MsgBoxStyle.YesNo, "Módulo - Ahorros")
    '    If Accion = 6 Then
    '        MarcarCtas_Omitir(OmitirCtas)
    '    End If
    'End Sub 
    Private Sub dgCuentas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgCuentas.CellContentClick
        If e.ColumnIndex = 0 Then
            If (Convert.ToBoolean(dgCuentas.Rows(e.RowIndex).Cells(0).Value)) Then
                dgCuentas.Rows(e.RowIndex).Cells(0).Value = False
                dgCuentas.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.WhiteSmoke
                dgCuentas.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            Else
                dgCuentas.Rows(e.RowIndex).Cells(0).Value = True
                dgCuentas.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Black
                dgCuentas.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.White
            End If
        End If
    End Sub
    Protected Function RecuperarCtas() As String
        Dim Ctas As String
        For Each row As DataGridViewRow In dgCuentas.Rows
            If row.Cells(0).Value = True Then
                Ctas += row.Cells("Nocuenta").Value.ToString.Trim + " "
            End If
        Next
        If Ctas.Length = 0 Then
            Return " "
        Else
            Return Replace(Ctas, " ", ",")
        End If

    End Function
    Private Sub Encabezado()
        Me.dgCuentas.Columns(0).HeaderText = "No Transferir"
        Me.dgCuentas.Columns(1).HeaderText = "DUI"
        Me.dgCuentas.Columns(2).HeaderText = "No. Socio"
        Me.dgCuentas.Columns(3).HeaderText = "Fecha Cuota"
        Me.dgCuentas.Columns(4).HeaderText = "Asociado"
        Me.dgCuentas.Columns(5).HeaderText = "No. Cuenta"
        Me.dgCuentas.Columns(6).HeaderText = "Saldo Cta. de Ahorro"
        Me.dgCuentas.Columns(7).HeaderText = "Saldo Disponible Cta. de Ahorro"
        Me.dgCuentas.Columns(8).HeaderText = "Cod. Prestamo"
        Me.dgCuentas.Columns(9).HeaderText = "Cuota"
        Me.dgCuentas.Columns(10).HeaderText = "Saldo Capital Prestamo"
        Me.dgCuentas.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgCuentas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgCuentas.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgCuentas.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgCuentas.Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgCuentas.Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgCuentas.Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgCuentas.Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgCuentas.Columns(6).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgCuentas.Columns(7).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgCuentas.Columns(8).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgCuentas.Columns(9).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgCuentas.Columns(10).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

    End Sub
    Protected Function ValidarCtasNoTransferir() As Boolean
        For Each row As DataGridViewRow In dgCuentas.Rows
            If row.Cells(0).Value = True Then
                Return True
            Else
                Return False
            End If
        Next
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ctas As String = ""
        Dim TotalCaracteres As Integer
        Dim resultado As Integer
        Try
            If ValidarCtasNoTransferir() = True Then
                If MsgBox("Desea realizar esta acción." + ctas, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Módulo - Ahorros") = 6 Then
                    ctas = RecuperarCtas()
                    TotalCaracteres = ctas.Length
                    ctas = ctas.Substring(0, (TotalCaracteres - 1))
                    If MsgBox("Desea omitir las siguientes Cuentas: " + ctas, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Módulo - Ahorros") = 6 Then
                        Cursor = Cursors.WaitCursor
                        resultado = Ahorro.TrasnferenciasAutomaticas_Ahorros(Format(Me.dtpFecha.Value, "Short Date"), sUsuario, ctas)
                        Cursor = Cursors.Default
                        If resultado = 0 Then
                            MsgBox("Transferencia realizada exitosamente", MsgBoxStyle.Information, "Módulo - Ahorros")
                            Llenar_Dg(Format(Me.dtpFecha.Value, "Short Date"))
                        Else
                            MsgBox("Transferencias no realizadas" + vbCrLf + "Por favor comuniquese con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Ahorros")
                        End If
                    End If
                End If
            Else
                If MsgBox("Desea realizar esta acción." + ctas, MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Módulo - Ahorros") = 6 Then
                    Cursor = Cursors.WaitCursor
                    resultado = Ahorro.TrasnferenciasAutomaticas_Ahorros(Format(Me.dtpFecha.Value, "Short Date"), sUsuario, ctas)
                    Cursor = Cursors.Default
                    If resultado = 0 Then
                        MsgBox("Transferencia realizada exitosamente", MsgBoxStyle.Information, "Módulo - Ahorros")
                        Llenar_Dg(Format(Me.dtpFecha.Value, "Short Date"))
                    Else
                        MsgBox("Transferencias no realizadas" + vbCrLf + "Por favor comuniquese con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Ahorros")
                    End If
                End If
            End If
        Catch ex As Exception
            Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Ahorros")
        End Try
    End Sub
    Protected Sub ImprimirRpt(ByVal Fecha As DateTime)
        Dim Dts As New DataSet
        Dts = Ahorro.RptTransferenciasAutoAhorros(Fecha)
        PFecha = dtpFecha.Value
        Dim ofrm As New frmVisor(Dts, 215, 0)
        ofrm.ShowDialog()
    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        ImprimirRpt(Format(dtpFecha.Value, "Short Date"))
    End Sub
End Class