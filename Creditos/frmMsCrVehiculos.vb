Public Class frmMsCrVehiculos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pNoSolic As Long, pCodEnlace As Long, pCorrelativo As Long, pAccion As String
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoPlaca As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoVehiculo As System.Windows.Forms.TextBox
    Friend WithEvents C1NEValor As C1.Win.C1Input.C1NumericEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.C1NEValor = New C1.Win.C1Input.C1NumericEdit()
        Me.txtNoPlaca = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTipoVehiculo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.C1NEValor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1NEValor
        '
        Me.C1NEValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEValor.CustomFormat = "###,###,##0.00"
        Me.C1NEValor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEValor.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEValor.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NEValor.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEValor.Location = New System.Drawing.Point(125, 109)
        Me.C1NEValor.Name = "C1NEValor"
        Me.C1NEValor.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEValor.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEValor.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEValor.Size = New System.Drawing.Size(144, 19)
        Me.C1NEValor.TabIndex = 2
        Me.C1NEValor.Tag = Nothing
        Me.C1NEValor.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.C1NEValor.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'txtNoPlaca
        '
        Me.txtNoPlaca.Location = New System.Drawing.Point(125, 83)
        Me.txtNoPlaca.MaxLength = 20
        Me.txtNoPlaca.Name = "txtNoPlaca"
        Me.txtNoPlaca.Size = New System.Drawing.Size(144, 20)
        Me.txtNoPlaca.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Valor:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Número de Placa:"
        '
        'txtTipoVehiculo
        '
        Me.txtTipoVehiculo.Location = New System.Drawing.Point(125, 57)
        Me.txtTipoVehiculo.MaxLength = 50
        Me.txtTipoVehiculo.Name = "txtTipoVehiculo"
        Me.txtTipoVehiculo.Size = New System.Drawing.Size(320, 20)
        Me.txtTipoVehiculo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Tipo de Vehículo:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(370, 142)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 36
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCrVehiculos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(466, 197)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.C1NEValor)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtNoPlaca)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTipoVehiculo)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(466, 197)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(466, 197)
        Me.Name = "frmMsCrVehiculos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Vehículos"
        CType(Me.C1NEValor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String

            Select Case oCred.AutorizarDatos(Trim(Me.txtTipoVehiculo.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El Tipo de Vehículo no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCorrelativo = oCred.ObtenerCorrelativoVehiculos("Correlativo", sUsuario, sPassword, sSucursal)
                pCampos = "Correlativo,NumSolicitud,TipoVehiculo,PlacaNo,Valor,CodEnlace"
                pValores = "" & pCorrelativo & "," & pNoSolic & ",'" & Trim(Me.txtTipoVehiculo.Text) & "','" & Trim(Me.txtNoPlaca.Text) & "'," & Val(Me.C1NEValor.Value) & "," & pCodEnlace & ""
                If oCred.InsertarVehiculos(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Vehículo NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "TipoVehiculo='" & Trim(Me.txtTipoVehiculo.Text) & "',PlacaNo='" & Trim(Me.txtNoPlaca.Text) & "',Valor=" & Val(Me.C1NEValor.Value) & ""
                If oCred.ModificarVehiculos(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Vehículo no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsCrVehiculos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection

            If Me.pAccion = "Modificar" Then

                ds = oCred.ConsultarVehiculos("*", "Correlativo='" & pCorrelativo & "'", "Correlativo", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtTipoVehiculo.Text = IIf(IsDBNull(Filas.Item(0)("TipoVehiculo")), "", Filas.Item(0)("TipoVehiculo"))
                    Me.txtNoPlaca.Text = IIf(IsDBNull(Filas.Item(0)("PlacaNo")), "", Filas.Item(0)("PlacaNo"))
                    Me.C1NEValor.Value = IIf(IsDBNull(Filas.Item(0)("Valor")), 0, Filas.Item(0)("Valor"))
                End If

            End If
            Me.txtTipoVehiculo.Focus()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub C1NEValor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles C1NEValor.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnGuardar1_Click(sender, e)
        End If
    End Sub

End Class
