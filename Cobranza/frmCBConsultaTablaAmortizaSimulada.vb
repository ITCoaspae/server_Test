Public Class frmCBConsultaTablaAmortizaSimulada
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents btnImprimir1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCBConsultaTablaAmortizaSimulada))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnImprimir1 = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.Location = New System.Drawing.Point(28, 73)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(466, 231)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 60
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir1.Location = New System.Drawing.Point(404, 311)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(90, 32)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 64
        Me.btnImprimir1.Text = "Imprimir"
        Me.btnImprimir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'frmCBConsultaTablaAmortizaSimulada
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(521, 370)
        Me.Controls.Add(Me.btnImprimir1)
        Me.Controls.Add(Me.fg)
        Me.MaximizeBox = False
        Me.Name = "frmCBConsultaTablaAmortizaSimulada"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Tabla de Amortizaci�n Simulada"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ds As New System.Data.DataSet
    Private vCodPrestamo As String

    Public Property Datos() As System.Data.DataSet
        Get
            Return ds
        End Get
        Set(ByVal Value As System.Data.DataSet)
            ds = Value
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

    Private Sub frmCBConsultaTablaAmortizaSimulada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fg.DataSource = ds.Tables(0)
    End Sub



    Private Sub btnImprimir1_Click(sender As Object, e As EventArgs) Handles btnImprimir1.Click
        Dim dsR As New DataSet, oAhorro As New wrAhorro.wsLibAhorro
        Dim dr As DataRow
        Try
            'dsR = oAhorro.TablaAmortizacion(vCodPrestamo, sUsuario, sPassword,sSucursal)
            Dim ofrm As New frmVisor(ds, 39, 0)
            ofrm.Show()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
