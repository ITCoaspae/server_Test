Public Class frmMsPlanificacion
    Inherits System.Windows.Forms.Form : Public rsc As System.Resources.ResourceManager

    Public pCodigo As String

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtEjecMercadeoE As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEjecMercadeoE As System.Windows.Forms.TextBox
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFecI As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecF As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtMontoPlanificado As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtComentarios As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents btNew As System.Windows.Forms.Button
    Friend WithEvents btDel As System.Windows.Forms.Button
    Friend WithEvents btEdit As System.Windows.Forms.Button
    Friend WithEvents chkYear As System.Windows.Forms.CheckBox
    Friend WithEvents dtYear As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMsPlanificacion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCantidad = New C1.Win.C1Input.C1NumericEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtComentarios = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtMontoPlanificado = New C1.Win.C1Input.C1NumericEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpFecF = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpFecI = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbTipo = New System.Windows.Forms.ComboBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.txtEjecMercadeoE = New System.Windows.Forms.TextBox
        Me.txtCodEjecMercadeoE = New System.Windows.Forms.TextBox
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.btNew = New System.Windows.Forms.Button
        Me.btDel = New System.Windows.Forms.Button
        Me.btEdit = New System.Windows.Forms.Button
        Me.chkYear = New System.Windows.Forms.CheckBox
        Me.dtYear = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoPlanificado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtComentarios)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtMontoPlanificado)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpFecF)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFecI)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbTipo)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Controls.Add(Me.txtEjecMercadeoE)
        Me.GroupBox1.Controls.Add(Me.txtCodEjecMercadeoE)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtCantidad
        '
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.CustomFormat = "###,###,##0"
        Me.txtCantidad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtCantidad.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtCantidad.Location = New System.Drawing.Point(536, 64)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtCantidad.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtCantidad.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtCantidad.ShowDropDownButton = False
        Me.txtCantidad.ShowUpDownButtons = False
        Me.txtCantidad.Size = New System.Drawing.Size(104, 21)
        Me.txtCantidad.TabIndex = 5
        Me.txtCantidad.Tag = Nothing
        Me.txtCantidad.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightBlue
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(536, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "Cantidad Planificada:"
        '
        'txtComentarios
        '
        Me.txtComentarios.Location = New System.Drawing.Point(16, 112)
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentarios.Size = New System.Drawing.Size(624, 64)
        Me.txtComentarios.TabIndex = 6
        Me.txtComentarios.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightBlue
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Comentarios:"
        '
        'txtMontoPlanificado
        '
        Me.txtMontoPlanificado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoPlanificado.CustomFormat = "###,###,##0.00"
        Me.txtMontoPlanificado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoPlanificado.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtMontoPlanificado.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.txtMontoPlanificado.Location = New System.Drawing.Point(416, 64)
        Me.txtMontoPlanificado.Name = "txtMontoPlanificado"
        Me.txtMontoPlanificado.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtMontoPlanificado.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtMontoPlanificado.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtMontoPlanificado.ShowDropDownButton = False
        Me.txtMontoPlanificado.ShowUpDownButtons = False
        Me.txtMontoPlanificado.Size = New System.Drawing.Size(104, 21)
        Me.txtMontoPlanificado.TabIndex = 4
        Me.txtMontoPlanificado.Tag = Nothing
        Me.txtMontoPlanificado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(416, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "Monto Planificado:"
        '
        'dtpFecF
        '
        Me.dtpFecF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecF.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecF.Location = New System.Drawing.Point(320, 64)
        Me.dtpFecF.Name = "dtpFecF"
        Me.dtpFecF.Size = New System.Drawing.Size(84, 20)
        Me.dtpFecF.TabIndex = 3
        Me.dtpFecF.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(320, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "al:"
        '
        'dtpFecI
        '
        Me.dtpFecI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecI.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecI.Location = New System.Drawing.Point(224, 64)
        Me.dtpFecI.Name = "dtpFecI"
        Me.dtpFecI.Size = New System.Drawing.Size(84, 20)
        Me.dtpFecI.TabIndex = 2
        Me.dtpFecI.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(224, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 134
        Me.Label6.Text = "Del:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "*Seleccione rubro:"
        '
        'cbTipo
        '
        Me.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipo.Items.AddRange(New Object() {"Créditos", "DPF", "Afiliación", "Ahorro Programado", "Ahorro a la Vista", "Recuperación", "Membresía", "Aportación", "Ahorro Restringido", "Retiro de Asociados", "Cartera de Prestamos", "Indice de Mora", "Excedentes ", "Productos Financieros", "Gastos Financieros", "Gastos de Administración", "Gastos Generales", "Gastos de Personal", "G. Personal Mercadeo(P) ", "Gast. Comercializacion(P)"})
        Me.cbTipo.Location = New System.Drawing.Point(16, 64)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(192, 21)
        Me.cbTipo.TabIndex = 1
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(16, 16)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(88, 16)
        Me.Label46.TabIndex = 130
        Me.Label46.Text = "*Cód. Ejecutivo:"
        '
        'txtEjecMercadeoE
        '
        Me.txtEjecMercadeoE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEjecMercadeoE.Enabled = False
        Me.txtEjecMercadeoE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecMercadeoE.Location = New System.Drawing.Point(184, 16)
        Me.txtEjecMercadeoE.MaxLength = 110
        Me.txtEjecMercadeoE.Name = "txtEjecMercadeoE"
        Me.txtEjecMercadeoE.ReadOnly = True
        Me.txtEjecMercadeoE.Size = New System.Drawing.Size(440, 20)
        Me.txtEjecMercadeoE.TabIndex = 129
        Me.txtEjecMercadeoE.Text = ""
        '
        'txtCodEjecMercadeoE
        '
        Me.txtCodEjecMercadeoE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEjecMercadeoE.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEjecMercadeoE.Location = New System.Drawing.Point(112, 16)
        Me.txtCodEjecMercadeoE.MaxLength = 10
        Me.txtCodEjecMercadeoE.Name = "txtCodEjecMercadeoE"
        Me.txtCodEjecMercadeoE.ReadOnly = True
        Me.txtCodEjecMercadeoE.Size = New System.Drawing.Size(64, 20)
        Me.txtCodEjecMercadeoE.TabIndex = 0
        Me.txtCodEjecMercadeoE.Text = ""
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(584, 400)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(80, 23)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "     &Cerrar"
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.SystemColors.Window
        Me.fg.ColumnInfo = "10,0,0,0,0,85,Columns:0{Width:26;}" & Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(8, 232)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Size = New System.Drawing.Size(656, 160)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Normal{Font:Arial, 8.25pt, style=Bold;ForeColor:Black;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:Light" & _
        "SteelBlue;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:SteelBlue;ForeColor:ControlText;Border:Flat,1,Contro" & _
        "lDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{Back" & _
        "Color:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{Bac" & _
        "kColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Bl" & _
        "ack;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subt" & _
        "otal1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDar" & _
        "kDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Su" & _
        "btotal4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlD" & _
        "arkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.fg.TabIndex = 6
        '
        'btNew
        '
        Me.btNew.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btNew.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btNew.ForeColor = System.Drawing.Color.Black
        Me.btNew.Image = CType(resources.GetObject("btNew.Image"), System.Drawing.Image)
        Me.btNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btNew.Location = New System.Drawing.Point(24, 200)
        Me.btNew.Name = "btNew"
        Me.btNew.Size = New System.Drawing.Size(72, 24)
        Me.btNew.TabIndex = 7
        Me.btNew.Text = "&Agregar"
        Me.btNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btDel
        '
        Me.btDel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btDel.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDel.ForeColor = System.Drawing.Color.Black
        Me.btDel.Image = CType(resources.GetObject("btDel.Image"), System.Drawing.Image)
        Me.btDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btDel.Location = New System.Drawing.Point(184, 200)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(72, 24)
        Me.btDel.TabIndex = 9
        Me.btDel.Text = "&Eliminar"
        Me.btDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btEdit
        '
        Me.btEdit.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btEdit.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEdit.ForeColor = System.Drawing.Color.Black
        Me.btEdit.Image = CType(resources.GetObject("btEdit.Image"), System.Drawing.Image)
        Me.btEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btEdit.Location = New System.Drawing.Point(104, 200)
        Me.btEdit.Name = "btEdit"
        Me.btEdit.Size = New System.Drawing.Size(72, 24)
        Me.btEdit.TabIndex = 8
        Me.btEdit.Text = "&Modificar"
        Me.btEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkYear
        '
        Me.chkYear.Location = New System.Drawing.Point(488, 200)
        Me.chkYear.Name = "chkYear"
        Me.chkYear.Size = New System.Drawing.Size(104, 16)
        Me.chkYear.TabIndex = 10
        Me.chkYear.Text = "&Filtrar por año:"
        '
        'dtYear
        '
        Me.dtYear.CustomFormat = "yyyy"
        Me.dtYear.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtYear.Location = New System.Drawing.Point(592, 200)
        Me.dtYear.Name = "dtYear"
        Me.dtYear.ShowUpDown = True
        Me.dtYear.Size = New System.Drawing.Size(56, 20)
        Me.dtYear.TabIndex = 11
        Me.dtYear.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'frmMsPlanificacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(674, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtYear)
        Me.Controls.Add(Me.chkYear)
        Me.Controls.Add(Me.btNew)
        Me.Controls.Add(Me.btDel)
        Me.Controls.Add(Me.btEdit)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsPlanificacion"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "    Planificación de Ejecutivos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoPlanificado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub frmMsEjecutivos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.chkYear.Checked = True
        Me.dtYear.Value = Now
        Me.cbTipo.SelectedIndex = 0
        Me.dtpFecI.Value = Now
        Me.dtpFecF.Value = Now
        ActualizaGrid()
    End Sub

    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        If Me.fg.Row > 0 Then
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection

            ds = oAsoc.ConsultarPlanificacion("*", "Correlativo='" & fg.Item(fg.Row, "Correlativo") & "'", "Correlativo", sUsuario, sPassword, sSucursal)

            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                Me.txtCodEjecMercadeoE.Text = Filas.Item(0)("CodEjecMercadeo")
                Me.cbTipo.SelectedIndex = Filas.Item(0)("Tipo")
                Me.dtpFecI.Value = IIf(IsDBNull(Filas.Item(0)("FechaI")), Now, Filas.Item(0)("FechaI"))
                Me.dtpFecF.Value = IIf(IsDBNull(Filas.Item(0)("FechaF")), Now, Filas.Item(0)("FechaF"))
                Me.txtMontoPlanificado.Value = IIf(IsDBNull(Filas.Item(0)("Planificado")), 0, Filas.Item(0)("Planificado"))
                Me.txtCantidad.Value = IIf(IsDBNull(Filas.Item(0)("Cantidad")), 0, Filas.Item(0)("Cantidad"))
                Me.txtComentarios.Text = IIf(IsDBNull(Filas.Item(0)("Comentarios")), "", Filas.Item(0)("Comentarios"))
                Me.txtEjecMercadeoE.Text = IIf(IsDBNull(Filas.Item(0)("Nombre")), "", Filas.Item(0)("Nombre"))
                Me.btNew.Enabled = False
                Me.btDel.Enabled = False
            End If
        End If
    End Sub

    Private Sub btNew_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btNew.Click
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String

        If Me.txtCodEjecMercadeoE.Text.Trim = "" Then
            MsgBox("El Código del Ejecutivo no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Ejecutivos")
            Exit Sub
        End If

        pCampos = "CodEjecMercadeo,Nombre,Planificado,Cantidad,Tipo,FechaI,FechaF,Comentarios"
        pValores = "'" & Me.txtCodEjecMercadeoE.Text.Trim & "','" & Me.txtEjecMercadeoE.Text.Trim & "'," & Me.txtMontoPlanificado.Value & "," & Me.txtCantidad.Value & ",'" & Me.cbTipo.SelectedIndex & "','" & Format(Me.dtpFecI.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFecF.Value, "dd/MM/yyyy") & "','" & Me.txtComentarios.Text.Trim & "'"
        If oAsoc.InsertarPlanificacion(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
            Me.txtCantidad.Value = 0
            Me.txtMontoPlanificado.Value = 0
            Me.txtComentarios.Text = ""
            ActualizaGrid()
        Else
            MsgBox("El registro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ejecutivos")
        End If
    End Sub

    Private Sub btEdit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btEdit.Click
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String

        pCampos = "CodEjecMercadeo='" & Me.txtCodEjecMercadeoE.Text.Trim & "',Nombre='" & Me.txtEjecMercadeoE.Text.Trim & "',Planificado=" & Me.txtMontoPlanificado.Value & ",Cantidad=" & Me.txtCantidad.Value & ",Tipo='" & Me.cbTipo.SelectedIndex & "',FechaI='" & Format(Me.dtpFecI.Value, "dd/MM/yyyy") & "',FechaF='" & Format(Me.dtpFecF.Value, "dd/MM/yyyy") & "',Comentarios='" & Me.txtComentarios.Text.Trim & "'"
        If oAsoc.ModificarPlanificacion("Correlativo='" & fg.Item(fg.Row, "Correlativo") & "'", pCampos, sUsuario, sPassword, sSucursal) = True Then
            Me.btNew.Enabled = True
            Me.btDel.Enabled = True
            Me.txtCantidad.Value = 0
            Me.txtMontoPlanificado.Value = 0
            Me.txtComentarios.Text = ""
        Else
            MsgBox("El registro no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ejecutivos")
        End If
        ActualizaGrid()
    End Sub

    Private Sub btDel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btDel.Click
        If fg.Row <> -1 Then
            If MsgBox("¿Desea eliminar el registro seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Planificación") = MsgBoxResult.Yes Then
                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
                oAsoc.EliminarPlanificacion("Correlativo='" & fg.Item(fg.Row, "Correlativo") & "'", sUsuario, sPassword, sSucursal)
                ActualizaGrid()
            End If
        End If
    End Sub

    Private Sub Encabezado()

        fg.Cols.Item(2).Caption = "Código"
        fg.Cols.Item(1).Width = 0

    End Sub

    Private Sub ActualizaGrid()
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As Data.DataSet = New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            If Me.chkYear.Checked = True Then
                ds = oAsoc.ConsultarPlanificacion("*", "CodEjecMercadeo='" & pCodigo & "' and year(FechaI)=" & Me.dtYear.Value.Year & " and year(FechaF)=" & Me.dtYear.Value.Year & "", "Correlativo", sUsuario, sPassword, sSucursal)
            Else
                ds = oAsoc.ConsultarPlanificacion("*", "CodEjecMercadeo='" & pCodigo & "'", "Correlativo", sUsuario, sPassword, sSucursal)
            End If
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Planificaciones." & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtYear_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtYear.TextChanged
        If Me.chkYear.Checked = True Then
            Dim oAsoc As wrAsociados.wsLibAsoc, ds As Data.DataSet = New Data.DataSet
            Try
                oAsoc = New wrAsociados.wsLibAsoc
                ds = oAsoc.ConsultarPlanificacion("*", "CodEjecMercadeo='" & pCodigo & "' and year(FechaI)=" & Me.dtYear.Value.Year & " and year(FechaF)=" & Me.dtYear.Value.Year & "", "Correlativo", sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables(0)
            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla Planificaciones." & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Encabezado()
        End If
    End Sub

End Class
