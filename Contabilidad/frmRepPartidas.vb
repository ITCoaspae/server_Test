Public Class frmRepPartidas
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbtnFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnNumPartida As System.Windows.Forms.RadioButton
    Friend WithEvents txtNumPartidaIni As System.Windows.Forms.TextBox
    Friend WithEvents txtNumPartidaFin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNumPartidaFin = New System.Windows.Forms.TextBox()
        Me.txtNumPartidaIni = New System.Windows.Forms.TextBox()
        Me.rbtnNumPartida = New System.Windows.Forms.RadioButton()
        Me.rbtnFecha = New System.Windows.Forms.RadioButton()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrar1 = New MetroFramework.Controls.MetroButton()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNumPartidaFin)
        Me.GroupBox1.Controls.Add(Me.txtNumPartidaIni)
        Me.GroupBox1.Controls.Add(Me.rbtnNumPartida)
        Me.GroupBox1.Controls.Add(Me.rbtnFecha)
        Me.GroupBox1.Controls.Add(Me.dtpFecIni)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFecFin)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 128)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro"
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(208, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Del:"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(208, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 16)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "al:"
        '
        'txtNumPartidaFin
        '
        Me.txtNumPartidaFin.Location = New System.Drawing.Point(240, 80)
        Me.txtNumPartidaFin.Name = "txtNumPartidaFin"
        Me.txtNumPartidaFin.Size = New System.Drawing.Size(160, 20)
        Me.txtNumPartidaFin.TabIndex = 32
        '
        'txtNumPartidaIni
        '
        Me.txtNumPartidaIni.Location = New System.Drawing.Point(240, 56)
        Me.txtNumPartidaIni.Name = "txtNumPartidaIni"
        Me.txtNumPartidaIni.Size = New System.Drawing.Size(160, 20)
        Me.txtNumPartidaIni.TabIndex = 31
        '
        'rbtnNumPartida
        '
        Me.rbtnNumPartida.ForeColor = System.Drawing.Color.Black
        Me.rbtnNumPartida.Location = New System.Drawing.Point(208, 24)
        Me.rbtnNumPartida.Name = "rbtnNumPartida"
        Me.rbtnNumPartida.Size = New System.Drawing.Size(136, 16)
        Me.rbtnNumPartida.TabIndex = 30
        Me.rbtnNumPartida.Text = "por Número de Partida"
        '
        'rbtnFecha
        '
        Me.rbtnFecha.Checked = True
        Me.rbtnFecha.ForeColor = System.Drawing.Color.Black
        Me.rbtnFecha.Location = New System.Drawing.Point(8, 24)
        Me.rbtnFecha.Name = "rbtnFecha"
        Me.rbtnFecha.Size = New System.Drawing.Size(88, 16)
        Me.rbtnFecha.TabIndex = 29
        Me.rbtnFecha.TabStop = True
        Me.rbtnFecha.Text = "por Fecha"
        '
        'dtpFecIni
        '
        Me.dtpFecIni.CustomFormat = ""
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecIni.Location = New System.Drawing.Point(64, 56)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(128, 20)
        Me.dtpFecIni.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Del día:"
        '
        'dtpFecFin
        '
        Me.dtpFecFin.CustomFormat = ""
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecFin.Location = New System.Drawing.Point(64, 80)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(128, 20)
        Me.dtpFecFin.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "al día:"
        '
        'btnCerrar1
        '
        Me.btnCerrar1.Location = New System.Drawing.Point(365, 197)
        Me.btnCerrar1.Name = "btnCerrar1"
        Me.btnCerrar1.Size = New System.Drawing.Size(73, 28)
        Me.btnCerrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCerrar1.TabIndex = 39
        Me.btnCerrar1.Text = "Cerrar"
        Me.btnCerrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCerrar1.UseSelectable = True
        Me.btnCerrar1.UseStyleColors = True
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(285, 197)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(73, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 38
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'frmRepPartidas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(460, 239)
        Me.Controls.Add(Me.btnCerrar1)
        Me.Controls.Add(Me.btnMostrar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(460, 239)
        Me.MinimumSize = New System.Drawing.Size(460, 239)
        Me.Name = "frmRepPartidas"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Partidas de Diario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region





    Private Sub frmRepPartidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFecIni.Value = Date.Now
        dtpFecFin.Value = Date.Now
    End Sub

    Private Sub rbtnFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnFecha.CheckedChanged
        Me.txtNumPartidaIni.Text = ""
        Me.txtNumPartidaFin.Text = ""
        Me.txtNumPartidaFin.Enabled = False
        Me.txtNumPartidaIni.Enabled = False
        Me.dtpFecIni.Enabled = True
        Me.dtpFecFin.Enabled = True
    End Sub

    Private Sub rbtnNumPartida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnNumPartida.CheckedChanged
        Me.txtNumPartidaIni.Text = ""
        Me.txtNumPartidaFin.Text = ""
        Me.txtNumPartidaFin.Enabled = True
        Me.txtNumPartidaIni.Enabled = True
        Me.dtpFecIni.Enabled = False
        Me.dtpFecFin.Enabled = False
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Dim oRep As wrConta.wsLibContab = New wrConta.wsLibContab, ds As New Data.DataSet

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim ofrm As New frmVisorRep
            'ofrm.Reporte = AlcalaLibs.Contabilidad.clsContab.ReportesContabilidad.PartidasDiario
            ofrm.Reporte = sifLib.Contabilidad.clsContabs.ReportesContabilidad.PartidasDiario
            ofrm.FechaIni = dtpFecIni.Value
            ofrm.sFechaI = dtpFecIni.Value.ToString
            ofrm.FechaFin = dtpFecFin.Value
            ofrm.sFechaF = dtpFecFin.Value.ToString
            ofrm.NumPartidaIni = Me.txtNumPartidaIni.Text.Trim
            ofrm.NumPartidaFin = Me.txtNumPartidaFin.Text.Trim
            ofrm.MdiParent = ofrmMain
            ofrm.Show()
            Me.Cursor = Cursors.Default
            Me.Close()

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("No hay datos disponibles.", "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar1_Click(sender As Object, e As EventArgs) Handles btnCerrar1.Click
        Me.Dispose()
    End Sub
End Class
