Public Class frmModulo
    Dim aplicaciones As New wrAdmin.wsLibAdmin


    Private Sub frmModulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles activoFijo.Click
        Index.Modulo = "O"
        Index.encabezado = "ACTIVO FIJO"
        Index.llenarMenu()
        Me.Close()

    End Sub

    Private Sub MetroTile5_Click(sender As Object, e As EventArgs) Handles asociados.Click
        Index.Modulo = "C"
        Index.encabezado = "ASOCIADOS"
        Index.llenarMenu()
        Me.Close()

    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles administracion.Click

        Index.Modulo = "B"
        Index.encabezado = "ADMINISTRACIÓN"
        Index.llenarMenu()
        Me.Close()

    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles ahorros.Click
        Index.Modulo = "E"
        Index.encabezado = "CUENTAS DE AHORRO"
        Index.llenarMenu()
        Me.Close()

    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles aportaciones.Click
        Index.Modulo = "D"
        Index.encabezado = "APORTACIONES"
        Index.llenarMenu()
        Me.Close()

    End Sub

    Private Sub caja_Click(sender As Object, e As EventArgs) Handles caja.Click
        Index.Modulo = "H"
        Index.encabezado = "FACTURACIÓN"
        Index.llenarMenu()
        Me.Close()

    End Sub

    Private Sub cobranza_Click(sender As Object, e As EventArgs) Handles cobranza.Click

        Index.Modulo = "G"
        Index.encabezado = "COBROS"
        Index.llenarMenu()
        Me.Close()

    End Sub

    Private Sub contabilidad_Click(sender As Object, e As EventArgs) Handles contabilidad.Click

        Index.Modulo = "J"
        Index.encabezado = "CONTABILIDAD"
        Index.llenarMenu()
        Me.Close()

    End Sub

    Private Sub garantias_Click(sender As Object, e As EventArgs) Handles garantias.Click

        Index.Modulo = "M"
        Index.encabezado = "GARANTÍAS"
        Index.llenarMenu()
        Me.Close()

    End Sub

    Private Sub planilas_Click(sender As Object, e As EventArgs) Handles planilas.Click


        Index.Modulo = "K"
        Index.encabezado = "PLANILLAS"
        Index.llenarMenu()
        Me.Close()
    End Sub

    Private Sub prestamos_Click(sender As Object, e As EventArgs) Handles prestamos.Click

        Index.Modulo = "F"
        Index.encabezado = "PRÉSTAMOS"
        Index.llenarMenu()
        Me.Close()
    End Sub

    Private Sub configuracion_Click(sender As Object, e As EventArgs) Handles configuracion.Click

        Index.Modulo = "L"
        Index.encabezado = "CATALOGOS"
        Index.llenarMenu()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim frm As New Index
        With frm
            .Show()
        End With
    End Sub
End Class