Public Class frmMSPLDescuentosISSS
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents lblMaxDesc As System.Windows.Forms.Label
    Friend WithEvents lblMaxSalario As System.Windows.Forms.Label
    Friend WithEvents lblPorcTrab As System.Windows.Forms.Label
    Friend WithEvents lblPorcPatrono As System.Windows.Forms.Label
    Friend WithEvents lblIVMTrab As System.Windows.Forms.Label
    Friend WithEvents lblIVMPatrono As System.Windows.Forms.Label
    Friend WithEvents txtPorcentajeTrabajador As System.Windows.Forms.TextBox
    Friend WithEvents txtPorcentajePatrono As System.Windows.Forms.TextBox
    Friend WithEvents txtIVMTrabajador As System.Windows.Forms.TextBox
    Friend WithEvents txtIVMPatrono As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxSalario As System.Windows.Forms.TextBox
    Friend WithEvents txtMaxDesc As System.Windows.Forms.TextBox
    Friend WithEvents lblId_ISSS As System.Windows.Forms.Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private Planilla As New wrPlanilla.wsLibPlanilla

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblMaxSalario = New System.Windows.Forms.Label()
        Me.lblMaxDesc = New System.Windows.Forms.Label()
        Me.lblPorcTrab = New System.Windows.Forms.Label()
        Me.lblPorcPatrono = New System.Windows.Forms.Label()
        Me.lblIVMTrab = New System.Windows.Forms.Label()
        Me.lblIVMPatrono = New System.Windows.Forms.Label()
        Me.txtPorcentajeTrabajador = New System.Windows.Forms.TextBox()
        Me.txtPorcentajePatrono = New System.Windows.Forms.TextBox()
        Me.txtIVMTrabajador = New System.Windows.Forms.TextBox()
        Me.txtIVMPatrono = New System.Windows.Forms.TextBox()
        Me.txtMaxSalario = New System.Windows.Forms.TextBox()
        Me.txtMaxDesc = New System.Windows.Forms.TextBox()
        Me.lblId_ISSS = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'lblMaxSalario
        '
        Me.lblMaxSalario.AutoSize = True
        Me.lblMaxSalario.Location = New System.Drawing.Point(26, 126)
        Me.lblMaxSalario.Name = "lblMaxSalario"
        Me.lblMaxSalario.Size = New System.Drawing.Size(78, 13)
        Me.lblMaxSalario.TabIndex = 70
        Me.lblMaxSalario.Text = "Maximo Salario"
        '
        'lblMaxDesc
        '
        Me.lblMaxDesc.AutoSize = True
        Me.lblMaxDesc.Location = New System.Drawing.Point(247, 126)
        Me.lblMaxDesc.Name = "lblMaxDesc"
        Me.lblMaxDesc.Size = New System.Drawing.Size(98, 13)
        Me.lblMaxDesc.TabIndex = 71
        Me.lblMaxDesc.Text = "Maximo Descuento"
        '
        'lblPorcTrab
        '
        Me.lblPorcTrab.AutoSize = True
        Me.lblPorcTrab.Location = New System.Drawing.Point(23, 60)
        Me.lblPorcTrab.Name = "lblPorcTrab"
        Me.lblPorcTrab.Size = New System.Drawing.Size(112, 13)
        Me.lblPorcTrab.TabIndex = 72
        Me.lblPorcTrab.Text = "Porcentaje Trabajador"
        '
        'lblPorcPatrono
        '
        Me.lblPorcPatrono.AutoSize = True
        Me.lblPorcPatrono.Location = New System.Drawing.Point(247, 60)
        Me.lblPorcPatrono.Name = "lblPorcPatrono"
        Me.lblPorcPatrono.Size = New System.Drawing.Size(98, 13)
        Me.lblPorcPatrono.TabIndex = 73
        Me.lblPorcPatrono.Text = "Porcentaje Patrono"
        '
        'lblIVMTrab
        '
        Me.lblIVMTrab.AutoSize = True
        Me.lblIVMTrab.Location = New System.Drawing.Point(26, 94)
        Me.lblIVMTrab.Name = "lblIVMTrab"
        Me.lblIVMTrab.Size = New System.Drawing.Size(80, 13)
        Me.lblIVMTrab.TabIndex = 74
        Me.lblIVMTrab.Text = "IVM Trabajador"
        '
        'lblIVMPatrono
        '
        Me.lblIVMPatrono.AutoSize = True
        Me.lblIVMPatrono.Location = New System.Drawing.Point(247, 94)
        Me.lblIVMPatrono.Name = "lblIVMPatrono"
        Me.lblIVMPatrono.Size = New System.Drawing.Size(66, 13)
        Me.lblIVMPatrono.TabIndex = 75
        Me.lblIVMPatrono.Text = "IVM Patrono"
        '
        'txtPorcentajeTrabajador
        '
        Me.txtPorcentajeTrabajador.Location = New System.Drawing.Point(141, 57)
        Me.txtPorcentajeTrabajador.Name = "txtPorcentajeTrabajador"
        Me.txtPorcentajeTrabajador.Size = New System.Drawing.Size(100, 20)
        Me.txtPorcentajeTrabajador.TabIndex = 76
        '
        'txtPorcentajePatrono
        '
        Me.txtPorcentajePatrono.Location = New System.Drawing.Point(351, 57)
        Me.txtPorcentajePatrono.Name = "txtPorcentajePatrono"
        Me.txtPorcentajePatrono.Size = New System.Drawing.Size(100, 20)
        Me.txtPorcentajePatrono.TabIndex = 77
        '
        'txtIVMTrabajador
        '
        Me.txtIVMTrabajador.Location = New System.Drawing.Point(141, 91)
        Me.txtIVMTrabajador.Name = "txtIVMTrabajador"
        Me.txtIVMTrabajador.Size = New System.Drawing.Size(100, 20)
        Me.txtIVMTrabajador.TabIndex = 78
        '
        'txtIVMPatrono
        '
        Me.txtIVMPatrono.Location = New System.Drawing.Point(351, 91)
        Me.txtIVMPatrono.Name = "txtIVMPatrono"
        Me.txtIVMPatrono.Size = New System.Drawing.Size(100, 20)
        Me.txtIVMPatrono.TabIndex = 79
        '
        'txtMaxSalario
        '
        Me.txtMaxSalario.Location = New System.Drawing.Point(141, 123)
        Me.txtMaxSalario.Name = "txtMaxSalario"
        Me.txtMaxSalario.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxSalario.TabIndex = 80
        '
        'txtMaxDesc
        '
        Me.txtMaxDesc.Location = New System.Drawing.Point(351, 123)
        Me.txtMaxDesc.Name = "txtMaxDesc"
        Me.txtMaxDesc.Size = New System.Drawing.Size(100, 20)
        Me.txtMaxDesc.TabIndex = 81
        '
        'lblId_ISSS
        '
        Me.lblId_ISSS.AutoSize = True
        Me.lblId_ISSS.Location = New System.Drawing.Point(451, 166)
        Me.lblId_ISSS.Name = "lblId_ISSS"
        Me.lblId_ISSS.Size = New System.Drawing.Size(0, 13)
        Me.lblId_ISSS.TabIndex = 82
        Me.lblId_ISSS.Visible = False
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(376, 149)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 126
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMSPLDescuentosISSS
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(474, 207)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.lblId_ISSS)
        Me.Controls.Add(Me.txtMaxDesc)
        Me.Controls.Add(Me.txtMaxSalario)
        Me.Controls.Add(Me.txtIVMPatrono)
        Me.Controls.Add(Me.txtIVMTrabajador)
        Me.Controls.Add(Me.txtPorcentajePatrono)
        Me.Controls.Add(Me.txtPorcentajeTrabajador)
        Me.Controls.Add(Me.lblMaxDesc)
        Me.Controls.Add(Me.lblIVMPatrono)
        Me.Controls.Add(Me.lblMaxSalario)
        Me.Controls.Add(Me.lblIVMTrab)
        Me.Controls.Add(Me.lblPorcPatrono)
        Me.Controls.Add(Me.lblPorcTrab)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMSPLDescuentosISSS"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Descuento ISSS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


#Region "Validaciones"
    Private Sub txtIVMPatrono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIVMPatrono.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.Equals(vbBack) Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtIVMTrabajador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIVMTrabajador.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.Equals(vbBack) Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtMaxDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMaxDesc.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.Equals(vbBack) Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtMaxSalario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMaxSalario.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.Equals(vbBack) Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtPorcentajePatrono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorcentajePatrono.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.Equals(vbBack) Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtPorcentajeTrabajador_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPorcentajeTrabajador.KeyPress
        If e.KeyChar.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.Equals(vbBack) Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim Resultado As Integer
            If Me.btnGuardar1.Text = "Guardar" Then
                Resultado = Planilla.Insertar_PlDescuentosISSS(Me.txtPorcentajeTrabajador.Text, Me.txtPorcentajePatrono.Text, Me.txtIVMTrabajador.Text,
                                                               Me.txtIVMPatrono.Text, Me.txtMaxSalario.Text, Me.txtMaxDesc.Text)
                If Resultado <> 0 Then
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo - Planillas")
                Else
                    MsgBox("El registro no pudo ser Ingresado, Por favor comuniquese con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Planillas")
                End If
            Else
                Resultado = Planilla.Modificar_PlDescuentosISSS(Me.txtPorcentajeTrabajador.Text, Me.txtPorcentajePatrono.Text, Me.txtIVMTrabajador.Text,
                                                               Me.txtIVMPatrono.Text, Me.txtMaxSalario.Text, Me.txtMaxDesc.Text, Me.lblId_ISSS.Text)
                If Resultado <> 0 Then
                    MsgBox("Registro modificado exitosamente", MsgBoxStyle.Information, "Módulo - Planillas")
                Else
                    MsgBox("El registro no pudo ser modificado, Por favor comuniquese con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Planillas")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

End Class
