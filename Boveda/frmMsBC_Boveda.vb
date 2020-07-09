Public Class frmMsBC_Boveda
    Dim Asociados As New wrAsociados.wsLibAsoc
    Dim Bancos As New wrBancos.wsLibBancos
    Public IdBoveda As Integer
    Public Accion As Integer '1=insertar,2=Modificar,3Consultar
#Region "Metodos"
    Public Sub LlenarCBSucursales(ByVal Campos As String, ByVal Filtro As String, ByVal Orden As String)
        Dim Dts As New DataSet
        Dts = Asociados.ConsultarSucursales(Campos, Filtro, Orden, sUsuario, sPassword, sSucursal)
        Me.cbSucursal.DataSource = Dts.Tables(0)
    End Sub
#End Region
#Region "Eventos"
    Private Sub frmMsBC_Boveda_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Accion = 1 Then
            Me.cbSucursal.DisplayMember = "Nom_Sucursal"
            Me.cbSucursal.ValueMember = "CodSucursal"
            LlenarCBSucursales("CodSucursal,Nom_Sucursal", "", "Nom_Sucursal")
        Else
            Me.Button1.Text = "Modificar"
        End If
        
    End Sub
#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Resultado As Integer
            If Accion = 1 Then
                Resultado = Bancos.InsertarBcBoveda(Me.txtNomBoveda.Text.Trim, Me.cbSucursal.SelectedValue,
                                                    Me.txtSaldo.Text.Trim, Me.txtMontoMin.Text, Me.txtMontoMax.Text,
                                                    sUsuario, Now, sPassword, sSucursal,
                                                     Me.c1nUno.Value, c1nCinco.Value,
                                                     c1nDiez.Value, c1nVeinte.Value,
                                                     c1nCincuenta.Value, c1nCien.Value,
                                                     C1nMonedaUno.Value, c1nFraccion.Value)
                If Resultado <> 0 Then
                    MsgBox("Registro ingresado exitosamente.", MsgBoxStyle.Information, "Boveda")
                End If
            ElseIf Accion = 2 Then
                Resultado = Bancos.ModificarBcBoveda(IdBoveda, Me.txtNomBoveda.Text.Trim, Me.cbSucursal.SelectedValue,
                                                     Me.txtSaldo.Text.Trim, Me.txtMontoMin.Text, txtMontoMax.Text, sUsuario,
                                                     Now, sPassword, sSucursal, 1,
                                                     Me.c1nUno.Value, c1nCinco.Value,
                                                     c1nDiez.Value, c1nVeinte.Value,
                                                     c1nCincuenta.Value, c1nCien.Value,
                                                     C1nMonedaUno.Value, c1nFraccion.Value)
                If Resultado <> 0 Then
                    MsgBox("Registro modificado exitosamente", MsgBoxStyle.Information, "Boveda")
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub c1nUno_Validated(sender As Object, e As EventArgs) Handles c1nUno.Validated
        Me.c1nTotal.Value = total()

    End Sub
    Public Function total() As Double
        Dim total_monedas As Double
        Dim total_billetes As Double
        total_billetes = c1nUno.Value + (c1nCinco.Value * 5) + (c1nDiez.Value * 10) + (c1nVeinte.Value * 20) + (c1nCincuenta.Value * 50) + (c1nCien.Value * 100)
        total_monedas = C1nMonedaUno.Value + c1nFraccion.Value
        Return total_billetes + total_monedas
    End Function

    Private Sub c1nCinco_Validated(sender As Object, e As EventArgs) Handles c1nCinco.Validated
        Me.c1nTotal.Value = total()
    End Sub

    Private Sub c1nDiez_Validated(sender As Object, e As EventArgs) Handles c1nDiez.Validated
        Me.c1nTotal.Value = total()
    End Sub

    Private Sub c1nVeinte_Validated(sender As Object, e As EventArgs) Handles c1nVeinte.Validated
        Me.c1nTotal.Value = total()
    End Sub

    Private Sub c1nCincuenta_Validated(sender As Object, e As EventArgs) Handles c1nCincuenta.Validated
        Me.c1nTotal.Value = total()
    End Sub

    Private Sub c1nCien_Validated(sender As Object, e As EventArgs) Handles c1nCien.Validated
        Me.c1nTotal.Value = total()
    End Sub

    Private Sub C1nMonedaUno_Validated(sender As Object, e As EventArgs) Handles C1nMonedaUno.Validated
        Me.c1nTotal.Value = total()
    End Sub

    Private Sub c1nFraccion_Validated(sender As Object, e As EventArgs) Handles c1nFraccion.Validated
        Me.c1nTotal.Value = total()
    End Sub
End Class