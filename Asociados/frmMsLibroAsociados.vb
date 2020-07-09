Public Class frmMsLibroAsociados
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim asociados As New wrAsociados.wsLibAsoc
    Public pDui As String, pCorrelativo As String
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFecRegistro As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNumFolio As System.Windows.Forms.TextBox
    Friend WithEvents txtNumLibro As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtNoSocio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpFecRegistro = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNumFolio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNumLibro = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtNoSocio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFecRegistro
        '
        Me.dtpFecRegistro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecRegistro.Location = New System.Drawing.Point(169, 211)
        Me.dtpFecRegistro.Name = "dtpFecRegistro"
        Me.dtpFecRegistro.Size = New System.Drawing.Size(514, 23)
        Me.dtpFecRegistro.TabIndex = 9
        Me.dtpFecRegistro.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Fecha de Registro:"
        '
        'txtNumFolio
        '
        Me.txtNumFolio.Location = New System.Drawing.Point(169, 240)
        Me.txtNumFolio.MaxLength = 10
        Me.txtNumFolio.Name = "txtNumFolio"
        Me.txtNumFolio.Size = New System.Drawing.Size(514, 22)
        Me.txtNumFolio.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(23, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Número de Folio:"
        '
        'txtNumLibro
        '
        Me.txtNumLibro.Location = New System.Drawing.Point(169, 177)
        Me.txtNumLibro.MaxLength = 10
        Me.txtNumLibro.Name = "txtNumLibro"
        Me.txtNumLibro.Size = New System.Drawing.Size(514, 22)
        Me.txtNumLibro.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Número de Libro:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(127, 83)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(144, 20)
        Me.txtDui.TabIndex = 1
        Me.txtDui.Tag = Nothing
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(23, 83)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(38, 18)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "Dui:"
        '
        'txtNoSocio
        '
        Me.txtNoSocio.Location = New System.Drawing.Point(537, 82)
        Me.txtNoSocio.MaxLength = 8
        Me.txtNoSocio.Name = "txtNoSocio"
        Me.txtNoSocio.Size = New System.Drawing.Size(146, 22)
        Me.txtNoSocio.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(435, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No. Asociado:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(127, 110)
        Me.txtNombre.MaxLength = 150
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(556, 22)
        Me.txtNombre.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(23, 110)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 23)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Asociado:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(579, 268)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(104, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 18
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsLibroAsociados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(709, 352)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtNoSocio)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecRegistro)
        Me.Controls.Add(Me.txtNumFolio)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNumLibro)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsLibroAsociados"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Libro de Registro de Asociados"
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmMsLibroAsociados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.dtpFecRegistro.Value = Now


        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet ', objRow As Data.DataRow, 
        Dim pEstado As String
        Try


            If Me.btnGuardar1.Text = "&Modificar" Then

                Dim Filas As Data.DataRowCollection
                'Dim vLen As Long, x As Integer

                ds = oAsoc.ConsultarLibroRegistro("*", "Correlativo='" & pCorrelativo & "'", "Dui", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtDui.Text = pDui
                    txtNumLibro.Text = CStr(Filas.Item(0)("Libro"))
                    txtNumFolio.Text = CStr(Filas.Item(0)("Folio"))
                    dtpFecRegistro.Value = CDate(Filas.Item(0)("FechaRegistro"))

                    pEstado = IIf(Filas.Item(0)("Estado") Is DBNull.Value, "", Filas.Item(0)("Estado"))

                End If
                ds = oAsoc.ConsultarAsociado("NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre", "Dui='" & Trim(pDui) & "'", "Dui", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNoSocio.Text = IIf(IsDBNull(Filas.Item(0)("NoSocio")), "", Filas.Item(0)("NoSocio"))

                    txtNombre.Text = CStr(Filas.Item(0)("Nombre"))
                    txtDui.Enabled = False

                    txtNoSocio.Enabled = False
                    txtNombre.Enabled = False
                End If

            End If
        Catch ex As Exception

        End Try

    End Sub






    Private Sub txtNoSocio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoSocio.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                If txtNoSocio.Text.Trim = "" Then
                    txtNoSocio_DoubleClick(sender, e)
                Else
                    Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                    ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre,ApellidoCas", "NoSocio='" & txtNoSocio.Text.Trim & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio"))
                        txtDui.Text = CStr(Filas.Item(0)("DUI"))
                        txtNombre.Text = CStr(Filas.Item(0)("Nombre"))

                    Else
                        txtNoSocio_DoubleClick(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtNoSocio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoSocio.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Asociados"
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            oAsoc = New wrAsociados.wsLibAsoc
            ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CONCAT(RTRIM(Nombres),' ',RTRIM(Apellido1),' ',RTRIM(Apellido2),' ',RTRIM(ApellidoCas))[Nombre] ,", "", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtNoSocio.Text = ofrm.Resultado2.Trim
            txtDui.Text = ofrm.Resultado.Trim
            txtNombre.Text = ofrm.Resultado3.Trim

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
            ' txtCodAntiguo.Text = ofrm.Resultado3
            Dim dtsEstadoIngreso As New DataSet
            dtsEstadoIngreso = asociados.ConsultarEstadoIngreso("fechaActa [fechaActa]", " a.nosocio = '" & txtNoSocio.Text & "' ", "", sUsuario, sPassword, sSucursal)
            If dtsEstadoIngreso.Tables(0).Rows.Count > 0 Then
                dtpFecRegistro.Value = IIf(dtsEstadoIngreso.Tables(0).Rows(0).Item("fechaActa") Is DBNull.Value, Now, dtsEstadoIngreso.Tables(0).Rows(0).Item("fechaActa"))
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDui_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDui.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then txtDui_LostFocus(sender, e)
    End Sub

    Private Sub txtDui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDui.LostFocus
        Try
            If txtDui.Text.Trim = "" Then
            Else
                Dim dtsEstadoIngreso As New DataSet
                dtsEstadoIngreso = asociados.ConsultarEstadoIngreso("max(fechaActa) [fechaActa]", " a.dui = '" & txtDui.Text & "' ", "", sUsuario, sPassword, sSucursal)
                Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                ds = oAsoc.ConsultarAsociado("DUI,NoSocio,CodAntiguo,Nombres + ' ' + Apellido1 + ' ' + Apellido2 as Nombre", "Dui='" & txtDui.Text.Trim & "' and EstadoAsociado<>'2' and EstadoAsociado<>'1'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtNoSocio.Text = CStr(Filas.Item(0)("NoSocio")).Trim
                    txtDui.Value = CStr(Filas.Item(0)("DUI")).Trim
                    txtNombre.Text = CStr(Filas.Item(0)("Nombre")).Trim
                    'txtCodAntiguo.Text = CStr(Filas.Item(0)("CodAntiguo")).Trim

                End If
                If dtsEstadoIngreso.Tables(0).Rows.Count > 0 Then
                    dtpFecRegistro.Value = dtsEstadoIngreso.Tables(0).Rows(0).Item("fechaActa")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click

        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String ', pAsoc As String, pos As Long, 
        Dim pEstado As String
        Try


            pEstado = "0"

            If Me.btnGuardar1.Text = "&Guardar" Then

                Select Case oAsoc.AutorizaDatos(Trim(txtDui.Text), Trim(txtNumLibro.Text), Trim(txtNumFolio.Text), "x", "x")
                    Case 1
                        MsgBox("El campo Dui del Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                        Exit Sub
                    Case 2
                        MsgBox("El número de Libro no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                        Exit Sub
                    Case 3
                        MsgBox("El número de Folio no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                        Exit Sub
                    Case 4
                        MsgBox("El número de Asociado no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                        Exit Sub
                End Select

                pCampos = "DUI,Correlativo,NoSocio,Libro,Folio,FechaRegistro,Estado"
                pValores = "'" & Trim(txtDui.Text) &
                    "','" & oAsoc.ObtenerCorrelativoLibroRegistro("Correlativo", sUsuario, sPassword, sSucursal) &
                    "','" & Me.txtNoSocio.Text.Trim &
                    "','" & Trim(txtNumLibro.Text) &
                    "','" & Trim(txtNumFolio.Text) &
                    "','" & dtpFecRegistro.Value.ToShortDateString &
                    "','" & pEstado & "'"
                If oAsoc.InsertarLibroRegistro(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("El Registro ha sido agregado.", MsgBoxStyle.Information, "Módulo Asociados")
                    Dim frm As New frmVisorRS
                    OpcionRS = 102
                    With frm
                        .dui = txtNoSocio.Text

                        .Show()
                    End With
                    Me.Dispose()
                Else
                    MsgBox("El Registro NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Libro='" & Trim(txtNumLibro.Text) & "',Folio='" & Trim(txtNumFolio.Text) & "',FechaRegistro='" & dtpFecRegistro.Value.ToShortDateString & "'"
                If oAsoc.ModificarLibroRegistro("Correlativo='" & pCorrelativo & "'", pCampos, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("El Registro ha sido modificado.", MsgBoxStyle.Information, "Módulo Asociados")
                    Me.Dispose()
                Else
                    MsgBox("El Registro no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub frmMsLibroAsociados_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class