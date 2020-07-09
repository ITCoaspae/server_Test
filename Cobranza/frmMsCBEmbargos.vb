Public Class frmMsCBEmbargos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbTipoEmbargo As System.Windows.Forms.ComboBox
    Friend WithEvents txtNoReferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNit As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCel As System.Windows.Forms.TextBox
    Friend WithEvents txtTelCasa As System.Windows.Forms.TextBox
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtComentario As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaEntAbogado As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDemandadoIII As System.Windows.Forms.TextBox
    Friend WithEvents txtDemandadoII As System.Windows.Forms.TextBox
    Friend WithEvents txtDemandadoI As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreTribunal As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreAbogado As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDel1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEdit1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNew1 As MetroFramework.Controls.MetroButton
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsCBEmbargos))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbTipoEmbargo = New System.Windows.Forms.ComboBox()
        Me.txtNoReferencia = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNit = New C1.Win.C1Input.C1TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.txtTelCasa = New System.Windows.Forms.TextBox()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.dtpFechaEntAbogado = New System.Windows.Forms.DateTimePicker()
        Me.txtDemandadoIII = New System.Windows.Forms.TextBox()
        Me.txtDemandadoII = New System.Windows.Forms.TextBox()
        Me.txtDemandadoI = New System.Windows.Forms.TextBox()
        Me.txtNombreTribunal = New System.Windows.Forms.TextBox()
        Me.txtNombreAbogado = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.btDel1 = New MetroFramework.Controls.MetroButton()
        Me.btEdit1 = New MetroFramework.Controls.MetroButton()
        Me.btNew1 = New MetroFramework.Controls.MetroButton()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(28, 73)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(576, 603)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(568, 574)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Embargos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnGuardar1)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.cbTipoEmbargo)
        Me.GroupBox1.Controls.Add(Me.txtNoReferencia)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCel)
        Me.GroupBox1.Controls.Add(Me.txtTelCasa)
        Me.GroupBox1.Controls.Add(Me.txtAsociado)
        Me.GroupBox1.Controls.Add(Me.txtCodPrestamo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtDui)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.txtComentario)
        Me.GroupBox1.Controls.Add(Me.dtpFechaEntAbogado)
        Me.GroupBox1.Controls.Add(Me.txtDemandadoIII)
        Me.GroupBox1.Controls.Add(Me.txtDemandadoII)
        Me.GroupBox1.Controls.Add(Me.txtDemandadoI)
        Me.GroupBox1.Controls.Add(Me.txtNombreTribunal)
        Me.GroupBox1.Controls.Add(Me.txtNombreAbogado)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 546)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Embargo:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuardar1.Location = New System.Drawing.Point(438, 497)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 33)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1016
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(10, 138)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 19)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "Tipo de Embargo:"
        '
        'cbTipoEmbargo
        '
        Me.cbTipoEmbargo.BackColor = System.Drawing.Color.White
        Me.cbTipoEmbargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoEmbargo.Items.AddRange(New Object() {"0 = Por sueldo", "1 = Por Bienes"})
        Me.cbTipoEmbargo.Location = New System.Drawing.Point(125, 138)
        Me.cbTipoEmbargo.Name = "cbTipoEmbargo"
        Me.cbTipoEmbargo.Size = New System.Drawing.Size(403, 24)
        Me.cbTipoEmbargo.TabIndex = 3
        '
        'txtNoReferencia
        '
        Me.txtNoReferencia.Location = New System.Drawing.Point(125, 222)
        Me.txtNoReferencia.MaxLength = 20
        Me.txtNoReferencia.Name = "txtNoReferencia"
        Me.txtNoReferencia.Size = New System.Drawing.Size(403, 22)
        Me.txtNoReferencia.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(10, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 18)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "No Referencia:"
        '
        'txtNit
        '
        Me.txtNit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNit.EditMask = "0000-000000-000-0"
        Me.txtNit.Location = New System.Drawing.Point(125, 46)
        Me.txtNit.MaxLength = 20
        Me.txtNit.Name = "txtNit"
        Me.txtNit.NumericInput = False
        Me.txtNit.Size = New System.Drawing.Size(134, 23)
        Me.txtNit.TabIndex = 1
        Me.txtNit.Tag = Nothing
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "NIT:"
        '
        'txtCel
        '
        Me.txtCel.BackColor = System.Drawing.Color.White
        Me.txtCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCel.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCel.Location = New System.Drawing.Point(374, 46)
        Me.txtCel.Multiline = True
        Me.txtCel.Name = "txtCel"
        Me.txtCel.ReadOnly = True
        Me.txtCel.Size = New System.Drawing.Size(154, 23)
        Me.txtCel.TabIndex = 49
        '
        'txtTelCasa
        '
        Me.txtTelCasa.BackColor = System.Drawing.Color.White
        Me.txtTelCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelCasa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTelCasa.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtTelCasa.Location = New System.Drawing.Point(374, 18)
        Me.txtTelCasa.Multiline = True
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.ReadOnly = True
        Me.txtTelCasa.Size = New System.Drawing.Size(154, 24)
        Me.txtTelCasa.TabIndex = 48
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAsociado.Location = New System.Drawing.Point(125, 74)
        Me.txtAsociado.MaxLength = 15
        Me.txtAsociado.Multiline = True
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.Size = New System.Drawing.Size(403, 28)
        Me.txtAsociado.TabIndex = 44
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPrestamo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodPrestamo.Location = New System.Drawing.Point(125, 111)
        Me.txtCodPrestamo.MaxLength = 20
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(403, 23)
        Me.txtCodPrestamo.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(269, 46)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 19)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Celular:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(269, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 19)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Teléfono Casa:"
        '
        'txtDui
        '
        Me.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(125, 18)
        Me.txtDui.MaxLength = 20
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(134, 24)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(10, 74)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 18)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "Asociado:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(10, 111)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 18)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Cod. Préstamo:"
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(10, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 19)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "DUI Asociado:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(125, 444)
        Me.txtObservaciones.MaxLength = 255
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(403, 46)
        Me.txtObservaciones.TabIndex = 12
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(125, 391)
        Me.txtComentario.MaxLength = 255
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentario.Size = New System.Drawing.Size(403, 46)
        Me.txtComentario.TabIndex = 11
        '
        'dtpFechaEntAbogado
        '
        Me.dtpFechaEntAbogado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEntAbogado.Location = New System.Drawing.Point(125, 347)
        Me.dtpFechaEntAbogado.Name = "dtpFechaEntAbogado"
        Me.dtpFechaEntAbogado.Size = New System.Drawing.Size(105, 22)
        Me.dtpFechaEntAbogado.TabIndex = 10
        '
        'txtDemandadoIII
        '
        Me.txtDemandadoIII.Location = New System.Drawing.Point(125, 305)
        Me.txtDemandadoIII.MaxLength = 100
        Me.txtDemandadoIII.Name = "txtDemandadoIII"
        Me.txtDemandadoIII.Size = New System.Drawing.Size(403, 22)
        Me.txtDemandadoIII.TabIndex = 9
        '
        'txtDemandadoII
        '
        Me.txtDemandadoII.Location = New System.Drawing.Point(125, 277)
        Me.txtDemandadoII.MaxLength = 100
        Me.txtDemandadoII.Name = "txtDemandadoII"
        Me.txtDemandadoII.Size = New System.Drawing.Size(403, 22)
        Me.txtDemandadoII.TabIndex = 8
        '
        'txtDemandadoI
        '
        Me.txtDemandadoI.Location = New System.Drawing.Point(125, 249)
        Me.txtDemandadoI.MaxLength = 100
        Me.txtDemandadoI.Name = "txtDemandadoI"
        Me.txtDemandadoI.Size = New System.Drawing.Size(403, 22)
        Me.txtDemandadoI.TabIndex = 7
        '
        'txtNombreTribunal
        '
        Me.txtNombreTribunal.Location = New System.Drawing.Point(125, 194)
        Me.txtNombreTribunal.MaxLength = 100
        Me.txtNombreTribunal.Name = "txtNombreTribunal"
        Me.txtNombreTribunal.Size = New System.Drawing.Size(403, 22)
        Me.txtNombreTribunal.TabIndex = 5
        '
        'txtNombreAbogado
        '
        Me.txtNombreAbogado.Location = New System.Drawing.Point(125, 166)
        Me.txtNombreAbogado.MaxLength = 100
        Me.txtNombreAbogado.Name = "txtNombreAbogado"
        Me.txtNombreAbogado.Size = New System.Drawing.Size(403, 22)
        Me.txtNombreAbogado.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(7, 444)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(106, 19)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Observaciones:"
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(10, 395)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 18)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Comentarios:"
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(10, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 49)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Fecha de Entrega caso al Abogado:"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Demandado III:"
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 277)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Demandado II:"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 19)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Demandado I:"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 18)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nombre Tribunal:"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 19)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Nombre Abogado:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.GroupBox18)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(568, 574)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle de Bienes Embargados"
        '
        'GroupBox18
        '
        Me.GroupBox18.BackColor = System.Drawing.Color.White
        Me.GroupBox18.Controls.Add(Me.btDel1)
        Me.GroupBox18.Controls.Add(Me.btEdit1)
        Me.GroupBox18.Controls.Add(Me.btNew1)
        Me.GroupBox18.Controls.Add(Me.fg)
        Me.GroupBox18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox18.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox18.Location = New System.Drawing.Point(10, 9)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(548, 561)
        Me.GroupBox18.TabIndex = 2
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "Bienes Embargados"
        '
        'btDel1
        '
        Me.btDel1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btDel1.Location = New System.Drawing.Point(204, 25)
        Me.btDel1.Name = "btDel1"
        Me.btDel1.Size = New System.Drawing.Size(90, 33)
        Me.btDel1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDel1.TabIndex = 1019
        Me.btDel1.Text = "Eliminar"
        Me.btDel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDel1.UseSelectable = True
        Me.btDel1.UseStyleColors = True
        '
        'btEdit1
        '
        Me.btEdit1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btEdit1.Location = New System.Drawing.Point(107, 25)
        Me.btEdit1.Name = "btEdit1"
        Me.btEdit1.Size = New System.Drawing.Size(90, 33)
        Me.btEdit1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEdit1.TabIndex = 1018
        Me.btEdit1.Text = "Modificar"
        Me.btEdit1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEdit1.UseSelectable = True
        Me.btEdit1.UseStyleColors = True
        '
        'btNew1
        '
        Me.btNew1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btNew1.Location = New System.Drawing.Point(10, 25)
        Me.btNew1.Name = "btNew1"
        Me.btNew1.Size = New System.Drawing.Size(90, 33)
        Me.btNew1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNew1.TabIndex = 1017
        Me.btNew1.Text = "&Guardar"
        Me.btNew1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNew1.UseSelectable = True
        Me.btNew1.UseStyleColors = True
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,0,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.Location = New System.Drawing.Point(10, 65)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(526, 477)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 3
        '
        'frmMsCBEmbargos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(631, 693)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(631, 693)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(631, 693)
        Me.Name = "frmMsCBEmbargos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Embargos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox18.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim oAso As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Dim ds As New Data.DataSet
        Dim sResultado1, sResultado2, sResultado3, sResultado4, sResultado5 As String
        Dim ofrm As New frmAGenerico
        Try
            ofrm.Text = "Buscar Códigos de Asociados"
            ds = oAso.ConsultarAsociado("DUI,NIT, Nombres + ' ' + Apellido1 + ' ' + Apellido2 + ' ' + ApellidoCas As NombreCompleto, TelCasa, Celular", "", "DUI", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            sResultado1 = ofrm.Resultado
            sResultado2 = ofrm.Resultado2
            sResultado3 = ofrm.Resultado3
            sResultado4 = ofrm.Resultado4
            sResultado5 = ofrm.Resultado5
            Me.txtDui.Value = sResultado1.Trim
            Me.txtNit.Text = sResultado2.Trim
            Me.txtAsociado.Text = sResultado3
            Me.txtTelCasa.Text = sResultado4
            Me.txtCel.Text = sResultado5
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub


    Private Sub txtCodPrestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPrestamo.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim sTexto As String
            Dim ds As New Data.DataSet, dr As DataRow
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
            Dim oPrest As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest
            Try
                sTexto = Me.txtCodPrestamo.Text
                If sTexto = "" Then
                    ds = oCred.ConsultarPrestamos("*", "Estado='C' and Dui='" & Me.txtDui.Text.Trim & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
                        Me.txtAsociado.Text = IIf(IsDBNull(dr("Nombre")), "", dr("Nombre"))
                        Me.txtDui.Value = IIf(IsDBNull(dr("Dui")), "", dr("Dui"))
                    End If
                ElseIf sTexto <> "" Then
                    ds = oCred.ConsultarPrestamos("*", "CodPrestamo = '" & Trim(Me.txtCodPrestamo.Text) & "' AND Estado='C' and Dui='" & Me.txtDui.Text.Trim & "'", "", sUsuario, sPassword, sSucursal)
                    'ds = oCred.ConsultarPrestamos("*", "CodPrestamo = '" & Trim(Me.txtCodPrestamo.Text) & "'", "", sUsuario, sPassword,sSucursal)
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
                        Me.txtAsociado.Text = IIf(IsDBNull(dr("Nombre")), "", dr("Nombre"))
                        Me.txtDui.Value = IIf(IsDBNull(dr("Dui")), "", dr("Dui"))
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: NO EXISTE EL CODIGO DE PRESTAMO --" & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick

        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Préstamo"
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
        Dim ds As New Data.DataSet

        Try
            ds = oCred.ConsultarPrestamos("*", "Estado='C' and Dui='" & Me.txtDui.Text.Trim & "'", "CodPrestamo", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                txtCodPrestamo.Text = sTexto.Trim
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNit_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNit.DoubleClick
        Dim oAso As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Dim ds As New Data.DataSet
        Dim sResultado1, sResultado2, sResultado3, sResultado4, sResultado5 As String
        Dim ofrm As New frmAGenerico
        Try
            ofrm.Text = "Buscar Códigos de Asociados"
            ds = oAso.ConsultarAsociado("DUI,NIT, Nombres + ' ' + Apellido1 + ' ' + Apellido2 + ' ' + ApellidoCas As NombreCompleto, TelCasa, Celular", "", "DUI", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            sResultado1 = ofrm.Resultado
            sResultado2 = ofrm.Resultado2
            sResultado3 = ofrm.Resultado3
            sResultado4 = ofrm.Resultado4
            sResultado5 = ofrm.Resultado5
            Me.txtDui.Text = sResultado1
            Me.txtNit.Text = sResultado2
            Me.txtAsociado.Text = sResultado3
            Me.txtTelCasa.Text = sResultado4
            Me.txtCel.Text = sResultado5
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub txtNit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNit.Validating
        Dim sTexto As String

        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            sTexto = Me.txtNit.Text
            If sTexto = "" Then 'Filtrar Registros
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,TelCasa,Celular,Nit", "", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtCel.Text = IIf(IsDBNull(dr("Celular")), "", dr("Celular"))
                    Me.txtTelCasa.Text = IIf(IsDBNull(dr("TelCasa")), "", dr("TelCasa"))
                    Me.txtNit.Value = IIf(IsDBNull(dr("Nit")), "", dr("Nit"))
                Else
                    Exit Sub
                End If
            ElseIf sTexto <> "" Then
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,TelCasa,Celular,Nit", "NIT='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtCel.Text = IIf(IsDBNull(dr("Celular")), "", dr("Celular"))
                    Me.txtTelCasa.Text = IIf(IsDBNull(dr("TelCasa")), "", dr("TelCasa"))
                    Me.txtNit.Value = IIf(IsDBNull(dr("Nit")), "", dr("Nit"))
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: NO ENCUENTRA DUI ASOCIADO --" & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbTipoEmbargo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoEmbargo.SelectedIndexChanged
        If Me.cbTipoEmbargo.SelectedIndex = 0 Then
            Me.txtNoReferencia.Enabled = True
            Me.txtNombreTribunal.Enabled = True
        End If
    End Sub



    Private Sub ActualizaGrid()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarCBBienesEmbargados("*", "", "CodBienEmbargado", sUsuario, sPassword, sSucursal)
            Me.fg.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Bienes Embargados." & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmMsCBEmbargos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        If btnGuardar1.Text = "&Modificar" Then
            ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,TelCasa,Celular,Nit", "DUI='" & Me.txtDui.Value & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.txtDui.Value = Trim(dr("DUI"))
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                Me.txtCel.Text = IIf(IsDBNull(dr("Celular")), "", dr("Celular"))
                Me.txtTelCasa.Text = IIf(IsDBNull(dr("TelCasa")), "", dr("TelCasa"))
                Me.txtNit.Value = IIf(IsDBNull(dr("Nit")), "", dr("Nit"))
            End If
            ActualizaGrid()
        End If
    End Sub

    Private Sub txtDui_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.GotFocus
        Try
            Dim Valor As String
            Valor = IIf(txtDui.ValueIsDbNull, "", txtDui.Value)
            If Valor.Trim = "" Then
                Me.txtDui.SelectionStart = 0
                Me.txtDui.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.Click
        Try
            Dim Valor As String
            Valor = IIf(txtDui.ValueIsDbNull, "", txtDui.Value)
            If Valor.Trim = "" Then
                Me.txtDui.SelectionStart = 0
                Me.txtDui.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNit.Click
        Try
            Dim Valor As String
            Valor = IIf(txtNit.ValueIsDbNull, "", txtNit.Value)
            If Valor.Trim = "" Then
                Me.txtNit.SelectionStart = 0
                Me.txtNit.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus

        If Me.txtDui.Text.Trim = "" Then Exit Sub
        Dim sTexto As String
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            sTexto = Me.txtDui.Value
            If sTexto <> "" Then
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,TelCasa,Celular,Nit", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtCel.Text = IIf(IsDBNull(dr("Celular")), "", dr("Celular"))
                    Me.txtTelCasa.Text = IIf(IsDBNull(dr("TelCasa")), "", dr("TelCasa"))
                    Me.txtNit.Value = IIf(IsDBNull(dr("Nit")), "", dr("Nit"))
                Else
                    Exit Sub
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim Campos, Valores, CamposValores As String
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
            Dim TipoEmbargo As String
            TipoEmbargo = Me.cbTipoEmbargo.SelectedIndex
            If TipoEmbargo = 0 Then
                TipoEmbargo = "0"
            ElseIf Me.cbTipoEmbargo.SelectedIndex = 1 Then
                TipoEmbargo = "1"
            End If

            If Me.btnGuardar1.Text = "&Guardar" Then
                If Me.txtCodPrestamo.Text = "" Or Me.txtNombreAbogado.Text = "" Or Me.txtNombreTribunal.Text = "" Or Me.txtDemandadoI.Text = "" Then
                    MsgBox("Existen campos que no deben de quedar vacíos, verifique y vuelva a intentarlo", MsgBoxStyle.Information, "Módulo - Créditos")
                Else
                    Campos = "CodPrestamo,Dui,NombreAbogado,NombreTribunal,DemandadoI,DemandadoII,DemandadoIII,FechaEntAbogado,NoReferencia,Comentarios,Observaciones,TipoEmbargo"
                    Valores = "'" & Trim(Me.txtCodPrestamo.Text) & "','" & Me.txtDui.Value & "','" & Trim(Me.txtNombreAbogado.Text) & "','" & Trim(Me.txtNombreTribunal.Text) & "','" & Trim(Me.txtDemandadoI.Text) & "','" & Trim(Me.txtDemandadoII.Text) & "','" & Trim(Me.txtDemandadoIII.Text) & "', '" & Me.dtpFechaEntAbogado.Value.ToShortDateString & "','" & Trim(Me.txtNoReferencia.Text) & "','" & Trim(Me.txtComentario.Text) & "','" & Trim(Me.txtObservaciones.Text) & "','" & TipoEmbargo.Trim & "'"
                    If oCred.InsertarBCEmbargos(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                        Me.Dispose()
                    Else
                        MsgBox("Los datos no fuerón ingresados correctamente", MsgBoxStyle.Critical, "Módulo - Créditos")
                    End If
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                CamposValores = "NombreAbogado='" & Trim(Me.txtNombreAbogado.Text) & "',NombreTribunal='" & Trim(Me.txtNombreTribunal.Text) & "',DemandadoI='" & Trim(Me.txtDemandadoI.Text) & "',DemandadoII='" & Trim(Me.txtDemandadoII.Text) & "',DemandadoIII='" & Trim(Me.txtDemandadoIII.Text) & "',FechaEntAbogado='" & Me.dtpFechaEntAbogado.Value.ToShortDateString & "',NoReferencia='" & Trim(Me.txtNoReferencia.Text) & "',Comentarios='" & Trim(Me.txtComentario.Text) & "',Observaciones='" & Trim(Me.txtObservaciones.Text) & "',TipoEmbargo='" & TipoEmbargo.Trim & "'"
                If oCred.ModificarBCEmbargos(CamposValores, "'" & Trim(Me.txtCodPrestamo.Text) & "'", sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos no fueron modificados correctamente", MsgBoxStyle.Critical, "Módulo - Créditos")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNew1_Click(sender As Object, e As EventArgs) Handles btNew1.Click
        Try
            If Me.txtCodPrestamo.Text.Trim <> "" Then
                Dim frm As frmMSCBBienesEmbargados = New frmMSCBBienesEmbargados
                'frm.DUI = Trim(Me.txtDui.Value)
                frm.CodPrestamo = Me.txtCodPrestamo.Text.Trim
                frm.Text = "Bienes Embargados"
                frm.btnGuardar1.Text = "&Guardar"
                frm.ShowDialog()
                ActualizaGrid()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEdit1_Click(sender As Object, e As EventArgs) Handles btEdit1.Click
        Try
            If Me.fg.Row <> -1 Then
                Dim frm As frmMSCBBienesEmbargados = New frmMSCBBienesEmbargados
                frm.DUI = Trim(Me.txtDui.Text)
                frm.CodPrestamo = Me.txtCodPrestamo.Text.Trim
                frm.pCodBienEmbargado = Me.fg.Item(Me.fg.Row, "CodBienEmbargado")
                frm.Text = "Bienes Embargados"
                frm.btnGuardar1.Text = "&Modificar"
                frm.ShowDialog()
                ActualizaGrid()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btDel1_Click(sender As Object, e As EventArgs) Handles btDel1.Click
        Try
            If Me.fg.Row <> -1 Then
                If MsgBox("¿Desea eliminar el Bien número " & Me.fg.Item(Me.fg.Row, "CodBienEmbargado") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Bien Embargado") = MsgBoxResult.Yes Then
                    Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                    oCred.EliminarCBBienesEmbargados("CodBienEmbargado=" & Me.fg.Item(Me.fg.Row, "CodBienEmbargado") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGrid()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class