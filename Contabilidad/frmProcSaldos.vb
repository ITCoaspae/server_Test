Public Class frmProcSaldos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents cbCosto As ComboBox
    Dim contabilidad As New wrConta.wsLibContab

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
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnProcesar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents dgCtas As MetroFramework.Controls.MetroGrid
    Friend WithEvents Label1 As Label
    Friend WithEvents chkMostar As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.chkMostar = New System.Windows.Forms.CheckBox()
        Me.btnProcesar1 = New MetroFramework.Controls.MetroButton()
        Me.dgCtas = New MetroFramework.Controls.MetroGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbCosto = New System.Windows.Forms.ComboBox()
        CType(Me.dgCtas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 19)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Seleccione Mes a Procesar"
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "MMMM/yyyy"
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(223, 69)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(298, 26)
        Me.dtpFecha.TabIndex = 31
        '
        'chkMostar
        '
        Me.chkMostar.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkMostar.Checked = True
        Me.chkMostar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMostar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMostar.Location = New System.Drawing.Point(26, 131)
        Me.chkMostar.Name = "chkMostar"
        Me.chkMostar.Size = New System.Drawing.Size(201, 18)
        Me.chkMostar.TabIndex = 32
        Me.chkMostar.Text = "No mostrar Saldos a Cero"
        '
        'btnProcesar1
        '
        Me.btnProcesar1.Location = New System.Drawing.Point(431, 131)
        Me.btnProcesar1.Name = "btnProcesar1"
        Me.btnProcesar1.Size = New System.Drawing.Size(90, 28)
        Me.btnProcesar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnProcesar1.TabIndex = 33
        Me.btnProcesar1.Text = "Procesar"
        Me.btnProcesar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnProcesar1.UseSelectable = True
        Me.btnProcesar1.UseStyleColors = True
        '
        'dgCtas
        '
        Me.dgCtas.AllowUserToAddRows = False
        Me.dgCtas.AllowUserToDeleteRows = False
        Me.dgCtas.AllowUserToResizeRows = False
        Me.dgCtas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCtas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgCtas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgCtas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCtas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgCtas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgCtas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCtas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgCtas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgCtas.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgCtas.EnableHeadersVisualStyles = False
        Me.dgCtas.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgCtas.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgCtas.Location = New System.Drawing.Point(31, 176)
        Me.dgCtas.Name = "dgCtas"
        Me.dgCtas.ReadOnly = True
        Me.dgCtas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgCtas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgCtas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgCtas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCtas.ShowCellToolTips = False
        Me.dgCtas.Size = New System.Drawing.Size(494, 190)
        Me.dgCtas.Style = MetroFramework.MetroColorStyle.Teal
        Me.dgCtas.TabIndex = 34
        Me.dgCtas.Theme = MetroFramework.MetroThemeStyle.Light
        Me.dgCtas.UseCustomBackColor = True
        Me.dgCtas.UseCustomForeColor = True
        Me.dgCtas.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 19)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Centro de Costos"
        '
        'cbCosto
        '
        Me.cbCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCosto.FormattingEnabled = True
        Me.cbCosto.Location = New System.Drawing.Point(223, 101)
        Me.cbCosto.Name = "cbCosto"
        Me.cbCosto.Size = New System.Drawing.Size(298, 24)
        Me.cbCosto.TabIndex = 173
        '
        'frmProcSaldos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(548, 476)
        Me.Controls.Add(Me.cbCosto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgCtas)
        Me.Controls.Add(Me.btnProcesar1)
        Me.Controls.Add(Me.chkMostar)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label2)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(548, 448)
        Me.Name = "frmProcSaldos"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Procesar Saldos"
        CType(Me.dgCtas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Dim obj As New wrConta.wsLibContab, ds As DataSet, sCampos As String, sMes As String, sSaldoA As String
        Try
            If obj.ProcesarSaldosNuevo(dtpFecha.Value.Month, dtpFecha.Value.Year, cbCosto.SelectedValue) Then
                MessageBox.Show("Proceso Completado con éxito", "Proceso Contable", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                obj = New wrConta.wsLibContab
                Select Case dtpFecha.Value.Month
                    Case Is = 1
                        sMes = "Enero"
                        sSaldoA = "Saldo_Anterior"
                    Case Is = 2
                        sMes = "Febrero"
                        sSaldoA = "SEnero"
                    Case Is = 3
                        sMes = "Marzo"
                        sSaldoA = "SFebrero"
                    Case Is = 4
                        sMes = "Abril"
                        sSaldoA = "SMarzo"
                    Case Is = 5
                        sMes = "Mayo"
                        sSaldoA = "SAbril"
                    Case Is = 6
                        sMes = "Junio"
                        sSaldoA = "SMayo"
                    Case Is = 7
                        sMes = "Julio"
                        sSaldoA = "SJunio"
                    Case Is = 8
                        sMes = "Agosto"
                        sSaldoA = "SJulio"
                    Case Is = 9
                        sMes = "Septiembre"
                        sSaldoA = "SAgosto"
                    Case Is = 10
                        sMes = "Octubre"
                        sSaldoA = "SSeptiembre"
                    Case Is = 11
                        sMes = "Noviembre"
                        sSaldoA = "SOctubre"
                    Case Is = 12
                        sMes = "Diciembre"
                        sSaldoA = "SNoviembre"

                End Select
                sCampos = "Saldos.IdCuenta,Descripcion," & sSaldoA & " as Saldo_Anterior,C" & sMes & " as Cargos,A" & sMes & " as Abonos,S" & sMes & " as Saldo"
                If Me.chkMostar.Checked = True Then
                    ds = obj.ConsultaSaldos(sCampos, "(" & sSaldoA & "<>0 or C" & sMes & "<>0 or A" & sMes & "<>0 or S" & sMes & "<>0) and Annio=" & dtpFecha.Value.Year & "", "Saldos.IdCuenta", sUsuario, sPassword, sSucursal)
                Else
                    ds = obj.ConsultaSaldos(sCampos, "Annio=" & dtpFecha.Value.Year & "", "Saldos.IdCuenta", sUsuario, sPassword, sSucursal)
                End If

                Me.dgCtas.DataSource = ds.Tables("Saldos")
                'C1fgrdDetalle.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                'C1fgrdDetalle.DataSource = ds.Tables("Saldos")
                'C1fgrdDetalle.Cols(0).Width = 5
                'C1fgrdDetalle.Cols(1).Width = 50
                'C1fgrdDetalle.Cols(2).Width = 300
            Else
                MessageBox.Show("El Proceso no se ha completado correctamente.", "Proceso Contable", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "SIF_ERP", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

    'Private Sub txtNombCosto_DoubleClick(sender As Object, e As EventArgs) Handles txtNombCosto.DoubleClick
    '    Dim frm As New frmAGenerico
    '    Dim campos As String ', var As Integer, corrDic As Integer
    '    'Dim dr As DataRow, 
    '    Dim ds As New Data.DataSet
    '    Dim oAh As wrAhorro.wsLibAhorro, oConta As wrConta.wsLibContab
    '    Dim oCred As wrCredito.wsLibCred

    '    Try
    '        oAh = New wrAhorro.wsLibAhorro
    '        oCred = New wrCredito.wsLibCred
    '        oConta = New wrConta.wsLibContab

    '        campos = "Cod_CCosto,Descripcion, Tipo_Cuenta, Comentario"
    '        ds = oConta.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, campos, "", "Cod_CCosto", sUsuario, sPassword, sSucursal)
    '        frm.Text = "Buscar Centro de Costos"
    '        frm.Datos = ds
    '        frm.ColSeleccion = 0
    '        frm.RefrescarGrid()
    '        frm.ShowDialog()
    '        If frm.Resultado.Trim <> "" Then
    '            Me.txtNombCosto.Text = IIf(IsDBNull(frm.Resultado2.Trim), "", frm.Resultado2.Trim)
    '            txtCodCosto.Text = IIf(IsDBNull(frm.Resultado.Trim), "", frm.Resultado.Trim)
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Error en la recuperación de datos - " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub llenarCentroCosto()
        Dim dts As New DataSet
        dts = contabilidad.ObtenerCatCostos(wrConta.TipoCatalogo.Costos, "Descripcion,Cod_CCosto", "", "Descripcion", sUsuario, sPassword, sSucursal)
        If dts.Tables(0).Rows.Count > 0 Then
            Me.cbCosto.DisplayMember = "Descripcion"
            Me.cbCosto.ValueMember = "Cod_CCosto"
            Me.cbCosto.DataSource = dts.Tables(0)
        End If
    End Sub
    Private Sub frmProcSaldos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCentroCosto()
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
