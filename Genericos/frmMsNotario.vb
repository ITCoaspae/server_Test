Public Class frmMsNotario
    Dim CREDITO As New wrCredito.wsLibCred
    Public vACCION As Integer '1 = INSERTAR, 2 MODIFICAR, 3 CONSULTAR
    Public vIDNOTARIO As Integer
    Private Sub frmMsNotario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If vACCION = 1 Then
            Me.Text = "Ingresar Notario"
            Me.btnGuardar1.Text = "Guardar"
        ElseIf vACCION = 2 Then
            Me.Text = "Modificar Notario"
            Me.btnGuardar1.Text = "Modificar"
            CONSULTARNOTARIO()
        ElseIf vACCION = 3 Then
            Me.Text = "Consultar Información Notario"
            Me.btnGuardar1.Text = "Consultar"
            Me.btnGuardar1.Enabled = False
            CONSULTARNOTARIO()
            SOLOLECTURA()
        End If
    End Sub
    Protected Sub GUARDARNOTARIO()
        Dim RESULTADO As Integer
        Dim TIPO As Boolean
        If Me.cbTIPO.SelectedIndex = 0 Then
            TIPO = True
        Else
            TIPO = False
        End If
        RESULTADO = CREDITO.INSERTARGRNOTARIOS(sUsuario, sPassword, sSucursal, Me.txtNombres.Text.Trim, _
                                                Me.txtApellido1.Text.Trim, Me.txtApellido2.Text.Trim, _
                                                Me.txtDirecOficina.Text.Trim, Me.txtTelefono.Text.Trim, _
                                                Me.txtCEL.Text.Trim, Me.txtEmail.Text.Trim, TIPO, _
                                                Me.txtDespacho.Text.Trim)
        If RESULTADO = 1 Then
            MsgBox("Notario ingresado exitosamente", MsgBoxStyle.Information, "")
        Else
            MsgBox("No se pudo ingresar el registro, por favor comuniquese con el administrador del sistema.", MsgBoxStyle.Critical, "")
        End If
    End Sub
    Protected Sub MODIFICARNOTARIO()
        Dim RESULTADO As Integer
        Dim TIPO As Boolean
        If Me.cbTIPO.SelectedIndex = 0 Then
            TIPO = True
        Else
            TIPO = False
        End If
        RESULTADO = CREDITO.MODIFICARGRNOTARIOS(sUsuario, sPassword, sSucursal, Me.txtNombres.Text.Trim, _
                                                Me.txtApellido1.Text.Trim, Me.txtApellido2.Text.Trim, _
                                                Me.txtDirecOficina.Text.Trim, Me.txtTelefono.Text.Trim, _
                                                Me.txtCEL.Text.Trim, Me.txtEmail.Text.Trim, TIPO, _
                                                Me.txtDespacho.Text.Trim, vIDNOTARIO)
        If RESULTADO = 1 Then
            MsgBox("Notario ingresado exitosamente", MsgBoxStyle.Information, "")
        Else
            MsgBox("No se pudo ingresar el registro, por favor comuniquese con el administrador del sistema.", MsgBoxStyle.Critical, "")
        End If
    End Sub
    Protected Sub CONSULTARNOTARIO()
        Dim DTS As New DataSet
        Dim TIPO As String
        DTS = CREDITO.CONSULTARGRNOTARIO(sUsuario, sPassword, sSucursal, 2, vIDNOTARIO, "", "", "")
        Me.txtNombres.Text = DTS.Tables(0).Rows(0).Item("NOMBRES")
        Me.txtApellido1.Text = DTS.Tables(0).Rows(0).Item("APELLIDO1")
        Me.txtApellido2.Text = DTS.Tables(0).Rows(0).Item("APELLIDO2")
        Me.txtCEL.Text = DTS.Tables(0).Rows(0).Item("CELULAR")
        Me.txtTelefono.Text = DTS.Tables(0).Rows(0).Item("TELEFONO")
        Me.txtDirecOficina.Text = DTS.Tables(0).Rows(0).Item("DIREC_OFICINA")
        Me.txtEmail.Text = DTS.Tables(0).Rows(0).Item("EMAIL")
        Me.txtDespacho.Text = DTS.Tables(0).Rows(0).Item("DESPACHO")
        TIPO = DTS.Tables(0).Rows(0).Item("TIPO").ToString.Trim
        If TIPO = "Interno" Then
            Me.cbTIPO.SelectedIndex = 0
        Else
            Me.cbTIPO.SelectedIndex = 1
        End If
    End Sub
    Protected Sub SOLOLECTURA()
        Me.txtNombres.ReadOnly = True
        Me.txtApellido1.ReadOnly = True
        Me.txtApellido2.ReadOnly = True
        Me.txtCEL.ReadOnly = True
        Me.txtTelefono.ReadOnly = True
        Me.txtDirecOficina.ReadOnly = True
        Me.txtEmail.ReadOnly = True
        Me.txtDespacho.ReadOnly = True
        Me.cbTIPO.Enabled = False
    End Sub
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            If vACCION = 1 Then
                GUARDARNOTARIO()
            ElseIf vACCION = 2 Then
                MODIFICARNOTARIO()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class