Public Class frmRepColocacionCredito
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btProcesar1 As MetroFramework.Controls.MetroButton
    Public NumReporte As Integer

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
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents txtTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkGarantia As System.Windows.Forms.CheckBox
    Friend WithEvents txtTipoGarantia As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoGarantia As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkGarantia = New System.Windows.Forms.CheckBox()
        Me.txtTipoGarantia = New System.Windows.Forms.TextBox()
        Me.txtCodTipoGarantia = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.txtTipoCredito = New System.Windows.Forms.TextBox()
        Me.txtCodTipoCredito = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.chkGarantia)
        Me.GroupBox1.Controls.Add(Me.txtTipoGarantia)
        Me.GroupBox1.Controls.Add(Me.txtCodTipoGarantia)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.chkTodos)
        Me.GroupBox1.Controls.Add(Me.txtTipoCredito)
        Me.GroupBox1.Controls.Add(Me.txtCodTipoCredito)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(386, 151)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chkGarantia
        '
        Me.chkGarantia.Checked = True
        Me.chkGarantia.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGarantia.Location = New System.Drawing.Point(216, 85)
        Me.chkGarantia.Name = "chkGarantia"
        Me.chkGarantia.Size = New System.Drawing.Size(160, 24)
        Me.chkGarantia.TabIndex = 4
        Me.chkGarantia.Text = "&Todos los tipos de garantía"
        Me.chkGarantia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTipoGarantia
        '
        Me.txtTipoGarantia.BackColor = System.Drawing.Color.White
        Me.txtTipoGarantia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoGarantia.Enabled = False
        Me.txtTipoGarantia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoGarantia.Location = New System.Drawing.Point(88, 111)
        Me.txtTipoGarantia.MaxLength = 100
        Me.txtTipoGarantia.Name = "txtTipoGarantia"
        Me.txtTipoGarantia.ReadOnly = True
        Me.txtTipoGarantia.Size = New System.Drawing.Size(288, 20)
        Me.txtTipoGarantia.TabIndex = 141
        '
        'txtCodTipoGarantia
        '
        Me.txtCodTipoGarantia.BackColor = System.Drawing.Color.White
        Me.txtCodTipoGarantia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoGarantia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTipoGarantia.Location = New System.Drawing.Point(8, 111)
        Me.txtCodTipoGarantia.MaxLength = 10
        Me.txtCodTipoGarantia.Name = "txtCodTipoGarantia"
        Me.txtCodTipoGarantia.ReadOnly = True
        Me.txtCodTipoGarantia.Size = New System.Drawing.Size(72, 20)
        Me.txtCodTipoGarantia.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 16)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Tipo de Garantía:"
        '
        'chkTodos
        '
        Me.chkTodos.Checked = True
        Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTodos.Location = New System.Drawing.Point(216, 40)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(160, 16)
        Me.chkTodos.TabIndex = 2
        Me.chkTodos.Text = "&Todos los tipos de crédito"
        Me.chkTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTipoCredito
        '
        Me.txtTipoCredito.BackColor = System.Drawing.Color.White
        Me.txtTipoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCredito.Enabled = False
        Me.txtTipoCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCredito.Location = New System.Drawing.Point(88, 56)
        Me.txtTipoCredito.MaxLength = 100
        Me.txtTipoCredito.Name = "txtTipoCredito"
        Me.txtTipoCredito.ReadOnly = True
        Me.txtTipoCredito.Size = New System.Drawing.Size(288, 20)
        Me.txtTipoCredito.TabIndex = 137
        '
        'txtCodTipoCredito
        '
        Me.txtCodTipoCredito.BackColor = System.Drawing.Color.White
        Me.txtCodTipoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTipoCredito.Location = New System.Drawing.Point(8, 56)
        Me.txtCodTipoCredito.MaxLength = 10
        Me.txtCodTipoCredito.Name = "txtCodTipoCredito"
        Me.txtCodTipoCredito.ReadOnly = True
        Me.txtCodTipoCredito.Size = New System.Drawing.Size(72, 20)
        Me.txtCodTipoCredito.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 16)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "Tipo de Crédito:"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(264, 16)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(112, 20)
        Me.dtpFechaFin.TabIndex = 1
        Me.dtpFechaFin.Value = New Date(2006, 12, 19, 16, 42, 14, 734)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(192, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Fecha Fin:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(80, 16)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(106, 20)
        Me.dtpFechaInicio.TabIndex = 0
        Me.dtpFechaInicio.Value = New Date(2006, 12, 19, 16, 42, 14, 734)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fecha Inicio:"
        '
        'btProcesar1
        '
        Me.btProcesar1.Location = New System.Drawing.Point(334, 220)
        Me.btProcesar1.Name = "btProcesar1"
        Me.btProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btProcesar1.TabIndex = 171
        Me.btProcesar1.Text = "Procesar"
        Me.btProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btProcesar1.UseSelectable = True
        Me.btProcesar1.UseStyleColors = True
        '
        'frmRepColocacionCredito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(432, 277)
        Me.Controls.Add(Me.btProcesar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(432, 277)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(432, 277)
        Me.Name = "frmRepColocacionCredito"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Colocación de Créditos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmRepColocacionCredito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFechaInicio.Value = Now
        Me.dtpFechaFin.Value = Now
        'If NumReporte = "1" Then
        '    Me.GroupBox1.Size = New Size(384, 168)
        '    Me.Size = New Size(408, 232)
        '    Me.btProcesar1.Location = New Point(88, 172)
        '    'Me.btnCerrar.Location = New Point(208, 172)
        'Else
        '    Me.GroupBox1.Size = New Size(384, 85)
        '    Me.Size = New Size(408, 168)
        '    Me.btProcesar1.Location = New Point(88, 108)
        '    'Me.btnCerrar.Location = New Point(208, 108)
        'End If
    End Sub

    Private Sub txtCodTipoCredito_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoCredito.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Tipo de Crédito"
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarTipoCreditos("*", "", "CodTipoCredito", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodTipoCredito.Text = ofrm.Resultado.Trim
            txtTipoCredito.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        txtCodTipoCredito.ReadOnly = chkTodos.Checked
    End Sub

    Private Sub chkGarantia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGarantia.CheckedChanged
        Me.txtCodTipoGarantia.ReadOnly = Me.chkGarantia.Checked
    End Sub

    Private Sub txtCodTipoGarantia_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoGarantia.DoubleClick
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Tipos de Garantía"
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
        Try
            oPerif = New wrCredito.wsLibCred
            ds = oPerif.ConsultarTipGarant("*", "", "CodTipoGarantias", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodTipoGarantia.Text = ofrm.Resultado.Trim
            Me.txtTipoGarantia.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCodTipoGarantia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodTipoGarantia.KeyPress
        Dim oPerif As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Try
            If e.KeyChar = Convert.ToChar(Keys.Enter) Then
                oPerif = New wrCredito.wsLibCred
                ds = oPerif.ConsultarTipGarant("*", "CodTipoGarantias='" & Trim(Me.txtCodTipoGarantia.Text) & "'", "CodTipoGarantias", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    If Not (Filas.Item(0)("Descripcion") Is DBNull.Value) Then
                        Me.txtTipoGarantia.Text = CStr(Filas.Item(0)("Descripcion"))
                    End If
                Else
                    txtCodTipoGarantia_DoubleClick(sender, e)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btProcesar1_Click(sender As Object, e As EventArgs) Handles btProcesar1.Click
        Try
            If NumReporte = 1 Then
                Dim ds As New Data.DataSet
                Dim oItem As New wrPrestamo.wsLibPrest
                Dim pAceptada As Boolean = False
                Dim crColCred As New crRepColocacionCredito
                ds = oItem.ReporteColocacionCreditos(Me.dtpFechaInicio.Value.ToShortDateString, Me.dtpFechaFin.Value.ToShortDateString, Me.chkTodos.Checked, Me.txtCodTipoCredito.Text.Trim, Me.chkGarantia.Checked, Me.txtCodTipoGarantia.Text.Trim, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 46, 0)
                ofrm.ShowDialog()
            ElseIf NumReporte = 2 Then 'PRÉSTAMOS POR PLAZO
                Dim ds As New Data.DataSet, oPrest As New wrPrestamo.wsLibPrest
                ds = oPrest.Prestamos_Agrupados(Me.dtpFechaInicio.Value.ToShortDateString, Me.dtpFechaFin.Value.ToShortDateString, 1, Me.chkTodos.Checked, Me.txtCodTipoCredito.Text.Trim, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 22, 0)
                ofrm.ShowDialog()
            ElseIf NumReporte = 3 Then 'PRÉSTAMOS POR INTERÉS
                Dim ds As New Data.DataSet, oPrest As New wrPrestamo.wsLibPrest
                ds = oPrest.Prestamos_Agrupados(Me.dtpFechaInicio.Value.ToShortDateString, Me.dtpFechaFin.Value.ToShortDateString, 2, Me.chkTodos.Checked, Me.txtCodTipoCredito.Text.Trim, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 9, 0)
                ofrm.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class