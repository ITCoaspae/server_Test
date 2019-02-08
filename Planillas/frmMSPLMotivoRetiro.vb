Public Class frmMSPLMotivoRetiro
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private oPlan As New wrPlanilla.wsLibPlanilla

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodMotivoRetiro As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodMotivoRetiro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(157, 84)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(288, 56)
        Me.txtDescripcion.TabIndex = 3
        '
        'txtCodMotivoRetiro
        '
        Me.txtCodMotivoRetiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodMotivoRetiro.Location = New System.Drawing.Point(157, 58)
        Me.txtCodMotivoRetiro.MaxLength = 10
        Me.txtCodMotivoRetiro.Name = "txtCodMotivoRetiro"
        Me.txtCodMotivoRetiro.Size = New System.Drawing.Size(128, 20)
        Me.txtCodMotivoRetiro.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código Motivo de Retiro"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(370, 146)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 134
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMSPLMotivoRetiro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(473, 216)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtCodMotivoRetiro)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(473, 216)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(473, 216)
        Me.Name = "frmMSPLMotivoRetiro"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Maestro Detalle Motivo Retiro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim Campos, Valores, CamposValores As String
        Try
            If Me.btnGuardar1.Text = "&Guardar" Then
                If Me.txtDescripcion.Text = "" Then
                    MsgBox("Debe de completar el campos Código de Retiro", MsgBoxStyle.Information, "Módulo - Planilla")
                Else
                    Campos = "Descripcion"
                    Valores = "'" & Trim(Me.txtDescripcion.Text) & "'"
                    If oPlan.InsertarPLMotivoRetiro(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                        MsgBox("Registro ingresado", MsgBoxStyle.Information, "Módulo - Planilla")
                        Me.Dispose()
                    Else
                        MsgBox("Registro NO ingresado", MsgBoxStyle.Information, "Módulo - Planilla")
                    End If
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                CamposValores = "Descripcion='" & Trim(Me.txtDescripcion.Text) & "'"
                If oPlan.ModificarPLMotivoRetiro(CamposValores, "'" & Trim(Me.txtCodMotivoRetiro.Text) & "'", sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Registro modificado", MsgBoxStyle.Information, "Módulo - Planilla")
                    Me.Dispose()
                Else
                    MsgBox("Registro NO modificado", MsgBoxStyle.Information, "Módulo - Planilla")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

#End Region

End Class
