Partial Class dsContratoDepositoPlazo
    Partial Public Class SP_RPT_ContratoDepositoPlazoDataTable
        Private Sub SP_RPT_ContratoDepositoPlazoDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.montoLetrasColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

        Private Sub SP_RPT_ContratoDepositoPlazoDataTable_SP_RPT_ContratoDepositoPlazoRowChanging(sender As Object, e As SP_RPT_ContratoDepositoPlazoRowChangeEvent) Handles Me.SP_RPT_ContratoDepositoPlazoRowChanging

        End Sub

    End Class
End Class
