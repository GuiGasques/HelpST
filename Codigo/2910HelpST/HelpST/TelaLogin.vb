Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataReader
Public Class TelaLogin
	Public dtb As New DataTable
	Public adp As New SqlDataAdapter
	Public Cod_user As Integer
	Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click


		variaveis.Login = "Lais"
		variaveis.senha = "4321"

		'If txtLogin.Text = "LOGIN" And txtSenha.Text = "SENHA" Then
		'    variaveis.Login = "Paulo"
		'    variaveis.senha = "1234"
		'Else
		variaveis.Login = txtLogin.Text
		variaveis.senha = txtSenha.Text
		'End If



		variaveis.con.Open()

        Dim sql As String
        sql = "select login_user, Hierarquia,Cod_User from usuario where login_user = @user and senha = @senha"
        Dim cmd As New SqlCommand(sql, variaveis.con)

        cmd.Parameters.AddWithValue("@user", variaveis.Login)
        cmd.Parameters.AddWithValue("@senha", variaveis.senha)
        adp.SelectCommand = cmd
        dtb.Clear()
        adp.Fill(dtb)

        If (dtb.Rows.Count > 0) Then
            MsgBox("Sucesso ao Logar")

            Select Case dtb.Rows(0).Item(1).ToString()
                Case "Administrador"
                    MenuAdmin.Show()
                    variaveis.isAdmin = True
                Case "Usuario"
                    MenuUser.Show()
                    variaveis.isAdmin = False
            End Select
            Cod_user = dtb.Rows(0).Item(2).ToString()
            Me.Hide()
            variaveis.con.Close()
        Else
            MsgBox("Login ou senha incorretas")
            Me.Show()
        End If
        variaveis.con.Close()
	End Sub

	Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
		Me.Close()
	End Sub
	Private Sub txtLogin_Enter(sender As Object, e As EventArgs) Handles txtLogin.Enter
		If (txtLogin.Text = "LOGIN") Then
			txtLogin.Text = ""
			txtLogin.ForeColor = Color.Black
		End If
	End Sub

	Private Sub txtLogin_Leave(sender As Object, e As EventArgs) Handles txtLogin.Leave
		If (txtLogin.Text = "") Then
			txtLogin.Text = "LOGIN"
			txtLogin.ForeColor = Color.Black
		End If
	End Sub

	Private Sub txtSenha_Enter(sender As Object, e As EventArgs) Handles txtSenha.Enter
		If (txtSenha.Text = "SENHA") Then
			txtSenha.Text = ""
			txtSenha.ForeColor = Color.Black
			txtSenha.UseSystemPasswordChar = True
		End If
	End Sub

	Private Sub txtSenha_Leave(sender As Object, e As EventArgs) Handles txtSenha.Leave
		If (txtSenha.Text = "") Then
			txtSenha.Text = "SENHA"
			txtSenha.ForeColor = Color.Black
			txtSenha.UseSystemPasswordChar = False
		End If
	End Sub

	Private Sub MetroPanel1_Paint(sender As Object, e As PaintEventArgs) Handles MetroPanel1.Paint

	End Sub

	Private Sub TelaLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
