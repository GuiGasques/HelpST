Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class NovoUsuario
	Public dtb As New DataTable
	Public adp As New SqlDataAdapter
	Public dtbUser As New DataTable
	Public dtbCargo As New DataTable
	Dim data As String
	Dim Codigo As Integer
	Private Sub NovoUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		MetroLabel6.Text = variaveis.Login
		AtualizaGrid()
		gridUser.DataSource = dtbUser

		cbCargo.Items.Add("Professor")
		cbCargo.Items.Add("Coordenador")
		cbCargo.Items.Add("Secretaria")
		cbCargo.Items.Add("Manutençao")
	End Sub
	Private Sub AtualizaGrid()
		variaveis.con.Open()
		Dim adp As New SqlDataAdapter("Select * from Usuario", variaveis.con)
		dtbUser.Clear()
		adp.Fill(dtbUser)
		variaveis.con.Close()
	End Sub
	Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
		data = MetroDateTime1.Value.Year & "/" & MetroDateTime1.Value.Month & "/" & MetroDateTime1.Value.Day
		Select Case cbCargo.Text
			Case "Professor"
				variaveis.con.Open()
                Dim cmd As New SqlCommand("INSERT INTO Usuario (Login_User,Usuario,Senha,Hierarquia,Matricula,Cargo) values ( '" & txtLogin.Text & "','" & txtNome.Text & "', '" & txtSenha.Text & "', 'Usuario', '" & data & "' ,'Professor')", variaveis.con)
				cmd.ExecuteNonQuery()
				variaveis.con.Close()
				AtualizaGrid()
			Case "Coordenador"
				variaveis.con.Open()
                Dim cmd As New SqlCommand("INSERT INTO Usuario  (Login_User,Usuario,Senha,Hierarquia,Matricula,Cargo) values ( '" & txtLogin.Text & "','" & txtNome.Text & "', '" & txtSenha.Text & "', 'Usuario', '" & data & "' ,'Coordenador')", variaveis.con)
				cmd.ExecuteNonQuery()
				variaveis.con.Close()
				AtualizaGrid()
			Case "Secetaria"
				variaveis.con.Open()
                Dim cmd As New SqlCommand("INSERT INTO Usuario  (Login_User,Usuario,Senha,Hierarquia,Matricula,Cargo) values ( '" & txtLogin.Text & "','" & txtNome.Text & "', '" & txtSenha.Text & "', 'Usuario', '" & data & "' ,'Secretaria')", variaveis.con)
				cmd.ExecuteNonQuery()
				variaveis.con.Close()
				AtualizaGrid()
			Case "Manutençao"
				variaveis.con.Open()
                Dim cmd As New SqlCommand("INSERT INTO Usuario  (Login_User,Usuario,Senha,Hierarquia,Matricula,Cargo) values ( '" & txtLogin.Text & "','" & txtNome.Text & "', '" & txtSenha.Text & "', 'Administrador', '" & data & "' ,'Manutençao')", variaveis.con)
				cmd.ExecuteNonQuery()
				variaveis.con.Close()
				AtualizaGrid()
		End Select
	End Sub

	Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
		data = MetroDateTime1.Value.Year & "/" & MetroDateTime1.Value.Month & "/" & MetroDateTime1.Value.Day
		Select Case cbCargo.Text
			Case "Professor"
				variaveis.con.Open()
                Dim cmd1 As New SqlCommand("UPDATE Usuario set Login_User = '" & txtLogin.Text & "',Usuario = '" & txtNome.Text & "',Senha = '" & txtSenha.Text & "',Hierarquia = 'Usuario',Matricula = '" & data & "',Cargo = 'Professsor' where Cod_User = " & Codigo & " ", variaveis.con)
				cmd1.ExecuteNonQuery()
				variaveis.con.Close()
				AtualizaGrid()
			Case "Coordenador"
				variaveis.con.Open()
                Dim cmd1 As New SqlCommand("UPDATE Usuario set Login_User = '" & txtLogin.Text & "',Usuario = '" & txtNome.Text & "',Senha = '" & txtSenha.Text & "',Hierarquia = 'Usuario',Matricula = '" & data & "',Cargo = 'Coordenador' where Cod_User = " & Codigo & " ", variaveis.con)
				cmd1.ExecuteNonQuery()
				variaveis.con.Close()
				AtualizaGrid()
			Case "Secretaria"
				variaveis.con.Open()
                Dim cmd1 As New SqlCommand("UPDATE Usuario set Login_User = '" & txtLogin.Text & "',Usuario = '" & txtNome.Text & "',Senha = '" & txtSenha.Text & "',Hierarquia = 'Usuario',Matricula = '" & data & "',Cargo = 'Secretaria' where Cod_User = " & Codigo & " ", variaveis.con)
				cmd1.ExecuteNonQuery()
				variaveis.con.Close()
				AtualizaGrid()
			Case "Manutençao"
				variaveis.con.Open()
                Dim cmd1 As New SqlCommand("UPDATE Usuario set Login_User = '" & txtLogin.Text & "',Usuario = '" & txtNome.Text & "',Senha = '" & txtSenha.Text & "',Hierarquia = 'Administrador',Matricula = '" & data & "',Cargo = 'Manutençao' where Cod_User = " & Codigo & " ", variaveis.con)
				cmd1.ExecuteNonQuery()
				variaveis.con.Close()
				AtualizaGrid()
		End Select
	End Sub

	Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
		dtbUser.Rows.RemoveAt(gridUser.CurrentRow.Index)
		variaveis.con.Open()
		Dim cmd2 As New SqlCommand(" Delete from Usuario where  Cod_User = '" & Codigo & "'", variaveis.con)
		cmd2.ExecuteNonQuery()
		variaveis.con.Close()
		AtualizaGrid()
	End Sub

	Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
		MenuAdmin.Show()
		Me.Close()
	End Sub

	Private Sub gridUser_Click(sender As Object, e As EventArgs) Handles gridUser.Click
		Codigo = dtbUser.Rows(gridUser.CurrentRow.Index).Item("Cod_User")
		txtLogin.Text = dtbUser.Rows(gridUser.CurrentRow.Index).Item("Login_User")
        txtNome.Text = dtbUser.Rows(gridUser.CurrentRow.Index).Item("Usuario")
		txtSenha.Text = dtbUser.Rows(gridUser.CurrentRow.Index).Item("Senha")
		MetroDateTime1.Text = dtbUser.Rows(gridUser.CurrentRow.Index).Item("Matricula")
	End Sub
End Class