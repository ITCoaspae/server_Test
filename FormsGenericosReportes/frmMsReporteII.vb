Public Class frmMsReporteII
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager

    Private vTitulo As String, vNumReporte As String
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.txtTipoAhorro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.chkTodos)
        Me.GroupBox1.Controls.Add(Me.txtCodTipoAhorro)
        Me.GroupBox1.Controls.Add(Me.txtTipoAhorro)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFecha2)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(392, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chkTodos
        '
        Me.chkTodos.Location = New System.Drawing.Point(312, 8)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(64, 16)
        Me.chkTodos.TabIndex = 0
        Me.chkTodos.Text = "&Todos"
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.AcceptsReturn = True
        Me.txtCodTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(8, 32)
        Me.txtCodTipoAhorro.MaxLength = 10
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(80, 20)
        Me.txtCodTipoAhorro.TabIndex = 1
        '
        'txtTipoAhorro
        '
        Me.txtTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoAhorro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoAhorro.Location = New System.Drawing.Point(96, 32)
        Me.txtTipoAhorro.MaxLength = 110
        Me.txtTipoAhorro.Name = "txtTipoAhorro"
        Me.txtTipoAhorro.ReadOnly = True
        Me.txtTipoAhorro.Size = New System.Drawing.Size(280, 20)
        Me.txtTipoAhorro.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Tipo de Ahorro:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Del:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(176, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "al:"
        '
        'dtpFecha2
        '
        Me.dtpFecha2.CustomFormat = ""
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha2.Location = New System.Drawing.Point(208, 64)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha2.TabIndex = 3
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(64, 64)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(334, 173)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 1025
        Me.btnProcesar1.Text = "Mostrar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmMsReporteII
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(439, 254)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsReporteII"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Propiedades"

    Public Property Titulo() As String
        Get
            Return vTitulo
        End Get
        Set(ByVal Value As String)
            vTitulo = Value
        End Set
    End Property

    Public Property NumReporte() As String
        Get
            Return vNumReporte
        End Get
        Set(ByVal Value As String)
            vNumReporte = Value
        End Set
    End Property

#End Region

    Private Sub frmMsReporteII_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
        Me.dtpFecha2.Value = Now
        Me.Text = Me.Titulo
        If Me.vNumReporte = "2" Then
            Me.dtpFecha2.Visible = False
            Me.Label1.Visible = False
            Me.Label2.Text = "Fecha:"
        End If
    End Sub


    Private Sub txtCodTipoAhorro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoAhorro.DoubleClick
        Dim ofrm As New frmAGenerico
        Try

            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet
            ds = oAhorro.ConsultarTipoAhorro("*", "left(CodTipoAhorro,1)<>'1'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
            ofrm.Text = "Buscar Tipos de Ahorro"
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()

            If ofrm.Resultado.Trim = "" Then Exit Sub

            txtCodTipoAhorro.Text = ofrm.Resultado.Trim
            txtTipoAhorro.Text = ofrm.Resultado2.Trim

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Tipos de Ahorro - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Try
            Select Case vNumReporte
                Case "0" 'REPORTE DE CANCELACIONES DE CUENTAS POR TIPO DE TRANSACCIÓN
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.RepCancelacion_Transf(Me.dtpFecha.Value, Me.dtpFecha2.Value, Me.txtCodTipoAhorro.Text.Trim, Me.chkTodos.Checked, "0", sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 114, 0)
                    ofrm.ShowDialog()
                Case "1" 'REPORTE DE CANCELACIONES DE CUENTAS 
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    ds = oAhorro.RepCancelacion_Transf(Me.dtpFecha.Value, Me.dtpFecha2.Value, Me.txtCodTipoAhorro.Text.Trim, Me.chkTodos.Checked, "1", sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 125, 0)
                    ofrm.ShowDialog()
                Case "2" 'REPORTE DE CUENTAS DE AHORRO NO PROVISIONADAS
                    Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New DataSet
                    If Me.chkTodos.Checked = True Then
                        ds = oAhorro.Provisiones_Ahorros(Me.dtpFecha.Value, Now, 0, True, False, Me.txtCodTipoAhorro.Text.Trim, sUsuario, sPassword, sSucursal)
                    Else
                        'Dim vTipo As Ahorros.clsAhorro.TiposAhorroReporteMovimientos
                        Dim vTipo As sifLib.Ahorro.clsAhorros.TiposAhorroReporteMovimientos
                        Select Case Mid(Me.txtCodTipoAhorro.Text.Trim, 1, 1)
                            Case "1"
                                'vTipo = Ahorros.clsAhorro.TiposAhorroReporteMovimientos.Aportacion
                                vTipo = sifLib.Ahorro.clsAhorros.TiposAhorroReporteMovimientos.Aportacion
                            Case "2"
                                'vTipo = Ahorros.clsAhorro.TiposAhorroReporteMovimientos.DPF
                                vTipo = sifLib.Ahorro.clsAhorros.TiposAhorroReporteMovimientos.DPF
                            Case "3"
                                'vTipo = Ahorros.clsAhorro.TiposAhorroReporteMovimientos.Vista
                                vTipo = sifLib.Ahorro.clsAhorros.TiposAhorroReporteMovimientos.Vista
                            Case "4"
                                'vTipo = Ahorros.clsAhorro.TiposAhorroReporteMovimientos.Restringido
                                vTipo = sifLib.Ahorro.clsAhorros.TiposAhorroReporteMovimientos.Restringido
                            Case "5"
                                'vTipo = Ahorros.clsAhorro.TiposAhorroReporteMovimientos.Programado
                                vTipo = sifLib.Ahorro.clsAhorros.TiposAhorroReporteMovimientos.Programado
                        End Select
                        ds = oAhorro.Provisiones_Ahorros(Me.dtpFecha.Value, Now, vTipo, False, False, Me.txtCodTipoAhorro.Text.Trim, sUsuario, sPassword, sSucursal)
                    End If
                    Dim ofrm As New frmVisor(ds, 169, 0)
                    ofrm.ShowDialog()
            End Select
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodTipoAhorro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodTipoAhorro.KeyPress
        Try
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet, dr As DataRow
            ds = oAhorro.ConsultarTipoAhorro("*", "left(CodTipoAhorro,1)<>'1' and CodTipoAhorro='" & Me.txtCodTipoAhorro.Text.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                txtCodTipoAhorro.Text = dr("CodTipoAhorro")
                txtTipoAhorro.Text = dr("Descripcion")
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Tipos de Ahorro - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class