Public Class frmMsFamiliaresPep
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim vAccion, vIdFamiliarPep, vIdPep As Integer
    Public Property accion() As Integer
        Get
            Return Me.vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property IdFamiliarPep() As Integer
        Get
            Return Me.vIdFamiliarPep
        End Get
        Set(ByVal value As Integer)
            vIdFamiliarPep = value
        End Set
    End Property
    Public Property idPep() As Integer
        Get
            Return Me.vIdPep
        End Get
        Set(ByVal value As Integer)
            vIdPep = value
        End Set
    End Property
    Public Sub llenarTipoFamiliar()
        Dim dts As New DataSet
        dts = asociados.ConsultarParentescos("codParentesco,descripcion", "", "descripcion", sUsuario, sPassword, sSucursal)
        'dts = asociados.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.nulo, wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables(0).Rows.Count > 0 Then
            Me.cbParentesco.DisplayMember = "descripcion"
            Me.cbParentesco.ValueMember = "codParentesco"
            Me.cbParentesco.DataSource = dts.Tables(0)
        End If
    End Sub

    Private Sub btnGuardarDom_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If accion = 1 Then
                If asociados.insertar_AsocPep_Familiares(idPep, cbParentesco.SelectedValue, txtNombre.Text.Trim) > 0 Then
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                Else
                    MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Information, "Módulo - Asociados")
                End If
            ElseIf accion = 2 Then
                If asociados.modificarAsocPep_Familiares(IdFamiliarPep, idPep, cbParentesco.SelectedValue, txtNombre.Text.Trim) > 0 Then
                    MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information, "Módulo - Asociados")
                Else
                    MsgBox("El registro no pudo ser modificado, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Asociados")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub frmMsFamiliaresPep_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If accion = 1 Then
            llenarTipoFamiliar()
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class