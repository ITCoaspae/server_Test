Public Class detCtaPorCobrar
    Private contabilidad As New wrConta.wsLibContab
    Private asociados As New wrAsociados.wsLibAsoc
    Private prestamo As New wrPrestamo.wsLibPrest
    Private ahorro As New wrAhorro.wsLibAhorro
    Private caja As New wrCaja.wsLibCaja
    Private vAccion, vIdCxC As Integer

    Private Enum origen
        ahorro = 1071
        prestamo = 1072
        otras = 1073

    End Enum

#Region "Propiedades"
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property idCxC() As Integer
        Get
            Return vIdCxC
        End Get
        Set(value As Integer)
            vIdCxC = value
        End Set
    End Property


#End Region
    Private Sub detCtaPorCobrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDui.Focus()
        llenarTipoCtaOrigen()
        llenarSucrsales()
        txtNombre.Enabled = False

        If accion = 2 Then
            txtDui.Enabled = False
            cbTipoCtaOrigen.Enabled = False
            cbCuentas.Enabled = False
            txtMonto.Enabled = False
            txtSaldo.Enabled = False
        Else
            chkActivo.Checked = True
            chkActivo.Enabled = False
        End If
    End Sub

    Private Sub txtDui_DoubleClick(sender As Object, e As EventArgs) Handles txtDui.DoubleClick
        Dim dts As New DataSet
        dts = asociados.ConsultarAsociado(" DUI,rtrim(nombres)[Nombres],rtrim(apellido1)[Primer Apellido],rtrim(apellido2)[Segundo Apellido],rtrim(apellidoCas)[Apellido Casada] ", " EstadoIngreso in ('2','1') and EstadoAsociado='25' ", " Nombres ", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            Dim frm As New frmAGenerico
            With frm
                .ColSeleccion = 0
                .Text = "Asociados"
                .Datos = dts
                .RefrescarGrid()
                .ShowDialog()
            End With
            If frm.Resultado.Trim.Length > 0 Then
                txtDui.Text = frm.Resultado.Trim
                txtNombre.Text = String.Concat(frm.Resultado2, " ", frm.Resultado3, " ", frm.Resultado4, " ", frm.Resultado5)

            End If
        End If
    End Sub
    Friend Sub llenarTipoCtaOrigen()
        Dim dts As New DataSet
        dts = asociados.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.tipoCuentaOrigen, 2)
        cbTipoCtaOrigen.DataSource = dts.Tables(0)
        cbTipoCtaOrigen.DisplayMember = "descripcion"
        cbTipoCtaOrigen.ValueMember = "idCatalogo"
    End Sub

    Private Sub cbTipoCtaOrigen_DropDownClosed(sender As Object, e As EventArgs) Handles cbTipoCtaOrigen.DropDownClosed

    End Sub

    Friend Sub cbTipoCtaOrigen_Validated(sender As Object, e As EventArgs) Handles cbTipoCtaOrigen.Validated
        If cbTipoCtaOrigen.SelectedValue = origen.ahorro Then
            llenarCuentaAhorro()
        ElseIf cbTipoCtaOrigen.SelectedValue = origen.prestamo Then
            llenarPrestamos()
        Else
            llenarCtasContables()
        End If
    End Sub
    Protected Sub llenarCuentaAhorro()
        Dim dts As New DataSet
        dts = ahorro.ConsultarCuentaAhorro("NoCuenta,codTipoAhorro ", "Dui='" & Me.txtDui.Text & "' ", "NoCuenta", sUsuario, sPassword, sSucursal)
        cbCuentas.DataSource = dts.Tables(0)
        cbCuentas.DisplayMember = "NoCuenta"
        cbCuentas.ValueMember = "NoCuenta"
    End Sub
    Protected Sub llenarPrestamos()
        Dim dts As New DataSet
        dts = prestamo.ConsultarPRPrestamosTipoCredito("a.codPrestamo", " a.DUI = '" & txtDui.Text & "' and a.saldo_capital > 0 and a.estado = 'A' ", "a.CODPRESTAMO", sUsuario, sPassword, sSucursal)
        cbCuentas.DataSource = dts.Tables(0)
        cbCuentas.DisplayMember = "codprestamo"
        cbCuentas.ValueMember = "codprestamo"
    End Sub
    Protected Sub llenarCtasContables()
        Dim dts As New DataSet
        dts = contabilidad.ObtenerCatContab("idCuenta, CONCAT(idCuenta,' - ', Descripcion)[descripcion]", " Final = 'S' and inhabilitado = 'N' ", "idCuenta", sUsuario, sPassword, sSucursal)
        cbCuentas.DataSource = dts.Tables(0)
        cbCuentas.DisplayMember = "descripcion"
        cbCuentas.ValueMember = "idCuenta"
    End Sub


    Private Sub TextBox3_DoubleClick(sender As Object, e As EventArgs) Handles TextBox3.DoubleClick
        Dim dts As New DataSet
        dts = caja.ConsultarFacturasxFiltro("idmovimiento,fec_mov,tipo,vta_total", " dui ='" & txtDui.Text.Trim & "' and Estado = 'D' ", " Fec_Mov", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            Dim frm As New frmAGenerico
            With frm
                .ColSeleccion = 0
                .Text = "Facturas"
                .Datos = dts
                .RefrescarGrid()
                .ShowDialog()
            End With
            If frm.Resultado.Trim.Length > 0 Then
                TextBox3.Text = frm.Resultado.Trim
                txtMonto.Text = frm.Resultado4
                txtSaldo.Text = frm.Resultado4
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim resultado As Integer
        If accion = 1 Then
            If contabilidad.ingresarCuentaPorCobrar(cbTipoCtaOrigen.SelectedValue, Now.ToShortDateString, txtMonto.Text, txtSaldo.Text, cbCuentas.SelectedValue, chkActivo.Checked, TextBox3.Text, sUsuario, txtDui.Text, cbSucursal.SelectedValue) > 0 Then
                MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            Else
                MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If
        Else

        End If
        Me.Close()
    End Sub

    Private Sub txtDui_LostFocus(sender As Object, e As EventArgs) Handles txtDui.LostFocus
        Dim dts As New DataSet
        Try
            dts = asociados.ConsultarAsociado(" DUI,concat(rtrim(nombres),' ',rtrim(apellido1),' ',rtrim(apellido2),' ',rtrim(apellidoCas) ) [Asociado]", " EstadoIngreso in ('2','1') and EstadoAsociado='25' and dui = '" & txtDui.Text.Trim & "' ", " Nombres ", sUsuario, sPassword, sSucursal)
            If dts.Tables.Count > 0 Then
                txtNombre.Text = dts.Tables(0).Rows(0).Item(1)
            End If

        Catch ex As Exception

        End Try
    End Sub
    Friend Sub llenarSucrsales()
        Dim dts As New DataSet
        dts = asociados.ConsultarSucursales("cod_ccosto,nom_sucursal", "", "Nom_Sucursal", sUsuario, sPassword, sSucursal)
        cbSucursal.DataSource = dts.Tables(0)
        cbSucursal.DisplayMember = "nom_sucursal"
        cbSucursal.ValueMember = "cod_ccosto"

    End Sub

    Private Sub txtMonto_Validated(sender As Object, e As EventArgs) Handles txtMonto.Validated
        txtSaldo.Text = txtMonto.Text
    End Sub
End Class