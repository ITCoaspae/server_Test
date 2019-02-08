Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Reporting
Imports CrystalDecisions.ReportSource
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Net
Public Class frmMPLPlanilla
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents lblHASTA As System.Windows.Forms.Label
    Friend WithEvents lblDESDE As System.Windows.Forms.Label
    Friend WithEvents dtpFECHAFIN As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFECHAINI As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgPlPlanillas As System.Windows.Forms.DataGridView
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCONSUL_DET As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Private oPlan As wrPlanilla.wsLibPlanilla = New wrPlanilla.wsLibPlanilla
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents sdlgFile As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.lblHASTA = New System.Windows.Forms.Label()
        Me.lblDESDE = New System.Windows.Forms.Label()
        Me.dtpFECHAFIN = New System.Windows.Forms.DateTimePicker()
        Me.dtpFECHAINI = New System.Windows.Forms.DateTimePicker()
        Me.sdlgFile = New System.Windows.Forms.SaveFileDialog()
        Me.dgPlPlanillas = New System.Windows.Forms.DataGridView()
        Me.btnCONSUL_DET = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgPlPlanillas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.lblHASTA)
        Me.GroupBox2.Controls.Add(Me.lblDESDE)
        Me.GroupBox2.Controls.Add(Me.dtpFECHAFIN)
        Me.GroupBox2.Controls.Add(Me.dtpFECHAINI)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(412, 70)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar datos de Planilla:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(328, 26)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 112
        Me.btnMostrar1.Text = "Buscar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'lblHASTA
        '
        Me.lblHASTA.AutoSize = True
        Me.lblHASTA.Location = New System.Drawing.Point(171, 31)
        Me.lblHASTA.Name = "lblHASTA"
        Me.lblHASTA.Size = New System.Drawing.Size(35, 13)
        Me.lblHASTA.TabIndex = 17
        Me.lblHASTA.Text = "Hasta"
        '
        'lblDESDE
        '
        Me.lblDESDE.AutoSize = True
        Me.lblDESDE.Location = New System.Drawing.Point(13, 31)
        Me.lblDESDE.Name = "lblDESDE"
        Me.lblDESDE.Size = New System.Drawing.Size(41, 13)
        Me.lblDESDE.TabIndex = 16
        Me.lblDESDE.Text = "Desde:"
        '
        'dtpFECHAFIN
        '
        Me.dtpFECHAFIN.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFECHAFIN.Location = New System.Drawing.Point(212, 31)
        Me.dtpFECHAFIN.Name = "dtpFECHAFIN"
        Me.dtpFECHAFIN.Size = New System.Drawing.Size(105, 20)
        Me.dtpFECHAFIN.TabIndex = 15
        '
        'dtpFECHAINI
        '
        Me.dtpFECHAINI.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFECHAINI.Location = New System.Drawing.Point(60, 31)
        Me.dtpFECHAINI.Name = "dtpFECHAINI"
        Me.dtpFECHAINI.Size = New System.Drawing.Size(105, 20)
        Me.dtpFECHAINI.TabIndex = 14
        '
        'sdlgFile
        '
        Me.sdlgFile.DefaultExt = "txt"
        Me.sdlgFile.Filter = "Archivos de texto|*.txt"
        Me.sdlgFile.InitialDirectory = "c:\"
        '
        'dgPlPlanillas
        '
        Me.dgPlPlanillas.AllowUserToAddRows = False
        Me.dgPlPlanillas.AllowUserToDeleteRows = False
        Me.dgPlPlanillas.AllowUserToOrderColumns = True
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.dgPlPlanillas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgPlPlanillas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgPlPlanillas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgPlPlanillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgPlPlanillas.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgPlPlanillas.Location = New System.Drawing.Point(23, 173)
        Me.dgPlPlanillas.Name = "dgPlPlanillas"
        Me.dgPlPlanillas.ReadOnly = True
        Me.dgPlPlanillas.Size = New System.Drawing.Size(587, 266)
        Me.dgPlPlanillas.TabIndex = 41
        '
        'btnCONSUL_DET
        '
        Me.btnCONSUL_DET.Enabled = False
        Me.btnCONSUL_DET.Location = New System.Drawing.Point(104, 139)
        Me.btnCONSUL_DET.Name = "btnCONSUL_DET"
        Me.btnCONSUL_DET.Size = New System.Drawing.Size(75, 28)
        Me.btnCONSUL_DET.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCONSUL_DET.TabIndex = 131
        Me.btnCONSUL_DET.Text = "Consultar"
        Me.btnCONSUL_DET.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCONSUL_DET.UseSelectable = True
        Me.btnCONSUL_DET.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 139)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(103, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 130
        Me.btnDel.Text = "Enviar Boletas"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(441, 94)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(78, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 129
        Me.btnMod.Text = "Detalle de Ingresos Planilla"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        Me.btnMod.Visible = False
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 139)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 128
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(441, 63)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(78, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 132
        Me.MetroButton1.Text = "Detalle Descuentos Planilla"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        Me.MetroButton1.Visible = False
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(294, 139)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(119, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 133
        Me.MetroButton2.Text = "Aplicar Desembolso"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'frmMPLPlanilla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(633, 489)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnCONSUL_DET)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgPlPlanillas)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMPLPlanilla"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento - Planillas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgPlPlanillas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Funciones Creadas por Javier Martinez"
    Protected Sub HeaderDg()
        Me.dgPlPlanillas.Columns("CodPlanilla").HeaderText = "Código de Planilla"
        Me.dgPlPlanillas.Columns("TipoPlanilla").HeaderText = "Tipo de Planilla"
        Me.dgPlPlanillas.Columns("FechaInicio").HeaderText = "Fecha Inicio"
        Me.dgPlPlanillas.Columns("FechaFin").HeaderText = "Fecha Fin"
        Me.dgPlPlanillas.Columns("CodPlanilla").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlPlanillas.Columns("TipoPlanilla").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlPlanillas.Columns("FechaInicio").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlPlanillas.Columns("FechaFin").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.dgPlPlanillas.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.dgPlPlanillas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

    End Sub

    Protected Sub LlenarDg(ByVal Opcion As Integer, ByVal FechaInicio As DateTime, ByVal FechaFin As DateTime)
        Dim Dts As New DataSet
        Try
            Dts = oPlan.Consultar_PlPlanillas(Opcion, FechaInicio, FechaFin)
            Me.dgPlPlanillas.DataSource = Dts.Tables(0)
            HeaderDg()
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub
#End Region
    Public Sub ActualizaGrid(ByVal FILTRO As String)

        Dim ds As New Data.DataSet
        'Try
        '    ds = oPlan.ConsultarPLPlanilla("*", FILTRO, "CodPlanilla", True, sUsuario, sPassword, sSucursal)
        '    fg.DataSource = ds.Tables(0)
        '    Encabezado()
        'Catch ex As Exception
        '    MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
        'End Try
    End Sub

    Private Sub frmMPLPlanilla_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LlenarDg(1, Me.dtpFECHAINI.Value, Me.dtpFECHAFIN.Value) '1 muestra todas las planillas 
        Me.btnCONSUL_DET.Enabled = True
    End Sub

    Private Sub txtCodigoArea_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnMostrar1_Click(sender, e)
        End If
    End Sub

    Private Sub fg_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.btnCONSUL_DET.Enabled = True
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try
            Dim Filtro As Integer
            Filtro = 2 'Filtra por un rango de fechas
            LlenarDg(2, Format(Me.dtpFECHAINI.Value, "SHORT DATE"), Format(Me.dtpFECHAFIN.Value, "SHORT DATE"))
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim ofrm As New frmMSPLPrePlanilla
            ofrm.Show()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnCONSUL_DET.Click
        Try
            If Me.dgPlPlanillas.CurrentRow.Index > -1 Then
                Dim CodPlanilla As Integer
                Dim TipoPlanilla As Integer
                Dim Form As New wfRPT_PLANILLA
                CodPlanilla = Me.dgPlPlanillas.Item("CODPLANILLA", Me.dgPlPlanillas.CurrentRow.Index).Value
                TipoPlanilla = Me.dgPlPlanillas.Item("CodTipoPlanilla", Me.dgPlPlanillas.CurrentRow.Index).Value
                Form.txtCodPlanilla.Text = CodPlanilla
                Form.dtpFechaInicio.Value = Me.dgPlPlanillas.Item("FECHAINICIO", Me.dgPlPlanillas.CurrentRow.Index).Value
                Form.dtpFechaFin.Value = Me.dgPlPlanillas.Item("FECHAFIN", Me.dgPlPlanillas.CurrentRow.Index).Value
                Form.rbMostrarTodos.Checked = True
                Form.txtTipoPlanilla.Text = TipoPlanilla
                Form.LlenarPlanilla(CodPlanilla, 1, "", "")
                Form.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            Dim ofrm As New frmVisorRS
            OpcionRS = 2
            ofrm.ShowDialog()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim ofrm As New frmVisorRS
            OpcionRS = 1
            ofrm.ShowDialog()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If Me.dgPlPlanillas.CurrentRow.Index > -1 Then
                'If MsgBox("¿Desea realizar esta acción?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Módulo - Planillas") = 6 Then
                Dim CodPlanilla As Integer
                Dim frmPb As New frmMsProgressBar
                Dim FechaInicio, FechaFin As DateTime
                CodPlanilla = Me.dgPlPlanillas.Item("CODPLANILLA", Me.dgPlPlanillas.CurrentRow.Index).Value
                FechaInicio = Me.dgPlPlanillas.Item("FECHAINICIO", Me.dgPlPlanillas.CurrentRow.Index).Value
                FechaFin = Me.dgPlPlanillas.Item("FECHAFIN", Me.dgPlPlanillas.CurrentRow.Index).Value
                frmPb.codplanilla = CodPlanilla
                frmPb.FechaInicio = FechaInicio
                frmPb.FechaFin = FechaFin
                frmPb.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub MetroButton2_Click_1(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            Dim resultado As String
            If Me.dgPlPlanillas.CurrentRow.Index > -1 Then
                If MsgBox("Desea realizar este Proceso?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    Dim CodPlanilla, TipoPlanilla As Integer
                    Dim FechaInicio, FechaFin As DateTime

                    Dim frmPb As New frmMsProgressBar
                    CodPlanilla = Me.dgPlPlanillas.Item("CODPLANILLA", Me.dgPlPlanillas.CurrentRow.Index).Value
                    FechaInicio = Me.dgPlPlanillas.Item("FECHAINICIO", Me.dgPlPlanillas.CurrentRow.Index).Value
                    FechaFin = Me.dgPlPlanillas.Item("FECHAFIN", Me.dgPlPlanillas.CurrentRow.Index).Value
                    TipoPlanilla = Me.dgPlPlanillas.Item("CodTipoPlanilla", Me.dgPlPlanillas.CurrentRow.Index).Value
                    If oPlan.VerificarDesembolso(CodPlanilla) > 0 Then
                        MsgBox("El Desemboslo de esta planilla ya se realizo, Favor Verificar", MsgBoxStyle.Exclamation)
                        Exit Sub
                    Else
                        resultado = oPlan.ProcesarDesembolso(TipoPlanilla, FechaInicio, FechaFin, sUsuario)
                        MsgBox(resultado, MsgBoxStyle.Information)
                    End If
                End If
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class