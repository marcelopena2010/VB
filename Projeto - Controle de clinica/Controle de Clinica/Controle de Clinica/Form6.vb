Public Class formCancelaConsulta

    Private Sub formCancelaConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dia, mes, ano, data As String
        'TODO: This line of code loads data into the 'Controle_ClinicaDataSet1.AgendaConsultas_Excluir' table. You can move, or remove it, as needed.
        Me.AgendaConsultas_ExcluirTableAdapter.Fill(Me.Controle_ClinicaDataSet1.AgendaConsultas_Excluir)

        Calendario.TodayDate = Now
        dia = Calendario.SelectionStart.Day
        mes = Calendario.SelectionStart.Month
        ano = Calendario.SelectionStart.Year
        data = dia + "/" + mes + "/" + ano

        Me.DataTable1BindingSource.Filter = "DataConsulta = '" + data + "'"
        Me.DataTable1TableAdapter.Fill(Me.Controle_ClinicaDataSet1.DataTable1)

    End Sub

    Private Sub btnListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListar.Click
        Dim dia, mes, ano, data As String
        
        Calendario.TodayDate = Now
        dia = Calendario.SelectionStart.Day
        mes = Calendario.SelectionStart.Month
        ano = Calendario.SelectionStart.Year
        data = dia + "/" + mes + "/" + ano

        Me.DataTable1BindingSource.Filter = "DataConsulta = '" + data + "'"
        Me.DataTable1TableAdapter.Fill(Me.Controle_ClinicaDataSet1.DataTable1)

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Dim dtDataHoraConsulta As DateTime

        If MsgBox("Deseja realmente cancelar a consulta ?", MsgBoxStyle.YesNo, "Confirmacao") = MsgBoxResult.Yes Then
            dtDataHoraConsulta = DataGridView1.CurrentRow.Cells(0).Value

            Me.AgendaConsultas_ExcluirTableAdapter.Delete(dtDataHoraConsulta)
            MsgBox("Consulta cancelada !")
        End If
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()

    End Sub
End Class