Public Class frmRepMovxCta
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents txtCtaFin As TextBox
    Friend WithEvents txtCtaIni As TextBox
    Dim contabilidad As New wrConta.wsLibContab

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
    Friend WithEvents btnCerrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents dtpFechaIni As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFechaFin As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroRadioButton2 As MetroFramework.Controls.MetroRadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCerrar1 = New MetroFramework.Controls.MetroButton()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.dtpFechaIni = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFechaFin = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroRadioButton2 = New MetroFramework.Controls.MetroRadioButton()
        Me.txtCtaFin = New System.Windows.Forms.TextBox()
        Me.txtCtaIni = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCerrar1
        '
        Me.btnCerrar1.Location = New System.Drawing.Point(371, 360)
        Me.btnCerrar1.Name = "btnCerrar1"
        Me.btnCerrar1.Size = New System.Drawing.Size(88, 32)
        Me.btnCerrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCerrar1.TabIndex = 13
        Me.btnCerrar1.Text = "Cerrar"
        Me.btnCerrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCerrar1.UseSelectable = True
        Me.btnCerrar1.UseStyleColors = True
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(277, 360)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(88, 32)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 12
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 24
        Me.MetroComboBox1.Location = New System.Drawing.Point(23, 228)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(436, 30)
        Me.MetroComboBox1.TabIndex = 7
        Me.MetroComboBox1.UseSelectable = True
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(23, 116)
        Me.dtpFechaIni.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(436, 30)
        Me.dtpFechaIni.TabIndex = 3
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 205)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(113, 20)
        Me.MetroLabel1.TabIndex = 6
        Me.MetroLabel1.Text = "Centro de Costo:"
        '
        'MetroRadioButton1
        '
        Me.MetroRadioButton1.AutoSize = True
        Me.MetroRadioButton1.Location = New System.Drawing.Point(23, 73)
        Me.MetroRadioButton1.Name = "MetroRadioButton1"
        Me.MetroRadioButton1.Size = New System.Drawing.Size(127, 17)
        Me.MetroRadioButton1.TabIndex = 0
        Me.MetroRadioButton1.Text = "Todas las cuentas"
        Me.MetroRadioButton1.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(23, 93)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(85, 20)
        Me.MetroLabel2.TabIndex = 2
        Me.MetroLabel2.Text = "Fecha Inicio:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(23, 149)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(71, 20)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Fecha Fin:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(23, 172)
        Me.dtpFechaFin.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(436, 30)
        Me.dtpFechaFin.TabIndex = 5
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(23, 261)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(33, 20)
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "Del:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(23, 309)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(24, 20)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Al:"
        '
        'MetroRadioButton2
        '
        Me.MetroRadioButton2.AutoSize = True
        Me.MetroRadioButton2.Location = New System.Drawing.Point(156, 73)
        Me.MetroRadioButton2.Name = "MetroRadioButton2"
        Me.MetroRadioButton2.Size = New System.Drawing.Size(204, 17)
        Me.MetroRadioButton2.TabIndex = 1
        Me.MetroRadioButton2.Text = "Filtrar por cuenta en especifico"
        Me.MetroRadioButton2.UseSelectable = True
        '
        'txtCtaFin
        '
        Me.txtCtaFin.Location = New System.Drawing.Point(23, 332)
        Me.txtCtaFin.Name = "txtCtaFin"
        Me.txtCtaFin.Size = New System.Drawing.Size(436, 22)
        Me.txtCtaFin.TabIndex = 11
        '
        'txtCtaIni
        '
        Me.txtCtaIni.Location = New System.Drawing.Point(23, 284)
        Me.txtCtaIni.Name = "txtCtaIni"
        Me.txtCtaIni.Size = New System.Drawing.Size(436, 22)
        Me.txtCtaIni.TabIndex = 9
        '
        'frmRepMovxCta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(504, 469)
        Me.Controls.Add(Me.btnCerrar1)
        Me.Controls.Add(Me.txtCtaFin)
        Me.Controls.Add(Me.btnMostrar1)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.txtCtaIni)
        Me.Controls.Add(Me.MetroRadioButton1)
        Me.Controls.Add(Me.MetroRadioButton2)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRepMovxCta"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reporte - Movimientos por Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmRepMovxCta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        llencarCC()
    End Sub
    Private Sub llencarCC()
        Me.MetroComboBox1.DisplayMember = "descripcion"
        Me.MetroComboBox1.ValueMember = "Cod_Ccosto"
        Dim dts As New DataSet
        dts = contabilidad.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "cod_Ccosto,descripcion", "", "descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables(0).Rows.Count > 0 Then
            Me.MetroComboBox1.DataSource = dts.Tables(0)
        End If
    End Sub


    'Private Sub rbtnTodasCuentas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    txtCuenta.Enabled = rbtnPorCuenta.Checked
    '    txtAl.Enabled = rbtnPorCuenta.Checked
    'End Sub

    'Private Sub rbtnPorCuenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    txtCuenta.Enabled = rbtnPorCuenta.Checked
    '    txtAl.Enabled = rbtnPorCuenta.Checked
    'End Sub




    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try
            Dim ofrm As frmVisor
            Dim oPr As New wrConta.wsLibContab, ds As New System.Data.DataSet

            ds = oPr.RepMovxCta(dtpFechaIni.Value.ToShortDateString, dtpFechaFin.Value.ToShortDateString, txtCtaIni.Text.Trim, txtCtaFin.Text.Trim, sUsuario, sPassword, sSucursal)
            ofrm = New frmVisor(ds, 4, 0)
            ofrm.Text = "Reporte - Movimiento por Cuenta"
            ofrm.TopMost = True
            ofrm.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("No hay datos disponibles.", "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnCerrar1_Click(sender As Object, e As EventArgs) Handles btnCerrar1.Click
        Me.Dispose()
    End Sub

    Private Sub MetroRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroRadioButton1.CheckedChanged
        If MetroRadioButton1.Checked = True Then
            txtCtaIni.Text = ""
            txtCtaFin.Text = ""
            txtCtaFin.Enabled = False
            txtCtaIni.Enabled = False

        End If
    End Sub

    Private Sub MetroRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles MetroRadioButton2.CheckedChanged
        If Me.MetroRadioButton2.Checked = True Then
            txtCtaIni.Text = ""
            txtCtaFin.Text = ""
            txtCtaFin.Enabled = True
            txtCtaIni.Enabled = True
        End If
    End Sub



    Private Sub txtCtaIni_DoubleClick(sender As Object, e As EventArgs) Handles txtCtaIni.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Contable"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatContab("idCuenta,Descripcion", "", " idCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCtaIni.Text = ofrm.Resultado.Trim

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCtaFin_DoubleClick(sender As Object, e As EventArgs) Handles txtCtaFin.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Contable"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatContab("idCuenta,Descripcion", "", " idCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCtaFin.Text = ofrm.Resultado.Trim

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
