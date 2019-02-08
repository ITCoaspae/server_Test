Public Class frmMsInhabilita
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region "Campos"
    Private pCorrelativo As Long, pUsuarioInhabilita As String, pUsuarioRehabilita As String
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
#End Region

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkResJV As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFecJV As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNoActaJV As System.Windows.Forms.TextBox
    Friend WithEvents txtObsJV As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecCA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNoActaCA As System.Windows.Forms.TextBox
    Friend WithEvents rbInhabilita As System.Windows.Forms.RadioButton
    Friend WithEvents rbRehabilitacion As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFecRehabilitacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodAntiguo As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFecRehabilitacion = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbRehabilitacion = New System.Windows.Forms.RadioButton()
        Me.rbInhabilita = New System.Windows.Forms.RadioButton()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkResJV = New System.Windows.Forms.CheckBox()
        Me.dtpFecJV = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNoActaJV = New System.Windows.Forms.TextBox()
        Me.txtObsJV = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpFecCA = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNoActaCA = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtCodAntiguo = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.dtpFecRehabilitacion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rbRehabilitacion)
        Me.GroupBox1.Controls.Add(Me.rbInhabilita)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(23, 306)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(557, 136)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'dtpFecRehabilitacion
        '
        Me.dtpFecRehabilitacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecRehabilitacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecRehabilitacion.Location = New System.Drawing.Point(336, 48)
        Me.dtpFecRehabilitacion.Name = "dtpFecRehabilitacion"
        Me.dtpFecRehabilitacion.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecRehabilitacion.TabIndex = 3
        Me.dtpFecRehabilitacion.Value = New Date(2004, 9, 9, 11, 34, 0, 0)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(186, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 16)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Fecha Inicio Rehabilitación:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rbRehabilitacion
        '
        Me.rbRehabilitacion.Enabled = False
        Me.rbRehabilitacion.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.rbRehabilitacion.ForeColor = System.Drawing.Color.Black
        Me.rbRehabilitacion.Location = New System.Drawing.Point(6, 48)
        Me.rbRehabilitacion.Name = "rbRehabilitacion"
        Me.rbRehabilitacion.Size = New System.Drawing.Size(160, 24)
        Me.rbRehabilitacion.TabIndex = 2
        Me.rbRehabilitacion.Text = "&Rehabilitación Efectuada"
        '
        'rbInhabilita
        '
        Me.rbInhabilita.Enabled = False
        Me.rbInhabilita.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.rbInhabilita.ForeColor = System.Drawing.Color.Black
        Me.rbInhabilita.Location = New System.Drawing.Point(6, 16)
        Me.rbInhabilita.Name = "rbInhabilita"
        Me.rbInhabilita.Size = New System.Drawing.Size(152, 24)
        Me.rbInhabilita.TabIndex = 0
        Me.rbInhabilita.Text = "&Inhabilitación Efectuada"
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(336, 19)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha.TabIndex = 1
        Me.dtpFecha.Value = New Date(2004, 9, 9, 11, 34, 0, 0)
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(100, 74)
        Me.txtObservaciones.MaxLength = 100
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(448, 40)
        Me.txtObservaciones.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Observaciones:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(186, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 16)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Fecha Inicio Inhabilitación:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.chkResJV)
        Me.GroupBox2.Controls.Add(Me.dtpFecJV)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtNoActaJV)
        Me.GroupBox2.Controls.Add(Me.txtObsJV)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(23, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(557, 87)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dictamen de la Junta de Vigilancia"
        '
        'chkResJV
        '
        Me.chkResJV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResJV.ForeColor = System.Drawing.Color.Black
        Me.chkResJV.Location = New System.Drawing.Point(358, 22)
        Me.chkResJV.Name = "chkResJV"
        Me.chkResJV.Size = New System.Drawing.Size(80, 16)
        Me.chkResJV.TabIndex = 2
        Me.chkResJV.Text = "&Resolución"
        '
        'dtpFecJV
        '
        Me.dtpFecJV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecJV.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecJV.Location = New System.Drawing.Point(264, 21)
        Me.dtpFecJV.Name = "dtpFecJV"
        Me.dtpFecJV.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecJV.TabIndex = 1
        Me.dtpFecJV.Value = New Date(2004, 9, 9, 11, 32, 0, 0)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(186, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Fecha Acta:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "No. de Acta:"
        '
        'txtNoActaJV
        '
        Me.txtNoActaJV.Location = New System.Drawing.Point(92, 21)
        Me.txtNoActaJV.MaxLength = 20
        Me.txtNoActaJV.Name = "txtNoActaJV"
        Me.txtNoActaJV.Size = New System.Drawing.Size(88, 20)
        Me.txtNoActaJV.TabIndex = 0
        '
        'txtObsJV
        '
        Me.txtObsJV.Location = New System.Drawing.Point(107, 47)
        Me.txtObsJV.MaxLength = 255
        Me.txtObsJV.Multiline = True
        Me.txtObsJV.Name = "txtObsJV"
        Me.txtObsJV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsJV.Size = New System.Drawing.Size(441, 34)
        Me.txtObsJV.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(13, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 85
        Me.Label10.Text = "Observaciones:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.dtpFecCA)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.txtNoActaCA)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(23, 244)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(557, 56)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dictamen del Consejo de Administración"
        '
        'dtpFecCA
        '
        Me.dtpFecCA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecCA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCA.Location = New System.Drawing.Point(264, 22)
        Me.dtpFecCA.Name = "dtpFecCA"
        Me.dtpFecCA.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecCA.TabIndex = 1
        Me.dtpFecCA.Value = New Date(2004, 9, 9, 11, 32, 0, 0)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(186, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Fecha Acta:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "No. de Acta:"
        '
        'txtNoActaCA
        '
        Me.txtNoActaCA.Location = New System.Drawing.Point(92, 24)
        Me.txtNoActaCA.MaxLength = 20
        Me.txtNoActaCA.Name = "txtNoActaCA"
        Me.txtNoActaCA.Size = New System.Drawing.Size(88, 20)
        Me.txtNoActaCA.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.txtDui)
        Me.GroupBox4.Controls.Add(Me.txtCodAntiguo)
        Me.GroupBox4.Controls.Add(Me.Label48)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.txtNoSocio)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtNombre)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(557, 88)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Asociado"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(224, 20)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(120, 20)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'txtCodAntiguo
        '
        Me.txtCodAntiguo.Location = New System.Drawing.Point(444, 21)
        Me.txtCodAntiguo.MaxLength = 10
        Me.txtCodAntiguo.Name = "txtCodAntiguo"
        Me.txtCodAntiguo.Size = New System.Drawing.Size(104, 20)
        Me.txtCodAntiguo.TabIndex = 2
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(350, 23)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(88, 16)
        Me.Label48.TabIndex = 114
        Me.Label48.Text = "Código Antiguo:"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(186, 24)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(32, 16)
        Me.Label31.TabIndex = 94
        Me.Label31.Text = "Dui:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.Location = New System.Drawing.Point(92, 20)
        Me.txtNoSocio.MaxLength = 8
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(88, 20)
        Me.txtNoSocio.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "No. Asociado:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(92, 46)
        Me.txtNombre.MaxLength = 150
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(456, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(6, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 16)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Asociado:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(493, 448)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(87, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 141
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsInhabilita
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(599, 495)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsInhabilita"
        Me.ShowInTaskbar = False
        Me.Text = "Inhabilitación de Asociados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Propiedades"
    Public Property Correlativo() As Long
        Get
            Return pCorrelativo
        End Get
        Set(ByVal Value As Long)
            pCorrelativo = Value
        End Set
    End Property
    Public Property UsuarioInhabilita() As String
        Get
            Return pUsuarioInhabilita
        End Get
        Set(ByVal Value As String)
            pUsuarioInhabilita = Value
        End Set
    End Property
    Public Property UsuarioRehabilita() As String
        Get
            Return pUsuarioRehabilita
        End Get
        Set(ByVal Value As String)
            pUsuarioRehabilita = Value
        End Set
    End Property
#End Region

#Region "Métodos"

    Private Sub LoadForm()

        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet

        Try
            dtpFecCA.Value = Date.Today
            dtpFecha.Value = Date.Today
            dtpFecJV.Value = Date.Today

            If Me.btnGuardar1.Text = "&Modificar" Then

                Dim Filas As Data.DataRowCollection
                'Dim vLen As Long, x As Integer

                ds = oAsoc.ConsultarInhabilitados("*", "Correlativo='" & Me.Correlativo & "'", "Correlativo", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not Filas.Item(0)("InhabilitacionEfectuada") Is DBNull.Value Then
                        If CStr(Filas.Item(0)("InhabilitacionEfectuada")) = 0 Then
                            Me.rbInhabilita.Checked = False = False
                        ElseIf CStr(Filas.Item(0)("InhabilitacionEfectuada")) = 1 Then
                            Me.rbInhabilita.Checked = True
                            Me.rbRehabilitacion.Enabled = True
                        End If
                    End If
                    If Not Filas.Item(0)("FechaInhabilitacion") Is DBNull.Value Then
                        dtpFecha.Value = Filas.Item(0)("FechaInhabilitacion")
                    End If
                    txtObservaciones.Text = CStr(Filas.Item(0)("Observacion"))
                    txtNoActaCA.Text = CStr(Filas.Item(0)("ActaNo"))
                    If Not Filas.Item(0)("FechaActa") Is DBNull.Value Then
                        dtpFecCA.Value = Filas.Item(0)("FechaActa")
                    End If
                    If Not Filas.Item(0)("Rehabilitacion") Is DBNull.Value Then
                        If CStr(Filas.Item(0)("Rehabilitacion")) = 0 Then
                            Me.rbRehabilitacion.Checked = False
                        ElseIf CStr(Filas.Item(0)("Rehabilitacion")) = 1 Then
                            Me.rbRehabilitacion.Checked = True
                        End If
                    End If
                    If Not Filas.Item(0)("FechaRehabilita") Is DBNull.Value Then
                        Me.dtpFecRehabilitacion.Value = CDate(Filas.Item(0)("FechaRehabilita"))
                    End If
                    txtNoActaJV.Text = Filas.Item(0)("ActaJuntaVNo")
                    If Not Filas.Item(0)("FechaActaJuntaV") Is DBNull.Value Then
                        dtpFecJV.Value = CDate(Filas.Item(0)("FechaActaJuntaV"))
                    End If
                    If Not Filas.Item(0)("ResolucionJuntaV") Is DBNull.Value Then
                        If CStr(Filas.Item(0)("ResolucionJuntaV")) = 0 Then
                            chkResJV.Checked = False
                        ElseIf CStr(Filas.Item(0)("ResolucionJuntaV")) = 1 Then
                            chkResJV.Checked = True
                        End If
                    End If
                    txtObsJV.Text = CStr(Filas.Item(0)("ObservacionJuntaV"))
                End If
                ds = oAsoc.ConsultarAsociado("NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre", "Dui='" & Trim(txtDui.Text) & "'", "Dui", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNoSocio.Text = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))
                    txtCodAntiguo.Text = IIf(IsDBNull(Filas.Item(0)("CodAntiguo")), "", Filas.Item(0)("CodAntiguo"))
                    txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                    txtDui.Enabled = False
                    txtCodAntiguo.Enabled = False
                    txtNoSocio.Enabled = False
                    txtNombre.Enabled = False
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Error en la carga de datos Módulo Asociados." & vbCrLf & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Guardar()
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String
        Try
            'Validaciones
            Select Case oAsoc.AutorizaDatos(Trim(txtDui.Text), Trim(Me.txtNoActaJV.Text), "x", "x", "x")
                Case 1
                    MsgBox("El campo Dui del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                    Exit Sub
                Case 2
                    MsgBox("El No. de Acta de Junta de Vigilancia no puede quedar vacía. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then
                If Me.rbInhabilita.Checked = True Then
                    If oAsoc.ProcesoInhabilitadosAsociados(Trim(Me.txtDui.Text), Trim(Me.txtNoActaCA.Text), Me.dtpFecCA.Value, sUsuario, sPassword, sSucursal) = False Then
                        MsgBox("El Usuario no puede ser Inhabilitado. Error de validación / derechos en Proceso Módulo Asociados.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    pCampos = "Correlativo,Dui,InhabilitacionEfectuada,FechaInhabilitacion,Observacion,ActaNo,FechaActa,UsuarioInhabilita,FechaUsuarioInhabilita,ActaJuntaVNo,FechaActaJuntaV,ResolucionJuntaV,ObservacionJuntaV,Rehabilitacion"
                    pValores = "" & oAsoc.ObtenerCorrelativoInhabilitados("Correlativo", sUsuario, sPassword, sSucursal) & ",'" & Trim(txtDui.Text) & "','" & System.Math.Abs(CInt(Me.rbInhabilita.Checked)) & "','" & Format(Me.dtpFecha.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtObservaciones.Text) & "','" & Trim(Me.txtNoActaCA.Text) & "','" & Format(Me.dtpFecCA.Value, "dd/MM/yyyy") & "','" & Me.UsuarioInhabilita & "','" & Format(Date.Today, "dd/MM/yyyy") & "','" & Trim(txtNoActaJV.Text) & "','" & Format(Me.dtpFecJV.Value, "dd/MM/yyyy") & "','" & System.Math.Abs(CInt(Me.chkResJV.Checked)) & "','" & Trim(Me.txtObsJV.Text) & "','0'"
                ElseIf Me.rbRehabilitacion.Checked = True Then
                    If oAsoc.ProcesoRehabilitadosAsociados(Trim(Me.txtDui.Text), Trim(Me.txtNoActaCA.Text), Me.dtpFecCA.Value, sUsuario, sPassword, sSucursal) = False Then
                        MsgBox("El Usuario no puede ser Rehabilitado. Error de validación / derechos en Proceso Módulo Asociados.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    pCampos = "Correlativo,Dui,Observacion,ActaNo,FechaActa,Rehabilitacion,FechaRehabilita,UsuarioRehabilita,FechaUsuarioRehabilita,ActaJuntaVNo,FechaActaJuntaV,ResolucionJuntaV,ObservacionJuntaV"
                    pValores = "" & oAsoc.ObtenerCorrelativoInhabilitados("Correlativo", sUsuario, sPassword, sSucursal) & ",'" & Trim(txtDui.Text) & "','" & Trim(Me.txtObservaciones.Text) & "','" & Trim(Me.txtNoActaCA.Text) & "','" & Format(Me.dtpFecCA.Value, "dd/MM/yyyy") & "','" & System.Math.Abs(CInt(Me.rbRehabilitacion.Checked)) & "','" & Format(Me.dtpFecRehabilitacion.Value, "dd/MM/yyyy") & "','" & Me.UsuarioRehabilita & "','" & Format(Date.Today, "dd/MM/yyyy") & "','" & Trim(txtNoActaJV.Text) & "','" & Format(Me.dtpFecJV.Value, "dd/MM/yyyy") & "','" & System.Math.Abs(CInt(Me.chkResJV.Checked)) & "','" & Trim(Me.txtObsJV.Text) & "'"
                ElseIf Me.rbInhabilita.Checked = False And Me.rbRehabilitacion.Checked = False Then
                    pCampos = "Correlativo,Dui,Observacion,ActaNo,FechaActa,ActaJuntaVNo,FechaActaJuntaV,ResolucionJuntaV,ObservacionJuntaV"
                    pValores = "" & oAsoc.ObtenerCorrelativoInhabilitados("Correlativo", sUsuario, sPassword, sSucursal) & ",'" & Trim(txtDui.Text) & "','" & Trim(Me.txtObservaciones.Text) & "','" & Trim(Me.txtNoActaCA.Text) & "','" & Format(Me.dtpFecCA.Value, "dd/MM/yyyy") & "','" & Trim(txtNoActaJV.Text) & "','" & Format(Me.dtpFecJV.Value, "dd/MM/yyyy") & "','" & System.Math.Abs(CInt(Me.chkResJV.Checked)) & "','" & Trim(Me.txtObsJV.Text) & "'"
                End If
                If oAsoc.InsertarInhabilitados(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Registro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                If Me.rbInhabilita.Checked = True Then
                    If oAsoc.ProcesoInhabilitadosAsociados(Trim(Me.txtDui.Text), Trim(Me.txtNoActaCA.Text), Me.dtpFecCA.Value, sUsuario, sPassword, sSucursal) = False Then
                        MsgBox("El Usuario no puede ser Inhabilitado. Error de validación / derechos en Proceso Módulo Asociados.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    pCampos = "Dui='" & Trim(txtDui.Text) & "',InhabilitacionEfectuada='" & System.Math.Abs(CInt(Me.rbInhabilita.Checked)) & "',FechaInhabilitacion='" & Format(Me.dtpFecha.Value, "dd/MM/yyyy") & "',Observacion='" & Trim(Me.txtObservaciones.Text) & "',ActaNo='" & Trim(Me.txtNoActaCA.Text) & "',FechaActa='" & Format(Me.dtpFecCA.Value, "dd/MM/yyyy") & "',UsuarioInhabilita='" & Me.UsuarioInhabilita & "',FechaUsuarioInhabilita='" & Format(Date.Today, "dd/MM/yyyy") & "',ActaJuntaVNo='" & Trim(txtNoActaJV.Text) & "',FechaActaJuntaV='" & Format(Me.dtpFecJV.Value, "dd/MM/yyyy") & "',ResolucionJuntaV='" & System.Math.Abs(CInt(Me.chkResJV.Checked)) & "',ObservacionJuntaV='" & Trim(Me.txtObsJV.Text) & "',Rehabilitacion='0'"
                ElseIf Me.rbRehabilitacion.Checked = True Then
                    If oAsoc.ProcesoRehabilitadosAsociados(Trim(Me.txtDui.Text), Trim(Me.txtNoActaCA.Text), Me.dtpFecCA.Value, sUsuario, sPassword, sSucursal) = False Then
                        MsgBox("El Usuario no puede ser Rehabilitado. Error de validación / derechos en Proceso Módulo Asociados.", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                    pCampos = "Dui='" & Trim(txtDui.Text) & "',Observacion='" & Trim(Me.txtObservaciones.Text) & "',ActaNo='" & Trim(Me.txtNoActaCA.Text) & "',FechaActa='" & Format(Me.dtpFecCA.Value, "dd/MM/yyyy") & "',Rehabilitacion='" & System.Math.Abs(CInt(Me.rbRehabilitacion.Checked)) & "',FechaRehabilita='" & Format(Me.dtpFecRehabilitacion.Value, "dd/MM/yyyy") & "',UsuarioRehabilita='" & Me.UsuarioRehabilita & "',FechaUsuarioRehabilita='" & Format(Date.Today, "dd/MM/yyyy") & "',ActaJuntaVNo='" & Trim(txtNoActaJV.Text) & "',FechaActaJuntaV='" & Format(Me.dtpFecJV.Value, "dd/MM/yyyy") & "',ResolucionJuntaV='" & System.Math.Abs(CInt(Me.chkResJV.Checked)) & "',ObservacionJuntaV='" & Trim(Me.txtObsJV.Text) & "'"
                ElseIf Me.rbInhabilita.Checked = False And Me.rbRehabilitacion.Checked = False Then
                    pCampos = "Dui='" & Trim(txtDui.Text) & "',Observacion='" & Trim(Me.txtObservaciones.Text) & "',ActaNo='" & Trim(Me.txtNoActaCA.Text) & "',FechaActa='" & Format(Me.dtpFecCA.Value, "dd/MM/yyyy") & "',ActaJuntaVNo='" & Trim(txtNoActaJV.Text) & "',FechaActaJuntaV='" & Format(Me.dtpFecJV.Value, "dd/MM/yyyy") & "',ResolucionJuntaV='" & System.Math.Abs(CInt(Me.chkResJV.Checked)) & "',ObservacionJuntaV='" & Trim(Me.txtObsJV.Text) & "'"
                End If
                If oAsoc.ModificarInhabilitados("Correlativo=" & Me.Correlativo & "", pCampos, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("El Registro ha sido modificado.", MsgBoxStyle.Information)
                    Me.Dispose()
                Else
                    MsgBox("El Registro No ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Error en el registro de datos Módulo Asociados." & vbCrLf & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "Eventos"

    Private Sub frmMsExclusion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub
    Private Sub txtNoActaCA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoActaCA.TextChanged
        If Me.txtNoActaCA.Text.Length = 0 Or Trim(Me.txtNoActaCA.Text) = "" Then
            Me.rbInhabilita.Enabled = False
        Else
            Me.rbInhabilita.Enabled = True
        End If
    End Sub

    Private Sub txtCodAntiguo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodAntiguo.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                If txtCodAntiguo.Text.Trim = "" Then
                    txtCodAntiguo_DoubleClick(sender, e)
                Else
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                    ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "CodAntiguo='" & txtCodAntiguo.Text.Trim & "'", "DUI,CodAntiguo", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio"))
                        txtCodAntiguo.Text = IIf(IsDBNull(Filas.Item(0)("CodAntiguo")), "", Filas.Item(0)("CodAntiguo"))
                        txtDui.Text = CStr(Filas.Item(0)("DUI"))
                        txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                    Else
                        txtNoSocio_DoubleClick(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCodAntiguo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodAntiguo.DoubleClick

        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Asociados"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodAntiguo.Text = ofrm.Resultado3.Trim
            txtNoSocio.Text = ofrm.Resultado2.Trim
            txtDui.Text = ofrm.Resultado.Trim
            txtNombre.Text = ofrm.Resultado4.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtNoSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSocio.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                If txtNoSocio.Text.Trim = "" Then
                    txtNoSocio_DoubleClick(sender, e)
                Else
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                    ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "NoSocio='" & txtNoSocio.Text.Trim & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio"))
                        txtDui.Text = CStr(Filas.Item(0)("DUI"))
                        txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                        txtCodAntiguo.Text = IIf(IsDBNull(Filas.Item(0)("CodAntiguo")), "", Filas.Item(0)("CodAntiguo"))
                    Else
                        txtNoSocio_DoubleClick(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNoSocio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoSocio.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Asociados"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtNoSocio.Text = ofrm.Resultado2.Trim
            txtDui.Text = ofrm.Resultado.Trim
            txtNombre.Text = ofrm.Resultado4.Trim
            txtCodAntiguo.Text = ofrm.Resultado3
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

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

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Asociados"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtNoSocio.Text = ofrm.Resultado2.Trim
            txtDui.Value = ofrm.Resultado.Trim
            txtNombre.Text = ofrm.Resultado4.Trim
            txtCodAntiguo.Text = ofrm.Resultado3
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click

        Guardar()
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        Try
            If txtDui.Text.Trim = "" Then
            Else
                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre", "Dui='" & txtDui.Text.Trim & "' and EstadoAsociado<>'2' and EstadoAsociado<>'1'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio")).Trim
                    txtDui.Value = CStr(Filas.Item(0)("DUI")).Trim
                    txtNombre.Text = CStr(Filas.Item(0)("Nombre")).Trim
                    txtCodAntiguo.Text = CStr(Filas.Item(0)("CodAntiguo")).Trim
                Else
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class