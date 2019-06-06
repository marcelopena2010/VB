Public Class formVerConsultas

    Private Sub formVerConsultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Calendario.TodayDate = Now
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()

    End Sub

    Private Sub btnVisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizar.Click
        Dim dia, mes, ano, data As String
        dia = Calendario.SelectionStart.Day
        mes = Calendario.SelectionStart.Month
        ano = Calendario.SelectionStart.Year
        data = dia + "/" + mes + "/" + ano

        Me.DataTable1BindingSource.Filter = "DataConsulta = '" + data + "'"
        Me.DataTable1TableAdapter.Fill(Me.Controle_ClinicaDataSet.DataTable1)
    End Sub
End Class