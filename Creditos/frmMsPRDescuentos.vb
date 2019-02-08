Public Class frmMsPRDescuentos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    'Private vTipoDeduccion As AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion, vTipoCredito As String, vCodRango As String, vDescripcion As String, vPorc As String, vTipo As String
    Private vTipoDeduccion As sifLib.Prestamos.clsPrestamos.TipoDeduccion, vTipoCredito As String, vCodRango As String, vDescripcion As String, vPorc As String, vTipo As String
    Friend WithEvents cbGastosTramitacion As System.Windows.Forms.ComboBox
    Dim Creditos As New wrCredito.wsLibCred
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Public CodTipoDeduccion As Integer

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
    Friend WithEvents c1txtDescripcion As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtCodDesc As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nValor As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nIva As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents c1nMontoMax As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblIva As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblMontoMax As System.Windows.Forms.Label
    Friend WithEvents chkAplicaIva As System.Windows.Forms.CheckBox
    Friend WithEvents chkAplicaPorc As System.Windows.Forms.CheckBox
    Friend WithEvents chkAplicaItem As System.Windows.Forms.CheckBox
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents txtCodItem As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbGastosTramitacion = New System.Windows.Forms.ComboBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtCodItem = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chkAplicaItem = New System.Windows.Forms.CheckBox()
        Me.c1txtDescripcion = New C1.Win.C1Input.C1TextBox()
        Me.chkAplicaPorc = New System.Windows.Forms.CheckBox()
        Me.c1nMontoMax = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nIva = New C1.Win.C1Input.C1NumericEdit()
        Me.lblIva = New System.Windows.Forms.Label()
        Me.c1nValor = New C1.Win.C1Input.C1NumericEdit()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.c1txtCodDesc = New C1.Win.C1Input.C1NumericEdit()
        Me.chkAplicaIva = New System.Windows.Forms.CheckBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.lblMontoMax = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nIva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nValor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCodDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbGastosTramitacion
        '
        Me.cbGastosTramitacion.FormattingEnabled = True
        Me.cbGastosTramitacion.Location = New System.Drawing.Point(23, 122)
        Me.cbGastosTramitacion.Name = "cbGastosTramitacion"
        Me.cbGastosTramitacion.Size = New System.Drawing.Size(430, 21)
        Me.cbGastosTramitacion.TabIndex = 182
        '
        'txtItem
        '
        Me.txtItem.BackColor = System.Drawing.Color.White
        Me.txtItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtItem.Location = New System.Drawing.Point(205, 200)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(248, 21)
        Me.txtItem.TabIndex = 181
        Me.txtItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodItem
        '
        Me.txtCodItem.BackColor = System.Drawing.Color.White
        Me.txtCodItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodItem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodItem.Location = New System.Drawing.Point(143, 200)
        Me.txtCodItem.Name = "txtCodItem"
        Me.txtCodItem.ReadOnly = True
        Me.txtCodItem.Size = New System.Drawing.Size(56, 21)
        Me.txtCodItem.TabIndex = 180
        Me.txtCodItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(20, 200)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 28)
        Me.Label7.TabIndex = 179
        Me.Label7.Text = "Item facturable aplicable a este rubro:"
        '
        'chkAplicaItem
        '
        Me.chkAplicaItem.Enabled = False
        Me.chkAplicaItem.Location = New System.Drawing.Point(23, 174)
        Me.chkAplicaItem.Name = "chkAplicaItem"
        Me.chkAplicaItem.Size = New System.Drawing.Size(104, 16)
        Me.chkAplicaItem.TabIndex = 82
        Me.chkAplicaItem.Text = "&Aplica Factura"
        '
        'c1txtDescripcion
        '
        Me.c1txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtDescripcion.Location = New System.Drawing.Point(143, 122)
        Me.c1txtDescripcion.MaxLength = 255
        Me.c1txtDescripcion.Name = "c1txtDescripcion"
        Me.c1txtDescripcion.NumericInput = False
        Me.c1txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.c1txtDescripcion.Size = New System.Drawing.Size(310, 18)
        Me.c1txtDescripcion.TabIndex = 1
        Me.c1txtDescripcion.Tag = Nothing
        '
        'chkAplicaPorc
        '
        Me.chkAplicaPorc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.chkAplicaPorc.Location = New System.Drawing.Point(23, 63)
        Me.chkAplicaPorc.Name = "chkAplicaPorc"
        Me.chkAplicaPorc.Size = New System.Drawing.Size(208, 16)
        Me.chkAplicaPorc.TabIndex = 81
        Me.chkAplicaPorc.Text = "Aplica % sobre &monto del préstamo"
        '
        'c1nMontoMax
        '
        Me.c1nMontoMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoMax.CustomFormat = "###,###,##0.00"
        Me.c1nMontoMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoMax.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoMax.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nMontoMax.Location = New System.Drawing.Point(143, 123)
        Me.c1nMontoMax.Name = "c1nMontoMax"
        Me.c1nMontoMax.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoMax.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoMax.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoMax.Size = New System.Drawing.Size(310, 18)
        Me.c1nMontoMax.TabIndex = 2
        Me.c1nMontoMax.Tag = Nothing
        Me.c1nMontoMax.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMontoMax.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nIva
        '
        Me.c1nIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nIva.CustomFormat = "###,###,##0.00"
        Me.c1nIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nIva.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nIva.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nIva.Location = New System.Drawing.Point(342, 149)
        Me.c1nIva.Name = "c1nIva"
        Me.c1nIva.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nIva.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nIva.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nIva.Size = New System.Drawing.Size(111, 18)
        Me.c1nIva.TabIndex = 4
        Me.c1nIva.Tag = Nothing
        Me.c1nIva.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nIva.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblIva
        '
        Me.lblIva.Location = New System.Drawing.Point(277, 150)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(59, 17)
        Me.lblIva.TabIndex = 76
        Me.lblIva.Text = "IVA:"
        '
        'c1nValor
        '
        Me.c1nValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nValor.CustomFormat = "###,###,##0.000"
        Me.c1nValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nValor.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nValor.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nValor.Location = New System.Drawing.Point(143, 148)
        Me.c1nValor.Name = "c1nValor"
        Me.c1nValor.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nValor.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nValor.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nValor.Size = New System.Drawing.Size(128, 18)
        Me.c1nValor.TabIndex = 3
        Me.c1nValor.Tag = Nothing
        Me.c1nValor.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nValor.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'lblMonto
        '
        Me.lblMonto.Location = New System.Drawing.Point(20, 150)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(112, 16)
        Me.lblMonto.TabIndex = 73
        Me.lblMonto.Text = "Valor:"
        '
        'c1txtCodDesc
        '
        Me.c1txtCodDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtCodDesc.CustomFormat = "######"
        Me.c1txtCodDesc.DataType = GetType(Integer)
        Me.c1txtCodDesc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtCodDesc.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1txtCodDesc.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1txtCodDesc.Location = New System.Drawing.Point(143, 96)
        Me.c1txtCodDesc.Name = "c1txtCodDesc"
        Me.c1txtCodDesc.Size = New System.Drawing.Size(310, 18)
        Me.c1txtCodDesc.TabIndex = 0
        Me.c1txtCodDesc.Tag = Nothing
        Me.c1txtCodDesc.Value = 0
        Me.c1txtCodDesc.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'chkAplicaIva
        '
        Me.chkAplicaIva.Location = New System.Drawing.Point(378, 63)
        Me.chkAplicaIva.Name = "chkAplicaIva"
        Me.chkAplicaIva.Size = New System.Drawing.Size(80, 16)
        Me.chkAplicaIva.TabIndex = 80
        Me.chkAplicaIva.Text = "&Aplica Iva"
        Me.chkAplicaIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(20, 96)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(112, 16)
        Me.lblTipo.TabIndex = 71
        Me.lblTipo.Text = "Tipo de Documento:"
        '
        'lblMontoMax
        '
        Me.lblMontoMax.Location = New System.Drawing.Point(155, 30)
        Me.lblMontoMax.Name = "lblMontoMax"
        Me.lblMontoMax.Size = New System.Drawing.Size(88, 16)
        Me.lblMontoMax.TabIndex = 78
        Me.lblMontoMax.Text = "Monto Máximo:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(378, 227)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 135
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsPRDescuentos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(482, 289)
        Me.Controls.Add(Me.txtItem)
        Me.Controls.Add(Me.cbGastosTramitacion)
        Me.Controls.Add(Me.txtCodItem)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkAplicaItem)
        Me.Controls.Add(Me.chkAplicaPorc)
        Me.Controls.Add(Me.c1nIva)
        Me.Controls.Add(Me.c1nMontoMax)
        Me.Controls.Add(Me.lblIva)
        Me.Controls.Add(Me.c1txtDescripcion)
        Me.Controls.Add(Me.c1nValor)
        Me.Controls.Add(Me.chkAplicaIva)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.c1txtCodDesc)
        Me.Controls.Add(Me.lblMontoMax)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(482, 289)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(482, 289)
        Me.Name = "frmMsPRDescuentos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Detalle"
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nIva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nValor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCodDesc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Propiedades"
    'Public Property TipoDeduccion() As AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion
    Public Property TipoDeduccion() As sifLib.Prestamos.clsPrestamos.TipoDeduccion
        Get
            Return vTipoDeduccion
        End Get
        'Set(ByVal Value As AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion)
        Set(ByVal Value As sifLib.Prestamos.clsPrestamos.TipoDeduccion)
            vTipoDeduccion = Value
        End Set
    End Property
    Public Property TipoCredito() As String
        Get
            Return vTipoCredito
        End Get
        Set(ByVal Value As String)
            vTipoCredito = Value
        End Set
    End Property
    Public Property CodRango() As String
        Get
            Return vCodRango
        End Get
        Set(ByVal Value As String)
            vCodRango = Value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return vDescripcion
        End Get
        Set(ByVal Value As String)
            vDescripcion = Value
        End Set
    End Property
    Public Property Porc() As String
        Get
            Return vPorc
        End Get
        Set(ByVal Value As String)
            vPorc = Value
        End Set
    End Property
    Public Property Tipo() As String
        Get
            Return vTipo
        End Get
        Set(ByVal Value As String)
            vTipo = Value
        End Set
    End Property
#End Region
    Public Sub LlenarCbGastosTramitacion(ByVal Opcion As Integer, ByVal Id_CatGastos_Tramitacion As Integer, ByVal Id_Cuenta As String)
        Dim Dts As New DataSet
        Dts = Creditos.Consultar_PrCatGastosTramitacion(Opcion, Id_CatGastos_Tramitacion, Id_Cuenta)
        Me.cbGastosTramitacion.DataSource = Dts.Tables(0)
    End Sub


    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim campos, camposvalores, valores, pDescripcion As String, vIva As Double, vTarifa As Double, vValor As Double
            Dim oCred As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest

            'If Me.vTipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Honorario Then
            If Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.Honorario Then
                pDescripcion = "Honorarios"
                If Me.c1nIva.Value = 0 Then
                    MessageBox.Show("La tarifa no puede tener valor cero.", "Honorarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                'ElseIf Me.vTipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Escrituracion Or Me.vTipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Tramitacion Then
            ElseIf Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.Escrituracion Or Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.Tramitacion Then
                vTipo = ""
                pDescripcion = Me.c1txtDescripcion.Text.Trim
            End If
            'If Me.vTipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.EscrituracionxRango Or Me.vTipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.TramitacionxRango Then
            If Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.EscrituracionxRango Or Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.TramitacionxRango Then
                pDescripcion = Me.Descripcion
            Else
                vPorc = IIf(Me.chkAplicaPorc.Checked = True, "1", "0")
            End If
            'If Me.vTipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.EscrituracionxRango Or Me.vTipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.TramitacionxRango Or Me.vTipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Honorario Then
            If Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.EscrituracionxRango Or Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.TramitacionxRango Or Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.Honorario Then
                If Me.chkAplicaIva.Checked = True Then
                    vTarifa = Me.c1nIva.Value
                    vIva = vTarifa * 0.13
                    vValor = Me.c1nValor.Value
                Else
                    vIva = 0
                    vTarifa = Me.c1nIva.Value
                    vValor = Me.c1nValor.Value
                End If
            Else
                vIva = Me.c1nIva.Value
                vTarifa = 0
                vValor = Me.c1nValor.Value
            End If
            Dim Resultado As Integer
            If Me.btnGuardar1.Text = "Guardar" Then
                '============================================================================================================
                '28/08/2012 Javier Martinez
                'Se incluyo el campo id_CatGastos_Tramitacion en el insert del formulario, y se elimino el campo Descripcion
                'Se creo SP para la insercíón de la tabla PRDEDUCCIONES
                'Modificación Realizada para la generación de partidas automaticas de desembolso
                Resultado = Creditos.Ingresar_PrDeducciones(Me.c1txtCodDesc.Value, Me.cbGastosTramitacion.SelectedValue, vTipoCredito,
                                                             CodTipoDeduccion.ToString, vValor, Me.c1nMontoMax.Value, vTarifa, vIva, vPorc,
                                                            vTipo, vCodRango, IIf(Me.chkAplicaItem.Checked = True, "1", "0"),
                                                            Me.txtCodItem.Text.Trim)
                If Resultado <> 0 Then
                    MsgBox("Registro Ingresado Exitosamente", MsgBoxStyle.Information, "Módulo - Créditos")
                Else
                    MsgBox("Error,No se pudo ingresar el registro, Por favor comuniquese con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Créditos")
                End If

                '============================================================================================================
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                '============================================================================================================
                '28/08/2012 Javier Martinez
                'Se incluyo el campo id_CatGastos_Tramitacion en la Query Update.
                'Se creo SP para la modificacion de registros en PRDEDUCCIONES
                'Modificación Realizada para la generación de partidas automaticas de desembolso
                Resultado = Creditos.Modificar_PrDeducciones(Me.c1txtCodDesc.Value, Me.cbGastosTramitacion.SelectedValue, vTipoCredito,
                                                           CodTipoDeduccion.ToString, vValor, Me.c1nMontoMax.Value, vTarifa, vIva, vPorc,
                                                           vTipo, vCodRango, IIf(Me.chkAplicaItem.Checked = True, "1", "0"),
                                                           Me.txtCodItem.Text.Trim)
                If Resultado <> 0 Then
                    MsgBox("Registro Modificado Exitosamente", MsgBoxStyle.Information, "Módulo - Créditos")
                Else
                    MsgBox("Error,No se pudo Modificar el registro, Por favor comuniquese con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Créditos")
                End If

            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub frmMsPRDescuentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        If Me.btnGuardar1.Text = "Guardar" Then
            Me.cbGastosTramitacion.DisplayMember = "GastosTramitacion"
            Me.cbGastosTramitacion.ValueMember = "id_CatGastos_Tramitacion"
            Dim oPrest As New wrPrestamo.wsLibPrest
            Me.c1txtCodDesc.Value = oPrest.ObtenercorrelativoPRDeducciones("CodDeduccion", sUsuario, sPassword, sSucursal)
            Me.c1txtCodDesc.ReadOnly = True
            LlenarCbGastosTramitacion(1, 0, "0")
        End If
        Select Case Me.vTipoDeduccion
            'Case AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Escrituracion, AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Tramitacion
            Case sifLib.Prestamos.clsPrestamos.TipoDeduccion.Escrituracion, sifLib.Prestamos.clsPrestamos.TipoDeduccion.Tramitacion
                Me.lblMontoMax.Visible = False
                Me.c1nMontoMax.Visible = False
                Me.lblMonto.Text = "Valor:"
                Me.c1nMontoMax.Value = 0
                'Me.lblMonto.Location = New Point(328, 32)
                'Me.c1nValor.Location = New Point(328, 48)
                Me.lblIva.Text = "Iva:"
                'Me.lblIva.Location = New Point(472, 32)
                'Me.c1nIva.Location = New Point(472, 48)
                Me.c1nIva.Enabled = False
                Me.chkAplicaIva.Visible = True
                Me.c1txtDescripcion.Visible = True
                'Me.c1txtDescripcion.Location = New Point(112, 48)
                Me.lblTipo.Text = "Tipo de Documento:"
                Me.c1nIva.Enabled = False
                Me.chkAplicaItem.Enabled = True
            'Case AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Honorario
            Case sifLib.Prestamos.clsPrestamos.TipoDeduccion.Honorario
                Me.lblMontoMax.Visible = True
                Me.c1nMontoMax.Visible = True
                Me.lblMonto.Text = "Monto Mínimo:"
                'Me.lblMontoMax.Location = New Point(144, 32)
                'Me.c1nMontoMax.Location = New Point(144, 48)
                'Me.lblMonto.Location = New Point(304, 32)
                'Me.c1nValor.Location = New Point(304, 48)
                If vPorc = "1" Then
                    Me.lblIva.Text = "Tarifa(%):"
                Else
                    Me.lblIva.Text = "Tarifa:"
                End If
                'Me.lblIva.Location = New Point(464, 32)
                'Me.c1nIva.Location = New Point(464, 48)
                Me.chkAplicaIva.Visible = False
                Me.c1txtDescripcion.Value = ""
                Me.c1txtDescripcion.Visible = False
                'Me.c1txtDescripcion.Location = New Point(112, 48)
                Me.lblTipo.Text = "Código:"
                Me.c1nIva.Enabled = True
                Me.chkAplicaPorc.Checked = False
                Me.chkAplicaPorc.Visible = False
                Me.chkAplicaItem.Enabled = False
            'Case AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.EscrituracionxRango, AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.TramitacionxRango
            Case sifLib.Prestamos.clsPrestamos.TipoDeduccion.EscrituracionxRango, sifLib.Prestamos.clsPrestamos.TipoDeduccion.TramitacionxRango
                Me.lblMontoMax.Visible = True
                Me.c1nMontoMax.Visible = True
                Me.lblMonto.Text = "Monto Mínimo:"
                'Me.lblMontoMax.Location = New Point(144, 32)
                'Me.c1nMontoMax.Location = New Point(144, 48)
                'Me.lblMonto.Location = New Point(304, 32)
                'Me.c1nValor.Location = New Point(304, 48)
                If vPorc = "1" Then
                    Me.lblIva.Text = "Tarifa(%):"
                Else
                    Me.lblIva.Text = "Tarifa:"
                End If
                'Me.lblIva.Location = New Point(464, 32)
                'Me.c1nIva.Location = New Point(464, 48)
                Me.chkAplicaIva.Visible = True
                Me.c1txtDescripcion.Value = ""
                Me.c1txtDescripcion.Visible = False
                'Me.c1txtDescripcion.Location = New Point(112, 48)
                Me.lblTipo.Text = "Código:"
                Me.c1nIva.Enabled = True
                Me.chkAplicaPorc.Checked = False
                Me.chkAplicaPorc.Visible = False
                Me.chkAplicaItem.Enabled = False
            'Case AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Escrituracion
            Case sifLib.Prestamos.clsPrestamos.TipoDeduccion.Escrituracion
                Me.chkAplicaItem.Enabled = True
        End Select
    End Sub

    Private Sub c1nValor_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nValor.LostFocus
        If Me.chkAplicaIva.Checked = True Then
            Dim oPerif As New wrAsociados.wsLibAsoc, ds As New DataSet, dr As DataRow
            Select Case Me.vTipoDeduccion
                'Case AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Escrituracion, AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Tramitacion
                Case sifLib.Prestamos.clsPrestamos.TipoDeduccion.Escrituracion, sifLib.Prestamos.clsPrestamos.TipoDeduccion.Tramitacion
                    ds = oPerif.ConsultarParametros("Iva", "", "Iva", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        Me.c1nIva.Value = Me.c1nValor.Value * (dr("Iva") / 100)
                    End If
                    'Case AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Honorario
                Case sifLib.Prestamos.clsPrestamos.TipoDeduccion.Honorario
            End Select
        End If
    End Sub

    Private Sub chkAplicaIva_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAplicaIva.CheckedChanged
        Dim oPerif As New wrAsociados.wsLibAsoc, ds As New DataSet, dr As DataRow
        'If Me.chkAplicaIva.Checked = True And (Me.vTipoDeduccion <> AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.EscrituracionxRango And Me.vTipoDeduccion <> AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.TramitacionxRango And Me.vTipoDeduccion <> AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Honorario) Then
        If Me.chkAplicaIva.Checked = True And (Me.vTipoDeduccion <> sifLib.Prestamos.clsPrestamos.TipoDeduccion.EscrituracionxRango And Me.vTipoDeduccion <> sifLib.Prestamos.clsPrestamos.TipoDeduccion.TramitacionxRango And Me.vTipoDeduccion <> sifLib.Prestamos.clsPrestamos.TipoDeduccion.Honorario) Then
            ds = oPerif.ConsultarParametros("Iva", "", "Iva", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.c1nIva.Value = Me.c1nValor.Value * (dr("Iva") / 100)
            End If
        ElseIf Me.chkAplicaIva.Checked = False Then
            Me.c1nIva.Value = 0
        End If
    End Sub

    Private Sub chkAplicaItem_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAplicaItem.CheckedChanged
        If Me.chkAplicaItem.Checked = True Then
            Me.txtCodItem.ReadOnly = False
        Else
            Me.txtCodItem.Text = ""
            Me.txtItem.Text = ""
            Me.txtCodItem.ReadOnly = True
        End If
    End Sub

    Private Sub txtCodItem_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodItem.DoubleClick
        Try

            If Me.chkAplicaItem.Enabled = False Then Exit Sub
            Dim oCaja As New wrCaja.wsLibCaja, ds As New Data.DataSet("Items"), dr As DataRow
            Dim frm As New frmAGenerico, sTexto As String
            frm.Text = "Buscar Item facturable"

            ds = oCaja.ObtenerListaItems("*", "Tipo_Item='P'", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oCaja.ObtenerItem(sTexto, "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables("CAItemsFact").Rows(0)
                Me.txtCodItem.Text = Trim(dr("CodItem"))
                Me.txtItem.Text = Trim(dr("Descripcion"))
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla CAItemsFact- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class