Public Class frmMsUsuarios
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim administracion As New wrAdmin.wsLibAdmin
    Friend WithEvents txtUsuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtClave As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtConfirmarClave As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtpFecDesde As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpFecHasta As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Dim asociados As New wrAsociados.wsLibAsoc
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
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents cbSucursal As MetroFramework.Controls.MetroComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.cbSucursal = New MetroFramework.Controls.MetroComboBox()
        Me.txtUsuario = New MetroFramework.Controls.MetroTextBox()
        Me.txtClave = New MetroFramework.Controls.MetroTextBox()
        Me.txtConfirmarClave = New MetroFramework.Controls.MetroTextBox()
        Me.dtpFecDesde = New MetroFramework.Controls.MetroDateTime()
        Me.dtpFecHasta = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtNombre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(551, 266)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 14
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'cbSucursal
        '
        Me.cbSucursal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.ItemHeight = 24
        Me.cbSucursal.Location = New System.Drawing.Point(128, 230)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(513, 30)
        Me.cbSucursal.TabIndex = 3
        Me.cbSucursal.UseSelectable = True
        '
        'txtUsuario
        '
        '
        '
        '
        Me.txtUsuario.CustomButton.Image = Nothing
        Me.txtUsuario.CustomButton.Location = New System.Drawing.Point(491, 1)
        Me.txtUsuario.CustomButton.Name = ""
        Me.txtUsuario.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtUsuario.CustomButton.TabIndex = 1
        Me.txtUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtUsuario.CustomButton.UseSelectable = True
        Me.txtUsuario.CustomButton.Visible = False
        Me.txtUsuario.Lines = New String(-1) {}
        Me.txtUsuario.Location = New System.Drawing.Point(128, 71)
        Me.txtUsuario.MaxLength = 32767
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.SelectionLength = 0
        Me.txtUsuario.SelectionStart = 0
        Me.txtUsuario.ShortcutsEnabled = True
        Me.txtUsuario.Size = New System.Drawing.Size(513, 23)
        Me.txtUsuario.TabIndex = 15
        Me.txtUsuario.UseSelectable = True
        Me.txtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtUsuario.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtClave
        '
        '
        '
        '
        Me.txtClave.CustomButton.Image = Nothing
        Me.txtClave.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.txtClave.CustomButton.Name = ""
        Me.txtClave.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtClave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtClave.CustomButton.TabIndex = 1
        Me.txtClave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtClave.CustomButton.UseSelectable = True
        Me.txtClave.CustomButton.Visible = False
        Me.txtClave.Lines = New String(-1) {}
        Me.txtClave.Location = New System.Drawing.Point(128, 100)
        Me.txtClave.MaxLength = 32767
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtClave.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtClave.SelectedText = ""
        Me.txtClave.SelectionLength = 0
        Me.txtClave.SelectionStart = 0
        Me.txtClave.ShortcutsEnabled = True
        Me.txtClave.Size = New System.Drawing.Size(177, 23)
        Me.txtClave.TabIndex = 16
        Me.txtClave.UseSelectable = True
        Me.txtClave.UseSystemPasswordChar = True
        Me.txtClave.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtClave.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtConfirmarClave
        '
        '
        '
        '
        Me.txtConfirmarClave.CustomButton.Image = Nothing
        Me.txtConfirmarClave.CustomButton.Location = New System.Drawing.Point(155, 1)
        Me.txtConfirmarClave.CustomButton.Name = ""
        Me.txtConfirmarClave.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtConfirmarClave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtConfirmarClave.CustomButton.TabIndex = 1
        Me.txtConfirmarClave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtConfirmarClave.CustomButton.UseSelectable = True
        Me.txtConfirmarClave.CustomButton.Visible = False
        Me.txtConfirmarClave.Lines = New String(-1) {}
        Me.txtConfirmarClave.Location = New System.Drawing.Point(464, 100)
        Me.txtConfirmarClave.MaxLength = 32767
        Me.txtConfirmarClave.Name = "txtConfirmarClave"
        Me.txtConfirmarClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtConfirmarClave.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtConfirmarClave.SelectedText = ""
        Me.txtConfirmarClave.SelectionLength = 0
        Me.txtConfirmarClave.SelectionStart = 0
        Me.txtConfirmarClave.ShortcutsEnabled = True
        Me.txtConfirmarClave.Size = New System.Drawing.Size(177, 23)
        Me.txtConfirmarClave.TabIndex = 17
        Me.txtConfirmarClave.UseSelectable = True
        Me.txtConfirmarClave.UseSystemPasswordChar = True
        Me.txtConfirmarClave.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtConfirmarClave.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'dtpFecDesde
        '
        Me.dtpFecDesde.Location = New System.Drawing.Point(128, 158)
        Me.dtpFecDesde.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFecDesde.Name = "dtpFecDesde"
        Me.dtpFecDesde.Size = New System.Drawing.Size(513, 30)
        Me.dtpFecDesde.TabIndex = 18
        '
        'dtpFecHasta
        '
        Me.dtpFecHasta.Location = New System.Drawing.Point(128, 194)
        Me.dtpFecHasta.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFecHasta.Name = "dtpFecHasta"
        Me.dtpFecHasta.Size = New System.Drawing.Size(513, 30)
        Me.dtpFecHasta.TabIndex = 19
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(24, 71)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(59, 20)
        Me.MetroLabel1.TabIndex = 20
        Me.MetroLabel1.Text = "Usuario:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(24, 100)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(82, 20)
        Me.MetroLabel2.TabIndex = 21
        Me.MetroLabel2.Text = "Contraseña:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(311, 100)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(147, 20)
        Me.MetroLabel3.TabIndex = 22
        Me.MetroLabel3.Text = "Confirmar Contraseña:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(24, 158)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(94, 20)
        Me.MetroLabel4.TabIndex = 23
        Me.MetroLabel4.Text = "Activo Desde:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(24, 194)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(88, 20)
        Me.MetroLabel5.TabIndex = 24
        Me.MetroLabel5.Text = "Activo Hasta:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(24, 230)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(63, 20)
        Me.MetroLabel6.TabIndex = 25
        Me.MetroLabel6.Text = "Sucursal:"
        '
        'txtNombre
        '
        '
        '
        '
        Me.txtNombre.CustomButton.Image = Nothing
        Me.txtNombre.CustomButton.Location = New System.Drawing.Point(491, 1)
        Me.txtNombre.CustomButton.Name = ""
        Me.txtNombre.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNombre.CustomButton.TabIndex = 1
        Me.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNombre.CustomButton.UseSelectable = True
        Me.txtNombre.CustomButton.Visible = False
        Me.txtNombre.Lines = New String(-1) {}
        Me.txtNombre.Location = New System.Drawing.Point(128, 129)
        Me.txtNombre.MaxLength = 32767
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.SelectionLength = 0
        Me.txtNombre.SelectionStart = 0
        Me.txtNombre.ShortcutsEnabled = True
        Me.txtNombre.Size = New System.Drawing.Size(513, 23)
        Me.txtNombre.TabIndex = 26
        Me.txtNombre.UseSelectable = True
        Me.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNombre.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(24, 129)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(61, 20)
        Me.MetroLabel7.TabIndex = 27
        Me.MetroLabel7.Text = "Nombre"
        '
        'frmMsUsuarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(686, 376)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.dtpFecHasta)
        Me.Controls.Add(Me.dtpFecDesde)
        Me.Controls.Add(Me.txtConfirmarClave)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.cbSucursal)
        Me.Controls.Add(Me.btnGuardar1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(654, 276)
        Me.Name = "frmMsUsuarios"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Sub llenarSucursal()
        Dim dts As New DataSet
        dts = asociados.ConsultarSucursales("codSucursal,nom_sucursal", "", "nom_sucursal", sUsuario, sPassword, sSucursal)
        Me.cbSucursal.DisplayMember = "nom_sucursal"
        Me.cbSucursal.ValueMember = "codSucursal"
        Me.cbSucursal.DataSource = dts.Tables(0)

    End Sub
    Private Sub txtCodSuc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Sucursales"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            ds = oPerif.ConsultarSucursales("*", "", "CodSucursal", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            '  Me.txtCodSuc.Text = ofrm.Resultado.Trim
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oAdm As wrAdmin.wsLibAdmin = New wrAdmin.wsLibAdmin
            Dim pFiltro As String

            If btnGuardar1.Text = "&Guardar" Then

                If Me.txtClave.Text.Trim <> Me.txtConfirmarClave.Text.Trim Then
                    MessageBox.Show("Las claves no coinciden, verífique.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                If oAdm.InsertarUsuario(Me.txtUsuario.Text.Trim, txtClave.Text.Trim, txtNombre.Text, dtpFecDesde.Value.ToShortDateString, dtpFecHasta.Value.ToShortDateString, Me.cbSucursal.SelectedValue, sUsuario, sPassword, sSucursal) = True Then
                    Me.Close()
                Else
                    MessageBox.Show("El usuario no ha sido agregado, verifíque.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else

                pFiltro = "Usuario='" & txtUsuario.Text.Trim & "'"
                If oAdm.ModificarUsarios(pFiltro, txtNombre.Text.Trim, dtpFecDesde.Value.ToShortDateString, dtpFecHasta.Value.ToShortDateString, Me.cbSucursal.SelectedValue, sUsuario, sPassword, sSucursal) Then
                    Me.Close()
                Else
                    MessageBox.Show("El Usuario no ha sido actualizado, verifíque.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsUsuarios_Load(sender As Object, e As EventArgs) Handles Me.Load
        If btnGuardar1.Text.Equals("&Guardar") Then
            llenarSucursal()
        End If

    End Sub

    Private Sub frmMsUsuarios_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class