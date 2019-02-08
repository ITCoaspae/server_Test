<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsPlan_Eje_Mercadeo
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
        Me.cbSucursal = New System.Windows.Forms.ComboBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.lblEjecutivo = New System.Windows.Forms.Label()
        Me.cbEjecutivo = New System.Windows.Forms.ComboBox()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.cbRubro = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudAnios = New System.Windows.Forms.NumericUpDown()
        Me.nudMes = New System.Windows.Forms.NumericUpDown()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.nudAnios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbSucursal
        '
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(83, 57)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(329, 21)
        Me.cbSucursal.TabIndex = 2
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(23, 60)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 1
        Me.lblSucursal.Text = "Sucursal:"
        '
        'lblEjecutivo
        '
        Me.lblEjecutivo.AutoSize = True
        Me.lblEjecutivo.Location = New System.Drawing.Point(23, 87)
        Me.lblEjecutivo.Name = "lblEjecutivo"
        Me.lblEjecutivo.Size = New System.Drawing.Size(54, 13)
        Me.lblEjecutivo.TabIndex = 3
        Me.lblEjecutivo.Text = "Ejecutivo:"
        '
        'cbEjecutivo
        '
        Me.cbEjecutivo.FormattingEnabled = True
        Me.cbEjecutivo.Location = New System.Drawing.Point(83, 84)
        Me.cbEjecutivo.Name = "cbEjecutivo"
        Me.cbEjecutivo.Size = New System.Drawing.Size(329, 21)
        Me.cbEjecutivo.TabIndex = 4
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Location = New System.Drawing.Point(23, 140)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(29, 13)
        Me.lblAnio.TabIndex = 7
        Me.lblAnio.Text = "Año:"
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(240, 140)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(30, 13)
        Me.lblMes.TabIndex = 9
        Me.lblMes.Text = "Mes:"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(23, 167)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(40, 13)
        Me.lblMonto.TabIndex = 11
        Me.lblMonto.Text = "Monto:"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(240, 167)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(52, 13)
        Me.lblCantidad.TabIndex = 13
        Me.lblCantidad.Text = "Cantidad:"
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(83, 164)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(98, 20)
        Me.txtMonto.TabIndex = 12
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(298, 164)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(114, 20)
        Me.txtCantidad.TabIndex = 14
        '
        'cbRubro
        '
        Me.cbRubro.FormattingEnabled = True
        Me.cbRubro.Location = New System.Drawing.Point(83, 111)
        Me.cbRubro.Name = "cbRubro"
        Me.cbRubro.Size = New System.Drawing.Size(329, 21)
        Me.cbRubro.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Rubro:"
        '
        'nudAnios
        '
        Me.nudAnios.Location = New System.Drawing.Point(83, 138)
        Me.nudAnios.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudAnios.Minimum = New Decimal(New Integer() {1980, 0, 0, 0})
        Me.nudAnios.Name = "nudAnios"
        Me.nudAnios.Size = New System.Drawing.Size(98, 20)
        Me.nudAnios.TabIndex = 8
        Me.nudAnios.Value = New Decimal(New Integer() {1980, 0, 0, 0})
        '
        'nudMes
        '
        Me.nudMes.Location = New System.Drawing.Point(298, 138)
        Me.nudMes.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudMes.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMes.Name = "nudMes"
        Me.nudMes.Size = New System.Drawing.Size(114, 20)
        Me.nudMes.TabIndex = 10
        Me.nudMes.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(337, 195)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 171
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsPlan_Eje_Mercadeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(435, 254)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.nudMes)
        Me.Controls.Add(Me.nudAnios)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbRubro)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.lblAnio)
        Me.Controls.Add(Me.cbEjecutivo)
        Me.Controls.Add(Me.lblEjecutivo)
        Me.Controls.Add(Me.lblSucursal)
        Me.Controls.Add(Me.cbSucursal)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsPlan_Eje_Mercadeo"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Planificación Ejecutivos de Mercadeo"
        CType(Me.nudAnios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents lblEjecutivo As System.Windows.Forms.Label
    Friend WithEvents cbEjecutivo As System.Windows.Forms.ComboBox
    Friend WithEvents lblAnio As System.Windows.Forms.Label
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents cbRubro As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudAnios As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMes As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
End Class
