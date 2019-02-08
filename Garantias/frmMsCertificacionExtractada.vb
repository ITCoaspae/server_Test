Public Class frmMsCertificacionExtractada
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim vDui As String, vNumSolicitud As Long
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton

#Region "Propiedades"


    Public Property Dui() As String
        Get
            Return vDui
        End Get
        Set(ByVal Value As String)
            vDui = Value
        End Set
    End Property

    Public Property NumSolicitud() As Long
        Get
            Return vNumSolicitud
        End Get
        Set(ByVal Value As Long)
            vNumSolicitud = Value
        End Set
    End Property

#End Region
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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPlazo As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents lblConcedido As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsCertificacionExtractada))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblPlazo = New System.Windows.Forms.Label()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.lblConcedido = New System.Windows.Forms.Label()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox4.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.Controls.Add(Me.lblPlazo)
        Me.GroupBox4.Controls.Add(Me.lblMonto)
        Me.GroupBox4.Controls.Add(Me.lblConcedido)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox4.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(632, 48)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'lblPlazo
        '
        Me.lblPlazo.Location = New System.Drawing.Point(552, 16)
        Me.lblPlazo.Name = "lblPlazo"
        Me.lblPlazo.Size = New System.Drawing.Size(64, 16)
        Me.lblPlazo.TabIndex = 3
        Me.lblPlazo.Text = "Plazo:"
        '
        'lblMonto
        '
        Me.lblMonto.Location = New System.Drawing.Point(416, 16)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(120, 16)
        Me.lblMonto.TabIndex = 2
        Me.lblMonto.Text = "Monto:"
        '
        'lblConcedido
        '
        Me.lblConcedido.Location = New System.Drawing.Point(8, 16)
        Me.lblConcedido.Name = "lblConcedido"
        Me.lblConcedido.Size = New System.Drawing.Size(400, 24)
        Me.lblConcedido.TabIndex = 1
        Me.lblConcedido.Text = "Crédito concedido a:"
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(185, 118)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(75, 28)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 218
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(104, 117)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(75, 28)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 217
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(23, 117)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 216
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:167;}" & Global.Microsoft.VisualBasic.ChrW(9) & "2{Width:178;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(23, 152)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.Size = New System.Drawing.Size(632, 300)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 9
        '
        'frmMsCertificacionExtractada
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(678, 500)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnAgregar1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(678, 500)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(678, 500)
        Me.Name = "frmMsCertificacionExtractada"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Certificaciones Extractadas"
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub frmCertificacionExtractada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargaDatosIniciales()
    End Sub
    Private Sub CargaDatosIniciales()
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection, oAsoc As New wrAsociados.wsLibAsoc, dr As DataRow, vDui As String

            ds = oCred.ConsultarCertificacionExtractada("*", "NumSolicitud=" & vNumSolicitud & " and Tipo='C'", "NumSolicitud", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            ds = oCred.ConsultarPRPrestamos("Dui,Monto,PlazoMeses", "NumSolicitud=" & vNumSolicitud & "", "NumSolicitud", False, sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                vDui = dr("Dui")
                Me.lblMonto.Text = "Monto: $" & IIf(IsDBNull(dr("Monto")), "$0.00", Format(dr("Monto"), "##0.00"))
                Me.lblPlazo.Text = "Plazo: " & IIf(IsDBNull(dr("PlazoMeses")), "0", dr("PlazoMeses"))
            End If
            ds.Clear()
            ds = oAsoc.ConsultarAsociado("Nombres,Apellido1,Apellido2", "Dui='" & vDui & "'", "Dui", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.lblConcedido.Text = "Crédito concedido a: " & dr("Nombres") & " " & dr("Apellido1") & " " & dr("Apellido2")
            End If
            ds.Clear()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As New frmCertificacionExtractada
            frm.NumSolicitud = vNumSolicitud
            frm.NoDoc = ""
            frm.btnGuardar1.Text = "&Guardar"
            frm.ShowDialog()
            CargaDatosIniciales()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            If fg.Row > 0 Then
                Dim frm As New frmCertificacionExtractada
                frm.NumSolicitud = fg.Item(fg.Row, "NumSolicitud")
                frm.NoDoc = fg.Item(fg.Row, "NoComprobante")
                frm.btnGuardar1.Text = "&Modificar"
                frm.ShowDialog()
                CargaDatosIniciales()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            If fg.Row > 0 Then
                If MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Certificación Extractada", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dim oCred As New wrCredito.wsLibCred
                    oCred.EliminarCertificacionExtractada(Me.fg.Item(Me.fg.Row, "NoComprobante"), "C", sUsuario, sPassword, sSucursal)
                    CargaDatosIniciales()
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub


End Class