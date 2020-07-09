Imports System.Security.Principal
Imports System.DirectoryServices
Imports System.Threading.Thread

Public Class frmInicioSesion
    Inherits MetroFramework.Forms.MetroForm 'Inherits System.Windows.Forms.Form
    Public rsc As System.Resources.ResourceManager
    Private vIngreso As Boolean
    Private vUsuario As String
    Dim administracion As New wrAdmin.wsLibAdmin
    Public Property Ingreso() As Boolean
        Get
            Return vIngreso
        End Get
        Set(ByVal Value As Boolean)
            vIngreso = Value
        End Set
    End Property
    Public Property Usuario() As String
        Get
            Return vUsuario
        End Get
        Set(ByVal Value As String)
            vUsuario = Value
        End Set
    End Property
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent() : Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly : rsc = New System.Resources.ResourceManager("SIF_ERP.resMain", asm) ' ' ' : Me.Icon = CType(rsc.GetObject("coaspaeLogo.ico"), System.Drawing.Icon)

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
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.LightGray
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(192, 194)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(194, 36)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "&CANCELAR"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Teal
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(-2, 194)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(194, 36)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "&INGRESAR"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.DimGray
        Me.txtPassword.Location = New System.Drawing.Point(26, 146)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPassword.Size = New System.Drawing.Size(325, 22)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.DimGray
        Me.txtUsuario.Location = New System.Drawing.Point(26, 85)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(325, 22)
        Me.txtUsuario.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkGray
        Me.Label2.Location = New System.Drawing.Point(23, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 22)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "CLAVE:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkGray
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 22)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "USUARIO:"
        '
        'frmInicioSesion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(451, 295)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmInicioSesion"
        Me.Style = MetroFramework.MetroColorStyle.Teal
        Me.Text = "INICIO DE SESIÓN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Try

            Dim oAdm As New wrAdmin.wsLibAdmin, vResponse As String, ds As New DataSet, dr As DataRow
            Dim vResp As String = ""
            sUsuario = Me.txtUsuario.Text.Trim
            sPassword = Me.txtPassword.Text.Trim
            sPC = My.Computer.Name.ToUpper.ToString

            vResponse = oAdm.VerificaUsuario(Me.txtUsuario.Text.Trim, Me.txtPassword.Text.Trim, sUsuario, sPassword, sSucursal)
            If vResponse = "" Then

                Dim dsPrivilegios As New DataSet
                sUsuario = Me.txtUsuario.Text.Trim
                sPassword = Me.txtPassword.Text.Trim
                If administracion.VerificarCambioContraseña(sUsuario) = True Then
                    Dim frm As New frmMsCambioPsw
                    With frm
                        .Usuario = sUsuario
                        .reset = False
                        .txtUsuario.ReadOnly = True
                        .txtClaveAnterior.ReadOnly = True
                        .txtClaveAnterior.Text = sPassword
                        .Text = "Cambio de Contraseña"
                        .ShowDialog()
                    End With
                    Exit Sub
                End If

                ds = oAdm.ConsultarUsuario("CodSucursal", "Usuario='" & Me.txtUsuario.Text.Trim & "'", "Usuario", sUsuario, sPassword, sSucursal)

                If ds.Tables("ADMUSUARIOS").Rows.Count > 0 Then
                    dr = ds.Tables("ADMUSUARIOS").Rows(0)
                    sSucursal = IIf(IsDBNull(dr("CodSucursal")), "", dr("CodSucursal"))
                End If
                'MessageBox.Show(sSucursal)

                '=============================================================================================================
                'recuperamos el cod. del centro de costo de la sucursal
                CentroCostoSucursal = oAdm.Consultar_CentroCostos_Sucursal(sSucursal).Tables(0).Rows(0).Item(0).ToString.Trim
                '=============================================================================================================



                ds = oAdm.ConsultarUsuarioxRol("CodRol", "a.Usuario='" & Me.txtUsuario.Text.Trim & "'", "a.Usuario", sUsuario, sPassword, sSucursal)

                Me.Ingreso = True
                Me.Usuario = Me.txtUsuario.Text.Trim

                Index.Text = "SISTEMA INTEGRAL FINANCIERO -- " & sUsuario.ToUpper
                Index.btnCerrarSesion.Visible = True
                Index.llenarMenu()

                Me.Close()

            Else
                MessageBox.Show(vResponse, "Autenticación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Me.Ingreso = False
                Me.txtPassword.Text = ""
                Me.txtPassword.Focus()
            End If
        Catch ex As Exception
           MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            btnLogin_Click(sender, e)
        End If
    End Sub
    'Private Sub frmInicioSesion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Me.txtUsuario.Focus()

    '    Try
    '        DesactivaMenus()
    '        If Me.txtUsuario.Focused = False Then
    '            Me.txtUsuario.Focus()
    '        End If
    '    Catch ex As Exception
    '       MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
    '    End Try
    'End Sub
    'Private Sub AccesoProgramas(ByVal ds As DataSet)
    '    Dim dv As New DataView, dr As DataRow, pName As String, omnu As MenuItem, oN2mnu As MenuItem, oN3mnu As MenuItem, oN4mnu As MenuItem
    '    dv = New DataView(ds.Tables(0))
    '    For Each dr In ds.Tables(0).Rows
    '        If dr("Pass") = "1" Then
    '            pName = dr("Num_Programa")
    '            Select Case pName.Substring(0, 1)
    '                Case "E"
    '                    For Each omnu In ofrmMain.mnuAhorros.MenuItems
    '                        If Mid(omnu.Text, 1, 3).Trim = pName Then
    '                            omnu.Visible = True
    '                            Exit For
    '                        End If
    '                        For Each oN2mnu In omnu.MenuItems
    '                            If Mid(oN2mnu.Text, 1, 3).Trim = pName Then
    '                                oN2mnu.Visible = True
    '                                Exit For
    '                            End If
    '                            For Each oN3mnu In oN2mnu.MenuItems
    '                                If Mid(oN3mnu.Text, 1, 4).Trim = pName Then
    '                                    oN3mnu.Visible = True
    '                                    Exit For
    '                                End If
    '                                For Each oN4mnu In oN3mnu.MenuItems
    '                                    If Mid(oN4mnu.Text, 1, 5).Trim = pName Then
    '                                        oN4mnu.Visible = True
    '                                        Exit For
    '                                    End If
    '                                Next
    '                            Next
    '                        Next
    '                    Next
    '                Case "C"
    '                    For Each omnu In ofrmMain.mnuAsociados.MenuItems
    '                        If Mid(omnu.Text, 1, 3).Trim = pName Then
    '                            omnu.Visible = True
    '                            Exit For
    '                        End If
    '                        For Each oN2mnu In omnu.MenuItems
    '                            If Mid(oN2mnu.Text, 1, 3).Trim = pName Then
    '                                oN2mnu.Visible = True
    '                                Exit For
    '                            End If
    '                            For Each oN3mnu In oN2mnu.MenuItems
    '                                If Mid(oN3mnu.Text, 1, 4).Trim = pName Then
    '                                    oN3mnu.Visible = True
    '                                    Exit For
    '                                End If
    '                                For Each oN4mnu In oN3mnu.MenuItems
    '                                    If Mid(oN4mnu.Text, 1, 5).Trim = pName Then
    '                                        oN4mnu.Visible = True
    '                                        Exit For
    '                                    End If
    '                                Next
    '                            Next
    '                        Next
    '                    Next
    '                Case "D"
    '                    For Each omnu In ofrmMain.mnuAportaciones.MenuItems
    '                        If Mid(omnu.Text, 1, 3).Trim = pName Then
    '                            omnu.Visible = True
    '                            Exit For
    '                        End If
    '                        For Each oN2mnu In omnu.MenuItems
    '                            If Mid(oN2mnu.Text, 1, 3).Trim = pName Then
    '                                oN2mnu.Visible = True
    '                                Exit For
    '                            End If
    '                            For Each oN3mnu In oN2mnu.MenuItems
    '                                If Mid(oN3mnu.Text, 1, 4).Trim = pName Then
    '                                    oN3mnu.Visible = True
    '                                    Exit For
    '                                End If
    '                                For Each oN4mnu In oN3mnu.MenuItems
    '                                    If Mid(oN4mnu.Text, 1, 5).Trim = pName Then
    '                                        oN4mnu.Visible = True
    '                                        Exit For
    '                                    End If
    '                                Next
    '                            Next
    '                        Next
    '                    Next
    '                Case "J"
    '                    For Each omnu In ofrmMain.mnuContabilidad.MenuItems
    '                        If Mid(omnu.Text, 1, 3).Trim = pName Then
    '                            omnu.Visible = True
    '                            Exit For
    '                        End If
    '                        For Each oN2mnu In omnu.MenuItems
    '                            If Mid(oN2mnu.Text, 1, 3).Trim = pName Then
    '                                oN2mnu.Visible = True
    '                                Exit For
    '                            End If
    '                            For Each oN3mnu In oN2mnu.MenuItems
    '                                If Mid(oN3mnu.Text, 1, 4).Trim = pName Then
    '                                    oN3mnu.Visible = True
    '                                    Exit For
    '                                End If
    '                                For Each oN4mnu In oN3mnu.MenuItems
    '                                    If Mid(oN4mnu.Text, 1, 5).Trim = pName Then
    '                                        oN4mnu.Visible = True
    '                                        Exit For
    '                                    End If
    '                                Next
    '                            Next
    '                        Next
    '                    Next
    '                Case "G"
    '                    For Each omnu In ofrmMain.mnuCobranza.MenuItems
    '                        If Mid(omnu.Text, 1, 3).Trim = pName Then
    '                            omnu.Visible = True
    '                            Exit For
    '                        End If
    '                        For Each oN2mnu In omnu.MenuItems
    '                            If Mid(oN2mnu.Text, 1, 3).Trim = pName Then
    '                                oN2mnu.Visible = True
    '                                Exit For
    '                            End If
    '                            For Each oN3mnu In oN2mnu.MenuItems
    '                                If Mid(oN3mnu.Text, 1, 4).Trim = pName Then
    '                                    oN3mnu.Visible = True
    '                                    Exit For
    '                                End If
    '                                For Each oN4mnu In oN3mnu.MenuItems
    '                                    If Mid(oN4mnu.Text, 1, 5).Trim = pName Then
    '                                        oN4mnu.Visible = True
    '                                        Exit For
    '                                    End If
    '                                Next
    '                            Next
    '                        Next
    '                    Next
    '                Case "A"
    '                    For Each omnu In ofrmMain.mnuInicio.MenuItems
    '                        If Mid(omnu.Text, 1, 3).Trim = pName Then
    '                            omnu.Visible = True
    '                            Exit For
    '                        End If
    '                        For Each oN2mnu In omnu.MenuItems
    '                            If Mid(oN2mnu.Text, 1, 3).Trim = pName Then
    '                                oN2mnu.Visible = True
    '                                Exit For
    '                            End If
    '                            For Each oN3mnu In oN2mnu.MenuItems
    '                                If Mid(oN3mnu.Text, 1, 4).Trim = pName Then
    '                                    oN3mnu.Visible = True
    '                                    Exit For
    '                                End If
    '                                For Each oN4mnu In oN3mnu.MenuItems
    '                                    If Mid(oN4mnu.Text, 1, 5).Trim = pName Then
    '                                        oN4mnu.Visible = True
    '                                        Exit For
    '                                    End If
    '                                Next
    '                            Next
    '                        Next
    '                    Next
    '                Case "F"
    '                    For Each omnu In ofrmMain.mnuCreditos.MenuItems
    '                        If Mid(omnu.Text, 1, 3).Trim = pName Then
    '                            omnu.Visible = True
    '                            Exit For
    '                        End If
    '                        For Each oN2mnu In omnu.MenuItems
    '                            If Mid(oN2mnu.Text, 1, 3).Trim = pName Then
    '                                oN2mnu.Visible = True
    '                                Exit For
    '                            End If
    '                            For Each oN3mnu In oN2mnu.MenuItems
    '                                If Mid(oN3mnu.Text, 1, 4).Trim = pName Then
    '                                    oN3mnu.Visible = True
    '                                    Exit For
    '                                End If
    '                                For Each oN4mnu In oN3mnu.MenuItems
    '                                    If Mid(oN4mnu.Text, 1, 5).Trim = pName Then
    '                                        oN4mnu.Visible = True
    '                                        Exit For
    '                                    End If
    '                                Next
    '                            Next
    '                        Next
    '                    Next
    '                Case "B"
    '                    For Each omnu In ofrmMain.mnuAdministracion.MenuItems
    '                        If Mid(omnu.Text, 1, 3).Trim = pName Then
    '                            omnu.Visible = True
    '                            Exit For
    '                        End If
    '                        For Each oN2mnu In omnu.MenuItems
    '                            If Mid(oN2mnu.Text, 1, 3).Trim = pName Then
    '                                oN2mnu.Visible = True
    '                                Exit For
    '                            End If
    '                            For Each oN3mnu In oN2mnu.MenuItems
    '                                If Mid(oN3mnu.Text, 1, 4).Trim = pName Then
    '                                    oN3mnu.Visible = True
    '                                    Exit For
    '                                End If
    '                                For Each oN4mnu In oN3mnu.MenuItems
    '                                    If Mid(oN4mnu.Text, 1, 5).Trim = pName Then
    '                                        oN4mnu.Visible = True
    '                                        Exit For
    '                                    End If
    '                                Next
    '                            Next
    '                        Next
    '                    Next
    '                Case "H"

    '                    For Each omnu In ofrmMain.mnuCaja.MenuItems
    '                        If Mid(omnu.Text, 1, 3).Trim = pName Then
    '                            omnu.Visible = True
    '                            Exit For
    '                        End If
    '                        For Each oN2mnu In omnu.MenuItems
    '                            If Mid(oN2mnu.Text, 1, 3).Trim = pName Then
    '                                oN2mnu.Visible = True
    '                                Exit For
    '                            End If
    '                            For Each oN3mnu In oN2mnu.MenuItems
    '                                If Mid(oN3mnu.Text, 1, 4).Trim = pName Then
    '                                    oN3mnu.Visible = True
    '                                    Exit For
    '                                End If
    '                                For Each oN4mnu In oN3mnu.MenuItems
    '                                    If Mid(oN4mnu.Text, 1, 5).Trim = pName Then
    '                                        oN4mnu.Visible = True
    '                                        Exit For
    '                                    End If
    '                                Next
    '                            Next
    '                        Next
    '                    Next
    '                Case "K"
    '                    For Each omnu In ofrmMain.mnuPlanilla.MenuItems
    '                        If Mid(omnu.Text, 1, 3).Trim = pName Then
    '                            omnu.Visible = True
    '                            Exit For
    '                        End If
    '                        For Each oN2mnu In omnu.MenuItems
    '                            If Mid(oN2mnu.Text, 1, 3).Trim = pName Then
    '                                oN2mnu.Visible = True
    '                                Exit For
    '                            End If
    '                            For Each oN3mnu In oN2mnu.MenuItems
    '                                If Mid(oN3mnu.Text, 1, 4).Trim = pName Then
    '                                    oN3mnu.Visible = True
    '                                    Exit For
    '                                End If
    '                                For Each oN4mnu In oN3mnu.MenuItems
    '                                    If Mid(oN4mnu.Text, 1, 5).Trim = pName Then
    '                                        oN4mnu.Visible = True
    '                                        Exit For
    '                                    End If
    '                                Next
    '                            Next
    '                        Next
    '                    Next
    '                Case "N"
    '                    For Each omnu In ofrmMain.mnuGerenciales.MenuItems
    '                        If Mid(omnu.Text, 1, 3).Trim = pName Then
    '                            omnu.Visible = True
    '                            Exit For
    '                        End If
    '                        For Each oN2mnu In omnu.MenuItems
    '                            If Mid(oN2mnu.Text, 1, 3).Trim = pName Then
    '                                oN2mnu.Visible = True
    '                                Exit For
    '                            End If
    '                            For Each oN3mnu In oN2mnu.MenuItems
    '                                If Mid(oN3mnu.Text, 1, 4).Trim = pName Then
    '                                    oN3mnu.Visible = True
    '                                    Exit For
    '                                End If
    '                                For Each oN4mnu In oN3mnu.MenuItems
    '                                    If Mid(oN4mnu.Text, 1, 5).Trim = pName Then
    '                                        oN4mnu.Visible = True
    '                                        Exit For
    '                                    End If
    '                                Next
    '                            Next
    '                        Next
    '                    Next
    '                Case "O"
    '                    For Each omnu In ofrmMain.mnuActivoFijo.MenuItems
    '                        If Mid(omnu.Text, 1, 3).Trim = pName Then
    '                            omnu.Visible = True
    '                            Exit For
    '                        End If
    '                        For Each oN2mnu In omnu.MenuItems
    '                            If Mid(oN2mnu.Text, 1, 3).Trim = pName Then
    '                                oN2mnu.Visible = True
    '                                Exit For
    '                            End If
    '                            For Each oN3mnu In oN2mnu.MenuItems
    '                                If Mid(oN3mnu.Text, 1, 4).Trim = pName Then
    '                                    oN3mnu.Visible = True
    '                                    Exit For
    '                                End If
    '                                For Each oN4mnu In oN3mnu.MenuItems
    '                                    If Mid(oN4mnu.Text, 1, 5).Trim = pName Then
    '                                        oN4mnu.Visible = True
    '                                        Exit For
    '                                    End If
    '                                Next
    '                            Next
    '                        Next
    '                    Next
    '                Case "L"
    '                    For Each omnu In ofrmMain.mnuGeneral.MenuItems
    '                        If Mid(omnu.Text, 1, 3).Trim = pName Then
    '                            omnu.Visible = True
    '                            Exit For
    '                        End If
    '                        For Each oN2mnu In omnu.MenuItems
    '                            If Mid(oN2mnu.Text, 1, 3).Trim = pName Then
    '                                oN2mnu.Visible = True
    '                                Exit For
    '                            End If
    '                            For Each oN3mnu In oN2mnu.MenuItems
    '                                If Mid(oN3mnu.Text, 1, 4).Trim = pName Then
    '                                    oN3mnu.Visible = True
    '                                    Exit For
    '                                End If
    '                                For Each oN4mnu In oN3mnu.MenuItems
    '                                    If Mid(oN4mnu.Text, 1, 5).Trim = pName Then
    '                                        oN4mnu.Visible = True
    '                                        Exit For
    '                                    End If
    '                                Next
    '                            Next
    '                        Next
    '                    Next
    '                Case "M"
    '                    For Each omnu In ofrmMain.mnuGarantias.MenuItems
    '                        If Mid(omnu.Text, 1, 3).Trim = pName Then
    '                            omnu.Visible = True
    '                            Exit For
    '                        End If
    '                        For Each oN2mnu In omnu.MenuItems
    '                            If Mid(oN2mnu.Text, 1, 3).Trim = pName Then
    '                                oN2mnu.Visible = True
    '                                Exit For
    '                            End If
    '                            For Each oN3mnu In oN2mnu.MenuItems
    '                                If Mid(oN3mnu.Text, 1, 4).Trim = pName Then
    '                                    oN3mnu.Visible = True
    '                                    Exit For
    '                                End If
    '                                For Each oN4mnu In oN3mnu.MenuItems
    '                                    If Mid(oN4mnu.Text, 1, 5).Trim = pName Then
    '                                        oN4mnu.Visible = True
    '                                        Exit For
    '                                    End If
    '                                Next
    '                            Next
    '                        Next
    '                    Next
    '            End Select
    '        End If
    '    Next
    'End Sub
    'Private Sub DesactivaMenus()
    '    Dim omnu As MenuItem, oN2mnu As MenuItem, oN3mnu As MenuItem, oN4mnu As MenuItem
    '    For Each omnu In ofrmMain.MainMenu1.MenuItems
    '        omnu.Visible = True
    '        For Each oN2mnu In omnu.MenuItems
    '            oN2mnu.Visible = False
    '            If oN2mnu.Text.Trim = "A1 - Cerrar Sesión" Or oN2mnu.Text.Trim = "A2 - Cargar Aplicación" Or oN2mnu.Text.Trim = "A3 - &Salir" Or oN2mnu.Text = "Cascada" Or oN2mnu.Text = "Vertical" Or oN2mnu.Text = "Horizontal" Or oN2mnu.Text = "A1 - Inicio de Sesión" Then
    '                oN2mnu.Visible = True
    '            End If
    '            For Each oN3mnu In oN2mnu.MenuItems
    '                oN3mnu.Visible = False
    '                For Each oN4mnu In oN3mnu.MenuItems
    '                    oN4mnu.Visible = False
    '                Next
    '            Next
    '        Next
    '    Next
    '    For Each omnu In ofrmMain.mnuAsociados.MenuItems
    '        omnu.Visible = True
    '        For Each oN2mnu In omnu.MenuItems
    '            oN2mnu.Visible = False
    '            If oN2mnu.Text.Trim = "A1 - Cerrar Sesión" Or oN2mnu.Text.Trim = "A2 - Cargar Aplicación" Or oN2mnu.Text.Trim = "A3 - &Salir" Or oN2mnu.Text = "Cascada" Or oN2mnu.Text = "Vertical" Or oN2mnu.Text = "Horizontal" Or oN2mnu.Text = "A1 - Inicio de Sesión" Then
    '                oN2mnu.Visible = True
    '            End If
    '            For Each oN3mnu In oN2mnu.MenuItems
    '                oN3mnu.Visible = False
    '                For Each oN4mnu In oN3mnu.MenuItems
    '                    oN4mnu.Visible = False
    '                Next
    '            Next
    '        Next
    '    Next
    '    For Each omnu In ofrmMain.mnuInicio.MenuItems
    '        omnu.Visible = True
    '        For Each oN2mnu In omnu.MenuItems
    '            oN2mnu.Visible = False
    '            If oN2mnu.Text.Trim = "A1 - Cerrar Sesión" Or oN2mnu.Text.Trim = "A2 - Cargar Aplicación" Or oN2mnu.Text.Trim = "A3 - &Salir" Or oN2mnu.Text = "Cascada" Or oN2mnu.Text = "Vertical" Or oN2mnu.Text = "Horizontal" Or oN2mnu.Text = "A1 - Inicio de Sesión" Then
    '                oN2mnu.Visible = True
    '            End If
    '            For Each oN3mnu In oN2mnu.MenuItems
    '                oN3mnu.Visible = False
    '                For Each oN4mnu In oN3mnu.MenuItems
    '                    oN4mnu.Visible = False
    '                Next
    '            Next
    '        Next
    '    Next
    '    For Each omnu In ofrmMain.mnuContabilidad.MenuItems
    '        omnu.Visible = True
    '        For Each oN2mnu In omnu.MenuItems
    '            oN2mnu.Visible = False
    '            If oN2mnu.Text.Trim = "A1 - Cerrar Sesión" Or oN2mnu.Text.Trim = "A2 - Cargar Aplicación" Or oN2mnu.Text.Trim = "A3 - &Salir" Or oN2mnu.Text = "Cascada" Or oN2mnu.Text = "Vertical" Or oN2mnu.Text = "Horizontal" Or oN2mnu.Text = "A1 - Inicio de Sesión" Then
    '                oN2mnu.Visible = True
    '            End If
    '            For Each oN3mnu In oN2mnu.MenuItems
    '                oN3mnu.Visible = False
    '                For Each oN4mnu In oN3mnu.MenuItems
    '                    oN4mnu.Visible = False
    '                Next
    '            Next
    '        Next
    '    Next
    '    For Each omnu In ofrmMain.mnuAportaciones.MenuItems
    '        omnu.Visible = True
    '        For Each oN2mnu In omnu.MenuItems
    '            oN2mnu.Visible = False
    '            If oN2mnu.Text.Trim = "A1 - Cerrar Sesión" Or oN2mnu.Text.Trim = "A2 - Cargar Aplicación" Or oN2mnu.Text.Trim = "A3 - &Salir" Or oN2mnu.Text = "Cascada" Or oN2mnu.Text = "Vertical" Or oN2mnu.Text = "Horizontal" Or oN2mnu.Text = "A1 - Inicio de Sesión" Then
    '                oN2mnu.Visible = True
    '            End If
    '            For Each oN3mnu In oN2mnu.MenuItems
    '                oN3mnu.Visible = False
    '                For Each oN4mnu In oN3mnu.MenuItems
    '                    oN4mnu.Visible = False
    '                Next
    '            Next
    '        Next
    '    Next
    '    For Each omnu In ofrmMain.mnuCreditos.MenuItems
    '        omnu.Visible = True
    '        For Each oN2mnu In omnu.MenuItems
    '            oN2mnu.Visible = False
    '            If oN2mnu.Text.Trim = "A1 - Cerrar Sesión" Or oN2mnu.Text.Trim = "A2 - Cargar Aplicación" Or oN2mnu.Text.Trim = "A3 - &Salir" Or oN2mnu.Text = "Cascada" Or oN2mnu.Text = "Vertical" Or oN2mnu.Text = "Horizontal" Or oN2mnu.Text = "A1 - Inicio de Sesión" Then
    '                oN2mnu.Visible = True
    '            End If
    '            For Each oN3mnu In oN2mnu.MenuItems
    '                oN3mnu.Visible = False
    '                For Each oN4mnu In oN3mnu.MenuItems
    '                    oN4mnu.Visible = False
    '                Next
    '            Next
    '        Next
    '    Next
    '    For Each omnu In ofrmMain.mnuAhorros.MenuItems
    '        omnu.Visible = True
    '        For Each oN2mnu In omnu.MenuItems
    '            oN2mnu.Visible = False
    '            If oN2mnu.Text.Trim = "A1 - Cerrar Sesión" Or oN2mnu.Text.Trim = "A2 - Cargar Aplicación" Or oN2mnu.Text.Trim = "A3 - &Salir" Or oN2mnu.Text = "Cascada" Or oN2mnu.Text = "Vertical" Or oN2mnu.Text = "Horizontal" Or oN2mnu.Text = "A1 - Inicio de Sesión" Then
    '                oN2mnu.Visible = True
    '            End If
    '            For Each oN3mnu In oN2mnu.MenuItems
    '                oN3mnu.Visible = False
    '                For Each oN4mnu In oN3mnu.MenuItems
    '                    oN4mnu.Visible = False
    '                Next
    '            Next
    '        Next
    '    Next
    '    For Each omnu In ofrmMain.mnuAdministracion.MenuItems
    '        omnu.Visible = True
    '        For Each oN2mnu In omnu.MenuItems
    '            oN2mnu.Visible = False
    '            If oN2mnu.Text.Trim = "A1 - Cerrar Sesión" Or oN2mnu.Text.Trim = "A2 - Cargar Aplicación" Or oN2mnu.Text.Trim = "A3 - &Salir" Or oN2mnu.Text = "Cascada" Or oN2mnu.Text = "Vertical" Or oN2mnu.Text = "Horizontal" Or oN2mnu.Text = "A1 - Inicio de Sesión" Then
    '                oN2mnu.Visible = True
    '            End If
    '            For Each oN3mnu In oN2mnu.MenuItems
    '                oN3mnu.Visible = False
    '                For Each oN4mnu In oN3mnu.MenuItems
    '                    oN4mnu.Visible = False
    '                Next
    '            Next
    '        Next
    '    Next
    '    For Each omnu In ofrmMain.mnuCaja.MenuItems
    '        omnu.Visible = True
    '        For Each oN2mnu In omnu.MenuItems
    '            oN2mnu.Visible = False
    '            If oN2mnu.Text.Trim = "A1 - Cerrar Sesión" Or oN2mnu.Text.Trim = "A2 - Cargar Aplicación" Or oN2mnu.Text.Trim = "A3 - &Salir" Or oN2mnu.Text = "Cascada" Or oN2mnu.Text = "Vertical" Or oN2mnu.Text = "Horizontal" Or oN2mnu.Text = "A1 - Inicio de Sesión" Then
    '                oN2mnu.Visible = True
    '            End If
    '            For Each oN3mnu In oN2mnu.MenuItems
    '                oN3mnu.Visible = False
    '                For Each oN4mnu In oN3mnu.MenuItems
    '                    oN4mnu.Visible = False
    '                Next
    '            Next
    '        Next
    '    Next
    '    For Each omnu In ofrmMain.mnuCobranza.MenuItems
    '        omnu.Visible = True
    '        For Each oN2mnu In omnu.MenuItems
    '            oN2mnu.Visible = False
    '            If oN2mnu.Text.Trim = "A1 - Cerrar Sesión" Or oN2mnu.Text.Trim = "A2 - Cargar Aplicación" Or oN2mnu.Text.Trim = "A3 - &Salir" Or oN2mnu.Text = "Cascada" Or oN2mnu.Text = "Vertical" Or oN2mnu.Text = "Horizontal" Or oN2mnu.Text = "A1 - Inicio de Sesión" Then
    '                oN2mnu.Visible = True
    '            End If
    '            For Each oN3mnu In oN2mnu.MenuItems
    '                oN3mnu.Visible = False
    '                For Each oN4mnu In oN3mnu.MenuItems
    '                    oN4mnu.Visible = False
    '                Next
    '            Next
    '        Next
    '    Next
    '    For Each omnu In ofrmMain.mnuPlanilla.MenuItems
    '        omnu.Visible = True
    '        For Each oN2mnu In omnu.MenuItems
    '            oN2mnu.Visible = False
    '            If oN2mnu.Text.Trim = "A1 - Cerrar Sesión" Or oN2mnu.Text.Trim = "A2 - Cargar Aplicación" Or oN2mnu.Text.Trim = "A3 - &Salir" Or oN2mnu.Text = "Cascada" Or oN2mnu.Text = "Vertical" Or oN2mnu.Text = "Horizontal" Or oN2mnu.Text = "A1 - Inicio de Sesión" Then
    '                oN2mnu.Visible = True
    '            End If
    '            For Each oN3mnu In oN2mnu.MenuItems
    '                oN3mnu.Visible = False
    '                For Each oN4mnu In oN3mnu.MenuItems
    '                    oN4mnu.Visible = False
    '                Next
    '            Next
    '        Next
    '    Next
    '    For Each omnu In ofrmMain.mnuGerenciales.MenuItems
    '        omnu.Visible = True
    '        For Each oN2mnu In omnu.MenuItems
    '            oN2mnu.Visible = False
    '            If oN2mnu.Text.Trim = "A1 - Cerrar Sesión" Or oN2mnu.Text.Trim = "A2 - Cargar Aplicación" Or oN2mnu.Text.Trim = "A3 - &Salir" Or oN2mnu.Text = "Cascada" Or oN2mnu.Text = "Vertical" Or oN2mnu.Text = "Horizontal" Or oN2mnu.Text = "A1 - Inicio de Sesión" Then
    '                oN2mnu.Visible = True
    '            End If
    '            For Each oN3mnu In oN2mnu.MenuItems
    '                oN3mnu.Visible = False
    '                For Each oN4mnu In oN3mnu.MenuItems
    '                    oN4mnu.Visible = False
    '                Next
    '            Next
    '        Next
    '    Next
    '    For Each omnu In ofrmMain.mnuActivoFijo.MenuItems
    '        omnu.Visible = True
    '        For Each oN2mnu In omnu.MenuItems
    '            oN2mnu.Visible = False
    '            If oN2mnu.Text.Trim = "A1 - Cerrar Sesión" Or oN2mnu.Text.Trim = "A2 - Cargar Aplicación" Or oN2mnu.Text.Trim = "A3 - &Salir" Or oN2mnu.Text = "Cascada" Or oN2mnu.Text = "Vertical" Or oN2mnu.Text = "Horizontal" Or oN2mnu.Text = "A1 - Inicio de Sesión" Then
    '                oN2mnu.Visible = True
    '            End If
    '            For Each oN3mnu In oN2mnu.MenuItems
    '                oN3mnu.Visible = False
    '                For Each oN4mnu In oN3mnu.MenuItems
    '                    oN4mnu.Visible = False
    '                Next
    '            Next
    '        Next
    '    Next
    '    For Each omnu In ofrmMain.mnuGeneral.MenuItems
    '        omnu.Visible = True
    '        For Each oN2mnu In omnu.MenuItems
    '            oN2mnu.Visible = False
    '            If oN2mnu.Text.Trim = "A1 - Cerrar Sesión" Or oN2mnu.Text.Trim = "A2 - Cargar Aplicación" Or oN2mnu.Text.Trim = "A3 - &Salir" Or oN2mnu.Text = "Cascada" Or oN2mnu.Text = "Vertical" Or oN2mnu.Text = "Horizontal" Or oN2mnu.Text = "A1 - Inicio de Sesión" Then
    '                oN2mnu.Visible = True
    '            End If
    '            For Each oN3mnu In oN2mnu.MenuItems
    '                oN3mnu.Visible = False
    '                For Each oN4mnu In oN3mnu.MenuItems
    '                    oN4mnu.Visible = False
    '                Next
    '            Next
    '        Next
    '    Next
    '    For Each omnu In ofrmMain.mnuGarantias.MenuItems
    '        omnu.Visible = True
    '        For Each oN2mnu In omnu.MenuItems
    '            oN2mnu.Visible = False
    '            If oN2mnu.Text.Trim = "A1 - Cerrar Sesión" Or oN2mnu.Text.Trim = "A2 - Cargar Aplicación" Or oN2mnu.Text.Trim = "A3 - &Salir" Or oN2mnu.Text = "Cascada" Or oN2mnu.Text = "Vertical" Or oN2mnu.Text = "Horizontal" Or oN2mnu.Text = "A1 - Inicio de Sesión" Then
    '                oN2mnu.Visible = True
    '            End If
    '            For Each oN3mnu In oN2mnu.MenuItems
    '                oN3mnu.Visible = False
    '                For Each oN4mnu In oN3mnu.MenuItems
    '                    oN4mnu.Visible = False
    '                Next
    '            Next
    '        Next
    '    Next
    'End Sub
    Private Sub txtUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuario.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Me.txtPassword.Focus()
        End If
    End Sub

End Class