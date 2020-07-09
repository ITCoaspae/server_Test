Public Class frmMsCrRangosLineaCred
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pAccion As String
    Friend WithEvents btDel1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btNew1 As MetroFramework.Controls.MetroButton

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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodLineaCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtLineaCredito As System.Windows.Forms.TextBox
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMsCrRangosLineaCred))
        Me.txtCodLineaCredito = New System.Windows.Forms.TextBox()
        Me.txtLineaCredito = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btDel1 = New MetroFramework.Controls.MetroButton()
        Me.btNew1 = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCodLineaCredito
        '
        Me.txtCodLineaCredito.BackColor = System.Drawing.Color.White
        Me.txtCodLineaCredito.Location = New System.Drawing.Point(150, 69)
        Me.txtCodLineaCredito.MaxLength = 10
        Me.txtCodLineaCredito.Name = "txtCodLineaCredito"
        Me.txtCodLineaCredito.Size = New System.Drawing.Size(77, 22)
        Me.txtCodLineaCredito.TabIndex = 0
        '
        'txtLineaCredito
        '
        Me.txtLineaCredito.BackColor = System.Drawing.Color.White
        Me.txtLineaCredito.Location = New System.Drawing.Point(234, 69)
        Me.txtLineaCredito.MaxLength = 255
        Me.txtLineaCredito.Name = "txtLineaCredito"
        Me.txtLineaCredito.Size = New System.Drawing.Size(416, 22)
        Me.txtLineaCredito.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(28, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 19)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Línea de Crédito:"
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:15;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(31, 141)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.Rows.DefaultSize = 21
        Me.fg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.fg.Size = New System.Drawing.Size(619, 277)
        Me.fg.StyleInfo = resources.GetString("fg.StyleInfo")
        Me.fg.TabIndex = 3
        '
        'btDel1
        '
        Me.btDel1.Location = New System.Drawing.Point(128, 102)
        Me.btDel1.Name = "btDel1"
        Me.btDel1.Size = New System.Drawing.Size(90, 32)
        Me.btDel1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btDel1.TabIndex = 217
        Me.btDel1.Text = "Eliminar"
        Me.btDel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btDel1.UseSelectable = True
        Me.btDel1.UseStyleColors = True
        '
        'btNew1
        '
        Me.btNew1.Location = New System.Drawing.Point(31, 102)
        Me.btNew1.Name = "btNew1"
        Me.btNew1.Size = New System.Drawing.Size(90, 32)
        Me.btNew1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btNew1.TabIndex = 216
        Me.btNew1.Text = "Nuevo"
        Me.btNew1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btNew1.UseSelectable = True
        Me.btNew1.UseStyleColors = True
        '
        'frmMsCrRangosLineaCred
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(671, 468)
        Me.Controls.Add(Me.txtLineaCredito)
        Me.Controls.Add(Me.txtCodLineaCredito)
        Me.Controls.Add(Me.btDel1)
        Me.Controls.Add(Me.btNew1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fg)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(671, 468)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(671, 468)
        Me.Name = "frmMsCrRangosLineaCred"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento de Rangos por Línea de Crédito"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmMsCrLineasCred_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oCred As New wrCredito.wsLibCred, ds As New Data.DataSet, Filas As Data.DataRowCollection

            If Me.pAccion = "Modificar" Then
                If pCodigo.Trim = "00000" Then
                    Me.txtCodLineaCredito.Text = "00000"
                    Me.txtLineaCredito.Text = "Todas las líneas de Crédito"
                Else
                    ds = oCred.ConsultarLineaCreditos("*", "CodLineaCredito='" & pCodigo & "'", "CodLineaCredito", sUsuario, sPassword, sSucursal)
                    Filas = ds.Tables(0).Rows()
                    If Filas.Count > 0 Then
                        Me.txtCodLineaCredito.Text = pCodigo
                        Me.txtLineaCredito.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    End If
                End If
                Encabezado()
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub Encabezado()

        Dim oCredito As New wrCredito.wsLibCred, ds As New DataSet
        ds = oCredito.ConsultarRangoLineaCreditos("Correlativo,Desde,Hasta", "CodLineaCredito='" & Me.txtCodLineaCredito.Text.Trim & "'", "Correlativo", sUsuario, sPassword, sSucursal)
        Me.fg.DataSource = ds.Tables(0)

        fg.Cols.Item(1).Caption = "No."
        fg.Cols.Item(2).Caption = "Desde"
        fg.Cols.Item(3).Caption = "Hasta"
        fg.Cols.Item(0).Width = 20
        fg.Cols.Item(1).Width = 100
        fg.Cols.Item(2).Width = 77
        fg.Cols.Item(3).Width = 77
    End Sub


    Private Sub btNew1_Click(sender As Object, e As EventArgs) Handles btNew1.Click
        Try
            Dim frm As New frmMsDetRangoLineaCred
            If Me.txtLineaCredito.Text.Trim = "" Then Exit Sub
            frm.CodLineaCredito = Me.txtCodLineaCredito.Text.Trim
            frm.Accion = "Guardar"
            frm.ShowDialog()
            Encabezado()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btDel1_Click(sender As Object, e As EventArgs) Handles btDel1.Click
        Try
            If fg.Row > -1 Then
                If MsgBox("¿Desea eliminar el registro seleccionado?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                    Dim oCredito As New wrCredito.wsLibCred
                    oCredito.EliminarRangoLineaCreditos("Correlativo", fg.Item(fg.Row, "Correlativo"), sUsuario, sPassword, sSucursal)
                    Encabezado()
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



End Class