Public Class frmMsCBCredito
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
    Friend WithEvents fg As C1.Win.C1FlexGrid.Classic.C1FlexGridClassic
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNit As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtTelCasa As System.Windows.Forms.TextBox
    Friend WithEvents txtCel As System.Windows.Forms.TextBox
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsCBCredito))
        Me.fg = New C1.Win.C1FlexGrid.Classic.C1FlexGridClassic()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTelCasa = New System.Windows.Forms.TextBox()
        Me.txtCel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNit = New C1.Win.C1Input.C1TextBox()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColorAlternate = System.Drawing.Color.WhiteSmoke
        Me.fg.BackColorFixed = System.Drawing.Color.Teal
        Me.fg.Cols = 50
        Me.fg.ColumnInfo = resources.GetString("fg.ColumnInfo")
        Me.fg.ForeColorFixed = System.Drawing.Color.White
        Me.fg.GridColorFixed = System.Drawing.SystemColors.ControlDark
        Me.fg.Location = New System.Drawing.Point(31, 219)
        Me.fg.Name = "fg"
        Me.fg.NodeClosedPicture = Nothing
        Me.fg.NodeOpenPicture = Nothing
        Me.fg.OutlineCol = -1
        Me.fg.Rows = 2
        Me.fg.SheetBorder = System.Drawing.Color.Black
        Me.fg.Size = New System.Drawing.Size(608, 198)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 7
        Me.fg.TreeColor = System.Drawing.Color.DarkGray
        '
        'txtDui
        '
        Me.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(131, 67)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(192, 23)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(30, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Asociado:"
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAsociado.Location = New System.Drawing.Point(131, 97)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.Size = New System.Drawing.Size(494, 25)
        Me.txtAsociado.TabIndex = 26
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPrestamo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodPrestamo.Location = New System.Drawing.Point(131, 128)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(192, 23)
        Me.txtCodPrestamo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(28, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Préstamo:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(28, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 19)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "DUI:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 19)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Teléfono Casa:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(330, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Celular:"
        '
        'txtTelCasa
        '
        Me.txtTelCasa.BackColor = System.Drawing.Color.White
        Me.txtTelCasa.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelCasa.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtTelCasa.Location = New System.Drawing.Point(131, 158)
        Me.txtTelCasa.Multiline = True
        Me.txtTelCasa.Name = "txtTelCasa"
        Me.txtTelCasa.ReadOnly = True
        Me.txtTelCasa.Size = New System.Drawing.Size(192, 19)
        Me.txtTelCasa.TabIndex = 30
        '
        'txtCel
        '
        Me.txtCel.BackColor = System.Drawing.Color.White
        Me.txtCel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCel.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCel.Location = New System.Drawing.Point(433, 158)
        Me.txtCel.Multiline = True
        Me.txtCel.Name = "txtCel"
        Me.txtCel.ReadOnly = True
        Me.txtCel.Size = New System.Drawing.Size(192, 19)
        Me.txtCel.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(330, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 19)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "NIT:"
        '
        'txtNit
        '
        Me.txtNit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNit.EditMask = "0000-000000-000-0"
        Me.txtNit.Location = New System.Drawing.Point(433, 67)
        Me.txtNit.Name = "txtNit"
        Me.txtNit.NumericInput = False
        Me.txtNit.Size = New System.Drawing.Size(192, 23)
        Me.txtNit.TabIndex = 1
        Me.txtNit.Tag = Nothing
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(31, 180)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(90, 32)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 1013
        Me.btnAgregar1.Text = "Gestor"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'frmMsCBCredito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(666, 459)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.txtNit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCel)
        Me.Controls.Add(Me.txtTelCasa)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAsociado)
        Me.Controls.Add(Me.txtCodPrestamo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.fg)
        Me.Name = "frmMsCBCredito"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Listado de Créditos Activos"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub txtCodPrestamo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodPrestamo.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Préstamo"
        Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo")
        Try
            oPrest = New wrPrestamo.wsLibPrest
            ds = oPrest.CargarListaPrestamos(False, "", "", Me.txtDui.Value, Me.txtDui.Value, 0, 0, sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                txtCodPrestamo.Text = sTexto.Trim
                Me.btnAgregar1.Enabled = True
                ds = oPrest.CargarListaPrestamos(False, frm.Resultado.Trim, frm.Resultado.Trim, Me.txtDui.Value, Me.txtDui.Value, 0, 0, sUsuario, sPassword, sSucursal)
                fg.DataSource = ds.Tables("Prestamos")
                Encabezado()
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Encabezado()
        '--------Formateo de ANCHO de columnas
        fg.ColumnCollection(1).Width = 100
        fg.ColumnCollection(13).Width = 100
        '--------Formateo de ENCABEZADO de columnas
        fg.ColumnCollection(1).Caption = "Código Préstamo"
        fg.ColumnCollection(13).Caption = "Interés Corriente"
        fg.ColumnCollection(14).Caption = "Interés Mora"
        fg.ColumnCollection(25).Caption = "Calificación"
        fg.ColumnCollection(31).Caption = "Ultimo Pago"
        fg.ColumnCollection(33).Caption = "Saldo Capital"
        fg.ColumnCollection(34).Caption = "Intereses Pagados"
        fg.ColumnCollection(35).Caption = "Saldo Dia Interes"
        fg.ColumnCollection(36).Caption = "Saldo Dia Capital Mora"
        fg.ColumnCollection(37).Caption = "Sald Dia Interes Mora"
        fg.ColumnCollection(38).Caption = "Saldo Dia Seguro Deuda"
        fg.ColumnCollection(39).Caption = "Saldo Dia Seguro Danios LA"
        fg.ColumnCollection(40).Caption = "Saldo Dia Seguro Vida"
        fg.ColumnCollection(41).Caption = "Saldo Dia Seguro Desempleo"
        fg.ColumnCollection(42).Caption = "Saldo Dia Aportacion"
        fg.ColumnCollection(43).Caption = "Saldo Dia Ahorro"
        fg.ColumnCollection(44).Caption = "Saldo Dia Comision Manejo"
        fg.ColumnCollection(45).Caption = "Saldo Dia Otros"

        fg.ColumnCollection(13).Format = "##0.00"
        fg.ColumnCollection(14).Format = "##0.00"
        fg.ColumnCollection(25).Format = "##0.00"
        fg.ColumnCollection(33).Format = "##0.00"
        fg.ColumnCollection(34).Format = "##0.00"
        fg.ColumnCollection(35).Format = "##0.00"
        fg.ColumnCollection(36).Format = "##0.00"
        fg.ColumnCollection(37).Format = "##0.00"
        fg.ColumnCollection(38).Format = "##0.00"
        fg.ColumnCollection(39).Format = "##0.00"
        fg.ColumnCollection(40).Format = "##0.00"
        fg.ColumnCollection(41).Format = "##0.00"
        fg.ColumnCollection(42).Format = "##0.00"
        fg.ColumnCollection(43).Format = "##0.00"
        fg.ColumnCollection(44).Format = "##0.00"
        fg.ColumnCollection(45).Format = "##0.00"

        '-------------Ocultar COLUMNAS
        fg.ColumnCollection(2).Visible = False
        fg.ColumnCollection(3).Visible = False
        fg.ColumnCollection(4).Visible = False
        fg.ColumnCollection(5).Visible = False
        fg.ColumnCollection(6).Visible = False
        fg.ColumnCollection(7).Visible = False
        fg.ColumnCollection(8).Visible = False
        fg.ColumnCollection(9).Visible = False
        fg.ColumnCollection(10).Visible = False
        fg.ColumnCollection(11).Visible = False
        fg.ColumnCollection(12).Visible = False
        fg.ColumnCollection(15).Visible = False
        fg.ColumnCollection(16).Visible = False
        fg.ColumnCollection(17).Visible = False
        fg.ColumnCollection(18).Visible = False
        fg.ColumnCollection(19).Visible = False
        fg.ColumnCollection(20).Visible = False
        fg.ColumnCollection(21).Visible = False
        fg.ColumnCollection(22).Visible = False
        fg.ColumnCollection(23).Visible = False
        fg.ColumnCollection(24).Visible = False
        fg.ColumnCollection(26).Visible = False
        fg.ColumnCollection(27).Visible = False
        fg.ColumnCollection(28).Visible = False
        fg.ColumnCollection(29).Visible = False
        fg.ColumnCollection(30).Visible = False
        fg.ColumnCollection(32).Visible = False
        fg.ColumnCollection(46).Visible = False
        fg.ColumnCollection(47).Visible = False
        fg.ColumnCollection(48).Visible = False
        fg.ColumnCollection(49).Visible = False
        fg.ColumnCollection(50).Visible = False
        fg.ColumnCollection(51).Visible = False
        fg.ColumnCollection(52).Visible = False

    End Sub

    Private Sub txtCodPrestamo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodPrestamo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

            Dim sTexto As String
            Dim oPrest As wrPrestamo.wsLibPrest, ds As New Data.DataSet("Prestamo"), dr As DataRow
            Try
                oPrest = New wrPrestamo.wsLibPrest
                sTexto = Me.txtCodPrestamo.Text
                If sTexto = "" Then

                ElseIf sTexto <> "" Then
                    ds = oPrest.CargaDatosPrestamoxRango(Me.txtCodPrestamo.Text.Trim, Now.ToShortDateString, Now.ToShortDateString, "", sUsuario, sPassword, sSucursal)
                    If ds.Tables(0).Rows.Count > 0 Then
                        dr = ds.Tables(0).Rows(0)
                        Me.btnAgregar1.Enabled = True
                        Me.txtCodPrestamo.Text = IIf(IsDBNull(dr("CodPrestamo")), 0, dr("CodPrestamo"))
                        Me.txtAsociado.Text = IIf(IsDBNull(dr("Nombre")), "", dr("Nombre"))
                        Me.txtDui.Value = IIf(IsDBNull(dr("Dui")), "", dr("Dui"))
                        Me.txtNit.Value = IIf(IsDBNull(dr("Nit")), "", dr("Nit"))
                        Me.txtTelCasa.Text = IIf(IsDBNull(dr("TelCasa")), "", dr("TelCasa"))
                        Me.txtCel.Text = IIf(IsDBNull(dr("Celular")), "", dr("Celular"))
                        ds = oPrest.CargarListaPrestamos(False, Me.txtCodPrestamo.Text, Me.txtCodPrestamo.Text, Me.txtDui.Value, Me.txtDui.Value, 0, 0, sUsuario, sPassword, sSucursal)
                        fg.DataSource = ds.Tables("Prestamos")
                        Encabezado()
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla PRPrestamos- " & "System Error: NO EXISTE EL CODIGO DE PRESTAMO --" & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    Private Sub btVerDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As frmMsCBBitacoraGestores = New frmMsCBBitacoraGestores
        frm.pAccion = "Modificar"
        frm.CodPrestamo = fg.Item(fg.Row, "CodPrestamo")
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
    End Sub

    Private Sub txtAsociado_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtAsociado.Validating
        Dim sTexto As String

        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            sTexto = Me.txtAsociado.Text
            If sTexto = "" Then 'Filtrar Registros

            ElseIf sTexto <> "" Then

                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,TelCasa,Celular,Nit", "Nombres LIKE '" & sTexto & "%'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtCel.Text = IIf(IsDBNull(dr("Celular")), "", dr("Celular"))
                    Me.txtTelCasa.Text = IIf(IsDBNull(dr("TelCasa")), "", dr("TelCasa"))
                    Me.txtNit.Value = IIf(IsDBNull(dr("Nit")), "", dr("Nit"))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: NO ENCUENTRA DUI ASOCIADO --" & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.DoubleClick
        Dim oAso As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Dim ds As New Data.DataSet
        Dim sResultado1, sResultado2, sResultado3, sResultado4, sResultado5 As String
        Dim ofrm As New frmAGenerico
        Try
            ofrm.Text = "Buscar Códigos de Asociados"
            ds = oAso.ConsultarAsociado("DUI,NIT, Nombres + ' ' + Apellido1 + ' ' + Apellido2 + ' ' + ApellidoCas As NombreCompleto, TelCasa, Celular", "", "DUI", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then
                sResultado1 = ofrm.Resultado
                sResultado2 = ofrm.Resultado2
                sResultado3 = ofrm.Resultado3
                sResultado4 = ofrm.Resultado4
                sResultado5 = ofrm.Resultado5
                Me.txtDui.Value = sResultado1.Trim
                Me.txtNit.Text = sResultado2.Trim
                Me.txtAsociado.Text = sResultado3
                Me.txtTelCasa.Text = sResultado4
                Me.txtCel.Text = sResultado5
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub txtAsociado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAsociado.DoubleClick
        Dim oAso As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Dim ds As New Data.DataSet
        Dim sResultado1, sResultado2, sResultado3, sResultado4, sResultado5 As String
        Dim ofrm As New frmAGenerico
        Try
            ofrm.Text = "Buscar Códigos de Asociados"
            ds = oAso.ConsultarAsociado("DUI,NIT, Nombres + ' ' + Apellido1 + ' ' + Apellido2 + ' ' + ApellidoCas As NombreCompleto, TelCasa, Celular", "", "DUI", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            sResultado1 = ofrm.Resultado
            sResultado2 = ofrm.Resultado2
            sResultado3 = ofrm.Resultado3
            sResultado4 = ofrm.Resultado4
            sResultado5 = ofrm.Resultado5
            Me.txtDui.Text = sResultado1
            Me.txtNit.Text = sResultado2
            Me.txtAsociado.Text = sResultado3
            Me.txtTelCasa.Text = sResultado4
            Me.txtCel.Text = sResultado5
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub txtNit_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNit.DoubleClick
        Dim oAso As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
        Dim ds As New Data.DataSet
        Dim sResultado1, sResultado2, sResultado3, sResultado4, sResultado5 As String
        Dim ofrm As New frmAGenerico
        Try
            ofrm.Text = "Buscar Códigos de Asociados"
            ds = oAso.ConsultarAsociado("DUI,NIT, Nombres + ' ' + Apellido1 + ' ' + Apellido2 + ' ' + ApellidoCas As NombreCompleto, TelCasa, Celular", "", "DUI", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            sResultado1 = ofrm.Resultado
            sResultado2 = ofrm.Resultado2
            sResultado3 = ofrm.Resultado3
            sResultado4 = ofrm.Resultado4
            sResultado5 = ofrm.Resultado5
            Me.txtDui.Text = sResultado1
            Me.txtNit.Text = sResultado2
            Me.txtAsociado.Text = sResultado3
            Me.txtTelCasa.Text = sResultado4
            Me.txtCel.Text = sResultado5
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub txtNit_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtNit.Validating
        Dim sTexto As String

        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc

            If Me.txtNit.ValueIsDbNull = False Then
                sTexto = Me.txtNit.Value
            Else
                sTexto = ""
            End If

            If sTexto = "" Then 'Filtrar Registros

            ElseIf sTexto <> "" Then
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,TelCasa,Celular,Nit", "NIT LIKE '" & sTexto & "%'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtCel.Text = IIf(IsDBNull(dr("Celular")), "", dr("Celular"))
                    Me.txtTelCasa.Text = IIf(IsDBNull(dr("TelCasa")), "", dr("TelCasa"))
                    Me.txtNit.Value = IIf(IsDBNull(dr("Nit")), "", dr("Nit"))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: NO ENCUENTRA DUI ASOCIADO --" & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub txtNit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNit.Click
        Try
            Dim Valor As String
            Valor = IIf(txtNit.ValueIsDbNull, "", txtNit.Value)
            If Valor.Trim = "" Then
                Me.txtNit.SelectionStart = 0
                Me.txtNit.SelectionLength = 0
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
            If sTexto = "" Then 'Filtrar Registros

            ElseIf sTexto <> "" Then
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,TelCasa,Celular,Nit", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtCel.Text = IIf(IsDBNull(dr("Celular")), "", dr("Celular"))
                    Me.txtTelCasa.Text = IIf(IsDBNull(dr("TelCasa")), "", dr("TelCasa"))
                    Me.txtNit.Value = IIf(IsDBNull(dr("Nit")), "", dr("Nit"))
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub frmMsCBCredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As frmMsCBBitacoraGestores = New frmMsCBBitacoraGestores
            frm.pAccion = "Agregar"
            frm.Dui = Me.txtDui.Value
            frm.CodPrestamo = fg.Item(fg.Row, "CodPrestamo")
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class