Public Class frmMsCBBitacoraGestores
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pAccion As String

    Private vCodGestor As String, vCodPrestamo As String, vCodBitacora As String, vDui As String
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardarTb1_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSig1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents btGuardarTb3_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCobranza As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoCobranza As System.Windows.Forms.TextBox
    Friend WithEvents txtAcuerdo As System.Windows.Forms.TextBox
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtDespacho As System.Windows.Forms.TextBox
    Friend WithEvents tbGestionCred As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblDespacho As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents txtGestor As System.Windows.Forms.TextBox
    Friend WithEvents txtCodGestor As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNit As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblCompromiso As System.Windows.Forms.Label
    Friend WithEvents lblRango As System.Windows.Forms.Label
    Friend WithEvents tb As System.Windows.Forms.TabControl
    Friend WithEvents tbTipoGestion As System.Windows.Forms.TabPage
    Friend WithEvents fg As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents gbGestion As System.Windows.Forms.GroupBox
    Friend WithEvents fgSitGest As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents txtTipoGestion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoGestion As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbTransfGestion As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents fgGestorxCredito As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents txtCodActualGestor As System.Windows.Forms.TextBox
    Friend WithEvents txtCodNuevoGestor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblHistorico As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionHistorico As System.Windows.Forms.Label
    Friend WithEvents txtCodPrestamoTb3 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpTransferenciaGestor As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents tip As System.Windows.Forms.ToolTip
    Friend WithEvents dtpFechaPactada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCodDespacho As System.Windows.Forms.TextBox
    Friend WithEvents lblAsociado As System.Windows.Forms.Label
    Friend WithEvents lblGestor As System.Windows.Forms.Label
    Friend WithEvents lblPrestamo As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tb = New System.Windows.Forms.TabControl()
        Me.tbGestionCred = New System.Windows.Forms.TabPage()
        Me.btnSig1 = New MetroFramework.Controls.MetroButton()
        Me.btnGuardarTb1_1 = New MetroFramework.Controls.MetroButton()
        Me.txtTipoGestion = New System.Windows.Forms.TextBox()
        Me.lblDescripcionHistorico = New System.Windows.Forms.Label()
        Me.txtCodTipoGestion = New System.Windows.Forms.TextBox()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblHistorico = New System.Windows.Forms.Label()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtNit = New C1.Win.C1Input.C1TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.fgSitGest = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.txtGestor = New System.Windows.Forms.TextBox()
        Me.txtCodGestor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbTipoGestion = New System.Windows.Forms.TabPage()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.fg = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.gbGestion = New System.Windows.Forms.GroupBox()
        Me.txtCodDespacho = New System.Windows.Forms.TextBox()
        Me.dtpFechaPactada = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.lblCompromiso = New System.Windows.Forms.Label()
        Me.lblRango = New System.Windows.Forms.Label()
        Me.txtDespacho = New System.Windows.Forms.TextBox()
        Me.lblDespacho = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtAcuerdo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTipoCobranza = New System.Windows.Forms.TextBox()
        Me.txtCodTipoCobranza = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbTransfGestion = New System.Windows.Forms.TabPage()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.fgGestorxCredito = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btGuardarTb3_1 = New MetroFramework.Controls.MetroButton()
        Me.txtCodPrestamoTb3 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCodNuevoGestor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpTransferenciaGestor = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCodActualGestor = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblAsociado = New System.Windows.Forms.Label()
        Me.lblGestor = New System.Windows.Forms.Label()
        Me.lblPrestamo = New System.Windows.Forms.Label()
        Me.tb.SuspendLayout()
        Me.tbGestionCred.SuspendLayout()
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.fgSitGest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbTipoGestion.SuspendLayout()
        'CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbGestion.SuspendLayout()
        Me.tbTransfGestion.SuspendLayout()
        ' CType(Me.fgGestorxCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tb
        '
        Me.tb.Controls.Add(Me.tbGestionCred)
        Me.tb.Controls.Add(Me.tbTipoGestion)
        Me.tb.Controls.Add(Me.tbTransfGestion)
        Me.tb.Location = New System.Drawing.Point(23, 63)
        Me.tb.Name = "tb"
        Me.tb.SelectedIndex = 0
        Me.tb.Size = New System.Drawing.Size(664, 400)
        Me.tb.TabIndex = 6
        '
        'tbGestionCred
        '
        Me.tbGestionCred.BackColor = System.Drawing.Color.White
        Me.tbGestionCred.Controls.Add(Me.btnSig1)
        Me.tbGestionCred.Controls.Add(Me.btnGuardarTb1_1)
        Me.tbGestionCred.Controls.Add(Me.txtTipoGestion)
        Me.tbGestionCred.Controls.Add(Me.lblDescripcionHistorico)
        Me.tbGestionCred.Controls.Add(Me.txtCodTipoGestion)
        Me.tbGestionCred.Controls.Add(Me.MetroButton2)
        Me.tbGestionCred.Controls.Add(Me.Label12)
        Me.tbGestionCred.Controls.Add(Me.lblHistorico)
        Me.tbGestionCred.Controls.Add(Me.btnMod)
        Me.tbGestionCred.Controls.Add(Me.dtpFecha)
        Me.tbGestionCred.Controls.Add(Me.txtNit)
        Me.tbGestionCred.Controls.Add(Me.Label7)
        Me.tbGestionCred.Controls.Add(Me.txtCodPrestamo)
        Me.tbGestionCred.Controls.Add(Me.MetroButton4)
        Me.tbGestionCred.Controls.Add(Me.Label6)
        Me.tbGestionCred.Controls.Add(Me.Label14)
        Me.tbGestionCred.Controls.Add(Me.fgSitGest)
        Me.tbGestionCred.Controls.Add(Me.txtGestor)
        Me.tbGestionCred.Controls.Add(Me.txtCodGestor)
        Me.tbGestionCred.Controls.Add(Me.Label8)
        Me.tbGestionCred.Location = New System.Drawing.Point(4, 22)
        Me.tbGestionCred.Name = "tbGestionCred"
        Me.tbGestionCred.Size = New System.Drawing.Size(656, 374)
        Me.tbGestionCred.TabIndex = 2
        Me.tbGestionCred.Text = "Administración - Supervisión de Gestión de Crédito"
        '
        'btnSig1
        '
        Me.btnSig1.Location = New System.Drawing.Point(573, 334)
        Me.btnSig1.Name = "btnSig1"
        Me.btnSig1.Size = New System.Drawing.Size(75, 28)
        Me.btnSig1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSig1.TabIndex = 201
        Me.btnSig1.Text = "&Siguiente"
        Me.btnSig1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSig1.UseSelectable = True
        Me.btnSig1.UseStyleColors = True
        '
        'btnGuardarTb1_1
        '
        Me.btnGuardarTb1_1.Location = New System.Drawing.Point(492, 334)
        Me.btnGuardarTb1_1.Name = "btnGuardarTb1_1"
        Me.btnGuardarTb1_1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardarTb1_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardarTb1_1.TabIndex = 200
        Me.btnGuardarTb1_1.Text = "&Guardar"
        Me.btnGuardarTb1_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardarTb1_1.UseSelectable = True
        Me.btnGuardarTb1_1.UseStyleColors = True
        '
        'txtTipoGestion
        '
        Me.txtTipoGestion.BackColor = System.Drawing.Color.White
        Me.txtTipoGestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoGestion.Location = New System.Drawing.Point(177, 308)
        Me.txtTipoGestion.MaxLength = 100
        Me.txtTipoGestion.Name = "txtTipoGestion"
        Me.txtTipoGestion.ReadOnly = True
        Me.txtTipoGestion.Size = New System.Drawing.Size(471, 20)
        Me.txtTipoGestion.TabIndex = 1
        '
        'lblDescripcionHistorico
        '
        Me.lblDescripcionHistorico.ForeColor = System.Drawing.Color.Teal
        Me.lblDescripcionHistorico.Location = New System.Drawing.Point(128, 93)
        Me.lblDescripcionHistorico.Name = "lblDescripcionHistorico"
        Me.lblDescripcionHistorico.Size = New System.Drawing.Size(430, 12)
        Me.lblDescripcionHistorico.TabIndex = 103
        Me.lblDescripcionHistorico.Text = "Esta gestión de crédito ha finalizado o fue reasignada a otro gestor de créditos." &
    ""
        Me.lblDescripcionHistorico.Visible = False
        '
        'txtCodTipoGestion
        '
        Me.txtCodTipoGestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoGestion.Location = New System.Drawing.Point(115, 308)
        Me.txtCodTipoGestion.MaxLength = 20
        Me.txtCodTipoGestion.Name = "txtCodTipoGestion"
        Me.txtCodTipoGestion.Size = New System.Drawing.Size(56, 20)
        Me.txtCodTipoGestion.TabIndex = 0
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(8, 112)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(171, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 197
        Me.MetroButton2.Text = "&Nueva Situación de Gestión"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(5, 310)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 78
        Me.Label12.Text = "Tipo de Gestión:"
        '
        'lblHistorico
        '
        Me.lblHistorico.Font = New System.Drawing.Font("Arial", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHistorico.ForeColor = System.Drawing.Color.Teal
        Me.lblHistorico.Location = New System.Drawing.Point(2, 85)
        Me.lblHistorico.Name = "lblHistorico"
        Me.lblHistorico.Size = New System.Drawing.Size(120, 24)
        Me.lblHistorico.TabIndex = 102
        Me.lblHistorico.Text = "HISTÓRICO"
        Me.lblHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblHistorico.Visible = False
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(185, 112)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 198
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(115, 62)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(206, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'txtNit
        '
        Me.txtNit.BackColor = System.Drawing.Color.White
        Me.txtNit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNit.EditMask = "0000-000000-000-0"
        Me.txtNit.Location = New System.Drawing.Point(115, 36)
        Me.txtNit.MaxLength = 20
        Me.txtNit.Name = "txtNit"
        Me.txtNit.NumericInput = False
        Me.txtNit.ReadOnly = True
        Me.txtNit.Size = New System.Drawing.Size(206, 20)
        Me.txtNit.TabIndex = 0
        Me.txtNit.Tag = Nothing
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 16)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "Fecha Asignación:"
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BackColor = System.Drawing.Color.White
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Location = New System.Drawing.Point(442, 36)
        Me.txtCodPrestamo.MaxLength = 25
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.ReadOnly = True
        Me.txtCodPrestamo.Size = New System.Drawing.Size(206, 20)
        Me.txtCodPrestamo.TabIndex = 2
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(266, 112)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton4.TabIndex = 199
        Me.MetroButton4.Text = "Eliminar"
        Me.MetroButton4.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton4.UseSelectable = True
        Me.MetroButton4.UseStyleColors = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(353, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Cód. Préstamo:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(3, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 16)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "Nit Gestor:"
        '
        'fgSitGest
        '
        Me.fgSitGest.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
        Me.fgSitGest.BackColor = System.Drawing.SystemColors.Window
        Me.fgSitGest.BackColorAlternate = System.Drawing.Color.WhiteSmoke
        Me.fgSitGest.BackColorBkg = System.Drawing.SystemColors.AppWorkspace
        Me.fgSitGest.BackColorFixed = System.Drawing.Color.Teal
        Me.fgSitGest.BackColorSel = System.Drawing.SystemColors.Highlight
        Me.fgSitGest.Cols = 6
        Me.fgSitGest.ColumnInfo = "6,1,0,0,0,85,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgSitGest.ForeColorFixed = System.Drawing.Color.White
        Me.fgSitGest.ForeColorSel = System.Drawing.SystemColors.HighlightText
        Me.fgSitGest.GridColor = System.Drawing.SystemColors.Control
        Me.fgSitGest.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.fgSitGest.Location = New System.Drawing.Point(7, 146)
        Me.fgSitGest.Name = "fgSitGest"
        Me.fgSitGest.NodeClosedPicture = Nothing
        Me.fgSitGest.NodeOpenPicture = Nothing
        Me.fgSitGest.OutlineBar = C1.Win.C1FlexGrid.Classic.OutlineBarSettings.flexOutlineBarSimple
        Me.fgSitGest.OutlineCol = -1
        Me.fgSitGest.Rows = 2
        Me.fgSitGest.SheetBorder = System.Drawing.Color.Black
        Me.fgSitGest.Size = New System.Drawing.Size(641, 156)
        Me.fgSitGest.TabIndex = 4
        Me.fgSitGest.TreeColor = System.Drawing.Color.DarkGray
        Me.fgSitGest.WallPaper = Nothing
        '
        'txtGestor
        '
        Me.txtGestor.BackColor = System.Drawing.Color.White
        Me.txtGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGestor.Location = New System.Drawing.Point(177, 10)
        Me.txtGestor.MaxLength = 100
        Me.txtGestor.Name = "txtGestor"
        Me.txtGestor.ReadOnly = True
        Me.txtGestor.Size = New System.Drawing.Size(471, 20)
        Me.txtGestor.TabIndex = 6
        '
        'txtCodGestor
        '
        Me.txtCodGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodGestor.Location = New System.Drawing.Point(115, 10)
        Me.txtCodGestor.MaxLength = 20
        Me.txtCodGestor.Name = "txtCodGestor"
        Me.txtCodGestor.Size = New System.Drawing.Size(56, 20)
        Me.txtCodGestor.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(4, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 78
        Me.Label8.Text = "Gestor:"
        '
        'tbTipoGestion
        '
        Me.tbTipoGestion.BackColor = System.Drawing.Color.White
        Me.tbTipoGestion.Controls.Add(Me.MetroButton3)
        Me.tbTipoGestion.Controls.Add(Me.MetroButton1)
        Me.tbTipoGestion.Controls.Add(Me.fg)
        Me.tbTipoGestion.Controls.Add(Me.gbGestion)
        Me.tbTipoGestion.Location = New System.Drawing.Point(4, 22)
        Me.tbTipoGestion.Name = "tbTipoGestion"
        Me.tbTipoGestion.Size = New System.Drawing.Size(656, 374)
        Me.tbTipoGestion.TabIndex = 0
        Me.tbTipoGestion.Text = "Tipo de Gestión"
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(496, 334)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 3
        Me.MetroButton3.Text = "&Atrás"
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(577, 334)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 0
        Me.MetroButton1.Text = "&Siguiente"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
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
        Me.fg.Location = New System.Drawing.Point(8, 8)
        Me.fg.Name = "fg"
        Me.fg.NodeClosedPicture = Nothing
        Me.fg.NodeOpenPicture = Nothing
        Me.fg.OutlineBar = C1.Win.C1FlexGrid.Classic.OutlineBarSettings.flexOutlineBarSimple
        Me.fg.OutlineCol = -1
        Me.fg.Rows = 2
        Me.fg.SheetBorder = System.Drawing.Color.Black
        Me.fg.Size = New System.Drawing.Size(640, 120)
        Me.fg.TabIndex = 0
        Me.tip.SetToolTip(Me.fg, "Presione doble click para ver el detalle de la Gestión")
        Me.fg.TreeColor = System.Drawing.Color.DarkGray
        Me.fg.WallPaper = Nothing
        '
        'gbGestion
        '
        Me.gbGestion.BackColor = System.Drawing.Color.White
        Me.gbGestion.Controls.Add(Me.txtCodDespacho)
        Me.gbGestion.Controls.Add(Me.dtpFechaPactada)
        Me.gbGestion.Controls.Add(Me.Label23)
        Me.gbGestion.Controls.Add(Me.txtHora)
        Me.gbGestion.Controls.Add(Me.lblCompromiso)
        Me.gbGestion.Controls.Add(Me.lblRango)
        Me.gbGestion.Controls.Add(Me.txtDespacho)
        Me.gbGestion.Controls.Add(Me.lblDespacho)
        Me.gbGestion.Controls.Add(Me.txtObservaciones)
        Me.gbGestion.Controls.Add(Me.Label4)
        Me.gbGestion.Controls.Add(Me.Label3)
        Me.gbGestion.Controls.Add(Me.dtFecha)
        Me.gbGestion.Controls.Add(Me.txtAcuerdo)
        Me.gbGestion.Controls.Add(Me.Label9)
        Me.gbGestion.Controls.Add(Me.txtTipoCobranza)
        Me.gbGestion.Controls.Add(Me.txtCodTipoCobranza)
        Me.gbGestion.Controls.Add(Me.Label2)
        Me.gbGestion.Controls.Add(Me.Label1)
        Me.gbGestion.Location = New System.Drawing.Point(8, 128)
        Me.gbGestion.Name = "gbGestion"
        Me.gbGestion.Size = New System.Drawing.Size(640, 200)
        Me.gbGestion.TabIndex = 2
        Me.gbGestion.TabStop = False
        '
        'txtCodDespacho
        '
        Me.txtCodDespacho.BackColor = System.Drawing.Color.White
        Me.txtCodDespacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodDespacho.Location = New System.Drawing.Point(116, 171)
        Me.txtCodDespacho.Name = "txtCodDespacho"
        Me.txtCodDespacho.ReadOnly = True
        Me.txtCodDespacho.Size = New System.Drawing.Size(48, 20)
        Me.txtCodDespacho.TabIndex = 16
        Me.txtCodDespacho.Visible = False
        '
        'dtpFechaPactada
        '
        Me.dtpFechaPactada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPactada.Location = New System.Drawing.Point(346, 50)
        Me.dtpFechaPactada.Name = "dtpFechaPactada"
        Me.dtpFechaPactada.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaPactada.TabIndex = 6
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(252, 54)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(88, 16)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Fecha Pactada:"
        '
        'txtHora
        '
        Me.txtHora.BackColor = System.Drawing.Color.White
        Me.txtHora.Location = New System.Drawing.Point(548, 148)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(80, 20)
        Me.txtHora.TabIndex = 14
        '
        'lblCompromiso
        '
        Me.lblCompromiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompromiso.ForeColor = System.Drawing.Color.Teal
        Me.lblCompromiso.Location = New System.Drawing.Point(6, 54)
        Me.lblCompromiso.Name = "lblCompromiso"
        Me.lblCompromiso.Size = New System.Drawing.Size(258, 16)
        Me.lblCompromiso.TabIndex = 4
        Me.lblCompromiso.Text = "Compromiso de pago no debe exceder de "
        '
        'lblRango
        '
        Me.lblRango.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRango.ForeColor = System.Drawing.Color.Teal
        Me.lblRango.Location = New System.Drawing.Point(6, 35)
        Me.lblRango.Name = "lblRango"
        Me.lblRango.Size = New System.Drawing.Size(133, 16)
        Me.lblRango.TabIndex = 3
        Me.lblRango.Text = "Rango de morosidad:"
        '
        'txtDespacho
        '
        Me.txtDespacho.BackColor = System.Drawing.Color.White
        Me.txtDespacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDespacho.Location = New System.Drawing.Point(170, 171)
        Me.txtDespacho.MaxLength = 100
        Me.txtDespacho.Name = "txtDespacho"
        Me.txtDespacho.ReadOnly = True
        Me.txtDespacho.Size = New System.Drawing.Size(458, 20)
        Me.txtDespacho.TabIndex = 17
        Me.txtDespacho.Visible = False
        '
        'lblDespacho
        '
        Me.lblDespacho.BackColor = System.Drawing.Color.White
        Me.lblDespacho.Location = New System.Drawing.Point(6, 172)
        Me.lblDespacho.Name = "lblDespacho"
        Me.lblDespacho.Size = New System.Drawing.Size(112, 16)
        Me.lblDespacho.TabIndex = 15
        Me.lblDespacho.Text = "Nombre Despacho:"
        Me.lblDespacho.Visible = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.White
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtObservaciones.Location = New System.Drawing.Point(116, 109)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ReadOnly = True
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(512, 30)
        Me.txtObservaciones.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Observaciones:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(434, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Hora de la Gestión:"
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(116, 145)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(110, 20)
        Me.dtFecha.TabIndex = 12
        '
        'txtAcuerdo
        '
        Me.txtAcuerdo.BackColor = System.Drawing.Color.White
        Me.txtAcuerdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAcuerdo.Location = New System.Drawing.Point(116, 73)
        Me.txtAcuerdo.Multiline = True
        Me.txtAcuerdo.Name = "txtAcuerdo"
        Me.txtAcuerdo.ReadOnly = True
        Me.txtAcuerdo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAcuerdo.Size = New System.Drawing.Size(512, 32)
        Me.txtAcuerdo.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 148)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Fecha de la Gestión:"
        '
        'txtTipoCobranza
        '
        Me.txtTipoCobranza.BackColor = System.Drawing.Color.White
        Me.txtTipoCobranza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCobranza.Location = New System.Drawing.Point(178, 12)
        Me.txtTipoCobranza.MaxLength = 100
        Me.txtTipoCobranza.Name = "txtTipoCobranza"
        Me.txtTipoCobranza.ReadOnly = True
        Me.txtTipoCobranza.Size = New System.Drawing.Size(450, 20)
        Me.txtTipoCobranza.TabIndex = 2
        '
        'txtCodTipoCobranza
        '
        Me.txtCodTipoCobranza.BackColor = System.Drawing.Color.White
        Me.txtCodTipoCobranza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoCobranza.Location = New System.Drawing.Point(116, 12)
        Me.txtCodTipoCobranza.MaxLength = 20
        Me.txtCodTipoCobranza.Name = "txtCodTipoCobranza"
        Me.txtCodTipoCobranza.ReadOnly = True
        Me.txtCodTipoCobranza.Size = New System.Drawing.Size(56, 20)
        Me.txtCodTipoCobranza.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Acuerdo o Comentario:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Cobranza:"
        '
        'tbTransfGestion
        '
        Me.tbTransfGestion.BackColor = System.Drawing.Color.White
        Me.tbTransfGestion.Controls.Add(Me.MetroButton5)
        Me.tbTransfGestion.Controls.Add(Me.fgGestorxCredito)
        Me.tbTransfGestion.Controls.Add(Me.GroupBox1)
        Me.tbTransfGestion.Location = New System.Drawing.Point(4, 22)
        Me.tbTransfGestion.Name = "tbTransfGestion"
        Me.tbTransfGestion.Size = New System.Drawing.Size(656, 374)
        Me.tbTransfGestion.TabIndex = 3
        Me.tbTransfGestion.Text = "Transferencia de Gestión de Crédito"
        '
        'MetroButton5
        '
        Me.MetroButton5.Location = New System.Drawing.Point(573, 343)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton5.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton5.TabIndex = 22
        Me.MetroButton5.Text = "&Atrás"
        Me.MetroButton5.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton5.UseSelectable = True
        Me.MetroButton5.UseStyleColors = True
        '
        'fgGestorxCredito
        '
        Me.fgGestorxCredito.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
        Me.fgGestorxCredito.BackColor = System.Drawing.SystemColors.Window
        Me.fgGestorxCredito.BackColorAlternate = System.Drawing.Color.WhiteSmoke
        Me.fgGestorxCredito.BackColorBkg = System.Drawing.SystemColors.AppWorkspace
        Me.fgGestorxCredito.BackColorFixed = System.Drawing.Color.Teal
        Me.fgGestorxCredito.BackColorSel = System.Drawing.SystemColors.Highlight
        Me.fgGestorxCredito.Cols = 6
        Me.fgGestorxCredito.ColumnInfo = "6,1,0,0,0,85,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgGestorxCredito.ForeColorFixed = System.Drawing.Color.White
        Me.fgGestorxCredito.ForeColorSel = System.Drawing.SystemColors.HighlightText
        Me.fgGestorxCredito.GridColor = System.Drawing.SystemColors.Control
        Me.fgGestorxCredito.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.fgGestorxCredito.Location = New System.Drawing.Point(8, 8)
        Me.fgGestorxCredito.Name = "fgGestorxCredito"
        Me.fgGestorxCredito.NodeClosedPicture = Nothing
        Me.fgGestorxCredito.NodeOpenPicture = Nothing
        Me.fgGestorxCredito.OutlineBar = C1.Win.C1FlexGrid.Classic.OutlineBarSettings.flexOutlineBarSimple
        Me.fgGestorxCredito.OutlineCol = -1
        Me.fgGestorxCredito.Rows = 2
        Me.fgGestorxCredito.SheetBorder = System.Drawing.Color.Black
        Me.fgGestorxCredito.Size = New System.Drawing.Size(640, 221)
        Me.fgGestorxCredito.TabIndex = 21
        Me.fgGestorxCredito.TreeColor = System.Drawing.Color.DarkGray
        Me.fgGestorxCredito.WallPaper = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btGuardarTb3_1)
        Me.GroupBox1.Controls.Add(Me.txtCodPrestamoTb3)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCodNuevoGestor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtpTransferenciaGestor)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtCodActualGestor)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 235)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 102)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'btGuardarTb3_1
        '
        Me.btGuardarTb3_1.Location = New System.Drawing.Point(509, 66)
        Me.btGuardarTb3_1.Name = "btGuardarTb3_1"
        Me.btGuardarTb3_1.Size = New System.Drawing.Size(125, 28)
        Me.btGuardarTb3_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btGuardarTb3_1.TabIndex = 201
        Me.btGuardarTb3_1.Text = "&Guardar Transferencia"
        Me.btGuardarTb3_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btGuardarTb3_1.UseSelectable = True
        Me.btGuardarTb3_1.UseStyleColors = True
        '
        'txtCodPrestamoTb3
        '
        Me.txtCodPrestamoTb3.BackColor = System.Drawing.Color.White
        Me.txtCodPrestamoTb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamoTb3.Enabled = False
        Me.txtCodPrestamoTb3.Location = New System.Drawing.Point(124, 40)
        Me.txtCodPrestamoTb3.MaxLength = 20
        Me.txtCodPrestamoTb3.Name = "txtCodPrestamoTb3"
        Me.txtCodPrestamoTb3.ReadOnly = True
        Me.txtCodPrestamoTb3.Size = New System.Drawing.Size(184, 20)
        Me.txtCodPrestamoTb3.TabIndex = 94
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(6, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 16)
        Me.Label10.TabIndex = 95
        Me.Label10.Text = "Código de Préstamo:"
        '
        'txtCodNuevoGestor
        '
        Me.txtCodNuevoGestor.BackColor = System.Drawing.Color.White
        Me.txtCodNuevoGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodNuevoGestor.Location = New System.Drawing.Point(450, 40)
        Me.txtCodNuevoGestor.MaxLength = 20
        Me.txtCodNuevoGestor.Name = "txtCodNuevoGestor"
        Me.txtCodNuevoGestor.ReadOnly = True
        Me.txtCodNuevoGestor.Size = New System.Drawing.Size(184, 20)
        Me.txtCodNuevoGestor.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(314, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Cod Nuevo Gestor"
        '
        'dtpTransferenciaGestor
        '
        Me.dtpTransferenciaGestor.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTransferenciaGestor.Location = New System.Drawing.Point(450, 14)
        Me.dtpTransferenciaGestor.Name = "dtpTransferenciaGestor"
        Me.dtpTransferenciaGestor.Size = New System.Drawing.Size(184, 20)
        Me.dtpTransferenciaGestor.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(314, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 16)
        Me.Label16.TabIndex = 90
        Me.Label16.Text = "Fecha Transferencia:"
        '
        'txtCodActualGestor
        '
        Me.txtCodActualGestor.BackColor = System.Drawing.Color.White
        Me.txtCodActualGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodActualGestor.Enabled = False
        Me.txtCodActualGestor.Location = New System.Drawing.Point(124, 14)
        Me.txtCodActualGestor.MaxLength = 20
        Me.txtCodActualGestor.Name = "txtCodActualGestor"
        Me.txtCodActualGestor.ReadOnly = True
        Me.txtCodActualGestor.Size = New System.Drawing.Size(184, 20)
        Me.txtCodActualGestor.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(6, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(104, 16)
        Me.Label18.TabIndex = 78
        Me.Label18.Text = "Cod Actual Gestor"
        '
        'lblAsociado
        '
        Me.lblAsociado.BackColor = System.Drawing.Color.White
        Me.lblAsociado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAsociado.ForeColor = System.Drawing.Color.Teal
        Me.lblAsociado.Location = New System.Drawing.Point(23, 466)
        Me.lblAsociado.Name = "lblAsociado"
        Me.lblAsociado.Size = New System.Drawing.Size(440, 16)
        Me.lblAsociado.TabIndex = 0
        Me.lblAsociado.Text = "Nombre de Asociado:"
        '
        'lblGestor
        '
        Me.lblGestor.BackColor = System.Drawing.Color.White
        Me.lblGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGestor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGestor.ForeColor = System.Drawing.Color.Teal
        Me.lblGestor.Location = New System.Drawing.Point(23, 490)
        Me.lblGestor.Name = "lblGestor"
        Me.lblGestor.Size = New System.Drawing.Size(648, 24)
        Me.lblGestor.TabIndex = 2
        Me.lblGestor.Text = "Gestor Asignado:"
        '
        'lblPrestamo
        '
        Me.lblPrestamo.BackColor = System.Drawing.Color.White
        Me.lblPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrestamo.ForeColor = System.Drawing.Color.Teal
        Me.lblPrestamo.Location = New System.Drawing.Point(471, 466)
        Me.lblPrestamo.Name = "lblPrestamo"
        Me.lblPrestamo.Size = New System.Drawing.Size(200, 16)
        Me.lblPrestamo.TabIndex = 1
        Me.lblPrestamo.Text = "Préstamo:"
        Me.lblPrestamo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmMsCBBitacoraGestores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(714, 542)
        Me.Controls.Add(Me.lblPrestamo)
        Me.Controls.Add(Me.lblGestor)
        Me.Controls.Add(Me.lblAsociado)
        Me.Controls.Add(Me.tb)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(714, 542)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(714, 542)
        Me.Name = "frmMsCBBitacoraGestores"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Procedimiento de Gestión de Crédito y Seguimiento de Cobranza"
        Me.tb.ResumeLayout(False)
        Me.tbGestionCred.ResumeLayout(False)
        Me.tbGestionCred.PerformLayout()
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgSitGest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbTipoGestion.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbGestion.ResumeLayout(False)
        Me.gbGestion.PerformLayout()
        Me.tbTransfGestion.ResumeLayout(False)
        CType(Me.fgGestorxCredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property Dui() As String
        Get
            Return vDui
        End Get
        Set(ByVal Value As String)
            vDui = Value
        End Set
    End Property

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

    Private Sub btnCerrarTb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub txtCodGestor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodGestor.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Gestor"
        Dim oPerif As wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarGestores("*", "", "CodGestor", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodGestor.Text = ofrm.Resultado.Trim
            Me.txtGestor.Text = ofrm.Resultado3.Trim
            Me.txtNit.Value = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Gestores - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Préstamo"
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow
        Try
            oPrest = New wrPrestamo.wsLibPrest
            ds = oPrest.CargarListaPrestamos(True, "", "", "", "", 0, 0, sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                txtCodPrestamo.Text = sTexto.Trim
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsCBBitacoraGestores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Estado As String
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection, oPerif As New wrConta.wsLibContab, oAsoc As New wrAsociados.wsLibAsoc
        Dim dr As DataRow
        Me.dtFecha.Value = Now
        Me.dtFecha.Value = Now
        Me.txtHora.Text = Now.TimeOfDay.ToString
        Me.txtCodPrestamo.Text = vCodPrestamo

        If Me.pAccion = "Modificar" Then

            ds = oCred.ConsultarGestoresxCredito("*", "CodPrestamo='" & Me.CodPrestamo.Trim & "' AND CodGestor='" & Me.CodGestor.Trim & "'", "CodGestor", sUsuario, sPassword, sSucursal)
            Me.fgGestorxCredito.DataSource = ds.Tables(0)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                If Not (IsDBNull(Filas.Item(0)("Estado"))) Then
                    Estado = Filas.Item(0)("Estado")
                    If Estado = "H" Then
                        Me.lblHistorico.Visible = True
                        Me.lblDescripcionHistorico.Visible = True
                    End If
                End If
                txtCodGestor.Text = IIf(IsDBNull(Filas.Item(0)("CodGestor")), "", Filas.Item(0)("CodGestor"))
                txtCodActualGestor.Text = IIf(IsDBNull(Filas.Item(0)("CodGestor")), "", Filas.Item(0)("CodGestor"))
                txtCodGestor.Enabled = False
                txtCodPrestamo.Text = IIf(IsDBNull(Filas.Item(0)("CodPrestamo")), "", Filas.Item(0)("CodPrestamo"))
                Me.lblPrestamo.Text = "Préstamo: " & IIf(IsDBNull(Filas.Item(0)("CodPrestamo")), "", Filas.Item(0)("CodPrestamo"))
                txtCodPrestamoTb3.Text = IIf(IsDBNull(Filas.Item(0)("CodPrestamo")), "", Filas.Item(0)("CodPrestamo"))
                txtCodPrestamo.Enabled = False
                dtpFecha.Value = IIf(IsDBNull(Filas.Item(0)("FechaAsignacion")), Now, Filas.Item(0)("FechaAsignacion"))
                ds = oCred.ConsultarGestores("Nombre,Nit", "CodGestor='" & Me.txtCodGestor.Text.Trim & "'", "CodGestor", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtGestor.Text = IIf(IsDBNull(Filas.Item(0)("Nombre")), "", Filas.Item(0)("Nombre"))
                    Me.lblGestor.Text = "Gestor Asignado: " & IIf(IsDBNull(Filas.Item(0)("Nombre")), "", Filas.Item(0)("Nombre"))
                    txtNit.Value = IIf(IsDBNull(Filas.Item(0)("Nit")), "", Filas.Item(0)("Nit"))
                End If
                Me.dtpFecha.Enabled = False
                Me.btnGuardarTb1_1.Enabled = True
                fg.DataSource = oCred.ConsultarBitacoraGestores("*", "CodGestor='" & Me.txtCodGestor.Text.Trim & "' and CodPrestamo='" & vCodPrestamo & "'", "CodBitacora", sUsuario, sPassword, sSucursal).Tables(0)
                fgSitGest.DataSource = oCred.ConsultarGestiones("**", "a.CodGestor='" & Me.txtCodGestor.Text.Trim & "' and a.CodPrestamo='" & vCodPrestamo & "'", "a.Correlativo", sUsuario, sPassword, sSucursal).Tables(0)
                ds = oAsoc.ConsultarAsociado("Nombres + ' ' + Apellido1 + ' ' + Apellido2 + ' ' + ApellidoCas as Nombre", "Dui='" & vDui.Trim & "'", "Dui", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.lblAsociado.Text = "Nombre de Asociado: " & dr("Nombre")
                End If
                Encabezado()
            End If
        End If
        txtCodPrestamo.Focus()

    End Sub

    Private Sub btnGuardarTb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub txtNit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNit.Validating
        Dim oPerif As wrCredito.wsLibCred, ds As New Data.DataSet, Filas As DataRowCollection
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarGestores("*", "Nit='" & Me.txtNit.Value & "'", "CodGestor", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtCodGestor.Text = IIf(IsDBNull(Filas.Item(0)("CodGestor")), "", Filas.Item(0)("CodGestor"))
                txtGestor.Text = IIf(IsDBNull(Filas.Item(0)("Nombre")), "", Filas.Item(0)("Nombre"))
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Gestores - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNit_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNit.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Gestor"
        Dim oPerif As wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarGestores("*", "Nit='" & Me.txtNit.Value & "'", "CodGestor", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodGestor.Text = ofrm.Resultado.Trim
            txtNit.Value = ofrm.Resultado2.Trim
            txtGestor.Text = ofrm.Resultado3.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Gestores - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnCerrarTb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btnAtrasTb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub

    Private Sub btnSgteTb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub

    Private Sub btnAtrasTb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub Encabezado()
        fgSitGest.ColumnCollection.Item(1).Width = 0
    End Sub

    Private Sub btNew_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btEdit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btDel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection, Estado As String

        ds = oCred.ConsultarBitacoraGestores("*", "CodBitacora='" & fg.Item(fg.Row, "CodBitacora") & "'", "CodBitacora", sUsuario, sPassword, sSucursal)
        Filas = ds.Tables(0).Rows()
        If Filas.Count > 0 Then
            vCodBitacora = fg.Item(fg.Row, "CodBitacora")
            Me.txtCodTipoCobranza.Text = IIf(IsDBNull(Filas.Item(0)("CodTipoCobranza")), "", Filas.Item(0)("CodTipoCobranza"))
            Me.dtFecha.Value = IIf(IsDBNull(Filas.Item(0)("Fecha")), Now, Filas.Item(0)("Fecha"))
            Me.dtpFechaPactada.Value = IIf(IsDBNull(Filas.Item(0)("FechaPactada")), Now, Filas.Item(0)("FechaPactada"))
            Me.txtHora.Text = IIf(IsDBNull(Filas.Item(0)("Hora")), "", Filas.Item(0)("Hora"))
            Me.txtAcuerdo.Text = IIf(IsDBNull(Filas.Item(0)("Comentario")), "", Filas.Item(0)("Comentario"))
            Me.txtCodDespacho.Text = IIf(IsDBNull(Filas.Item(0)("CodDespacho")), "", Filas.Item(0)("CodDespacho"))
            Me.txtObservaciones.Text = IIf(IsDBNull(Filas.Item(0)("Observaciones")), "", Filas.Item(0)("Observaciones"))
            If Me.txtCodTipoCobranza.Text.Trim <> "" Then
                ds = oCred.ConsultarTipoCobranza("Descripcion,Tipo", "CodTipoCobranza='" & Me.txtCodTipoCobranza.Text.Trim & "'", "CodTipoCobranza", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables("CBTipoCobranza").Rows()
                If Filas.Count > 0 Then
                    If IIf(IsDBNull(Filas.Item(0)("Tipo")), "N", Filas.Item(0)("Tipo")) = "J" Then
                        Me.txtCodDespacho.Visible = True
                        Me.txtDespacho.Visible = True
                        Me.lblDespacho.Visible = True
                    Else
                        Me.txtCodDespacho.Visible = False
                        Me.txtDespacho.Visible = False
                        Me.lblDespacho.Visible = False
                    End If
                    Me.txtTipoCobranza.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                End If
            End If
            If Me.txtCodDespacho.Text.Trim <> "" Then
                ds = oCred.ConsultarDespacho("Descripcion", "CodDespacho='" & Me.txtCodDespacho.Text.Trim & "'", "CodDespacho", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables("CBDespachos").Rows()
                If Filas.Count > 0 Then
                    Me.txtDespacho.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                End If
            End If
        End If
    End Sub

    Private Sub txtCodTipoGestion_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoGestion.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Tipo de Gestión"
        Dim oPerif As wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarTipoGestion("*", "", "CodTipoGestion", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodTipoGestion.Text = ofrm.Resultado.Trim
            Me.txtTipoGestion.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Tipo Gestión - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btSigtb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btATrasTb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnCerrarTb3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()

    End Sub

    Private Sub txtCodNuevoGestor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodNuevoGestor.Validating
        Dim oCred As wrCredito.wsLibCred, ds As New Data.DataSet, Filas As DataRowCollection
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarGestores("*", "CodGestor LIKE '" & Me.txtCodNuevoGestor.Text.Trim & "%'", "CodGestor", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                Me.txtCodNuevoGestor.Text = IIf(IsDBNull(Filas.Item(0)("CodGestor")), "", Filas.Item(0)("CodGestor"))
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Gestores - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblHistorico_Click(sender As Object, e As EventArgs) Handles lblHistorico.Click

    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String, pTipo As String
            Dim Filas As Data.DataRowCollection, ds As New DataSet

            If Me.txtCodGestor.Text.Trim = "" Then Exit Sub

            If Me.MetroButton2.Text = "&Nueva Situación de Gestión" Then

                'Me.gbSitGest.Visible = True
                Me.MetroButton2.Text = "&Agregar Situación de Gestión"

            ElseIf Me.MetroButton2.Text = "&Modificar Situación de Gestión" Then

                If Me.txtCodTipoGestion.Text.Trim = "" Then
                    MsgBox("El Tipo de Gestión no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Cobranzas")
                    Exit Sub
                End If

                pCampos = "CodTipoGestion='" & Me.txtCodTipoGestion.Text.Trim & "'"
                If oCred.ModificarGestiones(vCodBitacora, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    ' Me.gbSitGest.Visible = False
                    Me.txtCodTipoGestion.Text = ""
                    Me.txtTipoGestion.Text = ""
                    Me.MetroButton2.Text = "&Nueva Situación de Gestión"
                    Me.btnMod.Enabled = True
                    fgSitGest.DataSource = oCred.ConsultarGestiones("**", "a.CodGestor='" & vCodGestor & "' and a.CodPrestamo='" & vCodPrestamo & "'", "a.Correlativo", sUsuario, sPassword, sSucursal).Tables(0)
                    Encabezado()
                Else
                    MsgBox("El registro no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Cobranzas")
                End If
            ElseIf Me.MetroButton2.Text = "&Agregar Situación de Gestión" Then

                If Me.txtCodTipoGestion.Text.Trim = "" Then
                    MsgBox("El Tipo de Gestión no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Cobranzas")
                    Exit Sub
                End If

                pCampos = "CodGestor,CodPrestamo,CodTipoGestion"
                pValores = "'" & Me.txtCodGestor.Text.Trim & "','" & Me.txtCodPrestamo.Text.Trim & "','" & Me.txtCodTipoGestion.Text.Trim & "'"
                If oCred.InsertarGestiones(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    '  Me.gbSitGest.Visible = False
                    Me.txtCodTipoGestion.Text = ""
                    Me.txtTipoGestion.Text = ""
                    Me.MetroButton2.Text = "&Nueva Situación de Gestión"
                    fgSitGest.DataSource = oCred.ConsultarGestiones("**", "a.CodGestor='" & Me.txtCodGestor.Text.Trim & "' and a.CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "a.Correlativo", sUsuario, sPassword, sSucursal).Tables(0)
                    Encabezado()
                Else
                    MsgBox("El registro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Cobranzas")
                End If

            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            If fgSitGest.Row <> -1 Then
                'Me.gbSitGest.Visible = True
                Me.MetroButton2.Text = "&Modificar Situación de Gestión"
                Me.btnMod.Enabled = False

                Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
                Dim Filas As Data.DataRowCollection

                ds = oCred.ConsultarGestiones("*", "Correlativo='" & fgSitGest.Item(fgSitGest.Row, "Correlativo") & "'", "Correlativo", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    vCodBitacora = fgSitGest.Item(fgSitGest.Row, "Correlativo")
                    txtCodTipoGestion.Text = IIf(IsDBNull(Filas.Item(0)("CodTipoGestion")), "", Filas.Item(0)("CodTipoGestion"))
                    ds = oCred.ConsultarTipoGestion("Descripcion", "CodTipoGestion='" & Me.txtCodTipoGestion.Text.Trim & "'", "CodTipoGestion", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then Me.txtTipoGestion.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String
            Dim Filas As Data.DataRowCollection, ds As New DataSet
            If fgSitGest.Row <> -1 Then
                If oCred.EliminarGestiones(fgSitGest.Item(fgSitGest.Row, "Correlativo"), sUsuario, sPassword, sSucursal) = False Then
                    MsgBox("El registro NO ha sido eliminado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Cobranzas")
                Else
                    fgSitGest.DataSource = oCred.ConsultarGestiones("**", "a.CodGestor='" & vCodGestor & "' and a.CodPrestamo='" & vCodPrestamo & "'", "a.Correlativo", sUsuario, sPassword, sSucursal).Tables(0)
                    Encabezado()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtGestor_TextChanged(sender As Object, e As EventArgs) Handles txtGestor.TextChanged

    End Sub

    Private Sub btnGuardarTb1_1_Click(sender As Object, e As EventArgs) Handles btnGuardarTb1_1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String, pTipo As String

            If Me.txtCodPrestamo.Text.Trim = "" Then
                MsgBox("El Código de Préstamo no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Cobranzas")
                Exit Sub
            End If

            If Me.txtCodGestor.Text.Trim = "" Then
                MsgBox("El Código de Gestor no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Cobranzas")
                Exit Sub
            End If

            If pAccion = "Agregar" Then
                pCampos = "CodGestor,CodPrestamo,Dui,FechaAsignacion,Estado"
                pValores = "'" & Me.txtCodGestor.Text.Trim & "','" & Me.txtCodPrestamo.Text.Trim & "','" & vDui & "','" & Format(Me.dtpFecha.Value, "dd/MM/yyyy") & "','A'"
                vCodGestor = Me.txtCodGestor.Text.Trim
                vCodPrestamo = Me.txtCodPrestamo.Text.Trim
                If oCred.InsertarGestoresxCredito(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.pAccion = "Modificar"
                    Me.btnGuardarTb1_1.Text = "&Modificar"
                Else
                    MsgBox("El registro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Cobranzas")
                End If
            ElseIf pAccion = "Modificar" Then
                Me.btnGuardarTb1_1.Enabled = True
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSig1_Click(sender As Object, e As EventArgs) Handles btnSig1.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub

    Private Sub MetroButton3_Click_1(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub

    Private Sub MetroButton5_Click(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub

    Private Sub btGuardarTb3_1_Click(sender As Object, e As EventArgs) Handles btGuardarTb3_1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
            Dim Campos, Valores As String

            If Me.txtCodActualGestor.Text = "" Or Me.txtCodNuevoGestor.Text = "" Or Me.txtCodPrestamoTb3.Text = "" Then
                MsgBox("Existen campos que no pueden quedar vacíos para realizar esta operación", MsgBoxStyle.Information, "Módulo - Cobranza")
            Else
                Campos = "CodGestor,CodPrestamo,FechaAsignacion,Estado"
                Valores = "'" & Me.txtCodNuevoGestor.Text.Trim & "','" & Me.txtCodPrestamoTb3.Text.Trim & "','" & Me.dtpTransferenciaGestor.Value.ToShortDateString & "','A'"
                If oCred.ModificarGestoresxCredito("CodGestor='" & Me.txtCodActualGestor.Text.Trim & "' and CodPrestamo='" & Me.txtCodPrestamoTb3.Text.Trim & "'", "Estado ='H'", sUsuario, sPassword, sSucursal) = True Then
                    If oCred.InsertarGestoresxCredito(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                        MsgBox("La transferencia del Crédito al nuevo Gestor se ha realizado Correctamente", MsgBoxStyle.Information, "Módulo - Créditos")
                    End If
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodNuevoGestor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodNuevoGestor.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Gestores"
        Dim oCred As wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarGestores("*", "", "CodGestor", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodNuevoGestor.Text = ofrm.Resultado.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Tipo Gestión - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btGuardarTb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtCodGestor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodGestor.TextChanged

    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click

    End Sub
End Class