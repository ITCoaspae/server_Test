Public Class frmMsCrIngresos
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkVerificado As System.Windows.Forms.CheckBox
    Friend WithEvents chkConstancia As System.Windows.Forms.CheckBox
    Friend WithEvents chkEstFinanc As System.Windows.Forms.CheckBox
    Friend WithEvents chkDeclaraRenta As System.Windows.Forms.CheckBox
    Friend WithEvents chkDecIva As System.Windows.Forms.CheckBox
    Friend WithEvents chkVisitaCampo As System.Windows.Forms.CheckBox
    Friend WithEvents C1NEMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents chkCertificadoISSS As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkVerificado = New System.Windows.Forms.CheckBox()
        Me.chkCertificadoISSS = New System.Windows.Forms.CheckBox()
        Me.C1NEMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.chkVisitaCampo = New System.Windows.Forms.CheckBox()
        Me.chkDecIva = New System.Windows.Forms.CheckBox()
        Me.chkDeclaraRenta = New System.Windows.Forms.CheckBox()
        Me.chkEstFinanc = New System.Windows.Forms.CheckBox()
        Me.chkConstancia = New System.Windows.Forms.CheckBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkVerificado)
        Me.GroupBox1.Controls.Add(Me.chkCertificadoISSS)
        Me.GroupBox1.Controls.Add(Me.C1NEMonto)
        Me.GroupBox1.Controls.Add(Me.chkVisitaCampo)
        Me.GroupBox1.Controls.Add(Me.chkDecIva)
        Me.GroupBox1.Controls.Add(Me.chkDeclaraRenta)
        Me.GroupBox1.Controls.Add(Me.chkEstFinanc)
        Me.GroupBox1.Controls.Add(Me.chkConstancia)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chkVerificado
        '
        Me.chkVerificado.Location = New System.Drawing.Point(368, 72)
        Me.chkVerificado.Name = "chkVerificado"
        Me.chkVerificado.Size = New System.Drawing.Size(80, 24)
        Me.chkVerificado.TabIndex = 8
        Me.chkVerificado.Text = "&Verificado"
        '
        'chkCertificadoISSS
        '
        Me.chkCertificadoISSS.Location = New System.Drawing.Point(16, 64)
        Me.chkCertificadoISSS.Name = "chkCertificadoISSS"
        Me.chkCertificadoISSS.Size = New System.Drawing.Size(120, 24)
        Me.chkCertificadoISSS.TabIndex = 2
        Me.chkCertificadoISSS.Text = "Certific&ado ISSS"
        '
        'C1NEMonto
        '
        Me.C1NEMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMonto.CustomFormat = "###,###,##0.00"
        Me.C1NEMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMonto.Location = New System.Drawing.Point(360, 32)
        Me.C1NEMonto.Name = "C1NEMonto"
        Me.C1NEMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMonto.ShowDropDownButton = False
        Me.C1NEMonto.ShowUpDownButtons = False
        Me.C1NEMonto.Size = New System.Drawing.Size(80, 21)
        Me.C1NEMonto.TabIndex = 1
        Me.C1NEMonto.Tag = Nothing
        Me.C1NEMonto.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'chkVisitaCampo
        '
        Me.chkVisitaCampo.Location = New System.Drawing.Point(272, 88)
        Me.chkVisitaCampo.Name = "chkVisitaCampo"
        Me.chkVisitaCampo.Size = New System.Drawing.Size(104, 24)
        Me.chkVisitaCampo.TabIndex = 7
        Me.chkVisitaCampo.Text = "Vi&sita Campo"
        '
        'chkDecIva
        '
        Me.chkDecIva.Location = New System.Drawing.Point(152, 88)
        Me.chkDecIva.Name = "chkDecIva"
        Me.chkDecIva.Size = New System.Drawing.Size(120, 24)
        Me.chkDecIva.TabIndex = 6
        Me.chkDecIva.Text = "Delaraciones &Iva"
        '
        'chkDeclaraRenta
        '
        Me.chkDeclaraRenta.Location = New System.Drawing.Point(152, 64)
        Me.chkDeclaraRenta.Name = "chkDeclaraRenta"
        Me.chkDeclaraRenta.Size = New System.Drawing.Size(104, 24)
        Me.chkDeclaraRenta.TabIndex = 3
        Me.chkDeclaraRenta.Text = "&Declara Renta"
        '
        'chkEstFinanc
        '
        Me.chkEstFinanc.Location = New System.Drawing.Point(16, 88)
        Me.chkEstFinanc.Name = "chkEstFinanc"
        Me.chkEstFinanc.Size = New System.Drawing.Size(136, 24)
        Me.chkEstFinanc.TabIndex = 5
        Me.chkEstFinanc.Text = "&Estados Financieros"
        '
        'chkConstancia
        '
        Me.chkConstancia.Location = New System.Drawing.Point(272, 64)
        Me.chkConstancia.Name = "chkConstancia"
        Me.chkConstancia.Size = New System.Drawing.Size(80, 24)
        Me.chkConstancia.TabIndex = 4
        Me.chkConstancia.Text = "&Constancia"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Control
        Me.txtDescripcion.Location = New System.Drawing.Point(80, 32)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(264, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(16, 32)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(56, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(360, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Monto:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Tipo de Ingreso:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(414, 197)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 209
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCrIngresos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(518, 251)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(518, 251)
        Me.MinimumSize = New System.Drawing.Size(518, 251)
        Me.Name = "frmMsCrIngresos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Ingresos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region




    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String

            Select Case oCred.AutorizarDatos(Trim(Me.txtCodigo.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El Tipo de Ingreso no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Créditos")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCorrelativo = oCred.ObtenerCorrelativoIngresos("Correlativo", sUsuario, sPassword, sSucursal)
                pCampos = "Correlativo,NumSolicitud,CodTipoIngreso,Monto,CodEnlace,Verificado,xDeclarRenta,xConstancia,xEstadosFinancieros,xDeclaracionesIVA,xVisitaCampo,CertificadoISSS"
                pValores = "" & pCorrelativo & "," & pNoSolic & ",'" & Trim(Me.txtCodigo.Text) & "'," & Val(Me.C1NEMonto.Value) & "," & pCodEnlace & ",'" & IIf(Me.chkVerificado.Checked = True, "1", "0") & "','" & IIf(Me.chkDeclaraRenta.Checked = True, "1", "0") & "','" & IIf(Me.chkConstancia.Checked = True, "1", "0") & "','" & IIf(Me.chkEstFinanc.Checked = True, "1", "0") & "','" & IIf(Me.chkDecIva.Checked = True, "1", "0") & "','" & IIf(Me.chkVisitaCampo.Checked = True, "1", "0") & "','" & IIf(Me.chkCertificadoISSS.Checked = True, "1", "0") & "'"
                If oCred.InsertarIngresos(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Ingreso NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "CodTipoIngreso='" & Trim(Me.txtCodigo.Text) & "',Monto=" & Val(Me.C1NEMonto.Value) & ",Verificado='" & IIf(Me.chkVerificado.Checked = True, "1", "0") & "',xDeclarRenta='" & IIf(Me.chkDeclaraRenta.Checked = True, "1", "0") & "',xConstancia='" & IIf(Me.chkConstancia.Checked = True, "1", "0") & "',xEstadosFinancieros='" & IIf(Me.chkEstFinanc.Checked = True, "1", "0") & "',xDeclaracionesIVA='" & IIf(Me.chkDecIva.Checked = True, "1", "0") & "',xVisitaCampo='" & IIf(Me.chkVisitaCampo.Checked = True, "1", "0") & "',CertificadoISSS='" & IIf(Me.chkCertificadoISSS.Checked = True, "1", "0") & "'"
                If oCred.ModificarIngresos(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El Ingreso no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Créditos")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsCrIngresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection

            If Me.pAccion = "Modificar" Then

                ds = oCred.ConsultarIngresos("*", "Correlativo='" & pCorrelativo & "'", "Correlativo", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtCodigo.Text = IIf(IsDBNull(Filas.Item(0)("CodTipoIngreso")), "", Filas.Item(0)("CodTipoIngreso"))
                    Me.C1NEMonto.Value = IIf(IsDBNull(Filas.Item(0)("Monto")), 0, Filas.Item(0)("Monto"))
                    Me.chkVerificado.Checked = IIf(IsDBNull(Filas.Item(0)("Verificado")), False, IIf(Filas.Item(0)("Verificado") = "1", True, False))
                    Me.chkDeclaraRenta.Checked = IIf(IsDBNull(Filas.Item(0)("xDeclarRenta")), False, IIf(Filas.Item(0)("xDeclarRenta") = "1", True, False))
                    Me.chkConstancia.Checked = IIf(IsDBNull(Filas.Item(0)("xConstancia")), False, IIf(Filas.Item(0)("xConstancia") = "1", True, False))
                    Me.chkEstFinanc.Checked = IIf(IsDBNull(Filas.Item(0)("xEstadosFinancieros")), False, IIf(Filas.Item(0)("xEstadosFinancieros") = "1", True, False))
                    Me.chkDecIva.Checked = IIf(IsDBNull(Filas.Item(0)("xDeclaracionesIVA")), False, IIf(Filas.Item(0)("xDeclaracionesIVA") = "1", True, False))
                    Me.chkVisitaCampo.Checked = IIf(IsDBNull(Filas.Item(0)("xVisitaCampo")), False, IIf(Filas.Item(0)("xVisitaCampo") = "1", True, False))
                    Me.chkCertificadoISSS.Checked = IIf(IsDBNull(Filas.Item(0)("CertificadoISSS")), False, IIf(Filas.Item(0)("CertificadoISSS") = "1", True, False))
                    ds = oCred.ConsultarTipoIngresos("*", "CodTipoIngreso='" & Trim(Me.txtCodigo.Text) & "'", "", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        Me.txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    End If
                End If

            End If
            Me.txtCodigo.Focus()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet, Filas As Data.DataRowCollection
            Try
                oPerif = New wrCredito.wsLibCred
                ds = oPerif.ConsultarTipoIngresos("*", "CodTipoIngreso='" & Trim(Me.txtCodigo.Text) & "'", "", sUsuario, sPassword,sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    Me.C1NEMonto.Focus()
                Else
                    txtCodigo_DoubleClick(sender, e)
                End If

            Catch ex As Exception
               MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub txtCodigo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigo.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Tipos de Ingreso"
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarTipoIngresos("*", "", "CodTipoIngreso", sUsuario, sPassword,sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodigo.Text = ofrm.Resultado.Trim
            Me.txtDescripcion.Text = ofrm.Resultado2.Trim
            Me.C1NEMonto.Focus()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
