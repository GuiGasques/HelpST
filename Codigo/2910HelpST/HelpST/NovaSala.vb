Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class NovaSala
	Private dtbSalas As New DataTable
	Dim data As String
	Dim Codigo As String
	'data = MetroDateTime1.Value.Year & "/" & MetroDateTime1.Value.Month & "/" & MetroDateTime1.Value.Day
	Private Sub NovaSala_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroLabel4.Text = variaveis.Login
		gridSalas.DataSource = dtbSalas
		AtualizaGrid()
		cbComponentes.Items.Add("1")
		cbComponentes.Items.Add("2")
		cbComponentes.Items.Add("3")
		cbComponentes.Items.Add("4")
		cbComponentes.Items.Add("5")
		cbComponentes.Items.Add("6")
		cbComponentes.Items.Add("7")
		cbComponentes.Items.Add("8")
		cbComponentes.Items.Add("9")
		cbComponentes.Items.Add("10")
		cbComponentes.Items.Add("11")
		cbComponentes.Items.Add("12")
		cbComponentes.Items.Add("13")
		cbComponentes.Items.Add("14")
		cbComponentes.Items.Add("15")
		cbComponentes.Items.Add("16")
		cbComponentes.Items.Add("17")
		cbComponentes.Items.Add("18")
		cbComponentes.Items.Add("19")
		cbComponentes.Items.Add("20")
	End Sub



	Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
		data = MetroDateTime1.Value.Year & "/" & MetroDateTime1.Value.Month & "/" & MetroDateTime1.Value.Day
		variaveis.con.Open()
        Dim cmd As New SqlCommand("InsertNovaSala", variaveis.con)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@NomeAmbiente", txtNomeAmbiente.Text)
        cmd.Parameters.AddWithValue("@Data", data)
        cmd.Parameters.Add("@CodigoSala", SqlDbType.Int)
        cmd.Parameters("@CodigoSala").Direction = ParameterDirection.Output
        cmd.ExecuteNonQuery()
        Dim codAmbiente = Integer.Parse(cmd.Parameters("@CodigoSala").Value.ToString())
        For x As Integer = 1 To cbComponentes.Text Step +1
            Dim cmdx As New SqlCommand("INSERT INTO Componente (Pc,Cod_Ambiente) values ('PC" & x & "'," & codAmbiente & ")", variaveis.con)
            cmdx.ExecuteNonQuery()
        Next
        variaveis.con.Close()
        AtualizaGrid()
    End Sub
	Private Sub AtualizaGrid()
		variaveis.con.Open()
        Dim adp As New SqlDataAdapter("Select Cod_Ambiente,Sala,Data_de_Criacao from Ambiente ", variaveis.con)
		dtbSalas.Clear()
		adp.Fill(dtbSalas)
		variaveis.con.Close()
	End Sub
	Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
		MenuAdmin.Show()
		Me.Close()
	End Sub

	Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
		data = MetroDateTime1.Value.Year & "/" & MetroDateTime1.Value.Month & "/" & MetroDateTime1.Value.Day
		variaveis.con.Open()
        Dim cmd1 As New SqlCommand("UPDATE Ambiente set Sala = '" & txtNomeAmbiente.Text & "', Data_de_Criacao = '" & data & "' where Cod_ambiente = " & Codigo, variaveis.con)
		cmd1.ExecuteNonQuery()
		variaveis.con.Close()
		AtualizaGrid()
	End Sub

	Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
		dtbAmbiente.Rows.RemoveAt(gridSalas.CurrentRow.Index)
		variaveis.con.Open()
		Dim cmd2 As New SqlCommand(" Delete from Ambiente where Cod_Ambiente =" & Codigo, variaveis.con)
		cmd2.ExecuteNonQuery()
		variaveis.con.Close()
		AtualizaGrid()
	End Sub

	Private Sub gridSalas_Click(sender As Object, e As EventArgs) Handles gridSalas.Click
		Codigo = dtbSalas.Rows(gridSalas.CurrentRow.Index).Item("Cod_Ambiente").ToString()
		txtNomeAmbiente.Text = dtbSalas.Rows(gridSalas.CurrentRow.Index).Item(1)
		data = dtbSalas.Rows(gridSalas.CurrentRow.Index).Item("Data_de_Criacao")
	End Sub

End Class