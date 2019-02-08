Public Class frmPartidaCorteCaja
    Dim caja As New wrCaja.wsLibCaja
    Dim Contabilidad As New wrConta.wsLibContab
    Dim Planillas As New wrPlanilla.wsLibPlanilla
    Dim Asociados As New wrAsociados.wsLibAsoc
    Dim DtsIngresos As New DataSet
    Dim DtsEgresos As New DataSet
    Dim TotalIngresos As Double
    Dim TotalEgresos As Double
    Public Origen As Integer
#Region "Funciones"
    Protected Function Recuperar_CentroCostos(ByVal CodSucursal As String) As String
        Dim DtsCentroCosto As DataSet
        DtsCentroCosto = Asociados.ConsultarSucursales("Cod_CCosto", " CodSucursal = '" & CodSucursal & "'", "", sUsuario, sPassword, sSucursal)
        If DtsCentroCosto.Tables(0).Rows.Count > 0 Then
            Return DtsCentroCosto.Tables(0).Rows(0).Item("Cod_CCosto").ToString.Trim
        End If
    End Function
#End Region
#Region "Metodos"
    Protected Sub LlenarSucursales()
        Dim DtsSucursales As New DataSet
        If Origen = 0 Then
            DtsSucursales = Asociados.ConsultarSucursales("CodSucursal,NOM_SUCURSAL", " CodSucursal = '" & sSucursal & "'", "", sUsuario, sPassword, sSucursal)
            Me.cbSucursales.DataSource = DtsSucursales.Tables(0)
            Me.cbSucursales.Enabled = False
        Else
            DtsSucursales = Asociados.ConsultarSucursales("CodSucursal,NOM_SUCURSAL ", "", " Nom_Sucursal ", sUsuario, sPassword, sSucursal)
            Me.cbSucursales.DataSource = DtsSucursales.Tables(0)
            Me.cbSucursales.Enabled = True
        End If

        'DtsSucursales = Planillas.Consultar_Sucursales()
        'If DtsSucursales.Tables(0).Rows.Count > 0 Then
        '    Me.cbSucursales.DataSource = DtsSucursales.Tables(0)
        'End If
    End Sub
    Protected Sub llenarCajeros(ByVal CodSucursal As String)
        Dim Dts As New DataSet
        Dts = caja.ConsultarCajeros(" CodCajero,Nombre", "FechaFinalizacion >='" & Format(Me.dtpFecha.Value, "Short Date") & "' and CodSucursal = '" & CodSucursal & "'", _
                                     "Nombre", sUsuario, sPassword, sSucursal)
        Me.cbCajeros.DataSource = Dts.Tables(0)
    End Sub
    Protected Sub Redondear(ByVal opcion As Integer)
        If opcion = 1 Then
            For i As Integer = 0 To Me.dgIngresos1.Rows.Count - 1
                Me.dgIngresos1.Item("Monto", i).Value = Math.Round(Me.dgIngresos1.Item("Monto", i).Value, 2)
                Me.dgIngresos1.Item("IVA", i).Value = Math.Round(Me.dgIngresos1.Item("IVA", i).Value, 2)
            Next
        Else
            For i As Integer = 0 To Me.dgEgresos2.Rows.Count - 1
                Me.dgEgresos2.Item("Monto", i).Value = Math.Round(Me.dgEgresos2.Item("Monto", i).Value, 2)
            Next
        End If
    End Sub

#End Region
#Region "Eventos"
    Private Sub frmPartidaCorteCaja_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbCajeros.DisplayMember = "Nombre"
        Me.cbCajeros.ValueMember = "CodCajero"
        Me.cbSucursales.DisplayMember = "NOM_SUCURSAL"
        Me.cbSucursales.ValueMember = "CODSUCURSAL"
        LlenarSucursales()
    End Sub
    Private Sub cbSucursales_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSucursales.DataSourceChanged
        llenarCajeros(Me.cbSucursales.SelectedValue)
    End Sub
    Private Sub cbSucursales_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSucursales.SelectedIndexChanged
        llenarCajeros(Me.cbSucursales.SelectedValue)
    End Sub
    Private Sub cbSucursales_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbSucursales.DropDownClosed
        llenarCajeros(Me.cbSucursales.SelectedValue)
    End Sub
    Private Sub btnGenerar_Click(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btnProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub cbCajeros_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCajeros.SelectedIndexChanged
        Me.DtsEgresos.Clear()
        Me.DtsIngresos.Clear()
        Me.dgIngresos1.DataSource = ""
        Me.dgEgresos2.DataSource = ""
    End Sub
    Private Sub dtpFecha_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFecha.DropDown
        Me.DtsEgresos.Clear()
        Me.DtsIngresos.Clear()
        Me.dgIngresos1.DataSource = ""
        Me.dgEgresos2.DataSource = ""
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If Me.MetroTabControl1.SelectedIndex = 0 Then 'Ingresos
                TotalIngresos = 0
                DtsIngresos = Contabilidad.ConsultarIngresosCaja(Me.cbCajeros.SelectedValue, Format(Me.dtpFecha.Value, "Short Date"), 1, sUsuario, sSucursal)
                If DtsIngresos.Tables(0).Rows.Count > 0 Then
                    Dim total As Double
                    Dim iva As Double
                    For i As Integer = 0 To DtsIngresos.Tables(0).Rows.Count - 1
                        total = total + DtsIngresos.Tables(0).Rows(i).Item("Monto")
                        iva = iva + DtsIngresos.Tables(0).Rows(i).Item("IVA")
                    Next
                    Dim Fila As DataRow = DtsIngresos.Tables(0).NewRow
                    Fila("Descripcion") = "Total"
                    Fila("Monto") = Math.Round(total, 2)
                    Fila("IVA") = Math.Round(iva, 2)
                    DtsIngresos.Tables(0).Rows.Add(Fila)
                    TotalIngresos = total + iva
                    Me.dgIngresos1.DataSource = DtsIngresos.Tables(0)
                    Redondear(1)
                End If
            Else 'Egresos
                TotalEgresos = 0
                DtsEgresos = Contabilidad.ConsultarIngresosCaja(Me.cbCajeros.SelectedValue, Format(Me.dtpFecha.Value, "Short Date"), 2, sUsuario, sSucursal)
                If DtsEgresos.Tables(0).Rows.Count > 0 Then
                    Dim total As Double
                    'Dim iva As Double
                    For i As Integer = 0 To DtsEgresos.Tables(0).Rows.Count - 1
                        total = total + DtsEgresos.Tables(0).Rows(i).Item("Monto")
                        'iva = iva + Dts.Tables(0).Rows(i).Item("IVA")
                    Next
                    Dim Fila As DataRow = DtsEgresos.Tables(0).NewRow
                    Fila("Descripcion") = "Total"
                    Fila("Monto") = Math.Round(total, 2)
                    'Fila("IVA") = Math.Round(iva, 2)
                    DtsEgresos.Tables(0).Rows.Add(Fila)
                    TotalEgresos = total
                    Me.dgEgresos2.DataSource = DtsEgresos.Tables(0)
                    Redondear(2)

                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            If MsgBox("Desea realizar esta acción", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Módulo - Contabilidad") = MsgBoxResult.Yes Then
                Dim Concepto As String
                If Me.MetroTabControl1.SelectedIndex = 0 Then
                    Concepto = "Partida de Ingresos Corte diario de caja " & Format(Me.dtpFecha.Value, "Short Date") & "; Cajero: " & Me.cbCajeros.Text & " Sucursal: " & Me.cbSucursales.Text

                    If Contabilidad.CrearPartidasCorteDiarioCaja(DtsIngresos, TotalIngresos, "A", Format(Me.dtpFecha.Value, "Short Date"), Concepto, Recuperar_CentroCostos(Me.cbSucursales.SelectedValue), sUsuario, Me.cbSucursales.SelectedValue) = 1 Then
                        MsgBox("Partida creada exitosamente", MsgBoxStyle.Information, "Módulo - Contabilidad")
                        Me.DtsIngresos.Clear()
                    Else
                        MsgBox("Error. No se pudo ingresar la partida, por favor Comuniquese con el Administrador del sistema", MsgBoxStyle.Critical, "Módulo - Contabilidad")
                    End If

                Else
                    Concepto = "Partida de Egresos Corte diario de caja " & Format(Me.dtpFecha.Value, "Short Date") & "; Cajero: " & Me.cbCajeros.Text & " Sucursal: " & Me.cbSucursales.Text
                    If Contabilidad.CrearPartidasCorteDiarioCaja(DtsEgresos, TotalEgresos, "C", Format(Me.dtpFecha.Value, "Short Date"), Concepto, Recuperar_CentroCostos(Me.cbSucursales.SelectedValue), sUsuario, Me.cbSucursales.SelectedValue) = 1 Then
                        MsgBox("Partida creada exitosamente", MsgBoxStyle.Information, "Módulo - Contabilidad")
                        Me.DtsEgresos.Clear()
                    Else
                        MsgBox("Error. No se pudo ingresar la partida, por favor Comuniquese con el Administrador del sistema", MsgBoxStyle.Critical, "Módulo - Contabilidad")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub


#End Region

End Class