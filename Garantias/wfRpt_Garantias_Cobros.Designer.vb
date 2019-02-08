<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wfRPT_GARANTIAS_COBROS
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form

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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.dtFECHAFIN = New System.Windows.Forms.DateTimePicker()
        Me.dtFECHAINICIO = New System.Windows.Forms.DateTimePicker()
        Me.lblFECHAFIN = New System.Windows.Forms.Label()
        Me.lblFECHAINICIO = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(23, 94)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(453, 200)
        Me.CrystalReportViewer1.TabIndex = 5
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'dtFECHAFIN
        '
        Me.dtFECHAFIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFECHAFIN.Location = New System.Drawing.Point(257, 60)
        Me.dtFECHAFIN.Name = "dtFECHAFIN"
        Me.dtFECHAFIN.Size = New System.Drawing.Size(97, 20)
        Me.dtFECHAFIN.TabIndex = 3
        '
        'dtFECHAINICIO
        '
        Me.dtFECHAINICIO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFECHAINICIO.Location = New System.Drawing.Point(94, 60)
        Me.dtFECHAINICIO.Name = "dtFECHAINICIO"
        Me.dtFECHAINICIO.Size = New System.Drawing.Size(97, 20)
        Me.dtFECHAINICIO.TabIndex = 2
        '
        'lblFECHAFIN
        '
        Me.lblFECHAFIN.AutoSize = True
        Me.lblFECHAFIN.Location = New System.Drawing.Point(197, 60)
        Me.lblFECHAFIN.Name = "lblFECHAFIN"
        Me.lblFECHAFIN.Size = New System.Drawing.Size(54, 13)
        Me.lblFECHAFIN.TabIndex = 1
        Me.lblFECHAFIN.Text = "Fecha Fin"
        '
        'lblFECHAINICIO
        '
        Me.lblFECHAINICIO.AutoSize = True
        Me.lblFECHAINICIO.Location = New System.Drawing.Point(23, 60)
        Me.lblFECHAINICIO.Name = "lblFECHAINICIO"
        Me.lblFECHAINICIO.Size = New System.Drawing.Size(65, 13)
        Me.lblFECHAINICIO.TabIndex = 0
        Me.lblFECHAINICIO.Text = "Fecha Inicio"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(401, 60)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 238
        Me.btnGuardar1.Text = "&Generar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'wfRPT_GARANTIAS_COBROS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(499, 349)
        Me.Controls.Add(Me.dtFECHAFIN)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.dtFECHAINICIO)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.lblFECHAFIN)
        Me.Controls.Add(Me.lblFECHAINICIO)
        Me.Name = "wfRPT_GARANTIAS_COBROS"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reporte de Garantías Hipotecarias Cobros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dtFECHAFIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFECHAINICIO As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFECHAFIN As System.Windows.Forms.Label
    Friend WithEvents lblFECHAINICIO As System.Windows.Forms.Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
End Class
