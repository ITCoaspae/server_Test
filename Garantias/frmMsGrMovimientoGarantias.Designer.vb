<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsGrMovimientoGarantias
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblESTADO = New System.Windows.Forms.Label()
        Me.lblFechaVenc = New System.Windows.Forms.Label()
        Me.lblFechaOtorg = New System.Windows.Forms.Label()
        Me.lblTasaInt = New System.Windows.Forms.Label()
        Me.lblPlazo = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblConcedido = New System.Windows.Forms.Label()
        Me.txtObsDE = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbTipoDocEnt = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.dtpFecEntDC = New System.Windows.Forms.DateTimePicker()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.cbRESPONSABLEENTREGA = New System.Windows.Forms.ComboBox()
        Me.cbDEPTOENTREGA = New System.Windows.Forms.ComboBox()
        Me.cbRESPONSABLERECIBE = New System.Windows.Forms.ComboBox()
        Me.cbDEPRECIBE = New System.Windows.Forms.ComboBox()
        Me.dtpFECHA_FIN = New System.Windows.Forms.DateTimePicker()
        Me.lblFECHAFIN = New System.Windows.Forms.Label()
        Me.dtpFECHAINI = New System.Windows.Forms.DateTimePicker()
        Me.lblFECHAINI = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblNOMATRICULA = New System.Windows.Forms.Label()
        Me.lblNOCOMPROBANTE = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.gbCONSULTAR = New System.Windows.Forms.GroupBox()
        Me.btAtras1 = New MetroFramework.Controls.MetroButton()
        Me.cbMOSTRARTODOS = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnGUARDAR1 = New MetroFramework.Controls.MetroButton()
        Me.lblENCCODPRES = New System.Windows.Forms.Label()
        Me.llINF = New System.Windows.Forms.LinkLabel()
        Me.lblCODPRESGARANTIA = New System.Windows.Forms.Label()
        Me.gbACCION = New System.Windows.Forms.GroupBox()
        Me.rbDEVOLUCION = New System.Windows.Forms.RadioButton()
        Me.rbPRESTAMO = New System.Windows.Forms.RadioButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbCONSULTAR.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbACCION.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblESTADO
        '
        Me.lblESTADO.AutoSize = True
        Me.lblESTADO.Location = New System.Drawing.Point(368, 41)
        Me.lblESTADO.Name = "lblESTADO"
        Me.lblESTADO.Size = New System.Drawing.Size(46, 13)
        Me.lblESTADO.TabIndex = 7
        Me.lblESTADO.Text = "Estado :"
        '
        'lblFechaVenc
        '
        Me.lblFechaVenc.Location = New System.Drawing.Point(5, 60)
        Me.lblFechaVenc.Name = "lblFechaVenc"
        Me.lblFechaVenc.Size = New System.Drawing.Size(219, 15)
        Me.lblFechaVenc.TabIndex = 6
        Me.lblFechaVenc.Text = "Fecha de Vencimiento:"
        '
        'lblFechaOtorg
        '
        Me.lblFechaOtorg.Location = New System.Drawing.Point(230, 59)
        Me.lblFechaOtorg.Name = "lblFechaOtorg"
        Me.lblFechaOtorg.Size = New System.Drawing.Size(330, 16)
        Me.lblFechaOtorg.TabIndex = 5
        Me.lblFechaOtorg.Text = "Fecha de Otorgamiento:"
        '
        'lblTasaInt
        '
        Me.lblTasaInt.Location = New System.Drawing.Point(230, 38)
        Me.lblTasaInt.Name = "lblTasaInt"
        Me.lblTasaInt.Size = New System.Drawing.Size(137, 16)
        Me.lblTasaInt.TabIndex = 4
        Me.lblTasaInt.Text = "Tasa de Interés:"
        '
        'lblPlazo
        '
        Me.lblPlazo.Location = New System.Drawing.Point(5, 38)
        Me.lblPlazo.Name = "lblPlazo"
        Me.lblPlazo.Size = New System.Drawing.Size(71, 13)
        Me.lblPlazo.TabIndex = 3
        Me.lblPlazo.Text = "Plazo:"
        '
        'lblMonto
        '
        Me.lblMonto.Location = New System.Drawing.Point(100, 38)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(67, 13)
        Me.lblMonto.TabIndex = 2
        Me.lblMonto.Text = "Monto:"
        '
        'lblConcedido
        '
        Me.lblConcedido.Location = New System.Drawing.Point(5, 19)
        Me.lblConcedido.Name = "lblConcedido"
        Me.lblConcedido.Size = New System.Drawing.Size(212, 13)
        Me.lblConcedido.TabIndex = 1
        Me.lblConcedido.Text = "Nombre de Asociado:"
        '
        'txtObsDE
        '
        Me.txtObsDE.Location = New System.Drawing.Point(230, 236)
        Me.txtObsDE.Multiline = True
        Me.txtObsDE.Name = "txtObsDE"
        Me.txtObsDE.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsDE.Size = New System.Drawing.Size(401, 32)
        Me.txtObsDE.TabIndex = 167
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(7, 237)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 16)
        Me.Label18.TabIndex = 176
        Me.Label18.Text = "Observaciones:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbTipoDocEnt
        '
        Me.cbTipoDocEnt.DisplayMember = "DESCRIPCION"
        Me.cbTipoDocEnt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoDocEnt.Items.AddRange(New Object() {"Escritura de Hipoteca", "Escritura de Hipoteca otro desembolso", "Otros"})
        Me.cbTipoDocEnt.Location = New System.Drawing.Point(230, 209)
        Me.cbTipoDocEnt.Name = "cbTipoDocEnt"
        Me.cbTipoDocEnt.Size = New System.Drawing.Size(400, 21)
        Me.cbTipoDocEnt.TabIndex = 166
        Me.cbTipoDocEnt.ValueMember = "ID_TIPODOC"
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(7, 209)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(183, 16)
        Me.Label48.TabIndex = 175
        Me.Label48.Text = "Tipo de documentos entregados:"
        '
        'Label47
        '
        Me.Label47.BackColor = System.Drawing.Color.White
        Me.Label47.Location = New System.Drawing.Point(7, 71)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(202, 16)
        Me.Label47.TabIndex = 173
        Me.Label47.Text = "Departamento responsable que recibe:"
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.White
        Me.Label46.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(7, 179)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(144, 16)
        Me.Label46.TabIndex = 172
        Me.Label46.Text = "Responsable que entrega:"
        '
        'Label45
        '
        Me.Label45.BackColor = System.Drawing.Color.White
        Me.Label45.Location = New System.Drawing.Point(7, 152)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(208, 16)
        Me.Label45.TabIndex = 170
        Me.Label45.Text = "Departamento responsable que entrega:"
        '
        'dtpFecEntDC
        '
        Me.dtpFecEntDC.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecEntDC.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecEntDC.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecEntDC.Location = New System.Drawing.Point(230, 125)
        Me.dtpFecEntDC.Name = "dtpFecEntDC"
        Me.dtpFecEntDC.Size = New System.Drawing.Size(104, 20)
        Me.dtpFecEntDC.TabIndex = 162
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.White
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(7, 125)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(98, 16)
        Me.Label36.TabIndex = 169
        Me.Label36.Text = "Fecha de Entrega:"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.Color.White
        Me.Label41.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(7, 98)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(152, 16)
        Me.Label41.TabIndex = 168
        Me.Label41.Text = "Responsable que recibe:"
        '
        'cbRESPONSABLEENTREGA
        '
        Me.cbRESPONSABLEENTREGA.DisplayMember = "EMPLEADO"
        Me.cbRESPONSABLEENTREGA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRESPONSABLEENTREGA.Location = New System.Drawing.Point(230, 179)
        Me.cbRESPONSABLEENTREGA.Name = "cbRESPONSABLEENTREGA"
        Me.cbRESPONSABLEENTREGA.Size = New System.Drawing.Size(401, 21)
        Me.cbRESPONSABLEENTREGA.TabIndex = 181
        Me.cbRESPONSABLEENTREGA.ValueMember = "CODEMPLEADO"
        '
        'cbDEPTOENTREGA
        '
        Me.cbDEPTOENTREGA.DisplayMember = "DESCRIPCION"
        Me.cbDEPTOENTREGA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDEPTOENTREGA.Location = New System.Drawing.Point(230, 152)
        Me.cbDEPTOENTREGA.Name = "cbDEPTOENTREGA"
        Me.cbDEPTOENTREGA.Size = New System.Drawing.Size(400, 21)
        Me.cbDEPTOENTREGA.TabIndex = 180
        Me.cbDEPTOENTREGA.ValueMember = "CODDEPARTAMENTO"
        '
        'cbRESPONSABLERECIBE
        '
        Me.cbRESPONSABLERECIBE.DisplayMember = "EMPLEADO"
        Me.cbRESPONSABLERECIBE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbRESPONSABLERECIBE.Location = New System.Drawing.Point(230, 98)
        Me.cbRESPONSABLERECIBE.Name = "cbRESPONSABLERECIBE"
        Me.cbRESPONSABLERECIBE.Size = New System.Drawing.Size(400, 21)
        Me.cbRESPONSABLERECIBE.TabIndex = 179
        Me.cbRESPONSABLERECIBE.ValueMember = "CODEMPLEADO"
        '
        'cbDEPRECIBE
        '
        Me.cbDEPRECIBE.DisplayMember = "DESCRIPCION"
        Me.cbDEPRECIBE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDEPRECIBE.Location = New System.Drawing.Point(230, 71)
        Me.cbDEPRECIBE.Name = "cbDEPRECIBE"
        Me.cbDEPRECIBE.Size = New System.Drawing.Size(400, 21)
        Me.cbDEPRECIBE.TabIndex = 178
        Me.cbDEPRECIBE.ValueMember = "CODDEPARTAMENTO"
        '
        'dtpFECHA_FIN
        '
        Me.dtpFECHA_FIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFECHA_FIN.Location = New System.Drawing.Point(238, 19)
        Me.dtpFECHA_FIN.Name = "dtpFECHA_FIN"
        Me.dtpFECHA_FIN.Size = New System.Drawing.Size(106, 20)
        Me.dtpFECHA_FIN.TabIndex = 4
        '
        'lblFECHAFIN
        '
        Me.lblFECHAFIN.AutoSize = True
        Me.lblFECHAFIN.ForeColor = System.Drawing.Color.Black
        Me.lblFECHAFIN.Location = New System.Drawing.Point(181, 19)
        Me.lblFECHAFIN.Name = "lblFECHAFIN"
        Me.lblFECHAFIN.Size = New System.Drawing.Size(51, 13)
        Me.lblFECHAFIN.TabIndex = 3
        Me.lblFECHAFIN.Text = "Fecha fin"
        '
        'dtpFECHAINI
        '
        Me.dtpFECHAINI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFECHAINI.Location = New System.Drawing.Point(77, 19)
        Me.dtpFECHAINI.Name = "dtpFECHAINI"
        Me.dtpFECHAINI.Size = New System.Drawing.Size(98, 20)
        Me.dtpFECHAINI.TabIndex = 2
        '
        'lblFECHAINI
        '
        Me.lblFECHAINI.AutoSize = True
        Me.lblFECHAINI.ForeColor = System.Drawing.Color.Black
        Me.lblFECHAINI.Location = New System.Drawing.Point(6, 19)
        Me.lblFECHAINI.Name = "lblFECHAINI"
        Me.lblFECHAINI.Size = New System.Drawing.Size(65, 13)
        Me.lblFECHAINI.TabIndex = 1
        Me.lblFECHAINI.Text = "Fecha Inicio"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Location = New System.Drawing.Point(9, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(631, 122)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.lblFechaVenc)
        Me.GroupBox3.Controls.Add(Me.lblNOMATRICULA)
        Me.GroupBox3.Controls.Add(Me.lblPlazo)
        Me.GroupBox3.Controls.Add(Me.lblNOCOMPROBANTE)
        Me.GroupBox3.Controls.Add(Me.lblMonto)
        Me.GroupBox3.Controls.Add(Me.lblTasaInt)
        Me.GroupBox3.Controls.Add(Me.lblESTADO)
        Me.GroupBox3.Controls.Add(Me.lblConcedido)
        Me.GroupBox3.Controls.Add(Me.lblFechaOtorg)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(652, 78)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Generales"
        '
        'lblNOMATRICULA
        '
        Me.lblNOMATRICULA.AutoSize = True
        Me.lblNOMATRICULA.Location = New System.Drawing.Point(468, 19)
        Me.lblNOMATRICULA.Name = "lblNOMATRICULA"
        Me.lblNOMATRICULA.Size = New System.Drawing.Size(65, 13)
        Me.lblNOMATRICULA.TabIndex = 10
        Me.lblNOMATRICULA.Text = "N° Matricula"
        '
        'lblNOCOMPROBANTE
        '
        Me.lblNOCOMPROBANTE.AutoSize = True
        Me.lblNOCOMPROBANTE.Location = New System.Drawing.Point(295, 19)
        Me.lblNOCOMPROBANTE.Name = "lblNOCOMPROBANTE"
        Me.lblNOCOMPROBANTE.Size = New System.Drawing.Size(90, 13)
        Me.lblNOCOMPROBANTE.TabIndex = 9
        Me.lblNOCOMPROBANTE.Text = "No. Comprobante"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.SystemColors.Window
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(23, 147)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbCONSULTAR)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer1.Size = New System.Drawing.Size(652, 510)
        Me.SplitContainer1.SplitterDistance = 186
        Me.SplitContainer1.TabIndex = 183
        '
        'gbCONSULTAR
        '
        Me.gbCONSULTAR.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbCONSULTAR.Controls.Add(Me.btAtras1)
        Me.gbCONSULTAR.Controls.Add(Me.cbMOSTRARTODOS)
        Me.gbCONSULTAR.Controls.Add(Me.DataGridView1)
        Me.gbCONSULTAR.Controls.Add(Me.lblFECHAINI)
        Me.gbCONSULTAR.Controls.Add(Me.dtpFECHA_FIN)
        Me.gbCONSULTAR.Controls.Add(Me.dtpFECHAINI)
        Me.gbCONSULTAR.Controls.Add(Me.lblFECHAFIN)
        Me.gbCONSULTAR.ForeColor = System.Drawing.Color.Teal
        Me.gbCONSULTAR.Location = New System.Drawing.Point(3, 3)
        Me.gbCONSULTAR.Name = "gbCONSULTAR"
        Me.gbCONSULTAR.Size = New System.Drawing.Size(646, 180)
        Me.gbCONSULTAR.TabIndex = 1
        Me.gbCONSULTAR.TabStop = False
        Me.gbCONSULTAR.Text = "Consultar Movimientos"
        '
        'btAtras1
        '
        Me.btAtras1.Location = New System.Drawing.Point(450, 18)
        Me.btAtras1.Name = "btAtras1"
        Me.btAtras1.Size = New System.Drawing.Size(75, 28)
        Me.btAtras1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btAtras1.TabIndex = 231
        Me.btAtras1.Text = "&Buscar"
        Me.btAtras1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btAtras1.UseSelectable = True
        Me.btAtras1.UseStyleColors = True
        '
        'cbMOSTRARTODOS
        '
        Me.cbMOSTRARTODOS.AutoSize = True
        Me.cbMOSTRARTODOS.ForeColor = System.Drawing.Color.Black
        Me.cbMOSTRARTODOS.Location = New System.Drawing.Point(350, 19)
        Me.cbMOSTRARTODOS.Name = "cbMOSTRARTODOS"
        Me.cbMOSTRARTODOS.Size = New System.Drawing.Size(94, 17)
        Me.cbMOSTRARTODOS.TabIndex = 6
        Me.cbMOSTRARTODOS.Text = "Mostrar Todos"
        Me.cbMOSTRARTODOS.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnGUARDAR1)
        Me.GroupBox2.Controls.Add(Me.lblENCCODPRES)
        Me.GroupBox2.Controls.Add(Me.llINF)
        Me.GroupBox2.Controls.Add(Me.lblCODPRESGARANTIA)
        Me.GroupBox2.Controls.Add(Me.gbACCION)
        Me.GroupBox2.Controls.Add(Me.cbRESPONSABLEENTREGA)
        Me.GroupBox2.Controls.Add(Me.dtpFecEntDC)
        Me.GroupBox2.Controls.Add(Me.txtObsDE)
        Me.GroupBox2.Controls.Add(Me.cbTipoDocEnt)
        Me.GroupBox2.Controls.Add(Me.cbDEPTOENTREGA)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label45)
        Me.GroupBox2.Controls.Add(Me.Label47)
        Me.GroupBox2.Controls.Add(Me.cbRESPONSABLERECIBE)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label46)
        Me.GroupBox2.Controls.Add(Me.cbDEPRECIBE)
        Me.GroupBox2.Controls.Add(Me.Label48)
        Me.GroupBox2.Controls.Add(Me.Label41)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(643, 317)
        Me.GroupBox2.TabIndex = 184
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ingresar Movimientos"
        '
        'btnGUARDAR1
        '
        Me.btnGUARDAR1.Location = New System.Drawing.Point(555, 274)
        Me.btnGUARDAR1.Name = "btnGUARDAR1"
        Me.btnGUARDAR1.Size = New System.Drawing.Size(75, 28)
        Me.btnGUARDAR1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGUARDAR1.TabIndex = 232
        Me.btnGUARDAR1.Text = "&Guardar"
        Me.btnGUARDAR1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGUARDAR1.UseSelectable = True
        Me.btnGUARDAR1.UseStyleColors = True
        '
        'lblENCCODPRES
        '
        Me.lblENCCODPRES.AutoSize = True
        Me.lblENCCODPRES.Location = New System.Drawing.Point(227, 38)
        Me.lblENCCODPRES.Name = "lblENCCODPRES"
        Me.lblENCCODPRES.Size = New System.Drawing.Size(182, 13)
        Me.lblENCCODPRES.TabIndex = 187
        Me.lblENCCODPRES.Text = "Codigo del prestamo del documento: "
        '
        'llINF
        '
        Me.llINF.AutoSize = True
        Me.llINF.Location = New System.Drawing.Point(415, 16)
        Me.llINF.Name = "llINF"
        Me.llINF.Size = New System.Drawing.Size(198, 13)
        Me.llINF.TabIndex = 186
        Me.llINF.TabStop = True
        Me.llINF.Text = "Ver Información del documento prestado"
        '
        'lblCODPRESGARANTIA
        '
        Me.lblCODPRESGARANTIA.AutoSize = True
        Me.lblCODPRESGARANTIA.Location = New System.Drawing.Point(424, 38)
        Me.lblCODPRESGARANTIA.Name = "lblCODPRESGARANTIA"
        Me.lblCODPRESGARANTIA.Size = New System.Drawing.Size(39, 13)
        Me.lblCODPRESGARANTIA.TabIndex = 185
        Me.lblCODPRESGARANTIA.Text = "Label2"
        '
        'gbACCION
        '
        Me.gbACCION.BackColor = System.Drawing.SystemColors.Window
        Me.gbACCION.Controls.Add(Me.rbDEVOLUCION)
        Me.gbACCION.Controls.Add(Me.rbPRESTAMO)
        Me.gbACCION.Location = New System.Drawing.Point(10, 17)
        Me.gbACCION.Name = "gbACCION"
        Me.gbACCION.Size = New System.Drawing.Size(180, 44)
        Me.gbACCION.TabIndex = 184
        Me.gbACCION.TabStop = False
        Me.gbACCION.Text = "Acción"
        '
        'rbDEVOLUCION
        '
        Me.rbDEVOLUCION.AutoSize = True
        Me.rbDEVOLUCION.Location = New System.Drawing.Point(93, 17)
        Me.rbDEVOLUCION.Name = "rbDEVOLUCION"
        Me.rbDEVOLUCION.Size = New System.Drawing.Size(79, 17)
        Me.rbDEVOLUCION.TabIndex = 184
        Me.rbDEVOLUCION.TabStop = True
        Me.rbDEVOLUCION.Text = "Devolución"
        Me.rbDEVOLUCION.UseVisualStyleBackColor = True
        '
        'rbPRESTAMO
        '
        Me.rbPRESTAMO.AutoSize = True
        Me.rbPRESTAMO.Location = New System.Drawing.Point(6, 17)
        Me.rbPRESTAMO.Name = "rbPRESTAMO"
        Me.rbPRESTAMO.Size = New System.Drawing.Size(69, 17)
        Me.rbPRESTAMO.TabIndex = 183
        Me.rbPRESTAMO.TabStop = True
        Me.rbPRESTAMO.Text = "Prestamo"
        Me.rbPRESTAMO.UseVisualStyleBackColor = True
        '
        'frmMsGrMovimientoGarantias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(703, 680)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsGrMovimientoGarantias"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "CONTROL DE MOVIMIENTOS DE DOCS. GARANTÍAS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbCONSULTAR.ResumeLayout(False)
        Me.gbCONSULTAR.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbACCION.ResumeLayout(False)
        Me.gbACCION.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblESTADO As System.Windows.Forms.Label
    Friend WithEvents lblFechaVenc As System.Windows.Forms.Label
    Friend WithEvents lblFechaOtorg As System.Windows.Forms.Label
    Friend WithEvents lblTasaInt As System.Windows.Forms.Label
    Friend WithEvents lblPlazo As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblConcedido As System.Windows.Forms.Label
    Friend WithEvents txtObsDE As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cbTipoDocEnt As System.Windows.Forms.ComboBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents dtpFecEntDC As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cbRESPONSABLEENTREGA As System.Windows.Forms.ComboBox
    Friend WithEvents cbDEPTOENTREGA As System.Windows.Forms.ComboBox
    Friend WithEvents cbRESPONSABLERECIBE As System.Windows.Forms.ComboBox
    Friend WithEvents cbDEPRECIBE As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFECHA_FIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFECHAFIN As System.Windows.Forms.Label
    Friend WithEvents dtpFECHAINI As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFECHAINI As System.Windows.Forms.Label
    Friend WithEvents lblNOMATRICULA As System.Windows.Forms.Label
    Friend WithEvents lblNOCOMPROBANTE As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gbCONSULTAR As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents gbACCION As System.Windows.Forms.GroupBox
    Friend WithEvents rbDEVOLUCION As System.Windows.Forms.RadioButton
    Friend WithEvents rbPRESTAMO As System.Windows.Forms.RadioButton
    Friend WithEvents lblCODPRESGARANTIA As System.Windows.Forms.Label
    Friend WithEvents llINF As System.Windows.Forms.LinkLabel
    Friend WithEvents lblENCCODPRES As System.Windows.Forms.Label
    Friend WithEvents cbMOSTRARTODOS As System.Windows.Forms.CheckBox
    Friend WithEvents btAtras1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGUARDAR1 As MetroFramework.Controls.MetroButton
End Class
