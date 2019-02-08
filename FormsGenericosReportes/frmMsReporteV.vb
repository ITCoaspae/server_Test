Public Class frmMsReporteV
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
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCodTipoGarantia As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoGarantia As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCodTipoGarantia = New System.Windows.Forms.TextBox()
        Me.txtTipoGarantia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtCodTipoGarantia)
        Me.GroupBox1.Controls.Add(Me.txtTipoGarantia)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(482, 75)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtCodTipoGarantia
        '
        Me.txtCodTipoGarantia.AcceptsReturn = True
        Me.txtCodTipoGarantia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoGarantia.Location = New System.Drawing.Point(105, 20)
        Me.txtCodTipoGarantia.MaxLength = 10
        Me.txtCodTipoGarantia.Name = "txtCodTipoGarantia"
        Me.txtCodTipoGarantia.Size = New System.Drawing.Size(45, 20)
        Me.txtCodTipoGarantia.TabIndex = 0
        '
        'txtTipoGarantia
        '
        Me.txtTipoGarantia.BackColor = System.Drawing.Color.White
        Me.txtTipoGarantia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoGarantia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoGarantia.Location = New System.Drawing.Point(156, 20)
        Me.txtTipoGarantia.MaxLength = 110
        Me.txtTipoGarantia.Name = "txtTipoGarantia"
        Me.txtTipoGarantia.ReadOnly = True
        Me.txtTipoGarantia.Size = New System.Drawing.Size(320, 20)
        Me.txtTipoGarantia.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 133
        Me.Label6.Text = "Tipo de Garantía:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(105, 46)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(430, 116)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 1028
        Me.btnProcesar1.Text = "Procesar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmMsReporteV
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(526, 211)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsReporteV"
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
        Me.Text = Me.Titulo
    End Sub

    Private Sub txtCodTipoGarantia_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoGarantia.DoubleClick
        Dim ofrm As New frmAGenerico
        Try
            Dim oCred As New wrCredito.wsLibCred, ds As New Data.DataSet
            ds = oCred.ConsultarTipGarant("*", "", "CodTipoGarantias", sUsuario, sPassword, sSucursal)
            ofrm.Text = "Buscar Tipos de Garantía"
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()

            If ofrm.Resultado.Trim = "" Then Exit Sub

            txtCodTipoGarantia.Text = ofrm.Resultado.Trim
            txtTipoGarantia.Text = ofrm.Resultado2.Trim

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Tipos de Garantía - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Try
            Select Case vNumReporte
                Case "0" 'REPORTE DE CRÉDITOS CON GARANTÍAS
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    ds = oPrest.Reportes_PrestamosAgrupados(Me.dtpFecha.Value, wrPrestamo.TipoReportesMora.Garantia, Me.txtCodTipoGarantia.Text.Trim, sUsuario, sPassword, sSucursal)
                    Dim ofrm As New frmVisor(ds, 135, 0)
                    ofrm.ShowDialog()
            End Select
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtCodTipoGarantia_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodTipoGarantia.Validating
        Try
            Dim oCred As New wrCredito.wsLibCred, ds As New Data.DataSet, dr As DataRow
            ds = oCred.ConsultarTipGarant("*", "CodTipogarantias='" & Me.txtCodTipoGarantia.Text.Trim & "'", "CodTipoGarantias", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                txtCodTipoGarantia.Text = dr("CodTipoGarantias")
                txtTipoGarantia.Text = dr("Descripcion")
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Tipos de Garantía - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class