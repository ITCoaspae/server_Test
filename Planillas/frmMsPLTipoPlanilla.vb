Public Class frmMsPLTipoPlanilla
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents chkAFP As System.Windows.Forms.CheckBox
    Friend WithEvents chkRenta As System.Windows.Forms.CheckBox
    Friend WithEvents chkISSS As System.Windows.Forms.CheckBox
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
    Friend WithEvents txtCodTipoPlanilla As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkAFP = New System.Windows.Forms.CheckBox()
        Me.chkRenta = New System.Windows.Forms.CheckBox()
        Me.chkISSS = New System.Windows.Forms.CheckBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodTipoPlanilla = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'chkAFP
        '
        Me.chkAFP.AutoSize = True
        Me.chkAFP.Location = New System.Drawing.Point(213, 63)
        Me.chkAFP.Name = "chkAFP"
        Me.chkAFP.Size = New System.Drawing.Size(46, 17)
        Me.chkAFP.TabIndex = 6
        Me.chkAFP.Text = "AFP"
        Me.chkAFP.UseVisualStyleBackColor = True
        '
        'chkRenta
        '
        Me.chkRenta.AutoSize = True
        Me.chkRenta.Location = New System.Drawing.Point(321, 63)
        Me.chkRenta.Name = "chkRenta"
        Me.chkRenta.Size = New System.Drawing.Size(55, 17)
        Me.chkRenta.TabIndex = 8
        Me.chkRenta.Text = "Renta"
        Me.chkRenta.UseVisualStyleBackColor = True
        '
        'chkISSS
        '
        Me.chkISSS.AutoSize = True
        Me.chkISSS.Location = New System.Drawing.Point(265, 63)
        Me.chkISSS.Name = "chkISSS"
        Me.chkISSS.Size = New System.Drawing.Size(50, 17)
        Me.chkISSS.TabIndex = 7
        Me.chkISSS.Text = "ISSS"
        Me.chkISSS.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(101, 86)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(408, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodTipoPlanilla
        '
        Me.txtCodTipoPlanilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoPlanilla.Location = New System.Drawing.Point(101, 60)
        Me.txtCodTipoPlanilla.MaxLength = 10
        Me.txtCodTipoPlanilla.Name = "txtCodTipoPlanilla"
        Me.txtCodTipoPlanilla.Size = New System.Drawing.Size(106, 20)
        Me.txtCodTipoPlanilla.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Planilla:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(434, 112)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 144
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsPLTipoPlanilla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(533, 171)
        Me.Controls.Add(Me.chkRenta)
        Me.Controls.Add(Me.chkAFP)
        Me.Controls.Add(Me.chkISSS)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtCodTipoPlanilla)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(533, 171)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(533, 171)
        Me.Name = "frmMsPLTipoPlanilla"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Tipo de Planilla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim Campos, Valores, CamposValores As String
        Try
            If Me.btnGuardar1.Text = "&Guardar" Then
                If Me.txtCodTipoPlanilla.Text = "" Then
                    MsgBox("Debe de completar todos los campos", MsgBoxStyle.Information, "Módulo - Planilla")
                Else
                    Campos = "CodTipoPlanilla,Descripcion,AFP,ISSS,Renta"
                    Valores = "'" & Trim(Me.txtCodTipoPlanilla.Text) & "','" & Trim(Me.txtDescripcion.Text) & "', '" & Me.chkAFP.Checked &
                    "','" & Me.chkISSS.Checked & "', '" & Me.chkRenta.Checked & "'"
                    If oPlan.InsertarPLTipoPlanilla(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                        MsgBox("Regsitro ingresado", MsgBoxStyle.Information, "Módulo - Planilla")
                        Me.Dispose()
                    Else
                        MsgBox("Regsitro NO ingresado", MsgBoxStyle.Information, "Módulo - Planilla")
                    End If
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                CamposValores = "Descripcion='" & Trim(Me.txtDescripcion.Text) & "',AFP='" & Me.chkAFP.Checked & "',ISSS='" & Me.chkISSS.Checked & "',Renta='" & Me.chkRenta.Checked & "'"
                If oPlan.ModificarPLTipoPlanilla(CamposValores, "'" & Trim(Me.txtCodTipoPlanilla.Text) & "'", sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Registro modificado", MsgBoxStyle.Information, "Módulo - Planilla")
                    Me.Dispose()
                Else
                    MsgBox("Registro NO modificado", MsgBoxStyle.Information, "Módulo - Planilla")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region


End Class
