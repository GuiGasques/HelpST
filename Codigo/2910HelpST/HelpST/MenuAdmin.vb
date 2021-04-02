Public Class MenuAdmin
	Private Sub MenuAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label2.Text = variaveis.Login

    End Sub

	Private Sub btnNovoChamado_Click(sender As Object, e As EventArgs) Handles btnNovoChamado.Click
		NovoChamado.Show()
	End Sub

	Private Sub btnChamados_Click(sender As Object, e As EventArgs) Handles btnChamados.Click
		Chamados.Show()
	End Sub

	Private Sub btnNovoUsuario_Click(sender As Object, e As EventArgs) Handles btnNovoUsuario.Click
		NovoUsuario.Show()
	End Sub

	Private Sub btnMeusChamados_Click(sender As Object, e As EventArgs) Handles btnMeusChamados.Click
		MeusChamados.Show()
	End Sub

	Private Sub btnNovaSala_Click(sender As Object, e As EventArgs) Handles btnNovaSala.Click
		NovaSala.Show()
	End Sub

	Private Sub btnChamadosExcluidos_Click(sender As Object, e As EventArgs) Handles btnChamadosExcluidos.Click
		ChamadosExcluidos.Show()
	End Sub

	Private Sub btnChamadosFinalizados_Click(sender As Object, e As EventArgs) Handles btnChamadosFinalizados.Click
		ChamadosFinalizados.Show()
	End Sub

    Private Sub MenuAdmin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSair.Click

        Logoff.Show()

    End Sub
End Class