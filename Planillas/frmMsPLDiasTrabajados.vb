Public Class frmMsPLDiasTrabajados
    Protected planillas As New wrPlanilla.wsLibPlanilla
    Public CORRELATIVO As Integer
    Public ACCION As Integer
    Public MODIFICAR As Integer
    'ACCION = 1 INSERTAR
    'ACCION = 2 MODIFICAR
    'ACCION = 3 ELIMINAR
    'ACCION = 4 CONSULTAR
    Private Sub txtCODEMPLEADO_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles txtCODEMPLEADO.MouseDoubleClick
        Dim ds As New Data.DataSet
        Dim ofrm As New frmAGenerico
        Try
            ofrm.Text = "Buscar Empleado por Código"
            ds = planillas.ConsultarPLEmpleado("DUI,CodEmpleado,Apellido1,Apellido2,Nombres,CodTipoPersonal", "", "DUI", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCODEMPLEADO.Text = ofrm.Resultado2
            Me.txtNOMBREEMPLEADO.Text = ofrm.Resultado5 & " " & ofrm.Resultado3 & " " & ofrm.Resultado4
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Protected Function GUARDARDT(ByVal FECHAI As DateTime, ByVal FECHAF As DateTime, ByVal CODEMPLEADO As String _
                            , ByVal TD As Integer, ByVal FECHAACTU As DateTime, ByVal USUARIO As String _
                            , ByVal OPCION As Integer) As Integer
        Dim RESULTADO As Integer
        RESULTADO = planillas.INSERTAR_PLDIASTRABAJADOS(FECHAI, FECHAF, CODEMPLEADO, TD, FECHAACTU, USUARIO, OPCION)
        Return RESULTADO

    End Function
    Protected Function MODIFICARDT(ByVal FECHAI As DateTime, ByVal FECHAF As DateTime, ByVal CODEMPLEADO As String _
                            , ByVal TD As Integer, ByVal FECHAACTU As DateTime, ByVal USUARIO As String, ByVal ID As Integer) As Integer
        Dim RESULTADO As Integer
        RESULTADO = planillas.MODIFICAR_PLDIASTRABAJADOS(FECHAI, FECHAF, CODEMPLEADO, _
                                                         TD, FECHAACTU, USUARIO, ID)
        Return RESULTADO
    End Function
    Private Sub btnCERRAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
        My.Forms.wfDIASTRABAJADOS.ACTUALIZAR_DG(Now, Now, "0", 0, 0) ' se mandan valores vacios para que muestre el registro de todos.
    End Sub
    Protected Function RECUPERARDATOS(ByVal ID As Integer) As DataSet
        Try
            Dim DTS As New DataSet
            Dim FILTRO As Integer
            FILTRO = 4 'REGRESA UN NUMERO DE FILA ESPECIFICA
            DTS = planillas.CONSULTAR_PLDIASTRABAJADOS(Now, Now, "0", FILTRO, ID)
            Return DTS
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & "Por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
       
    End Function
    Private Sub frmMsPLDiasTrabajados_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Dim ACCION As Integer
        ' Me.ACCION = My.Forms.wfDIASTRABAJADOS.ACCION
        If Me.ACCION = 1 Then

        ElseIf Me.ACCION = 2 Then
            Dim DTS As New DataSet
            DTS = RECUPERARDATOS(CORRELATIVO)
            Dim CODEMPLEADO As String
            Dim FECHAI, FECHAF As DateTime
            Dim EMPLEADO As String
            Dim DT As Integer
            CODEMPLEADO = DTS.Tables(0).Rows(0).Item("CODEMPLEADO")
            FECHAI = DTS.Tables(0).Rows(0).Item("FECHAINICIO")
            FECHAF = DTS.Tables(0).Rows(0).Item("FECHAFIN")
            EMPLEADO = DTS.Tables(0).Rows(0).Item("EMPLEADO")
            DT = DTS.Tables(0).Rows(0).Item("DT")
            Me.txtCODEMPLEADO.Text = CODEMPLEADO
            Me.txtNOMBREEMPLEADO.Text = EMPLEADO
            Me.txtDIAS.Text = DT
            Me.DateTimePicker1.Value = FECHAI
            Me.DateTimePicker2.Value = FECHAF
        ElseIf Me.ACCION = 4 Then
            Dim DTS As New DataSet
            DTS = RECUPERARDATOS(CORRELATIVO)
            Dim CODEMPLEADO As String
            Dim FECHAI, FECHAF As DateTime
            Dim EMPLEADO As String
            Dim DT As Integer
            CODEMPLEADO = DTS.Tables(0).Rows(0).Item("CODEMPLEADO")
            FECHAI = DTS.Tables(0).Rows(0).Item("FECHAINICIO")
            FECHAF = DTS.Tables(0).Rows(0).Item("FECHAFIN")
            EMPLEADO = DTS.Tables(0).Rows(0).Item("EMPLEADO")
            DT = DTS.Tables(0).Rows(0).Item("DT")
            Me.txtCODEMPLEADO.Text = CODEMPLEADO
            Me.txtNOMBREEMPLEADO.Text = EMPLEADO
            Me.txtDIAS.Text = DT
            Me.DateTimePicker1.Value = FECHAI
            Me.DateTimePicker2.Value = FECHAF
            Me.txtCODEMPLEADO.Enabled = False
            Me.txtDIAS.Enabled = False
            Me.txtNOMBREEMPLEADO.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.DateTimePicker2.Enabled = False
        End If

    End Sub
    Private Sub cbEMPLEADOS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEMPLEADOS.CheckedChanged
        If Me.cbEMPLEADOS.Checked = True Then
            Me.txtCODEMPLEADO.Enabled = False And Me.txtNOMBREEMPLEADO.Enabled = False
        ElseIf Me.cbEMPLEADOS.Checked = False Then
            Me.txtCODEMPLEADO.Enabled = True And Me.txtNOMBREEMPLEADO.Enabled = True
        End If
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim FECHAI As DateTime = Format(Me.DateTimePicker1.Value, "SHORT DATE")
            Dim FECHAF As DateTime = Format(Me.DateTimePicker2.Value, "SHORT DATE")
            Dim CODEMPLEADO As String = Me.txtCODEMPLEADO.Text
            Dim TD As Integer = Me.txtDIAS.Text
            Dim USUARIO As String = sUsuario
            Dim resultado As Integer
            Dim OPCION As Integer
            If Me.cbEMPLEADOS.Checked = True Then
                OPCION = 1
                CODEMPLEADO = "0000"
            Else
                OPCION = 0
            End If
            'Dim ACCION As Integer
            'ACCION = My.Forms.wfDIASTRABAJADOS.ACCION
            If Me.ACCION = 1 Then
                resultado = GUARDARDT(FECHAI, FECHAF, CODEMPLEADO, TD, Now, USUARIO, OPCION)
                If resultado <> 0 Then
                    MsgBox(CStr(resultado) + " Días Trabajados Guardados Exitosamente", MsgBoxStyle.Information, "Módulo - Planilla")
                Else
                    MsgBox("No se pudo guardar la información", MsgBoxStyle.Information, "Módulo - Planilla")
                End If
            ElseIf ACCION = 2 Then
                resultado = MODIFICARDT(FECHAI, FECHAF, CODEMPLEADO, TD, Now, USUARIO, CORRELATIVO)
                If resultado <> 0 Then
                    MsgBox("Días Trabajados Actualizados Exitosamente", MsgBoxStyle.Information, "Módulo - Planilla")
                Else
                    MsgBox("No se pudo guardar la información", MsgBoxStyle.Information, "Módulo - Planilla")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class