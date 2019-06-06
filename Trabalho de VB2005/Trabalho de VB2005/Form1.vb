Public Class Form1

    Private Sub opcSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcSair.Click, btnSair.Click
        If txtTexto.Modified Then
            If MsgBox("Texto modificado. Deseja grava-lo ?", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                dlgSalvar.ShowDialog()
                If dlgSalvar.FileName <> "" Then
                    My.Computer.FileSystem.WriteAllText(dlgSalvar.FileName, txtTexto.Text, False)
                End If
            End If
        End If
    End Sub

    Private Sub opcNovo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcNovo.Click, btnNovo.Click
        If txtTexto.Modified Then
            If MsgBox("Texto modificado. Deseja grava-lo ?", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                dlgSalvar.ShowDialog()
                If dlgSalvar.FileName <> "" Then
                    My.Computer.FileSystem.WriteAllText(dlgSalvar.FileName, txtTexto.Text, False)
                    txtTexto.Modified = False
                End If
            End If
        End If
        txtTexto.Clear()
        stsMensagem1.Text = "Nome do arquivo:"
    End Sub

    Private Sub opcAbrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcAbrir.Click, btnAbrir.Click
        If txtTexto.Modified Then
            If MsgBox("Texto modificado. Desejagrava-lo ?", MsgBoxStyle.YesNo, "Aviso") = MsgBoxResult.Yes Then
                dlgSalvar.ShowDialog()
                If dlgSalvar.FileName <> "" Then
                    My.Computer.FileSystem.WriteAllText(dlgSalvar.FileName, txtTexto.Text, False)
                End If
            End If
        End If
        txtTexto.Clear()
        dlgAbrir.ShowDialog()
        If dlgAbrir.FileName <> "" Then
            txtTexto.Text = My.Computer.FileSystem.ReadAllText(dlgAbrir.FileName)
            stsMensagem1.Text = "Nome do arquivo: " + dlgAbrir.FileName

        End If
        txtTexto.Modified = False
    End Sub

    Private Sub opcSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcSalvar.Click, btnGravar.Click
        dlgAbrir.ShowDialog()
        If dlgSalvar.FileName <> "" Then
            My.Computer.FileSystem.WriteAllText(dlgSalvar.FileName, txtTexto.Text, False)
            stsMensagem1.Text = "Nome do arquivo: " + dlgSalvar.FileName
            txtTexto.Modified = False

        End If
    End Sub

    Private Sub opcImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opcImprimir.Click
        If dlgImprimir.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Impressao.DocumentName = "Meu documento"
            Impressao.Print()
        End If
    End Sub

    Private Sub Impressao_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles Impressao.PrintPage
        Dim strTexto As String
        Dim objImpressao As Graphics = e.Graphics
        strTexto = txtTexto.Text
        objImpressao.DrawString(strTexto, txtTexto.Font, Brushes.Black, 50, 50)
    End Sub
End Class
