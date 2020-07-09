<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisorRs_Contratos
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
        Me.rsVisor = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'rsVisor
        '
        Me.rsVisor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rsVisor.Location = New System.Drawing.Point(0, 0)
        Me.rsVisor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rsVisor.Name = "rsVisor"
        Me.rsVisor.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.rsVisor.ServerReport.BearerToken = Nothing
        Me.rsVisor.ServerReport.ReportPath = "/RS_SIF_ERP/"
        Me.rsVisor.ServerReport.ReportServerUrl = New System.Uri("http://192.168.1.3/reportserver", System.UriKind.Absolute)
        Me.rsVisor.Size = New System.Drawing.Size(872, 543)
        Me.rsVisor.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.rsVisor)
        Me.Panel2.Location = New System.Drawing.Point(-1, 33)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(872, 543)
        Me.Panel2.TabIndex = 5
        '
        'frmVisorRs_Contratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(865, 570)
        Me.Controls.Add(Me.Panel2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmVisorRs_Contratos"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents rsVisor As Microsoft.Reporting.WinForms.ReportViewer
End Class
