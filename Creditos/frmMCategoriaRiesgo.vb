
Public Class frmMCategoriaRiesgo
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim ds As New Data.DataSet
    Friend WithEvents btnModificar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAgregar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
    Dim oItem As wrCredito.wsLibCred = New wrCredito.wsLibCred
#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents fg As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMCategoriaRiesgo))
        Me.fg = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnModificar1 = New MetroFramework.Controls.MetroButton()
        Me.btnAgregar1 = New MetroFramework.Controls.MetroButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.fg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fg
        '
        Me.fg.AllowEditing = False
        Me.fg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fg.BackColor = System.Drawing.Color.White
        Me.fg.ColumnInfo = "10,1,0,0,0,85,Columns:1{AllowEditing:False;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.fg.Location = New System.Drawing.Point(20, 97)
        Me.fg.Name = "fg"
        Me.fg.Rows.Count = 2
        Me.fg.Size = New System.Drawing.Size(633, 204)
        Me.fg.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("fg.Styles"))
        Me.fg.TabIndex = 16
        '
        'btnModificar1
        '
        Me.btnModificar1.Location = New System.Drawing.Point(104, 63)
        Me.btnModificar1.Name = "btnModificar1"
        Me.btnModificar1.Size = New System.Drawing.Size(75, 28)
        Me.btnModificar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnModificar1.TabIndex = 193
        Me.btnModificar1.Text = "Modificar"
        Me.btnModificar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnModificar1.UseSelectable = True
        Me.btnModificar1.UseStyleColors = True
        '
        'btnAgregar1
        '
        Me.btnAgregar1.Location = New System.Drawing.Point(23, 63)
        Me.btnAgregar1.Name = "btnAgregar1"
        Me.btnAgregar1.Size = New System.Drawing.Size(75, 28)
        Me.btnAgregar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAgregar1.TabIndex = 192
        Me.btnAgregar1.Text = "Agregar"
        Me.btnAgregar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAgregar1.UseSelectable = True
        Me.btnAgregar1.UseStyleColors = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(266, 63)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(75, 28)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 195
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(185, 63)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(75, 28)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnEliminar1.TabIndex = 194
        Me.btnEliminar1.Text = "Eliminar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'frmMCategoriaRiesgo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(676, 355)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnEliminar1)
        Me.Controls.Add(Me.btnModificar1)
        Me.Controls.Add(Me.btnAgregar1)
        Me.Controls.Add(Me.fg)
        Me.Name = "frmMCategoriaRiesgo"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento - Categoria Riesgo"
        CType(Me.fg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMCategoriaRiesgo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ActualizarGrid()
    End Sub

    Private Sub ActualizarGrid()
        Try
            ds = oItem.ConsultarPRCategoriaRiesgo("*", "", "Categoria", sUsuario, sPassword, sSucursal)
            fg.DataSource = ds.Tables(0)
            fg.Cols.Item(0).Width = 50
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnAgregar1_Click(sender As Object, e As EventArgs) Handles btnAgregar1.Click
        Try
            Dim frm As frmDCategoriaRiesgo = New frmDCategoriaRiesgo
            Dim oItem As New wrCredito.wsLibCred
            frm.btnGuardar1.Text = "&Guardar"
            frm.StartPosition = FormStartPosition.CenterScreen
            frm.ShowDialog()
            ActualizarGrid()
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnModificar1_Click(sender As Object, e As EventArgs) Handles btnModificar1.Click
        Try
            Dim dr As DataRow, oItem As New wrCredito.wsLibCred
            Dim frm As frmDCategoriaRiesgo = New frmDCategoriaRiesgo

            If fg.Row <> -1 Then
                frm.btnGuardar1.Text = "&Modificar"
                ds = oItem.ConsultarPRCategoriaRiesgo("*", "Categoria='" & Trim(fg.Item(fg.Row, "Categoria")) & "'", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                If Not dr("Categoria") Is DBNull.Value Then
                    frm.txtCategoria.Text = CStr(dr("Categoria"))
                    frm.txtCategoria.ReadOnly = True
                End If
                If Not dr("DiaDesde") Is DBNull.Value Then
                    frm.txtDesde.Text = CInt(dr("DiaDesde"))
                End If
                If Not dr("DiaHasta") Is DBNull.Value Then
                    frm.txtHasta.Text = CInt(dr("DiaHasta"))
                End If
                If Not dr("PorcentajeRiesgo") Is DBNull.Value Then
                    frm.txtProcentaje.Text = CDbl(dr("PorcentajeRiesgo"))
                End If
                If Not dr("Rango1") Is DBNull.Value Then
                    frm.txtRango1.Text = CDbl(dr("Rango1"))
                End If
                If Not dr("Rango2") Is DBNull.Value Then
                    frm.txtRango2.Text = CDbl(dr("Rango2"))
                End If
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizarGrid()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnEliminar1_Click(sender As Object, e As EventArgs) Handles btnEliminar1.Click
        Try
            Dim oItem As New wrCredito.wsLibCred
            If fg.Row <> -1 Then
                If oItem.EliminarPRCategoriaRiesgo(Trim(fg.Item(fg.Row, "Categoria")), sUsuario, sPassword, sSucursal) = True Then
                    ActualizarGrid()
                Else
                    MsgBox("El registro se encuentra relacionado con otra tabla", MsgBoxStyle.Information, "M�dulo - Asociados")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnConsultar1_Click(sender As Object, e As EventArgs) Handles btnConsultar1.Click
        Try
            Dim dr As DataRow, oItem As New wrCredito.wsLibCred
            Dim frm As frmDCategoriaRiesgo = New frmDCategoriaRiesgo

            If fg.Row <> -1 Then
                frm.btnGuardar1.Text = "&Modificar"
                frm.btnGuardar1.Visible = False
                ds = oItem.ConsultarPRCategoriaRiesgo("*", "Categoria='" & Trim(fg.Item(fg.Row, "Categoria")) & "'", "", sUsuario, sPassword, sSucursal)
                dr = ds.Tables(0).Rows(0)
                If Not dr("Categoria") Is DBNull.Value Then
                    frm.txtCategoria.Text = CStr(dr("Categoria"))
                    frm.txtCategoria.ReadOnly = True
                End If
                If Not dr("DiaDesde") Is DBNull.Value Then
                    frm.txtDesde.Text = CInt(dr("DiaDesde"))
                End If
                If Not dr("DiaHasta") Is DBNull.Value Then
                    frm.txtHasta.Text = CInt(dr("DiaHasta"))
                End If
                If Not dr("PorcentajeRiesgo") Is DBNull.Value Then
                    frm.txtProcentaje.Text = CDbl(dr("PorcentajeRiesgo"))
                End If
                If Not dr("Rango1") Is DBNull.Value Then
                    frm.txtRango1.Text = CDbl(dr("Rango1"))
                End If
                If Not dr("Rango2") Is DBNull.Value Then
                    frm.txtRango2.Text = CDbl(dr("Rango2"))
                End If
                frm.StartPosition = FormStartPosition.CenterScreen
                frm.ShowDialog()
                ActualizarGrid()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
