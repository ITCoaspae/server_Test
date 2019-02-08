<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsGrConsultarCertificaciones_Anotacion
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
        Me.dgCERTIFICACIONES = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblPlazo = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblConcedido = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAGREGAR1 = New MetroFramework.Controls.MetroButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnELIMINAR1 = New MetroFramework.Controls.MetroButton()
        Me.btnMODIFICAR1 = New MetroFramework.Controls.MetroButton()
        Me.btnCONSULTAR1 = New MetroFramework.Controls.MetroButton()
        Me.lblENCANOTACION = New System.Windows.Forms.Label()
        Me.dgANOTACIONPREV = New System.Windows.Forms.DataGridView()
        CType(Me.dgCERTIFICACIONES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgANOTACIONPREV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCERTIFICACIONES
        '
        Me.dgCERTIFICACIONES.AllowUserToAddRows = False
        Me.dgCERTIFICACIONES.AllowUserToDeleteRows = False
        Me.dgCERTIFICACIONES.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCERTIFICACIONES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCERTIFICACIONES.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgCERTIFICACIONES.Location = New System.Drawing.Point(3, 60)
        Me.dgCERTIFICACIONES.Name = "dgCERTIFICACIONES"
        Me.dgCERTIFICACIONES.ReadOnly = True
        Me.dgCERTIFICACIONES.Size = New System.Drawing.Size(629, 88)
        Me.dgCERTIFICACIONES.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.Window
        Me.GroupBox4.Controls.Add(Me.lblPlazo)
        Me.GroupBox4.Controls.Add(Me.lblMonto)
        Me.GroupBox4.Controls.Add(Me.lblConcedido)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(632, 38)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'lblPlazo
        '
        Me.lblPlazo.Location = New System.Drawing.Point(552, 16)
        Me.lblPlazo.Name = "lblPlazo"
        Me.lblPlazo.Size = New System.Drawing.Size(64, 16)
        Me.lblPlazo.TabIndex = 3
        Me.lblPlazo.Text = "Plazo:"
        '
        'lblMonto
        '
        Me.lblMonto.Location = New System.Drawing.Point(416, 16)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(120, 16)
        Me.lblMonto.TabIndex = 2
        Me.lblMonto.Text = "Monto:"
        '
        'lblConcedido
        '
        Me.lblConcedido.Location = New System.Drawing.Point(8, 16)
        Me.lblConcedido.Name = "lblConcedido"
        Me.lblConcedido.Size = New System.Drawing.Size(400, 16)
        Me.lblConcedido.TabIndex = 1
        Me.lblConcedido.Text = "Crédito concedido a:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.btnAGREGAR1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgCERTIFICACIONES)
        Me.Panel1.Location = New System.Drawing.Point(23, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(635, 151)
        Me.Panel1.TabIndex = 5
        '
        'btnAGREGAR1
        '
        Me.btnAGREGAR1.Location = New System.Drawing.Point(161, 26)
        Me.btnAGREGAR1.Name = "btnAGREGAR1"
        Me.btnAGREGAR1.Size = New System.Drawing.Size(75, 28)
        Me.btnAGREGAR1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAGREGAR1.TabIndex = 222
        Me.btnAGREGAR1.Text = "&Agregar"
        Me.btnAGREGAR1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAGREGAR1.UseSelectable = True
        Me.btnAGREGAR1.UseStyleColors = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(377, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Certificaciones Extractadas pendientes de asignación de anotación preventiva"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Agregar anotación preventiva"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.btnELIMINAR1)
        Me.Panel2.Controls.Add(Me.btnMODIFICAR1)
        Me.Panel2.Controls.Add(Me.btnCONSULTAR1)
        Me.Panel2.Controls.Add(Me.lblENCANOTACION)
        Me.Panel2.Controls.Add(Me.dgANOTACIONPREV)
        Me.Panel2.Location = New System.Drawing.Point(23, 264)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(632, 173)
        Me.Panel2.TabIndex = 6
        '
        'btnELIMINAR1
        '
        Me.btnELIMINAR1.Location = New System.Drawing.Point(173, 26)
        Me.btnELIMINAR1.Name = "btnELIMINAR1"
        Me.btnELIMINAR1.Size = New System.Drawing.Size(75, 28)
        Me.btnELIMINAR1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnELIMINAR1.TabIndex = 225
        Me.btnELIMINAR1.Text = "&Eliminar"
        Me.btnELIMINAR1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnELIMINAR1.UseSelectable = True
        Me.btnELIMINAR1.UseStyleColors = True
        '
        'btnMODIFICAR1
        '
        Me.btnMODIFICAR1.Location = New System.Drawing.Point(92, 26)
        Me.btnMODIFICAR1.Name = "btnMODIFICAR1"
        Me.btnMODIFICAR1.Size = New System.Drawing.Size(75, 28)
        Me.btnMODIFICAR1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMODIFICAR1.TabIndex = 224
        Me.btnMODIFICAR1.Text = "&Modificar"
        Me.btnMODIFICAR1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMODIFICAR1.UseSelectable = True
        Me.btnMODIFICAR1.UseStyleColors = True
        '
        'btnCONSULTAR1
        '
        Me.btnCONSULTAR1.Location = New System.Drawing.Point(11, 26)
        Me.btnCONSULTAR1.Name = "btnCONSULTAR1"
        Me.btnCONSULTAR1.Size = New System.Drawing.Size(75, 28)
        Me.btnCONSULTAR1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCONSULTAR1.TabIndex = 223
        Me.btnCONSULTAR1.Text = "&Consultar"
        Me.btnCONSULTAR1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCONSULTAR1.UseSelectable = True
        Me.btnCONSULTAR1.UseStyleColors = True
        '
        'lblENCANOTACION
        '
        Me.lblENCANOTACION.AutoSize = True
        Me.lblENCANOTACION.Location = New System.Drawing.Point(10, 10)
        Me.lblENCANOTACION.Name = "lblENCANOTACION"
        Me.lblENCANOTACION.Size = New System.Drawing.Size(254, 13)
        Me.lblENCANOTACION.TabIndex = 6
        Me.lblENCANOTACION.Text = "Anotaciones preventivas asignadas a la solicitud N° "
        '
        'dgANOTACIONPREV
        '
        Me.dgANOTACIONPREV.AllowUserToAddRows = False
        Me.dgANOTACIONPREV.AllowUserToDeleteRows = False
        Me.dgANOTACIONPREV.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgANOTACIONPREV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgANOTACIONPREV.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgANOTACIONPREV.GridColor = System.Drawing.Color.Gainsboro
        Me.dgANOTACIONPREV.Location = New System.Drawing.Point(3, 66)
        Me.dgANOTACIONPREV.Name = "dgANOTACIONPREV"
        Me.dgANOTACIONPREV.ReadOnly = True
        Me.dgANOTACIONPREV.Size = New System.Drawing.Size(626, 88)
        Me.dgANOTACIONPREV.TabIndex = 0
        '
        'frmMsGrConsultarCertificaciones_Anotacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(681, 485)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(681, 485)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(681, 485)
        Me.Name = "frmMsGrConsultarCertificaciones_Anotacion"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consultar Certificaciones Anotación Preventiva"
        CType(Me.dgCERTIFICACIONES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgANOTACIONPREV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgCERTIFICACIONES As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPlazo As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblConcedido As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents dgANOTACIONPREV As System.Windows.Forms.DataGridView
    Friend WithEvents lblENCANOTACION As System.Windows.Forms.Label
    Friend WithEvents btnAGREGAR1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnELIMINAR1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMODIFICAR1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCONSULTAR1 As MetroFramework.Controls.MetroButton
End Class
