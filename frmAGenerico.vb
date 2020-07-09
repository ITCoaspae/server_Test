Imports System.Data
Public Class frmAGenerico
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    'Variables para manejo de Propiedades
    Dim oDatos As New DataSet
    Dim iColSel As Integer = 1
    Dim sResult As String = "", sResult2 As String = "",
    sResult3 As String = "", sResult4 As String = "",
    sResult5 As String = "", sResult6 As String = "",
    sResult7 As String = "", sResult8 As String = "",
    sResult9 As String, sResult10 As String = "", SResult11 As String = ""
    'Variables
    Dim iCol As Integer, iRow As Integer

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents C1fgrdResultado As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents optTodos As System.Windows.Forms.RadioButton
    Friend WithEvents optFiltro As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAGenerico))
        Me.C1fgrdResultado = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.optTodos = New System.Windows.Forms.RadioButton()
        Me.optFiltro = New System.Windows.Forms.RadioButton()
        CType(Me.C1fgrdResultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1fgrdResultado
        '
        Me.C1fgrdResultado.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.C1fgrdResultado.AllowEditing = False
        Me.C1fgrdResultado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fgrdResultado.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.C1fgrdResultado.BackColor = System.Drawing.Color.White
        Me.C1fgrdResultado.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:21;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.C1fgrdResultado.ForeColor = System.Drawing.Color.Black
        Me.C1fgrdResultado.Location = New System.Drawing.Point(28, 121)
        Me.C1fgrdResultado.Name = "C1fgrdResultado"
        Me.C1fgrdResultado.Rows.Count = 2
        Me.C1fgrdResultado.Rows.DefaultSize = 21
        Me.C1fgrdResultado.Size = New System.Drawing.Size(602, 182)
        Me.C1fgrdResultado.StyleInfo = resources.GetString("C1fgrdResultado.StyleInfo")
        Me.C1fgrdResultado.TabIndex = 6
        '
        'optTodos
        '
        Me.optTodos.Location = New System.Drawing.Point(28, 73)
        Me.optTodos.Name = "optTodos"
        Me.optTodos.Size = New System.Drawing.Size(150, 27)
        Me.optTodos.TabIndex = 7
        Me.optTodos.Text = "&Todos los Registros"
        '
        'optFiltro
        '
        Me.optFiltro.Checked = True
        Me.optFiltro.Location = New System.Drawing.Point(185, 73)
        Me.optFiltro.Name = "optFiltro"
        Me.optFiltro.Size = New System.Drawing.Size(333, 27)
        Me.optFiltro.TabIndex = 8
        Me.optFiltro.TabStop = True
        Me.optFiltro.Text = "&Filtrar Registros"
        '
        'frmAGenerico
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(658, 366)
        Me.Controls.Add(Me.optFiltro)
        Me.Controls.Add(Me.optTodos)
        Me.Controls.Add(Me.C1fgrdResultado)
        Me.Name = "frmAGenerico"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        CType(Me.C1fgrdResultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

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
            ColSeleccion = icolSel
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

    Public Property Resultado3() As String
        Get
            Resultado3 = sResult3
        End Get
        Set(ByVal Value As String)
            sResult3 = Value
        End Set
    End Property

    Public Property Resultado4() As String
        Get
            Resultado4 = sResult4
        End Get
        Set(ByVal Value As String)
            sResult4 = Value
        End Set
    End Property

    Public Property Resultado5() As String
        Get
            Resultado5 = sResult5
        End Get
        Set(ByVal Value As String)
            sResult5 = Value
        End Set
    End Property

    Public Property Resultado6() As String
        Get
            Resultado6 = sResult6
        End Get
        Set(ByVal Value As String)
            sResult6 = Value
        End Set
    End Property

    Public Property Resultado7() As String
        Get
            Resultado7 = sResult7
        End Get
        Set(ByVal Value As String)
            sResult7 = Value
        End Set
    End Property

    Public Property Resultado8() As String
        Get
            Resultado8 = sResult8
        End Get
        Set(ByVal Value As String)
            sResult8 = Value
        End Set
    End Property
    Public Property Resultado9() As String
        Get
            Resultado9 = sResult9
        End Get
        Set(ByVal Value As String)
            sResult9 = Value
        End Set
    End Property
    Public Property Resultado10() As String
        Get
            Resultado10 = sResult10
        End Get
        Set(ByVal Value As String)
            sResult10 = Value
        End Set
    End Property
    Public Property Resultado11() As String
        Get
            Resultado11 = SResult11
        End Get
        Set(ByVal Value As String)
            SResult11 = Value
        End Set
    End Property
#End Region
    Public Sub RefrescarGrid()
        C1fgrdResultado.DataSource = oDatos.Tables(0)

    End Sub
    Private Sub frmAGenerico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub C1fgrdResultado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1fgrdResultado.DoubleClick
        If optTodos.Checked = True Then
            Resultado = ""
            Resultado2 = ""
            Resultado3 = ""
            Resultado4 = ""
            Resultado5 = ""
            Resultado6 = ""
            Resultado7 = ""
            Resultado8 = ""
            Resultado9 = ""
            Resultado10 = ""
            Resultado11 = ""
        Else
            Resultado = IIf(IsDBNull(C1fgrdResultado.Item(iRow, ColSeleccion + 1)), "", C1fgrdResultado.Item(iRow, ColSeleccion + 1))
            If oDatos.Tables(0).Columns.Count > 1 Then Resultado2 = IIf(IsDBNull(C1fgrdResultado.Item(iRow, 2)), "", C1fgrdResultado.Item(iRow, 2))
            If oDatos.Tables(0).Columns.Count > 2 Then Resultado3 = IIf(IsDBNull(C1fgrdResultado.Item(iRow, 3)), "", C1fgrdResultado.Item(iRow, 3))
            If oDatos.Tables(0).Columns.Count > 3 Then Resultado4 = IIf(IsDBNull(C1fgrdResultado.Item(iRow, 4)), "", C1fgrdResultado.Item(iRow, 4))
            If oDatos.Tables(0).Columns.Count > 4 Then Resultado5 = IIf(IsDBNull(C1fgrdResultado.Item(iRow, 5)), "", C1fgrdResultado.Item(iRow, 5))
            If oDatos.Tables(0).Columns.Count > 5 Then Resultado6 = IIf(IsDBNull(C1fgrdResultado.Item(iRow, 6)), "", C1fgrdResultado.Item(iRow, 6))
            If oDatos.Tables(0).Columns.Count > 6 Then Resultado7 = IIf(IsDBNull(C1fgrdResultado.Item(iRow, 7)), "", C1fgrdResultado.Item(iRow, 7))
            If oDatos.Tables(0).Columns.Count > 7 Then Resultado8 = IIf(IsDBNull(C1fgrdResultado.Item(iRow, 8)), "", C1fgrdResultado.Item(iRow, 8))
            If oDatos.Tables(0).Columns.Count > 8 Then Resultado9 = IIf(IsDBNull(C1fgrdResultado.Item(iRow, 9)), "", C1fgrdResultado.Item(iRow, 9))
            If oDatos.Tables(0).Columns.Count > 9 Then Resultado10 = IIf(IsDBNull(C1fgrdResultado.Item(iRow, 10)), "", C1fgrdResultado.Item(iRow, 10))
            If oDatos.Tables(0).Columns.Count > 10 Then Resultado11 = IIf(IsDBNull(C1fgrdResultado.Item(iRow, 11)), "", C1fgrdResultado.Item(iRow, 11))
        End If
        Me.Close()
    End Sub

    Private Sub C1fgrdResultado_AfterSelChange(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.RangeEventArgs) Handles C1fgrdResultado.AfterSelChange
        iRow = C1fgrdResultado.RowSel
        iCol = C1fgrdResultado.ColSel
    End Sub

    Private Sub frmAGenerico_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If optTodos.Checked = True Then
            Resultado = ""
            Resultado2 = ""
            Resultado3 = ""
            Resultado4 = ""
            Resultado5 = ""
            Resultado6 = ""
            Resultado7 = ""
            Resultado8 = ""
            Resultado9 = ""
            Resultado10 = ""
            Resultado11 = ""
        End If
    End Sub

End Class
