Public Class frmMsAhRepLibreta
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pNoCuenta As String, pCodTipoAhorro As String, pAccion As String, pCorrelativo As String, pNoLibreta As String
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Private usuarioAutoriza As String
    Friend WithEvents btnGuardar As MetroFramework.Controls.MetroButton
    Private pResultado As Boolean

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
    Friend WithEvents gbRepLib As System.Windows.Forms.GroupBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtNoLibreta As System.Windows.Forms.TextBox
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkCancelaComision As System.Windows.Forms.CheckBox
    Friend WithEvents txtNoSolicitud As System.Windows.Forms.TextBox
    Friend WithEvents cbCausa As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gbRepLib = New System.Windows.Forms.GroupBox()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNoLibreta = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.dtFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.chkCancelaComision = New System.Windows.Forms.CheckBox()
        Me.txtNoSolicitud = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.cbCausa = New System.Windows.Forms.ComboBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.btnGuardar = New MetroFramework.Controls.MetroButton()
        Me.gbRepLib.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbRepLib
        '
        Me.gbRepLib.BackColor = System.Drawing.Color.White
        Me.gbRepLib.Controls.Add(Me.txtObservacion)
        Me.gbRepLib.Controls.Add(Me.Label1)
        Me.gbRepLib.Controls.Add(Me.txtNoLibreta)
        Me.gbRepLib.Controls.Add(Me.Label40)
        Me.gbRepLib.Controls.Add(Me.dtFecha)
        Me.gbRepLib.Controls.Add(Me.Label39)
        Me.gbRepLib.Controls.Add(Me.chkCancelaComision)
        Me.gbRepLib.Controls.Add(Me.txtNoSolicitud)
        Me.gbRepLib.Controls.Add(Me.Label41)
        Me.gbRepLib.Controls.Add(Me.cbCausa)
        Me.gbRepLib.Controls.Add(Me.Label42)
        Me.gbRepLib.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.gbRepLib.ForeColor = System.Drawing.Color.Navy
        Me.gbRepLib.Location = New System.Drawing.Point(23, 63)
        Me.gbRepLib.Name = "gbRepLib"
        Me.gbRepLib.Size = New System.Drawing.Size(540, 167)
        Me.gbRepLib.TabIndex = 1
        Me.gbRepLib.TabStop = False
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.Color.White
        Me.txtObservacion.Location = New System.Drawing.Point(141, 98)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(387, 53)
        Me.txtObservacion.TabIndex = 188
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 187
        Me.Label1.Text = "observación:"
        '
        'txtNoLibreta
        '
        Me.txtNoLibreta.BackColor = System.Drawing.Color.White
        Me.txtNoLibreta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoLibreta.Location = New System.Drawing.Point(140, 12)
        Me.txtNoLibreta.MaxLength = 20
        Me.txtNoLibreta.Name = "txtNoLibreta"
        Me.txtNoLibreta.Size = New System.Drawing.Size(152, 20)
        Me.txtNoLibreta.TabIndex = 4
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(6, 14)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(128, 16)
        Me.Label40.TabIndex = 186
        Me.Label40.Text = "Nuevo No. de Libreta"
        '
        'dtFecha
        '
        Me.dtFecha.Enabled = False
        Me.dtFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(141, 65)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(151, 20)
        Me.dtFecha.TabIndex = 1
        Me.dtFecha.Value = New Date(2018, 8, 14, 0, 0, 0, 0)
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.Color.White
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(10, 65)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(116, 19)
        Me.Label39.TabIndex = 184
        Me.Label39.Text = "Fecha de cambio:"
        '
        'chkCancelaComision
        '
        Me.chkCancelaComision.ForeColor = System.Drawing.Color.Black
        Me.chkCancelaComision.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCancelaComision.Location = New System.Drawing.Point(400, 68)
        Me.chkCancelaComision.Name = "chkCancelaComision"
        Me.chkCancelaComision.Size = New System.Drawing.Size(128, 16)
        Me.chkCancelaComision.TabIndex = 3
        Me.chkCancelaComision.Text = "Cancela Comisión"
        Me.chkCancelaComision.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkCancelaComision.Visible = False
        '
        'txtNoSolicitud
        '
        Me.txtNoSolicitud.BackColor = System.Drawing.Color.White
        Me.txtNoSolicitud.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoSolicitud.Enabled = False
        Me.txtNoSolicitud.Location = New System.Drawing.Point(382, 12)
        Me.txtNoSolicitud.MaxLength = 50
        Me.txtNoSolicitud.Name = "txtNoSolicitud"
        Me.txtNoSolicitud.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoSolicitud.Size = New System.Drawing.Size(152, 20)
        Me.txtNoSolicitud.TabIndex = 0
        Me.txtNoSolicitud.Visible = False
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(6, 40)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(120, 16)
        Me.Label41.TabIndex = 181
        Me.Label41.Text = "Motivo Reposición:"
        '
        'cbCausa
        '
        Me.cbCausa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCausa.Items.AddRange(New Object() {"-- Seleccione una opción -- ", "Actualización de Libreta", "Libreta Dañada", "Libreta Extraviada", "Libreta Finalizada"})
        Me.cbCausa.Location = New System.Drawing.Point(140, 38)
        Me.cbCausa.Name = "cbCausa"
        Me.cbCausa.Size = New System.Drawing.Size(388, 21)
        Me.cbCausa.TabIndex = 2
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(304, 14)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(72, 16)
        Me.Label42.TabIndex = 176
        Me.Label42.Text = "No. Solicitud:"
        Me.Label42.Visible = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(491, 236)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 28)
        Me.btnGuardar.Style = MetroFramework.MetroColorStyle.Green
        Me.btnGuardar.TabIndex = 211
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseSelectable = True
        Me.btnGuardar.UseStyleColors = True
        '
        'frmMsAhRepLibreta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(586, 275)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.gbRepLib)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(586, 275)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(586, 275)
        Me.Name = "frmMsAhRepLibreta"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Reposición Libreta de Ahorros"
        Me.gbRepLib.ResumeLayout(False)
        Me.gbRepLib.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Private Sub gbRepLib_Enter(sender As Object, e As EventArgs) Handles gbRepLib.Enter

    End Sub

#End Region
    Public Property usuarioAut() As String
        Get
            Return usuarioAutoriza
        End Get
        Set(ByVal value As String)
            usuarioAutoriza = value
        End Set
    End Property

    Private Sub MetroButton3_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim oAsoc As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, pCampos As String, pValores As String
        Try
            If Me.btnGuardar.Text = "&Guardar" Then
                pCampos = "CodTipoAhorro,NoCuenta,Causa,CancelaComision,NoLibretaRepone,NoLibreta,Fecha,usuario,usuarioAutoriza,observacion"
                pValores = "'" & Me.pCodTipoAhorro & "','" & Me.pNoCuenta & "','" & Me.cbCausa.SelectedIndex &
                "','" & IIf(Me.chkCancelaComision.Checked = True, "1", "0") & "','" & Me.pNoLibreta & "','" &
                Trim(Me.txtNoLibreta.Text) & "','" & Format(Me.dtFecha.Value, "dd/MM/yyyy") & "', '" & sUsuario &
                "','" & usuarioAutoriza & "', '" & txtObservacion.Text & "'"
                If oAsoc.InsertarReposicionLibreta(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    resultado = oAsoc.ModificarCuentaAhorro(Me.pNoCuenta, Me.pCodTipoAhorro, "NoLibreta='" & Me.txtNoLibreta.Text.Trim & "'", sUsuario, sPassword, sSucursal)
                    MsgBox("No. de libreta actualizado exitosamente.", MsgBoxStyle.Information)
                    Me.Dispose()
                Else
                    MsgBox("El registro NO ha sido agregado. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            ElseIf Me.btnGuardar.Text = "&Modificar" Then
                pCampos = "Causa='" & Me.cbCausa.SelectedIndex &
                "',CancelaComision='" & IIf(Me.chkCancelaComision.Checked = True, "1", "0") &
                "',NoLibreta='" & Trim(Me.txtNoLibreta.Text) & "',Fecha='" & Format(Me.dtFecha.Value, "dd/MM/yyyy") &
                "',usuario ='" & sUsuario & "','" & usuarioAutoriza & "',observacion = '" & txtObservacion.Text.Trim & "'"
                If oAsoc.ModificarReposicionLibreta(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    resultado = oAsoc.ModificarCuentaAhorro(Me.pNoCuenta, Me.pCodTipoAhorro, "NoLibreta='" & Me.txtNoLibreta.Text.Trim & "'", sUsuario, sPassword, sSucursal)
                    Me.Dispose()
                Else
                    MsgBox("El registro no ha sido modificado. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Property resultado() As Boolean
        Get
            Return pResultado
        End Get
        Set(ByVal value As Boolean)
            pResultado = value
        End Set
    End Property



    Private Sub frmMsAhRepLibreta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ds As New Data.DataSet
        Dim oAsoc As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
        Dim Filas As Data.DataRowCollection
        Try
            Me.dtFecha.Value = Now
            Me.cbCausa.SelectedIndex = 0

            If Me.btnGuardar.Text = "&Modificar" Then

                ds = oAsoc.ConsultarReposicionLibreta("*", "NoSolicitud='" & Me.pCorrelativo & "'", "Fecha", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtNoSolicitud.Text = Filas.Item(0)("NoSolicitud")
                    Me.cbCausa.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("Causa")), 0, Filas.Item(0)("Causa"))
                    Me.chkCancelaComision.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("CancelaComision")), "0", Filas.Item(0)("CancelaComision")) = "1", True, False)
                    Me.txtNoLibreta.Text = IIf(IsDBNull(Filas.Item(0)("NoLibreta")), 0, Filas.Item(0)("NoLibreta"))
                    Me.dtFecha.Value = IIf(IsDBNull(Filas.Item(0)("Fecha")), Now, Filas.Item(0)("Fecha"))
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub

End Class
