Public Class frmMsSucursales
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Dim asociados As New wrAsociados.wsLibAsoc
    Public pCodigo As String, pAccion As String
    Friend WithEvents cbcc As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cbDeptoSucursal As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label48 As Label
    Friend WithEvents cbMunSucursal As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label49 As Label
    Dim contabilidad As New wrConta.wsLibContab

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
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.cbcc = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbDeptoSucursal = New MetroFramework.Controls.MetroComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.cbMunSucursal = New MetroFramework.Controls.MetroComboBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(371, 257)
        Me.txtFax.MaxLength = 100
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(173, 22)
        Me.txtFax.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(315, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 19)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Fax:"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(136, 257)
        Me.txtTel.MaxLength = 100
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(173, 22)
        Me.txtTel.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(28, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 19)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "Teléfonos:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(136, 205)
        Me.txtDireccion.MaxLength = 255
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(408, 46)
        Me.txtDireccion.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(28, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 18)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Dirección:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(136, 99)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(408, 22)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(136, 69)
        Me.txtCodigo.MaxLength = 2
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(173, 22)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(28, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(28, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 19)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Código:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(454, 315)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 33)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 173
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'cbcc
        '
        Me.cbcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbcc.FormattingEnabled = True
        Me.cbcc.Location = New System.Drawing.Point(136, 285)
        Me.cbcc.Name = "cbcc"
        Me.cbcc.Size = New System.Drawing.Size(408, 24)
        Me.cbcc.TabIndex = 174
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(28, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 37)
        Me.Label6.TabIndex = 175
        Me.Label6.Text = "Centro de Costo:"
        '
        'cbDeptoSucursal
        '
        Me.cbDeptoSucursal.FormattingEnabled = True
        Me.cbDeptoSucursal.ItemHeight = 24
        Me.cbDeptoSucursal.Location = New System.Drawing.Point(136, 133)
        Me.cbDeptoSucursal.Name = "cbDeptoSucursal"
        Me.cbDeptoSucursal.Size = New System.Drawing.Size(408, 30)
        Me.cbDeptoSucursal.TabIndex = 179
        Me.cbDeptoSucursal.UseSelectable = True
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.BackColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(28, 133)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(102, 17)
        Me.Label48.TabIndex = 178
        Me.Label48.Text = "Departamento:"
        '
        'cbMunSucursal
        '
        Me.cbMunSucursal.FormattingEnabled = True
        Me.cbMunSucursal.ItemHeight = 24
        Me.cbMunSucursal.Location = New System.Drawing.Point(136, 169)
        Me.cbMunSucursal.Name = "cbMunSucursal"
        Me.cbMunSucursal.Size = New System.Drawing.Size(408, 30)
        Me.cbMunSucursal.TabIndex = 177
        Me.cbMunSucursal.UseSelectable = True
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.BackColor = System.Drawing.Color.White
        Me.Label49.Location = New System.Drawing.Point(28, 169)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(71, 17)
        Me.Label49.TabIndex = 176
        Me.Label49.Text = "Municipio:"
        '
        'frmMsSucursales
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(581, 416)
        Me.Controls.Add(Me.cbDeptoSucursal)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.cbMunSucursal)
        Me.Controls.Add(Me.Label49)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbcc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFax)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsSucursales"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Sucursales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub llenarDepartamentoSucursal()
        Dim dts As New DataSet
        dts = asociados.ConsultarDepartamentos("CodDepartamento,Departamento", "", "Departamento", sUsuario, sPassword, sSucursal)
        Me.cbDeptoSucursal.DataSource = dts.Tables(0)
        Me.cbDeptoSucursal.DisplayMember = "Departamento"
        Me.cbDeptoSucursal.ValueMember = "CodDepartamento"
    End Sub
    Private Sub llenarMunicipioSucursal(codDepartamento)
        Dim dts As New DataSet
        dts = asociados.ConsultarMunicipios("codMunicipio,Municipio", " codDepartamento = '" & codDepartamento & "' ", "Municipio", sUsuario, sPassword, sSucursal)
        Me.cbMunSucursal.DataSource = dts.Tables(0)
        Me.cbMunSucursal.DisplayMember = "Municipio"
        Me.cbMunSucursal.ValueMember = "codMunicipio"
    End Sub
    Public Sub llenarCbCostos()
        Dim dts As New DataSet
        dts = contabilidad.ObtenerCatCostos(wrConta.TiposCatalogo.Costos, "*", "", "Cod_CCosto", sUsuario, sPassword, sSucursal)
        If dts.Tables(0).Rows.Count > 0 Then
            Me.cbcc.DisplayMember = "descripcion"
            Me.cbcc.ValueMember = "cod_Ccosto"
            Me.cbcc.DataSource = dts.Tables(0)
        End If
    End Sub
    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String

            Select Case oAsoc.AutorizaDatos(Trim(txtCodigo.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El Código de la Sucursal no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Sucursales")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "CodSucursal,Nom_Sucursal,Direccion,Telefonos,Fax,cod_ccosto,codDepartamento,codMunicipio"
                pValores = "'" & Trim(txtCodigo.Text) & "','" & Trim(txtDescripcion.Text) & "','" & Me.txtDireccion.Text.Trim & "','" & Me.txtTel.Text.Trim & "','" & Me.txtFax.Text.Trim & "', '" & Me.cbcc.SelectedValue & "', '" & Me.cbDeptoSucursal.SelectedValue & "', '" & Me.cbMunSucursal.SelectedValue & "' "
                If oAsoc.InsertarSucursales(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("La Sucursal NO ha sido agregada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Sucursales")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Nom_Sucursal='" & Trim(txtDescripcion.Text) & "',Direccion='" & Me.txtDireccion.Text.Trim & "',Telefonos='" & Me.txtTel.Text.Trim & "',Fax='" & Me.txtFax.Text.Trim & "', cod_Ccosto = '" & Me.cbcc.SelectedValue & "', codDepartamento = '" & Me.cbDeptoSucursal.SelectedValue & "', codMunicipio = '" & Me.cbMunSucursal.SelectedValue & "' "
                If oAsoc.ModificarSucursales("CodSucursal='" & Trim(pCodigo) & "'", pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("La Sucursal no ha sido modificada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Sucursales")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsSucursales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        llenarCbCostos()
        llenarDepartamentoSucursal()

        If Me.pAccion = "Modificar" Then

            ds = oAsoc.ConsultarSucursales("*", "CodSucursal='" & pCodigo & "'", "CodSucursal", sUsuario, sPassword, sSucursal)

            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtCodigo.Text = pCodigo
                txtCodigo.Enabled = False
                txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Nom_Sucursal")), "", Filas.Item(0)("Nom_Sucursal"))
                txtDireccion.Text = IIf(IsDBNull(Filas.Item(0)("Direccion")), "", Filas.Item(0)("Direccion"))
                txtTel.Text = IIf(IsDBNull(Filas.Item(0)("Telefonos")), "", Filas.Item(0)("Telefonos"))
                txtFax.Text = IIf(IsDBNull(Filas.Item(0)("Fax")), "", Filas.Item(0)("Fax"))
                cbcc.SelectedValue = IIf(IsDBNull(Filas.Item(0)("cod_ccosto")), "0", Filas.Item(0)("cod_Ccosto"))
                cbDeptoSucursal.SelectedValue = IIf(IsDBNull(Filas.Item(0)("codDepartamento")), "0", Filas.Item(0)("codDepartamento"))
                llenarMunicipioSucursal(cbDeptoSucursal.SelectedValue)
                cbMunSucursal.SelectedValue = IIf(IsDBNull(Filas.Item(0)("codMunicipio")), "0", Filas.Item(0)("codMunicipio"))
            End If

        End If
        txtCodigo.Focus()
    End Sub

    Private Sub cbDeptoSucursal_Validated(sender As Object, e As EventArgs) Handles cbDeptoSucursal.Validated
        llenarMunicipioSucursal(cbDeptoSucursal.SelectedValue)
    End Sub
End Class
