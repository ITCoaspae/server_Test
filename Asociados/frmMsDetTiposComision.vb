Public Class frmMsDetTiposComision
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private pAccion As String, pCorrelativo As Integer, pCodigo As String
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblMontoMax As System.Windows.Forms.Label
    Friend WithEvents c1nMontoMax As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1nMontoMin As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nValor As C1.Win.C1Input.C1NumericEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.c1nMontoMin = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMontoMax = New System.Windows.Forms.Label()
        Me.c1nMontoMax = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nValor = New C1.Win.C1Input.C1NumericEdit()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1nMontoMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMontoMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nValor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.c1nMontoMin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblMontoMax)
        Me.GroupBox1.Controls.Add(Me.c1nMontoMax)
        Me.GroupBox1.Controls.Add(Me.c1nValor)
        Me.GroupBox1.Controls.Add(Me.lblMonto)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(289, 117)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'c1nMontoMin
        '
        Me.c1nMontoMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoMin.CustomFormat = "###,###,##0.00"
        Me.c1nMontoMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoMin.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoMin.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nMontoMin.Location = New System.Drawing.Point(110, 24)
        Me.c1nMontoMin.Name = "c1nMontoMin"
        Me.c1nMontoMin.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoMin.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoMin.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoMin.ShowDropDownButton = False
        Me.c1nMontoMin.ShowUpDownButtons = False
        Me.c1nMontoMin.Size = New System.Drawing.Size(96, 20)
        Me.c1nMontoMin.TabIndex = 0
        Me.c1nMontoMin.Tag = Nothing
        Me.c1nMontoMin.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Valor Mínimo:"
        '
        'lblMontoMax
        '
        Me.lblMontoMax.Location = New System.Drawing.Point(16, 58)
        Me.lblMontoMax.Name = "lblMontoMax"
        Me.lblMontoMax.Size = New System.Drawing.Size(88, 16)
        Me.lblMontoMax.TabIndex = 78
        Me.lblMontoMax.Text = "Valor Máximo:"
        '
        'c1nMontoMax
        '
        Me.c1nMontoMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontoMax.CustomFormat = "###,###,##0.00"
        Me.c1nMontoMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontoMax.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMontoMax.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nMontoMax.Location = New System.Drawing.Point(110, 54)
        Me.c1nMontoMax.Name = "c1nMontoMax"
        Me.c1nMontoMax.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMontoMax.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMontoMax.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMontoMax.ShowDropDownButton = False
        Me.c1nMontoMax.ShowUpDownButtons = False
        Me.c1nMontoMax.Size = New System.Drawing.Size(96, 20)
        Me.c1nMontoMax.TabIndex = 1
        Me.c1nMontoMax.Tag = Nothing
        Me.c1nMontoMax.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'c1nValor
        '
        Me.c1nValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nValor.CustomFormat = "###,###,##0.00"
        Me.c1nValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nValor.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nValor.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nValor.Location = New System.Drawing.Point(110, 88)
        Me.c1nValor.Name = "c1nValor"
        Me.c1nValor.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nValor.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nValor.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nValor.ShowDropDownButton = False
        Me.c1nValor.ShowUpDownButtons = False
        Me.c1nValor.Size = New System.Drawing.Size(96, 20)
        Me.c1nValor.TabIndex = 2
        Me.c1nValor.Tag = Nothing
        Me.c1nValor.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblMonto
        '
        Me.lblMonto.Location = New System.Drawing.Point(16, 88)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(80, 19)
        Me.lblMonto.TabIndex = 73
        Me.lblMonto.Text = "Monto ($):"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(225, 186)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(87, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 134
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsDetTiposComision
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(335, 231)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsDetTiposComision"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Detalle Tipos de Comisión"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1nMontoMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMontoMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nValor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Propiedades"

    Public Property Accion() As String
        Get
            Return pAccion
        End Get
        Set(ByVal Value As String)
            pAccion = Value
        End Set
    End Property

    Public Property Correlativo() As Integer
        Get
            Return pCorrelativo
        End Get
        Set(ByVal Value As Integer)
            pCorrelativo = Value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return pCodigo
        End Get
        Set(ByVal Value As String)
            pCodigo = Value
        End Set
    End Property

#End Region

    Private Sub frmMsDetTiposComision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow

        If Me.pAccion = "Modificar" Then
            ds = oAsoc.ConsultarDetalleComisionesMercadeo("*", "Correlativo=" & pCorrelativo & "", "Correlativo", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.c1nMontoMax.Value = dr("ValorMaximo")
                Me.c1nMontoMin.Value = dr("ValorMinimo")
                Me.c1nValor.Value = dr("Valor")
            End If
        End If
        Me.c1nMontoMin.Focus()

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click

        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String
        If Me.pAccion = "Guardar" Then
            pCampos = "Codigo,ValorMinimo,ValorMaximo,Valor"
            pValores = "'" & pCodigo & "'," & Me.c1nMontoMin.Value & "," & Me.c1nMontoMax.Value & "," & Me.c1nValor.Value & ""
            If oAsoc.InsertarDetalleComisionesMercadeo(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                Me.Dispose()
            Else
                MsgBox("El registro no ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
            End If
        ElseIf Me.pAccion = "Modificar" Then
            pCampos = "ValorMinimo=" & Me.c1nMontoMin.Value & ",ValorMaximo=" & Me.c1nMontoMax.Value & ",Valor=" & Me.c1nValor.Value & ""
            If oAsoc.ModificarDetalleComisionesMercadeo("Correlativo=" & pCorrelativo & "", pCampos, sUsuario, sPassword, sSucursal) = True Then
                Me.Dispose()
            Else
                MsgBox("El registro no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
            End If
        End If
    End Sub



End Class
