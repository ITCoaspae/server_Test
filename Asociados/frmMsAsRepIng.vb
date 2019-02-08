Public Class frmMsAsRepIng
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    Private vTipo As String

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRevisa As System.Windows.Forms.TextBox
    Friend WithEvents txtRealiza As System.Windows.Forms.TextBox
    Friend WithEvents txtCargoRealiza As System.Windows.Forms.TextBox
    Friend WithEvents txtCargoRevisa As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtComite As System.Windows.Forms.TextBox
    Friend WithEvents chkAsociado As System.Windows.Forms.CheckBox
    Friend WithEvents txtNoActa As System.Windows.Forms.TextBox
    Friend WithEvents lblNoActa As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtEjecMercadeo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEjecMercadeo As System.Windows.Forms.TextBox
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.chkAsociado = New System.Windows.Forms.CheckBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txtEjecMercadeo = New System.Windows.Forms.TextBox()
        Me.txtNoActa = New System.Windows.Forms.TextBox()
        Me.txtCodEjecMercadeo = New System.Windows.Forms.TextBox()
        Me.lblNoActa = New System.Windows.Forms.Label()
        Me.txtComite = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCargoRevisa = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCargoRealiza = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRevisa = New System.Windows.Forms.TextBox()
        Me.txtRealiza = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.chkTodos)
        Me.GroupBox1.Controls.Add(Me.chkAsociado)
        Me.GroupBox1.Controls.Add(Me.Label46)
        Me.GroupBox1.Controls.Add(Me.txtEjecMercadeo)
        Me.GroupBox1.Controls.Add(Me.txtNoActa)
        Me.GroupBox1.Controls.Add(Me.txtCodEjecMercadeo)
        Me.GroupBox1.Controls.Add(Me.lblNoActa)
        Me.GroupBox1.Controls.Add(Me.txtComite)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCargoRevisa)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCargoRealiza)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtRevisa)
        Me.GroupBox1.Controls.Add(Me.txtRealiza)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFecha2)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 261)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione datos del Reporte"
        '
        'chkTodos
        '
        Me.chkTodos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkTodos.Location = New System.Drawing.Point(336, 56)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(136, 16)
        Me.chkTodos.TabIndex = 4
        Me.chkTodos.Text = "&Todos los Ejecutivos"
        Me.chkTodos.Visible = False
        '
        'chkAsociado
        '
        Me.chkAsociado.Location = New System.Drawing.Point(6, 101)
        Me.chkAsociado.Name = "chkAsociado"
        Me.chkAsociado.Size = New System.Drawing.Size(152, 24)
        Me.chkAsociado.TabIndex = 3
        Me.chkAsociado.Text = "&Mostrar Asociados"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(24, 56)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(152, 16)
        Me.Label46.TabIndex = 106
        Me.Label46.Text = "*Código Ejecutivo Gestión:"
        Me.Label46.Visible = False
        '
        'txtEjecMercadeo
        '
        Me.txtEjecMercadeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEjecMercadeo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecMercadeo.Location = New System.Drawing.Point(79, 75)
        Me.txtEjecMercadeo.MaxLength = 100
        Me.txtEjecMercadeo.Name = "txtEjecMercadeo"
        Me.txtEjecMercadeo.ReadOnly = True
        Me.txtEjecMercadeo.Size = New System.Drawing.Size(393, 20)
        Me.txtEjecMercadeo.TabIndex = 105
        Me.txtEjecMercadeo.Visible = False
        '
        'txtNoActa
        '
        Me.txtNoActa.Location = New System.Drawing.Point(384, 30)
        Me.txtNoActa.Name = "txtNoActa"
        Me.txtNoActa.Size = New System.Drawing.Size(64, 20)
        Me.txtNoActa.TabIndex = 2
        '
        'txtCodEjecMercadeo
        '
        Me.txtCodEjecMercadeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEjecMercadeo.Location = New System.Drawing.Point(9, 75)
        Me.txtCodEjecMercadeo.MaxLength = 10
        Me.txtCodEjecMercadeo.Name = "txtCodEjecMercadeo"
        Me.txtCodEjecMercadeo.Size = New System.Drawing.Size(64, 20)
        Me.txtCodEjecMercadeo.TabIndex = 3
        Me.txtCodEjecMercadeo.Visible = False
        '
        'lblNoActa
        '
        Me.lblNoActa.Location = New System.Drawing.Point(381, 13)
        Me.lblNoActa.Name = "lblNoActa"
        Me.lblNoActa.Size = New System.Drawing.Size(72, 16)
        Me.lblNoActa.TabIndex = 91
        Me.lblNoActa.Text = "No. de Acta:"
        '
        'txtComite
        '
        Me.txtComite.BackColor = System.Drawing.Color.White
        Me.txtComite.Location = New System.Drawing.Point(70, 224)
        Me.txtComite.MaxLength = 100
        Me.txtComite.Name = "txtComite"
        Me.txtComite.ReadOnly = True
        Me.txtComite.Size = New System.Drawing.Size(384, 20)
        Me.txtComite.TabIndex = 90
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(6, 224)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(56, 20)
        Me.txtCodigo.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 16)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Seleccione el Consejo o Comité:"
        '
        'txtCargoRevisa
        '
        Me.txtCargoRevisa.Location = New System.Drawing.Point(246, 184)
        Me.txtCargoRevisa.MaxLength = 100
        Me.txtCargoRevisa.Name = "txtCargoRevisa"
        Me.txtCargoRevisa.Size = New System.Drawing.Size(208, 20)
        Me.txtCargoRevisa.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(246, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Cargo de quien Revisa:"
        '
        'txtCargoRealiza
        '
        Me.txtCargoRealiza.Location = New System.Drawing.Point(246, 144)
        Me.txtCargoRealiza.MaxLength = 100
        Me.txtCargoRealiza.Name = "txtCargoRealiza"
        Me.txtCargoRealiza.Size = New System.Drawing.Size(208, 20)
        Me.txtCargoRealiza.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(246, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 16)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Cargo de quien Realiza:"
        '
        'txtRevisa
        '
        Me.txtRevisa.Location = New System.Drawing.Point(6, 184)
        Me.txtRevisa.MaxLength = 100
        Me.txtRevisa.Name = "txtRevisa"
        Me.txtRevisa.Size = New System.Drawing.Size(232, 20)
        Me.txtRevisa.TabIndex = 7
        '
        'txtRealiza
        '
        Me.txtRealiza.Location = New System.Drawing.Point(6, 144)
        Me.txtRealiza.MaxLength = 100
        Me.txtRealiza.Name = "txtRealiza"
        Me.txtRealiza.Size = New System.Drawing.Size(232, 20)
        Me.txtRealiza.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Nombre de quien Revisa:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Nombre de quien Realiza:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Desde Fecha:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(182, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Hasta la Fecha:"
        '
        'dtpFecha2
        '
        Me.dtpFecha2.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.CustomFormat = ""
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha2.Location = New System.Drawing.Point(276, 19)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha2.TabIndex = 1
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(88, 19)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnProcesar1.Location = New System.Drawing.Point(386, 331)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(125, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 126
        Me.btnProcesar1.Text = "&Procesar Reporte"
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmMsAsRepIng
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(534, 399)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAsRepIng"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Ingreso de Asociados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property Tipo() As String
        Get
            Return vTipo
        End Get
        Set(ByVal Value As String)
            vTipo = Value
        End Set
    End Property

    Private Sub frmMsAsRepIng_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Date.Now()
        dtpFecha2.Value = Date.Now()
        If Me.vTipo = "I" Then
            Me.Text = "Ingreso de Aspirantes"
            ' Me.Size = New Size(512, 280)

            '  Me.btnProcesar1.Location = New Point(256, 216)
            ' Me.GroupBox1.Size = New Size(488, 200)
            Me.chkAsociado.Visible = True
            Me.lblNoActa.Visible = False
            Me.txtNoActa.Visible = False
        ElseIf Me.vTipo = "R" Then
            Me.Text = "Retiro de Asociados"
            ' Me.Size = New Size(512, 280)

            'Me.btnProcesar1.Location = New Point(256, 216)
            ' Me.GroupBox1.Size = New Size(488, 200)
            Me.chkAsociado.Visible = False
            Me.lblNoActa.Visible = False
            Me.txtNoActa.Visible = False
        ElseIf Me.vTipo = "N" Or Me.vTipo = "A" Then
            Me.Text = "Ingreso de Asociados"
            ' Me.Size = New Size(512, 192)

            '  Me.btnProcesar1.Location = New Point(256, 128)
            'Me.GroupBox1.Size = New Size(488, 112)
            Me.chkAsociado.Visible = False
            Me.lblNoActa.Visible = True
            Me.txtNoActa.Visible = True
            Me.txtRealiza.Visible = False
            Me.txtCargoRealiza.Visible = False
            Me.Label5.Visible = False
            Me.Label3.Visible = False
            Me.txtCodEjecMercadeo.Visible = True
            Me.txtEjecMercadeo.Visible = True
            Me.Label46.Visible = True
            Me.chkTodos.Visible = True
        ElseIf Me.vTipo = "T" Then
            Me.Size = New Size(534, 193)

            'Me.btnProcesar1.Location = New Point(256, 72)
            Me.chkAsociado.Visible = False
            Me.lblNoActa.Visible = True
            Me.txtNoActa.Visible = True
            Me.txtRealiza.Visible = False
            Me.txtCargoRealiza.Visible = False
            Me.Label5.Visible = False
            Me.Label3.Visible = False
            Me.txtCodEjecMercadeo.Visible = False
            Me.txtEjecMercadeo.Visible = False
            Me.Label46.Visible = False
            Me.chkTodos.Visible = False
            'Me.GroupBox1.Size = New Size(488, 56)
        ElseIf Me.vTipo = "G" Then
            ' Me.Size = New Size(512, 136)

            ' Me.btnProcesar1.Location = New Point(256, 72)
            Me.chkAsociado.Visible = False
            Me.lblNoActa.Visible = False
            Me.txtNoActa.Visible = False
            Me.txtRealiza.Visible = False
            Me.txtCargoRealiza.Visible = False
            Me.Label5.Visible = False
            Me.Label3.Visible = False
            Me.txtCodEjecMercadeo.Visible = False
            Me.txtEjecMercadeo.Visible = False
            Me.Label46.Visible = False
            Me.chkTodos.Visible = False
            Me.GroupBox1.Size = New Size(488, 56)
        Else
            'Me.Size = New Size(512, 144)

            'Me.btnProcesar1.Location = New Point(256, 80)
            ' Me.GroupBox1.Size = New Size(488, 64)
            Me.chkAsociado.Visible = False
            Me.lblNoActa.Visible = False
            Me.txtNoActa.Visible = False
        End If
    End Sub

    Private Sub txtCodigo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Directivos - Comités"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarDirectivos("*", "", "Codigo", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodigo.Text = ofrm.Resultado.Trim
            Me.txtComite.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Directivos - Comités - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodEjecMercadeo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEjecMercadeo.DoubleClick
        Dim ofrm As New frmAGenerico
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet

        ofrm.Text = "Buscar Ejecutivos de Mercadeo"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Try
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarEjecutivosMercadeoxNombre("", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodEjecMercadeo.Text = ofrm.Resultado.Trim
            txtEjecMercadeo.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Ejecutivos Mercadeo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodEjecMercadeo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEjecMercadeo.KeyPress
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Dim oPl As New wrPlanilla.wsLibPlanilla
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                ds = oPerif.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(txtCodEjecMercadeo.Text) & "'", "CodEjecMercadeo", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                        txtCodEjecMercadeo.Text = CStr(Filas.Item(0)("CodEjecMercadeo"))
                        txtEjecMercadeo.Text = CStr(Filas.Item(0)("CodEmpleado"))
                        ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecMercadeo.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            txtEjecMercadeo.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                        End If
                    End If
                Else
                    txtCodEjecMercadeo_DoubleClick(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Ejecutivos Mercadeo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click

        Dim ofrm As frmVisor
        Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New System.Data.DataSet
        Try
            If Me.vTipo = "I" Then
                Me.Cursor = Cursors.WaitCursor
                ds = oAsoc.IngresoAsociado(Me.chkAsociado.Checked,
                                           Me.dtpFecha.Value,
                                           Me.dtpFecha2.Value,
                                           Me.txtCodigo.Text.Trim,
                                           Me.txtRealiza.Text.Trim,
                                           Me.txtRevisa.Text.Trim,
                                           Me.txtCargoRealiza.Text.Trim,
                                           Me.txtCargoRevisa.Text.Trim,
                                           sUsuario, sPassword, sSucursal)
                ofrm = New frmVisor(ds, 5, 0)
                ofrm.Text = "Reporte - Ingreso de Aspirantes"
                ofrm.MdiParent = ofrmMain
                ofrm.Show()
                Me.Cursor = Cursors.Default
                Me.Close()
            ElseIf Me.vTipo = "R" Then
                Me.Cursor = Cursors.WaitCursor
                ds = oAsoc.RetiroAsociado(Me.dtpFecha.Value, Me.dtpFecha2.Value, Me.txtCodigo.Text.Trim, Me.txtRealiza.Text.Trim, Me.txtRevisa.Text.Trim, Me.txtCargoRealiza.Text.Trim, Me.txtCargoRevisa.Text.Trim, sUsuario, sPassword, sSucursal)
                ofrm = New frmVisor(ds, 25, 0)
                ofrm.Text = "Detalle de Renuncias de Asociados"
                ofrm.MdiParent = ofrmMain
                ofrm.Show()
                Me.Cursor = Cursors.Default
                Me.Close()
            ElseIf Me.vTipo = "N" Then
                Me.Cursor = Cursors.WaitCursor
                ds = oAsoc.NuevosAsociados(Me.dtpFecha.Value, Me.dtpFecha2.Value, Me.txtNoActa.Text.Trim, Me.txtCodEjecMercadeo.Text.Trim, Me.chkTodos.Checked, sUsuario, sPassword, sSucursal)
                ofrm = New frmVisor(ds, 31, 0)
                ofrm.Text = "Reporte - Ingreso de Asociados"
                ofrm.MdiParent = ofrmMain
                ofrm.Show()
                Me.Cursor = Cursors.Default
                Me.Close()
            ElseIf Me.vTipo = "A" Then
                Me.Cursor = Cursors.WaitCursor
                ds = oAsoc.NuevosAsociados(Me.dtpFecha.Value, Me.dtpFecha2.Value, Me.txtNoActa.Text.Trim, "", True, sUsuario, sPassword, sSucursal)
                ofrm = New frmVisor(ds, 126, 0)
                ofrm.Text = "Reporte - Ingreso de Asociados"
                ofrm.MdiParent = ofrmMain
                ofrm.Show()
                Me.Cursor = Cursors.Default
                Me.Close()
            ElseIf Me.vTipo = "T" Then 'RETIRO DE ASOCIADOS
                ds = oAsoc.Reporte_RetiroAsociados("Retiro", Me.txtNoActa.Text.Trim, Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                ofrm = New frmVisor(ds, 75, 0)
                ofrm.ShowDialog()
            ElseIf Me.vTipo = "G" Then 'Renuncia de Asociados
                ds = oAsoc.Reporte_RetiroAsociadosGr("Renuncia", "", Me.dtpFecha.Value, Me.dtpFecha2.Value, sUsuario, sPassword, sSucursal)
                ofrm = New frmVisor(ds, 176, 0)
                ofrm.ShowDialog()
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class