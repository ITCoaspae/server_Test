Imports System.ComponentModel

Public Class frmMsBCCheque
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Dim Bancos As New wrBancos.wsLibBancos
    Public FormOrigen As Integer 'Evalua el formulario que genera la llamada , 1 = Modulo Creditos, 0 = Bancos.
    Dim Creditos As New wrCredito.wsLibCred
    Public Monto_Desembolso As Double
    Public CodTipoCredito As String
    Friend WithEvents chkPrincipal As System.Windows.Forms.CheckBox
    Friend WithEvents chkPersonNatural As System.Windows.Forms.CheckBox
    Friend WithEvents btnImprimir1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnGuardar1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPartida1 As MetroFramework.Controls.MetroButton
    Public NumSolicitud As Integer
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents gbDatDoc As System.Windows.Forms.GroupBox
    Friend WithEvents ttipAsoc As System.Windows.Forms.ToolTip
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents C1NEMonto As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCtaBanco As System.Windows.Forms.TextBox
    Friend WithEvents txtNoCheque As System.Windows.Forms.TextBox
    Friend WithEvents dtpFec As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPagueseA As System.Windows.Forms.TextBox
    Friend WithEvents txtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents txtNumPartida As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.gbDatDoc = New System.Windows.Forms.GroupBox()
        Me.chkPersonNatural = New System.Windows.Forms.CheckBox()
        Me.chkPrincipal = New System.Windows.Forms.CheckBox()
        Me.txtNumPartida = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C1NEMonto = New C1.Win.C1Input.C1NumericEdit()
        Me.dtpFec = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPagueseA = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCtaBanco = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtConcepto = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtNoCheque = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.ttipAsoc = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnImprimir1 = New MetroFramework.Controls.MetroButton()
        Me.btnGuardar1 = New MetroFramework.Controls.MetroButton()
        Me.btnPartida1 = New MetroFramework.Controls.MetroButton()
        Me.gbDatDoc.SuspendLayout()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDatDoc
        '
        Me.gbDatDoc.BackColor = System.Drawing.Color.White
        Me.gbDatDoc.Controls.Add(Me.chkPersonNatural)
        Me.gbDatDoc.Controls.Add(Me.chkPrincipal)
        Me.gbDatDoc.Controls.Add(Me.txtNumPartida)
        Me.gbDatDoc.Controls.Add(Me.Label1)
        Me.gbDatDoc.Controls.Add(Me.C1NEMonto)
        Me.gbDatDoc.Controls.Add(Me.dtpFec)
        Me.gbDatDoc.Controls.Add(Me.Label6)
        Me.gbDatDoc.Controls.Add(Me.txtPagueseA)
        Me.gbDatDoc.Controls.Add(Me.Label3)
        Me.gbDatDoc.Controls.Add(Me.txtCiudad)
        Me.gbDatDoc.Controls.Add(Me.Label4)
        Me.gbDatDoc.Controls.Add(Me.txtCtaBanco)
        Me.gbDatDoc.Controls.Add(Me.Label15)
        Me.gbDatDoc.Controls.Add(Me.txtConcepto)
        Me.gbDatDoc.Controls.Add(Me.Label35)
        Me.gbDatDoc.Controls.Add(Me.txtNoCheque)
        Me.gbDatDoc.Controls.Add(Me.Label2)
        Me.gbDatDoc.Controls.Add(Me.Label31)
        Me.gbDatDoc.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatDoc.ForeColor = System.Drawing.Color.Teal
        Me.gbDatDoc.Location = New System.Drawing.Point(28, 73)
        Me.gbDatDoc.Name = "gbDatDoc"
        Me.gbDatDoc.Size = New System.Drawing.Size(729, 175)
        Me.gbDatDoc.TabIndex = 0
        Me.gbDatDoc.TabStop = False
        Me.gbDatDoc.Text = "Datos Generales del Cheque"
        '
        'chkPersonNatural
        '
        Me.chkPersonNatural.AutoSize = True
        Me.chkPersonNatural.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPersonNatural.ForeColor = System.Drawing.Color.Black
        Me.chkPersonNatural.Location = New System.Drawing.Point(541, 137)
        Me.chkPersonNatural.Name = "chkPersonNatural"
        Me.chkPersonNatural.Size = New System.Drawing.Size(132, 20)
        Me.chkPersonNatural.TabIndex = 151
        Me.chkPersonNatural.Text = "Persona Natural"
        Me.chkPersonNatural.UseVisualStyleBackColor = True
        '
        'chkPrincipal
        '
        Me.chkPrincipal.AutoSize = True
        Me.chkPrincipal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPrincipal.ForeColor = System.Drawing.Color.Black
        Me.chkPrincipal.Location = New System.Drawing.Point(634, 25)
        Me.chkPrincipal.Name = "chkPrincipal"
        Me.chkPrincipal.Size = New System.Drawing.Size(84, 20)
        Me.chkPrincipal.TabIndex = 150
        Me.chkPrincipal.Text = "Principal"
        Me.chkPrincipal.UseVisualStyleBackColor = True
        '
        'txtNumPartida
        '
        Me.txtNumPartida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumPartida.Location = New System.Drawing.Point(533, 105)
        Me.txtNumPartida.MaxLength = 8
        Me.txtNumPartida.Name = "txtNumPartida"
        Me.txtNumPartida.ReadOnly = True
        Me.txtNumPartida.Size = New System.Drawing.Size(144, 23)
        Me.txtNumPartida.TabIndex = 148
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(372, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 18)
        Me.Label1.TabIndex = 149
        Me.Label1.Text = "Número de Partida:"
        '
        'C1NEMonto
        '
        Me.C1NEMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.C1NEMonto.CustomFormat = "###,###,##0.00"
        Me.C1NEMonto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C1NEMonto.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.C1NEMonto.ImagePadding = New System.Windows.Forms.Padding(0, 0, 0, 0)
        Me.C1NEMonto.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.C1NEMonto.Location = New System.Drawing.Point(485, 52)
        Me.C1NEMonto.Name = "C1NEMonto"
        Me.C1NEMonto.PostValidation.ErrorMessage = "El valor debe ser positivo."
        Me.C1NEMonto.PostValidation.Inherit = C1.Win.C1Input.PostValidationInheritFlags.CaseSensitive
        Me.C1NEMonto.PostValidation.Intervals.AddRange(New C1.Win.C1Input.ValueInterval() {New C1.Win.C1Input.ValueInterval(New Decimal(New Integer() {0, 0, 0, 0}), Nothing, True, True)})
        Me.C1NEMonto.Size = New System.Drawing.Size(192, 26)
        Me.C1NEMonto.TabIndex = 3
        Me.C1NEMonto.Tag = Nothing
        Me.C1NEMonto.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        '
        'dtpFec
        '
        Me.dtpFec.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFec.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFec.Location = New System.Drawing.Point(149, 53)
        Me.dtpFec.Name = "dtpFec"
        Me.dtpFec.Size = New System.Drawing.Size(144, 23)
        Me.dtpFec.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 18)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Fecha:"
        '
        'txtPagueseA
        '
        Me.txtPagueseA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPagueseA.Location = New System.Drawing.Point(149, 136)
        Me.txtPagueseA.MaxLength = 100
        Me.txtPagueseA.Name = "txtPagueseA"
        Me.txtPagueseA.Size = New System.Drawing.Size(374, 23)
        Me.txtPagueseA.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 18)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Paguese A:"
        '
        'txtCiudad
        '
        Me.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCiudad.Location = New System.Drawing.Point(149, 108)
        Me.txtCiudad.MaxLength = 20
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(192, 23)
        Me.txtCiudad.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 19)
        Me.Label4.TabIndex = 139
        Me.Label4.Text = "Ciudad:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCtaBanco
        '
        Me.txtCtaBanco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCtaBanco.Location = New System.Drawing.Point(149, 28)
        Me.txtCtaBanco.MaxLength = 20
        Me.txtCtaBanco.Name = "txtCtaBanco"
        Me.txtCtaBanco.Size = New System.Drawing.Size(192, 23)
        Me.txtCtaBanco.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(391, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(115, 19)
        Me.Label15.TabIndex = 137
        Me.Label15.Text = "Cantidad:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtConcepto
        '
        Me.txtConcepto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConcepto.Location = New System.Drawing.Point(149, 80)
        Me.txtConcepto.MaxLength = 255
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(528, 23)
        Me.txtConcepto.TabIndex = 4
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(7, 85)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(77, 19)
        Me.Label35.TabIndex = 128
        Me.Label35.Text = "Concepto:"
        '
        'txtNoCheque
        '
        Me.txtNoCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoCheque.Location = New System.Drawing.Point(480, 25)
        Me.txtNoCheque.MaxLength = 8
        Me.txtNoCheque.Name = "txtNoCheque"
        Me.txtNoCheque.Size = New System.Drawing.Size(144, 23)
        Me.txtNoCheque.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 18)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "No. Cuenta Bancaria:"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(349, 30)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(135, 18)
        Me.Label31.TabIndex = 79
        Me.Label31.Text = "Número de Cheque:"
        '
        'btnImprimir1
        '
        Me.btnImprimir1.Location = New System.Drawing.Point(570, 255)
        Me.btnImprimir1.Name = "btnImprimir1"
        Me.btnImprimir1.Size = New System.Drawing.Size(90, 32)
        Me.btnImprimir1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnImprimir1.TabIndex = 49
        Me.btnImprimir1.Text = "Imprimir"
        Me.btnImprimir1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnImprimir1.UseSelectable = True
        Me.btnImprimir1.UseStyleColors = True
        '
        'btnGuardar1
        '
        Me.btnGuardar1.Location = New System.Drawing.Point(667, 255)
        Me.btnGuardar1.Name = "btnGuardar1"
        Me.btnGuardar1.Size = New System.Drawing.Size(90, 32)
        Me.btnGuardar1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnGuardar1.TabIndex = 50
        Me.btnGuardar1.Text = "Guardar"
        Me.btnGuardar1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnGuardar1.UseSelectable = True
        Me.btnGuardar1.UseStyleColors = True
        '
        'btnPartida1
        '
        Me.btnPartida1.Location = New System.Drawing.Point(439, 255)
        Me.btnPartida1.Name = "btnPartida1"
        Me.btnPartida1.Size = New System.Drawing.Size(124, 32)
        Me.btnPartida1.Style = MetroFramework.MetroColorStyle.Teal
        Me.btnPartida1.TabIndex = 52
        Me.btnPartida1.Text = "Partida Contable"
        Me.btnPartida1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.btnPartida1.UseSelectable = True
        Me.btnPartida1.UseStyleColors = True
        '
        'frmMsBCCheque
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(780, 302)
        Me.Controls.Add(Me.gbDatDoc)
        Me.Controls.Add(Me.btnPartida1)
        Me.Controls.Add(Me.btnGuardar1)
        Me.Controls.Add(Me.btnImprimir1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(780, 302)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(780, 302)
        Me.Name = "frmMsBCCheque"
        Me.ShowInTaskbar = False
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "Detalle de Cheque"
        Me.gbDatDoc.ResumeLayout(False)
        Me.gbDatDoc.PerformLayout()
        CType(Me.C1NEMonto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
#Region "Declaraciones"
    'Private vAccion As AlcalaLibs.Seguridad.clsUsuario.TipoAccion
    Private vAccion As sifLib.Seguridad.clsUsuario.TipoAccion
    'Private vEstado As AlcalaLibs.Bancos.clsBCBanco.EstadoCheques
    Private vEstado As sifLib.Bancos.clsBCBancos.EstadoCheques
    Private vNoPartida As String
    Private vCtaContableBco As String
    Private vChequeGuardado As Boolean
#End Region
#Region "Propiedades"

    Public Property ChequeGuardado() As Boolean
        Get
            Return vChequeGuardado
        End Get
        Set(ByVal Value As Boolean)
            vChequeGuardado = Value
        End Set
    End Property

    'Public Property Accion() As AlcalaLibs.Seguridad.clsUsuario.TipoAccion
    Public Property Accion() As sifLib.Seguridad.clsUsuario.TipoAccion
        Get
            Return vAccion
        End Get
        'Set(ByVal Value As AlcalaLibs.Seguridad.clsUsuario.TipoAccion)
        Set(ByVal Value As sifLib.Seguridad.clsUsuario.TipoAccion)
            vAccion = Value
        End Set
    End Property

    'Public Property Estado() As AlcalaLibs.Bancos.clsBCBanco.EstadoCheques
    Public Property Estado() As sifLib.Bancos.clsBCBancos.EstadoCheques
        Get
            Return vEstado
        End Get
        'Set(ByVal Value As AlcalaLibs.Bancos.clsBCBanco.EstadoCheques)
        Set(ByVal Value As sifLib.Bancos.clsBCBancos.EstadoCheques)
            vEstado = Value
        End Set
    End Property

    Public Property NoPartida() As String
        Get
            Return vNoPartida
        End Get
        Set(ByVal Value As String)
            vNoPartida = Value
        End Set
    End Property

    Public Property CtaContableBco() As String
        Get
            Return vCtaContableBco
        End Get
        Set(ByVal Value As String)
            vCtaContableBco = Value
        End Set
    End Property

#End Region
#Region "Métodos"
#Region "Métodos de Navegación"


#End Region
#End Region
    Private Sub frmMsBCCheque_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If FormOrigen = 1 Then
            Me.btnPartida1.Visible = False
            Me.btnImprimir1.Visible = False
        Else
            Me.chkPrincipal.Visible = False
            'If Me.Accion = AlcalaLibs.Seguridad.clsUsuario.TipoAccion.Insertar Then
            If Me.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Insertar Then
                Me.ChequeGuardado = False
                Me.dtpFec.Value = Date.Today
                'Me.vEstado = AlcalaLibs.Bancos.clsBCBanco.EstadoCheques.Digitado
                Me.vEstado = sifLib.Bancos.clsBCBancos.EstadoCheques.Digitado
                'ElseIf Me.Accion = AlcalaLibs.Seguridad.clsUsuario.TipoAccion.Modificar Then
            ElseIf Me.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Modificar Then
                Me.ChequeGuardado = True
                Me.btnImprimir1.Enabled = True
            End If
        End If
    End Sub

    Private Sub txtCtaBanco_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCtaBanco.DoubleClick
        Try
            Dim ofrm As New frmAGenerico
            ofrm.Text = "Buscar Cuenta Bancaria"
            Dim oPerif As wrBancos.wsLibBancos, ds As New Data.DataSet
            oPerif = New wrBancos.wsLibBancos
            ds = oPerif.ObtenerCuentaBanco("*", "", "idCtaBanco", sUsuario, sPassword, sSucursal)
            ofrm.Datos = ds
            ofrm.ColSeleccion = 0
            ofrm.RefrescarGrid()
            ofrm.ShowDialog()
            Me.txtCtaBanco.Text = ofrm.Resultado.Trim
            Me.CtaContableBco = ofrm.Resultado2.Trim
            Me.txtNoCheque.Text = Val(ofrm.C1fgrdResultado.Item(ofrm.C1fgrdResultado.RowSel, 6)) + 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnPartida1_Click(sender As Object, e As EventArgs) Handles btnPartida1.Click
        Try
            Dim ofrm As New frmPartida, dsDetP As System.Data.DataSet
            Dim oLib As New wrConta.wsLibContab
            If Me.txtNumPartida.Text.Trim <> "" Then

                ofrm.Tipo = sifLib.Contabilidad.clsPartidas.TipoPartidaModulo.Bancos

                ofrm.Accion = sifLib.Contabilidad.clsPartidas.TipoAccionPartidas.ModificarPartida
                ofrm.IdModifica = Me.txtNumPartida.Text.Trim
                ofrm.StartPosition = FormStartPosition.CenterScreen

                If vEstado = sifLib.Bancos.clsBCBancos.EstadoCheques.Anulado Or vEstado = sifLib.Bancos.clsBCBancos.EstadoCheques.Impreso Or Me.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Consultar Then
                    ofrm.btnGuardar1.Enabled = False
                    ofrm.btnGuardarPl1.Enabled = False
                    ofrm.btnAceptarLin1.Enabled = False
                End If
                ofrm.ShowDialog()
            Else

                ofrm.Tipo = sifLib.Contabilidad.clsPartidas.TipoPartidaModulo.Bancos
                ofrm.txtConcepto.Text = Me.txtConcepto.Text
                ofrm.txtDescripcion.Text = Me.txtConcepto.Text
                dsDetP = oLib.ObtenerPartidaVacia(sUsuario, sPassword, sSucursal)

                Dim dr As System.Data.DataRow = dsDetP.Tables("Det_Diario").NewRow
                dr("Correl") = 1
                dr("IdCuenta") = Me.CtaContableBco.Trim
                dr("CodCosto") = CentroCostoSucursal 'oLib. 'oLib.Recuperar_Cta_x_Centro_Costo(sSucursal, CtaContableBco) ' "11"
                dr("CodBeneficio") = CentroCostoSucursal ' oLib.Recuperar_Cta_x_Centro_Costo(sSucursal, CtaContableBco) '"11"
                dr("Descripcion") = ""
                dr("Cargo") = "0"
                dr("Abono") = Me.C1NEMonto.Value
                ofrm.txtDif.Text = Decimal.Parse(Me.C1NEMonto.Value)
                ofrm.txtTotalAbonos.Text = Decimal.Parse(Me.C1NEMonto.Value)
                ofrm.cmbTipoPartidas.Text = "EG - COMPROBANTES DE EGRESO"
                ofrm.dtpFecha.Value = Me.dtpFec.Value
                dr("Concepto") = Me.txtConcepto.Text
                ofrm.drNueva = dr
                ofrm.ShowDialog()
                NoPartida = ofrm.txtNumero.Text
                Me.txtNumPartida.Text = NoPartida
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnImprimir1_Click(sender As Object, e As EventArgs) Handles btnImprimir1.Click
        Try
            Dim oRep As wrBancos.wsLibBancos = New wrBancos.wsLibBancos ', pFecha As Date
            Dim ds As New Data.DataSet, pAnulado As Boolean
            'pFecha = Date.Today
            'If Me.Estado = AlcalaLibs.Bancos.clsBCBanco.EstadoCheques.Anulado Then
            If Me.Estado = sifLib.Bancos.clsBCBancos.EstadoCheques.Anulado Then
                pAnulado = True
            Else
                pAnulado = False
            End If
            NoNegociable = chkPersonNatural.Checked
            Me.Cursor = Cursors.WaitCursor
            ds = oRep.ImprimeCheque(Trim(Me.txtNoCheque.Text), Trim(NoPartida), dtpFec.Value.ToShortDateString, pAnulado, sUsuario, sPassword, sSucursal)
            Dim ofrm As New frmVisor(ds, 7, 0)
            ofrm.MdiParent = ofrmMain
            ofrm.Show()
            Me.Cursor = Cursors.Default
            Me.Close()
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardar1_Click(sender As Object, e As EventArgs) Handles btnGuardar1.Click
        Try
            If Me.FormOrigen = 1 Then 'Desembolso de Creditos
                Dim Resultado As Integer
                If Me.chkPrincipal.Checked = True Then
                    Resultado = Creditos.Partida_Desembolso_Prestamo(Me.txtNoCheque.Text.Trim, Me.txtCtaBanco.Text.Trim, "EG", Format(Me.dtpFec.Value, "Short Date"),
                                                     Me.txtConcepto.Text.Trim, Me.C1NEMonto.Value, Me.txtCiudad.Text.Trim, Me.txtPagueseA.Text.Trim,
                                                     Me.Monto_Desembolso, CodTipoCredito, NumSolicitud, sUsuario, "1", "1", sSucursal, 1, "", "", 0, "", "", 0, 0, "")
                Else
                    Resultado = Creditos.Partida_Desembolso_Prestamo(Me.txtNoCheque.Text.Trim, Me.txtCtaBanco.Text.Trim, "EG", Format(Me.dtpFec.Value, "Short Date"),
                                                     Me.txtConcepto.Text.Trim, Me.C1NEMonto.Value, Me.txtCiudad.Text.Trim, Me.txtPagueseA.Text.Trim,
                                                     Me.Monto_Desembolso, CodTipoCredito, NumSolicitud, sUsuario, "1", "1", sSucursal, 2, "", "", 0, "", "", 0, 0, "")
                End If

                If Resultado <> 0 Then
                    MsgBox("Cheque Ingresado Exitosamente", MsgBoxStyle.Information, "Modúlo - Créditos")
                    Me.Dispose()
                End If
            Else
                Dim oLibBco As New wrBancos.wsLibBancos
                If Me.txtNumPartida.Text.Trim.Length = 0 Then
                    MessageBox.Show("Debe agregar la partida contable primero", "Guardar Cheque", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else

                    If Me.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Insertar Then
                        If oLibBco.InsertaCheque("IdMovimiento,Num_Partida,IdEstado,IdCtaBanco,IdTipoMov,Fecha_Mov,Concepto,Cantidad,Ciudad,Paguese,Usu_Mov", "'" & Me.txtNoCheque.Text & "','" & NoPartida & "','D','" & Me.txtCtaBanco.Text & "','EG','" & Me.dtpFec.Value.Date & "','" & Me.txtConcepto.Text & "','" & Me.C1NEMonto.Value & "','" & Me.txtCiudad.Text & "','" & Me.txtPagueseA.Text & "','" & sUsuario & " '", sUsuario, sPassword, sSucursal) Then

                            Me.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Modificar
                            Me.btnImprimir1.Enabled = True
                            oLibBco.ModificaCuentaBanco(Trim(Me.txtCtaBanco.Text), "Corr_Cheque='" & Trim(Me.txtNoCheque.Text) & "'", sUsuario, sPassword, sSucursal)

                            MessageBox.Show("Cheque Agregado al Sistema", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                        Else
                            MessageBox.Show("Cheque NO Agregado al Sistema", "Ingreso de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                            Me.ChequeGuardado = False
                        End If
                        'ElseIf Me.Accion = AlcalaLibs.Seguridad.clsUsuario.TipoAccion.Modificar Then
                    ElseIf Me.Accion = sifLib.Seguridad.clsUsuario.TipoAccion.Modificar Then
                        'If Me.Estado = AlcalaLibs.Bancos.clsBCBanco.EstadoCheques.Digitado Then
                        If Me.Estado = sifLib.Bancos.clsBCBancos.EstadoCheques.Digitado Then
                            If oLibBco.ModificaCheque(Me.txtNoCheque.Text.Trim, "IdCtaBanco='" & Me.txtCtaBanco.Text & "',Fecha_Mov='" & Me.dtpFec.Value.Date & "',Concepto='" & Me.txtConcepto.Text & "',Cantidad='" & Me.C1NEMonto.Value & "',Ciudad='" & Me.txtCiudad.Text & "',Paguese='" & Me.txtPagueseA.Text & "',Usu_Mov=' '", sUsuario, sPassword, sSucursal) Then
                                oLibBco.ModificaCuentaBanco(Trim(Me.txtCtaBanco.Text), "Corr_Cheque='" & Trim(Me.txtNoCheque.Text) & "'", sUsuario, sPassword, sSucursal)
                                MessageBox.Show("Cheque Modificado en Sistema", "Modificación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                Me.ChequeGuardado = True

                            Else
                                MessageBox.Show("Cheque NO Modificado en el Sistema", "Modificación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                                Me.ChequeGuardado = False
                            End If
                        Else
                            MessageBox.Show("El cheque No puede ser modificado, debido a que ya fue impreso o se encuentra anulado", "Cheques", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en la Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmMsBCCheque_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Me.txtNumPartida.Text.Trim.Length > 0 Then
            If Me.ChequeGuardado = True Then
                Me.Dispose()
            Else
                MessageBox.Show("Debe guardar el Cheque antes de Salir", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            End If
        Else
            Me.Dispose()
        End If
    End Sub
End Class
