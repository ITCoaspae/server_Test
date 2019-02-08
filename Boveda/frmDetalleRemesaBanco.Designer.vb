<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleRemesaBanco
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoComprobante = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecMovRemesar = New System.Windows.Forms.DateTimePicker()
        Me.txtNombreCta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 155)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(305, 59)
        Me.TextBox1.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Observación:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Folio:"
        '
        'txtNoComprobante
        '
        Me.txtNoComprobante.Location = New System.Drawing.Point(137, 79)
        Me.txtNoComprobante.Name = "txtNoComprobante"
        Me.txtNoComprobante.Size = New System.Drawing.Size(305, 20)
        Me.txtNoComprobante.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 26)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "No. Comprobante " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remesa:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(137, 53)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(106, 20)
        Me.txtFolio.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Fecha Remesa:"
        '
        'dtpFecMovRemesar
        '
        Me.dtpFecMovRemesar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecMovRemesar.Location = New System.Drawing.Point(337, 53)
        Me.dtpFecMovRemesar.Name = "dtpFecMovRemesar"
        Me.dtpFecMovRemesar.Size = New System.Drawing.Size(105, 20)
        Me.dtpFecMovRemesar.TabIndex = 15
        '
        'txtNombreCta
        '
        Me.txtNombreCta.Location = New System.Drawing.Point(137, 105)
        Me.txtNombreCta.Multiline = True
        Me.txtNombreCta.Name = "txtNombreCta"
        Me.txtNombreCta.Size = New System.Drawing.Size(305, 44)
        Me.txtNombreCta.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Nombre de Cuenta:"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(367, 220)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 28)
        Me.btnSave.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSave.TabIndex = 180
        Me.btnSave.Text = "Guardar"
        Me.btnSave.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSave.UseSelectable = True
        Me.btnSave.UseStyleColors = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmDetalleRemesaBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(463, 292)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNoComprobante)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtpFecMovRemesar)
        Me.Controls.Add(Me.txtNombreCta)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(463, 292)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(463, 292)
        Me.Name = "frmDetalleRemesaBanco"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Datos Remesa"
        Me.Theme = MetroFramework.MetroThemeStyle.[Default]
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNoComprobante As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFolio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFecMovRemesar As DateTimePicker
    Friend WithEvents txtNombreCta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
