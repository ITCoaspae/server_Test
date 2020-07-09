Public Class frmMsMunicipios
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pCodDepto As String, pAccion As String
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodDpto As System.Windows.Forms.TextBox
    Friend WithEvents txtDpto As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtCodDpto = New System.Windows.Forms.TextBox()
        Me.txtDpto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtCodDpto
        '
        Me.txtCodDpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDpto.Location = New System.Drawing.Point(109, 60)
        Me.txtCodDpto.MaxLength = 2
        Me.txtCodDpto.Name = "txtCodDpto"
        Me.txtCodDpto.Size = New System.Drawing.Size(79, 20)
        Me.txtCodDpto.TabIndex = 97
        '
        'txtDpto
        '
        Me.txtDpto.BackColor = System.Drawing.Color.White
        Me.txtDpto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDpto.Location = New System.Drawing.Point(194, 60)
        Me.txtDpto.MaxLength = 30
        Me.txtDpto.Name = "txtDpto"
        Me.txtDpto.ReadOnly = True
        Me.txtDpto.Size = New System.Drawing.Size(265, 20)
        Me.txtDpto.TabIndex = 98
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Departamento:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(107, 112)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(352, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(109, 86)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(79, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Municipio"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Código:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(384, 138)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 167
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsMunicipios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(482, 194)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtDpto)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodDpto)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsMunicipios"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Municipios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub txtCodDpto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodDpto.KeyPress
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                oPerif = New wrAsociados.wsLibAsoc
                ds = oPerif.ConsultarDepartamentos("*", "CodDepartamento='" & Trim(txtCodDpto.Text) & "'", "CodDepartamento", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Departamento") Is DBNull.Value) Then
                        txtDpto.Text = CStr(Filas.Item(0)("Departamento"))
                    End If
                Else
                    txtCodDpto_DoubleClick(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Departamentos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodDpto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodDpto.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Departamentos"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarDepartamentos("*", "", "CodDepartamento", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodDpto.Text = ofrm.Resultado.Trim
            txtDpto.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Departamentos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsMunicipios_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection

        If Me.pAccion = "Modificar" Then

            ds = oAsoc.ConsultarMunicipios("*", "CodMunicipio='" & pCodigo & "' and CodDepartamento='" & pCodDepto & "'", "CodDepartamento,CodMunicipio", sUsuario, sPassword, sSucursal)

            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtCodigo.Text = pCodigo
                txtCodigo.Enabled = False
                txtCodDpto.Text = pCodDepto.Trim
                txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Municipio")), "", Filas.Item(0)("Municipio"))
                ds = oAsoc.ConsultarDepartamentos("*", "CodDepartamento='" & Trim(txtCodDpto.Text) & "'", "CodDepartamento", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Departamento") Is DBNull.Value) Then
                        txtDpto.Text = CStr(Filas.Item(0)("Departamento"))
                    End If
                End If
            End If

        End If
        txtCodigo.Focus()
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String

            Select Case oAsoc.AutorizaDatos(txtCodigo.Text.Trim, Me.txtCodDpto.Text.Trim, "x", "x", "x")
                Case 1
                    MsgBox("El Código del Municipio no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Municipios")
                    Exit Sub
                Case 2
                    MsgBox("El Código del Departamento no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Municipios")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "CodDepartamento,CodMunicipio,Municipio"
                pValores = "'" & txtCodDpto.Text.Trim & "','" & Trim(txtCodigo.Text) & "','" & Trim(txtDescripcion.Text) & "'"
                If oAsoc.InsertarMunicipios(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Municipio NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Municipios")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Municipio='" & Trim(txtDescripcion.Text) & "'"
                If oAsoc.ModificarMunicipios("CodMunicipio='" & Trim(pCodigo) & "' and CodDepartamento='" & pCodDepto.Trim & "'", pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Municipio no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Municipios")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



End Class
