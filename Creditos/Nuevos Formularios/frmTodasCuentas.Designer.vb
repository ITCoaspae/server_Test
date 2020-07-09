<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTodasCuentas
    Inherits MetroFramework.Forms.MetroForm
    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.rsVISOR = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.chkTodos = New MetroFramework.Controls.MetroCheckBox()
        Me.ChekActivas = New MetroFramework.Controls.MetroCheckBox()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(17, 67)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "DUI:"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(84, 67)
        Me.txtDui.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(103, 18)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(17, 88)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Asociado:"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNombre.Location = New System.Drawing.Point(82, 90)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(259, 20)
        Me.txtNombre.TabIndex = 172
        '
        'rsVISOR
        '
        Me.rsVISOR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rsVISOR.DocumentMapWidth = 1
        Me.rsVISOR.Location = New System.Drawing.Point(17, 119)
        Me.rsVISOR.Name = "rsVISOR"
        Me.rsVISOR.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote
        Me.rsVISOR.ServerReport.BearerToken = Nothing
        Me.rsVISOR.ServerReport.ReportPath = "/RS_SIF_ERP/"
        Me.rsVISOR.ServerReport.ReportServerUrl = New System.Uri("http://jaem90/ReportServer", System.UriKind.Absolute)
        Me.rsVISOR.Size = New System.Drawing.Size(594, 312)
        Me.rsVISOR.TabIndex = 173
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(352, 86)
        Me.btnProcesar1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(68, 26)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 1023
        Me.btnProcesar1.Text = "Mostrar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'chkTodos
        '
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(245, 65)
        Me.chkTodos.Margin = New System.Windows.Forms.Padding(2)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(88, 15)
        Me.chkTodos.TabIndex = 1024
        Me.chkTodos.Text = "Mostrar DPF"
        Me.chkTodos.UseSelectable = True
        '
        'ChekActivas
        '
        Me.ChekActivas.AutoSize = True
        Me.ChekActivas.Location = New System.Drawing.Point(350, 62)
        Me.ChekActivas.Margin = New System.Windows.Forms.Padding(2)
        Me.ChekActivas.Name = "ChekActivas"
        Me.ChekActivas.Size = New System.Drawing.Size(117, 15)
        Me.ChekActivas.TabIndex = 1026
        Me.ChekActivas.Text = "Todas las Cuentas"
        Me.ChekActivas.UseSelectable = True
        '
        'frmTodasCuentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 518)
        Me.Controls.Add(Me.ChekActivas)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.rsVISOR)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmTodasCuentas"
        Me.Padding = New System.Windows.Forms.Padding(15, 60, 15, 16)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "frmTodasCuentas"
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombre As TextBox
    Private WithEvents rsVISOR As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents chkTodos As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents ChekActivas As MetroFramework.Controls.MetroCheckBox
End Class
