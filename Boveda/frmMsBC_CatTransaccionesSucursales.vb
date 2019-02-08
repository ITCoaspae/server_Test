Public Class frmMsBC_CatTransaccionesSucursales
    Dim Bancos As New wrBancos.wsLibBancos
    Dim Contabilidad As New wrConta.wsLibContab
    Dim Asociados As New wrAsociados.wsLibAsoc
#Region "metodos"
    Public Sub LlenarCBSucursales(ByVal Campos As String, ByVal Filtro As String, ByVal Orden As String)
        Dim Dts As New DataSet
        Try
            Dts = Asociados.ConsultarSucursales(Campos, Filtro, Orden, sUsuario, sPassword, sSucursal)
            If Dts.Tables.Count > 0 Then
                If Dts.Tables(0).Rows.Count > 0 Then
                    Me.cbSucursales.DataSource = Dts.Tables(0)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Bóveda")
        End Try
       
    End Sub
    Public Sub llenarCbTransacciones(ByVal opcion As Integer, ByVal codTransaccion As Integer)
        Dim Dts As New DataSet
        Try
            Dts = Bancos.ConsultarBCCatTransacciones_Boveda(opcion, codTransaccion)
            If Dts.Tables.Count > 0 Then
                If Dts.Tables(0).Rows.Count > 0 Then
                    Me.cbTransacciones.DataSource = Dts.Tables(0)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Módulo - Bóveda")
        End Try
        

    End Sub
    Public Sub Llenardg(ByVal codSucursal As String, ByVal codTransaccion As Integer _
                        )
        Dim dts As New DataSet
        If Me.rbMostrarTodos.Checked = True Then
            dts = Bancos.ConsultarBcSucursales_TransaccionesBoveda(codSucursal, codTransaccion, 0, 1)
        ElseIf Me.rbSucursal.Checked = True Then
            dts = Bancos.ConsultarBcSucursales_TransaccionesBoveda(codSucursal, codTransaccion, 0, 2)
        ElseIf Me.rbTipoTransaccion.Checked = True Then
            dts = Bancos.ConsultarBcSucursales_TransaccionesBoveda(codSucursal, codTransaccion, 0, 3)
        End If
        Me.dgTranSucursales.DataSource = dts.Tables(0)
        estiloDg()
    End Sub
    Protected Sub estiloDg()
        Me.dgTranSucursales.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgTranSucursales.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgTranSucursales.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        Me.dgTranSucursales.Columns("idSucursalesTransaccionesBov").Visible = False
        Me.dgTranSucursales.Columns("CodSucursal").Visible = False
        Me.dgTranSucursales.Columns("CodTransaccion").Visible = False
        Me.dgTranSucursales.Columns("Nom_Sucursal").HeaderText = "Sucursal"
        Me.dgTranSucursales.Columns("MovBoveda").HeaderText = "Tipo de Movimiento"
        Me.dgTranSucursales.Columns("idCuentaA").HeaderText = "Codigo Cta. Contable Abono"
        Me.dgTranSucursales.Columns("ctaAbono").HeaderText = "Cta. Contable Abono"
        Me.dgTranSucursales.Columns("idCuentaC").HeaderText = "Codigo Cta. Contable Cargo"
        Me.dgTranSucursales.Columns("ctaCargo").HeaderText = "Cta. Contable Cargo"

        Me.dgTranSucursales.Columns("Nom_Sucursal").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgTranSucursales.Columns("idCuentaA").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgTranSucursales.Columns("ctaAbono").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgTranSucursales.Columns("idCuentaC").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgTranSucursales.Columns("ctaCargo").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgTranSucursales.Columns("MovBoveda").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells




    End Sub
#End Region

#Region "Funciones"

#End Region

#Region "Eventos"
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Llenardg(Me.cbSucursales.SelectedValue, Me.cbTransacciones.SelectedValue)
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub frmMsBC_CatTransaccionesSucursales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbSucursales.ValueMember = "CodSucursal"
        Me.cbSucursales.DisplayMember = "Nom_Sucursal"
        Me.cbTransacciones.ValueMember = "codTransaccion"
        Me.cbTransacciones.DisplayMember = "Descripcion"
        LlenarCBSucursales("CodSucursal,Nom_Sucursal", "", "Nom_Sucursal")
        llenarCbTransacciones(1, 0)
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As New frmMsBC_CatTransaccionesSucursalesBov
            With frm
                .Accion = 1
                .ShowDialog()
            End With
            Llenardg(Me.cbSucursales.SelectedValue, Me.cbTransacciones.SelectedValue)
        Catch ex As Exception
            MsgBox("Error, por favor comunicarse con el administrador del sistema." + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo Bóveda")
        End Try
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Dim frm As New frmMsBC_CatTransaccionesSucursalesBov
        Try
            If Me.dgTranSucursales.CurrentRow.Index > -1 Then

                With frm
                    .Accion = 2
                    .cbSucursal.DisplayMember = "Nom_Sucursal"
                    .cbSucursal.ValueMember = "CodSucursal"
                    .LlenarCBSucursales("CodSucursal,Nom_Sucursal", "", "Nom_Sucursal")
                    .cbTransaccion.DisplayMember = "Descripcion"
                    .cbTransaccion.ValueMember = "codTransaccion"
                    .llenarCbTransacciones(1, 0)
                    .txtCtaAbono.Text = Me.dgTranSucursales.Item("idCuentaA", Me.dgTranSucursales.CurrentRow.Index).Value
                    .txtCtaCargos.Text = Me.dgTranSucursales.Item("idCuentaC", Me.dgTranSucursales.CurrentRow.Index).Value
                    .txtDescCtaAbono.Text = Me.dgTranSucursales.Item("ctaAbono", Me.dgTranSucursales.CurrentRow.Index).Value
                    .txtDescCtaCargo.Text = Me.dgTranSucursales.Item("ctaCargo", Me.dgTranSucursales.CurrentRow.Index).Value
                    .idSucursalTransaccionBoveda = Me.dgTranSucursales.Item("idSucursalesTransaccionesBov", Me.dgTranSucursales.CurrentRow.Index).Value
                    .cbSucursal.SelectedValue = Me.dgTranSucursales.Item("CodSucursal", Me.dgTranSucursales.CurrentRow.Index).Value
                    .cbTransaccion.SelectedValue = Me.dgTranSucursales.Item("CodTransaccion", Me.dgTranSucursales.CurrentRow.Index).Value
                    .btnGuardar1.Text = "Modificar"
                    .ShowDialog()
                End With
                Llenardg(Me.cbSucursales.SelectedValue, Me.cbTransacciones.SelectedValue)
            End If
        Catch ex As Exception
            MsgBox("Error, por favor comunicarse con el administrador del sistema." + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo Bóveda")
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Dim frm As New frmMsBC_CatTransaccionesSucursalesBov
        Try
            If Me.dgTranSucursales.CurrentRow.Index > -1 Then

                With frm
                    .Accion = 3
                    .cbSucursal.DisplayMember = "Nom_Sucursal"
                    .cbSucursal.ValueMember = "CodSucursal"
                    .LlenarCBSucursales("CodSucursal,Nom_Sucursal", "", "Nom_Sucursal")
                    .cbTransaccion.DisplayMember = "Descripcion"
                    .cbTransaccion.ValueMember = "codTransaccion"
                    .llenarCbTransacciones(1, 0)
                    .txtCtaAbono.Text = Me.dgTranSucursales.Item("idCuentaA", Me.dgTranSucursales.CurrentRow.Index).Value
                    .txtCtaCargos.Text = Me.dgTranSucursales.Item("idCuentaC", Me.dgTranSucursales.CurrentRow.Index).Value
                    .txtDescCtaAbono.Text = Me.dgTranSucursales.Item("ctaAbono", Me.dgTranSucursales.CurrentRow.Index).Value
                    .txtDescCtaCargo.Text = Me.dgTranSucursales.Item("ctaCargo", Me.dgTranSucursales.CurrentRow.Index).Value
                    .idSucursalTransaccionBoveda = Me.dgTranSucursales.Item("idSucursalesTransaccionesBov", Me.dgTranSucursales.CurrentRow.Index).Value
                    .cbSucursal.SelectedValue = Me.dgTranSucursales.Item("CodSucursal", Me.dgTranSucursales.CurrentRow.Index).Value
                    .cbTransaccion.SelectedValue = Me.dgTranSucursales.Item("CodTransaccion", Me.dgTranSucursales.CurrentRow.Index).Value
                    .cbSucursal.Enabled = False
                    .cbTransaccion.Enabled = False
                    .txtCtaAbono.Enabled = False
                    .txtCtaCargos.Enabled = False
                    .btnGuardar1.Visible = False
                    .ShowDialog()
                End With
                Llenardg(Me.cbSucursales.SelectedValue, Me.cbTransacciones.SelectedValue)
            End If
        Catch ex As Exception
            MsgBox("Error, por favor comunicarse con el administrador del sistema." + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo Bóveda")
        End Try
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If Me.dgTranSucursales.CurrentRow.Index > -1 Then
                If MsgBox("Desea eliminar este registro", MsgBoxStyle.YesNo, "Módulo Bóveda") = MsgBoxResult.Yes Then
                    Dim resultado As Integer
                    resultado = Bancos.EliminarBcSucursales_TransaccionesBoveda(Me.dgTranSucursales.Item("idSucursalesTransaccionesBov",
                                                                                                         Me.dgTranSucursales.CurrentRow.Index).Value
                                                                                                         )
                    If resultado <> 0 Then
                        MsgBox("Registro eliminado exitosamente.", MsgBoxStyle.Information, "Módulo Bóveda")
                        Llenardg(Me.cbSucursales.SelectedValue, Me.cbTransacciones.SelectedValue)
                    Else
                        MsgBox("Error. El registro no pudo ser eliminado, por facor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo Bóveda")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error. El registro no pudo ser eliminado, por favor comunicarse con el administrador del sistema." + vbCrLf + ex.Message, MsgBoxStyle.Critical, "Módulo Bóveda")
        End Try

    End Sub

    Private Sub btnBuscar1_Click(sender As Object, e As EventArgs) Handles btnBuscar1.Click
        Try
            Llenardg(Me.cbSucursales.SelectedValue, Me.cbTransacciones.SelectedValue)
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub
#End Region


End Class