Public Class frmMsRepCACheques
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents c1txtNoCaja As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCajero As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.c1txtNoCaja = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodCajero = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(401, 42)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha.TabIndex = 2
        Me.dtpFecha.Value = New Date(2006, 8, 19, 10, 44, 20, 248)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(355, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Fecha:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Número de Caja:"
        '
        'c1txtNoCaja
        '
        Me.c1txtNoCaja.BackColor = System.Drawing.Color.White
        Me.c1txtNoCaja.Location = New System.Drawing.Point(118, 42)
        Me.c1txtNoCaja.Name = "c1txtNoCaja"
        Me.c1txtNoCaja.Size = New System.Drawing.Size(48, 20)
        Me.c1txtNoCaja.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.c1txtNoCaja)
        Me.GroupBox1.Controls.Add(Me.txtCodCajero)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(495, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(241, 16)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(248, 20)
        Me.txtNombre.TabIndex = 115
        '
        'txtCodCajero
        '
        Me.txtCodCajero.BackColor = System.Drawing.Color.White
        Me.txtCodCajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCajero.Location = New System.Drawing.Point(118, 16)
        Me.txtCodCajero.MaxLength = 10
        Me.txtCodCajero.Name = "txtCodCajero"
        Me.txtCodCajero.Size = New System.Drawing.Size(117, 20)
        Me.txtCodCajero.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(8, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "Código Cajero:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(443, 149)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1015
        Me.btnGuardar1.Text = "Mostrar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsRepCACheques
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(541, 205)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsRepCACheques"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reporte de Cheques por Movimientos de Caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public pTipo As String

    Private Sub frmMsRepCACheques_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
    End Sub


    Private Sub txtCodCajero_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCajero.DoubleClick
        Dim ofrm As New frmAGenerico

        Try
            Dim oCaja As wrCaja.wsLibCaja = New wrCaja.wsLibCaja, ds As New Data.DataSet
            ds = oCaja.ConsultarCajeros("*", "", "CodCajero", sUsuario, sPassword, sSucursal)
            ofrm.Text = "Buscar Cajeros"
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodCajero.Text = ofrm.Resultado.Trim
            Me.txtNombre.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Cajeros - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click

        Try
            Dim ds As New DataSet
            Dim oCaja As wrCaja.wsLibCaja = New wrCaja.wsLibCaja
            If Me.pTipo = "A" Then
                ds = oCaja.ChequexMovCaja(Me.dtpFecha.Value, Me.c1txtNoCaja.Text.Trim, False, Me.txtCodCajero.Text.Trim, True, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 175, 0)
                ofrm.ShowDialog()
            Else
                ds = oCaja.ChequexMovCaja(Me.dtpFecha.Value, Me.c1txtNoCaja.Text.Trim, False, Me.txtCodCajero.Text.Trim, False, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 29, 0)
                ofrm.ShowDialog()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
