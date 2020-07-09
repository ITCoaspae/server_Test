Public Class frmMsReferencia
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pDui As String, pAccion As String
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNuevo As MetroFramework.Controls.MetroButton

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents fgDetRef As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodAntiguo As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsReferencia))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New MetroFramework.Controls.MetroButton()
        Me.btnModificar = New MetroFramework.Controls.MetroButton()
        Me.btnNuevo = New MetroFramework.Controls.MetroButton()
        Me.fgDetRef = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtCodAntiguo = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fgDetRef, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.fgDetRef)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(28, 181)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(729, 277)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Referencias"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(202, 28)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(90, 32)
        Me.btnEliminar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar.TabIndex = 45
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseSelectable = True
        Me.btnEliminar.UseStyleColors = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(104, 28)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(90, 32)
        Me.btnModificar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar.TabIndex = 44
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseSelectable = True
        Me.btnModificar.UseStyleColors = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(7, 28)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(90, 32)
        Me.btnNuevo.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnNuevo.TabIndex = 43
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseSelectable = True
        Me.btnNuevo.UseStyleColors = True
        '
        'fgDetRef
        '
        Me.fgDetRef.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgDetRef.ColumnInfo = "10,1,0,0,0,110,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgDetRef.ForeColor = System.Drawing.Color.Black
        Me.fgDetRef.Location = New System.Drawing.Point(7, 67)
        Me.fgDetRef.Name = "fgDetRef"
        Me.fgDetRef.Rows.DefaultSize = 22
        Me.fgDetRef.Size = New System.Drawing.Size(691, 175)
        Me.fgDetRef.StyleInfo = resources.GetString("fgDetRef.StyleInfo")
        Me.fgDetRef.TabIndex = 5
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.txtDui)
        Me.GroupBox4.Controls.Add(Me.txtCodAntiguo)
        Me.GroupBox4.Controls.Add(Me.Label48)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.txtNoSocio)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtNombre)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(729, 101)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Datos del Asociado"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(67, 28)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(144, 24)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'txtCodAntiguo
        '
        Me.txtCodAntiguo.Location = New System.Drawing.Point(557, 28)
        Me.txtCodAntiguo.MaxLength = 10
        Me.txtCodAntiguo.Name = "txtCodAntiguo"
        Me.txtCodAntiguo.Size = New System.Drawing.Size(125, 23)
        Me.txtCodAntiguo.TabIndex = 2
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(451, 28)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(106, 18)
        Me.Label48.TabIndex = 114
        Me.Label48.Text = "Código Antiguo:"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(29, 28)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(38, 18)
        Me.Label31.TabIndex = 94
        Me.Label31.Text = "Dui:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.Location = New System.Drawing.Point(336, 28)
        Me.txtNoSocio.MaxLength = 8
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(106, 23)
        Me.txtNoSocio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(240, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "No. Asociado:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(125, 65)
        Me.txtNombre.MaxLength = 150
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(557, 23)
        Me.txtNombre.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(29, 65)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 18)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Asociado:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMsReferencia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(786, 511)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsReferencia"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Agregar Referencia de Asociado"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.fgDetRef, System.ComponentModel.ISupportInitialize).EndInit()
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
            ds = oAsoc.ConsultarReferencias("*", "Dui='" & Trim(pDui) & "'", "DUI", sUsuario, sPassword, sSucursal)
            fgDetRef.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Referencias de Asociado" & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        fgDetRef.Cols.Item(0).Width = 17
    End Sub

    Private Sub frmMsReferencia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        Try
            If fgDetRef.Row <> -1 Then
                btnModificar.Enabled = True
                Me.btnEliminar.Enabled = True
            End If

            If Me.pAccion = "Modificar" Then

                ds = oAsoc.ConsultarAsociado("NoSocio,CodAntiguo,Apellido1,Apellido2,Nombres", "Dui='" & pDui & "'", "Dui", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtDui.Value = pDui
                    txtDui.Enabled = False
                    txtCodAntiguo.Enabled = False
                    txtCodAntiguo.Text = IIf(IsDBNull(Filas.Item(0)("CodAntiguo")), "", Filas.Item(0)("CodAntiguo"))
                    txtNoSocio.Text = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))
                    txtNoSocio.Enabled = False
                    txtNombre.Text = CStr(Filas.Item(0)("Nombres")) & " " & CStr(Filas.Item(0)("Apellido1")) & " " & CStr(Filas.Item(0)("Apellido2"))
                    txtNombre.ReadOnly = True
                End If

            End If
            ds = oAsoc.ConsultarReferencias("*", "Dui='" & pDui & "'", "Dui", sUsuario, sPassword, sSucursal)
            fgDetRef.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNoSocio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtNombre.Text.Trim = "" Then
            btnNuevo.Enabled = False
        Else
            btnNuevo.Enabled = True
        End If
    End Sub

    Private Sub txtNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtNombre.Text.Trim = "" Then
            btnNuevo.Enabled = False
        Else
            btnNuevo.Enabled = True
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
                        txtDui.Value = CStr(Filas.Item(0)("DUI"))
                        txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                        If txtNombre.Text.Trim = "" Then
                            btnNuevo.Enabled = False
                        Else
                            btnNuevo.Enabled = True
                        End If
                    Else
                        txtNoSocio_DoubleClick(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception

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
            If ofrm.Resultado.Trim <> "" Then
                txtCodAntiguo.Text = ofrm.Resultado3.Trim
                txtNoSocio.Text = ofrm.Resultado2.Trim
                txtDui.Value = ofrm.Resultado.Trim
                txtNombre.Text = ofrm.Resultado4.Trim
                If txtNombre.Text.Trim = "" Then
                    btnNuevo.Enabled = False
                Else
                    btnNuevo.Enabled = True
                End If
            End If
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
                        txtDui.Value = CStr(Filas.Item(0)("DUI"))
                        txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                        txtCodAntiguo.Text = IIf(IsDBNull(Filas.Item(0)("CodAntiguo")), "", Filas.Item(0)("CodAntiguo"))
                        If txtNombre.Text.Trim = "" Then
                            btnNuevo.Enabled = False
                        Else
                            btnNuevo.Enabled = True
                        End If
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
            If ofrm.Resultado.Trim <> "" Then
                txtNoSocio.Text = ofrm.Resultado2.Trim
                txtDui.Value = ofrm.Resultado.Trim
                txtNombre.Text = ofrm.Resultado4.Trim
                txtCodAntiguo.Text = ofrm.Resultado3
                If txtNombre.Text.Trim = "" Then
                    btnNuevo.Enabled = False
                Else
                    btnNuevo.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodAntiguo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodAntiguo.TextChanged
        If txtNombre.Text.Trim = "" Then
            btnNuevo.Enabled = False
        Else
            btnNuevo.Enabled = True
        End If
    End Sub

    Private Sub txtDui_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.TextChanged
        If txtNombre.Text.Trim = "" Then
            btnNuevo.Enabled = False
        Else
            btnNuevo.Enabled = True
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
            If ofrm.Resultado.Trim <> "" Then
                txtNoSocio.Text = ofrm.Resultado2.Trim
                txtDui.Value = ofrm.Resultado.Trim
                txtNombre.Text = ofrm.Resultado4.Trim
                txtCodAntiguo.Text = ofrm.Resultado3
                If txtNombre.Text.Trim = "" Then
                    btnNuevo.Enabled = False
                Else
                    btnNuevo.Enabled = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                If txtDui.Text.Trim = "" Then
                    txtDui_DoubleClick(sender, e)
                Else
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                    ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "Dui='" & txtDui.Text.Trim & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio")).Trim
                        txtDui.Value = CStr(Filas.Item(0)("DUI")).Trim
                        txtNombre.Text = CStr(Filas.Item(0)("Nombre")).Trim
                        txtCodAntiguo.Text = IIf(IsDBNull(Filas.Item(0)("CodAntiguo")), "", Filas.Item(0)("CodAntiguo"))
                        If txtNombre.Text.Trim = "" Then
                            btnNuevo.Enabled = False
                        Else
                            btnNuevo.Enabled = True
                        End If
                    Else
                        txtDui_DoubleClick(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Dim frm As frmMsDetReferencia = New frmMsDetReferencia
        frm.pDui = txtDui.Value
        pDui = txtDui.Value
        frm.btnGuardar1.Text = "&Guardar"
        frm.ofrm = CType(Me, frmMsReferencia)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
        ActualizaGrid()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If fgDetRef.Row <> -1 Then
            Dim frm As frmMsDetReferencia = New frmMsDetReferencia
            frm.pDui = pDui
            frm.btnGuardar1.Text = "&Modificar"
            If Me.btnModificar.Text = "&Consulta" Then
                frm.btnGuardar1.Visible = False
            End If
            frm.pCorrelativo = fgDetRef.Item(fgDetRef.Row, "NumRef")
            frm.btnGuardar1.Text = "&Modificar"
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If fgDetRef.Row <> -1 Then
                If MsgBox("¿Desea eliminar la Referencia No. " & fgDetRef.Item(fgDetRef.Row, "NumRef") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Referencias") = MsgBoxResult.Yes Then
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
                    oAsoc.EliminarReferencias("Dui='" & fgDetRef.Item(fgDetRef.Row, "Dui") & "' and NumRef=" & fgDetRef.Item(fgDetRef.Row, "NumRef") & "", sUsuario, sPassword, sSucursal)
                    ActualizaGrid()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNoSocio_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoSocio.TextChanged
        If txtNombre.Text.Trim = "" Then
            btnNuevo.Enabled = False
        Else
            btnNuevo.Enabled = True
        End If
    End Sub

    Private Sub frmMsReferencia_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class

