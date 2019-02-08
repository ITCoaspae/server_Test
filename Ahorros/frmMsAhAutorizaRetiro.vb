Public Class frmMsAhAutorizaRetiro
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtPartida As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents cbDoc As System.Windows.Forms.ComboBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label44 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPartida = New C1.Win.C1Input.C1TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.cbDoc = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(27, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(164, 117)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(234, 52)
        Me.txtName.TabIndex = 2
        '
        'txtPartida
        '
        Me.txtPartida.AcceptsReturn = True
        Me.txtPartida.EditMask = "00000000-0"
        Me.txtPartida.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartida.Location = New System.Drawing.Point(165, 91)
        Me.txtPartida.MaxLength = 20
        Me.txtPartida.Name = "txtPartida"
        Me.txtPartida.NumericInput = False
        Me.txtPartida.Size = New System.Drawing.Size(233, 20)
        Me.txtPartida.TabIndex = 1
        Me.txtPartida.Tag = Nothing
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(27, 91)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(88, 16)
        Me.Label42.TabIndex = 172
        Me.Label42.Text = "No. Documento:"
        Me.Label42.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbDoc
        '
        Me.cbDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDoc.Items.AddRange(New Object() {"DUI", "NIT", "No. Licencia", "No. Residente", "No. Partida y No. Folio", "No. Pasaporte"})
        Me.cbDoc.Location = New System.Drawing.Point(165, 63)
        Me.cbDoc.Name = "cbDoc"
        Me.cbDoc.Size = New System.Drawing.Size(233, 22)
        Me.cbDoc.TabIndex = 0
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(23, 60)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(136, 16)
        Me.Label44.TabIndex = 171
        Me.Label44.Text = "Documento de Identidad:"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(323, 175)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Green
        Me.btnGuardar1.TabIndex = 194
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsAhAutorizaRetiro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(453, 221)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtPartida)
        Me.Controls.Add(Me.Label42)
        Me.Controls.Add(Me.cbDoc)
        Me.Controls.Add(Me.Label44)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(453, 221)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(453, 221)
        Me.Name = "frmMsAhAutorizaRetiro"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Personas autorizadas a realizar retiros"
        CType(Me.txtPartida, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public pNoCuenta As String, pCodTipoAhorro As String, pAccion As String, pCorrelativo As Long, pUsuario As String, pPassword As String

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
                pCampos = "CodTipoAhorro,NoCuenta,Nombre,TipoDoc"
                pValores = "'" & Me.pCodTipoAhorro & "','" & Me.pNoCuenta & "','" & Trim(txtName.Text) & "','" & Me.cbDoc.SelectedIndex & "'"
                If oAsoc.InsertarAutorizadoRetiro(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("El Registro ha sido agregado.", MsgBoxStyle.Information)
                    Me.Dispose()
                Else
                    MsgBox("El Registro NO ha sido agregado. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Nombre = '" & Trim(txtName.Text) & "',TipoDoc='" & Me.cbDoc.SelectedIndex & "'"
                If oAsoc.ModificarAutorizadoRetiro(pCorrelativo, pCampos, pUsuario, pPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Registro NO ha sido modificado. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

End Class
