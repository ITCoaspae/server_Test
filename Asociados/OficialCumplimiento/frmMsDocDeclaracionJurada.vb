Public Class frmMsDocDeclaracionJurada
    Dim asociados As New wrAsociados.wsLibAsoc
    Private vAccion As Integer
    Private vIdDeclaracion As Integer
    Private vIdDocumento As Integer
    Private vIdDoc As Integer

#Region "Propiedades"
    Public Property accion() As Integer
        Get
            Return Me.vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property idDeclaracion() As Integer
        Get
            Return Me.vIdDeclaracion
        End Get
        Set(ByVal value As Integer)
            vIdDeclaracion = value
        End Set
    End Property
    Public Property idDocumento() As Integer
        Get
            Return Me.vIdDocumento
        End Get
        Set(ByVal value As Integer)
            vIdDocumento = value
        End Set
    End Property
    Public Property idDoc() As Integer
        Get
            Return Me.vIdDoc
        End Get
        Set(ByVal value As Integer)
            vIdDoc = value
        End Set
    End Property
#End Region
    Public Sub llenarCbDocumentos()
        Dim dts As New DataSet
        dts = asociados.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.tipoDocumentoDeclaracionJurada,
                                                     wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbTipoDoc.DisplayMember = "Descripcion"
                Me.cbTipoDoc.ValueMember = "idCatalogo"
                Me.cbTipoDoc.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarCbPlazo()
        Dim dts As New DataSet
        dts = asociados.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.plazoDocumentoDeclaracionJurada,
                                                     wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbPlazo.DisplayMember = "Descripcion"
                Me.cbPlazo.ValueMember = "idCatalogo"
                Me.cbPlazo.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Public Sub llenarDatos(idDoc)
        Dim dts As New DataSet
        dts = asociados.consultarAsocDeclaracionJuradaDocumentos(idDeclaracion, idDoc, 2)
        If dts IsNot Nothing Then
            If dts.Tables.Count > 0 Then
                If dts.Tables(0).Rows.Count > 0 Then
                    llenarCbDocumentos()
                    llenarCbPlazo()
                    Me.cbTipoDoc.SelectedValue = dts.Tables(0).Rows(0).Item("idCatalogo")
                    Me.cbPlazo.SelectedValue = dts.Tables(0).Rows(0).Item("idPlazo")
                    chkPresentoDoc.Checked = dts.Tables(0).Rows(0).Item("PresentoDocumento")
                    dtpFechaEntrega.Value = dts.Tables(0).Rows(0).Item("FechaPresentacion")
                End If
            End If
            End If
    End Sub
    Private Sub frmMsDocDeclaracionJurada_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.cbPlazo.DisplayMember = "Descripcion"
        'Me.cbPlazo.ValueMember = "idCatalogo"
        'Me.cbTipoDoc.DisplayMember = "Descripcion"
        'Me.cbTipoDoc.ValueMember = "idCatalogo"
        If accion = 1 Then
            llenarCbDocumentos()
            llenarCbPlazo()
        ElseIf accion = 2
            llenarDatos(idDocumento)
        End If
        
    End Sub


    Private Sub btnGuardarDom_Click(sender As Object, e As EventArgs) Handles btnGuardarDom.Click
        Try
            If accion = 1 Then
                If asociados.insertarAsocDeclaracionJuradaDocumentos(idDeclaracion, cbTipoDoc.SelectedValue, cbPlazo.SelectedValue,
                                                             Format(dtpFechaEntrega.Value, "short date"), sUsuario, Now,
                                                             chkPresentoDoc.Checked, True) > 0 Then
                    MsgBox("Informacion Ingresada Exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                Else
                    MsgBox("Registro no ingresado.", MsgBoxStyle.Critical)
                End If
                Me.Close()
            ElseIf accion = 2 Then
                If asociados.modificarAsocDeclaracionJuradaDocumentos(cbTipoDoc.SelectedValue, cbPlazo.SelectedValue,
                                                                  Format(dtpFechaEntrega.Value, "Short date"), chkPresentoDoc.Checked,
                                                                  idDoc, sUsuario, Format(Now, "Short date"), True) > 0 Then
                    MsgBox("Informacion Actualizada Exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                Else
                    MsgBox("Registro no ingresado.", MsgBoxStyle.Critical)
                End If
            End If

        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class