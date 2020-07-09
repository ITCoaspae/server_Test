Public Class frmMsCBDespachos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pAccion As String
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDir = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(476, 154)
        Me.txtCorreo.MaxLength = 255
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(184, 20)
        Me.txtCorreo.TabIndex = 5
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(476, 197)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(184, 20)
        Me.dtpFechaFin.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(347, 197)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 109
        Me.Label7.Text = "Hasta:"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(158, 197)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(183, 20)
        Me.dtpFechaIni.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(23, 197)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 108
        Me.Label8.Text = "Desde:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(347, 158)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 16)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Correo electrónico:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 16)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Duración de Contrato:"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(157, 155)
        Me.txtTel.MaxLength = 255
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(184, 20)
        Me.txtTel.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Teléfono:"
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(157, 112)
        Me.txtDir.MaxLength = 255
        Me.txtDir.Multiline = True
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(503, 37)
        Me.txtDir.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Dirección:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(157, 86)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(503, 20)
        Me.txtDescripcion.TabIndex = 0
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(158, 60)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Nombre del Despacho:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Código:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuardar1.Location = New System.Drawing.Point(585, 223)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1015
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCBDespachos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(686, 290)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtDir)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(686, 290)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(686, 290)
        Me.Name = "frmMsCBDespachos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Despachos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try

            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "CodDespacho,Descripcion,Direccion,Telefono,Desde,Hasta,Correo"
                pValores = "'" & Me.txtCodigo.Text.Trim & "','" & Trim(txtDescripcion.Text) & "','" & Me.txtDir.Text.Trim & "','" & Me.txtTel.Text.Trim & "','" & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "','" & Me.txtCorreo.Text.Trim & "'"
                If oCred.InsertarDespacho(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Despacho no ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Cobranzas")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Descripcion='" & Trim(txtDescripcion.Text) & "',Direccion='" & Me.txtDir.Text.Trim & "',Telefono='" & Me.txtTel.Text.Trim & "',Desde='" & Format(Me.dtpFechaIni.Value, "dd/MM/yyyy") & "',Hasta='" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "',Correo='" & Me.txtCorreo.Text.Trim & "'"
                If oCred.ModificarDespacho(Trim(pCodigo), pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Despacho no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Cobranzas")
                End If
            End If

        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dtpFechaFin_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFin.ValueChanged

    End Sub

#End Region

    Private Sub frmMsCBDespachos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection

        If Me.pAccion = "Modificar" Then

            ds = oCred.ConsultarDespacho("*", "CodDespacho='" & pCodigo & "'", "CodDespacho", sUsuario, sPassword,sSucursal)

            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtCodigo.Text = pCodigo
                txtCodigo.Enabled = False
                txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                txtDir.Text = IIf(IsDBNull(Filas.Item(0)("Direccion")), "", Filas.Item(0)("Direccion"))
                txtCorreo.Text = IIf(IsDBNull(Filas.Item(0)("Correo")), "", Filas.Item(0)("Correo"))
                txtTel.Text = IIf(IsDBNull(Filas.Item(0)("Telefono")), "", Filas.Item(0)("Telefono"))
                Me.dtpFechaIni.Value = IIf(IsDBNull(Filas.Item(0)("Desde")), Now, Filas.Item(0)("Desde"))
                Me.dtpFechaFin.Value = IIf(IsDBNull(Filas.Item(0)("Hasta")), Now, Filas.Item(0)("Hasta"))
            End If
        Else
            Me.txtCodigo.Text = oCred.ObtenerCorrelativoDespacho("CodDespacho", sUsuario, sPassword,sSucursal)
            txtCodigo.ReadOnly = True
            Me.dtpFechaIni.Value = Now
            Me.dtpFechaFin.Value = Now
        End If
        txtCodigo.Focus()
    End Sub


End Class