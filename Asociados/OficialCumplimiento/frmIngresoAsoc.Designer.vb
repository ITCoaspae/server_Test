<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngresoAsoc
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tpNat = New MetroFramework.Controls.MetroTabPage()
        Me.tpNat1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.txtNoResidente = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.chkResidente = New MetroFramework.Controls.MetroCheckBox()
        Me.chkPersonaJuridica = New MetroFramework.Controls.MetroCheckBox()
        Me.txtUltIngreso = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtNosocio = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.cbEstadoIngreso = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtNoPasaporte = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtDui = New System.Windows.Forms.MaskedTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroContextMenu1 = New MetroFramework.Controls.MetroContextMenu(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()

        Me.MetroTabControl1.SuspendLayout()
        Me.tpNat.SuspendLayout()
        Me.tpNat1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.MetroContextMenu1.SuspendLayout()

        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroTabControl1.Controls.Add(Me.tpNat)
        Me.MetroTabControl1.Location = New System.Drawing.Point(31, 189)
        Me.MetroTabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTabControl1.Multiline = True
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1117, 349)
        Me.MetroTabControl1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabControl1.UseSelectable = True
        '
        'tpNat
        '
        Me.tpNat.Controls.Add(Me.tpNat1)
        Me.tpNat.Controls.Add(Me.txtNoResidente)
        Me.tpNat.Controls.Add(Me.MetroLabel6)
        Me.tpNat.Controls.Add(Me.chkResidente)
        Me.tpNat.Controls.Add(Me.chkPersonaJuridica)
        Me.tpNat.Controls.Add(Me.txtUltIngreso)
        Me.tpNat.Controls.Add(Me.MetroLabel5)
        Me.tpNat.Controls.Add(Me.txtNosocio)
        Me.tpNat.Controls.Add(Me.MetroLabel4)
        Me.tpNat.Controls.Add(Me.cbEstadoIngreso)
        Me.tpNat.Controls.Add(Me.MetroLabel3)
        Me.tpNat.Controls.Add(Me.txtNoPasaporte)
        Me.tpNat.Controls.Add(Me.MetroLabel2)
        Me.tpNat.Controls.Add(Me.txtDui)
        Me.tpNat.Controls.Add(Me.MetroLabel1)
        Me.tpNat.HorizontalScrollbarBarColor = True
        Me.tpNat.HorizontalScrollbarHighlightOnWheel = False
        Me.tpNat.HorizontalScrollbarSize = 12
        Me.tpNat.Location = New System.Drawing.Point(4, 38)
        Me.tpNat.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpNat.Name = "tpNat"
        Me.tpNat.Size = New System.Drawing.Size(1109, 307)
        Me.tpNat.TabIndex = 0
        Me.tpNat.Text = "Persona Natural/Representante Legal"
        Me.tpNat.VerticalScrollbarBarColor = True
        Me.tpNat.VerticalScrollbarHighlightOnWheel = False
        Me.tpNat.VerticalScrollbarSize = 13
        '
        'tpNat1
        '
        Me.tpNat1.Controls.Add(Me.MetroTabPage1)
        Me.tpNat1.Controls.Add(Me.MetroTabPage2)
        Me.tpNat1.Location = New System.Drawing.Point(4, 76)
        Me.tpNat1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpNat1.Name = "tpNat1"
        Me.tpNat1.SelectedIndex = 0
        Me.tpNat1.Size = New System.Drawing.Size(1079, 246)
        Me.tpNat1.TabIndex = 17
        Me.tpNat1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.MetroComboBox1)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel11)
        Me.MetroTabPage1.Controls.Add(Me.MetroTextBox4)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel10)
        Me.MetroTabPage1.Controls.Add(Me.MetroTextBox3)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel9)
        Me.MetroTabPage1.Controls.Add(Me.MetroTextBox2)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel8)
        Me.MetroTabPage1.Controls.Add(Me.MetroTextBox1)
        Me.MetroTabPage1.Controls.Add(Me.MetroLabel7)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 12
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(1071, 204)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Natural"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 13
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 21
        Me.MetroComboBox1.Location = New System.Drawing.Point(168, 75)
        Me.MetroComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(356, 27)
        Me.MetroComboBox1.TabIndex = 27
        Me.MetroComboBox1.UseSelectable = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(4, 84)
        Me.MetroLabel11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(92, 20)
        Me.MetroLabel11.TabIndex = 26
        Me.MetroLabel11.Text = "Nacionalidad:"
        '
        'MetroTextBox4
        '
        Me.MetroTextBox4.Lines = New String(-1) {}
        Me.MetroTextBox4.Location = New System.Drawing.Point(716, 43)
        Me.MetroTextBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTextBox4.MaxLength = 32767
        Me.MetroTextBox4.Name = "MetroTextBox4"
        Me.MetroTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox4.SelectedText = ""
        Me.MetroTextBox4.Size = New System.Drawing.Size(357, 25)
        Me.MetroTextBox4.TabIndex = 25
        Me.MetroTextBox4.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(568, 43)
        Me.MetroLabel10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(110, 20)
        Me.MetroLabel10.TabIndex = 24
        Me.MetroLabel10.Text = "Apellido Casada:"
        '
        'MetroTextBox3
        '
        Me.MetroTextBox3.Lines = New String(-1) {}
        Me.MetroTextBox3.Location = New System.Drawing.Point(168, 43)
        Me.MetroTextBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTextBox3.MaxLength = 32767
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.Size = New System.Drawing.Size(357, 25)
        Me.MetroTextBox3.TabIndex = 23
        Me.MetroTextBox3.UseSelectable = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(4, 44)
        Me.MetroLabel9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(121, 20)
        Me.MetroLabel9.TabIndex = 22
        Me.MetroLabel9.Text = "Segundo Apellido:"
        '
        'MetroTextBox2
        '
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(716, 10)
        Me.MetroTextBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.Size = New System.Drawing.Size(357, 25)
        Me.MetroTextBox2.TabIndex = 21
        Me.MetroTextBox2.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(568, 10)
        Me.MetroLabel8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(107, 20)
        Me.MetroLabel8.TabIndex = 20
        Me.MetroLabel8.Text = "Primer Apellido:"
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(168, 11)
        Me.MetroTextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.Size = New System.Drawing.Size(357, 25)
        Me.MetroTextBox1.TabIndex = 19
        Me.MetroTextBox1.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(4, 11)
        Me.MetroLabel7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(70, 20)
        Me.MetroLabel7.TabIndex = 18
        Me.MetroLabel7.Text = "Nombres:"
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 12
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(1071, 204)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Jurídica"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 13
        '
        'txtNoResidente
        '
        Me.txtNoResidente.Lines = New String() {"txtNoResidente"}
        Me.txtNoResidente.Location = New System.Drawing.Point(688, 44)
        Me.txtNoResidente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoResidente.MaxLength = 32767
        Me.txtNoResidente.Name = "txtNoResidente"
        Me.txtNoResidente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoResidente.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNoResidente.SelectedText = ""
        Me.txtNoResidente.Size = New System.Drawing.Size(144, 25)
        Me.txtNoResidente.TabIndex = 16
        Me.txtNoResidente.Text = "txtNoResidente"
        Me.txtNoResidente.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(556, 44)
        Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(99, 20)
        Me.MetroLabel6.TabIndex = 15
        Me.MetroLabel6.Text = "No. Residente:"
        '
        'chkResidente
        '
        Me.chkResidente.AutoSize = True
        Me.chkResidente.Location = New System.Drawing.Point(449, 49)
        Me.chkResidente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkResidente.Name = "chkResidente"
        Me.chkResidente.Size = New System.Drawing.Size(81, 17)
        Me.chkResidente.TabIndex = 14
        Me.chkResidente.Text = "Residente"
        Me.chkResidente.UseSelectable = True
        '
        'chkPersonaJuridica
        '
        Me.chkPersonaJuridica.AutoSize = True
        Me.chkPersonaJuridica.Location = New System.Drawing.Point(297, 49)
        Me.chkPersonaJuridica.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkPersonaJuridica.Name = "chkPersonaJuridica"
        Me.chkPersonaJuridica.Size = New System.Drawing.Size(119, 17)
        Me.chkPersonaJuridica.TabIndex = 13
        Me.chkPersonaJuridica.Text = "Persona Jurídica"
        Me.chkPersonaJuridica.UseSelectable = True
        '
        'txtUltIngreso
        '
        Me.txtUltIngreso.Lines = New String() {"txtUltIngreso"}
        Me.txtUltIngreso.Location = New System.Drawing.Point(116, 44)
        Me.txtUltIngreso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUltIngreso.MaxLength = 32767
        Me.txtUltIngreso.Name = "txtUltIngreso"
        Me.txtUltIngreso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUltIngreso.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUltIngreso.SelectedText = ""
        Me.txtUltIngreso.Size = New System.Drawing.Size(173, 25)
        Me.txtUltIngreso.TabIndex = 12
        Me.txtUltIngreso.Text = "txtUltIngreso"
        Me.txtUltIngreso.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(4, 44)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(82, 20)
        Me.MetroLabel5.TabIndex = 11
        Me.MetroLabel5.Text = "Ult. Ingreso:"
        '
        'txtNosocio
        '
        Me.txtNosocio.Lines = New String(-1) {}
        Me.txtNosocio.Location = New System.Drawing.Point(965, 12)
        Me.txtNosocio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNosocio.MaxLength = 32767
        Me.txtNosocio.Name = "txtNosocio"
        Me.txtNosocio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNosocio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNosocio.SelectedText = ""
        Me.txtNosocio.Size = New System.Drawing.Size(117, 25)
        Me.txtNosocio.TabIndex = 10
        Me.txtNosocio.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(840, 12)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(91, 20)
        Me.MetroLabel4.TabIndex = 9
        Me.MetroLabel4.Text = "No. Asociado"
        '
        'cbEstadoIngreso
        '
        Me.cbEstadoIngreso.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbEstadoIngreso.FormattingEnabled = True
        Me.cbEstadoIngreso.ItemHeight = 21
        Me.cbEstadoIngreso.Location = New System.Drawing.Point(615, 6)
        Me.cbEstadoIngreso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbEstadoIngreso.Name = "cbEstadoIngreso"
        Me.cbEstadoIngreso.Size = New System.Drawing.Size(216, 27)
        Me.cbEstadoIngreso.TabIndex = 8
        Me.cbEstadoIngreso.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(476, 14)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(103, 20)
        Me.MetroLabel3.TabIndex = 7
        Me.MetroLabel3.Text = "Estado Ingreso:"
        '
        'txtNoPasaporte
        '
        Me.txtNoPasaporte.Lines = New String(-1) {}
        Me.txtNoPasaporte.Location = New System.Drawing.Point(295, 12)
        Me.txtNoPasaporte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoPasaporte.MaxLength = 32767
        Me.txtNoPasaporte.Name = "txtNoPasaporte"
        Me.txtNoPasaporte.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNoPasaporte.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNoPasaporte.SelectedText = ""
        Me.txtNoPasaporte.Size = New System.Drawing.Size(173, 25)
        Me.txtNoPasaporte.TabIndex = 6
        Me.txtNoPasaporte.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(159, 14)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(99, 20)
        Me.MetroLabel2.TabIndex = 5
        Me.MetroLabel2.Text = "No. Pasaporte:"
        '
        'txtDui
        '
        Me.txtDui.Location = New System.Drawing.Point(53, 12)
        Me.txtDui.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDui.Mask = "________-_"
        Me.txtDui.Name = "txtDui"
        Me.txtDui.Size = New System.Drawing.Size(96, 22)
        Me.txtDui.TabIndex = 4
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(4, 14)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(33, 20)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Dui:"
        '
        'MetroContextMenu1
        '
        Me.MetroContextMenu1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MetroContextMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MetroContextMenu1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MetroContextMenu1.Name = "MetroContextMenu1"
        Me.MetroContextMenu1.Size = New System.Drawing.Size(111, 52)
        Me.MetroContextMenu1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroContextMenu1.Theme = MetroFramework.MetroThemeStyle.Dark
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(110, 24)
        Me.ToolStripMenuItem1.Text = "teset"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(110, 24)
        Me.ToolStripMenuItem2.Text = "test2"
        '
        'C1CommandHolder1

        '
        'frmIngresoAsoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1179, 647)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmIngresoAsoc"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Text = "frmIngresoAsoc"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tpNat.ResumeLayout(False)
        Me.tpNat.PerformLayout()
        Me.tpNat1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.MetroTabPage1.PerformLayout()
        Me.MetroContextMenu1.ResumeLayout(False)

        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tpNat As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txtDui As MaskedTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkResidente As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkPersonaJuridica As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtUltIngreso As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNosocio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbEstadoIngreso As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNoPasaporte As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tpNat1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txtNoResidente As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroContextMenu1 As MetroFramework.Controls.MetroContextMenu
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem

End Class
