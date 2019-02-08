<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wfRPT_GARANTIAS_MERCADEO
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
        Me.dtFECHAFIN = New System.Windows.Forms.DateTimePicker()
        Me.dtFECHAINICIO = New System.Windows.Forms.DateTimePicker()
        Me.lblFECHAFIN = New System.Windows.Forms.Label()
        Me.lblFECHAINICIO = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(550, 318)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(360, 60)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 242
        Me.btnGuardar1.Text = "&Generar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.CrystalReportViewer1)
        Me.Panel1.Location = New System.Drawing.Point(23, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(550, 318)
        Me.Panel1.TabIndex = 243
        '
        'wfRPT_GARANTIAS_MERCADEO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(610, 477)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.dtFECHAFIN)
        Me.Controls.Add(Me.lblFECHAFIN)
        Me.Controls.Add(Me.dtFECHAINICIO)
        Me.Controls.Add(Me.lblFECHAINICIO)
        Me.Name = "wfRPT_GARANTIAS_MERCADEO"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reporte de Garantías Hipotecarias Depto. de Mercadeo"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtFECHAFIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFECHAINICIO As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFECHAFIN As System.Windows.Forms.Label
    Friend WithEvents lblFECHAINICIO As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As Panel
End Class
