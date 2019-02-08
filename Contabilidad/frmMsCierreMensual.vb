Public Class frmMsCierreMensual
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
    Friend WithEvents dtpYear As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAperturar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCerrar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpYear = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAperturar1 = New MetroFramework.Controls.MetroButton()
        Me.btnCerrar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'dtpYear
        '
        Me.dtpYear.CustomFormat = "MMMM/yyyy"
        Me.dtpYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpYear.Location = New System.Drawing.Point(93, 60)
        Me.dtpYear.Name = "dtpYear"
        Me.dtpYear.Size = New System.Drawing.Size(120, 20)
        Me.dtpYear.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Mes / Año:"
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(25, 92)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 33
        Me.btnProcesar1.Text = "Cerrar Mes"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'btnAperturar1
        '
        Me.btnAperturar1.Location = New System.Drawing.Point(109, 92)
        Me.btnAperturar1.Name = "btnAperturar1"
        Me.btnAperturar1.Size = New System.Drawing.Size(104, 28)
        Me.btnAperturar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAperturar1.TabIndex = 34
        Me.btnAperturar1.Text = "Aperturar Mes"
        Me.btnAperturar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAperturar1.UseSelectable = True
        Me.btnAperturar1.UseStyleColors = True
        '
        'btnCerrar1
        '
        Me.btnCerrar1.Location = New System.Drawing.Point(219, 92)
        Me.btnCerrar1.Name = "btnCerrar1"
        Me.btnCerrar1.Size = New System.Drawing.Size(74, 28)
        Me.btnCerrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCerrar1.TabIndex = 35
        Me.btnCerrar1.Text = "Cerrar"
        Me.btnCerrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCerrar1.UseSelectable = True
        Me.btnCerrar1.UseStyleColors = True
        '
        'frmMsCierreMensual
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(311, 143)
        Me.Controls.Add(Me.btnCerrar1)
        Me.Controls.Add(Me.btnAperturar1)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpYear)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(311, 143)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(311, 143)
        Me.Name = "frmMsCierreMensual"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cierre Mensual"
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub frmMsSaldosHistoricos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpYear.Value = Now
    End Sub



    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Dim oContab As New wrConta.wsLibContab, vResultado As String
        Me.Cursor = Cursors.WaitCursor
        vResultado = oContab.CierreMes(Me.dtpYear.Value, True, sUsuario, sPassword, sSucursal)
        If vResultado.Trim <> "" Then
            Me.Cursor = Cursors.Default
            MsgBox(vResultado, MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Validación del Sistema")
        Else
            MsgBox("Proceso realizado con éxito!", MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Validación del Sistema")
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnAperturar1_Click(sender As Object, e As EventArgs) Handles btnAperturar1.Click

        Dim oContab As New wrConta.wsLibContab, vResultado As String
        Me.Cursor = Cursors.WaitCursor
        vResultado = oContab.CierreMes(Me.dtpYear.Value, False, sUsuario, sPassword, sSucursal)
        If vResultado.Trim <> "" Then
            Me.Cursor = Cursors.Default
            MsgBox(vResultado, MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Validación del Sistema")
        Else
            MsgBox("Proceso realizado con éxito!", MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Validación del Sistema")
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnCerrar1_Click(sender As Object, e As EventArgs) Handles btnCerrar1.Click
        Me.Dispose()
    End Sub
End Class