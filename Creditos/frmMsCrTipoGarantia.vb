Public Class frmMsCrTipoGarantia
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Public pCodigo As String, pAccion As String
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) '' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.Location = New System.Drawing.Point(101, 57)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(134, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Descripci�n:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "C�digo:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(274, 109)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 32
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(101, 83)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(248, 20)
        Me.txtDescripcion.TabIndex = 0
        '
        'frmMsCrTipoGarantia
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(371, 158)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(371, 158)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(371, 158)
        Me.Name = "frmMsCrTipoGarantia"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Tipo de Garant�a"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



    Private Sub frmMsTipoGarantia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, ds As New Data.DataSet
            Dim Filas As Data.DataRowCollection

            If Me.pAccion = "Modificar" Then

                ds = oCred.ConsultarTipGarant("*", "CodTipoGarantias='" & pCodigo & "'", "CodTipoGarantias", sUsuario, sPassword, sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    txtCodigo.Text = pCodigo
                    txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                End If
            Else
                Dim vCod As String
                vCod = oCred.ObtenerCorrelativoTipGarant("CodTipoGarantias", sUsuario, sPassword, sSucursal)
                Me.txtCodigo.Text = vCod.PadLeft(5, "0")
            End If
            txtCodigo.Focus()
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            Dim oCred As wrCredito.wsLibCred = New wrCredito.wsLibCred, pCampos As String, pValores As String

            Select Case oCred.AutorizarDatos(Trim(txtCodigo.Text), "x", "x", "x", "x")
                Case 1
                    MsgBox("El C�digo del Tipo de Garant�a no puede quedar vac�o. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "M�dulo Cr�ditos")
                    Exit Sub
            End Select

            If Me.btnGuardar1.Text = "&Guardar" Then
                pCampos = "CodTipoGarantias,Descripcion"
                pValores = "'" & Trim(txtCodigo.Text) & "','" & Trim(txtDescripcion.Text) & "'"
                If oCred.InsertarTipGarant(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El tipo de Garant�a NO ha sido agregada. Verif�que e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validaci�n/Derechos en M�dulo Cr�ditos")
                End If
            ElseIf Me.btnGuardar1.Text = "&Modificar" Then
                pCampos = "Descripcion='" & Trim(txtDescripcion.Text) & "'"
                If oCred.ModificarTipGarant(Trim(pCodigo), pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El tipo de Garant�a no ha sido modificada. Verif�que e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validaci�n/Derechos en M�dulo Cr�ditos")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtDescripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            btnGuardar1_Click(sender, e)
        End If
    End Sub

End Class
