Imports Microsoft.Reporting.WinForms
Public Class frmTodasCuentas
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim ingreso As Integer

    Private Sub txtDui_DoubleClick(sender As Object, e As EventArgs) Handles txtDui.DoubleClick
        Try
            Dim dts As New DataSet
            Dim ofrm As New frmAGenerico
            dts = asociados.ConsultarAsociado("DUI, concat(rtrim(Nombres),' ',rtrim(Apellido1),' ',rtrim(Apellido2),' ',rtrim(ApellidoCas))[Asociado]", "", "DUI", sUsuario, sPassword, sSucursal)
            ofrm.Text = "Mostrar Asociados"
            ofrm.Datos = dts
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then
                Dim sDui As String, sNombre As String
                sDui = ofrm.Resultado.Trim
                sNombre = ofrm.Resultado2.Trim
                Me.txtDui.Value = sDui.Trim
                Me.txtNombre.Text = sNombre

            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_LostFocus(sender As Object, e As EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text.Trim <> "" Then
            If ingreso = 0 Then
                '=========================================================================================
                Dim oAsoc As New wrAsociados.wsLibAsoc, ds1 As New Data.DataSet, dr1 As DataRow
                ds1 = oAsoc.ConsultarAsociadoVIP("DUI,Nombre", "DUI='" & Me.txtDui.Text.Trim & "'", "DUI,Nombre", sUsuario, sPassword, sSucursal)
                If ds1.Tables(0).Rows.Count > 0 Then
                    dr1 = ds1.Tables(0).Rows(0)
                    Dim ofrmAut As New frmMsAutorizacion
                    ofrmAut.TipoPermiso = "P"
                    ofrmAut.NumPrograma = "VIP001"
                    ingreso = 1
                    ofrmAut.ShowDialog()
                    If ofrmAut.Autoriza = True Then
                        '=========================================================================================
                        '--------------------- MODIFIACION CLIENTES VIP
                        Dim ds As New Data.DataSet, dr As DataRow
                        Try
                            Me.btnProcesar1.Enabled = True
                            asociados = New wrAsociados.wsLibAsoc
                            ds = asociados.ConsultarAsociado("DUI,concat(rtrim(Nombres),' ',rtrim(Apellido1),' ',rtrim(Apellido2),' ',rtrim(ApellidoCas))[Asociado]", "Dui='" & Me.txtDui.Text.Trim & "'", "DUI", sUsuario, sPassword, sSucursal)
                            If ds.Tables(0).Rows.Count = 1 Then

                                Me.txtNombre.Text = ""
                                dr = ds.Tables(0).Rows(0)
                                Me.txtNombre.Text = dr("Asociado").ToString.ToUpper

                            End If
                            Me.btnProcesar1.Enabled = True
                            'Me.btnProcesar1.Focus()
                        Catch ex As Exception
                            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                            Me.btnProcesar1.Enabled = False
                            Me.txtNombre.Text = ""
                            Me.txtDui.Text = ""
                            ' Me.txtDui.Focus()
                        End Try
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "Seleccionar Usuario que autoriza la consulta del Cliente VIP.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        Me.btnProcesar1.Enabled = False
                    End If
                Else
                    Dim ds2 As New Data.DataSet, dr2 As DataRow
                    Try
                        Me.btnProcesar1.Enabled = True
                        asociados = New wrAsociados.wsLibAsoc
                        ds2 = asociados.ConsultarAsociado("DUI,concat(rtrim(Nombres),' ',rtrim(Apellido1),' ',rtrim(Apellido2),' ',rtrim(ApellidoCas))[Asociado]", "Dui='" & Me.txtDui.Text.Trim & "'", "DUI", sUsuario, sPassword, sSucursal)
                        If ds2.Tables(0).Rows.Count = 1 Then
                            Me.txtNombre.Text = ""
                            dr2 = ds2.Tables(0).Rows(0)
                            Me.txtNombre.Text = dr2("Asociado").ToString.ToUpper
                        End If
                    Catch ex As Exception
                        MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Dim dtsConfiguracionRs As New DataSet
        Dim wActivas As String
        If Me.ChekActivas.Checked = True Then
            wActivas = "Estado = 'A'"
        Else
            wActivas = ""
        End If
        dtsConfiguracionRs = asociados.ConsultarParametros("rutaRs,urlRs,usuarioRs,contraseniaRs", "", " rutaRs", sUsuario, sPassword, sSucursal)
        If dtsConfiguracionRs.Tables(0).Rows.Count > 0 Then

            Dim RUTA As String
            Dim userRPT As String
            Dim pwdRPT As String
            Dim carpetaRs As String
            carpetaRs = My.Settings.CarpetaRS
            RUTA = "/" & carpetaRs & "/rsTodasCtasPrestAsoc"
            Me.rsVISOR.ServerReport.ReportPath = dtsConfiguracionRs.Tables(0).Rows(0).Item("rutaRs")
            Me.rsVISOR.ServerReport.ReportServerUrl = New Uri(dtsConfiguracionRs.Tables(0).Rows(0).Item("urlRs"))
            userRPT = dtsConfiguracionRs.Tables(0).Rows(0).Item("usuarioRs")  'My.Settings.UserRS
            pwdRPT = dtsConfiguracionRs.Tables(0).Rows(0).Item("contraseniaRs") 'My.Settings.PwdRS

            Me.rsVISOR.ServerReport.ReportServerCredentials.NetworkCredentials = New System.Net.NetworkCredential(userRPT, pwdRPT)
            Me.rsVISOR.ServerReport.ReportPath = RUTA

            Dim parametro1 As ReportParameter = New ReportParameter
            Dim parametro2 As ReportParameter = New ReportParameter
            Dim parametro3 As ReportParameter = New ReportParameter
            Dim parametro4 As ReportParameter = New ReportParameter
            parametro1.Name = "dui"
            parametro2.Name = "todos"
            parametro3.Name = "usuario"
            parametro4.Name = "vardpf"
            parametro1.Visible = False
            parametro2.Visible = False
            parametro3.Visible = False
            parametro4.Visible = False
            parametro1.Values.Add(txtDui.Value)

            parametro2.Values.Add(ChekActivas.Checked)
            parametro3.Values.Add(sUsuario.ToUpper)
            parametro4.Values.Add(chkTodos.Checked)

            Dim arrayParametros(3) As ReportParameter
            arrayParametros(0) = parametro1
            arrayParametros(1) = parametro2
            arrayParametros(2) = parametro3
            arrayParametros(3) = parametro4
            Me.rsVISOR.ServerReport.SetParameters(arrayParametros)
            Me.rsVISOR.RefreshReport()
            ingreso = 0
        End If
    End Sub

    Private Sub chkTodos_CheckedChanged(sender As Object, e As EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked = True Then
            Dim ofrmAut As New frmMsAutorizacion
            ofrmAut.TipoPermiso = "P"
            ofrmAut.NumPrograma = "AHN011"
            ofrmAut.ShowDialog()
            If ofrmAut.Autoriza = True Then
                ofrmAut.Autoriza = False
                ofrmAut.Dispose()
            Else
                Me.chkTodos.Checked = False
                ofrmAut.Dispose()
            End If
        End If
    End Sub

    Private Sub frmTodasCuentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtDui_TextChanged(sender As Object, e As EventArgs) Handles txtDui.TextChanged
        ingreso = 0
    End Sub
End Class