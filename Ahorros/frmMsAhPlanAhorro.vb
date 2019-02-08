Public Class frmMsAhPlanAhorro
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtTipoAhorro As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsAhPlanAhorro))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.txtTipoAhorro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNoCuenta)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCodTipoAhorro)
        Me.GroupBox1.Controls.Add(Me.txtTipoAhorro)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(511, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuenta.Enabled = False
        Me.txtNoCuenta.Location = New System.Drawing.Point(104, 50)
        Me.txtNoCuenta.MaxLength = 20
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.ReadOnly = True
        Me.txtNoCuenta.Size = New System.Drawing.Size(184, 20)
        Me.txtNoCuenta.TabIndex = 132
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 16)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "No. Cuenta:"
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoAhorro.Enabled = False
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(104, 24)
        Me.txtCodTipoAhorro.MaxLength = 10
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.ReadOnly = True
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(64, 20)
        Me.txtCodTipoAhorro.TabIndex = 7
        '
        'txtTipoAhorro
        '
        Me.txtTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoAhorro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoAhorro.Location = New System.Drawing.Point(176, 24)
        Me.txtTipoAhorro.MaxLength = 110
        Me.txtTipoAhorro.Name = "txtTipoAhorro"
        Me.txtTipoAhorro.ReadOnly = True
        Me.txtTipoAhorro.Size = New System.Drawing.Size(324, 20)
        Me.txtTipoAhorro.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo de Ahorro:"
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "2,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(23, 157)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Size = New System.Drawing.Size(508, 172)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 4
        '
        'frmMsAhPlanAhorro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(554, 352)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fg)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhPlanAhorro"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Plan de Ahorro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private vCodAhorro As String, vAhorro As String, vNoCuenta As String, vMontoApertura As Double, vTasa As Double, vMonto As Double, vNoCuotas As Double, vFecha As Date
    Private vPlan As DataSet, vFechaCuota As Date, frm As frmMsAhCuentas

#Region "Propiedades"

    Public Property FrmCtas() As frmMsAhCuentas
        Get
            Return frm
        End Get
        Set(ByVal Value As frmMsAhCuentas)
            frm = Value
        End Set
    End Property

    Public Property NoCuotas() As Double
        Get
            Return vNoCuotas
        End Get
        Set(ByVal Value As Double)
            vNoCuotas = Value
        End Set
    End Property

    Public Property Fecha() As Date
        Get
            Return vFecha
        End Get
        Set(ByVal Value As Date)
            vFecha = Value
        End Set
    End Property

    Public Property Monto() As Double
        Get
            Return vMonto
        End Get
        Set(ByVal Value As Double)
            vMonto = Value
        End Set
    End Property

    Public Property TasaInteres() As Double
        Get
            Return vTasa
        End Get
        Set(ByVal Value As Double)
            vTasa = Value
        End Set
    End Property

    Public Property MontoApertura() As Double
        Get
            Return vMontoApertura
        End Get
        Set(ByVal Value As Double)
            vMontoApertura = Value
        End Set
    End Property

    Public Property Cuenta() As String
        Get
            Return vNoCuenta
        End Get
        Set(ByVal Value As String)
            vNoCuenta = Value
        End Set
    End Property

    Public Property Ahorro() As String
        Get
            Return vAhorro
        End Get
        Set(ByVal Value As String)
            vAhorro = Value
        End Set
    End Property

    Public Property CodAhorro() As String
        Get
            Return vCodAhorro
        End Get
        Set(ByVal Value As String)
            vCodAhorro = Value
        End Set
    End Property

    Public Property Plan() As System.Data.DataSet
        Get
            Return vPlan
        End Get
        Set(ByVal Value As System.Data.DataSet)
            vPlan = Value
        End Set
    End Property

#End Region

    Private Sub frmMsAhPlanAhorro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, dr As DataRow, dv As New DataView

        Me.txtCodTipoAhorro.Text = vCodAhorro
        Me.txtTipoAhorro.Text = vAhorro
        Me.txtNoCuenta.Text = vNoCuenta
        Try
            vPlan = oAhorro.PlanAhorro(vMontoApertura, vTasa, vMonto, vNoCuotas, vFecha, Me.txtCodTipoAhorro.Text.Trim, sUsuario, sPassword,sSucursal)
            Me.fg.DataSource = vPlan.Tables(0)
            dv = New DataView(vPlan.Tables(0))
            dv.Sort = "FechaPago desc"
            If dv.Count > 0 Then
                frm.c1nMonto.Value = dv.Item(0)("Saldo")
                frm.dtpFecVenc.Value = dv.Item(0)("FechaPago")
            End If
            Me.fg.DataSource = vPlan.Tables(0)
            Encabezado()
        Catch ex As Exception
        End Try

    End Sub


    Private Sub Encabezado()

        fg.Cols.Item(0).Caption = "No. Cuota"
        fg.Cols.Item(1).Caption = "Fecha de Pago"
        fg.Cols.Item(2).Caption = "Monto Cuota"
        fg.Cols.Item(3).Caption = "Interés"
        fg.Cols.Item(4).Caption = "Saldo"
        fg.Cols.Item(0).Width = 77
        fg.Cols.Item(1).Width = 100
        fg.Cols.Item(2).Width = 100
        fg.Cols.Item(3).Width = 90
        fg.Cols.Item(4).Width = 100

    End Sub

End Class