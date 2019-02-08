<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCBGestionMora
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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnAnular = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtDui = New C1.Win.C1Input.C1TextBox
        Me.rbTodos = New System.Windows.Forms.RadioButton
        Me.txtPrestamo = New System.Windows.Forms.TextBox
        Me.btnMostrar = New System.Windows.Forms.Button
        Me.rbPrestamo = New System.Windows.Forms.RadioButton
        Me.rbDUI = New System.Windows.Forms.RadioButton
        Me.dgServiciosCoopas = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgServiciosCoopas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblEncabezado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(843, 33)
        Me.Panel1.TabIndex = 160
        '
        'lblEncabezado
        '
        Me.lblEncabezado.AutoSize = True
        Me.lblEncabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncabezado.ForeColor = System.Drawing.Color.White
        Me.lblEncabezado.Location = New System.Drawing.Point(3, 6)
        Me.lblEncabezado.Name = "lblEncabezado"
        Me.lblEncabezado.Size = New System.Drawing.Size(193, 24)
        Me.lblEncabezado.TabIndex = 0
        Me.lblEncabezado.Text = "Gestiones por Mora"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnAnular)
        Me.Panel2.Controls.Add(Me.btnAgregar)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Location = New System.Drawing.Point(13, 305)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(512, 48)
        Me.Panel2.TabIndex = 161
        '
        'btnAnular
        '
        Me.btnAnular.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnular.ForeColor = System.Drawing.Color.White
        Me.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnular.Location = New System.Drawing.Point(181, 12)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(75, 28)
        Me.btnAnular.TabIndex = 3
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAnular.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.ForeColor = System.Drawing.Color.White
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregar.Location = New System.Drawing.Point(6, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(87, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(86, 28)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Teal
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.rbTodos)
        Me.GroupBox2.Controls.Add(Me.txtPrestamo)
        Me.GroupBox2.Controls.Add(Me.btnMostrar)
        Me.GroupBox2.Controls.Add(Me.rbPrestamo)
        Me.GroupBox2.Controls.Add(Me.rbDUI)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(660, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(176, 312)
        Me.GroupBox2.TabIndex = 162
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar Gestiones por:"
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.Khaki
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Enabled = False
        Me.txtDui.Location = New System.Drawing.Point(14, 50)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(152, 20)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'rbTodos
        '
        Me.rbTodos.BackColor = System.Drawing.Color.Teal
        Me.rbTodos.Checked = True
        Me.rbTodos.Location = New System.Drawing.Point(16, 141)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(152, 24)
        Me.rbTodos.TabIndex = 4
        Me.rbTodos.TabStop = True
        Me.rbTodos.Text = "Todos"
        Me.rbTodos.UseVisualStyleBackColor = False
        '
        'txtPrestamo
        '
        Me.txtPrestamo.Enabled = False
        Me.txtPrestamo.Location = New System.Drawing.Point(16, 112)
        Me.txtPrestamo.Name = "txtPrestamo"
        Me.txtPrestamo.Size = New System.Drawing.Size(152, 20)
        Me.txtPrestamo.TabIndex = 3
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar.Location = New System.Drawing.Point(40, 236)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(112, 24)
        Me.btnMostrar.TabIndex = 6
        Me.btnMostrar.Text = "Mos&trar"
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'rbPrestamo
        '
        Me.rbPrestamo.BackColor = System.Drawing.Color.Teal
        Me.rbPrestamo.Location = New System.Drawing.Point(16, 80)
        Me.rbPrestamo.Name = "rbPrestamo"
        Me.rbPrestamo.Size = New System.Drawing.Size(152, 24)
        Me.rbPrestamo.TabIndex = 2
        Me.rbPrestamo.Text = "&Prestamo"
        Me.rbPrestamo.UseVisualStyleBackColor = False
        '
        'rbDUI
        '
        Me.rbDUI.BackColor = System.Drawing.Color.Teal
        Me.rbDUI.Location = New System.Drawing.Point(16, 19)
        Me.rbDUI.Name = "rbDUI"
        Me.rbDUI.Size = New System.Drawing.Size(152, 24)
        Me.rbDUI.TabIndex = 0
        Me.rbDUI.Text = "&DUI"
        Me.rbDUI.UseVisualStyleBackColor = False
        '
        'dgServiciosCoopas
        '
        Me.dgServiciosCoopas.AllowUserToAddRows = False
        Me.dgServiciosCoopas.AllowUserToDeleteRows = False
        Me.dgServiciosCoopas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgServiciosCoopas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgServiciosCoopas.Location = New System.Drawing.Point(15, 36)
        Me.dgServiciosCoopas.Name = "dgServiciosCoopas"
        Me.dgServiciosCoopas.ReadOnly = True
        Me.dgServiciosCoopas.Size = New System.Drawing.Size(625, 263)
        Me.dgServiciosCoopas.TabIndex = 163
        '
        'frmCBGestionMora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 359)
        Me.Controls.Add(Me.dgServiciosCoopas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmCBGestionMora"
        Me.Text = "frmCBGestionMora"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgServiciosCoopas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblEncabezado As System.Windows.Forms.Label
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbTodos As System.Windows.Forms.RadioButton
    Friend WithEvents txtPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents rbPrestamo As System.Windows.Forms.RadioButton
    Friend WithEvents rbDUI As System.Windows.Forms.RadioButton
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgServiciosCoopas As System.Windows.Forms.DataGridView

    Private Sub btnMostrar_ChangeUICues(ByVal sender As Object, ByVal e As System.Windows.Forms.UICuesEventArgs) Handles btnMostrar.ChangeUICues

    End Sub
End Class
