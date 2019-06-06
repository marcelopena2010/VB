Public Class formMarcaConsulta

    Private Sub formMarcaConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Controle_ClinicaDataSet.Cadastro_de_Convenios' table. You can move, or remove it, as needed.
        Me.Cadastro_de_ConveniosTableAdapter.Fill(Me.Controle_ClinicaDataSet.Cadastro_de_Convenios)
        'TODO: This line of code loads data into the 'Controle_ClinicaDataSet.Cadastro_de_Pacientes' table. You can move, or remove it, as needed.
        Me.Cadastro_de_PacientesTableAdapter.Fill(Me.Controle_ClinicaDataSet.Cadastro_de_Pacientes)
        Me.CadastroDeConveniosBindingSource.Sort = "NomeConvenio"
        'TODO: This line of code loads data into the 'Controle_ClinicaDataSet.Cadastro_de_Pacientes' table. You can move, or remove it, as needed.
        Me.Cadastro_de_PacientesTableAdapter.Fill(Me.Controle_ClinicaDataSet.Cadastro_de_Pacientes)
        Me.CadastroDePacientesBindingSource.Sort = "NomePaciente"
    End Sub

    Private Sub btnMarcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcar.Click
        Dim dia, mes, ano, hora, minuto As Integer
        Dim icodigopaciente, icodigoconvenio As Integer
        Dim shora, sminuto As String

        shora = Microsoft.VisualBasic.Left(mskHorario.Text, 2)
        sminuto = Microsoft.VisualBasic.Right(mskHorario.Text, 2)

        If (Trim(shora) = "") Or (Trim(sminuto) = "") Then
            MsgBox("E necessario informar o horario !")
        Else
            dia = MonthCalendar1.SelectionStart.Day
            mes = MonthCalendar1.SelectionStart.Month
            ano = MonthCalendar1.SelectionStart.Year

            hora = CInt(shora)
            minuto = CInt(sminuto)

            Dim dtDataHoraConsulta As New System.DateTime(ano, mes, dia, hora, minuto, 0)
            Dim dtDataConsulta As New System.DateTime(ano, mes, dia)

            icodigopaciente = DataGridPaciente.CurrentRow.Cells(0).Value

            icodigoconvenio = DataGridConvenio.CurrentRow.Cells(0).Value

            Me.Agenda_de_ConsultasTableAdapter1.Insert(dtDataHoraConsulta, dtDataConsulta, icodigopaciente, "N", icodigoconvenio)

            MsgBox("Consulta agendada !")
            Me.Close()


        End If
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()

    End Sub
End Class