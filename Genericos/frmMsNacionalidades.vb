Public Class frmMsNacionalidades
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pAccion As String
    Friend WithEvents txtNacionalidad As System.Windows.Forms.TextBox
    Friend WithEvents txtAlfa2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAlfa1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCodFGR As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
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
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodFGR = New System.Windows.Forms.TextBox()
        Me.txtNacionalidad = New System.Windows.Forms.TextBox()
        Me.txtAlfa2 = New System.Windows.Forms.TextBox()
        Me.txtAlfa1 = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(23, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Código FGR:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(23, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Nacionalidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(303, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Alfa2:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(23, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Alfa1:"
        '
        'txtCodFGR
        '
        Me.txtCodFGR.BackColor = System.Drawing.Color.White
        Me.txtCodFGR.Location = New System.Drawing.Point(101, 160)
        Me.txtCodFGR.MaxLength = 10
        Me.txtCodFGR.Name = "txtCodFGR"
        Me.txtCodFGR.Size = New System.Drawing.Size(100, 20)
        Me.txtCodFGR.TabIndex = 83
        '
        'txtNacionalidad
        '
        Me.txtNacionalidad.BackColor = System.Drawing.Color.White
        Me.txtNacionalidad.Location = New System.Drawing.Point(101, 134)
        Me.txtNacionalidad.MaxLength = 100
        Me.txtNacionalidad.Name = "txtNacionalidad"
        Me.txtNacionalidad.Size = New System.Drawing.Size(352, 20)
        Me.txtNacionalidad.TabIndex = 82
        '
        'txtAlfa2
        '
        Me.txtAlfa2.BackColor = System.Drawing.Color.White
        Me.txtAlfa2.Location = New System.Drawing.Point(353, 108)
        Me.txtAlfa2.MaxLength = 5
        Me.txtAlfa2.Name = "txtAlfa2"
        Me.txtAlfa2.Size = New System.Drawing.Size(100, 20)
        Me.txtAlfa2.TabIndex = 81
        '
        'txtAlfa1
        '
        Me.txtAlfa1.BackColor = System.Drawing.Color.White
        Me.txtAlfa1.Location = New System.Drawing.Point(101, 108)
        Me.txtAlfa1.MaxLength = 5
        Me.txtAlfa1.Name = "txtAlfa1"
        Me.txtAlfa1.Size = New System.Drawing.Size(100, 20)
        Me.txtAlfa1.TabIndex = 80
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.Location = New System.Drawing.Point(101, 82)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(352, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(101, 56)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Código:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(378, 160)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 168
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsNacionalidades
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(480, 234)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodFGR)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtNacionalidad)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtAlfa2)
        Me.Controls.Add(Me.txtAlfa1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 234)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(480, 234)
        Me.Name = "frmMsNacionalidades"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Nacionalidades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmMsNacionalidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection

        If Me.pAccion = "Agregar" Then
            Me.txtCodigo.Text = Format(oAsoc.ObtenerCorrelativoNacionalidades("CodNacionalidad", sUsuario, sPassword, sSucursal), "00000")
        ElseIf Me.pAccion = "Modificar" Then

            ds = oAsoc.ConsultarNacionalidades("*", "CodNacionalidad='" & pCodigo & "'", "CodNacionalidad", sUsuario, sPassword, sSucursal)

            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtCodigo.Text = pCodigo
                txtCodigo.Enabled = False
                txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                txtAlfa1.Text = IIf(IsDBNull(Filas.Item(0)("Alfa1")), "", Filas.Item(0)("Alfa1"))
                txtAlfa2.Text = IIf(IsDBNull(Filas.Item(0)("Alfa2")), "", Filas.Item(0)("Alfa2"))
                txtNacionalidad.Text = IIf(IsDBNull(Filas.Item(0)("Nacionalidad")), "", Filas.Item(0)("Nacionalidad"))
                txtCodFGR.Text = IIf(IsDBNull(Filas.Item(0)("CodigoFGR")), "", Filas.Item(0)("CodigoFGR"))
            End If

        End If
        txtCodigo.Focus()
    End Sub


    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String

            Select Case oAsoc.AutorizaDatos(Trim(txtCodigo.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El Código de la Nacionalidad no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Nacionalidades")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "Guardar" Then
                pCampos = "CodNacionalidad,Descripcion,Alfa1,Alfa2,Nacionalidad,CodigoFGR"
                pValores = "'" & Trim(txtCodigo.Text) &
                "', '" & Trim(txtDescripcion.Text) &
                "', '" & txtAlfa1.Text.Trim &
                "', '" & txtAlfa2.Text.Trim &
                "', '" & txtNacionalidad.Text.Trim &
                "', '" & txtCodFGR.Text.Trim & "'"
                If oAsoc.InsertarNacionalidades(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("La nacionalidad NO ha sido agregada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Nacionalidades")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Descripcion='" & Trim(txtDescripcion.Text) &
                "', alfa1 =  '" & txtAlfa1.Text.Trim &
                "', alfa2 = '" & txtAlfa2.Text.Trim &
                "', Nacionalidad = '" & txtNacionalidad.Text.Trim &
                "', CodigoFGR = '" & txtCodFGR.Text.Trim & "'"
                If oAsoc.ModificarNacionalidades("CodNacionalidad='" & Trim(pCodigo) & "'", pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("La nacionalidad no ha sido modificada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Nacionalidades")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

End Class
