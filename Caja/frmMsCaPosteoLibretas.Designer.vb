<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsCaPosteoLibretas
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtHoja = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkQuitarPosteo = New System.Windows.Forms.CheckBox()
        Me.txtTipoAhorro = New System.Windows.Forms.TextBox()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.lblTipoAho = New System.Windows.Forms.Label()
        Me.c1nSaldo = New C1.Win.C1Input.C1NumericEdit()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.txtUltLinea = New System.Windows.Forms.TextBox()
        Me.lblUltLineaImp = New System.Windows.Forms.Label()
        Me.txtCorrLibreta = New System.Windows.Forms.TextBox()
        Me.lblCorrLibreta = New System.Windows.Forms.Label()
        Me.txtNoLibreta = New System.Windows.Forms.TextBox()
        Me.lblNoLibreta = New System.Windows.Forms.Label()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.lblNocuenta = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.lblAsociado = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.lblDui = New System.Windows.Forms.Label()
        Me.btnIniLibreta1 = New MetroFramework.Controls.MetroButton()
        Me.btnPostear1 = New MetroFramework.Controls.MetroButton()
        Me.btnQuitarPosteo1 = New MetroFramework.Controls.MetroButton()
        Me.btnPostLibAnt1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.c1nSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(23, 228)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(561, 161)
        Me.DataGridView1.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtHoja)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.chkQuitarPosteo)
        Me.Panel1.Controls.Add(Me.txtTipoAhorro)
        Me.Panel1.Controls.Add(Me.txtCodTipoAhorro)
        Me.Panel1.Controls.Add(Me.lblTipoAho)
        Me.Panel1.Controls.Add(Me.c1nSaldo)
        Me.Panel1.Controls.Add(Me.lblSaldo)
        Me.Panel1.Controls.Add(Me.txtUltLinea)
        Me.Panel1.Controls.Add(Me.lblUltLineaImp)
        Me.Panel1.Controls.Add(Me.txtCorrLibreta)
        Me.Panel1.Controls.Add(Me.lblCorrLibreta)
        Me.Panel1.Controls.Add(Me.txtNoLibreta)
        Me.Panel1.Controls.Add(Me.lblNoLibreta)
        Me.Panel1.Controls.Add(Me.txtNoCuenta)
        Me.Panel1.Controls.Add(Me.lblNocuenta)
        Me.Panel1.Controls.Add(Me.txtAsociado)
        Me.Panel1.Controls.Add(Me.lblAsociado)
        Me.Panel1.Controls.Add(Me.txtDui)
        Me.Panel1.Controls.Add(Me.lblDui)
        Me.Panel1.Location = New System.Drawing.Point(23, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(558, 125)
        Me.Panel1.TabIndex = 0
        '
        'txtHoja
        '
        Me.txtHoja.BackColor = System.Drawing.Color.White
        Me.txtHoja.Location = New System.Drawing.Point(436, 58)
        Me.txtHoja.Name = "txtHoja"
        Me.txtHoja.ReadOnly = True
        Me.txtHoja.Size = New System.Drawing.Size(109, 20)
        Me.txtHoja.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(363, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "No. de Hoja:"
        '
        'chkQuitarPosteo
        '
        Me.chkQuitarPosteo.AutoSize = True
        Me.chkQuitarPosteo.Location = New System.Drawing.Point(398, 93)
        Me.chkQuitarPosteo.Name = "chkQuitarPosteo"
        Me.chkQuitarPosteo.Size = New System.Drawing.Size(147, 17)
        Me.chkQuitarPosteo.TabIndex = 17
        Me.chkQuitarPosteo.Text = "Quitar Todos los Posteos:"
        Me.chkQuitarPosteo.UseVisualStyleBackColor = True
        '
        'txtTipoAhorro
        '
        Me.txtTipoAhorro.BackColor = System.Drawing.Color.White
        Me.txtTipoAhorro.Location = New System.Drawing.Point(333, 32)
        Me.txtTipoAhorro.Name = "txtTipoAhorro"
        Me.txtTipoAhorro.ReadOnly = True
        Me.txtTipoAhorro.Size = New System.Drawing.Size(211, 20)
        Me.txtTipoAhorro.TabIndex = 8
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.BackColor = System.Drawing.Color.White
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(264, 32)
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.ReadOnly = True
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(63, 20)
        Me.txtCodTipoAhorro.TabIndex = 7
        Me.txtCodTipoAhorro.Visible = False
        '
        'lblTipoAho
        '
        Me.lblTipoAho.AutoSize = True
        Me.lblTipoAho.Location = New System.Drawing.Point(207, 32)
        Me.lblTipoAho.Name = "lblTipoAho"
        Me.lblTipoAho.Size = New System.Drawing.Size(46, 26)
        Me.lblTipoAho.TabIndex = 6
        Me.lblTipoAho.Text = "Tipo de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ahorro:"
        '
        'c1nSaldo
        '
        Me.c1nSaldo.BackColor = System.Drawing.Color.White
        Me.c1nSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSaldo.CustomFormat = "###,###,##0.00"
        Me.c1nSaldo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nSaldo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nSaldo.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nSaldo.Location = New System.Drawing.Point(264, 89)
        Me.c1nSaldo.Name = "c1nSaldo"
        Me.c1nSaldo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSaldo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSaldo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSaldo.ReadOnly = True
        Me.c1nSaldo.Size = New System.Drawing.Size(128, 19)
        Me.c1nSaldo.TabIndex = 16
        Me.c1nSaldo.Tag = Nothing
        Me.c1nSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nSaldo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(207, 97)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(37, 13)
        Me.lblSaldo.TabIndex = 15
        Me.lblSaldo.Text = "Saldo:"
        '
        'txtUltLinea
        '
        Me.txtUltLinea.BackColor = System.Drawing.Color.White
        Me.txtUltLinea.Location = New System.Drawing.Point(73, 89)
        Me.txtUltLinea.Name = "txtUltLinea"
        Me.txtUltLinea.ReadOnly = True
        Me.txtUltLinea.Size = New System.Drawing.Size(128, 20)
        Me.txtUltLinea.TabIndex = 14
        '
        'lblUltLineaImp
        '
        Me.lblUltLineaImp.AutoSize = True
        Me.lblUltLineaImp.Location = New System.Drawing.Point(3, 84)
        Me.lblUltLineaImp.Name = "lblUltLineaImp"
        Me.lblUltLineaImp.Size = New System.Drawing.Size(68, 26)
        Me.lblUltLineaImp.TabIndex = 13
        Me.lblUltLineaImp.Text = "Ultima Linea " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Impresa:"
        '
        'txtCorrLibreta
        '
        Me.txtCorrLibreta.BackColor = System.Drawing.Color.White
        Me.txtCorrLibreta.Location = New System.Drawing.Point(264, 60)
        Me.txtCorrLibreta.Name = "txtCorrLibreta"
        Me.txtCorrLibreta.ReadOnly = True
        Me.txtCorrLibreta.Size = New System.Drawing.Size(93, 20)
        Me.txtCorrLibreta.TabIndex = 12
        '
        'lblCorrLibreta
        '
        Me.lblCorrLibreta.AutoSize = True
        Me.lblCorrLibreta.Location = New System.Drawing.Point(207, 63)
        Me.lblCorrLibreta.Name = "lblCorrLibreta"
        Me.lblCorrLibreta.Size = New System.Drawing.Size(60, 26)
        Me.lblCorrLibreta.TabIndex = 11
        Me.lblCorrLibreta.Text = "Correlativo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Libreta:"
        '
        'txtNoLibreta
        '
        Me.txtNoLibreta.BackColor = System.Drawing.Color.White
        Me.txtNoLibreta.Location = New System.Drawing.Point(73, 58)
        Me.txtNoLibreta.Name = "txtNoLibreta"
        Me.txtNoLibreta.ReadOnly = True
        Me.txtNoLibreta.Size = New System.Drawing.Size(128, 20)
        Me.txtNoLibreta.TabIndex = 10
        '
        'lblNoLibreta
        '
        Me.lblNoLibreta.AutoSize = True
        Me.lblNoLibreta.Location = New System.Drawing.Point(3, 63)
        Me.lblNoLibreta.Name = "lblNoLibreta"
        Me.lblNoLibreta.Size = New System.Drawing.Size(62, 13)
        Me.lblNoLibreta.TabIndex = 9
        Me.lblNoLibreta.Text = "No. Libreta:"
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BackColor = System.Drawing.Color.White
        Me.txtNoCuenta.Location = New System.Drawing.Point(73, 32)
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.Size = New System.Drawing.Size(128, 20)
        Me.txtNoCuenta.TabIndex = 5
        '
        'lblNocuenta
        '
        Me.lblNocuenta.AutoSize = True
        Me.lblNocuenta.Location = New System.Drawing.Point(3, 35)
        Me.lblNocuenta.Name = "lblNocuenta"
        Me.lblNocuenta.Size = New System.Drawing.Size(64, 13)
        Me.lblNocuenta.TabIndex = 4
        Me.lblNocuenta.Text = "No. Cuenta:"
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.Location = New System.Drawing.Point(264, 6)
        Me.txtAsociado.Multiline = True
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(280, 20)
        Me.txtAsociado.TabIndex = 3
        '
        'lblAsociado
        '
        Me.lblAsociado.AutoSize = True
        Me.lblAsociado.Location = New System.Drawing.Point(207, 6)
        Me.lblAsociado.Name = "lblAsociado"
        Me.lblAsociado.Size = New System.Drawing.Size(51, 13)
        Me.lblAsociado.TabIndex = 2
        Me.lblAsociado.Text = "Asociado"
        '
        'txtDui
        '
        Me.txtDui.AcceptsReturn = True
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Enabled = False
        Me.txtDui.Location = New System.Drawing.Point(73, 6)
        Me.txtDui.MaxLength = 20
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(128, 18)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'lblDui
        '
        Me.lblDui.AutoSize = True
        Me.lblDui.Location = New System.Drawing.Point(3, 6)
        Me.lblDui.Name = "lblDui"
        Me.lblDui.Size = New System.Drawing.Size(26, 13)
        Me.lblDui.TabIndex = 0
        Me.lblDui.Text = "Dui:"
        '
        'btnIniLibreta1
        '
        Me.btnIniLibreta1.Location = New System.Drawing.Point(275, 194)
        Me.btnIniLibreta1.Name = "btnIniLibreta1"
        Me.btnIniLibreta1.Size = New System.Drawing.Size(99, 28)
        Me.btnIniLibreta1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnIniLibreta1.TabIndex = 1013
        Me.btnIniLibreta1.Text = "Inicializar Libreta"
        Me.btnIniLibreta1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnIniLibreta1.UseSelectable = True
        Me.btnIniLibreta1.UseStyleColors = True
        '
        'btnPostear1
        '
        Me.btnPostear1.Location = New System.Drawing.Point(380, 194)
        Me.btnPostear1.Name = "btnPostear1"
        Me.btnPostear1.Size = New System.Drawing.Size(99, 28)
        Me.btnPostear1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnPostear1.TabIndex = 1014
        Me.btnPostear1.Text = "Postear Libreta"
        Me.btnPostear1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnPostear1.UseSelectable = True
        Me.btnPostear1.UseStyleColors = True
        '
        'btnQuitarPosteo1
        '
        Me.btnQuitarPosteo1.Location = New System.Drawing.Point(485, 194)
        Me.btnQuitarPosteo1.Name = "btnQuitarPosteo1"
        Me.btnQuitarPosteo1.Size = New System.Drawing.Size(99, 28)
        Me.btnQuitarPosteo1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnQuitarPosteo1.TabIndex = 1015
        Me.btnQuitarPosteo1.Text = "Quitar Posteo"
        Me.btnQuitarPosteo1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnQuitarPosteo1.UseSelectable = True
        Me.btnQuitarPosteo1.UseStyleColors = True
        '
        'btnPostLibAnt1
        '
        Me.btnPostLibAnt1.Location = New System.Drawing.Point(356, 29)
        Me.btnPostLibAnt1.Name = "btnPostLibAnt1"
        Me.btnPostLibAnt1.Size = New System.Drawing.Size(166, 28)
        Me.btnPostLibAnt1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnPostLibAnt1.TabIndex = 1016
        Me.btnPostLibAnt1.Text = "Postear Libreta Anterior"
        Me.btnPostLibAnt1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnPostLibAnt1.UseSelectable = True
        Me.btnPostLibAnt1.UseStyleColors = True
        Me.btnPostLibAnt1.Visible = False
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(140, 194)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(129, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 1017
        Me.MetroButton1.Text = "Cambio de Libreta"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'frmMsCaPosteoLibretas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(607, 459)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnPostLibAnt1)
        Me.Controls.Add(Me.btnQuitarPosteo1)
        Me.Controls.Add(Me.btnPostear1)
        Me.Controls.Add(Me.btnIniLibreta1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsCaPosteoLibretas"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Posteo de Libretas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.c1nSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblDui As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents lblAsociado As System.Windows.Forms.Label
    Friend WithEvents lblNoLibreta As System.Windows.Forms.Label
    Friend WithEvents lblNocuenta As System.Windows.Forms.Label
    Friend WithEvents txtNoLibreta As System.Windows.Forms.TextBox
    Friend WithEvents txtUltLinea As System.Windows.Forms.TextBox
    Friend WithEvents lblUltLineaImp As System.Windows.Forms.Label
    Friend WithEvents txtCorrLibreta As System.Windows.Forms.TextBox
    Friend WithEvents lblCorrLibreta As System.Windows.Forms.Label
    Friend WithEvents lblSaldo As System.Windows.Forms.Label
    Friend WithEvents c1nSaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents lblTipoAho As System.Windows.Forms.Label
    Friend WithEvents txtTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents chkQuitarPosteo As System.Windows.Forms.CheckBox
    Friend WithEvents btnIniLibreta1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPostear1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnQuitarPosteo1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPostLibAnt1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtHoja As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
