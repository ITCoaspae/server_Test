Public Class frmModulo
    Dim aplicaciones As New wrAdmin.wsLibAdmin


    Private Sub frmModulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MetroTile1_Click(sender As Object, e As EventArgs) Handles activoFijo.Click
        aplicaciones.CargarApp(wrAdmin.Modulos.ActivoFijo, sUsuario, sPassword, sSucursal)
        ofrmMain.Menu = ofrmMain.mnuActivoFijo
        ofrmMain.Text = "SIF" & "-[ACTIVO FIJO]"
        Dim principal As New Index
        With principal
            .Modulo = "O"
            '.Show()
        End With
        Me.Close()
    End Sub

    Private Sub MetroTile5_Click(sender As Object, e As EventArgs) Handles asociados.Click
        aplicaciones.CargarApp(wrAdmin.Modulos.Asociados, sUsuario, sPassword, sSucursal)
        ofrmMain.Menu = ofrmMain.mnuAsociados
        ofrmMain.Text = "SIF" & "-[ASOCIADOS] "
        Dim principal As New Index
        With principal
            .Modulo = "C"
            '.Show()
        End With
        Me.Close()
    End Sub

    Private Sub MetroTile2_Click(sender As Object, e As EventArgs) Handles administracion.Click
        aplicaciones.CargarApp(wrAdmin.Modulos.Administrativo, sUsuario, sPassword, sSucursal)
        ofrmMain.Menu = ofrmMain.mnuAdministracion
        ofrmMain.Text = "SIF" & "-[ADMINISTRACIÓN] "

        Dim principal As New Index
        With principal
            .Modulo = "B"
            '.Show()
        End With

        Me.Close()
    End Sub

    Private Sub MetroTile3_Click(sender As Object, e As EventArgs) Handles ahorros.Click
        aplicaciones.CargarApp(wrAdmin.Modulos.Ahorros, sUsuario, sPassword, sSucursal)
        ofrmMain.Text = "SIF" & "-[AHORROS] "
        ofrmMain.Menu = ofrmMain.mnuAhorros
        Dim principal As New Index
        With principal
            .Modulo = "E"
            '.Show()
        End With
        Me.Close()
    End Sub

    Private Sub MetroTile4_Click(sender As Object, e As EventArgs) Handles aportaciones.Click
        aplicaciones.CargarApp(wrAdmin.Modulos.Aportaciones, sUsuario, sPassword, sSucursal)
        ofrmMain.Menu = ofrmMain.mnuAportaciones
        ofrmMain.Text = "SIF" & "-[APORTACIONES] "
        Dim principal As New Index
        With principal
            .Modulo = "D"
            '.Show()
        End With
        Me.Close()
    End Sub

    Private Sub caja_Click(sender As Object, e As EventArgs) Handles caja.Click
        aplicaciones.CargarApp(wrAdmin.Modulos.Caja, sUsuario, sPassword, sSucursal)
        ofrmMain.Menu = ofrmMain.mnuCaja
        ofrmMain.Text = "SIF" & "-[CAJA] "
        Dim principal As New Index
        With principal
            .Modulo = "H"
            '.Show()
        End With
        Me.Close()
    End Sub

    Private Sub cobranza_Click(sender As Object, e As EventArgs) Handles cobranza.Click
        aplicaciones.CargarApp(wrAdmin.Modulos.Cobranza, sUsuario, sPassword, sSucursal)
        ofrmMain.Menu = ofrmMain.mnuCobranza
        ofrmMain.Text = "SIF" & "-[COBRANZA] "
        Dim principal As New Index
        With principal
            .Modulo = "G"
            '.Show()
        End With
        Me.Close()
    End Sub

    Private Sub contabilidad_Click(sender As Object, e As EventArgs) Handles contabilidad.Click
        aplicaciones.CargarApp(wrAdmin.Modulos.Contabilidad, sUsuario, sPassword, sSucursal)
        ofrmMain.Menu = ofrmMain.mnuContabilidad
        ofrmMain.Text = "SIF" & "-[CONTABILIDAD] "
        Dim principal As New Index
        With principal
            .Modulo = "J"
            '.Show()
        End With
        Me.Close()
    End Sub

    Private Sub garantias_Click(sender As Object, e As EventArgs) Handles garantias.Click
        aplicaciones.CargarApp(wrAdmin.Modulos.Garantias, sUsuario, sPassword, sSucursal)
        ofrmMain.Menu = ofrmMain.mnuGarantias
        ofrmMain.Text = "SIF" & "-[GARANTÍAS] "
        Dim principal As New Index
        With principal
            .Modulo = "M"
            '.Show()
        End With
        Me.Close()
    End Sub

    Private Sub planilas_Click(sender As Object, e As EventArgs) Handles planilas.Click
        aplicaciones.CargarApp(wrAdmin.Modulos.Planillas, sUsuario, sPassword, sSucursal)
        ofrmMain.Menu = ofrmMain.mnuPlanilla
        ofrmMain.Text = "SIF" & "-[PLANILLAS] "
        Dim principal As New Index
        With principal
            .Modulo = "K"
            '.Show()
        End With
        Me.Close()
    End Sub

    Private Sub prestamos_Click(sender As Object, e As EventArgs) Handles prestamos.Click
        aplicaciones.CargarApp(wrAdmin.Modulos.Creditos, sUsuario, sPassword, sSucursal)
        ofrmMain.Menu = ofrmMain.mnuCreditos
        ofrmMain.Text = "SIF" & "-[PRÉSTAMOS] "
        Dim principal As New Index
        With principal
            .Modulo = "F"
            '.Show()
        End With
        Me.Close()
    End Sub

    Private Sub configuracion_Click(sender As Object, e As EventArgs) Handles configuracion.Click
        aplicaciones.CargarApp(wrAdmin.Modulos.Creditos, sUsuario, sPassword, sSucursal)
        ofrmMain.Menu = ofrmMain.mnuGeneral
        ofrmMain.Text = "SIF" & "-[CATALOGOS] "
        Dim principal As New Index
        With principal
            .Modulo = "L"
            '.Show()
        End With
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim frm As New Index
        With frm
            '.Show()
        End With
    End Sub
End Class