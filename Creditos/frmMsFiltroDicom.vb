Public Class frmMsFiltroDicom
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCorrDicom As String, pAccion As String
    Friend WithEvents btNuevo1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label2 As Label
    Friend WithEvents btEliminar1 As MetroFramework.Controls.MetroButton

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAsociado As System.Windows.Forms.TextBox
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNoSolicitud As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents txtNIT As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsFiltroDicom))
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNoSolicitud = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNIT = New C1.Win.C1Input.C1TextBox()
        Me.btNuevo1 = New MetroFramework.Controls.MetroButton()
        Me.btModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoSolicitud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNIT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNoSocio
        '
        Me.txtNoSocio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSocio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSocio.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtNoSocio.Location = New System.Drawing.Point(455, 67)
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(163, 23)
        Me.txtNoSocio.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(352, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 19)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "No. Asociado:"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(30, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 19)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Asociado:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAsociado
        '
        Me.txtAsociado.BackColor = System.Drawing.Color.White
        Me.txtAsociado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAsociado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsociado.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtAsociado.Location = New System.Drawing.Point(162, 97)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.ReadOnly = True
        Me.txtAsociado.Size = New System.Drawing.Size(456, 25)
        Me.txtAsociado.TabIndex = 73
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(162, 67)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(163, 23)
        Me.txtDui.TabIndex = 0
        Me.txtDui.Tag = Nothing
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(30, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 19)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "DUI:"
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.ForeColor = System.Drawing.Color.Black
        Me.fg.Location = New System.Drawing.Point(34, 233)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Rows.DefaultSize = 21
        Me.fg.Size = New System.Drawing.Size(724, 255)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 81
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodPrestamo.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCodPrestamo.Location = New System.Drawing.Point(162, 128)
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(163, 23)
        Me.txtCodPrestamo.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(30, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 18)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Préstamo:"
        '
        'txtNoSolicitud
        '
        Me.txtNoSolicitud.BackColor = System.Drawing.Color.White
        Me.txtNoSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSolicitud.CustomFormat = "######"
        Me.txtNoSolicitud.DataType = GetType(Integer)
        Me.txtNoSolicitud.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNoSolicitud.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtNoSolicitud.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.txtNoSolicitud.Location = New System.Drawing.Point(455, 128)
        Me.txtNoSolicitud.Name = "txtNoSolicitud"
        Me.txtNoSolicitud.ReadOnly = True
        Me.txtNoSolicitud.Size = New System.Drawing.Size(163, 27)
        Me.txtNoSolicitud.TabIndex = 83
        Me.txtNoSolicitud.Tag = Nothing
        Me.txtNoSolicitud.Value = 0
        Me.txtNoSolicitud.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(358, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 19)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "No. Solicitud:"
        '
        'txtNIT
        '
        Me.txtNIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNIT.EditMask = "0000-000000-000-0"
        Me.txtNIT.Location = New System.Drawing.Point(162, 158)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.NumericInput = False
        Me.txtNIT.Size = New System.Drawing.Size(163, 23)
        Me.txtNIT.TabIndex = 86
        Me.txtNIT.Tag = Nothing
        Me.txtNIT.Visible = False
        '
        'btNuevo1
        '
        Me.btNuevo1.Location = New System.Drawing.Point(34, 194)
        Me.btNuevo1.Name = "btNuevo1"
        Me.btNuevo1.Size = New System.Drawing.Size(90, 32)
        Me.btNuevo1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNuevo1.TabIndex = 87
        Me.btNuevo1.Text = "Agregar"
        Me.btNuevo1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNuevo1.UseSelectable = True
        Me.btNuevo1.UseStyleColors = True
        '
        'btModificar1
        '
        Me.btModificar1.Location = New System.Drawing.Point(131, 194)
        Me.btModificar1.Name = "btModificar1"
        Me.btModificar1.Size = New System.Drawing.Size(90, 32)
        Me.btModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btModificar1.TabIndex = 88
        Me.btModificar1.Text = "Modificar"
        Me.btModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btModificar1.UseSelectable = True
        Me.btModificar1.UseStyleColors = True
        '
        'btEliminar1
        '
        Me.btEliminar1.Location = New System.Drawing.Point(233, 194)
        Me.btEliminar1.Name = "btEliminar1"
        Me.btEliminar1.Size = New System.Drawing.Size(90, 32)
        Me.btEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEliminar1.TabIndex = 89
        Me.btEliminar1.Text = "Eliminar"
        Me.btEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEliminar1.UseSelectable = True
        Me.btEliminar1.UseStyleColors = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(30, 158)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 19)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "NIT:"
        '
        'frmMsFiltroDicom
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(786, 545)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btEliminar1)
        Me.Controls.Add(Me.btModificar1)
        Me.Controls.Add(Me.btNuevo1)
        Me.Controls.Add(Me.txtNIT)
        Me.Controls.Add(Me.txtCodPrestamo)
        Me.Controls.Add(Me.txtNoSolicitud)
        Me.Controls.Add(Me.fg)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.txtAsociado)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.Label14)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(786, 545)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(786, 545)
        Me.Name = "frmMsFiltroDicom"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Dicom"
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoSolicitud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNIT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

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
                txtNoSolicitud.Value = frm.Resultado3.Trim
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,Nosocio,Nit", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtDui.Value = Trim(dr("DUI"))
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                Me.txtNIT.Value = dr("NIT")
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtNoSocio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoSocio.DoubleClick
        Dim frm As New frmAGenerico
        Dim sTexto As String
        frm.Text = "Buscar Asociado"
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("NoSocio,DUI,Apellido1,Apellido2,Nombres", "", "Apellido1", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros

            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio,Nit", "NoSocio='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtDui.Value = Trim(dr("DUI"))
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                Me.txtNIT.Value = dr("NIT")
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsFiltroDicom_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If pAccion = "Modificar" Then
                Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow, oCred As New wrCredito.wsLibCred, dsC As New DataSet
                oAsoc = New wrAsociados.wsLibAsoc
                dsC = oCred.ConsultarDatGral("Dui,Nit", "NumSolicitud='" & Me.txtNoSolicitud.Value & "'", "Dui", sUsuario, sPassword, sSucursal)
                dr = dsC.Tables(0).Rows(0)
                Me.txtDui.Value = dr("Dui")
                Me.txtNIT.Value = dr("Nit")
                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio", "DUI='" & dr("Dui") & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                ds = oCred.ConsultarPRPrestamos("CodPrestamo", "NumSolicitud='" & Me.txtNoSolicitud.Value & "'", "CodPrestamo", False, sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                Me.txtCodPrestamo.Text = dr("CodPrestamo")
                Me.txtDui.Enabled = False
                Me.txtCodPrestamo.Enabled = False
                Me.txtNoSocio.Enabled = False
            End If
            ActualizaGrid()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
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


    Private Sub ActualizaGrid()
        Dim oCred As wrCredito.wsLibCred
        Dim ds As Data.DataSet = New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarDICOM("*", "NumSolicitud=" & Me.txtNoSolicitud.Text.Trim & "", "CorrelativoDicom", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        If Me.txtDui.Text.Trim = "" Then Exit Sub
        Dim sTexto As String
        Dim oAsoc As wrAsociados.wsLibAsoc, ds As New Data.DataSet, dr As DataRow
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            sTexto = Me.txtDui.Text.Trim
            If sTexto = "" Then      'Filtrar Registros

            ElseIf sTexto <> "" Then

                ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio,Nit", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Me.txtDui.Value = Trim(dr("DUI"))
                    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
                    Me.txtNoSocio.Text = Trim(dr("NoSocio"))
                    Me.txtNIT.Value = dr("NIT")
                End If
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btNuevo1_Click(sender As Object, e As EventArgs) Handles btNuevo1.Click
        Try
            Dim frm As New frmMsDICOM
            If Me.txtNoSolicitud.Text.Trim = "" Then Exit Sub
            frm.pNombre = Me.txtAsociado.Text
            frm.pDuiSol = Me.txtDui.Value
            frm.pNitSol = Me.txtNIT.Value
            frm.pNumSolicitud = Me.txtNoSolicitud.Value
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizaGrid()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btModificar1_Click(sender As Object, e As EventArgs) Handles btModificar1.Click
        Try
            If fg.Row <> -1 Then
                Dim frm As New frmMsDICOM
                Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
                Dim dr As Data.DataRow
                Dim ds As New Data.DataSet

                ds = oCred.ConsultarDICOM("*", "CorrelativoDicom='" & fg.Item(fg.Row, "CorrelativoDicom") & "'", "", sUsuario, sPassword, sSucursal)

                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    frm.pNombre = Me.txtAsociado.Text
                    frm.pDuiSol = Me.txtDui.Value
                    frm.pNitSol = Me.txtNIT.Value
                    frm.btnGuardar1.Text = "&Modificar"
                    frm.txtCorrelativoDICOM.Value = dr("CorrelativoDicom")
                    frm.pNumSolicitud = dr("NumSolicitud")
                    frm.dtpFechaHora.Value = IIf(IsDBNull(dr("Fecha")), "", dr("Fecha"))
                    frm.txtNoDICOM.Value = dr("NumDicom")
                    If Not dr("MoraBanca") Is DBNull.Value Then
                        If dr("MoraBanca") = "1" Then
                            frm.chkMoraBanca.Checked = True
                        Else
                            frm.chkMoraBanca.Checked = False
                        End If
                    Else
                        frm.chkMoraBanca.Checked = False
                    End If

                    If Not dr("MoraActual") Is DBNull.Value Then
                        If dr("MoraActual") = "1" Then
                            frm.chkMoraActual.Checked = True
                        Else
                            frm.chkMoraActual.Checked = False
                        End If
                    Else
                        frm.chkMoraActual.Checked = False
                    End If

                    If Not dr("MoraHistorica") Is DBNull.Value Then
                        If dr("MoraHistorica") = "1" Then
                            frm.chkMoraHistorica.Checked = True
                        Else
                            frm.chkMoraHistorica.Checked = False
                        End If
                    Else
                        frm.chkMoraHistorica.Checked = False
                    End If

                    If Not dr("Banco") Is DBNull.Value Then
                        If dr("Banco") = "1" Then
                            frm.chkBanco.Checked = True
                        Else
                            frm.chkBanco.Checked = False
                        End If
                    Else
                        frm.chkBanco.Checked = False
                    End If

                    If Not dr("TarjetaCredito") Is DBNull.Value Then
                        If dr("TarjetaCredito") = "1" Then
                            frm.chkTarjeta.Checked = True
                        Else
                            frm.chkTarjeta.Checked = False
                        End If
                    Else
                        frm.chkTarjeta.Checked = False
                    End If

                    If Not dr("Comercial") Is DBNull.Value Then
                        If dr("Comercial") = "1" Then
                            frm.chkComercial.Checked = True
                        Else
                            frm.chkComercial.Checked = False
                        End If
                    Else
                        frm.chkComercial.Checked = False
                    End If

                    If Not dr("Solicitante") Is DBNull.Value Then
                        If dr("Solicitante") = "1" Then
                            frm.chkSolicitante.Checked = True
                        Else
                            frm.chkSolicitante.Checked = False
                        End If
                    Else
                        frm.chkSolicitante.Checked = False
                    End If

                    If Not dr("Fiador") Is DBNull.Value Then
                        If dr("Fiador") = "1" Then
                            frm.chkFiador.Checked = True
                        Else
                            frm.chkFiador.Checked = False
                        End If
                    Else
                        frm.chkFiador.Checked = False
                    End If

                    frm.c1txtNombre.Value = dr("Nombre")
                    frm.txtNIT.Value = IIf(IsDBNull(dr("Dui")), "", dr("Dui"))
                    frm.txtNIT.Value = IIf(IsDBNull(dr("NIT")), "", dr("NIT"))
                    frm.c1txtObservaciones.Value = IIf(IsDBNull(dr("Observaciones")), "", dr("Observaciones"))
                    If Me.btEliminar1.Enabled = False Then
                        frm.btnGuardar1.Visible = False
                    End If
                    frm.StartPosition = FormStartPosition.CenterScreen
                    frm.ShowDialog()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEliminar1_Click(sender As Object, e As EventArgs) Handles btEliminar1.Click
        Try
            Dim oCred As New wrCredito.wsLibCred
            If fg.Row <> -1 Then
                If MsgBox("¿Desea eliminar el registro seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Dicom") = MsgBoxResult.Yes Then
                    oCred.EliminarDICOM(fg.Item(fg.Row, "CorrelativoDicom"), sUsuario, sPassword, sSucursal)
                    ActualizaGrid()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

End Class