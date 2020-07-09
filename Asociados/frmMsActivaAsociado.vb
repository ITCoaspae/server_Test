Public Class frmMsActivaAsociado
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager

    Public pDui As String, pEstado As String, pCorrelativo As String
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtNoActa As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents rbRechazado As System.Windows.Forms.RadioButton
    Friend WithEvents rbAdmitido As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpFecActa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFecResConsejo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtNoActa = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rbRechazado = New System.Windows.Forms.RadioButton()
        Me.rbAdmitido = New System.Windows.Forms.RadioButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFecActa = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dtpFecResConsejo = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.chkActivo)
        Me.GroupBox2.Controls.Add(Me.txtNoActa)
        Me.GroupBox2.Controls.Add(Me.txtObservaciones)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.rbRechazado)
        Me.GroupBox2.Controls.Add(Me.rbAdmitido)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.dtpFecActa)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.dtpFecResConsejo)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(28, 187)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(607, 164)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consejo Administración"
        '
        'chkActivo
        '
        Me.chkActivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.ForeColor = System.Drawing.Color.Black
        Me.chkActivo.Location = New System.Drawing.Point(293, 20)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(291, 27)
        Me.chkActivo.TabIndex = 9
        Me.chkActivo.Text = "Activar como Asociado"
        '
        'txtNoActa
        '
        Me.txtNoActa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoActa.Location = New System.Drawing.Point(168, 52)
        Me.txtNoActa.MaxLength = 20
        Me.txtNoActa.Name = "txtNoActa"
        Me.txtNoActa.Size = New System.Drawing.Size(113, 23)
        Me.txtNoActa.TabIndex = 2
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(168, 83)
        Me.txtObservaciones.MaxLength = 255
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(416, 44)
        Me.txtObservaciones.TabIndex = 6
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(7, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 16)
        Me.Label13.TabIndex = 120
        Me.Label13.Text = "Observaciones:"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(7, 58)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 18)
        Me.Label12.TabIndex = 119
        Me.Label12.Text = "Número de Acta:"
        '
        'rbRechazado
        '
        Me.rbRechazado.BackColor = System.Drawing.Color.White
        Me.rbRechazado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRechazado.ForeColor = System.Drawing.Color.Black
        Me.rbRechazado.Location = New System.Drawing.Point(271, 134)
        Me.rbRechazado.Name = "rbRechazado"
        Me.rbRechazado.Size = New System.Drawing.Size(106, 18)
        Me.rbRechazado.TabIndex = 8
        Me.rbRechazado.Text = "&Rechazado"
        Me.rbRechazado.UseVisualStyleBackColor = False
        '
        'rbAdmitido
        '
        Me.rbAdmitido.BackColor = System.Drawing.Color.White
        Me.rbAdmitido.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAdmitido.ForeColor = System.Drawing.Color.Black
        Me.rbAdmitido.Location = New System.Drawing.Point(168, 134)
        Me.rbAdmitido.Name = "rbAdmitido"
        Me.rbAdmitido.Size = New System.Drawing.Size(96, 18)
        Me.rbAdmitido.TabIndex = 7
        Me.rbAdmitido.Text = "&Admitido"
        Me.rbAdmitido.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(7, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 18)
        Me.Label11.TabIndex = 116
        Me.Label11.Text = "Resolución del Consejo:"
        '
        'dtpFecActa
        '
        Me.dtpFecActa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecActa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecActa.Location = New System.Drawing.Point(392, 53)
        Me.dtpFecActa.Name = "dtpFecActa"
        Me.dtpFecActa.Size = New System.Drawing.Size(113, 23)
        Me.dtpFecActa.TabIndex = 3
        Me.dtpFecActa.Value = New Date(2018, 7, 17, 0, 0, 0, 0)
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(289, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 18)
        Me.Label9.TabIndex = 109
        Me.Label9.Text = "Fecha de Acta:"
        '
        'dtpFecResConsejo
        '
        Me.dtpFecResConsejo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecResConsejo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecResConsejo.Location = New System.Drawing.Point(168, 22)
        Me.dtpFecResConsejo.Name = "dtpFecResConsejo"
        Me.dtpFecResConsejo.Size = New System.Drawing.Size(113, 23)
        Me.dtpFecResConsejo.TabIndex = 1
        Me.dtpFecResConsejo.Value = New Date(2018, 7, 17, 0, 0, 0, 0)
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(7, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 21)
        Me.Label10.TabIndex = 108
        Me.Label10.Text = "Fecha de Resolución:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(545, 358)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 123
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.txtDui)
        Me.GroupBox4.Controls.Add(Me.txtNombre)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.txtNoSocio)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(28, 66)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(607, 114)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Asociado"
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(97, 28)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.ReadOnly = True
        Me.txtDui.Size = New System.Drawing.Size(144, 21)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(97, 55)
        Me.txtNombre.MaxLength = 20
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(487, 50)
        Me.txtNombre.TabIndex = 3
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(16, 28)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(38, 18)
        Me.Label31.TabIndex = 94
        Me.Label31.Text = "Dui:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.Location = New System.Drawing.Point(440, 24)
        Me.txtNoSocio.MaxLength = 8
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(144, 23)
        Me.txtNoSocio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(337, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "No. Asociado:"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(16, 52)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 18)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Asociado:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMsActivaAsociado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(665, 445)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(665, 445)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(665, 445)
        Me.Name = "frmMsActivaAsociado"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Activación de Asociado"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMsActivaAsociado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        dtpFecActa.Value = Date.Today
        dtpFecResConsejo.Value = Date.Today
        If pEstado <> "1" Then Me.btnGuardar1.Visible = False
        Try
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet

            Dim Filas As Data.DataRowCollection
            Dim vLen As Long, x As Integer

            ds = oAsoc.ConsultarEstadoIngreso("*", "a.Correlativo='" & pCorrelativo & "'", "a.Dui", sUsuario, sPassword, sSucursal)

            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtDui.Value = pDui
                txtObservaciones.Text = IIf(IsDBNull(Filas.Item(0)("Observaciones")), "", Filas.Item(0)("Observaciones"))
                dtpFecResConsejo.Value = IIf(IsDBNull(Filas.Item(0)("FecResolucionConsejo")), Date.Now, Filas.Item(0)("FecResolucionConsejo"))
                If IsDBNull(Filas.Item(0)("Resolucion")) Then
                    rbAdmitido.Checked = False
                    rbRechazado.Checked = True
                Else
                    If CStr(Filas.Item(0)("Resolucion")) = "A" Then
                        rbAdmitido.Checked = True
                        rbRechazado.Checked = False
                    ElseIf CStr(Filas.Item(0)("Resolucion")) = "R" Then
                        rbAdmitido.Checked = False
                        rbRechazado.Checked = True
                    End If
                End If



                txtNoActa.Text = IIf(IsDBNull(Filas.Item(0)("ActaNo")), "", Filas.Item(0)("ActaNo"))
                dtpFecActa.Value = IIf(IsDBNull(Filas.Item(0)("FechaActa")), Date.Now, Filas.Item(0)("FechaActa"))
                If IsDBNull(Filas.Item(0)("ActivarAsociado")) Then
                    chkActivo.Checked = False
                Else
                    If CStr(Filas.Item(0)("ActivarAsociado")) = 0 Then
                        chkActivo.Checked = False
                    ElseIf CStr(Filas.Item(0)("ActivarAsociado")) = 1 Then
                        chkActivo.Checked = True
                    End If
                End If

            End If
            ds = oAsoc.ConsultarAsociado("NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre", "Dui='" & Trim(pDui) & "'", "Dui", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtNoSocio.Text = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))
                txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                txtDui.Enabled = False
                txtNoSocio.Enabled = False
                txtNombre.Enabled = False
            End If

        Catch ex As Exception

        End Try

    End Sub




    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String, pResolucion As String, ds As New DataSet, Filas As DataRowCollection, pResolucionCE As String, oApp As New wrAdmin.wsLibAdmin, pNoAsociado As String
        Try
            If Me.rbAdmitido.Checked = True Then
                pResolucion = "A"
            ElseIf Me.rbRechazado.Checked = True Then
                pResolucion = "R"
            End If




            pDui = Trim(Me.txtDui.Text)
            pCampos = "Observaciones='" & Trim(Me.txtObservaciones.Text) &
                "',UsuarioAutoriza='" & sUsuario &
                "',UsuarioGerenciaAutoriza='" & sUsuario &
                "',FecResolucionConsejo='" & dtpFecResConsejo.Value.ToShortDateString &
                "',Resolucion='" & pResolucion &
                "',Obs='" & Trim(Me.txtObservaciones.Text) &
                "',ActaNo='" & Trim(Me.txtNoActa.Text) &
                "',FechaActa='" & dtpFecActa.Value.ToShortDateString &
                "',ActivarAsociado='" & System.Math.Abs(CInt(Me.chkActivo.Checked)) &
                "',UsuarioActiva='" & sUsuario &
                "',FechaUsuarioActiva='" & Now.ToShortDateString &
                "',ResolucionCE='" & pResolucionCE & "'"
            If oAsoc.ModificarEstadoIngreso("Correlativo='" & pCorrelativo & "'", pCampos, sUsuario, sPassword, sSucursal) = True Then
                If ValidaAspirante(pDui) = True Then
                    ds = oAsoc.ConsultarAsociado("Correlativo", "Dui='" & pDui & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        oAsoc.ModificarAsociado(Filas.Item(0)("Correlativo"), "", "", "EstadoIngreso='1'", sUsuario, sPassword, sSucursal)
                    End If
                End If
                If Me.chkActivo.Checked = True Then
                    ds = oAsoc.ConsultarAsociado("Correlativo,EstadoAsociado,NoSocio", "Dui='" & pDui & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then

                        oAsoc.ModificarAsociado(Filas.Item(0)("Correlativo"), "", "", "EstadoIngreso='2',EstadoAsociado=25,FechaEstado='" & oApp.Fecha.ToShortDateString &
                                                "',NoSocio='" & txtNoSocio.Text & "'", sUsuario, sPassword, sSucursal)
                        oAsoc.ModificarEstadoIngreso("Correlativo='" & pCorrelativo & "'", "NoSocio='" & txtNoSocio.Text & "'", sUsuario, sPassword, sSucursal)
                        Dim DtsOrigenAsociado As New DataSet
                        Dim origen As String
                        Dim dtsEstadoIngreso As New DataSet
                        dtsEstadoIngreso = oAsoc.ConsultarEstadoIngreso("CodEjecMercadeo", "a.Correlativo='" & pCorrelativo & "'", "a.Dui", sUsuario, sPassword, sSucursal)
                        DtsOrigenAsociado = oAsoc.ConsultarEjecutivosMercadeo("CodSucursal", "CodEjecMercadeo = '" & dtsEstadoIngreso.Tables(0).Rows(0).Item("CodEjecMercadeo").ToString.Trim & "'", "", sUsuario, sPassword, sSucursal)

                    End If
                End If
                MsgBox("Asociado activo", MsgBoxStyle.Information, "Módulo Asociados")
                Me.Dispose()
            Else
                MsgBox("El Registro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical)
            End If

        Catch ex As Exception
            MsgBox("Error, por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical, "Módulo - Asociados")
        End Try
    End Sub



    Private Function ValidaAspirante(ByVal pDui As String) As Boolean

        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection, vLen As Long, x As Integer
        Try
            ds = oAsoc.ConsultarEstadoIngreso("*", "a.Correlativo='" & pCorrelativo & "'", "a.Dui", sUsuario, sPassword, sSucursal)

            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then

                If Filas.Item(0)("DocumentosCompletos") = 0 Then
                    ValidaAspirante = False
                ElseIf Filas.Item(0)("Fotografias") = 0 Then
                    ValidaAspirante = False
                ElseIf (Filas.Item(0)("TituloFotocop")) = 0 Then
                    ValidaAspirante = False
                ElseIf (Filas.Item(0)("DUIFotocop")) = 0 Then
                    ValidaAspirante = False
                ElseIf (Filas.Item(0)("NITFotocop")) = 0 Then
                    ValidaAspirante = False
                ElseIf Trim(CStr(Filas.Item(0)("ReciboCuotaInicial"))) = "" Then
                    ValidaAspirante = False
                Else
                    ValidaAspirante = True
                End If

            End If

        Catch ex As Exception

        End Try
    End Function

    Private Sub txtDui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

    Private Sub frmMsActivaAsociado_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class