Public Class frmMsCompras
    Dim vAccion As Integer '1=Insertar; 2= Modificar;3= Consultar
    Dim vIdCompra As Integer
    Dim contabilidad As New wrConta.wsLibContab
    Dim asociado As New wrAsociados.wsLibAsoc
    Dim caja As New wrCaja.wsLibCaja
    Dim iva As Double
    Dim TipoCont, vidTipoDoc As Integer
#Region "Propiedades"
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property idCompra() As Integer
        Get
            Return vIdCompra
        End Get
        Set(ByVal value As Integer)
            vIdCompra = value
        End Set
    End Property
    Public Property idTipoDoc() As Integer
        Get
            Return vidTipoDoc
        End Get
        Set(ByVal value As Integer)
            vidTipoDoc = value
        End Set
    End Property
#End Region
    Protected Function validaciones() As Boolean
        If txtExImpuesto.Value = 0 Then
            If txtNoComprobante.Text.Trim = "" Then
                MsgBox("No. de comprobante no puede quedar vacio.", MsgBoxStyle.Critical)
                Return False
            End If
        End If
        If txtNit.Text.Trim.Replace("-", "").Trim = "" Then
            MsgBox("NIT no puede quedar vacio.", MsgBoxStyle.Critical)
            Return False
        End If
        If txtNRC.Text.Trim = "" Then
            MsgBox("NRC no puede quedar vacio.", MsgBoxStyle.Critical)
            Return False
        End If
        If txtCodProveedor.Text.Trim = "" Then
            MsgBox("La información ingresado no corresponde a ningun proveedor.", MsgBoxStyle.Critical)
            Return False
        End If
        If txtTotal.Value <= 0 Then
            MsgBox("El monto debe ser mayor que cero.", MsgBoxStyle.Critical)
            Return False
        End If
        Return True
    End Function
    Protected Sub limpiar()
        Me.txtNit.Text = ""
        Me.txtNRC.Text = ""
        dtpFecha.Value = Now
        txtNoComprobante.Text = ""
        txtExLocales.Value = 0
        txtExImportaciones.Value = 0
        txtExInternacionales.Value = 0
        txtGraLocales.Value = 0
        txtGraImportaciones.Value = 0
        txtGravadasInternacionales.Value = 0
        txtCreditoFiscal.Value = 0
        txtTotal.Value = 0
        txtRetTerceros.Value = 0
        txtExImportaciones.Value = 0
        txtObservacion.Text = ""
        txtCodProveedor.Text = ""
        txtNombreProveedor.Text = ""
    End Sub
    Protected Function validarMesCerrado(ByVal mes As Integer, ByVal annio As Integer) As Boolean
        Dim dts As New DataSet
        dts = contabilidad.consultarCaCompraCierreMes(mes, annio, 5, txtBloque.Value)
        If dts.Tables(0).Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function
    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub txtCodProveedor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodProveedor.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Proveedor"
        Dim dts As New DataSet
        dts = contabilidad.consultarCaProveedores(5, "", "", "")

        With frm
            .Text = "Buscar Proveedor"
            .Datos = dts
            .ColSeleccion = 0
            .RefrescarGrid()
            .ShowDialog()
        End With

        If frm.Resultado <> "" Then
            Me.txtCodProveedor.Text = frm.Resultado.ToString.Trim
            Me.txtNombreProveedor.Text = frm.Resultado2.ToString.Trim
            Me.txtNRC.Text = frm.Resultado4.ToString.Trim
            Me.txtNit.Text = frm.Resultado3.ToString.Trim
            txtTipoCont.Text = frm.Resultado5.ToString.Trim
            TipoCont = frm.Resultado6.ToString.Trim
        End If

    End Sub
    Private Sub frmMsCompras_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dtsIva As New DataSet
        dtsIva = asociado.ConsultarParametros("Iva", "", "Iva", sUsuario, sPassword, sSucursal)
        If dtsIva.Tables.Count > 0 Then
            If dtsIva.Tables(0).Rows.Count > 0 Then
                iva = Math.Round(((dtsIva.Tables(0).Rows(0).Item(0)) / 100), 2)
            End If
        End If
        If accion = 2 Then
            Dim dts As New DataSet
            dts = contabilidad.consultarCaProveedores(2, "", "", txtNombreProveedor.Text.Trim)
            Me.txtNombreProveedor.Text = dts.Tables(0).Rows(0).Item("proveedor")
            Me.txtNit.Text = dts.Tables(0).Rows(0).Item("nit")
            Me.txtNRC.Text = dts.Tables(0).Rows(0).Item("noregistro")
            txtTipoCont.Text = dts.Tables(0).Rows(0).Item("descripcion")
            TipoCont = dts.Tables(0).Rows(0).Item("TipoContribuyente")
        End If
    End Sub
    Protected Sub suma()
        'txtCreditoFiscal.Value = Math.Round((txtGraImportaciones.Value + txtGraLocales.Value + txtGravadasInternacionales.Value), 2) 'Math.Round((txtGraImportaciones.Value + txtGraLocales.Value + txtGravadasInternacionales.Value) * iva, 2)
        txtTotal.Value = Math.Round(txtGraImportaciones.Value + txtGraLocales.Value + txtGravadasInternacionales.Value +
        txtExImportaciones.Value + txtExInternacionales.Value + txtExLocales.Value +
        txtExImpuesto.Value + txtRetTerceros.Value + txtCreditoFiscal.Value, 2)
    End Sub
    Private Sub txtCreditoFiscal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCreditoFiscal.LostFocus
        suma()
    End Sub
    Private Sub txtExImportaciones_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtExImportaciones.LostFocus
        suma()
    End Sub
    Private Sub txtExImpuesto_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtExImpuesto.LostFocus
        suma()
    End Sub
    Private Sub txtExInternacionales_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtExInternacionales.LostFocus
        suma()
    End Sub
    Private Sub txtExLocales_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtExLocales.LostFocus
        suma()
    End Sub
    Private Sub txtGraImportaciones_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGraImportaciones.LostFocus
        suma()
    End Sub
    Private Sub txtGraLocales_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGraLocales.LostFocus
        suma()
    End Sub
    Private Sub txtGravadasInternacionales_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtGravadasInternacionales.LostFocus
        suma()
    End Sub
    Private Sub txtRetTerceros_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRetTerceros.LostFocus
        suma()
    End Sub
    Private Sub btnCerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub txtNit_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNit.Leave
        Try
            Dim dts As New DataSet
            If txtNit.Text.Replace("-", "").Replace("_", "").Trim <> "" Then
                dts = contabilidad.consultarCaProveedores(4, "", txtNit.Text, "")
                If dts.Tables.Count > 0 Then
                    If dts.Tables(0).Rows.Count > 0 Then
                        Me.txtCodProveedor.Text = dts.Tables(0).Rows(0).Item("idproveedor")
                        Me.txtNombreProveedor.Text = dts.Tables(0).Rows(0).Item("proveedor")
                        Me.txtNRC.Text = dts.Tables(0).Rows(0).Item("noregistro")
                        txtNit.Text = dts.Tables(0).Rows(0).Item("nit")
                        txtTipoCont.Text = dts.Tables(0).Rows(0).Item("descripcion")
                        TipoCont = dts.Tables(0).Rows(0).Item("idCatalogo")
                    Else
                        MsgBox("No de NIT no existe.", MsgBoxStyle.Critical)
                        Me.txtCodProveedor.Text = ""
                        Me.txtNombreProveedor.Text = ""
                        Me.txtNRC.Text = ""
                        Me.txtNit.Text = ""
                        txtTipoCont.Text = ""
                        TipoCont = ""
                    End If
                Else
                    MsgBox("No de NIT no existe.", MsgBoxStyle.Critical)
                    Me.txtCodProveedor.Text = ""
                    Me.txtNombreProveedor.Text = ""
                    Me.txtNRC.Text = ""
                    Me.txtNit.Text = ""
                    txtTipoCont.Text = ""
                    TipoCont = ""
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub txtNRC_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNRC.Leave

        Dim dts As New DataSet
        If txtNRC.Text.Trim <> "" Then
            dts = contabilidad.consultarCaProveedores(3, txtNRC.Text.Trim, txtNit.Text, "")
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    Me.txtCodProveedor.Text = dts.Tables(0).Rows(0).Item("idproveedor")
                    Me.txtNombreProveedor.Text = dts.Tables(0).Rows(0).Item("proveedor")
                    Me.txtNit.Text = dts.Tables(0).Rows(0).Item("NIT")
                    txtTipoCont.Text = dts.Tables(0).Rows(0).Item("descripcion")
                    TipoCont = dts.Tables(0).Rows(0).Item("idCatalogo")
                Else
                    MsgBox("No de registro no existe.", MsgBoxStyle.Critical)
                    Me.txtCodProveedor.Text = ""
                    Me.txtNombreProveedor.Text = ""
                    Me.txtNRC.Text = ""
                    Me.txtNit.Text = ""
                    txtTipoCont.Text = ""
                    TipoCont = ""
                End If
            Else
                MsgBox("No de registro no existe.", MsgBoxStyle.Critical)
                Me.txtCodProveedor.Text = ""
                Me.txtNombreProveedor.Text = ""
                Me.txtNRC.Text = ""
                Me.txtNit.Text = ""
                txtTipoCont.Text = ""
                TipoCont = ""
            End If
        End If

    End Sub
    Private Sub dtpFecha_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.LostFocus
        Dim dif As Integer = DateDiff(DateInterval.Day, dtpFecha.Value, Now)
        If dif > 90 Then
            MsgBox("Fecha de emisión supera los 90 días habiles", MsgBoxStyle.Critical)
            Me.btnGuardar.Enabled = False
        Else
            Me.btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub lblNoComprobante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblNoComprobante.Click

    End Sub

    Private Sub btnAnular1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim resultado As Integer
            suma()
            If validaciones() = True Then
                If validarMesCerrado(dtpFecha.Value.Month, dtpFecha.Value.Year) = True Then
                    If Me.accion = 1 Then
                        resultado = contabilidad.insertarCaCompras(Format(Me.dtpFecha.Value, "Short Date"), txtNoComprobante.Text,
                                                                txtExLocales.Value, txtExImportaciones.Value, txtExInternacionales.Value,
                                                                txtGraLocales.Value, txtGraImportaciones.Value, txtGravadasInternacionales.Value,
                                                                txtCreditoFiscal.Value, txtTotal.Value, txtRetTerceros.Value, txtExImpuesto.Value,
                                                                sUsuario, Now, txtObservacion.Text, sSucursal, txtCodProveedor.Text, False, txtBloque.Value, vidTipoDoc)
                        If resultado <> 0 Then
                            MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information)
                            limpiar()
                        Else
                            MsgBox("El registro no pudo ser ingresado por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Compras")
                        End If
                    ElseIf Me.accion = 2 Then
                        resultado = contabilidad.modificarCaCompras(Format(Me.dtpFecha.Value, "Short Date"), txtNoComprobante.Text,
                                                                txtExLocales.Value, txtExImportaciones.Value, txtExInternacionales.Value,
                                                                txtGraLocales.Value, txtGraImportaciones.Value, txtGravadasInternacionales.Value,
                                                                txtCreditoFiscal.Value, txtTotal.Value, txtRetTerceros.Value, txtExImpuesto.Value,
                                                                sUsuario, Now, txtObservacion.Text, sSucursal, vIdCompra, txtCodProveedor.Text, vidTipoDoc)
                        If resultado <> 0 Then
                            MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information)
                            Me.Close()
                        Else
                            MsgBox("El registro no pudo ser ingresado por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Compras")
                        End If
                    End If
                Else
                    MsgBox("No se pueden ingresar compras en un mes que ya se encuentra cerrado", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtGraLocales_TextChanged(sender As Object, e As EventArgs) Handles txtGraLocales.TextChanged

    End Sub

    Private Sub txtGraLocales_Leave(sender As Object, e As EventArgs) Handles txtGraLocales.Leave
        If TipoCont = 1060 Then
            txtRetTerceros.Text = Math.Round(txtGraLocales.Text * 0.01, 2)
        Else
            txtRetTerceros.Text = 0
        End If

        txtCreditoFiscal.Text = Math.Round(txtGraLocales.Text * iva, 2)
    End Sub

    Private Sub txtCodProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtCodProveedor.TextChanged

    End Sub

    Private Sub txtTipoDocumento_TextChanged(sender As Object, e As EventArgs) Handles txtTipoDocumento.TextChanged

    End Sub

    Private Sub btnCheques_Click(sender As Object, e As EventArgs) Handles btnCheques.Click
        Try
            Dim ofrm As New frmMsBCCheque, oLibBco As New wrBancos.wsLibBancos, ds As DataSet
            'ofrm.Accion = Seguridad.clsUsuario.TipoAccion.Insertar
            ofrm.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Insertar
            'ofrm.C1NEMonto.ReadOnly = False
            ofrm.C1NEMonto.Value = txtTotal.Value
            ofrm.ShowDialog()
            ds = oLibBco.ObtenerCheque("b.*", "", "IdMovimiento", sUsuario, sPassword, sSucursal)
            ' btnMostrar1_Click(sender, e)
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtTipoDocumento_DoubleClick(sender As Object, e As EventArgs) Handles txtTipoDocumento.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Tipo de Documento"
        Dim dts As New DataSet
        dts = caja.consultarCaMaestrosTipoDocumentos(1, 1, 0)

        With frm
            .Text = "Buscar Tipo de Documento"
            .Datos = dts
            .ColSeleccion = 0
            .RefrescarGrid()
            .ShowDialog()
        End With

        If frm.Resultado <> "" Then
            idTipoDoc = frm.Resultado.ToString.Trim
            Me.txtTipoDocumento.Text = frm.Resultado2.ToString.Trim
        End If
    End Sub
End Class