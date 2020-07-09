Public Class frmMsCrRefCom
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
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefonos As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTelefonos = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.txtEmpresa = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(26, 203)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNombre.Size = New System.Drawing.Size(523, 81)
        Me.txtNombre.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 16)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "Nombre de persona que dió la referencia / Observaciones:"
        '
        'txtTelefonos
        '
        Me.txtTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefonos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonos.Location = New System.Drawing.Point(125, 86)
        Me.txtTelefonos.MaxLength = 40
        Me.txtTelefonos.Name = "txtTelefonos"
        Me.txtTelefonos.Size = New System.Drawing.Size(152, 20)
        Me.txtTelefonos.TabIndex = 1
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Black
        Me.Label65.Location = New System.Drawing.Point(23, 90)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(64, 16)
        Me.Label65.TabIndex = 132
        Me.Label65.Text = "Teléfonos:"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmpresa
        '
        Me.txtEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpresa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresa.Location = New System.Drawing.Point(125, 58)
        Me.txtEmpresa.MaxLength = 50
        Me.txtEmpresa.Name = "txtEmpresa"
        Me.txtEmpresa.Size = New System.Drawing.Size(424, 20)
        Me.txtEmpresa.TabIndex = 0
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.Black
        Me.Label67.Location = New System.Drawing.Point(23, 60)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(96, 16)
        Me.Label67.TabIndex = 128
        Me.Label67.Text = "Nombre Empresa:"
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(125, 112)
        Me.txtDireccion.MaxLength = 255
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(424, 69)
        Me.txtDireccion.TabIndex = 2
        '
        'Label68
        '
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.Black
        Me.Label68.Location = New System.Drawing.Point(23, 111)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(56, 16)
        Me.Label68.TabIndex = 130
        Me.Label68.Text = "Dirección:"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(474, 290)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 218
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCrRefCom
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(585, 351)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTelefonos)
        Me.Controls.Add(Me.Label68)
        Me.Controls.Add(Me.Label65)
        Me.Controls.Add(Me.Label67)
        Me.Controls.Add(Me.txtEmpresa)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(585, 351)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(585, 351)
        Me.Name = "frmMsCrRefCom"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Referencia Comercial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String

            Select Case oCred.AutorizarDatos(Trim(Me.txtEmpresa.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El Nombre de la Empresa no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCorrelativo = oCred.ObtenerCorrelativoRefComercial("Correlativo", sUsuario, sPassword, sSucursal)
                pCampos = "Correlativo,NumSolicitud,NombreEmpresa,Nombre,Direccion,Telefonos,CodEnlace"
                pValores = "" & pCorrelativo & "," & pNoSolic & ",'" & Trim(Me.txtEmpresa.Text) & "','" & Trim(Me.txtNombre.Text) & "','" & Trim(Me.txtDireccion.Text) & "','" & Trim(Me.txtTelefonos.Text) & "'," & pCodEnlace & ""
                If oCred.InsertarRefComercial(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("La Referencia Comercial NO ha sido agregada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "NombreEmpresa='" & Trim(Me.txtEmpresa.Text) & "',Nombre='" & Trim(Me.txtNombre.Text) & "',Direccion='" & Trim(Me.txtDireccion.Text) & "',Telefonos='" & Trim(Me.txtTelefonos.Text) & "'"
                If oCred.ModificarRefComercial(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("La Referencia no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region



    Private Sub frmMsCrRefCom_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection

            If Me.pAccion = "Modificar" Then

                ds = oCred.ConsultarRefComercial("*", "Correlativo='" & pCorrelativo & "'", "Correlativo", sUsuario, sPassword,sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtEmpresa.Text = IIf(IsDBNull(Filas.Item(0)("NombreEmpresa")), "", Filas.Item(0)("NombreEmpresa"))
                    Me.txtNombre.Text = IIf(IsDBNull(Filas.Item(0)("Nombre")), "", Filas.Item(0)("Nombre"))
                    Me.txtDireccion.Text = IIf(IsDBNull(Filas.Item(0)("Direccion")), "", Filas.Item(0)("Direccion"))
                    Me.txtTelefonos.Text = IIf(IsDBNull(Filas.Item(0)("Telefonos")), "", Filas.Item(0)("Telefonos"))
                End If

            End If
            Me.txtEmpresa.Focus()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub txtTelefonos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelefonos.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnGuardar1_Click(sender, e)
        End If
    End Sub

End Class
