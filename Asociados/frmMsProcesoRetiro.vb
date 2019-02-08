Public Class frmMsProcesoRetiro
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim asociados As New wrAsociados.wsLibAsoc
    Public pDui As String, pAccion As String, pCorr As String, pCont As Boolean
    Friend WithEvents btGenerarMov1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btGenCheque1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNoSolRetiro As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chkLiquidacion As System.Windows.Forms.CheckBox
    Friend WithEvents btnArchivo As System.Windows.Forms.Button
    Friend WithEvents txtArchivo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNoCheque As System.Windows.Forms.TextBox
    Friend WithEvents txtNoActa As System.Windows.Forms.TextBox
    Friend WithEvents txtNoLiquidacion As System.Windows.Forms.TextBox
    Friend WithEvents chkRetiroEfect As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtEjecMercadeo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEjecMercadeo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtEjecMercadeo = New System.Windows.Forms.TextBox()
        Me.txtCodEjecMercadeo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnArchivo = New System.Windows.Forms.Button()
        Me.txtArchivo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkRetiroEfect = New System.Windows.Forms.CheckBox()
        Me.chkLiquidacion = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoSolRetiro = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoCheque = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNoActa = New System.Windows.Forms.TextBox()
        Me.txtNoLiquidacion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btGenerarMov1 = New MetroFramework.Controls.MetroButton()
        Me.btGenCheque1 = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.txtDui)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.txtNoSocio)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtNombre)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(560, 52)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Asociado"
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(8, 26)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(96, 20)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(8, 13)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(32, 15)
        Me.Label31.TabIndex = 94
        Me.Label31.Text = "Dui:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.Location = New System.Drawing.Point(120, 26)
        Me.txtNoSocio.MaxLength = 8
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(80, 20)
        Me.txtNoSocio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(120, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "No. Asociado:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(216, 26)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(336, 20)
        Me.txtNombre.TabIndex = 90
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(216, 13)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 13)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Asociado:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Controls.Add(Me.txtEjecMercadeo)
        Me.GroupBox1.Controls.Add(Me.txtCodEjecMercadeo)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnArchivo)
        Me.GroupBox1.Controls.Add(Me.txtArchivo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.chkRetiroEfect)
        Me.GroupBox1.Controls.Add(Me.chkLiquidacion)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNoSolRetiro)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNoCheque)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtNoActa)
        Me.GroupBox1.Controls.Add(Me.txtNoLiquidacion)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(23, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 179)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(7, 153)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(144, 16)
        Me.Label46.TabIndex = 131
        Me.Label46.Text = "*Código Ejecutivo Gestión:"
        '
        'txtEjecMercadeo
        '
        Me.txtEjecMercadeo.BackColor = System.Drawing.Color.White
        Me.txtEjecMercadeo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecMercadeo.Location = New System.Drawing.Point(227, 151)
        Me.txtEjecMercadeo.MaxLength = 100
        Me.txtEjecMercadeo.Name = "txtEjecMercadeo"
        Me.txtEjecMercadeo.ReadOnly = True
        Me.txtEjecMercadeo.Size = New System.Drawing.Size(323, 20)
        Me.txtEjecMercadeo.TabIndex = 130
        '
        'txtCodEjecMercadeo
        '
        Me.txtCodEjecMercadeo.BackColor = System.Drawing.Color.White
        Me.txtCodEjecMercadeo.Location = New System.Drawing.Point(157, 151)
        Me.txtCodEjecMercadeo.MaxLength = 10
        Me.txtCodEjecMercadeo.Name = "txtCodEjecMercadeo"
        Me.txtCodEjecMercadeo.Size = New System.Drawing.Size(64, 20)
        Me.txtCodEjecMercadeo.TabIndex = 129
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(16, 118)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 1)
        Me.GroupBox2.TabIndex = 128
        Me.GroupBox2.TabStop = False
        '
        'btnArchivo
        '
        Me.btnArchivo.BackColor = System.Drawing.Color.LightGray
        Me.btnArchivo.ForeColor = System.Drawing.Color.Black
        Me.btnArchivo.Location = New System.Drawing.Point(528, 26)
        Me.btnArchivo.Name = "btnArchivo"
        Me.btnArchivo.Size = New System.Drawing.Size(24, 16)
        Me.btnArchivo.TabIndex = 4
        Me.btnArchivo.Text = "..."
        Me.btnArchivo.UseVisualStyleBackColor = False
        '
        'txtArchivo
        '
        Me.txtArchivo.BackColor = System.Drawing.Color.White
        Me.txtArchivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArchivo.Location = New System.Drawing.Point(296, 26)
        Me.txtArchivo.MaxLength = 255
        Me.txtArchivo.Name = "txtArchivo"
        Me.txtArchivo.Size = New System.Drawing.Size(232, 20)
        Me.txtArchivo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(296, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 16)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "Archivo vínculo al Acta Consejo:"
        '
        'chkRetiroEfect
        '
        Me.chkRetiroEfect.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRetiroEfect.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkRetiroEfect.ForeColor = System.Drawing.Color.Black
        Me.chkRetiroEfect.Location = New System.Drawing.Point(272, 122)
        Me.chkRetiroEfect.Name = "chkRetiroEfect"
        Me.chkRetiroEfect.Size = New System.Drawing.Size(112, 20)
        Me.chkRetiroEfect.TabIndex = 8
        Me.chkRetiroEfect.Text = "&Retiro Efectuado"
        '
        'chkLiquidacion
        '
        Me.chkLiquidacion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLiquidacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLiquidacion.ForeColor = System.Drawing.Color.Black
        Me.chkLiquidacion.Location = New System.Drawing.Point(6, 125)
        Me.chkLiquidacion.Name = "chkLiquidacion"
        Me.chkLiquidacion.Size = New System.Drawing.Size(88, 16)
        Me.chkLiquidacion.TabIndex = 6
        Me.chkLiquidacion.Text = "&Liquidación"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "No. Solicitud Retiro:"
        '
        'txtNoSolRetiro
        '
        Me.txtNoSolRetiro.BackColor = System.Drawing.Color.White
        Me.txtNoSolRetiro.Location = New System.Drawing.Point(8, 26)
        Me.txtNoSolRetiro.MaxLength = 50
        Me.txtNoSolRetiro.Name = "txtNoSolRetiro"
        Me.txtNoSolRetiro.Size = New System.Drawing.Size(72, 20)
        Me.txtNoSolRetiro.TabIndex = 0
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(200, 26)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha.TabIndex = 2
        Me.dtpFecha.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.White
        Me.txtObservaciones.Location = New System.Drawing.Point(6, 68)
        Me.txtObservaciones.MaxLength = 100
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(544, 44)
        Me.txtObservaciones.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 85
        Me.Label1.Text = "Observación:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNoCheque
        '
        Me.txtNoCheque.BackColor = System.Drawing.Color.White
        Me.txtNoCheque.Location = New System.Drawing.Point(468, 122)
        Me.txtNoCheque.MaxLength = 20
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoCheque.Size = New System.Drawing.Size(82, 20)
        Me.txtNoCheque.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(200, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 15)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Fecha Acta:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(390, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "No. Cheque:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNoActa
        '
        Me.txtNoActa.BackColor = System.Drawing.Color.White
        Me.txtNoActa.Location = New System.Drawing.Point(120, 26)
        Me.txtNoActa.MaxLength = 20
        Me.txtNoActa.Name = "txtNoActa"
        Me.txtNoActa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoActa.Size = New System.Drawing.Size(72, 20)
        Me.txtNoActa.TabIndex = 1
        '
        'txtNoLiquidacion
        '
        Me.txtNoLiquidacion.BackColor = System.Drawing.Color.White
        Me.txtNoLiquidacion.Location = New System.Drawing.Point(194, 122)
        Me.txtNoLiquidacion.MaxLength = 20
        Me.txtNoLiquidacion.Name = "txtNoLiquidacion"
        Me.txtNoLiquidacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoLiquidacion.Size = New System.Drawing.Size(72, 20)
        Me.txtNoLiquidacion.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(100, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 69
        Me.Label14.Text = "No. Liquidación:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(120, 13)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 15)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "No. Acta:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btGenerarMov1
        '
        Me.btGenerarMov1.Location = New System.Drawing.Point(363, 306)
        Me.btGenerarMov1.Name = "btGenerarMov1"
        Me.btGenerarMov1.Size = New System.Drawing.Size(139, 28)
        Me.btGenerarMov1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btGenerarMov1.TabIndex = 40
        Me.btGenerarMov1.Text = "Generar &Movimientos"
        Me.btGenerarMov1.UseSelectable = True
        Me.btGenerarMov1.UseStyleColors = True
        '
        'btGenCheque1
        '
        Me.btGenCheque1.Location = New System.Drawing.Point(217, 306)
        Me.btGenCheque1.Name = "btGenCheque1"
        Me.btGenCheque1.Size = New System.Drawing.Size(139, 28)
        Me.btGenCheque1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btGenCheque1.TabIndex = 41
        Me.btGenCheque1.Text = "Generar &Cheque"
        Me.btGenCheque1.UseSelectable = True
        Me.btGenCheque1.UseStyleColors = True
        Me.btGenCheque1.Visible = False
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(508, 306)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 42
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsProcesoRetiro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(602, 355)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.btGenCheque1)
        Me.Controls.Add(Me.btGenerarMov1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsProcesoRetiro"
        Me.Text = "Proceso de Retiro Voluntario"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnArchivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArchivo.Click
        Dim openDlg As OpenFileDialog = New OpenFileDialog
        Dim Resultado As DialogResult

        openDlg.Filter = "Todos los Archivos (*.*)|*.*"
        Resultado = openDlg.ShowDialog()

        If Resultado = DialogResult.OK Then
            txtArchivo.Text = openDlg.FileName
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


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
            txtDui.Value = ofrm.Resultado.Trim
            txtNombre.Text = ofrm.Resultado4.Trim

            Dim Filas As Data.DataRowCollection

            ds = oAsoc.ConsultarRetiros("*", "Dui='" & Me.txtDui.Value & "' and NoSocio='" & Me.txtNoSocio.Text.Trim & "'", "Correlativo", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                Me.txtNoSolRetiro.Text = CStr(Filas.Item(0)("NoSolicitudRetiro"))
                Me.txtNoActa.Text = CStr(Filas.Item(0)("ActaNo"))
                Me.dtpFecha.Value = Filas.Item(0)("FechaActa")
                Me.txtArchivo.Text = Filas.Item(0)("ArchivoVinculoActa")
                Me.txtObservaciones.Text = Filas.Item(0)("Observacion")
                Me.txtNoCheque.Text = CStr(Filas.Item(0)("NoCheque"))
                Me.txtNoLiquidacion.Text = CStr(Filas.Item(0)("NoLiquidacion"))
                Me.chkLiquidacion.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("Liquidacion")), "0", Filas.Item(0)("Liquidacion")) = "1", True, False)
                Me.chkRetiroEfect.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("RetiroEfectuado")), "0", Filas.Item(0)("RetiroEfectuado")) = "1", True, False)
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmMsProcesoRetiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Me.dtpFecha.Value = Now
        Try
            If Me.btnGuardar1.Text = "&Modificar" Then

                Dim Filas As Data.DataRowCollection

                ds = oAsoc.ConsultarRetiros("*", "Correlativo='" & pCorr & "'", "Correlativo", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtNoSolRetiro.Text = CStr(Filas.Item(0)("NoSolicitudRetiro"))
                    Me.txtNoActa.Text = CStr(Filas.Item(0)("ActaNo"))
                    Me.dtpFecha.Value = Filas.Item(0)("FechaActa")
                    Me.txtArchivo.Text = Filas.Item(0)("ArchivoVinculoActa")
                    Me.txtObservaciones.Text = Filas.Item(0)("Observacion")
                    Me.txtNoCheque.Text = CStr(Filas.Item(0)("NoCheque"))
                    Me.txtNoLiquidacion.Text = CStr(Filas.Item(0)("NoLiquidacion"))
                    Me.chkLiquidacion.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("Liquidacion")), "0", Filas.Item(0)("Liquidacion")) = "1", True, False)
                    Me.chkRetiroEfect.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("RetiroEfectuado")), "0", Filas.Item(0)("RetiroEfectuado")) = "1", True, False)
                End If
                ds = oAsoc.ConsultarAsociado("NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre", "Dui='" & Trim(txtDui.Text) & "'", "Dui", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNoSocio.Text = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))
                    txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                    txtDui.Enabled = False
                    txtNoSocio.Enabled = False
                    txtNombre.Enabled = False
                    txtNoSolRetiro.Enabled = False
                End If

            End If
            If pCont = True Then
                Me.btGenerarMov1.Visible = True
                Me.btGenCheque1.Visible = True
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la carga de datos Módulo Asociados." & vbCrLf & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Protected Sub validarSolicitudRetiro()
        Dim dtsSolRetiro As New DataSet
        dtsSolRetiro = asociados.ConsultarSolicitudRetiro("NoSolicitudRetiro", "dui = '" & txtDui.Text.Trim & "' and anulado = 'False'  ", "", sUsuario, sPassword, sSucursal)
        If dtsSolRetiro.Tables.Count > 0 Then
            If dtsSolRetiro.Tables(0).Rows.Count > 0 Then
                txtNoSolRetiro.Text = dtsSolRetiro.Tables(0).Rows(0).Item(0).ToString.Trim
            Else
                MsgBox("No se ha creado solicitud de retiro", MsgBoxStyle.Critical, "Módlo - Asociados")
                Me.Close()
            End If
        Else
            MsgBox("No se ha creado solicitud de retiro", MsgBoxStyle.Critical, "Módlo - Asociados")
            Me.Close()
        End If
    End Sub
    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Asociados"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "EstadoAsociado='5' or EstadoAsociado='25'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtNoSocio.Text = ofrm.Resultado2.Trim
            txtDui.Value = ofrm.Resultado.Trim
            Me.txtNombre.Text = ofrm.Resultado4.Trim
            'validarSolicitudRetiro()
            'If pCont = True Then
            Dim Filas As Data.DataRowCollection
            ds = oAsoc.ConsultarRetiros("*", "Dui='" & Me.txtDui.Value & "' and NoSocio='" & Me.txtNoSocio.Text.Trim & "'", "Correlativo", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                MsgBox("El asociado ya cuenta con un proceso de retiro activo.", MsgBoxStyle.Critical, "Módulo - Asociados")
                Me.Close()
                'Me.txtNoSolRetiro.Text = CStr(Filas.Item(0)("NoSolicitudRetiro"))
                'Me.txtNoActa.Text = CStr(Filas.Item(0)("ActaNo"))
                'Me.dtpFecha.Value = Filas.Item(0)("FechaActa")
                'Me.txtArchivo.Text = Filas.Item(0)("ArchivoVinculoActa")
                'Me.txtObservaciones.Text = Filas.Item(0)("Observacion")
                'Me.txtNoCheque.Text = CStr(Filas.Item(0)("NoCheque"))
                'Me.txtNoLiquidacion.Text = CStr(Filas.Item(0)("NoLiquidacion"))
                'Me.chkLiquidacion.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("Liquidacion")), "0", Filas.Item(0)("Liquidacion")) = "1", True, False)
                'Me.chkRetiroEfect.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("RetiroEfectuado")), "0", Filas.Item(0)("RetiroEfectuado")) = "1", True, False)
            End If
            'End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        Try
            If txtDui.Text.Trim = "" Then
            Else
                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,Direccion,TelCasa,Email", "Dui='" & txtDui.Text.Trim & "' and EstadoAsociado<>'2' and EstadoAsociado<>'1'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio")).Trim
                    txtDui.Value = CStr(Filas.Item(0)("DUI")).Trim
                    txtNombre.Text = CStr(Filas.Item(0)("Nombre")).Trim
                    validarSolicitudRetiro()
                    ds = oAsoc.ConsultarRetiros("*", "Dui='" & Me.txtDui.Value & "' and NoSocio='" & Me.txtNoSocio.Text.Trim & "'' ", "Correlativo", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        MsgBox("El asociado ya cuenta con un proceso de retiro activo.", MsgBoxStyle.Critical, "Módulo - Asociados")
                        Me.Close()
                        'Me.txtNoSolRetiro.Text = CStr(Filas.Item(0)("NoSolicitudRetiro"))
                        'Me.txtNoActa.Text = CStr(Filas.Item(0)("ActaNo"))
                        'Me.dtpFecha.Value = Filas.Item(0)("FechaActa")
                        'Me.txtArchivo.Text = Filas.Item(0)("ArchivoVinculoActa")
                        'Me.txtObservaciones.Text = Filas.Item(0)("Observacion")
                        'Me.txtNoCheque.Text = CStr(Filas.Item(0)("NoCheque"))
                        'Me.txtNoLiquidacion.Text = CStr(Filas.Item(0)("NoLiquidacion"))
                        'Me.chkLiquidacion.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("Liquidacion")), "0", Filas.Item(0)("Liquidacion")) = "1", True, False)
                        'Me.chkRetiroEfect.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("RetiroEfectuado")), "0", Filas.Item(0)("RetiroEfectuado")) = "1", True, False)
                    End If


                    'ds = oAsoc.ConsultarSolicitudRetiro("NoSolicitudRetiro", "Dui='" & Me.txtDui.Value & "'", "NoSolicitudRetiro", sUsuario, sPassword, sSucursal)
                    'Filas = ds.Tables(0).Rows()
                    'If Filas.Count > 0 Then
                    '    Me.txtNoSolRetiro.Text = IIf(IsDBNull(Filas.Item(0)("NoSolicitudRetiro")), "", Filas.Item(0)("NoSolicitudRetiro"))
                    'End If

                Else
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btGenerarMov1_Click(sender As Object, e As EventArgs) Handles btGenerarMov1.Click
        Dim oAsoc As New wrAsociados.wsLibAsoc
        Try
            If MsgBox("¿Está seguro que desea generar los movimientos para cancelar las Cuentas?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Retiro de Asociados") = MsgBoxResult.Yes Then
                If oAsoc.Generar_Movimiento_Retiro(Me.txtDui.Text, Me.txtCodEjecMercadeo.Text.Trim, sUsuario, sPassword, sSucursal).Trim = "" Then
                    MessageBox.Show("Movimientos realizados con éxito", "Proceso de Retiro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btGenCheque_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, oApp As New wrAdmin.wsLibAdmin
        Dim pCampos As String, pValores As String
        Try

            If Me.btnGuardar1.Text = "&Guardar" Then

                Select Case oAsoc.AutorizaDatos(Trim(txtDui.Text), "x", "x", "x", "x")
                    Case 1
                        MsgBox("El campo Dui del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                        Exit Sub
                End Select

                pCampos = "NoSolicitudRetiro,Dui," &
                "Observacion,ActaNo, " &
                "FechaActa,Liquidacion," &
                "NoCheque,NoLiquidacion, " &
                "RetiroEfectuado,Usuario," &
                "FechaUsuario,ArchivoVinculoActa, " &
                "NoSocio,FechaIngreso,anulado"

                pValores = "'" & Me.txtNoSolRetiro.Text.Trim & "','" & Me.txtDui.Text.Trim &
                "','" & Me.txtObservaciones.Text.Trim & "','" & Me.txtNoActa.Text.Trim &
                "','" & Format(Me.dtpFecha.Value, "dd/MM/yyyy") & "','" & IIf(Me.chkLiquidacion.Checked = True, "1", "0") &
                "','" & Me.txtNoCheque.Text.Trim & "','" & Me.txtNoLiquidacion.Text.Trim &
                "','" & IIf(Me.chkRetiroEfect.Checked = True, "1", "0") & "','" & sUsuario &
                "','" & Format(Now, "dd/MM/yyyy") & "','" & Me.txtArchivo.Text.Trim &
                "','" & Me.txtNoSocio.Text.Trim & "',Getdate(),'False'"
                If oAsoc.InsertarRetiros(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    If Me.chkRetiroEfect.Checked = True = "1" Then
                        If oAsoc.VerificarProcesoRetiro(Me.txtDui.Text.Trim, Me.txtNoSocio.Text.Trim, sUsuario, sPassword, sSucursal).Trim = "" Then
                            oAsoc.ModificarAsociadoxFiltro("Dui='" & Me.txtDui.Text.Trim & "'", "EstadoAsociado=1,FechaEstado='" & oApp.Fecha.ToShortDateString & "'", sUsuario, sPassword, sSucursal)
                        Else
                            MessageBox.Show("El Asociado tiene saldos pendientes en cuentas de ahorro o préstamos, no puede ser retirado.", "Retiro de Asociados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                    'Dim oAh As New wrAhorro.wsLibAhorro
                    'oAh.ModificarCuentaAhorro("DUI", Me.txtDui.Text.Trim, "Estado='C'", sUsuario, sPassword,sSucursal)
                    Me.Dispose()
                Else
                    MsgBox("El Registro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "NoSolicitudRetiro='" & Me.txtNoSolRetiro.Text.Trim &
                "',Dui='" & Me.txtDui.Text.Trim &
                "',Observacion='" & Me.txtObservaciones.Text.Trim &
                "',ActaNo='" & Me.txtNoActa.Text.Trim &
                "',FechaActa='" & Format(Me.dtpFecha.Value, "dd/MM/yyyy") &
                "',Liquidacion='" & IIf(Me.chkLiquidacion.Checked = True, "1", "0") &
                "',NoCheque='" & Me.txtNoCheque.Text.Trim &
                "',NoLiquidacion='" & Me.txtNoLiquidacion.Text.Trim &
                "',RetiroEfectuado='" & IIf(Me.chkRetiroEfect.Checked = True, "1", "0") &
                "',Usuario='" & sUsuario &
                "',FechaUsuario='" & Format(Now, "dd/MM/yyyy") &
                "',ArchivoVinculoActa='" & Me.txtArchivo.Text.Trim &
                "',NoSocio='" & Me.txtNoSocio.Text.Trim &
                "',UsuarioActu = '" & sUsuario &
                "',FechaActu = Getdate() "
                If oAsoc.ModificarRetiros("Correlativo=" & Trim(pCorr) & "", pCampos, sUsuario, sPassword, sSucursal) = True Then
                    If Me.chkRetiroEfect.Checked = True = "1" Then
                        If oAsoc.VerificarProcesoRetiro(Me.txtDui.Text.Trim, Me.txtNoSocio.Text.Trim, sUsuario, sPassword, sSucursal).Trim = "" Then
                            oAsoc.ModificarAsociadoxFiltro("Dui='" & Me.txtDui.Text.Trim & "'", "EstadoAsociado=1,FechaEstado='" & oApp.Fecha.ToShortDateString & "'", sUsuario, sPassword, sSucursal)
                        Else
                            MessageBox.Show("El Asociado tiene saldos pendientes en cuentas de ahorro o préstamos, no puede ser retirado.", "Retiro de Asociados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End If
                    MsgBox("El Registro ha sido modificado.", MsgBoxStyle.Information)
                    Me.Dispose()
                Else
                    MsgBox("El Registro No ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "")
        End Try
    End Sub

    Private Sub btGenCheque1_Click(sender As Object, e As EventArgs) Handles btGenCheque1.Click

    End Sub

    Private Sub btGenerarMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtCodEjecMercadeo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEjecMercadeo.DoubleClick
        Try
            Dim ofrm As New frmAGenerico, ds As New Data.DataSet
            ofrm.Text = "Buscar Ejecutivos de Mercadeo"
            Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarEjecutivosMercadeoxNombre("", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodEjecMercadeo.Text = ofrm.Resultado.Trim
            txtEjecMercadeo.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodEjecMercadeo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEjecMercadeo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Try
                Dim oPl As New wrPlanilla.wsLibPlanilla
                Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection

                ds = oPerif.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecMercadeo.Text) & "'", "CodEjecMercadeo", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                        Me.txtEjecMercadeo.Text = CStr(Filas.Item(0)("CodEmpleado"))
                        ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecMercadeo.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            Me.txtEjecMercadeo.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                        End If
                    End If
                Else
                    txtCodEjecMercadeo_DoubleClick(sender, e)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

End Class