Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class ResponderChamado
    Public Cod_Chamado As Integer

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        variaveis.con.Open()
        Dim cmd As New SqlCommand("INSERT INTO Manutencao (Comentar,Cod_Chamado) values ('" & txtResposta.Text & "'," & Cod_Chamado & ")", variaveis.con)
        cmd.ExecuteNonQuery()
        Dim cmd1 As New SqlCommand("UPDATE Chamados set Andamento = 'Finalizado ',Nivel = '" & cbNiveis.Text & "' where Cod_Chamado = '" & Cod_Chamado & "'", variaveis.con)

        cmd1.ExecuteNonQuery()
        variaveis.con.Close()

        MsgBox("Chamado Finalizado. Resposta Emitida")
		Me.Hide()
		Chamados.AtualizaGrid()

	End Sub

	Private Sub ResponderChamado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbNiveis.Items.Add("Facil")
        cbNiveis.Items.Add("Facil/Medio")
        cbNiveis.Items.Add("Medio")
        cbNiveis.Items.Add("Medio/Dificil")
        cbNiveis.Items.Add("Dificil")
        cbNiveis.Items.Insert(0, "-- Selecione --")
        cbNiveis.SelectedIndex = 0

        txtResposta.Text = ""

    End Sub
End Class