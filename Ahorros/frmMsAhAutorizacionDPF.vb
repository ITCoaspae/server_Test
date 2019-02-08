Public Class frmMsAhAutorizacionDPF
    Dim ahorros As New wrAhorro.wsLibAhorro
    Dim planillas As New wrPlanilla.wsLibPlanilla
    Dim vCodEmpleado
    Dim vIdAutorizacion
    Dim vAccion As Integer

#Region "Propiedades"
    Public Property accion() As Integer
        Get
            Return vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property codEmpleado() As String
        Get
            Return vCodEmpleado
        End Get
        Set(ByVal value As String)
            vCodEmpleado = value
        End Set
    End Property
    Public Property idAutorizacion() As Integer
        Get
            Return vIdAutorizacion
        End Get
        Set(ByVal Value As Integer)
            vIdAutorizacion = Value
        End Set
    End Property

#End Region
#Region "Metodos"
    Protected Sub llenarEmpleados(ByVal campos As String, ByVal filtro As String, ByVal orden As String)
        Dim dts As New DataSet
        dts = planillas.ConsultarPLEmpleado(campos, filtro, orden, sUsuario, sPassword, sSucursal)
        Me.cbEmpleado.DataSource = dts.Tables(0)
    End Sub
    Protected Sub ingresarAutorizacion(ByVal codEmpleado As String)
        Dim resultado As Integer
        resultado = ahorros.insertarAhAutorizacionTasasDpf(codEmpleado)
        If resultado <> 0 Then
            MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Ahorros")
        Else
            MsgBox("El registro no pudo ser ingresado. Por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Ahorros")
        End If
    End Sub
    Protected Sub modificarAutorizacion(ByVal codEmpleado As String, ByVal idAutorizacion As Integer)
        Dim resultado As Integer
        resultado = ahorros.modificarAhAutorizacionTasasDpf(codEmpleado, idAutorizacion)
        If resultado <> 0 Then
            MsgBox("Registro modificado exitosamente", MsgBoxStyle.Information, "Módulo - Ahorros")
        Else
            MsgBox("El registro no pudo ser modificado. Por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Ahorros")
        End If
    End Sub
#End Region
#Region "Eventos"
    Private Sub frmMsAhAutorizacionDPF_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbEmpleado.DisplayMember = "Empleado"
        Me.cbEmpleado.ValueMember = "CodEmpleado"
        llenarEmpleados("rtrim(Nombres) + ' ' + " & _
                            "rtrim(Apellido1) + ' '+ rtrim(Apellido2)[Empleado],CodEmpleado", _
                            "Estado = 'A'", "Nombres")
        If accion = 2 Then
            Me.cbEmpleado.SelectedValue = vCodEmpleado
            Me.btnGuardar1.Text = "Modificar"
        End If
    End Sub



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            If vAccion = 1 Then
                ingresarAutorizacion(Me.cbEmpleado.SelectedValue.ToString.Trim)
            ElseIf vAccion = 2 Then
                modificarAutorizacion(Me.cbEmpleado.SelectedValue.ToString.Trim, vIdAutorizacion)
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub
#End Region

End Class