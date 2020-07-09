Public Class frmMSCrEncDescRango
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    'Private vTipoDeduccion As Prestamos.clsPrestamos.TipoDeduccion, vAccion As String
    Private vTipoDeduccion As sifLib.Prestamos.clsPrestamos.TipoDeduccion, vAccion As String
    Friend WithEvents btEdit1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNew1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents fgDeducciones As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkNormal As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkPromocion As System.Windows.Forms.CheckBox
    Friend WithEvents txtTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoCredito As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMSCrEncDescRango))
        Me.btEdit1 = New MetroFramework.Controls.MetroButton()
        Me.btNew1 = New MetroFramework.Controls.MetroButton()
        Me.fgDeducciones = New C1.Win.C1FlexGrid.C1FlexGrid()
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
        CType(Me.fgDeducciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btEdit1
        '
        Me.btEdit1.Location = New System.Drawing.Point(124, 180)
        Me.btEdit1.Name = "btEdit1"
        Me.btEdit1.Size = New System.Drawing.Size(90, 32)
        Me.btEdit1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btEdit1.TabIndex = 215
        Me.btEdit1.Text = "Modificar"
        Me.btEdit1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btEdit1.UseSelectable = True
        Me.btEdit1.UseStyleColors = True
        '
        'btNew1
        '
        Me.btNew1.Location = New System.Drawing.Point(28, 180)
        Me.btNew1.Name = "btNew1"
        Me.btNew1.Size = New System.Drawing.Size(90, 32)
        Me.btNew1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNew1.TabIndex = 214
        Me.btNew1.Text = "Nuevo"
        Me.btNew1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNew1.UseSelectable = True
        Me.btNew1.UseStyleColors = True
        '
        'fgDeducciones
        '
        Me.fgDeducciones.AllowEditing = False
        Me.fgDeducciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fgDeducciones.BackColor = System.Drawing.Color.White
        Me.fgDeducciones.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:15;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{AllowDragging:False;AllowResizing:False;Allo" &
    "wEditing:False;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fgDeducciones.Location = New System.Drawing.Point(28, 218)
        Me.fgDeducciones.Name = "fgDeducciones"
        Me.fgDeducciones.Rows.Count = 1
        Me.fgDeducciones.Rows.DefaultSize = 21
        Me.fgDeducciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fgDeducciones.Size = New System.Drawing.Size(796, 190)
        Me.fgDeducciones.StyleInfo = resources.GetString("fgDeducciones.StyleInfo")
        Me.fgDeducciones.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
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
        Me.GroupBox1.Location = New System.Drawing.Point(28, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 101)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(643, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 19)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(518, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Desde:"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(518, 18)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(154, 19)
        Me.Label22.TabIndex = 143
        Me.Label22.Text = "Período de Promoción:"
        '
        'dtpFin
        '
        Me.dtpFin.Enabled = False
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFin.Location = New System.Drawing.Point(643, 65)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.Size = New System.Drawing.Size(106, 22)
        Me.dtpFin.TabIndex = 142
        '
        'dtpInicio
        '
        Me.dtpInicio.Enabled = False
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpInicio.Location = New System.Drawing.Point(518, 65)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.Size = New System.Drawing.Size(106, 22)
        Me.dtpInicio.TabIndex = 141
        '
        'chkNormal
        '
        Me.chkNormal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNormal.Enabled = False
        Me.chkNormal.Location = New System.Drawing.Point(163, 18)
        Me.chkNormal.Name = "chkNormal"
        Me.chkNormal.Size = New System.Drawing.Size(115, 19)
        Me.chkNormal.TabIndex = 0
        Me.chkNormal.Text = "&Normal"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 19)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "Tipo de Tabla:"
        '
        'chkPromocion
        '
        Me.chkPromocion.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPromocion.Enabled = False
        Me.chkPromocion.Location = New System.Drawing.Point(326, 18)
        Me.chkPromocion.Name = "chkPromocion"
        Me.chkPromocion.Size = New System.Drawing.Size(116, 19)
        Me.chkPromocion.TabIndex = 1
        Me.chkPromocion.Text = "&Promocional"
        '
        'txtTipoCredito
        '
        Me.txtTipoCredito.BackColor = System.Drawing.Color.White
        Me.txtTipoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCredito.Enabled = False
        Me.txtTipoCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCredito.Location = New System.Drawing.Point(106, 65)
        Me.txtTipoCredito.MaxLength = 100
        Me.txtTipoCredito.Name = "txtTipoCredito"
        Me.txtTipoCredito.ReadOnly = True
        Me.txtTipoCredito.Size = New System.Drawing.Size(384, 23)
        Me.txtTipoCredito.TabIndex = 1
        '
        'txtCodTipoCredito
        '
        Me.txtCodTipoCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodTipoCredito.Location = New System.Drawing.Point(19, 65)
        Me.txtCodTipoCredito.MaxLength = 10
        Me.txtCodTipoCredito.Name = "txtCodTipoCredito"
        Me.txtCodTipoCredito.Size = New System.Drawing.Size(67, 23)
        Me.txtCodTipoCredito.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(19, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 19)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Tipo de Crédito:"
        '
        'frmMSCrEncDescRango
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(847, 495)
        Me.Controls.Add(Me.fgDeducciones)
        Me.Controls.Add(Me.btEdit1)
        Me.Controls.Add(Me.btNew1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMSCrEncDescRango"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Deducciones"
        CType(Me.fgDeducciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Propiedades"
    'Public Property TipoDeduccion() As Prestamos.clsPrestamos.TipoDeduccion
    Public Property TipoDeduccion() As sifLib.Prestamos.clsPrestamos.TipoDeduccion
        Get
            Return vTipoDeduccion
        End Get
        'Set(ByVal Value As Prestamos.clsPrestamos.TipoDeduccion)
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

    Private Sub frmMSCrEncDescRango_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.vAccion = "Modificar" Then
            Me.txtCodTipoCredito.Enabled = False
            CargaDatosTipoCredito()
        End If
        Encabezado()
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
            End If

        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub Encabezado()

        MessageBox.Show("Falta implementar", "Incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        '*****************************************************
        '       Falta implementar en Web Service
        '*****************************************************


        'Dim oCredito As New wrPrestamo.wsLibPrest, ds As New DataSet
        'ds = oCredito.ConsultarPRDeduccionesxTipoDeduccion("CodRango,Descripcion", "CodTipoCredito='" & Me.txtCodTipoCredito.Text.Trim & "' and Tipo='" & vTipoDeduccion & "'", "CodRango", vTipoDeduccion, sUsuario, sPassword,sSucursal)
        'Me.fgDeducciones.DataSource = ds.Tables(0)

        'If Me.vAccion = "Guardar" And ds.Tables(0).Rows.Count > 0 Then Me.txtCodTipoCredito.Enabled = False
        'fgDeducciones.Cols.Item(1).Caption = "Código"
        'fgDeducciones.Cols.Item(2).Caption = "Descripción"
        'fgDeducciones.Cols.Item(0).Width = 20
        'fgDeducciones.Cols.Item(1).Width = 77
        'fgDeducciones.Cols.Item(2).Width = 100

    End Sub



    Private Sub btNew1_Click(sender As Object, e As EventArgs) Handles btNew1.Click
        Try
            Dim frm As New frmMsDetDescRango, oPrest As New wrPrestamo.wsLibPrest
            If Me.txtCodTipoCredito.Text.Trim = "" Then
                Exit Sub
            End If
            frm.CodRango = oPrest.ObtenercorrelativoPRDeducciones("CodRango", sUsuario, sPassword, sSucursal)
            frm.TipoCredito = Me.txtCodTipoCredito.Text.Trim
            frm.TipoDeduccion = Me.vTipoDeduccion
            frm.ShowDialog()
            Encabezado()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btEdit1_Click(sender As Object, e As EventArgs) Handles btEdit1.Click
        Try
            If fgDeducciones.Row > -1 Then
                Dim oCred As wrPrestamo.wsLibPrest = New wrPrestamo.wsLibPrest
                Dim frmR As New frmMsDetDescRango
                frmR.CodRango = fgDeducciones.Item(fgDeducciones.Row, "CodRango")
                frmR.c1txtDescripcion.ReadOnly = True
                If Me.btNew1.Visible = False Then
                    frmR.btNew1.Visible = False
                    frmR.btDel1.Visible = False
                End If
                frmR.TipoDeduccion = vTipoDeduccion
                frmR.TipoCredito = Me.txtCodTipoCredito.Text.Trim
                frmR.Accion = "Modificar"
                frmR.StartPosition = FormStartPosition.CenterScreen
                frmR.ShowDialog()
                Encabezado()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

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
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

End Class