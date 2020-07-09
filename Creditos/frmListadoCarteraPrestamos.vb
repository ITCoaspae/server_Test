Public Class frmListadoCarteraPrestamos
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim oItem As New wrCredito.wsLibCred
    Friend WithEvents btnExportar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    Private vNumReporte As String

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoCredito As System.Windows.Forms.ComboBox
    Friend WithEvents C1fgrdPrestamos As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListadoCarteraPrestamos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbTipoCredito = New System.Windows.Forms.ComboBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.C1fgrdPrestamos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnExportar1 = New MetroFramework.Controls.MetroButton()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.C1fgrdPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 55)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(451, 18)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(106, 22)
        Me.dtpFechaFin.TabIndex = 1
        Me.dtpFechaFin.Value = New Date(2017, 11, 14, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(365, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 27)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Fecha Fin:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(106, 18)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(105, 22)
        Me.dtpFechaInicio.TabIndex = 0
        Me.dtpFechaInicio.Value = New Date(2017, 11, 14, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha Inicio:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmbTipoCredito)
        Me.GroupBox2.Controls.Add(Me.chkTodos)
        Me.GroupBox2.Location = New System.Drawing.Point(28, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(670, 55)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(106, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 19)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Tipo Crédito"
        '
        'cmbTipoCredito
        '
        Me.cmbTipoCredito.Location = New System.Drawing.Point(202, 18)
        Me.cmbTipoCredito.Name = "cmbTipoCredito"
        Me.cmbTipoCredito.Size = New System.Drawing.Size(462, 24)
        Me.cmbTipoCredito.TabIndex = 1
        '
        'chkTodos
        '
        Me.chkTodos.Checked = True
        Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTodos.Location = New System.Drawing.Point(19, 21)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(144, 18)
        Me.chkTodos.TabIndex = 0
        Me.chkTodos.Text = "Todos"
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
        Me.C1fgrdPrestamos.Location = New System.Drawing.Point(58, 352)
        Me.C1fgrdPrestamos.Name = "C1fgrdPrestamos"
        Me.C1fgrdPrestamos.Rows.Count = 2
        Me.C1fgrdPrestamos.Rows.DefaultSize = 21
        Me.C1fgrdPrestamos.Size = New System.Drawing.Size(200, 19)
        Me.C1fgrdPrestamos.StyleInfo = resources.GetString("C1fgrdPrestamos.StyleInfo")
        Me.C1fgrdPrestamos.TabIndex = 9
        Me.C1fgrdPrestamos.Visible = False
        '
        'btnExportar1
        '
        Me.btnExportar1.Location = New System.Drawing.Point(125, 197)
        Me.btnExportar1.Name = "btnExportar1"
        Me.btnExportar1.Size = New System.Drawing.Size(90, 33)
        Me.btnExportar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnExportar1.TabIndex = 191
        Me.btnExportar1.Text = "Exportar"
        Me.btnExportar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnExportar1.UseSelectable = True
        Me.btnExportar1.UseStyleColors = True
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(28, 197)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(90, 33)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 190
        Me.btnProcesar1.Text = "Generar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmListadoCarteraPrestamos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(731, 269)
        Me.Controls.Add(Me.btnExportar1)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.C1fgrdPrestamos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmListadoCarteraPrestamos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reportes de Riesgo (Clasificación de cartera y reserva)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.C1fgrdPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property NumReporte() As String
        Get
            Return vNumReporte
        End Get
        Set(ByVal Value As String)
            vNumReporte = Value
        End Set
    End Property

    Private Sub frmListadoCarteraPrestamos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim ds1 As New DataSet, dr As DataRow
            Me.dtpFechaInicio.Value = Now
            Me.dtpFechaFin.Value = Now
            ds1 = oItem.ConsultarTipoCreditos("CodTipoCredito,Descripcion", "", "CodTipoCredito", sUsuario, sPassword, sSucursal)
            If ds1.Tables(0).Rows.Count > 0 Then
                For Each dr In ds1.Tables(0).Rows
                    Me.cmbTipoCredito.Items.Add(Trim(dr("CodTipoCredito")) & "-" & Trim(dr("Descripcion")))
                Next
            End If
            Me.cmbTipoCredito.SelectedIndex = 0
            If vNumReporte = "0" Then
                Me.btnExportar1.Visible = True
            Else
                Me.btnExportar1.Visible = False
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Dim ds As New Data.DataSet
        Dim vCodTipo As String
        Dim pAceptada As Boolean = False
        Try
            If vNumReporte = "0" Then
                If Me.chkTodos.Checked = True Then
                    ds = oItem.ListadoCarteraPrestamo(Me.dtpFechaInicio.Value.ToShortDateString, Me.dtpFechaFin.Value.ToShortDateString, sUsuario, sPassword, sSucursal, Me.chkTodos.Checked, "")
                Else
                    vCodTipo = Me.cmbTipoCredito.Text.Substring(0, Me.cmbTipoCredito.Text.IndexOf("-")).Trim
                    ds = oItem.ListadoCarteraPrestamo(Me.dtpFechaInicio.Value.ToShortDateString, Me.dtpFechaFin.Value.ToShortDateString, sUsuario, sPassword, sSucursal, False, vCodTipo)
                End If
                Dim ofrm As New frmVisor(ds, 33, 0)
                ofrm.ShowDialog()
            ElseIf vNumReporte = "1" Then 'REPORTE DE CRÉDITOS CANCELADOS EN EL MES
                Dim oPrest As New wrPrestamo.wsLibPrest
                ds = oPrest.RepCancelacion_Prestamos(Me.dtpFechaInicio.Value, Me.dtpFechaFin.Value, Me.cmbTipoCredito.Text.Substring(0, Me.cmbTipoCredito.Text.IndexOf("-")).Trim, Me.chkTodos.Checked, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 115, 0)
                ofrm.ShowDialog()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportar1_Click(sender As Object, e As EventArgs) Handles btnExportar1.Click
        Try
            Dim ds As New Data.DataSet, vCodTipo As String
            Select Case vNumReporte
                Case 0 'Categorización de Riesgo
                    If Me.chkTodos.Checked = True Then
                        ds = oItem.ListadoCarteraPrestamo(Me.dtpFechaInicio.Value.ToShortDateString, Me.dtpFechaFin.Value.ToShortDateString, sUsuario, sPassword, sSucursal, Me.chkTodos.Checked, "")
                    Else
                        vCodTipo = Me.cmbTipoCredito.Text.Substring(0, Me.cmbTipoCredito.Text.IndexOf("-")).Trim
                        ds = oItem.ListadoCarteraPrestamo(Me.dtpFechaInicio.Value.ToShortDateString, Me.dtpFechaFin.Value.ToShortDateString, sUsuario, sPassword, sSucursal, False, vCodTipo)
                    End If
                    Dim openDlg As SaveFileDialog = New SaveFileDialog
                    Dim Resultado As DialogResult
                    Try
                        openDlg.Filter = "Archivos Excel (*.csv)|*.csv"
                        openDlg.FileName = "Categ_Riesgo"
                        Resultado = openDlg.ShowDialog()
                        If Resultado = DialogResult.OK Then
                            If openDlg.FileName.Trim = "" Then
                                MessageBox.Show("Debe ingresar un nombre para el Nuevo Archivo.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            Else
                                Me.C1fgrdPrestamos.DataSource = ds.Tables(1)
                                Me.C1fgrdPrestamos.SaveGrid(openDlg.FileName, C1.Win.C1FlexGrid.FileFormatEnum.TextComma, True)
                                MessageBox.Show("El archivo ha sido generado.", "Exportación Categorización de Riesgo", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            End If
                        End If
                    Catch ex As Exception
                    End Try
            End Select
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class