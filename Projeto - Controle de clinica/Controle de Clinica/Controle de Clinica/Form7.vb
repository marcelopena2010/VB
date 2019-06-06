Public Class formFichaPaciente

    Private Sub formFichaPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Controle_ClinicaDataSet.Cadastro_de_Pacientes' table. You can move, or remove it, as needed.
        Me.Cadastro_de_PacientesTableAdapter.Fill(Me.Controle_ClinicaDataSet.Cadastro_de_Pacientes)

    End Sub

    Private Sub PrintDoc_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim dadospacientes As String
        Dim Impressao As Graphics = e.Graphics

        Impressao.DrawString("CLINICA DR. ALBERTO SERGIO FREDERICO", New System.Drawing.Font("Tines New Roman", 14, FontStyle.Bold), Brushes.Black, 50, 50)
        dadospacientes = "Nome do Paciente: " + DataGridPaciente.CurrentRow.Cells(0).Value.ToString + Chr(10) + Chr(10)
        dadospacientes = dadospacientes + "RG: " + DataGridPaciente.CurrentRow.Cells(2).Value.ToString + " / CPF:" + DataGridPaciente.CurrentRow.Cells(3).Value.ToString + Chr(10) + Chr(10)
        dadospacientes = dadospacientes + "Data Nascimento: " + DataGridPaciente.CurrentRow.Cells(4).Value + " Sexo: " + DataGridPaciente.CurrentRow.Cells(1).Value.ToString + Chr(10) + Chr(10)
        dadospacientes = dadospacientes + "Endereco: " + Trim(DataGridPaciente.CurrentRow.Cells(5).Value.ToString) + "," + DataGridPaciente.CurrentRow.Cells(6).Value.ToString + Chr(10) + Chr(10)
        dadospacientes = dadospacientes + "Complemento: " + DataGridPaciente.CurrentRow.Cells(7).Value.ToString + Chr(10) + Chr(10)
        dadospacientes = dadospacientes + "Bairro: " + DataGridPaciente.CurrentRow.Cells(8).Value.ToString + Chr(10) + Chr(10)
        dadospacientes = dadospacientes + "Cidade/Estado: " + DataGridPaciente.CurrentRow.Cells(9).Value.ToString + "/" + DataGridPaciente.CurrentRow.Cells(10).Value.ToString + Chr(10) + Chr(10)
        dadospacientes = dadospacientes + "Telefone/Celular: " + DataGridPaciente.CurrentRow.Cells(11).Value.ToString + "/" + DataGridPaciente.CurrentRow.Cells(12).Value.ToString + Chr(10) + Chr(10)

        Impressao.DrawString(dadospacientes, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, 50, 250)

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If PrintDlg.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDoc.DocumentName = "Ficha de Cadastro de Paciente"
            PrintDoc.Print()

        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()

    End Sub
End Class