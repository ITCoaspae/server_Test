Imports System.IO

Public Class frmMsPLArchivoNB
    Inherits MetroFramework.Forms.MetroForm
    Public rsc As System.Resources.ResourceManager
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Private oPlan As wrPlanilla.wsLibPlanilla = New wrPlanilla.wsLibPlanilla

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
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents sdlgFile As System.Windows.Forms.SaveFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sdlgFile = New System.Windows.Forms.SaveFileDialog()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(186, 91)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(124, 20)
        Me.dtpFechaFin.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(156, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "al"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(26, 91)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(124, 20)
        Me.dtpFechaInicio.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(23, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 16)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Fecha proceso de Planilla:"
        '
        'sdlgFile
        '
        Me.sdlgFile.DefaultExt = "txt"
        Me.sdlgFile.Filter = "Archivos de texto|*.txt"
        Me.sdlgFile.InitialDirectory = "c:\"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(287, 117)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 117
        Me.btnGuardar1.Text = "&Generar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsPLArchivoNB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(385, 188)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.Label5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(385, 188)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(385, 188)
        Me.Name = "frmMsPLArchivoNB"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Generación Archivo NetBanking"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmMsPLArchivoNB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpFechaInicio.Value = Now
        Me.dtpFechaFin.Value = Now
    End Sub



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim pNameFile As String, ds As New DataSet

        If Me.sdlgFile.ShowDialog = DialogResult.OK Then
            pNameFile = sdlgFile.FileName
            If File.Exists(pNameFile) Then
                If MsgBox("El archivo existe, Desea sobreescribirlo?", MsgBoxStyle.YesNo) <> MsgBoxResult.Yes Then
                    Return
                End If
            End If

            Dim myStreamWriter As StreamWriter, pCadena As String, dr As DataRow
            Try
                myStreamWriter = File.CreateText(pNameFile)
                ds = oPlan.ImportarFileNB("1", "", Me.dtpFechaInicio.Value.ToShortDateString, Me.dtpFechaFin.Value.ToShortDateString, False, "", "", "", Now, sUsuario, sPassword, sSucursal)

                For Each dr In ds.Tables("NetBanking").Rows
                    pCadena = dr("Cuenta") & "," & dr("TipoCuenta") & "," & dr("Monto") & "," & dr("Nombre") & vbCrLf
                    myStreamWriter.Write(pCadena)
                    myStreamWriter.Flush()
                Next

                MessageBox.Show("Arhivo generado con éxito", "Generación archivo NetBanking", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

            Catch exc As Exception
                 MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            Finally
                If Not myStreamWriter Is Nothing Then
                    myStreamWriter.Close()
                End If
            End Try
        End If
    End Sub
End Class
