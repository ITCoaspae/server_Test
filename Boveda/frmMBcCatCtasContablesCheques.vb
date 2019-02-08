Public Class frmMBcCatCtasContablesCheques
    Dim bancos As New wrBancos.wsLibBancos
    Dim Asociados As New wrAsociados.wsLibAsoc
    Dim usuarios As New wrAdmin.wsLibAdmin
    Protected Sub llenarDg(ByVal codSucursal As String, ByVal codRol As String, ByVal opcion As Integer)
        Dim dts As New DataSet
        dts = bancos.ConsultarBcCatCtasContablesCheques(codSucursal, codRol, opcion)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgCatCtasCheque.DataSource = dts.Tables(0)
            End If

        End If

    End Sub
    Protected Sub llenarcbSucursales(ByVal campos As String, ByVal filtro As String, ByVal orden As String)
        Dim Dts As New DataSet
        Dts = Asociados.ConsultarSucursales(Campos, Filtro, Orden, sUsuario, sPassword, sSucursal)
        If Dts.Tables.Count > 0 Then
            If Dts.Tables(0).Rows.Count > 0 Then
                Me.cbSucursales.DataSource = Dts.Tables(0)
            End If
        End If
    End Sub
    Protected Sub llenarcbRoles(ByVal campos As String, ByVal filtro As String, ByVal orden As String)
        Dim dts As New DataSet
        dts = usuarios.ConsultarRol(campos, filtro, orden, sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbRoles.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim frm As New frmMsBcCatCtasContablesCheques
        With frm
            .Accion = 1
            .btnGuardar.Text = "Guardar"
            .ShowDialog()


        End With
    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim frm As New frmMsBcCatCtasContablesCheques
        If Me.dgCatCtasCheque.CurrentRow.Index <> -1 Then
            With frm
                .Accion = 2
                .btnGuardar.Text = "Modificar"
                .Id = Me.dgCatCtasCheque.Item("idctascontcheques", Me.dgCatCtasCheque.CurrentRow.Index).Value
                .cbRoles.DisplayMember = "Descripcion"
                .cbRoles.ValueMember = "codRol"
                .cbSucursales.DisplayMember = "Nom_Sucursal"
                .cbSucursales.ValueMember = "CodSucursal"
                .llenarCbRoles("codRol,Descripcion", "", "Descripcion")
                .LlenarCBSucursales("CodSucursal,Nom_Sucursal", "", "Nom_Sucursal")
                .cbRoles.SelectedValue = Me.dgCatCtasCheque.Item("codRol", Me.dgCatCtasCheque.CurrentRow.Index).Value
                .cbSucursales.SelectedValue = Me.dgCatCtasCheque.Item("codSucursal", Me.dgCatCtasCheque.CurrentRow.Index).Value
                .txtCodCtaContable.Text = Me.dgCatCtasCheque.Item("idcuenta", Me.dgCatCtasCheque.CurrentRow.Index).Value
                .txtDescCtaContable.Text = Me.dgCatCtasCheque.Item("ctacontable", Me.dgCatCtasCheque.CurrentRow.Index).Value
                .txtDescripcion.Text = Me.dgCatCtasCheque.Item("aliasctacontable", Me.dgCatCtasCheque.CurrentRow.Index).Value
                .ShowDialog()
            End With
        End If
        
    End Sub

    Private Sub frmMBcCatCtasContablesCheques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cbRoles.DisplayMember = "descripcion"
        cbRoles.ValueMember = "codRol"
        cbSucursales.DisplayMember = "nom_Sucursal"
        cbSucursales.ValueMember = "codSucursal"
        llenarcbRoles("codRol,Descripcion", "", "descripcion")
        llenarcbSucursales("nom_Sucursal,codSucursal", "", "nom_sucursal")
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.rbSucursal.Checked = True Then
            llenarDg(Me.cbSucursales.SelectedValue, "", 2)
        ElseIf Me.rbRoles.Checked = True Then
            llenarDg(Me.cbSucursales.SelectedValue, cbRoles.SelectedValue, 3)
        ElseIf Me.rbMostrarTodos.Checked = True Then
            llenarDg(Me.cbSucursales.SelectedValue, "", 1)
        End If
    End Sub
End Class