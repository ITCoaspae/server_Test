Public Class frmMsCBTipoCobranza
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pAccion As String
    Friend WithEvents Label9 As Label
    Friend WithEvents txtTipo As TextBox
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
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nuDiaInicio As System.Windows.Forms.NumericUpDown
    Friend WithEvents nuDiaFin As System.Windows.Forms.NumericUpDown
    Friend WithEvents nuDiasCompromiso As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.nuDiasCompromiso = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nuDiaFin = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nuDiaInicio = New System.Windows.Forms.NumericUpDown()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        CType(Me.nuDiasCompromiso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuDiaFin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuDiaInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nuDiasCompromiso
        '
        Me.nuDiasCompromiso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nuDiasCompromiso.Location = New System.Drawing.Point(280, 157)
        Me.nuDiasCompromiso.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nuDiasCompromiso.Name = "nuDiasCompromiso"
        Me.nuDiasCompromiso.Size = New System.Drawing.Size(40, 20)
        Me.nuDiasCompromiso.TabIndex = 3
        Me.nuDiasCompromiso.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Teal
        Me.Label8.Location = New System.Drawing.Point(23, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(251, 16)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Compromiso de pago no debe exceder de "
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Teal
        Me.Label7.Location = New System.Drawing.Point(326, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 16)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "día(s)."
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(298, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "días."
        '
        'nuDiaFin
        '
        Me.nuDiaFin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nuDiaFin.Location = New System.Drawing.Point(221, 127)
        Me.nuDiaFin.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nuDiaFin.Name = "nuDiaFin"
        Me.nuDiaFin.Size = New System.Drawing.Size(71, 20)
        Me.nuDiaFin.TabIndex = 2
        Me.nuDiaFin.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(191, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 16)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "a:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(23, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Rango de morosidad:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "De:"
        '
        'nuDiaInicio
        '
        Me.nuDiaInicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nuDiaInicio.Location = New System.Drawing.Point(114, 127)
        Me.nuDiaInicio.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nuDiaInicio.Name = "nuDiaInicio"
        Me.nuDiaInicio.Size = New System.Drawing.Size(71, 20)
        Me.nuDiaInicio.TabIndex = 1
        Me.nuDiaInicio.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(114, 83)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(352, 20)
        Me.txtDescripcion.TabIndex = 0
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(114, 57)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(48, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Código:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btnGuardar1.Location = New System.Drawing.Point(391, 182)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1021
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(168, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 1022
        Me.Label9.Text = "Tipo:"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(205, 56)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(100, 20)
        Me.txtTipo.TabIndex = 1023
        '
        'frmMsCBTipoCobranza
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(491, 248)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.nuDiasCompromiso)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.nuDiaFin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.nuDiaInicio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.MaximumSize = New System.Drawing.Size(491, 248)
        Me.MinimumSize = New System.Drawing.Size(491, 248)
        Me.Name = "frmMsCBTipoCobranza"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Tipos de Cobranza"
        CType(Me.nuDiasCompromiso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuDiaFin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuDiaInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String

            If Me.txtCodigo.Text.Trim = "" Then
                MsgBox("La descripción del tipo de Cobranza no puede quedar vacía. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Cobranzas")
                Exit Sub
            End If

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "DiaInicio,DiaFin,Descripcion,DiasCompromiso,tipo"
                pValores = "" & nuDiaInicio.Value & "," & nuDiaFin.Value & ",'" & Trim(txtDescripcion.Text) & "'," & nuDiasCompromiso.Value & ",'" & txtTipo.Text.Trim & "'"
                If oCred.InsertarTipoCobranza(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El tipo de Cobranza NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Cobranzas")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "DiaInicio=" & nuDiaInicio.Value & ",DiaFin=" & nuDiaFin.Value & ",Descripcion='" & Trim(txtDescripcion.Text) & "',DiasCompromiso=" & nuDiasCompromiso.Value & ", tipo='" & txtTipo.Text.Trim & "'"
                If oCred.ModificarTipoCobranza(Trim(pCodigo), pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El tipo de Cobranza no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Cobranzas")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

#End Region



    Private Sub frmMsCBTipoCobranza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection

        If Me.pAccion = "Modificar" Then

            ds = oCred.ConsultarTipoCobranza("*", "CodTipoCobranza='" & pCodigo & "'", "CodTipoCobranza", sUsuario, sPassword,sSucursal)

            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                txtCodigo.Text = pCodigo
                txtCodigo.Enabled = False
                txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                nuDiaInicio.Value = IIf(IsDBNull(Filas.Item(0)("DiaInicio")), 0, Filas.Item(0)("DiaInicio"))
                nuDiaFin.Value = IIf(IsDBNull(Filas.Item(0)("DiaFin")), 0, Filas.Item(0)("DiaFin"))
                txtTipo.Text = IIf(IsDBNull(Filas.Item(0)("tipo")), 0, Filas.Item(0)("tipo"))
                nuDiasCompromiso.Value = IIf(IsDBNull(Filas.Item(0)("DiasCompromiso")), 0, Filas.Item(0)("DiasCompromiso"))
            End If

        Else
            Me.txtCodigo.Text = oCred.ObtenerCorrelativoTipoCobranza("CodTipoCobranza", sUsuario, sPassword,sSucursal)
        End If
        txtCodigo.Focus()
    End Sub

End Class
