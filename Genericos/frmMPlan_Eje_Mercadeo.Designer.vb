<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMPlan_Eje_Mercadeo
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
        Me.dgPlanificacion = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.lblAnio = New System.Windows.Forms.Label()
        Me.lblEjecutivo = New System.Windows.Forms.Label()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.cbSucursal = New System.Windows.Forms.ComboBox()
        Me.chkSucursal = New System.Windows.Forms.CheckBox()
        Me.nudMes = New System.Windows.Forms.NumericUpDown()
        Me.nudAnios = New System.Windows.Forms.NumericUpDown()
        Me.cbEjecutivos = New System.Windows.Forms.ComboBox()
        Me.chkEjecutivo = New System.Windows.Forms.CheckBox()
        Me.chkAnio = New System.Windows.Forms.CheckBox()
        Me.chkMes = New System.Windows.Forms.CheckBox()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        CType(Me.dgPlanificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudMes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAnios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgPlanificacion
        '
        Me.dgPlanificacion.AllowUserToAddRows = False
        Me.dgPlanificacion.AllowUserToDeleteRows = False
        Me.dgPlanificacion.AllowUserToOrderColumns = True
        Me.dgPlanificacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgPlanificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPlanificacion.Location = New System.Drawing.Point(23, 268)
        Me.dgPlanificacion.Name = "dgPlanificacion"
        Me.dgPlanificacion.ReadOnly = True
        Me.dgPlanificacion.Size = New System.Drawing.Size(567, 136)
        Me.dgPlanificacion.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.lblMes)
        Me.GroupBox2.Controls.Add(Me.lblAnio)
        Me.GroupBox2.Controls.Add(Me.lblEjecutivo)
        Me.GroupBox2.Controls.Add(Me.lblSucursal)
        Me.GroupBox2.Controls.Add(Me.cbSucursal)
        Me.GroupBox2.Controls.Add(Me.chkSucursal)
        Me.GroupBox2.Controls.Add(Me.nudMes)
        Me.GroupBox2.Controls.Add(Me.nudAnios)
        Me.GroupBox2.Controls.Add(Me.cbEjecutivos)
        Me.GroupBox2.Controls.Add(Me.chkEjecutivo)
        Me.GroupBox2.Controls.Add(Me.chkAnio)
        Me.GroupBox2.Controls.Add(Me.chkMes)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(567, 165)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtros"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(486, 126)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 86
        Me.MetroButton1.Text = "Buscar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(240, 48)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(30, 13)
        Me.lblMes.TabIndex = 26
        Me.lblMes.Text = "Mes:"
        '
        'lblAnio
        '
        Me.lblAnio.AutoSize = True
        Me.lblAnio.Location = New System.Drawing.Point(6, 43)
        Me.lblAnio.Name = "lblAnio"
        Me.lblAnio.Size = New System.Drawing.Size(29, 13)
        Me.lblAnio.TabIndex = 25
        Me.lblAnio.Text = "Año:"
        '
        'lblEjecutivo
        '
        Me.lblEjecutivo.AutoSize = True
        Me.lblEjecutivo.Location = New System.Drawing.Point(6, 102)
        Me.lblEjecutivo.Name = "lblEjecutivo"
        Me.lblEjecutivo.Size = New System.Drawing.Size(54, 13)
        Me.lblEjecutivo.TabIndex = 24
        Me.lblEjecutivo.Text = "Ejecutivo:"
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(6, 75)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 23
        Me.lblSucursal.Text = "Sucursal:"
        '
        'cbSucursal
        '
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(66, 72)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(495, 21)
        Me.cbSucursal.TabIndex = 22
        '
        'chkSucursal
        '
        Me.chkSucursal.AutoSize = True
        Me.chkSucursal.Location = New System.Drawing.Point(109, 19)
        Me.chkSucursal.Name = "chkSucursal"
        Me.chkSucursal.Size = New System.Drawing.Size(67, 17)
        Me.chkSucursal.TabIndex = 21
        Me.chkSucursal.Text = "Sucursal"
        Me.chkSucursal.UseVisualStyleBackColor = True
        '
        'nudMes
        '
        Me.nudMes.Location = New System.Drawing.Point(276, 46)
        Me.nudMes.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.nudMes.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMes.Name = "nudMes"
        Me.nudMes.Size = New System.Drawing.Size(86, 20)
        Me.nudMes.TabIndex = 20
        Me.nudMes.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'nudAnios
        '
        Me.nudAnios.Location = New System.Drawing.Point(70, 46)
        Me.nudAnios.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.nudAnios.Minimum = New Decimal(New Integer() {1980, 0, 0, 0})
        Me.nudAnios.Name = "nudAnios"
        Me.nudAnios.Size = New System.Drawing.Size(86, 20)
        Me.nudAnios.TabIndex = 19
        Me.nudAnios.Value = New Decimal(New Integer() {1980, 0, 0, 0})
        '
        'cbEjecutivos
        '
        Me.cbEjecutivos.FormattingEnabled = True
        Me.cbEjecutivos.Location = New System.Drawing.Point(66, 99)
        Me.cbEjecutivos.Name = "cbEjecutivos"
        Me.cbEjecutivos.Size = New System.Drawing.Size(495, 21)
        Me.cbEjecutivos.TabIndex = 7
        '
        'chkEjecutivo
        '
        Me.chkEjecutivo.AutoSize = True
        Me.chkEjecutivo.Location = New System.Drawing.Point(182, 19)
        Me.chkEjecutivo.Name = "chkEjecutivo"
        Me.chkEjecutivo.Size = New System.Drawing.Size(70, 17)
        Me.chkEjecutivo.TabIndex = 6
        Me.chkEjecutivo.Text = "Ejecutivo"
        Me.chkEjecutivo.UseVisualStyleBackColor = True
        '
        'chkAnio
        '
        Me.chkAnio.AutoSize = True
        Me.chkAnio.Location = New System.Drawing.Point(6, 19)
        Me.chkAnio.Name = "chkAnio"
        Me.chkAnio.Size = New System.Drawing.Size(45, 17)
        Me.chkAnio.TabIndex = 4
        Me.chkAnio.Text = "Año"
        Me.chkAnio.UseVisualStyleBackColor = True
        '
        'chkMes
        '
        Me.chkMes.AutoSize = True
        Me.chkMes.Location = New System.Drawing.Point(57, 19)
        Me.chkMes.Name = "chkMes"
        Me.chkMes.Size = New System.Drawing.Size(46, 17)
        Me.chkMes.TabIndex = 5
        Me.chkMes.Text = "Mes"
        Me.chkMes.UseVisualStyleBackColor = True
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 234)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 90
        Me.btnImp.Text = "Reporte"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 234)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 89
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 234)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 88
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 234)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 87
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'frmMPlan_Eje_Mercadeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(613, 452)
        Me.Controls.Add(Me.dgPlanificacion)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmMPlan_Eje_Mercadeo"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Planificación Mensual "
        CType(Me.dgPlanificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudMes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAnios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgPlanificacion As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkEjecutivo As System.Windows.Forms.CheckBox
    Friend WithEvents chkAnio As System.Windows.Forms.CheckBox
    Friend WithEvents chkMes As System.Windows.Forms.CheckBox
    Friend WithEvents cbEjecutivos As System.Windows.Forms.ComboBox
    Friend WithEvents nudMes As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudAnios As System.Windows.Forms.NumericUpDown
    Friend WithEvents chkSucursal As System.Windows.Forms.CheckBox
    Friend WithEvents cbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents lblAnio As System.Windows.Forms.Label
    Friend WithEvents lblEjecutivo As System.Windows.Forms.Label
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
End Class
