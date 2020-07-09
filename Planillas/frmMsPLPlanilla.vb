Imports CrystalDecisions.CrystalReports
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Windows.Forms.CrystalReportViewer

Public Class frmMsPLPlanilla
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager

    Dim oPlan As New wrPlanilla.wsLibPlanilla, dsPlan As New DataSet
    Friend WithEvents rbPRIMERAQUIN As System.Windows.Forms.RadioButton
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents rbSEGQUINCENA As System.Windows.Forms.RadioButton

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("logo.ico"), System.Drawing.Icon)

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
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDepto As System.Windows.Forms.TextBox
    Friend WithEvents txtCodDepartamento As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodTipoPlanilla As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoPlanilla As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.rbSEGQUINCENA = New System.Windows.Forms.RadioButton()
        Me.rbPRIMERAQUIN = New System.Windows.Forms.RadioButton()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNoPlanilla = New System.Windows.Forms.TextBox()
        Me.txtDepto = New System.Windows.Forms.TextBox()
        Me.txtCodDepartamento = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodTipoPlanilla = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'rbSEGQUINCENA
        '
        Me.rbSEGQUINCENA.AutoSize = True
        Me.rbSEGQUINCENA.Location = New System.Drawing.Point(448, 139)
        Me.rbSEGQUINCENA.Name = "rbSEGQUINCENA"
        Me.rbSEGQUINCENA.Size = New System.Drawing.Size(117, 17)
        Me.rbSEGQUINCENA.TabIndex = 91
        Me.rbSEGQUINCENA.TabStop = True
        Me.rbSEGQUINCENA.Text = "Segunda Quincena"
        Me.rbSEGQUINCENA.UseVisualStyleBackColor = True
        '
        'rbPRIMERAQUIN
        '
        Me.rbPRIMERAQUIN.AutoSize = True
        Me.rbPRIMERAQUIN.Location = New System.Drawing.Point(333, 138)
        Me.rbPRIMERAQUIN.Name = "rbPRIMERAQUIN"
        Me.rbPRIMERAQUIN.Size = New System.Drawing.Size(109, 17)
        Me.rbPRIMERAQUIN.TabIndex = 90
        Me.rbPRIMERAQUIN.TabStop = True
        Me.rbPRIMERAQUIN.Text = "Primera Quincena"
        Me.rbPRIMERAQUIN.UseVisualStyleBackColor = True
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(287, 162)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaFin.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(267, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "al"
        '
        'chkTodos
        '
        Me.chkTodos.Checked = True
        Me.chkTodos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTodos.Location = New System.Drawing.Point(493, 62)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(72, 16)
        Me.chkTodos.TabIndex = 1
        Me.chkTodos.Text = "&Todos"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(157, 162)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaInicio.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 29)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Fecha proceso de Planilla:"
        '
        'txtNoPlanilla
        '
        Me.txtNoPlanilla.BackColor = System.Drawing.Color.White
        Me.txtNoPlanilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoPlanilla.Enabled = False
        Me.txtNoPlanilla.Location = New System.Drawing.Point(157, 136)
        Me.txtNoPlanilla.MaxLength = 10
        Me.txtNoPlanilla.Name = "txtNoPlanilla"
        Me.txtNoPlanilla.ReadOnly = True
        Me.txtNoPlanilla.Size = New System.Drawing.Size(170, 20)
        Me.txtNoPlanilla.TabIndex = 87
        '
        'txtDepto
        '
        Me.txtDepto.BackColor = System.Drawing.Color.White
        Me.txtDepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDepto.Enabled = False
        Me.txtDepto.Location = New System.Drawing.Point(228, 110)
        Me.txtDepto.MaxLength = 100
        Me.txtDepto.Name = "txtDepto"
        Me.txtDepto.ReadOnly = True
        Me.txtDepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDepto.Size = New System.Drawing.Size(337, 20)
        Me.txtDepto.TabIndex = 85
        '
        'txtCodDepartamento
        '
        Me.txtCodDepartamento.BackColor = System.Drawing.Color.White
        Me.txtCodDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodDepartamento.Enabled = False
        Me.txtCodDepartamento.Location = New System.Drawing.Point(157, 110)
        Me.txtCodDepartamento.MaxLength = 10
        Me.txtCodDepartamento.Name = "txtCodDepartamento"
        Me.txtCodDepartamento.ReadOnly = True
        Me.txtCodDepartamento.Size = New System.Drawing.Size(65, 20)
        Me.txtCodDepartamento.TabIndex = 1
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.White
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(157, 84)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(408, 20)
        Me.txtDescripcion.TabIndex = 82
        '
        'txtCodTipoPlanilla
        '
        Me.txtCodTipoPlanilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodTipoPlanilla.Location = New System.Drawing.Point(157, 58)
        Me.txtCodTipoPlanilla.MaxLength = 10
        Me.txtCodTipoPlanilla.Name = "txtCodTipoPlanilla"
        Me.txtCodTipoPlanilla.Size = New System.Drawing.Size(104, 20)
        Me.txtCodTipoPlanilla.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "No. de Planilla:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 84
        Me.Label3.Text = "Departamento:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 17)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Código de Tipo Planilla:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(490, 189)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 136
        Me.btnGuardar1.Text = "&Generar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(359, 189)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(125, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 137
        Me.MetroButton1.Text = "&Cierre de Planilla"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'frmMsPLPlanilla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(590, 254)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.rbSEGQUINCENA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.rbPRIMERAQUIN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkTodos)
        Me.Controls.Add(Me.txtCodTipoPlanilla)
        Me.Controls.Add(Me.txtNoPlanilla)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtCodDepartamento)
        Me.Controls.Add(Me.txtDepto)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(590, 254)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(590, 254)
        Me.Name = "frmMsPLPlanilla"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Generación de Planilla"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub txtCodTipoPlanilla_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodTipoPlanilla.DoubleClick
        Dim ofrm As New frmAGenerico
        Dim ds As New Data.DataSet
        Dim sResultado1, sResultado2 As String

        Try
            ofrm.Text = "Buscar Tipos de Planilla..."
            ds = oPlan.ConsultarPLTipoPlanilla("*", "", "CodTipoPlanilla", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            sResultado1 = ofrm.Resultado.Trim
            sResultado2 = ofrm.Resultado2.Trim
            Me.txtCodTipoPlanilla.Text = sResultado1
            Me.txtDescripcion.Text = sResultado2
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub txtCodDepartamento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodDepartamento.DoubleClick
        Dim ofrm As New frmAGenerico
        Dim ds As New Data.DataSet
        Try
            ofrm.Text = "Buscar Departamentos..."
            ds = oPlan.ConsultarPLDepartamentos("*", "", "CodDepartamento", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCodDepartamento.Text = ofrm.Resultado2.Trim
            Me.txtDepto.Text = ofrm.Resultado3.Trim
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub



    Private Sub chkTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkTodos.CheckedChanged
        If Me.chkTodos.Checked = False Then
            Me.txtCodDepartamento.Enabled = True
            Me.txtCodDepartamento.ReadOnly = False
        Else
            Me.txtCodDepartamento.Enabled = False
            Me.txtCodDepartamento.ReadOnly = True
        End If
    End Sub



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim ds As New DataSet

            If Me.txtCodTipoPlanilla.Text.Trim = "" Then
                MsgBox("Seleccione el tipo de planilla.", MsgBoxStyle.OkOnly And MsgBoxStyle.Information, "Generación de Planillas")
                Exit Sub
            End If
            Dim quincena As Integer
            If Me.txtCodTipoPlanilla.Text.Trim = "1" Then

                If Me.chkTodos.Checked = True Then

                    If Me.rbPRIMERAQUIN.Checked = True Or Me.rbSEGQUINCENA.Checked = True Then

                        If Me.rbPRIMERAQUIN.Checked = True Then
                            quincena = 1
                        ElseIf Me.rbSEGQUINCENA.Checked = True Then
                            quincena = 2
                        End If
                    End If
                    ds = oPlan.GeneraPlanilla(Me.txtCodTipoPlanilla.Text.Trim, "", Me.dtpFechaInicio.Value, Me.dtpFechaFin.Value, False, "", "", "", Now, sUsuario, sPassword, sSucursal, 0, quincena)

                Else
                    ds = oPlan.GeneraPlanilla(Me.txtCodTipoPlanilla.Text.Trim, Me.txtCodDepartamento.Text.Trim, Me.dtpFechaInicio.Value, Me.dtpFechaFin.Value, False, "", "", "", Now, sUsuario, sPassword, sSucursal, 0, quincena)
                End If
                Dim ofrm As New frmVisor(ds, 43, 0)
                ofrm.WindowState = FormWindowState.Maximized
                ofrm.Show()


            End If
            Me.MetroButton1.Enabled = True
            dsPlan = ds
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        If Val(MsgBox("¿Está seguro que desea generar cierre de planilla?", MsgBoxStyle.YesNo, "Módulo - Planilla") = MsgBoxResult.Yes) Then
            Try
                If Me.rbPRIMERAQUIN.Checked = True Or Me.rbSEGQUINCENA.Checked = True Then
                    Dim quincena As Integer
                    If Me.rbPRIMERAQUIN.Checked = True Then
                        quincena = 1
                    ElseIf Me.rbSEGQUINCENA.Checked = True Then
                        quincena = 2
                    End If
                    My.Forms.frmMPLPlanilla.Dispose()
                    Dim vNoPlanilla As String
                    vNoPlanilla = oPlan.CierrePlanilla(Me.txtCodTipoPlanilla.Text.Trim, Me.dtpFechaInicio.Value, Me.dtpFechaFin.Value, dsPlan, sUsuario, sPassword, sSucursal, quincena)
                    Me.txtNoPlanilla.Text = vNoPlanilla
                    MsgBox("Cierre realizado exitosamente", MsgBoxStyle.Information, "Módulo - Plailla")
                Else
                    MsgBox("Por favor seleccione la quincena", MsgBoxStyle.Information, "Módulo - Plailla")
                End If

            Catch ex As Exception
                 MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            End Try


        End If
    End Sub

    Private Sub txtCodTipoPlanilla_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCodTipoPlanilla.Validating

        Dim ds As New Data.DataSet, dr As DataRow

        Try
            ds = oPlan.ConsultarPLTipoPlanilla("*", "CodTipoPlanilla='" & Me.txtCodTipoPlanilla.Text.Trim & "'", "CodTipoPlanilla", sUsuario, sPassword, sSucursal)
            If ds.Tables(0).Rows.Count > 0 Then
                dr = ds.Tables(0).Rows(0)
                Me.txtCodTipoPlanilla.Text = dr("CodTipoPlanilla")
                Me.txtDescripcion.Text = dr("Descripcion")
            End If
        Catch ex As Exception
            MsgBox("Error en la recuperación de los datos. Módulo - Planilla", MsgBoxStyle.Critical, "Módulo - Planilla")
        End Try
    End Sub

    Private Sub frmMsPLPlanilla_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            Dim FILTRO As String = ""
            frmMPLPlanilla.ActualizaGrid(FILTRO)

        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
