Public Class frmMsAhRepCert
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents btnRepDPF As System.Windows.Forms.Button
    Friend WithEvents nuNoPag3 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nuNoPag2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nuNoPag1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtPeriodico3 As System.Windows.Forms.TextBox
    Friend WithEvents txtPeriodico1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPeriodico2 As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cbCausa As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtNuevoNoCertificado As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtNoSolicitud As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents dtpFecPubIII As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents dtpFecPubII As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents dtpFecPubI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaSolicitud As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtObsPI As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveTb4 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtObsPI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRepDPF = New System.Windows.Forms.Button()
        Me.nuNoPag3 = New System.Windows.Forms.NumericUpDown()
        Me.nuNoPag2 = New System.Windows.Forms.NumericUpDown()
        Me.nuNoPag1 = New System.Windows.Forms.NumericUpDown()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtPeriodico3 = New System.Windows.Forms.TextBox()
        Me.txtPeriodico1 = New System.Windows.Forms.TextBox()
        Me.txtPeriodico2 = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cbCausa = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtNuevoNoCertificado = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtNoSolicitud = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dtpFecPubIII = New System.Windows.Forms.DateTimePicker()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.dtpFecPubII = New System.Windows.Forms.DateTimePicker()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.dtpFecPubI = New System.Windows.Forms.DateTimePicker()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.dtpFechaSolicitud = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnSaveTb4 = New MetroFramework.Controls.MetroButton()
        CType(Me.nuNoPag3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuNoPag2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuNoPag1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtObsPI
        '
        Me.txtObsPI.Location = New System.Drawing.Point(26, 369)
        Me.txtObsPI.Multiline = True
        Me.txtObsPI.Name = "txtObsPI"
        Me.txtObsPI.Size = New System.Drawing.Size(802, 63)
        Me.txtObsPI.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 347)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 207
        Me.Label1.Text = "Observación:"
        '
        'btnRepDPF
        '
        Me.btnRepDPF.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnRepDPF.Enabled = False
        Me.btnRepDPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRepDPF.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRepDPF.ForeColor = System.Drawing.Color.Black
        Me.btnRepDPF.Location = New System.Drawing.Point(26, 158)
        Me.btnRepDPF.Name = "btnRepDPF"
        Me.btnRepDPF.Size = New System.Drawing.Size(249, 28)
        Me.btnRepDPF.TabIndex = 14
        Me.btnRepDPF.Text = "&Cambiar Certificado x Reposición"
        Me.btnRepDPF.UseVisualStyleBackColor = False
        '
        'nuNoPag3
        '
        Me.nuNoPag3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nuNoPag3.Location = New System.Drawing.Point(579, 322)
        Me.nuNoPag3.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nuNoPag3.Name = "nuNoPag3"
        Me.nuNoPag3.Size = New System.Drawing.Size(249, 22)
        Me.nuNoPag3.TabIndex = 12
        Me.nuNoPag3.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nuNoPag2
        '
        Me.nuNoPag2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nuNoPag2.Location = New System.Drawing.Point(305, 324)
        Me.nuNoPag2.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nuNoPag2.Name = "nuNoPag2"
        Me.nuNoPag2.Size = New System.Drawing.Size(246, 22)
        Me.nuNoPag2.TabIndex = 9
        Me.nuNoPag2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nuNoPag1
        '
        Me.nuNoPag1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nuNoPag1.Location = New System.Drawing.Point(26, 322)
        Me.nuNoPag1.Maximum = New Decimal(New Integer() {999, 0, 0, 0})
        Me.nuNoPag1.Name = "nuNoPag1"
        Me.nuNoPag1.Size = New System.Drawing.Size(249, 22)
        Me.nuNoPag1.TabIndex = 6
        Me.nuNoPag1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label40
        '
        Me.Label40.BackColor = System.Drawing.Color.White
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(576, 302)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(77, 19)
        Me.Label40.TabIndex = 204
        Me.Label40.Text = "No. Pág.:"
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.White
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(299, 302)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(252, 19)
        Me.Label39.TabIndex = 203
        Me.Label39.Text = "No. Pág.:"
        '
        'Label38
        '
        Me.Label38.BackColor = System.Drawing.Color.White
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(23, 301)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(252, 18)
        Me.Label38.TabIndex = 202
        Me.Label38.Text = "No. Pág.:"
        '
        'txtPeriodico3
        '
        Me.txtPeriodico3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPeriodico3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodico3.Location = New System.Drawing.Point(579, 274)
        Me.txtPeriodico3.MaxLength = 20
        Me.txtPeriodico3.Name = "txtPeriodico3"
        Me.txtPeriodico3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPeriodico3.Size = New System.Drawing.Size(249, 25)
        Me.txtPeriodico3.TabIndex = 11
        '
        'txtPeriodico1
        '
        Me.txtPeriodico1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPeriodico1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodico1.Location = New System.Drawing.Point(26, 273)
        Me.txtPeriodico1.MaxLength = 20
        Me.txtPeriodico1.Name = "txtPeriodico1"
        Me.txtPeriodico1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPeriodico1.Size = New System.Drawing.Size(249, 25)
        Me.txtPeriodico1.TabIndex = 5
        '
        'txtPeriodico2
        '
        Me.txtPeriodico2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPeriodico2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodico2.Location = New System.Drawing.Point(302, 274)
        Me.txtPeriodico2.MaxLength = 20
        Me.txtPeriodico2.Name = "txtPeriodico2"
        Me.txtPeriodico2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPeriodico2.Size = New System.Drawing.Size(249, 25)
        Me.txtPeriodico2.TabIndex = 8
        '
        'Label37
        '
        Me.Label37.BackColor = System.Drawing.Color.White
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(576, 252)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(173, 19)
        Me.Label37.TabIndex = 198
        Me.Label37.Text = "Periódico de Publicación 3:"
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.White
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(299, 252)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(173, 19)
        Me.Label35.TabIndex = 197
        Me.Label35.Text = "Periódico de Publicación 2:"
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.White
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(23, 252)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(173, 18)
        Me.Label34.TabIndex = 196
        Me.Label34.Text = "Periódico de Publicación 1:"
        '
        'cbCausa
        '
        Me.cbCausa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCausa.Items.AddRange(New Object() {"Reposición por Deterioro", "Reposición por Pérdida"})
        Me.cbCausa.Location = New System.Drawing.Point(302, 128)
        Me.cbCausa.Name = "cbCausa"
        Me.cbCausa.Size = New System.Drawing.Size(249, 24)
        Me.cbCausa.TabIndex = 3
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(302, 107)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 18)
        Me.Label25.TabIndex = 194
        Me.Label25.Text = "Causa:"
        '
        'txtNuevoNoCertificado
        '
        Me.txtNuevoNoCertificado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNuevoNoCertificado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoNoCertificado.Location = New System.Drawing.Point(26, 127)
        Me.txtNuevoNoCertificado.MaxLength = 20
        Me.txtNuevoNoCertificado.Name = "txtNuevoNoCertificado"
        Me.txtNuevoNoCertificado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNuevoNoCertificado.Size = New System.Drawing.Size(249, 25)
        Me.txtNuevoNoCertificado.TabIndex = 2
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.White
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(23, 106)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(106, 18)
        Me.Label24.TabIndex = 193
        Me.Label24.Text = "No. Certificado:"
        '
        'txtNoSolicitud
        '
        Me.txtNoSolicitud.Location = New System.Drawing.Point(26, 81)
        Me.txtNoSolicitud.Name = "txtNoSolicitud"
        Me.txtNoSolicitud.Size = New System.Drawing.Size(246, 22)
        Me.txtNoSolicitud.TabIndex = 0
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(23, 60)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 18)
        Me.Label23.TabIndex = 190
        Me.Label23.Text = "No. Solicitud:"
        '
        'dtpFecPubIII
        '
        Me.dtpFecPubIII.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecPubIII.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecPubIII.Location = New System.Drawing.Point(579, 226)
        Me.dtpFecPubIII.Name = "dtpFecPubIII"
        Me.dtpFecPubIII.Size = New System.Drawing.Size(249, 23)
        Me.dtpFecPubIII.TabIndex = 10
        Me.dtpFecPubIII.Value = New Date(2018, 11, 8, 0, 0, 0, 0)
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(576, 204)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(275, 19)
        Me.Label33.TabIndex = 172
        Me.Label33.Text = "Fecha de Publicación 3:"
        '
        'dtpFecPubII
        '
        Me.dtpFecPubII.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecPubII.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecPubII.Location = New System.Drawing.Point(302, 226)
        Me.dtpFecPubII.Name = "dtpFecPubII"
        Me.dtpFecPubII.Size = New System.Drawing.Size(249, 23)
        Me.dtpFecPubII.TabIndex = 7
        Me.dtpFecPubII.Value = New Date(2018, 11, 8, 0, 0, 0, 0)
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(302, 204)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(249, 19)
        Me.Label32.TabIndex = 170
        Me.Label32.Text = "Fecha de Publicación 2:"
        '
        'dtpFecPubI
        '
        Me.dtpFecPubI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecPubI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecPubI.Location = New System.Drawing.Point(26, 226)
        Me.dtpFecPubI.Name = "dtpFecPubI"
        Me.dtpFecPubI.Size = New System.Drawing.Size(249, 23)
        Me.dtpFecPubI.TabIndex = 4
        Me.dtpFecPubI.Value = New Date(2018, 11, 8, 0, 0, 0, 0)
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(23, 205)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(252, 18)
        Me.Label30.TabIndex = 168
        Me.Label30.Text = "Fecha de Publicación 1:"
        '
        'dtpFechaSolicitud
        '
        Me.dtpFechaSolicitud.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSolicitud.Location = New System.Drawing.Point(305, 81)
        Me.dtpFechaSolicitud.Name = "dtpFechaSolicitud"
        Me.dtpFechaSolicitud.Size = New System.Drawing.Size(246, 23)
        Me.dtpFechaSolicitud.TabIndex = 1
        Me.dtpFechaSolicitud.Value = New Date(2018, 11, 8, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(302, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(125, 18)
        Me.Label7.TabIndex = 134
        Me.Label7.Text = "Fecha Solicitud:"
        '
        'btnSaveTb4
        '
        Me.btnSaveTb4.Location = New System.Drawing.Point(738, 438)
        Me.btnSaveTb4.Name = "btnSaveTb4"
        Me.btnSaveTb4.Size = New System.Drawing.Size(90, 32)
        Me.btnSaveTb4.Style = MetroFramework.MetroColorStyle.Green
        Me.btnSaveTb4.TabIndex = 219
        Me.btnSaveTb4.Text = "&Guardar"
        Me.btnSaveTb4.UseSelectable = True
        Me.btnSaveTb4.UseStyleColors = True
        '
        'frmMsAhRepCert
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(865, 537)
        Me.Controls.Add(Me.btnSaveTb4)
        Me.Controls.Add(Me.txtObsPI)
        Me.Controls.Add(Me.nuNoPag3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label40)
        Me.Controls.Add(Me.nuNoPag2)
        Me.Controls.Add(Me.nuNoPag1)
        Me.Controls.Add(Me.Label39)
        Me.Controls.Add(Me.btnRepDPF)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.txtNoSolicitud)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpFechaSolicitud)
        Me.Controls.Add(Me.txtPeriodico3)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label37)
        Me.Controls.Add(Me.txtPeriodico2)
        Me.Controls.Add(Me.txtPeriodico1)
        Me.Controls.Add(Me.txtNuevoNoCertificado)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.cbCausa)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.dtpFecPubI)
        Me.Controls.Add(Me.dtpFecPubIII)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.dtpFecPubII)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhRepCert"
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Reposición de Certificados DPF"
        CType(Me.nuNoPag3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuNoPag2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuNoPag1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public pNoCuenta As String, pCodTipoAhorro As String, pNoCertificado As String, pAccion As String, pCorrelativo As String

    Private Sub btnSaveTb4_Click(sender As Object, e As EventArgs) Handles btnSaveTb4.Click
        Try
            Dim oAsoc As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, pCampos As String, pValores As String

            Select Case oAsoc.AutorizaDatos(Me.txtNoSolicitud.Text, "x", "x", "x", "x")
                Case 1
                    MsgBox("El campo No. Solicitud no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
            End Select

            If Me.btnSaveTb4.Text = "&Guardar" Then
                pCampos = "NoSolicitud,NoCuenta,CodTipoAhorro,FechaSolicitud,IdCertificadoDPF,IdCertificadoDPFRepone,Causa,FechaPublicacion1,FechaPublicacion2,FechaPublicacion3,PeriodicoPublic1,PeriodicoPublic2,PeriodicoPublic3,NoPaginaPublic1,NoPaginaPublic2,NoPaginaPublic3,Estado,Observacion"
                pValores = "'" & Trim(Me.txtNoSolicitud.Text) & "','" & Me.pNoCuenta & "','" & Me.pCodTipoAhorro & "','" & Format(Me.dtpFechaSolicitud.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtNuevoNoCertificado.Text) & "','" & Me.pNoCertificado & "','" & Me.cbCausa.SelectedIndex & "','" & Format(Me.dtpFecPubI.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFecPubII.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFecPubIII.Value, "dd/MM/yyyy") & "','" & Me.txtPeriodico1.Text.Trim & "','" & Trim(Me.txtPeriodico2.Text) & "','" & Trim(Me.txtPeriodico3.Text) & "'," & Me.nuNoPag1.Value & "," & Me.nuNoPag2.Value & "," & Me.nuNoPag3.Value & ",'N','" & Me.txtObsPI.Text.Trim & "'"
                If oAsoc.InsertarReposicionCertificadosDPF(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("El registro ha sido modificado.", MsgBoxStyle.Information, "Módulo de Ahorros")
                    Me.btnRepDPF.Enabled = True
                    Me.btnSaveTb4.Text = "&Modificar"
                Else
                    MsgBox("El registro NO ha sido agregado. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            ElseIf Me.btnSaveTb4.Text = "&Modificar" Then
                pCampos = "FechaSolicitud='" & Format(Me.dtpFechaSolicitud.Value, "dd/MM/yyyy") & "',IdCertificadoDPF='" & Trim(Me.txtNuevoNoCertificado.Text) & "',IdCertificadoDPFRepone='" & Me.pNoCertificado & "',Causa='" & Me.cbCausa.SelectedIndex & "',FechaPublicacion1='" & Format(Me.dtpFecPubI.Value, "dd/MM/yyyy") & "',FechaPublicacion2='" & Format(Me.dtpFecPubII.Value, "dd/MM/yyyy") & "',FechaPublicacion3='" & Format(Me.dtpFecPubIII.Value, "dd/MM/yyyy") & "',PeriodicoPublic1='" & Me.txtPeriodico1.Text.Trim & "',PeriodicoPublic2='" & Trim(Me.txtPeriodico2.Text) & "',PeriodicoPublic3='" & Trim(Me.txtPeriodico3.Text) & "',NoPaginaPublic1=" & Me.nuNoPag1.Value & ",NoPaginaPublic2=" & Me.nuNoPag2.Value & ",NoPaginaPublic3=" & Me.nuNoPag3.Value & ",Observacion='" & Me.txtObsPI.Text.Trim & "'"
                If oAsoc.ModificarReposicionCertificadosDPF(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("El registro ha sido modificado.", MsgBoxStyle.Information)
                    Me.Dispose()
                Else
                    MsgBox("El registro no ha sido modificado. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMsAhRepCert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.dtpFechaSolicitud.Value = Now
        Me.dtpFecPubI.Value = Now
        Me.dtpFecPubII.Value = Now
        Me.dtpFecPubIII.Value = Now
        Me.btnRepDPF.Enabled = False

        Dim ds As New Data.DataSet, objRow As Data.DataRow, vPorcent As Double
        Dim oAsoc As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
        Dim Filas As Data.DataRowCollection

        Try
            cbCausa.SelectedIndex = 0

            If Me.btnSaveTb4.Text = "&Modificar" Then

                ds = oAsoc.ConsultarReposicionCertificadosDPF("*", "NoSolicitud='" & pCorrelativo & "'", "NoSolicitud", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtNoSolicitud.Text = IIf(IsDBNull(Filas.Item(0)("NoSolicitud")), "", Filas.Item(0)("NoSolicitud"))
                    Me.dtpFechaSolicitud.Value = IIf(IsDBNull(Filas.Item(0)("FechaSolicitud")), Now, Filas.Item(0)("FechaSolicitud"))
                    Me.txtNuevoNoCertificado.Text = IIf(IsDBNull(Filas.Item(0)("IdCertificadoDPF")), "", Filas.Item(0)("IdCertificadoDPF"))
                    Me.cbCausa.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("Causa")), 0, Filas.Item(0)("Causa"))
                    Me.dtpFecPubI.Value = IIf(IsDBNull(Filas.Item(0)("FechaPublicacion1")), Now, Filas.Item(0)("FechaPublicacion1"))
                    Me.dtpFecPubII.Value = IIf(IsDBNull(Filas.Item(0)("FechaPublicacion2")), Now, Filas.Item(0)("FechaPublicacion2"))
                    Me.dtpFecPubIII.Value = IIf(IsDBNull(Filas.Item(0)("FechaPublicacion3")), Now, Filas.Item(0)("FechaPublicacion3"))
                    txtPeriodico1.Text = IIf(IsDBNull(Filas.Item(0)("PeriodicoPublic1")), "", Filas.Item(0)("PeriodicoPublic1"))
                    txtPeriodico2.Text = IIf(IsDBNull(Filas.Item(0)("PeriodicoPublic2")), "", Filas.Item(0)("PeriodicoPublic2"))
                    txtPeriodico3.Text = IIf(IsDBNull(Filas.Item(0)("PeriodicoPublic3")), "", Filas.Item(0)("PeriodicoPublic3"))
                    Me.txtObsPI.Text = IIf(IsDBNull(Filas.Item(0)("Observacion")), "", Filas.Item(0)("Observacion"))
                    nuNoPag1.Value = IIf(IsDBNull(Filas.Item(0)("NoPaginaPublic1")), 0, Filas.Item(0)("NoPaginaPublic1"))
                    nuNoPag2.Value = IIf(IsDBNull(Filas.Item(0)("NoPaginaPublic2")), 0, Filas.Item(0)("NoPaginaPublic2"))
                    nuNoPag3.Value = IIf(IsDBNull(Filas.Item(0)("NoPaginaPublic3")), 0, Filas.Item(0)("NoPaginaPublic3"))
                    Me.btnRepDPF.Enabled = True
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub





    Private Sub btnRepDPF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRepDPF.Click
        Try
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
            If oAhorro.ModificarReposicionCertificadosDPF(Me.txtNoSolicitud.Text.Trim, "Estado='P',Fecha='" & Format(Now, "dd/MM/yyyy") & "'", sUsuario, sPassword,sSucursal) = True Then
                If oAhorro.ModificarCuentaAhorro(Me.pNoCuenta, Me.pCodTipoAhorro, "IdCertificadoDPF='" & Me.txtNuevoNoCertificado.Text.Trim & "'", sUsuario, sPassword,sSucursal) = True Then
                    MsgBox("Cambio de Certificado realizado.", MsgBoxStyle.Information, "Módulo Ahorros")
                Else
                    MsgBox("Cambio no realizado. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class
