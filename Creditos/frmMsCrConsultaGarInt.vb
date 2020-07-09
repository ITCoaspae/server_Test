Public Class frmMsCrConsultaGarInt
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoSolicitud As System.Windows.Forms.TextBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsCrConsultaGarInt))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNoSolicitud = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtNoSolicitud)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtDui)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNoSocio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 108)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtNoSolicitud
        '
        Me.txtNoSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSolicitud.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSolicitud.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSolicitud.Location = New System.Drawing.Point(110, 74)
        Me.txtNoSolicitud.Name = "txtNoSolicitud"
        Me.txtNoSolicitud.ReadOnly = True
        Me.txtNoSolicitud.Size = New System.Drawing.Size(106, 23)
        Me.txtNoSolicitud.TabIndex = 176
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "Nº de Solicitud:"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(110, 14)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.ReadOnly = True
        Me.txtDui.Size = New System.Drawing.Size(135, 23)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNombre.Location = New System.Drawing.Point(110, 44)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(351, 23)
        Me.txtNombre.TabIndex = 171
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(7, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 19)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "Asociado:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(355, 14)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(106, 23)
        Me.txtNoSocio.TabIndex = 169
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(252, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 19)
        Me.Label3.TabIndex = 168
        Me.Label3.Text = "No. Asociado:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "DUI:"
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.fg.ColumnInfo = "3,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.Location = New System.Drawing.Point(28, 188)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(498, 186)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 4
        '
        'frmMsCrConsultaGarInt
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(553, 416)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsCrConsultaGarInt"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consulta de Garantías Internas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private vNoSolicitud As String, vNoSocio As String, vDui As String, vNombre As String

#Region "Propiedades"

    Public Property NoSolicitud() As String
        Get
            Return vNoSolicitud
        End Get
        Set(ByVal Value As String)
            vNoSolicitud = Value
        End Set
    End Property

    Public Property NoSocio() As String
        Get
            Return vNoSocio
        End Get
        Set(ByVal Value As String)
            vNoSocio = Value
        End Set
    End Property

    Public Property Dui() As String
        Get
            Return vDui
        End Get
        Set(ByVal Value As String)
            vDui = Value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return vNombre
        End Get
        Set(ByVal Value As String)
            vNombre = Value
        End Set
    End Property

    Private Sub fg_Click(sender As Object, e As EventArgs) Handles fg.Click

    End Sub

#End Region

    Private Sub frmMsCrConsultaGarInt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtNoSolicitud.Text = vNoSolicitud
        Me.txtNoSocio.Text = vNoSocio
        Me.txtDui.Value = vDui
        Me.txtNombre.Text = vNombre
        Dim oCred As New wrCredito.wsLibCred, ds As New DataSet
        ds = oCred.ConsultarGarantiasInternas("a.Nocuenta,c.Descripcion as Tipo_Ahorro,a.Descripcion,b.Saldo_CuentaAhorro as Saldo,b.MontoPignorado,b.PorcentajePignora as Porcentaje_Pignorado", "a.NumSolicitud ='" & vNoSolicitud & "' and (a.CodTipoGarantia='00002' or a.CodTipoGarantia='00001')", "a.NoCuenta", sUsuario, sPassword, sSucursal)
        Me.fg.DataSource = ds.Tables(0)
        Encabezado()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub Encabezado()

        fg.Cols.Item(0).Width = 85 'No. Cuenta
        fg.Cols.Item(1).Width = 150 'Tipo_Ahorro
        fg.Cols.Item(2).Width = 150 'Descripcion
        fg.Cols.Item(3).Width = 65 'Saldo
        fg.Cols.Item(4).Width = 90 'Monto_Pignorado
        fg.Cols.Item(5).Width = 80 '% Pignoración

        fg.Cols.Item(5).Caption = "% Pignorado"

        Me.fg.Cols.Item(3).Format = "##0.00"
        Me.fg.Cols.Item(4).Format = "##0.00"
        Me.fg.Cols.Item(5).Format = "##0.00"

    End Sub

End Class