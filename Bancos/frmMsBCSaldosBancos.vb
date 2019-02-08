Public Class frmMsBCSaldosBancos
    Dim Bancos As New wrBancos.wsLibBancos
    Public idSaldosBancos As Integer
    Public Sub LlenarCBBancos(ByVal Campos As String, ByVal Orden As String, ByVal Usuario As String, ByVal Pwd As String, ByVal Psucursal As String)
        Dim Dts As New DataSet
        Dts = Bancos.ObtenerCuentaBanco(Campos, "", Orden, Usuario, Pwd, Psucursal)
        Me.cbBancos.DataSource = Dts.Tables(0)
    End Sub
    Dim Id_Banco As Integer
    Public Sub cbBancos_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbBancos.DropDownClosed
        Dim Cta As String
        Dim dts As New DataSet
        Try
            dts = Bancos.ObtenerCuentaBanco("A.idBanco", " A.IdCtaBanco='" & Me.cbBancos.SelectedValue & "'", "A.IdctaBanco", sUsuario, sPassword, sSucursal)
            If dts.Tables(0).Rows.Count > 0 Then
                Me.txtNoCta.Text = Me.cbBancos.SelectedValue
                Id_Banco = dts.Tables(0).Rows(0).Item(0)
            Else
                txtNoCta.Text = 0
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Contabilidad")
        End Try
    End Sub
    Public Function GuardarSaldosBancos(ByVal Idbanco As Integer, ByVal IdctaBanco As String, ByVal Saldo As Double, _
                                   ByVal fechaUltMov As Date)
        Dim Resultado As Integer
        Resultado = Bancos.InsertarBCSaldos_Bancos(Idbanco, IdctaBanco, Saldo, fechaUltMov)
        Return Resultado
    End Function
    Public Function ModificarSaldosBancos(ByVal Idbanco As Integer, ByVal IdctaBanco As String, ByVal Saldo As Double, _
                                   ByVal fechaUltMov As Date)
        Dim Resultado As Integer
        Resultado = Bancos.ActualizarBCSaldos_Bancos(Idbanco, IdctaBanco, Saldo, fechaUltMov)
        Return Resultado
    End Function
    Public Sub ConsultarSaldosBancos(ByVal id_SaldosBancos)
        Try
            Dim Dts As New DataSet
            Dts = Bancos.ConsultarBCSaldos_Bancos(id_SaldosBancos, 0, 2, "")
            If Dts.Tables(0).Rows.Count > 0 Then
                Me.cbBancos.SelectedValue = Dts.Tables(0).Rows(0).Item("IdCtaBanco")
                Me.txtNoCta.Text = Dts.Tables(0).Rows(0).Item("IdCtaBanco")
                Me.txtSaldo.Text = Dts.Tables(0).Rows(0).Item("Saldo")
                Id_Banco = Dts.Tables(0).Rows(0).Item("IdBanco")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Contabilidad")
        End Try
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim Resultado As Integer
        Try
            If btnGuardar.Text = "Guardar" Then
                If Me.txtNoCta.Text.Length > 0 Then
                    Resultado = GuardarSaldosBancos(Id_Banco, Me.txtNoCta.Text.Trim, Me.txtSaldo.Text, Format(Now, "Short Date"))
                    If Resultado <> 0 Then
                        MsgBox("Información ingresada exitosamente.", MsgBoxStyle.Information, "Módulo - Contabilidad")
                    Else
                        MsgBox("Error al ingrear el registro.", MsgBoxStyle.Critical, "Módulo - Contabilidad")
                    End If
                End If
            End If
            If btnGuardar.Text = "Modificar" Then
                If Me.txtNoCta.Text.Length > 0 Then
                    Resultado = ModificarSaldosBancos(Id_Banco, Me.txtNoCta.Text.Trim, Me.txtSaldo.Text, Format(Now, "Short Date"))
                    If Resultado <> 0 Then
                        MsgBox("Información ingresada exitosamente.", MsgBoxStyle.Information, "Módulo - Contabilidad")
                    Else
                        MsgBox("Error al ingrear el registro.", MsgBoxStyle.Critical, "Módulo - Contabilidad")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Contabilidad")
        End Try

    End Sub
    Private Sub frmMsBCSaldosBancos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LlenarCBBancos("IdCtaBanco,NOM_Cuenta", "Nom_Banco", sUsuario, sPassword, sSucursal)
        Me.txtNoCta.Enabled = False
        If Me.btnGuardar.Text <> "Guardar" Then
            ConsultarSaldosBancos(idSaldosBancos)
        End If
    End Sub
End Class