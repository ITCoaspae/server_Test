Public Class CasosCovidDet
    Private asociados As New wrAsociados.wsLibAsoc
    Private prestamo As New wrPrestamo.wsLibPrest
    Private vAccion As Integer '1 Insertar; 2 Modificar
    Private vId As Integer

#Region "Propiedades"
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property id() As Integer
        Get
            Return vId
        End Get
        Set(value As Integer)
            vId = value
        End Set
    End Property


#End Region
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim resultado As Integer
        If accion = 1 Then
            resultado = asociados.IngresarActualizarCasosCovid(cbPrestamo.SelectedValue, dtpFechaIni.Value.ToShortDateString, dtpFechaFin.Value.ToShortDateString, sUsuario, Now, " ", Now, True, 0, accion)
            If resultado > 0 Then
                MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                btnModTabla.Visible = True
                btnSave.Enabled = False
                cbPrestamo.Enabled = False
                txtDui.Enabled = False

            End If

        ElseIf accion = 2 Then
            resultado = asociados.IngresarActualizarCasosCovid(cbPrestamo.SelectedValue, dtpFechaIni.Value.ToShortDateString, dtpFechaFin.Value.ToShortDateString, "", Now, sUsuario, Now, True, id, accion)
            If resultado > 0 Then
                MetroFramework.MetroMessageBox.Show(Me, mensajeUpdateRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            End If
        End If
    End Sub

    Friend Sub recuperarPrestamo()
        Dim dts As New DataSet
        dts = prestamo.ConsultarPRPrestamosTipoCredito("a.codPrestamo", " a.DUI = '" & txtDui.Text & "' and a.saldo_capital > 0 and a.estado = 'A' ", "a.CODPRESTAMO", sUsuario, sPassword, sSucursal)
        cbPrestamo.DataSource = dts.Tables(0)
        cbPrestamo.DisplayMember = "codprestamo"
        cbPrestamo.ValueMember = "codprestamo"
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
                recuperarPrestamo()
            End If
        End If
    End Sub

    Private Sub CasosCovidDet_Load(sender As Object, e As EventArgs) Handles Me.Load
        If accion = 2 Then
            btnModTabla.Visible = True
            txtDui.Enabled = False
            txtNombre.ReadOnly = True

        End If
    End Sub

    Private Sub btnModTabla_Click(sender As Object, e As EventArgs) Handles btnModTabla.Click
        Dim form As New modTablaPagos
        With form
            .codPrestamo = cbPrestamo.SelectedValue
            .txtPrestamo.Text = cbPrestamo.SelectedValue
            .txtAsociado.Text = txtNombre.Text.ToUpper.Trim
            .mdtIni.Value = dtpFechaIni.Value
            .mdtFin.Value = dtpFechaFin.Value
            .ShowDialog()
        End With
        Me.Close()

    End Sub

    Private Sub txtDui_LostFocus(sender As Object, e As EventArgs) Handles txtDui.LostFocus
        Dim dts As New DataSet
        Try
            dts = asociados.ConsultarAsociado(" DUI,concat(rtrim(nombres),' ',rtrim(apellido1),' ',rtrim(apellido2),' ',rtrim(apellidoCas) ) [Asociado]", " EstadoIngreso in ('2','1') and EstadoAsociado='25' and dui = '" & txtDui.Text.Trim & "' ", " Nombres ", sUsuario, sPassword, sSucursal)
            If dts.Tables.Count > 0 Then
                txtNombre.Text = dts.Tables(0).Rows(0).Item(1)
                recuperarPrestamo()
            End If

        Catch ex As Exception

        End Try

    End Sub
End Class