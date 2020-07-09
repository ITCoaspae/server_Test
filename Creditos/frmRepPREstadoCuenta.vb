Public Class frmRepPREstadoCuenta
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Private pPrestamo As System.Data.DataSet, pTipo As String, vFiltro As String

    Dim prestamos As New wrPrestamo.wsLibPrest
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbPrestamo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents LblFechaHist As MetroFramework.Controls.MetroLabel
    Friend WithEvents DTFecHist As DateTimePicker
    Friend WithEvents btProcesar1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.cbPrestamo = New MetroFramework.Controls.MetroComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.LblFechaHist = New MetroFramework.Controls.MetroLabel()
        Me.DTFecHist = New System.Windows.Forms.DateTimePicker()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Enabled = False
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAsociado.Location = New System.Drawing.Point(87, 84)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.Size = New System.Drawing.Size(291, 21)
        Me.txtAsociado.TabIndex = 141
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(82, 59)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(120, 18)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'dtpFecha2
        '
        Me.dtpFecha2.CustomFormat = ""
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha2.Location = New System.Drawing.Point(257, 142)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(120, 20)
        Me.dtpFecha2.TabIndex = 3
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(82, 142)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(120, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'btProcesar1
        '
        Me.btProcesar1.Location = New System.Drawing.Point(302, 197)
        Me.btProcesar1.Name = "btProcesar1"
        Me.btProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btProcesar1.TabIndex = 173
        Me.btProcesar1.Text = "Procesar"
        Me.btProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btProcesar1.UseSelectable = True
        Me.btProcesar1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(19, 59)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel1.TabIndex = 175
        Me.MetroLabel1.Text = "DUI:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(19, 84)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel2.TabIndex = 176
        Me.MetroLabel2.Text = "Asociado:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(19, 111)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(68, 19)
        Me.MetroLabel3.TabIndex = 177
        Me.MetroLabel3.Text = "Préstamo:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(19, 142)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel4.TabIndex = 178
        Me.MetroLabel4.Text = "Desde:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(210, 142)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(44, 19)
        Me.MetroLabel5.TabIndex = 179
        Me.MetroLabel5.Text = "Hasta:"
        '
        'cbPrestamo
        '
        Me.cbPrestamo.FormattingEnabled = True
        Me.cbPrestamo.ItemHeight = 23
        Me.cbPrestamo.Location = New System.Drawing.Point(82, 111)
        Me.cbPrestamo.Name = "cbPrestamo"
        Me.cbPrestamo.Size = New System.Drawing.Size(295, 29)
        Me.cbPrestamo.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbPrestamo.TabIndex = 180
        Me.cbPrestamo.UseCustomBackColor = True
        Me.cbPrestamo.UseCustomForeColor = True
        Me.cbPrestamo.UseSelectable = True
        Me.cbPrestamo.UseStyleColors = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(246, 59)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(75, 19)
        Me.CheckBox1.TabIndex = 182
        Me.CheckBox1.Text = "Historico"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'LblFechaHist
        '
        Me.LblFechaHist.AutoSize = True
        Me.LblFechaHist.Location = New System.Drawing.Point(151, 171)
        Me.LblFechaHist.Name = "LblFechaHist"
        Me.LblFechaHist.Size = New System.Drawing.Size(100, 19)
        Me.LblFechaHist.TabIndex = 184
        Me.LblFechaHist.Text = "Fecha Historica:"
        Me.LblFechaHist.Visible = False
        '
        'DTFecHist
        '
        Me.DTFecHist.CustomFormat = ""
        Me.DTFecHist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFecHist.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTFecHist.Location = New System.Drawing.Point(257, 171)
        Me.DTFecHist.Name = "DTFecHist"
        Me.DTFecHist.Size = New System.Drawing.Size(120, 20)
        Me.DTFecHist.TabIndex = 183
        Me.DTFecHist.Visible = False
        '
        'frmRepPREstadoCuenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(418, 264)
        Me.Controls.Add(Me.LblFechaHist)
        Me.Controls.Add(Me.DTFecHist)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.cbPrestamo)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtAsociado)
        Me.Controls.Add(Me.dtpFecha2)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.btProcesar1)
        Me.Controls.Add(Me.txtDui)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRepPREstadoCuenta"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Estado de Cuenta del Préstamo"
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Property Tipo() As String
        Get
            Return pTipo
        End Get
        Set(ByVal Value As String)
            pTipo = Value
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
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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
        'Dim sTexto As String
        'Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        'Try
        '    oAsoc = New wrAsociados.wsLibAsoc
        '    sTexto = Me.txtDui.Text.Trim
        '    If sTexto = "" Then      'Filtrar Registros

        '    ElseIf sTexto <> "" Then

        '        ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
        '        If ds.Tables(0).Rows.Count > 0 Then
        '            dr = ds.Tables(0).Rows(0)
        '            Me.txtDui.Value = Trim(dr("DUI"))
        '            Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
        '            llenarPrestamos()
        '        End If
        '    End If
        'Catch ex As Exception
        '    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        'End Try
        Dim sTexto As String
        '--------------------CAMBIO APLICADO 31/08/2019  PROG01 ----------------------------
        '--------------------SOLICITADO POR GERENCIA PARA CLASIFICAR CLIENTES VIP-----------
        Try
            sTexto = Me.txtDui.Value
            If sTexto = "" Then      'Filtrar Registros
            ElseIf sTexto <> "" Then

                Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
                ds = oAsoc.ConsultarAsociadoVIP("DUI,Nombre", "DUI='" & sTexto & "'", "DUI,Nombre", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Dim ofrmAut As New frmMsAutorizacion
                    ofrmAut.TipoPermiso = "P"
                    ofrmAut.NumPrograma = "VIP001"
                    ofrmAut.ShowDialog()
                    If ofrmAut.Autoriza = True Then
                        '=========================================================================================
                        Dim oAsoc1 As New wrAsociados.wsLibAsoc, ds1 As New Data.DataSet, dr1 As DataRow
                        ds1 = oAsoc1.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                        If ds1.Tables(0).Rows.Count > 0 Then
                            dr1 = ds1.Tables(0).Rows(0)
                            Me.txtDui.Value = Trim(dr("DUI"))
                            Me.txtAsociado.Text = Trim(dr1("Nombres")) & ", " & dr1("Apellido1") & " " & dr1("Apellido2") & " " & dr1("ApellidoCas")
                            llenarPrestamos()
                        End If
                    Else
                        MetroFramework.MetroMessageBox.Show(Me, "Seleccionar Usuario que autoriza la consulta del Cliente VIP.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    End If
                Else
                    Dim oAsoc2 As New wrAsociados.wsLibAsoc, ds2 As New Data.DataSet, dr2 As DataRow
                    ds2 = oAsoc2.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    If ds2.Tables(0).Rows.Count > 0 Then
                        dr2 = ds2.Tables(0).Rows(0)
                        Me.txtDui.Value = Trim(dr2("DUI"))
                        Me.txtAsociado.Text = Trim(dr2("Nombres")) & ", " & dr2("Apellido1") & " " & dr2("Apellido2") & " " & dr2("ApellidoCas")
                        llenarPrestamos()
                    End If
                End If

            End If
            '-------------- FIN DEL CAMBIO DE CLIENTE VIP
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub btProcesar1_Click(sender As Object, e As EventArgs) Handles btProcesar1.Click
        Try
            Dim ofrm As New frmVisorRS

            OpcionRS = 90 'Estado Cuenta de Prestamo

            ofrm.codPrstamo = cbPrestamo.SelectedValue
            ofrm.dui = txtDui.Value.ToString
            ofrm.fechaIni = Format(dtpFecha.Value, "Short date")
            ofrm.fechaFin = Format(dtpFecha2.Value, "Short date")
            ofrm.Opcion = Me.CheckBox1.Checked
            ofrm.fecha = Format(dtpFecha2.Value, "Short date") 'Me.DTFecHist.Value.ToShortDateString
            ofrm.Show()

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs)
        Try
            Dim ofrmAut As New frmMsAutorizacion
            ofrmAut.TipoPermiso = "P"
            ofrmAut.NumPrograma = "PRB004"
            ofrmAut.ShowDialog()
            If ofrmAut.Autoriza = True Then
                vFiltro = ""
                ofrmAut.Autoriza = False
                ofrmAut.Dispose()
            Else
                ofrmAut.Dispose()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmRepPREstadoCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.LblFechaHist.Visible = False
            Me.DTFecHist.Visible = False
        Else
            Me.LblFechaHist.Visible = False
            Me.DTFecHist.Visible = False
        End If
    End Sub

    Private Sub btActivaProtesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Public Sub llenarPrestamos()
        Try
            Dim dts As New DataSet
            dts = prestamos.ConsultarPRPrestamosTipoCredito("a.codPrestamo", " a.DUI = '" & txtDui.Value & "' and a.estado <> 'D' ", "a.CODPRESTAMO", sUsuario, sPassword, sSucursal)
            cbPrestamo.DataSource = dts.Tables(0)
            cbPrestamo.DisplayMember = "codprestamo"
            cbPrestamo.ValueMember = "codprestamo"
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class