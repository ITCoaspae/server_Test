<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class estadoCuentaCxC
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtDui = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.cbOrigen = New System.Windows.Forms.ComboBox()
        Me.cb = New System.Windows.Forms.ComboBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 89)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(35, 20)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "DUI:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 119)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(64, 20)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Nombre:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 145)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(79, 20)
        Me.MetroLabel3.TabIndex = 2
        Me.MetroLabel3.Text = "Cta. Origén"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 175)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(150, 20)
        Me.MetroLabel4.TabIndex = 3
        Me.MetroLabel4.Text = "No. cuenta por cobrar:"
        '
        'txtDui
        '
        Me.txtDui.Location = New System.Drawing.Point(179, 89)
        Me.txtDui.Mask = "00000000-0"
        Me.txtDui.Name = "txtDui"
        Me.txtDui.Size = New System.Drawing.Size(304, 22)
        Me.txtDui.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(179, 117)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(304, 22)
        Me.txtNombre.TabIndex = 5
        '
        'cbOrigen
        '
        Me.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOrigen.FormattingEnabled = True
        Me.cbOrigen.Location = New System.Drawing.Point(179, 145)
        Me.cbOrigen.Name = "cbOrigen"
        Me.cbOrigen.Size = New System.Drawing.Size(304, 24)
        Me.cbOrigen.TabIndex = 6
        '
        'cb
        '
        Me.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb.FormattingEnabled = True
        Me.cb.Location = New System.Drawing.Point(179, 175)
        Me.cb.Name = "cb"
        Me.cb.Size = New System.Drawing.Size(304, 24)
        Me.cb.TabIndex = 7
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(393, 233)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 33)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 15
        Me.btnGuardar1.Text = "Procesar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 205)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(49, 20)
        Me.MetroLabel5.TabIndex = 16
        Me.MetroLabel5.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(179, 205)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(303, 22)
        Me.DateTimePicker1.TabIndex = 17
        '
        'estadoCuentaCxC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 318)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.cb)
        Me.Controls.Add(Me.cbOrigen)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "estadoCuentaCxC"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "estadoCuentaCxC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDui As MaskedTextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents cbOrigen As ComboBox
    Friend WithEvents cb As ComboBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
