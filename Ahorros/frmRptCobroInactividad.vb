Public Class frmRptCobroInactividad
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnProcesar As MetroFramework.Controls.MetroButton
    Private oAhorro As New wrAhorro.wsLibAhorro
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents c1nSaldoMinimo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.c1nSaldoMinimo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnProcesar = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1nSaldoMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtDesc)
        Me.GroupBox1.Controls.Add(Me.txtCodTipoAhorro)
        Me.GroupBox1.Controls.Add(Me.c1nSaldoMinimo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtDesc
        '
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Location = New System.Drawing.Point(227, 46)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ReadOnly = True
        Me.txtDesc.Size = New System.Drawing.Size(266, 20)
        Me.txtDesc.TabIndex = 2
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(128, 46)
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(96, 20)
        Me.txtCodTipoAhorro.TabIndex = 1
        '
        'c1nSaldoMinimo
        '
        Me.c1nSaldoMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSaldoMinimo.CustomFormat = "###,###,##0.00"
        Me.c1nSaldoMinimo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nSaldoMinimo.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nSaldoMinimo.Location = New System.Drawing.Point(128, 16)
        Me.c1nSaldoMinimo.Name = "c1nSaldoMinimo"
        Me.c1nSaldoMinimo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSaldoMinimo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSaldoMinimo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSaldoMinimo.ShowDropDownButton = False
        Me.c1nSaldoMinimo.ShowUpDownButtons = False
        Me.c1nSaldoMinimo.Size = New System.Drawing.Size(96, 21)
        Me.c1nSaldoMinimo.TabIndex = 0
        Me.c1nSaldoMinimo.Tag = Nothing
        Me.c1nSaldoMinimo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Días de Inactividad:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Tipo Ahorro:"
        '
        'btnProcesar
        '
        Me.btnProcesar.Location = New System.Drawing.Point(440, 139)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(83, 28)
        Me.btnProcesar.Style = MetroFramework.MetroColorStyle.Green
        Me.btnProcesar.TabIndex = 227
        Me.btnProcesar.Text = "Reporte"
        Me.btnProcesar.UseSelectable = True
        Me.btnProcesar.UseStyleColors = True
        '
        'frmRptCobroInactividad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(539, 179)
        Me.Controls.Add(Me.btnProcesar)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRptCobroInactividad"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Cobro por Inactividad en Cuentas de Ahorro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1nSaldoMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public vTipo As String

    Private Sub txtCodTipoAhorro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoAhorro.DoubleClick
        Dim ofrm As New frmAGenerico, ds As New Data.DataSet

        ofrm.Text = "Buscar Código de Tipos de Ahorro"
        Try
            If vTipo = "A" Then
                ds = oAhorro.ConsultarTipoAhorro("*", "Left(CodTipoAhorro,1)='1'", "codTipoAhorro", sUsuario, sPassword, sSucursal)
            Else
                ds = oAhorro.ConsultarTipoAhorro("*", "Left(CodTipoAhorro,1)<>'1'", "codTipoAhorro", sUsuario, sPassword, sSucursal)
            End If
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodTipoAhorro.Text = ofrm.Resultado.Trim
            txtDesc.Text = ofrm.Resultado2.Trim
            Me.btnProcesar.Focus()
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Tipos Ahorro - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub



    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Dim ds As New DataSet
        Dim cod As String
        Try
            cod = Me.txtCodTipoAhorro.Text.Trim
            ds = oAhorro.RepCobroInactividad(Me.c1nSaldoMinimo.Value, cod, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 32, 0)
            ofrm.Show()
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub
End Class