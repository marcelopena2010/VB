Public Class formCadConvenios

    Private Sub formCadConvenios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Controle_ClinicaDataSet.Cadastro_de_Convenios' table. You can move, or remove it, as needed.
        Me.Cadastro_de_ConveniosTableAdapter.Fill(Me.Controle_ClinicaDataSet.Cadastro_de_Convenios)

    End Sub

    Private Sub formCadConvenios_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Validate()
        Me.Cadastro_de_ConveniosBindingSource.EndEdit()
        Me.Cadastro_de_ConveniosTableAdapter.Update(Me.Controle_ClinicaDataSet.Cadastro_de_Convenios)
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()

    End Sub
End Class