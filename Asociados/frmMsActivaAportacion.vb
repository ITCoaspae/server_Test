Public Class frmMsActivaAportacion
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form
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
    Friend WithEvents txtNoActa As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtNoActa = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtNoActa
        '
        Me.txtNoActa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoActa.Location = New System.Drawing.Point(155, 69)
        Me.txtNoActa.MaxLength = 20
        Me.txtNoActa.Name = "txtNoActa"
        Me.txtNoActa.Size = New System.Drawing.Size(153, 23)
        Me.txtNoActa.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(28, 69)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 19)
        Me.Label12.TabIndex = 121
        Me.Label12.Text = "Número de Acta:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(28, 107)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 33)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 122
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsActivaAportacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(493, 218)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtNoActa)
        Me.Controls.Add(Me.Label12)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsActivaAportacion"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Activación Cuenta de Aportación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim oAsoc As New wrAsociados.wsLibAsoc, vResponse As String
        Try
            vResponse = oAsoc.ActivacionCuentasAportacion(Me.txtNoActa.Text.Trim, sUsuario, sPassword, sSucursal)
            If vResponse.Trim = "" Then
                MsgBox("Cuentas de Aportacion generadas con éxito.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Generación Cuentas de Aportación")
            Else
                MsgBox(vResponse, MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Generación Cuentas de Aportación")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frmMsActivaAportacion_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
