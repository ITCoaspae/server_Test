Public Class frmMsProcesoExclusion
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private ds As New DataSet, pTipo As wrAsociados.TipoInhabilitacion
    Friend WithEvents btnExportar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnInhabilitacion1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnVerificar1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsProcesoExclusion))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(740, 44)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(136, 16)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "Fecha de Exclusión:"
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
        Me.fg.Location = New System.Drawing.Point(23, 205)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(740, 185)
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
        Me.GroupBox3.Location = New System.Drawing.Point(23, 113)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(357, 52)
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
        Me.GroupBox4.Location = New System.Drawing.Point(392, 113)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(371, 52)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dictamen del Consejo de Administración"
        '
        'dtpFecCA
        '
        Me.dtpFecCA.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecCA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCA.Location = New System.Drawing.Point(260, 22)
        Me.dtpFecCA.Name = "dtpFecCA"
        Me.dtpFecCA.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecCA.TabIndex = 1
        Me.dtpFecCA.Value = New Date(2004, 9, 9, 11, 32, 0, 0)
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(182, 25)
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
        Me.btnExportar1.Location = New System.Drawing.Point(228, 171)
        Me.btnExportar1.Name = "btnExportar1"
        Me.btnExportar1.Size = New System.Drawing.Size(75, 28)
        Me.btnExportar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnExportar1.TabIndex = 34
        Me.btnExportar1.Text = "Anular"
        Me.btnExportar1.UseSelectable = True
        Me.btnExportar1.UseStyleColors = True
        '
        'btnInhabilitacion1
        '
        Me.btnInhabilitacion1.Location = New System.Drawing.Point(104, 171)
        Me.btnInhabilitacion1.Name = "btnInhabilitacion1"
        Me.btnInhabilitacion1.Size = New System.Drawing.Size(118, 28)
        Me.btnInhabilitacion1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnInhabilitacion1.TabIndex = 33
        Me.btnInhabilitacion1.Text = "Generar Exclusión"
        Me.btnInhabilitacion1.UseSelectable = True
        Me.btnInhabilitacion1.UseStyleColors = True
        '
        'btnVerificar1
        '
        Me.btnVerificar1.Location = New System.Drawing.Point(23, 171)
        Me.btnVerificar1.Name = "btnVerificar1"
        Me.btnVerificar1.Size = New System.Drawing.Size(75, 28)
        Me.btnVerificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnVerificar1.TabIndex = 32
        Me.btnVerificar1.Text = "Verificación"
        Me.btnVerificar1.UseSelectable = True
        Me.btnVerificar1.UseStyleColors = True
        '
        'frmMsProcesoExclusion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(786, 413)
        Me.Controls.Add(Me.btnExportar1)
        Me.Controls.Add(Me.btnInhabilitacion1)
        Me.Controls.Add(Me.btnVerificar1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.fg)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsProcesoExclusion"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Exclusión de Asociados"
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
        Me.dtpFecha.Value = Now
        Me.dtpFecCA.Value = Now
        Me.dtpFecJV.Value = Now
    End Sub

    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fg.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Space) And fg.ColSel = 0 Then
            e.Handled = True
            fg.StartEditing()
        End If
    End Sub

    Private Sub btnVerificar1_Click(sender As Object, e As EventArgs) Handles btnVerificar1.Click
        Dim oAsoc As New wrAsociados.wsLibAsoc
        ds = oAsoc.VerificaAsociados_Exclusion(Me.dtpFecha.Value.ToShortDateString, sUsuario, sPassword, sSucursal)

        Me.fg.DataSource = ds.Tables(0)

        If ds.Tables(0).Rows.Count > 0 Then Me.btnInhabilitacion1.Enabled = True

    End Sub

    Private Sub btnInhabilitacion1_Click(sender As Object, e As EventArgs) Handles btnInhabilitacion1.Click
        Dim oAsoc As New wrAsociados.wsLibAsoc, pResp As String, x As Integer, dsSel As New DataSet

        If Me.txtNoActaCA.Text.Trim = "" Then
            MessageBox.Show("Debe digitar el No. de Acta del Consejo de Administración.", "Inhabilitación de Asociados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If Me.txtNoActaJV.Text.Trim = "" Then
            MessageBox.Show("Debe digitar el No. de Acta de la Junta de Vigilancia.", "Inhabilitación de Asociados", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        dsSel = oAsoc.ObtenerEstructuraSeleccion(sUsuario, sPassword, sSucursal)
        For x = 1 To fg.Rows.Count - 1
            dsSel = oAsoc.AlmacenaEstructuraSeleccion(fg.Item(x, "Aplica_Exclusion"), fg.Item(x, "NoSocio"), fg.Item(x, "Dui"), dsSel, sUsuario, sPassword, sSucursal)
        Next
        pResp = oAsoc.ExclusionAsociado(Me.dtpFecha.Value, Me.txtNoActaCA.Text.Trim, Me.dtpFecCA.Value.ToShortDateString, Me.txtNoActaJV.Text.Trim, Me.dtpFecJV.Value.ToShortDateString, dsSel, sUsuario, sPassword, sSucursal)
        If pResp.Trim <> "" Then
            MessageBox.Show(pResp, "Exclusión de Asociados", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Exclusión Efectuada.", "Exclusión de Asociados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnExportar1_Click(sender As Object, e As EventArgs) Handles btnExportar1.Click
        Dim openDlg As SaveFileDialog = New SaveFileDialog
        Dim Resultado As DialogResult
        Try
            openDlg.Filter = "Archivos Excel (*.xml)|*.xml"
            openDlg.FileName = "Asociados_Excluidos"
            Resultado = openDlg.ShowDialog()
            If Resultado = DialogResult.OK Then
                If openDlg.FileName.Trim = "" Then
                    MessageBox.Show("Debe ingresar un nombre para el Nuevo Archivo.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    ds.WriteXml(openDlg.FileName)
                    MessageBox.Show("El archivo ha sido generado.", "Exportación Asociados Excluídos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub fg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fg.KeyPress
        If e.KeyChar = ChrW(13) Or e.KeyChar = ChrW(32) Then
            e.Handled = True
        End If
    End Sub

End Class