<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMCierreCompra
    Inherits MetroFramework.Forms.MetroForm ' Inherits System.Windows.Forms.Form

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
        Me.dgCierre = New System.Windows.Forms.DataGridView()
        Me.gbFiltros = New System.Windows.Forms.GroupBox()
        Me.btnBuscar1 = New MetroFramework.Controls.MetroButton()
        Me.txtAnio = New System.Windows.Forms.NumericUpDown()
        Me.lblAnnio = New System.Windows.Forms.Label()
        Me.btnAdd1 = New MetroFramework.Controls.MetroButton()
        Me.btnMod1 = New MetroFramework.Controls.MetroButton()
        Me.btnConsultar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.dgCierre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFiltros.SuspendLayout()
        CType(Me.txtAnio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCierre
        '
        Me.dgCierre.AllowUserToAddRows = False
        Me.dgCierre.AllowUserToDeleteRows = False
        Me.dgCierre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCierre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCierre.Location = New System.Drawing.Point(23, 154)
        Me.dgCierre.Name = "dgCierre"
        Me.dgCierre.ReadOnly = True
        Me.dgCierre.Size = New System.Drawing.Size(526, 195)
        Me.dgCierre.TabIndex = 0
        '
        'gbFiltros
        '
        Me.gbFiltros.BackColor = System.Drawing.Color.White
        Me.gbFiltros.Controls.Add(Me.btnBuscar1)
        Me.gbFiltros.Controls.Add(Me.txtAnio)
        Me.gbFiltros.Controls.Add(Me.lblAnnio)
        Me.gbFiltros.Location = New System.Drawing.Point(23, 63)
        Me.gbFiltros.Name = "gbFiltros"
        Me.gbFiltros.Size = New System.Drawing.Size(423, 51)
        Me.gbFiltros.TabIndex = 160
        Me.gbFiltros.TabStop = False
        Me.gbFiltros.Text = "Busqueda"
        '
        'btnBuscar1
        '
        Me.btnBuscar1.Location = New System.Drawing.Point(111, 13)
        Me.btnBuscar1.Name = "btnBuscar1"
        Me.btnBuscar1.Size = New System.Drawing.Size(70, 28)
        Me.btnBuscar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnBuscar1.TabIndex = 165
        Me.btnBuscar1.Text = "Buscar"
        Me.btnBuscar1.UseSelectable = True
        Me.btnBuscar1.UseStyleColors = True
        '
        'txtAnio
        '
        Me.txtAnio.BackColor = System.Drawing.Color.White
        Me.txtAnio.Location = New System.Drawing.Point(41, 18)
        Me.txtAnio.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.txtAnio.Minimum = New Decimal(New Integer() {2016, 0, 0, 0})
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(64, 20)
        Me.txtAnio.TabIndex = 3
        Me.txtAnio.Value = New Decimal(New Integer() {2016, 0, 0, 0})
        '
        'lblAnnio
        '
        Me.lblAnnio.AutoSize = True
        Me.lblAnnio.Location = New System.Drawing.Point(6, 20)
        Me.lblAnnio.Name = "lblAnnio"
        Me.lblAnnio.Size = New System.Drawing.Size(29, 13)
        Me.lblAnnio.TabIndex = 0
        Me.lblAnnio.Text = "Año:"
        '
        'btnAdd1
        '
        Me.btnAdd1.Location = New System.Drawing.Point(23, 120)
        Me.btnAdd1.Name = "btnAdd1"
        Me.btnAdd1.Size = New System.Drawing.Size(70, 28)
        Me.btnAdd1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnAdd1.TabIndex = 166
        Me.btnAdd1.Text = "Agregar"
        Me.btnAdd1.UseSelectable = True
        Me.btnAdd1.UseStyleColors = True
        '
        'btnMod1
        '
        Me.btnMod1.Location = New System.Drawing.Point(99, 120)
        Me.btnMod1.Name = "btnMod1"
        Me.btnMod1.Size = New System.Drawing.Size(70, 28)
        Me.btnMod1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnMod1.TabIndex = 167
        Me.btnMod1.Text = "Modificar"
        Me.btnMod1.UseSelectable = True
        Me.btnMod1.UseStyleColors = True
        '
        'btnConsultar1
        '
        Me.btnConsultar1.Location = New System.Drawing.Point(175, 120)
        Me.btnConsultar1.Name = "btnConsultar1"
        Me.btnConsultar1.Size = New System.Drawing.Size(70, 28)
        Me.btnConsultar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnConsultar1.TabIndex = 168
        Me.btnConsultar1.Text = "Consultar"
        Me.btnConsultar1.UseSelectable = True
        Me.btnConsultar1.UseStyleColors = True
        '
        'frmMCierreCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(572, 372)
        Me.Controls.Add(Me.btnConsultar1)
        Me.Controls.Add(Me.btnMod1)
        Me.Controls.Add(Me.btnAdd1)
        Me.Controls.Add(Me.gbFiltros)
        Me.Controls.Add(Me.dgCierre)
        Me.Name = "frmMCierreCompra"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cierre Mensual Compras"
        CType(Me.dgCierre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFiltros.ResumeLayout(False)
        Me.gbFiltros.PerformLayout()
        CType(Me.txtAnio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgCierre As System.Windows.Forms.DataGridView
    Friend WithEvents gbFiltros As System.Windows.Forms.GroupBox
    Friend WithEvents lblAnnio As System.Windows.Forms.Label
    Friend WithEvents txtAnio As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnBuscar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnMod1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConsultar1 As MetroFramework.Controls.MetroButton
End Class
