Public Class frmMSPLAreas
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Public vAccion As String
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private oPlan As wrPlanilla.wsLibPlanilla = New wrPlanilla.wsLibPlanilla

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer
    Friend WithEvents txtCodArea As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtCodArea = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(129, 86)
        Me.txtDesc.MaxLength = 100
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDesc.Size = New System.Drawing.Size(320, 56)
        Me.txtDesc.TabIndex = 1
        '
        'txtCodArea
        '
        Me.txtCodArea.Location = New System.Drawing.Point(129, 60)
        Me.txtCodArea.MaxLength = 10
        Me.txtCodArea.Name = "txtCodArea"
        Me.txtCodArea.Size = New System.Drawing.Size(104, 20)
        Me.txtCodArea.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Descripci�n:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "C�digo de �rea:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(374, 148)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 117
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMSPLAreas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(472, 231)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodArea)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(472, 231)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(472, 231)
        Me.Name = "frmMSPLAreas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "�reas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim Campos As String, Valores As String, CamposValores As String
            If Me.btnGuardar1.Text = "&Guardar" Then
                Campos = "Descripcion"
                Valores = "'" & Trim(Me.txtDesc.Text) & "'"
                If oPlan.InsertarPLAreas(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "M�dulo - Planilla")
                    Me.Dispose()
                Else
                    MsgBox("Los datos NO fuer�n ingresados correctamente", MsgBoxStyle.Critical, "M�dulo - Planilla")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                CamposValores = "Descripcion= '" & Trim(Me.txtDesc.Text) & "'"
                If oPlan.ModificarPLAreas(CamposValores, "'" & Trim(Me.txtCodArea.Text) & "'", sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Registro Modificado exitosamente", MsgBoxStyle.Information, "M�dulo - Planilla")
                    Me.Dispose()
                Else
                    MsgBox("Los datos No fuer�n modificados correctamente", MsgBoxStyle.Information, "M�dulo - Planilla")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region



End Class
