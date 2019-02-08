<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsIngresoComisionMerca
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
        Me.lblOpcion = New System.Windows.Forms.Label()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.chkTipoComision = New System.Windows.Forms.CheckBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.dgComisiones = New System.Windows.Forms.DataGridView()
        Me.gbPeriodoCancelar = New System.Windows.Forms.GroupBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.dtpFechaF = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaI = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbFiltros.SuspendLayout()
        CType(Me.dgComisiones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPeriodoCancelar.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOpcion
        '
        Me.lblOpcion.AutoSize = True
        Me.lblOpcion.Location = New System.Drawing.Point(640, 138)
        Me.lblOpcion.Name = "lblOpcion"
        Me.lblOpcion.Size = New System.Drawing.Size(22, 13)
        Me.lblOpcion.TabIndex = 1
        Me.lblOpcion.Text = "ttttt"
        Me.lblOpcion.Visible = False
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.MetroButton1)
        Me.gbFiltros.Controls.Add(Me.btnMostrar1)
        Me.gbFiltros.Controls.Add(Me.chkTipoComision)
        Me.gbFiltros.Controls.Add(Me.dtpFechaFin)
        Me.gbFiltros.Controls.Add(Me.lblFechaFin)
        Me.gbFiltros.Controls.Add(Me.dtpFechaInicio)
        Me.gbFiltros.Controls.Add(Me.lblFechaInicio)
        Me.gbFiltros.Location = New System.Drawing.Point(23, 63)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(555, 73)
        Me.gbFiltros.TabIndex = 3
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Periodo a evaluar"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(441, 37)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(101, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 113
        Me.MetroButton1.Text = "Exportar a Excel"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(360, 37)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 112
        Me.btnMostrar1.Text = "Calcular"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'chkTipoComision
        '
        Me.chkTipoComision.AutoSize = True
        Me.chkTipoComision.Location = New System.Drawing.Point(6, 16)
        Me.chkTipoComision.Name = "chkTipoComision"
        Me.chkTipoComision.Size = New System.Drawing.Size(179, 17)
        Me.chkTipoComision.TabIndex = 5
        Me.chkTipoComision.Text = "Comisiones Créditos Gerenciales"
        Me.chkTipoComision.UseVisualStyleBackColor = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(248, 45)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(102, 20)
        Me.dtpFechaFin.TabIndex = 3
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(188, 49)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(54, 13)
        Me.lblFechaFin.TabIndex = 2
        Me.lblFechaFin.Text = "Fecha Fin"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(80, 45)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(102, 20)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(6, 49)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(68, 13)
        Me.lblFechaInicio.TabIndex = 0
        Me.lblFechaInicio.Text = "Fecha Inicio:"
        '
        'dgComisiones
        '
        Me.dgComisiones.AllowUserToAddRows = False
        Me.dgComisiones.AllowUserToDeleteRows = False
        Me.dgComisiones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgComisiones.Location = New System.Drawing.Point(23, 195)
        Me.dgComisiones.Name = "dgComisiones"
        Me.dgComisiones.ReadOnly = True
        Me.dgComisiones.Size = New System.Drawing.Size(556, 240)
        Me.dgComisiones.TabIndex = 4
        '
        'gbPeriodoCancelar
        '
        Me.gbPeriodoCancelar.Controls.Add(Me.btnGuardar1)
        Me.gbPeriodoCancelar.Controls.Add(Me.dtpFechaF)
        Me.gbPeriodoCancelar.Controls.Add(Me.Label1)
        Me.gbPeriodoCancelar.Controls.Add(Me.dtpFechaI)
        Me.gbPeriodoCancelar.Controls.Add(Me.Label2)
        Me.gbPeriodoCancelar.Location = New System.Drawing.Point(23, 142)
        Me.gbPeriodoCancelar.Name = "gbPeriodoCancelar"
        Me.gbPeriodoCancelar.Size = New System.Drawing.Size(555, 47)
        Me.gbPeriodoCancelar.TabIndex = 5
        Me.gbPeriodoCancelar.TabStop = False
        Me.gbPeriodoCancelar.Text = "Periodo a cancelar"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(360, 13)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 113
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'dtpFechaF
        '
        Me.dtpFechaF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaF.Location = New System.Drawing.Point(248, 15)
        Me.dtpFechaF.Name = "dtpFechaF"
        Me.dtpFechaF.Size = New System.Drawing.Size(102, 20)
        Me.dtpFechaF.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha Fin"
        '
        'dtpFechaI
        '
        Me.dtpFechaI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaI.Location = New System.Drawing.Point(80, 15)
        Me.dtpFechaI.Name = "dtpFechaI"
        Me.dtpFechaI.Size = New System.Drawing.Size(102, 20)
        Me.dtpFechaI.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Inicio:"
        '
        'frmMsIngresoComisionMerca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(602, 484)
        Me.Controls.Add(Me.lblOpcion)
        Me.Controls.Add(Me.gbPeriodoCancelar)
        Me.Controls.Add(Me.dgComisiones)
        Me.Controls.Add(Me.gbFiltros)
        Me.Name = "frmMsIngresoComisionMerca"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Comisiones Mercadeo"
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        CType(Me.dgComisiones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPeriodoCancelar.ResumeLayout(False)
        Me.gbPeriodoCancelar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblOpcion As System.Windows.Forms.Label
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents dgComisiones As System.Windows.Forms.DataGridView
    Friend WithEvents chkTipoComision As System.Windows.Forms.CheckBox
    Friend WithEvents gbPeriodoCancelar As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaF As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
End Class
