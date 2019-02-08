Public Class frmMsCaParametros
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

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents C1NEMontoMinimo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1NEMontoMaximo As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.C1NEMontoMaximo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.C1NEMontoMinimo = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.C1NEMontoMaximo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NEMontoMinimo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.C1NEMontoMaximo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.C1NEMontoMinimo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 69)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'C1NEMontoMaximo
        '
        Me.C1NEMontoMaximo.BackColor = System.Drawing.Color.White
        Me.C1NEMontoMaximo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMontoMaximo.CustomFormat = "###,###,##0.00"
        Me.C1NEMontoMaximo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMontoMaximo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMontoMaximo.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMontoMaximo.Location = New System.Drawing.Point(202, 39)
        Me.C1NEMontoMaximo.Name = "C1NEMontoMaximo"
        Me.C1NEMontoMaximo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMontoMaximo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMontoMaximo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMontoMaximo.ShowDropDownButton = False
        Me.C1NEMontoMaximo.ShowUpDownButtons = False
        Me.C1NEMontoMaximo.Size = New System.Drawing.Size(152, 21)
        Me.C1NEMontoMaximo.TabIndex = 1
        Me.C1NEMontoMaximo.Tag = Nothing
        Me.C1NEMontoMaximo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Monto máximo de efectivo en Caja:"
        '
        'C1NEMontoMinimo
        '
        Me.C1NEMontoMinimo.BackColor = System.Drawing.Color.White
        Me.C1NEMontoMinimo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMontoMinimo.CustomFormat = "###,###,##0.00"
        Me.C1NEMontoMinimo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMontoMinimo.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMontoMinimo.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMontoMinimo.Location = New System.Drawing.Point(202, 12)
        Me.C1NEMontoMinimo.Name = "C1NEMontoMinimo"
        Me.C1NEMontoMinimo.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMontoMinimo.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMontoMinimo.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMontoMinimo.ShowDropDownButton = False
        Me.C1NEMontoMinimo.ShowUpDownButtons = False
        Me.C1NEMontoMinimo.Size = New System.Drawing.Size(152, 21)
        Me.C1NEMontoMinimo.TabIndex = 0
        Me.C1NEMontoMinimo.Tag = Nothing
        Me.C1NEMontoMinimo.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Monto mínimo para apertura de Caja:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(312, 138)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 1014
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsCaParametros
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(436, 195)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(436, 195)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(436, 195)
        Me.Name = "frmMsCaParametros"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Parámetros Generales - Módulo Caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.C1NEMontoMaximo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NEMontoMinimo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmMsCaParametros_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCaja As New wrCaja.wsLibCaja
        'Dim pCampos, pValores As String, 
        Dim ds As New DataSet
        Dim Filas As Data.DataRowCollection
        Try
            ds = oCaja.ConsultarCAParametros("*", "", "", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count > 0 Then

                Me.C1NEMontoMinimo.Value = IIf(IsDBNull(Filas.Item(0)("MontoMinimo_Apertura")), "0", Filas.Item(0)("MontoMinimo_Apertura"))
                Me.C1NEMontoMaximo.Value = IIf(IsDBNull(Filas.Item(0)("MontoMaximo_Apertura")), "0", Filas.Item(0)("MontoMaximo_Apertura"))

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim oCaja As New wrCaja.wsLibCaja
        Dim pCampos, pValores As String, ds As New DataSet
        Dim Filas As Data.DataRowCollection
        Try
            ds = oCaja.ConsultarCAParametros("*", "", "", sUsuario, sPassword, sSucursal)
            Filas = ds.Tables(0).Rows()
            If Filas.Count <= 0 Then
                pCampos = "MontoMinimo_Apertura,MontoMaximo_Apertura"
                pValores = "" & Trim(Me.C1NEMontoMinimo.Text) & "," & Val(Me.C1NEMontoMaximo.Value) & ""
                If oCaja.InsertarCAParametros(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los parámetros NO han sido agregados", MsgBoxStyle.Information, "Error de Validación/Derechos en Módulo Caja")
                End If
            Else
                pValores = "MontoMinimo_Apertura=" & Val(Me.C1NEMontoMinimo.Value) & ",MontoMaximo_Apertura=" & Val(Me.C1NEMontoMaximo.Value) & ""
                If oCaja.ModificarCAParametros(pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("Los parámetros NO han sido actualizados.", MsgBoxStyle.Information, "Error de Validación/Derechos en Módulo Caja")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class
