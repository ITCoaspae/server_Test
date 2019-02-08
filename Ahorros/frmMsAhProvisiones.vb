Public Class frmMsAhProvisiones
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim ahorro As New wrAhorro.wsLibAhorro

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpR2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpR1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodCuenta As System.Windows.Forms.TextBox
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpR2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodCuenta = New System.Windows.Forms.TextBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpR1 = New System.Windows.Forms.DateTimePicker()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpR2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodCuenta)
        Me.GroupBox1.Controls.Add(Me.chkTodos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpR1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(393, 103)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(152, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "al"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Del"
        '
        'dtpR2
        '
        Me.dtpR2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpR2.Location = New System.Drawing.Point(176, 40)
        Me.dtpR2.Name = "dtpR2"
        Me.dtpR2.Size = New System.Drawing.Size(88, 20)
        Me.dtpR2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Número de Cuenta:"
        '
        'txtCodCuenta
        '
        Me.txtCodCuenta.Enabled = False
        Me.txtCodCuenta.Location = New System.Drawing.Point(126, 66)
        Me.txtCodCuenta.Name = "txtCodCuenta"
        Me.txtCodCuenta.Size = New System.Drawing.Size(249, 20)
        Me.txtCodCuenta.TabIndex = 4
        '
        'chkTodos
        '
        Me.chkTodos.Checked = True
        Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTodos.Location = New System.Drawing.Point(273, 40)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(102, 16)
        Me.chkTodos.TabIndex = 2
        Me.chkTodos.Text = "&Todas las Cuentas"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha de Movimiento:"
        '
        'dtpR1
        '
        Me.dtpR1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpR1.Location = New System.Drawing.Point(48, 40)
        Me.dtpR1.Name = "dtpR1"
        Me.dtpR1.Size = New System.Drawing.Size(88, 20)
        Me.dtpR1.TabIndex = 0
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(320, 172)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(96, 28)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton3.TabIndex = 210
        Me.MetroButton3.Text = "Procesar"
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'frmMsAhProvisiones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(439, 276)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(439, 276)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(439, 276)
        Me.Name = "frmMsAhProvisiones"
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Cálculo de Provisión - Ahorros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked = False Then
            Me.txtCodCuenta.Enabled = True
        Else
            Me.txtCodCuenta.Enabled = False
        End If
    End Sub



    Private Sub frmMsAhProvisiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpR1.Value = Now
        Me.dtpR2.Value = Now
    End Sub

    'Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim oAsoc As wrAsociados.wsLibAsoc
    '    Dim ds As New Data.DataSet
    '    Dim ofrm As New frmAGenerico

    '    Try
    '        oAsoc = New wrAsociados.wsLibAsoc
    '        ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "", "DUI", sUsuario, sPassword, sSucursal)
    '        ofrm.Text = "Mostrar Asociados"
    '        ofrm.Datos = ds
    '        ofrm.ColSeleccion = 0
    '        ofrm.RefrescarGrid()
    '        ofrm.ShowDialog()
    '        If ofrm.Resultado.Trim <> "" Then
    '            Dim sDui As String, sNombre As String
    '            sDui = ofrm.Resultado.Trim
    '            sNombre = ofrm.Resultado2.Trim & " " & ofrm.Resultado3.Trim & " " & ofrm.Resultado4.Trim
    '            'Me.txtDui.Value = sDui.Trim
    '        End If
    '    Catch ex As Exception
    '        Dim sd As String
    '        sd = ex.Message
    '        sd = ex.Source
    '    End Try
    'End Sub

    'Private Sub txtCodCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCuenta.DoubleClick
    '    Dim frm As New frmAGenerico
    '    Dim sTexto As String

    '    frm.Text = "Buscar Cuenta"
    '    Dim oAh As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro")
    '    Try
    '        oAh = New wrAhorro.wsLibAhorro
    '        ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,NoCuentaAnterior,FechaApertura,Saldo_CuentaAhorro", "Dui='" & Me.txtDui.Value & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
    '        frm.Datos = ds
    '        frm.ColSeleccion = 0
    '        frm.RefrescarGrid()
    '        frm.ShowDialog()
    '        If frm.Resultado.Trim = "" Then
    '        ElseIf frm.Resultado.Trim <> "" Then
    '            sTexto = frm.Resultado3.Trim
    '            Me.txtCodCuenta.Text = sTexto
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub txtDui_Click(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim Valor As String
    '        Valor = IIf(txtDui.ValueIsDbNull, "", txtDui.Value)
    '        If Valor.Trim = "" Then
    '            Me.txtDui.SelectionStart = 0
    '            Me.txtDui.SelectionLength = 0
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            If (MsgBox("¿Desea realizar este proceso?", MsgBoxStyle.YesNo)) = MsgBoxResult.Yes Then
                Dim resultado As String
                Dim todas As Integer
                If chkTodos.Checked = True Then
                    todas = 1
                Else
                    todas = 0
                End If
                resultado = ahorro.procesarProvisionAhorro(todas, dtpR1.Value.ToShortDateString, dtpR2.Value.ToShortDateString, txtCodCuenta.Text)
                If resultado.Length > 0 Then
                    MsgBox(resultado, MsgBoxStyle.Information)
                Else
                    MsgBox(mensajeError, MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception

        End Try
        'Try
        '    Dim oAh As wrAhorro.wsLibAhorro, pValor As String, pFecha As Date, pFecIni As Date, pFecFin As Date, oApp As New wrAdmin.wsLibAdmin
        '    oAh = New wrAhorro.wsLibAhorro
        '    oAh.Timeout = -1
        '    pFecha = dtpR1.Value.Date
        '    pFecIni = dtpR1.Value.Date
        '    pFecFin = dtpR2.Value.Date
        '    Me.Cursor = Cursors.WaitCursor
        '    oApp.EscribeLog("Provisión de Ahorros iniciada." & vbCrLf & "Usuario: " & sUsuario & ", Fecha y Hora: " & oApp.Fecha.ToString)
        '    Do While pFecha <= pFecFin
        '        pValor = oAh.CalculoProvisionIntereses(Me.txtCodCuenta.Text.Trim, Me.chkTodos.Checked, pFecha, pFecha, sUsuario, sPassword, sSucursal)
        '        If Trim(pValor) <> "" Then
        '            MessageBox.Show(pValor, "Provisión de Intereses", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)
        '            Exit Sub
        '        End If
        '        If Me.chkTransf.Checked = True Then oAh.TransferenciaAutomaticaCuentas(pFecha, sUsuario, sPassword, sSucursal)
        '        pFecha = DateAdd(DateInterval.Day, 1, pFecha)
        '    Loop

        '    oApp.EscribeLog("Provisión de Ahorros finalizada con éxito." & vbCrLf & "Usuario: " & sUsuario & ", Fecha y Hora: " & oApp.Fecha.ToString)
        '    Me.Cursor = Cursors.Default
        '    Me.txtCodCuenta.Text = ""
        '    If pValor Is Nothing Then
        '        MessageBox.Show("Cálculo de provisión de intereses finalizado.", "Provisión de Intereses", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)
        '    Else
        '        If pValor.Trim <> "" Then
        '            MessageBox.Show(pValor, "Provisión de Intereses", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)
        '        Else
        '            MessageBox.Show("Cálculo de provisión de intereses finalizado.", "Provisión de Intereses", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)
        '        End If
        '    End If
        'Catch ex As Exception
        '    Me.Cursor = Cursors.Default
        '    MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        'End Try
    End Sub
End Class