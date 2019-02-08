Public Class frmMsCrLineasCred
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pAccion As String
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1NEInteres As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NEMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NEOtorgado As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents c1nEIntMax As C1.Win.C1Input.C1NumericEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.c1nEIntMax = New C1.Win.C1Input.C1NumericEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.C1NEOtorgado = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NEMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NEInteres = New C1.Win.C1Input.C1NumericEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.c1nEIntMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEOtorgado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEInteres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1nEIntMax
        '
        Me.c1nEIntMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nEIntMax.CustomFormat = "#0.00"
        Me.c1nEIntMax.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nEIntMax.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nEIntMax.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nEIntMax.Location = New System.Drawing.Point(347, 141)
        Me.c1nEIntMax.Name = "c1nEIntMax"
        Me.c1nEIntMax.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nEIntMax.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nEIntMax.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nEIntMax.ShowDropDownButton = False
        Me.c1nEIntMax.ShowUpDownButtons = False
        Me.c1nEIntMax.Size = New System.Drawing.Size(104, 21)
        Me.c1nEIntMax.TabIndex = 84
        Me.c1nEIntMax.Tag = Nothing
        Me.c1nEIntMax.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(237, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 34)
        Me.Label6.TabIndex = 83
        Me.Label6.Text = "Tasa de Interés máximo:"
        '
        'C1NEOtorgado
        '
        Me.C1NEOtorgado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEOtorgado.CustomFormat = "###,###,##0.00"
        Me.C1NEOtorgado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEOtorgado.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEOtorgado.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEOtorgado.Location = New System.Drawing.Point(347, 114)
        Me.C1NEOtorgado.Name = "C1NEOtorgado"
        Me.C1NEOtorgado.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEOtorgado.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEOtorgado.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEOtorgado.ShowDropDownButton = False
        Me.C1NEOtorgado.ShowUpDownButtons = False
        Me.C1NEOtorgado.Size = New System.Drawing.Size(104, 21)
        Me.C1NEOtorgado.TabIndex = 2
        Me.C1NEOtorgado.Tag = Nothing
        Me.C1NEOtorgado.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'C1NEMonto
        '
        Me.C1NEMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMonto.CustomFormat = "###,###,##0.00"
        Me.C1NEMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMonto.Location = New System.Drawing.Point(127, 114)
        Me.C1NEMonto.Name = "C1NEMonto"
        Me.C1NEMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMonto.ShowDropDownButton = False
        Me.C1NEMonto.ShowUpDownButtons = False
        Me.C1NEMonto.Size = New System.Drawing.Size(104, 21)
        Me.C1NEMonto.TabIndex = 1
        Me.C1NEMonto.Tag = Nothing
        Me.C1NEMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'C1NEInteres
        '
        Me.C1NEInteres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEInteres.CustomFormat = "#0.00"
        Me.C1NEInteres.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.C1NEInteres.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEInteres.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.C1NEInteres.Location = New System.Drawing.Point(127, 141)
        Me.C1NEInteres.Name = "C1NEInteres"
        Me.C1NEInteres.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEInteres.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEInteres.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEInteres.ShowDropDownButton = False
        Me.C1NEInteres.ShowUpDownButtons = False
        Me.C1NEInteres.Size = New System.Drawing.Size(104, 21)
        Me.C1NEInteres.TabIndex = 3
        Me.C1NEInteres.Tag = Nothing
        Me.C1NEInteres.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 34)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Tasa de Interés " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "mínimo:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Monto destinado:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(237, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Monto Otorgado:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(127, 88)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(324, 20)
        Me.txtDescripcion.TabIndex = 0
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(127, 57)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(72, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Código:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(23, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Monto total:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(376, 177)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 210
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCrLineasCred
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(474, 217)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.c1nEIntMax)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.C1NEInteres)
        Me.Controls.Add(Me.C1NEOtorgado)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.C1NEMonto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDescripcion)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(474, 217)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(474, 217)
        Me.Name = "frmMsCrLineasCred"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Líneas de Crédito"
        CType(Me.c1nEIntMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEOtorgado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEInteres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub frmMsCrLineasCred_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection

            If Me.pAccion = "Modificar" Then

                ds = oCred.ConsultarLineaCreditos("*", "CodLineaCredito='" & pCodigo & "'", "CodLineaCredito", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtCodigo.Text = pCodigo
                    txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    C1NEMonto.Value = IIf(IsDBNull(Filas.Item(0)("MontoTotal")), 0, Filas.Item(0)("MontoTotal"))
                    C1NEOtorgado.Value = IIf(IsDBNull(Filas.Item(0)("Otorgado")), 0, Filas.Item(0)("Otorgado"))
                    C1NEInteres.Value = IIf(IsDBNull(Filas.Item(0)("InteresMinimo")), 0, Filas.Item(0)("InteresMinimo"))
                    c1nEIntMax.Value = IIf(IsDBNull(Filas.Item(0)("InteresMaximo")), 0, Filas.Item(0)("InteresMaximo"))
                End If
            Else
                Dim vCod As String
                vCod = oCred.ObtenerCorrelativoLineaCreditos("CodLineaCredito", sUsuario, sPassword, sSucursal)
                Me.txtCodigo.Text = vCod.PadLeft(5, "0")
            End If
            txtCodigo.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String

            Select Case oCred.AutorizarDatos(Trim(txtCodigo.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El Código de Línea de Crédito no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "CodLineaCredito,Descripcion,MontoTotal,Otorgado,InteresMinimo,InteresMaximo"
                pValores = "'" & Me.txtCodigo.Text.Trim & "','" & Trim(txtDescripcion.Text) & "'," & Me.C1NEMonto.Value & "," & Me.C1NEOtorgado.Value & "," & Me.C1NEInteres.Value & "," & Me.c1nEIntMax.Value & ""
                If oCred.InsertarLineaCreditos(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("La Línea de Crédito NO ha sido agregada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Descripcion='" & Trim(txtDescripcion.Text) & "',MontoTotal=" & Me.C1NEMonto.Value & ",Otorgado=" & Me.C1NEOtorgado.Value & ",InteresMinimo=" & Me.C1NEInteres.Value & ",InteresMaximo=" & Me.c1nEIntMax.Value & ""
                If oCred.ModificarLineaCreditos(Trim(pCodigo), pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("La Línea de Crédito no ha sido modificada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub C1NEInteres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1NEInteres.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnGuardar1_Click(sender, e)
        End If
    End Sub

End Class
