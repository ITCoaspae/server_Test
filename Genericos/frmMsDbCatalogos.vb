Public Class frmMsDbCatalogos
    Dim catalogo As New wrAsociados.wsLibAsoc
    Dim vAccion As Integer
    Dim vIdTipoCatalogo As Integer
    Dim vIdCatalogo As Integer
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property idTipoCat() As Integer
        Get
            Return vIdTipoCatalogo
        End Get
        Set(ByVal value As Integer)
            vIdTipoCatalogo = value
        End Set
    End Property
    Public Property idCatalogo() As Integer
        Get
            Return vIdCatalogo
        End Get
        Set(ByVal value As Integer)
            vIdCatalogo = value
        End Set
    End Property
    Protected Sub llenarMaestroCatalogo(ByVal idTipo As Integer, ByVal opcion As Integer)
        Dim dts As New DataSet
        dts = catalogo.consultarCatalogosTiposCatalogo(idTipo, opcion)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbCatalogo.DataSource = dts.Tables(0)
            End If
        End If
    End Sub

    Private Sub frmMsDbCatalogos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbCatalogo.DisplayMember = "descripcion"
        Me.cbCatalogo.ValueMember = "idTipo"
        llenarMaestroCatalogo(0, 1)
        If accion = 2 Then
            Me.cbCatalogo.SelectedValue = idTipoCat
        End If
    End Sub
    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            If accion = 1 Then
                If catalogo.insertarDbCatalogosCatalogos(Me.cbCatalogo.SelectedValue, txtOpcion.Text.ToUpper.Trim) > 0 Then
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Mantenimiento de catalogos")
                Else
                    MsgBox("El registro no pudo ser ingresado, por favor notificar al administrador de sistemas.", MsgBoxStyle.Information, "Mantenimiento de catalogos")
                End If
            ElseIf accion = 2 Then
                If catalogo.actualizarDbCatalogosCatalogos(idCatalogo, txtOpcion.Text.ToUpper.Trim) > 0 Then
                    MsgBox("Registro modificado exitosamente", MsgBoxStyle.Information, "Mantenimiento de catalogos")
                Else
                    MsgBox("El registro no pudo ser modificado, por favor notificar al administrador de sistemas.", MsgBoxStyle.Information, "Mantenimiento de catalogos")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class