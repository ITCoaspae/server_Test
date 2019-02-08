Public Class frmMsProcesoInhabilitacion
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private ds As New DataSet, pTipo As wrAsociados.TipoInhabilitacion
    Friend WithEvents btnExportar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnInhabilitacion1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnVerificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImprimir1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btRehabilitacion1 As MetroFramework.Controls.MetroButton

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents cbTipoInhabilitacion As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDel As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecJV As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNoActaJV As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecCA As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtNoActaCA As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsProcesoInhabilitacion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpAl = New System.Windows.Forms.DateTimePicker()
        Me.dtpDel = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbTipoInhabilitacion = New System.Windows.Forms.ComboBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dtpFecJV = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNoActaJV = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dtpFecCA = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNoActaCA = New System.Windows.Forms.TextBox()
        Me.btnExportar1 = New MetroFramework.Controls.MetroButton()
        Me.btnInhabilitacion1 = New MetroFramework.Controls.MetroButton()
        Me.btnVerificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnImprimir1 = New MetroFramework.Controls.MetroButton()
        Me.btRehabilitacion1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpAl)
        Me.GroupBox1.Controls.Add(Me.dtpDel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.cbTipoInhabilitacion)
        Me.GroupBox1.Controls.Add(Me.chkTodos)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label60)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 64)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(552, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 212
        Me.Label4.Text = "al:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(416, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 211
        Me.Label3.Text = "Del:"
        '
        'dtpAl
        '
        Me.dtpAl.CustomFormat = "dd/MM/yyyy"
        Me.dtpAl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAl.Location = New System.Drawing.Point(584, 32)
        Me.dtpAl.Name = "dtpAl"
        Me.dtpAl.Size = New System.Drawing.Size(88, 20)
        Me.dtpAl.TabIndex = 3
        '
        'dtpDel
        '
        Me.dtpDel.CustomFormat = "dd/MM/yyyy"
        Me.dtpDel.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDel.Location = New System.Drawing.Point(448, 32)
        Me.dtpDel.Name = "dtpDel"
        Me.dtpDel.Size = New System.Drawing.Size(88, 20)
        Me.dtpDel.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(416, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 16)
        Me.Label2.TabIndex = 208
        Me.Label2.Text = "Período de Inhabilitación:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(383, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(2, 48)
        Me.GroupBox2.TabIndex = 207
        Me.GroupBox2.TabStop = False
        '
        'cbTipoInhabilitacion
        '
        Me.cbTipoInhabilitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoInhabilitacion.Items.AddRange(New Object() {"Aportaciones", "Préstamos"})
        Me.cbTipoInhabilitacion.Location = New System.Drawing.Point(16, 32)
        Me.cbTipoInhabilitacion.Name = "cbTipoInhabilitacion"
        Me.cbTipoInhabilitacion.Size = New System.Drawing.Size(208, 21)
        Me.cbTipoInhabilitacion.TabIndex = 0
        '
        'chkTodos
        '
        Me.chkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTodos.Location = New System.Drawing.Point(688, 8)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(72, 24)
        Me.chkTodos.TabIndex = 4
        Me.chkTodos.Text = "&Todos"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(240, 32)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(240, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "A la fecha:"
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(16, 16)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(112, 16)
        Me.Label60.TabIndex = 205
        Me.Label60.Text = "Inhabilitación por:"
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.SystemColors.Window
        Me.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.fg.ColumnInfo = "3,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(23, 225)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(767, 208)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 3
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.dtpFecJV)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtNoActaJV)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(23, 133)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(370, 52)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dictamen de la Junta de Vigilancia"
        '
        'dtpFecJV
        '
        Me.dtpFecJV.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecJV.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecJV.Location = New System.Drawing.Point(264, 24)
        Me.dtpFecJV.Name = "dtpFecJV"
        Me.dtpFecJV.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecJV.TabIndex = 1
        Me.dtpFecJV.Value = New Date(2004, 9, 9, 11, 32, 0, 0)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(184, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Fecha Acta:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "No. de Acta:"
        '
        'txtNoActaJV
        '
        Me.txtNoActaJV.Location = New System.Drawing.Point(88, 24)
        Me.txtNoActaJV.MaxLength = 20
        Me.txtNoActaJV.Name = "txtNoActaJV"
        Me.txtNoActaJV.Size = New System.Drawing.Size(88, 20)
        Me.txtNoActaJV.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.dtpFecCA)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtNoActaCA)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(407, 133)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(384, 52)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dictamen del Consejo de Administración"
        '
        'dtpFecCA
        '
        Me.dtpFecCA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecCA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCA.Location = New System.Drawing.Point(280, 24)
        Me.dtpFecCA.Name = "dtpFecCA"
        Me.dtpFecCA.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecCA.TabIndex = 1
        Me.dtpFecCA.Value = New Date(2004, 9, 9, 11, 32, 0, 0)
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(200, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 101
        Me.Label6.Text = "Fecha Acta:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 99
        Me.Label8.Text = "No. de Acta:"
        '
        'txtNoActaCA
        '
        Me.txtNoActaCA.Location = New System.Drawing.Point(88, 24)
        Me.txtNoActaCA.MaxLength = 20
        Me.txtNoActaCA.Name = "txtNoActaCA"
        Me.txtNoActaCA.Size = New System.Drawing.Size(88, 20)
        Me.txtNoActaCA.TabIndex = 0
        '
        'btnExportar1
        '
        Me.btnExportar1.Location = New System.Drawing.Point(336, 191)
        Me.btnExportar1.Name = "btnExportar1"
        Me.btnExportar1.Size = New System.Drawing.Size(75, 28)
        Me.btnExportar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnExportar1.TabIndex = 37
        Me.btnExportar1.Text = "Guardar"
        Me.btnExportar1.UseSelectable = True
        Me.btnExportar1.UseStyleColors = True
        '
        'btnInhabilitacion1
        '
        Me.btnInhabilitacion1.Location = New System.Drawing.Point(212, 191)
        Me.btnInhabilitacion1.Name = "btnInhabilitacion1"
        Me.btnInhabilitacion1.Size = New System.Drawing.Size(118, 28)
        Me.btnInhabilitacion1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnInhabilitacion1.TabIndex = 36
        Me.btnInhabilitacion1.Text = "Inhabilitación"
        Me.btnInhabilitacion1.UseSelectable = True
        Me.btnInhabilitacion1.UseStyleColors = True
        '
        'btnVerificar1
        '
        Me.btnVerificar1.Location = New System.Drawing.Point(131, 191)
        Me.btnVerificar1.Name = "btnVerificar1"
        Me.btnVerificar1.Size = New System.Drawing.Size(75, 28)
        Me.btnVerificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnVerificar1.TabIndex = 35
        Me.btnVerificar1.Text = "Verificación"
        Me.btnVerificar1.UseSelectable = True
        Me.btnVerificar1.UseStyleColors = True
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Location = New System.Drawing.Point(417, 191)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(75, 28)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 38
        Me.btnImprimir1.Text = "Imprimir"
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'btRehabilitacion1
        '
        Me.btRehabilitacion1.Location = New System.Drawing.Point(23, 191)
        Me.btRehabilitacion1.Name = "btRehabilitacion1"
        Me.btRehabilitacion1.Size = New System.Drawing.Size(102, 28)
        Me.btRehabilitacion1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btRehabilitacion1.TabIndex = 39
        Me.btRehabilitacion1.Text = "Rehabilitación"
        Me.btRehabilitacion1.UseSelectable = True
        Me.btRehabilitacion1.UseStyleColors = True
        '
        'frmMsProcesoInhabilitacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(813, 456)
        Me.Controls.Add(Me.btRehabilitacion1)
        Me.Controls.Add(Me.btnImprimir1)
        Me.Controls.Add(Me.btnExportar1)
        Me.Controls.Add(Me.btnInhabilitacion1)
        Me.Controls.Add(Me.btnVerificar1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fg)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsProcesoInhabilitacion"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Inhabilitación de Asociados"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMsProcesoInhabilitacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbTipoInhabilitacion.SelectedIndex = 0
        Me.dtpFecha.Value = Now
        Me.dtpDel.Value = Now
        Me.dtpAl.Value = Now.AddMonths(1)
    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked = True Then
            Me.cbTipoInhabilitacion.Enabled = False
        Else
            Me.cbTipoInhabilitacion.Enabled = True
        End If
    End Sub



    Private Sub btRehabilitacion1_Click(sender As Object, e As EventArgs) Handles btRehabilitacion1.Click
        Dim oAsoc As New wrAsociados.wsLibAsoc, pResp As String
        pResp = oAsoc.RehabilitacionAsociado(sUsuario, sPassword, sSucursal)
        If pResp.Trim = "" Then
            MessageBox.Show("Rehabilitación Efectuada.", "Inhabilitación de Asociados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(pResp, "Rehabilitación de Asociados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnVerificar1_Click(sender As Object, e As EventArgs) Handles btnVerificar1.Click
        Dim oAsoc As New wrAsociados.wsLibAsoc
        If Me.chkTodos.Checked = True Then
            pTipo = wrAsociados.TipoInhabilitacion.Ambas
        Else
            If Me.cbTipoInhabilitacion.SelectedIndex = 0 Then
                pTipo = wrAsociados.TipoInhabilitacion.Aportacion
            ElseIf Me.cbTipoInhabilitacion.SelectedIndex = 1 Then
                pTipo = wrAsociados.TipoInhabilitacion.Prestamos
            End If
        End If
        ds = oAsoc.VerificaAsociados_MoraInhabilitacion(True, "", Me.dtpFecha.Value.ToShortDateString, pTipo, sUsuario, sPassword, sSucursal)

        Me.fg.DataSource = ds.Tables(0)

        If ds.Tables(0).Rows.Count > 0 Then Me.btnInhabilitacion1.Enabled = True

    End Sub

    Private Sub btnInhabilitacion1_Click(sender As Object, e As EventArgs) Handles btnInhabilitacion1.Click
        Dim vNoCuotas_Ap As Integer, vNoCuotas_Pr As Integer, oAsoc As New wrAsociados.wsLibAsoc, pResp As String, pNum As String
        Dim pCampos As String, pValores As String

        If Me.txtNoActaCA.Text.Trim = "" Then
            MessageBox.Show("Debe digitar el No. de Acta del Consejo de Administración.", "Inhabilitación de Asociados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.txtNoActaJV.Text.Trim = "" Then
            MessageBox.Show("Debe digitar el No. de Acta de la Junta de Vigilancia.", "Inhabilitación de Asociados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If pTipo = wrAsociados.TipoInhabilitacion.Ambas Then
            vNoCuotas_Ap = InputBox("Introduzca el número de Cuotas Mora de Aportación:", "Inhabilitación de Asociados", 0)
            If pNum.Trim <> "" Then
                vNoCuotas_Ap = pNum
            Else
                Exit Sub
            End If

            vNoCuotas_Pr = InputBox("Introduzca el número de Cuotas Mora de Préstamos:", "Inhabilitación de Asociados", 0)
            If pNum.Trim <> "" Then
                vNoCuotas_Pr = pNum
            Else
                Exit Sub
            End If

            If vNoCuotas_Ap = 0 Or vNoCuotas_Pr = 0 Then Exit Sub

            pResp = oAsoc.InhabilitacionAsociado(True, "", Me.dtpFecha.Value, vNoCuotas_Ap, vNoCuotas_Pr, wrAsociados.TipoInhabilitacion.Ambas, Me.dtpDel.Value.ToShortDateString, Me.dtpAl.Value.ToShortDateString, Me.txtNoActaCA.Text.Trim, Me.dtpFecCA.Value.ToShortDateString, Me.txtNoActaJV.Text.Trim, Me.dtpFecJV.Value.ToShortDateString, sUsuario, sPassword, sSucursal)
            If pResp.Trim <> "" Then
                MessageBox.Show(pResp, "Inhabilitación de Asociados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Inhabilitación Efectuada.", "Inhabilitación de Asociados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf pTipo = wrAsociados.TipoInhabilitacion.Aportacion Then

            pNum = InputBox("Introduzca el número de Cuotas Mora de Aportación:", "Inhabilitación de Asociados", 0)
            If pNum.Trim <> "" Then
                vNoCuotas_Ap = pNum
            Else
                Exit Sub
            End If

            If vNoCuotas_Ap = 0 Then Exit Sub

            pResp = oAsoc.InhabilitacionAsociado(True, "", Me.dtpFecha.Value, vNoCuotas_Ap, 0, wrAsociados.TipoInhabilitacion.Aportacion, Me.dtpDel.Value.ToShortDateString, Me.dtpAl.Value.ToShortDateString, Me.txtNoActaCA.Text.Trim, Me.dtpFecCA.Value.ToShortDateString, Me.txtNoActaJV.Text.Trim, Me.dtpFecJV.Value.ToShortDateString, sUsuario, sPassword, sSucursal)
            If pResp.Trim <> "" Then
                MessageBox.Show(pResp, "Inhabilitación de Asociados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Inhabilitación Efectuada.", "Inhabilitación de Asociados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        ElseIf pTipo = wrAsociados.TipoInhabilitacion.Prestamos Then

            pNum = InputBox("Introduzca el número de Cuotas Mora de Préstamos:", "Inhabilitación de Asociados", 0)
            If pNum.Trim <> "" Then
                vNoCuotas_Pr = pNum
            Else
                Exit Sub
            End If

            If vNoCuotas_Pr = 0 Then Exit Sub

            pResp = oAsoc.InhabilitacionAsociado(True, "", Me.dtpFecha.Value, 0, vNoCuotas_Pr, wrAsociados.TipoInhabilitacion.Prestamos, Me.dtpDel.Value.ToShortDateString, Me.dtpAl.Value.ToShortDateString, Me.txtNoActaCA.Text.Trim, Me.dtpFecCA.Value.ToShortDateString, Me.txtNoActaJV.Text.Trim, Me.dtpFecJV.Value.ToShortDateString, sUsuario, sPassword, sSucursal)
            If pResp.Trim <> "" Then
                MessageBox.Show(pResp, "Inhabilitación de Asociados", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Inhabilitación Efectuada.", "Inhabilitación de Asociados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        End If
    End Sub

    Private Sub btnExportar1_Click(sender As Object, e As EventArgs) Handles btnExportar1.Click
        Dim openDlg As SaveFileDialog = New SaveFileDialog
        Dim Resultado As DialogResult
        Try
            openDlg.Filter = "Archivos Excel (*.xml)|*.xml"
            openDlg.FileName = "Asociados_Inhabilitados"
            Resultado = openDlg.ShowDialog()
            If Resultado = DialogResult.OK Then
                If openDlg.FileName.Trim = "" Then
                    MessageBox.Show("Debe ingresar un nombre para el Nuevo Archivo.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    ds.WriteXml(openDlg.FileName)
                    MessageBox.Show("El archivo ha sido generado.", "Exportación Asociados Inhabilitados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnImprimir1_Click(sender As Object, e As EventArgs) Handles btnImprimir1.Click
        Dim ofrm As New frmVisor(ds, 79, 0)
        ofrm.ShowDialog()
    End Sub



End Class