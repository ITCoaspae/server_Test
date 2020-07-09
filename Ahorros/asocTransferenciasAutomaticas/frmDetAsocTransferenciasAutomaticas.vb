Public Class frmDetAsocTransferenciasAutomaticas
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim ahorros As New wrAhorro.wsLibAhorro
    Private vCodTransferencia, vAccion As Integer


    Public Property accion() As Integer ' 1 insertar,2modificar,3 consultar
        Get
            Return vAccion
        End Get
        Set(value As Integer)
            vAccion = value
        End Set
    End Property


    Public Property codTransferencia() As Integer
        Get
            Return Me.vCodTransferencia
        End Get
        Set(ByVal Value As Integer)
            Me.vCodTransferencia = Value
        End Set
    End Property

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If accion = 1 Then
            If (ahorros.insertarAsocTransferenciasAutomaticas(cbOrigen.SelectedValue.ToString, cbDestino.SelectedValue.ToString,
                                                      dtpFechaTran.Value.ToShortDateString, txtMonto.Value,
                                                      chkActivo.Checked, sUsuario, Now, My.Computer.Name.ToString,
                                                              sUsuario, sPassword, sSucursal)) > 0 Then
                MsgBox("Registro ingrsado exitosamente", MsgBoxStyle.Information)
            Else
                 MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If
        ElseIf accion = 2 Then
            If (ahorros.modificarAsocTransferenciasAutomaticas(cbOrigen.SelectedValue, cbDestino.SelectedValue,
                                                               dtpFechaTran.Value.ToShortDateString, txtMonto.Value,
                                                               chkActivo.Checked, sUsuario,
                                                               Now, My.Computer.Name.ToString, codTransferencia,
                                                               sUsuario, sPassword, sSucursal)) Then
                MsgBox("Registro ingrsado exitosamente", MsgBoxStyle.Information)
            Else
                 MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If
        End If

    End Sub
    Private Sub llenarCuentasOrigen()
        Try
            Dim dts As New DataSet
            cbOrigen.DisplayMember = "NoCuenta"
            Me.cbOrigen.ValueMember = "NoCuenta"
            dts = ahorros.ConsultarCuentaAhorro("Nocuenta", " dui ='" & txtDui.Text & "'and left(codtipoahorro,1)in ('3','4','5')  ", "Nocuenta", sUsuario, sPassword, sSucursal)
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    Me.cbOrigen.DataSource = dts.Tables(0)
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub llenarCuentasDestino()
        Try
            Dim dts As New DataSet
            Dim rows As DataRow()
            Dim dtFiltro As New DataTable
            cbDestino.DisplayMember = "Cuenta"
            cbDestino.ValueMember = "Cuenta"
            dts = asociados.ReporteCuentasAsociado(txtDui.Text.Trim, True, sUsuario, sPassword, sSucursal)
            dts.Tables(0).Select()
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    dtFiltro = dts.Tables(0).Clone
                    rows = dts.Tables(0).Select("Saldo>0", "Cuenta")
                    For Each dr As DataRow In rows
                        dtFiltro.ImportRow(dr)
                    Next
                    Me.cbDestino.DataSource = dtFiltro
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError)
        End Try
    End Sub

    Private Sub frmDetAsocTransferenciasAutomaticas_Load(sender As Object, e As EventArgs) Handles Me.Load
        If accion = 2 Then
            Dim dts As New DataSet
            dts = ahorros.consultarAsocTransferenciasAutomaticas(codTransferencia, "", 6, "", "", "", Now, sUsuario, sPassword, sSucursal)
            If dts.Tables(0).Rows.Count > 0 Then
                txtDui.Text = dts.Tables(0).Rows(0).Item("dui").ToString.Trim
                lblAsociado.Text = dts.Tables(0).Rows(0).Item("Asociado").ToString
                txtDui.Enabled = False
                llenarCuentasDestino()
                llenarCuentasOrigen()
                cbDestino.SelectedValue = dts.Tables(0).Rows(0).Item("noCuentaDestino").ToString
                cbOrigen.SelectedValue = dts.Tables(0).Rows(0).Item("noCuentaOrigen").ToString
                txtMonto.Value = dts.Tables(0).Rows(0).Item("MontoTransferencia")
                dtpFechaTran.Value = dts.Tables(0).Rows(0).Item("fechaTransferencia")
                chkActivo.Checked = dts.Tables(0).Rows(0).Item("Activo")
                chkActivo.Enabled = False
            End If
        ElseIf accion = 1 Then
            chkActivo.Checked = True
            chkActivo.Enabled = False
        End If
    End Sub

    Private Sub txtDui_Validated(sender As Object, e As EventArgs) Handles txtDui.Validated
        Try
            If accion = 1 Then
                llenarCuentasDestino()
                llenarCuentasOrigen()
            End If

        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmDetAsocTransferenciasAutomaticas_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class