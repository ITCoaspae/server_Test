Public Class frmRepEstResult
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCerrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents dtpFecIni As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.btnCerrar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'dtpFecFin
        '
        Me.dtpFecFin.CustomFormat = "MMMM/yyyy"
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecFin.Location = New System.Drawing.Point(94, 86)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(168, 20)
        Me.dtpFecFin.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 23)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "al Mes:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Del Mes:"
        '
        'dtpFecIni
        '
        Me.dtpFecIni.CustomFormat = "MMMM/yyyy"
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecIni.Location = New System.Drawing.Point(94, 60)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(168, 20)
        Me.dtpFecIni.TabIndex = 24
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(110, 112)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(73, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 34
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'btnCerrar1
        '
        Me.btnCerrar1.Location = New System.Drawing.Point(189, 112)
        Me.btnCerrar1.Name = "btnCerrar1"
        Me.btnCerrar1.Size = New System.Drawing.Size(73, 28)
        Me.btnCerrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCerrar1.TabIndex = 35
        Me.btnCerrar1.Text = "Cerrar"
        Me.btnCerrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCerrar1.UseSelectable = True
        Me.btnCerrar1.UseStyleColors = True
        '
        'frmRepEstResult
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(298, 152)
        Me.Controls.Add(Me.btnCerrar1)
        Me.Controls.Add(Me.btnMostrar1)
        Me.Controls.Add(Me.dtpFecIni)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecFin)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(298, 152)
        Me.MinimumSize = New System.Drawing.Size(298, 152)
        Me.Name = "frmRepEstResult"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Estado de Resultados"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmRepEstResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFecIni.Value = Date.Now
        dtpFecFin.Value = Date.Now
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Dim oRep As wrConta.wsLibContab = New wrConta.wsLibContab, ds As New Data.DataSet
        Try
            Me.Cursor = Cursors.WaitCursor
            ds = oRep.GeneraEstRes(Month(Me.dtpFecIni.Value), Month(Me.dtpFecFin.Value), Me.dtpFecFin.Value.Year, 0, 3, 5,
                                   sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 3, 0)
            ofrm.Show()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar1_Click(sender As Object, e As EventArgs) Handles btnCerrar1.Click
        Me.Dispose()
    End Sub
End Class
