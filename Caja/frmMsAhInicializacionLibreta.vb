Public Class frmMsAhInicializacionLibreta
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Public vDui As String
    Public vNocta As String
    Friend WithEvents btFrente1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btReverso1 As MetroFramework.Controls.MetroButton
    Public vNoExistMov As Boolean

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btFrente1 = New MetroFramework.Controls.MetroButton()
        Me.btReverso1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'btFrente1
        '
        Me.btFrente1.Location = New System.Drawing.Point(23, 63)
        Me.btFrente1.Name = "btFrente1"
        Me.btFrente1.Size = New System.Drawing.Size(113, 28)
        Me.btFrente1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btFrente1.TabIndex = 61
        Me.btFrente1.Text = "Frente Libreta"
        Me.btFrente1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btFrente1.UseSelectable = True
        Me.btFrente1.UseStyleColors = True
        '
        'btReverso1
        '
        Me.btReverso1.Location = New System.Drawing.Point(142, 63)
        Me.btReverso1.Name = "btReverso1"
        Me.btReverso1.Size = New System.Drawing.Size(113, 28)
        Me.btReverso1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btReverso1.TabIndex = 62
        Me.btReverso1.Text = "Reverso Libreta"
        Me.btReverso1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btReverso1.UseSelectable = True
        Me.btReverso1.UseStyleColors = True
        '
        'frmMsAhInicializacionLibreta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(295, 111)
        Me.Controls.Add(Me.btReverso1)
        Me.Controls.Add(Me.btFrente1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsAhInicializacionLibreta"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Inicialización de Libreta"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim dSet As New DataSet, pCodTipoAhorro As String, dsPt As New DataSet

    Public Property TipoAhorro() As String
        Get
            Return pCodTipoAhorro
        End Get
        Set(ByVal Value As String)
            pCodTipoAhorro = Value
        End Set
    End Property

    Public Property dsPosteo() As DataSet
        Get
            Return dsPt
        End Get
        Set(ByVal Value As DataSet)
            dsPt = Value
        End Set
    End Property

    Public Property ds() As DataSet
        Get
            Return dSet
        End Get
        Set(ByVal Value As DataSet)
            dSet = Value
        End Set
    End Property

    Private Sub btFrente1_Click(sender As Object, e As EventArgs) Handles btFrente1.Click
        Try
            If Mid(pCodTipoAhorro.Trim, 1, 1) = "5" Then
                Dim ofrm As New frmVisor(ds, 105, 0)
                ofrm.Show()
            Else
                Dim ofrm As New frmVisor(ds, 18, 0)
                ofrm.Show()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btReverso1_Click(sender As Object, e As EventArgs) Handles btReverso1.Click
        Try
            If vNoExistMov = True Then
                Dim ofrm As New frmVisor(dsPt, 106, 0)
                ofrm.Show()
            Else
                Dim ofrm As New frmVisor(dsPt, 21, 0)
                ofrm.Show()
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub



End Class