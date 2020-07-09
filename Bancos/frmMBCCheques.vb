Public Class frmMBCCheques
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAnular1 As MetroFramework.Controls.MetroButton
    Dim Bancos As New wrBancos.wsLibBancos

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
    Friend WithEvents C1fgrdCheques As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbFecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbNoCuenta As System.Windows.Forms.RadioButton
    Friend WithEvents rbNoPartida As System.Windows.Forms.RadioButton
    Friend WithEvents rbNoCheque As System.Windows.Forms.RadioButton
    Friend WithEvents txtNoCheque As System.Windows.Forms.TextBox
    Friend WithEvents txtNoChequeAl As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPartida As System.Windows.Forms.TextBox
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMBCCheques))
        Me.C1fgrdCheques = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.txtNoPartida = New System.Windows.Forms.TextBox()
        Me.txtNoChequeAl = New System.Windows.Forms.TextBox()
        Me.txtNoCheque = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.rbFecha = New System.Windows.Forms.RadioButton()
        Me.rbNoCuenta = New System.Windows.Forms.RadioButton()
        Me.rbNoPartida = New System.Windows.Forms.RadioButton()
        Me.rbNoCheque = New System.Windows.Forms.RadioButton()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.btnAnular1 = New MetroFramework.Controls.MetroButton()
        CType(Me.C1fgrdCheques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'C1fgrdCheques
        '
        Me.C1fgrdCheques.AllowEditing = False
        Me.C1fgrdCheques.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fgrdCheques.BackColor = System.Drawing.Color.White
        Me.C1fgrdCheques.ColumnInfo = "9,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdCheques.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.C1fgrdCheques.ForeColor = System.Drawing.Color.Black
        Me.C1fgrdCheques.Location = New System.Drawing.Point(28, 247)
        Me.C1fgrdCheques.Name = "C1fgrdCheques"
        Me.C1fgrdCheques.Rows.DefaultSize = 21
        Me.C1fgrdCheques.Size = New System.Drawing.Size(751, 139)
        Me.C1fgrdCheques.StyleInfo = resources.GetString("C1fgrdCheques.StyleInfo")
        Me.C1fgrdCheques.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.txtNoCuenta)
        Me.GroupBox2.Controls.Add(Me.txtNoPartida)
        Me.GroupBox2.Controls.Add(Me.txtNoChequeAl)
        Me.GroupBox2.Controls.Add(Me.txtNoCheque)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.dtpFecha)
        Me.GroupBox2.Controls.Add(Me.rbFecha)
        Me.GroupBox2.Controls.Add(Me.rbNoCuenta)
        Me.GroupBox2.Controls.Add(Me.rbNoPartida)
        Me.GroupBox2.Controls.Add(Me.rbNoCheque)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(746, 128)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Filtrar registros por:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(643, 85)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(90, 33)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 20
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuenta.Location = New System.Drawing.Point(412, 55)
        Me.txtNoCuenta.MaxLength = 25
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.Size = New System.Drawing.Size(182, 22)
        Me.txtNoCuenta.TabIndex = 6
        '
        'txtNoPartida
        '
        Me.txtNoPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoPartida.Location = New System.Drawing.Point(222, 55)
        Me.txtNoPartida.MaxLength = 20
        Me.txtNoPartida.Name = "txtNoPartida"
        Me.txtNoPartida.Size = New System.Drawing.Size(182, 22)
        Me.txtNoPartida.TabIndex = 4
        '
        'txtNoChequeAl
        '
        Me.txtNoChequeAl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoChequeAl.Location = New System.Drawing.Point(58, 83)
        Me.txtNoChequeAl.MaxLength = 10
        Me.txtNoChequeAl.Name = "txtNoChequeAl"
        Me.txtNoChequeAl.Size = New System.Drawing.Size(144, 22)
        Me.txtNoChequeAl.TabIndex = 2
        '
        'txtNoCheque
        '
        Me.txtNoCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCheque.Location = New System.Drawing.Point(58, 55)
        Me.txtNoCheque.MaxLength = 10
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.Size = New System.Drawing.Size(144, 22)
        Me.txtNoCheque.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Al"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Del"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(601, 55)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(132, 22)
        Me.dtpFecha.TabIndex = 8
        '
        'rbFecha
        '
        Me.rbFecha.BackColor = System.Drawing.Color.White
        Me.rbFecha.Checked = True
        Me.rbFecha.ForeColor = System.Drawing.Color.Black
        Me.rbFecha.Location = New System.Drawing.Point(601, 28)
        Me.rbFecha.Name = "rbFecha"
        Me.rbFecha.Size = New System.Drawing.Size(117, 27)
        Me.rbFecha.TabIndex = 7
        Me.rbFecha.TabStop = True
        Me.rbFecha.Text = "&Fecha"
        Me.rbFecha.UseVisualStyleBackColor = False
        '
        'rbNoCuenta
        '
        Me.rbNoCuenta.BackColor = System.Drawing.Color.White
        Me.rbNoCuenta.ForeColor = System.Drawing.Color.Black
        Me.rbNoCuenta.Location = New System.Drawing.Point(412, 28)
        Me.rbNoCuenta.Name = "rbNoCuenta"
        Me.rbNoCuenta.Size = New System.Drawing.Size(182, 27)
        Me.rbNoCuenta.TabIndex = 5
        Me.rbNoCuenta.Text = "No. &Cuenta Bancaria"
        Me.rbNoCuenta.UseVisualStyleBackColor = False
        '
        'rbNoPartida
        '
        Me.rbNoPartida.BackColor = System.Drawing.Color.White
        Me.rbNoPartida.ForeColor = System.Drawing.Color.Black
        Me.rbNoPartida.Location = New System.Drawing.Point(222, 28)
        Me.rbNoPartida.Name = "rbNoPartida"
        Me.rbNoPartida.Size = New System.Drawing.Size(182, 27)
        Me.rbNoPartida.TabIndex = 3
        Me.rbNoPartida.Text = "No. &Partida"
        Me.rbNoPartida.UseVisualStyleBackColor = False
        '
        'rbNoCheque
        '
        Me.rbNoCheque.BackColor = System.Drawing.Color.White
        Me.rbNoCheque.ForeColor = System.Drawing.Color.Black
        Me.rbNoCheque.Location = New System.Drawing.Point(19, 28)
        Me.rbNoCheque.Name = "rbNoCheque"
        Me.rbNoCheque.Size = New System.Drawing.Size(183, 27)
        Me.rbNoCheque.TabIndex = 0
        Me.rbNoCheque.Text = "&Número de Cheque"
        Me.rbNoCheque.UseVisualStyleBackColor = False
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(319, 208)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(90, 32)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 23
        Me.btnImp.Text = "Consultar"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(222, 208)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(90, 32)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 22
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(125, 208)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(90, 32)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 21
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(28, 208)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(90, 32)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 20
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'btnAnular1
        '
        Me.btnAnular1.Location = New System.Drawing.Point(416, 208)
        Me.btnAnular1.Name = "btnAnular1"
        Me.btnAnular1.Size = New System.Drawing.Size(90, 32)
        Me.btnAnular1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAnular1.TabIndex = 24
        Me.btnAnular1.Text = "Anular"
        Me.btnAnular1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAnular1.UseSelectable = True
        Me.btnAnular1.UseStyleColors = True
        '
        'frmMBCCheques
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(803, 461)
        Me.Controls.Add(Me.btnAnular1)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.C1fgrdCheques)
        Me.Name = "frmMBCCheques"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Cheques"
        CType(Me.C1fgrdCheques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub C1fgrdCheques_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1fgrdCheques.DoubleClick
        btnImp_Click(sender, e)
    End Sub
    Private Sub frmMBCCheques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oLibBco As wrBancos.wsLibBancos, ds As Data.DataSet = New Data.DataSet
            oLibBco = New wrBancos.wsLibBancos
            ds = oLibBco.ObtenerCheque("b.*", "Fecha_Mov='" & Format(Date.Now, "dd/MM/yyyy") & "'", "IdMovimiento asc", sUsuario, sPassword, sSucursal)

            C1fgrdCheques.DataSource = ds.Tables(0).DefaultView
            Encabezado()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Encabezado()

        C1fgrdCheques.Cols.Item(1).Caption = "No. Cheque"
        C1fgrdCheques.Cols.Item(2).Caption = "No. Partida"
        C1fgrdCheques.Cols.Item(3).Caption = "Estado"
        C1fgrdCheques.Cols.Item(4).Caption = "No. Cta. Bancaria"
        C1fgrdCheques.Cols.Item(5).Caption = "Tipo Movimiento"
        C1fgrdCheques.Cols.Item(6).Caption = "Fecha"
        C1fgrdCheques.Cols.Item(7).Caption = "Concepto"
        C1fgrdCheques.Cols.Item(8).Caption = "Cantidad"
        C1fgrdCheques.Cols.Item(9).Caption = "Ciudad"
        C1fgrdCheques.Cols.Item(10).Caption = "Paguese"
        C1fgrdCheques.Cols.Item(11).Caption = "Usuario"
        C1fgrdCheques.Cols.Item(12).Caption = "Fecha Anula"
        C1fgrdCheques.Cols.Item(13).Caption = "Usuario Anula"

        C1fgrdCheques.Cols.Item(1).Width = 100
        C1fgrdCheques.Cols.Item(2).Width = 200
        C1fgrdCheques.Cols.Item(3).Width = 77
        C1fgrdCheques.Cols.Item(4).Width = 150
        C1fgrdCheques.Cols.Item(5).Width = 77
        C1fgrdCheques.Cols.Item(6).Width = 77
        C1fgrdCheques.Cols.Item(7).Width = 300
        C1fgrdCheques.Cols.Item(8).Width = 77
        C1fgrdCheques.Cols.Item(9).Width = 150
        C1fgrdCheques.Cols.Item(10).Width = 100
        C1fgrdCheques.Cols.Item(11).Width = 77
        C1fgrdCheques.Cols.Item(12).Width = 77
        C1fgrdCheques.Cols.Item(13).Width = 77

    End Sub
    Private Sub rbNoCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoCheque.CheckedChanged
        Me.txtNoCheque.Focus()
    End Sub
    Private Sub rbNoPartida_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoPartida.CheckedChanged
        Me.txtNoPartida.Focus()
    End Sub
    Private Sub rbNoCuenta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoCuenta.CheckedChanged
        Me.txtNoCuenta.Focus()
    End Sub
    Private Sub rbFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbFecha.CheckedChanged
        Me.dtpFecha.Focus()
    End Sub
    Private Sub txtNoCheque_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoCheque.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub
    Private Sub txtNoChequeAl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoChequeAl.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub
    Private Sub txtNoCuenta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoCuenta.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub
    Private Sub txtNoPartida_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoPartida.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub
    Private Sub dtpFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFecha.KeyDown
        If e.KeyData = Keys.Return Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try
            Dim oCred As wrBancos.wsLibBancos, ds As New Data.DataSet ', pDui As String
            Dim Filas As Data.DataRowCollection
            oCred = New wrBancos.wsLibBancos
            If rbNoCheque.Checked = True Then
                If Me.txtNoChequeAl.Text.Trim = "" Then
                    ds = oCred.ObtenerCheque("b.*", "IdMovimiento='" & Val(Me.txtNoCheque.Text) & "'", "IdMovimiento", sUsuario, sPassword, sSucursal)
                Else
                    ds = oCred.ObtenerCheque("b.*", "IdMovimiento>='" & Val(Me.txtNoCheque.Text) & "' and IdMovimiento<='" & Val(Me.txtNoChequeAl.Text) & "'", "IdMovimiento", sUsuario, sPassword, sSucursal)
                End If
            ElseIf rbNoCuenta.Checked = True Then
                ds = oCred.ObtenerCheque("b.*", "IdCtaBanco='" & Trim(Me.txtNoCuenta.Text) & "'", "IdMovimiento", sUsuario, sPassword, sSucursal)
            ElseIf rbNoPartida.Checked = True Then
                ds = oCred.ObtenerCheque("b.*", "Num_Partida='" & Trim(Me.txtNoPartida.Text) & "'", "IdMovimiento", sUsuario, sPassword, sSucursal)
            ElseIf rbFecha.Checked = True Then
                ds = oCred.ObtenerCheque("b.*", "Fecha_Mov='" & Format(dtpFecha.Value, "dd/MM/yyyy") & "'", "IdMovimiento", sUsuario, sPassword, sSucursal)
            End If
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                C1fgrdCheques.DataSource = ds.Tables(0)
                Encabezado()
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim ofrm As New frmMsBCCheque, oLibBco As New wrBancos.wsLibBancos, ds As DataSet
            'ofrm.Accion = Seguridad.clsUsuario.TipoAccion.Insertar
            ofrm.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Insertar
            ofrm.ShowDialog()
            ds = oLibBco.ObtenerCheque("b.*", "", "IdMovimiento", sUsuario, sPassword, sSucursal)
            btnMostrar1_Click(sender, e)
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            Dim ofrm As New frmMsBCCheque, oLibBco As New wrBancos.wsLibBancos ' ds As DataSet
            'ofrm.Accion = Seguridad.clsUsuario.TipoAccion.Modificar
            ofrm.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Modificar
            If C1fgrdCheques.Row <> -1 Then
                If CStr(C1fgrdCheques.Item(C1fgrdCheques.Row, "IdEstado")).Trim = "I" Then
                    'ofrm.Estado = Bancos.clsBCBanco.EstadoCheques.Impreso
                    ofrm.Estado = sifLib.Bancos.clsBCBancos.EstadoCheques.Impreso
                    ofrm.btnGuardar1.Enabled = False
                    'ofrm.btnCerrar.Enabled = False
                ElseIf CStr(C1fgrdCheques.Item(C1fgrdCheques.Row, "IdEstado")).Trim = "A" Then
                    'ofrm.Estado = Bancos.clsBCBanco.EstadoCheques.Anulado
                    ofrm.Estado = sifLib.Bancos.clsBCBancos.EstadoCheques.Anulado
                    Exit Sub
                ElseIf CStr(C1fgrdCheques.Item(C1fgrdCheques.Row, "IdEstado")).Trim = "D" Then
                    'ofrm.Estado = Bancos.clsBCBanco.EstadoCheques.Digitado
                    ofrm.Estado = sifLib.Bancos.clsBCBancos.EstadoCheques.Digitado
                End If
                ofrm.NoPartida = C1fgrdCheques.Item(C1fgrdCheques.Row, "Num_Partida")
                ofrm.txtNumPartida.Text = C1fgrdCheques.Item(C1fgrdCheques.Row, "Num_Partida")
                ofrm.txtNoCheque.Text = C1fgrdCheques.Item(C1fgrdCheques.Row, "IdMovimiento")
                ofrm.txtCtaBanco.Text = C1fgrdCheques.Item(C1fgrdCheques.Row, "IdCtaBanco")
                ofrm.dtpFec.Value = C1fgrdCheques.Item(C1fgrdCheques.Row, "Fecha_Mov")
                ofrm.C1NEMonto.Value = C1fgrdCheques.Item(C1fgrdCheques.Row, "Cantidad")
                ofrm.txtConcepto.Text = C1fgrdCheques.Item(C1fgrdCheques.Row, "Concepto")
                ofrm.txtCiudad.Text = C1fgrdCheques.Item(C1fgrdCheques.Row, "Ciudad")
                ofrm.txtPagueseA.Text = C1fgrdCheques.Item(C1fgrdCheques.Row, "Paguese")
                ofrm.ShowDialog()
            End If
            frmMBCCheques_Load(sender, e)
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If C1fgrdCheques.Row <> -1 Then
                If CStr(C1fgrdCheques.Item(C1fgrdCheques.Row, "IdEstado")).Trim = "I" Then
                    MsgBox("El Registro no se puede eliminar. Se encuentra Impreso.", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Eliminar Cheque")
                    Exit Sub
                ElseIf CStr(C1fgrdCheques.Item(C1fgrdCheques.Row, "IdEstado")).Trim = "A" Then
                    MsgBox("El Registro no se puede eliminar. Se encuentra Anulado.", MsgBoxStyle.Critical Or MsgBoxStyle.OkOnly, "Eliminar Cheque")
                    Exit Sub
                ElseIf CStr(C1fgrdCheques.Item(C1fgrdCheques.Row, "IdEstado")).Trim = "D" Then
                    Exit Sub
                End If
                If MsgBox("¿Desea eliminar el Registro: " & C1fgrdCheques.Item(C1fgrdCheques.Row, "Nom_Banco") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Cheque") = MsgBoxResult.Yes Then
                    Dim oLibBco As wrBancos.wsLibBancos = New wrBancos.wsLibBancos, ds As DataSet
                    oLibBco.EliminaCheque(C1fgrdCheques.Item(C1fgrdCheques.Row, "IdBanco"), sUsuario, sPassword, sSucursal)
                    ds = oLibBco.ObtenerCheque("b.*", "", "IdMovimiento", sUsuario, sPassword, sSucursal)
                    btnMostrar1_Click(sender, e)
                End If
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            If C1fgrdCheques.Row <> -1 Then
                Dim frm As frmMsBCCheque = New frmMsBCCheque
                'frm.Accion = Seguridad.clsUsuario.TipoAccion.Consultar
                frm.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Consultar
                frm.NoPartida = C1fgrdCheques.Item(C1fgrdCheques.Row, "Num_Partida")
                frm.txtNumPartida.Text = C1fgrdCheques.Item(C1fgrdCheques.Row, "Num_Partida")
                frm.txtNoCheque.Text = C1fgrdCheques.Item(C1fgrdCheques.Row, "IdMovimiento")
                frm.txtCtaBanco.Text = C1fgrdCheques.Item(C1fgrdCheques.Row, "IdCtaBanco")
                frm.dtpFec.Value = C1fgrdCheques.Item(C1fgrdCheques.Row, "Fecha_Mov")
                frm.C1NEMonto.Value = C1fgrdCheques.Item(C1fgrdCheques.Row, "Cantidad")
                frm.txtConcepto.Text = C1fgrdCheques.Item(C1fgrdCheques.Row, "Concepto")
                frm.txtCiudad.Text = C1fgrdCheques.Item(C1fgrdCheques.Row, "Ciudad")
                frm.txtPagueseA.Text = C1fgrdCheques.Item(C1fgrdCheques.Row, "Paguese")
                frm.btnGuardar1.Enabled = False
                frm.btnImprimir1.Enabled = True
                'frm.btnCerrar.Enabled = False
                If CStr(C1fgrdCheques.Item(C1fgrdCheques.Row, "IdEstado")).Trim = "A" Then
                    'frm.Estado = Bancos.clsBCBanco.EstadoCheques.Anulado
                    frm.Estado = sifLib.Bancos.clsBCBancos.EstadoCheques.Anulado
                End If
                frm.ShowDialog()
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAnular1_Click(sender As Object, e As EventArgs) Handles btnAnular1.Click
        Try
            Dim Filas As DataRowCollection, pTrasladado As String, dsDat As New Data.DataSet, pAnulado As String
            If C1fgrdCheques.Row <> -1 Then
                If MsgBox("¿Desea Anular el Registro: " & C1fgrdCheques.Item(C1fgrdCheques.Row, "IdMovimiento") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Anular Cheque") = MsgBoxResult.Yes Then
                    Dim oLibBco As wrBancos.wsLibBancos = New wrBancos.wsLibBancos, ds As DataSet
                    dsDat = oLibBco.ObtenerPartida(C1fgrdCheques.Item(C1fgrdCheques.Row, "IdMovimiento"), sUsuario, sPassword, sSucursal)
                    Filas = dsDat.Tables(1).Rows()

                    If C1fgrdCheques.Item(C1fgrdCheques.Row, "idEstado") = "A" Then
                        MessageBox.Show("El cheque ya se encuentra anulado.", "Captura de Error", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    End If
                    If pTrasladado = "1" Then

                        oLibBco.AnulaCheque(C1fgrdCheques.Item(C1fgrdCheques.Row, "IdMovimiento"),
                                            True, sUsuario, sPassword, sSucursal, C1fgrdCheques.Item(C1fgrdCheques.Row, "Num_Partida"))

                    Else
                        oLibBco.AnulaCheque(C1fgrdCheques.Item(C1fgrdCheques.Row, "IdMovimiento"),
                                            False, sUsuario, sPassword, sSucursal, C1fgrdCheques.Item(C1fgrdCheques.Row, "Num_Partida"))
                    End If

                    ds = oLibBco.ObtenerCheque("b.*", "", "IdMovimiento", sUsuario, sPassword, sSucursal)
                    btnMostrar1_Click(sender, e)
                End If
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMBCCheques_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class