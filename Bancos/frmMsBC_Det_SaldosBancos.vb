Public Class frmMsBC_Det_SaldosBancos
    Dim Bancos As New wrBancos.wsLibBancos
    Public Sub LlenarCBBancos(ByVal Campos As String, ByVal Orden As String, ByVal Usuario As String, ByVal Pwd As String, ByVal Psucursal As String)
        Dim Dts As New DataSet
        Dts = Bancos.ObtenerCuentaBanco(Campos, "", Orden, Usuario, Pwd, Psucursal)
        Me.cbBancos.DataSource = Dts.Tables(0)
       
    End Sub
    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        Try
            If Me.rbAbono.Checked = False And Me.rbCargo.Checked = False Then
                MsgBox("Seleccione el tipo de movimiento", MsgBoxStyle.Information, "Módulo - Contabilidad")
            Else
                Dim CodTransaccion As Char
                Dim Resultado As Integer
                Dim Dts As New DataSet
                Dim IdctaBanco As String
                IdctaBanco = Me.cbBancos.SelectedValue
                Dts = Bancos.ConsultarBCSaldos_Bancos(0, IdctaBanco, 3, "")
                Dim Id_SaldosBancos As Integer
                Dim IdBanco As Integer
                Dim IdCtaBanco2 As String
                Dim Saldo As Double

                Id_SaldosBancos = IIf(Dts.Tables(0).Rows(0).Item("Id_SaldosBancos") Is DBNull.Value, 0, Dts.Tables(0).Rows(0).Item("Id_SaldosBancos"))
                IdBanco = IIf(Dts.Tables(0).Rows(0).Item("IdBanco") Is DBNull.Value, 0, Dts.Tables(0).Rows(0).Item("IdBanco"))
                IdCtaBanco2 = IIf(Dts.Tables(0).Rows(0).Item("IdCtaBanco") Is DBNull.Value, "", Dts.Tables(0).Rows(0).Item("IdCtaBanco"))
                Saldo = IIf(Dts.Tables(0).Rows(0).Item("Saldo") Is DBNull.Value, "", Dts.Tables(0).Rows(0).Item("Saldo"))
                If Me.rbCargo.Checked = True Then
                    CodTransaccion = "C"
                    'ingresarmos registro
                    Resultado = Bancos.InsertarBCDet_SaldosBancos(Id_SaldosBancos, IdCtaBanco2, CodTransaccion, Me.txtMonto.Text, Format(Me.dtpFecha.Value, "SHORT DATE"), _
                                                             Saldo, Saldo - Me.txtMonto.Text, CStr(Now.Hour) + CStr(Now.Minute), sUsuario, sSucursal, Me.txtRemesa.Text.Trim, "R", _
                                                             "Remesa #" & Me.txtRemesa.Text.Trim)
                    'Actualizamos Saldo de cta. de banco afectada.
                    Bancos.ActualizarBCSaldos_Bancos(IdBanco, IdCtaBanco2, Math.Round(Saldo - Me.txtMonto.Text), Format(Now, "SHORT DATE"))
                ElseIf rbAbono.Checked = True Then
                    CodTransaccion = "A"
                    'ingresarmos registro
                    Resultado = Bancos.InsertarBCDet_SaldosBancos(Id_SaldosBancos, IdCtaBanco2, CodTransaccion, Me.txtMonto.Text, Format(Me.dtpFecha.Value, "SHORT DATE"), _
                                                             Saldo, Saldo + Me.txtMonto.Text, CStr(Now.Hour) + CStr(Now.Minute), sUsuario, sSucursal, Me.txtRemesa.Text.Trim, "R", _
                                                             "Remesa #" & Me.txtRemesa.Text.Trim)
                    'Actualizamos Saldo de cta. de banco afectada.
                    Bancos.ActualizarBCSaldos_Bancos(IdBanco, IdCtaBanco2, Math.Round(Saldo + Me.txtMonto.Text), Format(Now, "SHORT DATE"))
                End If
                If Resultado <> 0 Then
                    MsgBox("Regisro ingresado exitosamente", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Módulo - Contabilidad")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Módulo - Contabilidad")
        End Try
    End Sub
    Private Sub txtMonto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonto.LostFocus
        Try
            Dim Monto As Double
            Monto = CDbl(Me.txtMonto.Text)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Módulo - Contabilidad")
        End Try
    End Sub
    Private Sub frmMsBC_Det_SaldosBancos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbBancos.DisplayMember = "NOM_Cuenta"
        Me.cbBancos.ValueMember = "IdCtaBanco"
        LlenarCBBancos("IdCtaBanco,NOM_Cuenta", "Nom_Banco", sUsuario, sPassword, sSucursal)
    End Sub

 
End Class