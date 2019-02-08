<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArregloMora
    Inherits MetroFramework.Forms.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.lblInicio = New MetroFramework.Controls.MetroLabel()
        Me.dtpFechaFin = New MetroFramework.Controls.MetroDateTime()
        Me.dtpFechaIni = New MetroFramework.Controls.MetroDateTime()
        Me.MetroRadioButton2 = New MetroFramework.Controls.MetroRadioButton()
        Me.mTxtDui = New MetroFramework.Controls.MetroTextBox()
        Me.mrbDui = New MetroFramework.Controls.MetroRadioButton()
        Me.mTxtCodPrestamo = New MetroFramework.Controls.MetroTextBox()
        Me.mrbCodPrestamo = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Right
        Me.DataGridView1.Location = New System.Drawing.Point(298, 74)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(975, 550)
        Me.DataGridView1.TabIndex = 164
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MetroPanel1.Controls.Add(Me.MetroButton3)
        Me.MetroPanel1.Controls.Add(Me.MetroButton2)
        Me.MetroPanel1.Controls.Add(Me.MetroButton1)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.lblInicio)
        Me.MetroPanel1.Controls.Add(Me.dtpFechaFin)
        Me.MetroPanel1.Controls.Add(Me.dtpFechaIni)
        Me.MetroPanel1.Controls.Add(Me.MetroRadioButton2)
        Me.MetroPanel1.Controls.Add(Me.mTxtDui)
        Me.MetroPanel1.Controls.Add(Me.mrbDui)
        Me.MetroPanel1.Controls.Add(Me.mTxtCodPrestamo)
        Me.MetroPanel1.Controls.Add(Me.mrbCodPrestamo)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(27, 74)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(264, 550)
        Me.MetroPanel1.TabIndex = 166
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroButton1
        '
        Me.MetroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.MetroButton1.Location = New System.Drawing.Point(136, 209)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(112, 32)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 11
        Me.MetroButton1.Text = "Buscar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(16, 173)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(30, 20)
        Me.MetroLabel1.TabIndex = 10
        Me.MetroLabel1.Text = "Fin:"
        '
        'lblInicio
        '
        Me.lblInicio.AutoSize = True
        Me.lblInicio.Location = New System.Drawing.Point(14, 137)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(44, 20)
        Me.lblInicio.TabIndex = 9
        Me.lblInicio.Text = "Inicio:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(64, 173)
        Me.dtpFechaFin.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(184, 30)
        Me.dtpFechaFin.TabIndex = 8
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIni.Location = New System.Drawing.Point(64, 137)
        Me.dtpFechaIni.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(184, 30)
        Me.dtpFechaIni.TabIndex = 7
        '
        'MetroRadioButton2
        '
        Me.MetroRadioButton2.AutoSize = True
        Me.MetroRadioButton2.Location = New System.Drawing.Point(14, 114)
        Me.MetroRadioButton2.Name = "MetroRadioButton2"
        Me.MetroRadioButton2.Size = New System.Drawing.Size(153, 17)
        Me.MetroRadioButton2.TabIndex = 6
        Me.MetroRadioButton2.Text = "Fecha Ingreso Arreglo"
        Me.MetroRadioButton2.UseSelectable = True
        '
        'mTxtDui
        '
        Me.mTxtDui.Lines = New String() {"MetroTextBox1"}
        Me.mTxtDui.Location = New System.Drawing.Point(16, 85)
        Me.mTxtDui.MaxLength = 32767
        Me.mTxtDui.Name = "mTxtDui"
        Me.mTxtDui.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mTxtDui.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mTxtDui.SelectedText = ""
        Me.mTxtDui.Size = New System.Drawing.Size(232, 23)
        Me.mTxtDui.TabIndex = 5
        Me.mTxtDui.Text = "MetroTextBox1"
        Me.mTxtDui.UseSelectable = True
        '
        'mrbDui
        '
        Me.mrbDui.AutoSize = True
        Me.mrbDui.Location = New System.Drawing.Point(14, 62)
        Me.mrbDui.Name = "mrbDui"
        Me.mrbDui.Size = New System.Drawing.Size(48, 17)
        Me.mrbDui.TabIndex = 4
        Me.mrbDui.Text = "DUI:"
        Me.mrbDui.UseSelectable = True
        '
        'mTxtCodPrestamo
        '
        Me.mTxtCodPrestamo.Lines = New String() {"MetroTextBox1"}
        Me.mTxtCodPrestamo.Location = New System.Drawing.Point(16, 33)
        Me.mTxtCodPrestamo.MaxLength = 32767
        Me.mTxtCodPrestamo.Name = "mTxtCodPrestamo"
        Me.mTxtCodPrestamo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.mTxtCodPrestamo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.mTxtCodPrestamo.SelectedText = ""
        Me.mTxtCodPrestamo.Size = New System.Drawing.Size(232, 23)
        Me.mTxtCodPrestamo.TabIndex = 3
        Me.mTxtCodPrestamo.Text = "MetroTextBox1"
        Me.mTxtCodPrestamo.UseSelectable = True
        '
        'mrbCodPrestamo
        '
        Me.mrbCodPrestamo.AutoSize = True
        Me.mrbCodPrestamo.Location = New System.Drawing.Point(14, 10)
        Me.mrbCodPrestamo.Name = "mrbCodPrestamo"
        Me.mrbCodPrestamo.Size = New System.Drawing.Size(113, 17)
        Me.mrbCodPrestamo.TabIndex = 2
        Me.mrbCodPrestamo.Text = "Cod. Préstamo:"
        Me.mrbCodPrestamo.UseSelectable = True
        '
        'MetroButton2
        '
        Me.MetroButton2.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.MetroButton2.Location = New System.Drawing.Point(16, 247)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(114, 32)
        Me.MetroButton2.TabIndex = 12
        Me.MetroButton2.Text = "Agregar"
        Me.MetroButton2.UseSelectable = True
        '
        'MetroButton3
        '
        Me.MetroButton3.FontWeight = MetroFramework.MetroButtonWeight.Light
        Me.MetroButton3.Location = New System.Drawing.Point(136, 247)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(112, 32)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 13
        Me.MetroButton3.Text = "Consultar"
        Me.MetroButton3.UseSelectable = True
        '
        'frmArregloMora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 649)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmArregloMora"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "ARREGLOS"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblInicio As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFechaFin As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpFechaIni As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroRadioButton2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents mTxtDui As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mrbDui As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents mTxtCodPrestamo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents mrbCodPrestamo As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
End Class
