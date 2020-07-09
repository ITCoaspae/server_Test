Public Class frmMActivaAsociado
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents Label1 As Label
    Dim asociados As New wrAsociados.wsLibAsoc

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
    Friend WithEvents fgEstadoIngreso As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnActivar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMostrar As MetroFramework.Controls.MetroButton
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMActivaAsociado))
        Me.fgEstadoIngreso = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.btnActivar = New MetroFramework.Controls.MetroButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnMostrar = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.fgEstadoIngreso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fgEstadoIngreso
        '
        Me.fgEstadoIngreso.AllowEditing = False
        Me.fgEstadoIngreso.AllowFiltering = True
        Me.fgEstadoIngreso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgEstadoIngreso.BackColor = System.Drawing.Color.White
        Me.fgEstadoIngreso.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:97;Style:""TextAlign:RightCenter;"";}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{" &
    "Width:150;}" & Global.Microsoft.VisualBasic.ChrW(9) & "3{Width:150;}" & Global.Microsoft.VisualBasic.ChrW(9) & "4{Width:150;}" & Global.Microsoft.VisualBasic.ChrW(9) & "5{Width:150;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgEstadoIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fgEstadoIngreso.Location = New System.Drawing.Point(23, 135)
        Me.fgEstadoIngreso.Name = "fgEstadoIngreso"
        Me.fgEstadoIngreso.Rows.Count = 2
        Me.fgEstadoIngreso.Rows.DefaultSize = 22
        Me.fgEstadoIngreso.Size = New System.Drawing.Size(765, 315)
        Me.fgEstadoIngreso.StyleInfo = resources.GetString("fgEstadoIngreso.StyleInfo")
        Me.fgEstadoIngreso.TabIndex = 26
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(94, 67)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(183, 20)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'btnActivar
        '
        Me.btnActivar.Location = New System.Drawing.Point(119, 96)
        Me.btnActivar.Name = "btnActivar"
        Me.btnActivar.Size = New System.Drawing.Size(90, 33)
        Me.btnActivar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnActivar.TabIndex = 11
        Me.btnActivar.Text = "Activar"
        Me.btnActivar.UseSelectable = True
        Me.btnActivar.UseStyleColors = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(215, 96)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 33)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 12
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(23, 96)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(90, 33)
        Me.btnMostrar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMostrar.TabIndex = 27
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseSelectable = True
        Me.btnMostrar.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "DUI:"
        '
        'frmMActivaAsociado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(811, 522)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnActivar)
        Me.Controls.Add(Me.fgEstadoIngreso)
        Me.Name = "frmMActivaAsociado"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento - Activación de Asociados"
        CType(Me.fgEstadoIngreso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmMActivaAsociado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ActualizaGrid()
        'Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub ActualizaGrid()
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As Data.DataSet = New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarEstadoIngreso("top 30 a.correlativo,a.dui,concat(rtrim(b.nombres),' ',rtrim(b.Apellido1),' ',rtrim(b.apellido2),' ',rtrim(b.apellidocas)) as Nombre,b.EstadoIngreso as Estado", "b.EstadoIngreso=1", "a.DUI", sUsuario, sPassword, sSucursal)
            fgEstadoIngreso.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Estado Ingreso Asociados" & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        fgEstadoIngreso.Cols.Item(3).Width = 400
    End Sub








    Private Sub fgEstadoIngreso_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles fgEstadoIngreso.DoubleClick
        btnConsultar1_Click(sender, e)
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



    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click

        If fgEstadoIngreso.Row <> -1 Then
            Dim frm As frmMsActivaAsociado = New frmMsActivaAsociado
            frm.pEstado = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "Estado")
            frm.btnGuardar1.Text = "&Guardar"
            frm.btnGuardar1.Visible = False
            frm.pCorrelativo = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "Correlativo")
            frm.pDui = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "DUI")
            frm.btnGuardar1.Enabled = False
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()

        End If
    End Sub



    Private Sub btnActivar_Click(sender As Object, e As EventArgs) Handles btnActivar.Click
        If fgEstadoIngreso.Row <> -1 Then
            Dim frm As frmMsActivaAsociado = New frmMsActivaAsociado
            frm.pEstado = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "Estado")
            frm.btnGuardar1.Text = "&Guardar"
            frm.pCorrelativo = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "Correlativo")
            frm.pDui = fgEstadoIngreso.Item(fgEstadoIngreso.Row, "DUI")
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()

        End If
    End Sub

    Private Sub frmMActivaAsociado_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click

        Try
            Dim dts As New DataSet
            dts = asociados.ConsultarEstadoIngreso("a.correlativo,a.dui,concat(rtrim(b.nombres),' ',rtrim(b.Apellido1),' ',rtrim(b.apellido2),' ',rtrim(b.apellidocas)) as Nombre,b.EstadoIngreso as Estado", "a.dui ='" & txtDui.Value.ToString.Trim & "'", "", sUsuario, sPassword, sSucursal)
            fgEstadoIngreso.DataSource = dts.Tables(0)
            fgEstadoIngreso.Cols.Item(3).Width = 400

        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtDui_TextChanged(sender As Object, e As EventArgs) Handles txtDui.TextChanged

    End Sub

    Private Sub txtDui_DoubleClick(sender As Object, e As EventArgs) Handles txtDui.DoubleClick
        Dim frm As New frmAGenerico
        Dim dts As New DataSet
        dts = asociados.ConsultarEstadoIngreso("a.dui,rtrim(b.nombres) [Nombres],rtrim(b.Apellido1)[Primer Apellido],rtrim(b.apellido2)[Segundo Apellido],rtrim(b.apellidocas) [Apellido Casada]", "b.EstadoIngreso=1", "b.nombres", sUsuario, sPassword, sSucursal)

        With frm
            .Text = "Buscar Asociados"
            .Datos = dts
            .RefrescarGrid()
            .ColSeleccion = 0
            .ShowDialog()
        End With
        If frm.Resultado <> "" Then
            txtDui.Value = frm.Resultado
            btnMostrar_Click(sender, e)
        End If
    End Sub
End Class