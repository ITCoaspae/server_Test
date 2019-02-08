<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsPlCalculoVacaciones
    Inherits MetroFramework.Forms.MetroForm
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
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.lblPrima = New System.Windows.Forms.Label()
        Me.txtPrima = New System.Windows.Forms.TextBox()
        Me.lblDias = New System.Windows.Forms.Label()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(23, 60)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(41, 13)
        Me.lblDesde.TabIndex = 0
        Me.lblDesde.Text = "Desde:"
        '
        'txtDesde
        '
        Me.txtDesde.Location = New System.Drawing.Point(68, 57)
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(78, 20)
        Me.txtDesde.TabIndex = 1
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(152, 60)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(38, 13)
        Me.lblHasta.TabIndex = 2
        Me.lblHasta.Text = "Hasta:"
        '
        'txtHasta
        '
        Me.txtHasta.Location = New System.Drawing.Point(196, 57)
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(78, 20)
        Me.txtHasta.TabIndex = 3
        '
        'lblPrima
        '
        Me.lblPrima.AutoSize = True
        Me.lblPrima.Location = New System.Drawing.Point(23, 95)
        Me.lblPrima.Name = "lblPrima"
        Me.lblPrima.Size = New System.Drawing.Size(36, 13)
        Me.lblPrima.TabIndex = 4
        Me.lblPrima.Text = "Prima:"
        '
        'txtPrima
        '
        Me.txtPrima.Location = New System.Drawing.Point(68, 92)
        Me.txtPrima.Name = "txtPrima"
        Me.txtPrima.Size = New System.Drawing.Size(78, 20)
        Me.txtPrima.TabIndex = 5
        '
        'lblDias
        '
        Me.lblDias.AutoSize = True
        Me.lblDias.Location = New System.Drawing.Point(152, 95)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(33, 13)
        Me.lblDias.TabIndex = 6
        Me.lblDias.Text = "Días:"
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(196, 95)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(78, 20)
        Me.txtDias.TabIndex = 7
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(292, 119)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 120
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "AÑOS"
        '
        'frmMsPlCalculoVacaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(409, 198)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDesde)
        Me.Controls.Add(Me.txtDesde)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.lblHasta)
        Me.Controls.Add(Me.txtDias)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.txtPrima)
        Me.Controls.Add(Me.lblDias)
        Me.Controls.Add(Me.lblPrima)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(409, 198)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(409, 198)
        Me.Name = "frmMsPlCalculoVacaciones"
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Ingreso de Parámetros Vacaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents txtDesde As System.Windows.Forms.TextBox
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents txtHasta As System.Windows.Forms.TextBox
    Friend WithEvents lblPrima As System.Windows.Forms.Label
    Friend WithEvents txtPrima As System.Windows.Forms.TextBox
    Friend WithEvents lblDias As System.Windows.Forms.Label
    Friend WithEvents txtDias As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents Label1 As Label
End Class
