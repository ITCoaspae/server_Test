Public Class frmMsNivelCostos
    Inherits frmAMtoNiv 'SIF_ERP.frmAMtoNiv
    Private sTexto As String

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
        Me.SuspendLayout()
        '
        'frmMsNivelCostos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(533, 160)
        Me.MaximumSize = New System.Drawing.Size(533, 160)
        Me.MinimumSize = New System.Drawing.Size(533, 160)
        Me.Name = "frmMsNivelCostos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmMsNivelCostos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCat As wrConta.wsLibContab, ds As New Data.DataSet, oRow As Data.DataRow
        If Me.IdNivel <> "" Then
            Try
                oCat = New wrConta.wsLibContab
                ds = oCat.ObtenerNivelesCostos(wrConta.TiposNiveles.Costos, "*", "IdNivelCC='" & Me.IdNivel.Trim & "'", "IdNivelCC", sUsuario, sPassword, sSucursal)
                oRow = ds.Tables(0).Rows(0)
                Me.txtIdCuenta.Text = oRow.Item("IdNivelCC")
                Me.nudNivel.Value = oRow.Item("Digitos")
            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla Niveles_CCostos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Overrides Sub btnAceptarOnClick()
        
        If Me.btnAceptar.Text = "Insertar" Then
            Me.Insertar()
        ElseIf Me.btnAceptar.Text = "Modificar" Then
            Me.Modificar()
        ElseIf Me.btnAceptar.Text = "Eliminar" Then
            Me.Eliminar()
        End If
        Me.IdNivel = ""
        Me.Close()
    End Sub

    Public Overrides Sub btnCancelarOnClick()
        Me.IdNivel = ""
    End Sub

    Private Sub Generico()
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Nivel Centro de Costos"
        Dim oCat As wrConta.wsLibContab = New wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oCat = New wrConta.wsLibContab
            ds = oCat.ObtenerNivelesCostos(wrConta.TiposNiveles.Costos, "*", "", "IdNivelCC", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            sTexto = ofrm.Resultado.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Niveles_CCostos- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Insertar()
        Dim oCat As wrConta.wsLibContab = New wrConta.wsLibContab, pCampos As String, pValores As String
        pCampos = "IdNivelCC,DigitosCC"
        pValores = "'" & Me.txtIdCuenta.Text.Trim & "'," & Me.nudNivel.Value
        If oCat.InsertaNivelCostos(wrConta.TiposNiveles.Costos, pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
            MsgBox("Nivel Centros de Costos Agregado")
        Else
            MsgBox("Nivel Centros de Costos NO Agregado", MsgBoxStyle.Critical, "Error de Validación/Derechos en Cuenta Contable")
        End If
    End Sub

    Private Sub Modificar()
        Dim oCat As wrConta.wsLibContab = New wrConta.wsLibContab
        Dim pIdCuenta As String, pCamposyValores As String
        pIdCuenta = Me.txtIdCuenta.Text.Trim
        pCamposyValores = "DigitosCC=" & Me.nudNivel.Value
        If oCat.ModificaNivelCostos(wrConta.TiposNiveles.Costos, pIdCuenta, pCamposyValores, sUsuario, sPassword, sSucursal) = True Then
            MsgBox("Nivel Centros de Costos Modificado")
        Else
            MsgBox("Nivel Centros de Costos NO Modificado", MsgBoxStyle.Critical, "Error de Validación/Derechos en Cuenta Contable")
        End If
    End Sub

    Private Sub Eliminar()
        Dim oCat As wrConta.wsLibContab = New wrConta.wsLibContab
        Dim pIdCuenta As String
        pIdCuenta = Me.txtIdCuenta.Text.Trim
        If oCat.EliminaNivelCostos(wrConta.TiposNiveles.Costos, pIdCuenta, sUsuario, sPassword, sSucursal) = True Then
            MsgBox("Nivel Centros de Costos Eliminado")
        Else
            MsgBox("Nivel Centros de Costos NO Eliminado", MsgBoxStyle.Critical, "Error de Validación/Derechos en Cuenta Contable")
        End If
    End Sub

End Class
