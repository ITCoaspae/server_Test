Public Class frmMsAsocDirectivos
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCorrelativo As String, pAccion As String, pCodigo As String
    Friend WithEvents txtDui As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Dim asociados As New wrAsociados.wsLibAsoc

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbCargos As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaIni As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFin As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbCargos = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFechaIni = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.txtDui = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Location = New System.Drawing.Point(87, 121)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(337, 22)
        Me.dtpFechaFin.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(23, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 24)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "Hasta:"
        '
        'cbCargos
        '
        Me.cbCargos.Items.AddRange(New Object() {"Presidente", "Vicepresidente", "Secretario", "Prosecretario", "Tesorero", "Protesorero", "Síndico", "Vocal", "Suplente"})
        Me.cbCargos.Location = New System.Drawing.Point(87, 63)
        Me.cbCargos.Name = "cbCargos"
        Me.cbCargos.Size = New System.Drawing.Size(337, 24)
        Me.cbCargos.TabIndex = 0
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(87, 179)
        Me.txtDescripcion.MaxLength = 255
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(337, 44)
        Me.txtDescripcion.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 18)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 19)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Cargo:"
        '
        'dtpFechaIni
        '
        Me.dtpFechaIni.Location = New System.Drawing.Point(87, 93)
        Me.dtpFechaIni.Name = "dtpFechaIni"
        Me.dtpFechaIni.Size = New System.Drawing.Size(337, 22)
        Me.dtpFechaIni.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(23, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 19)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "Desde:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(334, 229)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 33)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 124
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'txtDui
        '
        Me.txtDui.Location = New System.Drawing.Point(87, 150)
        Me.txtDui.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDui.Mask = "00000000-0"
        Me.txtDui.Name = "txtDui"
        Me.txtDui.ReadOnly = True
        Me.txtDui.Size = New System.Drawing.Size(337, 22)
        Me.txtDui.TabIndex = 125
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 17)
        Me.Label5.TabIndex = 126
        Me.Label5.Text = "DUI:"
        '
        'frmMsAsocDirectivos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(452, 334)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDui)
        Me.Controls.Add(Me.dtpFechaFin)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbCargos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFechaIni)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAsocDirectivos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Mantenimiento Directivos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click

        Dim ds As New DataSet
        Dim pCampos As String, pValores As String
        Try
            If pAccion = "Guardar" Then
                pCampos = "Codigo,Cargo,Nombre,FechaIni,FechaFin,dui"
                pValores = "'" & pCodigo & "','" & Me.cbCargos.SelectedIndex & "','" & Me.txtDescripcion.Text.Trim & "','" & Me.dtpFechaIni.Value.ToShortDateString & "','" & dtpFechaFin.Value.ToShortDateString & "', '" & txtDui.Text & "'"
                If asociados.InsertarDetDirectivos(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeIngresoRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    Me.Dispose()
                Else
                    MsgBox("Los datos de los directivos NO han sido agregados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If
            ElseIf pAccion = "Modificar" Then
                pCampos = "Cargo='" & Me.cbCargos.SelectedIndex & "',Nombre='" & Me.txtDescripcion.Text.Trim & "',FechaIni='" & dtpFechaIni.Value.ToShortDateString & "',FechaFin='" & dtpFechaFin.Value.ToShortDateString & "', DUI = '" & txtDui.Text & "'"
                If asociados.ModificarDetDirectivos("Correlativo='" & pCorrelativo & "'", pCampos, sUsuario, sPassword, sSucursal) = True Then
                    MetroFramework.MetroMessageBox.Show(Me, mensajeUpdateRegistro, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                    Me.Dispose()
                Else
                    MsgBox("Los datos de los directivos no han sido modificados. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Asociados")
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub frmMsAsocDirectivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ds As New Data.DataSet, Filas As Data.DataRowCollection
        txtDescripcion.Enabled = False
        Try
            If Me.pAccion = "Modificar" Then
                ds = asociados.ConsultarDetDirectivos("*", "Correlativo='" & pCorrelativo & "'", "Correlativo", sUsuario, sPassword, sSucursal)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    cbCargos.SelectedIndex = IIf(IsDBNull(Filas.Item(0)("Cargo")), 0, Filas.Item(0)("Cargo"))
                    txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Nombre")), "", Filas.Item(0)("Nombre"))
                    dtpFechaIni.Value = IIf(IsDBNull(Filas.Item(0)("FechaIni")), Now, Filas.Item(0)("FechaIni"))
                    dtpFechaFin.Value = IIf(IsDBNull(Filas.Item(0)("FechaFin")), Now, Filas.Item(0)("FechaFin"))
                    txtDui.Text = IIf(IsDBNull(Filas.Item(0)("dui")), Now, Filas.Item(0)("dui"))
                End If
            Else
                Me.cbCargos.SelectedIndex = 0
                Me.dtpFechaIni.Value = Now
                Me.dtpFechaFin.Value = Now
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub frmMsAsocDirectivos_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub



    Private Sub txtDui_DoubleClick(sender As Object, e As EventArgs) Handles txtDui.DoubleClick
        Try
            Dim dts As New DataSet
            Dim frm As New frmAGenerico
            dts = asociados.ConsultarAsociado("DUI,CONCAT(RTRIM(nombres), ' ',RTRIM(apellido1),' ',RTRIM(apellido2),' ',rtrim(apellidocas))[Nombre]", "", "nombres", sUsuario, sPassword, sSucursal) 'Ópcion que permite la busqueda del dui de los asociados.
            'ds = oAsoc.ConsultarAsociado("DUI,CodAntiguo,NoSocio,Apellido1,Apellido2,Nombres", "DUI='" & txtDui.Text.Trim & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            frm.Datos = dts
            frm.ColSeleccion = 0
            frm.RefrescarGrid()
            frm.C1fgrdResultado.Cols.Item(1).Width = 100
            frm.C1fgrdResultado.Cols.Item(2).Width = 500
            frm.Text = Me.Text

            frm.ShowDialog()
            txtDui.Text = frm.Resultado
            txtDescripcion.Text = frm.Resultado2.ToString.ToUpper
            ''If frm.Resultado.Trim = "" Then   'Filtrar Registros

            ''ElseIf frm.Resultado.Trim <> "" Then
            ''    sTexto = frm.Resultado.Trim
            ''    ds = oAsoc.ConsultarAsociado("DUI,Nombres,Apellido1,Apellido2,ApellidoCas,NoSocio,CodAntiguo", "DUI='" & sTexto & "'", "DUI,NoSocio", sUsuario, sPassword, sSucursal)
            ''    dr = ds.Tables(0).Rows(0)
            ''    Me.txtDui.Value = Trim(dr("DUI"))
            ''    vNoSocio = dr("NoSocio")
            ''    vNoSocioAnterior = IIf(dr("CodAntiguo") Is DBNull.Value, "", dr("CodAntiguo"))
            ''    Me.txtAsociado.Text = Trim(dr("Nombres")) & ", " & dr("Apellido1") & " " & dr("Apellido2") & " " & dr("ApellidoCas")
            ''End If
        Catch ex As Exception
            MessageBox.Show("Error en la recuperación de datos tabla Asociados- " & "System Error: " & ex.Message.ToString() & " Método: " & ex.TargetSite.Name, "Error de Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class