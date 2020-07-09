Public Class frmMAhParametros
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents fgTipoAh As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoAh As System.Windows.Forms.TextBox
    Friend WithEvents rbtDesc As System.Windows.Forms.RadioButton
    Friend WithEvents rbtCodTipoAh As System.Windows.Forms.RadioButton
    Friend WithEvents btnMostrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMAhParametros))
        Me.fgTipoAh = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMostrar1 = New MetroFramework.Controls.MetroButton()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtCodTipoAh = New System.Windows.Forms.TextBox()
        Me.rbtDesc = New System.Windows.Forms.RadioButton()
        Me.rbtCodTipoAh = New System.Windows.Forms.RadioButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.fgTipoAh, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fgTipoAh
        '
        Me.fgTipoAh.AllowEditing = False
        Me.fgTipoAh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgTipoAh.BackColor = System.Drawing.Color.White
        Me.fgTipoAh.ColumnInfo = "36,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgTipoAh.Location = New System.Drawing.Point(28, 232)
        Me.fgTipoAh.Name = "fgTipoAh"
        Me.fgTipoAh.Rows.Count = 2
        Me.fgTipoAh.Rows.DefaultSize = 21
        Me.fgTipoAh.Size = New System.Drawing.Size(702, 127)
        Me.fgTipoAh.StyleInfo = resources.GetString("fgTipoAh.StyleInfo")
        Me.fgTipoAh.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMostrar1)
        Me.GroupBox2.Controls.Add(Me.txtDesc)
        Me.GroupBox2.Controls.Add(Me.txtCodTipoAh)
        Me.GroupBox2.Controls.Add(Me.rbtDesc)
        Me.GroupBox2.Controls.Add(Me.rbtCodTipoAh)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(700, 113)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "&Filtrar Parámetros Generales:"
        '
        'btnMostrar1
        '
        Me.btnMostrar1.Location = New System.Drawing.Point(397, 54)
        Me.btnMostrar1.Name = "btnMostrar1"
        Me.btnMostrar1.Size = New System.Drawing.Size(90, 33)
        Me.btnMostrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar1.TabIndex = 186
        Me.btnMostrar1.Text = "Mostrar"
        Me.btnMostrar1.UseSelectable = True
        Me.btnMostrar1.UseStyleColors = True
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(209, 65)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(182, 22)
        Me.txtDesc.TabIndex = 13
        '
        'txtCodTipoAh
        '
        Me.txtCodTipoAh.Location = New System.Drawing.Point(19, 65)
        Me.txtCodTipoAh.Name = "txtCodTipoAh"
        Me.txtCodTipoAh.Size = New System.Drawing.Size(183, 22)
        Me.txtCodTipoAh.TabIndex = 12
        '
        'rbtDesc
        '
        Me.rbtDesc.BackColor = System.Drawing.Color.White
        Me.rbtDesc.Location = New System.Drawing.Point(209, 28)
        Me.rbtDesc.Name = "rbtDesc"
        Me.rbtDesc.Size = New System.Drawing.Size(182, 27)
        Me.rbtDesc.TabIndex = 11
        Me.rbtDesc.Text = "Descripción:"
        Me.rbtDesc.UseVisualStyleBackColor = False
        '
        'rbtCodTipoAh
        '
        Me.rbtCodTipoAh.BackColor = System.Drawing.Color.White
        Me.rbtCodTipoAh.Location = New System.Drawing.Point(19, 28)
        Me.rbtCodTipoAh.Name = "rbtCodTipoAh"
        Me.rbtCodTipoAh.Size = New System.Drawing.Size(183, 27)
        Me.rbtCodTipoAh.TabIndex = 10
        Me.rbtCodTipoAh.Text = "Código Tipo de Ahorro:"
        Me.rbtCodTipoAh.UseVisualStyleBackColor = False
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(222, 193)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(90, 32)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 188
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(319, 193)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 32)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 187
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(125, 193)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 32)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 185
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(28, 193)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 32)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 184
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmMAhParametros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.CausesValidation = False
        Me.ClientSize = New System.Drawing.Size(757, 453)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.fgTipoAh)
        Me.Name = "frmMAhParametros"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Parámetros Generales"
        CType(Me.fgTipoAh, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Encabezado_fgTipoAH()
        Try
            fgTipoAh.Cols.Item(1).Caption = "Cód. Tipo Ahorro"
            fgTipoAh.Cols.Item(2).Caption = "Tipo Ahorro"
            fgTipoAh.Cols.Item(3).Caption = "Plazo"
            fgTipoAh.Cols.Item(4).Caption = "Junior"
            fgTipoAh.Cols.Item(5).Caption = "Cuenta_Contable"
            fgTipoAh.Cols.Item(6).Caption = "Cód. Tipo Ahorro"
            fgTipoAh.Cols.Item(7).Caption = "Saldo Mínimo"
            fgTipoAh.Cols.Item(8).Caption = "Cuota Mínima"
            fgTipoAh.Cols.Item(9).Caption = "Apertura Mínima"
            fgTipoAh.Cols.Item(10).Caption = "Apertura Máxima"
            fgTipoAh.Cols.Item(11).Caption = "Plazo Mínimo"
            fgTipoAh.Cols.Item(12).Caption = "Plazo Máximo"
            fgTipoAh.Cols.Item(13).Caption = "Aplica Inactividad"
            fgTipoAh.Cols.Item(14).Caption = "Saldo_Mínimo_Inact."
            fgTipoAh.Cols.Item(15).Caption = "Tiempo_Mínimo_Inact."
            fgTipoAh.Cols.Item(16).Caption = "$Mínimo_Inact."
            fgTipoAh.Cols.Item(17).Caption = "$Mínimo_No_Interés"
            fgTipoAh.Cols.Item(18).Caption = "Tasa Interés"
            fgTipoAh.Cols.Item(19).Caption = "$ Ley Lavado"
            fgTipoAh.Cols.Item(20).Caption = "Días Gracia"
            fgTipoAh.Cols.Item(21).Caption = "% Pignoración"

            fgTipoAh.Cols.Item(0).Width = 20
            fgTipoAh.Cols.Item(1).Width = 100
            fgTipoAh.Cols.Item(2).Width = 215
            fgTipoAh.Cols.Item(3).Width = 77
            fgTipoAh.Cols.Item(4).Width = 77
            fgTipoAh.Cols.Item(5).Width = 125
            fgTipoAh.Cols.Item(6).Width = 0
            fgTipoAh.Cols.Item(7).Width = 110
            fgTipoAh.Cols.Item(8).Width = 110
            fgTipoAh.Cols.Item(9).Width = 125
            fgTipoAh.Cols.Item(10).Width = 125
            fgTipoAh.Cols.Item(11).Width = 100
            fgTipoAh.Cols.Item(12).Width = 125
            fgTipoAh.Cols.Item(13).Width = 125
            fgTipoAh.Cols.Item(14).Width = 150
            fgTipoAh.Cols.Item(15).Width = 150
            fgTipoAh.Cols.Item(16).Width = 125
            fgTipoAh.Cols.Item(17).Width = 150
            fgTipoAh.Cols.Item(18).Width = 100
            fgTipoAh.Cols.Item(19).Width = 100
            fgTipoAh.Cols.Item(20).Width = 100
            fgTipoAh.Cols.Item(21).Width = 100
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMAhParametros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnMostrar1_Click(sender, e)
        Me.WindowState = FormWindowState.Normal
    End Sub


    Private Sub ActualizaGrid()
        Dim oAh As wrAhorro.wsLibAhorro, ds As Data.DataSet = New Data.DataSet
        Try
            oAh = New wrAhorro.wsLibAhorro
            ds = oAh.ConsultarParametrosxTipoAhorro("a.*,b.*", "", sUsuario, sPassword, sSucursal)
            fgTipoAh.DataSource = ds.Tables(0)
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
        Encabezado_fgTipoAH()
    End Sub

    Private Sub rbtCodTipoAh_CheckedChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtCodTipoAh.CheckedChanged
        If rbtCodTipoAh.Checked = True Then
            txtCodTipoAh.Enabled = True
        ElseIf rbtCodTipoAh.Checked = False Then
            txtCodTipoAh.Enabled = False
        End If
        Me.txtCodTipoAh.Focus()
    End Sub

    Private Sub rbtDesc_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbtDesc.CheckedChanged
        If rbtDesc.Checked = True Then
            txtDesc.Enabled = True
        ElseIf rbtDesc.Checked = False Then
            txtDesc.Enabled = False
        End If
        Me.txtDesc.Focus()
    End Sub

    Private Sub fgTipoAh_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgTipoAh.DoubleClick
        btnConsultar1_Click(sender, e)
    End Sub




    Private Sub txtCodTipoAh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodTipoAh.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub txtDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDesc.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then btnMostrar1_Click(sender, e)
    End Sub

    Private Sub btnMostrar1_Click(sender As Object, e As EventArgs) Handles btnMostrar1.Click
        Dim oAh As wrAhorro.wsLibAhorro
        Dim dsAhPar As New Data.DataSet
        'Dim pCodTipoAho As String
        'Dim Filas As Data.DataRowCollection
        Try
            oAh = New wrAhorro.wsLibAhorro
            If Me.rbtCodTipoAh.Checked = True Then
                dsAhPar = oAh.ConsultarParametrosxTipoAhorro("a.*,b.*", "a.CodTipoAhorro='" & Me.txtCodTipoAh.Text.Trim & "'", sUsuario, sPassword, sSucursal)
            ElseIf Me.rbtDesc.Checked = True Then
                dsAhPar = oAh.ConsultarParametrosxTipoAhorro("a.*,b.*", "Descripcion like '" & Me.txtDesc.Text & "%'", sUsuario, sPassword, sSucursal)
            Else
                dsAhPar = oAh.ConsultarParametrosxTipoAhorro("a.*,b.*", "", sUsuario, sPassword, sSucursal)
            End If
            fgTipoAh.DataSource = dsAhPar.Tables("AhParametros")
            Encabezado_fgTipoAH()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As frmMsAhParametros = New frmMsAhParametros
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            btnMostrar1_Click(sender, e)
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If fgTipoAh.Row <> -1 Then
                Dim frm As frmMsAhParametros = New frmMsAhParametros
                frm.pAccion = "Modificar"
                frm.btnGuardar.Text = "&Modificar"
                frm.pCodTipoAhorro = fgTipoAh.Item(fgTipoAh.Row, "CodTipoAhorro")
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                btnMostrar1_Click(sender, e)
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If fgTipoAh.Row <> -1 Then
                If MsgBox("¿Desea eliminar el Tipo de Ahorro seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Tipos de Ahorro") = MsgBoxResult.Yes Then
                    Dim oCred As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
                    oCred.EliminaParametros(fgTipoAh.Item(fgTipoAh.Row, "CodTipoAhorro"), sUsuario, sPassword, sSucursal)
                    oCred.EliminarTipoAhorro(fgTipoAh.Item(fgTipoAh.Row, "CodTipoAhorro"), sUsuario, sPassword, sSucursal)
                    ActualizaGrid()
                    txtCodTipoAh.Enabled = False
                    txtDesc.Enabled = False
                End If
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            If fgTipoAh.Row <> -1 Then
                Dim frm As frmMsAhParametros = New frmMsAhParametros
                frm.pAccion = "Modificar"
                frm.btnGuardar.Visible = False
                frm.pCodTipoAhorro = fgTipoAh.Item(fgTipoAh.Row, "CodTipoAhorro")
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                btnMostrar1_Click(sender, e)
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMAhParametros_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class