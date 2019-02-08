Public Class frmRemesaCheques
    Dim caja As New wrCaja.wsLibCaja
    Dim conta As New wrConta.wsLibContab
    Dim bancos As New wrBancos.wsLibBancos
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim dta As New DataSet
    Private Sub llenarCbSucursal()
        Dim dts As New DataSet
        dts = Asociados.ConsultarSucursales("codSucursal,nom_sucursal", " codSucursal = '" & sSucursal & "' ", "nom_sucursal", sUsuario, sPassword, sSucursal)
        cbSucursal.DataSource = dts.Tables(0)
        cbSucursal.DisplayMember = "nom_sucursal"
        cbSucursal.ValueMember = "codSucursal"
    End Sub
    Private Sub MetroButton2_Click(sender As Object, e As EventArgs)
        Try
            Dim dts As New DataSet
            dta = caja.ObtenerChequesARemesar(dtpFecMovRemesar.Value.ToShortDateString, cbSucursal.SelectedValue, CheckBox1.Checked)
            Dim col As New DataColumn
            col.ColumnName = "Seleccionar"
            col.DataType = GetType(Boolean)
            col.DefaultValue = False
            dta.Tables(0).Columns.Add(col)
            fgR.DataSource = dta.Tables(0)
            fgR.Cols.Item("IdBoveda").Visible = False
            fgR.Cols.Item("Correlativo").Visible = False
            fgR.Cols.Item("IdBanco").Visible = False
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
    Dim mensaje As String
    Private Function validarDatoRemesa() As Boolean
        Dim completo As Boolean = True
        mensaje = "Los siguientes campos son requeridos: "
        If txtFolio.Text.Trim.Length = 0 Then
            mensaje = mensaje & vbCrLf & " - Folio"
            completo = False
        ElseIf txtNoComprobante.Text.Trim.Length = 0 Then
            mensaje = mensaje & vbCrLf & " - No. de comprobante"
            completo = False
        ElseIf txtNombreCta.Text.Trim.Length = 0 Then
            mensaje = mensaje & vbCrLf & " - Nombre de cuenta"
            completo = False
        End If
        Return completo
    End Function
    Private Sub btnRemesar_Click(sender As Object, e As EventArgs) Handles btnRemesar.Click
        Dim Correlativo As Integer
        Dim Estado As Boolean
        Dim NumPartida As String
        Dim IdBoveda As String
        Dim IdBanco As Integer
        Dim codTransaccion As Integer

        Dim TotalCheques As Double = 0
        Dim CantidadCheques As Integer = 0
        '
        Try
            If validarDatoRemesa() = True Then

                If CInt(cbTipoTransaccion.SelectedValue) <= 0 Then
                    MsgBox("Debe selecciona el Banco.", MsgBoxStyle.Information)
                    cbTipoTransaccion.Focus()
                    Exit Sub
                End If


                NumPartida = conta.generarNumeroPartida(2, "DR", dtpFecMovRemesar.Value.Month, dtpFecMovRemesar.Value.Year)
                codTransaccion = cbTipoTransaccion.SelectedValue

                If fgR.Rows.Count > 0 Then
                    For i As Integer = 1 To fgR.Rows.Count - 1 'dta.Tables(0).Rows.Count - 1
                        'fgR.Rows(i).Item("Seleccionar") = True
                        'MsgBox(fgR.Item(i, "remesado"))
                        If fgR.Rows(i).Item("Seleccionar") = True Then
                            If fgR.Item(i, "Remesado") = False And fgR.Item(i, "Anulado") = False Then
                                Correlativo = fgR.Item(i, "Correlativo") 'fgR.Rows(i).Item("Correlativo") 'dta.Tables(0).Rows(i).Item("Correlativo")
                                IdBoveda = fgR.Item(i, "IdBoveda") 'dta.Tables(0).Rows(i).Item("IdBoveda")
                                IdBanco = fgR.Item(i, "IdBanco") 'dta.Tables(0).Rows(i).Item("IdBanco")
                                '----------------------------------------------------------------------------------------------
                                'temporal
                                caja.ActualizarChequesRemesar(Correlativo, 1, 0, dtpFecMovRemesar.Value.ToShortDateString,
                                                              IdBoveda, sUsuario, dtpFecMovRemesar.Value.ToShortTimeString,
                                                              NumPartida, codTransaccion, IdBanco,
                                                              0, 0, txtFolio.Text.Trim, txtNoComprobante.Text,
                                                              txtNombreCta.Text, TextBox1.Text.ToUpper)
                                '----------------------------------------------------------------------------------------------

                                TotalCheques = TotalCheques + fgR.Item(i, "MontoCheque")  'dta.Tables(0).Rows(i).Item("MontoCheque")
                                CantidadCheques = CantidadCheques + 1
                            End If
                        End If


                        'If dta.Tables(0).Rows(i).Item("Seleccionar") = True Then
                        '    Correlativo = dta.Tables(0).Rows(i).Item("Correlativo")
                        '    IdBoveda = dta.Tables(0).Rows(i).Item("IdBoveda")
                        '    IdBanco = dta.Tables(0).Rows(i).Item("IdBanco")
                        '    caja.ActualizarChequesRemesar(Correlativo, 1, 0, dtpFecMovRemesar.Value.ToShortDateString,
                        '                                  IdBoveda, sUsuario, dtpFecMovRemesar.Value.ToShortTimeString,
                        '                                  NumPartida, codTransaccion, IdBanco,
                        '                                  0, 0, txtFolio.Text.Trim, txtNoComprobante.Text,
                        '                                  txtNombreCta.Text, TextBox1.Text.ToUpper)

                        '    TotalCheques = TotalCheques + dta.Tables(0).Rows(i).Item("MontoCheque")
                        '    CantidadCheques = CantidadCheques + 1

                        'End If
                    Next i

                    '----------------------------------------------------------------------------------------------
                    'temporal
                    caja.ActualizarChequesRemesar(Correlativo, 1, 1, dtpFecMovRemesar.Value.ToShortDateString,
                                                  IdBoveda, sUsuario, dtpFecMovRemesar.Value.ToShortTimeString,
                                                  NumPartida, codTransaccion, IdBanco, TotalCheques,
                                                  CantidadCheques, txtFolio.Text.Trim, txtNoComprobante.Text,
                                                  txtNombreCta.Text, TextBox1.Text.ToUpper)
                    '----------------------------------------------------------------------------------------------
                    MsgBox("El Proceso se realizo Correctamente.", MsgBoxStyle.Information)
                    MetroButton2_Click(Nothing, Nothing)
                Else
                    MsgBox("No hay cheques para Remesar, favor de veriricar", MsgBoxStyle.Information)
                    Exit Sub
                End If
            Else
                MsgBox(mensaje, MsgBoxStyle.Critical)
            End If


        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAnular_Click(sender As Object, e As EventArgs) Handles btnAnular.Click
        Dim Correlativo As Integer
        Dim Estado As Boolean
        Dim NumPartida As String
        Dim IdBoveda As String
        'Dim dta As New DataSet
        Try
            NumPartida = conta.generarNumeroPartida(2, "DR", dtpFecMovRemesar.Value.Month, dtpFecMovRemesar.Value.Year)
            If fgR.Rows.Count > 0 Then
                For i As Integer = 0 To dta.Tables(0).Rows.Count - 1
                    If dta.Tables(0).Rows(i).Item("Seleccionar") = True Then
                        Correlativo = dta.Tables(0).Rows(i).Item("Correlativo")
                        IdBoveda = dta.Tables(0).Rows(i).Item("IdBoveda")
                        caja.AnularChequesBoveda(Correlativo, 0, NumPartida, sUsuario, dtpFecMovRemesar.Value.ToShortTimeString, dtpFecMovRemesar.Value.ToShortDateString, IdBoveda)
                    End If
                Next i
                caja.AnularChequesBoveda(Correlativo, 1, NumPartida, sUsuario, dtpFecMovRemesar.Value.ToShortTimeString, dtpFecMovRemesar.Value.ToShortDateString, IdBoveda)
                MsgBox("El Proceso se realizo Correctamente.", MsgBoxStyle.Information)
                MetroButton2_Click(Nothing, Nothing)
            Else
                MsgBox("No hay cheques para Remesar, favor de veriricar", MsgBoxStyle.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub llenarCbTransacciones(ByVal opcion As Integer, ByVal codTransaccion As Integer)
        Dim Dts As New DataSet
        Me.cbTipoTransaccion.DisplayMember = "Descripcion"
        Me.cbTipoTransaccion.ValueMember = "codTransaccion"
        Try
            Dts = Bancos.ConsultarBCCatTransacciones_Boveda(opcion, codTransaccion)
            If Dts.Tables.Count > 0 Then
                If Dts.Tables(0).Rows.Count > 0 Then
                    Me.cbTipoTransaccion.DataSource = Dts.Tables(0)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Bóveda")
        End Try
    End Sub
    Private Sub frmRemesaCheques_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenarCbSucursal()
        llenarCbTransacciones(1, 0)
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Try
            Dim dts As New DataSet
            dta = caja.ObtenerChequesARemesar(dtpFecMovRemesar.Value.ToShortDateString, cbSucursal.SelectedValue, CheckBox1.Checked)
            Dim col As New DataColumn
            col.ColumnName = "Seleccionar"
            col.DataType = GetType(Boolean)
            col.DefaultValue = False
            dta.Tables(0).Columns.Add(col)
            fgR.DataSource = dta.Tables(0)
            fgR.Cols.Item("IdBoveda").Visible = False
            fgR.Cols.Item("Correlativo").Visible = False
            fgR.Cols.Item("IdBanco").Visible = False
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class