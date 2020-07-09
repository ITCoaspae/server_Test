Public Class frmConsultaDICOM
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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
    Friend WithEvents txtNoSolicitud As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1txtObservaciones As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtNIT As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1txtNombre As C1.Win.C1Input.C1TextBox
    Friend WithEvents chkFiador As System.Windows.Forms.CheckBox
    Friend WithEvents chkSolicitante As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents c1txtCodPrestamo As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultaDICOM))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.c1txtCodPrestamo = New C1.Win.C1Input.C1TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoSolicitud = New C1.Win.C1Input.C1NumericEdit()
        Me.c1txtObservaciones = New C1.Win.C1Input.C1TextBox()
        Me.c1txtNIT = New C1.Win.C1Input.C1TextBox()
        Me.c1txtNombre = New C1.Win.C1Input.C1TextBox()
        Me.chkFiador = New System.Windows.Forms.CheckBox()
        Me.chkSolicitante = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtCodPrestamo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtNoSocio)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtAsociado)
        Me.GroupBox1.Controls.Add(Me.txtDui)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.c1txtCodPrestamo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNoSolicitud)
        Me.GroupBox1.Controls.Add(Me.c1txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.c1txtNIT)
        Me.GroupBox1.Controls.Add(Me.c1txtNombre)
        Me.GroupBox1.Controls.Add(Me.chkFiador)
        Me.GroupBox1.Controls.Add(Me.chkSolicitante)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(727, 284)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(115, 48)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(190, 23)
        Me.txtNoSocio.TabIndex = 74
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(10, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 18)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "No. Asociado:"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(247, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 19)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Asociado:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAsociado.Location = New System.Drawing.Point(331, 14)
        Me.txtAsociado.Multiline = True
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(370, 28)
        Me.txtAsociado.TabIndex = 76
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(115, 18)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(125, 24)
        Me.txtDui.TabIndex = 73
        Me.txtDui.Tag = Nothing
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(10, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 19)
        Me.Label14.TabIndex = 75
        Me.Label14.Text = "DUI Asociado:"
        '
        'c1txtCodPrestamo
        '
        Me.c1txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtCodPrestamo.Location = New System.Drawing.Point(511, 48)
        Me.c1txtCodPrestamo.MaxLength = 255
        Me.c1txtCodPrestamo.Name = "c1txtCodPrestamo"
        Me.c1txtCodPrestamo.NumericInput = False
        Me.c1txtCodPrestamo.Size = New System.Drawing.Size(190, 24)
        Me.c1txtCodPrestamo.TabIndex = 72
        Me.c1txtCodPrestamo.Tag = Nothing
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(386, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 18)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Prestamo:"
        '
        'txtNoSolicitud
        '
        Me.txtNoSolicitud.BackColor = System.Drawing.Color.White
        Me.txtNoSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSolicitud.CustomFormat = "######"
        Me.txtNoSolicitud.DataType = GetType(Integer)
        Me.txtNoSolicitud.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNoSolicitud.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtNoSolicitud.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtNoSolicitud.Location = New System.Drawing.Point(115, 78)
        Me.txtNoSolicitud.Name = "txtNoSolicitud"
        Me.txtNoSolicitud.ReadOnly = True
        Me.txtNoSolicitud.Size = New System.Drawing.Size(190, 27)
        Me.txtNoSolicitud.TabIndex = 70
        Me.txtNoSolicitud.Tag = Nothing
        Me.txtNoSolicitud.Value = 0
        Me.txtNoSolicitud.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'c1txtObservaciones
        '
        Me.c1txtObservaciones.BackColor = System.Drawing.Color.White
        Me.c1txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtObservaciones.EditMask = "0000-000000-000-0"
        Me.c1txtObservaciones.Location = New System.Drawing.Point(115, 204)
        Me.c1txtObservaciones.MaxLength = 255
        Me.c1txtObservaciones.Multiline = True
        Me.c1txtObservaciones.Name = "c1txtObservaciones"
        Me.c1txtObservaciones.NumericInput = False
        Me.c1txtObservaciones.ReadOnly = True
        Me.c1txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.c1txtObservaciones.Size = New System.Drawing.Size(586, 56)
        Me.c1txtObservaciones.TabIndex = 69
        Me.c1txtObservaciones.Tag = Nothing
        '
        'c1txtNIT
        '
        Me.c1txtNIT.BackColor = System.Drawing.Color.White
        Me.c1txtNIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtNIT.EditMask = "0000-000000-000-0"
        Me.c1txtNIT.Location = New System.Drawing.Point(115, 174)
        Me.c1txtNIT.MaxLength = 14
        Me.c1txtNIT.Name = "c1txtNIT"
        Me.c1txtNIT.NumericInput = False
        Me.c1txtNIT.ReadOnly = True
        Me.c1txtNIT.Size = New System.Drawing.Size(154, 23)
        Me.c1txtNIT.TabIndex = 68
        Me.c1txtNIT.Tag = Nothing
        '
        'c1txtNombre
        '
        Me.c1txtNombre.BackColor = System.Drawing.Color.White
        Me.c1txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtNombre.Location = New System.Drawing.Point(115, 144)
        Me.c1txtNombre.MaxLength = 255
        Me.c1txtNombre.Name = "c1txtNombre"
        Me.c1txtNombre.NumericInput = False
        Me.c1txtNombre.ReadOnly = True
        Me.c1txtNombre.Size = New System.Drawing.Size(586, 23)
        Me.c1txtNombre.TabIndex = 67
        Me.c1txtNombre.Tag = Nothing
        '
        'chkFiador
        '
        Me.chkFiador.Enabled = False
        Me.chkFiador.Location = New System.Drawing.Point(180, 110)
        Me.chkFiador.Name = "chkFiador"
        Me.chkFiador.Size = New System.Drawing.Size(125, 27)
        Me.chkFiador.TabIndex = 66
        Me.chkFiador.Text = "Fiador"
        '
        'chkSolicitante
        '
        Me.chkSolicitante.Enabled = False
        Me.chkSolicitante.Location = New System.Drawing.Point(13, 110)
        Me.chkSolicitante.Name = "chkSolicitante"
        Me.chkSolicitante.Size = New System.Drawing.Size(125, 27)
        Me.chkSolicitante.TabIndex = 65
        Me.chkSolicitante.Text = "Solicitante"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(10, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 19)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Observaciones:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(10, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 19)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "NIT:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(10, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 18)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(386, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Fecha y Hora:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(511, 78)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(190, 22)
        Me.dtpFecha.TabIndex = 59
        Me.dtpFecha.Value = New Date(2006, 12, 19, 16, 42, 14, 734)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(10, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "No. Solicitud:"
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "20,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.Location = New System.Drawing.Point(28, 363)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(730, 149)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 19
        '
        'frmConsultaDICOM
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(786, 556)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(786, 556)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(786, 556)
        Me.Name = "frmConsultaDICOM"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consulta DICOM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtCodPrestamo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub c1txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1txtCodPrestamo.DoubleClick
        Dim frm As New frmAGenerico
        Dim sCod, sNumSol As String
        Dim var, corrDic As Integer
        Dim dr As DataRow
        Dim oCred As wrCredito.wsLibCred, ds As New Data.DataSet

        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarPRPrestamos("a.*", "a.Dui='" & Me.txtDui.Value & "'", "a.Dui", False, sUsuario, sPassword,sSucursal)
            frm.Text = "Buscar Códigos de Prestamo"
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim <> "" Then
                sCod = IIf(IsDBNull(frm.Resultado.Trim), "", frm.Resultado.Trim)
                sNumSol = IIf(IsDBNull(frm.Resultado3.Trim), "", frm.Resultado3.Trim)
                Me.c1txtCodPrestamo.Value = sCod
                ds.Tables.Clear()
                ds = oCred.ConsultarDICOM("*", "NumSolicitud=" & sNumSol & "", "", sUsuario, sPassword,sSucursal)
                If ds.Tables.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    corrDic = dr("CorrelativoDicom")
                    Me.txtNoSolicitud.Value = IIf(IsDBNull(dr("NumSolicitud")), "", dr("NumSolicitud"))
                    Me.dtpFecha.Value = IIf(IsDBNull(dr("FechaHora")), "", dr("FechaHora"))
                    var = IIf(IsDBNull(dr("Solicitante")), 0, dr("Solicitante"))
                    If var = 1 Then
                        Me.chkSolicitante.Checked = True
                    End If
                    var = IIf(IsDBNull(dr("Fiador")), 0, dr("Fiador"))
                    If var = 1 Then
                        Me.chkFiador.Checked = True
                    End If
                    Me.c1txtNombre.Value = IIf(IsDBNull(dr("Nombre")), "", dr("Nombre"))
                    Me.c1txtNIT.Value = IIf(IsDBNull(dr("NIT")), "", dr("NIT"))
                    Me.c1txtObservaciones.Value = IIf(IsDBNull(dr("Observaciones")), "", dr("Observaciones"))
                End If
                ds.Tables.Clear()
                ds = oCred.ConsultarResultadosDICOM("*", "CorrelativoDicom=" & corrDic & "", "", sUsuario, sPassword,sSucursal)
                If ds.Tables.Count > 0 Then
                    fg.DataSource = ds.Tables(0)
                End If
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
  
    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,Apellido1,Apellido2,Nombres", "", "Apellido1", sUsuario, sPassword,sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword,sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtDui.Value = Trim(dr("DUI"))
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                Me.txtNoSocio.Text = Trim(dr("NoSocio"))
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNoSocio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoSocio.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("NoSocio,DUI,Apellido1,Apellido2,Nombres", "", "Apellido1", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "NoSocio='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtDui.Value = Trim(dr("DUI"))
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                Me.txtNoSocio.Text = Trim(dr("NoSocio"))
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
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

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text.Trim = "" Then Exit Sub
        Dim sTexto As String

        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            sTexto = Me.txtDui.Text.Trim
            If sTexto = "" Then      'Filtrar Registros

            ElseIf sTexto <> "" Then

                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                End If
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

End Class
