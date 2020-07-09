Public Class frmRepAuxMayor
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
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "MMMM/yyyy"
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(19, 52)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(169, 22)
        Me.dtpFecha.TabIndex = 32
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.btnProcesar1)
        Me.MetroPanel1.Controls.Add(Me.dtpFecha)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(23, 63)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(348, 88)
        Me.MetroPanel1.TabIndex = 1
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(210, 51)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(110, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 33
        Me.btnProcesar1.Text = "Procesar Reporte"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(19, 13)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(169, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Seleccione mes del reporte"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroLabel1.UseStyleColors = True
        '
        'frmRepAuxMayor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(410, 170)
        Me.Controls.Add(Me.MetroPanel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(410, 170)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(410, 170)
        Me.Name = "frmRepAuxMayor"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reporte - Libro Auxiliar de Mayor"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Dim ofrm As New frmVisorRep, iDias As Integer

        ofrm.Reporte = sifLib.Contabilidad.clsContabs.ReportesContabilidad.AuxiliardeMayor
        ofrm.Mes = Me.dtpFecha.Value.Month()
        ofrm.Annio = Me.dtpFecha.Value.Year
        ofrm.FechaIni = CDate("01/" & Me.dtpFecha.Value.Month.ToString & "/" & Me.dtpFecha.Value.Year.ToString)
        iDias = Date.DaysInMonth(Me.dtpFecha.Value.Year, Me.dtpFecha.Value.Month)
        ofrm.FechaFin = CDate(iDias.ToString & "/" & Me.dtpFecha.Value.Month.ToString & "/" & Me.dtpFecha.Value.Year.ToString) '.AddDays(1)

        ofrm.Show()

    End Sub
End Class
