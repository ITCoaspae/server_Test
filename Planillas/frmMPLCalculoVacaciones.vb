Public Class frmMPLCalculoVacaciones
    Protected Planillas As New wrPlanilla.wsLibPlanilla
    Private Sub LlenarDg()
        Dim Dts As New DataSet
        Dts = Planillas.Consultar_PlCalculoVacaciones
        Me.dgVacaciones.DataSource = Dts.Tables(0)
        EncabezadoDg()
    End Sub
    Private Sub EncabezadoDg()
        Me.dgVacaciones.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgVacaciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgVacaciones.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgVacaciones.Columns("ID_VAC").Visible = False
    End Sub
    Private Sub frmMPLCalculoVacaciones_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LlenarDg()
    End Sub


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim Frm As New frmMsPlCalculoVacaciones
            Frm.btnGuardar1.Text = "&Guardar"
            Frm.ShowDialog()
            LlenarDg()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            If Me.dgVacaciones.CurrentRow.Index <> -1 Then
                Dim Frm As New frmMsPlCalculoVacaciones
                Frm.txtDesde.Text = Me.dgVacaciones.Item("DESDE", Me.dgVacaciones.CurrentRow.Index).Value
                Frm.txtHasta.Text = Me.dgVacaciones.Item("HASTA", Me.dgVacaciones.CurrentRow.Index).Value
                Frm.txtDias.Text = Me.dgVacaciones.Item("DIAS", Me.dgVacaciones.CurrentRow.Index).Value
                Frm.txtPrima.Text = Me.dgVacaciones.Item("PRIMA", Me.dgVacaciones.CurrentRow.Index).Value
                Frm.id_Vac = Me.dgVacaciones.Item("ID_VAC", Me.dgVacaciones.CurrentRow.Index).Value
                Frm.btnGuardar1.Text = "&Modificar"
                Frm.ShowDialog()
                LlenarDg()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If Me.dgVacaciones.CurrentRow.Index <> -1 Then
                If MsgBox("Desea Eliminar este registro", MsgBoxStyle.YesNo, "Módulo - Planillas") = MsgBoxResult.Yes Then
                    Dim Resultado As Integer
                    Resultado = Planillas.Eliminar_PlCalculoVacaciones(Me.dgVacaciones.Item("ID_VAC", Me.dgVacaciones.CurrentRow.Index).Value)
                    If Resultado <> 0 Then
                        MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information, "Módulo - Planillas")
                    Else
                        MsgBox("El registro no pudo ser eliminado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Information, "Módulo - Planillas")
                    End If
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            Dim Frm As New frmMsPlCalculoVacaciones
            Frm.txtDesde.Text = Me.dgVacaciones.Item("DESDE", Me.dgVacaciones.CurrentRow.Index).Value
            Frm.txtHasta.Text = Me.dgVacaciones.Item("HASTA", Me.dgVacaciones.CurrentRow.Index).Value
            Frm.txtDias.Text = Me.dgVacaciones.Item("DIAS", Me.dgVacaciones.CurrentRow.Index).Value
            Frm.txtPrima.Text = Me.dgVacaciones.Item("PRIMA", Me.dgVacaciones.CurrentRow.Index).Value

            Frm.btnGuardar1.Enabled = False
            Frm.ShowDialog()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
