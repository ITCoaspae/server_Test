Public Class ConsultaGarantias
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Dim vCodPrestamo As String, vDui As String, vNoSocio As String, vNumSolicitud As Long, pEnlace As String, vNombre As String
    Friend WithEvents btConsultaGarantiasInt1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditGr1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEditFd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btEditCd1 As MetroFramework.Controls.MetroButton

#Region "Propiedades"

    Public Property Enlace() As String
        Get
            Return pEnlace
        End Get
        Set(ByVal Value As String)
            pEnlace = Value
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

    Public Property Dui() As String
        Get
            Return vDui
        End Get
        Set(ByVal Value As String)
            vDui = Value
        End Set
    End Property

    Public Property NoSocio() As String
        Get
            Return vNoSocio
        End Get
        Set(ByVal Value As String)
            vNoSocio = Value
        End Set
    End Property

    Public Property NumSolicitud() As Long
        Get
            Return vNumSolicitud
        End Get
        Set(ByVal Value As Long)
            vNumSolicitud = Value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return vNombre
        End Get
        Set(ByVal Value As String)
            vNombre = Value
        End Set
    End Property

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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPlazo As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblConcedido As System.Windows.Forms.Label
    Friend WithEvents fgGr As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgFd As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents fgCd As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaGarantias))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblPlazo = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblConcedido = New System.Windows.Forms.Label()
        Me.fgGr = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fgFd = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.fgCd = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btEditGr1 = New MetroFramework.Controls.MetroButton()
        Me.btConsultaGarantiasInt1 = New MetroFramework.Controls.MetroButton()
        Me.btEditFd1 = New MetroFramework.Controls.MetroButton()
        Me.btEditCd1 = New MetroFramework.Controls.MetroButton()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.GroupBox4.SuspendLayout()
        CType(Me.fgGr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgFd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgCd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblPlazo)
        Me.GroupBox4.Controls.Add(Me.lblMonto)
        Me.GroupBox4.Controls.Add(Me.lblConcedido)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(768, 55)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'lblPlazo
        '
        Me.lblPlazo.ForeColor = System.Drawing.Color.Teal
        Me.lblPlazo.Location = New System.Drawing.Point(662, 18)
        Me.lblPlazo.Name = "lblPlazo"
        Me.lblPlazo.Size = New System.Drawing.Size(77, 19)
        Me.lblPlazo.TabIndex = 3
        Me.lblPlazo.Text = "Plazo:"
        '
        'lblMonto
        '
        Me.lblMonto.ForeColor = System.Drawing.Color.Teal
        Me.lblMonto.Location = New System.Drawing.Point(499, 18)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(144, 19)
        Me.lblMonto.TabIndex = 2
        Me.lblMonto.Text = "Monto:"
        '
        'lblConcedido
        '
        Me.lblConcedido.ForeColor = System.Drawing.Color.Teal
        Me.lblConcedido.Location = New System.Drawing.Point(10, 18)
        Me.lblConcedido.Name = "lblConcedido"
        Me.lblConcedido.Size = New System.Drawing.Size(480, 28)
        Me.lblConcedido.TabIndex = 1
        Me.lblConcedido.Text = "Crédito concedido a:"
        '
        'fgGr
        '
        Me.fgGr.AllowEditing = False
        Me.fgGr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgGr.BackColor = System.Drawing.Color.White
        Me.fgGr.ColumnInfo = "10,0,0,0,0,105,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgGr.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fgGr.Location = New System.Drawing.Point(4, 43)
        Me.fgGr.Name = "fgGr"
        Me.fgGr.Rows.Count = 1
        Me.fgGr.Rows.DefaultSize = 21
        Me.fgGr.Size = New System.Drawing.Size(657, 263)
        Me.fgGr.StyleInfo = resources.GetString("fgGr.StyleInfo")
        Me.fgGr.TabIndex = 4
        '
        'fgFd
        '
        Me.fgFd.AllowEditing = False
        Me.fgFd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgFd.BackColor = System.Drawing.Color.White
        Me.fgFd.ColumnInfo = "10,0,0,0,0,105,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgFd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fgFd.Location = New System.Drawing.Point(4, 43)
        Me.fgFd.Name = "fgFd"
        Me.fgFd.Rows.Count = 1
        Me.fgFd.Rows.DefaultSize = 21
        Me.fgFd.Size = New System.Drawing.Size(657, 263)
        Me.fgFd.StyleInfo = resources.GetString("fgFd.StyleInfo")
        Me.fgFd.TabIndex = 5
        '
        'fgCd
        '
        Me.fgCd.AllowEditing = False
        Me.fgCd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgCd.BackColor = System.Drawing.Color.White
        Me.fgCd.ColumnInfo = "10,0,0,0,0,105,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgCd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fgCd.Location = New System.Drawing.Point(4, 43)
        Me.fgCd.Name = "fgCd"
        Me.fgCd.Rows.Count = 1
        Me.fgCd.Rows.DefaultSize = 21
        Me.fgCd.Size = New System.Drawing.Size(750, 262)
        Me.fgCd.StyleInfo = resources.GetString("fgCd.StyleInfo")
        Me.fgCd.TabIndex = 5
        '
        'btEditGr1
        '
        Me.btEditGr1.Location = New System.Drawing.Point(4, 3)
        Me.btEditGr1.Name = "btEditGr1"
        Me.btEditGr1.Size = New System.Drawing.Size(108, 33)
        Me.btEditGr1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditGr1.TabIndex = 185
        Me.btEditGr1.Text = "Mostrar"
        Me.btEditGr1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditGr1.UseSelectable = True
        Me.btEditGr1.UseStyleColors = True
        '
        'btConsultaGarantiasInt1
        '
        Me.btConsultaGarantiasInt1.Location = New System.Drawing.Point(119, 3)
        Me.btConsultaGarantiasInt1.Name = "btConsultaGarantiasInt1"
        Me.btConsultaGarantiasInt1.Size = New System.Drawing.Size(128, 33)
        Me.btConsultaGarantiasInt1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btConsultaGarantiasInt1.TabIndex = 186
        Me.btConsultaGarantiasInt1.Text = "Garantías Internas"
        Me.btConsultaGarantiasInt1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btConsultaGarantiasInt1.UseSelectable = True
        Me.btConsultaGarantiasInt1.UseStyleColors = True
        '
        'btEditFd1
        '
        Me.btEditFd1.Location = New System.Drawing.Point(4, 3)
        Me.btEditFd1.Name = "btEditFd1"
        Me.btEditFd1.Size = New System.Drawing.Size(108, 33)
        Me.btEditFd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditFd1.TabIndex = 186
        Me.btEditFd1.Text = "Mostrar"
        Me.btEditFd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditFd1.UseSelectable = True
        Me.btEditFd1.UseStyleColors = True
        '
        'btEditCd1
        '
        Me.btEditCd1.Location = New System.Drawing.Point(4, 3)
        Me.btEditCd1.Name = "btEditCd1"
        Me.btEditCd1.Size = New System.Drawing.Size(108, 33)
        Me.btEditCd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEditCd1.TabIndex = 186
        Me.btEditCd1.Text = "Mostrar"
        Me.btEditCd1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEditCd1.UseSelectable = True
        Me.btEditCd1.UseStyleColors = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl1.Location = New System.Drawing.Point(28, 135)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 2
        Me.MetroTabControl1.Size = New System.Drawing.Size(769, 359)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabControl1.TabIndex = 13
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroTabPage1.Controls.Add(Me.fgGr)
        Me.MetroTabPage1.Controls.Add(Me.btConsultaGarantiasInt1)
        Me.MetroTabPage1.Controls.Add(Me.btEditGr1)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 12
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(668, 317)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Garantías"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 12
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroTabPage2.Controls.Add(Me.fgFd)
        Me.MetroTabPage2.Controls.Add(Me.btEditFd1)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 12
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(668, 317)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Fiadores"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 12
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MetroTabPage3.Controls.Add(Me.fgCd)
        Me.MetroTabPage3.Controls.Add(Me.btEditCd1)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 12
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(761, 317)
        Me.MetroTabPage3.TabIndex = 2
        Me.MetroTabPage3.Text = "Codeudores"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 12
        '
        'ConsultaGarantias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(815, 541)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.GroupBox4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConsultaGarantias"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consulta de Garantías"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.fgGr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgFd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgCd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCertificacionExtractada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ds As New DataSet, dr As DataRow
        Dim oCred As New wrCredito.wsLibCred, oAsoc As New wrAsociados.wsLibAsoc

        ds = oCred.ConsultarPRPrestamos("Dui,Monto,PlazoMeses", "NumSolicitud=" & vNumSolicitud & "", "NumSolicitud", False, sUsuario, sPassword, sSucursal)
        If ds.Tables(0).Rows.Count > 0 Then
            dr = ds.Tables(0).Rows(0)
            vDui = dr("Dui")
            Me.lblMonto.Text = "Monto: $" & IIf(IsDBNull(dr("Monto")), "$0.00", Format(dr("Monto"), "##0.00"))
            Me.lblPlazo.Text = "Plazo: " & IIf(IsDBNull(dr("PlazoMeses")), "0", dr("PlazoMeses"))
        End If
        ds.Clear()
        ds = oAsoc.ConsultarAsociado("Nombres,Apellido1,Apellido2", "Dui='" & vDui & "'", "Dui", sUsuario, sPassword, sSucursal)
        If ds.Tables(0).Rows.Count > 0 Then
            dr = ds.Tables(0).Rows(0)
            Me.lblConcedido.Text = "Crédito concedido a: " & dr("Nombres") & " " & dr("Apellido1") & " " & dr("Apellido2")
        End If

        ds = oCred.ConsultarGarantias("*", "NumSolicitud=" & vNumSolicitud & "", "CodGarantia", sUsuario, sPassword, sSucursal)
        Me.fgGr.DataSource = ds.Tables(0)

        ds = oCred.ConsultarDatGral("*", "NumSolicitud=" & vNumSolicitud & " and Fiador='1'", "CodEnlace", sUsuario, sPassword, sSucursal)
        Me.fgFd.DataSource = ds.Tables(0)

        ds = oCred.ConsultarDatGral("*", "NumSolicitud=" & vNumSolicitud & " and Fiador='2'", "CodEnlace", sUsuario, sPassword, sSucursal)
        Me.fgCd.DataSource = ds.Tables(0)

    End Sub



    Private Sub ActualizaGridGr()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarGarantias("*", "NumSolicitud='" & vNumSolicitud & "'", "CodGarantia", sUsuario, sPassword, sSucursal)

            Me.fgGr.DataSource = ds.Tables(0)
            Me.fgGr.Cols.Item(0).Caption = "Código"
            Me.fgGr.Cols.Item(1).Caption = "Descripción"
            Me.fgGr.Cols.Item(2).Caption = "No. Solicitud"
            Me.fgGr.Cols.Item(3).Caption = "Tipo Garantía"
            Me.fgGr.Cols.Item(4).Caption = "Cód. Enlace"
            Me.fgGr.Cols.Item(5).Caption = "No. Factura"
            Me.fgGr.Cols.Item(6).Caption = "No. Valúo"

            Me.fgGr.Cols.Item(0).Width = 77
            Me.fgGr.Cols.Item(1).Width = 150
            Me.fgGr.Cols.Item(2).Width = 77
            Me.fgGr.Cols.Item(3).Width = 77
            Me.fgGr.Cols.Item(4).Width = 77
            Me.fgGr.Cols.Item(5).Width = 77
            Me.fgGr.Cols.Item(6).Width = 77

        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub btEditFd1_Click(sender As Object, e As EventArgs) Handles btEditFd1.Click
        Try
            If Me.fgFd.Row <> -1 Then
                Dim frm As frmMsCrFiadores = New frmMsCrFiadores
                frm.vFiador = 1
                frm.pNumSolicitud = vNumSolicitud
                frm.pCodEnlace = pEnlace
                frm.pAccion = "Modificar"
                frm.btnSaveTb1_1.Visible = False
                frm.btnSaveTb2_1.Visible = False
                frm.btnSaveTb3_1.Visible = False
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridFd()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditCd1_Click(sender As Object, e As EventArgs) Handles btEditCd1.Click
        Try
            If Me.fgCd.Row <> -1 Then
                Dim frm As frmMsCrFiadores = New frmMsCrFiadores
                frm.vFiador = 2
                frm.Text = "Mantenimiento de Codeudores"
                frm.pNumSolicitud = vNumSolicitud
                frm.pCodEnlace = pEnlace
                frm.pAccion = "Modificar"
                frm.btnSaveTb1_1.Visible = False
                frm.btnSaveTb2_1.Visible = False
                frm.btnSaveTb3_1.Visible = False
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridCd()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btConsultaGarantiasInt1_Click(sender As Object, e As EventArgs) Handles btConsultaGarantiasInt1.Click
        Try
            Dim ofrm As New frmMsCrConsultaGarInt
            ofrm.NoSolicitud = vNumSolicitud
            ofrm.NoSocio = vNoSocio
            ofrm.Dui = vDui
            ofrm.Nombre = vNombre
            ofrm.ShowDialog()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEditGr1_Click(sender As Object, e As EventArgs) Handles btEditGr1.Click
        Try
            If Me.fgGr.Row <> -1 Then
                Dim frm As frmMsCrGarantias = New frmMsCrGarantias
                frm.pNoSolic = vNumSolicitud
                frm.pCodEnlace = pEnlace
                frm.pCodigo = Me.fgGr.Item(Me.fgGr.Row, "CodGarantia")
                frm.pDui = vDui
                frm.pAccion = "Modificar"
                frm.btnGuardar1.Visible = False
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGridGr()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub ActualizaGridFd()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarDatGral("*", "NumSolicitud='" & vNumSolicitud & "' and Fiador='1'", "CodEnlace", sUsuario, sPassword, sSucursal)

            Me.fgFd.DataSource = ds.Tables(0)

        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ActualizaGridCd()

        Dim oCred As wrCredito.wsLibCred, ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarDatGral("*", "NumSolicitud='" & vNumSolicitud & "' and Fiador='2'", "CodEnlace", sUsuario, sPassword, sSucursal)

            Me.fgCd.DataSource = ds.Tables(0)
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub



End Class