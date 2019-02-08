<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsProgressBar
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
        Me.gbProgressBar = New System.Windows.Forms.GroupBox()
        Me.lblPorciento = New System.Windows.Forms.Label()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.lbEnviados = New System.Windows.Forms.ListBox()
        Me.lbNoEnviados = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.gbProgressBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbProgressBar
        '
        Me.gbProgressBar.Controls.Add(Me.lblPorciento)
        Me.gbProgressBar.Controls.Add(Me.pb)
        Me.gbProgressBar.Location = New System.Drawing.Point(23, 63)
        Me.gbProgressBar.Name = "gbProgressBar"
        Me.gbProgressBar.Size = New System.Drawing.Size(437, 67)
        Me.gbProgressBar.TabIndex = 0
        Me.gbProgressBar.TabStop = False
        Me.gbProgressBar.Text = "Progreso"
        '
        'lblPorciento
        '
        Me.lblPorciento.AutoSize = True
        Me.lblPorciento.Location = New System.Drawing.Point(206, 14)
        Me.lblPorciento.Name = "lblPorciento"
        Me.lblPorciento.Size = New System.Drawing.Size(24, 13)
        Me.lblPorciento.TabIndex = 1
        Me.lblPorciento.Text = "0 %"
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(4, 32)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(427, 23)
        Me.pb.TabIndex = 0
        '
        'lbEnviados
        '
        Me.lbEnviados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbEnviados.FormattingEnabled = True
        Me.lbEnviados.Location = New System.Drawing.Point(21, 162)
        Me.lbEnviados.Name = "lbEnviados"
        Me.lbEnviados.Size = New System.Drawing.Size(217, 173)
        Me.lbEnviados.Sorted = True
        Me.lbEnviados.TabIndex = 3
        '
        'lbNoEnviados
        '
        Me.lbNoEnviados.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbNoEnviados.FormattingEnabled = True
        Me.lbNoEnviados.Location = New System.Drawing.Point(243, 162)
        Me.lbNoEnviados.Name = "lbNoEnviados"
        Me.lbNoEnviados.Size = New System.Drawing.Size(217, 173)
        Me.lbNoEnviados.Sorted = True
        Me.lbNoEnviados.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Correos enviados a:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Correos no enviados a:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(385, 341)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 147
        Me.btnGuardar1.Text = "Enviar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(485, 426)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbNoEnviados)
        Me.Controls.Add(Me.lbEnviados)
        Me.Controls.Add(Me.gbProgressBar)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(485, 426)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(485, 426)
        Me.Name = "frmMsProgressBar"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Envio de boletas"
        Me.gbProgressBar.ResumeLayout(False)
        Me.gbProgressBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbProgressBar As System.Windows.Forms.GroupBox
    Friend WithEvents pb As System.Windows.Forms.ProgressBar
    Friend WithEvents lblPorciento As System.Windows.Forms.Label
    Friend WithEvents lbEnviados As System.Windows.Forms.ListBox
    Friend WithEvents lbNoEnviados As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
End Class
