<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetAsocTransferenciasAutomaticas
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtDui = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lblAsociado = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.cbOrigen = New MetroFramework.Controls.MetroComboBox()
        Me.cbDestino = New MetroFramework.Controls.MetroComboBox()
        Me.txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.lblMonto = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFechaTran = New MetroFramework.Controls.MetroDateTime()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.chkActivo = New MetroFramework.Controls.MetroCheckBox()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDui
        '
        Me.txtDui.Lines = New String() {"MetroTextBox1"}
        Me.txtDui.Location = New System.Drawing.Point(23, 83)
        Me.txtDui.MaxLength = 32767
        Me.txtDui.Name = "txtDui"
        Me.txtDui.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDui.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDui.SelectedText = ""
        Me.txtDui.Size = New System.Drawing.Size(406, 23)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Text = "MetroTextBox1"
        Me.txtDui.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(35, 20)
        Me.MetroLabel1.TabIndex = 1
        Me.MetroLabel1.Text = "DUI:"
        '
        'lblAsociado
        '
        Me.lblAsociado.AutoSize = True
        Me.lblAsociado.Location = New System.Drawing.Point(23, 109)
        Me.lblAsociado.Name = "lblAsociado"
        Me.lblAsociado.Size = New System.Drawing.Size(65, 20)
        Me.lblAsociado.TabIndex = 2
        Me.lblAsociado.Text = "Asociado"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 129)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(55, 20)
        Me.MetroLabel3.TabIndex = 3
        Me.MetroLabel3.Text = "Origen:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 185)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(59, 20)
        Me.MetroLabel4.TabIndex = 4
        Me.MetroLabel4.Text = "Destino:"
        '
        'cbOrigen
        '
        Me.cbOrigen.FormattingEnabled = True
        Me.cbOrigen.ItemHeight = 24
        Me.cbOrigen.Location = New System.Drawing.Point(23, 152)
        Me.cbOrigen.Name = "cbOrigen"
        Me.cbOrigen.Size = New System.Drawing.Size(406, 30)
        Me.cbOrigen.TabIndex = 5
        Me.cbOrigen.UseSelectable = True
        '
        'cbDestino
        '
        Me.cbDestino.FormattingEnabled = True
        Me.cbDestino.ItemHeight = 24
        Me.cbDestino.Location = New System.Drawing.Point(23, 208)
        Me.cbDestino.Name = "cbDestino"
        Me.cbDestino.Size = New System.Drawing.Size(406, 30)
        Me.cbDestino.TabIndex = 6
        Me.cbDestino.UseSelectable = True
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.CustomFormat = "###,###,##0.00"
        Me.txtMonto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtMonto.Location = New System.Drawing.Point(23, 264)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMonto.Size = New System.Drawing.Size(406, 21)
        Me.txtMonto.TabIndex = 7
        Me.txtMonto.Tag = Nothing
        Me.txtMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(23, 241)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(52, 20)
        Me.lblMonto.TabIndex = 9
        Me.lblMonto.Text = "Monto:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 288)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(135, 20)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Fecha Transferencia:"
        '
        'dtpFechaTran
        '
        Me.dtpFechaTran.Location = New System.Drawing.Point(23, 311)
        Me.dtpFechaTran.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaTran.Name = "dtpFechaTran"
        Me.dtpFechaTran.Size = New System.Drawing.Size(406, 30)
        Me.dtpFechaTran.TabIndex = 11
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(339, 363)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(90, 33)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 50
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(23, 363)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(59, 17)
        Me.chkActivo.TabIndex = 51
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseSelectable = True
        '
        'frmDetAsocTransferenciasAutomaticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 485)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.dtpFechaTran)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.cbDestino)
        Me.Controls.Add(Me.cbOrigen)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.lblAsociado)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtDui)
        Me.Name = "frmDetAsocTransferenciasAutomaticas"
        Me.Text = "Transferencia Automatica"
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDui As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAsociado As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbOrigen As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cbDestino As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblMonto As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFechaTran As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents chkActivo As MetroFramework.Controls.MetroCheckBox
End Class
