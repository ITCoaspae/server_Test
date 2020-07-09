Public Class frmMsFallecimiento
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecCA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNoActaCA As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoLiquidacion As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkLiquidacion As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNoCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtObs As System.Windows.Forms.TextBox
    Friend WithEvents chkFallecEfectuado As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFecFallec As System.Windows.Forms.DateTimePicker
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpFecCA = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNoActaCA = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtObs = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNoLiquidacion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkFallecEfectuado = New System.Windows.Forms.CheckBox()
        Me.dtpFecFallec = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.chkLiquidacion = New System.Windows.Forms.CheckBox()
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
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.dtpFecCA)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtNoActaCA)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(28, 167)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(670, 89)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consejo de Administración"
        '
        'dtpFecCA
        '
        Me.dtpFecCA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecCA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCA.Location = New System.Drawing.Point(110, 57)
        Me.dtpFecCA.Name = "dtpFecCA"
        Me.dtpFecCA.Size = New System.Drawing.Size(124, 23)
        Me.dtpFecCA.TabIndex = 1
        Me.dtpFecCA.Value = New Date(2004, 9, 9, 10, 41, 0, 0)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 18)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Fecha Acta:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 19)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "No. de Acta:"
        '
        'txtNoActaCA
        '
        Me.txtNoActaCA.Location = New System.Drawing.Point(110, 23)
        Me.txtNoActaCA.MaxLength = 20
        Me.txtNoActaCA.Name = "txtNoActaCA"
        Me.txtNoActaCA.Size = New System.Drawing.Size(202, 23)
        Me.txtNoActaCA.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.txtObs)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtNoLiquidacion)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.chkFallecEfectuado)
        Me.GroupBox3.Controls.Add(Me.dtpFecFallec)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.chkLiquidacion)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtNoCheque)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(28, 263)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(670, 143)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información General"
        '
        'txtObs
        '
        Me.txtObs.Location = New System.Drawing.Point(149, 57)
        Me.txtObs.MaxLength = 255
        Me.txtObs.Multiline = True
        Me.txtObs.Name = "txtObs"
        Me.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObs.Size = New System.Drawing.Size(509, 39)
        Me.txtObs.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(7, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 19)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "Observaciones:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNoLiquidacion
        '
        Me.txtNoLiquidacion.Location = New System.Drawing.Point(149, 103)
        Me.txtNoLiquidacion.MaxLength = 20
        Me.txtNoLiquidacion.Name = "txtNoLiquidacion"
        Me.txtNoLiquidacion.Size = New System.Drawing.Size(134, 23)
        Me.txtNoLiquidacion.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(7, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 18)
        Me.Label12.TabIndex = 110
        Me.Label12.Text = "No. de liquidación:"
        '
        'chkFallecEfectuado
        '
        Me.chkFallecEfectuado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkFallecEfectuado.Enabled = False
        Me.chkFallecEfectuado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFallecEfectuado.ForeColor = System.Drawing.Color.Black
        Me.chkFallecEfectuado.Location = New System.Drawing.Point(485, 27)
        Me.chkFallecEfectuado.Name = "chkFallecEfectuado"
        Me.chkFallecEfectuado.Size = New System.Drawing.Size(173, 18)
        Me.chkFallecEfectuado.TabIndex = 5
        Me.chkFallecEfectuado.Text = "&Asociado retirado"
        '
        'dtpFecFallec
        '
        Me.dtpFecFallec.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecFallec.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecFallec.Location = New System.Drawing.Point(149, 27)
        Me.dtpFecFallec.Name = "dtpFecFallec"
        Me.dtpFecFallec.Size = New System.Drawing.Size(123, 23)
        Me.dtpFecFallec.TabIndex = 0
        Me.dtpFecFallec.Value = New Date(2004, 9, 9, 10, 41, 0, 0)
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(7, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 18)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Fecha Fallecimiento:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkLiquidacion
        '
        Me.chkLiquidacion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLiquidacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLiquidacion.ForeColor = System.Drawing.Color.Black
        Me.chkLiquidacion.Location = New System.Drawing.Point(280, 30)
        Me.chkLiquidacion.Name = "chkLiquidacion"
        Me.chkLiquidacion.Size = New System.Drawing.Size(172, 18)
        Me.chkLiquidacion.TabIndex = 4
        Me.chkLiquidacion.Text = "&Liquidación efectuada"
        Me.chkLiquidacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(290, 106)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(210, 15)
        Me.Label10.TabIndex = 99
        Me.Label10.Text = "No. de cheque cancela liquidación:"
        '
        'txtNoCheque
        '
        Me.txtNoCheque.Location = New System.Drawing.Point(508, 103)
        Me.txtNoCheque.MaxLength = 20
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.Size = New System.Drawing.Size(150, 23)
        Me.txtNoCheque.TabIndex = 3
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
        Me.GroupBox4.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(670, 87)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Asociado"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(269, 22)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(144, 24)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'txtCodAntiguo
        '
        Me.txtCodAntiguo.Location = New System.Drawing.Point(533, 22)
        Me.txtCodAntiguo.MaxLength = 10
        Me.txtCodAntiguo.Name = "txtCodAntiguo"
        Me.txtCodAntiguo.Size = New System.Drawing.Size(125, 23)
        Me.txtCodAntiguo.TabIndex = 2
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(420, 28)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(106, 18)
        Me.Label48.TabIndex = 114
        Me.Label48.Text = "Código Antiguo:"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(223, 28)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(39, 18)
        Me.Label31.TabIndex = 94
        Me.Label31.Text = "Dui:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.Location = New System.Drawing.Point(110, 22)
        Me.txtNoSocio.MaxLength = 8
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(106, 23)
        Me.txtNoSocio.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "No. Asociado:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(110, 52)
        Me.txtNombre.MaxLength = 150
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(548, 23)
        Me.txtNombre.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(7, 53)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 19)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Asociado:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(594, 413)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(104, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 140
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsFallecimiento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(721, 498)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsFallecimiento"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Fallecimiento"
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
            dtpFecFallec.Value = Date.Today

            If Me.btnGuardar1.Text = "&Modificar" Then

                Dim Filas As Data.DataRowCollection
                '                Dim vLen As Long, x As Integer

                ds = oAsoc.ConsultarFallecidos("*", "Correlativo='" & Me.Correlativo & "'", "Correlativo", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    dtpFecFallec.Value = CDate(Filas.Item(0)("FechaFallece"))
                    txtObs.Text = CStr(Filas.Item(0)("Observacion"))
                    txtNoActaCA.Text = CStr(Filas.Item(0)("ActaNo"))
                    dtpFecCA.Value = CDate(Filas.Item(0)("FechaActa"))
                    If CStr(Filas.Item(0)("Liquidacion")) = 0 Then
                        chkLiquidacion.Checked = False
                    ElseIf CStr(Filas.Item(0)("Liquidacion")) = 1 Then
                        chkLiquidacion.Checked = True
                    End If
                    txtNoCheque.Text = CStr(Filas.Item(0)("NoCheque"))
                    txtNoLiquidacion.Text = CStr(Filas.Item(0)("NoLiquidacion"))
                    If CStr(Filas.Item(0)("FallecidoRegEfectuado")) = 0 Then
                        chkFallecEfectuado.Checked = False
                    ElseIf CStr(Filas.Item(0)("FallecidoRegEfectuado")) = 1 Then
                        chkFallecEfectuado.Checked = True
                    End If
                    If Trim(Me.txtNoActaCA.Text) <> "" Then
                        chkFallecEfectuado.Enabled = True
                    End If
                End If
                ds = oAsoc.ConsultarAsociado("NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre", "Dui='" & Trim(txtDui.Text) & "'", "Dui", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNoSocio.Text = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))
                    txtCodAntiguo.Text = IIf(IsDBNull(Filas.Item(0)("CodAntiguo")), "", Filas.Item(0)("CodAntiguo"))
                    txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                    txtDui.Enabled = False
                    txtNoSocio.Enabled = False
                    txtNombre.Enabled = False
                    txtCodAntiguo.Enabled = False
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
            Select Case oAsoc.AutorizaDatos(Trim(txtDui.Text), Trim(Me.txtNoActaCA.Text), "x", "x", "x")
                Case 1
                    MsgBox("El campo Dui del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                    Exit Sub
                Case 2
                    MsgBox("El No. de Acta de Consejo de Administración no puede quedar vacía. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then

                pCampos = "Correlativo,Dui,FechaFallece,Observacion,ActaNo,FechaActa,Liquidacion,NoCheque,NoLiquidacion,FallecidoRegEfectuado"
                pValores = "" & oAsoc.ObtenerCorrelativoFallecidos("Correlativo", sUsuario, sPassword, sSucursal) & ",'" & Trim(txtDui.Text) & "','" & Format(Me.dtpFecFallec.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtObs.Text) & "','" & Trim(Me.txtNoActaCA.Text) & "','" & Format(Me.dtpFecCA.Value, "dd/MM/yyyy") & "','" & System.Math.Abs(CInt(Me.chkLiquidacion.Checked)) & "','" & Trim(Me.txtNoCheque.Text) & "','" & Trim(Me.txtNoLiquidacion.Text) & "','" & System.Math.Abs(CInt(Me.chkFallecEfectuado.Checked)) & "'"
                If oAsoc.InsertarFallecidos(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Registro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If

            ElseIf Me.btnGuardar1.Text = "&Modificar" Then

                If Me.chkFallecEfectuado.Enabled = True Then
                    oAsoc.ProcesoFallecidos(Trim(Me.txtDui.Text), Trim(Me.txtNoActaCA.Text), Me.dtpFecCA.Value, sUsuario, sPassword, sSucursal)
                    pCampos = "FechaFallece='" & Format(Me.dtpFecFallec.Value, "dd/MM/yyyy") & "',Observacion='" & Trim(Me.txtObs.Text) & "',ActaNo='" & Trim(Me.txtNoActaCA.Text) & "',FechaActa='" & Format(Me.dtpFecCA.Value, "dd/MM/yyyy") & "',Liquidacion='" & System.Math.Abs(CInt(Me.chkLiquidacion.Checked)) & "',NoCheque='" & Trim(Me.txtNoCheque.Text) & "',NoLiquidacion='" & Trim(Me.txtNoLiquidacion.Text) & "',FallecidoRegEfectuado='" & System.Math.Abs(CInt(Me.chkFallecEfectuado.Checked)) & "',Usuario='" & sUsuario & "',FechaUsuario ='" & Format(Date.Today, "dd/MM/yyyy") & "'"
                Else
                    pCampos = "FechaFallece='" & Format(Me.dtpFecFallec.Value, "dd/MM/yyyy") & "',Observacion='" & Trim(Me.txtObs.Text) & "',ActaNo='" & Trim(Me.txtNoActaCA.Text) & "',FechaActa='" & Format(Me.dtpFecCA.Value, "dd/MM/yyyy") & "',Liquidacion='" & System.Math.Abs(CInt(Me.chkLiquidacion.Checked)) & "',NoCheque='" & Trim(Me.txtNoCheque.Text) & "',NoLiquidacion='" & Trim(Me.txtNoLiquidacion.Text) & "',FallecidoRegEfectuado='" & System.Math.Abs(CInt(Me.chkFallecEfectuado.Checked)) & "'"
                End If
                If oAsoc.ModificarFallecidos("Correlativo=" & Me.Correlativo & "", pCampos, sUsuario, sPassword, sSucursal) = True Then
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

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click

        Guardar()
    End Sub

    Private Sub frmMsFallecimiento_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class