Imports System.IO
Public Class frmArchivoBCR
    Dim Prestamos As New wrPrestamo.wsLibPrest
#Region "Metodos"
    Private Sub EstiloDG()
        Me.dgDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgDatos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgDatos.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub
    Protected Sub LlenarDg(ByVal FechaInicio As DateTime, ByVal FechaFin As DateTime)
        Dim Dts As New DataSet
        Dts = Prestamos.GenerarDocumento_BCR(FechaInicio, FechaFin)
        If Dts.Tables.Count > 0 Then
            If Dts.Tables(0).Rows.Count > 0 Then
                Me.dgDatos.DataSource = Dts.Tables(0)
            End If
        End If
    End Sub
#End Region
#Region "Eventos"
    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) 


    End Sub

    Private Sub btnGenerar1_Click(sender As Object, e As EventArgs) Handles btnGenerar1.Click
        Dim Dts As New DataSet
        Try
            LlenarDg(Format(Me.dtpFechaInicio.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
            EstiloDG()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim saveFileDialog1 As New SaveFileDialog()
        Try
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
            saveFileDialog1.Title = "Guardar como"
            saveFileDialog1.ShowDialog()
            If saveFileDialog1.FileName <> "" Then
                Dim Escritor As New StreamWriter(saveFileDialog1.FileName)
                Dim Linea As String = Nothing
                With Me.dgDatos
                    For i = 0 To .RowCount - 1
                        Linea = .Rows(i).Cells(0).Value & ";" &
                        .Rows(i).Cells(1).Value & ";" &
                        .Rows(i).Cells(2).Value & ";" &
                        .Rows(i).Cells(3).Value & ";" &
                        .Rows(i).Cells(4).Value & ";" &
                        .Rows(i).Cells(5).Value & ";" &
                        .Rows(i).Cells(6).Value & ";" &
                        .Rows(i).Cells(7).Value & ";" &
                        .Rows(i).Cells(8).Value & ";" &
                        .Rows(i).Cells(9).Value & ";" &
                        .Rows(i).Cells(10).Value & ";" &
                        .Rows(i).Cells(11).Value & ";" &
                        .Rows(i).Cells(12).Value & ";" &
                        .Rows(i).Cells(13).Value & ";" &
                        .Rows(i).Cells(14).Value '& ";" & _
                        ' .Rows(i).Cells(15).Value & ";" & _
                        ' .Rows(i).Cells(16).Value & ";" & _
                        ' .Rows(i).Cells(17).Value & ";" & _
                        ' .Rows(i).Cells(18).Value & ";" & _
                        ' .Rows(i).Cells(19).Value & ";" & _
                        ' .Rows(i).Cells(20).Value & ";" & _
                        ' .Rows(i).Cells(21).Value
                        If Linea.Length > 0 Then
                            Escritor.WriteLine(Linea)
                        End If

                    Next
                    Escritor.Flush()
                    Escritor.Close()
                    MsgBox("Archivo creado exitosamente.", MsgBoxStyle.Information, "Créditos - Prestamos")
                End With
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
End Class