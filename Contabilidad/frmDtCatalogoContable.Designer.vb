<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDtCatalogoContable
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodCta = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCtaDependencia = New System.Windows.Forms.TextBox()
        Me.cbTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.txtNivel = New System.Windows.Forms.NumericUpDown()
        Me.chkFinal = New System.Windows.Forms.CheckBox()
        Me.chkLegal = New System.Windows.Forms.CheckBox()
        Me.chkInhabilitada = New System.Windows.Forms.CheckBox()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.C1SuperErrorProvider1 = New C1.Win.C1SuperTooltip.C1SuperErrorProvider(Me.components)
        Me.C1SuperTooltip1 = New C1.Win.C1SuperTooltip.C1SuperTooltip(Me.components)
        Me.C1SuperErrorProvider2 = New C1.Win.C1SuperTooltip.C1SuperErrorProvider(Me.components)
        CType(Me.txtNivel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1SuperErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1SuperErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo de cuenta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre de cuenta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nivel Contable"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo de cuenta:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Cuenta padre:"
        '
        'txtCodCta
        '
        Me.txtCodCta.Location = New System.Drawing.Point(127, 97)
        Me.txtCodCta.Name = "txtCodCta"
        Me.txtCodCta.Size = New System.Drawing.Size(373, 20)
        Me.txtCodCta.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(127, 123)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(373, 20)
        Me.txtNombre.TabIndex = 5
        '
        'txtCtaDependencia
        '
        Me.txtCtaDependencia.Location = New System.Drawing.Point(127, 71)
        Me.txtCtaDependencia.Name = "txtCtaDependencia"
        Me.txtCtaDependencia.Size = New System.Drawing.Size(373, 20)
        Me.txtCtaDependencia.TabIndex = 1
        '
        'cbTipoCuenta
        '
        Me.cbTipoCuenta.FormattingEnabled = True
        Me.cbTipoCuenta.Location = New System.Drawing.Point(127, 149)
        Me.cbTipoCuenta.Name = "cbTipoCuenta"
        Me.cbTipoCuenta.Size = New System.Drawing.Size(373, 21)
        Me.cbTipoCuenta.TabIndex = 7
        '
        'txtNivel
        '
        Me.txtNivel.Location = New System.Drawing.Point(127, 176)
        Me.txtNivel.Name = "txtNivel"
        Me.txtNivel.Size = New System.Drawing.Size(96, 20)
        Me.txtNivel.TabIndex = 9
        '
        'chkFinal
        '
        Me.chkFinal.AutoSize = True
        Me.chkFinal.Location = New System.Drawing.Point(26, 202)
        Me.chkFinal.Name = "chkFinal"
        Me.chkFinal.Size = New System.Drawing.Size(96, 17)
        Me.chkFinal.TabIndex = 10
        Me.chkFinal.Text = "Es cuenta final"
        Me.chkFinal.UseVisualStyleBackColor = True
        '
        'chkLegal
        '
        Me.chkLegal.AutoSize = True
        Me.chkLegal.Location = New System.Drawing.Point(127, 202)
        Me.chkLegal.Name = "chkLegal"
        Me.chkLegal.Size = New System.Drawing.Size(99, 17)
        Me.chkLegal.TabIndex = 11
        Me.chkLegal.Text = "Es cuenta legal"
        Me.chkLegal.UseVisualStyleBackColor = True
        '
        'chkInhabilitada
        '
        Me.chkInhabilitada.AutoSize = True
        Me.chkInhabilitada.Location = New System.Drawing.Point(232, 202)
        Me.chkInhabilitada.Name = "chkInhabilitada"
        Me.chkInhabilitada.Size = New System.Drawing.Size(80, 17)
        Me.chkInhabilitada.TabIndex = 12
        Me.chkInhabilitada.Text = "Inhabilitada"
        Me.chkInhabilitada.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(427, 225)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(73, 28)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 13
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'C1SuperErrorProvider1
        '
        Me.C1SuperErrorProvider1.ContainerControl = Me
        Me.C1SuperErrorProvider1.ToolTip = Me.C1SuperTooltip1
        '
        'C1SuperTooltip1
        '
        Me.C1SuperTooltip1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        '
        'C1SuperErrorProvider2
        '
        Me.C1SuperErrorProvider2.ContainerControl = Me
        Me.C1SuperErrorProvider2.ToolTip = Me.C1SuperTooltip1
        '
        'frmDtCatalogoContable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(526, 308)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.chkInhabilitada)
        Me.Controls.Add(Me.chkLegal)
        Me.Controls.Add(Me.chkFinal)
        Me.Controls.Add(Me.txtNivel)
        Me.Controls.Add(Me.cbTipoCuenta)
        Me.Controls.Add(Me.txtCtaDependencia)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCodCta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(526, 308)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(526, 308)
        Me.Name = "frmDtCatalogoContable"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Catalogo Contable"
        CType(Me.txtNivel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1SuperErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1SuperErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodCta As TextBox
    Friend WithEvents txtCtaDependencia As TextBox
    Friend WithEvents chkFinal As CheckBox
    Friend WithEvents txtNivel As NumericUpDown
    Friend WithEvents cbTipoCuenta As ComboBox
    Friend WithEvents chkLegal As CheckBox
    Friend WithEvents chkInhabilitada As CheckBox
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents C1SuperErrorProvider1 As C1.Win.C1SuperTooltip.C1SuperErrorProvider
    Friend WithEvents C1SuperTooltip1 As C1.Win.C1SuperTooltip.C1SuperTooltip
    Friend WithEvents C1SuperErrorProvider2 As C1.Win.C1SuperTooltip.C1SuperErrorProvider
End Class
