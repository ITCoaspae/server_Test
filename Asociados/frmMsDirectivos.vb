Public Class frmMsDirectivos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pAccion As String
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNuevo1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsDirectivos))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnEliminar = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnNuevo1 = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.Location = New System.Drawing.Point(28, 190)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 22
        Me.fg.Size = New System.Drawing.Size(704, 196)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 7
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(92, 66)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(77, 22)
        Me.txtCodigo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(28, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 19)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "C�digo:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(270, 65)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(461, 22)
        Me.txtDescripcion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(176, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 19)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Descripci�n:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(28, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 23)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(92, 97)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(106, 22)
        Me.dtpFecha.TabIndex = 2
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(254, 151)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(105, 32)
        Me.btnEliminar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar.TabIndex = 136
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseSelectable = True
        Me.btnEliminar.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(143, 151)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(104, 32)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 135
        Me.btnModificar1.Text = "&Modificar"
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnNuevo1
        '
        Me.btnNuevo1.Location = New System.Drawing.Point(31, 151)
        Me.btnNuevo1.Name = "btnNuevo1"
        Me.btnNuevo1.Size = New System.Drawing.Size(105, 32)
        Me.btnNuevo1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnNuevo1.TabIndex = 134
        Me.btnNuevo1.Text = "&Nuevo"
        Me.btnNuevo1.UseSelectable = True
        Me.btnNuevo1.UseStyleColors = True
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(627, 104)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(104, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 137
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsDirectivos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(760, 413)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnNuevo1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsDirectivos"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Directivos"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Encabezado()

        fg.Cols.Item(1).Caption = "No."
        fg.Cols.Item(2).Caption = "C�digo"
        fg.Cols.Item(3).Caption = "Cargo"
        fg.Cols.Item(4).Caption = "Nombre"
        fg.Cols.Item(5).Caption = "Fecha Inicio"
        fg.Cols.Item(6).Caption = "Fecha Fin"

        fg.Cols.Item(1).Width = 77
        fg.Cols.Item(2).Width = 100
        fg.Cols.Item(3).Width = 100
        fg.Cols.Item(4).Width = 200
        fg.Cols.Item(5).Width = 100
        fg.Cols.Item(6).Width = 100

    End Sub

    Private Sub ActualizaGrid()
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As Data.DataSet = New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarDetDirectivos("*", "Codigo='" & pCodigo & "'", "Codigo,Correlativo", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            fg.Cols.Item(1).Visible = False
            fg.Cols.Item(2).Visible = False
            fg.Cols.Item(3).Visible = False

        Catch ex As Exception
            MessageBox.Show("Error en la recuperaci�n de datos tabla Directivos." & "System Error: " & ex.Message.ToString(), "Error de Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Encabezado()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub frmMsDirectivos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection

        If Me.pAccion = "Modificar" Then

            ds = oAsoc.ConsultarDirectivos("*", "Codigo='" & pCodigo & "'", "Codigo", sUsuario, sPassword, sSucursal)

            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtCodigo.Text = pCodigo
                txtCodigo.Enabled = False
                txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                dtpFecha.Value = IIf(IsDBNull(Filas.Item(0)("Fecha")), Now, Filas.Item(0)("Fecha"))
                Me.btnNuevo1.Enabled = True
            End If
        Else
            Me.dtpFecha.Value = Now
            Me.txtCodigo.Text = oAsoc.ObtenerCorrelativoDirectivos("Codigo", sUsuario, sPassword, sSucursal)
        End If
        ActualizaGrid()
        Encabezado()
        txtCodigo.Focus()
    End Sub



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String

        Select Case oAsoc.AutorizaDatos(Trim(Me.txtDescripcion.Text), "x", "x", "x", "x")
            Case 1
                MsgBox("La descripci�n no puede quedar vac�a. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Directivos")
                Exit Sub
        End Select

        If Me.btnGuardar1.Text = "&Guardar" Then
            pCampos = "Codigo,Descripcion,Fecha"
            pValores = "" & Me.txtCodigo.Text.Trim & ",'" & Trim(txtDescripcion.Text) & "','" & Format(Me.dtpFecha.Value, "dd/MM/yyyy") & "'"
            If oAsoc.InsertarDirectivos(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                Me.btnGuardar1.Text = "&Modificar"
                Me.pCodigo = Me.txtCodigo.Text.Trim
                Me.pAccion = "Modificar"
                Me.btnNuevo1.Enabled = True
            Else
                MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

            End If
        ElseIf Me.btnGuardar1.Text = "&Modificar" Then
            pCampos = "Descripcion='" & Trim(txtDescripcion.Text) & "',Fecha='" & Format(Me.dtpFecha.Value, "dd/MM/yyyy") & "'"
            If oAsoc.ModificarDirectivos("Codigo='" & Trim(pCodigo) & "'", pCampos, sUsuario, sPassword, sSucursal) = True Then
                MetroFramework.MetroMessageBox.Show(Me, mensajeUpdateRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                Me.Dispose()
            Else
                MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnNuevo1_Click(sender As Object, e As EventArgs) Handles btnNuevo1.Click
        Dim frm As New frmMsAsocDirectivos
        frm.pAccion = "Guardar"
        frm.pCodigo = Me.pCodigo
        frm.pCorrelativo = ""
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
        ActualizaGrid()
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        If fg.Row <> -1 Then
            Dim frm As New frmMsAsocDirectivos
            frm.pAccion = "Modificar"
            frm.pCodigo = Me.pCodigo
            frm.btnGuardar1.Text = "&Modificar"
            frm.pCorrelativo = fg.Item(fg.Row, "Correlativo")
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If fg.Row <> -1 Then
            If MsgBox("�Desea eliminar el registro?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar registro") = MsgBoxResult.Yes Then
                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
                If (oAsoc.EliminarDetDirectivos("Correlativo='" & fg.Item(fg.Row, "Correlativo") & "'", sUsuario, sPassword, sSucursal)) = True Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeDeleteRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                End If
                ActualizaGrid()
            End If
        End If
    End Sub


    Private Sub frmMsDirectivos_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class