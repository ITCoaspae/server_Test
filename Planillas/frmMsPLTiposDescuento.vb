Public Class frmMsPLTiposDescuento
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private oPlan As New wrPlanilla.wsLibPlanilla

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
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbDescInterno As System.Windows.Forms.RadioButton
    Friend WithEvents rbDescExterno As System.Windows.Forms.RadioButton
    Friend WithEvents txtCtaContable As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodTipo As System.Windows.Forms.TextBox
    Friend WithEvents chkMostrarPlanilla As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkMostrarPlanilla = New System.Windows.Forms.CheckBox()
        Me.txtCtaContable = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbDescExterno = New System.Windows.Forms.RadioButton()
        Me.rbDescInterno = New System.Windows.Forms.RadioButton()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodTipo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'chkMostrarPlanilla
        '
        Me.chkMostrarPlanilla.Location = New System.Drawing.Point(439, 124)
        Me.chkMostrarPlanilla.Name = "chkMostrarPlanilla"
        Me.chkMostrarPlanilla.Size = New System.Drawing.Size(128, 24)
        Me.chkMostrarPlanilla.TabIndex = 3
        Me.chkMostrarPlanilla.Text = "&Separar en Planilla"
        Me.chkMostrarPlanilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCtaContable
        '
        Me.txtCtaContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCtaContable.Location = New System.Drawing.Point(159, 124)
        Me.txtCtaContable.MaxLength = 20
        Me.txtCtaContable.Name = "txtCtaContable"
        Me.txtCtaContable.Size = New System.Drawing.Size(184, 20)
        Me.txtCtaContable.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Cuenta Contable:"
        '
        'rbDescExterno
        '
        Me.rbDescExterno.Location = New System.Drawing.Point(23, 156)
        Me.rbDescExterno.Name = "rbDescExterno"
        Me.rbDescExterno.Size = New System.Drawing.Size(136, 16)
        Me.rbDescExterno.TabIndex = 4
        Me.rbDescExterno.Text = "Descuento &Externo"
        '
        'rbDescInterno
        '
        Me.rbDescInterno.Location = New System.Drawing.Point(159, 156)
        Me.rbDescInterno.Name = "rbDescInterno"
        Me.rbDescInterno.Size = New System.Drawing.Size(136, 16)
        Me.rbDescInterno.TabIndex = 5
        Me.rbDescInterno.Text = "Descuento &Interno"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(159, 84)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(408, 32)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodTipo
        '
        Me.txtCodTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipo.Location = New System.Drawing.Point(159, 60)
        Me.txtCodTipo.MaxLength = 10
        Me.txtCodTipo.Name = "txtCodTipo"
        Me.txtCodTipo.Size = New System.Drawing.Size(104, 20)
        Me.txtCodTipo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de Descuento:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(492, 154)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 145
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsPLTiposDescuento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(593, 225)
        Me.Controls.Add(Me.chkMostrarPlanilla)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtCtaContable)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbDescExterno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbDescInterno)
        Me.Controls.Add(Me.txtCodTipo)
        Me.Controls.Add(Me.txtDescripcion)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(593, 225)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(593, 225)
        Me.Name = "frmMsPLTiposDescuento"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Control de Forma de Descuentos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim Campos, Valores, CamposValores As String, vTipo As String
        Try
            If Me.btnGuardar1.Text = "&Guardar" Then
                If Me.txtDescripcion.Text = "" Then
                    MsgBox("Debe de completar todos los campos", MsgBoxStyle.Information, "Módulo - Planilla")
                Else
                    If Me.rbDescExterno.Checked = True Then
                        vTipo = "E"
                    Else
                        vTipo = "I"
                    End If
                    Campos = "Descripcion,Tipo,IdCuenta,Reporte"
                    Valores = "'" & Trim(Me.txtDescripcion.Text) & "','" & vTipo & "','" & Me.txtCtaContable.Text.Trim & "','" & IIf(Me.chkMostrarPlanilla.Checked = True, "1", "0") & "'"
                    If oPlan.InsertarPLTipoDescuentos(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                        Me.Dispose()
                    Else
                        MsgBox("Registro NO ingresado", MsgBoxStyle.Information, "Módulo - Planilla")
                    End If
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                If Me.rbDescExterno.Checked = True Then
                    vTipo = "E"
                Else
                    vTipo = "I"
                End If
                CamposValores = "Descripcion='" & Trim(Me.txtDescripcion.Text) & "',Tipo='" & vTipo & "',IdCuenta='" & Me.txtCtaContable.Text.Trim & "',Reporte='" & IIf(Me.chkMostrarPlanilla.Checked = True, "1", "0") & "'"
                If oPlan.ModificarPLTipoDescuentos(CamposValores, "'" & Trim(Me.txtCodTipo.Text) & "'", sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Registro NO modificado", MsgBoxStyle.Information, "Módulo - Planilla")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
