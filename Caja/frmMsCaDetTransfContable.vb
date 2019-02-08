Public Class frmMsCaDetTransfContable
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents cbCentroCosto As MetroFramework.Controls.MetroComboBox

    Dim contabilidad As New wrConta.wsLibContab
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
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btNProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label2 As Label
    Friend WithEvents c1txtMonto As C1.Win.C1Input.C1NumericEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btNProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.c1txtMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.cbCentroCosto = New MetroFramework.Controls.MetroComboBox()
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Centro Costos:"
        '
        'btNProcesar1
        '
        Me.btNProcesar1.Location = New System.Drawing.Point(400, 184)
        Me.btNProcesar1.Name = "btNProcesar1"
        Me.btNProcesar1.Size = New System.Drawing.Size(90, 33)
        Me.btNProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNProcesar1.TabIndex = 7
        Me.btNProcesar1.Text = "Guardar"
        Me.btNProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNProcesar1.UseSelectable = True
        Me.btNProcesar1.UseStyleColors = True
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Location = New System.Drawing.Point(154, 82)
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(336, 22)
        Me.txtCuenta.TabIndex = 2
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.BackColor = System.Drawing.Color.White
        Me.txtIdCuenta.Location = New System.Drawing.Point(23, 82)
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.ReadOnly = True
        Me.txtIdCuenta.Size = New System.Drawing.Size(125, 22)
        Me.txtIdCuenta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuenta Contable:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(332, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Valor a transferir:"
        '
        'c1txtMonto
        '
        Me.c1txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtMonto.CustomFormat = "###,##0.00"
        Me.c1txtMonto.DataType = GetType(Double)
        Me.c1txtMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1txtMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1txtMonto.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1txtMonto.Location = New System.Drawing.Point(23, 184)
        Me.c1txtMonto.Name = "c1txtMonto"
        Me.c1txtMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1txtMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1txtMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(0R, Nothing, True, True)})
        Me.c1txtMonto.Size = New System.Drawing.Size(125, 23)
        Me.c1txtMonto.TabIndex = 6
        Me.c1txtMonto.Tag = Nothing
        Me.c1txtMonto.Value = 0R
        Me.c1txtMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'cbCentroCosto
        '
        Me.cbCentroCosto.FormattingEnabled = True
        Me.cbCentroCosto.ItemHeight = 24
        Me.cbCentroCosto.Location = New System.Drawing.Point(23, 129)
        Me.cbCentroCosto.Name = "cbCentroCosto"
        Me.cbCentroCosto.Size = New System.Drawing.Size(467, 30)
        Me.cbCentroCosto.TabIndex = 4
        Me.cbCentroCosto.UseSelectable = True
        '
        'frmMsCaDetTransfContable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(521, 324)
        Me.Controls.Add(Me.cbCentroCosto)
        Me.Controls.Add(Me.btNProcesar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdCuenta)
        Me.Controls.Add(Me.c1txtMonto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCuenta)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(521, 324)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(521, 324)
        Me.Name = "frmMsCaDetTransfContable"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Detalle de Cuenta Destino"
        CType(Me.c1txtMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private pDui As String, pNoCuenta As String, ofrmT As frmMCaTransferenciaContable, pFecha As Date
    Private selectedIndex As Integer

    Public Property Fecha() As Date
        Get
            Return pFecha
        End Get
        Set(ByVal Value As Date)
            pFecha = Value
        End Set
    End Property

    Public Property FrmT() As frmMCaTransferenciaContable
        Get
            Return ofrmT
        End Get
        Set(ByVal Value As frmMCaTransferenciaContable)
            ofrmT = Value
        End Set
    End Property

    Public Property Dui() As String
        Get
            Return pDui
        End Get
        Set(ByVal Value As String)
            pDui = Value
        End Set
    End Property

    Public Property NoCuenta() As String
        Get
            Return pNoCuenta
        End Get
        Set(ByVal Value As String)
            pNoCuenta = Value
        End Set
    End Property

    Private Sub txtCentroCostos_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btNProcesar1_Click(sender As Object, e As EventArgs) Handles btNProcesar1.Click
        Try
            If Me.txtIdCuenta.Text.Trim = "" Then
                MessageBox.Show("El Código de Cuenta Contable no puede quedar vacío.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If Me.c1txtMonto.Value = 0 Then
                MessageBox.Show("El valor a transferir no puede ser cero.", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim oAh As New wrAhorro.wsLibAhorro, ds As DataSet
            ds = oAh.AgregarDetalleTransferencia(FrmT.dsDetalle, FrmT.dsDetalle.Tables(0).Rows.Count + 1, Me.txtIdCuenta.Text, Me.c1txtMonto.Value, "", "C", Me.txtIdCuenta.Text.Trim, pFecha, cbCentroCosto.SelectedValue)
            FrmT.dsDetalle = ds
            Me.Dispose()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtIdCuenta_TextChanged(sender As Object, e As EventArgs) Handles txtIdCuenta.TextChanged

    End Sub

    Private Sub txtIdCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCuenta.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Contable"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatContab("idCuenta,Descripcion", "Final='S' and idCuenta<>'" & pNoCuenta & "' and Inhabilitado = 'N' ", "idCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtIdCuenta.Text = ofrm.Resultado.Trim
            Me.txtCuenta.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsCaDetTransfContable_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtIdCuenta.ReadOnly = True
        llenarCbCC()
    End Sub


    Private Sub llenarCbCC()
        Dim dts As New DataSet
        Dim campos As String
        campos = "Cod_CCosto,Descripcion"
        dts = contabilidad.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, campos, " FINAL = 'S' ", "Descripcion", sUsuario, sPassword, sSucursal)
        cbCentroCosto.DisplayMember = "Descripcion"
        cbCentroCosto.ValueMember = "Cod_CCosto"
        cbCentroCosto.DataSource = dts.Tables(0)
    End Sub
End Class