<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMPLModificacionPlanilla
    Inherits MetroFramework.Forms.MetroForm

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
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.cbDepartamento = New System.Windows.Forms.ComboBox()
        Me.cbArea = New System.Windows.Forms.ComboBox()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblArea = New System.Windows.Forms.Label()
        Me.rbDepartamento = New System.Windows.Forms.RadioButton()
        Me.rbSucursal = New System.Windows.Forms.RadioButton()
        Me.rbMostrarTodos = New System.Windows.Forms.RadioButton()
        Me.txtPERIODO = New System.Windows.Forms.TextBox()
        Me.txtCODPLANILLA = New System.Windows.Forms.TextBox()
        Me.lblCODPLANILLA = New System.Windows.Forms.Label()
        Me.dgDESCUENTOS = New System.Windows.Forms.DataGridView()
        Me.gbFiltros.SuspendLayout()
        CType(Me.dgDESCUENTOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbFiltros
        '
        Me.gbFiltros.Controls.Add(Me.btnMostrar1)
        Me.gbFiltros.Controls.Add(Me.cbDepartamento)
        Me.gbFiltros.Controls.Add(Me.cbArea)
        Me.gbFiltros.Controls.Add(Me.lblDepartamento)
        Me.gbFiltros.Controls.Add(Me.lblArea)
        Me.gbFiltros.Controls.Add(Me.rbDepartamento)
        Me.gbFiltros.Controls.Add(Me.rbSucursal)
        Me.gbFiltros.Controls.Add(Me.rbMostrarTodos)
        Me.gbFiltros.Location = New System.Drawing.Point(23, 85)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(561, 112)
        Me.gbFiltros.TabIndex = 5
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Filtros"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(480, 71)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 108
        Me.btnMostrar1.Text = "Buscar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'cbDepartamento
        '
        Me.cbDepartamento.DisplayMember = "DESCRIPCION"
        Me.cbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDepartamento.FormattingEnabled = True
        Me.cbDepartamento.Location = New System.Drawing.Point(99, 77)
        Me.cbDepartamento.Name = "cbDepartamento"
        Me.cbDepartamento.Size = New System.Drawing.Size(371, 22)
        Me.cbDepartamento.TabIndex = 6
        Me.cbDepartamento.ValueMember = "CODDEPARTAMENTO"
        '
        'cbArea
        '
        Me.cbArea.DisplayMember = "DESCRIPCION"
        Me.cbArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbArea.FormattingEnabled = True
        Me.cbArea.Location = New System.Drawing.Point(99, 45)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(371, 22)
        Me.cbArea.TabIndex = 5
        Me.cbArea.ValueMember = "CODAREA"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Location = New System.Drawing.Point(4, 77)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(89, 14)
        Me.lblDepartamento.TabIndex = 4
        Me.lblDepartamento.Text = "Departamento:"
        '
        'lblArea
        '
        Me.lblArea.AutoSize = True
        Me.lblArea.Location = New System.Drawing.Point(6, 48)
        Me.lblArea.Name = "lblArea"
        Me.lblArea.Size = New System.Drawing.Size(35, 14)
        Me.lblArea.TabIndex = 3
        Me.lblArea.Text = "Area:"
        '
        'rbDepartamento
        '
        Me.rbDepartamento.AutoSize = True
        Me.rbDepartamento.Location = New System.Drawing.Point(171, 21)
        Me.rbDepartamento.Name = "rbDepartamento"
        Me.rbDepartamento.Size = New System.Drawing.Size(104, 18)
        Me.rbDepartamento.TabIndex = 2
        Me.rbDepartamento.TabStop = True
        Me.rbDepartamento.Text = "Departamento"
        Me.rbDepartamento.UseVisualStyleBackColor = True
        '
        'rbSucursal
        '
        Me.rbSucursal.AutoSize = True
        Me.rbSucursal.Location = New System.Drawing.Point(115, 21)
        Me.rbSucursal.Name = "rbSucursal"
        Me.rbSucursal.Size = New System.Drawing.Size(50, 18)
        Me.rbSucursal.TabIndex = 1
        Me.rbSucursal.TabStop = True
        Me.rbSucursal.Text = "Area"
        Me.rbSucursal.UseVisualStyleBackColor = True
        '
        'rbMostrarTodos
        '
        Me.rbMostrarTodos.AutoSize = True
        Me.rbMostrarTodos.Location = New System.Drawing.Point(7, 21)
        Me.rbMostrarTodos.Name = "rbMostrarTodos"
        Me.rbMostrarTodos.Size = New System.Drawing.Size(102, 18)
        Me.rbMostrarTodos.TabIndex = 0
        Me.rbMostrarTodos.TabStop = True
        Me.rbMostrarTodos.Text = "Mostrar Todos"
        Me.rbMostrarTodos.UseVisualStyleBackColor = True
        '
        'txtPERIODO
        '
        Me.txtPERIODO.BackColor = System.Drawing.Color.White
        Me.txtPERIODO.Location = New System.Drawing.Point(246, 58)
        Me.txtPERIODO.Multiline = True
        Me.txtPERIODO.Name = "txtPERIODO"
        Me.txtPERIODO.ReadOnly = True
        Me.txtPERIODO.Size = New System.Drawing.Size(342, 21)
        Me.txtPERIODO.TabIndex = 3
        '
        'txtCODPLANILLA
        '
        Me.txtCODPLANILLA.BackColor = System.Drawing.Color.White
        Me.txtCODPLANILLA.Location = New System.Drawing.Point(208, 57)
        Me.txtCODPLANILLA.Name = "txtCODPLANILLA"
        Me.txtCODPLANILLA.Size = New System.Drawing.Size(32, 22)
        Me.txtCODPLANILLA.TabIndex = 1
        '
        'lblCODPLANILLA
        '
        Me.lblCODPLANILLA.AutoSize = True
        Me.lblCODPLANILLA.Location = New System.Drawing.Point(23, 60)
        Me.lblCODPLANILLA.Name = "lblCODPLANILLA"
        Me.lblCODPLANILLA.Size = New System.Drawing.Size(179, 14)
        Me.lblCODPLANILLA.TabIndex = 0
        Me.lblCODPLANILLA.Text = "Ingrese el codigo de la planilla"
        '
        'dgDESCUENTOS
        '
        Me.dgDESCUENTOS.AllowUserToAddRows = False
        Me.dgDESCUENTOS.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        Me.dgDESCUENTOS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgDESCUENTOS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDESCUENTOS.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgDESCUENTOS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgDESCUENTOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDESCUENTOS.Location = New System.Drawing.Point(23, 203)
        Me.dgDESCUENTOS.Name = "dgDESCUENTOS"
        Me.dgDESCUENTOS.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgDESCUENTOS.Size = New System.Drawing.Size(565, 240)
        Me.dgDESCUENTOS.TabIndex = 1
        '
        'frmMPLModificacionPlanilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(611, 510)
        Me.Controls.Add(Me.gbFiltros)
        Me.Controls.Add(Me.dgDESCUENTOS)
        Me.Controls.Add(Me.txtPERIODO)
        Me.Controls.Add(Me.lblCODPLANILLA)
        Me.Controls.Add(Me.txtCODPLANILLA)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmMPLModificacionPlanilla"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Modificación de Descuentos de Ley"
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        CType(Me.dgDESCUENTOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCODPLANILLA As System.Windows.Forms.TextBox
    Friend WithEvents lblCODPLANILLA As System.Windows.Forms.Label
    Friend WithEvents dgDESCUENTOS As System.Windows.Forms.DataGridView
    Friend WithEvents txtPERIODO As System.Windows.Forms.TextBox
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents cbDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents cbArea As System.Windows.Forms.ComboBox
    Friend WithEvents lblDepartamento As System.Windows.Forms.Label
    Friend WithEvents lblArea As System.Windows.Forms.Label
    Friend WithEvents rbDepartamento As System.Windows.Forms.RadioButton
    Friend WithEvents rbSucursal As System.Windows.Forms.RadioButton
    Friend WithEvents rbMostrarTodos As System.Windows.Forms.RadioButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
End Class
