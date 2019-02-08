Imports C1.Win.C1FlexGrid

Public Class frmMSGPrivilegios
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private iRow As Integer, idNo As String, vDescripcion As String, ds As New DataSet
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton

    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents picFolder As PictureBox
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton

    Public Property No() As String
        Get
            Return idNo
        End Get
        Set(ByVal Value As String)
            idNo = Value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return vDescripcion
        End Get
        Set(ByVal Value As String)
            vDescripcion = Value
        End Set
    End Property

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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents picSubNodo As System.Windows.Forms.PictureBox
    Friend WithEvents picRaiz As System.Windows.Forms.PictureBox
    Friend WithEvents picNodo As System.Windows.Forms.PictureBox
    Friend WithEvents txtRole As System.Windows.Forms.TextBox
    Friend WithEvents txtCodRole As System.Windows.Forms.TextBox
    Friend WithEvents picDeshabilita As System.Windows.Forms.PictureBox
    Friend WithEvents txtTip As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMSGPrivilegios))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRole = New System.Windows.Forms.TextBox()
        Me.txtCodRole = New System.Windows.Forms.TextBox()
        Me.picRaiz = New System.Windows.Forms.PictureBox()
        Me.picNodo = New System.Windows.Forms.PictureBox()
        Me.picSubNodo = New System.Windows.Forms.PictureBox()
        Me.txtTip = New System.Windows.Forms.TextBox()
        Me.picDeshabilita = New System.Windows.Forms.PictureBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.picFolder = New System.Windows.Forms.PictureBox()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRaiz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSubNodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeshabilita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "3,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:100;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(31, 168)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.fg.Size = New System.Drawing.Size(459, 319)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(28, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 14)
        Me.Label1.TabIndex = 186
        Me.Label1.Text = "Rol:"
        '
        'txtRole
        '
        Me.txtRole.BackColor = System.Drawing.Color.White
        Me.txtRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRole.Location = New System.Drawing.Point(186, 73)
        Me.txtRole.Multiline = True
        Me.txtRole.Name = "txtRole"
        Me.txtRole.ReadOnly = True
        Me.txtRole.Size = New System.Drawing.Size(403, 19)
        Me.txtRole.TabIndex = 185
        '
        'txtCodRole
        '
        Me.txtCodRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodRole.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodRole.Location = New System.Drawing.Point(73, 73)
        Me.txtCodRole.Multiline = True
        Me.txtCodRole.Name = "txtCodRole"
        Me.txtCodRole.Size = New System.Drawing.Size(106, 19)
        Me.txtCodRole.TabIndex = 183
        '
        'picRaiz
        '
        Me.picRaiz.Image = CType(resources.GetObject("picRaiz.Image"), System.Drawing.Image)
        Me.picRaiz.Location = New System.Drawing.Point(334, 143)
        Me.picRaiz.Name = "picRaiz"
        Me.picRaiz.Size = New System.Drawing.Size(19, 19)
        Me.picRaiz.TabIndex = 46
        Me.picRaiz.TabStop = False
        Me.picRaiz.Visible = False
        '
        'picNodo
        '
        Me.picNodo.Image = CType(resources.GetObject("picNodo.Image"), System.Drawing.Image)
        Me.picNodo.Location = New System.Drawing.Point(396, 143)
        Me.picNodo.Name = "picNodo"
        Me.picNodo.Size = New System.Drawing.Size(19, 19)
        Me.picNodo.TabIndex = 47
        Me.picNodo.TabStop = False
        Me.picNodo.Visible = False
        '
        'picSubNodo
        '
        Me.picSubNodo.Image = CType(resources.GetObject("picSubNodo.Image"), System.Drawing.Image)
        Me.picSubNodo.Location = New System.Drawing.Point(449, 143)
        Me.picSubNodo.Name = "picSubNodo"
        Me.picSubNodo.Size = New System.Drawing.Size(29, 19)
        Me.picSubNodo.TabIndex = 49
        Me.picSubNodo.TabStop = False
        Me.picSubNodo.Visible = False
        '
        'txtTip
        '
        Me.txtTip.BackColor = System.Drawing.Color.White
        Me.txtTip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTip.ForeColor = System.Drawing.Color.Teal
        Me.txtTip.Location = New System.Drawing.Point(31, 99)
        Me.txtTip.Name = "txtTip"
        Me.txtTip.Size = New System.Drawing.Size(558, 23)
        Me.txtTip.TabIndex = 50
        Me.txtTip.Text = "Para habilitar/deshabilitar presione barra espaciadora o los respectivos botones." &
    ""
        '
        'picDeshabilita
        '
        Me.picDeshabilita.Image = CType(resources.GetObject("picDeshabilita.Image"), System.Drawing.Image)
        Me.picDeshabilita.Location = New System.Drawing.Point(422, 143)
        Me.picDeshabilita.Name = "picDeshabilita"
        Me.picDeshabilita.Size = New System.Drawing.Size(20, 19)
        Me.picDeshabilita.TabIndex = 51
        Me.picDeshabilita.TabStop = False
        Me.picDeshabilita.Visible = False
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(31, 129)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 33)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1005
        Me.btnGuardar1.Text = "Habilitar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(128, 129)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(90, 33)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 1006
        Me.MetroButton1.Text = "Deshabilitar"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(226, 129)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(90, 33)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 1007
        Me.MetroButton2.Text = "Guardar"
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'picFolder
        '
        Me.picFolder.Image = CType(resources.GetObject("picFolder.Image"), System.Drawing.Image)
        Me.picFolder.Location = New System.Drawing.Point(360, 143)
        Me.picFolder.Name = "picFolder"
        Me.picFolder.Size = New System.Drawing.Size(29, 19)
        Me.picFolder.TabIndex = 48
        Me.picFolder.TabStop = False
        Me.picFolder.Visible = False
        '
        'frmMSGPrivilegios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(517, 535)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtRole)
        Me.Controls.Add(Me.txtCodRole)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picDeshabilita)
        Me.Controls.Add(Me.txtTip)
        Me.Controls.Add(Me.picSubNodo)
        Me.Controls.Add(Me.picFolder)
        Me.Controls.Add(Me.picNodo)
        Me.Controls.Add(Me.picRaiz)
        Me.Controls.Add(Me.fg)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMSGPrivilegios"
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Establecimiento de Privilegios"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRaiz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSubNodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeshabilita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Public Sub cargarGrid(ByVal pds As System.Data.DataSet)

        Dim dr As System.Data.DataRow, x As Integer = 0
        Dim range As CellRange

        fg.Rows.Count = pds.Tables(0).Rows.Count + 1
        fg.Rows.Fixed = 1
        fg.Cols.Fixed = 1
        fg.Cols.Count = 4
        fg.Tree.Column = 1

        fg(0, 1) = "No."
        fg(0, 2) = "Descripcion"
        fg(0, 3) = "Nivel"

        'fg.Rows(2).IsNode = True
        'fg.Rows(2).Node.Level = 1

        'fg.Rows(3).IsNode = True
        'fg.Rows(3).Node.Level = 2

        fg.Rows.Fixed = 1
        fg.Cols.Fixed = 1
        fg.Cols.Count = 4
        fg.Tree.Column = 1
        fg.Cols(1).Width = 150
        fg.Cols(2).Width = 225
        fg.Cols(3).Width = 0

        For Each dr In pds.Tables(0).Rows
            x += 1
            fg(x, 1) = dr("Num_Programa")
            fg(x, 2) = dr("Descripcion")
            fg(x, 3) = dr("Nivel")

            fg.Rows(x).IsNode = True
            fg.Rows(x).Node.Level = dr("Nivel")

            If dr("Nivel") = 0 Then
                range = fg.GetCellRange(x, 1)
                range.Image = picRaiz.Image
            ElseIf dr("Nivel") = 1 Then
                range = fg.GetCellRange(x, 1)
                range.Image = picNodo.Image
            ElseIf dr("Nivel") = 2 Then
                range = fg.GetCellRange(x, 1)
                range.Image = picSubNodo.Image
            Else
                range = fg.GetCellRange(x, 1)
                range.Image = picFolder.Image
            End If
        Next
        x = 0
        For Each dr In pds.Tables(0).Rows
            x += 1
            If dr("Nivel") = 0 Then
                fg.Rows(x).Node.Collapsed = False
            ElseIf dr("Nivel") = 1 Then
                fg.Rows(x).Node.Collapsed = False
            Else
                fg.Rows(x).Node.Collapsed = True
            End If
        Next
    End Sub

    Private Sub frmMSGPrivilegios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oApp As New wrAdmin.wsLibAdmin
            ds = oApp.CargaMenuPrivilegios("Num_Programa,Descripcion,Nivel", "", "Num_Programa", sUsuario, sPassword, sSucursal)
            cargarGrid(ds)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub fg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fg.Click
        iRow = fg.RowSel
        idNo = ds.Tables(0).Rows(iRow - 1).Item(0)
    End Sub

    Private Sub txtCodRole_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodRole.KeyPress
        Try
            Dim oPerif As wrAdmin.wsLibAdmin = New wrAdmin.wsLibAdmin, ds As New Data.DataSet, Filas As Data.DataRowCollection
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                ds = oPerif.ConsultarRol("*", "CodRol='" & Trim(Me.txtCodRole.Text) & "'", "CodRol", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                        Me.txtRole.Text = CStr(Filas.Item(0)("Descripcion"))
                    End If
                Else
                    txtCodRole_DoubleClick(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodRole_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodRole.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Roles"
        Try
            Dim oPerif As wrAdmin.wsLibAdmin = New wrAdmin.wsLibAdmin, ds As New Data.DataSet
            ds = oPerif.ConsultarRol("*", "", "CodRol", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodRole.Text = ofrm.Resultado.Trim
            Me.txtRole.Text = ofrm.Resultado2.Trim
            CargarRoles(Me.txtCodRole.Text.Trim)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btHabilitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btDeshabilitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim range As CellRange, x As Integer, dr As DataRow, range2 As CellRange
        range = fg.Rows(fg.RowSel).Node.GetCellRange
        Try
            For Each dr In ds.Tables(0).Rows
                x = x + 1
                If range.ContainsRow(x) = True Then
                    range2 = fg.GetCellRange(x, 1)
                    range2.Image = picFolder.Image
                End If
            Next
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim range As CellRange, x As Integer, dr As DataRow, range2 As CellRange
        Try
            range = fg.Rows(fg.RowSel).Node.GetCellRange
            For Each dr In ds.Tables(0).Rows
                x = x + 1
                If range.ContainsRow(x) = True Then
                    range2 = fg.GetCellRange(x, 1)
                    range2.Image = picDeshabilita.Image
                End If
            Next
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click

        Try
            Dim dr As DataRow, range As CellRange, x As Integer, vresp As String
            Dim oAdm As New wrAdmin.wsLibAdmin

            If Me.txtCodRole.Text.Trim = "" Then
                MessageBox.Show("El Role no puede quedar vacío, selecciónelo.", "Asignación Derechos Roles", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If oAdm.EliminarAcceso("CodRol='" & Me.txtCodRole.Text.Trim & "'", sUsuario, sPassword, sSucursal) = True Then
                For Each dr In ds.Tables(0).Rows
                    x += 1
                    range = fg.GetCellRange(x, 1)
                    If range.Image Is picFolder.Image Then
                        vresp = oAdm.InsertarAcceso(txtCodRole.Text.Trim, ds.Tables(0).Rows(x - 1).Item(0), Now.ToShortDateString, sUsuario, sUsuario, sPassword, sSucursal)
                    End If
                Next
            End If
            x = 0
            For Each dr In ds.Tables(0).Rows
                x += 1
                fg.Rows(x).Node.Collapsed = True
            Next

            MessageBox.Show("Derechos para este rol asignados con éxito. Debe iniciar sesión para visualizar los cambios.", "Asignación Derechos Roles", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub fg_SelChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.SelChange
        iRow = fg.RowSel
        idNo = ds.Tables(0).Rows(iRow - 1).Item(0)
    End Sub

    Private Sub CargarRoles(ByVal pCodRol As String)

        Try
            Dim oAdm As New wrAdmin.wsLibAdmin, dsAccesos As New DataSet, dr As DataRow, dv As DataView
            Dim range As CellRange, x As Integer

            dsAccesos = oAdm.ConsultarAcceso("Num_Programa", "CodRol='" & pCodRol & "'", "Num_Programa", sUsuario, sPassword,sSucursal)
            dv = New DataView(dsAccesos.Tables(0))
            For Each dr In ds.Tables(0).Rows
                x += 1
                dv.RowFilter = "Num_Programa='" & ds.Tables(0).Rows(x - 1).Item(0) & "'"
                range = fg.GetCellRange(x, 1)
                If dv.Count > 0 Then
                    range.Image = picFolder.Image
                Else
                    range.Image = picDeshabilita.Image
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub fg_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fg.KeyUp
        Try
            If e.KeyCode = Keys.Space Then
                Dim range As CellRange, x As Integer, dr As DataRow, range2 As CellRange
                range = fg.Rows(fg.RowSel).Node.GetCellRange
                For Each dr In ds.Tables(0).Rows
                    x = x + 1
                    If range.ContainsRow(x) = True Then
                        range2 = fg.GetCellRange(x, 1)
                        If range2.Image Is picFolder.Image Then
                            range2.Image = picDeshabilita.Image
                        Else
                            range2.Image = picFolder.Image
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class