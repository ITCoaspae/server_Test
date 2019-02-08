Imports System.IO

Public Class frmMsAsociados
    Inherits System.Windows.Forms.Form : Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtEjecMercadeo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEjecMercadeo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Dim creditos As New wrCredito.wsLibCred

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
    Friend WithEvents tbDatPer As System.Windows.Forms.TabPage
    Friend WithEvents txtNumPas As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents dtpFecExtDui As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents tbDatPerProf As System.Windows.Forms.TabPage
    Friend WithEvents tb As System.Windows.Forms.TabControl
    Friend WithEvents tbGrupoFam As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbOtros As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents btnSigTb1 As System.Windows.Forms.Button
    Friend WithEvents btnSigTb2 As System.Windows.Forms.Button
    Friend WithEvents btAtrasTb2 As System.Windows.Forms.Button
    Friend WithEvents btnAtrasTb4 As System.Windows.Forms.Button
    Friend WithEvents btnSigTb4 As System.Windows.Forms.Button
    Friend WithEvents btnAtrasTb5 As System.Windows.Forms.Button
    Friend WithEvents txtLugDui As System.Windows.Forms.TextBox
    Friend WithEvents txtIsss As System.Windows.Forms.TextBox
    Friend WithEvents txtCodProf As System.Windows.Forms.TextBox
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents txtProf As System.Windows.Forms.TextBox
    Friend WithEvents cbEstadoAsoc As System.Windows.Forms.ComboBox
    Friend WithEvents txtImagen As System.Windows.Forms.TextBox
    Friend WithEvents txtFirma As System.Windows.Forms.TextBox
    Friend WithEvents nuDGrupoFam As System.Windows.Forms.NumericUpDown
    Friend WithEvents nuDNumDep As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtConyugue As System.Windows.Forms.TextBox
    Friend WithEvents btImagen As System.Windows.Forms.Button
    Friend WithEvents btFirma As System.Windows.Forms.Button
    Friend WithEvents pbImagen As System.Windows.Forms.PictureBox
    Friend WithEvents pbFirma As System.Windows.Forms.PictureBox
    Friend WithEvents gbDatDoc As System.Windows.Forms.GroupBox
    Friend WithEvents cboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtCodNac As System.Windows.Forms.TextBox
    Friend WithEvents txtNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents txtApe3 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtApe1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtApe2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnCerrarTb2 As System.Windows.Forms.Button
    Friend WithEvents btnCerrarTb3 As System.Windows.Forms.Button
    Friend WithEvents btnCerrarTb5 As System.Windows.Forms.Button
    Friend WithEvents txtNit As C1.Win.C1Input.C1TextBox
    Friend WithEvents ttipAsoc As System.Windows.Forms.ToolTip
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoResidente As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents chkResidente As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents cbEstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpFecNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtTelCasa As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCel As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCodDpto As System.Windows.Forms.TextBox
    Friend WithEvents txtDpto As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtCorreo As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtMunicipio As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtCodMun As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtGiro As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents txtRegFiscal As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtOtrosIng As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtSalario As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtTipoAct As System.Windows.Forms.TextBox
    Friend WithEvents txtOrigIng As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents chkTrabPropio As System.Windows.Forms.CheckBox
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtLugTrab As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecIniTrab As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtDptoTrabajo As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtDirTrab As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTelOfic As System.Windows.Forms.TextBox
    Friend WithEvents txtExtOfic As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtEjecApertura As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEjecApertura As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txtTiempoResidencia As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents cbEstadoVivienda As System.Windows.Forms.ComboBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents txtDuiA As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txtTotalIngresos As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblReingreso As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsAsociados))
        Me.tb = New System.Windows.Forms.TabControl
        Me.tbDatPer = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblReingreso = New System.Windows.Forms.Label
        Me.txtDui = New C1.Win.C1Input.C1TextBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.cbEstado = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.chkResidente = New System.Windows.Forms.CheckBox
        Me.txtNoResidente = New System.Windows.Forms.TextBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnSigTb1 = New System.Windows.Forms.Button
        Me.gbDatDoc = New System.Windows.Forms.GroupBox
        Me.txtDuiA = New System.Windows.Forms.TextBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.txtCodMun = New System.Windows.Forms.TextBox
        Me.txtMunicipio = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.txtCorreo = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtCodDpto = New System.Windows.Forms.TextBox
        Me.txtDpto = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.txtCel = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtTelCasa = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtpFecNac = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtDir = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.cbEstadoCivil = New System.Windows.Forms.ComboBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.txtNit = New C1.Win.C1Input.C1TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtApe2 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNombres = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboSexo = New System.Windows.Forms.ComboBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtCodNac = New System.Windows.Forms.TextBox
        Me.txtNacionalidad = New System.Windows.Forms.TextBox
        Me.txtApe3 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtApe1 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtNumPas = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.dtpFecExtDui = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNoSocio = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtLugDui = New System.Windows.Forms.TextBox
        Me.txtIsss = New System.Windows.Forms.TextBox
        Me.tbDatPerProf = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtTotalIngresos = New C1.Win.C1Input.C1TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtExtOfic = New System.Windows.Forms.TextBox
        Me.txtTelOfic = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtGiro = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.txtRegFiscal = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.txtOtrosIng = New C1.Win.C1Input.C1TextBox
        Me.txtSalario = New C1.Win.C1Input.C1TextBox
        Me.txtTipoAct = New System.Windows.Forms.TextBox
        Me.txtOrigIng = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.chkTrabPropio = New System.Windows.Forms.CheckBox
        Me.txtCargo = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtLugTrab = New System.Windows.Forms.TextBox
        Me.dtpFecIniTrab = New System.Windows.Forms.DateTimePicker
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtDptoTrabajo = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtDirTrab = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.btnCerrarTb2 = New System.Windows.Forms.Button
        Me.btnSigTb2 = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtCodProf = New System.Windows.Forms.TextBox
        Me.txtTitulo = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtProf = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.btAtrasTb2 = New System.Windows.Forms.Button
        Me.tbGrupoFam = New System.Windows.Forms.TabPage
        Me.btnCerrarTb3 = New System.Windows.Forms.Button
        Me.btnAtrasTb4 = New System.Windows.Forms.Button
        Me.btnSigTb4 = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.cbEstadoVivienda = New System.Windows.Forms.ComboBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.txtTiempoResidencia = New System.Windows.Forms.TextBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.nuDGrupoFam = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.nuDNumDep = New System.Windows.Forms.NumericUpDown
        Me.txtConyugue = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbOtros = New System.Windows.Forms.TabPage
        Me.btnCerrarTb5 = New System.Windows.Forms.Button
        Me.btnAtrasTb5 = New System.Windows.Forms.Button
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.txtEjecApertura = New System.Windows.Forms.TextBox
        Me.txtCodEjecApertura = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.btImagen = New System.Windows.Forms.Button
        Me.btFirma = New System.Windows.Forms.Button
        Me.pbImagen = New System.Windows.Forms.PictureBox
        Me.pbFirma = New System.Windows.Forms.PictureBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.cbEstadoAsoc = New System.Windows.Forms.ComboBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.txtImagen = New System.Windows.Forms.TextBox
        Me.txtFirma = New System.Windows.Forms.TextBox
        Me.ttipAsoc = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.txtEjecMercadeo = New System.Windows.Forms.TextBox
        Me.txtCodEjecMercadeo = New System.Windows.Forms.TextBox
        Me.tb.SuspendLayout()
        Me.tbDatPer.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatDoc.SuspendLayout()
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbDatPerProf.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtTotalIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtOtrosIng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.tbGrupoFam.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.nuDGrupoFam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuDNumDep, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbOtros.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbFirma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb
        '
        Me.tb.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tb.Controls.Add(Me.tbDatPer)
        Me.tb.Controls.Add(Me.tbDatPerProf)
        Me.tb.Controls.Add(Me.tbGrupoFam)
        Me.tb.Controls.Add(Me.tbOtros)
        Me.tb.Location = New System.Drawing.Point(8, 8)
        Me.tb.Name = "tb"
        Me.tb.SelectedIndex = 0
        Me.tb.Size = New System.Drawing.Size(760, 424)
        Me.tb.TabIndex = 15
        '
        'tbDatPer
        '
        Me.tbDatPer.BackColor = System.Drawing.Color.White
        Me.tbDatPer.Controls.Add(Me.GroupBox1)
        Me.tbDatPer.Controls.Add(Me.btnCerrar)
        Me.tbDatPer.Controls.Add(Me.btnSigTb1)
        Me.tbDatPer.Controls.Add(Me.gbDatDoc)
        Me.tbDatPer.ImageIndex = 0
        Me.tbDatPer.Location = New System.Drawing.Point(4, 25)
        Me.tbDatPer.Name = "tbDatPer"
        Me.tbDatPer.Size = New System.Drawing.Size(752, 395)
        Me.tbDatPer.TabIndex = 0
        Me.tbDatPer.Text = "Datos Personales"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblReingreso)
        Me.GroupBox1.Controls.Add(Me.txtDui)
        Me.GroupBox1.Controls.Add(Me.Label51)
        Me.GroupBox1.Controls.Add(Me.cbEstado)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.chkResidente)
        Me.GroupBox1.Controls.Add(Me.txtNoResidente)
        Me.GroupBox1.Controls.Add(Me.Label50)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Generales"
        '
        'lblReingreso
        '
        Me.lblReingreso.BackColor = System.Drawing.Color.Yellow
        Me.lblReingreso.Location = New System.Drawing.Point(648, 0)
        Me.lblReingreso.Name = "lblReingreso"
        Me.lblReingreso.Size = New System.Drawing.Size(88, 16)
        Me.lblReingreso.TabIndex = 121
        Me.lblReingreso.Text = "REINGRESO"
        Me.lblReingreso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblReingreso.Visible = False
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(120, 32)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(104, 20)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        Me.txtDui.Value = ""
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(120, 16)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(56, 16)
        Me.Label51.TabIndex = 120
        Me.Label51.Text = "* No. Dui:"
        '
        'cbEstado
        '
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.Enabled = False
        Me.cbEstado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstado.Items.AddRange(New Object() {"Candidato=no canceló cuota inicial", "Aspirante=canceló cuota inicial", "Asociado", "Ninguno"})
        Me.cbEstado.Location = New System.Drawing.Point(520, 24)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(200, 22)
        Me.cbEstado.TabIndex = 119
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(416, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 16)
        Me.Label7.TabIndex = 118
        Me.Label7.Text = "Estado de Ingreso:"
        Me.Label7.Visible = False
        '
        'chkResidente
        '
        Me.chkResidente.BackColor = System.Drawing.Color.White
        Me.chkResidente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkResidente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkResidente.ForeColor = System.Drawing.Color.Black
        Me.chkResidente.Location = New System.Drawing.Point(16, 24)
        Me.chkResidente.Name = "chkResidente"
        Me.chkResidente.Size = New System.Drawing.Size(80, 16)
        Me.chkResidente.TabIndex = 0
        Me.chkResidente.Text = "&Residente"
        Me.chkResidente.UseVisualStyleBackColor = False
        '
        'txtNoResidente
        '
        Me.txtNoResidente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoResidente.Location = New System.Drawing.Point(256, 32)
        Me.txtNoResidente.MaxLength = 10
        Me.txtNoResidente.Name = "txtNoResidente"
        Me.txtNoResidente.ReadOnly = True
        Me.txtNoResidente.Size = New System.Drawing.Size(96, 20)
        Me.txtNoResidente.TabIndex = 115
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(248, 16)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(136, 16)
        Me.Label50.TabIndex = 116
        Me.Label50.Text = "*No. Carnet de Residente:"
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(664, 360)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(80, 23)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "     &Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnSigTb1
        '
        Me.btnSigTb1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSigTb1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSigTb1.ForeColor = System.Drawing.Color.Black
        Me.btnSigTb1.Image = CType(resources.GetObject("btnSigTb1.Image"), System.Drawing.Image)
        Me.btnSigTb1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSigTb1.Location = New System.Drawing.Point(568, 360)
        Me.btnSigTb1.Name = "btnSigTb1"
        Me.btnSigTb1.Size = New System.Drawing.Size(80, 23)
        Me.btnSigTb1.TabIndex = 2
        Me.btnSigTb1.Text = "&Siguiente"
        Me.btnSigTb1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSigTb1.UseVisualStyleBackColor = False
        '
        'gbDatDoc
        '
        Me.gbDatDoc.BackColor = System.Drawing.Color.White
        Me.gbDatDoc.Controls.Add(Me.txtDuiA)
        Me.gbDatDoc.Controls.Add(Me.Label55)
        Me.gbDatDoc.Controls.Add(Me.txtCodMun)
        Me.gbDatDoc.Controls.Add(Me.txtMunicipio)
        Me.gbDatDoc.Controls.Add(Me.Label37)
        Me.gbDatDoc.Controls.Add(Me.txtCorreo)
        Me.gbDatDoc.Controls.Add(Me.Label33)
        Me.gbDatDoc.Controls.Add(Me.txtCodDpto)
        Me.gbDatDoc.Controls.Add(Me.txtDpto)
        Me.gbDatDoc.Controls.Add(Me.Label38)
        Me.gbDatDoc.Controls.Add(Me.txtCel)
        Me.gbDatDoc.Controls.Add(Me.Label17)
        Me.gbDatDoc.Controls.Add(Me.txtTelCasa)
        Me.gbDatDoc.Controls.Add(Me.Label14)
        Me.gbDatDoc.Controls.Add(Me.dtpFecNac)
        Me.gbDatDoc.Controls.Add(Me.Label12)
        Me.gbDatDoc.Controls.Add(Me.txtDir)
        Me.gbDatDoc.Controls.Add(Me.Label13)
        Me.gbDatDoc.Controls.Add(Me.cbEstadoCivil)
        Me.gbDatDoc.Controls.Add(Me.Label32)
        Me.gbDatDoc.Controls.Add(Me.txtNit)
        Me.gbDatDoc.Controls.Add(Me.Label21)
        Me.gbDatDoc.Controls.Add(Me.txtApe2)
        Me.gbDatDoc.Controls.Add(Me.Label9)
        Me.gbDatDoc.Controls.Add(Me.txtNombres)
        Me.gbDatDoc.Controls.Add(Me.Label10)
        Me.gbDatDoc.Controls.Add(Me.cboSexo)
        Me.gbDatDoc.Controls.Add(Me.Label29)
        Me.gbDatDoc.Controls.Add(Me.txtCodNac)
        Me.gbDatDoc.Controls.Add(Me.txtNacionalidad)
        Me.gbDatDoc.Controls.Add(Me.txtApe3)
        Me.gbDatDoc.Controls.Add(Me.Label11)
        Me.gbDatDoc.Controls.Add(Me.txtApe1)
        Me.gbDatDoc.Controls.Add(Me.Label8)
        Me.gbDatDoc.Controls.Add(Me.txtNumPas)
        Me.gbDatDoc.Controls.Add(Me.Label28)
        Me.gbDatDoc.Controls.Add(Me.dtpFecExtDui)
        Me.gbDatDoc.Controls.Add(Me.Label6)
        Me.gbDatDoc.Controls.Add(Me.txtNoSocio)
        Me.gbDatDoc.Controls.Add(Me.Label4)
        Me.gbDatDoc.Controls.Add(Me.Label2)
        Me.gbDatDoc.Controls.Add(Me.Label18)
        Me.gbDatDoc.Controls.Add(Me.Label30)
        Me.gbDatDoc.Controls.Add(Me.txtLugDui)
        Me.gbDatDoc.Controls.Add(Me.txtIsss)
        Me.gbDatDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatDoc.ForeColor = System.Drawing.Color.Navy
        Me.gbDatDoc.Location = New System.Drawing.Point(8, 80)
        Me.gbDatDoc.Name = "gbDatDoc"
        Me.gbDatDoc.Size = New System.Drawing.Size(736, 272)
        Me.gbDatDoc.TabIndex = 1
        Me.gbDatDoc.TabStop = False
        Me.gbDatDoc.Text = "Datos Personales"
        '
        'txtDuiA
        '
        Me.txtDuiA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuiA.Location = New System.Drawing.Point(16, 88)
        Me.txtDuiA.MaxLength = 10
        Me.txtDuiA.Name = "txtDuiA"
        Me.txtDuiA.ReadOnly = True
        Me.txtDuiA.Size = New System.Drawing.Size(104, 20)
        Me.txtDuiA.TabIndex = 131
        Me.ttipAsoc.SetToolTip(Me.txtDuiA, "Este código se digita si no se encuentra en la Base de Datos.")
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(16, 72)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(56, 16)
        Me.Label55.TabIndex = 130
        Me.Label55.Text = "*Dui:"
        '
        'txtCodMun
        '
        Me.txtCodMun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMun.Location = New System.Drawing.Point(288, 232)
        Me.txtCodMun.MaxLength = 2
        Me.txtCodMun.Name = "txtCodMun"
        Me.txtCodMun.Size = New System.Drawing.Size(64, 20)
        Me.txtCodMun.TabIndex = 18
        '
        'txtMunicipio
        '
        Me.txtMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMunicipio.Location = New System.Drawing.Point(360, 232)
        Me.txtMunicipio.MaxLength = 100
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.ReadOnly = True
        Me.txtMunicipio.Size = New System.Drawing.Size(208, 20)
        Me.txtMunicipio.TabIndex = 129
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(288, 216)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(144, 16)
        Me.Label37.TabIndex = 128
        Me.Label37.Text = "*Municipio Residencia:"
        Me.Label37.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorreo
        '
        Me.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorreo.Location = New System.Drawing.Point(576, 232)
        Me.txtCorreo.MaxLength = 255
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCorreo.Size = New System.Drawing.Size(152, 20)
        Me.txtCorreo.TabIndex = 19
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(576, 216)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(112, 16)
        Me.Label33.TabIndex = 127
        Me.Label33.Text = "Correo electrónico:"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodDpto
        '
        Me.txtCodDpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDpto.Location = New System.Drawing.Point(16, 232)
        Me.txtCodDpto.MaxLength = 2
        Me.txtCodDpto.Name = "txtCodDpto"
        Me.txtCodDpto.Size = New System.Drawing.Size(64, 20)
        Me.txtCodDpto.TabIndex = 17
        '
        'txtDpto
        '
        Me.txtDpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDpto.Location = New System.Drawing.Point(88, 232)
        Me.txtDpto.MaxLength = 30
        Me.txtDpto.Name = "txtDpto"
        Me.txtDpto.ReadOnly = True
        Me.txtDpto.Size = New System.Drawing.Size(192, 20)
        Me.txtDpto.TabIndex = 125
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(16, 216)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(144, 16)
        Me.Label38.TabIndex = 124
        Me.Label38.Text = "*Departamento Residencia:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCel
        '
        Me.txtCel.Location = New System.Drawing.Point(624, 184)
        Me.txtCel.MaxLength = 10
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(104, 20)
        Me.txtCel.TabIndex = 16
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(624, 168)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 16)
        Me.Label17.TabIndex = 122
        Me.Label17.Text = "Teléfono Celular:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelCasa
        '
        Me.txtTelCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelCasa.Location = New System.Drawing.Point(528, 184)
        Me.txtTelCasa.MaxLength = 40
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.Size = New System.Drawing.Size(88, 20)
        Me.txtTelCasa.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(528, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 120
        Me.Label14.Text = "Teléfono Casa:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFecNac
        '
        Me.dtpFecNac.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecNac.Location = New System.Drawing.Point(408, 184)
        Me.dtpFecNac.Name = "dtpFecNac"
        Me.dtpFecNac.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecNac.TabIndex = 14
        Me.dtpFecNac.Value = New Date(2017, 1, 22, 18, 26, 35, 0)
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(408, 168)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 16)
        Me.Label12.TabIndex = 118
        Me.Label12.Text = "Fecha de Nacimiento:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDir
        '
        Me.txtDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDir.Location = New System.Drawing.Point(16, 184)
        Me.txtDir.MaxLength = 255
        Me.txtDir.Multiline = True
        Me.txtDir.Name = "txtDir"
        Me.txtDir.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDir.Size = New System.Drawing.Size(384, 24)
        Me.txtDir.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(16, 168)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "Dirección:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbEstadoCivil
        '
        Me.cbEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoCivil.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEstadoCivil.Items.AddRange(New Object() {"Soltero", "Casado", "Divorciado", "Acompañado", "Viudo"})
        Me.cbEstadoCivil.Location = New System.Drawing.Point(256, 136)
        Me.cbEstadoCivil.Name = "cbEstadoCivil"
        Me.cbEstadoCivil.Size = New System.Drawing.Size(104, 22)
        Me.cbEstadoCivil.TabIndex = 9
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(256, 120)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 16)
        Me.Label32.TabIndex = 114
        Me.Label32.Text = "Estado Civil:"
        '
        'txtNit
        '
        Me.txtNit.EditMask = "0000-000000-000-0"
        Me.txtNit.Location = New System.Drawing.Point(504, 136)
        Me.txtNit.MaxLength = 20
        Me.txtNit.Name = "txtNit"
        Me.txtNit.NumericInput = False
        Me.txtNit.Size = New System.Drawing.Size(112, 20)
        Me.txtNit.TabIndex = 11
        Me.txtNit.Tag = Nothing
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(368, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 16)
        Me.Label21.TabIndex = 111
        Me.Label21.Text = "* Nacionalidad:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApe2
        '
        Me.txtApe2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe2.Location = New System.Drawing.Point(16, 136)
        Me.txtApe2.MaxLength = 25
        Me.txtApe2.Name = "txtApe2"
        Me.txtApe2.Size = New System.Drawing.Size(136, 20)
        Me.txtApe2.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Apellido 2:"
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Location = New System.Drawing.Point(222, 88)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(338, 20)
        Me.txtNombres.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(230, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "* Nombres:"
        '
        'cboSexo
        '
        Me.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSexo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSexo.Items.AddRange(New Object() {"Femenino", "Masculino"})
        Me.cboSexo.Location = New System.Drawing.Point(160, 136)
        Me.cboSexo.Name = "cboSexo"
        Me.cboSexo.Size = New System.Drawing.Size(88, 22)
        Me.cboSexo.TabIndex = 8
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(160, 120)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 16)
        Me.Label29.TabIndex = 106
        Me.Label29.Text = "Sexo:"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodNac
        '
        Me.txtCodNac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodNac.Location = New System.Drawing.Point(352, 40)
        Me.txtCodNac.MaxLength = 5
        Me.txtCodNac.Name = "txtCodNac"
        Me.txtCodNac.Size = New System.Drawing.Size(64, 20)
        Me.txtCodNac.TabIndex = 2
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNacionalidad.Location = New System.Drawing.Point(424, 40)
        Me.txtNacionalidad.MaxLength = 100
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.ReadOnly = True
        Me.txtNacionalidad.Size = New System.Drawing.Size(160, 20)
        Me.txtNacionalidad.TabIndex = 105
        '
        'txtApe3
        '
        Me.txtApe3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe3.Enabled = False
        Me.txtApe3.Location = New System.Drawing.Point(368, 136)
        Me.txtApe3.MaxLength = 30
        Me.txtApe3.Name = "txtApe3"
        Me.txtApe3.Size = New System.Drawing.Size(128, 20)
        Me.txtApe3.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(368, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 16)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "Apellido de Casada:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApe1
        '
        Me.txtApe1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApe1.Location = New System.Drawing.Point(568, 88)
        Me.txtApe1.MaxLength = 25
        Me.txtApe1.Name = "txtApe1"
        Me.txtApe1.Size = New System.Drawing.Size(160, 20)
        Me.txtApe1.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(568, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "* Apellido 1:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNumPas
        '
        Me.txtNumPas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumPas.Location = New System.Drawing.Point(600, 40)
        Me.txtNumPas.MaxLength = 30
        Me.txtNumPas.Name = "txtNumPas"
        Me.txtNumPas.Size = New System.Drawing.Size(128, 20)
        Me.txtNumPas.TabIndex = 3
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(600, 24)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(120, 16)
        Me.Label28.TabIndex = 93
        Me.Label28.Text = "Número de pasaporte:"
        '
        'dtpFecExtDui
        '
        Me.dtpFecExtDui.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecExtDui.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecExtDui.Location = New System.Drawing.Point(240, 40)
        Me.dtpFecExtDui.Name = "dtpFecExtDui"
        Me.dtpFecExtDui.Size = New System.Drawing.Size(80, 20)
        Me.dtpFecExtDui.TabIndex = 1
        Me.dtpFecExtDui.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(240, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "Fecha extensión DUI:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Location = New System.Drawing.Point(128, 88)
        Me.txtNoSocio.MaxLength = 8
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(88, 20)
        Me.txtNoSocio.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(504, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "*Nit:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(128, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "No. Cliente"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(16, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 16)
        Me.Label18.TabIndex = 82
        Me.Label18.Text = "Lugar extensión DUI:"
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(624, 120)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(40, 16)
        Me.Label30.TabIndex = 84
        Me.Label30.Text = "ISSS:"
        '
        'txtLugDui
        '
        Me.txtLugDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLugDui.Location = New System.Drawing.Point(16, 40)
        Me.txtLugDui.MaxLength = 50
        Me.txtLugDui.Name = "txtLugDui"
        Me.txtLugDui.Size = New System.Drawing.Size(216, 20)
        Me.txtLugDui.TabIndex = 0
        '
        'txtIsss
        '
        Me.txtIsss.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIsss.Location = New System.Drawing.Point(624, 136)
        Me.txtIsss.MaxLength = 20
        Me.txtIsss.Name = "txtIsss"
        Me.txtIsss.Size = New System.Drawing.Size(104, 20)
        Me.txtIsss.TabIndex = 12
        '
        'tbDatPerProf
        '
        Me.tbDatPerProf.BackColor = System.Drawing.Color.White
        Me.tbDatPerProf.Controls.Add(Me.GroupBox2)
        Me.tbDatPerProf.Controls.Add(Me.btnCerrarTb2)
        Me.tbDatPerProf.Controls.Add(Me.btnSigTb2)
        Me.tbDatPerProf.Controls.Add(Me.GroupBox5)
        Me.tbDatPerProf.Controls.Add(Me.btAtrasTb2)
        Me.tbDatPerProf.Location = New System.Drawing.Point(4, 25)
        Me.tbDatPerProf.Name = "tbDatPerProf"
        Me.tbDatPerProf.Size = New System.Drawing.Size(752, 395)
        Me.tbDatPerProf.TabIndex = 2
        Me.tbDatPerProf.Text = "Datos Profesión / Datos Trabajo"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txtTotalIngresos)
        Me.GroupBox2.Controls.Add(Me.Label56)
        Me.GroupBox2.Controls.Add(Me.GroupBox4)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.txtExtOfic)
        Me.GroupBox2.Controls.Add(Me.txtTelOfic)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtGiro)
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.txtRegFiscal)
        Me.GroupBox2.Controls.Add(Me.Label45)
        Me.GroupBox2.Controls.Add(Me.txtOtrosIng)
        Me.GroupBox2.Controls.Add(Me.txtSalario)
        Me.GroupBox2.Controls.Add(Me.txtTipoAct)
        Me.GroupBox2.Controls.Add(Me.txtOrigIng)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.chkTrabPropio)
        Me.GroupBox2.Controls.Add(Me.txtCargo)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.txtLugTrab)
        Me.GroupBox2.Controls.Add(Me.dtpFecIniTrab)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtDptoTrabajo)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.txtDirTrab)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(736, 264)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Trabajo"
        '
        'txtTotalIngresos
        '
        Me.txtTotalIngresos.DataType = GetType(Decimal)
        Me.txtTotalIngresos.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtTotalIngresos.Location = New System.Drawing.Point(442, 120)
        Me.txtTotalIngresos.Name = "txtTotalIngresos"
        Me.txtTotalIngresos.ParseInfo.NumberStyle = CType((((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowLeadingSign) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtTotalIngresos.ReadOnly = True
        Me.txtTotalIngresos.Size = New System.Drawing.Size(96, 20)
        Me.txtTotalIngresos.TabIndex = 112
        Me.txtTotalIngresos.Tag = Nothing
        Me.txtTotalIngresos.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(346, 122)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(96, 16)
        Me.Label56.TabIndex = 111
        Me.Label56.Text = "Total de ingresos:"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(430, 170)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1, 80)
        Me.GroupBox4.TabIndex = 110
        Me.GroupBox4.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(16, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(704, 1)
        Me.GroupBox3.TabIndex = 109
        Me.GroupBox3.TabStop = False
        '
        'txtExtOfic
        '
        Me.txtExtOfic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExtOfic.Location = New System.Drawing.Point(208, 122)
        Me.txtExtOfic.MaxLength = 15
        Me.txtExtOfic.Name = "txtExtOfic"
        Me.txtExtOfic.Size = New System.Drawing.Size(120, 20)
        Me.txtExtOfic.TabIndex = 7
        '
        'txtTelOfic
        '
        Me.txtTelOfic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelOfic.Location = New System.Drawing.Point(16, 123)
        Me.txtTelOfic.MaxLength = 40
        Me.txtTelOfic.Name = "txtTelOfic"
        Me.txtTelOfic.Size = New System.Drawing.Size(160, 20)
        Me.txtTelOfic.TabIndex = 6
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(208, 105)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 16)
        Me.Label16.TabIndex = 106
        Me.Label16.Text = "Extensión de la Oficina:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(16, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 16)
        Me.Label15.TabIndex = 105
        Me.Label15.Text = "Teléfono Oficina:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGiro
        '
        Me.txtGiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGiro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGiro.Location = New System.Drawing.Point(16, 216)
        Me.txtGiro.MaxLength = 255
        Me.txtGiro.Name = "txtGiro"
        Me.txtGiro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGiro.Size = New System.Drawing.Size(144, 20)
        Me.txtGiro.TabIndex = 9
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(16, 200)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(48, 16)
        Me.Label44.TabIndex = 104
        Me.Label44.Text = "Giro:"
        '
        'txtRegFiscal
        '
        Me.txtRegFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRegFiscal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRegFiscal.Location = New System.Drawing.Point(168, 216)
        Me.txtRegFiscal.MaxLength = 8
        Me.txtRegFiscal.Name = "txtRegFiscal"
        Me.txtRegFiscal.Size = New System.Drawing.Size(112, 20)
        Me.txtRegFiscal.TabIndex = 10
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(168, 200)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(104, 16)
        Me.Label45.TabIndex = 102
        Me.Label45.Text = "Registro Fiscal:"
        '
        'txtOtrosIng
        '
        Me.txtOtrosIng.DataType = GetType(Decimal)
        Me.txtOtrosIng.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtOtrosIng.Location = New System.Drawing.Point(448, 216)
        Me.txtOtrosIng.Name = "txtOtrosIng"
        Me.txtOtrosIng.ParseInfo.NumberStyle = CType((((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowLeadingSign) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtOtrosIng.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtOtrosIng.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtOtrosIng.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtOtrosIng.Size = New System.Drawing.Size(88, 20)
        Me.txtOtrosIng.TabIndex = 12
        Me.txtOtrosIng.Tag = Nothing
        Me.txtOtrosIng.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtSalario
        '
        Me.txtSalario.DataType = GetType(Decimal)
        Me.txtSalario.FormatType = C1.Win.C1Input.FormatTypeEnum.Currency
        Me.txtSalario.Location = New System.Drawing.Point(240, 80)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.ParseInfo.NumberStyle = CType((((((C1.Win.C1Input.NumberStyleFlags.AllowLeadingWhite Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingWhite) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowLeadingSign) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowTrailingSign) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowDecimalPoint) _
                    Or C1.Win.C1Input.NumberStyleFlags.AllowThousands), C1.Win.C1Input.NumberStyleFlags)
        Me.txtSalario.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtSalario.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtSalario.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtSalario.Size = New System.Drawing.Size(96, 20)
        Me.txtSalario.TabIndex = 4
        Me.txtSalario.Tag = Nothing
        Me.txtSalario.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtTipoAct
        '
        Me.txtTipoAct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoAct.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoAct.Location = New System.Drawing.Point(288, 216)
        Me.txtTipoAct.MaxLength = 100
        Me.txtTipoAct.Name = "txtTipoAct"
        Me.txtTipoAct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTipoAct.Size = New System.Drawing.Size(128, 20)
        Me.txtTipoAct.TabIndex = 11
        '
        'txtOrigIng
        '
        Me.txtOrigIng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrigIng.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrigIng.Location = New System.Drawing.Point(560, 216)
        Me.txtOrigIng.MaxLength = 100
        Me.txtOrigIng.Name = "txtOrigIng"
        Me.txtOrigIng.Size = New System.Drawing.Size(160, 20)
        Me.txtOrigIng.TabIndex = 13
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(560, 200)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(136, 16)
        Me.Label36.TabIndex = 73
        Me.Label36.Text = "Origen de otros ingresos:"
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(448, 200)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(88, 16)
        Me.Label35.TabIndex = 72
        Me.Label35.Text = "Otros Ingresos:"
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(288, 200)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(104, 16)
        Me.Label34.TabIndex = 71
        Me.Label34.Text = "Tipo de Actividad:"
        '
        'chkTrabPropio
        '
        Me.chkTrabPropio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTrabPropio.ForeColor = System.Drawing.Color.Black
        Me.chkTrabPropio.Location = New System.Drawing.Point(16, 168)
        Me.chkTrabPropio.Name = "chkTrabPropio"
        Me.chkTrabPropio.Size = New System.Drawing.Size(104, 16)
        Me.chkTrabPropio.TabIndex = 8
        Me.chkTrabPropio.Text = "&Trabajo Propio"
        '
        'txtCargo
        '
        Me.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCargo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.Location = New System.Drawing.Point(16, 80)
        Me.txtCargo.MaxLength = 50
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCargo.Size = New System.Drawing.Size(208, 20)
        Me.txtCargo.TabIndex = 3
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(240, 64)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(48, 16)
        Me.Label27.TabIndex = 57
        Me.Label27.Text = "Salario:"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(16, 64)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 16)
        Me.Label26.TabIndex = 56
        Me.Label26.Text = "Cargo:"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(352, 64)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 16)
        Me.Label25.TabIndex = 55
        Me.Label25.Text = "Dirección:"
        '
        'txtLugTrab
        '
        Me.txtLugTrab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLugTrab.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugTrab.Location = New System.Drawing.Point(16, 40)
        Me.txtLugTrab.MaxLength = 255
        Me.txtLugTrab.Name = "txtLugTrab"
        Me.txtLugTrab.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLugTrab.Size = New System.Drawing.Size(304, 20)
        Me.txtLugTrab.TabIndex = 0
        '
        'dtpFecIniTrab
        '
        Me.dtpFecIniTrab.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecIniTrab.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecIniTrab.Location = New System.Drawing.Point(336, 40)
        Me.dtpFecIniTrab.Name = "dtpFecIniTrab"
        Me.dtpFecIniTrab.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecIniTrab.TabIndex = 1
        Me.dtpFecIniTrab.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(336, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 16)
        Me.Label24.TabIndex = 52
        Me.Label24.Text = "Fecha de Inicio:"
        '
        'txtDptoTrabajo
        '
        Me.txtDptoTrabajo.BackColor = System.Drawing.Color.White
        Me.txtDptoTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDptoTrabajo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDptoTrabajo.Location = New System.Drawing.Point(440, 40)
        Me.txtDptoTrabajo.MaxLength = 50
        Me.txtDptoTrabajo.Name = "txtDptoTrabajo"
        Me.txtDptoTrabajo.Size = New System.Drawing.Size(248, 20)
        Me.txtDptoTrabajo.TabIndex = 2
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(440, 14)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(136, 32)
        Me.Label23.TabIndex = 50
        Me.Label23.Text = "Área, Sección / Departamento de trabajo:"
        '
        'txtDirTrab
        '
        Me.txtDirTrab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDirTrab.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirTrab.Location = New System.Drawing.Point(352, 80)
        Me.txtDirTrab.MaxLength = 255
        Me.txtDirTrab.Name = "txtDirTrab"
        Me.txtDirTrab.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDirTrab.Size = New System.Drawing.Size(368, 20)
        Me.txtDirTrab.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(16, 24)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 16)
        Me.Label22.TabIndex = 48
        Me.Label22.Text = "Lugar de trabajo:"
        '
        'btnCerrarTb2
        '
        Me.btnCerrarTb2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrarTb2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrarTb2.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarTb2.Image = CType(resources.GetObject("btnCerrarTb2.Image"), System.Drawing.Image)
        Me.btnCerrarTb2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarTb2.Location = New System.Drawing.Point(664, 360)
        Me.btnCerrarTb2.Name = "btnCerrarTb2"
        Me.btnCerrarTb2.Size = New System.Drawing.Size(80, 23)
        Me.btnCerrarTb2.TabIndex = 4
        Me.btnCerrarTb2.Text = "     &Cerrar"
        Me.btnCerrarTb2.UseVisualStyleBackColor = False
        '
        'btnSigTb2
        '
        Me.btnSigTb2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSigTb2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSigTb2.ForeColor = System.Drawing.Color.Black
        Me.btnSigTb2.Image = CType(resources.GetObject("btnSigTb2.Image"), System.Drawing.Image)
        Me.btnSigTb2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSigTb2.Location = New System.Drawing.Point(568, 360)
        Me.btnSigTb2.Name = "btnSigTb2"
        Me.btnSigTb2.Size = New System.Drawing.Size(80, 23)
        Me.btnSigTb2.TabIndex = 3
        Me.btnSigTb2.Text = "&Siguiente"
        Me.btnSigTb2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSigTb2.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.White
        Me.GroupBox5.Controls.Add(Me.txtCodProf)
        Me.GroupBox5.Controls.Add(Me.txtTitulo)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.txtProf)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(736, 72)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Profesión"
        '
        'txtCodProf
        '
        Me.txtCodProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodProf.Location = New System.Drawing.Point(24, 32)
        Me.txtCodProf.MaxLength = 10
        Me.txtCodProf.Name = "txtCodProf"
        Me.txtCodProf.Size = New System.Drawing.Size(64, 20)
        Me.txtCodProf.TabIndex = 0
        '
        'txtTitulo
        '
        Me.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitulo.Location = New System.Drawing.Point(400, 32)
        Me.txtTitulo.MaxLength = 100
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(280, 20)
        Me.txtTitulo.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(400, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 16)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Título Obtenido:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProf
        '
        Me.txtProf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProf.Location = New System.Drawing.Point(96, 32)
        Me.txtProf.MaxLength = 100
        Me.txtProf.Name = "txtProf"
        Me.txtProf.ReadOnly = True
        Me.txtProf.Size = New System.Drawing.Size(288, 20)
        Me.txtProf.TabIndex = 58
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(24, 18)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "*Profesión:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btAtrasTb2
        '
        Me.btAtrasTb2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btAtrasTb2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btAtrasTb2.ForeColor = System.Drawing.Color.Black
        Me.btAtrasTb2.Image = CType(resources.GetObject("btAtrasTb2.Image"), System.Drawing.Image)
        Me.btAtrasTb2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btAtrasTb2.Location = New System.Drawing.Point(472, 360)
        Me.btAtrasTb2.Name = "btAtrasTb2"
        Me.btAtrasTb2.Size = New System.Drawing.Size(80, 23)
        Me.btAtrasTb2.TabIndex = 2
        Me.btAtrasTb2.Text = "     &Atrás"
        Me.btAtrasTb2.UseVisualStyleBackColor = False
        '
        'tbGrupoFam
        '
        Me.tbGrupoFam.BackColor = System.Drawing.Color.White
        Me.tbGrupoFam.Controls.Add(Me.btnGuardar)
        Me.tbGrupoFam.Controls.Add(Me.btnCerrarTb3)
        Me.tbGrupoFam.Controls.Add(Me.btnAtrasTb4)
        Me.tbGrupoFam.Controls.Add(Me.btnSigTb4)
        Me.tbGrupoFam.Controls.Add(Me.GroupBox6)
        Me.tbGrupoFam.Location = New System.Drawing.Point(4, 25)
        Me.tbGrupoFam.Name = "tbGrupoFam"
        Me.tbGrupoFam.Size = New System.Drawing.Size(752, 395)
        Me.tbGrupoFam.TabIndex = 3
        Me.tbGrupoFam.Text = "Grupo Familiar"
        '
        'btnCerrarTb3
        '
        Me.btnCerrarTb3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrarTb3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrarTb3.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarTb3.Image = CType(resources.GetObject("btnCerrarTb3.Image"), System.Drawing.Image)
        Me.btnCerrarTb3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarTb3.Location = New System.Drawing.Point(664, 360)
        Me.btnCerrarTb3.Name = "btnCerrarTb3"
        Me.btnCerrarTb3.Size = New System.Drawing.Size(80, 23)
        Me.btnCerrarTb3.TabIndex = 4
        Me.btnCerrarTb3.Text = "     &Cerrar"
        Me.btnCerrarTb3.UseVisualStyleBackColor = False
        '
        'btnAtrasTb4
        '
        Me.btnAtrasTb4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAtrasTb4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAtrasTb4.ForeColor = System.Drawing.Color.Black
        Me.btnAtrasTb4.Image = CType(resources.GetObject("btnAtrasTb4.Image"), System.Drawing.Image)
        Me.btnAtrasTb4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtrasTb4.Location = New System.Drawing.Point(492, 360)
        Me.btnAtrasTb4.Name = "btnAtrasTb4"
        Me.btnAtrasTb4.Size = New System.Drawing.Size(80, 23)
        Me.btnAtrasTb4.TabIndex = 2
        Me.btnAtrasTb4.Text = "     &Atrás"
        Me.btnAtrasTb4.UseVisualStyleBackColor = False
        '
        'btnSigTb4
        '
        Me.btnSigTb4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnSigTb4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSigTb4.ForeColor = System.Drawing.Color.Black
        Me.btnSigTb4.Image = CType(resources.GetObject("btnSigTb4.Image"), System.Drawing.Image)
        Me.btnSigTb4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSigTb4.Location = New System.Drawing.Point(664, 331)
        Me.btnSigTb4.Name = "btnSigTb4"
        Me.btnSigTb4.Size = New System.Drawing.Size(80, 23)
        Me.btnSigTb4.TabIndex = 3
        Me.btnSigTb4.Text = "&Siguiente"
        Me.btnSigTb4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSigTb4.UseVisualStyleBackColor = False
        Me.btnSigTb4.Visible = False
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.White
        Me.GroupBox6.Controls.Add(Me.txtEjecMercadeo)
        Me.GroupBox6.Controls.Add(Me.txtCodEjecMercadeo)
        Me.GroupBox6.Controls.Add(Me.GroupBox8)
        Me.GroupBox6.Controls.Add(Me.Label39)
        Me.GroupBox6.Controls.Add(Me.cbEstadoVivienda)
        Me.GroupBox6.Controls.Add(Me.Label54)
        Me.GroupBox6.Controls.Add(Me.txtTiempoResidencia)
        Me.GroupBox6.Controls.Add(Me.Label53)
        Me.GroupBox6.Controls.Add(Me.nuDGrupoFam)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.nuDNumDep)
        Me.GroupBox6.Controls.Add(Me.txtConyugue)
        Me.GroupBox6.Controls.Add(Me.Label3)
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox6.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(736, 208)
        Me.GroupBox6.TabIndex = 0
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Información de Grupo Familiar"
        '
        'cbEstadoVivienda
        '
        Me.cbEstadoVivienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoVivienda.Items.AddRange(New Object() {"Financiada", "Alquilada", "Propia"})
        Me.cbEstadoVivienda.Location = New System.Drawing.Point(472, 32)
        Me.cbEstadoVivienda.Name = "cbEstadoVivienda"
        Me.cbEstadoVivienda.Size = New System.Drawing.Size(184, 22)
        Me.cbEstadoVivienda.TabIndex = 3
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(472, 16)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(168, 16)
        Me.Label54.TabIndex = 64
        Me.Label54.Text = "Estado de la vivienda:"
        '
        'txtTiempoResidencia
        '
        Me.txtTiempoResidencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTiempoResidencia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTiempoResidencia.Location = New System.Drawing.Point(472, 80)
        Me.txtTiempoResidencia.MaxLength = 50
        Me.txtTiempoResidencia.Name = "txtTiempoResidencia"
        Me.txtTiempoResidencia.Size = New System.Drawing.Size(184, 20)
        Me.txtTiempoResidencia.TabIndex = 4
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(472, 64)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(168, 16)
        Me.Label53.TabIndex = 62
        Me.Label53.Text = "Tiempo de residir en la vivienda:"
        '
        'nuDGrupoFam
        '
        Me.nuDGrupoFam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nuDGrupoFam.Location = New System.Drawing.Point(296, 80)
        Me.nuDGrupoFam.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nuDGrupoFam.Name = "nuDGrupoFam"
        Me.nuDGrupoFam.Size = New System.Drawing.Size(40, 20)
        Me.nuDGrupoFam.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(296, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Número de Grupo familiar:"
        '
        'nuDNumDep
        '
        Me.nuDNumDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nuDNumDep.Location = New System.Drawing.Point(296, 32)
        Me.nuDNumDep.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.nuDNumDep.Name = "nuDNumDep"
        Me.nuDNumDep.Size = New System.Drawing.Size(40, 20)
        Me.nuDNumDep.TabIndex = 1
        '
        'txtConyugue
        '
        Me.txtConyugue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConyugue.Enabled = False
        Me.txtConyugue.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConyugue.Location = New System.Drawing.Point(16, 48)
        Me.txtConyugue.MaxLength = 100
        Me.txtConyugue.Name = "txtConyugue"
        Me.txtConyugue.Size = New System.Drawing.Size(256, 20)
        Me.txtConyugue.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Nombre Cónyugue:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(296, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Número de Dependientes:"
        '
        'tbOtros
        '
        Me.tbOtros.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.tbOtros.Controls.Add(Me.btnCerrarTb5)
        Me.tbOtros.Controls.Add(Me.btnAtrasTb5)
        Me.tbOtros.Controls.Add(Me.GroupBox9)
        Me.tbOtros.Location = New System.Drawing.Point(4, 25)
        Me.tbOtros.Name = "tbOtros"
        Me.tbOtros.Size = New System.Drawing.Size(752, 395)
        Me.tbOtros.TabIndex = 4
        Me.tbOtros.Text = "Otros datos"
        Me.tbOtros.UseVisualStyleBackColor = True
        '
        'btnCerrarTb5
        '
        Me.btnCerrarTb5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnCerrarTb5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrarTb5.ForeColor = System.Drawing.Color.Black
        Me.btnCerrarTb5.Image = CType(resources.GetObject("btnCerrarTb5.Image"), System.Drawing.Image)
        Me.btnCerrarTb5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrarTb5.Location = New System.Drawing.Point(664, 360)
        Me.btnCerrarTb5.Name = "btnCerrarTb5"
        Me.btnCerrarTb5.Size = New System.Drawing.Size(80, 23)
        Me.btnCerrarTb5.TabIndex = 3
        Me.btnCerrarTb5.Text = "     &Cerrar"
        Me.btnCerrarTb5.UseVisualStyleBackColor = False
        '
        'btnAtrasTb5
        '
        Me.btnAtrasTb5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAtrasTb5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAtrasTb5.ForeColor = System.Drawing.Color.Black
        Me.btnAtrasTb5.Image = CType(resources.GetObject("btnAtrasTb5.Image"), System.Drawing.Image)
        Me.btnAtrasTb5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAtrasTb5.Location = New System.Drawing.Point(472, 360)
        Me.btnAtrasTb5.Name = "btnAtrasTb5"
        Me.btnAtrasTb5.Size = New System.Drawing.Size(80, 23)
        Me.btnAtrasTb5.TabIndex = 1
        Me.btnAtrasTb5.Text = "     &Atrás"
        Me.btnAtrasTb5.UseVisualStyleBackColor = False
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Teal
        Me.GroupBox9.Controls.Add(Me.txtEjecApertura)
        Me.GroupBox9.Controls.Add(Me.txtCodEjecApertura)
        Me.GroupBox9.Controls.Add(Me.Label31)
        Me.GroupBox9.Controls.Add(Me.txtFecha)
        Me.GroupBox9.Controls.Add(Me.Label52)
        Me.GroupBox9.Controls.Add(Me.GroupBox10)
        Me.GroupBox9.Controls.Add(Me.GroupBox7)
        Me.GroupBox9.Controls.Add(Me.txtObservaciones)
        Me.GroupBox9.Controls.Add(Me.Label49)
        Me.GroupBox9.Controls.Add(Me.btImagen)
        Me.GroupBox9.Controls.Add(Me.btFirma)
        Me.GroupBox9.Controls.Add(Me.pbImagen)
        Me.GroupBox9.Controls.Add(Me.pbFirma)
        Me.GroupBox9.Controls.Add(Me.Label47)
        Me.GroupBox9.Controls.Add(Me.Label46)
        Me.GroupBox9.Controls.Add(Me.cbEstadoAsoc)
        Me.GroupBox9.Controls.Add(Me.Label40)
        Me.GroupBox9.Controls.Add(Me.Label42)
        Me.GroupBox9.Controls.Add(Me.txtImagen)
        Me.GroupBox9.Controls.Add(Me.txtFirma)
        Me.GroupBox9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox9.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(736, 336)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Otros Datos"
        '
        'txtEjecApertura
        '
        Me.txtEjecApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEjecApertura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecApertura.Location = New System.Drawing.Point(424, 262)
        Me.txtEjecApertura.MaxLength = 100
        Me.txtEjecApertura.Name = "txtEjecApertura"
        Me.txtEjecApertura.ReadOnly = True
        Me.txtEjecApertura.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtEjecApertura.Size = New System.Drawing.Size(280, 20)
        Me.txtEjecApertura.TabIndex = 206
        Me.txtEjecApertura.Visible = False
        '
        'txtCodEjecApertura
        '
        Me.txtCodEjecApertura.AcceptsReturn = True
        Me.txtCodEjecApertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEjecApertura.Location = New System.Drawing.Point(352, 262)
        Me.txtCodEjecApertura.MaxLength = 10
        Me.txtCodEjecApertura.Name = "txtCodEjecApertura"
        Me.txtCodEjecApertura.Size = New System.Drawing.Size(64, 20)
        Me.txtCodEjecApertura.TabIndex = 2
        Me.txtCodEjecApertura.Visible = False
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(312, 196)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(144, 16)
        Me.Label31.TabIndex = 205
        Me.Label31.Text = "Código Ejecutivo Apertura:"
        Me.Label31.Visible = False
        '
        'txtFecha
        '
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha.Location = New System.Drawing.Point(120, 80)
        Me.txtFecha.MaxLength = 10
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(104, 20)
        Me.txtFecha.TabIndex = 116
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(24, 80)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(80, 32)
        Me.Label52.TabIndex = 115
        Me.Label52.Text = "Fecha de Estado:"
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.Black
        Me.GroupBox10.Location = New System.Drawing.Point(368, 16)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(1, 168)
        Me.GroupBox10.TabIndex = 114
        Me.GroupBox10.TabStop = False
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.Black
        Me.GroupBox7.Location = New System.Drawing.Point(16, 192)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(704, 1)
        Me.GroupBox7.TabIndex = 113
        Me.GroupBox7.TabStop = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(24, 288)
        Me.txtObservaciones.MaxLength = 255
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(688, 32)
        Me.txtObservaciones.TabIndex = 3
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(24, 272)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(104, 16)
        Me.Label49.TabIndex = 109
        Me.Label49.Text = "Observaciones:"
        '
        'btImagen
        '
        Me.btImagen.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btImagen.Location = New System.Drawing.Point(680, 164)
        Me.btImagen.Name = "btImagen"
        Me.btImagen.Size = New System.Drawing.Size(24, 16)
        Me.btImagen.TabIndex = 2
        Me.btImagen.Text = "..."
        Me.btImagen.UseVisualStyleBackColor = False
        '
        'btFirma
        '
        Me.btFirma.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btFirma.Location = New System.Drawing.Point(680, 168)
        Me.btFirma.Name = "btFirma"
        Me.btFirma.Size = New System.Drawing.Size(24, 8)
        Me.btFirma.TabIndex = 2
        Me.btFirma.Text = "..."
        Me.btFirma.UseVisualStyleBackColor = False
        Me.btFirma.Visible = False
        '
        'pbImagen
        '
        Me.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbImagen.Location = New System.Drawing.Point(408, 32)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(112, 120)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 108
        Me.pbImagen.TabStop = False
        '
        'pbFirma
        '
        Me.pbFirma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbFirma.Location = New System.Drawing.Point(424, 32)
        Me.pbFirma.Name = "pbFirma"
        Me.pbFirma.Size = New System.Drawing.Size(80, 64)
        Me.pbFirma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFirma.TabIndex = 105
        Me.pbFirma.TabStop = False
        Me.pbFirma.Visible = False
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(408, 16)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(104, 16)
        Me.Label47.TabIndex = 104
        Me.Label47.Text = "Foto Asociado:"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(24, 208)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(152, 16)
        Me.Label46.TabIndex = 103
        Me.Label46.Text = "*Código Ejecutivo Gestión:"
        '
        'cbEstadoAsoc
        '
        Me.cbEstadoAsoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstadoAsoc.Items.AddRange(New Object() {"(A)ctivo", "(R)etirado", "(I)nhabilitado", "(E)xcluído", "(F)allecido", "(N)inguno", "(G)Reingreso"})
        Me.cbEstadoAsoc.Location = New System.Drawing.Point(120, 32)
        Me.cbEstadoAsoc.Name = "cbEstadoAsoc"
        Me.cbEstadoAsoc.Size = New System.Drawing.Size(136, 22)
        Me.cbEstadoAsoc.TabIndex = 0
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(24, 32)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(104, 16)
        Me.Label40.TabIndex = 101
        Me.Label40.Text = "Estado Asociado:"
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(408, 16)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(48, 16)
        Me.Label42.TabIndex = 98
        Me.Label42.Text = "Firma:"
        Me.Label42.Visible = False
        '
        'txtImagen
        '
        Me.txtImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImagen.Enabled = False
        Me.txtImagen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImagen.Location = New System.Drawing.Point(408, 160)
        Me.txtImagen.MaxLength = 50
        Me.txtImagen.Name = "txtImagen"
        Me.txtImagen.Size = New System.Drawing.Size(272, 20)
        Me.txtImagen.TabIndex = 0
        '
        'txtFirma
        '
        Me.txtFirma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirma.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirma.Location = New System.Drawing.Point(464, 160)
        Me.txtFirma.MaxLength = 50
        Me.txtFirma.Multiline = True
        Me.txtFirma.Name = "txtFirma"
        Me.txtFirma.Size = New System.Drawing.Size(104, 16)
        Me.txtFirma.TabIndex = 1
        Me.txtFirma.Visible = False
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Black
        Me.GroupBox8.Location = New System.Drawing.Point(16, 110)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(704, 1)
        Me.GroupBox8.TabIndex = 117
        Me.GroupBox8.TabStop = False
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(24, 126)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(152, 16)
        Me.Label39.TabIndex = 116
        Me.Label39.Text = "*Código Ejecutivo Gestión:"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(578, 360)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(80, 23)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtEjecMercadeo
        '
        Me.txtEjecMercadeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEjecMercadeo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecMercadeo.Location = New System.Drawing.Point(91, 145)
        Me.txtEjecMercadeo.MaxLength = 100
        Me.txtEjecMercadeo.Name = "txtEjecMercadeo"
        Me.txtEjecMercadeo.ReadOnly = True
        Me.txtEjecMercadeo.Size = New System.Drawing.Size(608, 20)
        Me.txtEjecMercadeo.TabIndex = 119
        '
        'txtCodEjecMercadeo
        '
        Me.txtCodEjecMercadeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEjecMercadeo.Location = New System.Drawing.Point(19, 145)
        Me.txtCodEjecMercadeo.MaxLength = 10
        Me.txtCodEjecMercadeo.Name = "txtCodEjecMercadeo"
        Me.txtCodEjecMercadeo.Size = New System.Drawing.Size(64, 20)
        Me.txtCodEjecMercadeo.TabIndex = 118
        '
        'frmMsAsociados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(776, 440)
        Me.Controls.Add(Me.tb)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAsociados"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   Mantenimiento de Cliente"
        Me.tb.ResumeLayout(False)
        Me.tbDatPer.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatDoc.ResumeLayout(False)
        Me.gbDatDoc.PerformLayout()
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbDatPerProf.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtTotalIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtOtrosIng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.tbGrupoFam.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.nuDGrupoFam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuDNumDep, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbOtros.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbFirma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Declaraciones"

    Public vCorrelativo As Long, vDui As String, vNoSocio As String

#End Region

#Region "Métodos"

#Region "Métodos de Navegación"

    Private Sub btnSigTb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSigTb1.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub

    Private Sub btnSigTb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSigTb2.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub

    Private Sub btnSigTb4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSigTb4.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
    End Sub

    Private Sub btnAtrasTb5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtrasTb5.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub

    Private Sub btnAtrasTb4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtrasTb4.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub

    Private Sub btAtrasTb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAtrasTb2.Click
        Me.tb.SelectedIndex = Me.tb.SelectedIndex() - 1
    End Sub

    Private Sub btnCerrarTb5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarTb5.Click
        Me.Dispose()
    End Sub

    Private Sub btnCerrarTb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarTb3.Click
        Me.Dispose()
    End Sub

    Private Sub btnCerrarTb2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarTb2.Click
        Me.Dispose()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btFirma.Click
        Dim openDlg As OpenFileDialog = New OpenFileDialog
        Dim Resultado As DialogResult
        Try
            openDlg.Filter = "Archivos JPG (*.jpg)|*.jpg|Archivos JPEG (*.jpeg)|*.jpeg|Archivos GIF (*.gif)|(*.gif)|Archivos de mapa de bits (*.bmp)|*.bmp"
            Resultado = openDlg.ShowDialog()
            If Resultado = DialogResult.OK Then
                txtFirma.Text = openDlg.FileName.Remove(0, openDlg.FileName.LastIndexOf("\") + 1)
                pbFirma.Image = System.Drawing.Image.FromFile(openDlg.FileName)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btImagen.Click
        Dim openDlg As OpenFileDialog = New OpenFileDialog
        Dim Resultado As DialogResult
        Try
            openDlg.Filter = "Archivos JPG (*.jpg)|*.jpg|Archivos JPEG (*.jpeg)|*.jpeg|Archivos GIF (*.gif)|(*.gif)|Archivos de mapa de bits (*.bmp)|*.bmp"
            Resultado = openDlg.ShowDialog()

            If Resultado = DialogResult.OK Then
                txtImagen.Text = openDlg.FileName '.Remove(0, openDlg.FileName.LastIndexOf("\") + 1)
                pbImagen.Image = System.Drawing.Image.FromFile(openDlg.FileName)
            End If
        Catch ex As Exception
        End Try
    End Sub

#End Region

    Private Sub CargaDatos()
        Dim Filas As Data.DataRowCollection, oFile As IO.FileStream

        Try
            cbEstadoAsoc.SelectedIndex = 5
            cbEstadoAsoc.Enabled = False
            cbEstadoCivil.SelectedIndex = 0
            cboSexo.SelectedIndex = 0
            cbEstadoVivienda.SelectedIndex = 0

            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
            Dim oPl As New wrPlanilla.wsLibPlanilla
            ds = oAsoc.ConsultarAsociado("*", "Correlativo=" & vCorrelativo & " and Dui='" & vDui & "'", "", sUsuario, sPassword, sSucursal)

            Filas = ds.Tables(0).Rows()

            Me.txtDuiA.Text = Me.txtDui.Text
            If IIf(Filas.Item(0)("Residente") Is DBNull.Value, "0", Filas.Item(0)("Residente")) = "1" Then
                Me.chkResidente.Checked = True
            End If
            txtNoResidente.Text = IIf(Filas.Item(0)("NoResidente") Is DBNull.Value, "", Filas.Item(0)("NoResidente"))
            'txtCodAntiguo.Text = IIf(Filas.Item(0)("CodAntiguo") Is DBNull.Value, "", Filas.Item(0)("CodAntiguo"))
            txtNit.Value = CStr(Filas.Item(0)("Nit"))
            txtIsss.Text = CStr(Filas.Item(0)("Isss"))
            txtLugDui.Text = CStr(Filas.Item(0)("LugarExtDui"))
            dtpFecExtDui.Value = CDate(Filas.Item(0)("FechaExtDui"))
            txtNumPas.Text = IIf(Filas.Item(0)("NumPasaporte") Is DBNull.Value, "", CStr(Filas.Item(0)("NumPasaporte")))
            cbEstado.SelectedIndex = 0
            txtApe1.Text = CStr(Filas.Item(0)("Apellido1"))
            txtApe2.Text = CStr(Filas.Item(0)("Apellido2"))
            txtApe3.Text = CStr(Filas.Item(0)("ApellidoCas"))
            txtNombres.Text = CStr(Filas.Item(0)("Nombres"))
            txtCodNac.Text = CStr(Filas.Item(0)("CodNacionalidad"))
            cboSexo.SelectedIndex = CStr(Filas.Item(0)("Sexo"))
            dtpFecNac.Value = CDate(Filas.Item(0)("Fecha_Nac"))
            txtTelCasa.Text = Filas.Item(0)("TelCasa")
            txtTelOfic.Text = CStr(Filas.Item(0)("TelOficina"))
            txtExtOfic.Text = IIf(CStr(Filas.Item(0)("ExtensionOfic")) Is DBNull.Value, "", (CStr(Filas.Item(0)("ExtensionOfic"))))
            txtDir.Text = CStr(Filas.Item(0)("Direccion"))
            txtCorreo.Text = CStr(Filas.Item(0)("Email"))
            txtCel.Text = CStr(Filas.Item(0)("Celular"))
            txtCodMun.Text = CStr(Filas.Item(0)("CodMunicipio"))
            txtCodDpto.Text = CStr(Filas.Item(0)("CodDepartamento"))
            txtCodProf.Text = CStr(Filas.Item(0)("CodProfesion"))
            txtTitulo.Text = CStr(Filas.Item(0)("TituloObtenido"))
            nuDNumDep.Value = CStr(Filas.Item(0)("NumDependientes"))
            nuDGrupoFam.Value = CStr(Filas.Item(0)("NumGrupoFam"))
            cbEstadoCivil.SelectedIndex = CStr(Filas.Item(0)("EstadoCivil"))
            txtConyugue.Text = CStr(Filas.Item(0)("NombreConyugue"))

            If Not (Filas.Item(0)("EstadoVivienda") Is DBNull.Value) Then
                cbEstadoVivienda.SelectedIndex = CStr(Filas.Item(0)("EstadoVivienda"))
            Else
                cbEstadoVivienda.SelectedIndex = 0
            End If


            txtLugTrab.Text = CStr(Filas.Item(0)("LugarTrabajo"))
            txtDptoTrabajo.Text = CStr(Filas.Item(0)("DepartamentoTrabajo"))
            txtDirTrab.Text = CStr(Filas.Item(0)("DireccionTrabajo"))
            dtpFecIniTrab.Value = CStr(Filas.Item(0)("FechaInicioTrab"))
            txtSalario.Value = CStr(Filas.Item(0)("Salario"))
            txtCargo.Text = CStr(Filas.Item(0)("Cargo"))

            If CStr(Filas.Item(0)("TrabajoPropio")) = 0 Then
                chkTrabPropio.Checked = False
            ElseIf CStr(Filas.Item(0)("TrabajoPropio")) = 1 Then
                chkTrabPropio.Checked = True
            End If

            txtOtrosIng.Value = CStr(Filas.Item(0)("OtrosIngresos"))
            txtOrigIng.Text = CStr(Filas.Item(0)("OrigenOtrosIngresos"))
            Me.txtTotalIngresos.Value = Me.txtSalario.Value + Me.txtOtrosIng.Value



            txtTipoAct.Text = CStr(Filas.Item(0)("TipoActividad"))
            cbEstadoAsoc.SelectedIndex = 6
            Me.txtFecha.Text = Now.ToShortDateString
            txtFirma.Text = CStr(Filas.Item(0)("Firmas"))
            txtImagen.Text = CStr(Filas.Item(0)("Imagen"))

            If Trim(Me.txtImagen.Text) <> "" Then
                oFile = New FileStream(Trim(Me.txtImagen.Text), FileMode.Open, FileAccess.Read, FileShare.Read)
                Me.pbImagen.Image = Image.FromStream(oFile)
                oFile.Close()
            End If

            txtCodEjecMercadeo.Text = CStr(Filas.Item(0)("CodEjecMercadeo"))
            If Not (Filas.Item(0)("CodEjecApertura") Is DBNull.Value) Then
                txtCodEjecApertura.Text = CStr(Filas.Item(0)("CodEjecApertura"))
            Else
                txtCodEjecApertura.Text = ""
            End If
            txtGiro.Text = CStr(Filas.Item(0)("Giro"))
            txtRegFiscal.Text = CStr(Filas.Item(0)("RegistroFiscal"))
            If CStr(Filas.Item(0)("EstadoIngreso")) = "0" Then
                If Not (Filas.Item(0)("Observaciones_Candidato") Is DBNull.Value) Then
                    Me.txtObservaciones.Text = CStr(Filas.Item(0)("Observaciones_Candidato"))
                End If
            ElseIf CStr(Filas.Item(0)("EstadoIngreso")) = "1" Then
                If Not (Filas.Item(0)("Observaciones_Aspirante") Is DBNull.Value) Then
                    Me.txtObservaciones.Text = CStr(Filas.Item(0)("Observaciones_Aspirante"))
                End If
            ElseIf CStr(Filas.Item(0)("EstadoIngreso")) = "2" Then
                If Not (Filas.Item(0)("Observaciones_Asociado") Is DBNull.Value) Then
                    Me.txtObservaciones.Text = CStr(Filas.Item(0)("Observaciones_Asociado"))
                End If
            End If
            If Not (Filas.Item(0)("TiempoResidencia") Is DBNull.Value) Then
                txtTiempoResidencia.Text = CStr(Filas.Item(0)("TiempoResidencia"))
            Else
                txtTiempoResidencia.Text = ""
            End If

            ds = oAsoc.ConsultarMunicipios("*", "CodMunicipio='" & Trim(Me.txtCodMun.Text) & "' and CodDepartamento='" & Trim(Me.txtCodDpto.Text) & "'", "", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                If Not (Filas.Item(0)("Municipio") Is DBNull.Value) Then
                    Me.txtMunicipio.Text = CStr(Filas.Item(0)("Municipio"))
                End If
            End If

            ds = oAsoc.ConsultarDepartamentos("*", "CodDepartamento='" & Trim(Me.txtCodDpto.Text) & "'", "", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                If Not (Filas.Item(0)("Departamento") Is DBNull.Value) Then
                    Me.txtDpto.Text = CStr(Filas.Item(0)("Departamento"))
                End If
            End If

            ds = oAsoc.ConsultarNacionalidades("*", "CodNacionalidad='" & Trim(Me.txtCodNac.Text) & "'", "", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                    Me.txtNacionalidad.Text = CStr(Filas.Item(0)("Descripcion"))
                End If
            End If

            ds = oAsoc.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecMercadeo.Text) & "'", "", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                    Me.txtEjecMercadeo.Text = CStr(Filas.Item(0)("CodEmpleado"))
                    ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecMercadeo.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        txtEjecMercadeo.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                    End If
                End If
            End If

            ds = oAsoc.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecApertura.Text) & "'", "", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                    Me.txtEjecApertura.Text = CStr(Filas.Item(0)("CodEmpleado"))
                    ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecApertura.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        txtEjecApertura.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                    End If
                End If
            End If

            ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(Me.txtCodProf.Text) & "'", "", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                    Me.txtProf.Text = CStr(Filas.Item(0)("Descripcion"))
                End If
            End If



        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub frmMsAsociados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Filas As Data.DataRowCollection, oFile As IO.FileStream

        Try
            txtDui.TabIndex = 0
            cbEstadoAsoc.SelectedIndex = 5
            cbEstadoAsoc.Enabled = False
            cbEstadoCivil.SelectedIndex = 0
            cboSexo.SelectedIndex = 0
            cbEstadoVivienda.SelectedIndex = 0
            cbEstado.SelectedIndex = 2
            Me.cbEstado.Visible = False
            Me.cbEstadoAsoc.Visible = False
            tbOtros.Parent = Nothing


            If Me.btnGuardar.Text = "&Modificar" Then

                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
                Dim oPl As New wrPlanilla.wsLibPlanilla
                ds = oAsoc.ConsultarAsociado("*", "Correlativo=" & vCorrelativo & " and Dui='" & vDui & "'", "", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()

                txtDui.Value = vDui
                Me.txtDuiA.Text = Me.txtDui.Text
                txtNoSocio.Text = vNoSocio
                If IIf(Filas.Item(0)("Residente") Is DBNull.Value, "0", Filas.Item(0)("Residente")) = "1" Then
                    Me.chkResidente.Checked = True
                End If
                txtNoResidente.Text = IIf(Filas.Item(0)("NoResidente") Is DBNull.Value, "", Filas.Item(0)("NoResidente"))
                'txtCodAntiguo.Text = IIf(Filas.Item(0)("CodAntiguo") Is DBNull.Value, "", Filas.Item(0)("CodAntiguo"))
                txtNit.Value = CStr(Filas.Item(0)("Nit"))
                txtIsss.Text = CStr(Filas.Item(0)("Isss"))
                txtLugDui.Text = CStr(Filas.Item(0)("LugarExtDui"))
                dtpFecExtDui.Value = CDate(Filas.Item(0)("FechaExtDui"))
                txtNumPas.Text = IIf(Filas.Item(0)("NumPasaporte") Is DBNull.Value, "", CStr(Filas.Item(0)("NumPasaporte")))
                cbEstado.SelectedIndex = CStr(Filas.Item(0)("EstadoIngreso"))
                txtApe1.Text = CStr(Filas.Item(0)("Apellido1"))
                txtApe2.Text = CStr(Filas.Item(0)("Apellido2"))
                txtApe3.Text = CStr(Filas.Item(0)("ApellidoCas"))
                txtNombres.Text = CStr(Filas.Item(0)("Nombres"))
                txtCodNac.Text = CStr(Filas.Item(0)("CodNacionalidad"))
                cboSexo.SelectedIndex = CStr(Filas.Item(0)("Sexo"))
                dtpFecNac.Value = CDate(Filas.Item(0)("Fecha_Nac"))
                txtTelCasa.Text = Filas.Item(0)("TelCasa")
                txtTelOfic.Text = CStr(Filas.Item(0)("TelOficina"))
                txtExtOfic.Text = IIf(CStr(Filas.Item(0)("ExtensionOfic")) Is DBNull.Value, "", (CStr(Filas.Item(0)("ExtensionOfic"))))
                txtDir.Text = CStr(Filas.Item(0)("Direccion"))
                txtCorreo.Text = CStr(Filas.Item(0)("Email"))
                txtCel.Text = CStr(Filas.Item(0)("Celular"))
                txtCodMun.Text = CStr(Filas.Item(0)("CodMunicipio"))
                txtCodDpto.Text = CStr(Filas.Item(0)("CodDepartamento"))
                txtCodProf.Text = CStr(Filas.Item(0)("CodProfesion"))
                txtTitulo.Text = CStr(Filas.Item(0)("TituloObtenido"))
                nuDNumDep.Value = CStr(Filas.Item(0)("NumDependientes"))
                nuDGrupoFam.Value = CStr(Filas.Item(0)("NumGrupoFam"))
                cbEstadoCivil.SelectedIndex = CStr(Filas.Item(0)("EstadoCivil"))
                txtConyugue.Text = CStr(Filas.Item(0)("NombreConyugue"))

                If Not (Filas.Item(0)("EstadoVivienda") Is DBNull.Value) Then
                    cbEstadoVivienda.SelectedIndex = CStr(Filas.Item(0)("EstadoVivienda"))
                Else
                    cbEstadoVivienda.SelectedIndex = 0
                End If



                txtLugTrab.Text = CStr(Filas.Item(0)("LugarTrabajo"))
                txtDptoTrabajo.Text = CStr(Filas.Item(0)("DepartamentoTrabajo"))
                txtDirTrab.Text = CStr(Filas.Item(0)("DireccionTrabajo"))
                dtpFecIniTrab.Value = CStr(Filas.Item(0)("FechaInicioTrab"))
                txtSalario.Value = CStr(Filas.Item(0)("Salario"))
                txtCargo.Text = CStr(Filas.Item(0)("Cargo"))

                If CStr(Filas.Item(0)("TrabajoPropio")) = 0 Then
                    chkTrabPropio.Checked = False
                ElseIf CStr(Filas.Item(0)("TrabajoPropio")) = 1 Then
                    chkTrabPropio.Checked = True
                End If



                txtOtrosIng.Value = CStr(Filas.Item(0)("OtrosIngresos"))
                txtOrigIng.Text = CStr(Filas.Item(0)("OrigenOtrosIngresos"))
                Me.txtTotalIngresos.Value = Me.txtSalario.Value + Me.txtOtrosIng.Value
                txtTipoAct.Text = CStr(Filas.Item(0)("TipoActividad"))
                cbEstadoAsoc.SelectedIndex = CStr(Filas.Item(0)("EstadoAsociado"))

                If Not (Filas.Item(0)("FechaEstado") Is DBNull.Value) Then
                    Me.txtFecha.Text = CStr(Filas.Item(0)("FechaEstado"))
                End If

                txtFirma.Text = CStr(Filas.Item(0)("Firmas"))
                txtImagen.Text = CStr(Filas.Item(0)("Imagen"))

                If Trim(Me.txtImagen.Text) <> "" Then
                    oFile = New FileStream(Trim(Me.txtImagen.Text), FileMode.Open, FileAccess.Read, FileShare.Read)
                    Me.pbImagen.Image = Image.FromStream(oFile)
                    oFile.Close()
                End If

                txtCodEjecMercadeo.Text = CStr(Filas.Item(0)("CodEjecMercadeo"))

                If Not (Filas.Item(0)("CodEjecApertura") Is DBNull.Value) Then
                    txtCodEjecApertura.Text = CStr(Filas.Item(0)("CodEjecApertura"))
                Else
                    txtCodEjecApertura.Text = ""
                End If

                txtGiro.Text = CStr(Filas.Item(0)("Giro"))
                txtRegFiscal.Text = CStr(Filas.Item(0)("RegistroFiscal"))

                If CStr(Filas.Item(0)("EstadoIngreso")) = "0" Then
                    If Not (Filas.Item(0)("Observaciones_Candidato") Is DBNull.Value) Then
                        Me.txtObservaciones.Text = CStr(Filas.Item(0)("Observaciones_Candidato"))
                    End If
                ElseIf CStr(Filas.Item(0)("EstadoIngreso")) = "1" Then
                    If Not (Filas.Item(0)("Observaciones_Aspirante") Is DBNull.Value) Then
                        Me.txtObservaciones.Text = CStr(Filas.Item(0)("Observaciones_Aspirante"))
                    End If
                ElseIf CStr(Filas.Item(0)("EstadoIngreso")) = "2" Then
                    If Not (Filas.Item(0)("Observaciones_Asociado") Is DBNull.Value) Then
                        Me.txtObservaciones.Text = CStr(Filas.Item(0)("Observaciones_Asociado"))
                    End If
                End If

                If Not (Filas.Item(0)("TiempoResidencia") Is DBNull.Value) Then
                    txtTiempoResidencia.Text = CStr(Filas.Item(0)("TiempoResidencia"))
                Else
                    txtTiempoResidencia.Text = ""
                End If

                ds = oAsoc.ConsultarMunicipios("*", "CodMunicipio='" & Trim(Me.txtCodMun.Text) & "' and CodDepartamento='" & Trim(Me.txtCodDpto.Text) & "'", "", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Municipio") Is DBNull.Value) Then
                        Me.txtMunicipio.Text = CStr(Filas.Item(0)("Municipio"))
                    End If
                End If

                ds = oAsoc.ConsultarDepartamentos("*", "CodDepartamento='" & Trim(Me.txtCodDpto.Text) & "'", "", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Departamento") Is DBNull.Value) Then
                        Me.txtDpto.Text = CStr(Filas.Item(0)("Departamento"))
                    End If
                End If

                ds = oAsoc.ConsultarNacionalidades("*", "CodNacionalidad='" & Trim(Me.txtCodNac.Text) & "'", "", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                        Me.txtNacionalidad.Text = CStr(Filas.Item(0)("Descripcion"))
                    End If
                End If

                ds = oAsoc.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecMercadeo.Text) & "'", "", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                        Me.txtEjecMercadeo.Text = CStr(Filas.Item(0)("CodEmpleado"))
                        ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecMercadeo.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            txtEjecMercadeo.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                        End If
                    End If
                End If

                ds = oAsoc.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecApertura.Text) & "'", "", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                        Me.txtEjecApertura.Text = CStr(Filas.Item(0)("CodEmpleado"))
                        ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecApertura.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            txtEjecApertura.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                        End If
                    End If
                End If

                ds = oAsoc.ConsultarProfesiones("*", "CodProfesion='" & Trim(Me.txtCodProf.Text) & "'", "", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                        Me.txtProf.Text = CStr(Filas.Item(0)("Descripcion"))
                    End If
                End If


                '=========================================================================
                '18/04/2012 Javier Escobar
                'Deshabilitamos el control para que no puedan modificar al ejecutivo
                Me.txtCodEjecApertura.ReadOnly = True
                Me.txtCodEjecApertura.Enabled = False
                Me.txtCodEjecMercadeo.ReadOnly = True
                Me.txtCodEjecMercadeo.Enabled = False
                Me.txtEjecApertura.Enabled = False
                Me.txtEjecMercadeo.Enabled = False
                '=========================================================================
                '--------------------------------------------------------------------------------------------
                '++++++++++++++++++++++++++ Mostrar Observaciones del Asociado ++++++++++++++++++++++++++++++
                'Dim drEstado, drObs As DataRow, dsObs As New Data.DataSet
                'Dim Estado As Integer
                'ds = oAsoc.ConsultarAsociado("EstadoIngreso", "Correlativo=" & vCorrelativo & " and Dui='" & vDui & "'", "", sUsuario, sPassword,sSucursal)
                'drEstado = ds.Tables(0).Rows(0)
                'If drEstado("EstadoIngreso") = 0 Then
                '    Estado = 0
                '    dsObs = oAsoc.ConsultarObservacionesAsociado("" & Estado & "", sUsuario, sPassword,sSucursal)
                'ElseIf drEstado("EstadoIngreso") = 1 Then
                '    Estado = 1
                '    dsObs = oAsoc.ConsultarObservacionesAsociado("" & Estado & "", sUsuario, sPassword,sSucursal)
                'ElseIf drEstado("EstadoIngreso") = 2 Then
                '    Estado = 2
                '    dsObs = oAsoc.ConsultarObservacionesAsociado("" & Estado & "", sUsuario, sPassword,sSucursal)
                'End If
                'drObs = dsObs.Tables(0).Rows(0)
                'Me.txtObservaciones.Text = drObs(0)

            End If
            txtDui.Focus()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    

    Private Sub HabilitaControles()

        Dim ctTb As Control, ct As Control, vText As Control

        For Each ctTb In Me.tb.Controls
            For Each ct In ctTb.Controls
                For Each vText In ct.Controls
                    If vText.GetType.Name = "TextBox" Then
                        Dim oText As TextBox
                        oText = CType(vText, TextBox)
                        oText.Text = ""
                    End If
                Next
            Next
        Next
        cbEstado.SelectedIndex = 0
        cbEstadoAsoc.SelectedIndex = 0
        cbEstadoCivil.SelectedIndex = 0
        cboSexo.SelectedIndex = 0

    End Sub

    Private Sub txtCodNac_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodNac.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Nacionalidad"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarNacionalidades("*", "", "CodNacionalidad", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodNac.Text = ofrm.Resultado.Trim
            txtNacionalidad.Text = ofrm.Resultado2.Trim
            cboSexo.Focus()
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Nacionalidades - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodNac_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodNac.KeyPress

        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                oPerif = New wrAsociados.wsLibAsoc
                ds = oPerif.ConsultarNacionalidades("*", "CodNacionalidad='" & Trim(txtCodNac.Text) & "'", "CodNacionalidad", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                        txtNacionalidad.Text = CStr(Filas.Item(0)("Descripcion"))
                        cboSexo.Focus()
                    End If
                Else
                    txtCodNac_DoubleClick(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Nacionalidades - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodProf_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodProf.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Profesiones"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarProfesiones("*", "", "CodProfesion", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodProf.Text = ofrm.Resultado.Trim
            txtProf.Text = ofrm.Resultado2.Trim
            txtTitulo.Focus()
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Profesiones - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodProf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodProf.KeyPress
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                oPerif = New wrAsociados.wsLibAsoc
                ds = oPerif.ConsultarProfesiones("*", "CodProfesion='" & Trim(Me.txtCodProf.Text) & "'", "CodProfesion", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                        txtProf.Text = CStr(Filas.Item(0)("Descripcion"))
                        txtTitulo.Focus()
                    End If
                Else
                    txtCodProf_DoubleClick(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Cuerpos Profesiones - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub txtCodEjecMercadeo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmAGenerico
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet

        ofrm.Text = "Buscar Ejecutivos de Mercadeo"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Try
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarEjecutivosMercadeoxNombre("", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodEjecMercadeo.Text = ofrm.Resultado.Trim
            txtEjecMercadeo.Text = ofrm.Resultado2.Trim
            txtGiro.Focus()
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Ejecutivos Mercadeo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodEjecMercadeo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Dim oPl As New wrPlanilla.wsLibPlanilla
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                ds = oPerif.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(txtCodEjecMercadeo.Text) & "'", "CodEjecMercadeo", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                        txtCodEjecMercadeo.Text = CStr(Filas.Item(0)("CodEjecMercadeo"))
                        txtEjecMercadeo.Text = CStr(Filas.Item(0)("CodEmpleado"))
                        ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecMercadeo.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            txtEjecMercadeo.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                        End If
                        txtGiro.Focus()
                    End If
                Else
                    txtCodEjecMercadeo_DoubleClick(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Ejecutivos Mercadeo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar.Equals("-"c) Or Char.IsControl(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtIsss_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIsss.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or Char.IsControl(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNoSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSocio.KeyPress
        If Char.IsNumber(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub cboSexo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSexo.SelectedIndexChanged
        If cboSexo.SelectedIndex = 1 Then
            txtApe3.Text = ""
            txtApe3.Enabled = False
        Else
            txtApe3.Text = ""
            txtApe3.Enabled = True
        End If
    End Sub



#End Region

    Private Sub txtNoResidente_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoResidente.LostFocus
        If Me.txtNoResidente.Text.Trim <> "" And Me.chkResidente.Checked = True Then Me.txtDui.Value = Me.txtNoResidente.Text.Trim & "-1"
    End Sub

    Private Sub chkResidente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkResidente.CheckedChanged
        If Me.chkResidente.Checked = True Then
            Me.txtNoResidente.ReadOnly = False
            Me.txtLugDui.ReadOnly = True
            Me.dtpFecExtDui.Enabled = False
        Else
            Me.txtNoResidente.ReadOnly = True
            Me.txtNoResidente.Text = ""
            Me.txtLugDui.ReadOnly = False
            Me.dtpFecExtDui.Enabled = True
        End If
    End Sub

    Private Sub cbEstadoCivil_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEstadoCivil.SelectedIndexChanged
        If cbEstadoCivil.SelectedIndex = 0 Or cbEstadoCivil.SelectedIndex = 2 Or cbEstadoCivil.SelectedIndex = 4 Then
            txtConyugue.Text = ""
            txtConyugue.Enabled = False
        Else
            txtConyugue.Text = ""
            txtConyugue.Enabled = True
        End If
    End Sub

    Private Sub txtCodDpto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodDpto.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Departamentos"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarDepartamentos("*", "", "CodDepartamento", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodDpto.Text = ofrm.Resultado.Trim
            txtDpto.Text = ofrm.Resultado2.Trim
            Me.txtCodMun.Text = ""
            Me.txtMunicipio.Text = ""
            txtCodMun.Focus()
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Departamentos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodDpto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodDpto.KeyPress
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                oPerif = New wrAsociados.wsLibAsoc
                ds = oPerif.ConsultarDepartamentos("*", "CodDepartamento='" & Trim(txtCodDpto.Text) & "'", "CodDepartamento", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Departamento") Is DBNull.Value) Then
                        txtDpto.Text = CStr(Filas.Item(0)("Departamento"))
                        Me.txtCodMun.Text = ""
                        Me.txtMunicipio.Text = ""
                        txtCodMun.Focus()
                    End If
                Else
                    txtCodDpto_DoubleClick(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Departamentos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodMun_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodMun.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Municipios"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oPerif = New wrAsociados.wsLibAsoc
            If Trim(Me.txtCodDpto.Text) <> "" Then
                ds = oPerif.ConsultarMunicipios("*", "CodDepartamento='" & Trim(Me.txtCodDpto.Text) & "'", "CodMunicipio", sUsuario, sPassword, sSucursal)
            Else
                ds = oPerif.ConsultarMunicipios("*", "", "CodDepartamento,CodMunicipio", sUsuario, sPassword, sSucursal)
            End If
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodMun.Text = ofrm.Resultado2.Trim
            txtMunicipio.Text = ofrm.Resultado3.Trim
            txtCodProf.Focus()
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Municipios - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodMun_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodMun.KeyPress
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                oPerif = New wrAsociados.wsLibAsoc
                ds = oPerif.ConsultarMunicipios("*", "CodDepartamento ='" & Trim(txtCodDpto.Text) & "' and  CodMunicipio='" & Trim(txtCodMun.Text) & "'", "CodMunicipio", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Municipio") Is DBNull.Value) Then
                        txtMunicipio.Text = CStr(Filas.Item(0)("Municipio"))
                        txtCodProf.Focus()
                    End If
                Else
                    txtCodMun_DoubleClick(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Municipios  - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSalario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSalario.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar.Equals("."c) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtOtrosIng_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOtrosIng.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar.Equals("."c) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtRegFiscal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRegFiscal.KeyPress
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back) Or e.KeyChar = "-"c Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCodEjecApertura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEjecApertura.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Try
                Dim oPl As New wrPlanilla.wsLibPlanilla
                Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection

                oPerif = New wrAsociados.wsLibAsoc
                ds = oPerif.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecApertura.Text) & "'", "CodEjecMercadeo", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                        Me.txtEjecApertura.Text = CStr(Filas.Item(0)("CodEmpleado"))
                        ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecApertura.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            Me.txtEjecApertura.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                            Me.txtObservaciones.Focus()
                        End If
                    End If
                Else
                    txtCodEjecApertura_DoubleClick(sender, e)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtCodEjecApertura_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEjecApertura.DoubleClick
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
            txtCodEjecApertura.Text = ofrm.Resultado.Trim
            txtEjecApertura.Text = ofrm.Resultado2.Trim
            Me.txtObservaciones.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        Try


            'Habilitamos los controles
            '====================================
            'Tab1
            Me.chkResidente.Enabled = True
            Me.txtNoResidente.Enabled = True
            Me.txtCodNac.Enabled = True
            Me.cbEstado.Enabled = True
            Me.txtLugDui.Enabled = True
            Me.dtpFecExtDui.Enabled = True
            Me.txtNumPas.Enabled = True
            Me.txtDuiA.Enabled = True
            Me.txtNoSocio.Enabled = True

            Me.txtNombres.Enabled = True
            Me.txtApe1.Enabled = True
            Me.txtApe2.Enabled = True
            Me.cboSexo.Enabled = True
            Me.cbEstadoCivil.Enabled = True
            Me.txtApe3.Enabled = True
            Me.txtNit.Enabled = True
            Me.txtIsss.Enabled = True
            Me.txtDir.Enabled = True
            Me.dtpFecNac.Enabled = True
            Me.txtTelCasa.Enabled = True
            Me.txtCel.Enabled = True
            Me.txtCodDpto.Enabled = True
            Me.txtCodMun.Enabled = True
            Me.txtCorreo.Enabled = True
            '====================================
            'Tab2
            Me.txtCodProf.Enabled = True
            Me.txtTitulo.Enabled = True
            Me.txtLugTrab.Enabled = True
            Me.dtpFecIniTrab.Enabled = True
            Me.txtDptoTrabajo.Enabled = True
            Me.txtCargo.Enabled = True
            Me.txtSalario.Enabled = True
            Me.txtTotalIngresos.Enabled = True

            Me.chkTrabPropio.Enabled = True
            Me.txtGiro.Enabled = True
            Me.txtRegFiscal.Enabled = True
            Me.txtTipoAct.Enabled = True
            Me.txtOtrosIng.Enabled = True
            Me.txtOrigIng.Enabled = True
            '====================================
            'Tab3
            Me.txtConyugue.Enabled = True
            Me.nuDNumDep.Enabled = True
            Me.nuDGrupoFam.Enabled = True
            Me.cbEstadoVivienda.Enabled = True
            Me.txtTiempoResidencia.Enabled = True

            '====================================
            'Tab4
            Me.cbEstadoAsoc.Enabled = True
            Me.txtFecha.Enabled = True
            Me.txtCodEjecApertura.Enabled = True
            Me.txtCodEjecMercadeo.Enabled = True
            Me.txtObservaciones.Enabled = True
            Me.btnGuardar.Enabled = True
            '=========================================
            If Me.btnGuardar.Text = "&Guardar" Then
                Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet, dr As DataRow

                ds = oAsoc.ConsultarAsociado("Correlativo,Dui,EstadoAsociado", "Dui='" & Me.txtDui.Value & "'", "Dui", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    If dr("EstadoAsociado") = "1" Then 'Retirado
                       
                    Else
                        MessageBox.Show("Este Dui ya se encuentra asignado, verifique!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                Else
                    Me.txtDuiA.Text = Me.txtDui.Text
                End If
            Else
                Me.txtDuiA.Text = Me.txtDui.Text
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub txtDuiA_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDuiA.Click
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

    Private Sub txtSalario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSalario.LostFocus
        Me.txtTotalIngresos.Value = Me.txtSalario.Value + Me.txtOtrosIng.Value
    End Sub

    Private Sub txtOtrosIng_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOtrosIng.LostFocus
        Me.txtTotalIngresos.Value = Me.txtSalario.Value + Me.txtOtrosIng.Value
    End Sub

    'Private Sub cbEstadoLaboral_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbEstadoLaboral.SelectedIndexChanged
    '    If cbEstadoLaboral.SelectedIndex = 0 Or cbEstadoLaboral.SelectedIndex = 1 Or cbEstadoLaboral.SelectedIndex = 2 Or cbEstadoLaboral.SelectedIndex = 3 Then
    '        cbEstadoLaboral.SelectedIndex = CInt("")
    '        cbEstadoLaboral.Enabled = False
    '    Else
    '        cbEstadoLaboral.SelectedIndex = CInt("")
    '        cbEstadoLaboral.Enabled = True
    '    End If
    'End Sub

   
    Private Sub btnGuardar_Click1(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String, pCodCuerpoDir As String, ds As New DataSet, vNoResidente As String, vSalarioMinimo As Double, dr As DataRow, oApp As New wrAdmin.wsLibAdmin

        Try

            Select Case oAsoc.AutorizaDatos(txtDui.Text, Me.txtNit.Text, "x", txtApe1.Text, txtNombres.Text)
                Case 1
                    MsgBox("El campo Dui del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Clientes")
                    Exit Sub
                Case 2
                    MsgBox("El campo Nit del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Clientes")
                    Exit Sub
                Case 4
                    MsgBox("El campo Apellido del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Clientes")
                    Exit Sub
                Case 5
                    MsgBox("El campo Nombres del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Clientes")
                    Exit Sub
            End Select
            If txtCodEjecMercadeo.Text.Trim = "" Then
                MsgBox("El campo código de ejecutivo no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Clientes")
                Exit Sub
            End If
            If txtCodProf.Text.Trim = "" Then
                MsgBox("El campo profesión no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Clientes")
                Exit Sub
            End If

            'ds = oAsoc.ConsultarParametros("*", "", "SalarioMinimo", sUsuario, sPassword,sSucursal)
            'If ds.Tables(0).Rows.Count > 0 Then
            '    dr = ds.Tables(0).Rows(0)
            '    vSalarioMinimo = IIf(dr("SalarioMinimo") Is DBNull.Value, 0, dr("SalarioMinimo"))
            'Else
            '    vSalarioMinimo = 0
            'End If
            'If Me.txtTotalIngresos.Value < vSalarioMinimo Then
            '    MessageBox.Show("La suma de Ingresos debe ser mayor o igual que el salario mínimo.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            'ds.Clear()

            'pCodCuerpoDir = "00"
            'If Trim(txtCodCuerpoDir.Text) <> "" Then pCodCuerpoDir = txtCodCuerpoDir.Text

            If Me.chkResidente.Checked = True Then
                vNoResidente = Me.txtNoResidente.Text.Trim
            Else
                vNoResidente = ""
            End If

            '--------------------------------------------------------------------------------------------
            '++++++++++++++++++++++++++ ingresar Observaciones del Asociado ++++++++++++++++++++++++++++++

            If Me.btnGuardar.Text = "&Guardar" Then

                If oAsoc.VerificaNit(Me.txtNit.Text, sUsuario, sPassword, sSucursal) = True Then
                    MessageBox.Show("El Nit ya se encuentra ingresado, verifique.", "Módulo Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                vCorrelativo = oAsoc.ObtenerCorrelativoAsociado("Correlativo", sUsuario, sPassword, sSucursal)
                If Me.cbEstado.SelectedIndex = 2 Then
                    pCampos = "DUI,Correlativo,NIT,ISSS," & _
                    "LugarExtDui,FechaExtDui," & _
                    "NumPasaporte,EstadoIngreso, " & _
                    "Apellido1,Apellido2, " & _
                    "ApellidoCas,Nombres,  " & _
                    "Fecha_Nac,Direccion, " & _
                    "TelCasa,TelOficina, " & _
                    "ExtensionOfic,Celular, " & _
                    "Email,CodProfesion, " & _
                    "TituloObtenido,CodNacionalidad, " & _
                    "LugarTrabajo,DepartamentoTrabajo, " & _
                    "FechaInicioTrab,DireccionTrabajo, " & _
                    "Cargo,Salario, " & _
                    "EstadoCivil,NombreConyugue, " & _
                    "NumGrupoFam,NumDependientes, " & _
                    "EstadoVivienda,TrabajoPropio, " & _
                    "TipoActividad,OtrosIngresos," & _
                    "OrigenOtrosIngresos,CodMunicipio, " & _
                    "CodDepartamento,EstadoAsociado, " & _
                    "CodEjecMercadeo,Imagen, " & _
                    "Firmas,Sexo, " & _
                    "RegistroFiscal,Giro," & _
                    "Observaciones_Asociado,Residente," & _
                    "NoResidente,CodEjecApertura, " & _
                    "TiempoResidencia,FechaEstado"
                    pValores = "'" & Trim(txtDui.Text) & "'," & vCorrelativo & _
                    ",'" & Trim(txtNit.Text) & "','" & Trim(txtIsss.Text) & _
                    "','" & Trim(txtLugDui.Text) & "','" & Format(dtpFecExtDui.Value, "Short date") & _
                    "','" & Trim(txtNumPas.Text) & "','" & cbEstado.SelectedIndex & _
                    "','" & Trim(txtApe1.Text.ToUpper) & "','" & Trim(txtApe2.Text.ToUpper) & _
                    "','" & Trim(txtApe3.Text.ToUpper) & "','" & Trim(txtNombres.Text.ToUpper) & _
                    "','" & Format(dtpFecNac.Value, "short date") & _
                    "','" & Trim(txtDir.Text) & "','" & Trim(txtTelCasa.Text) & _
                    "','" & Trim(txtTelOfic.Text) & "','" & Trim(txtExtOfic.Text) & _
                    "','" & Trim(txtCel.Text) & "','" & Trim(txtCorreo.Text) & _
                    "','" & Trim(txtCodProf.Text) & "','" & Trim(txtTitulo.Text) & _
                    "','" & Trim(txtCodNac.Text) & "','" & Trim(txtLugTrab.Text) & _
                    "','" & Trim(txtDptoTrabajo.Text) & "','" & Format(dtpFecIniTrab.Value, "short date") & _
                    "','" & Trim(txtDirTrab.Text) & "','" & Trim(txtCargo.Text) & _
                    "','" & Val(txtSalario.Value) & "','" & cbEstadoCivil.SelectedIndex & _
                    "','" & Trim(txtConyugue.Text) & "','" & nuDGrupoFam.Value & _
                    "','" & nuDNumDep.Value & "','" & cbEstadoVivienda.SelectedIndex & _
                    "','" & System.Math.Abs(CInt(chkTrabPropio.Checked)) & "','" & Trim(txtTipoAct.Text) & _
                    "','" & Val(txtOtrosIng.Value) & "','" & Trim(txtOrigIng.Text) & _
                    "','" & Trim(txtCodMun.Text) & "','" & Trim(txtCodDpto.Text) & _
                    "','0','" & Trim(txtCodEjecMercadeo.Text) & _
                    "','" & Trim(txtImagen.Text) & "','" & Trim(txtFirma.Text) & _
                    "','" & cboSexo.SelectedIndex & "','" & Trim(txtRegFiscal.Text) & _
                    "','" & Trim(txtGiro.Text) & "','" & Trim(Me.txtObservaciones.Text) & _
                    "','" & IIf(Me.chkResidente.Checked = True, "1", "0") & "','" & vNoResidente & _
                    "','" & Me.txtCodEjecMercadeo.Text.Trim & "','" & txtTiempoResidencia.Text.Trim & _
                    "','" & Format(Now, "Short date") & "'"
                End If

                If oAsoc.InsertarAsociado(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    'pCampos = "NoSocio,DUI,DocumentosCompletos,Fotografias,TituloFotocop,DUIFotocop,NITFotocop,ReciboCuotaInicial,OtrosDescripcion,Otros,Observaciones,FechaCharla,Aprobado,FechaAprob,UsuarioAutoriza,FechaAutoriza,UsuarioGerenciaAutoriza,FecUsuGerenciaAutoriza,FecResolucionConsejo,Resolucion,Obs,ActaNo,FechaActa,ActivarAsociado,UsuarioActiva,FechaUsuarioActiva,ArchivoVinculoActa,Procesada"
                    'pValores = "'" & Me.txtNoSocio.Text.Trim & "','" & Trim(txtDui.Text) & "','0','0','0','0','0','','','0','','" & Date.Today & "','0','" & Date.Today & "','" & sUsuario & "','" & Date.Today & "','" & sUsuario & "','" & Date.Today & "','" & Date.Today & "','','','','" & Date.Today & "','0','" & sUsuario & "','" & Date.Today & "','','0'"
                    'oAsoc.InsertarEstadoIngreso(pCampos, pValores, sUsuario, sPassword, sSucursal)
                    MsgBox("El Cliente ha sido agregado.", MsgBoxStyle.Information)
                    HabilitaControles()
                    Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                    Me.Dispose()
                Else
                    MsgBox("El Cliente NO ha sido agregado. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Clientes")
                End If
            ElseIf Me.btnGuardar.Text = "&Modificar" Then

                'SE AGREGO EL CAMPO ESTADO LABORAL 
                If Me.cbEstado.SelectedIndex = 2 Then 'Asociado
                    pCampos = "NIT='" & Trim(txtNit.Text) & _
                    "',ISSS='" & Trim(txtIsss.Text) & _
                    "',LugarExtDui='" & Trim(txtLugDui.Text) & _
                    "',FechaExtDui='" & Format(dtpFecExtDui.Value, "short date") & _
                    "',NumPasaporte='" & Trim(txtNumPas.Text) & _
                    "',Apellido1='" & Trim(txtApe1.Text.ToUpper) & _
                    "',Apellido2='" & Trim(txtApe2.Text.ToUpper) & _
                    "',ApellidoCas='" & Trim(txtApe3.Text.ToUpper) & _
                    "',Nombres='" & Trim(txtNombres.Text.ToUpper) & _
                    "',Fecha_Nac='" & Format(dtpFecNac.Value, "short date") & _
                    "',Direccion='" & Trim(txtDir.Text) & _
                    "',TelCasa='" & Trim(txtTelCasa.Text) & _
                    "',TelOficina='" & Trim(txtTelOfic.Text) & _
                    "',ExtensionOfic='" & Trim(txtExtOfic.Text) & _
                    "',Celular='" & Trim(txtCel.Text) & _
                    "',Email='" & Trim(txtCorreo.Text) & _
                    "',CodProfesion='" & Trim(txtCodProf.Text) & _
                    "',TituloObtenido='" & Trim(txtTitulo.Text) & _
                    "',CodNacionalidad='" & Trim(txtCodNac.Text) & _
                    "',LugarTrabajo='" & Trim(txtLugTrab.Text) & _
                    "',DepartamentoTrabajo='" & Trim(txtDptoTrabajo.Text) & _
                    "',FechaInicioTrab='" & Format(dtpFecIniTrab.Value, "short date") & _
                    "',DireccionTrabajo='" & Trim(txtDirTrab.Text) & _
                    "',Cargo='" & Trim(txtCargo.Text) & _
                    "',Salario=" & Val(txtSalario.Value) & _
                    ",EstadoCivil='" & cbEstadoCivil.SelectedIndex & _
                    "',NombreConyugue='" & Trim(txtConyugue.Text) & _
                    "',NumGrupoFam='" & nuDGrupoFam.Value & _
                    "',NumDependientes='" & nuDNumDep.Value & _
                    "',EstadoVivienda='" & cbEstadoVivienda.SelectedIndex & _
                    "',TrabajoPropio='" & System.Math.Abs(CInt(chkTrabPropio.Checked)) & _
                    "',TipoActividad='" & Trim(txtTipoAct.Text) & _
                    "',OtrosIngresos='" & txtOtrosIng.Value & _
                    "',OrigenOtrosIngresos='" & Trim(txtOrigIng.Text) & _
                    "', CodMunicipio='" & Trim(txtCodMun.Text) & _
                    "',CodDepartamento='" & Trim(txtCodDpto.Text) & _
                    "',CodEjecMercadeo='" & Trim(txtCodEjecMercadeo.Text) & _
                    "',Sexo='" & cboSexo.SelectedIndex & _
                    "',RegistroFiscal='" & Trim(txtRegFiscal.Text) & _
                    "',Giro='" & Trim(txtGiro.Text) & _
                    "',Residente='" & IIf(Me.chkResidente.Checked = True, "1", "0") & _
                    "',NoResidente='" & vNoResidente & _
                    "',TiempoResidencia='" & txtTiempoResidencia.Text.Trim & "'"
                End If

                If oAsoc.ModificarAsociado(vCorrelativo, vDui, "", pCampos, sUsuario, sPassword, sSucursal) = True Then
                    'pCampos = "NoSocio,DUI,DocumentosCompletos,Fotografias,TituloFotocop,DUIFotocop,NITFotocop,ReciboCuotaInicial,OtrosDescripcion,Otros,Observaciones,FechaCharla,Aprobado,FechaAprob,UsuarioAutoriza,FechaAutoriza,UsuarioGerenciaAutoriza,FecUsuGerenciaAutoriza,FecResolucionConsejo,Resolucion,Obs,ActaNo,FechaActa,ActivarAsociado,UsuarioActiva,FechaUsuarioActiva,ArchivoVinculoActa,Procesada"
                    'pValores = "'" & Me.txtNoSocio.Text.Trim & "','" & Trim(txtDui.Text) & "','0','0','0','0','0','','','0','','" & Date.Today & "','0','" & Date.Today & "','" & sUsuario & "','" & Date.Today & "','" & sUsuario & "','" & Date.Today & "','" & Date.Today & "','','','','" & Date.Today & "','0','" & sUsuario & "','" & Date.Today & "','','0'"
                    'ds = oAsoc.ConsultarEstadoIngreso("*", "a.NoSocio='" & Trim(Me.txtNoSocio.Text) & "' and a.Dui='" & Trim(Me.txtDui.Text) & "'", "a.Dui", sUsuario, sPassword, sSucursal)
                    'If ds.Tables(0).Rows.Count > 0 Then
                    'Else
                    '    oAsoc.InsertarEstadoIngreso(pCampos, pValores, sUsuario, sPassword, sSucursal)
                    'End If
                    Me.tb.SelectedIndex = Me.tb.SelectedIndex() + 1
                    MsgBox("Registro modificado exitosamente.", MsgBoxStyle.Information)
                    Me.Dispose()
                Else
                    MsgBox("El Cliente no ha sido modificado. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Clientes")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub txtCodEjecMercadeo_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEjecMercadeo.DoubleClick
        Dim ofrm As New frmAGenerico
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet

        ofrm.Text = "Buscar Ejecutivos de Mercadeo"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Try
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarEjecutivosMercadeoxNombre("", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodEjecMercadeo.Text = ofrm.Resultado.Trim
            txtEjecMercadeo.Text = ofrm.Resultado2.Trim
            txtGiro.Focus()
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Ejecutivos Mercadeo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    

    Private Sub txtCodEjecMercadeo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEjecMercadeo.Validated
        Dim oPl As New wrPlanilla.wsLibPlanilla
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Dim dtsEje As New DataSet
        dtsEje = oPerif.ConsultarEjecutivosMercadeo("CodEmpleado", "CodEjecMercadeo ='" & txtCodEjecMercadeo.Text.Trim.ToString & "'", "", sUsuario, sPassword, sSucursal)
        If dtsEje.Tables(0).Rows.Count > 0 Then
            Dim dtsPla As New DataSet
            dtsPla = oPl.ConsultarEmpleados(" rtrim(nombres)+' '+rtrim(apellido1)+' '+ rtrim(apellido2)  ", "CodEmpleado='" & dtsEje.Tables(0).Rows(0).Item(0).ToString & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
            If dtsPla.Tables(0).Rows.Count > 0 Then
                txtEjecMercadeo.Text = dtsPla.Tables(0).Rows(0).Item(0).ToString.ToUpper
            End If
        Else
            txtCodEjecMercadeo.Text = ""
            txtEjecMercadeo.Text = ""
            MsgBox("Código ingresado inexistente", MsgBoxStyle.Critical)
        End If
    End Sub
End Class