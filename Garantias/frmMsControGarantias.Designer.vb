<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsControGarantias
    Inherits System.Windows.Forms.Form

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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbEstadoGarantia = New System.Windows.Forms.ComboBox()
        Me.lblEstadoGarantia = New System.Windows.Forms.Label()
        Me.chbMostrarTodos = New System.Windows.Forms.CheckBox()
        Me.cbESTADOINSCRIPCION = New System.Windows.Forms.ComboBox()
        Me.lblEstadoInscripcion = New System.Windows.Forms.Label()
        Me.txtNumSolicitud = New System.Windows.Forms.TextBox()
        Me.lblCodPrestamo = New System.Windows.Forms.Label()
        Me.txtNosolicitud = New System.Windows.Forms.TextBox()
        Me.lblNumSolicitud = New System.Windows.Forms.Label()
        Me.txtDUI = New System.Windows.Forms.TextBox()
        Me.lblDUI = New System.Windows.Forms.Label()
        Me.txtNOCOMPROBANTE = New System.Windows.Forms.TextBox()
        Me.lblNoComprobante = New System.Windows.Forms.Label()
        Me.txtNoMatricula = New System.Windows.Forms.TextBox()
        Me.lblNoMatricula = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnEliminar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 47)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEliminar1)
        Me.GroupBox2.Controls.Add(Me.cbEstadoGarantia)
        Me.GroupBox2.Controls.Add(Me.lblEstadoGarantia)
        Me.GroupBox2.Controls.Add(Me.chbMostrarTodos)
        Me.GroupBox2.Controls.Add(Me.cbESTADOINSCRIPCION)
        Me.GroupBox2.Controls.Add(Me.txtNOCOMPROBANTE)
        Me.GroupBox2.Controls.Add(Me.lblEstadoInscripcion)
        Me.GroupBox2.Controls.Add(Me.txtNumSolicitud)
        Me.GroupBox2.Controls.Add(Me.lblCodPrestamo)
        Me.GroupBox2.Controls.Add(Me.txtNosolicitud)
        Me.GroupBox2.Controls.Add(Me.lblNumSolicitud)
        Me.GroupBox2.Controls.Add(Me.txtDUI)
        Me.GroupBox2.Controls.Add(Me.lblDUI)
        Me.GroupBox2.Controls.Add(Me.lblNoComprobante)
        Me.GroupBox2.Controls.Add(Me.txtNoMatricula)
        Me.GroupBox2.Controls.Add(Me.lblNoMatricula)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 65)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(729, 118)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtros"
        '
        'cbEstadoGarantia
        '
        Me.cbEstadoGarantia.FormattingEnabled = True
        Me.cbEstadoGarantia.Location = New System.Drawing.Point(372, 77)
        Me.cbEstadoGarantia.Name = "cbEstadoGarantia"
        Me.cbEstadoGarantia.Size = New System.Drawing.Size(139, 21)
        Me.cbEstadoGarantia.TabIndex = 14
        '
        'lblEstadoGarantia
        '
        Me.lblEstadoGarantia.AutoSize = True
        Me.lblEstadoGarantia.Location = New System.Drawing.Point(266, 80)
        Me.lblEstadoGarantia.Name = "lblEstadoGarantia"
        Me.lblEstadoGarantia.Size = New System.Drawing.Size(100, 13)
        Me.lblEstadoGarantia.TabIndex = 13
        Me.lblEstadoGarantia.Text = "Estado de Garantía"
        '
        'chbMostrarTodos
        '
        Me.chbMostrarTodos.AutoSize = True
        Me.chbMostrarTodos.Location = New System.Drawing.Point(517, 44)
        Me.chbMostrarTodos.Name = "chbMostrarTodos"
        Me.chbMostrarTodos.Size = New System.Drawing.Size(94, 17)
        Me.chbMostrarTodos.TabIndex = 12
        Me.chbMostrarTodos.Text = "Mostrar Todos"
        Me.chbMostrarTodos.UseVisualStyleBackColor = True
        '
        'cbESTADOINSCRIPCION
        '
        Me.cbESTADOINSCRIPCION.FormattingEnabled = True
        Me.cbESTADOINSCRIPCION.Location = New System.Drawing.Point(121, 77)
        Me.cbESTADOINSCRIPCION.Name = "cbESTADOINSCRIPCION"
        Me.cbESTADOINSCRIPCION.Size = New System.Drawing.Size(139, 21)
        Me.cbESTADOINSCRIPCION.TabIndex = 11
        '
        'lblEstadoInscripcion
        '
        Me.lblEstadoInscripcion.AutoSize = True
        Me.lblEstadoInscripcion.Location = New System.Drawing.Point(6, 77)
        Me.lblEstadoInscripcion.Name = "lblEstadoInscripcion"
        Me.lblEstadoInscripcion.Size = New System.Drawing.Size(109, 13)
        Me.lblEstadoInscripcion.TabIndex = 10
        Me.lblEstadoInscripcion.Text = "Estado de Inscripción"
        '
        'txtNumSolicitud
        '
        Me.txtNumSolicitud.Location = New System.Drawing.Point(574, 13)
        Me.txtNumSolicitud.Name = "txtNumSolicitud"
        Me.txtNumSolicitud.Size = New System.Drawing.Size(139, 20)
        Me.txtNumSolicitud.TabIndex = 9
        '
        'lblCodPrestamo
        '
        Me.lblCodPrestamo.AutoSize = True
        Me.lblCodPrestamo.Location = New System.Drawing.Point(517, 16)
        Me.lblCodPrestamo.Name = "lblCodPrestamo"
        Me.lblCodPrestamo.Size = New System.Drawing.Size(51, 13)
        Me.lblCodPrestamo.TabIndex = 8
        Me.lblCodPrestamo.Text = "Préstamo"
        Me.lblCodPrestamo.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtNosolicitud
        '
        Me.txtNosolicitud.Location = New System.Drawing.Point(372, 45)
        Me.txtNosolicitud.Name = "txtNosolicitud"
        Me.txtNosolicitud.Size = New System.Drawing.Size(139, 20)
        Me.txtNosolicitud.TabIndex = 7
        '
        'lblNumSolicitud
        '
        Me.lblNumSolicitud.AutoSize = True
        Me.lblNumSolicitud.Location = New System.Drawing.Point(266, 48)
        Me.lblNumSolicitud.Name = "lblNumSolicitud"
        Me.lblNumSolicitud.Size = New System.Drawing.Size(82, 13)
        Me.lblNumSolicitud.TabIndex = 6
        Me.lblNumSolicitud.Text = "No. de Solicitud"
        '
        'txtDUI
        '
        Me.txtDUI.Location = New System.Drawing.Point(121, 45)
        Me.txtDUI.Name = "txtDUI"
        Me.txtDUI.Size = New System.Drawing.Size(139, 20)
        Me.txtDUI.TabIndex = 5
        '
        'lblDUI
        '
        Me.lblDUI.AutoSize = True
        Me.lblDUI.Location = New System.Drawing.Point(6, 48)
        Me.lblDUI.Name = "lblDUI"
        Me.lblDUI.Size = New System.Drawing.Size(26, 13)
        Me.lblDUI.TabIndex = 4
        Me.lblDUI.Text = "DUI"
        '
        'txtNOCOMPROBANTE
        '
        Me.txtNOCOMPROBANTE.Location = New System.Drawing.Point(372, 13)
        Me.txtNOCOMPROBANTE.Name = "txtNOCOMPROBANTE"
        Me.txtNOCOMPROBANTE.Size = New System.Drawing.Size(139, 20)
        Me.txtNOCOMPROBANTE.TabIndex = 3
        '
        'lblNoComprobante
        '
        Me.lblNoComprobante.AutoSize = True
        Me.lblNoComprobante.Location = New System.Drawing.Point(266, 16)
        Me.lblNoComprobante.Name = "lblNoComprobante"
        Me.lblNoComprobante.Size = New System.Drawing.Size(90, 13)
        Me.lblNoComprobante.TabIndex = 2
        Me.lblNoComprobante.Text = "No. Comprobante"
        '
        'txtNoMatricula
        '
        Me.txtNoMatricula.Location = New System.Drawing.Point(121, 13)
        Me.txtNoMatricula.Name = "txtNoMatricula"
        Me.txtNoMatricula.Size = New System.Drawing.Size(139, 20)
        Me.txtNoMatricula.TabIndex = 1
        '
        'lblNoMatricula
        '
        Me.lblNoMatricula.AutoSize = True
        Me.lblNoMatricula.Location = New System.Drawing.Point(6, 16)
        Me.lblNoMatricula.Name = "lblNoMatricula"
        Me.lblNoMatricula.Size = New System.Drawing.Size(70, 13)
        Me.lblNoMatricula.TabIndex = 0
        Me.lblNoMatricula.Text = "No. Matricula"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 189)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(729, 260)
        Me.DataGridView1.TabIndex = 0
        '
        'btnEliminar1
        '
        Me.btnEliminar1.Location = New System.Drawing.Point(638, 77)
        Me.btnEliminar1.Name = "btnEliminar1"
        Me.btnEliminar1.Size = New System.Drawing.Size(75, 28)
        Me.btnEliminar1.Style = MetroFramework.MetroColorStyle.Purple
        Me.btnEliminar1.TabIndex = 219
        Me.btnEliminar1.Text = "Buscar"
        Me.btnEliminar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnEliminar1.UseSelectable = True
        Me.btnEliminar1.UseStyleColors = True
        '
        'frmMsControGarantias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(758, 487)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMsControGarantias"
        Me.Text = "Control de Garantías"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblNoMatricula As System.Windows.Forms.Label
    Friend WithEvents txtNosolicitud As System.Windows.Forms.TextBox
    Friend WithEvents lblNumSolicitud As System.Windows.Forms.Label
    Friend WithEvents txtDUI As System.Windows.Forms.TextBox
    Friend WithEvents lblDUI As System.Windows.Forms.Label
    Friend WithEvents txtNOCOMPROBANTE As System.Windows.Forms.TextBox
    Friend WithEvents lblNoComprobante As System.Windows.Forms.Label
    Friend WithEvents txtNoMatricula As System.Windows.Forms.TextBox
    Friend WithEvents cbESTADOINSCRIPCION As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstadoInscripcion As System.Windows.Forms.Label
    Friend WithEvents txtNumSolicitud As System.Windows.Forms.TextBox
    Friend WithEvents lblCodPrestamo As System.Windows.Forms.Label
    Friend WithEvents cbEstadoGarantia As System.Windows.Forms.ComboBox
    Friend WithEvents lblEstadoGarantia As System.Windows.Forms.Label
    Friend WithEvents chbMostrarTodos As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnEliminar1 As MetroFramework.Controls.MetroButton
End Class
