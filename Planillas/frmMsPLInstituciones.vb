Public Class frmMSPLInstituciones
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private oPlan As wrPlanilla.wsLibPlanilla = New wrPlanilla.wsLibPlanilla

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)

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
    Friend WithEvents txtNombreInstitucion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodInstitucion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkInstBanc As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkInstBanc = New System.Windows.Forms.CheckBox()
        Me.txtNombreInstitucion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodInstitucion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'chkInstBanc
        '
        Me.chkInstBanc.Location = New System.Drawing.Point(341, 64)
        Me.chkInstBanc.Name = "chkInstBanc"
        Me.chkInstBanc.Size = New System.Drawing.Size(128, 16)
        Me.chkInstBanc.TabIndex = 2
        Me.chkInstBanc.Text = "&Institución Bancaria"
        Me.chkInstBanc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNombreInstitucion
        '
        Me.txtNombreInstitucion.Location = New System.Drawing.Point(165, 86)
        Me.txtNombreInstitucion.MaxLength = 100
        Me.txtNombreInstitucion.Multiline = True
        Me.txtNombreInstitucion.Name = "txtNombreInstitucion"
        Me.txtNombreInstitucion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNombreInstitucion.Size = New System.Drawing.Size(304, 56)
        Me.txtNombreInstitucion.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Nombre de la Institución:"
        '
        'txtCodInstitucion
        '
        Me.txtCodInstitucion.Location = New System.Drawing.Point(165, 60)
        Me.txtCodInstitucion.MaxLength = 10
        Me.txtCodInstitucion.Name = "txtCodInstitucion"
        Me.txtCodInstitucion.Size = New System.Drawing.Size(104, 20)
        Me.txtCodInstitucion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Código de la Institución:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(394, 148)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 132
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMSPLInstituciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(492, 221)
        Me.Controls.Add(Me.chkInstBanc)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtNombreInstitucion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodInstitucion)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(492, 221)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(492, 221)
        Me.Name = "frmMSPLInstituciones"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Instituciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim Campos As String, Valores As String, CamposValores As String
            If Me.btnGuardar1.Text = "&Guardar" Then
                Campos = "Nombre,Tipo"
                Valores = "'" & Trim(Me.txtNombreInstitucion.Text) & "','" & IIf(Me.chkInstBanc.Checked = True, "1", "0") & "'"
                If oPlan.InsertarPLInstituciones(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos NO fueron ingresados correctamente", MsgBoxStyle.Critical, "Módulo - Planilla")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                CamposValores = "Nombre= '" & Trim(Me.txtNombreInstitucion.Text) & "',Tipo='" & IIf(Me.chkInstBanc.Checked = True, "1", "0") & "'"
                If oPlan.ModificarPLInstituciones(CamposValores, "'" & Trim(Me.txtCodInstitucion.Text) & "'", sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos No fueron modificados correctamente", MsgBoxStyle.Information, "Módulo - Planilla")
                End If

            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region


End Class
