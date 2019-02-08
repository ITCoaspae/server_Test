<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsRutasMercadeo
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblEncabezado = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cbTipoEvento = New System.Windows.Forms.ComboBox
        Me.lblProducto = New System.Windows.Forms.Label
        Me.txtComprobante = New System.Windows.Forms.TextBox
        Me.lblComprobante = New System.Windows.Forms.Label
        Me.txtDui = New C1.Win.C1Input.C1TextBox
        Me.lblDui = New System.Windows.Forms.Label
        Me.chkAsociado = New System.Windows.Forms.CheckBox
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.txtTel = New System.Windows.Forms.MaskedTextBox
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.txtCorreo = New System.Windows.Forms.TextBox
        Me.lblCorreo = New System.Windows.Forms.Label
        Me.gbVisitarRealizadas = New System.Windows.Forms.GroupBox
        Me.dgVisitas = New System.Windows.Forms.DataGridView
        Me.cbGestion = New System.Windows.Forms.ComboBox
        Me.lblGestion = New System.Windows.Forms.Label
        Me.txtObs = New System.Windows.Forms.TextBox
        Me.lblObs = New System.Windows.Forms.Label
        Me.cbProducto = New System.Windows.Forms.ComboBox
        Me.lblActividad = New System.Windows.Forms.Label
        Me.cbLugarTrabajo = New System.Windows.Forms.ComboBox
        Me.lblLugarTrabajo = New System.Windows.Forms.Label
        Me.lblTelCliente = New System.Windows.Forms.Label
        Me.dtpFechaVis = New System.Windows.Forms.DateTimePicker
        Me.txtNombreCliente = New System.Windows.Forms.TextBox
        Me.lblNombreCliente = New System.Windows.Forms.Label
        Me.lblFechaVisita = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbVisitarRealizadas.SuspendLayout()
        CType(Me.dgVisitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblEncabezado)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(607, 33)
        Me.Panel1.TabIndex = 158
        '
        'lblEncabezado
        '
        Me.lblEncabezado.AutoSize = True
        Me.lblEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezado.ForeColor = System.Drawing.Color.White
        Me.lblEncabezado.Location = New System.Drawing.Point(3, 6)
        Me.lblEncabezado.Name = "lblEncabezado"
        Me.lblEncabezado.Size = New System.Drawing.Size(298, 24)
        Me.lblEncabezado.TabIndex = 0
        Me.lblEncabezado.Text = "Ingreso de Rutas de Mercadeo"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel3.Controls.Add(Me.cbTipoEvento)
        Me.Panel3.Controls.Add(Me.lblProducto)
        Me.Panel3.Controls.Add(Me.txtComprobante)
        Me.Panel3.Controls.Add(Me.lblComprobante)
        Me.Panel3.Controls.Add(Me.txtDui)
        Me.Panel3.Controls.Add(Me.lblDui)
        Me.Panel3.Controls.Add(Me.chkAsociado)
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Controls.Add(Me.txtTel)
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Controls.Add(Me.txtCorreo)
        Me.Panel3.Controls.Add(Me.lblCorreo)
        Me.Panel3.Controls.Add(Me.gbVisitarRealizadas)
        Me.Panel3.Controls.Add(Me.cbGestion)
        Me.Panel3.Controls.Add(Me.lblGestion)
        Me.Panel3.Controls.Add(Me.txtObs)
        Me.Panel3.Controls.Add(Me.lblObs)
        Me.Panel3.Controls.Add(Me.cbProducto)
        Me.Panel3.Controls.Add(Me.lblActividad)
        Me.Panel3.Controls.Add(Me.cbLugarTrabajo)
        Me.Panel3.Controls.Add(Me.lblLugarTrabajo)
        Me.Panel3.Controls.Add(Me.lblTelCliente)
        Me.Panel3.Controls.Add(Me.dtpFechaVis)
        Me.Panel3.Controls.Add(Me.txtNombreCliente)
        Me.Panel3.Controls.Add(Me.lblNombreCliente)
        Me.Panel3.Controls.Add(Me.lblFechaVisita)
        Me.Panel3.Location = New System.Drawing.Point(12, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(580, 457)
        Me.Panel3.TabIndex = 168
        '
        'cbTipoEvento
        '
        Me.cbTipoEvento.BackColor = System.Drawing.Color.Khaki
        Me.cbTipoEvento.FormattingEnabled = True
        Me.cbTipoEvento.Location = New System.Drawing.Point(83, 135)
        Me.cbTipoEvento.Name = "cbTipoEvento"
        Me.cbTipoEvento.Size = New System.Drawing.Size(215, 21)
        Me.cbTipoEvento.TabIndex = 26
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(304, 141)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 25
        Me.lblProducto.Text = "Producto"
        Me.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtComprobante
        '
        Me.txtComprobante.BackColor = System.Drawing.Color.Khaki
        Me.txtComprobante.Location = New System.Drawing.Point(381, 165)
        Me.txtComprobante.Name = "txtComprobante"
        Me.txtComprobante.ReadOnly = True
        Me.txtComprobante.Size = New System.Drawing.Size(190, 20)
        Me.txtComprobante.TabIndex = 24
        '
        'lblComprobante
        '
        Me.lblComprobante.AutoSize = True
        Me.lblComprobante.Location = New System.Drawing.Point(304, 167)
        Me.lblComprobante.Name = "lblComprobante"
        Me.lblComprobante.Size = New System.Drawing.Size(70, 13)
        Me.lblComprobante.TabIndex = 23
        Me.lblComprobante.Text = "Comprobante"
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.Khaki
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(83, 33)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(96, 20)
        Me.txtDui.TabIndex = 22
        Me.txtDui.Tag = Nothing
        Me.txtDui.Value = ""
        '
        'lblDui
        '
        Me.lblDui.AutoSize = True
        Me.lblDui.Location = New System.Drawing.Point(13, 33)
        Me.lblDui.Name = "lblDui"
        Me.lblDui.Size = New System.Drawing.Size(29, 13)
        Me.lblDui.TabIndex = 21
        Me.lblDui.Text = "DUI:"
        '
        'chkAsociado
        '
        Me.chkAsociado.AutoSize = True
        Me.chkAsociado.Location = New System.Drawing.Point(16, 10)
        Me.chkAsociado.Name = "chkAsociado"
        Me.chkAsociado.Size = New System.Drawing.Size(85, 17)
        Me.chkAsociado.TabIndex = 20
        Me.chkAsociado.Text = "Es Asociado"
        Me.chkAsociado.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Image = Global.SysFinCoop.resMain.delete1
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCerrar.Location = New System.Drawing.Point(492, 419)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 28)
        Me.btnCerrar.TabIndex = 19
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'txtTel
        '
        Me.txtTel.BackColor = System.Drawing.Color.Khaki
        Me.txtTel.Location = New System.Drawing.Point(83, 85)
        Me.txtTel.Mask = "0000-0000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(215, 20)
        Me.txtTel.TabIndex = 4
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Global.SysFinCoop.resMain.save2
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(404, 419)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(82, 28)
        Me.btnGuardar.TabIndex = 18
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.Khaki
        Me.txtCorreo.Location = New System.Drawing.Point(356, 85)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(215, 20)
        Me.txtCorreo.TabIndex = 6
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(304, 85)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(41, 13)
        Me.lblCorreo.TabIndex = 5
        Me.lblCorreo.Text = "Correo:"
        '
        'gbVisitarRealizadas
        '
        Me.gbVisitarRealizadas.Controls.Add(Me.dgVisitas)
        Me.gbVisitarRealizadas.Location = New System.Drawing.Point(10, 288)
        Me.gbVisitarRealizadas.Name = "gbVisitarRealizadas"
        Me.gbVisitarRealizadas.Size = New System.Drawing.Size(561, 125)
        Me.gbVisitarRealizadas.TabIndex = 14
        Me.gbVisitarRealizadas.TabStop = False
        Me.gbVisitarRealizadas.Text = "Visitas Realizadas"
        '
        'dgVisitas
        '
        Me.dgVisitas.AllowUserToAddRows = False
        Me.dgVisitas.AllowUserToDeleteRows = False
        Me.dgVisitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVisitas.Location = New System.Drawing.Point(6, 19)
        Me.dgVisitas.Name = "dgVisitas"
        Me.dgVisitas.ReadOnly = True
        Me.dgVisitas.Size = New System.Drawing.Size(549, 89)
        Me.dgVisitas.TabIndex = 17
        '
        'cbGestion
        '
        Me.cbGestion.BackColor = System.Drawing.Color.Khaki
        Me.cbGestion.FormattingEnabled = True
        Me.cbGestion.Location = New System.Drawing.Point(83, 164)
        Me.cbGestion.Name = "cbGestion"
        Me.cbGestion.Size = New System.Drawing.Size(215, 21)
        Me.cbGestion.TabIndex = 12
        '
        'lblGestion
        '
        Me.lblGestion.AutoSize = True
        Me.lblGestion.Location = New System.Drawing.Point(13, 167)
        Me.lblGestion.Name = "lblGestion"
        Me.lblGestion.Size = New System.Drawing.Size(46, 13)
        Me.lblGestion.TabIndex = 11
        Me.lblGestion.Text = "Gestión:"
        '
        'txtObs
        '
        Me.txtObs.BackColor = System.Drawing.Color.Khaki
        Me.txtObs.Location = New System.Drawing.Point(16, 205)
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.Size = New System.Drawing.Size(555, 77)
        Me.txtObs.TabIndex = 16
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Location = New System.Drawing.Point(13, 189)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(70, 13)
        Me.lblObs.TabIndex = 15
        Me.lblObs.Text = "Observación:"
        '
        'cbProducto
        '
        Me.cbProducto.BackColor = System.Drawing.Color.Khaki
        Me.cbProducto.FormattingEnabled = True
        Me.cbProducto.Location = New System.Drawing.Point(381, 135)
        Me.cbProducto.Name = "cbProducto"
        Me.cbProducto.Size = New System.Drawing.Size(190, 21)
        Me.cbProducto.TabIndex = 10
        '
        'lblActividad
        '
        Me.lblActividad.AutoSize = True
        Me.lblActividad.Location = New System.Drawing.Point(13, 141)
        Me.lblActividad.Name = "lblActividad"
        Me.lblActividad.Size = New System.Drawing.Size(54, 13)
        Me.lblActividad.TabIndex = 9
        Me.lblActividad.Text = "Actividad:"
        '
        'cbLugarTrabajo
        '
        Me.cbLugarTrabajo.BackColor = System.Drawing.Color.Khaki
        Me.cbLugarTrabajo.FormattingEnabled = True
        Me.cbLugarTrabajo.Location = New System.Drawing.Point(83, 108)
        Me.cbLugarTrabajo.Name = "cbLugarTrabajo"
        Me.cbLugarTrabajo.Size = New System.Drawing.Size(488, 21)
        Me.cbLugarTrabajo.TabIndex = 8
        '
        'lblLugarTrabajo
        '
        Me.lblLugarTrabajo.AutoSize = True
        Me.lblLugarTrabajo.Location = New System.Drawing.Point(13, 111)
        Me.lblLugarTrabajo.Name = "lblLugarTrabajo"
        Me.lblLugarTrabajo.Size = New System.Drawing.Size(52, 26)
        Me.lblLugarTrabajo.TabIndex = 7
        Me.lblLugarTrabajo.Text = "Lugar de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Trabajo:"
        '
        'lblTelCliente
        '
        Me.lblTelCliente.AutoSize = True
        Me.lblTelCliente.Location = New System.Drawing.Point(13, 92)
        Me.lblTelCliente.Name = "lblTelCliente"
        Me.lblTelCliente.Size = New System.Drawing.Size(49, 13)
        Me.lblTelCliente.TabIndex = 3
        Me.lblTelCliente.Text = "Teléfono"
        '
        'dtpFechaVis
        '
        Me.dtpFechaVis.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVis.Location = New System.Drawing.Point(275, 33)
        Me.dtpFechaVis.Name = "dtpFechaVis"
        Me.dtpFechaVis.Size = New System.Drawing.Size(99, 20)
        Me.dtpFechaVis.TabIndex = 14
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.BackColor = System.Drawing.Color.Khaki
        Me.txtNombreCliente.Location = New System.Drawing.Point(83, 59)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(488, 20)
        Me.txtNombreCliente.TabIndex = 2
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(13, 59)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(64, 26)
        Me.lblNombreCliente.TabIndex = 1
        Me.lblNombreCliente.Text = "Nombre del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cliente:"
        '
        'lblFechaVisita
        '
        Me.lblFechaVisita.AutoSize = True
        Me.lblFechaVisita.Location = New System.Drawing.Point(185, 33)
        Me.lblFechaVisita.Name = "lblFechaVisita"
        Me.lblFechaVisita.Size = New System.Drawing.Size(83, 13)
        Me.lblFechaVisita.TabIndex = 13
        Me.lblFechaVisita.Text = "Fecha de Visita:"
        '
        'frmMsRutasMercadeo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(604, 507)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMsRutasMercadeo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbVisitarRealizadas.ResumeLayout(False)
        CType(Me.dgVisitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblEncabezado As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblFechaVisita As System.Windows.Forms.Label
    Friend WithEvents lblLugarTrabajo As System.Windows.Forms.Label
    Friend WithEvents lblTelCliente As System.Windows.Forms.Label
    Friend WithEvents dtpFechaVis As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
    Friend WithEvents cbLugarTrabajo As System.Windows.Forms.ComboBox
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents lblObs As System.Windows.Forms.Label
    Friend WithEvents cbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents lblActividad As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents cbGestion As System.Windows.Forms.ComboBox
    Friend WithEvents lblGestion As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents gbVisitarRealizadas As System.Windows.Forms.GroupBox
    Friend WithEvents dgVisitas As System.Windows.Forms.DataGridView
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents chkAsociado As System.Windows.Forms.CheckBox
    Friend WithEvents lblDui As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtComprobante As System.Windows.Forms.TextBox
    Friend WithEvents lblComprobante As System.Windows.Forms.Label
    Friend WithEvents cbTipoEvento As System.Windows.Forms.ComboBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
End Class
