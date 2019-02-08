Public Class frmMCierreMesCompra
    Dim contabilidad As New wrConta.wsLibContab
    Dim vAccion, vMes, vAnnio As Integer

    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property mes() As Integer
        Get
            Return vMes
        End Get
        Set(ByVal value As Integer)
            vMes = value
        End Set
    End Property
    Public Property annio() As Integer
        Get
            Return vAnnio
        End Get
        Set(ByVal value As Integer)
            vAnnio = value
        End Set
    End Property

    Private Sub btnBuscar1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If accion = 1 Then
                If consultarMesesCerrados(Me.cbMes.SelectedIndex + 1, Me.txtAnio.Value) = False Then
                    If (contabilidad.insertarCaCompraCierreMes(cbMes.SelectedIndex + 1, txtAnio.Value,
                                                             chkCerrado.Checked, sUsuario,
                                                             Format(Now, "short date"), txtBloque.Value)) > 0 Then
                        MsgBox("Mes cerrado exitosamente", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("El mes ya se encuentra cerrado.", MsgBoxStyle.Critical)
                    Me.Close()
                End If
            ElseIf accion = 2 Then
                If (contabilidad.actualizarCaCompraCierreMes(cbMes.SelectedIndex + 1, txtAnio.Value,
                                                          chkCerrado.Checked, sUsuario,
                                                          Format(Now, "short date"), txtBloque.Value)) > 0 Then
                    MsgBox("Mes modificado exitosamente", MsgBoxStyle.Information)
                    Me.Close()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Public Function consultarMesesCerrados(ByVal mes As Integer, ByVal annio As Integer) As Boolean
        Dim dts As New DataSet
        dts = contabilidad.consultarCaCompraCierreMes(mes, annio, 6, txtBloque.Value)
        If dts.Tables(0).Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Sub frmMCierreMesCompra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtAnio.Value = Now.Year
    End Sub
End Class