Imports System.ComponentModel

Public Class frmMsAhCuentas
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim Prestamos As New wrPrestamo.wsLibPrest
    Dim Ahorro As New wrAhorro.wsLibAhorro
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim libAhorro As New sifLib.Ahorro.clsAhorros
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Siguiente As MetroFramework.Controls.MetroButton
    Friend WithEvents btnSiguiente2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btTasaPactada As MetroFramework.Controls.MetroButton
    Friend WithEvents btnContrato As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton7 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton8 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton9 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelBen As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditBen As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewBen As MetroFramework.Controls.MetroButton
    Friend WithEvents btDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEditAut As MetroFramework.Controls.MetroButton
    Friend WithEvents btNew As MetroFramework.Controls.MetroButton
    Friend WithEvents btDelR As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditR As MetroFramework.Controls.MetroButton
    Friend WithEvents btNewR As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton5 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFechaCan As DateTimePicker
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents LblPlazo As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbSucursal As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtIntereses As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSaldoDisponible As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSaldo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtObservaciones As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtEstado As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSaveTb3 As MetroFramework.Controls.MetroButton
    Friend WithEvents cbEjecutivo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbTipoAhorro As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtCodPrestamo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel22 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel21 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents C1nCuota As C1.Win.C1Input.C1NumericEdit
    ' Friend WithEvents btModificaPlanAh As MetroFramework.Controls.MetroButton
    Dim bandera As Boolean
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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents tbSolic As System.Windows.Forms.TabControl
    Friend WithEvents tbDatGral As System.Windows.Forms.TabPage
    Friend WithEvents tbBeneficiarios As System.Windows.Forms.TabPage
    Friend WithEvents c1nTasa As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nMontoApertura As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents dtpFechaApertura As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecIniApertura As System.Windows.Forms.DateTimePicker
    Friend WithEvents fgBen As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tbLibRep As System.Windows.Forms.TabPage
    Friend WithEvents txtNoLibreta As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecVenc As System.Windows.Forms.DateTimePicker
    Friend WithEvents fgAut As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgR As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtApe3 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpFecNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtApe2 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtApe1 As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents dtpFecNacT2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtPartida As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents cbDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txtTitular2 As System.Windows.Forms.TextBox
    Friend WithEvents cbParentesco As System.Windows.Forms.ComboBox
    Friend WithEvents MetroButton3 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsAhCuentas))
        Me.tbSolic = New System.Windows.Forms.TabControl()
        Me.tbDatGral = New System.Windows.Forms.TabPage()
        Me.dtpFecNacT2 = New System.Windows.Forms.DateTimePicker()
        Me.cbParentesco = New System.Windows.Forms.ComboBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.txtPartida = New C1.Win.C1Input.C1TextBox()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.txtTitular2 = New System.Windows.Forms.TextBox()
        Me.cbDoc = New System.Windows.Forms.ComboBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MetroButton5 = New MetroFramework.Controls.MetroButton()
        Me.txtApe3 = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Siguiente = New MetroFramework.Controls.MetroButton()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtApe2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpFecNac = New System.Windows.Forms.DateTimePicker()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cbEstadoCivil = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtApe1 = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.txtCodPrestamo = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.cbTipoAhorro = New MetroFramework.Controls.MetroComboBox()
        Me.btnSaveTb3 = New MetroFramework.Controls.MetroButton()
        Me.txtEstado = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.txtObservaciones = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.txtIntereses = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.txtSaldoDisponible = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.txtSaldo = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFechaCan = New System.Windows.Forms.DateTimePicker()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.btnSiguiente2 = New MetroFramework.Controls.MetroButton()
        Me.LblPlazo = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.cbSucursal = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFecIniApertura = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFechaApertura = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.c1nMontoApertura = New C1.Win.C1Input.C1NumericEdit()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.c1nPlazo = New C1.Win.C1Input.C1NumericEdit()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.c1nTasa = New C1.Win.C1Input.C1NumericEdit()
        Me.txtNoLibreta = New System.Windows.Forms.TextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFecVenc = New System.Windows.Forms.DateTimePicker()
        Me.cbEjecutivo = New MetroFramework.Controls.MetroComboBox()
        Me.btTasaPactada = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.tbBeneficiarios = New System.Windows.Forms.TabPage()
        Me.fgAut = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btDel = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel22 = New MetroFramework.Controls.MetroLabel()
        Me.btnEditAut = New MetroFramework.Controls.MetroButton()
        Me.fgBen = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btNew = New MetroFramework.Controls.MetroButton()
        Me.btDelBen = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel21 = New MetroFramework.Controls.MetroLabel()
        Me.btEditBen = New MetroFramework.Controls.MetroButton()
        Me.btnContrato = New MetroFramework.Controls.MetroButton()
        Me.btNewBen = New MetroFramework.Controls.MetroButton()
        Me.MetroButton7 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton8 = New MetroFramework.Controls.MetroButton()
        Me.tbLibRep = New System.Windows.Forms.TabPage()
        Me.fgR = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btDelR = New MetroFramework.Controls.MetroButton()
        Me.MetroButton9 = New MetroFramework.Controls.MetroButton()
        Me.btEditR = New MetroFramework.Controls.MetroButton()
        Me.btNewR = New MetroFramework.Controls.MetroButton()
        Me.C1nCuota = New C1.Win.C1Input.C1NumericEdit()
        Me.tbSolic.SuspendLayout()
        Me.tbDatGral.SuspendLayout()
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.c1nMontoApertura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbBeneficiarios.SuspendLayout()
        CType(Me.fgAut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgBen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbLibRep.SuspendLayout()
        CType(Me.fgR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1nCuota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbSolic
        '
        Me.tbSolic.AllowDrop = True
        Me.tbSolic.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tbSolic.Controls.Add(Me.tbDatGral)
        Me.tbSolic.Controls.Add(Me.TabPage1)
        Me.tbSolic.Controls.Add(Me.tbBeneficiarios)
        Me.tbSolic.Controls.Add(Me.tbLibRep)
        Me.tbSolic.ItemSize = New System.Drawing.Size(300, 18)
        Me.tbSolic.Location = New System.Drawing.Point(19, 55)
        Me.tbSolic.Multiline = True
        Me.tbSolic.Name = "tbSolic"
        Me.tbSolic.SelectedIndex = 0
        Me.tbSolic.Size = New System.Drawing.Size(682, 489)
        Me.tbSolic.TabIndex = 0
        '
        'tbDatGral
        '
        Me.tbDatGral.BackColor = System.Drawing.Color.White
        Me.tbDatGral.Controls.Add(Me.dtpFecNacT2)
        Me.tbDatGral.Controls.Add(Me.cbParentesco)
        Me.tbDatGral.Controls.Add(Me.Label40)
        Me.tbDatGral.Controls.Add(Me.MetroLabel19)
        Me.tbDatGral.Controls.Add(Me.txtPartida)
        Me.tbDatGral.Controls.Add(Me.MetroLabel18)
        Me.tbDatGral.Controls.Add(Me.Label42)
        Me.tbDatGral.Controls.Add(Me.txtTitular2)
        Me.tbDatGral.Controls.Add(Me.cbDoc)
        Me.tbDatGral.Controls.Add(Me.txtDireccion)
        Me.tbDatGral.Controls.Add(Me.Label44)
        Me.tbDatGral.Controls.Add(Me.Label6)
        Me.tbDatGral.Controls.Add(Me.MetroButton5)
        Me.tbDatGral.Controls.Add(Me.txtApe3)
        Me.tbDatGral.Controls.Add(Me.Label53)
        Me.tbDatGral.Controls.Add(Me.txtNoSocio)
        Me.tbDatGral.Controls.Add(Me.Label9)
        Me.tbDatGral.Controls.Add(Me.Siguiente)
        Me.tbDatGral.Controls.Add(Me.Label54)
        Me.tbDatGral.Controls.Add(Me.Label27)
        Me.tbDatGral.Controls.Add(Me.txtApe2)
        Me.tbDatGral.Controls.Add(Me.Label10)
        Me.tbDatGral.Controls.Add(Me.dtpFecNac)
        Me.tbDatGral.Controls.Add(Me.txtNombres)
        Me.tbDatGral.Controls.Add(Me.Label8)
        Me.tbDatGral.Controls.Add(Me.Label28)
        Me.tbDatGral.Controls.Add(Me.Label26)
        Me.tbDatGral.Controls.Add(Me.cbEstadoCivil)
        Me.tbDatGral.Controls.Add(Me.Label31)
        Me.tbDatGral.Controls.Add(Me.txtDui)
        Me.tbDatGral.Controls.Add(Me.txtApe1)
        Me.tbDatGral.Controls.Add(Me.Label29)
        Me.tbDatGral.Location = New System.Drawing.Point(4, 22)
        Me.tbDatGral.Name = "tbDatGral"
        Me.tbDatGral.Size = New System.Drawing.Size(674, 463)
        Me.tbDatGral.TabIndex = 0
        Me.tbDatGral.Text = " Información de Asociado"
        '
        'dtpFecNacT2
        '
        Me.dtpFecNacT2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecNacT2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecNacT2.Location = New System.Drawing.Point(89, 325)
        Me.dtpFecNacT2.Name = "dtpFecNacT2"
        Me.dtpFecNacT2.Size = New System.Drawing.Size(225, 20)
        Me.dtpFecNacT2.TabIndex = 9
        Me.dtpFecNacT2.Value = New Date(2019, 3, 1, 0, 0, 0, 0)
        '
        'cbParentesco
        '
        Me.cbParentesco.Location = New System.Drawing.Point(89, 271)
        Me.cbParentesco.Name = "cbParentesco"
        Me.cbParentesco.Size = New System.Drawing.Size(569, 21)
        Me.cbParentesco.TabIndex = 1
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(11, 321)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(73, 30)
        Me.Label40.TabIndex = 8
        Me.Label40.Text = "Fecha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento:"
        Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel19.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel19.ForeColor = System.Drawing.Color.Teal
        Me.MetroLabel19.Location = New System.Drawing.Point(12, 209)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(112, 25)
        Me.MetroLabel19.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel19.TabIndex = 1027
        Me.MetroLabel19.Text = "Datos Titular"
        Me.MetroLabel19.UseCustomBackColor = True
        Me.MetroLabel19.UseCustomForeColor = True
        Me.MetroLabel19.UseStyleColors = True
        '
        'txtPartida
        '
        Me.txtPartida.AcceptsReturn = True
        Me.txtPartida.EditMask = "00000000-0"
        Me.txtPartida.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartida.Location = New System.Drawing.Point(434, 297)
        Me.txtPartida.MaxLength = 20
        Me.txtPartida.Name = "txtPartida"
        Me.txtPartida.NumericInput = False
        Me.txtPartida.Size = New System.Drawing.Size(224, 18)
        Me.txtPartida.TabIndex = 7
        Me.txtPartida.Tag = Nothing
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel18.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel18.ForeColor = System.Drawing.Color.Teal
        Me.MetroLabel18.Location = New System.Drawing.Point(12, 13)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(212, 25)
        Me.MetroLabel18.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel18.TabIndex = 1026
        Me.MetroLabel18.Text = "Información de Asociado"
        Me.MetroLabel18.UseCustomBackColor = True
        Me.MetroLabel18.UseCustomForeColor = True
        Me.MetroLabel18.UseStyleColors = True
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(338, 299)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(89, 16)
        Me.Label42.TabIndex = 6
        Me.Label42.Text = "No. Documento"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTitular2
        '
        Me.txtTitular2.Location = New System.Drawing.Point(89, 247)
        Me.txtTitular2.Name = "txtTitular2"
        Me.txtTitular2.Size = New System.Drawing.Size(569, 20)
        Me.txtTitular2.TabIndex = 1
        '
        'cbDoc
        '
        Me.cbDoc.BackColor = System.Drawing.Color.White
        Me.cbDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDoc.Items.AddRange(New Object() {"DUI", "NIT", "No. Licencia", "No. Residente", "No. Partida y No. Folio", "No. Pasaporte"})
        Me.cbDoc.Location = New System.Drawing.Point(89, 297)
        Me.cbDoc.Name = "cbDoc"
        Me.cbDoc.Size = New System.Drawing.Size(224, 22)
        Me.cbDoc.TabIndex = 5
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.White
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(80, 157)
        Me.txtDireccion.MaxLength = 500
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(577, 49)
        Me.txtDireccion.TabIndex = 26
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(12, 296)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(70, 19)
        Me.Label44.TabIndex = 4
        Me.Label44.Text = "Documento :"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 21)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Dirección:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroButton5
        '
        Me.MetroButton5.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.MetroButton5.Location = New System.Drawing.Point(482, 325)
        Me.MetroButton5.Name = "MetroButton5"
        Me.MetroButton5.Size = New System.Drawing.Size(95, 28)
        Me.MetroButton5.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton5.TabIndex = 1024
        Me.MetroButton5.Text = "&Datos Asociado"
        Me.MetroButton5.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton5.UseSelectable = True
        Me.MetroButton5.UseStyleColors = True
        '
        'txtApe3
        '
        Me.txtApe3.AcceptsReturn = True
        Me.txtApe3.BackColor = System.Drawing.Color.White
        Me.txtApe3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApe3.Location = New System.Drawing.Point(80, 122)
        Me.txtApe3.MaxLength = 25
        Me.txtApe3.Name = "txtApe3"
        Me.txtApe3.ReadOnly = True
        Me.txtApe3.Size = New System.Drawing.Size(224, 20)
        Me.txtApe3.TabIndex = 14
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(12, 273)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(72, 16)
        Me.Label53.TabIndex = 2
        Me.Label53.Text = "Parentesco:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.Location = New System.Drawing.Point(432, 49)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(225, 20)
        Me.txtNoSocio.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(11, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 31)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Apellido de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Casada"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Siguiente
        '
        Me.Siguiente.Location = New System.Drawing.Point(582, 325)
        Me.Siguiente.Name = "Siguiente"
        Me.Siguiente.Size = New System.Drawing.Size(75, 28)
        Me.Siguiente.Style = MetroFramework.MetroColorStyle.Teal
        Me.Siguiente.TabIndex = 0
        Me.Siguiente.Text = "Siguiente"
        Me.Siguiente.UseSelectable = True
        Me.Siguiente.UseStyleColors = True
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(12, 249)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(60, 17)
        Me.Label54.TabIndex = 0
        Me.Label54.Text = "Nombre:"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(11, 97)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 16)
        Me.Label27.TabIndex = 9
        Me.Label27.Text = "Apellido 2"
        '
        'txtApe2
        '
        Me.txtApe2.AcceptsReturn = True
        Me.txtApe2.BackColor = System.Drawing.Color.White
        Me.txtApe2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApe2.Location = New System.Drawing.Point(80, 97)
        Me.txtApe2.MaxLength = 25
        Me.txtApe2.Name = "txtApe2"
        Me.txtApe2.ReadOnly = True
        Me.txtApe2.Size = New System.Drawing.Size(224, 20)
        Me.txtApe2.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(347, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 33)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Nacimiento:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecNac
        '
        Me.dtpFecNac.Enabled = False
        Me.dtpFecNac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecNac.Location = New System.Drawing.Point(432, 126)
        Me.dtpFecNac.Name = "dtpFecNac"
        Me.dtpFecNac.Size = New System.Drawing.Size(225, 20)
        Me.dtpFecNac.TabIndex = 22
        Me.dtpFecNac.Value = New Date(2019, 3, 1, 0, 0, 0, 0)
        '
        'txtNombres
        '
        Me.txtNombres.AcceptsReturn = True
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(80, 73)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.ReadOnly = True
        Me.txtNombres.Size = New System.Drawing.Size(224, 20)
        Me.txtNombres.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(347, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "No. Asociado"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(11, 73)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 15)
        Me.Label28.TabIndex = 5
        Me.Label28.Text = "Nombres"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(347, 101)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(80, 16)
        Me.Label26.TabIndex = 11
        Me.Label26.Text = "Estado Civil:"
        '
        'cbEstadoCivil
        '
        Me.cbEstadoCivil.BackColor = System.Drawing.Color.White
        Me.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCivil.Enabled = False
        Me.cbEstadoCivil.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "Divorciado", "Acompañado", "Viudo"})
        Me.cbEstadoCivil.Location = New System.Drawing.Point(432, 100)
        Me.cbEstadoCivil.Name = "cbEstadoCivil"
        Me.cbEstadoCivil.Size = New System.Drawing.Size(224, 22)
        Me.cbEstadoCivil.TabIndex = 12
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(11, 49)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(40, 16)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Dui:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDui
        '
        Me.txtDui.AcceptsReturn = True
        Me.txtDui.BorderColor = System.Drawing.Color.Black
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDui.Location = New System.Drawing.Point(80, 49)
        Me.txtDui.MaxLength = 20
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(224, 18)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'txtApe1
        '
        Me.txtApe1.AcceptsReturn = True
        Me.txtApe1.BackColor = System.Drawing.Color.White
        Me.txtApe1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApe1.Location = New System.Drawing.Point(432, 75)
        Me.txtApe1.MaxLength = 25
        Me.txtApe1.Name = "txtApe1"
        Me.txtApe1.ReadOnly = True
        Me.txtApe1.Size = New System.Drawing.Size(225, 20)
        Me.txtApe1.TabIndex = 8
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(347, 75)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(64, 16)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "Apellido 1"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.C1nCuota)
        Me.TabPage1.Controls.Add(Me.MetroLabel10)
        Me.TabPage1.Controls.Add(Me.txtCodPrestamo)
        Me.TabPage1.Controls.Add(Me.MetroLabel20)
        Me.TabPage1.Controls.Add(Me.cbTipoAhorro)
        Me.TabPage1.Controls.Add(Me.btnSaveTb3)
        Me.TabPage1.Controls.Add(Me.txtEstado)
        Me.TabPage1.Controls.Add(Me.MetroLabel17)
        Me.TabPage1.Controls.Add(Me.txtObservaciones)
        Me.TabPage1.Controls.Add(Me.MetroLabel16)
        Me.TabPage1.Controls.Add(Me.txtIntereses)
        Me.TabPage1.Controls.Add(Me.MetroLabel15)
        Me.TabPage1.Controls.Add(Me.txtSaldoDisponible)
        Me.TabPage1.Controls.Add(Me.MetroLabel14)
        Me.TabPage1.Controls.Add(Me.txtSaldo)
        Me.TabPage1.Controls.Add(Me.MetroLabel13)
        Me.TabPage1.Controls.Add(Me.MetroLabel12)
        Me.TabPage1.Controls.Add(Me.dtpFechaCan)
        Me.TabPage1.Controls.Add(Me.MetroButton1)
        Me.TabPage1.Controls.Add(Me.MetroLabel11)
        Me.TabPage1.Controls.Add(Me.btnSiguiente2)
        Me.TabPage1.Controls.Add(Me.LblPlazo)
        Me.TabPage1.Controls.Add(Me.MetroLabel9)
        Me.TabPage1.Controls.Add(Me.cbSucursal)
        Me.TabPage1.Controls.Add(Me.MetroLabel8)
        Me.TabPage1.Controls.Add(Me.dtpFecIniApertura)
        Me.TabPage1.Controls.Add(Me.MetroLabel7)
        Me.TabPage1.Controls.Add(Me.txtNoCuenta)
        Me.TabPage1.Controls.Add(Me.MetroLabel6)
        Me.TabPage1.Controls.Add(Me.dtpFechaApertura)
        Me.TabPage1.Controls.Add(Me.MetroLabel5)
        Me.TabPage1.Controls.Add(Me.c1nMontoApertura)
        Me.TabPage1.Controls.Add(Me.MetroLabel4)
        Me.TabPage1.Controls.Add(Me.c1nPlazo)
        Me.TabPage1.Controls.Add(Me.MetroLabel3)
        Me.TabPage1.Controls.Add(Me.c1nTasa)
        Me.TabPage1.Controls.Add(Me.txtNoLibreta)
        Me.TabPage1.Controls.Add(Me.MetroLabel2)
        Me.TabPage1.Controls.Add(Me.dtpFecVenc)
        Me.TabPage1.Controls.Add(Me.cbEjecutivo)
        Me.TabPage1.Controls.Add(Me.btTasaPactada)
        Me.TabPage1.Controls.Add(Me.MetroLabel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(674, 463)
        Me.TabPage1.TabIndex = 9
        Me.TabPage1.Text = " Cuenta de Ahorro"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(346, 96)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel10.TabIndex = 1030
        Me.MetroLabel10.Text = "Cuota:"
        '
        'txtCodPrestamo
        '
        '
        '
        '
        Me.txtCodPrestamo.CustomButton.Image = Nothing
        Me.txtCodPrestamo.CustomButton.Location = New System.Drawing.Point(173, 2)
        Me.txtCodPrestamo.CustomButton.Name = ""
        Me.txtCodPrestamo.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtCodPrestamo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCodPrestamo.CustomButton.TabIndex = 1
        Me.txtCodPrestamo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCodPrestamo.CustomButton.UseSelectable = True
        Me.txtCodPrestamo.CustomButton.Visible = False
        Me.txtCodPrestamo.Lines = New String(-1) {}
        Me.txtCodPrestamo.Location = New System.Drawing.Point(142, 172)
        Me.txtCodPrestamo.MaxLength = 32767
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCodPrestamo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCodPrestamo.SelectedText = ""
        Me.txtCodPrestamo.SelectionLength = 0
        Me.txtCodPrestamo.SelectionStart = 0
        Me.txtCodPrestamo.ShortcutsEnabled = True
        Me.txtCodPrestamo.Size = New System.Drawing.Size(191, 20)
        Me.txtCodPrestamo.TabIndex = 1029
        Me.txtCodPrestamo.UseSelectable = True
        Me.txtCodPrestamo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCodPrestamo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.Location = New System.Drawing.Point(15, 16)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel20.TabIndex = 1028
        Me.MetroLabel20.Text = "Linea Ahorro"
        '
        'cbTipoAhorro
        '
        Me.cbTipoAhorro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbTipoAhorro.FormattingEnabled = True
        Me.cbTipoAhorro.ItemHeight = 23
        Me.cbTipoAhorro.Location = New System.Drawing.Point(142, 16)
        Me.cbTipoAhorro.Name = "cbTipoAhorro"
        Me.cbTipoAhorro.Size = New System.Drawing.Size(517, 29)
        Me.cbTipoAhorro.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbTipoAhorro.TabIndex = 1027
        Me.cbTipoAhorro.UseSelectable = True
        '
        'btnSaveTb3
        '
        Me.btnSaveTb3.Location = New System.Drawing.Point(424, 383)
        Me.btnSaveTb3.Name = "btnSaveTb3"
        Me.btnSaveTb3.Size = New System.Drawing.Size(75, 29)
        Me.btnSaveTb3.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSaveTb3.TabIndex = 46
        Me.btnSaveTb3.Text = "Guardar"
        Me.btnSaveTb3.UseSelectable = True
        Me.btnSaveTb3.UseStyleColors = True
        '
        'txtEstado
        '
        '
        '
        '
        Me.txtEstado.CustomButton.Image = Nothing
        Me.txtEstado.CustomButton.Location = New System.Drawing.Point(174, 2)
        Me.txtEstado.CustomButton.Name = ""
        Me.txtEstado.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtEstado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtEstado.CustomButton.TabIndex = 1
        Me.txtEstado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtEstado.CustomButton.UseSelectable = True
        Me.txtEstado.CustomButton.Visible = False
        Me.txtEstado.Enabled = False
        Me.txtEstado.Lines = New String(-1) {}
        Me.txtEstado.Location = New System.Drawing.Point(467, 290)
        Me.txtEstado.MaxLength = 32767
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEstado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEstado.SelectedText = ""
        Me.txtEstado.SelectionLength = 0
        Me.txtEstado.SelectionStart = 0
        Me.txtEstado.ShortcutsEnabled = True
        Me.txtEstado.Size = New System.Drawing.Size(192, 20)
        Me.txtEstado.TabIndex = 45
        Me.txtEstado.UseSelectable = True
        Me.txtEstado.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtEstado.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Enabled = False
        Me.MetroLabel17.Location = New System.Drawing.Point(349, 290)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel17.TabIndex = 44
        Me.MetroLabel17.Text = "Estado:"
        '
        'txtObservaciones
        '
        '
        '
        '
        Me.txtObservaciones.CustomButton.Image = Nothing
        Me.txtObservaciones.CustomButton.Location = New System.Drawing.Point(453, 1)
        Me.txtObservaciones.CustomButton.Name = ""
        Me.txtObservaciones.CustomButton.Size = New System.Drawing.Size(59, 59)
        Me.txtObservaciones.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtObservaciones.CustomButton.TabIndex = 1
        Me.txtObservaciones.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtObservaciones.CustomButton.UseSelectable = True
        Me.txtObservaciones.CustomButton.Visible = False
        Me.txtObservaciones.Lines = New String(-1) {}
        Me.txtObservaciones.Location = New System.Drawing.Point(142, 317)
        Me.txtObservaciones.MaxLength = 32767
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtObservaciones.SelectedText = ""
        Me.txtObservaciones.SelectionLength = 0
        Me.txtObservaciones.SelectionStart = 0
        Me.txtObservaciones.ShortcutsEnabled = True
        Me.txtObservaciones.Size = New System.Drawing.Size(513, 61)
        Me.txtObservaciones.TabIndex = 43
        Me.txtObservaciones.UseSelectable = True
        Me.txtObservaciones.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtObservaciones.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(15, 317)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel16.TabIndex = 42
        Me.MetroLabel16.Text = "Observaciones:"
        '
        'txtIntereses
        '
        '
        '
        '
        Me.txtIntereses.CustomButton.Image = Nothing
        Me.txtIntereses.CustomButton.Location = New System.Drawing.Point(170, 2)
        Me.txtIntereses.CustomButton.Name = ""
        Me.txtIntereses.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtIntereses.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtIntereses.CustomButton.TabIndex = 1
        Me.txtIntereses.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtIntereses.CustomButton.UseSelectable = True
        Me.txtIntereses.CustomButton.Visible = False
        Me.txtIntereses.Enabled = False
        Me.txtIntereses.Lines = New String(-1) {}
        Me.txtIntereses.Location = New System.Drawing.Point(142, 290)
        Me.txtIntereses.MaxLength = 32767
        Me.txtIntereses.Name = "txtIntereses"
        Me.txtIntereses.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIntereses.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIntereses.SelectedText = ""
        Me.txtIntereses.SelectionLength = 0
        Me.txtIntereses.SelectionStart = 0
        Me.txtIntereses.ShortcutsEnabled = True
        Me.txtIntereses.Size = New System.Drawing.Size(188, 20)
        Me.txtIntereses.TabIndex = 41
        Me.txtIntereses.UseSelectable = True
        Me.txtIntereses.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtIntereses.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(15, 290)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel15.TabIndex = 40
        Me.MetroLabel15.Text = "Intereses:"
        '
        'txtSaldoDisponible
        '
        '
        '
        '
        Me.txtSaldoDisponible.CustomButton.Image = Nothing
        Me.txtSaldoDisponible.CustomButton.Location = New System.Drawing.Point(174, 2)
        Me.txtSaldoDisponible.CustomButton.Name = ""
        Me.txtSaldoDisponible.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtSaldoDisponible.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSaldoDisponible.CustomButton.TabIndex = 1
        Me.txtSaldoDisponible.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSaldoDisponible.CustomButton.UseSelectable = True
        Me.txtSaldoDisponible.CustomButton.Visible = False
        Me.txtSaldoDisponible.Enabled = False
        Me.txtSaldoDisponible.Lines = New String(-1) {}
        Me.txtSaldoDisponible.Location = New System.Drawing.Point(467, 265)
        Me.txtSaldoDisponible.MaxLength = 32767
        Me.txtSaldoDisponible.Name = "txtSaldoDisponible"
        Me.txtSaldoDisponible.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSaldoDisponible.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSaldoDisponible.SelectedText = ""
        Me.txtSaldoDisponible.SelectionLength = 0
        Me.txtSaldoDisponible.SelectionStart = 0
        Me.txtSaldoDisponible.ShortcutsEnabled = True
        Me.txtSaldoDisponible.Size = New System.Drawing.Size(192, 20)
        Me.txtSaldoDisponible.TabIndex = 39
        Me.txtSaldoDisponible.UseSelectable = True
        Me.txtSaldoDisponible.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSaldoDisponible.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(349, 262)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel14.TabIndex = 38
        Me.MetroLabel14.Text = "Saldo Disponible:"
        '
        'txtSaldo
        '
        '
        '
        '
        Me.txtSaldo.CustomButton.Image = Nothing
        Me.txtSaldo.CustomButton.Location = New System.Drawing.Point(170, 2)
        Me.txtSaldo.CustomButton.Name = ""
        Me.txtSaldo.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtSaldo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSaldo.CustomButton.TabIndex = 1
        Me.txtSaldo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSaldo.CustomButton.UseSelectable = True
        Me.txtSaldo.CustomButton.Visible = False
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Lines = New String(-1) {}
        Me.txtSaldo.Location = New System.Drawing.Point(142, 265)
        Me.txtSaldo.MaxLength = 32767
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSaldo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSaldo.SelectedText = ""
        Me.txtSaldo.SelectionLength = 0
        Me.txtSaldo.SelectionStart = 0
        Me.txtSaldo.ShortcutsEnabled = True
        Me.txtSaldo.Size = New System.Drawing.Size(188, 20)
        Me.txtSaldo.TabIndex = 37
        Me.txtSaldo.UseSelectable = True
        Me.txtSaldo.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSaldo.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(15, 265)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel13.TabIndex = 36
        Me.MetroLabel13.Text = "Saldo:"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(346, 146)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(120, 19)
        Me.MetroLabel12.TabIndex = 35
        Me.MetroLabel12.Text = "Fecha Cancelación:"
        '
        'dtpFechaCan
        '
        Me.dtpFechaCan.Enabled = False
        Me.dtpFechaCan.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaCan.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaCan.Location = New System.Drawing.Point(492, 146)
        Me.dtpFechaCan.Name = "dtpFechaCan"
        Me.dtpFechaCan.Size = New System.Drawing.Size(166, 20)
        Me.dtpFechaCan.TabIndex = 34
        Me.dtpFechaCan.Value = New Date(2019, 3, 1, 0, 0, 0, 0)
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(504, 383)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 3
        Me.MetroButton1.Text = "Atrás"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(15, 172)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel11.TabIndex = 32
        Me.MetroLabel11.Text = "Préstamo:"
        '
        'btnSiguiente2
        '
        Me.btnSiguiente2.Location = New System.Drawing.Point(584, 383)
        Me.btnSiguiente2.Name = "btnSiguiente2"
        Me.btnSiguiente2.Size = New System.Drawing.Size(75, 28)
        Me.btnSiguiente2.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSiguiente2.TabIndex = 0
        Me.btnSiguiente2.Text = "Siguiente"
        Me.btnSiguiente2.UseSelectable = True
        Me.btnSiguiente2.UseStyleColors = True
        '
        'LblPlazo
        '
        Me.LblPlazo.AutoSize = True
        Me.LblPlazo.Location = New System.Drawing.Point(15, 101)
        Me.LblPlazo.Name = "LblPlazo"
        Me.LblPlazo.Size = New System.Drawing.Size(44, 19)
        Me.LblPlazo.TabIndex = 31
        Me.LblPlazo.Text = "Plazo:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(15, 146)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(121, 19)
        Me.MetroLabel9.TabIndex = 30
        Me.MetroLabel9.Text = "Fecha Vencimiento:"
        '
        'cbSucursal
        '
        Me.cbSucursal.Enabled = False
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.ItemHeight = 23
        Me.cbSucursal.Location = New System.Drawing.Point(142, 233)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(517, 29)
        Me.cbSucursal.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbSucursal.TabIndex = 23
        Me.cbSucursal.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(346, 121)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(117, 19)
        Me.MetroLabel8.TabIndex = 29
        Me.MetroLabel8.Text = "Fecha Renovación:"
        '
        'dtpFecIniApertura
        '
        Me.dtpFecIniApertura.Enabled = False
        Me.dtpFecIniApertura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecIniApertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIniApertura.Location = New System.Drawing.Point(165, 122)
        Me.dtpFecIniApertura.Name = "dtpFecIniApertura"
        Me.dtpFecIniApertura.Size = New System.Drawing.Size(167, 20)
        Me.dtpFecIniApertura.TabIndex = 13
        Me.dtpFecIniApertura.Value = New Date(2019, 3, 1, 0, 0, 0, 0)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(15, 121)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(103, 19)
        Me.MetroLabel7.TabIndex = 28
        Me.MetroLabel7.Text = "Fecha Apertura:"
        Me.MetroLabel7.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BackColor = System.Drawing.Color.White
        Me.txtNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuenta.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuenta.Location = New System.Drawing.Point(142, 47)
        Me.txtNoCuenta.MaxLength = 20
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.ReadOnly = True
        Me.txtNoCuenta.Size = New System.Drawing.Size(191, 22)
        Me.txtNoCuenta.TabIndex = 4
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(346, 75)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(100, 19)
        Me.MetroLabel6.TabIndex = 27
        Me.MetroLabel6.Text = "Código Libreta:"
        '
        'dtpFechaApertura
        '
        Me.dtpFechaApertura.Enabled = False
        Me.dtpFechaApertura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaApertura.Location = New System.Drawing.Point(492, 121)
        Me.dtpFechaApertura.Name = "dtpFechaApertura"
        Me.dtpFechaApertura.Size = New System.Drawing.Size(166, 20)
        Me.dtpFechaApertura.TabIndex = 15
        Me.dtpFechaApertura.Value = New Date(2019, 3, 1, 0, 0, 0, 0)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(15, 75)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(108, 19)
        Me.MetroLabel5.TabIndex = 26
        Me.MetroLabel5.Text = "Monto Apertura:"
        '
        'c1nMontoApertura
        '
        Me.c1nMontoApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoApertura.CustomFormat = "###,###,##0.00"
        Me.c1nMontoApertura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoApertura.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoApertura.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nMontoApertura.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nMontoApertura.Location = New System.Drawing.Point(142, 72)
        Me.c1nMontoApertura.Name = "c1nMontoApertura"
        Me.c1nMontoApertura.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoApertura.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoApertura.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoApertura.Size = New System.Drawing.Size(191, 19)
        Me.c1nMontoApertura.TabIndex = 9
        Me.c1nMontoApertura.Tag = Nothing
        Me.c1nMontoApertura.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoApertura.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(346, 47)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(97, 19)
        Me.MetroLabel4.TabIndex = 25
        Me.MetroLabel4.Text = "Tasa de Interes:"
        '
        'c1nPlazo
        '
        Me.c1nPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nPlazo.CustomFormat = "#0"
        Me.c1nPlazo.DataType = GetType(Short)
        Me.c1nPlazo.Enabled = False
        Me.c1nPlazo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nPlazo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nPlazo.Location = New System.Drawing.Point(143, 96)
        Me.c1nPlazo.MaxLength = 2
        Me.c1nPlazo.Name = "c1nPlazo"
        Me.c1nPlazo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nPlazo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nPlazo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nPlazo.Size = New System.Drawing.Size(190, 18)
        Me.c1nPlazo.TabIndex = 19
        Me.c1nPlazo.Tag = Nothing
        Me.c1nPlazo.Value = CType(0, Short)
        Me.c1nPlazo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(15, 47)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel3.TabIndex = 24
        Me.MetroLabel3.Text = "No. Cuenta"
        '
        'c1nTasa
        '
        Me.c1nTasa.BackColor = System.Drawing.Color.White
        Me.c1nTasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTasa.CustomFormat = "#0.00"
        Me.c1nTasa.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.c1nTasa.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTasa.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nTasa.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nTasa.Location = New System.Drawing.Point(547, 47)
        Me.c1nTasa.Name = "c1nTasa"
        Me.c1nTasa.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTasa.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTasa.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTasa.ReadOnly = True
        Me.c1nTasa.Size = New System.Drawing.Size(111, 19)
        Me.c1nTasa.TabIndex = 6
        Me.c1nTasa.Tag = Nothing
        Me.c1nTasa.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTasa.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtNoLibreta
        '
        Me.txtNoLibreta.AcceptsReturn = True
        Me.txtNoLibreta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoLibreta.Location = New System.Drawing.Point(467, 75)
        Me.txtNoLibreta.MaxLength = 20
        Me.txtNoLibreta.Name = "txtNoLibreta"
        Me.txtNoLibreta.Size = New System.Drawing.Size(191, 20)
        Me.txtNoLibreta.TabIndex = 11
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(15, 233)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel2.TabIndex = 22
        Me.MetroLabel2.Text = "Sucursal:"
        '
        'dtpFecVenc
        '
        Me.dtpFecVenc.Enabled = False
        Me.dtpFecVenc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecVenc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecVenc.Location = New System.Drawing.Point(165, 146)
        Me.dtpFecVenc.Name = "dtpFecVenc"
        Me.dtpFecVenc.Size = New System.Drawing.Size(167, 20)
        Me.dtpFecVenc.TabIndex = 17
        Me.dtpFecVenc.Value = New Date(2019, 3, 1, 0, 0, 0, 0)
        '
        'cbEjecutivo
        '
        Me.cbEjecutivo.FormattingEnabled = True
        Me.cbEjecutivo.ItemHeight = 23
        Me.cbEjecutivo.Location = New System.Drawing.Point(142, 202)
        Me.cbEjecutivo.Name = "cbEjecutivo"
        Me.cbEjecutivo.Size = New System.Drawing.Size(517, 29)
        Me.cbEjecutivo.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbEjecutivo.TabIndex = 21
        Me.cbEjecutivo.UseSelectable = True
        '
        'btTasaPactada
        '
        Me.btTasaPactada.Location = New System.Drawing.Point(468, 47)
        Me.btTasaPactada.Name = "btTasaPactada"
        Me.btTasaPactada.Size = New System.Drawing.Size(75, 22)
        Me.btTasaPactada.Style = MetroFramework.MetroColorStyle.Teal
        Me.btTasaPactada.TabIndex = 7
        Me.btTasaPactada.Text = "Cambiar Tasa"
        Me.btTasaPactada.UseSelectable = True
        Me.btTasaPactada.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(15, 202)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel1.TabIndex = 20
        Me.MetroLabel1.Text = "Ejecutivo:"
        '
        'tbBeneficiarios
        '
        Me.tbBeneficiarios.BackColor = System.Drawing.Color.White
        Me.tbBeneficiarios.Controls.Add(Me.fgAut)
        Me.tbBeneficiarios.Controls.Add(Me.btDel)
        Me.tbBeneficiarios.Controls.Add(Me.MetroLabel22)
        Me.tbBeneficiarios.Controls.Add(Me.btnEditAut)
        Me.tbBeneficiarios.Controls.Add(Me.fgBen)
        Me.tbBeneficiarios.Controls.Add(Me.btNew)
        Me.tbBeneficiarios.Controls.Add(Me.btDelBen)
        Me.tbBeneficiarios.Controls.Add(Me.MetroLabel21)
        Me.tbBeneficiarios.Controls.Add(Me.btEditBen)
        Me.tbBeneficiarios.Controls.Add(Me.btnContrato)
        Me.tbBeneficiarios.Controls.Add(Me.btNewBen)
        Me.tbBeneficiarios.Controls.Add(Me.MetroButton7)
        Me.tbBeneficiarios.Controls.Add(Me.MetroButton8)
        Me.tbBeneficiarios.Location = New System.Drawing.Point(4, 22)
        Me.tbBeneficiarios.Name = "tbBeneficiarios"
        Me.tbBeneficiarios.Size = New System.Drawing.Size(674, 463)
        Me.tbBeneficiarios.TabIndex = 4
        Me.tbBeneficiarios.Text = "Beneficiarios"
        Me.tbBeneficiarios.Visible = False
        '
        'fgAut
        '
        Me.fgAut.AllowEditing = False
        Me.fgAut.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgAut.BackColor = System.Drawing.Color.White
        Me.fgAut.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgAut.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.fgAut.ForeColor = System.Drawing.Color.Black
        Me.fgAut.Location = New System.Drawing.Point(8, 271)
        Me.fgAut.Name = "fgAut"
        Me.fgAut.Rows.Count = 1
        Me.fgAut.Rows.DefaultSize = 19
        Me.fgAut.Size = New System.Drawing.Size(655, 144)
        Me.fgAut.StyleInfo = resources.GetString("fgAut.StyleInfo")
        Me.fgAut.TabIndex = 3
        '
        'btDel
        '
        Me.btDel.Location = New System.Drawing.Point(168, 237)
        Me.btDel.Name = "btDel"
        Me.btDel.Size = New System.Drawing.Size(75, 29)
        Me.btDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDel.TabIndex = 2
        Me.btDel.Text = "Eliminar"
        Me.btDel.UseSelectable = True
        Me.btDel.UseStyleColors = True
        '
        'MetroLabel22
        '
        Me.MetroLabel22.AutoSize = True
        Me.MetroLabel22.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel22.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel22.ForeColor = System.Drawing.Color.Teal
        Me.MetroLabel22.Location = New System.Drawing.Point(8, 213)
        Me.MetroLabel22.Name = "MetroLabel22"
        Me.MetroLabel22.Size = New System.Drawing.Size(342, 25)
        Me.MetroLabel22.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel22.TabIndex = 1028
        Me.MetroLabel22.Text = "Personas Autorizadas Para Realizar Retiros"
        Me.MetroLabel22.UseCustomBackColor = True
        Me.MetroLabel22.UseCustomForeColor = True
        Me.MetroLabel22.UseStyleColors = True
        '
        'btnEditAut
        '
        Me.btnEditAut.Location = New System.Drawing.Point(88, 237)
        Me.btnEditAut.Name = "btnEditAut"
        Me.btnEditAut.Size = New System.Drawing.Size(75, 29)
        Me.btnEditAut.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEditAut.TabIndex = 1
        Me.btnEditAut.Text = "Modificar"
        Me.btnEditAut.UseSelectable = True
        Me.btnEditAut.UseStyleColors = True
        '
        'fgBen
        '
        Me.fgBen.AllowEditing = False
        Me.fgBen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgBen.BackColor = System.Drawing.Color.White
        Me.fgBen.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgBen.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.fgBen.ForeColor = System.Drawing.Color.Black
        Me.fgBen.Location = New System.Drawing.Point(8, 67)
        Me.fgBen.Name = "fgBen"
        Me.fgBen.Rows.Count = 1
        Me.fgBen.Rows.DefaultSize = 19
        Me.fgBen.Size = New System.Drawing.Size(655, 144)
        Me.fgBen.StyleInfo = resources.GetString("fgBen.StyleInfo")
        Me.fgBen.TabIndex = 3
        '
        'btNew
        '
        Me.btNew.Location = New System.Drawing.Point(8, 237)
        Me.btNew.Name = "btNew"
        Me.btNew.Size = New System.Drawing.Size(75, 29)
        Me.btNew.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNew.TabIndex = 0
        Me.btNew.Text = "Nuevo"
        Me.btNew.UseSelectable = True
        Me.btNew.UseStyleColors = True
        '
        'btDelBen
        '
        Me.btDelBen.Location = New System.Drawing.Point(168, 33)
        Me.btDelBen.Name = "btDelBen"
        Me.btDelBen.Size = New System.Drawing.Size(75, 29)
        Me.btDelBen.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelBen.TabIndex = 2
        Me.btDelBen.Text = "Eliminar"
        Me.btDelBen.UseSelectable = True
        Me.btDelBen.UseStyleColors = True
        '
        'MetroLabel21
        '
        Me.MetroLabel21.AutoSize = True
        Me.MetroLabel21.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel21.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel21.ForeColor = System.Drawing.Color.Teal
        Me.MetroLabel21.Location = New System.Drawing.Point(8, 9)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(110, 25)
        Me.MetroLabel21.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel21.TabIndex = 1027
        Me.MetroLabel21.Text = "Beneficiarios"
        Me.MetroLabel21.UseCustomBackColor = True
        Me.MetroLabel21.UseCustomForeColor = True
        Me.MetroLabel21.UseStyleColors = True
        '
        'btEditBen
        '
        Me.btEditBen.Location = New System.Drawing.Point(88, 33)
        Me.btEditBen.Name = "btEditBen"
        Me.btEditBen.Size = New System.Drawing.Size(75, 29)
        Me.btEditBen.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditBen.TabIndex = 1
        Me.btEditBen.Text = "Modificar"
        Me.btEditBen.UseSelectable = True
        Me.btEditBen.UseStyleColors = True
        '
        'btnContrato
        '
        Me.btnContrato.Location = New System.Drawing.Point(428, 420)
        Me.btnContrato.Name = "btnContrato"
        Me.btnContrato.Size = New System.Drawing.Size(75, 29)
        Me.btnContrato.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnContrato.TabIndex = 2
        Me.btnContrato.Text = "Contrato"
        Me.btnContrato.UseSelectable = True
        Me.btnContrato.UseStyleColors = True
        '
        'btNewBen
        '
        Me.btNewBen.Location = New System.Drawing.Point(8, 33)
        Me.btNewBen.Name = "btNewBen"
        Me.btNewBen.Size = New System.Drawing.Size(75, 29)
        Me.btNewBen.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewBen.TabIndex = 0
        Me.btNewBen.Text = "Nuevo"
        Me.btNewBen.UseSelectable = True
        Me.btNewBen.UseStyleColors = True
        '
        'MetroButton7
        '
        Me.MetroButton7.Location = New System.Drawing.Point(508, 420)
        Me.MetroButton7.Name = "MetroButton7"
        Me.MetroButton7.Size = New System.Drawing.Size(75, 29)
        Me.MetroButton7.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton7.TabIndex = 3
        Me.MetroButton7.Text = "Atrás"
        Me.MetroButton7.UseSelectable = True
        Me.MetroButton7.UseStyleColors = True
        '
        'MetroButton8
        '
        Me.MetroButton8.Location = New System.Drawing.Point(588, 420)
        Me.MetroButton8.Name = "MetroButton8"
        Me.MetroButton8.Size = New System.Drawing.Size(75, 29)
        Me.MetroButton8.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton8.TabIndex = 4
        Me.MetroButton8.Text = "Siguiente"
        Me.MetroButton8.UseSelectable = True
        Me.MetroButton8.UseStyleColors = True
        '
        'tbLibRep
        '
        Me.tbLibRep.BackColor = System.Drawing.Color.White
        Me.tbLibRep.Controls.Add(Me.fgR)
        Me.tbLibRep.Controls.Add(Me.btDelR)
        Me.tbLibRep.Controls.Add(Me.MetroButton9)
        Me.tbLibRep.Controls.Add(Me.btEditR)
        Me.tbLibRep.Controls.Add(Me.btNewR)
        Me.tbLibRep.Location = New System.Drawing.Point(4, 22)
        Me.tbLibRep.Name = "tbLibRep"
        Me.tbLibRep.Size = New System.Drawing.Size(674, 463)
        Me.tbLibRep.TabIndex = 8
        Me.tbLibRep.Text = "Control de Reposición de Libretas"
        '
        'fgR
        '
        Me.fgR.AllowEditing = False
        Me.fgR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgR.BackColor = System.Drawing.Color.White
        Me.fgR.ColumnInfo = "10,0,0,0,0,95,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgR.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.fgR.ForeColor = System.Drawing.Color.Black
        Me.fgR.Location = New System.Drawing.Point(10, 59)
        Me.fgR.Name = "fgR"
        Me.fgR.Rows.Count = 1
        Me.fgR.Rows.DefaultSize = 19
        Me.fgR.Size = New System.Drawing.Size(652, 366)
        Me.fgR.StyleInfo = resources.GetString("fgR.StyleInfo")
        Me.fgR.TabIndex = 3
        '
        'btDelR
        '
        Me.btDelR.Location = New System.Drawing.Point(170, 25)
        Me.btDelR.Name = "btDelR"
        Me.btDelR.Size = New System.Drawing.Size(75, 29)
        Me.btDelR.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDelR.TabIndex = 2
        Me.btDelR.Text = "Eliminar"
        Me.btDelR.UseSelectable = True
        Me.btDelR.UseStyleColors = True
        Me.btDelR.Visible = False
        '
        'MetroButton9
        '
        Me.MetroButton9.Location = New System.Drawing.Point(587, 430)
        Me.MetroButton9.Name = "MetroButton9"
        Me.MetroButton9.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton9.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton9.TabIndex = 3
        Me.MetroButton9.Text = "Atrás"
        Me.MetroButton9.UseSelectable = True
        Me.MetroButton9.UseStyleColors = True
        '
        'btEditR
        '
        Me.btEditR.Location = New System.Drawing.Point(90, 25)
        Me.btEditR.Name = "btEditR"
        Me.btEditR.Size = New System.Drawing.Size(75, 29)
        Me.btEditR.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditR.TabIndex = 1
        Me.btEditR.Text = "Modificar"
        Me.btEditR.UseSelectable = True
        Me.btEditR.UseStyleColors = True
        Me.btEditR.Visible = False
        '
        'btNewR
        '
        Me.btNewR.Location = New System.Drawing.Point(10, 25)
        Me.btNewR.Name = "btNewR"
        Me.btNewR.Size = New System.Drawing.Size(75, 29)
        Me.btNewR.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNewR.TabIndex = 0
        Me.btNewR.Text = "Nuevo"
        Me.btNewR.UseSelectable = True
        Me.btNewR.UseStyleColors = True
        '
        'C1nCuota
        '
        Me.C1nCuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1nCuota.CustomFormat = "###,###,##0.00"
        Me.C1nCuota.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1nCuota.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1nCuota.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1nCuota.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1nCuota.Location = New System.Drawing.Point(468, 100)
        Me.C1nCuota.Name = "C1nCuota"
        Me.C1nCuota.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1nCuota.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1nCuota.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1nCuota.Size = New System.Drawing.Size(191, 19)
        Me.C1nCuota.TabIndex = 1031
        Me.C1nCuota.Tag = Nothing
        Me.C1nCuota.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1nCuota.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'frmMsAhCuentas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(727, 562)
        Me.Controls.Add(Me.tbSolic)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhCuentas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cuentas de Ahorro"
        Me.tbSolic.ResumeLayout(False)
        Me.tbDatGral.ResumeLayout(False)
        Me.tbDatGral.PerformLayout()
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.c1nMontoApertura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbBeneficiarios.ResumeLayout(False)
        Me.tbBeneficiarios.PerformLayout()
        CType(Me.fgAut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgBen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbLibRep.ResumeLayout(False)
        CType(Me.fgR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1nCuota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public pNoCuenta As String, pCodTipoAhorro As String, pAccion As String, vTipo As String
    Private vAhorroJunior As Boolean, vAutorizaModificarPlan As Boolean

#Region "Propiedades"

    Public Property AhorroJunior() As Boolean
        Get
            Return vAhorroJunior
        End Get
        Set(ByVal Value As Boolean)
            vAhorroJunior = Value
        End Set
    End Property

#End Region
    Public Sub llenarEstadoCivil()
        Dim dts As New DataSet
        Me.cbEstadoCivil.DisplayMember = "Descripcion"
        Me.cbEstadoCivil.ValueMember = "idCatalogo"
        dts = asociados.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.estadoCivil,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbEstadoCivil.DataSource = dts.Tables(0)
            End If
        End If
    End Sub





#Region "Listas "
    Public Sub llenarTipoAhorro()
        Dim dts As New DataSet
        dts = Ahorro.consultarTiposAhorrosActivos("left(a.codtipoAhorro,1) in ('" & sifLib.Ahorro.clsAhorros.tiposAhorro.vista & "','" & sifLib.Ahorro.clsAhorros.tiposAhorro.restringido & "', '" & sifLib.Ahorro.clsAhorros.tiposAhorro.programado & "')")
        cbTipoAhorro.DataSource = dts.Tables(0)
        cbTipoAhorro.ValueMember = "codTipoAhorro"
        cbTipoAhorro.DisplayMember = "descripcion"
    End Sub
    Protected Sub llenarEjecutivos()
        Try
            Dim dts As New DataSet
            dts = asociados.ConsultarEjecutivosMercadeoxNombre("", sUsuario, sPassword, sSucursal)
            cbEjecutivo.DataSource = dts.Tables(0)
            cbEjecutivo.DisplayMember = "Nombres"
            cbEjecutivo.ValueMember = "CodEjecMercadeo"
        Catch ex As Exception

        End Try
    End Sub
    Protected Sub llenarSucursales()
        Try
            Dim dts As New DataSet
            dts = asociados.ConsultarSucursales("codSucursal,nom_sucursal", "", "nom_sucursal", sUsuario, sPassword, sSucursal)
            Me.cbSucursal.DataSource = dts.Tables(0)
            Me.cbSucursal.DisplayMember = "nom_sucursal"
            Me.cbSucursal.ValueMember = "codSucursal"
        Catch ex As Exception

        End Try
    End Sub
#End Region

    Private Sub frmMsAhCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            llenarTipoAhorro()

            llenarEjecutivos()
            llenarSucursales()

            dtpFechaApertura.Value = Now
            dtpFechaCan.Value = Now
            dtpFecIniApertura.Value = Now
            dtpFecVenc.Value = Now



            vAutorizaModificarPlan = False
            Me.txtDui.Focus()
            ''Me.cbTipoDeposito.SelectedIndex = 0
            ''Me.dtpFecIniDA.Value = Now
            ''Me.dtpFecFinDA.Value = Now
            ''Me.dtpFec1Cuota.Value = Now
            'Me.dtpFechaApertura.Value = Now
            'Me.dtpFecIniApertura.Value = Now
            'Me.dtpFecVenc.Value = Now
            'Me.dtpFecNacT2.Value = Now
            Me.cbDoc.SelectedIndex = 0
            'Me.dtpFec1Cuota.Visible = False
            'Me.c1nMonto.Visible = False
            'Me.c1nCuota.Visible = False
            'Me.Label17.Visible = False
            'Me.Label21.Visible = False
            'Me.Label19.Visible = False
            'Me.nuDNoCuotas.Visible = False
            'Me.Label22.Visible = False
            Me.c1nPlazo.Visible = False
            Me.C1nCuota.Visible = False
            'Me.Label18.Visible = False
            'Me.btnConsPlanAh.Visible = False
            'Me.txtCodPrestamo.Visible = False
            'Me.lblCodPrestamo.Visible = False

            Dim dsTemp As New DataSet, drTemp As DataRow
            dsTemp = asociados.ConsultarParentescos("*", "", "CodParentesco", sUsuario, sPassword, sSucursal)



            cbParentesco.DisplayMember = "Descripcion"
            cbParentesco.ValueMember = "CodParentesco"
            cbParentesco.DataSource = dsTemp.Tables(0)



            Me.cbParentesco.SelectedIndex = 0

            llenarEstadoCivil()
            Dim ds As New DataSet
            Dim filas As DataRowCollection
            Dim dr As DataRow
            If Me.pAccion = "Modificar" Then

                ds = Ahorro.ConsultarCuentaAhorro("*", "NoCuenta='" & pNoCuenta & "' and CodTipoAhorro='" & pCodTipoAhorro & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
                filas = ds.Tables(0).Rows()
                If filas.Count > 0 Then
                    Me.txtDui.Value = IIf(IsDBNull(filas.Item(0)("Dui")), "", filas.Item(0)("Dui"))
                    Me.txtNoCuenta.Text = pNoCuenta

                    txtCodPrestamo.Text = IIf(IsDBNull(filas.Item(0)("CodPrestamo")), "", filas.Item(0)("CodPrestamo"))
                    Me.dtpFechaApertura.Value = IIf(IsDBNull(filas.Item(0)("FechaApertura")), Now, filas.Item(0)("FechaApertura"))
                    Me.dtpFecIniApertura.Value = IIf(IsDBNull(filas.Item(0)("FechaInicioApertura")), Now, filas.Item(0)("FechaInicioApertura"))
                    Me.c1nPlazo.Value = IIf(IsDBNull(filas.Item(0)("FechaVencimiento")), Now, filas.Item(0)("FechaVencimiento"))
                    'Me.dtpFechaCan.Value = IIf(IsDBNull(filas.Item(0)("FechaVencimiento")), Now, filas.Item(0)("FechaVencimiento"))
                    'BUSCAR LOS DATOS QUE FALTAN PARA LAS CUENTAS DE AHORRO PROGRAMADOS'
                    cbTipoAhorro.SelectedValue = pCodTipoAhorro
                    txtSaldo.Text = Math.Round(IIf(IsDBNull(filas.Item(0)("Saldo_CuentaAhorro")), "", filas.Item(0)("Saldo_CuentaAhorro")), 2)
                    txtSaldoDisponible.Text = Math.Round(IIf(IsDBNull(filas.Item(0)("SaldoDisponible_CuentaAhorro")), 0, filas.Item(0)("SaldoDisponible_CuentaAhorro")), 2)
                    txtIntereses.Text = Math.Round(IIf(IsDBNull(filas.Item(0)("SaldoInteresPendiente")), 0, filas.Item(0)("SaldoInteresPendiente")), 2)
                    cbSucursal.SelectedValue = IIf(IsDBNull(filas.Item(0)("codSucursal")), "01", filas.Item(0)("codSucursal"))
                    '==================================================
                    '==================================================
                    Select Case Mid(Me.cbTipoAhorro.SelectedValue.Trim, 1, 1)
                        Case "3" 'Ahorro a la Vista
                            Me.vTipo = "Vista"
                        Case "5" 'Ahorro Restringido
                            Me.vTipo = "Rest"
                        Case "4" 'Ahorro Programado
                            Me.vTipo = "Prog"

                    End Select

                    txtEstado.Text = IIf(IsDBNull(filas.Item(0)("Estado")), "", filas.Item(0)("Estado"))
                    If txtEstado.Text = "C" Then
                        Me.txtEstado.Text = "CANCELADA"

                    End If


                    c1nMontoApertura.Value = IIf(IsDBNull(filas.Item(0)("MontoApertura")), 0, filas.Item(0)("MontoApertura"))
                    Me.c1nPlazo.Visible = True
                    Me.c1nPlazo.Value = IIf(IsDBNull(filas.Item(0)("Plazo")), 0, filas.Item(0)("Plazo"))
                    Me.c1nPlazo.Enabled = True
                    Me.C1nCuota.Visible = True
                    Me.C1nCuota.Value = IIf(IsDBNull(filas.Item(0)("Cuota")), 0, filas.Item(0)("Cuota"))
                    Me.C1nCuota.Enabled = True

                    Me.c1nTasa.Value = IIf(IsDBNull(filas.Item(0)("TasaInteres")), 0, filas.Item(0)("TasaInteres"))

                    Me.dtpFecIniApertura.Value = IIf(IsDBNull(filas.Item(0)("FechaInicioApertura")), Now, filas.Item(0)("FechaInicioApertura"))

                    Me.cbDoc.SelectedIndex = IIf(IsDBNull(filas.Item(0)("TipoDocTit2")), 0, filas.Item(0)("TipoDocTit2"))
                    Me.txtTitular2.Text = IIf(IsDBNull(filas.Item(0)("Titular2")), "", filas.Item(0)("Titular2"))
                    Me.txtTitular2.ReadOnly = True
                    Me.txtPartida.Text = IIf(IsDBNull(filas.Item(0)("PartidaNacTitular2")), "", filas.Item(0)("PartidaNacTitular2").trim)
                    Me.txtNoLibreta.Text = IIf(IsDBNull(filas.Item(0)("NoLibreta")), "", filas.Item(0)("NoLibreta"))
                    Me.cbEjecutivo.SelectedValue = IIf(IsDBNull(filas.Item(0)("CodEjecutivo")), "", filas.Item(0)("CodEjecutivo"))

                    dtpFecVenc.Value = IIf(IsDBNull(filas.Item(0)("FechaVencimiento")), Now, filas.Item(0)("FechaVencimiento"))

                    Me.dtpFechaCan.Value = IIf(IsDBNull(filas.Item(0)("FechaCancelacion")), Now, filas.Item(0)("FechaCancelacion"))
                    Me.txtObservaciones.Text = IIf(IsDBNull(filas.Item(0)("Observacion")), "", filas.Item(0)("Observacion"))
                    Me.dtpFecNacT2.Value = IIf(IsDBNull(filas.Item(0)("FechaNacTit2")), Now, filas.Item(0)("FechaNacTit2"))


                    Me.dtpFechaApertura.Enabled = False


                    If filas.Item(0)("CodParentesco") Is DBNull.Value = False Then
                        Me.cbParentesco.SelectedValue = filas.Item(0)("CodParentesco")
                    End If

                    ds = Ahorro.ConsultarBeneficiarios("*", " NoCuenta='" & Trim(txtNoCuenta.Text) & "' and CodTipoAhorro='" & Trim(Me.cbTipoAhorro.SelectedValue) & "'", "Correlativo", sUsuario, sPassword, sSucursal)
                    Me.fgBen.DataSource = ds.Tables(0)
                    ActualizaGridBen()

                    ds = Ahorro.ConsultarAutorizadoRetiro("*", "NoCuenta='" & Trim(txtNoCuenta.Text) & "' and CodTipoAhorro='" & Trim(cbTipoAhorro.SelectedValue) & "'", "Correlativo", sUsuario, sPassword, sSucursal)
                    Me.fgAut.DataSource = ds.Tables(0)
                    ActualizaGridAut()

                    ds = Ahorro.ConsultarReposicionLibreta("*", "NoCuenta='" & Trim(txtNoCuenta.Text) & "' and CodTipoAhorro='" & Trim(cbTipoAhorro.SelectedValue) & "'", "NoSolicitud", sUsuario, sPassword, sSucursal)
                    Me.fgR.DataSource = ds.Tables(0)
                    ActualizaGridR()

                    Dim pCodProf As String
                    ds = asociados.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,Fecha_Nac,CodProfesion,codEstadoCivil,Direccion,nosocio", "Dui='" & txtDui.Text.Trim & "' and EstadoIngreso in ('2','1') ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    filas = ds.Tables(0).Rows()
                    If filas.Count > 0 Then


                        txtNombres.Text = IIf((filas.Item(0)("Nombres")) Is DBNull.Value, "", CStr(filas.Item(0)("Nombres")))
                        txtApe1.Text = IIf((filas.Item(0)("Apellido1")) Is DBNull.Value, "", CStr(filas.Item(0)("Apellido1")).Trim)
                        txtApe2.Text = IIf((filas.Item(0)("Apellido2")) Is DBNull.Value, "", CStr(filas.Item(0)("Apellido2")))
                        txtApe3.Text = IIf((filas.Item(0)("ApellidoCas")) Is DBNull.Value, "", filas.Item(0)("ApellidoCas"))
                        direccionAsociado(txtDui.Value)

                        If filas.Item(0)("codEstadoCivil") Is DBNull.Value = False Then
                            cbEstadoCivil.SelectedValue = filas.Item(0)("codEstadoCivil")
                        End If

                        dtpFecNac.Value = IIf((filas.Item(0)("Fecha_Nac")) Is DBNull.Value, Now, filas.Item(0)("Fecha_Nac"))
                        txtNoSocio.Text = IIf((filas.Item(0)("NoSocio")) Is DBNull.Value, " ", filas.Item(0)("NoSocio"))


                    End If



                    If txtEstado.Text = "A" Then
                        Me.c1nMontoApertura.Enabled = False
                        Me.c1nPlazo.Enabled = False
                        Me.C1nCuota.Enabled = False

                    End If


                End If
                Me.dtpFechaApertura.Enabled = False
                Me.txtDui.Enabled = False
                Me.txtNombres.Enabled = False
                Me.txtApe1.Enabled = False
                Me.txtApe2.Enabled = False
                cbTipoAhorro.Enabled = False
                Me.txtNoLibreta.Enabled = False
                Me.txtNoCuenta.Enabled = False

                Me.btNew.Enabled = True
                Me.btNewR.Enabled = True
                Me.dtpFechaApertura.Focus()


                '=========================================================================
                '18/04/2012 Javier Escobar
                'Deshabilitamos el control para que no puedan modificar al ejecutivo
                Me.cbEjecutivo.Enabled = False

                '=========================================================================
            Else
                Me.btNewBen.Enabled = False
                Me.btNew.Enabled = False
                Me.btNewR.Enabled = False
                Me.tbLibRep.Enabled = False
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

        End Try

    End Sub





    Private Sub ActualizaGridBen()

        Dim oAh As wrAhorro.wsLibAhorro, ds As Data.DataSet = New Data.DataSet
        Try
            oAh = New wrAhorro.wsLibAhorro
            ds = oAh.ConsultarBeneficiarios("Correlativo,CONCAT(nombres,' ',Apellido1,' ',Apellido2,' ',ApellidoCas)[NombreBeneficiario],Porcentaje", "NoCuenta='" & pNoCuenta & "' and CodTipoAhorro='" & pCodTipoAhorro & "'", "Correlativo", sUsuario, sPassword, sSucursal)

            Me.fgBen.DataSource = ds.Tables(0)
            Me.fgBen.Cols.Item(0).Caption = "Correlativo"
            Me.fgBen.Cols.Item(1).Caption = "Beneficiario"
            Me.fgBen.Cols.Item(2).Caption = "Porcentaje"

            Me.fgBen.Cols.Item(0).Visible = False

            Me.fgBen.Cols.Item(0).Width = 77
            Me.fgBen.Cols.Item(1).Width = 300
            Me.fgBen.Cols.Item(2).Width = 150


            If Me.fgBen.Row <> -1 Then
                Me.btEditBen.Enabled = True
                ' If btnSaveTb1.Visible = True Then Me.btDelBen.Enabled = True
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub






    Private Sub ActualizaGridAut()

        Dim oAh As wrAhorro.wsLibAhorro, ds As Data.DataSet = New Data.DataSet
        Try
            oAh = New wrAhorro.wsLibAhorro
            ds = oAh.ConsultarAutorizadoRetiro("correlativo,Nombre", "NoCuenta='" & pNoCuenta & "' and CodTipoAhorro='" & pCodTipoAhorro & "'", "Nombre", sUsuario, sPassword, sSucursal)

            Me.fgAut.DataSource = ds.Tables(0)
            Me.fgAut.Cols.Item(1).Caption = "Persona Autorizada"
            Me.fgAut.Cols.Item(0).Visible = False
            Me.fgAut.Cols.Item(1).Width = 600


            If Me.fgAut.Row <> -1 Then
                Me.btDel.Enabled = True
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub ActualizaGridR()

        Dim oAh As wrAhorro.wsLibAhorro, ds As Data.DataSet = New Data.DataSet
        Try
            oAh = New wrAhorro.wsLibAhorro
            ds = oAh.ConsultarReposicionLibreta("NoSolicitud,NoLibretaRepone,NoLibreta,Fecha,Observacion,Usuario", "NoCuenta='" & pNoCuenta & "' and CodTipoAhorro='" & pCodTipoAhorro & "'", "NoSolicitud", sUsuario, sPassword, sSucursal)

            Me.fgR.DataSource = ds.Tables(0)
            Me.fgR.Cols.Item(0).Caption = "Solicitud"
            Me.fgR.Cols.Item(1).Caption = "No. Libreta Anterior"
            Me.fgR.Cols.Item(2).Caption = "Nuevo No. de Libreta"
            Me.fgR.Cols.Item(3).Caption = "Fecha"
            Me.fgR.Cols.Item(4).Caption = "Observación"
            Me.fgR.Cols.Item(5).Caption = "Responsable Cambio Libreta"


            Me.fgR.Cols.Item(0).Width = 50
            Me.fgR.Cols.Item(0).Visible = False
            Me.fgR.Cols.Item(1).Width = 200
            Me.fgR.Cols.Item(2).Width = 200
            Me.fgR.Cols.Item(3).Width = 100
            Me.fgR.Cols.Item(4).Width = 200
            Me.fgR.Cols.Item(5).Width = 200


            If Me.fgR.Row <> -1 Then
                Me.btEditR.Enabled = True
                Me.btDelR.Enabled = True
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub fgR_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgR.DoubleClick
        MetroButton12_Click(sender, e)
    End Sub


    Public Sub direccionAsociado(dui As String)
        Dim dts As New DataSet
        dts = asociados.ConsultarDomicilios(dui)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                For Each row As DataRow In dts.Tables(0).Rows
                    If row("Estado").Equals(True) Then
                        txtDireccion.Text = row("Direccion").ToString
                    End If
                Next
            End If
        End If
    End Sub
    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Try
            Dim ofrm As New frmAGenerico

            ofrm.Text = "Buscar Asociados"
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection, pCodProf As String
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2", " EstadoIngreso in ('2','1') and EstadoAsociado='25' ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtDui.Text = ofrm.Resultado.Trim

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        Dim pCodProf As String
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,codEstadoCivil,Direccion,NoSocio,TelCasa,TelOficina,Celular", "Dui='" & txtDui.Text.Trim & "' and EstadoIngreso in ('2','1') and EstadoAsociado='25'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtDui.Value = IIf(CStr(Filas.Item(0)("DUI")).Trim Is DBNull.Value, "", Filas.Item(0)("DUI").ToString.Trim)

                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub









    Private Sub cbDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDoc.SelectedIndexChanged
        If cbDoc.SelectedIndex = 0 Then
            Me.txtPartida.EditMask = "00000000-0"
        ElseIf cbDoc.SelectedIndex = 1 Or cbDoc.SelectedIndex = 2 Then
            Me.txtPartida.EditMask = "0000-000000-000-0"
        Else
            Me.txtPartida.EditMask = ""
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




    Private Function pCalculaFechaVencimiento(ByVal pFechaApertura As Date, ByVal pPlazo As Integer, ByVal pTipoPlazo As String) As Date
        Dim nDias As Integer, nAnios As Integer, x As Integer, pFechaVencimiento As Date
        If pTipoPlazo = "d" Then
            pFechaVencimiento = pFechaApertura.AddDays(pPlazo)
        ElseIf pTipoPlazo = "m" Then
            pFechaVencimiento = pFechaApertura.AddMonths(pPlazo)
        End If

        If DateTime.IsLeapYear(pFechaApertura.Year) = True Then 'Bisiesto
            If pFechaApertura.Month > 2 Then nDias = nDias + 1
        End If
        nAnios = DateDiff(DateInterval.Year, pFechaApertura, pFechaVencimiento)
        For x = 1 To nAnios
            If x = nAnios Then
                If DateTime.IsLeapYear(pFechaVencimiento.Year) = True Then
                    If pFechaVencimiento.Month > 2 Then nDias = nDias + 1
                End If
            Else
                If DateTime.IsLeapYear(pFechaApertura.Year + 1) = True Then
                    nDias = nDias + 1
                End If
            End If
        Next
        Return pFechaVencimiento.AddDays(nDias)
    End Function


    Private Sub btnSiguiente2_Click(sender As Object, e As EventArgs) Handles btnSiguiente2.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles btTasaPactada.Click
        Try
            Dim ofrmAut As New frmMsAutorizacion
            ofrmAut.TipoPermiso = "P"
            ofrmAut.NumPrograma = "AHC002"
            ofrmAut.ShowDialog()
            If ofrmAut.Autoriza = True Then
                Me.c1nTasa.ReadOnly = False
                Me.c1nTasa.Focus()
                ofrmAut.Autoriza = False
                ofrmAut.Dispose()
            Else
                ofrmAut.Dispose()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub MetroButton2_Click_2(sender As Object, e As EventArgs)
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs)
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub



    Private Sub MetroButton6_Click(sender As Object, e As EventArgs) Handles btnContrato.Click
        Try
            If txtNoCuenta.ToString.Trim = "" Then
                MetroFramework.MetroMessageBox.Show(Me, "No hay una cuenta seleccionada, Favor Verifique.", "Ahorros", MessageBoxButtons.OK, MessageBoxIcon.Hand)

                Exit Sub
            End If
            Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
            ds = oAh.RptContratoAhorros(txtNoCuenta.Text)
            Dim Tipoahoprog As String = Strings.Mid(Me.txtNoCuenta.Text, 8, 3)
            If Tipoahoprog = "510" Then
                Dim ofrm As New frmVisor(ds, 224, 0)
                ofrm.ShowDialog()
            Else
                If Tipoahoprog = "310" Then
                    Dim ofrm As New frmVisor(ds, 225, 0)
                    ofrm.ShowDialog()
                Else
                    Dim ofrm As New frmVisor(ds, 220, 0)
                    ofrm.ShowDialog()
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub MetroButton7_Click(sender As Object, e As EventArgs) Handles MetroButton7.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton8_Click(sender As Object, e As EventArgs) Handles MetroButton8.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub


    Private Sub MetroButton9_Click(sender As Object, e As EventArgs) Handles MetroButton9.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex - 1
    End Sub

    Private Sub MetroButton5_Click_1(sender As Object, e As EventArgs) Handles btNewBen.Click
        Try
            Dim frm As frmMsAhBeneficiarios = New frmMsAhBeneficiarios
            frm.pNoCuenta = Me.pNoCuenta
            frm.pCodTipoAhorro = Me.pCodTipoAhorro
            frm.pAccion = "Guardar"
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridBen()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton6_Click_1(sender As Object, e As EventArgs) Handles btEditBen.Click
        Try

            If Me.fgBen.Row <> -1 Then
                Dim frm As frmMsAhBeneficiarios = New frmMsAhBeneficiarios
                frm.pNoCuenta = Me.pNoCuenta

                frm.pCodTipoAhorro = Me.pCodTipoAhorro
                frm.pCorrelativo = Me.fgBen.Item(Me.fgBen.Row, "Correlativo")
                frm.pAccion = "Modificar"

                frm.btnGuardar1.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridBen()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton10_Click_1(sender As Object, e As EventArgs) Handles btDelBen.Click
        Try
            If Me.fgBen.Row <> -1 Then
                If MetroFramework.MetroMessageBox.Show(Me, "¿Desea eliminar el Beneficiario No. " & Me.fgBen.Item(Me.fgBen.Row, "Correlativo") & "?", "Ahorros", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then


                    Dim oAh As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
                    oAh.EliminarBeneficiarios("Correlativo=" & Me.fgBen.Item(Me.fgBen.Row, "Correlativo") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGridBen()
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton13_Click(sender As Object, e As EventArgs) Handles btNew.Click
        Try
            Dim frm As frmMsAhAutorizaRetiro = New frmMsAhAutorizaRetiro
            frm.pNoCuenta = Me.pNoCuenta
            frm.pCodTipoAhorro = Me.pCodTipoAhorro
            frm.pAccion = "Guardar"
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridAut()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton12_Click(sender As Object, e As EventArgs) Handles btnEditAut.Click
        Try
            If Me.fgAut.Row <> -1 Then
                Dim ofrmAut As New frmMsAutorizacion
                ofrmAut.TipoPermiso = "P"
                ofrmAut.NumPrograma = "AHO001"
                ofrmAut.ShowDialog()
                If ofrmAut.Autoriza = True Then
                    Dim frm As frmMsAhAutorizaRetiro = New frmMsAhAutorizaRetiro
                    frm.pUsuario = ofrmAut.Usuario
                    frm.pPassword = ofrmAut.Password
                    frm.pNoCuenta = Me.pNoCuenta
                    frm.pCodTipoAhorro = Me.pCodTipoAhorro
                    frm.pCorrelativo = Me.fgAut.Item(Me.fgAut.Row, "Correlativo")
                    frm.pAccion = "Modificar"
                    frm.btnGuardar1.Text = "&Modificar"
                    frm.StartPosition = FormStartPosition.CenterScreen
                    frm.ShowDialog()
                    ActualizaGridAut()
                    ofrmAut.Autoriza = False
                    ofrmAut.Dispose()
                Else
                    ofrmAut.Dispose()
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton11_Click(sender As Object, e As EventArgs) Handles btDel.Click
        Try
            If Me.fgAut.Row <> -1 Then
                If MetroFramework.MetroMessageBox.Show(Me, "¿Desea eliminar el registro No. " & Me.fgAut.Item(Me.fgAut.Row, "Correlativo") & "?", "Ahorros", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim oAh As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
                    oAh.EliminarAutorizadoRetiro(Me.fgAut.Item(Me.fgAut.Row, "Correlativo"), sUsuario, sPassword, sSucursal)
                    ActualizaGridAut()
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton16_Click(sender As Object, e As EventArgs) Handles btNewR.Click
        Try
            Dim frm As frmMsAhRepLibreta = New frmMsAhRepLibreta
            frm.pNoLibreta = Me.txtNoLibreta.Text
            frm.pNoCuenta = Me.pNoCuenta
            frm.pCodTipoAhorro = Me.pCodTipoAhorro
            frm.pAccion = "Guardar"
            frm.btnGuardar.Text = "&Guardar"
            frm.ShowDialog()
            ActualizaGridR()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton15_Click(sender As Object, e As EventArgs) Handles btEditR.Click
        Try

            If Me.fgR.Row <> -1 Then
                Dim frm As frmMsAhRepLibreta = New frmMsAhRepLibreta
                frm.pNoCuenta = Me.pNoCuenta
                frm.pCodTipoAhorro = Me.pCodTipoAhorro
                frm.pNoLibreta = Me.txtNoLibreta.Text
                frm.pCorrelativo = Me.fgR.Item(Me.fgR.Row, "NoSolicitud")
                frm.pAccion = "Modificar"
                frm.btnGuardar.Text = "&Modificar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridR()
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSaveTb3_Click(sender As Object, e As EventArgs) Handles btnSaveTb3.Click
        Try
            Me.cbEjecutivo_DropDownClosed(sender, e)
            'cbTipoAhorro_Validated(sender, e)

            If MetroFramework.MetroMessageBox.Show(Me, "Continuar con el ingreso/actualización de la cuenta No: " & txtNoCuenta.Text.Trim, "Ahorros", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Dim oCred As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, pCampos As String, pValores As String
                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection, pPignorado As String, dr As DataRow, CobroDomicilio As String

                Select Case oCred.AutorizaDatos(txtDui.Text, "x", txtNoCuenta.Text, Me.txtNoLibreta.Text, cbTipoAhorro.SelectedValue)
                    Case 1
                        MetroFramework.MetroMessageBox.Show(Me, "Por favor ingresar DUI", "Ahorros", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                        Exit Sub
                    Case 3
                        MetroFramework.MetroMessageBox.Show(Me, "No existe No. de cuenta", "Ahorros", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                        Exit Sub

                    Case 5
                        MetroFramework.MetroMessageBox.Show(Me, "Seleccione tipo de ahorro.", "Ahorros", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                        Exit Sub
                End Select

                If Me.c1nMontoApertura.Value <= 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, "Monto de apertura debe ser mayor a cero.", "Ahorros", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                    Exit Sub
                End If

                If Me.c1nTasa.Value <= 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, "Tasa de interes debe ser mayor que cero", "Ahorros", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                    Exit Sub
                End If

                If AhorroJunior = True Then
                    If Me.txtTitular2.Text.Trim = "" Then
                        MsgBox("Debe ingresar el Titular 2.", MsgBoxStyle.Critical, "Módulo Ahorros")
                        Exit Sub
                    End If

                    Dim FechaNacTit2 As Date, pEdad As Integer
                    FechaNacTit2 = dtpFecNacT2.Value.Day & "/" & dtpFecNacT2.Value.Month & "/" & Now().Year

                    pEdad = CInt(IIf(DateDiff(DateInterval.Day, FechaNacTit2, Now()) < 0, "-1", "0") + DateDiff(DateInterval.Year, dtpFecNacT2.Value, Now()))
                    If pEdad >= 18 Then
                        MsgBox("El niño tiene más de 18 años.", MsgBoxStyle.Critical, "Módulo Ahorros")
                        Exit Sub
                    End If

                End If
                ds = oCred.ConsultarParametros("*", "CodTipoAhorro='" & cbTipoAhorro.SelectedValue & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables("AhParametros").Rows
                If Filas.Count > 0 Then
                    dr = ds.Tables("AhParametros").Rows(0)
                    If Val(c1nMontoApertura.Value) < Val(dr("MontoAperturaMinima")) And (CDate(Me.dtpFechaApertura.Value.ToShortDateString) >= dr("ValidoDesdeMin") And CDate(Me.dtpFechaApertura.Value.ToShortDateString) <= dr("ValidoHastaMin")) Then
                        MetroFramework.MetroMessageBox.Show(Me, "Monto de apertura inferior a monto de apertura minima", "Ahorros", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    If Val(c1nMontoApertura.Value) > Val(dr("MontoAperturaMaxima")) And (CDate(Me.dtpFechaApertura.Value.ToShortDateString) >= dr("ValidoDesdeMax") And CDate(Me.dtpFechaApertura.Value.ToShortDateString) <= dr("ValidoHastaMax")) Then
                        MetroFramework.MetroMessageBox.Show(Me, "Monto de apertura mayor al monto de apertura maximo.", "Ahorros", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                        Exit Sub
                    End If

                End If

                ds = oAsoc.ConsultarAsociado("*", "Dui='" & Trim(Me.txtDui.Text) & "' and EstadoAsociado='25' and EstadoIngreso in ('2','1') ", "DUI", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                Else
                    MetroFramework.MetroMessageBox.Show(Me, "El Dui del Asociado no coincide con el Maestro de Asociados. Verifique e intente de nuevo.", "Ahorros", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                    Exit Sub
                End If


                If Me.btnSaveTb3.Text = "Guardar" Then
                    '========================================================================================================================================
                    'Valida #Cuenta
                    Me.txtNoCuenta.Text = Ahorro.generarNoCuentaTipoAhorro(txtDui.Value.Trim, cbTipoAhorro.SelectedValue, sUsuario, sPassword, sSucursal)
                    digitoVerificador = Ahorro.ObtieneDigitoVerificador(Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
                    If digitoVerificador >= 10 Then
                        digitoVerificador = 9
                    End If
                    '========================================================================================================================================
                    pPignorado = "N"
                    pCampos = "Dui,CodTipoAhorro,NoCuenta,CodPrestamo,Titular2,PartidaNacTitular2,NoLibreta,FechaInicioApertura,FechaApertura,FechaVencimiento,FechaPrimeraCuota,MontoApertura,Plazo,Cuota,Monto,NoCuotas,CodDestino,TasaInteres,CodEjecutivo,Saldo_CuentaAhorro,SaldoDisponible_CuentaAhorro,NoCuotasPagadas,SaldoInteresPendiente,Estado,Observacion,Pignorado,CobroDomicilio,TipoDocTit2,FechaNacTit2,FechaCancelacion,CodParentesco,NoSocio,Digito,CodEjecApertura"
                    pValores = "'" & Trim(Me.txtDui.Text) &
                        "','" & Trim(Me.cbTipoAhorro.SelectedValue) &
                        "','" & Trim(Me.txtNoCuenta.Text) &
                        "','" & Trim(txtCodPrestamo.Text) &
                        "','" & Trim(Me.txtTitular2.Text) &
                        "','" & Trim(Me.txtPartida.Text) &
                        "','" & Trim(Me.txtNoLibreta.Text) &
                        "','" & Format(Me.dtpFecIniApertura.Value, "dd/MM/yyyy") &
                        "','" & Format(Me.dtpFechaApertura.Value, "dd/MM/yyyy") &
                        "','" & Format(Me.dtpFecVenc.Value, "dd/MM/yyyy") &
                        "','" & Now &
                        "'," & (Me.c1nMontoApertura.Value) &
                        "," & (Me.c1nPlazo.Value) &
                        "," & (Me.C1nCuota.Value) &
                        "," & (Me.c1nMontoApertura.Value) &
                        "," & (0) &
                        ",'" & ("") &
                        "'," & Me.c1nTasa.Value &
                        ",'" & Trim(cbEjecutivo.SelectedValue) &
                        "',0,0,0,0,'D','" &
                        Trim(Me.txtObservaciones.Text) &
                        "','" & pPignorado &
                        "','" & CobroDomicilio &
                        "','" & Me.cbDoc.SelectedIndex &
                        "','" & Format(Me.dtpFecNacT2.Value, "dd/MM/yyyy") &
                        "','" & Format(Me.dtpFechaCan.Value, "dd/MM/yyyy") &
                        "','" & Me.cbParentesco.SelectedValue & 'Text.Substring(0, 5).Trim &
                        "','" & Me.txtNoSocio.Text.Trim &
                        "','" & Me.digitoVerificador &
                        "','" & Me.cbEjecutivo.SelectedValue & "'"
                    If oCred.InsertarCuentaAhorro(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                        Me.txtDui.Enabled = False
                        Me.txtNombres.Enabled = False
                        Me.txtApe1.Enabled = False
                        Me.txtApe2.Enabled = False
                        cbTipoAhorro.Enabled = False
                        Me.txtNoCuenta.Enabled = False
                        Me.btNewBen.Enabled = True
                        Me.btNew.Enabled = True
                        btnSaveTb3.Text = "&Modificar"

                        Me.pCodTipoAhorro = Trim(Me.cbTipoAhorro.SelectedValue)
                        Me.pNoCuenta = Trim(Me.txtNoCuenta.Text)

                        Me.tbLibRep.Enabled = True

                        MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                ElseIf btnSaveTb3.Text = "&Modificar" Then
                    pCampos = "Titular2='" & Trim(Me.txtTitular2.Text) & "',PartidaNacTitular2='" & Trim(Me.txtPartida.Text) &
                "',NoLibreta='" & Trim(Me.txtNoLibreta.Text) & "',FechaInicioApertura='" & Format(Me.dtpFecIniApertura.Value, "dd/MM/yyyy") &
                "',FechaApertura='" & Format(Me.dtpFechaApertura.Value, "dd/MM/yyyy") & "',FechaVencimiento='" & Format(Me.dtpFecVenc.Value, "dd/MM/yyyy") &
                "',FechaCancelacion='" & Format(Me.dtpFechaCan.Value, "dd/MM/yyyy") &
                "',FechaPrimeraCuota='" & Format(Now, "dd/MM/yyyy") & "',MontoApertura=" & Me.c1nMontoApertura.Value &
                ",Plazo=" & c1nPlazo.Value & ",Monto=" & Me.c1nMontoApertura.Value & ",Cuota=" & C1nCuota.Value &
                ",NoCuotas=" & (0) & ",CodDestino='" & ("") & "',TasaInteres=" & (Me.c1nTasa.Value) &
                ",CodEjecutivo='" & cbEjecutivo.SelectedValue & "',Observacion='" & Trim(Me.txtObservaciones.Text) &
                "',TipoDocTit2='" & Me.cbDoc.SelectedIndex & "',FechaNacTit2='" & Format(Me.dtpFecNacT2.Value, "dd/MM/yyyy") &
                "',CodParentesco='" & Me.cbParentesco.SelectedValue &
                "',CodEjecApertura='" & cbEjecutivo.SelectedValue &
                "',codprestamo = '" & txtCodPrestamo.Text & "' "
                    If Ahorro.ModificarCuentaAhorro(pNoCuenta, pCodTipoAhorro, pCampos, sUsuario, sPassword, sSucursal) = True Then
                        MetroFramework.MetroMessageBox.Show(Me, mensajeUpdateRegistro, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Dispose()
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                    End If

                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub MetroButton14_Click(sender As Object, e As EventArgs) Handles btDelR.Click
        Try
            If Me.fgR.Row <> -1 Then
                If MetroFramework.MetroMessageBox.Show(Me, "¿Desea eliminar la Solicitud No. " & Me.fgR.Item(Me.fgR.Row, "NoSolicitud") & "?", "Ahorros", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                    Dim oAh As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
                    oAh.EliminarReposicionLibreta(Me.fgR.Item(Me.fgR.Row, "NoSolicitud"), sUsuario, sPassword, sSucursal)
                    ActualizaGridR()
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

        End Try
    End Sub
    Private Sub MetroButton5_Click_2(sender As Object, e As EventArgs) Handles MetroButton5.Click
        Dim frm As New frmIngresoAsoc2
        With frm
            .txtDui.Text = Me.txtDui.Value
            .accion = 2
            .Show()
        End With
    End Sub
    Dim digitoVerificador As String
    Private Sub txtDui_Validated(sender As Object, e As EventArgs) Handles txtDui.Validated
        Try

            If Me.pAccion <> "Modificar" Then
                Dim ds As New DataSet
                Dim Filas As DataRowCollection
                Dim pCodProf As String
                ds = asociados.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,LugarExtDUI,FechaExtDUI,Fecha_Nac,CodProfesion,codEstadoCivil,Direccion,telCasa,celular,nosocio", " Dui='" & txtDui.Value & "' and EstadoIngreso in ('2','1') ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNombres.Text = IIf((Filas.Item(0)("Nombres")) Is DBNull.Value, "", CStr(Filas.Item(0)("Nombres")))
                    txtApe1.Text = IIf((Filas.Item(0)("Apellido1")) Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido1")).Trim)
                    txtApe2.Text = IIf((Filas.Item(0)("Apellido2")) Is DBNull.Value, "", CStr(Filas.Item(0)("Apellido2")))
                    txtApe3.Text = IIf((Filas.Item(0)("ApellidoCas")) Is DBNull.Value, "", Filas.Item(0)("ApellidoCas"))
                    direccionAsociado(txtDui.Text)
                    'txtDireccion.Text = IIf(CStr(Filas.Item(0)("Direccion")).Trim Is DBNull.Value, "", Filas.Item(0)("Direccion"))
                    If Filas.Item(0)("codEstadoCivil") Is DBNull.Value = False Then
                        cbEstadoCivil.SelectedValue = Filas.Item(0)("codEstadoCivil")
                    End If
                    dtpFecNac.Value = IIf((Filas.Item(0)("Fecha_Nac")) Is DBNull.Value, Now, Filas.Item(0)("Fecha_Nac"))
                    Me.txtNoSocio.Text = IIf(CStr(Filas.Item(0)("NoSocio")) Is DBNull.Value, " ", Filas.Item(0)("NoSocio"))
                End If
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Siguiente_Click(sender As Object, e As EventArgs) Handles Siguiente.Click
        Me.tbSolic.SelectedIndex = Me.tbSolic.SelectedIndex + 1
    End Sub

    Private Sub txtCodPrestamo_DoubleClick(sender As Object, e As EventArgs) Handles txtCodPrestamo.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Préstamos"

        Dim ds As New DataSet

        ds = Prestamos.ConsultarDatosPrestamos(Me.txtDui.Text.Trim, " ", 1)
        ofrm.Datos = ds
        ofrm.ColSeleccion = 0
        ofrm.RefrescarGrid()
        ofrm.ShowDialog()
        txtCodPrestamo.Text = ofrm.Resultado.Trim
    End Sub

    Private Sub c1nPlazo_TextChanged(sender As Object, e As EventArgs) Handles c1nPlazo.TextChanged

    End Sub

    Private Sub cbTipoAhorro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoAhorro.SelectedIndexChanged

    End Sub

    Private Sub txtCodPrestamo_Click(sender As Object, e As EventArgs) Handles txtCodPrestamo.Click
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Préstamos"

        Dim ds As New DataSet

        ds = Prestamos.ConsultarDatosPrestamos(Me.txtDui.Text.Trim, " ", 1)
        ofrm.Datos = ds
        ofrm.ColSeleccion = 0
        ofrm.RefrescarGrid()
        ofrm.ShowDialog()
        txtCodPrestamo.Text = ofrm.Resultado.Trim
    End Sub

    Private Sub C1nCuota_TextChanged(sender As Object, e As EventArgs) Handles C1nCuota.TextChanged

    End Sub

    Private Sub cbEjecutivo_DropDownClosed(sender As Object, e As EventArgs) Handles cbEjecutivo.DropDownClosed
        Try
            Dim dts As New DataSet
            dts = asociados.ConsultarEjecutivosMercadeo("codSucursal", "codEjecMercadeo ='" & cbEjecutivo.SelectedValue & "'", "codEjecMercadeo", sUsuario, sPassword, sSucursal)
            Me.cbSucursal.SelectedValue = dts.Tables(0).Rows(0).Item(0)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cbTipoAhorro_Validated(sender As Object, e As EventArgs) Handles cbTipoAhorro.Validated
        Try
            '=================================================================================================================
            'Generamos # DE CUENTA

            Me.txtNoCuenta.Text = Ahorro.generarNoCuentaTipoAhorro(txtDui.Value.Trim, cbTipoAhorro.SelectedValue, sUsuario, sPassword, sSucursal)
            'Me.txtNoCuenta.Text = Ahorro.GeneraNoCuenta(Trim(Me.txtCodTipoAhorro.Text), sSucursal, "02", Me.dtpFechaApertura.Value.Month, Me.dtpFechaApertura.Value.Year, sUsuario, sPassword, sSucursal)
            digitoVerificador = Ahorro.ObtieneDigitoVerificador(Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
            Dim dts As New DataSet
            Dim ahoprog As String = Strings.Mid(Me.txtNoCuenta.Text, 8, 1)
            If ahoprog = "5" Then
                Me.c1nPlazo.Visible = True
                Me.c1nPlazo.Enabled = True
                Me.c1nCuota.Visible = True
                Me.c1nCuota.Enabled = True
            Else
                Me.c1nPlazo.Visible = False
                Me.c1nPlazo.Enabled = False
                Me.c1nCuota.Visible = False
                Me.c1nCuota.Enabled = False
            End If
            dts = Ahorro.ConsultarParametros("tasaInteres", " codtipoahorro = '" & cbTipoAhorro.SelectedValue & "'", "", sUsuario, sPassword, sSucursal)
            c1nTasa.Value = dts.Tables(0).Rows(0).Item(0)
            '=================================================================================================================
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsAhCuentas_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub c1nPlazo_LostFocus(sender As Object, e As EventArgs) Handles c1nPlazo.LostFocus
        Me.dtpFecVenc.Value = DateAdd("m", (Me.c1nPlazo.Value), Now)
        Me.dtpFechaCan.Value = DateAdd("m", (Me.c1nPlazo.Value), Now)
    End Sub
End Class