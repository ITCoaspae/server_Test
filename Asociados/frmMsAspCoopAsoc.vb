Public Class frmMsAspCoopAsoc
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Public pDui As String

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents txtProposito As System.Windows.Forms.TextBox
    Friend WithEvents rbNO As System.Windows.Forms.RadioButton
    Friend WithEvents rbSI As System.Windows.Forms.RadioButton
    Friend WithEvents txtCooperativa As System.Windows.Forms.TextBox
    Friend WithEvents txtCodCooperativa As System.Windows.Forms.TextBox
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodAntiguo As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1nMonto As C1.Win.C1Input.C1NumericEdit
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.c1nMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.cbFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProposito = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rbNO = New System.Windows.Forms.RadioButton()
        Me.rbSI = New System.Windows.Forms.RadioButton()
        Me.txtCooperativa = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodCooperativa = New System.Windows.Forms.TextBox()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtCodAntiguo = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1nMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDatos.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.c1nMonto)
        Me.GroupBox1.Controls.Add(Me.cbFormaPago)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtProposito)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rbNO)
        Me.GroupBox1.Controls.Add(Me.rbSI)
        Me.GroupBox1.Controls.Add(Me.txtCooperativa)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtCodCooperativa)
        Me.GroupBox1.Controls.Add(Me.txtCargo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Maroon
        Me.GroupBox1.Location = New System.Drawing.Point(23, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 253)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'c1nMonto
        '
        Me.c1nMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMonto.CustomFormat = "###,###,##0.00"
        Me.c1nMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMonto.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nMonto.Location = New System.Drawing.Point(180, 177)
        Me.c1nMonto.Name = "c1nMonto"
        Me.c1nMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMonto.ShowDropDownButton = False
        Me.c1nMonto.ShowUpDownButtons = False
        Me.c1nMonto.Size = New System.Drawing.Size(104, 21)
        Me.c1nMonto.TabIndex = 5
        Me.c1nMonto.Tag = Nothing
        Me.c1nMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'cbFormaPago
        '
        Me.cbFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFormaPago.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbFormaPago.Items.AddRange(New Object() {""})
        Me.cbFormaPago.Location = New System.Drawing.Point(180, 213)
        Me.cbFormaPago.Name = "cbFormaPago"
        Me.cbFormaPago.Size = New System.Drawing.Size(168, 22)
        Me.cbFormaPago.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(141, 34)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Forma de Pago " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para las aportaciones:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 29)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Monto de ahorro mensual " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que tiene planeado efectuar:"
        '
        'txtProposito
        '
        Me.txtProposito.Location = New System.Drawing.Point(180, 122)
        Me.txtProposito.MaxLength = 100
        Me.txtProposito.Multiline = True
        Me.txtProposito.Name = "txtProposito"
        Me.txtProposito.Size = New System.Drawing.Size(388, 40)
        Me.txtProposito.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 33)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Propósito para " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "afiliarse a la Cooperativa:"
        '
        'rbNO
        '
        Me.rbNO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNO.ForeColor = System.Drawing.Color.Black
        Me.rbNO.Location = New System.Drawing.Point(250, 16)
        Me.rbNO.Name = "rbNO"
        Me.rbNO.Size = New System.Drawing.Size(72, 16)
        Me.rbNO.TabIndex = 1
        Me.rbNO.Text = "&No"
        '
        'rbSI
        '
        Me.rbSI.Checked = True
        Me.rbSI.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSI.ForeColor = System.Drawing.Color.Black
        Me.rbSI.Location = New System.Drawing.Point(180, 16)
        Me.rbSI.Name = "rbSI"
        Me.rbSI.Size = New System.Drawing.Size(64, 16)
        Me.rbSI.TabIndex = 0
        Me.rbSI.TabStop = True
        Me.rbSI.Text = "&Si"
        '
        'txtCooperativa
        '
        Me.txtCooperativa.Location = New System.Drawing.Point(250, 45)
        Me.txtCooperativa.MaxLength = 100
        Me.txtCooperativa.Name = "txtCooperativa"
        Me.txtCooperativa.ReadOnly = True
        Me.txtCooperativa.Size = New System.Drawing.Size(318, 20)
        Me.txtCooperativa.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 16)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Cooperativa a la que pertenece:"
        '
        'txtCodCooperativa
        '
        Me.txtCodCooperativa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodCooperativa.Location = New System.Drawing.Point(180, 45)
        Me.txtCodCooperativa.MaxLength = 5
        Me.txtCodCooperativa.Name = "txtCodCooperativa"
        Me.txtCodCooperativa.Size = New System.Drawing.Size(64, 20)
        Me.txtCodCooperativa.TabIndex = 2
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(180, 88)
        Me.txtCargo.MaxLength = 50
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(388, 20)
        Me.txtCargo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 16)
        Me.Label4.TabIndex = 89
        Me.Label4.Text = "Pertenece a otra Cooperativa:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 48)
        Me.Label5.TabIndex = 94
        Me.Label5.Text = "Cargo directivo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que desempeña " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o ha desempeñado:"
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.White
        Me.gbDatos.Controls.Add(Me.txtDui)
        Me.gbDatos.Controls.Add(Me.txtCodAntiguo)
        Me.gbDatos.Controls.Add(Me.Label48)
        Me.gbDatos.Controls.Add(Me.Label31)
        Me.gbDatos.Controls.Add(Me.txtNoSocio)
        Me.gbDatos.Controls.Add(Me.Label2)
        Me.gbDatos.Controls.Add(Me.txtNombre)
        Me.gbDatos.Controls.Add(Me.Label21)
        Me.gbDatos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos.ForeColor = System.Drawing.Color.Black
        Me.gbDatos.Location = New System.Drawing.Point(23, 63)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(580, 88)
        Me.gbDatos.TabIndex = 0
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "Datos del Asociado"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(44, 24)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(136, 20)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'txtCodAntiguo
        '
        Me.txtCodAntiguo.Location = New System.Drawing.Point(464, 24)
        Me.txtCodAntiguo.MaxLength = 10
        Me.txtCodAntiguo.Name = "txtCodAntiguo"
        Me.txtCodAntiguo.Size = New System.Drawing.Size(104, 20)
        Me.txtCodAntiguo.TabIndex = 2
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(376, 24)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(88, 16)
        Me.Label48.TabIndex = 114
        Me.Label48.Text = "Código Antiguo:"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(6, 24)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(32, 16)
        Me.Label31.TabIndex = 94
        Me.Label31.Text = "Dui:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.Location = New System.Drawing.Point(288, 24)
        Me.txtNoSocio.MaxLength = 8
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(72, 20)
        Me.txtNoSocio.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(208, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "No. Asociado:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(92, 56)
        Me.txtNombre.MaxLength = 150
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(476, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(6, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(80, 16)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Asociado:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(528, 416)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 125
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsAspCoopAsoc
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(621, 465)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.gbDatos)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAspCoopAsoc"
        Me.ShowInTaskbar = False
        Me.Text = "Aspectos Cooperativos del Asociado"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1nMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub frmMsAspCoopAsoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, objRow As Data.DataRow
        Try
            gbDatos.Focus()

            ds = oAsoc.ConsultarFormaPago("*", "", "IdFormaPago", sUsuario, sPassword, sSucursal)

            cbFormaPago.Items.Clear()
            For Each objRow In ds.Tables(0).Rows
                cbFormaPago.Items.Add(CStr(objRow("IdFormaPago")) & " - " & CStr(objRow("FormaPago")))
            Next
            'cbFormaPago.SelectedIndex = 0

            If Me.btnGuardar1.Text = "&Modificar" Then

                Dim Filas As Data.DataRowCollection
                Dim vLen As Long, x As Integer

                ds = oAsoc.ConsultarAspectosCooperativos("*", "Dui='" & pDui & "'", "Dui", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtDui.Text = pDui
                    txtCargo.Text = CStr(Filas.Item(0)("CargoDirectivo"))
                    txtCodCooperativa.Text = CStr(Filas.Item(0)("CodCooperativa"))
                    c1nMonto.Value = CDbl(Filas.Item(0)("Monto"))
                    txtProposito.Text = CStr(Filas.Item(0)("Proposito"))

                    vLen = Len(Trim(CStr(Filas.Item(0)("IdFormaPago"))))
                    For x = 0 To cbFormaPago.Items.Count - 1
                        If Trim(Microsoft.VisualBasic.Left(cbFormaPago.Items.Item(x), vLen)) = Trim(CStr(Filas.Item(0)("IdFormaPago"))) Then
                            cbFormaPago.SelectedIndex = x
                            Exit For
                        End If
                    Next

                    If CStr(Filas.Item(0)("AsocOtraCoop")) = "S" Then
                        rbSI.Checked = True
                    ElseIf CStr(Filas.Item(0)("AsocOtraCoop")) = "N" Then
                        rbNO.Checked = True
                    End If
                End If
                ds = oAsoc.ConsultarAsociado("NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre", "Dui='" & Trim(pDui) & "'", "Dui", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNoSocio.Text = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))
                    txtCodAntiguo.Text = IIf(IsDBNull(Filas.Item(0)("CodAntiguo")), "", Filas.Item(0)("CodAntiguo"))
                    txtNoSocio.Enabled = False
                    Me.txtDui.Enabled = False
                    txtCodAntiguo.Enabled = False
                    txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                End If
                ds = oAsoc.ConsultarCooperativas("*", "CodCooperativa='" & Trim(txtCodCooperativa.Text) & "'", "", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtCooperativa.Text = CStr(Filas.Item(0)("Descripcion"))
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub txtCodCooperativa_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodCooperativa.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cooperativas"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarCooperativas("*", "", "CodCooperativa", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodCooperativa.Text = ofrm.Resultado.Trim
            Me.txtCooperativa.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Cooperativas - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtMonto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsNumber(e.KeyChar) = True Or e.KeyChar.Equals("."c) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub rbNO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNO.CheckedChanged
        If Me.rbNO.Checked = True Then
            Me.txtCodCooperativa.Text = "01"
            Me.txtCodCooperativa.Enabled = False
            Me.txtCargo.Enabled = False
        Else
            Me.txtCodCooperativa.Enabled = True
            Me.txtCargo.Enabled = True
        End If
    End Sub

    Private Sub txtCodAntiguo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodAntiguo.DoubleClick

        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Asociados"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodAntiguo.Text = ofrm.Resultado3.Trim
            txtNoSocio.Text = ofrm.Resultado2.Trim
            txtDui.Value = ofrm.Resultado.Trim
            txtNombre.Text = ofrm.Resultado4.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtNoSocio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoSocio.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Asociados"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtNoSocio.Text = ofrm.Resultado2.Trim
            txtDui.Value = ofrm.Resultado.Trim
            txtNombre.Text = ofrm.Resultado4.Trim
            txtCodAntiguo.Text = ofrm.Resultado3
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Asociados"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtNoSocio.Text = ofrm.Resultado2.Trim
            txtDui.Value = ofrm.Resultado.Trim
            txtNombre.Text = ofrm.Resultado4.Trim
            txtCodAntiguo.Text = ofrm.Resultado3
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub txtNoSocio_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNoSocio.Validating
        Try
            If txtNoSocio.Text.Trim = "" Then
            Else
                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "NoSocio='" & txtNoSocio.Text.Trim & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio"))
                    txtDui.Value = CStr(Filas.Item(0)("DUI"))
                    txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                    txtCodAntiguo.Text = IIf(IsDBNull(Filas.Item(0)("CodAntiguo")), "", Filas.Item(0)("CodAntiguo"))
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCodAntiguo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodAntiguo.Validating
        Try
            If txtCodAntiguo.Text.Trim = "" Then
            Else
                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "CodAntiguo='" & txtCodAntiguo.Text.Trim & "'", "DUI,CodAntiguo", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio"))
                    txtCodAntiguo.Text = IIf(IsDBNull(Filas.Item(0)("CodAntiguo")), "", Filas.Item(0)("CodAntiguo"))
                    txtDui.Value = CStr(Filas.Item(0)("DUI"))
                    txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text.Trim = "" Then Exit Sub
        Try
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "Dui='" & txtDui.Text.Trim & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio")).Trim
                txtDui.Value = CStr(Filas.Item(0)("DUI")).Trim
                txtNombre.Text = CStr(Filas.Item(0)("Nombre")).Trim
                txtCodAntiguo.Text = IIf(IsDBNull(Filas.Item(0)("CodAntiguo")), "", Filas.Item(0)("CodAntiguo"))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click

        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String, pAsoc As String, IdFormaPago As String, pos As Long
        Try
            If Me.rbSI.Checked = True Then
                pAsoc = "S"
            ElseIf Me.rbNO.Checked = True Then
                pAsoc = "N"
            End If

            pos = InStr(Trim(cbFormaPago.Text), "-", CompareMethod.Binary)
            If Trim(cbFormaPago.Text) = "" Then Exit Sub
            IdFormaPago = Microsoft.VisualBasic.Left(Trim(cbFormaPago.Text), pos - 2)

            If Me.btnGuardar1.Text = "&Guardar" Then

                Select Case oAsoc.AutorizaDatos(Trim(txtDui.Text), "x", "x", "x", "x")
                    Case 1
                        MsgBox("El campo Dui del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                        Exit Sub
                End Select

                pCampos = "DUI,AsocOtraCoop,CodCooperativa,CargoDirectivo,Proposito,Monto,IdFormaPago"
                pValores = "'" & Trim(txtDui.Text) & "','" & pAsoc & "','" & Trim(txtCodCooperativa.Text) & "','" & Trim(txtCargo.Text) & "','" & Trim(txtProposito.Text) & "'," & Val(Me.c1nMonto.Value) & ",'" & IdFormaPago & "'"
                If oAsoc.InsertarAspectosCooperativos(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Registro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "AsocOtraCoop='" & pAsoc & "',CodCooperativa='" & Trim(txtCodCooperativa.Text) & "',CargoDirectivo='" & Trim(txtCargo.Text) & "',Proposito='" & Trim(txtProposito.Text) & "',Monto=" & Val(c1nMonto.Value) & ",IdFormaPago='" & IdFormaPago & "'"
                If oAsoc.ModificarAspectosCooperativos("Dui='" & pDui & "'", pCampos, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("El Registro ha sido modificado.", MsgBoxStyle.Information)
                    Me.Dispose()
                Else
                    MsgBox("El Registro no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class