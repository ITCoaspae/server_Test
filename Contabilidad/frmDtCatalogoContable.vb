Public Class frmDtCatalogoContable
    Dim contabilidad As New wrConta.wsLibContab
    Private accion As Integer
    Private idCuenta As String
    Dim final, legal, inhabilitada As String
#Region "propiedades"
    Public Property acccionP() As Integer
        Get
            Return Me.accion
        End Get
        Set(ByVal Value As Integer)
            Me.accion = Value
        End Set
    End Property
    Public Property idCuentaP() As String
        Get
            Return Me.idCuenta
        End Get
        Set(ByVal Value As String)
            Me.idCuenta = Value
        End Set
    End Property
#End Region

#Region "Metodos"

    Protected Sub llenar_TipoCuenta()
        Dim dts As New DataSet
        dts = contabilidad.consultarCat_TipoCtas_Contables("", "", sUsuario)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbTipoCuenta.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Private Sub recuperarDatos(idCuenta As String)
        Dim dts As New DataSet
        dts = contabilidad.ObtenerCatContab("idcuenta,descripcion,cta_Dependencia,nivel,tipo_cuenta,final,legal,inhabilitado", " idcuenta = '" & idCuenta & "'", "idcuenta", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                txtCodCta.Text = idCuenta.ToString.Trim
                txtCodCta.Enabled = False
                txtNombre.Text = dts.Tables(0).Rows(0).Item("descripcion").ToString.ToUpper
                txtCtaDependencia.Text = dts.Tables(0).Rows(0).Item("cta_Dependencia").ToString.ToUpper
                txtNivel.Value = dts.Tables(0).Rows(0).Item("nivel")
                cbTipoCuenta.SelectedValue = dts.Tables(0).Rows(0).Item("tipo_cuenta")
                If dts.Tables(0).Rows(0).Item("final") = "S" Then
                    chkFinal.Checked = True
                Else
                    chkFinal.Checked = False
                End If
                If dts.Tables(0).Rows(0).Item("legal") = "S" Then
                    chkLegal.Checked = True
                Else
                    chkLegal.Checked = False
                End If
                If dts.Tables(0).Rows(0).Item("inhabilitado") = "S" Then
                    chkInhabilitada.Checked = True
                Else
                    chkInhabilitada.Checked = False
                End If
            Else
                 MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End If
        End If
    End Sub
#End Region
#Region "Funciones"
    Private Function validaciones() As Boolean
        Me.C1SuperErrorProvider1.Clear()
        Dim valido As Boolean = True
        If txtCtaDependencia.Text.Trim.Length = 0 Then
            Me.C1SuperErrorProvider1.SetError(txtCtaDependencia, "Campo Requerido")
            valido = False
        End If
        If txtCodCta.Text.Trim.Length = 0 Then
            Me.C1SuperErrorProvider1.SetError(txtCodCta, "Campo Requerido")
            valido = False
        End If
        If txtNombre.Text.Trim.Length = 0 Then
            Me.C1SuperErrorProvider1.SetError(txtNombre, "Campo Requerido")
            valido = False
        End If
        Return valido
    End Function
#End Region
    Private Sub chkFinal_CheckedChanged(sender As Object, e As EventArgs) Handles chkFinal.CheckedChanged
        If chkFinal.Checked = True Then
            final = "S"
        Else
            final = "N"
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim campos As String = ""
        Dim valores As String = ""
        If validaciones() = True Then

            If accion = 1 Then 'Insertar
                campos = "idcuenta, descripcion, cta_dependencia, nivel, tipo_cuenta, final, legal, inhabilitado, usuarioCrea, fechaCreacion, pcCrea"
                valores = " '" & txtCodCta.Text &
                    "', '" & txtNombre.Text.ToUpper &
                    "', '" & txtCtaDependencia.Text &
                    "', '" & txtNivel.Value &
                    "', '" & cbTipoCuenta.SelectedValue &
                    "', '" & final &
                    "', '" & legal &
                    "', '" & inhabilitada &
                    "', '" & sUsuario &
                    "', '" & Now.ToShortDateString &
                    "', '" & sPC & "'  "
                'MsgBox(campos & " " & valores)
                If contabilidad.InsertaCuentaContab(campos, valores, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Registro ingresado exitosamente.", MsgBoxStyle.Information)
                    Me.Close()
                Else
                     MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If
            ElseIf accion = 2 Then 'Modificar

                valores = "cta_dependencia = '" & txtCtaDependencia.Text &
                    "',  descripcion = '" & txtNombre.Text.ToUpper &
                    "', tipo_cuenta = '" & cbTipoCuenta.SelectedValue &
                    "', final = '" & final &
                    "', legal = '" & legal &
                    "', Nivel = '" & txtNivel.Value &
                    "', inhabilitado = '" & inhabilitada &
                    "',  usuarioModifica = '" & sUsuario &
                    "', fechaModificacion = '" & Now.ToShortDateString &
                    "', pcModifica ='" & sPC.ToUpper & "' "
                If chkInhabilitada.Checked = True Then
                    valores = String.Concat(valores, ", usuarioInhabilita='" & sUsuario & "',fechaInhabilitacion = '" & Now.ToShortDateString & "',pcInhabilita = '" & sPC & "'")
                End If

                If contabilidad.ModificaCuentaContab(txtCodCta.Text, valores, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Registro actualizado exitosamente.", MsgBoxStyle.Information)
                    Me.Close()
                Else
                     MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If
            End If
        End If

    End Sub

    Private Sub chkInhabilitada_CheckedChanged(sender As Object, e As EventArgs) Handles chkInhabilitada.CheckedChanged
        If chkInhabilitada.Checked = True Then
            inhabilitada = "S"
        Else
            inhabilitada = "N"
        End If
    End Sub

    Private Sub chkLegal_CheckedChanged(sender As Object, e As EventArgs) Handles chkLegal.CheckedChanged
        If chkLegal.Checked = True Then
            legal = "S"
        Else
            legal = "N"
        End If
    End Sub

    Private Sub frmDtCatalogoContable_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.cbTipoCuenta.DisplayMember = "Descripcion"
        Me.cbTipoCuenta.ValueMember = "Tipo_Cuenta"
        llenar_TipoCuenta()
        Dim data As New AutoCompleteStringCollection
        Dim dts As New DataSet
        dts = contabilidad.ObtenerCatContab("idcuenta,descripcion,cta_Dependencia,nivel,tipo_cuenta,final,legal,inhabilitado", "", "idcuenta", sUsuario, sPassword, sSucursal)
        Dim i As Integer
        For i = 0 To dts.Tables(0).Rows.Count - 1
            data.Add(dts.Tables(0).Rows(i).Item("idcuenta").ToString.Trim)
        Next

        Me.txtCodCta.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtCodCta.AutoCompleteCustomSource = data
        Me.txtCodCta.AutoCompleteMode = AutoCompleteMode.Suggest

        Me.txtCtaDependencia.AutoCompleteSource = AutoCompleteSource.CustomSource
        Me.txtCtaDependencia.AutoCompleteCustomSource = data
        Me.txtCtaDependencia.AutoCompleteMode = AutoCompleteMode.Suggest

        If accion = 1 Then
            Me.btnGuardar.Text = "Guardar"
        ElseIf accion = 2 Then
            Me.btnGuardar.Text = "Modificar"
            recuperarDatos(idCuenta)
        End If
    End Sub

    Private Sub txtCtaDependencia_LostFocus(sender As Object, e As EventArgs) Handles txtCtaDependencia.LostFocus
        Dim dts As New DataSet
        dts = contabilidad.ObtenerCatContab("idcuenta,descripcion,cta_Dependencia,nivel,tipo_cuenta,final,legal,inhabilitado", " idcuenta = '" & txtCtaDependencia.Text.Trim & "'", "idcuenta", sUsuario, sPassword, sSucursal)

        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                txtNivel.Value = CInt(dts.Tables(0).Rows(0).Item("nivel")) + 1
                cbTipoCuenta.SelectedValue = dts.Tables(0).Rows(0).Item("tipo_cuenta")
                If accion = 1 Then
                    txtCodCta.Text = txtCtaDependencia.Text.Trim
                End If

                If dts.Tables(0).Rows(0).Item("final").ToString.Trim.Equals("S") Then
                    MsgBox("No se pueden agregar más dependencias.", MsgBoxStyle.Critical)
                    Me.btnGuardar.Enabled = False
                Else
                    Me.btnGuardar.Enabled = True
                End If
                Me.cbTipoCuenta.Enabled = False
                Me.txtNivel.Enabled = False
                txtCodCta.Focus()
            Else
                Me.cbTipoCuenta.Enabled = True
                Me.txtNivel.Enabled = True
                Me.btnGuardar.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtCtaDependencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCtaDependencia.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodCta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodCta.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class