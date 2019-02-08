Imports sifLib.Contabilidad
Imports C1.Win.C1FlexGrid


Public Class frmMCatContab
    Inherits frmCat
    Private iRow As Integer, ds As Data.DataSet = New Data.DataSet
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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        '
        'frmMCatContab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(760, 470)
        Me.Name = "frmMCatContab"

    End Sub

#End Region

    Private Sub frmCatContab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCat As wrConta.wsLibContab

        'lblTitulo.Text = "Catálogo de Cuentas Contables"
        Me.Text = "Mantenimiento Cuentas Contables"
        'Try
        oCat = New wrConta.wsLibContab
        ds = oCat.ObtenerCatContab("*", "", "IdCuenta", sUsuario, sPassword,sSucursal)
        Me.cargarGrid(ds)
        'Catch ex As Exception
        'MessageBox.Show("Error en la recuperación de datos tabla Catalogo" & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub

    Public Overrides Sub btnAgregarOnClick()
        Dim frm As New frmDtCatalogoContable 'frmMsCatContab
        With frm
            .acccionP = 1
            .ShowDialog()
        End With
        'frm.Text = "Catálogo Contable- Insertar Cuenta"
        'frm.btnAceptar.Text = "Insertar"
        'frm.ShowDialog()
        RefrescaGrid()
    End Sub

    Public Overrides Sub btnModificarOnClick()
        Dim frm As New frmDtCatalogoContable 'frmMsCatContab
        With frm
            .acccionP = 2
            .idCuentaP = Me.IdCuenta
            .ShowDialog()
        End With
        frm.Text = "Catálogo Contable- Modificar Cuenta"
        'frm.txtIdCuenta.Enabled = False
        'frm.btnBuscar.Enabled = False
        'frm.btnAceptar.Text = "Modificar"
        'frm.IdCuenta = Me.IdCuenta
        'frm.ShowDialog()
        RefrescaGrid()
    End Sub

    Public Overrides Sub btnEliminarOnClick()
        If MsgBox("Desea eliminar la cuenta: " & Me.IdCuenta.ToString.Trim, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If contabilidad.EliminaCuentaContab(Me.IdCuenta, sUsuario, sPassword, sSucursal) = True Then
                MsgBox("Cuenta Contable Eliminada")
            Else
                MsgBox("Cuenta Contable NO Eliminada", MsgBoxStyle.Critical, "Error de Validación/Derechos en Cuenta Contable")
            End If
            RefrescaGrid()
        End If

        'Dim frm As New frmMsCatContab
        'frm.Text = "Catálogo Contable- Eliminar Cuenta"
        'frm.txtIdCuenta.Enabled = False
        'frm.btnBuscar.Enabled = False
        'frm.txtDescripcion.Enabled = False
        'frm.nudNivel.Enabled = False
        'frm.cmbTipoCuenta.Enabled = False
        'frm.txtCtaDependencia.Enabled = False
        'frm.btnBuscar2.Enabled = False
        'frm.cmbFinal.Enabled = False
        'frm.chkInhabilitada.Enabled = False
        'frm.chkLegal.Enabled = False
        'frm.btnAceptar.Text = "Eliminar"
        'frm.IdCuenta =
        'frm.ShowDialog()
        'RefrescaGrid()
    End Sub

    Public Overrides Sub btnBuscarOnClick()
        Dim frm As New frmAGenerico
        Dim sTexto As String

        frm.Text = "Buscar Cuenta Contable"
        Dim oCat As wrConta.wsLibContab, ds As New Data.DataSet, ds2 As New Data.DataSet
        Try
            oCat = New wrConta.wsLibContab
            ds = oCat.ObtenerCatContab("Idcuenta,Descripcion", "", "IdCuenta", sUsuario, sPassword,sSucursal)
            frm.Datos = ds
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.ShowDialog()
            If frm.Resultado.Trim = "" Then   'Filtrar Registros

                C1fgrdCat.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                ds = oCat.ObtenerCatContab("*", "", "IdCuenta", sUsuario, sPassword,sSucursal)
                Me.cargarGrid(ds)
            ElseIf frm.Resultado.Trim <> "" Then
                sTexto = frm.Resultado.Trim
                C1fgrdCat.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
                ds = oCat.ObtenerCatContab("*", "IdCuenta='" & sTexto & "'", "IdCuenta", sUsuario, sPassword,sSucursal)
                Me.cargarGrid(ds)
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catalogo- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Overrides Sub C1fgrdCatOnDoubleClick()
        iRow = Me.C1fgrdCat.RowSel
        Me.IdCuenta = ds.Tables(0).Rows(iRow - 1).Item(0)
    End Sub
    Public Overrides Sub c1fgrdCatOnClic()
        iRow = Me.C1fgrdCat.RowSel
        Me.IdCuenta = ds.Tables(0).Rows(iRow - 1).Item(0)
    End Sub

    Private Sub RefrescaGrid()
        Dim oCat As wrConta.wsLibContab
        Try
            oCat = New wrConta.wsLibContab
            ds = oCat.ObtenerCatContab("*", "", "IdCuenta", sUsuario, sPassword,sSucursal)
            C1fgrdCat.Clear(C1.Win.C1FlexGrid.ClearFlags.UserData)
            Me.cargarGrid(ds)
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Catalogo" & "System Error: " & ex.Message.ToString(), "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub cargarGrid(ByVal pds As System.Data.DataSet)
        Dim dr As System.Data.DataRow, x As Integer = 0
        Dim range As CellRange
        C1fgrdCat.DataSource = pds.Tables(0)
        'C1fgrdCat.Rows.Count = pds.Tables(0).Rows.Count + 1
        'C1fgrdCat.Rows.Fixed = 1
        'C1fgrdCat.Cols.Fixed = 1
        'C1fgrdCat.Cols.Count = pds.Tables(0).Columns.Count + 1
        'C1fgrdCat.Tree.Column = 1

        'C1fgrdCat(0, 1) = "Cuenta"
        'C1fgrdCat(0, 2) = "Descripcion"
        'C1fgrdCat(0, 3) = "Nivel"
        'C1fgrdCat(0, 4) = "Tipo_Cuenta"
        'C1fgrdCat(0, 5) = "Cuenta_Dependencia"
        'C1fgrdCat(0, 6) = "Final"
        'C1fgrdCat(0, 7) = "Legal"
        'C1fgrdCat(0, 8) = "Cod_CCosto"
        'C1fgrdCat(0, 9) = "CuentaComun"
        'C1fgrdCat(0, 10) = "Inhabilitado"




        'C1fgrdCat.Rows(2).IsNode = True
        'C1fgrdCat.Rows(2).Node.Level = 1

        'C1fgrdCat.Rows(3).IsNode = True
        'C1fgrdCat.Rows(3).Node.Level = 2

        'C1fgrdCat.Rows.Fixed = 1
        'C1fgrdCat.Cols.Fixed = 1
        'C1fgrdCat.Cols.Count = pds.Tables(0).Columns.Count + 1
        'C1fgrdCat.Tree.Column = 1
        'C1fgrdCat.Cols(1).Width = 200
        'C1fgrdCat.Cols(2).Width = 300
        'For Each dr In pds.Tables(0).Rows
        '    x += 1
        '    'DoGroup(x, dr("Nivel"))
        '    C1fgrdCat(x, 1) = dr("IdCuenta")
        '    C1fgrdCat(x, 2) = dr("Descripcion")
        '    C1fgrdCat(x, 3) = dr("Nivel")
        '    C1fgrdCat(x, 4) = dr("Tipo_Cuenta")
        '    C1fgrdCat(x, 5) = dr("Cta_Dependencia")
        '    C1fgrdCat(x, 6) = dr("Final")
        '    C1fgrdCat(x, 7) = dr("Legal")
        '    C1fgrdCat(x, 8) = dr("Cod_CCosto")
        '    C1fgrdCat(x, 9) = dr("CuentaComun")
        '    C1fgrdCat(x, 10) = dr("Inhabilitado")
        '    C1fgrdCat.Rows(x).IsNode = True

        '    C1fgrdCat.Rows(x).Node.Level = dr("Nivel")
        '    If dr("Nivel") = 0 Then
        '        range = C1fgrdCat.GetCellRange(x, 1)
        '        range.Image = PictureBox1.Image
        '        If dr("Final") = "S" Then
        '            range.Image = PictureBox5.Image
        '        End If
        '    ElseIf dr("Nivel") = 1 Then
        '        range = C1fgrdCat.GetCellRange(x, 1)
        '        range.Image = PictureBox2.Image
        '        If dr("Final") = "S" Then
        '            range.Image = PictureBox5.Image
        '        End If
        '    ElseIf dr("Nivel") = 2 Then
        '        range = C1fgrdCat.GetCellRange(x, 1)
        '        range.Image = PictureBox3.Image
        '        If dr("Final") = "S" Then
        '            range.Image = PictureBox5.Image
        '        End If
        '    Else
        '        range = C1fgrdCat.GetCellRange(x, 1)
        '        range.Image = PictureBox4.Image
        '        If dr("Final") = "S" Then
        '            range.Image = PictureBox5.Image
        '        End If
        '    End If
        'Next
        'x = 0
        'For Each dr In pds.Tables(0).Rows
        '    x += 1
        '    If dr("Nivel") = 0 Then
        '        C1fgrdCat.Rows(x).Node.Collapsed = False
        '    ElseIf dr("Nivel") = 1 Then
        '        C1fgrdCat.Rows(x).Node.Collapsed = False
        '    Else
        '        C1fgrdCat.Rows(x).Node.Collapsed = False
        '    End If
        'Next
    End Sub

End Class
