Public Class frmMsPLPlanillaVacacion
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Dim oPlan As New wrPlanilla.wsLibPlanilla

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
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDepto As System.Windows.Forms.TextBox
    Friend WithEvents txtCodDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDepto = New System.Windows.Forms.TextBox()
        Me.txtCodDepartamento = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodTipoPlanilla = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(297, 134)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaFin.TabIndex = 81
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(267, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "al"
        '
        'chkTodos
        '
        Me.chkTodos.Location = New System.Drawing.Point(26, 84)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(192, 16)
        Me.chkTodos.TabIndex = 78
        Me.chkTodos.Text = "&Todos los Departamentos"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(173, 134)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(88, 20)
        Me.dtpFechaInicio.TabIndex = 80
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Fecha proceso de Planilla:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDepto
        '
        Me.txtDepto.BackColor = System.Drawing.Color.White
        Me.txtDepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepto.Location = New System.Drawing.Point(219, 105)
        Me.txtDepto.MaxLength = 100
        Me.txtDepto.Name = "txtDepto"
        Me.txtDepto.ReadOnly = True
        Me.txtDepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDepto.Size = New System.Drawing.Size(336, 20)
        Me.txtDepto.TabIndex = 85
        '
        'txtCodDepartamento
        '
        Me.txtCodDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDepartamento.Location = New System.Drawing.Point(157, 105)
        Me.txtCodDepartamento.MaxLength = 10
        Me.txtCodDepartamento.Name = "txtCodDepartamento"
        Me.txtCodDepartamento.Size = New System.Drawing.Size(56, 20)
        Me.txtCodDepartamento.TabIndex = 77
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(219, 58)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(336, 20)
        Me.txtDescripcion.TabIndex = 82
        '
        'txtCodTipoPlanilla
        '
        Me.txtCodTipoPlanilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoPlanilla.Location = New System.Drawing.Point(157, 58)
        Me.txtCodTipoPlanilla.MaxLength = 10
        Me.txtCodTipoPlanilla.Name = "txtCodTipoPlanilla"
        Me.txtCodTipoPlanilla.Size = New System.Drawing.Size(56, 20)
        Me.txtCodTipoPlanilla.TabIndex = 76
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Código de Departamento:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 18)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Tipo Planilla:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(480, 131)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 137
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsPLPlanillaVacacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(578, 212)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDepto)
        Me.Controls.Add(Me.txtCodTipoPlanilla)
        Me.Controls.Add(Me.txtCodDepartamento)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(578, 212)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(578, 212)
        Me.Name = "frmMsPLPlanillaVacacion"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Planilla de Vacaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub txtCodDepartamento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodDepartamento.DoubleClick
        Dim ofrm As New frmAGenerico
        Dim ds As New Data.DataSet

        Try
            ofrm.Text = "Buscar Departamentos..."
            ds = oPlan.ConsultarPLDepartamentos("*", "", "CodDepartamento", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodDepartamento.Text = ofrm.Resultado2.Trim
            Me.txtDepto.Text = ofrm.Resultado3.Trim
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub txtCodTipoPlanilla_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoPlanilla.DoubleClick
        Dim ofrm As New frmAGenerico
        Dim ds As New Data.DataSet
        Dim sResultado1, sResultado2 As String

        Try
            ofrm.Text = "Buscar Tipos de Planilla..."
            ds = oPlan.ConsultarPLTipoPlanilla("*", "", "CodTipoPlanilla", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            sResultado1 = ofrm.Resultado.Trim
            sResultado2 = ofrm.Resultado2.Trim
            Me.txtCodTipoPlanilla.Text = sResultado1
            Me.txtDescripcion.Text = sResultado2
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub



    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked = True Then
            Me.txtCodDepartamento.ReadOnly = True
        Else
            Me.txtCodDepartamento.ReadOnly = False
        End If
    End Sub

    Private Sub frmMsPLPlanillaVacacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFechaInicio.Value = Now
        Me.dtpFechaFin.Value = Now
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim ds As New DataSet
            If Me.txtCodTipoPlanilla.Text.Trim = "" Then
                MsgBox("Seleccione el tipo de planilla.", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Generación de Planillas")
                Exit Sub
            End If
            If Me.chkTodos.Checked = True Then
                ds = oPlan.Vacaciones(Me.txtCodTipoPlanilla.Text.Trim, "", Me.dtpFechaInicio.Value, Me.dtpFechaFin.Value, sUsuario, sPassword, sSucursal)
            Else
                ds = oPlan.Vacaciones(Me.txtCodTipoPlanilla.Text.Trim, Me.txtCodDepartamento.Text.Trim, Me.dtpFechaInicio.Value, Me.dtpFechaFin.Value, sUsuario, sPassword, sSucursal)
            End If
            Dim ofrm As New frmVisor(ds, 4, 0)
            ofrm.Show()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
