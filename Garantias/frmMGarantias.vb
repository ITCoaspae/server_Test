Public Class frmMGarantias
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents lblESTADO As System.Windows.Forms.Label
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCertExt1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Dim CREDITO As New wrCredito.wsLibCred

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoSolicitudAl As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNoSocio As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtNoSolicitud As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents rbNoSocio As System.Windows.Forms.RadioButton
    Friend WithEvents rbDui As System.Windows.Forms.RadioButton
    Friend WithEvents rbNoSolic As System.Windows.Forms.RadioButton
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents rbCodPrestamo As System.Windows.Forms.RadioButton
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents rbNombres As System.Windows.Forms.RadioButton
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMGarantias))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.rbNombres = New System.Windows.Forms.RadioButton()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoSolicitudAl = New C1.Win.C1Input.C1NumericEdit()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoSocio = New C1.Win.C1Input.C1NumericEdit()
        Me.txtNoSolicitud = New C1.Win.C1Input.C1NumericEdit()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.rbCodPrestamo = New System.Windows.Forms.RadioButton()
        Me.rbNoSocio = New System.Windows.Forms.RadioButton()
        Me.rbDui = New System.Windows.Forms.RadioButton()
        Me.rbNoSolic = New System.Windows.Forms.RadioButton()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.lblESTADO = New System.Windows.Forms.Label()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnCertExt1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtNoSolicitudAl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoSocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.rbNombres)
        Me.GroupBox2.Controls.Add(Me.cbNombres)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtNoSolicitudAl)
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.txtNoSocio)
        Me.GroupBox2.Controls.Add(Me.txtNoSolicitud)
        Me.GroupBox2.Controls.Add(Me.txtCodPrestamo)
        Me.GroupBox2.Controls.Add(Me.rbCodPrestamo)
        Me.GroupBox2.Controls.Add(Me.rbNoSocio)
        Me.GroupBox2.Controls.Add(Me.rbDui)
        Me.GroupBox2.Controls.Add(Me.rbNoSolic)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(707, 112)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Filtrar registros por:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(626, 76)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 218
        Me.MetroButton1.Text = "&Buscar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(254, 84)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(232, 20)
        Me.txtNombres.TabIndex = 11
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.ForeColor = System.Drawing.Color.Black
        Me.rbNombres.Location = New System.Drawing.Point(16, 78)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(107, 24)
        Me.rbNombres.TabIndex = 9
        Me.rbNombres.Text = "N&ombres"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Enabled = False
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(129, 81)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(119, 21)
        Me.cbNombres.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(367, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Al"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(129, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Del"
        '
        'txtNoSolicitudAl
        '
        Me.txtNoSolicitudAl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSolicitudAl.CustomFormat = "######"
        Me.txtNoSolicitudAl.DataType = GetType(Integer)
        Me.txtNoSolicitudAl.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNoSolicitudAl.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtNoSolicitudAl.Increment = 1
        Me.txtNoSolicitudAl.Location = New System.Drawing.Point(397, 54)
        Me.txtNoSolicitudAl.Name = "txtNoSolicitudAl"
        Me.txtNoSolicitudAl.ShowDropDownButton = False
        Me.txtNoSolicitudAl.ShowUpDownButtons = False
        Me.txtNoSolicitudAl.Size = New System.Drawing.Size(89, 21)
        Me.txtNoSolicitudAl.TabIndex = 8
        Me.txtNoSolicitudAl.Tag = Nothing
        Me.txtNoSolicitudAl.Value = 0
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(132, 24)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(116, 20)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.CustomFormat = "#######0"
        Me.txtNoSocio.DataType = GetType(Short)
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNoSocio.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtNoSocio.Increment = CType(1, Short)
        Me.txtNoSocio.Location = New System.Drawing.Point(370, 24)
        Me.txtNoSocio.MaxLength = 10
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ShowDropDownButton = False
        Me.txtNoSocio.ShowUpDownButtons = False
        Me.txtNoSocio.Size = New System.Drawing.Size(116, 21)
        Me.txtNoSocio.TabIndex = 3
        Me.txtNoSocio.Tag = Nothing
        Me.txtNoSocio.Value = CType(0, Short)
        '
        'txtNoSolicitud
        '
        Me.txtNoSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSolicitud.CustomFormat = "######"
        Me.txtNoSolicitud.DataType = GetType(Integer)
        Me.txtNoSolicitud.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNoSolicitud.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtNoSolicitud.Increment = 1
        Me.txtNoSolicitud.Location = New System.Drawing.Point(159, 54)
        Me.txtNoSolicitud.Name = "txtNoSolicitud"
        Me.txtNoSolicitud.ShowDropDownButton = False
        Me.txtNoSolicitud.ShowUpDownButtons = False
        Me.txtNoSolicitud.Size = New System.Drawing.Size(89, 21)
        Me.txtNoSolicitud.TabIndex = 7
        Me.txtNoSolicitud.Tag = Nothing
        Me.txtNoSolicitud.Value = 0
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Enabled = False
        Me.txtCodPrestamo.Location = New System.Drawing.Point(585, 25)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(116, 20)
        Me.txtCodPrestamo.TabIndex = 5
        '
        'rbCodPrestamo
        '
        Me.rbCodPrestamo.BackColor = System.Drawing.Color.White
        Me.rbCodPrestamo.ForeColor = System.Drawing.Color.Black
        Me.rbCodPrestamo.Location = New System.Drawing.Point(492, 24)
        Me.rbCodPrestamo.Name = "rbCodPrestamo"
        Me.rbCodPrestamo.Size = New System.Drawing.Size(110, 24)
        Me.rbCodPrestamo.TabIndex = 4
        Me.rbCodPrestamo.Text = "&Pr�stamo"
        Me.rbCodPrestamo.UseVisualStyleBackColor = False
        '
        'rbNoSocio
        '
        Me.rbNoSocio.BackColor = System.Drawing.Color.White
        Me.rbNoSocio.ForeColor = System.Drawing.Color.Black
        Me.rbNoSocio.Location = New System.Drawing.Point(254, 24)
        Me.rbNoSocio.Name = "rbNoSocio"
        Me.rbNoSocio.Size = New System.Drawing.Size(110, 24)
        Me.rbNoSocio.TabIndex = 2
        Me.rbNoSocio.Text = "No. Asociado"
        Me.rbNoSocio.UseVisualStyleBackColor = False
        '
        'rbDui
        '
        Me.rbDui.BackColor = System.Drawing.Color.White
        Me.rbDui.Checked = True
        Me.rbDui.ForeColor = System.Drawing.Color.Black
        Me.rbDui.Location = New System.Drawing.Point(16, 24)
        Me.rbDui.Name = "rbDui"
        Me.rbDui.Size = New System.Drawing.Size(110, 24)
        Me.rbDui.TabIndex = 0
        Me.rbDui.TabStop = True
        Me.rbDui.Text = "&DUI de Asociado"
        Me.rbDui.UseVisualStyleBackColor = False
        '
        'rbNoSolic
        '
        Me.rbNoSolic.BackColor = System.Drawing.Color.White
        Me.rbNoSolic.ForeColor = System.Drawing.Color.Black
        Me.rbNoSolic.Location = New System.Drawing.Point(16, 48)
        Me.rbNoSolic.Name = "rbNoSolic"
        Me.rbNoSolic.Size = New System.Drawing.Size(110, 24)
        Me.rbNoSolic.TabIndex = 6
        Me.rbNoSolic.Text = "&No. de Solicitud"
        Me.rbNoSolic.UseVisualStyleBackColor = False
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "20,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(20, 215)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Size = New System.Drawing.Size(717, 146)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 18
        '
        'lblESTADO
        '
        Me.lblESTADO.AutoSize = True
        Me.lblESTADO.BackColor = System.Drawing.Color.White
        Me.lblESTADO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblESTADO.ForeColor = System.Drawing.Color.Teal
        Me.lblESTADO.Location = New System.Drawing.Point(467, 189)
        Me.lblESTADO.Name = "lblESTADO"
        Me.lblESTADO.Size = New System.Drawing.Size(63, 20)
        Me.lblESTADO.TabIndex = 20
        Me.lblESTADO.Text = "Label3"
        Me.lblESTADO.Visible = False
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(322, 181)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(139, 28)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 218
        Me.btnEliminar1.Text = "&Inscripci�n de Garant�as"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(182, 181)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(134, 28)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 217
        Me.btnModificar1.Text = "&Anotaci�n Preventiva"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnCertExt1
        '
        Me.btnCertExt1.Location = New System.Drawing.Point(23, 181)
        Me.btnCertExt1.Name = "btnCertExt1"
        Me.btnCertExt1.Size = New System.Drawing.Size(153, 28)
        Me.btnCertExt1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCertExt1.TabIndex = 216
        Me.btnCertExt1.Text = "&Certificaci�n Extractada"
        Me.btnCertExt1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCertExt1.UseSelectable = True
        Me.btnCertExt1.UseStyleColors = True
        '
        'frmMGarantias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(751, 399)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnCertExt1)
        Me.Controls.Add(Me.lblESTADO)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fg)
        Me.Name = "frmMGarantias"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Garant�as"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtNoSolicitudAl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoSocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Encabezado()
        fg.Cols.Item(1).Caption = "No."
        fg.Cols.Item(2).Caption = "Nombres"
        fg.Cols.Item(3).Caption = "Primer Apellido"
        fg.Cols.Item(4).Caption = "Segundo Apellido"
        fg.Cols.Item(5).Caption = "Apellido de Casada"
        fg.Cols.Item(6).Caption = "Tel�fonos"
        fg.Cols.Item(7).Caption = "Direcci�n"
        fg.Cols.Item(8).Caption = "Fecha de Entrega"
        fg.Cols.Item(9).Caption = "Lugar de Trabajo"
        fg.Cols.Item(10).Caption = "Direcci�n de Trabajo"
        fg.Cols.Item(11).Caption = "Tel. Trabajo"
        fg.Cols.Item(12).Caption = "Asociado"
        fg.Cols.Item(13).Caption = "Dui"
        fg.Cols.Item(14).Caption = "C�d. Tipo de Cr�dito"
        fg.Cols.Item(15).Caption = "C�d. Profesi�n"
        fg.Cols.Item(16).Caption = "No. Solicitud"
        fg.Cols.Item(17).Caption = "Solic. Recibida"
        fg.Cols.Item(18).Caption = "C�d. Ejecutivo"
        fg.Cols.Item(1).Width = 50
        fg.Cols.Item(2).Width = 200
        fg.Cols.Item(3).Width = 150
        fg.Cols.Item(4).Width = 150
        fg.Cols.Item(5).Width = 150
        fg.Cols.Item(6).Width = 77
        fg.Cols.Item(7).Width = 300
        fg.Cols.Item(8).Width = 77
        fg.Cols.Item(9).Width = 100
        fg.Cols.Item(10).Width = 200
        fg.Cols.Item(11).Width = 77
        fg.Cols.Item(12).Width = 77
        fg.Cols.Item(13).Width = 77
        fg.Cols.Item(14).Width = 77
        fg.Cols.Item(15).Width = 77
        fg.Cols.Item(16).Width = 77
        fg.Cols.Item(17).Width = 77
        fg.Cols.Item(18).Width = 77
    End Sub

    Protected Function VALIDAR_ACCION(ByVal NUMSOLICITUD As Integer) As Boolean
        Dim BANDERA As Boolean
        Dim OCRED As New wrCredito.wsLibCred
        Dim DTS As New DataSet
        DTS = OCRED.CONSULTARANOTACIONPREVENTIVA(sUsuario, sPassword, sSucursal, NUMSOLICITUD, 0, 1)
        If DTS.Tables(0).Rows.Count > 0 Then
            BANDERA = True
        Else
            BANDERA = False
        End If
        Return BANDERA
    End Function
    Private Sub rbDui_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDui.CheckedChanged
        Me.txtDui.Focus()
    End Sub
    Private Sub txtDui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.Click
        Try
            Dim Valor As String
            Valor = IIf(txtDui.ValueIsDbNull, "", txtDui.Value)
            If Valor.Trim = "" Then
                Me.txtDui.SelectionStart = 0
                Me.txtDui.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub rbNoSolic_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoSolic.CheckedChanged
        Me.txtNoSolicitud.Focus()
    End Sub
    Private Sub rbNoSocio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoSocio.CheckedChanged
        Me.txtNoSocio.Focus()
    End Sub
    Private Sub rbCodPrestamo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCodPrestamo.CheckedChanged
        Me.txtCodPrestamo.Enabled = Me.rbCodPrestamo.Checked
        Me.txtCodPrestamo.Focus()
    End Sub

    Private Sub rbNombres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNombres.CheckedChanged
        If Me.rbNombres.Checked = True Then
            Me.cbNombres.Enabled = True
            Me.txtNombres.Enabled = True
        ElseIf Me.rbNombres.Checked = False Then
            Me.cbNombres.Enabled = False
            Me.txtNombres.Enabled = False
        End If
        Me.cbNombres.Focus()
    End Sub
    Private Sub txtNombres_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNombres.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub
    Private Sub txtCodPrestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPrestamo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub
    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub
    Private Sub txtNoSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSocio.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub
    Private Sub txtNoSolicitud_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSolicitud.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub
    Private Sub txtNoSolicitudAl_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSolicitudAl.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then MetroButton1_Click(sender, e)
    End Sub
    Private Sub frmMGarantias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        Dim ESTADO As String
        Dim NUMSOLICITUD As Integer
        If fg.Row > 0 Then
            NUMSOLICITUD = fg.Item(fg.Row, "NUMSOLICITUD")
            ESTADO = CREDITO.CONSULTAR_ESTADOPRESTAMO(sUsuario, sPassword, sSucursal, NUMSOLICITUD)
            Me.lblESTADO.Text = "Estado: " + ESTADO.Trim
            Me.lblESTADO.Visible = True
        End If
    End Sub

    Private Sub btnCertExt1_Click(sender As Object, e As EventArgs) Handles btnCertExt1.Click
        Try
            Dim frm As New frmMsCertificacionExtractada
            If fg.Row > 0 Then
                frm.NumSolicitud = fg.Item(fg.Row, "NumSolicitud")
                frm.ShowDialog()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            Dim TOTAL_CERTIFICACIONES As Integer
            Dim frmA As New frmMsGrAnotacionPreventiva
            Dim frmCE As New frmMsGrConsultarCertificaciones_Anotacion
            Dim NUMSOLICITUD As Integer
            If fg.Row > 0 Then
                TOTAL_CERTIFICACIONES = CREDITO.CONSULTAR_TOTAL_CERTIFICACIONESEXTRACTADAS(sUsuario, sPassword, sSucursal, fg.Item(fg.Row, "NumSolicitud"))
                If TOTAL_CERTIFICACIONES > 1 Then
                    frmCE.vNUMSOLICITUD = fg.Item(fg.Row, "NumSolicitud")
                    frmCE.ShowDialog()
                Else
                    Dim DTS As New DataSet
                    Dim VALIDAR As Boolean
                    Dim NOCOMPROBANTE As String
                    NUMSOLICITUD = fg.Item(fg.Row, "NumSolicitud")
                    DTS = CREDITO.CONSULTARDET_CERTIFICACIONEXTRACTADA(sUsuario, sPassword, sSucursal, NUMSOLICITUD, 0, " ")
                    NOCOMPROBANTE = DTS.Tables(0).Rows(0).Item("NOCOMPROBANTE")
                    frmA.NumSolicitud = NUMSOLICITUD
                    frmA.vNOCOMPROBANTE = NOCOMPROBANTE
                    VALIDAR = VALIDAR_ACCION(NUMSOLICITUD)
                    frmA.ORIGEN = 2
                    If VALIDAR = True Then
                        frmA.Accion = 3
                    ElseIf VALIDAR = False Then
                        frmA.Accion = 2
                    End If
                    frmA.ShowDialog()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Dim TOTAL_CERTIFICACIONES As Integer
        Dim FRMCG As New frmsGrConsultarAnotaciones_Garantias
        Dim frm As New frmMsGrInscripcionGarantia
        Dim NUMSOLICITUD As Integer
        Try
            If fg.Row > 0 Then
                NUMSOLICITUD = fg.Item(fg.Row, "NumSolicitud")
                TOTAL_CERTIFICACIONES = CREDITO.CONSULTAR_TOTAL_CERTIFICACIONESEXTRACTADAS(sUsuario, sPassword, sSucursal, NUMSOLICITUD)
                If TOTAL_CERTIFICACIONES > 1 Then
                    FRMCG.vNUMSOLICITUD = NUMSOLICITUD
                    FRMCG.ShowDialog()
                Else
                    'VALIDAMOS QUE NO EXISTA GARANTIA 
                    Dim GARANTIA As Integer
                    Dim DTS_GARANTIA As New DataSet
                    Dim DTS As New DataSet
                    Dim DTS_CERTIFICACION As DataSet
                    Dim IDANOTACION As Integer
                    Dim COMPROBANTE_CERTIFICACION As String
                    Dim OPERACION As Integer
                    Dim NOCOMPROBANTEGARANTIA As String = " "
                    DTS_GARANTIA = CREDITO.CONSULTARINSCRIPCIONGARANTIA(sUsuario, sPassword, sSucursal, NUMSOLICITUD, 1, " ", " ", " ")
                    GARANTIA = DTS_GARANTIA.Tables(0).Rows.Count
                    DTS = CREDITO.CONSULTARANOTACIONPREVENTIVA(sUsuario, sPassword, sSucursal, NUMSOLICITUD, 0, 1)
                    DTS_CERTIFICACION = CREDITO.CONSULTARDET_CERTIFICACIONEXTRACTADA(sUsuario, sPassword, sSucursal, NUMSOLICITUD, 0, " ")
                    IDANOTACION = IIf(DTS.Tables(0).Rows(0).Item("IDANOTACION") Is DBNull.Value, "", DTS.Tables(0).Rows(0).Item("IDANOTACION"))
                    COMPROBANTE_CERTIFICACION = IIf(DTS_CERTIFICACION.Tables(0).Rows(0).Item("NOCOMPROBANTE") Is DBNull.Value, "", DTS_CERTIFICACION.Tables(0).Rows(0).Item("NOCOMPROBANTE"))
                    If GARANTIA = 0 Then
                        OPERACION = 1
                    ElseIf GARANTIA = 1 Then
                        OPERACION = 2
                        Dim DTS_NG As New DataSet
                        DTS_NG = CREDITO.CONSULTARINSCRIPCIONGARANTIA(sUsuario, sPassword, sSucursal, NUMSOLICITUD, 1, " ", " ", " ")
                        NOCOMPROBANTEGARANTIA = IIf(DTS_NG.Tables(0).Rows(0).Item("NOCOMPROBANTE") Is DBNull.Value, "", DTS_NG.Tables(0).Rows(0).Item("NOCOMPROBANTE"))
                    End If
                    frm.vNOCOMPROBANTE = NOCOMPROBANTEGARANTIA
                    frm.NumSolicitud = NUMSOLICITUD
                    frm.vIDANOTACION = IDANOTACION
                    frm.vOPERACION = OPERACION
                    frm.vNOCOMPROBANTE_CERTIFICACION = COMPROBANTE_CERTIFICACION
                    frm.ShowDialog()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim DTS As New DataSet
        Dim OPCION As Integer
        Try
            If rbCodPrestamo.Checked = True Then
                OPCION = 5
                DTS = CREDITO.CONSULTARSOLICITUDESCREDITO(sUsuario, sPassword, sSucursal, OPCION, " ", 0, " ", 0, " ", Me.txtCodPrestamo.Text.Trim)
            ElseIf rbDui.Checked = True Then
                OPCION = 2
                DTS = CREDITO.CONSULTARSOLICITUDESCREDITO(sUsuario, sPassword, sSucursal, OPCION, txtDui.Text.Trim, 0, " ", 0, " ", " ")
            ElseIf rbNombres.Checked = True Then
                OPCION = 3
                If Me.cbNombres.SelectedIndex = 0 Then 'APELLIDO1
                    DTS = CREDITO.CONSULTARSOLICITUDESCREDITO(sUsuario, sPassword, sSucursal, OPCION, " ", 0, Me.txtNombres.Text.Trim, 2, " ", " ")
                ElseIf Me.cbNombres.SelectedIndex = 1 Then 'APELLIDO2
                    DTS = CREDITO.CONSULTARSOLICITUDESCREDITO(sUsuario, sPassword, sSucursal, OPCION, " ", 0, Me.txtNombres.Text.Trim, 3, " ", " ")
                ElseIf Me.cbNombres.SelectedIndex = 2 Then 'NOMBRES
                    DTS = CREDITO.CONSULTARSOLICITUDESCREDITO(sUsuario, sPassword, sSucursal, OPCION, " ", 0, Me.txtNombres.Text.Trim, 1, " ", " ")
                End If

            ElseIf rbNoSocio.Checked = True Then
                OPCION = 4
                DTS = CREDITO.CONSULTARSOLICITUDESCREDITO(sUsuario, sPassword, sSucursal, OPCION, " ", 0, " ", 0, txtNoSocio.Text.Trim, " ")
            ElseIf rbNoSolic.Checked = True Then
                OPCION = 1
                DTS = CREDITO.CONSULTARSOLICITUDESCREDITO(sUsuario, sPassword, sSucursal, OPCION, " ", CInt(Me.txtNoSolicitud.Text.Trim), " ", 0, " ", " ")
            End If
            If DTS.Tables(0).Rows.Count > 0 Then
                Me.fg.DataSource = DTS.Tables(0)
            End If


        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class