Public Class frmMsCrEncDescuentos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    'Private vTipoDeduccion As AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion, vAccion As String
    Private vTipoDeduccion As sifLib.Prestamos.clsPrestamos.TipoDeduccion, vAccion As String
    Friend WithEvents dgDeducciones As System.Windows.Forms.DataGridView
    Dim Credito As New wrCredito.wsLibCred
    Dim Caja As New wrCaja.wsLibCaja
    Friend WithEvents btEdit1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDel1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNew1 As MetroFramework.Controls.MetroButton
    Dim CodTipoDeduccion As Integer

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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkNormal As System.Windows.Forms.CheckBox
    Friend WithEvents chkPromocion As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.chkNormal = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkPromocion = New System.Windows.Forms.CheckBox()
        Me.txtTipoCredito = New System.Windows.Forms.TextBox()
        Me.txtCodTipoCredito = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btEdit1 = New MetroFramework.Controls.MetroButton()
        Me.btDel1 = New MetroFramework.Controls.MetroButton()
        Me.btNew1 = New MetroFramework.Controls.MetroButton()
        Me.dgDeducciones = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.dtpFin)
        Me.GroupBox1.Controls.Add(Me.dtpInicio)
        Me.GroupBox1.Controls.Add(Me.chkNormal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkPromocion)
        Me.GroupBox1.Controls.Add(Me.txtTipoCredito)
        Me.GroupBox1.Controls.Add(Me.txtCodTipoCredito)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(536, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 16)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(432, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 16)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Desde:"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(432, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(128, 16)
        Me.Label22.TabIndex = 143
        Me.Label22.Text = "Período de Promoción:"
        '
        'dtpFin
        '
        Me.dtpFin.Enabled = False
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(536, 56)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(88, 20)
        Me.dtpFin.TabIndex = 142
        '
        'dtpInicio
        '
        Me.dtpInicio.Enabled = False
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(432, 56)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(88, 20)
        Me.dtpInicio.TabIndex = 141
        '
        'chkNormal
        '
        Me.chkNormal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNormal.Enabled = False
        Me.chkNormal.Location = New System.Drawing.Point(136, 16)
        Me.chkNormal.Name = "chkNormal"
        Me.chkNormal.Size = New System.Drawing.Size(96, 16)
        Me.chkNormal.TabIndex = 0
        Me.chkNormal.Text = "&Normal"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 16)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Tipo de Tabla:"
        '
        'chkPromocion
        '
        Me.chkPromocion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPromocion.Enabled = False
        Me.chkPromocion.Location = New System.Drawing.Point(272, 16)
        Me.chkPromocion.Name = "chkPromocion"
        Me.chkPromocion.Size = New System.Drawing.Size(96, 16)
        Me.chkPromocion.TabIndex = 1
        Me.chkPromocion.Text = "&Promocional"
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
        Me.txtTipoCredito.Size = New System.Drawing.Size(320, 20)
        Me.txtTipoCredito.TabIndex = 1
        '
        'txtCodTipoCredito
        '
        Me.txtCodTipoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTipoCredito.Location = New System.Drawing.Point(16, 56)
        Me.txtCodTipoCredito.MaxLength = 10
        Me.txtCodTipoCredito.Name = "txtCodTipoCredito"
        Me.txtCodTipoCredito.Size = New System.Drawing.Size(56, 20)
        Me.txtCodTipoCredito.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Tipo de Crédito:"
        '
        'btEdit1
        '
        Me.btEdit1.Location = New System.Drawing.Point(104, 157)
        Me.btEdit1.Name = "btEdit1"
        Me.btEdit1.Size = New System.Drawing.Size(75, 28)
        Me.btEdit1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEdit1.TabIndex = 208
        Me.btEdit1.Text = "Modificar"
        Me.btEdit1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEdit1.UseSelectable = True
        Me.btEdit1.UseStyleColors = True
        '
        'btDel1
        '
        Me.btDel1.Location = New System.Drawing.Point(185, 157)
        Me.btDel1.Name = "btDel1"
        Me.btDel1.Size = New System.Drawing.Size(75, 28)
        Me.btDel1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDel1.TabIndex = 207
        Me.btDel1.Text = "Eliminar"
        Me.btDel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDel1.UseSelectable = True
        Me.btDel1.UseStyleColors = True
        '
        'btNew1
        '
        Me.btNew1.Location = New System.Drawing.Point(23, 157)
        Me.btNew1.Name = "btNew1"
        Me.btNew1.Size = New System.Drawing.Size(75, 28)
        Me.btNew1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNew1.TabIndex = 206
        Me.btNew1.Text = "Agregar"
        Me.btNew1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNew1.UseSelectable = True
        Me.btNew1.UseStyleColors = True
        '
        'dgDeducciones
        '
        Me.dgDeducciones.AllowUserToAddRows = False
        Me.dgDeducciones.AllowUserToDeleteRows = False
        Me.dgDeducciones.AllowUserToOrderColumns = True
        Me.dgDeducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDeducciones.Location = New System.Drawing.Point(23, 191)
        Me.dgDeducciones.Name = "dgDeducciones"
        Me.dgDeducciones.ReadOnly = True
        Me.dgDeducciones.Size = New System.Drawing.Size(640, 303)
        Me.dgDeducciones.TabIndex = 4
        '
        'frmMsCrEncDescuentos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(690, 543)
        Me.Controls.Add(Me.dgDeducciones)
        Me.Controls.Add(Me.btDel1)
        Me.Controls.Add(Me.btEdit1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btNew1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(690, 543)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(690, 543)
        Me.Name = "frmMsCrEncDescuentos"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Descuentos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Propiedades"
    'Public Property TipoDeduccion() As AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion
    Public Property TipoDeduccion() As sifLib.Prestamos.clsPrestamos.TipoDeduccion
        Get
            Return vTipoDeduccion
        End Get
        'Set(ByVal Value As AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion)
        Set(ByVal Value As sifLib.Prestamos.clsPrestamos.TipoDeduccion)
            vTipoDeduccion = Value
        End Set
    End Property
    Public Property Accion() As String
        Get
            Return vAccion
        End Get
        Set(ByVal Value As String)
            vAccion = Value
        End Set
    End Property
#End Region
    Private Sub frmMsCrEncDescuentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.vAccion = "Modificar" Then
            Me.txtCodTipoCredito.Enabled = False
            CargaDatosTipoCredito()
        End If
        'If Me.vTipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Escrituracion Then
        If Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.Escrituracion Then
            Me.Text = "Gastos de Escrituración"
            CodTipoDeduccion = 0
            'ElseIf Me.vTipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Honorario Then
        ElseIf Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.Honorario Then
            Me.Text = "Honorarios"
            CodTipoDeduccion = 1
            'ElseIf Me.vTipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Tramitacion Then
        ElseIf Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.Tramitacion Then
            Me.Text = "Gastos de Tramitación"
            CodTipoDeduccion = 2
        End If
        LlenarDgDeducciones(2, Me.txtCodTipoCredito.Text.Trim, 0, CodTipoDeduccion)
    End Sub

    Private Sub txtCodTipoCredito_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoCredito.DoubleClick
        Dim ofrm As New frmAGenerico, oCredito As wrCredito.wsLibCred, ds As New Data.DataSet
        ofrm.Text = "Buscar Tipo de Crédito"
        Try
            oCredito = New wrCredito.wsLibCred
            ds = oCredito.ConsultarTipoCreditos("CodTipoCredito,Descripcion,PlazoMaximo,interesActual as Interes,Promocion,FechaIniProm,FechaFinProm", "", "CodTipoCredito", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            If ofrm.Resultado.Trim <> "" Then
                txtCodTipoCredito.Text = ofrm.Resultado.Trim
                txtTipoCredito.Text = ofrm.Resultado2.Trim
                If ofrm.Resultado5.Trim = "" Or ofrm.Resultado5.Trim = "0" Then
                    Me.chkPromocion.Checked = False
                    Me.chkNormal.Checked = True
                ElseIf ofrm.Resultado5.Trim = "1" Then
                    Me.chkPromocion.Checked = True
                    Me.chkNormal.Checked = False
                    Me.dtpInicio.Value = ofrm.Resultado6.Trim
                    Me.dtpFin.Value = ofrm.Resultado7.Trim
                End If
                Me.btNew1.Enabled = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Protected Sub EncabezadoDg()
        Try
            Me.dgDeducciones.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
            Me.dgDeducciones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            Me.dgDeducciones.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke

            Me.dgDeducciones.Columns("CodDeduccion").Visible = False
            Me.dgDeducciones.Columns("id_CatGastos_Tramitacion").Visible = False
            Me.dgDeducciones.Columns("CodTipoCredito").Visible = False
            Me.dgDeducciones.Columns("Tipo").Visible = False
            Me.dgDeducciones.Columns("MontoMax").Visible = False
            Me.dgDeducciones.Columns("Tarifa").Visible = False
            Me.dgDeducciones.Columns("AplicaPorcentaje").Visible = False
            Me.dgDeducciones.Columns("TipoDeduccion").Visible = False
            Me.dgDeducciones.Columns("CodRango").Visible = False
            Me.dgDeducciones.Columns("AplicaFactura").Visible = False
            Me.dgDeducciones.Columns("CodItem").Visible = False
            Me.dgDeducciones.Columns("TipoCredito").Visible = False
            Me.dgDeducciones.Columns("Tramitacion").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        Catch ex As Exception
            MsgBox("Error en la carga de información.", MsgBoxStyle.Information, "Módulo - Créditos")
        End Try
    End Sub
    Private Sub LlenarDgDeducciones(ByVal Opcion As Integer, ByVal CodTipoCredito As String, ByVal CodDeduccion As Integer,
                                    ByVal Tipo As String)
        Dim Dts As New DataSet
        Dts = Credito.Consultar_PrDeducciones(Opcion, CodTipoCredito, CodDeduccion, Tipo) 'Muestra todas las deducciones por tipo de credito
        Me.dgDeducciones.DataSource = Dts.Tables(0)
        EncabezadoDg()
    End Sub

    Private Sub btNew1_Click(sender As Object, e As EventArgs) Handles btNew1.Click
        Try
            Dim frm As New frmMsPRDescuentos
            If Me.txtCodTipoCredito.Text.Trim = "" Then
                Exit Sub
            End If
            frm.TipoCredito = Me.txtCodTipoCredito.Text.Trim
            frm.CodTipoDeduccion = CodTipoDeduccion
            frm.ShowDialog()
            LlenarDgDeducciones(2, Me.txtCodTipoCredito.Text, 0, CodTipoDeduccion)
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btEdit1_Click(sender As Object, e As EventArgs) Handles btEdit1.Click

        Try
            If Me.dgDeducciones.CurrentRow.Index > -1 Then
                Dim frm As New frmMsPRDescuentos
                frm.btnGuardar1.Text = "&Modificar"
                frm.TipoDeduccion = CodTipoDeduccion
                frm.CodTipoDeduccion = CodTipoDeduccion
                frm.TipoCredito = Me.txtCodTipoCredito.Text.Trim
                frm.c1txtCodDesc.Value = Me.dgDeducciones.Item("CodDeduccion", Me.dgDeducciones.CurrentRow.Index).Value
                frm.c1txtCodDesc.ReadOnly = True
                frm.c1nMontoMax.Value = IIf(IsDBNull(Me.dgDeducciones.Item("MontoMax", Me.dgDeducciones.CurrentRow.Index).Value), 0, Me.dgDeducciones.Item("MontoMax", Me.dgDeducciones.CurrentRow.Index).Value)
                frm.c1nValor.Value = IIf(IsDBNull(Me.dgDeducciones.Item("Monto", Me.dgDeducciones.CurrentRow.Index).Value), 0, Me.dgDeducciones.Item("Monto", Me.dgDeducciones.CurrentRow.Index).Value)
                frm.c1nIva.Value = IIf(IsDBNull(Me.dgDeducciones.Item("Iva", Me.dgDeducciones.CurrentRow.Index).Value), "", Me.dgDeducciones.Item("Iva", Me.dgDeducciones.CurrentRow.Index).Value)
                frm.chkAplicaItem.Checked = IIf(IIf(IsDBNull(Me.dgDeducciones.Item("AplicaFactura", Me.dgDeducciones.CurrentRow.Index).Value), "0", Me.dgDeducciones.Item("AplicaFactura", Me.dgDeducciones.CurrentRow.Index).Value) = "0", False, True)
                frm.txtCodItem.Text = IIf(IsDBNull(Me.dgDeducciones.Item("CodItem", Me.dgDeducciones.CurrentRow.Index).Value), "", Me.dgDeducciones.Item("CodItem", Me.dgDeducciones.CurrentRow.Index).Value)
                frm.chkAplicaPorc.Checked = IIf(IIf(IsDBNull(Me.dgDeducciones.Item("AplicaPorcentaje", Me.dgDeducciones.CurrentRow.Index).Value), "0", Me.dgDeducciones.Item("AplicaPorcentaje", Me.dgDeducciones.CurrentRow.Index).Value) = "0", False, True)
                '===========================================================================================
                '28/08/2012 Javier Martinez
                'Validamos si se ha almacenado el cod. del Catalogo de gastos de tramitacion
                'Modificación Realizada para la generación de partidas automaticas de desembolso
                If IIf(IsDBNull(Me.dgDeducciones.Item("id_CatGastos_Tramitacion", Me.dgDeducciones.CurrentRow.Index).Value), 0, Me.dgDeducciones.Item("id_CatGastos_Tramitacion", Me.dgDeducciones.CurrentRow.Index).Value) = 0 Then
                    frm.c1txtDescripcion.Visible = True
                    frm.c1txtDescripcion.Value = IIf(IsDBNull(Me.dgDeducciones.Item("Tramitacion", Me.dgDeducciones.CurrentRow.Index).Value), "", Me.dgDeducciones.Item("Tramitacion", Me.dgDeducciones.CurrentRow.Index).Value)
                    frm.cbGastosTramitacion.Visible = False
                Else
                    frm.c1txtDescripcion.Visible = False
                    frm.cbGastosTramitacion.DisplayMember = "GastosTramitacion"
                    frm.cbGastosTramitacion.ValueMember = "id_CatGastos_Tramitacion"
                    frm.LlenarCbGastosTramitacion(1, 0, "0")
                    frm.cbGastosTramitacion.SelectedValue = Me.dgDeducciones.Item("id_CatGastos_Tramitacion", Me.dgDeducciones.CurrentRow.Index).Value
                End If
                '===========================================================================================
                If Me.dgDeducciones.Item("Iva", Me.dgDeducciones.CurrentRow.Index).Value > 0 Then frm.chkAplicaIva.Checked = True
                If frm.txtCodItem.Text.Trim <> "" Then
                    Dim Ds As New DataSet
                    Ds = Caja.ObtenerItem(frm.txtCodItem.Text.Trim, "", sUsuario, sPassword, sSucursal)
                    If Ds.Tables(0).Rows.Count > 0 Then
                        frm.txtItem.Text = IIf(IsDBNull(Ds.Tables(0).Rows(0).Item("Descripcion")), "", Ds.Tables(0).Rows(0).Item("Descripcion"))
                    End If
                End If
                frm.ShowDialog()
                LlenarDgDeducciones(2, Me.txtCodTipoCredito.Text, 0, CodTipoDeduccion)
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btDel1_Click(sender As Object, e As EventArgs) Handles btDel1.Click
        Try
            If Me.dgDeducciones.CurrentRow.Index > -1 Then
                If MsgBox("¿Desea eliminar el registro seleccionado?", MsgBoxStyle.YesNo, "Módulo - Créditos") = MsgBoxResult.Yes Then
                    Dim Resultado As Integer
                    Resultado = Credito.Eliminar_PrDeducciones(Me.dgDeducciones.Item("CodDeduccion", Me.dgDeducciones.CurrentRow.Index).Value)
                    If Resultado <> 0 Then
                        MsgBox("Registro Eliminado exitosamente", MsgBoxStyle.Information, "Módulo - Créditos")
                    Else
                        MsgBox("El registro no pudo ser eliminado, por favor comunicarse con el administrador del sistema.", MsgBoxStyle.Critical, "Módulo - Créditos")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
    'Private Sub Encabezado()
    '    Dim Dts As New DataSet
    '    Dts = Credito.Consultar_PrDeducciones(2, Me.txtCodTipoCredito.Text.Trim, 0) 'Muestra todas las deducciones por tipo de credito
    '    Me.dgDeducciones.DataSource = Dts.Tables(0)
    '    Me.fgDeducciones.DataSource = Dts.Tables(0)

    '    '    Modificacion(28 / 8 / 2012)
    '    'Se creo SP para la consulta de PRDEDUCCIONES
    '    'Modificación Realizada para la generación de partidas automaticas de desembolso 
    '    Dim oCredito As New wrPrestamo.wsLibPrest, ds As New DataSet
    '    ds = oCredito.ConsultarPRDeducciones("CodDeduccion,Descripcion,Monto,MontoMax,Iva,Tarifa", "CodTipoCredito='" & Me.txtCodTipoCredito.Text.Trim & "' and Tipo='" & vTipoDeduccion & "'", "CodDeduccion", vTipoDeduccion, sUsuario, sPassword, sSucursal)
    '    Me.fgDeducciones.DataSource = ds.Tables(0)
    '    If Me.vAccion = "Guardar" And ds.Tables(0).Rows.Count > 0 Then Me.txtCodTipoCredito.Enabled = False
    '    'If Me.vTipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Escrituracion Or Me.vTipoDeduccion = AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion.Tramitacion Then
    '    If Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.Escrituracion Or Me.vTipoDeduccion = sifLib.Prestamos.clsPrestamos.TipoDeduccion.Tramitacion Then
    '        fgDeducciones.Cols.Item(1).Caption = "Código"
    '        fgDeducciones.Cols.Item(2).Caption = "Descripción"
    '        fgDeducciones.Cols.Item(3).Caption = "Monto"
    '        fgDeducciones.Cols.Item(5).Caption = "IVA"
    '        fgDeducciones.Cols.Item(0).Width = 20
    '        fgDeducciones.Cols.Item(1).Width = 100
    '        fgDeducciones.Cols.Item(2).Width = 150
    '        fgDeducciones.Cols.Item(3).Width = 77
    '        fgDeducciones.Cols.Item(4).Width = 0
    '        fgDeducciones.Cols.Item(5).Width = 77
    '        fgDeducciones.Cols.Item(6).Width = 0
    '    Else
    '        fgDeducciones.Cols.Item(1).Caption = "Código"
    '        fgDeducciones.Cols.Item(3).Caption = "Monto mínimo"
    '        fgDeducciones.Cols.Item(4).Caption = "Monto máximo"
    '        fgDeducciones.Cols.Item(5).Caption = "Tarifa"
    '        fgDeducciones.Cols.Item(0).Width = 20
    '        fgDeducciones.Cols.Item(1).Width = 100
    '        fgDeducciones.Cols.Item(2).Width = 0
    '        fgDeducciones.Cols.Item(3).Width = 77
    '        fgDeducciones.Cols.Item(4).Width = 77
    '        fgDeducciones.Cols.Item(5).Width = 0
    '        fgDeducciones.Cols.Item(6).Width = 77
    '    End If
    'End Sub
    Public Sub CargaDatosTipoCredito()
        Dim oCredito As wrCredito.wsLibCred, ds As New Data.DataSet, dr As DataRow
        Try
            oCredito = New wrCredito.wsLibCred
            ds = oCredito.ConsultarTipoCreditos("CodTipoCredito,Descripcion,PlazoMaximo,interesActual as Interes,Promocion,FechaIniProm,FechaFinProm", "CodTipoCredito='" & txtCodTipoCredito.Text.Trim & "'", "CodTipoCredito", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                txtCodTipoCredito.Text = dr("CodTipoCredito")
                txtTipoCredito.Text = IIf(IsDBNull(dr("Descripcion")), "", dr("Descripcion"))
                If IIf(IsDBNull(dr("Promocion")), "", dr("Promocion")) = "" Or IIf(IsDBNull(dr("Promocion")), "", dr("Promocion")) = "0" Then
                    Me.chkPromocion.Checked = False
                    Me.chkNormal.Checked = True
                ElseIf dr("Promocion") = "1" Then
                    Me.chkPromocion.Checked = True
                    Me.chkNormal.Checked = False
                    Me.dtpInicio.Value = dr("FechaIniProm")
                    Me.dtpFin.Value = dr("FechaFinProm")
                End If
                Me.btNew1.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class