<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContratoCreditoGerencial
    'Inherits System.Windows.Forms.Form
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNombreAsoc = New System.Windows.Forms.Label()
        Me.txtNombreAsoc = New System.Windows.Forms.TextBox()
        Me.lblFechaSol = New System.Windows.Forms.Label()
        Me.dtpFechaSol = New System.Windows.Forms.DateTimePicker()
        Me.cbNoSolicitud = New System.Windows.Forms.ComboBox()
        Me.lblNoSol = New System.Windows.Forms.Label()
        Me.mskDui = New System.Windows.Forms.MaskedTextBox()
        Me.lblDui = New System.Windows.Forms.Label()
        Me.btnGenerar1 = New MetroFramework.Controls.MetroButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblNombreAsoc)
        Me.Panel1.Controls.Add(Me.txtNombreAsoc)
        Me.Panel1.Controls.Add(Me.lblFechaSol)
        Me.Panel1.Controls.Add(Me.dtpFechaSol)
        Me.Panel1.Controls.Add(Me.cbNoSolicitud)
        Me.Panel1.Controls.Add(Me.lblNoSol)
        Me.Panel1.Controls.Add(Me.mskDui)
        Me.Panel1.Controls.Add(Me.lblDui)
        Me.Panel1.Location = New System.Drawing.Point(23, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(472, 66)
        Me.Panel1.TabIndex = 5
        '
        'lblNombreAsoc
        '
        Me.lblNombreAsoc.AutoSize = True
        Me.lblNombreAsoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreAsoc.ForeColor = System.Drawing.Color.Black
        Me.lblNombreAsoc.Location = New System.Drawing.Point(3, 35)
        Me.lblNombreAsoc.Name = "lblNombreAsoc"
        Me.lblNombreAsoc.Size = New System.Drawing.Size(95, 14)
        Me.lblNombreAsoc.TabIndex = 9
        Me.lblNombreAsoc.Text = "Nombre Asociado:"
        '
        'txtNombreAsoc
        '
        Me.txtNombreAsoc.BackColor = System.Drawing.Color.White
        Me.txtNombreAsoc.Enabled = False
        Me.txtNombreAsoc.Location = New System.Drawing.Point(119, 35)
        Me.txtNombreAsoc.Name = "txtNombreAsoc"
        Me.txtNombreAsoc.Size = New System.Drawing.Size(342, 20)
        Me.txtNombreAsoc.TabIndex = 8
        '
        'lblFechaSol
        '
        Me.lblFechaSol.AutoSize = True
        Me.lblFechaSol.Location = New System.Drawing.Point(161, 98)
        Me.lblFechaSol.Name = "lblFechaSol"
        Me.lblFechaSol.Size = New System.Drawing.Size(83, 13)
        Me.lblFechaSol.TabIndex = 7
        Me.lblFechaSol.Text = "Fecha Solicitud:"
        Me.lblFechaSol.Visible = False
        '
        'dtpFechaSol
        '
        Me.dtpFechaSol.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSol.Location = New System.Drawing.Point(250, 91)
        Me.dtpFechaSol.Name = "dtpFechaSol"
        Me.dtpFechaSol.Size = New System.Drawing.Size(97, 20)
        Me.dtpFechaSol.TabIndex = 6
        Me.dtpFechaSol.Visible = False
        '
        'cbNoSolicitud
        '
        Me.cbNoSolicitud.FormattingEnabled = True
        Me.cbNoSolicitud.Location = New System.Drawing.Point(368, 3)
        Me.cbNoSolicitud.Name = "cbNoSolicitud"
        Me.cbNoSolicitud.Size = New System.Drawing.Size(93, 21)
        Me.cbNoSolicitud.TabIndex = 5
        '
        'lblNoSol
        '
        Me.lblNoSol.AutoSize = True
        Me.lblNoSol.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoSol.ForeColor = System.Drawing.Color.Black
        Me.lblNoSol.Location = New System.Drawing.Point(218, 6)
        Me.lblNoSol.Name = "lblNoSol"
        Me.lblNoSol.Size = New System.Drawing.Size(129, 14)
        Me.lblNoSol.TabIndex = 4
        Me.lblNoSol.Text = "Seleccionar No. Solicitud:"
        '
        'mskDui
        '
        Me.mskDui.BackColor = System.Drawing.Color.White
        Me.mskDui.Location = New System.Drawing.Point(119, 3)
        Me.mskDui.Mask = "00000000-0"
        Me.mskDui.Name = "mskDui"
        Me.mskDui.Size = New System.Drawing.Size(93, 20)
        Me.mskDui.TabIndex = 3
        '
        'lblDui
        '
        Me.lblDui.AutoSize = True
        Me.lblDui.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDui.ForeColor = System.Drawing.Color.Black
        Me.lblDui.Location = New System.Drawing.Point(3, 6)
        Me.lblDui.Name = "lblDui"
        Me.lblDui.Size = New System.Drawing.Size(99, 14)
        Me.lblDui.TabIndex = 2
        Me.lblDui.Text = "Digitar Numero DUI:"
        '
        'btnGenerar1
        '
        Me.btnGenerar1.Location = New System.Drawing.Point(420, 135)
        Me.btnGenerar1.Name = "btnGenerar1"
        Me.btnGenerar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGenerar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGenerar1.TabIndex = 165
        Me.btnGenerar1.Text = "Generar"
        Me.btnGenerar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGenerar1.UseSelectable = True
        Me.btnGenerar1.UseStyleColors = True
        '
        'frmContratoCreditoGerencial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(518, 198)
        Me.Controls.Add(Me.btnGenerar1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(518, 198)
        Me.MinimumSize = New System.Drawing.Size(518, 198)
        Me.Name = "frmContratoCreditoGerencial"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Solicitud de Créditos Gerenciales"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents mskDui As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblDui As System.Windows.Forms.Label
    Friend WithEvents lblNoSol As System.Windows.Forms.Label
    Friend WithEvents cbNoSolicitud As System.Windows.Forms.ComboBox
    Friend WithEvents lblFechaSol As System.Windows.Forms.Label
    Friend WithEvents dtpFechaSol As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblNombreAsoc As System.Windows.Forms.Label
    Friend WithEvents txtNombreAsoc As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerar1 As MetroFramework.Controls.MetroButton
End Class
