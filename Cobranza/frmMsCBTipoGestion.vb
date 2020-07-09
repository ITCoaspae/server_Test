Public Class frmMsCBTipoGestion
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pAccion As String
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
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents nuPorcentaje As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtIdCuenta As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.nuPorcentaje = New System.Windows.Forms.NumericUpDown()
        Me.txtCuenta = New System.Windows.Forms.TextBox()
        Me.txtIdCuenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.nuPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nuPorcentaje
        '
        Me.nuPorcentaje.DecimalPlaces = 2
        Me.nuPorcentaje.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nuPorcentaje.Location = New System.Drawing.Point(128, 112)
        Me.nuPorcentaje.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nuPorcentaje.Name = "nuPorcentaje"
        Me.nuPorcentaje.Size = New System.Drawing.Size(56, 20)
        Me.nuPorcentaje.TabIndex = 2
        Me.nuPorcentaje.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtCuenta
        '
        Me.txtCuenta.BackColor = System.Drawing.Color.White
        Me.txtCuenta.Location = New System.Drawing.Point(190, 144)
        Me.txtCuenta.MaxLength = 100
        Me.txtCuenta.Multiline = True
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(265, 46)
        Me.txtCuenta.TabIndex = 4
        '
        'txtIdCuenta
        '
        Me.txtIdCuenta.Location = New System.Drawing.Point(128, 145)
        Me.txtIdCuenta.MaxLength = 20
        Me.txtIdCuenta.Name = "txtIdCuenta"
        Me.txtIdCuenta.Size = New System.Drawing.Size(56, 20)
        Me.txtIdCuenta.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(23, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 101
        Me.Label5.Text = "Cuenta contable:"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(23, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(99, 29)
        Me.Label13.TabIndex = 100
        Me.Label13.Text = "Porcentaje de Cobro de Comisión:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(128, 86)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(327, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(128, 60)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(327, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Código:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuardar1.Location = New System.Drawing.Point(380, 196)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1022
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCBTipoGestion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(483, 257)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.nuPorcentaje)
        Me.Controls.Add(Me.txtIdCuenta)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescripcion)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(483, 257)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(483, 257)
        Me.Name = "frmMsCBTipoGestion"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Tipos de Situación de Gestión"
        CType(Me.nuPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub frmMsCBTipoGestion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Dim oPerif As New wrConta.wsLibContab
        Dim Filas As Data.DataRowCollection

        If Me.pAccion = "Modificar" Then

            ds = oCred.ConsultarTipoGestion("*", "CodTipoGestion='" & pCodigo & "'", "CodTipoGestion", sUsuario, sPassword, sSucursal)

            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtCodigo.Text = pCodigo
                txtCodigo.Enabled = False
                txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                nuPorcentaje.Value = IIf(IsDBNull(Filas.Item(0)("PorcentajeCobro")), 1, Filas.Item(0)("PorcentajeCobro"))
                txtIdCuenta.Text = IIf(IsDBNull(Filas.Item(0)("IdCuenta")), "", Filas.Item(0)("IdCuenta"))
                ds = oPerif.ObtenerCatContab("*", "IdCuenta='" & Me.txtIdCuenta.Text.Trim & "'", "IdCuenta", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtCuenta.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                End If
            End If
        Else
            Me.txtCodigo.Text = oCred.ObtenerCorrelativoTipoGestion("CodTipoGestion", sUsuario, sPassword, sSucursal)
            txtCodigo.ReadOnly = True
        End If
        txtCodigo.Focus()

    End Sub

    Private Sub nuPorcentaje_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nuPorcentaje.GotFocus
        Me.nuPorcentaje.Select(0, Len(Me.nuPorcentaje.Value))
    End Sub

    Private Sub nuPorcentaje_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles nuPorcentaje.Validating
        If Me.nuPorcentaje.Value > 100 Then e.Cancel = True
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try

            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String

            'If Me.txtCodigo.Text.Trim = "" Then
            '    MsgBox("El Código de Tipo de Gestión no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Cobranzas")
            '    Exit Sub
            'End If

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "Descripcion,PorcentajeCobro,IdCuenta"
                pValores = "'" & Trim(txtDescripcion.Text) & "'," & Val(Me.nuPorcentaje.Value) & ",'" & Trim(Me.txtIdCuenta.Text) & "'"
                If oCred.InsertarTipoGestion(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El tipo de Gestión no ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Cobranzas")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Descripcion='" & Trim(txtDescripcion.Text) & "',PorcentajeCobro=" & Val(Me.nuPorcentaje.Value) & ",IdCuenta='" & Trim(Me.txtIdCuenta.Text) & "'"
                If oCred.ModificarTipoGestion(Trim(pCodigo), pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El tipo de Gestión no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Cobranzas")
                End If
            End If

        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtIdCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIdCuenta.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Cuenta Bancaria"
        Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatContab("*", "", "IdCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtIdCuenta.Text = ofrm.Resultado.Trim
            Me.txtCuenta.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catálogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
