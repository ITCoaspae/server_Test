Public Class frmMsConsultarActividadEconomica
    Dim asociados As New wrAsociados.wsLibAsoc
    'Variables para manejo de Propiedades
    Dim oDatos As New DataSet
    Dim iColSel As Integer = 1
    Dim sResult As String = ""
    Dim sResult2 As String = ""
    Dim sResult3 As Boolean
    'Variables
    Dim iCol As Integer, iRow As Integer
#Region "Propiedades"

    Public Property Datos() As DataSet
        Get
            Datos = oDatos
        End Get
        Set(ByVal Value As DataSet)
            oDatos = Value
        End Set
    End Property

    Public Property ColSeleccion() As Integer
        Get
            ColSeleccion = iColSel
        End Get
        Set(ByVal Value As Integer)
            iColSel = Value
        End Set
    End Property

    Public Property Resultado() As String
        Get
            Resultado = sResult
        End Get
        Set(ByVal Value As String)
            sResult = Value
        End Set
    End Property

    Public Property Resultado2() As String
        Get
            Resultado2 = sResult2
        End Get
        Set(ByVal Value As String)
            sResult2 = Value
        End Set
    End Property

    Public Property Resultado3() As Boolean
        Get
            Resultado3 = sResult3
        End Get
        Set(ByVal Value As Boolean)
            sResult3 = Value
        End Set
    End Property
#End Region

    Private Sub dg_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dg.CellDoubleClick
        If dg.RowCount > 0 Then
            Resultado = dg.Item("CodigoActividadEconomica", Me.dg.CurrentRow.Index).Value.ToString
            Resultado2 = dg.Item("Descripcion", Me.dg.CurrentRow.Index).Value.ToString
            Resultado3 = dg.Item("APNFD", Me.dg.CurrentRow.Index).Value
            Me.Close()
        End If
    End Sub

    Private Sub frmMsConsultarActividadEconomica_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        llenarActividadEconomicaPrincipal()
    End Sub
    Public Sub llenarActividadEconomicaPrincipal()
        Dim dts As New DataSet
        dts = asociados.consultarCatActividadEconomica("0", "", 1, "")
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.ComboBox1.DisplayMember = "Descripcion"
                Me.ComboBox1.ValueMember = "CodigoActividadEconomica"
                Me.ComboBox1.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Protected Sub llenarActividadEconomicaSecundaria(ByVal dependencia As String)
        Dim dts As New DataSet
        dts = asociados.consultarCatActividadEconomica("1", dependencia, 2, "")
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.ComboBox2.DisplayMember = "Descripcion"
                Me.ComboBox2.ValueMember = "CodigoActividadEconomica"
                Me.ComboBox2.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Protected Sub llenarActividadEconomicaTerciaria(ByVal dependencia As String)
        Dim dts As New DataSet
        dts = asociados.consultarCatActividadEconomica("2", dependencia, 3, "")
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                dg.DataSource = dts.Tables(0)
                estidoDg()

            End If
        End If
    End Sub

    Private Sub ComboBox1_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.DropDownClosed
        llenarActividadEconomicaSecundaria(Me.ComboBox1.SelectedValue)
    End Sub

    Private Sub ComboBox2_DropDownClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox2.DropDownClosed
        llenarActividadEconomicaTerciaria(Me.ComboBox2.SelectedValue)
    End Sub
    Protected Sub estidoDg()
        Me.dg.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dg.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        Me.dg.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

        Me.dg.Columns("CodigoActividadEconomica").HeaderText = "Codigo Actividad Económica"
        Me.dg.Columns("Descripcion").HeaderText = "Actividad Económica"
       
        Me.dg.Columns("Nivel").Visible = False
        Me.dg.Columns("CodigoDependencia").Visible = False
        Me.dg.Columns("APNFD").Visible = False

        Me.dg.Columns("Descripcion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    End Sub
End Class