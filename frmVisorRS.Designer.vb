<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVisorRS
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rsVISOR = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'rsVISOR
        '
        Me.rsVISOR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rsVISOR.DocumentMapWidth = 1
        Me.rsVISOR.Location = New System.Drawing.Point(0, 0)
        Me.rsVISOR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rsVISOR.Name = "rsVISOR"
        Me.rsVISOR.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.rsVISOR.ServerReport.BearerToken = Nothing
        Me.rsVISOR.ServerReport.ReportPath = "/RS_SIF_ERP/"
        Me.rsVISOR.ServerReport.ReportServerUrl = New System.Uri("http://jaem90/ReportServer", System.UriKind.Absolute)
        Me.rsVISOR.Size = New System.Drawing.Size(791, 330)
        Me.rsVISOR.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.rsVISOR)
        Me.Panel2.Location = New System.Drawing.Point(31, 78)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(793, 332)
        Me.Panel2.TabIndex = 3
        '
        'frmVisorRS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(855, 510)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmVisorRS"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reportes"
        Me.TopMost = True
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents rsVISOR As Microsoft.Reporting.WinForms.ReportViewer
End Class
