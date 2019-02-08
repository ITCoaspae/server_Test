Public Class frmMsCBGestionCredEdit
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pAccion As String
    Private vCodGestor As String, vCodPrestamo As String, Tipo As String, NumSolicitud As Integer
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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents gbGestion As System.Windows.Forms.GroupBox
    Friend WithEvents txtHora As System.Windows.Forms.TextBox
    Friend WithEvents lblCompromiso As System.Windows.Forms.Label
    Friend WithEvents lblRango As System.Windows.Forms.Label
    Friend WithEvents txtDespacho As System.Windows.Forms.TextBox
    Friend WithEvents lblDespacho As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAcuerdo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCobranza As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoCobranza As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents txtCodDespacho As System.Windows.Forms.TextBox
    Friend WithEvents dtHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaPactada As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtCodBitacora As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gbGestion = New System.Windows.Forms.GroupBox()
        Me.txtCodBitacora = New System.Windows.Forms.TextBox()
        Me.dtpFechaPactada = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.dtHora = New System.Windows.Forms.DateTimePicker()
        Me.txtCodDespacho = New System.Windows.Forms.TextBox()
        Me.txtHora = New System.Windows.Forms.TextBox()
        Me.lblCompromiso = New System.Windows.Forms.Label()
        Me.lblRango = New System.Windows.Forms.Label()
        Me.txtDespacho = New System.Windows.Forms.TextBox()
        Me.lblDespacho = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtAcuerdo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTipoCobranza = New System.Windows.Forms.TextBox()
        Me.txtCodTipoCobranza = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.gbGestion.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbGestion
        '
        Me.gbGestion.BackColor = System.Drawing.Color.White
        Me.gbGestion.Controls.Add(Me.txtCodBitacora)
        Me.gbGestion.Controls.Add(Me.dtpFechaPactada)
        Me.gbGestion.Controls.Add(Me.Label23)
        Me.gbGestion.Controls.Add(Me.dtHora)
        Me.gbGestion.Controls.Add(Me.txtCodDespacho)
        Me.gbGestion.Controls.Add(Me.txtHora)
        Me.gbGestion.Controls.Add(Me.lblCompromiso)
        Me.gbGestion.Controls.Add(Me.lblRango)
        Me.gbGestion.Controls.Add(Me.txtDespacho)
        Me.gbGestion.Controls.Add(Me.lblDespacho)
        Me.gbGestion.Controls.Add(Me.txtObservaciones)
        Me.gbGestion.Controls.Add(Me.Label4)
        Me.gbGestion.Controls.Add(Me.Label3)
        Me.gbGestion.Controls.Add(Me.dtFecha)
        Me.gbGestion.Controls.Add(Me.txtAcuerdo)
        Me.gbGestion.Controls.Add(Me.Label9)
        Me.gbGestion.Controls.Add(Me.txtTipoCobranza)
        Me.gbGestion.Controls.Add(Me.txtCodTipoCobranza)
        Me.gbGestion.Controls.Add(Me.Label2)
        Me.gbGestion.Controls.Add(Me.Label1)
        Me.gbGestion.Location = New System.Drawing.Point(23, 245)
        Me.gbGestion.Name = "gbGestion"
        Me.gbGestion.Size = New System.Drawing.Size(640, 247)
        Me.gbGestion.TabIndex = 0
        Me.gbGestion.TabStop = False
        '
        'txtCodBitacora
        '
        Me.txtCodBitacora.Location = New System.Drawing.Point(242, 42)
        Me.txtCodBitacora.Name = "txtCodBitacora"
        Me.txtCodBitacora.Size = New System.Drawing.Size(8, 20)
        Me.txtCodBitacora.TabIndex = 205
        Me.txtCodBitacora.Visible = False
        '
        'dtpFechaPactada
        '
        Me.dtpFechaPactada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPactada.Location = New System.Drawing.Point(132, 87)
        Me.dtpFechaPactada.Name = "dtpFechaPactada"
        Me.dtpFechaPactada.Size = New System.Drawing.Size(176, 20)
        Me.dtpFechaPactada.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(6, 91)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(120, 16)
        Me.Label23.TabIndex = 204
        Me.Label23.Text = "Fecha Pactada:"
        '
        'dtHora
        '
        Me.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtHora.Location = New System.Drawing.Point(314, 215)
        Me.dtHora.Name = "dtHora"
        Me.dtHora.Size = New System.Drawing.Size(96, 20)
        Me.dtHora.TabIndex = 6
        Me.dtHora.Visible = False
        '
        'txtCodDespacho
        '
        Me.txtCodDespacho.BackColor = System.Drawing.Color.White
        Me.txtCodDespacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodDespacho.Location = New System.Drawing.Point(132, 189)
        Me.txtCodDespacho.Name = "txtCodDespacho"
        Me.txtCodDespacho.ReadOnly = True
        Me.txtCodDespacho.Size = New System.Drawing.Size(48, 20)
        Me.txtCodDespacho.TabIndex = 5
        Me.txtCodDespacho.Visible = False
        '
        'txtHora
        '
        Me.txtHora.BackColor = System.Drawing.Color.White
        Me.txtHora.Location = New System.Drawing.Point(132, 215)
        Me.txtHora.Name = "txtHora"
        Me.txtHora.ReadOnly = True
        Me.txtHora.Size = New System.Drawing.Size(176, 20)
        Me.txtHora.TabIndex = 7
        '
        'lblCompromiso
        '
        Me.lblCompromiso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompromiso.ForeColor = System.Drawing.Color.Teal
        Me.lblCompromiso.Location = New System.Drawing.Point(6, 65)
        Me.lblCompromiso.Name = "lblCompromiso"
        Me.lblCompromiso.Size = New System.Drawing.Size(488, 16)
        Me.lblCompromiso.TabIndex = 100
        Me.lblCompromiso.Text = "Compromiso de pago no debe exceder de "
        '
        'lblRango
        '
        Me.lblRango.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRango.ForeColor = System.Drawing.Color.Teal
        Me.lblRango.Location = New System.Drawing.Point(6, 39)
        Me.lblRango.Name = "lblRango"
        Me.lblRango.Size = New System.Drawing.Size(488, 16)
        Me.lblRango.TabIndex = 99
        Me.lblRango.Text = "Rango de morosidad:"
        '
        'txtDespacho
        '
        Me.txtDespacho.BackColor = System.Drawing.Color.White
        Me.txtDespacho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDespacho.Location = New System.Drawing.Point(186, 189)
        Me.txtDespacho.MaxLength = 100
        Me.txtDespacho.Name = "txtDespacho"
        Me.txtDespacho.ReadOnly = True
        Me.txtDespacho.Size = New System.Drawing.Size(446, 20)
        Me.txtDespacho.TabIndex = 4
        Me.txtDespacho.Visible = False
        '
        'lblDespacho
        '
        Me.lblDespacho.BackColor = System.Drawing.Color.White
        Me.lblDespacho.Location = New System.Drawing.Point(6, 193)
        Me.lblDespacho.Name = "lblDespacho"
        Me.lblDespacho.Size = New System.Drawing.Size(112, 16)
        Me.lblDespacho.TabIndex = 97
        Me.lblDespacho.Text = "Nombre Despacho:"
        Me.lblDespacho.Visible = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.White
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtObservaciones.Location = New System.Drawing.Point(132, 151)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ReadOnly = True
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(500, 32)
        Me.txtObservaciones.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(6, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Observaciones:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(6, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Hora de la Gestión:"
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(456, 87)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(176, 20)
        Me.dtFecha.TabIndex = 3
        '
        'txtAcuerdo
        '
        Me.txtAcuerdo.BackColor = System.Drawing.Color.White
        Me.txtAcuerdo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAcuerdo.Location = New System.Drawing.Point(132, 113)
        Me.txtAcuerdo.Multiline = True
        Me.txtAcuerdo.Name = "txtAcuerdo"
        Me.txtAcuerdo.ReadOnly = True
        Me.txtAcuerdo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAcuerdo.Size = New System.Drawing.Size(500, 32)
        Me.txtAcuerdo.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(314, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Fecha de la Gestión:"
        '
        'txtTipoCobranza
        '
        Me.txtTipoCobranza.BackColor = System.Drawing.Color.White
        Me.txtTipoCobranza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCobranza.Location = New System.Drawing.Point(178, 16)
        Me.txtTipoCobranza.MaxLength = 100
        Me.txtTipoCobranza.Name = "txtTipoCobranza"
        Me.txtTipoCobranza.ReadOnly = True
        Me.txtTipoCobranza.Size = New System.Drawing.Size(454, 20)
        Me.txtTipoCobranza.TabIndex = 1
        '
        'txtCodTipoCobranza
        '
        Me.txtCodTipoCobranza.BackColor = System.Drawing.Color.White
        Me.txtCodTipoCobranza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoCobranza.Location = New System.Drawing.Point(116, 16)
        Me.txtCodTipoCobranza.MaxLength = 20
        Me.txtCodTipoCobranza.Name = "txtCodTipoCobranza"
        Me.txtCodTipoCobranza.ReadOnly = True
        Me.txtCodTipoCobranza.Size = New System.Drawing.Size(56, 20)
        Me.txtCodTipoCobranza.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 32)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Acuerdo o Comentario:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Tipo de Cobranza:"
        '
        'fg
        '
        Me.fg.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
        Me.fg.BackColor = System.Drawing.SystemColors.Window
        Me.fg.BackColorAlternate = System.Drawing.Color.WhiteSmoke
        Me.fg.BackColorBkg = System.Drawing.SystemColors.AppWorkspace
        Me.fg.BackColorFixed = System.Drawing.Color.Teal
        Me.fg.BackColorSel = System.Drawing.SystemColors.Highlight
        Me.fg.Cols = 6
        Me.fg.ColumnInfo = "6,1,0,0,0,85,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.ForeColorFixed = System.Drawing.Color.White
        Me.fg.ForeColorSel = System.Drawing.SystemColors.HighlightText
        Me.fg.GridColor = System.Drawing.SystemColors.Control
        Me.fg.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.fg.Location = New System.Drawing.Point(23, 63)
        Me.fg.Name = "fg"
        Me.fg.NodeClosedPicture = Nothing
        Me.fg.NodeOpenPicture = Nothing
        Me.fg.OutlineBar = C1.Win.C1FlexGrid.Classic.OutlineBarSettings.flexOutlineBarNone
        Me.fg.OutlineCol = -1
        Me.fg.Rows = 2
        Me.fg.SheetBorder = System.Drawing.Color.Black
        Me.fg.Size = New System.Drawing.Size(640, 176)
        Me.fg.TabIndex = 17
        Me.fg.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.None
        Me.fg.TreeColor = System.Drawing.Color.DarkGray
        Me.fg.WallPaper = Nothing
        '
        'btnGuardar1
        '
        Me.btnGuardar1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuardar1.Location = New System.Drawing.Point(588, 498)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1015
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCBGestionCredEdit
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(686, 555)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.gbGestion)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(686, 555)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(686, 555)
        Me.Name = "frmMsCBGestionCredEdit"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consulta Gestión del Crédito"
        Me.gbGestion.ResumeLayout(False)
        Me.gbGestion.PerformLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property CodGestor() As String
        Get
            Return vCodGestor
        End Get
        Set(ByVal Value As String)
            vCodGestor = Value
        End Set
    End Property

    Public Property CodPrestamo() As String
        Get
            Return vCodPrestamo
        End Get
        Set(ByVal Value As String)
            vCodPrestamo = Value
        End Set
    End Property

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As New wrCredito.wsLibCred, ds As New DataSet, dr As DataRow
            Dim pCampos As String ', pValores As String

            If Me.pAccion = "Modificar" Then
                If Me.txtCodTipoCobranza.Text.Trim = "" Then
                    MsgBox("El Tipo de Cobranza no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Cobranza")
                    Exit Sub
                End If
                If Tipo = "J" Then
                    pCampos = "CodTipoCobranza='" & Me.txtCodTipoCobranza.Text.Trim & "',Fecha='" & Format(Me.dtFecha.Value, "dd/MM/yyyy") & "',Hora='" & Format(Me.dtHora.Value, "HH:mm") & "',Comentario='" & Me.txtAcuerdo.Text.Trim & "',CodDespacho='" & Me.txtDespacho.Text.Trim & "',Observaciones='" & Me.txtObservaciones.Text.Trim & "',FechaPactada='" & Format(Me.dtpFechaPactada.Value, "dd/MM/yyyy") & "',PagoEfectuado='0'"
                    If oCred.ModificarBitacoraGestores("CodBitacora=" & Me.txtCodBitacora.Text.Trim & "", pCampos, sUsuario, sPassword, sSucursal) = True Then
                        ds = oCred.ConsultarPrestamos("*", "CodPrestamo = '" & Me.CodPrestamo.Trim & "'", "", sUsuario, sPassword, sSucursal)
                        If ds.Tables(0).Rows.Count > 0 Then
                            dr = ds.Tables("PRPrestamos").Rows(0)
                            NumSolicitud = CInt(dr("NumSolicitud"))
                        End If
                        If oCred.ModificarPrestamos(NumSolicitud, "Estado='C'", sUsuario, sPassword, sSucursal) = True Then
                            MsgBox("Registro modificado correctamente.", MsgBoxStyle.Information, "Módulo - Cobranza")
                            Me.Dispose()
                        End If
                    Else
                        MsgBox("El registro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Cobranzas")
                    End If
                ElseIf Tipo = "N" Then
                    pCampos = "CodTipoCobranza='" & Me.txtCodTipoCobranza.Text.Trim & "',Fecha='" & Format(Me.dtFecha.Value, "dd/MM/yyyy") & "',Hora='" & Format(Me.dtHora.Value, "HH:mm") & "',Comentario='" & Me.txtAcuerdo.Text.Trim & "',Observaciones='" & Me.txtObservaciones.Text.Trim & "',FechaPactada='" & Format(Me.dtpFechaPactada.Value, "dd/MM/yyyy") & "',PagoEfectuado='0'"
                    If oCred.ModificarBitacoraGestores("CodBitacora=" & Me.txtCodBitacora.Text.Trim & "", pCampos, sUsuario, sPassword, sSucursal) = True Then
                        MsgBox("Registro modificado correctamente.", MsgBoxStyle.Information, "Módulo - Cobranza")
                        Me.Dispose()
                    Else
                        MsgBox("El registro no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Cobranzas")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub frmMsCBGestionCredEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        'Dim dr As DataRow
        Me.dtFecha.Value = Now
        Me.dtFecha.Value = Now
        Me.txtHora.Text = Now.TimeOfDay.ToString

        ds = oCred.ConsultarGestoresxCredito("*", "CodPrestamo='" & Me.CodPrestamo.Trim & "' AND CodGestor='" & Me.CodGestor.Trim & "'", "CodGestor", sUsuario, sPassword, sSucursal)
        Filas = ds.Tables(0).Rows()
        If Filas.Count > 0 Then
            fg.DataSource = oCred.ConsultarBitacoraGestores("*", "CodGestor='" & Me.CodGestor.Trim & "' and CodPrestamo='" & vCodPrestamo & "'", "CodBitacora", sUsuario, sPassword, sSucursal).Tables(0)
        End If
        If Me.pAccion = "Modificar" Then
            Me.dtHora.Visible = True
            Me.txtCodDespacho.ReadOnly = False
            Me.txtObservaciones.ReadOnly = False
            Me.txtAcuerdo.ReadOnly = False
            Me.dtFecha.Enabled = True
            Me.txtCodTipoCobranza.ReadOnly = True
        End If

    End Sub

    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.DoubleClick
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection

        ds = oCred.ConsultarBitacoraGestores("*", "CodBitacora='" & fg.Item(fg.Row, "CodBitacora") & "'", "CodBitacora", sUsuario, sPassword,sSucursal)
        Filas = ds.Tables(0).Rows()
        If Filas.Count > 0 Then
            Me.txtCodBitacora.Text = fg.Item(fg.Row, "CodBitacora")
            Me.txtCodTipoCobranza.Text = IIf(IsDBNull(Filas.Item(0)("CodTipoCobranza")), "", Filas.Item(0)("CodTipoCobranza"))
            Me.dtFecha.Value = IIf(IsDBNull(Filas.Item(0)("Fecha")), Now, Filas.Item(0)("Fecha"))
            Me.dtpFechaPactada.Value = IIf(IsDBNull(Filas.Item(0)("FechaPactada")), Now, Filas.Item(0)("FechaPactada"))
            Me.txtHora.Text = IIf(IsDBNull(Filas.Item(0)("Hora")), "", Filas.Item(0)("Hora"))
            Me.dtHora.Value = Now
            Me.txtAcuerdo.Text = IIf(IsDBNull(Filas.Item(0)("Comentario")), "", Filas.Item(0)("Comentario"))
            Me.txtCodDespacho.Text = IIf(IsDBNull(Filas.Item(0)("CodDespacho")), "", Filas.Item(0)("CodDespacho"))
            Me.txtObservaciones.Text = IIf(IsDBNull(Filas.Item(0)("Observaciones")), "", Filas.Item(0)("Observaciones"))
            If Me.txtCodTipoCobranza.Text.Trim <> "" Then
                ds = oCred.ConsultarTipoCobranza("Descripcion,Tipo", "CodTipoCobranza='" & Me.txtCodTipoCobranza.Text.Trim & "'", "CodTipoCobranza", sUsuario, sPassword,sSucursal)
                Filas = ds.Tables("CBTipoCobranza").Rows()
                If Filas.Count > 0 Then
                    Tipo = IIf(IsDBNull(Filas.Item(0)("Tipo")), "N", Filas.Item(0)("Tipo"))
                    If Tipo = "J" Then
                        Me.txtCodDespacho.Visible = True
                        Me.txtDespacho.Visible = True
                        Me.lblDespacho.Visible = True
                    Else
                        Me.txtCodDespacho.Visible = False
                        Me.txtDespacho.Visible = False
                        Me.lblDespacho.Visible = False
                    End If
                    Me.txtTipoCobranza.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                End If
            End If
            If Me.txtCodDespacho.Text.Trim <> "" Then
                ds = oCred.ConsultarDespacho("Descripcion", "CodDespacho='" & Me.txtCodDespacho.Text.Trim & "'", "CodDespacho", sUsuario, sPassword,sSucursal)
                Filas = ds.Tables("CBDespachos").Rows()
                If Filas.Count > 0 Then
                    Me.txtDespacho.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                End If
            End If
        End If
    End Sub


    Private Sub txtCodTipoCobranza_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoCobranza.DoubleClick
        If pAccion = "Consultar" Then Exit Sub

        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Tipo de Cobranza"
        Dim oPerif As wrCredito.wsLibCred, ds As New Data.DataSet

        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarTipoCobranza("CodTipoCobranza,DiaInicio,DiaFin,Descripcion,Tipo", "", "CodTipoCobranza", sUsuario, sPassword,sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Tipo = CStr(ofrm.Resultado5.Trim)
            If Tipo = "J" Then
                Me.txtCodDespacho.Visible = True
                Me.txtDespacho.Visible = True
                Me.lblDespacho.Visible = True
            Else
                Me.txtCodDespacho.Visible = False
                Me.txtDespacho.Visible = False
                Me.lblDespacho.Visible = False
            End If
            txtCodTipoCobranza.Text = ofrm.Resultado.Trim
            txtTipoCobranza.Text = ofrm.Resultado4.Trim
            lblRango.Text = "Rango de morosidad: De " & ofrm.Resultado2.Trim & " a " & ofrm.Resultado3.Trim & " días."
            lblCompromiso.Text = "Compromiso de pago no debe exceder de " & ofrm.Resultado5.Trim & " día(s)."
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Tipo Cobranza - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class