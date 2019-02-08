Public Class frmMsCatBenef
    Inherits frmAMto 'SIF_ERP.frmAMto
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtComentario As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtComentario = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(23, 218)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 24)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Comentario"
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(126, 215)
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentario.Size = New System.Drawing.Size(384, 20)
        Me.txtComentario.TabIndex = 25
        '
        'frmMsCatBenef
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(522, 326)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtComentario)
        Me.Name = "frmMsCatBenef"
        Me.Controls.SetChildIndex(Me.txtComentario, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmMsCatBenef_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim y As Integer
        Dim oCat As wrConta.wsLibContab, ds As New Data.DataSet, oRow As Data.DataRow
        Dim sTipoC() As String = {"B - Beneficios"}
        Dim sFinal() As String = {"S - Si", "N - No"}
        For y = 0 To sTipoC.GetUpperBound(0)
            cmbTipoCuenta.Items.Add(sTipoC(y))
        Next
        For y = 0 To sFinal.GetUpperBound(0)
            cmbFinal.Items.Add(sFinal(y))
        Next
        If Me.IdCuenta <> "" Then
            Try
                oCat = New wrConta.wsLibContab
                ds = oCat.ObtenerCatBeneficio("*", "Cod_CBeneficio='" & Me.IdCuenta.Trim & "'", "Cod_CBeneficio", sUsuario, sPassword,sSucursal)
                oRow = ds.Tables(0).Rows(0)
                Me.txtIdCuenta.Text = oRow.Item("Cod_CBeneficio")
                Me.txtDescripcion.Text = oRow.Item("Descripcion")
                Me.nudNivel.Value = oRow.Item("IdNivelCB")
                Me.cmbTipoCuenta.Text = oRow.Item("Tipo_Cuenta")
                Me.txtCtaDependencia.Text = oRow.Item("Cta_Dependencia")
                Me.cmbFinal.Text = oRow.Item("Final")
                Me.txtComentario.Text = oRow.Item("Comentario")
            Catch ex As Exception
                MessageBox.Show("Error en la recuperación de datos tabla Cat_CBeneficios- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Me.IdCuenta = ""
        Me.Close()
    End Sub

    Public Overrides Sub btnCancelarOnClick()
        Me.IdCuenta = ""
    End Sub

    Public Overrides Sub btnBuscarOnClick()
        Generico()
        txtIdCuenta.Text = sTexto
    End Sub

    Public Overrides Sub btnBuscar2OnClick()
        Generico()
        txtCtaDependencia.Text = sTexto
    End Sub

    Private Sub Generico()
        Dim ofrm As New frmAGenerico

        ofrm.Text = "Buscar Cuenta Centro de Costos"
        Dim oCat As wrConta.wsLibContab = New wrConta.wsLibContab, ds As New Data.DataSet
        Try
            oCat = New wrConta.wsLibContab
            ds = oCat.ObtenerCatBeneficio("Cod_CBeneficio,Descripcion", "", "Cod_CBeneficio", sUsuario, sPassword,sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            sTexto = ofrm.Resultado.Trim
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Cat_CBeneficios- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Insertar()
        Dim oCat As wrConta.wsLibContab = New wrConta.wsLibContab, pCampos As String, pValores As String
        Dim vTipo As String, vFinal As String
        pCampos = "Cod_CBeneficio,Descripcion,IdNivelCB,Tipo_Cuenta,Cta_Dependencia,Final,Comentario"
        vTipo = Me.cmbTipoCuenta.Text.Trim.Substring(0, 1)
        vFinal = Me.cmbFinal.Text.Trim.Substring(0, 1)
        pValores = "'" & Me.txtIdCuenta.Text.Trim & "','" & Me.txtDescripcion.Text.Trim & "'," & Me.nudNivel.Value & ",'" & vTipo & "','" & Me.txtCtaDependencia.Text.Trim & "','" & vFinal & "','" & txtComentario.Text.Trim & "'"
        Try
            If oCat.InsertaCuentaBeneficio(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                MsgBox("Cuenta Beneficios Agregada")
            Else
                MsgBox("Cuenta Beneficios NO Agregada, error de validación o derechos de usuario", MsgBoxStyle.Critical, "Error de Validación/Derechos en Cuenta Costos")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Modificar()
        Dim oCat As wrConta.wsLibContab = New wrConta.wsLibContab
        Dim pIdCuenta As String, pCamposyValores As String
        Dim vTipo As String, vFinal As String
        vTipo = Me.cmbTipoCuenta.Text.Trim.Substring(0, 1)
        vFinal = Me.cmbFinal.Text.Trim.Substring(0, 1)
        pIdCuenta = Me.txtIdCuenta.Text.Trim
        pCamposyValores = "Descripcion='" & Me.txtDescripcion.Text.Trim & "',IdNivelCB=" & Me.nudNivel.Value & ",Tipo_Cuenta='" & vTipo & "',Cta_Dependencia='" & Me.txtCtaDependencia.Text.Trim & "',Final='" & vFinal & "',Comentario='" & txtComentario.Text.Trim & "'"
        If oCat.ModificaCuentaBeneficio(pIdCuenta, pCamposyValores, sUsuario, sPassword,sSucursal) = True Then
            MsgBox("Cuenta Beneficios Modificada")
        Else
            MsgBox("Cuenta Beneficios NO Modificada, error de validación o derechos de usuario", MsgBoxStyle.Critical, "Error de Validación/Derechos en Cuenta Costos")
        End If
    End Sub

    Private Sub Eliminar()
        Dim oCat As wrConta.wsLibContab = New wrConta.wsLibContab
        Dim pIdCuenta As String
        pIdCuenta = Me.txtIdCuenta.Text.Trim
        If oCat.EliminaCuentaBeneficio(pIdCuenta, sUsuario, sPassword,sSucursal) = True Then
            MsgBox("Cuenta Beneficios Eliminada")
        Else
            MsgBox("Cuenta Beneficios NO Eliminada, error de validación o derechos de usuario", MsgBoxStyle.Critical, "Error de Validación/Derechos en Cuenta Costos")
        End If
    End Sub

End Class
