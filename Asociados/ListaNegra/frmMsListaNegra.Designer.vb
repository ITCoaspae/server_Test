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
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Panel1.SuspendLayout()
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cbEstado)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtInfComp)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtRefOficio)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtNoOficio)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtAlias)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.chkActivo)
        Me.Panel1.Controls.Add(Me.txtMotIngreso)
        Me.Panel1.Controls.Add(Me.cbNacionalidad)
        Me.Panel1.Controls.Add(Me.lblNacionalidad)
        Me.Panel1.Controls.Add(Me.txtNoRes)
        Me.Panel1.Controls.Add(Me.lblNoRes)
        Me.Panel1.Controls.Add(Me.txtNoPas)
        Me.Panel1.Controls.Add(Me.lblNoPas)
        Me.Panel1.Controls.Add(Me.lblNit)
        Me.Panel1.Controls.Add(Me.txtDuiA)
        Me.Panel1.Controls.Add(Me.txtNit)
        Me.Panel1.Controls.Add(Me.lblDUI)
        Me.Panel1.Controls.Add(Me.lblMotIng)
        Me.Panel1.Controls.Add(Me.txtInstReporta)
        Me.Panel1.Controls.Add(Me.lblInstReporta)
        Me.Panel1.Controls.Add(Me.txtNomReport)
        Me.Panel1.Controls.Add(Me.lblNombreReport)
        Me.Panel1.Location = New System.Drawing.Point(23, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 438)
        Me.Panel1.TabIndex = 0
        '
        'cbEstado
        '
        Me.cbEstado.BackColor = System.Drawing.Color.White
        Me.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(80, 408)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(293, 21)
        Me.cbEstado.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 409)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Estado:"
        '
        'txtInfComp
        '
        Me.txtInfComp.BackColor = System.Drawing.Color.White
        Me.txtInfComp.Location = New System.Drawing.Point(80, 264)
        Me.txtInfComp.Multiline = True
        Me.txtInfComp.Name = "txtInfComp"
        Me.txtInfComp.Size = New System.Drawing.Size(361, 59)
        Me.txtInfComp.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 26)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Información " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comp."
        '
        'txtRefOficio
        '
        Me.txtRefOficio.BackColor = System.Drawing.Color.White
        Me.txtRefOficio.Location = New System.Drawing.Point(80, 146)
        Me.txtRefOficio.Multiline = True
        Me.txtRefOficio.Name = "txtRefOficio"
        Me.txtRefOficio.Size = New System.Drawing.Size(361, 47)
        Me.txtRefOficio.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Referencia " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del Oficio:"
        '
        'txtNoOficio
        '
        Me.txtNoOficio.BackColor = System.Drawing.Color.White
        Me.txtNoOficio.Location = New System.Drawing.Point(80, 120)
        Me.txtNoOficio.Name = "txtNoOficio"
        Me.txtNoOficio.Size = New System.Drawing.Size(121, 20)
        Me.txtNoOficio.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "No. de Oficio"
        '
        'txtAlias
        '
        Me.txtAlias.BackColor = System.Drawing.Color.White
        Me.txtAlias.Location = New System.Drawing.Point(80, 41)
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(361, 20)
        Me.txtAlias.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Alias:"
        '
        'chkActivo
        '
        Me.chkActivo.AutoSize = True
        Me.chkActivo.Location = New System.Drawing.Point(385, 408)
        Me.chkActivo.Name = "chkActivo"
        Me.chkActivo.Size = New System.Drawing.Size(56, 17)
        Me.chkActivo.TabIndex = 26
        Me.chkActivo.Text = "Activo"
        Me.chkActivo.UseVisualStyleBackColor = True
        '
        'txtMotIngreso
        '
        Me.txtMotIngreso.BackColor = System.Drawing.Color.White
        Me.txtMotIngreso.Location = New System.Drawing.Point(80, 199)
        Me.txtMotIngreso.Multiline = True
        Me.txtMotIngreso.Name = "txtMotIngreso"
        Me.txtMotIngreso.Size = New System.Drawing.Size(361, 59)
        Me.txtMotIngreso.TabIndex = 11
        '
        'cbNacionalidad
        '
        Me.cbNacionalidad.BackColor = System.Drawing.Color.White
        Me.cbNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbNacionalidad.FormattingEnabled = True
        Me.cbNacionalidad.Location = New System.Drawing.Point(80, 381)
        Me.cbNacionalidad.Name = "cbNacionalidad"
        Me.cbNacionalidad.Size = New System.Drawing.Size(361, 21)
        Me.cbNacionalidad.TabIndex = 23
        '
        'lblNacionalidad
        '
        Me.lblNacionalidad.AutoSize = True
        Me.lblNacionalidad.Location = New System.Drawing.Point(5, 384)
        Me.lblNacionalidad.Name = "lblNacionalidad"
        Me.lblNacionalidad.Size = New System.Drawing.Size(69, 13)
        Me.lblNacionalidad.TabIndex = 22
        Me.lblNacionalidad.Text = "Nacionalidad"
        '
        'txtNoRes
        '
        Me.txtNoRes.BackColor = System.Drawing.Color.White
        Me.txtNoRes.Location = New System.Drawing.Point(302, 355)
        Me.txtNoRes.Name = "txtNoRes"
        Me.txtNoRes.Size = New System.Drawing.Size(139, 20)
        Me.txtNoRes.TabIndex = 21
        '
        'lblNoRes
        '
        Me.lblNoRes.AutoSize = True
        Me.lblNoRes.Location = New System.Drawing.Point(236, 349)
        Me.lblNoRes.Name = "lblNoRes"
        Me.lblNoRes.Size = New System.Drawing.Size(58, 26)
        Me.lblNoRes.TabIndex = 20
        Me.lblNoRes.Text = "No." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Residente:"
        '
        'txtNoPas
        '
        Me.txtNoPas.BackColor = System.Drawing.Color.White
        Me.txtNoPas.Location = New System.Drawing.Point(80, 355)
        Me.txtNoPas.Name = "txtNoPas"
        Me.txtNoPas.Size = New System.Drawing.Size(121, 20)
        Me.txtNoPas.TabIndex = 19
        '
        'lblNoPas
        '
        Me.lblNoPas.AutoSize = True
        Me.lblNoPas.Location = New System.Drawing.Point(5, 349)
        Me.lblNoPas.Name = "lblNoPas"
        Me.lblNoPas.Size = New System.Drawing.Size(58, 26)
        Me.lblNoPas.TabIndex = 18
        Me.lblNoPas.Text = "No." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Pasaporte:"
        '
        'lblNit
        '
        Me.lblNit.AutoSize = True
        Me.lblNit.Location = New System.Drawing.Point(236, 329)
        Me.lblNit.Name = "lblNit"
        Me.lblNit.Size = New System.Drawing.Size(28, 13)
        Me.lblNit.TabIndex = 16
        Me.lblNit.Text = "NIT:"
        '
        'txtDuiA
        '
        Me.txtDuiA.BackColor = System.Drawing.Color.White
        Me.txtDuiA.Location = New System.Drawing.Point(80, 329)
        Me.txtDuiA.MaxLength = 10
        Me.txtDuiA.Name = "txtDuiA"
        Me.txtDuiA.Size = New System.Drawing.Size(121, 20)
        Me.txtDuiA.TabIndex = 15
        '
        'txtNit
        '
        Me.txtNit.BackColor = System.Drawing.Color.White
        Me.txtNit.EditMask = "0000-000000-000-0"
        Me.txtNit.Location = New System.Drawing.Point(302, 329)
        Me.txtNit.MaxLength = 20
        Me.txtNit.Name = "txtNit"
        Me.txtNit.NumericInput = False
        Me.txtNit.Size = New System.Drawing.Size(139, 20)
        Me.txtNit.TabIndex = 17
        Me.txtNit.Tag = Nothing
        '
        'lblDUI
        '
        Me.lblDUI.AutoSize = True
        Me.lblDUI.Location = New System.Drawing.Point(5, 329)
        Me.lblDUI.Name = "lblDUI"
        Me.lblDUI.Size = New System.Drawing.Size(29, 13)
        Me.lblDUI.TabIndex = 14
        Me.lblDUI.Text = "DUI:"
        '
        'lblMotIng
        '
        Me.lblMotIng.AutoSize = True
        Me.lblMotIng.Location = New System.Drawing.Point(5, 199)
        Me.lblMotIng.Name = "lblMotIng"
        Me.lblMotIng.Size = New System.Drawing.Size(45, 26)
        Me.lblMotIng.TabIndex = 10
        Me.lblMotIng.Text = "Motivo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ingreso:"
        '
        'txtInstReporta
        '
        Me.txtInstReporta.BackColor = System.Drawing.Color.White
        Me.txtInstReporta.Location = New System.Drawing.Point(80, 67)
        Me.txtInstReporta.Multiline = True
        Me.txtInstReporta.Name = "txtInstReporta"
        Me.txtInstReporta.Size = New System.Drawing.Size(361, 47)
        Me.txtInstReporta.TabIndex = 5
        '
        'lblInstReporta
        '
        Me.lblInstReporta.AutoSize = True
        Me.lblInstReporta.Location = New System.Drawing.Point(5, 62)
        Me.lblInstReporta.Name = "lblInstReporta"
        Me.lblInstReporta.Size = New System.Drawing.Size(77, 52)
        Me.lblInstReporta.TabIndex = 4
        Me.lblInstReporta.Text = "Institución " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reporta/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Medio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Comunicación:"
        '
        'txtNomReport
        '
        Me.txtNomReport.BackColor = System.Drawing.Color.White
        Me.txtNomReport.Location = New System.Drawing.Point(80, 15)
        Me.txtNomReport.Name = "txtNomReport"
        Me.txtNomReport.Size = New System.Drawing.Size(361, 20)
        Me.txtNomReport.TabIndex = 1
        '
        'lblNombreReport
        '
        Me.lblNombreReport.AutoSize = True
        Me.lblNombreReport.Location = New System.Drawing.Point(5, 9)
        Me.lblNombreReport.Name = "lblNombreReport"
        Me.lblNombreReport.Size = New System.Drawing.Size(73, 26)
        Me.lblNombreReport.TabIndex = 0
        Me.lblNombreReport.Text = "Nombre " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Razón Social:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(321, 507)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 29
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'btnCerrar1
        '
        Me.btnCerrar1.Location = New System.Drawing.Point(402, 507)
        Me.btnCerrar1.Name = "btnCerrar1"
        Me.btnCerrar1.Size = New System.Drawing.Size(75, 28)
        Me.btnCerrar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnCerrar1.TabIndex = 30
        Me.btnCerrar1.Text = "Cerrar"
        Me.btnCerrar1.UseSelectable = True
        Me.btnCerrar1.UseStyleColors = True
        '
        'frmMsListaNegra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(500, 560)
        Me.Controls.Add(Me.btnCerrar1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsListaNegra"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Lista Negra"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtNit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
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
