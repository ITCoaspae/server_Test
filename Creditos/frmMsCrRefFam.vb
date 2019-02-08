Public Class frmMsCrRefFam
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pNoSolic As Long, pCodEnlace As Long, pCorrelativo As Long, pAccion As String
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents txtDirTrab As System.Windows.Forms.TextBox
    Friend WithEvents txtTrabajo As System.Windows.Forms.TextBox
    Friend WithEvents txtTelCasa As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTelTrab As System.Windows.Forms.TextBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCel As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOtro As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtApellido3 As System.Windows.Forms.TextBox
    Friend WithEvents cbPar As System.Windows.Forms.ComboBox
    Friend WithEvents cbParentesco As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTelTrab = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.txtDirTrab = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.txtTrabajo = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cbPar = New System.Windows.Forms.ComboBox()
        Me.cbParentesco = New System.Windows.Forms.ComboBox()
        Me.txtApellido3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOtro = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelCasa = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.White
        Me.GroupBox8.Controls.Add(Me.txtCargo)
        Me.GroupBox8.Controls.Add(Me.Label1)
        Me.GroupBox8.Controls.Add(Me.txtTelTrab)
        Me.GroupBox8.Controls.Add(Me.Label64)
        Me.GroupBox8.Controls.Add(Me.txtDirTrab)
        Me.GroupBox8.Controls.Add(Me.Label66)
        Me.GroupBox8.Controls.Add(Me.Label63)
        Me.GroupBox8.Controls.Add(Me.txtTrabajo)
        Me.GroupBox8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox8.Location = New System.Drawing.Point(23, 255)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(504, 147)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Datos del Trabajo"
        '
        'txtCargo
        '
        Me.txtCargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCargo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargo.Location = New System.Drawing.Point(95, 97)
        Me.txtCargo.MaxLength = 100
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCargo.Size = New System.Drawing.Size(399, 20)
        Me.txtCargo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "Cargo:"
        '
        'txtTelTrab
        '
        Me.txtTelTrab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelTrab.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelTrab.Location = New System.Drawing.Point(95, 123)
        Me.txtTelTrab.MaxLength = 100
        Me.txtTelTrab.Name = "txtTelTrab"
        Me.txtTelTrab.Size = New System.Drawing.Size(152, 20)
        Me.txtTelTrab.TabIndex = 3
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.Black
        Me.Label64.Location = New System.Drawing.Point(6, 123)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(88, 16)
        Me.Label64.TabIndex = 147
        Me.Label64.Text = "Teléfono Oficina:"
        Me.Label64.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDirTrab
        '
        Me.txtDirTrab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDirTrab.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDirTrab.Location = New System.Drawing.Point(95, 45)
        Me.txtDirTrab.MaxLength = 255
        Me.txtDirTrab.Multiline = True
        Me.txtDirTrab.Name = "txtDirTrab"
        Me.txtDirTrab.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDirTrab.Size = New System.Drawing.Size(399, 46)
        Me.txtDirTrab.TabIndex = 1
        '
        'Label66
        '
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Black
        Me.Label66.Location = New System.Drawing.Point(6, 47)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(64, 16)
        Me.Label66.TabIndex = 143
        Me.Label66.Text = "Dirección:"
        '
        'Label63
        '
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.Black
        Me.Label63.Location = New System.Drawing.Point(6, 21)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(88, 16)
        Me.Label63.TabIndex = 139
        Me.Label63.Text = "Lugar de trabajo:"
        '
        'txtTrabajo
        '
        Me.txtTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTrabajo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTrabajo.Location = New System.Drawing.Point(95, 19)
        Me.txtTrabajo.MaxLength = 255
        Me.txtTrabajo.Name = "txtTrabajo"
        Me.txtTrabajo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTrabajo.Size = New System.Drawing.Size(399, 20)
        Me.txtTrabajo.TabIndex = 0
        '
        'GroupBox7
        '
        Me.GroupBox7.BackColor = System.Drawing.Color.White
        Me.GroupBox7.Controls.Add(Me.cbPar)
        Me.GroupBox7.Controls.Add(Me.cbParentesco)
        Me.GroupBox7.Controls.Add(Me.txtApellido3)
        Me.GroupBox7.Controls.Add(Me.Label7)
        Me.GroupBox7.Controls.Add(Me.txtApellido2)
        Me.GroupBox7.Controls.Add(Me.txtApellido1)
        Me.GroupBox7.Controls.Add(Me.Label6)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Controls.Add(Me.Label3)
        Me.GroupBox7.Controls.Add(Me.txtOtro)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.txtCel)
        Me.GroupBox7.Controls.Add(Me.Label4)
        Me.GroupBox7.Controls.Add(Me.txtTelCasa)
        Me.GroupBox7.Controls.Add(Me.Label65)
        Me.GroupBox7.Controls.Add(Me.txtNombre)
        Me.GroupBox7.Controls.Add(Me.Label67)
        Me.GroupBox7.Controls.Add(Me.txtDireccion)
        Me.GroupBox7.Controls.Add(Me.Label68)
        Me.GroupBox7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.Teal
        Me.GroupBox7.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(504, 186)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Referencias Familiares"
        '
        'cbPar
        '
        Me.cbPar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPar.Location = New System.Drawing.Point(95, 128)
        Me.cbPar.Name = "cbPar"
        Me.cbPar.Size = New System.Drawing.Size(399, 22)
        Me.cbPar.TabIndex = 7
        '
        'cbParentesco
        '
        Me.cbParentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbParentesco.Location = New System.Drawing.Point(95, 128)
        Me.cbParentesco.Name = "cbParentesco"
        Me.cbParentesco.Size = New System.Drawing.Size(399, 22)
        Me.cbParentesco.TabIndex = 158
        Me.cbParentesco.Visible = False
        '
        'txtApellido3
        '
        Me.txtApellido3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido3.Location = New System.Drawing.Point(342, 50)
        Me.txtApellido3.MaxLength = 25
        Me.txtApellido3.Name = "txtApellido3"
        Me.txtApellido3.Size = New System.Drawing.Size(152, 20)
        Me.txtApellido3.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(253, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 157
        Me.Label7.Text = "Apellido 3:"
        '
        'txtApellido2
        '
        Me.txtApellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido2.Location = New System.Drawing.Point(95, 50)
        Me.txtApellido2.MaxLength = 25
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(152, 20)
        Me.txtApellido2.TabIndex = 2
        '
        'txtApellido1
        '
        Me.txtApellido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido1.Location = New System.Drawing.Point(342, 24)
        Me.txtApellido1.MaxLength = 25
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(152, 20)
        Me.txtApellido1.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 156
        Me.Label6.Text = "Apellido 2:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(253, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 155
        Me.Label5.Text = "Apellido 1:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "Especifique:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOtro
        '
        Me.txtOtro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtro.Location = New System.Drawing.Point(95, 156)
        Me.txtOtro.Name = "txtOtro"
        Me.txtOtro.Size = New System.Drawing.Size(399, 20)
        Me.txtOtro.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Parentesco:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCel
        '
        Me.txtCel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCel.Location = New System.Drawing.Point(342, 76)
        Me.txtCel.MaxLength = 100
        Me.txtCel.Name = "txtCel"
        Me.txtCel.Size = New System.Drawing.Size(152, 20)
        Me.txtCel.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(253, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "Teléfono Celular:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTelCasa
        '
        Me.txtTelCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelCasa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelCasa.Location = New System.Drawing.Point(95, 76)
        Me.txtTelCasa.MaxLength = 100
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.Size = New System.Drawing.Size(152, 20)
        Me.txtTelCasa.TabIndex = 4
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Black
        Me.Label65.Location = New System.Drawing.Point(6, 82)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(88, 16)
        Me.Label65.TabIndex = 132
        Me.Label65.Text = "Teléfono Casa:"
        Me.Label65.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(95, 24)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(152, 20)
        Me.txtNombre.TabIndex = 0
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.Black
        Me.Label67.Location = New System.Drawing.Point(6, 28)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(83, 16)
        Me.Label67.TabIndex = 128
        Me.Label67.Text = "Nombres:"
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(95, 102)
        Me.txtDireccion.MaxLength = 255
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(399, 20)
        Me.txtDireccion.TabIndex = 5
        '
        'Label68
        '
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.Black
        Me.Label68.Location = New System.Drawing.Point(6, 106)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(56, 16)
        Me.Label68.TabIndex = 130
        Me.Label68.Text = "Dirección:"
        Me.Label68.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(452, 408)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 219
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCrRefFam
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(547, 462)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(547, 462)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(547, 462)
        Me.Name = "frmMsCrRefFam"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Referencias Familiares"
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMsCrRefFam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection, oAsoc As New wrAsociados.wsLibAsoc


            Dim dsTemp As New DataSet, drTemp As DataRow, x As Integer
            dsTemp = oAsoc.ConsultarParentescos("*", "", "CodParentesco", sUsuario, sPassword, sSucursal)
            For Each drTemp In dsTemp.Tables(0).Rows
                cbParentesco.Items.Add(CStr(drTemp("CodParentesco")).Trim & " - " & CStr(drTemp("Descripcion")).Trim)
                cbPar.Items.Add(CStr(drTemp("Descripcion")).Trim)
            Next

            Me.cbPar.SelectedIndex = 0
            Me.cbParentesco.SelectedIndex = 0

            If Me.pAccion = "Modificar" Then

                ds = oCred.ConsultarRefFamiliar("*", "Correlativo='" & pCorrelativo & "'", "Correlativo", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtNombre.Text = IIf(IsDBNull(Filas.Item(0)("Nombre")), "", Filas.Item(0)("Nombre"))
                    Me.txtDireccion.Text = IIf(IsDBNull(Filas.Item(0)("Direccion")), "", Filas.Item(0)("Direccion"))
                    Me.txtTelCasa.Text = IIf(IsDBNull(Filas.Item(0)("TelCasa")), "", Filas.Item(0)("TelCasa"))
                    Me.txtTrabajo.Text = IIf(IsDBNull(Filas.Item(0)("LugarTrabajo")), "", Filas.Item(0)("LugarTrabajo"))
                    Me.txtDirTrab.Text = IIf(IsDBNull(Filas.Item(0)("DireccionTrabajo")), "", Filas.Item(0)("DireccionTrabajo"))
                    Me.txtCargo.Text = IIf(IsDBNull(Filas.Item(0)("Cargo")), "", Filas.Item(0)("Cargo"))
                    Me.txtTelTrab.Text = IIf(IsDBNull(Filas.Item(0)("TelOficina")), "", Filas.Item(0)("TelOficina"))
                    For x = 0 To cbParentesco.Items.Count - 1
                        cbParentesco.SelectedIndex = x
                        If Mid(cbParentesco.Text, 1, 5).Trim = Trim(IIf(IsDBNull(Filas.Item(0)("CodParentesco")), "", Filas.Item(0)("CodParentesco"))) Then
                            cbParentesco.SelectedIndex = x
                            cbPar.SelectedIndex = x
                            Exit For
                        End If
                    Next
                    Me.txtOtro.Text = IIf(IsDBNull(Filas.Item(0)("Otro")), "", Filas.Item(0)("Otro"))
                    Me.txtCel.Text = IIf(IsDBNull(Filas.Item(0)("Celular")), "", Filas.Item(0)("Celular"))
                    Me.txtApellido1.Text = IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1"))
                    Me.txtApellido2.Text = IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                    Me.txtApellido3.Text = IIf(IsDBNull(Filas.Item(0)("Apellido3")), "", Filas.Item(0)("Apellido3"))
                End If

            End If
            txtNombre.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String

            Select Case oCred.AutorizarDatos(Trim(Me.txtNombre.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El Nombre de la Referencia no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCorrelativo = oCred.ObtenerCorrelativoRefFamiliar("Correlativo", sUsuario, sPassword, sSucursal)
                pCampos = "Correlativo,NumSolicitud,Nombre,Direccion,TelCasa,LugarTrabajo,DireccionTrabajo,Cargo,TelOficina,CodEnlace,CodParentesco,Otro,Celular,Apellido1,Apellido2,Apellido3"
                pValores = "" & pCorrelativo & "," & pNoSolic & ",'" & Trim(Me.txtNombre.Text) & "','" & Trim(Me.txtDireccion.Text) & "','" & Trim(Me.txtTelCasa.Text) & "','" & Trim(Me.txtTrabajo.Text) & "','" & Trim(Me.txtDirTrab.Text) & "','" & Trim(Me.txtCargo.Text) & "','" & Trim(Me.txtTelTrab.Text) & "'," & pCodEnlace & ",'" & Me.cbParentesco.Text.Substring(0, 5).Trim & "','" & Me.txtOtro.Text.Trim & "','" & Me.txtCel.Text.Trim & "','" & Me.txtApellido1.Text.Trim & "','" & Me.txtApellido2.Text.Trim & "','" & Me.txtApellido3.Text.Trim & "'"
                If oCred.InsertarRefFamiliar(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("La Referencia Familiar NO ha sido agregada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Nombre='" & Trim(Me.txtNombre.Text) & "',Direccion='" & Trim(Me.txtDireccion.Text) & "',TelCasa='" & Trim(Me.txtTelCasa.Text) & "',LugarTrabajo='" & Trim(Me.txtTrabajo.Text) & "',DireccionTrabajo='" & Trim(Me.txtDirTrab.Text) & "',Cargo='" & Trim(Me.txtCargo.Text) & "',TelOficina='" & Trim(Me.txtTelTrab.Text) & "',CodParentesco='" & Me.cbParentesco.Text.Substring(0, 5).Trim & "',Otro='" & Me.txtOtro.Text.Trim & "',Celular='" & Me.txtCel.Text.Trim & "',Apellido1='" & Me.txtApellido1.Text.Trim & "',Apellido2='" & Me.txtApellido2.Text.Trim & "',Apellido3='" & Me.txtApellido3.Text.Trim & "'"
                If oCred.ModificarRefFamiliar(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("La Referencia no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Sub txtTelTrab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTelTrab.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnGuardar1_Click(sender, e)
        End If
    End Sub

    Private Sub cbPar_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbPar.SelectedIndexChanged
        Me.cbParentesco.SelectedIndex = Me.cbPar.SelectedIndex
    End Sub

End Class