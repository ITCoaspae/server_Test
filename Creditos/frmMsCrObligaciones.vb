Public Class frmMsCrObligaciones
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents C1NEMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NECuota As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NESaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtNombreAcreedor As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String

            Select Case oCred.AutorizarDatos(Trim(Me.txtNombreAcreedor.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El Nombre del Acreedor no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCorrelativo = oCred.ObtenerCorrelativoObligaciones("Correlativo", sUsuario, sPassword, sSucursal)
                pCampos = "Correlativo,NumSolicitud,NombreAcreedor,Telefono,Monto,Saldo,Cuota,CodEnlace"
                pValores = "" & pCorrelativo & "," & pNoSolic & ",'" & Trim(Me.txtNombreAcreedor.Text) & "','" & Trim(Me.txtTel.Text) & "'," & Val(Me.C1NEMonto.Value) & "," & Val(Me.C1NESaldo.Value) & "," & Val(Me.C1NECuota.Value) & "," & pCodEnlace & ""
                If oCred.InsertarObligaciones(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("La Obligación NO ha sido agregada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "NombreAcreedor='" & Trim(Me.txtNombreAcreedor.Text) & "',Telefono='" & Trim(Me.txtTel.Text) & "',Monto=" & Val(Me.C1NEMonto.Value) & ",Saldo=" & Val(Me.C1NESaldo.Value) & ",Cuota=" & Val(Me.C1NECuota.Value) & ""
                If oCred.ModificarObligaciones(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("La Obligación no ha sido modificada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.C1NESaldo = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NECuota = New C1.Win.C1Input.C1NumericEdit()
        Me.C1NEMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.txtNombreAcreedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1NESaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NECuota, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.C1NESaldo)
        Me.GroupBox1.Controls.Add(Me.C1NECuota)
        Me.GroupBox1.Controls.Add(Me.C1NEMonto)
        Me.GroupBox1.Controls.Add(Me.txtNombreAcreedor)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(444, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'C1NESaldo
        '
        Me.C1NESaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NESaldo.CustomFormat = "###,###,##0.00"
        Me.C1NESaldo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NESaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NESaldo.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NESaldo.Location = New System.Drawing.Point(248, 80)
        Me.C1NESaldo.Name = "C1NESaldo"
        Me.C1NESaldo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NESaldo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NESaldo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NESaldo.ShowDropDownButton = False
        Me.C1NESaldo.ShowUpDownButtons = False
        Me.C1NESaldo.Size = New System.Drawing.Size(96, 21)
        Me.C1NESaldo.TabIndex = 3
        Me.C1NESaldo.Tag = Nothing
        Me.C1NESaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'C1NECuota
        '
        Me.C1NECuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NECuota.CustomFormat = "###,###,##0.00"
        Me.C1NECuota.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NECuota.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NECuota.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NECuota.Location = New System.Drawing.Point(360, 80)
        Me.C1NECuota.Name = "C1NECuota"
        Me.C1NECuota.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NECuota.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NECuota.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NECuota.ShowDropDownButton = False
        Me.C1NECuota.ShowUpDownButtons = False
        Me.C1NECuota.Size = New System.Drawing.Size(64, 21)
        Me.C1NECuota.TabIndex = 4
        Me.C1NECuota.Tag = Nothing
        Me.C1NECuota.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'C1NEMonto
        '
        Me.C1NEMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMonto.CustomFormat = "###,###,##0.00"
        Me.C1NEMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMonto.Location = New System.Drawing.Point(136, 80)
        Me.C1NEMonto.Name = "C1NEMonto"
        Me.C1NEMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMonto.ShowDropDownButton = False
        Me.C1NEMonto.ShowUpDownButtons = False
        Me.C1NEMonto.Size = New System.Drawing.Size(96, 21)
        Me.C1NEMonto.TabIndex = 2
        Me.C1NEMonto.Tag = Nothing
        Me.C1NEMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'txtNombreAcreedor
        '
        Me.txtNombreAcreedor.Location = New System.Drawing.Point(16, 32)
        Me.txtNombreAcreedor.MaxLength = 255
        Me.txtNombreAcreedor.Name = "txtNombreAcreedor"
        Me.txtNombreAcreedor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNombreAcreedor.Size = New System.Drawing.Size(408, 20)
        Me.txtNombreAcreedor.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(360, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Cuota:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(248, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Saldo:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(136, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Monto:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(16, 80)
        Me.txtTel.MaxLength = 100
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(104, 20)
        Me.txtTel.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Teléfono:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Nombre del Acreedor:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(392, 181)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 211
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCrObligaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(490, 232)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(490, 232)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(490, 232)
        Me.Name = "frmMsCrObligaciones"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Obligaciones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.C1NESaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NECuota, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmMsCrObligaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection

            If Me.pAccion = "Modificar" Then

                ds = oCred.ConsultarObligaciones("*", "Correlativo='" & pCorrelativo & "'", "Correlativo", sUsuario, sPassword,sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtNombreAcreedor.Text = IIf(IsDBNull(Filas.Item(0)("NombreAcreedor")), "", Filas.Item(0)("NombreAcreedor"))
                    Me.txtTel.Text = IIf(IsDBNull(Filas.Item(0)("Telefono")), "", Filas.Item(0)("Telefono"))
                    Me.C1NEMonto.Value = IIf(IsDBNull(Filas.Item(0)("Monto")), 0, Filas.Item(0)("Monto"))
                    Me.C1NESaldo.Value = IIf(IsDBNull(Filas.Item(0)("Saldo")), 0, Filas.Item(0)("Saldo"))
                    Me.C1NECuota.Value = IIf(IsDBNull(Filas.Item(0)("Cuota")), 0, Filas.Item(0)("Cuota"))
                End If

            End If
            Me.txtNombreAcreedor.Focus()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



End Class
