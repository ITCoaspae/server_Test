Public Class frmMsPLTipoHoraExtra
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
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCtaContable As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidadHoras As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents nudPorcTrabajador As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.nudPorcTrabajador = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantidadHoras = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCtaContable = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodTipo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.nudPorcTrabajador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudPorcTrabajador
        '
        Me.nudPorcTrabajador.Location = New System.Drawing.Point(125, 138)
        Me.nudPorcTrabajador.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.nudPorcTrabajador.Name = "nudPorcTrabajador"
        Me.nudPorcTrabajador.Size = New System.Drawing.Size(140, 20)
        Me.nudPorcTrabajador.TabIndex = 4
        Me.nudPorcTrabajador.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Porcentaje:"
        '
        'txtCantidadHoras
        '
        Me.txtCantidadHoras.Location = New System.Drawing.Point(373, 112)
        Me.txtCantidadHoras.MaxLength = 5
        Me.txtCantidadHoras.Name = "txtCantidadHoras"
        Me.txtCantidadHoras.Size = New System.Drawing.Size(140, 20)
        Me.txtCantidadHoras.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(271, 114)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 16)
        Me.Label11.TabIndex = 117
        Me.Label11.Text = "Cantidad Horas:"
        '
        'txtCtaContable
        '
        Me.txtCtaContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCtaContable.Location = New System.Drawing.Point(125, 112)
        Me.txtCtaContable.MaxLength = 20
        Me.txtCtaContable.Name = "txtCtaContable"
        Me.txtCtaContable.Size = New System.Drawing.Size(140, 20)
        Me.txtCtaContable.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Cuenta Contable:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(125, 86)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(388, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodTipo
        '
        Me.txtCodTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipo.Location = New System.Drawing.Point(125, 60)
        Me.txtCodTipo.MaxLength = 10
        Me.txtCodTipo.Name = "txtCodTipo"
        Me.txtCodTipo.Size = New System.Drawing.Size(140, 20)
        Me.txtCodTipo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Hora Extra:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(438, 138)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 141
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsPLTipoHoraExtra
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(539, 206)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nudPorcTrabajador)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtCantidadHoras)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtCodTipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCtaContable)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescripcion)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(539, 206)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(539, 206)
        Me.Name = "frmMsPLTipoHoraExtra"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Tipo de Hora extra"
        CType(Me.nudPorcTrabajador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub txtCtaContable_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCtaContable.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Contable"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatContab("*", "Final='S'", "idCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCtaContable.Text = ofrm.Resultado.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim Campos, Valores, CamposValores As String
        Try
            If Me.btnGuardar1.Text = "&Guardar" Then
                If Me.txtDescripcion.Text = "" Then
                    MsgBox("Debe de completar todos los campos", MsgBoxStyle.Information, "Módulo - Planilla")
                Else
                    Campos = "Descripcion,IdCuenta,CantidadHoras,Porcentaje"
                    Valores = "'" & Trim(Me.txtDescripcion.Text) & "','" & Me.txtCtaContable.Text.Trim & "'," & Val(Me.txtCantidadHoras.Text) & "," & Me.nudPorcTrabajador.Value & ""
                    If oPlan.InsertarPLTipoHoraExtra(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                        MsgBox("Regsitro ingresado", MsgBoxStyle.Information, "Módulo - Planilla")
                        Me.Dispose()
                    Else
                        MsgBox("Regsitro NO ingresado", MsgBoxStyle.Information, "Módulo - Planilla")
                    End If
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                CamposValores = "Descripcion='" & Trim(Me.txtDescripcion.Text) & "',IdCuenta='" & Me.txtCtaContable.Text.Trim & "',CantidadHoras=" & Val(Me.txtCantidadHoras.Text) & ",Porcentaje=" & Me.nudPorcTrabajador.Value & ""
                If oPlan.ModificarPLTipoHoraExtra(CamposValores, "'" & Trim(Me.txtCodTipo.Text) & "'", sUsuario, sPassword, sSucursal) = True Then
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
End Class
