Public Class frmDetItemRubroDocumento
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

    'LLENANDO COMBOS
    Protected Sub llenarRubros()
        Dim dts As New DataSet
        dts = caja.ObtenerListaRubros("IdRubro,Descripcion", "", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbRubros.DataSource = dts.Tables(0)

            End If
        End If
    End Sub

    Protected Sub llenarItems()
        Dim dts As New DataSet
        dts = caja.ObtenerListaItems("CodItem, coditem + Descripcion as Descripcion ", " tipo_item = 'P'", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbItems.DataSource = dts.Tables(0)

            End If
        End If
    End Sub

    Protected Sub llenarTipoDocumentos()
        Dim dts As New DataSet
        dts = caja.consultarCaMaestrosTipoDocumentos(2, 1, 0)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbTipoDocumento.DataSource = dts.Tables(0)

            End If
        End If
    End Sub

    Private Sub frmDetItemRubroDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.cbItems.DisplayMember = "Descripcion"
        Me.cbItems.ValueMember = "CodItem"
        Me.cbTipoDocumento.DisplayMember = "tipoDocumento"
        Me.cbTipoDocumento.ValueMember = "idTipoDoc"
        Me.cbRubros.DisplayMember = "Descripcion"
        Me.cbRubros.ValueMember = "IdRubro"
        llenarTipoDocumentos()
        llenarItems()
        llenarRubros()
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim dta As DataSet
        If vAccion = 1 Then ' nuevo
            Try
                caja.ObtenerListaItesmRubrosDocumentos(0, cbItems.SelectedValue, cbRubros.SelectedValue, cbTipoDocumento.SelectedValue, 1)
                MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information)
                Me.Close()
            Catch ex As Exception
                MsgBox("Registro no pudo ser ingresado.", MsgBoxStyle.Critical)
            End Try

        ElseIf vAccion = 2 Then 'modificar
            Try
                caja.ObtenerListaItesmRubrosDocumentos(txtIdRubro.Text, cbItems.SelectedValue, cbRubros.SelectedValue, cbTipoDocumento.SelectedValue, 2)
                MsgBox("Registro modificado exitosamente", MsgBoxStyle.Information)
                Me.Close()
            Catch ex As Exception
                MsgBox("Registro no pudo ser modificado.", MsgBoxStyle.Critical)
            End Try
        End If

    End Sub

    Private Sub frmDetItemRubroDocumento_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class