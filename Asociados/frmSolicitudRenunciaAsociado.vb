Public Class frmSolicitudRenunciaAsociado
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    Dim ahorros As New wrAhorro.wsLibAhorro

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNoActa As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaSesion As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkAceptada As System.Windows.Forms.CheckBox
    Friend WithEvents txtObsAsociado As System.Windows.Forms.TextBox
    Friend WithEvents txtObsGerente As System.Windows.Forms.TextBox
    Friend WithEvents txtObsConsejo As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaProy As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDenegada As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkDenegada = New System.Windows.Forms.CheckBox()
        Me.dtpFechaProy = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtObsConsejo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObsGerente = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtObsAsociado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkAceptada = New System.Windows.Forms.CheckBox()
        Me.txtNoActa = New System.Windows.Forms.TextBox()
        Me.dtpFechaSesion = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkDenegada)
        Me.GroupBox1.Controls.Add(Me.dtpFechaProy)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtDui)
        Me.GroupBox1.Controls.Add(Me.txtObsConsejo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtObsGerente)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtObsAsociado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkAceptada)
        Me.GroupBox1.Controls.Add(Me.txtNoActa)
        Me.GroupBox1.Controls.Add(Me.dtpFechaSesion)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpFechaEmision)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(624, 498)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chkDenegada
        '
        Me.chkDenegada.Location = New System.Drawing.Point(499, 46)
        Me.chkDenegada.Name = "chkDenegada"
        Me.chkDenegada.Size = New System.Drawing.Size(106, 19)
        Me.chkDenegada.TabIndex = 5
        Me.chkDenegada.Text = "Denegada"
        '
        'dtpFechaProy
        '
        Me.dtpFechaProy.CausesValidation = False
        Me.dtpFechaProy.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaProy.Location = New System.Drawing.Point(490, 18)
        Me.dtpFechaProy.Name = "dtpFechaProy"
        Me.dtpFechaProy.Size = New System.Drawing.Size(105, 22)
        Me.dtpFechaProy.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(326, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 19)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Fecha Proyección saldos:"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(86, 74)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(144, 23)
        Me.txtDui.TabIndex = 6
        Me.txtDui.Tag = Nothing
        '
        'txtObsConsejo
        '
        Me.txtObsConsejo.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtObsConsejo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsConsejo.Location = New System.Drawing.Point(10, 378)
        Me.txtObsConsejo.MaxLength = 255
        Me.txtObsConsejo.Multiline = True
        Me.txtObsConsejo.Name = "txtObsConsejo"
        Me.txtObsConsejo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsConsejo.Size = New System.Drawing.Size(604, 111)
        Me.txtObsConsejo.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(10, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(172, 27)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Observaciones Consejo:"
        '
        'txtObsGerente
        '
        Me.txtObsGerente.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtObsGerente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsGerente.Location = New System.Drawing.Point(10, 249)
        Me.txtObsGerente.MaxLength = 255
        Me.txtObsGerente.Multiline = True
        Me.txtObsGerente.Name = "txtObsGerente"
        Me.txtObsGerente.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsGerente.Size = New System.Drawing.Size(604, 111)
        Me.txtObsGerente.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(10, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 26)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Observaciones Gerente:"
        '
        'txtObsAsociado
        '
        Me.txtObsAsociado.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtObsAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsAsociado.Location = New System.Drawing.Point(10, 120)
        Me.txtObsAsociado.MaxLength = 255
        Me.txtObsAsociado.Multiline = True
        Me.txtObsAsociado.Name = "txtObsAsociado"
        Me.txtObsAsociado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObsAsociado.Size = New System.Drawing.Size(604, 111)
        Me.txtObsAsociado.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 26)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Observaciones Asociado:"
        '
        'chkAceptada
        '
        Me.chkAceptada.Location = New System.Drawing.Point(394, 46)
        Me.chkAceptada.Name = "chkAceptada"
        Me.chkAceptada.Size = New System.Drawing.Size(86, 19)
        Me.chkAceptada.TabIndex = 4
        Me.chkAceptada.Text = "Aceptada"
        '
        'txtNoActa
        '
        Me.txtNoActa.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtNoActa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoActa.Location = New System.Drawing.Point(298, 46)
        Me.txtNoActa.MaxLength = 20
        Me.txtNoActa.Name = "txtNoActa"
        Me.txtNoActa.Size = New System.Drawing.Size(57, 22)
        Me.txtNoActa.TabIndex = 3
        '
        'dtpFechaSesion
        '
        Me.dtpFechaSesion.CausesValidation = False
        Me.dtpFechaSesion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSesion.Location = New System.Drawing.Point(115, 46)
        Me.dtpFechaSesion.Name = "dtpFechaSesion"
        Me.dtpFechaSesion.Size = New System.Drawing.Size(115, 22)
        Me.dtpFechaSesion.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(10, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 27)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Fecha Sesión:"
        '
        'dtpFechaEmision
        '
        Me.dtpFechaEmision.CausesValidation = False
        Me.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEmision.Location = New System.Drawing.Point(115, 18)
        Me.dtpFechaEmision.Name = "dtpFechaEmision"
        Me.dtpFechaEmision.Size = New System.Drawing.Size(115, 22)
        Me.dtpFechaEmision.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 27)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Fecha Emisión:"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(240, 74)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(365, 22)
        Me.txtNombre.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 26)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "DUI:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(240, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "No Acta:"
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(539, 578)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(113, 32)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 70
        Me.btnProcesar1.Text = "Imprimir"
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmSolicitudRenunciaAsociado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(673, 668)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSolicitudRenunciaAsociado"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Solicitud Renuncia Asociado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
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
            txtDui.Value = ofrm.Resultado.Trim
            txtNombre.Text = ofrm.Resultado4.Trim
            'If ValidarCuentasPendientesCancelar(txtDui.Text.Trim) = True Then
            '    MsgBox("Solicitud de retiro no procede por ser caso especial y tener cuentas de ahorro pendientes de su vencimiento.", MsgBoxStyle.Critical, "Renuncia - Asociado")
            '    Me.Close()
            'End If
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
    Private Function ValidarCuentasPendientesCancelar(ByVal dui As String) As Boolean
        Dim dtsAhorros As New DataSet
        dtsAhorros = ahorros.ConsultarCuentaAhorro("nocuenta", "dui = '" & dui & "' and Left(codTipoahorro,1)in ('2','5') and estado ='A' and Saldo_CuentaAhorro> 0 and fechaVencimiento > getdate() ", "", sUsuario, sPassword, sUsuario)
        If dtsAhorros.Tables.Count > 0 Then
            If dtsAhorros.Tables(0).Rows.Count > 0 Then
                Return True
            Else
                Return False

            End If
        Else
            Return False
        End If
    End Function
    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text.Trim = "" Then Exit Sub
        Try


            Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("Nombres,Apellido1,Apellido2,ApellidoCas", "Dui='" & Me.txtDui.Text.Trim & "'", "DUI", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.txtNombre.Text = dr("Nombres") & " " & dr("Apellido1") & " " & dr("Apellido2")
                If ValidarCuentasPendientesCancelar(txtDui.Text.Trim) = True Then
                    MsgBox("Solicitud de retiro no procede por ser caso especial y tener cuentas de ahorro pendientes de su vencimiento.", MsgBoxStyle.Critical, "Renuncia - Asociado")
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            Dim sd As String
            sd = ex.Message
            sd = ex.Source
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub


    Private Sub frmSolicitudRenunciaAsociado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Dim ds As New Data.DataSet
        Dim oItem As New wrAsociados.wsLibAsoc
        Try


            ds = oItem.ReporteRenunciaAsociado(Me.txtDui.Text, Me.dtpFechaEmision.Value.ToShortDateString, Me.txtObsAsociado.Text, Me.txtObsGerente.Text, Me.txtObsConsejo.Text, Me.dtpFechaSesion.Value.ToShortDateString, Me.txtNoActa.Text, Me.chkAceptada.Checked, Me.chkDenegada.Checked, Me.dtpFechaProy.Value, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 35, 0)
            ofrm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub frmSolicitudRenunciaAsociado_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class