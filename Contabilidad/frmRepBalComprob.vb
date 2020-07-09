Public Class frmRepBalComprob
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
    Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCC As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblCentroCosto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCC = New MetroFramework.Controls.MetroComboBox()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "MMMM"
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(86, 92)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(134, 22)
        Me.dtpFecha.TabIndex = 32
        '
        'lblCentroCosto
        '
        Me.lblCentroCosto.AutoSize = True
        Me.lblCentroCosto.Location = New System.Drawing.Point(24, 60)
        Me.lblCentroCosto.Name = "lblCentroCosto"
        Me.lblCentroCosto.Size = New System.Drawing.Size(56, 26)
        Me.lblCentroCosto.TabIndex = 35
        Me.lblCentroCosto.Text = "Centro de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Costos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Mes:"
        '
        'cbCC
        '
        Me.cbCC.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbCC.FormattingEnabled = True
        Me.cbCC.ItemHeight = 19
        Me.cbCC.Location = New System.Drawing.Point(86, 61)
        Me.cbCC.Name = "cbCC"
        Me.cbCC.Size = New System.Drawing.Size(290, 25)
        Me.cbCC.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbCC.TabIndex = 38
        Me.cbCC.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cbCC.UseSelectable = True
        Me.cbCC.UseStyleColors = True
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(226, 92)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(150, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 39
        Me.btnProcesar1.Text = "Procesar Reporte"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'frmRepBalComprob
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(395, 135)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.cbCC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblCentroCosto)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(395, 135)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(395, 135)
        Me.Name = "frmRepBalComprob"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Balance de Comprobación"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim contabilidad As New wrConta.wsLibContab
    Public Sub llenarCbCentroCostos()
        Dim dts As New DataSet
        dts = contabilidad.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "Cod_CCosto,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbCC.DataSource = dts.Tables(0)
            End If
        End If

    End Sub

    Private Sub frmRepBalComprob_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbCC.DisplayMember = "Descripcion"
        Me.cbCC.ValueMember = "Cod_Ccosto"
        llenarCbCentroCostos()
    End Sub


    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Dim ofrm As New frmVisorRep
        'ofrm.Reporte = Contabilidad.clsContab.ReportesContabilidad.BalanceComprobacion
        ofrm.Reporte = sifLib.Contabilidad.clsContabs.ReportesContabilidad.BalanceComprobacion
        ofrm.Mes = Me.dtpFecha.Value.Month()
        ofrm.centroCosto = Me.cbCC.SelectedValue
        ofrm.FechaIni = Me.dtpFecha.Value
        ' 
        ofrm.Show()

    End Sub
End Class
