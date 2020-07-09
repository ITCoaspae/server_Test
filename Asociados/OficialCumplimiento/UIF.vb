Imports MetroFramework

Public Class UIF
    Dim asociados As New wrAsociados.wsLibAsoc
#Region "Metodos"
    Public Sub llenarSucursal()
        Try
            Dim dts As New DataSet
            dts = asociados.ConsultarSucursales("Nom_Sucursal,CodSucursal", "", "Nom_Sucursal", sUsuario, sPassword, sSucursal)
            Me.cbSucursal.DisplayMember = "Nom_Sucursal"
            Me.cbSucursal.ValueMember = "CodSucursal"
            Me.cbSucursal.DataSource = dts.Tables(0)
        Catch ex As Exception
            MetroMessageBox.Show(Me, "Error en la recuperación de datos (Sucursales)", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub


#End Region
#Region "Eventos"
    Private Sub UIF_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            llenarSucursal()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

    End Sub

    Private Sub UIF_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
#End Region

End Class