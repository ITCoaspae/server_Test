Public Class frmMsUsuarioporRol
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private pCorrelativo As String

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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtRol As System.Windows.Forms.TextBox
    Friend WithEvents txtDescRol As System.Windows.Forms.TextBox
    Friend WithEvents txtDescUsuario As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCodUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRol = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescRol = New System.Windows.Forms.TextBox()
        Me.txtDescUsuario = New System.Windows.Forms.TextBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Location = New System.Drawing.Point(133, 142)
        Me.txtObservaciones.MaxLength = 255
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(384, 46)
        Me.txtObservaciones.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(28, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 19)
        Me.Label5.TabIndex = 109
        Me.Label5.Text = "Observaciones:"
        '
        'txtCodUsuario
        '
        Me.txtCodUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodUsuario.Location = New System.Drawing.Point(133, 106)
        Me.txtCodUsuario.MaxLength = 8
        Me.txtCodUsuario.Name = "txtCodUsuario"
        Me.txtCodUsuario.Size = New System.Drawing.Size(384, 22)
        Me.txtCodUsuario.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Usuario:"
        '
        'txtRol
        '
        Me.txtRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRol.Location = New System.Drawing.Point(133, 69)
        Me.txtRol.MaxLength = 8
        Me.txtRol.Name = "txtRol"
        Me.txtRol.Size = New System.Drawing.Size(106, 22)
        Me.txtRol.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(28, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "Rol:"
        '
        'txtDescRol
        '
        Me.txtDescRol.BackColor = System.Drawing.Color.White
        Me.txtDescRol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescRol.Location = New System.Drawing.Point(248, 69)
        Me.txtDescRol.MaxLength = 8
        Me.txtDescRol.Name = "txtDescRol"
        Me.txtDescRol.ReadOnly = True
        Me.txtDescRol.Size = New System.Drawing.Size(269, 22)
        Me.txtDescRol.TabIndex = 112
        '
        'txtDescUsuario
        '
        Me.txtDescUsuario.BackColor = System.Drawing.Color.White
        Me.txtDescUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescUsuario.Location = New System.Drawing.Point(219, 16)
        Me.txtDescUsuario.MaxLength = 8
        Me.txtDescUsuario.Name = "txtDescUsuario"
        Me.txtDescUsuario.ReadOnly = True
        Me.txtDescUsuario.Size = New System.Drawing.Size(269, 22)
        Me.txtDescUsuario.TabIndex = 113
        Me.txtDescUsuario.Visible = False
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(427, 194)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1010
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsUsuarioporRol
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(548, 280)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtDescUsuario)
        Me.Controls.Add(Me.txtDescRol)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCodUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRol)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(548, 280)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(548, 280)
        Me.Name = "frmMsUsuarioporRol"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Usuarios por Rol"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Property Correlativo() As String
        Get
            Return pCorrelativo
        End Get
        Set(ByVal Value As String)
            pCorrelativo = Value
        End Set
    End Property



    Private Sub txtCodUsuario_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodUsuario.DoubleClick
        Try
            If Me.txtCodUsuario.ReadOnly = True Then Exit Sub
            Dim ofrm As New frmAGenerico
            ofrm.Text = "Buscar Usuario"
            Dim oPerif As wrAdmin.wsLibAdmin, ds As New Data.DataSet
            oPerif = New wrAdmin.wsLibAdmin
            ds = oPerif.ConsultarUsuario("Usuario,Nombre", "", "Usuario", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodUsuario.Text = ofrm.Resultado
            Me.txtDescUsuario.Text = ofrm.Resultado2
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtRol_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRol.DoubleClick
        Try
            If Me.txtRol.ReadOnly = True Then Exit Sub
            Dim ofrm As New frmAGenerico
            ofrm.Text = "Buscar Rol"
            Dim oPerif As wrAdmin.wsLibAdmin, ds As New Data.DataSet
            oPerif = New wrAdmin.wsLibAdmin
            ds = oPerif.ConsultarRol("*", "", "CodRol", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtRol.Text = ofrm.Resultado
            Me.txtDescRol.Text = ofrm.Resultado2
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oAdm As New wrAdmin.wsLibAdmin, vRespuesta As String
            Dim pCampos As String, pValores As String, pCamposyValores As String
            If btnGuardar1.Text = "&Guardar" Then
                pCampos = "USUARIO,CODROL,DESCRIPCION"
                pValores = "'" & txtCodUsuario.Text & "','" & txtRol.Text & "','" & txtObservaciones.Text & "'"
                vRespuesta = oAdm.InsertarUsuarioxRol(pCampos, pValores, sUsuario, sPassword, sSucursal)
                If vRespuesta.Trim = "" Then
                    Me.Dispose()
                Else
                    MessageBox.Show(vRespuesta, "Usuarios por Rol", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                pCamposyValores = "USUARIO='" & txtCodUsuario.Text & "',CODROL='" & txtRol.Text & "',DESCRIPCION='" & txtObservaciones.Text & "'"
                vRespuesta = oAdm.ModificarUsariosxRol("Correlativo='" & pCorrelativo & "'", pCamposyValores, sUsuario, sPassword, sSucursal)
                If vRespuesta.Trim = "" Then
                    Me.Dispose()
                Else
                    MessageBox.Show(vRespuesta, "Usuarios por Rol", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsUsuarioporRol_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
