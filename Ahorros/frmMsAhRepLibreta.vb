Public Class frmMsAhRepLibreta
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pNoCuenta As String, pCodTipoAhorro As String, pAccion As String, pCorrelativo As String, pNoLibreta As String
    Private usuarioAutoriza As String
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNoLibreta As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtObservacion As MetroFramework.Controls.MetroTextBox
    Private pResultado As Boolean

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
    Friend WithEvents cbCausa As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cbCausa = New System.Windows.Forms.ComboBox()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtNoLibreta = New MetroFramework.Controls.MetroTextBox()
        Me.txtObservacion = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'cbCausa
        '
        Me.cbCausa.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbCausa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCausa.Items.AddRange(New Object() {"-- Seleccione una opción -- ", "Actualización de Libreta", "Libreta Dañada", "Libreta Extraviada", "Libreta Finalizada"})
        Me.cbCausa.Location = New System.Drawing.Point(154, 92)
        Me.cbCausa.Name = "cbCausa"
        Me.cbCausa.Size = New System.Drawing.Size(466, 24)
        Me.cbCausa.TabIndex = 2
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(533, 209)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(87, 33)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 211
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(24, 63)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(126, 20)
        Me.MetroLabel1.TabIndex = 212
        Me.MetroLabel1.Text = "Nuevo No. Libreta:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 92)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(125, 20)
        Me.MetroLabel2.TabIndex = 213
        Me.MetroLabel2.Text = "Motivo Reposición:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(24, 127)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(91, 20)
        Me.MetroLabel3.TabIndex = 214
        Me.MetroLabel3.Text = "Observación:"
        '
        'txtNoLibreta
        '
        '
        '
        '
        Me.txtNoLibreta.CustomButton.Image = Nothing
        Me.txtNoLibreta.CustomButton.Location = New System.Drawing.Point(145, 1)
        Me.txtNoLibreta.CustomButton.Name = ""
        Me.txtNoLibreta.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtNoLibreta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtNoLibreta.CustomButton.TabIndex = 1
        Me.txtNoLibreta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtNoLibreta.CustomButton.UseSelectable = True
        Me.txtNoLibreta.CustomButton.Visible = False
        Me.txtNoLibreta.Lines = New String(-1) {}
        Me.txtNoLibreta.Location = New System.Drawing.Point(156, 63)
        Me.txtNoLibreta.MaxLength = 32767
        Me.txtNoLibreta.Name = "txtNoLibreta"
        Me.txtNoLibreta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoLibreta.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNoLibreta.SelectedText = ""
        Me.txtNoLibreta.SelectionLength = 0
        Me.txtNoLibreta.SelectionStart = 0
        Me.txtNoLibreta.ShortcutsEnabled = True
        Me.txtNoLibreta.Size = New System.Drawing.Size(167, 23)
        Me.txtNoLibreta.TabIndex = 215
        Me.txtNoLibreta.UseSelectable = True
        Me.txtNoLibreta.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtNoLibreta.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtObservacion
        '
        '
        '
        '
        Me.txtObservacion.CustomButton.Image = Nothing
        Me.txtObservacion.CustomButton.Location = New System.Drawing.Point(384, 1)
        Me.txtObservacion.CustomButton.Name = ""
        Me.txtObservacion.CustomButton.Size = New System.Drawing.Size(79, 79)
        Me.txtObservacion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtObservacion.CustomButton.TabIndex = 1
        Me.txtObservacion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtObservacion.CustomButton.UseSelectable = True
        Me.txtObservacion.CustomButton.Visible = False
        Me.txtObservacion.Lines = New String(-1) {}
        Me.txtObservacion.Location = New System.Drawing.Point(156, 122)
        Me.txtObservacion.MaxLength = 32767
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtObservacion.SelectedText = ""
        Me.txtObservacion.SelectionLength = 0
        Me.txtObservacion.SelectionStart = 0
        Me.txtObservacion.ShortcutsEnabled = True
        Me.txtObservacion.Size = New System.Drawing.Size(464, 81)
        Me.txtObservacion.TabIndex = 216
        Me.txtObservacion.UseSelectable = True
        Me.txtObservacion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtObservacion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'frmMsAhRepLibreta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(646, 317)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.txtNoLibreta)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.cbCausa)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhRepLibreta"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reposición Libreta de Ahorros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub gbRepLib_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub MetroTextBox1_Click(sender As Object, e As EventArgs) Handles txtNoLibreta.Click

    End Sub

#End Region
    Public Property usuarioAut() As String
        Get
            Return usuarioAutoriza
        End Get
        Set(ByVal value As String)
            usuarioAutoriza = value
        End Set
    End Property

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim oAsoc As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, pCampos As String, pValores As String
        Try
            If Me.btnGuardar.Text = "&Guardar" Then
                pCampos = "CodTipoAhorro,NoCuenta,Causa,NoLibretaRepone,NoLibreta,Fecha,usuario,usuarioAutoriza,observacion"
                pValores = "'" & Me.pCodTipoAhorro & "','" & Me.pNoCuenta & "','" & Me.cbCausa.SelectedIndex &
                "','" & Me.pNoLibreta & "','" &
                Trim(Me.txtNoLibreta.Text) & "','" & Now & "', '" & sUsuario &
                "','" & usuarioAutoriza & "', '" & txtObservacion.Text & "'"
                If oAsoc.InsertarReposicionLibreta(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    resultado = oAsoc.ModificarCuentaAhorro(Me.pNoCuenta, Me.pCodTipoAhorro, "NoLibreta='" & Me.txtNoLibreta.Text.Trim & "'", sUsuario, sPassword, sSucursal)
                    MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose()
                Else
                    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If
            ElseIf Me.btnGuardar.Text = "&Modificar" Then
                pCampos = "Causa='" & Me.cbCausa.SelectedIndex &
                "',NoLibreta='" & Trim(Me.txtNoLibreta.Text) & "',Fecha='" & Now &
                "',usuario ='" & sUsuario & "','" & usuarioAutoriza & "',observacion = '" & txtObservacion.Text.Trim & "'"
                If oAsoc.ModificarReposicionLibreta(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    resultado = oAsoc.ModificarCuentaAhorro(Me.pNoCuenta, Me.pCodTipoAhorro, "NoLibreta='" & Me.txtNoLibreta.Text.Trim & "'", sUsuario, sPassword, sSucursal)
                    MetroFramework.MetroMessageBox.Show(Me, mensajeUpdateRegistro, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose()
                Else
                    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Property resultado() As Boolean
        Get
            Return pResultado
        End Get
        Set(ByVal value As Boolean)
            pResultado = value
        End Set
    End Property



    Private Sub frmMsAhRepLibreta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ds As New Data.DataSet
        Dim oAsoc As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
        Dim Filas As Data.DataRowCollection
        Try

            Me.cbCausa.SelectedIndex = 0

            If Me.btnGuardar.Text = "&Modificar" Then

                ds = oAsoc.ConsultarReposicionLibreta("*", "NoSolicitud='" & Me.pCorrelativo & "'", "Fecha", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then

                    Me.cbCausa.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("Causa")), 0, Filas.Item(0)("Causa"))

                    Me.txtNoLibreta.Text = IIf(IsDBNull(Filas.Item(0)("NoLibreta")), 0, Filas.Item(0)("NoLibreta"))

                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmMsAhRepLibreta_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
