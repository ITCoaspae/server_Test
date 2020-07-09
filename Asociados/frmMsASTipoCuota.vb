Public Class frmMsASTipoCuota
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pAccion As String
    Friend WithEvents Label7 As Label
    Friend WithEvents cbItem As ComboBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Dim caja As New wrCaja.wsLibCaja
    Dim asociado As New wrAsociados.wsLibAsoc

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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents c1nTotal As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nAportacion As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nMembresia As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents c1nReserva As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents chkProm As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.c1nTotal = New C1.Win.C1Input.C1NumericEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.c1nAportacion = New C1.Win.C1Input.C1NumericEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.c1nMembresia = New C1.Win.C1Input.C1NumericEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.c1nReserva = New C1.Win.C1Input.C1NumericEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkProm = New System.Windows.Forms.CheckBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbItem = New System.Windows.Forms.ComboBox()
        CType(Me.c1nTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nAportacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMembresia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkActivo
        '
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.ForeColor = System.Drawing.Color.Black
        Me.chkActivo.Location = New System.Drawing.Point(186, 114)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(71, 19)
        Me.chkActivo.TabIndex = 8
        Me.chkActivo.Text = "&Activo"
        Me.chkActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(23, 283)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(144, 19)
        Me.Label21.TabIndex = 140
        Me.Label21.Text = "Fin Promoción:"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(23, 255)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(115, 19)
        Me.Label22.TabIndex = 139
        Me.Label22.Text = "Inicio Promoción:"
        '
        'dtpFin
        '
        Me.dtpFin.Enabled = False
        Me.dtpFin.Location = New System.Drawing.Point(186, 283)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(360, 22)
        Me.dtpFin.TabIndex = 6
        '
        'dtpInicio
        '
        Me.dtpInicio.Enabled = False
        Me.dtpInicio.Location = New System.Drawing.Point(186, 255)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(360, 22)
        Me.dtpInicio.TabIndex = 5
        '
        'c1nTotal
        '
        Me.c1nTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTotal.CustomFormat = "##00.00"
        Me.c1nTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nTotal.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTotal.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nTotal.Location = New System.Drawing.Point(186, 226)
        Me.c1nTotal.Name = "c1nTotal"
        Me.c1nTotal.ReadOnly = True
        Me.c1nTotal.Size = New System.Drawing.Size(360, 23)
        Me.c1nTotal.TabIndex = 5
        Me.c1nTotal.Tag = Nothing
        Me.c1nTotal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nTotal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(23, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(87, 18)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Total:"
        '
        'c1nAportacion
        '
        Me.c1nAportacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nAportacion.CustomFormat = "##00.00"
        Me.c1nAportacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nAportacion.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nAportacion.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nAportacion.Location = New System.Drawing.Point(186, 197)
        Me.c1nAportacion.Name = "c1nAportacion"
        Me.c1nAportacion.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nAportacion.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nAportacion.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nAportacion.Size = New System.Drawing.Size(360, 23)
        Me.c1nAportacion.TabIndex = 4
        Me.c1nAportacion.Tag = Nothing
        Me.c1nAportacion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nAportacion.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 18)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Aportación:"
        '
        'c1nMembresia
        '
        Me.c1nMembresia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMembresia.CustomFormat = "##00.00"
        Me.c1nMembresia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nMembresia.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMembresia.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nMembresia.Location = New System.Drawing.Point(186, 168)
        Me.c1nMembresia.Name = "c1nMembresia"
        Me.c1nMembresia.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMembresia.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMembresia.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMembresia.Size = New System.Drawing.Size(360, 23)
        Me.c1nMembresia.TabIndex = 3
        Me.c1nMembresia.Tag = Nothing
        Me.c1nMembresia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nMembresia.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 18)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Gastos Administrativos:"
        '
        'c1nReserva
        '
        Me.c1nReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nReserva.CustomFormat = "##00.00"
        Me.c1nReserva.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nReserva.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nReserva.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.c1nReserva.Location = New System.Drawing.Point(186, 139)
        Me.c1nReserva.Name = "c1nReserva"
        Me.c1nReserva.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nReserva.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nReserva.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nReserva.Size = New System.Drawing.Size(360, 23)
        Me.c1nReserva.TabIndex = 2
        Me.c1nReserva.Tag = Nothing
        Me.c1nReserva.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.c1nReserva.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 19)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Reserva Educación:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(186, 86)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(360, 22)
        Me.txtDescripcion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 19)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Descripción Cuota:"
        '
        'chkProm
        '
        Me.chkProm.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProm.ForeColor = System.Drawing.Color.Black
        Me.chkProm.Location = New System.Drawing.Point(275, 114)
        Me.chkProm.Name = "chkProm"
        Me.chkProm.Size = New System.Drawing.Size(106, 19)
        Me.chkProm.TabIndex = 7
        Me.chkProm.Text = "&Promoción"
        Me.chkProm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(441, 341)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(105, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 127
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 311)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 17)
        Me.Label7.TabIndex = 141
        Me.Label7.Text = "Item Facturable:"
        '
        'cbItem
        '
        Me.cbItem.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbItem.FormattingEnabled = True
        Me.cbItem.Location = New System.Drawing.Point(186, 311)
        Me.cbItem.Name = "cbItem"
        Me.cbItem.Size = New System.Drawing.Size(360, 24)
        Me.cbItem.TabIndex = 142
        '
        'frmMsASTipoCuota
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(594, 456)
        Me.Controls.Add(Me.cbItem)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.dtpFin)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.c1nTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.c1nAportacion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.chkProm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.c1nMembresia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.c1nReserva)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsASTipoCuota"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Tipos de Cuota"
        CType(Me.c1nTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nAportacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMembresia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nReserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub frmMsASTipoCuota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        llenarItem()

        Try
            If Me.pAccion = "Modificar" Then

                ds = asociado.ConsultarTipoCuota("*", "CodCuota='" & pCodigo & "'", "CodCuota", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    cbItem.SelectedValue = IIf(IsDBNull(Filas.Item(0)("codItem")), "", Filas.Item(0)("codItem"))
                    txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    Me.c1nReserva.Value = IIf(IsDBNull(Filas.Item(0)("Reserva_Educacion")), 0, Filas.Item(0)("Reserva_Educacion"))
                    Me.c1nMembresia.Value = IIf(IsDBNull(Filas.Item(0)("Membresia")), 0, Filas.Item(0)("Membresia"))
                    Me.c1nAportacion.Value = IIf(IsDBNull(Filas.Item(0)("Aportacion")), 0, Filas.Item(0)("Aportacion"))
                    Me.c1nTotal.Value = IIf(IsDBNull(Filas.Item(0)("Valor_Total")), 0, Filas.Item(0)("Valor_Total"))
                    If Not Filas.Item(0)("Estado") Is DBNull.Value Then
                        chkActivo.Checked = IIf(Filas.Item(0)("Estado") = "0", False, True)
                    End If
                    If Not Filas.Item(0)("Promocion") Is DBNull.Value Then
                        chkProm.Checked = IIf(Filas.Item(0)("Promocion") = "0", False, True)
                    End If
                    If Not Filas.Item(0)("FechaInicio") Is DBNull.Value Then
                        dtpInicio.Value = Filas.Item(0)("FechaInicio")
                    End If
                    If Not Filas.Item(0)("FechaFin") Is DBNull.Value Then
                        dtpFin.Value = Filas.Item(0)("FechaFin")
                        If Me.dtpFin.Value < Now.ToShortDateString And Me.chkProm.Checked = True Then
                            asociado.ModificarTipoCuota(Trim(pCodigo), "Estado='0'", sUsuario, sPassword, sSucursal)
                            Me.btnGuardar1.Enabled = False
                        End If
                    End If
                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub c1nAportacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nAportacion.LostFocus
        Me.c1nTotal.Value = Me.c1nMembresia.Value + Me.c1nReserva.Value + Me.c1nAportacion.Value
    End Sub

    Private Sub c1nReserva_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nReserva.LostFocus
        Me.c1nTotal.Value = Me.c1nMembresia.Value + Me.c1nReserva.Value + Me.c1nAportacion.Value
    End Sub
    Private Function generarCodigoCuota() As Integer
        Dim dts As New DataSet
        Dim LastCodCuota As Integer = 0
        Dim codCuota As Integer = 0
        dts = asociado.ConsultarTipoCuota("MAX(CAST(CodCuota AS int))[CodCuota]", "", " CodCuota", sUsuario, sPassword, sSucursal)
        LastCodCuota = IIf(dts.Tables(0).Rows(0).Item(0) Is DBNull.Value, 0, dts.Tables(0).Rows(0).Item(0))
        codCuota = LastCodCuota + 1
        Return codCuota
    End Function
    Public Sub llenarItem()
        Dim dts As New DataSet
        dts = caja.ConsultarCAItemsFact("codItem,descripcion", "Tipo_item = 'P' ", "Descripcion", sUsuario, sPassword, sSucursal)
        cbItem.DataSource = dts.Tables(0)
        cbItem.DisplayMember = "Descripcion"
        cbItem.ValueMember = "codItem"
    End Sub
    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim asociado As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String



            If Me.btnGuardar1.Text = "&Guardar" Then
                Dim codCuota As Integer = 0
                codCuota = generarCodigoCuota()
                pCampos = "CodCuota,Descripcion,Reserva_Educacion,Membresia,Aportacion,Valor_Total,FechaInicio,FechaFin,Estado,Promocion,codItem"
                pValores = "'" & codCuota & "','" & Trim(txtDescripcion.Text) & "'," & Me.c1nReserva.Value & "," & c1nMembresia.Value & "," & c1nAportacion.Value & "," & c1nTotal.Value & ",'" & dtpInicio.Value.ToShortDateString & "','" & dtpFin.Value.ToShortDateString & "','" & IIf(Me.chkActivo.Checked = True, 1, 0) & "','" & IIf(Me.chkProm.Checked = True, 1, 0) & "', '" & cbItem.SelectedValue & "'"
                If asociado.InsertarTipoCuota(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    Me.Dispose()
                Else
                    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)

                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Descripcion='" & Trim(txtDescripcion.Text) &
                    "',Reserva_Educacion=" & c1nReserva.Value &
                    ",Membresia=" & c1nMembresia.Value &
                    ",Aportacion=" & c1nAportacion.Value &
                    ",Valor_Total=" & c1nTotal.Value &
                    ",FechaInicio='" & dtpInicio.Value.ToShortDateString &
                    "',FechaFin='" & dtpFin.Value.ToShortDateString &
                    "',Estado='" & IIf(chkActivo.Checked = True, 1, 0) &
                    "',Promocion='" & IIf(chkProm.Checked = True, 1, 0) &
                    "', codItem = '" & cbItem.SelectedValue & "'"
                If asociado.ModificarTipoCuota(Trim(pCodigo), pCampos, sUsuario, sPassword, sSucursal) = True Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeUpdateRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    Me.Dispose()
                Else
                    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, ex.TargetSite.ToString, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub c1nMembresia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nMembresia.LostFocus
        Me.c1nTotal.Value = Me.c1nMembresia.Value + Me.c1nReserva.Value + Me.c1nAportacion.Value
    End Sub

    Private Sub chkProm_CheckedChanged(sender As Object, e As EventArgs) Handles chkProm.CheckedChanged
        If chkProm.Checked = True Then
            dtpInicio.Enabled = True
            dtpFin.Enabled = True
        Else
            dtpInicio.Enabled = False
            dtpFin.Enabled = False
        End If
    End Sub

    Private Sub frmMsASTipoCuota_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
