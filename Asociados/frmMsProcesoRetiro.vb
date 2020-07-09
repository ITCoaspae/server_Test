Public Class frmMsProcesoRetiro
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim asociados As New wrAsociados.wsLibAsoc
    Dim ahorro As New wrAhorro.wsLibAhorro
    Public pDui As String, pAccion As String, pCorr As String, pCont As Boolean
    Friend WithEvents btGenerarMov1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btGenCheque1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFecha As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtNoSolRetiro As System.Windows.Forms.TextBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtNoActa As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNoSolRetiro = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtNoActa = New System.Windows.Forms.TextBox()
        Me.btGenerarMov1 = New MetroFramework.Controls.MetroButton()
        Me.btGenCheque1 = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFecha = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDui
        '
        Me.txtDui.BackColor = System.Drawing.Color.White
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(112, 62)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(106, 16)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BackColor = System.Drawing.Color.White
        Me.txtNoSocio.Enabled = False
        Me.txtNoSocio.Location = New System.Drawing.Point(325, 64)
        Me.txtNoSocio.MaxLength = 8
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(106, 20)
        Me.txtNoSocio.TabIndex = 1
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(112, 88)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(319, 20)
        Me.txtNombre.TabIndex = 90
        '
        'txtNoSolRetiro
        '
        Me.txtNoSolRetiro.BackColor = System.Drawing.Color.White
        Me.txtNoSolRetiro.Enabled = False
        Me.txtNoSolRetiro.Location = New System.Drawing.Point(112, 113)
        Me.txtNoSolRetiro.MaxLength = 50
        Me.txtNoSolRetiro.Name = "txtNoSolRetiro"
        Me.txtNoSolRetiro.Size = New System.Drawing.Size(106, 20)
        Me.txtNoSolRetiro.TabIndex = 0
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.White
        Me.txtObservaciones.Location = New System.Drawing.Point(112, 168)
        Me.txtObservaciones.MaxLength = 100
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(319, 44)
        Me.txtObservaciones.TabIndex = 5
        '
        'txtNoActa
        '
        Me.txtNoActa.BackColor = System.Drawing.Color.White
        Me.txtNoActa.Location = New System.Drawing.Point(325, 113)
        Me.txtNoActa.MaxLength = 20
        Me.txtNoActa.Name = "txtNoActa"
        Me.txtNoActa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoActa.Size = New System.Drawing.Size(106, 20)
        Me.txtNoActa.TabIndex = 1
        '
        'btGenerarMov1
        '
        Me.btGenerarMov1.Location = New System.Drawing.Point(147, 242)
        Me.btGenerarMov1.Name = "btGenerarMov1"
        Me.btGenerarMov1.Size = New System.Drawing.Size(106, 28)
        Me.btGenerarMov1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btGenerarMov1.TabIndex = 40
        Me.btGenerarMov1.Text = "Cancelar Cuentas"
        Me.btGenerarMov1.UseSelectable = True
        Me.btGenerarMov1.UseStyleColors = True
        Me.btGenerarMov1.Visible = False
        '
        'btGenCheque1
        '
        Me.btGenCheque1.Location = New System.Drawing.Point(338, 242)
        Me.btGenCheque1.Name = "btGenCheque1"
        Me.btGenCheque1.Size = New System.Drawing.Size(93, 28)
        Me.btGenCheque1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btGenCheque1.TabIndex = 41
        Me.btGenCheque1.Text = "Generar &Cheque"
        Me.btGenCheque1.UseSelectable = True
        Me.btGenCheque1.UseStyleColors = True
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(258, 242)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 42
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(19, 62)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(33, 19)
        Me.MetroLabel1.TabIndex = 43
        Me.MetroLabel1.Text = "DUI:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(242, 62)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(91, 19)
        Me.MetroLabel2.TabIndex = 44
        Me.MetroLabel2.Text = "No. Asociado:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(19, 88)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel3.TabIndex = 45
        Me.MetroLabel3.Text = "Asociado:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(19, 113)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel4.TabIndex = 91
        Me.MetroLabel4.Text = "No. Solicitud:"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(242, 113)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel5.TabIndex = 92
        Me.MetroLabel5.Text = "No. Acta:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(19, 137)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel6.TabIndex = 93
        Me.MetroLabel6.Text = "Fecha Acta:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Location = New System.Drawing.Point(112, 137)
        Me.dtpFecha.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(319, 30)
        Me.dtpFecha.Style = MetroFramework.MetroColorStyle.Teal
        Me.dtpFecha.TabIndex = 94
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(19, 168)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel7.TabIndex = 95
        Me.MetroLabel7.Text = "Observación:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(19, 218)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(103, 19)
        Me.MetroLabel8.TabIndex = 96
        Me.MetroLabel8.Text = "Monto Liquidar:"
        '
        'txtMonto
        '
        Me.txtMonto.BackColor = System.Drawing.Color.White
        Me.txtMonto.Enabled = False
        Me.txtMonto.Location = New System.Drawing.Point(112, 218)
        Me.txtMonto.MaxLength = 50
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(319, 20)
        Me.txtMonto.TabIndex = 97
        '
        'frmMsProcesoRetiro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(540, 365)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.MetroLabel7)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.btGenCheque1)
        Me.Controls.Add(Me.btGenerarMov1)
        Me.Controls.Add(Me.txtNoSolRetiro)
        Me.Controls.Add(Me.txtNoActa)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsProcesoRetiro"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Proceso de Retiro Voluntario"
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub txtNoSocio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoSocio.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Asociados"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtNoSocio.Text = ofrm.Resultado2.Trim
            txtDui.Value = ofrm.Resultado.Trim
            txtNombre.Text = ofrm.Resultado4.Trim

            Dim Filas As Data.DataRowCollection

            ds = oAsoc.ConsultarRetiros("*", "Dui='" & Me.txtDui.Value & "' and NoSocio='" & Me.txtNoSocio.Text.Trim & "'", "Correlativo", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                Me.txtNoSolRetiro.Text = CStr(Filas.Item(0)("NoSolicitudRetiro"))
                Me.txtNoActa.Text = CStr(Filas.Item(0)("ActaNo"))
                Me.dtpFecha.Value = Filas.Item(0)("FechaActa")
                ' Me.txtArchivo.Text = Filas.Item(0)("ArchivoVinculoActa")
                Me.txtObservaciones.Text = Filas.Item(0)("Observacion")
                'Me.txtNoCheque.Text = CStr(Filas.Item(0)("NoCheque"))
                'Me.txtNoLiquidacion.Text = CStr(Filas.Item(0)("NoLiquidacion"))
                'Me.chkLiquidacion.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("Liquidacion")), "0", Filas.Item(0)("Liquidacion")) = "1", True, False)
                'Me.chkRetiroEfect.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("RetiroEfectuado")), "0", Filas.Item(0)("RetiroEfectuado")) = "1", True, False)
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmMsProcesoRetiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Me.dtpFecha.Value = Now
        Try
            If Me.btnGuardar1.Text = "&Modificar" Then

                Dim Filas As Data.DataRowCollection

                ds = oAsoc.ConsultarRetiros("*", "Correlativo='" & pCorr & "'", "Correlativo", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtNoSolRetiro.Text = CStr(Filas.Item(0)("NoSolicitudRetiro"))
                    Me.txtNoActa.Text = CStr(Filas.Item(0)("ActaNo"))
                    Me.dtpFecha.Value = Filas.Item(0)("FechaActa")
                    ' Me.txtArchivo.Text = Filas.Item(0)("ArchivoVinculoActa")
                    Me.txtObservaciones.Text = Filas.Item(0)("Observacion")
                    'Me.txtNoCheque.Text = CStr(Filas.Item(0)("NoCheque"))
                    'Me.txtNoLiquidacion.Text = CStr(Filas.Item(0)("NoLiquidacion"))
                    'Me.chkLiquidacion.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("Liquidacion")), "0", Filas.Item(0)("Liquidacion")) = "1", True, False)
                    'Me.chkRetiroEfect.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("RetiroEfectuado")), "0", Filas.Item(0)("RetiroEfectuado")) = "1", True, False)
                End If
                ds = oAsoc.ConsultarAsociado("NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre", "Dui='" & Trim(txtDui.Text) & "'", "Dui", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNoSocio.Text = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))
                    txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                    txtDui.Enabled = False
                    txtNoSocio.Enabled = False
                    txtNombre.Enabled = False
                    txtNoSolRetiro.Enabled = False
                End If

            End If
            'If pCont = True Then
            '    Me.btGenerarMov1.Visible = True
            '    Me.btGenCheque1.Visible = True
            'End If

        Catch ex As Exception
            MessageBox.Show("Error en la carga de datos Módulo Asociados." & vbCrLf & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
    Protected Sub validarSolicitudRetiro()
        Dim dtsSolRetiro As New DataSet
        dtsSolRetiro = asociados.ConsultarSolicitudRetiro("NoSolicitudRetiro", "dui = '" & txtDui.Text.Trim & "' and anulado = 'False'  ", "", sUsuario, sPassword, sSucursal)
        If dtsSolRetiro.Tables.Count > 0 Then
            If dtsSolRetiro.Tables(0).Rows.Count > 0 Then
                txtNoSolRetiro.Text = dtsSolRetiro.Tables(0).Rows(0).Item(0).ToString.Trim
            Else
                MsgBox("No se ha creado solicitud de retiro", MsgBoxStyle.Critical, "Módlo - Asociados")
                Me.Close()
            End If
        Else
            MsgBox("No se ha creado solicitud de retiro", MsgBoxStyle.Critical, "Módlo - Asociados")
            Me.Close()
        End If
    End Sub
    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Asociados"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "EstadoAsociado='5' or EstadoAsociado='25'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtNoSocio.Text = ofrm.Resultado2.Trim
            txtDui.Value = ofrm.Resultado.Trim
            Me.txtNombre.Text = ofrm.Resultado4.Trim
            'validarSolicitudRetiro()
            'If pCont = True Then
            Dim Filas As Data.DataRowCollection
            ds = oAsoc.ConsultarRetiros("*", "Dui='" & Me.txtDui.Value & "' and NoSocio='" & Me.txtNoSocio.Text.Trim & "'", "Correlativo", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                MsgBox("El asociado ya cuenta con un proceso de retiro activo.", MsgBoxStyle.Critical, "Módulo - Asociados")
                Me.Close()
                'Me.txtNoSolRetiro.Text = CStr(Filas.Item(0)("NoSolicitudRetiro"))
                'Me.txtNoActa.Text = CStr(Filas.Item(0)("ActaNo"))
                'Me.dtpFecha.Value = Filas.Item(0)("FechaActa")
                'Me.txtArchivo.Text = Filas.Item(0)("ArchivoVinculoActa")
                'Me.txtObservaciones.Text = Filas.Item(0)("Observacion")
                'Me.txtNoCheque.Text = CStr(Filas.Item(0)("NoCheque"))
                'Me.txtNoLiquidacion.Text = CStr(Filas.Item(0)("NoLiquidacion"))
                'Me.chkLiquidacion.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("Liquidacion")), "0", Filas.Item(0)("Liquidacion")) = "1", True, False)
                'Me.chkRetiroEfect.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("RetiroEfectuado")), "0", Filas.Item(0)("RetiroEfectuado")) = "1", True, False)
            End If
            'End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        Try
            If txtDui.Text.Trim = "" Then
            Else
                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,Direccion,TelCasa,Email", "Dui='" & txtDui.Text.Trim & "' and EstadoAsociado<>'2' and EstadoAsociado<>'1'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio")).Trim
                    txtDui.Value = CStr(Filas.Item(0)("DUI")).Trim
                    txtNombre.Text = CStr(Filas.Item(0)("Nombre")).Trim
                    validarSolicitudRetiro()
                    ds = oAsoc.ConsultarRetiros("*", "Dui='" & Me.txtDui.Value & "' and NoSocio='" & Me.txtNoSocio.Text.Trim & "' ", "Correlativo", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        MsgBox("El asociado ya cuenta con un proceso de retiro activo.", MsgBoxStyle.Critical, "Módulo - Asociados")
                        Me.Close()
                        'Me.txtNoSolRetiro.Text = CStr(Filas.Item(0)("NoSolicitudRetiro"))
                        'Me.txtNoActa.Text = CStr(Filas.Item(0)("ActaNo"))
                        'Me.dtpFecha.Value = Filas.Item(0)("FechaActa")
                        'Me.txtArchivo.Text = Filas.Item(0)("ArchivoVinculoActa")
                        'Me.txtObservaciones.Text = Filas.Item(0)("Observacion")
                        'Me.txtNoCheque.Text = CStr(Filas.Item(0)("NoCheque"))
                        'Me.txtNoLiquidacion.Text = CStr(Filas.Item(0)("NoLiquidacion"))
                        'Me.chkLiquidacion.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("Liquidacion")), "0", Filas.Item(0)("Liquidacion")) = "1", True, False)
                        'Me.chkRetiroEfect.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("RetiroEfectuado")), "0", Filas.Item(0)("RetiroEfectuado")) = "1", True, False)
                    End If


                    'ds = oAsoc.ConsultarSolicitudRetiro("NoSolicitudRetiro", "Dui='" & Me.txtDui.Value & "'", "NoSolicitudRetiro", sUsuario, sPassword, sSucursal)
                    'Filas = ds.Tables(0).Rows()
                    'If Filas.Count > 0 Then
                    '    Me.txtNoSolRetiro.Text = IIf(IsDBNull(Filas.Item(0)("NoSolicitudRetiro")), "", Filas.Item(0)("NoSolicitudRetiro"))
                    'End If

                Else
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btGenerarMov1_Click(sender As Object, e As EventArgs) Handles btGenerarMov1.Click

        Try

            Dim resultado As Integer = 0
            If (MetroFramework.MetroMessageBox.Show(Me, "Este proceso cancelara las cuentas del asociados, ¿desea continuar?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)) = DialogResult.Yes Then
                resultado = asociados.liquidarCuentas_RenunciaAsociado(txtNoSolRetiro.Text, txtDui.Value, Now, sUsuario)
                If resultado > 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, "Cancelación de cuentas de asociado realizada exitosamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btGenerarMov1.Enabled = False
                    Dim dtsRetiro As New DataSet
                    dtsRetiro = asociados.ConsultarRetiros("montoLiquidar", "NoSolicitudRetiro = '" & txtNoSolRetiro.Text.Trim & "'", "", sUsuario, sPassword, sSucursal)
                    If dtsRetiro.Tables.Count > 0 Then
                        If dtsRetiro.Tables(0).Rows.Count > 0 Then
                            btGenCheque1.Enabled = True
                            txtMonto.Text = dtsRetiro.Tables(0).Rows(0).Item(0)
                        End If
                    End If
                Else
                    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_TextChanged(sender As Object, e As EventArgs) Handles txtDui.TextChanged

    End Sub

    Private Sub btGenCheque1_Click(sender As Object, e As EventArgs) Handles btGenCheque1.Click
        Dim frm As New frmMsBCCheque
        With frm

            .noSolicitudRetiro = txtNoSolRetiro.Text.Trim
            .txtPagueseA.Text = txtNombre.Text.Trim.ToUpper
            .C1NEMonto.Value = txtMonto.Text
            .txtConcepto.Text = "Retiro de asociado: " & txtNombre.Text.Trim
            .FormOrigen = 2
            .StartPosition = FormStartPosition.CenterScreen
            .ShowDialog()
        End With

    End Sub



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, oApp As New wrAdmin.wsLibAdmin
        Dim pCampos As String, pValores As String
        Try
            If (MetroFramework.MetroMessageBox.Show(Me, "Este proceso cancela las cuentas del asociado, y cambia el estado a retirado. ¿Desea continuar? ", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = DialogResult.Yes Then
                'Validamos que no tenga cuentas pignoradas
                Dim dts As New DataSet
                dts = ahorro.ConsultarCuentaAhorro("Nocuenta", " Dui = '" & txtDui.Value.ToString.Trim & "' and saldo_cuentaAhorro > 0 and montoPignorado > 0 ", "", sUsuario, sPassword, sSucursal)
                If dts.Tables.Count > 0 Then
                    If dts.Tables(0).Rows.Count > 0 Then
                        MetroFramework.MetroMessageBox.Show(Me, "Para continuar con el proceso de retiro, por favor despignorar cuentas de ahorro.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                        Me.Close()
                    End If
                End If

                Dim resultado As Integer
                resultado = asociados.guardarRetiro(txtNoSolRetiro.Text, txtDui.Value, txtObservaciones.Text.Trim.ToUpper, txtNoActa.Text, dtpFecha.Value.ToShortDateString, sUsuario, Now)
                If resultado > 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    btGenerarMov1.Enabled = False
                    Dim dtsRetiro As New DataSet
                    dtsRetiro = asociados.ConsultarRetiros("montoLiquidar", "NoSolicitudRetiro = '" & txtNoSolRetiro.Text.Trim & "'", "", sUsuario, sPassword, sSucursal)
                    If dtsRetiro.Tables.Count > 0 Then
                        If dtsRetiro.Tables(0).Rows.Count > 0 Then
                            btGenCheque1.Enabled = True
                            txtMonto.Text = dtsRetiro.Tables(0).Rows(0).Item(0)
                        End If
                    End If
                    Me.btnGuardar1.Enabled = False
                    Me.btGenCheque1.Enabled = True
                Else
                    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                    Me.Close()

                End If
            End If




        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub





    Private Sub frmMsProcesoRetiro_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class