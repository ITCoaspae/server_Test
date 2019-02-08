Public Class frmMsPRProvision
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents btProcesar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpR2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpR1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMsPRProvision))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpR2 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox
        Me.chkTodos = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpR1 = New System.Windows.Forms.DateTimePicker
        Me.btProcesar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpR2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCodPrestamo)
        Me.GroupBox1.Controls.Add(Me.chkTodos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpR1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(152, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "al"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Del"
        '
        'dtpR2
        '
        Me.dtpR2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpR2.Location = New System.Drawing.Point(176, 45)
        Me.dtpR2.Name = "dtpR2"
        Me.dtpR2.Size = New System.Drawing.Size(88, 20)
        Me.dtpR2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Código de Préstamo:"
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.Enabled = False
        Me.txtCodPrestamo.Location = New System.Drawing.Point(120, 104)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(144, 20)
        Me.txtCodPrestamo.TabIndex = 3
        Me.txtCodPrestamo.Text = ""
        '
        'chkTodos
        '
        Me.chkTodos.Checked = True
        Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTodos.Location = New System.Drawing.Point(16, 80)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(136, 16)
        Me.chkTodos.TabIndex = 2
        Me.chkTodos.Text = "&Todos los Préstamos"
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
        Me.dtpR1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpR1.Location = New System.Drawing.Point(48, 45)
        Me.dtpR1.Name = "dtpR1"
        Me.dtpR1.Size = New System.Drawing.Size(88, 20)
        Me.dtpR1.TabIndex = 0
        '
        'btProcesar
        '
        Me.btProcesar.BackColor = System.Drawing.SystemColors.Control
        Me.btProcesar.Image = CType(resources.GetObject("btProcesar.Image"), System.Drawing.Image)
        Me.btProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btProcesar.Location = New System.Drawing.Point(112, 152)
        Me.btProcesar.Name = "btProcesar"
        Me.btProcesar.Size = New System.Drawing.Size(80, 27)
        Me.btProcesar.TabIndex = 1
        Me.btProcesar.Text = "&Procesar"
        Me.btProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(208, 152)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(80, 27)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "&Cerrar"
        '
        'frmMsPRProvision
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(298, 184)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btProcesar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMsPRProvision"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "    Cálculo de Provisión"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    
    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked = False Then
            Me.txtCodPrestamo.Enabled = True
        Else
            Me.txtCodPrestamo.Enabled = False
        End If
    End Sub

    Private Sub btProcesar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btProcesar.Click
        Dim oCred As wsSysFinCoop.LibPrest.wsLibPrest, pValor As String, pFecha As Date
        oCred = New wsSysFinCoop.LibPrest.wsLibPrest
        oCred.Timeout = -1
        pFecha = dtpR1.Value.Date
        Me.Cursor = Cursors.WaitCursor
        Do While pFecha <= dtpR2.Value.Date
            pValor = oCred.CalculoInteresDiario(Trim(txtCodPrestamo.Text), Me.chkTodos.Checked, pFecha, dtpR2.Value.Date, sUsuario, sPassword, sSucursal)
            If Trim(pValor) <> "" Then
                MsgBox(pValor, MsgBoxStyle.Information, "Cálculo de Provisión")
                Exit Sub
            End If
            pFecha = DateAdd(DateInterval.Day, 1, pFecha)
        Loop
        Me.Cursor = Cursors.Default
        MessageBox.Show("Cálculo de provisión de intereses finalizado.", "Provisión de Intereses", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3)
    End Sub

    Private Sub frmMsPRProvision_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpR1.Value = Now
        Me.dtpR2.Value = Now
    End Sub

    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick

        Dim oPrest As wsSysFinCoop.LibPrest.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow
        Dim frm As New frmAGenerico, sTexto As String

        frm.Text = "Buscar Préstamo"
        Try
            oPrest = New wsSysFinCoop.LibPrest.wsLibPrest
            ds = oPrest.CargarListaPrestamos(True, "", "", "", "", 0, 0, sUsuario, sPassword, sSucursal)
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
            MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

End Class
