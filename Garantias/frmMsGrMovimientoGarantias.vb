Public Class frmMsGrMovimientoGarantias
    Dim PLANILLAS As New wrPlanilla.wsLibPlanilla
    Dim Credito As New wrCredito.wsLibCred
    Public vNUMSOLICITUD As Integer
    Public vNOCOMPROBANTE As String
    Public vACCION As Integer '1 = INSERTAR; 2 = MODIFICAR; 3 = CONSULTAR.
    Dim PENDIENTE As Boolean
    Dim CODPRESTAMODOCUMENTO As String
    Dim CORRELATIVO As Integer
    Private Sub frmMsGrMovimientoGarantias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cbDEPRECIBE.DataSource = LLENAR_DEPARTAMENTOS.Tables(0)
        Me.cbDEPTOENTREGA.DataSource = LLENAR_DEPARTAMENTOS.Tables(0)
        LLENAR_TIPOSDOC()
        DatosGeneralesCredito(vNUMSOLICITUD)
        DatosGarantia(vNOCOMPROBANTE)
        VALIDAR_ACCION()
        DOCUMENTOSPENDIENTES(vNOCOMPROBANTE)
        If vACCION = 1 And PENDIENTE = False Then
            Me.rbPRESTAMO.Checked = True
            Me.Height = 536
            'Me.MaximumSize = New Size(693, 536)
            Me.SplitContainer1.Panel1Collapsed = True
            Me.lblENCCODPRES.Visible = False
            Me.llINF.Visible = False
            Me.lblCODPRESGARANTIA.Visible = False
        ElseIf vACCION = 2 Then
            Me.gbCONSULTAR.Height = 450
            Me.Width = 950
            Me.SplitContainer1.Panel1Collapsed = False
            Me.SplitContainer1.Panel2Collapsed = True
            CONSULTAR_MOVIMIENTOS(vNOCOMPROBANTE, 1, Now, Now) 'coloco now xq no stoy filtrando por un perido especifico 
            HEADERDG()
            Me.btnGUARDAR1.Text = "Modificar"
        ElseIf vACCION = 3 Then
            Me.cbMOSTRARTODOS.Checked = True
            Me.gbCONSULTAR.Height = 450
            Me.Width = 950
            'Me.Height = 536
            'Me.Width = 800
            'Me.gbCONSULTAR.Height = 350
            'Me.DataGridView1.Height = 325
            'Me.MaximumSize = New Size(800, 536)
            Me.SplitContainer1.Panel1Collapsed = False
            Me.SplitContainer1.Panel2Collapsed = True
            Me.lblENCCODPRES.Visible = False
            Me.llINF.Visible = False
            Me.lblCODPRESGARANTIA.Visible = False
            CONSULTAR_MOVIMIENTOS(vNOCOMPROBANTE, 1, Now, Now) 'coloco now xq no stoy filtrando por un perido especifico 
        End If
    End Sub
    Protected Function LLENAR_DEPARTAMENTOS() As DataSet
        Dim DTS As New DataSet
        DTS = PLANILLAS.CONSULTAR_PLDEPARTAMENTOS(sUsuario, sPassword, sSucursal, 0, "", "", "")
        Return DTS
    End Function
    Protected Function LLENAR_EMPLEADOS(ByVal CODDEPARTAMENTO As Integer) As DataSet
        Dim DTS As New DataSet
        DTS = PLANILLAS.CONSULTAR_PLEMPLEADOS(sUsuario, sPassword, sSucursal, CODDEPARTAMENTO, 2)
        Return DTS
    End Function
    Private Sub cbDEPRECIBE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDEPRECIBE.SelectedIndexChanged
        Dim DTS As New DataSet
        DTS = LLENAR_EMPLEADOS(Me.cbDEPRECIBE.SelectedValue)
        Me.cbRESPONSABLERECIBE.DataSource = DTS.Tables(0)
    End Sub
    Private Sub cbDEPTOENTREGA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbDEPTOENTREGA.SelectedIndexChanged
        Dim DTS As New DataSet
        DTS = LLENAR_EMPLEADOS(Me.cbDEPTOENTREGA.SelectedValue)
        Me.cbRESPONSABLEENTREGA.DataSource = DTS.Tables(0)
    End Sub
    Protected Sub DatosGeneralesCredito(ByVal NUMSOLICITUD As Integer)
        Dim DTS As New DataSet
        DTS = Credito.CONSULTAR_DATOSGENERALESASOCIADOS(sUsuario, sPassword, sSucursal, NUMSOLICITUD)
        If DTS.Tables(0).Rows.Count > 0 Then
            Me.lblConcedido.Text = Me.lblConcedido.Text + " " + DTS.Tables(0).Rows(0).Item("ASOCIADO").ToString.Trim
            Me.lblPlazo.Text = Me.lblPlazo.Text + " " + DTS.Tables(0).Rows(0).Item("PLAZO").ToString.Trim
            Me.lblTasaInt.Text = Me.lblTasaInt.Text + " " + DTS.Tables(0).Rows(0).Item("TASA_INTERES").ToString.Trim
            Me.lblESTADO.Text = Me.lblESTADO.Text + " " + DTS.Tables(0).Rows(0).Item("ESTADO").ToString.Trim
            Me.lblMonto.Text = Me.lblMonto.Text + " " + DTS.Tables(0).Rows(0).Item("MONTO").ToString.Trim
            Me.lblFechaVenc.Text = Me.lblFechaVenc.Text + " " + DTS.Tables(0).Rows(0).Item("FECHAVENCIMIENTO").ToString.Trim
            Me.lblFechaOtorg.Text = Me.lblFechaOtorg.Text + " " + DTS.Tables(0).Rows(0).Item("FECHAOTORGAMIENTO").ToString.Trim
        End If
    End Sub
    Protected Sub DatosGarantia(ByVal NOCOMPROBANTE As String)
        Dim DTS As New DataSet
        DTS = Credito.CONSULTARINSCRIPCIONGARANTIA(sUsuario, sPassword, sSucursal, 0, 5, NOCOMPROBANTE, " ", " ")
        Me.lblNOCOMPROBANTE.Text = Me.lblNOCOMPROBANTE.Text + " " + DTS.Tables(0).Rows(0).Item("NOCOMPROBANTE")
        Me.lblNOMATRICULA.Text = Me.lblNOMATRICULA.Text + " " + DTS.Tables(0).Rows(0).Item("NOMATRICULA")
    End Sub
    Private Sub btnGUARDAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Protected Sub CONSULTAR_MOVIMIENTOS(ByVal NOCOMPROBANTE As String, ByVal OPCION As Integer, ByVal FECHAI As Date, ByVal FECHAF As Date)
        Dim DTS As New DataSet
        DTS = Credito.CONSULTAR_GRMOVIMIENTOSDOCGARANTIAS(sUsuario, sPassword, sSucursal, NOCOMPROBANTE, OPCION, FECHAI, FECHAF)
        Me.DataGridView1.DataSource = DTS.Tables(0)
    End Sub
    Protected Sub HEADERDG()
        Me.DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        Me.DataGridView1.Columns("CODEMPLEADO_RECIBE").Visible = False
        Me.DataGridView1.Columns("CODEMPLEADO_ENTREGA").Visible = False
        Me.DataGridView1.Columns("CODDEPARTAMENTO_RECIBE").Visible = False
        Me.DataGridView1.Columns("CODDEPARTAMENTO_ENTREGA").Visible = False
        Me.DataGridView1.Columns("ACCION").Visible = False
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Teal
        Me.DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub
    Protected Sub VALIDAR_ACCION()
        If Me.rbPRESTAMO.Checked = False And Me.rbDEVOLUCION.Checked = False Then
            Me.cbDEPRECIBE.Enabled = False
            Me.cbDEPTOENTREGA.Enabled = False
            Me.cbRESPONSABLEENTREGA.Enabled = False
            Me.cbRESPONSABLERECIBE.Enabled = False
            Me.cbTipoDocEnt.Enabled = False
            Me.txtObsDE.ReadOnly = True
            Me.dtpFecEntDC.Enabled = False
        ElseIf Me.rbPRESTAMO.Checked = True Or Me.rbDEVOLUCION.Checked = True Then
            Me.cbDEPRECIBE.Enabled = True
            Me.cbDEPTOENTREGA.Enabled = True
            Me.cbRESPONSABLEENTREGA.Enabled = True
            Me.cbRESPONSABLERECIBE.Enabled = True
            Me.cbTipoDocEnt.Enabled = True
            Me.txtObsDE.ReadOnly = False
            Me.dtpFecEntDC.Enabled = True
        End If
    End Sub
    Private Sub rbPRESTAMO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPRESTAMO.CheckedChanged
        VALIDAR_ACCION()
    End Sub
    Private Sub rbDEVOLUCION_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDEVOLUCION.CheckedChanged
        VALIDAR_ACCION()
    End Sub
    Protected Sub DOCUMENTOSPENDIENTES(ByVal NOCOMPROBANTE As String)
        Dim DTS As New DataSet
        DTS = Credito.CONSULTAR_GRMOVIMIENTOSDOCGARANTIAS(sUsuario, sPassword, sSucursal, NOCOMPROBANTE, 3, dtpFECHA_FIN.Value, dtpFECHA_FIN.Value)
        If DTS.Tables(0).Rows.Count > 0 And vACCION = 1 Then ' TIENE DOCUMENTOS PENDIENTES
            Me.DataGridView1.DataSource = DTS.Tables(0)
            Dim CODPRES As String = DTS.Tables(0).Rows(0).Item("CODPRES").ToString
            CODPRESTAMODOCUMENTO = CODPRES
            HEADERDG()
            Me.gbCONSULTAR.Height = 200
            Me.Width = 950
            Me.Height = 400
            Me.SplitContainer1.Panel1Collapsed = False
            Me.SplitContainer1.Panel2Collapsed = True
            'Me.MaximumSize = New Size(1024, 650)
            Me.dtpFECHA_FIN.Enabled = False
            Me.dtpFECHAINI.Enabled = False
            Me.btAtras1.Enabled = False
            Me.cbMOSTRARTODOS.Enabled = False
            Me.gbCONSULTAR.Text = "Doc. Pendientes de entrega"
            PENDIENTE = True
        End If
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If PENDIENTE = True And vACCION = 1 Then
            Dim CODPRES As String = Me.DataGridView1.CurrentRow.Cells("CODPRES").Value
            Me.SplitContainer1.Panel1Collapsed = True
            Me.SplitContainer1.Panel2Collapsed = False
            Me.lblCODPRESGARANTIA.Text = CODPRES
            Me.rbDEVOLUCION.Checked = True
            Me.Height = 516
            Me.Width = 687
            Me.MaximumSize = New Size(687, 526)
        ElseIf vACCION = 2 Then
            Dim ACCION As Integer
            '================================================================
            '================================================================
            ACCION = Me.DataGridView1.CurrentRow.Cells("ACCION").Value
            If ACCION = 0 Then
                Me.rbPRESTAMO.Checked = True
            Else
                Me.rbDEVOLUCION.Checked = True
            End If
            VALIDAR_ACCION()
            Me.rbDEVOLUCION.Enabled = False
            Me.rbPRESTAMO.Enabled = False
            '================================================================
            '================================================================
            'Me.ddlCOIU_PERS.SelectedValue = Me.ddlCOIU_PERS.Items.FindByText(RESPONSABLE).Value
            Me.cbDEPRECIBE.SelectedValue = Me.DataGridView1.CurrentRow.Cells("CODDEPARTAMENTO_RECIBE").Value
            Me.cbRESPONSABLERECIBE.SelectedValue = Me.DataGridView1.CurrentRow.Cells("CODEMPLEADO_RECIBE").Value
            Me.cbTipoDocEnt.SelectedValue = Me.DataGridView1.CurrentRow.Cells("ID_TIPODOC").Value
            Me.cbRESPONSABLEENTREGA.SelectedValue = Me.DataGridView1.CurrentRow.Cells("CODEMPLEADO_ENTREGA").Value
            Me.cbDEPTOENTREGA.SelectedValue = Me.DataGridView1.CurrentRow.Cells("CODDEPARTAMENTO_ENTREGA").Value
            Me.txtObsDE.Text = Me.DataGridView1.CurrentRow.Cells("Observaciones").Value
            Me.dtpFecEntDC.Value = Me.DataGridView1.CurrentRow.Cells("Fecha Entrega").Value
            Me.CORRELATIVO = Me.DataGridView1.CurrentRow.Cells("CORRELATIVO").Value
            Me.llINF.Visible = False
            Me.lblCODPRESGARANTIA.Visible = False
            Me.lblENCCODPRES.Visible = False
            Me.cbDEPTOENTREGA.SelectedText = Me.DataGridView1.CurrentRow.Cells("Departamento Entrega").Value
            Me.SplitContainer1.Panel1Collapsed = True
            Me.llINF.Text = "Ver Información del documento prestado"
            Me.MaximumSize = New Size(687, 526)
            Me.Height = 516
            Me.Width = 687
        End If
    End Sub
    Protected Sub LLENAR_TIPOSDOC()
        Dim DTS As New DataSet
        DTS = Credito.CONSULTAR_GRTIPODOCUMENTOS(sUsuario, sPassword, sSucursal)
        Me.cbTipoDocEnt.DataSource = DTS.Tables(0)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
    Private Sub cbMOSTRARTODOS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMOSTRARTODOS.CheckedChanged
        If Me.cbMOSTRARTODOS.Checked = True Then
            Me.dtpFECHA_FIN.Enabled = False
            Me.dtpFECHAINI.Enabled = False
            Me.btAtras1.Enabled = False
            CONSULTAR_MOVIMIENTOS(vNOCOMPROBANTE, 1, Now, Now) 'coloco now xq no stoy filtrando por un perido especifico 
            HEADERDG()
        ElseIf Me.cbMOSTRARTODOS.Checked = False Then
            Me.dtpFECHA_FIN.Enabled = True
            Me.dtpFECHAINI.Enabled = True
            Me.btAtras1.Enabled = True
        End If
    End Sub
    Private Sub llINF_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llINF.LinkClicked
        If Me.llINF.Text = "Ver Información del documento prestado" Then
            Me.MaximumSize = New Size(1024, 700)
            Me.SplitContainer1.Panel1Collapsed = False
            Me.DataGridView1.Height = 125
            Me.gbCONSULTAR.Height = 150
            Me.GroupBox2.Height = 314
            Me.Size = New Size(687, 640)
            Me.DataGridView1.ReadOnly = True
            'Me.Width = 950
            'Me.Height = 700
            Me.llINF.Text = "Ocultar información del documento prestado"
        ElseIf Me.llINF.Text = "Ocultar información del documento prestado" Then
            Me.SplitContainer1.Panel1Collapsed = True
            Me.llINF.Text = "Ver Información del documento prestado"
            Me.MaximumSize = New Size(687, 526)
            Me.Height = 516
            Me.Width = 687
        End If
    End Sub

    Private Sub dtpFecEntDC_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecEntDC.ValueChanged

    End Sub

    Private Sub btAtras1_Click(sender As Object, e As EventArgs) Handles btAtras1.Click
        Try
            If Me.cbMOSTRARTODOS.Checked = True Then
                CONSULTAR_MOVIMIENTOS(vNOCOMPROBANTE, 1, Now, Now) 'coloco now xq no stoy filtrando por un perido especifico 
                HEADERDG()
            ElseIf Me.cbMOSTRARTODOS.Checked = False Then
                CONSULTAR_MOVIMIENTOS(vNOCOMPROBANTE, 2, Format(Me.dtpFECHAINI.Value, "SHORT DATE"), Format(Me.dtpFECHA_FIN.Value, "SHORT DATE"))
                HEADERDG()
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGUARDAR1_Click(sender As Object, e As EventArgs) Handles btnGUARDAR1.Click
        Try
            Dim RESULTADO As Integer
            Dim ACCION As Integer
            Dim REINTEGRO As Boolean
            If Me.rbPRESTAMO.Checked = True Then
                ACCION = 0
                REINTEGRO = False
            ElseIf Me.rbDEVOLUCION.Checked = True Then
                ACCION = 1
                REINTEGRO = True
            End If
            If vACCION = 1 Then
                If PENDIENTE = False Then
                    RESULTADO = Credito.INSERTAR_GRMOVIMIENTOSDOCGARANTIAS(sUsuario, sPassword, sSucursal, vNOCOMPROBANTE, Me.cbRESPONSABLERECIBE.SelectedValue,
                                                                       Me.cbDEPRECIBE.SelectedValue, Format(Me.dtpFecEntDC.Value, "SHORT DATE"),
                                                                       Me.cbRESPONSABLEENTREGA.SelectedValue, Me.cbDEPTOENTREGA.SelectedValue, txtObsDE.Text.Trim, Now,
                                                                       ACCION, REINTEGRO, Me.cbTipoDocEnt.SelectedValue, 1, " ")
                ElseIf PENDIENTE = True Then
                    RESULTADO = Credito.INSERTAR_GRMOVIMIENTOSDOCGARANTIAS(sUsuario, sPassword, sSucursal, vNOCOMPROBANTE, Me.cbRESPONSABLERECIBE.SelectedValue,
                                                                       Me.cbDEPRECIBE.SelectedValue, Format(Me.dtpFecEntDC.Value, "SHORT DATE"),
                                                                       Me.cbRESPONSABLEENTREGA.SelectedValue, Me.cbDEPTOENTREGA.SelectedValue, txtObsDE.Text.Trim, Now,
                                                                       ACCION, REINTEGRO, Me.cbTipoDocEnt.SelectedValue, 2, Me.lblCODPRESGARANTIA.Text)
                    Credito.MODIFICAR_GRMOVIMIENTOSDOCGARANTIASENTREGA(sUsuario, sPassword, sSucursal, vNOCOMPROBANTE, CODPRESTAMODOCUMENTO, True, Now)
                End If
            ElseIf vACCION = 2 Then
                RESULTADO = Credito.MODIFICAR_GRMOVIMIENTOSDOCGARANTIAS(sUsuario, sPassword, sSucursal, vNOCOMPROBANTE, Me.cbRESPONSABLERECIBE.SelectedValue,
                                                                        Me.cbDEPRECIBE.SelectedValue, Format(dtpFecEntDC.Value, "SHORT DATE"), Me.cbRESPONSABLEENTREGA.SelectedValue,
                                                                        Me.cbDEPTOENTREGA.SelectedValue, Me.txtObsDE.Text.Trim, Now, CORRELATIVO)
            End If
            If RESULTADO <> 0 Then
                MsgBox("Movimiento ingresado correctamente", MsgBoxStyle.Information, "Módulo - Garantías")
                Me.SplitContainer1.Panel1Collapsed = False
                CONSULTAR_MOVIMIENTOS(vNOCOMPROBANTE, 1, dtpFECHAINI.Value, dtpFECHA_FIN.Value)
                HEADERDG()
                Me.Width = 950
                Me.gbCONSULTAR.Height = 450
                Me.MaximumSize = New Size(1024, 700)
                Me.SplitContainer1.Panel2Collapsed = True
                Me.dtpFECHAINI.Enabled = True
                Me.dtpFECHA_FIN.Enabled = True
                Me.btAtras1.Enabled = True
                Me.cbMOSTRARTODOS.Enabled = True
            Else
                MsgBox("Error al momento de ingresar el movimiento", MsgBoxStyle.Critical, "Módulo - Garantías")
            End If
        Catch ex As Exception
             MetroFramework.MetroMessageBox.Show(Me, mensajeError, Me.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub
End Class