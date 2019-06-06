Public Class formPrincipal

    Private Sub ToolTip1_Popup(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PopupEventArgs)

    End Sub

    Private Sub opcSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcSair.Click
        End
    End Sub

    Private Sub opcConvenios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcConvenios.Click
        formCadConvenios.ShowDialog()

    End Sub

    Private Sub formPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dia, mes, ano As String
        dia = Now.Day.ToString
        mes = Now.Month.ToString
        ano = Now.Year.ToString
        lblData.Text = "Data: " + dia + "/" + mes + "/" + ano

    End Sub

    Private Sub btnConvenio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvenio.Click
        formCadConvenios.ShowDialog()
    End Sub

    Private Sub opcPacientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcPacientes.Click
        formCadPacientes.ShowDialog()

    End Sub

    Private Sub btnPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaciente.Click
        formCadPacientes.ShowDialog()
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        End
    End Sub

    Private Sub opcVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcVerificar.Click
        formVerConsultas.ShowDialog()

    End Sub

    Private Sub btnVisualizarConsultas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVisualizarConsultas.Click
        formVerConsultas.ShowDialog()
    End Sub

    Private Sub opcMarcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcMarcar.Click
        formMarcaConsulta.ShowDialog()

    End Sub

    Private Sub btnMarcarConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarcarConsulta.Click
        formMarcaConsulta.ShowDialog()

    End Sub

    Private Sub opcCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcCancelar.Click
        formCancelaConsulta.ShowDialog()

    End Sub

    Private Sub opcRelFichaPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcRelFichaPaciente.Click
        formFichaPaciente.ShowDialog()

    End Sub
End Class
