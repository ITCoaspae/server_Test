Public Class frmMsDICOM
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pNumSolicitud As String, pNombre As String, pDuiSol As String, pNitSol As String
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
    Friend WithEvents c1txtObservaciones As C1.Win.C1Input.C1TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents c1txtNombre As C1.Win.C1Input.C1TextBox
    Friend WithEvents chkFiador As System.Windows.Forms.CheckBox
    Friend WithEvents chkSolicitante As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNoDICOM As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtNIT As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtCorrelativoDICOM As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents dtpFechaHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCorr As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpHora As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkMoraBanca As System.Windows.Forms.CheckBox
    Friend WithEvents chkMoraActual As System.Windows.Forms.CheckBox
    Friend WithEvents chkMoraHistorica As System.Windows.Forms.CheckBox
    Friend WithEvents chkComercial As System.Windows.Forms.CheckBox
    Friend WithEvents chkTarjeta As System.Windows.Forms.CheckBox

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim campos, camposvalores, valores, pFiltro As String
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred
            Dim Solicitante As String, Fiador As String

            If chkSolicitante.Checked = True Then
                Solicitante = "1"
            Else
                Solicitante = "0"
            End If
            If chkFiador.Checked = True Then
                Fiador = "1"
            Else
                Fiador = "0"
            End If

            If Me.btnGuardar1.Text = "&Guardar" Then
                campos = "NumSolicitud,Fecha,Hora,NumDicom,Solicitante,Fiador,Nombre,Dui,NIT,Observaciones,MoraBanca,MoraActual,MoraHistorica,Banco,TarjetaCredito,Comercial"
                valores = "" & pNumSolicitud & ",'" & Me.dtpFechaHora.Value.ToShortDateString & "','" & Format(Me.dtpHora.Value, "HH:mm") & "'," & Me.txtNoDICOM.Text.Trim & ",'" & Solicitante & "','" & Fiador & "','" & Trim(Me.c1txtNombre.Text) & "','" & Me.txtDui.Value & "','" & Me.txtNIT.Value & "', '" & Trim(Me.c1txtObservaciones.Text) & "','" & IIf(Me.chkMoraBanca.Checked = True, "1", "0") & "','" & IIf(Me.chkMoraActual.Checked = True, "1", "0") & "','" & IIf(Me.chkMoraHistorica.Checked = True, "1", "0") & "','" & IIf(Me.chkBanco.Checked = True, "1", "0") & "','" & IIf(Me.chkTarjeta.Checked = True, "1", "0") & "','" & IIf(Me.chkComercial.Checked = True, "1", "0") & "'"
                If oCred.InsertarDICOM(campos, valores, sUsuario, sPassword, sSucursal) Then
                    Me.Dispose()
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                camposvalores = "Fecha='" & Me.dtpFechaHora.Value.ToShortDateString & "',Hora='" & Format(Me.dtpHora.Value, "HH:mm") & "',NumDicom=" & Me.txtNoDICOM.Text.Trim & ",Solicitante='" & Solicitante & "',Fiador='" & Fiador & "',Nombre='" & Trim(Me.c1txtNombre.Text) & "',Dui='" & Me.txtDui.Value & "',NIT='" & Me.txtNIT.Value & "', Observaciones='" & Trim(Me.c1txtObservaciones.Text) & "',MoraBanca='" & IIf(Me.chkMoraBanca.Checked = True, "1", "0") & "',MoraActual='" & IIf(Me.chkMoraActual.Checked = True, "1", "0") & "',MoraHistorica='" & IIf(Me.chkMoraHistorica.Checked = True, "1", "0") & "',Banco='" & IIf(Me.chkBanco.Checked = True, "1", "0") & "',TarjetaCredito='" & IIf(Me.chkTarjeta.Checked = True, "1", "0") & "',Comercial='" & IIf(Me.chkComercial.Checked = True, "1", "0") & "'"
                pFiltro = "CorrelativoDicom=" & Me.txtCorrelativoDICOM.Text & ""
                If oCred.ModificarDICOM(camposvalores, Me.txtCorrelativoDICOM.Text, sUsuario, sPassword, sSucursal) Then
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Friend WithEvents chkBanco As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkComercial = New System.Windows.Forms.CheckBox()
        Me.chkTarjeta = New System.Windows.Forms.CheckBox()
        Me.chkBanco = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkMoraHistorica = New System.Windows.Forms.CheckBox()
        Me.chkMoraActual = New System.Windows.Forms.CheckBox()
        Me.chkMoraBanca = New System.Windows.Forms.CheckBox()
        Me.txtDui = New C1.Win.C1Input.C1TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.c1txtObservaciones = New C1.Win.C1Input.C1TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.c1txtNombre = New C1.Win.C1Input.C1TextBox()
        Me.chkFiador = New System.Windows.Forms.CheckBox()
        Me.chkSolicitante = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoDICOM = New C1.Win.C1Input.C1NumericEdit()
        Me.txtNIT = New C1.Win.C1Input.C1TextBox()
        Me.txtCorrelativoDICOM = New C1.Win.C1Input.C1NumericEdit()
        Me.dtpFechaHora = New System.Windows.Forms.DateTimePicker()
        Me.lblCorr = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtObservaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1txtNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoDICOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNIT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCorrelativoDICOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkComercial
        '
        Me.chkComercial.Location = New System.Drawing.Point(134, 77)
        Me.chkComercial.Name = "chkComercial"
        Me.chkComercial.Size = New System.Drawing.Size(104, 24)
        Me.chkComercial.TabIndex = 2
        Me.chkComercial.Text = "Comercial"
        '
        'chkTarjeta
        '
        Me.chkTarjeta.Location = New System.Drawing.Point(134, 48)
        Me.chkTarjeta.Name = "chkTarjeta"
        Me.chkTarjeta.Size = New System.Drawing.Size(120, 24)
        Me.chkTarjeta.TabIndex = 1
        Me.chkTarjeta.Text = "Tarjeta de Crédito"
        '
        'chkBanco
        '
        Me.chkBanco.Location = New System.Drawing.Point(134, 24)
        Me.chkBanco.Name = "chkBanco"
        Me.chkBanco.Size = New System.Drawing.Size(104, 24)
        Me.chkBanco.TabIndex = 0
        Me.chkBanco.Text = "Banco"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkComercial)
        Me.GroupBox2.Controls.Add(Me.chkMoraHistorica)
        Me.GroupBox2.Controls.Add(Me.chkTarjeta)
        Me.GroupBox2.Controls.Add(Me.chkMoraActual)
        Me.GroupBox2.Controls.Add(Me.chkBanco)
        Me.GroupBox2.Controls.Add(Me.chkMoraBanca)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 120)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Morosidad"
        '
        'chkMoraHistorica
        '
        Me.chkMoraHistorica.Location = New System.Drawing.Point(24, 77)
        Me.chkMoraHistorica.Name = "chkMoraHistorica"
        Me.chkMoraHistorica.Size = New System.Drawing.Size(104, 24)
        Me.chkMoraHistorica.TabIndex = 2
        Me.chkMoraHistorica.Text = "Mora Histórica"
        '
        'chkMoraActual
        '
        Me.chkMoraActual.Location = New System.Drawing.Point(24, 48)
        Me.chkMoraActual.Name = "chkMoraActual"
        Me.chkMoraActual.Size = New System.Drawing.Size(104, 24)
        Me.chkMoraActual.TabIndex = 1
        Me.chkMoraActual.Text = "Mora Actual"
        '
        'chkMoraBanca
        '
        Me.chkMoraBanca.Location = New System.Drawing.Point(24, 24)
        Me.chkMoraBanca.Name = "chkMoraBanca"
        Me.chkMoraBanca.Size = New System.Drawing.Size(104, 24)
        Me.chkMoraBanca.TabIndex = 0
        Me.chkMoraBanca.Text = "Mora Banca"
        '
        'txtDui
        '
        Me.txtDui.EditMask = "00000000-0"
        Me.txtDui.Location = New System.Drawing.Point(145, 175)
        Me.txtDui.Name = "txtDui"
        Me.txtDui.NumericInput = False
        Me.txtDui.Size = New System.Drawing.Size(112, 20)
        Me.txtDui.TabIndex = 6
        Me.txtDui.Tag = Nothing
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(27, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "DUI:"
        '
        'dtpHora
        '
        Me.dtpHora.CustomFormat = "HH:mm"
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHora.Location = New System.Drawing.Point(145, 123)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.ShowUpDown = True
        Me.dtpHora.Size = New System.Drawing.Size(129, 20)
        Me.dtpHora.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(27, 123)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 16)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "Hora de Solicitud:"
        '
        'c1txtObservaciones
        '
        Me.c1txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtObservaciones.Location = New System.Drawing.Point(145, 201)
        Me.c1txtObservaciones.MaxLength = 255
        Me.c1txtObservaciones.Multiline = True
        Me.c1txtObservaciones.Name = "c1txtObservaciones"
        Me.c1txtObservaciones.NumericInput = False
        Me.c1txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.c1txtObservaciones.Size = New System.Drawing.Size(430, 32)
        Me.c1txtObservaciones.TabIndex = 10
        Me.c1txtObservaciones.Tag = Nothing
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(27, 201)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Observaciones:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(392, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 23)
        Me.Label7.TabIndex = 56
        Me.Label7.Text = "NIT:"
        '
        'c1txtNombre
        '
        Me.c1txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtNombre.Location = New System.Drawing.Point(145, 149)
        Me.c1txtNombre.MaxLength = 255
        Me.c1txtNombre.Name = "c1txtNombre"
        Me.c1txtNombre.NumericInput = False
        Me.c1txtNombre.Size = New System.Drawing.Size(430, 20)
        Me.c1txtNombre.TabIndex = 5
        Me.c1txtNombre.Tag = Nothing
        '
        'chkFiador
        '
        Me.chkFiador.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkFiador.Location = New System.Drawing.Point(145, 63)
        Me.chkFiador.Name = "chkFiador"
        Me.chkFiador.Size = New System.Drawing.Size(80, 24)
        Me.chkFiador.TabIndex = 1
        Me.chkFiador.Text = "Fiador"
        '
        'chkSolicitante
        '
        Me.chkSolicitante.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSolicitante.Location = New System.Drawing.Point(23, 63)
        Me.chkSolicitante.Name = "chkSolicitante"
        Me.chkSolicitante.Size = New System.Drawing.Size(87, 24)
        Me.chkSolicitante.TabIndex = 0
        Me.chkSolicitante.Text = "Solicitante"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(27, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(27, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "No. Solicitud DICOM:"
        '
        'txtNoDICOM
        '
        Me.txtNoDICOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoDICOM.CustomFormat = "######"
        Me.txtNoDICOM.DataType = GetType(Integer)
        Me.txtNoDICOM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtNoDICOM.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtNoDICOM.Increment = 1
        Me.txtNoDICOM.Location = New System.Drawing.Point(145, 96)
        Me.txtNoDICOM.Name = "txtNoDICOM"
        Me.txtNoDICOM.ShowDropDownButton = False
        Me.txtNoDICOM.ShowUpDownButtons = False
        Me.txtNoDICOM.Size = New System.Drawing.Size(129, 21)
        Me.txtNoDICOM.TabIndex = 2
        Me.txtNoDICOM.Tag = Nothing
        Me.txtNoDICOM.Value = 0
        '
        'txtNIT
        '
        Me.txtNIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNIT.EditMask = "0000-000000-000-0"
        Me.txtNIT.Location = New System.Drawing.Point(446, 175)
        Me.txtNIT.Name = "txtNIT"
        Me.txtNIT.NumericInput = False
        Me.txtNIT.Size = New System.Drawing.Size(129, 20)
        Me.txtNIT.TabIndex = 7
        Me.txtNIT.Tag = Nothing
        '
        'txtCorrelativoDICOM
        '
        Me.txtCorrelativoDICOM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorrelativoDICOM.CustomFormat = "#######0"
        Me.txtCorrelativoDICOM.DataType = GetType(Short)
        Me.txtCorrelativoDICOM.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtCorrelativoDICOM.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtCorrelativoDICOM.Increment = CType(1, Short)
        Me.txtCorrelativoDICOM.Location = New System.Drawing.Point(350, 319)
        Me.txtCorrelativoDICOM.MaxLength = 10
        Me.txtCorrelativoDICOM.Name = "txtCorrelativoDICOM"
        Me.txtCorrelativoDICOM.ReadOnly = True
        Me.txtCorrelativoDICOM.ShowDropDownButton = False
        Me.txtCorrelativoDICOM.ShowUpDownButtons = False
        Me.txtCorrelativoDICOM.Size = New System.Drawing.Size(8, 21)
        Me.txtCorrelativoDICOM.TabIndex = 44
        Me.txtCorrelativoDICOM.Tag = Nothing
        Me.txtCorrelativoDICOM.Value = CType(0, Short)
        Me.txtCorrelativoDICOM.Visible = False
        '
        'dtpFechaHora
        '
        Me.dtpFechaHora.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaHora.Location = New System.Drawing.Point(446, 95)
        Me.dtpFechaHora.Name = "dtpFechaHora"
        Me.dtpFechaHora.Size = New System.Drawing.Size(129, 20)
        Me.dtpFechaHora.TabIndex = 3
        '
        'lblCorr
        '
        Me.lblCorr.Location = New System.Drawing.Point(373, 324)
        Me.lblCorr.Name = "lblCorr"
        Me.lblCorr.Size = New System.Drawing.Size(8, 16)
        Me.lblCorr.TabIndex = 46
        Me.lblCorr.Text = "Correlativo DICOM:"
        Me.lblCorr.Visible = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(336, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Fecha de Solicitud:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(500, 331)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 38
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsDICOM
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(606, 397)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.c1txtObservaciones)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.txtNIT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.chkSolicitante)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNoDICOM)
        Me.Controls.Add(Me.dtpHora)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.c1txtNombre)
        Me.Controls.Add(Me.dtpFechaHora)
        Me.Controls.Add(Me.chkFiador)
        Me.Controls.Add(Me.txtCorrelativoDICOM)
        Me.Controls.Add(Me.lblCorr)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(606, 397)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(606, 397)
        Me.Name = "frmMsDICOM"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Consulta Dicom"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.txtDui, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtObservaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1txtNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoDICOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNIT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCorrelativoDICOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub chkSolicitante_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSolicitante.CheckedChanged
        If Me.chkSolicitante.Checked = True Then
            Me.c1txtNombre.Value = pNombre
            Me.txtDui.Value = pDuiSol
            Me.txtNIT.Value = pNitSol
        End If
    End Sub

End Class