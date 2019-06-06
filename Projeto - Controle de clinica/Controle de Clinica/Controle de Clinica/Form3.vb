Public Class formCadPacientes

    Private Sub Cadastro_de_PacientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Cadastro_de_PacientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Controle_ClinicaDataSet)

    End Sub


    Private Sub Cadastro_de_PacientesBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cadastro_de_PacientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Cadastro_de_PacientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Controle_ClinicaDataSet)

    End Sub

    Private Sub formCadPacientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Controle_ClinicaDataSet.Cadastro_de_Pacientes' table. You can move, or remove it, as needed.
        Me.Cadastro_de_PacientesTableAdapter.Fill(Me.Controle_ClinicaDataSet.Cadastro_de_Pacientes)

    End Sub

    Private Sub formCadPacientes_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Cadastro_de_PacientesBindingSource.EndEdit()
        Me.Cadastro_de_PacientesTableAdapter.Update(Me.Controle_ClinicaDataSet.Cadastro_de_Pacientes)
        MsgBox("Paciente '" + Trim(NomePacienteTextBox.Text) + "'cadastro com sucesso !")
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()

    End Sub
End Class