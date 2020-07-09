<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class wfESTADO_RES
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbCC = New MetroFramework.Controls.MetroComboBox()
        Me.btnGenerar = New MetroFramework.Controls.MetroButton()
        Me.lblCentroCosto = New System.Windows.Forms.Label()
        Me.chkSaldosHistoricos = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cbCC)
        Me.Panel1.Controls.Add(Me.btnGenerar)
        Me.Panel1.Controls.Add(Me.lblCentroCosto)
        Me.Panel1.Controls.Add(Me.chkSaldosHistoricos)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(31, 78)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(657, 89)
        Me.Panel1.TabIndex = 0
        '
        'cbCC
        '
        Me.cbCC.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbCC.FormattingEnabled = True
        Me.cbCC.ItemHeight = 21
        Me.cbCC.Location = New System.Drawing.Point(103, 7)
        Me.cbCC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbCC.Name = "cbCC"
        Me.cbCC.Size = New System.Drawing.Size(389, 27)
        Me.cbCC.Style = MetroFramework.MetroColorStyle.Teal
        Me.cbCC.TabIndex = 2
        Me.cbCC.Theme = MetroFramework.MetroThemeStyle.Light
        Me.cbCC.UseSelectable = True
        Me.cbCC.UseStyleColors = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(544, 43)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(100, 28)
        Me.btnGenerar.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGenerar.TabIndex = 2
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGenerar.UseSelectable = True
        Me.btnGenerar.UseStyleColors = True
        '
        'lblCentroCosto
        '
        Me.lblCentroCosto.AutoSize = True
        Me.lblCentroCosto.Location = New System.Drawing.Point(4, 6)
        Me.lblCentroCosto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCentroCosto.Name = "lblCentroCosto"
        Me.lblCentroCosto.Size = New System.Drawing.Size(74, 34)
        Me.lblCentroCosto.TabIndex = 36
        Me.lblCentroCosto.Text = "Centro de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Costos:"
        '
        'chkSaldosHistoricos
        '
        Me.chkSaldosHistoricos.AutoSize = True
        Me.chkSaldosHistoricos.Location = New System.Drawing.Point(501, 15)
        Me.chkSaldosHistoricos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chkSaldosHistoricos.Name = "chkSaldosHistoricos"
        Me.chkSaldosHistoricos.Size = New System.Drawing.Size(139, 21)
        Me.chkSaldosHistoricos.TabIndex = 5
        Me.chkSaldosHistoricos.Text = "Saldos Historicos"
        Me.chkSaldosHistoricos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(281, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Fin:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "MMMM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(365, 46)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(169, 22)
        Me.DateTimePicker2.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.Khaki
        Me.DateTimePicker1.CustomFormat = "MMMM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(103, 46)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(169, 22)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Inicio:"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(31, 185)
        Me.CrystalReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.ShowZoomButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(657, 259)
        Me.CrystalReportViewer1.TabIndex = 1
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        Me.CrystalReportViewer1.ToolPanelWidth = 267
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'wfESTADO_RES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(716, 473)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "wfESTADO_RES"
        Me.Padding = New System.Windows.Forms.Padding(27, 74, 27, 25)
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Estado de Resultados"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkSaldosHistoricos As System.Windows.Forms.CheckBox
    Friend WithEvents lblCentroCosto As System.Windows.Forms.Label
    Friend WithEvents btnGenerar As MetroFramework.Controls.MetroButton
    Friend WithEvents cbCC As MetroFramework.Controls.MetroComboBox
End Class
