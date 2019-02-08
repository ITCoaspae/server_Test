Public Class frmMsPLPensiones
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private oPlan As wrPlanilla.wsLibPlanilla = New wrPlanilla.wsLibPlanilla

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
    Friend WithEvents txtNombreInstitucion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodInstitucion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudPorcPatrono As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudPorcTrabajador As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCtaContable As System.Windows.Forms.TextBox
    Friend WithEvents c1Monto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkMostrarPlanilla As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkMostrarPlanilla = New System.Windows.Forms.CheckBox()
        Me.c1Monto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCtaContable = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nudPorcPatrono = New System.Windows.Forms.NumericUpDown()
        Me.nudPorcTrabajador = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombreInstitucion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodInstitucion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.c1Monto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPorcPatrono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPorcTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkMostrarPlanilla
        '
        Me.chkMostrarPlanilla.Location = New System.Drawing.Point(341, 161)
        Me.chkMostrarPlanilla.Name = "chkMostrarPlanilla"
        Me.chkMostrarPlanilla.Size = New System.Drawing.Size(128, 24)
        Me.chkMostrarPlanilla.TabIndex = 6
        Me.chkMostrarPlanilla.Text = "&Separar en Planilla"
        Me.chkMostrarPlanilla.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'c1Monto
        '
        Me.c1Monto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1Monto.FormatType = C1.Win.C1Input.FormatTypeEnum.FixedPoint
        Me.c1Monto.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1Monto.Location = New System.Drawing.Point(165, 161)
        Me.c1Monto.Name = "c1Monto"
        Me.c1Monto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1Monto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1Monto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1Monto.ShowDropDownButton = False
        Me.c1Monto.ShowUpDownButtons = False
        Me.c1Monto.Size = New System.Drawing.Size(96, 20)
        Me.c1Monto.TabIndex = 4
        Me.c1Monto.Tag = Nothing
        Me.c1Monto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(23, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 16)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Monto Límite:"
        '
        'txtCtaContable
        '
        Me.txtCtaContable.Location = New System.Drawing.Point(165, 187)
        Me.txtCtaContable.MaxLength = 100
        Me.txtCtaContable.Name = "txtCtaContable"
        Me.txtCtaContable.Size = New System.Drawing.Size(136, 20)
        Me.txtCtaContable.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 80
        Me.Label5.Text = "Cuenta Contable:"
        '
        'nudPorcPatrono
        '
        Me.nudPorcPatrono.DecimalPlaces = 2
        Me.nudPorcPatrono.Location = New System.Drawing.Point(224, 135)
        Me.nudPorcPatrono.Name = "nudPorcPatrono"
        Me.nudPorcPatrono.Size = New System.Drawing.Size(72, 20)
        Me.nudPorcPatrono.TabIndex = 3
        Me.nudPorcPatrono.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'nudPorcTrabajador
        '
        Me.nudPorcTrabajador.DecimalPlaces = 2
        Me.nudPorcTrabajador.Location = New System.Drawing.Point(224, 109)
        Me.nudPorcTrabajador.Name = "nudPorcTrabajador"
        Me.nudPorcTrabajador.Size = New System.Drawing.Size(72, 20)
        Me.nudPorcTrabajador.TabIndex = 2
        Me.nudPorcTrabajador.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 16)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Porcentaje descuento del Patrono:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 16)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Porcentaje descuento del Trabajador:"
        '
        'txtNombreInstitucion
        '
        Me.txtNombreInstitucion.Location = New System.Drawing.Point(165, 83)
        Me.txtNombreInstitucion.MaxLength = 100
        Me.txtNombreInstitucion.Name = "txtNombreInstitucion"
        Me.txtNombreInstitucion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNombreInstitucion.Size = New System.Drawing.Size(304, 20)
        Me.txtNombreInstitucion.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Nombre de la Institución:"
        '
        'txtCodInstitucion
        '
        Me.txtCodInstitucion.Location = New System.Drawing.Point(165, 57)
        Me.txtCodInstitucion.MaxLength = 10
        Me.txtCodInstitucion.Name = "txtCodInstitucion"
        Me.txtCodInstitucion.Size = New System.Drawing.Size(72, 20)
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
        Me.btnGuardar1.Location = New System.Drawing.Point(394, 187)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 135
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsPLPensiones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(493, 258)
        Me.Controls.Add(Me.chkMostrarPlanilla)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtCtaContable)
        Me.Controls.Add(Me.c1Monto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodInstitucion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudPorcPatrono)
        Me.Controls.Add(Me.txtNombreInstitucion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudPorcTrabajador)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(493, 258)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(493, 258)
        Me.Name = "frmMsPLPensiones"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Control de Pensiones"
        CType(Me.c1Monto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPorcPatrono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPorcTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim Campos As String, Valores As String, CamposValores As String

            If Me.btnGuardar1.Text = "&Guardar" Then
                Campos = "CodPension,Descripcion,Porcentaje_Empleado,Porcentaje_Patrono,IdCuenta,MontoLimite,Reporte"
                Valores = "'" & Me.txtCodInstitucion.Text.Trim & "','" & Trim(Me.txtNombreInstitucion.Text) & "'," & Me.nudPorcTrabajador.Value & "," & Me.nudPorcPatrono.Value & ",'" & Me.txtCtaContable.Text.Trim & "'," & Me.c1Monto.Value & ",'" & IIf(Me.chkMostrarPlanilla.Checked = True, "1", "0") & "'"
                If oPlan.InsertarPLPensiones(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos NO fueron ingresados correctamente", MsgBoxStyle.Critical, "Módulo - Planilla")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                CamposValores = "Descripcion= '" & Trim(Me.txtNombreInstitucion.Text) & "',Porcentaje_Empleado=" & Me.nudPorcTrabajador.Value & ",Porcentaje_Patrono=" & Me.nudPorcPatrono.Value & ",IdCuenta='" & Me.txtCtaContable.Text.Trim & "',MontoLimite=" & Me.c1Monto.Value & ",Reporte='" & IIf(Me.chkMostrarPlanilla.Checked = True, "1", "0") & "'"
                If oPlan.ModificarPLPensiones(CamposValores, "'" & Trim(Me.txtCodInstitucion.Text) & "'", sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos No fueron modificados correctamente", MsgBoxStyle.Information, "Módulo - Planilla")
                End If

            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

#End Region

End Class
