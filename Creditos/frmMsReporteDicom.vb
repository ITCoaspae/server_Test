Public Class frmMsReporteDicom
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private vTitulo As String, vNumReporte As String
    Friend WithEvents btProcesar1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents C1fgrdPrestamos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodFuente As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsReporteDicom))
        Me.txtCodFuente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.C1fgrdPrestamos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btProcesar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.C1fgrdPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodFuente
        '
        Me.txtCodFuente.Location = New System.Drawing.Point(150, 99)
        Me.txtCodFuente.MaxLength = 25
        Me.txtCodFuente.Name = "txtCodFuente"
        Me.txtCodFuente.Size = New System.Drawing.Size(173, 22)
        Me.txtCodFuente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(28, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 18)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Código de fuente:"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(28, 69)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(115, 19)
        Me.lblFecha.TabIndex = 38
        Me.lblFecha.Text = "Saldos al día:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(150, 69)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(106, 23)
        Me.dtpFecha.TabIndex = 0
        '
        'C1fgrdPrestamos
        '
        Me.C1fgrdPrestamos.AllowEditing = False
        Me.C1fgrdPrestamos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fgrdPrestamos.AutoSearch = C1.Win.C1FlexGrid.AutoSearchEnum.FromTop
        Me.C1fgrdPrestamos.BackColor = System.Drawing.Color.White
        Me.C1fgrdPrestamos.ColumnInfo = "30,1,0,0,0,85,Columns:0{Width:21;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Caption:""CodPrestamo"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Caption:""Dui"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdPrestamos.Location = New System.Drawing.Point(281, 69)
        Me.C1fgrdPrestamos.Name = "C1fgrdPrestamos"
        Me.C1fgrdPrestamos.Rows.Count = 2
        Me.C1fgrdPrestamos.Rows.DefaultSize = 21
        Me.C1fgrdPrestamos.Size = New System.Drawing.Size(0, 0)
        Me.C1fgrdPrestamos.StyleInfo = resources.GetString("C1fgrdPrestamos.StyleInfo")
        Me.C1fgrdPrestamos.TabIndex = 8
        Me.C1fgrdPrestamos.Visible = False
        '
        'btProcesar1
        '
        Me.btProcesar1.Location = New System.Drawing.Point(233, 129)
        Me.btProcesar1.Name = "btProcesar1"
        Me.btProcesar1.Size = New System.Drawing.Size(90, 33)
        Me.btProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btProcesar1.TabIndex = 166
        Me.btProcesar1.Text = "Procesar"
        Me.btProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btProcesar1.UseSelectable = True
        Me.btProcesar1.UseStyleColors = True
        '
        'frmMsReporteDicom
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(352, 188)
        Me.Controls.Add(Me.txtCodFuente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btProcesar1)
        Me.Controls.Add(Me.C1fgrdPrestamos)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(352, 188)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(352, 188)
        Me.Name = "frmMsReporteDicom"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reporte DICOM"
        CType(Me.C1fgrdPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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

    Private Sub btProcesar1_Click(sender As Object, e As EventArgs) Handles btProcesar1.Click
        Try
            Select Case vNumReporte
                Case 0 'Exportación datos DICOM
                    Dim oPrest As New wrPrestamo.wsLibPrest, ds As New DataSet
                    oPrest.Timeout = -1
                    ds = oPrest.ExportacionDatos_Dicom(Me.dtpFecha.Value, Me.txtCodFuente.Text.Trim, sUsuario, sPassword, sSucursal)
                    Dim openDlg As SaveFileDialog = New SaveFileDialog
                    Dim Resultado As DialogResult
                    Try
                        openDlg.Filter = "Archivos Excel (*.csv)|*.csv"
                        openDlg.FileName = "Datos_DICOM"
                        Resultado = openDlg.ShowDialog()
                        If Resultado = DialogResult.OK Then
                            If openDlg.FileName.Trim = "" Then
                                MessageBox.Show("Debe ingresar un nombre para el Nuevo Archivo.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            Else
                                Me.C1fgrdPrestamos.DataSource = ds.Tables(0)
                                Me.C1fgrdPrestamos.SaveGrid(openDlg.FileName, C1.Win.C1FlexGrid.FileFormatEnum.TextComma, True)
                                MessageBox.Show("El archivo ha sido generado.", "Exportación datos Dicom", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Sub frmMsReporteIII_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
        Me.Text = Me.Titulo
    End Sub


End Class
