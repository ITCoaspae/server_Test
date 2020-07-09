Public Class frmMSCBBienesEmbargados
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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
    Friend WithEvents dtpFechaDecomiso As System.Windows.Forms.DateTimePicker
    Friend WithEvents c1nValuo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nPrecioCompra As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtPropietario As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoActivo As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtUbicacion As System.Windows.Forms.TextBox
    Friend WithEvents txtNofactura As System.Windows.Forms.TextBox
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtPerRecibeDec As System.Windows.Forms.TextBox
    Friend WithEvents txtPerDecomisa As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents cbTipoPropietario As System.Windows.Forms.ComboBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.cbTipoPropietario = New System.Windows.Forms.ComboBox()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.dtpFechaDecomiso = New System.Windows.Forms.DateTimePicker()
        Me.c1nValuo = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nPrecioCompra = New C1.Win.C1Input.C1NumericEdit()
        Me.txtPropietario = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.txtCodTipoActivo = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtUbicacion = New System.Windows.Forms.TextBox()
        Me.txtNofactura = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.txtPerRecibeDec = New System.Windows.Forms.TextBox()
        Me.txtPerDecomisa = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.c1nValuo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nPrecioCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbEstado
        '
        Me.cbEstado.Items.AddRange(New Object() {"C = Cancelado", "P =  En Pagos"})
        Me.cbEstado.Location = New System.Drawing.Point(559, 243)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(192, 21)
        Me.cbEstado.TabIndex = 85
        '
        'cbTipoPropietario
        '
        Me.cbTipoPropietario.Items.AddRange(New Object() {"D = Deudor", "F = Fiador", "O = Otro"})
        Me.cbTipoPropietario.Location = New System.Drawing.Point(192, 269)
        Me.cbTipoPropietario.Name = "cbTipoPropietario"
        Me.cbTipoPropietario.Size = New System.Drawing.Size(192, 21)
        Me.cbTipoPropietario.TabIndex = 84
        '
        'cbTipo
        '
        Me.cbTipo.Items.AddRange(New Object() {"D = Depósito", "P = Dación en Pago"})
        Me.cbTipo.Location = New System.Drawing.Point(192, 138)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(192, 21)
        Me.cbTipo.TabIndex = 83
        '
        'dtpFechaDecomiso
        '
        Me.dtpFechaDecomiso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDecomiso.Location = New System.Drawing.Point(192, 60)
        Me.dtpFechaDecomiso.Name = "dtpFechaDecomiso"
        Me.dtpFechaDecomiso.Size = New System.Drawing.Size(192, 20)
        Me.dtpFechaDecomiso.TabIndex = 76
        '
        'c1nValuo
        '
        Me.c1nValuo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nValuo.Location = New System.Drawing.Point(559, 217)
        Me.c1nValuo.Name = "c1nValuo"
        Me.c1nValuo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nValuo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nValuo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nValuo.ShowDropDownButton = False
        Me.c1nValuo.ShowUpDownButtons = False
        Me.c1nValuo.Size = New System.Drawing.Size(192, 20)
        Me.c1nValuo.TabIndex = 75
        Me.c1nValuo.Tag = Nothing
        Me.c1nValuo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nPrecioCompra
        '
        Me.c1nPrecioCompra.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nPrecioCompra.Location = New System.Drawing.Point(192, 217)
        Me.c1nPrecioCompra.Name = "c1nPrecioCompra"
        Me.c1nPrecioCompra.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nPrecioCompra.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nPrecioCompra.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nPrecioCompra.ShowDropDownButton = False
        Me.c1nPrecioCompra.ShowUpDownButtons = False
        Me.c1nPrecioCompra.Size = New System.Drawing.Size(192, 20)
        Me.c1nPrecioCompra.TabIndex = 74
        Me.c1nPrecioCompra.Tag = Nothing
        Me.c1nPrecioCompra.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtPropietario
        '
        Me.txtPropietario.Location = New System.Drawing.Point(559, 270)
        Me.txtPropietario.MaxLength = 100
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.Size = New System.Drawing.Size(192, 20)
        Me.txtPropietario.TabIndex = 73
        '
        'txtModelo
        '
        Me.txtModelo.Location = New System.Drawing.Point(559, 191)
        Me.txtModelo.MaxLength = 50
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(192, 20)
        Me.txtModelo.TabIndex = 71
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(559, 164)
        Me.txtSerie.MaxLength = 50
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(192, 20)
        Me.txtSerie.TabIndex = 70
        '
        'txtCodTipoActivo
        '
        Me.txtCodTipoActivo.Location = New System.Drawing.Point(559, 138)
        Me.txtCodTipoActivo.MaxLength = 5
        Me.txtCodTipoActivo.Name = "txtCodTipoActivo"
        Me.txtCodTipoActivo.Size = New System.Drawing.Size(192, 20)
        Me.txtCodTipoActivo.TabIndex = 69
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(192, 322)
        Me.txtObservaciones.MaxLength = 255
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(559, 64)
        Me.txtObservaciones.TabIndex = 68
        '
        'txtUbicacion
        '
        Me.txtUbicacion.Location = New System.Drawing.Point(192, 296)
        Me.txtUbicacion.MaxLength = 100
        Me.txtUbicacion.Name = "txtUbicacion"
        Me.txtUbicacion.Size = New System.Drawing.Size(559, 20)
        Me.txtUbicacion.TabIndex = 67
        '
        'txtNofactura
        '
        Me.txtNofactura.Location = New System.Drawing.Point(192, 243)
        Me.txtNofactura.MaxLength = 25
        Me.txtNofactura.Name = "txtNofactura"
        Me.txtNofactura.Size = New System.Drawing.Size(192, 20)
        Me.txtNofactura.TabIndex = 65
        '
        'txtMarca
        '
        Me.txtMarca.Location = New System.Drawing.Point(192, 191)
        Me.txtMarca.MaxLength = 50
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(192, 20)
        Me.txtMarca.TabIndex = 64
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(192, 165)
        Me.txtProducto.MaxLength = 10
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(192, 20)
        Me.txtProducto.TabIndex = 63
        '
        'txtPerRecibeDec
        '
        Me.txtPerRecibeDec.Location = New System.Drawing.Point(192, 112)
        Me.txtPerRecibeDec.MaxLength = 100
        Me.txtPerRecibeDec.Name = "txtPerRecibeDec"
        Me.txtPerRecibeDec.Size = New System.Drawing.Size(559, 20)
        Me.txtPerRecibeDec.TabIndex = 61
        '
        'txtPerDecomisa
        '
        Me.txtPerDecomisa.Location = New System.Drawing.Point(192, 86)
        Me.txtPerDecomisa.MaxLength = 100
        Me.txtPerDecomisa.Name = "txtPerDecomisa"
        Me.txtPerDecomisa.Size = New System.Drawing.Size(559, 20)
        Me.txtPerDecomisa.TabIndex = 60
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(23, 332)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(100, 23)
        Me.Label19.TabIndex = 57
        Me.Label19.Text = "Observaciones:"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(23, 295)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(100, 23)
        Me.Label18.TabIndex = 56
        Me.Label18.Text = "Ubicación:"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(390, 272)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 23)
        Me.Label17.TabIndex = 55
        Me.Label17.Text = "Propietario:"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(23, 272)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 23)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "Tipo de Propietario:"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(390, 243)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 23)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Estado:"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(23, 243)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(100, 23)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "No de Factura:"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(390, 217)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 23)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Valuo:"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(23, 214)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 23)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Precio de Compra:"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(390, 194)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 23)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Modelo:"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(390, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Serie:"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(23, 191)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Marca:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(23, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Producto:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(390, 141)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 16)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Código Tipo de Activo:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(23, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Tipo:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 17)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Quien Recibe Decomiso:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 21)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Nombre Persona que Decomisa:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Fecha Decomiso:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(676, 392)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 199
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMSCBBienesEmbargados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(782, 455)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.cbTipoPropietario)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPropietario)
        Me.Controls.Add(Me.c1nPrecioCompra)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.txtUbicacion)
        Me.Controls.Add(Me.dtpFechaDecomiso)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtNofactura)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.c1nValuo)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPerDecomisa)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtPerRecibeDec)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtSerie)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCodTipoActivo)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtProducto)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(782, 455)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(782, 455)
        Me.Name = "frmMSCBBienesEmbargados"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Detalle del Bien Embargado"
        CType(Me.c1nValuo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nPrecioCompra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public DUI As String, pCodBienEmbargado As String
    Public CodPrestamo As String



    Private Sub frmMSCBBienesEmbargados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New DataSet, Filas As Data.DataRowCollection

        If Me.btnGuardar1.Text = "&Guardar" Then
            Me.cbEstado.SelectedIndex = 0
            Me.cbTipo.SelectedIndex = 0
            Me.cbTipoPropietario.SelectedIndex = 0
        Else
            ds = oCred.ConsultarCBBienesEmbargados("*", "CodBienEmbargado='" & pCodBienEmbargado & "'", "CodBienEmbargado", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                Me.dtpFechaDecomiso.Value = Filas.Item(0)("FechaDecomiso")
                Me.txtPerDecomisa.Text = Filas.Item(0)("NombreDecomisa")
                Me.txtPerRecibeDec.Text = Filas.Item(0)("RecibeDecomiso")
                Me.txtCodTipoActivo.Text = Filas.Item(0)("CodTipoActivo")
                Me.txtProducto.Text = Filas.Item(0)("Producto")
                Me.txtMarca.Text = Filas.Item(0)("Marca")
                Me.txtSerie.Text = Filas.Item(0)("Serie")
                Me.txtModelo.Text = Filas.Item(0)("Modelo")
                Me.c1nPrecioCompra.Value = Filas.Item(0)("Precio_Compra")
                Me.c1nValuo.Value = Filas.Item(0)("Valuo")
                Me.txtNofactura.Text = Filas.Item(0)("NoFactura")
                Me.txtPropietario.Text = Filas.Item(0)("Propietario")
                Me.txtUbicacion.Text = Filas.Item(0)("Ubicacion")
                Me.txtObservaciones.Text = Filas.Item(0)("Observaciones")
            End If
        End If
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim Campos, Valores, CamposValores As String
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred

            Dim Estado, Tipo, TipoPropietario As String
            Estado = Me.cbEstado.SelectedIndex
            If Estado = 0 Then
                Estado = "C"
            Else
                Estado = "P"
            End If
            Tipo = Me.cbTipo.SelectedIndex
            If Tipo = 0 Then
                Tipo = "D"
            Else
                Tipo = "P"
            End If
            TipoPropietario = Me.cbTipoPropietario.SelectedIndex
            If TipoPropietario = 0 Then
                TipoPropietario = "D"
            ElseIf TipoPropietario = 1 Then
                TipoPropietario = "F"
            Else
                TipoPropietario = "O"
            End If
            If Me.btnGuardar1.Text = "&Guardar" Then
                If CodPrestamo = "" Or Me.txtPerDecomisa.Text = "" Or Me.txtPerRecibeDec.Text = "" Or Me.txtCodTipoActivo.Text = "" Then
                    MsgBox("Existen campos que no deben de quedar vacíos, verifique y vuelva a intentarlo", MsgBoxStyle.Information, "Módulo - Créditos")
                Else
                    Campos = "CodPrestamo,FechaDecomiso,NombreDecomisa,RecibeDecomiso,Tipo,CodTipoActivo,Producto,Marca,Serie,Modelo,Precio_Compra,Valuo,NoFactura,Estado,TipoPropietario,Propietario,Ubicacion,Observaciones"
                    Valores = "'" & Trim(CodPrestamo) & "','" & (Me.dtpFechaDecomiso.Value.ToShortDateString) & "','" & Trim(Me.txtPerDecomisa.Text) & "','" & Trim(Me.txtPerRecibeDec.Text) & "','" & Tipo & "','" & Trim(Me.txtCodTipoActivo.Text) & "','" & Trim(Me.txtProducto.Text) & "','" & Trim(Me.txtMarca.Text) & "','" & Trim(Me.txtSerie.Text) & "','" & Trim(Me.txtModelo.Text) & "'," & Val(Me.c1nPrecioCompra.Value) & "," & Val(Me.c1nValuo.Value) & ",'" & Trim(Me.txtNofactura.Text) & "','" & Estado & "','" & TipoPropietario & "','" & Trim(Me.txtPropietario.Text) & "','" & Trim(Me.txtUbicacion.Text) & "','" & Trim(Me.txtObservaciones.Text) & "'"
                    If oCred.InsertarCBBienesEMbargados(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                        Me.Dispose()
                    Else
                        MsgBox("Los datos no fuerón ingresados correctamente", MsgBoxStyle.Critical, "Módulo - Créditos")
                    End If
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                CamposValores = "CodPrestamo='" & Trim(CodPrestamo) & "',FechaDecomiso='" & (Me.dtpFechaDecomiso.Value.ToShortDateString) & "',NombreDecomisa='" & Trim(Me.txtPerDecomisa.Text) & "',RecibeDecomiso='" & Trim(Me.txtPerRecibeDec.Text) & "',Tipo='" & Tipo & "',CodTipoActivo='" & Trim(Me.txtCodTipoActivo.Text) & "',Producto='" & Trim(Me.txtProducto.Text) & "',Marca='" & Trim(Me.txtMarca.Text) & "',Serie='" & Trim(Me.txtSerie.Text) & "',Modelo='" & Trim(Me.txtModelo.Text) & "',Precio_Compra=" & Val(Me.c1nPrecioCompra.Value) & ",Valuo=" & Val(Me.c1nValuo.Value) & ",NoFactura='" & Trim(Me.txtNofactura.Text) & "',Estado='" & Estado & "',TipoPropietario='" & TipoPropietario & "',Propietario='" & Trim(Me.txtPropietario.Text) & "',Ubicacion='" & Trim(Me.txtUbicacion.Text) & "',Observaciones='" & Trim(Me.txtObservaciones.Text) & "'"
                If oCred.ModificarCBBienesEmbargados(CamposValores, pCodBienEmbargado, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos no fueron modificados correctamente.", MsgBoxStyle.Critical, "Módulo - Créditos")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
