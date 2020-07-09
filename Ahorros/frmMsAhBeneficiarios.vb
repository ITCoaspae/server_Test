Public Class frmMsAhBeneficiarios
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents cbParen As ComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombres As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtApe1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtApellido2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtApe3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblPorcentaje As MetroFramework.Controls.MetroLabel
    Dim asociados As New wrAsociados.wsLibAsoc

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents nUpDBenef As System.Windows.Forms.NumericUpDown
    Friend WithEvents cbDoc As System.Windows.Forms.ComboBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbParen = New System.Windows.Forms.ComboBox()
        Me.cbDoc = New System.Windows.Forms.ComboBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.nUpDBenef = New System.Windows.Forms.NumericUpDown()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombres = New MetroFramework.Controls.MetroTextBox()
        Me.txtApe1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtApellido2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtApe3 = New MetroFramework.Controls.MetroTextBox()
        Me.lblPorcentaje = New MetroFramework.Controls.MetroLabel()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nUpDBenef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbParen
        '
        Me.cbParen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbParen.FormattingEnabled = True
        Me.cbParen.Location = New System.Drawing.Point(165, 183)
        Me.cbParen.Name = "cbParen"
        Me.cbParen.Size = New System.Drawing.Size(559, 24)
        Me.cbParen.TabIndex = 23
        '
        'cbDoc
        '
        Me.cbDoc.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDoc.Items.AddRange(New Object() {"DUI", "NIT", "No. Licencia", "No. Residente", "No. Pasaporte", "Partida de Nacimiento"})
        Me.cbDoc.Location = New System.Drawing.Point(165, 63)
        Me.cbDoc.Name = "cbDoc"
        Me.cbDoc.Size = New System.Drawing.Size(213, 24)
        Me.cbDoc.TabIndex = 1
        '
        'txtDui
        '
        Me.txtDui.Location = New System.Drawing.Point(511, 63)
        Me.txtDui.MaxLength = 20
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(213, 21)
        Me.txtDui.TabIndex = 3
        Me.txtDui.Tag = Nothing
        '
        'nUpDBenef
        '
        Me.nUpDBenef.DecimalPlaces = 2
        Me.nUpDBenef.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nUpDBenef.Location = New System.Drawing.Point(165, 213)
        Me.nUpDBenef.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nUpDBenef.Name = "nUpDBenef"
        Me.nUpDBenef.Size = New System.Drawing.Size(213, 22)
        Me.nUpDBenef.TabIndex = 25
        Me.nUpDBenef.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(634, 213)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(136, 20)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Tipo de Documento:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(384, 60)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(111, 20)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "No. Documento:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 94)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(70, 20)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Nombres:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 123)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(107, 20)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "Primer Apellido:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(384, 123)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(121, 20)
        Me.MetroLabel5.TabIndex = 6
        Me.MetroLabel5.Text = "Segundo Apellido:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(23, 152)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(110, 20)
        Me.MetroLabel6.TabIndex = 7
        Me.MetroLabel6.Text = "Apellido Casada:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(23, 183)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(80, 20)
        Me.MetroLabel7.TabIndex = 8
        Me.MetroLabel7.Text = "Parentesco:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(24, 213)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(69, 20)
        Me.MetroLabel8.TabIndex = 9
        Me.MetroLabel8.Text = "Beneficio:"
        '
        'txtNombres
        '
        '
        '
        '
        Me.txtNombres.CustomButton.Image = Nothing
        Me.txtNombres.CustomButton.Location = New System.Drawing.Point(537, 1)
        Me.txtNombres.CustomButton.Name = ""
        Me.txtNombres.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombres.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombres.CustomButton.TabIndex = 1
        Me.txtNombres.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombres.CustomButton.UseSelectable = True
        Me.txtNombres.CustomButton.Visible = False
        Me.txtNombres.Lines = New String(-1) {}
        Me.txtNombres.Location = New System.Drawing.Point(165, 94)
        Me.txtNombres.MaxLength = 32767
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombres.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombres.SelectedText = ""
        Me.txtNombres.SelectionLength = 0
        Me.txtNombres.SelectionStart = 0
        Me.txtNombres.ShortcutsEnabled = True
        Me.txtNombres.Size = New System.Drawing.Size(559, 23)
        Me.txtNombres.TabIndex = 10
        Me.txtNombres.UseSelectable = True
        Me.txtNombres.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombres.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtApe1
        '
        '
        '
        '
        Me.txtApe1.CustomButton.Image = Nothing
        Me.txtApe1.CustomButton.Location = New System.Drawing.Point(191, 1)
        Me.txtApe1.CustomButton.Name = ""
        Me.txtApe1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtApe1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtApe1.CustomButton.TabIndex = 1
        Me.txtApe1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtApe1.CustomButton.UseSelectable = True
        Me.txtApe1.CustomButton.Visible = False
        Me.txtApe1.Lines = New String(-1) {}
        Me.txtApe1.Location = New System.Drawing.Point(165, 123)
        Me.txtApe1.MaxLength = 32767
        Me.txtApe1.Name = "txtApe1"
        Me.txtApe1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApe1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtApe1.SelectedText = ""
        Me.txtApe1.SelectionLength = 0
        Me.txtApe1.SelectionStart = 0
        Me.txtApe1.ShortcutsEnabled = True
        Me.txtApe1.Size = New System.Drawing.Size(213, 23)
        Me.txtApe1.TabIndex = 11
        Me.txtApe1.UseSelectable = True
        Me.txtApe1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtApe1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtApellido2
        '
        '
        '
        '
        Me.txtApellido2.CustomButton.Image = Nothing
        Me.txtApellido2.CustomButton.Location = New System.Drawing.Point(191, 1)
        Me.txtApellido2.CustomButton.Name = ""
        Me.txtApellido2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtApellido2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtApellido2.CustomButton.TabIndex = 1
        Me.txtApellido2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtApellido2.CustomButton.UseSelectable = True
        Me.txtApellido2.CustomButton.Visible = False
        Me.txtApellido2.Lines = New String(-1) {}
        Me.txtApellido2.Location = New System.Drawing.Point(511, 123)
        Me.txtApellido2.MaxLength = 32767
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApellido2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtApellido2.SelectedText = ""
        Me.txtApellido2.SelectionLength = 0
        Me.txtApellido2.SelectionStart = 0
        Me.txtApellido2.ShortcutsEnabled = True
        Me.txtApellido2.Size = New System.Drawing.Size(213, 23)
        Me.txtApellido2.TabIndex = 12
        Me.txtApellido2.UseSelectable = True
        Me.txtApellido2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtApellido2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtApe3
        '
        '
        '
        '
        Me.txtApe3.CustomButton.Image = Nothing
        Me.txtApe3.CustomButton.Location = New System.Drawing.Point(191, 1)
        Me.txtApe3.CustomButton.Name = ""
        Me.txtApe3.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtApe3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtApe3.CustomButton.TabIndex = 1
        Me.txtApe3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtApe3.CustomButton.UseSelectable = True
        Me.txtApe3.CustomButton.Visible = False
        Me.txtApe3.Lines = New String(-1) {}
        Me.txtApe3.Location = New System.Drawing.Point(165, 152)
        Me.txtApe3.MaxLength = 32767
        Me.txtApe3.Name = "txtApe3"
        Me.txtApe3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtApe3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtApe3.SelectedText = ""
        Me.txtApe3.SelectionLength = 0
        Me.txtApe3.SelectionStart = 0
        Me.txtApe3.ShortcutsEnabled = True
        Me.txtApe3.Size = New System.Drawing.Size(213, 23)
        Me.txtApe3.TabIndex = 13
        Me.txtApe3.UseSelectable = True
        Me.txtApe3.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtApe3.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.AutoSize = True
        Me.lblPorcentaje.Location = New System.Drawing.Point(384, 215)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(0, 0)
        Me.lblPorcentaje.TabIndex = 28
        '
        'frmMsAhBeneficiarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(755, 292)
        Me.Controls.Add(Me.lblPorcentaje)
        Me.Controls.Add(Me.cbParen)
        Me.Controls.Add(Me.txtApe3)
        Me.Controls.Add(Me.txtApellido2)
        Me.Controls.Add(Me.txtApe1)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.nUpDBenef)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.cbDoc)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Name = "frmMsAhBeneficiarios"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Beneficiarios"
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nUpDBenef, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox

    Public pNoCuenta As String, pCodTipoAhorro As String, pAccion As String, pCorrelativo As Long
    Public Sub llenarParentesco()
        Dim dts As New DataSet
        dts = asociados.ConsultarParentescos("codParentesco,descripcion", "", " descripcion ", sUsuario, sPassword, sSucursal)
        cbParen.DisplayMember = "Descripcion"
        cbParen.ValueMember = "codParentesco"
        Me.cbParen.DataSource = dts.Tables(0)
    End Sub

    Private Sub frmMsAhBeneficiarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim ds As New Data.DataSet, objRow As Data.DataRow, vPorcent As Double, oAsoc As New wrAsociados.wsLibAsoc
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, x As Integer
            Dim Filas As Data.DataRowCollection

            Me.txtNombres.Focus()
            Me.cbDoc.SelectedIndex = 0

            'llenarEstadoCivil()
            ds = oAhorro.ConsultarBeneficiarios("Porcentaje,Correlativo", " NoCuenta='" & pNoCuenta & "'", "DuiBeneficiario", sUsuario, sPassword, sSucursal)
            For Each objRow In ds.Tables(0).Rows
                vPorcent = vPorcent + CDbl(objRow("Porcentaje"))
            Next
            Me.lblPorcentaje.Text = "Porcentaje disponible: " & CDbl(100 - vPorcent) & "%"

            Dim dsTemp As New DataSet, drTemp As DataRow
            dsTemp = oAsoc.ConsultarParentescos("*", "", "CodParentesco", sUsuario, sPassword, sSucursal)
            llenarParentesco()



            If Me.btnGuardar1.Text = "&Modificar" Then

                ds = oAhorro.ConsultarBeneficiarios("*", "Correlativo=" & pCorrelativo & "", "DuiBeneficiario", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtDui.Value = IIf(Filas.Item(0)("DuiBeneficiario") Is DBNull.Value, " ", Filas.Item(0)("DuiBeneficiario").ToString.ToUpper)
                    txtNombres.Text = IIf(Filas.Item(0)("Nombres") Is DBNull.Value, " ", Filas.Item(0)("Nombres").ToString.ToUpper)
                    txtApe1.Text = IIf(Filas.Item(0)("Apellido1") Is DBNull.Value, " ", Filas.Item(0)("Apellido1").ToString.ToUpper)
                    txtApellido2.Text = IIf(Filas.Item(0)("Apellido2") Is DBNull.Value, " ", Filas.Item(0)("Apellido2").ToString.ToUpper)
                    Me.txtApe3.Text = IIf(IsDBNull(Filas.Item(0)("ApellidoCas")), 0, Filas.Item(0)("ApellidoCas").ToString.ToUpper)
                    cbParen.SelectedValue = IIf(IsDBNull(Filas.Item(0)("CodParentesco")), "20", Filas.Item(0)("CodParentesco"))
                    nUpDBenef.Value = CDbl(Filas.Item(0)("Porcentaje"))
                    cbDoc.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("TipoDoc")), 0, Filas.Item(0)("TipoDoc"))
                End If

            Else
                Me.nUpDBenef.Maximum = 100 - vPorcent
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub nUpDBenef_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nUpDBenef.GotFocus
        Me.nUpDBenef.Select(0, Len(Me.nUpDBenef.Value))
    End Sub

    Private Sub nUpDBenef_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles nUpDBenef.Validating
        If Me.nUpDBenef.Value > 100 Then e.Cancel = True
    End Sub





    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click

        Try
            Dim oAsoc As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, pCampos As String, pValores As String
            Select Case oAsoc.AutorizaDatos(IIf(IsDBNull(Me.txtDui.Value), "", Me.txtDui.Value), txtApe1.Text, txtNombres.Text, "x", "x")
                'Case 1
                '    MsgBox("El campo Dui del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                '    Exit Sub
                Case 2
                    MsgBox("El campo Apellido del Beneficiario no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
                Case 3
                    MsgBox("El campo Nombres del Beneficiario no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
            End Select

            If Me.nUpDBenef.Value = 0 Then
                MsgBox("El porcentaje de beneficio no puede ser cero.", MsgBoxStyle.OkOnly, "Módulo Ahorros")
                Exit Sub
            End If

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "Correlativo,DuiBeneficiario,CodTipoAhorro,NoCuenta,TipoDoc,Nombres,Apellido1,Apellido2,ApellidoCas,CodParentesco,Porcentaje"
                pValores = "" & oAsoc.ObtenerCorrelativoBeneficiarios("Correlativo", sUsuario, sPassword, sSucursal) &
                    ",'" & IIf(txtDui.Value.ToString.Trim.Length = 0, " ", txtDui.Value.ToString.Trim) &
                    "','" & Me.pCodTipoAhorro & "','" & Me.pNoCuenta & "','" & cbDoc.SelectedIndex &
                    "','" & txtNombres.Text.ToUpper.Trim & "','" & txtApe1.Text.Trim.ToUpper & "','" & txtApellido2.Text.Trim.ToUpper & "','" & txtApe3.Text.Trim.ToUpper & "','" & cbParen.SelectedValue & "','" & nUpDBenef.Value & "'"
                If oAsoc.InsertarBeneficiarios(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                Else
                    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "DuiBeneficiario='" & Trim(Me.txtDui.Value) & "',Apellido1='" & Trim(txtApe1.Text) & "',Apellido2='" & Trim(Me.txtApellido2.Text) & "',ApellidoCas='" & Trim(Me.txtApe3.Text) & "',Nombres='" & Trim(Me.txtNombres.Text) & "',CodParentesco='" & Me.cbParen.SelectedValue & "',Porcentaje='" & nUpDBenef.Value & "',TipoDoc='" & Me.cbDoc.SelectedIndex & "' "
                If oAsoc.ModificarBeneficiarios("Correlativo=" & pCorrelativo & "", pCampos, sUsuario, sPassword, sSucursal) = True Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeUpdateRegistro, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub cbEstadoCivil_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.cbEstadoCivil.SelectedIndex = 1 Then
    '        Me.txtApe3.ReadOnly = False
    '    Else
    '        Me.txtApe3.ReadOnly = True
    '        Me.txtApe3.Text = ""
    '    End If
    'End Sub

    Private Sub txtDui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.Click
        Try
            Dim Valor As String
            Valor = IIf(txtDui.ValueIsDbNull, "", txtDui.Value)
            If Valor.Trim = "" Then
                Me.txtDui.SelectionStart = 0
                Me.txtDui.SelectionLength = 0
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsAhBeneficiarios_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
