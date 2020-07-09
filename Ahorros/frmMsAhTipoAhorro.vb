Public Class frmMsAhTipoAhorro
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pAccion As String
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c1nPlazo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkJunior As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodCuenta As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCuenta As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtCodCuenta = New C1.Win.C1Input.C1TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCuenta = New C1.Win.C1Input.C1TextBox()
        Me.chkJunior = New System.Windows.Forms.CheckBox()
        Me.c1nPlazo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        CType(Me.txtCodCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodCuenta
        '
        Me.txtCodCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCuenta.Location = New System.Drawing.Point(116, 138)
        Me.txtCodCuenta.MaxLength = 14
        Me.txtCodCuenta.Name = "txtCodCuenta"
        Me.txtCodCuenta.NumericInput = False
        Me.txtCodCuenta.Size = New System.Drawing.Size(106, 20)
        Me.txtCodCuenta.TabIndex = 3
        Me.txtCodCuenta.Tag = Nothing
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(23, 138)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 19)
        Me.Label17.TabIndex = 171
        Me.Label17.Text = "Cuenta Contable:"
        '
        'txtCuenta
        '
        Me.txtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuenta.Enabled = False
        Me.txtCuenta.Location = New System.Drawing.Point(232, 138)
        Me.txtCuenta.MaxLength = 14
        Me.txtCuenta.Name = "txtCuenta"
        Me.txtCuenta.NumericInput = False
        Me.txtCuenta.ReadOnly = True
        Me.txtCuenta.Size = New System.Drawing.Size(364, 20)
        Me.txtCuenta.TabIndex = 4
        Me.txtCuenta.Tag = Nothing
        '
        'chkJunior
        '
        Me.chkJunior.Location = New System.Drawing.Point(26, 164)
        Me.chkJunior.Name = "chkJunior"
        Me.chkJunior.Size = New System.Drawing.Size(124, 19)
        Me.chkJunior.TabIndex = 3
        Me.chkJunior.Text = "Ahorro &Junior"
        Me.chkJunior.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'c1nPlazo
        '
        Me.c1nPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nPlazo.CustomFormat = "#00"
        Me.c1nPlazo.DataType = GetType(Short)
        Me.c1nPlazo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nPlazo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nPlazo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nPlazo.Location = New System.Drawing.Point(407, 81)
        Me.c1nPlazo.Name = "c1nPlazo"
        Me.c1nPlazo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nPlazo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nPlazo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nPlazo.Size = New System.Drawing.Size(189, 23)
        Me.c1nPlazo.TabIndex = 1
        Me.c1nPlazo.Tag = Nothing
        Me.c1nPlazo.Value = CType(0, Short)
        Me.c1nPlazo.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(353, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Plazo:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(116, 110)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(480, 22)
        Me.txtDescripcion.TabIndex = 2
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(116, 82)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(189, 22)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 19)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Código:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(500, 164)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(96, 32)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 216
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'frmMsAhTipoAhorro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(620, 281)
        Me.Controls.Add(Me.chkJunior)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtCodCuenta)
        Me.Controls.Add(Me.txtCuenta)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.c1nPlazo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhTipoAhorro"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Tipos de Ahorro"
        CType(Me.txtCodCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nPlazo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub frmMsAhTipoAhorro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection, oPerif As New wrConta.wsLibContab
        Try
            If Me.pAccion = "Modificar" Then

                ds = oAhorro.ConsultarTipoAhorro("*", "CodTipoAhorro='" & pCodigo & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtCodigo.Text = pCodigo
                    txtCodigo.Enabled = False
                    txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    Me.c1nPlazo.Value = IIf(IsDBNull(Filas.Item(0)("Plazo")), 0, Filas.Item(0)("Plazo"))
                    Me.chkJunior.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("Junior")), "0", Filas.Item(0)("Junior")) = "1", True, False)
                    Me.txtCodCuenta.Value = IIf(IsDBNull(Filas.Item(0)("IdCuenta")), "", Filas.Item(0)("IdCuenta"))
                    If Trim(Me.txtCodCuenta.Text.Trim) <> "" Then
                        ds = oPerif.ObtenerCatContab("*", "Final='S' and IdCuenta='" & Me.txtCodCuenta.Text.Trim & "'", "idCuenta", sUsuario, sPassword, sSucursal)
                        Filas = ds.Tables("Catalogo").Rows()
                        If Filas.Count > 0 Then Me.txtCuenta.Value = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    End If
                End If
            End If
            txtCodigo.Focus()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            MetroButton1_Click(sender, e)
        End If
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, pCampos As String, pValores As String

        Select Case oAhorro.AutorizaDatos(Trim(txtCodigo.Text), Me.txtCodCuenta.Text.Trim, "x", "x", "x")
            Case 1
                MsgBox("El Código de Tipo de Ahorro no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                Exit Sub
            Case 2
                MsgBox("El Código de Cuenta Contable no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Ahorros")
                Exit Sub
        End Select
        Try
            If Me.pAccion = "Agregar" Then
                pCampos = "CodTipoAhorro,Descripcion,Plazo,Junior,IdCuenta"
                pValores = "'" & Trim(txtCodigo.Text) & "','" & Trim(txtDescripcion.Text) & "'," & Val(Me.c1nPlazo.Value) & ",'" & IIf(Me.chkJunior.Checked = True, "1", "0") & "','" & Me.txtCodCuenta.Value & "'"
                If oAhorro.InsertarTipoAhorro(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El tipo de Ahorro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            ElseIf Me.pAccion = "Modificar" Then
                pCampos = "Descripcion='" & Trim(txtDescripcion.Text) & "',Plazo=" & Val(Me.c1nPlazo.Value) & ",Junior='" & IIf(Me.chkJunior.Checked = True, "1", "0") & "',IdCuenta='" & Me.txtCodCuenta.Value & "'"
                If oAhorro.ModificarTipoAhorro(Trim(pCodigo), pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El tipo de Ahorro no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub txtCodCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCuenta.DoubleClick
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
            Me.txtCodCuenta.Value = ofrm.Resultado.Trim
            Me.txtCuenta.Value = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catalogo - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsAhTipoAhorro_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class