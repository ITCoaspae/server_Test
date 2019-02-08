<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAsocTransferenciasAutomaticas
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtAsociado = New MetroFramework.Controls.MetroTextBox()
        Me.txtOrigen = New MetroFramework.Controls.MetroTextBox()
        Me.txtDestino = New MetroFramework.Controls.MetroTextBox()
        Me.dtpFecha = New MetroFramework.Controls.MetroDateTime()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.btnBuscar = New MetroFramework.Controls.MetroButton()
        Me.rbAsociado = New MetroFramework.Controls.MetroRadioButton()
        Me.rbCtaOrigen = New MetroFramework.Controls.MetroRadioButton()
        Me.rbCtaDestino = New MetroFramework.Controls.MetroRadioButton()
        Me.rbFechaCrea = New MetroFramework.Controls.MetroRadioButton()
        Me.rbTodos = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(23, 308)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(818, 236)
        Me.DataGridView1.TabIndex = 0
        '
        'txtAsociado
        '
        Me.txtAsociado.Lines = New String(-1) {}
        Me.txtAsociado.Location = New System.Drawing.Point(23, 108)
        Me.txtAsociado.MaxLength = 32767
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAsociado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAsociado.SelectedText = ""
        Me.txtAsociado.Size = New System.Drawing.Size(404, 23)
        Me.txtAsociado.TabIndex = 2
        Me.txtAsociado.UseSelectable = True
        '
        'txtOrigen
        '
        Me.txtOrigen.Lines = New String(-1) {}
        Me.txtOrigen.Location = New System.Drawing.Point(23, 160)
        Me.txtOrigen.MaxLength = 32767
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOrigen.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOrigen.SelectedText = ""
        Me.txtOrigen.Size = New System.Drawing.Size(404, 23)
        Me.txtOrigen.TabIndex = 4
        Me.txtOrigen.UseSelectable = True
        '
        'txtDestino
        '
        Me.txtDestino.Lines = New String(-1) {}
        Me.txtDestino.Location = New System.Drawing.Point(433, 160)
        Me.txtDestino.MaxLength = 32767
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDestino.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDestino.SelectedText = ""
        Me.txtDestino.Size = New System.Drawing.Size(404, 23)
        Me.txtDestino.TabIndex = 6
        Me.txtDestino.UseSelectable = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(23, 212)
        Me.dtpFecha.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(404, 30)
        Me.dtpFecha.TabIndex = 8
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(23, 269)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 33)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 49
        Me.btnConsultar1.Text = "Agregar"
        Me.btnConsultar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(215, 269)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(90, 33)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 50
        Me.MetroButton2.Text = "Consultar"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(119, 269)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(90, 33)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 51
        Me.MetroButton3.Text = "Modificar"
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(433, 212)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(90, 33)
        Me.btnBuscar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnBuscar.TabIndex = 52
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnBuscar.UseSelectable = True
        Me.btnBuscar.UseStyleColors = True
        '
        'rbAsociado
        '
        Me.rbAsociado.AutoSize = True
        Me.rbAsociado.Location = New System.Drawing.Point(23, 85)
        Me.rbAsociado.Name = "rbAsociado"
        Me.rbAsociado.Size = New System.Drawing.Size(81, 17)
        Me.rbAsociado.TabIndex = 53
        Me.rbAsociado.Text = "Asociado:"
        Me.rbAsociado.UseSelectable = True
        '
        'rbCtaOrigen
        '
        Me.rbCtaOrigen.AutoSize = True
        Me.rbCtaOrigen.Location = New System.Drawing.Point(23, 137)
        Me.rbCtaOrigen.Name = "rbCtaOrigen"
        Me.rbCtaOrigen.Size = New System.Drawing.Size(111, 17)
        Me.rbCtaOrigen.TabIndex = 54
        Me.rbCtaOrigen.Text = "Cuenta Origen:"
        Me.rbCtaOrigen.UseSelectable = True
        '
        'rbCtaDestino
        '
        Me.rbCtaDestino.AutoSize = True
        Me.rbCtaDestino.Location = New System.Drawing.Point(433, 137)
        Me.rbCtaDestino.Name = "rbCtaDestino"
        Me.rbCtaDestino.Size = New System.Drawing.Size(112, 17)
        Me.rbCtaDestino.TabIndex = 55
        Me.rbCtaDestino.Text = "Cuenta Destino"
        Me.rbCtaDestino.UseSelectable = True
        '
        'rbFechaCrea
        '
        Me.rbFechaCrea.AutoSize = True
        Me.rbFechaCrea.Location = New System.Drawing.Point(23, 189)
        Me.rbFechaCrea.Name = "rbFechaCrea"
        Me.rbFechaCrea.Size = New System.Drawing.Size(115, 17)
        Me.rbFechaCrea.TabIndex = 56
        Me.rbFechaCrea.Text = "Fecha Creación:"
        Me.rbFechaCrea.UseSelectable = True
        '
        'rbTodos
        '
        Me.rbTodos.AutoSize = True
        Me.rbTodos.Location = New System.Drawing.Point(433, 85)
        Me.rbTodos.Name = "rbTodos"
        Me.rbTodos.Size = New System.Drawing.Size(111, 17)
        Me.rbTodos.TabIndex = 57
        Me.rbTodos.Text = "Mostrar Todos"
        Me.rbTodos.UseSelectable = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(311, 269)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(212, 33)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 58
        Me.MetroButton1.Text = "Suspender Transferencia"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'frmAsocTransferenciasAutomaticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 663)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.rbTodos)
        Me.Controls.Add(Me.rbFechaCrea)
        Me.Controls.Add(Me.rbCtaDestino)
        Me.Controls.Add(Me.rbCtaOrigen)
        Me.Controls.Add(Me.rbAsociado)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtDestino)
        Me.Controls.Add(Me.txtOrigen)
        Me.Controls.Add(Me.txtAsociado)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmAsocTransferenciasAutomaticas"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Administración Transferencias Automaticas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtAsociado As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtOrigen As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDestino As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtpFecha As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnBuscar As MetroFramework.Controls.MetroButton
    Friend WithEvents rbAsociado As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbCtaOrigen As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbCtaDestino As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbFechaCrea As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbTodos As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
