Public Class frmMsAhTasasInteres
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Public pAccion As String, pCodigo As String
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents c1nTasaActiva As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nTasaPlaneada As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.c1nTasaActiva = New C1.Win.C1Input.C1NumericEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.c1nTasaPlaneada = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.c1nTasaActiva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nTasaPlaneada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Green
        Me.GroupBox1.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle Tasas de Interés:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.c1nTasaActiva)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.c1nTasaPlaneada)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(10, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(576, 64)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos de Tasa de interés:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(509, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(19, 18)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "%"
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(240, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 18)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "%"
        '
        'c1nTasaActiva
        '
        Me.c1nTasaActiva.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTasaActiva.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nTasaActiva.Location = New System.Drawing.Point(125, 28)
        Me.c1nTasaActiva.Name = "c1nTasaActiva"
        Me.c1nTasaActiva.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTasaActiva.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTasaActiva.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTasaActiva.Size = New System.Drawing.Size(105, 24)
        Me.c1nTasaActiva.TabIndex = 0
        Me.c1nTasaActiva.Tag = Nothing
        Me.c1nTasaActiva.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTasaActiva.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(298, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 18)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Tasa Planeada:"
        Me.Label5.Visible = False
        '
        'c1nTasaPlaneada
        '
        Me.c1nTasaPlaneada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nTasaPlaneada.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.c1nTasaPlaneada.Location = New System.Drawing.Point(403, 28)
        Me.c1nTasaPlaneada.Name = "c1nTasaPlaneada"
        Me.c1nTasaPlaneada.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nTasaPlaneada.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nTasaPlaneada.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nTasaPlaneada.Size = New System.Drawing.Size(96, 24)
        Me.c1nTasaPlaneada.TabIndex = 1
        Me.c1nTasaPlaneada.Tag = Nothing
        Me.c1nTasaPlaneada.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTasaPlaneada.Visible = False
        Me.c1nTasaPlaneada.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Tasa Vigente:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 74)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fechas de aplicación para Tasa de interés:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(403, 28)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(106, 23)
        Me.dtpFechaFin.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(307, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 18)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Fecha de Fin:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(125, 28)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(105, 23)
        Me.dtpFechaInicio.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 18)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Fecha de Inicio:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Location = New System.Drawing.Point(134, 18)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(120, 23)
        Me.txtCodigo.TabIndex = 0
        Me.txtCodigo.Visible = False
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Correlativo:"
        Me.Label1.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(527, 255)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(96, 32)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar.TabIndex = 215
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'frmMsAhTasasInteres
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(652, 310)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhTasasInteres"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = " Parámetros Generales - Tasas de Interés DPF"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.c1nTasaActiva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nTasaPlaneada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub



    Private Sub btProcesar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim oAh As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
        Dim ds As New Data.DataSet

        Dim pCampos As String, pValores As String
        Try
            If pAccion = "Guardar" Then
                Me.btnGuardar.Text = "&Guardar"
                pCampos = "FechaIni,FechaFin,TasaActiva,TasaPlaneada"
                pValores = "'" & Format(Me.dtpFechaInicio.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "','" & Val(Me.c1nTasaActiva.Value) & "','" & Val(Me.c1nTasaPlaneada.Value) & "'"
                oAh.InsertaTasasInteres(pCampos, pValores, sUsuario, sPassword, sSucursal)
                Me.Dispose()
            ElseIf pAccion = "Modificar" Then
                Me.btnGuardar.Text = "&Modificar"
                pCampos = "FechaIni='" & Format(Me.dtpFechaInicio.Value, "dd/MM/yyyy") & "',FechaFin='" & Format(Me.dtpFechaFin.Value, "dd/MM/yyyy") & "',TasaActiva='" & Val(Me.c1nTasaActiva.Value) & "',TasaPlaneada='" & Val(Me.c1nTasaPlaneada.Value) & "'"
                oAh.ModificaTasasInteres(pCodigo, pCampos, sUsuario, sPassword, sSucursal)
                Me.Dispose()
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsAhTasasInteres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ds As New Data.DataSet, Filas As Data.DataRowCollection
        Dim oAsoc As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
        Try
            If Me.btnGuardar.Text = "&Modificar" Then

                ds = oAsoc.ConsultarTasasInteres("*", "Correlativo='" & pCodigo & "'", "Correlativo", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.dtpFechaInicio.Value = CStr(Filas.Item(0)("FechaIni"))
                    Me.dtpFechaFin.Value = CStr(Filas.Item(0)("FechaFin"))
                    Me.c1nTasaActiva.Value = CDbl(Filas.Item(0)("TasaActiva"))
                    Me.c1nTasaPlaneada.Value = CDbl(Filas.Item(0)("TasaPlaneada"))
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmMsAhTasasInteres_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
