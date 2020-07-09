Public Class frmMsPRProvision
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Dim prestamo As New wrPrestamo.wsLibPrest

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
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents dtpR2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpR1 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpR2 = New System.Windows.Forms.DateTimePicker()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.dtpR1 = New System.Windows.Forms.DateTimePicker()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpR2
        '
        Me.dtpR2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpR2.Location = New System.Drawing.Point(338, 73)
        Me.dtpR2.Name = "dtpR2"
        Me.dtpR2.Size = New System.Drawing.Size(126, 22)
        Me.dtpR2.TabIndex = 2
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.Enabled = False
        Me.txtCodPrestamo.Location = New System.Drawing.Point(126, 101)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(338, 22)
        Me.txtCodPrestamo.TabIndex = 0
        '
        'chkTodos
        '
        Me.chkTodos.Checked = True
        Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTodos.Location = New System.Drawing.Point(26, 129)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(163, 18)
        Me.chkTodos.TabIndex = 3
        Me.chkTodos.Text = "&Todos los Préstamos"
        '
        'dtpR1
        '
        Me.dtpR1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpR1.Location = New System.Drawing.Point(126, 73)
        Me.dtpR1.Name = "dtpR1"
        Me.dtpR1.Size = New System.Drawing.Size(126, 22)
        Me.dtpR1.TabIndex = 1
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(374, 129)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 33)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 161
        Me.btnGuardar1.Text = "Procesar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 162
        Me.Label1.Text = "Fecha Inicio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(258, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 163
        Me.Label3.Text = "Fecha Fin:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 17)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Cod.Préstamo"
        '
        'frmMsPRProvision
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(510, 230)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.dtpR2)
        Me.Controls.Add(Me.txtCodPrestamo)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.dtpR1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(397, 230)
        Me.Name = "frmMsPRProvision"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cálculo de Provisión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim m
    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked = False Then
            Me.txtCodPrestamo.Enabled = True
        Else
            Me.txtCodPrestamo.Enabled = False
        End If
    End Sub



    Private Sub frmMsPRProvision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpR1.Value = Now
        Me.dtpR2.Value = Now
    End Sub

    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow
        Dim frm As New frmAGenerico, sTexto As String
        frm.Text = "Buscar Préstamo"
        Try
            oPrest = New wrPrestamo.wsLibPrest
            ds = oPrest.ConsultarPRPrestamosTipoCredito("a.CodPrestamo,a.CodAnteriorPrestamo,a.CodTipoCredito,a.Monto,a.Saldo_Capital as Saldo,a.FechaOtorgamiento as Fecha_Apertura,a.FechaVencimiento", "a.Saldo_Capital>0", "a.CodPrestamo", sUsuario, sPassword, sSucursal)
            'ds = oPrest.CargarListaPrestamos(True, "", "", "", "", 0, 0, sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oPrest.CargaDatosPrestamo(sTexto, sUsuario, sPassword, sSucursal)
                dr = ds.Tables("Prestamo").Rows(0)
                Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim todas As Integer
            Dim mensaje As String = ""
            Dim diasProvisionar As Integer
            Dim fecha As DateTime
            Dim contador As Integer = 1

            If chkTodos.Checked = True Then
                todas = 1
            Else
                todas = 0
            End If
            fecha = dtpR1.Value
            diasProvisionar = DateDiff(DateInterval.Day, dtpR1.Value, dtpR2.Value)
            If MsgBox("Desea realizar esta acción. ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                While fecha <= dtpR2.Value
                    mensaje = mensaje & prestamo.provisionarPrestamos(Format(fecha, "short date"), todas, txtCodPrestamo.Text.Trim) & vbNewLine
                    'mensaje = mensaje & "Fechaprovisionar" & fecha.ToShortDateString & vbNewLine
                    fecha = DateAdd(DateInterval.Day, 1, fecha)
                    contador = contador + 1
                End While
            End If
            ' If diasProvisionar > 0 Then



        Catch ex As Exception
            Me.Cursor = Cursors.Default
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
