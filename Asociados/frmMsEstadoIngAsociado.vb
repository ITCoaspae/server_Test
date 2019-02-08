Public Class frmMsEstadoIngAsociado
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pDui As String, pEstado As String, pCorrelativo As String, pNoSocio As String
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private pFecha As Date
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
    Friend WithEvents gbDatDoc As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoRecibo As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents chkOtrosDoc As System.Windows.Forms.CheckBox
    Friend WithEvents chkNit As System.Windows.Forms.CheckBox
    Friend WithEvents chkDui As System.Windows.Forms.CheckBox
    Friend WithEvents chkTit As System.Windows.Forms.CheckBox
    Friend WithEvents chkFoto As System.Windows.Forms.CheckBox
    Friend WithEvents chkDocs As System.Windows.Forms.CheckBox
    Friend WithEvents txtOtrosDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodAntiguo As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodCuota As System.Windows.Forms.TextBox
    Friend WithEvents txtCuota As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtAnnio As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gbDatDoc = New System.Windows.Forms.GroupBox()
        Me.txtAnnio = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.txtCuota = New System.Windows.Forms.TextBox()
        Me.txtCodCuota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoRecibo = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.chkOtrosDoc = New System.Windows.Forms.CheckBox()
        Me.chkNit = New System.Windows.Forms.CheckBox()
        Me.chkDui = New System.Windows.Forms.CheckBox()
        Me.chkTit = New System.Windows.Forms.CheckBox()
        Me.chkFoto = New System.Windows.Forms.CheckBox()
        Me.chkDocs = New System.Windows.Forms.CheckBox()
        Me.txtOtrosDoc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.gbDatDoc.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDatDoc
        '
        Me.gbDatDoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbDatDoc.BackColor = System.Drawing.Color.White
        Me.gbDatDoc.Controls.Add(Me.txtAnnio)
        Me.gbDatDoc.Controls.Add(Me.txtTipo)
        Me.gbDatDoc.Controls.Add(Me.txtCuota)
        Me.gbDatDoc.Controls.Add(Me.txtCodCuota)
        Me.gbDatDoc.Controls.Add(Me.Label1)
        Me.gbDatDoc.Controls.Add(Me.txtNoRecibo)
        Me.gbDatDoc.Controls.Add(Me.Label28)
        Me.gbDatDoc.Controls.Add(Me.chkOtrosDoc)
        Me.gbDatDoc.Controls.Add(Me.chkNit)
        Me.gbDatDoc.Controls.Add(Me.chkDui)
        Me.gbDatDoc.Controls.Add(Me.chkTit)
        Me.gbDatDoc.Controls.Add(Me.chkFoto)
        Me.gbDatDoc.Controls.Add(Me.chkDocs)
        Me.gbDatDoc.Controls.Add(Me.txtOtrosDoc)
        Me.gbDatDoc.Controls.Add(Me.Label4)
        Me.gbDatDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatDoc.ForeColor = System.Drawing.Color.Black
        Me.gbDatDoc.Location = New System.Drawing.Point(23, 157)
        Me.gbDatDoc.Name = "gbDatDoc"
        Me.gbDatDoc.Size = New System.Drawing.Size(579, 194)
        Me.gbDatDoc.TabIndex = 73
        Me.gbDatDoc.TabStop = False
        Me.gbDatDoc.Text = "Entrega de Documentos"
        '
        'txtAnnio
        '
        Me.txtAnnio.Location = New System.Drawing.Point(389, 130)
        Me.txtAnnio.MaxLength = 50
        Me.txtAnnio.Name = "txtAnnio"
        Me.txtAnnio.Size = New System.Drawing.Size(32, 20)
        Me.txtAnnio.TabIndex = 112
        Me.txtAnnio.Visible = False
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(351, 130)
        Me.txtTipo.MaxLength = 50
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(32, 20)
        Me.txtTipo.TabIndex = 111
        Me.txtTipo.Visible = False
        '
        'txtCuota
        '
        Me.txtCuota.Location = New System.Drawing.Point(247, 156)
        Me.txtCuota.MaxLength = 50
        Me.txtCuota.Name = "txtCuota"
        Me.txtCuota.ReadOnly = True
        Me.txtCuota.Size = New System.Drawing.Size(317, 20)
        Me.txtCuota.TabIndex = 110
        '
        'txtCodCuota
        '
        Me.txtCodCuota.Location = New System.Drawing.Point(185, 156)
        Me.txtCodCuota.MaxLength = 50
        Me.txtCodCuota.Name = "txtCodCuota"
        Me.txtCodCuota.Size = New System.Drawing.Size(56, 20)
        Me.txtCodCuota.TabIndex = 109
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 16)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Tipo de cuota Aspirante:"
        '
        'txtNoRecibo
        '
        Me.txtNoRecibo.Location = New System.Drawing.Point(185, 130)
        Me.txtNoRecibo.MaxLength = 50
        Me.txtNoRecibo.Name = "txtNoRecibo"
        Me.txtNoRecibo.ReadOnly = True
        Me.txtNoRecibo.Size = New System.Drawing.Size(160, 20)
        Me.txtNoRecibo.TabIndex = 9
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(3, 130)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(176, 16)
        Me.Label28.TabIndex = 107
        Me.Label28.Text = "Número de recibo de cuota inicial:"
        '
        'chkOtrosDoc
        '
        Me.chkOtrosDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOtrosDoc.ForeColor = System.Drawing.Color.Black
        Me.chkOtrosDoc.Location = New System.Drawing.Point(396, 68)
        Me.chkOtrosDoc.Name = "chkOtrosDoc"
        Me.chkOtrosDoc.Size = New System.Drawing.Size(184, 16)
        Me.chkOtrosDoc.TabIndex = 8
        Me.chkOtrosDoc.Text = "Entrega de Otros documentos"
        '
        'chkNit
        '
        Me.chkNit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNit.ForeColor = System.Drawing.Color.Black
        Me.chkNit.Location = New System.Drawing.Point(6, 68)
        Me.chkNit.Name = "chkNit"
        Me.chkNit.Size = New System.Drawing.Size(184, 16)
        Me.chkNit.TabIndex = 6
        Me.chkNit.Text = "Entrega de Fotocopia NIT"
        '
        'chkDui
        '
        Me.chkDui.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDui.ForeColor = System.Drawing.Color.Black
        Me.chkDui.Location = New System.Drawing.Point(396, 46)
        Me.chkDui.Name = "chkDui"
        Me.chkDui.Size = New System.Drawing.Size(184, 16)
        Me.chkDui.TabIndex = 5
        Me.chkDui.Text = "Entrega de Fotocopia DUI"
        '
        'chkTit
        '
        Me.chkTit.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTit.ForeColor = System.Drawing.Color.Black
        Me.chkTit.Location = New System.Drawing.Point(6, 46)
        Me.chkTit.Name = "chkTit"
        Me.chkTit.Size = New System.Drawing.Size(184, 16)
        Me.chkTit.TabIndex = 4
        Me.chkTit.Text = "Entrega de Fotocopia Título"
        '
        'chkFoto
        '
        Me.chkFoto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFoto.ForeColor = System.Drawing.Color.Black
        Me.chkFoto.Location = New System.Drawing.Point(396, 24)
        Me.chkFoto.Name = "chkFoto"
        Me.chkFoto.Size = New System.Drawing.Size(176, 16)
        Me.chkFoto.TabIndex = 3
        Me.chkFoto.Text = "Entrega de Fotografías"
        '
        'chkDocs
        '
        Me.chkDocs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDocs.ForeColor = System.Drawing.Color.Black
        Me.chkDocs.Location = New System.Drawing.Point(6, 24)
        Me.chkDocs.Name = "chkDocs"
        Me.chkDocs.Size = New System.Drawing.Size(216, 16)
        Me.chkDocs.TabIndex = 2
        Me.chkDocs.Text = "Entrega de documentos completa"
        '
        'txtOtrosDoc
        '
        Me.txtOtrosDoc.Location = New System.Drawing.Point(108, 90)
        Me.txtOtrosDoc.MaxLength = 255
        Me.txtOtrosDoc.Multiline = True
        Me.txtOtrosDoc.Name = "txtOtrosDoc"
        Me.txtOtrosDoc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOtrosDoc.Size = New System.Drawing.Size(456, 34)
        Me.txtOtrosDoc.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(3, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Otros documentos:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.GroupBox4.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(579, 88)
        Me.GroupBox4.TabIndex = 120
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Asociado"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(240, 24)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(120, 20)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'txtCodAntiguo
        '
        Me.txtCodAntiguo.Location = New System.Drawing.Point(464, 24)
        Me.txtCodAntiguo.MaxLength = 10
        Me.txtCodAntiguo.Name = "txtCodAntiguo"
        Me.txtCodAntiguo.Size = New System.Drawing.Size(104, 20)
        Me.txtCodAntiguo.TabIndex = 2
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(376, 24)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(88, 16)
        Me.Label48.TabIndex = 114
        Me.Label48.Text = "Código Antiguo:"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(200, 24)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(32, 16)
        Me.Label31.TabIndex = 94
        Me.Label31.Text = "Dui:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.Location = New System.Drawing.Point(104, 24)
        Me.txtNoSocio.MaxLength = 8
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(88, 20)
        Me.txtNoSocio.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "No. Asociado:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(104, 56)
        Me.txtNombre.MaxLength = 150
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(464, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(24, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 16)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Asociado:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(516, 357)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(87, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 138
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsEstadoIngAsociado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(625, 401)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gbDatDoc)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsEstadoIngAsociado"
        Me.ShowInTaskbar = False
        Me.Text = "Activación de Aspirante"
        Me.gbDatDoc.ResumeLayout(False)
        Me.gbDatDoc.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMsEstadoIngAsociado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            If pEstado <> "0" Then Me.btnGuardar1.Visible = False
            If Me.btnGuardar1.Text = "&Guardar" Then

                Dim Filas As Data.DataRowCollection

                ds = oAsoc.ConsultarEstadoIngreso("*", "a.Correlativo='" & pCorrelativo & "'", "a.Dui", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtDui.Text = pDui.ToString.Trim
                    If Filas.Item(0)("DocumentosCompletos") = 0 Then
                        chkDocs.Checked = False
                    ElseIf Filas.Item(0)("DocumentosCompletos") = 1 Then
                        chkDocs.Checked = True
                    End If
                    If Filas.Item(0)("Fotografias") = 0 Then
                        chkFoto.Checked = False
                    ElseIf Filas.Item(0)("Fotografias") = 1 Then
                        chkFoto.Checked = True
                    End If
                    If (Filas.Item(0)("TituloFotocop")) = 0 Then
                        chkTit.Checked = False
                    ElseIf (Filas.Item(0)("TituloFotocop")) = 1 Then
                        chkTit.Checked = True
                    End If
                    If (Filas.Item(0)("DUIFotocop")) = 0 Then
                        chkDui.Checked = False
                    ElseIf (Filas.Item(0)("DUIFotocop")) = 1 Then
                        chkDui.Checked = True
                    End If
                    If (Filas.Item(0)("NITFotocop")) = 0 Then
                        chkNit.Checked = False
                    ElseIf (Filas.Item(0)("NITFotocop")) = 1 Then
                        chkNit.Checked = True
                    End If
                    If Not Filas.Item(0)("OtrosDescripcion") Is DBNull.Value Then
                        txtOtrosDoc.Text = CStr(Filas.Item(0)("OtrosDescripcion"))
                    End If
                    If CStr(Filas.Item(0)("Otros")) = 0 Then
                        chkOtrosDoc.Checked = False
                    ElseIf CStr(Filas.Item(0)("Otros")) = 1 Then
                        chkOtrosDoc.Checked = True
                    End If
                    If IsDBNull(Filas.Item(0)("CodCuota")) = True Then
                        Me.txtCodCuota.Text = ""
                    Else
                        Me.txtCodCuota.Text = CStr(Filas.Item(0)("CodCuota"))
                    End If
                    Me.txtNoRecibo.Text = IIf(IsDBNull(Filas.Item(0)("ReciboCuotaInicial")), "", Filas.Item(0)("ReciboCuotaInicial"))
                    Me.txtAnnio.Text = IIf(IsDBNull(Filas.Item(0)("Annio")), 0, Filas.Item(0)("Annio"))
                    Me.txtTipo.Text = IIf(IsDBNull(Filas.Item(0)("Tipo")), "", Filas.Item(0)("Tipo"))
                End If
                ds = oAsoc.ConsultarAsociado("NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,FechaEstado", "Dui='" & Trim(pDui) & "'", "Dui", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNoSocio.Text = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))
                    txtCodAntiguo.Text = IIf(IsDBNull(Filas.Item(0)("CodAntiguo")), "", Filas.Item(0)("CodAntiguo"))
                    txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                    txtDui.Enabled = False
                    txtCodAntiguo.Enabled = False
                    txtNoSocio.Enabled = False
                    txtNombre.Enabled = False
                    pFecha = IIf(IsDBNull(Filas.Item(0)("FechaEstado")), Now, Filas.Item(0)("FechaEstado"))
                    CargaRecibosCuota()
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GuardarDatos()

        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String, ds As New DataSet, Filas As DataRowCollection
        Try
            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "DocumentosCompletos='" & System.Math.Abs(CInt(chkDocs.Checked)) & "',Fotografias='" & System.Math.Abs(CInt(chkFoto.Checked)) & "',TituloFotocop='" & System.Math.Abs(CInt(chkTit.Checked)) & "',DUIFotocop='" & System.Math.Abs(CInt(Me.chkDui.Checked)) & "',NITFotocop='" & System.Math.Abs(CInt(Me.chkNit.Checked)) & "',ReciboCuotaInicial='" & Trim(Me.txtNoRecibo.Text) & "',OtrosDescripcion='" & Trim(Me.txtOtrosDoc.Text) & "',Otros='" & System.Math.Abs(CInt(Me.chkOtrosDoc.Checked)) & "',CodCuota='" & Me.txtCodCuota.Text.Trim & "',FechaAspirante='" & Format(Now, "dd/MM/yyyy") & "',Tipo='" & txtTipo.Text & "',Annio=" & txtAnnio.Text.Trim & ""
                If oAsoc.ModificarEstadoIngreso("Correlativo='" & pCorrelativo & "'", pCampos, sUsuario, sPassword, sSucursal) = True Then
                    If ValidaAspirante() = True Then
                        ds = oAsoc.ConsultarAsociado("Correlativo", "Dui='" & pDui & "'", "", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            oAsoc.ModificarAsociado(Filas.Item(0)("Correlativo"), "", "", "EstadoIngreso=1", sUsuario, sPassword, sSucursal)
                        End If
                    End If
                    MsgBox("El Registro ha sido modificado.", MsgBoxStyle.Information)
                    Me.Dispose()
                Else
                    MsgBox("El Registro no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtNoRecibo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = True Or Char.IsControl(e.KeyChar) = True Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Function ValidaAspirante() As Boolean
        If Me.chkDocs.Checked = False Then
            ValidaAspirante = False
        ElseIf Me.chkDui.Checked = False Then
            ValidaAspirante = False
        ElseIf Me.chkNit.Checked = False Then
            ValidaAspirante = False
        ElseIf Me.chkFoto.Checked = False Then
            ValidaAspirante = False
        ElseIf Me.chkTit.Checked = False Then
            ValidaAspirante = False
        ElseIf Trim(Me.txtNoRecibo.Text) = "" Then
            ValidaAspirante = False
        Else
            ValidaAspirante = True
        End If
    End Function

    Private Sub txtCodAntiguo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodAntiguo.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                If txtCodAntiguo.Text.Trim = "" Then
                    txtCodAntiguo_DoubleClick(sender, e)
                Else
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                    ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "CodAntiguo='" & txtCodAntiguo.Text.Trim & "' and EstadoIngreso=1", "DUI,CodAntiguo", sUsuario, sPassword, sSucursal)
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
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "EstadoIngreso=1", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
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
                    ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "NoSocio='" & txtNoSocio.Text.Trim & "' and EstadoIngreso=1", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
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
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "EstadoIngreso=1", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
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

    Private Sub txtCodCuota_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCuota.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Tipos de Cuota"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, vFecha As Date, Filas As Data.DataRowCollection
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarTipoCuota("*", "Estado='1'", "CodCuota", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodCuota.Text = ofrm.Resultado.Trim
            Me.txtCuota.Text = ofrm.Resultado2.Trim
            ds = oAsoc.ConsultarTipoCuota("*", "CodCuota='" & Me.txtCodCuota.Text.Trim & "'", "CodCuota", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                If Filas.Item(0)("Promocion") = "1" Then
                    vFecha = Filas.Item(0)("FechaFin")
                    If vFecha < Now.ToShortDateString Then
                        oAsoc.ModificarTipoCuota(ofrm.Resultado.Trim, "Estado='0'", sUsuario, sPassword, sSucursal)
                        Me.txtCodCuota.Text = ""
                        Me.txtCuota.Text = ""
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Tipos de Cuota- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Function ObtenerListaFacturas() As String

    '    Dim oCaja As New wrCaja.wsLibCaja, ds As New Data.DataSet, dr As DataRow, pLista As String

    '    ds = oCaja.ObtenerListaFacturas(False, "", "", "", Me.txtDui.Text.Trim, sUsuario, sPassword,sSucursal)
    '    For Each dr In ds.Tables(0).Rows

    '    Next

    'End Function

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
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "EstadoIngreso=1", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
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

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        GuardarDatos()
    End Sub

    Private Sub CargaRecibosCuota()

        Dim oCaja As New wrCaja.wsLibCaja, ds As New Data.DataSet, dsTransf As New DataSet, dr As DataRow, pNumFacts As String, pAnnio As String, pTipo As String, oAh As New wrAhorro.wsLibAhorro
        Try
            'If Me.pNoSocio.Trim.Equals(Me.txtNoSocio.Text.Trim) = True Then 'Regitro actual
            ds = oCaja.ConsultarEncabezadoDetalleFacturasxFiltro("a.IdMovimiento,a.Annio,a.Tipo", "a.Dui='" & pDui & "' and a.Estado<>'A' and b.CodItem='1009' and Fec_Mov>='" & pFecha.ToShortDateString & "'", "a.IdMovimiento", sUsuario, sPassword, sSucursal)
            pNumFacts = ""
            For Each dr In ds.Tables(0).Rows
                If pNumFacts.Trim = "" Then
                    pNumFacts = dr("IdMovimiento")
                    pAnnio = dr("Annio")
                    pTipo = dr("Tipo")
                    pNumFacts = pNumFacts.Trim
                Else
                    pNumFacts = pNumFacts & " - " & CStr(dr("IdMovimiento")).Trim
                End If
            Next
            dsTransf = oAh.ConsultarTransferencia("top 1 a.CodTransferencia", "a.Dui='" & pDui & "' and Estado<>'A' and Membresia='1' ", "a.CodTransferencia", "0", sUsuario, sPassword, sSucursal)
            For Each dr In dsTransf.Tables(0).Rows
                If pNumFacts.Trim = "" Then
                    pNumFacts = dr("CodTransferencia")
                    pAnnio = "0"
                    pTipo = ""
                    pNumFacts = pNumFacts.Trim
                Else
                    pNumFacts = pNumFacts & " - " & CStr(dr("CodTransferencia")).Trim
                End If
            Next
            Me.txtNoRecibo.Text = pNumFacts
            Me.txtAnnio.Text = pAnnio
            Me.txtTipo.Text = pTipo
            'Else 'Registro histórico
            'End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Facturas " & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

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

    Private Sub gbDatDoc_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbDatDoc.Enter

    End Sub
End Class