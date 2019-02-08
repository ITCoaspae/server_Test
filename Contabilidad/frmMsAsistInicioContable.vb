Public Class frmMsAsistInicioContable
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnRegsHist As System.Windows.Forms.Button
    Friend WithEvents btnPartidaA As System.Windows.Forms.Button
    Friend WithEvents btnBDA As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtAnioIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtpAnioHist As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsAsistInicioContable))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.btnRegsHist = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtAnioIni = New System.Windows.Forms.DateTimePicker()
        Me.btnPartidaA = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpAnioHist = New System.Windows.Forms.DateTimePicker()
        Me.btnBDA = New System.Windows.Forms.Button()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Año:"
        '
        'dtpYear
        '
        Me.dtpYear.CustomFormat = "yyyy"
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(57, 67)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.ShowUpDown = True
        Me.dtpYear.Size = New System.Drawing.Size(56, 20)
        Me.dtpYear.TabIndex = 0
        '
        'btnRegsHist
        '
        Me.btnRegsHist.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRegsHist.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRegsHist.ForeColor = System.Drawing.Color.Black
        Me.btnRegsHist.Image = CType(resources.GetObject("btnRegsHist.Image"), System.Drawing.Image)
        Me.btnRegsHist.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegsHist.Location = New System.Drawing.Point(517, 67)
        Me.btnRegsHist.Name = "btnRegsHist"
        Me.btnRegsHist.Size = New System.Drawing.Size(80, 24)
        Me.btnRegsHist.TabIndex = 1
        Me.btnRegsHist.Text = "&Procesar"
        Me.btnRegsHist.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRegsHist.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Año:"
        '
        'dtAnioIni
        '
        Me.dtAnioIni.CustomFormat = "yyyy"
        Me.dtAnioIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtAnioIni.Location = New System.Drawing.Point(65, 67)
        Me.dtAnioIni.Name = "dtAnioIni"
        Me.dtAnioIni.ShowUpDown = True
        Me.dtAnioIni.Size = New System.Drawing.Size(56, 20)
        Me.dtAnioIni.TabIndex = 38
        '
        'btnPartidaA
        '
        Me.btnPartidaA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnPartidaA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPartidaA.ForeColor = System.Drawing.Color.Black
        Me.btnPartidaA.Image = CType(resources.GetObject("btnPartidaA.Image"), System.Drawing.Image)
        Me.btnPartidaA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPartidaA.Location = New System.Drawing.Point(493, 67)
        Me.btnPartidaA.Name = "btnPartidaA"
        Me.btnPartidaA.Size = New System.Drawing.Size(104, 24)
        Me.btnPartidaA.TabIndex = 0
        Me.btnPartidaA.Text = "&Generar Partida"
        Me.btnPartidaA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPartidaA.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Año:"
        '
        'dtpAnioHist
        '
        Me.dtpAnioHist.CustomFormat = "yyyy"
        Me.dtpAnioHist.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAnioHist.Location = New System.Drawing.Point(66, 67)
        Me.dtpAnioHist.Name = "dtpAnioHist"
        Me.dtpAnioHist.ShowUpDown = True
        Me.dtpAnioHist.Size = New System.Drawing.Size(56, 20)
        Me.dtpAnioHist.TabIndex = 36
        '
        'btnBDA
        '
        Me.btnBDA.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBDA.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBDA.ForeColor = System.Drawing.Color.Black
        Me.btnBDA.Image = CType(resources.GetObject("btnBDA.Image"), System.Drawing.Image)
        Me.btnBDA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBDA.Location = New System.Drawing.Point(517, 67)
        Me.btnBDA.Name = "btnBDA"
        Me.btnBDA.Size = New System.Drawing.Size(80, 24)
        Me.btnBDA.TabIndex = 0
        Me.btnBDA.Text = "&Procesar"
        Me.btnBDA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBDA.UseVisualStyleBackColor = False
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(608, 136)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabControl1.TabIndex = 1
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabControl1.UseSelectable = True
        Me.MetroTabControl1.UseStyleColors = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.btnRegsHist)
        Me.MetroTabPage1.Controls.Add(Me.Label3)
        Me.MetroTabPage1.Controls.Add(Me.MetroTextBox1)
        Me.MetroTabPage1.Controls.Add(Me.dtpYear)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(600, 94)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Creación Registros Históricos"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.BackColor = System.Drawing.Color.White
        Me.MetroTextBox1.Lines = New String() {"Este proceso traslada los registros del año seleccionado hacia  el contenedor de " &
            "registros históricos (si ya existen registros del año seleccionado estos se actu" &
            "alizan)."}
        Me.MetroTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Multiline = True
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ReadOnly = True
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.Size = New System.Drawing.Size(594, 38)
        Me.MetroTextBox1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTextBox1.TabIndex = 2
        Me.MetroTextBox1.Text = "Este proceso traslada los registros del año seleccionado hacia  el contenedor de " &
    "registros históricos (si ya existen registros del año seleccionado estos se actu" &
    "alizan)."
        Me.MetroTextBox1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox1.UseCustomBackColor = True
        Me.MetroTextBox1.UseSelectable = True
        Me.MetroTextBox1.UseStyleColors = True
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.Label5)
        Me.MetroTabPage2.Controls.Add(Me.MetroTextBox2)
        Me.MetroTabPage2.Controls.Add(Me.dtAnioIni)
        Me.MetroTabPage2.Controls.Add(Me.btnPartidaA)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(600, 94)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Generación Partida Apertura"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'MetroTextBox2
        '
        Me.MetroTextBox2.BackColor = System.Drawing.Color.White
        Me.MetroTextBox2.Lines = New String() {"Este proceso genera automáticamente la partida de apertura."}
        Me.MetroTextBox2.Location = New System.Drawing.Point(3, 3)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ReadOnly = True
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.Size = New System.Drawing.Size(594, 38)
        Me.MetroTextBox2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTextBox2.TabIndex = 3
        Me.MetroTextBox2.Text = "Este proceso genera automáticamente la partida de apertura."
        Me.MetroTextBox2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox2.UseCustomBackColor = True
        Me.MetroTextBox2.UseSelectable = True
        Me.MetroTextBox2.UseStyleColors = True
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.Label6)
        Me.MetroTabPage3.Controls.Add(Me.MetroTextBox3)
        Me.MetroTabPage3.Controls.Add(Me.dtpAnioHist)
        Me.MetroTabPage3.Controls.Add(Me.btnBDA)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(600, 94)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Preparar Base de Datos para Apertura"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'MetroTextBox3
        '
        Me.MetroTextBox3.BackColor = System.Drawing.Color.White
        Me.MetroTextBox3.Lines = New String() {"Este proceso limpia los registros del año en curso, antes de ejecutarlo asegurese" &
            " de haber creado Registros Históricos en el Paso 1, de lo contrario podría perde" &
            "r la información."}
        Me.MetroTextBox3.Location = New System.Drawing.Point(3, 3)
        Me.MetroTextBox3.MaxLength = 32767
        Me.MetroTextBox3.Multiline = True
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox3.ReadOnly = True
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.Size = New System.Drawing.Size(594, 38)
        Me.MetroTextBox3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTextBox3.TabIndex = 4
        Me.MetroTextBox3.Text = "Este proceso limpia los registros del año en curso, antes de ejecutarlo asegurese" &
    " de haber creado Registros Históricos en el Paso 1, de lo contrario podría perde" &
    "r la información."
        Me.MetroTextBox3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox3.UseCustomBackColor = True
        Me.MetroTextBox3.UseSelectable = True
        Me.MetroTextBox3.UseStyleColors = True
        '
        'frmMsAsistInicioContable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(656, 222)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(656, 222)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(656, 222)
        Me.Name = "frmMsAsistInicioContable"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Asistente Apertura Ejercicio Contable"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnRegsHist_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegsHist.Click
        Dim oContab As New wrConta.wsLibContab, vResultado As String
        Me.Cursor = Cursors.WaitCursor
        vResultado = oContab.CreacionSaldosHistoricos(Me.dtpYear.Value.Year, sUsuario, sPassword,sSucursal)
        If vResultado.Trim <> "" Then
            Me.Cursor = Cursors.Default
            MsgBox(vResultado, MsgBoxStyle.Critical And MsgBoxStyle.OKOnly, "Validación del Sistema")
        Else
            MsgBox("Proceso realizado con éxito!", MsgBoxStyle.Critical And MsgBoxStyle.OKOnly, "Validación del Sistema")
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnPartidaA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPartidaA.Click
        Dim oContab As New wrConta.wsLibContab, vResultado As String
        If MsgBox("¿Está seguro que desea generar la Partida de Apertura?", MsgBoxStyle.YesNo, "Generación Partida de Apertura") = MsgBoxResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            Dim pFecha As String
            pFecha = "01/01/" & Me.dtAnioIni.Value.Year
            vResultado = oContab.PartidaApertura(pFecha, sUsuario, sPassword,sSucursal)
            If vResultado.Trim <> "" Then
                Me.Cursor = Cursors.Default
                MsgBox(vResultado, MsgBoxStyle.Critical And MsgBoxStyle.OKOnly, "Validación del Sistema")
            Else
                MsgBox("Proceso realizado con éxito!", MsgBoxStyle.Critical And MsgBoxStyle.OKOnly, "Partida de Apertura")
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub frmMsAsistInicioContable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpYear.Value = Now
        Me.dtAnioIni.Value = Now
        Me.dtpAnioHist.Value = Now
    End Sub

    Private Sub btnBDA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBDA.Click
        Dim oContab As New wrConta.wsLibContab, vResultado As String
        If MsgBox("¿Está seguro que desea eliminar los registros?", MsgBoxStyle.YesNo, "Preparar Base de Datos para la Apertura") = MsgBoxResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            vResultado = oContab.ProcesoInicioEjercicio(Me.dtpAnioHist.Value.Year, sUsuario, sPassword, sSucursal)
            If vResultado.Trim <> "" Then
                Me.Cursor = Cursors.Default
                MsgBox(vResultado, MsgBoxStyle.Critical And MsgBoxStyle.OKOnly, "Validación del Sistema")
            Else
                MsgBox("Proceso realizado con éxito!", MsgBoxStyle.Critical And MsgBoxStyle.OKOnly, "Preparar Base de Datos para la Apertura")
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

End Class
