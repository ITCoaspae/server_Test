Public Class frmMsASTipoCuota
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pAccion As String
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkProm = New System.Windows.Forms.CheckBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1nTotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nAportacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nMembresia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1nReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkActivo)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.dtpFin)
        Me.GroupBox1.Controls.Add(Me.dtpInicio)
        Me.GroupBox1.Controls.Add(Me.c1nTotal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.c1nAportacion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.c1nMembresia)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.c1nReserva)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkProm)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 203)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chkActivo
        '
        Me.chkActivo.Checked = True
        Me.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkActivo.Enabled = False
        Me.chkActivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.ForeColor = System.Drawing.Color.Black
        Me.chkActivo.Location = New System.Drawing.Point(283, 48)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(68, 16)
        Me.chkActivo.TabIndex = 8
        Me.chkActivo.Text = "&Activo"
        Me.chkActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(280, 158)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 16)
        Me.Label21.TabIndex = 140
        Me.Label21.Text = "Fecha de Finalización:"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(16, 158)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 16)
        Me.Label22.TabIndex = 139
        Me.Label22.Text = "Fecha de Inicio:"
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(406, 156)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(88, 20)
        Me.dtpFin.TabIndex = 6
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(152, 156)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(112, 20)
        Me.dtpInicio.TabIndex = 5
        '
        'c1nTotal
        '
        Me.c1nTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nTotal.CustomFormat = "##00.00"
        Me.c1nTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nTotal.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nTotal.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nTotal.Location = New System.Drawing.Point(152, 129)
        Me.c1nTotal.Name = "c1nTotal"
        Me.c1nTotal.ReadOnly = True
        Me.c1nTotal.ShowDropDownButton = False
        Me.c1nTotal.ShowUpDownButtons = False
        Me.c1nTotal.Size = New System.Drawing.Size(112, 21)
        Me.c1nTotal.TabIndex = 5
        Me.c1nTotal.Tag = Nothing
        Me.c1nTotal.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Total:"
        '
        'c1nAportacion
        '
        Me.c1nAportacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nAportacion.CustomFormat = "##00.00"
        Me.c1nAportacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nAportacion.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nAportacion.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nAportacion.Location = New System.Drawing.Point(152, 102)
        Me.c1nAportacion.Name = "c1nAportacion"
        Me.c1nAportacion.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nAportacion.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nAportacion.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nAportacion.ShowDropDownButton = False
        Me.c1nAportacion.ShowUpDownButtons = False
        Me.c1nAportacion.Size = New System.Drawing.Size(112, 21)
        Me.c1nAportacion.TabIndex = 4
        Me.c1nAportacion.Tag = Nothing
        Me.c1nAportacion.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Aportación:"
        '
        'c1nMembresia
        '
        'Me.c1nMembresia.AllowDbNull = False
        Me.c1nMembresia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nMembresia.CustomFormat = "##00.00"
        Me.c1nMembresia.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nMembresia.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nMembresia.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nMembresia.Location = New System.Drawing.Point(152, 75)
        Me.c1nMembresia.Name = "c1nMembresia"
        Me.c1nMembresia.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nMembresia.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nMembresia.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nMembresia.ShowDropDownButton = False
        Me.c1nMembresia.ShowUpDownButtons = False
        Me.c1nMembresia.Size = New System.Drawing.Size(112, 21)
        Me.c1nMembresia.TabIndex = 3
        Me.c1nMembresia.Tag = Nothing
        Me.c1nMembresia.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 16)
        Me.Label4.TabIndex = 81
        Me.Label4.Text = "Gastos de papelería:"
        '
        'c1nReserva
        '
        Me.c1nReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1nReserva.CustomFormat = "##00.00"
        Me.c1nReserva.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.c1nReserva.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.c1nReserva.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1nReserva.Location = New System.Drawing.Point(152, 48)
        Me.c1nReserva.Name = "c1nReserva"
        Me.c1nReserva.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1nReserva.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1nReserva.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1nReserva.ShowDropDownButton = False
        Me.c1nReserva.ShowUpDownButtons = False
        Me.c1nReserva.Size = New System.Drawing.Size(112, 21)
        Me.c1nReserva.TabIndex = 2
        Me.c1nReserva.Tag = Nothing
        Me.c1nReserva.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 80
        Me.Label3.Text = "Reserva de Educación:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(194, 13)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(300, 20)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(70, 13)
        Me.txtCodigo.MaxLength = 5
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(48, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(124, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Código:"
        '
        'chkProm
        '
        Me.chkProm.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProm.ForeColor = System.Drawing.Color.Black
        Me.chkProm.Location = New System.Drawing.Point(386, 48)
        Me.chkProm.Name = "chkProm"
        Me.chkProm.Size = New System.Drawing.Size(88, 16)
        Me.chkProm.TabIndex = 7
        Me.chkProm.Text = "&Promoción"
        Me.chkProm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(437, 272)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(87, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 127
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsASTipoCuota
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(547, 311)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsASTipoCuota"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Tipos de Cuota"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.c1nTotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nAportacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nMembresia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1nReserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmMsASTipoCuota_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        Try
            If Me.pAccion = "Modificar" Then

                ds = oAsoc.ConsultarTipoCuota("*", "CodCuota='" & pCodigo & "'", "CodCuota", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtCodigo.Text = pCodigo
                    txtCodigo.Enabled = False
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
                            oAsoc.ModificarTipoCuota(Trim(pCodigo), "Estado='0'", sUsuario, sPassword, sSucursal)
                            Me.btnGuardar1.Enabled = False
                        End If
                    End If
                End If
            End If
            txtCodigo.Focus()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub c1nAportacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nAportacion.LostFocus
        Me.c1nTotal.Value = Me.c1nMembresia.Value + Me.c1nReserva.Value + Me.c1nAportacion.Value
    End Sub

    Private Sub c1nReserva_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nReserva.LostFocus
        Me.c1nTotal.Value = Me.c1nMembresia.Value + Me.c1nReserva.Value + Me.c1nAportacion.Value
    End Sub

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oAsoc As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, pCampos As String, pValores As String

            Select Case oAsoc.AutorizaDatos(Trim(Me.txtCodigo.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El Código de Cuota no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Asociados")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "CodCuota,Descripcion,Reserva_Educacion,Membresia,Aportacion,Valor_Total,FechaInicio,FechaFin,Estado,Promocion"
                pValores = "'" & Trim(txtCodigo.Text) & "','" & Trim(txtDescripcion.Text) & "'," & Val(Me.c1nReserva.Value) & "," & Val(Me.c1nMembresia.Value) & "," & Val(Me.c1nAportacion.Value) & "," & Val(Me.c1nTotal.Value) & ",'" & Format(Me.dtpInicio.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFin.Value, "dd/MM/yyyy") & "','" & IIf(Me.chkActivo.Checked = True, 1, 0) & "','" & IIf(Me.chkProm.Checked = True, 1, 0) & "'"
                If oAsoc.InsertarTipoCuota(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El tipo de Cuota NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Descripcion='" & Trim(txtDescripcion.Text) & "',Reserva_Educacion=" & Val(Me.c1nReserva.Value) & ",Membresia=" & Val(Me.c1nMembresia.Value) & ",Aportacion=" & Val(Me.c1nAportacion.Value) & ",Valor_Total=" & Val(Me.c1nTotal.Value) & ",FechaInicio='" & Format(Me.dtpInicio.Value, "dd/MM/yyyy") & "',FechaFin='" & Format(Me.dtpFin.Value, "dd/MM/yyyy") & "',Estado='" & IIf(Me.chkActivo.Checked = True, 1, 0) & "',Promocion='" & IIf(Me.chkProm.Checked = True, 1, 0) & "'"
                If oAsoc.ModificarTipoCuota(Trim(pCodigo), pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El tipo de Cuota no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub c1nMembresia_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1nMembresia.LostFocus
        Me.c1nTotal.Value = Me.c1nMembresia.Value + Me.c1nReserva.Value + Me.c1nAportacion.Value
    End Sub

End Class
