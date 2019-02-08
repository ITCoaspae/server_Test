Public Class frmMsNivelContab
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
        'frmMsNivelContab
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(532, 157)
        Me.MaximumSize = New System.Drawing.Size(532, 157)
        Me.MinimumSize = New System.Drawing.Size(532, 157)
        Me.Name = "frmMsNivelContab"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmMsNivelContab_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCat As wrConta.wsLibContab, ds As New Data.DataSet, oRow As Data.DataRow
        If Me.IdNivel <> "" Then
            Try
                oCat = New wrConta.wsLibContab
                ds = oCat.ObtenerNivelesContab(wrConta.TiposNivel.Contable, "*", "Nivel='" & Me.IdNivel.Trim & "'", "Nivel", sUsuario, sPassword, sSucursal)
                oRow = ds.Tables(0).Rows(0)
                Me.txtIdCuenta.Text = oRow.Item("Nivel")
                Me.nudNivel.Value = oRow.Item("Digitos")
            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla Niveles- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

        ofrm.Text = "Buscar Nivel Contable"
        Dim oCat As wrConta.wsLibContab = New wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oCat = New wrConta.wsLibContab
            ds = oCat.ObtenerNivelesContab(wrConta.TiposNivel.Contable, "*", "", "Nivel", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            sTexto = ofrm.Resultado.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Niveles- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Insertar()
        Dim oCat As wrConta.wsLibContab = New wrConta.wsLibContab, pCampos As String, pValores As String
        pCampos = "Nivel,Digitos"
        pValores = "'" & Me.txtIdCuenta.Text.Trim & "'," & Me.nudNivel.Value
        If oCat.InsertaNivelContab(wrConta.TiposNivel.Contable, pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
            MsgBox("Nivel Contable Agregado")
        Else
            MsgBox("Nivel Contable NO Agregado", MsgBoxStyle.Critical, "Error de Validación/Derechos en Cuenta Contable")
        End If
    End Sub

    Private Sub Modificar()
        Dim oCat As wrConta.wsLibContab = New wrConta.wsLibContab
        Dim pIdCuenta As String, pCamposyValores As String
        pIdCuenta = Me.txtIdCuenta.Text.Trim
        pCamposyValores = "Digitos=" & Me.nudNivel.Value
        If oCat.ModificaNivelContab(wrConta.TiposNivel.Contable, pIdCuenta, pCamposyValores, sUsuario, sPassword, sSucursal) = True Then
            MsgBox("Nivel Contable Modificado")
        Else
            MsgBox("Nivel Contable NO Modificado", MsgBoxStyle.Critical, "Error de Validación/Derechos en Cuenta Contable")
        End If
    End Sub

    Private Sub Eliminar()
        Dim oCat As wrConta.wsLibContab = New wrConta.wsLibContab
        Dim pIdCuenta As String
        pIdCuenta = Me.txtIdCuenta.Text.Trim
        If oCat.EliminaNivelContab(wrConta.TiposNivel.Contable, pIdCuenta, sUsuario, sPassword, sSucursal) = True Then
            MsgBox("Nivel Contable Eliminado")
        Else
            MsgBox("Nivel Contable NO Eliminado", MsgBoxStyle.Critical, "Error de Validación/Derechos en Cuenta Contable")
        End If
    End Sub

End Class
