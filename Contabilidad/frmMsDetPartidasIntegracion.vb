Public Class frmMsDetPartidasIntegracion
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form : 
    Public rsc As System.Resources.ResourceManager

    Private pCodigo As String, pAccion As String, pCorrelativo As String
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCerrar1 As MetroFramework.Controls.MetroButton
    Private errorProvider1 As New System.Windows.Forms.ErrorProvider

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
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaBE As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCuentaBE As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaCC As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCuentaCC As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCuentaCB As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCuentaCB As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rbAbono As System.Windows.Forms.RadioButton
    Friend WithEvents rbCargo As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtIdCuentaBE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbCargo = New System.Windows.Forms.RadioButton()
        Me.rbAbono = New System.Windows.Forms.RadioButton()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtCuentaBE = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCuentaCC = New System.Windows.Forms.TextBox()
        Me.txtIdCuentaCC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCuentaCB = New System.Windows.Forms.TextBox()
        Me.txtIdCuentaCB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.btnCerrar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIdCuentaBE
        '
        Me.txtIdCuentaBE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCuentaBE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCuentaBE.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtIdCuentaBE.Location = New System.Drawing.Point(104, 113)
        Me.txtIdCuentaBE.Name = "txtIdCuentaBE"
        Me.txtIdCuentaBE.Size = New System.Drawing.Size(128, 21)
        Me.txtIdCuentaBE.TabIndex = 4
        Me.txtIdCuentaBE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Tipo Cuenta:"
        '
        'rbCargo
        '
        Me.rbCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCargo.ForeColor = System.Drawing.Color.Black
        Me.rbCargo.Location = New System.Drawing.Point(184, 40)
        Me.rbCargo.Name = "rbCargo"
        Me.rbCargo.Size = New System.Drawing.Size(64, 16)
        Me.rbCargo.TabIndex = 1
        Me.rbCargo.Text = "&Cargo"
        '
        'rbAbono
        '
        Me.rbAbono.Checked = True
        Me.rbAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbAbono.ForeColor = System.Drawing.Color.Black
        Me.rbAbono.Location = New System.Drawing.Point(104, 40)
        Me.rbAbono.Name = "rbAbono"
        Me.rbAbono.Size = New System.Drawing.Size(64, 16)
        Me.rbAbono.TabIndex = 0
        Me.rbAbono.TabStop = True
        Me.rbAbono.Text = "&Abono"
        '
        'txtConcepto
        '
        Me.txtConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConcepto.Location = New System.Drawing.Point(104, 140)
        Me.txtConcepto.Multiline = True
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtConcepto.Size = New System.Drawing.Size(486, 48)
        Me.txtConcepto.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(8, 142)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "Concepto:"
        '
        'txtCuentaBE
        '
        Me.txtCuentaBE.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCuentaBE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaBE.Enabled = False
        Me.txtCuentaBE.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaBE.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCuentaBE.Location = New System.Drawing.Point(240, 113)
        Me.txtCuentaBE.Name = "txtCuentaBE"
        Me.txtCuentaBE.Size = New System.Drawing.Size(350, 21)
        Me.txtCuentaBE.TabIndex = 25
        Me.txtCuentaBE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(8, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 16)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Centro Beneficios:"
        '
        'txtCuentaCC
        '
        Me.txtCuentaCC.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCuentaCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaCC.Enabled = False
        Me.txtCuentaCC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaCC.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCuentaCC.Location = New System.Drawing.Point(240, 86)
        Me.txtCuentaCC.Name = "txtCuentaCC"
        Me.txtCuentaCC.Size = New System.Drawing.Size(350, 21)
        Me.txtCuentaCC.TabIndex = 22
        Me.txtCuentaCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIdCuentaCC
        '
        Me.txtIdCuentaCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCuentaCC.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCuentaCC.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtIdCuentaCC.Location = New System.Drawing.Point(104, 86)
        Me.txtIdCuentaCC.Name = "txtIdCuentaCC"
        Me.txtIdCuentaCC.Size = New System.Drawing.Size(128, 21)
        Me.txtIdCuentaCC.TabIndex = 3
        Me.txtIdCuentaCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(8, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Centro de Costos:"
        '
        'txtCuentaCB
        '
        Me.txtCuentaCB.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtCuentaCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaCB.Enabled = False
        Me.txtCuentaCB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaCB.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCuentaCB.Location = New System.Drawing.Point(240, 59)
        Me.txtCuentaCB.Name = "txtCuentaCB"
        Me.txtCuentaCB.Size = New System.Drawing.Size(350, 21)
        Me.txtCuentaCB.TabIndex = 19
        Me.txtCuentaCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtIdCuentaCB
        '
        Me.txtIdCuentaCB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCuentaCB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCuentaCB.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtIdCuentaCB.Location = New System.Drawing.Point(104, 59)
        Me.txtIdCuentaCB.Name = "txtIdCuentaCB"
        Me.txtIdCuentaCB.Size = New System.Drawing.Size(128, 21)
        Me.txtIdCuentaCB.TabIndex = 2
        Me.txtIdCuentaCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Cuenta Contable:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Observación:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(101, 70)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(528, 40)
        Me.txtDescripcion.TabIndex = 0
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.Label12)
        Me.MetroPanel1.Controls.Add(Me.txtConcepto)
        Me.MetroPanel1.Controls.Add(Me.txtIdCuentaBE)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.Controls.Add(Me.Label1)
        Me.MetroPanel1.Controls.Add(Me.txtCuentaBE)
        Me.MetroPanel1.Controls.Add(Me.rbCargo)
        Me.MetroPanel1.Controls.Add(Me.Label11)
        Me.MetroPanel1.Controls.Add(Me.rbAbono)
        Me.MetroPanel1.Controls.Add(Me.txtCuentaCC)
        Me.MetroPanel1.Controls.Add(Me.txtIdCuentaCC)
        Me.MetroPanel1.Controls.Add(Me.Label9)
        Me.MetroPanel1.Controls.Add(Me.Label10)
        Me.MetroPanel1.Controls.Add(Me.txtIdCuentaCB)
        Me.MetroPanel1.Controls.Add(Me.txtCuentaCB)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(26, 116)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(603, 201)
        Me.MetroPanel1.TabIndex = 29
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(11, 11)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(151, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Detalle Cuenta Contable"
        Me.MetroLabel1.UseStyleColors = True
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(473, 323)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 30
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'btnCerrar1
        '
        Me.btnCerrar1.Location = New System.Drawing.Point(554, 323)
        Me.btnCerrar1.Name = "btnCerrar1"
        Me.btnCerrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnCerrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCerrar1.TabIndex = 31
        Me.btnCerrar1.Text = "Cerrar"
        Me.btnCerrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCerrar1.UseSelectable = True
        Me.btnCerrar1.UseStyleColors = True
        '
        'frmMsDetPartidasIntegracion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(649, 365)
        Me.Controls.Add(Me.btnCerrar1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(649, 365)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(649, 365)
        Me.Name = "frmMsDetPartidasIntegracion"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Detalle de Cuentas Contables"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Propiedades"

    Public Property Codigo() As String
        Get
            Return pCodigo
        End Get
        Set(ByVal Value As String)
            pCodigo = Value
        End Set
    End Property

    Public Property Accion() As String
        Get
            Return pAccion
        End Get
        Set(ByVal Value As String)
            pAccion = Value
        End Set
    End Property

    Public Property Correlativo() As String
        Get
            Return pCorrelativo
        End Get
        Set(ByVal Value As String)
            pCorrelativo = Value
        End Set
    End Property

#End Region

    Private Sub txtIdCuentaCC_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCuentaCC.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Centro de Costos"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "Cod_CCosto,Descripcion,Comentario", "Final='S'", "Cod_CCosto", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtIdCuentaCC.Text = ofrm.Resultado.Trim
            txtCuentaCC.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Cat_Costos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtIdCuentaBE_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCuentaBE.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Centro de Beneficios"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatBeneficio("Cod_CBeneficio,Descripcion,Comentario", "Final='S'", "Cod_CBeneficio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtIdCuentaBE.Text = ofrm.Resultado.Trim
            txtCuentaBE.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Cat_Beneficios - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtIdCuentaCC_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdCuentaCC.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim ofrm As New frmAGenerico

            ofrm.Text = "Buscar Cuenta Centro de Costos"
            Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
            Try
                oPerif = New wrConta.wsLibContab
                ds = oPerif.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "Cod_CCosto,Descripcion,Comentario", "Final='S'", "Cod_CCosto", sUsuario, sPassword, sSucursal)
                ofrm.Datos = ds
                ofrm.ColSeleccion = 0
                ofrm.RefrescarGrid()
                ofrm.ShowDialog()
                txtIdCuentaCC.Text = ofrm.Resultado.Trim
                txtCuentaCC.Text = ofrm.Resultado2.Trim
            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla Cat_Costos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub txtIdCuentaBE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdCuentaBE.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim ofrm As New frmAGenerico

            ofrm.Text = "Buscar Cuenta Centro de Beneficios"
            Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
            Try
                oPerif = New wrConta.wsLibContab
                ds = oPerif.ObtenerCatBeneficio("Cod_CBeneficio,Descripcion,Comentario", "Final='S'", "Cod_CBeneficio", sUsuario, sPassword, sSucursal)
                ofrm.Datos = ds
                ofrm.ColSeleccion = 0
                ofrm.RefrescarGrid()
                ofrm.ShowDialog()
                txtIdCuentaBE.Text = ofrm.Resultado.Trim
                txtCuentaBE.Text = ofrm.Resultado2.Trim
            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla Cat_Beneficios - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub txtIdCuentaCC_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIdCuentaCC.Validating
        Dim oPerif As New wrConta.wsLibContab, ds As New Data.DataSet, dr As DataRow
        ds = oPerif.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "Cod_CCosto,Descripcion", "Cod_CCosto='" & Me.txtIdCuentaCC.Text.Trim & "' and Final='S'", "Cod_CCosto", sUsuario, sPassword, sSucursal)
        If ds.Tables("Catalogo").Rows.Count = 0 Then
            e.Cancel = True
            Me.txtIdCuentaCC.Select(0, txtIdCuentaCC.Text.Length)
            errorProvider1.SetIconAlignment(Me.txtIdCuentaCC, ErrorIconAlignment.MiddleRight)
            errorProvider1.SetIconPadding(Me.txtIdCuentaCC, 2)
            errorProvider1.BlinkRate = 1000
            errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
            errorProvider1.SetError(txtIdCuentaCC, "Cuenta Costos no existe")
        Else
            dr = ds.Tables("Catalogo").Rows(0)
            Me.txtCuentaCC.Text = dr("Descripcion")
            If Me.txtIdCuentaCC.Text.Trim = "" Then
                e.Cancel = True
                Me.txtIdCuentaCC.Select(0, txtIdCuentaCC.Text.Length)
                errorProvider1.SetIconAlignment(Me.txtIdCuentaCC, ErrorIconAlignment.MiddleRight)
                errorProvider1.SetIconPadding(Me.txtIdCuentaCC, 2)
                errorProvider1.BlinkRate = 1000
                errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
                errorProvider1.SetError(txtIdCuentaCC, "Error de Validación")
            Else
                errorProvider1.SetError(Me.txtIdCuentaCC, "")
            End If
        End If
    End Sub

    Private Sub txtIdCuentaBE_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIdCuentaBE.Validating
        Dim oPerif As New wrConta.wsLibContab, ds As New Data.DataSet, dr As DataRow
        ds = oPerif.ObtenerCatBeneficio("Cod_CBeneficio,Descripcion", "Cod_CBeneficio='" & Me.txtIdCuentaBE.Text.Trim & "' and Final='S'", "Cod_CBeneficio", sUsuario, sPassword, sSucursal)
        If ds.Tables("Catalogo").Rows.Count = 0 Then
            e.Cancel = True
            Me.txtIdCuentaBE.Select(0, txtIdCuentaBE.Text.Length)
            errorProvider1.SetIconAlignment(Me.txtIdCuentaBE, ErrorIconAlignment.MiddleRight)
            errorProvider1.SetIconPadding(Me.txtIdCuentaBE, 2)
            errorProvider1.BlinkRate = 1000
            errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
            errorProvider1.SetError(txtIdCuentaBE, "Cuenta Beneficios no existe")
        Else
            dr = ds.Tables("Catalogo").Rows(0)
            Me.txtCuentaBE.Text = dr("Descripcion")
            If Me.txtIdCuentaBE.Text.Trim = "" Then
                e.Cancel = True
                Me.txtIdCuentaBE.Select(0, txtIdCuentaCC.Text.Length)
                errorProvider1.SetIconAlignment(Me.txtIdCuentaBE, ErrorIconAlignment.MiddleRight)
                errorProvider1.SetIconPadding(Me.txtIdCuentaBE, 2)
                errorProvider1.BlinkRate = 1000
                errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
                errorProvider1.SetError(txtIdCuentaBE, "Error de Validación")
            Else
                errorProvider1.SetError(Me.txtIdCuentaBE, "")
            End If
        End If

    End Sub

    Private Sub frmMsDetPartidasIntegracion_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oCtb As New wrConta.wsLibContab, oPerif As New wrConta.wsLibContab
        Dim dsTipo As New DataSet, dr As DataRow, ds As New DataSet

        If Me.pAccion = "Modificar" Then
            ds = oCtb.ConsultarDetParametroPartidaIntegracion("*", "Correlativo=" & Me.pCorrelativo.Trim & "", "CodPartidaIntegrac", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.txtDescripcion.Text = dr("DescripcionCodigoGuia")
                Me.txtConcepto.Text = dr("Concepto")
                Me.txtIdCuentaCB.Text = dr("IdCuenta")
                Me.txtIdCuentaCC.Text = dr("CodCCosto")
                Me.txtIdCuentaBE.Text = dr("CodCBeneficio")
                If Trim(dr("TipoCuenta")) = "A" Then
                    Me.rbAbono.Checked = True
                ElseIf Trim(dr("TipoCuenta")) = "B" Then
                    Me.rbCargo.Checked = True
                End If

                ds = oPerif.ObtenerCatContab("*", "Final='S' and IdCuenta='" & Me.txtIdCuentaCB.Text.Trim & "'", "idCuenta", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtCuentaCB.Text = dr("Descripcion")
                End If

                ds = oPerif.ObtenerCatBeneficio("*", "Final='S' and Cod_CBeneficio='" & Me.txtIdCuentaBE.Text.Trim & "'", "Cod_CBeneficio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtCuentaBE.Text = dr("Descripcion")
                End If

                ds = oPerif.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "*", "Final='S' and Cod_CCosto='" & Me.txtIdCuentaCC.Text.Trim & "'", "Cod_CCosto", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtCuentaCC.Text = dr("Descripcion")
                End If

            End If
        End If

    End Sub

    Private Sub txtIdCuentaCB_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCuentaCB.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Contable"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatContab("*", "Final='S'", "idCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtIdCuentaCB.Text = ofrm.Resultado.Trim
            txtCuentaCB.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try

            If Me.txtIdCuentaCB.Text.Trim = "" Or Me.txtIdCuentaCC.Text.Trim = "" Or Me.txtIdCuentaBE.Text.Trim = "" Then Exit Sub

            Dim oCtb As New wrConta.wsLibContab
            Dim pTipo As String, pCampos As String, pValores As String

            If Me.rbAbono.Checked = True Then
                pTipo = "A"
            ElseIf Me.rbCargo.Checked = True Then
                pTipo = "C"
            End If
            If Me.pAccion = "Agregar" Then
                pCampos = "CodPartidaIntegrac,IdCuenta,TipoCuenta,Concepto,DescripcionCodigoGuia,CodCCosto,CodCBeneficio"
                pValores = "'" & pCodigo & "','" & Me.txtIdCuentaCB.Text.Trim & "','" & pTipo & "','" & Me.txtConcepto.Text.Trim & "','" & Me.txtDescripcion.Text.Trim & "','" & Me.txtIdCuentaCC.Text.Trim & "','" & Me.txtIdCuentaBE.Text.Trim & "'"
                If oCtb.InsertaDetParametroPartidaIntegracion(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MessageBox.Show("Los datos no se guardaron, verifíque.", "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            ElseIf Me.pAccion = "Modificar" Then
                pCampos = "IdCuenta='" & Me.txtIdCuentaCB.Text.Trim & "',TipoCuenta='" & pTipo & "',Concepto='" & Me.txtConcepto.Text.Trim & "',DescripcionCodigoGuia='" & Me.txtDescripcion.Text.Trim & "',CodCCosto='" & Me.txtIdCuentaCC.Text.Trim & "',CodCBeneficio='" & Me.txtIdCuentaBE.Text.Trim & "'"
                If oCtb.ModificaDetParametroPartidaIntegracion(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MessageBox.Show("Los datos no se modificaron, verifíque.", "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCerrar1_Click(sender As Object, e As EventArgs) Handles btnCerrar1.Click
        Me.Dispose()
    End Sub

    Private Sub txtIdCuentaCB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIdCuentaCB.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then


            Dim ofrm As New frmAGenerico

            ofrm.Text = "Buscar Cuenta Contable"
            Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
            Try
                oPerif = New wrConta.wsLibContab
                ds = oPerif.ObtenerCatContab("*", "Final='S'", "idCuenta", sUsuario, sPassword, sSucursal)
                ofrm.Datos = ds
                ofrm.ColSeleccion = 0
                ofrm.RefrescarGrid()
                ofrm.ShowDialog()
                txtIdCuentaCB.Text = ofrm.Resultado.Trim
                txtCuentaCB.Text = ofrm.Resultado2.Trim
            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub txtIdCuentaCB_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtIdCuentaCB.Validating
        Dim oPerif As New wrConta.wsLibContab, ds As New Data.DataSet, dr As DataRow
        ds = oPerif.ObtenerCatContab("IdCuenta,Descripcion", "IdCuenta='" & Me.txtIdCuentaCB.Text.Trim & "' and Final='S'", "IdCuenta", sUsuario, sPassword, sSucursal)
        If ds.Tables("Catalogo").Rows.Count = 0 Then
            e.Cancel = True
            Me.txtIdCuentaCB.Select(0, txtIdCuentaCB.Text.Length)
            errorProvider1.SetIconAlignment(Me.txtIdCuentaCB, ErrorIconAlignment.MiddleRight)
            errorProvider1.SetIconPadding(Me.txtIdCuentaCB, 2)
            errorProvider1.BlinkRate = 1000
            errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
            errorProvider1.SetError(txtIdCuentaCB, "Cuenta Contable no existe")
        Else
            dr = ds.Tables("Catalogo").Rows(0)
            Me.txtCuentaCB.Text = dr("Descripcion")
            If Me.txtIdCuentaCB.Text.Trim = "" Then
                e.Cancel = True
                Me.txtIdCuentaCB.Select(0, txtIdCuentaCB.Text.Length)
                errorProvider1.SetIconAlignment(Me.txtIdCuentaCB, ErrorIconAlignment.MiddleRight)
                errorProvider1.SetIconPadding(Me.txtIdCuentaCB, 2)
                errorProvider1.BlinkRate = 1000
                errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink
                errorProvider1.SetError(txtIdCuentaCB, "Error de Validación")
            Else
                errorProvider1.SetError(Me.txtIdCuentaCB, "")
            End If
        End If
    End Sub

End Class