Imports System.IO
Imports System.Text

Public Class frmMsCargaPlanillaPagosPrest
    Dim prestamos As New wrPrestamo.wsLibPrest
    Dim Bancos As New wrBancos.wsLibBancos
    Dim Creditos As New wrCredito.wsLibCred
    Dim ObjDataset As New DataSet
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Public Sub LlenarDg(ByVal Dts As DataSet)
        Me.DataGridView1.DataSource = Dts.Tables(0)
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
    End Sub
    Public Sub LlenarPagadurias(ByVal Campos As String, ByVal filtro As String, ByVal orden As String)
        Dim Dts As New DataSet
        Dts = Creditos.ConsultarPagaduria(Campos, filtro, orden, sUsuario, sPassword, sSucursal)
        Me.cbPagaduria.DataSource = Dts.Tables(0)

    End Sub
    Public Sub LlenarCBBancos(ByVal Campos As String, ByVal Orden As String, ByVal Usuario As String, ByVal Pwd As String, ByVal Psucursal As String)
        Dim Dts As New DataSet
        Dts = Bancos.ObtenerCuentaBanco(Campos, "", Orden, Usuario, Pwd, Psucursal)
        Me.cbCtaOrigen.DataSource = Dts.Tables(0)
    End Sub
#Region "Validaciones"
    Protected Function validar_Columnas() As Boolean
        If Me.DataGridView1.Columns.Count > 0 Then
            If Me.DataGridView1.Columns(0).HeaderText.ToString.Equals("dui", StringComparison.CurrentCulture) = True Then
                If Me.DataGridView1.Columns(1).HeaderText.ToString.Equals("codprestamo", StringComparison.CurrentCulture) = True Then
                    If Me.DataGridView1.Columns(2).HeaderText.ToString.Equals("cuota", StringComparison.CurrentCulture) = True Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Else
                Return False
            End If
        End If
    End Function
    Protected Function Validar_DUI(ByVal dui As String) As Boolean
        Dim Caracter As String
        Dim Correcto As Boolean
        If dui.Length = 10 Then
            For i As Integer = 0 To dui.Length - 1
                If i <> 8 Then
                    Caracter = dui.Chars(i).ToString
                    If CInt(Caracter) >= 0 And CInt(Caracter) <= 9 Then
                        Correcto = True
                    Else
                        Correcto = False
                        Return Correcto
                        Exit Function
                    End If
                Else
                    Caracter = dui.Chars(i).ToString
                    If Caracter.Equals("-", StringComparison.CurrentCulture) = False Then
                        Return False
                        Exit Function
                    End If
                End If
            Next
            Return True
        Else
            Return False
        End If
    End Function
    Protected Function Validar_CodPrestamo(ByVal CodPrestamo As String) As Boolean
        Dim Caracter As String
        If CodPrestamo.Length > 0 Then
            For i As Integer = 0 To CodPrestamo.Length - 1
                Caracter = CodPrestamo.Chars(i)
                If CInt(Caracter) >= 0 And CInt(Caracter) <= 9 Then
                    Return True
                Else
                    Return False
                    Exit Function
                End If
            Next
        Else
            Return False
        End If
    End Function
    Protected Function Validar_registros() As Boolean
        Dim dui, prestamo As Boolean
        Dim cadena As String
        Dim Incorrecto As Boolean
        Incorrecto = True
        If Me.DataGridView1.Rows.Count > 0 Then
            For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
                If Validar_DUI(Me.DataGridView1.Item("dui", i).Value.ToString) = True And Validar_CodPrestamo(Me.DataGridView1.Item("codprestamo", i).Value.ToString) = True Then
                    cadena += i.ToString + " " + Me.DataGridView1.Item("dui", i).Value.ToString + " " + Me.DataGridView1.Item("codprestamo", i).Value.ToString
                ElseIf Validar_DUI(Me.DataGridView1.Item("dui", i).Value.ToString) = False Then
                    Me.DataGridView1.Item("dui", i).Style.BackColor = Color.Red
                    Incorrecto = False
                ElseIf Validar_CodPrestamo(Me.DataGridView1.Item("codprestamo", i).Value.ToString) = False Then
                    Me.DataGridView1.Item("codprestamo", i).Style.BackColor = Color.Red
                    Incorrecto = False
                End If
            Next
        End If
        Return Incorrecto
    End Function
#End Region
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub frmMsImportarExcel_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cbCtaOrigen.DisplayMember = "NOM_Cuenta"
        Me.cbCtaOrigen.ValueMember = "IdCuenta"
        Me.cbPagaduria.DisplayMember = "Nombre"
        Me.cbPagaduria.ValueMember = "CodPagaduria"
        LlenarCBBancos("IdCuenta,NOM_Cuenta", "Nom_Banco", sUsuario, sPassword, sSucursal)
        LlenarPagadurias("Nombre,CodPagaduria", "", "Nombre")
    End Sub

    Private Sub btnCargar1_Click(sender As Object, e As EventArgs) Handles btnCargar1.Click
        Try
            Dim dt As DataTable
            Dim dts As New DataSet
            dt = New DataTable("cuentas")
            dt.Columns.Add("dui")
            dt.Columns.Add("codprestamo")
            'dtTransferencias.Columns.Add("Cta Origen")
            dt.Columns.Add("cuota")


            Dim fName As String = ""
            OpenFileDialog1.InitialDirectory = "c:\documents"
            OpenFileDialog1.Filter = "CSV files(*.csv)|*.csv"
            OpenFileDialog1.FilterIndex = 2
            OpenFileDialog1.RestoreDirectory = True
            If (OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                fName = OpenFileDialog1.FileName
            End If
            ' txtpathfile.Text = fName
            Dim TextLine As String = ""
            Dim SplitLine() As String


            If System.IO.File.Exists(fName) = True Then
                Dim objReader As New System.IO.StreamReader(fName, Encoding.ASCII)
                Do While objReader.Peek() <> -1
                    TextLine = objReader.ReadLine()
                    SplitLine = Split(TextLine, ";")

                    dt.Rows.Add(SplitLine)
                    'Me.DataGridView1.Rows.Add(SplitLine)
                Loop
                ObjDataset.Tables.Add(dt)
                Me.DataGridView1.DataSource = ObjDataset.Tables(0)
            Else
                MsgBox("File Does Not Exist")
            End If

        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try




        'Try
        '    Me.OpenFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
        '    Me.OpenFileDialog1.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx||"
        '    If Me.OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
        '        ObjDataset = ImportarExcel_Datagrid(Me.OpenFileDialog1.FileName)
        '        LlenarDg(ObjDataset)
        '    End If
        'Catch ex As Exception
        '    MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        'End Try
    End Sub

    Private Sub btnProcesar1_Click(sender As Object, e As EventArgs) Handles btnProcesar1.Click
        Try
            If MsgBox("Desea realizar esta acción", MsgBoxStyle.YesNo, "Confirmación de Transacción") = MsgBoxResult.Yes Then
                Dim resultado As Integer
                Dim Id_Carga As Integer
                Dim Incorrecto As String = ""
                Dim Pago As Integer
                If validar_Columnas() = True Then
                    If Validar_registros() = True Then
                        resultado = prestamos.CargarPlanillas_PagosPrestamos(Format(Me.dtpFecha.Value, "Short Date"), Me.cbPagaduria.SelectedValue.ToString.Trim,
                                                                             Me.cbCtaOrigen.SelectedValue.ToString, sUsuario, ObjDataset)
                        If resultado <> 0 Then
                            MsgBox("Transacción realizada exitosamente", MsgBoxStyle.Information, "Módulo - Créditos")
                            DataGridView1.DataSource = Nothing
                        Else
                            MsgBox("Error, por favor comunicarse con el administrador del sistema", MsgBoxStyle.Critical, "Módulo - Créditos")
                        End If
                    End If
                Else
                    MsgBox("el orden de las columnas o los nombres no coinciden con el formato requerido.", MsgBoxStyle.Critical, "Módulo - Créditos")
                End If
            End If
        Catch ex As Exception
            MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Try
            Dim archivo As String = "plantillaCargaPrestamo.csv"


            Dim folderBrowse As New FolderBrowserDialog
            Dim ruta As String

            If folderBrowse.ShowDialog() = DialogResult.OK Then
                ruta = folderBrowse.SelectedPath
            End If





            Dim path As String = ruta & "\" & archivo '"c:\temp\MyTest.txt"

            ' Create or overwrite the file.
            Dim fs As FileStream = File.Create(path)

            ' Add text to the file.
            Dim info As Byte() = New UTF8Encoding(True).GetBytes("00000000-0;01000002601;0.00")
            fs.Write(info, 0, info.Length)
            fs.Close()
            MsgBox("Archivo " & archivo.ToString & " creado en: " & ruta, MsgBoxStyle.Information)
        Catch ex As Exception

        End Try
    End Sub
End Class