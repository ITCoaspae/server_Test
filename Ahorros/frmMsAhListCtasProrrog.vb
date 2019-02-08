Public Class frmMsAhListCtasProrrog
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents fg2 As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtpR2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpR1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btNProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpR2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpR1 = New System.Windows.Forms.DateTimePicker()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.txtTipoAhorro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fg2 = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.fg2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(23, 62)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 356)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.MetroButton1)
        Me.TabPage2.Controls.Add(Me.btNProcesar1)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.dtpFecha)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.dtpR2)
        Me.TabPage2.Controls.Add(Me.dtpR1)
        Me.TabPage2.Controls.Add(Me.txtCodTipoAhorro)
        Me.TabPage2.Controls.Add(Me.txtTipoAhorro)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.fg2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(776, 330)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Cuentas de Ahorro Prorrogadas"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(426, 62)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton1.TabIndex = 191
        Me.MetroButton1.Text = "Ver Registros"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'btNProcesar1
        '
        Me.btNProcesar1.Location = New System.Drawing.Point(507, 62)
        Me.btNProcesar1.Name = "btNProcesar1"
        Me.btNProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btNProcesar1.Style = MetroFramework.MetroColorStyle.Green
        Me.btNProcesar1.TabIndex = 190
        Me.btNProcesar1.Text = "Procesar"
        Me.btNProcesar1.UseSelectable = True
        Me.btNProcesar1.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(99, 10)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(105, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(210, 62)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(16, 16)
        Me.Label21.TabIndex = 184
        Me.Label21.Text = "al"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(5, 62)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(32, 16)
        Me.Label22.TabIndex = 183
        Me.Label22.Text = "Del"
        '
        'dtpR2
        '
        Me.dtpR2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpR2.Location = New System.Drawing.Point(232, 62)
        Me.dtpR2.Name = "dtpR2"
        Me.dtpR2.Size = New System.Drawing.Size(105, 20)
        Me.dtpR2.TabIndex = 4
        '
        'dtpR1
        '
        Me.dtpR1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpR1.Location = New System.Drawing.Point(99, 62)
        Me.dtpR1.Name = "dtpR1"
        Me.dtpR1.Size = New System.Drawing.Size(105, 20)
        Me.dtpR1.TabIndex = 3
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.AcceptsReturn = True
        Me.txtCodTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(99, 36)
        Me.txtCodTipoAhorro.MaxLength = 10
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(80, 20)
        Me.txtCodTipoAhorro.TabIndex = 2
        '
        'txtTipoAhorro
        '
        Me.txtTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoAhorro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoAhorro.Location = New System.Drawing.Point(182, 36)
        Me.txtTipoAhorro.MaxLength = 110
        Me.txtTipoAhorro.Name = "txtTipoAhorro"
        Me.txtTipoAhorro.ReadOnly = True
        Me.txtTipoAhorro.Size = New System.Drawing.Size(400, 20)
        Me.txtTipoAhorro.TabIndex = 179
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(5, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 180
        Me.Label6.Text = "Tipo de Ahorro:"
        '
        'fg2
        '
        Me.fg2.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
        Me.fg2.BackColor = System.Drawing.SystemColors.Window
        Me.fg2.BackColorAlternate = System.Drawing.Color.WhiteSmoke
        Me.fg2.BackColorBkg = System.Drawing.SystemColors.AppWorkspace
        Me.fg2.BackColorFixed = System.Drawing.Color.Green
        Me.fg2.BackColorSel = System.Drawing.SystemColors.Highlight
        Me.fg2.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9)
        'Me.fg2.ExplorerBar = CType(((C1.Win.C1FlexGrid.Classic.ExplorerBarSettings.flexExSort Or C1.Win.C1FlexGrid.Classic.ExplorerBarSettings.flexExMove) _
        '    Or C1.Win.C1FlexGrid.Classic.ExplorerBarSettings.4),C1.Win.C1FlexGrid.Classic.ExplorerBarSettings)
        Me.fg2.ForeColorFixed = System.Drawing.SystemColors.ControlText
        Me.fg2.ForeColorSel = System.Drawing.SystemColors.HighlightText
        Me.fg2.GridColor = System.Drawing.SystemColors.Control
        Me.fg2.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.fg2.Location = New System.Drawing.Point(8, 96)
        Me.fg2.Name = "fg2"
        Me.fg2.NodeClosedPicture = Nothing
        Me.fg2.NodeOpenPicture = Nothing
        Me.fg2.OutlineBar = C1.Win.C1FlexGrid.Classic.OutlineBarSettings.flexOutlineBarSimple
        Me.fg2.OutlineCol = -1
        Me.fg2.Rows = 2
        Me.fg2.SheetBorder = System.Drawing.SystemColors.WindowText
        Me.fg2.Size = New System.Drawing.Size(765, 219)
        Me.fg2.TabIndex = 4
        Me.fg2.TreeColor = System.Drawing.Color.DarkGray
        Me.fg2.WallPaper = Nothing
        '
        'frmMsAhListCtasProrrog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(827, 441)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhListCtasProrrog"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Listado de Cuentas de Ahorro Prorrogadas"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.fg2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub frmMsAhListCtasProrrog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpR1.Value = Now
        Me.dtpR2.Value = Now
        Me.dtpFecha.Value = Now
    End Sub

    Private Sub btnVerReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtCodTipoAhorro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoAhorro.DoubleClick
        Dim ofrm As New frmAGenerico

        Try
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet
            ds = oAhorro.ConsultarTipoAhorro("*", "left(codtipoahorro,1)='2' or left(codtipoahorro,1)='5'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
            ofrm.Text = "Buscar Tipos de Ahorro"
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodTipoAhorro.Text = ofrm.Resultado.Trim
            If ofrm.Resultado.Trim = "" Then Exit Sub
            txtTipoAhorro.Text = ofrm.Resultado2.Trim

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Tipos de Ahorro - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCodTipoAhorro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodTipoAhorro.KeyPress
        Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                If txtCodTipoAhorro.Text.Trim = "" Then
                    txtCodTipoAhorro_DoubleClick(sender, e)
                Else
                    ds = oAhorro.ConsultarTipoAhorro("*", "CodTipoAhorro='" & txtCodTipoAhorro.Text.Trim & "' and left(codtipoahorro,1)='2' or left(codtipoahorro,1)='5'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        txtCodTipoAhorro.Text = CStr(Filas.Item(0)("CodTipoAhorro")).Trim
                        txtTipoAhorro.Text = CStr(Filas.Item(0)("Descripcion")).Trim
                    Else
                        txtCodTipoAhorro_DoubleClick(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btNProcesar1_Click(sender As Object, e As EventArgs) Handles btNProcesar1.Click
        Try
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet

            'ds = oAhorro.ProcesoProrrogaCuentas(True, "", "", Me.dtpFecha.Value.ToShortDateString, sUsuario, sPassword,sSucursal)
            MessageBox.Show("Proceso finalizado.", "Proceso Prorroga de Cuentas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim oAh As New wrAhorro.wsLibAhorro, pCodTipoAhorro As String
            If Me.txtCodTipoAhorro.Text.Trim = "" Then
                MsgBox("Seleccione el Tipo de Ahorro.", MsgBoxStyle.OkOnly, "Validación del Sistema")
                Exit Sub
            End If
            pCodTipoAhorro = Me.txtCodTipoAhorro.Text.Trim
            Me.fg2.DataSource = oAh.ConsultarCuentaAhorro("Dui,NoCuenta,Plazo,TasaInteres,FechaVencimiento", "Left(CodTipoAhorro,1)='" & pCodTipoAhorro.Substring(0, 1) & "' and Prorrogado='S'", "Dui,NoCuenta", sUsuario, sPassword, sSucursal).Tables(0)
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs)

    End Sub
End Class
