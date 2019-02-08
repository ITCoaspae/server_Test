Public Class frmMPLEmpleados
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents chkNombres As System.Windows.Forms.CheckBox
    Friend WithEvents chkDUI As System.Windows.Forms.CheckBox
    Friend WithEvents chkCodEmpleado As System.Windows.Forms.CheckBox
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Private oPlan As wrPlanilla.wsLibPlanilla = New wrPlanilla.wsLibPlanilla

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) '' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodempleado As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents cbNombres As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMPLEmpleados))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.chkEstado = New System.Windows.Forms.CheckBox()
        Me.chkNombres = New System.Windows.Forms.CheckBox()
        Me.chkDUI = New System.Windows.Forms.CheckBox()
        Me.chkCodEmpleado = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.cbNombres = New System.Windows.Forms.ComboBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtCodempleado = New System.Windows.Forms.TextBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.chkEstado)
        Me.GroupBox2.Controls.Add(Me.chkNombres)
        Me.GroupBox2.Controls.Add(Me.chkDUI)
        Me.GroupBox2.Controls.Add(Me.chkCodEmpleado)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.txtNombres)
        Me.GroupBox2.Controls.Add(Me.cbNombres)
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.txtCodempleado)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(559, 147)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar datos de empleados:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(469, 101)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 96
        Me.btnMostrar1.Text = "Buscar"
        Me.btnMostrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Location = New System.Drawing.Point(16, 102)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(59, 17)
        Me.chkEstado.TabIndex = 14
        Me.chkEstado.Text = "&Estado"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'chkNombres
        '
        Me.chkNombres.AutoSize = True
        Me.chkNombres.Location = New System.Drawing.Point(16, 71)
        Me.chkNombres.Name = "chkNombres"
        Me.chkNombres.Size = New System.Drawing.Size(68, 17)
        Me.chkNombres.TabIndex = 13
        Me.chkNombres.Text = "&Nombres"
        Me.chkNombres.UseVisualStyleBackColor = True
        '
        'chkDUI
        '
        Me.chkDUI.AutoSize = True
        Me.chkDUI.Location = New System.Drawing.Point(16, 48)
        Me.chkDUI.Name = "chkDUI"
        Me.chkDUI.Size = New System.Drawing.Size(45, 17)
        Me.chkDUI.TabIndex = 12
        Me.chkDUI.Text = "&DUI"
        Me.chkDUI.UseVisualStyleBackColor = True
        '
        'chkCodEmpleado
        '
        Me.chkCodEmpleado.AutoSize = True
        Me.chkCodEmpleado.Location = New System.Drawing.Point(16, 25)
        Me.chkCodEmpleado.Name = "chkCodEmpleado"
        Me.chkCodEmpleado.Size = New System.Drawing.Size(123, 17)
        Me.chkCodEmpleado.TabIndex = 11
        Me.chkCodEmpleado.Text = "&Código de empleado"
        Me.chkCodEmpleado.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Items.AddRange(New Object() {"Activo", "Retirado"})
        Me.ComboBox1.Location = New System.Drawing.Point(145, 102)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(152, 21)
        Me.ComboBox1.TabIndex = 10
        '
        'txtNombres
        '
        Me.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombres.Location = New System.Drawing.Point(303, 75)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(241, 20)
        Me.txtNombres.TabIndex = 6
        '
        'cbNombres
        '
        Me.cbNombres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNombres.Items.AddRange(New Object() {"Apellido 1", "Apellido 2", "Nombres"})
        Me.cbNombres.Location = New System.Drawing.Point(145, 75)
        Me.cbNombres.Name = "cbNombres"
        Me.cbNombres.Size = New System.Drawing.Size(152, 21)
        Me.cbNombres.TabIndex = 5
        '
        'txtDui
        '
        Me.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(145, 49)
        Me.txtDui.MaxLength = 20
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(92, 20)
        Me.txtDui.TabIndex = 3
        Me.txtDui.Tag = Nothing
        '
        'txtCodempleado
        '
        Me.txtCodempleado.Location = New System.Drawing.Point(145, 23)
        Me.txtCodempleado.MaxLength = 20
        Me.txtCodempleado.Name = "txtCodempleado"
        Me.txtCodempleado.Size = New System.Drawing.Size(92, 20)
        Me.txtCodempleado.TabIndex = 1
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "40,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(23, 250)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Size = New System.Drawing.Size(561, 174)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 38
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 216)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 99
        Me.btnImp.Text = "Consultar"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 216)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 98
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 216)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 97
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 216)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 96
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'frmMPLEmpleados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(607, 489)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmMPLEmpleados"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Empleados"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Sub Encabezado()

        fg.Cols.Item(1).Caption = "Código"
        fg.Cols.Item(2).Caption = "Apellido1"
        fg.Cols.Item(3).Caption = "Apellido2"
        fg.Cols.Item(4).Caption = "Apellido Casada"
        fg.Cols.Item(5).Caption = "Nombres"
        fg.Cols.Item(6).Caption = "Sexo"
        fg.Cols.Item(7).Caption = "Fecha Ingreso"
        fg.Cols.Item(8).Caption = "Estado Civil"
        fg.Cols.Item(9).Caption = "Cód.Cargo"
        fg.Cols.Item(10).Caption = "Tipo_Emp"
        fg.Cols.Item(11).Caption = "Fecha Retiro"
        fg.Cols.Item(12).Caption = "Fec. Nacimiento"
        fg.Cols.Item(13).Caption = "Lug. Nacimiento"
        fg.Cols.Item(14).Caption = "DUI"
        fg.Cols.Item(15).Caption = "Fecha Ext-DUI"
        fg.Cols.Item(16).Caption = "Lugar Ext-DUI"
        fg.Cols.Item(17).Caption = "NIT"
        fg.Cols.Item(18).Caption = "NIP"
        fg.Cols.Item(19).Caption = "Forma Pago"
        fg.Cols.Item(20).Caption = "Código Institución"
        fg.Cols.Item(21).Caption = "No Cuenta"
        fg.Cols.Item(22).Caption = "ISSS"
        fg.Cols.Item(23).Caption = "Dirección"
        fg.Cols.Item(24).Caption = "Teléfonos"
        fg.Cols.Item(25).Caption = "Celular"
        fg.Cols.Item(26).Caption = "Apellido Materno"
        fg.Cols.Item(27).Caption = "Apellido Paterno"
        fg.Cols.Item(28).Caption = "Nombre Según ISSS"
        fg.Cols.Item(29).Caption = "Código AFP"
        fg.Cols.Item(30).Caption = "No AFP"
        fg.Cols.Item(31).Caption = "Seguro Colectivo"
        fg.Cols.Item(32).Caption = "Estado"

        fg.Cols.Item(0).Width = 20
        fg.Cols.Item(1).Width = 60
        fg.Cols.Item(2).Width = 100
        fg.Cols.Item(3).Width = 100
        fg.Cols.Item(4).Width = 90
        fg.Cols.Item(5).Width = 150
        fg.Cols.Item(6).Width = 50
        fg.Cols.Item(7).Width = 90
        fg.Cols.Item(8).Width = 80
        fg.Cols.Item(9).Width = 70
        fg.Cols.Item(10).Width = 60
        fg.Cols.Item(11).Width = 100
        fg.Cols.Item(12).Width = 100
        fg.Cols.Item(13).Width = 200
        fg.Cols.Item(14).Width = 75
        fg.Cols.Item(15).Width = 100
        fg.Cols.Item(16).Width = 200
        fg.Cols.Item(17).Width = 120
        fg.Cols.Item(18).Width = 100
        fg.Cols.Item(19).Width = 100
        fg.Cols.Item(20).Width = 100
        fg.Cols.Item(21).Width = 100
        fg.Cols.Item(22).Width = 100
        fg.Cols.Item(23).Width = 350
        fg.Cols.Item(24).Width = 100
        fg.Cols.Item(25).Width = 100
        fg.Cols.Item(26).Width = 150
        fg.Cols.Item(27).Width = 150
        fg.Cols.Item(28).Width = 200
        fg.Cols.Item(29).Width = 100
        fg.Cols.Item(30).Width = 100
        fg.Cols.Item(31).Width = 100
        fg.Cols.Item(32).Width = 75

    End Sub

    Public Sub ActualizaGrid()
        Try
            Dim ds As New Data.DataSet, pFiltro As String
            Dim Bandera As Boolean
            Bandera = False
            pFiltro = ""
            If Me.chkCodEmpleado.Checked = True Then
                If Bandera = True Then
                    pFiltro += " And "
                End If
                pFiltro += "CodEmpleado LIKE'" & Trim(Me.txtCodempleado.Text) & "%'"
                Bandera = True
            End If
            If Me.chkDUI.Checked = True Then
                If Bandera = True Then
                    pFiltro += " And "
                End If
                pFiltro += "DUI LIKE'" & Trim(Me.txtDui.Text) & "%'"
                Bandera = True
            End If
            If Me.chkEstado.Checked = True Then
                Dim ESTADO As String
                If ComboBox1.SelectedIndex = 0 Then
                    ESTADO = "A"
                Else
                    ESTADO = "R"
                End If
                If Bandera = True Then
                    pFiltro += " And "
                End If
                pFiltro += "ESTADO='" & ESTADO & "'"
                Bandera = True
            End If
            If Me.chkNombres.Checked = True Then
                If Bandera = True Then
                    pFiltro += " And "
                End If
                If cbNombres.SelectedIndex = 0 Then
                    pFiltro += "Apellido1 like '" & Trim(txtNombres.Text) & "%'"
                ElseIf cbNombres.SelectedIndex = 1 Then
                    pFiltro += "Apellido2 like '" & Trim(txtNombres.Text) & "%'"
                ElseIf cbNombres.SelectedIndex = 2 Then
                    pFiltro += "Nombres like '" & Trim(txtNombres.Text) & "%'"
                End If
                Bandera = True
            End If

            ds = oPlan.ConsultarPLEmpleado("*", pFiltro, "CodEmpleado", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub frmMPLEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Encabezado()

    End Sub

#Region "Funciones eliminadas"
    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub
#End Region


    Private Sub rbtCodEmpleado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtDui.Focus()
    End Sub

    Private Sub rbtDUI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.txtCodempleado.Focus()
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

    Private Sub txtCodempleado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodempleado.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click(sender, e)
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar_Click(sender, e)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim ofrm As New frmMsEmpleados
            ofrm.vAccion = "Agregar"
            ofrm.btnGuardar1.Text = "&Guardar"
            ofrm.StartPosition = FormStartPosition.CenterScreen
            ofrm.ShowDialog()
            ActualizaGrid()
            Encabezado()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            Dim ofrm As New frmMsEmpleados, x As Integer
            Dim ds As New Data.DataSet
            Dim dr As DataRow
            If fg.Row <> -1 Then
                ofrm.vAccion = "Modificar"
                ofrm.btnGuardar1.Text = "&Modificar"
                ds = oPlan.ConsultarPLEmpleado("*", "CodEmpleado='" & Trim(fg.Item(fg.Row, "CodEmpleado")) & "'", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.txtCodEmpleado.Text = dr("CodEmpleado")
                ofrm.txtCodEmpleado.ReadOnly = True
                ofrm.txtApe2.Text = IIf(IsDBNull(dr("Apellido2")), " ", dr("Apellido2"))
                ofrm.txtApe1.Text = IIf(IsDBNull(dr("Apellido1")), " ", dr("Apellido1"))
                ofrm.txtApeCas.Text = IIf(IsDBNull(dr("ApellidoCas")), " ", dr("ApellidoCas"))
                ofrm.txtNombres.Text = IIf(IsDBNull(dr("Nombres")), " ", dr("Nombres"))
                If dr("Sexo") = "F" Then
                    ofrm.cboSexo.SelectedIndex = 0
                Else
                    ofrm.cboSexo.SelectedIndex = 1
                End If
                ofrm.dtpFecIng.Value = dr("FechaIngreso")
                ofrm.cbEstadoCivil.SelectedIndex = dr("EstadoCivil")
                ofrm.txtCodCargo.Text = IIf(IsDBNull(dr("CodCargo")), " ", dr("CodCargo"))
                ofrm.txtTipoEmpleado.Text = IIf(IsDBNull(dr("CodTipoPersonal")), " ", dr("CodTipoPersonal"))
                ofrm.txtCodRetiro.Text = IIf(IsDBNull(dr("CodRetiro")), " ", dr("CodRetiro"))
                If IsDBNull(dr("FechaRetiro")) = False Then ofrm.dtpFecRetiro.Value = dr("FechaRetiro")
                If IsDBNull(dr("FechaNac")) = False Then ofrm.dtpFecNac.Value = dr("FechaNac")
                ofrm.txtLugarNac.Text = IIf(IsDBNull(dr("LugarNac")), " ", dr("LugarNac"))
                ofrm.txtDui.Value = IIf(IsDBNull(dr("DUI")), " ", dr("DUI"))
                ofrm.dtpFecExtDUI.Value = IIf(IsDBNull(dr("FechaExtDUI")), " ", dr("FechaExtDUI"))
                ofrm.txtLugarExtDUI.Text = IIf(IsDBNull(dr("LugarExtDUI")), " ", dr("LugarExtDUI"))
                ofrm.txtNit.Value = IIf(IsDBNull(dr("NIT")), " ", dr("NIT"))
                ofrm.txtNIP.Text = IIf(IsDBNull(dr("NIP")), " ", dr("NIP"))
                ofrm.cbFormaPago.SelectedIndex = IIf(IsDBNull(dr("FormaPago")), " ", dr("FormaPago"))
                ofrm.txtCodInstitucion.Text = IIf(IsDBNull(dr("CodInstitucion")), " ", dr("CodInstitucion"))
                ofrm.txtNoCuenta.Text = IIf(IsDBNull(dr("NoCuenta")), " ", dr("NoCuenta"))
                ofrm.txtISSS.Text = IIf(IsDBNull(dr("ISSS")), " ", dr("ISSS"))
                ofrm.txtDireccion.Text = IIf(IsDBNull(dr("Direccion")), " ", dr("Direccion"))
                ofrm.txtTelefonos.Text = IIf(IsDBNull(dr("Telefonos")), " ", dr("Telefonos"))
                ofrm.txtCelular.Text = IIf(IsDBNull(dr("Celular")), " ", dr("Celular"))
                ofrm.txtApeMaterno.Text = IIf(IsDBNull(dr("Ap_Materno")), " ", dr("Ap_Materno"))
                ofrm.txtApePaterno.Text = IIf(IsDBNull(dr("Ap_Paterno")), " ", dr("Ap_Paterno"))
                ofrm.txtNombreISSS.Text = IIf(IsDBNull(dr("Nombre_ISSS")), " ", dr("Nombre_ISSS"))
                ofrm.txtCodAFP.Text = IIf(IsDBNull(dr("CodPension")), " ", dr("CodPension"))
                ofrm.txtNoAFP.Text = IIf(IsDBNull(dr("NoAFP")), " ", dr("NoAFp"))
                ofrm.txtEmail.Text = IIf(IsDBNull(dr("Email")), " ", dr("Email"))

                ofrm.chkISSS.Checked = IIf(IsDBNull(dr("DescISSS")), False, dr("DescISSS"))
                ofrm.chkAFP.Checked = IIf(IsDBNull(dr("DescAFP")), False, dr("DescAFP"))
                ofrm.chkRenta.Checked = IIf(IsDBNull(dr("DescRenta")), False, dr("DescRenta"))


                If dr("SeguroColectivo") = "S" Then
                    ofrm.chkSeguro.Checked = True
                Else
                    ofrm.chkSeguro.Checked = False
                End If
                If dr("Estado") = "A" Then
                    ofrm.chkEstado.Checked = False
                ElseIf dr("Estado") = "R" Then
                    ofrm.chkEstado.Checked = True
                End If
                ofrm.txtGradoAcademico.Text = IIf(IsDBNull(dr("GradoAcademico")), " ", dr("GradoAcademico"))
                If dr("Estado") = "A" Then
                    ofrm.chkEstado.Checked = False
                    ofrm.txtEstatus.Text = "Estado: Activo"
                ElseIf dr("Estado") = "R" Then
                    ofrm.txtEstatus.Text = "Estado: Inactivo"
                    ofrm.chkEstado.Checked = True
                End If
                If IsDBNull(dr("PoseeLic")) = False Then
                    If CStr(dr("PoseeLic")).Trim = "1" Then
                        ofrm.chkLicencia.Checked = True
                    Else
                        ofrm.chkLicencia.Checked = False
                    End If
                End If
                Dim dsTemp, dsSuc As New DataSet, drTemp As DataRow
                dsTemp = oPlan.ConsultarPLGradoAcademico("*", "", "CodGrado", sUsuario, sPassword, sSucursal)

                dsSuc = oPlan.Consultar_Sucursales()
                ofrm.cbSucursal.DisplayMember = "NOM_SUCURSAl"
                ofrm.cbSucursal.ValueMember = "CODSUCURSAL"
                ofrm.cbSucursal.DataSource = dsSuc.Tables(0)
                ofrm.cbSucursal.SelectedValue = IIf(IsDBNull(dr("CODSUCURSAL")), " ", dr("CODSUCURSAL"))

                For Each drTemp In dsTemp.Tables(0).Rows
                    ofrm.cbGradoAcademico.Items.Add(CStr(drTemp("CodGrado")).Trim & " - " & CStr(drTemp("Descripcion")).Trim)
                Next
                For x = 0 To ofrm.cbGradoAcademico.Items.Count - 1
                    ofrm.cbGradoAcademico.SelectedIndex = x
                    If Mid(ofrm.cbGradoAcademico.Text, 1, 2).Trim = Trim(IIf(IsDBNull(dr("CodGrado")), "", dr("CodGrado"))) Then
                        ofrm.cbGradoAcademico.SelectedIndex = x
                        Exit For
                    End If
                Next

                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                ActualizaGrid()
                Encabezado()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If fg.Row <> -1 Then
                If MsgBox("¿Esta seguro que desea eliminar el empleado?", MsgBoxStyle.OkCancel, "Módulo - Planilla") = MsgBoxResult.Ok Then
                    oPlan.EliminarPLEmpleado("'" & Trim(fg.Item(fg.Row, "CodEmpleado")) & "'", sUsuario, sPassword, sSucursal)
                    Me.btnMostrar1.Focus()
                End If
                ActualizaGrid()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            Dim ofrm As New frmMsEmpleados, x As Integer
            Dim ds As New Data.DataSet
            Dim dr As DataRow
            If fg.Row <> -1 Then
                ofrm.vAccion = "Modificar"
                ofrm.btnGuardar1.Text = "&Modificar"
                ds = oPlan.ConsultarPLEmpleado("*", "CodEmpleado='" & Trim(fg.Item(fg.Row, "CodEmpleado")) & "'", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                ofrm.txtCodEmpleado.Text = dr("CodEmpleado")
                ofrm.txtCodEmpleado.ReadOnly = True
                ofrm.txtApe1.Text = dr("Apellido1")
                ofrm.txtApe2.Text = dr("Apellido2")
                ofrm.txtApeCas.Text = dr("ApellidoCas")
                ofrm.txtNombres.Text = dr("Nombres")
                If dr("Sexo") = "F" Then
                    ofrm.cboSexo.SelectedIndex = 0
                Else
                    ofrm.cboSexo.SelectedIndex = 1
                End If
                ofrm.dtpFecIng.Value = dr("FechaIngreso")
                ofrm.cbEstadoCivil.SelectedIndex = dr("EstadoCivil")
                ofrm.txtCodCargo.Text = dr("CodCargo")
                ofrm.txtTipoEmpleado.Text = dr("CodTipoPersonal")
                ofrm.txtCodRetiro.Text = dr("CodRetiro")
                If IsDBNull(dr("FechaRetiro")) = False Then ofrm.dtpFecRetiro.Value = dr("FechaRetiro")
                ofrm.dtpFecNac.Value = dr("FechaNac")
                ofrm.txtLugarNac.Text = dr("LugarNac")
                ofrm.txtDui.Value = dr("DUI")
                ofrm.dtpFecExtDUI.Value = dr("FechaExtDUI")
                ofrm.txtLugarExtDUI.Text = dr("LugarExtDUI")
                ofrm.txtNit.Value = dr("NIT")
                ofrm.txtNIP.Text = dr("NIP")
                ofrm.cbFormaPago.SelectedIndex = dr("FormaPago")
                ofrm.txtCodInstitucion.Text = dr("CodInstitucion")
                ofrm.txtNoCuenta.Text = dr("NoCuenta")
                ofrm.txtISSS.Text = dr("ISSS")
                ofrm.txtDireccion.Text = dr("Direccion")
                ofrm.txtTelefonos.Text = dr("Telefonos")
                ofrm.txtCelular.Text = dr("Celular")
                ofrm.txtApeMaterno.Text = dr("Ap_Materno")
                ofrm.txtApePaterno.Text = dr("Ap_Paterno")
                ofrm.txtNombreISSS.Text = dr("Nombre_ISSS")
                ofrm.txtCodAFP.Text = dr("CodPension")
                ofrm.txtNoAFP.Text = dr("NoAFP")
                ofrm.txtEmail.Text = IIf(IsDBNull(dr("Email")), " ", dr("Email"))
                If dr("SeguroColectivo") = "S" Then
                    ofrm.chkSeguro.Checked = True
                Else
                    ofrm.chkSeguro.Checked = False
                End If
                If dr("Estado") = "A" Then
                    ofrm.chkEstado.Checked = False
                ElseIf dr("Estado") = "R" Then
                    ofrm.chkEstado.Checked = True
                End If
                ofrm.txtGradoAcademico.Text = dr("GradoAcademico")
                If dr("Estado") = "A" Then
                    ofrm.chkEstado.Checked = False
                    ofrm.txtEstatus.Text = "Estado: Activo"
                ElseIf dr("Estado") = "R" Then
                    ofrm.txtEstatus.Text = "Estado: Inactivo"
                    ofrm.chkEstado.Checked = True
                End If
                If IsDBNull(dr("PoseeLic")) = False Then
                    If CStr(dr("PoseeLic")).Trim = "1" Then
                        ofrm.chkLicencia.Checked = True
                    Else
                        ofrm.chkLicencia.Checked = False
                    End If
                End If
                Dim dsTemp As New DataSet, drTemp As DataRow
                dsTemp = oPlan.ConsultarPLGradoAcademico("*", "", "CodGrado", sUsuario, sPassword, sSucursal)
                For Each drTemp In dsTemp.Tables(0).Rows
                    ofrm.cbGradoAcademico.Items.Add(CStr(drTemp("CodGrado")).Trim & " - " & CStr(drTemp("Descripcion")).Trim)
                Next
                For x = 0 To ofrm.cbGradoAcademico.Items.Count - 1
                    ofrm.cbGradoAcademico.SelectedIndex = x
                    If Mid(ofrm.cbGradoAcademico.Text, 1, 2).Trim = Trim(IIf(IsDBNull(dr("CodGrado")), "", dr("CodGrado"))) Then
                        ofrm.cbGradoAcademico.SelectedIndex = x
                        Exit For
                    End If
                Next
                ofrm.btnGuardar1.Visible = False
                ofrm.cbEstadoCivil.Enabled = False
                ofrm.cbFormaPago.Enabled = False
                ofrm.cboSexo.Enabled = False
                ofrm.StartPosition = FormStartPosition.CenterScreen
                ofrm.ShowDialog()
                ActualizaGrid()
                Encabezado()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Try
            ActualizaGrid()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub



End Class