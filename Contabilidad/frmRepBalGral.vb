Public Class frmRepBalGral
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
    Friend WithEvents lblMes As System.Windows.Forms.Label
    Friend WithEvents cbCC As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    Dim Contabilidad As New wrConta.wsLibContab

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
    Friend WithEvents dtpMes As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpMes = New System.Windows.Forms.DateTimePicker()
        Me.lblCentroCosto = New System.Windows.Forms.Label()
        Me.lblMes = New System.Windows.Forms.Label()
        Me.cbCC = New MetroFramework.Controls.MetroComboBox()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'dtpMes
        '
        Me.dtpMes.CustomFormat = "MMMM/yyyy"
        Me.dtpMes.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpMes.Location = New System.Drawing.Point(85, 88)
        Me.dtpMes.Name = "dtpMes"
        Me.dtpMes.Size = New System.Drawing.Size(133, 20)
        Me.dtpMes.TabIndex = 21
        '
        'lblCentroCosto
        '
        Me.lblCentroCosto.AutoSize = True
        Me.lblCentroCosto.Location = New System.Drawing.Point(23, 60)
        Me.lblCentroCosto.Name = "lblCentroCosto"
        Me.lblCentroCosto.Size = New System.Drawing.Size(56, 26)
        Me.lblCentroCosto.TabIndex = 29
        Me.lblCentroCosto.Text = "Centro de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Costos:"
        '
        'lblMes
        '
        Me.lblMes.AutoSize = True
        Me.lblMes.Location = New System.Drawing.Point(23, 94)
        Me.lblMes.Name = "lblMes"
        Me.lblMes.Size = New System.Drawing.Size(30, 13)
        Me.lblMes.TabIndex = 31
        Me.lblMes.Text = "Mes:"
        '
        'cbCC
        '
        Me.cbCC.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbCC.FormattingEnabled = True
        Me.cbCC.ItemHeight = 19
        Me.cbCC.Location = New System.Drawing.Point(85, 57)
        Me.cbCC.Name = "cbCC"
        Me.cbCC.Size = New System.Drawing.Size(308, 25)
        Me.cbCC.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbCC.TabIndex = 32
        Me.cbCC.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cbCC.UseSelectable = True
        Me.cbCC.UseStyleColors = True
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(224, 85)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(169, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 33
        Me.btnProcesar1.Text = "Procesar Reporte"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmRepBalGral
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(414, 128)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.cbCC)
        Me.Controls.Add(Me.lblMes)
        Me.Controls.Add(Me.dtpMes)
        Me.Controls.Add(Me.lblCentroCosto)
        Me.MaximumSize = New System.Drawing.Size(414, 128)
        Me.MinimumSize = New System.Drawing.Size(414, 128)
        Me.Name = "frmRepBalGral"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reporte Balance General"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Sub llenarCbCentroCostos()
        Dim dts As New DataSet
        dts = Contabilidad.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "Cod_CCosto,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbCC.DataSource = dts.Tables(0)
            End If
        End If

    End Sub
    Private Sub frmRepBalGral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbCC.DisplayMember = "Descripcion"
        Me.cbCC.ValueMember = "Cod_Ccosto"
        llenarCbCentroCostos()
    End Sub

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Dim oTabla As DataTable, vColumn As DataColumn, vRow As DataRow, oApp As New wrAdmin.wsLibAdmin
        Dim oRep As wrConta.wsLibContab = New wrConta.wsLibContab, ds As New Data.DataSet

        Try

            'ds = oRep.GeneraBalance(Month(Me.dtpMes.Value), 1, 2, 1, Me.dtpMes.Value.Year, sUsuario, sPassword, sSucursal)
            '=======================================================================
            'Se modifica para permitir generar balance general en cualquier periodo.
            'Javier Martinez
            '29/01/2012
            Dim DtsSaldos As New DataSet
            DtsSaldos = Contabilidad.ConsultaSaldos("Saldos.Idcuenta", "Annio = '" & Me.dtpMes.Value.Year & "'", " ", sUsuario, sPassword, sSucursal)
            If DtsSaldos.Tables(0).Rows.Count > 0 Then
                ds = oRep.GeneraBalance(Month(Me.dtpMes.Value), 2, 3, 2, Me.dtpMes.Value.Year, sUsuario, sPassword, sSucursal, Me.cbCC.SelectedValue.ToString.Trim)
            Else
                ds = oRep.GeneraBalance_Hist(Month(Me.dtpMes.Value), Me.dtpMes.Value.Year, 1, 2, 1, sUsuario, sPassword, sSucursal)
            End If
            'If Me.dtpMes.Value.Year = oApp.Fecha.Year Then
            '    ds = oRep.GeneraBalance(Month(Me.dtpMes.Value), 1, 2, 1, Me.dtpMes.Value.Year, sUsuario, sPassword, sSucursal)
            'Else
            '    ds = oRep.GeneraBalance_Hist(Month(Me.dtpMes.Value), Me.dtpMes.Value.Year, 1, 2, 1, sUsuario, sPassword, sSucursal)
            'End If
            '=======================================================================

            oTabla = New Data.DataTable("Mes")
            vColumn = New DataColumn("NombreMes", Type.GetType("System.String"))
            oTabla.Columns.Add(vColumn)
            vRow = oTabla.NewRow()
            vRow("NombreMes") = "BALANCE GENERAL AL " & DateTime.DaysInMonth(Me.dtpMes.Value.Year, Me.dtpMes.Value.Month) & " DE " & UCase(MonthName(Me.dtpMes.Value.Month)) & " DE " & Me.dtpMes.Value.Year
            oTabla.Rows.Add(vRow)
            ds.Tables.Add(oTabla)
            Dim ofrm As New frmVisor(ds, 2, 0)
            'ofrm.MdiParent = ofrmMain
            ofrm.Show(Me)

            'Me.Cursor = Cursors.Default
            'Me.Dispose()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("No hay datos disponibles.", "Por favor comunicarse con el administrador del sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
