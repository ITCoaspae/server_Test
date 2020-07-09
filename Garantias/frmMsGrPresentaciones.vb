Public Class frmMsGrPresentaciones
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager

    Private pNoDoc As String, pTipo As String, pAccion As String, pCorrelativo As String
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

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
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(125, 86)
        Me.txtDescripcion.MaxLength = 0
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(400, 56)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(125, 60)
        Me.txtCodigo.MaxLength = 20
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(152, 20)
        Me.txtCodigo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "No. Presentación:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(450, 148)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(75, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 233
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'frmMsGrPresentaciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(556, 193)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMsGrPresentaciones"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Presentaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
#Region "Propiedades"
    Public Property NoDoc() As String
        Get
            Return pNoDoc
        End Get
        Set(ByVal Value As String)
            pNoDoc = Value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return pTipo
        End Get
        Set(ByVal Value As String)
            pTipo = Value
        End Set
    End Property

    Public Property Accion() As String
        Get
            Return pAccion
        End Get
        Set(ByVal Value As String)
            pAccion = Value
        End Set
    End Property

    Public Property Correlativo() As String
        Get
            Return pCorrelativo
        End Get
        Set(ByVal Value As String)
            pCorrelativo = Value
        End Set
    End Property

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Dim oCred As New wrCredito.wsLibCred, pCampos As String, pValores As String
        If Me.txtCodigo.Text.Trim = "" Then
            MsgBox("El No. de Presentación no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Garantías")
            Exit Sub
        End If
        Try
            If Me.pAccion = "Guardar" Then
                pCampos = "NoComprobante,NoPresentacion,Descripcion,Tipo"
                pValores = "'" & pNoDoc & "','" & Trim(txtCodigo.Text) & "','" & Trim(txtDescripcion.Text) & "','" & pTipo & "'"
                If oCred.InsertaPresentaciones(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Presentación ingresada exitosamente.", MsgBoxStyle.Information, "Módulo - Garantías")
                    Me.Dispose()
                Else
                    MsgBox("La presentación NO ha sido agregada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Garantías")
                End If
            ElseIf Me.pAccion = "Modificar" Then
                pCampos = "NoPresentacion='" & Trim(Me.txtCodigo.Text) & "',Descripcion='" & Trim(Me.txtDescripcion.Text) & "'"
                If oCred.ModificarPresentaciones(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Presentación actualizada exitosamente.", MsgBoxStyle.Information, "Módulo - Garantías")
                    Me.Dispose()
                Else
                    MsgBox("La presentación no ha sido modificada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Garantías")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

    Private Sub frmMsGrPresentaciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCred As New wrCredito.wsLibCred, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        Try
            If Me.pAccion = "Modificar" Then
                ds = oCred.CONSULTARPRESENTACIONES(sUsuario, sPassword, sSucursal, Me.pNoDoc, 2, Me.pCorrelativo)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtCodigo.Text = IIf(IsDBNull(Filas.Item(0)("NoPresentacion")), "", Filas.Item(0)("NoPresentacion"))
                    Me.txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                End If
            End If
            Me.txtCodigo.Focus()
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

End Class