Public Class frmMsDetDescRango
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    'Private vTipoDeduccion As AlcalaLibs.Prestamos.clsPrestamos.TipoDeduccion, vTipoCredito As String, vAccion As String, vCodRango As String
    Private vTipoDeduccion As sifLib.Prestamos.clsPrestamos.TipoDeduccion, vTipoCredito As String, vAccion As String, vCodRango As String
    Friend WithEvents btNew1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btEdit1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btDel1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents c1txtDescripcion As C1.Win.C1Input.C1TextBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents fgDeducciones As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents chkAplicaPorc As System.Windows.Forms.CheckBox
    Friend WithEvents cbAplica As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsDetDescRango))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbAplica = New System.Windows.Forms.ComboBox()
        Me.chkAplicaPorc = New System.Windows.Forms.CheckBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.c1txtDescripcion = New C1.Win.C1Input.C1TextBox()
        Me.fgDeducciones = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btNew1 = New MetroFramework.Controls.MetroButton()
        Me.btEdit1 = New MetroFramework.Controls.MetroButton()
        Me.btDel1 = New MetroFramework.Controls.MetroButton()
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fgDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(240, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Porcentaje de:"
        '
        'cbAplica
        '
        Me.cbAplica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAplica.Enabled = False
        Me.cbAplica.Items.AddRange(New Object() {"Monto del Crédito", "Aportaciones (Saldo Aportación p/ cálculo deducción)", "Aportaciones (Monto del Crédito p/ cálculo deducción)"})
        Me.cbAplica.Location = New System.Drawing.Point(316, 82)
        Me.cbAplica.Name = "cbAplica"
        Me.cbAplica.Size = New System.Drawing.Size(266, 21)
        Me.cbAplica.TabIndex = 83
        '
        'chkAplicaPorc
        '
        Me.chkAplicaPorc.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAplicaPorc.Location = New System.Drawing.Point(26, 83)
        Me.chkAplicaPorc.Name = "chkAplicaPorc"
        Me.chkAplicaPorc.Size = New System.Drawing.Size(208, 16)
        Me.chkAplicaPorc.TabIndex = 82
        Me.chkAplicaPorc.Text = "Tarifa se manejará como porcentaje"
        '
        'lblTipo
        '
        Me.lblTipo.Location = New System.Drawing.Point(23, 60)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(72, 16)
        Me.lblTipo.TabIndex = 72
        Me.lblTipo.Text = "Descripción:"
        '
        'c1txtDescripcion
        '
        Me.c1txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1txtDescripcion.Location = New System.Drawing.Point(101, 56)
        Me.c1txtDescripcion.MaxLength = 255
        Me.c1txtDescripcion.Name = "c1txtDescripcion"
        Me.c1txtDescripcion.NumericInput = False
        Me.c1txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.c1txtDescripcion.Size = New System.Drawing.Size(481, 20)
        Me.c1txtDescripcion.TabIndex = 0
        Me.c1txtDescripcion.Tag = Nothing
        '
        'fgDeducciones
        '
        Me.fgDeducciones.AllowEditing = False
        Me.fgDeducciones.BackColor = System.Drawing.Color.White
        Me.fgDeducciones.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:15;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgDeducciones.Location = New System.Drawing.Point(23, 139)
        Me.fgDeducciones.Name = "fgDeducciones"
        Me.fgDeducciones.Rows.Count = 1
        Me.fgDeducciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fgDeducciones.Size = New System.Drawing.Size(559, 288)
        Me.fgDeducciones.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fgDeducciones.Styles"))
        Me.fgDeducciones.TabIndex = 3
        '
        'btNew1
        '
        Me.btNew1.Location = New System.Drawing.Point(23, 105)
        Me.btNew1.Name = "btNew1"
        Me.btNew1.Size = New System.Drawing.Size(75, 28)
        Me.btNew1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNew1.TabIndex = 85
        Me.btNew1.Text = "Nuevo"
        Me.btNew1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNew1.UseSelectable = True
        Me.btNew1.UseStyleColors = True
        '
        'btEdit1
        '
        Me.btEdit1.Location = New System.Drawing.Point(104, 105)
        Me.btEdit1.Name = "btEdit1"
        Me.btEdit1.Size = New System.Drawing.Size(75, 28)
        Me.btEdit1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEdit1.TabIndex = 86
        Me.btEdit1.Text = "Modificar"
        Me.btEdit1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEdit1.UseSelectable = True
        Me.btEdit1.UseStyleColors = True
        '
        'btDel1
        '
        Me.btDel1.Location = New System.Drawing.Point(185, 105)
        Me.btDel1.Name = "btDel1"
        Me.btDel1.Size = New System.Drawing.Size(75, 28)
        Me.btDel1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDel1.TabIndex = 87
        Me.btDel1.Text = "Eliminar"
        Me.btDel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDel1.UseSelectable = True
        Me.btDel1.UseStyleColors = True
        '
        'frmMsDetDescRango
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(605, 469)
        Me.Controls.Add(Me.fgDeducciones)
        Me.Controls.Add(Me.btDel1)
        Me.Controls.Add(Me.btEdit1)
        Me.Controls.Add(Me.btNew1)
        Me.Controls.Add(Me.cbAplica)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkAplicaPorc)
        Me.Controls.Add(Me.lblTipo)
        Me.Controls.Add(Me.c1txtDescripcion)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsDetDescRango"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Gastos por Rango"
        CType(Me.c1txtDescripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fgDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Public Property TipoCredito() As String
        Get
            Return vTipoCredito
        End Get
        Set(ByVal Value As String)
            vTipoCredito = Value
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
    Public Property CodRango() As String
        Get
            Return vCodRango
        End Get
        Set(ByVal Value As String)
            vCodRango = Value
        End Set
    End Property
#End Region



    Private Sub Encabezado()

        Dim oCredito As New wrPrestamo.wsLibPrest, ds As New DataSet
        ds = oCredito.ConsultarPRDeducciones("CodDeduccion,Descripcion,Monto,MontoMax,Tarifa", "CodTipoCredito='" & Me.vTipoCredito & "' and Tipo='" & vTipoDeduccion & "' and CodRango='" & Me.CodRango & "'", "CodDeduccion", vTipoDeduccion, sUsuario, sPassword, sSucursal)
        Me.fgDeducciones.DataSource = ds.Tables(0)

        If Me.vAccion = "Guardar" And ds.Tables(0).Rows.Count > 0 Then Me.c1txtDescripcion.Enabled = False

        fgDeducciones.Cols.Item(1).Caption = "Código"
        fgDeducciones.Cols.Item(3).Caption = "Monto mínimo"
        fgDeducciones.Cols.Item(4).Caption = "Monto máximo"
        fgDeducciones.Cols.Item(5).Caption = "Tarifa"
        fgDeducciones.Cols.Item(0).Width = 20
        fgDeducciones.Cols.Item(1).Width = 100
        fgDeducciones.Cols.Item(2).Width = 0
        fgDeducciones.Cols.Item(3).Width = 77
        fgDeducciones.Cols.Item(4).Width = 77
        fgDeducciones.Cols.Item(5).Width = 77
    End Sub

    Private Sub frmMsDetDescRango_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Accion = "Modificar" Then
            Dim oCredito As New wrPrestamo.wsLibPrest, ds As New DataSet, dr As DataRow
            ds = oCredito.ConsultarPRDeducciones("TipoDeduccion,AplicaPorcentaje,Descripcion", "CodTipoCredito='" & Me.vTipoCredito & "' and Tipo='" & vTipoDeduccion & "' and CodRango='" & Me.CodRango & "'", "CodDeduccion", vTipoDeduccion, sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.c1txtDescripcion.Value = dr("Descripcion")
                Me.chkAplicaPorc.Checked = IIf(dr("AplicaPorcentaje") = "1", True, False)
                If Me.chkAplicaPorc.Checked = True Then
                    Me.cbAplica.SelectedIndex = dr("TipoDeduccion")
                End If
            End If
            Me.cbAplica.Enabled = False
            Me.chkAplicaPorc.Enabled = False
            Encabezado()
        Else
            Me.cbAplica.SelectedIndex = 0
        End If
    End Sub

    Private Sub btNew1_Click(sender As Object, e As EventArgs) Handles btNew1.Click
        Try
            Dim frm As New frmMsPRDescuentos
            If Me.c1txtDescripcion.Text.Trim = "" Then
                Exit Sub
            End If
            frm.Descripcion = Me.c1txtDescripcion.Text.Trim
            frm.CodRango = vCodRango
            frm.Porc = IIf(Me.chkAplicaPorc.Checked = True, "1", "0")
            frm.Tipo = Me.cbAplica.SelectedIndex
            frm.TipoCredito = vTipoCredito
            frm.TipoDeduccion = Me.vTipoDeduccion
            frm.ShowDialog()
            Encabezado()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btDel1_Click(sender As Object, e As EventArgs) Handles btDel1.Click
        Try
            If fgDeducciones.Row > -1 Then
                If MsgBox("¿Desea eliminar el registro seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    Dim oCredito As New wrPrestamo.wsLibPrest
                    oCredito.EliminarPRDeducciones("CodDeduccion='" & fgDeducciones.Item(fgDeducciones.Row, "CodDeduccion") & "'", vTipoDeduccion, sUsuario, sPassword, sSucursal)
                    Encabezado()
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btEdit1_Click(sender As Object, e As EventArgs) Handles btEdit1.Click
        Try
            If fgDeducciones.Row > -1 Then
                Dim oCredito As New wrPrestamo.wsLibPrest, ds As New DataSet, dr As DataRow
                ds = oCredito.ConsultarPRDeducciones("*", "CodDeduccion='" & fgDeducciones.Item(fgDeducciones.Row, "CodDeduccion") & "'", "CodDeduccion", vTipoDeduccion, sUsuario, sPassword, sSucursal)
                If ds.Tables(0).Rows.Count > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    Dim frm As New frmMsPRDescuentos
                    frm.btnGuardar1.Text = "&Modificar"
                    frm.CodRango = vCodRango
                    frm.TipoCredito = vTipoCredito
                    frm.TipoDeduccion = Me.vTipoDeduccion
                    If Me.btNew1.Visible = False Then frm.btnGuardar1.Visible = False
                    If Me.c1txtDescripcion.Text.Trim = "" Then Exit Sub
                    frm.Descripcion = Me.c1txtDescripcion.Text.Trim
                    frm.c1txtCodDesc.Value = dr("CodDeduccion")
                    frm.Porc = IIf(IsDBNull(dr("AplicaPorcentaje")), "0", dr("AplicaPorcentaje"))
                    frm.Tipo = IIf(IsDBNull(dr("TipoDeduccion")), "", dr("TipoDeduccion"))
                    frm.c1txtCodDesc.ReadOnly = True
                    frm.c1txtDescripcion.Value = IIf(IsDBNull(dr("Descripcion")), "", dr("Descripcion"))
                    frm.c1nMontoMax.Value = dr("MontoMax")
                    frm.c1nValor.Value = dr("Monto")
                    frm.c1nIva.Value = dr("Tarifa")
                    If dr("Iva") > 0 Then
                        frm.chkAplicaIva.Checked = True
                    Else
                        frm.chkAplicaIva.Checked = False
                    End If
                    frm.chkAplicaPorc.Checked = IIf(IIf(IsDBNull(dr("AplicaPorcentaje")), "0", dr("AplicaPorcentaje")) = "0", False, True)
                    If dr("Iva") > 0 Then frm.chkAplicaIva.Checked = True
                    frm.ShowDialog()
                    Encabezado()
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub chkAplicaPorc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAplicaPorc.CheckedChanged
        If Me.chkAplicaPorc.Checked = True Then
            Me.cbAplica.Enabled = True
        Else
            Me.cbAplica.Enabled = False
        End If
    End Sub

End Class