<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisorReporte
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
        Me.crvVisorReportes = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SuspendLayout()
        '
        'crvVisorReportes
        '
        Me.crvVisorReportes.ActiveViewIndex = -1
        Me.crvVisorReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvVisorReportes.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvVisorReportes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvVisorReportes.Location = New System.Drawing.Point(27, 74)
        Me.crvVisorReportes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.crvVisorReportes.Name = "crvVisorReportes"
        Me.crvVisorReportes.SelectionFormula = ""
        Me.crvVisorReportes.Size = New System.Drawing.Size(534, 387)
        Me.crvVisorReportes.TabIndex = 0
        Me.crvVisorReportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.crvVisorReportes.ToolPanelWidth = 267
        Me.crvVisorReportes.ViewTimeSelectionFormula = ""
        '
        'frmVisorReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 486)
        Me.Controls.Add(Me.crvVisorReportes)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmVisorReporte"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Visor Reporte"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvVisorReportes As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
