Public Class frmCancelacionPrestamo
    Dim prestamos As New wrPrestamo.wsLibPrest
    Dim vNoCaja As Integer
    Dim vCodCajero As Integer
#Region "Propiedades"
    Public Property noCaja() As Integer
        Get
            Return vNoCaja
        End Get
        Set(ByVal value As Integer)
            vNoCaja = value
        End Set
    End Property
    Public Property codCajero() As Integer
        Get
            Return vCodCajero
        End Get
        Set(ByVal value As Integer)
            vCodCajero = value
        End Set
    End Property
#End Region
#Region "Eventos"
    Private Sub DataGridView1_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If Me.DataGridView1.RowCount > 0 Then
            If Me.DataGridView1.Columns(e.ColumnIndex).Name = "cancelacion" Then
                If Me.DataGridView1.Item("cancelacion", Me.DataGridView1.CurrentRow.Index).Value = False Then
                    Me.DataGridView1.Item("cancelacion", Me.DataGridView1.CurrentRow.Index).Value = True
                Else
                    Me.DataGridView1.Item("cancelacion", Me.DataGridView1.CurrentRow.Index).Value = False
                End If
            End If
        End If
    End Sub
    Private Sub frmCancelacionPrestamo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtCodPrestamo.ReadOnly = True
        llenarDgCausasCancelacion()
        txtObservacion.ReadOnly = False
        txtObservacion.Enabled = True
    End Sub

#End Region
#Region "Metodos"
    Protected Sub estilodg()

        Me.DataGridView1.Columns("descripcion").HeaderText = "Causa de Cancelación"
        Me.DataGridView1.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns("idMotCan").ReadOnly = True
        Me.DataGridView1.Columns("descripcion").ReadOnly = True

        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub
    Protected Sub llenarDgCausasCancelacion()
        Dim dts As New DataSet
        dts = prestamos.consultarPrCatCausasCancelacion
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.DataGridView1.DataSource = dts.Tables(0)
                Dim colCan As New DataGridViewCheckBoxColumn
                colCan.Name = "cancelacion"
                colCan.HeaderText = "Cancelación"
                Me.DataGridView1.Columns.Add(colCan)
                estilodg()
            End If
        End If
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim dts As New DataSet
            Dim dr As DataRow
            Dim dtCancelacion As DataTable = New DataTable("cancelacion")
            dtCancelacion.Columns.Add("idMotCa", Type.GetType("System.Int32"))
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("cancelacion").Value = True Then
                    dr = dtCancelacion.NewRow()
                    dr("idMotCa") = row.Cells("idMotCan").Value
                    dtCancelacion.Rows.Add(dr)
                End If
            Next
            dts.Tables.Add(dtCancelacion)
            If dts.Tables(0).Rows.Count > 0 Then
                If prestamos.GuardarCancelacionPrestamo(txtCodPrestamo.Text.Trim, vNoCaja, vCodCajero, sUsuario, Now, txtObservacion.Text.Trim, dts, sSucursal) = 1 Then
                    MsgBox("Registro ingresado exitosamente.", MsgBoxStyle.Information, "Cancelación de Préstamos")
                    Me.Close()
                Else
                    MsgBox("El registro no fue ingresado, por favor comunciarse con el administrador del sistema", MsgBoxStyle.Critical, "Cancelación de Préstamos")
                    Me.Close()
                End If
            Else
                MsgBox("Por favor seleccione una causa de cancelación.", MsgBoxStyle.Critical, "Cancelación de Préstamos")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
#End Region





End Class