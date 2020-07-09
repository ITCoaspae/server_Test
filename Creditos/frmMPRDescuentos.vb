Public Class frmMPRDescuentos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton

    'Private vTipoDeduccion As Prestamos.clsPrestamos.TipoDeduccion
    Private vTipoDeduccion As sifLib.Prestamos.clsPrestamos.TipoDeduccion

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
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMPRDescuentos))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
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
        Me.fg.ColumnInfo = "20,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(28, 112)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(474, 158)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 22
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(319, 73)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(90, 32)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 236
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(222, 73)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(90, 32)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 235
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(125, 73)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(90, 32)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 234
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(28, 73)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 32)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 233
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmMPRDescuentos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(530, 322)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Name = "frmMPRDescuentos"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Descuentos"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Propiedades"
    'Public Property TipoDeduccion() As Prestamos.clsPrestamos.TipoDeduccion
    Public Property TipoDeduccion() As sifLib.Prestamos.clsPrestamos.TipoDeduccion
        Get
            Return vTipoDeduccion
        End Get
        'Set(ByVal Value As Prestamos.clsPrestamos.TipoDeduccion)
        Set(ByVal Value As sifLib.Prestamos.clsPrestamos.TipoDeduccion)
            vTipoDeduccion = Value
        End Set
    End Property
#End Region

    Private Sub ActualizaGrid()
        Dim oCred As wrPrestamo.wsLibPrest
        Dim ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrPrestamo.wsLibPrest
            ds = oCred.ConsultarPRDeduccionesxTipoCredito("*", "a.Tipo='" & 2 & "'", "", 2, sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            Encabezado()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Encabezado()
        fg.Cols.Item(1).Caption = "Código"
        fg.Cols.Item(2).Caption = "Tipo de Crédito"

        fg.Cols.Item(0).Width = 20
        fg.Cols.Item(1).Width = 100
        fg.Cols.Item(2).Width = 250
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub frmMPRDescuentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ''If Me.vTipoDeduccion = Prestamos.clsPrestamos.TipoDeduccion.Escrituracion Then
        'If Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.Escrituracion Then
        '    Me.Text = "Gastos de Escrituración"
        '    'ElseIf Me.vTipoDeduccion = Prestamos.clsPrestamos.TipoDeduccion.Honorario Then
        'ElseIf Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.Honorario Then
        '    Me.Text = "Mantenimiento - Honorarios"
        '    'ElseIf Me.vTipoDeduccion = Prestamos.clsPrestamos.TipoDeduccion.Tramitacion Then
        'ElseIf Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.Tramitacion Then
        '    Me.Text = "Mantenimiento - Gastos de Tramitación"
        '    'ElseIf Me.vTipoDeduccion = Prestamos.clsPrestamos.TipoDeduccion.TramitacionxRango Then
        'ElseIf Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.TramitacionxRango Then
        '    Me.Text = " Gastos de Tramitación por Rango"
        '    'ElseIf Me.vTipoDeduccion = Prestamos.clsPrestamos.TipoDeduccion.EscrituracionxRango Then
        'ElseIf Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.EscrituracionxRango Then
        '    Me.Text = "Gastos de Escrituración por Rango"
        'End If
        ActualizaGrid()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try

            Dim frm As New frmMsCrEncDescuentos
            frm.TipoDeduccion = 2
            frm.Accion = "Guardar"
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizaGrid()

        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If fg.Row > -1 Then
                Dim oCred As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest
                'If Me.vTipoDeduccion = Prestamos.clsPrestamos.TipoDeduccion.TramitacionxRango Or Me.vTipoDeduccion = Prestamos.clsPrestamos.TipoDeduccion.EscrituracionxRango Then

                Dim frm As New frmMsCrEncDescuentos
                frm.TipoDeduccion = 2
                frm.txtCodTipoCredito.Text = fg.Item(fg.Row, "CodTipoCredito")
                    frm.Accion = "Modificar"
                    frm.StartPosition = FormStartPosition.CenterScreen
                    frm.ShowDialog()

                ActualizaGrid()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If fg.Row > -1 Then
                Dim oCred As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest
                'Dim dr As Data.DataRow, 
                Dim ds As New Data.DataSet
                If MsgBox("¿Está seguro que desea eliminar el registro seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    oCred.EliminarPRDeducciones("CodTipoCredito='" & fg.Item(fg.Row, "CodTipoCredito") & "' and Tipo='" & 2 & "'", 2, sUsuario, sPassword, sSucursal)
                    ActualizaGrid()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            If fg.Row > -1 Then
                Dim oCred As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest

                Dim frm As New frmMsCrEncDescuentos
                frm.TipoDeduccion = 2
                frm.txtCodTipoCredito.Text = fg.Item(fg.Row, "CodTipoCredito")
                    frm.Accion = "Modificar"
                    frm.btNew1.Visible = False
                    frm.btDel1.Visible = False
                    frm.btEdit1.Location = New Point(8, 16)
                    frm.StartPosition = FormStartPosition.CenterScreen
                    frm.ShowDialog()

                ActualizaGrid()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class