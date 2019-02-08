Public Class frmMsProcesoComisiones
    Inherits System.Windows.Forms.Form : Public rsc As System.Resources.ResourceManager

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
    Friend WithEvents btnInhabilitacion As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpAl As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDel As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMsProcesoComisiones))
        Me.btnInhabilitacion = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpAl = New System.Windows.Forms.DateTimePicker
        Me.dtpDel = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.GroupBox1.SuspendLayout()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInhabilitacion
        '
        Me.btnInhabilitacion.BackColor = System.Drawing.SystemColors.Control
        Me.btnInhabilitacion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInhabilitacion.ForeColor = System.Drawing.Color.Black
        Me.btnInhabilitacion.Image = CType(resources.GetObject("btnInhabilitacion.Image"), System.Drawing.Image)
        Me.btnInhabilitacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInhabilitacion.Location = New System.Drawing.Point(456, 216)
        Me.btnInhabilitacion.Name = "btnInhabilitacion"
        Me.btnInhabilitacion.Size = New System.Drawing.Size(144, 24)
        Me.btnInhabilitacion.TabIndex = 2
        Me.btnInhabilitacion.Text = "&Calcular Comisiones"
        Me.btnInhabilitacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCerrar.Location = New System.Drawing.Point(696, 216)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(80, 23)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "     &Cerrar"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Teal
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtpAl)
        Me.GroupBox1.Controls.Add(Me.dtpDel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(288, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 212
        Me.Label4.Text = "al:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(128, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 211
        Me.Label3.Text = "Del:"
        '
        'dtpAl
        '
        Me.dtpAl.CustomFormat = "dd/MM/yyyy"
        Me.dtpAl.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAl.Location = New System.Drawing.Point(328, 24)
        Me.dtpAl.Name = "dtpAl"
        Me.dtpAl.Size = New System.Drawing.Size(88, 20)
        Me.dtpAl.TabIndex = 1
        '
        'dtpDel
        '
        Me.dtpDel.CustomFormat = "dd/MM/yyyy"
        Me.dtpDel.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDel.Location = New System.Drawing.Point(176, 24)
        Me.dtpDel.Name = "dtpDel"
        Me.dtpDel.Size = New System.Drawing.Size(88, 20)
        Me.dtpDel.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 208
        Me.Label2.Text = "Período de Cálculo:"
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.SystemColors.Control
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnImprimir.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.Location = New System.Drawing.Point(608, 216)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(80, 24)
        Me.btnImprimir.TabIndex = 3
        Me.btnImprimir.Text = "&Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'fg
        '
        Me.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.SystemColors.Window
        Me.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None
        Me.fg.ColumnInfo = "3,0,0,0,0,85,Columns:0{Width:26;}" & Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(8, 56)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 1
        Me.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.fg.Size = New System.Drawing.Size(768, 152)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Normal{Font:Arial, 8.25pt, style=Bold;ForeColor:Navy;}" & Microsoft.VisualBasic.ChrW(9) & "Alternate{BackColor:LightS" & _
        "teelTeal;}" & Microsoft.VisualBasic.ChrW(9) & "Fixed{BackColor:MidnightTeal;ForeColor:White;Border:Flat,1,ControlDar" & _
        "k,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Highlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColo" & _
        "r:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackCol" & _
        "or:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;" & _
        "ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal" & _
        "1{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDar" & _
        "k;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtot" & _
        "al4{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkD" & _
        "ark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me.fg.TabIndex = 1
        '
        'frmMsProcesoComisiones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.ClientSize = New System.Drawing.Size(784, 246)
        Me.Controls.Add(Me.btnInhabilitacion)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.fg)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsProcesoComisiones"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cálculo de Comisiones de Mercadeo"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMsProcesoComisiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpDel.Value = Now
        Me.dtpAl.Value = Now
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btnInhabilitacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInhabilitacion.Click
        Try
            Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
            ds = oAsoc.CalculaComisionesEjecutivos(Me.dtpDel.Value, Me.dtpAl.Value, sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Try
            Dim oAsoc As New wrAsociados.wsLibAsoc, ds As New DataSet
            ds = oAsoc.CalculaComisionesEjecutivos(Me.dtpDel.Value, Me.dtpAl.Value, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 90, 0)
            ofrm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class