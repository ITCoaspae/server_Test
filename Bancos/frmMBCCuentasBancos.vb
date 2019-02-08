Public Class frmMBCCuentasBancos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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
    Friend WithEvents btnImp As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents C1fgrdCuentasBancos As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMBCCuentasBancos))
        Me.C1fgrdCuentasBancos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnImp = New MetroFramework.Controls.MetroButton()
        Me.btnDel = New MetroFramework.Controls.MetroButton()
        Me.btnMod = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        CType(Me.C1fgrdCuentasBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1fgrdCuentasBancos
        '
        Me.C1fgrdCuentasBancos.AllowEditing = False
        Me.C1fgrdCuentasBancos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1fgrdCuentasBancos.BackColor = System.Drawing.SystemColors.Window
        Me.C1fgrdCuentasBancos.ColumnInfo = "9,1,0,0,0,85,Columns:0{Width:17;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.C1fgrdCuentasBancos.Location = New System.Drawing.Point(23, 97)
        Me.C1fgrdCuentasBancos.Name = "C1fgrdCuentasBancos"
        Me.C1fgrdCuentasBancos.Size = New System.Drawing.Size(634, 238)
        Me.C1fgrdCuentasBancos.Styles = New C1.Win.C1FlexGrid.CellStyleCollection(resources.GetString("C1fgrdCuentasBancos.Styles"))
        Me.C1fgrdCuentasBancos.TabIndex = 10
        '
        'btnImp
        '
        Me.btnImp.Location = New System.Drawing.Point(266, 63)
        Me.btnImp.Name = "btnImp"
        Me.btnImp.Size = New System.Drawing.Size(75, 28)
        Me.btnImp.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImp.TabIndex = 27
        Me.btnImp.Text = "Consultar"
        Me.btnImp.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImp.UseSelectable = True
        Me.btnImp.UseStyleColors = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(185, 63)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 28)
        Me.btnDel.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnDel.TabIndex = 26
        Me.btnDel.Text = "Eliminar"
        Me.btnDel.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnDel.UseSelectable = True
        Me.btnDel.UseStyleColors = True
        '
        'btnMod
        '
        Me.btnMod.Location = New System.Drawing.Point(104, 63)
        Me.btnMod.Name = "btnMod"
        Me.btnMod.Size = New System.Drawing.Size(75, 28)
        Me.btnMod.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod.TabIndex = 25
        Me.btnMod.Text = "Modificar"
        Me.btnMod.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnMod.UseSelectable = True
        Me.btnMod.UseStyleColors = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(23, 63)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 28)
        Me.btnAdd.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Agregar"
        Me.btnAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnAdd.UseSelectable = True
        Me.btnAdd.UseStyleColors = True
        '
        'frmMBCCuentasBancos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(680, 358)
        Me.Controls.Add(Me.btnImp)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnMod)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.C1fgrdCuentasBancos)
        Me.Name = "frmMBCCuentasBancos"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Cuentas Bancos"
        CType(Me.C1fgrdCuentasBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmMBCCuentasBancos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oLibBco As wrBancos.wsLibBancos, ds As Data.DataSet = New Data.DataSet
            oLibBco = New wrBancos.wsLibBancos
            ds = oLibBco.ObtenerCuentaBanco("*", "", "IdCtaBanco asc", sUsuario, sPassword, sSucursal)
            C1fgrdCuentasBancos.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub C1fgrdAsociados_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1fgrdCuentasBancos.DoubleClick
        btnImp_Click(sender, e)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim ofrm As New frmMsBCCuentaBanco, oLibBco As New wrBancos.wsLibBancos, ds As DataSet
            'ofrm.Accion = AlcalaLibs.Seguridad.clsUsuario.TipoAccion.Insertar
            ofrm.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Insertar
            ofrm.ShowDialog()
            ds = oLibBco.ObtenerCuentaBanco("*", "", "IdCtaBanco", sUsuario, sPassword, sSucursal)
            Me.C1fgrdCuentasBancos.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Try
            Dim ofrm As New frmMsBCCuentaBanco, oLibBco As New wrBancos.wsLibBancos, ds As DataSet
            'ofrm.Accion = AlcalaLibs.Seguridad.clsUsuario.TipoAccion.Modificar
            ofrm.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Modificar
            If C1fgrdCuentasBancos.Row <> -1 Then
                ofrm.txtCodBanco.Text = C1fgrdCuentasBancos.Item(C1fgrdCuentasBancos.Row, "IdBanco")
                ofrm.txtNombreBanco.Text = C1fgrdCuentasBancos.Item(C1fgrdCuentasBancos.Row, "Nom_Banco")
                ofrm.txtCodCuenta.Text = C1fgrdCuentasBancos.Item(C1fgrdCuentasBancos.Row, "IdCtaBanco")
                ofrm.txtCuentaContable.Text = C1fgrdCuentasBancos.Item(C1fgrdCuentasBancos.Row, "IdCuenta")
                ofrm.txtNombreCuenta.Text = C1fgrdCuentasBancos.Item(C1fgrdCuentasBancos.Row, "Nom_Cuenta")
                ofrm.dtpFecApertura.Value = C1fgrdCuentasBancos.Item(C1fgrdCuentasBancos.Row, "Fec_Apertura")
                ofrm.txtCorrCheque.Text = IIf(C1fgrdCuentasBancos.Item(C1fgrdCuentasBancos.Row, "corr_cheque") Is DBNull.Value = True, 0, C1fgrdCuentasBancos.Item(C1fgrdCuentasBancos.Row, "corr_cheque"))
                ofrm.ShowDialog()
            End If
            ds = oLibBco.ObtenerCuentaBanco("*", "", "IdCtaBanco", sUsuario, sPassword, sSucursal)
            Me.C1fgrdCuentasBancos.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Try
            If C1fgrdCuentasBancos.Row <> -1 Then
                If MsgBox("¿Desea eliminar el Registro: " & C1fgrdCuentasBancos.Item(C1fgrdCuentasBancos.Row, "IdCtaBanco") & "?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "Eliminar Cuenta Bancaria") = MsgBoxResult.Yes Then
                    Dim oLibBco As wrBancos.wsLibBancos = New wrBancos.wsLibBancos, ds As DataSet
                    oLibBco.EliminaCuentaBanco(C1fgrdCuentasBancos.Item(C1fgrdCuentasBancos.Row, "IdCtaBanco"), sUsuario, sPassword, sSucursal)
                    ds = oLibBco.ObtenerCuentaBanco("*", "", "IdCtaBanco", sUsuario, sPassword, sSucursal)
                    Me.C1fgrdCuentasBancos.DataSource = ds.Tables(0).DefaultView
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImp_Click(sender As Object, e As EventArgs) Handles btnImp.Click
        Try
            If C1fgrdCuentasBancos.Row <> -1 Then
                Dim ofrm As frmMsBCCuentaBanco = New frmMsBCCuentaBanco
                ofrm.txtCodBanco.Text = C1fgrdCuentasBancos.Item(C1fgrdCuentasBancos.Row, "IdBanco")
                ofrm.txtNombreBanco.Text = C1fgrdCuentasBancos.Item(C1fgrdCuentasBancos.Row, "Nom_Banco")
                ofrm.txtCodCuenta.Text = C1fgrdCuentasBancos.Item(C1fgrdCuentasBancos.Row, "IdCtaBanco")
                ofrm.txtCuentaContable.Text = C1fgrdCuentasBancos.Item(C1fgrdCuentasBancos.Row, "IdCuenta")
                ofrm.txtNombreCuenta.Text = C1fgrdCuentasBancos.Item(C1fgrdCuentasBancos.Row, "Nom_Cuenta")
                ofrm.dtpFecApertura.Value = C1fgrdCuentasBancos.Item(C1fgrdCuentasBancos.Row, "Fec_Apertura")
                ofrm.ShowDialog()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class