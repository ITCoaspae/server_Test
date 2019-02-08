Public Class frmMsCaPosteoLibretas
    Dim ahorro As New wrAhorro.wsLibAhorro
    Dim asociado As New wrAsociados.wsLibAsoc
    Dim quitarPosteo As Boolean = False
    Dim PostlibretaAnt As Boolean = False
    Protected Sub estiloDg()
        Me.DataGridView1.Columns("correlativo").Visible = False
        Me.DataGridView1.Columns("Posteado").Visible = False
        Me.DataGridView1.Columns("corr_libreta").HeaderText = "Correlativo"
        Me.DataGridView1.Columns("corr_libreta").ReadOnly = True
        Me.DataGridView1.Columns("fecha").ReadOnly = True
        Me.DataGridView1.Columns("codTransaccion").Visible = False
        Me.DataGridView1.Columns("codTipo").ReadOnly = True
        Me.DataGridView1.Columns("saldoAnterior").ReadOnly = True
        If quitarPosteo = False And PostlibretaAnt = False Then
            Me.DataGridView1.Columns("posteo").ReadOnly = True
        End If

        Me.DataGridView1.Columns("monto").ReadOnly = True
        Me.DataGridView1.Columns("saldo").ReadOnly = True
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

    End Sub
    Protected Sub llenardgMovimientos(ByVal noCuenta As String, ByVal correlativoLibreta As String)
        Dim dtsMov As New DataSet
        If DataGridView1.Rows.Count > 0 Then
            DataGridView1.DataSource = Nothing
            DataGridView1.Rows.Clear()
            DataGridView1.Columns.Clear()
        End If

        dtsMov = ahorro.ConsultarAhMovimientos("corr_libreta,correlativo,fecha,codTransaccion,codTipo,saldoAnterior,monto,saldo," &
                                                           "Posteado", " nocuenta = '" & noCuenta & "' and IdLibreta ='" & correlativoLibreta & "'", "Correlativo")

        '    dtsMov = ahorro.movimientosPendientesPostear()


        If dtsMov.Tables.Count > 0 Then
            If dtsMov.Tables(0).Rows.Count > 0 Then
                Me.DataGridView1.DataSource = dtsMov.Tables(0)
                Dim colPost As New DataGridViewCheckBoxColumn
                colPost.Name = "posteo"
                colPost.HeaderText = "posteo"
                Me.DataGridView1.Columns.Add(colPost)
                For Each row As DataGridViewRow In DataGridView1.Rows
                    row.Cells("posteo").Value = IIf(row.Cells("Posteado").Value = "0", False, True)
                Next
                estiloDg()
            End If
        End If
    End Sub
    Private Sub txtNoCuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoCuenta.LostFocus
        Dim dts, dtsParametro As New DataSet
        dts = ahorro.consultarDatosLibreta(txtNoCuenta.Text.Trim)
        Dim hoja As Integer
        Dim maxMovLibreta As Integer
        dtsParametro = asociado.ConsultarParametros("movPagLibreta", "", "movPagLibreta", sUsuario, sPassword, sSucursal)
        If dtsParametro.Tables(0).Rows.Count > 0 Then
            maxMovLibreta = dtsParametro.Tables(0).Rows(0).Item("movPagLibreta")
        End If


        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                txtNoLibreta.Text = dts.Tables(0).Rows(0).Item("NoLibreta").ToString.Trim
                txtCorrLibreta.Text = dts.Tables(0).Rows(0).Item("CorrLibreta")
                txtUltLinea.Text = dts.Tables(0).Rows(0).Item("UltLinea")
                txtHoja.Text = dts.Tables(0).Rows(0).Item("hoja")

                'If txtUltLinea.Text > 0 Then
                '    If dts.Tables(0).Rows(0).Item("UltLinea") Mod maxMovLibreta = 0 Then
                '        txtHoja.Text = CInt(((CInt(dts.Tables(0).Rows(0).Item("UltLinea")) + 1) / maxMovLibreta)) + 1
                '    Else
                '        If ((CInt(dts.Tables(0).Rows(0).Item("UltLinea")) + 1) / maxMovLibreta) = 1 Then
                '            txtHoja.Text = ((CInt(dts.Tables(0).Rows(0).Item("UltLinea")) + 1) / maxMovLibreta)
                '        Else
                '            txtHoja.Text = CInt(((CInt(dts.Tables(0).Rows(0).Item("UltLinea")) + 1) / maxMovLibreta)) + 1
                '        End If
                '    End If
                'Else
                '    txtHoja.Text = 1
                'End If
                'txtHoja.Text = IIf(dts.Tables(0).Rows(0).Item("hoja") = 0, 1, dts.Tables(0).Rows(0).Item("hoja"))
                c1nSaldo.Value = dts.Tables(0).Rows(0).Item("Saldo")
                txtCodTipoAhorro.Text = dts.Tables(0).Rows(0).Item("codTipoAhorro")
                txtTipoAhorro.Text = dts.Tables(0).Rows(0).Item("descripcion")
                If quitarPosteo = False Then
                    llenardgMovimientos(txtNoCuenta.Text.Trim, txtCorrLibreta.Text.Trim)
                End If
            End If
        End If
    End Sub

    Private Sub txtDui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.Click
        Try
            Dim Valor As String
            Valor = IIf(txtDui.ValueIsDbNull, "", txtDui.Value)
            If Valor.Trim = "" Then
                Me.txtDui.SelectionStart = 0
                Me.txtDui.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Try
            Dim ofrm As New frmAGenerico
            Dim ds As New DataSet
            ds = asociado.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "", "DUI", sUsuario, sPassword, sSucursal)
            ofrm.Text = "Mostrar Asociados"
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then
                Dim sDui As String, sNombre As String
                sDui = ofrm.Resultado.Trim
                sNombre = ofrm.Resultado2.Trim & " " & ofrm.Resultado3.Trim & " " & ofrm.Resultado4.Trim
                Me.txtDui.Value = sDui.Trim
                txtAsociado.Text = sNombre
            End If
        Catch ex As Exception
            Dim sd As String
            sd = ex.Message
            sd = ex.Source
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        Try
            If txtDui.Text.Trim.Equals("") = False Then
                Dim ds As New Data.DataSet, dr As DataRow

                ds = asociado.ConsultarAsociado("Nombres,Apellido1,Apellido2,ApellidoCas", "Dui='" & Me.txtDui.Text.Trim & "'", "DUI", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtAsociado.Text = dr("Nombres") & " " & dr("Apellido1") & " " & dr("Apellido2")
                End If
            End If

        Catch ex As Exception
            Dim sd As String
            sd = ex.Message
            sd = ex.Source
        End Try
    End Sub

    Private Sub frmMsCaPosteoLibretas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtDui.Enabled = True
        txtDui.ReadOnly = False
        chkQuitarPosteo.Enabled = False
    End Sub

    Private Sub btnPostear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtNoLibreta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoLibreta.LostFocus
        llenardgMovimientos(txtNoCuenta.Text.Trim, txtCorrLibreta.Text.Trim)
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If Me.DataGridView1.Rows.Count > 0 Then
            If Me.DataGridView1.Columns(e.ColumnIndex).Name = "posteo" Then
                If quitarPosteo = True Then
                    If Me.DataGridView1.Item("posteo", e.RowIndex).Value = True Then
                        ahorro.QuitarPosteos(Me.DataGridView1.Item("correlativo", e.RowIndex).Value, "0")
                    Else
                        ahorro.QuitarPosteos(Me.DataGridView1.Item("correlativo", e.RowIndex).Value, "1")
                    End If
                    Call txtNoCuenta_LostFocus(sender, e)
                End If
            End If
        End If
    End Sub

    Private Sub btnQuitarPosteo_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnIniLibreta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub chkQuitarPosteo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkQuitarPosteo.CheckedChanged
        If Me.chkQuitarPosteo.Checked = True Then
            If quitarPosteo = True Then
                If Me.DataGridView1.Rows.Count > 0 Then
                    For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                        If Me.DataGridView1.Item("posteo", i).Value = True Then
                            ahorro.QuitarPosteos(Me.DataGridView1.Item("correlativo", i).Value, "0")
                            Me.DataGridView1.Item("posteo", i).Value = False
                        End If
                    Next
                    Me.quitarPosteo = False
                    Me.chkQuitarPosteo.Enabled = False
                    Call txtNoCuenta_LostFocus(sender, e)
                End If
            End If
        End If

    End Sub


    Private Sub btnIniLibreta1_Click(sender As Object, e As EventArgs) Handles btnIniLibreta1.Click
        'Try
        Try
            Dim dts As New DataSet
            dts = ahorro.InicializacionLibreta(Me.txtDui.Value, Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
            vNocta = txtNoCuenta.Text.Trim
            vDui = txtDui.Value
            'If Mid(txtCodTipoAhorro.Text.Trim, 1, 1) = sifLib.Ahorro.clsAhorros.tiposAhorro.programado Then

            '    Dim ofrm As New frmVisor(dts, 105, 0)

            '    ofrm.Show()
            'Else
            Dim ofrm As New frmVisor(dts, 18, 0)
                ofrm.Show()
            'End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
            End Try
        '    Dim ds As New Data.DataSet, dsTmp As New DataSet, vResp As String, dr As DataRow, dsPosteo As New DataSet, oAsoc As New wrAsociados.wsLibAsoc, vLineaMax As Integer, pMaxPag As Integer
        '    ds = asociado.ConsultarParametros("MaxNumLibreta", "", "MaxNumLibreta", sUsuario, sPassword, sSucursal)
        '    If ds.Tables(0).Rows.Count > 0 Then
        '        dr = ds.Tables(0).Rows(0)
        '        vLineaMax = dr("MaxNumLibreta")
        '        pMaxPag = vLineaMax - 12
        '    End If
        '    dsTmp = ahorro.ConsultaPosteo("a.*", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Posteado='0'", "a.Num", sUsuario, sPassword, sSucursal)
        '    If dsTmp.Tables(0).Rows.Count > 0 Then 'Hay movimientos pendientes
        '        If txtUltLinea.Text < pMaxPag Then
        '            vResp = ahorro.PosteoMovimientos(True, Me.txtDui.Text.Trim, Me.txtNoCuenta.Text.Trim, "", 0, Me.c1nSaldo.Value, False, txtCorrLibreta.Text, False, sUsuario, sPassword, sSucursal)
        '        Else
        '            vResp = ahorro.PosteoMovimientos(True, Me.txtDui.Text.Trim, Me.txtNoCuenta.Text.Trim, "", 0, Me.c1nSaldo.Value, False, txtCorrLibreta.Text, True, sUsuario, sPassword, sSucursal)
        '        End If
        '        If vResp Is Nothing Then
        '            ds = ahorro.InicializacionLibreta(Me.txtDui.Value, Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
        '            If txtUltLinea.Text < pMaxPag Then
        '                dsPosteo = ahorro.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta=1 and a.IdLibreta=" & txtCorrLibreta.Text & " and a.Corr_Libreta<=" & pMaxPag & "", "a.Num", sUsuario, sPassword, sSucursal)
        '            Else
        '                dsPosteo = ahorro.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta=1 and a.IdLibreta=" & txtCorrLibreta.Text & "", "a.Num", sUsuario, sPassword, sSucursal)
        '            End If
        '            Dim ofrm As New frmMsAhInicializacionLibreta
        '            ofrm.vNoExistMov = False
        '            ofrm.TipoAhorro = txtCodTipoAhorro.Text
        '            ofrm.dsPosteo = dsPosteo
        '            vNocta = Me.txtNoCuenta.Text.Trim
        '            vDui = Me.txtDui.Text.Trim
        '            ofrm.ds = ds
        '            ofrm.ShowDialog()
        '        Else
        '            If vResp.Trim = "" Then
        '                ds = ahorro.InicializacionLibreta(Me.txtDui.Value, Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
        '                If txtUltLinea.Text < pMaxPag Then
        '                    dsPosteo = ahorro.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta=1 and a.IdLibreta=" & txtCorrLibreta.Text & " and a.Corr_Libreta<=" & pMaxPag & "", "a.Num", sUsuario, sPassword, sSucursal)
        '                Else
        '                    dsPosteo = ahorro.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta=1 and a.IdLibreta=" & txtCorrLibreta.Text & "", "a.Num", sUsuario, sPassword, sSucursal)
        '                End If
        '                Dim ofrm As New frmMsAhInicializacionLibreta
        '                ofrm.vNoExistMov = False
        '                ofrm.TipoAhorro = txtCodTipoAhorro.Text
        '                ofrm.dsPosteo = dsPosteo
        '                vNocta = Me.txtNoCuenta.Text.Trim
        '                vDui = Me.txtDui.Text.Trim
        '                ofrm.ds = ds
        '                ofrm.ShowDialog()
        '            Else
        '                MessageBox.Show(vResp, "Posteo de Libreta", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '            End If
        '        End If
        '    Else 'No hay movimientos pendientes
        '        ds = ahorro.InicializacionLibreta(Me.txtDui.Value, Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
        '        'dsPosteo = oAh.ConsultaPosteo("a.*,b.Titular2 as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Num=1", "a.Num", sUsuario, sPassword, sSucursal)
        '        Dim ofrm As New frmMsAhInicializacionLibreta
        '        ofrm.vNoExistMov = True
        '        ofrm.TipoAhorro = txtCodTipoAhorro.Text
        '        ofrm.dsPosteo = ds 'Posteo
        '        vNocta = Me.txtNoCuenta.Text.Trim
        '        vDui = Me.txtDui.Text.Trim
        '        ofrm.ds = ds
        '        ofrm.ShowDialog()
        '    End If
        '    Call txtNoCuenta_LostFocus(sender, e)
        'Catch ex As Exception
        '    MsgBox(mensajeError, MsgBoxStyle.Critical)
        'End Try
    End Sub

    Private Sub btnPostear1_Click(sender As Object, e As EventArgs) Handles btnPostear1.Click
        Try

            Dim ds As New Data.DataSet, vResp As String
            Dim dsPosteo As New DataSet, dr As DataRow, vLineaMax As Integer, pMaxPag As Integer

            If Me.txtDui.Text.Trim = "" Or Me.txtNoCuenta.Text.Trim = "" Then
                MsgBox("Ingrese el Dui y el Número de Cuenta.", MsgBoxStyle.Critical, "Validación del Sistema")
                Exit Sub
            End If

            If Me.txtNoLibreta.Text.Trim = "" Then
                MsgBox("Debe digitar el No. de Libreta.", MsgBoxStyle.Critical, "Validación del Sistema")
                Exit Sub
            End If
            Dim maxMovPagina As Integer
            ds = asociado.ConsultarParametros("MaxNumLibreta,movPagLibreta", "", "MaxNumLibreta", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                vLineaMax = dr("MaxNumLibreta")
                maxMovPagina = dr("movPagLibreta")
                pMaxPag = maxMovPagina 'vLineaMax - 12
            End If

            Dim dtsPosteo As New DataSet
            dtsPosteo = ahorro.movimientosPendientesPostear(txtNoCuenta.Text.Trim, txtHoja.Text.Trim, txtCorrLibreta.Text)
            If dtsPosteo.Tables.Count > 0 Then
                Dim ofrm As frmVisorLib
                If (CInt(txtHoja.Text) Mod 2 <> 0) Then
                    ofrm = New frmVisorLib(dtsPosteo, 21, Me.txtUltLinea.Text, Me.txtCorrLibreta.Text)
                Else
                    ofrm = New frmVisorLib(dtsPosteo, 133, Me.txtUltLinea.Text, Me.txtCorrLibreta.Text)
                End If
                ofrm.Show()

                ahorro.postearMovimientosAhorro(txtNoCuenta.Text.Trim, txtHoja.Text.Trim, txtCorrLibreta.Text)
                quitarPosteo = False
                PostlibretaAnt = False
                chkQuitarPosteo.Enabled = False
                Call txtNoCuenta_LostFocus(sender, e)

            End If



            'If txtUltLinea.Text < pMaxPag Then
            '    vResp = ahorro.PosteoMovimientos(False, Me.txtDui.Text.Trim, Me.txtNoCuenta.Text.Trim, Me.txtNoLibreta.Text.Trim, txtUltLinea.Text, Me.c1nSaldo.Value, False, txtCorrLibreta.Text, False, sUsuario, sPassword, sSucursal)
            'Else
            '    vResp = ahorro.PosteoMovimientos(False, Me.txtDui.Text.Trim, Me.txtNoCuenta.Text.Trim, Me.txtNoLibreta.Text.Trim, txtUltLinea.Text, Me.c1nSaldo.Value, False, txtCorrLibreta.Text, True, sUsuario, sPassword, sSucursal)
            'End If
            'If (vResp) = "" Then
            '    If txtUltLinea.Text < pMaxPag Then
            '        dsPosteo = ahorro.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta>" & txtUltLinea.Text & " and a.IdLibreta=" & txtCorrLibreta.Text & " and a.Corr_Libreta<=" & pMaxPag & "", "a.Num", sUsuario, sPassword, sSucursal)
            '    Else
            '        dsPosteo = ahorro.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta>" & txtUltLinea.Text & " and a.IdLibreta=" & txtCorrLibreta.Text & "", "a.Num", sUsuario, sPassword, sSucursal)
            '    End If

            '    ' Dim ofrm As New frmVisorLib(dsPosteo, 21, Me.txtUltLinea.Text, Me.txtCorrLibreta.Text)

            'Else
            '    MsgBox(vResp, MsgBoxStyle.Critical, "Validación del Sistema")
            'End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnQuitarPosteo1_Click(sender As Object, e As EventArgs) Handles btnQuitarPosteo1.Click
        Try
            Dim ofrmAut As New frmMsAutorizacion
            ofrmAut.TipoPermiso = "P"
            ofrmAut.NumPrograma = "AHL006"
            ofrmAut.ShowDialog()
            If ofrmAut.Autoriza = True Then
                quitarPosteo = True
                Me.DataGridView1.Columns("posteo").ReadOnly = False
                Me.chkQuitarPosteo.Enabled = True
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnPostLibAnt1_Click(sender As Object, e As EventArgs) Handles btnPostLibAnt1.Click
        Try
            If Me.txtUltLinea.Text = 0 Then
                Dim ofrmAut As New frmMsAutorizacion
                ofrmAut.TipoPermiso = "P"
                ofrmAut.NumPrograma = "AHL007"
                ofrmAut.ShowDialog()
                If ofrmAut.Autoriza = True Then
                    quitarPosteo = True
                    Me.DataGridView1.Columns("posteo").ReadOnly = False
                    Me.chkQuitarPosteo.Enabled = True
                    Dim corrLibreta As Integer = CInt(txtCorrLibreta.Text) - 1
                    Me.DataGridView1.Columns("posteo").ReadOnly = False
                    llenardgMovimientos(txtNoCuenta.Text, CStr(corrLibreta))
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim frm As New frmMsAhRepLibreta
        With frm
            .pNoCuenta = txtNoCuenta.Text.Trim
            .pCodTipoAhorro = txtCodTipoAhorro.Text.Trim
            .btnGuardar.Text = "&Guardar"
            .pNoLibreta = txtNoLibreta.Text.Trim
            .Show()
        End With
    End Sub

End Class