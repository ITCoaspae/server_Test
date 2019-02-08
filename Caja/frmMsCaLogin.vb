Public Class frmMsCaLogin
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager

    Private vPass As Boolean, vCodCajero As String, vCajero As String, vOrigen As String
    Friend WithEvents cbSucursales As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    '=======================================================
    'Modificación 04/10/2013
    'Javier Martinez
    Dim asociados As New wrAsociados.wsLibAsoc
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLogin1 As MetroFramework.Controls.MetroButton
    Dim bancos As New wrBancos.wsLibBancos

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtCajero As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtCajero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbSucursales = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogin1 = New MetroFramework.Controls.MetroButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 22)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 22)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Usuario:"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(18, 141)
        Me.txtPassword.MaxLength = 10
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(269, 26)
        Me.txtPassword.TabIndex = 2
        '
        'txtCajero
        '
        Me.txtCajero.BackColor = System.Drawing.Color.White
        Me.txtCajero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajero.Location = New System.Drawing.Point(18, 87)
        Me.txtCajero.MaxLength = 20
        Me.txtCajero.Name = "txtCajero"
        Me.txtCajero.Size = New System.Drawing.Size(271, 26)
        Me.txtCajero.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 18)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Sucusal:"
        '
        'cbSucursales
        '
        Me.cbSucursales.BackColor = System.Drawing.Color.White
        Me.cbSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSucursales.Enabled = False
        Me.cbSucursales.FormattingEnabled = True
        Me.cbSucursales.Location = New System.Drawing.Point(18, 33)
        Me.cbSucursales.Name = "cbSucursales"
        Me.cbSucursales.Size = New System.Drawing.Size(271, 24)
        Me.cbSucursales.TabIndex = 161
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.cbSucursales)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtCajero)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(28, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(298, 177)
        Me.Panel1.TabIndex = 162
        '
        'btnLogin1
        '
        Me.btnLogin1.Location = New System.Drawing.Point(236, 257)
        Me.btnLogin1.Name = "btnLogin1"
        Me.btnLogin1.Size = New System.Drawing.Size(90, 33)
        Me.btnLogin1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnLogin1.TabIndex = 162
        Me.btnLogin1.Text = "Ingresar"
        Me.btnLogin1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnLogin1.UseSelectable = True
        Me.btnLogin1.UseStyleColors = True
        '
        'frmMsCaLogin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(354, 310)
        Me.Controls.Add(Me.btnLogin1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsCaLogin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Inicio de sesión Caja"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Propiedades"
    Public Property Origen() As String
        Get
            Return vOrigen
        End Get
        Set(ByVal Value As String)
            vOrigen = Value
        End Set
    End Property

    Public Property Pass() As Boolean
        Get
            Return vPass
        End Get
        Set(ByVal Value As Boolean)
            vPass = Value
        End Set
    End Property

    Public Property CodCajero() As String
        Get
            Return vCodCajero
        End Get
        Set(ByVal Value As String)
            vCodCajero = Value
        End Set
    End Property

    Public Property Cajero() As String
        Get
            Return vCajero
        End Get
        Set(ByVal Value As String)
            vCajero = Value
        End Set
    End Property

#End Region
#Region "Eventos"

    Private Sub frmMsCaLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.cbSucursales.DisplayMember = "Nom_Sucursal"
            Me.cbSucursales.ValueMember = "CodSucursal"
            llenarCbSucursales(sSucursal)
        Catch ex As Exception
            MsgBox("Error, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo Caja")
        End Try
    End Sub
    Private Sub txtCodSuc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Me.txtCajero.Focus()
        End If
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnLogin1.Click
        Dim oItem As New wrCaja.wsLibCaja, ds As New DataSet, dsCaja As New DataSet
        Dim Filas As Data.DataRowCollection, oApp As New wrAdmin.wsLibAdmin
        Dim sucursalCajero As String
        Try
            ds = oItem.ConsultarCajerosPs("*", "Usuario='" & Me.txtCajero.Text.Trim & "' and Activo='1' and FechaIngreso<='" & oApp.Fecha.ToShortDateString & "' and FechaFinalizacion>='" & oApp.Fecha.ToShortDateString & "' and CodSucursal='" & Me.cbSucursales.SelectedValue.ToString.Trim & "'", Me.txtPassword.Text.Trim, "", sUsuario, sPassword, sSucursal)

            If ds Is Nothing Then
                vPass = False
                vCodCajero = ""
                vCajero = ""
                MessageBox.Show("El Usuario no existe o no está activo, verifíque.", "Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            If ds.Tables.Count = 0 Then
                vPass = False
                vCodCajero = ""
                vCajero = ""
                MessageBox.Show("El Usuario no existe o no está activo, verifíque.", "Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                vCodCajero = Filas.Item(0)("CodCajero")
                vCajero = Filas.Item(0)("Nombre")
                pCodCajero = vCodCajero
                sucursalCajero = Filas.Item(0)("codSucursal")

                dsCaja = oItem.ConsultarAperturaCaja("*", "FechaApertura='" & Date.Now.ToShortDateString & "' and CodCajero=" & vCodCajero & " and CajaCerrada<>'1'", "", sUsuario, sPassword, sSucursal)
                Filas = dsCaja.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If vOrigen = "A" Then
                        Dim frm As New frmCAFactura
                        frm.StartPosition = FormStartPosition.CenterScreen
                        frm.NoCaja = Filas.Item(0)("NoCaja")
                        pNocaja = Filas.Item(0)("NoCaja")
                        frm.Usuario = Me.txtCajero.Text.Trim
                        frm.CodCajero = vCodCajero
                        frm.Text = frm.Text & ", Cajero: " & Me.CodCajero & " - " & Me.Cajero
                        frm.ShowDialog()
                        Me.Hide()
                    ElseIf vOrigen = "C" Then
                        Dim frm As New frmMChequesBoveda
                        frm.StartPosition = FormStartPosition.CenterScreen
                        frm.cajero = vCodCajero
                        ' frm.noCaja = Filas.Item(0)("NoCaja")
                        frm.ShowDialog()
                        Me.Hide()
                    End If
                    vPass = True
                    Me.Dispose()
                Else
                    If vOrigen = "A" Then
                        Dim dtsSolicitud As New DataSet
                        dtsSolicitud = bancos.ConsultarBcSolicitudes_Boveda(sUsuario,
                                                                            Format(Now, "short date"), sSucursal,
                                                                            "", pCodCajero, pNocaja, 4, sUsuario,
                                                                            sPassword, sSucursal)
                        If dtsSolicitud.Tables.Count > 0 Then
                            If dtsSolicitud.Tables(0).Rows.Count > 0 Then
                                Dim ofrm1 As New frmMB_SolicitudesBoveda
                                Me.Hide()
                                With ofrm1
                                    .ShowDialog()
                                End With
                                Me.Close()

                            Else
                                Dim frm As New frmMsBc_SolicitudesBoveda
                                With frm
                                    .tipoUsuario = 1
                                    .lblCajero.Text = vCajero
                                    .MaximumSize = New Size(471, 204)
                                    .btnAutorizar.Visible = False
                                    .btnDenegar.Visible = False
                                    .codCajero = vCodCajero
                                    .codSuc = sucursalCajero
                                    .cajero = vCajero
                                    .usuario = Me.txtCajero.Text.Trim
                                    .ShowDialog()
                                End With
                            End If

                        End If

                        Me.Dispose()

                    ElseIf vOrigen = "C" Then
                        Dim frm As New frmMChequesBoveda
                            frm.StartPosition = FormStartPosition.CenterScreen
                            frm.cajero = vCodCajero
                        ' frm.noCaja = Filas.Item(0)("NoCaja")
                        frm.ShowDialog()
                            Me.Hide()

                    End If
                End If
            Else
                vPass = False
                vCodCajero = ""
                vCajero = ""
                MessageBox.Show("El Usuario no existe o no está activo, verifíque.", "Apertura de Caja", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Dispose()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnGuardar1_Click(sender, e)
        End If
    End Sub
    Private Sub txtCajero_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCajero.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Me.txtPassword.Focus()
        End If
    End Sub
#End Region
#Region "Metodos"
    Protected Sub llenarCbSucursales(ByVal codSucursal As String)
        Dim dts As New DataSet
        dts = asociados.ConsultarSucursales("CodSucursal,Nom_Sucursal", "codSucursal= '" & codSucursal & "'", "", sUsuario, sPassword, codSucursal)
        If dts.Tables.Count > 0 Then
            If dts.Tables(0).Rows.Count > 0 Then
                Me.cbSucursales.DataSource = dts.Tables(0)
            End If
        End If
    End Sub
#End Region
#Region "Funciones"

#End Region
#Region "Codigo eliminado"
    '================================================================================
    '================================================================================
    'Codigo eliminado
    '04/10/2013
    'Javier Martinez
    'Private Sub txtCodSuc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Dim ofrm As New frmAGenerico

    '    ofrm.Text = "Buscar Sucursales"
    '    Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
    '    Try
    '        ds = oPerif.ConsultarSucursales("*", "", "CodSucursal", sUsuario, sPassword, sSucursal)
    '        ofrm.Datos = ds
    '        ofrm.ColSeleccion = 0
    '        ofrm.RefrescarGrid()
    '        ofrm.ShowDialog()
    '        Me.txtCodSuc.Text = ofrm.Resultado.Trim
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    '================================================================================
    '================================================================================
#End Region


End Class
