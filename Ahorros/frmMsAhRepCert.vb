Public Class frmMsAhRepCert
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Dim ahorro As New wrAhorro.wsLibAhorro
    Dim asociado As New wrAsociados.wsLibAsoc
    Dim idSolicitud As Integer

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
    Friend WithEvents cbCausa As System.Windows.Forms.ComboBox
    Friend WithEvents txtNuevoNoCertificado As System.Windows.Forms.TextBox
    Friend WithEvents dtpFechaSolicitud As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtObsPI As System.Windows.Forms.TextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnSaveTb4 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtObsPI = New System.Windows.Forms.TextBox()
        Me.cbCausa = New System.Windows.Forms.ComboBox()
        Me.txtNuevoNoCertificado = New System.Windows.Forms.TextBox()
        Me.dtpFechaSolicitud = New System.Windows.Forms.DateTimePicker()
        Me.btnSaveTb4 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.SuspendLayout()
        '
        'txtObsPI
        '
        Me.txtObsPI.Location = New System.Drawing.Point(159, 164)
        Me.txtObsPI.Multiline = True
        Me.txtObsPI.Name = "txtObsPI"
        Me.txtObsPI.Size = New System.Drawing.Size(421, 115)
        Me.txtObsPI.TabIndex = 13
        '
        'cbCausa
        '
        Me.cbCausa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCausa.Items.AddRange(New Object() {"Reposición por Deterioro", "Reposición por Pérdida"})
        Me.cbCausa.Location = New System.Drawing.Point(159, 134)
        Me.cbCausa.Name = "cbCausa"
        Me.cbCausa.Size = New System.Drawing.Size(421, 24)
        Me.cbCausa.TabIndex = 3
        '
        'txtNuevoNoCertificado
        '
        Me.txtNuevoNoCertificado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNuevoNoCertificado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNuevoNoCertificado.Location = New System.Drawing.Point(159, 103)
        Me.txtNuevoNoCertificado.MaxLength = 20
        Me.txtNuevoNoCertificado.Name = "txtNuevoNoCertificado"
        Me.txtNuevoNoCertificado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNuevoNoCertificado.Size = New System.Drawing.Size(421, 25)
        Me.txtNuevoNoCertificado.TabIndex = 2
        '
        'dtpFechaSolicitud
        '
        Me.dtpFechaSolicitud.Enabled = False
        Me.dtpFechaSolicitud.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSolicitud.Location = New System.Drawing.Point(159, 72)
        Me.dtpFechaSolicitud.Name = "dtpFechaSolicitud"
        Me.dtpFechaSolicitud.Size = New System.Drawing.Size(421, 23)
        Me.dtpFechaSolicitud.TabIndex = 1
        Me.dtpFechaSolicitud.Value = New Date(2018, 11, 8, 0, 0, 0, 0)
        '
        'btnSaveTb4
        '
        Me.btnSaveTb4.Location = New System.Drawing.Point(490, 286)
        Me.btnSaveTb4.Name = "btnSaveTb4"
        Me.btnSaveTb4.Size = New System.Drawing.Size(90, 32)
        Me.btnSaveTb4.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSaveTb4.TabIndex = 219
        Me.btnSaveTb4.Text = "&Guardar"
        Me.btnSaveTb4.UseSelectable = True
        Me.btnSaveTb4.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(26, 74)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(120, 20)
        Me.MetroLabel1.TabIndex = 220
        Me.MetroLabel1.Text = "Fecha Reposición:"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(26, 103)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(125, 20)
        Me.MetroLabel2.TabIndex = 221
        Me.MetroLabel2.Text = "Nuevo Certificado:"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(26, 134)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(49, 20)
        Me.MetroLabel3.TabIndex = 222
        Me.MetroLabel3.Text = "Causa:"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(26, 164)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(91, 20)
        Me.MetroLabel4.TabIndex = 223
        Me.MetroLabel4.Text = "Observacion:"
        '
        'frmMsAhRepCert
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(598, 337)
        Me.Controls.Add(Me.MetroLabel4)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Controls.Add(Me.btnSaveTb4)
        Me.Controls.Add(Me.txtObsPI)
        Me.Controls.Add(Me.dtpFechaSolicitud)
        Me.Controls.Add(Me.txtNuevoNoCertificado)
        Me.Controls.Add(Me.cbCausa)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhRepCert"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Reposición de Certificados DPF"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public pNoCuenta As String, pCodTipoAhorro As String, pNoCertificado As String, pAccion As String, pCorrelativo As String
    Protected Function generarIdSolicitud() As Integer
        Try
            Dim dts As New DataSet
            Dim idSolicitud
            dts = ahorro.ConsultarReposicionCertificadosDPF("max(noSolicitud)", " estado = 'P'", "", sUsuario, sPassword, sSucursal)
            idSolicitud = CInt(dts.Tables(0).Rows(0).Item(0)) + 1
            Return idSolicitud
        Catch ex As Exception

        End Try


    End Function
    Private Sub btnSaveTb4_Click(sender As Object, e As EventArgs) Handles btnSaveTb4.Click
        Try


            If (MetroFramework.MetroMessageBox.Show(Me, "Desea ralizar esta acción, este proceso reemplazara el no. de certiciado", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

                If ahorro.ingresarReposicionCertificadoPlazo(pNoCuenta, txtNuevoNoCertificado.Text.Trim, pNoCertificado, Now.ToShortDateString, cbCausa.SelectedValue, txtObsPI.Text.Trim, sUsuario) > 0 Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)

                Else
                    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                End If
                Me.Close()
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
    Protected Friend Sub llenarCausaRetiro()
        Dim dts As New DataSet
        Me.cbCausa.DisplayMember = "Descripcion"
        Me.cbCausa.ValueMember = "idCatalogo"
        dts = asociado.consultarDbCatalogosCatalogos(0, wrAsociados.tipoCatalogo.motivosRepCertificadoDPF,
                                                      wrAsociados.tipoConsultaCatalogos.detalleCatalogo)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbCausa.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
    Private Sub frmMsAhRepCert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.dtpFechaSolicitud.Value = Now

        ' Me.btnRepDPF.Enabled = False

        Dim ds As New Data.DataSet, objRow As Data.DataRow, vPorcent As Double

        Dim Filas As Data.DataRowCollection

        Try
            llenarCausaRetiro()
            cbCausa.SelectedIndex = 0


            If Me.btnSaveTb4.Text = "&Modificar" Then

                ds = ahorro.ConsultarReposicionCertificadosDPF("*", "NoSolicitud='" & pCorrelativo & "'", "NoSolicitud", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    idSolicitud = IIf(IsDBNull(Filas.Item(0)("NoSolicitud")), "", Filas.Item(0)("NoSolicitud"))
                    dtpFechaSolicitud.Value = IIf(IsDBNull(Filas.Item(0)("FechaSolicitud")), Now, Filas.Item(0)("FechaSolicitud"))
                    txtNuevoNoCertificado.Text = IIf(IsDBNull(Filas.Item(0)("IdCertificadoDPF")), "", Filas.Item(0)("IdCertificadoDPF"))
                    cbCausa.SelectedValue = IIf(IsDBNull(Filas.Item(0)("Causa")), 0, Filas.Item(0)("Causa"))
                    txtObsPI.Text = IIf(IsDBNull(Filas.Item(0)("Observacion")), "", Filas.Item(0)("Observacion"))
                    dtpFechaSolicitud.Enabled = False
                    txtNuevoNoCertificado.Enabled = False
                    cbCausa.Enabled = False
                    txtObsPI.Enabled = False

                End If

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmMsAhRepCert_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub




End Class
