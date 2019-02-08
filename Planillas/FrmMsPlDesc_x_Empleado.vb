Public Class FrmMsPlDesc_x_Empleado
    Protected planillas As New wrPlanilla.wsLibPlanilla
    Public Dts As New DataSet
    Private Sub FrmMsPlDesc_x_Empleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CheckedListBox1.ValueMember = "CORRELATIVO"
        Me.CheckedListBox1.DisplayMember = "Descripcion"
        Dim contador As Integer = CheckedListBox1.Items.Count
        For i As Integer = 0 To Dts.Tables(0).Rows.Count - 1
            If Dts.Tables(0).Rows(i).Item("APLICA").ToString = "1" Then
                Me.CheckedListBox1.SetItemChecked(i, True)
            End If
        Next
    End Sub
    Public Sub MostarDescuentos(ByVal Opcion As Integer, ByVal Correlativo As Integer, ByVal CodEmpleado As String, _
                                                       ByVal Fecha_Inicio As DateTime, ByVal Fecha_Fin As DateTime)

        Dim APLICA As Char
        Dim Cor As Integer = 0
        Dts = planillas.Consultar_PlDescuentos(Opcion, Correlativo, CodEmpleado, Fecha_Inicio, Fecha_Fin)
        Me.CheckedListBox1.DataSource = Dts.Tables(0)
    End Sub
    Public Sub ModificarDescuentos()
        Try
            Dim correlativos As String = ""
            Dim Prestamos As String()
            Dim CorrenoSeleccionados As String
            Dim NoPrestamos As String()
            For Each row As DataRowView In CheckedListBox1.CheckedItems
                correlativos += row("Correlativo").ToString + ";"
            Next
            Prestamos = Split(correlativos, ";")
            Dim j As Integer
            For j = 0 To Prestamos.Length - 1
                If Prestamos(j).Length > 1 Then
                    planillas.InhabilitarDescuentos(sUsuario, sPassword, sSucursal, "1", CInt(Prestamos(j)))
                End If
            Next
            Dim k As Integer = 0
            For Each row As DataRowView In CheckedListBox1.Items
                If CheckedListBox1.GetItemChecked(k) = False Then
                    CorrenoSeleccionados += row("Correlativo").ToString + ";"
                End If
                k = k + 1
            Next
            Dim l As Integer
            NoPrestamos = Split(CorrenoSeleccionados, ";")
            For l = 0 To NoPrestamos.Length - 1
                If NoPrestamos(l).Length > 1 Then
                    planillas.InhabilitarDescuentos(sUsuario, sPassword, sSucursal, "0", CInt(NoPrestamos(l)))
                End If
            Next
            MsgBox("Modificación realizada exitosamente.", MsgBoxStyle.Information, "Módulo - Planillas")

        Catch ex As Exception
            MsgBox("Error, No se pudo realizar la modificación", MsgBoxStyle.Critical, "Módulo - Planillas")
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            ModificarDescuentos()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class