<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsListaNegra
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbEstado = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtInfComp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRefOficio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNoOficio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkActivo = New System.Windows.Forms.CheckBox()
        Me.txtMotIngreso = New System.Windows.Forms.TextBox()
        Me.cbNacionalidad = New System.Windows.Forms.ComboBox()
        Me.lblNacionalidad = New System.Windows.Forms.Label()
        Me.txtNoRes = New System.Windows.Forms.TextBox()
        Me.lblNoRes = New System.Windows.Forms.Label()
        Me.txtNoPas = New System.Windows.Forms.TextBox()
        Me.lblNoPas = New System.Windows.Forms.Label()
        Me.lblNit = New System.Windows.Forms.Label()
        Me.txtDuiA = New System.Windows.Forms.TextBox()
        Me.txtNit = New C1.Win.C1Input.C1TextBox()
        Me.lblDUI = New System.Windows.Forms.Label()
        Me.lblMotIng = New System.Windows.Forms.Label()
        Me.txtInstReporta = New System.Windows.Forms.TextBox()
        Me.lblInstReporta = New System.Windows.Forms.Label()
        Me.txtNomReport = New System.Windows.Forms.TextBox()
        Me.lblNombreReport = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.btnCerrar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbEstado
        '
        Me.cbEstado.BackColor = System.Drawing.Color.White
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(131, 565)
        Me.cbEstado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(389, 24)
        Me.cbEstado.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 566)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Estado:"
        '
        'txtInfComp
        '
        Me.txtInfComp.BackColor = System.Drawing.Color.White
        Me.txtInfComp.Location = New System.Drawing.Point(131, 388)
        Me.txtInfComp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInfComp.Multiline = True
        Me.txtInfComp.Name = "txtInfComp"
        Me.txtInfComp.Size = New System.Drawing.Size(480, 72)
        Me.txtInfComp.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 388)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 34)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Información " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comp."
        '
        'txtRefOficio
        '
        Me.txtRefOficio.BackColor = System.Drawing.Color.White
        Me.txtRefOficio.Location = New System.Drawing.Point(131, 243)
        Me.txtRefOficio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRefOficio.Multiline = True
        Me.txtRefOficio.Name = "txtRefOficio"
        Me.txtRefOficio.Size = New System.Drawing.Size(480, 57)
        Me.txtRefOficio.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 243)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 34)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Referencia " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del Oficio:"
        '
        'txtNoOficio
        '
        Me.txtNoOficio.BackColor = System.Drawing.Color.White
        Me.txtNoOficio.Location = New System.Drawing.Point(131, 211)
        Me.txtNoOficio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoOficio.Name = "txtNoOficio"
        Me.txtNoOficio.Size = New System.Drawing.Size(160, 22)
        Me.txtNoOficio.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 211)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "No. de Oficio"
        '
        'txtAlias
        '
        Me.txtAlias.BackColor = System.Drawing.Color.White
        Me.txtAlias.Location = New System.Drawing.Point(131, 113)
        Me.txtAlias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(480, 22)
        Me.txtAlias.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 117)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Alias:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(537, 565)
        Me.chkActivo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(68, 21)
        Me.chkActivo.TabIndex = 26
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtMotIngreso
        '
        Me.txtMotIngreso.BackColor = System.Drawing.Color.White
        Me.txtMotIngreso.Location = New System.Drawing.Point(131, 308)
        Me.txtMotIngreso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMotIngreso.Multiline = True
        Me.txtMotIngreso.Name = "txtMotIngreso"
        Me.txtMotIngreso.Size = New System.Drawing.Size(480, 72)
        Me.txtMotIngreso.TabIndex = 11
        '
        'cbNacionalidad
        '
        Me.cbNacionalidad.BackColor = System.Drawing.Color.White
        Me.cbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNacionalidad.FormattingEnabled = True
        Me.cbNacionalidad.Location = New System.Drawing.Point(131, 532)
        Me.cbNacionalidad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbNacionalidad.Name = "cbNacionalidad"
        Me.cbNacionalidad.Size = New System.Drawing.Size(480, 24)
        Me.cbNacionalidad.TabIndex = 23
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Location = New System.Drawing.Point(31, 536)
        Me.lblNacionalidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(90, 17)
        Me.lblNacionalidad.TabIndex = 22
        Me.lblNacionalidad.Text = "Nacionalidad"
        '
        'txtNoRes
        '
        Me.txtNoRes.BackColor = System.Drawing.Color.White
        Me.txtNoRes.Location = New System.Drawing.Point(427, 500)
        Me.txtNoRes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoRes.Name = "txtNoRes"
        Me.txtNoRes.Size = New System.Drawing.Size(184, 22)
        Me.txtNoRes.TabIndex = 21
        '
        'lblNoRes
        '
        Me.lblNoRes.AutoSize = True
        Me.lblNoRes.Location = New System.Drawing.Point(339, 493)
        Me.lblNoRes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoRes.Name = "lblNoRes"
        Me.lblNoRes.Size = New System.Drawing.Size(76, 34)
        Me.lblNoRes.TabIndex = 20
        Me.lblNoRes.Text = "No." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Residente:"
        '
        'txtNoPas
        '
        Me.txtNoPas.BackColor = System.Drawing.Color.White
        Me.txtNoPas.Location = New System.Drawing.Point(131, 500)
        Me.txtNoPas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNoPas.Name = "txtNoPas"
        Me.txtNoPas.Size = New System.Drawing.Size(160, 22)
        Me.txtNoPas.TabIndex = 19
        '
        'lblNoPas
        '
        Me.lblNoPas.AutoSize = True
        Me.lblNoPas.Location = New System.Drawing.Point(31, 493)
        Me.lblNoPas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNoPas.Name = "lblNoPas"
        Me.lblNoPas.Size = New System.Drawing.Size(77, 34)
        Me.lblNoPas.TabIndex = 18
        Me.lblNoPas.Text = "No." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pasaporte:"
        '
        'lblNit
        '
        Me.lblNit.AutoSize = True
        Me.lblNit.Location = New System.Drawing.Point(339, 468)
        Me.lblNit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNit.Name = "lblNit"
        Me.lblNit.Size = New System.Drawing.Size(34, 17)
        Me.lblNit.TabIndex = 16
        Me.lblNit.Text = "NIT:"
        '
        'txtDuiA
        '
        Me.txtDuiA.BackColor = System.Drawing.Color.White
        Me.txtDuiA.Location = New System.Drawing.Point(131, 468)
        Me.txtDuiA.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDuiA.MaxLength = 10
        Me.txtDuiA.Name = "txtDuiA"
        Me.txtDuiA.Size = New System.Drawing.Size(160, 22)
        Me.txtDuiA.TabIndex = 15
        '
        'txtNit
        '
        Me.txtNit.BackColor = System.Drawing.Color.White
        Me.txtNit.EditMask = "0000-000000-000-0"
        Me.txtNit.Location = New System.Drawing.Point(427, 468)
        Me.txtNit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNit.MaxLength = 20
        Me.txtNit.Name = "txtNit"
        Me.txtNit.NumericInput = False
        Me.txtNit.Size = New System.Drawing.Size(185, 25)
        Me.txtNit.TabIndex = 17
        Me.txtNit.Tag = Nothing
        '
        'lblDUI
        '
        Me.lblDUI.AutoSize = True
        Me.lblDUI.Location = New System.Drawing.Point(31, 468)
        Me.lblDUI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDUI.Name = "lblDUI"
        Me.lblDUI.Size = New System.Drawing.Size(35, 17)
        Me.lblDUI.TabIndex = 14
        Me.lblDUI.Text = "DUI:"
        '
        'lblMotIng
        '
        Me.lblMotIng.AutoSize = True
        Me.lblMotIng.Location = New System.Drawing.Point(31, 308)
        Me.lblMotIng.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMotIng.Name = "lblMotIng"
        Me.lblMotIng.Size = New System.Drawing.Size(59, 34)
        Me.lblMotIng.TabIndex = 10
        Me.lblMotIng.Text = "Motivo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ingreso:"
        '
        'txtInstReporta
        '
        Me.txtInstReporta.BackColor = System.Drawing.Color.White
        Me.txtInstReporta.Location = New System.Drawing.Point(131, 145)
        Me.txtInstReporta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtInstReporta.Multiline = True
        Me.txtInstReporta.Name = "txtInstReporta"
        Me.txtInstReporta.Size = New System.Drawing.Size(480, 57)
        Me.txtInstReporta.TabIndex = 5
        '
        'lblInstReporta
        '
        Me.lblInstReporta.AutoSize = True
        Me.lblInstReporta.Location = New System.Drawing.Point(31, 139)
        Me.lblInstReporta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInstReporta.Name = "lblInstReporta"
        Me.lblInstReporta.Size = New System.Drawing.Size(100, 68)
        Me.lblInstReporta.TabIndex = 4
        Me.lblInstReporta.Text = "Institución " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reporta/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Medio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comunicación:"
        '
        'txtNomReport
        '
        Me.txtNomReport.BackColor = System.Drawing.Color.White
        Me.txtNomReport.Location = New System.Drawing.Point(131, 81)
        Me.txtNomReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNomReport.Name = "txtNomReport"
        Me.txtNomReport.Size = New System.Drawing.Size(480, 22)
        Me.txtNomReport.TabIndex = 1
        '
        'lblNombreReport
        '
        Me.lblNombreReport.AutoSize = True
        Me.lblNombreReport.Location = New System.Drawing.Point(31, 74)
        Me.lblNombreReport.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombreReport.Name = "lblNombreReport"
        Me.lblNombreReport.Size = New System.Drawing.Size(95, 34)
        Me.lblNombreReport.TabIndex = 0
        Me.lblNombreReport.Text = "Nombre " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Razón Social:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(403, 597)
        Me.btnGuardar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(100, 34)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 29
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'btnCerrar1
        '
        Me.btnCerrar1.Location = New System.Drawing.Point(511, 597)
        Me.btnCerrar1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCerrar1.Name = "btnCerrar1"
        Me.btnCerrar1.Size = New System.Drawing.Size(100, 34)
        Me.btnCerrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCerrar1.TabIndex = 30
        Me.btnCerrar1.Text = "Cerrar"
        Me.btnCerrar1.UseSelectable = True
        Me.btnCerrar1.UseStyleColors = True
        '
        'frmMsListaNegra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(644, 689)
        Me.Controls.Add(Me.cbEstado)
        Me.Controls.Add(Me.btnCerrar1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtInfComp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblNombreReport)
        Me.Controls.Add(Me.txtRefOficio)
        Me.Controls.Add(Me.txtNomReport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblInstReporta)
        Me.Controls.Add(Me.txtNoOficio)
        Me.Controls.Add(Me.txtInstReporta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblMotIng)
        Me.Controls.Add(Me.txtAlias)
        Me.Controls.Add(Me.lblDUI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNit)
        Me.Controls.Add(Me.chkActivo)
        Me.Controls.Add(Me.txtDuiA)
        Me.Controls.Add(Me.txtMotIngreso)
        Me.Controls.Add(Me.lblNit)
        Me.Controls.Add(Me.cbNacionalidad)
        Me.Controls.Add(Me.lblNoPas)
        Me.Controls.Add(Me.lblNacionalidad)
        Me.Controls.Add(Me.txtNoPas)
        Me.Controls.Add(Me.txtNoRes)
        Me.Controls.Add(Me.lblNoRes)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsListaNegra"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Lista Negra"
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInstReporta As System.Windows.Forms.TextBox
    Friend WithEvents lblInstReporta As System.Windows.Forms.Label
    Friend WithEvents txtNomReport As System.Windows.Forms.TextBox
    Friend WithEvents lblNombreReport As System.Windows.Forms.Label
    Friend WithEvents lblDUI As System.Windows.Forms.Label
    Friend WithEvents lblMotIng As System.Windows.Forms.Label
    Friend WithEvents txtDuiA As System.Windows.Forms.TextBox
    Friend WithEvents txtNit As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNoPas As System.Windows.Forms.TextBox
    Friend WithEvents lblNoPas As System.Windows.Forms.Label
    Friend WithEvents lblNit As System.Windows.Forms.Label
    Friend WithEvents txtNoRes As System.Windows.Forms.TextBox
    Friend WithEvents lblNoRes As System.Windows.Forms.Label
    Friend WithEvents cbNacionalidad As System.Windows.Forms.ComboBox
    Friend WithEvents lblNacionalidad As System.Windows.Forms.Label
    Friend WithEvents txtMotIngreso As System.Windows.Forms.TextBox
    Friend WithEvents chkActivo As System.Windows.Forms.CheckBox
    Friend WithEvents txtInfComp As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRefOficio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNoOficio As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtAlias As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCerrar1 As MetroFramework.Controls.MetroButton
End Class
