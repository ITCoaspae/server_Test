Imports System.Text.RegularExpressions
Public Class frmMsRutasMercadeo
    Dim rutas As New wsSysFinCoop.LibAsoc.wsLibAsoc
    Dim creditos As New wsSysFinCoop.LibCred.wsLibCred
    Dim asociado As New wsSysFinCoop.LibAsoc.wsLibAsoc
    Dim prestamo As New wsSysFinCoop.LibPrest.wsLibPrest
    Dim ahorro As New wsSysFinCoop.LibAhorro.wsLibAhorro
    Dim vAccion As Integer
    Dim vIdAccion As Integer
    Dim vIdGestion As Integer
    Dim vCodPagaduria As String
    Dim vIdRuta As Integer
    Dim vIdVisitaRuta As Integer
    Dim fechaInicioGestion As DateTime

    Protected Enum producto
        Creditos = 1
        Ahorros = 2
        Ingreso_Asociados = 3
        IncrementoAportaciones = 73
    End Enum





    Function EmailAddressCheck(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]" & _
        "*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            EmailAddressCheck = True

        Else
            EmailAddressCheck = False

        End If
    End Function
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property idRuta() As Integer
        Get
            Return vIdRuta
        End Get
        Set(ByVal value As Integer)
            vIdRuta = value
        End Set
    End Property
    Public Property idVisitaRuta() As Integer
        Get
            Return vIdVisitaRuta
        End Get
        Set(ByVal value As Integer)
            vIdVisitaRuta = value
        End Set
    End Property
    Public Property idAccion() As Integer
        Get
            Return vIdAccion
        End Get
        Set(ByVal value As Integer)
            vIdAccion = value
        End Set
    End Property
    Public Property idGestion() As Integer
        Get
            Return vIdGestion
        End Get
        Set(ByVal value As Integer)
            vIdGestion = value
        End Set
    End Property
    Public Property codPagaduria() As String
        Get
            Return vCodPagaduria
        End Get
        Set(ByVal value As String)
            vCodPagaduria = value
        End Set
    End Property
    Protected Sub llenarcbActividad()
        Dim dts As New DataSet
        dts = rutas.consultarDbCatalogosCatalogos(0, 1, 2)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbProducto.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Protected Sub llenarcbTipoGestion()
        Dim dts As New DataSet
        dts = rutas.consultarDbCatalogosCatalogos(0, 2, 2)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbGestion.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Protected Sub llenarcbTipoEvento()
        Dim dts As New DataSet
        dts = rutas.consultarDbCatalogosCatalogos(0, wsSysFinCoop.LibAsoc.tipoCatalogo.tipoEventoMercadeo, 2)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbTipoEvento.DataSource = dts.Tables(0)
            End If
        End If
    End Sub

    Protected Sub llenarDgVisitas(ByVal idRuta As Integer)
        Dim dts As New DataSet
        dts = rutas.consultarMercaRutas(2, "", "", Now, Now, idRuta)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgVisitas.DataSource = dts.Tables(0)
                Me.dgVisitas.Columns("idMercaRutaVisitas").Visible = False
                Me.dgVisitas.Columns("idRuta").Visible = False
                Me.dgVisitas.Columns("UsuarioRevisa").Visible = False
                Me.dgVisitas.Columns("FechaRevision").Visible = False
                Me.dgVisitas.Columns("revisado").Visible = False
                Me.dgVisitas.Columns("Observacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                Me.dgVisitas.ColumnHeadersDefaultCellStyle.BackColor = Color.OliveDrab
                Me.dgVisitas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                Me.dgVisitas.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                Me.dgVisitas.Columns("Observacion").HeaderText = "Observación"
                Me.dgVisitas.Columns("FechaVisita").HeaderText = "Fecha de Visita"

            End If
        End If
    End Sub
    Protected Sub llenarPagadurias()
        Dim dts As New DataSet
        dts = creditos.consultarPrPagadurias("", "", 4)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbLugarTrabajo.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Private Sub frmMsRutasMercadeo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbProducto.DisplayMember = "descripcion"
        Me.cbProducto.ValueMember = "idCatalogo"
        Me.cbGestion.DisplayMember = "descripcion"
        Me.cbGestion.ValueMember = "idCatalogo"
        Me.cbTipoEvento.DisplayMember = "descripcion"
        Me.cbTipoEvento.ValueMember = "idCatalogo"
        Me.cbLugarTrabajo.ValueMember = "codPagaduria"
        Me.cbLugarTrabajo.DisplayMember = "Pagaduria"

        llenarcbActividad()
        llenarcbTipoGestion()
        llenarPagadurias()
        llenarcbTipoEvento()
        If Me.accion = 2 Or Me.accion = 3 Then
            Me.cbProducto.SelectedValue = idAccion
            Me.cbGestion.SelectedValue = idGestion
            'Me.cbLugarTrabajo.SelectedValue = codPagaduria
            recuperarInfRuta(idRuta)
            llenarDgVisitas(idRuta)
        End If
        If Me.accion = 4 Then

            Me.cbProducto.SelectedValue = idAccion
            Me.cbGestion.SelectedValue = idGestion
            'Me.cbLugarTrabajo.SelectedValue = codPagaduria
            recuperarInfRuta(idRuta)
            'llenarDgVisitas(idRuta)
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub dgVisitas_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgVisitas.CellMouseDoubleClick
        If Me.dgVisitas.RowCount > 0 Then
            Me.txtObs.Text = Me.dgVisitas.Item("observacion", Me.dgVisitas.CurrentRow.Index).Value.ToString.Trim.ToLower
            Me.dtpFechaVis.Value = Me.dgVisitas.Item("FechaVisita", Me.dgVisitas.CurrentRow.Index).Value
        End If
    End Sub

    Private Sub txtCorreo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCorreo.Validating

        If EmailAddressCheck(txtCorreo.Text.Trim) = False Then

            Dim result As DialogResult _
            = MessageBox.Show("La dirección de correo electronico ingresada no es valida." & _
                                       "Por favor ingresar una dirección valida.", "Correo electronico invalido", _
                                       MessageBoxButtons.OK, MessageBoxIcon.Error)
            If result = Windows.Forms.DialogResult.Yes Then
                e.Cancel = True
            End If

        End If


    End Sub
#Region "Modificaciones 21/07/2016"
    Private Sub chkAsociado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAsociado.Click
        If chkAsociado.Checked = True Then
            Try
                Dim dts As New DataSet
                dts = asociado.ConsultarAsociado("rtrim(nombres)+' '+rtrim(apellido1)+' '+ rtrim(apellido2)+' '+rtrim(apellidoCas) [nombre],telcasa,email,dui", "", "Correlativo", sUsuario, sPassword, sSucursal) 'Ópcion que permite la busqueda del dui de los asociados.
                Dim frm As New frmAGenerico
                'ds = oAsoc.ConsultarAsociado("DUI,CodAntiguo,NoSocio,Apellido1,Apellido2,Nombres", "DUI='" & txtDui.Text.Trim & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                frm.Datos = dts
                frm.ColSeleccion = 0
                frm.RefrescarGrid()
                frm.ShowDialog()
                If frm.Resultado.Trim <> "" Then
                    txtNombreCliente.Text = frm.Resultado.Trim
                    txtTel.Text = frm.Resultado2.ToString.Replace("-", "").ToString.Replace("_", "")  'Replace("-", frm.Resultado2, "")
                    txtCorreo.Text = frm.Resultado3
                    txtDui.Value = frm.Resultado4
                End If
            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla Asociados- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Public Function recuperarFechaInicioGestion() As DateTime
        Dim fecha As DateTime
        Dim dtsFechaRuta As New DataSet
        dtsFechaRuta = rutas.consultarMercaRutas(6, sSucursal, sUsuario, dtpFechaVis.Value, dtpFechaVis.Value, idRuta)
        If dtsFechaRuta.Tables.Count > 0 Then
            If dtsFechaRuta.Tables(0).Rows.Count > 0 Then
                If dtsFechaRuta.Tables(0).Rows(0).Item(0).ToString <> "" Then
                    fecha = IIf(IsDBNull(dtsFechaRuta.Tables(0).Rows(0).Item(0)), Format(Me.dtpFechaVis.Value, "Short Date"), dtsFechaRuta.Tables(0).Rows(0).Item(0))
                Else
                    fecha = Format(Me.dtpFechaVis.Value, "Short Date")
                End If

            Else
                fecha = Format(Me.dtpFechaVis.Value, "Short Date")
            End If
        End If
        Return fecha
    End Function
    Protected Sub consultarPrestamos()
        Dim frm As New frmAGenerico
        Dim dts As New DataSet
        Dim fecha As DateTime
        fecha = recuperarFechaInicioGestion()
        dts = prestamo.ConsultarPRPrestamos("a.codPrestamo,a.monto,a.fechaOtorgamiento,b.descripcion as TipoCredito", " a.dui = '" & txtDui.Text & "' and fechaOtorgamiento >='" & fecha & "' and a.estado = 'A' ", "", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                frm.Datos = dts
                frm.ColSeleccion = 0
                frm.RefrescarGrid()
                frm.ShowDialog()
                If frm.Resultado <> "" Then
                    txtComprobante.Text = frm.Resultado
                End If
            End If
        End If
    End Sub
    Protected Sub consultarMovimientos()
        Dim nocuenta As String
        Dim frm As New frmAGenerico
        Dim dtsCuenta, dtsMov As New DataSet
        Dim fecha As DateTime
        dtsCuenta = ahorro.ConsultarCuentaAhorro("nocuenta", " dui = '" & txtDui.Text & "' And left(codTipoAhorro,1)='1' and estado = 'A' and saldo_cuentaahorro > 0", "", sUsuario, sPassword, sSucursal)
        If dtsCuenta.Tables.Count > 0 Then
            If dtsCuenta.Tables(0).Rows.Count > 0 Then
                nocuenta = dtsCuenta.Tables(0).Rows(0).Item(0).ToString
            End If
        End If
        If nocuenta <> "" Then
            fecha = recuperarFechaInicioGestion()
            dtsMov = ahorro.ConsultarAhMovimientos("correlativo,nocuenta,monto,origen,fecha", " nocuenta = '" & nocuenta & "' and fecha >='" & fecha & "' and origen = 'C' and monto >= 25 ", "correlativo")
            If dtsMov.Tables.Count > 0 Then
                If dtsMov.Tables(0).Rows.Count > 0 Then
                    frm.Datos = dtsMov
                    frm.ColSeleccion = 0
                    frm.RefrescarGrid()
                    frm.ShowDialog()
                    If frm.Resultado <> "" Then
                        txtComprobante.Text = frm.Resultado
                    End If
                End If
            End If

        End If


    End Sub
    Protected Sub consultarAhorros(ByVal opcion As producto)
        Dim fecha As DateTime
        fecha = recuperarFechaInicioGestion()
        Dim frm As New frmAGenerico
        Dim dts As New DataSet
        If opcion = producto.Ahorros Then
            dts = ahorro.ConsultarCuentaAhorro("nocuenta,fechaInicioApertura", " dui = '" & txtDui.Text & "' and fechaInicioApertura >= '" & fecha & "' and left(codTipoAhorro,1)<>'1' and estado = 'A' and saldo_cuentaahorro > 0 ", "", sUsuario, sPassword, sSucursal)
        ElseIf opcion = producto.Ingreso_Asociados Then
            dts = ahorro.ConsultarCuentaAhorro("nocuenta,fechaInicioApertura", " dui = '" & txtDui.Text & "' and fechaInicioApertura >= '" & fecha & "' And left(codTipoAhorro,1)='1' and estado = 'A' and saldo_cuentaahorro > 0", "", sUsuario, sPassword, sSucursal)
        End If
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                frm.Datos = dts
                frm.ColSeleccion = 0
                frm.RefrescarGrid()
                frm.ShowDialog()
                If frm.Resultado <> "" Then
                    txtComprobante.Text = frm.Resultado
                End If
            End If
        End If
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If accion = 1 Then
            If rutas.insertarMercaRutas(sUsuario, Format(Me.dtpFechaVis.Value, "short date"), txtNombreCliente.Text.ToUpper, txtTel.Text, _
                                        Me.cbLugarTrabajo.SelectedValue, Me.cbProducto.SelectedValue, txtObs.Text.Trim.ToLower, _
                                        Me.cbGestion.SelectedValue, False, Format(Now, "short date"), sUsuario, Me.txtCorreo.Text.Trim.ToLower, _
                                        chkAsociado.Checked, txtDui.Text, txtComprobante.Text, cbTipoEvento.SelectedValue) > 0 Then
                MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Rutas")
            Else
                MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador de sistemas", MsgBoxStyle.Critical, "Rutas")
            End If
        ElseIf accion = 2 Then
            If rutas.insertarNuevaVistaMercaRutas(idRuta, Format(dtpFechaVis.Value, "Short Date"), txtObs.Text.Trim.ToLower, _
                                                  False, Me.cbProducto.SelectedValue, Me.cbGestion.SelectedValue, _
                                                   Format(Now, "short date"), sUsuario, IIf(txtComprobante.Text.Length > 0, txtComprobante.Text, "")) > 0 Then
                MsgBox("Nueva visita ingresada exitosamente", MsgBoxStyle.Information, "Rutas")
            Else
                MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador de sistemas", MsgBoxStyle.Critical, "Rutas")
            End If
        ElseIf accion = 4 Then
            If rutas.insertarRevisionMercaRutas(sUsuario, Format(Now, "short date"), idVisitaRuta, txtObs.Text.Trim.ToLower) > 0 Then
                MsgBox("Revisión realizada exitosamente", MsgBoxStyle.Information, "Rutas")
            Else
                MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador de sistemas", MsgBoxStyle.Critical, "Rutas")
            End If

        End If

        Me.Close()
    End Sub
    Private Sub cbGestion_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbGestion.Leave
        If txtComprobante.Text = "" Then
            If cbGestion.SelectedValue = 7 Then
                If cbProducto.SelectedValue = 1 Then
                    consultarPrestamos()
                ElseIf cbProducto.SelectedValue = 2 Then
                    consultarAhorros(producto.Ahorros)
                ElseIf cbProducto.SelectedValue = 3 Then
                    consultarAhorros(producto.Ingreso_Asociados)
                ElseIf cbProducto.SelectedValue = 73 Then
                    consultarMovimientos()
                End If
            End If
        End If
    End Sub
    Protected Sub recuperarInfRuta(ByVal idRuta As Integer)
        Dim dtsRuta As New DataSet
        dtsRuta = asociado.consultarMercaRutas(5, "", "", Format(dtpFechaVis.Value, "Short date"), Format(dtpFechaVis.Value, "Short date"), idRuta)
        If dtsRuta.Tables.Count > 0 Then
            If dtsRuta.Tables(0).Rows.Count > 0 Then
                txtNombreCliente.Text = dtsRuta.Tables(0).Rows(0).Item("cliente").ToString.Trim
                txtDui.Value = IIf(IsDBNull(dtsRuta.Tables(0).Rows(0).Item("dui")), "", dtsRuta.Tables(0).Rows(0).Item("dui"))
                txtTel.Text = IIf(IsDBNull(dtsRuta.Tables(0).Rows(0).Item("telCliente")), "", dtsRuta.Tables(0).Rows(0).Item("telCliente"))
                txtCorreo.Text = IIf(IsDBNull(dtsRuta.Tables(0).Rows(0).Item("correoCliente")), "", dtsRuta.Tables(0).Rows(0).Item("correoCliente"))
                cbLugarTrabajo.SelectedValue = dtsRuta.Tables(0).Rows(0).Item("codPagaduria").ToString.Trim
                If IsDBNull((dtsRuta.Tables(0).Rows(0).Item("idEvento").ToString.Trim)) = True Then
                    cbTipoEvento.SelectedValue = dtsRuta.Tables(0).Rows(0).Item("idEvento").ToString.Trim
                End If
                cbProducto.SelectedValue = dtsRuta.Tables(0).Rows(0).Item("idActividad").ToString.Trim
                cbGestion.SelectedValue = dtsRuta.Tables(0).Rows(0).Item("idTipoGestion").ToString.Trim
                txtComprobante.Text = IIf(IsDBNull(dtsRuta.Tables(0).Rows(0).Item("Comprobante")), "", dtsRuta.Tables(0).Rows(0).Item("Comprobante"))
                chkAsociado.Checked = IIf(IsDBNull(dtsRuta.Tables(0).Rows(0).Item("asociado")), False, dtsRuta.Tables(0).Rows(0).Item("asociado"))
                If chkAsociado.Checked = True Then
                    Me.txtDui.Enabled = False
                    Me.chkAsociado.Enabled = False
                    txtNombreCliente.Enabled = False
                    txtComprobante.Enabled = False
                End If
            End If
        End If
    End Sub
    Private Sub txtDui_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.Leave
        Dim dts As New DataSet
        dts = asociado.ConsultarAsociado("rtrim(nombres)+' '+rtrim(apellido1)+' '+ rtrim(apellido2)+' '+rtrim(apellidoCas) [nombre],telcasa,email,dui", " dui = '" & txtDui.Text.Trim & "'", "Correlativo", sUsuario, sPassword, sSucursal) 'Ópcion que permite la busqueda del dui de los asociados.
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                txtNombreCliente.Text = dts.Tables(0).Rows(0).Item("nombre").ToString.Trim
                txtTel.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("telcasa").ToString), "", dts.Tables(0).Rows(0).Item("telcasa").ToString.Replace("-", "").ToString.Replace("_", ""))
                txtCorreo.Text = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("email").ToString.Trim), "", dts.Tables(0).Rows(0).Item("email").ToString.Trim)
                chkAsociado.Checked = True
                chkAsociado.Enabled = False
            End If
        End If

    End Sub
#End Region
    
    
End Class