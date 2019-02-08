Public Class frmMsUsuarios
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtConfirmarClave As System.Windows.Forms.TextBox
    Friend WithEvents txtCodSuc As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtConfirmarClave = New System.Windows.Forms.TextBox()
        Me.txtCodSuc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Location = New System.Drawing.Point(112, 58)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(152, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Usuario:"
        '
        'txtClave
        '
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClave.Location = New System.Drawing.Point(112, 84)
        Me.txtClave.MaxLength = 20
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(152, 20)
        Me.txtClave.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Clave:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 26)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Fecha Válido " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "desde:"
        '
        'dtpFecDesde
        '
        Me.dtpFecDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecDesde.Location = New System.Drawing.Point(112, 136)
        Me.dtpFecDesde.Name = "dtpFecDesde"
        Me.dtpFecDesde.Size = New System.Drawing.Size(152, 20)
        Me.dtpFecDesde.TabIndex = 5
        '
        'dtpFecHasta
        '
        Me.dtpFecHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecHasta.Location = New System.Drawing.Point(368, 136)
        Me.dtpFecHasta.Name = "dtpFecHasta"
        Me.dtpFecHasta.Size = New System.Drawing.Size(152, 20)
        Me.dtpFecHasta.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(270, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 26)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "Fecha Válido " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hasta:"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(112, 110)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(408, 20)
        Me.txtNombre.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(23, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(270, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 16)
        Me.Label6.TabIndex = 107
        Me.Label6.Text = "Confirmar Clave:"
        '
        'txtConfirmarClave
        '
        Me.txtConfirmarClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConfirmarClave.Location = New System.Drawing.Point(368, 82)
        Me.txtConfirmarClave.MaxLength = 20
        Me.txtConfirmarClave.Name = "txtConfirmarClave"
        Me.txtConfirmarClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmarClave.Size = New System.Drawing.Size(152, 20)
        Me.txtConfirmarClave.TabIndex = 3
        '
        'txtCodSuc
        '
        Me.txtCodSuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodSuc.Location = New System.Drawing.Point(368, 56)
        Me.txtCodSuc.MaxLength = 10
        Me.txtCodSuc.Name = "txtCodSuc"
        Me.txtCodSuc.Size = New System.Drawing.Size(152, 20)
        Me.txtCodSuc.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(270, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 16)
        Me.Label7.TabIndex = 139
        Me.Label7.Text = "Cód. Agencia:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(445, 174)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1011
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsUsuarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(545, 239)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtCodSuc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtConfirmarClave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dtpFecHasta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFecDesde)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(545, 239)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(545, 239)
        Me.Name = "frmMsUsuarios"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub txtCodSuc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodSuc.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Sucursales"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            ds = oPerif.ConsultarSucursales("*", "", "CodSucursal", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodSuc.Text = ofrm.Resultado.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

                If oAdm.InsertarUsuario(Me.txtUsuario.Text.Trim, txtClave.Text.Trim, txtNombre.Text, dtpFecDesde.Value.ToShortDateString, dtpFecHasta.Value.ToShortDateString, Me.txtCodSuc.Text.Trim, sUsuario, sPassword, sSucursal) = True Then
                    Me.Close()
                Else
                    MessageBox.Show("El usuario no ha sido agregado, verifíque.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else

                pFiltro = "Usuario='" & txtUsuario.Text.Trim & "'"
                If oAdm.ModificarUsarios(pFiltro, txtNombre.Text.Trim, dtpFecDesde.Value.ToShortDateString, dtpFecHasta.Value.ToShortDateString, Me.txtCodSuc.Text.Trim, sUsuario, sPassword, sSucursal) Then
                    Me.Close()
                Else
                    MessageBox.Show("El Usuario no ha sido actualizado, verifíque.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub


End Class