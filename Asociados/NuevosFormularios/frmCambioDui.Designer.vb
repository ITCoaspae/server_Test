<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambioDui
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
        Me.lblDuiAnt = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDuiAnt = New C1.Win.C1Input.C1TextBox()
        Me.txtNuevoDui = New C1.Win.C1Input.C1TextBox()
        Me.btnImprimir1 = New MetroFramework.Controls.MetroButton()
        Me.txtAsociado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.txtDuiAnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNuevoDui, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDuiAnt
        '
        Me.lblDuiAnt.AutoSize = True
        Me.lblDuiAnt.Location = New System.Drawing.Point(16, 74)
        Me.lblDuiAnt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDuiAnt.Name = "lblDuiAnt"
        Me.lblDuiAnt.Size = New System.Drawing.Size(88, 17)
        Me.lblDuiAnt.TabIndex = 0
        Me.lblDuiAnt.Text = "DUI anterior:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 134)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nuevo DUI:"
        '
        'txtDuiAnt
        '
        Me.txtDuiAnt.BackColor = System.Drawing.Color.White
        Me.txtDuiAnt.EditMask = "00000000-0"
        Me.txtDuiAnt.Location = New System.Drawing.Point(112, 78)
        Me.txtDuiAnt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDuiAnt.Name = "txtDuiAnt"
        Me.txtDuiAnt.NumericInput = False
        Me.txtDuiAnt.Size = New System.Drawing.Size(308, 20)
        Me.txtDuiAnt.TabIndex = 1
        Me.txtDuiAnt.Tag = Nothing
        Me.txtDuiAnt.Value = ""
        '
        'txtNuevoDui
        '
        Me.txtNuevoDui.BackColor = System.Drawing.Color.White
        Me.txtNuevoDui.EditMask = "00000000-0"
        Me.txtNuevoDui.Location = New System.Drawing.Point(112, 134)
        Me.txtNuevoDui.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNuevoDui.Name = "txtNuevoDui"
        Me.txtNuevoDui.NumericInput = False
        Me.txtNuevoDui.Size = New System.Drawing.Size(308, 20)
        Me.txtNuevoDui.TabIndex = 5
        Me.txtNuevoDui.Tag = Nothing
        Me.txtNuevoDui.Value = ""
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Location = New System.Drawing.Point(330, 161)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(90, 32)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 6
        Me.btnImprimir1.Text = "Procesar"
        Me.btnImprimir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'txtAsociado
        '
        Me.txtAsociado.Location = New System.Drawing.Point(112, 105)
        Me.txtAsociado.Name = "txtAsociado"
        Me.txtAsociado.Size = New System.Drawing.Size(308, 22)
        Me.txtAsociado.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Asociado:"
        '
        'frmCambioDui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 244)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAsociado)
        Me.Controls.Add(Me.btnImprimir1)
        Me.Controls.Add(Me.txtNuevoDui)
        Me.Controls.Add(Me.txtDuiAnt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDuiAnt)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCambioDui"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.ShowIcon = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cambio de DUI"
        CType(Me.txtDuiAnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNuevoDui, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDuiAnt As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDuiAnt As C1.Win.C1Input.C1TextBox
    Friend WithEvents txtNuevoDui As C1.Win.C1Input.C1TextBox
    Friend WithEvents btnImprimir1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtAsociado As TextBox
    Friend WithEvents Label2 As Label
End Class
