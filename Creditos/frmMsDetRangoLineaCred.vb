Public Class frmMsDetRangoLineaCred
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private vCodLineaCredito As String, vAccion As String
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
    Friend WithEvents c1nHasta As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents c1nDesde As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.c1nHasta = New C1.Win.C1Input.C1NumericEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.c1nDesde = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.c1nHasta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nDesde, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1nHasta
        '
        Me.c1nHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nHasta.CustomFormat = "#######0.00"
        Me.c1nHasta.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nHasta.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nHasta.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nHasta.Location = New System.Drawing.Point(225, 70)
        Me.c1nHasta.Name = "c1nHasta"
        Me.c1nHasta.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nHasta.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nHasta.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nHasta.ShowDropDownButton = False
        Me.c1nHasta.ShowUpDownButtons = False
        Me.c1nHasta.Size = New System.Drawing.Size(88, 21)
        Me.c1nHasta.TabIndex = 1
        Me.c1nHasta.Tag = Nothing
        Me.c1nHasta.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(171, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 169
        Me.Label8.Text = "Hasta:"
        '
        'c1nDesde
        '
        Me.c1nDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nDesde.CustomFormat = "#######0.00"
        Me.c1nDesde.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nDesde.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nDesde.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.c1nDesde.Location = New System.Drawing.Point(77, 70)
        Me.c1nDesde.Name = "c1nDesde"
        Me.c1nDesde.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nDesde.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nDesde.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nDesde.ShowDropDownButton = False
        Me.c1nDesde.ShowUpDownButtons = False
        Me.c1nDesde.Size = New System.Drawing.Size(88, 21)
        Me.c1nDesde.TabIndex = 0
        Me.c1nDesde.Tag = Nothing
        Me.c1nDesde.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Desde:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(355, 97)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 37
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsDetRangoLineaCred
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(453, 155)
        Me.Controls.Add(Me.c1nHasta)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.c1nDesde)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(453, 155)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(453, 155)
        Me.Name = "frmMsDetRangoLineaCred"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Detalle de Rangos por Línea de Crédito"
        CType(Me.c1nHasta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nDesde, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Propiedades"
    Public Property CodLineaCredito() As String
        Get
            Return vCodLineaCredito
        End Get
        Set(ByVal Value As String)
            vCodLineaCredito = Value
        End Set
    End Property

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String

            If vAccion = "Guardar" Then
                pCampos = "Correlativo,CodLineaCredito,Desde,Hasta"
                pValores = "'" & oCred.ObtenerCorrelativoRangoLineaCreditos("Correlativo", sUsuario, sPassword, sSucursal) & "','" & vCodLineaCredito.Trim & "'," & Me.c1nDesde.Value & "," & Me.c1nHasta.Value & ""
                If oCred.InsertarRangoLineaCreditos(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Datos NO han sido agregados. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Property Accion() As String
        Get
            Return vAccion
        End Get
        Set(ByVal Value As String)
            vAccion = Value
        End Set
    End Property
#End Region


End Class