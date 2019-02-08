
Imports System.Globalization
Imports System.Threading
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Data

Public Class frmMsEmpleados
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Public vAccion As String
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblCorreo As System.Windows.Forms.Label
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSigTb1_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAtrasTb3_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cbSucursal As ComboBox
    Friend WithEvents Label21 As Label
    Friend WithEvents chkRenta As CheckBox
    Friend WithEvents chkAFP As CheckBox
    Friend WithEvents chkISSS As CheckBox
    Private oPlan As wrPlanilla.wsLibPlanilla = New wrPlanilla.wsLibPlanilla
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) '' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)
        Thread.CurrentThread.CurrentCulture = New CultureInfo("es-SV")
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
    Friend WithEvents OpenDlg As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtNit As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtDescCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtCodCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtCodEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtLugarNac As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtLugarExtDUI As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents dtpFecExtDUI As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCodAFP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNIP As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtISSS As System.Windows.Forms.TextBox
    Friend WithEvents txtApeCas As System.Windows.Forms.TextBox
    Friend WithEvents txtApe1 As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents llblAFP As System.Windows.Forms.Label
    Friend WithEvents txtNoAFP As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtApe2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCodUsuario As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonos As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtApePaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtApeMaterno As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNombreISSS As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtNombreInstitucion As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtCodInstitucion As System.Windows.Forms.TextBox
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpFecRetiro As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDescCodRetiro As System.Windows.Forms.TextBox
    Friend WithEvents txtCodRetiro As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtGradoAcademico As System.Windows.Forms.TextBox
    Friend WithEvents cbEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescTipoEmp As System.Windows.Forms.TextBox
    Friend WithEvents txtEstatus As System.Windows.Forms.TextBox
    Friend WithEvents cbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents txtAFP As System.Windows.Forms.TextBox
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents chkSeguro As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFecIng As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbGradoAcademico As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chkLicencia As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.OpenDlg = New System.Windows.Forms.OpenFileDialog()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.chkLicencia = New System.Windows.Forms.CheckBox()
        Me.dtpFecIng = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAFP = New System.Windows.Forms.TextBox()
        Me.txtEstatus = New System.Windows.Forms.TextBox()
        Me.cboSexo = New System.Windows.Forms.ComboBox()
        Me.cbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.txtNit = New C1.Win.C1Input.C1TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtDescCargo = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtCodCargo = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtCodEmpleado = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtLugarNac = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtLugarExtDUI = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.dtpFecExtDUI = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCodAFP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNIP = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtISSS = New System.Windows.Forms.TextBox()
        Me.txtApeCas = New System.Windows.Forms.TextBox()
        Me.txtApe1 = New System.Windows.Forms.TextBox()
        Me.dtpFecNac = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.llblAFP = New System.Windows.Forms.Label()
        Me.txtNoAFP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApe2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCodUsuario = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbGradoAcademico = New System.Windows.Forms.ComboBox()
        Me.chkSeguro = New System.Windows.Forms.CheckBox()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.txtDescTipoEmp = New System.Windows.Forms.TextBox()
        Me.txtGradoAcademico = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtDescCodRetiro = New System.Windows.Forms.TextBox()
        Me.txtCodRetiro = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.dtpFecRetiro = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTipoEmpleado = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtTelefonos = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txtApePaterno = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtApeMaterno = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNombreISSS = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbFormaPago = New System.Windows.Forms.ComboBox()
        Me.txtNombreInstitucion = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtCodInstitucion = New System.Windows.Forms.TextBox()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.cbSucursal = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.btnSigTb1_1 = New MetroFramework.Controls.MetroButton()
        Me.btnAtrasTb3_1 = New MetroFramework.Controls.MetroButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.chkISSS = New System.Windows.Forms.CheckBox()
        Me.chkAFP = New System.Windows.Forms.CheckBox()
        Me.chkRenta = New System.Windows.Forms.CheckBox()
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenDlg
        '
        Me.OpenDlg.Filter = "Archivos *.bmp|*.bmp|Archivos *.jpg|*.jpg|Archivos *.gif|*.gif"
        Me.OpenDlg.Title = "Abrir Archivo de Imagen"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(405, 378)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(176, 20)
        Me.txtEmail.TabIndex = 45
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(303, 378)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(94, 13)
        Me.lblCorreo.TabIndex = 44
        Me.lblCorreo.Text = "Correo Electronico"
        '
        'chkLicencia
        '
        Me.chkLicencia.BackColor = System.Drawing.Color.White
        Me.chkLicencia.Location = New System.Drawing.Point(306, 170)
        Me.chkLicencia.Name = "chkLicencia"
        Me.chkLicencia.Size = New System.Drawing.Size(96, 16)
        Me.chkLicencia.TabIndex = 22
        Me.chkLicencia.Text = "Tiene licencia"
        Me.chkLicencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkLicencia.UseVisualStyleBackColor = False
        '
        'dtpFecIng
        '
        Me.dtpFecIng.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecIng.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIng.Location = New System.Drawing.Point(121, 64)
        Me.dtpFecIng.Name = "dtpFecIng"
        Me.dtpFecIng.Size = New System.Drawing.Size(176, 20)
        Me.dtpFecIng.TabIndex = 7
        Me.dtpFecIng.Value = New Date(2006, 3, 13, 17, 37, 53, 882)
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Fecha de Ingreso:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAFP
        '
        Me.txtAFP.BackColor = System.Drawing.Color.White
        Me.txtAFP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAFP.Location = New System.Drawing.Point(175, 350)
        Me.txtAFP.MaxLength = 50
        Me.txtAFP.Name = "txtAFP"
        Me.txtAFP.ReadOnly = True
        Me.txtAFP.Size = New System.Drawing.Size(406, 20)
        Me.txtAFP.TabIndex = 41
        '
        'txtEstatus
        '
        Me.txtEstatus.BackColor = System.Drawing.Color.White
        Me.txtEstatus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstatus.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstatus.ForeColor = System.Drawing.Color.Teal
        Me.txtEstatus.Location = New System.Drawing.Point(191, 16)
        Me.txtEstatus.MaxLength = 1
        Me.txtEstatus.Name = "txtEstatus"
        Me.txtEstatus.Size = New System.Drawing.Size(120, 16)
        Me.txtEstatus.TabIndex = 2
        Me.txtEstatus.Text = "ESTADO: ACTIVO"
        Me.txtEstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboSexo
        '
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cboSexo.Location = New System.Drawing.Point(121, 168)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(176, 22)
        Me.cboSexo.TabIndex = 21
        '
        'cbEstadoCivil
        '
        Me.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCivil.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "Divorciado", "Acompañado", "Viudo"})
        Me.cbEstadoCivil.Location = New System.Drawing.Point(405, 142)
        Me.cbEstadoCivil.Name = "cbEstadoCivil"
        Me.cbEstadoCivil.Size = New System.Drawing.Size(176, 22)
        Me.cbEstadoCivil.TabIndex = 19
        '
        'txtNit
        '
        Me.txtNit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNit.EditMask = "0000-000000-000-0"
        Me.txtNit.Location = New System.Drawing.Point(121, 248)
        Me.txtNit.MaxLength = 20
        Me.txtNit.Name = "txtNit"
        Me.txtNit.NumericInput = False
        Me.txtNit.Size = New System.Drawing.Size(176, 18)
        Me.txtNit.TabIndex = 30
        Me.txtNit.Tag = Nothing
        '
        'txtDui
        '
        Me.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(121, 196)
        Me.txtDui.MaxLength = 20
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(176, 18)
        Me.txtDui.TabIndex = 24
        Me.txtDui.Tag = Nothing
        '
        'txtDescCargo
        '
        Me.txtDescCargo.BackColor = System.Drawing.Color.White
        Me.txtDescCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescCargo.Location = New System.Drawing.Point(191, 38)
        Me.txtDescCargo.MaxLength = 10
        Me.txtDescCargo.Name = "txtDescCargo"
        Me.txtDescCargo.ReadOnly = True
        Me.txtDescCargo.Size = New System.Drawing.Size(390, 20)
        Me.txtDescCargo.TabIndex = 5
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(3, 165)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(40, 20)
        Me.Label32.TabIndex = 20
        Me.Label32.Text = "Sexo:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodCargo
        '
        Me.txtCodCargo.BackColor = System.Drawing.Color.White
        Me.txtCodCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCargo.Location = New System.Drawing.Point(121, 38)
        Me.txtCodCargo.MaxLength = 50
        Me.txtCodCargo.Name = "txtCodCargo"
        Me.txtCodCargo.Size = New System.Drawing.Size(64, 20)
        Me.txtCodCargo.TabIndex = 4
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.White
        Me.Label31.Location = New System.Drawing.Point(3, 38)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(80, 20)
        Me.Label31.TabIndex = 3
        Me.Label31.Text = "Código Cargo:"
        '
        'txtCodEmpleado
        '
        Me.txtCodEmpleado.BackColor = System.Drawing.Color.White
        Me.txtCodEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpleado.Location = New System.Drawing.Point(121, 12)
        Me.txtCodEmpleado.MaxLength = 10
        Me.txtCodEmpleado.Name = "txtCodEmpleado"
        Me.txtCodEmpleado.ReadOnly = True
        Me.txtCodEmpleado.Size = New System.Drawing.Size(64, 20)
        Me.txtCodEmpleado.TabIndex = 1
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(3, 12)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(112, 20)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Código Empleado:"
        '
        'txtLugarNac
        '
        Me.txtLugarNac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLugarNac.Location = New System.Drawing.Point(405, 246)
        Me.txtLugarNac.MaxLength = 50
        Me.txtLugarNac.Name = "txtLugarNac"
        Me.txtLugarNac.Size = New System.Drawing.Size(176, 20)
        Me.txtLugarNac.TabIndex = 32
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(303, 248)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 20)
        Me.Label28.TabIndex = 31
        Me.Label28.Text = "Lugar Nac.:"
        '
        'txtLugarExtDUI
        '
        Me.txtLugarExtDUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLugarExtDUI.Location = New System.Drawing.Point(121, 222)
        Me.txtLugarExtDUI.MaxLength = 50
        Me.txtLugarExtDUI.Name = "txtLugarExtDUI"
        Me.txtLugarExtDUI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLugarExtDUI.Size = New System.Drawing.Size(460, 20)
        Me.txtLugarExtDUI.TabIndex = 28
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(3, 219)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(88, 16)
        Me.Label27.TabIndex = 27
        Me.Label27.Text = "Lugar Ext-DUI:"
        '
        'dtpFecExtDUI
        '
        Me.dtpFecExtDUI.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecExtDUI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecExtDUI.Location = New System.Drawing.Point(405, 196)
        Me.dtpFecExtDUI.Name = "dtpFecExtDUI"
        Me.dtpFecExtDUI.Size = New System.Drawing.Size(176, 20)
        Me.dtpFecExtDUI.TabIndex = 26
        Me.dtpFecExtDUI.Value = New Date(2006, 3, 13, 17, 37, 51, 579)
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(303, 200)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Fec. Ext. DUI:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(3, 352)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 16)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Cod AFP:"
        '
        'txtCodAFP
        '
        Me.txtCodAFP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodAFP.Location = New System.Drawing.Point(121, 350)
        Me.txtCodAFP.MaxLength = 10
        Me.txtCodAFP.Name = "txtCodAFP"
        Me.txtCodAFP.Size = New System.Drawing.Size(48, 20)
        Me.txtCodAFP.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(303, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "NIP:"
        Me.Label7.Visible = False
        '
        'txtNIP
        '
        Me.txtNIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNIP.Location = New System.Drawing.Point(405, 272)
        Me.txtNIP.MaxLength = 20
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(176, 20)
        Me.txtNIP.TabIndex = 36
        Me.txtNIP.Visible = False
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.White
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(3, 278)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(40, 16)
        Me.Label30.TabIndex = 33
        Me.Label30.Text = "ISSS:"
        '
        'txtISSS
        '
        Me.txtISSS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtISSS.Location = New System.Drawing.Point(121, 274)
        Me.txtISSS.MaxLength = 20
        Me.txtISSS.Name = "txtISSS"
        Me.txtISSS.Size = New System.Drawing.Size(176, 20)
        Me.txtISSS.TabIndex = 34
        '
        'txtApeCas
        '
        Me.txtApeCas.BackColor = System.Drawing.Color.White
        Me.txtApeCas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApeCas.Location = New System.Drawing.Point(405, 116)
        Me.txtApeCas.MaxLength = 30
        Me.txtApeCas.Name = "txtApeCas"
        Me.txtApeCas.Size = New System.Drawing.Size(176, 20)
        Me.txtApeCas.TabIndex = 15
        '
        'txtApe1
        '
        Me.txtApe1.BackColor = System.Drawing.Color.White
        Me.txtApe1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe1.Location = New System.Drawing.Point(405, 90)
        Me.txtApe1.MaxLength = 25
        Me.txtApe1.Name = "txtApe1"
        Me.txtApe1.Size = New System.Drawing.Size(176, 20)
        Me.txtApe1.TabIndex = 11
        '
        'dtpFecNac
        '
        Me.dtpFecNac.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecNac.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecNac.Location = New System.Drawing.Point(121, 142)
        Me.dtpFecNac.Name = "dtpFecNac"
        Me.dtpFecNac.Size = New System.Drawing.Size(176, 20)
        Me.dtpFecNac.TabIndex = 17
        Me.dtpFecNac.Value = New Date(2006, 3, 13, 17, 37, 52, 200)
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(3, 148)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 16)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Fecha Nacim.:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(3, 300)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Dirección:"
        '
        'llblAFP
        '
        Me.llblAFP.BackColor = System.Drawing.Color.White
        Me.llblAFP.Location = New System.Drawing.Point(3, 380)
        Me.llblAFP.Name = "llblAFP"
        Me.llblAFP.Size = New System.Drawing.Size(48, 16)
        Me.llblAFP.TabIndex = 42
        Me.llblAFP.Text = "No AFP:"
        '
        'txtNoAFP
        '
        Me.txtNoAFP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoAFP.Location = New System.Drawing.Point(121, 376)
        Me.txtNoAFP.MaxLength = 20
        Me.txtNoAFP.Name = "txtNoAFP"
        Me.txtNoAFP.Size = New System.Drawing.Size(176, 20)
        Me.txtNoAFP.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "NIT:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(303, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Apellido Casada:"
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Location = New System.Drawing.Point(121, 90)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(176, 20)
        Me.txtNombres.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nombres:"
        '
        'txtApe2
        '
        Me.txtApe2.BackColor = System.Drawing.Color.White
        Me.txtApe2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe2.Location = New System.Drawing.Point(121, 116)
        Me.txtApe2.MaxLength = 25
        Me.txtApe2.Name = "txtApe2"
        Me.txtApe2.Size = New System.Drawing.Size(176, 20)
        Me.txtApe2.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Apellido 2:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(303, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Estado Civil:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "DUI:"
        '
        'lblCodUsuario
        '
        Me.lblCodUsuario.BackColor = System.Drawing.Color.White
        Me.lblCodUsuario.Location = New System.Drawing.Point(303, 93)
        Me.lblCodUsuario.Name = "lblCodUsuario"
        Me.lblCodUsuario.Size = New System.Drawing.Size(64, 20)
        Me.lblCodUsuario.TabIndex = 10
        Me.lblCodUsuario.Text = "Apellido 1:"
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Location = New System.Drawing.Point(121, 298)
        Me.txtDireccion.MaxLength = 255
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(460, 46)
        Me.txtDireccion.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(3, 147)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(103, 20)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Título Obtenido:"
        '
        'cbGradoAcademico
        '
        Me.cbGradoAcademico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGradoAcademico.Location = New System.Drawing.Point(105, 119)
        Me.cbGradoAcademico.Name = "cbGradoAcademico"
        Me.cbGradoAcademico.Size = New System.Drawing.Size(460, 21)
        Me.cbGradoAcademico.TabIndex = 14
        '
        'chkSeguro
        '
        Me.chkSeguro.BackColor = System.Drawing.Color.White
        Me.chkSeguro.Location = New System.Drawing.Point(445, 175)
        Me.chkSeguro.Name = "chkSeguro"
        Me.chkSeguro.Size = New System.Drawing.Size(120, 16)
        Me.chkSeguro.TabIndex = 20
        Me.chkSeguro.Text = "&Seguro Colectivo"
        Me.chkSeguro.UseVisualStyleBackColor = False
        '
        'chkEstado
        '
        Me.chkEstado.BackColor = System.Drawing.Color.White
        Me.chkEstado.Location = New System.Drawing.Point(290, 172)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(64, 16)
        Me.chkEstado.TabIndex = 19
        Me.chkEstado.Text = "&Inactivo"
        Me.chkEstado.UseVisualStyleBackColor = False
        '
        'txtDescTipoEmp
        '
        Me.txtDescTipoEmp.BackColor = System.Drawing.Color.White
        Me.txtDescTipoEmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescTipoEmp.Location = New System.Drawing.Point(159, 93)
        Me.txtDescTipoEmp.MaxLength = 10
        Me.txtDescTipoEmp.Name = "txtDescTipoEmp"
        Me.txtDescTipoEmp.ReadOnly = True
        Me.txtDescTipoEmp.Size = New System.Drawing.Size(406, 20)
        Me.txtDescTipoEmp.TabIndex = 12
        '
        'txtGradoAcademico
        '
        Me.txtGradoAcademico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGradoAcademico.Location = New System.Drawing.Point(105, 146)
        Me.txtGradoAcademico.MaxLength = 50
        Me.txtGradoAcademico.Name = "txtGradoAcademico"
        Me.txtGradoAcademico.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGradoAcademico.Size = New System.Drawing.Size(460, 20)
        Me.txtGradoAcademico.TabIndex = 16
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(3, 122)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(103, 20)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "Grado Académico:"
        '
        'txtDescCodRetiro
        '
        Me.txtDescCodRetiro.BackColor = System.Drawing.Color.White
        Me.txtDescCodRetiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescCodRetiro.Location = New System.Drawing.Point(159, 198)
        Me.txtDescCodRetiro.MaxLength = 10
        Me.txtDescCodRetiro.Name = "txtDescCodRetiro"
        Me.txtDescCodRetiro.ReadOnly = True
        Me.txtDescCodRetiro.Size = New System.Drawing.Size(406, 20)
        Me.txtDescCodRetiro.TabIndex = 23
        '
        'txtCodRetiro
        '
        Me.txtCodRetiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodRetiro.Enabled = False
        Me.txtCodRetiro.Location = New System.Drawing.Point(105, 198)
        Me.txtCodRetiro.MaxLength = 50
        Me.txtCodRetiro.Name = "txtCodRetiro"
        Me.txtCodRetiro.Size = New System.Drawing.Size(48, 20)
        Me.txtCodRetiro.TabIndex = 22
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(3, 200)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 20)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "Código Retiro:"
        '
        'dtpFecRetiro
        '
        Me.dtpFecRetiro.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecRetiro.Enabled = False
        Me.dtpFecRetiro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecRetiro.Location = New System.Drawing.Point(105, 172)
        Me.dtpFecRetiro.Name = "dtpFecRetiro"
        Me.dtpFecRetiro.Size = New System.Drawing.Size(176, 20)
        Me.dtpFecRetiro.TabIndex = 18
        Me.dtpFecRetiro.Value = New Date(2006, 3, 13, 17, 37, 53, 792)
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Fecha de Retiro:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTipoEmpleado
        '
        Me.txtTipoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoEmpleado.Location = New System.Drawing.Point(105, 93)
        Me.txtTipoEmpleado.MaxLength = 1
        Me.txtTipoEmpleado.Name = "txtTipoEmpleado"
        Me.txtTipoEmpleado.Size = New System.Drawing.Size(48, 20)
        Me.txtTipoEmpleado.TabIndex = 11
        '
        'Label35
        '
        Me.Label35.BackColor = System.Drawing.Color.White
        Me.Label35.Location = New System.Drawing.Point(3, 97)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(96, 16)
        Me.Label35.TabIndex = 10
        Me.Label35.Text = "Tipo de personal:"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCelular
        '
        Me.txtCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCelular.Location = New System.Drawing.Point(389, 67)
        Me.txtCelular.MaxLength = 10
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(176, 20)
        Me.txtCelular.TabIndex = 9
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.White
        Me.Label34.Location = New System.Drawing.Point(287, 71)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(56, 16)
        Me.Label34.TabIndex = 8
        Me.Label34.Text = "Celular:"
        '
        'txtTelefonos
        '
        Me.txtTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefonos.Location = New System.Drawing.Point(105, 67)
        Me.txtTelefonos.MaxLength = 50
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.Size = New System.Drawing.Size(176, 20)
        Me.txtTelefonos.TabIndex = 7
        '
        'Label33
        '
        Me.Label33.BackColor = System.Drawing.Color.White
        Me.Label33.Location = New System.Drawing.Point(3, 67)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(64, 16)
        Me.Label33.TabIndex = 6
        Me.Label33.Text = "Teléfonos:"
        '
        'txtApePaterno
        '
        Me.txtApePaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApePaterno.Location = New System.Drawing.Point(389, 15)
        Me.txtApePaterno.MaxLength = 25
        Me.txtApePaterno.Name = "txtApePaterno"
        Me.txtApePaterno.Size = New System.Drawing.Size(176, 20)
        Me.txtApePaterno.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(3, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Apellido Paterno:"
        '
        'txtApeMaterno
        '
        Me.txtApeMaterno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApeMaterno.Location = New System.Drawing.Point(105, 15)
        Me.txtApeMaterno.MaxLength = 25
        Me.txtApeMaterno.Name = "txtApeMaterno"
        Me.txtApeMaterno.Size = New System.Drawing.Size(176, 20)
        Me.txtApeMaterno.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(287, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 20)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Apellido Materno:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombreISSS
        '
        Me.txtNombreISSS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreISSS.Location = New System.Drawing.Point(105, 41)
        Me.txtNombreISSS.MaxLength = 50
        Me.txtNombreISSS.Name = "txtNombreISSS"
        Me.txtNombreISSS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNombreISSS.Size = New System.Drawing.Size(460, 20)
        Me.txtNombreISSS.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(3, 41)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 16)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Carnet ISSS:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbFormaPago
        '
        Me.cbFormaPago.BackColor = System.Drawing.Color.White
        Me.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormaPago.Items.AddRange(New Object() {"-- Seleccionar Forma de Pago --", "Efectivo", "Cheque", "Transferencia a cuenta"})
        Me.cbFormaPago.Location = New System.Drawing.Point(99, 11)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(470, 21)
        Me.cbFormaPago.TabIndex = 1
        '
        'txtNombreInstitucion
        '
        Me.txtNombreInstitucion.BackColor = System.Drawing.Color.White
        Me.txtNombreInstitucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreInstitucion.Location = New System.Drawing.Point(177, 38)
        Me.txtNombreInstitucion.MaxLength = 10
        Me.txtNombreInstitucion.Name = "txtNombreInstitucion"
        Me.txtNombreInstitucion.ReadOnly = True
        Me.txtNombreInstitucion.Size = New System.Drawing.Size(392, 20)
        Me.txtNombreInstitucion.TabIndex = 4
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(3, 11)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(90, 16)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Forma de Pago:"
        '
        'txtCodInstitucion
        '
        Me.txtCodInstitucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodInstitucion.Location = New System.Drawing.Point(99, 38)
        Me.txtCodInstitucion.MaxLength = 10
        Me.txtCodInstitucion.Name = "txtCodInstitucion"
        Me.txtCodInstitucion.Size = New System.Drawing.Size(72, 20)
        Me.txtCodInstitucion.TabIndex = 3
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuenta.Location = New System.Drawing.Point(99, 73)
        Me.txtNoCuenta.MaxLength = 30
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.Size = New System.Drawing.Size(232, 20)
        Me.txtNoCuenta.TabIndex = 6
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(3, 77)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 16)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "No. Cuenta:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(3, 38)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(90, 28)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Código institución:"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Location = New System.Drawing.Point(23, 63)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(602, 446)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabControl1.TabIndex = 2
        Me.MetroTabControl1.UseSelectable = True
        Me.MetroTabControl1.UseStyleColors = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.txtEstatus)
        Me.MetroTabPage1.Controls.Add(Me.lblCorreo)
        Me.MetroTabPage1.Controls.Add(Me.txtEmail)
        Me.MetroTabPage1.Controls.Add(Me.txtAFP)
        Me.MetroTabPage1.Controls.Add(Me.llblAFP)
        Me.MetroTabPage1.Controls.Add(Me.Label14)
        Me.MetroTabPage1.Controls.Add(Me.txtNoAFP)
        Me.MetroTabPage1.Controls.Add(Me.chkLicencia)
        Me.MetroTabPage1.Controls.Add(Me.txtCodAFP)
        Me.MetroTabPage1.Controls.Add(Me.Label29)
        Me.MetroTabPage1.Controls.Add(Me.dtpFecIng)
        Me.MetroTabPage1.Controls.Add(Me.txtCodEmpleado)
        Me.MetroTabPage1.Controls.Add(Me.Label10)
        Me.MetroTabPage1.Controls.Add(Me.txtNIP)
        Me.MetroTabPage1.Controls.Add(Me.txtDireccion)
        Me.MetroTabPage1.Controls.Add(Me.Label7)
        Me.MetroTabPage1.Controls.Add(Me.Label28)
        Me.MetroTabPage1.Controls.Add(Me.txtLugarNac)
        Me.MetroTabPage1.Controls.Add(Me.Label30)
        Me.MetroTabPage1.Controls.Add(Me.txtNit)
        Me.MetroTabPage1.Controls.Add(Me.txtISSS)
        Me.MetroTabPage1.Controls.Add(Me.cboSexo)
        Me.MetroTabPage1.Controls.Add(Me.txtDui)
        Me.MetroTabPage1.Controls.Add(Me.Label8)
        Me.MetroTabPage1.Controls.Add(Me.txtLugarExtDUI)
        Me.MetroTabPage1.Controls.Add(Me.Label32)
        Me.MetroTabPage1.Controls.Add(Me.Label27)
        Me.MetroTabPage1.Controls.Add(Me.cbEstadoCivil)
        Me.MetroTabPage1.Controls.Add(Me.Label15)
        Me.MetroTabPage1.Controls.Add(Me.dtpFecExtDUI)
        Me.MetroTabPage1.Controls.Add(Me.txtCodCargo)
        Me.MetroTabPage1.Controls.Add(Me.Label6)
        Me.MetroTabPage1.Controls.Add(Me.Label31)
        Me.MetroTabPage1.Controls.Add(Me.txtDescCargo)
        Me.MetroTabPage1.Controls.Add(Me.txtNombres)
        Me.MetroTabPage1.Controls.Add(Me.Label4)
        Me.MetroTabPage1.Controls.Add(Me.txtApe1)
        Me.MetroTabPage1.Controls.Add(Me.lblCodUsuario)
        Me.MetroTabPage1.Controls.Add(Me.txtApe2)
        Me.MetroTabPage1.Controls.Add(Me.Label3)
        Me.MetroTabPage1.Controls.Add(Me.txtApeCas)
        Me.MetroTabPage1.Controls.Add(Me.Label5)
        Me.MetroTabPage1.Controls.Add(Me.dtpFecNac)
        Me.MetroTabPage1.Controls.Add(Me.Label2)
        Me.MetroTabPage1.Controls.Add(Me.Label17)
        Me.MetroTabPage1.Controls.Add(Me.Label1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(594, 404)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Información Personal"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.cbSucursal)
        Me.MetroTabPage2.Controls.Add(Me.Label21)
        Me.MetroTabPage2.Controls.Add(Me.chkSeguro)
        Me.MetroTabPage2.Controls.Add(Me.Label13)
        Me.MetroTabPage2.Controls.Add(Me.Label19)
        Me.MetroTabPage2.Controls.Add(Me.txtCodRetiro)
        Me.MetroTabPage2.Controls.Add(Me.txtDescCodRetiro)
        Me.MetroTabPage2.Controls.Add(Me.chkEstado)
        Me.MetroTabPage2.Controls.Add(Me.cbGradoAcademico)
        Me.MetroTabPage2.Controls.Add(Me.Label9)
        Me.MetroTabPage2.Controls.Add(Me.dtpFecRetiro)
        Me.MetroTabPage2.Controls.Add(Me.txtGradoAcademico)
        Me.MetroTabPage2.Controls.Add(Me.txtApePaterno)
        Me.MetroTabPage2.Controls.Add(Me.Label20)
        Me.MetroTabPage2.Controls.Add(Me.Label12)
        Me.MetroTabPage2.Controls.Add(Me.txtDescTipoEmp)
        Me.MetroTabPage2.Controls.Add(Me.Label11)
        Me.MetroTabPage2.Controls.Add(Me.txtApeMaterno)
        Me.MetroTabPage2.Controls.Add(Me.txtNombreISSS)
        Me.MetroTabPage2.Controls.Add(Me.Label18)
        Me.MetroTabPage2.Controls.Add(Me.Label33)
        Me.MetroTabPage2.Controls.Add(Me.txtTelefonos)
        Me.MetroTabPage2.Controls.Add(Me.Label35)
        Me.MetroTabPage2.Controls.Add(Me.txtCelular)
        Me.MetroTabPage2.Controls.Add(Me.Label34)
        Me.MetroTabPage2.Controls.Add(Me.txtTipoEmpleado)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(594, 404)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Otros Datos"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'cbSucursal
        '
        Me.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSucursal.Location = New System.Drawing.Point(105, 234)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(460, 21)
        Me.cbSucursal.TabIndex = 25
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(3, 234)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 16)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "Sucursal:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.btnGuardar1)
        Me.MetroTabPage3.Controls.Add(Me.Label22)
        Me.MetroTabPage3.Controls.Add(Me.txtNoCuenta)
        Me.MetroTabPage3.Controls.Add(Me.txtNombreInstitucion)
        Me.MetroTabPage3.Controls.Add(Me.cbFormaPago)
        Me.MetroTabPage3.Controls.Add(Me.Label16)
        Me.MetroTabPage3.Controls.Add(Me.txtCodInstitucion)
        Me.MetroTabPage3.Controls.Add(Me.Label25)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(594, 404)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Forma de Pago"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'btnGuardar1
        '
        Me.btnGuardar1.ForeColor = System.Drawing.Color.Teal
        Me.btnGuardar1.Location = New System.Drawing.Point(494, 111)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 0
        Me.btnGuardar1.Text = "&Agregar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'btnSigTb1_1
        '
        Me.btnSigTb1_1.ForeColor = System.Drawing.Color.Teal
        Me.btnSigTb1_1.Location = New System.Drawing.Point(550, 514)
        Me.btnSigTb1_1.Name = "btnSigTb1_1"
        Me.btnSigTb1_1.Size = New System.Drawing.Size(75, 28)
        Me.btnSigTb1_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSigTb1_1.TabIndex = 3
        Me.btnSigTb1_1.Text = "Siguiente"
        Me.btnSigTb1_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSigTb1_1.UseSelectable = True
        Me.btnSigTb1_1.UseStyleColors = True
        '
        'btnAtrasTb3_1
        '
        Me.btnAtrasTb3_1.ForeColor = System.Drawing.Color.Teal
        Me.btnAtrasTb3_1.Location = New System.Drawing.Point(469, 514)
        Me.btnAtrasTb3_1.Name = "btnAtrasTb3_1"
        Me.btnAtrasTb3_1.Size = New System.Drawing.Size(75, 28)
        Me.btnAtrasTb3_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAtrasTb3_1.TabIndex = 2
        Me.btnAtrasTb3_1.Text = "Atrás"
        Me.btnAtrasTb3_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAtrasTb3_1.UseSelectable = True
        Me.btnAtrasTb3_1.UseStyleColors = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'chkISSS
        '
        Me.chkISSS.BackColor = System.Drawing.Color.White
        Me.chkISSS.Location = New System.Drawing.Point(36, 521)
        Me.chkISSS.Name = "chkISSS"
        Me.chkISSS.Size = New System.Drawing.Size(53, 16)
        Me.chkISSS.TabIndex = 23
        Me.chkISSS.Text = "ISSS"
        Me.chkISSS.UseVisualStyleBackColor = False
        '
        'chkAFP
        '
        Me.chkAFP.BackColor = System.Drawing.Color.White
        Me.chkAFP.Location = New System.Drawing.Point(91, 521)
        Me.chkAFP.Name = "chkAFP"
        Me.chkAFP.Size = New System.Drawing.Size(50, 16)
        Me.chkAFP.TabIndex = 24
        Me.chkAFP.Text = "AFP"
        Me.chkAFP.UseVisualStyleBackColor = False
        '
        'chkRenta
        '
        Me.chkRenta.BackColor = System.Drawing.Color.White
        Me.chkRenta.Location = New System.Drawing.Point(148, 521)
        Me.chkRenta.Name = "chkRenta"
        Me.chkRenta.Size = New System.Drawing.Size(55, 16)
        Me.chkRenta.TabIndex = 25
        Me.chkRenta.Text = "Renta"
        Me.chkRenta.UseVisualStyleBackColor = False
        '
        'frmMsEmpleados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(644, 590)
        Me.Controls.Add(Me.chkRenta)
        Me.Controls.Add(Me.chkAFP)
        Me.Controls.Add(Me.chkISSS)
        Me.Controls.Add(Me.btnSigTb1_1)
        Me.Controls.Add(Me.btnAtrasTb3_1)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsEmpleados"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Empleados"
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.MetroTabPage3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public vDui As String

    Private Sub txtDui_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        ds = oPlan.ConsultarPLPlazas("*", "DUI LIKE '" & Trim(Me.txtDui.Text) & "%'", "DUI", False, sUsuario, sPassword, sSucursal)
        Filas = ds.Tables(0).Rows()
        Me.txtDui.Text = CStr(Filas.Item(0)("DUI")).Trim

    End Sub

    Private Sub txtCodCargo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodCargo.Validating

        Dim ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        ds = oPlan.ConsultarPLCargos("*", "CodCargo LIKE '" & Trim(Me.txtCodCargo.Text) & "%'", "CodCargo", sUsuario, sPassword, sSucursal)
        Filas = ds.Tables(0).Rows()
        Me.txtCodCargo.Text = CStr(Filas.Item(0)("CodCargo")).Trim
        Me.txtDescCargo.Text = CStr(Filas.Item(0)("Descripcion")).Trim
    End Sub

    Private Sub txtCodInstitucion_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodInstitucion.Validating

        Dim ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        ds = oPlan.ConsultarPLInstituciones("*", "CodInstitucion LIKE '" & Trim(Me.txtCodInstitucion.Text) & "%'", "CodInstitucion", sUsuario, sPassword, sSucursal)
        Filas = ds.Tables(0).Rows()
        Me.txtCodInstitucion.Text = CStr(Filas.Item(0)("CodInstitucion")).Trim
        Me.txtNombreInstitucion.Text = CStr(Filas.Item(0)("Nombre")).Trim
    End Sub

    Private Sub txtCodCargo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodCargo.DoubleClick

        Dim ds As New Data.DataSet
        Dim sResultado1 As String, sResultado2 As String
        Dim ofrm As New frmAGenerico


        Try
            ofrm.Text = "Buscar códigos de cargo"
            ds = oPlan.ConsultarPLCargos("*", "", "CodCargo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodCargo.Text = ofrm.Resultado
            Me.txtDescCargo.Text = ofrm.Resultado2
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub txtCodInstitucion_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodInstitucion.DoubleClick

        Dim ds As New Data.DataSet
        Dim sResultado1 As String, sResultado2 As String
        Dim ofrm As New frmAGenerico


        Try
            ofrm.Text = "Buscar códigos de Instituciones"
            ds = oPlan.ConsultarPLInstituciones("*", "", "CodInstitucion", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodInstitucion.Text = ofrm.Resultado
            Me.txtNombreInstitucion.Text = ofrm.Resultado2
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub dtpFecIng_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If Me.btnGuardar1.Text = "&Guardar" Then Me.txtCodEmpleado.Text = oPlan.GenerarCarneEmpleado("'" & Me.dtpFecIng.Value.ToShortDateString & "'", sUsuario, sPassword, sSucursal)
    End Sub

    Private Sub frmMsEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MetroTabControl1.TabIndex = 0
        Dim ds As New Data.DataSet, dr As DataRow
        Dim Filas As Data.DataRowCollection
        If Me.vAccion = "Modificar" Then
            ds = oPlan.ConsultarPLMotivoRetiro("*", "CodRetiro = '" & Trim(Me.txtCodRetiro.Text) & "'", "CodRetiro", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                Me.txtCodRetiro.Text = CStr(Filas.Item(0)("CodRetiro")).Trim
                Me.txtDescCodRetiro.Text = CStr(Filas.Item(0)("Descripcion")).Trim
            End If
            ds = oPlan.ConsultarPLTipoPersonal("*", "CodTipoPersonal = '" & Trim(Me.txtTipoEmpleado.Text) & "'", "CodTipoPersonal", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                Me.txtTipoEmpleado.Text = CStr(Filas.Item(0)("CodTipoPersonal")).Trim
                Me.txtDescTipoEmp.Text = CStr(Filas.Item(0)("Descripcion")).Trim
            End If
            ds = oPlan.ConsultarPLCargos("*", "CodCargo = '" & Trim(Me.txtCodCargo.Text) & "'", "CodCargo", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                Me.txtCodCargo.Text = CStr(Filas.Item(0)("CodCargo")).Trim
                Me.txtDescCargo.Text = CStr(Filas.Item(0)("Descripcion")).Trim
            End If
            ds = oPlan.ConsultarPLInstituciones("*", "CodInstitucion = '" & Trim(Me.txtCodInstitucion.Text) & "'", "CodInstitucion", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                Me.txtCodInstitucion.Text = CStr(Filas.Item(0)("CodInstitucion")).Trim
                Me.txtNombreInstitucion.Text = CStr(Filas.Item(0)("Nombre")).Trim
            End If

            ds = oPlan.ConsultarPLPensiones("*", "CodPension = '" & Trim(Me.txtCodAFP.Text) & "'", "CodPension", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                Me.txtCodAFP.Text = CStr(Filas.Item(0)("CodPension")).Trim
                Me.txtAFP.Text = CStr(Filas.Item(0)("Descripcion")).Trim
            End If



        Else
            ds = oPlan.ConsultarPLGradoAcademico("*", "", "CodGrado", sUsuario, sPassword, sSucursal)

            Me.cbGradoAcademico.DisplayMember = "Descripcion"
            Me.cbGradoAcademico.ValueMember = "CodGrado"
            Me.cbGradoAcademico.DataSource = ds.Tables(0)

            ds = oPlan.Consultar_Sucursales()
            Me.cbSucursal.DisplayMember = "NOM_SUCURSAl"
            Me.cbSucursal.ValueMember = "CODSUCURSAL"
            Me.cbSucursal.DataSource = ds.Tables(0)

            'For Each dr In ds.Tables(0).Rows
            '    Me.cbGradoAcademico.Items.Add(CStr(dr("CodGrado")).Trim & " - " & CStr(dr("Descripcion")).Trim)
            'Next


            Me.cbGradoAcademico.SelectedIndex = 0
            Me.cbSucursal.SelectedIndex = 0
            Me.dtpFecIng.Value = Now
            Me.dtpFecNac.Value = Now
            Me.dtpFecRetiro.Value = Now
            Me.dtpFecExtDUI.Value = Now
            Me.cbEstadoCivil.SelectedIndex = 0
            Me.cbFormaPago.SelectedIndex = 0
            Me.cboSexo.SelectedIndex = 0
        End If

    End Sub

    Private Sub txtCodRetiro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodRetiro.DoubleClick
        Dim ds As New Data.DataSet
        Dim sResultado1 As String, sResultado2 As String
        Dim ofrm As New frmAGenerico
        'oPlan = New wsSysPlanCOOPAS.LibPlanillaCOOPAS.wsLibPlanillaCOOPAS

        Try
            ofrm.Text = "Buscar códigos de retiro"
            ds = oPlan.ConsultarPLMotivoRetiro("*", "", "CodRetiro", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodRetiro.Text = ofrm.Resultado
            Me.txtDescCodRetiro.Text = ofrm.Resultado2
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub txtCodRetiro_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodRetiro.Validating
        Dim ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        ds = oPlan.ConsultarPLMotivoRetiro("*", "CodRetiro LIKE '" & Trim(Me.txtCodRetiro.Text) & "%'", "CodRetiro", sUsuario, sPassword, sSucursal)
        Filas = ds.Tables(0).Rows()
        Me.txtCodRetiro.Text = CStr(Filas.Item(0)("CodRetiro")).Trim
        Me.txtDescCodRetiro.Text = CStr(Filas.Item(0)("Descripcion")).Trim
    End Sub

    Private Sub txtTipoEmpleado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtTipoEmpleado.Validating
        Dim ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        ds = oPlan.ConsultarPLTipoPersonal("*", "CodTipoPersonal LIKE '" & Trim(Me.txtTipoEmpleado.Text) & "%'", "CodTipoPersonal", sUsuario, sPassword, sSucursal)
        Filas = ds.Tables(0).Rows()
        Me.txtTipoEmpleado.Text = CStr(Filas.Item(0)("CodTipoPersonal")).Trim
        Me.txtDescTipoEmp.Text = CStr(Filas.Item(0)("Descripcion")).Trim
    End Sub

    Private Sub txtTipoEmpleado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoEmpleado.DoubleClick
        Dim ds As New Data.DataSet
        Dim sResultado1 As String, sResultado2 As String
        Dim ofrm As New frmAGenerico
        Try
            ofrm.Text = "Buscar Tipos de Personal"
            ds = oPlan.ConsultarPLTipoPersonal("*", "", "CodTipoPersonal", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtTipoEmpleado.Text = ofrm.Resultado
            Me.txtDescTipoEmp.Text = ofrm.Resultado2
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub cbFormaPago_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbFormaPago.SelectedIndexChanged
        If Me.cbFormaPago.SelectedIndex = 3 Then
            Me.txtCodInstitucion.Enabled = True
            Me.txtNoCuenta.Enabled = True
        Else
            Me.txtCodInstitucion.Enabled = False
            Me.txtNoCuenta.Enabled = False
        End If
    End Sub

    Private Sub txtCodAFP_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodAFP.Validating
        Dim ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        ds = oPlan.ConsultarPLPensiones("*", "CodPension LIKE '" & Trim(Me.txtCodAFP.Text) & "%'", "CodPension", sUsuario, sPassword, sSucursal)
        Filas = ds.Tables(0).Rows()
        Me.txtCodAFP.Text = CStr(Filas.Item(0)("CodPension")).Trim
        Me.txtAFP.Text = CStr(Filas.Item(0)("Descripcion")).Trim
    End Sub

    Private Sub txtCodAFP_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodAFP.DoubleClick
        Dim ds As New Data.DataSet
        Dim sResultado1 As String, sResultado2 As String
        Dim ofrm As New frmAGenerico

        Try
            ofrm.Text = "Buscar códigos de Institución - Pensiones"
            ds = oPlan.ConsultarPLPensiones("*", "", "CodPension", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodAFP.Text = ofrm.Resultado
            Me.txtAFP.Text = ofrm.Resultado2
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub


    Private Sub chkEstado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkEstado.CheckedChanged
        If Me.chkEstado.Checked = True Then
            Me.dtpFecRetiro.Enabled = True
            Me.txtCodRetiro.Enabled = True
        Else
            Me.dtpFecRetiro.Enabled = False
            Me.txtCodRetiro.Enabled = False
        End If
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

    Private Sub txtApe1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApe1.LostFocus
        Me.txtApePaterno.Text = Me.txtApe1.Text.Trim
    End Sub

    Private Sub txtApe2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtApe2.LostFocus
        Me.txtApeMaterno.Text = Me.txtApe2.Text.Trim
    End Sub

    Private Sub txtNombres_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNombres.LostFocus
        Me.txtNombreISSS.Text = Me.txtNombres.Text.Trim
    End Sub

    Private Sub btnAtrasTb3_1_Click(sender As Object, e As EventArgs) Handles btnAtrasTb3_1.Click
        If Me.MetroTabControl1.SelectedIndex >= 1 Then Me.MetroTabControl1.SelectedIndex = Me.MetroTabControl1.SelectedIndex - 1
    End Sub

    Private Sub btnSigTb1_1_Click(sender As Object, e As EventArgs) Handles btnSigTb1_1.Click
        Me.MetroTabControl1.SelectedIndex = Me.MetroTabControl1.SelectedIndex + 1
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            If requeridos() = True Then
                Dim Campos, Valores, CamposValores As String, pCodRetiro As String, pCodInt As String
                Dim Resultado As Integer
                If Me.txtCodRetiro.Text.Trim = "" Then
                    pCodRetiro = "0"
                Else
                    pCodRetiro = Me.txtCodRetiro.Text.Trim
                End If
                If Me.txtCodInstitucion.Text.Trim = "" Then
                    pCodInt = "0"
                Else
                    pCodInt = Me.txtCodInstitucion.Text.Trim
                End If

                If Me.btnGuardar1.Text = "&Guardar" Then

                    Me.txtCodEmpleado.Text = oPlan.GenerarCarneEmpleado("" & Me.dtpFecIng.Value.ToShortDateString & "", sUsuario, sPassword, sSucursal)
                    Campos = "CodEmpleado,Apellido1,Apellido2,ApellidoCas,Nombres,Sexo,FechaIngreso,EstadoCivil,CodCargo,CodTipoPersonal,FechaRetiro,FechaNac," &
                    "LugarNac,DUI,FechaExtDUI,LugarExtDUI,NIT,NIP,FormaPago,CodInstitucion,NoCuenta,ISSS,Direccion,Telefonos,Celular,Ap_Materno,Ap_Paterno,Nombre_ISSS, " &
                    "CodPension,NoAFP,SeguroColectivo,Estado,CodRetiro,GradoAcademico,CodGrado,PoseeLic,NumLicencia,Email,CodSucursal,DescISSS,DescAFP,DescRenta"
                    Valores = "'" & Trim(Me.txtCodEmpleado.Text) & "','" & Trim(Me.txtApe1.Text) & "','" & Trim(Me.txtApe2.Text) & "','" & Trim(Me.txtApeCas.Text) &
                    "','" & Trim(Me.txtNombres.Text) & "','" & cboSexo.SelectedIndex & "','" & Format(Me.dtpFecIng.Value, "dd/MM/yyyy") & "','" & cbEstadoCivil.SelectedIndex &
                    "','" & Trim(Me.txtCodCargo.Text) & "','" & Trim(Me.txtTipoEmpleado.Text) & "','" & Format(Me.dtpFecRetiro.Value, "dd/MM/yyyy") & "','" &
                    Format(Me.dtpFecNac.Value, "dd/MM/yyyy") & "','" & Trim(Me.txtLugarNac.Text) & "','" & Trim(Me.txtDui.Text) & "','" & Format(Me.dtpFecExtDUI.Value, "dd/MM/yyyy") &
                    "','" & Trim(Me.txtLugarExtDUI.Text) & "','" & Trim(Me.txtNit.Text) & "','" & Trim(Me.txtNIP.Text) & "','" & Me.cbFormaPago.SelectedIndex & "','" & pCodInt &
                    "','" & (Me.txtNoCuenta.Text) & "','" & Trim(Me.txtISSS.Text) & "','" & Trim(Me.txtDireccion.Text) & "','" & Trim(Me.txtTelefonos.Text) & "','" & Trim(Me.txtCelular.Text) &
                    "','" & Trim(Me.txtApeMaterno.Text) & "','" & Trim(Me.txtApePaterno.Text) & "','" & Trim(Me.txtNombreISSS.Text) & "','" & Trim(Me.txtCodAFP.Text) & "','" & Trim(Me.txtNoAFP.Text) &
                    "','" & IIf(Me.chkSeguro.Checked = True, "S", "N") & "','" & IIf(Me.chkEstado.Checked = True, "R", "A") & "','" & pCodRetiro & "','" & Trim(Me.txtGradoAcademico.Text) & "','" &
                    Me.cbGradoAcademico.SelectedValue & "','" & IIf(Me.chkLicencia.Checked = True, "1", "0") & "','" & IIf(Me.chkLicencia.Checked = True, Me.txtNit.Text.Trim, "") & "','" & Me.txtEmail.Text.Trim & "' , '" & Me.cbSucursal.SelectedValue & "', '" & chkISSS.CheckState & "', '" & chkAFP.CheckState & "', '" & chkRenta.CheckState & "' "
                    If oPlan.InsertarPLEmpleado(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                        vAccion = "Modificar"
                        btnGuardar1.Text = "&Modificar"
                        txtCodEmpleado.ReadOnly = True
                        MsgBox("Registro ingresado exitosamente.", MsgBoxStyle.Information)
                    Else
                        MsgBox("Los datos no fueron ingresados", MsgBoxStyle.Critical, "Módulo - Planilla")
                    End If
                ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                    CamposValores = "Dui='" & Trim(Me.txtDui.Text) & "',Apellido1='" & Trim(Me.txtApe1.Text) & "',Apellido2='" & Trim(Me.txtApe2.Text) & "',ApellidoCas='" & Trim(Me.txtApeCas.Text) & "',Nombres='" & Trim(Me.txtNombres.Text) & "',Sexo='" & cboSexo.SelectedIndex & "',FechaIngreso='" & Format(Me.dtpFecIng.Value, "dd/MM/yyyy") & "',EstadoCivil='" & cbEstadoCivil.SelectedIndex & "',CodCargo='" & Trim(Me.txtCodCargo.Text) & "',CodTipoPersonal='" & Trim(Me.txtTipoEmpleado.Text) & "',FechaRetiro='" & Format(Me.dtpFecRetiro.Value, "dd/MM/yyyy") & "',FechaNac='" & Format(Me.dtpFecNac.Value, "dd/MM/yyyy") & "',LugarNac='" & Trim(Me.txtLugarNac.Text) & "',FechaExtDUI='" & Format(Me.dtpFecExtDUI.Value, "dd/MM/yyyy") & "',LugarExtDUI='" & Trim(Me.txtLugarExtDUI.Text) & "',NIT='" & Trim(Me.txtNit.Text) & "',NIP='" & Trim(Me.txtNIP.Text) & "',FormaPago='" & Me.cbFormaPago.SelectedIndex & "',CodInstitucion='" & pCodInt & "',NoCuenta='" & Trim(Me.txtNoCuenta.Text) & "',ISSS='" & Trim(Me.txtISSS.Text) & "',Direccion='" & Trim(Me.txtDireccion.Text) & "',Telefonos='" & Trim(Me.txtTelefonos.Text) & "',Celular='" & Trim(Me.txtCelular.Text) & "',Ap_Materno='" & Trim(Me.txtApeMaterno.Text) & "',Ap_Paterno='" & Trim(Me.txtApePaterno.Text) & "',Nombre_ISSS='" & Trim(Me.txtNombreISSS.Text) & "',CodPension='" & Trim(Me.txtCodAFP.Text) & "',NoAFP='" & Trim(Me.txtNoAFP.Text) & "',SeguroColectivo='" & IIf(Me.chkSeguro.Checked = True, "S", "N") & "',Estado='" & IIf(Me.chkEstado.Checked = True, "R", "A") & "',CodRetiro='" & pCodRetiro & "',GradoAcademico='" & Trim(Me.txtGradoAcademico.Text) & "',CodGrado='" & Me.cbGradoAcademico.Text.Substring(0, 2).Trim & "',PoseeLic='" & IIf(Me.chkLicencia.Checked = True, "1", "0") & "',NumLicencia='" & IIf(Me.chkLicencia.Checked = True, Me.txtNit.Text.Trim, "") & "',Email='" & Me.txtEmail.Text.Trim & "' , CodSucursal= '" & Me.cbSucursal.SelectedValue & "', DescISSS= '" & chkISSS.CheckState & "', DescAFP='" & chkAFP.CheckState & "', DescRenta='" & chkRenta.CheckState & "' "
                    If oPlan.ModificarPLEmpleado(CamposValores, "'" & Trim(Me.txtCodInstitucion.Text) & "'", "'" & Trim(Me.txtCodCargo.Text) & "'", "'" & Trim(Me.txtCodEmpleado.Text) & "'", sUsuario, sPassword, sSucursal) = True Then
                        MsgBox("Registro actualizado exitosamente.", MsgBoxStyle.Information)
                    Else
                        MsgBox("Los datos no fueron actualizados correctamente.", MsgBoxStyle.Critical, "Módulo - Planilla")
                    End If
                End If
            End If

        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
    Protected Function requeridos() As Boolean
        Dim valido As Boolean = True
        Me.ErrorProvider1.Clear()
        If Me.txtCodCargo.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtCodCargo, "Campo Requerido")
            valido = False
        End If
        If Me.txtNombres.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtNombres, "Campo Requerido")
            valido = False
        End If
        If Me.txtApe1.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtApe1, "Campo Requerido")
            valido = False
        End If
        If Me.txtDui.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtDui, "Campo Requerido")
            valido = False
        End If
        If Me.txtNit.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtNit, "Campo Requerido")
            valido = False
        End If
        If Me.txtCodAFP.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtCodAFP, "Campo Requerido")
            valido = False
        End If
        If Me.txtNoAFP.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtNoAFP, "Campo Requerido")
            valido = False
        End If
        If Me.txtTipoEmpleado.Text.Trim.Length = 0 Then
            Me.ErrorProvider1.SetError(txtTipoEmpleado, "Campo Requerido")
            valido = False
        End If
        If Me.cbFormaPago.SelectedIndex = 0 Then
            Me.ErrorProvider1.SetError(cbFormaPago, "Campo Requerido")
            valido = False
        End If
        If Me.cbFormaPago.SelectedIndex = 3 Then
            If Me.txtCodInstitucion.Text.Trim.Length = 0 Then
                Me.ErrorProvider1.SetError(txtCodInstitucion, "Campo Requerido")
                valido = False
            End If
            If Me.txtNoCuenta.Text.Trim.Length = 0 Then
                Me.ErrorProvider1.SetError(txtNoCuenta, "Campo Requerido")
                valido = False
            End If
        End If

        Return valido
    End Function

    Private Sub chkISSS_CheckedChanged(sender As Object, e As EventArgs) Handles chkISSS.CheckedChanged

    End Sub
End Class
