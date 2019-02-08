Public Class frmMsCaPosteo
    Inherits System.Windows.Forms.Form : Public rsc As System.Resources.ResourceManager

    Private pDui As String, pNoCuenta As String, pNombre As String, pNoLibreta As String, pRetiro As Boolean, pCodTipoAhorro As String

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SysFinCoop.resMain", asm) : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

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
    Friend WithEvents btnInicializarLibreta As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents c1nNum As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNoLibreta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c1nSaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents c1nCorr As C1.Win.C1Input.C1NumericEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsCaPosteo))
        Me.btnInicializarLibreta = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.c1nNum = New C1.Win.C1Input.C1NumericEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDui = New C1.Win.C1Input.C1TextBox
        Me.txtNoLibreta = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.c1nSaldo = New C1.Win.C1Input.C1NumericEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtNoCuenta = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.c1nCorr = New C1.Win.C1Input.C1NumericEdit
        CType(Me.c1nNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCorr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInicializarLibreta
        '
        Me.btnInicializarLibreta.BackColor = System.Drawing.SystemColors.Control
        Me.btnInicializarLibreta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicializarLibreta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicializarLibreta.Image = CType(resources.GetObject("btnInicializarLibreta.Image"), System.Drawing.Image)
        Me.btnInicializarLibreta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInicializarLibreta.Location = New System.Drawing.Point(64, 152)
        Me.btnInicializarLibreta.Name = "btnInicializarLibreta"
        Me.btnInicializarLibreta.Size = New System.Drawing.Size(128, 24)
        Me.btnInicializarLibreta.TabIndex = 2
        Me.btnInicializarLibreta.Text = "&Inicializar Libreta"
        Me.btnInicializarLibreta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInicializarLibreta.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(192, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 205
        Me.Label1.Text = "Nombre de Asociado:"
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.Color.White
        Me.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombre.Location = New System.Drawing.Point(192, 32)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(336, 20)
        Me.lblNombre.TabIndex = 191
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(376, 152)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(88, 24)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "   &Salir"
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.SystemColors.Control
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(216, 152)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(128, 24)
        Me.btnAceptar.TabIndex = 3
        Me.btnAceptar.Text = "   &Postear Libreta"
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'c1nNum
        '
        Me.c1nNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nNum.CustomFormat = "#0"
        Me.c1nNum.DataType = GetType(Short)
        Me.c1nNum.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nNum.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nNum.Increment = CType(1, Short)
        Me.c1nNum.Location = New System.Drawing.Point(424, 96)
        Me.c1nNum.MaxLength = 3
        Me.c1nNum.Name = "c1nNum"
        Me.c1nNum.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nNum.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nNum.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nNum.ShowDropDownButton = False
        Me.c1nNum.ShowUpDownButtons = False
        Me.c1nNum.Size = New System.Drawing.Size(104, 21)
        Me.c1nNum.TabIndex = 1
        Me.c1nNum.Tag = Nothing
        Me.c1nNum.Value = CType(0, Short)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(248, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 16)
        Me.Label4.TabIndex = 204
        Me.Label4.Text = "No. de última línea impresa:"
        '
        'txtDui
        '
        Me.txtDui.AcceptsReturn = True
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(24, 32)
        Me.txtDui.MaxLength = 20
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.ReadOnly = True
        Me.txtDui.Size = New System.Drawing.Size(128, 20)
        Me.txtDui.TabIndex = 190
        Me.txtDui.Tag = Nothing
        '
        'txtNoLibreta
        '
        Me.txtNoLibreta.AcceptsReturn = True
        Me.txtNoLibreta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoLibreta.Location = New System.Drawing.Point(384, 64)
        Me.txtNoLibreta.MaxLength = 20
        Me.txtNoLibreta.Name = "txtNoLibreta"
        Me.txtNoLibreta.ReadOnly = True
        Me.txtNoLibreta.Size = New System.Drawing.Size(144, 20)
        Me.txtNoLibreta.TabIndex = 192
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(312, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 203
        Me.Label3.Text = "No. Libreta:"
        '
        'c1nSaldo
        '
        Me.c1nSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSaldo.CustomFormat = "###,###,##0.00"
        Me.c1nSaldo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nSaldo.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nSaldo.Location = New System.Drawing.Point(96, 96)
        Me.c1nSaldo.Name = "c1nSaldo"
        Me.c1nSaldo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSaldo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSaldo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSaldo.ShowDropDownButton = False
        Me.c1nSaldo.ShowUpDownButtons = False
        Me.c1nSaldo.Size = New System.Drawing.Size(128, 21)
        Me.c1nSaldo.TabIndex = 0
        Me.c1nSaldo.Tag = Nothing
        Me.c1nSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(24, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 16)
        Me.Label14.TabIndex = 202
        Me.Label14.Text = "Saldo:"
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuenta.Location = New System.Drawing.Point(96, 64)
        Me.txtNoCuenta.MaxLength = 20
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.ReadOnly = True
        Me.txtNoCuenta.Size = New System.Drawing.Size(200, 20)
        Me.txtNoCuenta.TabIndex = 193
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 201
        Me.Label2.Text = "No. Cuenta:"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(24, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(40, 16)
        Me.Label31.TabIndex = 200
        Me.Label31.Text = "Dui:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(272, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 206
        Me.Label5.Text = "Correlativo de Libreta:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'c1nCorr
        '
        Me.c1nCorr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCorr.CustomFormat = "#0"
        Me.c1nCorr.DataType = GetType(Short)
        Me.c1nCorr.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nCorr.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCorr.Increment = CType(1, Short)
        Me.c1nCorr.Location = New System.Drawing.Point(424, 120)
        Me.c1nCorr.MaxLength = 3
        Me.c1nCorr.Name = "c1nCorr"
        Me.c1nCorr.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCorr.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCorr.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nCorr.ShowDropDownButton = False
        Me.c1nCorr.ShowUpDownButtons = False
        Me.c1nCorr.Size = New System.Drawing.Size(104, 21)
        Me.c1nCorr.TabIndex = 2
        Me.c1nCorr.Tag = Nothing
        Me.c1nCorr.Value = CType(0, Short)
        '
        'frmMsCaPosteo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(568, 191)
        Me.Controls.Add(Me.c1nCorr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnInicializarLibreta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.c1nNum)
        Me.Controls.Add(Me.txtNoLibreta)
        Me.Controls.Add(Me.c1nSaldo)
        Me.Controls.Add(Me.txtNoCuenta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label31)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsCaPosteo"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Posteo de Libreta"
        CType(Me.c1nNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCorr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Propiedades"

    Public Property TipoAhorro() As String
        Get
            Return pCodTipoAhorro
        End Get
        Set(ByVal Value As String)
            pCodTipoAhorro = Value
        End Set
    End Property

    Public Property Retiro() As Boolean
        Get
            Return pRetiro
        End Get
        Set(ByVal Value As Boolean)
            pRetiro = Value
        End Set
    End Property

    Public Property NoLibreta() As String
        Get
            Return pNoLibreta
        End Get
        Set(ByVal Value As String)
            pNoLibreta = Value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return pNombre
        End Get
        Set(ByVal Value As String)
            pNombre = Value
        End Set
    End Property

    Public Property NoCuenta() As String
        Get
            Return pNoCuenta
        End Get
        Set(ByVal Value As String)
            pNoCuenta = Value
        End Set
    End Property

    Public Property Dui() As String
        Get
            Return pDui
        End Get
        Set(ByVal Value As String)
            pDui = Value
        End Set
    End Property

#End Region

    Private Sub frmMsCaPosteo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtDui.Value = pDui
        Me.txtNoCuenta.Text = pNoCuenta
        Me.lblNombre.Text = pNombre
        Me.txtNoLibreta.Text = pNoLibreta
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Try
            Dim oAhorro As wsSysFinCoop.LibAhorro.wsLibAhorro = New wsSysFinCoop.LibAhorro.wsLibAhorro, ds As New Data.DataSet, vResp As String
            Dim dsPosteo As New DataSet, oAsoc As New wsSysFinCoop.LibAsoc.wsLibAsoc, dr As DataRow, vLineaMax As Integer, pMaxPag As Integer

            If Me.txtDui.Text.Trim = "" Or Me.txtNoCuenta.Text.Trim = "" Then
                MsgBox("Ingrese el Dui y el Número de Cuenta.", MsgBoxStyle.Critical, "Validación del Sistema")
                Exit Sub
            End If

            ds = oAsoc.ConsultarParametros("MaxNumLibreta", "", "MaxNumLibreta", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                vLineaMax = dr("MaxNumLibreta")
                pMaxPag = vLineaMax - 12
            End If

            'If Me.txtNoLibreta.Text.Trim = "" Then
            '    MsgBox("Debe digitar el No. de Libreta.", MsgBoxStyle.Critical, "Validación del Sistema")
            '    Exit Sub
            'End If
            If c1nNum.Value < pMaxPag Then
                vResp = oAhorro.PosteoMovimientos(False, Me.txtDui.Text.Trim, Me.txtNoCuenta.Text.Trim, Me.txtNoLibreta.Text.Trim, Me.c1nNum.Value, Me.c1nSaldo.Value, False, Me.c1nCorr.Value, False, sUsuario, sPassword, sSucursal)
            Else
                vResp = oAhorro.PosteoMovimientos(False, Me.txtDui.Text.Trim, Me.txtNoCuenta.Text.Trim, Me.txtNoLibreta.Text.Trim, Me.c1nNum.Value, Me.c1nSaldo.Value, False, Me.c1nCorr.Value, True, sUsuario, sPassword, sSucursal)
            End If
            If (vResp) = "" Then
                If c1nNum.Value < pMaxPag Then
                    dsPosteo = oAhorro.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta>" & Me.c1nNum.Value & " and a.IdLibreta=" & Me.c1nCorr.Value & " and a.Corr_Libreta<=" & pMaxPag & "", "a.Num", sUsuario, sPassword, sSucursal)
                Else
                    dsPosteo = oAhorro.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta>" & Me.c1nNum.Value & " and a.IdLibreta=" & Me.c1nCorr.Value & "", "a.Num", sUsuario, sPassword, sSucursal)
                End If
                Dim ofrm As New frmVisorLib(dsPosteo, 21, Me.c1nNum.Value, Me.c1nCorr.Value)
                ofrm.Show()
                Me.btnCerrar.Enabled = True
            Else
                MsgBox(vResp, MsgBoxStyle.Critical, "Validación del Sistema")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnInicializarLibreta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInicializarLibreta.Click
        Dim oAh As wsSysFinCoop.LibAhorro.wsLibAhorro = New wsSysFinCoop.LibAhorro.wsLibAhorro
        Dim ds As New Data.DataSet, dsTmp As New DataSet, vResp As String, dr As DataRow, dsPosteo As New DataSet, oAsoc As New wsSysFinCoop.LibAsoc.wsLibAsoc, vLineaMax As Integer, pMaxPag As Integer
        Try

            ds = oAsoc.ConsultarParametros("MaxNumLibreta", "", "MaxNumLibreta", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                vLineaMax = dr("MaxNumLibreta")
                pMaxPag = vLineaMax - 12
            End If

            dsTmp = oAh.ConsultaPosteo("a.*", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Posteado='0'", "a.Num", sUsuario, sPassword, sSucursal)
            If dsTmp.Tables(0).Rows.Count > 0 Then 'Hay movimientos pendientes
                If c1nNum.Value < pMaxPag Then
                    vResp = oAh.PosteoMovimientos(True, Me.txtDui.Text.Trim, Me.txtNoCuenta.Text.Trim, "", 0, Me.c1nSaldo.Value, False, Me.c1nCorr.Value, False, sUsuario, sPassword, sSucursal)
                Else
                    vResp = oAh.PosteoMovimientos(True, Me.txtDui.Text.Trim, Me.txtNoCuenta.Text.Trim, "", 0, Me.c1nSaldo.Value, False, Me.c1nCorr.Value, True, sUsuario, sPassword, sSucursal)
                End If
                If vResp Is Nothing Then
                    ds = oAh.InicializacionLibreta(Me.txtDui.Value, Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)

                    If c1nNum.Value < pMaxPag Then
                        dsPosteo = oAh.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta=1 and a.IdLibreta=" & Me.c1nCorr.Value & " and a.Corr_Libreta<=" & pMaxPag & "", "a.Num", sUsuario, sPassword, sSucursal)
                    Else
                        dsPosteo = oAh.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta=1 and a.IdLibreta=" & Me.c1nCorr.Value & "", "a.Num", sUsuario, sPassword, sSucursal)
                    End If
                    Dim ofrm As New frmMsAhInicializacionLibreta
                    ofrm.vNoExistMov = False
                    ofrm.TipoAhorro = Me.pCodTipoAhorro
                    ofrm.dsPosteo = dsPosteo
                    ofrm.ds = ds
                    ofrm.ShowDialog()
                Else
                    If vResp.Trim = "" Then
                        ds = oAh.InicializacionLibreta(Me.txtDui.Value, Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
                        If c1nNum.Value < pMaxPag Then
                            dsPosteo = oAh.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta=1 and a.IdLibreta=" & Me.c1nCorr.Value & " and a.Corr_Libreta<=" & pMaxPag & "", "a.Num", sUsuario, sPassword, sSucursal)
                        Else
                            dsPosteo = oAh.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta=1 and a.IdLibreta=" & Me.c1nCorr.Value & "", "a.Num", sUsuario, sPassword, sSucursal)
                        End If
                        Dim ofrm As New frmMsAhInicializacionLibreta
                        ofrm.vNoExistMov = False
                        ofrm.TipoAhorro = Me.pCodTipoAhorro
                        ofrm.dsPosteo = dsPosteo
                        ofrm.ds = ds
                        ofrm.ShowDialog()
                    Else
                        MessageBox.Show(vResp, "Posteo de Libreta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Else 'No hay movimientos pendientes
                ds = oAh.InicializacionLibreta(Me.txtDui.Value, Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
                'dsPosteo = oAh.ConsultaPosteo("a.*,b.Titular2 as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Num=1", "a.Num", sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmMsAhInicializacionLibreta
                ofrm.vNoExistMov = True
                ofrm.TipoAhorro = Me.pCodTipoAhorro
                ofrm.dsPosteo = ds
                ofrm.ds = ds
                ofrm.ShowDialog()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMsCaPosteo_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If pRetiro = True Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If
    End Sub

End Class