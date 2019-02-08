<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMNotarios
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelFiltros = New System.Windows.Forms.Panel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtAPELLIDO2 = New System.Windows.Forms.TextBox()
        Me.txtAPELLIDO1 = New System.Windows.Forms.TextBox()
        Me.txtNOMBRES = New System.Windows.Forms.TextBox()
        Me.txtIDNOTARIO = New System.Windows.Forms.TextBox()
        Me.rbAPELLIDO2 = New System.Windows.Forms.RadioButton()
        Me.rbApellido1 = New System.Windows.Forms.RadioButton()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.rbIdNotario = New System.Windows.Forms.RadioButton()
        Me.dgNOTARIOS = New System.Windows.Forms.DataGridView()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.PanelFiltros.SuspendLayout()
        CType(Me.dgNOTARIOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelFiltros
        '
        Me.PanelFiltros.BackColor = System.Drawing.SystemColors.Window
        Me.PanelFiltros.Controls.Add(Me.MetroButton1)
        Me.PanelFiltros.Controls.Add(Me.txtAPELLIDO2)
        Me.PanelFiltros.Controls.Add(Me.txtAPELLIDO1)
        Me.PanelFiltros.Controls.Add(Me.txtNOMBRES)
        Me.PanelFiltros.Controls.Add(Me.txtIDNOTARIO)
        Me.PanelFiltros.Controls.Add(Me.rbAPELLIDO2)
        Me.PanelFiltros.Controls.Add(Me.rbApellido1)
        Me.PanelFiltros.Controls.Add(Me.rbNombres)
        Me.PanelFiltros.Controls.Add(Me.rbIdNotario)
        Me.PanelFiltros.Location = New System.Drawing.Point(23, 63)
        Me.PanelFiltros.Name = "PanelFiltros"
        Me.PanelFiltros.Size = New System.Drawing.Size(562, 129)
        Me.PanelFiltros.TabIndex = 2
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(454, 92)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 76
        Me.MetroButton1.Text = "Buscar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'txtAPELLIDO2
        '
        Me.txtAPELLIDO2.Location = New System.Drawing.Point(376, 66)
        Me.txtAPELLIDO2.Name = "txtAPELLIDO2"
        Me.txtAPELLIDO2.Size = New System.Drawing.Size(153, 20)
        Me.txtAPELLIDO2.TabIndex = 8
        '
        'txtAPELLIDO1
        '
        Me.txtAPELLIDO1.Location = New System.Drawing.Point(103, 66)
        Me.txtAPELLIDO1.Name = "txtAPELLIDO1"
        Me.txtAPELLIDO1.Size = New System.Drawing.Size(153, 20)
        Me.txtAPELLIDO1.TabIndex = 7
        '
        'txtNOMBRES
        '
        Me.txtNOMBRES.Location = New System.Drawing.Point(103, 40)
        Me.txtNOMBRES.Name = "txtNOMBRES"
        Me.txtNOMBRES.Size = New System.Drawing.Size(426, 20)
        Me.txtNOMBRES.TabIndex = 6
        '
        'txtIDNOTARIO
        '
        Me.txtIDNOTARIO.Location = New System.Drawing.Point(103, 14)
        Me.txtIDNOTARIO.Name = "txtIDNOTARIO"
        Me.txtIDNOTARIO.Size = New System.Drawing.Size(125, 20)
        Me.txtIDNOTARIO.TabIndex = 5
        '
        'rbAPELLIDO2
        '
        Me.rbAPELLIDO2.AutoSize = True
        Me.rbAPELLIDO2.Location = New System.Drawing.Point(262, 67)
        Me.rbAPELLIDO2.Name = "rbAPELLIDO2"
        Me.rbAPELLIDO2.Size = New System.Drawing.Size(108, 17)
        Me.rbAPELLIDO2.TabIndex = 3
        Me.rbAPELLIDO2.TabStop = True
        Me.rbAPELLIDO2.Text = "Segundo Apellido"
        Me.rbAPELLIDO2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbAPELLIDO2.UseVisualStyleBackColor = True
        '
        'rbApellido1
        '
        Me.rbApellido1.AutoSize = True
        Me.rbApellido1.Location = New System.Drawing.Point(9, 69)
        Me.rbApellido1.Name = "rbApellido1"
        Me.rbApellido1.Size = New System.Drawing.Size(94, 17)
        Me.rbApellido1.TabIndex = 2
        Me.rbApellido1.TabStop = True
        Me.rbApellido1.Text = "Primer Apellido"
        Me.rbApellido1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbApellido1.UseVisualStyleBackColor = True
        '
        'rbNombres
        '
        Me.rbNombres.AutoSize = True
        Me.rbNombres.Location = New System.Drawing.Point(11, 41)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(62, 17)
        Me.rbNombres.TabIndex = 1
        Me.rbNombres.TabStop = True
        Me.rbNombres.Text = "Nombre"
        Me.rbNombres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbNombres.UseVisualStyleBackColor = True
        '
        'rbIdNotario
        '
        Me.rbIdNotario.AutoSize = True
        Me.rbIdNotario.Location = New System.Drawing.Point(9, 15)
        Me.rbIdNotario.Name = "rbIdNotario"
        Me.rbIdNotario.Size = New System.Drawing.Size(88, 17)
        Me.rbIdNotario.TabIndex = 0
        Me.rbIdNotario.TabStop = True
        Me.rbIdNotario.Text = "Id del Notario"
        Me.rbIdNotario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbIdNotario.UseVisualStyleBackColor = True
        '
        'dgNOTARIOS
        '
        Me.dgNOTARIOS.AllowUserToAddRows = False
        Me.dgNOTARIOS.AllowUserToDeleteRows = False
        Me.dgNOTARIOS.AllowUserToOrderColumns = True
        Me.dgNOTARIOS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgNOTARIOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgNOTARIOS.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgNOTARIOS.Location = New System.Drawing.Point(23, 232)
        Me.dgNOTARIOS.Name = "dgNOTARIOS"
        Me.dgNOTARIOS.ReadOnly = True
        Me.dgNOTARIOS.Size = New System.Drawing.Size(564, 158)
        Me.dgNOTARIOS.TabIndex = 0
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 198)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 81
        Me.btnImp.Text = "Consultar"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 198)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 80
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 198)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 79
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 198)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 78
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'frmMNotarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(610, 434)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgNOTARIOS)
        Me.Controls.Add(Me.PanelFiltros)
        Me.Name = "frmMNotarios"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Notarios."
        Me.PanelFiltros.ResumeLayout(False)
        Me.PanelFiltros.PerformLayout()
        CType(Me.dgNOTARIOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelFiltros As System.Windows.Forms.Panel
    Friend WithEvents rbAPELLIDO2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbApellido1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents rbIdNotario As System.Windows.Forms.RadioButton
    Friend WithEvents txtAPELLIDO2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAPELLIDO1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNOMBRES As System.Windows.Forms.TextBox
    Friend WithEvents txtIDNOTARIO As System.Windows.Forms.TextBox
    Friend WithEvents dgNOTARIOS As DataGridView
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
