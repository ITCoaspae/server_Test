Public Class frmMsDatosCheque
    Dim bancos As New wrBancos.wsLibBancos
    Dim caja As New wrCaja.wsLibCaja
#Region "Propiedades"
    Dim vIdBanco As Integer
    Dim vNoCuenta As String
    Dim vNoReserva As String
    Dim vNoCheque As String
    Dim vBanco As String
    Dim vNoPagosRealizados As Integer
    Dim vMontoPagosRealizados As Double

    Public Property idBanco() As Integer
        Get
            idBanco = vIdBanco
        End Get
        Set(ByVal value As Integer)
            vIdBanco = value
        End Set
    End Property
    Public Property noCuenta() As String
        Get
            noCuenta = vNoCuenta
        End Get
        Set(ByVal value As String)
            vNoCuenta = value
        End Set
    End Property
    Public Property noReserva() As String
        Get
            noReserva = vNoReserva
        End Get
        Set(ByVal value As String)
            vNoReserva = value
        End Set
    End Property
    Public Property noCheque() As String
        Get
            noCheque = vNoCheque
        End Get
        Set(ByVal value As String)
            vNoCheque = value
        End Set
    End Property
    Public Property banco() As String
        Get
            banco = vBanco
        End Get
        Set(ByVal value As String)
            vBanco = value
        End Set
    End Property
    Public Property NoPagosRealizados() As Integer
        Get
            NoPagosRealizados = vNoPagosRealizados
        End Get
        Set(ByVal value As Integer)
            vNoPagosRealizados = value
        End Set
    End Property
    Public Property MontoPagosRealizados() As Integer
        Get
            MontoPagosRealizados = vMontoPagosRealizados
        End Get
        Set(ByVal value As Integer)
            vMontoPagosRealizados = value
        End Set
    End Property

#End Region
    Protected Function consultarBanco(ByVal opcion As Integer, ByVal idBanco As Integer) As DataSet
        Dim dts As New DataSet
        If opcion = 1 Then
            dts = bancos.ObtenerBanco("IdBanco,Nom_Banco", "", "Nom_Banco", sUsuario, sPassword, sSucursal)
        ElseIf opcion = 2 Then
            dts = bancos.ObtenerBanco("IdBanco,Nom_Banco", "idBanco = '" & idBanco & "'", "Nom_Banco", sUsuario, sPassword, sSucursal)
        End If
        Return dts
    End Function
    Private Sub TextBox3_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdBanco.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Bancos"
        Dim ds As New Data.DataSet, dr As DataRow
        Try

            ds = consultarBanco(1, 0)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()



            If frm.Resultado.Trim = "" Then   'Filtrar Registros

            ElseIf frm.Resultado.Trim <> "" Then
                txtIdBanco.Text = frm.Resultado
                txtBanco.Text = frm.Resultado2
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Bancos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtIdBanco_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIdBanco.Validating
        If Me.txtIdBanco.Text.Length > 0 Then
            Me.txtBanco.Text = consultarBanco(2, Me.txtIdBanco.Text.Trim).Tables(0).Rows(0).Item("Nom_Banco")
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If Me.txtIdBanco.Text.Length > 0 And
        Me.txtNoCheque.Text.Length > 0 And
        Me.txtNoReserva.Text.Length > 0 And
        Me.txtNoCtaBancaria.Text.Length > 0 Then

                Dim dtsTransaccionesCheque As New DataSet
                dtsTransaccionesCheque = caja.consultarTransaccionesCheque(txtIdBanco.Text,
                                                                          txtNoCheque.Text, txtNoCtaBancaria.Text,
                                                                          txtNoReserva.Text, Format(Now, "short date")
                                                                          )
                If dtsTransaccionesCheque.Tables.Count > 0 Then
                    If dtsTransaccionesCheque.Tables(0).Rows.Count > 0 Then
                        If dtsTransaccionesCheque.Tables(0).Rows(0).Item("NoTransacciones") = 0 Then
                            NoPagosRealizados = 1
                            MontoPagosRealizados = txtMonto.Value
                        Else
                            NoPagosRealizados = dtsTransaccionesCheque.Tables(0).Rows(0).Item("NoTransacciones") + 1
                            MontoPagosRealizados = txtMonto.Value - dtsTransaccionesCheque.Tables(0).Rows(0).Item("Monto")
                        End If
                    End If
                Else
                    NoPagosRealizados = 1
                    MontoPagosRealizados = txtMonto.Value
                End If
                idBanco = Me.txtIdBanco.Text.Trim
                noCheque = Me.txtNoCheque.Text.Trim
                noCuenta = Me.txtNoCtaBancaria.Text.Trim
                noReserva = Me.txtNoReserva.Text.Trim
                banco = Me.txtBanco.Text.Trim
            End If
            Me.Close()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class