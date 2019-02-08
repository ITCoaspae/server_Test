Public Class frmMsAhFechasCap
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
    Friend WithEvents txtCodTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoAhorro As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents fgFechas As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btNProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsAhFechasCap))
        Me.txtCodTipoAhorro = New System.Windows.Forms.TextBox()
        Me.txtTipoAhorro = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fgFechas = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btNProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        CType(Me.fgFechas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodTipoAhorro
        '
        Me.txtCodTipoAhorro.AcceptsReturn = True
        Me.txtCodTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoAhorro.Location = New System.Drawing.Point(117, 58)
        Me.txtCodTipoAhorro.MaxLength = 10
        Me.txtCodTipoAhorro.Name = "txtCodTipoAhorro"
        Me.txtCodTipoAhorro.Size = New System.Drawing.Size(80, 20)
        Me.txtCodTipoAhorro.TabIndex = 128
        '
        'txtTipoAhorro
        '
        Me.txtTipoAhorro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoAhorro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoAhorro.Location = New System.Drawing.Point(203, 58)
        Me.txtTipoAhorro.MaxLength = 110
        Me.txtTipoAhorro.Name = "txtTipoAhorro"
        Me.txtTipoAhorro.ReadOnly = True
        Me.txtTipoAhorro.Size = New System.Drawing.Size(400, 20)
        Me.txtTipoAhorro.TabIndex = 129
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(23, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "Tipo de Ahorro:"
        '
        'fgFechas
        '
        Me.fgFechas.AllowEditing = False
        Me.fgFechas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgFechas.BackColor = System.Drawing.Color.White
        Me.fgFechas.ColumnInfo = "3,0,0,0,0,85,Columns:0{Width:26;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgFechas.Location = New System.Drawing.Point(23, 118)
        Me.fgFechas.Name = "fgFechas"
        Me.fgFechas.Rows.Count = 1
        Me.fgFechas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fgFechas.Size = New System.Drawing.Size(580, 165)
        Me.fgFechas.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgFechas.Styles"))
        Me.fgFechas.TabIndex = 132
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(23, 88)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 135
        Me.Label11.Text = "Mes:"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = ""
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(117, 84)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(324, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'btNProcesar1
        '
        Me.btNProcesar1.Location = New System.Drawing.Point(447, 84)
        Me.btNProcesar1.Name = "btNProcesar1"
        Me.btNProcesar1.Size = New System.Drawing.Size(75, 28)
        Me.btNProcesar1.Style = MetroFramework.MetroColorStyle.Green
        Me.btNProcesar1.TabIndex = 171
        Me.btNProcesar1.Text = "Agregar"
        Me.btNProcesar1.UseSelectable = True
        Me.btNProcesar1.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(528, 84)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroButton1.TabIndex = 172
        Me.MetroButton1.Text = "Eliminar"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'frmMsAhFechasCap
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(620, 306)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btNProcesar1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.fgFechas)
        Me.Controls.Add(Me.txtCodTipoAhorro)
        Me.Controls.Add(Me.txtTipoAhorro)
        Me.Controls.Add(Me.Label6)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhFechasCap"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Green
        Me.Text = "Fechas de Capitalización"
        CType(Me.fgFechas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Public pAccion As String, pCodigo As String

    Private Sub txtCodTipoAhorro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoAhorro.DoubleClick

        Dim ofrm As New frmAGenerico

        Try
            Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet
            ds = oAhorro.ConsultarTipoAhorro("*", "", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
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

    Private Sub txtCodTipoAhorro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodTipoAhorro.KeyPress
        Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet, Filas As Data.DataRowCollection
        Try
            If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
                If txtCodTipoAhorro.Text.Trim = "" Then
                    txtCodTipoAhorro_DoubleClick(sender, e)
                Else
                    ds = oAhorro.ConsultarTipoAhorro("*", "CodTipoAhorro='" & txtCodTipoAhorro.Text.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        txtCodTipoAhorro.Text = CStr(Filas.Item(0)("CodTipoAhorro")).Trim
                        txtTipoAhorro.Text = CStr(Filas.Item(0)("Descripcion")).Trim
                    Else
                        txtCodTipoAhorro_DoubleClick(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub frmMsAhFechasCap_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oAhorro As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection

        Try
            Me.dtpFecha.Value = Now

            If Me.pAccion = "Modificar" Then

                ds = oAhorro.ConsultarFechasCapitalizacion("*", "CodTipoAhorro='" & pCodigo.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                fgFechas.DataSource = ds.Tables(0)
                Encabezado()

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtCodTipoAhorro.Text = pCodigo
                    Me.txtCodTipoAhorro.Enabled = False
                    Me.dtpFecha.Value = IIf(IsDBNull(Filas.Item(0)("Fecha")), Now, Filas.Item(0)("Fecha"))
                    ds = oAhorro.ConsultarTipoAhorro("Descripcion", "CodTipoAhorro='" & Me.txtCodTipoAhorro.Text.Trim & "'", "CodTipoAhorro", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then Me.txtTipoAhorro.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                End If
                txtCodTipoAhorro.Focus()

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Encabezado()

        fgFechas.Cols.Item("Correlativo").Caption = "No."
        fgFechas.Cols.Item("CodTipoAhorro").Caption = "Tipo de Ahorro"
        fgFechas.Cols.Item("Fecha").Caption = "Fecha"

        fgFechas.Cols.Item("Correlativo").Width = 0
        fgFechas.Cols.Item("CodTipoAhorro").Width = 200
        fgFechas.Cols.Item("Fecha").Width = 200

    End Sub

    Private Sub btNProcesar1_Click(sender As Object, e As EventArgs) Handles btNProcesar1.Click

        Dim oAh As New wrAhorro.wsLibAhorro, pValores As String
        Try
            If Me.txtCodTipoAhorro.Text.Trim = "" Then Exit Sub

            If pAccion = "Agregar" Then

                pValores = "'" & Me.txtCodTipoAhorro.Text.Trim & "','" & Me.dtpFecha.Value.Date & "'"
                If oAh.InsertarFechasCapitalizacion("CodTipoAhorro,Fecha", pValores, sUsuario, sPassword, sSucursal) = True Then
                    fgFechas.DataSource = oAh.ConsultarFechasCapitalizacion("*", "CodTipoAhorro='" & Me.txtCodTipoAhorro.Text & "'", "Correlativo", sUsuario, sPassword, sSucursal).Tables(0)
                    Encabezado()
                Else
                    MsgBox("Los datos no han sido agregados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Ahorros")
                End If

            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            If fgFechas.Row <> -1 Then
                If MsgBox("¿Desea eliminar el registro seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Fechas de Capitalización") = MsgBoxResult.Yes Then
                    Dim oCred As wrAhorro.wsLibAhorro = New wrAhorro.wsLibAhorro
                    oCred.EliminarFechasCapitalizacion(fgFechas.Item(fgFechas.Row, "Correlativo"), sUsuario, sPassword, sSucursal)
                    fgFechas.DataSource = oCred.ConsultarFechasCapitalizacion("*", "CodTipoAhorro='" & Me.txtCodTipoAhorro.Text & "'", "Correlativo", sUsuario, sPassword, sSucursal).Tables(0)
                    Encabezado()
                End If
            End If
        Catch ex As Exception
            MsgBox("Error. Por favor comunicarse con el administrador de sistema.", MsgBoxStyle.Critical)
        End Try
    End Sub



End Class
