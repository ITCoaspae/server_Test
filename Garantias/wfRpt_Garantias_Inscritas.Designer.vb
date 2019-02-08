<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wfRpt_Garantias_Inscritas
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
        Me.cbMOSTRARTODOS = New System.Windows.Forms.CheckBox()
        Me.dtpFECHAFIN = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaFin = New System.Windows.Forms.Label()
        Me.dtpFECHAINI = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'cbMOSTRARTODOS
        '
        Me.cbMOSTRARTODOS.AutoSize = True
        Me.cbMOSTRARTODOS.Location = New System.Drawing.Point(343, 60)
        Me.cbMOSTRARTODOS.Name = "cbMOSTRARTODOS"
        Me.cbMOSTRARTODOS.Size = New System.Drawing.Size(94, 17)
        Me.cbMOSTRARTODOS.TabIndex = 4
        Me.cbMOSTRARTODOS.Text = "Mostrar Todos"
        Me.cbMOSTRARTODOS.UseVisualStyleBackColor = True
        '
        'dtpFECHAFIN
        '
        Me.dtpFECHAFIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFECHAFIN.Location = New System.Drawing.Point(253, 60)
        Me.dtpFECHAFIN.Name = "dtpFECHAFIN"
        Me.dtpFECHAFIN.Size = New System.Drawing.Size(84, 20)
        Me.dtpFECHAFIN.TabIndex = 3
        '
        'lblFechaFin
        '
        Me.lblFechaFin.AutoSize = True
        Me.lblFechaFin.Location = New System.Drawing.Point(190, 60)
        Me.lblFechaFin.Name = "lblFechaFin"
        Me.lblFechaFin.Size = New System.Drawing.Size(57, 13)
        Me.lblFechaFin.TabIndex = 2
        Me.lblFechaFin.Text = "Fecha Fin:"
        '
        'dtpFECHAINI
        '
        Me.dtpFECHAINI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFECHAINI.Location = New System.Drawing.Point(100, 60)
        Me.dtpFECHAINI.Name = "dtpFECHAINI"
        Me.dtpFECHAINI.Size = New System.Drawing.Size(84, 20)
        Me.dtpFECHAINI.TabIndex = 1
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.AutoSize = True
        Me.lblFechaInicio.Location = New System.Drawing.Point(23, 60)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(71, 13)
        Me.lblFechaInicio.TabIndex = 0
        Me.lblFechaInicio.Text = "Fecha Inicio :"
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
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(496, 283)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(443, 60)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 240
        Me.btnGuardar1.Text = "&Generar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'wfRpt_Garantias_Inscritas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(542, 448)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.cbMOSTRARTODOS)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.dtpFECHAFIN)
        Me.Controls.Add(Me.lblFechaFin)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.dtpFECHAINI)
        Me.Name = "wfRpt_Garantias_Inscritas"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reporte de Garantías Inscritas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbMOSTRARTODOS As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFECHAFIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaFin As System.Windows.Forms.Label
    Friend WithEvents dtpFECHAINI As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
End Class
