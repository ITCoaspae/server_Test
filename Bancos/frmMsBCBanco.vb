Public Class frmMsBCBanco
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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents gbDatDoc As System.Windows.Forms.GroupBox
    Friend WithEvents ttipAsoc As System.Windows.Forms.ToolTip
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtCodBanco As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreBanco As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtDirWeb As System.Windows.Forms.TextBox
    Friend WithEvents txtEjecutivo As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTel1 As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtTel2 As C1.Win.C1Input.C1TextBox
    Friend WithEvents btnSaveTb2 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtFax As C1.Win.C1Input.C1TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnSaveTb2 = New MetroFramework.Controls.MetroButton()
        Me.gbDatDoc = New System.Windows.Forms.GroupBox()
        Me.txtFax = New C1.Win.C1Input.C1TextBox()
        Me.txtTel2 = New C1.Win.C1Input.C1TextBox()
        Me.txtTel1 = New C1.Win.C1Input.C1TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDirWeb = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEjecutivo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNombreBanco = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtCodBanco = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.ttipAsoc = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbDatDoc.SuspendLayout()
        CType(Me.txtFax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaveTb2
        '
        Me.btnSaveTb2.Location = New System.Drawing.Point(542, 293)
        Me.btnSaveTb2.Name = "btnSaveTb2"
        Me.btnSaveTb2.Size = New System.Drawing.Size(75, 28)
        Me.btnSaveTb2.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnSaveTb2.TabIndex = 48
        Me.btnSaveTb2.Text = "Guardar"
        Me.btnSaveTb2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnSaveTb2.UseSelectable = True
        Me.btnSaveTb2.UseStyleColors = True
        '
        'gbDatDoc
        '
        Me.gbDatDoc.BackColor = System.Drawing.Color.White
        Me.gbDatDoc.Controls.Add(Me.txtFax)
        Me.gbDatDoc.Controls.Add(Me.txtTel2)
        Me.gbDatDoc.Controls.Add(Me.txtTel1)
        Me.gbDatDoc.Controls.Add(Me.txtEmail)
        Me.gbDatDoc.Controls.Add(Me.Label5)
        Me.gbDatDoc.Controls.Add(Me.txtDirWeb)
        Me.gbDatDoc.Controls.Add(Me.Label1)
        Me.gbDatDoc.Controls.Add(Me.txtEjecutivo)
        Me.gbDatDoc.Controls.Add(Me.Label3)
        Me.gbDatDoc.Controls.Add(Me.Label4)
        Me.gbDatDoc.Controls.Add(Me.Label15)
        Me.gbDatDoc.Controls.Add(Me.Label14)
        Me.gbDatDoc.Controls.Add(Me.txtNombreBanco)
        Me.gbDatDoc.Controls.Add(Me.txtDireccion)
        Me.gbDatDoc.Controls.Add(Me.Label35)
        Me.gbDatDoc.Controls.Add(Me.txtCodBanco)
        Me.gbDatDoc.Controls.Add(Me.Label2)
        Me.gbDatDoc.Controls.Add(Me.Label31)
        Me.gbDatDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatDoc.ForeColor = System.Drawing.Color.Teal
        Me.gbDatDoc.Location = New System.Drawing.Point(23, 63)
        Me.gbDatDoc.Name = "gbDatDoc"
        Me.gbDatDoc.Size = New System.Drawing.Size(594, 224)
        Me.gbDatDoc.TabIndex = 47
        Me.gbDatDoc.TabStop = False
        Me.gbDatDoc.Text = "Datos Generales del Banco"
        '
        'txtFax
        '
        Me.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFax.EditMask = "0000-0000"
        Me.txtFax.Location = New System.Drawing.Point(144, 120)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.NumericInput = False
        Me.txtFax.Size = New System.Drawing.Size(160, 20)
        Me.txtFax.TabIndex = 147
        Me.txtFax.Tag = Nothing
        '
        'txtTel2
        '
        Me.txtTel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTel2.EditMask = "0000-0000"
        Me.txtTel2.Location = New System.Drawing.Point(424, 96)
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.NumericInput = False
        Me.txtTel2.Size = New System.Drawing.Size(160, 20)
        Me.txtTel2.TabIndex = 146
        Me.txtTel2.Tag = Nothing
        '
        'txtTel1
        '
        Me.txtTel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTel1.EditMask = "0000-0000"
        Me.txtTel1.Location = New System.Drawing.Point(144, 96)
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.NumericInput = False
        Me.txtTel1.Size = New System.Drawing.Size(160, 20)
        Me.txtTel1.TabIndex = 145
        Me.txtTel1.Tag = Nothing
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(144, 192)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(312, 20)
        Me.txtEmail.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(24, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 16)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "Correos Electronicos:"
        '
        'txtDirWeb
        '
        Me.txtDirWeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDirWeb.Location = New System.Drawing.Point(144, 168)
        Me.txtDirWeb.MaxLength = 100
        Me.txtDirWeb.Name = "txtDirWeb"
        Me.txtDirWeb.Size = New System.Drawing.Size(312, 20)
        Me.txtDirWeb.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(24, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Dirección WEB:"
        '
        'txtEjecutivo
        '
        Me.txtEjecutivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEjecutivo.Location = New System.Drawing.Point(144, 144)
        Me.txtEjecutivo.MaxLength = 100
        Me.txtEjecutivo.Name = "txtEjecutivo"
        Me.txtEjecutivo.Size = New System.Drawing.Size(312, 20)
        Me.txtEjecutivo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(24, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 16)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Ejecutivo de Cuenta:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(24, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Fax:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(328, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 16)
        Me.Label15.TabIndex = 137
        Me.Label15.Text = "Teléfono 2:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(24, 98)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 16)
        Me.Label14.TabIndex = 136
        Me.Label14.Text = "Teléfono 1:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombreBanco
        '
        Me.txtNombreBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreBanco.Location = New System.Drawing.Point(144, 48)
        Me.txtNombreBanco.MaxLength = 100
        Me.txtNombreBanco.Name = "txtNombreBanco"
        Me.txtNombreBanco.Size = New System.Drawing.Size(312, 20)
        Me.txtNombreBanco.TabIndex = 2
        '
        'txtDireccion
        '
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Location = New System.Drawing.Point(144, 72)
        Me.txtDireccion.MaxLength = 255
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(440, 20)
        Me.txtDireccion.TabIndex = 3
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(24, 74)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(64, 16)
        Me.Label35.TabIndex = 128
        Me.Label35.Text = "Dirección:"
        '
        'txtCodBanco
        '
        Me.txtCodBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodBanco.Location = New System.Drawing.Point(144, 24)
        Me.txtCodBanco.MaxLength = 8
        Me.txtCodBanco.Name = "txtCodBanco"
        Me.txtCodBanco.ReadOnly = True
        Me.txtCodBanco.Size = New System.Drawing.Size(120, 20)
        Me.txtCodBanco.TabIndex = 1
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
        'frmMsBCBanco
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(632, 331)
        Me.Controls.Add(Me.btnSaveTb2)
        Me.Controls.Add(Me.gbDatDoc)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(632, 331)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(632, 331)
        Me.Name = "frmMsBCBanco"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Detalle de Información Banco"
        Me.gbDatDoc.ResumeLayout(False)
        Me.gbDatDoc.PerformLayout()
        CType(Me.txtFax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Declaraciones"
    'Private vAccion As AlcalaLibs.Seguridad.clsUsuario.TipoAccion
    Private vAccion As sifLib.Seguridad.clsUsuario.TipoAccion

#End Region

#Region "Propiedades"
    'Public Property Accion() As AlcalaLibs.Seguridad.clsUsuario.TipoAccion
    Public Property Accion() As sifLib.Seguridad.clsUsuario.TipoAccion
        Get
            Return vAccion
        End Get
        'Set(ByVal Value As AlcalaLibs.Seguridad.clsUsuario.TipoAccion)
        Set(ByVal Value As sifLib.Seguridad.clsUsuario.TipoAccion)
            vAccion = Value
        End Set
    End Property
#End Region

#Region "Métodos"

#Region "Métodos de Navegación"



#End Region


#End Region

    Private Sub frmMsBCBanco_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'If Me.Accion = AlcalaLibs.Seguridad.clsUsuario.TipoAccion.Insertar Then
        If Me.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Insertar Then

        End If
    End Sub

    Private Sub btnSaveTb2_Click(sender As Object, e As EventArgs) Handles btnSaveTb2.Click
        Try
            Dim oLibBco As New wrBancos.wsLibBancos
            'If Me.Accion = AlcalaLibs.Seguridad.clsUsuario.TipoAccion.Insertar Then
            If Me.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Insertar Then
                If oLibBco.InsertaBanco("Nom_Banco,Direccion,Telefono1,Telefono2,Fax,Nom_Ejecutivo,Dir_Web,EMail", "'" & Me.txtNombreBanco.Text & "','" & Me.txtDireccion.Text & "','" & Me.txtTel1.Text & "','" & Me.txtTel2.Text & "','" & Me.txtFax.Text & "','" & Me.txtEjecutivo.Text & "','" & Me.txtDirWeb.Text & "','" & Me.txtEmail.Text & "'", sUsuario, sPassword, sSucursal) Then
                    MessageBox.Show("Banco Agregado al Sistema", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                    Me.Dispose()
                Else
                    MessageBox.Show("Banco NO Agregado al Sistema", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
                'ElseIf Me.Accion = AlcalaLibs.Seguridad.clsUsuario.TipoAccion.Modificar Then
            ElseIf Me.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Modificar Then
                If oLibBco.ModificaBanco(Me.txtCodBanco.Text.Trim, "Nom_Banco='" & Me.txtNombreBanco.Text & "',Direccion='" & Me.txtDireccion.Text & "',Telefono1='" & Me.txtTel1.Text & "',Telefono2='" & Me.txtTel2.Text & "',Fax='" & Me.txtFax.Text & "',Nom_Ejecutivo='" & Me.txtEjecutivo.Text & "',Dir_Web='" & Me.txtDirWeb.Text & "',EMail='" & Me.txtEmail.Text & "'", sUsuario, sPassword, sSucursal) Then
                    MessageBox.Show("Banco Modificado en Sistema", "Modificación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show("Banco NO Modificado en el Sistema", "Modificación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
