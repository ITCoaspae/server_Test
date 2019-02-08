Public Class frmMSPLDepartamentos
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Public vAccion As String
    Friend WithEvents cbArea As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private oPlan As wrPlanilla.wsLibPlanilla = New wrPlanilla.wsLibPlanilla

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("LogoCoopasICO.ico"), System.Drawing.Icon)

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtCodDepartamento = New System.Windows.Forms.TextBox()
        Me.cbArea = New System.Windows.Forms.ComboBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtCodDepartamento
        '
        Me.txtCodDepartamento.Location = New System.Drawing.Point(165, 87)
        Me.txtCodDepartamento.Name = "txtCodDepartamento"
        Me.txtCodDepartamento.Size = New System.Drawing.Size(312, 21)
        Me.txtCodDepartamento.TabIndex = 72
        '
        'cbArea
        '
        Me.cbArea.DisplayMember = "DESCRIPCION"
        Me.cbArea.FormattingEnabled = True
        Me.cbArea.Location = New System.Drawing.Point(165, 60)
        Me.cbArea.Name = "cbArea"
        Me.cbArea.Size = New System.Drawing.Size(312, 21)
        Me.cbArea.TabIndex = 71
        Me.cbArea.ValueMember = "CODAREA"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(165, 121)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDesc.Size = New System.Drawing.Size(312, 58)
        Me.txtDesc.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Código de Área:"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 16)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Código de Departamento:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(402, 185)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 123
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMSPLDepartamentos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 14)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(501, 257)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtCodDepartamento)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.cbArea)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(501, 257)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(501, 257)
        Me.Name = "frmMSPLDepartamentos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Departamentos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub txtCodArea_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim ds As New Data.DataSet
        Dim ofrm As New frmAGenerico

        Try
            ofrm.Text = "Buscar Códigos de Área"
            ds = oPlan.ConsultarPLAreas("*", "", "CodArea", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            'Me.txtCodArea.Text = ofrm.Resultado
            'Me.txtDescArea.Text = ofrm.Resultado2
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub txtCodArea_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Dim ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        'ds = oPlan.ConsultarPLAreas("*", "CodArea LIKE '" & Trim(Me.txtCodArea.Text) & "%'", "CodArea", sUsuario, sPassword, sSucursal)
        If ds.Tables(0).Rows.Count > 0 Then
            Filas = ds.Tables(0).Rows()
            'Me.txtCodArea.Text = CStr(Filas.Item(0)("CodArea")).Trim
            'Me.txtDescArea.Text = CStr(Filas.Item(0)("Descripcion")).Trim
        Else
            MsgBox("El código de área no existe", MsgBoxStyle.Information, "Módulo - Planilla")
        End If
    End Sub

    Private Sub frmMSPLDepartamentos_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'llenar_cbareas()
        'If Me.vAccion = "Modificar" Then
        '    Dim ds As New Data.DataSet
        '    Dim Filas As Data.DataRowCollection
        '    ' ds = oPlan.ConsultarPLAreas("*", "CodArea LIKE '" & Trim(Me.txtCodArea.Text) & "%'", "CodArea", sUsuario, sPassword, sSucursal)
        '    If ds.Tables(0).Rows.Count > 0 Then
        '        Filas = ds.Tables(0).Rows()
        '        'Me.txtCodArea.Text = CStr(Filas.Item(0)("CodArea")).Trim

        '        'Me.txtDescArea.Text = CStr(Filas.Item(0)("Descripcion")).Trim
        '    Else
        '        MsgBox("El código de área no existe", MsgBoxStyle.Information, "Módulo - Planilla")
        '    End If
        If Me.vAccion = "CONSULTAR" Then
            Me.txtDesc.ReadOnly = True
            Me.txtCodDepartamento.ReadOnly = True
            Me.cbArea.Enabled = False
        ElseIf Me.vAccion = "Modificar" Then
            Me.btnGuardar1.Text = "&Modificar"
        ElseIf Me.vAccion = "Guardar=" Then
            Me.btnGuardar1.Text = "&Guardar"
        End If
    End Sub
    Public Sub llenar_cbareas() 'Fecha de creación 08/03/2012, javier escobar
        Dim Dts As New DataSet
        Dts = oPlan.Consultar_PlAreas(sUsuario, sPassword, sSucursal, 1, "") '1 MUESTRA TODAS LAS AREAS
        Me.cbArea.DataSource = Dts.Tables(0)
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim Campos As String, Valores As String, CamposValores As String
            Dim Resultado As Integer
            If Me.btnGuardar1.Text = "&Guardar" Then

                Resultado = oPlan.Insertar_PlDepartamentos(sUsuario, sPassword, sSucursal, Me.cbArea.SelectedValue, Me.txtCodDepartamento.Text.Trim, Me.txtDesc.Text.Trim, "")
                If Resultado <> 0 Then
                    MsgBox("Los datos fuerón ingresados correctamente", MsgBoxStyle.Information, "Módulo - Planilla ")
                    Me.Dispose()
                Else
                    MsgBox("Los datos no fuerón ingresados correctamente", MsgBoxStyle.Critical, "Módulo - Planilla ")
                End If

            ElseIf Me.btnGuardar1.Text = "&Modificar" Then

                Resultado = oPlan.Modificar_PlDepartamentos(sUsuario, sPassword, sSucursal, Me.cbArea.SelectedValue, Me.txtCodDepartamento.Text.Trim, Me.txtDesc.Text.Trim)
                If Resultado <> 0 Then
                    MsgBox("Los datos fueron actualizados correctamente", MsgBoxStyle.Information, "Módulo - Planilla")
                    Me.Dispose()
                Else
                    MsgBox("Los datos no fueron actualizados correctamente", MsgBoxStyle.Critical, "Módulo - Planilla")
                    Me.Dispose()
                End If


            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
