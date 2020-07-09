Public Class frmMsBC_CatTransaccionesBoveda
    Dim Bancos As New wrBancos.wsLibBancos
    Dim Contabilidad As New wrConta.wsLibContab
    Dim Asociados As New wrAsociados.wsLibAsoc
    Public Accion As Integer '1=insertar,2=Modificar,3Consultar
    Public CodTransaccion As Integer
#Region "Metodos"
    
    Public Sub SoloLectura()

        Me.btnGuardar.Enabled = False
        Me.txtDescripcion.ReadOnly = True
    End Sub
    Public Sub Limpiar()
       
        Me.txtDescripcion.Text = ""
    End Sub
#End Region
#Region "Eventos"

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim Resultado As Integer
            Dim tipoMov As String
            If cbTipoMov.SelectedIndex = 0 Then
                tipoMov = "A"
            ElseIf cbTipoMov.SelectedIndex = 1 Then
                tipoMov = "C"
            End If
            If Accion = 1 Then

                Resultado = Bancos.InsertarBcCatTransacciones_Boveda(
                                                                     Me.txtDescripcion.Text, tipoMov, Me.txtPrefijo.Text.Trim,
                                                                     sUsuario, sPassword, sSucursal
                                                                     )
                If Resultado <> 0 Then
                    MsgBox("Registro ingresado exitosamente.", MsgBoxStyle.Information, "Boveda")
                End If
            ElseIf Accion = 2 Then
                Resultado = Bancos.ModificarBcCatTransacciones_Boveda(CodTransaccion, txtDescripcion.Text, tipoMov, Me.txtPrefijo.Text.Trim,
                                                                      sUsuario, sPassword, sSucursal
                                                                      )
                If Resultado <> 0 Then
                    MsgBox("Registro modificado exitosamente", MsgBoxStyle.Information, "Boveda")
                End If
            End If
            Limpiar()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsBC_CatTransaccionesBoveda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmMsBC_CatTransaccionesBoveda_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

#End Region






End Class