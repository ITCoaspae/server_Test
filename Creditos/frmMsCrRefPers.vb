Public Class frmMsCrRefPers
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
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents txtTelCasa As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDirTrab As System.Windows.Forms.TextBox
    Friend WithEvents txtTelOfic As System.Windows.Forms.TextBox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents txtLugarTrabajo As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido3 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String

            Select Case oCred.AutorizarDatos(Trim(Me.txtNombres.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El Nombre de la Referencia no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCorrelativo = oCred.ObtenerCorrelativoRefPersonal("Correlativo", sUsuario, sPassword, sSucursal)
                pCampos = "Correlativo,NumSolicitud,Nombre,Direccion,TelCasa,LugarTrabajo,DireccionTrabajo,Cargo,TelOficina,CodEnlace,Apellido1,Apellido2,Apellido3"
                pValores = "" & pCorrelativo & "," & pNoSolic & ",'" & Trim(Me.txtNombres.Text) & "','" & Trim(Me.txtDireccion.Text) & "','" & Trim(Me.txtTelCasa.Text) & "','" & Trim(Me.txtLugarTrabajo.Text) & "','" & Trim(Me.txtDirTrab.Text) & "','" & Trim(Me.txtCargo.Text) & "','" & Trim(Me.txtTelOfic.Text) & "'," & pCodEnlace & ",'" & Me.txtApellido1.Text.Trim & "','" & Me.txtApellido2.Text.Trim & "','" & Me.txtApellido3.Text.Trim & "'"
                If oCred.InsertarRefPersonal(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("La Referencia Personal NO ha sido agregada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Nombre='" & Trim(Me.txtNombres.Text) & "',Direccion='" & Trim(Me.txtDireccion.Text) & "',TelCasa='" & Trim(Me.txtTelCasa.Text) & "',LugarTrabajo='" & Trim(Me.txtLugarTrabajo.Text) & "',DireccionTrabajo='" & Trim(Me.txtDirTrab.Text) & "',Cargo='" & Trim(Me.txtCargo.Text) & "',TelOficina='" & Trim(Me.txtTelOfic.Text) & "',Apellido1='" & Me.txtApellido1.Text.Trim & "',Apellido2='" & Me.txtApellido2.Text.Trim & "',Apellido3='" & Me.txtApellido3.Text.Trim & "'"
                If oCred.ModificarRefPersonal(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("La Referencia no ha sido modificada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtApellido3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDirTrab = New System.Windows.Forms.TextBox()
        Me.txtTelOfic = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.txtLugarTrabajo = New System.Windows.Forms.TextBox()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTelCasa = New System.Windows.Forms.TextBox()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtApellido3
        '
        Me.txtApellido3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido3.Location = New System.Drawing.Point(409, 84)
        Me.txtApellido3.MaxLength = 25
        Me.txtApellido3.Name = "txtApellido3"
        Me.txtApellido3.Size = New System.Drawing.Size(160, 20)
        Me.txtApellido3.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(299, 86)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 170
        Me.Label7.Text = "Apellido 3:"
        '
        'txtCargo
        '
        Me.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCargo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.Location = New System.Drawing.Point(133, 214)
        Me.txtCargo.MaxLength = 100
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(160, 20)
        Me.txtCargo.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "Cargo:"
        '
        'txtDirTrab
        '
        Me.txtDirTrab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDirTrab.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirTrab.Location = New System.Drawing.Point(133, 188)
        Me.txtDirTrab.MaxLength = 255
        Me.txtDirTrab.Name = "txtDirTrab"
        Me.txtDirTrab.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDirTrab.Size = New System.Drawing.Size(436, 20)
        Me.txtDirTrab.TabIndex = 7
        '
        'txtTelOfic
        '
        Me.txtTelOfic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelOfic.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelOfic.Location = New System.Drawing.Point(409, 214)
        Me.txtTelOfic.MaxLength = 40
        Me.txtTelOfic.Name = "txtTelOfic"
        Me.txtTelOfic.Size = New System.Drawing.Size(160, 20)
        Me.txtTelOfic.TabIndex = 9
        '
        'Label69
        '
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Black
        Me.Label69.Location = New System.Drawing.Point(299, 214)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(112, 16)
        Me.Label69.TabIndex = 166
        Me.Label69.Text = "Teléfono de Oficina:"
        Me.Label69.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label70
        '
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.Black
        Me.Label70.Location = New System.Drawing.Point(23, 185)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(111, 16)
        Me.Label70.TabIndex = 167
        Me.Label70.Text = "Dirección del Trabajo:"
        Me.Label70.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label71
        '
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.Black
        Me.Label71.Location = New System.Drawing.Point(23, 163)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(96, 16)
        Me.Label71.TabIndex = 165
        Me.Label71.Text = "Lugar de trabajo:"
        '
        'txtLugarTrabajo
        '
        Me.txtLugarTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLugarTrabajo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLugarTrabajo.Location = New System.Drawing.Point(133, 162)
        Me.txtLugarTrabajo.MaxLength = 255
        Me.txtLugarTrabajo.Name = "txtLugarTrabajo"
        Me.txtLugarTrabajo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLugarTrabajo.Size = New System.Drawing.Size(436, 20)
        Me.txtLugarTrabajo.TabIndex = 6
        '
        'txtApellido2
        '
        Me.txtApellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido2.Location = New System.Drawing.Point(133, 84)
        Me.txtApellido2.MaxLength = 25
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(160, 20)
        Me.txtApellido2.TabIndex = 2
        '
        'txtApellido1
        '
        Me.txtApellido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido1.Location = New System.Drawing.Point(409, 58)
        Me.txtApellido1.MaxLength = 25
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(160, 20)
        Me.txtApellido1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(23, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 160
        Me.Label6.Text = "Apellido 2:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(299, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 159
        Me.Label5.Text = "Apellido 1:"
        '
        'txtTelCasa
        '
        Me.txtTelCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelCasa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelCasa.Location = New System.Drawing.Point(133, 110)
        Me.txtTelCasa.MaxLength = 40
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.Size = New System.Drawing.Size(160, 20)
        Me.txtTelCasa.TabIndex = 4
        '
        'Label72
        '
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.Black
        Me.Label72.Location = New System.Drawing.Point(23, 110)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(88, 16)
        Me.Label72.TabIndex = 132
        Me.Label72.Text = "Teléfono Casa:"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombres.Location = New System.Drawing.Point(133, 58)
        Me.txtNombres.MaxLength = 50
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(160, 20)
        Me.txtNombres.TabIndex = 0
        '
        'Label73
        '
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.Black
        Me.Label73.Location = New System.Drawing.Point(23, 60)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(104, 16)
        Me.Label73.TabIndex = 128
        Me.Label73.Text = "Nombres:"
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(133, 136)
        Me.txtDireccion.MaxLength = 255
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(436, 20)
        Me.txtDireccion.TabIndex = 5
        '
        'Label74
        '
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.Black
        Me.Label74.Location = New System.Drawing.Point(23, 136)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(56, 16)
        Me.Label74.TabIndex = 130
        Me.Label74.Text = "Dirección:"
        Me.Label74.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(494, 240)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 220
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCrRefPers
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(595, 301)
        Me.Controls.Add(Me.txtTelOfic)
        Me.Controls.Add(Me.txtCargo)
        Me.Controls.Add(Me.Label69)
        Me.Controls.Add(Me.txtApellido3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtDirTrab)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label73)
        Me.Controls.Add(Me.Label70)
        Me.Controls.Add(Me.txtNombres)
        Me.Controls.Add(Me.txtLugarTrabajo)
        Me.Controls.Add(Me.Label71)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtApellido1)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.Label74)
        Me.Controls.Add(Me.txtTelCasa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtApellido2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(595, 301)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(595, 301)
        Me.Name = "frmMsCrRefPers"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Referencia Personal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub frmMsCrRefPers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection

            If Me.pAccion = "Modificar" Then

                ds = oCred.ConsultarRefPersonal("*", "Correlativo='" & pCorrelativo & "'", "Correlativo", sUsuario, sPassword,sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtNombres.Text = IIf(IsDBNull(Filas.Item(0)("Nombre")), "", Filas.Item(0)("Nombre"))
                    Me.txtDireccion.Text = IIf(IsDBNull(Filas.Item(0)("Direccion")), "", Filas.Item(0)("Direccion"))
                    Me.txtTelCasa.Text = IIf(IsDBNull(Filas.Item(0)("TelCasa")), "", Filas.Item(0)("TelCasa"))
                    Me.txtLugarTrabajo.Text = IIf(IsDBNull(Filas.Item(0)("LugarTrabajo")), "", Filas.Item(0)("LugarTrabajo"))
                    Me.txtDirTrab.Text = IIf(IsDBNull(Filas.Item(0)("DireccionTrabajo")), "", Filas.Item(0)("DireccionTrabajo"))
                    Me.txtCargo.Text = IIf(IsDBNull(Filas.Item(0)("Cargo")), "", Filas.Item(0)("Cargo"))
                    Me.txtTelOfic.Text = IIf(IsDBNull(Filas.Item(0)("TelOficina")), "", Filas.Item(0)("TelOficina"))
                    Me.txtApellido1.Text = IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1"))
                    Me.txtApellido2.Text = IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                    Me.txtApellido3.Text = IIf(IsDBNull(Filas.Item(0)("Apellido3")), "", Filas.Item(0)("Apellido3"))
                End If

            End If
            txtNombres.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



End Class
