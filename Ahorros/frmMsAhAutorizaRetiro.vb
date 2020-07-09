Public Class frmMsAhAutorizaRetiro
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager

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
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPartida As C1.Win.C1Input.C1TextBox
    Friend WithEvents cbDoc As System.Windows.Forms.ComboBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPartida = New C1.Win.C1Input.C1TextBox()
        Me.cbDoc = New System.Windows.Forms.ComboBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(163, 120)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(358, 60)
        Me.txtName.TabIndex = 2
        '
        'txtPartida
        '
        Me.txtPartida.AcceptsReturn = True
        Me.txtPartida.EditMask = "00000000-0"
        Me.txtPartida.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartida.Location = New System.Drawing.Point(163, 93)
        Me.txtPartida.MaxLength = 20
        Me.txtPartida.Name = "txtPartida"
        Me.txtPartida.NumericInput = False
        Me.txtPartida.Size = New System.Drawing.Size(358, 21)
        Me.txtPartida.TabIndex = 1
        Me.txtPartida.Tag = Nothing
        '
        'cbDoc
        '
        Me.cbDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDoc.Items.AddRange(New Object() {"DUI", "NIT", "No. Licencia", "No. Residente", "No. Partida y No. Folio", "No. Pasaporte"})
        Me.cbDoc.Location = New System.Drawing.Point(163, 63)
        Me.cbDoc.Name = "cbDoc"
        Me.cbDoc.Size = New System.Drawing.Size(358, 24)
        Me.cbDoc.TabIndex = 0
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(431, 186)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 194
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(134, 20)
        Me.MetroLabel1.TabIndex = 195
        Me.MetroLabel1.Text = "Tipo de documento:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 93)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(129, 20)
        Me.MetroLabel2.TabIndex = 196
        Me.MetroLabel2.Text = "No. de documento:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 120)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(129, 20)
        Me.MetroLabel3.TabIndex = 197
        Me.MetroLabel3.Text = "Persona autorizada:"
        '
        'frmMsAhAutorizaRetiro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(544, 255)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtPartida)
        Me.Controls.Add(Me.cbDoc)
        Me.Controls.Add(Me.txtName)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(544, 255)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(544, 255)
        Me.Name = "frmMsAhAutorizaRetiro"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Personas autorizadas a realizar retiros"
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public pNoCuenta As String, pCodTipoAhorro As String, pAccion As String, pCorrelativo As Long, pUsuario As String, pPassword As String

    Private Sub MetroLabel2_Click(sender As Object, e As EventArgs) Handles MetroLabel2.Click

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim oAsoc As wrAhorro.wsLibAhorro, pCampos As String, pValores As String
        Try
            oAsoc = New wrAhorro.wsLibAhorro
            Select Case oAsoc.AutorizaDatos(txtName.Text, "x", "x", "x", "x")
                Case 1
                    MsgBox("El campo Nombre no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "CodTipoAhorro,NoCuenta,Nombre,TipoDoc,NoDocumento"
                pValores = "'" & Me.pCodTipoAhorro & "','" & Me.pNoCuenta & "','" & Trim(txtName.Text) & "','" & Me.cbDoc.SelectedIndex & "','" & txtPartida.Value & "'"
                If oAsoc.InsertarAutorizadoRetiro(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Dispose()
                Else
                    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Nombre = '" & Trim(txtName.Text) & "',TipoDoc='" & Me.cbDoc.SelectedIndex & "',NoDocumento = '" & txtPartida.Value & "'"
                If oAsoc.ModificarAutorizadoRetiro(pCorrelativo, pCampos, pUsuario, pPassword, sSucursal) = True Then
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

    Private Sub frmMsAhAutorizaRetiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New Data.DataSet, Filas As Data.DataRowCollection
        Me.txtName.Focus()
        Try
            Dim oAsoc As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
            If Me.btnGuardar1.Text = "&Modificar" Then
                ds = oAsoc.ConsultarAutorizadoRetiro("*", "Correlativo='" & pCorrelativo & "'", "Correlativo", pUsuario, pPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtName.Text = CStr(Filas.Item(0)("Nombre"))
                    Me.cbDoc.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("TipoDoc")), 0, Filas.Item(0)("TipoDoc"))
                    Me.txtPartida.Value = IIf(IsDBNull(Filas.Item(0)("NoDocumento")), 0, Filas.Item(0)("NoDocumento"))

                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub cbDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDoc.SelectedIndexChanged
        If cbDoc.SelectedIndex = 0 Then
            Me.txtPartida.EditMask = "00000000-0"
        ElseIf cbDoc.SelectedIndex = 1 Or cbDoc.SelectedIndex = 2 Then
            Me.txtPartida.EditMask = "0000-000000-000-0"
        Else
            Me.txtPartida.EditMask = ""
        End If
    End Sub

    Private Sub frmMsAhAutorizaRetiro_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
