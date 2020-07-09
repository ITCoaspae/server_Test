Public Class frmMsSolicitudRetiro
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim ahorro As New wrAhorro.wsLibAhorro
    Dim prestamos As New wrPrestamo.wsLibPrest
    Dim creditos As New wrCredito.wsLibCred
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cbTipoRetiro As ComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Dim asociado As New wrAsociados.wsLibAsoc

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
    Friend WithEvents txtMotivos As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSolRetiro As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents chkBloquear As System.Windows.Forms.CheckBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkBloquear = New System.Windows.Forms.CheckBox()
        Me.txtNoSolRetiro = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtMotivos = New System.Windows.Forms.TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.cbTipoRetiro = New System.Windows.Forms.ComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkBloquear
        '
        Me.chkBloquear.ForeColor = System.Drawing.Color.Black
        Me.chkBloquear.Location = New System.Drawing.Point(439, 171)
        Me.chkBloquear.Name = "chkBloquear"
        Me.chkBloquear.Size = New System.Drawing.Size(128, 24)
        Me.chkBloquear.TabIndex = 10
        Me.chkBloquear.Text = "&Bloquear Cuentas"
        '
        'txtNoSolRetiro
        '
        Me.txtNoSolRetiro.BackColor = System.Drawing.Color.White
        Me.txtNoSolRetiro.Enabled = False
        Me.txtNoSolRetiro.Location = New System.Drawing.Point(112, 146)
        Me.txtNoSolRetiro.MaxLength = 50
        Me.txtNoSolRetiro.Name = "txtNoSolRetiro"
        Me.txtNoSolRetiro.ReadOnly = True
        Me.txtNoSolRetiro.Size = New System.Drawing.Size(180, 20)
        Me.txtNoSolRetiro.TabIndex = 7
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Location = New System.Drawing.Point(345, 146)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(222, 20)
        Me.dtpFecha.TabIndex = 9
        Me.dtpFecha.Value = New Date(2020, 5, 14, 0, 0, 0, 0)
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.White
        Me.txtObservaciones.Location = New System.Drawing.Point(19, 325)
        Me.txtObservaciones.MaxLength = 100
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(546, 79)
        Me.txtObservaciones.TabIndex = 14
        '
        'txtMotivos
        '
        Me.txtMotivos.BackColor = System.Drawing.Color.White
        Me.txtMotivos.Location = New System.Drawing.Point(19, 224)
        Me.txtMotivos.MaxLength = 255
        Me.txtMotivos.Multiline = True
        Me.txtMotivos.Name = "txtMotivos"
        Me.txtMotivos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivos.Size = New System.Drawing.Size(546, 78)
        Me.txtMotivos.TabIndex = 12
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(112, 75)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(455, 15)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.Enabled = False
        Me.txtNoSocio.Location = New System.Drawing.Point(112, 97)
        Me.txtNoSocio.MaxLength = 8
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(456, 20)
        Me.txtNoSocio.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Location = New System.Drawing.Point(112, 121)
        Me.txtNombre.MaxLength = 150
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(455, 20)
        Me.txtNombre.TabIndex = 5
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(490, 409)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 29)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 15
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(19, 170)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(96, 19)
        Me.MetroLabel1.TabIndex = 16
        Me.MetroLabel1.Text = "Tipo de Retiro:"
        '
        'cbTipoRetiro
        '
        Me.cbTipoRetiro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoRetiro.FormattingEnabled = True
        Me.cbTipoRetiro.Location = New System.Drawing.Point(120, 171)
        Me.cbTipoRetiro.Name = "cbTipoRetiro"
        Me.cbTipoRetiro.Size = New System.Drawing.Size(299, 21)
        Me.cbTipoRetiro.TabIndex = 17
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(296, 146)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel2.TabIndex = 18
        Me.MetroLabel2.Text = "Fecha:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(19, 146)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel3.TabIndex = 19
        Me.MetroLabel3.Text = "No. Solicitud:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(19, 121)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel4.TabIndex = 20
        Me.MetroLabel4.Text = "Asociado:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(19, 99)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(91, 19)
        Me.MetroLabel5.TabIndex = 21
        Me.MetroLabel5.Text = "No. Asociado:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(19, 75)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel6.TabIndex = 22
        Me.MetroLabel6.Text = "DUI:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(19, 204)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(92, 19)
        Me.MetroLabel7.TabIndex = 23
        Me.MetroLabel7.Text = "Motivo Retiro:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(19, 305)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel8.TabIndex = 24
        Me.MetroLabel8.Text = "Observaciones:"
        '
        'frmMsSolicitudRetiro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(592, 454)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.cbTipoRetiro)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.chkBloquear)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtMotivos)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtNoSolRetiro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsSolicitudRetiro"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Solicitud de Retiro"
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Métodos"

    Private Sub LoadForm()

        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try

            llenarTipoRetiro()

            If Me.btnGuardar1.Text = "&Modificar" Then
                cbTipoRetiro.Enabled = False
                dtpFecha.Enabled = False
                txtNoSocio.Enabled = False
                txtDui.Enabled = False
                txtNombre.Enabled = False

                Dim Filas As Data.DataRowCollection

                ds = oAsoc.ConsultarSolicitudRetiro("A", "NoSolicitudRetiro='" & Trim(txtNoSolRetiro.Text) & "'", "NoSolicitudRetiro", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtMotivos.Text = CStr(Filas.Item(0)("Motivos"))
                    txtObservaciones.Text = CStr(Filas.Item(0)("Observaciones"))
                    dtpFecha.Value = Filas.Item(0)("fechaSolicitud")
                    If Filas.Item(0)("idTipoRetiro") Is DBNull.Value = False Then
                        cbTipoRetiro.SelectedValue = Filas.Item(0)("idTipoRetiro")
                    End If


                    Me.chkBloquear.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("CuentaBloqueada")), "0", Filas.Item(0)("CuentaBloqueada")) = "1", True, False)
                End If
                ds = oAsoc.ConsultarAsociado("NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre", "Dui='" & Trim(txtDui.Text) & "'", "Dui", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNoSocio.Text = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))
                    txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                    txtDui.Enabled = False
                    txtNoSocio.Enabled = False
                    txtNombre.Enabled = False
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Error en la carga de datos Módulo Asociados." & vbCrLf & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Guardar()

        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String, pBloqueada As String
        Try
            Dim frm As New frmVisorRS
            OpcionRS = 228
            pBloqueada = IIf(Me.chkBloquear.Checked = True, "1", "0")
            If Me.btnGuardar1.Text = "&Guardar" Then

                Select Case oAsoc.AutorizaDatos(Trim(txtDui.Text), "x", "x", "x", "x")
                    Case 1
                        MsgBox("El campo Dui del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                        Exit Sub
                End Select

                Dim dts As New DataSet
                dts = asociado.ConsultarSolicitudRetiro("A", "a.Dui = '" & txtDui.Text.Trim & "' and Anulado = '0' ", "NoSolicitudRetiro", sUsuario, sPassword, sSucursal)
                If dts.Tables.Count > 0 Then
                    If dts.Tables(0).Rows.Count > 0 Then
                        MsgBox("El asociado ya cuenta con una solicitud de retiro.", MsgBoxStyle.Information, "Módulo - Asociados")
                        Exit Sub
                    End If
                End If

                pCampos = "NoSolicitudRetiro,FechaSolicitud, " &
                "Motivos,Dui, " &
                "Observaciones,CuentaBloqueada,Anulado, " &
                "usuarioIngresa,FechaIngreso"
                pValores = "'" & Trim(txtNoSolRetiro.Text) &
                "','" & Format(dtpFecha.Value, "dd/MM/yyyy") &
                "','" & Trim(txtMotivos.Text) &
                "','" & Trim(txtDui.Text) &
                "','" & Trim(txtObservaciones.Text) &
                "','" & pBloqueada &
                "','" & False &
                "','" & sUsuario &
                "', getdate()"


                If oAsoc.InsertarSolicitudRetiro(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    ' Validamos que existan prestamos activos
                    Dim dtsPrestamos As New DataSet
                    dtsPrestamos = creditos.ConsultarPrestamos("codPrestamo", " dui = '" & txtDui.Value & "' and saldo_Capital > 0 ", "", sUsuario, sPassword, sSucursal)
                    If dtsPrestamos.Tables.Count > 0 Then
                        If dtsPrestamos.Tables(0).Rows.Count > 0 Then
                            For i As Integer = 0 To dtsPrestamos.Tables(0).Rows.Count - 1
                                creditos.ModificarPrestamos(dtsPrestamos.Tables(0).Rows(i).Item(0), " CasoEspecial = '14' ", sUsuario, sPassword, sSucursal)
                            Next
                        End If
                    End If

                    If Me.chkBloquear.Checked = True Then
                        ahorro.ModificarAhCuentasAhorro("Estado='B'", "Dui='" & Me.txtDui.Text.Trim & "' and Estado<>'C' and Estado<>'D'", sUsuario, sPassword, sSucursal)
                    Else
                        ahorro.ModificarAhCuentasAhorro("Estado='A'", "Dui='" & Me.txtDui.Text.Trim & "' and Estado<>'C' and Estado<>'D'", sUsuario, sPassword, sSucursal)
                    End If
                    MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    With frm
                        .dui = txtDui.Value.ToString.Trim
                        .idReserva = txtNoSolRetiro.Text
                        .Show()
                    End With

                Else
                    MsgBox("El Registro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "FechaSolicitud='" & Format(dtpFecha.Value, "dd/MM/yyyy") &
                "',Motivos='" & Trim(txtMotivos.Text) &
                "',Observaciones='" & Trim(txtObservaciones.Text) &
                "',CuentaBloqueada='" & pBloqueada &
                "', usuarioActu = '" & sUsuario &
                "', fechaActu =  getdate() "
                If oAsoc.ModificarSolicitudRetiro("NoSolicitudRetiro=" & Trim(txtNoSolRetiro.Text) & "", pCampos, sUsuario, sPassword, sSucursal) = True Then

                    If Me.chkBloquear.Checked = True Then
                        ahorro.ModificarAhCuentasAhorro("Estado='B'", "Dui='" & Me.txtDui.Text.Trim & "' and Estado<>'C' and Estado<>'D'", sUsuario, sPassword, sSucursal)
                    Else
                        ahorro.ModificarAhCuentasAhorro("Estado='A'", "Dui='" & Me.txtDui.Text.Trim & "' and Estado<>'C' and Estado<>'D'", sUsuario, sPassword, sSucursal)
                    End If
                    MetroFramework.MetroMessageBox.Show(Me, mensajeUpdateRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    With frm
                        .dui = txtDui.Value.ToString.Trim
                        .idReserva = txtNoSolRetiro.Text
                        .Show()
                    End With
                Else
                    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

#End Region

#Region "Eventos"

    Private Sub frmMsSolicitudRetiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadForm()

    End Sub




#End Region

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Asociados"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,Direccion,TelCasa,Email", "EstadoAsociado<>'2' and EstadoAsociado<>'1'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtNoSocio.Text = ofrm.Resultado2.Trim
            txtDui.Value = ofrm.Resultado.Trim
            txtNombre.Text = ofrm.Resultado4.Trim

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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




    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        Try
            If txtDui.Text.Trim = "" Then
            Else
                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                ds = oAsoc.ConsultarAsociado("DUI,NoSocio, concat(RTRIM(Nombres),' ',RTRIM(Apellido1), ' ', RTRIM(Apellido2)) as Nombre", "Dui='" & txtDui.Text.Trim & "' ", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio")).Trim
                    txtDui.Value = CStr(Filas.Item(0)("DUI")).Trim
                    txtNombre.Text = CStr(Filas.Item(0)("Nombre")).Trim
                    If validarSolicitud() = False Then
                        Me.chkBloquear.Enabled = False
                        Me.txtMotivos.Enabled = False
                        Me.txtObservaciones.Enabled = False
                        Me.btnGuardar1.Enabled = False
                    Else
                        Me.chkBloquear.Enabled = True
                        Me.txtMotivos.Enabled = True
                        Me.txtObservaciones.Enabled = True
                        Me.btnGuardar1.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Protected Function llenarTipoRetiro()
        Dim dts As New DataSet

        Me.cbTipoRetiro.DisplayMember = "Descripcion"
        Me.cbTipoRetiro.ValueMember = "idCatalogo"
        dts = asociado.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.estadoAsociado,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Dim dv As New DataView(dts.Tables(0))
                dv.RowFilter = "idCatalogo <> 25 and idCatalogo <> 27 and idCatalogo <> 30"
                Me.cbTipoRetiro.DataSource = dv
            End If
        End If
    End Function
    Protected Function validarSolicitud()
        Dim valido As Boolean = True
        'Verificamos que no tenga cuentas a plazo pendientes de cancelar
        Dim dtsAhorro As New DataSet
        Dim dtsValLiquidez As New DataSet
        dtsAhorro = ahorro.ConsultarCtasAhorroDUI("a.nocuenta", " a.DUI = '" & txtDui.Value.ToString.Trim & "' and left(a.codtipoahorro,1) in ('6','5') and a.estado = 'A' and a.saldo_cuentaAhorro > 0 ", "", sUsuario, sPassword, sSucursal)
        If dtsAhorro.Tables(0).Rows.Count > 0 Then
            valido = False
            MetroFramework.MetroMessageBox.Show(Me, "No se pueden ingresar solicitud de retiro, asociado tiene cuentas pendientes de vencimiento.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        End If
        ' verificar si saldo de cuentas es mayor o igual al monto necesario para cancelar prestamo
        dtsValLiquidez = asociado.validarLiquidacionCtas(txtDui.Value.ToString.Trim)
        If dtsValLiquidez.Tables(0).Rows.Count > 0 Then
            If dtsValLiquidez.Tables(0).Rows(0).Item("valido") = False Then
                MetroFramework.MetroMessageBox.Show(Me, "No se pueden ingresar solicitud de retiro, el saldo de préstamos es mayor que su saldo de ahorros.", Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                valido = False
            End If
        End If
        Return valido


    End Function



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim bloqueada As String
        Dim frm As New frmVisorRS
        OpcionRS = 233
        bloqueada = IIf(Me.chkBloquear.Checked = True, "1", "0")
        Try
            If Me.btnGuardar1.Text = "&Guardar" Then
                '    If asociado.guardarSolicitudRetiro(txtNoSolRetiro.Text, dtpFecha.Value.ToShortDateString, txtMotivos.Text.Trim.ToUpper, txtDui.Value, txtObservaciones.Text.Trim.ToUpper, bloqueada, sUsuario, False, 1, cbTipoRetiro.SelectedValue) > 0 Then
                '        MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                '    End If
                'Else
                '    If asociado.guardarSolicitudRetiro(txtNoSolRetiro.Text, dtpFecha.Value.ToShortDateString, txtMotivos.Text.Trim.ToUpper, txtDui.Value, txtObservaciones.Text.Trim.ToUpper, bloqueada, sUsuario, False, 2, cbTipoRetiro.SelectedValue) > 0 Then
                '        MetroFramework.MetroMessageBox.Show(Me, mensajeUpdateRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                '    End If
            End If
            btnGuardar1.Enabled = False
            With frm
                .dui = txtDui.Value.ToString.Trim
                .idReserva = txtNoSolRetiro.Text
                .Show()
            End With
            Me.Close()
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub frmMsSolicitudRetiro_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class