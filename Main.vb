'Imports AlcalaLibs
'Imports sifLib
Imports System.Net.Mail
Imports System.Net.Mime
'Imports SIF_ERP.resMain
Imports System.Drawing.Bitmap

Module Main
    Public sUsuario As String = "", sPassword As String = "", sRol As String, sAnnio As Integer = Now.Year, sSucursal, sPC As String
    Public ofrmMain As New frmMAIN, vEmpresa As String
    Public PFecha As DateTime
    Public vNocta As String
    Public vDui As String
    Public OpcionRS As Integer
    Public CentroCostoSucursal As String
    Public NoNegociable As Boolean
    Public pCodCajero As Integer
    Public pNocaja As Integer
    Public mensajeError As String = "Error. Por favor comunicarse con el administrador de sistema."
    Sub Main()
        Application.Run(ofrmMain)
        sAnnio = Now.Year
    End Sub
    Public Function EnviarCorreo(ByVal adjunto As Boolean, ByRef mensaje As String, ByVal from As String, _
                                    ByVal toAddress As String, ByVal subject As String, ByVal body As String, _
                                    ByVal filename As String) As Boolean
        Dim Envio As Boolean
        Dim correo As New System.Net.Mail.MailMessage
        correo.From = New System.Net.Mail.MailAddress(from)
        correo.To.Add(toAddress)
        correo.Subject = subject
        correo.Body = body
        correo.IsBodyHtml = False
        correo.Priority = System.Net.Mail.MailPriority.Normal
        If adjunto Then 'SI LLEVA DOCUMENTO ADJUNTO
            'Dim archivo As String
            'Dim filename As String
            'archivo = RTrim(LTrim(lote)) & ".pdf"
            'filename = HttpRuntime.AppDomainAppPath & "Adjunto/" & archivo
            correo.Attachments.Add(New System.Net.Mail.Attachment(filename))
        End If
        Dim smtp As New System.Net.Mail.SmtpClient
        smtp.Port = 587
        smtp.Host = "Mail.gmail.com"
        smtp.Credentials = New System.Net.NetworkCredential(My.Settings.UserCredenciales, My.Settings.PwdCredenciales) 'CAMBIAR POR NOREPLY
        Try
            smtp.Send(correo)
            mensaje = "Mensaje enviado satisfactoriamente"
            Envio = True
        Catch ex As Exception
            mensaje = "ERROR: " & ex.Message
            Envio = False
        End Try
        Return Envio
    End Function
    Public Function EnvioCorreoAutomatico(ByVal Para As String, ByVal De As String, ByVal Asunto As String) As Integer
        Dim Resultado As Integer
        Try
            Dim htmlBody As String = "<html><body><br><img src=""cid:Pic1""></body></html>"
            Dim avHtml As AlternateView = AlternateView.CreateAlternateViewFromString _
            (htmlBody, Nothing, System.Net.Mime.MediaTypeNames.Text.Html)
            Dim pic1 As LinkedResource = New LinkedResource(System.IO.Directory.GetCurrentDirectory + "\ImagenesCorreo\Tarjeta_Cumpleaños.jpg", System.Net.Mime.MediaTypeNames.Image.Jpeg)
            pic1.ContentId = "Pic1"
            avHtml.LinkedResources.Add(pic1)
            Dim textBody As String = "Debe utilizar un cliente de correo electrónico que soporta mensajes HTML"
            Dim avText As AlternateView = AlternateView.CreateAlternateViewFromString _
            (textBody, Nothing, System.Net.Mime.MediaTypeNames.Text.Plain)
            Dim m As MailMessage = New MailMessage
            m.AlternateViews.Add(avHtml)
            m.AlternateViews.Add(avText)
            m.From = New MailAddress(De)
            m.To.Add(Para)
            m.Subject = Asunto
            Dim client As SmtpClient = New SmtpClient("mail.gmail.com")
            client.Credentials = New Net.NetworkCredential(My.Settings.UserCredenciales, My.Settings.PwdCredenciales)
            client.Send(m)
            Resultado = 1
        Catch ex As Exception
            Resultado = 0
        End Try
        Return Resultado
    End Function
    Public Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean
        'Dim exApp As New Microsoft.Office.Interop.Excel.Application
        'Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        'Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        'Try
        '    'Añadimos el Libro al programa, y la hoja al libro
        '    exLibro = exApp.Workbooks.Add
        '    exHoja = exLibro.Worksheets.Add()
        '    ' ¿Cuantas columnas y cuantas filas?
        '    Dim NCol As Integer = ElGrid.ColumnCount
        '    Dim NRow As Integer = ElGrid.RowCount
        '    'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
        '    For i As Integer = 1 To NCol
        '        exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
        '        'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
        '    Next
        '    For Fila As Integer = 0 To NRow - 1
        '        For Col As Integer = 0 To NCol - 1
        '            exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
        '        Next
        '    Next
        '    'Titulo en negrita, Alineado al centro y que el tamaño de la columna seajuste al texto
        '    exHoja.Rows.Item(1).Font.Bold = 1
        '    exHoja.Rows.Item(1).HorizontalAlignment = 3
        '    exHoja.Columns.AutoFit()
        '    'Aplicación visible
        '    exApp.Application.Visible = True
        '    exHoja = Nothing
        '    exLibro = Nothing
        '    exApp = Nothing
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        '    Return False
        'End Try
        Return True
    End Function
    Public Function ImportarExcel_Datagrid()

    End Function
    Public Function ImportarExcel_Datagrid(ByVal Ruta As String) As DataSet
        Dim ConecExcel As System.Data.OleDb.OleDbConnection
        Dim Dts As New DataSet
        Dim ObjAdapter As System.Data.OleDb.OleDbDataAdapter
        ConecExcel = New System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & Ruta & "';Extended Properties='Excel 12.0 Xml;HDR=YES';")
        ObjAdapter = New System.Data.OleDb.OleDbDataAdapter("select * from [Planilla$]", ConecExcel)
        ObjAdapter.TableMappings.Add("Tabla", "PagoPlanilla")
        ObjAdapter.Fill(Dts, "Planilla")
        ConecExcel.Close()
        If ConecExcel.State <> ConnectionState.Closed Then
            ConecExcel.Dispose()
        End If
        Return Dts
    End Function
    Public Function ImportarExcel_Datagrid_Ahorros(ByVal Ruta As String, ByVal hoja As String) As DataSet
        Try
            Dim ConecExcel As System.Data.OleDb.OleDbConnection
            Dim Dts As New DataSet
            Dim ObjAdapter As System.Data.OleDb.OleDbDataAdapter
            ConecExcel = New System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & Ruta & "';Extended Properties='Excel 12.0 Xml;HDR=YES';")
            ObjAdapter = New System.Data.OleDb.OleDbDataAdapter("select * from [" & hoja & "$]", ConecExcel)
            ObjAdapter.TableMappings.Add("Tabla", "PagoPlanilla")
            ObjAdapter.Fill(Dts, "Planilla")
            ConecExcel.Close()
            If ConecExcel.State <> ConnectionState.Closed Then
                ConecExcel.Dispose()
            End If
            Return Dts
        Catch ex As Exception
            MsgBox("Por favor verifique que el nombre de la hoja sea valido", MsgBoxStyle.Critical, "Módulo - Ahorros")
        End Try
    End Function
End Module
