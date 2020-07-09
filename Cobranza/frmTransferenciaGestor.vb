Public Class frmTransferenciaGestor
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents txtCodNuevoGestor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCodActualGestor As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtNombreGestor As System.Windows.Forms.TextBox
    Friend WithEvents txtNota As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btGuardarTb3_1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtNombreNuevoGestor As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtNombreNuevoGestor = New System.Windows.Forms.TextBox()
        Me.txtNombreGestor = New System.Windows.Forms.TextBox()
        Me.txtCodNuevoGestor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCodActualGestor = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtNota = New System.Windows.Forms.TextBox()
        Me.btGuardarTb3_1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtNombreNuevoGestor
        '
        Me.txtNombreNuevoGestor.BackColor = System.Drawing.Color.White
        Me.txtNombreNuevoGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreNuevoGestor.Enabled = False
        Me.txtNombreNuevoGestor.Location = New System.Drawing.Point(217, 137)
        Me.txtNombreNuevoGestor.Name = "txtNombreNuevoGestor"
        Me.txtNombreNuevoGestor.ReadOnly = True
        Me.txtNombreNuevoGestor.Size = New System.Drawing.Size(362, 20)
        Me.txtNombreNuevoGestor.TabIndex = 95
        '
        'txtNombreGestor
        '
        Me.txtNombreGestor.BackColor = System.Drawing.Color.White
        Me.txtNombreGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreGestor.Enabled = False
        Me.txtNombreGestor.Location = New System.Drawing.Point(216, 111)
        Me.txtNombreGestor.Name = "txtNombreGestor"
        Me.txtNombreGestor.ReadOnly = True
        Me.txtNombreGestor.Size = New System.Drawing.Size(363, 20)
        Me.txtNombreGestor.TabIndex = 94
        '
        'txtCodNuevoGestor
        '
        Me.txtCodNuevoGestor.BackColor = System.Drawing.Color.White
        Me.txtCodNuevoGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodNuevoGestor.Location = New System.Drawing.Point(138, 137)
        Me.txtCodNuevoGestor.MaxLength = 20
        Me.txtCodNuevoGestor.Name = "txtCodNuevoGestor"
        Me.txtCodNuevoGestor.ReadOnly = True
        Me.txtCodNuevoGestor.Size = New System.Drawing.Size(73, 20)
        Me.txtCodNuevoGestor.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(20, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 28)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Seleccione el nuevo Gestor:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(138, 85)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(104, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(20, 85)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 15)
        Me.Label16.TabIndex = 90
        Me.Label16.Text = "Fecha Transferencia:"
        '
        'txtCodActualGestor
        '
        Me.txtCodActualGestor.BackColor = System.Drawing.Color.White
        Me.txtCodActualGestor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodActualGestor.Location = New System.Drawing.Point(139, 111)
        Me.txtCodActualGestor.MaxLength = 20
        Me.txtCodActualGestor.Name = "txtCodActualGestor"
        Me.txtCodActualGestor.ReadOnly = True
        Me.txtCodActualGestor.Size = New System.Drawing.Size(72, 20)
        Me.txtCodActualGestor.TabIndex = 1
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(20, 113)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 13)
        Me.Label18.TabIndex = 78
        Me.Label18.Text = "Gestor actual:"
        '
        'txtNota
        '
        Me.txtNota.BackColor = System.Drawing.Color.White
        Me.txtNota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNota.ForeColor = System.Drawing.Color.Teal
        Me.txtNota.Location = New System.Drawing.Point(23, 63)
        Me.txtNota.Multiline = True
        Me.txtNota.Name = "txtNota"
        Me.txtNota.Size = New System.Drawing.Size(556, 16)
        Me.txtNota.TabIndex = 23
        Me.txtNota.Text = "Se trasladará toda la cartera de créditos del gestor actual al gestor que se sele" &
    "cione."
        '
        'btGuardarTb3_1
        '
        Me.btGuardarTb3_1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.btGuardarTb3_1.Location = New System.Drawing.Point(504, 163)
        Me.btGuardarTb3_1.Name = "btGuardarTb3_1"
        Me.btGuardarTb3_1.Size = New System.Drawing.Size(75, 28)
        Me.btGuardarTb3_1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btGuardarTb3_1.TabIndex = 1026
        Me.btGuardarTb3_1.Text = "&Transferir"
        Me.btGuardarTb3_1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btGuardarTb3_1.UseSelectable = True
        Me.btGuardarTb3_1.UseStyleColors = True
        '
        'frmTransferenciaGestor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(602, 211)
        Me.Controls.Add(Me.txtNombreNuevoGestor)
        Me.Controls.Add(Me.btGuardarTb3_1)
        Me.Controls.Add(Me.txtCodNuevoGestor)
        Me.Controls.Add(Me.txtNombreGestor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtNota)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtCodActualGestor)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label18)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(602, 211)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(602, 211)
        Me.Name = "frmTransferenciaGestor"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Transferencia de Gestor de Créditos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub btnCerrarTb1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Dispose()
    End Sub

    Private Sub txtCodNuevoGestor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodNuevoGestor.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Gestores"
        Dim oCred As wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarGestores("*", "CodGestor<>'" & Me.txtCodActualGestor.Text.Trim & "'", "CodGestor", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodNuevoGestor.Text = ofrm.Resultado.Trim
            Me.txtNombreNuevoGestor.Text = ofrm.Resultado3.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Tipo Gestión - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodActualGestor_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodActualGestor.DoubleClick
        Dim ofrm As New frmAGenerico
        ofrm.Text = "Buscar Gestores"
        Dim oCred As wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarGestores("*", "CodGestor<>'" & Me.txtCodNuevoGestor.Text.Trim & "'", "CodGestor", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodActualGestor.Text = ofrm.Resultado.Trim
            Me.txtNombreGestor.Text = ofrm.Resultado3.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Tipo Gestión - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmTransferenciaGestor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha.Value = Now
    End Sub

    Private Sub txtCodNuevoGestor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodNuevoGestor.Validating
        Dim oCred As wrCredito.wsLibCred, ds As New Data.DataSet, Filas As DataRowCollection
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarGestores("*", "CodGestor = '" & Me.txtCodNuevoGestor.Text.Trim & "'", "CodGestor", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                Me.txtCodNuevoGestor.Text = IIf(IsDBNull(Filas.Item(0)("CodGestor")), "", Filas.Item(0)("CodGestor"))
                Me.txtNombreNuevoGestor.Text = IIf(IsDBNull(Filas.Item(0)("Nombre")), "", Filas.Item(0)("Nombre"))
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Gestores - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodActualGestor_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodActualGestor.Validating
        Dim oCred As wrCredito.wsLibCred, ds As New Data.DataSet, Filas As DataRowCollection
        Try
            oCred = New wrCredito.wsLibCred
            ds = oCred.ConsultarGestores("*", "CodGestor = '" & Me.txtCodActualGestor.Text.Trim & "'", "CodGestor", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then
                Me.txtCodActualGestor.Text = IIf(IsDBNull(Filas.Item(0)("CodGestor")), "", Filas.Item(0)("CodGestor"))
                Me.txtNombreGestor.Text = IIf(IsDBNull(Filas.Item(0)("Nombre")), "", Filas.Item(0)("Nombre"))
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Gestores - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btGuardarTb3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btGuardarTb3_1.Click
        Try
            Dim ofrmAut As New frmMsAutorizacion
            ofrmAut.TipoPermiso = "P"
            ofrmAut.NumPrograma = "CBD006"
            ofrmAut.ShowDialog()
            If ofrmAut.Autoriza = True Then
                Dim oCred As New wrCredito.wsLibCred, Campos As String, Valores As String, ds As New DataSet, dr As DataRow

                If Me.txtCodActualGestor.Text = "" Or Me.txtCodNuevoGestor.Text = "" Then
                    MsgBox("Existen campos que no pueden quedar vacíos para realizar esta operación", MsgBoxStyle.Information, "Módulo - Cobranza")
                Else

                    Campos = "CodGestor,CodPrestamo,Dui,FechaAsignacion,Estado"
                    ds = oCred.ConsultarGestoresxCredito("*", "CodGestor='" & Me.txtCodActualGestor.Text.Trim & "' and estado= 'A'", "FechaAsignacion", sUsuario, sPassword, sSucursal)
                    For Each dr In ds.Tables(0).Rows
                        Valores = "'" & Me.txtCodNuevoGestor.Text.Trim & "','" & dr("CodPrestamo") & "','" & dr("Dui") & "','" & Me.dtpFecha.Value.ToShortDateString & "','A'"
                        If oCred.ModificarGestoresxCredito("CodGestor='" & Me.txtCodActualGestor.Text.Trim & "' and CodPrestamo='" & dr("CodPrestamo") & "' and FechaAsignacion='" & dr("FechaAsignacion") & "'", "Estado ='H'", sUsuario, sPassword, sSucursal) = True Then
                            oCred.InsertarGestoresxCredito(Campos, Valores, sUsuario, sPassword, sSucursal)
                        End If
                    Next
                    MsgBox("La transferencia de la cartera de créditos al nuevo Gestor se ha realizado correctamente.", MsgBoxStyle.Information, "Módulo - Cobranza")
                    Me.Dispose()
                End If
                ofrmAut.Dispose()
            Else
                ofrmAut.Dispose()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class