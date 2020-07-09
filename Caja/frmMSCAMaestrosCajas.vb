Public Class frmMSCAMaestrosCajas
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim asociado As New wrAsociados.wsLibAsoc

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
    Friend WithEvents c1txtNoCaja As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbSucursal As ComboBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.c1txtNoCaja = New C1.Win.C1Input.C1TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbSucursal = New System.Windows.Forms.ComboBox()
        CType(Me.c1txtNoCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1txtNoCaja
        '
        Me.c1txtNoCaja.BackColor = System.Drawing.Color.White
        Me.c1txtNoCaja.DataType = GetType(Short)
        Me.c1txtNoCaja.Location = New System.Drawing.Point(129, 60)
        Me.c1txtNoCaja.Name = "c1txtNoCaja"
        Me.c1txtNoCaja.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1txtNoCaja.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1txtNoCaja.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1txtNoCaja.Size = New System.Drawing.Size(112, 20)
        Me.c1txtNoCaja.TabIndex = 9
        Me.c1txtNoCaja.Tag = Nothing
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(23, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Número de Caja"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(213, 162)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 163
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 164
        Me.Label1.Text = "Sucursal"
        '
        'cbSucursal
        '
        Me.cbSucursal.FormattingEnabled = True
        Me.cbSucursal.Location = New System.Drawing.Point(129, 86)
        Me.cbSucursal.Name = "cbSucursal"
        Me.cbSucursal.Size = New System.Drawing.Size(246, 21)
        Me.cbSucursal.TabIndex = 165
        '
        'frmMSCAMaestrosCajas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(392, 243)
        Me.Controls.Add(Me.cbSucursal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.c1txtNoCaja)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(266, 139)
        Me.Name = "frmMSCAMaestrosCajas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Maestro Cajas"
        CType(Me.c1txtNoCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Protected Sub llenarSucursales()
        Try
            Dim dts As New DataSet
            dts = asociado.ConsultarSucursales("codSucursal,nom_sucursal", "", "nom_sucursal", sUsuario, sPassword, sSucursal)
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbSucursal.ValueMember = "codSucursal"
                Me.cbSucursal.DisplayMember = "nom_sucursal"
                Me.cbSucursal.DataSource = dts.Tables(0)
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim Campos, Valores As String
        Try
            Dim oItem As New wrCaja.wsLibCaja
            Campos = "NoCaja,codSucursal"
            Valores = "" & Me.c1txtNoCaja.Value & ", '" & Me.cbSucursal.SelectedValue & "'"
            If oItem.InsertarCajas(Campos, Valores, sUsuario, sPassword, sSucursal) Then
                Me.Dispose()
            Else
                MessageBox.Show("Registro no ingresado")
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMSCAMaestrosCajas_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenarSucursales()
    End Sub
End Class
