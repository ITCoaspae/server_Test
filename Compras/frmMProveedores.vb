Public Class frmMProveedores

    Dim contabilidad As New wrConta.wsLibContab
    Protected Sub estiloDg()
        Me.dgProveedores.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgProveedores.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.dgProveedores.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgProveedores.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders

        Me.dgProveedores.Columns("noregistro").HeaderText = "No. Registro"
        Me.dgProveedores.Columns("nit").HeaderText = "NIT"
        Me.dgProveedores.Columns("dui").HeaderText = "DUI"
        Me.dgProveedores.Columns("proveedor").HeaderText = "Nombre del Proveedor"
        Me.dgProveedores.Columns("direccion").HeaderText = "Dirección"
        Me.dgProveedores.Columns("telefono").HeaderText = "Teléfono"
        Me.dgProveedores.Columns("email").HeaderText = "Email"
        Me.dgProveedores.Columns("representanteLegal").HeaderText = "Representante Legal"
        Me.dgProveedores.Columns("TipoContribuyente").HeaderText = "TipoContribuyente"

        Me.dgProveedores.Columns("codDepartamento").Visible = False
        Me.dgProveedores.Columns("codMunicipio").Visible = False
    End Sub
    Protected Sub llenarDgProveedores(ByVal opcion As Integer, ByVal noRegistro As String, ByVal nit As String, ByVal proveedor As String)
        Dim dts As New DataSet
        dts = contabilidad.consultarCaProveedores(opcion, noRegistro, nit, proveedor)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgProveedores.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Protected Sub buscar()
        Try
            If Me.rbMostrarTodos.Checked = True Then
                llenarDgProveedores(1, "", "", "")
            ElseIf Me.rbNit.Checked = True Then
                llenarDgProveedores(4, "", Me.txtNit.Text, "")
            ElseIf Me.rbProveedor.Checked = True Then
                llenarDgProveedores(2, "", "", txtProveedor.Text.Trim)
            ElseIf Me.rbNoRegistro.Checked = True Then
                llenarDgProveedores(3, txtNoRegistro.Text, "", "")
            End If
            estiloDg()
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnBuscar1_Click(sender As Object, e As EventArgs) Handles btnBuscar1.Click
        buscar()
    End Sub

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        Try
            Dim frm As New frmMsProveedores
            With frm
                .accion = 1
                .ShowDialog()
            End With
            buscar()
        Catch ex As Exception
            MsgBox("Error, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Compras")
        End Try
    End Sub

    Private Sub btnMod1_Click(sender As Object, e As EventArgs) Handles btnMod1.Click
        Try
            If Me.dgProveedores.CurrentRow.Index > -1 Then
                Dim frm As New frmMsProveedores
                With frm
                    .accion = 2
                    .btnGuardar.Text = "Actualizar"
                    .cbDepartamento.ValueMember = "codDepartamento"
                    .cbDepartamento.DisplayMember = "Departamento"
                    .cbMunicipio.ValueMember = "codMunicipio"
                    .cbMunicipio.DisplayMember = "Municipio"
                    .cbTipoContri.ValueMember = "idCatalogo"
                    .cbTipoContri.DisplayMember = "Descripcion"
                    .llenarTipoContribuyente()
                    .llenarCbDepartamento("CodDepartamento,Departamento", "", "Departamento")
                    .txtNoRegistro.Text = IIf(Me.dgProveedores.Item("noRegistro", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("noRegistro", Me.dgProveedores.CurrentRow.Index).Value)
                    .txtNit.Text = IIf(Me.dgProveedores.Item("nit", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("nit", Me.dgProveedores.CurrentRow.Index).Value)
                    .txtDui.Text = IIf(Me.dgProveedores.Item("dui", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("dui", Me.dgProveedores.CurrentRow.Index).Value)
                    .txtProveedor.Text = IIf(Me.dgProveedores.Item("proveedor", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("proveedor", Me.dgProveedores.CurrentRow.Index).Value)
                    .cbDepartamento.SelectedValue = IIf(Me.dgProveedores.Item("codDepartamento", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("codDepartamento", Me.dgProveedores.CurrentRow.Index).Value)
                    .llenarCbMunicipio("codMunicipio,Municipio", "CodDepartamento = '" & dgProveedores.Item("codDepartamento", Me.dgProveedores.CurrentRow.Index).Value & "'", "")
                    .cbMunicipio.Text = IIf(Me.dgProveedores.Item("codMunicipio", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("codMunicipio", Me.dgProveedores.CurrentRow.Index).Value)

                    .txtDireccion.Text = IIf(Me.dgProveedores.Item("direccion", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("direccion", Me.dgProveedores.CurrentRow.Index).Value)
                    .txtTelefono.Text = IIf(Me.dgProveedores.Item("telefono", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("telefono", Me.dgProveedores.CurrentRow.Index).Value)
                    .txtEmail.Text = IIf(Me.dgProveedores.Item("email", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("email", Me.dgProveedores.CurrentRow.Index).Value)
                    .txtRepresentante.Text = IIf(Me.dgProveedores.Item("representanteLegal", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("representanteLegal", Me.dgProveedores.CurrentRow.Index).Value)
                    .idProveedor = IIf(Me.dgProveedores.Item("idProveedor", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("idProveedor", Me.dgProveedores.CurrentRow.Index).Value)
                    .cbTipoContri.SelectedValue = IIf(Me.dgProveedores.Item("TipoContribuyente", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("TipoContribuyente", Me.dgProveedores.CurrentRow.Index).Value)
                    .ShowDialog()
                End With
                buscar()
            End If
        Catch ex As Exception
            MsgBox("Error, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Compras")
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            If Me.dgProveedores.CurrentRow.Index > -1 Then
                Dim frm As New frmMsProveedores
                With frm
                    .accion = 3
                    .cbDepartamento.ValueMember = "codDepartamento"
                    .cbDepartamento.DisplayMember = "Departamento"
                    .cbMunicipio.ValueMember = "codMunicipio"
                    .cbMunicipio.DisplayMember = "Municipio"
                    .llenarCbDepartamento("CodDepartamento,Departamento", "", "Departamento")
                    .txtNoRegistro.Text = IIf(Me.dgProveedores.Item("noRegistro", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("noRegistro", Me.dgProveedores.CurrentRow.Index).Value)
                    .txtNit.Text = IIf(Me.dgProveedores.Item("nit", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("nit", Me.dgProveedores.CurrentRow.Index).Value)
                    .txtDui.Text = IIf(Me.dgProveedores.Item("dui", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("dui", Me.dgProveedores.CurrentRow.Index).Value)
                    .txtProveedor.Text = IIf(Me.dgProveedores.Item("proveedor", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("proveedor", Me.dgProveedores.CurrentRow.Index).Value)
                    .cbDepartamento.SelectedValue = IIf(Me.dgProveedores.Item("codDepartamento", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("codDepartamento", Me.dgProveedores.CurrentRow.Index).Value)
                    .llenarCbMunicipio("codMunicipio,Municipio", "CodDepartamento = '" & dgProveedores.Item("codDepartamento", Me.dgProveedores.CurrentRow.Index).Value & "'", "")
                    .cbMunicipio.Text = IIf(Me.dgProveedores.Item("codMunicipio", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("codMunicipio", Me.dgProveedores.CurrentRow.Index).Value)

                    .txtDireccion.Text = IIf(Me.dgProveedores.Item("direccion", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("direccion", Me.dgProveedores.CurrentRow.Index).Value)
                    .txtTelefono.Text = IIf(Me.dgProveedores.Item("telefono", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("telefono", Me.dgProveedores.CurrentRow.Index).Value)
                    .txtEmail.Text = IIf(Me.dgProveedores.Item("email", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("email", Me.dgProveedores.CurrentRow.Index).Value)
                    .txtRepresentante.Text = IIf(Me.dgProveedores.Item("representanteLegal", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                                      Me.dgProveedores.Item("representanteLegal", Me.dgProveedores.CurrentRow.Index).Value)
                    .idProveedor = IIf(Me.dgProveedores.Item("idProveedor", Me.dgProveedores.CurrentRow.Index).Value Is DBNull.Value, "",
                                              Me.dgProveedores.Item("idProveedor", Me.dgProveedores.CurrentRow.Index).Value)
                    .cbDepartamento.Enabled = False
                    .cbMunicipio.Enabled = False
                    .txtNoRegistro.ReadOnly = True
                    .txtNit.ReadOnly = True
                    .txtDui.ReadOnly = True
                    .txtProveedor.ReadOnly = True
                    .txtDireccion.ReadOnly = True
                    .txtTelefono.ReadOnly = True
                    .txtEmail.ReadOnly = True
                    .txtRepresentante.ReadOnly = True
                    .btnGuardar.Enabled = False
                    .ShowDialog()

                End With

            End If
        Catch ex As Exception
            MsgBox("Error, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Compras")
        End Try
    End Sub

    Private Sub btnAnular1_Click(sender As Object, e As EventArgs) Handles btnAnular1.Click
        Try
            If Me.dgProveedores.CurrentRow.Index > -1 Then
                If MsgBox("¿Desea eliminar este registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Módulo - Compras") = MsgBoxResult.Yes Then
                    Dim resultado As Integer
                    resultado = contabilidad.eliminarCaProveedores(Me.dgProveedores.Item("idProveedor", Me.dgProveedores.CurrentRow.Index).Value)
                    If resultado <> 0 Then
                        MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information, "Módulo - Compras")
                    Else
                        MsgBox("El registro no pudo ser eliminado por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Compras")
                    End If
                End If
                buscar()
            End If
        Catch ex As Exception
            MsgBox("Error, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Compras")
        End Try
    End Sub
End Class