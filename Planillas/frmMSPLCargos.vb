Public Class frmMSPLCargos
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Public vAccion As String
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private oPlan As wrPlanilla.wsLibPlanilla = New wrPlanilla.wsLibPlanilla

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) '' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

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
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtCodCargo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(119, 84)
        Me.txtDesc.MaxLength = 100
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDesc.Size = New System.Drawing.Size(320, 47)
        Me.txtDesc.TabIndex = 1
        '
        'txtCodCargo
        '
        Me.txtCodCargo.Location = New System.Drawing.Point(119, 60)
        Me.txtCodCargo.MaxLength = 10
        Me.txtCodCargo.Name = "txtCodCargo"
        Me.txtCodCargo.Size = New System.Drawing.Size(104, 20)
        Me.txtCodCargo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Código de Cargo:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(364, 137)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 121
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMSPLCargos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(464, 214)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtCodCargo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(464, 214)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(464, 214)
        Me.Name = "frmMSPLCargos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cargos"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub
    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim Campos As String, Valores As String, CamposValores As String
            If Me.btnGuardar1.Text = "&Guardar" Then
                Campos = "Descripcion"
                Valores = "'" & Trim(Me.txtDesc.Text) & "'"
                If oPlan.InsertarPLCargos(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Registro Ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Planilla")
                    Me.Dispose()
                Else
                    MsgBox("Los datos no fuerón ingresados correctamente", MsgBoxStyle.Critical, "Módulo - Planilla")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                CamposValores = "Descripcion='" & Trim(Me.txtDesc.Text) & "'"
                If oPlan.ModificarPLCargos(CamposValores, "'" & Trim(Me.txtCodCargo.Text) & "'", sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Registro Modificado exitosamente", MsgBoxStyle.Information, "Módulo - Planilla")
                    Me.Dispose()
                Else
                    MsgBox("Los datos no fuerón modificados correctamente", MsgBoxStyle.Critical, "Módulo - Planilla")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
#End Region
End Class
