Public Class frmMsCierreContable
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form : 
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCerrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents dtYear As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtYear = New System.Windows.Forms.DateTimePicker()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.btnCerrar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 23)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Año:"
        '
        'dtYear
        '
        Me.dtYear.CustomFormat = "yyyy"
        Me.dtYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtYear.Location = New System.Drawing.Point(61, 97)
        Me.dtYear.Name = "dtYear"
        Me.dtYear.Size = New System.Drawing.Size(72, 20)
        Me.dtYear.TabIndex = 34
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(248, 19)
        Me.MetroLabel1.TabIndex = 35
        Me.MetroLabel1.Text = "Este proceso genera la partida de cierre."
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(110, 135)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 36
        Me.btnProcesar1.Text = "Procesar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'btnCerrar1
        '
        Me.btnCerrar1.Location = New System.Drawing.Point(202, 135)
        Me.btnCerrar1.Name = "btnCerrar1"
        Me.btnCerrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnCerrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCerrar1.TabIndex = 37
        Me.btnCerrar1.Text = "Cerrar"
        Me.btnCerrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCerrar1.UseSelectable = True
        Me.btnCerrar1.UseStyleColors = True
        '
        'frmMsCierreContable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(300, 186)
        Me.Controls.Add(Me.btnCerrar1)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.dtYear)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 186)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(300, 186)
        Me.Name = "frmMsCierreContable"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cierre Contable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click

        Dim oContab As New wrConta.wsLibContab, vResultado As String
        If MsgBox("¿Está seguro que desea generar la Partida de Cierre?", MsgBoxStyle.YesNo, "Generación Partida de Cierre") = MsgBoxResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            Dim pFecha As String
            pFecha = "31/12/" & Me.dtYear.Value.Year
            vResultado = oContab.CierreContable(pFecha, sUsuario, sPassword, sSucursal)
            If vResultado.Trim <> "" Then
                Me.Cursor = Cursors.Default
                MsgBox(vResultado, MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Validación del Sistema")
            Else
                MsgBox("Proceso realizado con éxito!", MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Cierre Contable")
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnCerrar1_Click(sender As Object, e As EventArgs) Handles btnCerrar1.Click
        Me.Dispose()
    End Sub
End Class
