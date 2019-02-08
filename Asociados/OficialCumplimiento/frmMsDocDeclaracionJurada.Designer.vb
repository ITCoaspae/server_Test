<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsDocDeclaracionJurada
    Inherits MetroFramework.Forms.MetroForm '  Inherits System.Windows.Forms.Form

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
        Me.lblTipoDocumento = New System.Windows.Forms.Label()
        Me.cbTipoDoc = New System.Windows.Forms.ComboBox()
        Me.lblPlazoEntrega = New System.Windows.Forms.Label()
        Me.cbPlazo = New System.Windows.Forms.ComboBox()
        Me.lblFechaEntrega = New System.Windows.Forms.Label()
        Me.dtpFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkPresentoDoc = New System.Windows.Forms.CheckBox()
        Me.btnGuardarDom = New MetroFramework.Controls.MetroButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.AutoSize = True
        Me.lblTipoDocumento.Location = New System.Drawing.Point(6, 11)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(89, 13)
        Me.lblTipoDocumento.TabIndex = 0
        Me.lblTipoDocumento.Text = "Tipo Documento:"
        '
        'cbTipoDoc
        '
        Me.cbTipoDoc.BackColor = System.Drawing.Color.White
        Me.cbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDoc.FormattingEnabled = True
        Me.cbTipoDoc.Location = New System.Drawing.Point(101, 8)
        Me.cbTipoDoc.Name = "cbTipoDoc"
        Me.cbTipoDoc.Size = New System.Drawing.Size(200, 21)
        Me.cbTipoDoc.TabIndex = 1
        '
        'lblPlazoEntrega
        '
        Me.lblPlazoEntrega.AutoSize = True
        Me.lblPlazoEntrega.Location = New System.Drawing.Point(6, 37)
        Me.lblPlazoEntrega.Name = "lblPlazoEntrega"
        Me.lblPlazoEntrega.Size = New System.Drawing.Size(74, 26)
        Me.lblPlazoEntrega.TabIndex = 2
        Me.lblPlazoEntrega.Text = "Plazo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Entrega(días):"
        '
        'cbPlazo
        '
        Me.cbPlazo.BackColor = System.Drawing.Color.White
        Me.cbPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPlazo.FormattingEnabled = True
        Me.cbPlazo.Location = New System.Drawing.Point(101, 42)
        Me.cbPlazo.Name = "cbPlazo"
        Me.cbPlazo.Size = New System.Drawing.Size(114, 21)
        Me.cbPlazo.TabIndex = 3
        '
        'lblFechaEntrega
        '
        Me.lblFechaEntrega.AutoSize = True
        Me.lblFechaEntrega.Location = New System.Drawing.Point(221, 46)
        Me.lblFechaEntrega.Name = "lblFechaEntrega"
        Me.lblFechaEntrega.Size = New System.Drawing.Size(80, 13)
        Me.lblFechaEntrega.TabIndex = 4
        Me.lblFechaEntrega.Text = "Fecha Entrega:"
        '
        'dtpFechaEntrega
        '
        Me.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEntrega.Location = New System.Drawing.Point(307, 43)
        Me.dtpFechaEntrega.Name = "dtpFechaEntrega"
        Me.dtpFechaEntrega.Size = New System.Drawing.Size(106, 20)
        Me.dtpFechaEntrega.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.chkPresentoDoc)
        Me.Panel1.Controls.Add(Me.cbPlazo)
        Me.Panel1.Controls.Add(Me.dtpFechaEntrega)
        Me.Panel1.Controls.Add(Me.lblTipoDocumento)
        Me.Panel1.Controls.Add(Me.lblFechaEntrega)
        Me.Panel1.Controls.Add(Me.cbTipoDoc)
        Me.Panel1.Controls.Add(Me.lblPlazoEntrega)
        Me.Panel1.Location = New System.Drawing.Point(23, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 71)
        Me.Panel1.TabIndex = 6
        '
        'chkPresentoDoc
        '
        Me.chkPresentoDoc.AutoSize = True
        Me.chkPresentoDoc.Location = New System.Drawing.Point(312, 7)
        Me.chkPresentoDoc.Name = "chkPresentoDoc"
        Me.chkPresentoDoc.Size = New System.Drawing.Size(101, 30)
        Me.chkPresentoDoc.TabIndex = 6
        Me.chkPresentoDoc.Text = "Presento " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Documentación"
        Me.chkPresentoDoc.UseVisualStyleBackColor = True
        '
        'btnGuardarDom
        '
        Me.btnGuardarDom.Location = New System.Drawing.Point(366, 140)
        Me.btnGuardarDom.Name = "btnGuardarDom"
        Me.btnGuardarDom.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardarDom.TabIndex = 158
        Me.btnGuardarDom.Text = "Guardar"
        Me.btnGuardarDom.UseSelectable = True
        Me.btnGuardarDom.UseStyleColors = True
        '
        'frmMsDocDeclaracionJurada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(464, 185)
        Me.Controls.Add(Me.btnGuardarDom)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsDocDeclaracionJurada"
        Me.Text = "Documentos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTipoDocumento As System.Windows.Forms.Label
    Friend WithEvents cbTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents lblPlazoEntrega As System.Windows.Forms.Label
    Friend WithEvents cbPlazo As System.Windows.Forms.ComboBox
    Friend WithEvents lblFechaEntrega As System.Windows.Forms.Label
    Friend WithEvents dtpFechaEntrega As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkPresentoDoc As System.Windows.Forms.CheckBox
    Friend WithEvents btnGuardarDom As MetroFramework.Controls.MetroButton
End Class
