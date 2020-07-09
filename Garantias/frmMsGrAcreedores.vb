Public Class frmMsGrAcreedores
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Private pNoDoc As String, pTipo As String, pAccion As String, pCorrelativo As String
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbGrado As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents c1txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents c1nTasa As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtJuzgado As System.Windows.Forms.TextBox
    Friend WithEvents txtNotario As System.Windows.Forms.TextBox
    Friend WithEvents txtPorcHipoteca As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtReferencia As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAFavorde As System.Windows.Forms.TextBox
    Friend WithEvents txtOrden As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtJuzgado = New System.Windows.Forms.TextBox()
        Me.c1nTasa = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nPlazo = New C1.Win.C1Input.C1NumericEdit()
        Me.txtNotario = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.c1txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtPorcHipoteca = New System.Windows.Forms.NumericUpDown()
        Me.cbGrado = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtReferencia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.txtAFavorde = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPorcHipoteca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtJuzgado
        '
        Me.txtJuzgado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJuzgado.Location = New System.Drawing.Point(135, 204)
        Me.txtJuzgado.Name = "txtJuzgado"
        Me.txtJuzgado.Size = New System.Drawing.Size(448, 20)
        Me.txtJuzgado.TabIndex = 8
        '
        'c1nTasa
        '
        Me.c1nTasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTasa.CustomFormat = "#0.00"
        Me.c1nTasa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTasa.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTasa.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nTasa.Location = New System.Drawing.Point(311, 140)
        Me.c1nTasa.Name = "c1nTasa"
        Me.c1nTasa.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTasa.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTasa.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTasa.ShowDropDownButton = False
        Me.c1nTasa.ShowUpDownButtons = False
        Me.c1nTasa.Size = New System.Drawing.Size(80, 21)
        Me.c1nTasa.TabIndex = 5
        Me.c1nTasa.Tag = Nothing
        Me.c1nTasa.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nPlazo
        '
        Me.c1nPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nPlazo.CustomFormat = "###"
        Me.c1nPlazo.DataType = GetType(Short)
        Me.c1nPlazo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nPlazo.Increment = CType(1, Short)
        Me.c1nPlazo.Location = New System.Drawing.Point(527, 140)
        Me.c1nPlazo.MaxLength = 2
        Me.c1nPlazo.Name = "c1nPlazo"
        Me.c1nPlazo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nPlazo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nPlazo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nPlazo.ShowDropDownButton = False
        Me.c1nPlazo.ShowUpDownButtons = False
        Me.c1nPlazo.Size = New System.Drawing.Size(56, 21)
        Me.c1nPlazo.TabIndex = 6
        Me.c1nPlazo.Tag = Nothing
        Me.c1nPlazo.Value = CType(0, Short)
        '
        'txtNotario
        '
        Me.txtNotario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotario.Location = New System.Drawing.Point(135, 172)
        Me.txtNotario.Name = "txtNotario"
        Me.txtNotario.Size = New System.Drawing.Size(448, 20)
        Me.txtNotario.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 204)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 170
        Me.Label12.Text = "Juzgado:"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(23, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 16)
        Me.Label11.TabIndex = 169
        Me.Label11.Text = "Notario:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(447, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 16)
        Me.Label10.TabIndex = 168
        Me.Label10.Text = "Plazo:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(271, 140)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 16)
        Me.Label9.TabIndex = 167
        Me.Label9.Text = "Tasa:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(23, 140)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 166
        Me.Label8.Text = "Monto:"
        '
        'c1txtMonto
        '
        Me.c1txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtMonto.CustomFormat = "###,##0.00"
        Me.c1txtMonto.DataType = GetType(Double)
        Me.c1txtMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1txtMonto.Increment = 1.0R
        Me.c1txtMonto.Location = New System.Drawing.Point(135, 140)
        Me.c1txtMonto.Name = "c1txtMonto"
        Me.c1txtMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1txtMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(0R, Nothing, True, True)})
        Me.c1txtMonto.ShowDropDownButton = False
        Me.c1txtMonto.ShowUpDownButtons = False
        Me.c1txtMonto.Size = New System.Drawing.Size(104, 21)
        Me.c1txtMonto.TabIndex = 4
        Me.c1txtMonto.Tag = Nothing
        Me.c1txtMonto.Value = 0R
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(173, 108)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(18, 20)
        Me.TextBox1.TabIndex = 164
        '
        'txtPorcHipoteca
        '
        Me.txtPorcHipoteca.DecimalPlaces = 2
        Me.txtPorcHipoteca.Location = New System.Drawing.Point(135, 108)
        Me.txtPorcHipoteca.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.txtPorcHipoteca.Name = "txtPorcHipoteca"
        Me.txtPorcHipoteca.Size = New System.Drawing.Size(56, 20)
        Me.txtPorcHipoteca.TabIndex = 2
        Me.txtPorcHipoteca.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'cbGrado
        '
        Me.cbGrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGrado.Items.AddRange(New Object() {"1ra Hipoteca", "2da Hipoteca", "3ra Hpoteca", "4ta Hipoteca", "Secciones de Crédito", "Embargo", "5ta Hipoteca", "6ta Hipoteca", "7ma Hipoteca", "8va Hipoteca", "9na Hipoteca", "10ma Hipoteca"})
        Me.cbGrado.Location = New System.Drawing.Point(447, 108)
        Me.cbGrado.Name = "cbGrado"
        Me.cbGrado.Size = New System.Drawing.Size(136, 21)
        Me.cbGrado.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(327, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Grado de Hipoteca:"
        '
        'txtReferencia
        '
        Me.txtReferencia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Location = New System.Drawing.Point(135, 252)
        Me.txtReferencia.MaxLength = 255
        Me.txtReferencia.Multiline = True
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReferencia.Size = New System.Drawing.Size(448, 32)
        Me.txtReferencia.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Referencia Juicio:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(375, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Fecha Fin:"
        '
        'dtpFecFin
        '
        Me.dtpFecFin.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecFin.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecFin.Location = New System.Drawing.Point(487, 228)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecFin.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 228)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fecha Inicio:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "% de Hipoteca:"
        '
        'dtpFecIni
        '
        Me.dtpFecIni.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecIni.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecIni.Location = New System.Drawing.Point(135, 228)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecIni.TabIndex = 9
        '
        'txtAFavorde
        '
        Me.txtAFavorde.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAFavorde.Location = New System.Drawing.Point(135, 84)
        Me.txtAFavorde.Name = "txtAFavorde"
        Me.txtAFavorde.Size = New System.Drawing.Size(448, 20)
        Me.txtAFavorde.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "A favor de:"
        '
        'txtOrden
        '
        Me.txtOrden.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrden.Location = New System.Drawing.Point(135, 60)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(104, 20)
        Me.txtOrden.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Orden Gravamenes:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(508, 290)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 221
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsGrAcreedores
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(605, 344)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtJuzgado)
        Me.Controls.Add(Me.c1nTasa)
        Me.Controls.Add(Me.c1nPlazo)
        Me.Controls.Add(Me.txtNotario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtOrden)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAFavorde)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpFecIni)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.c1txtMonto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dtpFecFin)
        Me.Controls.Add(Me.txtPorcHipoteca)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbGrado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtReferencia)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsGrAcreedores"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Acreedores"
        CType(Me.c1nTasa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPorcHipoteca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Propiedades"
    Public Property NoDoc() As String
        Get
            Return pNoDoc
        End Get
        Set(ByVal Value As String)
            pNoDoc = Value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return pTipo
        End Get
        Set(ByVal Value As String)
            pTipo = Value
        End Set
    End Property

    Public Property Accion() As String
        Get
            Return pAccion
        End Get
        Set(ByVal Value As String)
            pAccion = Value
        End Set
    End Property

    Public Property Correlativo() As String
        Get
            Return pCorrelativo
        End Get
        Set(ByVal Value As String)
            pCorrelativo = Value
        End Set
    End Property

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim oCred As New wrCredito.wsLibCred, pCampos As String, pValores As String

        If Me.txtAFavorde.Text.Trim = "" Then
            MsgBox("El campo a favor de no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Garantías")
            Exit Sub
        End If
        Try
            If Me.pAccion = "Guardar" Then
                pCampos = "NoComprobante,NoOrden,AFavor,Porcentaje,GradoHipoteca,Monto,Tasa,Plazo,FechaIni,FechaFin,Notario,Juzgado,NoRefJuicio,Tipo"
                pValores = "'" & pNoDoc & "','" & Trim(txtOrden.Text) & "','" & Trim(txtAFavorde.Text) & "'," & Me.txtPorcHipoteca.Value & "," & Me.cbGrado.SelectedIndex & "," & Val(Me.c1txtMonto.Value) & "," & Val(Me.c1nTasa.Value) & "," & Val(Me.c1nPlazo.Value) & ",'" & Format(Me.dtpFecIni.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFecFin.Value, "dd/MM/yyyy") & "','" & Me.txtNotario.Text.Trim & "','" & Me.txtJuzgado.Text.Trim & "','" & Me.txtReferencia.Text.Trim & "','" & pTipo & "'"
                If oCred.InsertaAcreedores(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Acreedor ingresado exitosamente.", MsgBoxStyle.Information, "Módulo - Garantías")
                    Me.Dispose()
                Else
                    MsgBox("El Acreedor NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Garantías")
                End If
            ElseIf Me.pAccion = "Modificar" Then
                pCampos = "NoOrden='" & Trim(txtOrden.Text) & "',AFavor='" & Trim(txtAFavorde.Text) & "',Porcentaje=" & Me.txtPorcHipoteca.Value & ",GradoHipoteca=" & Me.cbGrado.SelectedIndex & ",Monto=" & Val(Me.c1txtMonto.Value) & ",Tasa=" & Val(Me.c1nTasa.Value) & ",Plazo=" & Val(Me.c1nPlazo.Value) & ",FechaIni='" & Format(Me.dtpFecIni.Value, "dd/MM/yyyy") & "',FechaFin='" & Format(Me.dtpFecFin.Value, "dd/MM/yyyy") & "',Notario='" & Me.txtNotario.Text.Trim & "',Juzgado='" & Me.txtJuzgado.Text.Trim & "',NoRefJuicio='" & Me.txtReferencia.Text.Trim & "'"
                If oCred.ModificarAcreedores(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Acreedor actualizado exitosamente.", MsgBoxStyle.Information, "Módulo - Garantías")
                    Me.Dispose()
                Else
                    MsgBox("El Acreedor no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Garantías")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

    Private Sub frmMsGrAcreedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oCred As New wrCredito.wsLibCred, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        Try
            If Me.pAccion = "Modificar" Then
                ds = oCred.CONSULTARACREEDORES(sUsuario, sPassword, sSucursal, Me.pNoDoc, 2, pCorrelativo)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtOrden.Text = IIf(IsDBNull(Filas.Item(0)("NoOrden")), "", Filas.Item(0)("NoOrden"))
                    txtAFavorde.Text = IIf(IsDBNull(Filas.Item(0)("AFavor")), "", Filas.Item(0)("AFavor"))
                    Me.c1nTasa.Value = IIf(IsDBNull(Filas.Item(0)("Tasa")), 0, Filas.Item(0)("Tasa"))
                    Me.c1nPlazo.Value = IIf(IsDBNull(Filas.Item(0)("Plazo")), 0, Filas.Item(0)("Plazo"))
                    Me.c1txtMonto.Value = IIf(IsDBNull(Filas.Item(0)("Monto")), 0, Filas.Item(0)("Monto"))
                    Me.txtPorcHipoteca.Value = IIf(IsDBNull(Filas.Item(0)("Porcentaje")), 0, Filas.Item(0)("Porcentaje"))
                    Me.txtNotario.Text = IIf(IsDBNull(Filas.Item(0)("Notario")), "", Filas.Item(0)("Notario"))
                    Me.txtJuzgado.Text = IIf(IsDBNull(Filas.Item(0)("Juzgado")), "", Filas.Item(0)("Juzgado"))
                    Me.txtReferencia.Text = IIf(IsDBNull(Filas.Item(0)("NoRefJuicio")), "", Filas.Item(0)("NoRefJuicio"))
                    Me.dtpFecIni.Value = IIf(IsDBNull(Filas.Item(0)("FechaIni")), Now, Filas.Item(0)("FechaIni"))
                    Me.dtpFecFin.Value = IIf(IsDBNull(Filas.Item(0)("FechaFin")), Now, Filas.Item(0)("FechaFin"))
                    Me.cbGrado.SelectedValue = IIf(IsDBNull(Filas.Item(0)("GRADOHIPOTECA")), 0, Filas.Item(0)("GRADOHIPOTECA"))
                End If
            Else
                Me.cbGrado.SelectedIndex = 0
            End If
            Me.txtOrden.Focus()
        Catch ex As Exception
        End Try
    End Sub
End Class