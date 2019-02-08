<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMBCSaldosBancos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.dgSaldos = New System.Windows.Forms.DataGridView
        Me.pnBotones = New System.Windows.Forms.Panel
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnConsultar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnAgregarCta = New System.Windows.Forms.Button
        Me.btnActualizarGrid = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.dgSaldos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(318, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Consulta de Saldos en Ctas. de Banco"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(687, 23)
        Me.Panel1.TabIndex = 1
        '
        'dgSaldos
        '
        Me.dgSaldos.AllowUserToAddRows = False
        Me.dgSaldos.AllowUserToDeleteRows = False
        Me.dgSaldos.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgSaldos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgSaldos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgSaldos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgSaldos.Location = New System.Drawing.Point(8, 67)
        Me.dgSaldos.Name = "dgSaldos"
        Me.dgSaldos.ReadOnly = True
        Me.dgSaldos.Size = New System.Drawing.Size(667, 273)
        Me.dgSaldos.TabIndex = 2
        '
        'pnBotones
        '
        Me.pnBotones.Controls.Add(Me.btnEliminar)
        Me.pnBotones.Controls.Add(Me.btnConsultar)
        Me.pnBotones.Controls.Add(Me.btnModificar)
        Me.pnBotones.Controls.Add(Me.btnAgregarCta)
        Me.pnBotones.Location = New System.Drawing.Point(8, 345)
        Me.pnBotones.Name = "pnBotones"
        Me.pnBotones.Size = New System.Drawing.Size(667, 37)
        Me.pnBotones.TabIndex = 3
        '
        'btnEliminar
        '
        Me.btnEliminar.Image = My.Resources.resMain._001_051
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEliminar.Location = New System.Drawing.Point(264, 0)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(80, 29)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Image = My.Resources.resMain._001_38
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(177, 1)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(81, 29)
        Me.btnConsultar.TabIndex = 2
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Image = My.Resources.resMain._001_45
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(91, 1)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(80, 29)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregarCta
        '
        Me.btnAgregarCta.Image = My.Resources.resMain._001_03
        Me.btnAgregarCta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAgregarCta.Location = New System.Drawing.Point(3, 1)
        Me.btnAgregarCta.Name = "btnAgregarCta"
        Me.btnAgregarCta.Size = New System.Drawing.Size(82, 29)
        Me.btnAgregarCta.TabIndex = 0
        Me.btnAgregarCta.Text = "Agregar"
        Me.btnAgregarCta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAgregarCta.UseVisualStyleBackColor = True
        '
        'btnActualizarGrid
        '
        Me.btnActualizarGrid.Image = My.Resources.resMain._001_39
        Me.btnActualizarGrid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnActualizarGrid.Location = New System.Drawing.Point(8, 33)
        Me.btnActualizarGrid.Name = "btnActualizarGrid"
        Me.btnActualizarGrid.Size = New System.Drawing.Size(85, 29)
        Me.btnActualizarGrid.TabIndex = 4
        Me.btnActualizarGrid.Text = "Actualizar"
        Me.btnActualizarGrid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnActualizarGrid.UseVisualStyleBackColor = True
        '
        'frmMBCSaldosBancos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(687, 383)
        Me.Controls.Add(Me.btnActualizarGrid)
        Me.Controls.Add(Me.pnBotones)
        Me.Controls.Add(Me.dgSaldos)
        Me.Controls.Add(Me.Panel1)
        Me.MaximumSize = New System.Drawing.Size(703, 450)
        Me.Name = "frmMBCSaldosBancos"
        Me.Text = "Saldos Bancos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgSaldos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnBotones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgSaldos As System.Windows.Forms.DataGridView
    Friend WithEvents pnBotones As System.Windows.Forms.Panel
    Friend WithEvents btnAgregarCta As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnActualizarGrid As System.Windows.Forms.Button
End Class
