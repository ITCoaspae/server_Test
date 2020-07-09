Public Class frmMCorrelativosDocumentosCaja
    Dim caja As New wrCaja.wsLibCaja
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim Seguridad As New wrAdmin.wsLibAdmin
#Region "Metodos"
    Protected Sub llenarDgCorrelativos(ByVal codSucursal As String, ByVal codCajero As Integer, _
                                    ByVal idTipoDoc As Integer, ByVal idCorrCaja As Integer, _
                                    ByVal opcion As Integer)
        Dim dts As New DataSet
        dts = caja.consultarCaCorrelativoCaja(codSucursal, codCajero, idTipoDoc, _
                                              idCorrCaja, opcion)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.dgCorrCaja.DataSource = dts.Tables(0)
                EstiloDg()
            End If
        End If
    End Sub
    Protected Sub EstiloDg()
        Me.dgCorrCaja.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.dgCorrCaja.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Me.dgCorrCaja.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        Me.dgCorrCaja.Columns("idCorrCaja").Visible = False
        Me.dgCorrCaja.Columns("CodSucursal").Visible = False
        Me.dgCorrCaja.Columns("idTipoDoc").Visible = False

        Me.dgCorrCaja.Columns("noCaja").HeaderText = "No. Caja"
        Me.dgCorrCaja.Columns("minimo").HeaderText = "Minimo"
        Me.dgCorrCaja.Columns("maximo").HeaderText = "Maximo"
        Me.dgCorrCaja.Columns("Correlativo").HeaderText = "Número Actual"
        Me.dgCorrCaja.Columns("Nom_Sucursal").HeaderText = "Sucursal"
        Me.dgCorrCaja.Columns("tipoDocumento").HeaderText = "Tipo Documento"


        Me.dgCorrCaja.Columns("Nom_Sucursal").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgCorrCaja.Columns("tipoDocumento").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

    End Sub
    Protected Sub LlenarCbSucursales(ByVal Campos, ByVal Filtro, ByVal Orden, ByVal sUsuario, ByVal sPassword, ByVal sSucursal)
        Dim Dts As New DataSet
        Dts = Asociados.ConsultarSucursales(Campos, Filtro, Orden, sUsuario, sPassword, sSucursal)
        Me.cbSucursales.DataSource = Dts.Tables(0)
    End Sub
#End Region
#Region "Funciones"
    Protected Function eliminarCorrelativoCaja(ByVal idCorrCaja As Integer)
        Dim resultado As Integer
        resultado = caja.eliminarCaCorrelativoCaja(idCorrCaja)
        Return resultado
    End Function
#End Region
#Region "Eventos"
    Private Sub frmMCorrelativosDocumentosCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbSucursales.DisplayMember = "Nom_Sucursal"
        Me.cbSucursales.ValueMember = "CodSucursal"
        'LlenarCbSucursales("nom_sucursal,codsucursal", "", "Nom_Sucursal", sUsuario, sPassword, sSucursal)


        Dim dtsRoles As New DataSet
        dtsRoles = Seguridad.ConsultarRolesUsuario(sUsuario, "", 2)
        For I As Integer = 0 To dtsRoles.Tables(0).Rows.Count - 1
            If Seguridad.ConsultarPermisoProcesos("CAL001", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                LlenarCbSucursales("CodSucursal,Nom_Sucursal", "codSucursal = '" & sSucursal & "'", "Nom_Sucursal", sUsuario, sPassword, sSucursal)
                chkMostrarTodos.Enabled = False
                Exit For
            ElseIf Seguridad.ConsultarPermisoProcesos("CAL004", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                LlenarCbSucursales("CodSucursal,Nom_Sucursal", "", "Nom_Sucursal", sUsuario, sPassword, sSucursal)
                chkMostrarTodos.Enabled = True
                Exit For
            End If
        Next

    End Sub
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If Me.chkMostrarTodos.Checked = True Then
                llenarDgCorrelativos(Me.cbSucursales.SelectedValue, 0, 0, 0, 1)
            Else
                llenarDgCorrelativos(Me.cbSucursales.SelectedValue, 0, 0, 0, 2)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            Dim frm As New frmMsCorrelativosDocumentsoCaja
            With frm
                .accion = 1
                .ShowDialog()
            End With
            If Me.chkMostrarTodos.Checked = True Then
                llenarDgCorrelativos(Me.cbSucursales.SelectedValue, 0, 0, 0, 1)
            Else
                llenarDgCorrelativos(Me.cbSucursales.SelectedValue, 0, 0, 0, 2)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnModificar_Click_1(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim frm As New frmMsCorrelativosDocumentsoCaja
            With frm
                .accion = 2
                .cbCajero.DisplayMember = "noCaja"
                .cbCajero.ValueMember = "noCaja"
                .cbSucursal.DisplayMember = "Nom_Sucursal"
                .cbSucursal.ValueMember = "CodSucursal"
                .cbDocumento.DisplayMember = "tipoDocumento"
                .cbDocumento.ValueMember = "idTipoDoc"
                .LlenarCbSucursales("nom_Sucursal,codSucursal", "", "Nom_Sucursal", sUsuario, sPassword, sSucursal)
                .llenarCajero("noCaja", "CodSucursal = '" & Me.dgCorrCaja.Item("CodSucursal", Me.dgCorrCaja.CurrentRow.Index).Value & "'", "")
                .llenarCbDocumentos(True, 0, 1)
                .cbSucursal.Enabled = False
                .cbCajero.Enabled = False
                .idCorrCaja = Me.dgCorrCaja.Item("idCorrCaja", Me.dgCorrCaja.CurrentRow.Index).Value
                .cbSucursal.SelectedValue = Me.dgCorrCaja.Item("codSucursal", Me.dgCorrCaja.CurrentRow.Index).Value
                .cbCajero.SelectedValue = Me.dgCorrCaja.Item("noCaja", Me.dgCorrCaja.CurrentRow.Index).Value
                .cbDocumento.SelectedValue = Me.dgCorrCaja.Item("idTipoDoc", Me.dgCorrCaja.CurrentRow.Index).Value
                .txtMinimo.Text = Me.dgCorrCaja.Item("minimo", Me.dgCorrCaja.CurrentRow.Index).Value
                .txtMaximo.Text = Me.dgCorrCaja.Item("maximo", Me.dgCorrCaja.CurrentRow.Index).Value
                .txtCorrIni.Text = Me.dgCorrCaja.Item("correlativo", Me.dgCorrCaja.CurrentRow.Index).Value
                .ShowDialog()
                If Me.chkMostrarTodos.Checked = True Then
                    llenarDgCorrelativos(Me.cbSucursales.SelectedValue, 0, 0, 0, 1)
                Else
                    llenarDgCorrelativos(Me.cbSucursales.SelectedValue, 0, 0, 0, 2)
                End If
            End With
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If MsgBox("¿Desea eliminar el registro?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo - Caja") = MsgBoxResult.Yes Then
                If eliminarCorrelativoCaja(Me.dgCorrCaja.Item("idCorrCaja", Me.dgCorrCaja.CurrentRow.Index).Value) <> 0 Then
                    MsgBox("Registro eliminado exitosamente", MsgBoxStyle.Information, "Módulo - Caja")
                Else
                    MsgBox("Error, Registro no pudo ser eliminado. Por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Information, "Módulo - Caja")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar_Click_1(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            Dim frm As New frmMsCorrelativosDocumentsoCaja
            With frm
                .accion = 3
                .cbCajero.DisplayMember = "noCaja"
                .cbCajero.ValueMember = "noCaja"
                .cbSucursal.DisplayMember = "Nom_Sucursal"
                .cbSucursal.ValueMember = "CodSucursal"
                .cbDocumento.DisplayMember = "tipoDocumento"
                .cbDocumento.ValueMember = "idTipoDoc"
                .LlenarCbSucursales("nom_Sucursal,codSucursal", "", "Nom_Sucursal", sUsuario, sPassword, sSucursal)
                .llenarCajero("noCaja", "CodSucursal = '" & Me.dgCorrCaja.Item("CodSucursal", Me.dgCorrCaja.CurrentRow.Index).Value & "'", "Nombre")
                .llenarCbDocumentos(True, 0, 1)
                .cbSucursal.SelectedValue = Me.dgCorrCaja.Item("codSucursal", Me.dgCorrCaja.CurrentRow.Index).Value
                .cbCajero.SelectedValue = Me.dgCorrCaja.Item("noCaja", Me.dgCorrCaja.CurrentRow.Index).Value
                .cbDocumento.SelectedValue = Me.dgCorrCaja.Item("idTipoDoc", Me.dgCorrCaja.CurrentRow.Index).Value
                .txtMinimo.Text = Me.dgCorrCaja.Item("minimo", Me.dgCorrCaja.CurrentRow.Index).Value
                .txtMaximo.Text = Me.dgCorrCaja.Item("maximo", Me.dgCorrCaja.CurrentRow.Index).Value
                .txtCorrIni.Text = Me.dgCorrCaja.Item("correlativo", Me.dgCorrCaja.CurrentRow.Index).Value
                .cbSucursal.Enabled = False
                .cbCajero.Enabled = False
                .cbDocumento.Enabled = False
                .txtMinimo.ReadOnly = True
                .txtMaximo.ReadOnly = True
                .txtCorrIni.ReadOnly = True
                .ShowDialog()
            End With
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMCorrelativosDocumentosCaja_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
#End Region
End Class