<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsGrHistorialGarantias
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form

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
        Me.dgHISTORICOGARANTIAS = New System.Windows.Forms.DataGridView()
        Me.lblENCABEZADO = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnMODIFICAR1 = New MetroFramework.Controls.MetroButton()
        Me.txtPLAZO = New System.Windows.Forms.TextBox()
        Me.lblPLAZO = New System.Windows.Forms.Label()
        Me.txtTASA = New System.Windows.Forms.TextBox()
        Me.lblTASA = New System.Windows.Forms.Label()
        Me.txtOBSERVACIONES = New System.Windows.Forms.TextBox()
        Me.lblOBSERVACIONES = New System.Windows.Forms.Label()
        Me.txtINSCRIPCION = New System.Windows.Forms.TextBox()
        Me.lblINSCRIPCION = New System.Windows.Forms.Label()
        Me.dtpFECHAINSCRIPCION = New System.Windows.Forms.DateTimePicker()
        Me.lblFECHAINSCRIPCION = New System.Windows.Forms.Label()
        Me.dtpFECHAPRESENTACION = New System.Windows.Forms.DateTimePicker()
        Me.lblFECHAPRESENTACION = New System.Windows.Forms.Label()
        Me.txtMONTO = New System.Windows.Forms.TextBox()
        Me.lblMONTO = New System.Windows.Forms.Label()
        Me.dtpFECHAMODIFICACION = New System.Windows.Forms.DateTimePicker()
        Me.lblFECHAMODIFICACION = New System.Windows.Forms.Label()
        Me.txtNOCOMPROBANTE = New System.Windows.Forms.TextBox()
        Me.lblNOCOMPROBANTE = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblNUMSOLICITUD = New System.Windows.Forms.Label()
        Me.lblENCFECHAOTOR = New System.Windows.Forms.Label()
        Me.lblENCTASA = New System.Windows.Forms.Label()
        Me.lblENCMONTO = New System.Windows.Forms.Label()
        Me.lblENCPLAZO = New System.Windows.Forms.Label()
        Me.lblENCFECHAVENCIMIENTO = New System.Windows.Forms.Label()
        Me.lblASOCIADO = New System.Windows.Forms.Label()
        Me.lblENCESTADO = New System.Windows.Forms.Label()
        CType(Me.dgHISTORICOGARANTIAS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgHISTORICOGARANTIAS
        '
        Me.dgHISTORICOGARANTIAS.AllowUserToAddRows = False
        Me.dgHISTORICOGARANTIAS.AllowUserToDeleteRows = False
        Me.dgHISTORICOGARANTIAS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgHISTORICOGARANTIAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgHISTORICOGARANTIAS.Location = New System.Drawing.Point(7, 42)
        Me.dgHISTORICOGARANTIAS.Name = "dgHISTORICOGARANTIAS"
        Me.dgHISTORICOGARANTIAS.ReadOnly = True
        Me.dgHISTORICOGARANTIAS.Size = New System.Drawing.Size(665, 133)
        Me.dgHISTORICOGARANTIAS.TabIndex = 0
        '
        'lblENCABEZADO
        '
        Me.lblENCABEZADO.AutoSize = True
        Me.lblENCABEZADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblENCABEZADO.ForeColor = System.Drawing.Color.Teal
        Me.lblENCABEZADO.Location = New System.Drawing.Point(3, 9)
        Me.lblENCABEZADO.Name = "lblENCABEZADO"
        Me.lblENCABEZADO.Size = New System.Drawing.Size(304, 20)
        Me.lblENCABEZADO.TabIndex = 1
        Me.lblENCABEZADO.Text = "Historial de modificaciones garantías"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.lblENCABEZADO)
        Me.Panel1.Controls.Add(Me.dgHISTORICOGARANTIAS)
        Me.Panel1.Location = New System.Drawing.Point(23, 147)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 188)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.btnMODIFICAR1)
        Me.Panel2.Controls.Add(Me.txtPLAZO)
        Me.Panel2.Controls.Add(Me.lblPLAZO)
        Me.Panel2.Controls.Add(Me.txtTASA)
        Me.Panel2.Controls.Add(Me.lblTASA)
        Me.Panel2.Controls.Add(Me.txtOBSERVACIONES)
        Me.Panel2.Controls.Add(Me.lblOBSERVACIONES)
        Me.Panel2.Controls.Add(Me.txtINSCRIPCION)
        Me.Panel2.Controls.Add(Me.lblINSCRIPCION)
        Me.Panel2.Controls.Add(Me.dtpFECHAINSCRIPCION)
        Me.Panel2.Controls.Add(Me.lblFECHAINSCRIPCION)
        Me.Panel2.Controls.Add(Me.dtpFECHAPRESENTACION)
        Me.Panel2.Controls.Add(Me.lblFECHAPRESENTACION)
        Me.Panel2.Controls.Add(Me.txtMONTO)
        Me.Panel2.Controls.Add(Me.lblMONTO)
        Me.Panel2.Controls.Add(Me.dtpFECHAMODIFICACION)
        Me.Panel2.Controls.Add(Me.lblFECHAMODIFICACION)
        Me.Panel2.Controls.Add(Me.txtNOCOMPROBANTE)
        Me.Panel2.Controls.Add(Me.lblNOCOMPROBANTE)
        Me.Panel2.Location = New System.Drawing.Point(23, 345)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(680, 203)
        Me.Panel2.TabIndex = 3
        '
        'btnMODIFICAR1
        '
        Me.btnMODIFICAR1.Location = New System.Drawing.Point(597, 169)
        Me.btnMODIFICAR1.Name = "btnMODIFICAR1"
        Me.btnMODIFICAR1.Size = New System.Drawing.Size(75, 28)
        Me.btnMODIFICAR1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMODIFICAR1.TabIndex = 223
        Me.btnMODIFICAR1.Text = "&Modificar"
        Me.btnMODIFICAR1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMODIFICAR1.UseSelectable = True
        Me.btnMODIFICAR1.UseStyleColors = True
        '
        'txtPLAZO
        '
        Me.txtPLAZO.Location = New System.Drawing.Point(539, 33)
        Me.txtPLAZO.Name = "txtPLAZO"
        Me.txtPLAZO.Size = New System.Drawing.Size(133, 20)
        Me.txtPLAZO.TabIndex = 17
        '
        'lblPLAZO
        '
        Me.lblPLAZO.AutoSize = True
        Me.lblPLAZO.Location = New System.Drawing.Point(418, 36)
        Me.lblPLAZO.Name = "lblPLAZO"
        Me.lblPLAZO.Size = New System.Drawing.Size(33, 13)
        Me.lblPLAZO.TabIndex = 16
        Me.lblPLAZO.Text = "Plazo"
        '
        'txtTASA
        '
        Me.txtTASA.Location = New System.Drawing.Point(279, 33)
        Me.txtTASA.Name = "txtTASA"
        Me.txtTASA.Size = New System.Drawing.Size(133, 20)
        Me.txtTASA.TabIndex = 15
        '
        'lblTASA
        '
        Me.lblTASA.AutoSize = True
        Me.lblTASA.Location = New System.Drawing.Point(201, 36)
        Me.lblTASA.Name = "lblTASA"
        Me.lblTASA.Size = New System.Drawing.Size(66, 13)
        Me.lblTASA.TabIndex = 14
        Me.lblTASA.Text = "Tasa Interés"
        '
        'txtOBSERVACIONES
        '
        Me.txtOBSERVACIONES.Location = New System.Drawing.Point(88, 91)
        Me.txtOBSERVACIONES.Multiline = True
        Me.txtOBSERVACIONES.Name = "txtOBSERVACIONES"
        Me.txtOBSERVACIONES.Size = New System.Drawing.Size(584, 72)
        Me.txtOBSERVACIONES.TabIndex = 13
        '
        'lblOBSERVACIONES
        '
        Me.lblOBSERVACIONES.AutoSize = True
        Me.lblOBSERVACIONES.Location = New System.Drawing.Point(6, 94)
        Me.lblOBSERVACIONES.Name = "lblOBSERVACIONES"
        Me.lblOBSERVACIONES.Size = New System.Drawing.Size(78, 13)
        Me.lblOBSERVACIONES.TabIndex = 12
        Me.lblOBSERVACIONES.Text = "Observaciones"
        '
        'txtINSCRIPCION
        '
        Me.txtINSCRIPCION.Location = New System.Drawing.Point(279, 7)
        Me.txtINSCRIPCION.Name = "txtINSCRIPCION"
        Me.txtINSCRIPCION.Size = New System.Drawing.Size(133, 20)
        Me.txtINSCRIPCION.TabIndex = 11
        '
        'lblINSCRIPCION
        '
        Me.lblINSCRIPCION.AutoSize = True
        Me.lblINSCRIPCION.Location = New System.Drawing.Point(200, 10)
        Me.lblINSCRIPCION.Name = "lblINSCRIPCION"
        Me.lblINSCRIPCION.Size = New System.Drawing.Size(73, 13)
        Me.lblINSCRIPCION.TabIndex = 10
        Me.lblINSCRIPCION.Text = "N° Inscripción"
        '
        'dtpFECHAINSCRIPCION
        '
        Me.dtpFECHAINSCRIPCION.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFECHAINSCRIPCION.Location = New System.Drawing.Point(95, 62)
        Me.dtpFECHAINSCRIPCION.Name = "dtpFECHAINSCRIPCION"
        Me.dtpFECHAINSCRIPCION.Size = New System.Drawing.Size(100, 20)
        Me.dtpFECHAINSCRIPCION.TabIndex = 9
        '
        'lblFECHAINSCRIPCION
        '
        Me.lblFECHAINSCRIPCION.AutoSize = True
        Me.lblFECHAINSCRIPCION.Location = New System.Drawing.Point(4, 62)
        Me.lblFECHAINSCRIPCION.Name = "lblFECHAINSCRIPCION"
        Me.lblFECHAINSCRIPCION.Size = New System.Drawing.Size(91, 13)
        Me.lblFECHAINSCRIPCION.TabIndex = 8
        Me.lblFECHAINSCRIPCION.Text = "Fecha Inscripción"
        '
        'dtpFECHAPRESENTACION
        '
        Me.dtpFECHAPRESENTACION.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFECHAPRESENTACION.Location = New System.Drawing.Point(279, 62)
        Me.dtpFECHAPRESENTACION.Name = "dtpFECHAPRESENTACION"
        Me.dtpFECHAPRESENTACION.Size = New System.Drawing.Size(133, 20)
        Me.dtpFECHAPRESENTACION.TabIndex = 7
        '
        'lblFECHAPRESENTACION
        '
        Me.lblFECHAPRESENTACION.AutoSize = True
        Me.lblFECHAPRESENTACION.Location = New System.Drawing.Point(200, 62)
        Me.lblFECHAPRESENTACION.Name = "lblFECHAPRESENTACION"
        Me.lblFECHAPRESENTACION.Size = New System.Drawing.Size(69, 26)
        Me.lblFECHAPRESENTACION.TabIndex = 6
        Me.lblFECHAPRESENTACION.Text = "Fecha " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Presentación"
        '
        'txtMONTO
        '
        Me.txtMONTO.Location = New System.Drawing.Point(95, 36)
        Me.txtMONTO.Name = "txtMONTO"
        Me.txtMONTO.Size = New System.Drawing.Size(100, 20)
        Me.txtMONTO.TabIndex = 5
        '
        'lblMONTO
        '
        Me.lblMONTO.AutoSize = True
        Me.lblMONTO.Location = New System.Drawing.Point(6, 36)
        Me.lblMONTO.Name = "lblMONTO"
        Me.lblMONTO.Size = New System.Drawing.Size(37, 13)
        Me.lblMONTO.TabIndex = 4
        Me.lblMONTO.Text = "Monto"
        '
        'dtpFECHAMODIFICACION
        '
        Me.dtpFECHAMODIFICACION.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFECHAMODIFICACION.Location = New System.Drawing.Point(539, 7)
        Me.dtpFECHAMODIFICACION.Name = "dtpFECHAMODIFICACION"
        Me.dtpFECHAMODIFICACION.Size = New System.Drawing.Size(133, 20)
        Me.dtpFECHAMODIFICACION.TabIndex = 3
        '
        'lblFECHAMODIFICACION
        '
        Me.lblFECHAMODIFICACION.AutoSize = True
        Me.lblFECHAMODIFICACION.Location = New System.Drawing.Point(418, 10)
        Me.lblFECHAMODIFICACION.Name = "lblFECHAMODIFICACION"
        Me.lblFECHAMODIFICACION.Size = New System.Drawing.Size(115, 13)
        Me.lblFECHAMODIFICACION.TabIndex = 2
        Me.lblFECHAMODIFICACION.Text = "Fecha de Modificación"
        '
        'txtNOCOMPROBANTE
        '
        Me.txtNOCOMPROBANTE.Location = New System.Drawing.Point(95, 10)
        Me.txtNOCOMPROBANTE.Name = "txtNOCOMPROBANTE"
        Me.txtNOCOMPROBANTE.Size = New System.Drawing.Size(100, 20)
        Me.txtNOCOMPROBANTE.TabIndex = 1
        '
        'lblNOCOMPROBANTE
        '
        Me.lblNOCOMPROBANTE.AutoSize = True
        Me.lblNOCOMPROBANTE.Location = New System.Drawing.Point(4, 10)
        Me.lblNOCOMPROBANTE.Name = "lblNOCOMPROBANTE"
        Me.lblNOCOMPROBANTE.Size = New System.Drawing.Size(85, 13)
        Me.lblNOCOMPROBANTE.TabIndex = 0
        Me.lblNOCOMPROBANTE.Text = "N° Comprobante"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.lblNUMSOLICITUD)
        Me.GroupBox3.Controls.Add(Me.lblENCFECHAOTOR)
        Me.GroupBox3.Controls.Add(Me.lblENCTASA)
        Me.GroupBox3.Controls.Add(Me.lblENCMONTO)
        Me.GroupBox3.Controls.Add(Me.lblENCPLAZO)
        Me.GroupBox3.Controls.Add(Me.lblENCFECHAVENCIMIENTO)
        Me.GroupBox3.Controls.Add(Me.lblASOCIADO)
        Me.GroupBox3.Controls.Add(Me.lblENCESTADO)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox3.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(680, 78)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Generales"
        '
        'lblNUMSOLICITUD
        '
        Me.lblNUMSOLICITUD.AutoSize = True
        Me.lblNUMSOLICITUD.ForeColor = System.Drawing.Color.Black
        Me.lblNUMSOLICITUD.Location = New System.Drawing.Point(92, 52)
        Me.lblNUMSOLICITUD.Name = "lblNUMSOLICITUD"
        Me.lblNUMSOLICITUD.Size = New System.Drawing.Size(77, 13)
        Me.lblNUMSOLICITUD.TabIndex = 17
        Me.lblNUMSOLICITUD.Text = "N° de Solicitud"
        '
        'lblENCFECHAOTOR
        '
        Me.lblENCFECHAOTOR.AutoSize = True
        Me.lblENCFECHAOTOR.ForeColor = System.Drawing.Color.Black
        Me.lblENCFECHAOTOR.Location = New System.Drawing.Point(231, 52)
        Me.lblENCFECHAOTOR.Name = "lblENCFECHAOTOR"
        Me.lblENCFECHAOTOR.Size = New System.Drawing.Size(121, 13)
        Me.lblENCFECHAOTOR.TabIndex = 16
        Me.lblENCFECHAOTOR.Text = "Fecha de Otorgamiento:"
        Me.lblENCFECHAOTOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblENCTASA
        '
        Me.lblENCTASA.AutoSize = True
        Me.lblENCTASA.ForeColor = System.Drawing.Color.Black
        Me.lblENCTASA.Location = New System.Drawing.Point(370, 19)
        Me.lblENCTASA.Name = "lblENCTASA"
        Me.lblENCTASA.Size = New System.Drawing.Size(81, 13)
        Me.lblENCTASA.TabIndex = 15
        Me.lblENCTASA.Text = "Tasa de Interés"
        '
        'lblENCMONTO
        '
        Me.lblENCMONTO.AutoSize = True
        Me.lblENCMONTO.ForeColor = System.Drawing.Color.Black
        Me.lblENCMONTO.Location = New System.Drawing.Point(256, 19)
        Me.lblENCMONTO.Name = "lblENCMONTO"
        Me.lblENCMONTO.Size = New System.Drawing.Size(40, 13)
        Me.lblENCMONTO.TabIndex = 14
        Me.lblENCMONTO.Text = "Monto:"
        '
        'lblENCPLAZO
        '
        Me.lblENCPLAZO.AutoSize = True
        Me.lblENCPLAZO.ForeColor = System.Drawing.Color.Black
        Me.lblENCPLAZO.Location = New System.Drawing.Point(6, 52)
        Me.lblENCPLAZO.Name = "lblENCPLAZO"
        Me.lblENCPLAZO.Size = New System.Drawing.Size(36, 13)
        Me.lblENCPLAZO.TabIndex = 13
        Me.lblENCPLAZO.Text = "Plazo:"
        '
        'lblENCFECHAVENCIMIENTO
        '
        Me.lblENCFECHAVENCIMIENTO.AutoSize = True
        Me.lblENCFECHAVENCIMIENTO.ForeColor = System.Drawing.Color.Black
        Me.lblENCFECHAVENCIMIENTO.Location = New System.Drawing.Point(467, 52)
        Me.lblENCFECHAVENCIMIENTO.Name = "lblENCFECHAVENCIMIENTO"
        Me.lblENCFECHAVENCIMIENTO.Size = New System.Drawing.Size(116, 13)
        Me.lblENCFECHAVENCIMIENTO.TabIndex = 12
        Me.lblENCFECHAVENCIMIENTO.Text = "Fecha de Vencimiento:"
        '
        'lblASOCIADO
        '
        Me.lblASOCIADO.AutoSize = True
        Me.lblASOCIADO.ForeColor = System.Drawing.Color.Black
        Me.lblASOCIADO.Location = New System.Drawing.Point(6, 19)
        Me.lblASOCIADO.Name = "lblASOCIADO"
        Me.lblASOCIADO.Size = New System.Drawing.Size(54, 13)
        Me.lblASOCIADO.TabIndex = 11
        Me.lblASOCIADO.Text = "Asociado:"
        '
        'lblENCESTADO
        '
        Me.lblENCESTADO.AutoSize = True
        Me.lblENCESTADO.ForeColor = System.Drawing.Color.Black
        Me.lblENCESTADO.Location = New System.Drawing.Point(536, 19)
        Me.lblENCESTADO.Name = "lblENCESTADO"
        Me.lblENCESTADO.Size = New System.Drawing.Size(46, 13)
        Me.lblENCESTADO.TabIndex = 7
        Me.lblENCESTADO.Text = "Estado :"
        '
        'frmMsGrHistorialGarantias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(725, 580)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(725, 580)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(725, 580)
        Me.Name = "frmMsGrHistorialGarantias"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Historial de Garantías"
        CType(Me.dgHISTORICOGARANTIAS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgHISTORICOGARANTIAS As System.Windows.Forms.DataGridView
    Friend WithEvents lblENCABEZADO As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblFECHAMODIFICACION As System.Windows.Forms.Label
    Friend WithEvents txtNOCOMPROBANTE As System.Windows.Forms.TextBox
    Friend WithEvents lblNOCOMPROBANTE As System.Windows.Forms.Label
    Friend WithEvents txtMONTO As System.Windows.Forms.TextBox
    Friend WithEvents lblMONTO As System.Windows.Forms.Label
    Friend WithEvents dtpFECHAMODIFICACION As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPLAZO As System.Windows.Forms.TextBox
    Friend WithEvents lblPLAZO As System.Windows.Forms.Label
    Friend WithEvents txtTASA As System.Windows.Forms.TextBox
    Friend WithEvents lblTASA As System.Windows.Forms.Label
    Friend WithEvents txtOBSERVACIONES As System.Windows.Forms.TextBox
    Friend WithEvents lblOBSERVACIONES As System.Windows.Forms.Label
    Friend WithEvents txtINSCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents lblINSCRIPCION As System.Windows.Forms.Label
    Friend WithEvents dtpFECHAINSCRIPCION As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFECHAINSCRIPCION As System.Windows.Forms.Label
    Friend WithEvents dtpFECHAPRESENTACION As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFECHAPRESENTACION As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblENCESTADO As System.Windows.Forms.Label
    Friend WithEvents lblENCTASA As System.Windows.Forms.Label
    Friend WithEvents lblENCMONTO As System.Windows.Forms.Label
    Friend WithEvents lblENCPLAZO As System.Windows.Forms.Label
    Friend WithEvents lblENCFECHAVENCIMIENTO As System.Windows.Forms.Label
    Friend WithEvents lblASOCIADO As System.Windows.Forms.Label
    Friend WithEvents lblENCFECHAOTOR As System.Windows.Forms.Label
    Friend WithEvents lblNUMSOLICITUD As System.Windows.Forms.Label
    Friend WithEvents btnMODIFICAR1 As MetroFramework.Controls.MetroButton
End Class
