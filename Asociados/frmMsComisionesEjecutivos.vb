Public Class frmMsComisionesEjecutivos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private pAccion As String, pCodigo As String
    Friend WithEvents btnEliminar As MetroFramework.Controls.MetroButton
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNuevo1 As MetroFramework.Controls.MetroButton

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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cbAplicaA As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTipoComision As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents rbPorcentaje As System.Windows.Forms.RadioButton
    Friend WithEvents rbMonto As System.Windows.Forms.RadioButton
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbCNumero As System.Windows.Forms.RadioButton
    Friend WithEvents rbCMonto As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsComisionesEjecutivos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbCMonto = New System.Windows.Forms.RadioButton()
        Me.rbMonto = New System.Windows.Forms.RadioButton()
        Me.rbCNumero = New System.Windows.Forms.RadioButton()
        Me.rbPorcentaje = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAplicaA = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtTipoComision = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminar = New MetroFramework.Controls.MetroButton()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnNuevo1 = New MetroFramework.Controls.MetroButton()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.rbCMonto)
        Me.GroupBox1.Controls.Add(Me.rbMonto)
        Me.GroupBox1.Controls.Add(Me.rbCNumero)
        Me.GroupBox1.Controls.Add(Me.rbPorcentaje)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbAplicaA)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.txtTipoComision)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 131)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'rbCMonto
        '
        Me.rbCMonto.Location = New System.Drawing.Point(350, 100)
        Me.rbCMonto.Name = "rbCMonto"
        Me.rbCMonto.Size = New System.Drawing.Size(80, 16)
        Me.rbCMonto.TabIndex = 6
        Me.rbCMonto.Text = "&Montos ($)"
        '
        'rbMonto
        '
        Me.rbMonto.Checked = True
        Me.rbMonto.Location = New System.Drawing.Point(350, 76)
        Me.rbMonto.Name = "rbMonto"
        Me.rbMonto.Size = New System.Drawing.Size(80, 16)
        Me.rbMonto.TabIndex = 4
        Me.rbMonto.TabStop = True
        Me.rbMonto.Text = "&Monto ($)"
        '
        'rbCNumero
        '
        Me.rbCNumero.Checked = True
        Me.rbCNumero.Location = New System.Drawing.Point(192, 100)
        Me.rbCNumero.Name = "rbCNumero"
        Me.rbCNumero.Size = New System.Drawing.Size(152, 16)
        Me.rbCNumero.TabIndex = 5
        Me.rbCNumero.TabStop = True
        Me.rbCNumero.Text = "&Número de colocaciones"
        '
        'rbPorcentaje
        '
        Me.rbPorcentaje.Location = New System.Drawing.Point(192, 78)
        Me.rbPorcentaje.Name = "rbPorcentaje"
        Me.rbPorcentaje.Size = New System.Drawing.Size(88, 16)
        Me.rbPorcentaje.TabIndex = 3
        Me.rbPorcentaje.Text = "&Porcentaje"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 146
        Me.Label3.Text = "Comisión calculada por:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 16)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Valor de la comisión definida por:"
        '
        'cbAplicaA
        '
        Me.cbAplicaA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAplicaA.Items.AddRange(New Object() {"Membresías", "Créditos", "DPF"})
        Me.cbAplicaA.Location = New System.Drawing.Point(111, 44)
        Me.cbAplicaA.Name = "cbAplicaA"
        Me.cbAplicaA.Size = New System.Drawing.Size(299, 21)
        Me.cbAplicaA.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(6, 44)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(102, 16)
        Me.Label22.TabIndex = 143
        Me.Label22.Text = "Calcular en base a:"
        '
        'txtTipoComision
        '
        Me.txtTipoComision.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoComision.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoComision.Location = New System.Drawing.Point(173, 11)
        Me.txtTipoComision.MaxLength = 100
        Me.txtTipoComision.Name = "txtTipoComision"
        Me.txtTipoComision.Size = New System.Drawing.Size(237, 20)
        Me.txtTipoComision.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(111, 11)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(56, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Tipo de Comisión:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnModificar1)
        Me.GroupBox2.Controls.Add(Me.btnNuevo1)
        Me.GroupBox2.Controls.Add(Me.fg)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(508, 201)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(192, 19)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(87, 28)
        Me.btnEliminar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar.TabIndex = 133
        Me.btnEliminar.Text = "&Eliminar"
        Me.btnEliminar.UseSelectable = True
        Me.btnEliminar.UseStyleColors = True
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(99, 19)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(87, 28)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 132
        Me.btnModificar1.Text = "&Modificar"
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnNuevo1
        '
        Me.btnNuevo1.Location = New System.Drawing.Point(6, 19)
        Me.btnNuevo1.Name = "btnNuevo1"
        Me.btnNuevo1.Size = New System.Drawing.Size(87, 28)
        Me.btnNuevo1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnNuevo1.TabIndex = 131
        Me.btnNuevo1.Text = "&Nuevo"
        Me.btnNuevo1.UseSelectable = True
        Me.btnNuevo1.UseStyleColors = True
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:15;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(6, 53)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.Size = New System.Drawing.Size(496, 142)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 3
        '
        'frmMsComisionesEjecutivos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(553, 424)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsComisionesEjecutivos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Comisiones Mercadeo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Propiedades"

    Public Property Accion() As String
        Get
            Return pAccion
        End Get
        Set(ByVal Value As String)
            pAccion = Value
        End Set
    End Property

    Public Property Codigo() As String
        Get
            Return pCodigo
        End Get
        Set(ByVal Value As String)
            pCodigo = Value
        End Set
    End Property

#End Region

    Private Sub btNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub frmMsComisionesEjecutivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet, dr As DataRow

        Me.cbAplicaA.SelectedIndex = 0

        If Me.Accion = "Modificar" Then
            ds = oAsoc.ConsultarComisionesMercadeo("*", "Codigo='" & pCodigo & "'", "Codigo", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.txtCodigo.Text = pCodigo
                Me.txtTipoComision.Text = dr("Descripcion")
                If Trim(dr("TipoCalculo")) = "Porcentaje" Then
                    Me.rbPorcentaje.Checked = True
                ElseIf Trim(dr("TipoCalculo")) = "Monto" Then
                    Me.rbMonto.Checked = True
                End If
                If dr("BaseCalculo") = "C" Then
                    Me.rbCNumero.Checked = True
                ElseIf dr("BaseCalculo") = "M" Then
                    Me.rbCMonto.Checked = True
                End If
                Me.cbAplicaA.SelectedIndex = dr("AplicaA")
                Encabezado()
            End If
        Else
            Me.txtCodigo.Text = CStr(oAsoc.ObtenerCorrelativoComisionesMercadeo("Codigo", sUsuario, sPassword, sSucursal)).PadLeft(4, "0")
            pCodigo = Me.txtCodigo.Text.Trim
        End If
        Me.txtCodigo.ReadOnly = True

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Encabezado()

        Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
        ds = oAsoc.ConsultarDetalleComisionesMercadeo("Correlativo,Codigo,ValorMinimo,ValorMaximo,Valor", "Codigo='" & pCodigo & "'", "Codigo", sUsuario, sPassword, sSucursal)
        Me.fg.DataSource = ds.Tables(0)

        If Me.pAccion = "Guardar" And ds.Tables(0).Rows.Count > 0 Then Me.txtCodigo.Enabled = False
        fg.Cols.Item(1).Caption = "No."
        fg.Cols.Item(2).Caption = "Código"
        fg.Cols.Item(3).Caption = "Valor Mínimo"
        fg.Cols.Item(4).Caption = "Valor Máximo"
        fg.Cols.Item(5).Caption = "Valor"
        fg.Cols.Item(0).Width = 20
        fg.Cols.Item(1).Width = 100
        fg.Cols.Item(2).Width = 100
        fg.Cols.Item(3).Width = 100
        fg.Cols.Item(4).Width = 100
        fg.Cols.Item(5).Width = 100

    End Sub

    Private Sub btnNuevo1_Click(sender As Object, e As EventArgs) Handles btnNuevo1.Click

        Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet, vTipo As String, vBaseCalculo As String
        ds = oAsoc.ConsultarComisionesMercadeo("*", "Codigo='" & Me.txtCodigo.Text.Trim & "'", "Codigo", sUsuario, sPassword, sSucursal)

        If Me.rbMonto.Checked = True Then
            vTipo = "Monto"
        ElseIf Me.rbPorcentaje.Checked = True Then
            vTipo = "Porcentaje"
        End If

        If Me.rbCMonto.Checked = True Then
            vBaseCalculo = "M"
        ElseIf Me.rbCNumero.Checked = True Then
            vBaseCalculo = "C"
        End If

        If ds.Tables(0).Rows.Count <= 0 Then
            If Me.txtCodigo.Text.Trim = "" Then
                Exit Sub
            End If

            If oAsoc.InsertarComisionesMercadeo("Codigo,Descripcion,AplicaA,TipoCalculo,BaseCalculo", "'" & Me.txtCodigo.Text.Trim & "','" & Me.txtTipoComision.Text.Trim & "','" & Me.cbAplicaA.SelectedIndex & "','" & vTipo & "','" & vBaseCalculo & "'", sUsuario, sPassword, sSucursal) = True Then
            Else
                Exit Sub
            End If
        Else
            If oAsoc.ModificarComisionesMercadeo("Codigo='" & Me.txtCodigo.Text.Trim & "'", "Descripcion='" & Me.txtTipoComision.Text.Trim & "',AplicaA='" & Me.cbAplicaA.SelectedIndex & "',TipoCalculo='" & vTipo & "',BaseCalculo='" & vBaseCalculo & "'", sUsuario, sPassword, sSucursal) = True Then
            Else
                Exit Sub
            End If
        End If

        Dim frm As frmMsDetTiposComision = New frmMsDetTiposComision
        frm.StartPosition = FormStartPosition.CenterScreen
        If vTipo = "Monto" Then
            frm.lblMonto.Text = "Monto ($):"
        ElseIf vTipo = "Porcentaje" Then
            frm.lblMonto.Text = "Porcentaje (%):"
        End If
        frm.Codigo = pCodigo
        frm.Accion = "Guardar"
        frm.ShowDialog()
        Encabezado()
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click

        If fg.Row > -1 Then
            Dim frm As New frmMsDetTiposComision
            frm.btnGuardar1.Text = "&Modificar"
            frm.Accion = "Modificar"
            frm.Correlativo = fg.Item(fg.Row, "Correlativo")
            frm.Codigo = fg.Item(fg.Row, "Codigo")
            If Me.btnEliminar.Enabled = False Then frm.btnGuardar1.Visible = False
            frm.ShowDialog()
            Encabezado()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If fg.Row > -1 Then
            If MsgBox("¿Desea eliminar el registro seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                Dim oAsoc As New wrAsociados.wsLibAsoc
                oAsoc.EliminarDetalleComisionesMercadeo("Correlativo='" & fg.Item(fg.Row, "Correlativo") & "'", sUsuario, sPassword, sSucursal)
                Encabezado()
            End If
        End If
    End Sub



End Class