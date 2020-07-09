Public Class frmRepPrestamos_TiposCredito
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
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents txtTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btProcesar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.txtTipoCredito = New System.Windows.Forms.TextBox()
        Me.txtCodTipoCredito = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'chkTodos
        '
        Me.chkTodos.Checked = True
        Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTodos.Location = New System.Drawing.Point(226, 63)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(160, 16)
        Me.chkTodos.TabIndex = 1
        Me.chkTodos.Text = "Todos los tipos de crédito"
        '
        'txtTipoCredito
        '
        Me.txtTipoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCredito.Enabled = False
        Me.txtTipoCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCredito.Location = New System.Drawing.Point(226, 88)
        Me.txtTipoCredito.MaxLength = 100
        Me.txtTipoCredito.Name = "txtTipoCredito"
        Me.txtTipoCredito.ReadOnly = True
        Me.txtTipoCredito.Size = New System.Drawing.Size(288, 20)
        Me.txtTipoCredito.TabIndex = 3
        '
        'txtCodTipoCredito
        '
        Me.txtCodTipoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTipoCredito.Location = New System.Drawing.Point(121, 86)
        Me.txtCodTipoCredito.MaxLength = 10
        Me.txtCodTipoCredito.Name = "txtCodTipoCredito"
        Me.txtCodTipoCredito.ReadOnly = True
        Me.txtCodTipoCredito.Size = New System.Drawing.Size(99, 20)
        Me.txtCodTipoCredito.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "Tipo de Crédito:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(121, 60)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(99, 20)
        Me.dtpFecha.TabIndex = 0
        Me.dtpFecha.Value = New Date(2006, 12, 19, 16, 42, 14, 734)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Fecha:"
        '
        'btProcesar1
        '
        Me.btProcesar1.Location = New System.Drawing.Point(439, 114)
        Me.btProcesar1.Name = "btProcesar1"
        Me.btProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btProcesar1.TabIndex = 174
        Me.btProcesar1.Text = "Procesar"
        Me.btProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btProcesar1.UseSelectable = True
        Me.btProcesar1.UseStyleColors = True
        '
        'frmRepPrestamos_TiposCredito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(534, 166)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.btProcesar1)
        Me.Controls.Add(Me.txtTipoCredito)
        Me.Controls.Add(Me.txtCodTipoCredito)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpFecha)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(534, 166)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(534, 166)
        Me.Name = "frmRepPrestamos_TiposCredito"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Préstamos Hipotecarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        txtCodTipoCredito.ReadOnly = chkTodos.Checked
    End Sub

    Private Sub txtCodTipoCredito_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoCredito.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Tipo de Crédito"
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarTipoCreditos("*", "", "CodTipoCredito", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodTipoCredito.Text = ofrm.Resultado.Trim
            txtTipoCredito.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmRepPrestamos_TiposCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
    End Sub

    Private Sub btProcesar1_Click(sender As Object, e As EventArgs) Handles btProcesar1.Click
        Try
            Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet, pCodTipoCredito As String
            If Me.chkTodos.Checked = False Then
                pCodTipoCredito = Me.txtCodTipoCredito.Text.Trim
            Else
                pCodTipoCredito = ""
            End If
            ds = oPrest.SaldosPrestamos_Tipo(Me.dtpFecha.Value, wrPrestamo.TipoPrestamos.Hipotecarios, pCodTipoCredito, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 123, 0)
            ofrm.ShowDialog()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class