Public Class frmMsAhCancelaCuenta
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Dim vNoCuenta As String, vCodTipoAhorro As String, vAutorizado As Boolean, vCodCajero As String, vNoCaja As String
    Public vCUsuario As String, vCPassword As String, vAplicaAut As Boolean
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents gbCancela As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecCanc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtEjecMercadeoCanc As System.Windows.Forms.TextBox
    Friend WithEvents txtCodEjecCanc As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMotivoCancela As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gbCancela = New System.Windows.Forms.GroupBox()
        Me.dtpFecCanc = New System.Windows.Forms.DateTimePicker()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtEjecMercadeoCanc = New System.Windows.Forms.TextBox()
        Me.txtCodEjecCanc = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMotivoCancela = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.gbCancela.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbCancela
        '
        Me.gbCancela.BackColor = System.Drawing.Color.White
        Me.gbCancela.Controls.Add(Me.dtpFecCanc)
        Me.gbCancela.Controls.Add(Me.Label30)
        Me.gbCancela.Controls.Add(Me.txtEjecMercadeoCanc)
        Me.gbCancela.Controls.Add(Me.txtCodEjecCanc)
        Me.gbCancela.Controls.Add(Me.Label13)
        Me.gbCancela.Controls.Add(Me.txtMotivoCancela)
        Me.gbCancela.Controls.Add(Me.Label45)
        Me.gbCancela.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCancela.ForeColor = System.Drawing.Color.Green
        Me.gbCancela.Location = New System.Drawing.Point(23, 63)
        Me.gbCancela.Name = "gbCancela"
        Me.gbCancela.Size = New System.Drawing.Size(592, 136)
        Me.gbCancela.TabIndex = 0
        Me.gbCancela.TabStop = False
        Me.gbCancela.Text = "Cancelación de Cuenta"
        '
        'dtpFecCanc
        '
        Me.dtpFecCanc.Enabled = False
        Me.dtpFecCanc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecCanc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCanc.Location = New System.Drawing.Point(152, 24)
        Me.dtpFecCanc.Name = "dtpFecCanc"
        Me.dtpFecCanc.Size = New System.Drawing.Size(84, 20)
        Me.dtpFecCanc.TabIndex = 0
        Me.dtpFecCanc.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(16, 96)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 16)
        Me.Label30.TabIndex = 176
        Me.Label30.Text = "Código Ejecutivo:"
        '
        'txtEjecMercadeoCanc
        '
        Me.txtEjecMercadeoCanc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEjecMercadeoCanc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEjecMercadeoCanc.Location = New System.Drawing.Point(224, 96)
        Me.txtEjecMercadeoCanc.MaxLength = 100
        Me.txtEjecMercadeoCanc.Name = "txtEjecMercadeoCanc"
        Me.txtEjecMercadeoCanc.ReadOnly = True
        Me.txtEjecMercadeoCanc.Size = New System.Drawing.Size(344, 20)
        Me.txtEjecMercadeoCanc.TabIndex = 3
        '
        'txtCodEjecCanc
        '
        Me.txtCodEjecCanc.AcceptsReturn = True
        Me.txtCodEjecCanc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEjecCanc.Location = New System.Drawing.Point(152, 96)
        Me.txtCodEjecCanc.MaxLength = 10
        Me.txtCodEjecCanc.Name = "txtCodEjecCanc"
        Me.txtCodEjecCanc.Size = New System.Drawing.Size(64, 20)
        Me.txtCodEjecCanc.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(16, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 16)
        Me.Label13.TabIndex = 173
        Me.Label13.Text = "Fecha de Cancelación:"
        '
        'txtMotivoCancela
        '
        Me.txtMotivoCancela.AcceptsReturn = True
        Me.txtMotivoCancela.Location = New System.Drawing.Point(152, 56)
        Me.txtMotivoCancela.Multiline = True
        Me.txtMotivoCancela.Name = "txtMotivoCancela"
        Me.txtMotivoCancela.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivoCancela.Size = New System.Drawing.Size(416, 32)
        Me.txtMotivoCancela.TabIndex = 1
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(16, 56)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(128, 16)
        Me.Label45.TabIndex = 172
        Me.Label45.Text = "Motivo de Cancelación:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(540, 205)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Green
        Me.btnGuardar1.TabIndex = 196
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsAhCancelaCuenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(634, 262)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.gbCancela)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(634, 262)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(634, 262)
        Me.Name = "frmMsAhCancelaCuenta"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Cancelación de Cuenta"
        Me.gbCancela.ResumeLayout(False)
        Me.gbCancela.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Propiedades"

    Public Property NoCaja() As String
        Get
            Return vNoCaja
        End Get
        Set(ByVal Value As String)
            vNoCaja = Value
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

    Public Property Autorizado() As Boolean
        Get
            Return vAutorizado
        End Get
        Set(ByVal Value As Boolean)
            vAutorizado = Value
        End Set
    End Property

    Public Property NoCuenta() As String
        Get
            Return vNoCuenta
        End Get
        Set(ByVal Value As String)
            vNoCuenta = Value
        End Set
    End Property

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click

        Try
            If vAplicaAut = True Then
                Dim ofrmAut As New frmMsAutorizacion
                ofrmAut.TipoPermiso = "P"
                ofrmAut.NumPrograma = "AHG015"
                ofrmAut.ShowDialog()
                If ofrmAut.Autoriza = True Then
                    Dim oCred As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, vResponse As String, oApp As New wrAdmin.wsLibAdmin
                    vResponse = oCred.CancelarCuentaAhorro(vNoCuenta, vCodTipoAhorro, Me.txtMotivoCancela.Text.Trim, Me.txtCodEjecCanc.Text.Trim, Me.vNoCaja, Me.vCodCajero, Me.dtpFecCanc.Value, vCUsuario, vCPassword, sSucursal)
                    If vResponse.Trim = "" Then
                        vAutorizado = True
                        Me.Dispose()
                    Else
                        vAutorizado = False
                        MsgBox(vResponse, MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                    End If
                    ofrmAut.Autoriza = False
                    ofrmAut.Dispose()
                Else
                    ofrmAut.Dispose()
                End If
            Else
                Dim oCred As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, vResponse As String, oApp As New wrAdmin.wsLibAdmin
                vResponse = oCred.CancelarCuentaAhorro(vNoCuenta, vCodTipoAhorro, Me.txtMotivoCancela.Text.Trim, Me.txtCodEjecCanc.Text.Trim, Me.vNoCaja, Me.vCodCajero, Me.dtpFecCanc.Value, vCUsuario, vCPassword, sSucursal)
                If vResponse.Trim = "" Then
                    vAutorizado = True
                    Me.Dispose()
                Else
                    vAutorizado = False
                    MsgBox(vResponse, MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Property CodTipoAhorro() As String
        Get
            Return vCodTipoAhorro
        End Get
        Set(ByVal Value As String)
            vCodTipoAhorro = Value
        End Set
    End Property

#End Region

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub


    Private Sub txtCodEjecCanc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEjecCanc.DoubleClick
        Dim ofrm As New frmAGenerico, ds As New Data.DataSet
        ofrm.Text = "Buscar Ejecutivos de Mercadeo"
        Try
            Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc
            oPerif = New wrAsociados.wsLibAsoc
            ds = oPerif.ConsultarEjecutivosMercadeoxNombre("", sUsuario, sPassword,sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodEjecCanc.Text = ofrm.Resultado.Trim
            txtEjecMercadeoCanc.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub txtCodEjecCanc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodEjecCanc.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Try
                Dim oPl As New wrPlanilla.wsLibPlanilla
                Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet, Filas As Data.DataRowCollection
                oPerif = New wrAsociados.wsLibAsoc
                ds = oPerif.ConsultarEjecutivosMercadeo("*", "CodEjecMercadeo='" & Trim(Me.txtCodEjecCanc.Text) & "'", "CodEjecMercadeo", sUsuario, sPassword,sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("CodEmpleado") Is DBNull.Value) Then
                        Me.txtEjecMercadeoCanc.Text = CStr(Filas.Item(0)("CodEmpleado"))
                        ds = oPl.ConsultarEmpleados("*", "CodEmpleado='" & Trim(Me.txtEjecMercadeoCanc.Text) & "'", "CodEmpleado", sUsuario, sPassword,sSucursal)
                        Filas = ds.Tables(0).Rows()
                        If Filas.Count > 0 Then
                            Me.txtEjecMercadeoCanc.Text = IIf(IsDBNull(Filas.Item(0)("Nombres")), "", Filas.Item(0)("Nombres")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido1")), "", Filas.Item(0)("Apellido1")) & " " & IIf(IsDBNull(Filas.Item(0)("Apellido2")), "", Filas.Item(0)("Apellido2"))
                        End If
                    End If
                Else
                    txtCodEjecCanc_DoubleClick(sender, e)
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub frmMsAhCancelaCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oApp As New wrAdmin.wsLibAdmin
        Me.dtpFecCanc.Value = oApp.Fecha
    End Sub

End Class
