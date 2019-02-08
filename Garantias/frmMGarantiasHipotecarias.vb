Public Class frmMGarantiasHipotecarias
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
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
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMGarantiasHipotecarias))
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
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
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
        Me.GroupBox2.Size = New System.Drawing.Size(657, 108)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Filtrar registros por:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(571, 70)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 219
        Me.MetroButton1.Text = "&Buscar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Enabled = False
        Me.txtNombres.Location = New System.Drawing.Point(232, 78)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(211, 20)
        Me.txtNombres.TabIndex = 11
        '
        'rbNombres
        '
        Me.rbNombres.BackColor = System.Drawing.Color.White
        Me.rbNombres.ForeColor = System.Drawing.Color.Black
        Me.rbNombres.Location = New System.Drawing.Point(19, 77)
        Me.rbNombres.Name = "rbNombres"
        Me.rbNombres.Size = New System.Drawing.Size(89, 24)
        Me.rbNombres.TabIndex = 9
        Me.rbNombres.Text = "N&ombres"
        Me.rbNombres.UseVisualStyleBackColor = False
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Enabled = False
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(114, 77)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(112, 21)
        Me.cbNombres.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(328, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Al"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(111, 51)
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
        Me.txtNoSolicitudAl.Location = New System.Drawing.Point(358, 51)
        Me.txtNoSolicitudAl.Name = "txtNoSolicitudAl"
        Me.txtNoSolicitudAl.ShowDropDownButton = False
        Me.txtNoSolicitudAl.ShowUpDownButtons = False
        Me.txtNoSolicitudAl.Size = New System.Drawing.Size(85, 21)
        Me.txtNoSolicitudAl.TabIndex = 8
        Me.txtNoSolicitudAl.Tag = Nothing
        Me.txtNoSolicitudAl.Value = 0
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(114, 24)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(112, 20)
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
        Me.txtNoSocio.Location = New System.Drawing.Point(331, 24)
        Me.txtNoSocio.MaxLength = 10
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ShowDropDownButton = False
        Me.txtNoSocio.ShowUpDownButtons = False
        Me.txtNoSocio.Size = New System.Drawing.Size(112, 21)
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
        Me.txtNoSolicitud.Location = New System.Drawing.Point(141, 50)
        Me.txtNoSolicitud.Name = "txtNoSolicitud"
        Me.txtNoSolicitud.ShowDropDownButton = False
        Me.txtNoSolicitud.ShowUpDownButtons = False
        Me.txtNoSolicitud.Size = New System.Drawing.Size(85, 21)
        Me.txtNoSolicitud.TabIndex = 7
        Me.txtNoSolicitud.Tag = Nothing
        Me.txtNoSolicitud.Value = 0
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Enabled = False
        Me.txtCodPrestamo.Location = New System.Drawing.Point(534, 24)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(112, 20)
        Me.txtCodPrestamo.TabIndex = 5
        '
        'rbCodPrestamo
        '
        Me.rbCodPrestamo.BackColor = System.Drawing.Color.White
        Me.rbCodPrestamo.ForeColor = System.Drawing.Color.Black
        Me.rbCodPrestamo.Location = New System.Drawing.Point(449, 23)
        Me.rbCodPrestamo.Name = "rbCodPrestamo"
        Me.rbCodPrestamo.Size = New System.Drawing.Size(79, 24)
        Me.rbCodPrestamo.TabIndex = 4
        Me.rbCodPrestamo.Text = "&Préstamo:"
        Me.rbCodPrestamo.UseVisualStyleBackColor = False
        '
        'rbNoSocio
        '
        Me.rbNoSocio.BackColor = System.Drawing.Color.White
        Me.rbNoSocio.ForeColor = System.Drawing.Color.Black
        Me.rbNoSocio.Location = New System.Drawing.Point(232, 23)
        Me.rbNoSocio.Name = "rbNoSocio"
        Me.rbNoSocio.Size = New System.Drawing.Size(93, 24)
        Me.rbNoSocio.TabIndex = 2
        Me.rbNoSocio.Text = "No. Asociado:"
        Me.rbNoSocio.UseVisualStyleBackColor = False
        '
        'rbDui
        '
        Me.rbDui.BackColor = System.Drawing.Color.White
        Me.rbDui.Checked = True
        Me.rbDui.ForeColor = System.Drawing.Color.Black
        Me.rbDui.Location = New System.Drawing.Point(16, 24)
        Me.rbDui.Name = "rbDui"
        Me.rbDui.Size = New System.Drawing.Size(79, 24)
        Me.rbDui.TabIndex = 0
        Me.rbDui.TabStop = True
        Me.rbDui.Text = "&DUI:"
        Me.rbDui.UseVisualStyleBackColor = False
        '
        'rbNoSolic
        '
        Me.rbNoSolic.BackColor = System.Drawing.Color.White
        Me.rbNoSolic.ForeColor = System.Drawing.Color.Black
        Me.rbNoSolic.Location = New System.Drawing.Point(16, 48)
        Me.rbNoSolic.Name = "rbNoSolic"
        Me.rbNoSolic.Size = New System.Drawing.Size(89, 24)
        Me.rbNoSolic.TabIndex = 6
        Me.rbNoSolic.Text = "&No. Solicitud"
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
        Me.fg.Location = New System.Drawing.Point(23, 211)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Size = New System.Drawing.Size(658, 225)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 18
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.BackColor = System.Drawing.Color.White
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Teal
        Me.lblEstado.Location = New System.Drawing.Point(124, 177)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(304, 21)
        Me.lblEstado.TabIndex = 20
        Me.lblEstado.Text = "N/A"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(23, 177)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(135, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 220
        Me.MetroButton2.Text = "&Inscripción de Garantías"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'frmMGarantiasHipotecarias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(704, 477)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fg)
        Me.Name = "frmMGarantiasHipotecarias"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Garantías Hipotecarias"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtNoSolicitudAl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoSocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Encabezado()

        fg.Cols.Item(1).Caption = "No."
        fg.Cols.Item(2).Caption = "Nombres"
        fg.Cols.Item(3).Caption = "Primer Apellido"
        fg.Cols.Item(4).Caption = "Segundo Apellido"
        fg.Cols.Item(5).Caption = "Apellido de Casada"
        fg.Cols.Item(6).Caption = "Teléfonos"
        fg.Cols.Item(7).Caption = "Dirección"
        fg.Cols.Item(8).Caption = "Fecha de Entrega"
        fg.Cols.Item(9).Caption = "Lugar de Trabajo"
        fg.Cols.Item(10).Caption = "Dirección de Trabajo"
        fg.Cols.Item(11).Caption = "Tel. Trabajo"
        fg.Cols.Item(12).Caption = "Asociado"
        fg.Cols.Item(13).Caption = "Dui"
        fg.Cols.Item(14).Caption = "Cód. Tipo de Crédito"
        fg.Cols.Item(15).Caption = "Cód. Profesión"
        fg.Cols.Item(16).Caption = "No. Solicitud"
        fg.Cols.Item(17).Caption = "Solic. Recibida"
        fg.Cols.Item(18).Caption = "Cód. Ejecutivo"

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

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

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

    Private Sub btInscripcion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

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

    Private Sub fg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.Click
        Select Case CStr(fg.Item(fg.Row, "Estado")).Trim
            Case "D" 'Digitado (sin tabla de amortización)
                Me.lblEstado.Text = "DIGITADO"
            Case "A" 'A: Activo (ya se ha generado tabla de amortización)
                Me.lblEstado.Text = "ACTIVO"
            Case "C" 'C: Cancelado
                Me.lblEstado.Text = "CANCELADO"
            Case Else
                Me.lblEstado.Text = ""
        End Select
    End Sub

    Private Sub fg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles fg.KeyPress
        Select Case CStr(fg.Item(fg.Row, "Estado")).Trim
            Case "D" 'Digitado (sin tabla de amortización)
                Me.lblEstado.Text = "DIGITADO"
            Case "A" 'A: Activo (ya se ha generado tabla de amortización)
                Me.lblEstado.Text = "ACTIVO"
            Case "C" 'C: Cancelado
                Me.lblEstado.Text = "CANCELADO"
            Case Else
                Me.lblEstado.Text = ""
        End Select
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim oCred As wrCredito.wsLibCred, ds As New Data.DataSet, pDui As String, Filas As Data.DataRowCollection
        Dim oAsoc As New wrAsociados.wsLibAsoc, pNumSol As String, dr As DataRow
        Try
            oCred = New wrCredito.wsLibCred
            If rbNoSolic.Checked = True Then
                If Me.txtNoSolicitudAl.Text.Trim = "" Then
                    ds = oCred.ConsultarSolicitudCredito("a.*", "a.NumSolicitud='" & Val(Me.txtNoSolicitud.Value) & "' and b.Tipo='H'", "a.Correlativo", sUsuario, sPassword, sSucursal)
                Else
                    ds = oCred.ConsultarSolicitudCredito("a.*", "a.NumSolicitud>='" & Val(Me.txtNoSolicitud.Value) & "' and a.NumSolicitud<='" & Val(Me.txtNoSolicitudAl.Value) & "' and b.Tipo='H'", "a.Correlativo", sUsuario, sPassword, sSucursal)
                End If
            ElseIf rbDui.Checked = True Then
                ds = oCred.ConsultarSolicitudCredito("a.*", "a.Dui='" & Trim(txtDui.Value) & "' and b.Tipo='H'", "a.Apellido1", sUsuario, sPassword, sSucursal)
            ElseIf rbNoSocio.Checked = True Then
                ds = oCred.ConsultarDatGral("Dui", "NoSocio='" & Val(txtNoSocio.Value) & "'", "Dui", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)(0) Is DBNull.Value) Then
                        pDui = CStr(Filas.Item(0)("Dui"))
                    End If
                    ds = oCred.ConsultarSolicitudCredito("a.*", "a.Dui='" & Trim(pDui) & "' and b.Tipo='H'", "a.Apellido1", sUsuario, sPassword, sSucursal)
                End If
            ElseIf Me.rbCodPrestamo.Checked = True Then
                ds = oCred.ConsultarPrestamos("NumSolicitud", "CodPrestamo='" & Me.txtCodPrestamo.Text.Trim & "'", "NumSolicitud", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    pNumSol = dr("NumSolicitud")
                    ds = oCred.ConsultarSolicitudCredito("a.*", "a.NumSolicitud='" & pNumSol & "' and b.Tipo='H'", "a.Correlativo", sUsuario, sPassword, sSucursal)
                Else
                    Exit Sub
                End If
            ElseIf Me.rbNombres.Checked = True Then
                If cbNombres.SelectedIndex = 0 Then
                    ds = oCred.ConsultarSolicitudCredito("a.*", "Apellido1 like '" & Trim(txtNombres.Text) & "%' and b.Tipo='H'", "Apellido1,Apellido2", sUsuario, sPassword, sSucursal)
                ElseIf cbNombres.SelectedIndex = 1 Then
                    ds = oCred.ConsultarSolicitudCredito("a.*", "Apellido2 like '" & Trim(txtNombres.Text) & "%' and b.Tipo='H'", "Apellido1", sUsuario, sPassword, sSucursal)
                ElseIf cbNombres.SelectedIndex = 2 Then
                    ds = oCred.ConsultarSolicitudCredito("a.*", "Nombres like '" & Trim(txtNombres.Text) & "%' and b.Tipo='H'", "Apellido1", sUsuario, sPassword, sSucursal)
                End If
            End If
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                fg.DataSource = ds.Tables(0)
                Encabezado()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim frm As New frmMsGrInscripcionGarantia
            If fg.Row > 0 Then
                frm.Accion = "Guardar"
                frm.NumSolicitud = fg.Item(fg.Row, "NumSolicitud")
                frm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub


End Class