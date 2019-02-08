Public Class frmDCategoriaRiesgo
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents txtDesde As System.Windows.Forms.TextBox
    Friend WithEvents txtHasta As System.Windows.Forms.TextBox
    Friend WithEvents txtProcentaje As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRango1 As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtRango2 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtRango2 = New System.Windows.Forms.TextBox()
        Me.txtRango1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtProcentaje = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHasta = New System.Windows.Forms.TextBox()
        Me.txtDesde = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtRango2
        '
        Me.txtRango2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRango2.Location = New System.Drawing.Point(231, 88)
        Me.txtRango2.MaxLength = 20
        Me.txtRango2.Name = "txtRango2"
        Me.txtRango2.Size = New System.Drawing.Size(64, 20)
        Me.txtRango2.TabIndex = 4
        '
        'txtRango1
        '
        Me.txtRango1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRango1.Location = New System.Drawing.Point(99, 86)
        Me.txtRango1.MaxLength = 20
        Me.txtRango1.Name = "txtRango1"
        Me.txtRango1.Size = New System.Drawing.Size(64, 20)
        Me.txtRango1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(169, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 118
        Me.Label5.Text = "Rango 2:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(23, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 117
        Me.Label4.Text = "Rango 1:"
        '
        'txtProcentaje
        '
        Me.txtProcentaje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcentaje.Location = New System.Drawing.Point(375, 90)
        Me.txtProcentaje.MaxLength = 20
        Me.txtProcentaje.Name = "txtProcentaje"
        Me.txtProcentaje.Size = New System.Drawing.Size(64, 20)
        Me.txtProcentaje.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(313, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 115
        Me.Label3.Text = "% Riesgo:"
        '
        'txtHasta
        '
        Me.txtHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHasta.Location = New System.Drawing.Point(375, 58)
        Me.txtHasta.MaxLength = 20
        Me.txtHasta.Name = "txtHasta"
        Me.txtHasta.Size = New System.Drawing.Size(64, 20)
        Me.txtHasta.TabIndex = 2
        '
        'txtDesde
        '
        Me.txtDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesde.Location = New System.Drawing.Point(231, 58)
        Me.txtDesde.MaxLength = 20
        Me.txtDesde.Name = "txtDesde"
        Me.txtDesde.Size = New System.Drawing.Size(64, 20)
        Me.txtDesde.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(313, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 112
        Me.Label2.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(169, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Desde:"
        '
        'txtCategoria
        '
        Me.txtCategoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCategoria.Location = New System.Drawing.Point(99, 60)
        Me.txtCategoria.MaxLength = 20
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(64, 20)
        Me.txtCategoria.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(23, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 16)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Categoria:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(364, 131)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 187
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmDCategoriaRiesgo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)

        Me.ClientSize = New System.Drawing.Size(529, 190)
        Me.Controls.Add(Me.txtRango2)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtRango1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtProcentaje)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtCategoria)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHasta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDesde)
        Me.MaximumSize = New System.Drawing.Size(529, 190)
        Me.MinimumSize = New System.Drawing.Size(529, 190)
        Me.Name = "frmDCategoriaRiesgo"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.Text = "Categoría de Riesgo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim frmG As frmMCategoriaRiesgo = New frmMCategoriaRiesgo
            Dim oItem As New wrCredito.wsLibCred

            If btnGuardar1.Text = "&Guardar" Then
                Dim Campos, Valores As String
                Dim categoria As String = txtCategoria.Text.ToString
                Dim desde As Integer = CInt(txtDesde.Text)
                Dim hasta As Integer = CInt(txtHasta.Text)
                Dim por As Double = txtProcentaje.Text
                Campos = "Categoria,DiaDesde,DiaHasta,PorcentajeRiesgo,Rango1,Rango2"
                Valores = "'" & categoria & "'," & desde & "," & hasta & "," & por & "," & CDbl(Me.txtRango1.Text) & "," & CDbl(Me.txtRango2.Text) & ""
                If oItem.InsertarPRCategoriaRiesgo(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Close()
                Else
                    MessageBox.Show("Registro no ingresado")
                End If
            ElseIf btnGuardar1.Text = "&Modificar" Then
                Dim camposyvalores As String
                Dim categoria As String = txtCategoria.Text.ToString
                Dim desde As Integer = CInt(txtDesde.Text)
                Dim hasta As Integer = CInt(txtHasta.Text)
                Dim por As Double = txtProcentaje.Text
                camposyvalores = "DiaDesde=" & desde & ",DiaHasta=" & hasta & ",PorcentajeRiesgo=" & por & ",Rango1=" & CDbl(Me.txtRango1.Text) & ",Rango2=" & CDbl(Me.txtRango2.Text) & ""

                If oItem.ModificarPRCategoriaRiesgo(camposyvalores, categoria, sUsuario, sPassword, sSucursal) = True Then
                    Me.Close()
                Else
                    MessageBox.Show("Registro no Actualizado")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
