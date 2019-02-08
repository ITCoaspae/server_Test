<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDifCarteraPrestamos
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.lflFechaI = New System.Windows.Forms.Label()
        Me.dgDiferencias = New System.Windows.Forms.DataGridView()
        Me.btnGenerar1 = New MetroFramework.Controls.MetroButton()
        Me.btnExportar1 = New MetroFramework.Controls.MetroButton()
        Me.Panel2.SuspendLayout()
        CType(Me.dgDiferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtpFechaFin)
        Me.Panel2.Controls.Add(Me.lblFechaFin)
        Me.Panel2.Controls.Add(Me.dtpFechaInicio)
        Me.Panel2.Controls.Add(Me.lflFechaI)
        Me.Panel2.Location = New System.Drawing.Point(23, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(340, 46)
        Me.Panel2.TabIndex = 1
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(234, 9)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(86, 20)
        Me.dtpFechaFin.TabIndex = 3
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(171, 9)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(57, 13)
        Me.lblFechaFin.TabIndex = 2
        Me.lblFechaFin.Text = "Fecha Fin:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(79, 9)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(86, 20)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'lflFechaI
        '
        Me.lflFechaI.AutoSize = True
        Me.lflFechaI.Location = New System.Drawing.Point(5, 9)
        Me.lflFechaI.Name = "lflFechaI"
        Me.lflFechaI.Size = New System.Drawing.Size(68, 13)
        Me.lflFechaI.TabIndex = 0
        Me.lflFechaI.Text = "Fecha Inicio:"
        '
        'dgDiferencias
        '
        Me.dgDiferencias.AllowUserToAddRows = False
        Me.dgDiferencias.AllowUserToDeleteRows = False
        Me.dgDiferencias.AllowUserToOrderColumns = True
        Me.dgDiferencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDiferencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDiferencias.Location = New System.Drawing.Point(23, 149)
        Me.dgDiferencias.Name = "dgDiferencias"
        Me.dgDiferencias.ReadOnly = True
        Me.dgDiferencias.Size = New System.Drawing.Size(551, 157)
        Me.dgDiferencias.TabIndex = 2
        '
        'btnGenerar1
        '
        Me.btnGenerar1.Location = New System.Drawing.Point(23, 115)
        Me.btnGenerar1.Name = "btnGenerar1"
        Me.btnGenerar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGenerar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGenerar1.TabIndex = 188
        Me.btnGenerar1.Text = "Generar"
        Me.btnGenerar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGenerar1.UseSelectable = True
        Me.btnGenerar1.UseStyleColors = True
        '
        'btnExportar1
        '
        Me.btnExportar1.Location = New System.Drawing.Point(104, 115)
        Me.btnExportar1.Name = "btnExportar1"
        Me.btnExportar1.Size = New System.Drawing.Size(75, 28)
        Me.btnExportar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnExportar1.TabIndex = 189
        Me.btnExportar1.Text = "Exportar"
        Me.btnExportar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnExportar1.UseSelectable = True
        Me.btnExportar1.UseStyleColors = True
        '
        'frmDifCarteraPrestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.ClientSize = New System.Drawing.Size(597, 366)
        Me.Controls.Add(Me.btnExportar1)
        Me.Controls.Add(Me.btnGenerar1)
        Me.Controls.Add(Me.dgDiferencias)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmDifCarteraPrestamos"

        Me.Text = "Diferencias cartera de préstamos"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgDiferencias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lflFechaI As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgDiferencias As System.Windows.Forms.DataGridView
    Friend WithEvents btnGenerar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnExportar1 As MetroFramework.Controls.MetroButton
End Class
