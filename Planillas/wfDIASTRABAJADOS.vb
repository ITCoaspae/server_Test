Public Class wfDIASTRABAJADOS
    Protected planillas As New wrPlanilla.wsLibPlanilla
    Public CORRELATIVO As Integer
    Private Sub wfDIASTRABAJADOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FECHAI, FECHAF As DateTime
        Dim CODEMPLEADO As String
        Dim FILTRO As Integer
        FILTRO = 0
        FECHAI = Now
        FECHAF = Now
        Dim CORRELATIVO As Integer = 0
        CODEMPLEADO = "0"
        ACTUALIZAR_DG(FECHAI, FECHAF, CODEMPLEADO, FILTRO, CORRELATIVO)

    End Sub
    Public Sub ACTUALIZAR_DG(ByVal FECHAINICIO As DateTime, ByVal FECHAFIN As DateTime, ByVal CODEMPLEADO As String, ByVal FILTRO As Integer, ByVal CORRELATIVO As Integer)
        Dim DTS As New DataSet
        DTS = planillas.CONSULTAR_PLDIASTRABAJADOS(FECHAINICIO, FECHAFIN, CODEMPLEADO, FILTRO, CORRELATIVO)
        Me.fg.DataSource = DTS.Tables(0)
    End Sub
    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub fg_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles fg.MouseClick
        If fg.Row <> -1 Then
            Dim ID As Integer
            ID = fg.Item(fg.Row, "CORRELATIVO")
            My.Forms.frmMsPLDiasTrabajados.CORRELATIVO = ID
        End If
    End Sub
    Private Sub wfDIASTRABAJADOS_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If fg.Row <> -1 Then
            Dim FORM As New frmMsPLDiasTrabajados
            FORM.Show()
        End If
    End Sub
    Private Sub btnModificar_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If fg.Row <> -1 Then
            My.Forms.frmMsPLDiasTrabajados.ACCION = 2
            My.Forms.frmMsPLDiasTrabajados.Text = 2
            Dim ID As Integer
            ID = fg.Item(fg.Row, "CORRELATIVO")
            My.Forms.frmMsPLDiasTrabajados.CORRELATIVO = ID
            My.Forms.frmMsPLDiasTrabajados.Show()

        Else
            MsgBox("Por favor seleccione un registro", MsgBoxStyle.Information, "Modulo - Planilla")
        End If

    End Sub
    Private Sub btnEliminar_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If fg.Row <> -1 Then
                'Dim ACCION As Integer
                My.Forms.frmMsPLDiasTrabajados.ACCION = 3
                Dim CORR, RESULTADO As Integer
                CORR = fg.Item(fg.Row, "CORRELATIVO")
                RESULTADO = ELIMINARDT(CORR)
                If RESULTADO <> 0 Then
                    MsgBox("Días Trabajados Eliminados Exitosamente", MsgBoxStyle.Information, "Modulo - Planillas")
                End If
                Dim FECHAI, FECHAF As DateTime
                Dim CODEMPLEADO As String
                Dim FILTRO As Integer
                FILTRO = 0
                FECHAI = Now
                FECHAF = Now
                Dim CORRELATIVO As Integer = 0
                CODEMPLEADO = "0"
                ACTUALIZAR_DG(FECHAI, FECHAF, CODEMPLEADO, FILTRO, CORRELATIVO)
            Else
                MsgBox("Debe seleccionar a un empleado para realizar esta acción ", MsgBoxStyle.Critical, "Modulo - Planillas")
            End If

        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Modulo - Planillas")
        End Try



    End Sub
    Protected Function ELIMINARDT(ByVal CORRELATIVO As Integer) As Integer
        Try
            Dim VALOR As Integer
            VALOR = MsgBox("Esta seguro que desea realizar esta acción", MsgBoxStyle.YesNo, "Modulo - Planilla")
            If VALOR = 6 Then
                Dim RESULTADO As Integer
                RESULTADO = planillas.ELIMINAR_PLDIASTRABAJADOS(CORRELATIVO)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Modulo - Planilla")
        End Try
    End Function
    Private Sub btnConsultar_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Try
            If fg.Row <> -1 Then
                My.Forms.frmMsPLDiasTrabajados.ACCION = 4
                Dim ID As Integer
                ID = fg.Item(fg.Row, "CORRELATIVO")
                My.Forms.frmMsPLDiasTrabajados.CORRELATIVO = ID
                My.Forms.frmMsPLDiasTrabajados.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public CODEMPLEADO As String

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If Me.chkFecha.Checked = True And Me.chkEmpleado.Checked = False Then
                ACTUALIZAR_DG(Format(dtFECHAINICIO.Value, "SHORT DATE"), Format(dtFECHAFIN.Value, "SHORT DATE"), "0", 1, 0)
            ElseIf Me.chkEmpleado.Checked = True And Me.chkEmpleado.Checked = False Then
                If Me.CODEMPLEADO <> 0 Then
                    ACTUALIZAR_DG(Now, Now, CODEMPLEADO, 2, 0)
                End If
            ElseIf Me.chkEmpleado.Checked = True And Me.chkEmpleado.Checked = True Then
                ACTUALIZAR_DG(Format(dtFECHAINICIO.Value, "SHORT DATE"), Format(dtFECHAFIN.Value, "SHORT DATE"), CODEMPLEADO, 3, 0)
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            frmMsPLDiasTrabajados.Show()
            My.Forms.frmMsPLDiasTrabajados.ACCION = 1
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Dim FECHAI, FECHAF As DateTime
        Dim CODEMPLEADO As String
        Dim FILTRO As Integer
        FILTRO = 0
        FECHAI = Now
        FECHAF = Now
        Dim CORRELATIVO As Integer = 0
        CODEMPLEADO = "0"
        ACTUALIZAR_DG(FECHAI, FECHAF, CODEMPLEADO, FILTRO, CORRELATIVO)
    End Sub
End Class