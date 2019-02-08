Public Class frmRepPRDetallePrestamo
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private pPrestamo As System.Data.DataSet, vNumSol As String, vNumReporte As String, vTitulo As String
    Friend WithEvents lblCARGO As System.Windows.Forms.Label
    Friend WithEvents cbCARGO As System.Windows.Forms.ComboBox
    Friend WithEvents btProcesar1 As MetroFramework.Controls.MetroButton
    Public seleccion As Integer
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDirigidoA As System.Windows.Forms.TextBox
    Friend WithEvents txtCopiaA As System.Windows.Forms.TextBox
    Friend WithEvents txtCargoCopiaA As System.Windows.Forms.TextBox
    Friend WithEvents chkCopia As System.Windows.Forms.CheckBox
    Friend WithEvents txtPagaduria As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPagaduria As System.Windows.Forms.TextBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents txtDescCargo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkFormato2 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblCARGO = New System.Windows.Forms.Label()
        Me.cbCARGO = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkFormato2 = New System.Windows.Forms.CheckBox()
        Me.txtDescCargo = New System.Windows.Forms.TextBox()
        Me.txtCodCargo = New System.Windows.Forms.TextBox()
        Me.txtPagaduria = New System.Windows.Forms.TextBox()
        Me.txtCodPagaduria = New System.Windows.Forms.TextBox()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.txtCargoCopiaA = New System.Windows.Forms.TextBox()
        Me.txtCopiaA = New System.Windows.Forms.TextBox()
        Me.chkCopia = New System.Windows.Forms.CheckBox()
        Me.txtDirigidoA = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCARGO
        '
        Me.lblCARGO.Location = New System.Drawing.Point(293, 108)
        Me.lblCARGO.Name = "lblCARGO"
        Me.lblCARGO.Size = New System.Drawing.Size(38, 18)
        Me.lblCARGO.TabIndex = 146
        Me.lblCARGO.Text = "Cargo:"
        '
        'cbCARGO
        '
        Me.cbCARGO.FormattingEnabled = True
        Me.cbCARGO.Items.AddRange(New Object() {"Jefe Operaciones C.F.", "Jefe Suc. Metrocentro", "Jefe Suc. Plaza Mundo", "Jefe Suc. Las Cascadas"})
        Me.cbCARGO.Location = New System.Drawing.Point(337, 108)
        Me.cbCARGO.Name = "cbCARGO"
        Me.cbCARGO.Size = New System.Drawing.Size(178, 21)
        Me.cbCARGO.TabIndex = 145
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(293, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 144
        Me.Label7.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(347, 56)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(168, 20)
        Me.dtpFecha.TabIndex = 143
        Me.dtpFecha.Value = New Date(2006, 12, 19, 16, 42, 14, 734)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkFormato2)
        Me.GroupBox2.Controls.Add(Me.txtDescCargo)
        Me.GroupBox2.Controls.Add(Me.txtCodCargo)
        Me.GroupBox2.Controls.Add(Me.txtPagaduria)
        Me.GroupBox2.Controls.Add(Me.txtCodPagaduria)
        Me.GroupBox2.Controls.Add(Me.Label77)
        Me.GroupBox2.Controls.Add(Me.txtCargoCopiaA)
        Me.GroupBox2.Controls.Add(Me.txtCopiaA)
        Me.GroupBox2.Controls.Add(Me.chkCopia)
        Me.GroupBox2.Controls.Add(Me.txtDirigidoA)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(501, 187)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la Orden de Descuento:"
        '
        'chkFormato2
        '
        Me.chkFormato2.Location = New System.Drawing.Point(97, 45)
        Me.chkFormato2.Name = "chkFormato2"
        Me.chkFormato2.Size = New System.Drawing.Size(200, 16)
        Me.chkFormato2.TabIndex = 180
        Me.chkFormato2.Text = "&Formato 2 Orden de descuento"
        '
        'txtDescCargo
        '
        Me.txtDescCargo.BackColor = System.Drawing.Color.White
        Me.txtDescCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescCargo.Location = New System.Drawing.Point(153, 152)
        Me.txtDescCargo.Name = "txtDescCargo"
        Me.txtDescCargo.ReadOnly = True
        Me.txtDescCargo.Size = New System.Drawing.Size(336, 20)
        Me.txtDescCargo.TabIndex = 179
        '
        'txtCodCargo
        '
        Me.txtCodCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCargo.Location = New System.Drawing.Point(83, 152)
        Me.txtCodCargo.MaxLength = 10
        Me.txtCodCargo.Name = "txtCodCargo"
        Me.txtCodCargo.Size = New System.Drawing.Size(64, 20)
        Me.txtCodCargo.TabIndex = 4
        '
        'txtPagaduria
        '
        Me.txtPagaduria.BackColor = System.Drawing.Color.White
        Me.txtPagaduria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPagaduria.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagaduria.Location = New System.Drawing.Point(169, 19)
        Me.txtPagaduria.MaxLength = 100
        Me.txtPagaduria.Name = "txtPagaduria"
        Me.txtPagaduria.ReadOnly = True
        Me.txtPagaduria.Size = New System.Drawing.Size(320, 20)
        Me.txtPagaduria.TabIndex = 175
        '
        'txtCodPagaduria
        '
        Me.txtCodPagaduria.BackColor = System.Drawing.Color.White
        Me.txtCodPagaduria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPagaduria.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPagaduria.Location = New System.Drawing.Point(83, 19)
        Me.txtCodPagaduria.MaxLength = 10
        Me.txtCodPagaduria.Name = "txtCodPagaduria"
        Me.txtCodPagaduria.ReadOnly = True
        Me.txtCodPagaduria.Size = New System.Drawing.Size(80, 20)
        Me.txtCodPagaduria.TabIndex = 174
        '
        'Label77
        '
        Me.Label77.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.Black
        Me.Label77.Location = New System.Drawing.Point(8, 16)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(64, 16)
        Me.Label77.TabIndex = 176
        Me.Label77.Text = "Pagaduría:"
        '
        'txtCargoCopiaA
        '
        Me.txtCargoCopiaA.Enabled = False
        Me.txtCargoCopiaA.Location = New System.Drawing.Point(83, 93)
        Me.txtCargoCopiaA.Name = "txtCargoCopiaA"
        Me.txtCargoCopiaA.Size = New System.Drawing.Size(406, 20)
        Me.txtCargoCopiaA.TabIndex = 2
        '
        'txtCopiaA
        '
        Me.txtCopiaA.Enabled = False
        Me.txtCopiaA.Location = New System.Drawing.Point(83, 67)
        Me.txtCopiaA.Name = "txtCopiaA"
        Me.txtCopiaA.Size = New System.Drawing.Size(406, 20)
        Me.txtCopiaA.TabIndex = 1
        '
        'chkCopia
        '
        Me.chkCopia.Location = New System.Drawing.Point(11, 45)
        Me.chkCopia.Name = "chkCopia"
        Me.chkCopia.Size = New System.Drawing.Size(80, 16)
        Me.chkCopia.TabIndex = 0
        Me.chkCopia.Text = "Con &Copia"
        '
        'txtDirigidoA
        '
        Me.txtDirigidoA.Location = New System.Drawing.Point(83, 120)
        Me.txtDirigidoA.Name = "txtDirigidoA"
        Me.txtDirigidoA.Size = New System.Drawing.Size(406, 20)
        Me.txtDirigidoA.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 28)
        Me.Label6.TabIndex = 146
        Me.Label6.Text = "Cargo Firma Autorizado:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 145
        Me.Label5.Text = "Dirigido A:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 144
        Me.Label2.Text = "Cargo:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 143
        Me.Label1.Text = "Copia a:"
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.Location = New System.Drawing.Point(109, 82)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(406, 20)
        Me.txtAsociado.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Asociado:"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(109, 56)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(178, 20)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPrestamo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodPrestamo.Location = New System.Drawing.Point(109, 108)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(178, 20)
        Me.txtCodPrestamo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 16)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "Préstamo:"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(23, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 16)
        Me.Label14.TabIndex = 137
        Me.Label14.Text = "DUI:"
        '
        'btProcesar1
        '
        Me.btProcesar1.Location = New System.Drawing.Point(452, 328)
        Me.btProcesar1.Name = "btProcesar1"
        Me.btProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btProcesar1.TabIndex = 172
        Me.btProcesar1.Text = "Procesar"
        Me.btProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btProcesar1.UseSelectable = True
        Me.btProcesar1.UseStyleColors = True
        '
        'frmRepPRDetallePrestamo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(546, 384)
        Me.Controls.Add(Me.btProcesar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbCARGO)
        Me.Controls.Add(Me.lblCARGO)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.txtCodPrestamo)
        Me.Controls.Add(Me.txtAsociado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(546, 384)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(546, 384)
        Me.Name = "frmRepPRDetallePrestamo"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Detalle de Préstamo"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Property Titulo() As String
        Get
            Return vTitulo
        End Get
        Set(ByVal Value As String)
            vTitulo = Value
        End Set
    End Property

    Public Property NumReporte() As String
        Get
            Return vNumReporte
        End Get
        Set(ByVal Value As String)
            vNumReporte = Value
        End Set
    End Property

    Public Property Prestamo() As System.Data.DataSet
        Get
            Return Me.pPrestamo
        End Get
        Set(ByVal Value As System.Data.DataSet)
            pPrestamo = Value
        End Set
    End Property

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Correlativo,NoSocio,Apellido1,Apellido2,Nombres", "", "Correlativo", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtDui.Value = Trim(dr("DUI"))
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Préstamo"
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow
        Try
            oPrest = New wrPrestamo.wsLibPrest
            ds = oPrest.CargarListaPrestamos(False, "", "", Me.txtDui.Value, Me.txtDui.Value, 0, 0, sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oPrest.CargaDatosPrestamo(sTexto, sUsuario, sPassword, sSucursal)
                Me.Prestamo = ds
                dr = ds.Tables("Prestamo").Rows(0)
                Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
                vNumSol = IIf(IsDBNull(dr("NumSolicitud")), 0, dr("NumSolicitud"))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodPrestamo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodPrestamo.Validating
        Dim sTexto As String
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow, dsTmp As New DataSet
        Dim oCred As New wrCredito.wsLibCred
        Try
            oPrest = New wrPrestamo.wsLibPrest
            sTexto = Me.txtCodPrestamo.Text
            If sTexto = "" Then

            ElseIf sTexto <> "" Then
                ds = oPrest.CargaDatosPrestamo(sTexto, sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
                vNumSol = IIf(IsDBNull(dr("NumSolicitud")), 0, dr("NumSolicitud"))
                dsTmp = oCred.ConsultarSolP2Credito("*", "NumSolicitud='" & vNumSol & "'", "NumSolicitud", sUsuario, sPassword, sSucursal)
                If dsTmp.Tables(0).Rows.Count > 0 Then
                    dr = dsTmp.Tables(0).Rows(0)
                    txtCodPagaduria.Text = IIf(IsDBNull(dr("CodPagaduria")), "", dr("CodPagaduria"))
                    dsTmp.Clear()
                    dsTmp = oCred.ConsultarPagaduria("*", "CodPagaduria='" & Trim(Me.txtCodPagaduria.Text) & "'", "", sUsuario, sPassword, sSucursal)
                    If dsTmp.Tables(0).Rows.Count > 0 Then
                        dr = dsTmp.Tables(0).Rows(0)
                        Me.txtPagaduria.Text = IIf(IsDBNull(dr("Nombre")), "", dr("Nombre"))
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text.Trim = "" Then Exit Sub
        Dim sTexto As String
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            sTexto = Me.txtDui.Text.Trim
            If sTexto = "" Then      'Filtrar Registros
            ElseIf sTexto <> "" Then
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub frmRepPRDetallePrestamo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = vTitulo
        Me.dtpFecha.Value = Now
        If Me.vNumReporte = "1" Then
            Me.Size = New Size(552, 176)
            'Me.GroupBox1.Size = New Size(560, 96)
            ' Me.btProcesar1.Location = New Point(304, 112)
            'Me.btnCerrar.Location = New Point(456, 112)
            Me.dtpFecha.Visible = False
            Me.Label7.Visible = False
        ElseIf Me.vNumReporte = "2" Then
            Me.Size = New Size(552, 368)
            'Me.GroupBox1.Size = New Size(528, 288)
            'Me.btProcesar.Location = New Point(304, 304)
            'Me.btnCerrar.Location = New Point(456, 304)
            Me.lblCARGO.Visible = False
            Me.cbCARGO.Visible = False
        End If
    End Sub

    Private Sub btProcesar1_Click(sender As Object, e As EventArgs) Handles btProcesar1.Click
        Try
            Select Case vNumReporte
                Case "1"
                    Me.Cursor = Cursors.WaitCursor
                    Dim ofrm As New frmVisorRep

                    'ofrm.ReportePrestamos = AlcalaLibs.Prestamos.clsPrestamos.ReportesPrestamos.DetallePrestamo
                    ofrm.ReportePrestamos = sifLib.Prestamos.clsPrestamos.ReportesPrestamos.DetallePrestamo
                    ofrm.NumSolicitud = vNumSol
                    ofrm.CodigoPrestamo = Me.txtCodPrestamo.Text
                    ofrm.DuiAsociado = Me.txtDui.Text
                    ofrm.MdiParent = ofrmMain
                    ofrm.x = Me.cbCARGO.SelectedIndex
                    ofrm.Show()
                    Me.Cursor = Cursors.Default
                ' Me.Dispose()
                Case "2"
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Orden_Descuento(Me.txtCodPrestamo.Text.Trim, Me.txtCopiaA.Text.Trim, Me.txtCargoCopiaA.Text.Trim, Me.txtDirigidoA.Text.Trim, Me.dtpFecha.Value, Me.txtCodCargo.Text.Trim, sUsuario, sPassword, sSucursal)
                    If Me.chkFormato2.Checked = True Then
                        Dim ofrm As New frmVisor(ds, 132, 0)
                        ofrm.ShowDialog()
                    Else
                        Dim ofrm As New frmVisor(ds, 8, 0)
                        ofrm.ShowDialog()
                    End If
            End Select

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtCodCargo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCargo.DoubleClick
        Dim ofrm As New frmAGenerico, oPlan As New wrPlanilla.wsLibPlanilla
        Dim ds As New Data.DataSet
        Dim sResultado1, sResultado2 As String
        Try
            ofrm.Text = "Buscar Cargos"
            ds = oPlan.ConsultarPLCargos("*", "", "CodCargo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then
                sResultado1 = ofrm.Resultado.Trim
                sResultado2 = ofrm.Resultado2.Trim
                Me.txtCodCargo.Text = sResultado1
                Me.txtDescCargo.Text = sResultado2
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos.", MsgBoxStyle.Critical, "Módulo General")
        End Try
    End Sub

    Private Sub chkCopia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCopia.CheckedChanged
        If Me.chkCopia.Checked = True Then
            Me.txtCopiaA.Enabled = True
            Me.txtCargoCopiaA.Enabled = True
        Else
            Me.txtCopiaA.Text = ""
            Me.txtCargoCopiaA.Text = ""
            Me.txtCopiaA.Enabled = False
            Me.txtCargoCopiaA.Enabled = False
        End If
    End Sub

    Private Sub cbCARGO_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCARGO.SelectedIndexChanged
        Me.seleccion = cbCARGO.SelectedIndex
    End Sub
End Class