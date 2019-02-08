Public Class frmMsCaTipoMovCaja
    Dim vAccion As Integer
    Dim vIdTipoMovCaja As Integer
    Dim vDescripcion As String
    Dim vCodTransaccion As Integer
    Dim bancos As New wrBancos.wsLibBancos
    Dim caja As New wrCaja.wsLibCaja
#Region "Propiedades"
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property idTipoMovCaja() As Integer
        Get
            Return vIdTipoMovCaja
        End Get
        Set(ByVal value As Integer)
            vIdTipoMovCaja = value
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
    Public Property codTransaccion() As Integer
        Get
            Return vCodTransaccion
        End Get
        Set(ByVal value As Integer)
            vCodTransaccion = codTransaccion
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Sub llenarcbTransacciones(ByVal opcion As Integer, ByVal codTransaccion As Integer)
        Dim dts As New DataSet
        dts = bancos.ConsultarBCCatTransacciones_Boveda(opcion, codTransaccion)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbTransacciones.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Protected Sub limpiar()
        Me.txtTipoMov.Text = ""
    End Sub
#End Region
#Region "Eventos"
    Private Sub frmMsCaTipoMovCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If vAccion = 1 Then
            Me.cbTransacciones.DisplayMember = "Descripcion"
            Me.cbTransacciones.ValueMember = "CodTransaccion"
            llenarcbTransacciones(1, 0)
        End If
    End Sub
#End Region


    Private Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnGuardar_Click_1(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim resultado As Integer
        Try
            If vAccion = 1 Then
                resultado = caja.InsertarCaTipoMovCaja(Me.txtTipoMov.Text.Trim, Me.cbTransacciones.SelectedValue,
                                                    sUsuario, sPassword, sSucursal)
                If resultado <> 0 Then
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Caja")
                Else
                    MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Caja")
                End If
            ElseIf vAccion = 2 Then
                resultado = caja.modificarCaTipoMovCaja(vIdTipoMovCaja, Me.txtTipoMov.Text.Trim,
                                                        Me.cbTransacciones.SelectedValue, sUsuario,
                                                        sPassword, sSucursal)
                If resultado <> 0 Then
                    MsgBox("Modificación realizada exitosamente.", MsgBoxStyle.Information, "Módulo - Caja")
                Else
                    MsgBox("El registro no pudo ser modificado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Caja")

                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical, "Módulo - Caja")
        End Try


    End Sub
End Class