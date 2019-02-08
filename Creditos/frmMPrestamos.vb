Public Class frmMPrestamos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim ofrm2 As New frmCRTablaAmort

    Private dsPrestamo As DataSet, vIdPrestamo As String, vIdAmortiza As String, vFechaOtorgamiento As Date
    Private pMonto As Double, pMontoGarantia As Double, pTasa As Double, pPlazo As Integer, pModulo As Modulo
    Friend WithEvents lblEstado As Label
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBuscar1 As MetroFramework.Controls.MetroButton

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) '' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents C1fgrdPrestamos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtdelCodPrest As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSocio As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    Friend WithEvents rbNoSocio As System.Windows.Forms.RadioButton
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents rbDui As System.Windows.Forms.RadioButton
    Friend WithEvents rbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents txtNoSolicitud As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents rbNoSolic As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMPrestamos))
        Me.C1fgrdPrestamos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar1 = New MetroFramework.Controls.MetroButton()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtNoSolicitud = New C1.Win.C1Input.C1NumericEdit()
        Me.rbNoSolic = New System.Windows.Forms.RadioButton()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoSocio = New C1.Win.C1Input.C1NumericEdit()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.rbNoSocio = New System.Windows.Forms.RadioButton()
        Me.txtdelCodPrest = New System.Windows.Forms.TextBox()
        Me.rbDui = New System.Windows.Forms.RadioButton()
        Me.rbCodigo = New System.Windows.Forms.RadioButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.C1fgrdPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtNoSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoSocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1fgrdPrestamos
        '
        Me.C1fgrdPrestamos.AllowEditing = False
        Me.C1fgrdPrestamos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fgrdPrestamos.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.C1fgrdPrestamos.BackColor = System.Drawing.Color.White
        Me.C1fgrdPrestamos.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:21;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdPrestamos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.C1fgrdPrestamos.Location = New System.Drawing.Point(28, 258)
        Me.C1fgrdPrestamos.Name = "C1fgrdPrestamos"
        Me.C1fgrdPrestamos.Rows.Count = 2
        Me.C1fgrdPrestamos.Rows.DefaultSize = 21
        Me.C1fgrdPrestamos.Size = New System.Drawing.Size(797, 294)
        Me.C1fgrdPrestamos.StyleInfo = resources.GetString("C1fgrdPrestamos.StyleInfo")
        Me.C1fgrdPrestamos.TabIndex = 6
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btnBuscar1)
        Me.GroupBox2.Controls.Add(Me.lblEstado)
        Me.GroupBox2.Controls.Add(Me.txtNoSolicitud)
        Me.GroupBox2.Controls.Add(Me.rbNoSolic)
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.txtNoSocio)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.rbNombres)
        Me.GroupBox2.Controls.Add(Me.cbNombres)
        Me.GroupBox2.Controls.Add(Me.rbNoSocio)
        Me.GroupBox2.Controls.Add(Me.txtdelCodPrest)
        Me.GroupBox2.Controls.Add(Me.rbDui)
        Me.GroupBox2.Controls.Add(Me.rbCodigo)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(772, 139)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Préstamo por:"
        '
        'btnBuscar1
        '
        Me.btnBuscar1.Location = New System.Drawing.Point(7, 91)
        Me.btnBuscar1.Name = "btnBuscar1"
        Me.btnBuscar1.Size = New System.Drawing.Size(90, 32)
        Me.btnBuscar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnBuscar1.TabIndex = 231
        Me.btnBuscar1.Text = "Mostrar"
        Me.btnBuscar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnBuscar1.UseSelectable = True
        Me.btnBuscar1.UseStyleColors = True
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.BackColor = System.Drawing.Color.Teal
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.White
        Me.lblEstado.Location = New System.Drawing.Point(574, 91)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(192, 19)
        Me.lblEstado.TabIndex = 13
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNoSolicitud
        '
        Me.txtNoSolicitud.BackColor = System.Drawing.Color.White
        Me.txtNoSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSolicitud.CustomFormat = "######"
        Me.txtNoSolicitud.DataType = GetType(Integer)
        Me.txtNoSolicitud.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNoSolicitud.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtNoSolicitud.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtNoSolicitud.Location = New System.Drawing.Point(338, 61)
        Me.txtNoSolicitud.Name = "txtNoSolicitud"
        Me.txtNoSolicitud.Size = New System.Drawing.Size(135, 23)
        Me.txtNoSolicitud.TabIndex = 10
        Me.txtNoSolicitud.Tag = Nothing
        Me.txtNoSolicitud.Value = 0
        Me.txtNoSolicitud.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'rbNoSolic
        '
        Me.rbNoSolic.BackColor = System.Drawing.Color.White
        Me.rbNoSolic.Checked = True
        Me.rbNoSolic.ForeColor = System.Drawing.Color.Black
        Me.rbNoSolic.Location = New System.Drawing.Point(248, 66)
        Me.rbNoSolic.Name = "rbNoSolic"
        Me.rbNoSolic.Size = New System.Drawing.Size(83, 18)
        Me.rbNoSolic.TabIndex = 9
        Me.rbNoSolic.TabStop = True
        Me.rbNoSolic.Text = "Solicitud"
        Me.rbNoSolic.UseVisualStyleBackColor = False
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(73, 27)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(135, 20)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.CustomFormat = "#######0"
        Me.txtNoSocio.DataType = GetType(Integer)
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNoSocio.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtNoSocio.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtNoSocio.Location = New System.Drawing.Point(631, 61)
        Me.txtNoSocio.MaxLength = 10
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(135, 23)
        Me.txtNoSocio.TabIndex = 3
        Me.txtNoSocio.Tag = Nothing
        Me.txtNoSocio.Value = 0
        Me.txtNoSocio.Visible = False
        Me.txtNoSocio.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.White
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(449, 27)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(317, 22)
        Me.txtNombres.TabIndex = 6
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.ForeColor = System.Drawing.Color.Black
        Me.rbNombres.Location = New System.Drawing.Point(215, 27)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(85, 18)
        Me.rbNombres.TabIndex = 4
        Me.rbNombres.Text = "N&ombres"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'cbNombres
        '
        Me.cbNombres.BackColor = System.Drawing.Color.White
        Me.cbNombres.Enabled = False
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(307, 27)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(135, 24)
        Me.cbNombres.TabIndex = 5
        '
        'rbNoSocio
        '
        Me.rbNoSocio.BackColor = System.Drawing.Color.White
        Me.rbNoSocio.ForeColor = System.Drawing.Color.Black
        Me.rbNoSocio.Location = New System.Drawing.Point(486, 66)
        Me.rbNoSocio.Name = "rbNoSocio"
        Me.rbNoSocio.Size = New System.Drawing.Size(142, 18)
        Me.rbNoSocio.TabIndex = 2
        Me.rbNoSocio.Text = "No. de Asociado"
        Me.rbNoSocio.UseVisualStyleBackColor = False
        Me.rbNoSocio.Visible = False
        '
        'txtdelCodPrest
        '
        Me.txtdelCodPrest.BackColor = System.Drawing.Color.White
        Me.txtdelCodPrest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdelCodPrest.Location = New System.Drawing.Point(107, 61)
        Me.txtdelCodPrest.Name = "txtdelCodPrest"
        Me.txtdelCodPrest.Size = New System.Drawing.Size(134, 22)
        Me.txtdelCodPrest.TabIndex = 8
        '
        'rbDui
        '
        Me.rbDui.BackColor = System.Drawing.Color.White
        Me.rbDui.Location = New System.Drawing.Point(7, 22)
        Me.rbDui.Name = "rbDui"
        Me.rbDui.Size = New System.Drawing.Size(59, 28)
        Me.rbDui.TabIndex = 0
        Me.rbDui.Text = "DUI"
        Me.rbDui.UseVisualStyleBackColor = False
        '
        'rbCodigo
        '
        Me.rbCodigo.BackColor = System.Drawing.Color.White
        Me.rbCodigo.Checked = True
        Me.rbCodigo.Location = New System.Drawing.Point(7, 57)
        Me.rbCodigo.Name = "rbCodigo"
        Me.rbCodigo.Size = New System.Drawing.Size(93, 27)
        Me.rbCodigo.TabIndex = 7
        Me.rbCodigo.TabStop = True
        Me.rbCodigo.Text = "Préstamo"
        Me.rbCodigo.UseVisualStyleBackColor = False
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(125, 219)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(144, 33)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 238
        Me.btnModificar1.Text = "Asignar Tabla"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(28, 219)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 33)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 237
        Me.btnAgregar1.Text = "Detalle"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmMPrestamos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(853, 617)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.C1fgrdPrestamos)
        Me.Name = "frmMPrestamos"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Maestro de Préstamos"
        CType(Me.C1fgrdPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtNoSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoSocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Enumeración"
    Public Enum Modulo
        Creditos = 0
        Garantias = 1
    End Enum
#End Region

#Region "Propiedades"
    Public Property setModulo() As Modulo
        Get
            Return pModulo
        End Get
        Set(ByVal Value As Modulo)
            pModulo = Value
        End Set
    End Property
    Public Property IdPrestamo() As String
        Get
            Return vIdPrestamo
        End Get
        Set(ByVal Value As String)
            vIdPrestamo = Value
        End Set
    End Property
#End Region

    Private Sub frmMPrestamos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oPrestamos As New wrPrestamo.wsLibPrest
        Dim dsPrest As New DataSet
        Try
            dsPrest = oPrestamos.CargarListaPrestamosxFiltro("a.CodPrestamo,a.DUI,b.Nombres+ ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres,a.CodAnteriorPrestamo,a.NumSolicitud,a.CodTipoCredito,a.NoSocio,a.IdMovimiento,a.Num_Partida,a.Cuota,a.CuotaTotal,a.Monto,a.Monto_Garantia,a.Tasa_Interes,a.Tasa_Interes_Mora,a.PlazoMeses,a.NoActa,a.FechaActa,a.ArchivoActa,a.FechaOtorgamiento,FechaPrimeraCuota,FechaVencimiento,CodTablaAmortiza,GeneraReserva,CodEmpleadoCobro,Categoria,CodTipoPago,DiaCobro,CodPagaduria,CodRuta,CodEstadoPrestamo,FechaUltimoPago,FechaInicioProvision,Saldo_Capital,Intereses_pagados,SaldoDia_Interes,SaldoDia_CapitalMora,SaldoDia_InteresMora,SaldoDia_SeguroDeuda,SaldoDia_SeguroDaniosyLA,SaldoDia_SeguroVida,SaldoDia_SeguroDesempleo,SaldoDia_Aportacion,SaldoDia_Ahorro,SaldoDia_ComisionManejo,SaldoDia_Otros,DiasMora,a.Estado,Baja,a.Tipo,Digito,Refinanciamiento,MontoRefinanciamiento,FechaUltProv", False, "FechaOtorgamiento>='" & Now.ToShortDateString & "' and FechaOtorgamiento<='" & Now.ToShortDateString & "'", sUsuario, sPassword, sSucursal)
            C1fgrdPrestamos.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
            C1fgrdPrestamos.DataSource = dsPrest.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub C1fgrdPrestamos_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1fgrdPrestamos.DoubleClick
        If Me.C1fgrdPrestamos.Row <> -1 Then
            Try


                Me.btnAgregar1_Click(sender, e)
                Me.IdPrestamo = C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "CodPrestamo")
                vIdAmortiza = C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "CodTablaAmortiza")
                vFechaOtorgamiento = C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "FechaPrimeraCuota")

                ofrm2.pNombre = C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "Nombres")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub



    Private Sub optCodPrest_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCodigo.CheckedChanged
        Me.txtdelCodPrest.Enabled = Me.rbCodigo.Checked
        Me.txtdelCodPrest.Focus()
    End Sub

    Private Sub C1fgrdPrestamos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1fgrdPrestamos.Click
        If Me.C1fgrdPrestamos.Row <> -1 Then

            Me.IdPrestamo = C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "CodPrestamo")
            vIdAmortiza = IIf(IsDBNull(C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "CodTablaAmortiza")) = True, "", C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "CodTablaAmortiza"))
            vFechaOtorgamiento = IIf(IsDBNull(C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "FechaPrimeraCuota")) = True, Now, C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "FechaPrimeraCuota"))
            pMonto = IIf(IsDBNull(C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "Monto")) = True, 0, C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "Monto"))
            pMontoGarantia = IIf(IsDBNull(C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "Monto_Garantia")) = True, 0, C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "Monto_Garantia"))
            pTasa = IIf(IsDBNull(C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "Tasa_Interes")) = True, 0, C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "Tasa_Interes"))
            pPlazo = IIf(IsDBNull(C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "PlazoMeses")) = True, 0, C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "PlazoMeses"))
            Select Case CStr(C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "Estado")).Trim
                Case "D" 'Digitado (sin tabla de amortización)
                    Me.lblEstado.Text = "DIGITADO"
                Case "A" 'A: Activo (ya se ha generado tabla de amortización)
                    Me.lblEstado.Text = "ACTIVO"
                Case "C" 'C: Cancelado
                    Me.lblEstado.Text = "CANCELADO"
            End Select
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

    Private Sub rbDui_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDui.CheckedChanged
        If Me.rbDui.Checked = True Then
            Me.txtDui.Enabled = True
        ElseIf Me.rbDui.Checked = False Then
            Me.txtDui.Enabled = False
        End If
        Me.txtDui.Focus()
    End Sub

    Private Sub rbNoSocio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoSocio.CheckedChanged
        Me.txtNoSocio.Focus()
    End Sub

    Private Sub rbNombres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNombres.CheckedChanged
        If Me.rbNombres.Checked = True Then
            Me.cbNombres.Enabled = True
            Me.txtNombres.Enabled = True
        ElseIf Me.rbNombres.Checked = False Then
            Me.cbNombres.Enabled = False
            Me.txtNombres.Enabled = False
        End If
        Me.cbNombres.Focus()
    End Sub

    Private Sub btnBuscar1_Click(sender As Object, e As EventArgs) Handles btnBuscar1.Click
        Dim oPrestamos As New wrPrestamo.wsLibPrest, oAsoc As New wrAsociados.wsLibAsoc
        Dim dsPrest As New DataSet, ds As New DataSet, dr As DataRow, pFiltro As String
        Try
            If Me.rbCodigo.Checked = True Then
                dsPrest = oPrestamos.CargarListaPrestamosxFiltro("a.CodPrestamo,a.DUI,b.Nombres+ ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres,a.CodAnteriorPrestamo,a.NumSolicitud,a.CodTipoCredito,a.NoSocio,a.IdMovimiento,a.Num_Partida,a.Cuota,a.CuotaTotal,a.Monto,a.Monto_Garantia,a.Tasa_Interes,a.Tasa_Interes_Mora,a.PlazoMeses,a.NoActa,a.FechaActa,a.ArchivoActa,a.FechaOtorgamiento,FechaPrimeraCuota,FechaVencimiento,CodTablaAmortiza,GeneraReserva,CodEmpleadoCobro,Categoria,CodTipoPago,DiaCobro,CodPagaduria,CodRuta,CodEstadoPrestamo,FechaUltimoPago,FechaInicioProvision,Saldo_Capital,Intereses_pagados,SaldoDia_Interes,SaldoDia_CapitalMora,SaldoDia_InteresMora,SaldoDia_SeguroDeuda,SaldoDia_SeguroDaniosyLA,SaldoDia_SeguroVida,SaldoDia_SeguroDesempleo,SaldoDia_Aportacion,SaldoDia_Ahorro,SaldoDia_ComisionManejo,SaldoDia_Otros,DiasMora,a.Estado,Baja,a.Tipo,Digito,Refinanciamiento,MontoRefinanciamiento,FechaUltProv", False, "a.CodPrestamo='" & Me.txtdelCodPrest.Text.Trim & "'", sUsuario, sPassword, sSucursal)
            ElseIf Me.rbNoSocio.Checked = True Then
                dsPrest = oPrestamos.CargarListaPrestamosxFiltro("a.CodPrestamo,a.DUI,b.Nombres+ ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres,a.CodAnteriorPrestamo,a.NumSolicitud,a.CodTipoCredito,a.NoSocio,a.IdMovimiento,a.Num_Partida,a.Cuota,a.CuotaTotal,a.Monto,a.Monto_Garantia,a.Tasa_Interes,a.Tasa_Interes_Mora,a.PlazoMeses,a.NoActa,a.FechaActa,a.ArchivoActa,a.FechaOtorgamiento,FechaPrimeraCuota,FechaVencimiento,CodTablaAmortiza,GeneraReserva,CodEmpleadoCobro,Categoria,CodTipoPago,DiaCobro,CodPagaduria,CodRuta,CodEstadoPrestamo,FechaUltimoPago,FechaInicioProvision,Saldo_Capital,Intereses_pagados,SaldoDia_Interes,SaldoDia_CapitalMora,SaldoDia_InteresMora,SaldoDia_SeguroDeuda,SaldoDia_SeguroDaniosyLA,SaldoDia_SeguroVida,SaldoDia_SeguroDesempleo,SaldoDia_Aportacion,SaldoDia_Ahorro,SaldoDia_ComisionManejo,SaldoDia_Otros,DiasMora,a.Estado,Baja,a.Tipo,Digito,Refinanciamiento,MontoRefinanciamiento,FechaUltProv", False, "a.NoSocio='" & Me.txtNoSocio.Text.Trim & "'", sUsuario, sPassword, sSucursal)
            ElseIf Me.rbDui.Checked = True Then
                dsPrest = oPrestamos.CargarListaPrestamosxFiltro("a.CodPrestamo,a.DUI,b.Nombres+ ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres,a.CodAnteriorPrestamo,a.NumSolicitud,a.CodTipoCredito,a.NoSocio,a.IdMovimiento,a.Num_Partida,a.Cuota,a.CuotaTotal,a.Monto,a.Monto_Garantia,a.Tasa_Interes,a.Tasa_Interes_Mora,a.PlazoMeses,a.NoActa,a.FechaActa,a.ArchivoActa,a.FechaOtorgamiento,FechaPrimeraCuota,FechaVencimiento,CodTablaAmortiza,GeneraReserva,CodEmpleadoCobro,Categoria,CodTipoPago,DiaCobro,CodPagaduria,CodRuta,CodEstadoPrestamo,FechaUltimoPago,FechaInicioProvision,Saldo_Capital,Intereses_pagados,SaldoDia_Interes,SaldoDia_CapitalMora,SaldoDia_InteresMora,SaldoDia_SeguroDeuda,SaldoDia_SeguroDaniosyLA,SaldoDia_SeguroVida,SaldoDia_SeguroDesempleo,SaldoDia_Aportacion,SaldoDia_Ahorro,SaldoDia_ComisionManejo,SaldoDia_Otros,DiasMora,a.Estado,Baja,a.Tipo,Digito,Refinanciamiento,MontoRefinanciamiento,FechaUltProv", False, "a.Dui='" & Me.txtDui.Text.Trim & "'", sUsuario, sPassword, sSucursal)
            ElseIf Me.rbNoSolic.Checked = True Then
                dsPrest = oPrestamos.CargarListaPrestamosxFiltro("a.CodPrestamo,a.DUI,b.Nombres+ ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres,a.CodAnteriorPrestamo,a.NumSolicitud,a.CodTipoCredito,a.NoSocio,a.IdMovimiento,a.Num_Partida,a.Cuota,a.CuotaTotal,a.Monto,a.Monto_Garantia,a.Tasa_Interes,a.Tasa_Interes_Mora,a.PlazoMeses,a.NoActa,a.FechaActa,a.ArchivoActa,a.FechaOtorgamiento,FechaPrimeraCuota,FechaVencimiento,CodTablaAmortiza,GeneraReserva,CodEmpleadoCobro,Categoria,CodTipoPago,DiaCobro,CodPagaduria,CodRuta,CodEstadoPrestamo,FechaUltimoPago,FechaInicioProvision,Saldo_Capital,Intereses_pagados,SaldoDia_Interes,SaldoDia_CapitalMora,SaldoDia_InteresMora,SaldoDia_SeguroDeuda,SaldoDia_SeguroDaniosyLA,SaldoDia_SeguroVida,SaldoDia_SeguroDesempleo,SaldoDia_Aportacion,SaldoDia_Ahorro,SaldoDia_ComisionManejo,SaldoDia_Otros,DiasMora,a.Estado,Baja,a.Tipo,Digito,Refinanciamiento,MontoRefinanciamiento,FechaUltProv", False, "a.NumSolicitud=" & Me.txtNoSolicitud.Value & "", sUsuario, sPassword, sSucursal)
            ElseIf rbNombres.Checked = True Then
                If cbNombres.SelectedIndex = 0 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Apellido1 like '" & Trim(txtNombres.Text) & "%'", "Apellido1,Apellido2", sUsuario, sPassword, sSucursal)
                ElseIf cbNombres.SelectedIndex = 1 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Apellido2 like '" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
                ElseIf cbNombres.SelectedIndex = 2 Then
                    ds = oAsoc.ConsultarAsociado("Dui", "Nombres like '" & Trim(txtNombres.Text) & "%'", "Apellido1", sUsuario, sPassword, sSucursal)
                End If
                pFiltro = ""
                For Each dr In ds.Tables(0).Rows
                    If pFiltro.Trim = "" Then
                        pFiltro = "a.Dui='" & dr("Dui") & "'"
                    Else
                        pFiltro = pFiltro & "or a.Dui='" & dr("Dui") & "'"
                    End If
                Next
                If pFiltro.Trim = "" Then
                    C1fgrdPrestamos.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                    Exit Sub
                Else
                    dsPrest = oPrestamos.CargarListaPrestamosxFiltro("a.CodPrestamo,a.DUI,b.Nombres+ ' ' + b.Apellido1 + ' ' + b.Apellido2 as Nombres,a.CodAnteriorPrestamo,a.NumSolicitud,a.CodTipoCredito,a.NoSocio,a.IdMovimiento,a.Num_Partida,a.Cuota,a.CuotaTotal,a.Monto,a.Monto_Garantia,a.Tasa_Interes,a.Tasa_Interes_Mora,a.PlazoMeses,a.NoActa,a.FechaActa,a.ArchivoActa,a.FechaOtorgamiento,FechaPrimeraCuota,FechaVencimiento,CodTablaAmortiza,GeneraReserva,CodEmpleadoCobro,Categoria,CodTipoPago,DiaCobro,CodPagaduria,CodRuta,CodEstadoPrestamo,FechaUltimoPago,FechaInicioProvision,Saldo_Capital,Intereses_pagados,SaldoDia_Interes,SaldoDia_CapitalMora,SaldoDia_InteresMora,SaldoDia_SeguroDeuda,SaldoDia_SeguroDaniosyLA,SaldoDia_SeguroVida,SaldoDia_SeguroDesempleo,SaldoDia_Aportacion,SaldoDia_Ahorro,SaldoDia_ComisionManejo,SaldoDia_Otros,DiasMora,a.Estado,Baja,a.Tipo,Digito,Refinanciamiento,MontoRefinanciamiento,FechaUltProv", False, pFiltro, sUsuario, sPassword, sSucursal)
                End If
            End If
            C1fgrdPrestamos.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
            C1fgrdPrestamos.DataSource = dsPrest.Tables(0)
            C1fgrdPrestamos.Cols.Item(0).Width = 30
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try

            Dim ofrm As New frmMsCRDetPrestamo
            If Me.pModulo = Modulo.Creditos Then
                ofrm.btNewCd1.Enabled = False
                ofrm.btEditCd1.Enabled = False
                ofrm.btDelCd1.Visible = False
                ofrm.btNewGr1.Enabled = False
                ofrm.btEditGr1.Enabled = False
                ofrm.btDelGr1.Visible = False
                ofrm.btNewFd1.Enabled = False
                ofrm.btEditFd1.Enabled = False
                ofrm.btDelFd1.Visible = False
            ElseIf Me.pModulo = Modulo.Garantias Then
                ofrm.btnAsinaTA1.Visible = False
            End If
            If Me.IdPrestamo Is Nothing Then Exit Sub
            If Me.IdPrestamo.Trim = "" Then Exit Sub
            ofrm.IdPrestamo = Me.IdPrestamo.Trim
            'luis alvarenga
            ofrm2.pNombre = C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "Nombres")
            'ofrm.TopMost = True
            ofrm.ShowDialog()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If vIdAmortiza.Trim = "" Then

                Dim ds As New DataSet, oPrest As New wrPrestamo.wsLibPrest, dr As DataRow, dv As New DataView
                ds = oPrest.CargaDatosPrestamo(Me.IdPrestamo.Trim, sUsuario, sPassword, sSucursal)
                If ds.Tables("TablaAmortiza").Rows.Count > 0 Then 'Ya tiene asignada Tabla de Amortización
                    Dim ofrmAut As New frmMsAutorizacion
                    ofrmAut.TipoPermiso = "P"
                    ofrmAut.NumPrograma = "CRY004"
                    ofrmAut.ShowDialog()
                    If ofrmAut.Autoriza = True Then
                        Dim ofrm As New frmCRTablaAmort

                        dr = ds.Tables("Prestamo").Rows(0)
                        dv = New DataView(ds.Tables("TablaAmortiza"))

                        dv.RowFilter = "Cancelada='N'"
                        dv.Sort = "FechaCuota asc"

                        ofrm.Reasignacion = True
                        ofrm.dtpFecha.Value = dv.Item(0)("FechaCuota")
                        ofrm.dtpFecha.Enabled = False
                        ofrm.dtpFechaEmision.Value = Now

                        ofrm.CodPrestamo = Me.IdPrestamo.Trim
                        ofrm.pNombre = dv.Item(0)("Nombres")

                        ofrm.C1NEMonto.Value = dr("Saldo_Capital")
                        ofrm.C1NEMonto.Enabled = False

                        ofrm.C1NEInteres.Value = dr("Tasa_Interes")
                        ofrm.C1NENumPagos.Value = dr("PlazoMeses")
                        ofrm.C1NEMontoGarantia.Value = dr("Monto_Garantia")
                        'ofrm.TopMost = True
                        ofrm.ShowDialog()
                        ofrmAut.Autoriza = False
                        ofrmAut.Dispose()
                    Else
                        ofrmAut.Dispose()
                    End If
                Else
                    Dim ofrm As New frmCRTablaAmort
                    dr = ds.Tables("Prestamo").Rows(0)
                    If dr("Saldo_Capital") > 0 Then
                        ofrm.C1NEMonto.Value = dr("Saldo_Capital")
                    Else
                        ofrm.C1NEMonto.Value = pMonto
                    End If
                    ofrm.Reasignacion = False
                    ofrm.dtpFecha.Value = vFechaOtorgamiento
                    ofrm.dtpFechaEmision.Value = Now
                    ofrm.CodPrestamo = Me.IdPrestamo

                    ofrm.C1NEInteres.Value = pTasa
                    ofrm.C1NENumPagos.Value = pPlazo
                    ofrm.C1NEMontoGarantia.Value = pMontoGarantia
                    ' ofrm.TopMost = True
                    ofrm.ShowDialog()
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnBuscar1_Click(sender, e)
    End Sub

    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnBuscar1_Click(sender, e)
    End Sub

    Private Sub txtNoSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSocio.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnBuscar1_Click(sender, e)
    End Sub

    Private Sub txtdelCodPrest_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdelCodPrest.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnBuscar1_Click(sender, e)
    End Sub

    Private Sub C1fgrdPrestamos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1fgrdPrestamos.KeyPress
        Select Case CStr(C1fgrdPrestamos.Item(C1fgrdPrestamos.Row, "Estado")).Trim
            Case "D" 'Digitado (sin tabla de amortización)
                Me.lblEstado.Text = "DIGITADO"
            Case "A" 'A: Activo (ya se ha generado tabla de amortización)
                Me.lblEstado.Text = "ACTIVO"
            Case "C" 'C: Cancelado
                Me.lblEstado.Text = "CANCELADO"
        End Select
    End Sub

    Private Sub txtNoSolicitud_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSolicitud.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnBuscar1_Click(sender, e)
    End Sub

End Class