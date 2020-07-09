Imports C1.Win.C1FlexGrid

Public Class frmMsProcesos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim administracion As New wrAdmin.wsLibAdmin
    Private iRow As Integer, idNo As String, vDescripcion As String, ds As New DataSet
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton

    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents picDeshabilita As System.Windows.Forms.PictureBox
    Friend WithEvents picNodo As System.Windows.Forms.PictureBox
    Friend WithEvents picRaiz As System.Windows.Forms.PictureBox
    Friend WithEvents picSubNodo As System.Windows.Forms.PictureBox
    Friend WithEvents picFolder As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsProcesos))
        Me.picDeshabilita = New System.Windows.Forms.PictureBox()
        Me.picNodo = New System.Windows.Forms.PictureBox()
        Me.picRaiz = New System.Windows.Forms.PictureBox()
        Me.picSubNodo = New System.Windows.Forms.PictureBox()
        Me.picFolder = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        CType(Me.picDeshabilita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRaiz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSubNodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFolder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picDeshabilita
        '
        Me.picDeshabilita.Image = CType(resources.GetObject("picDeshabilita.Image"), System.Drawing.Image)
        Me.picDeshabilita.Location = New System.Drawing.Point(444, 126)
        Me.picDeshabilita.Name = "picDeshabilita"
        Me.picDeshabilita.Size = New System.Drawing.Size(19, 18)
        Me.picDeshabilita.TabIndex = 63
        Me.picDeshabilita.TabStop = False
        Me.picDeshabilita.Visible = False
        '
        'picNodo
        '
        Me.picNodo.Image = CType(resources.GetObject("picNodo.Image"), System.Drawing.Image)
        Me.picNodo.Location = New System.Drawing.Point(418, 126)
        Me.picNodo.Name = "picNodo"
        Me.picNodo.Size = New System.Drawing.Size(19, 18)
        Me.picNodo.TabIndex = 59
        Me.picNodo.TabStop = False
        Me.picNodo.Visible = False
        '
        'picRaiz
        '
        Me.picRaiz.Image = CType(resources.GetObject("picRaiz.Image"), System.Drawing.Image)
        Me.picRaiz.Location = New System.Drawing.Point(319, 126)
        Me.picRaiz.Name = "picRaiz"
        Me.picRaiz.Size = New System.Drawing.Size(19, 18)
        Me.picRaiz.TabIndex = 58
        Me.picRaiz.TabStop = False
        Me.picRaiz.Visible = False
        '
        'picSubNodo
        '
        Me.picSubNodo.Image = CType(resources.GetObject("picSubNodo.Image"), System.Drawing.Image)
        Me.picSubNodo.Location = New System.Drawing.Point(382, 126)
        Me.picSubNodo.Name = "picSubNodo"
        Me.picSubNodo.Size = New System.Drawing.Size(28, 18)
        Me.picSubNodo.TabIndex = 61
        Me.picSubNodo.TabStop = False
        Me.picSubNodo.Visible = False
        '
        'picFolder
        '
        Me.picFolder.Image = CType(resources.GetObject("picFolder.Image"), System.Drawing.Image)
        Me.picFolder.Location = New System.Drawing.Point(346, 126)
        Me.picFolder.Name = "picFolder"
        Me.picFolder.Size = New System.Drawing.Size(28, 18)
        Me.picFolder.TabIndex = 60
        Me.picFolder.TabStop = False
        Me.picFolder.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 14)
        Me.Label1.TabIndex = 186
        Me.Label1.Text = "Rol:"
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "3,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:100;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.fg.Location = New System.Drawing.Point(28, 165)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 21
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange
        Me.fg.Size = New System.Drawing.Size(732, 410)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 52
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(222, 126)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 1010
        Me.MetroButton2.Text = "Guardar"
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(125, 126)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(90, 32)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 1009
        Me.MetroButton1.Text = "Deshabilitar"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(28, 126)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1008
        Me.btnGuardar1.Text = "Habilitar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 24
        Me.MetroComboBox1.Location = New System.Drawing.Point(72, 69)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(688, 30)
        Me.MetroComboBox1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroComboBox1.TabIndex = 1011
        Me.MetroComboBox1.UseSelectable = True
        '
        'frmMsProcesos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(787, 618)
        Me.Controls.Add(Me.MetroComboBox1)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picDeshabilita)
        Me.Controls.Add(Me.picNodo)
        Me.Controls.Add(Me.picRaiz)
        Me.Controls.Add(Me.picSubNodo)
        Me.Controls.Add(Me.picFolder)
        Me.Controls.Add(Me.fg)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(787, 618)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(787, 618)
        Me.Name = "frmMsProcesos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Asignación de Procesos"
        CType(Me.picDeshabilita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRaiz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSubNodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFolder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMsProcesos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            llenarRoles()
            Dim oApp As New wrAdmin.wsLibAdmin
            ds = oApp.CargaMenuProcesos("IdProceso,Descripcion,Nivel,Observacion", "", "IdProceso", sUsuario, sPassword, sSucursal)
            cargarGrid(ds)
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Public Sub cargarGrid(ByVal pds As System.Data.DataSet)

        Dim dr As System.Data.DataRow, x As Integer = 0
        Dim range As CellRange

        fg.Rows.Count = pds.Tables(0).Rows.Count + 1
        fg.Rows.Fixed = 1
        fg.Cols.Fixed = 1
        fg.Cols.Count = 5
        fg.Tree.Column = 1

        fg(0, 1) = "No."
        fg(0, 2) = "Descripcion"
        fg(0, 3) = "Nivel"
        fg(0, 4) = "Observación"

        fg.Rows.Fixed = 1
        fg.Cols.Fixed = 1
        fg.Cols.Count = 5
        fg.Tree.Column = 1
        fg.Cols(1).Width = 150
        fg.Cols(2).Width = 225
        fg.Cols(3).Width = 0
        fg.Cols(4).Width = 500

        For Each dr In pds.Tables(0).Rows
            x += 1
            fg(x, 1) = dr("IdProceso")
            fg(x, 2) = dr("Descripcion")
            fg(x, 3) = dr("Nivel")
            fg(x, 4) = dr("Observacion")

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
    Private Sub llenarRoles()
        MetroComboBox1.DisplayMember = "Descripcion"
        MetroComboBox1.ValueMember = "codRol"
        Dim dts As New DataSet
        dts = administracion.ConsultarRol("*", "", "CodRol", sUsuario, sPassword, sSucursal)
        Me.MetroComboBox1.DataSource = dts.Tables(0)

    End Sub
    'Private Sub txtCodRole_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodRole.DoubleClick
    '    Try
    '        Dim ofrm As New frmAGenerico
    '        ofrm.Text = "Buscar Roles"
    '        Dim oPerif As wrAdmin.wsLibAdmin = New wrAdmin.wsLibAdmin, ds As New Data.DataSet
    '        ds = oPerif.ConsultarRol("*", "", "CodRol", sUsuario, sPassword, sSucursal)
    '        ofrm.Datos = ds
    '        ofrm.ColSeleccion = 0
    '        ofrm.RefrescarGrid()
    '        ofrm.ShowDialog()
    '        Me.txtCodRole.Text = ofrm.Resultado.Trim
    '        Me.txtRole.Text = ofrm.Resultado2.Trim
    '        CargarRoles(Me.txtCodRole.Text.Trim)
    '    Catch ex As Exception
    '       MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    'Private Sub txtCodRole_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodRole.KeyPress
    '    Try
    '        Dim oPerif As wrAdmin.wsLibAdmin = New wrAdmin.wsLibAdmin, ds As New Data.DataSet, Filas As Data.DataRowCollection
    '        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
    '            ds = oPerif.ConsultarRol("*", "CodRol='" & Trim(Me.txtCodRole.Text) & "'", "CodRol", sUsuario, sPassword, sSucursal)
    '            Filas = ds.Tables(0).Rows()
    '            If Filas.Count > 0 Then
    '                If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
    '                    Me.txtRole.Text = CStr(Filas.Item(0)("Descripcion"))
    '                End If
    '            Else
    '                txtCodRole_DoubleClick(sender, e)
    '            End If
    '        End If

    '    Catch ex As Exception
    '       MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub fg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.Click
        iRow = fg.RowSel
        idNo = ds.Tables(0).Rows(iRow - 1).Item(0)
    End Sub



    Private Sub fg_SelChange(ByVal sender As Object, ByVal e As System.EventArgs) Handles fg.SelChange
        iRow = fg.RowSel
        idNo = ds.Tables(0).Rows(iRow - 1).Item(0)
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
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim range As CellRange, x As Integer, dr As DataRow, range2 As CellRange
        Try
            range = fg.Rows(fg.RowSel).Node.GetCellRange
            For Each dr In ds.Tables(0).Rows
                x = x + 1
                If range.ContainsRow(x) = True Then
                    range2 = fg.GetCellRange(x, 1)
                    range2.Image = picFolder.Image
                End If
            Next
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Dim dr As DataRow, range As CellRange, x As Integer, vresp As String
        Dim oAdm As New wrAdmin.wsLibAdmin, dsTemp As New DataSet, sRol As String, sFiltro As String
        Try

            'If Me.txtCodRole.Text.Trim = "" Then
            '    MessageBox.Show("El Role no puede quedar vacío, selecciónelo.", "Asignación Derechos Roles", MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Exit Sub
            'End If
            dsTemp = oAdm.ConsultarUsuarioxRol("*", "a.Usuario='" & sUsuario & "'", "a.Usuario", sUsuario, sPassword, sSucursal)
            If dsTemp.Tables(0).Rows.Count > 0 Then
                dr = dsTemp.Tables(0).Rows(0)
                sRol = dr("CodRol")
            End If
            If sRol.Trim = MetroComboBox1.SelectedValue.ToString.Trim Then ' Me.txtCodRole.Text.Trim Then
                sFiltro = "CodRol='" & MetroComboBox1.SelectedValue.ToString.Trim & "' and Left(IdProceso,2)<>'AD'"
            Else
                sFiltro = "CodRol='" & MetroComboBox1.Text.Trim.ToString.Trim & "'"
            End If
            If oAdm.EliminarAccesoProceso(sFiltro, sUsuario, sPassword, sSucursal) = True Then
                For Each dr In ds.Tables(0).Rows
                    x += 1
                    range = fg.GetCellRange(x, 1)

                    If range.Image Is picFolder.Image Then
                        Dim dtsRepetido As New DataSet
                        dtsRepetido = oAdm.ConsultarAccesoProceso("idProceso", " codRol = '" & MetroComboBox1.SelectedValue.ToString.Trim & "' and idproceso='" & ds.Tables(0).Rows(x - 1).Item(0) & "' ", "idProceso", sUsuario, sPassword, sSucursal)
                        If dtsRepetido.Tables(0).Rows.Count <= 0 Then
                            vresp = oAdm.InsertarAccesoProceso(MetroComboBox1.SelectedValue, ds.Tables(0).Rows(x - 1).Item(0), Now.ToShortDateString, sUsuario, sUsuario, sPassword, sSucursal)
                        End If

                        'vresp = oAdm.InsertarAccesoProceso(txtCodRole.Text.Trim, ds.Tables(0).Rows(x - 1).Item(0), Now.ToShortDateString, sUsuario, sUsuario, sPassword, sSucursal)
                    End If
                Next
            End If
            x = 0
            For Each dr In ds.Tables(0).Rows
                x += 1
                fg.Rows(x).Node.Collapsed = True
            Next

            MsgBox("Derechos para este rol asignados con éxito.", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ds.Tables(0).Rows(x - 1).Item(0))
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub CargarRoles(ByVal pCodRol As String)

        Try
            Dim oAdm As New wrAdmin.wsLibAdmin, dsAccesos As New DataSet, dr As DataRow, dv As DataView
            Dim range As CellRange, x As Integer
            dsAccesos = oAdm.ConsultarAccesoProceso("IdProceso", "CodRol='" & pCodRol & "'", "IdProceso", sUsuario, sPassword,sSucursal)
            dv = New DataView(dsAccesos.Tables(0))
            For Each dr In ds.Tables(0).Rows
                x += 1
                dv.RowFilter = "IdProceso='" & ds.Tables(0).Rows(x - 1).Item(0) & "'"
                range = fg.GetCellRange(x, 1)
                If dv.Count > 0 Then
                    range.Image = picFolder.Image
                Else
                    range.Image = picDeshabilita.Image
                End If
            Next
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub frmMsProcesos_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub MetroComboBox1_Validated(sender As Object, e As EventArgs) Handles MetroComboBox1.Validated
        'administracion.CargaMenuProcesos("IdProceso,Descripcion,Nivel,Observacion", "", "IdProceso", sUsuario, sPassword, sSucursal)
        'cargarGrid(ds)
        CargarRoles(MetroComboBox1.SelectedValue)
    End Sub
End Class
