Public Class frmMsPartidaApertura
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

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCerrar1 As MetroFramework.Controls.MetroButton

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.btnCerrar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(266, 19)
        Me.MetroLabel1.TabIndex = 36
        Me.MetroLabel1.Text = "Este proceso genera la partida de apertura."
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(164, 109)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 37
        Me.btnProcesar1.Text = "Procesar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'btnCerrar1
        '
        Me.btnCerrar1.Location = New System.Drawing.Point(245, 109)
        Me.btnCerrar1.Name = "btnCerrar1"
        Me.btnCerrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnCerrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCerrar1.TabIndex = 38
        Me.btnCerrar1.Text = "Cerrar"
        Me.btnCerrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCerrar1.UseSelectable = True
        Me.btnCerrar1.UseStyleColors = True
        '
        'frmMsPartidaApertura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(343, 160)
        Me.Controls.Add(Me.btnCerrar1)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.MetroLabel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(343, 160)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(343, 160)
        Me.Name = "frmMsPartidaApertura"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Partida de Apertura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Dim oContab As New wrConta.wsLibContab, vResultado As String
        If MsgBox("¿Está seguro que desea generar la Partida de Apertura?", MsgBoxStyle.YesNo, "Generación Partida de Apertura") = MsgBoxResult.Yes Then
            Me.Cursor = Cursors.WaitCursor
            vResultado = oContab.PartidaApertura("01/01/2006", sUsuario, sPassword, sSucursal)
            If vResultado.Trim <> "" Then
                Me.Cursor = Cursors.Default
                MsgBox(vResultado, MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Validación del Sistema")
            Else
                MsgBox("Proceso realizado con éxito!", MsgBoxStyle.Critical And MsgBoxStyle.OkOnly, "Partida de Apertura")
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub btnCerrar1_Click(sender As Object, e As EventArgs) Handles btnCerrar1.Click
        Me.Dispose()
    End Sub
End Class
