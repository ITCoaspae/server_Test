﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMTipoEvaluaciones
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgTipoEvaluaciones = New System.Windows.Forms.DataGridView()
        Me.MetroButton3 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton2 = New MetroFramework.Controls.MetroButton()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnGenerar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.dgTipoEvaluaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgTipoEvaluaciones
        '
        Me.dgTipoEvaluaciones.AllowUserToAddRows = False
        Me.dgTipoEvaluaciones.AllowUserToDeleteRows = False
        Me.dgTipoEvaluaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgTipoEvaluaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTipoEvaluaciones.Location = New System.Drawing.Point(23, 97)
        Me.dgTipoEvaluaciones.Name = "dgTipoEvaluaciones"
        Me.dgTipoEvaluaciones.ReadOnly = True
        Me.dgTipoEvaluaciones.Size = New System.Drawing.Size(573, 178)
        Me.dgTipoEvaluaciones.TabIndex = 38
        '
        'MetroButton3
        '
        Me.MetroButton3.Location = New System.Drawing.Point(266, 63)
        Me.MetroButton3.Name = "MetroButton3"
        Me.MetroButton3.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton3.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton3.TabIndex = 189
        Me.MetroButton3.Text = "Eliminar"
        Me.MetroButton3.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton3.UseSelectable = True
        Me.MetroButton3.UseStyleColors = True
        '
        'MetroButton2
        '
        Me.MetroButton2.Location = New System.Drawing.Point(185, 63)
        Me.MetroButton2.Name = "MetroButton2"
        Me.MetroButton2.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton2.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton2.TabIndex = 188
        Me.MetroButton2.Text = "Consultar"
        Me.MetroButton2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton2.UseSelectable = True
        Me.MetroButton2.UseStyleColors = True
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(104, 63)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(75, 28)
        Me.MetroButton1.Style = MetroFramework.MetroColorStyle.Teal
        Me.MetroButton1.TabIndex = 187
        Me.MetroButton1.Text = "Modificar"
        Me.MetroButton1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroButton1.UseSelectable = True
        Me.MetroButton1.UseStyleColors = True
        '
        'btnGenerar1
        '
        Me.btnGenerar1.Location = New System.Drawing.Point(23, 63)
        Me.btnGenerar1.Name = "btnGenerar1"
        Me.btnGenerar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGenerar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGenerar1.TabIndex = 186
        Me.btnGenerar1.Text = "Agregar"
        Me.btnGenerar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGenerar1.UseSelectable = True
        Me.btnGenerar1.UseStyleColors = True
        '
        'frmMTipoEvaluaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(619, 317)
        Me.Controls.Add(Me.MetroButton3)
        Me.Controls.Add(Me.MetroButton2)
        Me.Controls.Add(Me.MetroButton1)
        Me.Controls.Add(Me.btnGenerar1)
        Me.Controls.Add(Me.dgTipoEvaluaciones)
        Me.Name = "frmMTipoEvaluaciones"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento  Tipo de Evaluaciones"
        CType(Me.dgTipoEvaluaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgTipoEvaluaciones As System.Windows.Forms.DataGridView
    Friend WithEvents MetroButton3 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton2 As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGenerar1 As MetroFramework.Controls.MetroButton
End Class
