<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsGrConsultarAnotaciones_Garantias
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblENC_CERTIFICACIONES = New System.Windows.Forms.Label()
        Me.dgCERTIFICACIONES = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.lblENC_Garantias = New System.Windows.Forms.Label()
        Me.dgGARANTIAS = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        CType(Me.dgCERTIFICACIONES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgGARANTIAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblENC_CERTIFICACIONES
        '
        Me.lblENC_CERTIFICACIONES.AutoSize = True
        Me.lblENC_CERTIFICACIONES.ForeColor = System.Drawing.Color.Teal
        Me.lblENC_CERTIFICACIONES.Location = New System.Drawing.Point(4, 11)
        Me.lblENC_CERTIFICACIONES.Name = "lblENC_CERTIFICACIONES"
        Me.lblENC_CERTIFICACIONES.Size = New System.Drawing.Size(258, 13)
        Me.lblENC_CERTIFICACIONES.TabIndex = 4
        Me.lblENC_CERTIFICACIONES.Text = "Certificaciones pendientes de asignación de garantía"
        '
        'dgCERTIFICACIONES
        '
        Me.dgCERTIFICACIONES.AllowUserToAddRows = False
        Me.dgCERTIFICACIONES.AllowUserToDeleteRows = False
        Me.dgCERTIFICACIONES.AllowUserToOrderColumns = True
        Me.dgCERTIFICACIONES.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCERTIFICACIONES.BackgroundColor = System.Drawing.Color.Silver
        Me.dgCERTIFICACIONES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCERTIFICACIONES.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgCERTIFICACIONES.Location = New System.Drawing.Point(7, 45)
        Me.dgCERTIFICACIONES.Name = "dgCERTIFICACIONES"
        Me.dgCERTIFICACIONES.ReadOnly = True
        Me.dgCERTIFICACIONES.Size = New System.Drawing.Size(666, 100)
        Me.dgCERTIFICACIONES.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.btnGuardar1)
        Me.Panel2.Controls.Add(Me.lblENC_CERTIFICACIONES)
        Me.Panel2.Controls.Add(Me.dgCERTIFICACIONES)
        Me.Panel2.Location = New System.Drawing.Point(23, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(682, 156)
        Me.Panel2.TabIndex = 2
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(598, 11)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 235
        Me.btnGuardar1.Text = "&Consultar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'lblENC_Garantias
        '
        Me.lblENC_Garantias.AutoSize = True
        Me.lblENC_Garantias.ForeColor = System.Drawing.Color.Teal
        Me.lblENC_Garantias.Location = New System.Drawing.Point(4, 17)
        Me.lblENC_Garantias.Name = "lblENC_Garantias"
        Me.lblENC_Garantias.Size = New System.Drawing.Size(179, 13)
        Me.lblENC_Garantias.TabIndex = 9
        Me.lblENC_Garantias.Text = "Garantias asignadas a la solicitud N°"
        '
        'dgGARANTIAS
        '
        Me.dgGARANTIAS.AllowUserToAddRows = False
        Me.dgGARANTIAS.AllowUserToDeleteRows = False
        Me.dgGARANTIAS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgGARANTIAS.BackgroundColor = System.Drawing.Color.Silver
        Me.dgGARANTIAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgGARANTIAS.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgGARANTIAS.Location = New System.Drawing.Point(7, 52)
        Me.dgGARANTIAS.Name = "dgGARANTIAS"
        Me.dgGARANTIAS.ReadOnly = True
        Me.dgGARANTIAS.Size = New System.Drawing.Size(666, 100)
        Me.dgGARANTIAS.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.MetroButton1)
        Me.Panel1.Controls.Add(Me.MetroButton2)
        Me.Panel1.Controls.Add(Me.MetroButton3)
        Me.Panel1.Controls.Add(Me.lblENC_Garantias)
        Me.Panel1.Controls.Add(Me.dgGARANTIAS)
        Me.Panel1.Location = New System.Drawing.Point(23, 225)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(682, 169)
        Me.Panel1.TabIndex = 3
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(436, 18)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 236
        Me.MetroButton1.Text = "&Consultar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(517, 18)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 237
        Me.MetroButton2.Text = "&Modificar"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(598, 18)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 238
        Me.MetroButton3.Text = "&Eliminar"
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'frmsGrConsultarAnotaciones_Garantias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(723, 432)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(723, 432)
        Me.MinimizeBox = False
        Me.Name = "frmsGrConsultarAnotaciones_Garantias"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Control de Garantías"
        CType(Me.dgCERTIFICACIONES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgGARANTIAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgCERTIFICACIONES As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgGARANTIAS As System.Windows.Forms.DataGridView
    Friend WithEvents lblENC_CERTIFICACIONES As System.Windows.Forms.Label
    Friend WithEvents lblENC_Garantias As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
End Class
