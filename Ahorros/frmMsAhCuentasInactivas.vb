Public Class frmMsAhCuentasInactivas
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Private dsInactivas As New DataSet

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1nMontComInact As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents ttip As System.Windows.Forms.ToolTip
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsAhCuentasInactivas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.c1nMontComInact = New C1.Win.C1Input.C1NumericEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.txtTipoAhorro = New System.Windows.Forms.TextBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.ttip = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1nMontComInact, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.chkTodos)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.c1nMontComInact)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label60)
        Me.GroupBox1.Controls.Add(Me.txtCodTipoAhorro)
        Me.GroupBox1.Controls.Add(Me.txtTipoAhorro)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "s"
        '
        'chkTodos
        '
        Me.chkTodos.Location = New System.Drawing.Point(534, 11)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(72, 24)
        Me.chkTodos.TabIndex = 3
        Me.chkTodos.Text = "&Todos"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(369, 40)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(159, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'c1nMontComInact
        '
        Me.c1nMontComInact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMontComInact.CustomFormat = "#0.00"
        Me.c1nMontComInact.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nMontComInact.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nMontComInact.Location = New System.Drawing.Point(128, 40)
        Me.c1nMontComInact.Name = "c1nMontComInact"
        Me.c1nMontComInact.ReadOnly = True
        Me.c1nMontComInact.ShowDropDownButton = False
        Me.c1nMontComInact.ShowUpDownButtons = False
        Me.c1nMontComInact.Size = New System.Drawing.Size(170, 21)
        Me.c1nMontComInact.TabIndex = 2
        Me.c1nMontComInact.Tag = Nothing
        Me.c1nMontComInact.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(10, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 16)
        Me.Label15.TabIndex = 207
        Me.Label15.Text = "Valor cobro Inactividad:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(315, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "Fecha:"
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(10, 16)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(88, 16)
        Me.Label60.TabIndex = 205
        Me.Label60.Text = "Tipo de Ahorro:"
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.AcceptsReturn = True
        Me.txtCodTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(128, 14)
        Me.txtCodTipoAhorro.MaxLength = 10
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.ReadOnly = True
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(56, 20)
        Me.txtCodTipoAhorro.TabIndex = 0
        '
        'txtTipoAhorro
        '
        Me.txtTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoAhorro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoAhorro.Location = New System.Drawing.Point(190, 14)
        Me.txtTipoAhorro.MaxLength = 110
        Me.txtTipoAhorro.Name = "txtTipoAhorro"
        Me.txtTipoAhorro.ReadOnly = True
        Me.txtTipoAhorro.Size = New System.Drawing.Size(338, 20)
        Me.txtTipoAhorro.TabIndex = 131
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.fg.ColumnInfo = "3,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(23, 141)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(626, 184)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 2
        Me.ttip.SetToolTip(Me.fg, "Presione Enter o barra espaciadora parar marcar las cuentas a las que se aplicará" &
        " inactividad")
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar1.Location = New System.Drawing.Point(218, 331)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(136, 28)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Green
        Me.btnAgregar1.TabIndex = 168
        Me.btnAgregar1.Text = "Verificar Ctas. Inactivas"
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.Location = New System.Drawing.Point(360, 331)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(127, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton1.TabIndex = 169
        Me.MetroButton1.Text = "Cobro por Inactividad"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton2.Location = New System.Drawing.Point(493, 331)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton2.TabIndex = 170
        Me.MetroButton2.Text = "Exportar"
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton3
        '
        Me.MetroButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton3.Location = New System.Drawing.Point(574, 331)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton3.TabIndex = 171
        Me.MetroButton3.Text = "Imprimir"
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'frmMsAhCuentasInactivas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(662, 382)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhCuentasInactivas"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Cobro por inactividad de Cuentas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1nMontComInact, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub frmMsAhCuentasInactivas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked = True Then
            Me.txtCodTipoAhorro.ReadOnly = True
            Me.txtCodTipoAhorro.Text = ""
            Me.txtTipoAhorro.Text = ""
        ElseIf Me.chkTodos.Checked = False Then
            Me.txtCodTipoAhorro.ReadOnly = False
        End If
    End Sub

    Private Sub txtCodTipoAhorro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoAhorro.DoubleClick
        Dim ofrm As New frmAGenerico
        Try
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet, dr As DataRow
            ds = oAhorro.ConsultarTipoAhorro("*", "", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
            ofrm.Text = "Buscar Tipos de Ahorro"
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim = "" Then Exit Sub
            txtCodTipoAhorro.Text = ofrm.Resultado.Trim
            txtTipoAhorro.Text = ofrm.Resultado2.Trim
            ds.Clear()
            ds = oAhorro.ConsultarParametros("Monto_ComisionInactividad", "CodTipoAhorro='" & ofrm.Resultado.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.c1nMontComInact.Value = IIf(dr("Monto_ComisionInactividad") Is DBNull.Value, 0, dr("Monto_ComisionInactividad"))
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Tipos de Ahorro - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Encabezado()

        fg.Cols.Item(0).Width = 100
        fg.Cols.Item(1).Width = 85
        fg.Cols.Item(2).Width = 80
        fg.Cols.Item(3).Width = 150
        fg.Cols.Item(4).Width = 70
        fg.Cols.Item(5).Width = 100
        fg.Cols.Item(6).Width = 150
        fg.Cols.Item(7).Width = 75
        fg.Cols.Item(8).Width = 0

        fg.Cols.Item(0).Caption = "Aplicar Inact."
        fg.Cols.Item(1).Caption = "Código Cuenta"
        fg.Cols.Item(2).Caption = "Tipo Cuenta"
        fg.Cols.Item(3).Caption = "Descripción"
        fg.Cols.Item(4).Caption = "Saldo Actual"
        fg.Cols.Item(5).Caption = "Fecha Últ.Transac."
        fg.Cols.Item(6).Caption = "Nombres Asociado"
        fg.Cols.Item(7).Caption = "Días Inact."
        fg.Cols.Item(8).Caption = "Fecha"

        Me.fg.Cols.Item(4).Format = "##0.00"

    End Sub


    Private Sub fg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fg.KeyDown
        If (e.KeyCode = Keys.Return Or e.KeyCode = Keys.Space) And fg.ColSel = 0 Then
            e.Handled = True
            fg.StartEditing()
        End If
    End Sub

    Private Sub fg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fg.KeyPress
        If e.KeyChar = ChrW(13) Or e.KeyChar = ChrW(32) Then
            e.Handled = True
        End If
    End Sub



    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim oAh As New wrAhorro.wsLibAhorro
            dsInactivas = oAh.ActualizaListadoCuentasInactivas(Me.dtpFecha.Value, Me.txtCodTipoAhorro.Text.Trim, Me.chkTodos.Checked, sUsuario, sPassword, sSucursal)
            fg.DataSource = dsInactivas.Tables("AhCuentasInactivas")
            Encabezado()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim oAh As New wrAhorro.wsLibAhorro, vResponse As String, x As Integer, dsSel As New DataSet
            dsSel = oAh.ObtenerEstructuraSeleccion(sUsuario, sPassword, sSucursal)
            For x = 1 To fg.Rows.Count - 1
                dsSel = oAh.AlmacenaEstructuraSeleccion(fg.Item(x, "Aplica_Inactividad"), fg.Item(x, "NoCuenta"), dsSel, sUsuario, sPassword, sSucursal)
            Next
            dsInactivas = oAh.ActualizaEstructuraCuentasInactivas(dsInactivas, dsSel, sUsuario, sPassword, sSucursal)
            vResponse = oAh.ActualizaCuentasInactivas(Me.dtpFecha.Value, dsInactivas, sUsuario, sPassword, sSucursal)
            If vResponse.Trim = "" Then
                MsgBox("Proceso finalizado con éxito.", MsgBoxStyle.OkOnly, "Módulo Ahorros")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim openDlg As SaveFileDialog = New SaveFileDialog
        Dim Resultado As DialogResult
        Try
            openDlg.Filter = "Archivos Excel (*.xml)|*.xml"
            openDlg.FileName = "CuentasInactivas"
            Resultado = openDlg.ShowDialog()
            If Resultado = DialogResult.OK Then
                If openDlg.FileName.Trim = "" Then
                    MessageBox.Show("Debe ingresar un nombre para el Nuevo Archivo.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                Else
                    dsInactivas.WriteXml(openDlg.FileName)
                    MessageBox.Show("El archivo ha sido generado.", "Exportación Cuentas Inactivas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet
        ds = oAh.Reporte_CuentasInactivas(dsInactivas, sUsuario, sPassword, sSucursal)
        Dim ofrm As New frmVisor(ds, 82, 0)
        ofrm.ShowDialog()
    End Sub
End Class