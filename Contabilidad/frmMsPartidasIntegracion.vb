Public Class frmMsPartidasIntegracion
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private vAccion As String, vCodigo As String
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnNuevo As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCerrar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroButton

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoPartidas As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsPartidasIntegracion))
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cmbTipoPartidas = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnNuevo = New MetroFramework.Controls.MetroButton()
        Me.btnModificar = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.btnCerrar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Location = New System.Drawing.Point(164, 14)
        Me.txtCodigo.MaxLength = 6
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(106, 22)
        Me.txtCodigo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "No. Partida Integración:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 19)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Descripción Partida:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(164, 61)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(478, 32)
        Me.txtDescripcion.TabIndex = 2
        '
        'cmbTipoPartidas
        '
        Me.cmbTipoPartidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoPartidas.Location = New System.Drawing.Point(390, 13)
        Me.cmbTipoPartidas.Name = "cmbTipoPartidas"
        Me.cmbTipoPartidas.Size = New System.Drawing.Size(252, 24)
        Me.cmbTipoPartidas.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(277, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tipo de Partida:"
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:15;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(28, 226)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 21
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.Size = New System.Drawing.Size(660, 222)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 3
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.Label4)
        Me.MetroPanel1.Controls.Add(Me.txtCodigo)
        Me.MetroPanel1.Controls.Add(Me.txtDescripcion)
        Me.MetroPanel1.Controls.Add(Me.Label1)
        Me.MetroPanel1.Controls.Add(Me.cmbTipoPartidas)
        Me.MetroPanel1.Controls.Add(Me.Label3)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 12
        Me.MetroPanel1.Location = New System.Drawing.Point(28, 73)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(660, 107)
        Me.MetroPanel1.TabIndex = 4
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 12
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(28, 187)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(90, 32)
        Me.btnNuevo.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnNuevo.UseSelectable = True
        Me.btnNuevo.UseStyleColors = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(125, 187)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(90, 32)
        Me.btnModificar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar.UseSelectable = True
        Me.btnModificar.UseStyleColors = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(222, 187)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(90, 32)
        Me.btnEliminar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar.UseSelectable = True
        Me.btnEliminar.UseStyleColors = True
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(500, 455)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 8
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'btnCerrar1
        '
        Me.btnCerrar1.Location = New System.Drawing.Point(598, 455)
        Me.btnCerrar1.Name = "btnCerrar1"
        Me.btnCerrar1.Size = New System.Drawing.Size(90, 32)
        Me.btnCerrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCerrar1.TabIndex = 9
        Me.btnCerrar1.Text = "Cerrar"
        Me.btnCerrar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnCerrar1.UseSelectable = True
        Me.btnCerrar1.UseStyleColors = True
        '
        'frmMsPartidasIntegracion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(721, 503)
        Me.Controls.Add(Me.btnCerrar1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.MetroPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(721, 503)
        Me.Name = "frmMsPartidasIntegracion"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Partidas de Integración"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Propiedades"
    Public Property Accion() As String
        Get
            Return vAccion
        End Get
        Set(ByVal Value As String)
            vAccion = Value
        End Set
    End Property
    Public Property Codigo() As String
        Get
            Return vCodigo
        End Get
        Set(ByVal Value As String)
            vCodigo = Value
        End Set
    End Property
#End Region

    Private Sub frmMsPartidasIntegracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCtb As New wrConta.wsLibContab, oApp As New wrAdmin.wsLibAdmin
        Dim dsTipo As New DataSet, dr As DataRow, ds As New DataSet, x As Integer

        dsTipo = oCtb.ObtenerTipoPartidasAut(oApp.Fecha.Year, sUsuario, sPassword, sSucursal)
        For Each dr In dsTipo.Tables(0).Rows
            cmbTipoPartidas.Items.Add(CStr(dr("Prefijo")) & " - " & CStr(dr("Descripcion")))
        Next
        Me.cmbTipoPartidas.SelectedIndex = 0
        If Me.vAccion = "Modificar" Then
            Me.txtCodigo.Text = Me.vCodigo
            ds = oCtb.ConsultarParametroPartidaIntegracion("*", "CodPartidaIntegrac='" & Me.txtCodigo.Text.Trim & "'", "CodPartidaIntegrac", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.txtDescripcion.Text = dr("Descripcion")
                For x = 0 To Me.cmbTipoPartidas.Items.Count - 1
                    Me.cmbTipoPartidas.SelectedIndex = x
                    If Mid(Me.cmbTipoPartidas.Text, 1, 2) = IIf(IsDBNull(dr("Prefijo")), "", dr("Prefijo")) Then
                        Me.cmbTipoPartidas.SelectedIndex = x
                        Exit For
                    End If
                Next
            End If
            ActualizaGrid()
            Me.txtCodigo.ReadOnly = True
        End If

    End Sub



    Private Sub Encabezado()

        fg.Cols.Item(1).Caption = "Código"
        fg.Cols.Item(2).Caption = "No."
        fg.Cols.Item(3).Caption = "Cód.Cuenta"
        fg.Cols.Item(4).Caption = "Tipo Cuenta"
        fg.Cols.Item(5).Caption = "Concepto"
        fg.Cols.Item(6).Caption = "Descripción"
        fg.Cols.Item(7).Caption = "Cód.Costo"
        fg.Cols.Item(8).Caption = "Cód.Beneficio"

        fg.Cols.Item(1).Width = 100
        fg.Cols.Item(2).Width = 77
        fg.Cols.Item(3).Width = 100
        fg.Cols.Item(4).Width = 100
        fg.Cols.Item(5).Width = 200
        fg.Cols.Item(6).Width = 200
        fg.Cols.Item(7).Width = 100
        fg.Cols.Item(8).Width = 100

    End Sub

    Private Sub ActualizaGrid()
        Dim oCtb As New wrConta.wsLibContab, ds As Data.DataSet = New Data.DataSet
        Try
            ds = oCtb.ConsultarDetParametroPartidaIntegracion("*", "CodPartidaIntegrac='" & Me.txtCodigo.Text.Trim & "'", "CodPartidaIntegrac", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Partidas de Integración." & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        If Me.txtCodigo.Text.Trim = "" Then Exit Sub

        Dim oCtb As New wrConta.wsLibContab, ds As New DataSet, pCampos As String, pValores As String
        Dim frm As New frmMsDetPartidasIntegracion

        ds = oCtb.ConsultarParametroPartidaIntegracion("*", "CodPartidaIntegrac='" & Me.txtCodigo.Text.Trim & "'", "CodPartidaIntegrac", sUsuario, sPassword, sSucursal)
        If ds.Tables(0).Rows.Count < 1 Then
            pCampos = "CodPartidaIntegrac,Descripcion,Prefijo"
            pValores = "'" & Me.txtCodigo.Text.Trim & "','" & Me.txtDescripcion.Text.Trim & "','" & Me.cmbTipoPartidas.Text.Substring(0, 2) & "'"
            If oCtb.InsertaParametroPartidaIntegracion(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                frm.Accion = "Agregar"
                frm.Codigo = Me.txtCodigo.Text.Trim
                frm.ShowDialog()
                ActualizaGrid()
            End If
        Else
            pCampos = "Descripcion='" & Me.txtDescripcion.Text.Trim & "',Prefijo='" & Me.cmbTipoPartidas.Text.Substring(0, 2) & "'"
            If oCtb.ModificaParametroPartidaIntegracion(Me.txtCodigo.Text.Trim, pCampos, sUsuario, sPassword, sSucursal) = True Then
                frm.Accion = "Agregar"
                frm.txtConcepto.Text = Me.txtDescripcion.Text
                frm.Codigo = Me.txtCodigo.Text.Trim
                frm.ShowDialog()
                ActualizaGrid()
            End If
        End If

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If fg.Row > -1 Then
            Dim frm As New frmMsDetPartidasIntegracion

            If Me.btnModificar.Text = "&Consulta" Then frm.btnGuardar1.Visible = False
            frm.Codigo = Me.txtCodigo.Text.Trim
            frm.Correlativo = fg.Item(fg.Row, "Correlativo")
            frm.Accion = "Modificar"
            frm.ShowDialog()
            ActualizaGrid()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If fg.Row > -1 Then
            If MsgBox("¿Desea eliminar el registro seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Parámetro") = MsgBoxResult.Yes Then
                Dim oCtb As New wrConta.wsLibContab
                oCtb.EliminaDetParametroPartidaIntegracion(fg.Item(fg.Row, "Correlativo"), sUsuario, sPassword, sSucursal)
                ActualizaGrid()
            End If
        End If
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            If Me.txtCodigo.Text.Trim = "" Then Exit Sub

            Dim oCtb As New wrConta.wsLibContab, ds As New DataSet, pCampos As String, pValores As String

            ds = oCtb.ConsultarParametroPartidaIntegracion("*", "CodPartidaIntegrac='" & Me.txtCodigo.Text.Trim & "'", "CodPartidaIntegrac", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count < 1 Then
                pCampos = "CodPartidaIntegrac,Descripcion,Prefijo"
                pValores = "'" & Me.txtCodigo.Text.Trim & "','" & Me.txtDescripcion.Text.Trim & "','" & Me.cmbTipoPartidas.Text.Substring(0, 2) & "'"
                If oCtb.InsertaParametroPartidaIntegracion(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                End If
            Else
                pCampos = "Descripcion='" & Me.txtDescripcion.Text.Trim & "',Prefijo='" & Me.cmbTipoPartidas.Text.Substring(0, 2) & "'"
                If oCtb.ModificaParametroPartidaIntegracion(Me.txtCodigo.Text.Trim, pCampos, sUsuario, sPassword, sSucursal) = True Then
                End If
            End If
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCerrar1_Click(sender As Object, e As EventArgs) Handles btnCerrar1.Click
        Me.Dispose()
    End Sub



End Class