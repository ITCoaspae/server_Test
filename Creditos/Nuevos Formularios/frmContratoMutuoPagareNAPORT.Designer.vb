<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContratoMutuoPagareNAPORT
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGenerar1 = New MetroFramework.Controls.MetroButton()
        Me.cbNoSolicitud = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaOtorgado = New System.Windows.Forms.DateTimePicker()
        Me.txtNombreAsoc = New System.Windows.Forms.TextBox()
        Me.lblNombreAsociado = New System.Windows.Forms.Label()
        Me.mskDui = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbNoSolicitud)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.dtpFechaOtorgado)
        Me.Panel1.Controls.Add(Me.txtNombreAsoc)
        Me.Panel1.Controls.Add(Me.lblNombreAsociado)
        Me.Panel1.Controls.Add(Me.mskDui)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(23, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(555, 95)
        Me.Panel1.TabIndex = 11
        '
        'btnGenerar1
        '
        Me.btnGenerar1.Location = New System.Drawing.Point(503, 164)
        Me.btnGenerar1.Name = "btnGenerar1"
        Me.btnGenerar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGenerar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGenerar1.TabIndex = 166
        Me.btnGenerar1.Text = "Generar"
        Me.btnGenerar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGenerar1.UseSelectable = True
        Me.btnGenerar1.UseStyleColors = True
        '
        'cbNoSolicitud
        '
        Me.cbNoSolicitud.FormattingEnabled = True
        Me.cbNoSolicitud.Location = New System.Drawing.Point(446, 12)
        Me.cbNoSolicitud.Name = "cbNoSolicitud"
        Me.cbNoSolicitud.Size = New System.Drawing.Size(97, 21)
        Me.cbNoSolicitud.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(377, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 14)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "NoSolicitud:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 14)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Seleccionar Fecha:"
        '
        'dtpFechaOtorgado
        '
        Me.dtpFechaOtorgado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaOtorgado.Location = New System.Drawing.Point(127, 40)
        Me.dtpFechaOtorgado.Name = "dtpFechaOtorgado"
        Me.dtpFechaOtorgado.Size = New System.Drawing.Size(102, 20)
        Me.dtpFechaOtorgado.TabIndex = 22
        '
        'txtNombreAsoc
        '
        Me.txtNombreAsoc.BackColor = System.Drawing.Color.White
        Me.txtNombreAsoc.Enabled = False
        Me.txtNombreAsoc.Location = New System.Drawing.Point(126, 66)
        Me.txtNombreAsoc.Name = "txtNombreAsoc"
        Me.txtNombreAsoc.Size = New System.Drawing.Size(417, 20)
        Me.txtNombreAsoc.TabIndex = 5
        '
        'lblNombreAsociado
        '
        Me.lblNombreAsociado.AutoSize = True
        Me.lblNombreAsociado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreAsociado.ForeColor = System.Drawing.Color.Black
        Me.lblNombreAsociado.Location = New System.Drawing.Point(10, 66)
        Me.lblNombreAsociado.Name = "lblNombreAsociado"
        Me.lblNombreAsociado.Size = New System.Drawing.Size(95, 14)
        Me.lblNombreAsociado.TabIndex = 4
        Me.lblNombreAsociado.Text = "Nombre Asociado:"
        '
        'mskDui
        '
        Me.mskDui.BackColor = System.Drawing.Color.White
        Me.mskDui.Location = New System.Drawing.Point(127, 12)
        Me.mskDui.Mask = "00000000-0"
        Me.mskDui.Name = "mskDui"
        Me.mskDui.Size = New System.Drawing.Size(102, 20)
        Me.mskDui.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "DUI:"
        '
        'frmContratoMutuoPagareNAPORT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(595, 227)
        Me.Controls.Add(Me.btnGenerar1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(595, 227)
        Me.MinimumSize = New System.Drawing.Size(595, 227)
        Me.Name = "frmContratoMutuoPagareNAPORT"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Contrato Mutuo Pagare Aportaciones"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbNoSolicitud As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaOtorgado As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombreAsoc As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreAsociado As System.Windows.Forms.Label
    Friend WithEvents mskDui As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnGenerar1 As MetroFramework.Controls.MetroButton
End Class
