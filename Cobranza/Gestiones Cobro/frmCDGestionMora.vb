Public Class frmCDGestionMora

    Dim caja As New wrCaja.wsLibCaja
    Dim prestamo As New wrPrestamo.wsLibPrest
    Dim vAccion, vIdGestion As Integer

    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
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
 
    Private Sub txtCodItem_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodItem.DoubleClick
        Dim dts As New DataSet
        dts = caja.ObtenerListaItems("codItem,Descripcion", " Tipo_Item <>'P' And IdRubro = 11 ", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Dim frm As New frmAGenerico
                With frm
                    .Datos = dts
                    .ColSeleccion = 0
                    .RefrescarGrid()
                    .ShowDialog()
                End With
                If frm.Resultado <> "" Then
                    txtCodItem.Text = frm.Resultado
                    txtDescItemFact.Text = frm.Resultado2
                End If
            End If
        End If
    End Sub

    Private Sub txtCodItem_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodItem.Leave
        Dim dts As New DataSet
        dts = caja.ObtenerListaItems("descripcion", " codItem = '" & txtCodItem.Text.Trim & "' ", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                txtDescItemFact.Text = dts.Tables(0).Rows(0).Item(0).ToString.Trim
            Else
                txtCodItem.Text = ""
                MsgBox("Ingresar CodItem valido", MsgBoxStyle.Critical, "Módulo - Asociados")
            End If
        Else
            txtCodItem.Text = ""
            MsgBox("Ingresar CodItem valido", MsgBoxStyle.Critical, "Módulo - Asociados")
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        If txtDescripcion.Text.Trim.Length > 0 And txtCodItem.Text.Trim.Length > 0 Then
            Dim resultado As Integer
            If accion = 1 Then
                Dim validaPrestamo As Integer
                validaPrestamo = prestamo.validaCodPrestamo(txtCodPrestamo.Text)


                If validaPrestamo = 0 Then
                    MsgBox("Cod. Prestamo incorrecto.", MsgBoxStyle.Exclamation, "Módulo - Prestamo")
                    GoTo FIN
                End If


                resultado = prestamo.insertarGestionMora(txtDescripcion.Text, txtCosto.Text, txtCodItem.Text, txtCodPrestamo.Text, Format(dtpFechaGestion.Value, "Short Date"), _
                                                         sUsuario, True, txtCantidad.Value, sPassword, sSucursal)
                'resultado = asociados.insertarCatServiciosCoopas(txtDescripcion.Text.ToUpper, txtCosto.Value, _
                '                                             txtCodItem.Text.Trim, Now, _
                '                                             sUsuario, chkActivo.Checked, _
                '                                             chkPaquete.Checked, txtCantidad.Value)
                If resultado < -1 Then
                    MsgBox("No tiene permiso para crear gestiones", MsgBoxStyle.Information, "Módulo - Prestamos")
                ElseIf resultado > 0 Then
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Prestamos")
                    Limpiar()
                Else
                    MsgBox("El Registro no fue ingresado.", MsgBoxStyle.Exclamation, "Módulo - Prestamo")
                End If
            ElseIf accion = 2 Then
                If txtPerdonado.Value > (txtCosto.Value - txtPagado.Value) Then
                    MsgBox("El monto perdonado no puede ser mayor que lo adeudado.", MsgBoxStyle.Exclamation, "Módulo - Prestamos")
                    GoTo FIN
                End If
                resultado = prestamo.ModificarGestionMora(Me.idGestion, sUsuario, txtDescripcion.Text, txtPerdonado.Value, sPassword, sSucursal)
                'resultado = asociados.modificarCatServiciosCoopas(txtDescripcion.Text.ToUpper, txtCosto.Value, _
                '                                                  txtCodItem.Text.Trim, Now, _
                '                                                  sUsuario, chkActivo.Checked, _
                '                                                  idCatServiciosCosta, chkPaquete.Checked, _
                '                                                  txtCantidad.Value)
                If resultado < 0 Then
                    MsgBox("No tiene permiso para modificar", MsgBoxStyle.Information, "Módulo - Prestamos")
                ElseIf resultado > 0 Then
                    MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information, "Módulo - Prestamos")
                    Me.Close()
                Else
                    MsgBox("El Registro no fue actualizado.", MsgBoxStyle.Exclamation, "Módulo - Prestamos")
                End If
            End If
        End If
FIN:
    End Sub

    Public Sub Limpiar()
        txtCodPrestamo.Text = ""
        txtCantidad.Value = 0
        txtCodItem.Text = ""
        txtCosto.Text = ""
        txtDescItemFact.Text = ""
        txtDescripcion.Text = ""
        dtpFechaGestion.Value = Date.Now
        txtCodPrestamo.Focus()

    End Sub

    Public Sub estiloDg()
        If Me.accion = 1 Then
            txtCantidad.Enabled = True
            txtCodItem.Enabled = True
            txtCodPrestamo.Enabled = True
            txtCosto.Enabled = True
            txtDescItemFact.Enabled = True
            txtDescripcion.Enabled = True
            dtpFechaGestion.Enabled = True
            txtPagado.Enabled = False
            txtPerdonado.Enabled = False
        End If
        If Me.accion = 2 Then
            txtCantidad.Enabled = False
            txtCodItem.Enabled = False
            txtCodPrestamo.Enabled = False
            txtCosto.Enabled = False
            txtDescItemFact.Enabled = False
            dtpFechaGestion.Enabled = False
            txtDescripcion.Enabled = True
            txtPerdonado.Enabled = True
        End If
    End Sub

    Private Sub frmCDGestionMora_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Me.accion = 1 Then
            Limpiar()
        End If
        estiloDg()
    End Sub

End Class