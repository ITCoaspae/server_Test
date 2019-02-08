<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMsCorrelativosDocumentsoCaja
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form

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
        Me.txtCorrIni = New System.Windows.Forms.TextBox()
        Me.lblCorreInicial = New System.Windows.Forms.Label()
        Me.txtMaximo = New System.Windows.Forms.TextBox()
        Me.lblCorrFinal = New System.Windows.Forms.Label()
        Me.txtMinimo = New System.Windows.Forms.TextBox()
        Me.lblCorrMin = New System.Windows.Forms.Label()
        Me.cbDocumento = New System.Windows.Forms.ComboBox()
        Me.lblTipoDoc = New System.Windows.Forms.Label()
        Me.cbCajero = New System.Windows.Forms.ComboBox()
        Me.lblCajero = New System.Windows.Forms.Label()
        Me.cbSucursal = New System.Windows.Forms.ComboBox()
        Me.lblSucursales = New System.Windows.Forms.Label()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtCorrIni
        '
        Me.txtCorrIni.BackColor = System.Drawing.Color.White
        Me.txtCorrIni.Location = New System.Drawing.Point(34, 289)
        Me.txtCorrIni.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCorrIni.Name = "txtCorrIni"
        Me.txtCorrIni.Size = New System.Drawing.Size(200, 22)
        Me.txtCorrIni.TabIndex = 11
        '
        'lblCorreInicial
        '
        Me.lblCorreInicial.AutoSize = True
        Me.lblCorreInicial.Location = New System.Drawing.Point(31, 268)
        Me.lblCorreInicial.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCorreInicial.Name = "lblCorreInicial"
        Me.lblCorreInicial.Size = New System.Drawing.Size(115, 17)
        Me.lblCorreInicial.TabIndex = 10
        Me.lblCorreInicial.Text = "Correlativo Inicial"
        '
        'txtMaximo
        '
        Me.txtMaximo.BackColor = System.Drawing.Color.White
        Me.txtMaximo.Location = New System.Drawing.Point(264, 242)
        Me.txtMaximo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Size = New System.Drawing.Size(203, 22)
        Me.txtMaximo.TabIndex = 9
        '
        'lblCorrFinal
        '
        Me.lblCorrFinal.AutoSize = True
        Me.lblCorrFinal.Location = New System.Drawing.Point(261, 221)
        Me.lblCorrFinal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCorrFinal.Name = "lblCorrFinal"
        Me.lblCorrFinal.Size = New System.Drawing.Size(59, 17)
        Me.lblCorrFinal.TabIndex = 8
        Me.lblCorrFinal.Text = "Máximo:"
        '
        'txtMinimo
        '
        Me.txtMinimo.BackColor = System.Drawing.Color.White
        Me.txtMinimo.Location = New System.Drawing.Point(34, 242)
        Me.txtMinimo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.Size = New System.Drawing.Size(200, 22)
        Me.txtMinimo.TabIndex = 7
        '
        'lblCorrMin
        '
        Me.lblCorrMin.AutoSize = True
        Me.lblCorrMin.Location = New System.Drawing.Point(31, 221)
        Me.lblCorrMin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCorrMin.Name = "lblCorrMin"
        Me.lblCorrMin.Size = New System.Drawing.Size(56, 17)
        Me.lblCorrMin.TabIndex = 6
        Me.lblCorrMin.Text = "Mínimo:"
        '
        'cbDocumento
        '
        Me.cbDocumento.BackColor = System.Drawing.Color.White
        Me.cbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDocumento.FormattingEnabled = True
        Me.cbDocumento.Location = New System.Drawing.Point(34, 193)
        Me.cbDocumento.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDocumento.Name = "cbDocumento"
        Me.cbDocumento.Size = New System.Drawing.Size(433, 24)
        Me.cbDocumento.TabIndex = 5
        '
        'lblTipoDoc
        '
        Me.lblTipoDoc.AutoSize = True
        Me.lblTipoDoc.Location = New System.Drawing.Point(31, 172)
        Me.lblTipoDoc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoDoc.Name = "lblTipoDoc"
        Me.lblTipoDoc.Size = New System.Drawing.Size(84, 17)
        Me.lblTipoDoc.TabIndex = 4
        Me.lblTipoDoc.Text = "Documento:"
        '
        'cbCajero
        '
        Me.cbCajero.BackColor = System.Drawing.Color.White
        Me.cbCajero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCajero.FormattingEnabled = True
        Me.cbCajero.Location = New System.Drawing.Point(34, 144)
        Me.cbCajero.Margin = New System.Windows.Forms.Padding(4)
        Me.cbCajero.Name = "cbCajero"
        Me.cbCajero.Size = New System.Drawing.Size(433, 24)
        Me.cbCajero.TabIndex = 3
        '
        'lblCajero
        '
        Me.lblCajero.AutoSize = True
        Me.lblCajero.Location = New System.Drawing.Point(31, 123)
        Me.lblCajero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCajero.Name = "lblCajero"
        Me.lblCajero.Size = New System.Drawing.Size(40, 17)
        Me.lblCajero.TabIndex = 2
        Me.lblCajero.Text = "Caja:"
        '
        'cbSucursal
        '
        Me.cbSucursal.BackColor = System.Drawing.Color.White
        Me.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(34, 95)
        Me.cbSucursal.Margin = New System.Windows.Forms.Padding(4)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(433, 24)
        Me.cbSucursal.TabIndex = 1
        '
        'lblSucursales
        '
        Me.lblSucursales.AutoSize = True
        Me.lblSucursales.Location = New System.Drawing.Point(31, 74)
        Me.lblSucursales.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSucursales.Name = "lblSucursales"
        Me.lblSucursales.Size = New System.Drawing.Size(67, 17)
        Me.lblSucursales.TabIndex = 0
        Me.lblSucursales.Text = "Sucursal:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(367, 289)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 34)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 178
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'frmMsCorrelativosDocumentsoCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(503, 411)
        Me.Controls.Add(Me.txtCorrIni)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblCorreInicial)
        Me.Controls.Add(Me.txtMaximo)
        Me.Controls.Add(Me.lblSucursales)
        Me.Controls.Add(Me.lblCorrFinal)
        Me.Controls.Add(Me.cbSucursal)
        Me.Controls.Add(Me.txtMinimo)
        Me.Controls.Add(Me.lblCajero)
        Me.Controls.Add(Me.lblCorrMin)
        Me.Controls.Add(Me.cbCajero)
        Me.Controls.Add(Me.cbDocumento)
        Me.Controls.Add(Me.lblTipoDoc)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsCorrelativosDocumentsoCaja"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Correlativo de Documentos Caja"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCorrMin As System.Windows.Forms.Label
    Friend WithEvents cbDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipoDoc As System.Windows.Forms.Label
    Friend WithEvents cbCajero As System.Windows.Forms.ComboBox
    Friend WithEvents lblCajero As System.Windows.Forms.Label
    Friend WithEvents cbSucursal As System.Windows.Forms.ComboBox
    Friend WithEvents lblSucursales As System.Windows.Forms.Label
    Friend WithEvents txtCorrIni As System.Windows.Forms.TextBox
    Friend WithEvents lblCorreInicial As System.Windows.Forms.Label
    Friend WithEvents txtMaximo As System.Windows.Forms.TextBox
    Friend WithEvents lblCorrFinal As System.Windows.Forms.Label
    Friend WithEvents txtMinimo As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
End Class
