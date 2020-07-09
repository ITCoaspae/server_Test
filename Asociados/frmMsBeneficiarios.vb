Public Class frmMsBeneficiarios
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pDui As String, pAccion As String
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNuevo1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents C1fGrdDetBeneficiarios As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtCodAntiguo As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsBeneficiarios))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnNuevo1 = New MetroFramework.Controls.MetroButton()
        Me.C1fGrdDetBeneficiarios = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodAntiguo = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1fGrdDetBeneficiarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnModificar1)
        Me.GroupBox1.Controls.Add(Me.btnNuevo1)
        Me.GroupBox1.Controls.Add(Me.C1fGrdDetBeneficiarios)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(32, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(668, 272)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Referencias"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(230, 22)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(105, 32)
        Me.btnEliminar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar.TabIndex = 130
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseSelectable = True
        Me.btnEliminar.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(119, 22)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(104, 32)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 129
        Me.btnModificar1.Text = "&Modificar"
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnNuevo1
        '
        Me.btnNuevo1.Location = New System.Drawing.Point(7, 22)
        Me.btnNuevo1.Name = "btnNuevo1"
        Me.btnNuevo1.Size = New System.Drawing.Size(105, 32)
        Me.btnNuevo1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnNuevo1.TabIndex = 128
        Me.btnNuevo1.Text = "&Nuevo"
        Me.btnNuevo1.UseSelectable = True
        Me.btnNuevo1.UseStyleColors = True
        '
        'C1fGrdDetBeneficiarios
        '
        Me.C1fGrdDetBeneficiarios.AllowEditing = False
        Me.C1fGrdDetBeneficiarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fGrdDetBeneficiarios.BackColor = System.Drawing.Color.White
        Me.C1fGrdDetBeneficiarios.ColumnInfo = "10,1,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fGrdDetBeneficiarios.ForeColor = System.Drawing.Color.Black
        Me.C1fGrdDetBeneficiarios.Location = New System.Drawing.Point(7, 61)
        Me.C1fGrdDetBeneficiarios.Name = "C1fGrdDetBeneficiarios"
        Me.C1fGrdDetBeneficiarios.Rows.Count = 2
        Me.C1fGrdDetBeneficiarios.Rows.DefaultSize = 22
        Me.C1fGrdDetBeneficiarios.Size = New System.Drawing.Size(651, 204)
        Me.C1fGrdDetBeneficiarios.StyleInfo = resources.GetString("C1fGrdDetBeneficiarios.StyleInfo")
        Me.C1fGrdDetBeneficiarios.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.txtDui)
        Me.GroupBox4.Controls.Add(Me.txtNombre)
        Me.GroupBox4.Controls.Add(Me.txtCodAntiguo)
        Me.GroupBox4.Controls.Add(Me.Label48)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.txtNoSocio)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(32, 73)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(668, 83)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Asociado"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(53, 18)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(144, 25)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(101, 48)
        Me.txtNombre.MaxLength = 10
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(557, 23)
        Me.txtNombre.TabIndex = 3
        '
        'txtCodAntiguo
        '
        Me.txtCodAntiguo.Location = New System.Drawing.Point(533, 18)
        Me.txtCodAntiguo.MaxLength = 10
        Me.txtCodAntiguo.Name = "txtCodAntiguo"
        Me.txtCodAntiguo.Size = New System.Drawing.Size(125, 23)
        Me.txtCodAntiguo.TabIndex = 2
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(420, 18)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(106, 19)
        Me.Label48.TabIndex = 114
        Me.Label48.Text = "Código Antiguo:"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(7, 18)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(39, 19)
        Me.Label31.TabIndex = 94
        Me.Label31.Text = "Dui:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.Location = New System.Drawing.Point(307, 18)
        Me.txtNoSocio.MaxLength = 8
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(106, 23)
        Me.txtNoSocio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(204, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "No. Asociado:"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(7, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(87, 20)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Asociado:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMsBeneficiarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(725, 511)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(702, 462)
        Me.Name = "frmMsBeneficiarios"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Beneficiarios"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.C1fGrdDetBeneficiarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub ActualizaGrid()
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As Data.DataSet = New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarBeneficiarios("*", "Dui='" & pDui & "'", "DUI", sUsuario, sPassword, sSucursal)
            C1fGrdDetBeneficiarios.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Beneficiarios" & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        C1fGrdDetBeneficiarios.Cols.Item(0).Width = 17
    End Sub

    Private Sub frmMsBeneficiarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        Try
            If Me.C1fGrdDetBeneficiarios.Row <> -1 Then
                btnModificar1.Enabled = True
                Me.btnEliminar.Enabled = True
            End If

            If Me.pAccion = "Modificar" Then

                ds = oAsoc.ConsultarAsociado("NoSocio,CodAntiguo,Apellido1,Apellido2,Nombres", "Dui='" & pDui & "'", "Dui", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtDui.Text = pDui
                    txtDui.Enabled = False
                    txtCodAntiguo.Enabled = False
                    txtNoSocio.Text = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))
                    txtCodAntiguo.Text = IIf(IsDBNull(Filas.Item(0)("CodAntiguo")), "", Filas.Item(0)("CodAntiguo"))
                    txtCodAntiguo.Enabled = False
                    txtNoSocio.Enabled = False
                    txtNombre.Text = CStr(Filas.Item(0)("Nombres")) & " " & CStr(Filas.Item(0)("Apellido1")) & " " & CStr(Filas.Item(0)("Apellido2"))
                    txtNombre.ReadOnly = True
                End If

            End If

            ds = oAsoc.ConsultarBeneficiarios("*", "Dui='" & pDui & "'", "Dui", sUsuario, sPassword, sSucursal)
            C1fGrdDetBeneficiarios.DataSource = ds.Tables(0)

        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub txtNoSocio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoSocio.TextChanged
        If txtNombre.Text.Trim = "" Then
            btnNuevo1.Enabled = False
        Else
            btnNuevo1.Enabled = True
        End If
    End Sub

    Private Sub txtCodAntiguo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodAntiguo.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                If txtCodAntiguo.Text.Trim = "" Then
                    txtCodAntiguo_DoubleClick(sender, e)
                Else
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                    ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "CodAntiguo='" & txtCodAntiguo.Text.Trim & "'", "DUI,CodAntiguo", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio"))
                        txtCodAntiguo.Text = IIf(IsDBNull(Filas.Item(0)("CodAntiguo")), "", Filas.Item(0)("CodAntiguo"))
                        txtDui.Text = CStr(Filas.Item(0)("DUI"))
                        pDui = Me.txtDui.Text.Trim
                        txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                    Else
                        txtNoSocio_DoubleClick(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodAntiguo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodAntiguo.DoubleClick

        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Asociados"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodAntiguo.Text = ofrm.Resultado3.Trim
            txtNoSocio.Text = ofrm.Resultado2.Trim
            txtDui.Text = ofrm.Resultado.Trim
            pDui = Me.txtDui.Text.Trim
            txtNombre.Text = ofrm.Resultado4.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtNoSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSocio.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                If txtNoSocio.Text.Trim = "" Then
                    txtNoSocio_DoubleClick(sender, e)
                Else
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                    ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "NoSocio='" & txtNoSocio.Text.Trim & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio"))
                        txtDui.Text = CStr(Filas.Item(0)("DUI"))
                        pDui = Me.txtDui.Text.Trim
                        txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                        txtCodAntiguo.Text = IIf(IsDBNull(Filas.Item(0)("CodAntiguo")), "", Filas.Item(0)("CodAntiguo"))
                    Else
                        txtNoSocio_DoubleClick(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNoSocio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoSocio.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Asociados"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtNoSocio.Text = ofrm.Resultado2.Trim
            txtDui.Text = ofrm.Resultado.Trim
            pDui = Me.txtDui.Text.Trim
            txtNombre.Text = ofrm.Resultado4.Trim
            txtCodAntiguo.Text = ofrm.Resultado3
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNombre.TextChanged
        If txtNombre.Text.Trim = "" Then
            btnNuevo1.Enabled = False
        Else
            btnNuevo1.Enabled = True
        End If
    End Sub

    Private Sub txtDui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.Click
        Try
            Dim Valor As String
            Valor = IIf(txtDui.ValueIsDbNull, "", txtDui.Value)
            If Valor.Trim = "" Then
                Me.txtDui.SelectionStart = 0
                Me.txtDui.SelectionLength = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text.Trim = "" Then Exit Sub
        pDui = Me.txtDui.Text.Trim
        Try
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "Dui='" & txtDui.Text.Trim & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio")).Trim
                txtDui.Text = CStr(Filas.Item(0)("DUI")).Trim
                pDui = Me.txtDui.Text.Trim
                txtNombre.Text = CStr(Filas.Item(0)("Nombre")).Trim
                txtCodAntiguo.Text = IIf(IsDBNull(Filas.Item(0)("CodAntiguo")), "", Filas.Item(0)("CodAntiguo"))
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Asociados"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtNoSocio.Text = ofrm.Resultado2.Trim
            txtDui.Text = ofrm.Resultado.Trim
            pDui = Me.txtDui.Text.Trim
            txtNombre.Text = ofrm.Resultado4.Trim
            txtCodAntiguo.Text = ofrm.Resultado3
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNuevo1_Click(sender As Object, e As EventArgs) Handles btnNuevo1.Click
        Dim frm As frmMsDetBeneficiarios = New frmMsDetBeneficiarios
        frm.pDui = Trim(txtDui.Text)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
        ActualizaGrid()
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        If C1fGrdDetBeneficiarios.Row <> -1 Then
            Dim frm As frmMsDetBeneficiarios = New frmMsDetBeneficiarios
            frm.pDui = pDui
            frm.pCorrelativo = C1fGrdDetBeneficiarios.Item(C1fGrdDetBeneficiarios.Row, "Correlativo")
            frm.btnGuardar1.Text = "&Modificar"
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If C1fGrdDetBeneficiarios.Row <> -1 Then
                If MsgBox("¿Desea eliminar el Beneficiario No. " & C1fGrdDetBeneficiarios.Item(C1fGrdDetBeneficiarios.Row, "Correlativo") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Beneficiarios") = MsgBoxResult.Yes Then
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
                    oAsoc.EliminarBeneficiarios("Correlativo=" & C1fGrdDetBeneficiarios.Item(C1fGrdDetBeneficiarios.Row, "Correlativo") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGrid()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDui_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.TextChanged
        If txtNombre.Text.Trim = "" Then
            btnNuevo1.Enabled = False
        Else
            btnNuevo1.Enabled = True
        End If
    End Sub

    Private Sub frmMsBeneficiarios_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
