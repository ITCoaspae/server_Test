Imports System.IO
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data
Public Class wfCARGADT

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Dim op As New OpenFileDialog
        Dim ruta As String
        Dim mystream As Stream = Nothing
        OpenFileDialog1.InitialDirectory = "c:\"
        '  op.Filter = "libro de excel (*.xls)|*.xls|"
        OpenFileDialog1.RestoreDirectory = False
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            ruta = OpenFileDialog1.FileName
            'ruta = Path.GetDirectoryName(OpenFileDialog1.FileName) + "/" + OpenFileDialog1.FileName
            Me.TextBox1.Text = ruta
        End If
    End Sub
    Public Function IMPORTAR_EXCEL(ByVal RUTA As String)
        Dim dts As New DataSet
        Dim cn As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
                "Data Source=" & RUTA & _
                ";Extended Properties=""Excel 12.0;HDR=Yes;"""
        Dim cns As New OleDbConnection(cn)
        Dim dAdapter As New OleDbDataAdapter("select * from [hoja1$] ", cns)
        dAdapter.Fill(dts)
        Return dts
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        IMPORTAR_EXCEL(Me.TextBox1.Text)
    End Sub
End Class