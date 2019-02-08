Public Class frmRepPRSaldosxLinea
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtCodLinea As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtCodLinea = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtCodLinea
        '
        Me.txtCodLinea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodLinea.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodLinea.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodLinea.Location = New System.Drawing.Point(123, 82)
        Me.txtCodLinea.Name = "txtCodLinea"
        Me.txtCodLinea.Size = New System.Drawing.Size(80, 20)
        Me.txtCodLinea.TabIndex = 177
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "Fecha del Saldo:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(123, 56)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(112, 20)
        Me.dtpFecha.TabIndex = 175
        '
        'chkTodos
        '
        Me.chkTodos.Location = New System.Drawing.Point(241, 55)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(184, 24)
        Me.chkTodos.TabIndex = 174
        Me.chkTodos.Text = "Todas las Líneas de Préstamos"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNombre.Location = New System.Drawing.Point(209, 82)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(272, 20)
        Me.txtNombre.TabIndex = 171
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 16)
        Me.Label2.TabIndex = 167
        Me.Label2.Text = "Línea Préstamo:"
        '
        'btProcesar1
        '
        Me.btProcesar1.Location = New System.Drawing.Point(406, 108)
        Me.btProcesar1.Name = "btProcesar1"
        Me.btProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btProcesar1.TabIndex = 175
        Me.btProcesar1.Text = "Procesar"
        Me.btProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btProcesar1.UseSelectable = True
        Me.btProcesar1.UseStyleColors = True
        '
        'frmRepPRSaldosxLinea
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(500, 154)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.txtCodLinea)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btProcesar1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(500, 154)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(500, 154)
        Me.Name = "frmRepPRSaldosxLinea"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reporte de Saldos por Líneas de Préstamos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked = True Then
            Me.txtCodLinea.Enabled = True
        Else
            Me.txtCodLinea.Enabled = False
        End If
    End Sub

    Private Sub frmRepPRSaldosxLinea_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Date.Now
    End Sub


    Private Sub txtCodLinea_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodLinea.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Líneas de Crédito"
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarLineaCreditos("*", "", "CodLineaCredito", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodLinea.Text = ofrm.Resultado.Trim
            Me.txtNombre.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btProcesar1_Click(sender As Object, e As EventArgs) Handles btProcesar1.Click
        Try
            Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
            If Me.chkTodos.Checked = True Then
                ds = oPrest.RepSaldosPrestamoxLinea(Me.dtpFecha.Value, Me.chkTodos.Checked, " ", sUsuario, sPassword, sSucursal)
            Else
                ds = oPrest.RepSaldosPrestamoxLinea(Me.dtpFecha.Value, Me.chkTodos.Checked, Me.txtCodLinea.Text, sUsuario, sPassword, sSucursal)
            End If
            Dim ofrm As New frmVisor(ds, 71, 0)
            ofrm.ShowDialog()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class