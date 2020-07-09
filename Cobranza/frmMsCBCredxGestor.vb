Public Class frmMsCBCredxGestor
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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
    Friend WithEvents fg As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btVerDetalle1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.fg = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.btVerDetalle1 = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
        Me.fg.BackColor = System.Drawing.SystemColors.Window
        Me.fg.BackColorAlternate = System.Drawing.Color.WhiteSmoke
        Me.fg.BackColorBkg = System.Drawing.SystemColors.AppWorkspace
        Me.fg.BackColorFixed = System.Drawing.Color.Teal
        Me.fg.BackColorSel = System.Drawing.SystemColors.Highlight
        Me.fg.Cols = 6
        Me.fg.ColumnInfo = "6,1,0,0,0,85,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.ForeColorFixed = System.Drawing.Color.White
        Me.fg.ForeColorSel = System.Drawing.SystemColors.HighlightText
        Me.fg.GridColor = System.Drawing.SystemColors.Control
        Me.fg.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.fg.Location = New System.Drawing.Point(23, 97)
        Me.fg.Name = "fg"
        Me.fg.NodeClosedPicture = Nothing
        Me.fg.NodeOpenPicture = Nothing
        Me.fg.OutlineBar = C1.Win.C1FlexGrid.Classic.OutlineBarSettings.flexOutlineBarSimple
        Me.fg.OutlineCol = -1
        Me.fg.Rows = 2
        Me.fg.SheetBorder = System.Drawing.Color.Black
        Me.fg.Size = New System.Drawing.Size(679, 263)
        Me.fg.TabIndex = 6
        Me.fg.TreeColor = System.Drawing.Color.DarkGray
        Me.fg.WallPaper = Nothing
        '
        'btnAgregar1
        '
        Me.btnAgregar1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnAgregar1.Location = New System.Drawing.Point(23, 63)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 1014
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'btVerDetalle1
        '
        Me.btVerDetalle1.Location = New System.Drawing.Point(104, 63)
        Me.btVerDetalle1.Name = "btVerDetalle1"
        Me.btVerDetalle1.Size = New System.Drawing.Size(120, 28)
        Me.btVerDetalle1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btVerDetalle1.TabIndex = 1015
        Me.btVerDetalle1.Text = "Detalle Gestión"
        Me.btVerDetalle1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btVerDetalle1.UseSelectable = True
        Me.btVerDetalle1.UseStyleColors = True
        '
        'frmMsCBCredxGestor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(725, 408)
        Me.Controls.Add(Me.btVerDetalle1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.fg)
        Me.Name = "frmMsCBCredxGestor"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Listado de Préstamos - Créditos asignados a este Gestor"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private vCodGestor As String, vCodPrestamo As String

    Public Property CodGestor() As String
        Get
            Return vCodGestor
        End Get
        Set(ByVal Value As String)
            vCodGestor = Value
        End Set
    End Property

    Public Property CodPrestamo() As String
        Get
            Return vCodPrestamo
        End Get
        Set(ByVal Value As String)
            vCodPrestamo = Value
        End Set
    End Property



    Private Sub frmMsCBCredxGestor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ActualizaGrid()
        If fg.Row <> -1 Then Me.btnAgregar1.Visible = False
    End Sub

    Private Sub Encabezado()

        fg.ColumnCollection.Item(1).Caption = "Cód. Gestor"
        fg.ColumnCollection.Item(2).Caption = "Nombre"
        fg.ColumnCollection.Item(3).Caption = "Tipo de Gestor"
        fg.ColumnCollection.Item(4).Caption = "Cód. Préstamo"
        fg.ColumnCollection.Item(5).Caption = "Dui"
        fg.ColumnCollection.Item(6).Caption = "Fecha Asignación"

        fg.ColumnCollection.Item(0).Width = 20
        fg.ColumnCollection.Item(1).Width = 75
        fg.ColumnCollection.Item(2).Width = 200
        fg.ColumnCollection.Item(3).Width = 50
        fg.ColumnCollection.Item(4).Width = 150
        fg.ColumnCollection.Item(5).Width = 75
        fg.ColumnCollection.Item(6).Width = 100

    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ActualizaGrid()
        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarGestoresxCredito("*", "a.CodPrestamo='" & vCodPrestamo & "'", "*", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Gestores x Préstamo." & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Encabezado()
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As frmMsCBBitacoraGestores = New frmMsCBBitacoraGestores
            frm.pAccion = "Agregar"
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btVerDetalle1_Click(sender As Object, e As EventArgs) Handles btVerDetalle1.Click
        Try
            If fg.Row <> -1 Then
                Dim frm As frmMsCBBitacoraGestores = New frmMsCBBitacoraGestores
                frm.CodGestor = vCodGestor
                frm.CodPrestamo = Trim(fg.Item(fg.Row, "CodPrestamo"))
                frm.Dui = Trim(fg.Item(fg.Row, "Dui"))
                frm.pAccion = "Modificar"
                frm.btnGuardarTb1_1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


End Class

