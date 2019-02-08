<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wfDIASTRABAJADOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(wfDIASTRABAJADOS))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.lblFECHAINICIO = New System.Windows.Forms.Label()
        Me.lblFECHAFIN = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.chkEmpleado = New System.Windows.Forms.CheckBox()
        Me.chkFecha = New System.Windows.Forms.CheckBox()
        Me.txtEMPLEADO = New System.Windows.Forms.TextBox()
        Me.dtFECHAFIN = New System.Windows.Forms.DateTimePicker()
        Me.dtFECHAINICIO = New System.Windows.Forms.DateTimePicker()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.Location = New System.Drawing.Point(23, 243)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Size = New System.Drawing.Size(503, 185)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 42
        '
        'lblFECHAINICIO
        '
        Me.lblFECHAINICIO.AutoSize = True
        Me.lblFECHAINICIO.Location = New System.Drawing.Point(3, 39)
        Me.lblFECHAINICIO.Name = "lblFECHAINICIO"
        Me.lblFECHAINICIO.Size = New System.Drawing.Size(40, 26)
        Me.lblFECHAINICIO.TabIndex = 44
        Me.lblFECHAINICIO.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Inicio"
        '
        'lblFECHAFIN
        '
        Me.lblFECHAFIN.AutoSize = True
        Me.lblFECHAFIN.Location = New System.Drawing.Point(161, 39)
        Me.lblFECHAFIN.Name = "lblFECHAFIN"
        Me.lblFECHAFIN.Size = New System.Drawing.Size(40, 26)
        Me.lblFECHAFIN.TabIndex = 45
        Me.lblFECHAFIN.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fin"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.chkEmpleado)
        Me.GroupBox2.Controls.Add(Me.chkFecha)
        Me.GroupBox2.Controls.Add(Me.txtEMPLEADO)
        Me.GroupBox2.Controls.Add(Me.dtFECHAFIN)
        Me.GroupBox2.Controls.Add(Me.dtFECHAINICIO)
        Me.GroupBox2.Controls.Add(Me.lblFECHAINICIO)
        Me.GroupBox2.Controls.Add(Me.lblFECHAFIN)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(402, 140)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar Días Trabajados"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(311, 101)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 66
        Me.MetroButton1.Text = "Buscar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'chkEmpleado
        '
        Me.chkEmpleado.AutoSize = True
        Me.chkEmpleado.Location = New System.Drawing.Point(6, 78)
        Me.chkEmpleado.Name = "chkEmpleado"
        Me.chkEmpleado.Size = New System.Drawing.Size(73, 17)
        Me.chkEmpleado.TabIndex = 55
        Me.chkEmpleado.Text = "Empleado"
        Me.chkEmpleado.UseVisualStyleBackColor = True
        '
        'chkFecha
        '
        Me.chkFecha.AutoSize = True
        Me.chkFecha.Location = New System.Drawing.Point(6, 19)
        Me.chkFecha.Name = "chkFecha"
        Me.chkFecha.Size = New System.Drawing.Size(111, 17)
        Me.chkFecha.TabIndex = 54
        Me.chkFecha.Text = "Periodo de tiempo"
        Me.chkFecha.UseVisualStyleBackColor = True
        '
        'txtEMPLEADO
        '
        Me.txtEMPLEADO.Location = New System.Drawing.Point(85, 75)
        Me.txtEMPLEADO.Name = "txtEMPLEADO"
        Me.txtEMPLEADO.Size = New System.Drawing.Size(301, 20)
        Me.txtEMPLEADO.TabIndex = 51
        '
        'dtFECHAFIN
        '
        Me.dtFECHAFIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFECHAFIN.Location = New System.Drawing.Point(207, 42)
        Me.dtFECHAFIN.Name = "dtFECHAFIN"
        Me.dtFECHAFIN.Size = New System.Drawing.Size(100, 20)
        Me.dtFECHAFIN.TabIndex = 47
        '
        'dtFECHAINICIO
        '
        Me.dtFECHAINICIO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFECHAINICIO.Location = New System.Drawing.Point(55, 42)
        Me.dtFECHAINICIO.Name = "dtFECHAINICIO"
        Me.dtFECHAINICIO.Size = New System.Drawing.Size(100, 20)
        Me.dtFECHAINICIO.TabIndex = 46
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 209)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 71
        Me.btnImp.Text = "Consultar"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 209)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 70
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 209)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 69
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 209)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 68
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'wfDIASTRABAJADOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(551, 475)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fg)
        Me.Name = "wfDIASTRABAJADOS"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "MANTENIMIENTO DÍAS TRABAJADOS"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents lblFECHAINICIO As System.Windows.Forms.Label
    Friend WithEvents lblFECHAFIN As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtFECHAFIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFECHAINICIO As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEMPLEADO As System.Windows.Forms.TextBox
    Friend WithEvents chkEmpleado As System.Windows.Forms.CheckBox
    Friend WithEvents chkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
End Class
