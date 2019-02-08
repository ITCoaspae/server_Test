Public Class frmRepBcoMovCheques
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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnPorCuenta As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnTodasCuentas As System.Windows.Forms.RadioButton
    Friend WithEvents txtCuenta As C1.Win.C1Input.C1TextBox
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCuenta = New C1.Win.C1Input.C1TextBox()
        Me.rbtnPorCuenta = New System.Windows.Forms.RadioButton()
        Me.rbtnTodasCuentas = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFecha2)
        Me.GroupBox1.Controls.Add(Me.dtpFecha1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 136)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione datos del Reporte"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCuenta)
        Me.GroupBox2.Controls.Add(Me.rbtnPorCuenta)
        Me.GroupBox2.Controls.Add(Me.rbtnTodasCuentas)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 64)
        Me.GroupBox2.TabIndex = 143
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtro"
        '
        'txtCuenta
        '
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Location = New System.Drawing.Point(272, 24)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.NumericInput = False
        Me.txtCuenta.Size = New System.Drawing.Size(192, 20)
        Me.txtCuenta.TabIndex = 141
        Me.txtCuenta.Tag = Nothing
        '
        'rbtnPorCuenta
        '
        Me.rbtnPorCuenta.ForeColor = System.Drawing.Color.Black
        Me.rbtnPorCuenta.Location = New System.Drawing.Point(168, 26)
        Me.rbtnPorCuenta.Name = "rbtnPorCuenta"
        Me.rbtnPorCuenta.Size = New System.Drawing.Size(104, 16)
        Me.rbtnPorCuenta.TabIndex = 142
        Me.rbtnPorCuenta.Text = "Por Cuenta"
        '
        'rbtnTodasCuentas
        '
        Me.rbtnTodasCuentas.Checked = True
        Me.rbtnTodasCuentas.ForeColor = System.Drawing.Color.Black
        Me.rbtnTodasCuentas.Location = New System.Drawing.Point(24, 26)
        Me.rbtnTodasCuentas.Name = "rbtnTodasCuentas"
        Me.rbtnTodasCuentas.Size = New System.Drawing.Size(120, 16)
        Me.rbtnTodasCuentas.TabIndex = 141
        Me.rbtnTodasCuentas.TabStop = True
        Me.rbtnTodasCuentas.Text = "Todas las Cuentas"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Desde Fecha:"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(248, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Hasta la Fecha:"
        '
        'dtpFecha2
        '
        Me.dtpFecha2.CustomFormat = ""
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha2.Location = New System.Drawing.Point(360, 32)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(120, 22)
        Me.dtpFecha2.TabIndex = 33
        '
        'dtpFecha1
        '
        Me.dtpFecha1.CustomFormat = ""
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha1.Location = New System.Drawing.Point(120, 32)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(120, 22)
        Me.dtpFecha1.TabIndex = 32
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(436, 205)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 53
        Me.btnGuardar1.Text = "Mostrar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmRepBcoMovCheques
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(530, 246)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(530, 246)
        Me.MinimumSize = New System.Drawing.Size(530, 246)
        Me.Name = "frmRepBcoMovCheques"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reporte - Cheques Emitidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub rbtnPorCuenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnPorCuenta.CheckedChanged
        txtCuenta.Enabled = rbtnPorCuenta.Checked
    End Sub

    Private Sub rbtnTodasCuentas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnTodasCuentas.CheckedChanged
        txtCuenta.Enabled = rbtnPorCuenta.Checked
    End Sub

    Private Sub frmRepBcoMovCheques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFecha1.Value = Date.Now()
        dtpFecha2.Value = Date.Now()
    End Sub

    Private Sub txtCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuenta.DoubleClick
        Try
            Dim ofrm As New frmAGenerico
            ofrm.Text = "Buscar Cuenta Bancaria"
            Dim oPerif As wrBancos.wsLibBancos, ds As New Data.DataSet
            oPerif = New wrBancos.wsLibBancos
            ds = oPerif.ObtenerCuentaBanco("*", "", "idCtaBanco", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCuenta.Value = ofrm.Resultado.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ofrm As New frmVisorRep
            'ofrm.ReporteBancos = AlcalaLibs.Bancos.clsBCBanco.ReportesBancos.ChequesEmitidos
            ofrm.ReporteBancos = sifLib.Bancos.clsBCBancos.ReportesBancos.ChequesEmitidos
            ofrm.FechaIni = dtpFecha1.Value
            ofrm.sFechaI = dtpFecha1.Value.ToString
            ofrm.FechaFin = dtpFecha2.Value
            ofrm.sFechaF = dtpFecha2.Value.ToString
            ofrm.NumPartidaIni = " "
            ofrm.NumPartidaFin = " "
            ofrm.Todos = Me.rbtnTodasCuentas.Checked
            If ofrm.Todos = False Then
                ofrm.Cuenta = Me.txtCuenta.Text
            Else
                ofrm.Cuenta = " "
            End If
            ofrm.MdiParent = ofrmMain
            ofrm.Show()
            Me.Cursor = Cursors.Default
            Me.Close()

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
