Public Class frmMsCrGarantias
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pNoSolic As Long, pCodEnlace As Long, pAccion As String, pDui As String
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents chkPrincipal As System.Windows.Forms.CheckBox

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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNoValuo As System.Windows.Forms.TextBox
    Friend WithEvents txtNoFactura As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoGarantia As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoGarantia As System.Windows.Forms.TextBox
    Friend WithEvents txtEvaluadora As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCodGarantia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkPrincipal = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodGarantia = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEvaluadora = New System.Windows.Forms.TextBox()
        Me.txtNoValuo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNoFactura = New System.Windows.Forms.TextBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.txtTipoGarantia = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodTipoGarantia = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'chkPrincipal
        '
        Me.chkPrincipal.AutoSize = True
        Me.chkPrincipal.Checked = True
        Me.chkPrincipal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrincipal.Location = New System.Drawing.Point(218, 61)
        Me.chkPrincipal.Name = "chkPrincipal"
        Me.chkPrincipal.Size = New System.Drawing.Size(66, 17)
        Me.chkPrincipal.TabIndex = 97
        Me.chkPrincipal.Text = "Principal"
        Me.chkPrincipal.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 45)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Nombre de la Institución / " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Valuadora:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodGarantia
        '
        Me.txtCodGarantia.BackColor = System.Drawing.Color.White
        Me.txtCodGarantia.Location = New System.Drawing.Point(132, 56)
        Me.txtCodGarantia.MaxLength = 10
        Me.txtCodGarantia.Name = "txtCodGarantia"
        Me.txtCodGarantia.Size = New System.Drawing.Size(80, 20)
        Me.txtCodGarantia.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(23, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Código de Garantía:"
        '
        'txtEvaluadora
        '
        Me.txtEvaluadora.BackColor = System.Drawing.Color.White
        Me.txtEvaluadora.ForeColor = System.Drawing.Color.Black
        Me.txtEvaluadora.Location = New System.Drawing.Point(132, 195)
        Me.txtEvaluadora.MaxLength = 255
        Me.txtEvaluadora.Name = "txtEvaluadora"
        Me.txtEvaluadora.ReadOnly = True
        Me.txtEvaluadora.Size = New System.Drawing.Size(428, 20)
        Me.txtEvaluadora.TabIndex = 94
        '
        'txtNoValuo
        '
        Me.txtNoValuo.BackColor = System.Drawing.Color.White
        Me.txtNoValuo.Enabled = False
        Me.txtNoValuo.Location = New System.Drawing.Point(386, 165)
        Me.txtNoValuo.Name = "txtNoValuo"
        Me.txtNoValuo.Size = New System.Drawing.Size(174, 20)
        Me.txtNoValuo.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(307, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 16)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Número valúo:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNoFactura
        '
        Me.txtNoFactura.BackColor = System.Drawing.Color.White
        Me.txtNoFactura.Location = New System.Drawing.Point(132, 165)
        Me.txtNoFactura.MaxLength = 20
        Me.txtNoFactura.Name = "txtNoFactura"
        Me.txtNoFactura.Size = New System.Drawing.Size(174, 20)
        Me.txtNoFactura.TabIndex = 4
        '
        'lbl
        '
        Me.lbl.Location = New System.Drawing.Point(23, 166)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(104, 16)
        Me.lbl.TabIndex = 91
        Me.lbl.Text = "Número de factura:"
        Me.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTipoGarantia
        '
        Me.txtTipoGarantia.BackColor = System.Drawing.Color.White
        Me.txtTipoGarantia.ForeColor = System.Drawing.Color.Black
        Me.txtTipoGarantia.Location = New System.Drawing.Point(218, 84)
        Me.txtTipoGarantia.MaxLength = 100
        Me.txtTipoGarantia.Name = "txtTipoGarantia"
        Me.txtTipoGarantia.ReadOnly = True
        Me.txtTipoGarantia.Size = New System.Drawing.Size(342, 20)
        Me.txtTipoGarantia.TabIndex = 80
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.Location = New System.Drawing.Point(132, 110)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(428, 49)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodTipoGarantia
        '
        Me.txtCodTipoGarantia.BackColor = System.Drawing.Color.White
        Me.txtCodTipoGarantia.Location = New System.Drawing.Point(132, 82)
        Me.txtCodTipoGarantia.MaxLength = 10
        Me.txtCodTipoGarantia.Name = "txtCodTipoGarantia"
        Me.txtCodTipoGarantia.Size = New System.Drawing.Size(80, 20)
        Me.txtCodTipoGarantia.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(23, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Tipo de Garantía:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(485, 240)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 207
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCrGarantias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(584, 295)
        Me.Controls.Add(Me.txtEvaluadora)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.chkPrincipal)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtNoValuo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCodGarantia)
        Me.Controls.Add(Me.txtNoFactura)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodTipoGarantia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTipoGarantia)
        Me.MaximumSize = New System.Drawing.Size(584, 295)
        Me.MinimumSize = New System.Drawing.Size(584, 295)
        Me.Name = "frmMsCrGarantias"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Garantías"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmMsCrGarantias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection

            If Me.pAccion = "Modificar" Then

                ds = oCred.ConsultarGarantias("*", "CodGarantia='" & pCodigo & "'", "CodGarantia", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.chkPrincipal.Checked = IIf(IsDBNull(Filas.Item(0)("Principal")), False, Filas.Item(0)("Principal"))
                    Me.txtCodGarantia.Text = pCodigo
                    Me.txtCodGarantia.Enabled = True
                    Me.txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    Me.txtCodTipoGarantia.Text = IIf(IsDBNull(Filas.Item(0)("CodTipoGarantia")), "", Filas.Item(0)("CodTipoGarantia"))
                    Me.txtNoValuo.Text = IIf(IsDBNull(Filas.Item(0)("CorrelValuo")), 0, Filas.Item(0)("CorrelValuo"))
                    If Me.txtCodTipoGarantia.Text.Trim = "00004" Then
                        Me.txtNoValuo.Enabled = True
                        Me.txtNoFactura.Text = IIf(IsDBNull(Filas.Item(0)("NumFactura")), 0, Filas.Item(0)("NumFactura"))
                    ElseIf Me.txtCodTipoGarantia.Text.Trim = "00002" Or Me.txtCodTipoGarantia.Text.Trim = "00001" Or Me.txtCodTipoGarantia.Text.Trim = "00007" Then
                        Me.lbl.Text = "No. de Cuenta"
                        Me.txtNoFactura.Text = IIf(IsDBNull(Filas.Item(0)("NoCuenta")), 0, Filas.Item(0)("NoCuenta"))
                    Else
                        Me.txtNoFactura.Text = IIf(IsDBNull(Filas.Item(0)("NumFactura")), 0, Filas.Item(0)("NumFactura"))
                    End If
                End If

                If Trim(Me.txtCodTipoGarantia.Text) <> "" Then
                    ds = oCred.ConsultarTipGarant("*", "CodTipoGarantias='" & Trim(Me.txtCodTipoGarantia.Text) & "'", "CodTipoGarantias", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        Me.txtTipoGarantia.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    End If
                End If

                If Trim(Me.txtNoValuo.Text) <> "" Then
                    ds = oCred.ConsultarValuos("*", "CorrelValuo='" & Trim(Me.txtNoValuo.Text) & "'", "CorrelValuo", False, sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        Me.txtEvaluadora.Text = IIf(IsDBNull(Filas.Item(0)("EmpresaValuadora")), "", Filas.Item(0)("EmpresaValuadora"))
                    End If
                End If
            Else
                Me.txtCodGarantia.Text = oCred.ObtenerCorrelativoGarantias("CodGarantia", sUsuario, sPassword, sSucursal)
                Me.txtCodGarantia.ReadOnly = True
            End If
            Me.txtDescripcion.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCodTipoGarantia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodTipoGarantia.KeyPress
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                oPerif = New wrCredito.wsLibCred
                ds = oPerif.ConsultarTipGarant("*", "CodTipoGarantias='" & Trim(Me.txtCodTipoGarantia.Text) & "'", "CodTipoGarantias", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                        Me.txtTipoGarantia.Text = CStr(Filas.Item(0)("Descripcion"))
                        If Me.txtCodTipoGarantia.Text.Trim = "00004" Then
                            Me.txtNoValuo.Enabled = True
                        ElseIf Me.txtCodTipoGarantia.Text.Trim = "00002" Or Me.txtCodTipoGarantia.Text.Trim = "00001" Or Me.txtCodTipoGarantia.Text.Trim = "00007" Then
                            Me.lbl.Text = "No. de Cuenta"
                        End If
                    End If
                Else
                    txtCodTipoGarantia_DoubleClick(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodTipoGarantia_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoGarantia.DoubleClick

        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Tipos de Garantía"
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarTipGarant("*", "", "CodTipoGarantias", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodTipoGarantia.Text = ofrm.Resultado.Trim
            Me.txtTipoGarantia.Text = ofrm.Resultado2.Trim
            If Me.txtCodTipoGarantia.Text.Trim = "00004" Then
                Me.txtNoValuo.Enabled = True
            ElseIf Me.txtCodTipoGarantia.Text.Trim = "00002" Or Me.txtCodTipoGarantia.Text.Trim = "00001" Or Me.txtCodTipoGarantia.Text.Trim = "00007" Then
                Me.lbl.Text = "No. de Cuenta"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String, pNoCuenta As String, pNumFactura As String

            Select Case oCred.AutorizarDatos(Me.txtCodGarantia.Text, Me.txtCodTipoGarantia.Text, "x", "x", "x")
                Case 1
                    MsgBox("El Código de Garantía no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
                Case 2
                    MsgBox("El Código de Tipo de Garantía no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
            End Select

            If Me.txtCodTipoGarantia.Text.Trim = "00002" Or Me.txtCodTipoGarantia.Text.Trim = "00001" Or Me.txtCodTipoGarantia.Text.Trim = "00007" Then
                pNoCuenta = Me.txtNoFactura.Text.Trim
                pNumFactura = ""
            Else
                pNoCuenta = ""
                pNumFactura = Me.txtNoFactura.Text.Trim
            End If

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "Descripcion,NumSolicitud,CodTipoGarantia,CodEnlace,NumFactura,CorrelValuo,NoCuenta,Principal"
                pValores = "'" & Trim(Me.txtDescripcion.Text) & "'," & pNoSolic &
                ",'" & Trim(Me.txtCodTipoGarantia.Text) & "'," & pCodEnlace &
                ",'" & pNumFactura & "','" & Trim(Me.txtNoValuo.Text) &
                "','" & pNoCuenta & "','" & Me.chkPrincipal.Checked & "'"
                If oCred.InsertarGarantias(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos de la Garantía NO han sido agregados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Descripcion='" & Trim(Me.txtDescripcion.Text) &
                "',CodTipoGarantia='" & Trim(Me.txtCodTipoGarantia.Text) &
                "',NumFactura='" & pNumFactura &
                "',CorrelValuo='" & Trim(Me.txtNoValuo.Text) &
                "',NoCuenta='" & pNoCuenta &
                "',Principal = '" & Me.chkPrincipal.Checked & "'"
                If oCred.ModificarGarantias(pCodigo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los datos de la Garantía no han sido modificados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            End If

        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub txtNoValuo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoValuo.KeyPress
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                oPerif = New wrCredito.wsLibCred
                ds = oPerif.ConsultarValuos("*", "CorrelValuo='" & Trim(Me.txtNoValuo.Text) & "'", "CorrelValuo", False, sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("EmpresaValuadora") Is DBNull.Value) Then
                        Me.txtEvaluadora.Text = CStr(Filas.Item(0)("EmpresaValuadora"))
                    End If
                Else
                    txtNoValuo_DoubleClick(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNoValuo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoValuo.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Valúos"
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarValuos("CorrelValuo,EmpresaValuadora,FechaRequerido,DireccionPropiedad,FechaRealizado,MontoValuo,ValorComercial,ProfesionalAvala,NoRegistro", "", "CorrelValuo", False, sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtNoValuo.Text = ofrm.Resultado.Trim
            Me.txtEvaluadora.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtNoFactura_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoFactura.DoubleClick
        If Me.txtCodTipoGarantia.Text.Trim = "00002" Or Me.txtCodTipoGarantia.Text.Trim = "00001" Or Me.txtCodTipoGarantia.Text.Trim = "00007" Then
            Dim frm As New frmAGenerico
            Dim sTexto As String, vTipoAhorro As String
            Dim oAh As New wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro")
            Try
                If Me.txtCodTipoGarantia.Text.Trim = "00001" Then
                    frm.Text = "Buscar Cuentas de Aportación"
                    vTipoAhorro = " and Left(a.CodTipoAhorro,1)='1'"
                ElseIf Me.txtCodTipoGarantia.Text.Trim = "00002" Then
                    frm.Text = "Buscar Certificado DPF"
                    vTipoAhorro = " and Left(a.CodTipoAhorro,1)='2'"
                ElseIf Me.txtCodTipoGarantia.Text.Trim = "00007" Then
                    vTipoAhorro = " and ( Left(a.CodTipoAhorro,1)<>'2' and  Left(a.CodTipoAhorro,1)<>'1')"
                End If
                ds = oAh.ConsultarCuentaAhorroTipoAhorro("a.CodTipoAhorro,b.Descripcion as Tipo_Ahorro,a.NoCuenta,a.NoCuentaAnterior,a.FechaApertura,a.Saldo_CuentaAhorro as Saldo,a.SaldoDisponible_CuentaAhorro as Saldo_Disp,IdCertificadoDPF as No_Certificado", "Dui='" & pDui & "'" & vTipoAhorro, "a.NoCuenta", sUsuario, sPassword, sSucursal)
                frm.Datos = ds
                frm.C1fgrdResultado.Cols.Item(5).Format = "##0.00"
                frm.C1fgrdResultado.Cols.Item(6).Format = "##0.00"
                frm.ColSeleccion = 0
                frm.RefrescarGrid()
                frm.ShowDialog()
                If frm.Resultado.Trim = "" Then
                ElseIf frm.Resultado.Trim <> "" Then
                    sTexto = frm.Resultado3.Trim
                    Me.txtNoFactura.Text = sTexto
                End If
            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class