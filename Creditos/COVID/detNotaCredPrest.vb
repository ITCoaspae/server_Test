Public Class detNotaCredPrest
    Private pFecha As Date
    Private pDts As New DataSet
    Private prestamos As New wrPrestamo.wsLibPrest
#Region "Propiedades"
    Public Property fecha() As Date
        Get
            Return pFecha
        End Get
        Set(value As Date)
            pFecha = value
        End Set
    End Property
    Public Property dts() As DataSet
        Get
            Return pDts
        End Get
        Set(value As DataSet)
            pDts = value
        End Set
    End Property


#End Region
#Region "Eventos"
    Private Sub detNotaCredPrest_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.DataGridView1.DataSource = dts.Tables(0)
            estiloDg()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNotaCred_Click(sender As Object, e As EventArgs) Handles btnNotaCred.Click
        Try
            If MetroFramework.MetroMessageBox.Show(Me, "¿Desea guardar nota de crédito?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If prestamos.crearNotaCreditoPorTabla(fecha, txtPrestamo.Text.Trim) > 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    Me.btnNotaCred.Enabled = False
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub
#End Region
#Region "Metodos"
    Public Sub estiloDg()
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub
#End Region

End Class