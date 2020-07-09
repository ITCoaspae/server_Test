Public Class frmMsCajeros
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
    Friend WithEvents gbDatDoc As System.Windows.Forms.GroupBox
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents la As System.Windows.Forms.Label
    Friend WithEvents txtCodCajero As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtCodSuc As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.gbDatDoc = New System.Windows.Forms.GroupBox()
        Me.txtCodSuc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtCodEmpleado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.la = New System.Windows.Forms.Label()
        Me.txtCodCajero = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.gbDatDoc.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatDoc
        '
        Me.gbDatDoc.BackColor = System.Drawing.Color.White
        Me.gbDatDoc.Controls.Add(Me.txtCodSuc)
        Me.gbDatDoc.Controls.Add(Me.Label2)
        Me.gbDatDoc.Controls.Add(Me.chkActivo)
        Me.gbDatDoc.Controls.Add(Me.Label21)
        Me.gbDatDoc.Controls.Add(Me.Label22)
        Me.gbDatDoc.Controls.Add(Me.dtpFin)
        Me.gbDatDoc.Controls.Add(Me.dtpInicio)
        Me.gbDatDoc.Controls.Add(Me.txtCodEmpleado)
        Me.gbDatDoc.Controls.Add(Me.Label1)
        Me.gbDatDoc.Controls.Add(Me.txtUsuario)
        Me.gbDatDoc.Controls.Add(Me.txtContraseña)
        Me.gbDatDoc.Controls.Add(Me.Label15)
        Me.gbDatDoc.Controls.Add(Me.Label31)
        Me.gbDatDoc.Controls.Add(Me.txtNombre)
        Me.gbDatDoc.Controls.Add(Me.la)
        Me.gbDatDoc.Controls.Add(Me.txtCodCajero)
        Me.gbDatDoc.Controls.Add(Me.Label10)
        Me.gbDatDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatDoc.ForeColor = System.Drawing.Color.Navy
        Me.gbDatDoc.Location = New System.Drawing.Point(23, 63)
        Me.gbDatDoc.Name = "gbDatDoc"
        Me.gbDatDoc.Size = New System.Drawing.Size(536, 154)
        Me.gbDatDoc.TabIndex = 0
        Me.gbDatDoc.TabStop = False
        '
        'txtCodSuc
        '
        Me.txtCodSuc.BackColor = System.Drawing.Color.White
        Me.txtCodSuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodSuc.Location = New System.Drawing.Point(373, 14)
        Me.txtCodSuc.MaxLength = 10
        Me.txtCodSuc.Name = "txtCodSuc"
        Me.txtCodSuc.Size = New System.Drawing.Size(157, 20)
        Me.txtCodSuc.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(281, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Cód. Agencia:"
        '
        'chkActivo
        '
        Me.chkActivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkActivo.ForeColor = System.Drawing.Color.Black
        Me.chkActivo.Location = New System.Drawing.Point(284, 42)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(64, 16)
        Me.chkActivo.TabIndex = 6
        Me.chkActivo.Text = "&Activo"
        Me.chkActivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(281, 118)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 31)
        Me.Label21.TabIndex = 136
        Me.Label21.Text = "Fecha de Finalización:"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(8, 123)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 16)
        Me.Label22.TabIndex = 135
        Me.Label22.Text = "Fecha de Ingreso:"
        '
        'dtpFin
        '
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(373, 118)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(157, 20)
        Me.dtpFin.TabIndex = 5
        '
        'dtpInicio
        '
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(110, 118)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(157, 20)
        Me.dtpInicio.TabIndex = 4
        '
        'txtCodEmpleado
        '
        Me.txtCodEmpleado.BackColor = System.Drawing.Color.White
        Me.txtCodEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodEmpleado.Location = New System.Drawing.Point(110, 14)
        Me.txtCodEmpleado.MaxLength = 5
        Me.txtCodEmpleado.Name = "txtCodEmpleado"
        Me.txtCodEmpleado.Size = New System.Drawing.Size(157, 20)
        Me.txtCodEmpleado.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 132
        Me.Label1.Text = "Cód. Empleado:"
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Location = New System.Drawing.Point(110, 92)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(157, 20)
        Me.txtUsuario.TabIndex = 2
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.White
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContraseña.Location = New System.Drawing.Point(373, 92)
        Me.txtContraseña.MaxLength = 10
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(157, 20)
        Me.txtContraseña.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(281, 92)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 16)
        Me.Label15.TabIndex = 130
        Me.Label15.Text = "Contraseña:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(8, 100)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 16)
        Me.Label31.TabIndex = 126
        Me.Label31.Text = "Usuario:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Location = New System.Drawing.Point(110, 66)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(420, 20)
        Me.txtNombre.TabIndex = 5
        '
        'la
        '
        Me.la.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.la.ForeColor = System.Drawing.Color.Black
        Me.la.Location = New System.Drawing.Point(8, 66)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(88, 16)
        Me.la.TabIndex = 113
        Me.la.Text = "Nombre:"
        Me.la.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCodCajero
        '
        Me.txtCodCajero.BackColor = System.Drawing.Color.White
        Me.txtCodCajero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodCajero.Location = New System.Drawing.Point(110, 40)
        Me.txtCodCajero.MaxLength = 10
        Me.txtCodCajero.Name = "txtCodCajero"
        Me.txtCodCajero.Size = New System.Drawing.Size(80, 20)
        Me.txtCodCajero.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(8, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Código Cajero"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(487, 223)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 155
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCajeros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(585, 293)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.gbDatDoc)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(585, 293)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(585, 293)
        Me.Name = "frmMsCajeros"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cajeros"
        Me.gbDatDoc.ResumeLayout(False)
        Me.gbDatDoc.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub txtCodEmpleado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodEmpleado.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Empleados"
        Dim oPl As New wrPlanilla.wsLibPlanilla, ds As New Data.DataSet
        Try
            ds = oPl.ConsultarEmpleados("*", "", "CodEmpleado", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodEmpleado.Text = ofrm.Resultado.Trim
            Me.txtNombre.Text = ofrm.Resultado5.Trim & " " & ofrm.Resultado4.Trim & " " & ofrm.Resultado2.Trim & " " & ofrm.Resultado3.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Empleados - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsCajeros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.btnGuardar1.Text = "&Guardar" Then
            Me.dtpInicio.Value = Now
            Me.dtpFin.Value = Now
        End If
    End Sub



    Private Sub txtCodSuc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodSuc.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Sucursales"
        Dim oPerif As wrAsociados.wsLibAsoc = New wrAsociados.wsLibAsoc, ds As New Data.DataSet
        Try
            ds = oPerif.ConsultarSucursales("*", "", "CodSucursal", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodSuc.Text = ofrm.Resultado.Trim
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim oItem As New wrCaja.wsLibCaja
        Try
            If Me.btnGuardar1.Text = "&Guardar" Then
                If oItem.InsertarCajeros(Trim(Me.txtNombre.Text), Trim(Me.txtCodEmpleado.Text), Trim(Me.txtUsuario.Text), Format(Me.dtpInicio.Value, "dd/MM/yyyy"), Format(Me.dtpFin.Value, "dd/MM/yyyy"), IIf(Me.chkActivo.Checked = True, 1, 0), Me.txtCodSuc.Text.Trim, Trim(Me.txtContraseña.Text), sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MessageBox.Show("Los datos no fueron ingresados.")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                If oItem.ModificarCajeros(Trim(Me.txtNombre.Text), Trim(Me.txtCodEmpleado.Text), Trim(Me.txtUsuario.Text), Format(Me.dtpInicio.Value, "dd/MM/yyyy"), Format(Me.dtpFin.Value, "dd/MM/yyyy"), IIf(Me.chkActivo.Checked = True, 1, 0), Me.txtCodSuc.Text.Trim, Trim(Me.txtContraseña.Text), Val(Me.txtCodCajero.Text), sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MessageBox.Show("Los datos no fueron modificados.")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub gbDatDoc_Enter(sender As Object, e As EventArgs) Handles gbDatDoc.Enter

    End Sub
End Class