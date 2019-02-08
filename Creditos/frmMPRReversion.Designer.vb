<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMPRReversion
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
        Me.dgReversiones = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.rbPeriodo = New System.Windows.Forms.RadioButton()
        Me.txtCodReversion = New System.Windows.Forms.TextBox()
        Me.rbCodReversion = New System.Windows.Forms.RadioButton()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.rbCodPrestamo = New System.Windows.Forms.RadioButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        CType(Me.dgReversiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgReversiones
        '
        Me.dgReversiones.AllowUserToAddRows = False
        Me.dgReversiones.AllowUserToDeleteRows = False
        Me.dgReversiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgReversiones.Location = New System.Drawing.Point(23, 226)
        Me.dgReversiones.Name = "dgReversiones"
        Me.dgReversiones.ReadOnly = True
        Me.dgReversiones.Size = New System.Drawing.Size(834, 310)
        Me.dgReversiones.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnMostrar1)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.dtpFechaIni)
        Me.GroupBox1.Controls.Add(Me.rbPeriodo)
        Me.GroupBox1.Controls.Add(Me.txtCodReversion)
        Me.GroupBox1.Controls.Add(Me.rbCodReversion)
        Me.GroupBox1.Controls.Add(Me.txtCodPrestamo)
        Me.GroupBox1.Controls.Add(Me.rbCodPrestamo)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 108)
        Me.GroupBox1.TabIndex = 202
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Busqueda"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(390, 68)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 201
        Me.btnMostrar1.Text = "Buscar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(252, 68)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(123, 20)
        Me.dtpFechaFin.TabIndex = 13
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(123, 68)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(123, 20)
        Me.dtpFechaIni.TabIndex = 12
        '
        'rbPeriodo
        '
        Me.rbPeriodo.AutoSize = True
        Me.rbPeriodo.Location = New System.Drawing.Point(6, 68)
        Me.rbPeriodo.Name = "rbPeriodo"
        Me.rbPeriodo.Size = New System.Drawing.Size(111, 17)
        Me.rbPeriodo.TabIndex = 11
        Me.rbPeriodo.TabStop = True
        Me.rbPeriodo.Text = "Periodo Ejecución"
        Me.rbPeriodo.UseVisualStyleBackColor = True
        '
        'txtCodReversion
        '
        Me.txtCodReversion.Location = New System.Drawing.Point(339, 23)
        Me.txtCodReversion.Name = "txtCodReversion"
        Me.txtCodReversion.Size = New System.Drawing.Size(126, 20)
        Me.txtCodReversion.TabIndex = 10
        '
        'rbCodReversion
        '
        Me.rbCodReversion.AutoSize = True
        Me.rbCodReversion.Location = New System.Drawing.Point(235, 23)
        Me.rbCodReversion.Name = "rbCodReversion"
        Me.rbCodReversion.Size = New System.Drawing.Size(98, 17)
        Me.rbCodReversion.TabIndex = 9
        Me.rbCodReversion.TabStop = True
        Me.rbCodReversion.Text = "Cod. Reversión"
        Me.rbCodReversion.UseVisualStyleBackColor = True
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.Location = New System.Drawing.Point(106, 23)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(123, 20)
        Me.txtCodPrestamo.TabIndex = 8
        '
        'rbCodPrestamo
        '
        Me.rbCodPrestamo.AutoSize = True
        Me.rbCodPrestamo.Location = New System.Drawing.Point(6, 23)
        Me.rbCodPrestamo.Name = "rbCodPrestamo"
        Me.rbCodPrestamo.Size = New System.Drawing.Size(94, 17)
        Me.rbCodPrestamo.TabIndex = 7
        Me.rbCodPrestamo.TabStop = True
        Me.rbCodPrestamo.Text = "Cod. Préstamo"
        Me.rbCodPrestamo.UseVisualStyleBackColor = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(104, 177)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(75, 28)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 204
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(23, 177)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 203
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(185, 177)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 205
        Me.MetroButton1.Text = "Imprimir"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'frmMPRReversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 600)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgReversiones)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(880, 600)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(880, 600)
        Me.Name = "frmMPRReversion"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Aplicaciones Valor Fecha/ Reversiones"
        CType(Me.dgReversiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgReversiones As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbPeriodo As RadioButton
    Friend WithEvents txtCodReversion As TextBox
    Friend WithEvents rbCodReversion As RadioButton
    Friend WithEvents txtCodPrestamo As TextBox
    Friend WithEvents rbCodPrestamo As RadioButton
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents dtpFechaIni As DateTimePicker
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
