Public Class frmMChequesBoveda
    Inherits MetroFramework.Forms.MetroForm
    Dim oCaja As New wrCaja.wsLibCaja
    Dim oConta As New wrConta.wsLibContab
    Dim ds, dts As New Data.DataSet
    Dim Bancos As New wrBancos.wsLibBancos
    Dim Asociados As New wrAsociados.wsLibAsoc
    Public cajero As String
    Public noCaja As String
    Dim IdBoveda As Integer
    Dim numPartida As String
    Dim noCheque As String
    Dim IdBanco As Integer
    Dim MontoCheque As Double
    Dim FecMov As Date
    Dim dtsTranBoveda As New DataSet
    Dim dta As DataSet
    Private Sub llenarCbSucursal()
        Dim dts As New DataSet
        dts = Asociados.ConsultarSucursales("codSucursal,nom_sucursal", " codSucursal = '" & sSucursal & "' ", "nom_sucursal", sUsuario, sPassword, sSucursal)
        cbSucursal.DataSource = dts.Tables(0)
        cbSucursal.DisplayMember = "nom_sucursal"
        cbSucursal.ValueMember = "codSucursal"
    End Sub
    Private Sub frmMChequesBoveda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            llenarCbSucursal()
        Catch ex As Exception

        End Try
    End Sub

    Sub HabilitarColumnasGrid()
        fg.Cols.Item("NoCaja").Visible = False
        fg.Cols.Item("Nombre").Visible = False
        fg.Cols.Item("CodCajero").Visible = False
        fg.Cols.Item("IdBanco").Visible = False
        fg.Cols.Item("NoCtabanco").Visible = False
        fg.Cols.Item("Girador").Visible = False
        fg.Cols.Item("Paguese").Visible = False
    End Sub
    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try
            If pCodCajero = 0 Then
                Dim ofrm As New frmMsCaLogin
                ofrm.Origen = "C"
                ofrm.ShowDialog()
            End If
            If pCodCajero > 0 Then
                dts = oCaja.ObtenerCajero(dtpFechaMovimiento.Value.ToShortDateString, pCodCajero)
                IdBoveda = dts.Tables(0).Rows(0).Item(2).ToString
                noCaja = dts.Tables(0).Rows(0).Item(1).ToString

                ds = oCaja.ObtenerChequesBoveda(pCodCajero, dtpFechaMovimiento.Value.ToShortDateString, cbSucursal.SelectedValue)
                Dim col As New DataColumn
                col.ColumnName = "Seleccionar"
                col.DataType = GetType(Boolean)
                col.DefaultValue = False
                ds.Tables(0).Columns.Add(col)
                fg.DataSource = ds.Tables(0)
                HabilitarColumnasGrid()
            End If

        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub btnTrasladar_Click(sender As Object, e As EventArgs) Handles btnTrasladar.Click
        Try
            GuardarCheques()

        Catch ex As Exception

        End Try
    End Sub

    Sub GuardarCheques()

        Dim TotalCheques As Double = 0
        Dim CantidadCheques As Integer = 0


        Try
            numPartida = oConta.generarNumeroPartida(2, "DR", dtpFechaMovimiento.Value.Month, dtpFechaMovimiento.Value.Year)

            If fg.Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables(0).Rows.Count - 1
                    With ds.Tables(0).Rows(i)
                        If .Item("Seleccionar") = True Then
                            noCheque = .Item("NoCheque").ToString
                            IdBanco = .Item("IdBanco")
                            MontoCheque = .Item("Total")
                            oCaja.GuardarChequesBoveda(noCheque, IdBanco, MontoCheque, IdBoveda, dtpFechaMovimiento.Value.ToShortDateString, sUsuario, dtpFechaMovimiento.Value.ToShortTimeString, numPartida, 0, 0, 0, pCodCajero)

                            TotalCheques = TotalCheques + .Item("Total")
                            CantidadCheques = CantidadCheques + 1

                        End If
                    End With
                Next i
                oCaja.GuardarChequesBoveda(noCheque, IdBanco, MontoCheque, IdBoveda, dtpFechaMovimiento.Value.ToShortDateString, sUsuario, dtpFechaMovimiento.Value.ToShortTimeString, numPartida, 1, TotalCheques, CantidadCheques, pCodCajero)
                MsgBox("El Proceso se realizo Correctamente.", MsgBoxStyle.Information)
                Me.Close()
            Else
                MsgBox("No hay cheques para trasladar, Favor verifique", MsgBoxStyle.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class