Public Class frmMsCatContab
    Inherits frmAMto 'SIF_ERP.frmAMto
    Private sTexto As String, oFila As DataRow
    Private Legal As String, Inhabilitada As String
    Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
    Friend WithEvents chkComun As System.Windows.Forms.CheckBox
    Friend WithEvents cbCentroCosto As System.Windows.Forms.ComboBox

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
    Friend WithEvents chkLegal As System.Windows.Forms.CheckBox
    Friend WithEvents chkInhabilitada As System.Windows.Forms.CheckBox
    Dim contabilidad As New wrConta.wsLibContab
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkLegal = New System.Windows.Forms.CheckBox()
        Me.chkInhabilitada = New System.Windows.Forms.CheckBox()
        Me.lblCentroCosto = New System.Windows.Forms.Label()
        Me.cbCentroCosto = New System.Windows.Forms.ComboBox()
        Me.chkComun = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'chkLegal
        '
        Me.chkLegal.Location = New System.Drawing.Point(31, 252)
        Me.chkLegal.Name = "chkLegal"
        Me.chkLegal.Size = New System.Drawing.Size(77, 27)
        Me.chkLegal.TabIndex = 25
        Me.chkLegal.Text = "Legal"
        Me.chkLegal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkInhabilitada
        '
        Me.chkInhabilitada.Location = New System.Drawing.Point(115, 252)
        Me.chkInhabilitada.Name = "chkInhabilitada"
        Me.chkInhabilitada.Size = New System.Drawing.Size(119, 27)
        Me.chkInhabilitada.TabIndex = 26
        Me.chkInhabilitada.Text = "Inhabilitada"
        '
        'lblCentroCosto
        '
        Me.lblCentroCosto.AutoSize = True
        Me.lblCentroCosto.Location = New System.Drawing.Point(311, 153)
        Me.lblCentroCosto.Name = "lblCentroCosto"
        Me.lblCentroCosto.Size = New System.Drawing.Size(74, 34)
        Me.lblCentroCosto.TabIndex = 27
        Me.lblCentroCosto.Text = "Centro de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Costo:"
        '
        'cbCentroCosto
        '
        Me.cbCentroCosto.BackColor = System.Drawing.Color.White
        Me.cbCentroCosto.FormattingEnabled = True
        Me.cbCentroCosto.Location = New System.Drawing.Point(385, 159)
        Me.cbCentroCosto.Name = "cbCentroCosto"
        Me.cbCentroCosto.Size = New System.Drawing.Size(234, 24)
        Me.cbCentroCosto.TabIndex = 28
        '
        'chkComun
        '
        Me.chkComun.AutoSize = True
        Me.chkComun.Location = New System.Drawing.Point(220, 256)
        Me.chkComun.Name = "chkComun"
        Me.chkComun.Size = New System.Drawing.Size(123, 21)
        Me.chkComun.TabIndex = 29
        Me.chkComun.Text = "Cuenta Común"
        Me.chkComun.UseVisualStyleBackColor = True
        '
        'frmMsCatContab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(634, 357)
        Me.Controls.Add(Me.chkComun)
        Me.Controls.Add(Me.cbCentroCosto)
        Me.Controls.Add(Me.lblCentroCosto)
        Me.Controls.Add(Me.chkInhabilitada)
        Me.Controls.Add(Me.chkLegal)
        Me.MaximumSize = New System.Drawing.Size(634, 357)
        Me.MinimumSize = New System.Drawing.Size(634, 357)
        Me.Name = "frmMsCatContab"
        Me.Controls.SetChildIndex(Me.chkLegal, 0)
        Me.Controls.SetChildIndex(Me.chkInhabilitada, 0)
        Me.Controls.SetChildIndex(Me.lblCentroCosto, 0)
        Me.Controls.SetChildIndex(Me.cbCentroCosto, 0)
        Me.Controls.SetChildIndex(Me.chkComun, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Protected Sub LlenarCentroCosto()
        Dim dts As New DataSet
        dts = contabilidad.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "Cod_CCosto,Descripcion", "", "Descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbCentroCosto.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Protected Sub llenar_TipoCuenta()
        Dim dts As New DataSet
        dts = contabilidad.consultarCat_TipoCtas_Contables("", "", sUsuario)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cmbTipoCuenta.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Private Sub frmMsCatContab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim y As Integer, x As Integer
        Me.cbCentroCosto.DisplayMember = "Descripcion"
        Me.cbCentroCosto.ValueMember = "Cod_CCosto"
        Me.cmbTipoCuenta.DisplayMember = "Descripcion"
        Me.cmbTipoCuenta.ValueMember = "Tipo_Cuenta"

        LlenarCentroCosto()
        llenar_TipoCuenta()
        Dim oCat As wrConta.wsLibContab, ds As New Data.DataSet, oRow As Data.DataRow
        'Dim sTipoC() As String = {"A - Activo", "P - Pasivo", "C - Capital", "G - Gastos", "I - Ingresos", "D - Orden", "R - Resultado"}
        Dim sFinal() As String = {"S - Si", "N - No"}
        'For y = 0 To sTipoC.GetUpperBound(0)
        '    cmbTipoCuenta.Items.Add(sTipoC(y))
        'Next
        For y = 0 To sFinal.GetUpperBound(0)
            cmbFinal.Items.Add(sFinal(y))
        Next
        If Me.IdCuenta <> "" Then
            Try
                oCat = New wrConta.wsLibContab
                ds = oCat.ObtenerCatContab("*", "Idcuenta='" & Me.IdCuenta.Trim & "'", "IdCuenta", sUsuario, sPassword, sSucursal)
                oRow = ds.Tables(0).Rows(0)
                Me.txtIdCuenta.Text = oRow.Item("IdCuenta")
                Me.txtDescripcion.Text = oRow.Item("Descripcion")
                Me.nudNivel.Value = oRow.Item("Nivel")
                'Me.cmbTipoCuenta.Text = oRow.Item("Tipo_Cuenta")
                Me.txtCtaDependencia.Text = oRow.Item("Cta_Dependencia")
                Me.cmbFinal.Text = oRow.Item("Final")


                Me.cmbTipoCuenta.SelectedValue = oRow.Item("Tipo_Cuenta")
                Me.cbCentroCosto.SelectedValue = oRow.Item("Cod_CCosto")
                Me.chkComun.Checked = oRow.Item("CuentaComun")
                For x = 0 To Me.cmbTipoCuenta.Items.Count - 1
                    Me.cmbTipoCuenta.SelectedIndex = x
                    If Mid(Me.cmbTipoCuenta.Text.Trim, 1, 1) = oRow.Item("Tipo_Cuenta") Then
                        Me.cmbTipoCuenta.SelectedIndex = x
                        Exit For
                    End If
                Next


                For x = 0 To Me.cmbFinal.Items.Count - 1
                    Me.cmbFinal.SelectedIndex = x
                    If Mid(Me.cmbFinal.Text.Trim, 1, 1) = oRow.Item("Final") Then
                        Me.cmbFinal.SelectedIndex = x
                        Exit For
                    End If
                Next

                If oRow.Item("Legal") = "S" Then
                    Me.chkLegal.Checked = True
                Else
                    Me.chkLegal.Checked = False
                End If
                If oRow.Item("Inhabilitado") = "S" Then
                    Me.chkInhabilitada.Checked = True
                Else
                    Me.chkInhabilitada.Checked = False
                End If
            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla Catalogo- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Public Overrides Sub btnAceptarOnClick()
        If Me.chkLegal.Checked = True Then
            Legal = "S"
        Else
            Legal = "N"
        End If
        If Me.chkInhabilitada.Checked = True Then
            Inhabilitada = "S"
        Else
            Inhabilitada = "N"
        End If
        If Me.btnAceptar.Text = "Insertar" Then
            Me.Insertar()
        ElseIf Me.btnAceptar.Text = "Modificar" Then
            Me.Modificar()
        ElseIf Me.btnAceptar.Text = "Eliminar" Then
            Me.Eliminar()
        End If
        Me.IdCuenta = ""
        Me.Close()
    End Sub

    Public Overrides Sub btnCancelarOnClick()
        Me.IdCuenta = ""
    End Sub

    Public Overrides Sub btnBuscarOnClick()
        Generico()
        txtIdCuenta.Text = sTexto
        'txtCtaDependencia.Text = oFila(3)
        'nudNivel.Value = oFila(2)
        'Me.cmbTipoCuenta.Text = oFila(4)
    End Sub

    Public Overrides Sub txtIdCuentaKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                Dim oCat As New wrConta.wsLibContab, ds As New DataSet, dr As DataRow
                ds = oCat.VerificaCuentaContab(txtIdCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                If dr("Valida") = "S" Then
                    If dr("Final") = "S" Then
                        Me.txtIdCuenta.Text = ""
                        MessageBox.Show("Cuenta de Dependencia no válida porque es final", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        Exit Sub
                    End If
                    Me.nudNivel.Value = dr("Nivel")
                    Me.cmbTipoCuenta.Text = Trim(dr("Tipo_Cuenta"))
                    Me.txtCtaDependencia.Text = dr("Cta_Dependencia")
                Else
                    If txtIdCuenta.Text.Trim <> "" Then
                        MessageBox.Show("Cuenta no válida verifique", "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        txtIdCuenta.Text = ""
                    End If
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            If txtIdCuenta.Text.Trim <> "" Then
                MessageBox.Show("Origen del Error: " & ex.Source & " --- Mensaje de Error: Longitud NO Válida", "Error Capturado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                txtIdCuenta.Text = ""
            End If

            Exit Sub
        End Try

    End Sub

    Public Overrides Sub btnBuscar2OnClick()
        Generico()
        txtCtaDependencia.Text = sTexto
    End Sub

    Private Sub Generico()
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Contable"
        Dim oCat As wrConta.wsLibContab = New wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oCat = New wrConta.wsLibContab
            ds = oCat.ObtenerCatContab("Idcuenta,Descripcion,Nivel,Cta_Dependencia,Tipo_Cuenta", "", "IdCuenta", sUsuario, sPassword,sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            sTexto = ofrm.Resultado.Trim
            '            oFila = ofrm.Fila
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catalogo- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Insertar()
        Dim oCat As wrConta.wsLibContab = New wrConta.wsLibContab, pCampos As String, pValores As String
        Dim vTipo As String, vFinal As String
        pCampos = "IdCuenta,Descripcion,Nivel,Tipo_Cuenta,Cta_Dependencia,Final,Legal,Inhabilitado,Cod_CCosto,CuentaComun"
        vTipo = Me.cmbTipoCuenta.Text.Trim.Substring(0, 1)
        vFinal = Me.cmbFinal.Text.Trim.Substring(0, 1)
        pValores = "'" & Me.txtIdCuenta.Text.Trim & "','" &
        Me.txtDescripcion.Text.Trim & "'," & Me.nudNivel.Value & ",'" &
        Me.cmbTipoCuenta.SelectedValue & "','" & Me.txtCtaDependencia.Text.Trim & "','" & vFinal &
        "','" & Legal & "','" & Inhabilitada & "','0', '" & Me.chkComun.Checked & "'"
        If oCat.InsertaCuentaContab(pCampos, pValores, sUsuario, sPassword,sSucursal) = True Then
            MsgBox("Cuenta Contable Agregada")
        Else
            MsgBox("Cuenta Contable NO Agregada", MsgBoxStyle.Critical, "Error de Validación/Derechos en Cuenta Contable")
        End If
    End Sub

    Private Sub Modificar()
        Dim oCat As wrConta.wsLibContab = New wrConta.wsLibContab
        Dim pIdCuenta As String, pCamposyValores As String
        Dim vTipo As String, vFinal As String
        vTipo = Me.cmbTipoCuenta.Text.Trim.Substring(0, 1)
        vFinal = Me.cmbFinal.Text.Trim.Substring(0, 1)
        pIdCuenta = Me.txtIdCuenta.Text.Trim
        pCamposyValores = "Descripcion='" & Me.txtDescripcion.Text.Trim &
        "',Nivel=" & Me.nudNivel.Value & ",Tipo_Cuenta='" & vTipo & "',Cta_Dependencia='" &
        Me.txtCtaDependencia.Text.Trim & "',Final='" & vFinal & "',Legal='" & Legal & "',Inhabilitado='" & Inhabilitada _
        & "',cod_Ccosto = '0', CuentaComun = '" & Me.chkComun.Checked & "'"
        If oCat.ModificaCuentaContab(pIdCuenta, pCamposyValores, sUsuario, sPassword,sSucursal) = True Then
            MsgBox("Cuenta Contable Modificada")
        Else
            MsgBox("Cuenta Contable NO Modificada", MsgBoxStyle.Critical, "Error de Validación/Derechos en Cuenta Contable")
        End If
    End Sub

    Private Sub Eliminar()
        Dim oCat As wrConta.wsLibContab = New wrConta.wsLibContab
        Dim pIdCuenta As String
        pIdCuenta = Me.txtIdCuenta.Text.Trim
        If oCat.EliminaCuentaContab(pIdCuenta, sUsuario, sPassword,sSucursal) = True Then
            MsgBox("Cuenta Contable Eliminada")
        Else
            MsgBox("Cuenta Contable NO Eliminada", MsgBoxStyle.Critical, "Error de Validación/Derechos en Cuenta Contable")
        End If
    End Sub

End Class
