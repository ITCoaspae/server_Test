Public Class frmRepAhAperturaCtas
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbItem As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.txtTipoAhorro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbItem = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpFecha1 = New System.Windows.Forms.DateTimePicker()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.chkTodos)
        Me.GroupBox1.Controls.Add(Me.txtCodTipoAhorro)
        Me.GroupBox1.Controls.Add(Me.txtTipoAhorro)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbItem)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtpFecha2)
        Me.GroupBox1.Controls.Add(Me.dtpFecha1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(449, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'chkTodos
        '
        Me.chkTodos.Location = New System.Drawing.Point(9, 96)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(200, 16)
        Me.chkTodos.TabIndex = 4
        Me.chkTodos.Text = "&Todos los tipos de ahorro"
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.AcceptsReturn = True
        Me.txtCodTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoAhorro.Enabled = False
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(104, 70)
        Me.txtCodTipoAhorro.MaxLength = 10
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(80, 20)
        Me.txtCodTipoAhorro.TabIndex = 3
        '
        'txtTipoAhorro
        '
        Me.txtTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoAhorro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoAhorro.Location = New System.Drawing.Point(190, 70)
        Me.txtTipoAhorro.MaxLength = 110
        Me.txtTipoAhorro.Name = "txtTipoAhorro"
        Me.txtTipoAhorro.ReadOnly = True
        Me.txtTipoAhorro.Size = New System.Drawing.Size(253, 20)
        Me.txtTipoAhorro.TabIndex = 129
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "Tipo de Ahorro:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 15)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Seleccione:"
        '
        'cbItem
        '
        Me.cbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbItem.Items.AddRange(New Object() {"Apertura de Depósitos de Ahorros", "Apertura de Depósitos a Plazo Fijo", "Apertura de Cuentas de Aportaciones"})
        Me.cbItem.Location = New System.Drawing.Point(104, 42)
        Me.cbItem.Name = "cbItem"
        Me.cbItem.Size = New System.Drawing.Size(339, 21)
        Me.cbItem.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Desde Fecha:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(261, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Hasta la Fecha:"
        '
        'dtpFecha2
        '
        Me.dtpFecha2.CustomFormat = ""
        Me.dtpFecha2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha2.Location = New System.Drawing.Point(355, 16)
        Me.dtpFecha2.Name = "dtpFecha2"
        Me.dtpFecha2.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha2.TabIndex = 1
        '
        'dtpFecha1
        '
        Me.dtpFecha1.CustomFormat = ""
        Me.dtpFecha1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha1.Location = New System.Drawing.Point(104, 16)
        Me.dtpFecha1.Name = "dtpFecha1"
        Me.dtpFecha1.Size = New System.Drawing.Size(88, 20)
        Me.dtpFecha1.TabIndex = 0
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(389, 190)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(83, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton1.TabIndex = 222
        Me.MetroButton1.Text = "Reporte"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'frmRepAhAperturaCtas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(495, 226)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRepAhAperturaCtas"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Reporte de Apertura de Cuentas de Ahorro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region



    Private Sub frmRepAhAperturaCtas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFecha1.Value = Now
        Me.dtpFecha2.Value = Now
    End Sub

    Private Sub txtCodTipoAhorro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoAhorro.DoubleClick

        Try
            Dim ofrm As New frmAGenerico, pFiltro As String
            Dim oAhorro As New wrAhorro.wsLibAhorro, ds As New Data.DataSet
            If Me.cbItem.SelectedIndex = 0 Then 'Ahorros
                pFiltro = "Left(CodTipoAhorro, 1) <> '1' and Left(CodTipoAhorro,1)<>'2'"
            ElseIf Me.cbItem.SelectedIndex = 0 Then 'DPF
                pFiltro = "Left(CodTipoAhorro, 1) = '2'"
            ElseIf Me.cbItem.SelectedIndex = 0 Then 'Aportación
                pFiltro = "Left(CodTipoAhorro, 1) = '1'"
            End If
            ds = oAhorro.ConsultarTipoAhorro("*", pFiltro, "CodTipoAhorro", sUsuario, sPassword, sSucursal)

            ofrm.Text = "Buscar Tipos de Ahorro"
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            txtCodTipoAhorro.Text = ofrm.Resultado.Trim
            If ofrm.Resultado.Trim = "" Then Exit Sub
            txtTipoAhorro.Text = ofrm.Resultado2.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Tipos de Ahorro - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub cbItem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbItem.SelectedIndexChanged
        If Me.cbItem.SelectedIndex = 0 Or Me.cbItem.SelectedIndex = 1 Then
            Me.txtCodTipoAhorro.Enabled = True
        Else
            Me.txtCodTipoAhorro.Enabled = False
        End If
    End Sub



    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Cursor = Cursors.WaitCursor

        If Me.cbItem.Text.Trim = "" Then
            MsgBox("Seleccione un elemento.", MsgBoxStyle.Information, "Validación del Sistema")
            Exit Sub
        End If

        Try
            'Dim pTipoReporte As AlcalaLibs.Ahorros.clsAhorro.TipoReporte, ds As New DataSet, vTodos As Boolean
            Dim pTipoReporte As sifLib.Ahorro.clsAhorros.TipoReporte, ds As New DataSet, vTodos As Boolean
            Dim oAh As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
            If Me.chkTodos.Checked = False Then
                vTodos = False
            Else
                vTodos = True
            End If
            If Me.cbItem.SelectedIndex = 0 Then
                'pTipoReporte = AlcalaLibs.Ahorros.clsAhorro.TipoReporte.AperturaAhorro
                'pTipoReporte = sifLib.Ahorro.clsAhorros.TipoReporte.AperturaAhorro
                'oAh.RepCtasAhorro(Me.dtpFecha1.Value, Me.dtpFecha2.Value, wrAhorro.TipoReporte.AperturaAhorro, Trim(Me.txtCodTipoAhorro.Text), vTodos, sUsuario, sPassword, sSucursal)
                ds = oAh.RepCtasAhorro(Me.dtpFecha1.Value, Me.dtpFecha2.Value, wrAhorro.TipoReporte.AperturaAhorro, Trim(Me.txtCodTipoAhorro.Text), vTodos, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 15, 0)
                ofrm.Text = "APERTURAS AHORROS"
                ofrm.ShowDialog()
            ElseIf Me.cbItem.SelectedIndex = 1 Then
                'pTipoReporte = AlcalaLibs.Ahorros.clsAhorro.TipoReporte.AperturaDeposito
                pTipoReporte = sifLib.Ahorro.clsAhorros.TipoReporte.AperturaDeposito
                ds = oAh.RepCtasAhorro(Me.dtpFecha1.Value, Me.dtpFecha2.Value, wrAhorro.TipoReporte.AperturaDeposito, Trim(Me.txtCodTipoAhorro.Text), vTodos, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 16, 0)
                ofrm.Text = "APERTURAS CERTIFICADOS DEPÓSITO A PLAZO FIJO"
                ofrm.ShowDialog()
            ElseIf Me.cbItem.SelectedIndex = 2 Then
                'pTipoReporte = AlcalaLibs.Ahorros.clsAhorro.TipoReporte.AperturaAportacion
                pTipoReporte = sifLib.Ahorro.clsAhorros.TipoReporte.AperturaAportacion
                ds = oAh.RepCtasAhorro(Me.dtpFecha1.Value, Me.dtpFecha2.Value, wrAhorro.TipoReporte.AperturaAportacion, Trim(Me.txtCodTipoAhorro.Text), vTodos, sUsuario, sPassword, sSucursal)
                Dim ofrm As New frmVisor(ds, 52, 0)
                ofrm.Text = "APERTURAS APORTACIONES"
                ofrm.ShowDialog()
            End If
            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show("No hay datos disponibles.", "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class