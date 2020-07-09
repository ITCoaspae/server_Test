Public Class frmDetRubros
    Dim caja As New wrCaja.wsLibCaja
    Dim vAccion, vIdRubro As Integer
    Dim vDescripcion As String
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property idRubro() As Integer
        Get
            Return vIdRubro
        End Get
        Set(ByVal value As Integer)
            vIdRubro = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return vDescripcion
        End Get
        Set(ByVal value As String)
            vDescripcion = value
        End Set
    End Property



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim valores As String = ""
            If accion = 1 Then
                valores = " '" & txtIdRubro.Text.Trim & "','" & txtRubro.Text.Trim.ToUpper & "' "
                If (caja.insertarCaRubro("idRubro,descripcion", "" & valores & "", sUsuario, sPassword, sSucursal)) Then
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information)
                    Me.Close()
                Else
                    MsgBox("Registro no pudo ser ingresado.", MsgBoxStyle.Critical)
                End If
            ElseIf accion = 2 Then

                If idRubro > 0 Then
                    valores = " descripcion = '" & txtRubro.Text.Trim.ToUpper & "' "
                    If (caja.modificarCaRubro(valores, idRubro, sUsuario, sPassword, sSucursal)) Then
                        MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information)
                        Me.Close()
                    Else
                        MsgBox("Registro no pudo ser actualizado.", MsgBoxStyle.Critical)
                    End If
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    'Public Sub recuperarDescripcionItem(codItem As String)
    '    Dim dts As New DataSet
    '    dts = caja.ConsultarCAItemsFact("codItem,Descripcion", " codItem='" & codItem.Trim & "'", " Descripcion ", sUsuario, sPassword, sSucursal)
    '    If dts.Tables.Count > 0 Then
    '        If dts.Tables(0).Rows.Count > 0 Then
    '            txtItem.Text = dts.Tables(0).Rows(0).Item("Descripcion").trim
    '        End If
    '    Else
    '        MsgBox("No existen registros", MsgBoxStyle.Critical)
    '    End If
    'End Sub
    'Private Sub txtCodItem_DoubleClick(sender As Object, e As EventArgs) Handles txtCodItem.DoubleClick

    '    Dim ds As New Data.DataSet("Items"), dr As DataRow
    '    Dim frm As New frmAGenerico, sTexto As String
    '    frm.Text = "Items Facturables"

    '    Try
    '        Dim dts As New DataSet
    '        dts = caja.ConsultarCAItemsFact("codItem,Descripcion", " Tipo_Item='P' ", " Descripcion ", sUsuario, sPassword, sSucursal)
    '        If dts.Tables.Count > 0 Then
    '            If dts.Tables(0).Rows.Count > 0 Then
    '                frm.Datos = dts
    '                frm.ColSeleccion = 0
    '                frm.RefrescarGrid()
    '                frm.ShowDialog()

    '                txtCodItem.Text = frm.Resultado
    '                txtItem.Text = frm.Resultado2.Trim
    '            Else
    '                MsgBox("No existen registros", MsgBoxStyle.Critical)
    '            End If
    '        Else
    '            MsgBox("No existen registros", MsgBoxStyle.Critical)
    '        End If


    '    Catch ex As Exception
    '         MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
    '    End Try
    'End Sub
End Class