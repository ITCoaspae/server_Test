<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRemesaCheques
    Inherits MetroFramework.Forms.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRemesaCheques))
        Me.lblTipoTransaccion = New System.Windows.Forms.Label()
        Me.cbTipoTransaccion = New System.Windows.Forms.ComboBox()
        Me.btnAnular = New MetroFramework.Controls.MetroButton()
        Me.btnRemesar = New MetroFramework.Controls.MetroButton()
        Me.dtpFecMovRemesar = New System.Windows.Forms.DateTimePicker()
        Me.fgR = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbSucursal = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.txtNombreCta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoComprobante = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnMostrar = New MetroFramework.Controls.MetroButton()
        CType(Me.fgR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTipoTransaccion
        '
        Me.lblTipoTransaccion.AutoSize = True
        Me.lblTipoTransaccion.Location = New System.Drawing.Point(13, 122)
        Me.lblTipoTransaccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoTransaccion.Name = "lblTipoTransaccion"
        Me.lblTipoTransaccion.Size = New System.Drawing.Size(142, 17)
        Me.lblTipoTransaccion.TabIndex = 8
        Me.lblTipoTransaccion.Text = "Tipo de Transacción:"
        '
        'cbTipoTransaccion
        '
        Me.cbTipoTransaccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoTransaccion.FormattingEnabled = True
        Me.cbTipoTransaccion.Location = New System.Drawing.Point(165, 126)
        Me.cbTipoTransaccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbTipoTransaccion.Name = "cbTipoTransaccion"
        Me.cbTipoTransaccion.Size = New System.Drawing.Size(688, 24)
        Me.cbTipoTransaccion.TabIndex = 9
        '
        'btnAnular
        '
        Me.btnAnular.Location = New System.Drawing.Point(739, 281)
        Me.btnAnular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(155, 34)
        Me.btnAnular.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAnular.TabIndex = 3
        Me.btnAnular.Text = "Anular Cheques"
        Me.btnAnular.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAnular.UseSelectable = True
        Me.btnAnular.UseStyleColors = True
        '
        'btnRemesar
        '
        Me.btnRemesar.Location = New System.Drawing.Point(576, 281)
        Me.btnRemesar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnRemesar.Name = "btnRemesar"
        Me.btnRemesar.Size = New System.Drawing.Size(155, 34)
        Me.btnRemesar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnRemesar.TabIndex = 2
        Me.btnRemesar.Text = "Remesar Cheques"
        Me.btnRemesar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnRemesar.UseSelectable = True
        Me.btnRemesar.UseStyleColors = True
        '
        'dtpFecMovRemesar
        '
        Me.dtpFecMovRemesar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecMovRemesar.Location = New System.Drawing.Point(432, 57)
        Me.dtpFecMovRemesar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFecMovRemesar.Name = "dtpFecMovRemesar"
        Me.dtpFecMovRemesar.Size = New System.Drawing.Size(139, 22)
        Me.dtpFecMovRemesar.TabIndex = 3
        '
        'fgR
        '
        Me.fgR.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fgR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgR.BackColor = System.Drawing.Color.White
        Me.fgR.ColumnInfo = "10,1,0,0,0,95,Columns:0{Width:15;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Visible:False;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Visible:False;}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{AllowSor" &
    "ting:False;Name:""Seleccionar"";Style:""DataType:System.Boolean;TextAlign:LeftCente" &
    "r;ImageAlign:CenterCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgR.Location = New System.Drawing.Point(31, 322)
        Me.fgR.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fgR.Name = "fgR"
        Me.fgR.Rows.Count = 2
        Me.fgR.Rows.DefaultSize = 22
        Me.fgR.Size = New System.Drawing.Size(861, 202)
        Me.fgR.StyleInfo = resources.GetString("fgR.StyleInfo")
        Me.fgR.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(315, 60)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Remesa:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Sucursal:"
        '
        'cbSucursal
        '
        Me.cbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSucursal.Enabled = False
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(165, 23)
        Me.cbSucursal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(688, 24)
        Me.cbSucursal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 65)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Folio:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(165, 57)
        Me.txtFolio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(140, 22)
        Me.txtFolio.TabIndex = 1
        '
        'txtNombreCta
        '
        Me.txtNombreCta.Location = New System.Drawing.Point(165, 94)
        Me.txtNombreCta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombreCta.Name = "txtNombreCta"
        Me.txtNombreCta.Size = New System.Drawing.Size(688, 22)
        Me.txtNombreCta.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 94)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre de Cuenta:"
        '
        'txtNoComprobante
        '
        Me.txtNoComprobante.Location = New System.Drawing.Point(712, 58)
        Me.txtNoComprobante.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoComprobante.Name = "txtNoComprobante"
        Me.txtNoComprobante.Size = New System.Drawing.Size(141, 22)
        Me.txtNoComprobante.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(580, 57)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 34)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No. Comprobante " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Remesa:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(268, 289)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(217, 21)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "Mostrar Cheques Remesados"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.cbSucursal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblTipoTransaccion)
        Me.GroupBox2.Controls.Add(Me.txtNoComprobante)
        Me.GroupBox2.Controls.Add(Me.cbTipoTransaccion)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtFolio)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtpFecMovRemesar)
        Me.GroupBox2.Controls.Add(Me.txtNombreCta)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 78)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(863, 196)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de Remesa"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(165, 159)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(688, 22)
        Me.TextBox1.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 162)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Observación:"
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(31, 281)
        Me.btnMostrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(229, 34)
        Me.btnMostrar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar.TabIndex = 5
        Me.btnMostrar.Text = "Mostrar Cheques a Remesar"
        Me.btnMostrar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar.UseSelectable = True
        Me.btnMostrar.UseStyleColors = True
        '
        'frmRemesaCheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 590)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.fgR)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnRemesar)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmRemesaCheques"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Remesa de cheques"
        CType(Me.fgR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTipoTransaccion As Label
    Friend WithEvents cbTipoTransaccion As ComboBox
    Friend WithEvents btnAnular As MetroFramework.Controls.MetroButton
    Friend WithEvents btnRemesar As MetroFramework.Controls.MetroButton
    Friend WithEvents dtpFecMovRemesar As DateTimePicker
    Friend WithEvents fgR As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbSucursal As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFolio As TextBox
    Friend WithEvents txtNombreCta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNoComprobante As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnMostrar As MetroFramework.Controls.MetroButton
End Class
