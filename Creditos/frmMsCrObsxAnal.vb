Public Class frmMsCrObsxAnal
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager

    Public pNoSolic As Long, pCodEnlace As Long, pCorrelativo As Long, pAccion As String
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpEjecutivo As System.Windows.Forms.TabPage
    Friend WithEvents tpAnalista As System.Windows.Forms.TabPage
    Friend WithEvents txtObsEje As System.Windows.Forms.TextBox
    Friend WithEvents lblObsEje As System.Windows.Forms.Label
    Friend WithEvents txtObsAnalista As System.Windows.Forms.TextBox
    Friend WithEvents lblAnalista As System.Windows.Forms.Label
    Friend WithEvents tpJefatura As System.Windows.Forms.TabPage
    Friend WithEvents tpComTec As System.Windows.Forms.TabPage
    Friend WithEvents tpComCre As System.Windows.Forms.TabPage
    Friend WithEvents txtObsJefe As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoActaTec As System.Windows.Forms.TextBox
    Friend WithEvents lblNoActa As System.Windows.Forms.Label
    Friend WithEvents txtObsComTec As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNoActaComCre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtObsComCre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
  
    Friend WithEvents dtpFechaRes As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFechaResTec As System.Windows.Forms.Label
    Friend WithEvents dtpFechaComCre As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Dim credito As New wrCredito.wsLibCred
    Dim vAccion, vNumSolicitud, vCorrelativo As Integer
    Friend WithEvents btnGuardarAnalista As System.Windows.Forms.Button
    Friend WithEvents btnGuardarJefatura As System.Windows.Forms.Button
    Friend WithEvents btnGuardarComTec As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnGuardarComCre As System.Windows.Forms.Button
    Dim Seguridad As New wrAdmin.wsLibAdmin
    Public Property accion() As Integer
        Get
            Return Me.vAccion
        End Get
        Set(ByVal value As Integer)
            vAccion = value
        End Set
    End Property
    Public Property NumSolicitud() As Integer
        Get
            Return Me.vNumSolicitud
        End Get
        Set(ByVal value As Integer)
            vNumSolicitud = value
        End Set
    End Property
    Public Property Correlativo() As Integer
        Get
            Return Me.vCorrelativo
        End Get
        Set(ByVal value As Integer)
            vCorrelativo = value
        End Set
    End Property
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly


        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SysFinCoop.resMain", asm) : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpEjecutivo = New System.Windows.Forms.TabPage()
        Me.txtObsEje = New System.Windows.Forms.TextBox()
        Me.lblObsEje = New System.Windows.Forms.Label()
        Me.tpAnalista = New System.Windows.Forms.TabPage()
        Me.btnGuardarAnalista = New System.Windows.Forms.Button()
        Me.txtObsAnalista = New System.Windows.Forms.TextBox()
        Me.lblAnalista = New System.Windows.Forms.Label()
        Me.tpJefatura = New System.Windows.Forms.TabPage()
        Me.btnGuardarJefatura = New System.Windows.Forms.Button()
        Me.txtObsJefe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tpComTec = New System.Windows.Forms.TabPage()
        Me.btnGuardarComTec = New System.Windows.Forms.Button()
        Me.dtpFechaRes = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaResTec = New System.Windows.Forms.Label()
        Me.txtNoActaTec = New System.Windows.Forms.TextBox()
        Me.lblNoActa = New System.Windows.Forms.Label()
        Me.txtObsComTec = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tpComCre = New System.Windows.Forms.TabPage()
        Me.btnGuardarComCre = New System.Windows.Forms.Button()
        Me.dtpFechaComCre = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoActaComCre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObsComCre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.tpEjecutivo.SuspendLayout()
        Me.tpAnalista.SuspendLayout()
        Me.tpJefatura.SuspendLayout()
        Me.tpComTec.SuspendLayout()
        Me.tpComCre.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(444, 176)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(80, 23)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpEjecutivo)
        Me.TabControl1.Controls.Add(Me.tpAnalista)
        Me.TabControl1.Controls.Add(Me.tpJefatura)
        Me.TabControl1.Controls.Add(Me.tpComTec)
        Me.TabControl1.Controls.Add(Me.tpComCre)
        Me.TabControl1.Location = New System.Drawing.Point(23, 63)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(546, 231)
        Me.TabControl1.TabIndex = 3
        '
        'tpEjecutivo
        '
        Me.tpEjecutivo.Controls.Add(Me.txtObsEje)
        Me.tpEjecutivo.Controls.Add(Me.lblObsEje)
        Me.tpEjecutivo.Controls.Add(Me.btnGuardar)
        Me.tpEjecutivo.Location = New System.Drawing.Point(4, 22)
        Me.tpEjecutivo.Name = "tpEjecutivo"
        Me.tpEjecutivo.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEjecutivo.Size = New System.Drawing.Size(538, 205)
        Me.tpEjecutivo.TabIndex = 0
        Me.tpEjecutivo.Text = "Obs. Ejecutivo"
        Me.tpEjecutivo.UseVisualStyleBackColor = True
        '
        'txtObsEje
        '
        Me.txtObsEje.BackColor = System.Drawing.Color.White
        Me.txtObsEje.Location = New System.Drawing.Point(6, 19)
        Me.txtObsEje.Multiline = True
        Me.txtObsEje.Name = "txtObsEje"
        Me.txtObsEje.Size = New System.Drawing.Size(518, 151)
        Me.txtObsEje.TabIndex = 1
        '
        'lblObsEje
        '
        Me.lblObsEje.AutoSize = True
        Me.lblObsEje.Location = New System.Drawing.Point(6, 3)
        Me.lblObsEje.Name = "lblObsEje"
        Me.lblObsEje.Size = New System.Drawing.Size(70, 13)
        Me.lblObsEje.TabIndex = 0
        Me.lblObsEje.Text = "Observación:"
        '
        'tpAnalista
        '
        Me.tpAnalista.Controls.Add(Me.btnGuardarAnalista)
        Me.tpAnalista.Controls.Add(Me.txtObsAnalista)
        Me.tpAnalista.Controls.Add(Me.lblAnalista)
        Me.tpAnalista.Location = New System.Drawing.Point(4, 22)
        Me.tpAnalista.Name = "tpAnalista"
        Me.tpAnalista.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAnalista.Size = New System.Drawing.Size(538, 205)
        Me.tpAnalista.TabIndex = 1
        Me.tpAnalista.Text = "Obs. Analista"
        Me.tpAnalista.UseVisualStyleBackColor = True
        '
        'btnGuardarAnalista
        '
        Me.btnGuardarAnalista.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardarAnalista.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardarAnalista.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarAnalista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarAnalista.Location = New System.Drawing.Point(448, 176)
        Me.btnGuardarAnalista.Name = "btnGuardarAnalista"
        Me.btnGuardarAnalista.Size = New System.Drawing.Size(80, 23)
        Me.btnGuardarAnalista.TabIndex = 4
        Me.btnGuardarAnalista.Text = "&Guardar"
        Me.btnGuardarAnalista.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardarAnalista.UseVisualStyleBackColor = False
        '
        'txtObsAnalista
        '
        Me.txtObsAnalista.BackColor = System.Drawing.Color.White
        Me.txtObsAnalista.Location = New System.Drawing.Point(10, 21)
        Me.txtObsAnalista.Multiline = True
        Me.txtObsAnalista.Name = "txtObsAnalista"
        Me.txtObsAnalista.Size = New System.Drawing.Size(518, 149)
        Me.txtObsAnalista.TabIndex = 3
        '
        'lblAnalista
        '
        Me.lblAnalista.AutoSize = True
        Me.lblAnalista.Location = New System.Drawing.Point(10, 5)
        Me.lblAnalista.Name = "lblAnalista"
        Me.lblAnalista.Size = New System.Drawing.Size(70, 13)
        Me.lblAnalista.TabIndex = 2
        Me.lblAnalista.Text = "Observación:"
        '
        'tpJefatura
        '
        Me.tpJefatura.Controls.Add(Me.btnGuardarJefatura)
        Me.tpJefatura.Controls.Add(Me.txtObsJefe)
        Me.tpJefatura.Controls.Add(Me.Label2)
        Me.tpJefatura.Location = New System.Drawing.Point(4, 22)
        Me.tpJefatura.Name = "tpJefatura"
        Me.tpJefatura.Size = New System.Drawing.Size(538, 205)
        Me.tpJefatura.TabIndex = 2
        Me.tpJefatura.Text = "Obs. Jefatura"
        Me.tpJefatura.UseVisualStyleBackColor = True
        '
        'btnGuardarJefatura
        '
        Me.btnGuardarJefatura.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardarJefatura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardarJefatura.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarJefatura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarJefatura.Location = New System.Drawing.Point(448, 179)
        Me.btnGuardarJefatura.Name = "btnGuardarJefatura"
        Me.btnGuardarJefatura.Size = New System.Drawing.Size(80, 23)
        Me.btnGuardarJefatura.TabIndex = 6
        Me.btnGuardarJefatura.Text = "&Guardar"
        Me.btnGuardarJefatura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardarJefatura.UseVisualStyleBackColor = False
        '
        'txtObsJefe
        '
        Me.txtObsJefe.BackColor = System.Drawing.Color.White
        Me.txtObsJefe.Location = New System.Drawing.Point(10, 22)
        Me.txtObsJefe.Multiline = True
        Me.txtObsJefe.Name = "txtObsJefe"
        Me.txtObsJefe.Size = New System.Drawing.Size(518, 103)
        Me.txtObsJefe.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Observación:"
        '
        'tpComTec
        '
        Me.tpComTec.Controls.Add(Me.btnGuardarComTec)
        Me.tpComTec.Controls.Add(Me.dtpFechaRes)
        Me.tpComTec.Controls.Add(Me.lblFechaResTec)
        Me.tpComTec.Controls.Add(Me.txtNoActaTec)
        Me.tpComTec.Controls.Add(Me.lblNoActa)
        Me.tpComTec.Controls.Add(Me.txtObsComTec)
        Me.tpComTec.Controls.Add(Me.Label3)
        Me.tpComTec.Location = New System.Drawing.Point(4, 22)
        Me.tpComTec.Name = "tpComTec"
        Me.tpComTec.Size = New System.Drawing.Size(538, 205)
        Me.tpComTec.TabIndex = 3
        Me.tpComTec.Text = "Resolución comite técnico"
        Me.tpComTec.UseVisualStyleBackColor = True
        '
        'btnGuardarComTec
        '
        Me.btnGuardarComTec.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardarComTec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardarComTec.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarComTec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarComTec.Location = New System.Drawing.Point(441, 163)
        Me.btnGuardarComTec.Name = "btnGuardarComTec"
        Me.btnGuardarComTec.Size = New System.Drawing.Size(80, 23)
        Me.btnGuardarComTec.TabIndex = 12
        Me.btnGuardarComTec.Text = "&Guardar"
        Me.btnGuardarComTec.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardarComTec.UseVisualStyleBackColor = False
        '
        'dtpFechaRes
        '
        Me.dtpFechaRes.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRes.Location = New System.Drawing.Point(284, 6)
        Me.dtpFechaRes.Name = "dtpFechaRes"
        Me.dtpFechaRes.Size = New System.Drawing.Size(98, 20)
        Me.dtpFechaRes.TabIndex = 11
        '
        'lblFechaResTec
        '
        Me.lblFechaResTec.AutoSize = True
        Me.lblFechaResTec.Location = New System.Drawing.Point(167, 9)
        Me.lblFechaResTec.Name = "lblFechaResTec"
        Me.lblFechaResTec.Size = New System.Drawing.Size(111, 13)
        Me.lblFechaResTec.TabIndex = 10
        Me.lblFechaResTec.Text = "Fecha de Resolución:"
        '
        'txtNoActaTec
        '
        Me.txtNoActaTec.BackColor = System.Drawing.Color.White
        Me.txtNoActaTec.Location = New System.Drawing.Point(61, 6)
        Me.txtNoActaTec.Name = "txtNoActaTec"
        Me.txtNoActaTec.Size = New System.Drawing.Size(100, 20)
        Me.txtNoActaTec.TabIndex = 9
        '
        'lblNoActa
        '
        Me.lblNoActa.AutoSize = True
        Me.lblNoActa.Location = New System.Drawing.Point(3, 9)
        Me.lblNoActa.Name = "lblNoActa"
        Me.lblNoActa.Size = New System.Drawing.Size(52, 13)
        Me.lblNoActa.TabIndex = 8
        Me.lblNoActa.Text = "No. Acta:"
        '
        'txtObsComTec
        '
        Me.txtObsComTec.BackColor = System.Drawing.Color.White
        Me.txtObsComTec.Location = New System.Drawing.Point(3, 45)
        Me.txtObsComTec.Multiline = True
        Me.txtObsComTec.Name = "txtObsComTec"
        Me.txtObsComTec.Size = New System.Drawing.Size(518, 79)
        Me.txtObsComTec.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Observación:"
        '
        'tpComCre
        '
        Me.tpComCre.Controls.Add(Me.btnGuardarComCre)
        Me.tpComCre.Controls.Add(Me.dtpFechaComCre)
        Me.tpComCre.Controls.Add(Me.Label1)
        Me.tpComCre.Controls.Add(Me.txtNoActaComCre)
        Me.tpComCre.Controls.Add(Me.Label4)
        Me.tpComCre.Controls.Add(Me.txtObsComCre)
        Me.tpComCre.Controls.Add(Me.Label6)
        Me.tpComCre.Location = New System.Drawing.Point(4, 22)
        Me.tpComCre.Name = "tpComCre"
        Me.tpComCre.Size = New System.Drawing.Size(538, 205)
        Me.tpComCre.TabIndex = 4
        Me.tpComCre.Text = "Resolución comite crédito"
        Me.tpComCre.UseVisualStyleBackColor = True
        '
        'btnGuardarComCre
        '
        Me.btnGuardarComCre.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardarComCre.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardarComCre.ForeColor = System.Drawing.Color.Black
        Me.btnGuardarComCre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardarComCre.Location = New System.Drawing.Point(455, 162)
        Me.btnGuardarComCre.Name = "btnGuardarComCre"
        Me.btnGuardarComCre.Size = New System.Drawing.Size(80, 23)
        Me.btnGuardarComCre.TabIndex = 16
        Me.btnGuardarComCre.Text = "&Guardar"
        Me.btnGuardarComCre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardarComCre.UseVisualStyleBackColor = False
        '
        'dtpFechaComCre
        '
        Me.dtpFechaComCre.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaComCre.Location = New System.Drawing.Point(286, 6)
        Me.dtpFechaComCre.Name = "dtpFechaComCre"
        Me.dtpFechaComCre.Size = New System.Drawing.Size(98, 20)
        Me.dtpFechaComCre.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Fecha de Resolución:"
        '
        'txtNoActaComCre
        '
        Me.txtNoActaComCre.BackColor = System.Drawing.Color.White
        Me.txtNoActaComCre.Location = New System.Drawing.Point(63, 6)
        Me.txtNoActaComCre.Name = "txtNoActaComCre"
        Me.txtNoActaComCre.Size = New System.Drawing.Size(100, 20)
        Me.txtNoActaComCre.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "No. Acta:"
        '
        'txtObsComCre
        '
        Me.txtObsComCre.BackColor = System.Drawing.Color.White
        Me.txtObsComCre.Location = New System.Drawing.Point(10, 45)
        Me.txtObsComCre.Multiline = True
        Me.txtObsComCre.Name = "txtObsComCre"
        Me.txtObsComCre.Size = New System.Drawing.Size(525, 85)
        Me.txtObsComCre.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Observación:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Khaki
        Me.TextBox1.Location = New System.Drawing.Point(10, 22)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(518, 103)
        Me.TextBox1.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Observación:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Khaki
        Me.TextBox2.Location = New System.Drawing.Point(10, 22)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(518, 103)
        Me.TextBox2.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Observación:"
        '
        'frmMsCrObsxAnal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(596, 345)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmMsCrObsxAnal"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Analisis de crédito"
        Me.TabControl1.ResumeLayout(False)
        Me.tpEjecutivo.ResumeLayout(False)
        Me.tpEjecutivo.PerformLayout()
        Me.tpAnalista.ResumeLayout(False)
        Me.tpAnalista.PerformLayout()
        Me.tpJefatura.ResumeLayout(False)
        Me.tpJefatura.PerformLayout()
        Me.tpComTec.ResumeLayout(False)
        Me.tpComTec.PerformLayout()
        Me.tpComCre.ResumeLayout(False)
        Me.tpComCre.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMsCrObsxAnal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oPl As New wrPlanilla.wsLibPlanilla
            Dim oCred As New wrCredito.wsLibCred, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection
            consultarAccesos()
            If accion = 2 Then
                Dim dts As New DataSet
                dts = credito.ConsultarObservacionesxAnalisis("*", "correlativo = '" & Correlativo & "'", "Correlativo", sUsuario, sPassword, sSucursal)
                If dts.Tables.Count > 0 Then
                    If dts.Tables(0).Rows.Count > 0 Then
                        txtObsEje.Text = dts.Tables(0).Rows(0).Item("ObsEjecutivo").ToString
                        txtObsAnalista.Text = dts.Tables(0).Rows(0).Item("ObservacionAnalista").ToString
                        txtObsJefe.Text = dts.Tables(0).Rows(0).Item("ObsJefe").ToString
                        txtObsComTec.Text = dts.Tables(0).Rows(0).Item("ResolucionComiteTec").ToString
                        txtNoActaTec.Text = dts.Tables(0).Rows(0).Item("NoActaComiteTec").ToString
                        dtpFechaRes.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaResComiteTec")), Format(Now, "short date"), dts.Tables(0).Rows(0).Item("FechaResComiteTec"))
                        txtObsComCre.Text = dts.Tables(0).Rows(0).Item("ResolucionComiteCre").ToString
                        txtNoActaComCre.Text = dts.Tables(0).Rows(0).Item("NoActaComiteCre").ToString
                        dtpFechaComCre.Value = IIf(IsDBNull(dts.Tables(0).Rows(0).Item("FechaResComiteCre")), Format(Now, "short date"), dts.Tables(0).Rows(0).Item("FechaResComiteCre"))
                    End If
                End If
            ElseIf accion = 1 Then

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btnGuardarAnalista_Click(sender As Object, e As EventArgs) Handles btnGuardarAnalista.Click
        Dim corr As Integer
        Dim campos As String
        Dim valores As String

        If accion = 1 Then
            corr = credito.ObtenerCorrelativoObservacionesxAnalisis("correlativo", sUsuario, sPassword, sSucursal)
            campos = "correlativo,numSolicitud, " &
            "observacionanalista,fechaObs"

            valores = " '" & corr & "','" & NumSolicitud &
            "','" & txtObsAnalista.Text & "', '" & Format(dtpFechaRes.Value, "short date") & "'"


            If credito.InsertarObservacionesxAnalisis(campos, valores, sUsuario, sPassword, sSucursal) = True Then
                MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo Crédito - Préstamos")
                accion = 2
                Correlativo = corr
            Else
                MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo Crédito - Préstamos")
            End If
        ElseIf accion = 2 Then
            campos = " observacionanalista = '" & txtObsAnalista.Text.Trim &
             "', fechaObs = '" & Format(dtpFechaRes.Value, "short date") & "'"

            If credito.ModificarObservacionesxAnalisis(Correlativo, campos, sUsuario, sPassword, sSucursal) = True Then
                MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information, "Módulo Crédito - Préstamos")
            Else
                MsgBox("El registro no pudo ser actualizado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo Crédito - Préstamos")
            End If
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim corr As Integer
            Dim campos As String
            Dim valores As String

            If accion = 1 Then
                corr = credito.ObtenerCorrelativoObservacionesxAnalisis("correlativo", sUsuario, sPassword, sSucursal)
                campos = "correlativo,numSolicitud, " & _
                "ObsEjecutivo,FechaObsEjecutivo," & _
                "ejecutivo"
                valores = " '" & corr & "','" & NumSolicitud & _
                "','" & txtObsEje.Text & "','" & Format(Now, "short date") & _
                "','" & sUsuario & "'"
                If credito.InsertarObservacionesxAnalisis(campos, valores, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo Crédito - Préstamos")
                    accion = 2
                    Correlativo = corr
                Else
                    MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo Crédito - Préstamos")
                End If
            ElseIf accion = 2 Then
                campos = " obsEjecutivo = '" & txtObsEje.Text.Trim & _
                "', fechaObsEjecutivo = '" & Format(Now, "short date") & _
                "', ejecutivo = '" & sUsuario & "'"
                If credito.ModificarObservacionesxAnalisis(Correlativo, campos, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information, "Módulo Crédito - Préstamos")
                Else
                    MsgBox("El registro no pudo ser actualizado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo Crédito - Préstamos")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardarJefatura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarJefatura.Click
        Dim corr As Integer
        Dim campos As String
        Dim valores As String

        If accion = 1 Then
            corr = credito.ObtenerCorrelativoObservacionesxAnalisis("correlativo", sUsuario, sPassword, sSucursal)
            campos = "correlativo,numSolicitud, " & _
            "ObsJefe,FechaObsJefe,Jefatura"

            valores = " '" & corr & "','" & NumSolicitud & _
            "','" & txtObsJefe.Text & "','" & Format(Now, "short date") & _
            "','" & sUsuario & "'"

            If credito.InsertarObservacionesxAnalisis(campos, valores, sUsuario, sPassword, sSucursal) = True Then
                MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo Crédito - Préstamos")
                accion = 2
                Correlativo = corr
            Else
                MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo Crédito - Préstamos")
            End If
        ElseIf accion = 2 Then
            campos = " ObsJefe = '" & txtObsJefe.Text.Trim & _
            "', FechaObsJefe = '" & Format(Now, "short date") & _
            "',Jefatura = '" & sUsuario & "'"
            If credito.ModificarObservacionesxAnalisis(Correlativo, campos, sUsuario, sPassword, sSucursal) = True Then
                MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information, "Módulo Crédito - Préstamos")
            Else
                MsgBox("El registro no pudo ser actualizado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo Crédito - Préstamos")
            End If
        End If
    End Sub

    Private Sub btnGuardarComTec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarComTec.Click
        Dim corr As Integer
        Dim campos As String
        Dim valores As String

        If accion = 1 Then
            corr = credito.ObtenerCorrelativoObservacionesxAnalisis("correlativo", sUsuario, sPassword, sSucursal)
            campos = "correlativo,numSolicitud, " & _
            "ResolucionComiteTec,NoActaComiteTec,FechaResComiteTec"

            valores = " '" & corr & "','" & NumSolicitud & _
            "','" & txtObsComTec.Text & "', '" & txtNoActaTec.Text & _
            "','" & Format(dtpFechaRes.Value, "short date") & "'"

            If credito.InsertarObservacionesxAnalisis(campos, valores, sUsuario, sPassword, sSucursal) = True Then
                MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo Crédito - Préstamos")
                accion = 2
                Correlativo = corr
            Else
                MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo Crédito - Préstamos")
            End If
        ElseIf accion = 2 Then
            campos = " ResolucionComiteTec = '" & txtObsComTec.Text.Trim & _
             "', NoActaComiteTec = '" & txtNoActaTec.Text & _
            "', FechaResComiteTec = '" & Format(dtpFechaRes.Value, "short date") & "'"
            If credito.ModificarObservacionesxAnalisis(Correlativo, campos, sUsuario, sPassword, sSucursal) = True Then
                MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information, "Módulo Crédito - Préstamos")
            Else
                MsgBox("El registro no pudo ser actualizado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo Crédito - Préstamos")
            End If
        End If
    End Sub

    Private Sub btnGuardarComCre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarComCre.Click
        Dim corr As Integer
        Dim campos As String
        Dim valores As String

        If accion = 1 Then
            corr = credito.ObtenerCorrelativoObservacionesxAnalisis("correlativo", sUsuario, sPassword, sSucursal)
            campos = "correlativo,numSolicitud, " & _
            "ResolucionComiteCre,NoActaComiteCre,FechaResComiteCre"

            valores = " '" & corr & "','" & NumSolicitud & _
            "','" & txtObsComCre.Text & "', '" & txtNoActaComCre.Text & _
            "','" & Format(dtpFechaComCre.Value, "short date") & "'"

            If credito.InsertarObservacionesxAnalisis(campos, valores, sUsuario, sPassword, sSucursal) = True Then
                MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo Crédito - Préstamos")
                accion = 2
                Correlativo = corr
            Else
                MsgBox("El registro no pudo ser ingresado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo Crédito - Préstamos")
            End If
        ElseIf accion = 2 Then
            campos = " ResolucionComiteCre = '" & txtObsComCre.Text.Trim & _
             "', NoActaComiteCre = '" & txtNoActaComCre.Text & _
            "', FechaResComiteCre = '" & Format(dtpFechaComCre.Value, "short date") & "'"
            If credito.ModificarObservacionesxAnalisis(Correlativo, campos, sUsuario, sPassword, sSucursal) = True Then
                MsgBox("Registro actualizado exitosamente", MsgBoxStyle.Information, "Módulo Crédito - Préstamos")
            Else
                MsgBox("El registro no pudo ser actualizado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo Crédito - Préstamos")
            End If
        End If
    End Sub

    Protected Sub consultarAccesos()
        Try
            Dim dtsRoles As New DataSet
            dtsRoles = Seguridad.ConsultarRolesUsuario(sUsuario, "", 2)
            If dtsRoles.Tables.Count > 0 Then
                If dtsRoles.Tables(0).Rows.Count > 0 Then
                    For I As Integer = 0 To dtsRoles.Tables(0).Rows.Count - 1
                        If Seguridad.ConsultarPermisoProcesos("CRM006", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                            Me.txtObsEje.Enabled = True
                            Me.btnGuardar.Enabled = True

                            Me.txtObsJefe.Enabled = False
                            Me.btnGuardarJefatura.Enabled = False

                            Me.txtObsAnalista.Enabled = False
                            Me.btnGuardarAnalista.Enabled = False

                            Me.txtObsComCre.Enabled = False
                            Me.dtpFechaComCre.Enabled = False
                            Me.btnGuardarComCre.Enabled = False
                            Me.txtNoActaComCre.Enabled = False
                            Me.txtNoActaTec.Enabled = False
                            Me.txtObsComTec.Enabled = False
                            Me.dtpFechaRes.Enabled = False
                            Me.btnGuardarComTec.Enabled = False

                            Exit For
                        ElseIf Seguridad.ConsultarPermisoProcesos("CRM007", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                            Me.txtObsJefe.Enabled = True
                            Me.btnGuardarJefatura.Enabled = True
                            Me.txtObsEje.Enabled = True
                            Me.btnGuardar.Enabled = True

                            Me.txtObsAnalista.Enabled = False
                            Me.btnGuardarAnalista.Enabled = False

                            Me.txtObsComCre.Enabled = False
                            Me.dtpFechaComCre.Enabled = False
                            Me.btnGuardarComCre.Enabled = False
                            Me.txtNoActaComCre.Enabled = False
                            Me.txtNoActaTec.Enabled = False
                            Me.txtObsComTec.Enabled = False
                            Me.dtpFechaRes.Enabled = False
                            Me.btnGuardarComTec.Enabled = False


                            'llenarDg(4, sSucursal, sUsuario, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
                            Exit For
                        ElseIf Seguridad.ConsultarPermisoProcesos("CRM008", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                            Me.txtObsAnalista.Enabled = True
                            Me.btnGuardarAnalista.Enabled = True

                            Me.txtObsComCre.Enabled = True
                            Me.dtpFechaComCre.Enabled = True
                            Me.btnGuardarComCre.Enabled = True

                            Me.txtObsComTec.Enabled = True
                            Me.dtpFechaRes.Enabled = True
                            Me.btnGuardarComTec.Enabled = True
                            Me.txtNoActaComCre.Enabled = True
                            Me.txtNoActaTec.Enabled = True
                            Me.txtObsJefe.Enabled = False
                            Me.btnGuardarJefatura.Enabled = False
                            Me.txtObsEje.Enabled = False
                            Me.btnGuardar.Enabled = False
                            'llenarDg(1, sSucursal, sUsuario, Format(Me.dtpFechaIni.Value, "Short Date"), Format(Me.dtpFechaFin.Value, "Short Date"))
                            Exit For
                        Else
                            Me.txtObsAnalista.Enabled = False
                            Me.btnGuardarAnalista.Enabled = False

                            Me.txtObsComCre.Enabled = False
                            Me.dtpFechaComCre.Enabled = False
                            Me.btnGuardarComCre.Enabled = False

                            Me.txtObsComTec.Enabled = False
                            Me.dtpFechaRes.Enabled = False
                            Me.btnGuardarComTec.Enabled = False
                            Me.txtNoActaComCre.Enabled = False
                            Me.txtNoActaTec.Enabled = False
                            Me.txtObsJefe.Enabled = False
                            Me.btnGuardarJefatura.Enabled = False
                            Me.txtObsEje.Enabled = False
                            Me.btnGuardar.Enabled = False
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox("Error por favor cominicarse con el administrador de sistemas.", MsgBoxStyle.Critical, "Rutas")
        End Try
    End Sub
End Class
