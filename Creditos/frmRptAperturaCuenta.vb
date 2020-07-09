Public Class frmRptAperturaCuenta
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtEjecMercadeo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEjecMercadeo As System.Windows.Forms.TextBox
    Friend WithEvents btProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents chkTodosEjecutivos As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkTodosEjecutivos = New System.Windows.Forms.CheckBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtEjecMercadeo = New System.Windows.Forms.TextBox()
        Me.txtCodEjecMercadeo = New System.Windows.Forms.TextBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.txtTipoCredito = New System.Windows.Forms.TextBox()
        Me.txtCodTipoCredito = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'chkTodosEjecutivos
        '
        Me.chkTodosEjecutivos.Checked = True
        Me.chkTodosEjecutivos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTodosEjecutivos.Location = New System.Drawing.Point(26, 135)
        Me.chkTodosEjecutivos.Name = "chkTodosEjecutivos"
        Me.chkTodosEjecutivos.Size = New System.Drawing.Size(160, 18)
        Me.chkTodosEjecutivos.TabIndex = 4
        Me.chkTodosEjecutivos.Text = "&Todos los Ejecutivos"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(23, 161)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(88, 16)
        Me.Label46.TabIndex = 138
        Me.Label46.Text = "Cód. Ejecutivo:"
        '
        'txtEjecMercadeo
        '
        Me.txtEjecMercadeo.BackColor = System.Drawing.Color.White
        Me.txtEjecMercadeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEjecMercadeo.Enabled = False
        Me.txtEjecMercadeo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecMercadeo.Location = New System.Drawing.Point(199, 159)
        Me.txtEjecMercadeo.MaxLength = 110
        Me.txtEjecMercadeo.Name = "txtEjecMercadeo"
        Me.txtEjecMercadeo.ReadOnly = True
        Me.txtEjecMercadeo.Size = New System.Drawing.Size(293, 20)
        Me.txtEjecMercadeo.TabIndex = 137
        '
        'txtCodEjecMercadeo
        '
        Me.txtCodEjecMercadeo.BackColor = System.Drawing.Color.White
        Me.txtCodEjecMercadeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEjecMercadeo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodEjecMercadeo.Location = New System.Drawing.Point(121, 159)
        Me.txtCodEjecMercadeo.MaxLength = 10
        Me.txtCodEjecMercadeo.Name = "txtCodEjecMercadeo"
        Me.txtCodEjecMercadeo.ReadOnly = True
        Me.txtCodEjecMercadeo.Size = New System.Drawing.Size(72, 20)
        Me.txtCodEjecMercadeo.TabIndex = 5
        '
        'chkTodos
        '
        Me.chkTodos.Checked = True
        Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTodos.Location = New System.Drawing.Point(26, 86)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(160, 17)
        Me.chkTodos.TabIndex = 2
        Me.chkTodos.Text = "Todos los tipos de crédito"
        '
        'txtTipoCredito
        '
        Me.txtTipoCredito.BackColor = System.Drawing.Color.White
        Me.txtTipoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCredito.Enabled = False
        Me.txtTipoCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCredito.Location = New System.Drawing.Point(199, 109)
        Me.txtTipoCredito.MaxLength = 100
        Me.txtTipoCredito.Name = "txtTipoCredito"
        Me.txtTipoCredito.ReadOnly = True
        Me.txtTipoCredito.Size = New System.Drawing.Size(293, 20)
        Me.txtTipoCredito.TabIndex = 3
        '
        'txtCodTipoCredito
        '
        Me.txtCodTipoCredito.BackColor = System.Drawing.Color.White
        Me.txtCodTipoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTipoCredito.Location = New System.Drawing.Point(121, 109)
        Me.txtCodTipoCredito.MaxLength = 10
        Me.txtCodTipoCredito.Name = "txtCodTipoCredito"
        Me.txtCodTipoCredito.ReadOnly = True
        Me.txtCodTipoCredito.Size = New System.Drawing.Size(72, 20)
        Me.txtCodTipoCredito.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Tipo de Crédito:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(296, 60)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(111, 20)
        Me.dtpFechaFin.TabIndex = 1
        Me.dtpFechaFin.Value = New Date(2006, 12, 19, 16, 42, 14, 734)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(226, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Fecha Fin:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(109, 60)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(111, 20)
        Me.dtpFechaInicio.TabIndex = 0
        Me.dtpFechaInicio.Value = New Date(2006, 12, 19, 16, 42, 14, 734)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha Inicio:"
        '
        'btProcesar1
        '
        Me.btProcesar1.Location = New System.Drawing.Point(417, 185)
        Me.btProcesar1.Name = "btProcesar1"
        Me.btProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btProcesar1.TabIndex = 177
        Me.btProcesar1.Text = "Procesar"
        Me.btProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btProcesar1.UseSelectable = True
        Me.btProcesar1.UseStyleColors = True
        '
        'frmRptAperturaCuenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(515, 246)
        Me.Controls.Add(Me.txtEjecMercadeo)
        Me.Controls.Add(Me.Label46)
        Me.Controls.Add(Me.txtCodEjecMercadeo)
        Me.Controls.Add(Me.chkTodosEjecutivos)
        Me.Controls.Add(Me.btProcesar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTipoCredito)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.txtCodTipoCredito)
        Me.Controls.Add(Me.Label4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(515, 246)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(515, 246)
        Me.Name = "frmRptAperturaCuenta"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Apertura Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub frmRptAperturaCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFechaInicio.Value = Now
        Me.dtpFechaFin.Value = Now
    End Sub


    Private Sub txtCodTipoCredito_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoCredito.DoubleClick

        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Tipo de Crédito"
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarTipoCreditos("*", "", "CodTipoCredito", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodTipoCredito.Text = ofrm.Resultado.Trim
            txtTipoCredito.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodEjecMercadeo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEjecMercadeo.DoubleClick
        Dim ofrm As New frmAGenerico
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet

        ofrm.Text = "Buscar Ejecutivos de Mercadeo"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Try
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarEjecutivosMercadeoxNombre("", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodEjecMercadeo.Text = ofrm.Resultado.Trim
            txtEjecMercadeo.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkTodosEjecutivos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodosEjecutivos.CheckedChanged
        txtCodEjecMercadeo.ReadOnly = chkTodosEjecutivos.Checked
    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        txtCodTipoCredito.ReadOnly = chkTodos.Checked
    End Sub

    Private Sub btProcesar1_Click(sender As Object, e As EventArgs) Handles btProcesar1.Click
        Dim ds As New Data.DataSet
        Try
            Dim oItem As New wrPrestamo.wsLibPrest
            ds = oItem.AperturaPrestamos(Me.dtpFechaInicio.Value.ToShortDateString, Me.dtpFechaFin.Value.ToShortDateString, Me.chkTodos.Checked, Me.txtCodTipoCredito.Text.Trim, Me.chkTodosEjecutivos.Checked, Me.txtCodEjecMercadeo.Text.Trim, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 47, 0)
            ofrm.ShowDialog()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class