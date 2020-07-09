<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsIndiceLiquidez
    Inherits System.Windows.Forms.Form

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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lblEncabezado = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblIndice = New System.Windows.Forms.Label
        Me.txtIndice = New C1.Win.C1Input.C1NumericEdit
        Me.nudAnnio = New System.Windows.Forms.NumericUpDown
        Me.lblAnnio = New System.Windows.Forms.Label
        Me.cbMes = New System.Windows.Forms.ComboBox
        Me.lblMes = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txtIndice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAnnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lblEncabezado)
        Me.Panel2.Location = New System.Drawing.Point(0, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(432, 33)
        Me.Panel2.TabIndex = 156
        '
        'lblEncabezado
        '
        Me.lblEncabezado.AutoSize = True
        Me.lblEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezado.ForeColor = System.Drawing.Color.White
        Me.lblEncabezado.Location = New System.Drawing.Point(3, 6)
        Me.lblEncabezado.Name = "lblEncabezado"
        Me.lblEncabezado.Size = New System.Drawing.Size(182, 24)
        Me.lblEncabezado.TabIndex = 0
        Me.lblEncabezado.Text = "Indice de Liquidez"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblIndice)
        Me.Panel1.Controls.Add(Me.txtIndice)
        Me.Panel1.Controls.Add(Me.nudAnnio)
        Me.Panel1.Controls.Add(Me.lblAnnio)
        Me.Panel1.Controls.Add(Me.cbMes)
        Me.Panel1.Controls.Add(Me.lblMes)
        Me.Panel1.Location = New System.Drawing.Point(12, 40)
        Me.Panel1.MaximumSize = New System.Drawing.Size(406, 71)
        Me.Panel1.MinimumSize = New System.Drawing.Size(406, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 71)
        Me.Panel1.TabIndex = 157
        '
        'lblIndice
        '
        Me.lblIndice.AutoSize = True
        Me.lblIndice.Location = New System.Drawing.Point(3, 37)
        Me.lblIndice.Name = "lblIndice"
        Me.lblIndice.Size = New System.Drawing.Size(39, 13)
        Me.lblIndice.TabIndex = 11
        Me.lblIndice.Text = "Indice:"
        '
        'txtIndice
        '
        Me.txtIndice.BackColor = System.Drawing.Color.Khaki
        Me.txtIndice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIndice.CustomFormat = "###,###,##0.00"
        Me.txtIndice.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIndice.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtIndice.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtIndice.Location = New System.Drawing.Point(48, 37)
        Me.txtIndice.Name = "txtIndice"
        Me.txtIndice.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtIndice.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtIndice.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtIndice.ShowDropDownButton = False
        Me.txtIndice.ShowUpDownButtons = False
        Me.txtIndice.Size = New System.Drawing.Size(104, 21)
        Me.txtIndice.TabIndex = 10
        Me.txtIndice.Tag = Nothing
        Me.txtIndice.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'nudAnnio
        '
        Me.nudAnnio.BackColor = System.Drawing.Color.Khaki
        Me.nudAnnio.Location = New System.Drawing.Point(48, 11)
        Me.nudAnnio.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.nudAnnio.Minimum = New Decimal(New Integer() {1990, 0, 0, 0})
        Me.nudAnnio.Name = "nudAnnio"
        Me.nudAnnio.Size = New System.Drawing.Size(59, 20)
        Me.nudAnnio.TabIndex = 8
        Me.nudAnnio.Value = New Decimal(New Integer() {2015, 0, 0, 0})
        '
        'lblAnnio
        '
        Me.lblAnnio.AutoSize = True
        Me.lblAnnio.Location = New System.Drawing.Point(3, 13)
        Me.lblAnnio.Name = "lblAnnio"
        Me.lblAnnio.Size = New System.Drawing.Size(29, 13)
        Me.lblAnnio.TabIndex = 7
        Me.lblAnnio.Text = "Año:"
        '
        'cbMes
        '
        Me.cbMes.BackColor = System.Drawing.Color.Khaki
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cbMes.Location = New System.Drawing.Point(193, 8)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(198, 21)
        Me.cbMes.TabIndex = 1
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(157, 11)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(30, 13)
        Me.lblMes.TabIndex = 0
        Me.lblMes.Text = "Mes:"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        'Me.btnGuardar.Image = My.Resources.resMain.save2
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(228, 117)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 28)
        Me.btnGuardar.TabIndex = 158
        Me.btnGuardar.Text = "Button1"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        'Me.btnCerrar.Image = My.Resources.resMain.delete1
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(332, 117)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(86, 28)
        Me.btnCerrar.TabIndex = 159
        Me.btnCerrar.Text = "Button2"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'frmMsIndiceLiquidez
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(430, 153)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "frmMsIndiceLiquidez"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtIndice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAnnio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblEncabezado As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbMes As System.Windows.Forms.ComboBox
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents nudAnnio As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblAnnio As System.Windows.Forms.Label
    Friend WithEvents lblIndice As System.Windows.Forms.Label
    Friend WithEvents txtIndice As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
End Class
