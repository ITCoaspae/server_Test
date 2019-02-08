Public Class frmMsAhPosteo
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton4 As MetroFramework.Controls.MetroButton
    Private pCodTipoAhorro As String

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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents txtNoLibreta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents c1nSaldo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nNum As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents c1nCorr As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtNoLibreta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c1nSaldo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.c1nNum = New C1.Win.C1Input.C1NumericEdit()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.c1nCorr = New C1.Win.C1Input.C1NumericEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton4 = New MetroFramework.Controls.MetroButton()
        CType(Me.c1nSaldo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nCorr, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNoLibreta
        '
        Me.txtNoLibreta.AcceptsReturn = True
        Me.txtNoLibreta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoLibreta.Location = New System.Drawing.Point(149, 130)
        Me.txtNoLibreta.MaxLength = 20
        Me.txtNoLibreta.Name = "txtNoLibreta"
        Me.txtNoLibreta.Size = New System.Drawing.Size(144, 20)
        Me.txtNoLibreta.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 182
        Me.Label3.Text = "No. Libreta:"
        '
        'c1nSaldo
        '
        Me.c1nSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nSaldo.CustomFormat = "###,###,##0.00"
        Me.c1nSaldo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.c1nSaldo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nSaldo.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.c1nSaldo.Location = New System.Drawing.Point(149, 103)
        Me.c1nSaldo.Name = "c1nSaldo"
        Me.c1nSaldo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nSaldo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nSaldo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nSaldo.ShowDropDownButton = False
        Me.c1nSaldo.ShowUpDownButtons = False
        Me.c1nSaldo.Size = New System.Drawing.Size(144, 21)
        Me.c1nSaldo.TabIndex = 3
        Me.c1nSaldo.Tag = Nothing
        Me.c1nSaldo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(23, 103)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 16)
        Me.Label14.TabIndex = 181
        Me.Label14.Text = "Saldo:"
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCuenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoCuenta.Location = New System.Drawing.Point(377, 128)
        Me.txtNoCuenta.MaxLength = 20
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.Size = New System.Drawing.Size(144, 20)
        Me.txtNoCuenta.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(299, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 180
        Me.Label2.Text = "No. Cuenta:"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(23, 60)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(40, 16)
        Me.Label31.TabIndex = 179
        Me.Label31.Text = "Dui:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 32)
        Me.Label4.TabIndex = 184
        Me.Label4.Text = "No. de última " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "línea impresa:"
        '
        'c1nNum
        '
        Me.c1nNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nNum.CustomFormat = "#0"
        Me.c1nNum.DataType = GetType(Short)
        Me.c1nNum.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nNum.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nNum.Increment = CType(1, Short)
        Me.c1nNum.Location = New System.Drawing.Point(149, 156)
        Me.c1nNum.MaxLength = 3
        Me.c1nNum.Name = "c1nNum"
        Me.c1nNum.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nNum.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nNum.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nNum.ShowDropDownButton = False
        Me.c1nNum.ShowUpDownButtons = False
        Me.c1nNum.Size = New System.Drawing.Size(144, 21)
        Me.c1nNum.TabIndex = 4
        Me.c1nNum.Tag = Nothing
        Me.c1nNum.Value = CType(0, Short)
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.Color.White
        Me.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNombre.Location = New System.Drawing.Point(149, 80)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(372, 20)
        Me.lblNombre.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 189
        Me.Label1.Text = "Nombre de Asociado:"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(149, 56)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(144, 20)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'c1nCorr
        '
        Me.c1nCorr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nCorr.CustomFormat = "#0"
        Me.c1nCorr.DataType = GetType(Short)
        Me.c1nCorr.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nCorr.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nCorr.Increment = CType(1, Short)
        Me.c1nCorr.Location = New System.Drawing.Point(377, 156)
        Me.c1nCorr.MaxLength = 3
        Me.c1nCorr.Name = "c1nCorr"
        Me.c1nCorr.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nCorr.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nCorr.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(CType(0, Long), Nothing, True, True)})
        Me.c1nCorr.ShowDropDownButton = False
        Me.c1nCorr.ShowUpDownButtons = False
        Me.c1nCorr.Size = New System.Drawing.Size(144, 21)
        Me.c1nCorr.TabIndex = 5
        Me.c1nCorr.Tag = Nothing
        Me.c1nCorr.Value = CType(0, Short)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(299, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 30)
        Me.Label5.TabIndex = 208
        Me.Label5.Text = "Correlativo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Libreta:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(20, 197)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(96, 28)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton3.TabIndex = 209
        Me.MetroButton3.Text = "Postear Libreta"
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(122, 197)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(96, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton1.TabIndex = 210
        Me.MetroButton1.Text = "Iniciar Libreta"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(224, 197)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(96, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton2.TabIndex = 211
        Me.MetroButton2.Text = "Reponer Libreta"
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton4
        '
        Me.MetroButton4.Location = New System.Drawing.Point(326, 197)
        Me.MetroButton4.Name = "MetroButton4"
        Me.MetroButton4.Size = New System.Drawing.Size(131, 28)
        Me.MetroButton4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton4.TabIndex = 212
        Me.MetroButton4.Text = "Postear Nuevamente"
        Me.MetroButton4.UseSelectable = True
        Me.MetroButton4.UseStyleColors = True
        '
        'frmMsAhPosteo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(547, 248)
        Me.Controls.Add(Me.MetroButton4)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.c1nCorr)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.c1nNum)
        Me.Controls.Add(Me.txtNoLibreta)
        Me.Controls.Add(Me.c1nSaldo)
        Me.Controls.Add(Me.txtNoCuenta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label31)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhPosteo"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Posteo de Libreta"
        CType(Me.c1nSaldo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nCorr, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public Property TipoAhorro() As String
        Get
            Return pCodTipoAhorro
        End Get
        Set(ByVal Value As String)
            pCodTipoAhorro = Value
        End Set
    End Property



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

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim oAsoc As wrAsociados.wsLibAsoc
        Dim ds As New Data.DataSet
        Dim ofrm As New frmAGenerico

        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas", "", "DUI", sUsuario, sPassword, sSucursal)
            ofrm.Text = "Mostrar Asociados"
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then
                Dim sDui As String, sNombre As String
                sDui = ofrm.Resultado.Trim
                sNombre = ofrm.Resultado2.Trim & " " & ofrm.Resultado3.Trim & " " & ofrm.Resultado4.Trim
                Me.txtDui.Value = sDui.Trim
                Me.lblNombre.Text = sNombre
            End If
        Catch ex As Exception
            Dim sd As String
            sd = ex.Message
            sd = ex.Source
        End Try
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text.Trim = "" Then Exit Sub
        Try
            Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("Nombres,Apellido1,Apellido2,ApellidoCas", "Dui='" & Me.txtDui.Text.Trim & "'", "DUI", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.lblNombre.Text = dr("Nombres") & " " & dr("Apellido1") & " " & dr("Apellido2")
            End If

        Catch ex As Exception
            Dim sd As String
            sd = ex.Message
            sd = ex.Source
        End Try
    End Sub

    Private Sub txtNoCuenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoCuenta.LostFocus
        Dim oAh As New wrAhorro.wsLibAhorro, ds As New DataSet, dr As DataRow
        ds = oAh.ConsultarCuentaAhorro("CodTipoAhorro,NoLibreta", "NoCuenta='" & Me.txtNoCuenta.Text.Trim & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
        If ds.Tables(0).Rows.Count > 0 Then
            dr = ds.Tables(0).Rows(0)
            Me.pCodTipoAhorro = dr("CodTipoAhorro")
        End If
    End Sub

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles MetroButton3.Click
        Try
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet, vResp As String
            Dim dsPosteo As New DataSet, oAsoc As New wrAsociados.wsLibAsoc, dr As DataRow, vLineaMax As Integer, pMaxPag As Integer

            If Me.txtDui.Text.Trim = "" Or Me.txtNoCuenta.Text.Trim = "" Then
                MsgBox("Ingrese el Dui y el Número de Cuenta.", MsgBoxStyle.Critical, "Validación del Sistema")
                Exit Sub
            End If

            If Me.txtNoLibreta.Text.Trim = "" Then
                MsgBox("Debe digitar el No. de Libreta.", MsgBoxStyle.Critical, "Validación del Sistema")
                Exit Sub
            End If

            ds = oAsoc.ConsultarParametros("MaxNumLibreta", "", "MaxNumLibreta", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                vLineaMax = dr("MaxNumLibreta")
                pMaxPag = vLineaMax - 12
            End If
            If c1nNum.Value < pMaxPag Then
                vResp = oAhorro.PosteoMovimientos(False, Me.txtDui.Text.Trim, Me.txtNoCuenta.Text.Trim, Me.txtNoLibreta.Text.Trim, Me.c1nNum.Value, Me.c1nSaldo.Value, False, Me.c1nCorr.Value, False, sUsuario, sPassword, sSucursal)
            Else
                vResp = oAhorro.PosteoMovimientos(False, Me.txtDui.Text.Trim, Me.txtNoCuenta.Text.Trim, Me.txtNoLibreta.Text.Trim, Me.c1nNum.Value, Me.c1nSaldo.Value, False, Me.c1nCorr.Value, True, sUsuario, sPassword, sSucursal)
            End If
            If (vResp) = "" Then
                If c1nNum.Value < pMaxPag Then
                    dsPosteo = oAhorro.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta>" & Me.c1nNum.Value & " and a.IdLibreta=" & Me.c1nCorr.Value & " and a.Corr_Libreta<=" & pMaxPag & "", "a.Num", sUsuario, sPassword, sSucursal)
                Else
                    dsPosteo = oAhorro.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta>" & Me.c1nNum.Value & " and a.IdLibreta=" & Me.c1nCorr.Value & "", "a.Num", sUsuario, sPassword, sSucursal)
                End If
                Dim ofrm As New frmVisorLib(dsPosteo, 21, Me.c1nNum.Value, Me.c1nCorr.Value)
                ofrm.Show()
            Else
                MsgBox(vResp, MsgBoxStyle.Critical, "Validación del Sistema")
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim oAh As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
        Dim ds As New Data.DataSet, dsTmp As New DataSet, vResp As String, dr As DataRow, dsPosteo As New DataSet, oAsoc As New wrAsociados.wsLibAsoc, vLineaMax As Integer, pMaxPag As Integer
        Try

            ds = oAsoc.ConsultarParametros("MaxNumLibreta", "", "MaxNumLibreta", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                vLineaMax = dr("MaxNumLibreta")
                pMaxPag = vLineaMax - 12
            End If
            dsTmp = oAh.ConsultaPosteo("a.*", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Posteado='0'", "a.Num", sUsuario, sPassword, sSucursal)
            If dsTmp.Tables(0).Rows.Count > 0 Then 'Hay movimientos pendientes
                If c1nNum.Value < pMaxPag Then
                    vResp = oAh.PosteoMovimientos(True, Me.txtDui.Text.Trim, Me.txtNoCuenta.Text.Trim, "", 0, Me.c1nSaldo.Value, False, Me.c1nCorr.Value, False, sUsuario, sPassword, sSucursal)
                Else
                    vResp = oAh.PosteoMovimientos(True, Me.txtDui.Text.Trim, Me.txtNoCuenta.Text.Trim, "", 0, Me.c1nSaldo.Value, False, Me.c1nCorr.Value, True, sUsuario, sPassword, sSucursal)
                End If
                If vResp Is Nothing Then
                    ds = oAh.InicializacionLibreta(Me.txtDui.Value, Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
                    If c1nNum.Value < pMaxPag Then
                        dsPosteo = oAh.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta=1 and a.IdLibreta=" & Me.c1nCorr.Value & " and a.Corr_Libreta<=" & pMaxPag & "", "a.Num", sUsuario, sPassword, sSucursal)
                    Else
                        dsPosteo = oAh.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta=1 and a.IdLibreta=" & Me.c1nCorr.Value & "", "a.Num", sUsuario, sPassword, sSucursal)
                    End If
                    Dim ofrm As New frmMsAhInicializacionLibreta
                    ofrm.vNoExistMov = False
                    ofrm.TipoAhorro = Me.pCodTipoAhorro
                    ofrm.dsPosteo = dsPosteo
                    vNocta = Me.txtNoCuenta.Text.Trim
                    vDui = Me.txtDui.Text.Trim
                    ofrm.ds = ds
                    ofrm.ShowDialog()
                Else
                    If vResp.Trim = "" Then
                        ds = oAh.InicializacionLibreta(Me.txtDui.Value, Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
                        If c1nNum.Value < pMaxPag Then
                            dsPosteo = oAh.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta=1 and a.IdLibreta=" & Me.c1nCorr.Value & " and a.Corr_Libreta<=" & pMaxPag & "", "a.Num", sUsuario, sPassword, sSucursal)
                        Else
                            dsPosteo = oAh.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta=1 and a.IdLibreta=" & Me.c1nCorr.Value & "", "a.Num", sUsuario, sPassword, sSucursal)
                        End If
                        Dim ofrm As New frmMsAhInicializacionLibreta
                        ofrm.vNoExistMov = False
                        ofrm.TipoAhorro = Me.pCodTipoAhorro
                        ofrm.dsPosteo = dsPosteo
                        vNocta = Me.txtNoCuenta.Text.Trim
                        vDui = Me.txtDui.Text.Trim
                        ofrm.ds = ds
                        ofrm.ShowDialog()
                    Else
                        MessageBox.Show(vResp, "Posteo de Libreta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            Else 'No hay movimientos pendientes
                ds = oAh.InicializacionLibreta(Me.txtDui.Value, Me.txtNoCuenta.Text.Trim, sUsuario, sPassword, sSucursal)
                'dsPosteo = oAh.ConsultaPosteo("a.*,b.Titular2 as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Num=1", "a.Num", sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmMsAhInicializacionLibreta
                ofrm.vNoExistMov = True
                ofrm.TipoAhorro = Me.pCodTipoAhorro
                ofrm.dsPosteo = ds 'Posteo
                vNocta = Me.txtNoCuenta.Text.Trim
                vDui = Me.txtDui.Text.Trim
                ofrm.ds = ds
                ofrm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub MetroButton2_Click(sender As Object, e As EventArgs) Handles MetroButton2.Click
        Try
            If Me.txtNoCuenta.Text.Trim = "" Then
                MessageBox.Show("Debe digitar el No. de Cuenta.", "Reposición de Libreta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Dim oAh As New wrAhorro.wsLibAhorro, frm As frmMsAhRepLibreta = New frmMsAhRepLibreta, ds As New DataSet, dr As DataRow
            ds = oAh.ConsultarCuentaAhorro("CodTipoAhorro,NoLibreta", "NoCuenta='" & Me.txtNoCuenta.Text.Trim & "'", "NoCuenta", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                frm.pCodTipoAhorro = dr("CodTipoAhorro")
                frm.pNoLibreta = dr("NoLibreta")
                frm.pNoCuenta = Me.txtNoCuenta.Text.Trim
                frm.pAccion = "Guardar"
                frm.btnGuardar.Text = "&Guardar"
                frm.ShowDialog()
                MessageBox.Show("Reposición de libreta efectuado.", "Reposición de Libreta", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador.", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub MetroButton4_Click(sender As Object, e As EventArgs) Handles MetroButton4.Click
        Try

            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet, vResp As String
            Dim dsPosteo As New DataSet, oAsoc As New wrAsociados.wsLibAsoc, dr As DataRow, vLineaMax As Integer, pMaxPag As Integer

            ds = oAsoc.ConsultarParametros("MaxNumLibreta", "", "MaxNumLibreta", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                vLineaMax = dr("MaxNumLibreta")
                pMaxPag = vLineaMax - 12
            End If

            If Me.txtDui.Text.Trim = "" Or Me.txtNoCuenta.Text.Trim = "" Then
                MsgBox("Ingrese el Dui y el Número de Cuenta.", MsgBoxStyle.Critical, "Validación del Sistema")
                Exit Sub
            End If

            If Me.txtNoLibreta.Text.Trim = "" Then
                MsgBox("Debe digitar el No. de Libreta.", MsgBoxStyle.Critical, "Validación del Sistema")
                Exit Sub
            End If
            If c1nNum.Value < pMaxPag Then
                vResp = oAhorro.PosteoMovimientos(False, Me.txtDui.Text.Trim, Me.txtNoCuenta.Text.Trim, Me.txtNoLibreta.Text.Trim, Me.c1nNum.Value, Me.c1nSaldo.Value, True, Me.c1nCorr.Value, False, sUsuario, sPassword, sSucursal)
            Else
                vResp = oAhorro.PosteoMovimientos(False, Me.txtDui.Text.Trim, Me.txtNoCuenta.Text.Trim, Me.txtNoLibreta.Text.Trim, Me.c1nNum.Value, Me.c1nSaldo.Value, True, Me.c1nCorr.Value, True, sUsuario, sPassword, sSucursal)
            End If
            If (vResp) = "" Then
                If c1nNum.Value < pMaxPag Then
                    dsPosteo = oAhorro.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta=" & Me.c1nNum.Value & " and a.IdLibreta=" & Me.c1nCorr.Value & " and a.Corr_Libreta<=" & pMaxPag & "", "a.Num", sUsuario, sPassword, sSucursal)
                Else
                    dsPosteo = oAhorro.ConsultaPosteo("a.*,c.Nombres + ' ' + c.Apellido1 + ' ' + c.Apellido2 + ' ' + c.ApellidoCas as NombreAhorrante", "a.NoCuenta='" & Me.txtNoCuenta.Text.Trim & "' and a.Corr_Libreta=" & Me.c1nNum.Value & " and a.IdLibreta=" & Me.c1nCorr.Value & "", "a.Num", sUsuario, sPassword, sSucursal)
                End If
                Dim ofrm As New frmVisorLib(dsPosteo, 21, Me.c1nNum.Value, Me.c1nCorr.Value)
                ofrm.Show()
            Else
                MsgBox(vResp, MsgBoxStyle.Critical, "Validación del Sistema")
            End If


        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador.", MsgBoxStyle.Critical)
        End Try
    End Sub


End Class