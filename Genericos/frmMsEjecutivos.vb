Public Class frmMsEjecutivos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pAccion As String
    Friend WithEvents chkComision As System.Windows.Forms.CheckBox
    Friend WithEvents cbSucursales As System.Windows.Forms.ComboBox
    Friend WithEvents lblSucursal As System.Windows.Forms.Label
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private Planilla As New wrPlanilla.wsLibPlanilla
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
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodEmpleado As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.chkComision = New System.Windows.Forms.CheckBox()
        Me.cbSucursales = New System.Windows.Forms.ComboBox()
        Me.lblSucursal = New System.Windows.Forms.Label()
        Me.txtCodEmpleado = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(186, 53)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(56, 17)
        Me.chkEstado.TabIndex = 84
        Me.chkEstado.Text = "Activo"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'chkComision
        '
        Me.chkComision.AutoSize = True
        Me.chkComision.Location = New System.Drawing.Point(248, 53)
        Me.chkComision.Name = "chkComision"
        Me.chkComision.Size = New System.Drawing.Size(116, 17)
        Me.chkComision.TabIndex = 83
        Me.chkComision.Text = "Comisión Gerencial"
        Me.chkComision.UseVisualStyleBackColor = True
        '
        'cbSucursales
        '
        Me.cbSucursales.BackColor = System.Drawing.Color.White
        Me.cbSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSucursales.FormattingEnabled = True
        Me.cbSucursales.Location = New System.Drawing.Point(88, 105)
        Me.cbSucursales.Name = "cbSucursales"
        Me.cbSucursales.Size = New System.Drawing.Size(398, 21)
        Me.cbSucursales.TabIndex = 82
        '
        'lblSucursal
        '
        Me.lblSucursal.AutoSize = True
        Me.lblSucursal.Location = New System.Drawing.Point(23, 108)
        Me.lblSucursal.Name = "lblSucursal"
        Me.lblSucursal.Size = New System.Drawing.Size(51, 13)
        Me.lblSucursal.TabIndex = 81
        Me.lblSucursal.Text = "Sucursal:"
        '
        'txtCodEmpleado
        '
        Me.txtCodEmpleado.BackColor = System.Drawing.Color.White
        Me.txtCodEmpleado.Location = New System.Drawing.Point(88, 79)
        Me.txtCodEmpleado.MaxLength = 10
        Me.txtCodEmpleado.Name = "txtCodEmpleado"
        Me.txtCodEmpleado.Size = New System.Drawing.Size(92, 20)
        Me.txtCodEmpleado.TabIndex = 80
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.Location = New System.Drawing.Point(186, 79)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(300, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(88, 53)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(92, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Empleado:"
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
        Me.btnGuardar1.Location = New System.Drawing.Point(411, 132)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 164
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsEjecutivos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(507, 188)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.chkEstado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.cbSucursales)
        Me.Controls.Add(Me.chkComision)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodEmpleado)
        Me.Controls.Add(Me.lblSucursal)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsEjecutivos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Ejecutivos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmMsEjecutivos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        Me.cbSucursales.DisplayMember = "NOM_SUCURSAL"
        Me.cbSucursales.ValueMember = "CODSUCURSAL"
        LlenarSucursales()
        If Me.pAccion = "Modificar" Then

            ds = oAsoc.ConsultarEjecutivosMercadeoxNombre(pCodigo, sUsuario, sPassword, sSucursal)

            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtCodigo.Text = pCodigo
                txtCodigo.Enabled = False
                txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres"))
                Me.cbSucursales.SelectedValue = IIf(IsDBNull(Filas.Item(0)("CodSucursal")), "", Filas.Item(0)("CodSucursal"))
                Me.chkComision.Checked = IIf(IsDBNull(Filas.Item(0)("ComisionGerenciales")), False, Filas.Item(0)("ComisionGerenciales"))
                Me.txtCodEmpleado.Text = IIf(IsDBNull(Filas.Item(0)("CodEmpleado")), "", Filas.Item(0)("CodEmpleado"))
                Me.chkEstado.Checked = IIf(IsDBNull(Filas.Item(0)("Estado")), False, Filas.Item(0)("Estado"))
            End If

        End If
        txtCodigo.Focus()
    End Sub


    Private Sub txtCodEmpleado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEmpleado.DoubleClick
        Dim ds As New Data.DataSet
        Dim sResultado1 As String, sResultado2 As String
        Dim ofrm As New frmAGenerico
        Dim oPlan As New wrPlanilla.wsLibPlanilla

        Try
            ofrm.Text = "Buscar Empleado por Código"
            ds = oPlan.ConsultarPLEmpleado("DUI,CodEmpleado,Apellido1,Apellido2,Nombres", "CodEmpleado like '" & Me.txtCodEmpleado.Text.Trim & "%'", "DUI", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodEmpleado.Text = ofrm.Resultado2
            Me.txtDescripcion.Text = ofrm.Resultado5 & " " & ofrm.Resultado3 & " " & ofrm.Resultado4
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtCodEmpleado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodEmpleado.Validating

        Dim oPlan As New wrPlanilla.wsLibPlanilla

        If Me.btnGuardar1.Text = "&Guardar" Then
            Try
                If Me.txtCodEmpleado.Text.Trim <> "" Then
                    Dim ds As New Data.DataSet
                    Dim Filas As Data.DataRowCollection
                    ds = oPlan.ConsultarPLEmpleado("*", "CodEmpleado LIKE '" & Trim(Me.txtCodEmpleado.Text) & "'", "CodEmpleado", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count <= 0 Then
                    Else
                        Filas = ds.Tables(0).Rows()
                        Me.txtCodEmpleado.Text = CStr(Filas.Item(0)("CodEmpleado")).Trim
                        Me.txtDescripcion.Text = CStr(Filas.Item(0)("Nombres")).Trim & " " & CStr(Filas.Item(0)("Apellido1")).Trim & ", " & CStr(Filas.Item(0)("Apellido2")).Trim
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String

            Select Case oAsoc.AutorizaDatos(Trim(txtCodigo.Text), txtCodEmpleado.Text.Trim, "x", "x", "x")
                Case 1
                    MsgBox("El Código del Ejecutivo no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Ejecutivos")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "CodEjecMercadeo,CodEmpleado,CodSucursal,ComisionGerenciales,Estado"
                pValores = "'" & Trim(txtCodigo.Text) &
                "','" & Trim(txtCodEmpleado.Text) &
                "','" & Me.cbSucursales.SelectedValue.ToString &
                "','" & Me.chkComision.Checked &
                "','" & Me.chkEstado.Checked & "'"
                If oAsoc.InsertarEjecutivosMercadeo(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Registro ingresado exitosamente", MsgBoxStyle.Information, "Módulo Ejecutivos")
                    Me.Dispose()
                Else
                    MsgBox("El Ejecutivo NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ejecutivos")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "CodEmpleado='" & Trim(txtCodEmpleado.Text) &
                "',CodSucursal ='" & Me.cbSucursales.SelectedValue &
                "',ComisionGerenciales = '" & Me.chkComision.Checked &
                "',Estado = '" & Me.chkEstado.Checked & "'"
                If oAsoc.ModificarEjecutivosMercadeo("CodEjecMercadeo='" & Trim(pCodigo) & "'", pCampos, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Registro modificado exitosamente", MsgBoxStyle.Information, "Módulo Ejecutivos")
                    Me.Dispose()
                Else
                    MsgBox("El Ejecutivo no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ejecutivos")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LlenarSucursales()
        Dim Dts As New DataSet
        Dts = Planilla.Consultar_Sucursales()
        Me.cbSucursales.DataSource = Dts.Tables(0)
    End Sub

End Class
