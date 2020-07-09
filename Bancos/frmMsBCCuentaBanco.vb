Public Class frmMsBCCuentaBanco
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
    Friend WithEvents ttipAsoc As System.Windows.Forms.ToolTip
    Friend WithEvents gbDatDoc As GroupBox
    Friend WithEvents txtCorrCheque As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCuentaContable As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFecApertura As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCodCuenta As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreCuenta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombreBanco As TextBox
    Friend WithEvents txtCodBanco As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ttipAsoc = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.gbDatDoc = New System.Windows.Forms.GroupBox()
        Me.txtCorrCheque = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCuentaContable = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecApertura = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodCuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreCuenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombreBanco = New System.Windows.Forms.TextBox()
        Me.txtCodBanco = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.gbDatDoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(416, 279)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 51
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'gbDatDoc
        '
        Me.gbDatDoc.BackColor = System.Drawing.Color.White
        Me.gbDatDoc.Controls.Add(Me.txtCorrCheque)
        Me.gbDatDoc.Controls.Add(Me.Label5)
        Me.gbDatDoc.Controls.Add(Me.txtCuentaContable)
        Me.gbDatDoc.Controls.Add(Me.Label4)
        Me.gbDatDoc.Controls.Add(Me.dtpFecApertura)
        Me.gbDatDoc.Controls.Add(Me.Label6)
        Me.gbDatDoc.Controls.Add(Me.txtCodCuenta)
        Me.gbDatDoc.Controls.Add(Me.Label1)
        Me.gbDatDoc.Controls.Add(Me.txtNombreCuenta)
        Me.gbDatDoc.Controls.Add(Me.Label3)
        Me.gbDatDoc.Controls.Add(Me.txtNombreBanco)
        Me.gbDatDoc.Controls.Add(Me.txtCodBanco)
        Me.gbDatDoc.Controls.Add(Me.Label2)
        Me.gbDatDoc.Controls.Add(Me.Label31)
        Me.gbDatDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatDoc.ForeColor = System.Drawing.Color.Teal
        Me.gbDatDoc.Location = New System.Drawing.Point(23, 63)
        Me.gbDatDoc.Name = "gbDatDoc"
        Me.gbDatDoc.Size = New System.Drawing.Size(472, 210)
        Me.gbDatDoc.TabIndex = 47
        Me.gbDatDoc.TabStop = False
        Me.gbDatDoc.Text = "Datos Generales de la Cuenta"
        '
        'txtCorrCheque
        '
        Me.txtCorrCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorrCheque.Location = New System.Drawing.Point(144, 170)
        Me.txtCorrCheque.MaxLength = 20
        Me.txtCorrCheque.Name = "txtCorrCheque"
        Me.txtCorrCheque.Size = New System.Drawing.Size(120, 20)
        Me.txtCorrCheque.TabIndex = 149
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(24, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 20)
        Me.Label5.TabIndex = 148
        Me.Label5.Text = "Correlativo Cheque:"
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaContable.Location = New System.Drawing.Point(144, 144)
        Me.txtCuentaContable.MaxLength = 20
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.Size = New System.Drawing.Size(120, 20)
        Me.txtCuentaContable.TabIndex = 147
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(24, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 146
        Me.Label4.Text = "Cuenta Contable:"
        '
        'dtpFecApertura
        '
        Me.dtpFecApertura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecApertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecApertura.Location = New System.Drawing.Point(144, 120)
        Me.dtpFecApertura.Name = "dtpFecApertura"
        Me.dtpFecApertura.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecApertura.TabIndex = 144
        Me.dtpFecApertura.Value = New Date(2004, 9, 9, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(24, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 145
        Me.Label6.Text = "Fecha Apertura:"
        '
        'txtCodCuenta
        '
        Me.txtCodCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCuenta.Location = New System.Drawing.Point(144, 72)
        Me.txtCodCuenta.MaxLength = 25
        Me.txtCodCuenta.Name = "txtCodCuenta"
        Me.txtCodCuenta.Size = New System.Drawing.Size(120, 20)
        Me.txtCodCuenta.TabIndex = 143
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Código Cuenta:"
        '
        'txtNombreCuenta
        '
        Me.txtNombreCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCuenta.Location = New System.Drawing.Point(144, 96)
        Me.txtNombreCuenta.MaxLength = 100
        Me.txtNombreCuenta.Name = "txtNombreCuenta"
        Me.txtNombreCuenta.Size = New System.Drawing.Size(312, 20)
        Me.txtNombreCuenta.TabIndex = 141
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Nombre de la Cuenta:"
        '
        'txtNombreBanco
        '
        Me.txtNombreBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreBanco.Location = New System.Drawing.Point(144, 48)
        Me.txtNombreBanco.MaxLength = 100
        Me.txtNombreBanco.Name = "txtNombreBanco"
        Me.txtNombreBanco.ReadOnly = True
        Me.txtNombreBanco.Size = New System.Drawing.Size(312, 20)
        Me.txtNombreBanco.TabIndex = 133
        '
        'txtCodBanco
        '
        Me.txtCodBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodBanco.Location = New System.Drawing.Point(144, 24)
        Me.txtCodBanco.MaxLength = 20
        Me.txtCodBanco.Name = "txtCodBanco"
        Me.txtCodBanco.Size = New System.Drawing.Size(120, 20)
        Me.txtCodBanco.TabIndex = 115
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(24, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Nombre del Banco:"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(24, 26)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(96, 16)
        Me.Label31.TabIndex = 79
        Me.Label31.Text = "Código Banco:"
        '
        'frmMsBCCuentaBanco
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(514, 314)
        Me.Controls.Add(Me.gbDatDoc)
        Me.Controls.Add(Me.btnGuardar1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(514, 314)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(514, 314)
        Me.Name = "frmMsBCCuentaBanco"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Detalle de Información Cuenta Bancaria"
        Me.gbDatDoc.ResumeLayout(False)
        Me.gbDatDoc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Declaraciones"
    'Private vAccion As Seguridad.clsUsuario.TipoAccion
    Private vAccion As sifLib.Seguridad.clsUsuario.TipoAccion
#End Region

#Region "Propiedades"
    'Public Property Accion() As Seguridad.clsUsuario.TipoAccion
    Public Property Accion() As sifLib.Seguridad.clsUsuario.TipoAccion
        Get
            Return vAccion
        End Get
        'Set(ByVal Value As Seguridad.clsUsuario.TipoAccion)
        Set(ByVal Value As sifLib.Seguridad.clsUsuario.TipoAccion)
            vAccion = Value
        End Set
    End Property
#End Region

#Region "Métodos"

#Region "Métodos de Navegación"


#End Region

#End Region

    Private Sub txtCodBanco_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodBanco.DoubleClick
        Try
            Dim ofrm As New frmAGenerico
            ofrm.Text = "Buscar Banco"
            Dim oPerif As wrBancos.wsLibBancos, ds As New Data.DataSet

            oPerif = New wrBancos.wsLibBancos
            ds = oPerif.ObtenerBanco("*", "", "idBanco", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodBanco.Text = ofrm.Resultado.Trim
            Me.txtNombreBanco.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCuentaContable_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuentaContable.DoubleClick
        Try
            Dim ofrm As New frmAGenerico
            ofrm.Text = "Buscar Cuenta Contable"
            Dim oPerif As wrConta.wsLibContab, ds As New Data.DataSet
            oPerif = New wrConta.wsLibContab
            ds = oPerif.ObtenerCatContab("*", "Final='S'", "idCuenta", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCuentaContable.Text = ofrm.Resultado.Trim
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsBCCuentaBanco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecApertura.Value = Date.Now
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oLibBco As New wrBancos.wsLibBancos
            'If Me.Accion = Seguridad.clsUsuario.TipoAccion.Insertar Then
            If Me.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Insertar Then
                If oLibBco.InsertaCuentaBanco("IdCtaBanco,IdCuenta,IdBanco,Nom_Cuenta,Fec_Apertura,corr_cheque", "'" & Me.txtCodCuenta.Text & "','" & Me.txtCuentaContable.Text & "','" & Me.txtCodBanco.Text & "','" & Me.txtNombreCuenta.Text & "','" & Me.dtpFecApertura.Value.ToShortDateString & "', '" & txtCorrCheque.Text & "'", sUsuario, sPassword, sSucursal) Then
                    MessageBox.Show("Cuenta Bancaria Agregada al Sistema", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show("Cuenta Bancaria NO Agregada al Sistema", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
                'ElseIf Me.Accion = Seguridad.clsUsuario.TipoAccion.Modificar Then
            ElseIf Me.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Modificar Then
                If oLibBco.ModificaCuentaBanco(Me.txtCodCuenta.Text.Trim, "IdCuenta='" & Me.txtCuentaContable.Text & "',IdBanco='" & Me.txtCodBanco.Text & "',Nom_Cuenta='" & Me.txtNombreCuenta.Text & "',Fec_Apertura='" & Me.dtpFecApertura.Value.ToShortDateString & "', corr_cheque='" & txtCorrCheque.Text & "' ", sUsuario, sPassword, sSucursal) Then
                    MessageBox.Show("Cuenta Bancaria Modificada en Sistema", "Modificación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show("Cuenta Bancaria NO Modificada en el Sistema", "Modificación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsBCCuentaBanco_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub
End Class
