Public Class frmMCaReversiones
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim asociados As New wrAsociados.wsLibAsoc
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Dim caja As New wrCaja.wsLibCaja
    Dim seguridad As New wrAdmin.wsLibAdmin


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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFechaMovimiento As MetroFramework.Controls.MetroDateTime
    Friend WithEvents cbSucursal As MetroFramework.Controls.MetroComboBox
    Friend WithEvents rbNoCaja As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents cbCaja As MetroFramework.Controls.MetroComboBox
    Friend WithEvents rbCajero As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents cbCajero As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCaReversiones))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFechaMovimiento = New MetroFramework.Controls.MetroDateTime()
        Me.cbSucursal = New MetroFramework.Controls.MetroComboBox()
        Me.rbNoCaja = New MetroFramework.Controls.MetroRadioButton()
        Me.cbCaja = New MetroFramework.Controls.MetroComboBox()
        Me.rbCajero = New MetroFramework.Controls.MetroRadioButton()
        Me.cbCajero = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.AllowFiltering = True
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:15;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.fg.Location = New System.Drawing.Point(28, 248)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(700, 359)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 18
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(541, 210)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(90, 32)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 47
        Me.btnMostrar1.Text = "Buscar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(23, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 18)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Fecha de Movimiento:"
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(637, 211)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 33)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 48
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel1.Location = New System.Drawing.Point(23, 60)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(100, 25)
        Me.MetroLabel1.TabIndex = 49
        Me.MetroLabel1.Text = "Buscar por:"
        '
        'dtpFechaMovimiento
        '
        Me.dtpFechaMovimiento.Enabled = False
        Me.dtpFechaMovimiento.Location = New System.Drawing.Point(23, 115)
        Me.dtpFechaMovimiento.MinimumSize = New System.Drawing.Size(0, 30)
        Me.dtpFechaMovimiento.Name = "dtpFechaMovimiento"
        Me.dtpFechaMovimiento.Size = New System.Drawing.Size(332, 30)
        Me.dtpFechaMovimiento.TabIndex = 50
        '
        'cbSucursal
        '
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.ItemHeight = 24
        Me.cbSucursal.Location = New System.Drawing.Point(395, 115)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(332, 30)
        Me.cbSucursal.TabIndex = 52
        Me.cbSucursal.UseSelectable = True
        '
        'rbNoCaja
        '
        Me.rbNoCaja.AutoSize = True
        Me.rbNoCaja.Location = New System.Drawing.Point(23, 151)
        Me.rbNoCaja.Name = "rbNoCaja"
        Me.rbNoCaja.Size = New System.Drawing.Size(96, 17)
        Me.rbNoCaja.TabIndex = 53
        Me.rbNoCaja.Text = "No. de Caja:"
        Me.rbNoCaja.UseSelectable = True
        '
        'cbCaja
        '
        Me.cbCaja.FormattingEnabled = True
        Me.cbCaja.ItemHeight = 24
        Me.cbCaja.Location = New System.Drawing.Point(23, 174)
        Me.cbCaja.Name = "cbCaja"
        Me.cbCaja.Size = New System.Drawing.Size(332, 30)
        Me.cbCaja.TabIndex = 54
        Me.cbCaja.UseSelectable = True
        '
        'rbCajero
        '
        Me.rbCajero.AutoSize = True
        Me.rbCajero.Location = New System.Drawing.Point(395, 151)
        Me.rbCajero.Name = "rbCajero"
        Me.rbCajero.Size = New System.Drawing.Size(65, 17)
        Me.rbCajero.TabIndex = 55
        Me.rbCajero.Text = "Cajero:"
        Me.rbCajero.UseSelectable = True
        '
        'cbCajero
        '
        Me.cbCajero.FormattingEnabled = True
        Me.cbCajero.ItemHeight = 24
        Me.cbCajero.Location = New System.Drawing.Point(395, 174)
        Me.cbCajero.Name = "cbCajero"
        Me.cbCajero.Size = New System.Drawing.Size(332, 30)
        Me.cbCajero.TabIndex = 56
        Me.cbCajero.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(395, 92)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(63, 20)
        Me.MetroLabel2.TabIndex = 57
        Me.MetroLabel2.Text = "Sucursal:"
        '
        'frmMCaReversiones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(755, 672)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.btnMostrar1)
        Me.Controls.Add(Me.cbCajero)
        Me.Controls.Add(Me.rbCajero)
        Me.Controls.Add(Me.cbCaja)
        Me.Controls.Add(Me.rbNoCaja)
        Me.Controls.Add(Me.cbSucursal)
        Me.Controls.Add(Me.dtpFechaMovimiento)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.fg)
        Me.Name = "frmMCaReversiones"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Reversiones"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region





    Private Sub llenarSucursales()
        Dim dts As New DataSet
        dts = asociados.ConsultarSucursales("Nom_Sucursal,codSucursal", "", "Nom_Sucursal", sUsuario, sPassword, sSucursal)
        If dts.Tables(0).Rows.Count > 0 Then
            Me.cbSucursal.DataSource = dts.Tables(0)
        End If
    End Sub
    Private Sub llenarCajeros(sucursal As String)
        Dim dts As New DataSet
        Me.cbCajero.DisplayMember = "nombre"
        Me.cbCajero.ValueMember = "codCajero"
        dts = caja.ConsultarCajeros("codCajero,nombre", " codSucursal = '" & sucursal & "' ", " nombre", sUsuario, sSucursal, sPassword)
        If dts.Tables(0).Rows.Count > 0 Then
            Me.cbCajero.DataSource = dts.Tables(0)
        End If
    End Sub
    Private Sub llenarCajas(sucursal As String)

        Dim dts As New DataSet
        Me.cbCaja.DisplayMember = "NoCaja"
        Me.cbCaja.ValueMember = "NoCaja"
        dts = caja.ConsultarCajas("NoCaja", " codSucursal = '" & sucursal & "' ", "", sUsuario, sSucursal, sPassword)
        If dts.Tables(0).Rows.Count > 0 Then
            Me.cbCaja.DataSource = dts.Tables(0)
        End If
    End Sub

    Private Sub frmMCaReversiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtsRoles As New DataSet
        dtsRoles = seguridad.ConsultarRolesUsuario(sUsuario, "", 2)
        Dim dts As New DataSet
        For I As Integer = 0 To dtsRoles.Tables(0).Rows.Count - 1
            If seguridad.ConsultarPermisoProcesos("CAI007", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                dts = asociados.ConsultarSucursales("CodSucursal,Nom_Sucursal", "codSucursal = '" & sSucursal & "'", "Nom_Sucursal", sUsuario, sPassword, sSucursal)
                llenarCajas(sSucursal)
                llenarCajeros(sSucursal)
                Me.cbSucursal.Enabled = False
                Exit For
            ElseIf seguridad.ConsultarPermisoProcesos("CAI008", dtsRoles.Tables(0).Rows(I).Item("CodRol").ToString.Trim, 4) Then
                dts = asociados.ConsultarSucursales("CodSucursal,Nom_Sucursal", "", "Nom_Sucursal", sUsuario, sPassword, sSucursal)

                Exit For
            End If
        Next
        If dts.Tables(0).Rows.Count > 0 Then
            cbSucursal.DisplayMember = "Nom_Sucursal"
            cbSucursal.ValueMember = "CodSucursal"
            Me.cbSucursal.DataSource = dts.Tables(0)
        End If
    End Sub

    Private Sub txtCajero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtNoCaja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub dtpFechaMovimiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyData = Keys.Return Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try
            Dim oCaja As New wrCaja.wsLibCaja
            ', oApp As New wrAdmin.wsLibAdmin
            Dim ds As New DataSet
            If Me.rbNoCaja.Checked = True Then

                ds = oCaja.ConsultarFacturasxFiltro("*", "NoCaja=" & Me.cbCaja.SelectedValue & " and Fec_Mov='" & Me.dtpFechaMovimiento.Value.ToShortDateString & "'", "IdMovimiento", sUsuario, sPassword, sSucursal)
            ElseIf Me.rbCajero.Checked = True Then
                ds = oCaja.ConsultarFacturasxFiltro("*", "CodCajero=" & cbCajero.SelectedValue.ToString & " and Fec_Mov='" & Me.dtpFechaMovimiento.Value.ToShortDateString & "'", "IdMovimiento", sUsuario, sPassword, sSucursal)
                'ElseIf rbSucursal.Checked = True Then
                '    ds = oCaja.ConsultarFacturasxFiltro("*", "codSucursal =" & cbSucursal.SelectedValue.ToString & " and Fec_Mov='" & Me.dtpFechaMovimiento.Value.ToShortDateString & "'", "IdMovimiento", sUsuario, sPassword, sSucursal)
            End If
            Me.fg.DataSource = ds.Tables(0)
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            If fg.Row > 0 Then
                If Trim(fg.Item(fg.Row, "Estado")) = "A" Then
                    MessageBox.Show("El documento ya se encuentra anulado, verifíque.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
                Dim ofrm As New frmMsCaConsultaFactura
                ofrm.IdMovimiento = fg.Item(fg.Row, "IdMovimiento")
                ofrm.Annio = fg.Item(fg.Row, "Annio")
                ofrm.Tipo = fg.Item(fg.Row, "Tipo")
                ofrm.NoCaja = fg.Item(fg.Row, "NoCaja")
                ofrm.CodCajero = fg.Item(fg.Row, "CodCajero")
                ofrm.codSucursal = fg.Item(fg.Row, "CodSucursal")
                ofrm.ShowDialog()
                btnMostrar1_Click(sender, e)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fg_Click(sender As Object, e As EventArgs) Handles fg.Click

    End Sub

    Private Sub cbSucursal_DropDownClosed(sender As Object, e As EventArgs) Handles cbSucursal.DropDownClosed
        llenarCajas(cbSucursal.SelectedValue)
        llenarCajeros(cbSucursal.SelectedValue)
    End Sub
End Class