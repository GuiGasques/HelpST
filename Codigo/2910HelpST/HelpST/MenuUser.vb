Public Class MenuUser
	Private Sub btnChamados_Click(sender As Object, e As EventArgs) Handles btnChamados.Click
		Chamados.Show()
	End Sub

	Private Sub btnNovoChamado_Click(sender As Object, e As EventArgs) Handles btnNovoChamado.Click
		NovoChamado.Show()
	End Sub

	Private Sub btnMeusChamados_Click(sender As Object, e As EventArgs) Handles btnMeusChamados.Click
		MeusChamados.Show()

	End Sub
	Private Sub btnChamadosResolvidos_Click(sender As Object, e As EventArgs) Handles btnChamadosResolvidos.Click
		ChamadosFinalizados.Show()

	End Sub

	Private Sub btnChamadosExcluidos_Click(sender As Object, e As EventArgs) Handles btnChamadosExcluidos.Click
		ChamadosExcluidos.Show()
	End Sub

	Private Sub MenuUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Label2.Text = variaveis.Login
	End Sub

    Private Sub MenuUser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit() 'METODO PARA FECHAR APLICACAO
    End Sub

    Private Sub btnSair_Click(sender As Object, e As EventArgs) Handles btnSair.Click
        Logoff.Show()


    End Sub
End Class