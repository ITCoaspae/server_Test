<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMsAsociacionesPep
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtPorParticipacin = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSociedad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.Panel1.SuspendLayout()
        CType(Me.txtPorParticipacin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtPorParticipacin)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSociedad)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(23, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 81)
        Me.Panel1.TabIndex = 159
        '
        'txtPorParticipacin
        '
        Me.txtPorParticipacin.BackColor = System.Drawing.Color.White
        Me.txtPorParticipacin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPorParticipacin.CustomFormat = "##0.00"
        Me.txtPorParticipacin.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorParticipacin.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtPorParticipacin.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtPorParticipacin.Location = New System.Drawing.Point(79, 50)
        Me.txtPorParticipacin.Name = "txtPorParticipacin"
        Me.txtPorParticipacin.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.txtPorParticipacin.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.txtPorParticipacin.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.txtPorParticipacin.ShowDropDownButton = False
        Me.txtPorParticipacin.ShowUpDownButtons = False
        Me.txtPorParticipacin.Size = New System.Drawing.Size(112, 21)
        Me.txtPorParticipacin.TabIndex = 133
        Me.txtPorParticipacin.Tag = Nothing
        Me.txtPorParticipacin.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 26)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Porcentaje" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Participación:"
        '
        'txtSociedad
        '
        Me.txtSociedad.BackColor = System.Drawing.Color.White
        Me.txtSociedad.Location = New System.Drawing.Point(79, 15)
        Me.txtSociedad.Name = "txtSociedad"
        Me.txtSociedad.Size = New System.Drawing.Size(337, 20)
        Me.txtSociedad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sociedad:"
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(378, 150)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.TabIndex = 163
        Me.MetroButton1.Text = "Guardar"
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'frmMsAsociacionesPep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 229)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(478, 229)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(478, 229)
        Me.Name = "frmMsAsociacionesPep"
        Me.ShowIcon = False
        Me.Text = "Sociedades Relacionadas con PEP"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtPorParticipacin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSociedad As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPorParticipacin As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
End Class
