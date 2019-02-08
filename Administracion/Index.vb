Public Class Index
    Dim app As New wrAdmin.wsLibAdmin
    Dim vModulo As String
    Public Property Modulo() As String
        Get
            Return vModulo
        End Get
        Set(ByVal value As String)
            vModulo = value
        End Set
    End Property

    Private Sub TreeView1_Click(sender As Object, e As EventArgs)
        Dim form As New frmMAhCuentasAhorro


        form.MdiParent = Me
        Me.SplitContainer1.Panel2.Controls.Add(form)

        form.Show()
    End Sub

    Private Sub Index_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dts As New DataSet
        Dim x As Integer = 0
        dts = app.CargaMenuPrivilegios("CONCAT(RTRIM(Num_Programa),'-',RTRIM(Descripcion) )Descripcion ,Num_Programa,Nivel", "left(num_programa,1)='" & Modulo & "'  and nivel > 1", "Num_Programa", sUsuario, sPassword, sSucursal)
        fg.Rows.Count = dts.Tables(0).Rows.Count + 1
        fg.Cols.Fixed = 2
        fg.Tree.Column = 2
        fg.Tree.LineStyle = Drawing2D.DashStyle.Dash

        fg.Rows.Fixed = 1
        fg.Cols.Fixed = 1
        fg.Cols.Count = 4
        fg.Tree.Column = 1
        fg(0, 1) = "No."
        fg(0, 2) = "Descripcion"
        fg(0, 3) = "Nivel"

        fg.Cols(1).Width = 450
        fg.Cols(2).Width = 0
        fg.Cols(3).Width = 0
        For Each dr In dts.Tables(0).Rows
            x += 1
            fg(x, 1) = dr("Descripcion")
            fg(x, 2) = dr("Num_Programa")
            fg(x, 3) = dr("Nivel")
            fg.Rows(x).IsNode = True
            fg.Rows(x).Node.Level = dr("Nivel")
        Next
        x = 0
        For Each dr In dts.Tables(0).Rows
            x += 1
            If dr("Nivel") = 1 Then
                fg.Rows(x).Node.Collapsed = False
            ElseIf dr("Nivel") = 2 Then
                fg.Rows(x).Node.Collapsed = True
            Else
                fg.Rows(x).Node.Collapsed = True
            End If
        Next
    End Sub

    Private Sub fg_Click(sender As Object, e As EventArgs) Handles fg.Click
        'If fg.Rows(fg.RowSel).Node.Collapsed = True Then
        '    fg.Rows(fg.RowSel).Node.Collapsed = False
        'End   
        'MsgBox(fg.Item(fg.RowSel, 0))
        'MsgBox(fg.Item(fg.RowSel, 1))
        'MsgBox(fg.Item(fg.RowSel, 2))
        Dim numPrograma As String

        numPrograma = fg.Item(fg.RowSel, 2).ToString.Trim
        Select Case numPrograma
            Case "J61"
                Dim form As New frmMBCBancos
                form.MdiParent = Me
                Me.SplitContainer1.Panel2.Controls.Add(form)
                form.Show()
            Case "J62"
                Dim form As New frmMBCCuentasBancos
                form.MdiParent = Me
                Me.SplitContainer1.Panel2.Controls.Add(form)
                form.Show()
        End Select

    End Sub
End Class