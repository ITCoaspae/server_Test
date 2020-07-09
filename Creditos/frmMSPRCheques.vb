Public Class frmMSPRCheques
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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPagueseA As System.Windows.Forms.TextBox
    Friend WithEvents txtCodPrestamo As System.Windows.Forms.TextBox
    Friend WithEvents c1neMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNoCheque As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents txtBanco As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtBanco = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoCheque = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c1neMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPagueseA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCodPrestamo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.c1neMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBanco
        '
        Me.txtBanco.Location = New System.Drawing.Point(109, 147)
        Me.txtBanco.Name = "txtBanco"
        Me.txtBanco.Size = New System.Drawing.Size(410, 20)
        Me.txtBanco.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "Banco:"
        '
        'txtNoCheque
        '
        Me.txtNoCheque.Location = New System.Drawing.Point(109, 112)
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.Size = New System.Drawing.Size(160, 20)
        Me.txtNoCheque.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 31)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "Número de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cheque:"
        '
        'c1neMonto
        '
        Me.c1neMonto.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.c1neMonto.Location = New System.Drawing.Point(359, 60)
        Me.c1neMonto.Name = "c1neMonto"
        Me.c1neMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.c1neMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.c1neMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.c1neMonto.ShowDropDownButton = False
        Me.c1neMonto.ShowUpDownButtons = False
        Me.c1neMonto.Size = New System.Drawing.Size(160, 20)
        Me.c1neMonto.TabIndex = 1
        Me.c1neMonto.Tag = Nothing
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(275, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 16)
        Me.Label15.TabIndex = 130
        Me.Label15.Text = "Monto:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPagueseA
        '
        Me.txtPagueseA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPagueseA.Location = New System.Drawing.Point(109, 86)
        Me.txtPagueseA.MaxLength = 100
        Me.txtPagueseA.Name = "txtPagueseA"
        Me.txtPagueseA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPagueseA.Size = New System.Drawing.Size(410, 20)
        Me.txtPagueseA.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(23, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Paguese A:"
        '
        'txtCodPrestamo
        '
        Me.txtCodPrestamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodPrestamo.Location = New System.Drawing.Point(109, 60)
        Me.txtCodPrestamo.MaxLength = 20
        Me.txtCodPrestamo.Name = "txtCodPrestamo"
        Me.txtCodPrestamo.Size = New System.Drawing.Size(160, 20)
        Me.txtCodPrestamo.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(23, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Préstamo:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(444, 173)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 134
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMSPRCheques
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(539, 238)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtBanco)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNoCheque)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPagueseA)
        Me.Controls.Add(Me.c1neMonto)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCodPrestamo)
        Me.Controls.Add(Me.Label15)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(539, 238)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(539, 238)
        Me.Name = "frmMSPRCheques"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Cheque para desembolso de préstamo"
        CType(Me.c1neMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private vCorrelativo As Integer, pNoSolic As String

#Region "Propiedades"

    Public Property NoSolic() As String
        Get
            Return pNoSolic
        End Get
        Set(ByVal Value As String)
            pNoSolic = Value
        End Set
    End Property

    Public Property Correlativo() As Integer
        Get
            Return vCorrelativo
        End Get
        Set(ByVal Value As Integer)
            vCorrelativo = Value
        End Set
    End Property

    Private Sub txtBanco_TextChanged(sender As Object, e As EventArgs) Handles txtBanco.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtNoCheque_TextChanged(sender As Object, e As EventArgs) Handles txtNoCheque.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub txtPagueseA_TextChanged(sender As Object, e As EventArgs) Handles txtPagueseA.TextChanged

    End Sub

    Private Sub c1neMonto_TextChanged(sender As Object, e As EventArgs) Handles c1neMonto.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub txtCodPrestamo_TextChanged(sender As Object, e As EventArgs) Handles txtCodPrestamo.TextChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

#End Region



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim Campos, Valores, CamposValores As String
            Dim oItem As New wrPrestamo.wsLibPrest

            If Me.btnGuardar1.Text = "&Guardar" Then
                Campos = "CodPrestamo,NumSolicitud,PagueseA,Monto,NoCheque,Banco"
                Valores = "'" & Trim(Me.txtCodPrestamo.Text) & "'," & pNoSolic & ",'" & Trim(Me.txtPagueseA.Text) & "'," & Me.c1neMonto.Value & ",'" & Me.txtNoCheque.Text.Trim & "','" & Me.txtBanco.Text.Trim & "'"
                If oItem.InsertarPRCheques(Campos, Valores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MessageBox.Show("Registro no ingresado.")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                CamposValores = "PagueseA='" & Trim(Me.txtPagueseA.Text) & "',Monto=" & Me.c1neMonto.Value & ",NoCheque='" & Me.txtNoCheque.Text.Trim & "',Banco='" & Me.txtBanco.Text.Trim & "'"
                If oItem.ModificarPRCheques(CamposValores, vCorrelativo, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MessageBox.Show("Registro no modificado.")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


End Class