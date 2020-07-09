Public Class frmMsExportar
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
    Friend WithEvents C1fgrdPrestamos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rbActivos As System.Windows.Forms.RadioButton
    Friend WithEvents rbRetirados As System.Windows.Forms.RadioButton
    Friend WithEvents rbAmbos As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsExportar))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbAmbos = New System.Windows.Forms.RadioButton()
        Me.rbRetirados = New System.Windows.Forms.RadioButton()
        Me.rbActivos = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.C1fgrdPrestamos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1fgrdPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rbAmbos)
        Me.GroupBox1.Controls.Add(Me.rbRetirados)
        Me.GroupBox1.Controls.Add(Me.rbActivos)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFecha2)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(368, 157)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(19, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(336, 19)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Seleccione una opción para filtrar la exportación:"
        '
        'rbAmbos
        '
        Me.rbAmbos.Location = New System.Drawing.Point(250, 111)
        Me.rbAmbos.Name = "rbAmbos"
        Me.rbAmbos.Size = New System.Drawing.Size(96, 18)
        Me.rbAmbos.TabIndex = 4
        Me.rbAmbos.Text = "Am&bos"
        '
        'rbRetirados
        '
        Me.rbRetirados.Location = New System.Drawing.Point(134, 111)
        Me.rbRetirados.Name = "rbRetirados"
        Me.rbRetirados.Size = New System.Drawing.Size(96, 18)
        Me.rbRetirados.TabIndex = 3
        Me.rbRetirados.Text = "&Retirados"
        '
        'rbActivos
        '
        Me.rbActivos.Checked = True
        Me.rbActivos.Location = New System.Drawing.Point(19, 111)
        Me.rbActivos.Name = "rbActivos"
        Me.rbActivos.Size = New System.Drawing.Size(96, 18)
        Me.rbActivos.TabIndex = 2
        Me.rbActivos.TabStop = True
        Me.rbActivos.Text = "&Activos"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(19, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(336, 19)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Digite los rangos para fecha de Ingreso del Asociado:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(19, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 19)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Del:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(192, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "al:"
        '
        'dtpFecha2
        '
        Me.dtpFecha2.CustomFormat = ""
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha2.Location = New System.Drawing.Point(250, 46)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(105, 23)
        Me.dtpFecha2.TabIndex = 1
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(58, 46)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(105, 23)
        Me.dtpFecha.TabIndex = 0
        '
        'C1fgrdPrestamos
        '
        Me.C1fgrdPrestamos.AllowEditing = False
        Me.C1fgrdPrestamos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.C1fgrdPrestamos.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.C1fgrdPrestamos.BackColor = System.Drawing.Color.White
        Me.C1fgrdPrestamos.ColumnInfo = "30,1,0,0,0,85,Columns:0{Width:21;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Caption:""CodPrestamo"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Caption:""Dui"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdPrestamos.Location = New System.Drawing.Point(-71, 146)
        Me.C1fgrdPrestamos.Name = "C1fgrdPrestamos"
        Me.C1fgrdPrestamos.Rows.Count = 2
        Me.C1fgrdPrestamos.Rows.DefaultSize = 21
        Me.C1fgrdPrestamos.Size = New System.Drawing.Size(38, 10)
        Me.C1fgrdPrestamos.StyleInfo = resources.GetString("C1fgrdPrestamos.StyleInfo")
        Me.C1fgrdPrestamos.TabIndex = 7
        Me.C1fgrdPrestamos.Visible = False
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(268, 237)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(128, 32)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 43
        Me.btnProcesar1.Text = "&Exportar datos"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmMsExportar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(438, 288)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.C1fgrdPrestamos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsExportar"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.C1fgrdPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Try
            Select Case vNumReporte
                Case 0 'DATOS ASOCIADOS PARA EXPORTACIÓN
                    Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet, pFiltro As String
                    pFiltro = "d.FechaActa>='" & Me.dtpFecha.Value.ToShortDateString & "' and d.FechaActa<='" & Me.dtpFecha2.Value.ToShortDateString & "' and a.EstadoIngreso='2' and d.NoSocio<>''"
                    If Me.rbActivos.Checked = True Then
                        pFiltro = pFiltro & " and (EstadoAsociado='25' or EstadoAsociado='2')"
                    ElseIf Me.rbRetirados.Checked = True Then
                        pFiltro = pFiltro & " and (EstadoAsociado='1' or EstadoAsociado='3' or EstadoAsociado='4' or EstadoAsociado='5')"
                    End If
                    ds = oAsoc.ExportarDatosAsociado("a.Dui,a.NoSocio as No_Asociado,a.Nombres + ' ' + a.Apellido1 + ' ' + a.Apellido2 + ' ' + a.ApellidoCas as Nombres,a.Fecha_Nac,a.Direccion,a.TelCasa,a.Celular,a.Email,a.LugarTrabajo,a.DireccionTrabajo,a.TelOficina,a.Cargo,a.Salario,a.EstadoCivil,a.NombreConyugue,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as Ejecutivo_Mercadeo", pFiltro, "a.Apellido1", sUsuario, sPassword, sSucursal)
                    Dim openDlg As SaveFileDialog = New SaveFileDialog
                    Dim Resultado As DialogResult
                    Try
                        openDlg.Filter = "Archivos Excel (*.csv)|*.csv"
                        openDlg.FileName = "Datos_Asociados"
                        Resultado = openDlg.ShowDialog()
                        If Resultado = DialogResult.OK Then
                            If openDlg.FileName.Trim = "" Then
                                MessageBox.Show("Debe ingresar un nombre para el Nuevo Archivo.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            Else
                                Me.C1fgrdPrestamos.DataSource = ds.Tables(0)
                                Me.C1fgrdPrestamos.SaveGrid(openDlg.FileName, C1.Win.C1FlexGrid.FileFormatEnum.TextComma, True)
                                MessageBox.Show("El archivo ha sido generado.", "Exportación datos Asociados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                    End Try
            End Select
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

    Private Sub frmMsReporteI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
        Me.dtpFecha2.Value = Now
        Me.Text = Me.Titulo
    End Sub



End Class