Public Class frmMsPLRecibosPago
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDepto = New System.Windows.Forms.TextBox()
        Me.txtCodDepartamento = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(312, 82)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(103, 20)
        Me.dtpFechaFin.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(282, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "al"
        '
        'chkTodos
        '
        Me.chkTodos.Checked = True
        Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTodos.ForeColor = System.Drawing.Color.Black
        Me.chkTodos.Location = New System.Drawing.Point(421, 85)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(72, 16)
        Me.chkTodos.TabIndex = 1
        Me.chkTodos.Text = "&Todos"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(173, 82)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(103, 20)
        Me.dtpFechaInicio.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(23, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Fecha Proceso de Planilla:"
        '
        'txtDepto
        '
        Me.txtDepto.BackColor = System.Drawing.Color.White
        Me.txtDepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepto.Location = New System.Drawing.Point(194, 56)
        Me.txtDepto.MaxLength = 100
        Me.txtDepto.Name = "txtDepto"
        Me.txtDepto.ReadOnly = True
        Me.txtDepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDepto.Size = New System.Drawing.Size(299, 20)
        Me.txtDepto.TabIndex = 85
        '
        'txtCodDepartamento
        '
        Me.txtCodDepartamento.BackColor = System.Drawing.Color.White
        Me.txtCodDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDepartamento.Location = New System.Drawing.Point(116, 56)
        Me.txtCodDepartamento.MaxLength = 10
        Me.txtCodDepartamento.Name = "txtCodDepartamento"
        Me.txtCodDepartamento.ReadOnly = True
        Me.txtCodDepartamento.Size = New System.Drawing.Size(72, 20)
        Me.txtCodDepartamento.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Departamento:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(418, 107)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 140
        Me.btnGuardar1.Text = "&Generar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsPLRecibosPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(515, 181)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodDepartamento)
        Me.Controls.Add(Me.txtDepto)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(515, 181)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(515, 181)
        Me.Name = "frmMsPLRecibosPago"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Generación - Recibos de Pago"
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

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim ds As New DataSet, dv As New DataView
            If Me.chkTodos.Checked = True Then
                ds = oPlan.GeneraPlanilla("1", "", Me.dtpFechaInicio.Value, Me.dtpFechaFin.Value, False, "", "", "", Now, sUsuario, sPassword, sSucursal, 0, 0)
            Else
                ds = oPlan.GeneraPlanilla("1", Me.txtCodDepartamento.Text.Trim, Me.dtpFechaInicio.Value, Me.dtpFechaFin.Value, False, "", "", "", Now, sUsuario, sPassword, sSucursal, 0, 0)
            End If
            Dim ofrm As New frmVisor(ds, 206, 0)
            ofrm.Show()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
