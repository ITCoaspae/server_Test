Public Class frmMCatBeneficios
    Inherits frmCat
    Private ds As Data.DataSet = New Data.DataSet, iRow As Integer

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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'frmMCatBeneficios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(760, 502)
        Me.Name = "frmMCatBeneficios"

    End Sub

#End Region

    Private Sub frmCatBeneficios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCat As wrConta.wsLibContab
        'lblTitulo.Text = "Catálogo de Centros de Beneficios"
        Me.Text = "Mantenimiento Cuentas Centros de Beneficios"
        Me.Text = "Mantenimiento Cuentas Contables"
        Try
            oCat = New wrConta.wsLibContab
            ds = oCat.ObtenerCatBeneficio("*", "", "Cod_CBeneficio", sUsuario, sPassword, sSucursal)
            C1fgrdCat.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Cat_CBeneficios" & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Overrides Sub btnAgregarOnClick()
        Dim frm As New frmMsCatBenef
        frm.Text = "Catálogo Centros de Beneficios- Insertar Cuenta"
        frm.btnAceptar.Text = "Insertar"
        frm.ShowDialog()
        RefrescaGrid()
    End Sub

    Public Overrides Sub btnModificarOnClick()
        Dim frm As New frmMsCatBenef
        frm.Text = "Catálogo Centros de Beneficios- Modificar Cuenta"
        ' frm.lblTitulo.Text = "Catálogo Centros de Beneficios- Modificar Cuenta"
        frm.txtIdCuenta.Enabled = False
        frm.btnBuscar.Enabled = False
        frm.btnAceptar.Text = "Modificar"
        frm.IdCuenta = Me.IdCuenta
        frm.ShowDialog()
        RefrescaGrid()
    End Sub

    Public Overrides Sub btnEliminarOnClick()
        Dim frm As New frmMsCatBenef
        frm.Text = "Catálogo Centros de Beneficios- Eliminar Cuenta"
        frm.txtIdCuenta.Enabled = False
        frm.btnBuscar.Enabled = False
        frm.txtDescripcion.Enabled = False
        frm.nudNivel.Enabled = False
        frm.cmbTipoCuenta.Enabled = False
        frm.txtCtaDependencia.Enabled = False
        frm.btnBuscar2.Enabled = False
        frm.cmbFinal.Enabled = False
        frm.txtComentario.Enabled = False
        frm.btnAceptar.Text = "Eliminar"
        frm.IdCuenta = Me.IdCuenta
        frm.ShowDialog()
        RefrescaGrid()
    End Sub

    Public Overrides Sub btnBuscarOnClick()
        Dim frm As New frmAGenerico
        Dim sTexto As String

        frm.Text = "Buscar Cuenta Centros de Beneficios"
        Dim oCat As wrConta.wsLibContab, ds As New Data.DataSet, ds2 As New Data.DataSet
        Try
            oCat = New wrConta.wsLibContab
            ds = oCat.ObtenerCatBeneficio("Cod_CBeneficio,Descripcion", "", "Cod_CBeneficio", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros

                C1fgrdCat.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                ds = oCat.ObtenerCatBeneficio("*", "", "Cod_CBeneficio", sUsuario, sPassword, sSucursal)
                C1fgrdCat.DataSource = ds.Tables(0)
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                C1fgrdCat.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                ds = oCat.ObtenerCatBeneficio("*", "Cod_CBeneficio='" & sTexto & "'", "Cod_CBeneficio", sUsuario, sPassword, sSucursal)
                C1fgrdCat.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Cat_CBeneficios- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Overrides Sub C1fgrdCatOnDoubleClick()
        iRow = Me.C1fgrdCat.RowSel
        Me.IdCuenta = ds.Tables(0).Rows(iRow - 1).Item(0)
    End Sub

    Private Sub RefrescaGrid()
        Dim oCat As wrConta.wsLibContab
        Try
            oCat = New wrConta.wsLibContab
            ds = oCat.ObtenerCatBeneficio("*", "", "Cod_CBeneficio", sUsuario, sPassword, sSucursal)
            C1fgrdCat.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
            C1fgrdCat.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Cat_CBeneficios" & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
