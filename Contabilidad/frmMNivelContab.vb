

Public Class frmMNivelContab
    Inherits frmCat
    Private iRow As Integer, ds As Data.DataSet = New Data.DataSet

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'frmMNivelContab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(760, 502)
        Me.Name = "frmMNivelContab"

    End Sub

#End Region

    Private Sub frmMNivelContab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCat As wrConta.wsLibContab
        'lblTitulo.Text = "Maestro de Niveles Contables"
        Me.Text = "Mantenimiento Niveles Contables"
        Try
            oCat = New wrConta.wsLibContab
            ds = oCat.ObtenerNivelesContab(wrConta.TiposCatalogo.Contable, "*", "", "Nivel", sUsuario, sPassword, sSucursal)
            C1fgrdCat.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperaci�n de datos tabla Niveles" & "System Error: " & ex.Message.ToString(), "Error de Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Overrides Sub btnAgregarOnClick()
        Dim frm As New frmMsNivelContab
        frm.Text = "Niveles Cat�logo Contable- Insertar Cuenta"
        frm.btnAceptar.Text = "Insertar"
        frm.ShowDialog()
        RefrescaGrid()
    End Sub

    Public Overrides Sub btnModificarOnClick()
        Dim frm As New frmMsNivelContab
        frm.Text = "Niveles Cat�logo Contable- Modificar Cuenta"
        frm.txtIdCuenta.Enabled = False
        frm.nudNivel.Enabled = True
        frm.btnAceptar.Text = "Modificar"
        frm.IdNivel = Me.IdCuenta
        frm.ShowDialog()
        RefrescaGrid()
    End Sub

    Public Overrides Sub btnEliminarOnClick()
        Dim frm As New frmMsNivelContab
        frm.Text = "Niveles Cat�logo Contable- Eliminar Cuenta"
        frm.txtIdCuenta.Enabled = False
        frm.nudNivel.Enabled = False
        frm.btnAceptar.Text = "Eliminar"
        frm.IdNivel = Me.IdCuenta
        frm.ShowDialog()
        RefrescaGrid()
    End Sub

    Public Overrides Sub btnBuscarOnClick()
        Dim frm As New frmAGenerico
        Dim sTexto As String

        frm.Text = "Buscar Nivel Cat�logo Contable"
        Dim oCat As wrConta.wsLibContab, ds As New Data.DataSet, ds2 As New Data.DataSet
        Try
            oCat = New wrConta.wsLibContab
            ds = oCat.ObtenerNivelesContab(wrConta.TiposCatalogo.Contable, "*", "", "Nivel", sUsuario, sPassword, sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros

                C1fgrdCat.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                ds = oCat.ObtenerNivelesContab(wrConta.TiposCatalogo.Contable, "*", "", "Nivel", sUsuario, sPassword, sSucursal)
                C1fgrdCat.DataSource = ds.Tables(0)
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                C1fgrdCat.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                ds = oCat.ObtenerNivelesContab(wrConta.TiposCatalogo.Contable, "*", "Nivel='" & sTexto & "'", "Nivel", sUsuario, sPassword, sSucursal)
                C1fgrdCat.DataSource = ds.Tables(0)
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperaci�n de datos tabla Niveles- " & "System Error: " & ex.Message.ToString() & " M�todo: " & ex.TargetSite.Name, "Error de Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            ds = oCat.ObtenerNivelesContab(wrConta.TiposCatalogo.Contable, "*", "", "Nivel", sUsuario, sPassword, sSucursal)
            C1fgrdCat.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
            C1fgrdCat.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperaci�n de datos tabla Niveles" & "System Error: " & ex.Message.ToString(), "Error de Aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
