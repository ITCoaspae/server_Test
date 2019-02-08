Public Class frmMSConsultaMovimientosCuentas
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents lblCtasInactivas As System.Windows.Forms.Label
    'Private vTipoCuenta As AlcalaLibs.Ahorros.clsAhorro.TipoCuenta
    Private vTipoCuenta As sifLib.Ahorro.clsAhorros.TipoCuenta
    Friend WithEvents btnAceptar As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Private ahorros As New wrAhorro.wsLibAhorro

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMSConsultaMovimientosCuentas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAceptar = New MetroFramework.Controls.MetroButton()
        Me.lblCtasInactivas = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtNoCuenta = New System.Windows.Forms.TextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.fg)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Green
        Me.GroupBox1.Location = New System.Drawing.Point(23, 229)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(676, 212)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle Movimientos:"
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "16,1,0,0,0,85,Columns:0{Width:19;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(6, 19)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Size = New System.Drawing.Size(664, 177)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetroButton1)
        Me.GroupBox2.Controls.Add(Me.btnAceptar)
        Me.GroupBox2.Controls.Add(Me.lblCtasInactivas)
        Me.GroupBox2.Controls.Add(Me.lblEstado)
        Me.GroupBox2.Controls.Add(Me.txtDui)
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtNoSocio)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.dtpFin)
        Me.GroupBox2.Controls.Add(Me.dtpInicio)
        Me.GroupBox2.Controls.Add(Me.txtNoCuenta)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(455, 160)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Movimiento:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(292, 123)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(129, 28)
        Me.btnAceptar.Style = MetroFramework.MetroColorStyle.Green
        Me.btnAceptar.TabIndex = 220
        Me.btnAceptar.Text = "Mostrar Movimientos"
        Me.btnAceptar.UseSelectable = True
        Me.btnAceptar.UseStyleColors = True
        '
        'lblCtasInactivas
        '
        Me.lblCtasInactivas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCtasInactivas.BackColor = System.Drawing.Color.White
        Me.lblCtasInactivas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCtasInactivas.ForeColor = System.Drawing.Color.Green
        Me.lblCtasInactivas.Location = New System.Drawing.Point(-355, 139)
        Me.lblCtasInactivas.Name = "lblCtasInactivas"
        Me.lblCtasInactivas.Size = New System.Drawing.Size(160, 16)
        Me.lblCtasInactivas.TabIndex = 167
        Me.lblCtasInactivas.Text = "Cuenta Inactiva"
        Me.lblCtasInactivas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCtasInactivas.Visible = False
        '
        'lblEstado
        '
        Me.lblEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstado.BackColor = System.Drawing.Color.White
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.Color.Green
        Me.lblEstado.Location = New System.Drawing.Point(-355, 123)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(160, 16)
        Me.lblEstado.TabIndex = 166
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(92, 19)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(112, 20)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNombre.Location = New System.Drawing.Point(91, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(330, 20)
        Me.txtNombre.TabIndex = 165
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 164
        Me.Label4.Text = "Asociado:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(317, 19)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.ReadOnly = True
        Me.txtNoSocio.Size = New System.Drawing.Size(104, 20)
        Me.txtNoSocio.TabIndex = 163
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(231, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "No. Asociado:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "DUI Asociado:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Cuenta:"
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(231, 97)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(43, 16)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "Hasta:"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(6, 97)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(39, 35)
        Me.Label22.TabIndex = 34
        Me.Label22.Text = "Dede:"
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(317, 97)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(104, 20)
        Me.dtpFin.TabIndex = 3
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(92, 97)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(112, 20)
        Me.dtpInicio.TabIndex = 2
        '
        'txtNoCuenta
        '
        Me.txtNoCuenta.Location = New System.Drawing.Point(91, 71)
        Me.txtNoCuenta.Name = "txtNoCuenta"
        Me.txtNoCuenta.Size = New System.Drawing.Size(330, 20)
        Me.txtNoCuenta.TabIndex = 1
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(203, 123)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(83, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton1.TabIndex = 221
        Me.MetroButton1.Text = "Limpiar"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'frmMSConsultaMovimientosCuentas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(719, 465)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimumSize = New System.Drawing.Size(719, 465)
        Me.Name = "frmMSConsultaMovimientosCuentas"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Consulta de Movimientos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Public Property TipoCuenta() As AlcalaLibs.Ahorros.clsAhorro.TipoCuenta
    Public Property TipoCuenta() As sifLib.Ahorro.clsAhorros.TipoCuenta
        Get
            Return vTipoCuenta
        End Get
        'Set(ByVal Value As AlcalaLibs.Ahorros.clsAhorro.TipoCuenta)
        Set(ByVal Value As sifLib.Ahorro.clsAhorros.TipoCuenta)
            vTipoCuenta = Value
        End Set
    End Property

    Public Sub Encabezado()

        fg.Cols.Item(1).Caption = "Número de Libreta"
        fg.Cols.Item(2).Caption = "Fecha"
        fg.Cols.Item(3).Caption = "Hora"
        fg.Cols.Item(4).Caption = "Cód. Transacción"
        fg.Cols.Item(5).Caption = "Tipo de Pago"
        fg.Cols.Item(6).Caption = "Valor de Transacción"
        fg.Cols.Item(7).Caption = "Saldo"
        fg.Cols.Item(8).Caption = "Tasa de Interes"
        fg.Cols.Item(9).Caption = "Tipo de Movimiento"
        fg.Cols.Item(10).Caption = "No de Caja"
        fg.Cols.Item(11).Caption = "Usuario de Caja"
        fg.Cols.Item(12).Caption = "Pago de Libreta"
        fg.Cols.Item(13).Caption = "Observacion"
        fg.Cols.Item(14).Caption = "Id de Movimiento"
        fg.Cols.Item(15).Caption = "Año"


        fg.Cols.Item(6).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftBottom
        fg.Cols.Item(7).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftBottom
        fg.Cols.Item(8).TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.LeftBottom

        fg.Cols.Item(6).Format = "##0.00"
        fg.Cols.Item(7).Format = "##0.00"
        fg.Cols.Item(8).Format = "##0.00"

        fg.Cols.Item(0).Width = 10
        fg.Cols.Item(1).Width = 100
        fg.Cols.Item(2).Width = 100
        fg.Cols.Item(3).Width = 100
        fg.Cols.Item(4).Width = 100
        fg.Cols.Item(5).Width = 100
        fg.Cols.Item(6).Width = 130
        fg.Cols.Item(7).Width = 100
        fg.Cols.Item(8).Width = 100
        fg.Cols.Item(9).Width = 130
        fg.Cols.Item(10).Width = 100
        fg.Cols.Item(11).Width = 100
        fg.Cols.Item(12).Width = 100
        fg.Cols.Item(13).Width = 100
        fg.Cols.Item(14).Width = 100
        fg.Cols.Item(15).Width = 75

    End Sub



    Private Sub frmMSConsultaMovimientosCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Encabezado()
    End Sub

    Private Sub txtNoCuenta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoCuenta.DoubleClick
        Dim frm As New frmAGenerico ', Fila As DataRowCollection
        Dim sTexto As String ', vCodTipoAhorro As String, pCodPlanAhorro As String, 
        Dim vTipoAhorro As String
        vTipoAhorro = ""

        frm.Text = "Buscar Cuenta"
        Dim oAh As wrAhorro.wsLibAhorro, ds As New Data.DataSet("Ahorro")
        Try
            oAh = New wrAhorro.wsLibAhorro
            'If Me.vTipoCuenta = AlcalaLibs.Ahorros.clsAhorro.TipoCuenta.Ahorro Then
            If Me.vTipoCuenta = sifLib.Ahorro.clsAhorros.TipoCuenta.Ahorro Then
                vTipoAhorro = " and Left(CodTipoAhorro,1)<>'1'"
                'ElseIf Me.vTipoCuenta = AlcalaLibs.Ahorros.clsAhorro.TipoCuenta.Aportacion Then
            ElseIf Me.vTipoCuenta = sifLib.Ahorro.clsAhorros.TipoCuenta.Aportacion Then
                vTipoAhorro = " and Left(CodTipoAhorro,1)='1'"
            End If
            ds = oAh.ConsultarCuentaAhorro("Dui,CodTipoAhorro,NoCuenta,NoCuentaAnterior,FechaApertura,Saldo_CuentaAhorro,SaldoDisponible_CuentaAhorro,Estado", "Dui='" & Me.txtDui.Value & "'" & vTipoAhorro, "NoCuenta", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.C1fgrdResultado.Cols.Item(5).Format = "##0.00"

            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado3.Trim
                Me.txtNoCuenta.Text = sTexto
                '================================================================
                Dim inactiva As Boolean
                inactiva = ahorros.Temp_Consultar_CtasInactivas(txtNoCuenta.Text)
                If inactiva = True Then
                    Me.lblCtasInactivas.Visible = True
                    Me.lblEstado.Visible = False
                Else
                    Me.lblCtasInactivas.Visible = False
                    Me.lblEstado.Visible = True
                End If
                '================================================================
                Select Case frm.Resultado8.Trim
                    Case "D" 'Digitada
                        Me.lblEstado.Text = "DIGITADA"
                    Case "A" 'A: Activa
                        Me.lblEstado.Text = "ACTIVA"
                    Case "C" 'C: Cancelada
                        Me.lblEstado.Text = "CANCELADA"
                    Case "I" 'Inactiva
                        Me.lblEstado.Text = "INACTIVA"
                    Case "B" 'Bloqueada
                        Me.lblEstado.Text = "BLOQUEADA"
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla AhCuentasAhorro- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub txtDui_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.GotFocus
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

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick

        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,Correlativo,NoSocio,Apellido1,Apellido2,Nombres", "", "Correlativo", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtNombre.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
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
                    Me.txtNombre.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim oAh As wrAhorro.wsLibAhorro
        Dim ds As New Data.DataSet
        Dim ofrm As New frmAGenerico

        Try
            oAh = New wrAhorro.wsLibAhorro
            If Me.txtNoCuenta.Text = "" = True Then
                MsgBox("Debe de ingresar un Número de Cuenta - Módulo Ahorros -", MsgBoxStyle.Information, "Módulo Ahorros")
            Else
                ds = oAh.MostrarMovimientos("*", "Fecha", Me.txtNoCuenta.Text.Trim, "", Me.dtpInicio.Value.ToShortDateString, Me.dtpFin.Value.ToShortDateString, Me.vTipoCuenta, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables("AhMovimientos")
                Encabezado()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click

        Dim ds As New DataSet
        Me.txtDui.Text = ""
        Me.txtDui.Value = ""
        Me.txtNombre.Text = ""
        Me.txtNoSocio.Text = ""
        Me.txtNoCuenta.Text = ""
        fg.DataSource = ds
    End Sub
End Class