Public Class fmMsGrRestricciones
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpFecFin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpFecIni As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFecFin = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFecIni = New System.Windows.Forms.DateTimePicker()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(203, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Fecha Fin:"
        '
        'dtpFecFin
        '
        Me.dtpFecFin.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecFin.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecFin.Location = New System.Drawing.Point(281, 122)
        Me.dtpFecFin.Name = "dtpFecFin"
        Me.dtpFecFin.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecFin.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Fecha Inicio:"
        '
        'dtpFecIni
        '
        Me.dtpFecIni.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecIni.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecIni.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecIni.Location = New System.Drawing.Point(101, 122)
        Me.dtpFecIni.Name = "dtpFecIni"
        Me.dtpFecIni.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecIni.TabIndex = 1
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(101, 60)
        Me.txtDescripcion.MaxLength = 0
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(400, 56)
        Me.txtDescripcion.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(23, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Descripción:"
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(419, 122)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(82, 28)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 188
        Me.btnGuardar1.Text = "&Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'fmMsGrRestricciones
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(523, 167)
        Me.Controls.Add(Me.dtpFecFin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpFecIni)
        Me.Controls.Add(Me.txtDescripcion)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fmMsGrRestricciones"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Restricciones"
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
        Try
            If Me.pAccion = "Guardar" Then
                pCampos = "NoComprobante,Descripcion,FechaIni,FechaFin,Tipo"
                pValores = "'" & pNoDoc & "','" & Trim(txtDescripcion.Text) & "','" & Format(Me.dtpFecIni.Value, "dd/MM/yyyy") & "','" & Format(Me.dtpFecFin.Value, "dd/MM/yyyy") & "','" & pTipo & "'"
                If oCred.InsertaRestricciones(pCampos, pValores, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Restricción ingresada exitosamente.", MsgBoxStyle.Information, "Módulo - Garantías")
                    Me.Dispose()
                Else
                    MsgBox("La restricción NO ha sido agregada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Garantías")
                End If
            ElseIf Me.pAccion = "Modificar" Then
                pCampos = "Descripcion='" & Trim(Me.txtDescripcion.Text) & "',FechaIni='" & Format(Me.dtpFecIni.Value, "dd/MM/yyyy") & "',FechaFin='" & Format(Me.dtpFecFin.Value, "dd/MM/yyyy") & "'"
                If oCred.ModificarRestricciones(pCorrelativo, pCampos, sUsuario, sPassword, sSucursal) = True Then
                    MsgBox("Restricción actualizada exitosamente.", MsgBoxStyle.Information, "Módulo - Garantías")
                    Me.Dispose()
                Else
                    MsgBox("La restricción no ha sido modificada. Verifíque e intente de nuevo.", MsgBoxStyle.Critical, "Error de Validación/Derechos en Módulo Garantías")
                End If
            End If
        Catch ex As Exception
            MsgBox(mensajeError, MsgBoxStyle.Critical)
        End Try
    End Sub
#End Region
    Private Sub fmMsGrRestricciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim oCred As New wrCredito.wsLibCred, ds As New Data.DataSet
        Dim Filas As Data.DataRowCollection
        Try
            If Me.pAccion = "Modificar" Then

                ds = oCred.CONSULTARRESTRICCIONES(sUsuario, sPassword, sSucursal, Me.pNoDoc, 2, pCorrelativo) '"*", "Correlativo=" & pCorrelativo & "", "Correlativo", sUsuario, sPassword,sSucursal)

                Filas = ds.Tables(0).Rows()
                If Filas.Count > 0 Then
                    Me.txtDescripcion.Text = IIf(IsDBNull(Filas.Item(0)("Descripcion")), "", Filas.Item(0)("Descripcion"))
                    Me.dtpFecIni.Value = IIf(IsDBNull(Filas.Item(0)("FechaIni")), Now, Filas.Item(0)("FechaIni"))
                    Me.dtpFecFin.Value = IIf(IsDBNull(Filas.Item(0)("FechaFin")), Now, Filas.Item(0)("FechaFin"))
                End If
            End If
            Me.txtDescripcion.Focus()
        Catch ex As Exception
        End Try
    End Sub

End Class