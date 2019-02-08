<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsPLDiasTrabajados
    Inherits MetroFramework.Forms.MetroForm

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
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.cbEMPLEADOS = New System.Windows.Forms.CheckBox()
        Me.txtDIAS = New System.Windows.Forms.TextBox()
        Me.lblTOTALDIAS = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblFECHAF = New System.Windows.Forms.Label()
        Me.lblFECHAI = New System.Windows.Forms.Label()
        Me.txtNOMBREEMPLEADO = New System.Windows.Forms.TextBox()
        Me.txtCODEMPLEADO = New System.Windows.Forms.TextBox()
        Me.lblCODEMPLEADO = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(351, 135)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 127
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'cbEMPLEADOS
        '
        Me.cbEMPLEADOS.AutoSize = True
        Me.cbEMPLEADOS.Location = New System.Drawing.Point(23, 63)
        Me.cbEMPLEADOS.Name = "cbEMPLEADOS"
        Me.cbEMPLEADOS.Size = New System.Drawing.Size(126, 17)
        Me.cbEMPLEADOS.TabIndex = 12
        Me.cbEMPLEADOS.Text = "Todos los empleados"
        Me.cbEMPLEADOS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbEMPLEADOS.UseVisualStyleBackColor = True
        '
        'txtDIAS
        '
        Me.txtDIAS.Location = New System.Drawing.Point(112, 135)
        Me.txtDIAS.MaxLength = 2
        Me.txtDIAS.Name = "txtDIAS"
        Me.txtDIAS.Size = New System.Drawing.Size(45, 20)
        Me.txtDIAS.TabIndex = 8
        '
        'lblTOTALDIAS
        '
        Me.lblTOTALDIAS.AutoSize = True
        Me.lblTOTALDIAS.Location = New System.Drawing.Point(20, 135)
        Me.lblTOTALDIAS.Name = "lblTOTALDIAS"
        Me.lblTOTALDIAS.Size = New System.Drawing.Size(86, 13)
        Me.lblTOTALDIAS.TabIndex = 7
        Me.lblTOTALDIAS.Text = "Días Trabajados"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(318, 109)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(108, 20)
        Me.DateTimePicker2.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(112, 109)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(108, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'lblFECHAF
        '
        Me.lblFECHAF.AutoSize = True
        Me.lblFECHAF.Location = New System.Drawing.Point(258, 109)
        Me.lblFECHAF.Name = "lblFECHAF"
        Me.lblFECHAF.Size = New System.Drawing.Size(54, 13)
        Me.lblFECHAF.TabIndex = 4
        Me.lblFECHAF.Text = "Fecha Fin"
        '
        'lblFECHAI
        '
        Me.lblFECHAI.AutoSize = True
        Me.lblFECHAI.Location = New System.Drawing.Point(20, 109)
        Me.lblFECHAI.Name = "lblFECHAI"
        Me.lblFECHAI.Size = New System.Drawing.Size(65, 13)
        Me.lblFECHAI.TabIndex = 3
        Me.lblFECHAI.Text = "Fecha Inicio"
        '
        'txtNOMBREEMPLEADO
        '
        Me.txtNOMBREEMPLEADO.Enabled = False
        Me.txtNOMBREEMPLEADO.Location = New System.Drawing.Point(184, 83)
        Me.txtNOMBREEMPLEADO.Name = "txtNOMBREEMPLEADO"
        Me.txtNOMBREEMPLEADO.Size = New System.Drawing.Size(242, 20)
        Me.txtNOMBREEMPLEADO.TabIndex = 2
        '
        'txtCODEMPLEADO
        '
        Me.txtCODEMPLEADO.Location = New System.Drawing.Point(112, 83)
        Me.txtCODEMPLEADO.Name = "txtCODEMPLEADO"
        Me.txtCODEMPLEADO.Size = New System.Drawing.Size(66, 20)
        Me.txtCODEMPLEADO.TabIndex = 1
        '
        'lblCODEMPLEADO
        '
        Me.lblCODEMPLEADO.AutoSize = True
        Me.lblCODEMPLEADO.Location = New System.Drawing.Point(20, 86)
        Me.lblCODEMPLEADO.Name = "lblCODEMPLEADO"
        Me.lblCODEMPLEADO.Size = New System.Drawing.Size(57, 13)
        Me.lblCODEMPLEADO.TabIndex = 0
        Me.lblCODEMPLEADO.Text = "Empleado:"
        '
        'frmMsPLDiasTrabajados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(454, 216)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.cbEMPLEADOS)
        Me.Controls.Add(Me.txtDIAS)
        Me.Controls.Add(Me.lblCODEMPLEADO)
        Me.Controls.Add(Me.lblTOTALDIAS)
        Me.Controls.Add(Me.txtCODEMPLEADO)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.txtNOMBREEMPLEADO)
        Me.Controls.Add(Me.lblFECHAF)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblFECHAI)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(454, 216)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(454, 216)
        Me.Name = "frmMsPLDiasTrabajados"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Días Trabajados"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFECHAF As System.Windows.Forms.Label
    Friend WithEvents lblFECHAI As System.Windows.Forms.Label
    Friend WithEvents txtNOMBREEMPLEADO As System.Windows.Forms.TextBox
    Friend WithEvents txtCODEMPLEADO As System.Windows.Forms.TextBox
    Friend WithEvents lblCODEMPLEADO As System.Windows.Forms.Label
    Friend WithEvents txtDIAS As System.Windows.Forms.TextBox
    Friend WithEvents lblTOTALDIAS As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbEMPLEADOS As System.Windows.Forms.CheckBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
End Class
