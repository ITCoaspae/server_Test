Public Class frmMsExclusion
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton

#Region "Campos"
    Private pCorrelativo As Long
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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpFecJV As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoActaJV As System.Windows.Forms.TextBox
    Friend WithEvents txtObsJV As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecCA As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoActaCA As System.Windows.Forms.TextBox
    Friend WithEvents txtObsCA As System.Windows.Forms.TextBox
    Friend WithEvents txtNoLiquidacion As System.Windows.Forms.TextBox
    Friend WithEvents chkNotificacion As System.Windows.Forms.CheckBox
    Friend WithEvents chkNotifRecibida As System.Windows.Forms.CheckBox
    Friend WithEvents chkExclusionEfectuada As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFecRecepcion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecExclusion As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkLiquidacion As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFecEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoCheque As System.Windows.Forms.TextBox
    Friend WithEvents chkResJV As System.Windows.Forms.CheckBox
    Friend WithEvents chkResCA As System.Windows.Forms.CheckBox
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
        Me.chkResJV = New System.Windows.Forms.CheckBox()
        Me.dtpFecJV = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoActaJV = New System.Windows.Forms.TextBox()
        Me.txtObsJV = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkResCA = New System.Windows.Forms.CheckBox()
        Me.dtpFecCA = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNoActaCA = New System.Windows.Forms.TextBox()
        Me.txtObsCA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtNoLiquidacion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkNotificacion = New System.Windows.Forms.CheckBox()
        Me.chkNotifRecibida = New System.Windows.Forms.CheckBox()
        Me.chkExclusionEfectuada = New System.Windows.Forms.CheckBox()
        Me.dtpFecRecepcion = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFecExclusion = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkLiquidacion = New System.Windows.Forms.CheckBox()
        Me.dtpFecEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNoCheque = New System.Windows.Forms.TextBox()
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
        Me.GroupBox1.Controls.Add(Me.chkResJV)
        Me.GroupBox1.Controls.Add(Me.dtpFecJV)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNoActaJV)
        Me.GroupBox1.Controls.Add(Me.txtObsJV)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(23, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 87)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dictamen de la Junta de Vigilancia"
        '
        'chkResJV
        '
        Me.chkResJV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResJV.ForeColor = System.Drawing.Color.Black
        Me.chkResJV.Location = New System.Drawing.Point(379, 22)
        Me.chkResJV.Name = "chkResJV"
        Me.chkResJV.Size = New System.Drawing.Size(80, 16)
        Me.chkResJV.TabIndex = 5
        Me.chkResJV.Text = "&Resolución"
        '
        'dtpFecJV
        '
        Me.dtpFecJV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecJV.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecJV.Location = New System.Drawing.Point(264, 19)
        Me.dtpFecJV.Name = "dtpFecJV"
        Me.dtpFecJV.Size = New System.Drawing.Size(97, 20)
        Me.dtpFecJV.TabIndex = 3
        Me.dtpFecJV.Value = New Date(2004, 9, 9, 11, 32, 0, 0)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(186, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "Fecha Acta:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "No. de Acta:"
        '
        'txtNoActaJV
        '
        Me.txtNoActaJV.Location = New System.Drawing.Point(92, 19)
        Me.txtNoActaJV.MaxLength = 20
        Me.txtNoActaJV.Name = "txtNoActaJV"
        Me.txtNoActaJV.Size = New System.Drawing.Size(88, 20)
        Me.txtNoActaJV.TabIndex = 2
        '
        'txtObsJV
        '
        Me.txtObsJV.Location = New System.Drawing.Point(92, 45)
        Me.txtObsJV.MaxLength = 255
        Me.txtObsJV.Multiline = True
        Me.txtObsJV.Name = "txtObsJV"
        Me.txtObsJV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsJV.Size = New System.Drawing.Size(442, 34)
        Me.txtObsJV.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 22)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Observaciones:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.chkResCA)
        Me.GroupBox2.Controls.Add(Me.dtpFecCA)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtNoActaCA)
        Me.GroupBox2.Controls.Add(Me.txtObsCA)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(23, 229)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(548, 85)
        Me.GroupBox2.TabIndex = 102
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dictamen del Consejo de Administración"
        '
        'chkResCA
        '
        Me.chkResCA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResCA.ForeColor = System.Drawing.Color.Black
        Me.chkResCA.Location = New System.Drawing.Point(379, 19)
        Me.chkResCA.Name = "chkResCA"
        Me.chkResCA.Size = New System.Drawing.Size(80, 16)
        Me.chkResCA.TabIndex = 9
        Me.chkResCA.Text = "Re&solución"
        Me.chkResCA.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpFecCA
        '
        Me.dtpFecCA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecCA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCA.Location = New System.Drawing.Point(264, 19)
        Me.dtpFecCA.Name = "dtpFecCA"
        Me.dtpFecCA.Size = New System.Drawing.Size(97, 20)
        Me.dtpFecCA.TabIndex = 7
        Me.dtpFecCA.Value = New Date(2004, 9, 9, 11, 32, 0, 0)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(186, 23)
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
        Me.txtNoActaCA.Location = New System.Drawing.Point(92, 19)
        Me.txtNoActaCA.MaxLength = 20
        Me.txtNoActaCA.Name = "txtNoActaCA"
        Me.txtNoActaCA.Size = New System.Drawing.Size(88, 20)
        Me.txtNoActaCA.TabIndex = 6
        '
        'txtObsCA
        '
        Me.txtObsCA.Location = New System.Drawing.Point(92, 45)
        Me.txtObsCA.MaxLength = 255
        Me.txtObsCA.Multiline = True
        Me.txtObsCA.Name = "txtObsCA"
        Me.txtObsCA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsCA.Size = New System.Drawing.Size(442, 34)
        Me.txtObsCA.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 18)
        Me.Label7.TabIndex = 85
        Me.Label7.Text = "Observaciones:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txtNoLiquidacion)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.chkNotificacion)
        Me.GroupBox3.Controls.Add(Me.chkNotifRecibida)
        Me.GroupBox3.Controls.Add(Me.chkExclusionEfectuada)
        Me.GroupBox3.Controls.Add(Me.dtpFecRecepcion)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.dtpFecExclusion)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.chkLiquidacion)
        Me.GroupBox3.Controls.Add(Me.dtpFecEmision)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtNoCheque)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(23, 320)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(548, 149)
        Me.GroupBox3.TabIndex = 103
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de la Exclusión"
        '
        'txtNoLiquidacion
        '
        Me.txtNoLiquidacion.Location = New System.Drawing.Point(438, 83)
        Me.txtNoLiquidacion.MaxLength = 20
        Me.txtNoLiquidacion.Name = "txtNoLiquidacion"
        Me.txtNoLiquidacion.Size = New System.Drawing.Size(96, 20)
        Me.txtNoLiquidacion.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(240, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 110
        Me.Label12.Text = "No. de liquidación:"
        '
        'chkNotificacion
        '
        Me.chkNotificacion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNotificacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNotificacion.ForeColor = System.Drawing.Color.Black
        Me.chkNotificacion.Location = New System.Drawing.Point(9, 57)
        Me.chkNotificacion.Name = "chkNotificacion"
        Me.chkNotificacion.Size = New System.Drawing.Size(200, 16)
        Me.chkNotificacion.TabIndex = 15
        Me.chkNotificacion.Text = "&Notificación de Exclusión &emitida"
        '
        'chkNotifRecibida
        '
        Me.chkNotifRecibida.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNotifRecibida.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNotifRecibida.ForeColor = System.Drawing.Color.Black
        Me.chkNotifRecibida.Location = New System.Drawing.Point(9, 79)
        Me.chkNotifRecibida.Name = "chkNotifRecibida"
        Me.chkNotifRecibida.Size = New System.Drawing.Size(200, 16)
        Me.chkNotifRecibida.TabIndex = 16
        Me.chkNotifRecibida.Text = "Notificación de Exclusión &recibida"
        '
        'chkExclusionEfectuada
        '
        Me.chkExclusionEfectuada.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkExclusionEfectuada.Enabled = False
        Me.chkExclusionEfectuada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkExclusionEfectuada.ForeColor = System.Drawing.Color.Black
        Me.chkExclusionEfectuada.Location = New System.Drawing.Point(9, 123)
        Me.chkExclusionEfectuada.Name = "chkExclusionEfectuada"
        Me.chkExclusionEfectuada.Size = New System.Drawing.Size(144, 16)
        Me.chkExclusionEfectuada.TabIndex = 17
        Me.chkExclusionEfectuada.Text = "&Exclusión efectuada"
        '
        'dtpFecRecepcion
        '
        Me.dtpFecRecepcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecRecepcion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecRecepcion.Location = New System.Drawing.Point(446, 27)
        Me.dtpFecRecepcion.Name = "dtpFecRecepcion"
        Me.dtpFecRecepcion.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecRecepcion.TabIndex = 13
        Me.dtpFecRecepcion.Value = New Date(2004, 9, 9, 11, 33, 0, 0)
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(350, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 27)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "Fecha Recepción " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Notificación:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecExclusion
        '
        Me.dtpFecExclusion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecExclusion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecExclusion.Location = New System.Drawing.Point(71, 27)
        Me.dtpFecExclusion.Name = "dtpFecExclusion"
        Me.dtpFecExclusion.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecExclusion.TabIndex = 10
        Me.dtpFecExclusion.Value = New Date(2004, 9, 9, 11, 33, 0, 0)
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 32)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exclusión:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkLiquidacion
        '
        Me.chkLiquidacion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLiquidacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLiquidacion.ForeColor = System.Drawing.Color.Black
        Me.chkLiquidacion.Location = New System.Drawing.Point(9, 101)
        Me.chkLiquidacion.Name = "chkLiquidacion"
        Me.chkLiquidacion.Size = New System.Drawing.Size(144, 16)
        Me.chkLiquidacion.TabIndex = 14
        Me.chkLiquidacion.Text = "&Liquidación caja"
        '
        'dtpFecEmision
        '
        Me.dtpFecEmision.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecEmision.Location = New System.Drawing.Point(264, 27)
        Me.dtpFecEmision.Name = "dtpFecEmision"
        Me.dtpFecEmision.Size = New System.Drawing.Size(80, 20)
        Me.dtpFecEmision.TabIndex = 12
        Me.dtpFecEmision.Value = New Date(2004, 9, 9, 11, 32, 0, 0)
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(176, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 32)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Fecha Emisión " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Notificación:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(241, 57)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(184, 16)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "No. de cheque cancela liquidación:"
        '
        'txtNoCheque
        '
        Me.txtNoCheque.Location = New System.Drawing.Point(446, 57)
        Me.txtNoCheque.MaxLength = 20
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.Size = New System.Drawing.Size(88, 20)
        Me.txtNoCheque.TabIndex = 11
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
        Me.GroupBox4.Size = New System.Drawing.Size(548, 67)
        Me.GroupBox4.TabIndex = 106
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Asociado"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(224, 13)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(120, 20)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'txtCodAntiguo
        '
        Me.txtCodAntiguo.Location = New System.Drawing.Point(438, 12)
        Me.txtCodAntiguo.MaxLength = 10
        Me.txtCodAntiguo.Name = "txtCodAntiguo"
        Me.txtCodAntiguo.Size = New System.Drawing.Size(104, 20)
        Me.txtCodAntiguo.TabIndex = 2
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(350, 16)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(88, 16)
        Me.Label48.TabIndex = 114
        Me.Label48.Text = "Código Antiguo:"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(186, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(32, 16)
        Me.Label31.TabIndex = 94
        Me.Label31.Text = "Dui:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.Location = New System.Drawing.Point(92, 13)
        Me.txtNoSocio.MaxLength = 8
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(88, 20)
        Me.txtNoSocio.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "No. Asociado:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(92, 39)
        Me.txtNombre.MaxLength = 150
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(450, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(6, 40)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 16)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Asociado:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(484, 475)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(87, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 139
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsExclusion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(590, 520)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsExclusion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Proceso Exclusión de Asociados"
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
#End Region

#Region "Métodos"

    Private Sub LoadForm()

        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet

        Try
            dtpFecCA.Value = Date.Today
            dtpFecEmision.Value = Date.Today
            dtpFecExclusion.Value = Date.Today
            dtpFecJV.Value = Date.Today
            dtpFecRecepcion.Value = Date.Today

            If Me.btnGuardar1.Text = "&Modificar" Then

                Dim Filas As Data.DataRowCollection ', vLen As Long, x As Integer

                ds = oAsoc.ConsultarExclusion("*", "Correlativo='" & Me.Correlativo & "'", "Correlativo", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    dtpFecExclusion.Value = CDate(Filas.Item(0)("FechaExclusion"))
                    txtNoActaJV.Text = CStr(Filas.Item(0)("ActaJuntaVNo"))
                    dtpFecJV.Value = CDate(Filas.Item(0)("FechaActaJuntaV"))
                    If CStr(Filas.Item(0)("ResolucionJuntaV")) = 0 Then
                        chkResJV.Checked = False
                    ElseIf CStr(Filas.Item(0)("ResolucionJuntaV")) = 1 Then
                        chkResJV.Checked = True
                    End If
                    txtObsJV.Text = CStr(Filas.Item(0)("ObservacionJuntaV"))
                    txtNoActaCA.Text = CStr(Filas.Item(0)("ActaNo"))
                    dtpFecCA.Value = CDate(Filas.Item(0)("FechaActa"))
                    If CStr(Filas.Item(0)("Resolucion")) = 0 Then
                        chkResCA.Checked = False
                    ElseIf CStr(Filas.Item(0)("Resolucion")) = 1 Then
                        chkResCA.Checked = True
                    End If
                    txtObsCA.Text = CStr(Filas.Item(0)("Observacion"))
                    If CStr(Filas.Item(0)("Liquidacion")) = 0 Then
                        chkLiquidacion.Checked = False
                    ElseIf CStr(Filas.Item(0)("Liquidacion")) = 1 Then
                        chkLiquidacion.Checked = True
                    End If
                    txtNoCheque.Text = CStr(Filas.Item(0)("NoCheque"))
                    txtNoLiquidacion.Text = CStr(Filas.Item(0)("NoLiquidacion"))
                    If CStr(Filas.Item(0)("EmitioNotificacion")) = 0 Then
                        chkNotificacion.Checked = False
                    ElseIf CStr(Filas.Item(0)("EmitioNotificacion")) = 1 Then
                        chkNotificacion.Checked = True
                    End If
                    dtpFecEmision.Value = CDate(Filas.Item(0)("FechaNotificacion"))
                    dtpFecRecepcion.Value = CDate(Filas.Item(0)("FechaRecibeNotificacion"))
                    If CStr(Filas.Item(0)("RecibeNotificacion")) = 0 Then
                        chkNotifRecibida.Checked = False
                    ElseIf CStr(Filas.Item(0)("RecibeNotificacion")) = 1 Then
                        chkNotifRecibida.Checked = True
                    End If
                    If CStr(Filas.Item(0)("ExclusionEfectuada")) = 0 Then
                        chkExclusionEfectuada.Checked = False
                    ElseIf CStr(Filas.Item(0)("ExclusionEfectuada")) = 1 Then
                        chkExclusionEfectuada.Checked = True
                    End If
                    If Trim(Me.txtNoActaCA.Text) <> "" Then
                        chkExclusionEfectuada.Enabled = True
                    End If
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

                pCampos = "Dui,FechaExclusion,ActaJuntaVNo,FechaActaJuntaV,ResolucionJuntaV,ObservacionJuntaV,ActaNo,FechaActa,Resolucion,Observacion,Liquidacion,NoCheque,NoLiquidacion,EmitioNotificacion,FechaNotificacion,FechaRecibeNotificacion,RecibeNotificacion,ExclusionEfectuada,NoSocio"
                pValores = "'" & Trim(txtDui.Text) & "','" & Format(dtpFecExclusion.Value, "dd/MM/yyyy") & "','" & Trim(txtNoActaJV.Text) & "','" & Format(Me.dtpFecJV.Value, "dd/MM/yyyy") & "','" & System.Math.Abs(CInt(Me.chkResJV.Checked)) & "','" & Trim(Me.txtObsJV.Text) & "','" & Trim(Me.txtNoActaCA.Text) & "','" & Format(Me.dtpFecCA.Value, "dd/MM/yyyy") & "','" & System.Math.Abs(CInt(Me.chkResCA.Checked)) & "','" & Trim(Me.txtObsCA.Text) & "','" & System.Math.Abs(CInt(Me.chkLiquidacion.Checked)) & "','" & Trim(Me.txtNoCheque.Text) & "','" & Trim(Me.txtNoLiquidacion.Text) & "','" & System.Math.Abs(CInt(Me.chkNotificacion.Checked)) & "','" & Format(Me.dtpFecEmision.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFecRecepcion.Value, "dd/MM/yyyy") & "','" & System.Math.Abs(CInt(Me.chkNotifRecibida.Checked)) & "','" & System.Math.Abs(CInt(Me.chkExclusionEfectuada.Checked)) & "','" & Me.txtNoSocio.Text.Trim & "'"
                If oAsoc.InsertarExclusion(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Registro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If

            ElseIf Me.btnGuardar1.Text = "&Modificar" Then

                If Me.chkExclusionEfectuada.Enabled = True Then
                    oAsoc.ProcesoExclusionAsociados(Trim(Me.txtDui.Text), Trim(Me.txtNoActaCA.Text), Me.dtpFecCA.Value, sUsuario, sPassword, sSucursal)
                    pCampos = "FechaExclusion='" & Format(dtpFecExclusion.Value, "dd/MM/yyyy") & "',ActaJuntaVNo='" & Trim(txtNoActaJV.Text) & "',FechaActaJuntaV='" & Format(Me.dtpFecJV.Value, "dd/MM/yyyy") & "',ResolucionJuntaV='" & System.Math.Abs(CInt(Me.chkResJV.Checked)) & "',ObservacionJuntaV='" & Trim(Me.txtObsJV.Text) & "',ActaNo='" & Trim(Me.txtNoActaCA.Text) & "',FechaActa='" & Format(Me.dtpFecCA.Value, "dd/MM/yyyy") & "',Resolucion='" & System.Math.Abs(CInt(Me.chkResCA.Checked)) & "',Observacion='" & Trim(Me.txtObsCA.Text) & "',Liquidacion='" & System.Math.Abs(CInt(Me.chkLiquidacion.Checked)) & "',NoCheque='" & Trim(Me.txtNoCheque.Text) & "',NoLiquidacion='" & Trim(Me.txtNoLiquidacion.Text) & "',EmitioNotificacion='" & System.Math.Abs(CInt(Me.chkNotificacion.Checked)) & "',FechaNotificacion='" & Format(Me.dtpFecEmision.Value, "dd/MM/yyyy") & "',FechaRecibeNotificacion='" & Format(Me.dtpFecRecepcion.Value, "dd/MM/yyyy") & "',RecibeNotificacion='" & System.Math.Abs(CInt(Me.chkNotifRecibida.Checked)) & "',ExclusionEfectuada='" & System.Math.Abs(CInt(Me.chkExclusionEfectuada.Checked)) & "',Usuario='" & sUsuario & "',FechaUsuario ='" & Format(Date.Today, "dd/MM/yyyy") & "'"
                Else
                    pCampos = "FechaExclusion='" & Format(dtpFecExclusion.Value, "dd/MM/yyyy") & "',ActaJuntaVNo='" & Trim(txtNoActaJV.Text) & "',FechaActaJuntaV='" & Format(Me.dtpFecJV.Value, "dd/MM/yyyy") & "',ResolucionJuntaV='" & System.Math.Abs(CInt(Me.chkResJV.Checked)) & "',ObservacionJuntaV='" & Trim(Me.txtObsJV.Text) & "',ActaNo='" & Trim(Me.txtNoActaCA.Text) & "',FechaActa='" & Format(Me.dtpFecCA.Value, "dd/MM/yyyy") & "',Resolucion='" & System.Math.Abs(CInt(Me.chkResCA.Checked)) & "',Observacion='" & Trim(Me.txtObsCA.Text) & "',Liquidacion='" & System.Math.Abs(CInt(Me.chkLiquidacion.Checked)) & "',NoCheque='" & Trim(Me.txtNoCheque.Text) & "',NoLiquidacion='" & Trim(Me.txtNoLiquidacion.Text) & "',EmitioNotificacion='" & System.Math.Abs(CInt(Me.chkNotificacion.Checked)) & "',FechaNotificacion='" & Format(Me.dtpFecEmision.Value, "dd/MM/yyyy") & "',FechaRecibeNotificacion='" & Format(Me.dtpFecRecepcion.Value, "dd/MM/yyyy") & "',RecibeNotificacion='" & System.Math.Abs(CInt(Me.chkNotifRecibida.Checked)) & "'"
                End If
                If oAsoc.ModificarExclusion("Correlativo=" & Me.Correlativo & "", pCampos, sUsuario, sPassword, sSucursal) = True Then
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

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
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



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click

        Guardar()
    End Sub
End Class