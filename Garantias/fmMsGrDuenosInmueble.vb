Public Class fmMsGrDuenosInmueble
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkAsociado As System.Windows.Forms.CheckBox
    Friend WithEvents txtPorcentaje As System.Windows.Forms.NumericUpDown
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkAsociado = New System.Windows.Forms.CheckBox()
        Me.txtPorcentaje = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        CType(Me.txtPorcentaje, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkAsociado
        '
        Me.chkAsociado.Location = New System.Drawing.Point(161, 114)
        Me.chkAsociado.Name = "chkAsociado"
        Me.chkAsociado.Size = New System.Drawing.Size(95, 16)
        Me.chkAsociado.TabIndex = 2
        Me.chkAsociado.Text = "&Es Asociado"
        Me.chkAsociado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.DecimalPlaces = 2
        Me.txtPorcentaje.Location = New System.Drawing.Point(99, 114)
        Me.txtPorcentaje.Minimum = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(56, 20)
        Me.txtPorcentaje.TabIndex = 1
        Me.txtPorcentaje.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 39)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "Porcentaje propiedad:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(99, 60)
        Me.txtDescripcion.MaxLength = 0
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(376, 48)
        Me.txtDescripcion.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 31)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Nombre de Propietario:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(393, 114)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(82, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 187
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'fmMsGrDuenosInmueble
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(498, 171)
        Me.Controls.Add(Me.chkAsociado)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.txtPorcentaje)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescripcion)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(498, 171)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(498, 171)
        Me.Name = "fmMsGrDuenosInmueble"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Dueños del Inmueble"
        CType(Me.txtPorcentaje, System.ComponentModel.ISupportInitialize).EndInit()
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

        If Me.txtDescripcion.Text.Trim = "" Then
            MsgBox("El Nombre no puede quedar vacío. Verifique e intente de nuevo.", MsgBoxStyle.Critical, "Módulo Garantías")
            Exit Sub
        End If

        Try
            If Me.pAccion = "Guardar" Then
                pCampos = "NoComprobante,Nombre,Porcentaje,Asociado,Tipo"
                pValores = "'" & pNoDoc & "','" & Trim(Me.txtDescripcion.Text) & "','" & Val(Me.txtPorcentaje.Value) & "','" & IIf(Me.chkAsociado.Checked = True, "1", "0") & "','" & pTipo & "'"
                If oCred.InsertaDuenosInmueble(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El dueño del inmueble NO ha sido agregado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Garantías")
                End If
            ElseIf Me.pAccion = "Modificar" Then
                pCampos = "Nombre='" & Trim(Me.txtDescripcion.Text) & "',Porcentaje='" & Val(Me.txtPorcentaje.Value) & "',Asociado='" & IIf(Me.chkAsociado.Checked = True, "1", "0") & "'"
                If oCred.ModificarDuenosInmueble(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    Me.Dispose()
                Else
                    MsgBox("El dueño del inmueble no ha sido modificado. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Garantías")
                End If
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region



    Private Sub fmMsGrDuenosInmueble_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCred As New wrCredito.wsLibCred, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        Try
            If Me.pAccion = "Modificar" Then

                ' ds = oCred.ConsultarDuenosInmueble("*", "Correlativo=" & pCorrelativo & "", "Correlativo", sUsuario, sPassword,sSucursal)
                ds = oCred.CONSULTARDUENOSINMUEBLE(sUsuario, sPassword, sSucursal, 2, " ", pCorrelativo)
                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Nombre")), "", Filas.Item(0)("Nombre"))
                    Me.txtPorcentaje.Value = IIf(IsDBNull(Filas.Item(0)("Porcentaje")), 0, Filas.Item(0)("Porcentaje"))
                    Me.chkAsociado.Checked = IIf(IIf(IsDBNull(Filas.Item(0)("Asociado")), 0, Filas.Item(0)("Asociado")) = "1", True, False)
                End If
            End If
            Me.txtDescripcion.Focus()
        Catch ex As Exception
        End Try
    End Sub
End Class