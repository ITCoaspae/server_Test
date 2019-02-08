Public Class frmMovCaja
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim ds As New DataSet
    Private oCaja As New wrCaja.wsLibCaja, vOrigen As String, pSupervisor As String, pPassword As String, pCorrelativo As String
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents gbDatDoc As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpR1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboTipoMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents txtCaja As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents c1nUno As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nCinco As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nDiez As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nFraccion As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nVeinte As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nCincuenta As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nCien As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents gbDetalle As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMovCaja))
        Me.gbDatDoc = New System.Windows.Forms.GroupBox()
        Me.txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.txtCaja = New System.Windows.Forms.TextBox()
        Me.cboTipoMovimiento = New System.Windows.Forms.ComboBox()
        Me.dtpR1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbDetalle = New System.Windows.Forms.GroupBox()
        Me.c1nTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nCien = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nCincuenta = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nVeinte = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nFraccion = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nDiez = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nCinco = New C1.Win.C1Input.C1NumericEdit()
        Me.c1nUno = New C1.Win.C1Input.C1NumericEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.gbDatDoc.SuspendLayout()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDetalle.SuspendLayout()
        CType(Me.c1nTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCincuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nVeinte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nFraccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nDiez, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCinco, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nUno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDatDoc
        '
        Me.gbDatDoc.BackColor = System.Drawing.Color.White
        Me.gbDatDoc.Controls.Add(Me.txtMonto)
        Me.gbDatDoc.Controls.Add(Me.txtCaja)
        Me.gbDatDoc.Controls.Add(Me.cboTipoMovimiento)
        Me.gbDatDoc.Controls.Add(Me.dtpR1)
        Me.gbDatDoc.Controls.Add(Me.Label4)
        Me.gbDatDoc.Controls.Add(Me.Label14)
        Me.gbDatDoc.Controls.Add(Me.Label35)
        Me.gbDatDoc.Controls.Add(Me.Label2)
        resources.ApplyResources(Me.gbDatDoc, "gbDatDoc")
        Me.gbDatDoc.ForeColor = System.Drawing.Color.Navy
        Me.gbDatDoc.Name = "gbDatDoc"
        Me.gbDatDoc.TabStop = False
        '
        'txtMonto
        '
        resources.ApplyResources(Me.txtMonto, "txtMonto")
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.PostValidation.ErrorMessage = resources.GetString("txtMonto.PostValidation.ErrorMessage")
        Me.txtMonto.PostValidation.Inherit = CType(resources.GetObject("txtMonto.PostValidation.Inherit"), C1.Win.C1Input.PostValidationInheritFlags)
        Me.txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {CType(resources.GetObject("txtMonto.PostValidation.Intervals"), C1.Win.C1Input.ValueInterval)})
        Me.txtMonto.ShowDropDownButton = False
        Me.txtMonto.ShowUpDownButtons = False
        '
        'txtCaja
        '
        Me.txtCaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        resources.ApplyResources(Me.txtCaja, "txtCaja")
        Me.txtCaja.Name = "txtCaja"
        '
        'cboTipoMovimiento
        '
        Me.cboTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.cboTipoMovimiento, "cboTipoMovimiento")
        Me.cboTipoMovimiento.Items.AddRange(New Object() {resources.GetString("cboTipoMovimiento.Items"), resources.GetString("cboTipoMovimiento.Items1")})
        Me.cboTipoMovimiento.Name = "cboTipoMovimiento"
        '
        'dtpR1
        '
        resources.ApplyResources(Me.dtpR1, "dtpR1")
        Me.dtpR1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpR1.Name = "dtpR1"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Name = "Label4"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Name = "Label14"
        '
        'Label35
        '
        resources.ApplyResources(Me.Label35, "Label35")
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Name = "Label35"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'gbDetalle
        '
        Me.gbDetalle.BackColor = System.Drawing.Color.White
        Me.gbDetalle.Controls.Add(Me.c1nTotal)
        Me.gbDetalle.Controls.Add(Me.c1nCien)
        Me.gbDetalle.Controls.Add(Me.c1nCincuenta)
        Me.gbDetalle.Controls.Add(Me.c1nVeinte)
        Me.gbDetalle.Controls.Add(Me.c1nFraccion)
        Me.gbDetalle.Controls.Add(Me.c1nDiez)
        Me.gbDetalle.Controls.Add(Me.c1nCinco)
        Me.gbDetalle.Controls.Add(Me.c1nUno)
        Me.gbDetalle.Controls.Add(Me.Label11)
        Me.gbDetalle.Controls.Add(Me.Label10)
        Me.gbDetalle.Controls.Add(Me.Label9)
        Me.gbDetalle.Controls.Add(Me.Label8)
        Me.gbDetalle.Controls.Add(Me.Label7)
        Me.gbDetalle.Controls.Add(Me.Label6)
        Me.gbDetalle.Controls.Add(Me.Label5)
        Me.gbDetalle.Controls.Add(Me.Label3)
        Me.gbDetalle.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.gbDetalle, "gbDetalle")
        Me.gbDetalle.Name = "gbDetalle"
        Me.gbDetalle.TabStop = False
        '
        'c1nTotal
        '
        resources.ApplyResources(Me.c1nTotal, "c1nTotal")
        Me.c1nTotal.Name = "c1nTotal"
        Me.c1nTotal.PostValidation.ErrorMessage = resources.GetString("c1nTotal.PostValidation.ErrorMessage")
        Me.c1nTotal.PostValidation.Inherit = CType(resources.GetObject("c1nTotal.PostValidation.Inherit"), C1.Win.C1Input.PostValidationInheritFlags)
        Me.c1nTotal.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {CType(resources.GetObject("c1nTotal.PostValidation.Intervals"), C1.Win.C1Input.ValueInterval)})
        Me.c1nTotal.ReadOnly = True
        Me.c1nTotal.ShowDropDownButton = False
        Me.c1nTotal.ShowUpDownButtons = False
        '
        'c1nCien
        '
        resources.ApplyResources(Me.c1nCien, "c1nCien")
        Me.c1nCien.Name = "c1nCien"
        Me.c1nCien.PostValidation.ErrorMessage = resources.GetString("c1nCien.PostValidation.ErrorMessage")
        Me.c1nCien.PostValidation.Inherit = CType(resources.GetObject("c1nCien.PostValidation.Inherit"), C1.Win.C1Input.PostValidationInheritFlags)
        Me.c1nCien.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {CType(resources.GetObject("c1nCien.PostValidation.Intervals"), C1.Win.C1Input.ValueInterval)})
        Me.c1nCien.ShowDropDownButton = False
        Me.c1nCien.ShowUpDownButtons = False
        '
        'c1nCincuenta
        '
        resources.ApplyResources(Me.c1nCincuenta, "c1nCincuenta")
        Me.c1nCincuenta.Name = "c1nCincuenta"
        Me.c1nCincuenta.PostValidation.ErrorMessage = resources.GetString("c1nCincuenta.PostValidation.ErrorMessage")
        Me.c1nCincuenta.PostValidation.Inherit = CType(resources.GetObject("c1nCincuenta.PostValidation.Inherit"), C1.Win.C1Input.PostValidationInheritFlags)
        Me.c1nCincuenta.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {CType(resources.GetObject("c1nCincuenta.PostValidation.Intervals"), C1.Win.C1Input.ValueInterval)})
        Me.c1nCincuenta.ShowDropDownButton = False
        Me.c1nCincuenta.ShowUpDownButtons = False
        '
        'c1nVeinte
        '
        resources.ApplyResources(Me.c1nVeinte, "c1nVeinte")
        Me.c1nVeinte.Name = "c1nVeinte"
        Me.c1nVeinte.PostValidation.ErrorMessage = resources.GetString("c1nVeinte.PostValidation.ErrorMessage")
        Me.c1nVeinte.PostValidation.Inherit = CType(resources.GetObject("c1nVeinte.PostValidation.Inherit"), C1.Win.C1Input.PostValidationInheritFlags)
        Me.c1nVeinte.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {CType(resources.GetObject("c1nVeinte.PostValidation.Intervals"), C1.Win.C1Input.ValueInterval)})
        Me.c1nVeinte.ShowDropDownButton = False
        Me.c1nVeinte.ShowUpDownButtons = False
        '
        'c1nFraccion
        '
        resources.ApplyResources(Me.c1nFraccion, "c1nFraccion")
        Me.c1nFraccion.Name = "c1nFraccion"
        Me.c1nFraccion.PostValidation.ErrorMessage = resources.GetString("c1nFraccion.PostValidation.ErrorMessage")
        Me.c1nFraccion.PostValidation.Inherit = CType(resources.GetObject("c1nFraccion.PostValidation.Inherit"), C1.Win.C1Input.PostValidationInheritFlags)
        Me.c1nFraccion.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {CType(resources.GetObject("c1nFraccion.PostValidation.Intervals"), C1.Win.C1Input.ValueInterval)})
        Me.c1nFraccion.ShowDropDownButton = False
        Me.c1nFraccion.ShowUpDownButtons = False
        '
        'c1nDiez
        '
        resources.ApplyResources(Me.c1nDiez, "c1nDiez")
        Me.c1nDiez.Name = "c1nDiez"
        Me.c1nDiez.PostValidation.ErrorMessage = resources.GetString("c1nDiez.PostValidation.ErrorMessage")
        Me.c1nDiez.PostValidation.Inherit = CType(resources.GetObject("c1nDiez.PostValidation.Inherit"), C1.Win.C1Input.PostValidationInheritFlags)
        Me.c1nDiez.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {CType(resources.GetObject("c1nDiez.PostValidation.Intervals"), C1.Win.C1Input.ValueInterval)})
        Me.c1nDiez.ShowDropDownButton = False
        Me.c1nDiez.ShowUpDownButtons = False
        '
        'c1nCinco
        '
        resources.ApplyResources(Me.c1nCinco, "c1nCinco")
        Me.c1nCinco.Name = "c1nCinco"
        Me.c1nCinco.PostValidation.ErrorMessage = resources.GetString("c1nCinco.PostValidation.ErrorMessage")
        Me.c1nCinco.PostValidation.Inherit = CType(resources.GetObject("c1nCinco.PostValidation.Inherit"), C1.Win.C1Input.PostValidationInheritFlags)
        Me.c1nCinco.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {CType(resources.GetObject("c1nCinco.PostValidation.Intervals"), C1.Win.C1Input.ValueInterval)})
        Me.c1nCinco.ShowDropDownButton = False
        Me.c1nCinco.ShowUpDownButtons = False
        '
        'c1nUno
        '
        resources.ApplyResources(Me.c1nUno, "c1nUno")
        Me.c1nUno.Name = "c1nUno"
        Me.c1nUno.PostValidation.ErrorMessage = resources.GetString("c1nUno.PostValidation.ErrorMessage")
        Me.c1nUno.PostValidation.Inherit = CType(resources.GetObject("c1nUno.PostValidation.Inherit"), C1.Win.C1Input.PostValidationInheritFlags)
        Me.c1nUno.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {CType(resources.GetObject("c1nUno.PostValidation.Intervals"), C1.Win.C1Input.ValueInterval)})
        Me.c1nUno.ShowDropDownButton = False
        Me.c1nUno.ShowUpDownButtons = False
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'btnGuardar1
        '
        resources.ApplyResources(Me.btnGuardar1, "btnGuardar1")
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMovCaja
        '
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.gbDetalle)
        Me.Controls.Add(Me.gbDatDoc)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMovCaja"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.gbDatDoc.ResumeLayout(False)
        Me.gbDatDoc.PerformLayout()
        CType(Me.txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDetalle.ResumeLayout(False)
        Me.gbDetalle.PerformLayout()
        CType(Me.c1nTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCincuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nVeinte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nFraccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nDiez, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCinco, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nUno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property Correlativo() As String
        Get
            Return pCorrelativo
        End Get
        Set(ByVal Value As String)
            pCorrelativo = Value
        End Set
    End Property

    Public Property Supervisor() As String
        Get
            Return pSupervisor
        End Get
        Set(ByVal Value As String)
            pSupervisor = Value
        End Set
    End Property

    Public Property Password() As String
        Get
            Return pSupervisor
        End Get
        Set(ByVal Value As String)
            pPassword = Value
        End Set
    End Property

    Public Property Origen() As String
        Get
            Return vOrigen
        End Get
        Set(ByVal Value As String)
            vOrigen = Value
        End Set
    End Property

    Private Sub frmMovCaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oApp As New wrAdmin.wsLibAdmin
        If btnGuardar1.Visible = True Then
            Me.dtpR1.Value = oApp.Fecha
        End If
        If Me.vOrigen = "F" Then

            Dim vSize As New Size(580, 207)
            'dimvLocation As New Point(376, 80), vLocation2 As New Point(464, 80)
            Me.gbDetalle.Visible = False
            'Me.btnGuardar1.Location = vLocation
            'Me.btnCerrar.Location = vLocation2
            Me.Size = vSize
            If Me.btnGuardar1.Visible = True And Me.btnGuardar1.Text = "&Guardar" Then
                Me.cboTipoMovimiento.Items.Clear()
                Me.cboTipoMovimiento.Items.Add("Faltante")
                Me.cboTipoMovimiento.Items.Add("Sobrante")
                Me.cboTipoMovimiento.SelectedIndex = 0
            End If
        End If
    End Sub


    Private Sub c1nCien_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCien.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value
    End Sub

    Private Sub c1nCinco_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCinco.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value
    End Sub

    Private Sub c1nCincuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nCincuenta.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim nocaja As Integer
            Dim monto As Double
            Dim tipomov As String
            Dim fecha As String

            If IsNumeric(Me.txtCaja.Text.Trim) = False Then Exit Sub
            If Me.vOrigen <> "F" Then
                If Me.txtMonto.Value <> Me.c1nTotal.Value Then
                    MessageBox.Show("El Monto no coincide con el total del detalle, verifíque.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            fecha = dtpR1.Value.ToShortDateString
            nocaja = CInt(txtCaja.Text)
            monto = CDbl(txtMonto.Value)

            If cboTipoMovimiento.SelectedIndex = 0 Then
                If Me.vOrigen = "F" Then
                    tipomov = "T" 'Faltante de Caja
                Else
                    tipomov = "R" 'Remisión a Caja
                End If
            Else
                If Me.vOrigen = "F" Then
                    tipomov = "S" 'Sobrante de Caja
                Else
                    tipomov = "F" 'Fondo del Cajero
                End If
            End If

            Dim pCampos, pValores As String, resp As Boolean

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "NoCaja,Fecha,Monto,TipoMov,CantidadUno,CantidadCinco,CantidadDiez,CantidadVeinte,CantidadCincuenta,CantidadCien,CantidadFraccion"
                pValores = nocaja & ",'" & fecha & "'," & monto & ",'" & tipomov & "'," & Me.c1nUno.Value & "," & Me.c1nCinco.Value & "," & Me.c1nDiez.Value & "," & Me.c1nVeinte.Value & "," & Me.c1nCincuenta.Value & "," & Me.c1nCien.Value & "," & Me.c1nFraccion.Value & ""

                If Me.vOrigen = "F" Then
                    resp = oCaja.InsertarMovimientoCaja(pCampos, pValores, "F", pSupervisor, pPassword, sSucursal)
                Else
                    resp = oCaja.InsertarMovimientoCaja(pCampos, pValores, "M", sUsuario, sPassword, sSucursal)
                End If
                If resp = True Then Me.Close()
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "NoCaja=" & nocaja & ",Fecha='" & fecha & "',Monto=" & monto & ",TipoMov='" & tipomov & "',CantidadUno=" & Me.c1nUno.Value & ",CantidadCinco=" & Me.c1nCinco.Value & ",CantidadDiez=" & Me.c1nDiez.Value & ",CantidadVeinte=" & Me.c1nVeinte.Value & ",CantidadCincuenta=" & Me.c1nCincuenta.Value & ",CantidadCien=" & Me.c1nCien.Value & ",CantidadFraccion=" & Me.c1nFraccion.Value & ""
                If Me.vOrigen = "F" Then
                    resp = oCaja.ModificarMovimientoCaja(pCampos, pCorrelativo, "F", pSupervisor, pPassword, sSucursal)
                Else
                    resp = oCaja.ModificarMovimientoCaja(pCampos, pCorrelativo, "M", sUsuario, sPassword, sSucursal)
                End If
                If resp = True Then Me.Close()
            End If

        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub c1nDiez_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nDiez.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value
    End Sub

    Private Sub c1nFraccion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nFraccion.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value
    End Sub

    Private Sub c1nUno_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nUno.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value
    End Sub

    Private Sub c1nVeinte_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nVeinte.LostFocus
        Me.c1nTotal.Value = Me.c1nUno.Value + Me.c1nCinco.Value * 5 + Me.c1nDiez.Value * 10 + Me.c1nVeinte.Value * 20 + Me.c1nCincuenta.Value * 50 + Me.c1nCien.Value * 100 + Me.c1nFraccion.Value
    End Sub

End Class