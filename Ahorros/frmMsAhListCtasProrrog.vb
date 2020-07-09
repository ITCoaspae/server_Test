Public Class frmMsAhListCtasProrrog
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim ahorro As New wrAhorro.wsLibAhorro

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents fg2 As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cbTipoAhorro As MetroFramework.Controls.MetroComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsAhListCtasProrrog))
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fg2 = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.cbTipoAhorro = New MetroFramework.Controls.MetroComboBox()
        CType(Me.fg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(26, 104)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 191
        Me.MetroButton1.Text = "Ver Registros"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(28, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 19)
        Me.Label6.TabIndex = 180
        Me.Label6.Text = "Tipo de Ahorro:"
        '
        'fg2
        '
        Me.fg2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg2.BackColor = System.Drawing.Color.White
        Me.fg2.BackColorAlternate = System.Drawing.Color.WhiteSmoke
        Me.fg2.BackColorBkg = System.Drawing.Color.White
        Me.fg2.BackColorFixed = System.Drawing.Color.Teal
        Me.fg2.BackColorSel = System.Drawing.Color.Gainsboro
        Me.fg2.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg2.ForeColor = System.Drawing.Color.Black
        Me.fg2.ForeColorFixed = System.Drawing.Color.White
        Me.fg2.ForeColorSel = System.Drawing.Color.Black
        Me.fg2.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.fg2.Location = New System.Drawing.Point(26, 142)
        Me.fg2.Name = "fg2"
        Me.fg2.NodeClosedPicture = Nothing
        Me.fg2.NodeOpenPicture = Nothing
        Me.fg2.OutlineCol = -1
        Me.fg2.Rows = 2
        Me.fg2.SheetBorder = System.Drawing.SystemColors.WindowText
        Me.fg2.Size = New System.Drawing.Size(620, 321)
        Me.fg2.StyleInfo = resources.GetString("fg2.StyleInfo")
        Me.fg2.TabIndex = 4
        Me.fg2.TreeColor = System.Drawing.Color.DarkGray
        '
        'cbTipoAhorro
        '
        Me.cbTipoAhorro.FormattingEnabled = True
        Me.cbTipoAhorro.ItemHeight = 24
        Me.cbTipoAhorro.Location = New System.Drawing.Point(143, 63)
        Me.cbTipoAhorro.Name = "cbTipoAhorro"
        Me.cbTipoAhorro.Size = New System.Drawing.Size(503, 30)
        Me.cbTipoAhorro.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbTipoAhorro.TabIndex = 190
        Me.cbTipoAhorro.UseCustomBackColor = True
        Me.cbTipoAhorro.UseCustomForeColor = True
        Me.cbTipoAhorro.UseSelectable = True
        Me.cbTipoAhorro.UseStyleColors = True
        '
        'frmMsAhListCtasProrrog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(678, 572)
        Me.Controls.Add(Me.fg2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.cbTipoAhorro)
        Me.Controls.Add(Me.Label6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhListCtasProrrog"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Listado de Cuentas de Ahorro Prorrogadas"
        CType(Me.fg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region



    Protected Sub llenarTipoAhorro()
        Dim dts As New DataSet
        dts = ahorro.ConsultarTipoAhorro("CodTipoAhorro,Descripcion", "left(codtipoahorro,1) in ('6','4','5') ", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
        cbTipoAhorro.DisplayMember = "Descripcion"
        cbTipoAhorro.ValueMember = "CodTipoAhorro"
    End Sub



    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            fg2.DataSource = ahorro.ConsultarCuentaAhorro("Dui,NoCuenta,Plazo,TasaInteres,FechaVencimiento", "CodTipoAhorro='" & cbTipoAhorro.SelectedValue & "' and Prorrogado='S'", "Dui,NoCuenta", sUsuario, sPassword, sSucursal).Tables(0)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsAhListCtasProrrog_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenarTipoAhorro()
    End Sub

    Private Sub frmMsAhListCtasProrrog_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
