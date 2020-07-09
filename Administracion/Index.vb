Public Class Index
    Dim app As New wrAdmin.wsLibAdmin
    Dim vModulo, vEncabezado As String
    Public Property Modulo() As String
        Get
            Return vModulo
        End Get
        Set(ByVal value As String)
            vModulo = value
        End Set
    End Property
    Public Property encabezado() As String
        Get
            Return vEncabezado
        End Get
        Set(ByVal value As String)
            vEncabezado = value
        End Set
    End Property

    Private Sub TreeView1_Click(sender As Object, e As EventArgs)
        Dim form As New frmMAhCuentasAhorro
        form.MdiParent = Me
        Me.SplitContainer1.Panel2.Controls.Add(form)

        form.Show()
    End Sub
    Public Sub llenarMenu()
        fg.Visible = True
        Dim dts As New DataSet
        Dim x As Integer = 0
        ' QUITAR EL COMENTARIO, SE SUSTITUYO FUNCION POR SP
        dts = app.llenarMenu(sUsuario) 'CargaMenuPrivilegios("RTRIM(Descripcion) as  Descripcion ,Num_Programa,Nivel,isnull(formulario,'') as formulario,OpcionRS", "  left(num_programa,1)<>'A' and nivel > 0", "Num_Programa", sUsuario, sPassword, sSucursal)

        'dts = app.CargaMenuPrivilegios("RTRIM(Descripcion) as  Descripcion ,Num_Programa,Nivel,isnull(formulario,'') as formulario,OpcionRS", "  left(num_programa,1)<>'A' and nivel > 0", "Num_Programa", sUsuario, sPassword, sSucursal)
        fg.Rows.Count = dts.Tables(0).Rows.Count + 1
        fg.Cols.Fixed = 2
        fg.Tree.Column = 2
        fg.Tree.LineStyle = Drawing2D.DashStyle.Dash

        fg.Rows.Fixed = 1
        fg.Cols.Fixed = 1
        fg.Cols.Count = 7
        fg.Tree.Column = 1
        fg(0, 1) = encabezado
        fg(0, 2) = "Descripcion"
        fg(0, 3) = "Nivel"
        fg(0, 4) = "Formulario"
        fg(0, 5) = "Opcion"
        fg(0, 6) = "ParametroForm"

        fg.Cols(1).Width = 450
        fg.Cols(2).Width = 0
        fg.Cols(3).Width = 0
        fg.Cols(4).Width = 0
        fg.Cols(5).Width = 0
        fg.Cols(6).Width = 0
        For Each dr In dts.Tables(0).Rows
            x += 1
            fg(x, 1) = dr("Descripcion")
            fg(x, 2) = dr("Num_Programa")
            fg(x, 3) = dr("Nivel")
            fg(x, 4) = dr("formulario")
            fg(x, 5) = dr("OpcionRS")
            fg(x, 6) = dr("ParametroForm")
            fg.Rows(x).IsNode = True
            fg.Rows(x).Node.Level = dr("Nivel")
        Next
        x = 0
        For Each dr In dts.Tables(0).Rows
            x += 1
            If dr("Nivel") = 1 Then
                fg.Rows(x).Node.Collapsed = True
            ElseIf dr("Nivel") = 2 Then
                fg.Rows(x).Node.Collapsed = True
            Else
                fg.Rows(x).Node.Collapsed = True
            End If
        Next
    End Sub
    Private Sub Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sUsuario.Trim.Equals("") Then
            Dim form As New frmInicioSesion
            form.MdiParent = Me
            PanelFormularios.Controls.Add(form)
            PanelFormularios.MaximumSize = SplitContainer1.Panel2.Size
            ' MsgBox(SplitContainer1.Panel2.Size.ToString)
            ' Me.SplitContainer1.Panel2.Controls.Add(form)
            form.StartPosition = FormStartPosition.Manual
            form.Show()
            btnCerrarSesion.Visible = False
            'btnModulos.Visible = False

        End If

    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.PanelFormularios.Controls.Clear()
        sUsuario = ""
        sPassword = ""
        sSucursal = ""
        Dim form As New frmInicioSesion
        form.MdiParent = Me
        Me.PanelFormularios.Controls.Add(form)
        'Dim dts As New DataSet
        'fg.DataSource = dts.Tables(0)
        fg.Visible = False
        Me.fg.Clear()
        'Me.fg.DataSource = dts.Tables(0)
        'Me.SplitContainer1.Panel2.Controls.Add(form)
        form.StartPosition = FormStartPosition.Manual
        form.Show()
        btnCerrarSesion.Visible = False
        'btnModulos.Visible = False

    End Sub
    Private Sub minimizarFormAbiertos()
        For Each Obj As Form In PanelFormularios.Controls

            Obj.WindowState = FormWindowState.Minimized

        Next
    End Sub


    Private Sub fg_Click(sender As Object, e As EventArgs) Handles fg.Click
        'If fg.Rows(fg.RowSel).Node.Collapsed = True Then
        '    fg.Rows(fg.RowSel).Node.Collapsed = False
        'End   
        'MsgBox(fg.Item(fg.RowSel, 0))
        'MsgBox(fg.Item(fg.RowSel, 1))
        'MsgBox(fg.Item(fg.RowSel, 2))
        Dim numPrograma As String = ""
        Dim nombreFormulario As String
        Dim opcion As String
        Dim encabezado As String = ""
        Dim parametroForm As String = ""
        Try

            OpcionRS = 0
            numPrograma = fg.Item(fg.RowSel, 2).ToString.Trim
            nombreFormulario = fg.Item(fg.RowSel, 4).ToString.Trim
            OpcionRS = IIf(IsDBNull(fg.Item(fg.RowSel, 5)), 0, fg.Item(fg.RowSel, 5))
            parametroForm = IIf(IsDBNull(fg.Item(fg.RowSel, 6)), 0, fg.Item(fg.RowSel, 6))
            encabezado = fg.Item(fg.RowSel, 1).ToString.Trim
            'If IIf(IsDBNull(fg.Item(fg.RowSel, 5)), "", fg.Item(fg.RowSel, 5)) <> "" Then
            '    OpcionRS = fg.Item(fg.RowSel, 5).ToString.Trim
            'End If

            If nombreFormulario.Length > 0 Then
                minimizarFormAbiertos()



                Dim frmType As Type = Type.GetType("SIF_ERP." + nombreFormulario)
                Dim formu As Object = Activator.CreateInstance(frmType)
                formu.maximizebox = True
                formu.minimizebox = True

                formu.mdiParent = Me

                Dim frm As New frmAGenerico

                formu.text = encabezado

                formu.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
                formu.StartPosition = FormStartPosition.WindowsDefaultBounds

                If nombreFormulario = "frmMsReporteI" Then
                    formu.NumReporte = parametroForm
                End If
                If nombreFormulario = "frmMsCaLogin" Or nombreFormulario = "frmPartidaCorteCaja" Then
                    formu.origen = parametroForm
                End If
                If nombreFormulario = "frmRepMovCajaxDoc" Or nombreFormulario = "frmRptConcentracionGestion" Then
                    formu.tipo = parametroForm
                End If

                PanelFormularios.Controls.Add(formu)
                formu.show
                formu.BringToFront
                ' formu.MaximumSize = New System.Drawing.Size(Me.PanelFormularios.Width - 200, Me.PanelFormularios.Height - 150)
                formu.windowstate = FormWindowState.Normal
            End If
        Catch ex As Exception

        End Try




        fg.RowSel = 0
        numPrograma = ""
    End Sub


End Class