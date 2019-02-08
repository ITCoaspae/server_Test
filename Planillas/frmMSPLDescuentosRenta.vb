Public Class frmMSPLDescuentosRenta
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Public vAccion As String
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private oPlan As wrPlanilla.wsLibPlanilla = New wrPlanilla.wsLibPlanilla

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

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
    Friend WithEvents c1nPorcentaje As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nValorFijo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nHasta As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nDesde As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents c1nValorSobre As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCorrelativo As System.Windows.Forms.TextBox
    Friend WithEvents lblCorrelativo As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCorrelativo = New System.Windows.Forms.TextBox()
        Me.lblCorrelativo = New System.Windows.Forms.Label()
        Me.c1nValorSobre = New C1.Win.C1Input.C1NumericEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.c1nPorcentaje = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nValorFijo = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nHasta = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nDesde = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.c1nValorSobre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nValorFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(346, 142)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 126
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(315, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 31)
        Me.Label7.TabIndex = 79
        Me.Label7.Text = "M: Mensual; Q: Quincenal; S: Semestral"
        '
        'txtCorrelativo
        '
        Me.txtCorrelativo.Location = New System.Drawing.Point(123, 60)
        Me.txtCorrelativo.MaxLength = 1
        Me.txtCorrelativo.Name = "txtCorrelativo"
        Me.txtCorrelativo.Size = New System.Drawing.Size(111, 20)
        Me.txtCorrelativo.TabIndex = 0
        '
        'lblCorrelativo
        '
        Me.lblCorrelativo.Location = New System.Drawing.Point(23, 60)
        Me.lblCorrelativo.Name = "lblCorrelativo"
        Me.lblCorrelativo.Size = New System.Drawing.Size(94, 16)
        Me.lblCorrelativo.TabIndex = 78
        Me.lblCorrelativo.Text = "Correlativo:"
        '
        'c1nValorSobre
        '
        Me.c1nValorSobre.FormatType = C1.Win.C1Input.FormatTypeEnum.FixedPoint
        Me.c1nValorSobre.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nValorSobre.Location = New System.Drawing.Point(123, 138)
        Me.c1nValorSobre.Name = "c1nValorSobre"
        Me.c1nValorSobre.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nValorSobre.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nValorSobre.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nValorSobre.Size = New System.Drawing.Size(111, 18)
        Me.c1nValorSobre.TabIndex = 5
        Me.c1nValorSobre.Tag = Nothing
        Me.c1nValorSobre.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nValorSobre.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(23, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 16)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Valor Sobre:"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(286, 60)
        Me.txtTipo.MaxLength = 1
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(24, 20)
        Me.txtTipo.TabIndex = 75
        Me.txtTipo.Text = "M"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(240, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Tipo:"
        '
        'c1nPorcentaje
        '
        Me.c1nPorcentaje.FormatType = C1.Win.C1Input.FormatTypeEnum.FixedPoint
        Me.c1nPorcentaje.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nPorcentaje.Location = New System.Drawing.Point(310, 116)
        Me.c1nPorcentaje.Name = "c1nPorcentaje"
        Me.c1nPorcentaje.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nPorcentaje.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nPorcentaje.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nPorcentaje.Size = New System.Drawing.Size(111, 18)
        Me.c1nPorcentaje.TabIndex = 4
        Me.c1nPorcentaje.Tag = Nothing
        Me.c1nPorcentaje.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nPorcentaje.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nValorFijo
        '
        Me.c1nValorFijo.FormatType = C1.Win.C1Input.FormatTypeEnum.FixedPoint
        Me.c1nValorFijo.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nValorFijo.Location = New System.Drawing.Point(123, 112)
        Me.c1nValorFijo.Name = "c1nValorFijo"
        Me.c1nValorFijo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nValorFijo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nValorFijo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nValorFijo.Size = New System.Drawing.Size(111, 18)
        Me.c1nValorFijo.TabIndex = 3
        Me.c1nValorFijo.Tag = Nothing
        Me.c1nValorFijo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nValorFijo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nHasta
        '
        Me.c1nHasta.FormatType = C1.Win.C1Input.FormatTypeEnum.FixedPoint
        Me.c1nHasta.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nHasta.Location = New System.Drawing.Point(310, 90)
        Me.c1nHasta.Name = "c1nHasta"
        Me.c1nHasta.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nHasta.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nHasta.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nHasta.Size = New System.Drawing.Size(111, 18)
        Me.c1nHasta.TabIndex = 2
        Me.c1nHasta.Tag = Nothing
        Me.c1nHasta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nHasta.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1nDesde
        '
        Me.c1nDesde.FormatType = C1.Win.C1Input.FormatTypeEnum.FixedPoint
        Me.c1nDesde.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nDesde.Location = New System.Drawing.Point(123, 86)
        Me.c1nDesde.Name = "c1nDesde"
        Me.c1nDesde.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nDesde.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nDesde.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nDesde.Size = New System.Drawing.Size(111, 18)
        Me.c1nDesde.TabIndex = 1
        Me.c1nDesde.Tag = Nothing
        Me.c1nDesde.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nDesde.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(240, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Porcentaje:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(240, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Hasta:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Valor fijo:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Desde:"
        '
        'frmMSPLDescuentosRenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(483, 218)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.c1nValorSobre)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.c1nPorcentaje)
        Me.Controls.Add(Me.txtCorrelativo)
        Me.Controls.Add(Me.c1nValorFijo)
        Me.Controls.Add(Me.c1nHasta)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.c1nDesde)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCorrelativo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "frmMSPLDescuentosRenta"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Tabla de Renta"
        CType(Me.c1nValorSobre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nValorFijo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim Campos As String, Valores As String, CamposValores As String

            If Me.btnGuardar1.Text = "&Guardar" Then
                Campos = "Tipo,Desde,Hasta,Valor_Fijo,Porcentaje,Valor_Sobre"
                Valores = "'" & Trim(Me.txtTipo.Text) & "','" & Val(Me.c1nDesde.Value) & "','" & Val(Me.c1nHasta.Value) & "','" & Val(Me.c1nValorFijo.Value) & "','" & Val(Me.c1nPorcentaje.Value) & "','" & Val(Me.c1nValorSobre.Value) & "'"

                If oPlan.InsertarPLDescuentosRenta(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos no fueron correctamente ingresados.", MsgBoxStyle.Critical, "Módulo - Planilla")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                CamposValores = "Tipo='" & Trim(Me.txtTipo.Text) & "',Desde='" & Val(Me.c1nDesde.Value) & "',Hasta='" & Val(Me.c1nHasta.Value) & "',Valor_Fijo='" & Val(Me.c1nValorFijo.Value) & "',Porcentaje='" & Val(Me.c1nPorcentaje.Value) & "',Valor_Sobre='" & Val(Me.c1nValorSobre.Value) & "'"
                If oPlan.ModificarPLDescuentosRenta(CamposValores, "'" & Val(Me.txtCorrelativo.Text) & "'", sUsuario, sPassword, sSucursal) Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos no fueron modificados correctamente.", MsgBoxStyle.Critical, "Módulo - Planilla")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub



#End Region



End Class
